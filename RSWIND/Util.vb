Imports System
Imports System.Collections
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports ChartFX.WinForms
Imports DataDynamics.ActiveReports
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.Compatibility.VB6
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	Friend NotInheritable Module Util
		Private Property dlgSelectCBM As dlgSelectCBM
			Get
				Return Util._dlgSelectCBM
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As dlgSelectCBM)
				Util._dlgSelectCBM = value
			End Set
		End Property = New dlgSelectCBM()

		Public Sub AlertMsg(msg As String)
			Dim sMsgType As String = ""
			Dim bClosing As Boolean = False
			Dim dialogResult As DialogResult = DialogResult.OK
			Util.SendMessage(msg, sMsgType, bClosing, dialogResult)
		End Sub

		Public Sub BusyCursor()
			Cursor.Current = Cursors.WaitCursor
		End Sub

		Public Sub CenterForm(ByRef frm As Form, frmMain As Form, Optional iPlusThis As Integer = 0, Optional bChildFrm As Boolean = False)
		End Sub

		Public Sub cErrmsg(errnum As Integer)
			Try
				RSWIN_DESC.sNull = ""
				Util.DoError(RSWIN_DESC.sNull, errnum, 48)
			Catch ex As Exception
			End Try
		End Sub

		Public Sub cErrmsgECM(Errnum_E As Integer, Errnum_C As Integer, Errnum_M As Integer)
			Dim obj As Object
			Select Case RSWIN_DESC.SETUP_MeasurementSystem
				Case 1
					obj = Errnum_E
				Case 2
					obj = Errnum_C
				Case 3
					obj = Errnum_M
			End Select
			Util.DoError(RSWIN_DESC.sNull, Conversions.ToInteger(obj), 48)
		End Sub

		Public Sub cFatalError(errnum As Integer)
			Util.DoError(RSWIN_DESC.sNull, errnum, 16)
		End Sub

		Public Function CheckLower(ByRef v As Object, LowerBound As Single, Inclusive As Integer, errnum As Integer, useMetric As Integer, CanadianIsMetric As Integer, Optional bQuiet As Boolean = False, Optional ByRef sMsg As String = "") As Object
			Dim result As Object = False
			If Information.IsDBNull(RuntimeHelpers.GetObjectValue(v)) Then
				result = True
			Else
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Interaction.IIf(Inclusive <> 0, RuntimeHelpers.GetObjectValue(Operators.CompareObjectLess(v, LowerBound, False)), RuntimeHelpers.GetObjectValue(Operators.CompareObjectLessEqual(v, LowerBound, False))))
				If Conversions.ToBoolean(Operators.NotObject(objectValue)) Then
					result = True
				ElseIf errnum > 0 And Not bQuiet Then
					If Not useMetric <> 0 Then
						Util.cErrmsg(errnum)
					ElseIf Not CanadianIsMetric <> 0 Then
						Util.cErrmsgECM(errnum, errnum, errnum + 1)
					Else
						Util.cErrmsgECM(errnum, errnum + 1, errnum + 1)
					End If
				ElseIf errnum > 0 Then
					Util.LoadMessage(errnum, sMsg)
				End If
			End If
			Return result
		End Function

		Public Function CheckUpper(ByRef v As Object, UpperBound As Single, Inclusive As Integer, errnum As Integer, useMetric As Integer, CanadianIsMetric As Integer, Optional bQuiet As Boolean = False, Optional ByRef sMsg As String = "") As Object
			Dim result As Object = False
			If Information.IsDBNull(RuntimeHelpers.GetObjectValue(v)) Then
				result = True
			ElseIf Not Conversions.ToBoolean(Interaction.IIf(Inclusive <> 0, RuntimeHelpers.GetObjectValue(Operators.CompareObjectGreater(v, UpperBound, False)), RuntimeHelpers.GetObjectValue(Operators.CompareObjectGreaterEqual(v, UpperBound, False)))) Then
				result = True
			ElseIf errnum > 0 And Not bQuiet Then
				If Not useMetric <> 0 Then
					Util.cErrmsg(errnum)
				ElseIf Not CanadianIsMetric <> 0 Then
					Util.cErrmsgECM(errnum, errnum, errnum + 1)
				Else
					Util.cErrmsgECM(errnum, errnum + 1, errnum + 1)
				End If
			ElseIf errnum > 0 Then
				Util.LoadMessage(errnum, sMsg)
			End If
			Return result
		End Function

		Public Function GetCheckLowerMsg(ByRef v As Object, LowerBound As Single, Inclusive As Integer, errnum As Integer, useMetric As Integer, CanadianIsMetric As Integer, ByRef sMsg As String) As Object
			Dim result As Object = True
			If Information.IsDBNull(RuntimeHelpers.GetObjectValue(v)) Then
				result = False
			Else
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Interaction.IIf(Inclusive <> 0, RuntimeHelpers.GetObjectValue(Operators.CompareObjectLess(v, LowerBound, False)), RuntimeHelpers.GetObjectValue(Operators.CompareObjectLessEqual(v, LowerBound, False))))
				If Conversions.ToBoolean(Operators.NotObject(objectValue)) Then
					result = False
				ElseIf errnum > 0 Then
					If Not CanadianIsMetric <> 0 Then
						Select Case RSWIN_DESC.SETUP_MeasurementSystem
							Case 2
								errnum = errnum
							Case 3
								errnum += 1
						End Select
					End If
					Util.LoadMessage(errnum, sMsg)
				End If
			End If
			Return result
		End Function

		Public Function GetCheckUpperMsg(ByRef v As Object, UpperBound As Single, Inclusive As Integer, errnum As Integer, useMetric As Integer, CanadianIsMetric As Integer, ByRef sMsg As String) As Object
			Dim result As Object = True
			If Information.IsDBNull(RuntimeHelpers.GetObjectValue(v)) Then
				result = False
			Else
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Interaction.IIf(Inclusive <> 0, RuntimeHelpers.GetObjectValue(Operators.CompareObjectGreater(v, UpperBound, False)), RuntimeHelpers.GetObjectValue(Operators.CompareObjectGreaterEqual(v, UpperBound, False))))
				If Conversions.ToBoolean(Operators.NotObject(objectValue)) Then
					result = False
				ElseIf errnum > 0 Then
					If Not CanadianIsMetric <> 0 Then
						Select Case RSWIN_DESC.SETUP_MeasurementSystem
							Case 2
								errnum = errnum
							Case 3
								errnum += 1
						End Select
					End If
					Util.LoadMessage(errnum, sMsg)
				End If
			End If
			Return result
		End Function

		Public Function CVI(S As String) As Integer
			Dim expression As Integer
			Dim result As Integer
			If Strings.Len(S) < Strings.Len(expression) Then
				result = 0
			Else
				result = Convert.ToInt32(S)
			End If
			Return result
		End Function

		Public Sub Errmsg(msgtxt As String)
			If Not RSWIN_DESC.rst.gbBatch Then
				Util.DoError(msgtxt, 0, 48)
				Return
			End If
			Dim flag2 As Boolean
			Dim flag As Boolean = RSWIN_DESC.frmMain.MdiFormExists("BatchLog", False, False, False, flag2)
			If flag Then
				RSWIN_DESC.frmMain.SetBatchLogTopMost(False)
				Util.DoError(msgtxt, 0, 48)
				RSWIN_DESC.frmMain.SetBatchLogTopMost(True)
				Return
			End If
			Util.DoError(msgtxt, 0, 48)
		End Sub

		Public Sub ExportMCM()
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			Dim num As Single
			If rst.PU.UnitType <> 8S Or CDbl(rst.GearboxLoading(0)) >= 0.99 Or RSWIN_DESC.bBalancedEVarsOverwritten Then
				If rst.get_M(1) = rst.get_M(0) Then
					num = rst.get_M(1)
				Else
					Util.dlgSelectCBM.ShowDialog()
					If Conversion.Val(RuntimeHelpers.GetObjectValue(Util.dlgSelectCBM.Tag)) = 1.0 Then
						num = rst.get_M(1)
					ElseIf Conversion.Val(RuntimeHelpers.GetObjectValue(Util.dlgSelectCBM.Tag)) = 0.0 Then
						num = rst.get_M(0)
					End If
				End If
				If num = 0F Then
					num = rst.get_M(2)
				End If
			Else
				If rst.get_RequiredUnbalance(1) = rst.get_RequiredUnbalance(0) Or CDbl(rst.GearboxLoading(0)) >= 0.99 Or RSWIN_DESC.bBalancedEVarsOverwritten Then
					num = rst.get_RequiredUnbalance(1)
				Else
					Util.dlgSelectCBM.ShowDialog()
					If Conversion.Val(RuntimeHelpers.GetObjectValue(Util.dlgSelectCBM.Tag)) = 1.0 Then
						num = rst.get_RequiredUnbalance(1)
					ElseIf Conversion.Val(RuntimeHelpers.GetObjectValue(Util.dlgSelectCBM.Tag)) = 0.0 Then
						num = rst.get_RequiredUnbalance(0)
					End If
				End If
				If num = 0F Then
					num = rst.Unbalance
				End If
			End If
			Util.CopyMCMToClipboard(num)
		End Sub

		Public Sub FatalError(sMsgtxt As String)
			Util.DoError(sMsgtxt, 0, 16)
		End Sub

		Public Function FileName(sPath As String) As String
			Dim text As String = Strings.Trim(sPath)
			Dim obj As Object = 1
			While True
				Dim obj2 As Object = Strings.InStr(Conversions.ToInteger(obj), text, "\", CompareMethod.Binary)
				If Operators.ConditionalCompareObjectEqual(obj2, 0, False) Then
					Exit For
				End If
				obj = Operators.AddObject(obj2, 1)
			End While
			Return Strings.Mid(text, Conversions.ToInteger(obj))
		End Function

		Public Function FindProgramFile(sExt As String) As String
			Dim result As String
			FILEUTIL.LocateFile("Rodstar" + sExt, result, 2S, False, False, False, False)
			Return result
		End Function

		Public Function FormatSw(S As Single, Fmt As String, w As Integer) As String
			Dim text As String = Util.Format(S, Fmt)
			Dim result As String
			If Strings.Len(text) >= Math.Abs(w) Then
				result = text
			ElseIf w > 0 Then
				result = Strings.Space(w - Strings.Len(text)) + text
			Else
				result = text + Strings.Space(0 - w - Strings.Len(text))
			End If
			Return result
		End Function

		Public Function FSum(A As Single()) As Single
			Dim num As Single = 0F
			Dim num2 As Integer = Information.LBound(A, 1)
			Dim num3 As Integer = Information.UBound(A, 1)
			For i As Integer = num2 To num3
				num += A(i)
			Next
			Return num
		End Function

		Public Function GetLabelTag(txt As Control) As Object
			Dim result As Object
			Return result
		End Function

		Public Function GetToken(ByRef sSource As String, sSep As String) As String
			Dim num As Integer = Strings.InStr(sSource, sSep, CompareMethod.Binary)
			Dim result As String
			If num = 0 Then
				result = sSource
				sSource = ""
			Else
				' The following expression was wrapped in a checked-expression
				result = sSource.Substring(0, num - 1)
				sSource = sSource.Substring(num)
			End If
			Return result
		End Function

		Public Function FormatMessage(Template As Object, ParamArray Args As Object()) As String
			Dim num2 As Integer
			Dim text5 As String
			Dim num8 As Integer
			Dim obj3 As Object
			Try
				IL_00:
				Dim num As Integer = 1
				Dim text As String = ""
				IL_0A:
				num = 2
				If Not Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(Template)) Then
					GoTo IL_3A
				End If
				IL_1A:
				ProjectData.ClearProjectError()
				num2 = 1
				IL_22:
				num = 4
				text = Support.LoadResString(Conversions.ToInteger(Template))
				IL_32:
				ProjectData.ClearProjectError()
				num2 = 0
				IL_3A:
				num = 7
				If Strings.Len(text) <> 0 Then
					GoTo IL_57
				End If
				IL_47:
				num = 8
				text = Convert.ToString(RuntimeHelpers.GetObjectValue(Template))
				IL_57:
				num = 10
				Dim num3 As Short = 0S
				IL_5E:
				num = 11
				Dim i As Integer = 0
				While i < Args.Length
					Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Args(i))
					IL_78:
					num = 12
					Dim num4 As Short = CShort(Strings.InStr(text, "{" + Conversions.ToString(CInt(num3)), CompareMethod.Binary))
					IL_98:
					num = 13
					If num4 <> 0S Then
						IL_A4:
						num = 14
						Dim num5 As Short = CShort(Strings.InStr(CInt(num4), text, "}", CompareMethod.Binary))
						IL_B9:
						num = 15
						If num5 = 0S Then
							IL_C1:
							num = 16
							num5 = CShort(Strings.Len(text))
						End If
						IL_CE:
						num = 18
						Dim text2 As String = Strings.Mid(text, CInt(num4), CInt((num5 - num4 + 1S)))
						IL_E4:
						num = 19
						Dim num6 As Short = CShort(Strings.InStr(text2, "!", CompareMethod.Binary))
						IL_F7:
						num = 20
						Dim replacement As String
						If num6 = 0S Then
							IL_FF:
							num = 21
							replacement = Convert.ToString(RuntimeHelpers.GetObjectValue(objectValue))
							IL_110:
						Else
							IL_115:
							num = 23
							IL_119:
							num = 24
							Dim text3 As String = Strings.Mid(text2, CInt((num6 + 1S)), Strings.Len(text2) - CInt(num6) - 1)
							IL_133:
							num = 25
							Dim obj As Object = Nothing
							Dim typeFromHandle As Type = GetType(Util)
							Dim text4 As String = "Format"
							Dim array As Object() = New Object() { RuntimeHelpers.GetObjectValue(objectValue), text3 }
							Dim array2 As Object() = array
							Dim array3 As String() = Nothing
							Dim array4 As Type() = Nothing
							Dim array5 As Boolean() = New Boolean() { True, True }
							Dim obj2 As Object = NewLateBinding.LateGet(obj, typeFromHandle, text4, array2, array3, array4, array5)
							If array5(0) Then
								objectValue = RuntimeHelpers.GetObjectValue(array(0))
							End If
							If array5(1) Then
								text3 = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array(1)), GetType(String)))
							End If
							replacement = Conversions.ToString(obj2)
						End If
						IL_1BA:
						num = 27
						text = Strings.Replace(text, text2, replacement, 1, 1, CompareMethod.Binary)
						IL_1CE:
						num = 28
						num3 += 1S
					End If
					IL_1D9:
					i += 1
					IL_1DF:
					num = 30
				End While
				IL_1EE:
				num = 31
				text5 = text
				IL_1F6:
				GoTo IL_2CF
				IL_1FB:
				Dim num7 As Integer = num8 + 1
				num8 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num7)
				IL_28B:
				GoTo IL_2C4
				IL_28D:
				num8 = num
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num2)
				IL_2A0:
			Catch obj4 When endfilter(TypeOf obj3 Is Exception And num2 <> 0 And num8 = 0)
				Dim ex As Exception = CType(obj4, Exception)
				GoTo IL_28D
			End Try
			IL_2C4:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_2CF:
			Dim result As String = text5
			If num8 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		Public Function FormatSw(S As Single, Fmt As String, W As Short) As String
			Dim text As String = Util.Format(S, Fmt)
			Dim result As String
			If Strings.Len(text) >= CInt(Math.Abs(W)) Then
				result = text
			ElseIf W > 0S Then
				result = Strings.Space(CInt(W) - Strings.Len(text)) + text
			Else
				' The following expression was wrapped in a unchecked-expression
				result = text + Strings.Space(CInt(-W) - Strings.Len(text))
			End If
			Return result
		End Function

		Public Sub Infomsg(sMsgtxt As String)
			Util.DoError(sMsgtxt, 0, 64)
		End Sub

		Public Function Licensee() As String
			Return ""
		End Function

		Public Function GetWindowsDir() As String
			Dim directoryInfo As DirectoryInfo = New DirectoryInfo(Environment.SystemDirectory)
			Return directoryInfo.Parent.FullName
		End Function

		Public Sub LoadMenu(sMenu As String, ByRef nItems As Short, ByRef items As String())
			' The following expression was wrapped in a checked-statement
			Try
				Dim fileName As String = Util.FindProgramFile("32.MNU")
				Dim num As Short = CShort(FileSystem.FreeFile())
				Dim flag As Boolean = True
				While flag
					Try
						FileSystem.FileOpen(CInt(num), fileName, OpenMode.Binary, OpenAccess.Read, OpenShare.LockReadWrite, -1)
						flag = False
					Catch ex As Exception
					End Try
				End While
				Dim num2 As Short
				FileSystem.FileGet(CInt(num), num2, -1L)
				Dim array As Integer() = New Integer(CInt((num2 + 1S)) - 1) {}
				Dim array2 As String() = New String(CInt((num2 + 1S)) - 1) {}
				Dim num3 As Integer = 1
				Dim num4 As Integer = CInt(num2)
				For i As Integer = num3 To num4
					FileSystem.FileGet(CInt(num), array(i), -1L)
				Next
				Dim num5 As Integer = 1
				Dim num6 As Integer = CInt(num2)
				Dim charCount As Short
				For i As Integer = num5 To num6
					FileSystem.FileGet(CInt(num), charCount, -1L)
					array2(i) = FileSystem.InputString(CInt(num), CInt(charCount))
				Next
				Dim num7 As Integer = 1
				Dim num8 As Integer = CInt(num2)
				For i As Integer = num7 To num8
					If Operators.CompareString(sMenu, array2(i), False) = 0 Then
						' The following expression was wrapped in a unchecked-expression
						' The following expression was wrapped in a checked-expression
						FileSystem.Seek(CInt(num), CLng((array(i) + 1)))
						FileSystem.FileGet(CInt(num), nItems, -1L)
						nItems -= 1S
						items = New String(CInt((nItems + 1S)) - 1) {}
						Dim num9 As Integer = 0
						Dim num10 As Integer = CInt(nItems)
						For j As Integer = num9 To num10
							FileSystem.FileGet(CInt(num), charCount, -1L)
							items(j) = FileSystem.InputString(CInt(num), CInt(charCount))
						Next
						FileSystem.FileClose(New Integer() { CInt(num) })
						Return
					End If
				Next
				FileSystem.FileClose(New Integer() { CInt(num) })
			Catch ex2 As Exception
				Dim num As Short
				FileSystem.FileClose(New Integer() { CInt(num) })
				Dim sMsg As String = "Error in Load Menu: " + ex2.Message
				Dim sMsgType As String = "Error"
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
			End Try
		End Sub

		Public Sub LoadMessage(nErrorNumber As Integer, ByRef sMsg As String)
			Try
				If Util.$STATIC$LoadMessage$021810E$msgfrn = 0S Then
					Dim fileName As String = Util.FindProgramFile(".MSG")
					Dim num As Short
					Dim num2 As Short
					Util.$STATIC$LoadMessage$021810E$msgfrn = CShort(FileSystem.FreeFile())
					FileSystem.FileOpen(CInt(Util.$STATIC$LoadMessage$021810E$msgfrn), fileName, OpenMode.Binary, OpenAccess.Read, OpenShare.[Shared], -1)
					FileSystem.FileGet(CInt(Util.$STATIC$LoadMessage$021810E$msgfrn), Util.$STATIC$LoadMessage$021810E$numMsgs, -1L)
					Util.$STATIC$LoadMessage$021810E$numMsgs -= 1S
					Util.$STATIC$LoadMessage$021810E$msgOffsets = New Integer(CInt((Util.$STATIC$LoadMessage$021810E$numMsgs + 1S)) - 1) {}
					num = 0S
					num2 = Util.$STATIC$LoadMessage$021810E$numMsgs
					For num3 As Short = num To num2
						FileSystem.FileGet(CInt(Util.$STATIC$LoadMessage$021810E$msgfrn), Util.$STATIC$LoadMessage$021810E$msgOffsets(CInt(num3)), -1L)
					Next
				End If
				If nErrorNumber < 0 Or nErrorNumber > CInt(Util.$STATIC$LoadMessage$021810E$numMsgs) Then
					nErrorNumber = 0
				End If
				FileSystem.Seek(CInt(Util.$STATIC$LoadMessage$021810E$msgfrn), CLng((Util.$STATIC$LoadMessage$021810E$msgOffsets(nErrorNumber) + 1)))
				Dim charCount As Short
				FileSystem.FileGet(CInt(Util.$STATIC$LoadMessage$021810E$msgfrn), charCount, -1L)
				sMsg = FileSystem.InputString(CInt(Util.$STATIC$LoadMessage$021810E$msgfrn), CInt(charCount))
				Dim num4 As Short
				Do
					num4 = CShort(Strings.InStr(sMsg, "%{p}", CompareMethod.Binary))
					If num4 > 0S Then
						sMsg = Strings.Left(sMsg, CInt((num4 - 1S))) + "RODSTAR" + Strings.Mid(sMsg, CInt((num4 + 4S)))
					End If
				Loop While num4 <> 0S
				RSWIN_DESC.sNull = ""
				RSWIN_DESC.iErrorOccurred = nErrorNumber
				If Operators.CompareString(sMsg, "", False) <> 0 AndAlso RSWIN_DESC.bExpert AndAlso Strings.InStr(sMsg, "RODSTAR", CompareMethod.Binary) > 0 Then
					sMsg = sMsg.Replace("RODSTAR", "XROD")
				End If
			Catch ex As Exception
				Try
					FileSystem.FileClose(New Integer() { CInt(Util.$STATIC$LoadMessage$021810E$msgfrn) })
					Util.$STATIC$LoadMessage$021810E$msgfrn = 0S
					Util.LoadMessageAgain(nErrorNumber, sMsg)
				Catch ex2 As Exception
					Util.$STATIC$LoadMessage$021810E$msgfrn = 0S
				End Try
			End Try
		End Sub

		Public Sub LoadMessageAgain(nErrorNumber As Integer, ByRef sMsg As String)
			Try
				If Util.$STATIC$LoadMessageAgain$021810E$msgfrn = 0S Then
					Dim fileName As String = Util.FindProgramFile(".MSG")
					Dim num As Short
					Dim num2 As Short
					Util.$STATIC$LoadMessageAgain$021810E$msgfrn = CShort(FileSystem.FreeFile())
					FileSystem.FileOpen(CInt(Util.$STATIC$LoadMessageAgain$021810E$msgfrn), fileName, OpenMode.Binary, OpenAccess.Read, OpenShare.[Shared], -1)
					FileSystem.FileGet(CInt(Util.$STATIC$LoadMessageAgain$021810E$msgfrn), Util.$STATIC$LoadMessageAgain$021810E$numMsgs, -1L)
					Util.$STATIC$LoadMessageAgain$021810E$numMsgs -= 1S
					Util.$STATIC$LoadMessageAgain$021810E$msgOffsets = New Integer(CInt((Util.$STATIC$LoadMessageAgain$021810E$numMsgs + 1S)) - 1) {}
					num = 0S
					num2 = Util.$STATIC$LoadMessageAgain$021810E$numMsgs
					For num3 As Short = num To num2
						FileSystem.FileGet(CInt(Util.$STATIC$LoadMessageAgain$021810E$msgfrn), Util.$STATIC$LoadMessageAgain$021810E$msgOffsets(CInt(num3)), -1L)
					Next
				End If
				If nErrorNumber < 0 Or nErrorNumber > CInt(Util.$STATIC$LoadMessageAgain$021810E$numMsgs) Then
					nErrorNumber = 0
				End If
				FileSystem.Seek(CInt(Util.$STATIC$LoadMessageAgain$021810E$msgfrn), CLng((Util.$STATIC$LoadMessageAgain$021810E$msgOffsets(nErrorNumber) + 1)))
				Dim charCount As Short
				FileSystem.FileGet(CInt(Util.$STATIC$LoadMessageAgain$021810E$msgfrn), charCount, -1L)
				sMsg = FileSystem.InputString(CInt(Util.$STATIC$LoadMessageAgain$021810E$msgfrn), CInt(charCount))
				Dim num4 As Short
				Do
					num4 = CShort(Strings.InStr(sMsg, "%{p}", CompareMethod.Binary))
					If num4 > 0S Then
						sMsg = Strings.Left(sMsg, CInt((num4 - 1S))) + "RODSTAR" + Strings.Mid(sMsg, CInt((num4 + 4S)))
					End If
				Loop While num4 <> 0S
				RSWIN_DESC.sNull = ""
			Catch ex As Exception
			End Try
		End Sub

		Public Function Max(v1 As Object, v2 As Object) As Object
			Dim objectValue As Object
			If Operators.ConditionalCompareObjectGreater(v1, v2, False) Then
				objectValue = RuntimeHelpers.GetObjectValue(v1)
			Else
				objectValue = RuntimeHelpers.GetObjectValue(v2)
			End If
			Return objectValue
		End Function

		Public Sub Maxmin(A As Single(), ByRef Max As Single, ByRef min As Single, ByRef maxpos As Single, ByRef minpos As Single)
			Try
				Dim obj As Object = Information.LBound(A, 1)
				Dim obj2 As Object = Information.UBound(A, 1)
				maxpos = Conversions.ToSingle(obj)
				minpos = Conversions.ToSingle(obj)
				Max = A(Conversions.ToInteger(obj))
				min = A(Conversions.ToInteger(obj))
				Dim obj3 As Object
				Dim obj4 As Object
				If ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj3, Operators.AddObject(obj, 1), obj2, 1, obj4, obj3) Then
					Do
						If A(Conversions.ToInteger(obj3)) > Max Then
							maxpos = Conversions.ToSingle(obj3)
							Max = A(Conversions.ToInteger(obj3))
						End If
						If A(Conversions.ToInteger(obj3)) < min Then
							minpos = Conversions.ToSingle(obj3)
							min = A(Conversions.ToInteger(obj3))
						End If
					Loop While ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj3, obj4, obj3)
				End If
			Catch ex As Exception
			End Try
		End Sub

		Public Sub Maxmin(A As Double(), ByRef Max As Double, ByRef min As Double, ByRef maxpos As Double, ByRef minpos As Double)
			Try
				Dim obj As Object = Information.LBound(A, 1)
				Dim obj2 As Object = Information.UBound(A, 1)
				maxpos = Conversions.ToDouble(obj)
				minpos = Conversions.ToDouble(obj)
				Max = A(Conversions.ToInteger(obj))
				min = A(Conversions.ToInteger(obj))
				Dim obj3 As Object
				Dim obj4 As Object
				If ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj3, Operators.AddObject(obj, 1), obj2, 1, obj4, obj3) Then
					Do
						If A(Conversions.ToInteger(obj3)) > Max Then
							maxpos = Conversions.ToDouble(obj3)
							Max = A(Conversions.ToInteger(obj3))
						End If
						If A(Conversions.ToInteger(obj3)) < min Then
							minpos = Conversions.ToDouble(obj3)
							min = A(Conversions.ToInteger(obj3))
						End If
					Loop While ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj3, obj4, obj3)
				End If
			Catch ex As Exception
			End Try
		End Sub

		Public Sub Message(msgtxt As String)
			Try
				RSWIN_DESC.StatusControl.Text = msgtxt
			Catch ex As Exception
			End Try
		End Sub

		Public Function MKD(d As Single) As String
			Return d.ToString()
		End Function

		Public Function MKI(I As Integer) As String
			Return I.ToString()
		End Function

		Public Sub PLAY(noteS As Object)
		End Sub

		Public Function QFormat(v As Object) As String
			Dim text As String = Util.Format(v)
			If Strings.Len(text) > 0 Then
				Select Case Information.VarType(RuntimeHelpers.GetObjectValue(v))
					Case VariantType.[Single], VariantType.[Double]
						Dim obj As Object = Strings.InStr(text, ".", CompareMethod.Binary)
						If Operators.ConditionalCompareObjectGreater(obj, 0, False) Then
							Dim text2 As String = Strings.Mid(text, Conversions.ToInteger(Operators.AddObject(obj, 1)))
							If Strings.Len(text2) > 1 Then
								Dim text3 As String = text2
								If Operators.CompareString(text3, New String("0"c, Strings.Len(text2) - 1) + "1", False) = 0 Then
									text = Strings.Left(text, Conversions.ToInteger(Operators.SubtractObject(obj, 1)))
								ElseIf Operators.CompareString(text3, New String("9"c, Strings.Len(text2)), False) = 0 Then
									Dim obj2 As Object = Conversion.Int(Convert.ToDouble(RuntimeHelpers.GetObjectValue(v))) + 1.0
									text = Util.Format(obj2)
								End If
							End If
						End If
				End Select
			End If
			Return text
		End Function

		Public Function ArraySize(ByRef Arr As Object, Optional Rank As Long = 1L) As Long
			Dim num As Integer
			Dim num5 As Long
			Dim num6 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 2
				IL_07:
				Dim num2 As Integer = 2
				Dim num3 As Long = CLng(Information.LBound(CType(Arr, Array), CInt(Rank)))
				IL_1A:
				num2 = 3
				Dim num4 As Long = CLng(Information.UBound(CType(Arr, Array), CInt(Rank)))
				IL_2D:
				num2 = 4
				num5 = num4 - num3 + 1L
				IL_37:
				GoTo IL_CB
				IL_3C:
				num2 = 6
				ProjectData.ClearProjectError()
				If num6 <> 0 Then
					GoTo IL_55
				End If
				Throw ProjectData.CreateProjectError(-2146828268)
				IL_53:
				GoTo IL_CB
				IL_55:
				Dim num7 As Integer = num6
				GoTo IL_5D
				IL_59:
				num7 = num6 + 1
				IL_5D:
				num6 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num7)
				IL_85:
				GoTo IL_C0
				IL_87:
				num6 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_9D:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num6 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_87
			End Try
			IL_C0:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_CB:
			Dim result As Long = num5
			If num6 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		Public Sub ReformText(ByRef sText As String, nWidth As Integer)
			Dim text As String = sText
			sText = ""
			Do
				Dim obj As Object = Strings.InStr(text, Conversions.ToString(RSWIN_DESC.LF), CompareMethod.Binary)
				Dim text2 As String
				Dim obj2 As Object
				If Operators.ConditionalCompareObjectEqual(obj, 0, False) Then
					text2 = text
					text = ""
					obj2 = False
				Else
					text2 = Strings.Left(text, Conversions.ToInteger(Operators.SubtractObject(obj, 1)))
					text = Strings.Mid(text, Conversions.ToInteger(Operators.AddObject(obj, 1)))
					obj2 = True
				End If
				If Strings.Len(text2) > 0 Then
					Dim obj3 As Object = 0
					Dim obj4 As Object = 1
					Do
						Dim obj5 As Object = 0
						While Operators.CompareString(Strings.Mid(text2, Conversions.ToInteger(obj4), 1), " ", False) = 0
							obj4 = Operators.AddObject(obj4, 1)
							obj5 = Operators.AddObject(obj5, 1)
						End While
						obj = Strings.InStr(Conversions.ToInteger(obj4), text2, " ", CompareMethod.Binary)
						Dim text3 As String
						If Operators.ConditionalCompareObjectGreater(obj, 0, False) Then
							text3 = Strings.Mid(text2, Conversions.ToInteger(obj4), Conversions.ToInteger(Operators.SubtractObject(obj, obj4)))
							obj4 = RuntimeHelpers.GetObjectValue(obj)
						Else
							text3 = Strings.Mid(text2, Conversions.ToInteger(obj4))
						End If
						If Operators.ConditionalCompareObjectGreater(Operators.AddObject(Operators.AddObject(obj3, obj5), Strings.Len(text3)), nWidth, False) Then
							sText += "~"
							obj3 = 0
							obj5 = 0
						End If
						sText = sText + Strings.Space(Conversions.ToInteger(obj5)) + text3
						obj3 = Operators.AddObject(Operators.AddObject(obj3, obj5), Strings.Len(text3))
					Loop While Operators.ConditionalCompareObjectNotEqual(obj, 0, False)
				End If
				If Conversions.ToBoolean(obj2) Then
					sText += "~"
				End If
			Loop While Strings.Len(text) <> 0
		End Sub

		Public Function RFormat(vParam As Object, Fmt As String) As String
			If vParam Is Nothing Then
				Return ""
			End If
			If Not Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(vParam)) Then
				Return Conversions.ToString(vParam)
			End If
			Dim num As Single = Convert.ToSingle(RuntimeHelpers.GetObjectValue(vParam))
			Dim text As String = Strings.Space(16)
			Dim text2 As String = "intl"
			Dim text3 As String = "sDecimal"
			Dim text4 As String = "."
			Dim regProfileString As Integer = RSWIN.GetRegProfileString(text2, text3, text4, text, False)
			If regProfileString = 0 Or Operators.CompareString(text, RSWIN_DESC.NumFormatInfo.NumberDecimalSeparator, False) <> 0 Then
				text = RSWIN_DESC.NumFormatInfo.NumberDecimalSeparator
			Else
				text = Strings.Left(text, regProfileString)
			End If
			Dim text5 As String = Util.Format(num, Fmt)
			If Strings.InStr(Fmt, text, CompareMethod.Binary) = 0 Then
				If Strings.Len(text5) < Strings.Len(Fmt) Then
					' The following expression was wrapped in a checked-expression
					text5 = Strings.Space(Strings.Len(Fmt) - Strings.Len(text5)) + text5
				End If
			Else
				Dim obj As Object = Strings.InStr(Fmt, text, CompareMethod.Binary)
				Dim obj2 As Object = Strings.InStr(text5, text, CompareMethod.Binary)
				Dim obj3 As Object = Operators.SubtractObject(obj, 1)
				Dim obj4 As Object = Operators.SubtractObject(Strings.Len(Fmt), obj)
				Dim obj5 As Object = Operators.SubtractObject(obj2, 1)
				Dim obj6 As Object = Operators.SubtractObject(Strings.Len(text5), obj2)
				If Operators.ConditionalCompareObjectLess(obj5, obj3, False) Then
					text5 = Strings.Space(Conversions.ToInteger(Operators.SubtractObject(obj3, obj5))) + text5
				End If
				If Operators.ConditionalCompareObjectLess(obj6, obj4, False) Then
					text5 += Strings.Space(Conversions.ToInteger(Operators.SubtractObject(obj4, obj6)))
				End If
			End If
			Return text5
		End Function

		Public Sub SentinelError(code As Object)
			Dim obj As Object
			If Not Operators.ConditionalCompareObjectEqual(code, 1, False) Then
				If Not Operators.ConditionalCompareObjectEqual(code, 2, False) Then
					If Operators.ConditionalCompareObjectEqual(code, 3, False) Then
						obj = 117S
					ElseIf Operators.ConditionalCompareObjectEqual(code, 4, False) Then
						obj = 150S
					ElseIf Not Operators.ConditionalCompareObjectEqual(code, 5, False) Then
						If Operators.ConditionalCompareObjectEqual(code, 6, False) Then
							obj = 116S
						End If
					End If
				End If
			End If
			Util.cFatalError(Conversions.ToInteger(obj))
			ProjectData.EndApp()
		End Sub

		Public Sub UnbusyCursor()
			Cursor.Current = Cursors.[Default]
		End Sub

		Public Function ValidNumber(S As String, ShowMessage As Short) As Short
			Return If((-If((Versioned.IsNumeric(S) > False), 1S, 0S)), 1S, 0S)
		End Function

		Public Function CVS(S As String) As Single
			Dim expression As Single
			Dim result As Single
			If Strings.Len(S) < Strings.Len(expression) Then
				result = 0F
			Else
				result = Convert.ToSingle(S)
			End If
			Return result
		End Function

		Public Sub CVIArray(S As String, ByRef nPoints As Object, ByRef Arr As Short())
			Dim expression As Short
			If Strings.Len(S) < Strings.Len(expression) Or Operators.CompareString(S, "", False) = 0 Then
				Arr = Nothing
				nPoints = 0
				Return
			End If
			nPoints = Strings.Len(S) / Strings.Len(expression)
			Dim num As Short = CShort(Information.LBound(Arr, 1))
			If Information.Err().Number <> 0 Then
				num = 0S
			End If
			Arr = New Short(Conversions.ToInteger(Operators.SubtractObject(Operators.AddObject(num, nPoints), 1)) + 1 - 1) {}
			Try
				Dim gchandle As GCHandle = GCHandle.Alloc(S, GCHandleType.Pinned)
				Dim source As IntPtr = gchandle.AddrOfPinnedObject()
				gchandle.Free()
				Marshal.Copy(source, Arr, 0, Conversions.ToInteger(nPoints))
			Catch ex As Exception
				Dim sMsg As String = "Error in CVIArray: " + ex.Message
				Dim sMsgType As String = "Error"
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
			End Try
		End Sub

		Public Sub CVIArrayI(S As String, ByRef nPoints As Object, ByRef Arr As Integer())
			Dim expression As Short
			If Strings.Len(S) < Strings.Len(expression) Then
				Arr = Nothing
				nPoints = 0
				Return
			End If
			nPoints = Strings.Len(S) / Strings.Len(expression)
			Dim num As Short = CShort(Information.LBound(Arr, 1))
			If Information.Err().Number <> 0 Then
				num = 0S
			End If
			Arr = New Integer(Conversions.ToInteger(Operators.SubtractObject(Operators.AddObject(num, nPoints), 1)) + 1 - 1) {}
			Try
				Dim gchandle As GCHandle = GCHandle.Alloc(S, GCHandleType.Pinned)
				Dim source As IntPtr = gchandle.AddrOfPinnedObject()
				gchandle.Free()
				Marshal.Copy(source, Arr, 0, Conversions.ToInteger(nPoints))
			Catch ex As Exception
				Dim sMsg As String = "Error in CVIArrayI: " + ex.Message
				Dim sMsgType As String = "Error"
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
			End Try
		End Sub

		Public Sub ItoS(ByRef S As String, ByRef I As Integer)
			Dim destination As Char() = New Char(0) {}
			Try
				Dim gchandle As GCHandle = GCHandle.Alloc(I, GCHandleType.Pinned)
				Dim source As IntPtr = gchandle.AddrOfPinnedObject()
				gchandle.Free()
				Marshal.Copy(source, destination, 0, 1)
			Catch ex As Exception
				Dim sMsg As String = "Error in ItoS: " + ex.Message
				Dim sMsgType As String = "Error"
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
			End Try
		End Sub

		Public Sub CVIArrayByte(S As Byte(), ByRef nPoints As Object, ByRef Arr As Short())
			Dim num2 As Integer
			Dim num7 As Integer
			Dim obj As Object
			Try
				IL_00:
				Dim num As Integer = 1
				Dim expression As Short
				If S.Length >= Strings.Len(expression) Then
					GoTo IL_24
				End If
				IL_0E:
				num = 2
				Arr = Nothing
				IL_14:
				num = 3
				nPoints = 0
				IL_1F:
				GoTo IL_171
				IL_24:
				num = 6
				nPoints = S.Length / Strings.Len(expression)
				IL_38:
				ProjectData.ClearProjectError()
				num2 = 1
				IL_40:
				num = 8
				Dim num3 As Short = CShort(Information.LBound(Arr, 1))
				IL_4D:
				num = 9
				If Information.Err().Number = 0 Then
					GoTo IL_64
				End If
				IL_5E:
				num = 10
				num3 = 0S
				IL_64:
				ProjectData.ClearProjectError()
				num2 = 0
				IL_6C:
				num = 13
				Arr = New Short(Conversions.ToInteger(Operators.SubtractObject(Operators.AddObject(num3, nPoints), 1)) + 1 - 1) {}
				IL_96:
				num = 16
				Dim num4 As Integer = 0
				Dim num5 As Integer = Conversions.ToInteger(Operators.SubtractObject(nPoints, 1))
				For i As Integer = num4 To num5
					IL_B2:
					num = 17
					Arr(CInt(num3) + i) = CShort(S(i))
					IL_BF:
					num = 18
				Next
				IL_CC:
				GoTo IL_171
				IL_D1:
				Dim num6 As Integer = num7 + 1
				num7 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num6)
				IL_12D:
				GoTo IL_166
				IL_12F:
				num7 = num
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num2)
				IL_142:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num2 <> 0 And num7 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_12F
			End Try
			IL_166:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_171:
			If num7 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		Public Sub CopyIntegerToSingle(ByRef DestArr As Single(), Offset As Integer, SourceArr As Integer(), StartIndex As Integer, nLength As Integer)
			Dim gchandle As GCHandle = GCHandle.Alloc(SourceArr, GCHandleType.Pinned)
			Dim intPtr As IntPtr = gchandle.AddrOfPinnedObject()
			gchandle.Free()
			Marshal.Copy(SourceArr, StartIndex, intPtr, nLength)
			Marshal.Copy(intPtr, DestArr, Offset, nLength)
		End Sub

		Public Sub CopySingleToInteger(ByRef DestArr As Integer(), Offset As Integer, SourceArr As Single(), StartIndex As Integer, nLength As Integer)
			Dim gchandle As GCHandle = GCHandle.Alloc(SourceArr, GCHandleType.Pinned)
			Dim intPtr As IntPtr = gchandle.AddrOfPinnedObject()
			gchandle.Free()
			Marshal.Copy(SourceArr, StartIndex, intPtr, nLength)
			Marshal.Copy(intPtr, DestArr, Offset, nLength)
		End Sub

		Public Function CVLS(L As Integer) As Single
			Dim array As Single() = New Single(0) {}
			Dim sourceArr As Integer() = New Integer() { L }
			Dim offset As Integer = 0
			Dim startIndex As Integer = 0
			Dim nLength As Integer = 1
			Util.CopyIntegerToSingle(array, offset, sourceArr, startIndex, nLength)
			Return array(0)
		End Function

		Public Function CVSL(S As Single) As Integer
			Dim array As Integer() = New Integer(0) {}
			Dim sourceArr As Single() = New Single() { S }
			Dim offset As Integer = 0
			Dim startIndex As Integer = 0
			Dim nLength As Integer = 1
			Util.CopySingleToInteger(array, offset, sourceArr, startIndex, nLength)
			Return array(0)
		End Function

		Public Sub CVSArray(S As String, nPoints As Integer, Arr As Single())
			Dim num2 As Integer
			Dim num4 As Integer
			Dim obj2 As Object
			Try
				IL_00:
				Dim num As Integer = 1
				Dim expression As Single
				If Strings.Len(S) >= Strings.Len(expression) Then
					GoTo IL_16
				End If
				IL_11:
				GoTo IL_F5
				IL_16:
				num = 4
				nPoints = Strings.Len(S) / Strings.Len(expression)
				IL_28:
				ProjectData.ClearProjectError()
				num2 = 1
				IL_2F:
				num = 6
				Dim obj As Object = Information.LBound(Arr, 1)
				IL_3F:
				num = 7
				If Information.Err().Number = 0 Then
					GoTo IL_59
				End If
				IL_4F:
				num = 8
				obj = 0
				IL_59:
				ProjectData.ClearProjectError()
				num2 = 0
				IL_60:
				num = 11
				Arr = New Single(nPoints + 1 - 1) {}
				IL_6E:
				GoTo IL_F5
				IL_73:
				Dim num3 As Integer = num4 + 1
				num4 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_B3:
				GoTo IL_EA
				IL_B5:
				num4 = num
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num2)
				IL_C7:
			Catch obj3 When endfilter(TypeOf obj2 Is Exception And num2 <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj3, Exception)
				GoTo IL_B5
			End Try
			IL_EA:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_F5:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		Public Sub debugmsg(msg As Object)
		End Sub

		Public Sub SendMessage(sMsg As String, Optional sMsgType As String = "", Optional bClosing As Boolean = False, Optional ByRef retc As DialogResult = __Pointer(Of DialogResult).OK)
			Try
				If Operators.CompareString(sMsg.Trim(), "", False) <> 0 Then
					If RSWIN_DESC.bRSWINEXE Then
						Interaction.Beep()
						If Versioned.IsNumeric(sMsg) Then
							Util.DoError("", Convert.ToInt32(sMsg), 48)
						ElseIf Not RSWIN_DESC.rst.gbBatch And Not RSWIN_DESC.bSuppressWarningMessages Then
							If Not bClosing Then
								MessageBox.Show(sMsg, sMsgType)
							Else
								retc = MessageBox.Show(sMsg, sMsgType, MessageBoxButtons.OKCancel, MessageBoxIcon.Hand)
							End If
						End If
					End If
				Else
					Debug.WriteLine("Problem in SendMessage: black message")
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub DoError(sErrorText As String, iErrorNumber As Integer, wMsgType As Integer)
			Dim text As String = ""
			If sErrorText.Length > 0 Then
				text = sErrorText
			Else
				Util.LoadMessage(iErrorNumber, text)
				text = Util.AssignValueToConstant("ErrorMessages", iErrorNumber.ToString().Trim(), text)
			End If
			If Strings.InStr(text, "NABLA", CompareMethod.Binary) > 0 Then
				text = text.Replace("NABLA", "LUFKIN AUTOMATION")
			End If
			If Not RSWIN_DESC.rst.gbBatch Then
				If RSWIN_DESC.bRSWINEXE And Not RSWIN_DESC.bExpert Then
					Interaction.Beep()
					Dim sMsg As String = text
					Dim sMsgType As String = ""
					Dim bClosing As Boolean = False
					Dim dialogResult As DialogResult = DialogResult.OK
					Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
				ElseIf Not RSWIN_DESC.bSuppressWarningMessages Then
					Interaction.Beep()
					Dim sMsg2 As String = text
					Dim sMsgType2 As String = ""
					Dim bClosing2 As Boolean = False
					Dim dialogResult As DialogResult = DialogResult.OK
					Util.SendMessage(sMsg2, sMsgType2, bClosing2, dialogResult)
				ElseIf RSWIN_DESC.bExpert And RSWIN_DESC.bOneGuruFile And Not RSWIN_DESC.bImprovingScore And Not RSWIN_DESC.bSuppressWarningMessages Then
					Try
						RSWIN_DESC.frmMain.StopRunAni()
					Catch ex As Exception
					End Try
					Interaction.Beep()
					Dim sMsg3 As String = text
					Dim sMsgType3 As String = ""
					Dim bClosing3 As Boolean = False
					Dim dialogResult As DialogResult = DialogResult.OK
					Util.SendMessage(sMsg3, sMsgType3, bClosing3, dialogResult)
				End If
				If wMsgType = 16 Then
					Util.UnbusyCursor()
					ProjectData.EndApp()
				End If
				Return
			End If
			If Not RSWIN_DESC.bSuppressWarningMessages Then
				Batch.BatchMessage(text)
				Return
			End If
		End Sub

		Public Function WindowsVersion() As Single
			Dim num As Integer = Conversions.ToInteger(Application.ProductVersion)
			Dim result As Single
			Return result
		End Function

		Public Function YesNo(msg As String, bDefaultYes As Boolean, Optional ByRef bAnswered As Boolean = False) As Boolean
			Dim result As Boolean
			Try
				If RSWIN_DESC.rst.gbBatch Then
					result = bDefaultYes
					Application.DoEvents()
				Else
					Dim dialogResult As DialogResult
					If RSWIN_DESC.bRSWINEXE And Not RSWIN_DESC.bSuppressWarningMessages Then
						bAnswered = True
						dialogResult = MessageBox.Show(msg, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
					Else
						dialogResult = DialogResult.No
					End If
					If dialogResult = DialogResult.Yes Then
						result = True
					Else
						result = False
					End If
				End If
			Catch ex As Exception
				MessageBox.Show("Error in YesNo: " + ex.Message)
			End Try
			Return result
		End Function

		Public Sub ApplyNumber(Value As Single, ByRef sTarget As String)
			Dim obj As Object = Strings.InStr(sTarget, "%{", CompareMethod.Binary)
			If Operators.ConditionalCompareObjectEqual(obj, 0, False) Then
				Return
			End If
			Dim obj2 As Object = Strings.InStr(Conversions.ToInteger(obj), sTarget, "}", CompareMethod.Binary)
			If Operators.ConditionalCompareObjectEqual(obj2, 0, False) Then
				Return
			End If
			Dim text As String = Strings.Mid(sTarget, Conversions.ToInteger(Operators.AddObject(obj, 2)), Conversions.ToInteger(Operators.SubtractObject(Operators.SubtractObject(obj2, obj), 2)))
			Dim str As String = Strings.Left(sTarget, Conversions.ToInteger(Operators.SubtractObject(obj, 1)))
			Dim str2 As String = Strings.Mid(sTarget, Conversions.ToInteger(Operators.AddObject(obj2, 1)))
			Dim str3 As String = Util.Format(Value, text)
			sTarget = str + str3 + str2
		End Sub

		Public Function CheckLowerQuiet(ByRef v As Object, LowerBound As Single, Inclusive As Integer, iErrnum As Integer, bUseMetric As Boolean, CanadianIsMetric As Integer, iErrOut As Integer) As Integer
			Dim result As Integer = 0
			If Information.IsDBNull(RuntimeHelpers.GetObjectValue(v)) Then
				result = -1
			Else
				Dim num As Integer = Conversions.ToInteger(Interaction.IIf(Inclusive <> 0, RuntimeHelpers.GetObjectValue(Operators.CompareObjectLess(v, LowerBound, False)), RuntimeHelpers.GetObjectValue(Operators.CompareObjectLessEqual(v, LowerBound, False))))
				If Not num <> 0 Then
					result = -1
				ElseIf iErrnum > 0 Then
					If bUseMetric Then
						If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
							If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
								iErrOut = iErrnum + 1
							ElseIf CanadianIsMetric <> 0 Then
								iErrOut = iErrnum + 1
							End If
						End If
					End If
				End If
			End If
			Return result
		End Function

		Public Sub cInfomsg(iErrnum As Integer)
			Util.DoError(RSWIN_DESC.sNull, iErrnum, 64)
		End Sub

		Public Sub cInfomsgECM(iErrnum_E As Integer, iErrnum_C As Integer, iErrnum_M As Integer)
			Dim iErrorNumber As Integer
			Select Case RSWIN_DESC.SETUP_MeasurementSystem
				Case 1
					iErrorNumber = iErrnum_E
				Case 2
					iErrorNumber = iErrnum_C
				Case 3
					iErrorNumber = iErrnum_M
			End Select
			Util.DoError(RSWIN_DESC.sNull, iErrorNumber, 64)
		End Sub

		Public Sub CopyMCMToClipboard(M As Single)
			Dim flag As Boolean = CLIPXML.XDW_CopyMCMToCLIPXML(M, 1)
		End Sub

		Public Sub CopyMCMToClipboard_Save(M As Object)
			Dim format As DataFormats.Format = DataFormats.GetFormat("THETA_CBALANCE_IMPORT")
			Dim csImportedMoment As Util.csImportedMoment = New Util.csImportedMoment()
			csImportedMoment.CBMoment = Conversions.ToString(Operators.ConcatenateObject("RSWINV3: ", M))
			csImportedMoment.wSource = 1
			Dim data As DataObject = New DataObject(format.Name, csImportedMoment)
			Clipboard.SetDataObject(data, True)
			Dim dataObject As IDataObject = Clipboard.GetDataObject()
			Dim csImportedMoment2 As Util.csImportedMoment = New Util.csImportedMoment()
			csImportedMoment2 = CType(dataObject.GetData(format.Name, False), Util.csImportedMoment)
		End Sub

		Public Function CheckBoxValue(Checked As Boolean) As Boolean
			Return Conversions.ToBoolean(Interaction.IIf(Checked, True, False))
		End Function

		Public Function CheckBoxChecked(CheckBoxValue As Boolean) As Boolean
			Return CheckBoxValue
		End Function

		Public Sub SetComboColor(ByRef cbo As ComboBox)
			If cbo.Enabled Then
				If cbo.SelectedIndex = -1 Then
					cbo.BackColor = Color.Yellow
				Else
					cbo.BackColor = Color.White
				End If
			End If
		End Sub

		Public Sub SetFieldColor(ByRef txt As System.Windows.Forms.TextBox)
			If txt.Enabled Then
				If Operators.CompareString(txt.Text, "", False) = 0 Then
					txt.BackColor = Color.Yellow
				Else
					txt.BackColor = Color.White
				End If
			End If
		End Sub

		Public Sub CreateBatchApplicationLog()
			Try
				If Not EventLog.SourceExists("RSWIN_BATCH: " + RSWIN_DESC.rst.WellName) Then
					EventLog.CreateEventSource("RSWIN_BATCH: " + RSWIN_DESC.rst.WellName, "Application")
					Console.WriteLine("CreatingEventSource")
				End If
				RSWIN_DESC.objLog.Source = "RSWIN_BATCH: " + RSWIN_DESC.rst.WellName
				RSWIN_DESC.objLog.Log = "Application"
			Catch ex As Exception
				MessageBox.Show("Error in CreateBatchApplicationLog: " + RSWIN_DESC.objLog.Source + " : " + ex.Message)
			End Try
		End Sub

		Public Function Switch(Cond1 As Object, objRet1 As Object, Cond2 As Object, objRet2 As Object, Optional Cond3 As Boolean = False, Optional objRet3 As Object = Nothing, Optional Cond4 As Boolean = False, Optional objRet4 As Object = Nothing, Optional Cond5 As Boolean = False, Optional objRet5 As Object = Nothing, Optional Cond6 As Boolean = False, Optional objRet6 As Object = Nothing, Optional Cond7 As Boolean = False, Optional objRet7 As Object = Nothing, Optional Cond8 As Boolean = False, Optional objRet8 As Object = Nothing, Optional Cond9 As Boolean = False, Optional objRet9 As Object = Nothing, Optional Cond10 As Boolean = False, Optional objRet10 As Object = Nothing) As Object
			Dim flag As Boolean = True
			If Operators.ConditionalCompareObjectEqual(flag, Cond1, False) Then
				Return objRet1
			End If
			If Operators.ConditionalCompareObjectEqual(flag, Cond2, False) Then
				Return objRet2
			End If
			If flag = Cond3 Then
				Return objRet3
			End If
			If flag = Cond4 Then
				Return objRet4
			End If
			If flag = Cond5 Then
				Return objRet5
			End If
			If flag = Cond6 Then
				Return objRet6
			End If
			If flag = Cond7 Then
				Return objRet7
			End If
			If flag = Cond8 Then
				Return objRet8
			End If
			If flag = Cond9 Then
				Return objRet9
			End If
			If flag = Cond10 Then
				Return objRet10
			End If
			Dim result As Object
			Return result
		End Function

		Public Function Format(ByRef myVar As Short, ByRef myFormat As String) As String
			Dim result As String
			Try
				If Operators.CompareString(myFormat, "", False) = 0 Then
					result = myVar.ToString()
				Else
					result = myVar.ToString(myFormat)
				End If
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Function Format(ByRef myVar As DateTime, ByRef myFormat As String) As String
			Dim result As String
			Try
				If Operators.CompareString(myFormat, "", False) = 0 Then
					result = myVar.ToString()
				Else
					result = myVar.ToString(myFormat)
				End If
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Function Format(ByRef myVar As Single, ByRef myFormat As String) As String
			Dim result As String
			Try
				If Operators.CompareString(myFormat, "", False) = 0 Then
					result = myVar.ToString()
				Else
					Dim text As String = myVar.ToString(myFormat)
					If(myVar = 0F And Operators.CompareString(text, "", False) = 0) Or text = Nothing Then
						text = "0"
					ElseIf text.Length > 1 And Operators.CompareString(text.Substring(0, 1), "0", False) = 0 Then
						If Operators.CompareString(text.Substring(1, 1), ".", False) <> 0 And Operators.CompareString(text.Substring(1, 1), ",", False) <> 0 Then
							' The following expression was wrapped in a checked-expression
							text = text.Substring(1, text.Length - 1)
						End If
					ElseIf text.Length = 0 And Conversions.ToDouble(myVar.ToString()) > 0.0 Then
						text = myVar.ToString()
					End If
					result = text
				End If
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Function Format(ByRef myVar As Integer, ByRef myFormat As String) As String
			Dim result As String
			Try
				If Operators.CompareString(myFormat, "", False) = 0 Then
					result = myVar.ToString()
				Else
					result = myVar.ToString(myFormat)
				End If
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Function Format(ByRef myVar As Double, ByRef myFormat As String) As String
			Dim result As String
			Try
				If Operators.CompareString(myFormat, "", False) = 0 Then
					result = myVar.ToString()
				Else
					Dim text As String = myVar.ToString(myFormat)
					If Operators.CompareString(text, "", False) = 0 Then
						text = myVar.ToString()
					End If
					result = text
				End If
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Function Format(ByRef myVar As Object) As String
			Dim result As String
			Try
				result = myVar.ToString()
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Function GetLastDepth(ByRef myDataSet As DataSet, bConvert As Boolean, iDS As Integer) As Single
			Dim num As Single = 0F
			Try
				For Each obj As Object In myDataSet.Tables(0).Rows
					Dim dataRow As DataRow = CType(obj, DataRow)
					If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow("Depth"))) AndAlso Operators.ConditionalCompareObjectLess(num, dataRow("Depth"), False) Then
						num = Conversions.ToSingle(dataRow("Depth"))
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			If bConvert And RSWIN_DESC.SETUP_MeasurementSystem <> 1 And iDS = 0 Then
				CtrlUI.ConvertValue(num, "f", True)
			End If
			Return num
		End Function

		Public Function GetWellnameFromLastTempDeviationProfile(ByRef sWellName As String) As Boolean
			sWellName = ""
			Dim result As Boolean
			Try
				Dim flag As Boolean = True
				Dim str As String = "temp.deviationprofile"
				Dim str2 As String = Interaction.Environ("USERPROFILE") + "\Application Data\ThetaData\" + VERSION1.ProgramName()
				Dim fileName As String = str2 + "\" + str
				If Not FILEUTIL.FileExists(fileName) Then
					result = False
				Else
					Dim num As Integer = FileSystem.FreeFile()
					FileSystem.FileOpen(num, fileName, OpenMode.Input, OpenAccess.[Default], OpenShare.[Default], -1)
					Dim num2 As Integer
					FileSystem.Input(num, num2)
					Dim num3 As Integer = num2
					If num3 = 1 Then
						Dim num4 As Integer
						FileSystem.Input(num, num4)
						If num4 > 0 Then
							Dim array As Double() = New Double(num4 - 1 + 1 - 1) {}
							Dim array2 As String() = New String(num4 - 1 + 1 - 1) {}
							Dim array3 As String() = New String(num4 - 1 + 1 - 1) {}
							Dim num5 As Integer = 0
							Dim num6 As Integer = num4 - 1
							For i As Integer = num5 To num6
								FileSystem.Input(num, array(i))
								FileSystem.Input(num, array3(i))
								FileSystem.Input(num, array2(i))
							Next
						Else
							flag = False
						End If
						Try
							FileSystem.Input(num, sWellName)
						Catch ex As Exception
							flag = False
						End Try
					End If
					FileSystem.FileClose(New Integer() { num })
					result = flag
					result = flag
				End If
			Catch ex2 As Exception
				Try
					Dim num As Integer
					FileSystem.FileClose(New Integer() { num })
					result = False
					ProjectData.ClearProjectError()
				Catch ex3 As Exception
				End Try
			End Try
			Return result
		End Function

		Public Sub OpenResourceReader(sFrm As String)
			Try
				RSWIN_DESC.RzX = New ResXResourceReader(sFrm.Trim() + "." + RSWIN_DESC.SETUP_Language + ".resx")
			Catch ex As Exception
			End Try
		End Sub

		Public Sub ReadResourceResxReader(ByRef myKeyValueHT As Hashtable)
			Try
				RSWIN_DESC.RzxEn = RSWIN_DESC.RzX.GetEnumerator()
				myKeyValueHT.Clear()
				While RSWIN_DESC.RzxEn.MoveNext()
					myKeyValueHT.Add(RuntimeHelpers.GetObjectValue(RSWIN_DESC.RzxEn.Key), RuntimeHelpers.GetObjectValue(RSWIN_DESC.RzxEn.Value))
				End While
			Catch ex As Exception
			End Try
		End Sub

		Public Function ConvertToDouble(sVar As String) As Single
			Dim result As Single
			Try
				Util.CheckDecimal(sVar)
				result = CSng(Convert.ToDouble(sVar))
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Function ConvertToSingle(sVar As String) As Single
			Dim result As Single
			Try
				Util.CheckDecimal(sVar)
				result = Convert.ToSingle(sVar)
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Function ConvertToInt16(sVar As String) As Object
			Dim result As Object
			Try
				Util.CheckDecimal(sVar)
				result = Convert.ToInt16(sVar)
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Function ConvertToInt32(sVar As String) As Object
			Dim result As Object
			Try
				Util.CheckDecimal(sVar)
				result = Convert.ToInt32(sVar)
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Sub CheckDecimal(ByRef sVar As String)
			Try
				If Strings.InStr(sVar, ".", CompareMethod.Binary) > 0 And Strings.InStr(sVar, ",", CompareMethod.Binary) = 0 And Operators.CompareString(RSWIN_DESC.NumFormatInfo.NumberDecimalSeparator, ".", False) <> 0 Then
					sVar = sVar.Replace(".", RSWIN_DESC.NumFormatInfo.NumberDecimalSeparator)
				ElseIf Strings.InStr(sVar, ",", CompareMethod.Binary) > 0 And Strings.InStr(sVar, ".", CompareMethod.Binary) = 0 And Operators.CompareString(RSWIN_DESC.NumFormatInfo.NumberDecimalSeparator, ",", False) <> 0 Then
					sVar = sVar.Replace(",", RSWIN_DESC.NumFormatInfo.NumberDecimalSeparator)
				End If
			Catch ex As Exception
			End Try
		End Sub

		Public Function CheckDec(sVar As String) As String
			Dim text As String = sVar
			Try
				If Strings.InStr(text, ".", CompareMethod.Binary) > 0 And Strings.InStr(text, ",", CompareMethod.Binary) = 0 And Operators.CompareString(RSWIN_DESC.NumFormatInfo.NumberDecimalSeparator, ".", False) <> 0 Then
					text = text.Replace(".", RSWIN_DESC.NumFormatInfo.NumberDecimalSeparator)
				ElseIf Strings.InStr(text, ",", CompareMethod.Binary) > 0 And Strings.InStr(text, ".", CompareMethod.Binary) = 0 And Operators.CompareString(RSWIN_DESC.NumFormatInfo.NumberDecimalSeparator, ",", False) <> 0 Then
					text = text.Replace(",", RSWIN_DESC.NumFormatInfo.NumberDecimalSeparator)
				End If
			Catch ex As Exception
			End Try
			Return text
		End Function

		Public Sub CheckFluidSPGR()
			Try
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				rst.gfMaxFluidSPGR = 0F
				Dim flag As Boolean = True
				If flag <> Not Versioned.IsNumeric(rst.OilAPI) Then
					If flag <> Not Versioned.IsNumeric(rst.WaterCut) Then
						If flag <> Not Versioned.IsNumeric(rst.WaterSPGR) Then
							rst.gfMaxFluidSPGR = LoadXDG.MaxFluidSPGR(rst.WaterCut, rst.WaterSPGR, rst.OilSPGR)
							rst.gfMaxFluidSPGR = CSng((Conversion.Int(CDbl((10000F * rst.gfMaxFluidSPGR)) + 0.5) / 10000.0))
						End If
					End If
				End If
			Catch ex As Exception
			End Try
		End Sub

		Public Sub OpenResourceWriter(sFrm As String)
			Try
				RSWIN_DESC.RwX = New ResXResourceWriter(sFrm.Trim() + "." + RSWIN_DESC.SETUP_Language + ".resx")
			Catch ex As Exception
			End Try
		End Sub

		Public Sub CloseResourceWriter()
			Try
				RSWIN_DESC.RwX.Generate()
				RSWIN_DESC.RwX.Close()
			Catch ex As Exception
			End Try
		End Sub

		Public Sub WriteControlStrings(frm As Form, Optional objTT As ToolTip = Nothing)
			Try
				Try
					For Each obj As Object In frm.Controls
						Dim control As Control = CType(obj, Control)
						Try
							Util.AddRexResource(control.Name, control.Text, control, True, frm.Name, objTT)
							Try
								For Each obj2 As Object In control.Controls
									Dim control2 As Control = CType(obj2, Control)
									Try
										Util.AddRexResource(control2.Name, control2.Text, control2, True, frm.Name, objTT)
										Try
											For Each obj3 As Object In control2.Controls
												Dim control3 As Control = CType(obj3, Control)
												Try
													Util.AddRexResource(control3.Name, control3.Text, control3, True, frm.Name, objTT)
													Try
														For Each obj4 As Object In control3.Controls
															Dim control4 As Control = CType(obj4, Control)
															Try
																Util.AddRexResource(control4.Name, control4.Text, control4, True, frm.Name, objTT)
																Try
																	For Each obj5 As Object In control4.Controls
																		Dim control5 As Control = CType(obj5, Control)
																		Try
																			Util.AddRexResource(control5.Name, control5.Text, control5, True, frm.Name, objTT)
																			Try
																				For Each obj6 As Object In control5.Controls
																					Dim control6 As Control = CType(obj6, Control)
																					Try
																						Util.AddRexResource(control6.Name, control6.Text, control6, True, frm.Name, objTT)
																					Catch ex As Exception
																					End Try
																				Next
																			Finally
																				Dim enumerator6 As IEnumerator
																				If TypeOf enumerator6 Is IDisposable Then
																					TryCast(enumerator6, IDisposable).Dispose()
																				End If
																			End Try
																		Catch ex2 As Exception
																		End Try
																	Next
																Finally
																	Dim enumerator5 As IEnumerator
																	If TypeOf enumerator5 Is IDisposable Then
																		TryCast(enumerator5, IDisposable).Dispose()
																	End If
																End Try
															Catch ex3 As Exception
															End Try
														Next
													Finally
														Dim enumerator4 As IEnumerator
														If TypeOf enumerator4 Is IDisposable Then
															TryCast(enumerator4, IDisposable).Dispose()
														End If
													End Try
												Catch ex4 As Exception
												End Try
											Next
										Finally
											Dim enumerator3 As IEnumerator
											If TypeOf enumerator3 Is IDisposable Then
												TryCast(enumerator3, IDisposable).Dispose()
											End If
										End Try
									Catch ex5 As Exception
									End Try
								Next
							Finally
								Dim enumerator2 As IEnumerator
								If TypeOf enumerator2 Is IDisposable Then
									TryCast(enumerator2, IDisposable).Dispose()
								End If
							End Try
						Catch ex6 As Exception
						End Try
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
			Catch ex7 As Exception
			End Try
		End Sub

		Public Sub AddRexResource(sKey As String, sVal As String, ByRef objControl As Control, Optional bTag As Boolean = False, Optional sFrmName As String = "", Optional objTT As ToolTip = Nothing)
			Dim listBox As ListBox = New ListBox()
			Try
				sKey = sKey.ToLower()
				If(TypeOf objControl Is System.Windows.Forms.Label And objControl.Height > 2 And objControl.Width > 2) Or TypeOf objControl Is GroupBox Or TypeOf objControl Is System.Windows.Forms.CheckBox Or TypeOf objControl Is RadioButton Or TypeOf objControl Is System.Windows.Forms.RichTextBox Or TypeOf objControl Is Button Then
					RSWIN_DESC.RwX.AddResource(sKey, sVal)
					If bTag And objControl.Tag IsNot Nothing Then
						RSWIN_DESC.RwX.AddResource(sKey + "-TAG", RuntimeHelpers.GetObjectValue(objControl.Tag))
					End If
					If objTT IsNot Nothing Then
						If objTT.GetToolTip(objControl) <> Nothing And Operators.CompareString(objTT.GetToolTip(objControl), "", False) <> 0 Then
							RSWIN_DESC.RwX.AddResource(sKey + "-Tooltip", objTT.GetToolTip(objControl))
						End If
					End If
				ElseIf TypeOf objControl Is System.Windows.Forms.ToolBar Then
					Util.WriteToolBarInfoToRexResource(CType(objControl, System.Windows.Forms.ToolBar))
				ElseIf TypeOf objControl Is ListBox Then
					listBox = CType(objControl, ListBox)
					Dim num As Integer = 0
					Dim num2 As Integer = listBox.Items.Count - 1
					For i As Integer = num To num2
						RSWIN_DESC.RwX.AddResource(String.Concat(New String() { sFrmName, "-", sKey, "-", i.ToString() }), RuntimeHelpers.GetObjectValue(listBox.Items(i)))
					Next
					If objTT IsNot Nothing AndAlso (objTT.GetToolTip(listBox) <> Nothing And Operators.CompareString(objTT.GetToolTip(listBox), "", False) <> 0) Then
						RSWIN_DESC.RwX.AddResource(sKey + "-Tooltip", objTT.GetToolTip(objControl))
					End If
				End If
			Catch ex As Exception
			End Try
		End Sub

		Public Sub WriteToolBarInfoToRexResource(objControl As System.Windows.Forms.ToolBar)
			' The following expression was wrapped in a checked-statement
			Try
				Dim num As Integer = 0
				Dim num2 As Integer = objControl.Buttons.Count - 1
				For i As Integer = num To num2
					RSWIN_DESC.RwX.AddResource(objControl.Name + " - " + i.ToString(), objControl.Buttons(i).Text)
					If Operators.CompareString(objControl.Buttons(i).ToolTipText, "", False) <> 0 Then
						RSWIN_DESC.RwX.AddResource(objControl.Name + "-ToolTipText-" + i.ToString(), objControl.Buttons(i).ToolTipText)
					End If
				Next
			Catch ex As Exception
			End Try
		End Sub

		Public Sub WriteMainMenuToRexResource(objControl As MainMenu, sMenu As String)
			' The following expression was wrapped in a checked-statement
			Try
				Dim num As Integer = 0
				Dim num2 As Integer = objControl.MenuItems.Count - 1
				For i As Integer = num To num2
					RSWIN_DESC.RwX.AddResource(sMenu + " - " + i.ToString(), objControl.MenuItems(i).Text)
				Next
			Catch ex As Exception
			End Try
		End Sub

		Public Sub WriteTabControlToRexResource(objControl As TabControl)
			Try
			Catch ex As Exception
			End Try
		End Sub

		Public Sub WriteContextMenuToRexResource(objControl As ContextMenu)
			Try
			Catch ex As Exception
			End Try
		End Sub

		Public Sub WriteChartStrings(myCht As Chart)
			' The following expression was wrapped in a checked-statement
			Try
				Dim num As Integer = 0
				Dim count As Integer = myCht.Titles.Count
				For i As Integer = num To count
					RSWIN_DESC.RwX.AddResource(myCht.Name + " - Titles" + i.ToString(), myCht.Titles(i).Text)
				Next
				Dim axisX As AxisX = myCht.AxisX
				Dim axisY As AxisY = myCht.AxisY
				RSWIN_DESC.RwX.AddResource(myCht.Name + " - axisX.Title.Text", axisX.Title.Text)
				RSWIN_DESC.RwX.AddResource(myCht.Name + " - axisY.Title.Text", axisY.Title.Text)
			Catch ex As Exception
			End Try
		End Sub

		Public Sub OpenResourceReader()
			Try
				If Not RSWIN_DESC.bRunningChineseVersion Then
					RSWIN_DESC.RzX = New ResXResourceReader(Application.StartupPath + "\AllStrings.resx")
				End If
			Catch ex As Exception
			End Try
		End Sub

		Public Sub CloseResourceReader()
			Try
				RSWIN_DESC.RzX.Close()
			Catch ex As Exception
			End Try
		End Sub

		Public Sub AssignValuesToControls(frm As Form)
			Try
				Dim text As String = frm.Name.Trim() + "-" + RSWIN_DESC.SETUP_Language.Trim() + "-"
				If RSWIN_DESC.bRunningChineseVersion And RSWIN_DESC.clsGlobal Is Nothing Then
					RSWIN_DESC.clsGlobal = New cGlobal()
					cGlobal.Lang = New ResourceManager("RSWINV3.RSWStrings_zh-Hans", GetType(RODSTAR).Assembly)
				End If
				Try
					Util.AssignValueToForm(text + "caption", frm)
				Catch ex As Exception
				End Try
				Try
					For Each obj As Object In frm.Controls
						Dim control As Control = CType(obj, Control)
						Try
							Util.AssignValueToControl(text, control)
							Try
								For Each obj2 As Object In control.Controls
									Dim control2 As Control = CType(obj2, Control)
									Try
										Util.AssignValueToControl(text, control2)
										Try
											For Each obj3 As Object In control2.Controls
												Dim control3 As Control = CType(obj3, Control)
												Try
													Util.AssignValueToControl(text, control3)
													Try
														For Each obj4 As Object In control3.Controls
															Dim control4 As Control = CType(obj4, Control)
															Try
																Util.AssignValueToControl(text, control4)
																Try
																	For Each obj5 As Object In control4.Controls
																		Dim control5 As Control = CType(obj5, Control)
																		Try
																			Util.AssignValueToControl(text, control5)
																			Try
																				For Each obj6 As Object In control5.Controls
																					Dim control6 As Control = CType(obj6, Control)
																					Try
																						Util.AssignValueToControl(text, control6)
																						Try
																							For Each obj7 As Object In control6.Controls
																								Dim control7 As Control = CType(obj7, Control)
																								Try
																									Util.AssignValueToControl(text, control7)
																									Try
																										For Each obj8 As Object In control7.Controls
																											Dim control8 As Control = CType(obj8, Control)
																											Try
																												Util.AssignValueToControl(text, control8)
																											Catch ex2 As Exception
																											End Try
																										Next
																									Finally
																										Dim enumerator8 As IEnumerator
																										If TypeOf enumerator8 Is IDisposable Then
																											TryCast(enumerator8, IDisposable).Dispose()
																										End If
																									End Try
																								Catch ex3 As Exception
																								End Try
																							Next
																						Finally
																							Dim enumerator7 As IEnumerator
																							If TypeOf enumerator7 Is IDisposable Then
																								TryCast(enumerator7, IDisposable).Dispose()
																							End If
																						End Try
																					Catch ex4 As Exception
																					End Try
																				Next
																			Finally
																				Dim enumerator6 As IEnumerator
																				If TypeOf enumerator6 Is IDisposable Then
																					TryCast(enumerator6, IDisposable).Dispose()
																				End If
																			End Try
																		Catch ex5 As Exception
																		End Try
																	Next
																Finally
																	Dim enumerator5 As IEnumerator
																	If TypeOf enumerator5 Is IDisposable Then
																		TryCast(enumerator5, IDisposable).Dispose()
																	End If
																End Try
															Catch ex6 As Exception
															End Try
														Next
													Finally
														Dim enumerator4 As IEnumerator
														If TypeOf enumerator4 Is IDisposable Then
															TryCast(enumerator4, IDisposable).Dispose()
														End If
													End Try
												Catch ex7 As Exception
												End Try
											Next
										Finally
											Dim enumerator3 As IEnumerator
											If TypeOf enumerator3 Is IDisposable Then
												TryCast(enumerator3, IDisposable).Dispose()
											End If
										End Try
									Catch ex8 As Exception
									End Try
								Next
							Finally
								Dim enumerator2 As IEnumerator
								If TypeOf enumerator2 Is IDisposable Then
									TryCast(enumerator2, IDisposable).Dispose()
								End If
							End Try
						Catch ex9 As Exception
						End Try
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
			Catch ex10 As Exception
			End Try
		End Sub

		Public Sub ReadResourceResxReader()
			Try
				RSWIN_DESC.RzxEn = RSWIN_DESC.RzX.GetEnumerator()
				RSWIN_DESC.RzxEn.Reset()
				RSWIN_DESC.myALLKeyValueHT.Clear()
				While RSWIN_DESC.RzxEn.MoveNext()
					Dim text As String = Conversions.ToString(RSWIN_DESC.RzxEn.Key)
					Dim text2 As String = Conversions.ToString(RSWIN_DESC.RzxEn.Value)
					RSWIN_DESC.myALLKeyValueHT.Add(text.Trim(), text2.Trim())
				End While
			Catch ex As Exception
			End Try
		End Sub

		Public Sub ReadTextFileAndPrintResXResouceFile(sTxtFilename As String)
			Dim array As Integer() = New Integer(500) {}
			Dim array2 As String() = New String(500) {}
			Try
				Util.BusyCursor()
				Dim fileName As String = RSWIN.App.Path + "\" + sTxtFilename + ".txt"
				If FILEUTIL.FileExists(fileName) Then
					Dim num As Short = CShort(FileSystem.FreeFile())
					FileSystem.FileOpen(CInt(num), fileName, OpenMode.Input, OpenAccess.[Default], OpenShare.[Default], -1)
					Dim num2 As Integer = 0
					FileSystem.Seek(CInt(num), 1L)
					Util.OpenResourceWriter(sTxtFilename)
					While Not FileSystem.EOF(CInt(num))
						num2 += 1
						array(num2) = num2
						Dim text As String = FileSystem.LineInput(CInt(num))
						array2(num2) = text
						RSWIN_DESC.RwX.AddResource(num2.ToString(), text)
					End While
					Util.CloseResourceWriter()
					FileSystem.FileClose(New Integer() { CInt(num) })
				End If
			Catch ex As Exception
			End Try
			Util.UnbusyCursor()
		End Sub

		Public Sub ReadTextFileAndReorder(sFName As String, Optional bTemp As Boolean = False)
			Dim array As String() = New String(500) {}
			Try
				Util.BusyCursor()
				Dim fileName As String = RSWIN.App.Path + "\" + sFName + ".txt"
				If FILEUTIL.FileExists(fileName) Then
					Dim num As Short = CShort(FileSystem.FreeFile())
					FileSystem.FileOpen(CInt(num), fileName, OpenMode.Input, OpenAccess.[Default], OpenShare.[Default], -1)
					Dim num2 As Integer = 0
					FileSystem.Seek(CInt(num), 1L)
					While Not FileSystem.EOF(CInt(num))
						Dim text As String = FileSystem.LineInput(CInt(num))
						If bTemp AndAlso Operators.CompareString(text, "", False) <> 0 AndAlso Versioned.IsNumeric(text.Substring(0, 3)) Then
							num2 += 1
							Dim num3 As Integer = Convert.ToInt32(text.Substring(0, 3))
							array(num3) = text.Substring(3)
						End If
					End While
					FileSystem.FileClose(New Integer() { CInt(num) })
					Dim num4 As Short = CShort(FileSystem.FreeFile())
					FileSystem.FileOpen(CInt(num4), RSWIN.App.Path + "\" + sFName + ".new.txt", OpenMode.Output, OpenAccess.Write, OpenShare.[Default], -1)
					Dim num5 As Integer = 1
					Dim num6 As Integer = num2
					For i As Integer = num5 To num6
						FileSystem.PrintLine(CInt(num4), New Object() { i.ToString() + " , " + array(i) })
					Next
					FileSystem.FileClose(New Integer() { CInt(num4) })
				End If
			Catch ex As Exception
			End Try
			Util.UnbusyCursor()
		End Sub

		Public Sub ReadTextFileAndRewrite(sFName As String)
			Dim text As String = ""
			Dim array As String() = New String(500) {}
			Try
				Util.BusyCursor()
				Dim fileName As String = RSWIN.App.Path + "\" + sFName + ".txt"
				If FILEUTIL.FileExists(fileName) Then
					Dim num As Short = CShort(FileSystem.FreeFile())
					FileSystem.FileOpen(CInt(num), fileName, OpenMode.Input, OpenAccess.[Default], OpenShare.[Default], -1)
					Dim num2 As Short = CShort(FileSystem.FreeFile())
					FileSystem.FileOpen(CInt(num2), RSWIN.App.Path + "\" + sFName + ".new.txt", OpenMode.Output, OpenAccess.Write, OpenShare.[Default], -1)
					FileSystem.Seek(CInt(num), 1L)
					While Not FileSystem.EOF(CInt(num))
						Dim text2 As String = FileSystem.LineInput(CInt(num))
						If Strings.InStr(text2, "FORM_NAME", CompareMethod.Binary) > 0 Then
							text = text2.Substring(Strings.InStr(text2, "=", CompareMethod.Binary))
							FileSystem.PrintLine(CInt(num2), New Object() { "FORM_NAME=" + text })
							FileSystem.PrintLine(CInt(num2), New Object() { " " })
						ElseIf Operators.CompareString(text2.Trim(), "", False) <> 0 Then
							Dim text3 As String = FileSystem.LineInput(CInt(num))
							Dim num3 As Integer = Strings.InStr(text2, " ", CompareMethod.Binary)
							Dim num4 As Integer = Strings.InStr(text2, vbTab, CompareMethod.Binary)
							Dim num5 As Integer
							If num3 < num4 And num3 <> 0 Then
								num5 = num3
							ElseIf num4 < num3 And num4 <> 0 Then
								num5 = num4
							ElseIf num4 <> 0 Then
								num5 = num4
							ElseIf num3 <> 0 Then
								num5 = num3
							End If
							If num5 <> 0 Then
								Dim text4 As String = text2.Substring(0, num5).Trim()
								Dim text5 As String = text2.Substring(num5).Trim()
								FileSystem.PrintLine(CInt(num2), New Object() { String.Concat(New String() { text.Trim(), "-", RSWIN_DESC.sEnglish, "-", text4.Trim(), "  =  ", text5.Trim() }) })
								FileSystem.PrintLine(CInt(num2), New Object() { String.Concat(New String() { text.Trim(), "-", RSWIN_DESC.sSpanish, "-", text4.Trim(), "  =  ", text3.Trim() }) })
								FileSystem.PrintLine(CInt(num2), New Object() { " " })
							End If
						End If
					End While
					FileSystem.FileClose(New Integer() { CInt(num) })
					FileSystem.FileClose(New Integer() { CInt(num2) })
				End If
			Catch ex As Exception
			End Try
			Util.UnbusyCursor()
		End Sub

		Public Sub AssignValueToForm(sKey As String, ByRef objFrm As Form)
			Try
				If RSWIN_DESC.bRunningChineseVersion And RSWIN_DESC.clsGlobal Is Nothing Then
					RSWIN_DESC.clsGlobal = New cGlobal()
					cGlobal.Lang = New ResourceManager("RSWINV3.RSWStrings_zh-Hans", GetType(RODSTAR).Assembly)
				End If
				sKey = sKey.ToLower()
				If RSWIN_DESC.bRunningChineseVersion Then
					sKey = sKey.Replace("-zh-hans-", "-")
					Dim text As String = cGlobal.Lang.GetString(sKey)
					If text IsNot Nothing Then
						If Operators.CompareString(text.Trim(), "", False) <> 0 Then
							objFrm.Text = text
						End If
					End If
				ElseIf RSWIN_DESC.myALLKeyValueHT.ContainsKey(sKey) Then
					Dim text As String = Conversions.ToString(RSWIN_DESC.myALLKeyValueHT(sKey))
					objFrm.Text = text
				End If
			Catch ex As Exception
			End Try
		End Sub

		Public Sub AssignValueToControl(sPrefix As String, ByRef objControl As Control)
			Try
				If Strings.InStr(objControl.Name, "frmMaxProduction", CompareMethod.Binary) <> 0 Then
					Debug.WriteLine(" ")
				End If
				If(TypeOf objControl Is System.Windows.Forms.Label And objControl.Height > 2 And objControl.Width > 2) Or TypeOf objControl Is GroupBox Or TypeOf objControl Is System.Windows.Forms.CheckBox Or TypeOf objControl Is RadioButton Or TypeOf objControl Is System.Windows.Forms.RichTextBox Or TypeOf objControl Is Button Then
					Dim text As String = sPrefix.Trim() + objControl.Name.Trim()
					text = text.ToLower()
					If RSWIN_DESC.bRunningChineseVersion Then
						text = text.Replace("-zh-hans-", "-")
						Dim text2 As String = cGlobal.Lang.GetString(text)
						If text2 IsNot Nothing Then
							If Operators.CompareString(text2.Trim(), "", False) <> 0 Then
								Dim str As String = text2
								objControl.Text = text2
								text = sPrefix.Trim() + objControl.Name.Trim() + "-TAG"
								text = text.ToLower()
								text = text.Replace("-zh-hans-", "-")
								text2 = cGlobal.Lang.GetString(text)
								If text2 = Nothing And objControl.Tag IsNot Nothing Then
									If Strings.InStr(Conversions.ToString(objControl.Tag), "(^)", CompareMethod.Binary) > 0 Then
										objControl.Tag = str + " (^)"
									End If
								ElseIf text2 IsNot Nothing AndAlso Operators.CompareString(text2.Trim(), "", False) <> 0 Then
									objControl.Tag = text2
								End If
							End If
						End If
					ElseIf RSWIN_DESC.myALLKeyValueHT.ContainsKey(text) Then
						Dim text2 As String = Conversions.ToString(RSWIN_DESC.myALLKeyValueHT(text))
						objControl.Text = text2
						text = sPrefix.Trim() + objControl.Name.Trim() + "-TAG"
						text = text.ToLower()
						If RSWIN_DESC.myALLKeyValueHT.ContainsKey(text) Then
							objControl.Tag = RuntimeHelpers.GetObjectValue(RSWIN_DESC.myALLKeyValueHT(text))
						End If
					End If
				ElseIf TypeOf objControl Is System.Windows.Forms.ToolBar Then
					Dim toolBar As System.Windows.Forms.ToolBar = CType(objControl, System.Windows.Forms.ToolBar)
					Util.AssignToToolBar(sPrefix, toolBar)
					objControl = toolBar
				ElseIf Not(TypeOf objControl Is ListBox) Then
					Dim text As String = sPrefix + objControl.Name
					text = text.ToLower()
					If RSWIN_DESC.bRunningChineseVersion Then
						text = text.Replace("-zh-hans-", "-")
						Dim text2 As String = cGlobal.Lang.GetString(text)
						If text2 IsNot Nothing Then
							If Operators.CompareString(text2.Trim(), "", False) <> 0 Then
								objControl.Text = text2
								text = sPrefix + objControl.Name + "-TAG"
								text = text.ToLower()
								text = text.Replace("-zh-hans-", "-")
								text2 = cGlobal.Lang.GetString(text)
								If text2 IsNot Nothing AndAlso Operators.CompareString(text2.Trim(), "", False) <> 0 Then
									objControl.Tag = text2
								End If
							End If
						End If
					ElseIf RSWIN_DESC.myALLKeyValueHT.ContainsKey(text) Then
						objControl.Text = Conversions.ToString(RSWIN_DESC.myALLKeyValueHT(text))
						text = sPrefix + objControl.Name + "-TAG"
						text = text.ToLower()
						If RSWIN_DESC.myALLKeyValueHT.ContainsKey(text) Then
							objControl.Tag = RuntimeHelpers.GetObjectValue(RSWIN_DESC.myALLKeyValueHT(text))
						End If
					End If
				End If
			Catch ex As Exception
			End Try
		End Sub

		Public Function AssignValueToConstant(sModule As String, sConstantName As String, Optional sDefault As String = "") As String
			If RSWIN_DESC.bRunningChineseVersion And RSWIN_DESC.clsGlobal Is Nothing Then
				RSWIN_DESC.clsGlobal = New cGlobal()
				cGlobal.Lang = New ResourceManager("RSWINV3.RSWStrings_zh-Hans", GetType(RODSTAR).Assembly)
			End If
			If Not RSWIN_DESC.bResxReader Then
				Util.OpenResourceReader()
				Util.ReadResourceResxReader()
				Util.CloseResourceReader()
				RSWIN_DESC.bResxReader = True
			End If
			If Operators.CompareString(sDefault, "", False) = 0 Then
				sDefault = sConstantName
			End If
			If RSWIN_DESC.SETUP_Language Is Nothing Then
				Dim text As String = "Language"
				Dim text2 As String
				Dim regProfileString As Integer = RSWIN.GetRegProfileString(RSWIN_DESC.SECT_GENERAL, text, RSWIN_DESC.sEnglish, text2, False)
				RSWIN_DESC.SETUP_Language = text2.Substring(0, regProfileString)
			End If
			Dim result As String
			If RSWIN_DESC.bIntVersion Then
				Dim str As String = sModule + "-" + RSWIN_DESC.SETUP_Language + "-"
				Try
					Dim text3 As String = str + sConstantName
					text3 = text3.ToLower()
					If RSWIN_DESC.bRunningChineseVersion Then
						text3 = text3.Replace("-zh-hans-", "-")
						Dim [string] As String = cGlobal.Lang.GetString(text3)
						If [string] Is Nothing Then
							result = sDefault
						ElseIf [string] IsNot Nothing Then
							If Operators.CompareString([string].Trim(), "", False) <> 0 Then
								result = [string]
							End If
						End If
					Else
						If RSWIN_DESC.myALLKeyValueHT.ContainsKey(text3) Then
							Try
								Return Conversions.ToString(RSWIN_DESC.myALLKeyValueHT(text3))
							Catch ex As Exception
								Return result
							End Try
						End If
						result = sDefault
					End If
					Return result
				Catch ex2 As Exception
					Return sDefault
				End Try
			End If
			result = sDefault
			Return result
		End Function

		Public Sub AssignToToolBar(sPrefix As String, ByRef objControl As System.Windows.Forms.ToolBar)
			' The following expression was wrapped in a checked-statement
			Try
				If RSWIN_DESC.bRunningChineseVersion And RSWIN_DESC.clsGlobal Is Nothing Then
					RSWIN_DESC.clsGlobal = New cGlobal()
					cGlobal.Lang = New ResourceManager("RSWINV3.RSWStrings_zh-Hans", GetType(RODSTAR).Assembly)
				End If
				Dim num As Integer = 0
				Dim num2 As Integer = objControl.Buttons.Count - 1
				For i As Integer = num To num2
					Dim text As String = sPrefix + objControl.Name + " - " + i.ToString()
					text = text.ToLower()
					If RSWIN_DESC.bRunningChineseVersion Then
						text = text.Replace(" - ", "-").Trim()
						text = text.Replace("-zh-hans-", "-")
						Dim [string] As String = cGlobal.Lang.GetString(text)
						If [string] IsNot Nothing Then
							If Operators.CompareString([string].Trim(), "", False) <> 0 Then
								objControl.Buttons(i).Text = [string]
							End If
						End If
					ElseIf RSWIN_DESC.myALLKeyValueHT.ContainsKey(text) Then
						objControl.Buttons(i).Text = Conversions.ToString(RSWIN_DESC.myALLKeyValueHT(text))
					End If
					If Operators.CompareString(objControl.Buttons(i).ToolTipText, "", False) <> 0 Then
						text = sPrefix + objControl.Name + "-ToolTipText-" + i.ToString()
						text = text.ToLower()
						If RSWIN_DESC.bRunningChineseVersion Then
							text = text.Replace(" - ", "-").Trim()
							text = text.Replace("-zh-hans-", "-")
							Dim [string] As String = cGlobal.Lang.GetString(text)
							If [string] IsNot Nothing Then
								If Operators.CompareString([string].Trim(), "", False) <> 0 Then
									objControl.Buttons(i).ToolTipText = [string]
								End If
							End If
						ElseIf RSWIN_DESC.myALLKeyValueHT.ContainsKey(text) Then
							objControl.Buttons(i).ToolTipText = Conversions.ToString(RSWIN_DESC.myALLKeyValueHT(text))
						End If
					End If
				Next
			Catch ex As Exception
			End Try
		End Sub

		Public Sub AssignToListBox(sPrefix As String, ByRef objControl As ListBox)
			Dim listBox As ListBox = New ListBox()
			Try
				If RSWIN_DESC.bRunningChineseVersion And RSWIN_DESC.clsGlobal Is Nothing Then
					RSWIN_DESC.clsGlobal = New cGlobal()
					cGlobal.Lang = New ResourceManager("RSWINV3.RSWStrings_zh-Hans", GetType(RODSTAR).Assembly)
				End If
				listBox = objControl
				Dim num As Integer = 0
				Dim num2 As Integer = listBox.Items.Count - 1
				For i As Integer = num To num2
					Dim text As String = sPrefix + objControl.Name + " - " + i.ToString()
					text = text.ToLower()
					If RSWIN_DESC.bRunningChineseVersion Then
						text = text.Replace("-zh-hans-", "-")
						Dim [string] As String = cGlobal.Lang.GetString(text)
						If [string] IsNot Nothing Then
							If Operators.CompareString([string].Trim(), "", False) <> 0 Then
								listBox.Items(i) = [string]
							End If
						End If
					ElseIf RSWIN_DESC.myALLKeyValueHT.ContainsKey(text) Then
						listBox.Items(i) = RuntimeHelpers.GetObjectValue(RSWIN_DESC.myALLKeyValueHT(text))
					End If
					text = sPrefix + objControl.Name + "-Tooltip"
					text = text.ToLower()
					If RSWIN_DESC.bRunningChineseVersion Then
						text = text.Replace("-zh-hans-", "-")
						Dim [string] As String = cGlobal.Lang.GetString(text)
						If [string] IsNot Nothing Then
							If Operators.CompareString([string].Trim(), "", False) <> 0 Then
								Dim num3 As Single = Conversions.ToSingle([string])
								Dim toolTip As ToolTip
								toolTip.SetToolTip(objControl, Conversions.ToString(num3))
							End If
						End If
					ElseIf RSWIN_DESC.myALLKeyValueHT.ContainsKey(text) Then
						Dim num3 As Single = Conversions.ToSingle(RSWIN_DESC.myALLKeyValueHT(text))
						Dim toolTip As ToolTip
						toolTip.SetToolTip(objControl, Conversions.ToString(num3))
					End If
				Next
			Catch ex As Exception
			End Try
		End Sub

		Public Sub DebugRodGradeArrayList(myList As IEnumerable)
			Dim enumerator As IEnumerator = myList.GetEnumerator()
			Try
				While enumerator.MoveNext()
					Dim obj As Object = enumerator.Current
					Dim cRodGrade As cRodGrade = CType(obj, cRodGrade)
				End While
			Catch ex As Exception
			End Try
		End Sub

		Public Sub DebugRodSizeArrayList(myList As IEnumerable)
			Dim enumerator As IEnumerator = myList.GetEnumerator()
			Try
				While enumerator.MoveNext()
					Dim obj As Object = enumerator.Current
					Dim cRodSize As cRodSize = CType(obj, cRodSize)
				End While
			Catch ex As Exception
			End Try
		End Sub

		Public Sub SetLabelColor(fVal As Single, ByRef Label1 As DataDynamics.ActiveReports.Label, sFormat As String)
			Try
				Dim text As String = Util.Format(fVal, sFormat)
				If fVal > 1F And Operators.CompareString(text.Trim(), "100%", False) <> 0 Then
					Label1.ForeColor = Color.Red
				Else
					Label1.ForeColor = Color.Black
				End If
			Catch ex As Exception
			End Try
		End Sub

		Public Function IsPolyLined(fTubingID As Single) As Boolean
			Return fTubingID = 1.71F Or fTubingID = 2.16F Or fTubingID = 2.67F
		End Function

		Public Function CheckFrictionCoeffs() As Boolean
			' The following expression was wrapped in a checked-statement
			Dim result As Boolean
			Try
				Dim flag As Boolean = False
				If RSWIN_DESC.rst.RodStringType = 1S Or RSWIN_DESC.rst.RodStringType = 2S Or RSWIN_DESC.rst.RodStringType = 4S Then
					Dim num As Integer = 1
					Dim numRods As Integer = CInt(RSWIN_DESC.rst.NumRods)
					For i As Integer = num To numRods
						If RSWIN_DESC.rst.Sections(i).friction_coef >= RODUTIL.GetFricCoeff(CInt(RSWIN_DESC.rst.Sections(i).Guide), False) Then
							RSWIN_DESC.rst.Sections(i).friction_coef = RSWIN_DESC.rst.Sections(i).friction_coef / 2F
							flag = True
						End If
					Next
				ElseIf RSWIN_DESC.rst.RSFricCoef >= RODUTIL.GetFricCoeff(RSWIN_DESC.rst.RSRodGuide, False) Then
					RSWIN_DESC.rst.RSFricCoef = RSWIN_DESC.rst.RSFricCoef / 2F
					flag = True
				End If
				result = flag
			Catch ex As Exception
			End Try
			Return result
		End Function

		Private Const SzENGLISH As String = "e"

		Private Const SzMETRIC As String = "m"

		Private Const cnRODSTAR As Integer = 1

		Private Const cnRODDIAG As Integer = 2

		Private Const cnXDIAG As Integer = 3

		<AccessedThroughProperty("dlgSelectCBM")>
		Private _dlgSelectCBM As dlgSelectCBM

		Private $STATIC$LoadMessage$021810E$msgfrn As Short

		Private $STATIC$LoadMessageAgain$021810E$msgfrn As Short

		Private $STATIC$LoadMessage$021810E$numMsgs As Short

		Private $STATIC$LoadMessageAgain$021810E$numMsgs As Short

		Private $STATIC$LoadMessage$021810E$msgOffsets As Integer()

		Private $STATIC$LoadMessageAgain$021810E$msgOffsets As Integer()

		Public Structure IMPORTEDMOMENT
			Public CBMoment As Single

			Public wSource As Integer
		End Structure

		<Serializable()>
		Public Class csImportedMoment
			Public Property CBMoment As String
				Get
					Return Me.sngCBMoment
				End Get
				Set(value As String)
					Me.sngCBMoment = value
				End Set
			End Property

			Public Property wSource As Integer
				Get
					Return Me.iwSource
				End Get
				Set(value As Integer)
					Me.iwSource = value
				End Set
			End Property

			Private sngCBMoment As String

			Private iwSource As Integer
		End Class
	End Module
End Namespace
