Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Globalization
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	Public Partial Class frmSendEmail
		Inherits Form

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.frmSendEmail_Load
			Me.sSelectFile = Util.AssignValueToConstant("frmSendEmail", "sSelectFile", "Select file attachment")
			Me.sPleaseEnterValue = Util.AssignValueToConstant("frmSendEmail", "sPleaseEnterValue", "Please enter a value for field ")
			Me.sEmailUtilityError = Util.AssignValueToConstant("frmSendEmail", "sEmailUtilityError", "Email utility data entry error")
			Me.sNoOutput = Util.AssignValueToConstant("frmSendEmail", "sNoOutput", "Default Input file (file1) does not contain Output. Continue?")
			Me.sSupport = "support@gotheta.com"
			Me.InitializeComponent()
		End Sub

		Friend Overridable Property grpSendEmail As GroupBox
			Get
				Return Me._grpSendEmail
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Dim value2 As EventHandler = AddressOf Me.grpSendEmail_Enter
				If Me._grpSendEmail IsNot Nothing Then
					RemoveHandler Me._grpSendEmail.Enter, value2
				End If
				Me._grpSendEmail = value
				If Me._grpSendEmail IsNot Nothing Then
					AddHandler Me._grpSendEmail.Enter, value2
				End If
			End Set
		End Property

		Friend Overridable Property cmdBrowse_2 As Button
			Get
				Return Me._cmdBrowse_2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.cmdBrowse_2_Click
				If Me._cmdBrowse_2 IsNot Nothing Then
					RemoveHandler Me._cmdBrowse_2.Click, value2
				End If
				Me._cmdBrowse_2 = value
				If Me._cmdBrowse_2 IsNot Nothing Then
					AddHandler Me._cmdBrowse_2.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property cmdBrowse_1 As Button
			Get
				Return Me._cmdBrowse_1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.cmdBrowse_1_Click
				If Me._cmdBrowse_1 IsNot Nothing Then
					RemoveHandler Me._cmdBrowse_1.Click, value2
				End If
				Me._cmdBrowse_1 = value
				If Me._cmdBrowse_1 IsNot Nothing Then
					AddHandler Me._cmdBrowse_1.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property cmdBrowse_0 As Button
			Get
				Return Me._cmdBrowse_0
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.cmdBrowse_0_Click
				If Me._cmdBrowse_0 IsNot Nothing Then
					RemoveHandler Me._cmdBrowse_0.Click, value2
				End If
				Me._cmdBrowse_0 = value
				If Me._cmdBrowse_0 IsNot Nothing Then
					AddHandler Me._cmdBrowse_0.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property lblFrom As Label
			Get
				Return Me._lblFrom
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblFrom = value
			End Set
		End Property

		Friend Overridable Property lblTO As Label
			Get
				Return Me._lblTO
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblTO = value
			End Set
		End Property

		Friend Overridable Property lblFirst As Label
			Get
				Return Me._lblFirst
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblFirst = value
			End Set
		End Property

		Friend Overridable Property txtFrom As TextBox
			Get
				Return Me._txtFrom
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtFrom_TextChanged
				If Me._txtFrom IsNot Nothing Then
					RemoveHandler Me._txtFrom.TextChanged, value2
				End If
				Me._txtFrom = value
				If Me._txtFrom IsNot Nothing Then
					AddHandler Me._txtFrom.TextChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property lblSecond As Label
			Get
				Return Me._lblSecond
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblSecond = value
			End Set
		End Property

		Friend Overridable Property lblThird As Label
			Get
				Return Me._lblThird
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblThird = value
			End Set
		End Property

		Friend Overridable Property lblOutgoingEmail As Label
			Get
				Return Me._lblOutgoingEmail
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblOutgoingEmail = value
			End Set
		End Property

		Friend Overridable Property txtThird As TextBox
			Get
				Return Me._txtThird
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtThird = value
			End Set
		End Property

		Friend Overridable Property txtSecond As TextBox
			Get
				Return Me._txtSecond
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtSecond = value
			End Set
		End Property

		Friend Overridable Property txtFirst As TextBox
			Get
				Return Me._txtFirst
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtFirst = value
			End Set
		End Property

		Friend Overridable Property txtSMTP As TextBox
			Get
				Return Me._txtSMTP
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtSMTP_TextChanged
				If Me._txtSMTP IsNot Nothing Then
					RemoveHandler Me._txtSMTP.TextChanged, value2
				End If
				Me._txtSMTP = value
				If Me._txtSMTP IsNot Nothing Then
					AddHandler Me._txtSMTP.TextChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property btnSend As Button
			Get
				Return Me._btnSend
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button1_Click
				If Me._btnSend IsNot Nothing Then
					RemoveHandler Me._btnSend.Click, value2
				End If
				Me._btnSend = value
				If Me._btnSend IsNot Nothing Then
					AddHandler Me._btnSend.Click, value2
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

		Friend Overridable Property rtbMessage As RichTextBox
			Get
				Return Me._rtbMessage
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RichTextBox)
				Me._rtbMessage = value
			End Set
		End Property

		Friend Overridable Property lblMessage As Label
			Get
				Return Me._lblMessage
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblMessage = value
			End Set
		End Property

		Friend Overridable Property txtSubject As TextBox
			Get
				Return Me._txtSubject
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtSubject = value
			End Set
		End Property

		Friend Overridable Property lblSubject As Label
			Get
				Return Me._lblSubject
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblSubject = value
			End Set
		End Property

		Friend Overridable Property txtPassword As TextBox
			Get
				Return Me._txtPassword
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtPassword_TextChanged
				If Me._txtPassword IsNot Nothing Then
					RemoveHandler Me._txtPassword.TextChanged, value2
				End If
				Me._txtPassword = value
				If Me._txtPassword IsNot Nothing Then
					AddHandler Me._txtPassword.TextChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property lblPassword As Label
			Get
				Return Me._lblPassword
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblPassword = value
			End Set
		End Property

		Friend Overridable Property txtUserName As TextBox
			Get
				Return Me._txtUserName
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtUserName_TextChanged
				If Me._txtUserName IsNot Nothing Then
					RemoveHandler Me._txtUserName.TextChanged, value2
				End If
				Me._txtUserName = value
				If Me._txtUserName IsNot Nothing Then
					AddHandler Me._txtUserName.TextChanged, value2
				End If
			End Set
		End Property

		Friend Overridable Property lblUserName As Label
			Get
				Return Me._lblUserName
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblUserName = value
			End Set
		End Property

		Friend Overridable Property HelpProvider1 As HelpProvider
			Get
				Return Me._HelpProvider1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As HelpProvider)
				Me._HelpProvider1 = value
			End Set
		End Property

		Private Sub cmdBrowse_0_Click(sender As Object, e As EventArgs)
			Dim text As String = ""
			Dim sCaption As String = Me.sSelectFile
			Dim text2 As String = Me.BrowseForFolder(sCaption, text)
			If Operators.CompareString(text2, "", False) <> 0 Then
				Me.txtFirst.Text = text2
			End If
		End Sub

		Private Sub cmdBrowse_1_Click(sender As Object, e As EventArgs)
			Dim text As String = ""
			Dim sCaption As String = Me.sSelectFile
			Dim text2 As String = Me.BrowseForFolder(sCaption, text)
			If Operators.CompareString(text2, "", False) <> 0 Then
				Me.txtSecond.Text = text2
			End If
		End Sub

		Private Sub cmdBrowse_2_Click(sender As Object, e As EventArgs)
			Dim text As String = ""
			Dim sCaption As String = Me.sSelectFile
			Dim text2 As String = Me.BrowseForFolder(sCaption, text)
			If Operators.CompareString(text2, "", False) <> 0 Then
				Me.txtThird.Text = text2
				Return
			End If
		End Sub

		Public Function BrowseForFolder(sCaption As String, ByRef sInitialDir As String) As String
			Dim text As String = ""
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			Dim rstdir As String = rst.RSTDir
			Dim flag As Boolean = Me.SelectEmailAttachment(text, rstdir, RSWIN_DESC.sRODSTARFiles, text, RSWIN_DESC.sDOTFILETYPE, Me.sSelectFile)
			rst.RSTDir = rstdir
			If Not flag Then
				text = ""
			End If
			Return text
		End Function

		Private Function SelectEmailAttachment(ByRef sFileName As String, ByRef sInitialDir As String, sDescList As String, sInitFileName As String, sExtension As String, sDialogTitle As String) As Boolean
			Dim openFileDialog As OpenFileDialog = New OpenFileDialog()
			Dim result As Boolean
			Try
				Dim openFileDialog2 As OpenFileDialog = openFileDialog
				openFileDialog2.Title = sDialogTitle
				openFileDialog2.FileName = sInitFileName
				openFileDialog2.Filter = sDescList
				openFileDialog2.FilterIndex = 1
				openFileDialog2.InitialDirectory = Conversions.ToString(RSWIN.GetInitialDir(sDescList, ""))
				openFileDialog2.RestoreDirectory = False
				Dim dialogResult As DialogResult = openFileDialog2.ShowDialog()
				If dialogResult <> DialogResult.Cancel Then
					sFileName = openFileDialog2.FileName
					If Strings.Len(sExtension) > 0 And Strings.InStr(sFileName, ".PDF", CompareMethod.Binary) = 0 And Strings.InStr(sFileName, ".pdf", CompareMethod.Binary) = 0 Then
						Dim num As Short = CShort(Strings.InStrRev(sFileName, ".", -1, CompareMethod.Binary))
						If num = 0S Then
							sFileName += sExtension
						Else
							sFileName = sFileName.Substring(0, CInt((num - 1S))) + sExtension
						End If
					End If
					Dim text As String = Nothing
					Dim text2 As String = Nothing
					Dim text3 As String
					Dim text4 As String
					FILEIO.SplitPath(sFileName, text3, text4, text, text2)
					text2 = Nothing
					text = Nothing
					FILEIO.MakePath(sInitialDir, text3, text4, text2, text)
					result = True
				Else
					result = False
				End If
			Catch ex As Exception
				Dim sMsg As String = "Error in SelectOutputFile: " + ex.Message
				Dim sMsgType As String = ""
				Dim bClosing As Boolean = False
				Dim dialogResult2 As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult2)
				result = False
			End Try
			Return result
		End Function

		Private Sub Button1_Click(sender As Object, e As EventArgs)
			Dim sendMail As SendMail = New SendMail()
			Dim array As String() = New String(10) {}
			If Me.txtSMTP.Text.Length = 0 Then
				Dim text As String = Me.lblOutgoingEmail.Text.Substring(0, Me.lblOutgoingEmail.Text.Length - 1)
				MessageBox.Show(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Me.sPleaseEnterValue, RSWIN_DESC.sDblQuote), text), RSWIN_DESC.sDblQuote), ".")), Conversions.ToString(Me.sEmailUtilityError), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
				Me.txtSMTP.Focus()
				Return
			End If
			If Me.txtFrom.Text.Length = 0 Then
				Dim text As String = Me.lblFrom.Text.Substring(0, Me.lblFrom.Text.Length - 1)
				MessageBox.Show(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Me.sPleaseEnterValue, RSWIN_DESC.sDblQuote), text), RSWIN_DESC.sDblQuote), ".")), Conversions.ToString(Me.sEmailUtilityError), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
				Me.txtFrom.Focus()
				Return
			End If
			If Me.txtSubject.Text.Length = 0 Then
				Dim text As String = Me.lblSubject.Text.Substring(0, Me.lblSubject.Text.Length - 1)
				MessageBox.Show(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Me.sPleaseEnterValue, RSWIN_DESC.sDblQuote), text), RSWIN_DESC.sDblQuote), ".")), Conversions.ToString(Me.sEmailUtilityError), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
				Me.txtSubject.Focus()
				Return
			End If
			If Me.rtbMessage.Text.Length = 0 Then
				Dim text As String = Me.lblMessage.Text.Substring(0, Me.lblMessage.Text.Length - 1)
				MessageBox.Show(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Me.sPleaseEnterValue, RSWIN_DESC.sDblQuote), text), RSWIN_DESC.sDblQuote), ".")), Conversions.ToString(Me.sEmailUtilityError), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
				Me.rtbMessage.Focus()
				Return
			End If
			If Me.txtUserName.Text.Length = 0 Then
				Dim text As String = Me.lblUserName.Text.Substring(0, Me.lblUserName.Text.Length - 1)
				MessageBox.Show(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Me.sPleaseEnterValue, RSWIN_DESC.sDblQuote), text), RSWIN_DESC.sDblQuote), ".")), Conversions.ToString(Me.sEmailUtilityError), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
				Me.txtUserName.Focus()
				Return
			End If
			If Me.txtPassword.Text.Length = 0 Then
				Dim text As String = Me.lblPassword.Text.Substring(0, Me.lblPassword.Text.Length - 1)
				MessageBox.Show(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Me.sPleaseEnterValue, RSWIN_DESC.sDblQuote), text), RSWIN_DESC.sDblQuote), ".")), Conversions.ToString(Me.sEmailUtilityError), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
				Me.txtPassword.Focus()
				Return
			End If
			array(0) = Me.txtSMTP.Text
			array(1) = Me.sSupport
			array(2) = Me.txtFrom.Text
			array(3) = Me.txtSubject.Text
			array(4) = Me.rtbMessage.Text.ToString()
			Dim text2 As String = "Email_From"
			Dim textBox As TextBox = Me.txtFrom
			Dim text3 As String = textBox.Text
			RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text3, RSWIN_DESC.sINIFile)
			textBox.Text = text3
			text3 = "Email_SMTP"
			textBox = Me.txtSMTP
			text2 = textBox.Text
			RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text3, text2, RSWIN_DESC.sINIFile)
			textBox.Text = text2
			text3 = "Email_UN"
			textBox = Me.txtUserName
			text2 = textBox.Text
			RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text3, text2, RSWIN_DESC.sINIFile)
			textBox.Text = text2
			text3 = "Email_PW"
			textBox = Me.txtPassword
			text2 = textBox.Text
			RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text3, text2, RSWIN_DESC.sINIFile)
			textBox.Text = text2
			array(5) = ""
			If Me.txtFirst.Text.Length > 0 Then
				array(5) = Me.txtFirst.Text
			End If
			If Me.txtSecond.Text.Length > 0 Then
				array(5) = array(5) + "," + Me.txtSecond.Text
			End If
			If Me.txtThird.Text.Length > 0 Then
				array(5) = array(5) + "," + Me.txtThird.Text
			End If
			If Me.txtUserName.Text.Length > 0 Then
				array(8) = Me.txtUserName.Text
			Else
				array(8) = ""
			End If
			If Me.txtPassword.Text.Length > 0 Then
				array(9) = Me.txtPassword.Text
			Else
				array(9) = ""
			End If
			sendMail.Send(array)
			Me.Close()
		End Sub

		Private Sub btnCancel_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		Private Sub frmSendEmail_Load(sender As Object, e As EventArgs)
			Dim text As String = ""
			Me.HelpProvider1.HelpNamespace = RSWIN_DESC.HelpNameSpace
			Try
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
				If RSWIN_DESC.bRodStarD Then
					Me.Text = "RODSTAR-D Email Utility"
				ElseIf RSWIN_DESC.bExpert Then
					Me.Text = "XROD-V Email Utility"
				Else
					Me.Text = "RODSTAR-V Email Utility"
				End If
			Catch ex As Exception
			End Try
			Try
				Dim text2 As String = "Email_From"
				Dim text3 As String = "-1"
				Dim regProfileString As Integer = RSWIN.GetRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text3, text, False)
				Me.txtFrom.Text = text.Substring(0, regProfileString)
				If Operators.CompareString(Me.txtFrom.Text, "-1", False) = 0 Then
					Me.txtFrom.Text = ""
				End If
			Catch ex2 As Exception
			End Try
			Try
				Dim text3 As String = "Email_UN"
				Dim text2 As String = "-1"
				Dim regProfileString As Integer = RSWIN.GetRegProfileString(RSWIN_DESC.SECT_RSWIN, text3, text2, text, False)
				Me.txtUserName.Text = text.Substring(0, regProfileString)
				If Operators.CompareString(Me.txtUserName.Text, "-1", False) = 0 Then
					Me.txtUserName.Text = ""
				End If
			Catch ex3 As Exception
			End Try
			Try
				Dim text3 As String = "Email_PW"
				Dim text2 As String = "-1"
				Dim regProfileString As Integer = RSWIN.GetRegProfileString(RSWIN_DESC.SECT_RSWIN, text3, text2, text, False)
				Me.txtPassword.Text = text.Substring(0, regProfileString)
				If Operators.CompareString(Me.txtPassword.Text, "-1", False) = 0 Then
					Me.txtPassword.Text = ""
				End If
			Catch ex4 As Exception
			End Try
			Me.txtSubject.Text = ""
			Me.rtbMessage.Text = ""
			Try
				Dim text3 As String = "Email_SMTP"
				Dim text2 As String = "-1"
				Dim regProfileString As Integer = RSWIN.GetRegProfileString(RSWIN_DESC.SECT_RSWIN, text3, text2, text, False)
				Me.txtSMTP.Text = text.Substring(0, regProfileString)
				If Operators.CompareString(Me.txtSMTP.Text, "-1", False) = 0 Then
					Me.txtSMTP.Text = ""
				End If
			Catch ex5 As Exception
			End Try
			If RSWIN_DESC.rst.Inputfile.Length > 0 And Operators.CompareString(RSWIN_DESC.rst.Inputfile.Trim(), "(Untitled)", False) <> 0 Then
				Me.txtFirst.Text = RSWIN_DESC.rst.Inputfile
				If Not RSWIN_DESC.rst.gbOutputLoaded Then
					Me.sNoOutput = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Me.sNoOutput, Nothing, "Replace", New Object() { "file1", RSWIN_DESC.rst.Inputfile.Trim() }, Nothing, Nothing, Nothing))
					Dim msg As String = Conversions.ToString(Me.sNoOutput)
					Dim bDefaultYes As Boolean = True
					Dim flag As Boolean = False
					If Not Util.YesNo(msg, bDefaultYes, flag) Then
						Me.btnCancel.PerformClick()
						Return
					End If
				End If
			End If
			If RSWIN_DESC.bWriteResXFile Then
				Util.OpenResourceWriter(Me.Name)
				Util.WriteControlStrings(Me, Nothing)
				Util.CloseResourceWriter()
				Return
			End If
		End Sub

		Private Sub grpSendEmail_Enter(sender As Object, e As EventArgs)
		End Sub

		Private Sub txtSMTP_TextChanged(sender As Object, e As EventArgs)
			If Me.txtSMTP Is Me.ActiveControl Then
				If Operators.CompareString(Me.txtSMTP.Text, "", False) <> 0 Then
					Dim text As String = "Email_SMTP"
					Dim txtSMTP As TextBox = Me.txtSMTP
					Dim text2 As String = txtSMTP.Text
					RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text, text2, RSWIN_DESC.sINIFile)
					txtSMTP.Text = text2
				End If
				Return
			End If
		End Sub

		Private Sub txtFrom_TextChanged(sender As Object, e As EventArgs)
			If Me.txtFrom Is Me.ActiveControl Then
				If Operators.CompareString(Me.txtFrom.Text, "", False) <> 0 Then
					Dim text As String = "Email_From"
					Dim txtFrom As TextBox = Me.txtFrom
					Dim text2 As String = txtFrom.Text
					RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text, text2, RSWIN_DESC.sINIFile)
					txtFrom.Text = text2
				End If
				Return
			End If
		End Sub

		Private Sub txtUserName_TextChanged(sender As Object, e As EventArgs)
			If Me.txtUserName Is Me.ActiveControl Then
				If Operators.CompareString(Me.txtUserName.Text, "", False) <> 0 Then
					Dim text As String = "Email_UN"
					Dim txtUserName As TextBox = Me.txtUserName
					Dim text2 As String = txtUserName.Text
					RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text, text2, RSWIN_DESC.sINIFile)
					txtUserName.Text = text2
				End If
				Return
			End If
		End Sub

		Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs)
			If Me.txtPassword Is Me.ActiveControl Then
				If Operators.CompareString(Me.txtPassword.Text, "", False) <> 0 Then
					Dim text As String = "Email_PW"
					Dim txtPassword As TextBox = Me.txtPassword
					Dim text2 As String = txtPassword.Text
					RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text, text2, RSWIN_DESC.sINIFile)
					txtPassword.Text = text2
				End If
				Return
			End If
		End Sub

		<AccessedThroughProperty("grpSendEmail")>
		Private _grpSendEmail As GroupBox

		<AccessedThroughProperty("cmdBrowse_2")>
		Private _cmdBrowse_2 As Button

		<AccessedThroughProperty("cmdBrowse_1")>
		Private _cmdBrowse_1 As Button

		<AccessedThroughProperty("cmdBrowse_0")>
		Private _cmdBrowse_0 As Button

		<AccessedThroughProperty("lblFrom")>
		Private _lblFrom As Label

		<AccessedThroughProperty("lblTO")>
		Private _lblTO As Label

		<AccessedThroughProperty("lblFirst")>
		Private _lblFirst As Label

		<AccessedThroughProperty("txtFrom")>
		Private _txtFrom As TextBox

		<AccessedThroughProperty("lblSecond")>
		Private _lblSecond As Label

		<AccessedThroughProperty("lblThird")>
		Private _lblThird As Label

		<AccessedThroughProperty("lblOutgoingEmail")>
		Private _lblOutgoingEmail As Label

		<AccessedThroughProperty("txtThird")>
		Private _txtThird As TextBox

		<AccessedThroughProperty("txtSecond")>
		Private _txtSecond As TextBox

		<AccessedThroughProperty("txtFirst")>
		Private _txtFirst As TextBox

		<AccessedThroughProperty("txtSMTP")>
		Private _txtSMTP As TextBox

		<AccessedThroughProperty("btnSend")>
		Private _btnSend As Button

		<AccessedThroughProperty("btnCancel")>
		Private _btnCancel As Button

		<AccessedThroughProperty("rtbMessage")>
		Private _rtbMessage As RichTextBox

		<AccessedThroughProperty("lblMessage")>
		Private _lblMessage As Label

		<AccessedThroughProperty("txtSubject")>
		Private _txtSubject As TextBox

		<AccessedThroughProperty("lblSubject")>
		Private _lblSubject As Label

		<AccessedThroughProperty("txtPassword")>
		Private _txtPassword As TextBox

		<AccessedThroughProperty("lblPassword")>
		Private _lblPassword As Label

		<AccessedThroughProperty("txtUserName")>
		Private _txtUserName As TextBox

		<AccessedThroughProperty("lblUserName")>
		Private _lblUserName As Label

		<AccessedThroughProperty("HelpProvider1")>
		Private _HelpProvider1 As HelpProvider

		Private sSelectFile As String

		Private sPleaseEnterValue As Object

		Private sEmailUtilityError As Object

		Private sNoOutput As Object

		Private sSupport As String
	End Class
End Namespace
