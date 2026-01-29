Imports System

Namespace RSWINV3
	Public Class cRodSize
		Public Property RodSizeID As Integer
			Get
				Return Me.m_RodSizeID
			End Get
			Set(value As Integer)
				Me.m_RodSizeID = value
			End Set
		End Property

		Public Property DisplayName As String
			Get
				Return Me.m_DisplayName
			End Get
			Set(value As String)
				Me.m_DisplayName = value
			End Set
		End Property

		Public Sub New(ID As Integer, sName As String)
			Me.m_RodSizeID = ID
			Me.m_DisplayName = sName
		End Sub

		Private m_RodSizeID As Integer

		Private m_DisplayName As String
	End Class
End Namespace
