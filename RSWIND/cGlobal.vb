Imports System
Imports System.Globalization
Imports System.Resources
Imports System.Threading
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	Public Class cGlobal
		Protected Friend Shared Function SetLocalizedLanguage() As String
			If Operators.CompareString(Thread.CurrentThread.CurrentUICulture.Name, "zh-Hans", False) <> 0 Then
				Return Thread.CurrentThread.CurrentUICulture.Name
			End If
			Thread.CurrentThread.CurrentUICulture = New CultureInfo("zh-Hans")
			Return "zh-Hans"
		End Function

		Public Shared Property SETUP_LocalizedLanguage As String
			Get
				Return cGlobal._LocalizedLanguage
			End Get
			Set(value As String)
				cGlobal._LocalizedLanguage = value
			End Set
		End Property

		Public Shared Property Lang As ResourceManager
			Get
				Return cGlobal._Lang
			End Get
			Set(value As ResourceManager)
				cGlobal._Lang = value
			End Set
		End Property

		Private Shared _LocalizedLanguage As String

		Private Shared _Lang As ResourceManager
	End Class
End Namespace
