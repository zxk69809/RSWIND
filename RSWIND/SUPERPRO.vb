Imports System
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	Friend  Module SUPERPRO
		Public Function ConvHexData(ByRef thisString As String, ByRef OutData As Short) As Short
			Try
				' The following expression was wrapped in a checked-expression
				OutData = CShort(Conversions.ToInteger("&H" + thisString))
			Catch ex As Exception
				Return -1S
			End Try
			Return 0S
		End Function

		Private Function BitReverse(nValue As Integer) As Integer
			Dim num As Integer = 0
			Dim num5 As Integer = 0
			Dim num6 As Integer = 0   ' 异常标志

			Try
				Dim app As CThetaApp = RSWIN.App
				Dim text As String = "MSuperproClass.BitReverse"
				app.TrTraceIn(text)

				If Not RSWIN.App.InDesign() Then
					ProjectData.ClearProjectError()
					num = 2
				End If

				Dim num2 As Integer = nValue And 32767
				If (nValue And -32768) <> 0 Then
					num2 += 32768
				End If

				Dim num3 As Integer = 0
				Dim num4 As Integer = 0
				Do
					num3 *= 2
					num3 = num3 Or (num2 And 1)
					num2 \= 2
					num4 += 1
				Loop While num4 <= 15

				If (num3 And -32768) <> 0 Then
					num3 -= 65536
				End If

				num5 = num3

				Dim app2 As CThetaApp = RSWIN.App
				app2.TrTraceOut(text)

			Catch ex As Exception When num <> 0 AndAlso num6 = 0
				num6 = -1
			End Try

			If num6 <> 0 Then
				ProjectData.ClearProjectError()
			ElseIf num = 0 Then
				Throw ProjectData.CreateProjectError(-2146828237)
			End If

			Return num5
		End Function


		Public Sub NewCheckSentinel(Optional bExit As Boolean = True)
			Try
				If Not RSWIN_DESC.bDoAutoSentinelChecks AndAlso Not RSWIN_DESC.gbDemoMode Then
					Application.DoEvents()
					RSWIN_DESC.frmMain.mTLM32.ReCheckLicense_Thread()
					If Not RSWIN_DESC.frmMain.mTLM32.SentinelFound Then
						RSWIN_DESC.frmMain.SentinelUnplugged(bExit)
					End If
					Application.DoEvents()
					Application.DoEvents()
				End If
			Catch ex As Exception
			End Try
		End Sub

		Public Sub CheckSentinel(bAbortIfNotFound As Short, ByRef bOK As Short)
			Dim num As Integer = 0
			Dim num3 As Integer = 0   ' 异常标志

			Try
				If Not RSWIN_DESC.bCheck4Sentinel Then
					bOK = -1S
				Else
					Dim app As CThetaApp = RSWIN.App
					Dim text As String = "MSuperproClass.CheckSentinel"
					app.TrTraceIn(text)

					If Not RSWIN.App.InDesign() Then
						ProjectData.ClearProjectError()
						num = 2
					End If

					If SUPERPRO.CheckSentinelThetaSerial = 0 Then
						Dim num2 As Short = SUPERPRO.TestSentinel(-1S)
						SUPERPRO.CheckSentinelThetaSerial = SUPERPRO.SentinelSerialNumber()
						bOK = -1S
					Else
						bOK = If(SUPERPRO.CheckSentinelThetaSerial = SUPERPRO.SentinelSerialNumber(), 1S, 0S)
					End If

					Dim text3 As String
					If (Not bOK AndAlso bAbortIfNotFound) <> 0S Then
						text = "Status"
						Dim text2 As String = "Sentinel Failure"
						text3 = Conversions.ToString(True)
						RSWIN.WriteRegProfileString(text, text2, text3, "")

						If RSWIN_DESC.bCheck4Sentinel Then
							Util.FatalError("Your Sentinel does not appear to be connected.")
						End If
					Else
						text3 = "Status"
						Dim text2 As String = "Sentinel Failure"
						text = Conversions.ToString(False)
						RSWIN.WriteRegProfileString(text3, text2, text, "")
					End If

					Dim app2 As CThetaApp = RSWIN.App
					text3 = "MSuperproClass.CheckSentinel"
					app2.TrTraceOut(text3)
				End If

			Catch ex As Exception When num <> 0 AndAlso num3 = 0
				' 等价于 IL_E1
				num3 = -1
			End Try

			' ===== 原 IL_126 逻辑 =====
			If num3 <> 0 Then
				ProjectData.ClearProjectError()
			ElseIf num = 0 Then
				Throw ProjectData.CreateProjectError(-2146828237)
			End If
		End Sub


		Public Sub CloseSentinel()
			Dim num As Integer = 0
			Dim num2 As Integer = 0   ' 异常标志

			Try
				Dim app As CThetaApp = RSWIN.App
				Dim text As String = "MSuperproClass.CloseSentinel"
				app.TrTraceIn(text)

				If Not RSWIN.App.InDesign() Then
					ProjectData.ClearProjectError()
					num = 2
				End If

				Dim app2 As CThetaApp = RSWIN.App
				text = "MSuperproClass.CloseSentinel"
				app2.TrTraceOut(text)

			Catch ex As Exception When num <> 0 AndAlso num2 = 0
				num2 = -1
			End Try

			If num2 <> 0 Then
				ProjectData.ClearProjectError()
			ElseIf num = 0 Then
				Throw ProjectData.CreateProjectError(-2146828237)
			End If
		End Sub


		Public Sub InitSentinel(ByRef sProgram As String, bAbortIfNotFound As Boolean, ByRef bOK As Boolean)
			Dim num As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				If Not RSWIN_DESC.bCheck4Sentinel Then
					bOK = True
				Else
					Dim app As CThetaApp = RSWIN.App
					Dim text As String = "MSuperproClass.InitSentinel"
					app.TrTraceIn(text)
					If Not RSWIN.App.InDesign() Then
						ProjectData.ClearProjectError()
						num = 2
					End If
					bOK = True
					If Not SUPERPRO.bInitialized Then
						Dim str As String = sProgram
						Dim text2 As String = RSWIN.App.Path + "\" + str + ".EXE"
						SUPERPRO.msLogFile = RSWIN.App.Path + "\" + str + ".SSP"
						If Not FILEUTIL.FileExists(SUPERPRO.msLogFile) Then
							SUPERPRO.msLogFile = ""
						End If
						Dim packet As Byte() = SuperproLib.SuperproClass.packet
						Dim num2 As Integer = 4112
						Dim num3 As Short = SuperproLib.SuperproClass.RNBOsproFormatPacket(packet, num2)
						SUPERPRO.LogResult(0S, CInt(Convert.ToInt16(num3)))
						If num3 <> 0S Then
							bOK = False
						Else
							num3 = SuperproLib.SuperproClass.RNBOsproInitialize(SuperproLib.SuperproClass.packet)
							SUPERPRO.LogResult(1S, CInt(Convert.ToInt16(num3)))
							If num3 <> 0S Then
								bOK = False
							Else
								num3 = SuperproLib.SuperproClass.RNBOsproFindFirstUnit(SuperproLib.SuperproClass.packet, 38690)
								SUPERPRO.LogResult(4S, CInt(Convert.ToInt16(num3)))
								If num3 <> 0S Then
									bOK = False
								End If
							End If
							SUPERPRO.bInitialized = True
						End If
					End If
					Dim text4 As String
					If bOK Then
						SUPERPRO.msProgramName = sProgram
						bOK = (SUPERPRO.TestSentinel(If((-If((bAbortIfNotFound > False), 1S, 0S)), 1S, 0S)) <> 0S)
					ElseIf bAbortIfNotFound Then
						text = "Status"
						Dim text3 As String = "Sentinel Failure"
						text4 = Conversions.ToString(True)
						RSWIN.WriteRegProfileString(text, text3, text4, "")
						If RSWIN_DESC.bCheck4Sentinel Then
							Util.FatalError("Your Sentinel does not appear to be connected.")
						End If
					End If
					Dim app2 As CThetaApp = RSWIN.App
					text4 = "MSuperproClass.InitSentinel"
					app2.TrTraceOut(text4)
				End If
				IL_175:
				GoTo IL_1BC
				IL_177:
				num4 = -1
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_18D:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_177
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_1BC:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		Public Sub LoadWaterSpWt(ByRef WaterSpWt As Single)
			Dim num As Integer
			Dim num7 As Integer
			Dim obj As Object
			Try
				Dim app As CThetaApp = RSWIN.App
				Dim text As String = "MSuperproClass.LoadWaterSpWt"
				app.TrTraceIn(text)
				If Not RSWIN.App.InDesign() Then
					ProjectData.ClearProjectError()
					num = 2
				End If
				WaterSpWt = 0F
				Dim flag As Boolean = False
				Dim flag2 As Boolean = flag
				Dim wAddr As Integer = 0
				Dim num3 As Integer
				Dim num2 As Integer = num3
				If flag2 <> (SUPERPRO.ReadCell(wAddr, num2) = 0S) Then
					Dim flag3 As Boolean = flag
					Dim wAddr2 As Integer = 1
					Dim num4 As Integer
					num2 = num4
					If flag3 <> (SUPERPRO.ReadCell(wAddr2, num2) = 0S) Then
						Dim flag4 As Boolean = flag
						Dim wAddr3 As Integer = 8
						Dim num5 As Integer
						num2 = num5
						If flag4 <> (SUPERPRO.ReadCell(wAddr3, num2) = 0S) Then
							Dim flag5 As Boolean = flag
							Dim wAddr4 As Integer = 9
							Dim num6 As Integer
							num2 = num6
							If flag5 <> (SUPERPRO.ReadCell(wAddr4, num2) = 0S) Then
								num5 = num5 Xor SUPERPRO.BitReverse(num4)
								num6 = num6 Xor SUPERPRO.BitReverse(num3)
								num5 = num5 Xor SUPERPRO.BitReverse(num4)
								num6 = num6 Xor SUPERPRO.BitReverse(num3)
								WaterSpWt = Util.CVS(Util.MKI(num5) + Util.MKI(num6))
								If WaterSpWt = 0F Then
									WaterSpWt = 62.4F
								End If
							End If
						End If
					End If
				End If
				Dim app2 As CThetaApp = RSWIN.App
				text = "MSuperproClass.LoadWaterSpWt"
				app2.TrTraceOut(text)
				IL_E6:
				GoTo IL_12D
				IL_E8:
				num7 = -1
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_FE:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num7 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_E8
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_12D:
			If num7 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		Private Sub LogResult(iOpCode As Short, iErrCode As Integer)
			Dim num As Integer
			Dim num3 As Integer
			Dim obj As Object
			Try
				Dim app As CThetaApp = RSWIN.App
				Dim text As String = "MSuperproClass.LogResult"
				app.TrTraceIn(text)
				If Not RSWIN.App.InDesign() Then
					ProjectData.ClearProjectError()
					num = 2
				End If
				Dim text2 As String
				Select Case iOpCode
					Case 0S
						text2 = "op_formatpacket"
					Case 1S
						text2 = "op_initialize"
					Case 2S
						text2 = "op_get_extended_status"
					Case 3S
						text2 = "op_get_version"
					Case 4S
						text2 = "op_find_first_unit"
					Case 5S
						text2 = "op_find_next_unit"
					Case 6S
						text2 = "op_read"
					Case 7S
						text2 = "op_extended_read"
					Case 8S
						text2 = "op_write"
					Case 9S
						text2 = "op_overwrite"
					Case 10S
						text2 = "op_decrement"
					Case 11S
						text2 = "op_activate"
					Case 12S
						text2 = "op_query"
				End Select
				Dim text3 As String
				Select Case Convert.ToInt32(iErrCode)
					Case 0
						text3 = "SP_SUCCESS"
						GoTo IL_2E3
					Case 1
						text3 = "SP_INVALID_FUNCTION_CODE"
						GoTo IL_2E3
					Case 2
						text3 = "SP_INVALID_PACKET"
						GoTo IL_2E3
					Case 3
						text3 = "SP_UNIT_NOT_FOUND"
						GoTo IL_2E3
					Case 4
						text3 = "SP_ACCESS_DENIED"
						GoTo IL_2E3
					Case 5
						text3 = "SP_INVALID_MEMORY_ADDRESS"
						GoTo IL_2E3
					Case 6
						text3 = "SP_INVALID_ACCESS_CODE"
						GoTo IL_2E3
					Case 7
						text3 = "SP_PORT_IS_BUSY"
						GoTo IL_2E3
					Case 8
						text3 = "SP_WRITE_NOT_READY"
						GoTo IL_2E3
					Case 9
						text3 = "SP_NO_PORT_INSTALLED"
						GoTo IL_2E3
					Case 10
						text3 = "SP_ALREADY_ZERO"
						GoTo IL_2E3
					Case 12
						text3 = "SP_DRIVER_NOT_INSTALLED"
						GoTo IL_2E3
					Case 13
						text3 = "SP_COMMUNICATIONS_ERROR"
						GoTo IL_2E3
					Case 18
						text3 = "SP_VERSION_NOT_SUPPORTED"
						GoTo IL_2E3
					Case 19
						text3 = "SP_OS_ENV_NOT_SUPPORTED"
						GoTo IL_2E3
					Case 20
						text3 = "SP_QUERY_TOO_LONG"
						GoTo IL_2E3
					Case 30
						text3 = "SP_DRIVER_IS_BUSY"
						GoTo IL_2E3
					Case 31
						text3 = "SP_PORT_ALLOCATION_FAILURE"
						GoTo IL_2E3
					Case 32
						text3 = "SP_PORT_RELEASE_FAILURE"
						GoTo IL_2E3
					Case 39
						text3 = "SP_AQUIRE_PORT_TIMEOUT"
						GoTo IL_2E3
					Case 42
						text3 = "SP_SIGNAL_NOT_SUPPORTED"
						GoTo IL_2E3
					Case 57
						text3 = "SP_INIT_NOT_CALLED"
						GoTo IL_2E3
					Case 58
						text3 = "SP_DRIVER_TYPE_NOT_SUPPORTED"
						GoTo IL_2E3
					Case 59
						text3 = "SP_FAIL_ON_DRIVER_COMM"
						GoTo IL_2E3
				End Select
				If iErrCode.CompareTo(0) > 0 Then
					text3 = "return code " + iErrCode.ToString()
				Else
					text3 = "error " + iErrCode.ToString()
				End If
				IL_2E3:
				If Strings.Len(SUPERPRO.msLogFile) > 0 Then
					Dim num2 As Integer = FileSystem.FreeFile()
					FileSystem.FileOpen(num2, SUPERPRO.msLogFile, OpenMode.Append, OpenAccess.Write, OpenShare.LockWrite, -1)
					FileSystem.PrintLine(num2, New Object() { String.Concat(New String() { Conversions.ToString(DateAndTime.Now), " ", text2, ": ", text3, " (", iErrCode.ToString(), ")" }) })
					FileSystem.FileClose(New Integer() { num2 })
				End If
				Dim app2 As CThetaApp = RSWIN.App
				text = "MSuperproClass.LogResult"
				app2.TrTraceOut(text)
				IL_39A:
				GoTo IL_3E1
				IL_39C:
				num3 = -1
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_3B2:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num3 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_39C
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_3E1:
			If num3 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		Private Function ReadCell(wAddr As Integer, ByRef wData As Integer) As Short
			Dim app As CThetaApp = RSWIN.App
			Dim text As String = "MSuperproClass.ReadCell"
			app.TrTraceIn(text)
			Dim num As Integer = wAddr
			Dim num2 As Integer = wData
			Dim num3 As Short = 1S
			Dim result As Short
			Do
				Try
					Dim num4 As Short = SuperproLib.SuperproClass.RNBOsproRead(SuperproLib.SuperproClass.packet, num, num2)
					wAddr = num
					wData = num2
					If wData > 32767 Then
						wData -= 65536
					End If
					SUPERPRO.LogResult(6S, CInt(Convert.ToInt16(num4)))
					result = num4
					Select Case Convert.ToInt32(num4)
						Case 0
							GoTo IL_99
						Case 4
							GoTo IL_99
					End Select
					SUPERPRO.LogResult(6S, CInt((-num3)))
				Catch ex As Exception
				End Try
				num3 += 1S
			Loop While num3 <= 5S
			IL_99:
			Dim app2 As CThetaApp = RSWIN.App
			text = "MSuperproClass.ReadCell"
			app2.TrTraceOut(text)
			Return result
		End Function

		Public Function SentinelRunsRemaining() As Object
			Dim num As Integer
			Dim obj As Object
			Dim num3 As Integer
			Dim obj2 As Object
			Try
				Dim app As CThetaApp = RSWIN.App
				Dim text As String = "MSuperproClass.SentinelRunsRemaining"
				app.TrTraceIn(text)
				If Not RSWIN.App.InDesign() Then
					ProjectData.ClearProjectError()
					num = 2
				End If
				obj = DBNull.Value
				Dim flag As Boolean = False
				Dim num2 As Integer
				If flag <> (SUPERPRO.ReadCell(60, num2) = 4S) Then
					If flag <> (SUPERPRO.ReadCell(59, num2) = 0S) Then
						obj = num2
					End If
				End If
				Dim app2 As CThetaApp = RSWIN.App
				text = "MSuperproClass.SentinelRunsRemaining"
				app2.TrTraceOut(text)
				IL_6B:
				GoTo IL_B2
				IL_6D:
				num3 = -1
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_83:
			Catch obj3 When endfilter(TypeOf obj2 Is Exception And num <> 0 And num3 = 0)
				Dim ex As Exception = CType(obj3, Exception)
				GoTo IL_6D
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_B2:
			Dim result As Object = obj
			If num3 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		Public Function SentinelSerialNumber() As Integer
			Dim result As Integer
			Try
				Dim app As CThetaApp = RSWIN.App
				Dim text As String = "MSuperproClass.SentinelSerialNumber"
				app.TrTraceIn(text)
				RSWIN.App.InDesign()
				result = 0
				Dim flag As Boolean = False
				Dim nValue As Integer
				If flag <> (SUPERPRO.ReadCell(0, nValue) = 0S) Then
					Dim nValue2 As Integer
					If flag <> (SUPERPRO.ReadCell(1, nValue2) = 0S) Then
						Dim num As Integer
						If flag <> (SUPERPRO.ReadCell(10, num) = 0S) Then
							result = SUPERPRO.BitReverse(num Xor SUPERPRO.BitReverse(nValue2) Xor SUPERPRO.BitReverse(nValue))
						End If
					End If
				End If
				Dim app2 As CThetaApp = RSWIN.App
				text = "MSuperproClass.SentinelSerialNumber"
				app2.TrTraceOut(text)
			Catch ex As Exception
				Dim sMsg As String = "Error in SentinelSerialNumber: " + ex.Message
				Dim sMsgType As String = ""
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
			End Try
			Return result
		End Function

		Public Function TestSentinel(bAbortIfNotFound As Short) As Short
			Dim num As Integer
			Dim num11 As Short
			Dim num12 As Integer
			Dim obj As Object
			Try
				Dim app As CThetaApp = RSWIN.App
				Dim text As String = "MSuperproClass.TestSentinel"
				app.TrTraceIn(text)
				If Not RSWIN.App.InDesign() Then
					ProjectData.ClearProjectError()
					num = 2
				End If
				Dim app2 As CThetaApp = RSWIN.App
				text = "MSuperproClass.TestSentinel"
				app2.TrTraceIn(text)
				If Not RSWIN.App.InDesign() Then
					ProjectData.ClearProjectError()
					num = 3
				End If
				Dim num2 As Short = 0S
				If(bAbortIfNotFound And 4095S) = 3564S Then
					num2 = -1S
					bAbortIfNotFound = If((-If((((bAbortIfNotFound And -4096S) <> 0S) > False), 1S, 0S)), 1S, 0S)
				End If
				Dim num3 As Short = 0S
				Dim flag As Boolean = False
				Dim nValue As Integer
				Dim [string] As String
				Dim num9 As Integer
				If flag <> (SUPERPRO.ReadCell(0, nValue) = 0S) Then
					Dim nValue2 As Integer
					If flag <> (SUPERPRO.ReadCell(1, nValue2) = 0S) Then
						Dim num4 As Integer
						If flag <> (SUPERPRO.ReadCell(10, num4) = 0S) Then
							num3 = -1S
							Dim num5 As Integer = SUPERPRO.BitReverse(nValue2)
							Dim num6 As Integer = SUPERPRO.BitReverse(nValue)
							[string] = Strings.Space(96)
							Dim num7 As Short = 0S
							Do
								' The following expression was wrapped in a checked-statement
								Dim num8 As Integer = CInt(SUPERPRO.ReadCell(CInt((num7 + 11S)), num9))
								If num8 = 0 Then
									If num9 > 32767 Then
										num9 -= 65536
									End If
									num9 = (num9 Xor num5 Xor num6 Xor Not num4)
									StringType.MidStmtStr([string], CInt((num7 * 2S + 1S)), 2, Conversions.ToString(Strings.Chr(num9 And 255)) + Conversions.ToString(Strings.Chr(num9 / 256 And 255)))
								Else
									num3 = 0S
								End If
								num7 += 1S
							Loop While num7 <= 47S
						End If
					End If
				End If
				If num3 <> 0S Then
					num3 = If((-If((Strings.InStr([string], SUPERPRO.msProgramName, CompareMethod.Binary) > 0 > False), 1S, 0S)), 1S, 0S)
					If(num3 And If((-If(((Operators.CompareString(SUPERPRO.msProgramName, "XDWINAUTO", False) = 0) > False), 1S, 0S)), 1S, 0S)) <> 0S Then
						RSWIN_DESC.rst.gbAutomaticEnabled = True
					End If
				End If
				If(num3 And num2) <> 0S Then
					Dim wAddr As Integer = 60
					Dim num10 As Integer = num9
					If SUPERPRO.ReadCell(wAddr, num10) = 4S AndAlso SuperproLib.SuperproClass.RNBOsproDecrement(SuperproLib.SuperproClass.packet, 1951, 59) <> 0S Then
						num3 = 0S
					End If
				End If
				Dim text3 As String
				If num3 <> 0S Then
					num11 = -1S
				ElseIf num2 <> 0S Then
					num11 = 0S
				ElseIf bAbortIfNotFound <> 0S Then
					text = "Status"
					Dim text2 As String = "Sentinel Failure"
					text3 = Conversions.ToString(True)
					RSWIN.WriteRegProfileString(text, text2, text3, "")
					If RSWIN_DESC.bCheck4Sentinel Then
						Util.FatalError("Your Sentinel does not appear to be connected.")
					End If
				Else
					text3 = "Status"
					Dim text2 As String = "Sentinel Failure"
					text = Conversions.ToString(False)
					RSWIN.WriteRegProfileString(text3, text2, text, "")
					num11 = 0S
				End If
				Dim app3 As CThetaApp = RSWIN.App
				text3 = "MSuperproClass.TestSentinel"
				app3.TrTraceOut(text3)
				GoTo IL_2C8
				IL_259:
				Dim sMsg As String = " Error has occurred in TestSentinel: " + Information.Err().Description
				Dim sMsgType As String = ""
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
				GoTo IL_2C8
				IL_27F:
				num12 = -1
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_299:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num12 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_27F
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_2C8:
			Dim result As Short = num11
			If num12 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		Private Const MODULESIG As String = "MSuperproClass."

		Private nRetries As Integer = 0

		Private bRetry As Boolean

		Private Const op_formatpacket As Short = 0S

		Private Const op_initialize As Integer = 1

		Private Const op_get_extended_status As Decimal = 2D

		Private Const op_get_version As Single = 3F

		Private Const op_find_first_unit As Single = 4F

		Private Const op_find_next_unit As Single = 5F

		Private Const op_read As Single = 6F

		Private Const op_extended_read As Single = 7F

		Private Const op_write As Single = 8F

		Private Const op_overwrite As Single = 9F

		Private Const op_decrement As Single = 10F

		Private Const op_activate As Single = 11F

		Private Const op_query As Single = 12F

		Private Const AC_DATA As Short = 0S

		Private Const AC_LOCKED_DATA As Short = 1S

		Private Const AC_COUNTER As Short = 2S

		Private Const AC_ALGORITHM As Short = 3S

		Private Const SSP_CELL_RNBOSN As Short = 0S

		Private Const SSP_CELL_DEVID As Short = 1S

		Private Const SSP_CELL_WATERSPWTLO As Short = 8S

		Private Const SSP_CELL_WATERSPWTHI As Short = 9S

		Private Const SSP_CELL_THETASN As Short = 10S

		Private Const SSP_CELL_COUNTER As Short = 59S

		Private Const SSP_CELL_ALGORITHM As Short = 60S

		Private Const SSP_CELL_PASSWORD As Short = 62S

		Private Const SSP_MAX_CELLS As Short = 59S

		Private Const SP_SUCCESS As Integer = 0

		Private Const SP_INVALID_FUNCTION_CODE As Integer = 1

		Private Const SP_INVALID_PACKET As Integer = 2

		Private Const SP_UNIT_NOT_FOUND As Integer = 3

		Private Const SP_ACCESS_DENIED As Integer = 4

		Private Const SP_INVALID_MEMORY_ADDRESS As Integer = 5

		Private Const SP_INVALID_ACCESS_CODE As Integer = 6

		Private Const SP_PORT_IS_BUSY As Integer = 7

		Private Const SP_WRITE_NOT_READY As Integer = 8

		Private Const SP_NO_PORT_FOUND As Integer = 9

		Private Const SP_ALREADY_ZERO As Integer = 10

		Private Const SP_DRIVER_OPEN_ERROR As Integer = 11

		Private Const SP_DRIVER_NOT_INSTALLED As Integer = 12

		Private Const SP_IO_COMMUNICATIONS_ERROR As Integer = 13

		Private Const SP_PACKET_TOO_SMALL As Integer = 15

		Private Const SP_INVALID_PARAMETER As Integer = 16

		Private Const SP_MEM_ACCESS_ERROR As Integer = 17

		Private Const SP_VERSION_NOT_SUPPORTED As Integer = 18

		Private Const SP_OS_NOT_SUPPORTED As Integer = 19

		Private Const SP_QUERY_TOO_LONG As Integer = 20

		Private Const SP_INVALID_COMMAND As Integer = 21

		Private Const SP_MEM_ALIGNMENT_ERROR As Integer = 29

		Private Const SP_DRIVER_IS_BUSY As Integer = 30

		Private Const SP_PORT_ALLOCATION_FAILURE As Integer = 31

		Private Const SP_PORT_RELEASE_FAILURE As Integer = 32

		Private Const SP_ACQUIRE_PORT_TIMEOUT As Integer = 39

		Private Const SP_SIGNAL_NOT_SUPPORTED As Integer = 42

		Private Const SP_UNKNOWN_MACHINE As Integer = 44

		Private Const SP_SYS_API_ERROR As Integer = 45

		Private Const SP_UNIT_IS_BUSY As Integer = 46

		Private Const SP_INVALID_PORT_TYPE As Integer = 47

		Private Const SP_INVALID_MACH_TYPE As Integer = 48

		Private Const SP_INVALID_IRQ_MASK As Integer = 49

		Private Const SP_INVALID_CONT_METHOD As Integer = 50

		Private Const SP_INVALID_PORT_FLAGS As Integer = 51

		Private Const SP_INVALID_LOG_PORT_CFG As Integer = 52

		Private Const SP_INVALID_OS_TYPE As Integer = 53

		Private Const SP_INVALID_LOG_PORT_NUM As Integer = 54

		Private Const SP_INVALID_ROUTER_FLGS As Integer = 56

		Private Const SP_INIT_NOT_CALLED As Integer = 57

		Private Const SP_DRVR_TYPE_NOT_SUPPORTED As Integer = 58

		Private Const SP_FAIL_ON_DRIVER_COMM As Integer = 59

		Private Const SP_SERVER_PROBABLY_NOT_UP As Integer = 60

		Private Const SP_UNKNOWN_HOST As Integer = 61

		Private Const SP_SENDTO_FAILED As Integer = 62

		Private Const SP_SOCKET_CREATION_FAILED As Integer = 63

		Private Const SP_NORESOURCES As Integer = 64

		Private Const SP_BROADCAST_NOT_SUPPORTED As Integer = 65

		Private Const SP_BAD_SERVER_MESSAGE As Integer = 66

		Private Const SP_NO_SERVER_RUNNING As Integer = 67

		Private Const SP_NO_NETWORK As Integer = 68

		Private Const SP_NO_SERVER_RESPONSE As Integer = 69

		Private Const SP_NO_LICENSE_AVAILABLE As Integer = 70

		Private Const SP_INVALID_LICENSE As Integer = 71

		Private Const SP_INVALID_OPERATION As Integer = 72

		Private Const SP_BUFFER_TOO_SMALL As Integer = 73

		Private Const SP_INTERNAL_ERROR As Integer = 74

		Private Const SP_PACKET_ALREADY_INITIALIZED As Integer = 75

		Private Const SP_PROTOCOL_NOT_INSTALLED As Integer = 76

		Private msLogFile As String

		Private msProgramName As String

		Private bInitialized As Boolean

		Private CheckSentinelThetaSerial As Integer
	End Module
End Namespace
