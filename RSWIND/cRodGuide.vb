Imports System

Namespace RSWINV3
	Public Class cRodGuide
		Public Property RodGuideID As Integer
			Get
				Return Me.m_RodGuideID
			End Get
			Set(value As Integer)
				Me.m_RodGuideID = value
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

		Public Property DisplayOrder As Integer
			Get
				Return Me.m_DisplayOrder
			End Get
			Set(value As Integer)
				Me.m_DisplayOrder = value
			End Set
		End Property

		Public Property AbbrName As String
			Get
				Return Me.m_AbbrName
			End Get
			Set(value As String)
				Me.m_AbbrName = value
			End Set
		End Property

		Public Property XMLstring As String
			Get
				Return Me.m_XMLstring
			End Get
			Set(value As String)
				Me.m_XMLstring = value
			End Set
		End Property

		Public Sub New(ID As Integer, sName As String, DOrder As Integer, sAbbrName As String, sXMLstring As String)
			Me.m_RodGuideID = ID
			Me.m_DisplayName = sName
			Me.m_DisplayOrder = DOrder
			Me.m_AbbrName = sAbbrName
			Me.m_XMLstring = sXMLstring
		End Sub

		Private m_RodGuideID As Integer

		Private m_DisplayName As String

		Private m_DisplayOrder As Integer

		Private m_AbbrName As String

		Private m_XMLstring As String
	End Class
End Namespace
