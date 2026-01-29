Imports System

Namespace RSWINV3
	Public Class cRodType
		Public Property RodTypeID As Integer
			Get
				Return Me.m_RodTypeID
			End Get
			Set(value As Integer)
				Me.m_RodTypeID = value
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
			Me.m_RodTypeID = ID
			Me.m_DisplayName = sName
		End Sub

		Private m_RodTypeID As Integer

		Private m_DisplayName As String
	End Class
End Namespace
