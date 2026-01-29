Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.Compatibility.VB6
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.Win32

Namespace RSWINV3
	Friend Partial Class FAboutSplash
		Inherits Form

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.FAboutSplash_Load
			AddHandler MyBase.Activated, AddressOf Me.FAboutSplash_Activated
			Me.gWarningInfo = Util.AssignValueToConstant("FAboutSplash", "gWarningInfo", " Warning: This computer program is protected by copyright law and international treaties. Unauthorized reproduction of this program, or any portion of it, may result in severe civil and criminal penalties, and will be prosecuted to the maximum extent possible under law.")
			If FAboutSplash.m_vb6FormDefInstance Is Nothing Then
				If FAboutSplash.m_InitializingDefInstance Then
					FAboutSplash.m_vb6FormDefInstance = Me
				Else
					Try
						If Assembly.GetExecutingAssembly().EntryPoint.DeclaringType Is Me.[GetType]() Then
							FAboutSplash.m_vb6FormDefInstance = Me
						End If
					Catch ex As Exception
					End Try
				End If
			End If
			Me.InitializeComponent()
		End Sub

		Public Overridable Property lblUserInfo As Label
			Get
				Return Me._lblUserInfo
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblUserInfo = value
			End Set
		End Property

		Public Overridable Property lblUserName As Label
			Get
				Return Me._lblUserName
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblUserName = value
			End Set
		End Property

		Public Overridable Property Picture1 As Panel
			Get
				Return Me._Picture1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._Picture1 = value
			End Set
		End Property

		Public Overridable Property Timer1 As Timer
			Get
				Return Me._Timer1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Dim value2 As EventHandler = AddressOf Me.Timer1_Tick
				If Me._Timer1 IsNot Nothing Then
					RemoveHandler Me._Timer1.Tick, value2
				End If
				Me._Timer1 = value
				If Me._Timer1 IsNot Nothing Then
					AddHandler Me._Timer1.Tick, value2
				End If
			End Set
		End Property

		Public Overridable Property cmdSysInfo As Button
			Get
				Return Me._cmdSysInfo
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.cmdSysInfo_Click
				If Me._cmdSysInfo IsNot Nothing Then
					RemoveHandler Me._cmdSysInfo.Click, value2
				End If
				Me._cmdSysInfo = value
				If Me._cmdSysInfo IsNot Nothing Then
					AddHandler Me._cmdSysInfo.Click, value2
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

		Public Overridable Property lblCompanyName As Label
			Get
				Return Me._lblCompanyName
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblCompanyName = value
			End Set
		End Property

		Public Overridable Property lblFileDescription As Label
			Get
				Return Me._lblFileDescription
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblFileDescription = value
			End Set
		End Property

		Public Overridable Property _lblMisc_0 As Label
			Get
				Return Me.__lblMisc_0
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__lblMisc_0 = value
			End Set
		End Property

		Public Overridable Property lblPathEXE As Label
			Get
				Return Me._lblPathEXE
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblPathEXE = value
			End Set
		End Property

		Public Overridable Property lblTrademark As Label
			Get
				Return Me._lblTrademark
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblTrademark = value
			End Set
		End Property

		Public Overridable Property lblCopyright As Label
			Get
				Return Me._lblCopyright
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblCopyright = value
			End Set
		End Property

		Public Overridable Property _linDivide_1 As Label
			Get
				Return Me.__linDivide_1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__linDivide_1 = value
			End Set
		End Property

		Public Overridable Property _linDivide_0 As Label
			Get
				Return Me.__linDivide_0
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__linDivide_0 = value
			End Set
		End Property

		Public Overridable Property lblWarning As Label
			Get
				Return Me._lblWarning
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblWarning = value
			End Set
		End Property

		Public Overridable Property lblVersion As Label
			Get
				Return Me._lblVersion
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblVersion = value
			End Set
		End Property

		Public Overridable Property lblTitle As Label
			Get
				Return Me._lblTitle
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Dim value2 As EventHandler = AddressOf Me.lblTitle_TextChanged
				If Me._lblTitle IsNot Nothing Then
					RemoveHandler Me._lblTitle.TextChanged, value2
				End If
				Me._lblTitle = value
				If Me._lblTitle IsNot Nothing Then
					AddHandler Me._lblTitle.TextChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property imgIcon As PictureBox
			Get
				Return Me._imgIcon
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._imgIcon = value
			End Set
		End Property

		Public Overridable Property lblMisc As LabelArray
			Get
				Return Me._lblMisc
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As LabelArray)
				Me._lblMisc = value
			End Set
		End Property

		Public Overridable Property linDivide As LabelArray
			Get
				Return Me._linDivide
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As LabelArray)
				Me._linDivide = value
			End Set
		End Property

		Friend Overridable Property lblDemoMode As Label
			Get
				Return Me._lblDemoMode
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblDemoMode = value
			End Set
		End Property

		Public Shared Property DefInstance As FAboutSplash
			Get
				If FAboutSplash.m_vb6FormDefInstance Is Nothing OrElse FAboutSplash.m_vb6FormDefInstance.IsDisposed Then
					FAboutSplash.m_InitializingDefInstance = True
					FAboutSplash.m_vb6FormDefInstance = New FAboutSplash()
					FAboutSplash.m_InitializingDefInstance = False
				End If
				Return FAboutSplash.m_vb6FormDefInstance
			End Get
			Set(value As FAboutSplash)
				FAboutSplash.m_vb6FormDefInstance = value
			End Set
		End Property

		Public Property bLaunch As Boolean
			Get
				Return Me.m_bLaunch
			End Get
			Set(value As Boolean)
				Me.m_bLaunch = value
				If Me.m_bLaunch Then
					Try
						Cursor.Current = Cursors.WaitCursor
						Me.CheckRegKeyRSWIN32()
						Dim text As String = "Status"
						Me.CheckForKey(text)
						text = "Status"
						Dim text2 As String = "Checking Sentinel"
						Dim text3 As String = Conversions.ToString(False)
						Me.WriteRegProfileString(text, text2, text3, "")
						text3 = "Status"
						text2 = "Sentinel Failure"
						text = Conversions.ToString(False)
						Me.WriteRegProfileString(text3, text2, text, "")
						text3 = "Status"
						text2 = "Running"
						text = Conversions.ToString(False)
						Me.WriteRegProfileString(text3, text2, text, "")
						Me.iMajor = Conversions.ToInteger(RSWIN_DESC.VersionMajor)
						Me.iMinor = Conversions.ToInteger(RSWIN_DESC.VersionMinor)
						Me.iBuild = Conversions.ToInteger(RSWIN_DESC.VersionBuild)
						Me.iRevision = Conversions.ToInteger(RSWIN_DESC.VersionRevision)
						If RSWIN_DESC.bRodStarD Then
							Dim text4 As String = RSWIN_DESC.sProgramNameD.Replace(" for Windows", " ")
							Me.sProgramName = String.Concat(New String() { text4, Me.iMajor.ToString(), ".", Me.iMinor.ToString(), RSWIN_DESC.sForWindows })
							Dim text5 As String = RSWIN_DESC.sProgramLongNameD.Replace(" for Windows", " ")
							RSWIN_DESC.sProgramLongName = String.Concat(New String() { text5, Me.iMajor.ToString(), ".", Me.iMinor.ToString(), ".", Me.iBuild.ToString(), RSWIN_DESC.sForWindows })
						Else
							Dim text4 As String = RSWIN_DESC.sProgramNameV.Replace(" for Windows", " ")
							Me.sProgramName = String.Concat(New String() { text4, Me.iMajor.ToString(), ".", Me.iMinor.ToString(), RSWIN_DESC.sForWindows })
							Dim text5 As String = RSWIN_DESC.sProgramLongNameV.Replace(" for Windows", " ")
							RSWIN_DESC.sProgramLongName = String.Concat(New String() { text5, Me.iMajor.ToString(), ".", Me.iMinor.ToString(), ".", Me.iBuild.ToString(), RSWIN_DESC.sForWindows })
						End If
						text3 = "Version"
						text2 = "Short"
						text = Me.sProgramName
						Me.WriteRegProfileString(text3, text2, text, "")
						Me.sProgramName = text
						text3 = "Version"
						text2 = "Long"
						text = RSWIN_DESC.sProgramLongName
						Me.WriteRegProfileString(text3, text2, text, "")
						RSWIN_DESC.sProgramLongName = text
						Me.sProgramName = Me.sProgramName.Replace("1.0", Me.iMajor.ToString() + "." + Me.iMinor.ToString())
						If Operators.CompareString(RSWIN_DESC.gsTrialType, "", False) <> 0 Then
							Me.lblTitle.Text = String.Concat(New String() { "Launching ", Me.sProgramName, " (", RSWIN_DESC.gsTrialType, ") " })
						Else
							Me.lblTitle.Text = "Launching " + Me.sProgramName + " "
						End If
						Me.lblVersion.Text = ""
						Me.cmdOK.Enabled = False
						Me.cmdSysInfo.Enabled = False
						Me.lblWarning.Text = Me.gWarningInfo
						If Strings.Len(Me.lUserName) <> 0 Then
							Me.lblUserName.Text = Me.lUserName
							Me.lblUserInfo.Text = Me.lUserInfo
						Else
							Me.lblUserName.Text = Me.GetUserName()
							Me.lblUserInfo.Text = Me.GetUserCompany()
						End If
						Dim app As CThetaApp = RSWIN.App
						If Strings.Len(app.CompanyName) <> 0 Then
							Me.lblCompanyName.Text = "A product of Theta Oilfield Services, Inc."
						Else
							Me.lblCompanyName.Text = Nothing
						End If
						Me.lblCopyright.Text = app.LegalCopyright
						Me.lblTrademark.Text = app.LegalTrademarks
						Me.lblPathEXE.Text = app.Path + "\" + app.EXEName + " "
						Me.lblFileDescription.Text = app.FileDescription
						Application.DoEvents()
						Me.Refresh()
					Catch ex As Exception
					End Try
				End If
			End Set
		End Property

		Public Property sProgramName As String
			Get
				Return Me.m_sProgramName
			End Get
			Set(value As String)
				Me.m_sProgramName = value
			End Set
		End Property

		Public Property SerialNumber As Integer
			Get
				Return Me.m_SerialNumber
			End Get
			Set(value As Integer)
				Me.m_SerialNumber = value
			End Set
		End Property

		Public Sub About(Optional ByRef lUserName As String = "", Optional ByRef lUserInfo As String = "")
			Me.imgIcon.Image = Me.ParentForm.Icon.ToBitmap()
			Me.cmdOK.Enabled = True
			Me.cmdSysInfo.Enabled = True
			If Strings.Len(lUserName) <> 0 Then
				Me.lblUserName.Text = lUserName
				Me.lblUserInfo.Text = lUserInfo
			Else
				Me.lblUserName.Text = Me.GetUserName()
				Me.lblUserInfo.Text = Me.GetUserCompany()
			End If
		End Sub

		Public Sub SplashOff()
			If Me.Visible Then
				Me.Hide()
				Me.ShowTitleBar()
			End If
		End Sub

		Public Property MinDisplay As Integer
			Get
				Return Me.m_MinDisplay
			End Get
			Set(value As Integer)
				Me.m_MinDisplay = value
			End Set
		End Property

		Public Property lUserInfo As String
			Get
				Return Me.m_lUserInfo
			End Get
			Set(value As String)
				Me.m_lUserInfo = value
			End Set
		End Property

		Public Property lUserName As String
			Get
				Return Me.m_lUserName
			End Get
			Set(value As String)
				Me.m_lUserName = value
			End Set
		End Property

		Public Sub SplashOn(Optional ByRef lUserName As String = "", Optional ByRef lUserInfo As String = "")
			If Me.m_MinDisplay > 0 Then
				Me.cmdOK.Enabled = False
				Me.cmdSysInfo.Enabled = False
			Else
				Me.cmdOK.Enabled = True
				Me.cmdSysInfo.Enabled = True
			End If
			If Strings.Len(lUserName) <> 0 Then
				Me.lblUserName.Text = lUserName
				Me.lblUserInfo.Text = lUserInfo
			Else
				Me.lblUserName.Text = Me.GetUserName()
				Me.lblUserInfo.Text = Me.GetUserCompany()
			End If
			Me.sProgramName = Me.sProgramName.Replace("1.0", Me.iMajor.ToString() + "." + Me.iMinor.ToString())
			If Operators.CompareString(RSWIN_DESC.gsTrialType, "", False) <> 0 Then
				Me.lblTitle.Text = Me.m_sProgramName + " (" + RSWIN_DESC.gsTrialType + ")"
			Else
				Me.lblTitle.Text = Me.m_sProgramName
			End If
			Me.lblVersion.Text = " (SN#" + Me.m_SerialNumber.ToString() + ")"
			Me.Show()
			Application.DoEvents()
			Me.Refresh()
			If Me.m_MinDisplay > 0 Then
				Me.Timer1.Interval = Me.m_MinDisplay
				Me.Timer1.Enabled = True
				Me.Timer1.Start()
				Me.exitFlag = False
				While Not Me.exitFlag
					Application.DoEvents()
				End While
				Me.SplashOff()
				Return
			End If
		End Sub

		Private Function GetKeyValue(ByRef KeyRoot As Integer, ByRef KeyName As String, ByRef SubKeyRef As String, ByRef KeyVal As String) As Boolean
			' The following expression was wrapped in a checked-statement
			Dim result As Boolean
			Try
				Dim registryKey As RegistryKey = Registry.LocalMachine.OpenSubKey(KeyName)
				Dim text As String = New String(vbNullChar, 1024)
				text = Conversions.ToString(registryKey.GetValue(SubKeyRef, 0))
				Dim type As Type = Type.[GetType]("System.String")
				Dim num As Integer
				If text.[GetType]() Is type Then
					num = 1
				Else
					num = 2
				End If
				Select Case num
					Case 1
						KeyVal = text
					Case 4
						For i As Integer = Strings.Len(text)To 1 Step -1
							KeyVal += Conversion.Hex(Strings.Asc(Strings.Mid(text, i, 1)))
						Next
						Dim obj As Object = "&h" + KeyVal
						KeyVal = Util.Format(obj)
				End Select
				result = True
				registryKey.Close()
			Catch ex As Exception
				KeyVal = Nothing
				result = False
				Dim registryKey As RegistryKey
				registryKey.Close()
			End Try
			Return result
		End Function

		Private Function GetUserCompany() As String
			Dim num As Integer = -2147483646
			Dim text As String = "SOFTWARE\Microsoft\Windows NT\CurrentVersion"
			Dim text2 As String = "RegisteredOrganization"
			Dim text3 As String
			Dim result As String
			If Me.GetKeyValue(num, text, text2, text3) Then
				result = text3
			Else
				num = -2147483647
				text2 = "Software\Microsoft\MS Setup (ACME)\User Info"
				text = "DefCompany"
				If Me.GetKeyValue(num, text2, text, text3) Then
					result = text3
				Else
					result = Nothing
				End If
			End If
			Return result
		End Function

		Private Function GetUserName() As String
			Dim num As Integer = -2147483646
			Dim text As String = "SOFTWARE\Microsoft\Windows NT\CurrentVersion"
			Dim text2 As String = "RegisteredOwner"
			Dim text3 As String
			Dim result As String
			If Me.GetKeyValue(num, text, text2, text3) Then
				result = text3
			Else
				num = -2147483647
				text2 = "Software\Microsoft\MS Setup (ACME)\User Info"
				text = "DefName"
				If Me.GetKeyValue(num, text2, text, text3) Then
					result = text3
				Else
					result = Nothing
				End If
			End If
			Return result
		End Function

		Private Sub ShowTitleBar()
		End Sub

		Private Sub StartSysInfo()
			Dim num As Integer
			Dim num3 As Integer
			Dim obj As Object
			Try
				ProjectData.ClearProjectError()
				num = 2
				Dim num2 As Integer = -2147483646
				Dim text As String = "SOFTWARE\Microsoft\Shared Tools\MSINFO"
				Dim text2 As String = "PATH"
				Dim text3 As String
				If Not Me.GetKeyValue(num2, text, text2, text3) Then
					num2 = -2147483646
					text2 = "SOFTWARE\Microsoft\Shared Tools Location"
					text = "MSINFO"
					If Me.GetKeyValue(num2, text2, text, text3) AndAlso Strings.Len(FileSystem.Dir(text3 + "\MSINFO32.EXE", FileAttribute.Normal)) <> 0 Then
						text3 += "\MSINFO32.EXE"
						GoTo IL_75
					End If
					IL_81:
					GoTo IL_C8
				End If
				IL_75:
				Interaction.Shell(text3, AppWinStyle.NormalFocus, False, -1)
				GoTo IL_C8
				IL_83:
				num3 = -1
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_99:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num3 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_83
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_C8:
			If num3 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		Private Sub cmdOK_Click(eventSender As Object, eventArgs As EventArgs)
			Me.Hide()
		End Sub

		Private Sub cmdSysInfo_Click(eventSender As Object, eventArgs As EventArgs)
			Me.StartSysInfo()
		End Sub

		Private Sub FAboutSplash_Load(eventSender As Object, eventArgs As EventArgs)
			Try
				Me.Show()
				If RSWIN_DESC.bIntVersion Then
					If RSWIN_DESC.bWriteResXFile Then
						Dim text As String = ""
						Dim text2 As String = "Language"
						Dim regProfileString As Integer = RSWIN.GetRegProfileString(RSWIN_DESC.SECT_GENERAL, text2, RSWIN_DESC.sEnglish, text, False)
						RSWIN_DESC.SETUP_Language = text.Substring(0, regProfileString)
						If Not RSWIN_DESC.bIntVersion Then
							RSWIN_DESC.SETUP_Language = RSWIN_DESC.sEnglish
						End If
						Util.OpenResourceWriter(Me.Name)
						Util.WriteControlStrings(Me, Me.ToolTip1)
						Util.CloseResourceWriter()
					End If
					If RSWIN_DESC.bReadResXFile Then
						Util.AssignValuesToControls(Me)
					End If
				End If
			Catch ex As Exception
				Dim sMsg As String = "Error in Load AbSplash: " + ex.Message
				Dim sMsgType As String = ""
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
			End Try
		End Sub

		Private Sub Timer1_Tick(eventSender As Object, eventArgs As EventArgs)
			Me.Timer1.[Stop]()
			Me.Timer1.Enabled = False
			Me.exitFlag = True
		End Sub

		Public Function CheckRegKeyRSWIN32() As Boolean
			If RSWIN_DESC.bUseCurrentUser Then
				If Registry.CurrentUser.OpenSubKey(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Software\", RSWIN_DESC.sThetaName), "\"), RSWIN_DESC.SECT_PROGWIN32))) Is Nothing Then
					Registry.CurrentUser.CreateSubKey(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Software\", RSWIN_DESC.sThetaName), "\"), RSWIN_DESC.SECT_PROGWIN32)))
					Return False
				End If
				Return True
			Else
				If Registry.LocalMachine.OpenSubKey(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Software\", RSWIN_DESC.sThetaName), "\"), RSWIN_DESC.SECT_PROGWIN32))) Is Nothing Then
					Registry.LocalMachine.CreateSubKey(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Software\", RSWIN_DESC.sThetaName), "\"), RSWIN_DESC.SECT_PROGWIN32)))
					Return False
				End If
				Return True
			End If
		End Function

		Private Function CheckForKey(ByRef sSection As String) As Boolean
			If RSWIN_DESC.bUseCurrentUser Then
				If Registry.CurrentUser.OpenSubKey(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Software\", RSWIN_DESC.sThetaName), "\"), RSWIN_DESC.SECT_PROGWIN32), "\"), sSection))) Is Nothing Then
					Registry.CurrentUser.CreateSubKey(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Software\", RSWIN_DESC.sThetaName), "\"), RSWIN_DESC.SECT_PROGWIN32), "\"), sSection)))
					Return False
				End If
				Return True
			Else
				If Registry.LocalMachine.OpenSubKey(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Software\", RSWIN_DESC.sThetaName), "\"), RSWIN_DESC.SECT_PROGWIN32), "\"), sSection))) Is Nothing Then
					Registry.LocalMachine.CreateSubKey(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Software\", RSWIN_DESC.sThetaName), "\"), RSWIN_DESC.SECT_PROGWIN32), "\"), sSection)))
					Return False
				End If
				Return True
			End If
		End Function

		Public Function WriteRegProfileString(ByRef lpKeyName As String, ByRef lpValueName As String, ByRef lpValue As String, Optional IniFile As String = "") As Integer
			Dim flag As Boolean = Me.CheckForKey(lpKeyName)
			Dim registryKey As RegistryKey
			If RSWIN_DESC.bUseCurrentUser Then
				registryKey = Registry.CurrentUser.OpenSubKey(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Software\", RSWIN_DESC.sThetaName), "\"), RSWIN_DESC.SECT_PROGWIN32), "\"), lpKeyName)), True)
			Else
				registryKey = Registry.LocalMachine.OpenSubKey(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Software\", RSWIN_DESC.sThetaName), "\"), RSWIN_DESC.SECT_PROGWIN32), "\"), lpKeyName)), True)
			End If
			Dim result As Integer
			Try
				registryKey.SetValue(lpValueName, lpValue)
				result = 1
			Catch ex As Exception
				result = -1
			End Try
			Return result
		End Function

		Private Sub FAboutSplash_Activated(sender As Object, e As EventArgs)
		End Sub

		Private Sub lblTitle_TextChanged(sender As Object, e As EventArgs)
			Me.lblTitle.Text = Me.lblTitle.Text.Replace("1.0", Me.iMajor.ToString() + "." + Me.iMinor.ToString())
		End Sub

		<AccessedThroughProperty("lblUserInfo")>
		Private _lblUserInfo As Label

		<AccessedThroughProperty("lblUserName")>
		Private _lblUserName As Label

		<AccessedThroughProperty("Picture1")>
		Private _Picture1 As Panel

		<AccessedThroughProperty("Timer1")>
		Private _Timer1 As Timer

		<AccessedThroughProperty("cmdSysInfo")>
		Private _cmdSysInfo As Button

		<AccessedThroughProperty("cmdOK")>
		Private _cmdOK As Button

		<AccessedThroughProperty("lblCompanyName")>
		Private _lblCompanyName As Label

		<AccessedThroughProperty("lblFileDescription")>
		Private _lblFileDescription As Label

		<AccessedThroughProperty("_lblMisc_0")>
		Private __lblMisc_0 As Label

		<AccessedThroughProperty("lblPathEXE")>
		Private _lblPathEXE As Label

		<AccessedThroughProperty("lblTrademark")>
		Private _lblTrademark As Label

		<AccessedThroughProperty("lblCopyright")>
		Private _lblCopyright As Label

		<AccessedThroughProperty("_linDivide_1")>
		Private __linDivide_1 As Label

		<AccessedThroughProperty("_linDivide_0")>
		Private __linDivide_0 As Label

		<AccessedThroughProperty("lblWarning")>
		Private _lblWarning As Label

		<AccessedThroughProperty("lblVersion")>
		Private _lblVersion As Label

		<AccessedThroughProperty("lblTitle")>
		Private _lblTitle As Label

		<AccessedThroughProperty("imgIcon")>
		Private _imgIcon As PictureBox

		<AccessedThroughProperty("lblMisc")>
		Private _lblMisc As LabelArray

		<AccessedThroughProperty("linDivide")>
		Private _linDivide As LabelArray

		<AccessedThroughProperty("lblDemoMode")>
		Private _lblDemoMode As Label

		Private Shared m_vb6FormDefInstance As FAboutSplash

		Private Shared m_InitializingDefInstance As Boolean

		Private exitFlag As Boolean

		Private Const READ_CONTROL As Integer = 131072

		Private Const KEY_QUERY_VALUE As Short = 1S

		Private Const KEY_SET_VALUE As Short = 2S

		Private Const KEY_CREATE_SUB_KEY As Short = 4S

		Private Const KEY_ENUMERATE_SUB_KEYS As Short = 8S

		Private Const KEY_NOTIFY As Short = 16S

		Private Const KEY_CREATE_LINK As Short = 32S

		Private Const KEY_ALL_ACCESS As Double = 131135.0

		Private Const HKEY_CLASSES_ROOT As Integer = -2147483648

		Private Const HKEY_CURRENT_USER As Integer = -2147483647

		Private Const HKEY_LOCAL_MACHINE As Integer = -2147483646

		Private Const ERROR_SUCCESS As Short = 0S

		Private Const REG_SZ As Short = 1S

		Private Const REG_DWORD As Short = 4S

		Private Const gREGKEYSYSINFOLOC As String = "SOFTWARE\Microsoft\Shared Tools Location"

		Private Const gREGKEYSYSINFO As String = "SOFTWARE\Microsoft\Shared Tools\MSINFO"

		Private Const gREGVALSYSINFOLOC As String = "MSINFO"

		Private Const gREGVALSYSINFO As String = "PATH"

		Private Const gNTREGKEYINFO As String = "SOFTWARE\Microsoft\Windows NT\CurrentVersion"

		Private Const gNTREGVALUSER As String = "RegisteredOwner"

		Private Const gNTREGVALCOMPANY As String = "RegisteredOrganization"

		Private Const g95REGKEYINFO As String = "Software\Microsoft\MS Setup (ACME)\User Info"

		Private Const g95REGVALUSER As String = "DefName"

		Private Const g95REGVALCOMPANY As String = "DefCompany"

		Private Const DEFAULT_USER_NAME As String = Nothing

		Private Const DEFAULT_USER_INFO As String = Nothing

		Private gWarningInfo As String

		Private mBoxHeight As Short

		Private mStyle As FAboutSplash.StyleType

		Private mTitleBarHidden As Boolean

		Private bStop As Boolean

		Private iMajor As Integer

		Private iMinor As Integer

		Private iBuild As Integer

		Private iRevision As Integer

		Private m_bLaunch As Boolean

		Private m_sProgramName As String

		Private m_SerialNumber As Integer

		Private m_MinDisplay As Integer

		Private m_lUserInfo As String

		Private m_lUserName As String

		Private Structure StyleType
			Public OldStyle As Integer

			Public NewStyle As Integer
		End Structure
	End Class
End Namespace
