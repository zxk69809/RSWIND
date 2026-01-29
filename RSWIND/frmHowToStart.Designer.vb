Namespace RSWINV3
	Friend Partial Class frmHowToStart
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
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.RSWINV3.frmHowToStart))
			Me.ToolTip1 = New Global.System.Windows.Forms.ToolTip(Me.components)
			Me._Label_4 = New Global.System.Windows.Forms.Label()
			Me._imgTBButton_3 = New Global.System.Windows.Forms.PictureBox()
			Me._imgTBButton_2 = New Global.System.Windows.Forms.PictureBox()
			Me._imgTBButton_1 = New Global.System.Windows.Forms.PictureBox()
			Me._imgTBButton_0 = New Global.System.Windows.Forms.PictureBox()
			Me._Label_3 = New Global.System.Windows.Forms.Label()
			Me._Label_2 = New Global.System.Windows.Forms.Label()
			Me._Label_1 = New Global.System.Windows.Forms.Label()
			Me._Label_0 = New Global.System.Windows.Forms.Label()
			Me.Label = New Global.Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
			Me.picBox = New Global.System.Windows.Forms.PictureBox()
			CType(Me._imgTBButton_3, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me._imgTBButton_2, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me._imgTBButton_1, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me._imgTBButton_0, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.Label, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.picBox, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			Me.ToolTip1.ShowAlways = True
			Me._Label_4.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_4.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_4.Font = New Global.System.Drawing.Font("Arial", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me._Label_4.ForeColor = Global.System.Drawing.SystemColors.HighlightText
			Me._Label_4.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.Label.SetIndex(Me._Label_4, 4S)
			Dim label_ As Global.System.Windows.Forms.Control = Me._Label_4
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(8, 160)
			label_.Location = location
			Me._Label_4.Name = "_Label_4"
			Me._Label_4.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim label_2 As Global.System.Windows.Forms.Control = Me._Label_4
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(552, 21)
			label_2.Size = size
			Me._Label_4.TabIndex = 4
			Me._Label_4.Text = "To get help with any input data item, press the F1 key."
			Me._imgTBButton_3.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.None
			Me._imgTBButton_3.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._imgTBButton_3.Image = CType(componentResourceManager.GetObject("_imgTBButton_3.Image"), Global.System.Drawing.Image)
			Me._imgTBButton_3.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim imgTBButton_ As Global.System.Windows.Forms.Control = Me._imgTBButton_3
			location = New Global.System.Drawing.Point(532, 123)
			imgTBButton_.Location = location
			Me._imgTBButton_3.Name = "_imgTBButton_3"
			Dim imgTBButton_2 As Global.System.Windows.Forms.Control = Me._imgTBButton_3
			size = New Global.System.Drawing.Size(25, 23)
			imgTBButton_2.Size = size
			Me._imgTBButton_3.TabIndex = 5
			Me._imgTBButton_3.TabStop = False
			Me._imgTBButton_2.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.None
			Me._imgTBButton_2.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._imgTBButton_2.Image = CType(componentResourceManager.GetObject("_imgTBButton_2.Image"), Global.System.Drawing.Image)
			Me._imgTBButton_2.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim imgTBButton_3 As Global.System.Windows.Forms.Control = Me._imgTBButton_2
			location = New Global.System.Drawing.Point(532, 84)
			imgTBButton_3.Location = location
			Me._imgTBButton_2.Name = "_imgTBButton_2"
			Dim imgTBButton_4 As Global.System.Windows.Forms.Control = Me._imgTBButton_2
			size = New Global.System.Drawing.Size(25, 23)
			imgTBButton_4.Size = size
			Me._imgTBButton_2.TabIndex = 6
			Me._imgTBButton_2.TabStop = False
			Me._imgTBButton_1.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.None
			Me._imgTBButton_1.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._imgTBButton_1.Image = CType(componentResourceManager.GetObject("_imgTBButton_1.Image"), Global.System.Drawing.Image)
			Me._imgTBButton_1.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim imgTBButton_5 As Global.System.Windows.Forms.Control = Me._imgTBButton_1
			location = New Global.System.Drawing.Point(532, 44)
			imgTBButton_5.Location = location
			Me._imgTBButton_1.Name = "_imgTBButton_1"
			Dim imgTBButton_6 As Global.System.Windows.Forms.Control = Me._imgTBButton_1
			size = New Global.System.Drawing.Size(25, 23)
			imgTBButton_6.Size = size
			Me._imgTBButton_1.TabIndex = 7
			Me._imgTBButton_1.TabStop = False
			Me._imgTBButton_0.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.None
			Me._imgTBButton_0.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._imgTBButton_0.Image = CType(componentResourceManager.GetObject("_imgTBButton_0.Image"), Global.System.Drawing.Image)
			Me._imgTBButton_0.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim imgTBButton_7 As Global.System.Windows.Forms.Control = Me._imgTBButton_0
			location = New Global.System.Drawing.Point(532, 5)
			imgTBButton_7.Location = location
			Me._imgTBButton_0.Name = "_imgTBButton_0"
			Dim imgTBButton_8 As Global.System.Windows.Forms.Control = Me._imgTBButton_0
			size = New Global.System.Drawing.Size(25, 23)
			imgTBButton_8.Size = size
			Me._imgTBButton_0.TabIndex = 8
			Me._imgTBButton_0.TabStop = False
			Me._Label_3.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_3.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_3.Font = New Global.System.Drawing.Font("Arial", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me._Label_3.ForeColor = Global.System.Drawing.SystemColors.HighlightText
			Me._Label_3.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.Label.SetIndex(Me._Label_3, 3S)
			Dim label_3 As Global.System.Windows.Forms.Control = Me._Label_3
			location = New Global.System.Drawing.Point(8, 84)
			label_3.Location = location
			Me._Label_3.Name = "_Label_3"
			Me._Label_3.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim label_4 As Global.System.Windows.Forms.Control = Me._Label_3
			size = New Global.System.Drawing.Size(552, 21)
			label_4.Size = size
			Me._Label_3.TabIndex = 3
			Me._Label_3.Text = "To run calculations on the case, click the Run button."
			Me._Label_2.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_2.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_2.Font = New Global.System.Drawing.Font("Arial", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me._Label_2.ForeColor = Global.System.Drawing.SystemColors.HighlightText
			Me._Label_2.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.Label.SetIndex(Me._Label_2, 2S)
			Dim label_5 As Global.System.Windows.Forms.Control = Me._Label_2
			location = New Global.System.Drawing.Point(8, 123)
			label_5.Location = location
			Me._Label_2.Name = "_Label_2"
			Me._Label_2.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim label_6 As Global.System.Windows.Forms.Control = Me._Label_2
			size = New Global.System.Drawing.Size(552, 21)
			label_6.Size = size
			Me._Label_2.TabIndex = 2
			Me._Label_2.Text = "To open an existing case, click the Open button."
			Me._Label_1.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_1.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_1.Font = New Global.System.Drawing.Font("Arial", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me._Label_1.ForeColor = Global.System.Drawing.SystemColors.HighlightText
			Me._Label_1.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.Label.SetIndex(Me._Label_1, 1S)
			Dim label_7 As Global.System.Windows.Forms.Control = Me._Label_1
			location = New Global.System.Drawing.Point(8, 44)
			label_7.Location = location
			Me._Label_1.Name = "_Label_1"
			Me._Label_1.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim label_8 As Global.System.Windows.Forms.Control = Me._Label_1
			size = New Global.System.Drawing.Size(552, 21)
			label_8.Size = size
			Me._Label_1.TabIndex = 1
			Me._Label_1.Text = "After entering data for a window, click the Next Window button."
			Me._Label_0.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_0.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_0.Font = New Global.System.Drawing.Font("Arial", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me._Label_0.ForeColor = Global.System.Drawing.SystemColors.HighlightText
			Me._Label_0.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Me.Label.SetIndex(Me._Label_0, 0S)
			Dim label_9 As Global.System.Windows.Forms.Control = Me._Label_0
			location = New Global.System.Drawing.Point(8, 5)
			label_9.Location = location
			Me._Label_0.Name = "_Label_0"
			Me._Label_0.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim label_10 As Global.System.Windows.Forms.Control = Me._Label_0
			size = New Global.System.Drawing.Size(552, 21)
			label_10.Size = size
			Me._Label_0.TabIndex = 0
			Me._Label_0.Text = "To start a new case, click the New button on the toolbar."
			Dim picBox As Global.System.Windows.Forms.Control = Me.picBox
			location = New Global.System.Drawing.Point(233, 179)
			picBox.Location = location
			Me.picBox.Name = "picBox"
			Dim picBox2 As Global.System.Windows.Forms.Control = Me.picBox
			size = New Global.System.Drawing.Size(164, 188)
			picBox2.Size = size
			Me.picBox.TabIndex = 9
			Me.picBox.TabStop = False
			Me.picBox.Visible = False
			size = New Global.System.Drawing.Size(7, 16)
			Me.AutoScaleBaseSize = size
			size = New Global.System.Drawing.Size(671, 370)
			Me.ClientSize = size
			Me.ControlBox = False
			Me.Controls.Add(Me.picBox)
			Me.Controls.Add(Me._imgTBButton_3)
			Me.Controls.Add(Me._imgTBButton_2)
			Me.Controls.Add(Me._imgTBButton_1)
			Me.Controls.Add(Me._imgTBButton_0)
			Me.Controls.Add(Me._Label_4)
			Me.Controls.Add(Me._Label_3)
			Me.Controls.Add(Me._Label_2)
			Me.Controls.Add(Me._Label_1)
			Me.Controls.Add(Me._Label_0)
			Me.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedDialog
			location = New Global.System.Drawing.Point(284, 283)
			Me.Location = location
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "frmHowToStart"
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.Manual
			CType(Me._imgTBButton_3, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me._imgTBButton_2, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me._imgTBButton_1, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me._imgTBButton_0, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.Label, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.picBox, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
		End Sub

		Private components As Global.System.ComponentModel.IContainer

		Public ToolTip1 As Global.System.Windows.Forms.ToolTip
	End Class
End Namespace
