Imports System
Imports System.CodeDom.Compiler
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Globalization
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3.My.Resources
	<HideModuleName()>
	<GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")>
	<CompilerGenerated()>
	<DebuggerNonUserCode()>
	Friend NotInheritable Module Resources
		<EditorBrowsable(EditorBrowsableState.Advanced)>
		Friend ReadOnly Property ResourceManager As ResourceManager
			Get
				If Object.ReferenceEquals(Resources.resourceMan, Nothing) Then
					Dim resourceManager As ResourceManager = New ResourceManager("RSWINV3.Resources", GetType(Resources).Assembly)
					Resources.resourceMan = resourceManager
				End If
				Return Resources.resourceMan
			End Get
		End Property

		<EditorBrowsable(EditorBrowsableState.Advanced)>
		Friend Property Culture As CultureInfo
			Get
				Return Resources.resourceCulture
			End Get
			Set(value As CultureInfo)
				Resources.resourceCulture = value
			End Set
		End Property

		Private resourceMan As ResourceManager

		Private resourceCulture As CultureInfo
	End Module
End Namespace
