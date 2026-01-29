Imports System

Namespace RSWINV3
	Public Class cRecPU
		Public Property TargetProduction As Integer
			Get
				Return Me.m_TargetProduction
			End Get
			Set(value As Integer)
				Me.m_TargetProduction = value
			End Set
		End Property

		Public Property GearBox As Integer
			Get
				Return Me.m_GearBox
			End Get
			Set(value As Integer)
				Me.m_GearBox = value
			End Set
		End Property

		Public Property StructRating As Integer
			Get
				Return Me.m_StructRating
			End Get
			Set(value As Integer)
				Me.m_StructRating = value
			End Set
		End Property

		Public Property StrokeLength As Integer
			Get
				Return Me.m_StrokeLength
			End Get
			Set(value As Integer)
				Me.m_StrokeLength = value
			End Set
		End Property

		Public Sub New(iTP As Integer, iGB As Integer, iSR As Integer, iSL As Integer)
			Try
				Me.m_TargetProduction = iTP
				Me.m_GearBox = iGB
				Me.m_StructRating = iSR
				Me.m_StrokeLength = iSL
			Catch ex As Exception
			End Try
		End Sub

		Private m_TargetProduction As Integer

		Private m_GearBox As Integer

		Private m_StructRating As Integer

		Private m_StrokeLength As Integer
	End Class
End Namespace
