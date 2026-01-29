Namespace RSWINV3
	Public Partial Class frmDevSettings
		Inherits Global.System.Windows.Forms.Form

		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.RSWINV3.frmDevSettings))
			Me.GroupBox1 = New Global.System.Windows.Forms.GroupBox()
			Me.GroupBox2 = New Global.System.Windows.Forms.GroupBox()
			Me.txtPumpDragDownstrokeMax = New Global.System.Windows.Forms.TextBox()
			Me.txtPumpDragUpstrokeMax = New Global.System.Windows.Forms.TextBox()
			Me.txtFluidDamping = New Global.System.Windows.Forms.TextBox()
			Me._Label_12 = New Global.System.Windows.Forms.Label()
			Me._Label_11 = New Global.System.Windows.Forms.Label()
			Me._Label_10 = New Global.System.Windows.Forms.Label()
			Me._fraPumpDrag_2 = New Global.System.Windows.Forms.GroupBox()
			Me._optPolishedRodDrag_0 = New Global.System.Windows.Forms.RadioButton()
			Me._optPolishedRodDrag_1 = New Global.System.Windows.Forms.RadioButton()
			Me._optPolishedRodDrag_2 = New Global.System.Windows.Forms.RadioButton()
			Me._fraPumpDrag_1 = New Global.System.Windows.Forms.GroupBox()
			Me._optPumpDragDown_0 = New Global.System.Windows.Forms.RadioButton()
			Me._optPumpDragDown_1 = New Global.System.Windows.Forms.RadioButton()
			Me._optPumpDragDown_2 = New Global.System.Windows.Forms.RadioButton()
			Me._fraPumpDrag_0 = New Global.System.Windows.Forms.GroupBox()
			Me._optPumpDragUp_2 = New Global.System.Windows.Forms.RadioButton()
			Me._optPumpDragUp_1 = New Global.System.Windows.Forms.RadioButton()
			Me._optPumpDragUp_0 = New Global.System.Windows.Forms.RadioButton()
			Me.cmdCancel = New Global.System.Windows.Forms.Button()
			Me.cmdOK = New Global.System.Windows.Forms.Button()
			Me.GroupBox1.SuspendLayout()
			Me.GroupBox2.SuspendLayout()
			Me._fraPumpDrag_2.SuspendLayout()
			Me._fraPumpDrag_1.SuspendLayout()
			Me._fraPumpDrag_0.SuspendLayout()
			Me.SuspendLayout()
			Me.GroupBox1.Controls.Add(Me.GroupBox2)
			Me.GroupBox1.Controls.Add(Me._fraPumpDrag_2)
			Me.GroupBox1.Controls.Add(Me._fraPumpDrag_1)
			Me.GroupBox1.Controls.Add(Me._fraPumpDrag_0)
			Dim groupBox As Global.System.Windows.Forms.Control = Me.GroupBox1
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(10, 9)
			groupBox.Location = location
			Me.GroupBox1.Name = "GroupBox1"
			Dim groupBox2 As Global.System.Windows.Forms.Control = Me.GroupBox1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(614, 333)
			groupBox2.Size = size
			Me.GroupBox1.TabIndex = 31
			Me.GroupBox1.TabStop = False
			Me.GroupBox2.Controls.Add(Me.txtPumpDragDownstrokeMax)
			Me.GroupBox2.Controls.Add(Me.txtPumpDragUpstrokeMax)
			Me.GroupBox2.Controls.Add(Me.txtFluidDamping)
			Me.GroupBox2.Controls.Add(Me._Label_12)
			Me.GroupBox2.Controls.Add(Me._Label_11)
			Me.GroupBox2.Controls.Add(Me._Label_10)
			Dim groupBox3 As Global.System.Windows.Forms.Control = Me.GroupBox2
			location = New Global.System.Drawing.Point(259, 28)
			groupBox3.Location = location
			Me.GroupBox2.Name = "GroupBox2"
			Dim groupBox4 As Global.System.Windows.Forms.Control = Me.GroupBox2
			size = New Global.System.Drawing.Size(346, 120)
			groupBox4.Size = size
			Me.GroupBox2.TabIndex = 40
			Me.GroupBox2.TabStop = False
			Me.txtPumpDragDownstrokeMax.AcceptsReturn = True
			Me.txtPumpDragDownstrokeMax.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtPumpDragDownstrokeMax.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtPumpDragDownstrokeMax.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.txtPumpDragDownstrokeMax.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Dim txtPumpDragDownstrokeMax As Global.System.Windows.Forms.Control = Me.txtPumpDragDownstrokeMax
			location = New Global.System.Drawing.Point(240, 83)
			txtPumpDragDownstrokeMax.Location = location
			Me.txtPumpDragDownstrokeMax.MaxLength = 10
			Me.txtPumpDragDownstrokeMax.Name = "txtPumpDragDownstrokeMax"
			Me.txtPumpDragDownstrokeMax.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim txtPumpDragDownstrokeMax2 As Global.System.Windows.Forms.Control = Me.txtPumpDragDownstrokeMax
			size = New Global.System.Drawing.Size(73, 24)
			txtPumpDragDownstrokeMax2.Size = size
			Me.txtPumpDragDownstrokeMax.TabIndex = 41
			Me.txtPumpDragDownstrokeMax.Tag = "lee"
			Me.txtPumpDragUpstrokeMax.AcceptsReturn = True
			Me.txtPumpDragUpstrokeMax.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtPumpDragUpstrokeMax.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtPumpDragUpstrokeMax.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.txtPumpDragUpstrokeMax.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Dim txtPumpDragUpstrokeMax As Global.System.Windows.Forms.Control = Me.txtPumpDragUpstrokeMax
			location = New Global.System.Drawing.Point(240, 55)
			txtPumpDragUpstrokeMax.Location = location
			Me.txtPumpDragUpstrokeMax.MaxLength = 10
			Me.txtPumpDragUpstrokeMax.Name = "txtPumpDragUpstrokeMax"
			Me.txtPumpDragUpstrokeMax.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim txtPumpDragUpstrokeMax2 As Global.System.Windows.Forms.Control = Me.txtPumpDragUpstrokeMax
			size = New Global.System.Drawing.Size(73, 25)
			txtPumpDragUpstrokeMax2.Size = size
			Me.txtPumpDragUpstrokeMax.TabIndex = 40
			Me.txtPumpDragUpstrokeMax.Tag = "lee"
			Me.txtFluidDamping.AcceptsReturn = True
			Me.txtFluidDamping.BackColor = Global.System.Drawing.SystemColors.Window
			Me.txtFluidDamping.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.txtFluidDamping.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me.txtFluidDamping.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Dim txtFluidDamping As Global.System.Windows.Forms.Control = Me.txtFluidDamping
			location = New Global.System.Drawing.Point(240, 28)
			txtFluidDamping.Location = location
			Me.txtFluidDamping.MaxLength = 10
			Me.txtFluidDamping.Name = "txtFluidDamping"
			Me.txtFluidDamping.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim txtFluidDamping2 As Global.System.Windows.Forms.Control = Me.txtFluidDamping
			size = New Global.System.Drawing.Size(73, 24)
			txtFluidDamping2.Size = size
			Me.txtFluidDamping.TabIndex = 39
			Me._Label_12.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_12.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_12.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._Label_12.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._Label_12.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label_ As Global.System.Windows.Forms.Control = Me._Label_12
			location = New Global.System.Drawing.Point(10, 83)
			label_.Location = location
			Me._Label_12.Name = "_Label_12"
			Me._Label_12.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim label_2 As Global.System.Windows.Forms.Control = Me._Label_12
			size = New Global.System.Drawing.Size(220, 15)
			label_2.Size = size
			Me._Label_12.TabIndex = 44
			Me._Label_12.Tag = "Max downstroke pump drag (^):"
			Me._Label_12.Text = "Max downstroke pump drag (lbs):"
			Me._Label_12.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me._Label_11.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_11.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_11.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._Label_11.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._Label_11.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label_3 As Global.System.Windows.Forms.Control = Me._Label_11
			location = New Global.System.Drawing.Point(10, 55)
			label_3.Location = location
			Me._Label_11.Name = "_Label_11"
			Me._Label_11.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim label_4 As Global.System.Windows.Forms.Control = Me._Label_11
			size = New Global.System.Drawing.Size(220, 15)
			label_4.Size = size
			Me._Label_11.TabIndex = 43
			Me._Label_11.Tag = "Max upstroke pump drag (^):"
			Me._Label_11.Text = "Max upstroke pump drag (lbs):"
			Me._Label_11.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me._Label_10.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_10.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_10.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._Label_10.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._Label_10.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim label_5 As Global.System.Windows.Forms.Control = Me._Label_10
			location = New Global.System.Drawing.Point(10, 28)
			label_5.Location = location
			Me._Label_10.Name = "_Label_10"
			Me._Label_10.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim label_6 As Global.System.Windows.Forms.Control = Me._Label_10
			size = New Global.System.Drawing.Size(220, 15)
			label_6.Size = size
			Me._Label_10.TabIndex = 42
			Me._Label_10.Text = "Fluid damping:"
			Me._Label_10.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me._fraPumpDrag_2.BackColor = Global.System.Drawing.SystemColors.Control
			Me._fraPumpDrag_2.Controls.Add(Me._optPolishedRodDrag_0)
			Me._fraPumpDrag_2.Controls.Add(Me._optPolishedRodDrag_1)
			Me._fraPumpDrag_2.Controls.Add(Me._optPolishedRodDrag_2)
			Me._fraPumpDrag_2.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._fraPumpDrag_2.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Dim fraPumpDrag_ As Global.System.Windows.Forms.Control = Me._fraPumpDrag_2
			location = New Global.System.Drawing.Point(19, 222)
			fraPumpDrag_.Location = location
			Me._fraPumpDrag_2.Name = "_fraPumpDrag_2"
			Me._fraPumpDrag_2.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim fraPumpDrag_2 As Global.System.Windows.Forms.Control = Me._fraPumpDrag_2
			size = New Global.System.Drawing.Size(231, 92)
			fraPumpDrag_2.Size = size
			Me._fraPumpDrag_2.TabIndex = 39
			Me._fraPumpDrag_2.TabStop = False
			Me._fraPumpDrag_2.Text = "Polished rod drag is:"
			Me._optPolishedRodDrag_0.BackColor = Global.System.Drawing.SystemColors.Control
			Me._optPolishedRodDrag_0.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._optPolishedRodDrag_0.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._optPolishedRodDrag_0.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._optPolishedRodDrag_0.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim optPolishedRodDrag_ As Global.System.Windows.Forms.Control = Me._optPolishedRodDrag_0
			location = New Global.System.Drawing.Point(8, 22)
			optPolishedRodDrag_.Location = location
			Me._optPolishedRodDrag_0.Name = "_optPolishedRodDrag_0"
			Me._optPolishedRodDrag_0.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim optPolishedRodDrag_2 As Global.System.Windows.Forms.Control = Me._optPolishedRodDrag_0
			size = New Global.System.Drawing.Size(203, 18)
			optPolishedRodDrag_2.Size = size
			Me._optPolishedRodDrag_0.TabIndex = 7
			Me._optPolishedRodDrag_0.TabStop = True
			Me._optPolishedRodDrag_0.Text = "Constant"
			Me._optPolishedRodDrag_0.UseVisualStyleBackColor = False
			Me._optPolishedRodDrag_1.BackColor = Global.System.Drawing.SystemColors.Control
			Me._optPolishedRodDrag_1.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._optPolishedRodDrag_1.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._optPolishedRodDrag_1.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._optPolishedRodDrag_1.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim optPolishedRodDrag_3 As Global.System.Windows.Forms.Control = Me._optPolishedRodDrag_1
			location = New Global.System.Drawing.Point(8, 43)
			optPolishedRodDrag_3.Location = location
			Me._optPolishedRodDrag_1.Name = "_optPolishedRodDrag_1"
			Me._optPolishedRodDrag_1.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim optPolishedRodDrag_4 As Global.System.Windows.Forms.Control = Me._optPolishedRodDrag_1
			size = New Global.System.Drawing.Size(203, 18)
			optPolishedRodDrag_4.Size = size
			Me._optPolishedRodDrag_1.TabIndex = 8
			Me._optPolishedRodDrag_1.TabStop = True
			Me._optPolishedRodDrag_1.Text = "Proportional to velocity"
			Me._optPolishedRodDrag_1.UseVisualStyleBackColor = False
			Me._optPolishedRodDrag_2.BackColor = Global.System.Drawing.SystemColors.Control
			Me._optPolishedRodDrag_2.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._optPolishedRodDrag_2.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._optPolishedRodDrag_2.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._optPolishedRodDrag_2.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim optPolishedRodDrag_5 As Global.System.Windows.Forms.Control = Me._optPolishedRodDrag_2
			location = New Global.System.Drawing.Point(8, 63)
			optPolishedRodDrag_5.Location = location
			Me._optPolishedRodDrag_2.Name = "_optPolishedRodDrag_2"
			Me._optPolishedRodDrag_2.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim optPolishedRodDrag_6 As Global.System.Windows.Forms.Control = Me._optPolishedRodDrag_2
			size = New Global.System.Drawing.Size(203, 19)
			optPolishedRodDrag_6.Size = size
			Me._optPolishedRodDrag_2.TabIndex = 9
			Me._optPolishedRodDrag_2.TabStop = True
			Me._optPolishedRodDrag_2.Text = "Proportional to velocity^2"
			Me._optPolishedRodDrag_2.UseVisualStyleBackColor = False
			Me._fraPumpDrag_1.BackColor = Global.System.Drawing.SystemColors.Control
			Me._fraPumpDrag_1.Controls.Add(Me._optPumpDragDown_0)
			Me._fraPumpDrag_1.Controls.Add(Me._optPumpDragDown_1)
			Me._fraPumpDrag_1.Controls.Add(Me._optPumpDragDown_2)
			Me._fraPumpDrag_1.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._fraPumpDrag_1.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Dim fraPumpDrag_3 As Global.System.Windows.Forms.Control = Me._fraPumpDrag_1
			location = New Global.System.Drawing.Point(19, 120)
			fraPumpDrag_3.Location = location
			Me._fraPumpDrag_1.Name = "_fraPumpDrag_1"
			Me._fraPumpDrag_1.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim fraPumpDrag_4 As Global.System.Windows.Forms.Control = Me._fraPumpDrag_1
			size = New Global.System.Drawing.Size(231, 92)
			fraPumpDrag_4.Size = size
			Me._fraPumpDrag_1.TabIndex = 35
			Me._fraPumpDrag_1.TabStop = False
			Me._fraPumpDrag_1.Text = "Downstroke pump drag is:"
			Me._optPumpDragDown_0.BackColor = Global.System.Drawing.SystemColors.Control
			Me._optPumpDragDown_0.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._optPumpDragDown_0.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._optPumpDragDown_0.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._optPumpDragDown_0.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim optPumpDragDown_ As Global.System.Windows.Forms.Control = Me._optPumpDragDown_0
			location = New Global.System.Drawing.Point(8, 22)
			optPumpDragDown_.Location = location
			Me._optPumpDragDown_0.Name = "_optPumpDragDown_0"
			Me._optPumpDragDown_0.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim optPumpDragDown_2 As Global.System.Windows.Forms.Control = Me._optPumpDragDown_0
			size = New Global.System.Drawing.Size(203, 18)
			optPumpDragDown_2.Size = size
			Me._optPumpDragDown_0.TabIndex = 4
			Me._optPumpDragDown_0.TabStop = True
			Me._optPumpDragDown_0.Text = "Constant"
			Me._optPumpDragDown_0.UseVisualStyleBackColor = False
			Me._optPumpDragDown_1.BackColor = Global.System.Drawing.SystemColors.Control
			Me._optPumpDragDown_1.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._optPumpDragDown_1.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._optPumpDragDown_1.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._optPumpDragDown_1.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim optPumpDragDown_3 As Global.System.Windows.Forms.Control = Me._optPumpDragDown_1
			location = New Global.System.Drawing.Point(8, 43)
			optPumpDragDown_3.Location = location
			Me._optPumpDragDown_1.Name = "_optPumpDragDown_1"
			Me._optPumpDragDown_1.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim optPumpDragDown_4 As Global.System.Windows.Forms.Control = Me._optPumpDragDown_1
			size = New Global.System.Drawing.Size(203, 18)
			optPumpDragDown_4.Size = size
			Me._optPumpDragDown_1.TabIndex = 5
			Me._optPumpDragDown_1.TabStop = True
			Me._optPumpDragDown_1.Text = "Proportional to velocity"
			Me._optPumpDragDown_1.UseVisualStyleBackColor = False
			Me._optPumpDragDown_2.BackColor = Global.System.Drawing.SystemColors.Control
			Me._optPumpDragDown_2.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._optPumpDragDown_2.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._optPumpDragDown_2.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._optPumpDragDown_2.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim optPumpDragDown_5 As Global.System.Windows.Forms.Control = Me._optPumpDragDown_2
			location = New Global.System.Drawing.Point(8, 63)
			optPumpDragDown_5.Location = location
			Me._optPumpDragDown_2.Name = "_optPumpDragDown_2"
			Me._optPumpDragDown_2.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim optPumpDragDown_6 As Global.System.Windows.Forms.Control = Me._optPumpDragDown_2
			size = New Global.System.Drawing.Size(203, 19)
			optPumpDragDown_6.Size = size
			Me._optPumpDragDown_2.TabIndex = 6
			Me._optPumpDragDown_2.TabStop = True
			Me._optPumpDragDown_2.Text = "Proportional to velocity^2"
			Me._optPumpDragDown_2.UseVisualStyleBackColor = False
			Me._fraPumpDrag_0.BackColor = Global.System.Drawing.SystemColors.Control
			Me._fraPumpDrag_0.Controls.Add(Me._optPumpDragUp_2)
			Me._fraPumpDrag_0.Controls.Add(Me._optPumpDragUp_1)
			Me._fraPumpDrag_0.Controls.Add(Me._optPumpDragUp_0)
			Me._fraPumpDrag_0.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._fraPumpDrag_0.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Dim fraPumpDrag_5 As Global.System.Windows.Forms.Control = Me._fraPumpDrag_0
			location = New Global.System.Drawing.Point(19, 28)
			fraPumpDrag_5.Location = location
			Me._fraPumpDrag_0.Name = "_fraPumpDrag_0"
			Me._fraPumpDrag_0.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim fraPumpDrag_6 As Global.System.Windows.Forms.Control = Me._fraPumpDrag_0
			size = New Global.System.Drawing.Size(231, 92)
			fraPumpDrag_6.Size = size
			Me._fraPumpDrag_0.TabIndex = 34
			Me._fraPumpDrag_0.TabStop = False
			Me._fraPumpDrag_0.Text = "Upstroke pump drag is:"
			Me._optPumpDragUp_2.BackColor = Global.System.Drawing.SystemColors.Control
			Me._optPumpDragUp_2.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._optPumpDragUp_2.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._optPumpDragUp_2.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._optPumpDragUp_2.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim optPumpDragUp_ As Global.System.Windows.Forms.Control = Me._optPumpDragUp_2
			location = New Global.System.Drawing.Point(8, 63)
			optPumpDragUp_.Location = location
			Me._optPumpDragUp_2.Name = "_optPumpDragUp_2"
			Me._optPumpDragUp_2.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim optPumpDragUp_2 As Global.System.Windows.Forms.Control = Me._optPumpDragUp_2
			size = New Global.System.Drawing.Size(203, 19)
			optPumpDragUp_2.Size = size
			Me._optPumpDragUp_2.TabIndex = 3
			Me._optPumpDragUp_2.TabStop = True
			Me._optPumpDragUp_2.Text = "Proportional to velocity^2"
			Me._optPumpDragUp_2.UseVisualStyleBackColor = False
			Me._optPumpDragUp_1.BackColor = Global.System.Drawing.SystemColors.Control
			Me._optPumpDragUp_1.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._optPumpDragUp_1.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._optPumpDragUp_1.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._optPumpDragUp_1.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim optPumpDragUp_3 As Global.System.Windows.Forms.Control = Me._optPumpDragUp_1
			location = New Global.System.Drawing.Point(8, 43)
			optPumpDragUp_3.Location = location
			Me._optPumpDragUp_1.Name = "_optPumpDragUp_1"
			Me._optPumpDragUp_1.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim optPumpDragUp_4 As Global.System.Windows.Forms.Control = Me._optPumpDragUp_1
			size = New Global.System.Drawing.Size(203, 18)
			optPumpDragUp_4.Size = size
			Me._optPumpDragUp_1.TabIndex = 2
			Me._optPumpDragUp_1.TabStop = True
			Me._optPumpDragUp_1.Text = "Proportional to velocity"
			Me._optPumpDragUp_1.UseVisualStyleBackColor = False
			Me._optPumpDragUp_0.BackColor = Global.System.Drawing.SystemColors.Control
			Me._optPumpDragUp_0.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._optPumpDragUp_0.Font = New Global.System.Drawing.Font("Arial", 8F)
			Me._optPumpDragUp_0.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me._optPumpDragUp_0.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim optPumpDragUp_5 As Global.System.Windows.Forms.Control = Me._optPumpDragUp_0
			location = New Global.System.Drawing.Point(8, 22)
			optPumpDragUp_5.Location = location
			Me._optPumpDragUp_0.Name = "_optPumpDragUp_0"
			Me._optPumpDragUp_0.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim optPumpDragUp_6 As Global.System.Windows.Forms.Control = Me._optPumpDragUp_0
			size = New Global.System.Drawing.Size(203, 18)
			optPumpDragUp_6.Size = size
			Me._optPumpDragUp_0.TabIndex = 1
			Me._optPumpDragUp_0.TabStop = True
			Me._optPumpDragUp_0.Text = "Constant"
			Me._optPumpDragUp_0.UseVisualStyleBackColor = False
			Me.cmdCancel.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdCancel As Global.System.Windows.Forms.Control = Me.cmdCancel
			location = New Global.System.Drawing.Point(643, 55)
			cmdCancel.Location = location
			Me.cmdCancel.Name = "cmdCancel"
			Dim cmdCancel2 As Global.System.Windows.Forms.Control = Me.cmdCancel
			size = New Global.System.Drawing.Size(87, 28)
			cmdCancel2.Size = size
			Me.cmdCancel.TabIndex = 33
			Me.cmdCancel.Text = "&Cancel"
			Me.cmdOK.ImeMode = Global.System.Windows.Forms.ImeMode.NoControl
			Dim cmdOK As Global.System.Windows.Forms.Control = Me.cmdOK
			location = New Global.System.Drawing.Point(643, 18)
			cmdOK.Location = location
			Me.cmdOK.Name = "cmdOK"
			Dim cmdOK2 As Global.System.Windows.Forms.Control = Me.cmdOK
			size = New Global.System.Drawing.Size(87, 28)
			cmdOK2.Size = size
			Me.cmdOK.TabIndex = 32
			Me.cmdOK.Text = "&OK"
			size = New Global.System.Drawing.Size(6, 15)
			Me.AutoScaleBaseSize = size
			size = New Global.System.Drawing.Size(753, 338)
			Me.ClientSize = size
			Me.ControlBox = False
			Me.Controls.Add(Me.cmdCancel)
			Me.Controls.Add(Me.cmdOK)
			Me.Controls.Add(Me.GroupBox1)
			Me.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "frmDevSettings"
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Deviation Settings"
			Me.GroupBox1.ResumeLayout(False)
			Me.GroupBox2.ResumeLayout(False)
			Me._fraPumpDrag_2.ResumeLayout(False)
			Me._fraPumpDrag_1.ResumeLayout(False)
			Me._fraPumpDrag_0.ResumeLayout(False)
			Me.ResumeLayout(False)
		End Sub

		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
