Imports System
Imports System.Collections
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Threading
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	Public Class ExcelXLS
		Public Function XLWorkSheetCreate() As Boolean
			Dim result As Boolean
			Try
				Me.XLCreateSpreadSheet()
				result = True
			Catch ex As Exception
				result = False
			End Try
			Return result
		End Function

		Public Sub XLWorkSheetClose(bSaveOutput As Boolean, ByRef sFileName As String)
			Dim flag As Boolean = RSWIN_DESC.SETUP_BatchViewWorksheet <> 0
			Try
				If bSaveOutput Then
					Dim num As Integer = 65
					Do
						Dim text As String = Conversions.ToString(Strings.Chr(num)) + "1:" + Conversions.ToString(Strings.Chr(num)) + "20"
						Try
							Dim obj As Object = Me.oXLApp
							Dim type As Type = Nothing
							Dim text2 As String = "Range"
							Dim array As Object() = New Object() { text }
							Dim array2 As Object() = array
							Dim array3 As String() = Nothing
							Dim array4 As Type() = Nothing
							Dim array5 As Boolean() = New Boolean() { True }
							Dim obj2 As Object = NewLateBinding.LateGet(obj, type, text2, array2, array3, array4, array5)
							If array5(0) Then
								text = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array(0)), GetType(String)))
							End If
							NewLateBinding.LateCall(NewLateBinding.LateGet(obj2, Nothing, "Columns", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "AutoFit", New Object(-1) {}, Nothing, Nothing, Nothing, True)
						Catch ex As Exception
						End Try
						num += 1
					Loop While num <= 90
					num = 1
					Dim array10 As Object()
					Dim array14 As Boolean()
					Do
						Dim text As String = "A" + num.ToString().Trim() + ":Z" + num.ToString().Trim()
						Try
							Dim obj3 As Object = Me.oXLApp
							Dim type2 As Type = Nothing
							Dim text3 As String = "Range"
							Dim array6 As Object() = New Object() { text }
							Dim array7 As Object() = array6
							Dim array8 As String() = Nothing
							Dim array9 As Type() = Nothing
							Dim array5 As Boolean() = New Boolean() { True }
							Dim obj4 As Object = NewLateBinding.LateGet(obj3, type2, text3, array7, array8, array9, array5)
							If array5(0) Then
								text = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6(0)), GetType(String)))
							End If
							If Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet(NewLateBinding.LateGet(obj4, Nothing, "Columns", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "RowHeight", New Object(-1) {}, Nothing, Nothing, Nothing), 20, False) Then
								Dim obj5 As Object = Me.oXLApp
								Dim type3 As Type = Nothing
								Dim text4 As String = "Range"
								array10 = New Object() { text }
								Dim array11 As Object() = array10
								Dim array12 As String() = Nothing
								Dim array13 As Type() = Nothing
								array14 = New Boolean() { True }
								Dim obj6 As Object = NewLateBinding.LateGet(obj5, type3, text4, array11, array12, array13, array14)
								If array14(0) Then
									text = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array10(0)), GetType(String)))
								End If
								NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj6, Nothing, "Columns", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "RowHeight", New Object() { 13 }, Nothing, Nothing, False, True)
							End If
						Catch ex2 As Exception
						End Try
						num += 1
					Loop While num <= 100
					NewLateBinding.LateSet(Me.oXLApp, Nothing, "DisplayAlerts", New Object() { False }, Nothing, Nothing)
					Dim obj7 As Object = Me.oWB
					Dim type4 As Type = Nothing
					Dim text5 As String = "SaveAs"
					array10 = New Object() { sFileName }
					Dim array15 As Object() = array10
					Dim array16 As String() = New String() { "FileName" }
					Dim array17 As Type() = Nothing
					array14 = New Boolean() { True }
					NewLateBinding.LateCall(obj7, type4, text5, array15, array16, array17, array14, True)
					If array14(0) Then
						sFileName = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array10(0)), GetType(String)))
					End If
					NewLateBinding.LateSet(Me.oXLApp, Nothing, "DisplayAlerts", New Object() { True }, Nothing, Nothing)
					Try
						For Each obj8 As Object In CType(Me.oWBs, IEnumerable)
							Dim objectValue As Object = RuntimeHelpers.GetObjectValue(obj8)
							Try
								If Not flag Then
									If Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(objectValue, Nothing, "Name", New Object(-1) {}, Nothing, Nothing, Nothing), RSWIN_DESC.EXCELBATCHFILENAME, False) Then
										NewLateBinding.LateCall(objectValue, Nothing, "Close", New Object() { True }, New String() { "SaveChanges" }, Nothing, Nothing, True)
									Else
										NewLateBinding.LateCall(objectValue, Nothing, "Close", New Object() { False }, New String() { "SaveChanges" }, Nothing, Nothing, True)
									End If
								Else
									NewLateBinding.LateCall(objectValue, Nothing, "Save", New Object(-1) {}, Nothing, Nothing, Nothing, True)
								End If
							Catch ex3 As Exception
							End Try
						Next
					Finally
						Dim enumerator As IEnumerator
						If TypeOf enumerator Is IDisposable Then
							TryCast(enumerator, IDisposable).Dispose()
						End If
					End Try
					NewLateBinding.LateSet(Me.oXLApp, Nothing, "Visible", New Object() { flag }, Nothing, Nothing)
					NewLateBinding.LateSet(Me.oXLApp, Nothing, "UserControl", New Object() { flag }, Nothing, Nothing)
					Try
						Me.NAR(RuntimeHelpers.GetObjectValue(Me.oSheet))
						Me.NAR(RuntimeHelpers.GetObjectValue(Me.oWB))
						Me.NAR(RuntimeHelpers.GetObjectValue(Me.oWBs))
						If Not flag Then
							NewLateBinding.LateCall(Me.oXLApp, Nothing, "Quit", New Object(-1) {}, Nothing, Nothing, Nothing, True)
						End If
						Me.NAR(RuntimeHelpers.GetObjectValue(Me.oXLApp))
						Thread.Sleep(1000)
					Catch ex4 As Exception
					End Try
				End If
			Catch ex5 As Exception
				NewLateBinding.LateCall(Me.oXLApp, Nothing, "Quit", New Object(-1) {}, Nothing, Nothing, Nothing, True)
			End Try
		End Sub

		Public Sub XLMakeVisible(bVisible As Boolean)
			NewLateBinding.LateSet(Me.oXLApp, Nothing, "Visible", New Object() { bVisible }, Nothing, Nothing)
		End Sub

		Public Sub XLUserControl(bControl As Boolean)
			NewLateBinding.LateSet(Me.oXLApp, Nothing, "Visible", New Object() { bControl }, Nothing, Nothing)
			NewLateBinding.LateSet(Me.oXLApp, Nothing, "UserControl", New Object() { bControl }, Nothing, Nothing)
		End Sub

		Public Sub XLCreateSpreadSheet()
			If Me.oXLApp IsNot Nothing Then
				Me.oXLApp = Nothing
			End If
			Me.oXLApp = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("Excel.Application", ""))
			Try
				Me.oWBs = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Me.oXLApp, Nothing, "Workbooks", New Object(-1) {}, Nothing, Nothing, Nothing))
				Me.oWB = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Me.oWBs, Nothing, "Add", New Object(-1) {}, Nothing, Nothing, Nothing))
				Me.oSheet = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Me.oWB, Nothing, "ActiveSheet", New Object(-1) {}, Nothing, Nothing, Nothing))
				Dim obj As Object = Me.oWB
				NewLateBinding.LateSet(obj, Nothing, "Title", New Object() { RSWIN_DESC.EXCELBATCH }, Nothing, Nothing)
				NewLateBinding.LateSet(obj, Nothing, "Subject", New Object() { RSWIN_DESC.EXCELBATCH.ToLower() }, Nothing, Nothing)
				Me.oSheet = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Me.oWB, Nothing, "ActiveSheet", New Object(-1) {}, Nothing, Nothing, Nothing))
			Catch ex As Exception
			End Try
		End Sub

		Public Sub XLWorkSheetAddString(ByRef RowIndex As Integer, ByRef ColIndex As Integer, sCellValue As String)
			Try
				' The following expression was wrapped in a checked-expression
				NewLateBinding.LateSet(Me.oSheet, Nothing, "Cells", New Object() { RowIndex + 1, ColIndex + 1, sCellValue }, Nothing, Nothing)
			Catch ex As Exception
			End Try
		End Sub

		Public Sub XLWorkSheetAddCurrency(ByRef Row As Object, ByRef Col As Object, Num As Single, nDecPlaces As Object)
			Try
				Dim num As Integer = Conversions.ToInteger(Row)
				Dim num2 As Integer = Conversions.ToInteger(Col)
				Dim text As String = "C"
				Me.XLWorkSheetAddString(num, num2, Util.Format(Num, text))
				Col = num2
				Row = num
			Catch ex As Exception
			End Try
		End Sub

		Public Sub XLWorkSheetAddDate(ByRef Row As Short, ByRef Col As Short, aDate As DateTime)
			' The following expression was wrapped in a checked-statement
			Try
				Dim num As Integer = CInt(Row)
				Dim num2 As Integer = CInt(Col)
				Me.XLWorkSheetAddString(num, num2, aDate.ToShortDateString())
				Col = CShort(num2)
				Row = CShort(num)
			Catch ex As Exception
			End Try
		End Sub

		Public Sub XLWorkSheetAddFloat(ByRef Row As Short, ByRef Col As Short, Num As Single, nDecPlaces As Short)
			' The following expression was wrapped in a checked-statement
			Try
				Select Case nDecPlaces
					Case -1S, 0S
						Dim num As Integer = CInt(Row)
						Dim num2 As Integer = CInt(Col)
						Dim text As String = "#########"
						Me.XLWorkSheetAddString(num, num2, Util.Format(Num, text))
						Col = CShort(num2)
						Row = CShort(num)
					Case 1S
						Dim num2 As Integer = CInt(Row)
						Dim num As Integer = CInt(Col)
						Dim text As String = "#########.#"
						Me.XLWorkSheetAddString(num2, num, Util.Format(Num, text))
						Col = CShort(num)
						Row = CShort(num2)
					Case 2S
						Dim num2 As Integer = CInt(Row)
						Dim num As Integer = CInt(Col)
						Dim text As String = "#########.##"
						Me.XLWorkSheetAddString(num2, num, Util.Format(Num, text))
						Col = CShort(num)
						Row = CShort(num2)
					Case 3S
						Dim num2 As Integer = CInt(Row)
						Dim num As Integer = CInt(Col)
						Dim text As String = "#########.###"
						Me.XLWorkSheetAddString(num2, num, Util.Format(Num, text))
						Col = CShort(num)
						Row = CShort(num2)
					Case 4S
						Dim num2 As Integer = CInt(Row)
						Dim num As Integer = CInt(Col)
						Dim text As String = "#########.####"
						Me.XLWorkSheetAddString(num2, num, Util.Format(Num, text))
						Col = CShort(num)
						Row = CShort(num2)
				End Select
			Catch ex As Exception
			End Try
		End Sub

		Public Sub XLWorkSheetAddInteger(ByRef Row As Short, ByRef Col As Short, iNum As Short)
			' The following expression was wrapped in a checked-statement
			Try
				Dim num As Integer = CInt(Row)
				Dim num2 As Integer = CInt(Col)
				Me.XLWorkSheetAddString(num, num2, iNum.ToString())
				Col = CShort(num2)
				Row = CShort(num)
			Catch ex As Exception
			End Try
		End Sub

		Public Sub XLWorkSheetAddPercent(ByRef Row As Short, ByRef Col As Short, Num As Single, Optional iDec As Integer = 0)
			' The following expression was wrapped in a checked-statement
			Try
				Dim text2 As String
				If iDec = 0 Then
					Dim text As String = "#####%"
					text2 = Util.Format(Num, text)
				Else
					Dim text As String = "#####.#%"
					text2 = Util.Format(Num, text)
					Try
						NewLateBinding.LateSetComplex(NewLateBinding.LateGet(Me.oSheet, Nothing, "Cells", New Object() { CInt((Row + 1S)), CInt((Col + 1S)) }, Nothing, Nothing, Nothing), Nothing, "NumberFormat", New Object() { "0.0%" }, Nothing, Nothing, False, True)
					Catch ex As Exception
					End Try
				End If
				If Operators.CompareString(text2, "%", False) = 0 Then
					text2 = "0%"
				End If
				Dim num As Integer = CInt(Row)
				Dim num2 As Integer = CInt(Col)
				Me.XLWorkSheetAddString(num, num2, text2)
				Col = CShort(num2)
				Row = CShort(num)
			Catch ex2 As Exception
			End Try
		End Sub

		Private Sub NAR(o As Object)
			Try
				Marshal.ReleaseComObject(RuntimeHelpers.GetObjectValue(o))
			Catch ex As Exception
			Finally
				o = Nothing
			End Try
		End Sub

		Public oXLApp As Object

		Public oWBs As Object

		Public oWB As Object

		Public oSheet As Object

		Public oRng As Object
	End Class
End Namespace
