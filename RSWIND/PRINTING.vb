Imports System
Imports System.Drawing.Printing
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	Friend Module PRINTING
		Private Sub InitTorqueGraph(lMargin As Single, rMargin As Single, tMargin As Single, bMargin As Single, ByRef tcminpos As Short)
			If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
				PRINTING.tYAxisScale = RSWIN_DESC.MINLB__NM / 1000.0F
			Else
				PRINTING.tYAxisScale = 0.001F
			End If
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			PRINTING.PMax = rst.TotalTheta
			PRINTING.PMin = 0F
			PRINTING.lmax = rst.Tnet(0, 0)
			PRINTING.lmin = rst.Tnet(0, 0)
			tcminpos = 1S
			Dim num As Short = 0S
			Dim num2 As Short = rst.Ntsteps - 1S
			For num3 As Short = num To num2
				If rst.M(0) <> rst.M(1) Then
					If rst.Tnet(0, CInt(num3)) > PRINTING.lmax Then
						PRINTING.lmax = rst.Tnet(0, CInt(num3))
					End If
					If rst.Tnet(0, CInt(num3)) < PRINTING.lmin Then
						PRINTING.lmin = rst.Tnet(0, CInt(num3))
					End If
				End If
				If rst.Tnet(1, CInt(num3)) > PRINTING.lmax Then
					PRINTING.lmax = rst.Tnet(1, CInt(num3))
				End If
				If rst.Tnet(1, CInt(num3)) < PRINTING.lmin Then
					PRINTING.lmin = rst.Tnet(1, CInt(num3))
				End If
				If Not rst.UnknownM Then
					If rst.Tnet(2, CInt(num3)) > PRINTING.lmax Then
						PRINTING.lmax = rst.Tnet(2, CInt(num3))
					End If
					If rst.Tnet(2, CInt(num3)) < PRINTING.lmin Then
						PRINTING.lmin = rst.Tnet(2, CInt(num3))
					End If
				End If
				If rst.Thetac(CInt(num3)) < rst.Thetac(CInt(tcminpos)) Then
					tcminpos = num3
				End If
			Next
			If CDbl(PRINTING.lmax) < 1200.0 * CDbl(rst.PU.GearboxRating) Then
				PRINTING.lmax = CSng((1200.0 * CDbl(rst.PU.GearboxRating)))
			End If
			If CDbl(PRINTING.lmin) > -1200.0 * CDbl(rst.PU.GearboxRating) Then
				PRINTING.lmin = CSng((-1200.0 * CDbl(rst.PU.GearboxRating)))
			End If
			PRINTING.lmin_axis = PRINTING.lmin * PRINTING.tYAxisScale
			PRINTING.lmax_axis = PRINTING.lmax * PRINTING.tYAxisScale
			Dim num4 As Single
			If PRINTING.lmax > -PRINTING.lmin Then
				num4 = PRINTING.lmax_axis
			Else
				num4 = -PRINTING.lmin_axis
			End If
			PRINTING.ystep = 0.1F
			While True
				' The following expression was wrapped in a checked-expression
				Dim num5 As Integer = CInt(Math.Round(CDbl(Conversion.Int(num4 / PRINTING.ystep))))
				If 4 <= num5 And num5 <= 9 Then
					Exit While
				End If
				PRINTING.ystep *= 2.0F
				num5 = CInt(Math.Round(CDbl(Conversion.Int(num4 / PRINTING.ystep))))
				If 4 <= num5 And num5 <= 9 Then
					Exit While
				End If
				PRINTING.ystep = CSng((CDbl(PRINTING.ystep) * 2.5))
				num5 = CInt(Math.Round(CDbl(Conversion.Int(num4 / PRINTING.ystep))))
				If 4 <= num5 And num5 <= 9 Then
					Exit While
				End If
				PRINTING.ystep *= 2.0F
			End While
			PRINTING.lmax_axis = PRINTING.ystep * (Conversion.Int(num4 / PRINTING.ystep) + 1.0F)
			PRINTING.lmin_axis = -PRINTING.lmax_axis
			PRINTING.lmax = PRINTING.lmax_axis / PRINTING.tYAxisScale
			PRINTING.lmin = PRINTING.lmin_axis / PRINTING.tYAxisScale
			PRINTING.PScaleMax = PRINTING.PMax + rMargin * (PRINTING.PMax - PRINTING.PMin)
			PRINTING.PScaleMin = PRINTING.PMin - lMargin * (PRINTING.PMax - PRINTING.PMin)
			PRINTING.LScaleMax = PRINTING.lmax + tMargin * (PRINTING.lmax - PRINTING.lmin)
			PRINTING.LScaleMin = PRINTING.lmin - bMargin * (PRINTING.lmax - PRINTING.lmin)
		End Sub

		Public Function IsColorPrinter() As Boolean
			Return PRINTING.ps.SupportsColor
		End Function

		Private Sub PrintDynoGraph(bSummary As Short)
		End Sub

		Public Sub PrintInitialize(bSummary As Short, bSetOrientation As Short)
		End Sub

		Public Sub PrintTerminate()
		End Sub

		Public Sub PrintTitle(iPage As Short, nPages As Short)
		End Sub

		Private Sub PrintTorqueGraph(bSummary As Object)
		End Sub

		Private Sub AddLegendLine(sLabel As String, nDrawWidth As Short, iDrawStyle As Short, rgbColor As Integer)
			' The following expression was wrapped in a checked-statement
			PRINTING.nLegendLines += 1S
			PRINTING.LGColor = CType(Utils.CopyArray(CType(PRINTING.LGColor, Array), New Integer(CInt((PRINTING.nLegendLines + 1S)) - 1) {}), Integer())
			PRINTING.LGDrawStyle = CType(Utils.CopyArray(CType(PRINTING.LGDrawStyle, Array), New Short(CInt((PRINTING.nLegendLines + 1S)) - 1) {}), Short())
			PRINTING.LGDrawWidth = CType(Utils.CopyArray(CType(PRINTING.LGDrawWidth, Array), New Short(CInt((PRINTING.nLegendLines + 1S)) - 1) {}), Short())
			PRINTING.LGLegend = CType(Utils.CopyArray(CType(PRINTING.LGLegend, Array), New String(CInt((PRINTING.nLegendLines + 1S)) - 1) {}), String())
			PRINTING.LGColor(CInt(PRINTING.nLegendLines)) = rgbColor
			PRINTING.LGDrawStyle(CInt(PRINTING.nLegendLines)) = iDrawStyle
			PRINTING.LGDrawWidth(CInt(PRINTING.nLegendLines)) = nDrawWidth
			PRINTING.LGLegend(CInt(PRINTING.nLegendLines)) = sLabel
		End Sub

		Private Sub ClipPrinterPop()
		End Sub

		Private Sub ClipPrinterPush(xmin As Single, xmax As Single, ymin As Single, ymax As Single)
		End Sub

		Public Sub DrawVertical(ByRef pic As PictureBox, bVertical As Boolean)
		End Sub

		Private Sub GetPrinterName(ByRef sDevName As String, ByRef sDevDriver As String, ByRef sDevPort As String)
		End Sub

		Private Sub InitDynoGraph(lMargin As Single, rMargin As Single, tMargin As Single, bMargin As Single)
		End Sub

		Private ps As PrinterSettings = New PrinterSettings()

		Private Const XTICLENGTH As Single = 0.03F

		Private Const YTICLENGTH As Single = 0.02F

		Private BotForce As Single

		Private pmax_axis As Single

		Private PMax As Single

		Private PScaleMax As Single

		Private pmin_axis As Single

		Private PMin As Single

		Private PScaleMin As Single

		Private lmax_axis As Single

		Private lmax As Single

		Private LScaleMax As Single

		Private lmin_axis As Single

		Private lmin As Single

		Private LScaleMin As Single

		Private xmajcnt As Short

		Private ymajcnt As Short

		Private xstep As Single

		Private ystep As Single

		Private nLegendLines As Short

		Private LGColor As Integer()

		Private LGDrawStyle As Short()

		Private LGDrawWidth As Short()

		Private LGLegend As String()

		Private dXAxisScale As Single

		Private dYAxisScale As Single

		Private tYAxisScale As Single

		Private Const DMORIENT_PORTRAIT As Short = 1S

		Private Const DMORIENT_LANDSCAPE As Short = 2S

		Private Const LOGPIXELSY As Short = 90S
	End Module
End Namespace
