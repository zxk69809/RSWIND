Imports System
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	Friend NotInheritable Module VERSION1
		Public Function ProgramFullVersion() As String
			Dim text As String = Strings.Replace("{1}.{2} Build {3}", "{1}", Convert.ToString(Application.ProductVersion), 1, -1, CompareMethod.Binary)
			Dim text2 As String = text
			If Not RSWIN_DESC.bRodStarD Then
				text2 = text2.Replace("-D", "-V")
			End If
			Return text2
		End Function

		Public Function ProgramInternalName() As String
			Dim result As String
			Return result
		End Function

		Public Function ProgramName() As String
			Dim result As String = Application.ProductName
			If RSWIN_DESC.bExpert Then
				If RSWIN_DESC.bXRODAdmin Then
					result = "XROD-V-Admin"
				Else
					result = "XROD-V for Windows"
				End If
			ElseIf RSWIN_DESC.bRodStarD Then
				result = "RODSTAR-D"
			Else
				result = "RODSTAR-V"
			End If
			Return result
		End Function

		Public Function ProgramTitle() As String
			' The following expression was wrapped in a checked-statement
			If Strings.Len(VERSION1.$STATIC$ProgramTitle$00E$sTitle) = 0 Then
				VERSION1.$STATIC$ProgramTitle$00E$sTitle = Application.ProductName
				Dim num As Short = CShort(Strings.InStr(VERSION1.$STATIC$ProgramTitle$00E$sTitle, " ", CompareMethod.Binary))
				If num > 0S Then
					VERSION1.$STATIC$ProgramTitle$00E$sTitle = Strings.Left(VERSION1.$STATIC$ProgramTitle$00E$sTitle, CInt((num - 1S)))
				End If
			End If
			Dim text As String = VERSION1.$STATIC$ProgramTitle$00E$sTitle
			If Not RSWIN_DESC.bRodStarD Then
				text = text.Replace("-D", "-V")
			End If
			Return text
		End Function

		Private $STATIC$ProgramTitle$00E$sTitle As String
	End Module
End Namespace
