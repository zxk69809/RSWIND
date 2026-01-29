Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Globalization
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.Compatibility.VB6
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	Friend Partial Class dlgCoverPageComments
		Inherits Form

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.dlgCoverPageComments_Load
			Me.sSecondCompanyIconFilename = ""
			If dlgCoverPageComments.m_vb6FormDefInstance Is Nothing Then
				If dlgCoverPageComments.m_InitializingDefInstance Then
					dlgCoverPageComments.m_vb6FormDefInstance = Me
				Else
					Try
						If Assembly.GetExecutingAssembly().EntryPoint.DeclaringType Is Me.[GetType]() Then
							dlgCoverPageComments.m_vb6FormDefInstance = Me
						End If
					Catch ex As Exception
					End Try
				End If
			End If
			Me.InitializeComponent()
		End Sub

		Public Overridable Property _SSPanel_0 As Panel
			Get
				Return Me.__SSPanel_0
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me.__SSPanel_0 = value
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

		Public Overridable Property SSPanel As PanelArray
			Get
				Return Me._SSPanel
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PanelArray)
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

		Public Overridable Property btnResetComments As Button
			Get
				Return Me._btnResetComments
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnResetComments_Click
				If Me._btnResetComments IsNot Nothing Then
					RemoveHandler Me._btnResetComments.Click, value2
				End If
				Me._btnResetComments = value
				If Me._btnResetComments IsNot Nothing Then
					AddHandler Me._btnResetComments.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property rtbComments As RichTextBox
			Get
				Return Me._rtbComments
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RichTextBox)
				Me._rtbComments = value
			End Set
		End Property

		Friend Overridable Property btnAddWellInfoComment As Button
			Get
				Return Me._btnAddWellInfoComment
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnAddWellInfoComment_Click
				If Me._btnAddWellInfoComment IsNot Nothing Then
					RemoveHandler Me._btnAddWellInfoComment.Click, value2
				End If
				Me._btnAddWellInfoComment = value
				If Me._btnAddWellInfoComment IsNot Nothing Then
					AddHandler Me._btnAddWellInfoComment.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property btnAddRodStringInfo As Button
			Get
				Return Me._btnAddRodStringInfo
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnAddRodStringInfo_Click
				If Me._btnAddRodStringInfo IsNot Nothing Then
					RemoveHandler Me._btnAddRodStringInfo.Click, value2
				End If
				Me._btnAddRodStringInfo = value
				If Me._btnAddRodStringInfo IsNot Nothing Then
					AddHandler Me._btnAddRodStringInfo.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property btnAddSetupComment As Button
			Get
				Return Me._btnAddSetupComment
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnAddSetupComment_Click
				If Me._btnAddSetupComment IsNot Nothing Then
					RemoveHandler Me._btnAddSetupComment.Click, value2
				End If
				Me._btnAddSetupComment = value
				If Me._btnAddSetupComment IsNot Nothing Then
					AddHandler Me._btnAddSetupComment.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property Panel1 As Panel
			Get
				Return Me._Panel1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._Panel1 = value
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

		Friend Overridable Property lblComments As Label
			Get
				Return Me._lblComments
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblComments = value
			End Set
		End Property

		Friend Overridable Property txtCustomerContactName As TextBox
			Get
				Return Me._txtCustomerContactName
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtCustomerContactName = value
			End Set
		End Property

		Friend Overridable Property txtCustomerCompanyName As TextBox
			Get
				Return Me._txtCustomerCompanyName
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtCustomerCompanyName = value
			End Set
		End Property

		Friend Overridable Property Label1 As Label
			Get
				Return Me._Label1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label1 = value
			End Set
		End Property

		Friend Overridable Property lblCustomerCompany As Label
			Get
				Return Me._lblCustomerCompany
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblCustomerCompany = value
			End Set
		End Property

		Friend Overridable Property txtFootnote As TextBox
			Get
				Return Me._txtFootnote
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtFootnote = value
			End Set
		End Property

		Friend Overridable Property lblFootnote As Label
			Get
				Return Me._lblFootnote
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblFootnote = value
			End Set
		End Property

		Friend Overridable Property lblMyCompanyName As Label
			Get
				Return Me._lblMyCompanyName
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblMyCompanyName = value
			End Set
		End Property

		Friend Overridable Property txtMyCompanyName As TextBox
			Get
				Return Me._txtMyCompanyName
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtMyCompanyName = value
			End Set
		End Property

		Friend Overridable Property txtMyContactName As TextBox
			Get
				Return Me._txtMyContactName
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtMyContactName = value
			End Set
		End Property

		Friend Overridable Property lblMyContactName As Label
			Get
				Return Me._lblMyContactName
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblMyContactName = value
			End Set
		End Property

		Friend Overridable Property txtMyCompanyWebsite As TextBox
			Get
				Return Me._txtMyCompanyWebsite
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtMyCompanyWebsite = value
			End Set
		End Property

		Friend Overridable Property lblMyCompanyWebsite As Label
			Get
				Return Me._lblMyCompanyWebsite
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblMyCompanyWebsite = value
			End Set
		End Property

		Friend Overridable Property txtAddress1 As TextBox
			Get
				Return Me._txtAddress1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtAddress1 = value
			End Set
		End Property

		Friend Overridable Property lblAddress1 As Label
			Get
				Return Me._lblAddress1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblAddress1 = value
			End Set
		End Property

		Friend Overridable Property txtAddress2 As TextBox
			Get
				Return Me._txtAddress2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtAddress2 = value
			End Set
		End Property

		Friend Overridable Property lblAddress2 As Label
			Get
				Return Me._lblAddress2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblAddress2 = value
			End Set
		End Property

		Friend Overridable Property txtMyTelephone As TextBox
			Get
				Return Me._txtMyTelephone
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtMyTelephone = value
			End Set
		End Property

		Friend Overridable Property lblPhone As Label
			Get
				Return Me._lblPhone
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblPhone = value
			End Set
		End Property

		Friend Overridable Property btnLogo As Button
			Get
				Return Me._btnLogo
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnLogo_Click
				If Me._btnLogo IsNot Nothing Then
					RemoveHandler Me._btnLogo.Click, value2
				End If
				Me._btnLogo = value
				If Me._btnLogo IsNot Nothing Then
					AddHandler Me._btnLogo.Click, value2
				End If
			End Set
		End Property

		Public Overridable Property _Label_WellInfo_Comment As Label
			Get
				Return Me.__Label_WellInfo_Comment
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_WellInfo_Comment = value
			End Set
		End Property

		Friend Overridable Property rtbSetupDefault As RichTextBox
			Get
				Return Me._rtbSetupDefault
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RichTextBox)
				Me._rtbSetupDefault = value
			End Set
		End Property

		Public Overridable Property lblSetupDefaultsComment As Label
			Get
				Return Me._lblSetupDefaultsComment
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblSetupDefaultsComment = value
			End Set
		End Property

		Friend Overridable Property txtWellInfoComment As RichTextBox
			Get
				Return Me._txtWellInfoComment
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RichTextBox)
				Me._txtWellInfoComment = value
			End Set
		End Property

		Public Shared Property DefInstance As dlgCoverPageComments
			Get
				If dlgCoverPageComments.m_vb6FormDefInstance Is Nothing OrElse dlgCoverPageComments.m_vb6FormDefInstance.IsDisposed Then
					dlgCoverPageComments.m_InitializingDefInstance = True
					dlgCoverPageComments.m_vb6FormDefInstance = New dlgCoverPageComments()
					dlgCoverPageComments.m_InitializingDefInstance = False
				End If
				Return dlgCoverPageComments.m_vb6FormDefInstance
			End Get
			Set(value As dlgCoverPageComments)
				dlgCoverPageComments.m_vb6FormDefInstance = value
			End Set
		End Property

		Private Sub dlgCoverPageComments_Load(eventSender As Object, eventArgs As EventArgs)
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
			Try
				Me.PopulateControls()
			Catch ex As Exception
			End Try
			Me._Label_0.Text = String.Concat(New String() { vbTab & "The comments below will be used in the Cover Page. You may include ", RSWIN_DESC.sDblQuote, "File Comments", RSWIN_DESC.sDblQuote, " from the Well Information window, ", RSWIN_DESC.sDblQuote, "Cover Page Comments", RSWIN_DESC.sDblQuote, " from Setup/Defaults, and Rod String design which will be added at runtime replacing ", RSWIN_DESC.sDblQuote, "< Insert Rod String Information here >", RSWIN_DESC.sDblQuote, ". You may also edit other cover page items, found in Setup/Defaults, here as well." })
			If RSWIN_DESC.rst.CoverPageComment IsNot Nothing Then
				Me.rtbComments.Text = RSWIN_DESC.rst.CoverPageComment
			End If
			If RSWIN_DESC.bWriteResXFile Then
				Util.OpenResourceWriter(Me.Name)
				Util.WriteControlStrings(Me, Me.ToolTip1)
				Util.CloseResourceWriter()
				Return
			End If
		End Sub

		Private Sub AddFileComments()
			Try
				Dim text As String = "< Insert Well Information Comment Here >"
				If Strings.InStr(Me.rtbComments.Text, text, CompareMethod.Binary) <= 0 Then
					Me.rtbComments.Text = Me.rtbComments.Text + vbCrLf + text + vbCrLf
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub btnResetComments_Click(sender As Object, e As EventArgs)
			Dim text As String = ""
			Try
				Me.rtbComments.Text = text
			Catch ex As Exception
			End Try
		End Sub

		Private Sub AddRodStringInfo()
			Try
				Dim text As String = "< Insert Rod String Information Here >"
				If Strings.InStr(Me.rtbComments.Text, text, CompareMethod.Binary) <= 0 Then
					Me.rtbComments.Text = Me.rtbComments.Text + vbCrLf + text + vbCrLf
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub AddSetupCoverComments()
			Try
				Dim text As String = "< Insert Setup / Defaults Comment Here >"
				If Strings.InStr(Me.rtbComments.Text, text, CompareMethod.Binary) <= 0 Then
					Me.rtbComments.Text = Me.rtbComments.Text + vbCrLf + text + vbCrLf
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub cmdOK_Click(sender As Object, e As EventArgs)
			Try
				RSWIN_DESC.rst.CoverPageComment = Me.rtbComments.Text
				Me.SaveDefaults()
				Me.Close()
			Catch ex As Exception
			End Try
		End Sub

		Private Sub cmdCancel_Click(sender As Object, e As EventArgs)
			Try
				Me.Close()
			Catch ex As Exception
			End Try
		End Sub

		Private Sub btnAddWellInfoComment_Click(sender As Object, e As EventArgs)
			Me.AddFileComments()
		End Sub

		Private Sub btnAddRodStringInfo_Click(sender As Object, e As EventArgs)
			Me.AddRodStringInfo()
		End Sub

		Private Sub btnAddSetupComment_Click(sender As Object, e As EventArgs)
			Me.AddSetupCoverComments()
		End Sub

		Private Sub PopulateControls()
			Dim text As String = ""
			Try
				Dim sDefaultName As String = "SecondCompanyName"
				Dim vNotPresentDefault As Object = ""
				Dim flag As Boolean = False
				Dim text2 As String = Conversions.ToString(ini.GetDefault(sDefaultName, vNotPresentDefault, flag))
				If text2 IsNot Nothing Then
					Me.txtMyCompanyName.Text = text2
				End If
			Catch ex As Exception
			End Try
			Try
				Dim sDefaultName2 As String = "SecondCompanyContactName"
				Dim vNotPresentDefault2 As Object = ""
				Dim flag As Boolean = False
				Dim text3 As String = Conversions.ToString(ini.GetDefault(sDefaultName2, vNotPresentDefault2, flag))
				If text3 IsNot Nothing Then
					Me.txtMyContactName.Text = text3
				End If
			Catch ex2 As Exception
			End Try
			Try
				Dim sDefaultName3 As String = "SecondCompanyPhone"
				Dim vNotPresentDefault3 As Object = ""
				Dim flag As Boolean = False
				Dim text4 As String = Conversions.ToString(ini.GetDefault(sDefaultName3, vNotPresentDefault3, flag))
				If text4 IsNot Nothing Then
					Me.txtMyTelephone.Text = text4
				End If
			Catch ex3 As Exception
			End Try
			Try
				Dim sDefaultName4 As String = "SecondCompanyAddress1"
				Dim vNotPresentDefault4 As Object = ""
				Dim flag As Boolean = False
				Dim text5 As String = Conversions.ToString(ini.GetDefault(sDefaultName4, vNotPresentDefault4, flag))
				If text5 IsNot Nothing Then
					Me.txtAddress1.Text = text5
				End If
			Catch ex4 As Exception
			End Try
			Try
				Dim sDefaultName5 As String = "SecondCompanyAddress2"
				Dim vNotPresentDefault5 As Object = ""
				Dim flag As Boolean = False
				Dim text6 As String = Conversions.ToString(ini.GetDefault(sDefaultName5, vNotPresentDefault5, flag))
				If text6 IsNot Nothing Then
					Me.txtAddress2.Text = text6
				End If
			Catch ex5 As Exception
			End Try
			Try
				Dim sDefaultName6 As String = "SecondCompanyWebsite"
				Dim vNotPresentDefault6 As Object = ""
				Dim flag As Boolean = False
				Dim text7 As String = Conversions.ToString(ini.GetDefault(sDefaultName6, vNotPresentDefault6, flag))
				If text7 IsNot Nothing Then
					Me.txtMyCompanyWebsite.Text = text7
				End If
			Catch ex6 As Exception
			End Try
			Try
				Dim sDefaultName7 As String = "SecondCompanyFootnote"
				Dim vNotPresentDefault7 As Object = ""
				Dim flag As Boolean = False
				Dim text8 As String = Conversions.ToString(ini.GetDefault(sDefaultName7, vNotPresentDefault7, flag))
				If text8 IsNot Nothing Then
					Me.txtFootnote.Text = text8
				End If
			Catch ex7 As Exception
			End Try
			Try
				Dim sDefaultName8 As String = "SecondCompanyCustomerCompany"
				Dim vNotPresentDefault8 As Object = ""
				Dim flag As Boolean = False
				Dim text9 As String = Conversions.ToString(ini.GetDefault(sDefaultName8, vNotPresentDefault8, flag))
				If text9 IsNot Nothing Then
					Me.txtCustomerCompanyName.Text = text9
				End If
			Catch ex8 As Exception
			End Try
			Try
				Dim sDefaultName9 As String = "SecondCompanyCustomerName"
				Dim vNotPresentDefault9 As Object = ""
				Dim flag As Boolean = False
				Dim text10 As String = Conversions.ToString(ini.GetDefault(sDefaultName9, vNotPresentDefault9, flag))
				If text10 IsNot Nothing Then
					Me.txtCustomerContactName.Text = text10
				End If
			Catch ex9 As Exception
			End Try
			Try
				Dim sDefaultName10 As String = "SecondCompanyFootnote"
				Dim vNotPresentDefault10 As Object = ""
				Dim flag As Boolean = False
				Dim text11 As String = Conversions.ToString(ini.GetDefault(sDefaultName10, vNotPresentDefault10, flag))
				If text11 IsNot Nothing Then
					Me.txtFootnote.Text = text11
				End If
			Catch ex10 As Exception
			End Try
			Try
				text = ""
				Dim text12 As String = "SecondCompanyIconFilename"
				Dim text13 As String = ""
				Dim regProfileString As Integer = RSWIN.GetRegProfileString(RSWIN_DESC.SECT_DEFAULTS, text12, text13, text, False)
				Me.sSecondCompanyIconFilename = text.Substring(0, regProfileString)
				If Me.sSecondCompanyIconFilename IsNot Nothing AndAlso Operators.CompareString(Me.sSecondCompanyIconFilename.Trim(), "", False) <> 0 AndAlso FILEUTIL.FileExists(Me.sSecondCompanyIconFilename) Then
					Me.btnLogo.Text = ""
					Dim image As Bitmap = New Bitmap(Me.sSecondCompanyIconFilename)
					Me.btnLogo.Image = image
				End If
			Catch ex11 As Exception
			End Try
			Try
				If RSWIN_DESC.rst.FileComment IsNot Nothing Then
					Me.txtWellInfoComment.Text = RSWIN_DESC.rst.FileComment
				Else
					Me.txtWellInfoComment.Text = ""
				End If
			Catch ex12 As Exception
			End Try
			Try
				text = ""
				Dim text13 As String = "SecondCompanyComments"
				Dim text12 As String = ""
				Dim regProfileString As Integer = RSWIN.GetRegProfileString(RSWIN_DESC.SECT_DEFAULTS, text13, text12, text, False)
				Dim text14 As String = text.Substring(0, regProfileString)
				If text14 IsNot Nothing Then
					If Operators.CompareString(text14, "", False) <> 0 Then
						Me.rtbSetupDefault.Text = text14
					End If
				Else
					Me.rtbSetupDefault.Text = ""
				End If
			Catch ex13 As Exception
			End Try
		End Sub

		Private Sub SaveDefaults()
			Try
				Dim text As String = "SecondCompanyName"
				Dim textBox As TextBox = Me.txtMyCompanyName
				Dim text2 As String = textBox.Text
				RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_DEFAULTS, text, text2, "")
				textBox.Text = text2
			Catch ex As Exception
			End Try
			Try
				Dim text2 As String = "SecondCompanyContactName"
				Dim textBox As TextBox = Me.txtMyContactName
				Dim text As String = textBox.Text
				RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_DEFAULTS, text2, text, "")
				textBox.Text = text
			Catch ex2 As Exception
			End Try
			Try
				Dim text2 As String = "SecondCompanyPhone"
				Dim textBox As TextBox = Me.txtMyTelephone
				Dim text As String = textBox.Text
				RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_DEFAULTS, text2, text, "")
				textBox.Text = text
			Catch ex3 As Exception
			End Try
			Try
				Dim text2 As String = "SecondCompanyAddress1"
				Dim textBox As TextBox = Me.txtAddress1
				Dim text As String = textBox.Text
				RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_DEFAULTS, text2, text, "")
				textBox.Text = text
			Catch ex4 As Exception
			End Try
			Try
				Dim text2 As String = "SecondCompanyAddress2"
				Dim textBox As TextBox = Me.txtAddress2
				Dim text As String = textBox.Text
				RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_DEFAULTS, text2, text, "")
				textBox.Text = text
			Catch ex5 As Exception
			End Try
			Try
				Dim text2 As String = "SecondCompanyWebsite"
				Dim textBox As TextBox = Me.txtMyCompanyWebsite
				Dim text As String = textBox.Text
				RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_DEFAULTS, text2, text, "")
				textBox.Text = text
			Catch ex6 As Exception
			End Try
			Try
				Dim text2 As String = "SecondCompanyFootnote"
				Dim textBox As TextBox = Me.txtFootnote
				Dim text As String = textBox.Text
				RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_DEFAULTS, text2, text, "")
				textBox.Text = text
			Catch ex7 As Exception
			End Try
			Try
				Dim text2 As String = "SecondCompanyCustomerCompany"
				Dim textBox As TextBox = Me.txtCustomerCompanyName
				Dim text As String = textBox.Text
				RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_DEFAULTS, text2, text, "")
				textBox.Text = text
			Catch ex8 As Exception
			End Try
			Try
				Dim text2 As String = "SecondCompanyCustomerName"
				Dim textBox As TextBox = Me.txtCustomerContactName
				Dim text As String = textBox.Text
				RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_DEFAULTS, text2, text, "")
				textBox.Text = text
			Catch ex9 As Exception
			End Try
			Try
				Dim text2 As String = "SecondCompanyFootnote"
				Dim textBox As TextBox = Me.txtFootnote
				Dim text As String = textBox.Text
				RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_DEFAULTS, text2, text, "")
				textBox.Text = text
			Catch ex10 As Exception
			End Try
			Try
				Dim text2 As String = "SecondCompanyIconFilename"
				RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_DEFAULTS, text2, Me.sSecondCompanyIconFilename, "")
			Catch ex11 As Exception
			End Try
			Try
				If Operators.CompareString(Me.rtbSetupDefault.Text, "", False) <> 0 Then
					Dim text2 As String = "SecondCompanyComments"
					Dim rtbSetupDefault As RichTextBox = Me.rtbSetupDefault
					Dim text As String = rtbSetupDefault.Text
					RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_DEFAULTS, text2, text, RSWIN_DESC.sINIFile)
					rtbSetupDefault.Text = text
				End If
			Catch ex12 As Exception
			End Try
			Try
				If Operators.CompareString(Me.txtWellInfoComment.Text, "", False) <> 0 Then
					RSWIN_DESC.rst.FileComment = Me.txtWellInfoComment.Text
					ini.SaveDataValue("FileComment", Strings.Trim(RSWIN_DESC.rst.FileComment))
				End If
			Catch ex13 As Exception
			End Try
		End Sub

		Private Sub btnLogo_Click(sender As Object, e As EventArgs)
			Dim folderBrowserDialog As FolderBrowserDialog = New FolderBrowserDialog()
			Dim obj As Object = "Imape Files (*.bmp,*.gif,*.jpg)|*.bmp;*.gif;*.jpg"
			Dim startupPath As String = Application.StartupPath
			Dim text As String
			FILEIO.SelectInputFile(text, startupPath, Conversions.ToString(obj), 1, "", "Company Icon Image File")
			If text IsNot Nothing Then
				Me.sSecondCompanyIconFilename = text
				If FILEUTIL.FileExists(Me.sSecondCompanyIconFilename) Then
					Me.btnLogo.Text = ""
					Dim image As Bitmap = New Bitmap(Me.sSecondCompanyIconFilename)
					Me.btnLogo.Image = image
				End If
				Return
			End If
		End Sub

		<AccessedThroughProperty("_SSPanel_0")>
		Private __SSPanel_0 As Panel

		<AccessedThroughProperty("Label")>
		Private _Label As LabelArray

		<AccessedThroughProperty("SSPanel")>
		Private _SSPanel As PanelArray

		<AccessedThroughProperty("cmdOK")>
		Private _cmdOK As Button

		<AccessedThroughProperty("cmdCancel")>
		Private _cmdCancel As Button

		<AccessedThroughProperty("btnResetComments")>
		Private _btnResetComments As Button

		<AccessedThroughProperty("rtbComments")>
		Private _rtbComments As RichTextBox

		<AccessedThroughProperty("btnAddWellInfoComment")>
		Private _btnAddWellInfoComment As Button

		<AccessedThroughProperty("btnAddRodStringInfo")>
		Private _btnAddRodStringInfo As Button

		<AccessedThroughProperty("btnAddSetupComment")>
		Private _btnAddSetupComment As Button

		<AccessedThroughProperty("Panel1")>
		Private _Panel1 As Panel

		<AccessedThroughProperty("_Label_0")>
		Private __Label_0 As Label

		<AccessedThroughProperty("lblComments")>
		Private _lblComments As Label

		<AccessedThroughProperty("txtCustomerContactName")>
		Private _txtCustomerContactName As TextBox

		<AccessedThroughProperty("txtCustomerCompanyName")>
		Private _txtCustomerCompanyName As TextBox

		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		<AccessedThroughProperty("lblCustomerCompany")>
		Private _lblCustomerCompany As Label

		<AccessedThroughProperty("txtFootnote")>
		Private _txtFootnote As TextBox

		<AccessedThroughProperty("lblFootnote")>
		Private _lblFootnote As Label

		<AccessedThroughProperty("lblMyCompanyName")>
		Private _lblMyCompanyName As Label

		<AccessedThroughProperty("txtMyCompanyName")>
		Private _txtMyCompanyName As TextBox

		<AccessedThroughProperty("txtMyContactName")>
		Private _txtMyContactName As TextBox

		<AccessedThroughProperty("lblMyContactName")>
		Private _lblMyContactName As Label

		<AccessedThroughProperty("txtMyCompanyWebsite")>
		Private _txtMyCompanyWebsite As TextBox

		<AccessedThroughProperty("lblMyCompanyWebsite")>
		Private _lblMyCompanyWebsite As Label

		<AccessedThroughProperty("txtAddress1")>
		Private _txtAddress1 As TextBox

		<AccessedThroughProperty("lblAddress1")>
		Private _lblAddress1 As Label

		<AccessedThroughProperty("txtAddress2")>
		Private _txtAddress2 As TextBox

		<AccessedThroughProperty("lblAddress2")>
		Private _lblAddress2 As Label

		<AccessedThroughProperty("txtMyTelephone")>
		Private _txtMyTelephone As TextBox

		<AccessedThroughProperty("lblPhone")>
		Private _lblPhone As Label

		<AccessedThroughProperty("btnLogo")>
		Private _btnLogo As Button

		<AccessedThroughProperty("_Label_WellInfo_Comment")>
		Private __Label_WellInfo_Comment As Label

		<AccessedThroughProperty("rtbSetupDefault")>
		Private _rtbSetupDefault As RichTextBox

		<AccessedThroughProperty("lblSetupDefaultsComment")>
		Private _lblSetupDefaultsComment As Label

		<AccessedThroughProperty("txtWellInfoComment")>
		Private _txtWellInfoComment As RichTextBox

		Private Shared m_vb6FormDefInstance As dlgCoverPageComments

		Private Shared m_InitializingDefInstance As Boolean

		Private sSecondCompanyIconFilename As String
	End Class
End Namespace
