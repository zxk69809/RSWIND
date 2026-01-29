Namespace RSWINV3
	Friend Partial Class SetupEquip
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
			Me.panPage = New Global.System.Windows.Forms.Panel()
			Me.panContainer = New Global.System.Windows.Forms.Panel()
			Me.cmdCheckData = New Global.System.Windows.Forms.Button()
			Me.cmdPUList = New Global.System.Windows.Forms.Button()
			Me.panEquipList = New Global.System.Windows.Forms.Panel()
			Me.lstRGEquip = New Global.System.Windows.Forms.ListBox()
			Me.lstPUEquip = New Global.System.Windows.Forms.ListBox()
			Me.cmdEquipNew = New Global.System.Windows.Forms.Button()
			Me.cmdEquipModify = New Global.System.Windows.Forms.Button()
			Me.cmdEquipDelete = New Global.System.Windows.Forms.Button()
			Me._Label_0 = New Global.System.Windows.Forms.Label()
			Me.cboEquipList = New Global.System.Windows.Forms.ComboBox()
			Me.Label = New Global.Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
			Me.SSPanel = New Global.Microsoft.VisualBasic.Compatibility.VB6.PanelArray(Me.components)
			Me.panPage.SuspendLayout()
			Me.panContainer.SuspendLayout()
			Me.panEquipList.SuspendLayout()
			CType(Me.Label, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.SSPanel, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			Me.ToolTip1.ShowAlways = True
			Me.panPage.BackColor = Global.System.Drawing.SystemColors.Window
			Me.panPage.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.panPage.Controls.Add(Me.panContainer)
			Me.panPage.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.panPage.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.panPage.ForeColor = Global.System.Drawing.Color.Black
			Dim panPage As Global.System.Windows.Forms.Control = Me.panPage
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(0, 0)
			panPage.Location = location
			Me.panPage.Name = "panPage"
			Me.panPage.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim panPage2 As Global.System.Windows.Forms.Control = Me.panPage
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(486, 221)
			panPage2.Size = size
			Me.panPage.TabIndex = 1
			Me.panPage.TabStop = True
			Me.panContainer.BackColor = Global.System.Drawing.SystemColors.Control
			Me.panContainer.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.panContainer.Controls.Add(Me.cmdCheckData)
			Me.panContainer.Controls.Add(Me.cmdPUList)
			Me.panContainer.Controls.Add(Me.panEquipList)
			Me.panContainer.Controls.Add(Me.cmdEquipNew)
			Me.panContainer.Controls.Add(Me.cmdEquipModify)
			Me.panContainer.Controls.Add(Me.cmdEquipDelete)
			Me.panContainer.Controls.Add(Me._Label_0)
			Me.panContainer.Controls.Add(Me.cboEquipList)
			Me.panContainer.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.panContainer.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.panContainer.ForeColor = Global.System.Drawing.Color.Black
			Dim panContainer As Global.System.Windows.Forms.Control = Me.panContainer
			location = New Global.System.Drawing.Point(3, 3)
			panContainer.Location = location
			Me.panContainer.Name = "panContainer"
			Me.panContainer.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim panContainer2 As Global.System.Windows.Forms.Control = Me.panContainer
			size = New Global.System.Drawing.Size(480, 215)
			panContainer2.Size = size
			Me.panContainer.TabIndex = 2
			Me.panContainer.TabStop = True
			Me.cmdCheckData.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdCheckData.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cmdCheckData.Font = New Global.System.Drawing.Font("Arial", 8.25F)
			Me.cmdCheckData.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.cmdCheckData.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdCheckData As Global.System.Windows.Forms.Control = Me.cmdCheckData
			location = New Global.System.Drawing.Point(344, 184)
			cmdCheckData.Location = location
			Me.cmdCheckData.Name = "cmdCheckData"
			Me.cmdCheckData.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim cmdCheckData2 As Global.System.Windows.Forms.Control = Me.cmdCheckData
			size = New Global.System.Drawing.Size(120, 20)
			cmdCheckData2.Size = size
			Me.cmdCheckData.TabIndex = 12
			Me.cmdCheckData.Text = "Check data (hiddent)"
			Me.cmdCheckData.UseVisualStyleBackColor = False
			Me.cmdCheckData.Visible = False
			Me.cmdPUList.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdPUList.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cmdPUList.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cmdPUList.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.cmdPUList.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdPUList As Global.System.Windows.Forms.Control = Me.cmdPUList
			location = New Global.System.Drawing.Point(12, 183)
			cmdPUList.Location = location
			Me.cmdPUList.Name = "cmdPUList"
			Me.cmdPUList.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim cmdPUList2 As Global.System.Windows.Forms.Control = Me.cmdPUList
			size = New Global.System.Drawing.Size(185, 22)
			cmdPUList2.Size = size
			Me.cmdPUList.TabIndex = 0
			Me.cmdPUList.Text = "Customize pumping unit list.."
			Me.cmdPUList.UseVisualStyleBackColor = False
			Me.panEquipList.BackColor = Global.System.Drawing.SystemColors.Control
			Me.panEquipList.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.panEquipList.Controls.Add(Me.lstRGEquip)
			Me.panEquipList.Controls.Add(Me.lstPUEquip)
			Me.panEquipList.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.panEquipList.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.panEquipList.ForeColor = Global.System.Drawing.Color.Black
			Dim panEquipList As Global.System.Windows.Forms.Control = Me.panEquipList
			location = New Global.System.Drawing.Point(11, 36)
			panEquipList.Location = location
			Me.panEquipList.Name = "panEquipList"
			Me.panEquipList.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim panEquipList2 As Global.System.Windows.Forms.Control = Me.panEquipList
			size = New Global.System.Drawing.Size(357, 140)
			panEquipList2.Size = size
			Me.panEquipList.TabIndex = 10
			Me.panEquipList.TabStop = True
			Me.lstRGEquip.BackColor = Global.System.Drawing.SystemColors.Window
			Me.lstRGEquip.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.lstRGEquip.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lstRGEquip.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.lstRGEquip.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.lstRGEquip.ItemHeight = 14
			Dim lstRGEquip As Global.System.Windows.Forms.Control = Me.lstRGEquip
			location = New Global.System.Drawing.Point(216, 8)
			lstRGEquip.Location = location
			Me.lstRGEquip.Name = "lstRGEquip"
			Me.lstRGEquip.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim lstRGEquip2 As Global.System.Windows.Forms.Control = Me.lstRGEquip
			size = New Global.System.Drawing.Size(130, 114)
			lstRGEquip2.Size = size
			Me.lstRGEquip.TabIndex = 3
			Me.lstRGEquip.Visible = False
			Me.lstPUEquip.ItemHeight = 14
			Dim lstPUEquip As Global.System.Windows.Forms.Control = Me.lstPUEquip
			location = New Global.System.Drawing.Point(8, 8)
			lstPUEquip.Location = location
			Me.lstPUEquip.Name = "lstPUEquip"
			Dim lstPUEquip2 As Global.System.Windows.Forms.Control = Me.lstPUEquip
			size = New Global.System.Drawing.Size(336, 116)
			lstPUEquip2.Size = size
			Me.lstPUEquip.TabIndex = 0
			Me.cmdEquipNew.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdEquipNew.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cmdEquipNew.Enabled = False
			Me.cmdEquipNew.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cmdEquipNew.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.cmdEquipNew.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdEquipNew As Global.System.Windows.Forms.Control = Me.cmdEquipNew
			location = New Global.System.Drawing.Point(382, 35)
			cmdEquipNew.Location = location
			Me.cmdEquipNew.Name = "cmdEquipNew"
			Me.cmdEquipNew.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim cmdEquipNew2 As Global.System.Windows.Forms.Control = Me.cmdEquipNew
			size = New Global.System.Drawing.Size(77, 23)
			cmdEquipNew2.Size = size
			Me.cmdEquipNew.TabIndex = 9
			Me.cmdEquipNew.Text = "New.."
			Me.cmdEquipNew.UseVisualStyleBackColor = False
			Me.cmdEquipModify.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdEquipModify.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cmdEquipModify.Enabled = False
			Me.cmdEquipModify.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cmdEquipModify.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.cmdEquipModify.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdEquipModify As Global.System.Windows.Forms.Control = Me.cmdEquipModify
			location = New Global.System.Drawing.Point(382, 68)
			cmdEquipModify.Location = location
			Me.cmdEquipModify.Name = "cmdEquipModify"
			Me.cmdEquipModify.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim cmdEquipModify2 As Global.System.Windows.Forms.Control = Me.cmdEquipModify
			size = New Global.System.Drawing.Size(77, 23)
			cmdEquipModify2.Size = size
			Me.cmdEquipModify.TabIndex = 8
			Me.cmdEquipModify.Text = "Modify.."
			Me.cmdEquipModify.UseVisualStyleBackColor = False
			Me.cmdEquipDelete.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdEquipDelete.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cmdEquipDelete.Enabled = False
			Me.cmdEquipDelete.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cmdEquipDelete.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.cmdEquipDelete.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdEquipDelete As Global.System.Windows.Forms.Control = Me.cmdEquipDelete
			location = New Global.System.Drawing.Point(382, 107)
			cmdEquipDelete.Location = location
			Me.cmdEquipDelete.Name = "cmdEquipDelete"
			Me.cmdEquipDelete.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim cmdEquipDelete2 As Global.System.Windows.Forms.Control = Me.cmdEquipDelete
			size = New Global.System.Drawing.Size(77, 23)
			cmdEquipDelete2.Size = size
			Me.cmdEquipDelete.TabIndex = 7
			Me.cmdEquipDelete.Text = "Delete"
			Me.cmdEquipDelete.UseVisualStyleBackColor = False
			Me._Label_0.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_0.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_0.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._Label_0.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me._Label_0.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.Label.SetIndex(Me._Label_0, 0S)
			Dim label_ As Global.System.Windows.Forms.Control = Me._Label_0
			location = New Global.System.Drawing.Point(27, 11)
			label_.Location = location
			Me._Label_0.Name = "_Label_0"
			Me._Label_0.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim label_2 As Global.System.Windows.Forms.Control = Me._Label_0
			size = New Global.System.Drawing.Size(250, 13)
			label_2.Size = size
			Me._Label_0.TabIndex = 4
			Me._Label_0.Text = "Select the custom equipment list to change:"
			Me.cboEquipList.BackColor = Global.System.Drawing.SystemColors.Window
			Me.cboEquipList.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cboEquipList.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cboEquipList.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.cboEquipList.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.cboEquipList.ItemHeight = 14
			Dim cboEquipList As Global.System.Windows.Forms.Control = Me.cboEquipList
			location = New Global.System.Drawing.Point(280, 8)
			cboEquipList.Location = location
			Me.cboEquipList.Name = "cboEquipList"
			Me.cboEquipList.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim cboEquipList2 As Global.System.Windows.Forms.Control = Me.cboEquipList
			size = New Global.System.Drawing.Size(163, 22)
			cboEquipList2.Size = size
			Me.cboEquipList.TabIndex = 6
			size = New Global.System.Drawing.Size(6, 13)
			Me.AutoScaleBaseSize = size
			size = New Global.System.Drawing.Size(497, 245)
			Me.ClientSize = size
			Me.ControlBox = False
			Me.Controls.Add(Me.panPage)
			Me.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.KeyPreview = True
			location = New Global.System.Drawing.Point(13, 199)
			Me.Location = location
			Me.Name = "SetupEquip"
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "Setup (Custom Equipment Lists)"
			Me.panPage.ResumeLayout(False)
			Me.panContainer.ResumeLayout(False)
			Me.panEquipList.ResumeLayout(False)
			CType(Me.Label, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.SSPanel, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
		End Sub

		Private components As Global.System.ComponentModel.IContainer

		Public ToolTip1 As Global.System.Windows.Forms.ToolTip
	End Class
End Namespace
