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
	Friend Partial Class dlgGuides
		Inherits Form

		Friend Overridable Property cboGuides As ComboBox
			Get
				Return Me._cboGuides
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim value2 As EventHandler = AddressOf Me.cboGuides_SelectedIndexChanged
				If Me._cboGuides IsNot Nothing Then
					RemoveHandler Me._cboGuides.SelectedIndexChanged, value2
				End If
				Me._cboGuides = value
				If Me._cboGuides IsNot Nothing Then
					AddHandler Me._cboGuides.SelectedIndexChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property btnNo As Button
			Get
				Return Me._btnNo
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnNo_Click
				If Me._btnNo IsNot Nothing Then
					RemoveHandler Me._btnNo.Click, value2
				End If
				Me._btnNo = value
				If Me._btnNo IsNot Nothing Then
					AddHandler Me._btnNo.Click, value2
				End If
			End Set
		End Property

		Public Overridable Property btnYes As Button
			Get
				Return Me._btnYes
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnYes_Click
				If Me._btnYes IsNot Nothing Then
					RemoveHandler Me._btnYes.Click, value2
				End If
				Me._btnYes = value
				If Me._btnYes IsNot Nothing Then
					AddHandler Me._btnYes.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property lblOverwrite As Label
			Get
				Return Me._lblOverwrite
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblOverwrite = value
			End Set
		End Property

		Friend Overridable Property lblQuestionMark As Label
			Get
				Return Me._lblQuestionMark
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblQuestionMark = value
			End Set
		End Property

		Public Overridable Property btnOverwriteNo As Button
			Get
				Return Me._btnOverwriteNo
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnOverwriteNo_Click
				If Me._btnOverwriteNo IsNot Nothing Then
					RemoveHandler Me._btnOverwriteNo.Click, value2
				End If
				Me._btnOverwriteNo = value
				If Me._btnOverwriteNo IsNot Nothing Then
					AddHandler Me._btnOverwriteNo.Click, value2
				End If
			End Set
		End Property

		Public Overridable Property btnOverwriteYes As Button
			Get
				Return Me._btnOverwriteYes
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Me._btnOverwriteYes = value
			End Set
		End Property

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.dlgGuides_Load
			AddHandler MyBase.Resize, AddressOf Me.dlgGuides_Resize
			AddHandler MyBase.Activated, AddressOf Me.dlgGuides_Activated
			Dim point As Point = New Point(0, 0)
			Me.StartPoint = point
			Me.m_bUseFile = False
			Me.m_bUseSetup = False
			Me.m_bOverwriteSetup = False
			If dlgGuides.m_vb6FormDefInstance Is Nothing Then
				If dlgGuides.m_InitializingDefInstance Then
					dlgGuides.m_vb6FormDefInstance = Me
				Else
					Try
						If Assembly.GetExecutingAssembly().EntryPoint.DeclaringType Is Me.[GetType]() Then
							dlgGuides.m_vb6FormDefInstance = Me
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

		Public Overridable Property ulgRodGuides As UltraGrid
			Get
				Return Me._ulgRodGuides
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As UltraGrid)
				Dim value2 As InitializeLayoutEventHandler = AddressOf Me.ulgRodGuides_InitializeLayout
				If Me._ulgRodGuides IsNot Nothing Then
					RemoveHandler Me._ulgRodGuides.InitializeLayout, value2
				End If
				Me._ulgRodGuides = value
				If Me._ulgRodGuides IsNot Nothing Then
					AddHandler Me._ulgRodGuides.InitializeLayout, value2
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

		Public Shared Property DefInstance As dlgGuides
			Get
				If dlgGuides.m_vb6FormDefInstance Is Nothing OrElse dlgGuides.m_vb6FormDefInstance.IsDisposed Then
					dlgGuides.m_InitializingDefInstance = True
					dlgGuides.m_vb6FormDefInstance = New dlgGuides()
					dlgGuides.m_InitializingDefInstance = False
				End If
				Return dlgGuides.m_vb6FormDefInstance
			End Get
			Set(value As dlgGuides)
				dlgGuides.m_vb6FormDefInstance = value
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

		Public Property GuideInFileToUse As Integer
			Get
				Return Me.m_GuideInFileToUse
			End Get
			Set(value As Integer)
				Me.m_GuideInFileToUse = value
			End Set
		End Property

		Private Sub dlgGuides_Load(eventSender As Object, eventArgs As EventArgs)
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
			Me.AssignRodGuideData()
			If RSWIN_DESC.bWriteResXFile Then
				Util.OpenResourceWriter(Me.Name)
				Util.WriteControlStrings(Me, Me.ToolTip1)
				Util.CloseResourceWriter()
				Return
			End If
		End Sub

		Private Sub AssignRodGuideData()
			Dim text As String = "  (" + Conversions.ToString(Strings.Chr(215)) + ")"
			Try
				Dim text2 As String = "GuideToUse"
				Dim molded As Integer = CInt(RSWIN_DESC.MOLDED)
				Dim regProfileStringByInt As String = RSWIN.GetRegProfileStringByInt(RSWIN_DESC.SECT_RSWIN, text2, molded)
				RSWIN_DESC.MOLDED = CShort(molded)
				RSWIN_DESC.SETUP_GuideToUse = Conversions.ToInteger(regProfileStringByInt)
				If RSWIN_DESC.SETUP_GuideToUse = 0 Then
					RSWIN_DESC.SETUP_GuideToUse = CInt(RSWIN_DESC.MOLDED)
					text2 = "GuideToUse"
					Dim text3 As String = Conversions.ToString(CInt(RSWIN_DESC.MOLDED))
					RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text3, RSWIN_DESC.sINIFile)
					RSWIN_DESC.MOLDED = Conversions.ToShort(text3)
				End If
				Me.ulgRodGuides.DataSource = Nothing
				Me.InitRodGuidesDataset(Me.mdsRodGuides)
				Dim dataRow As DataRow = Me.mdsRodGuides.Tables(0).NewRow()
				If RSWIN_DESC.rst.RodStringType = 3S Then
					dataRow("FileSide") = "Rod Guide : " + Me.GetRodGuideName(CShort(RSWIN_DESC.rst.RSRodGuide))
					dataRow("SetupSide") = Me.GetRodGuideName(CShort(RSWIN_DESC.SETUP_GuideToUse))
					Me.mdsRodGuides.Tables(0).Rows.Add(dataRow)
					dataRow = Me.mdsRodGuides.Tables(0).NewRow()
				Else
					Dim num As Integer = 1
					Dim numRods As Integer = CInt(RSWIN_DESC.rst.NumRods)
					For i As Integer = num To numRods
						dataRow("FileSide") = "Taper " + i.ToString().Trim() + " : " + Me.GetRodGuideName(RSWIN_DESC.rst.Sections(i).Guide)
						If i = 1 Then
							dataRow("SetupSide") = Me.GetRodGuideName(CShort(RSWIN_DESC.SETUP_GuideToUse))
						Else
							dataRow("SetupSide") = ""
						End If
						Me.mdsRodGuides.Tables(0).Rows.Add(dataRow)
						dataRow = Me.mdsRodGuides.Tables(0).NewRow()
					Next
				End If
				Me.ulgRodGuides.DataSource = Me.mdsRodGuides
				Me.ulgRodGuides.Rows.Refresh(RefreshRow.RefreshDisplay, True)
				Me.SetGridColors()
				Me.bOverwriteSetup = False
				Me.bUseSetup = True
				Me.bUseFile = False
				Me.bOverwriteSetup = False
				Me.cboGuides.Visible = False
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
			Me.Hide()
		End Sub

		Private Sub ulgRodGuides_InitializeLayout(eventSender As Object, eventArgs As InitializeLayoutEventArgs)
			Try
				Dim layout As UltraGridLayout = eventArgs.Layout
				layout.TabNavigation = TabNavigation.NextCell
				Dim ultraGridBand As UltraGridBand = layout.Bands(0)
				Dim ultraGridColumn As UltraGridColumn = ultraGridBand.Columns("FileSide")
				ultraGridColumn.Header.Caption = "From File"
				ultraGridColumn.Width = 240
				Dim ultraGridColumn2 As UltraGridColumn = ultraGridBand.Columns("SetupSide")
				ultraGridColumn2.Header.Caption = "From Setup"
				ultraGridColumn2.Width = 260
				ultraGridColumn2.Nullable = Infragistics.Win.UltraWinGrid.Nullable.Null
				ultraGridColumn2.CellAppearance.TextHAlign = HAlign.Center
				Dim ultraGrid As UltraGrid = Me.ulgRodGuides
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

		Public Sub InitRodGuidesDataset(ByRef mdsRodGuides As DataSet)
			Try
				mdsRodGuides = Nothing
				mdsRodGuides = New DataSet("RodGuides")
				Dim dataTable As DataTable = New DataTable("RodGuides")
				Dim dataColumn As DataColumn = New DataColumn("FileSide", GetType(String))
				dataColumn.AllowDBNull = True
				dataTable.Columns.Add(dataColumn)
				Dim dataColumn2 As DataColumn = New DataColumn("SetupSide", GetType(String))
				dataColumn2.AllowDBNull = True
				dataTable.Columns.Add(dataColumn2)
				mdsRodGuides.Tables.Add(dataTable)
				mdsRodGuides.Tables(0).Clear()
			Catch ex As Exception
				MessageBox.Show("Error in InitRodGuidesDataset: " + ex.Message)
			End Try
		End Sub

		Private Sub SetGridColors()
			' The following expression was wrapped in a checked-statement
			Try
				Dim ultraGridRow As UltraGridRow = Me.ulgRodGuides.GetRow(ChildRow.First)
				Me.cboGuides.Items.Clear()
				While ultraGridRow IsNot Nothing
					If Strings.InStr(Conversions.ToString(ultraGridRow.Cells("FileSide").Value), "Taper", CompareMethod.Binary) > 0 Then
						Dim startIndex As Integer = Strings.InStr(Conversions.ToString(ultraGridRow.Cells("FileSide").Value), ":", CompareMethod.Binary) + 1
						Dim text As String = Conversions.ToString(ultraGridRow.Cells("FileSide").Value)
						text = text.Substring(startIndex)
						Me.AddGuideToCombo(text)
					ElseIf Strings.InStr(Conversions.ToString(ultraGridRow.Cells("FileSide").Value), "Rod Guide", CompareMethod.Binary) > 0 Then
						Dim startIndex As Integer = Strings.InStr(Conversions.ToString(ultraGridRow.Cells("FileSide").Value), ":", CompareMethod.Binary) + 1
						Dim text As String = Conversions.ToString(ultraGridRow.Cells("FileSide").Value)
						text = text.Substring(startIndex)
						Me.AddGuideToCombo(text)
					End If
					ultraGridRow.Cells("FileSide").Appearance.BackColor = Color.LightGreen
					ultraGridRow.Cells("FileSide").Appearance.BackColor = Color.LightGreen
					ultraGridRow.Cells("SetupSide").Appearance.BackColor = Color.LightBlue
					ultraGridRow.Cells("SetupSide").Appearance.BackColor = Color.LightBlue
					If ultraGridRow.HasNextSibling() Then
						ultraGridRow = ultraGridRow.GetSibling(SiblingRow.[Next])
					Else
						ultraGridRow = Nothing
					End If
				End While
			Catch ex As Exception
			End Try
		End Sub

		Private Sub dlgGuides_Resize(sender As Object, e As EventArgs)
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
					Me.ulgRodGuides.Height = Me._SSPanel_0.Height - 40
					Me._SSPanel_0.AutoScroll = True
					Dim sspanel_ As ScrollableControl = Me._SSPanel_0
					Dim startPoint2 As Object = Me.StartPoint
					sspanel_.AutoScrollPosition = If((startPoint2 IsNot Nothing), CType(startPoint2, Point), point)
					Me.Panel1.Top = Me._SSPanel_0.Top + Me._SSPanel_0.Height + 4
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub dlgGuides_Activated(sender As Object, e As EventArgs)
			RSWIN.GetMeasurementUnit()
		End Sub

		Public Function GetRodGuideName(RodGuide As Short) As String
			Dim text As String = New String(" "c, 8192)
			Dim result As String
			Try
				If RodGuide = 0S Then
					result = "Bare Rod (no rod guides)"
				ElseIf RodGuide = RSWIN_DESC.MOLDED Then
					result = "Molded"
				ElseIf RodGuide = 2S Then
					result = "Wheeled"
				ElseIf RodGuide = 3S Then
					Dim text2 As String = "OtherGuide"
					Dim text3 As String = "Other"
					Dim length As Short = CShort(RSWIN.GetRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text3, text, True))
					RSWIN_DESC.sOtherGuided = text.Substring(0, CInt(length))
					result = RSWIN_DESC.sOtherGuided
				ElseIf RodGuide = 4S Then
					result = "Norris Standard"
				ElseIf RodGuide = RSWIN_DESC.NorrisSidewinderGuide Then
					result = "Norris Sidewinder"
				ElseIf RodGuide = 6S Then
					result = "RGI Jake Coupling"
				ElseIf RodGuide = 7S Then
					result = "RGI SVT"
				ElseIf RodGuide = 8S Then
					result = "RGI Tomahawk"
				ElseIf RodGuide = 9S Then
					result = "RGI Tornado"
				ElseIf RodGuide = 10S Then
					result = "RGI Twister"
				ElseIf RodGuide = 11S Then
					result = "RGI WVT"
				End If
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Sub AddGuideToCombo(sRodGuide As String)
			' The following expression was wrapped in a checked-statement
			Try
				Dim flag As Boolean = False
				If Me.cboGuides.Items.Count = 0 Then
					Me.cboGuides.Items.Add(sRodGuide)
				Else
					Dim num As Integer = 0
					Dim num2 As Integer = Me.cboGuides.Items.Count - 1
					For i As Integer = num To num2
						If Operators.ConditionalCompareObjectEqual(Me.cboGuides.Items(i), sRodGuide, False) Then
							flag = True
						End If
					Next
					If Not flag Then
						Me.cboGuides.Items.Add(sRodGuide)
					End If
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub cboGuides_SelectedIndexChanged(sender As Object, e As EventArgs)
			Me.GuideInFileToUse = CInt(Me.GetRodGuideByName(Conversions.ToString(Me.cboGuides.SelectedItem)))
		End Sub

		Public Function GetRodGuideByName(sRodGuide As String) As Short
			Dim result As Short
			Try
				If Operators.CompareString(sRodGuide, "Bare Rod (no rod guides)", False) = 0 Then
					result = 0S
				ElseIf Operators.CompareString(sRodGuide, "Molded", False) = 0 Then
					result = RSWIN_DESC.MOLDED
				ElseIf Operators.CompareString(sRodGuide, "Wheeled", False) = 0 Then
					result = 2S
				ElseIf Operators.CompareString(sRodGuide, RSWIN_DESC.sOtherGuided, False) = 0 Then
					result = 3S
				ElseIf Operators.CompareString(sRodGuide, "Norris Standard", False) = 0 Then
					result = 4S
				ElseIf Operators.CompareString(sRodGuide, "Norris Sidewinder", False) = 0 Then
					result = RSWIN_DESC.NorrisSidewinderGuide
				ElseIf Operators.CompareString(sRodGuide, "RGI Jake Coupling", False) = 0 Then
					result = 6S
				ElseIf Operators.CompareString(sRodGuide, "RGI SVT", False) = 0 Then
					result = 7S
				ElseIf Operators.CompareString(sRodGuide, "RGI Tomahawk", False) = 0 Then
					result = 8S
				ElseIf Operators.CompareString(sRodGuide, "RGI Tornado", False) = 0 Then
					result = 9S
				ElseIf Operators.CompareString(sRodGuide, "RGI Twister", False) = 0 Then
					result = 10S
				ElseIf Operators.CompareString(sRodGuide, "RGI WVT", False) = 0 Then
					result = 11S
				End If
			Catch ex As Exception
			End Try
			Return result
		End Function

		Private Sub btnYes_Click(sender As Object, e As EventArgs)
			Me.bUseSetup = True
			Me.bUseFile = False
			Me.bOverwriteSetup = False
			Me.cboGuides.Visible = False
			Me.Hide()
		End Sub

		Private Sub btnNo_Click(sender As Object, e As EventArgs)
			Me.bUseFile = True
			Me.bUseSetup = False
			Me.Hide()
		End Sub

		Private Sub btnOverwriteYes_Click(sender As Object, e As EventArgs)
			If Me.ActiveControl Is Me.btnOverwriteYes Then
				Me.bOverwriteSetup = True
				Me.Hide()
				Return
			End If
		End Sub

		Private Sub btnOverwriteNo_Click(sender As Object, e As EventArgs)
			Me.bOverwriteSetup = False
			Me.Hide()
		End Sub

		Private Sub AssignRodGuideData_Old()
			Dim text As String = "  (" + Conversions.ToString(Strings.Chr(215)) + ")"
			Try
				Dim text2 As String = "GuideToUse"
				Dim molded As Integer = CInt(RSWIN_DESC.MOLDED)
				Dim regProfileStringByInt As String = RSWIN.GetRegProfileStringByInt(RSWIN_DESC.SECT_RSWIN, text2, molded)
				RSWIN_DESC.MOLDED = CShort(molded)
				RSWIN_DESC.SETUP_GuideToUse = Conversions.ToInteger(regProfileStringByInt)
				Me.ulgRodGuides.DataSource = Nothing
				Me.InitRodGuidesDataset(Me.mdsRodGuides)
				Dim dataRow As DataRow = Me.mdsRodGuides.Tables(0).NewRow()
				dataRow("FileSide") = "Setup/Default : "
				dataRow("SetupSide") = Me.GetRodGuideName(CShort(RSWIN_DESC.SETUP_GuideToUse))
				Me.mdsRodGuides.Tables(0).Rows.Add(dataRow)
				dataRow = Me.mdsRodGuides.Tables(0).NewRow()
				dataRow("FileSide") = "File: "
				dataRow("SetupSide") = " "
				Me.mdsRodGuides.Tables(0).Rows.Add(dataRow)
				dataRow = Me.mdsRodGuides.Tables(0).NewRow()
				If RSWIN_DESC.rst.RodStringType = 3S Then
					dataRow("FileSide") = "   Rod Guide : "
					dataRow("SetupSide") = Me.GetRodGuideName(CShort(RSWIN_DESC.rst.RSRodGuide))
					Me.mdsRodGuides.Tables(0).Rows.Add(dataRow)
					dataRow = Me.mdsRodGuides.Tables(0).NewRow()
				Else
					Dim num As Integer = 1
					Dim numRods As Integer = CInt(RSWIN_DESC.rst.NumRods)
					For i As Integer = num To numRods
						dataRow("FileSide") = "   Taper " + i.ToString().Trim() + " : "
						dataRow("SetupSide") = Me.GetRodGuideName(RSWIN_DESC.rst.Sections(i).Guide)
						Me.mdsRodGuides.Tables(0).Rows.Add(dataRow)
						dataRow = Me.mdsRodGuides.Tables(0).NewRow()
					Next
				End If
				Me.ulgRodGuides.DataSource = Me.mdsRodGuides
				Me.ulgRodGuides.Rows.Refresh(RefreshRow.RefreshDisplay, True)
				Me.SetGridColors()
				Me.bOverwriteSetup = False
				Me.bUseSetup = True
				Me.bUseFile = False
				Me.bOverwriteSetup = False
				Me.cboGuides.Visible = False
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

		Private Const sFileSide As String = "FileSide"

		Private Const sSetupSide As String = "SetupSide"

		<AccessedThroughProperty("cboGuides")>
		Private _cboGuides As ComboBox

		<AccessedThroughProperty("btnNo")>
		Private _btnNo As Button

		<AccessedThroughProperty("btnYes")>
		Private _btnYes As Button

		<AccessedThroughProperty("lblOverwrite")>
		Private _lblOverwrite As Label

		<AccessedThroughProperty("lblQuestionMark")>
		Private _lblQuestionMark As Label

		<AccessedThroughProperty("btnOverwriteNo")>
		Private _btnOverwriteNo As Button

		<AccessedThroughProperty("btnOverwriteYes")>
		Private _btnOverwriteYes As Button

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

		<AccessedThroughProperty("ulgRodGuides")>
		Private _ulgRodGuides As UltraGrid

		<AccessedThroughProperty("Panel1")>
		Private _Panel1 As Panel

		Private Shared m_vb6FormDefInstance As dlgGuides

		Private Shared m_InitializingDefInstance As Boolean

		Private m_bUseFile As Boolean

		Private m_bUseSetup As Boolean

		Private m_bOverwriteSetup As Boolean

		Private m_GuideInFileToUse As Integer

		Private mdsRodGuides As DataSet
	End Class
End Namespace
