Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Globalization
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports ChartFX.WinForms
Imports ChartFX.WinForms.Adornments
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	Friend Partial Class IPRPlot
		Inherits Form

		Private Overridable Property IPRReport As IPRReport
			Get
				Return Me._IPRReport
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As IPRReport)
				Me._IPRReport = value
			End Set
		End Property

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.IPRPlot_Load
			AddHandler MyBase.Activated, AddressOf Me.IPRPlot_Activated
			Me.bAfterFirstPaint = False
			If IPRPlot.m_vb6FormDefInstance Is Nothing Then
				If IPRPlot.m_InitializingDefInstance Then
					IPRPlot.m_vb6FormDefInstance = Me
				Else
					Try
						If Assembly.GetExecutingAssembly().EntryPoint.DeclaringType Is Me.[GetType]() Then
							IPRPlot.m_vb6FormDefInstance = Me
						End If
					Catch ex As Exception
					End Try
				End If
			End If
			Me.InitializeComponent()
		End Sub

		Public Overridable Property panCalc As Panel
			Get
				Return Me._panCalc
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._panCalc = value
			End Set
		End Property

		Friend Overridable Property panFluid As Label
			Get
				Return Me._panFluid
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._panFluid = value
			End Set
		End Property

		Public Overridable Property panWater As Label
			Get
				Return Me._panWater
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._panWater = value
			End Set
		End Property

		Public Overridable Property panOil As Label
			Get
				Return Me._panOil
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._panOil = value
			End Set
		End Property

		Public Overridable Property panPi As Label
			Get
				Return Me._panPi
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._panPi = value
			End Set
		End Property

		Public Overridable Property panPwf As Label
			Get
				Return Me._panPwf
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._panPwf = value
			End Set
		End Property

		Public Overridable Property cmdPrint As Button
			Get
				Return Me._cmdPrint
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.cmdPrint_Click
				If Me._cmdPrint IsNot Nothing Then
					RemoveHandler Me._cmdPrint.Click, value2
				End If
				Me._cmdPrint = value
				If Me._cmdPrint IsNot Nothing Then
					AddHandler Me._cmdPrint.Click, value2
				End If
			End Set
		End Property

		Public Overridable Property cmdClose As Button
			Get
				Return Me._cmdClose
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.cmdClose_Click
				If Me._cmdClose IsNot Nothing Then
					RemoveHandler Me._cmdClose.Click, value2
				End If
				Me._cmdClose = value
				If Me._cmdClose IsNot Nothing Then
					AddHandler Me._cmdClose.Click, value2
				End If
			End Set
		End Property

		Public Overridable Property lblWaterUnits As Label
			Get
				Return Me._lblWaterUnits
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblWaterUnits = value
			End Set
		End Property

		Public Overridable Property lblPiUnits As Label
			Get
				Return Me._lblPiUnits
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblPiUnits = value
			End Set
		End Property

		Public Overridable Property lblOilUnits As Label
			Get
				Return Me._lblOilUnits
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblOilUnits = value
			End Set
		End Property

		Public Overridable Property lblFluidUnits As Label
			Get
				Return Me._lblFluidUnits
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblFluidUnits = value
			End Set
		End Property

		Public Overridable Property lblPwfUnits As Label
			Get
				Return Me._lblPwfUnits
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblPwfUnits = value
			End Set
		End Property

		Public Overridable Property panLines As Panel
			Get
				Return Me._panLines
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._panLines = value
			End Set
		End Property

		Public Overridable Property picIPR As Panel
			Get
				Return Me._picIPR
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._picIPR = value
			End Set
		End Property

		Public Overridable Property Label1 As Label
			Get
				Return Me._Label1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label1 = value
			End Set
		End Property

		Public Overridable Property SSFrame As GroupBox
			Get
				Return Me._SSFrame
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._SSFrame = value
			End Set
		End Property

		Public Overridable Property Shape1 As Label
			Get
				Return Me._Shape1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Shape1 = value
			End Set
		End Property

		Public Overridable Property _Label_5 As Label
			Get
				Return Me.__Label_5
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_5 = value
			End Set
		End Property

		Public Overridable Property _Label_8 As Label
			Get
				Return Me.__Label_8
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_8 = value
			End Set
		End Property

		Public Overridable Property _Label_7 As Label
			Get
				Return Me.__Label_7
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_7 = value
			End Set
		End Property

		Public Overridable Property _Label_6 As Label
			Get
				Return Me.__Label_6
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_6 = value
			End Set
		End Property

		Public Overridable Property _linLegend_2 As Label
			Get
				Return Me.__linLegend_2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__linLegend_2 = value
			End Set
		End Property

		Public Overridable Property _linLegend_1 As Label
			Get
				Return Me.__linLegend_1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__linLegend_1 = value
			End Set
		End Property

		Public Overridable Property _linLegend_0 As Label
			Get
				Return Me.__linLegend_0
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__linLegend_0 = value
			End Set
		End Property

		Public Overridable Property lblCorrelation As Label
			Get
				Return Me._lblCorrelation
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblCorrelation = value
			End Set
		End Property

		Friend Overridable Property ChartFX_IPR As Chart
			Get
				Return Me._ChartFX_IPR
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Chart)
				Dim value2 As CustomPaintEventHandler = AddressOf Me.ChartFX_IPR_PrePaint
				Dim value3 As HitTestEventHandler = AddressOf Me.Handle_MouseMove
				Dim value4 As HitTestEventHandler = AddressOf Me.Handle_MouseUp
				Dim value5 As HitTestEventHandler = AddressOf Me.Handle_MouseDown
				If Me._ChartFX_IPR IsNot Nothing Then
					RemoveHandler Me._ChartFX_IPR.PrePaint, value2
					RemoveHandler Me._ChartFX_IPR.MouseMove, value3
					RemoveHandler Me._ChartFX_IPR.MouseUp, value4
					RemoveHandler Me._ChartFX_IPR.MouseDown, value5
				End If
				Me._ChartFX_IPR = value
				If Me._ChartFX_IPR IsNot Nothing Then
					AddHandler Me._ChartFX_IPR.PrePaint, value2
					AddHandler Me._ChartFX_IPR.MouseMove, value3
					AddHandler Me._ChartFX_IPR.MouseUp, value4
					AddHandler Me._ChartFX_IPR.MouseDown, value5
				End If
			End Set
		End Property

		Friend Overridable Property pnlIPR As Panel
			Get
				Return Me._pnlIPR
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._pnlIPR = value
			End Set
		End Property

		Public Overridable Property lblOil As Label
			Get
				Return Me._lblOil
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblOil = value
			End Set
		End Property

		Public Overridable Property lblWater As Label
			Get
				Return Me._lblWater
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblWater = value
			End Set
		End Property

		Public Overridable Property lblFluid As Label
			Get
				Return Me._lblFluid
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblFluid = value
			End Set
		End Property

		Public Overridable Property lblPWF As Label
			Get
				Return Me._lblPWF
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblPWF = value
			End Set
		End Property

		Public Overridable Property lblPI As Label
			Get
				Return Me._lblPI
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblPI = value
			End Set
		End Property

		Public Shared Property DefInstance As IPRPlot
			Get
				If IPRPlot.m_vb6FormDefInstance Is Nothing OrElse IPRPlot.m_vb6FormDefInstance.IsDisposed Then
					IPRPlot.m_InitializingDefInstance = True
					IPRPlot.m_vb6FormDefInstance = New IPRPlot()
					IPRPlot.m_InitializingDefInstance = False
				End If
				Return IPRPlot.m_vb6FormDefInstance
			End Get
			Set(value As IPRPlot)
				IPRPlot.m_vb6FormDefInstance = value
			End Set
		End Property

		Public Function CalculateIPR(ByRef Pwf As Single, bConvert As Boolean) As Boolean
			Dim result As Boolean = True
			Dim flag As Boolean = RSWIN_DESC.SETUP_MeasurementSystem = 1
			If Not flag AndAlso bConvert Then
				Pwf = Pwf * 1F / RSWIN_DESC.PSI__KPA
			End If
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			If Pwf > Me.PwfMax Then
				Pwf = Me.PwfMax
				result = False
			ElseIf Pwf < Me.PwfMin Then
				Pwf = Me.PwfMin
				result = False
			End If
			Dim value As Single = IPR.iprPipFromPwf(Pwf)
			Dim num As Single = IPR.iprProductionFromPwf(Pwf)
			Dim num2 As Single = (rst.StaticBHPressure - Pwf) * rst.WaterPI
			Dim value2 As Single = num + num2
			Dim panPwf As Label = Me.panPwf
			Dim num3 As Single = CtrlUI.ConvertUnits(Pwf, 7)
			panPwf.Text = Util.Format(num3, Me.sFmtPressure)
			Dim panPi As Label = Me.panPi
			num3 = CtrlUI.ConvertUnits(value, 7)
			panPi.Text = Util.Format(num3, Me.sFmtPressure)
			Dim panOil As Label = Me.panOil
			num3 = CtrlUI.ConvertUnits(num, 0)
			Dim text As String = "####.##"
			panOil.Text = Util.Format(num3, text)
			Dim panWater As Label = Me.panWater
			num3 = CtrlUI.ConvertUnits(num2, 0)
			panWater.Text = Util.Format(num3, Me.sFmtProduction)
			Dim panFluid As Label = Me.panFluid
			num3 = CtrlUI.ConvertUnits(value2, 0)
			panFluid.Text = Util.Format(num3, Me.sFmtProduction)
			If Not flag AndAlso bConvert Then
				Pwf = CtrlUI.ConvertUnits(Pwf, 7)
			End If
			Return result
		End Function

		Private Sub cmdClose_Click(eventSender As Object, eventArgs As EventArgs)
			Me.Close()
		End Sub

		Private Sub cmdPrint_Click(eventSender As Object, eventArgs As EventArgs)
			Util.BusyCursor()
			Dim iprreport As IPRReport
			Me.PrintIPRPlot(iprreport, 0, 0, True)
			Util.UnbusyCursor()
		End Sub

		Public Sub PrintIPRPlot(ByRef myIPRReport As IPRReport, Optional iPage As Integer = 0, Optional nPages As Integer = 0, Optional bPrint As Boolean = False)
			myIPRReport = New IPRReport()
			Me.ChartFX_IPR.Export(FileFormat.Bitmap)
			myIPRReport.Header1 = Me.Label1.Text
			myIPRReport.Header2 = Me.lblCorrelation.Text
			myIPRReport.PBP = String.Concat(New String() { Me.lblPWF.Text, " : ", Me.panPwf.Text, " ", Me.lblPwfUnits.Text })
			myIPRReport.PIP = String.Concat(New String() { Me.lblPI.Text, " : ", Me.panPi.Text, " ", Me.lblPiUnits.Text })
			myIPRReport.OBPD = String.Concat(New String() { Me.lblOil.Text, " : ", Me.panOil.Text, " ", Me.lblOilUnits.Text })
			myIPRReport.WBPD = String.Concat(New String() { Me.lblWater.Text, " : ", Me.panWater.Text, " ", Me.lblWaterUnits.Text })
			myIPRReport.FBPD = String.Concat(New String() { Me.lblFluid.Text, " : ", Me.panFluid.Text, " ", Me.lblFluidUnits.Text })
			myIPRReport.ImportIPRChart()
			myIPRReport.ThisPageNumber = iPage
			myIPRReport.TotalPageNumber = nPages
			myIPRReport.bPrint = bPrint
			myIPRReport.Run(False)
			If bPrint Then
				myIPRReport.Document.Print(False, False)
				Return
			End If
		End Sub

		Private Sub DrawIPRCurves()
			Dim array As Single(,) = New Single(2, 50) {}
			Dim array2 As Single(,) = New Single(2, 50) {}
			IPR.iprSetup()
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			Dim value As Single = 0F
			Dim value2 As Single = IPR.iprProductionFromPwf(Me.PwfMin) + (rst.StaticBHPressure - Me.PwfMin) * rst.WaterPI
			Dim num As Single = CtrlUI.ConvertUnits(value, 0)
			Dim num2 As Single = CtrlUI.ConvertUnits(value2, 0)
			Me.PwfMin = IPR.iprPwfFromPip(rst.CasingPressure)
			Me.PwfMax = rst.StaticBHPressure
			Dim num3 As Single = CtrlUI.ConvertUnits(Me.PwfMin, 7)
			Dim num4 As Single = CtrlUI.ConvertUnits(Me.PwfMax, 7)
			Dim num5 As Single = 0F
			Dim num6 As Single = 0F
			Dim num7 As Single = 0F
			Dim num8 As Single = CtrlUI.ConvertUnits(rst.StaticBHPressure, 7)
			array(0, 0) = num5
			array2(0, 0) = num8
			array(1, 0) = num6
			array2(1, 0) = num8
			array(2, 0) = num7
			array2(2, 0) = num8
			Dim red As Color = Color.Red
			Dim blue As Color = Color.Blue
			Dim green As Color = Color.Green
			Dim num9 As Short = 1S
			Do
				' The following expression was wrapped in a checked-expression
				Dim num10 As Single = Me.PwfMin + CSng((50S - num9)) * (Me.PwfMax - Me.PwfMin) / 50F
				Dim num11 As Single = CtrlUI.ConvertUnits(IPR.iprProductionFromPwf(num10), 0)
				Dim num12 As Single = CtrlUI.ConvertUnits((rst.StaticBHPressure - num10) * rst.WaterPI, 0)
				Dim num13 As Single = num12 + num11
				num10 = CtrlUI.ConvertUnits(num10, 7)
				array(0, CInt(num9)) = num11
				array2(0, CInt(num9)) = num10
				array(1, CInt(num9)) = num12
				array2(1, CInt(num9)) = num10
				array(2, CInt(num9)) = num13
				array2(2, CInt(num9)) = num10
				num9 += 1S
			Loop While num9 <= 50S
			Dim chart As Chart = Me.ChartFX_IPR
			Try
				chart.Series.Clear()
				chart.LegendBox.CustomItems.Clear()
			Catch ex As Exception
			End Try
			chart.Data.Clear()
			chart.LegendBox.Visible = True
			Dim legendItemAttributes As LegendItemAttributes = New LegendItemAttributes()
			legendItemAttributes.Visible = False
			chart.LegendBox.ItemAttributes(chart.Series) = legendItemAttributes
			Dim customLegendItem As CustomLegendItem = New CustomLegendItem()
			customLegendItem.Text = "Oil"
			customLegendItem.Color = Color.Red
			customLegendItem.MarkerShape = MarkerShape.HorizontalLine
			customLegendItem.Border.Effect = BorderEffect.None
			chart.LegendBox.CustomItems.Add(customLegendItem)
			Dim customLegendItem2 As CustomLegendItem = New CustomLegendItem()
			customLegendItem2.Text = "Water"
			customLegendItem2.Color = Color.Blue
			customLegendItem2.MarkerShape = MarkerShape.HorizontalLine
			customLegendItem2.Border.Effect = BorderEffect.None
			chart.LegendBox.CustomItems.Add(customLegendItem2)
			Dim customLegendItem3 As CustomLegendItem = New CustomLegendItem()
			customLegendItem3.Text = "Fluid"
			customLegendItem3.Color = Color.Green
			customLegendItem3.MarkerShape = MarkerShape.HorizontalLine
			customLegendItem3.Border.Effect = BorderEffect.None
			chart.LegendBox.CustomItems.Add(customLegendItem3)
			Dim customLegendItem4 As CustomLegendItem = New CustomLegendItem()
			customLegendItem4.Text = "Current Design"
			customLegendItem4.Color = Color.DarkGray
			customLegendItem4.MarkerShape = MarkerShape.HorizontalLine
			customLegendItem4.Border.Effect = BorderEffect.None
			chart.LegendBox.CustomItems.Add(customLegendItem4)
			Dim customLegendItem5 As CustomLegendItem = New CustomLegendItem()
			customLegendItem5.Text = "Test Points"
			customLegendItem5.Color = Color.DarkGray
			customLegendItem5.MarkerShape = MarkerShape.Rect
			customLegendItem5.Border.Effect = BorderEffect.None
			chart.LegendBox.CustomItems.Add(customLegendItem5)
			chart.LegendBox.Border = DockBorder.None
			chart.LegendBox.Dock = DockArea.Right
			chart.LegendBox.Visible = True
			Dim text As String = Conversions.ToString(Operators.AddObject("Production ", Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem = 1, "(BPD)", "(m³/D)")))
			chart.AxisX.Title.Text = text
			chart.AxisX.Title.Alignment = StringAlignment.Center
			chart.AxisX.Title.Font = New Font("Arial", 10F, FontStyle.Bold)
			text = "(Correlation: "
			Dim rst2 As cRODSTAR
			Dim num14 As Single
			Select Case RSWIN_DESC.rst.giIPRMethod
				Case 0S
					Dim str As String = text
					Dim str2 As String = "Fetkovich, N="
					rst2 = RSWIN_DESC.rst
					num14 = rst2.FetkovichN
					Dim text2 As String = "0.000"
					Dim str3 As String = Util.Format(num14, text2)
					rst2.FetkovichN = num14
					text = str + str2 + str3 + ")"
				Case 1S
					text += "Vogel)"
				Case Else
					text += "Unknown)"
			End Select
			Me.lblCorrelation.Text = text
			text = Conversions.ToString(Operators.AddObject("Flowing bottomhole pressure ", Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem = 1, "(psi)", "(kPa)")))
			chart.AxisY.Title.Text = text
			chart.AxisY.Title.Alignment = StringAlignment.Center
			chart.AxisY.Title.Font = New Font("Arial", 10F, FontStyle.Bold)
			Dim series As Integer = 5
			Dim points As Integer = 50
			chart.Refresh()
			chart.Data.Series = series
			chart.Data.Points = points
			chart.Series(0).Color = Color.Red
			chart.Series(1).Color = Color.Blue
			chart.Series(2).Color = Color.Green
			chart.Series(3).Color = Color.DarkGray
			chart.Series(4).Color = Color.DarkGray
			chart.Series(0).Line.Style = DashStyle.Solid
			chart.Series(1).Line.Style = DashStyle.Solid
			chart.Series(2).Line.Style = DashStyle.Solid
			chart.Series(3).Line.Style = DashStyle.Dot
			chart.Series(4).MarkerShape = MarkerShape.Rect
			chart.Series(0).Line.Width = 2S
			chart.Series(1).Line.Width = 2S
			chart.Series(2).Line.Width = 2S
			chart.Series(3).Line.Width = 2S
			chart.Series(4).MarkerSize = 3S
			Dim num15 As Single = -1000000F
			num9 = 0S
			Do
				Dim num16 As Short = 0S
				Do
					' The following expression was wrapped in a checked-statement
					Select Case num9
						Case 0S, 1S, 2S
							Dim num17 As Single = array2(CInt(num9), CInt(num16))
							Dim num18 As Single = array(CInt(num9), CInt(num16))
							chart.Data.X(CInt(num9), CInt(num16)) = CDbl(num18)
							If num18 > num15 Then
								num15 = num18
							End If
							chart.Data.Y(CInt(num9), CInt(num16)) = CDbl(num17)
						Case 3S, 4S
							If num16 < RSWIN_DESC.rst.gnTestPoints Then
								Dim num10 As Single = CtrlUI.ConvertUnits(RSWIN_DESC.rst.TestPoints(CInt((num16 + 1S))).Pwf, 7)
								Dim num13 As Single = CtrlUI.ConvertUnits(RSWIN_DESC.rst.TestPoints(CInt((num16 + 1S))).Production, 0)
								Dim num17 As Single = num10
								Dim num18 As Single = num13
								chart.Data.X(CInt(num9), CInt(num16)) = CDbl(num18)
								If num18 > num15 Then
									num15 = num18
								End If
								chart.Data.Y(CInt(num9), CInt(num16)) = CDbl(num17)
							Else
								chart.Data.Y(CInt(num9), CInt(num16)) = 1E+108
							End If
					End Select
					num16 += 1S
				Loop While num16 <= 50S
				num9 += 1S
			Loop While num9 <= 4S
			Dim axisX As AxisX = Me.ChartFX_IPR.AxisX
			axisX.Max = CDbl(num15) + CDbl(num15) * 0.1
			chart.Series(0).Visible = True
			chart.Series(1).Visible = True
			chart.Series(2).Visible = True
			chart.Series(3).Visible = True
			chart.Series(4).Visible = True
			chart = Nothing
			Me.ChartFX_IPR.Show()
			rst2 = RSWIN_DESC.rst
			num14 = rst2.UPumpIntakePressure
			Me.CalculateIPR(num14, False)
			rst2.UPumpIntakePressure = num14
		End Sub

		Private Sub IPRPlot_Load(eventSender As Object, eventArgs As EventArgs)
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
			SUPERPRO.NewCheckSentinel(True)
			RSWIN.GetMeasurementUnit()
			Util.BusyCursor()
			Me.LoadIPRPlot()
			Util.Message(RSWIN_DESC.sNull)
			Util.UnbusyCursor()
			If RSWIN_DESC.bRodStarD Then
				Me.Icon = RSWIN_DESC.RodstarD_Icon
			ElseIf Not RSWIN_DESC.bExpert Then
				Me.Icon = RSWIN_DESC.RodstarV_Icon
			Else
				Me.Icon = Me.ParentForm.Icon
			End If
		End Sub

		Public Sub LoadIPRPlot()
			Dim setup_MeasurementSystem As Integer = RSWIN_DESC.SETUP_MeasurementSystem
			If setup_MeasurementSystem = 1 Then
				Me.lblPwfUnits.Text = "psi"
				Me.lblPiUnits.Text = "psi"
				Me.lblOilUnits.Text = "BPD"
				Me.lblWaterUnits.Text = "BPD"
				Me.lblFluidUnits.Text = "BPD"
				Me.sFmtPressure = "0"
				Me.sFmtProduction = "0"
			Else
				Me.lblPwfUnits.Text = "kPa"
				Me.lblPiUnits.Text = "kPa"
				Me.lblOilUnits.Text = "m³/D"
				Me.lblWaterUnits.Text = "m³/D"
				Me.lblFluidUnits.Text = "m³/D"
				Me.sFmtPressure = "0"
				Me.sFmtProduction = "0.0#"
			End If
			Select Case RSWIN_DESC.rst.giIPRMethod
				Case 0S
					Me.lblCorrelation.Text = "(Correlation: Fetkovich)"
				Case 1S
					Me.lblCorrelation.Text = "(Correlation: Vogel)"
				Case Else
					Me.lblCorrelation.Text = "(Correlation: Unknown)"
			End Select
			Me.bAfterFirstPaint = False
			Me.DrawIPRCurves()
			Me.bAfterFirstPaint = True
		End Sub

		Public Sub AddConstantLine()
			Me.newValue = IPR.iprPwfFromPip(RSWIN_DESC.rst.PumpIntakePressure)
			Dim num As Single = Me.newValue
			If num < Me.PwfMin Then
				Me.newValue = Me.PwfMin
			ElseIf num > Me.PwfMax Then
				Me.newValue = Me.PwfMax
			End If
			Me.PressureLine = New CustomGridLine()
			Me.newValue = CtrlUI.ConvertUnits(Me.newValue, 7)
			Dim pressureLine As CustomGridLine = Me.PressureLine
			pressureLine.Style = DashStyle.Solid
			pressureLine.Value = CDbl(Me.newValue)
			pressureLine.Color = Color.Cyan
			pressureLine.Width = 1
			Me.ChartFX_IPR.AxisY.CustomGridLines.Add(Me.PressureLine)
			Me.ChartFX_IPR.Refresh()
			Me.CalculateIPR(Me.newValue, True)
		End Sub

		Private Sub Handle_MouseDown(sender As Object, e As HitTestEventArgs)
			Me.CurrentX = CSng(e.X)
			Me.CurrentY = CSng(e.Y)
			If Math.Abs(e.Y - Me.ChartFX_IPR.AxisY.ValueToPixel(CDbl(Me.newValue))) < 3 Then
				Me.CurrentLine = 1
				Me.bMouseDown = True
			Else
				Me.CurrentLine = -1
				Me.bMouseDown = False
			End If
		End Sub

		Private Sub Handle_MouseUp(sender As Object, e As HitTestEventArgs)
			Me.bMouseDown = False
			Me.CurrentX = CSng(e.X)
			Me.CurrentY = CSng(e.Y)
			Dim currentLine As Integer = Me.CurrentLine
			If currentLine = 1 Then
				Dim pressureLine As CustomGridLine = Me.PressureLine
				pressureLine.Value = Me.ChartFX_IPR.AxisY.PixelToValue(CInt(Math.Round(CDbl(Me.CurrentY))))
				pressureLine.Color = Color.DarkGray
				pressureLine.Width = 1
				Me.newValue = CSng(Me.PressureLine.Value)
				If Not Me.CalculateIPR(Me.newValue, True) Then
					Me.PressureLine.Value = CDbl(Me.newValue)
				End If
				Me.ChartFX_IPR.AxisY.CustomGridLines.Add(Me.PressureLine)
			End If
			Me.ChartFX_IPR.Refresh()
			Me.CurrentLine = 0
		End Sub

		Private Sub Handle_MouseMove(sender As Object, e As HitTestEventArgs)
			Me.CurrentX = CSng(e.X)
			Me.CurrentY = CSng(e.Y)
			If Not Me.bMouseDown Then
				Me.CurrentLine = 0
				Cursor.Current = Cursors.[Default]
				If Math.Abs(e.Y - Me.ChartFX_IPR.AxisY.ValueToPixel(CDbl(Me.newValue))) < 3 Then
					Me.CurrentLine = 1
				Else
					Me.CurrentLine = -1
				End If
			End If
			Dim currentLine As Integer = Me.CurrentLine
			If currentLine = 1 Then
				If Me.bMouseDown Then
					Dim pressureLine As CustomGridLine = Me.PressureLine
					pressureLine.Value = Me.ChartFX_IPR.AxisY.PixelToValue(CInt(Math.Round(CDbl(Me.CurrentY))))
					pressureLine.Color = Color.Orange
					pressureLine.Width = 1
					Me.newValue = CSng(Me.PressureLine.Value)
					If Not Me.CalculateIPR(Me.newValue, True) Then
						Me.PressureLine.Value = CDbl(Me.newValue)
					End If
					Me.ChartFX_IPR.AxisY.CustomGridLines.Add(Me.PressureLine)
				End If
				Cursor.Current = Cursors.SizeNS
				Return
			End If
		End Sub

		Private Sub ChartFX_IPR_PrePaint(sender As Object, e As CustomPaintEventArgs)
			If Me.bAfterFirstPaint Then
				Me.bAfterFirstPaint = False
				Me.AddConstantLine()
				Application.DoEvents()
				Application.DoEvents()
				Application.DoEvents()
				Return
			End If
		End Sub

		Public Sub DisplayIPRPlot(ByRef myIPRReport As IPRReport, Optional iPage As Integer = 0, Optional nPages As Integer = 0, Optional bPrint As Boolean = False)
			myIPRReport = New IPRReport()
			myIPRReport.bPrint = bPrint
			Dim chartFX_IPR As Chart = Me.ChartFX_IPR
			RSWIN.ExportChartToClipboard(chartFX_IPR)
			Me.ChartFX_IPR = chartFX_IPR
			myIPRReport.Header1 = Me.Label1.Text
			myIPRReport.Header2 = Me.lblCorrelation.Text
			myIPRReport.PBP = String.Concat(New String() { Me.lblPWF.Text, " : ", Me.panPwf.Text, " ", Me.lblPwfUnits.Text })
			myIPRReport.PIP = String.Concat(New String() { Me.lblPI.Text, " : ", Me.panPi.Text, " ", Me.lblPiUnits.Text })
			myIPRReport.OBPD = String.Concat(New String() { Me.lblOil.Text, " : ", Me.panOil.Text, " ", Me.lblOilUnits.Text })
			myIPRReport.WBPD = String.Concat(New String() { Me.lblWater.Text, " : ", Me.panWater.Text, " ", Me.lblWaterUnits.Text })
			myIPRReport.FBPD = String.Concat(New String() { Me.lblFluid.Text, " : ", Me.panFluid.Text, " ", Me.lblFluidUnits.Text })
			myIPRReport.ImportIPRChart()
			myIPRReport.ThisPageNumber = iPage
			myIPRReport.TotalPageNumber = nPages
			myIPRReport.Run(False)
			If bPrint Then
				myIPRReport.Document.Print(False, False)
				Return
			End If
		End Sub

		Private Sub IPRPlot_Activated(sender As Object, e As EventArgs)
			RSWIN.GetMeasurementUnit()
		End Sub

		<AccessedThroughProperty("IPRReport")>
		Private _IPRReport As IPRReport

		<AccessedThroughProperty("panCalc")>
		Private _panCalc As Panel

		<AccessedThroughProperty("panFluid")>
		Private _panFluid As Label

		<AccessedThroughProperty("panWater")>
		Private _panWater As Label

		<AccessedThroughProperty("panOil")>
		Private _panOil As Label

		<AccessedThroughProperty("panPi")>
		Private _panPi As Label

		<AccessedThroughProperty("panPwf")>
		Private _panPwf As Label

		<AccessedThroughProperty("cmdPrint")>
		Private _cmdPrint As Button

		<AccessedThroughProperty("cmdClose")>
		Private _cmdClose As Button

		<AccessedThroughProperty("lblWaterUnits")>
		Private _lblWaterUnits As Label

		<AccessedThroughProperty("lblPiUnits")>
		Private _lblPiUnits As Label

		<AccessedThroughProperty("lblOilUnits")>
		Private _lblOilUnits As Label

		<AccessedThroughProperty("lblFluidUnits")>
		Private _lblFluidUnits As Label

		<AccessedThroughProperty("lblPwfUnits")>
		Private _lblPwfUnits As Label

		<AccessedThroughProperty("panLines")>
		Private _panLines As Panel

		<AccessedThroughProperty("picIPR")>
		Private _picIPR As Panel

		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		<AccessedThroughProperty("SSFrame")>
		Private _SSFrame As GroupBox

		<AccessedThroughProperty("Shape1")>
		Private _Shape1 As Label

		<AccessedThroughProperty("_Label_5")>
		Private __Label_5 As Label

		<AccessedThroughProperty("_Label_8")>
		Private __Label_8 As Label

		<AccessedThroughProperty("_Label_7")>
		Private __Label_7 As Label

		<AccessedThroughProperty("_Label_6")>
		Private __Label_6 As Label

		<AccessedThroughProperty("_linLegend_2")>
		Private __linLegend_2 As Label

		<AccessedThroughProperty("_linLegend_1")>
		Private __linLegend_1 As Label

		<AccessedThroughProperty("_linLegend_0")>
		Private __linLegend_0 As Label

		<AccessedThroughProperty("lblCorrelation")>
		Private _lblCorrelation As Label

		<AccessedThroughProperty("ChartFX_IPR")>
		Private _ChartFX_IPR As Chart

		<AccessedThroughProperty("pnlIPR")>
		Private _pnlIPR As Panel

		<AccessedThroughProperty("lblOil")>
		Private _lblOil As Label

		<AccessedThroughProperty("lblWater")>
		Private _lblWater As Label

		<AccessedThroughProperty("lblFluid")>
		Private _lblFluid As Label

		<AccessedThroughProperty("lblPWF")>
		Private _lblPWF As Label

		<AccessedThroughProperty("lblPI")>
		Private _lblPI As Label

		Private Shared m_vb6FormDefInstance As IPRPlot

		Private Shared m_InitializingDefInstance As Boolean

		Private Const PUMPCOLOR As Short = 9S

		Private Const XTICLENGTH As Double = 0.03

		Private Const YTICLENGTH As Double = 0.02

		Private bMovingLine As Short

		Private bOverLine As Short

		Private PwfMin As Single

		Private PwfMax As Single

		Private sFmtPressure As String

		Private sFmtProduction As String

		Private dXAxisScale As Single

		Private dYAxisScale As Single

		Private origX As Single

		Private origX1 As Single

		Private origY As Single

		Private origY1 As Single

		Private max As Single

		Private min As Single

		Private lmax As Single

		Private lmin As Single

		Private majorStep As Single

		Private minorStep As Single

		Private bOKClicked As Short

		Private bAfterFirstPaint As Boolean

		Private PressureLine As CustomGridLine

		Private CurrentX As Single

		Private CurrentY As Single

		Private bMouseDown As Boolean

		Private newValue As Single

		Private CurrentLine As Integer
	End Class
End Namespace
