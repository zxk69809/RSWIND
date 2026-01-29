Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.Compatibility.VB6

Namespace RSWINV3
	Friend Partial Class dlgCBData
		Inherits Form

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.dlgCBData_Load
			If dlgCBData.m_vb6FormDefInstance Is Nothing Then
				If dlgCBData.m_InitializingDefInstance Then
					dlgCBData.m_vb6FormDefInstance = Me
				Else
					Try
						If Assembly.GetExecutingAssembly().EntryPoint.DeclaringType Is Me.[GetType]() Then
							dlgCBData.m_vb6FormDefInstance = Me
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

		Public Overridable Property Panel3D1 As Panel
			Get
				Return Me._Panel3D1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._Panel3D1 = value
			End Set
		End Property

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

		Public Overridable Property txtCBM As TextBox
			Get
				Return Me._txtCBM
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtCBM_TextChanged
				If Me._txtCBM IsNot Nothing Then
					RemoveHandler Me._txtCBM.TextChanged, value2
				End If
				Me._txtCBM = value
				If Me._txtCBM IsNot Nothing Then
					AddHandler Me._txtCBM.TextChanged, value2
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
				Dim value2 As EventHandler = AddressOf Me._optCBData_0_CheckedChanged
				If Me.__optCBData_0 IsNot Nothing Then
					RemoveHandler Me.__optCBData_0.CheckedChanged, value2
				End If
				Me.__optCBData_0 = value
				If Me.__optCBData_0 IsNot Nothing Then
					AddHandler Me.__optCBData_0.CheckedChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property _optCBData_1 As RadioButton
			Get
				Return Me.__optCBData_1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Dim value2 As EventHandler = AddressOf Me._optCBData_1_CheckedChanged
				If Me.__optCBData_1 IsNot Nothing Then
					RemoveHandler Me.__optCBData_1.CheckedChanged, value2
				End If
				Me.__optCBData_1 = value
				If Me.__optCBData_1 IsNot Nothing Then
					AddHandler Me.__optCBData_1.CheckedChanged, value2
				End If
			End Set
		End Property

		Public Shared Property DefInstance As dlgCBData
			Get
				If dlgCBData.m_vb6FormDefInstance Is Nothing OrElse dlgCBData.m_vb6FormDefInstance.IsDisposed Then
					dlgCBData.m_InitializingDefInstance = True
					dlgCBData.m_vb6FormDefInstance = New dlgCBData()
					dlgCBData.m_InitializingDefInstance = False
				End If
				Return dlgCBData.m_vb6FormDefInstance
			End Get
			Set(value As dlgCBData)
				dlgCBData.m_vb6FormDefInstance = value
			End Set
		End Property

		Public Property bCancel As Boolean
			Get
				Return Me.m_bCancel
			End Get
			Set(value As Boolean)
				Me.m_bCancel = value
			End Set
		End Property

		Public Property CBMoment As Single
			Get
				Return Me.m_CBMoment
			End Get
			Set(value As Single)
				Me.m_CBMoment = value
			End Set
		End Property

		Private Sub cmdCancel_Click(eventSender As Object, eventArgs As EventArgs)
			Me.bCancel = True
			Me.Close()
		End Sub

		Private Sub cmdOK_Click(eventSender As Object, eventArgs As EventArgs)
			Me.bCancel = False
			Me.Tag = Me._optCBData_0.Checked
			Me.Hide()
		End Sub

		Private Sub dlgCBData_Load(eventSender As Object, eventArgs As EventArgs)
			Try
				RSWIN.GetMeasurementUnit()
				If Not(RSWIN_DESC.rst.PU.UnitType = 8S Or RSWIN_DESC.bBeamBalanced) Then
					Me.Label.Text = "XBAL has placed an existing maximum counterbalance moment of " + Me.txtCBM.Text + " on the Clipboard.  Do you want to use this value, or read an existing maximum counterbalance moment from a XBAL data file?"
					Me._optCBData_0.Text = "Use CB moment exported by XBAL"
				Else
					Me.Label.Text = "XBAL has placed an calculated structural unbalance of " + Me.txtCBM.Text + " on the Clipboard.  Do you want to use this value, or read an calculated structural unbalance from a XBAL data file?"
					Me._optCBData_0.Text = "Use calculated structural unbalance exported by XBAL"
				End If
				Dim form As Form = Me
				Util.CenterForm(form, RSWIN_DESC.frmMain, RSWIN_DESC.frmMain.pnlToolbar.Height, False)
				If RSWIN_DESC.bWriteResXFile Then
					Util.OpenResourceWriter(Me.Name)
					Util.WriteControlStrings(Me, Me.ToolTip1)
					Util.CloseResourceWriter()
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub txtCBM_TextChanged(eventSender As Object, eventArgs As EventArgs)
			If Not(RSWIN_DESC.rst.PU.UnitType = 8S Or RSWIN_DESC.bBeamBalanced) Then
				Me.Label.Text = "XBAL has placed an existing maximum counterbalance moment of " + Me.txtCBM.Text + " on the Clipboard.  Do you want to use this value, or read an existing maximum counterbalance moment from a XBAL data file?"
				Return
			End If
			Me.Label.Text = "XBAL has placed a required structural unbalance of " + Me.txtCBM.Text + " on the Clipboard.  Do you want to use this value, or read a value from a XBAL data file?"
		End Sub

		Private Sub _optCBData_0_CheckedChanged(sender As Object, e As EventArgs)
		End Sub

		Private Sub _optCBData_1_CheckedChanged(sender As Object, e As EventArgs)
		End Sub

		<AccessedThroughProperty("Label")>
		Private _Label As Label

		<AccessedThroughProperty("Panel3D1")>
		Private _Panel3D1 As Panel

		<AccessedThroughProperty("cmdCancel")>
		Private _cmdCancel As Button

		<AccessedThroughProperty("txtCBM")>
		Private _txtCBM As TextBox

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

		Private Shared m_vb6FormDefInstance As dlgCBData

		Private Shared m_InitializingDefInstance As Boolean

		Private m_bCancel As Boolean

		Private m_CBMoment As Single
	End Class
End Namespace
