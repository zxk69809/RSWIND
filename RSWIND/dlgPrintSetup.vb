Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.Compatibility.VB6
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	Friend Partial Class dlgPrintSetup
		Inherits Form

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.dlgPrintSetup_Load
			Me.SavePrinter = ""
			Me.ps = New PrinterSettings()
			If dlgPrintSetup.m_vb6FormDefInstance Is Nothing Then
				If dlgPrintSetup.m_InitializingDefInstance Then
					dlgPrintSetup.m_vb6FormDefInstance = Me
				Else
					Try
						If Assembly.GetExecutingAssembly().EntryPoint.DeclaringType Is Me.[GetType]() Then
							dlgPrintSetup.m_vb6FormDefInstance = Me
						End If
					Catch ex As Exception
					End Try
				End If
			End If
			Me.InitializeComponent()
		End Sub

		Public Overridable Property cmdCancel As Button
			Get
				Return Me._cmdCancel
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.cmdCancel_Click
				If Me._cmdCancel IsNot Nothing Then
					RemoveHandler Me._cmdCancel.Click, value2
				End If
				Me._cmdCancel = value
				If Me._cmdCancel IsNot Nothing Then
					AddHandler Me._cmdCancel.Click, value2
				End If
			End Set
		End Property

		Public Overridable Property cmdOK As Button
			Get
				Return Me._cmdOK
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.cmdOK_Click
				If Me._cmdOK IsNot Nothing Then
					RemoveHandler Me._cmdOK.Click, value2
				End If
				Me._cmdOK = value
				If Me._cmdOK IsNot Nothing Then
					AddHandler Me._cmdOK.Click, value2
				End If
			End Set
		End Property

		Public Overridable Property lblDefault As Label
			Get
				Return Me._lblDefault
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblDefault = value
			End Set
		End Property

		Public Overridable Property _Label_0 As Label
			Get
				Return Me.__Label_0
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_0 = value
			End Set
		End Property

		Public Overridable Property Label As LabelArray
			Get
				Return Me._Label
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As LabelArray)
				Me._Label = value
			End Set
		End Property

		Friend Overridable Property lstPrinters As ListBox
			Get
				Return Me._lstPrinters
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ListBox)
				Me._lstPrinters = value
			End Set
		End Property

		Public Shared Property DefInstance As dlgPrintSetup
			Get
				If dlgPrintSetup.m_vb6FormDefInstance Is Nothing OrElse dlgPrintSetup.m_vb6FormDefInstance.IsDisposed Then
					dlgPrintSetup.m_InitializingDefInstance = True
					dlgPrintSetup.m_vb6FormDefInstance = New dlgPrintSetup()
					dlgPrintSetup.m_InitializingDefInstance = False
				End If
				Return dlgPrintSetup.m_vb6FormDefInstance
			End Get
			Set(value As dlgPrintSetup)
				dlgPrintSetup.m_vb6FormDefInstance = value
			End Set
		End Property

		Private Sub cmdCancel_Click(eventSender As Object, eventArgs As EventArgs)
			Me.Close()
		End Sub

		Private Sub cmdOK_Click(eventSender As Object, eventArgs As EventArgs)
			Me.ps.PrinterName = Conversions.ToString(Me.lstPrinters.SelectedItem)
			RSWIN_DESC.pd.PrinterSettings.PrinterName = Conversions.ToString(Me.lstPrinters.SelectedItem)
			Me.Close()
		End Sub

		Private Sub dlgPrintSetup_Load(eventSender As Object, eventArgs As EventArgs)
			Try
				Dim form As Form = Me
				Util.CenterForm(form, RSWIN_DESC.frmMain, RSWIN_DESC.frmMain.pnlToolbar.Height, False)
				Me.PopulateInstalledPrintersListBox()
				If RSWIN_DESC.bWriteResXFile Then
					Util.OpenResourceWriter(Me.Name)
					Util.WriteControlStrings(Me, Me.ToolTip1)
					Util.CloseResourceWriter()
				End If
			Catch ex As Exception
				Dim sMsg As String = "Error in PrintSetup Load: " + ex.Message
				Dim sMsgType As String = ""
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
			End Try
		End Sub

		Private Sub PopulateInstalledPrintersListBox()
			Try
				For Each obj As Object In PrinterSettings.InstalledPrinters
					Dim text As String = Conversions.ToString(obj)
					Me.lstPrinters.Items.Add(text)
					If Operators.CompareString(Me.ps.PrinterName, text, False) = 0 Then
						If Me.ps.IsDefaultPrinter Then
							Me.SavePrinter = text
						End If
						Me.lstPrinters.SelectedIndex = Me.lstPrinters.Items.IndexOf(text)
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			Me.lblDefault.Text = "Default: " + Me.SavePrinter
		End Sub

		Private Sub lstPrinters_DoubleClick(eventSender As Object, eventArgs As EventArgs)
			Me.cmdOK_Click(Me.cmdOK, New EventArgs())
		End Sub

		<AccessedThroughProperty("cmdCancel")>
		Private _cmdCancel As Button

		<AccessedThroughProperty("cmdOK")>
		Private _cmdOK As Button

		<AccessedThroughProperty("lblDefault")>
		Private _lblDefault As Label

		<AccessedThroughProperty("_Label_0")>
		Private __Label_0 As Label

		<AccessedThroughProperty("Label")>
		Private _Label As LabelArray

		<AccessedThroughProperty("lstPrinters")>
		Private _lstPrinters As ListBox

		Private Shared m_vb6FormDefInstance As dlgPrintSetup

		Private Shared m_InitializingDefInstance As Boolean

		Private SavePrinter As String

		Private nDevices As Short

		Private asDeviceList As String()

		Private asDriverList As String()

		Private asPortList As String()

		Private ps As PrinterSettings

		Private sDefaultDevice As String

		Private Const WM_WININICHANGE As Short = 26S
	End Class
End Namespace
