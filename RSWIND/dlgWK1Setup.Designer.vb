Namespace RSWINV3
	Friend Partial Class dlgWK1Setup
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
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.RSWINV3.dlgWK1Setup))
			Me.ToolTip1 = New Global.System.Windows.Forms.ToolTip(Me.components)
			Me.cmdHelp = New Global.System.Windows.Forms.Button()
			Me.cmdLoad = New Global.System.Windows.Forms.Button()
			Me.cmdCancel = New Global.System.Windows.Forms.Button()
			Me.cmdOK = New Global.System.Windows.Forms.Button()
			Me._SSPanel_0 = New Global.System.Windows.Forms.Panel()
			Me.chkIncludeRodString = New Global.System.Windows.Forms.CheckBox()
			Me.cmdRemove = New Global.System.Windows.Forms.Button()
			Me.cmdInsert = New Global.System.Windows.Forms.Button()
			Me.cmdAppend = New Global.System.Windows.Forms.Button()
			Me.cmdMoveDown = New Global.System.Windows.Forms.Button()
			Me.cmdMoveUp = New Global.System.Windows.Forms.Button()
			Me._Label_3 = New Global.System.Windows.Forms.Label()
			Me._Label_0 = New Global.System.Windows.Forms.Label()
			Me._Label_2 = New Global.System.Windows.Forms.Label()
			Me._Label_1 = New Global.System.Windows.Forms.Label()
			Me.txtFormatName = New Global.System.Windows.Forms.TextBox()
			Me.lstAvailable = New Global.System.Windows.Forms.ListBox()
			Me.lstSelected = New Global.System.Windows.Forms.ListBox()
			Me.Label = New Global.Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
			Me.SSPanel = New Global.Microsoft.VisualBasic.Compatibility.VB6.PanelArray(Me.components)
			Me.HelpProvider1 = New Global.System.Windows.Forms.HelpProvider()
			Me._SSPanel_0.SuspendLayout()
			CType(Me.Label, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.SSPanel, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			Me.ToolTip1.ShowAlways = True
			Me.cmdHelp.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdHelp.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			componentResourceManager.ApplyResources(Me.cmdHelp, "cmdHelp")
			Me.cmdHelp.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.cmdHelp.Name = "cmdHelp"
			Me.HelpProvider1.SetShowHelp(Me.cmdHelp, Global.Microsoft.VisualBasic.CompilerServices.Conversions.ToBoolean(componentResourceManager.GetObject("cmdHelp.ShowHelp")))
			Me.cmdHelp.UseVisualStyleBackColor = False
			Me.cmdLoad.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdLoad.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			componentResourceManager.ApplyResources(Me.cmdLoad, "cmdLoad")
			Me.cmdLoad.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.cmdLoad.Name = "cmdLoad"
			Me.HelpProvider1.SetShowHelp(Me.cmdLoad, Global.Microsoft.VisualBasic.CompilerServices.Conversions.ToBoolean(componentResourceManager.GetObject("cmdLoad.ShowHelp")))
			Me.cmdLoad.UseVisualStyleBackColor = False
			Me.cmdCancel.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdCancel.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cmdCancel.DialogResult = Global.System.Windows.Forms.DialogResult.Cancel
			componentResourceManager.ApplyResources(Me.cmdCancel, "cmdCancel")
			Me.cmdCancel.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.cmdCancel.Name = "cmdCancel"
			Me.HelpProvider1.SetShowHelp(Me.cmdCancel, Global.Microsoft.VisualBasic.CompilerServices.Conversions.ToBoolean(componentResourceManager.GetObject("cmdCancel.ShowHelp")))
			Me.cmdCancel.UseVisualStyleBackColor = False
			Me.cmdOK.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdOK.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			componentResourceManager.ApplyResources(Me.cmdOK, "cmdOK")
			Me.cmdOK.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.cmdOK.Name = "cmdOK"
			Me.HelpProvider1.SetShowHelp(Me.cmdOK, Global.Microsoft.VisualBasic.CompilerServices.Conversions.ToBoolean(componentResourceManager.GetObject("cmdOK.ShowHelp")))
			Me.cmdOK.UseVisualStyleBackColor = False
			Me._SSPanel_0.BackColor = Global.System.Drawing.SystemColors.Control
			Me._SSPanel_0.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me._SSPanel_0.Controls.Add(Me.chkIncludeRodString)
			Me._SSPanel_0.Controls.Add(Me.cmdRemove)
			Me._SSPanel_0.Controls.Add(Me.cmdInsert)
			Me._SSPanel_0.Controls.Add(Me.cmdAppend)
			Me._SSPanel_0.Controls.Add(Me.cmdMoveDown)
			Me._SSPanel_0.Controls.Add(Me.cmdMoveUp)
			Me._SSPanel_0.Controls.Add(Me._Label_3)
			Me._SSPanel_0.Controls.Add(Me._Label_0)
			Me._SSPanel_0.Controls.Add(Me._Label_2)
			Me._SSPanel_0.Controls.Add(Me._Label_1)
			Me._SSPanel_0.Controls.Add(Me.txtFormatName)
			Me._SSPanel_0.Controls.Add(Me.lstAvailable)
			Me._SSPanel_0.Controls.Add(Me.lstSelected)
			Me._SSPanel_0.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			componentResourceManager.ApplyResources(Me._SSPanel_0, "_SSPanel_0")
			Me._SSPanel_0.ForeColor = Global.System.Drawing.Color.Blue
			Me.SSPanel.SetIndex(Me._SSPanel_0, 0S)
			Me._SSPanel_0.Name = "_SSPanel_0"
			Me.HelpProvider1.SetShowHelp(Me._SSPanel_0, Global.Microsoft.VisualBasic.CompilerServices.Conversions.ToBoolean(componentResourceManager.GetObject("_SSPanel_0.ShowHelp")))
			Me._SSPanel_0.TabStop = True
			Me.chkIncludeRodString.ForeColor = Global.System.Drawing.Color.Black
			componentResourceManager.ApplyResources(Me.chkIncludeRodString, "chkIncludeRodString")
			Me.chkIncludeRodString.Name = "chkIncludeRodString"
			Me.HelpProvider1.SetShowHelp(Me.chkIncludeRodString, Global.Microsoft.VisualBasic.CompilerServices.Conversions.ToBoolean(componentResourceManager.GetObject("chkIncludeRodString.ShowHelp")))
			Me.cmdRemove.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdRemove.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			componentResourceManager.ApplyResources(Me.cmdRemove, "cmdRemove")
			Me.cmdRemove.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.HelpProvider1.SetHelpKeyword(Me.cmdRemove, componentResourceManager.GetString("cmdRemove.HelpKeyword"))
			Me.HelpProvider1.SetHelpNavigator(Me.cmdRemove, CType(Global.Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(componentResourceManager.GetObject("cmdRemove.HelpNavigator")), Global.System.Windows.Forms.HelpNavigator))
			Me.cmdRemove.Name = "cmdRemove"
			Me.HelpProvider1.SetShowHelp(Me.cmdRemove, Global.Microsoft.VisualBasic.CompilerServices.Conversions.ToBoolean(componentResourceManager.GetObject("cmdRemove.ShowHelp")))
			Me.cmdRemove.UseVisualStyleBackColor = False
			Me.cmdInsert.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdInsert.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			componentResourceManager.ApplyResources(Me.cmdInsert, "cmdInsert")
			Me.cmdInsert.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.HelpProvider1.SetHelpKeyword(Me.cmdInsert, componentResourceManager.GetString("cmdInsert.HelpKeyword"))
			Me.HelpProvider1.SetHelpNavigator(Me.cmdInsert, CType(Global.Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(componentResourceManager.GetObject("cmdInsert.HelpNavigator")), Global.System.Windows.Forms.HelpNavigator))
			Me.cmdInsert.Name = "cmdInsert"
			Me.HelpProvider1.SetShowHelp(Me.cmdInsert, Global.Microsoft.VisualBasic.CompilerServices.Conversions.ToBoolean(componentResourceManager.GetObject("cmdInsert.ShowHelp")))
			Me.cmdInsert.UseVisualStyleBackColor = False
			Me.cmdAppend.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdAppend.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			componentResourceManager.ApplyResources(Me.cmdAppend, "cmdAppend")
			Me.cmdAppend.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.HelpProvider1.SetHelpKeyword(Me.cmdAppend, componentResourceManager.GetString("cmdAppend.HelpKeyword"))
			Me.HelpProvider1.SetHelpNavigator(Me.cmdAppend, CType(Global.Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(componentResourceManager.GetObject("cmdAppend.HelpNavigator")), Global.System.Windows.Forms.HelpNavigator))
			Me.cmdAppend.Name = "cmdAppend"
			Me.HelpProvider1.SetShowHelp(Me.cmdAppend, Global.Microsoft.VisualBasic.CompilerServices.Conversions.ToBoolean(componentResourceManager.GetObject("cmdAppend.ShowHelp")))
			Me.cmdAppend.UseVisualStyleBackColor = False
			Me.cmdMoveDown.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdMoveDown.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			componentResourceManager.ApplyResources(Me.cmdMoveDown, "cmdMoveDown")
			Me.cmdMoveDown.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.HelpProvider1.SetHelpKeyword(Me.cmdMoveDown, componentResourceManager.GetString("cmdMoveDown.HelpKeyword"))
			Me.HelpProvider1.SetHelpNavigator(Me.cmdMoveDown, CType(Global.Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(componentResourceManager.GetObject("cmdMoveDown.HelpNavigator")), Global.System.Windows.Forms.HelpNavigator))
			Me.cmdMoveDown.Name = "cmdMoveDown"
			Me.HelpProvider1.SetShowHelp(Me.cmdMoveDown, Global.Microsoft.VisualBasic.CompilerServices.Conversions.ToBoolean(componentResourceManager.GetObject("cmdMoveDown.ShowHelp")))
			Me.cmdMoveDown.UseVisualStyleBackColor = False
			Me.cmdMoveUp.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdMoveUp.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			componentResourceManager.ApplyResources(Me.cmdMoveUp, "cmdMoveUp")
			Me.cmdMoveUp.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.HelpProvider1.SetHelpKeyword(Me.cmdMoveUp, componentResourceManager.GetString("cmdMoveUp.HelpKeyword"))
			Me.HelpProvider1.SetHelpNavigator(Me.cmdMoveUp, CType(Global.Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(componentResourceManager.GetObject("cmdMoveUp.HelpNavigator")), Global.System.Windows.Forms.HelpNavigator))
			Me.cmdMoveUp.Name = "cmdMoveUp"
			Me.HelpProvider1.SetShowHelp(Me.cmdMoveUp, Global.Microsoft.VisualBasic.CompilerServices.Conversions.ToBoolean(componentResourceManager.GetObject("cmdMoveUp.ShowHelp")))
			Me.cmdMoveUp.UseVisualStyleBackColor = False
			Me._Label_3.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_3.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			componentResourceManager.ApplyResources(Me._Label_3, "_Label_3")
			Me._Label_3.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.Label.SetIndex(Me._Label_3, 3S)
			Me._Label_3.Name = "_Label_3"
			Me.HelpProvider1.SetShowHelp(Me._Label_3, Global.Microsoft.VisualBasic.CompilerServices.Conversions.ToBoolean(componentResourceManager.GetObject("_Label_3.ShowHelp")))
			Me._Label_0.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_0.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			componentResourceManager.ApplyResources(Me._Label_0, "_Label_0")
			Me._Label_0.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.Label.SetIndex(Me._Label_0, 0S)
			Me._Label_0.Name = "_Label_0"
			Me.HelpProvider1.SetShowHelp(Me._Label_0, Global.Microsoft.VisualBasic.CompilerServices.Conversions.ToBoolean(componentResourceManager.GetObject("_Label_0.ShowHelp")))
			Me._Label_2.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_2.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			componentResourceManager.ApplyResources(Me._Label_2, "_Label_2")
			Me._Label_2.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.Label.SetIndex(Me._Label_2, 2S)
			Me._Label_2.Name = "_Label_2"
			Me.HelpProvider1.SetShowHelp(Me._Label_2, Global.Microsoft.VisualBasic.CompilerServices.Conversions.ToBoolean(componentResourceManager.GetObject("_Label_2.ShowHelp")))
			Me._Label_1.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_1.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			componentResourceManager.ApplyResources(Me._Label_1, "_Label_1")
			Me._Label_1.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.Label.SetIndex(Me._Label_1, 1S)
			Me._Label_1.Name = "_Label_1"
			Me.HelpProvider1.SetShowHelp(Me._Label_1, Global.Microsoft.VisualBasic.CompilerServices.Conversions.ToBoolean(componentResourceManager.GetObject("_Label_1.ShowHelp")))
			Me.txtFormatName.AcceptsReturn = True
			Me.txtFormatName.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtFormatName.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			componentResourceManager.ApplyResources(Me.txtFormatName, "txtFormatName")
			Me.txtFormatName.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.txtFormatName, componentResourceManager.GetString("txtFormatName.HelpKeyword"))
			Me.HelpProvider1.SetHelpNavigator(Me.txtFormatName, CType(Global.Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(componentResourceManager.GetObject("txtFormatName.HelpNavigator")), Global.System.Windows.Forms.HelpNavigator))
			Me.txtFormatName.Name = "txtFormatName"
			Me.HelpProvider1.SetShowHelp(Me.txtFormatName, Global.Microsoft.VisualBasic.CompilerServices.Conversions.ToBoolean(componentResourceManager.GetObject("txtFormatName.ShowHelp")))
			Me.lstAvailable.AllowDrop = True
			Me.lstAvailable.BackColor = Global.System.Drawing.SystemColors.Window
			Me.lstAvailable.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			componentResourceManager.ApplyResources(Me.lstAvailable, "lstAvailable")
			Me.lstAvailable.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.lstAvailable, componentResourceManager.GetString("lstAvailable.HelpKeyword"))
			Me.HelpProvider1.SetHelpNavigator(Me.lstAvailable, CType(Global.Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(componentResourceManager.GetObject("lstAvailable.HelpNavigator")), Global.System.Windows.Forms.HelpNavigator))
			Me.lstAvailable.Name = "lstAvailable"
			Me.HelpProvider1.SetShowHelp(Me.lstAvailable, Global.Microsoft.VisualBasic.CompilerServices.Conversions.ToBoolean(componentResourceManager.GetObject("lstAvailable.ShowHelp")))
			Me.lstAvailable.Sorted = True
			Me.lstSelected.AllowDrop = True
			Me.lstSelected.BackColor = Global.System.Drawing.SystemColors.Window
			Me.lstSelected.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			componentResourceManager.ApplyResources(Me.lstSelected, "lstSelected")
			Me.lstSelected.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.HelpProvider1.SetHelpKeyword(Me.lstSelected, componentResourceManager.GetString("lstSelected.HelpKeyword"))
			Me.HelpProvider1.SetHelpNavigator(Me.lstSelected, CType(Global.Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(componentResourceManager.GetObject("lstSelected.HelpNavigator")), Global.System.Windows.Forms.HelpNavigator))
			Me.lstSelected.Name = "lstSelected"
			Me.HelpProvider1.SetShowHelp(Me.lstSelected, Global.Microsoft.VisualBasic.CompilerServices.Conversions.ToBoolean(componentResourceManager.GetObject("lstSelected.ShowHelp")))
			Me.AcceptButton = Me.cmdOK
			componentResourceManager.ApplyResources(Me, "$this")
			Me.CancelButton = Me.cmdCancel
			Me.ControlBox = False
			Me.Controls.Add(Me.cmdHelp)
			Me.Controls.Add(Me.cmdLoad)
			Me.Controls.Add(Me.cmdCancel)
			Me.Controls.Add(Me.cmdOK)
			Me.Controls.Add(Me._SSPanel_0)
			Me.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedDialog
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "dlgWK1Setup"
			Me.HelpProvider1.SetShowHelp(Me, Global.Microsoft.VisualBasic.CompilerServices.Conversions.ToBoolean(componentResourceManager.GetObject("$this.ShowHelp")))
			Me._SSPanel_0.ResumeLayout(False)
			Me._SSPanel_0.PerformLayout()
			CType(Me.Label, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.SSPanel, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
		End Sub

		Private components As Global.System.ComponentModel.IContainer

		Public ToolTip1 As Global.System.Windows.Forms.ToolTip
	End Class
End Namespace
