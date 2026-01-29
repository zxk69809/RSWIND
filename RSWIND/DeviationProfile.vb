Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Data.OleDb
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Globalization
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports ChartFX.WinForms
Imports ChartFX.WinForms.Adornments
Imports DataDynamics.ActiveReports.DataSources
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinMaskedEdit
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.Compatibility.VB6
Imports Microsoft.VisualBasic.CompilerServices
Imports Steema.TeeChart
Imports Steema.TeeChart.Drawing
Imports Steema.TeeChart.Styles
Imports Steema.TeeChart.Tools
Imports ThetaStdInfo

Namespace RSWINV3
	Friend Partial Class DeviationProfile
		Inherits Form

		Public Sub New()
			AddHandler MyBase.Scroll, AddressOf Me.DeviationProfile_Scroll
			AddHandler MyBase.KeyPress, AddressOf Me.DeviationProfile_KeyPress
			AddHandler MyBase.DragDrop, AddressOf Me.DeviationProfile_DragDrop
			AddHandler MyBase.DragEnter, AddressOf Me.DeviationProfile_DragEnter
			AddHandler MyBase.FormClosed, AddressOf Me.DeviationProfile_FormClosed
			AddHandler MyBase.FormClosing, AddressOf Me.DeviationProfile_FormClosing
			AddHandler MyBase.LostFocus, AddressOf Me.DeviationProfile_LostFocus
			AddHandler MyBase.GotFocus, AddressOf Me.DeviationProfile_GotFocus
			AddHandler MyBase.Activated, AddressOf Me.DeviationProfile_Activated
			AddHandler MyBase.Load, AddressOf Me.DeviationProfile_Load
			AddHandler MyBase.Resize, AddressOf Me.DeviationProfile_Resize
			AddHandler MyBase.Closing, AddressOf Me.DeviationProfile_Closing
			AddHandler MyBase.KeyDown, AddressOf Me.DeviationProfile_KeyDown
			AddHandler MyBase.KeyUp, AddressOf Me.DeviationProfile_KeyUp
			AddHandler MyBase.Closed, AddressOf Me.DeviationProfile_Closed
			AddHandler MyBase.Leave, AddressOf Me.DeviationProfile_Leave
			AddHandler MyBase.MouseDoubleClick, AddressOf Me.DeviationProfile_MouseDoubleClick
			AddHandler MyBase.MouseDown, AddressOf Me.DeviationProfile_MouseDown
			AddHandler MyBase.MouseEnter, AddressOf Me.DeviationProfile_MouseEnter
			AddHandler MyBase.MouseMove, AddressOf Me.DeviationProfile_MouseMove
			AddHandler MyBase.MouseUp, AddressOf Me.DeviationProfile_MouseUp
			AddHandler MyBase.MouseWheel, AddressOf Me.DeviationProfile_MouseWheel
			AddHandler MyBase.Move, AddressOf Me.DeviationProfile_Move
			Me.bShowDoglegPlotTab = False
			Me.m_frmDevSettings = New frmDevSettings()
			Me.bAddQuestionAsked = False
			Me.m_bClosing = False
			Me.sARSRemoveThis = Util.AssignValueToConstant("DeviationProfile", "sARSRemoveThis", "Are you sure you want to remove this entry?")
			Me.sARSRemove = Util.AssignValueToConstant("DeviationProfile", "sARSRemove", "Are you sure you want to remove these entries?")
			Me.sDeleteRow = Util.AssignValueToConstant("DeviationProfile", "sDeleteRow", "Delete row")
			Me.sDeleteRows = Util.AssignValueToConstant("DeviationProfile", "sDeleteRows", "Delete rows")
			Me.sDYWFill = Util.AssignValueToConstant("DeviationProfile", "sDYWFill", "Impred requires the deviation survey to extend past the end of the rod string. Do you want RSW32 to fill in the missing entries?")
			Me.sMsg1 = Util.AssignValueToConstant("DeviationProfile", "sMsg1", "There are null depth values in previous row(s). Please enter data.")
			Me.sMsg2 = Util.AssignValueToConstant("DeviationProfile", "sMsg2", "Please enter Azimuth as a decimal number or in degrees and minutes (for example: 30 15). " & vbCrLf & "Azimuth may also be entered with directional information (for example: N30 15W or S30E.)")
			Me.sMsg3 = Util.AssignValueToConstant("DeviationProfile", "sMsg3", "Please enter INCLINATION as a decimal number or in degrees and minutes (for example: 30 15). ")
			Me.sRemoveALL = Util.AssignValueToConstant("DeviationProfile", "sRemoveALL", "Remove ALL entries from Deviation Survey?")
			Me.sARS = Util.AssignValueToConstant("DeviationProfile", "sARS", "Are you sure?")
			Me.sSurveyLoaded = Util.AssignValueToConstant("DeviationProfile", "sSurveyLoaded", "Survey loaded sucessfully.")
			Me.sSurveyNotLoaded = Util.AssignValueToConstant("DeviationProfile", "sSurveyNotLoaded", "Survey did not load sucessfully.")
			Me.sImportWizard = Util.AssignValueToConstant("DeviationProfile", "sImportWizard", "Import Wizard")
			Me.iShowDev = 2
			Me.tmp_PumpDepth = 0.0
			Me.m_bReplot = False
			Me.frmWizard = New frmWizard()
			Me.frmImportDialog = New frmImportDialog()
			Me.r_e = New DeviationProfile.rod_element_data_type(4000) {}
			Me.bAnswered = False
			Me.m_bTapers = New Boolean(10) {}
			Me.myKeyValueHT = New Hashtable()
			Me.TaperDepths = New Single(0) {}
			Me.$STATIC$tabInput_SelectedIndexChanged$20211C1241$PreviousTab$Init = New StaticLocalInitFlag()
			If DeviationProfile.m_vb6FormDefInstance Is Nothing Then
				If DeviationProfile.m_InitializingDefInstance Then
					DeviationProfile.m_vb6FormDefInstance = Me
				Else
					Try
						If Assembly.GetExecutingAssembly().EntryPoint.DeclaringType Is Me.[GetType]() Then
							DeviationProfile.m_vb6FormDefInstance = Me
						End If
					Catch ex As Exception
					End Try
				End If
			End If
			Me.InitializeComponent()
			Me.Text = "Deviation Profile Information"
		End Sub

		Public Overridable Property cmdAddSection As Button
			Get
				Return Me._cmdAddSection
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.cmdAddSection_Click
				If Me._cmdAddSection IsNot Nothing Then
					RemoveHandler Me._cmdAddSection.Click, value2
				End If
				Me._cmdAddSection = value
				If Me._cmdAddSection IsNot Nothing Then
					AddHandler Me._cmdAddSection.Click, value2
				End If
			End Set
		End Property

		Public Overridable Property cmdMoveSectionUp As Button
			Get
				Return Me._cmdMoveSectionUp
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.cmdMoveSectionUp_Click
				If Me._cmdMoveSectionUp IsNot Nothing Then
					RemoveHandler Me._cmdMoveSectionUp.Click, value2
				End If
				Me._cmdMoveSectionUp = value
				If Me._cmdMoveSectionUp IsNot Nothing Then
					AddHandler Me._cmdMoveSectionUp.Click, value2
				End If
			End Set
		End Property

		Public Overridable Property cmdMoveSectionDown As Button
			Get
				Return Me._cmdMoveSectionDown
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.cmdMoveSectionDown_Click
				If Me._cmdMoveSectionDown IsNot Nothing Then
					RemoveHandler Me._cmdMoveSectionDown.Click, value2
				End If
				Me._cmdMoveSectionDown = value
				If Me._cmdMoveSectionDown IsNot Nothing Then
					AddHandler Me._cmdMoveSectionDown.Click, value2
				End If
			End Set
		End Property

		Public Overridable Property cmdNumberOfEntries As Button
			Get
				Return Me._cmdNumberOfEntries
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.cmdNumberOfEntries_Click
				If Me._cmdNumberOfEntries IsNot Nothing Then
					RemoveHandler Me._cmdNumberOfEntries.Click, value2
				End If
				Me._cmdNumberOfEntries = value
				If Me._cmdNumberOfEntries IsNot Nothing Then
					AddHandler Me._cmdNumberOfEntries.Click, value2
				End If
			End Set
		End Property

		Public Overridable Property cmdPrint As Button
			Get
				Return Me._cmdPrint
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.cmdPrint_Click
				If Me._cmdPrint IsNot Nothing Then
					RemoveHandler Me._cmdPrint.Click, value2
				End If
				Me._cmdPrint = value
				If Me._cmdPrint IsNot Nothing Then
					AddHandler Me._cmdPrint.Click, value2
				End If
			End Set
		End Property

		Public Overridable Property _tabInput_TabPage0 As TabPage
			Get
				Return Me.__tabInput_TabPage0
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TabPage)
				Me.__tabInput_TabPage0 = value
			End Set
		End Property

		Public Overridable Property _tabInput_TabPage2 As TabPage
			Get
				Return Me.__tabInput_TabPage2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TabPage)
				Me.__tabInput_TabPage2 = value
			End Set
		End Property

		Public Overridable Property tabInput As TabControl
			Get
				Return Me._tabInput
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TabControl)
				Dim value2 As EventHandler = AddressOf Me.tabInput_SelectedIndexChanged
				If Me._tabInput IsNot Nothing Then
					RemoveHandler Me._tabInput.SelectedIndexChanged, value2
				End If
				Me._tabInput = value
				If Me._tabInput IsNot Nothing Then
					AddHandler Me._tabInput.SelectedIndexChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property picRemoveFocus As System.Windows.Forms.Panel
			Get
				Return Me._picRemoveFocus
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As System.Windows.Forms.Panel)
				Dim value2 As MouseEventHandler = AddressOf Me.picRemoveFocus_MouseDown
				If Me._picRemoveFocus IsNot Nothing Then
					RemoveHandler Me._picRemoveFocus.MouseDown, value2
				End If
				Me._picRemoveFocus = value
				If Me._picRemoveFocus IsNot Nothing Then
					AddHandler Me._picRemoveFocus.MouseDown, value2
				End If
			End Set
		End Property

		Public Overridable Property Label As LabelArray
			Get
				Return Me._Label
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As LabelArray)
				Dim obj As EventHandler = AddressOf Me.Label_DoubleClick
				Dim obj2 As EventHandler = AddressOf Me.Label_Click
				If Me._Label IsNot Nothing Then
					RemoveHandler Me._Label.DoubleClick, obj
					RemoveHandler Me._Label.Click, obj2
				End If
				Me._Label = value
				If Me._Label IsNot Nothing Then
					AddHandler Me._Label.DoubleClick, obj
					AddHandler Me._Label.Click, obj2
				End If
			End Set
		End Property

		Public Overridable Property fraPumpDrag As GroupBoxArray
			Get
				Return Me._fraPumpDrag
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBoxArray)
				Me._fraPumpDrag = value
			End Set
		End Property

		Public Overridable Property optPolishedRodDrag As RadioButtonArray
			Get
				Return Me._optPolishedRodDrag
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButtonArray)
				Me._optPolishedRodDrag = value
			End Set
		End Property

		Public Overridable Property optPumpDragDown As RadioButtonArray
			Get
				Return Me._optPumpDragDown
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButtonArray)
				Me._optPumpDragDown = value
			End Set
		End Property

		Public Overridable Property optPumpDragUp As RadioButtonArray
			Get
				Return Me._optPumpDragUp
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButtonArray)
				Me._optPumpDragUp = value
			End Set
		End Property

		Private Overridable Property m_frmDevSettings As frmDevSettings
			Get
				Return Me._m_frmDevSettings
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As frmDevSettings)
				Me._m_frmDevSettings = value
			End Set
		End Property

		Friend Overridable Property ImageList3 As ImageList
			Get
				Return Me._ImageList3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ImageList)
				Me._ImageList3 = value
			End Set
		End Property

		Public Overridable Property ulgDeviationProfile As UltraGrid
			Get
				Return Me._ulgDeviationProfile
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As UltraGrid)
				Dim value2 As CellEventHandler = AddressOf Me.ulgDeviationProfile_CellChange
				Dim value3 As MouseEventHandler = AddressOf Me.ulgDeviationProfile_MouseUp
				Dim value4 As EventHandler = AddressOf Me.ulgDeviationProfile_Click
				Dim value5 As BeforeCellUpdateEventHandler = AddressOf Me.ulgDeviationProfile_BeforeCellUpdate
				Dim value6 As KeyPressEventHandler = AddressOf Me.ulgDeviationProfile_KeyPress
				Dim value7 As BeforeRowsDeletedEventHandler = AddressOf Me.ulgDeviationProfile_BeforeRowsDeleted
				Dim value8 As InitializeLayoutEventHandler = AddressOf Me.ulgDeviationProfile_InitializeLayout
				Dim value9 As Infragistics.Win.UltraWinGrid.BeforeExitEditModeEventHandler = AddressOf Me.ulgDeviationProfile_BeforeExitEditMode
				Dim value10 As MouseEventHandler = AddressOf Me.ulgDeviationProfile_MouseDownEvent
				Dim value11 As KeyEventHandler = AddressOf Me.ulgDeviationProfile_KeyUpEvent
				Dim value12 As BeforeRowRegionScrollEventHandler = AddressOf Me.ulgDeviationProfile_BeforeRowRegionScroll
				Dim value13 As BeforeColRegionScrollEventHandler = AddressOf Me.ulgDeviationProfile_BeforeColRegionScroll
				Dim value14 As CancelEventHandler = AddressOf Me.ulgDeviationProfile_BeforeCellDeactivate
				Dim value15 As KeyEventHandler = AddressOf Me.ulgDeviationProfile_KeyDown
				Dim value16 As InitializeRowEventHandler = AddressOf Me.ulgDeviationProfile_InitializeRow
				Dim value17 As CancelEventHandler = AddressOf Me.ulgDeviationProfile_BeforeEnterEditMode
				Dim value18 As RowEventHandler = AddressOf Me.ulgDeviationProfile_AfterRowUpdate
				Dim value19 As EventHandler = AddressOf Me.ulgDeviationProfile_AfterRowsDeleted
				Dim value20 As RowEventHandler = AddressOf Me.ulgDeviationProfile_AfterRowInsert
				Dim value21 As EventHandler = AddressOf Me.ulgDeviationProfile_AfterRowActivate
				Dim value22 As CellEventHandler = AddressOf Me.ulgDeviationProfile_AfterCellUpdate
				Dim value23 As EventHandler = AddressOf Me.ulgDeviationProfile_AfterCellActivate
				If Me._ulgDeviationProfile IsNot Nothing Then
					RemoveHandler Me._ulgDeviationProfile.CellChange, value2
					RemoveHandler Me._ulgDeviationProfile.MouseUp, value3
					RemoveHandler Me._ulgDeviationProfile.Click, value4
					RemoveHandler Me._ulgDeviationProfile.BeforeCellUpdate, value5
					RemoveHandler Me._ulgDeviationProfile.KeyPress, value6
					RemoveHandler Me._ulgDeviationProfile.BeforeRowsDeleted, value7
					RemoveHandler Me._ulgDeviationProfile.InitializeLayout, value8
					RemoveHandler Me._ulgDeviationProfile.BeforeExitEditMode, value9
					RemoveHandler Me._ulgDeviationProfile.MouseDown, value10
					RemoveHandler Me._ulgDeviationProfile.KeyUp, value11
					RemoveHandler Me._ulgDeviationProfile.BeforeRowRegionScroll, value12
					RemoveHandler Me._ulgDeviationProfile.BeforeColRegionScroll, value13
					RemoveHandler Me._ulgDeviationProfile.BeforeCellDeactivate, value14
					RemoveHandler Me._ulgDeviationProfile.KeyDown, value15
					RemoveHandler Me._ulgDeviationProfile.InitializeRow, value16
					RemoveHandler Me._ulgDeviationProfile.BeforeEnterEditMode, value17
					RemoveHandler Me._ulgDeviationProfile.AfterRowUpdate, value18
					RemoveHandler Me._ulgDeviationProfile.AfterRowsDeleted, value19
					RemoveHandler Me._ulgDeviationProfile.AfterRowInsert, value20
					RemoveHandler Me._ulgDeviationProfile.AfterRowActivate, value21
					RemoveHandler Me._ulgDeviationProfile.AfterCellUpdate, value22
					RemoveHandler Me._ulgDeviationProfile.AfterCellActivate, value23
				End If
				Me._ulgDeviationProfile = value
				If Me._ulgDeviationProfile IsNot Nothing Then
					AddHandler Me._ulgDeviationProfile.CellChange, value2
					AddHandler Me._ulgDeviationProfile.MouseUp, value3
					AddHandler Me._ulgDeviationProfile.Click, value4
					AddHandler Me._ulgDeviationProfile.BeforeCellUpdate, value5
					AddHandler Me._ulgDeviationProfile.KeyPress, value6
					AddHandler Me._ulgDeviationProfile.BeforeRowsDeleted, value7
					AddHandler Me._ulgDeviationProfile.InitializeLayout, value8
					AddHandler Me._ulgDeviationProfile.BeforeExitEditMode, value9
					AddHandler Me._ulgDeviationProfile.MouseDown, value10
					AddHandler Me._ulgDeviationProfile.KeyUp, value11
					AddHandler Me._ulgDeviationProfile.BeforeRowRegionScroll, value12
					AddHandler Me._ulgDeviationProfile.BeforeColRegionScroll, value13
					AddHandler Me._ulgDeviationProfile.BeforeCellDeactivate, value14
					AddHandler Me._ulgDeviationProfile.KeyDown, value15
					AddHandler Me._ulgDeviationProfile.InitializeRow, value16
					AddHandler Me._ulgDeviationProfile.BeforeEnterEditMode, value17
					AddHandler Me._ulgDeviationProfile.AfterRowUpdate, value18
					AddHandler Me._ulgDeviationProfile.AfterRowsDeleted, value19
					AddHandler Me._ulgDeviationProfile.AfterRowInsert, value20
					AddHandler Me._ulgDeviationProfile.AfterRowActivate, value21
					AddHandler Me._ulgDeviationProfile.AfterCellUpdate, value22
					AddHandler Me._ulgDeviationProfile.AfterCellActivate, value23
				End If
			End Set
		End Property

		Friend Overridable Property tabDirection As TabControl
			Get
				Return Me._tabDirection
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TabControl)
				Me._tabDirection = value
			End Set
		End Property

		Friend Overridable Property NE As TabPage
			Get
				Return Me._NE
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TabPage)
				Me._NE = value
			End Set
		End Property

		Friend Overridable Property NW As TabPage
			Get
				Return Me._NW
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TabPage)
				Me._NW = value
			End Set
		End Property

		Friend Overridable Property SE As TabPage
			Get
				Return Me._SE
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TabPage)
				Me._SE = value
			End Set
		End Property

		Friend Overridable Property SW As TabPage
			Get
				Return Me._SW
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TabPage)
				Me._SW = value
			End Set
		End Property

		Public Overridable Property txtInclination As TextBox
			Get
				Return Me._txtInclination
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtInclination_TextChanged
				Dim value3 As KeyEventHandler = AddressOf Me.txtInclination_KeyDown
				Dim value4 As KeyEventHandler = AddressOf Me.txtInclination_KeyUp
				Dim value5 As EventHandler = AddressOf Me.txtInclination_Leave
				Dim value6 As EventHandler = AddressOf Me.txtInclination_Enter
				If Me._txtInclination IsNot Nothing Then
					RemoveHandler Me._txtInclination.TextChanged, value2
					RemoveHandler Me._txtInclination.KeyDown, value3
					RemoveHandler Me._txtInclination.KeyUp, value4
					RemoveHandler Me._txtInclination.Leave, value5
					RemoveHandler Me._txtInclination.Enter, value6
				End If
				Me._txtInclination = value
				If Me._txtInclination IsNot Nothing Then
					AddHandler Me._txtInclination.TextChanged, value2
					AddHandler Me._txtInclination.KeyDown, value3
					AddHandler Me._txtInclination.KeyUp, value4
					AddHandler Me._txtInclination.Leave, value5
					AddHandler Me._txtInclination.Enter, value6
				End If
			End Set
		End Property

		Public Overridable Property txtAzimuth As TextBox
			Get
				Return Me._txtAzimuth
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As KeyEventHandler = AddressOf Me.txtAzimuth_KeyUp
				Dim value3 As KeyEventHandler = AddressOf Me.txtAzimuth_KeyDown
				Dim value4 As EventHandler = AddressOf Me.txtAzimuth_Leave
				Dim value5 As EventHandler = AddressOf Me.txtAzimuth_Enter
				Dim value6 As EventHandler = AddressOf Me.txtAzimuth_TextChanged
				If Me._txtAzimuth IsNot Nothing Then
					RemoveHandler Me._txtAzimuth.KeyUp, value2
					RemoveHandler Me._txtAzimuth.KeyDown, value3
					RemoveHandler Me._txtAzimuth.Leave, value4
					RemoveHandler Me._txtAzimuth.Enter, value5
					RemoveHandler Me._txtAzimuth.TextChanged, value6
				End If
				Me._txtAzimuth = value
				If Me._txtAzimuth IsNot Nothing Then
					AddHandler Me._txtAzimuth.KeyUp, value2
					AddHandler Me._txtAzimuth.KeyDown, value3
					AddHandler Me._txtAzimuth.Leave, value4
					AddHandler Me._txtAzimuth.Enter, value5
					AddHandler Me._txtAzimuth.TextChanged, value6
				End If
			End Set
		End Property

		Friend Overridable Property Panel1 As System.Windows.Forms.Panel
			Get
				Return Me._Panel1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As System.Windows.Forms.Panel)
				Me._Panel1 = value
			End Set
		End Property

		Friend Overridable Property Panel2 As System.Windows.Forms.Panel
			Get
				Return Me._Panel2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As System.Windows.Forms.Panel)
				Me._Panel2 = value
			End Set
		End Property

		Friend Overridable Property TChart1 As TChart
			Get
				Return Me._TChart1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TChart)
				Dim value2 As EventHandler = AddressOf Me.TChart1_Move
				Dim value3 As MouseEventHandler = AddressOf Me.TChart1_MouseDown
				If Me._TChart1 IsNot Nothing Then
					RemoveHandler Me._TChart1.Move, value2
					RemoveHandler Me._TChart1.MouseDown, value3
				End If
				Me._TChart1 = value
				If Me._TChart1 IsNot Nothing Then
					AddHandler Me._TChart1.Move, value2
					AddHandler Me._TChart1.MouseDown, value3
				End If
			End Set
		End Property

		Public Overridable Property grpDevPlot As GroupBox
			Get
				Return Me._grpDevPlot
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._grpDevPlot = value
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

		Friend Overridable Property btnReadTest As Button
			Get
				Return Me._btnReadTest
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Me._btnReadTest = value
			End Set
		End Property

		Friend Overridable Property point3DSeries1 As Points3D
			Get
				Return Me._point3DSeries1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Points3D)
				Dim value2 As Points3D.GetPointerStyleEventHandler = AddressOf Me.point3DSeries1_GetPointerStyle
				If Me._point3DSeries1 IsNot Nothing Then
					RemoveHandler Me._point3DSeries1.GetPointerStyle, value2
				End If
				Me._point3DSeries1 = value
				If Me._point3DSeries1 IsNot Nothing Then
					AddHandler Me._point3DSeries1.GetPointerStyle, value2
				End If
			End Set
		End Property

		Friend Overridable Property MarksTip1 As MarksTip
			Get
				Return Me._MarksTip1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MarksTip)
				Dim value2 As MarksTipGetTextEventHandler = AddressOf Me.marksTip1_GetText
				If Me._MarksTip1 IsNot Nothing Then
					RemoveHandler Me._MarksTip1.GetText, value2
				End If
				Me._MarksTip1 = value
				If Me._MarksTip1 IsNot Nothing Then
					AddHandler Me._MarksTip1.GetText, value2
				End If
			End Set
		End Property

		Friend Overridable Property btnResetPlot As Button
			Get
				Return Me._btnResetPlot
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnResetPlot_Click
				If Me._btnResetPlot IsNot Nothing Then
					RemoveHandler Me._btnResetPlot.Click, value2
				End If
				Me._btnResetPlot = value
				If Me._btnResetPlot IsNot Nothing Then
					AddHandler Me._btnResetPlot.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property lblNoData As Label
			Get
				Return Me._lblNoData
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblNoData = value
			End Set
		End Property

		Friend Overridable Property lblTemp As Label
			Get
				Return Me._lblTemp
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblTemp = value
			End Set
		End Property

		Friend Overridable Property txtTempLength As TextBox
			Get
				Return Me._txtTempLength
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtTempLength = value
			End Set
		End Property

		Public Overridable Property cmdDelSection As Button
			Get
				Return Me._cmdDelSection
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.cmdDelSection_Click
				If Me._cmdDelSection IsNot Nothing Then
					RemoveHandler Me._cmdDelSection.Click, value2
				End If
				Me._cmdDelSection = value
				If Me._cmdDelSection IsNot Nothing Then
					AddHandler Me._cmdDelSection.Click, value2
				End If
			End Set
		End Property

		Public Overridable Property cmdDeleteALLSections As Button
			Get
				Return Me._cmdDeleteALLSections
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.cmdDeleteALLSections_Click
				If Me._cmdDeleteALLSections IsNot Nothing Then
					RemoveHandler Me._cmdDeleteALLSections.Click, value2
				End If
				Me._cmdDeleteALLSections = value
				If Me._cmdDeleteALLSections IsNot Nothing Then
					AddHandler Me._cmdDeleteALLSections.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property btnImport As Button
			Get
				Return Me._btnImport
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnImport_Click
				If Me._btnImport IsNot Nothing Then
					RemoveHandler Me._btnImport.Click, value2
				End If
				Me._btnImport = value
				If Me._btnImport IsNot Nothing Then
					AddHandler Me._btnImport.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property Button1 As Button
			Get
				Return Me._Button1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Me._Button1 = value
			End Set
		End Property

		Friend Overridable Property btnExport As Button
			Get
				Return Me._btnExport
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnExport_Click
				If Me._btnExport IsNot Nothing Then
					RemoveHandler Me._btnExport.Click, value2
				End If
				Me._btnExport = value
				If Me._btnExport IsNot Nothing Then
					AddHandler Me._btnExport.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property Panel_Dogleg As System.Windows.Forms.Panel
			Get
				Return Me._Panel_Dogleg
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As System.Windows.Forms.Panel)
				Me._Panel_Dogleg = value
			End Set
		End Property

		Friend Overridable Property lblNoDataAvailable As Label
			Get
				Return Me._lblNoDataAvailable
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblNoDataAvailable = value
			End Set
		End Property

		Friend Overridable Property ChartFX_DoglegSeverity As ChartFX.WinForms.Chart
			Get
				Return Me._ChartFX_DoglegSeverity
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ChartFX.WinForms.Chart)
				Me._ChartFX_DoglegSeverity = value
			End Set
		End Property

		Private Overridable Property commander1 As Commander
			Get
				Return Me._commander1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Commander)
				Dim value2 As ToolBarButtonClickEventHandler = AddressOf Me.commander1_ButtonClick
				If Me._commander1 IsNot Nothing Then
					RemoveHandler Me._commander1.ButtonClick, value2
				End If
				Me._commander1 = value
				If Me._commander1 IsNot Nothing Then
					AddHandler Me._commander1.ButtonClick, value2
				End If
			End Set
		End Property

		Friend Overridable Property pnlLegend As System.Windows.Forms.Panel
			Get
				Return Me._pnlLegend
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As System.Windows.Forms.Panel)
				Dim value2 As PaintEventHandler = AddressOf Me.pnlLegend_Paint
				If Me._pnlLegend IsNot Nothing Then
					RemoveHandler Me._pnlLegend.Paint, value2
				End If
				Me._pnlLegend = value
				If Me._pnlLegend IsNot Nothing Then
					AddHandler Me._pnlLegend.Paint, value2
				End If
			End Set
		End Property

		Friend Overridable Property lblDiameters As Label
			Get
				Return Me._lblDiameters
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblDiameters = value
			End Set
		End Property

		Friend Overridable Property T20 As Label
			Get
				Return Me._T20
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._T20 = value
			End Set
		End Property

		Friend Overridable Property T19 As Label
			Get
				Return Me._T19
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._T19 = value
			End Set
		End Property

		Friend Overridable Property T18 As Label
			Get
				Return Me._T18
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._T18 = value
			End Set
		End Property

		Friend Overridable Property T17 As Label
			Get
				Return Me._T17
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._T17 = value
			End Set
		End Property

		Friend Overridable Property T16 As Label
			Get
				Return Me._T16
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._T16 = value
			End Set
		End Property

		Friend Overridable Property T15 As Label
			Get
				Return Me._T15
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._T15 = value
			End Set
		End Property

		Friend Overridable Property T14 As Label
			Get
				Return Me._T14
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._T14 = value
			End Set
		End Property

		Friend Overridable Property T13 As Label
			Get
				Return Me._T13
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._T13 = value
			End Set
		End Property

		Friend Overridable Property T12 As Label
			Get
				Return Me._T12
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._T12 = value
			End Set
		End Property

		Friend Overridable Property T11 As Label
			Get
				Return Me._T11
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._T11 = value
			End Set
		End Property

		Friend Overridable Property T10 As Label
			Get
				Return Me._T10
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._T10 = value
			End Set
		End Property

		Friend Overridable Property T9 As Label
			Get
				Return Me._T9
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._T9 = value
			End Set
		End Property

		Friend Overridable Property T8 As Label
			Get
				Return Me._T8
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._T8 = value
			End Set
		End Property

		Friend Overridable Property T7 As Label
			Get
				Return Me._T7
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._T7 = value
			End Set
		End Property

		Friend Overridable Property T6 As Label
			Get
				Return Me._T6
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._T6 = value
			End Set
		End Property

		Friend Overridable Property T5 As Label
			Get
				Return Me._T5
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._T5 = value
			End Set
		End Property

		Friend Overridable Property T4 As Label
			Get
				Return Me._T4
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._T4 = value
			End Set
		End Property

		Friend Overridable Property T3 As Label
			Get
				Return Me._T3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._T3 = value
			End Set
		End Property

		Friend Overridable Property T2 As Label
			Get
				Return Me._T2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._T2 = value
			End Set
		End Property

		Friend Overridable Property T1 As Label
			Get
				Return Me._T1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._T1 = value
			End Set
		End Property

		Friend Overridable Property btnPaste As Button
			Get
				Return Me._btnPaste
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnPaste_Click
				If Me._btnPaste IsNot Nothing Then
					RemoveHandler Me._btnPaste.Click, value2
				End If
				Me._btnPaste = value
				If Me._btnPaste IsNot Nothing Then
					AddHandler Me._btnPaste.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property lblDiameters2 As Label
			Get
				Return Me._lblDiameters2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblDiameters2 = value
			End Set
		End Property

		Friend Overridable Property lblStatus As Label
			Get
				Return Me._lblStatus
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Dim value2 As EventHandler = AddressOf Me.lblStatus_TextChanged
				If Me._lblStatus IsNot Nothing Then
					RemoveHandler Me._lblStatus.TextChanged, value2
				End If
				Me._lblStatus = value
				If Me._lblStatus IsNot Nothing Then
					AddHandler Me._lblStatus.TextChanged, value2
				End If
			End Set
		End Property

		Public Shared Property DefInstance As DeviationProfile
			Get
				If DeviationProfile.m_vb6FormDefInstance Is Nothing OrElse DeviationProfile.m_vb6FormDefInstance.IsDisposed Then
					DeviationProfile.m_InitializingDefInstance = True
					DeviationProfile.m_vb6FormDefInstance = New DeviationProfile()
					DeviationProfile.m_InitializingDefInstance = False
				End If
				Return DeviationProfile.m_vb6FormDefInstance
			End Get
			Set(value As DeviationProfile)
				DeviationProfile.m_vb6FormDefInstance = value
			End Set
		End Property

		Public Property bClosing As Boolean
			Get
				Return Me.m_bClosing
			End Get
			Set(value As Boolean)
				Me.m_bClosing = value
			End Set
		End Property

		Private Overridable Property frmWizard As frmWizard
			Get
				Return Me._frmWizard
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As frmWizard)
				Me._frmWizard = value
			End Set
		End Property

		Private Overridable Property frmImportDialog As frmImportDialog
			Get
				Return Me._frmImportDialog
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As frmImportDialog)
				Me._frmImportDialog = value
			End Set
		End Property

		Public Property bVisible_tabInput As Boolean
			Get
				Return Me.m_bVisible_tabInput
			End Get
			Set(value As Boolean)
				Me.m_bVisible_tabInput = value
				Me.tabInput.Visible = value
			End Set
		End Property

		Public Property bAfterPump As Boolean
			Get
				Return Me.m_bAfterPump
			End Get
			Set(value As Boolean)
				Me.m_bAfterPump = value
			End Set
		End Property

		Public Function CheckFormData() As Boolean
			Dim result As Boolean = False
			Dim text As String = "enter"
			Dim text2 As String = Nothing
			Dim text3 As String
			If Strings.Len(text2) > 0 Then
				text3 = String.Concat(New String() { "Please ", text, " the ", text2, "." })
			End If
			If Strings.Len(text3) > 0 Then
				Util.Errmsg(text3)
			Else
				Dim flag As Boolean
				If(RSWIN_DESC.NewData(5) And If((-If((Me.CheckForValidValues(RSWIN_DESC.mdsDeviationProfile, flag, 1) > False), 1S, 0S)), 1S, 0S) And If((-If((Me.CheckValidSurveyDepth(RSWIN_DESC.mdsDeviationProfile) > False), 1S, 0S)), 1S, 0S)) <> 0S Then
					RSWIN_DESC.NewData(5) = 0S
					ini.SaveDataValue("DeviationProfile", True)
				Else
					ini.SaveDataValue("DeviationProfile", False)
				End If
				result = True
			End If
			Return result
		End Function

		Private Function CheckDeviationProfile() As Boolean
			Dim num As Integer = 0
			Dim num2 As Single = Conversions.ToSingle(Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem = 3, 305, 1000))
			Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem = 3, 70, 200))
			Dim flag As Boolean = False
			Dim flag2 As Boolean = True
			Dim num3 As Integer = 0
			Dim num4 As Integer = -1
			Dim text As String = Nothing
			Me.lblStatus.Text = " "
			Dim ultraGridRow As UltraGridRow = Me.ulgDeviationProfile.GetRow(ChildRow.First)
			If Information.Err().Number <> 0 Then
				ultraGridRow = Nothing
			End If
			Dim flag3 As Boolean
			Dim flag4 As Boolean
			Dim num5 As Double
			Dim iNumToAdd As Integer
			Dim num9 As Integer
			While ultraGridRow IsNot Nothing
				Dim ultraGridRow2 As UltraGridRow = ultraGridRow
				num += 1
				Dim objectValue2 As Object
				Dim obj As Object
				Dim obj2 As Object
				If Information.IsDBNull(RuntimeHelpers.GetObjectValue(ultraGridRow2.Cells("Depth").Value)) Then
					text = "Depth"
				ElseIf Conversions.ToBoolean(Operators.OrObject(Information.IsDBNull(RuntimeHelpers.GetObjectValue(ultraGridRow2.Cells("Azimuth").Value)), Operators.CompareObjectEqual(ultraGridRow2.Cells("Azimuth").Value, "", False))) Then
					text = "Azimuth"
				ElseIf Conversions.ToBoolean(Operators.OrObject(Information.IsDBNull(RuntimeHelpers.GetObjectValue(ultraGridRow2.Cells("Inclination").Value)), Operators.CompareObjectEqual(ultraGridRow2.Cells("Inclination").Value, "", False))) Then
					text = "Inclination"
				Else
					Dim text2 As String = Conversions.ToString(ultraGridRow2.Cells("Azimuth").Value)
					Dim text3 As String = Me.AzimuthCheck(text2)
					Dim text4 As String = Me.InclinationCheck(Conversions.ToString(ultraGridRow2.Cells("Inclination").Value))
					Util.CheckDecimal(text3)
					Util.CheckDecimal(text4)
					If Strings.Len(text3) = 0 Or Strings.Len(text4) = 0 Then
						If Strings.Len(text3) = 0 Then
							ultraGridRow2.Cells("Azimuth").Value = DBNull.Value
							text = "Azimuth"
						ElseIf Strings.Len(text4) = 0 Then
							ultraGridRow2.Cells("Inclination").Value = DBNull.Value
							text = "Inclination"
						End If
					Else
						objectValue2 = RuntimeHelpers.GetObjectValue(ultraGridRow2.Cells("Depth").Value)
						obj = Convert.ToDouble(text3)
						obj2 = Convert.ToDouble(text4)
						If Strings.Len(text) = 0 Then
							Me.CheckDeviationProfileValue(RuntimeHelpers.GetObjectValue(objectValue2), "Depth", flag3, flag4)
							If flag3 OrElse flag4 Then
								text = "Depth"
								flag2 = False
							End If
						End If
						If Strings.Len(text) = 0 Then
							Me.CheckDeviationProfileValue(RuntimeHelpers.GetObjectValue(obj), "Azimuth", flag3, flag4)
							If flag3 OrElse flag4 Then
								text = "Azimuth"
								num5 = Convert.ToDouble(RuntimeHelpers.GetObjectValue(objectValue2))
								flag2 = False
								If flag4 Then
									Me.lblStatus.ForeColor = Color.Red
									Me.lblStatus.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("     Row #" + num.ToString().Trim() + ", Entered Azimuth Out of Range (", obj), ")."))
								End If
							End If
						End If
						If Strings.Len(text) = 0 Then
							Me.CheckDeviationProfileValue(RuntimeHelpers.GetObjectValue(obj2), "Inclination", flag3, flag4)
							If flag3 OrElse flag4 Then
								text = "Inclination"
								num5 = CDbl(Convert.ToSingle(RuntimeHelpers.GetObjectValue(objectValue2)))
								flag2 = False
								If flag4 Then
									Me.lblStatus.ForeColor = Color.Red
									Me.lblStatus.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("     Row #, Inclination Out of Range (", obj2), ")."))
								End If
							End If
						End If
						If flag2 Then
							Dim num7 As Single
							If num = 2 Then
								Dim num6 As Single = Conversions.ToSingle(Operators.SubtractObject(objectValue2, num7))
								If num6 >= num2 Then
									flag = True
									iNumToAdd = Conversions.ToInteger(Operators.SubtractObject(Operators.DivideObject(num6, objectValue), 1))
								End If
							End If
							num7 = Conversions.ToSingle(objectValue2)
							Dim objectValue3 As Object = RuntimeHelpers.GetObjectValue(obj2)
							Dim objectValue4 As Object = RuntimeHelpers.GetObjectValue(obj)
						End If
					End If
				End If
				Dim flag5 As Boolean = Strings.Len(text) <> 0 And num4 < 0
				Dim num8 As Integer = CInt((0S - If(-If((Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue2)) > False), 1S, 0S), 1S, 0S) - If((-If((Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) > False), 1S, 0S)), 1S, 0S) - If((-If((Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj2)) > False), 1S, 0S)), 1S, 0S)))
				If num8 > 0 Then
					num3 += 1
				End If
				num9 += num8
				If ultraGridRow2.HasNextSibling() Then
					ultraGridRow = ultraGridRow2.GetSibling(SiblingRow.[Next])
				Else
					ultraGridRow = Nothing
				End If
			End While
			Dim num10 As Integer = num3 * 3
			Dim text5 As String
			If num10 = 0 Then
				text5 = " "
				flag2 = False
			ElseIf CDbl(num9) / CDbl(num10) < 0.6 Then
				text5 = " "
				flag2 = False
			Else
				text5 = text5
			End If
			If Strings.Len(text5) = 0 Then
				If flag3 Then
					Dim text6 As String = text
					If Operators.CompareString(text6, "Depth", False) = 0 Then
						text5 = Support.LoadResString(107)
					ElseIf Operators.CompareString(text6, "Azimuth", False) = 0 Then
						text5 = Util.FormatMessage(Support.LoadResString(108), New Object() { num5 })
					ElseIf Operators.CompareString(text6, "Inclination", False) = 0 Then
						text5 = Util.FormatMessage(Support.LoadResString(110), New Object() { num5 })
					End If
				ElseIf flag4 Then
					Dim text7 As String = text
					If Operators.CompareString(text7, "Azimuth", False) = 0 Then
						text5 = Util.FormatMessage(Support.LoadResString(109), New Object() { num5 })
					ElseIf Operators.CompareString(text7, "Inclination", False) = 0 Then
						text5 = Util.FormatMessage(Support.LoadResString(111), New Object() { num5 })
					End If
				End If
			End If
			RSWIN_DESC.frmMain.ToolbarButtonSetState(16, flag2)
			Dim result As Boolean = flag2
			If flag2 AndAlso (flag And Not Me.bAddQuestionAsked And Not Me.bNew) Then
				Dim msg As String = "The difference in the first and second entered measured depths is greater than " + Conversions.ToString(num2) + " feet. Do you want the program to fill in missing points?"
				Dim bDefaultYes As Boolean = True
				Dim flag6 As Boolean = False
				If Util.YesNo(msg, bDefaultYes, flag6) Then
					Me.EnterMissingPoints(iNumToAdd, Conversions.ToSingle(objectValue))
					Me.bAddQuestionAsked = True
				Else
					Me.bAddQuestionAsked = True
				End If
			End If
			Return result
		End Function

		Private Sub CheckDeviationProfileValue(Value As Object, sKey As String, ByRef bMissing As Boolean, ByRef bOutOfRange As Boolean)
			bMissing = False
			bOutOfRange = False
			If Information.IsDBNull(RuntimeHelpers.GetObjectValue(Value)) Then
				bMissing = True
			ElseIf Operators.CompareString(sKey, "Azimuth", False) = 0 Then
				If Operators.ConditionalCompareObjectGreater(Value, 360, False) Then
					bOutOfRange = True
				End If
			ElseIf Operators.CompareString(sKey, "Inclination", False) = 0 AndAlso Operators.ConditionalCompareObjectGreater(Value, 180, False) Then
				bOutOfRange = True
			End If
		End Sub

		Private Sub CheckDisabledItems(X As Integer, Y As Integer)
		End Sub

		Private Sub InitDeviationProfile()
			Try
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				rst.FluidDamping = Conversions.ToSingle(ini.GetDataValue("FluidDamping", 4, True, 0.1))
				rst.PumpDragUpstrokeMax = Conversions.ToSingle(ini.GetDataValue("PumpDragUpstrokeMax", 4, True, 200))
				rst.PumpDragDownstrokeMax = Conversions.ToSingle(ini.GetDataValue("PumpDragDownstrokeMax", 4, True, 200))
				rst.DragSettings = Conversions.ToShort(ini.GetDataValue("DragSettings", 2, True, 0))
				If RSWIN_DESC.NewData(5) <> 0S Then
					If Not RSWIN_DESC.bNewCaseAsked Then
						Dim text As String
						LOADRST.LoadTempDeviationProfile(text, True)
					End If
				Else
					Dim str As String = "temp.deviationprofile"
					Dim str2 As String = Interaction.Environ("USERPROFILE") + "\Application Data\ThetaData\" + VERSION1.ProgramName()
					Dim pathName As String = str2 + "\" + str
					If FILEUTIL.FileExists(pathName) Then
						FileSystem.Kill(pathName)
					End If
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub LoadDeviationProfile()
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			If RSWIN_DESC.NewData(5) <> 0S Then
				If rst.FluidDamping = 0F Then
					rst.FluidDamping = Conversions.ToSingle(ini.GetDataValue("FluidDamping", 4, True, 0.1))
				End If
				If rst.PumpDragUpstrokeMax = 0F Then
					rst.PumpDragUpstrokeMax = Conversions.ToSingle(ini.GetDataValue("PumpDragUpstrokeMax", 4, True, 200))
				End If
				If rst.PumpDragDownstrokeMax = 0F Then
					rst.PumpDragDownstrokeMax = Conversions.ToSingle(ini.GetDataValue("PumpDragDownstrokeMax", 4, True, 200))
				End If
			End If
		End Sub

		Public Function StoreTempDeviationProfile(ByRef mdsDeviationProfile As DataSet, bConvert As Boolean) As Boolean
			Dim dataSet As DataSet = New DataSet()
			Dim result As Boolean
			Try
				If mdsDeviationProfile Is Nothing Then
					result = False
				Else
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
					Dim flag As Boolean = True
					FileSystem.FileClose(New Integer() { num2 })
					result = flag
				End If
			Catch ex As Exception
			End Try
			Return result
		End Function

		Private Sub ShowDeviation_TVD(dsDeviationProfile As DataSet, bPlotData As Boolean, ByRef iostat As Short)
			Try
				Dim num As Double = 2.0 * Math.Atan(1.0)
				Dim activeRow As UltraGridRow = Me.ulgDeviationProfile.ActiveRow
				num = 2.0 * Math.Atan(1.0)
				Dim num2 As Integer = dsDeviationProfile.Tables(0).Rows.Count
				Dim array2 As Single()
				Dim array3 As DeviationProfile.survey_point_type()
				Dim array4 As Double()
				Dim array5 As Double()
				Dim array6 As Double()
				Dim array7 As Double()
				Dim num4 As Single
				Dim parameter_structure_type As DeviationProfile.parameter_structure_type
				Dim ultraGridRow As UltraGridRow
				Dim flag As Boolean
				Dim num3 As Short = CShort(dsDeviationProfile.Tables(0).Rows.Count)
				Dim array As Double() = New Double(num2 + 1 - 1) {}
				Me.m_MeasDepth = New Double(num2 + 1 - 1) {}
				array2 = New Single(num2 + 1 - 1) {}
				array3 = New DeviationProfile.survey_point_type(num2 + 1 - 1) {}
				array4 = New Double(num2 + 1 - 1) {}
				Me.m_TVDepth = New Double(num2 + 1 - 1) {}
				array5 = New Double(num2 + 1 - 1) {}
				array6 = New Double(num2 + 1 - 1) {}
				array7 = New Double(num2 + 1 - 1) {}
				num4 = 400F
				parameter_structure_type.epsilon = 1E-06
				num2 = 0
				Dim num5 As Double = 0.0
				array2(0) = 0F
				ultraGridRow = Me.ulgDeviationProfile.GetRow(ChildRow.First)
				flag = True
				Try
					Me.fMaxMD = 0F
					While flag
						Dim ultraGridRow2 As UltraGridRow = ultraGridRow
						If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(ultraGridRow2.Cells("Depth").Value)) And Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(ultraGridRow2.Cells("Inclination").Value)) And Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(ultraGridRow2.Cells("Azimuth").Value)) Then
							Dim num6 As Double = Conversions.ToDouble(ultraGridRow2.Cells("Depth").Value)
							If num6 > CDbl(Me.fMaxMD) Then
								Me.fMaxMD = CSng(num6)
							End If
							If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
								Dim num7 As Single = CSng(num6)
								CtrlUI.ConvertValue(num7, "f", True)
								num6 = CDbl(num7)
							End If
							Dim text As String = Conversions.ToString(ultraGridRow2.Cells("Azimuth").Value)
							Dim text2 As String = Me.AzimuthCheck(text)
							Dim text3 As String = Me.InclinationCheck(Conversions.ToString(ultraGridRow2.Cells("Inclination").Value))
							If Versioned.IsNumeric(text2) And Versioned.IsNumeric(text3) Then
								num2 += 1
								Dim num8 As Double = Convert.ToDouble(text2)
								Dim num9 As Double = Convert.ToDouble(text3)

									array3(num2).azi = num8 / 180.0 * 3.141592653589793
									array3(num2).inc = num9 / 180.0 * 3.141592653589793
									Dim num10 As Double = num6 - num5
									array2(num2) = CSng(num10)
									num5 = num6
									array3(num2).m_d = num6
									array(num2) = num6
									Me.m_MeasDepth(num2) = array(num2)

							End If
						End If
						If ultraGridRow.HasNextSibling() Then
							ultraGridRow = ultraGridRow.GetSibling(SiblingRow.[Next])
						Else
							flag = False
						End If
					End While
				Catch ex As Exception
				End Try
				Try
					iostat = 0S
					parameter_structure_type.num_survey_points = dsDeviationProfile.Tables(0).Rows.Count
					Dim num11 As Short = 1S
					Dim num12 As Short = CShort(parameter_structure_type.num_survey_points)
					For num13 As Short = num11 To num12
						array3(CInt(num13)).tan.X = Math.Sin(array3(CInt(num13)).inc) * Math.Sin(array3(CInt(num13)).azi)
						array3(CInt(num13)).tan.Y = Math.Sin(array3(CInt(num13)).inc) * Math.Cos(array3(CInt(num13)).azi)
						array3(CInt(num13)).tan.z = Math.Cos(array3(CInt(num13)).inc)
					Next
				Catch ex2 As Exception
				End Try
				Try
					Dim num14 As Short = 1S
					Dim num15 As Short = CShort((parameter_structure_type.num_survey_points - 1))
					For num13 As Short = num14 To num15
						' The following expression was wrapped in a checked-expression
						Dim num16 As Double = Me.dot_prod(array3(CInt(num13)).tan, array3(CInt((num13 + 1S))).tan)
						If num16 > 1.0 Then
							If num16 <= 1.0 + parameter_structure_type.epsilon Then
								num16 = 1.0
							Else
								iostat = -9941S
							End If
						End If
						If num16 < 0.0 Then
							If num16 >= -parameter_structure_type.epsilon Then
								num16 = 0.0
							Else
								iostat = -9942S
							End If
						End If
						array3(CInt(num13)).dog = kinemat.ArcCosine(CSng(num16))
						If array3(CInt(num13)).dog > parameter_structure_type.epsilon Then
							' The following expression was wrapped in a checked-expression
							array3(CInt(num13)).rad = (array3(CInt((num13 + 1S))).m_d - array3(CInt(num13)).m_d) / array3(CInt(num13)).dog
						Else
							array3(CInt(num13)).rad = -9999.0
						End If
					Next
				Catch ex3 As Exception
				End Try
				Try
					Dim num17 As Short
					Dim num18 As Short
					Dim num13 As Short = CShort(parameter_structure_type.num_survey_points)
					array3(CInt(num13)).dog = -9999.0
					array3(CInt(num13)).rad = -9999.0
					num17 = 1S
					num18 = CShort((parameter_structure_type.num_survey_points - 1))
					For num13 As Short = num17 To num18
						If array3(CInt(num13)).dog > parameter_structure_type.epsilon Then
							' The following expression was wrapped in a checked-expression
							Me.calc_nor(array3(CInt(num13)).nor, array3(CInt(num13)).tan, array3(CInt((num13 + 1S))).tan)
						Else
							array3(CInt(num13)).nor.X = -9999.0
							array3(CInt(num13)).nor.Y = -9999.0
							array3(CInt(num13)).nor.z = -9999.0
						End If
					Next
				Catch ex4 As Exception
				End Try
				Try
					Dim num19 As Short
					Dim num20 As Short
					Dim num13 As Short = CShort(parameter_structure_type.num_survey_points)
					array3(CInt(num13)).nor.X = -9999.0
					array3(CInt(num13)).nor.Y = -9999.0
					array3(CInt(num13)).nor.z = -9999.0
					num13 = 1S
					array3(CInt(num13)).pos.X = 0.0
					array3(CInt(num13)).pos.Y = 0.0
					array3(CInt(num13)).pos.z = 0.0
					num19 = 2S
					num20 = CShort(parameter_structure_type.num_survey_points)
					For num13 As Short = num19 To num20
						' The following expression was wrapped in a checked-statement
						If array3(CInt((num13 - 1S))).dog > parameter_structure_type.epsilon Then
							Me.calc_pos(array3(CInt(num13)).pos, array3(CInt((num13 - 1S))).pos, array3(CInt((num13 - 1S))).tan, array3(CInt((num13 - 1S))).nor, array3(CInt((num13 - 1S))).dog, array3(CInt((num13 - 1S))).rad)
						Else
							Me.calc_str(array3(CInt(num13)).pos, array3(CInt((num13 - 1S))).pos, array3(CInt((num13 - 1S))).tan, array3(CInt(num13)).m_d, array3(CInt((num13 - 1S))).m_d)
						End If
					Next
				Catch ex5 As Exception
				End Try
				Try
					ultraGridRow = Me.ulgDeviationProfile.GetRow(ChildRow.First)
					ultraGridRow.Cells("TVDepth").Value = 0
					ultraGridRow.Cells("NorthSouth").Value = 0
					ultraGridRow.Cells("EastWest").Value = 0
					If ultraGridRow.HasNextSibling() Then
						ultraGridRow = ultraGridRow.GetSibling(SiblingRow.[Next])
						flag = True
					Else
						flag = False
					End If
				Catch ex6 As Exception
				End Try
				Try
					Dim num21 As Integer = 2
					While flag
						Try
							If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
								Dim num22 As Single = CSng(array3(num21).pos.z)
								array4(num21) = Math.Round(CDbl((num22 * RSWIN_DESC.FT__M)), 2)
								Me.m_TVDepth(num21) = array4(num21)
								num22 = CSng(array3(num21).pos.Y)
								array6(num21) = Math.Round(CDbl((num22 * RSWIN_DESC.FT__M)), 2)
								num22 = CSng(array3(num21).pos.X)
								array7(num21) = Math.Round(CDbl((num22 * RSWIN_DESC.FT__M)), 2)
							Else
								array4(num21) = Math.Round(array3(num21).pos.z, 2)
								Me.m_TVDepth(num21) = array4(num21)
								array6(num21) = Math.Round(array3(num21).pos.Y, 2)
								array7(num21) = Math.Round(array3(num21).pos.X, 2)
							End If
							If array2(num21) <> 0F Then
								Dim dog As Double = array3(num21).dog
								If dog = -9999.0 Then
									' The following expression was wrapped in a checked-expression
									dog = array3(parameter_structure_type.num_survey_points - 1).dog
								End If
								If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
									array5(num21) = Math.Round(dog / num * 90.0 / CDbl(array2(num21)) * 100.0, 2)
								Else
									array5(num21) = Math.Round(dog / num * 90.0 / CDbl(array2(num21)) * 30.0, 2)
								End If
							Else
								array5(num21) = 0.0
							End If
							ultraGridRow.Cells("TVDepth").Value = array4(num21)
							ultraGridRow.Cells("NorthSouth").Value = array6(num21)
							ultraGridRow.Cells("EastWest").Value = array7(num21)
							If Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectGreater(ultraGridRow.Cells("Dogleg").Value, array5(num21), False), num21 < 4)) AndAlso array3(2).m_d - array3(1).m_d < CDbl(num4) Then
								ultraGridRow.Cells("Dogleg").Value = array5(num21)
								If Not bPlotData Then
									If Operators.ConditionalCompareObjectGreaterEqual(ultraGridRow.Cells("Dogleg").Value, 15, False) Then
										ultraGridRow.Cells("Dogleg").Appearance.ForeColor = Color.Crimson
									Else
										ultraGridRow.Cells("Dogleg").Appearance.ForeColor = Color.Black
									End If
								End If
							End If
						Catch ex7 As Exception
						End Try
						num21 += 1
						If num21 = num2 + 1 Then
							flag = False
						ElseIf ultraGridRow.HasNextSibling() Then
							ultraGridRow = ultraGridRow.GetSibling(SiblingRow.[Next])
						Else
							flag = False
						End If
					End While
				Catch ex8 As Exception
				End Try
				If bPlotData Then
					Me.m_bAfterPump = False
					Me.ShowDeviation_Before_Plot(parameter_structure_type.num_survey_points, array3)
				End If
				Me.SetStatus()
			Catch ex9 As Exception
			End Try
		End Sub

		Private Sub ShowDeviation_Before_Plot(num_survey_points As Integer, ByRef s_p As DeviationProfile.survey_point_type())
			Try
				Dim num As Double = 2.0 * Math.Atan(1.0)
				Dim num2 As Integer
				Dim array As DeviationProfile.survey_point_type()
				Dim array2 As Double()
				Dim array3 As Single()
				Dim array4 As Double()
				Dim array5 As Double()
				Dim array6 As Double()
				Dim array7 As Double()
				Dim array8 As Boolean()
				Dim array9 As Single()
				Dim num3 As Single
				Dim num7 As Integer
				Dim survey_point_type As DeviationProfile.survey_point_type
				Dim num8 As Short
				Dim num9 As Short
				num2 = num_survey_points + 20
				array = New DeviationProfile.survey_point_type(num2 + 1 - 1) {}
				num = 2.0 * Math.Atan(1.0)
				array2 = New Double(num2 + 1 - 1) {}
				Me.m_MeasDepth = New Double(num2 + 1 - 1) {}
				array3 = New Single(num2 + 1 - 1) {}
				array4 = New Double(num2 + 1 - 1) {}
				Me.m_TVDepth = New Double(num2 + 1 - 1) {}
				array5 = New Double(num2 + 1 - 1) {}
				array6 = New Double(num2 + 1 - 1) {}
				array7 = New Double(num2 + 1 - 1) {}
				array8 = New Boolean(44) {}
				array9 = New Single(44) {}
				num3 = 1E-06F
				num2 = 0
				If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
					Me.fMult = 1F
				Else
					Me.fMult = RSWIN_DESC.FT__M
				End If
				RSWIN_DESC.taper_lens = New Single(CInt((RSWIN_DESC.rst.NumRods + 1S)) - 1) {}
				RSWIN_DESC.taper_lens(0) = 0F
				Dim num4 As Integer = 1
				Dim numRods As Integer = CInt(RSWIN_DESC.rst.NumRods)
				For i As Integer = num4 To numRods
					' The following expression was wrapped in a unchecked-expression
					' The following expression was wrapped in a checked-expression
					RSWIN_DESC.taper_lens(i) = RSWIN_DESC.taper_lens(i - 1) + RSWIN_DESC.rst.Sections(i).length
				Next
				Dim j As Integer = 1
				Do
					array8(j) = False
					j += 1
				Loop While j <= 22
				j = 1
				array9(j) = 1F
				array8(j) = True
				If RSWIN_DESC.rst.NumRods > 0S Then
					Dim num5 As Integer = 1
					Dim numRods2 As Integer = CInt(RSWIN_DESC.rst.NumRods)
					For i As Integer = num5 To numRods2
						j += 1
						array9(j) = RSWIN_DESC.taper_lens(i) - 1F
						array8(j) = True
						If i < CInt(RSWIN_DESC.rst.NumRods) Then
							j += 1
							array9(j) = RSWIN_DESC.taper_lens(i) + 1F
							array8(j) = True
						Else
							j += 1
							array9(j) = RSWIN_DESC.taper_lens(i)
							array8(j) = True
						End If
					Next
					Dim num6 As Integer = 1
					Dim numRods3 As Integer = CInt(RSWIN_DESC.rst.NumRods)
					For i As Integer = num6 To numRods3
						' The following expression was wrapped in a unchecked-expression
						RSWIN_DESC.taper_lens(i) = RSWIN_DESC.taper_lens(i) * Me.fMult
					Next
				End If
				array9(j + 1) = array9(j) + 1F
				array8(j + 1) = True
				j += 1
				num7 = j
				survey_point_type = s_p(1)
				num8 = 1S
				num9 = CShort(num_survey_points)
				For num10 As Short = num8 To num9
					Dim num11 As Integer = 1
					Dim num12 As Integer = num7
					For j As Integer = num11 To num12
						If array8(j) And CDbl(array9(j)) < s_p(CInt(num10)).m_d Then
							num2 += 1
							Try
								If Information.UBound(array, 1) < num2 Then
									array = CType(Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(CType(array, Array), New DeviationProfile.survey_point_type(num2 + 1 - 1) {}), DeviationProfile.survey_point_type())
									array2 = CType(Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(CType(array2, Array), New Double(num2 + 1 - 1) {}), Double())
									Me.m_MeasDepth = CType(Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(CType(Me.m_MeasDepth, Array), New Double(num2 + 1 - 1) {}), Double())
									array3 = CType(Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(CType(array3, Array), New Single(num2 + 1 - 1) {}), Single())
									array4 = CType(Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(CType(array4, Array), New Double(num2 + 1 - 1) {}), Double())
									Me.m_TVDepth = CType(Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(CType(Me.m_TVDepth, Array), New Double(num2 + 1 - 1) {}), Double())
									array5 = CType(Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(CType(array5, Array), New Double(num2 + 1 - 1) {}), Double())
									array6 = CType(Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(CType(array6, Array), New Double(num2 + 1 - 1) {}), Double())
									array7 = CType(Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(CType(array7, Array), New Double(num2 + 1 - 1) {}), Double())
								End If
								array(num2) = survey_point_type
								array(num2).m_d = CDbl(array9(j))
								array2(num2) = array(num2).m_d
								Me.m_MeasDepth(num2) = array2(num2)
								array8(j) = False
							Catch ex As Exception
							End Try
						End If
					Next
					num2 += 1
					Try
						If Information.UBound(array, 1) < num2 Then
							array = CType(Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(CType(array, Array), New DeviationProfile.survey_point_type(num2 + 1 - 1) {}), DeviationProfile.survey_point_type())
							array2 = CType(Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(CType(array2, Array), New Double(num2 + 1 - 1) {}), Double())
							Me.m_MeasDepth = CType(Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(CType(Me.m_MeasDepth, Array), New Double(num2 + 1 - 1) {}), Double())
							array3 = CType(Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(CType(array3, Array), New Single(num2 + 1 - 1) {}), Single())
							array4 = CType(Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(CType(array4, Array), New Double(num2 + 1 - 1) {}), Double())
							Me.m_TVDepth = CType(Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(CType(Me.m_TVDepth, Array), New Double(num2 + 1 - 1) {}), Double())
							array5 = CType(Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(CType(array5, Array), New Double(num2 + 1 - 1) {}), Double())
							array6 = CType(Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(CType(array6, Array), New Double(num2 + 1 - 1) {}), Double())
							array7 = CType(Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(CType(array7, Array), New Double(num2 + 1 - 1) {}), Double())
						End If
						array(num2) = s_p(CInt(num10))
						array2(num2) = array(num2).m_d
						Me.m_MeasDepth(num2) = array2(num2)
					Catch ex2 As Exception
					End Try
					survey_point_type = s_p(CInt(num10))
				Next
				Try
					Dim num13 As Short = 1S
					Dim num14 As Short = CShort(num2)
					For num10 As Short = num13 To num14
						array(CInt(num10)).tan.X = Math.Sin(array(CInt(num10)).inc) * Math.Sin(array(CInt(num10)).azi)
						array(CInt(num10)).tan.Y = Math.Sin(array(CInt(num10)).inc) * Math.Cos(array(CInt(num10)).azi)
						array(CInt(num10)).tan.z = Math.Cos(array(CInt(num10)).inc)
					Next
				Catch ex3 As Exception
				End Try
				Try
					Dim num15 As Short = 1S
					Dim num16 As Short = CShort((num2 - 1))
					For num10 As Short = num15 To num16
						' The following expression was wrapped in a checked-expression
						Dim num17 As Double = Me.dot_prod(array(CInt(num10)).tan, array(CInt((num10 + 1S))).tan)
						If num17 > 1.0 AndAlso num17 <= CDbl((1F + num3)) Then
							num17 = 1.0
						End If
						If num17 < 0.0 AndAlso num17 >= CDbl((-CDbl(num3))) Then
							num17 = 0.0
						End If
						array(CInt(num10)).dog = kinemat.ArcCosine(CSng(num17))
						If array(CInt(num10)).dog > CDbl(num3) Then
							' The following expression was wrapped in a checked-expression
							array(CInt(num10)).rad = (array(CInt((num10 + 1S))).m_d - array(CInt(num10)).m_d) / array(CInt(num10)).dog
						Else
							array(CInt(num10)).rad = -9999.0
						End If
					Next
				Catch ex4 As Exception
				End Try
				Try
					Dim num18 As Short
					Dim num19 As Short
					Dim num10 As Short = CShort(num2)
					array(CInt(num10)).dog = -9999.0
					array(CInt(num10)).rad = -9999.0
					num18 = 1S
					num19 = CShort((num2 - 1))
					For num10 As Short = num18 To num19
						If array(CInt(num10)).dog > CDbl(num3) Then
							' The following expression was wrapped in a checked-expression
							Me.calc_nor(array(CInt(num10)).nor, array(CInt(num10)).tan, array(CInt((num10 + 1S))).tan)
						Else
							array(CInt(num10)).nor.X = -9999.0
							array(CInt(num10)).nor.Y = -9999.0
							array(CInt(num10)).nor.z = -9999.0
						End If
					Next
				Catch ex5 As Exception
				End Try
				Try
					Dim num10 As Short = CShort(num2)
					array(CInt(num10)).nor.X = -9999.0
					array(CInt(num10)).nor.Y = -9999.0
					array(CInt(num10)).nor.z = -9999.0
					num10 = 1S
					array(CInt(num10)).pos.X = 0.0
					array(CInt(num10)).pos.Y = 0.0
					array(CInt(num10)).pos.z = 0.0
					Dim num20 As Short = 2S
					Dim num21 As Short = CShort(num2)
					num10 = num20
					While num10 <= num21
						If array(CInt((num10 - 1S))).dog > CDbl(num3) Then
							Me.calc_pos(array(CInt(num10)).pos, array(CInt((num10 - 1S))).pos, array(CInt((num10 - 1S))).tan, array(CInt((num10 - 1S))).nor, array(CInt((num10 - 1S))).dog, array(CInt((num10 - 1S))).rad)
						Else
							Me.calc_str(array(CInt(num10)).pos, array(CInt((num10 - 1S))).pos, array(CInt((num10 - 1S))).tan, array(CInt(num10)).m_d, array(CInt((num10 - 1S))).m_d)
						End If
						num10 = num10 + 1S
					End While
				Catch ex6 As Exception
				End Try
				Try
					Dim i As Integer = 2
					Dim flag As Boolean = True
					While flag

							Try
								If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
									Dim num22 As Single = CSng(array(i).pos.z)
									array4(i) = Math.Round(CDbl((num22 * RSWIN_DESC.FT__M)), 2)
									Me.m_TVDepth(i) = array4(i)
									num22 = CSng(array(i).pos.Y)
									array6(i) = Math.Round(CDbl((num22 * RSWIN_DESC.FT__M)), 2)
									num22 = CSng(array(i).pos.X)
									array7(i) = Math.Round(CDbl((num22 * RSWIN_DESC.FT__M)), 2)
								Else
									array4(i) = Math.Round(array(i).pos.z, 2)
									Me.m_TVDepth(i) = array4(i)
									array6(i) = Math.Round(array(i).pos.Y, 2)
									array7(i) = Math.Round(array(i).pos.X, 2)
								End If
							Catch ex7 As Exception
							End Try

						i += 1
						If i = num2 + 1 Then
							flag = False
						End If
					End While
				Catch ex8 As Exception
				End Try
				Dim num23 As Integer = Information.LBound(Me.m_MeasDepth, 1)
				Dim num24 As Integer = Information.UBound(Me.m_MeasDepth, 1)
				For i As Integer = num23 To num24

						Me.m_MeasDepth(i) = Me.m_MeasDepth(i) * CDbl(Me.fMult)
						array2(i) *= CDbl(Me.fMult)

				Next
				Me.m_bAfterPump = False
				Me.ReplotTeeChart(array7, array4, array6, array2, True)
			Catch ex9 As Exception
				Debug.WriteLine(ex9.Message)
			End Try
		End Sub

		Private Sub ShowDeviation_Dogleg(dsDeviationProfile As DataSet, bPlotData As Boolean, Optional bChangeAll As Boolean = False)
			Try
				Dim activeRow As UltraGridRow = Me.ulgDeviationProfile.ActiveRow
				Dim num As Double = 2.0 * Math.Atan(1.0)
				Dim num2 As Integer = dsDeviationProfile.Tables(0).Rows.Count
				Dim num3 As Short = CShort(dsDeviationProfile.Tables(0).Rows.Count)
				Dim array As Double() = New Double(num2 + 1 - 1) {}
				Dim array2 As Double() = New Double(num2 + 1 - 1) {}
				Dim array3 As Double() = New Double(num2 + 1 - 1) {}
				Dim array4 As Double() = New Double(num2 + 1 - 1) {}
				Dim array5 As Double() = New Double(num2 + 1 - 1) {}
				Dim array6 As Double() = New Double(num2 + 1 - 1) {}
				Dim array7 As Double() = New Double(num2 + 1 - 1) {}
				If Me.m_MeasDepth Is Nothing Then
					Me.m_MeasDepth = New Double(num2 + 1 - 1) {}
				End If
				Dim array8 As Double() = New Double(num2 + 1 - 1) {}
				Dim array9 As Double() = New Double(num2 + 1 - 1) {}
				Dim array10 As Double() = New Double(num2 + 1 - 1) {}
				Dim array11 As Single() = New Single(num2 + 1 - 1) {}
				Dim array12 As DeviationProfile.survey_point_type() = New DeviationProfile.survey_point_type(num2 + 1 - 1) {}
				Dim num4 As Single = 1E-06F
				num2 = 0
				Dim num5 As Double = 0.0
				Dim ultraGridRow As UltraGridRow = Me.ulgDeviationProfile.GetRow(ChildRow.First)
				Dim flag As Boolean = True
				Try
					While flag
						Dim ultraGridRow2 As UltraGridRow = ultraGridRow
						If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(ultraGridRow2.Cells("Depth").Value)) And Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(ultraGridRow2.Cells("Inclination").Value)) And Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(ultraGridRow2.Cells("Azimuth").Value)) Then
							Dim num6 As Double = Conversions.ToDouble(ultraGridRow2.Cells("Depth").Value)
							If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
								Dim num7 As Single = CSng(num6)
								CtrlUI.ConvertValue(num7, "f", True)
								num6 = CDbl(num7)
							End If
							Dim text As String = Conversions.ToString(ultraGridRow2.Cells("Azimuth").Value)
							Dim text2 As String = Me.AzimuthCheck(text)
							Dim text3 As String = Me.InclinationCheck(Conversions.ToString(ultraGridRow2.Cells("Inclination").Value))
							If Versioned.IsNumeric(text2) And Versioned.IsNumeric(text3) Then

									Dim num8 As Double = Convert.ToDouble(text3) / 180.0 * 3.141592653589793
									Dim num9 As Double = Convert.ToDouble(text2)
									If num9 < 0.0 Then
										num9 = 360.0 + num9
									End If
									Dim num10 As Double = num9 / 180.0 * 3.141592653589793
									Dim num11 As Double = num6 - num5
									array11(num2) = CSng(num11)
									array7(num2) = num6
									Me.m_MeasDepth(num2) = num6
									array12(num2).m_d = num6
									array12(num2).inc = num8
									array12(num2).azi = num10

								num2 += 1
								num5 = num6
							End If
						End If
						If ultraGridRow.HasNextSibling() Then
							ultraGridRow = ultraGridRow.GetSibling(SiblingRow.[Next])
						Else
							flag = False
						End If
					End While
				Catch ex As Exception
				End Try
				Dim num12 As Integer = 1
				Dim num13 As Integer = num2
				For i As Integer = num12 To num13

						Try
							Dim num11 As Double
							If i > 1 Then
								' The following expression was wrapped in a checked-expression
								num11 = array12(i).m_d - array12(i - 1).m_d
							Else
								num11 = array12(i).m_d
							End If
							Dim num8 As Double = array12(i).inc
							Dim num10 As Double = array12(i).azi
							array8(i) = num11 * Math.Sin(num8) * Math.Sin(num10)
							array9(i) = num11 * Math.Sin(num8) * Math.Cos(num10)
							array10(i) = num11 * Math.Cos(num8)
							array(i) = Math.Sin(num8) * Math.Sin(num10)
							array2(i) = Math.Sin(num8) * Math.Cos(num10)
							array3(i) = Math.Cos(num8)
							array12(i).tan.X = array(i)
							array12(i).tan.Y = array2(i)
							array12(i).tan.z = array3(i)
						Catch ex2 As Exception
						End Try

				Next
				If num2 > 1 Then
					array = CType(Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(CType(array, Array), New Double(num2 - 1 + 1 - 1) {}), Double())
					array2 = CType(Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(CType(array2, Array), New Double(num2 - 1 + 1 - 1) {}), Double())
					array3 = CType(Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(CType(array3, Array), New Double(num2 - 1 + 1 - 1) {}), Double())
					array12 = CType(Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(CType(array12, Array), New DeviationProfile.survey_point_type(num2 - 1 + 1 - 1) {}), DeviationProfile.survey_point_type())
					array4 = CType(Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(CType(array4, Array), New Double(num2 - 1 + 1 - 1) {}), Double())
					array5 = CType(Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(CType(array5, Array), New Double(num2 - 1 + 1 - 1) {}), Double())
					array6 = CType(Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(CType(array6, Array), New Double(num2 - 1 + 1 - 1) {}), Double())
					ultraGridRow = Me.ulgDeviationProfile.GetRow(ChildRow.First)
					If ultraGridRow.HasNextSibling() Then
						ultraGridRow = ultraGridRow.GetSibling(SiblingRow.[Next])
						flag = True
					Else
						flag = False
					End If
					Dim i As Integer = 1
					array5(0) = 0.0
					While flag

							' The following expression was wrapped in a checked-expression
							array(i) += array(i - 1)
							array2(i) += array2(i - 1)
							array3(i) += array3(i - 1)
							array8(i) += array8(i - 1)
							array9(i) += array9(i - 1)
							array10(i) += array10(i - 1)
							Try
								array5(i) = Math.Round(array10(i), 2)
							Catch ex3 As Exception
							End Try

						i += 1
						If i = num2 Then
							flag = False
						ElseIf ultraGridRow.HasNextSibling() Then
							ultraGridRow = ultraGridRow.GetSibling(SiblingRow.[Next])
						Else
							flag = False
						End If
					End While
				End If
				If num2 > 2 Then
					ultraGridRow = Me.ulgDeviationProfile.GetRow(ChildRow.First)
					ultraGridRow.Cells("Dogleg").Value = 0
					If ultraGridRow.HasNextSibling() Then
						ultraGridRow = ultraGridRow.GetSibling(SiblingRow.[Next])
						flag = True
					Else
						flag = False
					End If
					Dim num14 As Double = 0.0
					Dim num15 As Double = 0.0
					Dim num16 As Double = 1.0
					Dim i As Integer = 1
					While flag
						Dim num17 As Double
						Dim num18 As Double
						Dim num19 As Double

							' The following expression was wrapped in a checked-expression
							num17 = array(i) - array(i - 1)
							num18 = array2(i) - array2(i - 1)
							num19 = array3(i) - array3(i - 1)
							Dim num20 As Double = num14 * num17 + num15 * num18 + num16 * num19
							Dim num21 As Double
							If num20 <> 0.0 Then
								num21 = kinemat.ArcCosine(CSng(num20))
							Else
								num21 = 0.0
							End If
							If num21 < 0.0 Then
								num21 += 2.0 * num
							End If
							If bChangeAll Then
								If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
									Dim num22 As Single = CSng(array10(i))
									ultraGridRow.Cells("TVDepth").Value = Math.Round(CDbl((num22 * RSWIN_DESC.FT__M)), 2)
								Else
									ultraGridRow.Cells("TVDepth").Value = Math.Round(array10(i), 2)
								End If
							End If
							If Not bPlotData Then
								If array11(i) <> 0F Then
									ultraGridRow.Cells("Dogleg").Value = Math.Round(num21 / num * 90.0 / CDbl(array11(i)) * 100.0, 2)
									If Operators.ConditionalCompareObjectGreaterEqual(ultraGridRow.Cells("Dogleg").Value, 15, False) Then
										ultraGridRow.Cells("Dogleg").Appearance.ForeColor = Color.Crimson
									Else
										ultraGridRow.Cells("Dogleg").Appearance.ForeColor = Color.Black
									End If
								Else
									ultraGridRow.Cells("Dogleg").Value = 0
								End If
							End If

						i += 1
						If i = num2 Then
							flag = False
						ElseIf ultraGridRow.HasNextSibling() Then
							ultraGridRow = ultraGridRow.GetSibling(SiblingRow.[Next])
						Else
							flag = False
						End If
						num14 = num17
						num15 = num18
						num16 = num19
					End While
					num3 = CShort(Information.UBound(array12, 1))
					Dim num23 As Short = 0S
					Dim num24 As Short = CShort((Information.UBound(array12, 1) - 1))
					Dim num25 As Short

						num25 = num23
						While num25 <= num24
							' The following expression was wrapped in a checked-expression
							Dim num26 As Double = Me.dot_prod(array12(CInt(num25)).tan, array12(CInt((num25 + 1S))).tan)
							If num26 > 1.0 AndAlso num26 <= CDbl((1F + num4)) Then
								num26 = 1.0
							End If
							If num26 < 0.0 AndAlso num26 >= CDbl((-CDbl(num4))) Then
								num26 = 0.0
							End If
							array12(CInt(num25)).dog = kinemat.ArcCosine(CSng(num26))
							If array12(CInt(num25)).dog > CDbl(num4) Then
								' The following expression was wrapped in a checked-expression
								array12(CInt(num25)).rad = (array12(CInt((num25 + 1S))).m_d - array12(CInt(num25)).m_d) / array12(CInt(num25)).dog
							Else
								array12(CInt(num25)).rad = -9999.0
							End If
							num25 += 1S
						End While

					num3 = CShort(Information.UBound(array12, 1))
					num25 = num3 - 1S
					array12(CInt(num25)).dog = -9999.0
					array12(CInt(num25)).rad = -9999.0
					Dim num27 As Short = 0S
					Dim num28 As Short = num3 - 2S

						num25 = num27
						While num25 <= num28
							If array12(CInt(num25)).dog > CDbl(num4) Then
								' The following expression was wrapped in a checked-expression
								Me.calc_nor(array12(CInt(num25)).nor, array12(CInt(num25)).tan, array12(CInt((num25 + 1S))).tan)
							Else
								array12(CInt(num25)).nor.X = -9999.0
								array12(CInt(num25)).nor.Y = -9999.0
								array12(CInt(num25)).nor.z = -9999.0
							End If
							num25 += 1S
						End While

					num25 = num3 - 1S
					num25 = 0S
					array12(CInt(num25)).pos.X = 0.0
					array12(CInt(num25)).pos.Y = 0.0
					array12(CInt(num25)).pos.z = 0.0
					Dim num29 As Short = 1S
					Dim num30 As Short = num3 - 1S
					num25 = num29
					While num25 <= num30
						If array12(CInt((num25 - 1S))).dog > CDbl(num4) Then
							Me.calc_pos(array12(CInt(num25)).pos, array12(CInt((num25 - 1S))).pos, array12(CInt((num25 - 1S))).tan, array12(CInt((num25 - 1S))).nor, array12(CInt((num25 - 1S))).dog, array12(CInt((num25 - 1S))).rad)
						Else
							Me.calc_str(array12(CInt(num25)).pos, array12(CInt((num25 - 1S))).pos, array12(CInt((num25 - 1S))).tan, array12(CInt(num25)).m_d, array12(CInt((num25 - 1S))).m_d)
						End If
						num25 = num25 + 1S
					End While
					ultraGridRow = Me.ulgDeviationProfile.GetRow(ChildRow.First)
					If ultraGridRow.HasNextSibling() Then
						ultraGridRow = ultraGridRow.GetSibling(SiblingRow.[Next])
						flag = True
					Else
						flag = False
					End If
					i = 0
					array4(i) = 0.0
					array6(i) = 0.0
					While flag

							If bChangeAll Then
								Try
									If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
										Dim num22 As Single = CSng(Math.Round(array12(i).pos.Y, 2))
										ultraGridRow.Cells("NorthSouth").Value = Math.Round(CDbl((num22 * RSWIN_DESC.FT__M)), 2)
										num22 = CSng(Math.Round(array12(i).pos.X, 2))
										ultraGridRow.Cells("EastWest").Value = Math.Round(CDbl((num22 * RSWIN_DESC.FT__M)), 2)
									Else
										ultraGridRow.Cells("NorthSouth").Value = Math.Round(array12(i).pos.Y, 2)
										ultraGridRow.Cells("EastWest").Value = Math.Round(array12(i).pos.X, 2)
									End If
								Catch ex4 As Exception
								End Try
							End If
							Try
								array4(i) = array12(i).pos.X
								array6(i) = array12(i).pos.Y
							Catch ex5 As Exception
							End Try

						i += 1
						If i = CInt((num3 + 1S)) Then
							flag = False
						ElseIf ultraGridRow.HasNextSibling() Then
							ultraGridRow = ultraGridRow.GetSibling(SiblingRow.[Next])
						Else
							flag = False
						End If
					End While
				End If
			Catch ex6 As Exception
			End Try
		End Sub

		Private Sub ShowDeviation_Dogleg_Original(dsDeviationProfile As DataSet, bPlotData As Boolean, Optional bChangeAll As Boolean = False)
			Try
				Dim activeRow As UltraGridRow = Me.ulgDeviationProfile.ActiveRow
				Dim num As Double = 2.0 * Math.Atan(1.0)
				Dim num2 As Integer = dsDeviationProfile.Tables(0).Rows.Count
				Dim num3 As Short = CShort(dsDeviationProfile.Tables(0).Rows.Count)
				Dim array As Double() = New Double(num2 + 1 - 1) {}
				Dim array2 As Double() = New Double(num2 + 1 - 1) {}
				Dim array3 As Double() = New Double(num2 + 1 - 1) {}
				Dim array4 As Double() = New Double(num2 + 1 - 1) {}
				Dim array5 As Double() = New Double(num2 + 1 - 1) {}
				Dim array6 As Double() = New Double(num2 + 1 - 1) {}
				Dim array7 As Double() = New Double(num2 + 1 - 1) {}
				If Me.m_MeasDepth Is Nothing Then
					Me.m_MeasDepth = New Double(num2 + 1 - 1) {}
				End If
				Dim array8 As Double() = New Double(num2 + 1 - 1) {}
				Dim array9 As Double() = New Double(num2 + 1 - 1) {}
				Dim array10 As Double() = New Double(num2 + 1 - 1) {}
				Dim array11 As Single() = New Single(num2 + 1 - 1) {}
				Dim array12 As DeviationProfile.survey_point_type() = New DeviationProfile.survey_point_type(num2 + 1 - 1) {}
				Dim num4 As Single = 1E-06F
				num2 = 0
				Dim num5 As Double = 0.0
				Dim ultraGridRow As UltraGridRow = Me.ulgDeviationProfile.GetRow(ChildRow.First)
				Dim flag As Boolean = True
				Try
					While flag
						Dim ultraGridRow2 As UltraGridRow = ultraGridRow
						If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(ultraGridRow2.Cells("Depth").Value)) And Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(ultraGridRow2.Cells("Inclination").Value)) And Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(ultraGridRow2.Cells("Azimuth").Value)) Then
							Dim num6 As Double = Conversions.ToDouble(ultraGridRow2.Cells("Depth").Value)
							If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
								Dim num7 As Single = CSng(num6)
								CtrlUI.ConvertValue(num7, "f", True)
								num6 = CDbl(num7)
							End If
							Dim text As String = Conversions.ToString(ultraGridRow2.Cells("Azimuth").Value)
							Dim text2 As String = Me.AzimuthCheck(text)
							Dim text3 As String = Me.InclinationCheck(Conversions.ToString(ultraGridRow2.Cells("Inclination").Value))
							If Versioned.IsNumeric(text2) And Versioned.IsNumeric(text3) Then

									Dim num8 As Double = Convert.ToDouble(text3) / 180.0 * 3.141592653589793
									Dim num9 As Double = Convert.ToDouble(text2)
									If num9 < 0.0 Then
										num9 = 360.0 + num9
									End If
									Dim num10 As Double = num9 / 180.0 * 3.141592653589793
									Dim num11 As Double = num6 - num5
									array11(num2) = CSng(num11)
									num5 = num6
									array12(num2).m_d = num6
									array12(num2).inc = num8
									array12(num2).azi = num10
									array7(num2) = num6
									Me.m_MeasDepth(num2) = array7(num2)
									array8(num2) = num11 * Math.Sin(num8) * Math.Sin(num10)
									array9(num2) = num11 * Math.Sin(num8) * Math.Cos(num10)
									array10(num2) = num11 * Math.Cos(num8)
									array(num2) = Math.Sin(num8) * Math.Sin(num10)
									array2(num2) = Math.Sin(num8) * Math.Cos(num10)
									array3(num2) = Math.Cos(num8)
									array12(num2).tan.X = array(num2)
									array12(num2).tan.Y = array2(num2)
									array12(num2).tan.z = array3(num2)

								num2 += 1
							End If
						End If
						If ultraGridRow.HasNextSibling() Then
							ultraGridRow = ultraGridRow.GetSibling(SiblingRow.[Next])
						Else
							flag = False
						End If
					End While
				Catch ex As Exception
				End Try
				If num2 > 1 Then
					array = CType(Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(CType(array, Array), New Double(num2 - 1 + 1 - 1) {}), Double())
					array2 = CType(Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(CType(array2, Array), New Double(num2 - 1 + 1 - 1) {}), Double())
					array3 = CType(Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(CType(array3, Array), New Double(num2 - 1 + 1 - 1) {}), Double())
					array12 = CType(Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(CType(array12, Array), New DeviationProfile.survey_point_type(num2 - 1 + 1 - 1) {}), DeviationProfile.survey_point_type())
					array4 = CType(Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(CType(array4, Array), New Double(num2 - 1 + 1 - 1) {}), Double())
					array5 = CType(Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(CType(array5, Array), New Double(num2 - 1 + 1 - 1) {}), Double())
					array6 = CType(Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(CType(array6, Array), New Double(num2 - 1 + 1 - 1) {}), Double())
					ultraGridRow = Me.ulgDeviationProfile.GetRow(ChildRow.First)
					If ultraGridRow.HasNextSibling() Then
						ultraGridRow = ultraGridRow.GetSibling(SiblingRow.[Next])
						flag = True
					Else
						flag = False
					End If
					Dim num12 As Integer = 1
					array5(0) = 0.0
					While flag

							' The following expression was wrapped in a checked-expression
							array(num12) += array(num12 - 1)
							array2(num12) += array2(num12 - 1)
							array3(num12) += array3(num12 - 1)
							array8(num12) += array8(num12 - 1)
							array9(num12) += array9(num12 - 1)
							array10(num12) += array10(num12 - 1)
							If bChangeAll Then
								If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
									Dim num13 As Single = CSng(array10(num12))
									ultraGridRow.Cells("TVDepth").Value = Math.Round(CDbl((num13 * RSWIN_DESC.FT__M)), 2)
								Else
									ultraGridRow.Cells("TVDepth").Value = Math.Round(array10(num12), 2)
								End If
							End If
							Try
								array5(num12) = Math.Round(array10(num12), 2)
							Catch ex2 As Exception
							End Try

						num12 += 1
						If num12 = num2 Then
							flag = False
						ElseIf ultraGridRow.HasNextSibling() Then
							ultraGridRow = ultraGridRow.GetSibling(SiblingRow.[Next])
						Else
							flag = False
						End If
					End While
				End If
				If num2 > 2 Then
					ultraGridRow = Me.ulgDeviationProfile.GetRow(ChildRow.First)
					ultraGridRow.Cells("Dogleg").Value = 0
					If ultraGridRow.HasNextSibling() Then
						ultraGridRow = ultraGridRow.GetSibling(SiblingRow.[Next])
						flag = True
					Else
						flag = False
					End If
					Dim num14 As Double = 0.0
					Dim num15 As Double = 0.0
					Dim num16 As Double = 1.0
					Dim num12 As Integer = 1
					While flag
						Dim num17 As Double
						Dim num18 As Double
						Dim num19 As Double

							' The following expression was wrapped in a checked-expression
							num17 = array(num12) - array(num12 - 1)
							num18 = array2(num12) - array2(num12 - 1)
							num19 = array3(num12) - array3(num12 - 1)
							Dim num20 As Double = num14 * num17 + num15 * num18 + num16 * num19
							Dim num21 As Double
							If num20 <> 0.0 Then
								num21 = kinemat.ArcCosine(CSng(num20))
							Else
								num21 = 0.0
							End If
							If num21 < 0.0 Then
								num21 += 2.0 * num
							End If
							If Not bPlotData Then
								If array11(num12) <> 0F Then
									ultraGridRow.Cells("Dogleg").Value = Math.Round(num21 / num * 90.0 / CDbl(array11(num12)) * 100.0, 2)
									If Operators.ConditionalCompareObjectGreaterEqual(ultraGridRow.Cells("Dogleg").Value, 15, False) Then
										ultraGridRow.Cells("Dogleg").Appearance.ForeColor = Color.Crimson
									Else
										ultraGridRow.Cells("Dogleg").Appearance.ForeColor = Color.Black
									End If
								Else
									ultraGridRow.Cells("Dogleg").Value = 0
								End If
							End If

						num12 += 1
						If num12 = num2 Then
							flag = False
						ElseIf ultraGridRow.HasNextSibling() Then
							ultraGridRow = ultraGridRow.GetSibling(SiblingRow.[Next])
						Else
							flag = False
						End If
						num14 = num17
						num15 = num18
						num16 = num19
					End While
					num3 = CShort(Information.UBound(array12, 1))
					Dim num22 As Short = 0S
					Dim num23 As Short = CShort((Information.UBound(array12, 1) - 1))
					Dim num24 As Short

						num24 = num22
						While num24 <= num23
							' The following expression was wrapped in a checked-expression
							Dim num25 As Double = Me.dot_prod(array12(CInt(num24)).tan, array12(CInt((num24 + 1S))).tan)
							If num25 > 1.0 AndAlso num25 <= CDbl((1F + num4)) Then
								num25 = 1.0
							End If
							If num25 < 0.0 AndAlso num25 >= CDbl((-CDbl(num4))) Then
								num25 = 0.0
							End If
							array12(CInt(num24)).dog = kinemat.ArcCosine(CSng(num25))
							If array12(CInt(num24)).dog > CDbl(num4) Then
								' The following expression was wrapped in a checked-expression
								array12(CInt(num24)).rad = (array12(CInt((num24 + 1S))).m_d - array12(CInt(num24)).m_d) / array12(CInt(num24)).dog
							Else
								array12(CInt(num24)).rad = -9999.0
							End If
							num24 += 1S
						End While

					num3 = CShort(Information.UBound(array12, 1))
					num24 = num3 - 1S
					array12(CInt(num24)).dog = -9999.0
					array12(CInt(num24)).rad = -9999.0
					Dim num26 As Short = 0S
					Dim num27 As Short = num3 - 2S

						num24 = num26
						While num24 <= num27
							If array12(CInt(num24)).dog > CDbl(num4) Then
								' The following expression was wrapped in a checked-expression
								Me.calc_nor(array12(CInt(num24)).nor, array12(CInt(num24)).tan, array12(CInt((num24 + 1S))).tan)
							Else
								array12(CInt(num24)).nor.X = -9999.0
								array12(CInt(num24)).nor.Y = -9999.0
								array12(CInt(num24)).nor.z = -9999.0
							End If
							num24 += 1S
						End While

					num24 = num3 - 1S
					num24 = 0S
					array12(CInt(num24)).pos.X = 0.0
					array12(CInt(num24)).pos.Y = 0.0
					array12(CInt(num24)).pos.z = 0.0
					Dim num28 As Short = 1S
					Dim num29 As Short = num3 - 1S
					num24 = num28
					While num24 <= num29
						If array12(CInt((num24 - 1S))).dog > CDbl(num4) Then
							Me.calc_pos(array12(CInt(num24)).pos, array12(CInt((num24 - 1S))).pos, array12(CInt((num24 - 1S))).tan, array12(CInt((num24 - 1S))).nor, array12(CInt((num24 - 1S))).dog, array12(CInt((num24 - 1S))).rad)
						Else
							Me.calc_str(array12(CInt(num24)).pos, array12(CInt((num24 - 1S))).pos, array12(CInt((num24 - 1S))).tan, array12(CInt(num24)).m_d, array12(CInt((num24 - 1S))).m_d)
						End If
						num24 = num24 + 1S
					End While
					ultraGridRow = Me.ulgDeviationProfile.GetRow(ChildRow.First)
					If ultraGridRow.HasNextSibling() Then
						ultraGridRow = ultraGridRow.GetSibling(SiblingRow.[Next])
						flag = True
					Else
						flag = False
					End If
					num12 = 0
					array4(num12) = 0.0
					array6(num12) = 0.0
					While flag

							If bChangeAll Then
								Try
									If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
										Dim num13 As Single = CSng(Math.Round(array12(num12).pos.Y, 2))
										ultraGridRow.Cells("NorthSouth").Value = Math.Round(CDbl((num13 * RSWIN_DESC.FT__M)), 2)
										num13 = CSng(Math.Round(array12(num12).pos.X, 2))
										ultraGridRow.Cells("EastWest").Value = Math.Round(CDbl((num13 * RSWIN_DESC.FT__M)), 2)
									Else
										ultraGridRow.Cells("NorthSouth").Value = Math.Round(array12(num12).pos.Y, 2)
										ultraGridRow.Cells("EastWest").Value = Math.Round(array12(num12).pos.X, 2)
									End If
								Catch ex3 As Exception
								End Try
							End If
							Try
								array4(num12) = array12(num12).pos.X
								array6(num12) = array12(num12).pos.Y
							Catch ex4 As Exception
							End Try

						num12 += 1
						If num12 = CInt((num3 + 1S)) Then
							flag = False
						ElseIf ultraGridRow.HasNextSibling() Then
							ultraGridRow = ultraGridRow.GetSibling(SiblingRow.[Next])
						Else
							flag = False
						End If
					End While
				End If
			Catch ex5 As Exception
			End Try
		End Sub

		Private Sub chkWellHead_Click()
		End Sub

		Private Sub cmdZoomIn_Click_Save()
		End Sub

		Private Sub AddEntry(ByRef mdsDeviationProfile As DataSet, ENTRYNUMBER As Object, Depth As Object, Inclination As Object, Azimuth As Object, DOGLEG As Object, TVDEPTH As Object, TVNORTHSOUTH As Object, TVEASTWEST As Object)
			Dim dataRow As DataRow = mdsDeviationProfile.Tables(0).NewRow()
			dataRow("EntryNumber") = RuntimeHelpers.GetObjectValue(ENTRYNUMBER)
			dataRow("Depth") = RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.ConditionalCompareObjectNotEqual(Depth, 0, False), RuntimeHelpers.GetObjectValue(Depth), DBNull.Value))
			dataRow("Inclination") = RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.ConditionalCompareObjectNotEqual(Inclination, 0, False), RuntimeHelpers.GetObjectValue(Inclination), DBNull.Value))
			dataRow("Azimuth") = RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.ConditionalCompareObjectNotEqual(Azimuth, 0, False), RuntimeHelpers.GetObjectValue(Azimuth), DBNull.Value))
			dataRow("Dogleg") = RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.ConditionalCompareObjectNotEqual(DOGLEG, 0, False), RuntimeHelpers.GetObjectValue(DOGLEG), DBNull.Value))
			dataRow("TVDepth") = RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.ConditionalCompareObjectNotEqual(TVDEPTH, 0, False), RuntimeHelpers.GetObjectValue(TVDEPTH), DBNull.Value))
			dataRow("NorthSouth") = RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.ConditionalCompareObjectNotEqual(TVNORTHSOUTH, 0, False), RuntimeHelpers.GetObjectValue(TVNORTHSOUTH), DBNull.Value))
			dataRow("EastWest") = RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.ConditionalCompareObjectNotEqual(TVEASTWEST, 0, False), RuntimeHelpers.GetObjectValue(TVEASTWEST), DBNull.Value))
			mdsDeviationProfile.Tables(0).Rows.Add(dataRow)
		End Sub

		Private Sub AddEntryToDataSet(ByRef mdsDeviationProfile As DataSet, ENTRYNUMBER As Object, Depth As Object, Inclination As Object, Azimuth As Object, DOGLEG As Object, TVDEPTH As Object, TVNORTHSOUTH As Object, TVEASTWEST As Object)
			Try
				Dim dataRow As DataRow = mdsDeviationProfile.Tables(0).NewRow()
				dataRow("EntryNumber") = RuntimeHelpers.GetObjectValue(ENTRYNUMBER)
				If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(Depth)) Then
					dataRow("Depth") = RuntimeHelpers.GetObjectValue(Depth)
				ElseIf Operators.ConditionalCompareObjectEqual(ENTRYNUMBER, 1, False) Then
					dataRow("Depth") = 0
				Else
					dataRow("Depth") = DBNull.Value
				End If
				If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(Inclination)) Then
					dataRow("Inclination") = RuntimeHelpers.GetObjectValue(Inclination)
				ElseIf Operators.ConditionalCompareObjectEqual(ENTRYNUMBER, 1, False) Then
					dataRow("Inclination") = "0"
				Else
					dataRow("Inclination") = DBNull.Value
				End If
				If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(Azimuth)) Then
					dataRow("Azimuth") = RuntimeHelpers.GetObjectValue(Azimuth)
				ElseIf Operators.ConditionalCompareObjectEqual(ENTRYNUMBER, 1, False) Then
					dataRow("Azimuth") = "0"
				Else
					dataRow("Azimuth") = DBNull.Value
				End If
				If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(DOGLEG)) Then
					dataRow("Dogleg") = RuntimeHelpers.GetObjectValue(DOGLEG)
				Else
					dataRow("Dogleg") = DBNull.Value
				End If
				If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(TVDEPTH)) Then
					dataRow("TVDepth") = RuntimeHelpers.GetObjectValue(TVDEPTH)
				Else
					dataRow("TVDepth") = DBNull.Value
				End If
				If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(TVNORTHSOUTH)) Then
					dataRow("NorthSouth") = RuntimeHelpers.GetObjectValue(TVNORTHSOUTH)
				Else
					dataRow("NorthSouth") = DBNull.Value
				End If
				If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(TVEASTWEST)) Then
					dataRow("EastWest") = RuntimeHelpers.GetObjectValue(TVEASTWEST)
				Else
					dataRow("EastWest") = DBNull.Value
				End If
				Try
					mdsDeviationProfile.Tables(0).Rows.Add(dataRow)
				Catch ex As Exception
				End Try
			Catch ex2 As Exception
			End Try
		End Sub

		Private Sub RenumberDataset(ByRef mdsDeviationProfile As DataSet)
			Dim num As Integer = 1
			Try
				For Each obj As Object In mdsDeviationProfile.Tables(0).Rows
					Dim dataRow As DataRow = CType(obj, DataRow)
					dataRow("EntryNumber") = num
					num += 1
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			mdsDeviationProfile.AcceptChanges()
		End Sub

		Private Sub NumOfEntriesSelected(ByRef iStart As Short)
			Try
				Dim numEntries As Short = Me.NumEntries
				Dim num As Short = RSWIN_DESC.iEntryNum - 1S
				Dim ulgDeviationProfile As UltraGrid = Me.ulgDeviationProfile
				Dim num2 As Short = iStart
				Dim num3 As Short = iStart + num
				For num4 As Short = num2 To num3
					' The following expression was wrapped in a checked-expression
					Me.miNewEntryNum = num4 + 1S
					Me.AddEntryToDataSet(RSWIN_DESC.mdsDeviationProfile_Edit, Me.miNewEntryNum, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value)
				Next
				Try
					' The following expression was wrapped in a checked-expression
					Dim ultraGridRow As UltraGridRow = Me.ulgDeviationProfile.Rows(CInt((iStart + 1S)))
					If ultraGridRow IsNot Nothing Then
						Me.SelectRow(ultraGridRow, True)
						Me.ulgDeviationProfile.ActiveCell = ultraGridRow.Cells("Depth")
						Me.ulgDeviationProfile.PerformAction(UltraGridAction.ActivateCell)
					End If
				Catch ex As Exception
				End Try
				ini.SaveDataValue("NumEntries", RSWIN_DESC.mdsDeviationProfile_Edit.Tables(0).Rows.Count)
			Catch ex2 As Exception
			End Try
		End Sub

		Private Sub cmdZoomOut_Click_Save()
		End Sub

		Private Sub cmdNumberOfEntries_Click(eventSender As Object, eventArgs As EventArgs)
			Dim dlgDeviationEntries As dlgDeviationEntries = New dlgDeviationEntries()
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
			dlgDeviationEntries.ShowDialog()
			If RSWIN_DESC.iEntryNum <> 0S Then
				' The following expression was wrapped in a checked-expression
				Dim num As Short = CShort(RSWIN_DESC.mdsDeviationProfile_Edit.Tables(0).Rows.Count)
				Me.NumOfEntriesSelected(num)
			End If
		End Sub

		Private Sub cmdPrint_Click(eventSender As Object, eventArgs As EventArgs)
			Try
				If Me.ulgDeviationProfile.Rows.Count > 2 Then
					Dim numberOfLines As Integer
					Me.BuildDeviationProfileXML(numberOfLines)
					Me.rptDeviationProfile = New rptDeviationProfile()
					Dim xmldataSource As XMLDataSource = New XMLDataSource()
					xmldataSource.LoadXML(RSWIN_DESC.sDeviationProfileXML)
					Me.rptDeviationProfile.ds = xmldataSource
					Me.rptDeviationProfile.DataSource = xmldataSource
					Me.rptDeviationProfile.ds.ValidateOnParse = True
					Me.rptDeviationProfile.ds.RecordsetPattern = "//Data/Entries/Row"
					Me.rptDeviationProfile.TotalPageNumber = RSWIN_DESC.rst.NumDevSurveyPages
					Me.rptDeviationProfile.ThisPageNumber = 1
					Me.rptDeviationProfile.NumberOfLines = numberOfLines
					Me.rptDeviationProfile.Run(False)
					Me.rptDeviationProfile.Document.Printer.PrinterSettings = RSWIN_DESC.pd.PrinterSettings
					Me.rptDeviationProfile.Document.Print(False, False)
					Me.rptDeviationProfile = Nothing
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub DeviationProfile_Activated(eventSender As Object, eventArgs As EventArgs)
			Me.Left = 30
			Me.Width = RSWIN_DESC.frmMain.Width - 100
			If Me.Width > 940 Then
				Me.Width = 940
			End If
			Me.Height = RSWIN_DESC.frmMain.Height - 150
			Me.Top = 10
			Me.m_bClosing = False
			Me.picRemoveFocus.Width = Me.Width - 50
			Me.tabInput.Width = Me.picRemoveFocus.Width
			Me.ulgDeviationProfile.Width = Me.tabInput.Width - 70
			Me.picRemoveFocus.Height = Me.Height - 50
			Me.tabInput.Height = Me.picRemoveFocus.Height - 20
			Me.ulgDeviationProfile.Height = Me.tabInput.Height - 75
			If Me.tmp_PumpDepth = 0.0 Then
				Me.txtTempLength.Tag = "fem"
				Me.txtTempLength.Text = Conversions.ToString(RSWIN_DESC.rst.PumpDepth)
				Dim txtTempLength As TextBox = Me.txtTempLength
				Dim lblTemp As Label = Me.lblTemp
				Me.TextBox_Change(txtTempLength, lblTemp)
				Me.lblTemp = lblTemp
				Me.txtTempLength = txtTempLength
				Me.tmp_PumpDepth = CDbl(Convert.ToSingle(Me.txtTempLength.Text))
			End If
			If RSWIN_DESC.mdsDeviationProfile_Edit Is Nothing Then
				Me.LoadDevSurvey()
			End If
			Me.SetStatus()
			Me.bLoadingFrm = False
			Try
				Me.commander1.Buttons(8).Enabled = False
				Me.commander1.Buttons(8).Visible = False
				Me.commander1.Buttons(11).Enabled = False
				Me.commander1.Buttons(11).Visible = False
			Catch ex As Exception
			End Try
			RSWIN_DESC.sCurrentFormName = "DeviationProfile"
		End Sub

		Private Sub Form_Initialize()
			Me.mbFirstResize = True
		End Sub

		Private Sub DeviationProfile_Load(eventSender As Object, eventArgs As EventArgs)
			' The following expression was wrapped in a checked-statement
			Try
				SUPERPRO.NewCheckSentinel(True)
				Me.lblStatus.Text = " "
				RSWIN.GetMeasurementUnit()
				Me.ResetClock()
				Me.m_bClosing = False
				RSWIN_DESC.sCurrentFormName = "DeviationProfile"
				Me.HelpProvider1.HelpNamespace = RSWIN_DESC.HelpNameSpace
				Me.bLoadingFrm = True
				Me.bAnswered = False
				Me.Left = 30
				Me.Width = RSWIN_DESC.frmMain.Width - 100
				If Me.Width > 940 Then
					Me.Width = 940
				End If
				Me.Height = RSWIN_DESC.frmMain.Height - 150
				Me.Top = 10
				Me.picRemoveFocus.Width = Me.Width - 50
				Me.tabInput.Width = Me.picRemoveFocus.Width
				Me.ulgDeviationProfile.Width = Me.tabInput.Width - 70
				Me.picRemoveFocus.Height = Me.Height - 50
				Me.tabInput.Height = Me.picRemoveFocus.Height - 20
				Me.ulgDeviationProfile.Height = Me.tabInput.Height - 75
				Me.tabDirection.Top = Me.ulgDeviationProfile.Top + Me.ulgDeviationProfile.Height + 5
				Me.tabDirection.Left = Me.ulgDeviationProfile.Width + Me.ulgDeviationProfile.Left - Me.tabDirection.Width
				Me.grpDevPlot.Width = Me.Width - 100
				Me.Panel2.Width = Me.grpDevPlot.Width - 20
				Me.Panel1.Width = Me.grpDevPlot.Width - 20
				Me.commander1.Width = Me.Panel2.Width - 20
				Me.TChart1.Width = Me.Panel2.Width - 20
				Me.grpDevPlot.Height = Me.Height - 120
				Me.Panel2.Height = Me.grpDevPlot.Height - 110
				Me.TChart1.Height = Me.Panel2.Height - 20
				Me.pnlLegend.Top = Me.Panel2.Height + Me.Panel2.Top
				Me.pnlLegend.Width = Me.TChart1.Width + 20
				Me.Panel2.Left = CInt(Math.Round(CDbl((Me.grpDevPlot.Width - Me.Panel2.Width)) / 2.0))
				Me.TChart1.Left = CInt(Math.Round(CDbl((Me.Panel2.Width - Me.TChart1.Width)) / 2.0))
				Me.Panel_Dogleg.Width = Me.Panel2.Width
				Me.Panel_Dogleg.Left = Me.Panel2.Left
				Me.Panel_Dogleg.Height = Me.grpDevPlot.Height - 30
				Me.ChartFX_DoglegSeverity.Width = Me.TChart1.Width
				Me.ChartFX_DoglegSeverity.Left = Me.TChart1.Left
				Me.ChartFX_DoglegSeverity.Height = Me.Panel_Dogleg.Height - 20
				Try
					Me.commander1.Buttons(8).Enabled = False
					Me.commander1.Buttons(8).Visible = False
					Me.commander1.Buttons(11).Enabled = False
					Me.commander1.Buttons(11).Visible = False
				Catch ex As Exception
				End Try
				Me.TChart1.Visible = False
				Me.commander1.Visible = False
				Me.pnlLegend.Visible = False
				Me.btnResetPlot.Visible = False
				Me.bShiftDown = False
				Me.bCtrlDown = False
				Me.m_InclinationKeyDnKeyCode = Nothing
				Me.m_AzimuthKeyDnKeyCode = Nothing
				Me.mbFirstResize = True
				If RSWIN_DESC.SETUP_DISPLAYAZDIRTOOLBAR <> 0S Then
					Me.tabDirection.Visible = True
					Me.tabDirection.BringToFront()
				Else
					Me.tabDirection.Visible = False
				End If
				RSWIN_DESC.iEntryInterval = 0S
				If RSWIN_DESC.bIntVersion Then
					If RSWIN_DESC.bChangeCultures Then
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
					If RSWIN_DESC.bReadResXFile Then
						Util.AssignValuesToControls(Me)
					End If
				End If
				Me.LoadDevSurvey()
				If RSWIN_DESC.bIntVersion AndAlso RSWIN_DESC.bWriteResXFile Then
					Util.OpenResourceWriter(Me.Name)
					Util.WriteControlStrings(Me, Me.ToolTip1)
					RSWIN_DESC.RwX.AddResource("Axes.Depth.Title", "South - North")
					RSWIN_DESC.RwX.AddResource("Axes.Bottom.Title", "East - West")
					RSWIN_DESC.RwX.AddResource("Axes.Left.Title", "True Vertical Depth")
					Util.CloseResourceWriter()
				End If
				If Me.tmp_PumpDepth = 0.0 Then
					Me.txtTempLength.Tag = "fem"
					Me.txtTempLength.Text = Conversions.ToString(RSWIN_DESC.rst.PumpDepth)
					Dim txtTempLength As TextBox = Me.txtTempLength
					Dim lblTemp As Label = Me.lblTemp
					Me.TextBox_Change(txtTempLength, lblTemp)
					Me.lblTemp = lblTemp
					Me.txtTempLength = txtTempLength
					Me.tmp_PumpDepth = CDbl(Convert.ToSingle(Me.txtTempLength.Text))
				End If
				If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
					Me.fMult = 1F
				Else
					Me.fMult = RSWIN_DESC.FT__M
				End If
				Try
					Me.commander1.Buttons(8).Enabled = False
					Me.commander1.Buttons(8).Visible = False
					Me.commander1.Buttons(11).Enabled = False
					Me.commander1.Buttons(11).Visible = False
				Catch ex2 As Exception
				End Try
				Me.SetStatus()
				Me.CenterForm()
				Me.ValidateDeviationProfile()
			Catch ex3 As Exception
				Me.bLoadingFrm = False
			End Try
		End Sub

		Private Sub LoadDevSurvey()
			If RSWIN_DESC.NewData(5) <> 0S Then
				Me.InitDeviationProfile()
				Me.bNew = True
			Else
				Me.LoadDeviationProfile()
				Me.bNew = False
			End If
			RSWIN_DESC.mdsDeviationProfile_Edit = Nothing
			MImpred.InitSurveyDataset(RSWIN_DESC.mdsDeviationProfile_Edit, Nothing)
			If RSWIN_DESC.mdsDeviationProfile IsNot Nothing Then
				MImpred.CopyDatasets(RSWIN_DESC.mdsDeviationProfile, RSWIN_DESC.mdsDeviationProfile_Edit, RSWIN_DESC.SETUP_MeasurementSystem <> 1, False)
			End If
			Dim ulgDeviationProfile As UltraGrid = Me.ulgDeviationProfile
			ulgDeviationProfile.DataSource = RSWIN_DESC.mdsDeviationProfile_Edit
			ulgDeviationProfile.Rows.Refresh(RefreshRow.FireInitializeRow, True)
			Dim ulgDeviationProfile2 As UltraGrid = Me.ulgDeviationProfile
			CtrlUI.Grid_SetLabels(ulgDeviationProfile2, True)
			Me.ulgDeviationProfile = ulgDeviationProfile2
			Me.SetDoglegColumnHeader()
			Dim flag As Boolean = Me.CheckDeviationProfile()
			If flag Then
				Me.ShowDeviation_Dogleg(CType(Me.ulgDeviationProfile.DataSource, DataSet), False, False)
				Dim dsDeviationProfile As DataSet = CType(Me.ulgDeviationProfile.DataSource, DataSet)
				Dim bPlotData As Boolean = False
				Dim obj As Object
				Dim num As Short = Conversions.ToShort(obj)
				Me.ShowDeviation_TVD(dsDeviationProfile, bPlotData, num)
				obj = num
				Me.ulgDeviationProfile.ActiveRow = Me.ulgDeviationProfile.GetRow(ChildRow.First)
			End If
			Me.bLoadingFrm = False
		End Sub

		Public Sub UpdateRecordSet(ThisCell As UltraGridCell, bConvert As Boolean, bEnglish As Boolean)
			Dim oleDbDataAdapter As OleDbDataAdapter = New OleDbDataAdapter()
			Dim oleDbCommand As OleDbCommand = New OleDbCommand()
			Dim flag As Boolean = False
			Try
				If RSWIN_DESC.mdsDeviationProfile IsNot Nothing Then
					Dim mdsDeviationProfile As DataSet = RSWIN_DESC.mdsDeviationProfile
					Try
						For Each obj As Object In mdsDeviationProfile.Tables(0).Rows
							Dim dataRow As DataRow = CType(obj, DataRow)
							Dim num As Short = Conversions.ToShort(dataRow("ENTRYNUMBER"))
							If Operators.ConditionalCompareObjectEqual(ThisCell.Row.Cells("EntryNumber").Value, num, False) Then
								If Operators.CompareString(ThisCell.Column.Key, "Depth", False) = 0 Then
									Dim num2 As Single = Conversions.ToSingle(ThisCell.Row.Cells("Depth").Value)
									If bConvert Then
										CtrlUI.ConvertValue(num2, "f", bEnglish)
									End If
									dataRow("Depth") = num2
									flag = True
									Exit For
								End If
								If Operators.CompareString(ThisCell.Column.Key, "Inclination", False) = 0 Then
									dataRow("Inclination") = RuntimeHelpers.GetObjectValue(ThisCell.Row.Cells("Inclination").Value)
									flag = True
									Exit For
								End If
								If Operators.CompareString(ThisCell.Column.Key, "Azimuth", False) = 0 Then
									dataRow("Azimuth") = RuntimeHelpers.GetObjectValue(ThisCell.Row.Cells("Azimuth").Value)
									flag = True
									Exit For
								End If
								Exit For
							End If
						Next
					Finally
						Dim enumerator As IEnumerator
						If TypeOf enumerator Is IDisposable Then
							TryCast(enumerator, IDisposable).Dispose()
						End If
					End Try
					If flag Then
						RSWIN_DESC.mdsDeviationProfile.AcceptChanges()
					End If
				End If
			Catch ex As Exception
			End Try
		End Sub

		Public Sub UpdateAllRecordSets(bConvert As Boolean, bEnglish As Boolean)
			Dim oleDbDataAdapter As OleDbDataAdapter = New OleDbDataAdapter()
			MImpred.InitSurveyDataset(RSWIN_DESC.mdsDeviationProfile, Nothing)
			oleDbDataAdapter.Fill(RSWIN_DESC.mdsDeviationProfile)
			Dim oleDbCommandBuilder As OleDbCommandBuilder = New OleDbCommandBuilder(oleDbDataAdapter)
			Dim ultraGridRow As UltraGridRow = Me.ulgDeviationProfile.GetRow(ChildRow.First)
			Dim flag As Boolean = True
			While flag
				Dim ultraGridRow2 As UltraGridRow = ultraGridRow
				Dim text As String = ""
				If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(ultraGridRow2.Cells("Depth").Value)) AndAlso Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(ultraGridRow2.Cells("Depth").Value)) Then
					Dim num As Single = Conversions.ToSingle(ultraGridRow2.Cells("Depth").Value)
					If bConvert Then
						CtrlUI.ConvertValue(num, "f", bEnglish)
					End If
					text = Conversion.Str(num)
				End If
				If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(ultraGridRow2.Cells("Azimuth").Value)) Then
					Dim text2 As String = Conversions.ToString(ultraGridRow2.Cells("Azimuth").Value)
					Dim text3 As String = Me.AzimuthCheck(text2)
				End If
				Dim text4 As String
				If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(ultraGridRow2.Cells("Inclination").Value)) Then
					text4 = Me.InclinationCheck(Conversions.ToString(ultraGridRow2.Cells("Inclination").Value))
				Else
					text4 = ""
				End If
				Dim dataRow As DataRow = RSWIN_DESC.mdsDeviationProfile.Tables(0).NewRow()
				dataRow("EntryNumber") = RuntimeHelpers.GetObjectValue(ultraGridRow2.Cells("EntryNumber").Value)
				If Versioned.IsNumeric(text) Then
					dataRow("Depth") = Convert.ToSingle(text)
				Else
					dataRow("Depth") = DBNull.Value
				End If
				dataRow("Inclination") = RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.CompareString(text4, "", False) <> 0, text4, DBNull.Value))
				dataRow("Azimuth") = RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.CompareString(text4, "", False) <> 0, text4, DBNull.Value))
				dataRow("Dogleg") = DBNull.Value
				dataRow("TVDepth") = DBNull.Value
				dataRow("NorthSouth") = DBNull.Value
				dataRow("EastWest") = DBNull.Value
				RSWIN_DESC.mdsDeviationProfile.Tables(0).Rows.Add(dataRow)
				If ultraGridRow.HasNextSibling() Then
					ultraGridRow = ultraGridRow.GetSibling(SiblingRow.[Next])
				Else
					flag = False
				End If
			End While
			Dim num2 As Integer = oleDbDataAdapter.Update(RSWIN_DESC.mdsDeviationProfile)
			Dim flag2 As Boolean = Me.StoreTempDeviationProfile(RSWIN_DESC.mdsDeviationProfile, False)
		End Sub

		Private Sub DeviationProfile_Resize(eventSender As Object, eventArgs As EventArgs)
			' The following expression was wrapped in a checked-statement
			Me.picRemoveFocus.Width = Me.Width - 50
			Me.tabInput.Width = Me.picRemoveFocus.Width
			Me.ulgDeviationProfile.Width = Me.tabInput.Width - 70
			Me.picRemoveFocus.Height = Me.Height - 50
			Me.tabInput.Height = Me.picRemoveFocus.Height - 20
			Me.ulgDeviationProfile.Height = Me.tabInput.Height - 75
			Me.tabDirection.Top = Me.ulgDeviationProfile.Top + Me.ulgDeviationProfile.Height + 5
			Me.tabDirection.Left = Me.ulgDeviationProfile.Width + Me.ulgDeviationProfile.Left - Me.tabDirection.Width
			Me.grpDevPlot.Width = Me.Width - 100
			Me.Panel2.Width = Me.grpDevPlot.Width - 20
			Me.Panel1.Width = Me.grpDevPlot.Width - 20
			Me.commander1.Width = Me.Panel2.Width - 20
			Me.TChart1.Width = Me.Panel2.Width - 20
			Me.grpDevPlot.Height = Me.Height - 120
			Me.Panel2.Height = Me.grpDevPlot.Height - 110
			Me.TChart1.Height = Me.Panel2.Height - 20
			Me.pnlLegend.Top = Me.Panel2.Height + Me.Panel2.Top
			Me.pnlLegend.Width = Me.TChart1.Width + 20
			Me.Panel2.Left = CInt(Math.Round(CDbl((Me.grpDevPlot.Width - Me.Panel2.Width)) / 2.0))
			Me.TChart1.Left = CInt(Math.Round(CDbl((Me.Panel2.Width - Me.TChart1.Width)) / 2.0))
			Me.Panel_Dogleg.Width = Me.Panel2.Width
			Me.Panel_Dogleg.Left = Me.Panel2.Left
			Me.Panel_Dogleg.Height = Me.grpDevPlot.Height - 30
			Me.ChartFX_DoglegSeverity.Width = Me.TChart1.Width
			Me.ChartFX_DoglegSeverity.Left = Me.TChart1.Left
			Me.ChartFX_DoglegSeverity.Height = Me.Panel_Dogleg.Height - 20
			Me.CenterForm()
			Debug.WriteLine(Me.Width)
		End Sub

		Private Function CheckValidSurveyDepth(ByRef mdsDeviationProfile As DataSet) As Boolean
			Dim num As Integer
			Dim flag2 As Boolean
			Dim num6 As Integer
			Dim obj2 As Object
			Try
				ProjectData.ClearProjectError()
				num = 2
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				Dim num2 As Double = 0.0
				Dim num3 As Short = 1S
				Dim numRods As Short = rst.NumRods
				For num4 As Short = num3 To numRods
					num2 += CDbl(rst.Sections(CInt(num4)).length)
				Next
				Dim flag As Boolean = True
				Dim num5 As Single = 0F
				Dim enumerator As IEnumerator = mdsDeviationProfile.Tables(0).Rows.GetEnumerator()
				While enumerator.MoveNext()
					Dim obj As Object = enumerator.Current
					Dim dataRow As DataRow = CType(obj, DataRow)
					If Operators.ConditionalCompareObjectLess(num5, dataRow("Depth"), False) Then
						num5 = Conversions.ToSingle(dataRow("Depth"))
					End If
				End While
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
				If num2 > CDbl(num5) Then
					flag = False
				End If
				flag2 = flag
				IL_DB:
				GoTo IL_122
				IL_DD:
				num6 = -1
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_F3:
			Catch obj3 When endfilter(TypeOf obj2 Is Exception And num <> 0 And num6 = 0)
				Dim ex As Exception = CType(obj3, Exception)
				GoTo IL_DD
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_122:
			Dim result As Boolean = flag2
			If num6 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		Private Function CheckForValidValues(mdsDeviationProfile As DataSet, ByRef bOkToPumpDepth As Boolean, iDSSet As Integer) As Boolean
			Dim num As Integer
			Dim flag2 As Boolean
			Dim num3 As Integer
			Dim obj2 As Object
			Try
				ProjectData.ClearProjectError()
				num = 2
				Dim flag As Boolean = True
				bOkToPumpDepth = False
				Dim num2 As Single
				If iDSSet = 0 Then
					num2 = CSng(Me.tmp_PumpDepth)
				Else
					num2 = RSWIN_DESC.rst.PumpDepth
				End If
				Dim enumerator As IEnumerator = mdsDeviationProfile.Tables(0).Rows.GetEnumerator()
				While enumerator.MoveNext()
					Dim obj As Object = enumerator.Current
					Dim dataRow As DataRow = CType(obj, DataRow)
					If Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectGreaterEqual(dataRow("Depth"), num2, False), flag)) Then
						bOkToPumpDepth = True
					End If
					If Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow("Depth"))) Or Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow("Inclination"))) Or Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow("Azimuth"))) Then
						flag = False
					End If
				End While
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
				flag2 = flag
				IL_EA:
				GoTo IL_131
				IL_EC:
				num3 = -1
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_102:
			Catch obj3 When endfilter(TypeOf obj2 Is Exception And num <> 0 And num3 = 0)
				Dim ex As Exception = CType(obj3, Exception)
				GoTo IL_EC
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_131:
			Dim result As Boolean = flag2
			If num3 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		Public Sub SaveDeviationSurvey()
			If RSWIN_DESC.mdsDeviationProfile_Edit IsNot Nothing Then
				MImpred.InitSurveyDataset(RSWIN_DESC.mdsDeviationProfile, Nothing)
				MImpred.CopyDatasets(RSWIN_DESC.mdsDeviationProfile_Edit, RSWIN_DESC.mdsDeviationProfile, RSWIN_DESC.SETUP_MeasurementSystem <> 1, True)
				Dim flag As Boolean = Me.StoreTempDeviationProfile(RSWIN_DESC.mdsDeviationProfile, False)
			End If
		End Sub

		Public Sub SaveDeviationSurvey2()
			If RSWIN_DESC.mdsDeviationProfile_Edit IsNot Nothing Then
				MImpred.InitSurveyDataset(RSWIN_DESC.mdsDeviationProfile, Nothing)
				MImpred.CopyDatasets2(RSWIN_DESC.mdsDeviationProfile_Edit, RSWIN_DESC.mdsDeviationProfile, RSWIN_DESC.SETUP_MeasurementSystem <> 1, True)
				Dim flag As Boolean = Me.StoreTempDeviationProfile(RSWIN_DESC.mdsDeviationProfile, False)
			End If
		End Sub

		Private Sub DeviationProfile_Closing(sender As Object, e As CancelEventArgs)
			Me.m_bClosing = True
			If RSWIN_DESC.mdsDeviationProfile_Edit IsNot Nothing Then
				Dim flag2 As Boolean
				Dim flag As Boolean = Me.CheckForValidValues(RSWIN_DESC.mdsDeviationProfile_Edit, flag2, 0)
				If Not flag And Not flag2 And RSWIN_DESC.mdsDeviationProfile_Edit.Tables(0).Rows.Count > 0 Then
					Interaction.MsgBox("NULL values for Depth, Inclination or Azimuth are not allowed. Please review the data!", MsgBoxStyle.OKOnly, Nothing)
					e.Cancel = True
					Return
				End If
				If Not flag AndAlso flag2 Then
					Me.SaveDeviationSurvey2()
				Else
					Me.SaveDeviationSurvey()
				End If
				Me.ulgDeviationProfile.Visible = True
				If RSWIN_DESC.mdsDeviationProfile_Edit.Tables(0).Rows.Count > 0 Then
					Dim num As Double = 0.0
					Dim num2 As Short = 1S
					Dim numRods As Short = RSWIN_DESC.rst.NumRods
					For num3 As Short = num2 To numRods
						num += CDbl(RSWIN_DESC.rst.Sections(CInt(num3)).length)
					Next
					Dim mdsDeviationProfile_Edit As DataSet = RSWIN_DESC.mdsDeviationProfile_Edit
					If mdsDeviationProfile_Edit.Tables(0).Rows.Count > 0 Then
						Dim lastDepth As Single = Util.GetLastDepth(RSWIN_DESC.mdsDeviationProfile_Edit, True, 0)
						If num > CDbl(lastDepth) And num - CDbl(lastDepth) > 50.0 Then
							Dim msg As String = Me.sDYWFill
							Dim bDefaultYes As Boolean = False
							Dim flag3 As Boolean = False
							If Not Util.YesNo(msg, bDefaultYes, flag3) Then
								Return
							End If
							Dim dataRow As DataRow
							Dim num4 As Single = Conversions.ToSingle(dataRow("Depth"))
							Dim num5 As Single = Conversions.ToSingle(dataRow("Inclination"))
							Dim num6 As Single = Conversions.ToSingle(dataRow("Azimuth"))
							Dim num7 As Single = 0F
							Dim num8 As Short = 1S
							Dim num9 As Single = 0F
							Dim num10 As Single = Conversions.ToSingle(dataRow("Depth"))
							Try
								For Each obj As Object In RSWIN_DESC.mdsDeviationProfile_Edit.Tables(0).Rows
									dataRow = CType(obj, DataRow)
									num8 += 1S
									num7 += num10 - num9
									num9 = num10
									num10 = Conversions.ToSingle(dataRow("Depth"))
								Next
							Finally
								Dim enumerator As IEnumerator
								If TypeOf enumerator Is IDisposable Then
									TryCast(enumerator, IDisposable).Dispose()
								End If
							End Try
							num8 -= 1S
							Dim num11 As Short
							If num8 <> 0S Or num7 <> 0F Then
								num11 = CShort(Math.Round(CDbl((num7 / CSng(num8)))))
							Else
								num11 = 100S
							End If
							Dim num12 As Single = num4
							Dim num3 As Short = num8
							Do
								' The following expression was wrapped in a unchecked-expression
								num12 = CSng(CShort(Math.Round(CDbl((num12 + CSng(num11))))))
								num3 += 1S
								Me.AddEntry(RSWIN_DESC.mdsDeviationProfile, num3, Math.Round(CDbl(num12), 2), num5, num6, 0, 0, 0, 0)
							Loop While CDbl(num12) < num
						End If
					End If
				End If
			End If
			RSWIN_DESC.sCurrentFormName = ""
		End Sub

		Private Sub Label_Click(eventSender As Object, eventArgs As EventArgs)
			Dim index As Short = Me.Label.GetIndex(CType(eventSender, Label))
			Dim form As Form = Me
			CtrlUI.Label_Click_1(form, index)
		End Sub

		Private Sub Label_DoubleClick(eventSender As Object, eventArgs As EventArgs)
			Dim index As Short = Me.Label.GetIndex(CType(eventSender, Label))
			Dim form As Form = Me
			CtrlUI.Label_DblClick_1(form, index)
		End Sub

		Private Sub picRemoveFocus_MouseDown(eventSender As Object, eventArgs As MouseEventArgs)
			' The following expression was wrapped in a checked-statement
			Dim num As Short = CShort((eventArgs.Button / MouseButtons.Left))
			Dim num2 As Short = CShort((Control.ModifierKeys / Keys.Shift))
			Dim num3 As Single = CSng(Support.PixelsToTwipsX(CDbl(eventArgs.X)))
			Dim num4 As Single = CSng(Support.PixelsToTwipsY(CDbl(eventArgs.Y)))
			If num <> 1S Or num2 <> 0S Then
				Return
			End If
		End Sub

		Public Sub DisplayInputTab(sControlName As String, sTabName As String)
			Try
				If Operators.CompareString(sControlName, "tabInput", False) = 0 Then
					If Operators.CompareString(sTabName, "_tabInput_TabPage0", False) = 0 Then
						Me.tabInput.[Select]()
						Me.tabInput.SelectedTab = Me._tabInput_TabPage0
					ElseIf Operators.CompareString(sTabName, "_tabInput_TabPage2", False) = 0 Then
						Dim flag As Boolean = Me.CheckDeviationProfile()
						If flag Then
							Me.TChart1.Visible = False
							Me.ShowDeviation_Dogleg(CType(Me.ulgDeviationProfile.DataSource, DataSet), True, False)
							Dim dsDeviationProfile As DataSet = CType(Me.ulgDeviationProfile.DataSource, DataSet)
							Dim bPlotData As Boolean = True
							Dim obj As Object
							Dim num As Short = Conversions.ToShort(obj)
							Me.ShowDeviation_TVD(dsDeviationProfile, bPlotData, num)
							obj = num
							Me.commander1.Visible = True
							Me.btnResetPlot.Visible = True
							Me.lblNoData.Visible = False
						Else
							Me.TChart1.Visible = False
							Me.commander1.Visible = False
							Me.btnResetPlot.Visible = False
							Me.lblNoData.Visible = True
						End If
						Application.DoEvents()
						Me.tabInput.[Select]()
						Me.tabInput.SelectedTab = Me._tabInput_TabPage2
						Application.DoEvents()
					End If
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub tabInput_SelectedIndexChanged(eventSender As Object, eventArgs As EventArgs)
			' The following expression was wrapped in a checked-statement
			If Me.ActiveControl Is Me.tabInput And Not Me.bLoadingFrm Then
				Monitor.Enter(Me.$STATIC$tabInput_SelectedIndexChanged$20211C1241$PreviousTab$Init)
				Try
					If Me.$STATIC$tabInput_SelectedIndexChanged$20211C1241$PreviousTab$Init.State = 0S Then
						Me.$STATIC$tabInput_SelectedIndexChanged$20211C1241$PreviousTab$Init.State = 2S
						Me.$STATIC$tabInput_SelectedIndexChanged$20211C1241$PreviousTab = CShort(Me.tabInput.SelectedIndex)
					ElseIf Me.$STATIC$tabInput_SelectedIndexChanged$20211C1241$PreviousTab$Init.State = 2S Then
						Throw New IncompleteInitialization()
					End If
				Finally
					Me.$STATIC$tabInput_SelectedIndexChanged$20211C1241$PreviousTab$Init.State = 1S
					Monitor.[Exit](Me.$STATIC$tabInput_SelectedIndexChanged$20211C1241$PreviousTab$Init)
				End Try
				Util.BusyCursor()
				Application.DoEvents()
				Dim text As String = Strings.Trim(Me.tabInput.SelectedTab.Text)
				If Operators.CompareString(text, "Plot Survey", False) = 0 Then
					Dim flag As Boolean = Me.CheckDeviationProfile()
					If flag Then
						Me.TChart1.Visible = False
						Me.ShowDeviation_Dogleg(CType(Me.ulgDeviationProfile.DataSource, DataSet), True, False)
						Dim dsDeviationProfile As DataSet = CType(Me.ulgDeviationProfile.DataSource, DataSet)
						Dim bPlotData As Boolean = True
						Dim num2 As Integer
						Dim num As Short = CShort(num2)
						Me.ShowDeviation_TVD(dsDeviationProfile, bPlotData, num)
						num2 = CInt(num)
						Me.commander1.Visible = True
						Me.btnResetPlot.Visible = True
						Me.lblNoData.Visible = False
						Try
							Me.commander1.Buttons(8).Enabled = False
							Me.commander1.Buttons(8).Visible = False
							Me.commander1.Buttons(11).Enabled = False
							Me.commander1.Buttons(11).Visible = False
							GoTo IL_1B7
						Catch ex As Exception
							GoTo IL_1B7
						End Try
					End If
					Me.TChart1.Visible = False
					Me.commander1.Visible = False
					Me.btnResetPlot.Visible = False
					Me.lblNoData.Visible = True
					IL_1B7:
					Application.DoEvents()
				ElseIf Operators.CompareString(text, "Plot Dogleg Severity", False) = 0 Then
					Dim flag As Boolean = Me.CheckDeviationProfile()
					If flag Then
						Me.Panel_Dogleg.Visible = False
						Me.CalcTaperDepths()
						Me.ShowDeviation_Dogleg(CType(Me.ulgDeviationProfile.DataSource, DataSet), False, False)
						Dim dsDeviationProfile2 As DataSet = CType(Me.ulgDeviationProfile.DataSource, DataSet)
						Dim bPlotData2 As Boolean = False
						Dim num2 As Integer
						Dim num As Short = CShort(num2)
						Me.ShowDeviation_TVD(dsDeviationProfile2, bPlotData2, num)
						num2 = CInt(num)
						Application.DoEvents()
						Application.DoEvents()
						Application.DoEvents()
						Application.DoEvents()
						Me.PlotDoglegSeverity()
						Me.Panel_Dogleg.Visible = True
						Me.ChartFX_DoglegSeverity.Visible = True
						Me.lblNoDataAvailable.Visible = False
						Me.lblNoDataAvailable.SendToBack()
					Else
						Me.Panel_Dogleg.Visible = True
						Me.ChartFX_DoglegSeverity.Visible = False
						Me.lblNoDataAvailable.Visible = True
						Me.lblNoDataAvailable.BringToFront()
					End If
				End If
				Me.$STATIC$tabInput_SelectedIndexChanged$20211C1241$PreviousTab = CShort(Me.tabInput.SelectedIndex)
				Application.DoEvents()
				Util.UnbusyCursor()
				Return
			End If
		End Sub

		Private Sub txtAzimuth_TextChanged(eventSender As Object, eventArgs As EventArgs)
			Try
				If Strings.InStr(Me.txtAzimuth.Text, vbTab, CompareMethod.Binary) > 0 Or Strings.InStr(Me.txtAzimuth.Text, vbVerticalTab, CompareMethod.Binary) > 0 Or Strings.InStr(Me.txtAzimuth.Text, vbCr, CompareMethod.Binary) > 0 Then
					Me.txtAzimuth.Text = Conversions.ToString(Me.ulgDeviationProfile.ActiveCell.Row.Cells("Azimuth").Value)
					MessageBox.Show("Please use Edit/Paste to paste Deviation Survey items from Clipboard.", "Paste Error", MessageBoxButtons.OK)
				Else
					Me.Control_SelectedIndexChanged(Me.ActiveControl Is Me.txtAzimuth)
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub txtInclination_Enter(eventSender As Object, eventArgs As EventArgs)
			Me.txtInclination.BackColor = RSWIN_DESC.rgbEditFocus
			Me.txtInclination.TabIndex = Me.ulgDeviationProfile.TabIndex - 1
		End Sub

		Private Sub txtAzimuth_Enter(eventSender As Object, eventArgs As EventArgs)
			Me.txtAzimuth.BackColor = RSWIN_DESC.rgbEditFocus
			Me.txtAzimuth.TabIndex = Me.ulgDeviationProfile.TabIndex - 1
		End Sub

		Private Sub txtInclination_Leave(eventSender As Object, eventArgs As EventArgs)
			Try
				Dim activeCell As UltraGridCell = Me.ulgDeviationProfile.ActiveCell
				Dim num As Short = Conversions.ToShort(Me.ulgDeviationProfile.ActiveCell.Row.Cells("EntryNumber").Value)
				If Operators.CompareString(activeCell.Column.Key, "Inclination", False) = 0 Then
					Dim obj As Object = Me.InclinationCheck(Me.txtInclination.Text)
					Dim flag As Boolean = Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(obj))
					If flag Then
						Dim ulgDeviationProfile As UltraGrid = Me.ulgDeviationProfile
						If Information.IsDBNull(RuntimeHelpers.GetObjectValue(ulgDeviationProfile.ActiveCell.Value)) Then
							ulgDeviationProfile.ActiveCell.Value = Me.txtInclination.Text
						ElseIf Operators.ConditionalCompareObjectNotEqual(ulgDeviationProfile.ActiveCell.Value, Me.txtInclination.Text, False) Then
							ulgDeviationProfile.ActiveCell.Value = Me.txtInclination.Text
						End If
					End If
				End If
				Dim txtInclination As Control = Me.txtInclination
				CtrlUI.Control_LostFocus(txtInclination)
				Me.txtInclination = CType(txtInclination, TextBox)
				txtInclination = Me.txtInclination
				Me.HideControl(txtInclination)
				Me.txtInclination = CType(txtInclination, TextBox)
			Catch ex As Exception
			End Try
		End Sub

		Private Sub ulgDeviationProfile_AfterCellActivate(eventSender As Object, eventArgs As EventArgs)
			Me.SetCommandButtons()
		End Sub

		Private Sub ulgDeviationProfile_AfterCellUpdate(eventSender As Object, eventArgs As CellEventArgs)
			Try
				Dim cell As UltraGridCell = eventArgs.Cell
				If Operators.CompareString(cell.Column.Key, "Depth", False) = 0 Or Operators.CompareString(cell.Column.Key, "Azimuth", False) = 0 Or Operators.CompareString(cell.Column.Key, "Inclination", False) = 0 Then
					If Me.ulgDeviationProfile.ActiveCell IsNot Nothing Then
						Me.UpdateRecordSet(Me.ulgDeviationProfile.ActiveCell, RSWIN_DESC.SETUP_MeasurementSystem <> 1, True)
					End If
					If Not Me.bLoadingFrm Then
						Dim flag As Boolean = Me.CheckDeviationProfile()
						If flag Then
							Me.ShowDeviation_Dogleg(CType(Me.ulgDeviationProfile.DataSource, DataSet), False, False)
							Dim dsDeviationProfile As DataSet = CType(Me.ulgDeviationProfile.DataSource, DataSet)
							Dim bPlotData As Boolean = False
							Dim obj As Object
							Dim num As Short = Conversions.ToShort(obj)
							Me.ShowDeviation_TVD(dsDeviationProfile, bPlotData, num)
							obj = num
						End If
					End If
				End If
				If Me.ActiveControl IsNot Nothing Then
					Me.Control_SelectedIndexChanged(Me.ActiveControl Is Me.ulgDeviationProfile)
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub ulgDeviationProfile_AfterRowActivate(eventSender As Object, eventArgs As EventArgs)
			Me.SetCommandButtons()
		End Sub

		Private Sub ulgDeviationProfile_AfterRowInsert(eventSender As Object, eventArgs As RowEventArgs)
			Try
				Dim num As Short = 0S
				Dim row As UltraGridRow = eventArgs.Row
				Dim ultraGridRow As UltraGridRow = Me.ulgDeviationProfile.GetRow(ChildRow.First)
				While ultraGridRow IsNot Nothing
					Dim ultraGridCell As UltraGridCell = ultraGridRow.Cells("EntryNumber")
					If Information.IsDBNull(RuntimeHelpers.GetObjectValue(ultraGridCell.Value)) Then
						ultraGridCell.Value = num
					ElseIf Operators.ConditionalCompareObjectGreaterEqual(ultraGridCell.Value, Me.miNewEntryNum, False) Then
						ultraGridCell.Value = Operators.AddObject(ultraGridCell.Value, 1)
						num = Conversions.ToShort(ultraGridCell.Value)
					End If
					If Me.bNew And num > 0S Then
						If RSWIN_DESC.iEntryInterval > 0S Then
							Dim ultraGridCell2 As UltraGridCell = ultraGridRow.Cells("Depth")
							ultraGridCell2.Value = CInt((RSWIN_DESC.iEntryInterval * (num - 1S)))
						Else
							Dim ultraGridCell3 As UltraGridCell = ultraGridRow.Cells("Depth")
							ultraGridCell3.Value = DBNull.Value
						End If
					End If
					If ultraGridRow.HasNextSibling() Then
						ultraGridRow = ultraGridRow.GetSibling(SiblingRow.[Next])
					Else
						ultraGridRow = Nothing
					End If
				End While
				row.Cells("EntryNumber").Value = Me.miNewEntryNum
				row.Update()
				Me.miNewEntryNum = 0S
				Me.ResortGrid()
				Me.SelectRow(eventArgs.Row, False)
				Me.SetCommandButtons()
				Me.SaveDeviationSurvey()
			Catch ex As Exception
			End Try
		End Sub

		Private Sub ulgDeviationProfile_AfterRowsDeleted(eventSender As Object, eventArgs As EventArgs)
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
			Try
				Dim flag As Boolean = Me.CheckDeviationProfile()
				If flag Then
					Me.ShowDeviation_Dogleg(CType(Me.ulgDeviationProfile.DataSource, DataSet), False, False)
					Dim dsDeviationProfile As DataSet = CType(Me.ulgDeviationProfile.DataSource, DataSet)
					Dim bPlotData As Boolean = False
					Dim obj As Object
					Dim num As Short = Conversions.ToShort(obj)
					Me.ShowDeviation_TVD(dsDeviationProfile, bPlotData, num)
					obj = num
				End If
				Me.SaveDeviationSurvey()
			Catch ex2 As Exception
			End Try
		End Sub

		Private Sub ulgDeviationProfile_AfterRowUpdate(eventSender As Object, eventArgs As RowEventArgs)
			Try
				Dim flag As Boolean = Me.StoreTempDeviationProfile(RSWIN_DESC.mdsDeviationProfile_Edit, RSWIN_DESC.SETUP_MeasurementSystem <> 1)
			Catch ex As Exception
			End Try
		End Sub

		Private Sub ulgDeviationProfile_BeforeEnterEditMode(eventSender As Object, eventArgs As CancelEventArgs)
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
			Try
				Dim activeCell As UltraGridCell = Me.ulgDeviationProfile.ActiveCell
				Me.sCurrentCol = activeCell.Column.Key
				If Operators.CompareString(Me.sCurrentCol, "EntryNumber", False) = 0 Or Operators.CompareString(Me.sCurrentCol, "Dogleg", False) = 0 Or Operators.CompareString(Me.sCurrentCol, "TVDepth", False) = 0 Or Operators.CompareString(Me.sCurrentCol, "NorthSouth", False) = 0 Or Operators.CompareString(Me.sCurrentCol, "EastWest", False) = 0 Then
					eventArgs.Cancel = True
					If Not Me.bShiftDown And Not Me.bCtrlDown Then
						Me.ulgDeviationProfile.Selected.Rows.Clear()
					End If
				ElseIf Operators.CompareString(activeCell.Column.Key, "Depth", False) = 0 Then
					If Me.ulgDeviationProfile.ActiveRow IsNot Nothing Then
						Dim ultraGridRow As UltraGridRow = Me.ulgDeviationProfile.ActiveRow
						If ultraGridRow.HasPrevSibling() Then
							Dim flag As Boolean = True
							Dim flag2 As Boolean = False
							Dim ultraGridRow2 As UltraGridRow = ultraGridRow
							While flag
								If ultraGridRow2.HasPrevSibling() Then
									Dim sibling As UltraGridRow = ultraGridRow2.GetSibling(SiblingRow.Previous)
									If Information.IsDBNull(RuntimeHelpers.GetObjectValue(sibling.Cells("Depth").Value)) Then
										flag2 = True
										ultraGridRow = sibling
									End If
									ultraGridRow2 = sibling
								Else
									flag = False
								End If
							End While
							If flag2 Then
								Interaction.MsgBox(Me.sMsg1, MsgBoxStyle.Exclamation, "Data entry warning")
								eventArgs.Cancel = True
								Me.SelectRow(ultraGridRow, True)
								Me.ulgDeviationProfile.Focus()
							Else
								activeCell.Appearance.BackColor = RSWIN_DESC.rgbEditFocus
							End If
						End If
					End If
					If Not eventArgs.Cancel Then
						Me.ulgDeviationProfile.Selected.Rows.Clear()
					End If
				ElseIf Operators.CompareString(activeCell.Column.Key, "Azimuth", False) = 0 Then
					Me.ulgDeviationProfile.Selected.Rows.Clear()
					eventArgs.Cancel = True
					Me.BeforeEditAzimuth()
					If Me.txtInclination.Visible Then
						Dim control As Control = Me.txtInclination
						Me.HideControl(control)
						Me.txtInclination = CType(control, TextBox)
					End If
					Me.PositionOverCell(Me.txtAzimuth, Me.ulgDeviationProfile)
				ElseIf Operators.CompareString(activeCell.Column.Key, "Inclination", False) = 0 Then
					Me.ulgDeviationProfile.Selected.Rows.Clear()
					eventArgs.Cancel = True
					Me.BeforeEditInclination()
					If Me.txtAzimuth.Visible Then
						Dim control As Control = Me.txtAzimuth
						Me.HideControl(control)
						Me.txtAzimuth = CType(control, TextBox)
					End If
					Me.PositionOverCell(Me.txtInclination, Me.ulgDeviationProfile)
				End If
			Catch ex2 As Exception
			End Try
		End Sub

		Private Sub ulgDeviationProfile_InitializeRow(eventSender As Object, eventArgs As InitializeRowEventArgs)
			Try
				Try
					Me.ResetClock()
				Catch ex As Exception
				End Try
				Dim row As UltraGridRow = eventArgs.Row
				Dim ultraGridCell As UltraGridCell = row.Cells("EntryNumber")
				ultraGridCell.Appearance.BackColor = SystemColors.Control
				Dim ultraGridCell2 As UltraGridCell = row.Cells("Dogleg")
				ultraGridCell2.Appearance.BackColor = SystemColors.Control
				Dim ultraGridCell3 As UltraGridCell = row.Cells("TVDepth")
				ultraGridCell3.Appearance.BackColor = SystemColors.Control
				Dim ultraGridCell4 As UltraGridCell = row.Cells("NorthSouth")
				ultraGridCell4.Appearance.BackColor = SystemColors.Control
				Dim ultraGridCell5 As UltraGridCell = row.Cells("EastWest")
				ultraGridCell5.Appearance.BackColor = SystemColors.Control
			Catch ex2 As Exception
			End Try
		End Sub

		Private Sub ulgDeviationProfile_KeyDown(eventSender As Object, eventArgs As KeyEventArgs)
			Try
				If Not(-(eventArgs.Shift > False)) Then
					Me.bShiftDown = False
				ElseIf-(eventArgs.Shift > False) Then
					Me.bShiftDown = True
				End If
				If eventArgs.KeyCode = Keys.[Return] Then
					Dim activeCell As UltraGridCell = Me.ulgDeviationProfile.ActiveCell
					Dim activeRow As UltraGridRow = Me.ulgDeviationProfile.ActiveRow
					If activeRow IsNot Nothing Then
						If Operators.CompareString(activeCell.Column.Key, "Depth", False) = 0 Then
							Me.ulgDeviationProfile.ActiveCell = activeRow.Cells("Inclination")
							Me.ulgDeviationProfile.PerformAction(UltraGridAction.EnterEditMode)
						End If
					End If
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub HideControl(ByRef Ctrl As Control)
			Dim num As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 1
				IL_07:
				Dim num2 As Integer = 2
				If Ctrl Is Nothing Then
					GoTo IL_22
				End If
				IL_0D:
				num2 = 3
				If Not Ctrl.Visible Then
					GoTo IL_22
				End If
				IL_18:
				num2 = 4
				Ctrl.Visible = False
				IL_22:
				GoTo IL_8D
				IL_24:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_4E:
				GoTo IL_82
				IL_50:
				num4 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_60:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_50
			End Try
			IL_82:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_8D:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		Private Sub ulgDeviationProfile_BeforeCellDeactivate(eventSender As Object, eventArgs As CancelEventArgs)
			Try
				Dim ultraGridRow As UltraGridRow
				If Me.ulgDeviationProfile.ActiveRow IsNot Nothing Then
					Dim activeRow As UltraGridRow = Me.ulgDeviationProfile.ActiveRow
					If activeRow.HasPrevSibling() Then
						ultraGridRow = activeRow.GetSibling(SiblingRow.Previous)
					Else
						ultraGridRow = Nothing
					End If
				End If
				Dim activeCell As UltraGridCell = Me.ulgDeviationProfile.ActiveCell
				Dim num As Short = Conversions.ToShort(Me.ulgDeviationProfile.ActiveCell.Row.Cells("EntryNumber").Value)
				If Operators.CompareString(activeCell.Column.Key, "Azimuth", False) = 0 Then
					If Not Conversions.ToBoolean(Operators.AndObject(Operators.CompareString(Me.txtAzimuth.Text, "", False) = 0, Operators.NotObject(Operators.CompareObjectEqual(Me.ulgDeviationProfile.ActiveCell.Value, "", False)))) Then
						Dim text As String
						Dim flag As Boolean
						If Operators.CompareString(Me.txtAzimuth.Text, "0", False) = 0 Then
							text = "0"
							flag = True
						Else
							Me.bEditAzimuth = True
							Dim text2 As String = Me.txtAzimuth.Text
							text = Me.AzimuthCheck(text2)
							If Operators.CompareString(text2, Me.txtAzimuth.Text, False) <> 0 Then
								Me.txtAzimuth.Text = text2
							End If
							Me.bEditAzimuth = False
							flag = Versioned.IsNumeric(text)
						End If
						If flag Then
							Dim ulgDeviationProfile As UltraGrid = Me.ulgDeviationProfile
							ulgDeviationProfile.ActiveCell.Value = Me.txtAzimuth.Text
							Dim control As Control = Me.txtAzimuth
							Me.HideControl(control)
							Me.txtAzimuth = CType(control, TextBox)
						Else
							Dim prompt As String = Me.sMsg2
							Interaction.MsgBox(prompt, MsgBoxStyle.Information, "Data Entry Error")
							eventArgs.Cancel = True
							If Me.txtAzimuth.Visible And Me.txtAzimuth.Enabled Then
								Me.txtAzimuth.Focus()
							End If
						End If
						If Not Information.IsDBNull(text) And ultraGridRow IsNot Nothing Then
							If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(ultraGridRow.Cells("Azimuth").Value)) Then
								Operators.ConditionalCompareObjectLess(Conversion.Val(text), Operators.MultiplyObject(ultraGridRow.Cells("Azimuth").Value, 0.5), False)
							End If
						End If
					End If
				ElseIf Operators.CompareString(activeCell.Column.Key, "Inclination", False) = 0 Then
					If Not Conversions.ToBoolean(Operators.AndObject(Operators.CompareString(Me.txtInclination.Text, "", False) = 0, Operators.NotObject(Operators.CompareObjectEqual(Me.ulgDeviationProfile.ActiveCell.Value, "", False)))) Then
						Dim text3 As String = Me.InclinationCheck(Me.txtInclination.Text)
						Dim flag As Boolean = Versioned.IsNumeric(text3)
						If flag Then
							Dim ulgDeviationProfile2 As UltraGrid = Me.ulgDeviationProfile
							ulgDeviationProfile2.ActiveCell.Value = Me.txtInclination.Text
							Dim control As Control = Me.txtInclination
							Me.HideControl(control)
							Me.txtInclination = CType(control, TextBox)
						Else
							Dim prompt As String = Me.sMsg3
							Interaction.MsgBox(prompt, MsgBoxStyle.Information, "Data Entry Error")
							eventArgs.Cancel = True
							If Me.txtInclination.Visible And Me.txtInclination.Enabled Then
								Me.txtInclination.Focus()
							End If
						End If
						If Not Information.IsDBNull(text3) And ultraGridRow IsNot Nothing Then
							If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(ultraGridRow.Cells("Inclination").Value)) Then
								Operators.ConditionalCompareObjectLess(Conversion.Val(text3), Operators.MultiplyObject(ultraGridRow.Cells("Inclination").Value, 0.5), False)
							End If
						End If
					End If
				ElseIf Operators.CompareString(activeCell.Column.Key, "Depth", False) = 0 AndAlso (Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(activeCell.Value)) And ultraGridRow IsNot Nothing) AndAlso Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(ultraGridRow.Cells("Depth").Value)) Then
					Try
						Dim num2 As Single = Convert.ToSingle(RuntimeHelpers.GetObjectValue(activeCell.Value))
						Dim num3 As Single = Convert.ToSingle(RuntimeHelpers.GetObjectValue(ultraGridRow.Cells("Depth").Value))
						If num2 < num3 Then
							Interaction.MsgBox("Current depth cannot be less than previous depth", MsgBoxStyle.Exclamation, "Data entry error")
							eventArgs.Cancel = True
							Me.ulgDeviationProfile.Focus()
						End If
					Catch ex As Exception
					End Try
				End If
			Catch ex2 As Exception
			End Try
		End Sub

		Private Function CheckData() As Boolean
			Dim flag As Boolean = True
			Dim activeCell As UltraGridCell = Me.ulgDeviationProfile.ActiveCell
			If Operators.CompareString(activeCell.Column.Key, "Azimuth", False) = 0 Then
				If Operators.CompareString(Me.txtAzimuth.Text, "0", False) = 0 Then
					flag = True
				Else
					Me.bEditAzimuth = True
					Dim text As String = Me.txtAzimuth.Text
					Dim text2 As String = Me.AzimuthCheck(text)
					If Operators.CompareString(text, Me.txtAzimuth.Text, False) <> 0 Then
						Me.txtAzimuth.Text = text
					End If
					Me.bEditAzimuth = False
					flag = Versioned.IsNumeric(text2)
				End If
				If flag Then
					Dim ulgDeviationProfile As UltraGrid = Me.ulgDeviationProfile
					ulgDeviationProfile.ActiveCell.Value = Me.txtAzimuth.Text
					Dim control As Control = Me.txtAzimuth
					Me.HideControl(control)
					Me.txtAzimuth = CType(control, TextBox)
				Else
					Dim prompt As String = Me.sMsg2
					Interaction.MsgBox(prompt, MsgBoxStyle.Information, "Data Entry Error")
					If Me.txtAzimuth.Visible And Me.txtAzimuth.Enabled Then
						Me.txtAzimuth.Focus()
					End If
				End If
			ElseIf Operators.CompareString(activeCell.Column.Key, "Inclination", False) = 0 Then
				Dim text3 As String = Me.InclinationCheck(Me.txtInclination.Text)
				flag = Versioned.IsNumeric(text3)
				If flag Then
					Dim ulgDeviationProfile2 As UltraGrid = Me.ulgDeviationProfile
					ulgDeviationProfile2.ActiveCell.Value = Me.txtInclination.Text
					Dim control As Control = Me.txtInclination
					Me.HideControl(control)
					Me.txtInclination = CType(control, TextBox)
				Else
					Dim prompt As String = Me.sMsg3
					Interaction.MsgBox(prompt, MsgBoxStyle.Information, "Data Entry Error")
					If Me.txtInclination.Visible And Me.txtInclination.Enabled Then
						Me.txtInclination.Focus()
					End If
				End If
			End If
			Return flag
		End Function

		Private Sub ulgDeviationProfile_BeforeColRegionScroll(eventSender As Object, eventArgs As BeforeColRegionScrollEventArgs)
			Try
				Dim control As Control = Me.txtAzimuth
				Me.HideControl(control)
				Me.txtAzimuth = CType(control, TextBox)
				control = Me.txtInclination
				Me.HideControl(control)
				Me.txtInclination = CType(control, TextBox)
			Catch ex As Exception
			End Try
		End Sub

		Private Sub ulgDeviationProfile_BeforeRowRegionScroll(eventSender As Object, eventArgs As BeforeRowRegionScrollEventArgs)
			Try
				Dim control As Control = Me.txtAzimuth
				Me.HideControl(control)
				Me.txtAzimuth = CType(control, TextBox)
				control = Me.txtInclination
				Me.HideControl(control)
				Me.txtInclination = CType(control, TextBox)
			Catch ex As Exception
			End Try
		End Sub

		Private Sub PositionOverCell(CtlToMove As Control, Grid As UltraGrid)
			' The following expression was wrapped in a checked-statement
			Try
				Dim activeCell As UltraGridCell = Grid.ActiveCell
				If activeCell IsNot Nothing Then
					Dim uielement As UIElement = activeCell.GetUIElement(Grid.ActiveRowScrollRegion, Grid.ActiveColScrollRegion)
					If uielement IsNot Nothing Then
						Dim cellUIElement As CellUIElement = CType(uielement, CellUIElement)
						If cellUIElement IsNot Nothing Then
							Dim left As Integer = cellUIElement.RectInsideBorders.Location.X + Grid.Location.X
							Dim top As Integer = cellUIElement.RectInsideBorders.Location.Y + Grid.Location.Y
							Dim width As Integer = cellUIElement.RectInsideBorders.Width
							Dim height As Integer = cellUIElement.RectInsideBorders.Height
							CtlToMove.Left = left
							CtlToMove.Top = top
							CtlToMove.Width = width
							CtlToMove.Height = height
							CtlToMove.Visible = True
							CtlToMove.Focus()
						End If
					End If
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub ulgDeviationProfile_KeyUpEvent(eventSender As Object, eventArgs As KeyEventArgs)
			Try
				If Not(-(eventArgs.Shift > False)) Then
					Me.bShiftDown = False
				ElseIf-(eventArgs.Shift > False) Then
					Me.bShiftDown = True
				End If
				Me.ResetClock()
			Catch ex As Exception
			End Try
		End Sub

		Private Sub ulgDeviationProfile_MouseDownEvent(eventSender As Object, eventArgs As MouseEventArgs)
			Try
				Me.mfMouseDownX = CSng(eventArgs.X)
				Me.mfMouseDownY = CSng(eventArgs.Y)
			Catch ex As Exception
			End Try
		End Sub

		Private Sub ulgDeviationProfile_BeforeExitEditMode(eventSender As Object, eventArgs As Infragistics.Win.UltraWinGrid.BeforeExitEditModeEventArgs)
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
			Try
				Dim activeCell As UltraGridCell = Me.ulgDeviationProfile.ActiveCell
				If Operators.CompareString(activeCell.Column.Key, "Inclination", False) = 0 Or Operators.CompareString(activeCell.Column.Key, "Azimuth", False) = 0 Then
					Dim flag As Boolean = True
					If flag <> (Me.ulgDeviationProfile.ActiveCell Is Nothing) Then
						If flag = (Util.ValidNumber(Me.ulgDeviationProfile.ActiveCell.GetText(MaskMode.Raw), -1S) <> 0S) Then
						End If
					End If
				ElseIf Operators.CompareString(activeCell.Column.Key, "Depth", False) = 0 Then
					activeCell.Appearance.BackColor = Color.White
				End If
			Catch ex2 As Exception
			End Try
		End Sub

		Public Function InclinationCheck(sInclination As String) As String
			' The following expression was wrapped in a checked-statement
			Dim num As Integer
			Dim text As String
			Dim num7 As Integer
			Dim obj As Object
			Try
				Dim [string] As String = " "
				ProjectData.ClearProjectError()
				num = 2
				If Operators.CompareString(sInclination, "", False) = 0 Then
					text = ""
				End If
				Util.CheckDecimal(sInclination)
				Dim length As Short = CShort(Strings.Len(sInclination))
				Dim text2 As String = Strings.Mid(sInclination, 1, CInt(length))
				Dim num2 As Short = CShort(Strings.InStr(1, text2, [string], CompareMethod.Binary))
				If num2 = 1S Then
					num2 = 0S
				End If
				Dim text3 As String
				If num2 = 0S Then
					text3 = sInclination
				Else
					Dim num3 As Short = CShort(Math.Round(Conversion.Val(Strings.Mid(text2, 1, CInt((num2 - 1S))))))
					Dim num4 As Short = CShort(Math.Round(Conversion.Val(Strings.Mid(text2, CInt((num2 + 1S)), CInt(length)))))
					Dim num5 As Single = CSng((CDbl(num3) + CDbl(num4) / 60.0))
					Dim num6 As Single = num5
					Dim text4 As String = "####.####"
					text3 = Util.Format(num6, text4)
				End If
				If Operators.CompareString(text3, ".", False) = 0 Or Operators.CompareString(text3, ",", False) = 0 Then
					text3 = "0"
				End If
				text = text3
				IL_E0:
				GoTo IL_127
				IL_E2:
				num7 = -1
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_F8:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num7 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_E2
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_127:
			Dim result As String = text
			If num7 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		Public Function AzimuthCheck(ByRef sAZIMUTH As String) As String
			sAZIMUTH = Strings.StrConv(sAZIMUTH, VbStrConv.UpperCase, 0)
			Util.CheckDecimal(sAZIMUTH)
			Dim [string] As String = " "
			Dim flag As Boolean = False
			Dim flag2 As Boolean = False
			Dim flag3 As Boolean = False
			Dim flag4 As Boolean = False
			Dim num2 As Short
			Dim flag5 As Boolean
			Dim flag6 As Boolean
			Dim num7 As Short
			Dim num8 As Short
			Dim num As Short = CShort(Strings.Len(sAZIMUTH))
			Dim string2 As String = Strings.Mid(sAZIMUTH, 1, CInt(num))
			num2 = CShort(Strings.InStr(string2, [string], CompareMethod.Binary))
			If num2 = 1S Then
				num2 = 0S
			End If
			flag5 = (num2 > 0S)
			flag6 = (Strings.InStr(sAZIMUTH, "N", CompareMethod.Binary) = 0 And Strings.InStr(sAZIMUTH, "S", CompareMethod.Binary) = 0 And Strings.InStr(sAZIMUTH, "E", CompareMethod.Binary) = 0 And Strings.InStr(sAZIMUTH, "W", CompareMethod.Binary) = 0)
			If If((-If((flag6 > False), 1S, 0S)), 1S, 0S) And RSWIN_DESC.SETUP_DISPLAYAZDIRTOOLBAR And If((-If(((Operators.CompareString(Strings.Trim(sAZIMUTH), "0", False) <> 0) > False), 1S, 0S)), 1S, 0S) And If((-If((Me.bEditAzimuth > False), 1S, 0S)), 1S, 0S) <> 0S Then
				Dim name As String = Me.tabDirection.SelectedTab.Name
				If Operators.CompareString(name, "NE", False) = 0 Then
					flag = True
				ElseIf Operators.CompareString(name, "NW", False) = 0 Then
					sAZIMUTH = "N" + sAZIMUTH + "W"
					flag2 = True
				ElseIf Operators.CompareString(name, "SE", False) = 0 Then
					sAZIMUTH = "S" + sAZIMUTH + "E"
					flag3 = True
				ElseIf Operators.CompareString(name, "SW", False) = 0 Then
					sAZIMUTH = "S" + sAZIMUTH + "W"
					flag4 = True
				End If
			End If
			Dim num3 As Short = CShort(Strings.InStr(sAZIMUTH, "N", CompareMethod.Binary))
			Dim num4 As Short = CShort(Strings.InStr(sAZIMUTH, "E", CompareMethod.Binary))
			Dim num5 As Short = CShort(Strings.InStr(sAZIMUTH, "S", CompareMethod.Binary))
			Dim num6 As Short = CShort(Strings.InStr(sAZIMUTH, "W", CompareMethod.Binary))
			If num3 = 0S And num5 = 0S And num4 = 0S And num6 = 0S Then
				flag6 = True
				num7 = 0S
				num8 = num
			ElseIf num3 > 0S And num4 > 0S Then
				flag = True
				num7 = num3
				num8 = num4
			ElseIf num3 > 0S And num6 > 0S Then
				flag2 = True
				num7 = num3
				num8 = num6
			ElseIf num5 > 0S And num4 > 0S Then
				flag3 = True
				num7 = num5
				num8 = num4
			ElseIf num5 > 0S And num6 > 0S Then
				flag4 = True
				num7 = num5
				num8 = num6
			End If
			Dim text2 As String
			If(If((-If(((Not flag5 AndAlso flag6) > False), 1S, 0S)), 1S, 0S) And Not RSWIN_DESC.SETUP_DISPLAYAZDIRTOOLBAR) <> 0S Then
				Dim num9 As Double = Conversion.Val(sAZIMUTH)
				Dim text As String = "####.####"
				text2 = Util.Format(num9, text)
			ElseIf(If((-If(((flag5 AndAlso flag6) > False), 1S, 0S)), 1S, 0S) And Not RSWIN_DESC.SETUP_DISPLAYAZDIRTOOLBAR) <> 0S Then
				Dim num10 As Short
				Dim num11 As Short
				num10 = CShort(Math.Round(Conversion.Val(Strings.Mid(sAZIMUTH, CInt((num7 + 1S)), CInt((num2 - 1S))))))
				num11 = CShort(Math.Round(Conversion.Val(Strings.Mid(sAZIMUTH, CInt((num2 + 1S)), CInt(num8)))))
				Dim num12 As Single = CSng((CDbl(num10) + CDbl(num11) / 60.0))
				Dim text As String = "####.####"
				text2 = Util.Format(num12, text)
			ElseIf(If((-If(((Not flag5 AndAlso flag6) > False), 1S, 0S)), 1S, 0S) And RSWIN_DESC.SETUP_DISPLAYAZDIRTOOLBAR) <> 0S Then
				If Me.bEditAzimuth Then
					Dim name2 As String = Me.tabDirection.SelectedTab.Name
					If Operators.CompareString(name2, "NW", False) = 0 Then
						Dim num9 As Double = Conversion.Val(sAZIMUTH) * -1.0
						Dim text As String = "####.####"
						text2 = Util.Format(num9, text)
					ElseIf Operators.CompareString(name2, "SE", False) = 0 Then
						Dim num9 As Double = 180.0 - Conversion.Val(sAZIMUTH)
						Dim text As String = "####.####"
						text2 = Util.Format(num9, text)
					ElseIf Operators.CompareString(name2, "SW", False) = 0 Then
						Dim num9 As Double = 180.0 + Conversion.Val(sAZIMUTH)
						Dim text As String = "####.####"
						text2 = Util.Format(num9, text)
					Else
						text2 = sAZIMUTH
					End If
				Else
					text2 = sAZIMUTH
				End If
			ElseIf(If((-If(((flag5 AndAlso flag6) > False), 1S, 0S)), 1S, 0S) And RSWIN_DESC.SETUP_DISPLAYAZDIRTOOLBAR) <> 0S Then
				Dim num10 As Short
				Dim num11 As Short
				Dim num13 As Short
				num10 = CShort(Math.Round(Conversion.Val(Strings.Mid(sAZIMUTH, CInt((num7 + 1S)), CInt((num2 - 1S))))))
				num11 = CShort(Math.Round(Conversion.Val(Strings.Mid(sAZIMUTH, CInt((num2 + 1S)), CInt(num8)))))
				If num10 < 0S Then
					num13 = -1S
				Else
					num13 = 1S
				End If
				Dim num12 As Single = CSng((CDbl(num13) * (CDbl(Math.Abs(num10)) + CDbl(num11) / 60.0)))
				If Me.bEditAzimuth Then
					Dim name3 As String = Me.tabDirection.SelectedTab.Name
					If Operators.CompareString(name3, "NW", False) = 0 Then
						Dim num14 As Single = num12 * -1F
						Dim text As String = "####.####"
						text2 = Util.Format(num14, text)
					ElseIf Operators.CompareString(name3, "SE", False) = 0 Then
						Dim num14 As Single = 180F - num12
						Dim text As String = "####.####"
						text2 = Util.Format(num14, text)
					ElseIf Operators.CompareString(name3, "SW", False) = 0 Then
						Dim num14 As Single = 180F + num12
						Dim text As String = "####.####"
						text2 = Util.Format(num14, text)
					Else
						Dim text As String = "####.####"
						text2 = Util.Format(num12, text)
					End If
				Else
					Dim text As String = "####.####"
					text2 = Util.Format(num12, text)
				End If
			ElseIf Not flag6 Then
				If flag5 Then
					Dim num10 As Short
					Dim num11 As Short
					num10 = CShort(Math.Round(Conversion.Val(Strings.Mid(sAZIMUTH, CInt((num7 + 1S)), CInt((num2 - 1S))))))
					num11 = CShort(Math.Round(Conversion.Val(Strings.Mid(sAZIMUTH, CInt((num2 + 1S)), CInt((num8 - 1S))))))
					Dim num15 As Single
					If flag Then
						num15 = CSng((CDbl(num10) + CDbl(num11) / 60.0))
					ElseIf flag2 Then
						num15 = CSng((-1.0 * (CDbl(num10) + CDbl(num11) / 60.0)))
					ElseIf flag3 Then
						num15 = CSng((180.0 - (CDbl(num10) + CDbl(num11) / 60.0)))
					ElseIf flag4 Then
						num15 = CSng((180.0 + (CDbl(num10) + CDbl(num11) / 60.0)))
					End If
					Dim text As String = "####.####"
					text2 = Util.Format(num15, text)
				ElseIf Operators.CompareString(sAZIMUTH, "NULL", False) = 0 Then
					sAZIMUTH = ""
					text2 = ""
				Else
					' The following expression was wrapped in a checked-expression
					Dim inputStr As String = Strings.Mid(sAZIMUTH, CInt((num7 + 1S)), CInt((num8 - 1S)))
					Dim num15 As Single = CSng(Conversion.Val(inputStr))
					If flag2 Then
						num15 = -num15
					ElseIf flag3 Then
						num15 = 180F - num15
					ElseIf flag4 Then
						num15 = 180F + num15
					End If
					Dim text As String = "####.####"
					text2 = Util.Format(num15, text)
				End If
			End If
			If Operators.CompareString(text2, ".", False) = 0 Or Operators.CompareString(text2, ",", False) = 0 Then
				text2 = "0"
			ElseIf Operators.CompareString(text2, "", False) <> 0 Then
				Dim num12 As Single = CSng(Convert.ToDouble(text2))
				If num12 < 0F Then
					num12 = 360F + num12
					Dim text As String = "####.####"
					text2 = Util.Format(num12, text)
				End If
			End If
			Return text2
		End Function

		Private Sub ulgDeviationProfile_InitializeLayout(eventSender As Object, eventArgs As InitializeLayoutEventArgs)
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
			Try
				Dim layout As UltraGridLayout = eventArgs.Layout
				layout.TabNavigation = TabNavigation.NextCell
				Dim ultraGridBand As UltraGridBand = layout.Bands(0)
				Dim ultraGridColumn As UltraGridColumn = ultraGridBand.Columns("EntryNumber")
				ultraGridColumn.Header.Caption = "#"
				ultraGridColumn.Tag = ""
				ultraGridColumn.Width = 50
				ultraGridColumn.CellAppearance.BackColor = Color.Gray
				Dim ultraGridColumn2 As UltraGridColumn = ultraGridBand.Columns("Depth")
				ultraGridColumn2.Header.Caption = "Meas. depth (ft)"
				ultraGridColumn2.Tag = "Meas. depth (^)" & vbLf & "fem"
				ultraGridColumn2.Width = 125
				ultraGridColumn2.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
				Dim ultraGridColumn3 As UltraGridColumn = ultraGridBand.Columns("Inclination")
				ultraGridColumn3.Header.Caption = "Inclination (°)"
				ultraGridColumn3.Tag = ""
				ultraGridColumn3.Width = 115
				ultraGridColumn3.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
				Dim ultraGridColumn4 As UltraGridColumn = ultraGridBand.Columns("Azimuth")
				ultraGridColumn4.Header.Caption = "Azimuth (°)"
				ultraGridColumn4.Tag = ""
				ultraGridColumn4.Width = 115
				ultraGridColumn4.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
				Dim ultraGridColumn5 As UltraGridColumn = ultraGridBand.Columns("Dogleg")
				Me.SetDoglegColumnHeader()
				ultraGridColumn5.Width = 140
				ultraGridColumn5.CellAppearance.BackColor = Color.Gray
				ultraGridColumn5.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
				Dim ultraGridColumn6 As UltraGridColumn = ultraGridBand.Columns("TVDepth")
				ultraGridColumn6.Header.Caption = "TVD"
				ultraGridColumn6.Tag = "TVD (^)" & vbLf & "fem"
				ultraGridColumn6.Width = 85
				ultraGridColumn6.CellAppearance.BackColor = Color.Gray
				ultraGridColumn6.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
				Dim ultraGridColumn7 As UltraGridColumn = ultraGridBand.Columns("NorthSouth")
				ultraGridColumn7.Header.Caption = "N-S "
				ultraGridColumn7.Tag = "N-S (^)" & vbLf & "fem"
				ultraGridColumn7.Width = 85
				ultraGridColumn7.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
				ultraGridColumn7.CellAppearance.BackColor = Color.Gray
				Dim ultraGridColumn8 As UltraGridColumn = ultraGridBand.Columns("EastWest")
				ultraGridColumn8.Header.Caption = "E-W "
				ultraGridColumn8.Tag = "E-W (^)" & vbLf & "fem"
				ultraGridColumn8.Width = 85
				ultraGridColumn8.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
				ultraGridColumn8.CellAppearance.BackColor = Color.Gray
				Dim ultraGrid As UltraGrid = Me.ulgDeviationProfile
				Try
					ultraGrid.ActiveRow = ultraGrid.GetRow(ChildRow.First)
				Catch ex2 As Exception
				End Try
				Dim ultraGridBand2 As UltraGridBand = ultraGrid.DisplayLayout.Bands(0)
				ultraGridBand2.SortedColumns.Add(ultraGridBand2.Columns("EntryNumber"), False)
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
				Me.SetCommandButtons()
			Catch ex3 As Exception
			End Try
		End Sub

		Private Sub txtAzimuth_Leave(eventSender As Object, eventArgs As EventArgs)
			Try
				Dim activeCell As UltraGridCell = Me.ulgDeviationProfile.ActiveCell
				Dim num As Short = Conversions.ToShort(Me.ulgDeviationProfile.ActiveCell.Row.Cells("EntryNumber").Value)
				If Operators.CompareString(activeCell.Column.Key, "Azimuth", False) = 0 Then
					Dim flag As Boolean
					If Operators.CompareString(Me.txtAzimuth.Text, "0", False) = 0 Then
						flag = True
					Else
						Me.bEditAzimuth = True
						Dim text As String = Me.txtAzimuth.Text
						Dim text2 As String = Me.AzimuthCheck(text)
						If Operators.CompareString(text, Me.txtAzimuth.Text, False) <> 0 Then
							Me.txtAzimuth.Text = text
						End If
						Me.bEditAzimuth = False
						flag = Versioned.IsNumeric(text2)
					End If
					If flag Then
						Dim ulgDeviationProfile As UltraGrid = Me.ulgDeviationProfile
						If Information.IsDBNull(RuntimeHelpers.GetObjectValue(ulgDeviationProfile.ActiveCell.Value)) Then
							ulgDeviationProfile.ActiveCell.Value = Me.txtAzimuth.Text
						ElseIf Operators.ConditionalCompareObjectNotEqual(ulgDeviationProfile.ActiveCell.Value, Me.txtAzimuth.Text, False) Then
							ulgDeviationProfile.ActiveCell.Value = Me.txtAzimuth.Text
						End If
					End If
				End If
				Dim txtAzimuth As Control = Me.txtAzimuth
				CtrlUI.Control_LostFocus(txtAzimuth)
				Me.txtAzimuth = CType(txtAzimuth, TextBox)
				txtAzimuth = Me.txtAzimuth
				Me.HideControl(txtAzimuth)
				Me.txtAzimuth = CType(txtAzimuth, TextBox)
			Catch ex As Exception
			End Try
		End Sub

		Private Function BeforeEditAzimuth() As Boolean
			Dim activeCell As UltraGridCell = Me.ulgDeviationProfile.ActiveCell
			Dim result As Boolean
			If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(activeCell.Row.Cells("Azimuth").Value)) Then
				Me.txtAzimuth.Text = Conversions.ToString(activeCell.Row.Cells("Azimuth").Value)
				result = True
			Else
				Me.txtAzimuth.Text = ""
				result = False
			End If
			Return result
		End Function

		Private Function BeforeEditInclination() As Boolean
			Dim activeCell As UltraGridCell = Me.ulgDeviationProfile.ActiveCell
			Dim result As Boolean
			If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(activeCell.Row.Cells("Inclination").Value)) Then
				Me.txtInclination.Text = Conversions.ToString(activeCell.Row.Cells("Inclination").Value)
				result = True
			Else
				Me.txtInclination.Text = ""
				result = False
			End If
			Return result
		End Function

		Private Sub cmdMoveSectionUp_Click(eventSender As Object, eventArgs As EventArgs)
			Dim activeRow As UltraGridRow = Me.ulgDeviationProfile.ActiveRow
			Dim ultraGridRow As UltraGridRow
			If activeRow.HasPrevSibling() Then
				ultraGridRow = activeRow.GetSibling(SiblingRow.Previous)
			Else
				ultraGridRow = Nothing
			End If
			Dim num As Short = Conversions.ToShort(activeRow.Cells("Depth").Value)
			ultraGridRow.Cells("Depth").Value = num
			activeRow.Cells("Depth").Value = CInt((num - 1S))
			Me.ResortGrid()
			Me.SelectRow(activeRow, True)
			Dim flag As Boolean = Me.CheckDeviationProfile()
			If flag Then
				Me.ShowDeviation_Dogleg(CType(Me.ulgDeviationProfile.DataSource, DataSet), False, False)
				Dim dsDeviationProfile As DataSet = CType(Me.ulgDeviationProfile.DataSource, DataSet)
				Dim bPlotData As Boolean = False
				Dim obj As Object
				Dim num2 As Short = Conversions.ToShort(obj)
				Me.ShowDeviation_TVD(dsDeviationProfile, bPlotData, num2)
				obj = num2
				Return
			End If
		End Sub

		Private Sub ResortGrid()
			Me.bDoingResort = True
			Dim ultraGridBand As UltraGridBand = Me.ulgDeviationProfile.DisplayLayout.Bands(0)
			Dim ultraGridBand2 As UltraGridBand = ultraGridBand
			ultraGridBand2.SortedColumns.Clear()
			ultraGridBand2.SortedColumns.Add(ultraGridBand2.Columns("EntryNumber"), False, False)
			Me.bDoingResort = False
		End Sub

		Private Sub SelectRow(Row As UltraGridRow, Optional ActivateRow As Boolean = False)
			If ActivateRow Then
				Row.Activated = True
			Else
				Row.Activated = False
			End If
		End Sub

		Private Sub SelectRow(iNumRow As Integer)
			Try
				Application.DoEvents()
				Application.DoEvents()
				Application.DoEvents()
				Dim ultraGridRow As UltraGridRow = Me.ulgDeviationProfile.GetRow(ChildRow.Last)
				If ultraGridRow IsNot Nothing Then
					If Operators.ConditionalCompareObjectEqual(ultraGridRow.Cells("EntryNumber").Value, iNumRow, False) Then
						ultraGridRow.Selected = True
						Me.ulgDeviationProfile.ActiveRow = ultraGridRow
					Else
						Dim flag As Boolean = ultraGridRow.HasPrevSibling()
						While flag
							ultraGridRow = ultraGridRow.GetSibling(SiblingRow.Previous)
							If Operators.ConditionalCompareObjectEqual(ultraGridRow.Cells("EntryNumber").Value, iNumRow, False) Then
								flag = False
								ultraGridRow.Selected = True
								Me.ulgDeviationProfile.ActiveRow = ultraGridRow
							Else
								flag = ultraGridRow.HasPrevSibling()
							End If
						End While
					End If
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub cmdMoveSectionDown_Click(eventSender As Object, eventArgs As EventArgs)
			Dim activeRow As UltraGridRow = Me.ulgDeviationProfile.ActiveRow
			Dim sibling As UltraGridRow = activeRow.GetSibling(SiblingRow.[Next])
			Dim num As Short = Conversions.ToShort(activeRow.Cells("Depth").Value)
			sibling.Cells("Depth").Value = num
			activeRow.Cells("Depth").Value = CInt((num + 1S))
			Me.ResortGrid()
			Me.SelectRow(activeRow, True)
			Dim flag As Boolean = Me.CheckDeviationProfile()
			If flag Then
				Me.ShowDeviation_Dogleg(CType(Me.ulgDeviationProfile.DataSource, DataSet), False, False)
				Dim dsDeviationProfile As DataSet = CType(Me.ulgDeviationProfile.DataSource, DataSet)
				Dim bPlotData As Boolean = False
				Dim obj As Object
				Dim num2 As Short = Conversions.ToShort(obj)
				Me.ShowDeviation_TVD(dsDeviationProfile, bPlotData, num2)
				obj = num2
				Return
			End If
		End Sub

		Private Sub tabDirection_Click(sender As Object, e As EventArgs)
			Me.sDirection = Me.tabDirection.SelectedTab.Name
		End Sub

		Private Sub tabDirection_DblClick(sender As Object, e As EventArgs)
			Me.sDirection = Me.tabDirection.SelectedTab.Name
		End Sub

		Private Sub cmdAddSection_Click(eventSender As Object, eventArgs As EventArgs)
			If Me.ulgDeviationProfile.ActiveCell IsNot Nothing AndAlso Not Me.CheckData() Then
				Return
			End If
			RSWIN_DESC.iEntryInterval = 0S
			Dim ulgDeviationProfile As UltraGrid = Me.ulgDeviationProfile
			Me.NumEntries = CShort(RSWIN_DESC.mdsDeviationProfile_Edit.Tables(0).Rows.Count)
			If Me.NumEntries = 0S Then
				Me.miNewEntryNum = 1S
			ElseIf ulgDeviationProfile.ActiveCell IsNot Nothing Then
				Me.miNewEntryNum = Conversions.ToShort(Operators.AddObject(ulgDeviationProfile.ActiveCell.Row.Cells("EntryNumber").Value, 1))
			ElseIf ulgDeviationProfile.ActiveRow IsNot Nothing Then
				Me.miNewEntryNum = Conversions.ToShort(Operators.AddObject(ulgDeviationProfile.ActiveRow.Cells("EntryNumber").Value, 1))
			ElseIf ulgDeviationProfile.Selected.Rows.Count = 1 Then
				Me.miNewEntryNum = Conversions.ToShort(Operators.AddObject(ulgDeviationProfile.Selected.Rows(0).Cells("EntryNumber").Value, 1))
			Else
				Me.miNewEntryNum = Conversions.ToShort(Operators.AddObject(ulgDeviationProfile.GetRow(ChildRow.Last).Cells("EntryNumber").Value, 1))
			End If
			Dim num As Short = Me.miNewEntryNum
			Me.RenumberGrid(CInt(Me.miNewEntryNum), True)
			Me.AddEntryToDataSet(RSWIN_DESC.mdsDeviationProfile_Edit, num, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value)
			ulgDeviationProfile.DataSource = Nothing
			ulgDeviationProfile.DataSource = RSWIN_DESC.mdsDeviationProfile_Edit
			ulgDeviationProfile.Rows.Refresh(RefreshRow.RefreshDisplay, True)
			Me.MakeRowActive(CInt(Me.miNewEntryNum))
			Dim flag As Boolean = Me.CheckDeviationProfile()
			If flag Then
				Me.ShowDeviation_Dogleg(CType(Me.ulgDeviationProfile.DataSource, DataSet), False, False)
				Dim dsDeviationProfile As DataSet = CType(Me.ulgDeviationProfile.DataSource, DataSet)
				Dim bPlotData As Boolean = False
				Dim obj As Object
				Dim num2 As Short = Conversions.ToShort(obj)
				Me.ShowDeviation_TVD(dsDeviationProfile, bPlotData, num2)
				obj = num2
				Return
			End If
		End Sub

		Private Sub MakeRowActive(miNewEntryNum As Integer)
			' The following expression was wrapped in a checked-expression
			Dim ultraGridRow As UltraGridRow = Me.ulgDeviationProfile.Rows(miNewEntryNum - 1)
			If ultraGridRow IsNot Nothing Then
				Me.SelectRow(ultraGridRow, True)
				Me.ulgDeviationProfile.ActiveCell = ultraGridRow.Cells("Depth")
				Me.ulgDeviationProfile.PerformAction(UltraGridAction.EnterEditMode)
			End If
		End Sub

		Private Sub cmdDelSection_Click(eventSender As Object, eventArgs As EventArgs)
			Dim ulgDeviationProfile As UltraGrid = Me.ulgDeviationProfile
			Dim count As Integer = ulgDeviationProfile.Rows.Count
			Dim activeRow As UltraGridRow = ulgDeviationProfile.ActiveRow
			Dim num As Integer = Conversions.ToInteger(activeRow.Cells("EntryNumber").Value)
			Dim ultraGridRow As UltraGridRow
			If activeRow.HasPrevSibling() Then
				ultraGridRow = activeRow.GetSibling(SiblingRow.Previous)
			Else
				ultraGridRow = Nothing
			End If
			Me.bDisplayDeleteMessage = True
			If ulgDeviationProfile.Selected.Cells.Count = 0 Or ulgDeviationProfile.Selected.Cells.Count = 1 Then
				ulgDeviationProfile.ActiveRow.Selected = True
			Else
				Dim obj As Object = MessageBox.Show(Me.sARSRemove, Me.sDeleteRows, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
				If Not Operators.ConditionalCompareObjectEqual(obj, DialogResult.Yes, False) Then
					Return
				End If
				Me.bDisplayDeleteMessage = False
				For Each ultraGridCell As UltraGridCell In ulgDeviationProfile.Selected.Cells
					ultraGridCell.Row.Delete(False)
				Next
				Me.bDisplayDeleteMessage = True
			End If
			If ulgDeviationProfile.ActiveCell IsNot Nothing Then
				If ulgDeviationProfile.Selected.Rows.Count = 1 Then
					ulgDeviationProfile.ActiveCell.Row.Delete()
				Else
					ulgDeviationProfile.DeleteSelectedRows()
				End If
			ElseIf ulgDeviationProfile.Selected.Rows.Count = 1 Then
				ulgDeviationProfile.DeleteSelectedRows()
			End If
			Application.DoEvents()
			Dim count2 As Integer = Me.ulgDeviationProfile.Rows.Count
			If count2 <> count Then
				If ultraGridRow IsNot Nothing Then
					Me.SelectRow(ultraGridRow, True)
				End If
				Dim iEntryNumber As Integer
				Dim bInc As Boolean
				If count2 = count - 1 Then
					iEntryNumber = num
					bInc = False
				ElseIf ultraGridRow IsNot Nothing Then
					iEntryNumber = 0
					bInc = True
				End If
				Me.RenumberGrid(iEntryNumber, bInc)
				Return
			End If
		End Sub

		Private Sub cmdDelSection_Click_Old(eventSender As Object, eventArgs As EventArgs)
			' The following expression was wrapped in a checked-statement
			Dim num As Integer
			Dim num3 As Integer
			Dim obj As Object
			Try
				ProjectData.ClearProjectError()
				num = 2
				Dim ulgDeviationProfile As UltraGrid = Me.ulgDeviationProfile
				Dim activeCell As UltraGridCell
				If ulgDeviationProfile.ActiveCell IsNot Nothing And ulgDeviationProfile.Selected.Rows.Count = 1 Then
					activeCell = Me.ulgDeviationProfile.ActiveCell
				End If
				Dim activeRow As UltraGridRow
				Dim sibling As UltraGridRow
				If ulgDeviationProfile.ActiveRow IsNot Nothing And ulgDeviationProfile.Selected.Rows.Count = 1 Then
					activeRow = Me.ulgDeviationProfile.ActiveRow
					If activeRow.HasNextSibling() Then
						sibling = activeRow.GetSibling(SiblingRow.[Next])
					ElseIf activeRow.HasPrevSibling() Then
						sibling = activeRow.GetSibling(SiblingRow.Previous)
					End If
				End If
				Dim ulgDeviationProfile2 As UltraGrid = Me.ulgDeviationProfile
				If ulgDeviationProfile2.ActiveCell IsNot Nothing And ulgDeviationProfile2.Selected.Rows.Count = 1 Then
					ulgDeviationProfile2.ActiveCell.Row.Delete()
				Else
					If ulgDeviationProfile2.ActiveRow Is Nothing Or ulgDeviationProfile2.Selected.Rows.Count = 0 Then
						Me.SelectRow(activeRow, True)
						Me.ulgDeviationProfile.ActiveCell = activeCell
					End If
					If ulgDeviationProfile2.Selected.Rows.Count > 0 Then
						ulgDeviationProfile2.DeleteSelectedRows()
					End If
				End If
				Dim num2 As Short = 0S
				Dim ultraGridRow As UltraGridRow = Me.ulgDeviationProfile.GetRow(ChildRow.First)
				While ultraGridRow IsNot Nothing
					num2 += 1S
					ultraGridRow.Cells("EntryNumber").Value = num2
					If ultraGridRow.HasNextSibling() Then
						ultraGridRow = ultraGridRow.GetSibling(SiblingRow.[Next])
					Else
						ultraGridRow = Nothing
					End If
				End While
				If sibling IsNot Nothing Then
					Me.SelectRow(sibling, True)
				End If
				IL_183:
				GoTo IL_1CA
				IL_185:
				num3 = -1
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_19B:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num3 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_185
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_1CA:
			If num3 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		Private Sub SetCommandButtons()
			Try
				If Me.ulgDeviationProfile.ActiveRow IsNot Nothing Then
					Me.cmdAddSection.Enabled = True
					Me.cmdDelSection.Enabled = True
					Me.cmdDeleteALLSections.Enabled = True
					Me.cmdMoveSectionUp.Enabled = Me.ulgDeviationProfile.ActiveRow.HasPrevSibling()
					Me.cmdMoveSectionDown.Enabled = Me.ulgDeviationProfile.ActiveRow.HasNextSibling()
				Else
					Me.cmdAddSection.Enabled = True
					Me.cmdDelSection.Enabled = False
					Me.cmdDeleteALLSections.Enabled = False
					Me.cmdMoveSectionUp.Enabled = False
					Me.cmdMoveSectionDown.Enabled = False
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub calc_nor(ByRef n As DeviationProfile.cart_coord_type, ByRef t1 As DeviationProfile.cart_coord_type, ByRef t2 As DeviationProfile.cart_coord_type)
			Dim cart_coord_type As DeviationProfile.cart_coord_type
			Me.cross_prod(cart_coord_type, t2, t1)
			Dim cart_coord_type2 As DeviationProfile.cart_coord_type
			Me.cross_prod(cart_coord_type2, t1, cart_coord_type)
			Dim num As Double = Math.Sqrt(cart_coord_type2.X * cart_coord_type2.X + cart_coord_type2.Y * cart_coord_type2.Y + cart_coord_type2.z * cart_coord_type2.z)
			If num > 0.0 Then
				n.X = cart_coord_type2.X / num
				n.Y = cart_coord_type2.Y / num
				n.z = cart_coord_type2.z / num
				Return
			End If
			n.X = 0.0
			n.Y = 0.0
			n.z = 0.0
		End Sub

		Private Sub cross_prod(ByRef result As DeviationProfile.cart_coord_type, ByRef V1 As DeviationProfile.cart_coord_type, ByRef v2 As DeviationProfile.cart_coord_type)
			result.X = V1.Y * v2.z - V1.z * v2.Y
			result.Y = V1.z * v2.X - V1.X * v2.z
			result.z = V1.X * v2.Y - V1.Y * v2.X
		End Sub

		Private Sub calc_pos_lower(ByRef pos2 As DeviationProfile.cart_coord_type, ByRef pos1 As DeviationProfile.cart_coord_type, ByRef tan2 As DeviationProfile.cart_coord_type, ByRef nor2 As DeviationProfile.cart_coord_type, ByRef dog2 As Double, ByRef rad2 As Double)
			Dim num As Double = rad2 * Math.Sin(dog2)
			Dim num2 As Double = -rad2 * (1.0 - Math.Cos(dog2))
			pos2.X = pos1.X + num * tan2.X + num2 * nor2.X
			pos2.Y = pos1.Y + num * tan2.Y + num2 * nor2.Y
			pos2.z = pos1.z + num * tan2.z + num2 * nor2.z
		End Sub

		Private Sub calc_str_lower(ByRef pos2 As DeviationProfile.cart_coord_type, ByRef pos1 As DeviationProfile.cart_coord_type, ByRef tan2 As DeviationProfile.cart_coord_type, ByRef m_d2 As Double, ByRef m_d1 As Double)
			Dim num As Double = m_d2 - m_d1
			pos2.X = pos1.X + num * tan2.X
			pos2.Y = pos1.Y + num * tan2.Y
			pos2.z = pos1.z + num * tan2.z
		End Sub

		Private Sub calc_pos(ByRef pos2 As DeviationProfile.cart_coord_type, ByRef pos1 As DeviationProfile.cart_coord_type, ByRef tan1 As DeviationProfile.cart_coord_type, ByRef nor1 As DeviationProfile.cart_coord_type, dog1 As Double, rad1 As Double)
			Dim num As Double = rad1 * Math.Sin(dog1)
			Dim num2 As Double = rad1 * (1.0 - Math.Cos(dog1))
			pos2.X = pos1.X + num * tan1.X + num2 * nor1.X
			pos2.Y = pos1.Y + num * tan1.Y + num2 * nor1.Y
			pos2.z = pos1.z + num * tan1.z + num2 * nor1.z
		End Sub

		Private Sub calc_str(ByRef pos2 As DeviationProfile.cart_coord_type, ByRef pos1 As DeviationProfile.cart_coord_type, ByRef tan1 As DeviationProfile.cart_coord_type, ByRef m_d2 As Double, ByRef m_d1 As Double)
			Dim num As Double = m_d2 - m_d1
			pos2.X = pos1.X + num * tan1.X
			pos2.Y = pos1.Y + num * tan1.Y
			pos2.z = pos1.z + num * tan1.z
		End Sub

		Private Function dot_prod(ByRef V1 As DeviationProfile.cart_coord_type, ByRef v2 As DeviationProfile.cart_coord_type) As Double
			Return V1.X * v2.X + V1.Y * v2.Y + V1.z * v2.z
		End Function

		Public Sub ConvertmdsDeviationProfile(bConvert As Boolean)
			Dim oleDbDataAdapter As OleDbDataAdapter = New OleDbDataAdapter()
			RSWIN_DESC.mdsDeviationProfile = RSWIN_DESC.mdsDeviationProfile_Edit.Copy()
			oleDbDataAdapter.Fill(RSWIN_DESC.mdsDeviationProfile)
			Dim oleDbCommandBuilder As OleDbCommandBuilder = New OleDbCommandBuilder(oleDbDataAdapter)
			If bConvert Then
				Try
					For Each obj As Object In RSWIN_DESC.mdsDeviationProfile.Tables(0).Rows
						Dim dataRow As DataRow = CType(obj, DataRow)
						Dim num As Single = Conversions.ToSingle(dataRow("Depth"))
						CtrlUI.ConvertValue(num, "f", True)
						dataRow("Depth") = Math.Round(CDbl(num), 2)
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
			End If
			Dim num2 As Integer = oleDbDataAdapter.Update(RSWIN_DESC.mdsDeviationProfile)
		End Sub

		Private Sub BuildDeviationProfileXML(ByRef iNumOfLines As Integer)
			' The following expression was wrapped in a checked-statement
			Dim num As Integer
			Dim num3 As Integer
			Dim obj As Object
			Try
				ProjectData.ClearProjectError()
				num = 2
				RSWIN_DESC.sDeviationProfileXML = ""
				RSWIN_DESC.sDeviationProfileXML += "<Data><Entries>"
				Dim ultraGridRow As UltraGridRow = Me.ulgDeviationProfile.GetRow(ChildRow.First)
				Dim flag As Boolean = True
				iNumOfLines += 1
				While flag
					Dim ultraGridRow2 As UltraGridRow = ultraGridRow
					If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(ultraGridRow2.Cells("Depth").Value)) And Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(ultraGridRow2.Cells("Inclination").Value)) And Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(ultraGridRow2.Cells("Azimuth").Value)) Then
						RSWIN_DESC.sDeviationProfileXML += "<Row>"
						RSWIN_DESC.sDeviationProfileXML += "<Depth>"
						Dim num2 As Single = Conversions.ToSingle(ultraGridRow2.Cells("Depth").Value)
						If num2 = 0F Then
							RSWIN_DESC.sDeviationProfileXML += "0"
						Else
							Dim sDeviationProfileXML As String = RSWIN_DESC.sDeviationProfileXML
							Dim text As String = "#####.###"
							RSWIN_DESC.sDeviationProfileXML = sDeviationProfileXML + Util.Format(num2, text)
						End If
						RSWIN_DESC.sDeviationProfileXML += "</Depth>"
						RSWIN_DESC.sDeviationProfileXML += "<Inclination>"
						Dim str As String = Conversions.ToString(ultraGridRow2.Cells("Inclination").Value)
						RSWIN_DESC.sDeviationProfileXML += str
						RSWIN_DESC.sDeviationProfileXML += "</Inclination>"
						RSWIN_DESC.sDeviationProfileXML += "<Azimuth>"
						str = Conversions.ToString(ultraGridRow2.Cells("Azimuth").Value)
						RSWIN_DESC.sDeviationProfileXML += str
						RSWIN_DESC.sDeviationProfileXML += "</Azimuth>"
						iNumOfLines += 1
						If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(ultraGridRow2.Cells("Dogleg").Value)) Then
							RSWIN_DESC.sDeviationProfileXML += "<Dogleg>"
							num2 = Conversions.ToSingle(ultraGridRow2.Cells("Dogleg").Value)
							If num2 = 0F Then
								RSWIN_DESC.sDeviationProfileXML += "0"
							Else
								Dim sDeviationProfileXML2 As String = RSWIN_DESC.sDeviationProfileXML
								Dim text As String = "#####.###"
								RSWIN_DESC.sDeviationProfileXML = sDeviationProfileXML2 + Util.Format(num2, text)
							End If
							RSWIN_DESC.sDeviationProfileXML += "</Dogleg>"
							RSWIN_DESC.sDeviationProfileXML += "<TVDepth>"
							num2 = Conversions.ToSingle(ultraGridRow2.Cells("TVDepth").Value)
							If num2 = 0F Then
								RSWIN_DESC.sDeviationProfileXML += "0"
							Else
								Dim sDeviationProfileXML3 As String = RSWIN_DESC.sDeviationProfileXML
								Dim text As String = "#####.###"
								RSWIN_DESC.sDeviationProfileXML = sDeviationProfileXML3 + Util.Format(num2, text)
							End If
							RSWIN_DESC.sDeviationProfileXML += "</TVDepth>"
							RSWIN_DESC.sDeviationProfileXML += "<NorthSouth>"
							num2 = Conversions.ToSingle(ultraGridRow2.Cells("NorthSouth").Value)
							If num2 = 0F Then
								RSWIN_DESC.sDeviationProfileXML += "0"
							Else
								Dim sDeviationProfileXML4 As String = RSWIN_DESC.sDeviationProfileXML
								Dim text As String = "#####.###"
								RSWIN_DESC.sDeviationProfileXML = sDeviationProfileXML4 + Util.Format(num2, text)
							End If
							RSWIN_DESC.sDeviationProfileXML += "</NorthSouth>"
							RSWIN_DESC.sDeviationProfileXML += "<EastWest>"
							num2 = Conversions.ToSingle(ultraGridRow2.Cells("EastWest").Value)
							If num2 = 0F Then
								RSWIN_DESC.sDeviationProfileXML += "0"
							Else
								Dim sDeviationProfileXML5 As String = RSWIN_DESC.sDeviationProfileXML
								Dim text As String = "#####.###"
								RSWIN_DESC.sDeviationProfileXML = sDeviationProfileXML5 + Util.Format(num2, text)
							End If
							RSWIN_DESC.sDeviationProfileXML += "</EastWest>"
						Else
							RSWIN_DESC.sDeviationProfileXML += "<Dogleg></Dogleg>"
							RSWIN_DESC.sDeviationProfileXML += "<TVDepth></TVDepth>"
							RSWIN_DESC.sDeviationProfileXML += "<NorthSouth></NorthSouth>"
							RSWIN_DESC.sDeviationProfileXML += "<EastWest></EastWest>"
						End If
						If ultraGridRow.HasNextSibling() Then
							ultraGridRow = ultraGridRow.GetSibling(SiblingRow.[Next])
						Else
							flag = False
						End If
						RSWIN_DESC.sDeviationProfileXML += "</Row>"
					End If
				End While
				RSWIN_DESC.sDeviationProfileXML += "</Entries></Data>"
				If CDbl(iNumOfLines) / 35.0 > Conversion.Int(CDbl(iNumOfLines) / 35.0) Then
					' The following expression was wrapped in a unchecked-expression
					RSWIN_DESC.rst.NumDevSurveyPages = CInt(Math.Round(Conversion.Int(CDbl(iNumOfLines) / 35.0) + 1.0))
				Else
					RSWIN_DESC.rst.NumDevSurveyPages = CInt(Math.Round(Conversion.Int(CDbl(iNumOfLines) / 35.0)))
				End If
				If RSWIN_DESC.rst.NumDevSurveyPages = 0 Then
					RSWIN_DESC.rst.NumDevSurveyPages = 1
				End If
				IL_541:
				GoTo IL_588
				IL_543:
				num3 = -1
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_559:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num3 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_543
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_588:
			If num3 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		Private Sub TextBox_Change(ByRef txt As TextBox, ByRef lbl As Label)
			If Me.ActiveControl IsNot txt Then
				CtrlUI.TextBox_LostFocus(txt, lbl, True)
				Me.ResetClock()
				Return
			End If
		End Sub

		Private Sub RenumberGrid(iEntryNumber As Integer, bInc As Boolean)
			Dim ultraGridRow As UltraGridRow
			Try
				ultraGridRow = Me.ulgDeviationProfile.GetRow(ChildRow.First)
			Catch ex As Exception
				ultraGridRow = Nothing
			End Try
			Dim num As Integer = iEntryNumber
			While ultraGridRow IsNot Nothing
				Dim ultraGridRow2 As UltraGridRow = ultraGridRow
				Try
					If Conversions.ToBoolean(Operators.AndObject(bInc, Operators.CompareObjectGreaterEqual(ultraGridRow2.Cells("EntryNumber").Value, iEntryNumber, False))) Then
						num += 1
						ultraGridRow2.Cells("EntryNumber").Value = num
					ElseIf Conversions.ToBoolean(Operators.AndObject(Not bInc, Operators.CompareObjectGreater(ultraGridRow2.Cells("EntryNumber").Value, iEntryNumber, False))) Then
						num = Conversions.ToInteger(Operators.SubtractObject(ultraGridRow2.Cells("EntryNumber").Value, 1))
						ultraGridRow2.Cells("EntryNumber").Value = num
					End If
					If ultraGridRow2.HasNextSibling() Then
						ultraGridRow = ultraGridRow2.GetSibling(SiblingRow.[Next])
					Else
						ultraGridRow = Nothing
					End If
				Catch ex2 As Exception
				End Try
			End While
		End Sub

		Private Sub ulgDeviationProfile_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs)
			Try
				e.DisplayPromptMsg = False
				If Me.bDisplayDeleteMessage Then
					Dim obj As Object = MessageBox.Show(Me.sARSRemoveThis, Me.sDeleteRow, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
					If Operators.ConditionalCompareObjectEqual(obj, DialogResult.No, False) Then
						e.Cancel = True
					End If
				End If
			Catch ex As Exception
			End Try
		End Sub

		Public Sub ReplotTeeChart(xval As Double(), yval As Double(), zval As Double(), fMeasDepth As Double(), Optional bConvert As Boolean = True)
			Dim flag As Boolean = False
			If Me.point3DSeries1 Is Nothing Then
				Me.point3DSeries1 = New Points3D()
			End If
			Me.point3DSeries1.Clear()
			Try
				Me.commander1.Buttons(8).Enabled = False
				Me.commander1.Buttons(8).Visible = False
				Me.commander1.Buttons(11).Enabled = False
				Me.commander1.Buttons(11).Visible = False
			Catch ex As Exception
			End Try
			Me.m_bReplot = False
			Dim num As Integer = Information.LBound(fMeasDepth, 1)
			Dim num2 As Integer = Information.UBound(fMeasDepth, 1)
			Dim num4 As Single
			Dim num6 As Single
			Dim num11 As Single
			Dim num12 As Single
			Dim bottom2 As Steema.TeeChart.Axis
			Dim axisMinMax As Single
			For i As Integer = num To num2
				Try
					If(i > 0 And fMeasDepth(i) <> 0.0) Or i = 0 Then
						Me.point3DSeries1.Add(xval(i), yval(i), zval(i))
					End If
				Catch ex2 As Exception
					Debug.WriteLine(ex2.Message)
				End Try
			Next
			Me.TChart1.Series.Add(Me.point3DSeries1)
			Dim num3 As Double = CDbl(num4)
			Dim num5 As Double = CDbl(num6)
			Dim num7 As Double = 0.0
			Dim num8 As Double = 0.0
			Util.Maxmin(zval, num3, num5, num7, num8)
			num6 = CSng(num5)
			num4 = CSng(num3)
			Dim num9 As Single
			num8 = CDbl(num9)
			Dim num10 As Single
			num7 = CDbl(num10)
			num5 = 0.0
			num3 = 0.0
			Util.Maxmin(xval, num8, num7, num5, num3)
			num10 = CSng(num7)
			num9 = CSng(num8)
			num8 = CDbl(num11)
			num7 = CDbl(num12)
			num5 = 0.0
			num3 = 0.0
			Util.Maxmin(yval, num8, num7, num5, num3)
			num12 = CSng(num7)
			num11 = CSng(num8)
			Dim bottom As Steema.TeeChart.Axis = Me.TChart1.Axes.Bottom
			Dim depth As Steema.TeeChart.Axis = Me.TChart1.Axes.Depth
			Dim tchart As TChart = Me.TChart1
			tchart.Header.Font.Name = "Sans Serif"
			tchart.Header.Font.Bold = True
			tchart.Header.Font.Size = 9
			bottom2 = Me.TChart1.Axes.Bottom
			bottom2.Labels.ValueFormat = "0"
			bottom2.Automatic = False
			If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
				bottom2.Increment = 100.0
			Else
				bottom2.Increment = 30.0
			End If
			axisMinMax = Me.GetAxisMinMax(CSng(bottom2.Increment), num9, num10)
			bottom2.Minimum = CDbl((axisMinMax * -1F))
			bottom2.Maximum = CDbl(axisMinMax)
			If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
				bottom2.Title.Text = "West  (m)  East"
			Else
				bottom2.Title.Text = "West  (ft)  East"
			End If
			bottom2.Title.Font.Name = "Sans Serif"
			bottom2.Title.Font.Size = 9
			Dim left As Steema.TeeChart.Axis = Me.TChart1.Axes.Left
			left.Labels.ValueFormat = "0"
			left.Increment = 100.0
			left.Automatic = False
			axisMinMax = Me.GetAxisMinMax(CSng(left.Increment), num11, num12)
			left.Minimum = 0.0
			left.Maximum = CDbl(axisMinMax)
			If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
				left.Title.Text = "True Vertical Depth (m)"
			Else
				left.Title.Text = "True Vertical Depth (ft)"
			End If
			left.Title.Font.Name = "Sans Serif"
			left.Title.Font.Size = 9
			Dim depth2 As Steema.TeeChart.Axis = Me.TChart1.Axes.Depth
			depth2.Labels.ValueFormat = "0"
			If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
				depth2.Increment = 100.0
			Else
				depth2.Increment = 30.0
			End If
			depth2.Automatic = False
			axisMinMax = Me.GetAxisMinMax(CSng(depth2.Increment), num4, num6)
			depth2.Minimum = CDbl((axisMinMax * -1F))
			depth2.Maximum = CDbl(axisMinMax)
			If axisMinMax > 1000F And axisMinMax < 2000F Then
				depth2.Increment = 200.0
			ElseIf axisMinMax > 2000F Then
				depth2.Increment = 500.0
			Else
				depth2.Increment = 100.0
			End If
			If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
				depth2.Title.Text = "South  (m)  North"
			Else
				depth2.Title.Text = "South  (ft)  North"
			End If
			depth2.Title.Font.Name = "Sans Serif"
			depth2.Title.Font.Size = 9
			depth2.Inverted = True
			If RSWIN_DESC.rst.NumRods > 0S Then
				Dim num13 As Integer = 1
				Dim numRods As Integer = CInt(RSWIN_DESC.rst.NumRods)
				For j As Integer = num13 To numRods
					Dim teRodSizeList As teRodSizeList
					Try
						Dim grade As Short = RSWIN_DESC.rst.Sections(j).Grade
						If CUSTOMRG.IsOtherSteel(CInt(grade)) Or CUSTOMRG.IsOtherFG(CInt(grade)) Or CUSTOMRG.IsOtherSinkerBar(CInt(grade)) Then
							Dim sRodType As String
							If CUSTOMRG.IsOtherFG(CInt(grade)) Then
								Dim iRodGrade As Integer = CInt(grade)
								Dim num14 As Single = 0F
								sRodType = RODUTIL.GetOtherFG(iRodGrade, num14)
							ElseIf CUSTOMRG.IsOtherSinkerBar(CInt(grade)) Then
								Dim iRodGrade2 As Integer = CInt(grade)
								Dim num14 As Single = 0F
								sRodType = RODUTIL.GetOtherSinkerbar(iRodGrade2, num14)
							ElseIf CUSTOMRG.IsOtherSteel(CInt(grade)) Then
								Dim iRodGrade3 As Integer = CInt(grade)
								Dim num14 As Single = 0F
								sRodType = RODUTIL.GetOtherSteel(iRodGrade3, num14)
							End If
							If CUSTOMRG.IsOtherSinkerBar(CInt(grade)) Then
								teRodSizeList = RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.RodSizeList(13)
							ElseIf Not RODUTIL.IsAPI(CInt(grade), sRodType) Then
								teRodSizeList = RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.RodSizeList(14)
							Else
								teRodSizeList = RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.RodSizeList(1)
							End If
						Else
							teRodSizeList = RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.RodGradeDB().Item(CType(RSWIN_DESC.rst.Sections(j).Grade, StdInfoConstants.RodGradeConstants)).RodSizeList
						End If
					Catch ex3 As Exception
						teRodSizeList = Nothing
					End Try
					Dim text As String
					If teRodSizeList IsNot Nothing Then
						Try
							For Each obj As Object In teRodSizeList
								Dim dictionaryEntry As DictionaryEntry
								Dim teRodSize As teRodSize = CType(If((obj IsNot Nothing), CType(obj, DictionaryEntry), dictionaryEntry).Value, teRodSize)
								Try
									If teRodSize.Diameter = RSWIN_DESC.rst.Sections(j).Diameter Then
										If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
											text = teRodSize.MetricDisplayName
										Else
											text = teRodSize.DisplayName
										End If
										flag = True
										text = text.Replace("  ", " ")
									End If
								Catch ex4 As Exception
								End Try
							Next
						Finally
							Dim enumerator As IEnumerator
							If TypeOf enumerator Is IDisposable Then
								TryCast(enumerator, IDisposable).Dispose()
							End If
						End Try
					End If

						If Not flag Then
							If RODUTIL.IsCorodH(RSWIN_DESC.rst.Sections(j).Grade) Then
								text = "N/A"
							ElseIf RODUTIL.IsCorod(RSWIN_DESC.rst.Sections(j).Grade) Then
								If RSWIN_DESC.rst.Sections(j).Diameter > 1F Then
									Dim num14 As Single = RSWIN_DESC.rst.Sections(j).Diameter * 16F
									Dim text2 As String = "0.0"
									text = Util.Format(num14, text2) + "/16"""
								Else
									Dim num14 As Single = RSWIN_DESC.rst.Sections(j).Diameter * 16F
									Dim text2 As String = "0"
									text = Util.Format(num14, text2) + "/16"""
								End If
								Dim flag2 As Boolean
								If Not flag2 And RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									text += """"
								End If
							ElseIf RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
								Dim num14 As Single = RSWIN_DESC.rst.Sections(j).Diameter * RSWIN_DESC.IN__MM
								Dim text2 As String = "0.0"
								text = Util.Format(num14, text2)
							Else
								Dim sections As RSWIN_DESC.RodSection() = RSWIN_DESC.rst.Sections
								Dim num15 As Integer = j
								Dim text2 As String = "0.0###"
								text = Util.Format(sections(num15).Diameter, text2) + """"
							End If
						End If

					Select Case j
						Case 1
							Me.T1.Text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(CInt(RSWIN_DESC.rst.NumRods) > j, ", ", "")))
							Me.T1.ForeColor = Color.Red
							Me.T1.Left = Me.lblDiameters.Left + Me.lblDiameters.Width + 1
							Me.T1.Visible = True
						Case 2
							Me.T2.Text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(CInt(RSWIN_DESC.rst.NumRods) > j, ", ", "")))
							Me.T2.ForeColor = Color.Green
							Me.T2.Left = Conversions.ToInteger(Operators.AddObject(Me.T1.Left + Me.T1.Width, Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem <> 1, 0, 2)))
							Me.T2.Visible = True
						Case 3
							Me.T3.Text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(CInt(RSWIN_DESC.rst.NumRods) > j, ", ", "")))
							Me.T3.ForeColor = Color.Blue
							Me.T3.Visible = True
							Me.T3.Left = Conversions.ToInteger(Operators.AddObject(Me.T2.Left + Me.T2.Width, Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem <> 1, 0, 2)))
						Case 4
							Me.T4.Text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(CInt(RSWIN_DESC.rst.NumRods) > j, ", ", "")))
							Me.T4.ForeColor = Color.Magenta
							Me.T4.Visible = True
							Me.T4.Left = Conversions.ToInteger(Operators.AddObject(Me.T3.Left + Me.T3.Width, Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem <> 1, 0, 2)))
						Case 5
							Me.T5.Text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(CInt(RSWIN_DESC.rst.NumRods) > j, ", ", "")))
							Me.T5.ForeColor = Color.MediumTurquoise
							Me.T5.Visible = True
							Me.T5.Left = Conversions.ToInteger(Operators.AddObject(Me.T4.Left + Me.T4.Width, Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem <> 1, 0, 2)))
						Case 6
							Me.T6.Text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(CInt(RSWIN_DESC.rst.NumRods) > j, ", ", "")))
							Me.T6.ForeColor = Color.Orange
							Me.T6.Visible = True
							Me.T6.Left = Conversions.ToInteger(Operators.AddObject(Me.T5.Left + Me.T5.Width, Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem <> 1, 0, 2)))
						Case 7
							Me.T7.Text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(CInt(RSWIN_DESC.rst.NumRods) > j, ", ", "")))
							Me.T7.ForeColor = Color.Purple
							Me.T7.Visible = True
							Me.T7.Left = Conversions.ToInteger(Operators.AddObject(Me.T6.Left + Me.T6.Width, Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem <> 1, 0, 2)))
						Case 8
							Me.T8.Text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(CInt(RSWIN_DESC.rst.NumRods) > j, ", ", "")))
							Me.T8.ForeColor = Color.Tan
							Me.T8.Visible = True
							Me.T8.Left = Conversions.ToInteger(Operators.AddObject(Me.T7.Left + Me.T7.Width, Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem <> 1, 0, 2)))
						Case 9
							Me.T9.Text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(CInt(RSWIN_DESC.rst.NumRods) > j, ", ", "")))
							Me.T9.ForeColor = Color.DarkRed
							Me.T9.Visible = True
							Me.T9.Left = Conversions.ToInteger(Operators.AddObject(Me.T8.Left + Me.T8.Width, Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem <> 1, 0, 2)))
						Case 10
							Me.T10.Text = text
							Me.T10.ForeColor = Color.Gray
							Me.T10.Visible = True
							Me.T10.Left = Conversions.ToInteger(Operators.AddObject(Me.T9.Left + Me.T9.Width, Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem <> 1, 0, 2)))
						Case 11
							Me.T11.Text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(CInt(RSWIN_DESC.rst.NumRods) > j, ", ", "")))
							Me.T11.ForeColor = Color.Red
							If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
								Me.T11.Left = Me.T1.Left
							Else
								Me.T11.Left = Conversions.ToInteger(Operators.AddObject(Me.T10.Left + Me.T10.Width, Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem <> 1, 0, 2)))
							End If
							Me.T11.Visible = True
						Case 12
							Me.T12.Text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(CInt(RSWIN_DESC.rst.NumRods) > j, ", ", "")))
							Me.T12.ForeColor = Color.Green
							If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
								Me.T12.Left = Me.T2.Left
							Else
								Me.T12.Left = Conversions.ToInteger(Operators.AddObject(Me.T11.Left + Me.T11.Width, Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem <> 1, 0, 2)))
							End If
							Me.T12.Visible = True
						Case 13
							Me.T13.Text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(CInt(RSWIN_DESC.rst.NumRods) > j, ", ", "")))
							Me.T13.ForeColor = Color.Blue
							Me.T13.Visible = True
							If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
								Me.T13.Left = Me.T3.Left
							Else
								Me.T13.Left = Conversions.ToInteger(Operators.AddObject(Me.T12.Left + Me.T12.Width, Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem <> 1, 0, 2)))
							End If
						Case 14
							Me.T14.Text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(CInt(RSWIN_DESC.rst.NumRods) > j, ", ", "")))
							Me.T14.ForeColor = Color.Magenta
							Me.T14.Visible = True
							If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
								Me.T14.Left = Me.T4.Left
							Else
								Me.T14.Left = Conversions.ToInteger(Operators.AddObject(Me.T13.Left + Me.T13.Width, Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem <> 1, 0, 2)))
							End If
						Case 15
							Me.T15.Text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(CInt(RSWIN_DESC.rst.NumRods) > j, ", ", "")))
							Me.T15.ForeColor = Color.MediumTurquoise
							Me.T15.Visible = True
							If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
								Me.T15.Left = Me.T5.Left
							Else
								Me.T15.Left = Conversions.ToInteger(Operators.AddObject(Me.T14.Left + Me.T14.Width, Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem <> 1, 0, 2)))
							End If
						Case 16
							Me.T16.Text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(CInt(RSWIN_DESC.rst.NumRods) > j, ", ", "")))
							Me.T16.ForeColor = Color.Orange
							Me.T16.Visible = True
							If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
								Me.T16.Left = Me.T6.Left
							Else
								Me.T16.Left = Conversions.ToInteger(Operators.AddObject(Me.T15.Left + Me.T15.Width, Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem <> 1, 0, 2)))
							End If
						Case 17
							Me.T17.Text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(CInt(RSWIN_DESC.rst.NumRods) > j, ", ", "")))
							Me.T17.ForeColor = Color.Purple
							Me.T17.Visible = True
							If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
								Me.T17.Left = Me.T7.Left
							Else
								Me.T17.Left = Conversions.ToInteger(Operators.AddObject(Me.T16.Left + Me.T16.Width, Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem <> 1, 0, 2)))
							End If
						Case 18
							Me.T18.Text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(CInt(RSWIN_DESC.rst.NumRods) > j, ", ", "")))
							Me.T18.ForeColor = Color.Tan
							Me.T18.Visible = True
							If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
								Me.T18.Left = Me.T8.Left
							Else
								Me.T18.Left = Conversions.ToInteger(Operators.AddObject(Me.T17.Left + Me.T17.Width, Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem <> 1, 0, 2)))
							End If
						Case 19
							Me.T19.Text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(CInt(RSWIN_DESC.rst.NumRods) > j, ", ", "")))
							Me.T19.ForeColor = Color.DarkRed
							Me.T19.Visible = True
							If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
								Me.T19.Left = Me.T9.Left
							Else
								Me.T19.Left = Conversions.ToInteger(Operators.AddObject(Me.T18.Left + Me.T18.Width, Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem <> 1, 0, 2)))
							End If
						Case 20
							Me.T20.Text = text
							Me.T20.ForeColor = Color.Gray
							If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
								Me.T20.Left = Me.T10.Left
							Else
								Me.T20.Left = Conversions.ToInteger(Operators.AddObject(Me.T19.Left + Me.T19.Width, Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem <> 1, 0, 2)))
							End If
							Me.T20.Visible = True
					End Select
				Next
			End If
			If RSWIN_DESC.rst.NumRods > 10S And RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
				Me.lblDiameters.Visible = True
				Me.T11.Top = Me.lblDiameters2.Top
				Me.T12.Top = Me.lblDiameters2.Top
				Me.T13.Top = Me.lblDiameters2.Top
				Me.T14.Top = Me.lblDiameters2.Top
				Me.T15.Top = Me.lblDiameters2.Top
				Me.T16.Top = Me.lblDiameters2.Top
				Me.T17.Top = Me.lblDiameters2.Top
				Me.T18.Top = Me.lblDiameters2.Top
				Me.T19.Top = Me.lblDiameters2.Top
				Me.T20.Top = Me.lblDiameters2.Top
			Else
				Me.lblDiameters.Visible = True
				Me.T11.Top = Me.lblDiameters.Top
				Me.T12.Top = Me.lblDiameters.Top
				Me.T13.Top = Me.lblDiameters.Top
				Me.T14.Top = Me.lblDiameters.Top
				Me.T15.Top = Me.lblDiameters.Top
				Me.T16.Top = Me.lblDiameters.Top
				Me.T17.Top = Me.lblDiameters.Top
				Me.T18.Top = Me.lblDiameters.Top
				Me.T19.Top = Me.lblDiameters.Top
				Me.T20.Top = Me.lblDiameters.Top
			End If
			Me.TChart1.Aspect.Chart3DPercent = 100
			Me.TChart1.Aspect.Orthogonal = False
			Me.TChart1.Aspect.Perspective = 50
			Me.TChart1.Aspect.Rotation = 340
			Me.TChart1.Aspect.Elevation = 352
			Me.TChart1.Aspect.Zoom = 70
			Me.TChart1.Aspect.View3D = True
			Me.TChart1.Aspect.HorizOffset = 0
			Me.TChart1.Aspect.VertOffset = 0
			Me.TChart1.Aspect.ZOffset = 0.0
			Me.TChart1.Visible = True
			Me.commander1.Visible = True
			Me.pnlLegend.Visible = True
			Me.btnResetPlot.Visible = True
		End Sub

		Private Function GetAxisMinMax(fInc As Single, Max As Single, Min As Single) As Single
			Dim num As Single
			If Math.Abs(Max) > Math.Abs(Min) Then
				num = Math.Abs(Max)
			Else
				num = Math.Abs(Min)
			End If
			Dim num2 As Integer = 1
			Dim num3 As Single
			While Not(num >= CSng(num2) * fInc And num < CSng((num2 + 1)) * fInc)
				' The following expression was wrapped in a checked-statement
				num2 += 1
				If num2 > 500 Then
					IL_4B:
					If num3 = 0F Then
						num3 = fInc
					End If
					Return num3
				End If
			End While
			num3 = CSng((num2 + 1)) * fInc
			GoTo IL_4B
		End Function

		Private Sub txtAzimuth_KeyDown(sender As Object, e As KeyEventArgs)
			Me.m_AzimuthKeyDnKeyCode = e.KeyCode
			If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Me.m_AzimuthKeyDnKeyCode, Nothing, False))) AndAlso Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(Me.m_AzimuthKeyDnKeyCode, Keys.Tab, False), Operators.CompareObjectEqual(Me.m_AzimuthKeyDnKeyCode, Keys.[Return], False))) Then
				Dim activeCell As UltraGridCell = Me.ulgDeviationProfile.ActiveCell
				Dim activeRow As UltraGridRow = Me.ulgDeviationProfile.ActiveRow
				If activeCell IsNot Nothing Then
					Dim ultraGridCell As UltraGridCell = activeCell
					If Operators.CompareString(ultraGridCell.Column.Key, "Azimuth", False) = 0 Then
						Dim flag As Boolean
						If Operators.CompareString(Me.txtAzimuth.Text, "0", False) = 0 Then
							flag = True
						Else
							Me.bEditAzimuth = True
							Dim text As String = Me.txtAzimuth.Text
							Dim text2 As String = Me.AzimuthCheck(text)
							If Operators.CompareString(text, Me.txtAzimuth.Text, False) <> 0 Then
								Me.txtAzimuth.Text = text
							End If
							Me.bEditAzimuth = False
							flag = Versioned.IsNumeric(text2)
						End If
						If flag Then
							Dim ulgDeviationProfile As UltraGrid = Me.ulgDeviationProfile
							If Information.IsDBNull(RuntimeHelpers.GetObjectValue(ulgDeviationProfile.ActiveCell.Value)) Then
								ulgDeviationProfile.ActiveCell.Value = Me.txtAzimuth.Text
							ElseIf Operators.ConditionalCompareObjectNotEqual(ulgDeviationProfile.ActiveCell.Value, Me.txtAzimuth.Text, False) Then
								ulgDeviationProfile.ActiveCell.Value = Me.txtAzimuth.Text
							End If
						End If
					End If
				End If
				If activeRow Is Nothing Then
					Return
				End If
				Dim ultraGridRow As UltraGridRow
				If activeRow.HasNextSibling() Then
					ultraGridRow = activeRow.GetSibling(SiblingRow.[Next])
				Else
					ultraGridRow = Nothing
				End If
				If ultraGridRow IsNot Nothing Then
					Me.SelectRow(ultraGridRow, True)
					Me.ulgDeviationProfile.ActiveCell = ultraGridRow.Cells("Depth")
					Me.ulgDeviationProfile.PerformAction(UltraGridAction.EnterEditMode)
				End If
			End If
		End Sub

		Private Sub txtAzimuth_KeyUp(sender As Object, e As KeyEventArgs)
		End Sub

		Private Sub txtInclination_KeyUp(sender As Object, e As KeyEventArgs)
		End Sub

		Private Sub txtInclination_KeyDown(sender As Object, e As KeyEventArgs)
			Dim obj As Object = Me.IsInputKey(e.KeyCode)
			Me.m_InclinationKeyDnKeyCode = e.KeyCode
			If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Me.m_InclinationKeyDnKeyCode, Nothing, False))) AndAlso Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(Me.m_InclinationKeyDnKeyCode, Keys.Tab, False), Operators.CompareObjectEqual(Me.m_InclinationKeyDnKeyCode, Keys.[Return], False))) Then
				Dim activeCell As UltraGridCell = Me.ulgDeviationProfile.ActiveCell
				Dim activeRow As UltraGridRow = Me.ulgDeviationProfile.ActiveRow
				If activeRow Is Nothing Then
					Return
				End If
				If activeCell IsNot Nothing Then
					Dim ultraGridCell As UltraGridCell = activeCell
					If Operators.CompareString(ultraGridCell.Column.Key, "Inclination", False) = 0 Then
						Dim text As String = Me.InclinationCheck(Me.txtInclination.Text)
						Dim num As Integer = If((-If((Versioned.IsNumeric(text) > False), 1, 0)), 1, 0)
						If num <> 0 Then
							Dim ulgDeviationProfile As UltraGrid = Me.ulgDeviationProfile
							If Information.IsDBNull(RuntimeHelpers.GetObjectValue(ulgDeviationProfile.ActiveCell.Value)) Then
								ulgDeviationProfile.ActiveCell.Value = Me.txtInclination.Text
							ElseIf Operators.ConditionalCompareObjectNotEqual(ulgDeviationProfile.ActiveCell.Value, Me.txtInclination.Text, False) Then
								ulgDeviationProfile.ActiveCell.Value = Me.txtInclination.Text
							End If
						End If
					End If
				End If
				Me.ulgDeviationProfile.ActiveCell = activeRow.Cells("Azimuth")
				Me.ulgDeviationProfile.PerformAction(UltraGridAction.EnterEditMode)
			End If
		End Sub

		Private Sub DeviationProfile_KeyDown(sender As Object, e As KeyEventArgs)
			Me.m_InclinationKeyDnKeyCode = False
			Me.m_AzimuthKeyDnKeyCode = False
		End Sub

		Private Sub DeviationProfile_KeyUp(sender As Object, e As KeyEventArgs)
			Try
				If Me.ulgDeviationProfile.ActiveCell IsNot Nothing Then
					Dim activeCell As UltraGridCell = Me.ulgDeviationProfile.ActiveCell
				End If
				Me.ResetClock()
				If e.KeyCode = Keys.Tab And Operators.CompareString(Me.ulgDeviationProfile.ActiveCell.Column.Key, "Inclination", False) = 0 And Operators.CompareString(Me.ActiveControl.Name, "ulgDeviationProfile", False) = 0 Then
					Dim activeCell As UltraGridCell = Me.ulgDeviationProfile.ActiveCell
					Dim activeRow As UltraGridRow = Me.ulgDeviationProfile.ActiveRow
					If activeRow IsNot Nothing Then
						Me.ulgDeviationProfile.ActiveCell = activeRow.Cells("Azimuth")
						Me.ulgDeviationProfile.PerformAction(UltraGridAction.EnterEditMode)
					End If
				ElseIf e.KeyCode = Keys.Tab And Operators.CompareString(Me.ulgDeviationProfile.ActiveCell.Column.Key, "Azimuth", False) = 0 And Operators.CompareString(Me.ActiveControl.Name, "ulgDeviationProfile", False) = 0 Then
					Dim activeCell As UltraGridCell = Me.ulgDeviationProfile.ActiveCell
					Dim activeRow As UltraGridRow = Me.ulgDeviationProfile.ActiveRow
					If activeRow IsNot Nothing Then
						Dim ultraGridRow As UltraGridRow
						If activeRow.HasNextSibling() Then
							ultraGridRow = activeRow.GetSibling(SiblingRow.[Next])
						Else
							ultraGridRow = Nothing
						End If
						If ultraGridRow IsNot Nothing Then
							Me.SelectRow(ultraGridRow, True)
							Me.ulgDeviationProfile.ActiveCell = ultraGridRow.Cells("Depth")
							Me.ulgDeviationProfile.PerformAction(UltraGridAction.EnterEditMode)
						End If
					End If
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub DeviationProfile_Closed(sender As Object, e As EventArgs)
			Me.m_bClosing = False
		End Sub

		Private Sub DeviationProfile_Leave(sender As Object, e As EventArgs)
			Me.m_bClosing = False
			If RSWIN_DESC.mdsDeviationProfile_Edit IsNot Nothing Then
				Dim flag2 As Boolean
				Dim flag As Boolean = Me.CheckForValidValues(RSWIN_DESC.mdsDeviationProfile_Edit, flag2, 0)
				If Not flag And Not flag2 And RSWIN_DESC.mdsDeviationProfile_Edit.Tables(0).Rows.Count > 0 Then
					Interaction.MsgBox("NULL values for Depth, Inclination or Azimuth are not allowed. Please review the data!", MsgBoxStyle.OKOnly, Nothing)
					Return
				End If
				If Not flag AndAlso flag2 Then
					Me.SaveDeviationSurvey2()
				Else
					Me.SaveDeviationSurvey()
				End If
				Me.ulgDeviationProfile.Visible = True
				If RSWIN_DESC.mdsDeviationProfile_Edit.Tables(0).Rows.Count > 0 Then
					Dim num As Double = 0.0
					Dim num2 As Short = 1S
					Dim numRods As Short = RSWIN_DESC.rst.NumRods
					For num3 As Short = num2 To numRods
						num += CDbl(RSWIN_DESC.rst.Sections(CInt(num3)).length)
					Next
					Dim mdsDeviationProfile_Edit As DataSet = RSWIN_DESC.mdsDeviationProfile_Edit
					If mdsDeviationProfile_Edit.Tables(0).Rows.Count > 0 Then
						Dim lastDepth As Single = Util.GetLastDepth(RSWIN_DESC.mdsDeviationProfile_Edit, True, 0)
						If(num > CDbl(lastDepth) And num - CDbl(lastDepth) > 50.0) AndAlso Me.bAnswered Then
							' The following expression was wrapped in a checked-statement
							If Util.YesNo(Me.sDYWFill, False, Me.bAnswered) Then
								Dim dataRow As DataRow
								Dim num4 As Single = Conversions.ToSingle(dataRow("Depth"))
								Dim num5 As Single = Conversions.ToSingle(dataRow("Inclination"))
								Dim num6 As Single = Conversions.ToSingle(dataRow("Azimuth"))
								Dim num7 As Single = 0F
								Dim num8 As Short = 1S
								Dim num9 As Single = 0F
								Dim num10 As Single = Conversions.ToSingle(dataRow("Depth"))
								Try
									For Each obj As Object In RSWIN_DESC.mdsDeviationProfile_Edit.Tables(0).Rows
										dataRow = CType(obj, DataRow)
										num8 += 1S

											num7 += num10 - num9
											num9 = num10
											num10 = Conversions.ToSingle(dataRow("Depth"))

									Next
								Finally
									Dim enumerator As IEnumerator
									If TypeOf enumerator Is IDisposable Then
										TryCast(enumerator, IDisposable).Dispose()
									End If
								End Try
								num8 -= 1S
								Dim num11 As Short
								If num8 <> 0S Or num7 <> 0F Then
									num11 = CShort(Math.Round(CDbl((num7 / CSng(num8)))))
								Else
									num11 = 100S
								End If
								Dim num12 As Single = num4
								Dim num3 As Short = num8
								Do
									' The following expression was wrapped in a unchecked-expression
									num12 = CSng(CShort(Math.Round(CDbl((num12 + CSng(num11))))))
									num3 += 1S
									Me.AddEntry(RSWIN_DESC.mdsDeviationProfile, num3, num12, num5, num6, 0, 0, 0, 0)
								Loop While CDbl(num12) < num
							End If
						End If
					End If
				End If
			End If
		End Sub

		Private Sub optPolishedRodDrag_Click(Index As Integer)
			' The following expression was wrapped in a checked-expression
			RSWIN_DESC.rst.DragSettings = CShort((Index * 16 Or CInt((RSWIN_DESC.rst.DragSettings And -49S))))
		End Sub

		Private Sub optPumpDragDown_Click(Index As Integer)
			' The following expression was wrapped in a checked-expression
			RSWIN_DESC.rst.DragSettings = CShort((Index * 4 Or CInt((RSWIN_DESC.rst.DragSettings And -13S))))
		End Sub

		Private Sub optPumpDragUp_Click(Index As Integer)
			' The following expression was wrapped in a checked-expression
			RSWIN_DESC.rst.DragSettings = CShort((Index Or CInt((RSWIN_DESC.rst.DragSettings And -4S))))
		End Sub

		Private Sub _optPumpDragUp_0_CheckedChanged(sender As Object, e As EventArgs)
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
			Me.optPumpDragUp_Click(0)
		End Sub

		Private Sub _optPumpDragDown_0_CheckedChanged(sender As Object, e As EventArgs)
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
			Me.optPumpDragDown_Click(0)
		End Sub

		Private Sub _optPumpDragDown_1_CheckedChanged(sender As Object, e As EventArgs)
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
			Me.optPumpDragDown_Click(1)
		End Sub

		Private Sub _optPolishedRodDrag_0_CheckedChanged(sender As Object, e As EventArgs)
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
			Me.optPolishedRodDrag_Click(0)
		End Sub

		Private Sub _optPumpDragUp_1_CheckedChanged(sender As Object, e As EventArgs)
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
			Me.optPumpDragUp_Click(1)
		End Sub

		Private Sub _optPumpDragUp_2_CheckedChanged(sender As Object, e As EventArgs)
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
			Me.optPumpDragUp_Click(2)
		End Sub

		Private Sub _optPumpDragDown_2_CheckedChanged(sender As Object, e As EventArgs)
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
			Me.optPumpDragDown_Click(2)
		End Sub

		Private Sub _optPolishedRodDrag_1_CheckedChanged(sender As Object, e As EventArgs)
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
			Me.optPolishedRodDrag_Click(1)
		End Sub

		Private Sub _optPolishedRodDrag_2_CheckedChanged(sender As Object, e As EventArgs)
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
			Me.optPolishedRodDrag_Click(2)
		End Sub

		Private Sub txtPumpDragUpstrokeMax_TextChanged(sender As Object, e As EventArgs)
			Try
				Application.DoEvents()
			Catch ex As Exception
			End Try
		End Sub

		Private Sub txtPumpDragDownstrokeMax_TextChanged(sender As Object, e As EventArgs)
			Try
				Application.DoEvents()
			Catch ex As Exception
			End Try
		End Sub

		Private Sub calc_sur(ByRef p_s As DeviationProfile.parameter_structure_type, ByRef s_p As DeviationProfile.survey_point_type())
			Dim num As Integer
			Dim num13 As Integer
			Dim obj As Object
			Try
				ProjectData.ClearProjectError()
				num = 2
				p_s.iostat = 0
				Dim num2 As Short = 1S
				Dim num3 As Short = CShort(p_s.num_survey_points)
				For num4 As Short = num2 To num3
					s_p(CInt(num4)).tan.X = Math.Sin(s_p(CInt(num4)).inc) * Math.Sin(s_p(CInt(num4)).azi)
					s_p(CInt(num4)).tan.Y = Math.Sin(s_p(CInt(num4)).inc) * Math.Cos(s_p(CInt(num4)).azi)
					s_p(CInt(num4)).tan.z = Math.Cos(s_p(CInt(num4)).inc)
				Next
				Dim num5 As Short = 1S
				Dim num6 As Short = CShort((p_s.num_survey_points - 1))
				For num4 As Short = num5 To num6
					' The following expression was wrapped in a checked-expression
					Dim num7 As Double = Me.dot_prod(s_p(CInt(num4)).tan, s_p(CInt((num4 + 1S))).tan)
					If num7 > 1.0 Then
						If num7 > 1.0 + p_s.epsilon Then
							p_s.iostat = -9941
							GoTo IL_554
						End If
						num7 = 1.0
					End If
					If num7 < 0.0 Then
						If num7 < -p_s.epsilon Then
							p_s.iostat = -9942
							GoTo IL_554
						End If
						num7 = 0.0
					End If
					s_p(CInt(num4)).dog = kinemat.ArcCosine(CSng(num7))
					If s_p(CInt(num4)).dog > p_s.epsilon Then
						' The following expression was wrapped in a checked-expression
						s_p(CInt(num4)).rad = (s_p(CInt((num4 + 1S))).m_d - s_p(CInt(num4)).m_d) / s_p(CInt(num4)).dog
					Else
						s_p(CInt(num4)).rad = -9999.0
					End If
				Next
				Dim num8 As Short
				Dim num9 As Short
				Dim num4 As Short = CShort(p_s.num_survey_points)
				s_p(CInt(num4)).dog = -9999.0
				s_p(CInt(num4)).rad = -9999.0
				num8 = 1S
				num9 = CShort((p_s.num_survey_points - 1))
				Dim num10 As Integer
				For num4 As Short = num8 To num9
					If s_p(CInt(num4)).dog > p_s.epsilon Then
						' The following expression was wrapped in a checked-expression
						Me.calc_nor(s_p(CInt(num4)).nor, s_p(CInt(num4)).tan, s_p(CInt((num4 + 1S))).tan)
					Else
						s_p(CInt(num4)).nor.X = -9999.0
						s_p(CInt(num4)).nor.Y = -9999.0
						s_p(CInt(num4)).nor.z = -9999.0
					End If
					If s_p(CInt(num4)).m_d <= CDbl(RSWIN_DESC.rst.PumpDepth) Then
						num10 = CInt(num4)
					End If
				Next
				Dim num11 As Short
				Dim num12 As Short
				If s_p(num10).m_d < CDbl(RSWIN_DESC.rst.PumpDepth) Then
					num10 += 1
				End If
				Dim num4 As Short = CShort(p_s.num_survey_points)
				s_p(CInt(num4)).nor.X = -9999.0
				s_p(CInt(num4)).nor.Y = -9999.0
				s_p(CInt(num4)).nor.z = -9999.0
				num4 = 1S
				s_p(CInt(num4)).pos.X = 0.0
				s_p(CInt(num4)).pos.Y = 0.0
				s_p(CInt(num4)).pos.z = 0.0
				num11 = 2S
				num12 = CShort(p_s.num_survey_points)
				For num4 As Short = num11 To num12
					' The following expression was wrapped in a checked-statement
					If s_p(CInt((num4 - 1S))).dog > p_s.epsilon Then
						Me.calc_pos(s_p(CInt(num4)).pos, s_p(CInt((num4 - 1S))).pos, s_p(CInt((num4 - 1S))).tan, s_p(CInt((num4 - 1S))).nor, s_p(CInt((num4 - 1S))).dog, s_p(CInt((num4 - 1S))).rad)
					Else
						Me.calc_str(s_p(CInt(num4)).pos, s_p(CInt((num4 - 1S))).pos, s_p(CInt((num4 - 1S))).tan, s_p(CInt(num4)).m_d, s_p(CInt((num4 - 1S))).m_d)
					End If
				Next
				GoTo IL_554
				IL_4E6:
				p_s.iostat = -9999
				Interaction.MsgBox("Error: in calc_sur " + Information.Err().Description, MsgBoxStyle.OKOnly, Nothing)
				GoTo IL_554
				IL_50F:
				num13 = -1
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_525:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num13 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_50F
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_554:
			If num13 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		Private Sub UnloadAllFormsExceptMe()
			Try
				For Each form As Form In Me.ParentForm.MdiChildren
					Try
						If form IsNot Nothing AndAlso (Operators.CompareString(form.Name, Me.Name, False) <> 0 And Operators.CompareString(form.Name, "VisInput", False) <> 0) Then
							form.Hide()
						End If
					Catch ex As Exception
					End Try
				Next
			Catch ex2 As Exception
			End Try
		End Sub

		Private Sub point3DSeries1_GetPointerStyle(series As Points3D, e As GetPointerStyleEventArgs)
			Dim num As Double = Me.point3DSeries1.YValues(e.ValueIndex)
			Dim num2 As Double = CDbl(Me.GetMDVal(CSng(num)))
			If num2 = 0.0 Then
				Me.m_bAfterPump = False
			End If
			If num2 < Me.tmp_PumpDepth And Not Me.m_bAfterPump Then
				Me.m_bAfterPump = False
			ElseIf Not Me.m_bAfterPump Then
				Me.m_bAfterPump = True
			End If
			Debug.WriteLine(" MDVAL=" + Conversions.ToString(num2) + ",  TVDVal=" + Conversions.ToString(num))
			If RSWIN_DESC.rst.NumRods > 0S Then
				If Me.m_bAfterPump Then
					Me.point3DSeries1.LinePen.Color = Color.Black
					Return
				End If
				If num2 <= CDbl(RSWIN_DESC.taper_lens(1)) Or RSWIN_DESC.rst.NumRods = 1S Then
					Me.point3DSeries1.LinePen.Color = Color.Red
					Return
				End If
				If num2 <= CDbl(RSWIN_DESC.taper_lens(2)) Or RSWIN_DESC.rst.NumRods = 2S Then
					Me.point3DSeries1.LinePen.Color = Color.Green
					Return
				End If
				If num2 <= CDbl(RSWIN_DESC.taper_lens(3)) Or RSWIN_DESC.rst.NumRods = 3S Then
					Me.point3DSeries1.LinePen.Color = Color.Blue
					Return
				End If
				If num2 <= CDbl(RSWIN_DESC.taper_lens(4)) Or RSWIN_DESC.rst.NumRods = 4S Then
					Me.point3DSeries1.LinePen.Color = Color.Magenta
					Return
				End If
				If num2 <= CDbl(RSWIN_DESC.taper_lens(5)) Or RSWIN_DESC.rst.NumRods = 5S Then
					Me.point3DSeries1.LinePen.Color = Color.MediumTurquoise
					Return
				End If
				If num2 <= CDbl(RSWIN_DESC.taper_lens(6)) Or RSWIN_DESC.rst.NumRods = 6S Then
					Me.point3DSeries1.LinePen.Color = Color.Orange
					Return
				End If
				If num2 <= CDbl(RSWIN_DESC.taper_lens(7)) Or RSWIN_DESC.rst.NumRods = 7S Then
					Me.point3DSeries1.LinePen.Color = Color.Purple
					Return
				End If
				If num2 <= CDbl(RSWIN_DESC.taper_lens(8)) Or RSWIN_DESC.rst.NumRods = 8S Then
					Me.point3DSeries1.LinePen.Color = Color.Tan
					Return
				End If
				If num2 <= CDbl(RSWIN_DESC.taper_lens(9)) Or RSWIN_DESC.rst.NumRods = 9S Then
					Me.point3DSeries1.LinePen.Color = Color.DarkRed
					Return
				End If
				If num2 <= CDbl(RSWIN_DESC.taper_lens(10)) Or RSWIN_DESC.rst.NumRods = 10S Then
					Me.point3DSeries1.LinePen.Color = Color.Gray
					Return
				End If
				If num2 <= CDbl(RSWIN_DESC.taper_lens(11)) Or RSWIN_DESC.rst.NumRods = 11S Then
					Me.point3DSeries1.LinePen.Color = Color.Red
					Return
				End If
				If num2 <= CDbl(RSWIN_DESC.taper_lens(12)) Or RSWIN_DESC.rst.NumRods = 12S Then
					Me.point3DSeries1.LinePen.Color = Color.Green
					Return
				End If
				If num2 <= CDbl(RSWIN_DESC.taper_lens(13)) Or RSWIN_DESC.rst.NumRods = 13S Then
					Me.point3DSeries1.LinePen.Color = Color.Blue
					Return
				End If
				If num2 <= CDbl(RSWIN_DESC.taper_lens(14)) Or RSWIN_DESC.rst.NumRods = 14S Then
					Me.point3DSeries1.LinePen.Color = Color.Magenta
					Return
				End If
				If num2 <= CDbl(RSWIN_DESC.taper_lens(15)) Or RSWIN_DESC.rst.NumRods = 15S Then
					Me.point3DSeries1.LinePen.Color = Color.MediumTurquoise
					Return
				End If
				If num2 <= CDbl(RSWIN_DESC.taper_lens(16)) Or RSWIN_DESC.rst.NumRods = 16S Then
					Me.point3DSeries1.LinePen.Color = Color.Orange
					Return
				End If
				If num2 <= CDbl(RSWIN_DESC.taper_lens(17)) Or RSWIN_DESC.rst.NumRods = 17S Then
					Me.point3DSeries1.LinePen.Color = Color.Purple
					Return
				End If
				If num2 <= CDbl(RSWIN_DESC.taper_lens(18)) Or RSWIN_DESC.rst.NumRods = 18S Then
					Me.point3DSeries1.LinePen.Color = Color.Cyan
					Return
				End If
				If num2 <= CDbl(RSWIN_DESC.taper_lens(19)) Or RSWIN_DESC.rst.NumRods = 19S Then
					Me.point3DSeries1.LinePen.Color = Color.DarkRed
					Return
				End If
				If num2 <= CDbl(RSWIN_DESC.taper_lens(20)) Or RSWIN_DESC.rst.NumRods = 20S Then
					Me.point3DSeries1.LinePen.Color = Color.Gray
					Return
				End If
			Else
				Me.point3DSeries1.LinePen.Color = Color.Red
			End If
		End Sub

		Private Sub marksTip1_GetText(sender As MarksTip, e As MarksTipGetTextEventArgs)
			' The following expression was wrapped in a checked-statement
			Try
				Dim text As String = e.Text
				Dim num As Double = Conversions.ToDouble(text.Substring(0, Strings.InStr(text, " ", CompareMethod.Binary) - 1))
				Dim num2 As Single = Conversions.ToSingle(text.Substring(Strings.InStr(text, " ", CompareMethod.Binary)))
				Dim num3 As Integer = 0
				Dim count As Integer = Me.point3DSeries1.Count
				For i As Integer = num3 To count
					' The following expression was wrapped in a unchecked-expression
					If Math.Abs(Me.point3DSeries1.XValues(i) - num) < 0.1 Then
						e.Text = String.Concat(New String() { Convert.ToString(Me.point3DSeries1.XValues.Value(i)), ", ", Convert.ToString(Me.point3DSeries1.YValues.Value(i)), ", ", Convert.ToString(Me.point3DSeries1.ZValues.Value(i)) })
					End If
				Next
			Catch ex As Exception
			End Try
		End Sub

		Private Function GetMDVal(TVDVal As Single) As Single
			' The following expression was wrapped in a checked-statement
			Dim result As Single
			Try
				Dim num As Integer = Information.UBound(Me.m_TVDepth, 1)
				Dim num2 As Integer = 0
				Dim num3 As Integer = num
				For i As Integer = num2 To num3
					' The following expression was wrapped in a unchecked-expression
					If Math.Abs(CDbl(TVDVal) - Me.m_TVDepth(i)) <= 0.1 Then
						result = CSng(Me.m_MeasDepth(i))
						Exit For
					End If
				Next
			Catch ex As Exception
			End Try
			Return result
		End Function

		Private Sub btnResetPlot_Click(sender As Object, e As EventArgs)
			Me.ResetClock()
			Dim flag As Boolean = Me.CheckDeviationProfile()
			If flag Then
				Me.TChart1.Visible = False
				Me.ShowDeviation_Dogleg(CType(Me.ulgDeviationProfile.DataSource, DataSet), True, False)
				Dim dsDeviationProfile As DataSet = CType(Me.ulgDeviationProfile.DataSource, DataSet)
				Dim bPlotData As Boolean = True
				Dim obj As Object
				Dim num As Short = Conversions.ToShort(obj)
				Me.ShowDeviation_TVD(dsDeviationProfile, bPlotData, num)
				obj = num
			End If
			Application.DoEvents()
		End Sub

		Private Sub ulgDeviationProfile_KeyPress(sender As Object, e As KeyPressEventArgs)
			Try
			Catch ex As Exception
			End Try
		End Sub

		Private Function HasFGlass() As Boolean
			Dim flag As Boolean = False
			Try
				If RSWIN_DESC.rst.RodStringType = 2S Then
					flag = False
					Dim rst As cRODSTAR = RSWIN_DESC.rst
					Dim num As Integer = 1
					Dim numRods As Integer = CInt(rst.NumRods)
					For i As Integer = num To numRods
						If RODUTIL.IsFG(rst.Sections(i).Grade) Then
							flag = True
							Exit For
						End If
					Next
				ElseIf RSWIN_DESC.rst.RodStringType = 3S And RSWIN_DESC.rst.giRodDesignStyle = 1S Then
					flag = True
				Else
					flag = False
				End If
			Catch ex As Exception
				flag = False
			End Try
			If flag Then
				MessageBox.Show("Design of deviated wells not allowed Fiberglass rods.")
			End If
			Return flag
		End Function

		Public Sub CenterForm()
			' The following expression was wrapped in a checked-statement
			Try
				If Me.MyParentFrm Is Nothing Then
					Try
						Me.MyParentFrm = CType(Me.ParentForm, RODSTAR)
					Catch ex As Exception
					End Try
				End If
				Me.Left = CInt(Math.Round(CDbl((Me.MyParentFrm.Width - Me.Width)) / 2.0 - 8.0))
				Me.Top = CInt(Math.Round(CDbl((Me.MyParentFrm.Height - Me.Height)) / 2.0 - CDbl(Me.MyParentFrm.ParentToolbarHeight())))
			Catch ex2 As Exception
			End Try
		End Sub

		Private Sub SetDoglegColumnHeader()
			Dim ultraGridColumn As UltraGridColumn = Me.ulgDeviationProfile.DisplayLayout.Bands(0).Columns("Dogleg")
			If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
				ultraGridColumn.Header.Caption = "Dogleg sev. °/100ft"
				ultraGridColumn.Tag = ""
			Else
				ultraGridColumn.Header.Caption = "Dogleg sev. °/30m"
				ultraGridColumn.Tag = ""
			End If
		End Sub

		Private Sub SetMeasDepthColumnHeader()
			Dim ultraGridColumn As UltraGridColumn = Me.ulgDeviationProfile.DisplayLayout.Bands(0).Columns("Depth")
			If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
				ultraGridColumn.Header.Caption = "Meas. depth (ft)"
			Else
				ultraGridColumn.Header.Caption = "Meas. depth (m)"
			End If
		End Sub

		Private Sub TChart1_MouseDown(sender As Object, e As MouseEventArgs)
			Try
				Application.DoEvents()
			Catch ex As Exception
			End Try
		End Sub

		Private Sub TChart1_Move(sender As Object, e As EventArgs)
			Try
				Application.DoEvents()
			Catch ex As Exception
			End Try
		End Sub

		Private Sub TurnOffViewReportOption()
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
			Try
				If Me.MyParentFrm Is Nothing Then
					Try
						Me.MyParentFrm = CType(Me.ParentForm, RODSTAR)
					Catch ex2 As Exception
					End Try
				End If
				If Me.MyParentFrm.CheckMdiForm("Results") Then
					Me.MyParentFrm.RemoveChildForm("Results", False)
				End If
				Me.MyParentFrm.ToolbarButtonSetState2(2, False)
			Catch ex3 As Exception
			End Try
		End Sub

		Private Sub Control_SelectedIndexChanged(bActiveControl As Boolean)
			If bActiveControl Then
				RSWIN_DESC.rst.gbInputDataChanged = True
				Me.TurnOffViewReportOption()
				Me.ResetClock()
				Return
			End If
		End Sub

		Private Sub txtInclination_TextChanged(sender As Object, e As EventArgs)
			Try
				If Strings.InStr(Me.txtInclination.Text, vbTab, CompareMethod.Binary) > 0 Or Strings.InStr(Me.txtInclination.Text, vbVerticalTab, CompareMethod.Binary) > 0 Or Strings.InStr(Me.txtInclination.Text, vbCr, CompareMethod.Binary) > 0 Then
					Me.txtInclination.Text = Conversions.ToString(Me.ulgDeviationProfile.ActiveCell.Row.Cells("Inclination").Value)
					MessageBox.Show("Please use Edit/Paste to paste Deviation Survey items from Clipboard.", "Paste Error", MessageBoxButtons.OK)
				Else
					Me.Control_SelectedIndexChanged(Me.ActiveControl Is Me.txtInclination)
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub ulgDeviationProfile_BeforeCellUpdate(sender As Object, e As BeforeCellUpdateEventArgs)
			If Me.ActiveControl IsNot Nothing Then
				Me.Control_SelectedIndexChanged(Me.ActiveControl Is Me.ulgDeviationProfile Or Operators.CompareString(Me.ActiveControl.Name.Trim(), "", False) = 0)
				Return
			End If
		End Sub

		Private Sub cmdDeleteALLSections_Click(sender As Object, e As EventArgs)
			Try
				Me.ResetClock()
				Dim obj As Object = MessageBox.Show(Me.sRemoveALL, Me.sARS, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
				If Operators.ConditionalCompareObjectEqual(obj, DialogResult.Yes, False) Then
					RSWIN_DESC.mdsDeviationProfile_Edit = Nothing
					MImpred.InitSurveyDataset(RSWIN_DESC.mdsDeviationProfile_Edit, Nothing)
					RSWIN_DESC.mdsDeviationProfile = Nothing
					MImpred.InitSurveyDataset(RSWIN_DESC.mdsDeviationProfile, Nothing)
					Dim ulgDeviationProfile As UltraGrid = Me.ulgDeviationProfile
					ulgDeviationProfile.DataSource = RSWIN_DESC.mdsDeviationProfile_Edit
					ulgDeviationProfile.Rows.Refresh(RefreshRow.FireInitializeRow, True)
					Dim ulgDeviationProfile2 As UltraGrid = Me.ulgDeviationProfile
					CtrlUI.Grid_SetLabels(ulgDeviationProfile2, True)
					Me.ulgDeviationProfile = ulgDeviationProfile2
					Me.SetDoglegColumnHeader()
					Me.fMaxMD = 0F
					Me.SetStatus()
				End If
			Catch ex As Exception
			End Try
		End Sub

		Public Sub ImportToGridPasteString(sClipPaste As String)
			' The following expression was wrapped in a checked-statement
			Try
				Dim num As Integer = -1
				Dim text As String = ""
				Dim text2 As String = ""
				Dim text3 As String = ""
				Dim flag As Boolean = True
				Dim flag2 As Boolean = False
				Dim flag3 As Boolean = False
				Dim num2 As Integer = 0
				Dim num3 As Integer = sClipPaste.Length - 1
				Dim array As String()
				Dim array2 As Double()
				Dim array3 As String()
				For i As Integer = num2 To num3
					Debug.WriteLine(sClipPaste.Substring(i, 1) + " , " + Conversions.ToString(Strings.Asc(sClipPaste.Substring(i, 1))))
					If Strings.Asc(sClipPaste.Substring(i, 1)) <> 9 And Strings.Asc(sClipPaste.Substring(i, 1)) <> 10 And Strings.Asc(sClipPaste.Substring(i, 1)) <> 11 And Strings.Asc(sClipPaste.Substring(i, 1)) <> 12 And Strings.Asc(sClipPaste.Substring(i, 1)) <> 13 Then
						If flag Then
							text2 += sClipPaste.Substring(i, 1)
						ElseIf flag2 Then
							text3 += sClipPaste.Substring(i, 1)
						ElseIf flag3 Then
							text += sClipPaste.Substring(i, 1)
						End If
						If i = sClipPaste.Length - 1 Then
							If flag3 And Operators.CompareString(text, "", False) <> 0 Then
								array = CType(Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(CType(array, Array), New String(num + 1 - 1) {}), String())
								array(num) = text
								flag3 = False
								flag2 = False
								flag = True
							End If
						End If
					ElseIf flag And Operators.CompareString(text2, "", False) <> 0 Then
						If Versioned.IsNumeric(text2) Then
							num += 1
							array2 = CType(Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(CType(array2, Array), New Double(num + 1 - 1) {}), Double())
							array2(num) = Convert.ToDouble(text2)
							flag = False
							flag2 = True
							flag3 = False
							text2 = ""
							text3 = ""
							text = ""
						End If
					ElseIf flag2 And Operators.CompareString(text3, "", False) <> 0 Then
						array3 = CType(Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(CType(array3, Array), New String(num + 1 - 1) {}), String())
						array3(num) = text3
						flag2 = False
						flag3 = True
						flag = False
					ElseIf flag3 And Operators.CompareString(text, "", False) <> 0 Then
						array = CType(Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(CType(array, Array), New String(num + 1 - 1) {}), String())
						array(num) = text
						flag3 = False
						flag2 = False
						flag = True
					End If
				Next
				Dim flag5 As Boolean
				If RSWIN_DESC.mdsDeviationProfile_Edit IsNot Nothing Then
					If RSWIN_DESC.mdsDeviationProfile_Edit.Tables(0).Rows.Count > 0 Then
						Dim msg As String = "Replace current survey with items from clipboard?"
						Dim bDefaultYes As Boolean = False
						Dim flag4 As Boolean = False
						flag5 = Util.YesNo(msg, bDefaultYes, flag4)
					Else
						flag5 = True
					End If
				Else
					flag5 = True
				End If
				If flag5 Then
					Me.ulgDeviationProfile.DataSource = Nothing
					RSWIN_DESC.mdsDeviationProfile = Nothing
					RSWIN_DESC.mdsDeviationProfile_Edit = Nothing
					MImpred.InitSurveyDataset(RSWIN_DESC.mdsDeviationProfile, Nothing)
					MImpred.InitSurveyDataset(RSWIN_DESC.mdsDeviationProfile_Edit, Nothing)
					Dim mdsDeviationProfile_Edit As DataSet = RSWIN_DESC.mdsDeviationProfile_Edit
					Dim num4 As Integer = 0
					Dim num5 As Integer = num
					For j As Integer = num4 To num5
						Debug.WriteLine(String.Concat(New String() { Conversions.ToString(array2(j)), " , ", array3(j), " , ", array(j) }))
						Dim dataRow As DataRow = mdsDeviationProfile_Edit.Tables(0).NewRow()
						dataRow("EntryNumber") = j + 1
						dataRow("Depth") = array2(j)
						dataRow("Inclination") = array3(j)
						dataRow("Azimuth") = array(j)
						dataRow("Dogleg") = DBNull.Value
						dataRow("TVDepth") = DBNull.Value
						dataRow("NorthSouth") = DBNull.Value
						dataRow("EastWest") = DBNull.Value
						mdsDeviationProfile_Edit.Tables(0).Rows.Add(dataRow)
					Next
					If RSWIN_DESC.mdsDeviationProfile_Edit IsNot Nothing Then
						MImpred.InitSurveyDataset(RSWIN_DESC.mdsDeviationProfile, Nothing)
						MImpred.CopyDatasets(RSWIN_DESC.mdsDeviationProfile_Edit, RSWIN_DESC.mdsDeviationProfile, RSWIN_DESC.SETUP_MeasurementSystem <> 1, True)
						Dim ulgDeviationProfile As UltraGrid = Me.ulgDeviationProfile
						ulgDeviationProfile.DataSource = RSWIN_DESC.mdsDeviationProfile_Edit
						ulgDeviationProfile.Rows.Refresh(RefreshRow.FireInitializeRow, True)
						Dim flag6 As Boolean = Me.CheckDeviationProfile()
						If flag6 Then
							Me.ShowDeviation_Dogleg(CType(Me.ulgDeviationProfile.DataSource, DataSet), False, False)
							Dim dsDeviationProfile As DataSet = CType(Me.ulgDeviationProfile.DataSource, DataSet)
							Dim bPlotData As Boolean = False
							Dim obj As Object
							Dim num6 As Short = Conversions.ToShort(obj)
							Me.ShowDeviation_TVD(dsDeviationProfile, bPlotData, num6)
							obj = num6
							Me.ulgDeviationProfile.ActiveRow = Me.ulgDeviationProfile.GetRow(ChildRow.First)
						End If
					End If
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub ulgDeviationProfile_Click(sender As Object, e As EventArgs)
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
		End Sub

		Private Sub ulgDeviationProfile_MouseUp(sender As Object, e As MouseEventArgs)
		End Sub

		Private Sub ulgDeviationProfile_CellChange(sender As Object, e As CellEventArgs)
			' The following expression was wrapped in a checked-statement
			Try
				Try
					Me.ResetClock()
				Catch ex As Exception
				End Try
				If Strings.InStr(e.Cell.Text, vbTab, CompareMethod.Binary) > 0 Or Strings.InStr(e.Cell.Text, vbVerticalTab, CompareMethod.Binary) > 0 Or Strings.InStr(e.Cell.Text, vbCr, CompareMethod.Binary) > 0 Then
					e.Cell.CancelUpdate()
					Dim num As Integer = 1
					Do
						Application.DoEvents()
						num += 1
					Loop While num <= 100
					MessageBox.Show("Please use Edit/Paste to paste Deviation Survey items from Clipboard.", "Paste Error", MessageBoxButtons.OK)
				End If
			Catch ex2 As Exception
			End Try
		End Sub

		Private Sub PasteToGrid()
			Try
				Dim dataObject As DataObject = CType(Clipboard.GetDataObject(), DataObject)
				Dim text As String = Conversions.ToString(dataObject.GetData(DataFormats.Text))
				If Strings.InStr(text, vbTab, CompareMethod.Binary) > 0 Then
					Me.ImportToGridPasteString(text)
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub PlotDoglegSeverity()
			' The following expression was wrapped in a checked-statement
			Dim array As Single()
			Dim array2 As Single()
			Dim num As Integer
			Try
				Dim count As Integer = RSWIN_DESC.mdsDeviationProfile.Tables(0).Rows.Count
				array = New Single(count + 1 - 1) {}
				array2 = New Single(count + 1 - 1) {}
				Dim ultraGridRow As UltraGridRow = Me.ulgDeviationProfile.GetRow(ChildRow.First)
				Dim flag As Boolean = True
				num = -1
				While flag
					Dim ultraGridRow2 As UltraGridRow = ultraGridRow
					If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(ultraGridRow2.Cells("Depth").Value)) And Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(ultraGridRow2.Cells("Dogleg").Value)) Then
						num += 1
						array(num) = Conversions.ToSingle(ultraGridRow2.Cells("Depth").Value)
						array2(num) = Conversions.ToSingle(ultraGridRow2.Cells("Dogleg").Value)
					End If
					If ultraGridRow.HasNextSibling() Then
						ultraGridRow = ultraGridRow.GetSibling(SiblingRow.[Next])
					Else
						flag = False
					End If
				End While
			Catch ex As Exception
			End Try
			Dim num2 As Single = -10000F
			Dim num3 As Integer = num
			Dim chartFX_DoglegSeverity As ChartFX.WinForms.Chart = Me.ChartFX_DoglegSeverity
			chartFX_DoglegSeverity.Data.Series = 1
			chartFX_DoglegSeverity.Data.Points = num3
			Dim array3 As Single() = New Single(num3 - 1 + 1 - 1) {}
			Dim num4 As Single = 0F
			Dim num5 As Long = 0L
			Dim num6 As Long = CLng((num - 1))
			For num7 As Long = num5 To num6
				Dim num8 As Single = array(CInt(num7))
				Dim num9 As Single = num8 - num4
				array3(CInt(num7)) = num9
				num4 = num8
			Next
			Dim num10 As Long = 0L
			Dim num11 As Long = CLng((num - 1))
			For num7 As Long = num10 To num11
				' The following expression was wrapped in a unchecked-expression
				' The following expression was wrapped in a checked-expression
				Dim num12 As Single = -array(CInt(num7))
				chartFX_DoglegSeverity.Data.Y(0, CInt(num7)) = CDbl(num12)
				Dim num13 As Single = array2(CInt(num7))
				If num13 > num2 Then
					num2 = num13
				End If
				If array3(CInt(num7)) <> 0F Then
					chartFX_DoglegSeverity.Data.X(0, CInt(num7)) = CDbl(array2(CInt(num7)))
				Else
					chartFX_DoglegSeverity.Data.X(0, CInt(num7)) = 0.0
				End If
				Dim num8 As Single = array(CInt(num7))
				If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
					' The following expression was wrapped in a unchecked-expression
					num8 = num8 * 1F / RSWIN_DESC.FT__M
				End If
				chartFX_DoglegSeverity.Points(0, CInt(num7)).Color = Me.GetLineColor(num8)
			Next
			chartFX_DoglegSeverity.AllSeries.Border.Visible = False
			Dim axisX As AxisX = chartFX_DoglegSeverity.AxisX
			Dim title As ChartFX.WinForms.Title = axisX.Title
			title.Alignment = StringAlignment.Center
			title.Font = New Font("Arial", 7F, FontStyle.Bold)
			title.Text = Conversions.ToString(Me.DoglegColumnHeader())
			title.TextColor = Color.Black
			axisX.ForceZero = True
			axisX.Font = New Font("Arial", 7F, FontStyle.Bold)
			axisX.Max = CDbl((CInt(Math.Round(CDbl(num2))) * 2))
			axisX.Title.Alignment = StringAlignment.Center
			axisX.Title.Font = New Font("Arial", 10F, FontStyle.Bold)
			Dim axisY As AxisY = chartFX_DoglegSeverity.AxisY
			Dim title2 As ChartFX.WinForms.Title = axisY.Title
			title2.Font = New Font("Arial", 7F, FontStyle.Bold)
			If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
				title2.Text = "Measured depth (m)"
			Else
				title2.Text = "Measured depth (ft)"
			End If
			title2.TextColor = Color.Black
			axisY.Title.Alignment = StringAlignment.Center
			axisY.Title.Font = New Font("Arial", 10F, FontStyle.Bold)
			chartFX_DoglegSeverity.Titles(0).Font = New Font("Arial", 10F, FontStyle.Bold)
			chartFX_DoglegSeverity.AllSeries.Line.Width = 2S
			chartFX_DoglegSeverity.Refresh()
		End Sub

		Public Sub CalcTaperDepths()
			' The following expression was wrapped in a checked-statement
			Me.TaperDepths = New Single(CInt((RSWIN_DESC.rst.NumRods + 1S)) - 1) {}
			Me.TaperDepths(1) = RSWIN_DESC.rst.Sections(1).length
			Dim num As Integer = 2
			Dim numRods As Integer = CInt(RSWIN_DESC.rst.NumRods)
			For i As Integer = num To numRods
				' The following expression was wrapped in a unchecked-expression
				' The following expression was wrapped in a checked-expression
				Me.TaperDepths(i) = Me.TaperDepths(i - 1) + RSWIN_DESC.rst.Sections(i).length
			Next
		End Sub

		Public Function GetLineColor(fDepth As Single) As Color
			Dim result As Color
			Try
				fDepth = Math.Abs(fDepth)
				Dim flag As Boolean = True
				If flag = fDepth <= RSWIN_DESC.rst.Sections(1).length Then
					result = Color.Red
				ElseIf flag = (RSWIN_DESC.rst.NumRods >= 1S And fDepth <= Me.TaperDepths(2)) Then
					result = Color.Green
				ElseIf flag = (RSWIN_DESC.rst.NumRods >= 2S And fDepth <= Me.TaperDepths(3)) Then
					result = Color.Blue
				ElseIf flag = (RSWIN_DESC.rst.NumRods >= 3S And fDepth <= Me.TaperDepths(4)) Then
					result = Color.Magenta
				ElseIf flag = (RSWIN_DESC.rst.NumRods >= 4S And fDepth <= Me.TaperDepths(5)) Then
					result = Color.MediumTurquoise
				ElseIf flag = (RSWIN_DESC.rst.NumRods >= 5S And fDepth <= Me.TaperDepths(6)) Then
					result = Color.Orange
				ElseIf flag = (RSWIN_DESC.rst.NumRods >= 6S And fDepth <= Me.TaperDepths(7)) Then
					result = Color.Purple
				ElseIf flag = (RSWIN_DESC.rst.NumRods >= 7S And fDepth <= Me.TaperDepths(8)) Then
					result = Color.Tan
				ElseIf flag = (RSWIN_DESC.rst.NumRods >= 8S And fDepth <= Me.TaperDepths(9)) Then
					result = Color.DarkRed
				ElseIf flag = (RSWIN_DESC.rst.NumRods >= 9S And fDepth <= Me.TaperDepths(10)) Then
					result = Color.Gray
				ElseIf flag = (RSWIN_DESC.rst.NumRods >= 10S And fDepth <= Me.TaperDepths(11)) Then
					result = Color.Red
				ElseIf flag = (RSWIN_DESC.rst.NumRods >= 11S And fDepth <= Me.TaperDepths(12)) Then
					result = Color.Green
				ElseIf flag = (RSWIN_DESC.rst.NumRods >= 12S And fDepth <= Me.TaperDepths(13)) Then
					result = Color.Blue
				ElseIf flag = (RSWIN_DESC.rst.NumRods >= 13S And fDepth <= Me.TaperDepths(14)) Then
					result = Color.Magenta
				ElseIf flag = (RSWIN_DESC.rst.NumRods >= 14S And fDepth <= Me.TaperDepths(15)) Then
					result = Color.MediumTurquoise
				ElseIf flag = (RSWIN_DESC.rst.NumRods >= 15S And fDepth <= Me.TaperDepths(16)) Then
					result = Color.Orange
				ElseIf flag = (RSWIN_DESC.rst.NumRods >= 16S And fDepth <= Me.TaperDepths(17)) Then
					result = Color.Purple
				ElseIf flag = (RSWIN_DESC.rst.NumRods >= 17S And fDepth <= Me.TaperDepths(18)) Then
					result = Color.Cyan
				ElseIf flag = (RSWIN_DESC.rst.NumRods >= 18S And fDepth <= Me.TaperDepths(19)) Then
					result = Color.DarkRed
				ElseIf flag = (RSWIN_DESC.rst.NumRods >= 19S And fDepth <= Me.TaperDepths(20)) Then
					result = Color.Gray
				ElseIf flag = (RSWIN_DESC.rst.NumRods >= 20S And fDepth <= Me.TaperDepths(21)) Then
					result = Color.Red
				End If
			Catch ex As Exception
				result = Color.Black
			End Try
			Return result
		End Function

		Private Function DoglegColumnHeader() As Object
			Dim result As String
			If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
				result = "Dogleg Severity °/100ft"
			Else
				result = "Dogleg Severity °/30m"
			End If
			Return result
		End Function

		Private Sub btnExport_Click(sender As Object, e As EventArgs)
			Dim text As String = RSWIN_DESC.rst.WellName.Trim() + "_survey.csv"
			Dim sDescList As String = "MS Excel Comma Delimited (*.CSV)|*.CSV"
			Try
				Me.ResetClock()
				If(Me.ulgDeviationProfile IsNot Nothing And RSWIN_DESC.mdsDeviationProfile_Edit IsNot Nothing) AndAlso Me.ulgDeviationProfile.Rows.Count > 2 Then
					Dim rst As cRODSTAR = RSWIN_DESC.rst
					Dim rstdir As String = rst.RSTDir
					Dim flag As Boolean = FILEIO.SelectOutputFile(text, rstdir, sDescList, text, ".csv", "Save File As")
					rst.RSTDir = rstdir
					Dim flag2 As Boolean = flag
					If flag2 And Operators.CompareString(text, "", False) <> 0 Then
						If FILEUTIL.FileExists(text) Then
							FileSystem.Kill(text)
						End If
						Dim num As Short = CShort(FileSystem.FreeFile())
						FileSystem.FileOpen(CInt(num), text, OpenMode.Output, OpenAccess.[Default], OpenShare.[Default], -1)
						Dim dataView As DataView = New DataView(RSWIN_DESC.mdsDeviationProfile_Edit.Tables(0))
						dataView.Sort = "Depth"
						Dim caption As String = Me.ulgDeviationProfile.DisplayLayout.Bands(0).Columns("Depth").Header.Caption
						Dim caption2 As String = Me.ulgDeviationProfile.DisplayLayout.Bands(0).Columns("Inclination").Header.Caption
						Dim caption3 As String = Me.ulgDeviationProfile.DisplayLayout.Bands(0).Columns("Azimuth").Header.Caption
						FileSystem.PrintLine(CInt(num), New Object() { String.Concat(New String() { caption, ",", caption2, ",", caption3 }) })
						Try
							For Each obj As Object In dataView
								Dim dataRowView As DataRowView = CType(obj, DataRowView)
								Dim row As DataRow = dataRowView.Row
								FileSystem.PrintLine(CInt(num), New Object() { Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(row("Depth"), ","), row("Inclination")), ","), row("Azimuth")) })
							Next
						Finally
							Dim enumerator As IEnumerator
							If TypeOf enumerator Is IDisposable Then
								TryCast(enumerator, IDisposable).Dispose()
							End If
						End Try
						FileSystem.FileClose(New Integer() { CInt(num) })
					End If
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub btnImport_Click(sender As Object, e As EventArgs)
			Dim sDescList As String = "MS Excel Comma Delimited (*.CSV)|*.CSV"
			Dim [string] As String = ""
			Dim text As String = ""
			Dim text2 As String = ""
			Me.ResetClock()
			Me.UnloadAllFormsExceptMe()
			Me.Visible = False
			Application.DoEvents()
			Try
				Me.frmImportDialog = Me.frmImportDialog
				Me.frmImportDialog.ShowDialog()
				Me.ResetClock()
				If Me.frmImportDialog.bContinue And Me.frmImportDialog.bExcel Then
					Me.frmWizard = Me.frmWizard
					Me.frmWizard.ShowDialog()
					Me.bAnswered = False
					Dim flag As Boolean = Me.frmWizard.bSuccess
					If flag Then
						If RSWIN_DESC.mdsDeviationProfile IsNot Nothing Then
							MImpred.InitSurveyDataset(RSWIN_DESC.mdsDeviationProfile_Edit, Nothing)
							MImpred.CopyDatasets(RSWIN_DESC.mdsDeviationProfile, RSWIN_DESC.mdsDeviationProfile_Edit, RSWIN_DESC.SETUP_MeasurementSystem <> 1, False)
							Dim ulgDeviationProfile As UltraGrid = Me.ulgDeviationProfile
							ulgDeviationProfile.DataSource = RSWIN_DESC.mdsDeviationProfile_Edit
							ulgDeviationProfile.Rows.Refresh(RefreshRow.FireInitializeRow, True)
							Dim ulgDeviationProfile2 As UltraGrid = Me.ulgDeviationProfile
							CtrlUI.Grid_SetLabels(ulgDeviationProfile2, True)
							Me.ulgDeviationProfile = ulgDeviationProfile2
							Me.SetDoglegColumnHeader()
							Dim flag2 As Boolean = Me.CheckDeviationProfile()
							If flag2 Then
								Me.ShowDeviation_Dogleg(CType(Me.ulgDeviationProfile.DataSource, DataSet), False, False)
								Dim dsDeviationProfile As DataSet = CType(Me.ulgDeviationProfile.DataSource, DataSet)
								Dim bPlotData As Boolean = False
								Dim obj As Object
								Dim num As Short = Conversions.ToShort(obj)
								Me.ShowDeviation_TVD(dsDeviationProfile, bPlotData, num)
								obj = num
								Me.ulgDeviationProfile.ActiveRow = Me.ulgDeviationProfile.GetRow(ChildRow.First)
							End If
						End If
					End If
				ElseIf Me.frmImportDialog.bContinue And Me.frmImportDialog.bRodstar Then
					Dim text3 As String = ""
					Dim num2 As Integer = 0
					Dim rstdir As String = ""
					FILEIO.SelectInputFile(text3, rstdir, RSWIN_DESC.sImportRSTXFiles, 1, "", "Import File")
					Dim flag3 As Boolean
					If Strings.InStr(text3.ToLower(), ".rsdx", CompareMethod.Binary) > 0 Or Strings.InStr(text3.ToLower(), ".xddx", CompareMethod.Binary) > 0 Then
						flag3 = MRodstarXML.LoadRodstarXML_DeviationOnly(text3, num2)
					Else
						flag3 = LOADRST.LoadDeviationProfile(text3, num2)
					End If
					If flag3 And num2 > 1 Then
						Me.RODSTAR_Message("Importing! Please Wait!")
						LOADRST.DeleteTempDeviationFile()
						FILEIO.CheckSurveyOrder()
						Me.LoadDevSurvey()
						MessageBox.Show(Me.sSurveyLoaded, Me.sImportWizard)
					Else
						Try
							RSWIN_DESC.mdsDeviationProfile = Nothing
							MImpred.InitSurveyDataset(RSWIN_DESC.mdsDeviationProfile, Nothing)
							MImpred.CopyDatasets(RSWIN_DESC.mdsDeviationProfile_Edit, RSWIN_DESC.mdsDeviationProfile, RSWIN_DESC.SETUP_MeasurementSystem <> 1, True)
						Catch ex As Exception
						End Try
						MessageBox.Show(Me.sSurveyNotLoaded, Me.sImportWizard)
					End If
				ElseIf Me.frmImportDialog.bContinue And Me.frmImportDialog.bCSV Then
					Dim flag4 As Boolean = True
					Dim text4 As String = ""
					Dim num2 As Integer = 0
					Dim rst As cRODSTAR = RSWIN_DESC.rst
					Dim rstdir As String = rst.RSTDir
					FILEIO.SelectInputFile(text4, rstdir, sDescList, 1, text4, "Import File")
					rst.RSTDir = rstdir
					If Operators.CompareString(text4, "", False) <> 0 Then
						Dim num3 As Short = CShort(FileSystem.FreeFile())
						FileSystem.FileOpen(CInt(num3), text4, OpenMode.Input, OpenAccess.[Default], OpenShare.[Default], -1)
						Dim dataSet As DataSet = Nothing
						MImpred.InitSurveyDataset(dataSet, Nothing)
						Dim flag As Boolean
						If Not FileSystem.EOF(CInt(num3)) Then
							FileSystem.Input(CInt(num3), [string])
							flag4 = (Strings.InStr([string], "(ft)", CompareMethod.Binary) > 0 Or Strings.InStr([string], "(m)", CompareMethod.Binary) = 0)
							If Not FileSystem.EOF(CInt(num3)) Then
								FileSystem.Input(CInt(num3), text)
								If Not FileSystem.EOF(CInt(num3)) Then
									FileSystem.Input(CInt(num3), text2)
									Dim num4 As Integer = 0
									While Not FileSystem.EOF(CInt(num3))
										Dim value As String
										FileSystem.Input(CInt(num3), value)
										Dim value2 As String
										FileSystem.Input(CInt(num3), value2)
										Dim value3 As String
										FileSystem.Input(CInt(num3), value3)
										Dim dataSet2 As DataSet = dataSet
										Dim dataRow As DataRow = dataSet2.Tables(0).NewRow()
										num4 += 1
										dataRow("EntryNumber") = num4
										dataRow("Depth") = Convert.ToDouble(value)
										dataRow("Inclination") = value2
										dataRow("Azimuth") = value3
										dataRow("Dogleg") = DBNull.Value
										dataRow("TVDepth") = DBNull.Value
										dataRow("NorthSouth") = DBNull.Value
										dataRow("EastWest") = DBNull.Value
										dataSet2.Tables(0).Rows.Add(dataRow)
									End While
									FileSystem.FileClose(New Integer() { CInt(num3) })
									flag = True
								Else
									flag = False
								End If
							Else
								flag = False
							End If
						Else
							flag = False
						End If
						If flag Then
							Dim bConvert As Boolean = (RSWIN_DESC.SETUP_MeasurementSystem <> 1 AndAlso flag4) Or (RSWIN_DESC.SETUP_MeasurementSystem = 1 And Not flag4)
							Me.ulgDeviationProfile.DataSource = Nothing
							RSWIN_DESC.mdsDeviationProfile_Edit = Nothing
							MImpred.InitSurveyDataset(RSWIN_DESC.mdsDeviationProfile_Edit, Nothing)
							RSWIN_DESC.mdsDeviationProfile = Nothing
							MImpred.InitSurveyDataset(RSWIN_DESC.mdsDeviationProfile, Nothing)
							MImpred.CopyDatasets(dataSet, RSWIN_DESC.mdsDeviationProfile_Edit, bConvert, RSWIN_DESC.SETUP_MeasurementSystem = 1)
							If RSWIN_DESC.mdsDeviationProfile_Edit IsNot Nothing Then
								MImpred.InitSurveyDataset(RSWIN_DESC.mdsDeviationProfile, Nothing)
								MImpred.CopyDatasets(RSWIN_DESC.mdsDeviationProfile_Edit, RSWIN_DESC.mdsDeviationProfile, RSWIN_DESC.SETUP_MeasurementSystem <> 1, True)
								Dim ulgDeviationProfile3 As UltraGrid = Me.ulgDeviationProfile
								ulgDeviationProfile3.DataSource = RSWIN_DESC.mdsDeviationProfile_Edit
								ulgDeviationProfile3.Rows.Refresh(RefreshRow.FireInitializeRow, True)
								Dim flag2 As Boolean = Me.CheckDeviationProfile()
								If flag2 Then
									Me.ShowDeviation_Dogleg(CType(Me.ulgDeviationProfile.DataSource, DataSet), False, False)
									Dim dsDeviationProfile2 As DataSet = CType(Me.ulgDeviationProfile.DataSource, DataSet)
									Dim bPlotData2 As Boolean = False
									Dim obj2 As Object
									Dim num As Short = Conversions.ToShort(obj2)
									Me.ShowDeviation_TVD(dsDeviationProfile2, bPlotData2, num)
									obj2 = num
									Me.ulgDeviationProfile.ActiveRow = Me.ulgDeviationProfile.GetRow(ChildRow.First)
								End If
							End If
						End If
					End If
				End If
				Me.Left = 30
				Me.Width = RSWIN_DESC.frmMain.Width - 100
				If Me.Width > 1200 Then
					Me.Width = 1200
				End If
				Me.Height = RSWIN_DESC.frmMain.Height - 150
				Me.Top = 10
				Me.Visible = True
				Me.Refresh()
				Me.SetMeasDepthColumnHeader()
				Application.DoEvents()
			Catch ex2 As Exception
				Me.Visible = True
				Application.DoEvents()
			End Try
		End Sub

		Private Sub SetStatus()
			If Strings.InStr(Me.lblStatus.Text, "     Row #", CompareMethod.Binary) = 0 Then
				If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
					Dim lblStatus As Label = Me.lblStatus
					Dim str As String = " Last Entered Measured Depth (ft): "
					Dim text As String = "#######.##"
					Dim str2 As String = Util.Format(Me.fMaxMD, text)
					Dim str3 As String = " ,  Pump Depth (ft): "
					Dim text2 As String = "#######.##"
					lblStatus.Text = str + str2 + str3 + Util.Format(Me.tmp_PumpDepth, text2)
				Else
					Dim lblStatus2 As Label = Me.lblStatus
					Dim str4 As String = " Last Entered Measured Depth (m): "
					Dim text2 As String = "#######.##"
					Dim str5 As String = Util.Format(Me.fMaxMD, text2)
					Dim str6 As String = " ,  Pump Depth (m): "
					Dim text As String = "#######.##"
					lblStatus2.Text = str4 + str5 + str6 + Util.Format(Me.tmp_PumpDepth, text)
				End If
				If Me.tmp_PumpDepth = 0.0 Then
					Me.txtTempLength.Tag = "fem"
					Me.txtTempLength.Text = Conversions.ToString(RSWIN_DESC.rst.PumpDepth)
					Dim txtTempLength As TextBox = Me.txtTempLength
					Dim lblTemp As Label = Me.lblTemp
					Me.TextBox_Change(txtTempLength, lblTemp)
					Me.lblTemp = lblTemp
					Me.txtTempLength = txtTempLength
					Me.tmp_PumpDepth = CDbl(Convert.ToSingle(Me.txtTempLength.Text))
				End If
				If CDbl(Me.fMaxMD) >= Me.tmp_PumpDepth Or Math.Abs(CDbl(Me.fMaxMD) - Me.tmp_PumpDepth) < 0.1 Then
					Me.lblStatus.ForeColor = Color.Green
				Else
					Me.lblStatus.ForeColor = Color.Red
				End If
				Return
			End If
		End Sub

		Public Sub RODSTAR_Message(sMsg As String)
			Try
				If Me.MyParentFrm Is Nothing Then
					Try
						Me.MyParentFrm = CType(Me.ParentForm, RODSTAR)
					Catch ex As Exception
					End Try
				End If
				Me.MyParentFrm.Message(sMsg)
			Catch ex2 As Exception
			End Try
		End Sub

		Public Sub ResetClock()
			Try
				If RSWIN_DESC.SETUP_ExitIfIdle <> 0S Then
					If Me.MyParentFrm Is Nothing Then
						Try
							Me.MyParentFrm = CType(Me.ParentForm, RODSTAR)
						Catch ex As Exception
						End Try
					End If
					Me.MyParentFrm.bEnd = False
					Me.MyParentFrm.tmrClock.Enabled = False
					Me.MyParentFrm.NowTime = DateAndTime.Now
					Me.MyParentFrm.tmrClock.Enabled = True
				End If
			Catch ex2 As Exception
			End Try
		End Sub

		Public Sub DisableTimeClock()
			Try
				If Me.MyParentFrm Is Nothing Then
					Try
						Me.MyParentFrm = CType(Me.ParentForm, RODSTAR)
					Catch ex As Exception
					End Try
				End If
				Me.MyParentFrm.tmrClock.Enabled = False
			Catch ex2 As Exception
			End Try
		End Sub

		Private Sub DeviationProfile_MouseDoubleClick(sender As Object, e As MouseEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub DeviationProfile_MouseDown(sender As Object, e As MouseEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub DeviationProfile_MouseEnter(sender As Object, e As EventArgs)
			Me.ResetClock()
		End Sub

		Private Sub DeviationProfile_MouseMove(sender As Object, e As MouseEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub DeviationProfile_MouseUp(sender As Object, e As MouseEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub DeviationProfile_MouseWheel(sender As Object, e As MouseEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub DeviationProfile_Move(sender As Object, e As EventArgs)
			Me.ResetClock()
		End Sub

		Private Sub DeviationProfile_Scroll(sender As Object, e As ScrollEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub DeviationProfile_KeyPress(sender As Object, e As KeyPressEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub DeviationProfile_DragDrop(sender As Object, e As DragEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub DeviationProfile_DragEnter(sender As Object, e As DragEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub DeviationProfile_FormClosed(sender As Object, e As FormClosedEventArgs)
			Me.DisableTimeClock()
		End Sub

		Private Sub DeviationProfile_FormClosing(sender As Object, e As FormClosingEventArgs)
			Me.DisableTimeClock()
		End Sub

		Private Sub DeviationProfile_LostFocus(sender As Object, e As EventArgs)
			Me.DisableTimeClock()
		End Sub

		Private Sub DeviationProfile_GotFocus(sender As Object, e As EventArgs)
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

		Private Sub commander1_ButtonClick(sender As Object, e As ToolBarButtonClickEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub lblStatus_TextChanged(sender As Object, e As EventArgs)
		End Sub

		Private Sub EnterMissingPoints(iNumToAdd As Integer, fInc As Single)
			Dim dataView As DataView = New DataView(RSWIN_DESC.mdsDeviationProfile_Edit.Tables(0))
			Dim num As Integer = RSWIN_DESC.mdsDeviationProfile_Edit.Tables(0).Rows.Count + iNumToAdd
			Dim array As String() = New String(num + 1 - 1) {}
			Dim array2 As String() = New String(num + 1 - 1) {}
			Dim array3 As String() = New String(num + 1 - 1) {}
			dataView.Sort = "Depth"
			Dim i As Integer = 0
			Try
				For Each obj As Object In dataView
					Dim dataRowView As DataRowView = CType(obj, DataRowView)
					i += 1
					Dim row As DataRow = dataRowView.Row
					If i = 1 Then
						Dim text As String = Conversions.ToString(row("Depth"))
						Dim text2 As String = Conversions.ToString(row("Inclination"))
						Dim text3 As String = Conversions.ToString(row("Azimuth"))
						array(i) = text
						array2(i) = text2
						array3(i) = text3
					ElseIf i = 2 Then
						For j As Integer = 1 To iNumToAdd
							' The following expression was wrapped in a unchecked-expression
							array(i) = Conversions.ToString(CSng(j) * fInc)
							Dim text2 As String
							array2(i) = text2
							Dim text3 As String
							array3(i) = text3
							i += 1
						Next
						array(i) = Conversions.ToString(row("Depth"))
						array2(i) = Conversions.ToString(row("Inclination"))
						array3(i) = Conversions.ToString(row("Azimuth"))
					Else
						array(i) = Conversions.ToString(row("Depth"))
						array2(i) = Conversions.ToString(row("Inclination"))
						array3(i) = Conversions.ToString(row("Azimuth"))
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			RSWIN_DESC.mdsDeviationProfile_Edit = Nothing
			MImpred.InitSurveyDataset(RSWIN_DESC.mdsDeviationProfile_Edit, Nothing)
			Dim num2 As Integer = 1
			Dim num3 As Integer = num
			i = num2
			While i <= num3
				Dim dataRow As DataRow = RSWIN_DESC.mdsDeviationProfile_Edit.Tables(0).NewRow()
				dataRow("EntryNumber") = i
				dataRow("Depth") = array(i)
				dataRow("Inclination") = array2(i)
				dataRow("Azimuth") = array3(i)
				RSWIN_DESC.mdsDeviationProfile_Edit.Tables(0).Rows.Add(dataRow)
				i += 1
			End While
			Dim ulgDeviationProfile As UltraGrid = Me.ulgDeviationProfile
			ulgDeviationProfile.DataSource = RSWIN_DESC.mdsDeviationProfile_Edit
			ulgDeviationProfile.Rows.Refresh(RefreshRow.FireInitializeRow, True)
			Dim ulgDeviationProfile2 As UltraGrid = Me.ulgDeviationProfile
			CtrlUI.Grid_SetLabels(ulgDeviationProfile2, True)
			Me.ulgDeviationProfile = ulgDeviationProfile2
			Me.SetDoglegColumnHeader()
			Dim flag As Boolean = Me.CheckDeviationProfile()
			If flag Then
				Me.ShowDeviation_Dogleg(CType(Me.ulgDeviationProfile.DataSource, DataSet), False, False)
				Dim dsDeviationProfile As DataSet = CType(Me.ulgDeviationProfile.DataSource, DataSet)
				Dim bPlotData As Boolean = False
				Dim obj2 As Object
				Dim num4 As Short = Conversions.ToShort(obj2)
				Me.ShowDeviation_TVD(dsDeviationProfile, bPlotData, num4)
				obj2 = num4
				Me.ulgDeviationProfile.ActiveRow = Me.ulgDeviationProfile.GetRow(ChildRow.First)
				Return
			End If
		End Sub

		Private Sub btnPaste_Click(sender As Object, e As EventArgs)
			Me.PasteToGrid()
		End Sub

		Private Sub pnlLegend_Paint(sender As Object, e As PaintEventArgs)
		End Sub

		Public Sub ValidateDeviationProfile()
			Try
				Dim bEnabled As Boolean = Me.CheckDeviationProfile()
				RSWIN_DESC.frmMain.ToolbarButtonSetState(16, bEnabled)
			Catch ex As Exception
			End Try
		End Sub

		Private bShowDoglegPlotTab As Boolean

		<AccessedThroughProperty("cmdAddSection")>
		Private _cmdAddSection As Button

		<AccessedThroughProperty("cmdMoveSectionUp")>
		Private _cmdMoveSectionUp As Button

		<AccessedThroughProperty("cmdMoveSectionDown")>
		Private _cmdMoveSectionDown As Button

		<AccessedThroughProperty("cmdNumberOfEntries")>
		Private _cmdNumberOfEntries As Button

		<AccessedThroughProperty("cmdPrint")>
		Private _cmdPrint As Button

		<AccessedThroughProperty("_tabInput_TabPage0")>
		Private __tabInput_TabPage0 As TabPage

		<AccessedThroughProperty("_tabInput_TabPage2")>
		Private __tabInput_TabPage2 As TabPage

		<AccessedThroughProperty("tabInput")>
		Private _tabInput As TabControl

		<AccessedThroughProperty("picRemoveFocus")>
		Private _picRemoveFocus As System.Windows.Forms.Panel

		<AccessedThroughProperty("Label")>
		Private _Label As LabelArray

		<AccessedThroughProperty("fraPumpDrag")>
		Private _fraPumpDrag As GroupBoxArray

		<AccessedThroughProperty("optPolishedRodDrag")>
		Private _optPolishedRodDrag As RadioButtonArray

		<AccessedThroughProperty("optPumpDragDown")>
		Private _optPumpDragDown As RadioButtonArray

		<AccessedThroughProperty("optPumpDragUp")>
		Private _optPumpDragUp As RadioButtonArray

		<AccessedThroughProperty("m_frmDevSettings")>
		Private _m_frmDevSettings As frmDevSettings

		<AccessedThroughProperty("ImageList3")>
		Private _ImageList3 As ImageList

		<AccessedThroughProperty("ulgDeviationProfile")>
		Private _ulgDeviationProfile As UltraGrid

		<AccessedThroughProperty("tabDirection")>
		Private _tabDirection As TabControl

		<AccessedThroughProperty("NE")>
		Private _NE As TabPage

		<AccessedThroughProperty("NW")>
		Private _NW As TabPage

		<AccessedThroughProperty("SE")>
		Private _SE As TabPage

		<AccessedThroughProperty("SW")>
		Private _SW As TabPage

		Private CurrentColumn As String

		<AccessedThroughProperty("txtInclination")>
		Private _txtInclination As TextBox

		<AccessedThroughProperty("txtAzimuth")>
		Private _txtAzimuth As TextBox

		<AccessedThroughProperty("Panel1")>
		Private _Panel1 As System.Windows.Forms.Panel

		<AccessedThroughProperty("Panel2")>
		Private _Panel2 As System.Windows.Forms.Panel

		<AccessedThroughProperty("TChart1")>
		Private _TChart1 As TChart

		<AccessedThroughProperty("grpDevPlot")>
		Private _grpDevPlot As GroupBox

		<AccessedThroughProperty("HelpProvider1")>
		Private _HelpProvider1 As HelpProvider

		<AccessedThroughProperty("btnReadTest")>
		Private _btnReadTest As Button

		<AccessedThroughProperty("point3DSeries1")>
		Private _point3DSeries1 As Points3D

		<AccessedThroughProperty("MarksTip1")>
		Private _MarksTip1 As MarksTip

		<AccessedThroughProperty("btnResetPlot")>
		Private _btnResetPlot As Button

		<AccessedThroughProperty("lblNoData")>
		Private _lblNoData As Label

		<AccessedThroughProperty("lblTemp")>
		Private _lblTemp As Label

		<AccessedThroughProperty("txtTempLength")>
		Private _txtTempLength As TextBox

		<AccessedThroughProperty("cmdDelSection")>
		Private _cmdDelSection As Button

		<AccessedThroughProperty("cmdDeleteALLSections")>
		Private _cmdDeleteALLSections As Button

		<AccessedThroughProperty("btnImport")>
		Private _btnImport As Button

		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		<AccessedThroughProperty("btnExport")>
		Private _btnExport As Button

		<AccessedThroughProperty("Panel_Dogleg")>
		Private _Panel_Dogleg As System.Windows.Forms.Panel

		<AccessedThroughProperty("lblNoDataAvailable")>
		Private _lblNoDataAvailable As Label

		<AccessedThroughProperty("ChartFX_DoglegSeverity")>
		Private _ChartFX_DoglegSeverity As ChartFX.WinForms.Chart

		<AccessedThroughProperty("commander1")>
		Private _commander1 As Commander

		<AccessedThroughProperty("pnlLegend")>
		Private _pnlLegend As System.Windows.Forms.Panel

		<AccessedThroughProperty("lblDiameters")>
		Private _lblDiameters As Label

		<AccessedThroughProperty("T20")>
		Private _T20 As Label

		<AccessedThroughProperty("T19")>
		Private _T19 As Label

		<AccessedThroughProperty("T18")>
		Private _T18 As Label

		<AccessedThroughProperty("T17")>
		Private _T17 As Label

		<AccessedThroughProperty("T16")>
		Private _T16 As Label

		<AccessedThroughProperty("T15")>
		Private _T15 As Label

		<AccessedThroughProperty("T14")>
		Private _T14 As Label

		<AccessedThroughProperty("T13")>
		Private _T13 As Label

		<AccessedThroughProperty("T12")>
		Private _T12 As Label

		<AccessedThroughProperty("T11")>
		Private _T11 As Label

		<AccessedThroughProperty("T10")>
		Private _T10 As Label

		<AccessedThroughProperty("T9")>
		Private _T9 As Label

		<AccessedThroughProperty("T8")>
		Private _T8 As Label

		<AccessedThroughProperty("T7")>
		Private _T7 As Label

		<AccessedThroughProperty("T6")>
		Private _T6 As Label

		<AccessedThroughProperty("T5")>
		Private _T5 As Label

		<AccessedThroughProperty("T4")>
		Private _T4 As Label

		<AccessedThroughProperty("T3")>
		Private _T3 As Label

		<AccessedThroughProperty("T2")>
		Private _T2 As Label

		<AccessedThroughProperty("T1")>
		Private _T1 As Label

		<AccessedThroughProperty("btnPaste")>
		Private _btnPaste As Button

		<AccessedThroughProperty("lblDiameters2")>
		Private _lblDiameters2 As Label

		<AccessedThroughProperty("lblStatus")>
		Private _lblStatus As Label

		Private Shared m_vb6FormDefInstance As DeviationProfile

		Private Shared m_InitializingDefInstance As Boolean

		Private MyParentFrm As RODSTAR

		Private bAddQuestionAsked As Boolean

		Private m_bClosing As Boolean

		Private Const epsilon As Double = 1E-06

		Private Const c_ENTRYNUMBER As String = "EntryNumber"

		Private Const c_AZIMUTH As String = "Azimuth"

		Private Const c_CONSTANT As String = "constant"

		Private Const c_DEPTH As String = "Depth"

		Private Const c_INCLINATION As String = "Inclination"

		Private Const c_NORTHSOUTH As String = "NorthSouth"

		Private Const c_EASTWEST As String = "EastWest"

		Private Const c_DELTA_INCLINATION As String = "DeltaInclination"

		Private Const c_DELTA_AZIMUTH As String = "DeltaAzimuth"

		Private sARSRemoveThis As String

		Private sARSRemove As String

		Private sDeleteRow As String

		Private sDeleteRows As String

		Private sDYWFill As String

		Private sMsg1 As String

		Private sMsg2 As String

		Private sMsg3 As String

		Private sRemoveALL As String

		Private sARS As String

		Private sSurveyLoaded As String

		Private sSurveyNotLoaded As String

		Private sImportWizard As String

		Private iShowDev As Integer

		Private tmp_PumpDepth As Double

		Private bDataError As Boolean

		Private bShiftDown As Boolean

		Private bCtrlDown As Boolean

		Private bDisplayDeleteMessage As Boolean

		Private m_TVDepth As Double()

		Private m_MeasDepth As Double()

		Private m_bReplot As Boolean

		Private rptDeviationProfile As rptDeviationProfile

		<AccessedThroughProperty("frmWizard")>
		Private _frmWizard As frmWizard

		<AccessedThroughProperty("frmImportDialog")>
		Private _frmImportDialog As frmImportDialog

		Private fMaxMD As Single

		Private fMult As Single

		Private m_bVisible_tabInput As Boolean

		Private m_bAfterPump As Boolean

		Private Const max_fluid_elem As Short = 4000S

		Private r_e As DeviationProfile.rod_element_data_type()

		Private Const csKEY_ENTRYNUMBER As String = "EntryNumber"

		Private Const csKEY_AZIMUTH As String = "Azimuth"

		Private Const csKEY_DEPTH As String = "Depth"

		Private Const csKEY_DOGLEG As String = "Dogleg"

		Private Const csKEY_INCLINATION As String = "Inclination"

		Private Const csKEY_TVDEPTH As String = "TVDepth"

		Private Const csKEY_NORTHSOUTH As String = "NorthSouth"

		Private Const csKEY_EASTWEST As String = "EastWest"

		Private Const csKEY_DELTA_INCLINATION As String = "DeltaInclination"

		Private Const csKEY_DELTA_AZIMUTH As String = "DeltaAzimuth"

		Private Const PM_POSITIONCTRL As Short = 1S

		Private Const PM_MOVEPREVCELL As Short = 2S

		Private Const PM_MOVENEXTCELL As Short = 3S

		Private Const PM_EXITEDITMODE As Short = 4S

		Private Const PM_PROCESSKEY As Short = 5S

		Private Const PM_SELECTFIRSTROW As Short = 6S

		Private mfMouseDownX As Single

		Private mfMouseDownY As Single

		Private sDirection As String

		Private bNew As Boolean

		Private mbFirstResize As Boolean

		Private mcSurveyPoints As Integer

		Private remember As Short

		Private iAngle As Short

		Private bEditAzimuth As Boolean

		Private miNewEntryNum As Short

		Private NumEntries As Short

		Private sCurrentCol As String

		Private bLoadingFrm As Boolean

		Private bDoingResort As Boolean

		Private bAnswered As Boolean

		Private m_bTapers As Boolean()

		Private myKeyValueHT As Hashtable

		Private TaperDepths As Single()

		Private m_AzimuthKeyDnKeyCode As Object

		Private m_InclinationKeyDnKeyCode As Object

		Private $STATIC$DeviationProfile_Resize$20211C1241$busy As Boolean

		Private $STATIC$tabInput_SelectedIndexChanged$20211C1241$PreviousTab As Short

		Private $STATIC$tabInput_SelectedIndexChanged$20211C1241$PreviousTab$Init As StaticLocalInitFlag

		Private Structure cart_coord_type
			Public X As Double

			Public Y As Double

			Public z As Double
		End Structure

		Public Structure parameter_structure_type
			Public num_survey_points As Integer

			Public iostat As Integer

			Public epsilon As Double
		End Structure

		Private Structure survey_point_type
			Public m_d As Double

			Public inc As Double

			Public azi As Double

			Public dog As Double

			Public rad As Double

			Public pos As DeviationProfile.cart_coord_type

			Public tan As DeviationProfile.cart_coord_type

			Public nor As DeviationProfile.cart_coord_type
		End Structure

		Private Structure rod_element_data_type
			Public m_d As Double

			Public dog As Double

			Public rad As Double

			Public ea As Double

			Public friction_coef As Double

			Public mass As Double

			Public buoy_weight As Double

			Public old_force As Double

			Public old_velocity As Double

			Public friction_force As Double

			Public gravity_force As Double

			Public pos As DeviationProfile.cart_coord_type

			Public tan As DeviationProfile.cart_coord_type

			Public nor As DeviationProfile.cart_coord_type

			Public sfg As DeviationProfile.cart_coord_type

			Public max_sf_total As Double

			Public inc As Double

			Public azi As Double

			Public max_force As Double

			Public min_force As Double

			Public damp_coef_dn As Double

			Public damp_coef_up As Double

			Public hydrostat_psia_tbg As Double

			Public hydrostat_psia_csg As Double

			Public dynamic_psia_tbg As Double

			Public dynamic_psia_csg As Double

			Public buckle_tendency As Double

			Public rod_area As Double
		End Structure
	End Class
End Namespace
