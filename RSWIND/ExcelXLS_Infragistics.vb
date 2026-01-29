Imports System
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Threading
Imports Infragistics.Excel
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	Public Class ExcelXLS_Infragistics
		Public Function XLWorkSheetCreate(wfn As String) As Boolean
			Dim result As Boolean
			Try
				Me.XLCreateSpreadSheet(wfn)
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
					If Strings.InStr(sFileName.ToLower(), ".xlsx", CompareMethod.Binary) > 0 Then
						Me.oWB.Save(sFileName)
					Else
						Me.oWB.Save(sFileName)
					End If
					Try
						Me.NAR(Me.oSheet)
						Me.NAR(Me.oWB)
						Thread.Sleep(1000)
					Catch ex As Exception
					End Try
				End If
			Catch ex2 As Exception
			End Try
		End Sub

		Public Sub XLMakeVisible(bVisible As Boolean)
		End Sub

		Public Sub XLUserControl(bControl As Boolean)
		End Sub

		Public Sub XLCreateSpreadSheet(wfn As String)
			Try
				Me.oWB = New Workbook()
				If Strings.InStr(wfn.ToLower(), ".xlsx", CompareMethod.Binary) > 0 Then
					Me.oWB.SetCurrentFormat(WorkbookFormat.Excel2007)
				End If
				Me.oSheet = Me.oWB.Worksheets.Add(RSWIN_DESC.EXCELBATCH)
			Catch ex As Exception
			End Try
		End Sub

		Public Sub XLWorkSheetAddString(ByRef RowIndex As Integer, ByRef ColIndex As Integer, sCellValue As String)
			Try
				' The following expression was wrapped in a checked-expression
				Me.oSheet.Rows(RowIndex + 1).Cells(ColIndex + 1).Value = sCellValue
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

		Public Sub XLWorkSheetAddFloat(ByRef Row As Integer, ByRef Col As Integer, Num As Single, nDecPlaces As Short)
			Try
				Select Case nDecPlaces
					Case -1S, 0S
						Dim text As String = "#########"
						Me.XLWorkSheetAddString(Row, Col, Util.Format(Num, text))
					Case 1S
						Dim text As String = "#########.#"
						Me.XLWorkSheetAddString(Row, Col, Util.Format(Num, text))
					Case 2S
						Dim text As String = "#########.##"
						Me.XLWorkSheetAddString(Row, Col, Util.Format(Num, text))
					Case 3S
						Dim text As String = "#########.###"
						Me.XLWorkSheetAddString(Row, Col, Util.Format(Num, text))
					Case 4S
						Dim text As String = "#########.####"
						Me.XLWorkSheetAddString(Row, Col, Util.Format(Num, text))
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
				End If
				If Operators.CompareString(text2, "%", False) = 0 Then
					text2 = "0%"
				End If
				Dim num As Integer = CInt(Row)
				Dim num2 As Integer = CInt(Col)
				Me.XLWorkSheetAddString(num, num2, text2)
				Col = CShort(num2)
				Row = CShort(num)
			Catch ex As Exception
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

		Public oWB As Workbook

		Public oSheet As Worksheet

		Public oRng As Object
	End Class
End Namespace
