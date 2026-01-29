Imports System

Namespace RSWINV3
	Public Class cMenu
		Public Property MenuDisplayName As String
			Get
				Return Me.m_MenuDisplayName
			End Get
			Set(value As String)
				Me.m_MenuDisplayName = value
			End Set
		End Property

		Public Property ControlName As String
			Get
				Return Me.m_ControlName
			End Get
			Set(value As String)
				Me.m_ControlName = value
			End Set
		End Property

		Public Property TabName As String
			Get
				Return Me.m_TabName
			End Get
			Set(value As String)
				Me.m_TabName = value
			End Set
		End Property

		Public Sub New(sDisplayName As String, sControlName As String, Optional sTabName As String = "")
			Me.m_ControlName = sControlName
			Me.m_MenuDisplayName = sDisplayName
			Me.m_TabName = sTabName
		End Sub

		Private m_MenuDisplayName As String

		Private m_ControlName As String

		Private m_TabName As String
	End Class
End Namespace
