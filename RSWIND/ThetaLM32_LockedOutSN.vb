Imports System
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	Friend NotInheritable Module ThetaLM32_LockedOutSN
		Public Function LockedOut(sSerialNum As String, sProduct As String) As Boolean
			Dim [string] As String = ""
			Dim result As Boolean = False
			If Strings.InStr([string], "00", CompareMethod.Binary) > 0 Then
				result = True
			ElseIf Strings.InStr([string], sProduct, CompareMethod.Binary) > 0 Then
				result = True
			End If
			Return result
		End Function
	End Module
End Namespace
