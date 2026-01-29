Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Globalization
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.Compatibility.VB6
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	Friend Partial Class dlgAIPreference
		Inherits Form

		Public Sub New()
			AddHandler MyBase.Resize, AddressOf Me.dlgAIPreference_Resize
			AddHandler MyBase.Activated, AddressOf Me.dlgAIPreference_Activated
			AddHandler MyBase.Load, AddressOf Me.dlgAIPreference_Load
			Dim point As Point = New Point(0, 0)
			Me.StartPoint = point
			Me.m_bUseFile = False
			Me.m_bUseSetup = False
			Me.m_bOverwriteSetup = False
			If dlgAIPreference.m_vb6FormDefInstance Is Nothing Then
				If dlgAIPreference.m_InitializingDefInstance Then
					dlgAIPreference.m_vb6FormDefInstance = Me
				Else
					Try
						If Assembly.GetExecutingAssembly().EntryPoint.DeclaringType Is Me.[GetType]() Then
							dlgAIPreference.m_vb6FormDefInstance = Me
						End If
					Catch ex As Exception
					End Try
				End If
			End If
			Me.InitializeComponent()
		End Sub

		Public Overridable Property _Label_0 As Label
			Get
				Return Me.__Label_0
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_0 = value
			End Set
		End Property

		Public Overridable Property _SSPanel_0 As Panel
			Get
				Return Me.__SSPanel_0
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me.__SSPanel_0 = value
			End Set
		End Property

		Public Overridable Property Image As PictureBox
			Get
				Return Me._Image
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._Image = value
			End Set
		End Property

		Public Overridable Property Label As LabelArray
			Get
				Return Me._Label
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As LabelArray)
				Me._Label = value
			End Set
		End Property

		Public Overridable Property SSPanel As PanelArray
			Get
				Return Me._SSPanel
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PanelArray)
				Me._SSPanel = value
			End Set
		End Property

		Public Overridable Property ulgPreferences As UltraGrid
			Get
				Return Me._ulgPreferences
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As UltraGrid)
				Dim value2 As InitializeLayoutEventHandler = AddressOf Me.ulgPreferences_InitializeLayout
				If Me._ulgPreferences IsNot Nothing Then
					RemoveHandler Me._ulgPreferences.InitializeLayout, value2
				End If
				Me._ulgPreferences = value
				If Me._ulgPreferences IsNot Nothing Then
					AddHandler Me._ulgPreferences.InitializeLayout, value2
				End If
			End Set
		End Property

		Friend Overridable Property Panel1 As Panel
			Get
				Return Me._Panel1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._Panel1 = value
			End Set
		End Property

		Public Overridable Property cmdOK As Button
			Get
				Return Me._cmdOK
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.cmdOK_Click
				If Me._cmdOK IsNot Nothing Then
					RemoveHandler Me._cmdOK.Click, value2
				End If
				Me._cmdOK = value
				If Me._cmdOK IsNot Nothing Then
					AddHandler Me._cmdOK.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property chkUseFile As CheckBox
			Get
				Return Me._chkUseFile
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.chkUseFile_CheckedChanged
				If Me._chkUseFile IsNot Nothing Then
					RemoveHandler Me._chkUseFile.CheckedChanged, value2
				End If
				Me._chkUseFile = value
				If Me._chkUseFile IsNot Nothing Then
					AddHandler Me._chkUseFile.CheckedChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property chkUseSetup As CheckBox
			Get
				Return Me._chkUseSetup
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.chkUseSetup_CheckedChanged
				If Me._chkUseSetup IsNot Nothing Then
					RemoveHandler Me._chkUseSetup.CheckedChanged, value2
				End If
				Me._chkUseSetup = value
				If Me._chkUseSetup IsNot Nothing Then
					AddHandler Me._chkUseSetup.CheckedChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property chkOverwriteSetupPreferences As CheckBox
			Get
				Return Me._chkOverwriteSetupPreferences
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.chkOverwriteSetupPreferences_CheckedChanged
				If Me._chkOverwriteSetupPreferences IsNot Nothing Then
					RemoveHandler Me._chkOverwriteSetupPreferences.CheckedChanged, value2
				End If
				Me._chkOverwriteSetupPreferences = value
				If Me._chkOverwriteSetupPreferences IsNot Nothing Then
					AddHandler Me._chkOverwriteSetupPreferences.CheckedChanged, value2
				End If
			End Set
		End Property

		Public Shared Property DefInstance As dlgAIPreference
			Get
				If dlgAIPreference.m_vb6FormDefInstance Is Nothing OrElse dlgAIPreference.m_vb6FormDefInstance.IsDisposed Then
					dlgAIPreference.m_InitializingDefInstance = True
					dlgAIPreference.m_vb6FormDefInstance = New dlgAIPreference()
					dlgAIPreference.m_InitializingDefInstance = False
				End If
				Return dlgAIPreference.m_vb6FormDefInstance
			End Get
			Set(value As dlgAIPreference)
				dlgAIPreference.m_vb6FormDefInstance = value
			End Set
		End Property

		Public Property bUseFile As Boolean
			Get
				Return Me.m_bUseFile
			End Get
			Set(value As Boolean)
				Me.m_bUseFile = value
			End Set
		End Property

		Public Property bUseSetup As Boolean
			Get
				Return Me.m_bUseSetup
			End Get
			Set(value As Boolean)
				Me.m_bUseSetup = value
			End Set
		End Property

		Public Property bOverwriteSetup As Boolean
			Get
				Return Me.m_bOverwriteSetup
			End Get
			Set(value As Boolean)
				Me.m_bOverwriteSetup = value
			End Set
		End Property

		Private Sub dlgAIPreference_Load(eventSender As Object, eventArgs As EventArgs)
			RSWIN.GetMeasurementUnit()
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
			Me.AssignPreferenceData()
			If RSWIN_DESC.bWriteResXFile Then
				Util.OpenResourceWriter(Me.Name)
				Util.WriteControlStrings(Me, Me.ToolTip1)
				Util.CloseResourceWriter()
				Return
			End If
		End Sub

		Private Sub AssignPreferenceData()
			Dim truePart As String = "  (" + Conversions.ToString(Strings.Chr(215)) + ")"
			Try
				Me.ulgPreferences.DataSource = Nothing
				Me.InitPreferencesDataset(Me.mdsPreferences)
				Dim dataRow As DataRow = Me.mdsPreferences.Tables(0).NewRow()
				dataRow("Preferences") = "Rod Preferences "
				dataRow("FromFile") = " "
				dataRow("FromSetup") = " "
				Me.mdsPreferences.Tables(0).Rows.Add(dataRow)
				dataRow = Me.mdsPreferences.Tables(0).NewRow()
				dataRow("Preferences") = "Rod type stronger than API grade D:"
				dataRow("FromFile") = RODUTIL.RodGrade(RSWIN_DESC.AIFilePreferences.HSGradeRod)
				dataRow("FromSetup") = RODUTIL.RodGrade(RSWIN_DESC.HSGradeRod)
				Me.mdsPreferences.Tables(0).Rows.Add(dataRow)
				dataRow = Me.mdsPreferences.Tables(0).NewRow()
				dataRow("Preferences") = "Fiberglass Rod: "
				dataRow("FromFile") = RODUTIL.RodGrade(RSWIN_DESC.AIFilePreferences.FGGradeRod)
				dataRow("FromSetup") = RODUTIL.RodGrade(RSWIN_DESC.FGGradeRod)
				Me.mdsPreferences.Tables(0).Rows.Add(dataRow)
				dataRow = Me.mdsPreferences.Tables(0).NewRow()
				dataRow("Preferences") = "Sinker Bar: "
				dataRow("FromFile") = RODUTIL.RodGrade(RSWIN_DESC.AIFilePreferences.SBGradeRod)
				dataRow("FromSetup") = RODUTIL.RodGrade(RSWIN_DESC.SBGradeRod)
				Me.mdsPreferences.Tables(0).Rows.Add(dataRow)
				dataRow = Me.mdsPreferences.Tables(0).NewRow()
				dataRow("Preferences") = "Use XROD-V Tubing size recommendations: "
				dataRow("FromFile") = Me.CheckBoolean(RSWIN_DESC.AIFilePreferences.bUseXRODVTubingSizes)
				dataRow("FromSetup") = Me.CheckBoolean(RSWIN_DESC.SETUP_UseXRODVTubingSizes)
				Me.mdsPreferences.Tables(0).Rows.Add(dataRow)
				dataRow = Me.mdsPreferences.Tables(0).NewRow()
				If RSWIN_DESC.MaxCasingSize <> 0F And RSWIN_DESC.AIFilePreferences.fCasingSize <> 0F Then
					dataRow("Preferences") = "Casing Size: "
					dataRow("FromFile") = RSWIN_DESC.AIFilePreferences.fCasingSize
					dataRow("FromSetup") = RSWIN_DESC.MaxCasingSize
					Me.mdsPreferences.Tables(0).Rows.Add(dataRow)
					dataRow = Me.mdsPreferences.Tables(0).NewRow()
				End If
				If RSWIN_DESC.MaxTubingSizeOD <> 0F And RSWIN_DESC.AIFilePreferences.fTubingSizeOD <> 0F Then
					dataRow("Preferences") = "Tubing Size OD: "
					dataRow("FromFile") = RSWIN_DESC.AIFilePreferences.fTubingSizeOD
					dataRow("FromSetup") = RSWIN_DESC.MaxTubingSizeOD
					Me.mdsPreferences.Tables(0).Rows.Add(dataRow)
					dataRow = Me.mdsPreferences.Tables(0).NewRow()
				End If
				If Not RSWIN_DESC.AIFilePreferences.bUseXRODVTubingSizes Or Not RSWIN_DESC.SETUP_UseXRODVTubingSizes Then
					dataRow("Preferences") = "Fix Tubing size: "
					dataRow("FromFile") = Me.CheckBoolean(RSWIN_DESC.AIFilePreferences.bFixTubingSize)
					dataRow("FromSetup") = Me.CheckBoolean(RSWIN_DESC.SETUP_FixTubingSize)
					Me.mdsPreferences.Tables(0).Rows.Add(dataRow)
					dataRow = Me.mdsPreferences.Tables(0).NewRow()
				End If
				dataRow("Preferences") = "Use Steel rods: "
				dataRow("FromFile") = Me.CheckBoolean(RSWIN_DESC.AIFilePreferences.bUseSteelRodsOnly)
				dataRow("FromSetup") = Me.CheckBoolean(RSWIN_DESC.SETUP_bUseSteelRodsOnly)
				Me.mdsPreferences.Tables(0).Rows.Add(dataRow)
				dataRow = Me.mdsPreferences.Tables(0).NewRow()
				dataRow("Preferences") = "Use Fiberglass with Steel rods on bottom: "
				dataRow("FromFile") = Me.CheckBoolean(RSWIN_DESC.AIFilePreferences.bUseFGlassWithSteelOnBottom)
				dataRow("FromSetup") = Me.CheckBoolean(RSWIN_DESC.SETUP_bUseFGlassWithSteelOnBottom)
				Me.mdsPreferences.Tables(0).Rows.Add(dataRow)
				dataRow = Me.mdsPreferences.Tables(0).NewRow()
				dataRow("Preferences") = "Steel rod service rod: "
				dataRow("FromFile") = RSWIN_DESC.AIFilePreferences.ServiceFactorPreference
				dataRow("FromSetup") = RSWIN_DESC.SETUP_ServiceFactorPreference
				Me.mdsPreferences.Tables(0).Rows.Add(dataRow)
				dataRow = Me.mdsPreferences.Tables(0).NewRow()
				dataRow("Preferences") = "Electricity Cost: "
				dataRow("FromFile") = RSWIN_DESC.AIFilePreferences.ElectricityCostPreference
				dataRow("FromSetup") = RSWIN_DESC.SETUP_ElectricityCostPreference
				Me.mdsPreferences.Tables(0).Rows.Add(dataRow)
				dataRow = Me.mdsPreferences.Tables(0).NewRow()
				dataRow("Preferences") = "Use Customized Pumping Unit Lists: "
				dataRow("FromFile") = Me.CheckBoolean(RSWIN_DESC.AIFilePreferences.bXRODUseCustomizedLists)
				dataRow("FromSetup") = Me.CheckBoolean(RSWIN_DESC.bXRODUseCustomizedLists)
				Me.mdsPreferences.Tables(0).Rows.Add(dataRow)
				dataRow = Me.mdsPreferences.Tables(0).NewRow()
				If RSWIN_DESC.AIFilePreferences.bXRODUseCustomizedLists Or RSWIN_DESC.bXRODUseCustomizedLists Then
					dataRow("Preferences") = "Use General List: "
					dataRow("FromFile") = Me.CheckBoolean(RSWIN_DESC.AIFilePreferences.bXRODUseGeneralList)
					dataRow("FromSetup") = Me.CheckBoolean(RSWIN_DESC.bXRODUseGeneralList)
					Me.mdsPreferences.Tables(0).Rows.Add(dataRow)
					dataRow = Me.mdsPreferences.Tables(0).NewRow()
					dataRow("Preferences") = "Use Closest Unit: "
					dataRow("FromFile") = Me.CheckBoolean(RSWIN_DESC.AIFilePreferences.bXRODUseClosestUnit)
					dataRow("FromSetup") = Me.CheckBoolean(RSWIN_DESC.bXRODUseClosestUnit)
					Me.mdsPreferences.Tables(0).Rows.Add(dataRow)
					dataRow = Me.mdsPreferences.Tables(0).NewRow()
				End If
				dataRow("Preferences") = "Pumping Unit Manufacturer Preferences "
				dataRow("FromFile") = " "
				dataRow("FromSetup") = " "
				Me.mdsPreferences.Tables(0).Rows.Add(dataRow)
				dataRow = Me.mdsPreferences.Tables(0).NewRow()
				If RSWIN_DESC.AIFilePreferences.bUsePUManuf(1) Or RSWIN_DESC.get_bUsePUManuf(1) Then
					dataRow("Preferences") = "Manufacturer #1 "
					dataRow("FromFile") = Operators.AddObject(RSWIN_DESC.AIFilePreferences.PUManuf(1), Interaction.IIf(RSWIN_DESC.AIFilePreferences.bUsePUManuf(1), truePart, " "))
					dataRow("FromSetup") = Operators.AddObject(RSWIN_DESC.get_PUManuf(1), Interaction.IIf(RSWIN_DESC.get_bUsePUManuf(1), truePart, " "))
					Me.mdsPreferences.Tables(0).Rows.Add(dataRow)
					dataRow = Me.mdsPreferences.Tables(0).NewRow()
				End If
				If RSWIN_DESC.AIFilePreferences.bUsePUManuf(2) Or RSWIN_DESC.get_bUsePUManuf(2) Then
					dataRow("Preferences") = "Manufacturer #2 "
					dataRow("FromFile") = Operators.AddObject(RSWIN_DESC.AIFilePreferences.PUManuf(2), Interaction.IIf(RSWIN_DESC.AIFilePreferences.bUsePUManuf(2), truePart, " "))
					dataRow("FromSetup") = Operators.AddObject(RSWIN_DESC.get_PUManuf(2), Interaction.IIf(RSWIN_DESC.get_bUsePUManuf(2), truePart, " "))
					Me.mdsPreferences.Tables(0).Rows.Add(dataRow)
					dataRow = Me.mdsPreferences.Tables(0).NewRow()
				End If
				If RSWIN_DESC.AIFilePreferences.bUsePUManuf(3) Or RSWIN_DESC.get_bUsePUManuf(3) Then
					dataRow("Preferences") = "Manufacturer #3 "
					dataRow("FromFile") = Operators.AddObject(RSWIN_DESC.AIFilePreferences.PUManuf(3), Interaction.IIf(RSWIN_DESC.AIFilePreferences.bUsePUManuf(3), truePart, " "))
					dataRow("FromSetup") = Operators.AddObject(RSWIN_DESC.get_PUManuf(3), Interaction.IIf(RSWIN_DESC.get_bUsePUManuf(3), truePart, " "))
					Me.mdsPreferences.Tables(0).Rows.Add(dataRow)
					dataRow = Me.mdsPreferences.Tables(0).NewRow()
				End If
				If RSWIN_DESC.AIFilePreferences.bUsePUManuf(4) Or RSWIN_DESC.get_bUsePUManuf(4) Then
					dataRow("Preferences") = "Manufacturer #4 "
					dataRow("FromFile") = Operators.AddObject(RSWIN_DESC.AIFilePreferences.PUManuf(4), Interaction.IIf(RSWIN_DESC.AIFilePreferences.bUsePUManuf(4), truePart, " "))
					dataRow("FromSetup") = Operators.AddObject(RSWIN_DESC.get_PUManuf(4), Interaction.IIf(RSWIN_DESC.get_bUsePUManuf(4), truePart, " "))
					Me.mdsPreferences.Tables(0).Rows.Add(dataRow)
					dataRow = Me.mdsPreferences.Tables(0).NewRow()
				End If
				If RSWIN_DESC.AIFilePreferences.bUsePUManuf(5) Or RSWIN_DESC.get_bUsePUManuf(5) Then
					dataRow("Preferences") = "Manufacturer #5 "
					dataRow("FromFile") = Operators.AddObject(RSWIN_DESC.AIFilePreferences.PUManuf(5), Interaction.IIf(RSWIN_DESC.AIFilePreferences.bUsePUManuf(5), truePart, " "))
					dataRow("FromSetup") = Operators.AddObject(RSWIN_DESC.get_PUManuf(5), Interaction.IIf(RSWIN_DESC.get_bUsePUManuf(5), truePart, " "))
					Me.mdsPreferences.Tables(0).Rows.Add(dataRow)
					dataRow = Me.mdsPreferences.Tables(0).NewRow()
				End If
				If RSWIN_DESC.AIFilePreferences.bUsePUManuf(6) Or RSWIN_DESC.get_bUsePUManuf(6) Then
					dataRow("Preferences") = "Manufacturer #6 "
					dataRow("FromFile") = Operators.AddObject(RSWIN_DESC.AIFilePreferences.PUManuf(6), Interaction.IIf(RSWIN_DESC.AIFilePreferences.bUsePUManuf(6), truePart, " "))
					dataRow("FromSetup") = Operators.AddObject(RSWIN_DESC.get_PUManuf(6), Interaction.IIf(RSWIN_DESC.get_bUsePUManuf(6), truePart, " "))
					Me.mdsPreferences.Tables(0).Rows.Add(dataRow)
					dataRow = Me.mdsPreferences.Tables(0).NewRow()
				End If
				If RSWIN_DESC.AIFilePreferences.bUsePUManuf(7) Or RSWIN_DESC.get_bUsePUManuf(7) Then
					dataRow("Preferences") = "Manufacturer #7 "
					dataRow("FromFile") = Operators.AddObject(RSWIN_DESC.AIFilePreferences.PUManuf(7), Interaction.IIf(RSWIN_DESC.AIFilePreferences.bUsePUManuf(7), truePart, " "))
					dataRow("FromSetup") = Operators.AddObject(RSWIN_DESC.get_PUManuf(7), Interaction.IIf(RSWIN_DESC.get_bUsePUManuf(7), truePart, " "))
					Me.mdsPreferences.Tables(0).Rows.Add(dataRow)
					dataRow = Me.mdsPreferences.Tables(0).NewRow()
				End If
				If RSWIN_DESC.AIFilePreferences.bUsePUManuf(8) Or RSWIN_DESC.get_bUsePUManuf(8) Then
					dataRow("Preferences") = "Manufacturer #8 "
					dataRow("FromFile") = Operators.AddObject(RSWIN_DESC.AIFilePreferences.PUManuf(8), Interaction.IIf(RSWIN_DESC.AIFilePreferences.bUsePUManuf(8), truePart, " "))
					dataRow("FromSetup") = Operators.AddObject(RSWIN_DESC.get_PUManuf(8), Interaction.IIf(RSWIN_DESC.get_bUsePUManuf(8), truePart, " "))
					Me.mdsPreferences.Tables(0).Rows.Add(dataRow)
					dataRow = Me.mdsPreferences.Tables(0).NewRow()
				End If
				dataRow("Preferences") = "Rod-Tubing Friction Coefficient Preference "
				dataRow("FromFile") = " "
				dataRow("FromSetup") = " "
				Me.mdsPreferences.Tables(0).Rows.Add(dataRow)
				dataRow = Me.mdsPreferences.Tables(0).NewRow()
				Dim num As Single
				If RSWIN_DESC.AIFilePreferences.bUseAvgRodTBGFricCoeff Then
					num = 1F
				Else
					num = RSWIN_DESC.AIFilePreferences.TimesAvgRodTBGFricCoeff
				End If
				Dim num2 As Single
				If RSWIN_DESC.SETUP_bUseAvgRodTBGFricCoeff Then
					num2 = 1F
				Else
					num2 = RSWIN_DESC.SETUP_TimesAvgRodTBGFricCoeff
				End If
				dataRow("Preferences") = "Use X times fric. coeff. "
				dataRow("FromFile") = num
				dataRow("FromSetup") = num2
				Me.mdsPreferences.Tables(0).Rows.Add(dataRow)
				dataRow = Me.mdsPreferences.Tables(0).NewRow()
				dataRow("Preferences") = "Motor Preferences "
				dataRow("FromFile") = " "
				dataRow("FromSetup") = " "
				Me.mdsPreferences.Tables(0).Rows.Add(dataRow)
				dataRow = Me.mdsPreferences.Tables(0).NewRow()
				dataRow("Preferences") = "Power meter type: "
				dataRow("FromFile") = Me.CheckDetent(RSWIN_DESC.AIFilePreferences.PowerMeterType)
				dataRow("FromSetup") = Me.CheckDetent(RSWIN_DESC.SETUP_PowerMeterType)
				Me.mdsPreferences.Tables(0).Rows.Add(dataRow)
				dataRow = Me.mdsPreferences.Tables(0).NewRow()
				dataRow("Preferences") = "Include motor speed variation: "
				dataRow("FromFile") = Me.CheckBoolean(RSWIN_DESC.AIFilePreferences.IncludeMotorSPV)
				dataRow("FromSetup") = Me.CheckBoolean(RSWIN_DESC.SETUP_IncludeMotorSPV)
				Me.mdsPreferences.Tables(0).Rows.Add(dataRow)
				dataRow = Me.mdsPreferences.Tables(0).NewRow()
				Me.ulgPreferences.DataSource = Me.mdsPreferences
				Me.ulgPreferences.Rows.Refresh(RefreshRow.RefreshDisplay, True)
				Me.SetGridColors()
				Me.chkOverwriteSetupPreferences.Enabled = False
				Me.bOverwriteSetup = False
				Me.bUseSetup = True
				Me.bUseFile = False
				Me.bOverwriteSetup = False
				Me.chkOverwriteSetupPreferences.Enabled = False
				Me.chkOverwriteSetupPreferences.Visible = False
				Me.chkUseFile.Checked = False
				Me.chkUseSetup.Checked = True
				Try
					If Screen.PrimaryScreen.Bounds.Height < 800 Or Screen.PrimaryScreen.Bounds.Width < 1100 Then
						Me.AutoScroll = True
						Dim startPoint As Object = Me.StartPoint
						Dim point As Point
						Me.AutoScrollPosition = If((startPoint IsNot Nothing), CType(startPoint, Point), point)
						Me._SSPanel_0.AutoScroll = True
						Dim sspanel_ As ScrollableControl = Me._SSPanel_0
						Dim startPoint2 As Object = Me.StartPoint
						sspanel_.AutoScrollPosition = If((startPoint2 IsNot Nothing), CType(startPoint2, Point), point)
					End If
				Catch ex As Exception
				End Try
			Catch ex2 As Exception
			End Try
		End Sub

		Private Sub chkUseSetup_CheckedChanged(sender As Object, e As EventArgs)
			If Me.ActiveControl Is Me.chkUseSetup Then
				If Me.chkUseSetup.Checked Then
					Me.bUseSetup = True
					Me.bUseFile = False
					Me.bOverwriteSetup = False
					Me.chkOverwriteSetupPreferences.Enabled = False
					Me.chkOverwriteSetupPreferences.Visible = False
					Me.chkUseFile.Checked = False
				Else
					Me.bUseFile = True
					Me.bUseSetup = False
					Me.chkOverwriteSetupPreferences.Enabled = True
					Me.chkOverwriteSetupPreferences.Visible = True
					Me.chkUseSetup.Checked = False
					Me.chkUseFile.Checked = True
				End If
				Return
			End If
		End Sub

		Private Sub chkUseFile_CheckedChanged(sender As Object, e As EventArgs)
			If Me.ActiveControl Is Me.chkUseFile Then
				If Me.chkUseFile.Checked Then
					Me.bUseFile = True
					Me.bUseSetup = False
					Me.chkOverwriteSetupPreferences.Enabled = True
					Me.chkOverwriteSetupPreferences.Visible = True
					Me.chkUseSetup.Checked = False
				Else
					Me.chkOverwriteSetupPreferences.Enabled = False
					Me.bOverwriteSetup = False
					Me.bUseSetup = True
					Me.bUseFile = False
					Me.bOverwriteSetup = False
					Me.chkOverwriteSetupPreferences.Enabled = False
					Me.chkOverwriteSetupPreferences.Visible = False
					Me.chkUseFile.Checked = False
					Me.chkUseSetup.Checked = True
				End If
				Return
			End If
		End Sub

		Private Function CheckBoolean(bValue As Boolean) As String
			If bValue Then
				Return "Yes"
			End If
			Return "No"
		End Function

		Private Function CheckDetent(iValue As Short) As String
			If iValue = 1S Then
				Return "Detent"
			End If
			Return "Non-Detent"
		End Function

		Private Sub cmdOK_Click(sender As Object, e As EventArgs)
			If Not Me.chkUseSetup.Checked And Not Me.chkUseFile.Checked Then
				MessageBox.Show("Please select one of the preference options!")
				Return
			End If
			Me.Hide()
		End Sub

		Private Sub chkOverwriteSetupPreferences_CheckedChanged(sender As Object, e As EventArgs)
			If Me.ActiveControl Is Me.chkOverwriteSetupPreferences Then
				If Me.chkOverwriteSetupPreferences.Checked Then
					Dim msg As String = "Overwrite AI Preferences in Setup with those from file. Are you sure?"
					Dim bDefaultYes As Boolean = False
					Dim flag As Boolean = False
					If Util.YesNo(msg, bDefaultYes, flag) Then
						Me.bOverwriteSetup = Me.chkOverwriteSetupPreferences.Checked
					Else
						Me.bOverwriteSetup = False
						Me.chkOverwriteSetupPreferences.Checked = False
					End If
				End If
				Return
			End If
		End Sub

		Private Sub ulgPreferences_InitializeLayout(eventSender As Object, eventArgs As InitializeLayoutEventArgs)
			Try
				Dim layout As UltraGridLayout = eventArgs.Layout
				layout.TabNavigation = TabNavigation.NextCell
				Dim ultraGridBand As UltraGridBand = layout.Bands(0)
				Dim ultraGridColumn As UltraGridColumn = ultraGridBand.Columns("Preferences")
				ultraGridColumn.Header.Caption = "Preferences"
				ultraGridColumn.Width = 275
				Dim ultraGridColumn2 As UltraGridColumn = ultraGridBand.Columns("FromFile")
				ultraGridColumn2.Header.Caption = "From File "
				ultraGridColumn2.Width = 255
				ultraGridColumn2.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
				Dim ultraGridColumn3 As UltraGridColumn = ultraGridBand.Columns("FromSetup")
				ultraGridColumn3.Header.Caption = "From Setup"
				ultraGridColumn3.Width = 255
				ultraGridColumn3.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
				Dim ultraGrid As UltraGrid = Me.ulgPreferences
				Try
					ultraGrid.ActiveRow = ultraGrid.GetRow(ChildRow.First)
				Catch ex As Exception
				End Try
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

		Public Sub InitPreferencesDataset(ByRef mdsPreferences As DataSet)
			Try
				mdsPreferences = Nothing
				mdsPreferences = New DataSet("Preferences")
				Dim dataTable As DataTable = New DataTable("Preferences")
				Dim dataColumn As DataColumn = New DataColumn("Preferences", GetType(String))
				dataColumn.AllowDBNull = True
				dataTable.Columns.Add(dataColumn)
				Dim dataColumn2 As DataColumn = New DataColumn("FromFile", GetType(String))
				dataColumn2.AllowDBNull = True
				dataTable.Columns.Add(dataColumn2)
				Dim dataColumn3 As DataColumn = New DataColumn("FromSetup", GetType(String))
				dataColumn3.AllowDBNull = True
				dataTable.Columns.Add(dataColumn3)
				mdsPreferences.Tables.Add(dataTable)
				mdsPreferences.Tables(0).Clear()
			Catch ex As Exception
				MessageBox.Show("Error in InitPreferencesDataset: " + ex.Message)
			End Try
		End Sub

		Private Sub SetGridColors()
			Try
				Dim ultraGridRow As UltraGridRow = Me.ulgPreferences.GetRow(ChildRow.First)
				While ultraGridRow IsNot Nothing
					If Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(ultraGridRow.Cells("FromFile").Value, ultraGridRow.Cells("FromSetup").Value, False))) Then
						ultraGridRow.Cells("Preferences").Appearance.BackColor = Color.DarkRed
						ultraGridRow.Cells("FromFile").Appearance.BackColor = Color.DarkRed
						ultraGridRow.Cells("FromSetup").Appearance.BackColor = Color.DarkRed
						ultraGridRow.Cells("Preferences").Appearance.ForeColor = Color.White
						ultraGridRow.Cells("FromFile").Appearance.ForeColor = Color.White
						ultraGridRow.Cells("FromSetup").Appearance.ForeColor = Color.White
					Else
						ultraGridRow.Cells("Preferences").Appearance.BackColor = Color.White
						ultraGridRow.Cells("FromFile").Appearance.BackColor = Color.White
						ultraGridRow.Cells("FromSetup").Appearance.BackColor = Color.White
						ultraGridRow.Cells("Preferences").Appearance.ForeColor = Color.Black
						ultraGridRow.Cells("FromFile").Appearance.ForeColor = Color.Black
						ultraGridRow.Cells("FromSetup").Appearance.ForeColor = Color.Black
					End If
					If Strings.InStr(Conversions.ToString(ultraGridRow.Cells("Preferences").Value), "Preference", CompareMethod.Binary) > 0 Then
						ultraGridRow.Cells("Preferences").Appearance.FontData.Italic = DefaultableBoolean.[True]
						ultraGridRow.Cells("Preferences").Appearance.BackGradientStyle = GradientStyle.Horizontal
						ultraGridRow.Cells("Preferences").Appearance.BackColor2 = Color.LightGray
						ultraGridRow.Cells("Preferences").Appearance.BackColor = Color.LightSlateGray
						ultraGridRow.Cells("Preferences").Appearance.ForeColor = Color.Black
						ultraGridRow.Cells("FromFile").Appearance.BackColor = Color.LightGray
						ultraGridRow.Cells("FromFile").Appearance.ForeColor = Color.Black
						ultraGridRow.Cells("FromSetup").Appearance.BackColor = Color.LightGray
						ultraGridRow.Cells("FromSetup").Appearance.ForeColor = Color.Black
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

		Private Sub dlgAIPreference_Resize(sender As Object, e As EventArgs)
			' The following expression was wrapped in a checked-statement
			Try
				If Screen.PrimaryScreen.Bounds.Height < 800 Or Screen.PrimaryScreen.Bounds.Width < 1100 Then
					If Me.Height > Screen.PrimaryScreen.Bounds.Height Then
						Me.Height = Screen.PrimaryScreen.Bounds.Height
					End If
					If Me.Width > Screen.PrimaryScreen.Bounds.Width Then
						Me.Width = Screen.PrimaryScreen.Bounds.Width
					End If
					Me.AutoScroll = True
					Dim startPoint As Object = Me.StartPoint
					Dim point As Point
					Me.AutoScrollPosition = If((startPoint IsNot Nothing), CType(startPoint, Point), point)
					Me._SSPanel_0.Height = Me.Height - Me.Panel1.Height - 40
					Me.ulgPreferences.Height = Me._SSPanel_0.Height - 40
					Me._SSPanel_0.AutoScroll = True
					Dim sspanel_ As ScrollableControl = Me._SSPanel_0
					Dim startPoint2 As Object = Me.StartPoint
					sspanel_.AutoScrollPosition = If((startPoint2 IsNot Nothing), CType(startPoint2, Point), point)
					Me.Panel1.Top = Me._SSPanel_0.Top + Me._SSPanel_0.Height + 4
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub dlgAIPreference_Activated(sender As Object, e As EventArgs)
			RSWIN.GetMeasurementUnit()
		End Sub

		Private Const sPreferences As String = "Preferences"

		Private Const sFromFile As String = "FromFile"

		Private Const sFromSetup As String = "FromSetup"

		Private StartPoint As Object

		<AccessedThroughProperty("_Label_0")>
		Private __Label_0 As Label

		<AccessedThroughProperty("_SSPanel_0")>
		Private __SSPanel_0 As Panel

		<AccessedThroughProperty("Image")>
		Private _Image As PictureBox

		<AccessedThroughProperty("Label")>
		Private _Label As LabelArray

		<AccessedThroughProperty("SSPanel")>
		Private _SSPanel As PanelArray

		<AccessedThroughProperty("ulgPreferences")>
		Private _ulgPreferences As UltraGrid

		<AccessedThroughProperty("Panel1")>
		Private _Panel1 As Panel

		<AccessedThroughProperty("cmdOK")>
		Private _cmdOK As Button

		<AccessedThroughProperty("chkUseFile")>
		Private _chkUseFile As CheckBox

		<AccessedThroughProperty("chkUseSetup")>
		Private _chkUseSetup As CheckBox

		<AccessedThroughProperty("chkOverwriteSetupPreferences")>
		Private _chkOverwriteSetupPreferences As CheckBox

		Private Shared m_vb6FormDefInstance As dlgAIPreference

		Private Shared m_InitializingDefInstance As Boolean

		Private m_bUseFile As Boolean

		Private m_bUseSetup As Boolean

		Private m_bOverwriteSetup As Boolean

		Private mdsPreferences As DataSet
	End Class
End Namespace
