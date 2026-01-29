Imports System
Imports System.ComponentModel
Imports System.Runtime.CompilerServices
Imports DataDynamics.ActiveReports
Imports DDCssLib

Namespace RSWINV3
	Public Class rptAll
		Inherits ActiveReport

		Public Sub New()
			AddHandler MyBase.ReportStart, AddressOf Me.myReportStart
			AddHandler MyBase.ReportEnd, AddressOf Me.myReportEnd
			Me.PageHeader = Nothing
			Me.Detail = Nothing
			Me.PageFooter = Nothing
			Me.InitializeComponent()
		End Sub

		Private Overridable Property PageHeader As PageHeader
			Get
				Return Me._PageHeader
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PageHeader)
				Me._PageHeader = value
			End Set
		End Property

		Private Overridable Property Detail As Detail
			Get
				Return Me._Detail
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Detail)
				Dim value2 As EventHandler = AddressOf Me.Detail_Format
				If Me._Detail IsNot Nothing Then
					RemoveHandler Me._Detail.Format, value2
				End If
				Me._Detail = value
				If Me._Detail IsNot Nothing Then
					AddHandler Me._Detail.Format, value2
				End If
			End Set
		End Property

		Private Overridable Property PageFooter As PageFooter
			Get
				Return Me._PageFooter
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PageFooter)
				Me._PageFooter = value
			End Set
		End Property

		Private Sub InitializeComponent()
			Dim componentResourceManager As ComponentResourceManager = New ComponentResourceManager(GetType(rptAll))
			Me.Detail = New Detail()
			Me.PageHeader = New PageHeader()
			Me.PageFooter = New PageFooter()
			CType(Me, ISupportInitialize).BeginInit()
			Me.Detail.ColumnSpacing = 0F
			Me.Detail.Height = 0.1666667F
			Me.Detail.Name = "Detail"
			Me.PageHeader.Height = 0.04166667F
			Me.PageHeader.Name = "PageHeader"
			Me.PageFooter.Height = 0.01041667F
			Me.PageFooter.Name = "PageFooter"
			Me.MasterReport = False
			Me.PageSettings.Margins.Bottom = 0F
			Me.PageSettings.Margins.Left = 0F
			Me.PageSettings.Margins.Right = 0F
			Me.PageSettings.Margins.Top = 0F
			Me.PageSettings.PaperHeight = 11F
			Me.PageSettings.PaperWidth = 8.5F
			Me.PrintWidth = 7.75F
			Me.Sections.Add(Me.PageHeader)
			Me.Sections.Add(Me.Detail)
			Me.Sections.Add(Me.PageFooter)
			Me.StyleSheet.Add(New StyleSheetRule(componentResourceManager.GetString("$this.StyleSheet"), "Normal"))
			Me.StyleSheet.Add(New StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bold; font-size: 16pt; font-size-adjust: inherit; font-stretch: inherit", "Heading1", "Normal"))
			Me.StyleSheet.Add(New StyleSheetRule("font-family: Times New Roman; font-style: italic; font-variant: inherit; font-weight: bold; font-size: 14pt; font-size-adjust: inherit; font-stretch: inherit", "Heading2", "Normal"))
			Me.StyleSheet.Add(New StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bold; font-size: 13pt; font-size-adjust: inherit; font-stretch: inherit", "Heading3", "Normal"))
			CType(Me, ISupportInitialize).EndInit()
		End Sub

		Public Sub myReportStart(sender As Object, e As EventArgs)
		End Sub

		Public Sub myReportEnd(sender As Object, e As EventArgs)
		End Sub

		Private Sub Detail_Format(sender As Object, e As EventArgs)
		End Sub

		<AccessedThroughProperty("PageHeader")>
		Private _PageHeader As PageHeader

		<AccessedThroughProperty("Detail")>
		Private _Detail As Detail

		<AccessedThroughProperty("PageFooter")>
		Private _PageFooter As PageFooter
	End Class
End Namespace
