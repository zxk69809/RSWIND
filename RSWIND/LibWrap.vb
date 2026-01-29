Imports System
Imports System.Runtime.InteropServices
Imports System.Text

Namespace RSWINV3
	Public Class LibWrap
		Public Declare Auto Sub GetSystemDirectory Lib "Kernel32.dll" (sysDirBuffer As StringBuilder, buffSize As Integer)

		Public Declare Auto Function GetCommandLine Lib "Kernel32.dll" () As Integer

		Public Declare Ansi Function GetPrivateProfileInt Lib "kernel32" Alias "GetPrivateProfileIntA" (<MarshalAs(UnmanagedType.VBByRefStr)> ByRef SectionName As String, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef KeyName As String, [Default] As Integer, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef FileName As String) As Integer

		Public Declare Ansi Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" (<MarshalAs(UnmanagedType.VBByRefStr)> ByRef SectionName As String, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef KeyName As String, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef [Default] As String, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef ReturnedString As String, StringSize As Integer, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef FileName As String) As Integer

		Public Declare Ansi Function WritePrivateProfileString Lib "kernel32" Alias "WritePrivateProfileStringA" (<MarshalAs(UnmanagedType.VBByRefStr)> ByRef SectionName As String, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef KeyName As String, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef KeyValue As String, <MarshalAs(UnmanagedType.VBByRefStr)> ByRef FileName As String) As Integer

		Public Declare Ansi Function GetAsyncKeyState Lib "user32" (vKey As Long) As Integer

		Public Declare Auto Sub CopyMemory_StringToShort Lib "kernel32" Alias "RtlMoveMemory" (dest As Short(), <MarshalAs(UnmanagedType.VBByRefStr)> ByRef source As String, numBytes As Integer)

		Public Declare Auto Sub CopyMemory_IntegerToSingle Lib "kernel32" Alias "RtlMoveMemory" (dest As Single, source As Integer, numBytes As Integer)

		Public Declare Auto Sub CopyMemory_SingleToInteger Lib "kernel32" Alias "RtlMoveMemory" (dest As Integer, source As Single, numBytes As Integer)

		Public Declare Auto Sub CopyMemory_SingleToSingle Lib "kernel32" Alias "RtlMoveMemory" (dest As Single, source As Single, numBytes As Integer)
	End Class
End Namespace
