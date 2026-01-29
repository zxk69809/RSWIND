Imports System
Imports System.Collections
Imports System.Data
Imports System.Diagnostics
Imports System.IO
Imports System.Text
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	Friend NotInheritable Module FILEIO
		Public Sub GetString(frn As Short, ByRef S As String)
			Try
				Dim charCount As Short
				FileSystem.FileGet(CInt(frn), charCount, -1L)
				S = FileSystem.InputString(CInt(frn), CInt(charCount))
			Catch ex As Exception
			End Try
		End Sub

		Public Function MakePath(ByRef sFullPathName As String, ByRef sDrive As String, ByRef sDir As String, ByRef sFile As String, ByRef sExt As String) As Boolean
			Dim result As Boolean = True
			sFullPathName = Nothing
			If Strings.InStr(sFile, "\", CompareMethod.Binary) > 0 Then
				sFullPathName = sFile
			Else
				If Strings.Len(sDrive) > 0 Then
					sFullPathName = sDrive
					If Operators.CompareString(Strings.Right(sDrive, 1), ":", False) <> 0 Then
						sFullPathName += ":"
					End If
				End If
				If Strings.Len(sDir) > 0 Then
					sFullPathName += sDir
					If Operators.CompareString(Strings.Right(sDir, 1), "\", False) <> 0 And Operators.CompareString(Strings.Right(sDir, 1), "/", False) <> 0 Then
						sFullPathName += "\"
					End If
				End If
				If Strings.Len(sFile) > 0 Then
					sFullPathName += sFile
				End If
				If Strings.Len(sExt) > 0 Then
					If Operators.CompareString(Strings.Left(sExt, 1), ".", False) <> 0 Then
						sFullPathName += "."
					End If
					sFullPathName += sExt
				End If
			End If
			Return result
		End Function

		Public Sub MakeFileName(ByRef Filename As String, sExt As String)
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			Dim text As String = Strings.UCase(sExt)
			Dim text2 As String
			If Operators.CompareString(text, ".XDG", False) = 0 Then
				text2 = rst.XDGDir
			ElseIf Operators.CompareString(text, ".RSTX", False) = 0 Then
				text2 = rst.RSTDir
			ElseIf Operators.CompareString(text, ".XRVX", False) = 0 Then
				text2 = rst.RSTDir
			ElseIf Operators.CompareString(text, ".DYN", False) = 0 Then
				text2 = rst.DYNDir
			ElseIf sExt.Length > 0 Then
				text2 = Conversions.ToString(RSWIN.GetInitialDir(sExt, ""))
			Else
				text2 = FileSystem.CurDir()
			End If
			If Operators.CompareString(Strings.Right(text2, 1), "\", False) <> 0 Then
				text2 += "\"
			End If
			Dim text3 As String = ""
			Dim text4 As String = ""
			Dim text5 As String
			Dim text6 As String
			FILEIO.SplitPath(text2, text5, text6, text3, text4)
			Dim text7 As String = Strings.UCase(Strings.Trim(rst.WellName))
			If Strings.Len(text7) = 0 Then
				text7 = "DATA"
			End If
			Dim obj As Object
			Dim obj2 As Object
			If ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj, 0, RSWIN_DESC.sSpecialChars.Length - 1, 1, obj2, obj) Then
				Do
					If Strings.InStr(text7, RSWIN_DESC.sSpecialChars.Substring(Conversions.ToInteger(obj), 1), CompareMethod.Binary) > 0 Then
						text7 = text7.Replace(RSWIN_DESC.sSpecialChars.Substring(Conversions.ToInteger(obj), 1), "")
					End If
				Loop While ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj, obj2, obj)
			End If
			FILEIO.MakePath(Filename, text5, text6, text7, sExt)
		End Sub

		Public Sub PutString(frn As Short, S As String)
			' The following expression was wrapped in a checked-expression
			Dim value As Short = CShort(Strings.Len(S))
			FileSystem.FilePut(CInt(frn), value, -1L)
			FileSystem.FilePut(CInt(frn), S, -1L, False)
		End Sub

		Public Sub SelectInputFile(ByRef sFileName As String, ByRef sInitialDir As String, sDescList As String, iIndex As Integer, sInitFileName As String, sDialogTitle As String)
			Dim openFileDialog As OpenFileDialog = New OpenFileDialog()
			Try
				Dim openFileDialog2 As OpenFileDialog = openFileDialog
				openFileDialog2.Multiselect = False
				openFileDialog2.Title = sDialogTitle
				openFileDialog2.FileName = sInitFileName
				openFileDialog2.InitialDirectory = Conversions.ToString(RSWIN.GetInitialDir(sDescList, ""))
				openFileDialog2.RestoreDirectory = False
				openFileDialog2.Filter = sDescList
				openFileDialog2.FilterIndex = iIndex
				Dim dialogResult As DialogResult = openFileDialog2.ShowDialog()
				If dialogResult = DialogResult.OK Then
					Try
						sFileName = openFileDialog2.FileNames(0)
						If Operators.CompareString(sFileName, Nothing, False) = 0 Then
							Dim fileDirectory As String = FILEIO.GetFileDirectory(sFileName)
							Dim text As String = Nothing
							Dim text2 As String = Nothing
							Dim str As String
							Dim str2 As String
							FILEIO.SplitPath(fileDirectory, str, str2, text, text2)
							text2 = Nothing
							text = Nothing
							FILEIO.MakePath(sInitialDir, str, str2, text2, text)
							RSWIN.WriteInitialDir(sFileName, str + str2)
						End If
						GoTo IL_D7
					Catch ex As Exception
						sFileName = ""
						GoTo IL_D7
					End Try
				End If
				sFileName = ""
				IL_D7:
			Catch ex2 As Exception
			End Try
		End Sub

		Public Function SelectInputFiles(ByRef asFileList As String(), ByRef cFiles As Short, ByRef sInitialDir As String, sDescList As String, iIndex As Integer, sInitFileName As String, sDialogTitle As String, Optional ByRef sDefaultsFolder As String = "") As Boolean
			Dim openFileDialog As OpenFileDialog = New OpenFileDialog()
			Dim openFileDialog2 As OpenFileDialog = openFileDialog
			If RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru Then
				openFileDialog2.Multiselect = False
			Else
				openFileDialog2.Multiselect = True
			End If
			openFileDialog2.Title = sDialogTitle
			openFileDialog2.FileName = sInitFileName
			openFileDialog2.InitialDirectory = Conversions.ToString(RSWIN.GetInitialDir(sDescList, ""))
			openFileDialog2.RestoreDirectory = False
			openFileDialog2.Filter = sDescList
			openFileDialog2.FilterIndex = 1
			Dim dialogResult As DialogResult = openFileDialog2.ShowDialog()
			If dialogResult = DialogResult.OK Then
				Try
					Dim fileDirectory As String = FILEIO.GetFileDirectory(openFileDialog2.FileNames(0))
					Dim text As String = Nothing
					Dim text2 As String = Nothing
					Dim str As String
					Dim str2 As String
					FILEIO.SplitPath(fileDirectory, str, str2, text, text2)
					text2 = Nothing
					text = Nothing
					FILEIO.MakePath(sInitialDir, str, str2, text2, text)
					sDefaultsFolder = str + str2
					cFiles = CShort(openFileDialog2.FileNames.Length)
					asFileList = New String(CInt((cFiles + 1S)) - 1) {}
					If RSWIN_DESC.bExpert Then
						Dim num As Integer = -1
						Dim num2 As Integer = 0
						Dim num3 As Integer = CInt((cFiles - 1S))
						For i As Integer = num2 To num3
							If Not RSWIN_DESC.SETUP_bGuru And cFiles > 1S And Strings.InStr(openFileDialog2.FileNames(i).ToLower(), ".xrvx", CompareMethod.Binary) > 0 Then
								Debug.WriteLine("xrvx not allowed in batch run")
							Else
								num += 1
								asFileList = CType(Utils.CopyArray(CType(asFileList, Array), New String(num + 1 - 1) {}), String())
								Dim array As String() = asFileList
								Dim num4 As Integer = num
								text2 = Nothing
								Dim fileNames As String() = openFileDialog2.FileNames
								Dim num5 As Integer = i
								text = Nothing
								FILEIO.MakePath(array(num4), text2, sInitialDir, fileNames(num5), text)
								RSWIN.WriteInitialDir(asFileList(num), sDefaultsFolder)
							End If
						Next
						If Not RSWIN_DESC.SETUP_bGuru And cFiles > 1S And CInt(cFiles) <> num Then
							cFiles = CShort((num + 1))
						End If
					Else
						Dim num6 As Integer = 0
						Dim num7 As Integer = CInt((cFiles - 1S))
						For i As Integer = num6 To num7
							Dim array2 As String() = asFileList
							Dim num8 As Integer = i
							text2 = Nothing
							Dim fileNames2 As String() = openFileDialog2.FileNames
							Dim num9 As Integer = i
							text = Nothing
							FILEIO.MakePath(array2(num8), text2, sInitialDir, fileNames2(num9), text)
							RSWIN.WriteInitialDir(asFileList(i), sDefaultsFolder)
						Next
					End If
					Return True
				Catch ex As Exception
					Return False
				End Try
				Return False
			End If
			Return False
		End Function

		Public Function GetFileDirectory(ByRef FileName As String) As String
			Dim text As String = ""
			For num As Integer = Strings.InStr(FileName, "\", CompareMethod.Binary)To
				text += FileName.Substring(0, num)
				FileName = FileName.Substring(num, FileName.Length - num)
			Next
			Return text
		End Function

		Public Function SelectOutputFile(ByRef sFileName As String, ByRef sInitialDir As String, sDescList As String, sInitFileName As String, sExtension As String, sDialogTitle As String) As Boolean
			Dim saveFileDialog As SaveFileDialog = New SaveFileDialog()
			Dim result As Boolean
			Try
				Dim saveFileDialog2 As SaveFileDialog = saveFileDialog
				saveFileDialog2.Title = sDialogTitle
				saveFileDialog2.FileName = sInitFileName
				saveFileDialog2.Filter = sDescList
				saveFileDialog2.FilterIndex = 1
				saveFileDialog2.DefaultExt = sExtension
				saveFileDialog2.InitialDirectory = Conversions.ToString(RSWIN.GetInitialDir(sDescList, ""))
				saveFileDialog2.RestoreDirectory = False
				Dim dialogResult As DialogResult = saveFileDialog2.ShowDialog()
				If dialogResult <> DialogResult.Cancel Then
					sFileName = saveFileDialog2.FileName
					If Strings.Len(sExtension) > 0 And Strings.InStr(sFileName, ".PDF", CompareMethod.Binary) = 0 And Strings.InStr(sFileName, ".pdf", CompareMethod.Binary) = 0 And Strings.InStr(sFileName, ".XLS", CompareMethod.Binary) = 0 And Strings.InStr(sFileName, ".xls", CompareMethod.Binary) = 0 Then
						' The following expression was wrapped in a checked-expression
						Dim num As Short = CShort(Strings.InStrRev(sFileName, ".", -1, CompareMethod.Binary))
						If num = 0S Then
							sFileName += sExtension
						End If
					End If
					Dim text As String = Nothing
					Dim text2 As String = Nothing
					Dim str As String
					Dim str2 As String
					FILEIO.SplitPath(sFileName, str, str2, text, text2)
					text2 = Nothing
					text = Nothing
					FILEIO.MakePath(sInitialDir, str, str2, text2, text)
					RSWIN.WriteInitialDir(sFileName, str + str2)
					result = True
				Else
					result = False
				End If
			Catch ex As Exception
				Dim sMsg As String = "Error in SelectOutputFile: " + ex.Message
				Dim sMsgType As String = ""
				Dim bClosing As Boolean = False
				Dim dialogResult2 As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult2)
				result = False
			End Try
			Return result
		End Function

		Public Function SplitPath(ByRef sFullPathName As String, ByRef sDrive As String, ByRef sDir As String, ByRef sFile As String, ByRef sExt As String) As Boolean
			Dim asciiencoding As ASCIIEncoding = New ASCIIEncoding()
			If Not FILEIO.$STATIC$SplitPath$05210E10E10E10E10E$bInitialized Then
				FILEIO.$STATIC$SplitPath$05210E10E10E10E10E$iBackSlash = 92
				FILEIO.$STATIC$SplitPath$05210E10E10E10E10E$iColon = 58
				FILEIO.$STATIC$SplitPath$05210E10E10E10E10E$iPeriod = 46
				FILEIO.$STATIC$SplitPath$05210E10E10E10E10E$iSlash = 47
				FILEIO.$STATIC$SplitPath$05210E10E10E10E10E$bInitialized = True
			End If
			Dim result As Boolean = True
			Dim num As Integer = 0
			sDrive = ""
			sDir = ""
			sFile = ""
			sExt = ""
			Dim bytes As Byte() = asciiencoding.GetBytes(sFullPathName)
			If Strings.Len(sFullPathName) >= 2 AndAlso bytes(1) = FILEIO.$STATIC$SplitPath$05210E10E10E10E10E$iColon Then
				sDrive = Strings.Left(sFullPathName, 2)
				num = 2
			End If
			Dim num2 As Integer = Strings.Len(sFullPathName) - 1
			Dim num3 As Integer = num
			For i As Integer = num2 To num3 Step -1
				If bytes(i) = FILEIO.$STATIC$SplitPath$05210E10E10E10E10E$iSlash Or bytes(i) = FILEIO.$STATIC$SplitPath$05210E10E10E10E10E$iBackSlash Then
					sDir = Strings.Mid(sFullPathName, num + 1, i - num + 1)
					num = i + 1
					Exit For
				End If
			Next
			sFile = Strings.Mid(sFullPathName, num + 1)
			Dim num4 As Integer = Strings.Len(sFullPathName) - 1
			Dim num5 As Integer = num
			For i As Integer = num4 To num5 Step -1
				If bytes(i) = FILEIO.$STATIC$SplitPath$05210E10E10E10E10E$iPeriod Then
					sFile = Strings.Mid(sFullPathName, num + 1, i - num)
					sExt = Strings.Mid(sFullPathName, i + 1)
					Exit For
				End If
			Next
			Return result
		End Function

		Friend Function IsKindOfFile(frn As Short, sMagic As String) As Boolean
			' The following expression was wrapped in a checked-expression
			Dim num As Integer = CInt(FileSystem.LOF(CInt(frn)))
			Dim length As Integer = sMagic.Length
			If FileSystem.LOF(CInt(frn)) < CLng(sMagic.Length) Then
				Return False
			End If
			RSWIN_DESC.ThisMagic = Strings.Space(sMagic.Length)
			FileSystem.Seek(CInt(frn), 1L)
			FileSystem.FileGet(CInt(frn), RSWIN_DESC.ThisMagic, -1L, False)
			RSWIN_DESC.rst.ThisMagic = RSWIN_DESC.ThisMagic
			Return Operators.CompareString(RSWIN_DESC.ThisMagic, sMagic, False) = 0
		End Function

		Friend Function IsKindOfFile_BinaryReader(ByRef r As BinaryReader, sMagic As String) As Boolean
			Dim result As Boolean
			If r.BaseStream.Length < CLng(sMagic.Length) Then
				result = False
			Else
				RSWIN_DESC.ThisMagic = Strings.Space(sMagic.Length)
				r.BaseStream.Seek(0L, SeekOrigin.Begin)
				RSWIN_DESC.ThisMagic = r.ReadString()
				RSWIN_DESC.rst.ThisMagic = RSWIN_DESC.ThisMagic
				result = (Operators.CompareString(RSWIN_DESC.ThisMagic, sMagic, False) = 0)
			End If
			Return result
		End Function

		Public Function OpenTheFile(sFileName As String, iFileMode As Short, iRecLen As Short) As Short
			Dim num As Integer
			Dim num8 As Short
			Dim num9 As Integer
			Dim obj As Object
			Try
				ProjectData.ClearProjectError()
				num = 2
				Dim num2 As Short = CShort(FileSystem.FreeFile())
				Select Case iFileMode And 15S
					Case 0S
						Dim num3 As Short = iFileMode And 4080S
						If num3 = 0S Then
							FileSystem.FileOpen(CInt(num2), sFileName, OpenMode.Input, OpenAccess.[Default], OpenShare.[Default], -1)
						ElseIf num3 = 16S Then
							FileSystem.FileOpen(CInt(num2), sFileName, OpenMode.Input, OpenAccess.[Default], OpenShare.LockRead, -1)
						ElseIf num3 = 32S Then
							FileSystem.FileOpen(CInt(num2), sFileName, OpenMode.Input, OpenAccess.[Default], OpenShare.LockWrite, -1)
						ElseIf num3 = 48S Then
							FileSystem.FileOpen(CInt(num2), sFileName, OpenMode.Input, OpenAccess.[Default], OpenShare.LockReadWrite, -1)
						ElseIf num3 = 256S Then
							FileSystem.FileOpen(CInt(num2), sFileName, OpenMode.Input, OpenAccess.Read, OpenShare.[Default], -1)
						ElseIf num3 = 272S Then
							FileSystem.FileOpen(CInt(num2), sFileName, OpenMode.Input, OpenAccess.Read, OpenShare.LockRead, -1)
						ElseIf num3 = 288S Then
							FileSystem.FileOpen(CInt(num2), sFileName, OpenMode.Input, OpenAccess.Read, OpenShare.LockWrite, -1)
						Else
							If num3 <> 304S Then
								Throw ProjectData.CreateProjectError(54)
							End If
							FileSystem.FileOpen(CInt(num2), sFileName, OpenMode.Input, OpenAccess.Read, OpenShare.LockReadWrite, -1)
						End If
					Case 1S
						Dim num4 As Short = iFileMode And 4080S
						If num4 = 0S Then
							FileSystem.FileOpen(CInt(num2), sFileName, OpenMode.Output, OpenAccess.[Default], OpenShare.[Default], -1)
						ElseIf num4 = 16S Then
							FileSystem.FileOpen(CInt(num2), sFileName, OpenMode.Output, OpenAccess.[Default], OpenShare.LockRead, -1)
						ElseIf num4 = 32S Then
							FileSystem.FileOpen(CInt(num2), sFileName, OpenMode.Output, OpenAccess.[Default], OpenShare.LockWrite, -1)
						ElseIf num4 = 48S Then
							FileSystem.FileOpen(CInt(num2), sFileName, OpenMode.Output, OpenAccess.[Default], OpenShare.LockReadWrite, -1)
						ElseIf num4 = 512S Then
							FileSystem.FileOpen(CInt(num2), sFileName, OpenMode.Output, OpenAccess.Write, OpenShare.[Default], -1)
						ElseIf num4 = 528S Then
							FileSystem.FileOpen(CInt(num2), sFileName, OpenMode.Output, OpenAccess.Write, OpenShare.LockRead, -1)
						ElseIf num4 = 544S Then
							FileSystem.FileOpen(CInt(num2), sFileName, OpenMode.Output, OpenAccess.Write, OpenShare.LockWrite, -1)
						Else
							If num4 <> 560S Then
								Throw ProjectData.CreateProjectError(54)
							End If
							FileSystem.FileOpen(CInt(num2), sFileName, OpenMode.Output, OpenAccess.Write, OpenShare.LockReadWrite, -1)
						End If
					Case 2S
						Dim num5 As Short = iFileMode And 4080S
						If num5 = 0S Then
							FileSystem.FileOpen(CInt(num2), sFileName, OpenMode.Append, OpenAccess.[Default], OpenShare.[Default], -1)
						ElseIf num5 = 16S Then
							FileSystem.FileOpen(CInt(num2), sFileName, OpenMode.Append, OpenAccess.[Default], OpenShare.LockRead, -1)
						ElseIf num5 = 32S Then
							FileSystem.FileOpen(CInt(num2), sFileName, OpenMode.Append, OpenAccess.[Default], OpenShare.LockWrite, -1)
						ElseIf num5 = 48S Then
							FileSystem.FileOpen(CInt(num2), sFileName, OpenMode.Append, OpenAccess.[Default], OpenShare.LockReadWrite, -1)
						ElseIf num5 = 512S Then
							FileSystem.FileOpen(CInt(num2), sFileName, OpenMode.Append, OpenAccess.Write, OpenShare.[Default], -1)
						ElseIf num5 = 528S Then
							FileSystem.FileOpen(CInt(num2), sFileName, OpenMode.Append, OpenAccess.Write, OpenShare.LockRead, -1)
						ElseIf num5 = 544S Then
							FileSystem.FileOpen(CInt(num2), sFileName, OpenMode.Append, OpenAccess.Write, OpenShare.LockWrite, -1)
						ElseIf num5 = 560S Then
							FileSystem.FileOpen(CInt(num2), sFileName, OpenMode.Append, OpenAccess.Write, OpenShare.LockReadWrite, -1)
						ElseIf num5 = 768S Then
							FileSystem.FileOpen(CInt(num2), sFileName, OpenMode.Append, OpenAccess.ReadWrite, OpenShare.[Default], -1)
						ElseIf num5 = 784S Then
							FileSystem.FileOpen(CInt(num2), sFileName, OpenMode.Append, OpenAccess.ReadWrite, OpenShare.LockRead, -1)
						ElseIf num5 = 800S Then
							FileSystem.FileOpen(CInt(num2), sFileName, OpenMode.Append, OpenAccess.ReadWrite, OpenShare.LockWrite, -1)
						Else
							If num5 <> 816S Then
								Throw ProjectData.CreateProjectError(54)
							End If
							FileSystem.FileOpen(CInt(num2), sFileName, OpenMode.Append, OpenAccess.ReadWrite, OpenShare.LockReadWrite, -1)
						End If
					Case 3S
						Dim num6 As Short = iFileMode And 4080S
						If num6 = 0S Then
							FileSystem.FileOpen(CInt(num2), sFileName, OpenMode.Random, OpenAccess.[Default], OpenShare.[Default], CInt(iRecLen))
						ElseIf num6 = 16S Then
							FileSystem.FileOpen(CInt(num2), sFileName, OpenMode.Random, OpenAccess.[Default], OpenShare.LockRead, CInt(iRecLen))
						ElseIf num6 = 32S Then
							FileSystem.FileOpen(CInt(num2), sFileName, OpenMode.Random, OpenAccess.[Default], OpenShare.LockWrite, CInt(iRecLen))
						ElseIf num6 = 48S Then
							FileSystem.FileOpen(CInt(num2), sFileName, OpenMode.Random, OpenAccess.[Default], OpenShare.LockReadWrite, CInt(iRecLen))
						ElseIf num6 = 256S Then
							FileSystem.FileOpen(CInt(num2), sFileName, OpenMode.Random, OpenAccess.Read, OpenShare.[Default], CInt(iRecLen))
						ElseIf num6 = 272S Then
							FileSystem.FileOpen(CInt(num2), sFileName, OpenMode.Random, OpenAccess.Read, OpenShare.LockRead, CInt(iRecLen))
						ElseIf num6 = 288S Then
							FileSystem.FileOpen(CInt(num2), sFileName, OpenMode.Random, OpenAccess.Read, OpenShare.LockWrite, CInt(iRecLen))
						ElseIf num6 = 304S Then
							FileSystem.FileOpen(CInt(num2), sFileName, OpenMode.Random, OpenAccess.Read, OpenShare.LockReadWrite, CInt(iRecLen))
						ElseIf num6 = 512S Then
							FileSystem.FileOpen(CInt(num2), sFileName, OpenMode.Random, OpenAccess.Write, OpenShare.[Default], CInt(iRecLen))
						ElseIf num6 = 528S Then
							FileSystem.FileOpen(CInt(num2), sFileName, OpenMode.Random, OpenAccess.Write, OpenShare.LockRead, CInt(iRecLen))
						ElseIf num6 = 544S Then
							FileSystem.FileOpen(CInt(num2), sFileName, OpenMode.Random, OpenAccess.Write, OpenShare.LockWrite, CInt(iRecLen))
						ElseIf num6 = 560S Then
							FileSystem.FileOpen(CInt(num2), sFileName, OpenMode.Random, OpenAccess.Write, OpenShare.LockReadWrite, CInt(iRecLen))
						ElseIf num6 = 768S Then
							FileSystem.FileOpen(CInt(num2), sFileName, OpenMode.Random, OpenAccess.ReadWrite, OpenShare.[Default], CInt(iRecLen))
						ElseIf num6 = 784S Then
							FileSystem.FileOpen(CInt(num2), sFileName, OpenMode.Random, OpenAccess.ReadWrite, OpenShare.LockRead, CInt(iRecLen))
						ElseIf num6 = 800S Then
							FileSystem.FileOpen(CInt(num2), sFileName, OpenMode.Random, OpenAccess.ReadWrite, OpenShare.LockWrite, CInt(iRecLen))
						Else
							If num6 <> 816S Then
								Throw ProjectData.CreateProjectError(54)
							End If
							FileSystem.FileOpen(CInt(num2), sFileName, OpenMode.Random, OpenAccess.ReadWrite, OpenShare.LockReadWrite, CInt(iRecLen))
						End If
					Case 4S
						Dim num7 As Short = iFileMode And 4080S
						If num7 = 0S Then
							FileSystem.FileOpen(CInt(num2), sFileName, OpenMode.Binary, OpenAccess.[Default], OpenShare.[Default], -1)
						ElseIf num7 = 16S Then
							FileSystem.FileOpen(CInt(num2), sFileName, OpenMode.Binary, OpenAccess.[Default], OpenShare.LockRead, -1)
						ElseIf num7 = 32S Then
							FileSystem.FileOpen(CInt(num2), sFileName, OpenMode.Binary, OpenAccess.[Default], OpenShare.LockWrite, -1)
						ElseIf num7 = 48S Then
							FileSystem.FileOpen(CInt(num2), sFileName, OpenMode.Binary, OpenAccess.[Default], OpenShare.LockReadWrite, -1)
						ElseIf num7 = 256S Then
							FileSystem.FileOpen(CInt(num2), sFileName, OpenMode.Binary, OpenAccess.Read, OpenShare.[Default], -1)
						ElseIf num7 = 272S Then
							FileSystem.FileOpen(CInt(num2), sFileName, OpenMode.Binary, OpenAccess.Read, OpenShare.LockRead, -1)
						ElseIf num7 = 288S Then
							FileSystem.FileOpen(CInt(num2), sFileName, OpenMode.Binary, OpenAccess.Read, OpenShare.LockWrite, -1)
						ElseIf num7 = 304S Then
							FileSystem.FileOpen(CInt(num2), sFileName, OpenMode.Binary, OpenAccess.Read, OpenShare.LockReadWrite, -1)
						ElseIf num7 = 512S Then
							FileSystem.FileOpen(CInt(num2), sFileName, OpenMode.Binary, OpenAccess.Write, OpenShare.[Default], -1)
						ElseIf num7 = 528S Then
							FileSystem.FileOpen(CInt(num2), sFileName, OpenMode.Binary, OpenAccess.Write, OpenShare.LockRead, -1)
						ElseIf num7 = 544S Then
							FileSystem.FileOpen(CInt(num2), sFileName, OpenMode.Binary, OpenAccess.Write, OpenShare.LockWrite, -1)
						ElseIf num7 = 560S Then
							FileSystem.FileOpen(CInt(num2), sFileName, OpenMode.Binary, OpenAccess.Write, OpenShare.LockReadWrite, -1)
						ElseIf num7 = 768S Then
							FileSystem.FileOpen(CInt(num2), sFileName, OpenMode.Binary, OpenAccess.ReadWrite, OpenShare.[Default], -1)
						ElseIf num7 = 784S Then
							FileSystem.FileOpen(CInt(num2), sFileName, OpenMode.Binary, OpenAccess.ReadWrite, OpenShare.LockRead, -1)
						ElseIf num7 = 800S Then
							FileSystem.FileOpen(CInt(num2), sFileName, OpenMode.Binary, OpenAccess.ReadWrite, OpenShare.LockWrite, -1)
						Else
							If num7 <> 816S Then
								Throw ProjectData.CreateProjectError(54)
							End If
							FileSystem.FileOpen(CInt(num2), sFileName, OpenMode.Binary, OpenAccess.ReadWrite, OpenShare.LockReadWrite, -1)
						End If
				End Select
				num8 = num2
				GoTo IL_6E5
				IL_61D:
				Dim number As Integer = Information.Err().Number
				If number <> 53 Then
					GoTo IL_644
				End If
				Util.FatalError("File not found: " + sFileName)
				GoTo IL_6E5
				IL_644:
				Util.FatalError(String.Concat(New String() { "OpenTheFile(sFileName=", sFileName, ", iFileMode=", Conversions.ToString(CInt(iFileMode)), ", iRecLen=", Conversions.ToString(CInt(iRecLen)), "): ", Conversion.ErrorToString() }))
				GoTo IL_6E5
				IL_6A0:
				num9 = -1
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_6B6:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num9 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_6A0
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_6E5:
			Dim result As Short = num8
			If num9 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		Public Sub CheckSurveyOrder()
			Dim num As Integer
			Dim num4 As Integer
			Dim obj2 As Object
			Try
				ProjectData.ClearProjectError()
				num = 2
				If RSWIN_DESC.mdsDeviationProfile IsNot Nothing AndAlso RSWIN_DESC.mdsDeviationProfile.Tables(0).Rows.Count > 1 Then
					Dim enumerator As IEnumerator = RSWIN_DESC.mdsDeviationProfile.Tables(0).Rows.GetEnumerator()
					While enumerator.MoveNext()
						Dim obj As Object = enumerator.Current
						Dim dataRow As DataRow = CType(obj, DataRow)
						Dim num2 As Single = Conversions.ToSingle(dataRow("Depth"))
						Dim num3 As Single = num2
						If num2 > num3 Then
						End If
					End While
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End If
				IL_9D:
				GoTo IL_E4
				IL_9F:
				num4 = -1
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_B5:
			Catch obj3 When endfilter(TypeOf obj2 Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj3, Exception)
				GoTo IL_9F
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_E4:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		Private $STATIC$SplitPath$05210E10E10E10E10E$iBackSlash As Byte

		Private $STATIC$SplitPath$05210E10E10E10E10E$iColon As Byte

		Private $STATIC$SplitPath$05210E10E10E10E10E$iPeriod As Byte

		Private $STATIC$SplitPath$05210E10E10E10E10E$iSlash As Byte

		Private $STATIC$SplitPath$05210E10E10E10E10E$bInitialized As Boolean
	End Module
End Namespace
