Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document
Imports DDCssLib
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	Public Class rptDynoAndTorqueChart_Landscape
		Inherits ActiveReport

		Public Sub New()
			AddHandler MyBase.ReportStart, AddressOf Me.myReportStart
			Me.ReportHeader = Nothing
			Me.GroupHeader1 = Nothing
			Me.Detail = Nothing
			Me.GroupFooter1 = Nothing
			Me.ReportFooter = Nothing
			Me.lblTitle1 = Nothing
			Me.lblUserDate = Nothing
			Me.lblCompany = Nothing
			Me.lblWellName = Nothing
			Me.txtPage2 = Nothing
			Me.lblOf = Nothing
			Me.txtPage1 = Nothing
			Me.lblPage = Nothing
			Me.lblLabel2 = Nothing
			Me.lblGoTheta = Nothing
			Me.picDyno = Nothing
			Me.picTorquePlot = Nothing
			Me.sCompany = Util.AssignValueToConstant("rptCalcResults", "sCompany", "Company: ")
			Me.sWell = Util.AssignValueToConstant("rptCalcResults", "sWell", "Well: ")
			Me.sUser = Util.AssignValueToConstant("rptCalcResults", "sUser", "User: ")
			Me.sDiskFile = Util.AssignValueToConstant("rptCalcResults", "sDiskFile", "Disk file: ")
			Me.sDate = Util.AssignValueToConstant("rptCalcResults", "sDate", "Date: ")
			Me.sPage = Util.AssignValueToConstant("rptCalcResults", "sPage", "Page")
			Me.sOf = Util.AssignValueToConstant("rptCalcResults", "sOf", "of")
			Me.sComment = Util.AssignValueToConstant("rptCalcResults", "sComment", "Comment: ")
			Me.sThetaEnterprises = Util.AssignValueToConstant("rptCalcResults", "sThetaEnterprises", "(c) Theta Oilfield Services, Inc.")
			Me.sLicenseTo = Util.AssignValueToConstant("rptCalcResults", "sLicenseTo", " - Licensed to ")
			Me.slbl = "lbl"
			Me.InitializeComponent()
		End Sub

		Private Overridable Property ReportHeader As ReportHeader
			Get
				Return Me._ReportHeader
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ReportHeader)
				Me._ReportHeader = value
			End Set
		End Property

		Private Overridable Property GroupHeader1 As GroupHeader
			Get
				Return Me._GroupHeader1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupHeader)
				Me._GroupHeader1 = value
			End Set
		End Property

		Private Overridable Property Detail As Detail
			Get
				Return Me._Detail
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Detail)
				Me._Detail = value
			End Set
		End Property

		Private Overridable Property GroupFooter1 As GroupFooter
			Get
				Return Me._GroupFooter1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupFooter)
				Me._GroupFooter1 = value
			End Set
		End Property

		Private Overridable Property ReportFooter As ReportFooter
			Get
				Return Me._ReportFooter
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ReportFooter)
				Me._ReportFooter = value
			End Set
		End Property

		Private Sub InitializeComponent()
			Dim componentResourceManager As ComponentResourceManager = New ComponentResourceManager(GetType(rptDynoAndTorqueChart_Landscape))
			Me.Detail = New Detail()
			Me.ReportHeader = New ReportHeader()
			Me.ReportFooter = New ReportFooter()
			Me.GroupHeader1 = New GroupHeader()
			Me.GroupFooter1 = New GroupFooter()
			Me.lblTitle1 = New Label()
			Me.lblUserDate = New Label()
			Me.lblCompany = New Label()
			Me.lblWellName = New Label()
			Me.txtPage2 = New TextBox()
			Me.lblOf = New Label()
			Me.txtPage1 = New TextBox()
			Me.lblPage = New Label()
			Me.lblLabel2 = New Label()
			Me.lblGoTheta = New Label()
			Me.picDyno = New Picture()
			Me.picTorquePlot = New Picture()
			CType(Me.lblTitle1, ISupportInitialize).BeginInit()
			CType(Me.lblUserDate, ISupportInitialize).BeginInit()
			CType(Me.lblCompany, ISupportInitialize).BeginInit()
			CType(Me.lblWellName, ISupportInitialize).BeginInit()
			CType(Me.txtPage2, ISupportInitialize).BeginInit()
			CType(Me.lblOf, ISupportInitialize).BeginInit()
			CType(Me.txtPage1, ISupportInitialize).BeginInit()
			CType(Me.lblPage, ISupportInitialize).BeginInit()
			CType(Me.lblLabel2, ISupportInitialize).BeginInit()
			CType(Me.lblGoTheta, ISupportInitialize).BeginInit()
			CType(Me.picDyno, ISupportInitialize).BeginInit()
			CType(Me.picTorquePlot, ISupportInitialize).BeginInit()
			CType(Me, ISupportInitialize).BeginInit()
			Me.Detail.ColumnSpacing = 0F
			Me.Detail.Height = 0F
			Me.Detail.Name = "Detail"
			Me.ReportHeader.Controls.AddRange(New ARControl() { Me.lblTitle1, Me.lblUserDate, Me.lblCompany, Me.lblWellName, Me.txtPage2, Me.lblOf, Me.txtPage1, Me.lblPage, Me.lblLabel2, Me.lblGoTheta })
			Me.ReportHeader.Height = 0.3958333F
			Me.ReportHeader.Name = "ReportHeader"
			Me.ReportFooter.Height = 0.02083333F
			Me.ReportFooter.Name = "ReportFooter"
			Me.GroupHeader1.Controls.AddRange(New ARControl() { Me.picDyno, Me.picTorquePlot })
			Me.GroupHeader1.Height = 5.25F
			Me.GroupHeader1.Name = "GroupHeader1"
			Me.GroupFooter1.Height = 0.02083333F
			Me.GroupFooter1.Name = "GroupFooter1"
			Me.lblTitle1.Height = 0.17F
			Me.lblTitle1.HyperLink = Nothing
			Me.lblTitle1.Left = 3.072917F
			Me.lblTitle1.Name = "lblTitle1"
			Me.lblTitle1.Style = "text-align: center; font-weight: bold; font-size: 9pt; font-family: Microsoft Sans Serif"
			Me.lblTitle1.Text = "RODSTAR-D 1.0"
			Me.lblTitle1.Top = 0F
			Me.lblTitle1.Width = 4.9375F
			Me.lblUserDate.Height = 0.17F
			Me.lblUserDate.HyperLink = Nothing
			Me.lblUserDate.Left = 9.0625F
			Me.lblUserDate.Name = "lblUserDate"
			Me.lblUserDate.Style = "font-size: 8.25pt; font-family: Microsoft Sans Serif"
			Me.lblUserDate.Text = "Date: "
			Me.lblUserDate.Top = 0.1875F
			Me.lblUserDate.Width = 1.875F
			Me.lblCompany.Height = 0.17F
			Me.lblCompany.HyperLink = Nothing
			Me.lblCompany.Left = 0.125F
			Me.lblCompany.Name = "lblCompany"
			Me.lblCompany.Style = "font-size: 8.25pt; font-family: Microsoft Sans Serif"
			Me.lblCompany.Text = "Company: "
			Me.lblCompany.Top = 0F
			Me.lblCompany.Width = 2.9375F
			Me.lblWellName.Height = 0.17F
			Me.lblWellName.HyperLink = Nothing
			Me.lblWellName.Left = 0.125F
			Me.lblWellName.Name = "lblWellName"
			Me.lblWellName.Style = "font-size: 8.25pt; font-family: Microsoft Sans Serif"
			Me.lblWellName.Text = "Well: "
			Me.lblWellName.Top = 0.1875F
			Me.lblWellName.Width = 3.9375F
			Me.txtPage2.Height = 0.17F
			Me.txtPage2.Left = 9.875F
			Me.txtPage2.Name = "txtPage2"
			Me.txtPage2.Style = "font-size: 8.25pt; font-family: Microsoft Sans Serif"
			Me.txtPage2.Top = 0F
			Me.txtPage2.Width = 0.1875F
			Me.lblOf.Height = 0.17F
			Me.lblOf.HyperLink = Nothing
			Me.lblOf.Left = 9.6875F
			Me.lblOf.Name = "lblOf"
			Me.lblOf.Style = "font-size: 8.25pt; font-family: Microsoft Sans Serif"
			Me.lblOf.Text = "of"
			Me.lblOf.Top = 0F
			Me.lblOf.Width = 0.1875F
			Me.txtPage1.Height = 0.17F
			Me.txtPage1.Left = 9.5F
			Me.txtPage1.Name = "txtPage1"
			Me.txtPage1.Style = "font-size: 8.25pt; font-family: Microsoft Sans Serif"
			Me.txtPage1.Top = 0F
			Me.txtPage1.Width = 0.1875F
			Me.lblPage.Height = 0.17F
			Me.lblPage.HyperLink = Nothing
			Me.lblPage.Left = 9.0625F
			Me.lblPage.Name = "lblPage"
			Me.lblPage.Style = "font-size: 8.25pt; font-family: Microsoft Sans Serif"
			Me.lblPage.Text = "Page"
			Me.lblPage.Top = 0F
			Me.lblPage.Width = 0.4375F
			Me.lblLabel2.Height = 0.17F
			Me.lblLabel2.HyperLink = Nothing
			Me.lblLabel2.Left = 4.0625F
			Me.lblLabel2.Name = "lblLabel2"
			Me.lblLabel2.Style = "text-align: center; font-size: 8.25pt; font-family: Microsoft Sans Serif"
			Me.lblLabel2.Text = "© Theta Oilfield Services, Inc."
			Me.lblLabel2.Top = 0.1875F
			Me.lblLabel2.Width = 2F
			Me.lblGoTheta.Height = 0.17F
			Me.lblGoTheta.HyperLink = Nothing
			Me.lblGoTheta.Left = 5.875F
			Me.lblGoTheta.Name = "lblGoTheta"
			Me.lblGoTheta.Style = "text-align: center; font-size: 8.25pt; font-family: Microsoft Sans Serif"
			Me.lblGoTheta.Text = "(www.gotheta.com)"
			Me.lblGoTheta.Top = 0.1875F
			Me.lblGoTheta.Width = 1.0625F
			Me.picDyno.BackColor = Color.FromArgb(255, 255, 255)
			Me.picDyno.Height = 5F
			Me.picDyno.ImageData = Nothing
			Me.picDyno.Left = 0.1325F
			Me.picDyno.LineColor = Color.FromArgb(255, 255, 255)
			Me.picDyno.LineWeight = 0F
			Me.picDyno.Name = "picDyno"
			Me.picDyno.SizeMode = SizeModes.Stretch
			Me.picDyno.Top = 0.125F
			Me.picDyno.Width = 5.3675F
			Me.picTorquePlot.BackColor = Color.FromArgb(255, 255, 255)
			Me.picTorquePlot.Height = 5F
			Me.picTorquePlot.ImageData = Nothing
			Me.picTorquePlot.Left = 5.572499F
			Me.picTorquePlot.LineColor = Color.FromArgb(255, 255, 255)
			Me.picTorquePlot.LineWeight = 0F
			Me.picTorquePlot.Name = "picTorquePlot"
			Me.picTorquePlot.SizeMode = SizeModes.Stretch
			Me.picTorquePlot.Top = 0.125F
			Me.picTorquePlot.Width = 5.3625F
			Me.MasterReport = False
			Me.PageSettings.Margins.Bottom = 0F
			Me.PageSettings.Margins.Left = 0F
			Me.PageSettings.Margins.Right = 0F
			Me.PageSettings.Margins.Top = 0.2F
			Me.PageSettings.Orientation = PageOrientation.Landscape
			Me.PageSettings.PaperHeight = 11F
			Me.PageSettings.PaperWidth = 8.5F
			Me.PrintWidth = 10.98958F
			Me.Sections.Add(Me.ReportHeader)
			Me.Sections.Add(Me.GroupHeader1)
			Me.Sections.Add(Me.Detail)
			Me.Sections.Add(Me.GroupFooter1)
			Me.Sections.Add(Me.ReportFooter)
			Me.StyleSheet.Add(New StyleSheetRule(componentResourceManager.GetString("$this.StyleSheet"), "Normal"))
			Me.StyleSheet.Add(New StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bold; font-size: 16pt; font-size-adjust: inherit; font-stretch: inherit", "Heading1", "Normal"))
			Me.StyleSheet.Add(New StyleSheetRule("font-family: Times New Roman; font-style: italic; font-variant: inherit; font-weight: bold; font-size: 14pt; font-size-adjust: inherit; font-stretch: inherit", "Heading2", "Normal"))
			Me.StyleSheet.Add(New StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bold; font-size: 13pt; font-size-adjust: inherit; font-stretch: inherit", "Heading3", "Normal"))
			CType(Me.lblTitle1, ISupportInitialize).EndInit()
			CType(Me.lblUserDate, ISupportInitialize).EndInit()
			CType(Me.lblCompany, ISupportInitialize).EndInit()
			CType(Me.lblWellName, ISupportInitialize).EndInit()
			CType(Me.txtPage2, ISupportInitialize).EndInit()
			CType(Me.lblOf, ISupportInitialize).EndInit()
			CType(Me.txtPage1, ISupportInitialize).EndInit()
			CType(Me.lblPage, ISupportInitialize).EndInit()
			CType(Me.lblLabel2, ISupportInitialize).EndInit()
			CType(Me.lblGoTheta, ISupportInitialize).EndInit()
			CType(Me.picDyno, ISupportInitialize).EndInit()
			CType(Me.picTorquePlot, ISupportInitialize).EndInit()
			CType(Me, ISupportInitialize).EndInit()
		End Sub

		Public Property bPrint As Boolean
			Get
				Return Me.m_bPrint
			End Get
			Set(value As Boolean)
				Me.m_bPrint = value
				Me.PageSettings.Orientation = PageOrientation.Landscape
			End Set
		End Property

		Public Sub ImportDynoChart()
			Try
				Dim sTempDynoPlotLFileName As String = RSWIN_DESC.sTempDynoPlotLFileName
				Dim flag As Boolean = FILEUTIL.FileExists(sTempDynoPlotLFileName)
				RSWIN_DESC.sTempDynoPlotLFileName = sTempDynoPlotLFileName
				If flag Then
					Try
						Dim bitmap As Bitmap = New Bitmap(RSWIN_DESC.sTempDynoPlotLFileName)
						Dim bitmap2 As Bitmap = New Bitmap(bitmap)
						bitmap.Dispose()
						Me.picDyno.Image = CType(bitmap2.Clone(), Image)
						bitmap2.Dispose()
					Catch ex As Exception
					Finally
						Dim bitmap2 As Bitmap
						bitmap2.Dispose()
					End Try
					Try
						sTempDynoPlotLFileName = RSWIN_DESC.sTempDynoPlotLFileName
						Dim flag2 As Boolean = FILEUTIL.FileExists(sTempDynoPlotLFileName)
						RSWIN_DESC.sTempDynoPlotLFileName = sTempDynoPlotLFileName
						If flag2 Then
							FileSystem.Kill(RSWIN_DESC.sTempDynoPlotLFileName)
						End If
					Catch ex2 As Exception
					End Try
				End If
			Catch ex3 As Exception
			End Try
		End Sub

		Public Sub ImportTorquePlotChart()
			Try
				Dim sTempTorquePlotLFileName As String = RSWIN_DESC.sTempTorquePlotLFileName
				Dim flag As Boolean = FILEUTIL.FileExists(sTempTorquePlotLFileName)
				RSWIN_DESC.sTempTorquePlotLFileName = sTempTorquePlotLFileName
				If flag Then
					Try
						Dim bitmap As Bitmap = New Bitmap(RSWIN_DESC.sTempTorquePlotLFileName)
						Dim bitmap2 As Bitmap = New Bitmap(bitmap)
						bitmap.Dispose()
						Me.picTorquePlot.Image = CType(bitmap2.Clone(), Image)
						bitmap2.Dispose()
					Catch ex As Exception
					Finally
						Dim bitmap2 As Bitmap
						bitmap2.Dispose()
					End Try
					Try
						sTempTorquePlotLFileName = RSWIN_DESC.sTempTorquePlotLFileName
						Dim flag2 As Boolean = FILEUTIL.FileExists(sTempTorquePlotLFileName)
						RSWIN_DESC.sTempTorquePlotLFileName = sTempTorquePlotLFileName
						If flag2 Then
							FileSystem.Kill(RSWIN_DESC.sTempTorquePlotLFileName)
						End If
					Catch ex2 As Exception
					End Try
				End If
			Catch ex3 As Exception
			End Try
		End Sub

		Public Property TotalPageNumber As Integer
			Get
				Return Me.m_TotalPageNumber
			End Get
			Set(value As Integer)
				Me.m_TotalPageNumber = value
			End Set
		End Property

		Public Property ThisPageNumber As Integer
			Get
				Return Me.m_ThisPageNumber
			End Get
			Set(value As Integer)
				Me.m_ThisPageNumber = value
			End Set
		End Property

		Public Sub myReportStart(sender As Object, e As EventArgs)
			Try
				Me.SummHeader(Me.m_ThisPageNumber, Me.m_TotalPageNumber)
				If RSWIN_DESC.rst.PU.UnitType = 10S Then
					Me.picTorquePlot.Visible = False
				Else
					Me.picTorquePlot.Visible = True
				End If
				Try
					If RSWIN_DESC.bIntVersion Then
						If RSWIN_DESC.bWriteResXFile Then
							Util.OpenResourceWriter("rptDynoAndTorqueChart_Landscape")
							Me.WriteControlStrings()
							Util.CloseResourceWriter()
						End If
						If RSWIN_DESC.bReadResXFile Then
							Me.ReadReportControlStrings()
						End If
					End If
				Catch ex As Exception
				End Try
			Catch ex2 As Exception
			End Try
		End Sub

		Private Sub SummHeader(iPage As Integer, nPages As Integer)
			Dim text As String = New String(" "c, 112)
			Try
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				Dim text2 As String = RSWIN_DESC.sProgramLongName
				Dim text3 As String = ""
				If Strings.Len(text3) > 0 Then
					text2 = text2 + " (SN#" + text3 + ")"
				End If
				If Strings.Len(Util.Licensee()) > 0 Then
					text2 = text2 + Me.sLicenseTo + Util.Licensee()
				End If
				Me.lblTitle1.Text = text2
				Me.lblLabel2.Text = Me.sThetaEnterprises
				Me.lblPage.Text = Me.sPage
				Me.lblOf.Text = Me.sOf
				Me.lblCompany.Text = Me.sCompany + Strings.Trim(rst.ACompanyName)
				If iPage >= 1 Then
					Me.txtPage1.Text = iPage.ToString()
					Me.txtPage2.Text = nPages.ToString()
				End If
				Me.lblWellName.Text = Me.sWell + Strings.Trim(rst.WellName)
				Dim text4 As String = Me.sThetaEnterprises
				If rst.FileComment Is Nothing Then
					rst.FileComment = ""
				End If
				If Information.IsDate(rst.UserDate) Then
					Me.lblUserDate.Text = Me.sDate + Convert.ToDateTime(rst.UserDate).ToShortDateString()
				Else
					Me.lblUserDate.Text = Me.sDate + rst.UserDate
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub SummHeader_old(iPage As Integer, nPages As Integer)
			Dim text As String = New String(" "c, 112)
			Try
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				Dim str As String = RSWIN_DESC.sProgramLongName
				Dim text2 As String = ""
				If Strings.Len(text2) > 0 Then
					str = str + " (SN#" + text2 + ")"
				End If
				If Strings.Len(Util.Licensee()) > 0 Then
					str = str + Me.sLicenseTo + Util.Licensee()
				End If
				Dim text3 As String = Me.sThetaEnterprises
			Catch ex As Exception
			End Try
		End Sub

		Private Sub WriteControlStrings()
			' The following expression was wrapped in a checked-statement
			Try
				Dim num As Integer = 0
				Dim num2 As Integer = Me.Detail.Controls.Count - 1
				For i As Integer = num To num2
					Try
						If Me.Detail.Controls(i).[GetType]() Is GetType(Label) Then
							Dim label As Label = CType(Me.Detail.Controls(i), Label)
							If Operators.CompareString(label.Name.Substring(0, Me.slbl.Length), Me.slbl, False) = 0 Then
								Me.AddRexResource(label.Name, label.Text)
							End If
						End If
					Catch ex As Exception
						Debug.WriteLine(ex.Message)
					End Try
				Next
				Dim num3 As Integer = 1
				Dim count As Integer = Me.ReportHeader.Controls.Count
				For i As Integer = num3 To count
					Try
						If Me.ReportHeader.Controls(i).[GetType]() Is GetType(Label) Then
							Dim label As Label = CType(Me.ReportHeader.Controls(i), Label)
							If Operators.CompareString(label.Name.Substring(0, Me.slbl.Length), Me.slbl, False) = 0 Then
								Me.AddRexResource(label.Name, label.Text)
							End If
						End If
					Catch ex2 As Exception
						Debug.WriteLine(ex2.Message)
					End Try
				Next
			Catch ex3 As Exception
			End Try
		End Sub

		Private Sub AddRexResource(sKey As String, sVal As String)
			RSWIN_DESC.RwX.AddResource(sKey, sVal)
		End Sub

		Private Sub ReadReportControlStrings()
			Dim sPrefix As String = "rptDynoAndTorqueChart_Landscape-" + RSWIN_DESC.SETUP_Language.Trim() + "-"
			Try
				Dim num As Integer = 0
				Dim num2 As Integer = Me.GroupHeader1.Controls.Count - 1
				For i As Integer = num To num2
					Try
						If Me.GroupHeader1.Controls(i).[GetType]() Is GetType(Label) Then
							Dim label As Label = CType(Me.GroupHeader1.Controls(i), Label)
							Me.AssignValueToReportControl(sPrefix, label)
						End If
					Catch ex As Exception
					End Try
				Next
				Dim num3 As Integer = 0
				Dim num4 As Integer = Me.GroupFooter1.Controls.Count - 1
				For i As Integer = num3 To num4
					Try
						If Me.GroupFooter1.Controls(i).[GetType]() Is GetType(Label) Then
							Dim label As Label = CType(Me.GroupFooter1.Controls(i), Label)
							Me.AssignValueToReportControl(sPrefix, label)
						End If
					Catch ex2 As Exception
					End Try
				Next
				Dim num5 As Integer = 0
				Dim num6 As Integer = Me.Detail.Controls.Count - 1
				For i As Integer = num5 To num6
					Try
						If Me.Detail.Controls(i).[GetType]() Is GetType(Label) Then
							Dim label As Label = CType(Me.Detail.Controls(i), Label)
							Me.AssignValueToReportControl(sPrefix, label)
						End If
					Catch ex3 As Exception
					End Try
				Next
			Catch ex4 As Exception
			End Try
		End Sub

		Public Sub AssignValueToReportControl(sPrefix As String, ByRef objControl As Label)
			Try
				Dim text As String = sPrefix + objControl.Name
				text = text.ToLower()
				If RSWIN_DESC.bRunningChineseVersion Then
					text = text.Replace("-zh-hans-", "-")
					Dim [string] As String = cGlobal.Lang.GetString(text)
					If [string] IsNot Nothing Then
						If Operators.CompareString([string].Trim(), "", False) <> 0 Then
							objControl.Text = [string]
							text = sPrefix + objControl.Name + "-TAG"
							text = text.ToLower()
							[string] = cGlobal.Lang.GetString(text)
							If [string] IsNot Nothing AndAlso Operators.CompareString([string].Trim(), "", False) <> 0 Then
								objControl.Tag = [string]
							End If
						End If
					End If
				ElseIf RSWIN_DESC.myALLKeyValueHT.ContainsKey(text) Then
					objControl.Text = Conversions.ToString(RSWIN_DESC.myALLKeyValueHT(text))
					text = sPrefix + objControl.Name + "-TAG"
					text = text.ToLower()
					If RSWIN_DESC.myALLKeyValueHT.ContainsKey(text) Then
						objControl.Tag = RuntimeHelpers.GetObjectValue(RSWIN_DESC.myALLKeyValueHT(text))
					End If
				End If
			Catch ex As Exception
			End Try
		End Sub

		<AccessedThroughProperty("ReportHeader")>
		Private _ReportHeader As ReportHeader

		<AccessedThroughProperty("GroupHeader1")>
		Private _GroupHeader1 As GroupHeader

		<AccessedThroughProperty("Detail")>
		Private _Detail As Detail

		<AccessedThroughProperty("GroupFooter1")>
		Private _GroupFooter1 As GroupFooter

		<AccessedThroughProperty("ReportFooter")>
		Private _ReportFooter As ReportFooter

		Private lblTitle1 As Label

		Private lblUserDate As Label

		Private lblCompany As Label

		Private lblWellName As Label

		Private txtPage2 As TextBox

		Private lblOf As Label

		Private txtPage1 As TextBox

		Private lblPage As Label

		Private lblLabel2 As Label

		Private lblGoTheta As Label

		Private picDyno As Picture

		Private picTorquePlot As Picture

		Private sCompany As String

		Private sWell As String

		Private sUser As String

		Private sDiskFile As String

		Private sDate As String

		Private sPage As String

		Private sOf As String

		Private sComment As String

		Private sThetaEnterprises As String

		Private sLicenseTo As String

		Private slbl As String

		Private m_bPrint As Boolean

		Private m_TotalPageNumber As Integer

		Private m_ThisPageNumber As Integer
	End Class
End Namespace
