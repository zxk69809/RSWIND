Namespace RSWINV3
	Friend Partial Class IPRPlot
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
			Dim border As Global.ChartFX.WinForms.Adornments.ImageBorder = New Global.ChartFX.WinForms.Adornments.ImageBorder(Global.ChartFX.WinForms.Adornments.ImageBorderType.Emboss)
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.RSWINV3.IPRPlot))
			Me.ToolTip1 = New Global.System.Windows.Forms.ToolTip(Me.components)
			Me.pnlIPR = New Global.System.Windows.Forms.Panel()
			Me.panCalc = New Global.System.Windows.Forms.Panel()
			Me.panFluid = New Global.System.Windows.Forms.Label()
			Me.panWater = New Global.System.Windows.Forms.Label()
			Me.panOil = New Global.System.Windows.Forms.Label()
			Me.panPi = New Global.System.Windows.Forms.Label()
			Me.panPwf = New Global.System.Windows.Forms.Label()
			Me.cmdPrint = New Global.System.Windows.Forms.Button()
			Me.cmdClose = New Global.System.Windows.Forms.Button()
			Me.lblOil = New Global.System.Windows.Forms.Label()
			Me.lblWater = New Global.System.Windows.Forms.Label()
			Me.lblFluid = New Global.System.Windows.Forms.Label()
			Me.lblPWF = New Global.System.Windows.Forms.Label()
			Me.lblPI = New Global.System.Windows.Forms.Label()
			Me.lblWaterUnits = New Global.System.Windows.Forms.Label()
			Me.lblPiUnits = New Global.System.Windows.Forms.Label()
			Me.lblOilUnits = New Global.System.Windows.Forms.Label()
			Me.lblFluidUnits = New Global.System.Windows.Forms.Label()
			Me.lblPwfUnits = New Global.System.Windows.Forms.Label()
			Me.panLines = New Global.System.Windows.Forms.Panel()
			Me.picIPR = New Global.System.Windows.Forms.Panel()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.SSFrame = New Global.System.Windows.Forms.GroupBox()
			Me.Shape1 = New Global.System.Windows.Forms.Label()
			Me._Label_5 = New Global.System.Windows.Forms.Label()
			Me._Label_8 = New Global.System.Windows.Forms.Label()
			Me._Label_7 = New Global.System.Windows.Forms.Label()
			Me._Label_6 = New Global.System.Windows.Forms.Label()
			Me._linLegend_2 = New Global.System.Windows.Forms.Label()
			Me._linLegend_1 = New Global.System.Windows.Forms.Label()
			Me._linLegend_0 = New Global.System.Windows.Forms.Label()
			Me.lblCorrelation = New Global.System.Windows.Forms.Label()
			Me.ChartFX_IPR = New Global.ChartFX.WinForms.Chart()
			Me.pnlIPR.SuspendLayout()
			Me.panCalc.SuspendLayout()
			Me.panLines.SuspendLayout()
			Me.picIPR.SuspendLayout()
			Me.SSFrame.SuspendLayout()
			CType(Me.ChartFX_IPR, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			Me.ToolTip1.ShowAlways = True
			Me.pnlIPR.Controls.Add(Me.panCalc)
			Me.pnlIPR.Controls.Add(Me.panLines)
			Dim pnlIPR As Global.System.Windows.Forms.Control = Me.pnlIPR
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(8, 8)
			pnlIPR.Location = location
			Me.pnlIPR.Name = "pnlIPR"
			Dim pnlIPR2 As Global.System.Windows.Forms.Control = Me.pnlIPR
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(768, 600)
			pnlIPR2.Size = size
			Me.pnlIPR.TabIndex = 0
			Me.panCalc.BackColor = Global.System.Drawing.SystemColors.Control
			Me.panCalc.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.panCalc.Controls.Add(Me.panFluid)
			Me.panCalc.Controls.Add(Me.panWater)
			Me.panCalc.Controls.Add(Me.panOil)
			Me.panCalc.Controls.Add(Me.panPi)
			Me.panCalc.Controls.Add(Me.panPwf)
			Me.panCalc.Controls.Add(Me.cmdPrint)
			Me.panCalc.Controls.Add(Me.cmdClose)
			Me.panCalc.Controls.Add(Me.lblOil)
			Me.panCalc.Controls.Add(Me.lblWater)
			Me.panCalc.Controls.Add(Me.lblFluid)
			Me.panCalc.Controls.Add(Me.lblPWF)
			Me.panCalc.Controls.Add(Me.lblPI)
			Me.panCalc.Controls.Add(Me.lblWaterUnits)
			Me.panCalc.Controls.Add(Me.lblPiUnits)
			Me.panCalc.Controls.Add(Me.lblOilUnits)
			Me.panCalc.Controls.Add(Me.lblFluidUnits)
			Me.panCalc.Controls.Add(Me.lblPwfUnits)
			Me.panCalc.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.panCalc.Font = New Global.System.Drawing.Font("Arial", 8F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.panCalc.ForeColor = Global.System.Drawing.Color.Blue
			Dim panCalc As Global.System.Windows.Forms.Control = Me.panCalc
			location = New Global.System.Drawing.Point(16, 480)
			panCalc.Location = location
			Me.panCalc.Name = "panCalc"
			Me.panCalc.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim panCalc2 As Global.System.Windows.Forms.Control = Me.panCalc
			size = New Global.System.Drawing.Size(744, 112)
			panCalc2.Size = size
			Me.panCalc.TabIndex = 4
			Me.panCalc.TabStop = True
			Me.panFluid.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.panFluid.ForeColor = Global.System.Drawing.Color.Black
			Dim panFluid As Global.System.Windows.Forms.Control = Me.panFluid
			location = New Global.System.Drawing.Point(448, 69)
			panFluid.Location = location
			Me.panFluid.Name = "panFluid"
			Dim panFluid2 As Global.System.Windows.Forms.Control = Me.panFluid
			size = New Global.System.Drawing.Size(67, 20)
			panFluid2.Size = size
			Me.panFluid.TabIndex = 32
			Me.panFluid.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.panWater.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.panWater.ForeColor = Global.System.Drawing.Color.Black
			Dim panWater As Global.System.Windows.Forms.Control = Me.panWater
			location = New Global.System.Drawing.Point(448, 43)
			panWater.Location = location
			Me.panWater.Name = "panWater"
			Dim panWater2 As Global.System.Windows.Forms.Control = Me.panWater
			size = New Global.System.Drawing.Size(67, 20)
			panWater2.Size = size
			Me.panWater.TabIndex = 31
			Me.panWater.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.panOil.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.panOil.ForeColor = Global.System.Drawing.Color.Black
			Dim panOil As Global.System.Windows.Forms.Control = Me.panOil
			location = New Global.System.Drawing.Point(448, 17)
			panOil.Location = location
			Me.panOil.Name = "panOil"
			Dim panOil2 As Global.System.Windows.Forms.Control = Me.panOil
			size = New Global.System.Drawing.Size(67, 20)
			panOil2.Size = size
			Me.panOil.TabIndex = 30
			Me.panOil.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.panPi.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.panPi.ForeColor = Global.System.Drawing.Color.Black
			Dim panPi As Global.System.Windows.Forms.Control = Me.panPi
			location = New Global.System.Drawing.Point(194, 40)
			panPi.Location = location
			Me.panPi.Name = "panPi"
			Dim panPi2 As Global.System.Windows.Forms.Control = Me.panPi
			size = New Global.System.Drawing.Size(67, 20)
			panPi2.Size = size
			Me.panPi.TabIndex = 29
			Me.panPi.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.panPwf.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.panPwf.ForeColor = Global.System.Drawing.Color.Black
			Dim panPwf As Global.System.Windows.Forms.Control = Me.panPwf
			location = New Global.System.Drawing.Point(194, 16)
			panPwf.Location = location
			Me.panPwf.Name = "panPwf"
			Dim panPwf2 As Global.System.Windows.Forms.Control = Me.panPwf
			size = New Global.System.Drawing.Size(67, 20)
			panPwf2.Size = size
			Me.panPwf.TabIndex = 28
			Me.panPwf.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.cmdPrint.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdPrint.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cmdPrint.Font = New Global.System.Drawing.Font("Arial", 8F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.cmdPrint.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Dim cmdPrint As Global.System.Windows.Forms.Control = Me.cmdPrint
			location = New Global.System.Drawing.Point(600, 43)
			cmdPrint.Location = location
			Me.cmdPrint.Name = "cmdPrint"
			Me.cmdPrint.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim cmdPrint2 As Global.System.Windows.Forms.Control = Me.cmdPrint
			size = New Global.System.Drawing.Size(67, 23)
			cmdPrint2.Size = size
			Me.cmdPrint.TabIndex = 27
			Me.cmdPrint.TabStop = False
			Me.cmdPrint.Text = "Print"
			Me.cmdPrint.UseVisualStyleBackColor = False
			Me.cmdClose.BackColor = Global.System.Drawing.SystemColors.Control
			Me.cmdClose.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.cmdClose.Font = New Global.System.Drawing.Font("Arial", 8F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.cmdClose.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Dim cmdClose As Global.System.Windows.Forms.Control = Me.cmdClose
			location = New Global.System.Drawing.Point(600, 69)
			cmdClose.Location = location
			Me.cmdClose.Name = "cmdClose"
			Me.cmdClose.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim cmdClose2 As Global.System.Windows.Forms.Control = Me.cmdClose
			size = New Global.System.Drawing.Size(67, 23)
			cmdClose2.Size = size
			Me.cmdClose.TabIndex = 18
			Me.cmdClose.TabStop = False
			Me.cmdClose.Text = "Close"
			Me.cmdClose.UseVisualStyleBackColor = False
			Me.lblOil.BackColor = Global.System.Drawing.Color.Transparent
			Me.lblOil.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblOil.Font = New Global.System.Drawing.Font("Arial", 8F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblOil.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Dim lblOil As Global.System.Windows.Forms.Control = Me.lblOil
			location = New Global.System.Drawing.Point(368, 17)
			lblOil.Location = location
			Me.lblOil.Name = "lblOil"
			Me.lblOil.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim lblOil2 As Global.System.Windows.Forms.Control = Me.lblOil
			size = New Global.System.Drawing.Size(80, 13)
			lblOil2.Size = size
			Me.lblOil.TabIndex = 17
			Me.lblOil.Text = "Oil production"
			Me.lblOil.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me.lblWater.AutoSize = True
			Me.lblWater.BackColor = Global.System.Drawing.Color.Transparent
			Me.lblWater.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblWater.Font = New Global.System.Drawing.Font("Arial", 8F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblWater.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Dim lblWater As Global.System.Windows.Forms.Control = Me.lblWater
			location = New Global.System.Drawing.Point(344, 43)
			lblWater.Location = location
			Me.lblWater.Name = "lblWater"
			Me.lblWater.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim lblWater2 As Global.System.Windows.Forms.Control = Me.lblWater
			size = New Global.System.Drawing.Size(90, 14)
			lblWater2.Size = size
			Me.lblWater.TabIndex = 16
			Me.lblWater.Text = "Water production"
			Me.lblWater.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me.lblFluid.BackColor = Global.System.Drawing.Color.Transparent
			Me.lblFluid.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblFluid.Font = New Global.System.Drawing.Font("Arial", 8F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblFluid.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Dim lblFluid As Global.System.Windows.Forms.Control = Me.lblFluid
			location = New Global.System.Drawing.Point(328, 69)
			lblFluid.Location = location
			Me.lblFluid.Name = "lblFluid"
			Me.lblFluid.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim lblFluid2 As Global.System.Windows.Forms.Control = Me.lblFluid
			size = New Global.System.Drawing.Size(122, 13)
			lblFluid2.Size = size
			Me.lblFluid.TabIndex = 15
			Me.lblFluid.Text = "Total fluid production"
			Me.lblFluid.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me.lblPWF.AutoSize = True
			Me.lblPWF.BackColor = Global.System.Drawing.Color.Transparent
			Me.lblPWF.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblPWF.Font = New Global.System.Drawing.Font("Arial", 8F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblPWF.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Dim lblPWF As Global.System.Windows.Forms.Control = Me.lblPWF
			location = New Global.System.Drawing.Point(13, 17)
			lblPWF.Location = location
			Me.lblPWF.Name = "lblPWF"
			Me.lblPWF.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim lblPWF2 As Global.System.Windows.Forms.Control = Me.lblPWF
			size = New Global.System.Drawing.Size(157, 14)
			lblPWF2.Size = size
			Me.lblPWF.TabIndex = 14
			Me.lblPWF.Text = "Producing bottomhole pressure"
			Me.lblPWF.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me.lblPI.AutoSize = True
			Me.lblPI.BackColor = Global.System.Drawing.Color.Transparent
			Me.lblPI.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblPI.Font = New Global.System.Drawing.Font("Arial", 8F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblPI.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Dim lblPI As Global.System.Windows.Forms.Control = Me.lblPI
			location = New Global.System.Drawing.Point(67, 43)
			lblPI.Location = location
			Me.lblPI.Name = "lblPI"
			Me.lblPI.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim lblPI2 As Global.System.Windows.Forms.Control = Me.lblPI
			size = New Global.System.Drawing.Size(111, 14)
			lblPI2.Size = size
			Me.lblPI.TabIndex = 13
			Me.lblPI.Text = "Pump intake pressure"
			Me.lblPI.TextAlign = Global.System.Drawing.ContentAlignment.TopRight
			Me.lblWaterUnits.BackColor = Global.System.Drawing.Color.Transparent
			Me.lblWaterUnits.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblWaterUnits.Font = New Global.System.Drawing.Font("Arial", 8F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblWaterUnits.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Dim lblWaterUnits As Global.System.Windows.Forms.Control = Me.lblWaterUnits
			location = New Global.System.Drawing.Point(520, 43)
			lblWaterUnits.Location = location
			Me.lblWaterUnits.Name = "lblWaterUnits"
			Me.lblWaterUnits.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim lblWaterUnits2 As Global.System.Windows.Forms.Control = Me.lblWaterUnits
			size = New Global.System.Drawing.Size(35, 13)
			lblWaterUnits2.Size = size
			Me.lblWaterUnits.TabIndex = 12
			Me.lblWaterUnits.Text = "BPD"
			Me.lblPiUnits.BackColor = Global.System.Drawing.Color.Transparent
			Me.lblPiUnits.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblPiUnits.Font = New Global.System.Drawing.Font("Arial", 8F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblPiUnits.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Dim lblPiUnits As Global.System.Windows.Forms.Control = Me.lblPiUnits
			location = New Global.System.Drawing.Point(265, 43)
			lblPiUnits.Location = location
			Me.lblPiUnits.Name = "lblPiUnits"
			Me.lblPiUnits.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim lblPiUnits2 As Global.System.Windows.Forms.Control = Me.lblPiUnits
			size = New Global.System.Drawing.Size(35, 13)
			lblPiUnits2.Size = size
			Me.lblPiUnits.TabIndex = 11
			Me.lblPiUnits.Text = "psi"
			Me.lblOilUnits.BackColor = Global.System.Drawing.Color.Transparent
			Me.lblOilUnits.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblOilUnits.Font = New Global.System.Drawing.Font("Arial", 8F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblOilUnits.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Dim lblOilUnits As Global.System.Windows.Forms.Control = Me.lblOilUnits
			location = New Global.System.Drawing.Point(520, 17)
			lblOilUnits.Location = location
			Me.lblOilUnits.Name = "lblOilUnits"
			Me.lblOilUnits.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim lblOilUnits2 As Global.System.Windows.Forms.Control = Me.lblOilUnits
			size = New Global.System.Drawing.Size(35, 13)
			lblOilUnits2.Size = size
			Me.lblOilUnits.TabIndex = 10
			Me.lblOilUnits.Text = "BPD"
			Me.lblFluidUnits.BackColor = Global.System.Drawing.Color.Transparent
			Me.lblFluidUnits.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblFluidUnits.Font = New Global.System.Drawing.Font("Arial", 8F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblFluidUnits.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Dim lblFluidUnits As Global.System.Windows.Forms.Control = Me.lblFluidUnits
			location = New Global.System.Drawing.Point(520, 69)
			lblFluidUnits.Location = location
			Me.lblFluidUnits.Name = "lblFluidUnits"
			Me.lblFluidUnits.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim lblFluidUnits2 As Global.System.Windows.Forms.Control = Me.lblFluidUnits
			size = New Global.System.Drawing.Size(35, 13)
			lblFluidUnits2.Size = size
			Me.lblFluidUnits.TabIndex = 9
			Me.lblFluidUnits.Text = "BPD"
			Me.lblPwfUnits.BackColor = Global.System.Drawing.Color.Transparent
			Me.lblPwfUnits.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblPwfUnits.Font = New Global.System.Drawing.Font("Arial", 8F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblPwfUnits.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Dim lblPwfUnits As Global.System.Windows.Forms.Control = Me.lblPwfUnits
			location = New Global.System.Drawing.Point(265, 17)
			lblPwfUnits.Location = location
			Me.lblPwfUnits.Name = "lblPwfUnits"
			Me.lblPwfUnits.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim lblPwfUnits2 As Global.System.Windows.Forms.Control = Me.lblPwfUnits
			size = New Global.System.Drawing.Size(35, 13)
			lblPwfUnits2.Size = size
			Me.lblPwfUnits.TabIndex = 8
			Me.lblPwfUnits.Text = "psi"
			Me.panLines.BackColor = Global.System.Drawing.SystemColors.Control
			Me.panLines.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.panLines.Controls.Add(Me.picIPR)
			Me.panLines.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.panLines.Font = New Global.System.Drawing.Font("Arial", 8F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.panLines.ForeColor = Global.System.Drawing.Color.Black
			Dim panLines As Global.System.Windows.Forms.Control = Me.panLines
			location = New Global.System.Drawing.Point(16, 14)
			panLines.Location = location
			Me.panLines.Name = "panLines"
			Me.panLines.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim panLines2 As Global.System.Windows.Forms.Control = Me.panLines
			size = New Global.System.Drawing.Size(744, 458)
			panLines2.Size = size
			Me.panLines.TabIndex = 3
			Me.panLines.TabStop = True
			Me.picIPR.BackColor = Global.System.Drawing.SystemColors.Control
			Me.picIPR.Controls.Add(Me.Label1)
			Me.picIPR.Controls.Add(Me.SSFrame)
			Me.picIPR.Controls.Add(Me.lblCorrelation)
			Me.picIPR.Controls.Add(Me.ChartFX_IPR)
			Me.picIPR.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.picIPR.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.picIPR.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Dim picIPR As Global.System.Windows.Forms.Control = Me.picIPR
			location = New Global.System.Drawing.Point(8, 8)
			picIPR.Location = location
			Me.picIPR.Name = "picIPR"
			Me.picIPR.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim picIPR2 As Global.System.Windows.Forms.Control = Me.picIPR
			size = New Global.System.Drawing.Size(728, 440)
			picIPR2.Size = size
			Me.picIPR.TabIndex = 1
			Me.Label1.BackColor = Global.System.Drawing.Color.Transparent
			Me.Label1.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.Label1.Font = New Global.System.Drawing.Font("Arial", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label1.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Dim label As Global.System.Windows.Forms.Control = Me.Label1
			location = New Global.System.Drawing.Point(8, 8)
			label.Location = location
			Me.Label1.Name = "Label1"
			Me.Label1.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim label2 As Global.System.Windows.Forms.Control = Me.Label1
			size = New Global.System.Drawing.Size(712, 16)
			label2.Size = size
			Me.Label1.TabIndex = 23
			Me.Label1.Text = "Inflow Perfomance Relationship"
			Me.Label1.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
			Me.SSFrame.BackColor = Global.System.Drawing.SystemColors.Window
			Me.SSFrame.Controls.Add(Me.Shape1)
			Me.SSFrame.Controls.Add(Me._Label_5)
			Me.SSFrame.Controls.Add(Me._Label_8)
			Me.SSFrame.Controls.Add(Me._Label_7)
			Me.SSFrame.Controls.Add(Me._Label_6)
			Me.SSFrame.Controls.Add(Me._linLegend_2)
			Me.SSFrame.Controls.Add(Me._linLegend_1)
			Me.SSFrame.Controls.Add(Me._linLegend_0)
			Me.SSFrame.Font = New Global.System.Drawing.Font("Arial", 9.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.SSFrame.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Dim ssframe As Global.System.Windows.Forms.Control = Me.SSFrame
			location = New Global.System.Drawing.Point(-1333, 22)
			ssframe.Location = location
			Me.SSFrame.Name = "SSFrame"
			Me.SSFrame.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim ssframe2 As Global.System.Windows.Forms.Control = Me.SSFrame
			size = New Global.System.Drawing.Size(127, 104)
			ssframe2.Size = size
			Me.SSFrame.TabIndex = 22
			Me.SSFrame.TabStop = False
			Me.SSFrame.Text = "Legend"
			Me.Shape1.BackColor = Global.System.Drawing.Color.Transparent
			Me.Shape1.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Dim shape As Global.System.Windows.Forms.Control = Me.Shape1
			location = New Global.System.Drawing.Point(25, 86)
			shape.Location = location
			Me.Shape1.Name = "Shape1"
			Dim shape2 As Global.System.Windows.Forms.Control = Me.Shape1
			size = New Global.System.Drawing.Size(7, 7)
			shape2.Size = size
			Me.Shape1.TabIndex = 0
			Me._Label_5.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_5.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_5.Font = New Global.System.Drawing.Font("Arial", 9.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me._Label_5.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Dim label_ As Global.System.Windows.Forms.Control = Me._Label_5
			location = New Global.System.Drawing.Point(39, 82)
			label_.Location = location
			Me._Label_5.Name = "_Label_5"
			Me._Label_5.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim label_2 As Global.System.Windows.Forms.Control = Me._Label_5
			size = New Global.System.Drawing.Size(81, 16)
			label_2.Size = size
			Me._Label_5.TabIndex = 26
			Me._Label_5.Text = "Test point"
			Me._Label_8.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_8.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_8.Font = New Global.System.Drawing.Font("Arial", 9.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me._Label_8.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Dim label_3 As Global.System.Windows.Forms.Control = Me._Label_8
			location = New Global.System.Drawing.Point(38, 61)
			label_3.Location = location
			Me._Label_8.Name = "_Label_8"
			Me._Label_8.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim label_4 As Global.System.Windows.Forms.Control = Me._Label_8
			size = New Global.System.Drawing.Size(66, 16)
			label_4.Size = size
			Me._Label_8.TabIndex = 25
			Me._Label_8.Text = "Total fluid"
			Me._Label_7.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_7.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_7.Font = New Global.System.Drawing.Font("Arial", 9.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me._Label_7.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Dim label_5 As Global.System.Windows.Forms.Control = Me._Label_7
			location = New Global.System.Drawing.Point(38, 40)
			label_5.Location = location
			Me._Label_7.Name = "_Label_7"
			Me._Label_7.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim label_6 As Global.System.Windows.Forms.Control = Me._Label_7
			size = New Global.System.Drawing.Size(58, 16)
			label_6.Size = size
			Me._Label_7.TabIndex = 24
			Me._Label_7.Text = "Water"
			Me._Label_6.BackColor = Global.System.Drawing.Color.Transparent
			Me._Label_6.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me._Label_6.Font = New Global.System.Drawing.Font("Arial", 9.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me._Label_6.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Dim label_7 As Global.System.Windows.Forms.Control = Me._Label_6
			location = New Global.System.Drawing.Point(38, 19)
			label_7.Location = location
			Me._Label_6.Name = "_Label_6"
			Me._Label_6.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim label_8 As Global.System.Windows.Forms.Control = Me._Label_6
			size = New Global.System.Drawing.Size(50, 16)
			label_8.Size = size
			Me._Label_6.TabIndex = 23
			Me._Label_6.Text = "Oil"
			Me._linLegend_2.BackColor = Global.System.Drawing.Color.Black
			Dim linLegend_ As Global.System.Windows.Forms.Control = Me._linLegend_2
			location = New Global.System.Drawing.Point(9, 69)
			linLegend_.Location = location
			Me._linLegend_2.Name = "_linLegend_2"
			Dim linLegend_2 As Global.System.Windows.Forms.Control = Me._linLegend_2
			size = New Global.System.Drawing.Size(24, 1)
			linLegend_2.Size = size
			Me._linLegend_2.TabIndex = 27
			Me._linLegend_1.BackColor = Global.System.Drawing.Color.Blue
			Dim linLegend_3 As Global.System.Windows.Forms.Control = Me._linLegend_1
			location = New Global.System.Drawing.Point(9, 48)
			linLegend_3.Location = location
			Me._linLegend_1.Name = "_linLegend_1"
			Dim linLegend_4 As Global.System.Windows.Forms.Control = Me._linLegend_1
			size = New Global.System.Drawing.Size(24, 1)
			linLegend_4.Size = size
			Me._linLegend_1.TabIndex = 28
			Me._linLegend_0.BackColor = Global.System.Drawing.Color.FromArgb(128, 0, 0)
			Dim linLegend_5 As Global.System.Windows.Forms.Control = Me._linLegend_0
			location = New Global.System.Drawing.Point(9, 27)
			linLegend_5.Location = location
			Me._linLegend_0.Name = "_linLegend_0"
			Dim linLegend_6 As Global.System.Windows.Forms.Control = Me._linLegend_0
			size = New Global.System.Drawing.Size(24, 1)
			linLegend_6.Size = size
			Me._linLegend_0.TabIndex = 29
			Me.lblCorrelation.BackColor = Global.System.Drawing.Color.Transparent
			Me.lblCorrelation.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.lblCorrelation.Font = New Global.System.Drawing.Font("Arial", 9F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblCorrelation.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Dim lblCorrelation As Global.System.Windows.Forms.Control = Me.lblCorrelation
			location = New Global.System.Drawing.Point(8, 24)
			lblCorrelation.Location = location
			Me.lblCorrelation.Name = "lblCorrelation"
			Me.lblCorrelation.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim lblCorrelation2 As Global.System.Windows.Forms.Control = Me.lblCorrelation
			size = New Global.System.Drawing.Size(712, 16)
			lblCorrelation2.Size = size
			Me.lblCorrelation.TabIndex = 21
			Me.lblCorrelation.Text = "Correlation: Fetkovich"
			Me.lblCorrelation.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
			Me.ChartFX_IPR.AllSeries.MarkerShape = Global.ChartFX.WinForms.MarkerShape.None
			Me.ChartFX_IPR.AllSeries.MarkerSize = 4S
			Me.ChartFX_IPR.AxisX.Grids.Major.Visible = False
			Me.ChartFX_IPR.AxisY.Grids.Major.Visible = False
			Me.ChartFX_IPR.AxisY2.Visible = False
			Me.ChartFX_IPR.Border = border
			Dim chartFX_IPR As Global.System.Windows.Forms.Control = Me.ChartFX_IPR
			location = New Global.System.Drawing.Point(8, 48)
			chartFX_IPR.Location = location
			Me.ChartFX_IPR.Name = "ChartFX_IPR"
			Me.ChartFX_IPR.PlotAreaMargin.Bottom = 5
			Me.ChartFX_IPR.PlotAreaMargin.Left = 5
			Me.ChartFX_IPR.PlotAreaMargin.Right = 5
			Me.ChartFX_IPR.PlotAreaMargin.Top = 5
			Dim chartFX_IPR2 As Global.System.Windows.Forms.Control = Me.ChartFX_IPR
			size = New Global.System.Drawing.Size(720, 392)
			chartFX_IPR2.Size = size
			Me.ChartFX_IPR.TabIndex = 1
			size = New Global.System.Drawing.Size(6, 13)
			Me.AutoScaleBaseSize = size
			size = New Global.System.Drawing.Size(792, 629)
			Me.ClientSize = size
			Me.ControlBox = False
			Me.Controls.Add(Me.pnlIPR)
			Me.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.ForeColor = Global.System.Drawing.SystemColors.WindowText
			Me.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedDialog
			Me.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			location = New Global.System.Drawing.Point(185, 183)
			Me.Location = location
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "IPRPlot"
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "Inflow Performance"
			Me.pnlIPR.ResumeLayout(False)
			Me.panCalc.ResumeLayout(False)
			Me.panCalc.PerformLayout()
			Me.panLines.ResumeLayout(False)
			Me.picIPR.ResumeLayout(False)
			Me.picIPR.PerformLayout()
			Me.SSFrame.ResumeLayout(False)
			CType(Me.ChartFX_IPR, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
		End Sub

		Private components As Global.System.ComponentModel.IContainer

		Public ToolTip1 As Global.System.Windows.Forms.ToolTip
	End Class
End Namespace
