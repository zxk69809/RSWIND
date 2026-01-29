Namespace RSWINV3
	Friend Partial Class dlgPUList
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
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.RSWINV3.dlgPUList))
			Me.ToolTip1 = New Global.System.Windows.Forms.ToolTip(Me.components)
			Me.cmdHelp = New Global.System.Windows.Forms.Button()
			Me.cmdCancel = New Global.System.Windows.Forms.Button()
			Me.cmdOK = New Global.System.Windows.Forms.Button()
			Me._SSPanel_0 = New Global.System.Windows.Forms.Panel()
			Me.lstCustomPUDB = New Global.System.Windows.Forms.ListBox()
			Me.cboManufMenu = New Global.System.Windows.Forms.ComboBox()
			Me.cmdRemove = New Global.System.Windows.Forms.Button()
			Me.cmdAdd = New Global.System.Windows.Forms.Button()
			Me.lstSelected = New Global.System.Windows.Forms.ListBox()
			Me.lstAvailable = New Global.System.Windows.Forms.ListBox()
			Me._panOtherInfo_1 = New Global.System.Windows.Forms.Label()
			Me._panUnitName_1 = New Global.System.Windows.Forms.Label()
			Me._panOtherInfo_0 = New Global.System.Windows.Forms.Label()
			Me._panUnitName_0 = New Global.System.Windows.Forms.Label()
			Me._Label_5 = New Global.System.Windows.Forms.Label()
			Me._Label_4 = New Global.System.Windows.Forms.Label()
			Me._lblUnitName_1 = New Global.System.Windows.Forms.Label()
			Me._Label_3 = New Global.System.Windows.Forms.Label()
			Me._lblUnitName_0 = New Global.System.Windows.Forms.Label()
			Me._Label_0 = New Global.System.Windows.Forms.Label()
			Me._Label_2 = New Global.System.Windows.Forms.Label()
			Me._Label_1 = New Global.System.Windows.Forms.Label()
			Me.Timer1 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.Label = New Global.Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
			Me.SSPanel = New Global.Microsoft.VisualBasic.Compatibility.VB6.PanelArray(Me.components)
			Me.lblUnitName = New Global.Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
			Me.panOtherInfo = New Global.Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
			Me.panUnitName = New Global.Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
			Me.HelpProvider1 = New Global.System.Windows.Forms.HelpProvider()
			Me._SSPanel_0.SuspendLayout()
			CType(Me.Label, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.SSPanel, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lblUnitName, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panOtherInfo, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panUnitName, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			Me.ToolTip1.ShowAlways = True
			Me.cmdHelp.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdHelp.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cmdHelp.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cmdHelp.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.cmdHelp.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdHelp As Global.System.Windows.Forms.Control = Me.cmdHelp
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(792, 75)
			cmdHelp.Location = location
			Me.cmdHelp.Name = "cmdHelp"
			Me.cmdHelp.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.cmdHelp, False)
			Dim cmdHelp2 As Global.System.Windows.Forms.Control = Me.cmdHelp
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(83, 25)
			cmdHelp2.Size = size
			Me.cmdHelp.TabIndex = 7
			Me.cmdHelp.TabStop = False
			Me.cmdHelp.Text = "Help"
			Me.cmdHelp.UseVisualStyleBackColor = False
			Me.cmdCancel.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdCancel.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cmdCancel.DialogResult = Global.System.Windows.Forms.DialogResult.Cancel
			Me.cmdCancel.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cmdCancel.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.cmdCancel.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdCancel As Global.System.Windows.Forms.Control = Me.cmdCancel
			location = New Global.System.Drawing.Point(792, 34)
			cmdCancel.Location = location
			Me.cmdCancel.Name = "cmdCancel"
			Me.cmdCancel.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.cmdCancel, False)
			Dim cmdCancel2 As Global.System.Windows.Forms.Control = Me.cmdCancel
			size = New Global.System.Drawing.Size(83, 25)
			cmdCancel2.Size = size
			Me.cmdCancel.TabIndex = 6
			Me.cmdCancel.Text = "Cancel"
			Me.cmdCancel.UseVisualStyleBackColor = False
			Me.cmdOK.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdOK.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cmdOK.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cmdOK.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.cmdOK.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdOK As Global.System.Windows.Forms.Control = Me.cmdOK
			location = New Global.System.Drawing.Point(792, 5)
			cmdOK.Location = location
			Me.cmdOK.Name = "cmdOK"
			Me.cmdOK.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.cmdOK, False)
			Dim cmdOK2 As Global.System.Windows.Forms.Control = Me.cmdOK
			size = New Global.System.Drawing.Size(83, 25)
			cmdOK2.Size = size
			Me.cmdOK.TabIndex = 5
			Me.cmdOK.Text = "OK"
			Me.cmdOK.UseVisualStyleBackColor = False
			Me._SSPanel_0.BackColor = Global.System.Drawing.SystemColors.Control
			Me._SSPanel_0.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Me._SSPanel_0.Controls.Add(Me.lstCustomPUDB)
			Me._SSPanel_0.Controls.Add(Me.cboManufMenu)
			Me._SSPanel_0.Controls.Add(Me.cmdRemove)
			Me._SSPanel_0.Controls.Add(Me.cmdAdd)
			Me._SSPanel_0.Controls.Add(Me.lstSelected)
			Me._SSPanel_0.Controls.Add(Me.lstAvailable)
			Me._SSPanel_0.Controls.Add(Me._panOtherInfo_1)
			Me._SSPanel_0.Controls.Add(Me._panUnitName_1)
			Me._SSPanel_0.Controls.Add(Me._panOtherInfo_0)
			Me._SSPanel_0.Controls.Add(Me._panUnitName_0)
			Me._SSPanel_0.Controls.Add(Me._Label_5)
			Me._SSPanel_0.Controls.Add(Me._Label_4)
			Me._SSPanel_0.Controls.Add(Me._lblUnitName_1)
			Me._SSPanel_0.Controls.Add(Me._Label_3)
			Me._SSPanel_0.Controls.Add(Me._lblUnitName_0)
			Me._SSPanel_0.Controls.Add(Me._Label_0)
			Me._SSPanel_0.Controls.Add(Me._Label_2)
			Me._SSPanel_0.Controls.Add(Me._Label_1)
			Me._SSPanel_0.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._SSPanel_0.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._SSPanel_0.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.SSPanel.SetIndex(Me._SSPanel_0, 0S)
			Dim sspanel_ As Global.System.Windows.Forms.Control = Me._SSPanel_0
			location = New Global.System.Drawing.Point(2, 6)
			sspanel_.Location = location
			Me._SSPanel_0.Name = "_SSPanel_0"
			Me._SSPanel_0.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._SSPanel_0, False)
			Dim sspanel_2 As Global.System.Windows.Forms.Control = Me._SSPanel_0
			size = New Global.System.Drawing.Size(774, 287)
			sspanel_2.Size = size
			Me._SSPanel_0.TabIndex = 8
			Me._SSPanel_0.TabStop = True
			Me.lstCustomPUDB.BackColor = Global.System.Drawing.SystemColors.Window
			Me.lstCustomPUDB.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lstCustomPUDB.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.lstCustomPUDB.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.lstCustomPUDB.ItemHeight = 14
			Dim lstCustomPUDB As Global.System.Windows.Forms.Control = Me.lstCustomPUDB
			location = New Global.System.Drawing.Point(456, 39)
			lstCustomPUDB.Location = location
			Me.lstCustomPUDB.Name = "lstCustomPUDB"
			Me.lstCustomPUDB.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.lstCustomPUDB, False)
			Dim lstCustomPUDB2 As Global.System.Windows.Forms.Control = Me.lstCustomPUDB
			size = New Global.System.Drawing.Size(136, 4)
			lstCustomPUDB2.Size = size
			Me.lstCustomPUDB.TabIndex = 11
			Me.lstCustomPUDB.TabStop = False
			Me.lstCustomPUDB.Visible = False
			Me.cboManufMenu.BackColor = Global.System.Drawing.Color.White
			Me.cboManufMenu.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cboManufMenu.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cboManufMenu.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cboManufMenu.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.cboManufMenu, "Pumping Unit: Manufacturer List")
			Me.HelpProvider1.SetHelpNavigator(Me.cboManufMenu, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.cboManufMenu.ItemHeight = 14
			Dim cboManufMenu As Global.System.Windows.Forms.Control = Me.cboManufMenu
			location = New Global.System.Drawing.Point(178, 35)
			cboManufMenu.Location = location
			Me.cboManufMenu.Name = "cboManufMenu"
			Me.cboManufMenu.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.cboManufMenu, True)
			Dim cboManufMenu2 As Global.System.Windows.Forms.Control = Me.cboManufMenu
			size = New Global.System.Drawing.Size(270, 22)
			cboManufMenu2.Size = size
			Me.cboManufMenu.TabIndex = 0
			Me.cmdRemove.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdRemove.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cmdRemove.Enabled = False
			Me.cmdRemove.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cmdRemove.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.HelpProvider1.SetHelpKeyword(Me.cmdRemove, "Pumping Unit List: Remove")
			Me.HelpProvider1.SetHelpNavigator(Me.cmdRemove, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.cmdRemove.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdRemove As Global.System.Windows.Forms.Control = Me.cmdRemove
			location = New Global.System.Drawing.Point(376, 144)
			cmdRemove.Location = location
			Me.cmdRemove.Name = "cmdRemove"
			Me.cmdRemove.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.cmdRemove, True)
			Dim cmdRemove2 As Global.System.Windows.Forms.Control = Me.cmdRemove
			size = New Global.System.Drawing.Size(76, 25)
			cmdRemove2.Size = size
			Me.cmdRemove.TabIndex = 4
			Me.cmdRemove.Text = "&Remove>>"
			Me.cmdRemove.UseVisualStyleBackColor = False
			Me.cmdAdd.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdAdd.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cmdAdd.Enabled = False
			Me.cmdAdd.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cmdAdd.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.HelpProvider1.SetHelpKeyword(Me.cmdAdd, "Setup Pumping Unit Equipment: Add button")
			Me.HelpProvider1.SetHelpNavigator(Me.cmdAdd, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.cmdAdd.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdAdd As Global.System.Windows.Forms.Control = Me.cmdAdd
			location = New Global.System.Drawing.Point(376, 109)
			cmdAdd.Location = location
			Me.cmdAdd.Name = "cmdAdd"
			Me.cmdAdd.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.cmdAdd, True)
			Dim cmdAdd2 As Global.System.Windows.Forms.Control = Me.cmdAdd
			size = New Global.System.Drawing.Size(76, 25)
			cmdAdd2.Size = size
			Me.cmdAdd.TabIndex = 3
			Me.cmdAdd.Text = "<<&Add"
			Me.cmdAdd.UseVisualStyleBackColor = False
			Me.lstSelected.AllowDrop = True
			Me.lstSelected.BackColor = Global.System.Drawing.SystemColors.Window
			Me.lstSelected.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lstSelected.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.lstSelected.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.lstSelected, "Pumping Unit: Selected List")
			Me.HelpProvider1.SetHelpNavigator(Me.lstSelected, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.lstSelected.ItemHeight = 14
			Dim lstSelected As Global.System.Windows.Forms.Control = Me.lstSelected
			location = New Global.System.Drawing.Point(72, 85)
			lstSelected.Location = location
			Me.lstSelected.Name = "lstSelected"
			Me.lstSelected.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.lstSelected, True)
			Dim lstSelected2 As Global.System.Windows.Forms.Control = Me.lstSelected
			size = New Global.System.Drawing.Size(296, 116)
			lstSelected2.Size = size
			Me.lstSelected.TabIndex = 1
			Me.lstAvailable.AllowDrop = True
			Me.lstAvailable.BackColor = Global.System.Drawing.SystemColors.Window
			Me.lstAvailable.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lstAvailable.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.lstAvailable.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.lstAvailable, "Available Pumping Units")
			Me.HelpProvider1.SetHelpNavigator(Me.lstAvailable, Global.System.Windows.Forms.HelpNavigator.KeywordIndex)
			Me.lstAvailable.ItemHeight = 14
			Dim lstAvailable As Global.System.Windows.Forms.Control = Me.lstAvailable
			location = New Global.System.Drawing.Point(464, 85)
			lstAvailable.Location = location
			Me.lstAvailable.Name = "lstAvailable"
			Me.lstAvailable.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me.lstAvailable, True)
			Dim lstAvailable2 As Global.System.Windows.Forms.Control = Me.lstAvailable
			size = New Global.System.Drawing.Size(296, 116)
			lstAvailable2.Size = size
			Me.lstAvailable.TabIndex = 2
			Me._panOtherInfo_1.BackColor = Global.System.Drawing.Color.Transparent
			Me._panOtherInfo_1.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Me._panOtherInfo_1.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._panOtherInfo_1.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._panOtherInfo_1.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._panOtherInfo_1.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.panOtherInfo.SetIndex(Me._panOtherInfo_1, 1S)
			Dim panOtherInfo_ As Global.System.Windows.Forms.Control = Me._panOtherInfo_1
			location = New Global.System.Drawing.Point(464, 259)
			panOtherInfo_.Location = location
			Me._panOtherInfo_1.Name = "_panOtherInfo_1"
			Me._panOtherInfo_1.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._panOtherInfo_1, False)
			Dim panOtherInfo_2 As Global.System.Windows.Forms.Control = Me._panOtherInfo_1
			size = New Global.System.Drawing.Size(296, 18)
			panOtherInfo_2.Size = size
			Me._panOtherInfo_1.TabIndex = 21
			Me._panUnitName_1.BackColor = Global.System.Drawing.Color.Transparent
			Me._panUnitName_1.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Me._panUnitName_1.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._panUnitName_1.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._panUnitName_1.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._panUnitName_1.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.panUnitName.SetIndex(Me._panUnitName_1, 1S)
			Dim panUnitName_ As Global.System.Windows.Forms.Control = Me._panUnitName_1
			location = New Global.System.Drawing.Point(464, 239)
			panUnitName_.Location = location
			Me._panUnitName_1.Name = "_panUnitName_1"
			Me._panUnitName_1.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._panUnitName_1, False)
			Dim panUnitName_2 As Global.System.Windows.Forms.Control = Me._panUnitName_1
			size = New Global.System.Drawing.Size(296, 18)
			panUnitName_2.Size = size
			Me._panUnitName_1.TabIndex = 20
			Me._panOtherInfo_0.BackColor = Global.System.Drawing.Color.Transparent
			Me._panOtherInfo_0.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Me._panOtherInfo_0.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._panOtherInfo_0.Font = New Global.System.Drawing.Font("Arial", 8.25F)
			Me._panOtherInfo_0.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._panOtherInfo_0.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.panOtherInfo.SetIndex(Me._panOtherInfo_0, 0S)
			Dim panOtherInfo_3 As Global.System.Windows.Forms.Control = Me._panOtherInfo_0
			location = New Global.System.Drawing.Point(72, 259)
			panOtherInfo_3.Location = location
			Me._panOtherInfo_0.Name = "_panOtherInfo_0"
			Me._panOtherInfo_0.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._panOtherInfo_0, False)
			Dim panOtherInfo_4 As Global.System.Windows.Forms.Control = Me._panOtherInfo_0
			size = New Global.System.Drawing.Size(296, 17)
			panOtherInfo_4.Size = size
			Me._panOtherInfo_0.TabIndex = 17
			Me._panUnitName_0.BackColor = Global.System.Drawing.Color.Transparent
			Me._panUnitName_0.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Me._panUnitName_0.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._panUnitName_0.Font = New Global.System.Drawing.Font("Arial", 8.25F)
			Me._panUnitName_0.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._panUnitName_0.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.panUnitName.SetIndex(Me._panUnitName_0, 0S)
			Dim panUnitName_3 As Global.System.Windows.Forms.Control = Me._panUnitName_0
			location = New Global.System.Drawing.Point(72, 239)
			panUnitName_3.Location = location
			Me._panUnitName_0.Name = "_panUnitName_0"
			Me._panUnitName_0.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._panUnitName_0, False)
			Dim panUnitName_4 As Global.System.Windows.Forms.Control = Me._panUnitName_0
			size = New Global.System.Drawing.Size(296, 17)
			panUnitName_4.Size = size
			Me._panUnitName_0.TabIndex = 16
			Me._Label_5.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_5.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_5.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._Label_5.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._Label_5.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.Label.SetIndex(Me._Label_5, 5S)
			Dim label_ As Global.System.Windows.Forms.Control = Me._Label_5
			location = New Global.System.Drawing.Point(24, 40)
			label_.Location = location
			Me._Label_5.Name = "_Label_5"
			Me._Label_5.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_5, False)
			Dim label_2 As Global.System.Windows.Forms.Control = Me._Label_5
			size = New Global.System.Drawing.Size(152, 15)
			label_2.Size = size
			Me._Label_5.TabIndex = 13
			Me._Label_5.Text = "Manufacturer:"
			Me._Label_5.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me._Label_4.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_4.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_4.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._Label_4.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._Label_4.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.Label.SetIndex(Me._Label_4, 4S)
			Dim label_3 As Global.System.Windows.Forms.Control = Me._Label_4
			location = New Global.System.Drawing.Point(400, 261)
			label_3.Location = location
			Me._Label_4.Name = "_Label_4"
			Me._Label_4.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_4, False)
			Dim label_4 As Global.System.Windows.Forms.Control = Me._Label_4
			size = New Global.System.Drawing.Size(56, 13)
			label_4.Size = size
			Me._Label_4.TabIndex = 19
			Me._Label_4.Text = "Other:"
			Me._Label_4.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me._lblUnitName_1.BackColor = Global.System.Drawing.Color.Transparent
			Me._lblUnitName_1.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._lblUnitName_1.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._lblUnitName_1.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._lblUnitName_1.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.lblUnitName.SetIndex(Me._lblUnitName_1, 1S)
			Dim lblUnitName_ As Global.System.Windows.Forms.Control = Me._lblUnitName_1
			location = New Global.System.Drawing.Point(400, 241)
			lblUnitName_.Location = location
			Me._lblUnitName_1.Name = "_lblUnitName_1"
			Me._lblUnitName_1.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._lblUnitName_1, False)
			Dim lblUnitName_2 As Global.System.Windows.Forms.Control = Me._lblUnitName_1
			size = New Global.System.Drawing.Size(56, 13)
			lblUnitName_2.Size = size
			Me._lblUnitName_1.TabIndex = 18
			Me._lblUnitName_1.Text = "Name:"
			Me._lblUnitName_1.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me._Label_3.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_3.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_3.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._Label_3.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._Label_3.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.Label.SetIndex(Me._Label_3, 3S)
			Dim label_5 As Global.System.Windows.Forms.Control = Me._Label_3
			location = New Global.System.Drawing.Point(8, 261)
			label_5.Location = location
			Me._Label_3.Name = "_Label_3"
			Me._Label_3.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_3, False)
			Dim label_6 As Global.System.Windows.Forms.Control = Me._Label_3
			size = New Global.System.Drawing.Size(56, 13)
			label_6.Size = size
			Me._Label_3.TabIndex = 15
			Me._Label_3.Text = "Other:"
			Me._Label_3.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me._lblUnitName_0.BackColor = Global.System.Drawing.Color.Transparent
			Me._lblUnitName_0.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._lblUnitName_0.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._lblUnitName_0.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._lblUnitName_0.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.lblUnitName.SetIndex(Me._lblUnitName_0, 0S)
			Dim lblUnitName_3 As Global.System.Windows.Forms.Control = Me._lblUnitName_0
			location = New Global.System.Drawing.Point(8, 241)
			lblUnitName_3.Location = location
			Me._lblUnitName_0.Name = "_lblUnitName_0"
			Me._lblUnitName_0.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._lblUnitName_0, False)
			Dim lblUnitName_4 As Global.System.Windows.Forms.Control = Me._lblUnitName_0
			size = New Global.System.Drawing.Size(56, 16)
			lblUnitName_4.Size = size
			Me._lblUnitName_0.TabIndex = 14
			Me._lblUnitName_0.Text = "Name:"
			Me._lblUnitName_0.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me._Label_0.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_0.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_0.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._Label_0.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._Label_0.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.Label.SetIndex(Me._Label_0, 0S)
			Dim label_7 As Global.System.Windows.Forms.Control = Me._Label_0
			location = New Global.System.Drawing.Point(9, 8)
			label_7.Location = location
			Me._Label_0.Name = "_Label_0"
			Me._Label_0.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_0, False)
			Dim label_8 As Global.System.Windows.Forms.Control = Me._Label_0
			size = New Global.System.Drawing.Size(543, 16)
			label_8.Size = size
			Me._Label_0.TabIndex = 9
			Me._Label_0.Text = "Select the pumping units you want to appear in the custom pumping unit database:"
			Me._Label_2.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_2.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_2.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._Label_2.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._Label_2.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.Label.SetIndex(Me._Label_2, 2S)
			Dim label_9 As Global.System.Windows.Forms.Control = Me._Label_2
			location = New Global.System.Drawing.Point(472, 70)
			label_9.Location = location
			Me._Label_2.Name = "_Label_2"
			Me._Label_2.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_2, False)
			Dim label_10 As Global.System.Windows.Forms.Control = Me._Label_2
			size = New Global.System.Drawing.Size(296, 13)
			label_10.Size = size
			Me._Label_2.TabIndex = 12
			Me._Label_2.Text = "Available pumping units:"
			Me._Label_1.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_1.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_1.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._Label_1.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._Label_1.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.Label.SetIndex(Me._Label_1, 1S)
			Dim label_11 As Global.System.Windows.Forms.Control = Me._Label_1
			location = New Global.System.Drawing.Point(72, 70)
			label_11.Location = location
			Me._Label_1.Name = "_Label_1"
			Me._Label_1.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Me.HelpProvider1.SetShowHelp(Me._Label_1, False)
			Dim label_12 As Global.System.Windows.Forms.Control = Me._Label_1
			size = New Global.System.Drawing.Size(296, 13)
			label_12.Size = size
			Me._Label_1.TabIndex = 10
			Me._Label_1.Text = "Pumping units in custom database:"
			Me.AcceptButton = Me.cmdOK
			size = New Global.System.Drawing.Size(5, 13)
			Me.AutoScaleBaseSize = size
			Me.CancelButton = Me.cmdCancel
			size = New Global.System.Drawing.Size(895, 369)
			Me.ClientSize = size
			Me.ControlBox = False
			Me.Controls.Add(Me.cmdHelp)
			Me.Controls.Add(Me.cmdCancel)
			Me.Controls.Add(Me.cmdOK)
			Me.Controls.Add(Me._SSPanel_0)
			Me.Font = New Global.System.Drawing.Font("Arial", 8.25F)
			Me.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedDialog
			Me.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			location = New Global.System.Drawing.Point(59, 157)
			Me.Location = location
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "dlgPUList"
			Me.HelpProvider1.SetShowHelp(Me, False)
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "Custom Pumping Unit Database Setup"
			Me._SSPanel_0.ResumeLayout(False)
			CType(Me.Label, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.SSPanel, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lblUnitName, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panOtherInfo, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panUnitName, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
		End Sub

		Private components As Global.System.ComponentModel.IContainer

		Public ToolTip1 As Global.System.Windows.Forms.ToolTip
	End Class
End Namespace
