Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Globalization
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	Public Partial Class VisInput
		Inherits Form

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.VisInput_Load
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
			Me.myAL = New ArrayList()
			Me.SFList = New Hashtable()
			Me.myKeyValueHT = New Hashtable()
			If VisInput.m_vb6FormDefInstance Is Nothing Then
				If VisInput.m_InitializingDefInstance Then
					VisInput.m_vb6FormDefInstance = Me
				Else
					Try
						If Assembly.GetExecutingAssembly().EntryPoint.DeclaringType Is Me.[GetType]() Then
							VisInput.m_vb6FormDefInstance = Me
						End If
					Catch ex As Exception
					End Try
				End If
			End If
			Me.InitializeComponent()
		End Sub

		Friend Overridable Property VIImageList1 As ImageList
			Get
				Return Me._VIImageList1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ImageList)
				Me._VIImageList1 = value
			End Set
		End Property

		Friend Overridable Property VIContextMenu1 As ContextMenu
			Get
				Return Me._VIContextMenu1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ContextMenu)
				Me._VIContextMenu1 = value
			End Set
		End Property

		Public Overridable Property VIPanel2 As Panel
			Get
				Return Me._VIPanel2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._VIPanel2 = value
			End Set
		End Property

		Public Overridable Property VIPanel1 As Panel
			Get
				Return Me._VIPanel1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._VIPanel1 = value
			End Set
		End Property

		Public Overridable Property imgVIPicture As PictureBox
			Get
				Return Me._imgVIPicture
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim value2 As MouseEventHandler = AddressOf Me.imgVIPicture_MouseDown
				Dim value3 As MouseEventHandler = AddressOf Me.imgVIPicture_MouseMove
				If Me._imgVIPicture IsNot Nothing Then
					RemoveHandler Me._imgVIPicture.MouseDown, value2
					RemoveHandler Me._imgVIPicture.MouseMove, value3
				End If
				Me._imgVIPicture = value
				If Me._imgVIPicture IsNot Nothing Then
					AddHandler Me._imgVIPicture.MouseDown, value2
					AddHandler Me._imgVIPicture.MouseMove, value3
				End If
			End Set
		End Property

		Public Overridable Property cmdVISelInput As Button
			Get
				Return Me._cmdVISelInput
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.cmdSelInput_Click
				If Me._cmdVISelInput IsNot Nothing Then
					RemoveHandler Me._cmdVISelInput.Click, value2
				End If
				Me._cmdVISelInput = value
				If Me._cmdVISelInput IsNot Nothing Then
					AddHandler Me._cmdVISelInput.Click, value2
				End If
			End Set
		End Property

		Public Overridable Property VILabel As Label
			Get
				Return Me._VILabel
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Dim value2 As EventHandler = AddressOf Me.Label_Click
				If Me._VILabel IsNot Nothing Then
					RemoveHandler Me._VILabel.Click, value2
				End If
				Me._VILabel = value
				If Me._VILabel IsNot Nothing Then
					AddHandler Me._VILabel.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property VIToolTip1 As ToolTip
			Get
				Return Me._VIToolTip1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolTip)
				Me._VIToolTip1 = value
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

		Friend Overridable Property Panel1 As Panel
			Get
				Return Me._Panel1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._Panel1 = value
			End Set
		End Property

		Public Shared Property DefInstance As VisInput
			Get
				If VisInput.m_vb6FormDefInstance Is Nothing OrElse VisInput.m_vb6FormDefInstance.IsDisposed Then
					VisInput.m_InitializingDefInstance = True
					VisInput.m_vb6FormDefInstance = New VisInput()
					VisInput.m_InitializingDefInstance = False
				End If
				Return VisInput.m_vb6FormDefInstance
			End Get
			Set(value As VisInput)
				VisInput.m_vb6FormDefInstance = value
			End Set
		End Property

		Private Sub GetScrnNum(sKey As String, ByRef ScrnNum As Integer)
			Dim enumerator As IDictionaryEnumerator = Me.SFList.GetEnumerator()
			While enumerator.MoveNext()
				If Operators.ConditionalCompareObjectEqual(enumerator.Key, sKey, False) Then
					Dim objectValue As Object = RuntimeHelpers.GetObjectValue(enumerator.Value)
					ScrnNum = Convert.ToInt32(RuntimeHelpers.GetObjectValue(objectValue))
				End If
			End While
		End Sub

		Private Sub imgVIPicture_Click(sender As Object, e As EventArgs)
		End Sub

		Public Sub ShowMyImage(fileToDisplay As String, xSize As Integer, ySize As Integer)
			If Me.MyImage IsNot Nothing Then
				Me.MyImage.Dispose()
			End If
			Me.imgVIPicture.SizeMode = PictureBoxSizeMode.StretchImage
			Me.MyImage = New Bitmap(fileToDisplay)
			Dim imgVIPicture As Control = Me.imgVIPicture
			Dim clientSize As Size = New Size(xSize, ySize)
			imgVIPicture.ClientSize = clientSize
			Me.imgVIPicture.Image = Me.MyImage
		End Sub

		Private Sub imgVIPicture_MouseMove(sender As Object, e As MouseEventArgs)
			If(e.X >= 50 And e.X <= 136 And (e.Y >= 34 And e.Y <= 127)) Or (e.X >= 125 And e.X <= 165 And (e.Y >= 27 And e.Y <= 65)) Then
				Me.VIToolTip1.SetToolTip(Me.imgVIPicture, "Pumping Unit")
			ElseIf e.X >= 163 And e.X <= 175 And (e.Y >= 135 And e.Y <= 275) Then
				Me.VIToolTip1.SetToolTip(Me.imgVIPicture, "Rod String")
			ElseIf(e.X >= 176 And e.X <= 183 And (e.Y >= 134 And e.Y <= 294)) Or (e.X >= 150 And e.X <= 161 And (e.Y >= 134 And e.Y <= 294)) Then
				Me.VIToolTip1.SetToolTip(Me.imgVIPicture, "Tubing and Casing")
			ElseIf e.X >= 135 And e.X <= 200 And (e.Y >= 113 And e.Y <= 133) Then
				Me.VIToolTip1.SetToolTip(Me.imgVIPicture, "Well Information")
			ElseIf e.X >= 154 And e.X <= 167 And (e.Y >= 279 And e.Y <= 367) Then
				Me.VIToolTip1.SetToolTip(Me.imgVIPicture, "Pump")
			ElseIf(e.X >= 15 And e.X <= 142 And (e.Y >= 300 And e.Y <= 350)) Or (e.X >= 175 And e.X <= 200 And (e.Y >= 300 And e.Y <= 380)) Then
				Me.VIToolTip1.SetToolTip(Me.imgVIPicture, "Production")
			ElseIf e.X >= 10 And e.X <= 50 And (e.Y >= 75 And e.Y <= 130) Then
				Me.VIToolTip1.SetToolTip(Me.imgVIPicture, "Primer Mover")
			ElseIf RSWIN_DESC.bRodStarD And ((e.X >= 141 And e.X <= 143 And (e.Y >= 135 And e.Y <= 329)) Or (e.X >= 174 And e.X <= 179 And (e.Y >= 135 And e.Y <= 329))) Then
				Me.VIToolTip1.SetToolTip(Me.imgVIPicture, "Deviation Profile")
			Else
				Me.VIToolTip1.SetToolTip(Me.imgVIPicture, "")
			End If
		End Sub

		Private Sub imgVIPicture_MouseDown(sender As Object, e As MouseEventArgs)
			Me.MyParentFrm = New RODSTAR()
			Me.MyParentFrm = CType(Me.ParentForm, RODSTAR)
			If Not Me.MyParentFrm.ValidateActiveMDIChild(RSWIN_DESC.sCurrentFormName) Then
				Return
			End If
			Dim toolTip As String = Me.VIToolTip1.GetToolTip(Me.imgVIPicture)
			Me.VIToolTip1.SetToolTip(Me.imgVIPicture, "")
			If e.Button = MouseButtons.Right Then
				If(e.X >= 50 And e.X <= 136 And (e.Y >= 34 And e.Y <= 127)) Or (e.X >= 125 And e.X <= 165 And (e.Y >= 27 And e.Y <= 65)) Then
					Me.VIToolTip1.SetToolTip(Me.imgVIPicture, "Pumping Unit")
					Me.CreateContextMenuPUData()
				ElseIf e.X >= 163 And e.X <= 175 And (e.Y >= 135 And e.Y <= 275) Then
					Me.CreateContextMenuRSInput()
				ElseIf(e.X >= 176 And e.X <= 183 And (e.Y >= 134 And e.Y <= 294)) Or (e.X >= 150 And e.X <= 161 And (e.Y >= 134 And e.Y <= 294)) Then
					Me.CreateContextMenuTubingAndCasing()
				ElseIf e.X >= 135 And e.X <= 200 And (e.Y >= 113 And e.Y <= 133) Then
					Me.CreateContextMenuWellInfo()
				ElseIf e.X >= 154 And e.X <= 167 And (e.Y >= 279 And e.Y <= 367) Then
					Me.CreateContextMenuPump()
				ElseIf(e.X >= 15 And e.X <= 142 And (e.Y >= 300 And e.Y <= 350)) Or (e.X >= 175 And e.X <= 200 And (e.Y >= 300 And e.Y <= 380)) Then
					Me.CreateContextMenuProdInfo()
				ElseIf e.X >= 10 And e.X <= 50 And (e.Y >= 75 And e.Y <= 130) Then
					Me.CreateContextMenuMotorData()
				ElseIf RSWIN_DESC.bRodStarD And ((e.X >= 141 And e.X <= 143 And (e.Y >= 135 And e.Y <= 329)) Or (e.X >= 174 And e.X <= 179 And (e.Y >= 135 And e.Y <= 329))) Then
					Me.CreateContextMenuDeviationProfile()
				Else
					Me.VIToolTip1.SetToolTip(Me.imgVIPicture, "")
				End If
			ElseIf e.Button = MouseButtons.Left Then
				RSWIN_DESC.ScrnNum = 0
				If Operators.CompareString(toolTip.Trim(), "Pumping Unit", False) = 0 Then
					If RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru Then
						RSWIN_DESC.ScrnNum = 0
					Else
						RSWIN_DESC.ScrnNum = 6
					End If
				ElseIf Operators.CompareString(toolTip.Trim(), "Rod String", False) = 0 Then
					If RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru Then
						RSWIN_DESC.ScrnNum = 0
					Else
						RSWIN_DESC.ScrnNum = 4
					End If
				ElseIf Operators.CompareString(toolTip.Trim(), "Well Information", False) = 0 Then
					RSWIN_DESC.ScrnNum = 1
				ElseIf Operators.CompareString(toolTip.Trim(), "Pump", False) = 0 Or Operators.CompareString(toolTip.Trim(), "Tubing and Casing", False) = 0 Then
					RSWIN_DESC.ScrnNum = 3
				ElseIf Operators.CompareString(toolTip.Trim(), "Production", False) = 0 Then
					RSWIN_DESC.ScrnNum = 2
				ElseIf Operators.CompareString(toolTip.Trim(), "Primer Mover", False) = 0 Then
					RSWIN_DESC.ScrnNum = 7
				ElseIf RSWIN_DESC.bRodStarD And Operators.CompareString(toolTip.Trim(), "Deviation Profile", False) = 0 Then
					RSWIN_DESC.ScrnNum = 5
				End If
				If RSWIN_DESC.ScrnNum <> 0 Then
					Me.sTabName = ""
					Me.sControlName = ""
					Me.DisplayForm()
				End If
			End If
		End Sub

		Private Sub VisInputMouseHandler(sender As Object, e As MouseEventArgs)
			If e.Button = MouseButtons.Left Then
			End If
		End Sub

		Public Function ChildFormExists(sChildFormName As String) As Boolean
			Dim result As Boolean = False
			For Each form As Form In Me.ParentForm.MdiChildren
				If Operators.CompareString(form.Name, sChildFormName, False) = 0 Then
					result = True
					Exit For
				End If
			Next
			Return result
		End Function

		Private Sub VisInput_Load(sender As Object, e As EventArgs)
			Me.SFList.Clear()
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
			If RSWIN_DESC.bIntVersion AndAlso RSWIN_DESC.bWriteResXFile Then
				Util.OpenResourceWriter(Me.Name)
				Me.CreateContextMenuWellInfo()
				Me.WriteContextMenu("WellInfo", Me.VIContextMenu1)
				Me.CreateContextMenuProdInfo()
				Me.WriteContextMenu("ProdInfo", Me.VIContextMenu1)
				Me.CreateContextMenuPTInfo()
				Me.WriteContextMenu("PTInfo", Me.VIContextMenu1)
				Me.CreateContextMenuTubingAndCasing()
				Me.WriteContextMenu("TubingAndCasing", Me.VIContextMenu1)
				Me.CreateContextMenuPUData()
				Me.WriteContextMenu("PUData", Me.VIContextMenu1)
				Me.CreateContextMenuRSInput()
				Me.WriteContextMenu("RSInput", Me.VIContextMenu1)
				Me.CreateContextMenuMotorData()
				Me.WriteContextMenu("MotorData", Me.VIContextMenu1)
				Util.CloseResourceWriter()
			End If
			Me.ResetClock()
		End Sub

		Private Sub Label_Click(sender As Object, e As EventArgs)
		End Sub

		Private Sub cmdSelInput_Click(sender As Object, e As EventArgs)
			Me.MyParentFrm = New RODSTAR()
			Me.MyParentFrm = CType(Me.ParentForm, RODSTAR)
			Me.MyParentFrm.AddDlgSelectInput(True, False)
		End Sub

		Private Sub VIContextMenu1_Clicked(sender As Object, e As EventArgs)
			Dim menuItem As MenuItem = CType(sender, MenuItem)
			Me.sControlName = ""
			Dim num As Integer = 0
			Dim num2 As Integer = Me.VIContextMenu1.MenuItems.Count - 1
			For i As Integer = num To num2
				If menuItem Is Me.VIContextMenu1.MenuItems(i) Then
					If RSWIN_DESC.ScrnNum = -1 Then
						Dim text As String = menuItem.Text
						If Operators.CompareString(text, "     Casing pressure", False) = 0 OrElse Operators.CompareString(text, "     Tubing pressure", False) = 0 Then
							RSWIN_DESC.ScrnNum = 1
						Else
							If Operators.CompareString(text, "     Rod-tubing friction", False) <> 0 Then
								If Operators.CompareString(text, "     Tubing anchor depth", False) <> 0 Then
									If Operators.CompareString(text, "     Tubing size", False) <> 0 Then
										GoTo IL_B3
									End If
								End If
							End If
							RSWIN_DESC.ScrnNum = 3
						End If
					End If
					Try
						IL_B3:
						For Each obj As Object In Me.myAL
							Dim cMenu As cMenu = CType(obj, cMenu)
							If Operators.CompareString(menuItem.Text, cMenu.MenuDisplayName, False) = 0 Then
								RSWIN_DESC.FldNum = Me.myAL.IndexOf(cMenu)
								Me.sControlName = cMenu.ControlName
								Me.sTabName = cMenu.TabName
								Me.GetScrnNum(Me.sControlName, RSWIN_DESC.ScrnNum)
							End If
						Next
					Finally
						Dim enumerator As IEnumerator
						If TypeOf enumerator Is IDisposable Then
							TryCast(enumerator, IDisposable).Dispose()
						End If
					End Try
					RSWIN_DESC.FldNum = i
				End If
			Next
			If RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru And RSWIN_DESC.ScrnNum = 6 And RSWIN_DESC.ScrnNum = 4 Then
				RSWIN_DESC.ScrnNum = 0
				Return
			End If
			Me.DisplayForm()
		End Sub

		Private Sub DisplayForm()
			If Not RSWIN_DESC.bRodStarD AndAlso (RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru) AndAlso (RSWIN_DESC.ScrnNum <> 1 And RSWIN_DESC.ScrnNum <> 2) Then
				MessageBox.Show("While in AI Mode only  Well Info and Production Info data entry screens are required and accessible.")
				Return
			End If
			Dim frmName As String
			Select Case RSWIN_DESC.ScrnNum
				Case 1
					frmName = "WellInfo"
					Me.sTabName = ""
				Case 2
					frmName = "ProdInfo"
					Me.sTabName = ""
				Case 3
					frmName = "PTInfo"
					Me.sTabName = ""
				Case 4
					frmName = "RSInput"
					Me.sTabName = ""
				Case 5
					frmName = "DeviationProfile"
				Case 6
					frmName = "PUData"
					Me.sTabName = ""
				Case 7
					frmName = "MotorData"
					Me.sTabName = ""
			End Select
			Me.MyParentFrm = New RODSTAR()
			Me.MyParentFrm = CType(Me.ParentForm, RODSTAR)
			Me.MyParentFrm.DisplayChildFormAndControl(frmName, Me.sControlName, Me.sTabName)
			If Operators.CompareString(RSWIN_DESC.HelpNameSpace, "", False) <> 0 Or RSWIN_DESC.HelpNameSpace <> Nothing Then
				Me.HelpProvider1.HelpNamespace = RSWIN_DESC.HelpNameSpace
			End If
		End Sub

		Private Sub AddContextItem(sLabel As String, nItem As Integer, Optional sControlName As String = "", Optional nSN As Integer = 0, Optional sTabName As String = "")
			' The following expression was wrapped in a checked-statement
			If nItem = -1 Then
				nItem = 0
			Else
				nItem += 1
			End If
			If nSN = 0 Then
				nSN = RSWIN_DESC.ScrnNum
			End If
			Me.VIContextMenu1.MenuItems.Add(New MenuItem(sLabel, AddressOf Me.VIContextMenu1_Clicked))
			If Operators.CompareString(sControlName, "", False) <> 0 Then
				If Operators.CompareString(sTabName, "", False) = 0 Then
					Me.myAL.Add(New cMenu(sLabel, sControlName, ""))
				Else
					Me.myAL.Add(New cMenu(sLabel, sControlName, sTabName))
				End If
				Try
					Me.SFList.Add(sControlName, nSN.ToString())
				Catch ex As Exception
				End Try
			End If
		End Sub

		Public Sub CreateContextMenuMotorData()
			Me.myAL.Clear()
			Me.VIContextMenu1.MenuItems.Clear()
			Me.AddContextItem("     Electricity cost", 0, "txtElectricityCost", 7, "")
			Me.AddContextItem("     Motor size", 1, "cboMotorSize", 7, "")
			Me.AddContextItem("     Motor speed variation", 2, "chkIncludeMotorSPV", 7, "")
			Me.AddContextItem("     Motor type", 3, "cboMotorType", 7, "")
			If RSWIN_DESC.rst.PowerMeterType = 1S Then
				Me.AddContextItem("     Power meter type ", 4, "optPowerMeterType_1", 7, "")
			Else
				Me.AddContextItem("     Power meter type ", 4, "optPowerMeterType_2", 7, "")
			End If
			Me.AddContextItem("     Pumping speed/Target Production", 1, "txtSPMBFPD", 2, "")
			If Operators.ConditionalCompareObjectGreater(Motor.GetMotorInfo(6), 1, False) Then
				Me.AddContextItem("     Motor setting", 5, "cboMotorSetting", 7, "")
				Return
			End If
		End Sub

		Public Sub CreateContextMenuProdInfo()
			Me.myAL.Clear()
			Me.VIContextMenu1.MenuItems.Clear()
			Me.AddContextItem("     Bubble point pressure", 5, "txtBubblePoint", 2, "")
			If RSWIN_DESC.rst.giFluidLevelSource <> 2S Then
				Me.AddContextItem("     Fluid level/pump intake pressure", 0, "txtFLPIP", 2, "")
			End If
			Me.AddContextItem("     Gross production", 2, "txtGrossProduction", 2, "")
			Me.AddContextItem("     Mid-perf. depth", 3, "txtMidPerfDepth", 2, "")
			If RSWIN_DESC.rst.giFluidLevelSource = 2S Then
				Me.AddContextItem("     Pump intake pressure/fluid level", 0, "txtFLPIP", 2, "")
			End If
			Me.AddContextItem("     Pumping speed/Target Production", 1, "txtSPMBFPD", 2, "")
			Me.AddContextItem("     Static bottom hole pressure", 4, "txtStaticBHPressure", 2, "")
		End Sub

		Public Sub CreateContextMenuPTInfo()
			Me.myAL.Clear()
			Me.VIContextMenu1.MenuItems.Clear()
			Me.AddContextItem("     Casing pressure", 9, "txtCasingPressure", 1, "")
			Me.AddContextItem("     Plunger size", 3, "cboPlungerSize", 3, "")
			Me.AddContextItem("     Pump depth", 7, "txtPumpDepth", 1, "")
			Me.AddContextItem("     Pump type", 4, "optPumpType_1", 3, "")
			Me.AddContextItem("     Rod-tubing friction", 1, "txtFriction", 3, "")
			Me.AddContextItem("     Tubing anchor depth", 2, "txtTubingAnchorDepth", 3, "")
			Me.AddContextItem("     Tubing pressure", 8, "txtTubingPressure", 1, "")
			Me.AddContextItem("     Tubing size", 0, "cboTubingOD", 3, "")
		End Sub

		Public Sub CreateContextMenuPump()
			Me.myAL.Clear()
			Me.VIContextMenu1.MenuItems.Clear()
			Me.AddContextItem("     Fluid inertia effects", 0, "chkIncludeFluidInertia", 3, "")
			Me.AddContextItem("     Fluid compressibility index", 1, "txtCompressibilityIndex", 3, "")
			Me.AddContextItem("     Plunger size", 2, "cboPlungerSize", 3, "")
			Me.AddContextItem("     Pump condition", 3, "_optPumpCondition_1", 1, "")
			Me.AddContextItem("     Pump depth", 4, "txtPumpDepth", 1, "")
			Me.AddContextItem("     Pump efficiency", 5, "txtPumpEfficiency", 1, "")
			Me.AddContextItem("     Pump fillage", 6, "txtPumpFillage", 1, "")
			Me.AddContextItem("     Pump type", 7, "optPumpType_1", 3, "")
		End Sub

		Public Sub CreateContextMenuTubingAndCasing()
			Me.myAL.Clear()
			Me.VIContextMenu1.MenuItems.Clear()
			Me.AddContextItem("     Casing pressure", 9, "txtCasingPressure", 1, "")
			Me.AddContextItem("     Rod-tubing friction", 1, "txtFriction", 3, "")
			Me.AddContextItem("     Tubing anchor depth", 2, "txtTubingAnchorDepth", 3, "")
			Me.AddContextItem("     Tubing pressure", 8, "txtTubingPressure", 1, "")
			Me.AddContextItem("     Tubing size", 0, "cboTubingOD", 3, "")
		End Sub

		Public Sub CreateContextMenuPUData()
			Me.myAL.Clear()
			Me.VIContextMenu1.MenuItems.Clear()
			Me.AddContextItem("     Crank hole number", 4, "cboCrankHole", 6, "")
			Me.AddContextItem("     Crank rotation", 3, "cboCrankRotation", 6, "")
			Me.AddContextItem("     Maximum counterbalance moment", 6, "txtCounterbalance", 6, "")
			Me.AddContextItem("     Pumping unit", 1, "lvwUnitList", 6, "")
			If RSWIN_DESC.rst.IDEntered <> 0S Then
				Me.AddContextItem("     Pumping unit ID", 2, "txtUnitID", 6, "")
			End If
			Me.AddContextItem("     Pumping unit manufacturer", 0, "cboManufMenu", 6, "")
			Me.AddContextItem("     SPM/Target Production", 1, "txtSPMBFPD", 2, "")
			Me.AddContextItem("     Structural unbalance", 5, "txtUnbalance", 6, "")
		End Sub

		Public Sub CreateContextMenuRSInput()
			Me.myAL.Clear()
			Me.VIContextMenu1.MenuItems.Clear()
			Me.AddContextItem("     Additional rod costs", 0, "txtRSExtraCost", 4, "")
			Me.AddContextItem("     Rod Cost description", 1, "txtRSExtraCostLabel", 4, "")
			Me.AddContextItem("     Rod string", 3, "ulgTapers", 4, "")
			Me.AddContextItem("     Service factor", 2, "txtServiceFactor", 4, "")
		End Sub

		Public Sub CreateContextMenuDeviationProfile()
			Me.myAL.Clear()
			Me.VIContextMenu1.MenuItems.Clear()
			Me.AddContextItem("     Deviation Survey Entry", 0, "tabInput", 5, "_tabInput_TabPage0")
			Me.AddContextItem("     Deviation Survey Plot", 1, "tabInput", 5, "_tabInput_TabPage2")
		End Sub

		Public Sub CreateContextMenuWellInfo()
			Me.myAL.Clear()
			Me.VIContextMenu1.MenuItems.Clear()
			Me.AddContextItem("     Casing pressure", 9, "txtCasingPressure", 1, "")
			Me.AddContextItem("     Company name", 0, "txtCompanyName", 1, "")
			Me.AddContextItem("     Comment", 3, "txtComment", 1, "")
			Me.AddContextItem("     Date", 4, "txtUserDate", 1, "")
			Me.AddContextItem("     Fluid specific gravity", 13, "txtFluidSPGR", 1, "")
			Me.AddContextItem("     Oil gravity/density", 12, "txtOilAPI", 1, "")
			Me.AddContextItem("     Pump depth", 7, "txtPumpDepth", 1, "")
			Me.AddContextItem("     Run time", 6, "txtRunTime", 1, "")
			Me.AddContextItem("     Specific gravity (produced fluid)", 13, "txtFluidSPGR", 1, "")
			Me.AddContextItem("     Specific gravity (water)", 11, "txtWaterSPGR", 1, "")
			Me.AddContextItem("     Tubing pressure", 8, "txtTubingPressure", 1, "")
			Me.AddContextItem("     User name", 2, "txtUserName", 1, "")
			Me.AddContextItem("     Water cut", 10, "txtWaterCut", 1, "")
			Me.AddContextItem("     Water specific gravity", 11, "txtWaterSPGR", 1, "")
			Me.AddContextItem("     Well name", 1, "txtWellName", 1, "")
		End Sub

		Public Sub WriteContextMenu(sMenu As String, VIContextMenu1 As ContextMenu)
			' The following expression was wrapped in a checked-statement
			Try
				Dim num As Integer = 0
				Dim num2 As Integer = VIContextMenu1.MenuItems.Count - 1
				For i As Integer = num To num2
					Try
						Me.WriteContextItem(sMenu + "-" + i.ToString(), VIContextMenu1.MenuItems(i).Text)
					Catch ex As Exception
					End Try
				Next
			Catch ex2 As Exception
			End Try
		End Sub

		Public Sub WriteContextMenuProdInfo()
			Me.WriteContextItem(Conversions.ToString(2), "     Bubble point pressure")
			Me.WriteContextItem(Conversions.ToString(3), "     Fluid level/pump intake pressure")
			Me.WriteContextItem(Conversions.ToString(4), "     Gross production")
			Me.WriteContextItem(Conversions.ToString(5), "     Mid-perf. depth")
			Me.WriteContextItem(Conversions.ToString(6), "     Pump intake pressure/fluid level")
			Me.WriteContextItem(Conversions.ToString(7), "     Pumping speed")
			Me.WriteContextItem(Conversions.ToString(8), "     SPM")
			Me.WriteContextItem(Conversions.ToString(9), "     Static bottom hole pressure")
		End Sub

		Public Sub WriteContextMenuPTInfo()
			Me.WriteContextItem(Conversions.ToString(2), "     Casing pressure")
			Me.WriteContextItem(Conversions.ToString(3), "     Plunger size")
			Me.WriteContextItem(Conversions.ToString(4), "     Pump depth")
			Me.WriteContextItem(Conversions.ToString(5), "     Pump type")
			Me.WriteContextItem(Conversions.ToString(6), "     Rod-tubing friction")
			Me.WriteContextItem(Conversions.ToString(7), "     Tubing anchor depth")
			Me.WriteContextItem(Conversions.ToString(8), "     Tubing pressure")
			Me.WriteContextItem(Conversions.ToString(9), "     Tubing size")
		End Sub

		Public Sub WriteContextMenuTubingAndCasing()
			Me.WriteContextItem(Conversions.ToString(2), "     Casing pressure")
			Me.WriteContextItem(Conversions.ToString(3), "     Rod-tubing friction")
			Me.WriteContextItem(Conversions.ToString(4), "     Tubing anchor depth")
			Me.WriteContextItem(Conversions.ToString(5), "     Tubing pressure")
			Me.WriteContextItem(Conversions.ToString(6), "     Tubing size")
		End Sub

		Public Sub WriteContextMenuPUData()
			Me.WriteContextItem(Conversions.ToString(3), "     Crank hole number")
			Me.WriteContextItem(Conversions.ToString(4), "     Crank rotation")
			Me.WriteContextItem(Conversions.ToString(5), "     Maximum counterbalance moment")
			Me.WriteContextItem(Conversions.ToString(6), "     Pumping speed")
			Me.WriteContextItem(Conversions.ToString(7), "     Pumping unit")
			Me.WriteContextItem(Conversions.ToString(8), "     Pumping unit manufacturer")
			Me.WriteContextItem(Conversions.ToString(9), "     Stroke Length")
			Me.WriteContextItem(Conversions.ToString(10), "     Structural unbalance")
			Me.WriteContextItem(Conversions.ToString(11), "     Pumping unit ID")
		End Sub

		Public Sub WriteContextMenuRSInput()
			Me.WriteContextItem(Conversions.ToString(1), "     Additional rod costs")
			Me.WriteContextItem(Conversions.ToString(2), "     Rod Cost description")
			Me.WriteContextItem(Conversions.ToString(3), "     Rod string")
			Me.WriteContextItem(Conversions.ToString(4), "     Service factor")
		End Sub

		Public Sub WriteContextMenuWellInfo()
			Me.WriteContextItem(Conversions.ToString(2), "     Company name")
			Me.WriteContextItem(Conversions.ToString(3), "     Well name")
			Me.WriteContextItem(Conversions.ToString(4), "     User name")
			Me.WriteContextItem(Conversions.ToString(5), "     Comment")
			Me.WriteContextItem(Conversions.ToString(6), "     Date")
			Me.WriteContextItem(Conversions.ToString(8), "     Pump depth")
			Me.WriteContextItem(Conversions.ToString(9), "     Run time")
			Me.WriteContextItem(Conversions.ToString(10), "     Tubing pressure")
			Me.WriteContextItem(Conversions.ToString(11), "     Casing pressure")
			Me.WriteContextItem(Conversions.ToString(12), "     Water cut")
			Me.WriteContextItem(Conversions.ToString(13), "     Specific gravity (water)")
			Me.WriteContextItem(Conversions.ToString(14), "     Oil gravity/density")
			Me.WriteContextItem(Conversions.ToString(15), "     Fluid specific gravity")
			Me.WriteContextItem(Conversions.ToString(16), "     Specific gravity (produced fluid)")
		End Sub

		Private Sub WriteContextItem(sKey As String, sValue As String)
			RSWIN_DESC.RwX.AddResource(sKey, sValue)
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

		Private Const POPUP_NONE As Integer = -1

		Private Const POPUP_WELLINFO As Integer = 0

		Private Const POPUP_PRODINFO As Integer = 1

		Private Const POPUP_PTINFO As Integer = 2

		Private Const POPUP_RSINPUT As Integer = 3

		Private Const POPUP_PUDATA As Integer = 4

		Private Const POPUP_MOTORDATA As Integer = 5

		Private Const POPUP_TUBING As Integer = 6

		Private CurrentContextMenu As String

		Private hctlLabel As Integer()

		Private iActivePopup As Integer

		Private myAL As ArrayList

		Private sControlName As String

		Private sTabName As String

		Private MyParentFrm As RODSTAR

		<AccessedThroughProperty("VIImageList1")>
		Private _VIImageList1 As ImageList

		<AccessedThroughProperty("VIContextMenu1")>
		Private _VIContextMenu1 As ContextMenu

		<AccessedThroughProperty("VIPanel2")>
		Private _VIPanel2 As Panel

		<AccessedThroughProperty("VIPanel1")>
		Private _VIPanel1 As Panel

		<AccessedThroughProperty("imgVIPicture")>
		Private _imgVIPicture As PictureBox

		<AccessedThroughProperty("cmdVISelInput")>
		Private _cmdVISelInput As Button

		<AccessedThroughProperty("VILabel")>
		Private _VILabel As Label

		<AccessedThroughProperty("VIToolTip1")>
		Private _VIToolTip1 As ToolTip

		<AccessedThroughProperty("HelpProvider1")>
		Private _HelpProvider1 As HelpProvider

		<AccessedThroughProperty("Panel1")>
		Private _Panel1 As Panel

		Private Shared m_vb6FormDefInstance As VisInput

		Private Shared m_InitializingDefInstance As Boolean

		Private SFList As Hashtable

		Private myKeyValueHT As Hashtable

		Private MyImage As Bitmap
	End Class
End Namespace
