Imports System
Imports System.Reflection
Imports System.Resources
Imports System.Windows.Forms

Namespace RSWINV3
	Public Class csVersion
		Public Sub New()
			Me.Lang = New ResourceManager("RODSTAR.XDStrings", GetType(RODSTAR).Assembly)
		End Sub

		Public Sub GetVersionInfo()
			Dim major As Integer = Assembly.GetExecutingAssembly().GetName().Version.Major
			Dim minor As Integer = Assembly.GetExecutingAssembly().GetName().Version.Minor
			Dim build As Integer = Assembly.GetExecutingAssembly().GetName().Version.Build
			Dim revision As Integer = Assembly.GetExecutingAssembly().GetName().Version.Revision
			Me.m_sProductVersion = major.ToString() + "." + minor.ToString()
			Me.m_sProductFullVersion = Me.m_sProductVersion + "." + build.ToString()
			Me.m_sCompanyName = Application.CompanyName
			Me.m_sProductName = Application.ProductName
			If Not RSWIN_DESC.bRodStarD Then
				Me.m_sProductName = Me.m_sProductName.Replace("-D", "-V")
				Return
			End If
		End Sub

		Public ReadOnly Property CompanyName As String
			Get
				Return Me.m_sCompanyName
			End Get
		End Property

		Public ReadOnly Property ProductName As String
			Get
				Return Me.m_sProductName
			End Get
		End Property

		Public ReadOnly Property PathEXE As String
			Get
				Return Application.ExecutablePath
			End Get
		End Property

		Public ReadOnly Property ProductVersion As String
			Get
				Return Me.m_sProductVersion
			End Get
		End Property

		Public ReadOnly Property ProductFullVersion As String
			Get
				Return Me.m_sProductFullVersion
			End Get
		End Property

		Public ReadOnly Property TradeMark As String
			Get
				Return Me.m_sTradeMark
			End Get
		End Property

		Public ReadOnly Property CopyRight As String
			Get
				Return Me.Lang.GetString("COPYRIGHT")
			End Get
		End Property

		Public ReadOnly Property Warning As String
			Get
				Return Me.Lang.GetString("COPYRIGHT_WARNING")
			End Get
		End Property

		Private m_sCompanyName As String

		Private m_sProductName As String

		Private m_sProductVersion As String

		Private m_sProductFullVersion As String

		Private m_sTradeMark As String

		Private Lang As ResourceManager
	End Class
End Namespace
