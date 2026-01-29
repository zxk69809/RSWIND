Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	Public Partial Class db_guru_admin_form
		Inherits Form

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.db_guru_admin_form_Load
			Me.m_ShowAddedOnly = False
			Me.InitializeComponent()
		End Sub

		Friend Overridable Property btnClose As Button
			Get
				Return Me._btnClose
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnClose_Click
				If Me._btnClose IsNot Nothing Then
					RemoveHandler Me._btnClose.Click, value2
				End If
				Me._btnClose = value
				If Me._btnClose IsNot Nothing Then
					AddHandler Me._btnClose.Click, value2
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

		Public Overridable Property ulgTemplates As UltraGrid
			Get
				Return Me._ulgTemplates
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As UltraGrid)
				Dim value2 As InitializeRowEventHandler = AddressOf Me.ulgTemplates_InitializeRow
				Dim value3 As InitializeLayoutEventHandler = AddressOf Me.ulgTemplates_InitializeLayout
				If Me._ulgTemplates IsNot Nothing Then
					RemoveHandler Me._ulgTemplates.InitializeRow, value2
					RemoveHandler Me._ulgTemplates.InitializeLayout, value3
				End If
				Me._ulgTemplates = value
				If Me._ulgTemplates IsNot Nothing Then
					AddHandler Me._ulgTemplates.InitializeRow, value2
					AddHandler Me._ulgTemplates.InitializeLayout, value3
				End If
			End Set
		End Property

		Friend Overridable Property lblDBFile As Label
			Get
				Return Me._lblDBFile
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblDBFile = value
			End Set
		End Property

		Public Property ShowAddedOnly As Boolean
			Get
				Return Me.m_ShowAddedOnly
			End Get
			Set(value As Boolean)
				Me.m_ShowAddedOnly = value
			End Set
		End Property

		Private Sub db_guru_admin_form_Load(sender As Object, e As EventArgs)
			Try
				Me.myFile = Nothing
				Me.myFile = New cGuruFileData()
				Util.BusyCursor()
				GURU_DB.LoadALLGuruFiledata(False)
				RSWIN_DESC.bGuruFileDataLoaded = True
				Util.BusyCursor()
				Me.LoadTemplatedata()
				Util.BusyCursor()
				Me.ulgTemplates.Show()
				Util.UnbusyCursor()
			Catch ex As Exception
			End Try
		End Sub

		Private Sub ulgTemplates_InitializeLayout(eventSender As Object, eventArgs As InitializeLayoutEventArgs)
			Try
				Dim layout As UltraGridLayout = eventArgs.Layout
				layout.TabNavigation = TabNavigation.NextCell
				Dim ultraGridBand As UltraGridBand = layout.Bands(0)
				Dim ultraGridColumn As UltraGridColumn = ultraGridBand.Columns("FileName")
				ultraGridColumn.Header.Caption = "File Key"
				ultraGridColumn.Tag = ""
				ultraGridColumn.Width = 190
				ultraGridColumn.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Disallow
				Dim ultraGridColumn2 As UltraGridColumn = ultraGridBand.Columns("IrotEntered")
				ultraGridColumn2.Header.Caption = "Irot Entered"
				ultraGridColumn2.Tag = ""
				ultraGridColumn2.Width = 85
				ultraGridColumn2.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
				Dim ultraGridColumn3 As UltraGridColumn = ultraGridBand.Columns("CalcPlungerSize")
				ultraGridColumn3.Header.Caption = "Calc Plungr Size"
				ultraGridColumn3.Tag = ""
				ultraGridColumn3.Width = 110
				ultraGridColumn3.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
				Dim ultraGridColumn4 As UltraGridColumn = ultraGridBand.Columns("gbCalcPumpIntakePressure")
				ultraGridColumn4.Header.Caption = "Calc PIP"
				ultraGridColumn4.Tag = ""
				ultraGridColumn4.Width = 85
				ultraGridColumn4.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
				Dim ultraGridColumn5 As UltraGridColumn = ultraGridBand.Columns("CasingPressure")
				ultraGridColumn5.Header.Caption = "Casing Prss"
				ultraGridColumn5.Tag = ""
				ultraGridColumn5.Width = 95
				ultraGridColumn5.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
				Dim ultraGridColumn6 As UltraGridColumn = ultraGridBand.Columns("CompressibilityIndex")
				ultraGridColumn6.Header.Caption = "Comprss Indx"
				ultraGridColumn6.Tag = ""
				ultraGridColumn6.Width = 95
				ultraGridColumn6.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
				Dim ultraGridColumn7 As UltraGridColumn = ultraGridBand.Columns("ElectricityCost")
				ultraGridColumn7.Header.Caption = "Elec Cost"
				ultraGridColumn7.Tag = ""
				ultraGridColumn7.Width = 85
				ultraGridColumn7.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
				Dim ultraGridColumn8 As UltraGridColumn = ultraGridBand.Columns("FluidDamping")
				ultraGridColumn8.Header.Caption = "Fluid Damp"
				ultraGridColumn8.Tag = ""
				ultraGridColumn8.Width = 85
				ultraGridColumn8.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
				Dim ultraGridColumn9 As UltraGridColumn = ultraGridBand.Columns("FluidLevel")
				ultraGridColumn9.Header.Caption = "Fluid Level"
				ultraGridColumn9.Tag = ""
				ultraGridColumn9.Width = 85
				ultraGridColumn9.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
				Dim ultraGridColumn10 As UltraGridColumn = ultraGridBand.Columns("gbIncludeBuoyancy")
				ultraGridColumn10.Header.Caption = "Include Buoyancy"
				ultraGridColumn10.Tag = ""
				ultraGridColumn10.Width = 115
				ultraGridColumn10.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
				Dim ultraGridColumn11 As UltraGridColumn = ultraGridBand.Columns("IncludeFluidInertia")
				ultraGridColumn11.Header.Caption = "Include FL Inertia"
				ultraGridColumn11.Tag = ""
				ultraGridColumn11.Width = 120
				ultraGridColumn11.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
				Dim ultraGridColumn12 As UltraGridColumn = ultraGridBand.Columns("Iart")
				ultraGridColumn12.Header.Caption = "Iart"
				ultraGridColumn12.Tag = ""
				ultraGridColumn12.Width = 85
				ultraGridColumn12.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
				Dim ultraGridColumn13 As UltraGridColumn = ultraGridBand.Columns("Irot")
				ultraGridColumn13.Header.Caption = "Irot"
				ultraGridColumn13.Tag = ""
				ultraGridColumn13.Width = 85
				ultraGridColumn13.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
				Dim ultraGridColumn14 As UltraGridColumn = ultraGridBand.Columns("UnknownM")
				ultraGridColumn14.Header.Caption = "Unknown M"
				ultraGridColumn14.Tag = ""
				ultraGridColumn14.Width = 100
				ultraGridColumn14.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
				Dim ultraGridColumn15 As UltraGridColumn = ultraGridBand.Columns("M_Existing")
				ultraGridColumn15.Header.Caption = "Existing M"
				ultraGridColumn15.Tag = ""
				ultraGridColumn15.Width = 100
				ultraGridColumn15.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
				Dim ultraGridColumn16 As UltraGridColumn = ultraGridBand.Columns("CBEffect")
				ultraGridColumn16.Header.Caption = "CB Effect"
				ultraGridColumn16.Tag = ""
				ultraGridColumn16.Width = 95
				ultraGridColumn16.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
				Dim ultraGridColumn17 As UltraGridColumn = ultraGridBand.Columns("CBAngle")
				ultraGridColumn17.Header.Caption = "CB Angle"
				ultraGridColumn17.Tag = ""
				ultraGridColumn17.Width = 95
				ultraGridColumn17.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
				Dim ultraGridColumn18 As UltraGridColumn = ultraGridBand.Columns("CalcMotorSize")
				ultraGridColumn18.Header.Caption = "Calc Motor Size"
				ultraGridColumn18.Tag = ""
				ultraGridColumn18.Width = 95
				ultraGridColumn18.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
				Dim ultraGridColumn19 As UltraGridColumn = ultraGridBand.Columns("IncludeMotorSPV")
				ultraGridColumn19.Header.Caption = "Incl. Motor SPV"
				ultraGridColumn19.Tag = ""
				ultraGridColumn19.Width = 95
				ultraGridColumn19.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
				Dim ultraGridColumn20 As UltraGridColumn = ultraGridBand.Columns("MotorSPV")
				ultraGridColumn20.Header.Caption = "Motor SPV"
				ultraGridColumn20.Tag = ""
				ultraGridColumn20.Width = 95
				ultraGridColumn20.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
				Dim ultraGridColumn21 As UltraGridColumn = ultraGridBand.Columns("OilAPI")
				ultraGridColumn21.Header.Caption = "Oil API"
				ultraGridColumn21.Tag = ""
				ultraGridColumn21.Width = 95
				ultraGridColumn21.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
				Dim ultraGridColumn22 As UltraGridColumn = ultraGridBand.Columns("PlungerSize")
				ultraGridColumn22.Header.Caption = "Plungr Size"
				ultraGridColumn22.Tag = ""
				ultraGridColumn22.Width = 100
				ultraGridColumn22.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
				Dim ultraGridColumn23 As UltraGridColumn = ultraGridBand.Columns("PowerMeterType")
				ultraGridColumn23.Header.Caption = "Meter Type"
				ultraGridColumn23.Tag = ""
				ultraGridColumn23.Width = 95
				ultraGridColumn23.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
				Dim ultraGridColumn24 As UltraGridColumn = ultraGridBand.Columns("PumpDepth")
				ultraGridColumn24.Header.Caption = "Pump Depth"
				ultraGridColumn24.Tag = ""
				ultraGridColumn24.Width = 95
				ultraGridColumn24.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
				Dim ultraGridColumn25 As UltraGridColumn = ultraGridBand.Columns("PumpEfficiency")
				ultraGridColumn25.Header.Caption = "Pump Eff."
				ultraGridColumn25.Tag = ""
				ultraGridColumn25.Width = 95
				ultraGridColumn25.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
				Dim ultraGridColumn26 As UltraGridColumn = ultraGridBand.Columns("PumpFillage")
				ultraGridColumn26.Header.Caption = "Pump Fill."
				ultraGridColumn26.Tag = ""
				ultraGridColumn26.Width = 95
				ultraGridColumn26.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
				Dim ultraGridColumn27 As UltraGridColumn = ultraGridBand.Columns("PumpFriction")
				ultraGridColumn27.Header.Caption = "Pump Fric."
				ultraGridColumn27.Tag = ""
				ultraGridColumn27.Width = 95
				ultraGridColumn27.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
				Dim ultraGridColumn28 As UltraGridColumn = ultraGridBand.Columns("PumpIntakePressure")
				ultraGridColumn28.Header.Caption = "PIP"
				ultraGridColumn28.Tag = ""
				ultraGridColumn28.Width = 70
				ultraGridColumn28.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
				Dim ultraGridColumn29 As UltraGridColumn = ultraGridBand.Columns("PumpLoadAdj")
				ultraGridColumn29.Header.Caption = "Pump Load Adj."
				ultraGridColumn29.Tag = ""
				ultraGridColumn29.Width = 110
				ultraGridColumn29.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
				Dim ultraGridColumn30 As UltraGridColumn = ultraGridBand.Columns("PumpType")
				ultraGridColumn30.Header.Caption = "Pump Type"
				ultraGridColumn30.Tag = ""
				ultraGridColumn30.Width = 95
				ultraGridColumn30.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
				Dim ultraGridColumn31 As UltraGridColumn = ultraGridBand.Columns("SPM")
				ultraGridColumn31.Header.Caption = "SPM"
				ultraGridColumn31.Tag = ""
				ultraGridColumn31.Width = 95
				ultraGridColumn31.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
				Dim ultraGridColumn32 As UltraGridColumn = ultraGridBand.Columns("CalcFriction")
				ultraGridColumn32.Header.Caption = "Calc Fric."
				ultraGridColumn32.Tag = ""
				ultraGridColumn32.Width = 95
				ultraGridColumn32.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
				Dim ultraGridColumn33 As UltraGridColumn = ultraGridBand.Columns("DownstrokeFriction")
				ultraGridColumn33.Header.Caption = "D'Stroke Fric."
				ultraGridColumn33.Tag = ""
				ultraGridColumn33.Width = 100
				ultraGridColumn33.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
				Dim ultraGridColumn34 As UltraGridColumn = ultraGridBand.Columns("UpstrokeFriction")
				ultraGridColumn34.Header.Caption = "U'Stroke Fric."
				ultraGridColumn34.Tag = ""
				ultraGridColumn34.Width = 100
				ultraGridColumn34.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
				Dim ultraGridColumn35 As UltraGridColumn = ultraGridBand.Columns("XTimes")
				ultraGridColumn35.Header.Caption = "XTimes"
				ultraGridColumn35.Tag = ""
				ultraGridColumn35.Width = 100
				ultraGridColumn35.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
				Dim ultraGridColumn36 As UltraGridColumn = ultraGridBand.Columns("Runtime")
				ultraGridColumn36.Header.Caption = "Run time"
				ultraGridColumn36.Tag = ""
				ultraGridColumn36.Width = 85
				ultraGridColumn36.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
				Dim ultraGridColumn37 As UltraGridColumn = ultraGridBand.Columns("StuffingBoxFriction")
				ultraGridColumn37.Header.Caption = "Stuff Box Fric."
				ultraGridColumn37.Tag = ""
				ultraGridColumn37.Width = 100
				ultraGridColumn37.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
				Dim ultraGridColumn38 As UltraGridColumn = ultraGridBand.Columns("TargetBFPD")
				ultraGridColumn38.Header.Caption = "Target BFPD"
				ultraGridColumn38.Tag = ""
				ultraGridColumn38.Width = 100
				ultraGridColumn38.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
				Dim ultraGridColumn39 As UltraGridColumn = ultraGridBand.Columns("TubingAnchorDepth")
				ultraGridColumn39.Header.Caption = "Tubing Anchor Depth"
				ultraGridColumn39.Tag = ""
				ultraGridColumn39.Width = 100
				ultraGridColumn39.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
				Dim ultraGridColumn40 As UltraGridColumn = ultraGridBand.Columns("TubingAnchored")
				ultraGridColumn40.Header.Caption = "Tubing Anchored"
				ultraGridColumn40.Tag = ""
				ultraGridColumn40.Width = 100
				ultraGridColumn40.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
				Dim ultraGridColumn41 As UltraGridColumn = ultraGridBand.Columns("TubingID")
				ultraGridColumn41.Header.Caption = "Tubing ID"
				ultraGridColumn41.Tag = ""
				ultraGridColumn41.Width = 95
				ultraGridColumn41.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
				Dim ultraGridColumn42 As UltraGridColumn = ultraGridBand.Columns("TubingOD")
				ultraGridColumn42.Header.Caption = "Tubing OD"
				ultraGridColumn42.Tag = ""
				ultraGridColumn42.Width = 95
				ultraGridColumn42.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
				Dim ultraGridColumn43 As UltraGridColumn = ultraGridBand.Columns("TubingPressure")
				ultraGridColumn43.Header.Caption = "Tubing Prss"
				ultraGridColumn43.Tag = ""
				ultraGridColumn43.Width = 95
				ultraGridColumn43.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
				Dim ultraGridColumn44 As UltraGridColumn = ultraGridBand.Columns("WaterCut")
				ultraGridColumn44.Header.Caption = "Water Cut"
				ultraGridColumn44.Tag = ""
				ultraGridColumn44.Width = 95
				ultraGridColumn44.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
				Dim ultraGridColumn45 As UltraGridColumn = ultraGridBand.Columns("WaterSPGR")
				ultraGridColumn45.Header.Caption = "Water SPGR"
				ultraGridColumn45.Tag = ""
				ultraGridColumn45.Width = 95
				ultraGridColumn45.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
				Dim ultraGridColumn46 As UltraGridColumn = ultraGridBand.Columns("giRodDesignStyle")
				ultraGridColumn46.Header.Caption = "Rod Design"
				ultraGridColumn46.Tag = ""
				ultraGridColumn46.Width = 95
				ultraGridColumn46.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
				Dim ultraGridColumn47 As UltraGridColumn = ultraGridBand.Columns("RSFGIncludeSteel")
				ultraGridColumn47.Header.Caption = "Include Steel"
				ultraGridColumn47.Tag = ""
				ultraGridColumn47.Width = 95
				ultraGridColumn47.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
				Dim ultraGridColumn48 As UltraGridColumn = ultraGridBand.Columns("RSGrade")
				ultraGridColumn48.Header.Caption = "RS Grade"
				ultraGridColumn48.Tag = ""
				ultraGridColumn48.Width = 95
				ultraGridColumn48.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
				Dim ultraGridColumn49 As UltraGridColumn = ultraGridBand.Columns("RSMaxSize")
				ultraGridColumn49.Header.Caption = "RS Max Size"
				ultraGridColumn49.Tag = ""
				ultraGridColumn49.Width = 95
				ultraGridColumn49.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
				Dim ultraGridColumn50 As UltraGridColumn = ultraGridBand.Columns("RSMinSize")
				ultraGridColumn50.Header.Caption = "RS Min Size"
				ultraGridColumn50.Tag = ""
				ultraGridColumn50.Width = 95
				ultraGridColumn50.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
				Dim ultraGridColumn51 As UltraGridColumn = ultraGridBand.Columns("RSFricCoef")
				ultraGridColumn51.Header.Caption = "RS Fric Coef"
				ultraGridColumn51.Tag = ""
				ultraGridColumn51.Width = 100
				ultraGridColumn51.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
				Dim ultraGridColumn52 As UltraGridColumn = ultraGridBand.Columns("RSIncludeSB")
				ultraGridColumn52.Header.Caption = "Include SB"
				ultraGridColumn52.Tag = ""
				ultraGridColumn52.Width = 85
				ultraGridColumn52.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
				Dim ultraGridColumn53 As UltraGridColumn = ultraGridBand.Columns("SinkerBar_Grade")
				ultraGridColumn53.Header.Caption = "SB Grade"
				ultraGridColumn53.Tag = ""
				ultraGridColumn53.Width = 85
				ultraGridColumn53.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
				Dim ultraGridColumn54 As UltraGridColumn = ultraGridBand.Columns("SinkerBar_length")
				ultraGridColumn54.Header.Caption = "SB length"
				ultraGridColumn54.Tag = ""
				ultraGridColumn54.Width = 85
				ultraGridColumn54.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
				Dim ultraGridColumn55 As UltraGridColumn = ultraGridBand.Columns("SinkerBar_Diameter")
				ultraGridColumn55.Header.Caption = "SB Diam"
				ultraGridColumn55.Tag = ""
				ultraGridColumn55.Width = 85
				ultraGridColumn55.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
				Dim ultraGridColumn56 As UltraGridColumn = ultraGridBand.Columns("RSFGGrade")
				ultraGridColumn56.Header.Caption = "RS FG Grade"
				ultraGridColumn56.Tag = ""
				ultraGridColumn56.Width = 100
				ultraGridColumn56.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
				Dim ultraGridColumn57 As UltraGridColumn = ultraGridBand.Columns("RSExtraCost")
				ultraGridColumn57.Header.Caption = "RS Extra Cost"
				ultraGridColumn57.Tag = ""
				ultraGridColumn57.Width = 110
				ultraGridColumn57.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
				Dim ultraGridColumn58 As UltraGridColumn = ultraGridBand.Columns("ServiceFactor")
				ultraGridColumn58.Header.Caption = "Service Factor"
				ultraGridColumn58.Tag = ""
				ultraGridColumn58.Width = 110
				ultraGridColumn58.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
				Dim ultraGridColumn59 As UltraGridColumn = ultraGridBand.Columns("PU_CrankRotation")
				ultraGridColumn59.Header.Caption = "Crank Rotation"
				ultraGridColumn59.Tag = ""
				ultraGridColumn59.Width = 110
				ultraGridColumn59.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
				Dim ultraGridColumn60 As UltraGridColumn = ultraGridBand.Columns("PU_CrankHole")
				ultraGridColumn60.Header.Caption = "Crank Hole"
				ultraGridColumn60.Tag = ""
				ultraGridColumn60.Width = 85
				ultraGridColumn60.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
				Dim ultraGridColumn61 As UltraGridColumn = ultraGridBand.Columns("Unbalance")
				ultraGridColumn61.Header.Caption = "Unbalance"
				ultraGridColumn61.Tag = ""
				ultraGridColumn61.Width = 90
				ultraGridColumn61.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
				Dim ultraGridColumn62 As UltraGridColumn = ultraGridBand.Columns("Unit")
				ultraGridColumn62.Header.Caption = "Unit"
				ultraGridColumn62.Tag = ""
				ultraGridColumn62.Width = 40
				ultraGridColumn62.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
				Dim ultraGridColumn63 As UltraGridColumn = ultraGridBand.Columns("ID")
				ultraGridColumn63.Header.Caption = "ID"
				ultraGridColumn63.Tag = ""
				ultraGridColumn63.Width = 40
				ultraGridColumn63.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
				Dim ultraGridColumn64 As UltraGridColumn = ultraGridBand.Columns("DateAdded")
				ultraGridColumn64.Header.Caption = "Date Added"
				ultraGridColumn64.Tag = ""
				ultraGridColumn64.Width = 80
				ultraGridColumn64.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
				Dim ultraGridColumn65 As UltraGridColumn = ultraGridBand.Columns("Original")
				ultraGridColumn65.Header.Caption = "Original"
				ultraGridColumn65.Tag = ""
				ultraGridColumn65.Width = 80
				ultraGridColumn65.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
				Dim ultraGrid As UltraGrid = Me.ulgTemplates
				Try
					ultraGrid.ActiveRow = ultraGrid.GetRow(ChildRow.First)
				Catch ex As Exception
				End Try
				Dim ultraGridBand2 As UltraGridBand = ultraGrid.DisplayLayout.Bands(0)
				ultraGridBand2.SortedColumns.Add(ultraGridBand2.Columns("FileName"), False)
				Dim override As UltraGridOverride = ultraGrid.DisplayLayout.Override
				override.AllowColMoving = AllowColMoving.NotAllowed
				override.AllowColSizing = AllowColSizing.None
				override.AllowColSwapping = AllowColSwapping.NotAllowed
				override.BorderStyleCell = UIElementBorderStyle.InsetSoft
				override.BorderStyleRow = UIElementBorderStyle.RaisedSoft
				override.RowSelectors = DefaultableBoolean.[False]
				override.RowSizing = RowSizing.Fixed
				override.ActiveRowAppearance.BorderColor = SystemColors.Highlight
				override.ActiveRowAppearance.BorderColor3DBase = SystemColors.Highlight
				ultraGrid = Nothing
			Catch ex2 As Exception
			End Try
		End Sub

		Private Sub ulgTemplates_InitializeRow(eventSender As Object, eventArgs As InitializeRowEventArgs)
			Try
				Dim row As UltraGridRow = eventArgs.Row
				Dim ultraGridCell As UltraGridCell = row.Cells("FileName")
				ultraGridCell.Appearance.BackColor = SystemColors.Control
				Dim ultraGridCell2 As UltraGridCell = row.Cells("IrotEntered")
				ultraGridCell2.Appearance.BackColor = SystemColors.Control
				Dim ultraGridCell3 As UltraGridCell = row.Cells("CalcPlungerSize")
				ultraGridCell3.Appearance.BackColor = SystemColors.Control
				Dim ultraGridCell4 As UltraGridCell = row.Cells("gbCalcPumpIntakePressure")
				ultraGridCell4.Appearance.BackColor = SystemColors.Control
				Dim ultraGridCell5 As UltraGridCell = row.Cells("CasingPressure")
				ultraGridCell5.Appearance.BackColor = SystemColors.Control
				Dim ultraGridCell6 As UltraGridCell = row.Cells("CompressibilityIndex")
				ultraGridCell6.Appearance.BackColor = SystemColors.Control
				Dim ultraGridCell7 As UltraGridCell = row.Cells("ElectricityCost")
				ultraGridCell7.Appearance.BackColor = SystemColors.Control
				Dim ultraGridCell8 As UltraGridCell = row.Cells("FluidDamping")
				ultraGridCell8.Appearance.BackColor = SystemColors.Control
				Dim ultraGridCell9 As UltraGridCell = row.Cells("FluidLevel")
				ultraGridCell9.Appearance.BackColor = SystemColors.Control
				Dim ultraGridCell10 As UltraGridCell = row.Cells("gbIncludeBuoyancy")
				ultraGridCell10.Appearance.BackColor = SystemColors.Control
				Dim ultraGridCell11 As UltraGridCell = row.Cells("IncludeFluidInertia")
				ultraGridCell11.Appearance.BackColor = SystemColors.Control
				Dim ultraGridCell12 As UltraGridCell = row.Cells("Iart")
				ultraGridCell12.Appearance.BackColor = SystemColors.Control
				Dim ultraGridCell13 As UltraGridCell = row.Cells("Irot")
				ultraGridCell13.Appearance.BackColor = SystemColors.Control
				Dim ultraGridCell14 As UltraGridCell = row.Cells("UnknownM")
				ultraGridCell14.Appearance.BackColor = SystemColors.Control
				Dim ultraGridCell15 As UltraGridCell = row.Cells("M_Existing")
				ultraGridCell15.Appearance.BackColor = SystemColors.Control
				Dim ultraGridCell16 As UltraGridCell = row.Cells("CBEffect")
				ultraGridCell16.Appearance.BackColor = SystemColors.Control
				Dim ultraGridCell17 As UltraGridCell = row.Cells("CBAngle")
				ultraGridCell17.Appearance.BackColor = SystemColors.Control
				Dim ultraGridCell18 As UltraGridCell = row.Cells("CalcMotorSize")
				ultraGridCell18.Appearance.BackColor = SystemColors.Control
				Dim ultraGridCell19 As UltraGridCell = row.Cells("IncludeMotorSPV")
				ultraGridCell19.Appearance.BackColor = SystemColors.Control
				Dim ultraGridCell20 As UltraGridCell = row.Cells("MotorSPV")
				ultraGridCell20.Appearance.BackColor = SystemColors.Control
				Dim ultraGridCell21 As UltraGridCell = row.Cells("OilAPI")
				ultraGridCell21.Appearance.BackColor = SystemColors.Control
				Dim ultraGridCell22 As UltraGridCell = row.Cells("PlungerSize")
				ultraGridCell22.Appearance.BackColor = SystemColors.Control
				Dim ultraGridCell23 As UltraGridCell = row.Cells("PowerMeterType")
				ultraGridCell23.Appearance.BackColor = SystemColors.Control
				Dim ultraGridCell24 As UltraGridCell = row.Cells("PumpDepth")
				ultraGridCell24.Appearance.BackColor = SystemColors.Control
				Dim ultraGridCell25 As UltraGridCell = row.Cells("PumpEfficiency")
				ultraGridCell25.Appearance.BackColor = SystemColors.Control
				Dim ultraGridCell26 As UltraGridCell = row.Cells("PumpFillage")
				ultraGridCell26.Appearance.BackColor = SystemColors.Control
				Dim ultraGridCell27 As UltraGridCell = row.Cells("PumpFriction")
				ultraGridCell27.Appearance.BackColor = SystemColors.Control
				Dim ultraGridCell28 As UltraGridCell = row.Cells("PumpIntakePressure")
				ultraGridCell28.Appearance.BackColor = SystemColors.Control
				Dim ultraGridCell29 As UltraGridCell = row.Cells("PumpLoadAdj")
				ultraGridCell29.Appearance.BackColor = SystemColors.Control
				Dim ultraGridCell30 As UltraGridCell = row.Cells("PumpType")
				ultraGridCell30.Appearance.BackColor = SystemColors.Control
				Dim ultraGridCell31 As UltraGridCell = row.Cells("SPM")
				ultraGridCell31.Appearance.BackColor = SystemColors.Control
				Dim ultraGridCell32 As UltraGridCell = row.Cells("CalcFriction")
				ultraGridCell32.Appearance.BackColor = SystemColors.Control
				Dim ultraGridCell33 As UltraGridCell = row.Cells("DownstrokeFriction")
				ultraGridCell33.Appearance.BackColor = SystemColors.Control
				Dim ultraGridCell34 As UltraGridCell = row.Cells("UpstrokeFriction")
				ultraGridCell34.Appearance.BackColor = SystemColors.Control
				Dim ultraGridCell35 As UltraGridCell = row.Cells("XTimes")
				ultraGridCell35.Appearance.BackColor = SystemColors.Control
				Dim ultraGridCell36 As UltraGridCell = row.Cells("Runtime")
				ultraGridCell36.Appearance.BackColor = SystemColors.Control
				Dim ultraGridCell37 As UltraGridCell = row.Cells("StuffingBoxFriction")
				ultraGridCell37.Appearance.BackColor = SystemColors.Control
				Dim ultraGridCell38 As UltraGridCell = row.Cells("TargetBFPD")
				ultraGridCell38.Appearance.BackColor = SystemColors.Control
				Dim ultraGridCell39 As UltraGridCell = row.Cells("TubingAnchorDepth")
				ultraGridCell39.Appearance.BackColor = SystemColors.Control
				Dim ultraGridCell40 As UltraGridCell = row.Cells("TubingAnchored")
				ultraGridCell40.Appearance.BackColor = SystemColors.Control
				Dim ultraGridCell41 As UltraGridCell = row.Cells("TubingID")
				ultraGridCell41.Appearance.BackColor = SystemColors.Control
				Dim ultraGridCell42 As UltraGridCell = row.Cells("TubingOD")
				ultraGridCell42.Appearance.BackColor = SystemColors.Control
				Dim ultraGridCell43 As UltraGridCell = row.Cells("TubingPressure")
				ultraGridCell43.Appearance.BackColor = SystemColors.Control
				Dim ultraGridCell44 As UltraGridCell = row.Cells("WaterCut")
				ultraGridCell44.Appearance.BackColor = SystemColors.Control
				Dim ultraGridCell45 As UltraGridCell = row.Cells("WaterSPGR")
				ultraGridCell45.Appearance.BackColor = SystemColors.Control
				Dim ultraGridCell46 As UltraGridCell = row.Cells("giRodDesignStyle")
				ultraGridCell46.Appearance.BackColor = SystemColors.Control
				Dim ultraGridCell47 As UltraGridCell = row.Cells("RSFGIncludeSteel")
				ultraGridCell47.Appearance.BackColor = SystemColors.Control
				Dim ultraGridCell48 As UltraGridCell = row.Cells("RSGrade")
				ultraGridCell48.Appearance.BackColor = SystemColors.Control
				Dim ultraGridCell49 As UltraGridCell = row.Cells("RSMaxSize")
				ultraGridCell49.Appearance.BackColor = SystemColors.Control
				Dim ultraGridCell50 As UltraGridCell = row.Cells("RSMinSize")
				ultraGridCell50.Appearance.BackColor = SystemColors.Control
				Dim ultraGridCell51 As UltraGridCell = row.Cells("RSFricCoef")
				ultraGridCell51.Appearance.BackColor = SystemColors.Control
				Dim ultraGridCell52 As UltraGridCell = row.Cells("RSIncludeSB")
				ultraGridCell52.Appearance.BackColor = SystemColors.Control
				Dim ultraGridCell53 As UltraGridCell = row.Cells("SinkerBar_Grade")
				ultraGridCell53.Appearance.BackColor = SystemColors.Control
				Dim ultraGridCell54 As UltraGridCell = row.Cells("SinkerBar_length")
				ultraGridCell54.Appearance.BackColor = SystemColors.Control
				Dim ultraGridCell55 As UltraGridCell = row.Cells("SinkerBar_Diameter")
				ultraGridCell55.Appearance.BackColor = SystemColors.Control
				Dim ultraGridCell56 As UltraGridCell = row.Cells("RSFGGrade")
				ultraGridCell56.Appearance.BackColor = SystemColors.Control
				Dim ultraGridCell57 As UltraGridCell = row.Cells("RSExtraCost")
				ultraGridCell57.Appearance.BackColor = SystemColors.Control
				Dim ultraGridCell58 As UltraGridCell = row.Cells("ServiceFactor")
				ultraGridCell58.Appearance.BackColor = SystemColors.Control
				Dim ultraGridCell59 As UltraGridCell = row.Cells("PU_CrankRotation")
				ultraGridCell59.Appearance.BackColor = SystemColors.Control
				Dim ultraGridCell60 As UltraGridCell = row.Cells("PU_CrankHole")
				ultraGridCell60.Appearance.BackColor = SystemColors.Control
				Dim ultraGridCell61 As UltraGridCell = row.Cells("Unbalance")
				ultraGridCell61.Appearance.BackColor = SystemColors.Control
				Dim ultraGridCell62 As UltraGridCell = row.Cells("Unit")
				ultraGridCell62.Appearance.BackColor = SystemColors.Control
				Dim ultraGridCell63 As UltraGridCell = row.Cells("ID")
				ultraGridCell63.Appearance.BackColor = SystemColors.Control
				Dim ultraGridCell64 As UltraGridCell = row.Cells("DateAdded")
				ultraGridCell64.Appearance.BackColor = SystemColors.Control
				Dim ultraGridCell65 As UltraGridCell = row.Cells("Original")
				ultraGridCell65.Appearance.BackColor = SystemColors.Control
			Catch ex As Exception
			End Try
		End Sub

		Public Sub InitTemplateDataset()
			Try
				Me.mdsTemplatedata = Nothing
				Me.mdsTemplatedata = New DataSet("templatedata")
				Me.dtTemplate = New DataTable("templatedata")
				Dim dataColumn As DataColumn = New DataColumn("FileName", GetType(String))
				dataColumn.Unique = False
				dataColumn.AllowDBNull = False
				Me.dtTemplate.Columns.Add(dataColumn)
				Dim dataColumn2 As DataColumn = New DataColumn("Unit", GetType(String))
				dataColumn2.AllowDBNull = True
				Me.dtTemplate.Columns.Add(dataColumn2)
				Dim dataColumn3 As DataColumn = New DataColumn("ID", GetType(String))
				dataColumn3.AllowDBNull = True
				Me.dtTemplate.Columns.Add(dataColumn3)
				Dim dataColumn4 As DataColumn = New DataColumn("PumpDepth", GetType(Single))
				dataColumn4.AllowDBNull = True
				Me.dtTemplate.Columns.Add(dataColumn4)
				Dim dataColumn5 As DataColumn = New DataColumn("TargetBFPD", GetType(Single))
				dataColumn5.AllowDBNull = True
				Me.dtTemplate.Columns.Add(dataColumn5)
				Dim dataColumn6 As DataColumn = New DataColumn("DateAdded", GetType(DateTime))
				dataColumn6.AllowDBNull = True
				Me.dtTemplate.Columns.Add(dataColumn6)
				Dim dataColumn7 As DataColumn = New DataColumn("Original", GetType(Short))
				dataColumn7.AllowDBNull = True
				Me.dtTemplate.Columns.Add(dataColumn7)
				Dim dataColumn8 As DataColumn = New DataColumn("giRodDesignStyle", GetType(String))
				dataColumn8.AllowDBNull = True
				Me.dtTemplate.Columns.Add(dataColumn8)
				Dim dataColumn9 As DataColumn = New DataColumn("IrotEntered", GetType(Boolean))
				dataColumn9.AllowDBNull = True
				Me.dtTemplate.Columns.Add(dataColumn9)
				Dim dataColumn10 As DataColumn = New DataColumn("CalcPlungerSize", GetType(Boolean))
				dataColumn10.AllowDBNull = True
				Me.dtTemplate.Columns.Add(dataColumn10)
				Dim dataColumn11 As DataColumn = New DataColumn("gbCalcPumpIntakePressure", GetType(Boolean))
				dataColumn11.AllowDBNull = True
				Me.dtTemplate.Columns.Add(dataColumn11)
				Dim dataColumn12 As DataColumn = New DataColumn("CasingPressure", GetType(Single))
				dataColumn12.AllowDBNull = True
				Me.dtTemplate.Columns.Add(dataColumn12)
				Dim dataColumn13 As DataColumn = New DataColumn("CompressibilityIndex", GetType(Single))
				dataColumn13.AllowDBNull = True
				Me.dtTemplate.Columns.Add(dataColumn13)
				Dim dataColumn14 As DataColumn = New DataColumn("ElectricityCost", GetType(Single))
				dataColumn14.AllowDBNull = True
				Me.dtTemplate.Columns.Add(dataColumn14)
				Dim dataColumn15 As DataColumn = New DataColumn("FluidDamping", GetType(Single))
				dataColumn15.AllowDBNull = True
				Me.dtTemplate.Columns.Add(dataColumn15)
				Dim dataColumn16 As DataColumn = New DataColumn("FluidLevel", GetType(Single))
				dataColumn16.AllowDBNull = True
				Me.dtTemplate.Columns.Add(dataColumn16)
				Dim dataColumn17 As DataColumn = New DataColumn("gbIncludeBuoyancy", GetType(Boolean))
				dataColumn17.AllowDBNull = True
				Me.dtTemplate.Columns.Add(dataColumn17)
				Dim dataColumn18 As DataColumn = New DataColumn("IncludeFluidInertia", GetType(Boolean))
				dataColumn18.AllowDBNull = True
				Me.dtTemplate.Columns.Add(dataColumn18)
				Dim dataColumn19 As DataColumn = New DataColumn("Iart", GetType(Single))
				dataColumn19.AllowDBNull = True
				Me.dtTemplate.Columns.Add(dataColumn19)
				Dim dataColumn20 As DataColumn = New DataColumn("Irot", GetType(Boolean))
				dataColumn20.AllowDBNull = True
				Me.dtTemplate.Columns.Add(dataColumn20)
				Dim dataColumn21 As DataColumn = New DataColumn("UnknownM", GetType(Boolean))
				dataColumn21.AllowDBNull = True
				Me.dtTemplate.Columns.Add(dataColumn21)
				Dim dataColumn22 As DataColumn = New DataColumn("M_Existing", GetType(Single))
				dataColumn22.AllowDBNull = True
				Me.dtTemplate.Columns.Add(dataColumn22)
				Dim dataColumn23 As DataColumn = New DataColumn("CBEffect", GetType(Single))
				dataColumn23.AllowDBNull = True
				Me.dtTemplate.Columns.Add(dataColumn23)
				Dim dataColumn24 As DataColumn = New DataColumn("CBAngle", GetType(Single))
				dataColumn24.AllowDBNull = True
				Me.dtTemplate.Columns.Add(dataColumn24)
				Dim dataColumn25 As DataColumn = New DataColumn("CalcMotorSize", GetType(Boolean))
				dataColumn25.AllowDBNull = True
				Me.dtTemplate.Columns.Add(dataColumn25)
				Dim dataColumn26 As DataColumn = New DataColumn("IncludeMotorSPV", GetType(Boolean))
				dataColumn26.AllowDBNull = True
				Me.dtTemplate.Columns.Add(dataColumn26)
				Dim dataColumn27 As DataColumn = New DataColumn("MotorSPV", GetType(Single))
				dataColumn27.AllowDBNull = True
				Me.dtTemplate.Columns.Add(dataColumn27)
				Dim dataColumn28 As DataColumn = New DataColumn("OilAPI", GetType(Single))
				dataColumn28.AllowDBNull = True
				Me.dtTemplate.Columns.Add(dataColumn28)
				Dim dataColumn29 As DataColumn = New DataColumn("PlungerSize", GetType(Single))
				dataColumn29.AllowDBNull = True
				Me.dtTemplate.Columns.Add(dataColumn29)
				Dim dataColumn30 As DataColumn = New DataColumn("PowerMeterType", GetType(String))
				dataColumn30.AllowDBNull = True
				Me.dtTemplate.Columns.Add(dataColumn30)
				Dim dataColumn31 As DataColumn = New DataColumn("PumpEfficiency", GetType(Single))
				dataColumn31.AllowDBNull = True
				Me.dtTemplate.Columns.Add(dataColumn31)
				Dim dataColumn32 As DataColumn = New DataColumn("PumpFillage", GetType(Single))
				dataColumn32.AllowDBNull = True
				Me.dtTemplate.Columns.Add(dataColumn32)
				Dim dataColumn33 As DataColumn = New DataColumn("PumpFriction", GetType(Single))
				dataColumn33.AllowDBNull = True
				Me.dtTemplate.Columns.Add(dataColumn33)
				Dim dataColumn34 As DataColumn = New DataColumn("PumpIntakePressure", GetType(Single))
				dataColumn34.AllowDBNull = True
				Me.dtTemplate.Columns.Add(dataColumn34)
				Dim dataColumn35 As DataColumn = New DataColumn("PumpLoadAdj", GetType(Single))
				dataColumn35.AllowDBNull = True
				Me.dtTemplate.Columns.Add(dataColumn35)
				Dim dataColumn36 As DataColumn = New DataColumn("PumpType", GetType(String))
				dataColumn36.AllowDBNull = True
				Me.dtTemplate.Columns.Add(dataColumn36)
				Dim dataColumn37 As DataColumn = New DataColumn("SPM", GetType(Single))
				dataColumn37.AllowDBNull = True
				Me.dtTemplate.Columns.Add(dataColumn37)
				Dim dataColumn38 As DataColumn = New DataColumn("CalcFriction", GetType(Boolean))
				dataColumn38.AllowDBNull = True
				Me.dtTemplate.Columns.Add(dataColumn38)
				Dim dataColumn39 As DataColumn = New DataColumn("DownstrokeFriction", GetType(Single))
				dataColumn39.AllowDBNull = True
				Me.dtTemplate.Columns.Add(dataColumn39)
				Dim dataColumn40 As DataColumn = New DataColumn("UpstrokeFriction", GetType(Single))
				dataColumn40.AllowDBNull = True
				Me.dtTemplate.Columns.Add(dataColumn40)
				Dim dataColumn41 As DataColumn = New DataColumn("XTimes", GetType(Single))
				dataColumn41.AllowDBNull = True
				Me.dtTemplate.Columns.Add(dataColumn41)
				Dim dataColumn42 As DataColumn = New DataColumn("Runtime", GetType(Single))
				dataColumn42.AllowDBNull = True
				Me.dtTemplate.Columns.Add(dataColumn42)
				Dim dataColumn43 As DataColumn = New DataColumn("StuffingBoxFriction", GetType(Single))
				dataColumn43.AllowDBNull = True
				Me.dtTemplate.Columns.Add(dataColumn43)
				Dim dataColumn44 As DataColumn = New DataColumn("TubingAnchorDepth", GetType(Single))
				dataColumn44.AllowDBNull = True
				Me.dtTemplate.Columns.Add(dataColumn44)
				Dim dataColumn45 As DataColumn = New DataColumn("TubingAnchored", GetType(Boolean))
				dataColumn45.AllowDBNull = True
				Me.dtTemplate.Columns.Add(dataColumn45)
				Dim dataColumn46 As DataColumn = New DataColumn("TubingID", GetType(Single))
				dataColumn46.AllowDBNull = True
				Me.dtTemplate.Columns.Add(dataColumn46)
				Dim dataColumn47 As DataColumn = New DataColumn("TubingOD", GetType(Single))
				dataColumn47.AllowDBNull = True
				Me.dtTemplate.Columns.Add(dataColumn47)
				Dim dataColumn48 As DataColumn = New DataColumn("TubingPressure", GetType(Single))
				dataColumn48.AllowDBNull = True
				Me.dtTemplate.Columns.Add(dataColumn48)
				Dim dataColumn49 As DataColumn = New DataColumn("WaterCut", GetType(Single))
				dataColumn49.AllowDBNull = True
				Me.dtTemplate.Columns.Add(dataColumn49)
				Dim dataColumn50 As DataColumn = New DataColumn("WaterSPGR", GetType(Single))
				dataColumn50.AllowDBNull = True
				Me.dtTemplate.Columns.Add(dataColumn50)
				Dim dataColumn51 As DataColumn = New DataColumn("RSFGIncludeSteel", GetType(Boolean))
				dataColumn51.AllowDBNull = True
				Me.dtTemplate.Columns.Add(dataColumn51)
				Dim dataColumn52 As DataColumn = New DataColumn("RSGrade", GetType(Short))
				dataColumn52.AllowDBNull = True
				Me.dtTemplate.Columns.Add(dataColumn52)
				Dim dataColumn53 As DataColumn = New DataColumn("RSMaxSize", GetType(Single))
				dataColumn53.AllowDBNull = True
				Me.dtTemplate.Columns.Add(dataColumn53)
				Dim dataColumn54 As DataColumn = New DataColumn("RSMinSize", GetType(Single))
				dataColumn54.AllowDBNull = True
				Me.dtTemplate.Columns.Add(dataColumn54)
				Dim dataColumn55 As DataColumn = New DataColumn("RSFricCoef", GetType(Single))
				dataColumn55.AllowDBNull = True
				Me.dtTemplate.Columns.Add(dataColumn55)
				Dim dataColumn56 As DataColumn = New DataColumn("RSIncludeSB", GetType(Boolean))
				dataColumn56.AllowDBNull = True
				Me.dtTemplate.Columns.Add(dataColumn56)
				Dim dataColumn57 As DataColumn = New DataColumn("SinkerBar_Grade", GetType(Short))
				dataColumn57.AllowDBNull = True
				Me.dtTemplate.Columns.Add(dataColumn57)
				Dim dataColumn58 As DataColumn = New DataColumn("SinkerBar_length", GetType(Single))
				dataColumn58.AllowDBNull = True
				Me.dtTemplate.Columns.Add(dataColumn58)
				Dim dataColumn59 As DataColumn = New DataColumn("SinkerBar_Diameter", GetType(Single))
				dataColumn59.AllowDBNull = True
				Me.dtTemplate.Columns.Add(dataColumn59)
				Dim dataColumn60 As DataColumn = New DataColumn("RSFGGrade", GetType(Short))
				dataColumn60.AllowDBNull = True
				Me.dtTemplate.Columns.Add(dataColumn60)
				Dim dataColumn61 As DataColumn = New DataColumn("RSExtraCost", GetType(Single))
				dataColumn61.AllowDBNull = True
				Me.dtTemplate.Columns.Add(dataColumn61)
				Dim dataColumn62 As DataColumn = New DataColumn("ServiceFactor", GetType(Single))
				dataColumn62.AllowDBNull = True
				Me.dtTemplate.Columns.Add(dataColumn62)
				Dim dataColumn63 As DataColumn = New DataColumn("PU_CrankRotation", GetType(String))
				dataColumn63.AllowDBNull = True
				Me.dtTemplate.Columns.Add(dataColumn63)
				Dim dataColumn64 As DataColumn = New DataColumn("PU_CrankHole", GetType(Short))
				dataColumn64.AllowDBNull = True
				Me.dtTemplate.Columns.Add(dataColumn64)
				Dim dataColumn65 As DataColumn = New DataColumn("Unbalance", GetType(Single))
				dataColumn65.AllowDBNull = True
				Me.dtTemplate.Columns.Add(dataColumn65)
				Me.mdsTemplatedata.Tables.Add(Me.dtTemplate)
				Me.mdsTemplatedata.Tables(0).Clear()
			Catch ex As Exception
				MessageBox.Show("Error in InitTemplatedata: " + ex.Message)
			End Try
		End Sub

		Private Sub LoadTemplatedata()
			Try
				Dim sTemplateDBFileName As String = RSWIN_DESC.sTemplateDBFileName
				Dim guruDataBaseFileName As String = RSWIN_DESC.GuruDataBaseFileName
				FILEUTIL.LocateFile(sTemplateDBFileName, guruDataBaseFileName, 2S, True, False, False, False)
				RSWIN_DESC.GuruDataBaseFileName = guruDataBaseFileName
				Me.lblDBFile.Text = " Database file: " + RSWIN_DESC.GuruDataBaseFileName
				Me.mdsTemplatedata = Nothing
				Me.InitTemplateDataset()
				Me.LoadTemplatedataDataset()
				Dim ulgTemplates As UltraGrid = Me.ulgTemplates
				ulgTemplates.DataSource = Me.mdsTemplatedata
				ulgTemplates.Rows.Refresh(RefreshRow.FireInitializeRow, True)
				ulgTemplates.ActiveRow = ulgTemplates.GetRow(ChildRow.First)
				ulgTemplates.Visible = True
				Me.SetGridColors()
			Catch ex As Exception
				MessageBox.Show("Error in InitTemplatedata: " + ex.Message)
			End Try
		End Sub

		Private Sub LoadTemplatedataDataset()
			' The following expression was wrapped in a checked-statement
			Try
				Dim num As Integer = 1
				Dim iGuruFileCount As Integer = RSWIN_DESC.iGuruFileCount
				For i As Integer = num To iGuruFileCount
					Dim dataRow As DataRow = Me.mdsTemplatedata.Tables(0).NewRow()
					Dim guruFileDataStructure As RSWIN_DESC.GuruFileDataStructure = RSWIN_DESC.AllGuruFiles(i)
					dataRow("FileName") = guruFileDataStructure.FileName
					dataRow("Unit") = guruFileDataStructure.Unit
					dataRow("ID") = guruFileDataStructure.ID
					dataRow("PumpDepth") = guruFileDataStructure.PumpDepth
					dataRow("TargetBFPD") = guruFileDataStructure.TargetBFPD
					dataRow("DateAdded") = guruFileDataStructure.DateAdded
					dataRow("Original") = guruFileDataStructure.Original
					If guruFileDataStructure.giRodDesignStyle = 0S Then
						dataRow("giRodDesignStyle") = "Steel"
					ElseIf guruFileDataStructure.giRodDesignStyle = 1S Then
						dataRow("giRodDesignStyle") = "FGSteel"
					End If
					dataRow("IrotEntered") = guruFileDataStructure.IrotEntered
					dataRow("CalcPlungerSize") = guruFileDataStructure.CalcPlungerSize
					dataRow("gbCalcPumpIntakePressure") = guruFileDataStructure.gbCalcPumpIntakePressure
					dataRow("CasingPressure") = guruFileDataStructure.CasingPressure
					dataRow("CompressibilityIndex") = guruFileDataStructure.CompressibilityIndex
					dataRow("ElectricityCost") = guruFileDataStructure.ElectricityCost
					dataRow("FluidDamping") = guruFileDataStructure.FluidDamping
					dataRow("FluidLevel") = guruFileDataStructure.FluidLevel
					dataRow("gbIncludeBuoyancy") = guruFileDataStructure.gbIncludeBuoyancy
					dataRow("IncludeFluidInertia") = guruFileDataStructure.IncludeFluidInertia
					dataRow("Iart") = guruFileDataStructure.Iart
					dataRow("Irot") = guruFileDataStructure.Irot
					dataRow("UnknownM") = guruFileDataStructure.UnknownM
					dataRow("M_Existing") = guruFileDataStructure.M_Existing
					dataRow("CBEffect") = guruFileDataStructure.CBEffect
					dataRow("CBAngle") = guruFileDataStructure.CBAngle
					dataRow("CalcMotorSize") = guruFileDataStructure.CalcMotorSize
					dataRow("IncludeMotorSPV") = guruFileDataStructure.IncludeMotorSPV
					dataRow("MotorSPV") = guruFileDataStructure.MotorSPV
					dataRow("OilAPI") = guruFileDataStructure.OilAPI
					dataRow("PlungerSize") = guruFileDataStructure.PlungerSize
					If guruFileDataStructure.PowerMeterType = 1S Then
						dataRow("PowerMeterType") = "Detent"
					ElseIf guruFileDataStructure.PowerMeterType = 2S Then
						dataRow("PowerMeterType") = "NonDetent"
					End If
					dataRow("PumpEfficiency") = guruFileDataStructure.PumpEfficiency
					dataRow("PumpFillage") = guruFileDataStructure.PumpFillage
					dataRow("PumpFriction") = guruFileDataStructure.PumpFriction
					dataRow("PumpIntakePressure") = guruFileDataStructure.PumpIntakePressure
					dataRow("PumpLoadAdj") = guruFileDataStructure.PumpLoadAdj
					If guruFileDataStructure.PumpType = 1S Then
						dataRow("PumpType") = "INSERT"
					ElseIf guruFileDataStructure.PumpType = 2S Then
						dataRow("PumpType") = "TUBING"
					ElseIf guruFileDataStructure.PumpType = 3S Then
						dataRow("PumpType") = "LARGEBORE"
					End If
					dataRow("SPM") = guruFileDataStructure.SPM
					dataRow("CalcFriction") = guruFileDataStructure.CalcFriction
					dataRow("DownstrokeFriction") = guruFileDataStructure.DownstrokeFriction
					dataRow("UpstrokeFriction") = guruFileDataStructure.UpstrokeFriction
					dataRow("XTimes") = guruFileDataStructure.XTimes
					dataRow("Runtime") = guruFileDataStructure.Runtime
					dataRow("StuffingBoxFriction") = guruFileDataStructure.StuffingBoxFriction
					dataRow("TubingAnchorDepth") = guruFileDataStructure.TubingAnchorDepth
					dataRow("TubingAnchored") = guruFileDataStructure.TubingAnchored
					dataRow("TubingID") = guruFileDataStructure.TubingID
					dataRow("TubingOD") = guruFileDataStructure.TubingOD
					dataRow("TubingPressure") = guruFileDataStructure.TubingPressure
					dataRow("WaterCut") = guruFileDataStructure.WaterCut
					dataRow("WaterSPGR") = guruFileDataStructure.WaterSPGR
					If guruFileDataStructure.giRodDesignStyle = 0S Then
						dataRow("giRodDesignStyle") = "Steel"
					ElseIf guruFileDataStructure.giRodDesignStyle = 1S Then
						dataRow("giRodDesignStyle") = "FGSteel"
					End If
					dataRow("RSFGIncludeSteel") = guruFileDataStructure.RSFGIncludeSteel
					dataRow("RSGrade") = guruFileDataStructure.RSGrade
					dataRow("RSMaxSize") = guruFileDataStructure.RSMaxSize
					dataRow("RSMinSize") = guruFileDataStructure.RSMinSize
					dataRow("RSFricCoef") = guruFileDataStructure.RSFricCoef
					dataRow("RSIncludeSB") = guruFileDataStructure.RSIncludeSB
					dataRow("SinkerBar_Grade") = guruFileDataStructure.SinkerBar_Grade
					dataRow("SinkerBar_length") = guruFileDataStructure.SinkerBar_length
					dataRow("SinkerBar_Diameter") = guruFileDataStructure.SinkerBar_Diameter
					dataRow("RSFGGrade") = guruFileDataStructure.RSFGGrade
					dataRow("RSExtraCost") = guruFileDataStructure.RSExtraCost
					dataRow("ServiceFactor") = guruFileDataStructure.ServiceFactor
					If guruFileDataStructure.PU_CrankRotation = 1S Then
						dataRow("PU_CrankRotation") = "CW"
					ElseIf guruFileDataStructure.PU_CrankRotation = -1S Or RSWIN_DESC.rst.PU.CrankRotation = 0S Then
						dataRow("PU_CrankRotation") = "CCW"
					End If
					dataRow("PU_CrankHole") = guruFileDataStructure.PU_CrankHole
					dataRow("Unbalance") = guruFileDataStructure.Unbalance
					If Me.ShowAddedOnly Then
						If guruFileDataStructure.Original = 0S Then
							Me.mdsTemplatedata.Tables(0).Rows.Add(dataRow)
						End If
					Else
						Me.mdsTemplatedata.Tables(0).Rows.Add(dataRow)
					End If
					Debug.WriteLine(Me.mdsTemplatedata.Tables(0).Rows.Count)
				Next
			Catch ex As Exception
			End Try
		End Sub

		Private Sub btnClose_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		Private Sub SetGridColors()
			Dim key As String = "Original"
			Try
				Dim ultraGridRow As UltraGridRow = Me.ulgTemplates.GetRow(ChildRow.First)
				While ultraGridRow IsNot Nothing
					Debug.WriteLine(RuntimeHelpers.GetObjectValue(ultraGridRow.Cells(key).Value))
					Dim ultraGridRow2 As UltraGridRow = ultraGridRow
					If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(ultraGridRow2.Cells(key).Value, 1, False))) Then
						ultraGridRow2.Appearance.ForeColor = Color.Red
					End If
					If ultraGridRow.HasNextSibling() Then
						ultraGridRow = ultraGridRow.GetSibling(SiblingRow.[Next])
					Else
						ultraGridRow = Nothing
					End If
				End While
			Catch ex As Exception
			End Try
		End Sub

		<AccessedThroughProperty("btnClose")>
		Private _btnClose As Button

		<AccessedThroughProperty("GroupBox1")>
		Private _GroupBox1 As GroupBox

		<AccessedThroughProperty("ulgTemplates")>
		Private _ulgTemplates As UltraGrid

		<AccessedThroughProperty("lblDBFile")>
		Private _lblDBFile As Label

		Private Const csKEY_FileName As String = "FileName"

		Private Const csKEY_IrotEntered As String = "IrotEntered"

		Private Const csKEY_CalcPlungerSize As String = "CalcPlungerSize"

		Private Const csKEY_gbCalcPumpIntakePressure As String = "gbCalcPumpIntakePressure"

		Private Const csKEY_CasingPressure As String = "CasingPressure"

		Private Const csKEY_CompressibilityIndex As String = "CompressibilityIndex"

		Private Const csKEY_ElectricityCost As String = "ElectricityCost"

		Private Const csKEY_FluidDamping As String = "FluidDamping"

		Private Const csKEY_FluidLevel As String = "FluidLevel"

		Private Const csKEY_gbIncludeBuoyancy As String = "gbIncludeBuoyancy"

		Private Const csKEY_IncludeFluidInertia As String = "IncludeFluidInertia"

		Private Const csKEY_Iart As String = "Iart"

		Private Const csKEY_Irot As String = "Irot"

		Private Const csKEY_UnknownM As String = "UnknownM"

		Private Const csKEY_M_Existing As String = "M_Existing"

		Private Const csKEY_CBEffect As String = "CBEffect"

		Private Const csKEY_CBAngle As String = "CBAngle"

		Private Const csKEY_CalcMotorSize As String = "CalcMotorSize"

		Private Const csKEY_IncludeMotorSPV As String = "IncludeMotorSPV"

		Private Const csKEY_MotorSPV As String = "MotorSPV"

		Private Const csKEY_OilAPI As String = "OilAPI"

		Private Const csKEY_PlungerSize As String = "PlungerSize"

		Private Const csKEY_PowerMeterType As String = "PowerMeterType"

		Private Const csKEY_PumpDepth As String = "PumpDepth"

		Private Const csKEY_PumpEfficiency As String = "PumpEfficiency"

		Private Const csKEY_PumpFillage As String = "PumpFillage"

		Private Const csKEY_PumpFriction As String = "PumpFriction"

		Private Const csKEY_PumpIntakePressure As String = "PumpIntakePressure"

		Private Const csKEY_PumpLoadAdj As String = "PumpLoadAdj"

		Private Const csKEY_PumpType As String = "PumpType"

		Private Const csKEY_SPM As String = "SPM"

		Private Const csKEY_CalcFriction As String = "CalcFriction"

		Private Const csKEY_DownstrokeFriction As String = "DownstrokeFriction"

		Private Const csKEY_UpstrokeFriction As String = "UpstrokeFriction"

		Private Const csKEY_XTimes As String = "XTimes"

		Private Const csKEY_Runtime As String = "Runtime"

		Private Const csKEY_StuffingBoxFriction As String = "StuffingBoxFriction"

		Private Const csKEY_TargetBFPD As String = "TargetBFPD"

		Private Const csKEY_TubingAnchorDepth As String = "TubingAnchorDepth"

		Private Const csKEY_TubingAnchored As String = "TubingAnchored"

		Private Const csKEY_TubingID As String = "TubingID"

		Private Const csKEY_TubingOD As String = "TubingOD"

		Private Const csKEY_TubingPressure As String = "TubingPressure"

		Private Const csKEY_WaterCut As String = "WaterCut"

		Private Const csKEY_WaterSPGR As String = "WaterSPGR"

		Private Const csKEY_giRodDesignStyle As String = "giRodDesignStyle"

		Private Const csKEY_RSFGIncludeSteel As String = "RSFGIncludeSteel"

		Private Const csKEY_RSGrade As String = "RSGrade"

		Private Const csKEY_RSMaxSize As String = "RSMaxSize"

		Private Const csKEY_RSMinSize As String = "RSMinSize"

		Private Const csKEY_RSFricCoef As String = "RSFricCoef"

		Private Const csKEY_RSIncludeSB As String = "RSIncludeSB"

		Private Const csKEY_SinkerBar_Grade As String = "SinkerBar_Grade"

		Private Const csKEY_SinkerBar_length As String = "SinkerBar_length"

		Private Const csKEY_SinkerBar_Diameter As String = "SinkerBar_Diameter"

		Private Const csKEY_RSFGGrade As String = "RSFGGrade"

		Private Const csKEY_RSExtraCost As String = "RSExtraCost"

		Private Const csKEY_ServiceFactor As String = "ServiceFactor"

		Private Const csKEY_PU_CrankRotation As String = "PU_CrankRotation"

		Private Const csKEY_PU_CrankHole As String = "PU_CrankHole"

		Private Const csKEY_Unbalance As String = "Unbalance"

		Private Const csKEY_Unit As String = "Unit"

		Private Const csKEY_ID As String = "ID"

		Private Const csKEY_DateAdded As String = "DateAdded"

		Private Const csKEY_Original As String = "Original"

		Private bRetVal As Boolean

		Private strConn As String

		Private iRecsUpdate As Integer

		Private TableName As String

		Private strSelectCmd As String

		Private mdsTemplatedata As DataSet

		Private dtTemplate As DataTable

		Private myFile As cGuruFileData

		Private m_ShowAddedOnly As Boolean
	End Class
End Namespace
