Imports System
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
	Friend Partial Class frmHowToStart
		Inherits Form

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.frmHowToStart_Load
			AddHandler MyBase.Resize, AddressOf Me.frmHowToStart_Resize
			AddHandler MyBase.SizeChanged, AddressOf Me.frmHowToStart_SizeChanged
			If frmHowToStart.m_vb6FormDefInstance Is Nothing Then
				If frmHowToStart.m_InitializingDefInstance Then
					frmHowToStart.m_vb6FormDefInstance = Me
				Else
					Try
						If Assembly.GetExecutingAssembly().EntryPoint.DeclaringType Is Me.[GetType]() Then
							frmHowToStart.m_vb6FormDefInstance = Me
						End If
					Catch ex As Exception
					End Try
				End If
			End If
			Me.InitializeComponent()
		End Sub

		Public Overridable Property _Label_4 As Label
			Get
				Return Me.__Label_4
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_4 = value
			End Set
		End Property

		Public Overridable Property _imgTBButton_3 As PictureBox
			Get
				Return Me.__imgTBButton_3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me.__imgTBButton_3 = value
			End Set
		End Property

		Public Overridable Property _imgTBButton_2 As PictureBox
			Get
				Return Me.__imgTBButton_2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me.__imgTBButton_2 = value
			End Set
		End Property

		Public Overridable Property _imgTBButton_1 As PictureBox
			Get
				Return Me.__imgTBButton_1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me.__imgTBButton_1 = value
			End Set
		End Property

		Public Overridable Property _imgTBButton_0 As PictureBox
			Get
				Return Me.__imgTBButton_0
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me.__imgTBButton_0 = value
			End Set
		End Property

		Public Overridable Property _Label_3 As Label
			Get
				Return Me.__Label_3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_3 = value
			End Set
		End Property

		Public Overridable Property _Label_2 As Label
			Get
				Return Me.__Label_2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_2 = value
			End Set
		End Property

		Public Overridable Property _Label_1 As Label
			Get
				Return Me.__Label_1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_1 = value
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

		Friend Overridable Property picBox As PictureBox
			Get
				Return Me._picBox
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._picBox = value
			End Set
		End Property

		Public Shared Property DefInstance As frmHowToStart
			Get
				If frmHowToStart.m_vb6FormDefInstance Is Nothing OrElse frmHowToStart.m_vb6FormDefInstance.IsDisposed Then
					frmHowToStart.m_InitializingDefInstance = True
					frmHowToStart.m_vb6FormDefInstance = New frmHowToStart()
					frmHowToStart.m_InitializingDefInstance = False
				End If
				Return frmHowToStart.m_vb6FormDefInstance
			End Get
			Set(value As frmHowToStart)
				frmHowToStart.m_vb6FormDefInstance = value
			End Set
		End Property

		Private Sub frmHowToStart_Load(eventSender As Object, eventArgs As EventArgs)
			Dim text As String = ""
			FILEUTIL.LocateFile(Conversions.ToString(RSWIN_DESC.sHowToFileName), text, 0S, False, False, False, False)
			Try
				If RSWIN_DESC.bIntVersion Then
					Dim text2 As String = "Language"
					Dim text3 As String
					Dim regProfileString As Integer = RSWIN.GetRegProfileString(RSWIN_DESC.SECT_GENERAL, text2, RSWIN_DESC.sEnglish, text3, False)
					RSWIN_DESC.SETUP_Language = text3.Substring(0, regProfileString)
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
						If Not RSWIN_DESC.bResxReader Then
							Util.OpenResourceReader()
							Util.ReadResourceResxReader()
							Util.CloseResourceReader()
						End If
						Util.AssignValuesToControls(Me)
					End If
				End If
			Catch ex As Exception
			End Try
			If RSWIN_DESC.bExpert Then
				Me._Label_0.ForeColor = Color.Gray
				Me._Label_1.ForeColor = Color.Gray
				Me._Label_2.ForeColor = Color.Gray
				Me._Label_3.ForeColor = Color.Gray
				Me._Label_4.ForeColor = Color.Gray
			ElseIf Not RSWIN_DESC.bRodStarD Then
				Me._Label_0.ForeColor = Color.DarkBlue
				Me._Label_1.ForeColor = Color.DarkBlue
				Me._Label_2.ForeColor = Color.DarkBlue
				Me._Label_3.ForeColor = Color.DarkBlue
				Me._Label_4.ForeColor = Color.DarkBlue
			Else
				Me._Label_0.ForeColor = Color.White
				Me._Label_1.ForeColor = Color.White
				Me._Label_2.ForeColor = Color.White
				Me._Label_3.ForeColor = Color.White
				Me._Label_4.ForeColor = Color.White
			End If
			Me._Label_0.BackColor = Color.Transparent
			Me._Label_1.BackColor = Color.Transparent
			Me._Label_2.BackColor = Color.Transparent
			Me._Label_3.BackColor = Color.Transparent
			Me._Label_4.BackColor = Color.Transparent
			If Operators.CompareString(text, "", False) <> 0 Then
				Dim bitmap As Bitmap = New Bitmap(text)
				Me.Width = bitmap.Width
				Me.Height = bitmap.Height
				Me.BackgroundImage = bitmap
				Me.picBox.Visible = False
				If RSWIN_DESC.bExpert Then
					Dim text4 As String = ""
					FILEUTIL.LocateFile(RSWIN_DESC.sXRODV_Gif_Welcome_head, text4, 0S, False, False, False, False)
					If Operators.CompareString(text4, "", False) <> 0 Then
						Dim image As Bitmap = New Bitmap(text4)
						Me.picBox.BackColor = Color.Transparent
						Me.picBox.Image = image
						Me.picBox.Width = bitmap.Width
						Me.picBox.Height = bitmap.Height
						Me.picBox.SendToBack()
						Me.picBox.Visible = True
					End If
				End If
				Try
					Me.StartPosition = FormStartPosition.Manual
					Me.Left = CInt(Math.Round(CDbl((Me.ParentForm.Width - Me.Width)) / 2.0))
					Me.Top = CInt(Math.Round(CDbl((Me.ParentForm.Height - Me.Height)) / 2.0 - 35.0))
					Application.DoEvents()
				Catch ex2 As Exception
				End Try
			End If
			Me.Show()
			Application.DoEvents()
			If RSWIN_DESC.bWriteResXFile Then
				Util.OpenResourceWriter(Me.Name)
				Util.WriteControlStrings(Me, Me.ToolTip1)
				Util.CloseResourceWriter()
				Return
			End If
		End Sub

		Private Sub frmHowToStart_Resize(sender As Object, e As EventArgs)
		End Sub

		Private Sub frmHowToStart_SizeChanged(sender As Object, e As EventArgs)
		End Sub

		<AccessedThroughProperty("_Label_4")>
		Private __Label_4 As Label

		<AccessedThroughProperty("_imgTBButton_3")>
		Private __imgTBButton_3 As PictureBox

		<AccessedThroughProperty("_imgTBButton_2")>
		Private __imgTBButton_2 As PictureBox

		<AccessedThroughProperty("_imgTBButton_1")>
		Private __imgTBButton_1 As PictureBox

		<AccessedThroughProperty("_imgTBButton_0")>
		Private __imgTBButton_0 As PictureBox

		<AccessedThroughProperty("_Label_3")>
		Private __Label_3 As Label

		<AccessedThroughProperty("_Label_2")>
		Private __Label_2 As Label

		<AccessedThroughProperty("_Label_1")>
		Private __Label_1 As Label

		<AccessedThroughProperty("_Label_0")>
		Private __Label_0 As Label

		<AccessedThroughProperty("Label")>
		Private _Label As LabelArray

		<AccessedThroughProperty("picBox")>
		Private _picBox As PictureBox

		Private Shared m_vb6FormDefInstance As frmHowToStart

		Private Shared m_InitializingDefInstance As Boolean
	End Class
End Namespace
