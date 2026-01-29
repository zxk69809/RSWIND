Namespace RSWINV3
	Friend Partial Class dlgCoverPageComments
		Inherits Global.System.Windows.Forms.Form

		Protected Overrides Sub Dispose(Disposing As Boolean)
			If Disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(Disposing)
		End Sub

		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Me.ToolTip1 = New Global.System.Windows.Forms.ToolTip(Me.components)
			Me._SSPanel_0 = New Global.System.Windows.Forms.Panel()
			Me.lblSetupDefaultsComment = New Global.System.Windows.Forms.Label()
			Me.rtbSetupDefault = New Global.System.Windows.Forms.RichTextBox()
			Me.txtWellInfoComment = New Global.System.Windows.Forms.RichTextBox()
			Me._Label_WellInfo_Comment = New Global.System.Windows.Forms.Label()
			Me.txtFootnote = New Global.System.Windows.Forms.TextBox()
			Me.lblFootnote = New Global.System.Windows.Forms.Label()
			Me.txtCustomerCompanyName = New Global.System.Windows.Forms.TextBox()
			Me.txtCustomerContactName = New Global.System.Windows.Forms.TextBox()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.lblCustomerCompany = New Global.System.Windows.Forms.Label()
			Me.lblComments = New Global.System.Windows.Forms.Label()
			Me.rtbComments = New Global.System.Windows.Forms.RichTextBox()
			Me.Label = New Global.Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
			Me.SSPanel = New Global.Microsoft.VisualBasic.Compatibility.VB6.PanelArray(Me.components)
			Me.cmdOK = New Global.System.Windows.Forms.Button()
			Me.cmdCancel = New Global.System.Windows.Forms.Button()
			Me.btnResetComments = New Global.System.Windows.Forms.Button()
			Me.btnAddWellInfoComment = New Global.System.Windows.Forms.Button()
			Me.btnAddRodStringInfo = New Global.System.Windows.Forms.Button()
			Me.btnAddSetupComment = New Global.System.Windows.Forms.Button()
			Me.Panel1 = New Global.System.Windows.Forms.Panel()
			Me.btnLogo = New Global.System.Windows.Forms.Button()
			Me.txtMyTelephone = New Global.System.Windows.Forms.TextBox()
			Me.lblPhone = New Global.System.Windows.Forms.Label()
			Me.txtAddress2 = New Global.System.Windows.Forms.TextBox()
			Me.lblAddress2 = New Global.System.Windows.Forms.Label()
			Me.txtAddress1 = New Global.System.Windows.Forms.TextBox()
			Me.lblAddress1 = New Global.System.Windows.Forms.Label()
			Me.txtMyCompanyWebsite = New Global.System.Windows.Forms.TextBox()
			Me.lblMyCompanyWebsite = New Global.System.Windows.Forms.Label()
			Me.txtMyCompanyName = New Global.System.Windows.Forms.TextBox()
			Me.txtMyContactName = New Global.System.Windows.Forms.TextBox()
			Me.lblMyContactName = New Global.System.Windows.Forms.Label()
			Me.lblMyCompanyName = New Global.System.Windows.Forms.Label()
			Me._Label_0 = New Global.System.Windows.Forms.Label()
			Me._SSPanel_0.SuspendLayout()
			CType(Me.Label, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.SSPanel, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.Panel1.SuspendLayout()
			Me.SuspendLayout()
			Me._SSPanel_0.BackColor = Global.System.Drawing.SystemColors.Control
			Me._SSPanel_0.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Me._SSPanel_0.Controls.Add(Me.lblSetupDefaultsComment)
			Me._SSPanel_0.Controls.Add(Me.rtbSetupDefault)
			Me._SSPanel_0.Controls.Add(Me.txtWellInfoComment)
			Me._SSPanel_0.Controls.Add(Me._Label_WellInfo_Comment)
			Me._SSPanel_0.Controls.Add(Me.txtFootnote)
			Me._SSPanel_0.Controls.Add(Me.lblFootnote)
			Me._SSPanel_0.Controls.Add(Me.txtCustomerCompanyName)
			Me._SSPanel_0.Controls.Add(Me.txtCustomerContactName)
			Me._SSPanel_0.Controls.Add(Me.Label1)
			Me._SSPanel_0.Controls.Add(Me.lblCustomerCompany)
			Me._SSPanel_0.Controls.Add(Me.lblComments)
			Me._SSPanel_0.Controls.Add(Me.rtbComments)
			Me._SSPanel_0.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._SSPanel_0.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._SSPanel_0.ForeColor = Global.System.Drawing.Color.Black
			Me.SSPanel.SetIndex(Me._SSPanel_0, 0S)
			Dim sspanel_ As Global.System.Windows.Forms.Control = Me._SSPanel_0
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(4, 164)
			sspanel_.Location = location
			Me._SSPanel_0.Name = "_SSPanel_0"
			Me._SSPanel_0.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim sspanel_2 As Global.System.Windows.Forms.Control = Me._SSPanel_0
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(784, 450)
			sspanel_2.Size = size
			Me._SSPanel_0.TabIndex = 2
			Me._SSPanel_0.TabStop = True
			Me.lblSetupDefaultsComment.BackColor = Global.System.Drawing.Color.Transparent
			Me.lblSetupDefaultsComment.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblSetupDefaultsComment.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.lblSetupDefaultsComment.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.lblSetupDefaultsComment.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim lblSetupDefaultsComment As Global.System.Windows.Forms.Control = Me.lblSetupDefaultsComment
			location = New Global.System.Drawing.Point(264, 320)
			lblSetupDefaultsComment.Location = location
			Me.lblSetupDefaultsComment.Name = "lblSetupDefaultsComment"
			Me.lblSetupDefaultsComment.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim lblSetupDefaultsComment2 As Global.System.Windows.Forms.Control = Me.lblSetupDefaultsComment
			size = New Global.System.Drawing.Size(504, 20)
			lblSetupDefaultsComment2.Size = size
			Me.lblSetupDefaultsComment.TabIndex = 179
			Me.lblSetupDefaultsComment.Text = "Setup / Defaults Comment:"
			Me.lblSetupDefaultsComment.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.rtbSetupDefault.Font = New Global.System.Drawing.Font("Arial", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim rtbSetupDefault As Global.System.Windows.Forms.Control = Me.rtbSetupDefault
			location = New Global.System.Drawing.Point(264, 344)
			rtbSetupDefault.Location = location
			Me.rtbSetupDefault.Name = "rtbSetupDefault"
			Dim rtbSetupDefault2 As Global.System.Windows.Forms.Control = Me.rtbSetupDefault
			size = New Global.System.Drawing.Size(512, 72)
			rtbSetupDefault2.Size = size
			Me.rtbSetupDefault.TabIndex = 178
			Me.rtbSetupDefault.Text = ""
			Me.txtWellInfoComment.Font = New Global.System.Drawing.Font("Arial", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim txtWellInfoComment As Global.System.Windows.Forms.Control = Me.txtWellInfoComment
			location = New Global.System.Drawing.Point(8, 344)
			txtWellInfoComment.Location = location
			Me.txtWellInfoComment.Name = "txtWellInfoComment"
			Dim txtWellInfoComment2 As Global.System.Windows.Forms.Control = Me.txtWellInfoComment
			size = New Global.System.Drawing.Size(248, 70)
			txtWellInfoComment2.Size = size
			Me.txtWellInfoComment.TabIndex = 176
			Me.txtWellInfoComment.Text = ""
			Me._Label_WellInfo_Comment.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_WellInfo_Comment.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_WellInfo_Comment.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me._Label_WellInfo_Comment.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._Label_WellInfo_Comment.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label_WellInfo_Comment As Global.System.Windows.Forms.Control = Me._Label_WellInfo_Comment
			location = New Global.System.Drawing.Point(16, 320)
			label_WellInfo_Comment.Location = location
			Me._Label_WellInfo_Comment.Name = "_Label_WellInfo_Comment"
			Me._Label_WellInfo_Comment.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim label_WellInfo_Comment2 As Global.System.Windows.Forms.Control = Me._Label_WellInfo_Comment
			size = New Global.System.Drawing.Size(200, 20)
			label_WellInfo_Comment2.Size = size
			Me._Label_WellInfo_Comment.TabIndex = 177
			Me._Label_WellInfo_Comment.Text = "Well Information Comment:"
			Me._Label_WellInfo_Comment.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.txtFootnote.Font = New Global.System.Drawing.Font("Arial", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim txtFootnote As Global.System.Windows.Forms.Control = Me.txtFootnote
			location = New Global.System.Drawing.Point(152, 416)
			txtFootnote.Location = location
			Me.txtFootnote.Name = "txtFootnote"
			Dim txtFootnote2 As Global.System.Windows.Forms.Control = Me.txtFootnote
			size = New Global.System.Drawing.Size(624, 21)
			txtFootnote2.Size = size
			Me.txtFootnote.TabIndex = 23
			Me.lblFootnote.Font = New Global.System.Drawing.Font("Arial", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim lblFootnote As Global.System.Windows.Forms.Control = Me.lblFootnote
			location = New Global.System.Drawing.Point(16, 416)
			lblFootnote.Location = location
			Me.lblFootnote.Name = "lblFootnote"
			Dim lblFootnote2 As Global.System.Windows.Forms.Control = Me.lblFootnote
			size = New Global.System.Drawing.Size(128, 21)
			lblFootnote2.Size = size
			Me.lblFootnote.TabIndex = 22
			Me.lblFootnote.Text = "Cover Page Footnote: "
			Me.lblFootnote.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.txtCustomerCompanyName.Font = New Global.System.Drawing.Font("Arial", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim txtCustomerCompanyName As Global.System.Windows.Forms.Control = Me.txtCustomerCompanyName
			location = New Global.System.Drawing.Point(160, 8)
			txtCustomerCompanyName.Location = location
			Me.txtCustomerCompanyName.Name = "txtCustomerCompanyName"
			Dim txtCustomerCompanyName2 As Global.System.Windows.Forms.Control = Me.txtCustomerCompanyName
			size = New Global.System.Drawing.Size(232, 21)
			txtCustomerCompanyName2.Size = size
			Me.txtCustomerCompanyName.TabIndex = 20
			Me.txtCustomerContactName.Font = New Global.System.Drawing.Font("Arial", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim txtCustomerContactName As Global.System.Windows.Forms.Control = Me.txtCustomerContactName
			location = New Global.System.Drawing.Point(544, 8)
			txtCustomerContactName.Location = location
			Me.txtCustomerContactName.Name = "txtCustomerContactName"
			Dim txtCustomerContactName2 As Global.System.Windows.Forms.Control = Me.txtCustomerContactName
			size = New Global.System.Drawing.Size(232, 21)
			txtCustomerContactName2.Size = size
			Me.txtCustomerContactName.TabIndex = 21
			Me.Label1.Font = New Global.System.Drawing.Font("Arial", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim label As Global.System.Windows.Forms.Control = Me.Label1
			location = New Global.System.Drawing.Point(392, 8)
			label.Location = location
			Me.Label1.Name = "Label1"
			Dim label2 As Global.System.Windows.Forms.Control = Me.Label1
			size = New Global.System.Drawing.Size(152, 21)
			label2.Size = size
			Me.Label1.TabIndex = 19
			Me.Label1.Text = "Customer Contact Name:"
			Me.Label1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.lblCustomerCompany.Font = New Global.System.Drawing.Font("Arial", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim lblCustomerCompany As Global.System.Windows.Forms.Control = Me.lblCustomerCompany
			location = New Global.System.Drawing.Point(8, 8)
			lblCustomerCompany.Location = location
			Me.lblCustomerCompany.Name = "lblCustomerCompany"
			Dim lblCustomerCompany2 As Global.System.Windows.Forms.Control = Me.lblCustomerCompany
			size = New Global.System.Drawing.Size(176, 21)
			lblCustomerCompany2.Size = size
			Me.lblCustomerCompany.TabIndex = 18
			Me.lblCustomerCompany.Text = "Customer Company Name: "
			Me.lblCustomerCompany.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.lblComments.Font = New Global.System.Drawing.Font("Arial", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim lblComments As Global.System.Windows.Forms.Control = Me.lblComments
			location = New Global.System.Drawing.Point(8, 32)
			lblComments.Location = location
			Me.lblComments.Name = "lblComments"
			Dim lblComments2 As Global.System.Windows.Forms.Control = Me.lblComments
			size = New Global.System.Drawing.Size(160, 16)
			lblComments2.Size = size
			Me.lblComments.TabIndex = 17
			Me.lblComments.Text = "Cover Page Comments:"
			Me.rtbComments.Font = New Global.System.Drawing.Font("Arial", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim rtbComments As Global.System.Windows.Forms.Control = Me.rtbComments
			location = New Global.System.Drawing.Point(8, 48)
			rtbComments.Location = location
			Me.rtbComments.Name = "rtbComments"
			Dim rtbComments2 As Global.System.Windows.Forms.Control = Me.rtbComments
			size = New Global.System.Drawing.Size(768, 272)
			rtbComments2.Size = size
			Me.rtbComments.TabIndex = 16
			Me.rtbComments.Text = ""
			Me.cmdOK.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdOK.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cmdOK.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cmdOK.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.cmdOK.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdOK As Global.System.Windows.Forms.Control = Me.cmdOK
			location = New Global.System.Drawing.Point(664, 618)
			cmdOK.Location = location
			Me.cmdOK.Name = "cmdOK"
			Me.cmdOK.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim cmdOK2 As Global.System.Windows.Forms.Control = Me.cmdOK
			size = New Global.System.Drawing.Size(96, 23)
			cmdOK2.Size = size
			Me.cmdOK.TabIndex = 40
			Me.cmdOK.Text = "OK"
			Me.cmdOK.UseVisualStyleBackColor = False
			Me.cmdCancel.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdCancel.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cmdCancel.DialogResult = Global.System.Windows.Forms.DialogResult.Cancel
			Me.cmdCancel.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cmdCancel.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.cmdCancel.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdCancel As Global.System.Windows.Forms.Control = Me.cmdCancel
			location = New Global.System.Drawing.Point(664, 648)
			cmdCancel.Location = location
			Me.cmdCancel.Name = "cmdCancel"
			Me.cmdCancel.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim cmdCancel2 As Global.System.Windows.Forms.Control = Me.cmdCancel
			size = New Global.System.Drawing.Size(96, 23)
			cmdCancel2.Size = size
			Me.cmdCancel.TabIndex = 41
			Me.cmdCancel.Text = "Cancel"
			Me.cmdCancel.UseVisualStyleBackColor = False
			Me.btnResetComments.BackColor = Global.System.Drawing.SystemColors.Control
			Me.btnResetComments.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.btnResetComments.Font = New Global.System.Drawing.Font("Arial", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnResetComments.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.btnResetComments.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim btnResetComments As Global.System.Windows.Forms.Control = Me.btnResetComments
			location = New Global.System.Drawing.Point(336, 648)
			btnResetComments.Location = location
			Me.btnResetComments.Name = "btnResetComments"
			Me.btnResetComments.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim btnResetComments2 As Global.System.Windows.Forms.Control = Me.btnResetComments
			size = New Global.System.Drawing.Size(288, 23)
			btnResetComments2.Size = size
			Me.btnResetComments.TabIndex = 48
			Me.btnResetComments.Text = "Reset Comments"
			Me.btnResetComments.UseVisualStyleBackColor = False
			Me.btnAddWellInfoComment.Font = New Global.System.Drawing.Font("Arial", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim btnAddWellInfoComment As Global.System.Windows.Forms.Control = Me.btnAddWellInfoComment
			location = New Global.System.Drawing.Point(40, 618)
			btnAddWellInfoComment.Location = location
			Me.btnAddWellInfoComment.Name = "btnAddWellInfoComment"
			Dim btnAddWellInfoComment2 As Global.System.Windows.Forms.Control = Me.btnAddWellInfoComment
			size = New Global.System.Drawing.Size(288, 24)
			btnAddWellInfoComment2.Size = size
			Me.btnAddWellInfoComment.TabIndex = 52
			Me.btnAddWellInfoComment.Text = "Add Well Information Comment"
			Me.btnAddRodStringInfo.Font = New Global.System.Drawing.Font("Arial", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim btnAddRodStringInfo As Global.System.Windows.Forms.Control = Me.btnAddRodStringInfo
			location = New Global.System.Drawing.Point(40, 648)
			btnAddRodStringInfo.Location = location
			Me.btnAddRodStringInfo.Name = "btnAddRodStringInfo"
			Dim btnAddRodStringInfo2 As Global.System.Windows.Forms.Control = Me.btnAddRodStringInfo
			size = New Global.System.Drawing.Size(288, 24)
			btnAddRodStringInfo2.Size = size
			Me.btnAddRodStringInfo.TabIndex = 53
			Me.btnAddRodStringInfo.Text = "Add Rod String Information "
			Me.btnAddSetupComment.Font = New Global.System.Drawing.Font("Arial", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim btnAddSetupComment As Global.System.Windows.Forms.Control = Me.btnAddSetupComment
			location = New Global.System.Drawing.Point(336, 618)
			btnAddSetupComment.Location = location
			Me.btnAddSetupComment.Name = "btnAddSetupComment"
			Dim btnAddSetupComment2 As Global.System.Windows.Forms.Control = Me.btnAddSetupComment
			size = New Global.System.Drawing.Size(288, 24)
			btnAddSetupComment2.Size = size
			Me.btnAddSetupComment.TabIndex = 54
			Me.btnAddSetupComment.Text = "Add Setup / Defaults Cover Page Comment"
			Me.Panel1.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Me.Panel1.Controls.Add(Me.btnLogo)
			Me.Panel1.Controls.Add(Me.txtMyTelephone)
			Me.Panel1.Controls.Add(Me.lblPhone)
			Me.Panel1.Controls.Add(Me.txtAddress2)
			Me.Panel1.Controls.Add(Me.lblAddress2)
			Me.Panel1.Controls.Add(Me.txtAddress1)
			Me.Panel1.Controls.Add(Me.lblAddress1)
			Me.Panel1.Controls.Add(Me.txtMyCompanyWebsite)
			Me.Panel1.Controls.Add(Me.lblMyCompanyWebsite)
			Me.Panel1.Controls.Add(Me.txtMyCompanyName)
			Me.Panel1.Controls.Add(Me.txtMyContactName)
			Me.Panel1.Controls.Add(Me.lblMyContactName)
			Me.Panel1.Controls.Add(Me.lblMyCompanyName)
			Dim panel As Global.System.Windows.Forms.Control = Me.Panel1
			location = New Global.System.Drawing.Point(4, 56)
			panel.Location = location
			Me.Panel1.Name = "Panel1"
			Dim panel2 As Global.System.Windows.Forms.Control = Me.Panel1
			size = New Global.System.Drawing.Size(784, 104)
			panel2.Size = size
			Me.Panel1.TabIndex = 55
			Dim btnLogo As Global.System.Windows.Forms.Control = Me.btnLogo
			location = New Global.System.Drawing.Point(4, 4)
			btnLogo.Location = location
			Me.btnLogo.Name = "btnLogo"
			Dim btnLogo2 As Global.System.Windows.Forms.Control = Me.btnLogo
			size = New Global.System.Drawing.Size(90, 90)
			btnLogo2.Size = size
			Me.btnLogo.TabIndex = 34
			Me.txtMyTelephone.Font = New Global.System.Drawing.Font("Arial", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim txtMyTelephone As Global.System.Windows.Forms.Control = Me.txtMyTelephone
			location = New Global.System.Drawing.Point(544, 64)
			txtMyTelephone.Location = location
			Me.txtMyTelephone.Name = "txtMyTelephone"
			Dim txtMyTelephone2 As Global.System.Windows.Forms.Control = Me.txtMyTelephone
			size = New Global.System.Drawing.Size(232, 21)
			txtMyTelephone2.Size = size
			Me.txtMyTelephone.TabIndex = 33
			Me.lblPhone.Font = New Global.System.Drawing.Font("Arial", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim lblPhone As Global.System.Windows.Forms.Control = Me.lblPhone
			location = New Global.System.Drawing.Point(432, 64)
			lblPhone.Location = location
			Me.lblPhone.Name = "lblPhone"
			Dim lblPhone2 As Global.System.Windows.Forms.Control = Me.lblPhone
			size = New Global.System.Drawing.Size(152, 21)
			lblPhone2.Size = size
			Me.lblPhone.TabIndex = 32
			Me.lblPhone.Text = "Telephone No. :"
			Me.lblPhone.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.txtAddress2.Font = New Global.System.Drawing.Font("Arial", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim txtAddress As Global.System.Windows.Forms.Control = Me.txtAddress2
			location = New Global.System.Drawing.Point(192, 64)
			txtAddress.Location = location
			Me.txtAddress2.Name = "txtAddress2"
			Dim txtAddress2 As Global.System.Windows.Forms.Control = Me.txtAddress2
			size = New Global.System.Drawing.Size(232, 21)
			txtAddress2.Size = size
			Me.txtAddress2.TabIndex = 31
			Me.lblAddress2.Font = New Global.System.Drawing.Font("Arial", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim lblAddress As Global.System.Windows.Forms.Control = Me.lblAddress2
			location = New Global.System.Drawing.Point(96, 64)
			lblAddress.Location = location
			Me.lblAddress2.Name = "lblAddress2"
			Dim lblAddress2 As Global.System.Windows.Forms.Control = Me.lblAddress2
			size = New Global.System.Drawing.Size(126, 21)
			lblAddress2.Size = size
			Me.lblAddress2.TabIndex = 30
			Me.lblAddress2.Text = "Address 2:"
			Me.lblAddress2.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.txtAddress1.Font = New Global.System.Drawing.Font("Arial", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim txtAddress3 As Global.System.Windows.Forms.Control = Me.txtAddress1
			location = New Global.System.Drawing.Point(192, 40)
			txtAddress3.Location = location
			Me.txtAddress1.Name = "txtAddress1"
			Dim txtAddress4 As Global.System.Windows.Forms.Control = Me.txtAddress1
			size = New Global.System.Drawing.Size(232, 21)
			txtAddress4.Size = size
			Me.txtAddress1.TabIndex = 29
			Me.lblAddress1.Font = New Global.System.Drawing.Font("Arial", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim lblAddress3 As Global.System.Windows.Forms.Control = Me.lblAddress1
			location = New Global.System.Drawing.Point(96, 40)
			lblAddress3.Location = location
			Me.lblAddress1.Name = "lblAddress1"
			Dim lblAddress4 As Global.System.Windows.Forms.Control = Me.lblAddress1
			size = New Global.System.Drawing.Size(126, 21)
			lblAddress4.Size = size
			Me.lblAddress1.TabIndex = 28
			Me.lblAddress1.Text = "Address 1:"
			Me.lblAddress1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.txtMyCompanyWebsite.Font = New Global.System.Drawing.Font("Arial", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim txtMyCompanyWebsite As Global.System.Windows.Forms.Control = Me.txtMyCompanyWebsite
			location = New Global.System.Drawing.Point(544, 16)
			txtMyCompanyWebsite.Location = location
			Me.txtMyCompanyWebsite.Name = "txtMyCompanyWebsite"
			Dim txtMyCompanyWebsite2 As Global.System.Windows.Forms.Control = Me.txtMyCompanyWebsite
			size = New Global.System.Drawing.Size(232, 21)
			txtMyCompanyWebsite2.Size = size
			Me.txtMyCompanyWebsite.TabIndex = 27
			Me.lblMyCompanyWebsite.Font = New Global.System.Drawing.Font("Arial", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim lblMyCompanyWebsite As Global.System.Windows.Forms.Control = Me.lblMyCompanyWebsite
			location = New Global.System.Drawing.Point(432, 16)
			lblMyCompanyWebsite.Location = location
			Me.lblMyCompanyWebsite.Name = "lblMyCompanyWebsite"
			Dim lblMyCompanyWebsite2 As Global.System.Windows.Forms.Control = Me.lblMyCompanyWebsite
			size = New Global.System.Drawing.Size(152, 21)
			lblMyCompanyWebsite2.Size = size
			Me.lblMyCompanyWebsite.TabIndex = 26
			Me.lblMyCompanyWebsite.Text = "Company Website"
			Me.lblMyCompanyWebsite.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.txtMyCompanyName.Font = New Global.System.Drawing.Font("Arial", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim txtMyCompanyName As Global.System.Windows.Forms.Control = Me.txtMyCompanyName
			location = New Global.System.Drawing.Point(192, 16)
			txtMyCompanyName.Location = location
			Me.txtMyCompanyName.Name = "txtMyCompanyName"
			Dim txtMyCompanyName2 As Global.System.Windows.Forms.Control = Me.txtMyCompanyName
			size = New Global.System.Drawing.Size(232, 21)
			txtMyCompanyName2.Size = size
			Me.txtMyCompanyName.TabIndex = 24
			Me.txtMyContactName.Font = New Global.System.Drawing.Font("Arial", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim txtMyContactName As Global.System.Windows.Forms.Control = Me.txtMyContactName
			location = New Global.System.Drawing.Point(544, 40)
			txtMyContactName.Location = location
			Me.txtMyContactName.Name = "txtMyContactName"
			Dim txtMyContactName2 As Global.System.Windows.Forms.Control = Me.txtMyContactName
			size = New Global.System.Drawing.Size(232, 21)
			txtMyContactName2.Size = size
			Me.txtMyContactName.TabIndex = 25
			Me.lblMyContactName.Font = New Global.System.Drawing.Font("Arial", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim lblMyContactName As Global.System.Windows.Forms.Control = Me.lblMyContactName
			location = New Global.System.Drawing.Point(432, 40)
			lblMyContactName.Location = location
			Me.lblMyContactName.Name = "lblMyContactName"
			Dim lblMyContactName2 As Global.System.Windows.Forms.Control = Me.lblMyContactName
			size = New Global.System.Drawing.Size(152, 21)
			lblMyContactName2.Size = size
			Me.lblMyContactName.TabIndex = 23
			Me.lblMyContactName.Text = "My Contact Name:"
			Me.lblMyContactName.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.lblMyCompanyName.Font = New Global.System.Drawing.Font("Arial", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim lblMyCompanyName As Global.System.Windows.Forms.Control = Me.lblMyCompanyName
			location = New Global.System.Drawing.Point(96, 16)
			lblMyCompanyName.Location = location
			Me.lblMyCompanyName.Name = "lblMyCompanyName"
			Dim lblMyCompanyName2 As Global.System.Windows.Forms.Control = Me.lblMyCompanyName
			size = New Global.System.Drawing.Size(126, 21)
			lblMyCompanyName2.Size = size
			Me.lblMyCompanyName.TabIndex = 22
			Me.lblMyCompanyName.Text = "Company Name: "
			Me.lblMyCompanyName.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me._Label_0.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_0.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Me._Label_0.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_0.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._Label_0.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me._Label_0.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label_ As Global.System.Windows.Forms.Control = Me._Label_0
			location = New Global.System.Drawing.Point(4, 4)
			label_.Location = location
			Me._Label_0.Name = "_Label_0"
			Me._Label_0.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim label_2 As Global.System.Windows.Forms.Control = Me._Label_0
			size = New Global.System.Drawing.Size(784, 48)
			label_2.Size = size
			Me._Label_0.TabIndex = 56
			Me._Label_0.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			size = New Global.System.Drawing.Size(6, 13)
			Me.AutoScaleBaseSize = size
			Me.AutoScroll = True
			size = New Global.System.Drawing.Size(802, 689)
			Me.ClientSize = size
			Me.ControlBox = False
			Me.Controls.Add(Me._Label_0)
			Me.Controls.Add(Me.Panel1)
			Me.Controls.Add(Me.btnResetComments)
			Me.Controls.Add(Me._SSPanel_0)
			Me.Controls.Add(Me.cmdOK)
			Me.Controls.Add(Me.cmdCancel)
			Me.Controls.Add(Me.btnAddWellInfoComment)
			Me.Controls.Add(Me.btnAddRodStringInfo)
			Me.Controls.Add(Me.btnAddSetupComment)
			Me.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedDialog
			location = New Global.System.Drawing.Point(64, 184)
			Me.Location = location
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "dlgCoverPageComments"
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "Cover Page Comments"
			Me._SSPanel_0.ResumeLayout(False)
			Me._SSPanel_0.PerformLayout()
			CType(Me.Label, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.SSPanel, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.Panel1.ResumeLayout(False)
			Me.Panel1.PerformLayout()
			Me.ResumeLayout(False)
		End Sub

		Private components As Global.System.ComponentModel.IContainer

		Public ToolTip1 As Global.System.Windows.Forms.ToolTip
	End Class
End Namespace
