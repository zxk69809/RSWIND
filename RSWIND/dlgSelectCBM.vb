Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Globalization
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.Compatibility.VB6
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	Friend Partial Class dlgSelectCBM
		Inherits Form

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.dlgSelectCBM_Load
			AddHandler MyBase.Closing, AddressOf Me.dlgSelectCBM_Closing
			Me.myKeyValueHT = New Hashtable()
			If dlgSelectCBM.m_vb6FormDefInstance Is Nothing Then
				If dlgSelectCBM.m_InitializingDefInstance Then
					dlgSelectCBM.m_vb6FormDefInstance = Me
				Else
					Try
						If Assembly.GetExecutingAssembly().EntryPoint.DeclaringType Is Me.[GetType]() Then
							dlgSelectCBM.m_vb6FormDefInstance = Me
						End If
					Catch ex As Exception
					End Try
				End If
			End If
			Me.InitializeComponent()
		End Sub

		Public Overridable Property Label As Label
			Get
				Return Me._Label
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label = value
			End Set
		End Property

		Public Overridable Property SSPanel As Panel
			Get
				Return Me._SSPanel
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._SSPanel = value
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

		Public Overridable Property Image As PictureBox
			Get
				Return Me._Image
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._Image = value
			End Set
		End Property

		Public Overridable Property optCBData As PictureBoxArray
			Get
				Return Me._optCBData
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBoxArray)
				Me._optCBData = value
			End Set
		End Property

		Friend Overridable Property _optCBData_0 As RadioButton
			Get
				Return Me.__optCBData_0
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Me.__optCBData_0 = value
			End Set
		End Property

		Friend Overridable Property _optCBData_1 As RadioButton
			Get
				Return Me.__optCBData_1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Me.__optCBData_1 = value
			End Set
		End Property

		Public Shared Property DefInstance As dlgSelectCBM
			Get
				If dlgSelectCBM.m_vb6FormDefInstance Is Nothing OrElse dlgSelectCBM.m_vb6FormDefInstance.IsDisposed Then
					dlgSelectCBM.m_InitializingDefInstance = True
					dlgSelectCBM.m_vb6FormDefInstance = New dlgSelectCBM()
					dlgSelectCBM.m_InitializingDefInstance = False
				End If
				Return dlgSelectCBM.m_vb6FormDefInstance
			End Get
			Set(value As dlgSelectCBM)
				dlgSelectCBM.m_vb6FormDefInstance = value
			End Set
		End Property

		Private Sub cmdOK_Click(eventSender As Object, eventArgs As EventArgs)
			If Me._optCBData_0.Checked Then
				Me.Tag = 1
			ElseIf Me._optCBData_1.Checked Then
				Me.Tag = 0
			End If
			Me.Hide()
		End Sub

		Private Sub dlgSelectCBM_Load(eventSender As Object, eventArgs As EventArgs)
			If RSWIN_DESC.bIntVersion Then
				If RSWIN_DESC.bChangeCultures Then
					Dim setup_Language As String = RSWIN_DESC.SETUP_Language
					If Operators.CompareString(setup_Language, RSWIN_DESC.sEnglish, False) = 0 Then
						RSWIN_DESC.myCulture = New CultureInfo(RSWIN_DESC.sEnglish)
					ElseIf Operators.CompareString(setup_Language, RSWIN_DESC.sSpanish, False) = 0 Then
						RSWIN_DESC.myCulture = New CultureInfo(RSWIN_DESC.sSpanish)
					ElseIf Operators.CompareString(setup_Language, RSWIN_DESC.sChinese, False) = 0 Then
						RSWIN_DESC.myCulture = New CultureInfo(RSWIN_DESC.sChinese)
					Else
						RSWIN_DESC.myCulture = New CultureInfo(RSWIN_DESC.sEnglish)
					End If
					Thread.CurrentThread.CurrentUICulture = RSWIN_DESC.myCulture
				End If
				If RSWIN_DESC.bReadResXFile Then
					Util.AssignValuesToControls(Me)
				End If
			End If
			Dim form As Form = Me
			Util.CenterForm(form, RSWIN_DESC.frmMain, RSWIN_DESC.frmMain.pnlToolbar.Height, False)
			If RSWIN_DESC.rst.PU.UnitType <> 8S Then
				Me.Label.Text = " RODSTAR has calculated a balanced CB moment for minimum torque and a balanced CB moment for minimum energy.  Which do you want to export to XBAL?"
			Else
				Me.Label.Text = " RODSTAR has calculated required structural unbalance for minimum torque and for minimum energy.  Which do you want to export to XBAL?"
			End If
			If RSWIN_DESC.bIntVersion Then
				If RSWIN_DESC.bWriteResXFile Then
					Util.OpenResourceWriter(Me.Name)
					Util.WriteControlStrings(Me, Me.ToolTip1)
					Util.CloseResourceWriter()
				End If
				Return
			End If
		End Sub

		Private Sub dlgSelectCBM_Closing(eventSender As Object, eventArgs As CancelEventArgs)
			Dim num As Short = If((-If((eventArgs.Cancel > False), 1S, 0S)), 1S, 0S)
			eventArgs.Cancel = (num <> 0S)
		End Sub

		Private Sub optCBData_GotFocus(ByRef Index As Short)
		End Sub

		Private Sub optCBData_LostFocus(ByRef Index As Short)
		End Sub

		<AccessedThroughProperty("Label")>
		Private _Label As Label

		<AccessedThroughProperty("SSPanel")>
		Private _SSPanel As Panel

		<AccessedThroughProperty("cmdOK")>
		Private _cmdOK As Button

		<AccessedThroughProperty("Image")>
		Private _Image As PictureBox

		<AccessedThroughProperty("optCBData")>
		Private _optCBData As PictureBoxArray

		<AccessedThroughProperty("_optCBData_0")>
		Private __optCBData_0 As RadioButton

		<AccessedThroughProperty("_optCBData_1")>
		Private __optCBData_1 As RadioButton

		Private Shared m_vb6FormDefInstance As dlgSelectCBM

		Private Shared m_InitializingDefInstance As Boolean

		Private myKeyValueHT As Hashtable
	End Class
End Namespace
