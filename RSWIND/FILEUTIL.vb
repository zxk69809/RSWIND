Imports System
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	Friend NotInheritable Module FILEUTIL
		Private Declare Ansi Function OpenFile Lib "kernel32" (<MarshalAs(UnmanagedType.VBByRefStr)> ByRef lpFileName As String, ByRef lpReOpenBuff As FILEUTIL.OFSTRUCT, wStyle As Integer) As Integer

		Public Function FileExists(ByRef sFileName As String) As Boolean
			Dim fileInfo As FileInfo = New FileInfo(sFileName)
			Return fileInfo.Exists
		End Function

		Public Function GetFileDate(ByRef sFileName As String) As String
			Dim fileInfo As FileInfo = New FileInfo(sFileName)
			If fileInfo.Exists Then
				Return fileInfo.CreationTime.ToLongDateString()
			End If
			Return ""
		End Function

		Public Function CopyFile(sFromFileName As String, sToFileName As String, sShortToFileName As String, Optional sDirDefault As String = "") As String
			Dim fileInfo As FileInfo = New FileInfo(sFromFileName)
			Dim text As String = ""
			If Operators.CompareString(sDirDefault, "", False) = 0 Then
				text = fileInfo.DirectoryName + "\" + sShortToFileName
			Else
				text = sDirDefault + "\" + sShortToFileName
			End If
			If FILEUTIL.FileExists(text) Then
				FileSystem.Kill(text)
			End If
			fileInfo.CopyTo(text)
			Return text
		End Function

		Public Sub LocateFile(sFileTitle As String, ByRef sFilePath As String, fuFlags As Short, Optional bSuppressErrorMsg As Boolean = False, Optional bInitialization As Boolean = False, Optional bSearchThetaDataOnly As Boolean = False, Optional bSearchServerOnly As Boolean = False)
			Dim text As String = Interaction.Environ("USERPROFILE") + "\Application Data\ThetaData\" + VERSION1.ProgramName() + "\"
			Try
				Dim num As Short = If((-If((((fuFlags And 2S) <> 0S) > False), 1S, 0S)), 1S, 0S)
				Dim num2 As Short = If((-If((((fuFlags And 1S) <> 0S) > False), 1S, 0S)), 1S, 0S)
				Dim num3 As Short = If((-If((((fuFlags And 4S) = 0S) > False), 1S, 0S)), 1S, 0S)
				Dim num4 As Short = If((-If((((fuFlags And 8S) = 0S) > False), 1S, 0S)), 1S, 0S)
				sFilePath = ""
				Dim text2 As String = sFileTitle
				If bInitialization Then
					If Strings.Len(sFilePath) = 0 Then
						Dim text3 As String = "c:\Theta\Superpro\Rodstar"
						Dim text4 As String = text3 + "\" + text2
						If FILEUTIL.FileExists(text4) Then
							sFilePath = text3 + "\" + sFileTitle
						End If
					End If
					If Strings.Len(sFilePath) = 0 Then
						Dim text3 As String = "c:\Theta\ThetaLM\Rodstar"
						Dim text4 As String = text3 + "\" + text2
						If FILEUTIL.FileExists(text4) Then
							sFilePath = text3 + "\" + sFileTitle
						End If
					End If
				End If
				If RSWIN_DESC.SETUP_UseServerDBLocation And Operators.CompareString(RSWIN_DESC.SETUP_ServerDBLocation.Trim(), "", False) = 0 Then
					RSWIN_DESC.SETUP_UseDefaultDBLocation = True
					RSWIN_DESC.SETUP_UseServerDBLocation = False
					If bSearchServerOnly Then
						sFilePath = ""
						Return
					End If
				End If
				If bSearchThetaDataOnly Then
					Dim fileInfo As FileInfo = New FileInfo(text + text2)
					If fileInfo.Exists Then
						sFilePath = text + text2
					Else
						sFilePath = ""
					End If
				ElseIf bSearchServerOnly Then
					Dim fileInfo As FileInfo = New FileInfo(RSWIN_DESC.SETUP_ServerDBLocation.Trim() + "\" + text2)
					If fileInfo.Exists Then
						sFilePath = RSWIN_DESC.SETUP_ServerDBLocation.Trim() + "\" + text2
					Else
						sFilePath = ""
					End If
				ElseIf Strings.InStr(text2.ToUpper(), "RODSTAR.CDB", CompareMethod.Binary) > 0 Or Strings.InStr(text2, Conversions.ToString(RSWIN_DESC.sCustomDBFileName), CompareMethod.Binary) > 0 Or Strings.InStr(text2.ToUpper(), "CUSTOM", CompareMethod.Binary) > 0 Or Strings.InStr(text2.ToLower(), "xre.mdb", CompareMethod.Binary) > 0 Or Strings.InStr(text2.ToLower(), "xr.mdb", CompareMethod.Binary) > 0 Then
					Dim flag As Boolean
					If RSWIN_DESC.SETUP_UseServerDBLocation Then
						flag = False
						Dim fileInfo As FileInfo = New FileInfo(RSWIN_DESC.SETUP_ServerDBLocation.Trim() + "\" + text2)
						If fileInfo.Exists Then
							sFilePath = RSWIN_DESC.SETUP_ServerDBLocation.Trim() + "\" + text2
						Else
							fileInfo = New FileInfo(text + text2)
							If fileInfo.Exists Then
								sFilePath = text + text2
							Else
								flag = True
							End If
						End If
					Else
						flag = True
					End If
					If flag Then
						Dim fileInfo As FileInfo = New FileInfo(text + text2)
						If Not fileInfo.Exists Then
							If Not Directory.Exists(text) Then
								Directory.CreateDirectory(text)
							End If
							Dim fileInfo2 As FileInfo = New FileInfo(Application.StartupPath + "\" + text2)
							If fileInfo2.Exists Then
								File.Copy(Application.StartupPath + "\" + text2, text + text2)
								sFilePath = text + text2
							ElseIf Not RSWIN_DESC.rst.gbBatch AndAlso Strings.InStr(text2.ToUpper(), "CUSTOM", CompareMethod.Binary) > 0 Then
								MessageBox.Show("Custom pumping unit not located. Please contact Theta technical support.")
							End If
						Else
							sFilePath = text + text2
						End If
					End If
				Else
					If Strings.Len(sFilePath) = 0 Then
						Dim text3 As String = Application.StartupPath
						Dim text4 As String = text3 + "\" + text2
						If FILEUTIL.FileExists(text4) Then
							sFilePath = text3 + "\" + sFileTitle
						End If
					End If
					If Strings.Len(sFilePath) = 0 Then
						If Strings.Len(FILEUTIL.$STATIC$LocateFile$071E10E62222$sAppData) = 0 Then
							FILEUTIL.$STATIC$LocateFile$071E10E62222$sAppData = Interaction.Environ("APPDATA")
							If Strings.Len(FILEUTIL.$STATIC$LocateFile$071E10E62222$sAppData) <> 0 Then
								FILEUTIL.$STATIC$LocateFile$071E10E62222$sAppData += "\THETA"
							End If
						End If
						Dim text3 As String = FILEUTIL.$STATIC$LocateFile$071E10E62222$sAppData
						If Strings.Len(text3) > 0 Then
							Dim text4 As String = text3 + "\" + text2
							If FILEUTIL.FileExists(text4) Then
								sFilePath = text3 + "\" + sFileTitle
							End If
						End If
					End If
					If Strings.Len(sFilePath) = 0 Then
						If Strings.Len(FILEUTIL.$STATIC$LocateFile$071E10E62222$sUserProfileAppData) = 0 Then
							FILEUTIL.$STATIC$LocateFile$071E10E62222$sUserProfileAppData = Interaction.Environ("USERPROFILE")
							If Strings.Len(FILEUTIL.$STATIC$LocateFile$071E10E62222$sUserProfileAppData) <> 0 Then
								FILEUTIL.$STATIC$LocateFile$071E10E62222$sUserProfileAppData += "\APPLIC~1\THETA"
							End If
						End If
						Dim text3 As String = FILEUTIL.$STATIC$LocateFile$071E10E62222$sUserProfileAppData
						If Strings.Len(text3) > 0 Then
							Dim text4 As String = text3 + "\" + text2
							If FILEUTIL.FileExists(text4) Then
								sFilePath = text3 + "\" + sFileTitle
							End If
						End If
					End If
					If Strings.Len(sFilePath) = 0 Then
						If Strings.Len(FILEUTIL.$STATIC$LocateFile$071E10E62222$sUserProfile) = 0 Then
							FILEUTIL.$STATIC$LocateFile$071E10E62222$sUserProfile = Interaction.Environ("USERPROFILE")
							If Strings.Len(FILEUTIL.$STATIC$LocateFile$071E10E62222$sUserProfile) <> 0 Then
								FILEUTIL.$STATIC$LocateFile$071E10E62222$sUserProfile += "\THETA"
							End If
						End If
						Dim text3 As String = FILEUTIL.$STATIC$LocateFile$071E10E62222$sUserProfile
						If Strings.Len(text3) > 0 Then
							Dim text4 As String = text3 + "\" + text2
							If FILEUTIL.FileExists(text4) Then
								sFilePath = text3 + "\" + sFileTitle
							End If
						End If
					End If
					If(num4 And If((-If(((Strings.Len(sFilePath) = 0) > False), 1S, 0S)), 1S, 0S)) <> 0S Then
						Dim text3 As String = Interaction.Environ("THETA")
						If Strings.Len(text3) > 0 Then
							Dim text4 As String = text3 + "\" + text2
							If FILEUTIL.FileExists(text4) Then
								sFilePath = text3 + "\" + sFileTitle
							End If
						End If
					End If
					If(num3 And If((-If(((Strings.Len(sFilePath) = 0) > False), 1S, 0S)), 1S, 0S)) <> 0S Then
						Dim text4 As String = FileSystem.CurDir() + "\" + text2
						If FILEUTIL.FileExists(text4) Then
							Dim text3 As String = FileSystem.CurDir()
							sFilePath = text3 + "\" + sFileTitle
						End If
					End If
					If Strings.Len(sFilePath) = 0 Then
						FILEUTIL.$STATIC$LocateFile$071E10E62222$sWin = Environment.SystemDirectory.ToString()
						Dim text4 As String = FILEUTIL.$STATIC$LocateFile$071E10E62222$sWin + "\" + text2
						If FILEUTIL.FileExists(text4) Then
							Dim text3 As String = FILEUTIL.$STATIC$LocateFile$071E10E62222$sWin
							sFilePath = text3 + "\" + sFileTitle
						End If
					End If
					If Strings.Len(sFilePath) = 0 Then
						FILEUTIL.$STATIC$LocateFile$071E10E62222$sAppData = Application.StartupPath + "\Data"
						Dim text3 As String = FILEUTIL.$STATIC$LocateFile$071E10E62222$sAppData
						If Strings.Len(text3) > 0 Then
							Dim text4 As String = text3 + "\" + text2
							If FILEUTIL.FileExists(text4) Then
								sFilePath = text3 + "\" + sFileTitle
							End If
						End If
					End If
					If Strings.Len(sFilePath) = 0 Then
						Dim ofstruct As FILEUTIL.OFSTRUCT
						Try
							If FILEUTIL.FileExists(text2) Then
								FILEUTIL.OpenFile(text2, ofstruct, 16448)
							End If
						Catch ex As Exception
							If Not bSuppressErrorMsg Then
								Dim sMsg As String = "Error in LocateFile: Error in opening " + text2
								Dim sMsgType As String = "Error"
								Dim bClosing As Boolean = False
								Dim dialogResult As DialogResult = DialogResult.OK
								Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
							End If
						End Try
						If ofstruct.nErrCode = 0S Or ofstruct.nErrCode = 32S Then
							Dim num5 As Short = CShort(Strings.InStr(sFilePath, vbNullChar, CompareMethod.Binary))
							If num5 <> 0S Then
								sFilePath = Strings.Left(sFilePath, CInt((num5 - 1S)))
							End If
							sFilePath = Strings.Trim(sFilePath)
						End If
					End If
					If Strings.Len(sFilePath) = 0 Then
						If num <> 0S Then
							If Not bSuppressErrorMsg Then
								Util.FatalError(Util.FormatMessage("The {0} data file {1} could not be found.", New Object() { VERSION1.ProgramName(), sFileTitle }))
							End If
						ElseIf num2 <> 0S Then
							If Strings.Len(sFilePath) = 0 And Strings.Len(FILEUTIL.$STATIC$LocateFile$071E10E62222$sAppData) <> 0 Then
								Dim text4 As String = FILEUTIL.$STATIC$LocateFile$071E10E62222$sAppData + "\NUL"
								Dim flag2 As Boolean = Not FILEUTIL.FileExists(text4)
								Dim text5 As String = Interaction.Environ("APPDATA") + "\NUL"
								If flag2 And FILEUTIL.FileExists(text5) Then
									FileSystem.MkDir(FILEUTIL.$STATIC$LocateFile$071E10E62222$sAppData)
								End If
								sFilePath = FILEUTIL.$STATIC$LocateFile$071E10E62222$sAppData + "\" + sFileTitle
							ElseIf Strings.Len(sFilePath) = 0 And Strings.Len(FILEUTIL.$STATIC$LocateFile$071E10E62222$sUserProfileAppData) <> 0 Then
								Dim text5 As String = FILEUTIL.$STATIC$LocateFile$071E10E62222$sUserProfileAppData + "\NUL"
								Dim flag3 As Boolean = Not FILEUTIL.FileExists(text5)
								Dim text4 As String = Interaction.Environ("USERPROFILE") + "\APPLIC~1\NUL"
								If flag3 And FILEUTIL.FileExists(text4) Then
									FileSystem.MkDir(FILEUTIL.$STATIC$LocateFile$071E10E62222$sUserProfileAppData)
								End If
								sFilePath = FILEUTIL.$STATIC$LocateFile$071E10E62222$sUserProfileAppData + "\" + sFileTitle
							ElseIf Strings.Len(sFilePath) = 0 And Strings.Len(FILEUTIL.$STATIC$LocateFile$071E10E62222$sUserProfile) <> 0 Then
								Dim text5 As String = FILEUTIL.$STATIC$LocateFile$071E10E62222$sUserProfile + "\NUL"
								Dim flag4 As Boolean = Not FILEUTIL.FileExists(text5)
								Dim text4 As String = Interaction.Environ("USERPROFILE") + "\NUL"
								If flag4 And FILEUTIL.FileExists(text4) Then
									FileSystem.MkDir(FILEUTIL.$STATIC$LocateFile$071E10E62222$sUserProfile)
								End If
								sFilePath = FILEUTIL.$STATIC$LocateFile$071E10E62222$sUserProfile + "\" + sFileTitle
							ElseIf Strings.Len(sFilePath) = 0 And (fuFlags And 16S) = 0S Then
								sFilePath = Application.StartupPath + "\" + sFileTitle
							End If
						End If
					End If
				End If
			Catch ex2 As Exception
				If Not bSuppressErrorMsg Then
					Dim sMsg2 As String = "Error in LocateFile (" + sFileTitle + "): " + ex2.Message
					Dim sMsgType2 As String = ""
					Dim bClosing2 As Boolean = False
					Dim dialogResult As DialogResult = DialogResult.OK
					Util.SendMessage(sMsg2, sMsgType2, bClosing2, dialogResult)
				End If
			End Try
		End Sub

		Public Function InitializeCustomMDB() As Boolean
			Dim text As String = Interaction.Environ("USERPROFILE") + "\Application Data\ThetaData\" + VERSION1.ProgramName() + "\"
			Dim obj As Object = Application.StartupPath + "\"
			Dim result As Boolean
			Try
				RSWIN_DESC.SETUP_UseServerDBLocation = False
				Dim text2 As String = Conversions.ToString(RSWIN_DESC.sCustomDBFileName)
				Dim fileInfo As FileInfo = New FileInfo(text + text2)
				If Not fileInfo.Exists Then
					If Not Directory.Exists(text) Then
						Directory.CreateDirectory(text)
					End If
					Dim fileInfo2 As FileInfo = New FileInfo(Conversions.ToString(Operators.ConcatenateObject(obj, text2)))
					If fileInfo2.Exists Then
						File.Copy(Conversions.ToString(Operators.ConcatenateObject(obj, text2)), text + text2)
					End If
				End If
				Dim array As RSWIN_DESC.CustomRodGrade()
				Try
					Custom.LoadCustomRodGradeList(RSWIN_DESC.CustomRodGradeList, False, "")
					CUSTOMRG.LoadCustomRodGradeList(array, False)
				Catch ex As Exception
				End Try
				Try
					Dim num As Short = 1S
					Dim num2 As Short = CShort(Information.UBound(array, 1))
					For num3 As Short = num To num2
						If array(CInt(num3)).RodType IsNot Nothing AndAlso Operators.CompareString(array(CInt(num3)).RodType.Trim(), "", False) <> 0 AndAlso Conversions.ToBoolean(Operators.NotObject(FILEUTIL.IsInCustomRodGradeDB(array(CInt(num3))))) Then
							Custom.CustomRodGrades_DBAddRow(array(CInt(num3)), False, "")
						End If
					Next
				Catch ex2 As Exception
				End Try
				result = True
			Catch ex3 As Exception
				Dim sMsg As String = "Error in InitializeCustomMDB : " + ex3.Message
				Dim sMsgType As String = ""
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
				result = False
			End Try
			Return result
		End Function

		Public Function InitializeThetaDataFiles_() As Boolean
			Try
				Dim str As String = Interaction.Environ("USERPROFILE") + "\Application Data\ThetaData\"
				Dim text As String = Interaction.Environ("USERPROFILE") + "\Application Data\ThetaData\" + VERSION1.ProgramName() + "\"
				Dim array As String() = New String(4) {}
				Dim array2 As String() = New String(4) {}
				Dim num As Integer = 4
				array(1) = "RODSTAR.CDB"
				array(2) = "CUSTOM32.PUD"
				array(3) = "CustomRGPU.mdb"
				array2(1) = ""
				array2(2) = ""
				array2(3) = ""
				Dim flag As Boolean = True
				Dim num2 As Integer = 0
				Dim num3 As Short = 1S
				Dim num4 As Short = CShort(num)
				For num5 As Short = num3 To num4
					Dim text2 As String = array(CInt(num5))
					If Not(num5 = 3S And Not RSWIN_DESC.bExpert) Then
						Dim fileInfo As FileInfo = New FileInfo(RSWIN_DESC.SETUP_ServerDBLocation.Trim() + "\" + text2)
						If fileInfo.Exists Then
							Dim text3 As String = RSWIN_DESC.SETUP_ServerDBLocation.Trim() + "\" + text2
						Else
							flag = False
							num2 += 1
							array2(num2) = array(CInt(num5))
						End If
					End If
				Next
				If Not flag Then
					Dim num6 As Short = 1S
					Dim num7 As Short = CShort(num2)
					Dim num5 As Short = num6
					While num5 <= num7
						Dim text2 As String = array2(CInt(num5))
						If Operators.CompareString(text2.ToLower().Trim(), "xre.mdb", False) = 0 Then
							str = Interaction.Environ("USERPROFILE") + "\Application Data\ThetaData\" + VERSION1.ProgramName() + "\"
						Else
							str = Interaction.Environ("USERPROFILE") + "\Application Data\ThetaData\"
						End If
						Dim fileInfo As FileInfo = New FileInfo(str + text2)
						If fileInfo.Exists Then
							Try
								File.Copy(str + text2, RSWIN_DESC.SETUP_ServerDBLocation + "\" + text2)
								GoTo IL_234
							Catch ex As Exception
								MessageBox.Show(ex.Message)
								GoTo IL_234
							End Try
							GoTo IL_1CE
						End If
						GoTo IL_1CE
						IL_234:
						num5 += 1S
						Continue While
						IL_1CE:
						Dim fileInfo2 As FileInfo = New FileInfo(Application.StartupPath + "\" + text2)
						If fileInfo2.Exists Then
							Try
								File.Copy(Application.StartupPath + "\" + text2, RSWIN_DESC.SETUP_ServerDBLocation + "\" + text2)
							Catch ex2 As Exception
								MessageBox.Show(ex2.Message)
							End Try
							GoTo IL_234
						End If
						GoTo IL_234
					End While
				End If
			Catch ex3 As Exception
			End Try
			Dim result As Boolean
			Return result
		End Function

		Public Function IsInCustomRodGradeDB(CustomRodGradeItem As RSWIN_DESC.CustomRodGrade) As Object
			' The following expression was wrapped in a checked-statement
			Dim result As Object
			Try
				Dim flag As Boolean = False
				Dim num As Integer = 1
				Dim num2 As Integer = Information.UBound(RSWIN_DESC.CustomRodGradeList, 1)
				For i As Integer = num To num2
					If Operators.CompareString(RSWIN_DESC.CustomRodGradeList(i).RodType, CustomRodGradeItem.RodType, False) = 0 Then
						flag = True
						Exit For
					End If
				Next
				result = flag
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Const LF_OKNOTEXIST As Short = 1S

		Public Const LF_MUSTEXIST As Short = 2S

		Public Const LF_NOUSECURDIR As Short = 4S

		Public Const LF_NOUSETHETA As Short = 8S

		Public Const LF_INIFILE As Short = 16S

		Private Const OF_SHARE_DENY_NONE As Short = 64S

		Private Const OF_PARSE As Short = 256S

		Private Const OF_EXIST As Short = 16384S

		Private Const OF_REOPEN As Short = -32768S

		Private Const OFS_MAXPATHNAME As Short = 128S

		Private $STATIC$LocateFile$071E10E62222$sAppData As String

		Private $STATIC$InitializeCustomMDB$002$sAppData As String

		Private $STATIC$InitializeThetaDataFiles_$002$sAppData As String

		Private $STATIC$LocateFile$071E10E62222$sUserProfile As String

		Private $STATIC$InitializeCustomMDB$002$sUserProfile As String

		Private $STATIC$InitializeThetaDataFiles_$002$sUserProfile As String

		Private $STATIC$LocateFile$071E10E62222$sUserProfileAppData As String

		Private $STATIC$InitializeCustomMDB$002$sUserProfileAppData As String

		Private $STATIC$InitializeThetaDataFiles_$002$sUserProfileAppData As String

		Private $STATIC$LocateFile$071E10E62222$sWinDir As StringBuilder

		Private $STATIC$InitializeCustomMDB$002$sWinDir As StringBuilder

		Private $STATIC$LocateFile$071E10E62222$sWinSysDir As StringBuilder

		Private $STATIC$InitializeCustomMDB$002$sWinSysDir As StringBuilder

		Private $STATIC$LocateFile$071E10E62222$sWin As String

		Private $STATIC$InitializeCustomMDB$002$sWin As String

		Private $STATIC$InitializeThetaDataFiles_$002$sWin As String

		Private $STATIC$LocateFile$071E10E62222$sWinSys As String

		Private $STATIC$InitializeCustomMDB$002$sWinSys As String

		Private $STATIC$InitializeThetaDataFiles_$002$sWinSys As String

		Private Structure OFSTRUCT
			Public Sub Initialize()
				Me.szPathName = New Byte(128) {}
			End Sub

			Public cBytes As Byte

			Public fFixedDisk As Byte

			Public nErrCode As Short

			Public Reserved1 As Short

			Public Reserved2 As Short

			<VBFixedArray(128)>
			Public szPathName As Byte()
		End Structure
	End Module
End Namespace
