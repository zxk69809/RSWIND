Namespace RSWINV3
	Public Partial Class frmSendEmail
		Inherits Global.System.Windows.Forms.Form

		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.RSWINV3.frmSendEmail))
			Me.grpSendEmail = New Global.System.Windows.Forms.GroupBox()
			Me.txtPassword = New Global.System.Windows.Forms.TextBox()
			Me.lblPassword = New Global.System.Windows.Forms.Label()
			Me.txtUserName = New Global.System.Windows.Forms.TextBox()
			Me.lblUserName = New Global.System.Windows.Forms.Label()
			Me.txtSubject = New Global.System.Windows.Forms.TextBox()
			Me.lblSubject = New Global.System.Windows.Forms.Label()
			Me.lblMessage = New Global.System.Windows.Forms.Label()
			Me.rtbMessage = New Global.System.Windows.Forms.RichTextBox()
			Me.btnCancel = New Global.System.Windows.Forms.Button()
			Me.btnSend = New Global.System.Windows.Forms.Button()
			Me.txtSMTP = New Global.System.Windows.Forms.TextBox()
			Me.lblOutgoingEmail = New Global.System.Windows.Forms.Label()
			Me.lblThird = New Global.System.Windows.Forms.Label()
			Me.lblSecond = New Global.System.Windows.Forms.Label()
			Me.lblTO = New Global.System.Windows.Forms.Label()
			Me.txtFrom = New Global.System.Windows.Forms.TextBox()
			Me.txtThird = New Global.System.Windows.Forms.TextBox()
			Me.txtSecond = New Global.System.Windows.Forms.TextBox()
			Me.txtFirst = New Global.System.Windows.Forms.TextBox()
			Me.cmdBrowse_2 = New Global.System.Windows.Forms.Button()
			Me.cmdBrowse_1 = New Global.System.Windows.Forms.Button()
			Me.cmdBrowse_0 = New Global.System.Windows.Forms.Button()
			Me.lblFirst = New Global.System.Windows.Forms.Label()
			Me.lblFrom = New Global.System.Windows.Forms.Label()
			Me.HelpProvider1 = New Global.System.Windows.Forms.HelpProvider()
			Me.grpSendEmail.SuspendLayout()
			Me.SuspendLayout()
			Me.grpSendEmail.Controls.Add(Me.txtPassword)
			Me.grpSendEmail.Controls.Add(Me.lblPassword)
			Me.grpSendEmail.Controls.Add(Me.txtUserName)
			Me.grpSendEmail.Controls.Add(Me.lblUserName)
			Me.grpSendEmail.Controls.Add(Me.txtSubject)
			Me.grpSendEmail.Controls.Add(Me.lblSubject)
			Me.grpSendEmail.Controls.Add(Me.lblMessage)
			Me.grpSendEmail.Controls.Add(Me.rtbMessage)
			Me.grpSendEmail.Controls.Add(Me.btnCancel)
			Me.grpSendEmail.Controls.Add(Me.btnSend)
			Me.grpSendEmail.Controls.Add(Me.txtSMTP)
			Me.grpSendEmail.Controls.Add(Me.lblOutgoingEmail)
			Me.grpSendEmail.Controls.Add(Me.lblThird)
			Me.grpSendEmail.Controls.Add(Me.lblSecond)
			Me.grpSendEmail.Controls.Add(Me.lblTO)
			Me.grpSendEmail.Controls.Add(Me.txtFrom)
			Me.grpSendEmail.Controls.Add(Me.txtThird)
			Me.grpSendEmail.Controls.Add(Me.txtSecond)
			Me.grpSendEmail.Controls.Add(Me.txtFirst)
			Me.grpSendEmail.Controls.Add(Me.cmdBrowse_2)
			Me.grpSendEmail.Controls.Add(Me.cmdBrowse_1)
			Me.grpSendEmail.Controls.Add(Me.cmdBrowse_0)
			Me.grpSendEmail.Controls.Add(Me.lblFirst)
			Me.grpSendEmail.Controls.Add(Me.lblFrom)
			Dim grpSendEmail As Global.System.Windows.Forms.Control = Me.grpSendEmail
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(8, 8)
			grpSendEmail.Location = location
			Me.grpSendEmail.Name = "grpSendEmail"
			Me.HelpProvider1.SetShowHelp(Me.grpSendEmail, False)
			Dim grpSendEmail2 As Global.System.Windows.Forms.Control = Me.grpSendEmail
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(736, 360)
			grpSendEmail2.Size = size
			Me.grpSendEmail.TabIndex = 2
			Me.grpSendEmail.TabStop = False
			Me.HelpProvider1.SetHelpKeyword(Me.txtPassword, "RODSTAR-D Email Utility: Outgoing Email Server (SMTP)")
			Me.HelpProvider1.SetHelpNavigator(Me.txtPassword, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.HelpProvider1.SetHelpString(Me.txtPassword, "")
			Dim txtPassword As Global.System.Windows.Forms.Control = Me.txtPassword
			location = New Global.System.Drawing.Point(297, 282)
			txtPassword.Location = location
			Me.txtPassword.Name = "txtPassword"
			Me.HelpProvider1.SetShowHelp(Me.txtPassword, True)
			Dim txtPassword2 As Global.System.Windows.Forms.Control = Me.txtPassword
			size = New Global.System.Drawing.Size(272, 20)
			txtPassword2.Size = size
			Me.txtPassword.TabIndex = 10
			Me.lblPassword.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblPassword As Global.System.Windows.Forms.Control = Me.lblPassword
			location = New Global.System.Drawing.Point(17, 282)
			lblPassword.Location = location
			Me.lblPassword.Name = "lblPassword"
			Me.HelpProvider1.SetShowHelp(Me.lblPassword, False)
			Dim lblPassword2 As Global.System.Windows.Forms.Control = Me.lblPassword
			size = New Global.System.Drawing.Size(272, 24)
			lblPassword2.Size = size
			Me.lblPassword.TabIndex = 26
			Me.lblPassword.Text = "Password:"
			Me.HelpProvider1.SetHelpKeyword(Me.txtUserName, "RODSTAR-D Email Utility: Outgoing Email Server (SMTP)")
			Me.HelpProvider1.SetHelpNavigator(Me.txtUserName, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.HelpProvider1.SetHelpString(Me.txtUserName, "")
			Dim txtUserName As Global.System.Windows.Forms.Control = Me.txtUserName
			location = New Global.System.Drawing.Point(296, 256)
			txtUserName.Location = location
			Me.txtUserName.Name = "txtUserName"
			Me.HelpProvider1.SetShowHelp(Me.txtUserName, True)
			Dim txtUserName2 As Global.System.Windows.Forms.Control = Me.txtUserName
			size = New Global.System.Drawing.Size(272, 20)
			txtUserName2.Size = size
			Me.txtUserName.TabIndex = 9
			Me.lblUserName.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblUserName As Global.System.Windows.Forms.Control = Me.lblUserName
			location = New Global.System.Drawing.Point(16, 256)
			lblUserName.Location = location
			Me.lblUserName.Name = "lblUserName"
			Me.HelpProvider1.SetShowHelp(Me.lblUserName, False)
			Dim lblUserName2 As Global.System.Windows.Forms.Control = Me.lblUserName
			size = New Global.System.Drawing.Size(272, 24)
			lblUserName2.Size = size
			Me.lblUserName.TabIndex = 24
			Me.lblUserName.Text = "Username:"
			Me.HelpProvider1.SetHelpKeyword(Me.txtSubject, "RODSTAR-D Email Utility: Subject")
			Me.HelpProvider1.SetHelpNavigator(Me.txtSubject, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.HelpProvider1.SetHelpString(Me.txtSubject, "")
			Dim txtSubject As Global.System.Windows.Forms.Control = Me.txtSubject
			location = New Global.System.Drawing.Point(296, 64)
			txtSubject.Location = location
			Me.txtSubject.Name = "txtSubject"
			Me.HelpProvider1.SetShowHelp(Me.txtSubject, True)
			Dim txtSubject2 As Global.System.Windows.Forms.Control = Me.txtSubject
			size = New Global.System.Drawing.Size(272, 20)
			txtSubject2.Size = size
			Me.txtSubject.TabIndex = 3
			Me.lblSubject.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblSubject As Global.System.Windows.Forms.Control = Me.lblSubject
			location = New Global.System.Drawing.Point(16, 64)
			lblSubject.Location = location
			Me.lblSubject.Name = "lblSubject"
			Me.HelpProvider1.SetShowHelp(Me.lblSubject, False)
			Dim lblSubject2 As Global.System.Windows.Forms.Control = Me.lblSubject
			size = New Global.System.Drawing.Size(272, 24)
			lblSubject2.Size = size
			Me.lblSubject.TabIndex = 22
			Me.lblSubject.Text = "Email Subject :"
			Me.lblMessage.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblMessage As Global.System.Windows.Forms.Control = Me.lblMessage
			location = New Global.System.Drawing.Point(16, 88)
			lblMessage.Location = location
			Me.lblMessage.Name = "lblMessage"
			Me.HelpProvider1.SetShowHelp(Me.lblMessage, False)
			Dim lblMessage2 As Global.System.Windows.Forms.Control = Me.lblMessage
			size = New Global.System.Drawing.Size(272, 16)
			lblMessage2.Size = size
			Me.lblMessage.TabIndex = 20
			Me.lblMessage.Text = "Email Message Body:"
			Me.HelpProvider1.SetHelpKeyword(Me.rtbMessage, "RODSTAR-D Email Utility: Message Body")
			Me.HelpProvider1.SetHelpNavigator(Me.rtbMessage, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.HelpProvider1.SetHelpString(Me.rtbMessage, "")
			Dim rtbMessage As Global.System.Windows.Forms.Control = Me.rtbMessage
			location = New Global.System.Drawing.Point(296, 88)
			rtbMessage.Location = location
			Me.rtbMessage.Name = "rtbMessage"
			Me.HelpProvider1.SetShowHelp(Me.rtbMessage, True)
			Dim rtbMessage2 As Global.System.Windows.Forms.Control = Me.rtbMessage
			size = New Global.System.Drawing.Size(272, 48)
			rtbMessage2.Size = size
			Me.rtbMessage.TabIndex = 4
			Me.rtbMessage.Text = ""
			Me.btnCancel.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim btnCancel As Global.System.Windows.Forms.Control = Me.btnCancel
			location = New Global.System.Drawing.Point(296, 322)
			btnCancel.Location = location
			Me.btnCancel.Name = "btnCancel"
			Me.HelpProvider1.SetShowHelp(Me.btnCancel, False)
			Dim btnCancel2 As Global.System.Windows.Forms.Control = Me.btnCancel
			size = New Global.System.Drawing.Size(88, 24)
			btnCancel2.Size = size
			Me.btnCancel.TabIndex = 18
			Me.btnCancel.Text = "&Cancel"
			Me.btnSend.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim btnSend As Global.System.Windows.Forms.Control = Me.btnSend
			location = New Global.System.Drawing.Point(472, 322)
			btnSend.Location = location
			Me.btnSend.Name = "btnSend"
			Me.HelpProvider1.SetShowHelp(Me.btnSend, False)
			Dim btnSend2 As Global.System.Windows.Forms.Control = Me.btnSend
			size = New Global.System.Drawing.Size(88, 24)
			btnSend2.Size = size
			Me.btnSend.TabIndex = 17
			Me.btnSend.Text = "&Send"
			Me.HelpProvider1.SetHelpKeyword(Me.txtSMTP, "RODSTAR-D Email Utility: Outgoing Email Server (SMTP)")
			Me.HelpProvider1.SetHelpNavigator(Me.txtSMTP, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.HelpProvider1.SetHelpString(Me.txtSMTP, "")
			Dim txtSMTP As Global.System.Windows.Forms.Control = Me.txtSMTP
			location = New Global.System.Drawing.Point(296, 232)
			txtSMTP.Location = location
			Me.txtSMTP.Name = "txtSMTP"
			Me.HelpProvider1.SetShowHelp(Me.txtSMTP, True)
			Dim txtSMTP2 As Global.System.Windows.Forms.Control = Me.txtSMTP
			size = New Global.System.Drawing.Size(272, 20)
			txtSMTP2.Size = size
			Me.txtSMTP.TabIndex = 8
			Me.lblOutgoingEmail.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblOutgoingEmail As Global.System.Windows.Forms.Control = Me.lblOutgoingEmail
			location = New Global.System.Drawing.Point(16, 232)
			lblOutgoingEmail.Location = location
			Me.lblOutgoingEmail.Name = "lblOutgoingEmail"
			Me.HelpProvider1.SetShowHelp(Me.lblOutgoingEmail, False)
			Dim lblOutgoingEmail2 As Global.System.Windows.Forms.Control = Me.lblOutgoingEmail
			size = New Global.System.Drawing.Size(272, 24)
			lblOutgoingEmail2.Size = size
			Me.lblOutgoingEmail.TabIndex = 15
			Me.lblOutgoingEmail.Text = "Outgoing email server (SMTP) :"
			Me.lblThird.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblThird As Global.System.Windows.Forms.Control = Me.lblThird
			location = New Global.System.Drawing.Point(16, 192)
			lblThird.Location = location
			Me.lblThird.Name = "lblThird"
			Me.HelpProvider1.SetShowHelp(Me.lblThird, False)
			Dim lblThird2 As Global.System.Windows.Forms.Control = Me.lblThird
			size = New Global.System.Drawing.Size(272, 16)
			lblThird2.Size = size
			Me.lblThird.TabIndex = 14
			Me.lblThird.Text = "Third File attachment  :"
			Me.lblSecond.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblSecond As Global.System.Windows.Forms.Control = Me.lblSecond
			location = New Global.System.Drawing.Point(16, 168)
			lblSecond.Location = location
			Me.lblSecond.Name = "lblSecond"
			Me.HelpProvider1.SetShowHelp(Me.lblSecond, False)
			Dim lblSecond2 As Global.System.Windows.Forms.Control = Me.lblSecond
			size = New Global.System.Drawing.Size(272, 16)
			lblSecond2.Size = size
			Me.lblSecond.TabIndex = 13
			Me.lblSecond.Text = "Second File attachment :"
			Me.lblTO.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblTO As Global.System.Windows.Forms.Control = Me.lblTO
			location = New Global.System.Drawing.Point(16, 40)
			lblTO.Location = location
			Me.lblTO.Name = "lblTO"
			Me.HelpProvider1.SetShowHelp(Me.lblTO, False)
			Dim lblTO2 As Global.System.Windows.Forms.Control = Me.lblTO
			size = New Global.System.Drawing.Size(272, 24)
			lblTO2.Size = size
			Me.lblTO.TabIndex = 11
			Me.lblTO.Text = "To:  Theta Oilfield Services Technical Support"
			Me.HelpProvider1.SetHelpKeyword(Me.txtFrom, "RODSTAR-D Email Utility: From (email address of sender)")
			Me.HelpProvider1.SetHelpNavigator(Me.txtFrom, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.HelpProvider1.SetHelpString(Me.txtFrom, "")
			Dim txtFrom As Global.System.Windows.Forms.Control = Me.txtFrom
			location = New Global.System.Drawing.Point(296, 16)
			txtFrom.Location = location
			Me.txtFrom.Name = "txtFrom"
			Me.HelpProvider1.SetShowHelp(Me.txtFrom, True)
			Dim txtFrom2 As Global.System.Windows.Forms.Control = Me.txtFrom
			size = New Global.System.Drawing.Size(272, 20)
			txtFrom2.Size = size
			Me.txtFrom.TabIndex = 1
			Me.HelpProvider1.SetHelpKeyword(Me.txtThird, "RODSTAR-D Email Utility: File Attachment")
			Me.HelpProvider1.SetHelpNavigator(Me.txtThird, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.HelpProvider1.SetHelpString(Me.txtThird, "")
			Dim txtThird As Global.System.Windows.Forms.Control = Me.txtThird
			location = New Global.System.Drawing.Point(296, 192)
			txtThird.Location = location
			Me.txtThird.Name = "txtThird"
			Me.HelpProvider1.SetShowHelp(Me.txtThird, True)
			Dim txtThird2 As Global.System.Windows.Forms.Control = Me.txtThird
			size = New Global.System.Drawing.Size(272, 20)
			txtThird2.Size = size
			Me.txtThird.TabIndex = 7
			Me.HelpProvider1.SetHelpKeyword(Me.txtSecond, "RODSTAR-D Email Utility: File Attachment")
			Me.HelpProvider1.SetHelpNavigator(Me.txtSecond, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.HelpProvider1.SetHelpString(Me.txtSecond, "")
			Dim txtSecond As Global.System.Windows.Forms.Control = Me.txtSecond
			location = New Global.System.Drawing.Point(296, 168)
			txtSecond.Location = location
			Me.txtSecond.Name = "txtSecond"
			Me.HelpProvider1.SetShowHelp(Me.txtSecond, True)
			Dim txtSecond2 As Global.System.Windows.Forms.Control = Me.txtSecond
			size = New Global.System.Drawing.Size(272, 20)
			txtSecond2.Size = size
			Me.txtSecond.TabIndex = 6
			Me.HelpProvider1.SetHelpKeyword(Me.txtFirst, "RODSTAR-D Email Utility: File Attachment")
			Me.HelpProvider1.SetHelpNavigator(Me.txtFirst, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.HelpProvider1.SetHelpString(Me.txtFirst, "")
			Dim txtFirst As Global.System.Windows.Forms.Control = Me.txtFirst
			location = New Global.System.Drawing.Point(296, 144)
			txtFirst.Location = location
			Me.txtFirst.Name = "txtFirst"
			Me.HelpProvider1.SetShowHelp(Me.txtFirst, True)
			Dim txtFirst2 As Global.System.Windows.Forms.Control = Me.txtFirst
			size = New Global.System.Drawing.Size(272, 20)
			txtFirst2.Size = size
			Me.txtFirst.TabIndex = 5
			Me.cmdBrowse_2.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdBrowse_ As Global.System.Windows.Forms.Control = Me.cmdBrowse_2
			location = New Global.System.Drawing.Point(576, 192)
			cmdBrowse_.Location = location
			Me.cmdBrowse_2.Name = "cmdBrowse_2"
			Me.HelpProvider1.SetShowHelp(Me.cmdBrowse_2, False)
			Dim cmdBrowse_2 As Global.System.Windows.Forms.Control = Me.cmdBrowse_2
			size = New Global.System.Drawing.Size(80, 22)
			cmdBrowse_2.Size = size
			Me.cmdBrowse_2.TabIndex = 6
			Me.cmdBrowse_2.Text = "Browse.."
			Me.cmdBrowse_1.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdBrowse_3 As Global.System.Windows.Forms.Control = Me.cmdBrowse_1
			location = New Global.System.Drawing.Point(576, 168)
			cmdBrowse_3.Location = location
			Me.cmdBrowse_1.Name = "cmdBrowse_1"
			Me.HelpProvider1.SetShowHelp(Me.cmdBrowse_1, False)
			Dim cmdBrowse_4 As Global.System.Windows.Forms.Control = Me.cmdBrowse_1
			size = New Global.System.Drawing.Size(80, 22)
			cmdBrowse_4.Size = size
			Me.cmdBrowse_1.TabIndex = 5
			Me.cmdBrowse_1.Text = "Browse.."
			Me.cmdBrowse_0.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdBrowse_5 As Global.System.Windows.Forms.Control = Me.cmdBrowse_0
			location = New Global.System.Drawing.Point(576, 144)
			cmdBrowse_5.Location = location
			Me.cmdBrowse_0.Name = "cmdBrowse_0"
			Me.HelpProvider1.SetShowHelp(Me.cmdBrowse_0, False)
			Dim cmdBrowse_6 As Global.System.Windows.Forms.Control = Me.cmdBrowse_0
			size = New Global.System.Drawing.Size(80, 22)
			cmdBrowse_6.Size = size
			Me.cmdBrowse_0.TabIndex = 4
			Me.cmdBrowse_0.Text = "Browse.."
			Me.lblFirst.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblFirst As Global.System.Windows.Forms.Control = Me.lblFirst
			location = New Global.System.Drawing.Point(16, 144)
			lblFirst.Location = location
			Me.lblFirst.Name = "lblFirst"
			Me.HelpProvider1.SetShowHelp(Me.lblFirst, False)
			Dim lblFirst2 As Global.System.Windows.Forms.Control = Me.lblFirst
			size = New Global.System.Drawing.Size(272, 16)
			lblFirst2.Size = size
			Me.lblFirst.TabIndex = 1
			Me.lblFirst.Text = "First File attachment :"
			Me.lblFrom.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblFrom As Global.System.Windows.Forms.Control = Me.lblFrom
			location = New Global.System.Drawing.Point(16, 16)
			lblFrom.Location = location
			Me.lblFrom.Name = "lblFrom"
			Me.HelpProvider1.SetShowHelp(Me.lblFrom, False)
			Dim lblFrom2 As Global.System.Windows.Forms.Control = Me.lblFrom
			size = New Global.System.Drawing.Size(272, 16)
			lblFrom2.Size = size
			Me.lblFrom.TabIndex = 0
			Me.lblFrom.Text = "From (email address of sender) :"
			size = New Global.System.Drawing.Size(5, 13)
			Me.AutoScaleBaseSize = size
			size = New Global.System.Drawing.Size(807, 371)
			Me.ClientSize = size
			Me.ControlBox = False
			Me.Controls.Add(Me.grpSendEmail)
			Me.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			Me.Name = "frmSendEmail"
			Me.HelpProvider1.SetShowHelp(Me, False)
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "RODSTAR-D Email Utility "
			Me.grpSendEmail.ResumeLayout(False)
			Me.grpSendEmail.PerformLayout()
			Me.ResumeLayout(False)
		End Sub

		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
