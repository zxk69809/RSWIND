Imports System
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	Friend NotInheritable Module LOADCBL
		Public Sub LoadCBalanceFile(sCBFile As String, ByRef bFileLoaded As Boolean)
			Dim num2 As Integer
			Dim num11 As Integer
			Dim obj As Object
			Try
				IL_00:
				Dim num As Integer = 1
				bFileLoaded = False
				IL_06:
				ProjectData.ClearProjectError()
				num2 = 2
				IL_0E:
				num = 3
				Dim num3 As Integer = FileSystem.FreeFile()
				IL_17:
				num = 4
				FileSystem.FileOpen(num3, sCBFile, OpenMode.Binary, OpenAccess.Read, OpenShare.LockWrite, -1)
				IL_26:
				num = 5
				Dim text As String
				If FileSystem.LOF(num3) >= CLng(Strings.Len(text)) Then
					GoTo IL_55
				End If
				IL_39:
				num = 6
				FileSystem.FileClose(New Integer() { num3 })
				IL_50:
				GoTo IL_6B3
				IL_55:
				num = 9
				text = New String(" "c, 11)
				IL_64:
				num = 10
				FileSystem.FileGet(num3, text, -1L, False)
				IL_73:
				num = 11
				If Operators.CompareString(text, RSWIN_DESC.CBMagic, False) = 0 Then
					GoTo IL_A4
				End If
				IL_87:
				num = 12
				FileSystem.FileClose(New Integer() { num3 })
				IL_9F:
				GoTo IL_6B3
				IL_A4:
				num = 15
				Dim num4 As Short
				FileSystem.FileGet(num3, num4, -1L)
				IL_B2:
				num = 16
				If num4 <= 5S Then
					GoTo IL_D8
				End If
				IL_BB:
				num = 17
				FileSystem.FileClose(New Integer() { num3 })
				IL_D3:
				GoTo IL_6B3
				IL_D8:
				num = 20
				Dim num5 As Short = num4
				IL_E0:
				num = 23
				If num5 < 2S Then
					GoTo IL_46A
				End If
				IL_EC:
				num = 25
				If num5 >= 5S Then
					GoTo IL_25B
				End If
				IL_F8:
				num = 26
				Dim num12 As Integer
				FileSystem.Seek(num3, FileSystem.Seek(num3) + 2L)
				IL_10B:
				num = 27
				FileSystem.Seek(num3, FileSystem.Seek(num3) + 40L)
				IL_11F:
				num = 28
				FileSystem.Seek(num3, FileSystem.Seek(num3) + 40L)
				IL_133:
				num = 29
				FileSystem.Seek(num3, FileSystem.Seek(num3) + 40L)
				IL_147:
				num = 30
				FileSystem.Seek(num3, FileSystem.Seek(num3) + 20L)
				IL_15B:
				num = 31
				FileSystem.Seek(num3, FileSystem.Seek(num3) + 109L)
				IL_16F:
				num = 32
				If num4 < 3S Then
					GoTo IL_18B
				End If
				IL_178:
				num = 33
				FileSystem.Seek(num3, FileSystem.Seek(num3) + 2L)
				IL_18B:
				num = 35
				FileSystem.Seek(num3, FileSystem.Seek(num3) + 68L)
				IL_19F:
				num = 36
				Dim num6 As Integer = 1
				Do
					IL_1A5:
					num = 37
					FileSystem.Seek(num3, FileSystem.Seek(num3) + 158L)
					IL_1BC:
					num = 38
					Dim num7 As Integer = 1
					Do
						IL_1C3:
						num = 39
						FileSystem.Seek(num3, FileSystem.Seek(num3) + 36L)
						IL_1D7:
						num = 40
						num7 += 1
					Loop While num7 <= 3
					IL_1E6:
					num = 41
					FileSystem.Seek(num3, FileSystem.Seek(num3) + 4L)
					IL_1F9:
					num = 42
					num6 += 1
				Loop While num6 <= 4
				IL_205:
				num = 43
				FileSystem.Seek(num3, FileSystem.Seek(num3) + 4L)
				IL_218:
				num = 44
				If num4 < 2S Then
					GoTo IL_24F
				End If
				IL_221:
				num = 45
				Dim fileNumber As Integer = num3
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				Dim cRODSTAR As cRODSTAR = rst
				Dim index As Integer = 2
				Dim value As Single = cRODSTAR.get_M(index)
				FileSystem.FileGet(fileNumber, value, -1L)
				rst.set_M(index, value)
				IL_24F:
				num = 47
				bFileLoaded = True
				IL_256:
				GoTo IL_46A
				IL_25B:
				num = 50
				Dim num8 As Short
				FileSystem.FileGet(num3, num8, -1L)
				IL_269:
				num = 51
				FileSystem.Seek(num3, FileSystem.Seek(num3) + 40L)
				IL_27D:
				num = 52
				FileSystem.Seek(num3, FileSystem.Seek(num3) + 40L)
				IL_291:
				num = 53
				FileSystem.Seek(num3, FileSystem.Seek(num3) + 40L)
				IL_2A5:
				num = 54
				FileSystem.Seek(num3, FileSystem.Seek(num3) + 20L)
				IL_2B9:
				num = 55
				FileSystem.Seek(num3, FileSystem.Seek(num3) + 3L)
				IL_2CC:
				num = 56
				FileSystem.Seek(num3, FileSystem.Seek(num3) + 40L)
				IL_2E0:
				num = 57
				FileSystem.FileGet(num3, num8, -1L)
				IL_2EE:
				num = 58
				FileSystem.Seek(num3, FileSystem.Seek(num3) + 16L)
				IL_302:
				num = 59
				FileSystem.Seek(num3, FileSystem.Seek(num3) + 16L)
				IL_316:
				num = 60
				FileSystem.Seek(num3, FileSystem.Seek(num3) + 16L)
				IL_32A:
				num = 61
				FileSystem.Seek(num3, FileSystem.Seek(num3) + 16L)
				IL_33E:
				num = 62
				FileSystem.Seek(num3, FileSystem.Seek(num3) + 12L)
				IL_352:
				num = 63
				Dim num9 As Single
				FileSystem.FileGet(num3, num9, -1L)
				IL_360:
				num = 64
				FileSystem.FileGet(num3, num9, -1L)
				IL_36E:
				num = 65
				FileSystem.FileGet(num3, num9, -1L)
				IL_37C:
				num = 66
				FileSystem.FileGet(num3, num9, -1L)
				IL_38A:
				num = 67
				FileSystem.FileGet(num3, num9, -1L)
				IL_398:
				num = 68
				FileSystem.FileGet(num3, num8, -1L)
				IL_3A6:
				num = 69
				num6 = 1
				Dim num10 As Single
				Do
					IL_3AC:
					num = 70
					FileSystem.Seek(num3, FileSystem.Seek(num3) + 158L)
					IL_3C3:
					num = 71
					Dim num7 As Integer = 1
					Do
						IL_3CA:
						num = 72
						FileSystem.Seek(num3, FileSystem.Seek(num3) + 36L)
						IL_3DE:
						num = 73
						num7 += 1
					Loop While num7 <= 3
					IL_3ED:
					num = 74
					FileSystem.FileGet(num3, num10, -1L)
					IL_3FB:
					num = 75
					num6 += 1
				Loop While num6 <= 4
				IL_407:
				num = 76
				FileSystem.FileGet(num3, num10, -1L)
				IL_415:
				num = 77
				Dim fileNumber2 As Integer = num3
				rst = RSWIN_DESC.rst
				Dim cRODSTAR2 As cRODSTAR = rst
				index = 2
				value = cRODSTAR2.get_M(index)
				FileSystem.FileGet(fileNumber2, value, -1L)
				rst.set_M(index, value)
				IL_443:
				num = 78
				RSWIN_DESC.rst.UnknownM = (RSWIN_DESC.rst.get_M(2) = 0F)
				IL_463:
				num = 79
				bFileLoaded = True
				IL_46A:
				num = 81
				FileSystem.FileClose(New Integer() { num3 })
				IL_482:
				GoTo IL_6B3
				IL_487:
				num = 83
				Dim number As Integer = Information.Err().Number
				IL_497:
				num = 86
				If number <> 53 AndAlso number <> 71 AndAlso number <> 76 Then
					GoTo IL_4CA
				End If
				IL_4AD:
				num = 87
				ProjectData.ClearProjectError()
				If num11 <> 0 Then
					GoTo IL_4E3
				End If
				Throw ProjectData.CreateProjectError(-2146828268)
				IL_4C5:
				GoTo IL_6B3
				IL_4CA:
				num = 91
				Throw ProjectData.CreateProjectError(Information.Err().Number)
				IL_4DE:
				GoTo IL_6B3
				IL_4E3:
				num12 = num11
				GoTo IL_4EB
				IL_4E7:
				num12 = num11 + 1
				IL_4EB:
				num11 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num12)
				IL_66B:
				GoTo IL_6A8
				IL_66D:
				num11 = num
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num2)
				IL_684:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num2 <> 0 And num11 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_66D
			End Try
			IL_6A8:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_6B3:
			If num11 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub
	End Module
End Namespace
