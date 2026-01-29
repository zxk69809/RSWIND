Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.Compatibility.VB6
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	Friend Partial Class Clock
		Inherits Form

		Public Sub New()
			AddHandler MyBase.Activated, AddressOf Me.Clock_Activated
			AddHandler MyBase.Leave, AddressOf Me.Clock_Leave
			AddHandler MyBase.Load, AddressOf Me.Clock_Load
			AddHandler MyBase.Closing, AddressOf Me.Clock_Closing
			AddHandler MyBase.Resize, AddressOf Me.Clock_Resize
			Me.bCheck = True
			If Clock.m_vb6FormDefInstance Is Nothing Then
				If Clock.m_InitializingDefInstance Then
					Clock.m_vb6FormDefInstance = Me
				Else
					Try
						If Assembly.GetExecutingAssembly().EntryPoint.DeclaringType Is Me.[GetType]() Then
							Clock.m_vb6FormDefInstance = Me
						End If
					Catch ex As Exception
					End Try
				End If
			End If
			Me.InitializeComponent()
		End Sub

		Public Overridable Property cmdCancel As Button
			Get
				Return Me._cmdCancel
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.cmdCancel_Click
				If Me._cmdCancel IsNot Nothing Then
					RemoveHandler Me._cmdCancel.Click, value2
				End If
				Me._cmdCancel = value
				If Me._cmdCancel IsNot Nothing Then
					AddHandler Me._cmdCancel.Click, value2
				End If
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

		Public Overridable Property txtCode As TextBox
			Get
				Return Me._txtCode
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtCode_Leave
				Dim value3 As EventHandler = AddressOf Me.txtCode_Enter
				If Me._txtCode IsNot Nothing Then
					RemoveHandler Me._txtCode.Leave, value2
					RemoveHandler Me._txtCode.Enter, value3
				End If
				Me._txtCode = value
				If Me._txtCode IsNot Nothing Then
					AddHandler Me._txtCode.Leave, value2
					AddHandler Me._txtCode.Enter, value3
				End If
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

		Public Overridable Property tmrBatch As Timer
			Get
				Return Me._tmrBatch
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Dim value2 As EventHandler = AddressOf Me.tmrBatch_Tick
				If Me._tmrBatch IsNot Nothing Then
					RemoveHandler Me._tmrBatch.Tick, value2
				End If
				Me._tmrBatch = value
				If Me._tmrBatch IsNot Nothing Then
					AddHandler Me._tmrBatch.Tick, value2
				End If
			End Set
		End Property

		Public Overridable Property tmrCode As Timer
			Get
				Return Me._tmrCode
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Dim value2 As EventHandler = AddressOf Me.tmrCode_Tick
				If Me._tmrCode IsNot Nothing Then
					RemoveHandler Me._tmrCode.Tick, value2
				End If
				Me._tmrCode = value
				If Me._tmrCode IsNot Nothing Then
					AddHandler Me._tmrCode.Tick, value2
				End If
			End Set
		End Property

		Public Overridable Property _Label_0 As Label
			Get
				Return Me.__Label_0
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_0 = value
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

		Friend Overridable Property lblCancel As Label
			Get
				Return Me._lblCancel
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblCancel = value
			End Set
		End Property

		Public Shared Property DefInstance As Clock
			Get
				If Clock.m_vb6FormDefInstance Is Nothing OrElse Clock.m_vb6FormDefInstance.IsDisposed Then
					Clock.m_InitializingDefInstance = True
					Clock.m_vb6FormDefInstance = New Clock()
					Clock.m_InitializingDefInstance = False
				End If
				Return Clock.m_vb6FormDefInstance
			End Get
			Set(value As Clock)
				Clock.m_vb6FormDefInstance = value
			End Set
		End Property

		Public Property StartTime As DateTime
			Get
				Return Me.m_StartTime
			End Get
			Set(value As DateTime)
				Me.m_StartTime = value
			End Set
		End Property

		Public Property dwInterval As Integer
			Get
				Return Me.m_dwInterval
			End Get
			Set(value As Integer)
				Me.m_dwInterval = value
				Me.tmrBatch.Interval = Me.m_dwInterval
			End Set
		End Property

		Public Sub EnableBatchTimer()
			Me.tmrBatch.Enabled = True
		End Sub

		Private Sub CancelABM()
			Me.tmrCode.Enabled = False
			RSWIN_DESC.rst.gbAutomatic = False
			Me.Hide()
			RSWIN_DESC.frmMain.Show()
			RSWIN_DESC.frmMain.Activate()
			RSWIN_DESC.frmMain.tbrToolBar2.Buttons(8).Enabled = True
		End Sub

		Private Sub CheckABM()
			If Me.Visible And Me.bCheck Then
				Me.Hide()
				Me.tmrBatch.Enabled = False
				Dim dialogResult As DialogResult = MessageBox.Show("Do you want to cancel automatic batch mode?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
				If dialogResult = DialogResult.Yes Then
					Me.CancelABM()
				Else
					Me.ResumeABM()
				End If
				Return
			End If
		End Sub

		Private Sub cmdCancel_Click(eventSender As Object, eventArgs As EventArgs)
			Me.ResumeABM()
		End Sub

		Private Sub cmdOK_Click(eventSender As Object, eventArgs As EventArgs)
			Me.CancelABM()
		End Sub

		Private Sub Clock_Load(eventSender As Object, eventArgs As EventArgs)
			If RSWIN_DESC.bRodStarD Then
				Me.Text = RSWIN_DESC.sProgramNameD + " (Automatic Batch Mode)"
			Else
				Me.Text = RSWIN_DESC.sProgramNameV + " (Automatic Batch Mode)"
			End If
			Dim form As Form = Me
			Util.CenterForm(form, Nothing, 0, False)
			Dim text As String = Strings.Space(255)
			Dim text2 As String = "BeginTime"
			Dim sNull As String = RSWIN_DESC.sNull
			Dim regProfileString As Short = CShort(RSWIN.GetRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, sNull, text, False))
			RSWIN_DESC.sNull = sNull
			Dim length As Short = regProfileString
			RSWIN_DESC.sNull = ""
			text = Strings.Trim(text.Substring(0, CInt(length)))
			Me.m_StartTime = Convert.ToDateTime(text)
			If RSWIN_DESC.bRodStarD Then
				Me.Icon = RSWIN_DESC.RodstarD_Icon
				Return
			End If
			If RSWIN_DESC.bExpert Then
				Me.Icon = RSWIN_DESC.XRODV_Icon
				Return
			End If
			Me.Icon = RSWIN_DESC.RodstarV_Icon
		End Sub

		Private Sub Clock_Closing(eventSender As Object, eventArgs As CancelEventArgs)
			Dim num As Short = If((-If((eventArgs.Cancel > False), 1S, 0S)), 1S, 0S)
			eventArgs.Cancel = (num <> 0S)
		End Sub

		Private Sub Clock_Resize(eventSender As Object, eventArgs As EventArgs)
			Select Case Me.WindowState
				Case FormWindowState.Normal, FormWindowState.Maximized
					Me.CheckABM()
					Me.WindowState = FormWindowState.Minimized
			End Select
		End Sub

		Private Sub ResumeABM()
			Me.WindowState = FormWindowState.Minimized
			Me.Show()
			Me.tmrBatch.Enabled = True
		End Sub

		Private Sub tmrBatch_Tick(eventSender As Object, eventArgs As EventArgs)
			Dim text As String = Strings.Space(255)
			Dim text2 As String = "BeginTime"
			Dim sNull As String = RSWIN_DESC.sNull
			Dim regProfileString As Short = CShort(RSWIN.GetRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, sNull, text, False))
			RSWIN_DESC.sNull = sNull
			Dim length As Short = regProfileString
			text = Strings.Trim(text.Substring(0, CInt(length)))
			Me.m_StartTime = Convert.ToDateTime(text)
			Dim num As Short
			If DateAndTime.Hour(DateAndTime.Now) = DateAndTime.Hour(Me.m_StartTime) And DateAndTime.Minute(DateAndTime.Now) = DateAndTime.Minute(Me.m_StartTime) Then
				num = -1S
			End If
			If num <> 0S Then
				Me.tmrBatch.Enabled = False
				Me.StartAutomaticBatchRun()
				RSWIN_DESC.SETUP_ExitIfIdle = 0S
				Me.tmrBatch.Enabled = True
			End If
		End Sub

		Private Sub StartAutomaticBatchRun()
			Dim obj As Object = New String(" "c, 255)
			Dim libWrap As LibWrap = New LibWrap()
			Try
				If RSWIN_DESC.bRodStarD Then
					Me.Text = RSWIN_DESC.sProgramNameD + " (Automatic Batch Mode)"
				Else
					Me.Text = RSWIN_DESC.sProgramNameV + " (Automatic Batch Mode)"
				End If
				Util.CreateBatchApplicationLog()
				Dim text As String = "RODSTARDirectory"
				Dim text2 As String = ""
				Dim text3 As String = Conversions.ToString(obj)
				Dim regProfileString As Integer = RSWIN.GetRegProfileString(RSWIN_DESC.SECT_RSWIN, text, text2, text3, False)
				obj = text3
				Dim num As Integer = regProfileString
				Dim obj2 As Object = obj
				Dim type As Type = Nothing
				Dim text4 As String = "SubString"
				Dim array As Object() = New Object() { 0, num }
				Dim array2 As Object() = array
				Dim array3 As String() = Nothing
				Dim array4 As Type() = Nothing
				Dim array5 As Boolean() = New Boolean() { False, True }
				Dim obj3 As Object = NewLateBinding.LateGet(obj2, type, text4, array2, array3, array4, array5)
				If array5(1) Then
					num = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array(1)), GetType(Integer)))
				End If
				RSWIN_DESC.SETUP_RSWINDIR = Strings.Trim(Conversions.ToString(obj3))
				text3 = "DynoDirectory"
				text2 = ""
				text = Conversions.ToString(obj)
				RSWIN.GetRegProfileString(RSWIN_DESC.SECT_RSWIN, text3, text2, text, False)
				obj = text
				text3 = "WK1Directory"
				text2 = ""
				text = Conversions.ToString(obj)
				Dim regProfileString2 As Integer = RSWIN.GetRegProfileString(RSWIN_DESC.SECT_RSWIN, text3, text2, text, False)
				obj = text
				num = regProfileString2
				Dim obj4 As Object = obj
				Dim type2 As Type = Nothing
				Dim text5 As String = "SubString"
				Dim array6 As Object() = New Object() { 0, num }
				Dim array7 As Object() = array6
				Dim array8 As String() = Nothing
				Dim array9 As Type() = Nothing
				array5 = New Boolean() { False, True }
				Dim obj5 As Object = NewLateBinding.LateGet(obj4, type2, text5, array7, array8, array9, array5)
				If array5(1) Then
					num = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(1)), GetType(Integer)))
				End If
				RSWIN_DESC.SETUP_WK1Dir = Strings.Trim(Conversions.ToString(obj5))
				Dim text6 As String = Conversions.ToString(Operators.ConcatenateObject(RSWIN_DESC.SETUP_RSWINDIR, Interaction.IIf(Operators.CompareString(RSWIN_DESC.SETUP_RSWINDIR.Substring(RSWIN_DESC.SETUP_RSWINDIR.Length - 1, 1), "\", False) = 0, "", "\")))
				Dim files As String() = Directory.GetFiles(text6, "*.*")
				Dim array10 As String() = New String(files.Length - 1 + 1 - 1) {}
				Dim obj6 As Object = 0
				Dim obj7 As Object
				Dim obj8 As Object
				If ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj7, 0, files.Length - 1, 1, obj8, obj7) Then
					Do
						If Me.CheckFileType(files(Conversions.ToInteger(obj7))) Then
							array10(Conversions.ToInteger(obj6)) = files(Conversions.ToInteger(obj7))
							obj6 = Operators.AddObject(obj6, 1)
						End If
					Loop While ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj7, obj8, obj7)
				End If
				array10 = CType(Utils.CopyArray(CType(array10, Array), New String(Conversions.ToInteger(obj6) + 1 - 1) {}), String())
				RSWIN_DESC.mrgBatchFileList = New String(100) {}
				Dim array11 As String() = New String(100) {}
				Try
					obj6 = 0
					Dim obj9 As Object
					If ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj7, 0, Information.UBound(array10, 1), 1, obj9, obj7) Then
						Do
							If Me.CheckFileType(array10(Conversions.ToInteger(obj7))) Then
								array11(Conversions.ToInteger(obj6)) = array10(Conversions.ToInteger(obj7)).Substring(Strings.Len(text6))
								RSWIN_DESC.mrgBatchFileList(Conversions.ToInteger(obj6)) = array10(Conversions.ToInteger(obj7))
								obj6 = Operators.AddObject(obj6, 1)
							End If
						Loop While ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj7, obj9, obj7)
					End If
				Catch ex As Exception
				End Try
				RSWIN_DESC.mcBatchFiles = Conversions.ToInteger(obj6)
				If RSWIN_DESC.rst.gbPrintBatchLog Then
					RSWIN_DESC.msBatchLogFile = Interaction.Environ("TEMP")
					If Not LikeOperator.LikeString(RSWIN_DESC.msBatchLogFile, "*\", CompareMethod.Binary) Then
						RSWIN_DESC.msBatchLogFile += "\"
					End If
					RSWIN_DESC.msBatchLogFile += RSWIN_DESC.BATCHLOGNAME
				Else
					RSWIN_DESC.msBatchLogFile = ""
				End If
				If Strings.Len(RSWIN_DESC.msBatchLogFile) > 0 Then
					If FILEUTIL.FileExists(RSWIN_DESC.msBatchLogFile) Then
						Try
							FileSystem.FileClose(New Integer() { RSWIN_DESC.mhBatchLog })
						Catch ex2 As Exception
						End Try
						Try
							FileSystem.Kill(RSWIN_DESC.msBatchLogFile)
						Catch ex3 As Exception
						End Try
					End If
					RSWIN_DESC.mhBatchLog = CInt(FILEIO.OpenTheFile(RSWIN_DESC.msBatchLogFile, 545S, 0S))
				End If
				RSWIN_DESC.miBatchCurFile = 0
				If RSWIN_DESC.mcBatchFiles > 0 Then
					Dim frmMain As RODSTAR = RSWIN_DESC.frmMain
					text3 = ""
					frmMain.BatchProcess(text3)
					Me.Enabled = True
					If Operators.CompareString(RSWIN_DESC.msBatchLogFile, "", False) <> 0 AndAlso FILEUTIL.FileExists(RSWIN_DESC.msBatchLogFile) Then
						FileSystem.FileClose(New Integer() { RSWIN_DESC.mhBatchLog })
						If RSWIN_DESC.rst.gbPrintBatchLog Then
							Batch.PrintAutoBatchLog(RSWIN_DESC.msBatchLogFile)
						End If
						If FileSystem.FileLen(RSWIN_DESC.msBatchLogFile) = 0L Then
							FileSystem.Kill(RSWIN_DESC.msBatchLogFile)
						End If
					End If
				End If
			Catch ex4 As Exception
				Dim sMsg As String = "Error in StartAutomaticBatchRun: " + ex4.Message
				Dim sMsgType As String = ""
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
			End Try
		End Sub

		Private Sub StartGuruBatchRun()
			Dim obj As Object = New String(" "c, 255)
			Dim libWrap As LibWrap = New LibWrap()
			Try
				If RSWIN_DESC.bRodStarD Then
					Me.Text = RSWIN_DESC.sProgramNameD + " (AI Batch Mode)"
				Else
					Me.Text = RSWIN_DESC.sProgramNameV + " (AI Batch Mode)"
				End If
				Dim text As String = "RODSTARDirectory"
				Dim text2 As String = ""
				Dim text3 As String = Conversions.ToString(obj)
				Dim regProfileString As Integer = RSWIN.GetRegProfileString(RSWIN_DESC.SECT_RSWIN, text, text2, text3, False)
				obj = text3
				Dim num As Integer = regProfileString
				Dim obj2 As Object = obj
				Dim type As Type = Nothing
				Dim text4 As String = "SubString"
				Dim array As Object() = New Object() { 0, num }
				Dim array2 As Object() = array
				Dim array3 As String() = Nothing
				Dim array4 As Type() = Nothing
				Dim array5 As Boolean() = New Boolean() { False, True }
				Dim obj3 As Object = NewLateBinding.LateGet(obj2, type, text4, array2, array3, array4, array5)
				If array5(1) Then
					num = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array(1)), GetType(Integer)))
				End If
				RSWIN_DESC.SETUP_RSWINDIR = Strings.Trim(Conversions.ToString(obj3))
				text3 = "DynoDirectory"
				text2 = ""
				text = Conversions.ToString(obj)
				RSWIN.GetRegProfileString(RSWIN_DESC.SECT_RSWIN, text3, text2, text, False)
				obj = text
				text3 = "WK1Directory"
				text2 = ""
				text = Conversions.ToString(obj)
				Dim regProfileString2 As Integer = RSWIN.GetRegProfileString(RSWIN_DESC.SECT_RSWIN, text3, text2, text, False)
				obj = text
				num = regProfileString2
				Dim obj4 As Object = obj
				Dim type2 As Type = Nothing
				Dim text5 As String = "SubString"
				Dim array6 As Object() = New Object() { 0, num }
				Dim array7 As Object() = array6
				Dim array8 As String() = Nothing
				Dim array9 As Type() = Nothing
				array5 = New Boolean() { False, True }
				Dim obj5 As Object = NewLateBinding.LateGet(obj4, type2, text5, array7, array8, array9, array5)
				If array5(1) Then
					num = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(1)), GetType(Integer)))
				End If
				RSWIN_DESC.SETUP_WK1Dir = Strings.Trim(Conversions.ToString(obj5))
				Dim text6 As String = Conversions.ToString(Operators.ConcatenateObject(RSWIN_DESC.SETUP_RSWINDIR, Interaction.IIf(Operators.CompareString(RSWIN_DESC.SETUP_RSWINDIR.Substring(RSWIN_DESC.SETUP_RSWINDIR.Length - 1, 1), "\", False) = 0, "", "\")))
				Dim files As String() = Directory.GetFiles(text6, "*.*")
				Dim array10 As String() = New String(files.Length - 1 + 1 - 1) {}
				Dim obj6 As Object = 0
				Dim obj7 As Object
				Dim obj8 As Object
				If ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj7, 0, files.Length - 1, 1, obj8, obj7) Then
					Do
						If Me.CheckFileType(files(Conversions.ToInteger(obj7))) Then
							array10(Conversions.ToInteger(obj6)) = files(Conversions.ToInteger(obj7))
							obj6 = Operators.AddObject(obj6, 1)
						End If
					Loop While ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj7, obj8, obj7)
				End If
				array10 = CType(Utils.CopyArray(CType(array10, Array), New String(Conversions.ToInteger(obj6) + 1 - 1) {}), String())
				RSWIN_DESC.mrgBatchFileList = New String(100) {}
				Dim array11 As String() = New String(100) {}
				Try
					obj6 = 0
					Dim obj9 As Object
					If ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj7, 0, Information.UBound(array10, 1), 1, obj9, obj7) Then
						Do
							If Me.CheckFileType(array10(Conversions.ToInteger(obj7))) Then
								array11(Conversions.ToInteger(obj6)) = array10(Conversions.ToInteger(obj7)).Substring(Strings.Len(text6))
								RSWIN_DESC.mrgBatchFileList(Conversions.ToInteger(obj6)) = array10(Conversions.ToInteger(obj7))
								obj6 = Operators.AddObject(obj6, 1)
							End If
						Loop While ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj7, obj9, obj7)
					End If
				Catch ex As Exception
				End Try
				RSWIN_DESC.mcBatchFiles = Conversions.ToInteger(obj6)
				If RSWIN_DESC.rst.gbPrintBatchLog Then
					RSWIN_DESC.msBatchLogFile = Interaction.Environ("TEMP")
					If Not LikeOperator.LikeString(RSWIN_DESC.msBatchLogFile, "*\", CompareMethod.Binary) Then
						RSWIN_DESC.msBatchLogFile += "\"
					End If
					RSWIN_DESC.msBatchLogFile += RSWIN_DESC.BATCHLOGNAME
				Else
					RSWIN_DESC.msBatchLogFile = ""
				End If
				If Strings.Len(RSWIN_DESC.msBatchLogFile) > 0 Then
					If FILEUTIL.FileExists(RSWIN_DESC.msBatchLogFile) Then
						Try
							FileSystem.FileClose(New Integer() { RSWIN_DESC.mhBatchLog })
						Catch ex2 As Exception
						End Try
						Try
							FileSystem.Kill(RSWIN_DESC.msBatchLogFile)
						Catch ex3 As Exception
						End Try
					End If
					RSWIN_DESC.mhBatchLog = CInt(FILEIO.OpenTheFile(RSWIN_DESC.msBatchLogFile, 545S, 0S))
				End If
				RSWIN_DESC.miBatchCurFile = 0
				If RSWIN_DESC.mcBatchFiles > 0 Then
					Dim frmMain As RODSTAR = RSWIN_DESC.frmMain
					text3 = ""
					frmMain.BatchProcess(text3)
					Me.Enabled = True
					If Operators.CompareString(RSWIN_DESC.msBatchLogFile, "", False) <> 0 AndAlso FILEUTIL.FileExists(RSWIN_DESC.msBatchLogFile) Then
						FileSystem.FileClose(New Integer() { RSWIN_DESC.mhBatchLog })
						If RSWIN_DESC.rst.gbPrintBatchLog Then
							Batch.PrintAutoBatchLog(RSWIN_DESC.msBatchLogFile)
						End If
						If FileSystem.FileLen(RSWIN_DESC.msBatchLogFile) = 0L Then
							FileSystem.Kill(RSWIN_DESC.msBatchLogFile)
						End If
					End If
				End If
			Catch ex4 As Exception
				Dim sMsg As String = "Error in StartAutomaticBatchRun: " + ex4.Message
				Dim sMsgType As String = ""
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
			End Try
		End Sub

		Private Function CheckFileType(sFileName As String) As Boolean
			Dim result As Boolean = False
			Dim flag As Boolean = True
			If flag = Strings.InStr(sFileName.ToUpper(), ".RSVX", CompareMethod.Binary) > 0 Then
				Dim num As Integer = Strings.InStr(sFileName.ToUpper(), ".RSVX", CompareMethod.Binary)
				If sFileName.Length = num + 4 Then
					result = True
				End If
			ElseIf flag = Strings.InStr(sFileName.ToUpper(), ".RSDX", CompareMethod.Binary) > 0 Then
				Dim num As Integer = Strings.InStr(sFileName.ToUpper(), ".RSDX", CompareMethod.Binary)
				If sFileName.Length = num + 4 Then
					result = True
				End If
			ElseIf flag = Strings.InStr(sFileName.ToUpper(), ".RST", CompareMethod.Binary) > 0 Then
				Dim num As Integer = Strings.InStr(sFileName.ToUpper(), ".RST", CompareMethod.Binary)
				If sFileName.Length = num + 3 Then
					result = True
				End If
			ElseIf flag = Strings.InStr(sFileName.ToUpper(), ".RDG", CompareMethod.Binary) > 0 Then
				Dim num As Integer = Strings.InStr(sFileName.ToUpper(), ".RDG", CompareMethod.Binary)
				If sFileName.Length = num + 3 Then
					result = True
				End If
			ElseIf flag = Strings.InStr(sFileName.ToUpper(), ".XDG", CompareMethod.Binary) > 0 Then
				Dim num As Integer = Strings.InStr(sFileName.ToUpper(), ".XDG", CompareMethod.Binary)
				If sFileName.Length = num + 3 Then
					result = True
				End If
			End If
			Return result
		End Function

		Private Sub tmrCode_Tick(eventSender As Object, eventArgs As EventArgs)
			' The following expression was wrapped in a checked-expression
			Dim value As Short = 1S + Me.tmrCodeCount
			Me.tmrCodeCount = Conversions.ToShort(Convert.ToString(value))
			Select Case value
				Case 3S
					If Strings.Len(Me.txtCode.Text) = 0 Then
						Me.tmrCode.Enabled = False
						Me.ResumeABM()
					End If
				Case 8S
					Me.tmrCode.Enabled = False
					Me.ResumeABM()
			End Select
		End Sub

		Private Sub txtCode_Enter(eventSender As Object, eventArgs As EventArgs)
		End Sub

		Private Sub txtCode_Leave(eventSender As Object, eventArgs As EventArgs)
		End Sub

		Private Sub UnsecureABM()
			Me.tmrBatch.Enabled = False
			Me.tmrCodeCount = Conversions.ToShort("0")
			Me.tmrCode.Enabled = True
			Me.txtCode.Text = RSWIN_DESC.sNull
			Me.txtCode.Focus()
		End Sub

		Public Sub BatchShowInputFile(sInputFile As String)
			If Strings.Len(RSWIN_DESC.msClockCaption) = 0 Then
				RSWIN_DESC.msClockCaption = Me.Text
			End If
			If Strings.Len(sInputFile) = 0 Then
				Me.Text = RSWIN_DESC.msClockCaption
				Return
			End If
			Me.Text = "Processing " + Util.FileName(sInputFile) + ".."
		End Sub

		Public Sub StopAutomaticBatch()
			Me.tmrBatch.Enabled = False
			Me.bCheck = False
			Me.CancelABM()
		End Sub

		Private Sub Clock_Activated(sender As Object, e As EventArgs)
		End Sub

		Private Sub Clock_Leave(sender As Object, e As EventArgs)
		End Sub

		<AccessedThroughProperty("cmdCancel")>
		Private _cmdCancel As Button

		<AccessedThroughProperty("cmdOK")>
		Private _cmdOK As Button

		<AccessedThroughProperty("txtCode")>
		Private _txtCode As TextBox

		<AccessedThroughProperty("_SSPanel_0")>
		Private __SSPanel_0 As Panel

		<AccessedThroughProperty("tmrBatch")>
		Private _tmrBatch As Timer

		<AccessedThroughProperty("tmrCode")>
		Private _tmrCode As Timer

		<AccessedThroughProperty("_Label_0")>
		Private __Label_0 As Label

		<AccessedThroughProperty("Label")>
		Private _Label As LabelArray

		<AccessedThroughProperty("SSPanel")>
		Private _SSPanel As PanelArray

		<AccessedThroughProperty("lblCancel")>
		Private _lblCancel As Label

		Private Shared m_vb6FormDefInstance As Clock

		Private Shared m_InitializingDefInstance As Boolean

		Private m_dwInterval As Integer

		Private tmrCodeCount As Short

		Private bCheck As Boolean

		Private m_StartTime As DateTime
	End Class
End Namespace
