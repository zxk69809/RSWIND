Imports System
Imports System.Windows.Forms

Namespace RSWINV3
	Friend Class CWindowManager
		Public Property MainHeight As Integer
			Get
				Return Me.m_MainHeight
			End Get
			Set(value As Integer)
				Me.m_MainHeight = value
			End Set
		End Property

		Public Property MainWidth As Integer
			Get
				Return Me.m_MainWidth
			End Get
			Set(value As Integer)
				Me.m_MainWidth = value
			End Set
		End Property

		Public Sub AddMinMax(frm As Form)
		End Sub

		Public Sub RemoveMinMax(frm As Form)
		End Sub

		Public Sub ShowForm(ByRef frm As Form)
		End Sub

		Private m_MainHeight As Integer

		Private m_MainWidth As Integer
	End Class
End Namespace
