Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace RSWINV3
	Public Partial Class frmDemoMode
		Inherits Form

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.frmDemoMode_Load
			Me.InitializeComponent()
		End Sub

		Friend Overridable Property Label1 As Label
			Get
				Return Me._Label1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label1 = value
			End Set
		End Property

		Friend Overridable Property btnOK As Button
			Get
				Return Me._btnOK
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnOK_Click
				If Me._btnOK IsNot Nothing Then
					RemoveHandler Me._btnOK.Click, value2
				End If
				Me._btnOK = value
				If Me._btnOK IsNot Nothing Then
					AddHandler Me._btnOK.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property btnCancel As Button
			Get
				Return Me._btnCancel
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnCancel_Click
				If Me._btnCancel IsNot Nothing Then
					RemoveHandler Me._btnCancel.Click, value2
				End If
				Me._btnCancel = value
				If Me._btnCancel IsNot Nothing Then
					AddHandler Me._btnCancel.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property cboDemoFile As ComboBox
			Get
				Return Me._cboDemoFile
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Me._cboDemoFile = value
			End Set
		End Property

		Friend Overridable Property Label2 As Label
			Get
				Return Me._Label2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label2 = value
			End Set
		End Property

		Friend Overridable Property lblDemoText As Label
			Get
				Return Me._lblDemoText
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblDemoText = value
			End Set
		End Property

		Friend Overridable Property lblSentinelText As Label
			Get
				Return Me._lblSentinelText
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblSentinelText = value
			End Set
		End Property

		Friend Overridable Property btnRetry As Button
			Get
				Return Me._btnRetry
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnRetry_Click
				If Me._btnRetry IsNot Nothing Then
					RemoveHandler Me._btnRetry.Click, value2
				End If
				Me._btnRetry = value
				If Me._btnRetry IsNot Nothing Then
					AddHandler Me._btnRetry.Click, value2
				End If
			End Set
		End Property

		Private Sub frmDemoMode_Load(sender As Object, e As EventArgs)
			If RSWIN_DESC.bRodStarD Then
				Me.DemoFileName = New String(8) {}
				Me.DemoFileDesc = New String(8) {}
				Me.DemoFileName(1) = "demo_RSD1.rsdx"
				Me.DemoFileDesc(1) = "     Demo 1"
				Me.DemoFileName(2) = "demo_RSD2.rsdx"
				Me.DemoFileDesc(2) = "     Demo 2"
				Me.DemoFileName(3) = "demo_RSD3.rsdx"
				Me.DemoFileDesc(3) = "     Demo 3"
				Me.DemoFileName(4) = "demo_RSD4.rsdx"
				Me.DemoFileDesc(4) = "     Demo 4"
				Me.DemoFileName(5) = "demo_RSV1.rsvx"
				Me.DemoFileDesc(5) = "     Demo vertical 1"
				Me.DemoFileName(6) = "demo_RSV2.rsvx"
				Me.DemoFileDesc(6) = "     Demo vertical 2"
				Me.DemoFileName(7) = "demo_RSV3.rsvx"
				Me.DemoFileDesc(7) = "     Demo vertical 3"
				Me.DemoFileName(8) = "demo_RSV4.rsvx"
				Me.DemoFileDesc(8) = "     Demo vertical 4"
			Else
				Me.DemoFileName = New String(4) {}
				Me.DemoFileDesc = New String(4) {}
				Me.DemoFileName(1) = "demo_RSV1.rsvx"
				Me.DemoFileDesc(1) = "     Demo vertical 1"
				Me.DemoFileName(2) = "demo_RSV2.rsvx"
				Me.DemoFileDesc(2) = "     Demo vertical 2"
				Me.DemoFileName(3) = "demo_RSV3.rsvx"
				Me.DemoFileDesc(3) = "     Demo vertical 3"
				Me.DemoFileName(4) = "demo_RSV4.rsvx"
				Me.DemoFileDesc(4) = "     Demo vertical 4"
			End If
			Dim text As String
			If RSWIN_DESC.gbTrialLicenseExpired Then
				Me.Label2.Text = "Trial License Expired"
				text = "Your Trial License has expired for this product."
				text += vbCrLf & "Check to see if either a Stand-along Sentinel is attached to your computer or check with your Network Administrator regarding a Network Sentinel."
				text += vbCrLf & vbCrLf & "If no Sentinel is available, contact Theta Oilfield Services, Inc. for purchase of a License at http://www.GoTheta.com"
				Me.lblSentinelText.Text = text
			Else
				Me.Label2.Text = "Sentinel Not Found"
				text = "No Sentinel was found for this product license."
				text += vbCrLf & "Check to see if either a Stand-along Sentinel is attached to your computer or check with your Network Administrator regarding a Network Sentinel."
				text += vbCrLf & vbCrLf & "If no Sentinel is available, contact Theta Oilfield Services, Inc. for purchase of a License at http://www.GoTheta.com"
				Me.lblSentinelText.Text = text
			End If
			text = "You may run in Demo Mode if you like."
			text += vbCrLf & "Demo Mode is fully functional, but only outputs results for the example case selected."
			text += vbCrLf & "Select an example Case below and Click OK."
			Me.lblDemoText.Text = text
			Me.cboDemoFile.Items.Add("-- Select an Example Case --")
			Dim num As Integer = 1
			Dim num2 As Integer = Me.DemoFileName.Length - 1
			For i As Integer = num To num2
				Me.cboDemoFile.Items.Add(Me.DemoFileDesc(i))
			Next
			Me.cboDemoFile.SelectedIndex = 0
		End Sub

		Private Sub btnCancel_Click(sender As Object, e As EventArgs)
			RSWIN_DESC.gbDemoMode = False
			RSWIN_DESC.gsDemoFile = ""
			RSWIN_DESC.gbRetry = False
			Me.Close()
		End Sub

		Private Sub btnOK_Click(sender As Object, e As EventArgs)
			Dim selectedIndex As Integer = Me.cboDemoFile.SelectedIndex
			If selectedIndex < 1 Then
				MessageBox.Show("Select an Example Case to use for Demo Mode.", "No Case Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
				Me.cboDemoFile.Focus()
				Return
			End If
			RSWIN_DESC.gsDemoFile = Me.DemoFileName(selectedIndex)
			Dim text As String = Application.StartupPath + "\" + RSWIN_DESC.gsDemoFile
			If Not FILEUTIL.FileExists(text) Then
				RSWIN_DESC.gsDemoFile = ""
				MessageBox.Show("File not found. Select another.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				Me.cboDemoFile.Focus()
				Return
			End If
			RSWIN_DESC.gbDemoMode = True
			RSWIN_DESC.gbRetry = False
			Me.Close()
		End Sub

		Private Sub btnRetry_Click(sender As Object, e As EventArgs)
			RSWIN_DESC.gbRetry = True
			RSWIN_DESC.gbDemoMode = False
			Me.Close()
		End Sub

		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		<AccessedThroughProperty("btnOK")>
		Private _btnOK As Button

		<AccessedThroughProperty("btnCancel")>
		Private _btnCancel As Button

		<AccessedThroughProperty("cboDemoFile")>
		Private _cboDemoFile As ComboBox

		<AccessedThroughProperty("Label2")>
		Private _Label2 As Label

		<AccessedThroughProperty("lblDemoText")>
		Private _lblDemoText As Label

		<AccessedThroughProperty("lblSentinelText")>
		Private _lblSentinelText As Label

		<AccessedThroughProperty("btnRetry")>
		Private _btnRetry As Button

		Private DemoFileName As String()

		Private DemoFileDesc As String()
	End Class
End Namespace
