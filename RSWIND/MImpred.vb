Imports System
Imports System.Collections
Imports System.Data
Imports System.Diagnostics
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports ThetaStdInfo

Namespace RSWINV3
	Friend NotInheritable Module MImpred
		Public Property bUseJohnsNewRodDensityCalc As Boolean
			Get
				Return MImpred.m_bUseJohnsNewRodDensityCalc
			End Get
			Set(value As Boolean)
				MImpred.m_bUseJohnsNewRodDensityCalc = True
			End Set
		End Property

		Public Property new_ratio_vb As Double
			Get
				Return MImpred.m_new_ratio_vb
			End Get
			Set(value As Double)
				MImpred.m_new_ratio_vb = value
			End Set
		End Property

		Public Property bVBeltRatio As Boolean
			Get
				Return MImpred.m_bVBeltRatio
			End Get
			Set(value As Boolean)
				MImpred.m_bVBeltRatio = value
			End Set
		End Property

		Public Property ImpredObj As TEImpred
			Get
				If MImpred.m_Impred Is Nothing Then
					MImpred.m_Impred = New TEImpred()
				End If
				Return MImpred.m_Impred
			End Get
			Set(value As TEImpred)
				MImpred.m_Impred = value
			End Set
		End Property

		Public Sub CloseImpred()
			Dim num As Integer
			Dim num2 As Integer
			Dim obj As Object
			Try
				ProjectData.ClearProjectError()
				num = 2
				MImpred.m_Impred = Nothing
				IL_0F:
				GoTo IL_52
				IL_11:
				num2 = -1
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_25:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num2 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_11
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_52:
			If num2 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		Public Function Impred() As Boolean
			Dim flag As Boolean = False
			Dim result As Boolean
			Try
				Dim flag2 As Boolean = MImpred.CheckImpred()
				If flag2 Then
					Application.DoEvents()
					MImpred.LoadImpred(flag)
					If flag Then
						Try
							MImpred.m_Impred = Nothing
							Dim num As Integer = 1
							Do
								Application.DoEvents()
								num += 1
							Loop While num <= 1000
							MImpred.LoadImpred(flag)
						Catch ex As Exception
						End Try
					End If
					If Not RSWIN_DESC.bAbortRun Then
						Dim flag3 As Boolean = False
						Dim flag4 As Boolean
						Dim num2 As Short
						If RSWIN_DESC.SETUP_UseJohnsFix Then
							If Not MImpred.bUseJohnsNewRodDensityCalc Then
								MImpred.ApplyJohnsFix()
							Else
								flag4 = MImpred.m_Impred.Run_Partial()
								flag3 = True
								If flag4 Then
									MImpred.ApplyJohnsFix()
								Else
									Application.DoEvents()
									num2 = CShort(MImpred.m_Impred.p_s.iostat)
									If Not flag4 Then
										If Not RSWIN_DESC.rst.gbAutomatic Then
											Dim impredErrorMessage As String = MImpred.GetImpredErrorMessage(CShort(MImpred.m_Impred.RunStatus))
											If Operators.CompareString(impredErrorMessage, "", False) <> 0 Then
												If Not RSWIN_DESC.bImplementingRodGuides Then
													MessageBox.Show("Run did not complete successfully. " + MImpred.GetImpredErrorMessage(CShort(MImpred.m_Impred.RunStatus)))
												End If
											Else
												MessageBox.Show("Run did not complete successfully. Please check input data.  Error code = " + Conversions.ToString(MImpred.m_Impred.RunStatus))
											End If
											Return flag4
										End If
										Return flag4
									End If
								End If
							End If
						End If
						Application.DoEvents()
						If flag3 Then
							flag4 = MImpred.m_Impred.Run_Remainder()
						Else
							flag4 = MImpred.m_Impred.Run()
						End If
						Application.DoEvents()
						Application.DoEvents()
						Application.DoEvents()
						num2 = CShort(MImpred.m_Impred.p_s.iostat)
						Application.DoEvents()
						Application.DoEvents()
						Application.DoEvents()
						If Not flag4 Then
							If Not RSWIN_DESC.rst.gbAutomatic Then
								Dim impredErrorMessage2 As String = MImpred.GetImpredErrorMessage(CShort(MImpred.m_Impred.RunStatus))
								If num2 <> -1S Then
									If Operators.CompareString(impredErrorMessage2, "", False) <> 0 Then
										' The following expression was wrapped in a unchecked-expression
										If RSWIN_DESC.bRodStarD And CDbl(RSWIN_DESC.rst.PumpIntakePressure) > 0.433 * CDbl(RSWIN_DESC.rst.PumpDepth) Then
											MessageBox.Show(RSWIN_DESC.sRunDidNotComplete + RSWIN_DESC.sIncorrectFluidLevel)
										Else
											MessageBox.Show("Run did not complete successfully. " + MImpred.GetImpredErrorMessage(CShort(MImpred.m_Impred.RunStatus)))
										End If
									Else
										MessageBox.Show("Run did not complete successfully. Please check input data.  Error code = " + Conversions.ToString(MImpred.m_Impred.RunStatus))
									End If
								End If
								result = flag4
							Else
								result = flag4
							End If
						ElseIf flag4 Then
							MImpred.UnloadImpred()
							result = flag4
							If(RSWIN_DESC.bQuickFix And RSWIN_DESC.bQuickFixUsed) AndAlso (MImpred.m_bSBFound And MImpred.m_bLastTaperSB And Not(MImpred.m_bHasFG Or MImpred.m_bHasRibbonRod)) Then
								Dim pumpLoad As Single() = RSWIN_DESC.rst.PumpLoad
								Dim num3 As Single = 0F
								Dim num4 As Single = 0F
								Dim num5 As Single
								Dim num6 As Single
								Util.Maxmin(pumpLoad, num5, num6, num3, num4)
								If num6 > 0F And RSWIN_DESC.bQuickFixLoop Then
									result = MImpred.ReRunImpred()
								Else
									MImpred.m_Impred.num_rod_tapers = MImpred.m_Impred.num_rod_tapers - 1
								End If
							End If
						End If
					End If
				Else
					result = False
				End If
			Catch ex2 As Exception
				result = False
			End Try
			Return result
		End Function

		Private Function ReRunImpred() As Boolean
			Dim flag As Boolean = True
			Dim result As Boolean
			Try
				Dim num As Integer = 0
				Dim flag2 As Boolean
				While flag
					Dim impred As TEImpred = MImpred.m_Impred
					Dim num2 As Single = CSng(impred.get_r_t_taper_depth(impred.num_rod_tapers - 1))
					impred.set_r_t_taper_depth(impred.num_rod_tapers - 1, CDbl((num2 - 25F)))
					impred.set_r_t_taper_depth(impred.num_rod_tapers, impred.get_r_t_taper_depth(impred.num_rod_tapers - 1) + 30.0)
					num += 1
					Application.DoEvents()
					flag2 = impred.Run()
					Application.DoEvents()
					Dim num3 As Short = CShort(MImpred.m_Impred.p_s.iostat)
					If Not flag2 Then
						If Not RSWIN_DESC.rst.gbAutomatic Then
							Dim text As String = MImpred.GetImpredErrorMessage(CShort(MImpred.m_Impred.RunStatus))
							If Operators.CompareString(text, "", False) <> 0 Then
								text = "Run did not complete successfully. " + MImpred.GetImpredErrorMessage(CShort(MImpred.m_Impred.RunStatus))
							End If
						End If
						flag = False
					ElseIf flag2 Then
						MImpred.UnloadImpred()
						Dim pumpLoad As Single() = RSWIN_DESC.rst.PumpLoad
						Dim num4 As Single = 0F
						Dim num5 As Single = 0F
						Dim num6 As Single
						Dim num7 As Single
						Util.Maxmin(pumpLoad, num6, num7, num4, num5)
						flag = (num7 > 0F And num < 5 And num2 > 25F)
					End If
				End While
				result = flag2
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Function GetImpredErrorMessage(iError As Short) As String
			Dim result As String
			Try
				If iError = -8900S Or iError < -8550S Then
					result = "unknown error"
				Else
					Dim text As String = ""
					Dim fileName As String
					FILEUTIL.LocateFile("ImpredErrors.txt", fileName, 0S, False, False, False, False)
					Dim num As Short = CShort(FileSystem.FreeFile())
					FileSystem.FileOpen(CInt(num), fileName, OpenMode.Input, OpenAccess.[Default], OpenShare.[Default], -1)
					While Not FileSystem.EOF(CInt(num))
						Try
							Dim num2 As Short
							FileSystem.Input(CInt(num), num2)
							Dim text2 As String
							FileSystem.Input(CInt(num), text2)
							If iError = num2 Then
								text = text2
								Exit Try
							End If
						Catch ex As Exception
						End Try
					End While
					Try
						FileSystem.FileClose(New Integer() { CInt(num) })
					Catch ex2 As Exception
					End Try
					result = text
				End If
			Catch ex3 As Exception
				Try
					Dim num As Short
					FileSystem.FileClose(New Integer() { CInt(num) })
				Catch ex4 As Exception
				End Try
			End Try
			Return result
		End Function

		Public Sub InitSurveyDataset(ByRef mdsDeviationProfile As DataSet, Optional sSurveyFile As String = Nothing)
			Try
				mdsDeviationProfile = Nothing
				mdsDeviationProfile = New DataSet("DeviationProfile")
				Dim dataTable As DataTable = New DataTable("DeviationSurvey")
				Dim dataColumn As DataColumn = New DataColumn("EntryNumber", GetType(Integer))
				dataColumn.Unique = False
				dataColumn.AllowDBNull = True
				dataTable.Columns.Add(dataColumn)
				Dim dataColumn2 As DataColumn = New DataColumn("Depth", GetType(Single))
				dataColumn2.AllowDBNull = True
				dataTable.Columns.Add(dataColumn2)
				Dim dataColumn3 As DataColumn = New DataColumn("Inclination", GetType(String))
				dataColumn3.AllowDBNull = True
				dataTable.Columns.Add(dataColumn3)
				Dim dataColumn4 As DataColumn = New DataColumn("Azimuth", GetType(String))
				dataColumn4.AllowDBNull = True
				dataTable.Columns.Add(dataColumn4)
				Dim dataColumn5 As DataColumn = New DataColumn("Dogleg", GetType(Single))
				dataColumn5.AllowDBNull = True
				dataTable.Columns.Add(dataColumn5)
				Dim dataColumn6 As DataColumn = New DataColumn("TVDepth", GetType(Single))
				dataColumn6.AllowDBNull = True
				dataTable.Columns.Add(dataColumn6)
				Dim dataColumn7 As DataColumn = New DataColumn("NorthSouth", GetType(Single))
				dataColumn7.AllowDBNull = True
				dataTable.Columns.Add(dataColumn7)
				Dim dataColumn8 As DataColumn = New DataColumn("EastWest", GetType(Single))
				dataColumn8.AllowDBNull = True
				dataTable.Columns.Add(dataColumn8)
				mdsDeviationProfile.Tables.Add(dataTable)
				mdsDeviationProfile.Tables(0).Clear()
			Catch ex As Exception
				MessageBox.Show("Error in InitSurveyDataset: " + ex.Message)
			End Try
		End Sub

		Private Sub CalcDamping()
			Try
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				Dim flag As Boolean = False
				Dim flag2 As Boolean = False
				Dim num As Short = 1S
				Dim numRods As Short = rst.NumRods
				For num2 As Short = num To numRods
					If rst.Sections(CInt(num2)).Grade >= 16384S And rst.Sections(CInt(num2)).Grade < 20480S Then
						flag = True
					End If
					If rst.Sections(CInt(num2)).Grade >= 20480S And rst.Sections(CInt(num2)).Grade < 24576S Then
						flag2 = True
					End If
				Next
				Dim num3 As Single = rst.SPM * rst.PU.KinematicStroke / 360F
				Dim num4 As Single
				If flag And rst.SPM >= 10F And rst.PumpDepth >= 6000F Then
					If CDbl(num3) < 1.274 Then
						num4 = 0.5F
					Else
						num4 = CSng((0.3447 + 0.12187 * CDbl(num3)))
						num4 = CSng(Math.Min(CDbl(num4), 0.85))
					End If
				Else
					Dim num5 As Single
					If CDbl(num3) > 2.5 Then
						num5 = 0.15F
					Else
						num5 = CSng((0.17789 * Math.Pow(CDbl(num3), -0.89166)))
					End If
					num4 = CSng((3.141592653589793 * MImpred.mfSpeemax * CDbl(num5) / CDbl((2F * rst.PumpDepth))))
					If rst.PumpDepth < 1500F Then
						num4 /= 2F
					ElseIf rst.PumpDepth < 2500F Then
						num4 = CSng((CDbl(num4) / 1.75))
					ElseIf rst.PumpDepth < 3500F Then
						num4 = CSng((CDbl(num4) / 1.25))
					ElseIf rst.PumpDepth < 4500F Then
						num4 = CSng((CDbl(num4) / 1.125))
					End If
					If flag2 Then
						num4 = CSng(Math.Min(Conversions.ToDouble(Util.Max(num4, 0.5)), 1.35))
					Else
						num4 = Conversions.ToSingle(NewLateBinding.LateGet(Nothing, GetType(Math), "Min", New Object() { RuntimeHelpers.GetObjectValue(Util.Max(num4, 0.5)), 2F }, Nothing, Nothing, Nothing))
					End If
				End If
				rst.UpstrokeFriction = num4
				rst.DownstrokeFriction = num4
				If flag And Not flag2 Then
					Dim flag3 As Boolean = False
					Dim num6 As Short = 1S
					Dim numRods2 As Short = rst.NumRods
					For num2 As Short = num6 To numRods2
						If flag3 Then
							If(RODUTIL.IsSteel(CInt(rst.Sections(CInt(num2)).Grade)) And If((-If((CDbl(rst.Sections(CInt(num2)).Diameter) > 1.62 > False), 1, 0)), 1, 0) And If((-If((rst.Sections(CInt(num2)).length > 1000F > False), 1, 0)), 1, 0)) <> 0 Then
								rst.UpstrokeFriction /= 2F
								rst.DownstrokeFriction = CSng((CDbl(rst.DownstrokeFriction) * 1.5))
								Exit For
							End If
						ElseIf RODUTIL.IsFG(rst.Sections(CInt(num2)).Grade) Then
							flag3 = True
						End If
					Next
				End If
				rst.UpstrokeFriction = CSng(Math.Round(CDbl(rst.UpstrokeFriction), 2))
				rst.DownstrokeFriction = CSng(Math.Round(CDbl(rst.DownstrokeFriction), 2))
			Catch ex As Exception
			End Try
		End Sub

		Private Function CheckImpred() As Boolean
			Dim num As Integer
			Dim flag2 As Boolean
			Dim num5 As Integer
			Dim obj As Object
			Try
				ProjectData.ClearProjectError()
				num = 2
				MImpred.m_PI = 3.141592653589793
				Dim flag As Boolean = False
				Dim num2 As Double = 0.0
				Dim num3 As Double = 0.0
				Dim num4 As Integer = 1
				Dim numRods As Integer = CInt(RSWIN_DESC.rst.NumRods)
				For i As Integer = num4 To numRods
					If RSWIN_DESC.rst.Sections(i).Diameter > 2F Then
						flag = True
					End If
					If CDbl(RSWIN_DESC.rst.Sections(i).Diameter) > num2 Then
						num2 = CDbl(RSWIN_DESC.rst.Sections(i).Diameter)
					End If
					num3 += CDbl(RSWIN_DESC.rst.Sections(i).length)
				Next
				If Math.Abs(num3 - CDbl(RSWIN_DESC.rst.PumpDepth)) > 50.0 Then
					If Not RSWIN_DESC.bSinkerBarDepthChanged Then
						Util.Errmsg("The pump setting depth and rod string length must be within 50 feet (15.24 meters) of each other. Please check input.")
						flag2 = False
						GoTo IL_202
					End If
					MImpred.CheckLastTaperLength()
				End If
				If RSWIN_DESC.mdsDeviationProfile IsNot Nothing AndAlso (CDbl(Util.GetLastDepth(RSWIN_DESC.mdsDeviationProfile, False, 1)) < num3 And num3 - CDbl(Util.GetLastDepth(RSWIN_DESC.mdsDeviationProfile, False, 0)) > 50.0 And RSWIN_DESC.mdsDeviationProfile.Tables(0).Rows.Count > 0) Then
					Util.Errmsg("The deviation survey must extend past the end of the rod string. Please check input.")
					flag2 = False
				ElseIf flag Then
					Util.Errmsg("Tapers cannot be larger than 2"". Please check input.")
					flag2 = False
				Else
					If Not RSWIN_DESC.rst.TubingAnchored <> 0S Then
						MImpred.mfTubingAnchorDepth = 0.0
					ElseIf CDbl(RSWIN_DESC.rst.TubingAnchorDepth) > num3 Then
						MImpred.mfTubingAnchorDepth = num3
					Else
						MImpred.mfTubingAnchorDepth = CDbl(RSWIN_DESC.rst.TubingAnchorDepth)
					End If
					flag2 = True
				End If
				IL_1BB:
				GoTo IL_202
				IL_1BD:
				num5 = -1
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_1D3:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num5 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_1BD
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_202:
			Dim result As Boolean = flag2
			If num5 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		Public Sub EstimateRotatingInertia()
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			Dim num As Single
			If Not rst.UnknownM Then
				num = rst.get_M(2)
			Else
				If rst.RodStringType = 3S Then
					If RODUTIL.IsSteel(CInt(rst.RSGrade)) <> 0 Then
						rst.WrodsInFluid = CSng((CDbl(rst.PumpDepth) * (2.22 - 62.4 * CDbl(rst.FluidSPGR) * 0.6013 / 144.0)))
					Else
						rst.WrodsInFluid = CSng((CDbl(rst.PumpDepth) * 0.6 * (0.819 - 62.4 * CDbl(rst.FluidSPGR) * 0.7854 / 144.0)))
						rst.WrodsInFluid = CSng((CDbl(rst.PumpDepth) * 0.4 * (4.53 - 62.4 * CDbl(rst.FluidSPGR) * 1.2272 / 144.0) + CDbl(rst.WrodsInFluid)))
					End If
				Else
					rst.WrodsInFluid = 0F
					Dim num2 As Single = 0F
					Dim num3 As Integer = 1
					Dim numRods As Integer = CInt(rst.NumRods)
					For i As Integer = num3 To numRods
						Dim num4 As Single
						If(If((-If((RODUTIL.IsCorod(rst.Sections(i).Grade) > False), 1, 0)), 1, 0) Or RODUTIL.IsProRod(CInt(rst.Sections(i).Grade))) <> 0 Then
							num4 = 1F
						Else
							num4 = 1.07F
						End If
						rst.WrodsInFluid = CSng((CDbl(rst.WrodsInFluid) + CDbl(rst.Sections(i).length) * (CDbl(rst.Sections(i).RodWeight) - CDbl(num4) * (62.4 * CDbl(rst.FluidSPGR) * CDbl(rst.Sections(i).Area) / 144.0))))
						num2 += rst.Sections(i).length
					Next
					Dim num5 As Single = rst.PumpDepth - num2
					If num5 > 0F Then
						Dim num6 As Single = CSng((0.5 * CDbl(num5)))
						Dim num7 As Single = CSng((0.5 * CDbl(num5)))
						Dim num8 As Single = CSng((5.2 * CDbl(num6)))
						Dim num9 As Single = 2F * num7
						rst.WrodsInFluid = rst.WrodsInFluid + num8 + num9
					End If
				End If
				kinemat.Kinconst(rst.PU)
				Dim cRODSTAR As cRODSTAR = rst
				Dim pu As RSWIN_DESC.PUDataRec = cRODSTAR.PU
				kinemat.Unitstroke(pu)
				cRODSTAR.PU = pu
				rst.FluidDens = CSng((CDbl(rst.FluidSPGR) * 62.4))
				rst.Apump = CSng((3.141592653589793 * CDbl(rst.PlungerSize) * CDbl(rst.PlungerSize) / 4.0))
				If(If((-If(((RSWIN_DESC.bRodStarD And RSWIN_DESC.bUseFluidInertiaPumpLoadAdj) > False), 1S, 0S)), 1S, 0S) And RSWIN_DESC.rst.IncludeFluidInertia And RSWIN_DESC.SETUP_UseImpred) <> 0S Then
					Dim num10 As Single = rst.PumpEfficiency / 100F
					rst.FluidLoad = CSng(((0.433 * CDbl(rst.FluidSPGR) * CDbl(rst.FluidLevel) + CDbl(rst.TubingPressure) - CDbl(rst.CasingPressure)) * CDbl(rst.Apump) * CDbl(num10)))
				Else
					rst.FluidLoad = CSng(((0.433 * CDbl(rst.FluidSPGR) * CDbl(rst.FluidLevel) + CDbl(rst.TubingPressure) - CDbl(rst.CasingPressure)) * CDbl(rst.Apump)))
				End If
				pu = rst.PU
				If pu.UnitType = 7S Or rst.PU.UnitType = 10S Then
					num = CSng((CDbl(rst.PU.DrumDiamRatio) * (2.0 * CDbl(rst.WrodsInFluid) + CDbl(rst.FluidLoad)) / 2.0))
				Else
					num = CSng(((CDbl(rst.FluidLoad) / 2.0 + CDbl(rst.WrodsInFluid)) * CDbl(rst.PU.KinematicStroke) / 2.0))
				End If
			End If
			If CDbl(num) < 0.0 Then
				rst.Irot = -1F
			Else
				Select Case rst.PU.UnitType
					Case 5S
						rst.Irot = CSng((CDbl(num) * 0.75))
						GoTo IL_4BD
					Case 6S, 7S, 10S
						GoTo IL_4BD
				End Select
				rst.Irot = CSng((CDbl(num) * 1.25))
				IL_4BD:
				rst.Irot = CSng((Conversion.Int(CDbl(rst.Irot) / 10000.0 + 0.5) * 10000.0))
			End If
		End Sub

		Public Sub CalcWrodsInFluid()
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			rst.WrodsInFluid = 0F
			Dim num As Single = 0F
			Dim num2 As Integer = 1
			Dim numRods As Integer = CInt(rst.NumRods)
			For i As Integer = num2 To numRods
				Dim num3 As Single
				If(If((-If((RODUTIL.IsCorod(rst.Sections(i).Grade) > False), 1, 0)), 1, 0) Or RODUTIL.IsProRod(CInt(rst.Sections(i).Grade))) <> 0 Then
					num3 = 1F
				Else
					num3 = 1.07F
				End If
				rst.WrodsInFluid = CSng((CDbl(rst.WrodsInFluid) + CDbl(rst.Sections(i).length) * (CDbl(rst.Sections(i).RodWeight) - CDbl(num3) * (62.4 * CDbl(rst.FluidSPGR) * CDbl(rst.Sections(i).Area) / 144.0))))
				num += rst.Sections(i).length
			Next
			Dim num4 As Single = rst.PumpDepth - num
			If num4 > 0F Then
				Dim num5 As Single = CSng((0.5 * CDbl(num4)))
				Dim num6 As Single = CSng((0.5 * CDbl(num4)))
				Dim num7 As Single = CSng((5.2 * CDbl(num5)))
				Dim num8 As Single = 2F * num6
				rst.WrodsInFluid = rst.WrodsInFluid + num7 + num8
			End If
		End Sub

		Private Function EstimateMaximumCBMoment() As Double
			Dim num As Integer
			Dim num2 As Double
			Dim num4 As Integer
			Dim obj As Object
			Try
				ProjectData.ClearProjectError()
				num = 2
				If Not RSWIN_DESC.rst.UnknownM Then
					num2 = CDbl(RSWIN_DESC.rst.get_M(2))
				Else
					num2 = 0.0
					Dim num3 As Double = CDbl(RSWIN_DESC.rst.Irot)
					MImpred.EstimateRotatingInertia()
					If RSWIN_DESC.rst.Irot > 0F Then
						Select Case RSWIN_DESC.rst.PU.UnitType
							Case 5S
								num2 = CDbl(RSWIN_DESC.rst.Irot) / 0.75
								GoTo IL_B5
							Case 6S, 7S, 10S
								GoTo IL_B5
						End Select
						num2 = CDbl(RSWIN_DESC.rst.Irot) / 1.25
					End If
					IL_B5:
					RSWIN_DESC.rst.Irot = CSng(num3)
				End If
				IL_C3:
				GoTo IL_10A
				IL_C5:
				num4 = -1
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_DB:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_C5
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_10A:
			Dim result As Double = num2
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		Private Function GetValues(hFile As Integer, ByRef V As Object()) As Boolean
			' The following expression was wrapped in a checked-statement
			Dim num As Integer
			Dim flag As Boolean
			Dim num4 As Integer
			Dim obj As Object
			Try
				ProjectData.ClearProjectError()
				num = 2
				flag = False
				While Not FileSystem.EOF(hFile)
					Dim text As String = FileSystem.LineInput(hFile)
					If Strings.InStr(text, "!", CompareMethod.Binary) <> 0 Then
						text = Strings.Left(text, Strings.InStr(text, "!", CompareMethod.Binary) - 1)
					End If
					text = Strings.Trim(text)
					If Strings.Len(text) > 0 Then
						Dim text2 As String
						Do
							text2 = text
							text = Strings.Replace(text, "  ", " ", 1, -1, CompareMethod.Binary)
						Loop While Operators.CompareString(text2, text, False) <> 0
						Dim array As String() = Strings.Split(text, " ", -1, CompareMethod.Binary)
						V = New Object(Information.UBound(array, 1) + 1 - 1) {}
						Dim num2 As Integer = Information.LBound(array, 1)
						Dim num3 As Integer = Information.UBound(array, 1)
						For i As Integer = num2 To num3
							If Versioned.IsNumeric(array(i)) Then
								V(i) = Convert.ToDouble(array(i))
							Else
								V(i) = Convert.ToString(array(i))
							End If
						Next
						flag = True
						Exit While
					End If
				End While
				IL_DC:
				GoTo IL_123
				IL_DE:
				num4 = -1
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_F4:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_DE
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_123:
			Dim result As Boolean = flag
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		Private Sub WriteRSW32VariablesToFile()
		End Sub

		Private Sub LoadImpred(ByRef bTryAgain As Boolean)
			Try
				Dim flag As Boolean = True
				bTryAgain = False
				If MImpred.m_Impred Is Nothing Then
					MImpred.m_Impred = New TEImpred()
					Application.DoEvents()
					Application.DoEvents()
				Else
					MImpred.m_Impred = Nothing
					Application.DoEvents()
					Application.DoEvents()
					MImpred.m_Impred = New TEImpred()
					Application.DoEvents()
					Application.DoEvents()
				End If
				If RSWIN_DESC.rst.PU.UnitType = 8S Then
					RSWIN_DESC.rst.UnknownM = True
					RSWIN_DESC.rst.set_M(2, RSWIN_DESC.rst.PU.M * 1000F)
					If RSWIN_DESC.rst.bUnknownUnbalance Then
						RSWIN_DESC.rst.iUnknownM = 1
					Else
						RSWIN_DESC.rst.iUnknownM = 2
					End If
				ElseIf RSWIN_DESC.rst.UnknownM Then
					RSWIN_DESC.rst.iUnknownM = 1
				Else
					RSWIN_DESC.rst.iUnknownM = 2
				End If
				Dim num As Short
				Dim num2 As Double
				Dim num3 As Double
				MImpred.CalcNtsteps(num, num2, num3, MImpred.mfSpeemax)
				Dim teimpred As TEImpred = MImpred.m_Impred
				teimpred.Initialize()
				RSWIN_DESC.rst.BPDsurface = 0F
				teimpred.anch_depth = Conversions.ToDouble(Interaction.IIf(RSWIN_DESC.rst.TubingAnchored <> 0S, RSWIN_DESC.rst.TubingAnchorDepth, 0))
				teimpred.angl_cwt_phase = CDbl(RSWIN_DESC.rst.PU.CrankOffset)
				If RSWIN_DESC.rst.PU.UnitType = 9S Then
					teimpred.API_len_A = 0.0
				Else
					teimpred.API_len_A = CDbl(RSWIN_DESC.rst.PU.A)
				End If
				teimpred.casing_pressure = CDbl(RSWIN_DESC.rst.CasingPressure)
				teimpred.comp_tot = CDbl(RSWIN_DESC.rst.CompressibilityIndex) * 1E-06
				teimpred.cw_or_ccw = CInt(RSWIN_DESC.rst.PU.CrankRotation)
				teimpred.eff_gb = MImpred.mc_GEARBOXEFFICIENCY
				teimpred.eff_pu = MImpred.mc_PUMPJACKEFFICIENCY
				teimpred.eff_vb = MImpred.mc_VBELTEFFICIENCY
				teimpred.eff_gb = 1.0
				teimpred.eff_pu = 1.0
				teimpred.eff_vb = 1.0
				teimpred.fluid_solution = Conversions.ToInteger(Interaction.IIf(RSWIN_DESC.rst.IncludeFluidInertia <> 0S, 0, -1))
				teimpred.force_su = CDbl(RSWIN_DESC.rst.PU.Unbalance)
				If RSWIN_DESC.rst.PU.UnitType = 5S Or RSWIN_DESC.rst.PU.UnitType = 6S Then
					teimpred.four_bar_class = 3
				ElseIf RSWIN_DESC.rst.PU.UnitType = 9S Then
					teimpred.four_bar_class = 1
				Else
					teimpred.four_bar_class = 1
				End If
				teimpred.hp_mot = Conversions.ToDouble(Motor.GetMotorInfo(0))
				If teimpred.hp_mot = 0.0 Then
					teimpred.hp_mot = 100.0
				End If
				teimpred.liquid_level = Conversions.ToDouble(Interaction.IIf(RSWIN_DESC.rst.FluidLevelEntered, RSWIN_DESC.rst.FluidLevel, CDbl(RSWIN_DESC.rst.PumpDepth) - (CDbl((RSWIN_DESC.rst.PumpIntakePressure - RSWIN_DESC.rst.CasingPressure)) - 14.7) / (CDbl(RSWIN_DESC.rst.OilSPGR) * 0.433)))
				teimpred.num_tbg_tapers = 1
				teimpred.pump_diam = CDbl(RSWIN_DESC.rst.PlungerSize)
				teimpred.pump_effic = CDbl((RSWIN_DESC.rst.PumpEfficiency / 100F))
				teimpred.pump_fillup = Conversions.ToDouble(Interaction.IIf(RSWIN_DESC.rst.PumpCondition = 1S, 1, RSWIN_DESC.rst.PumpFillage / 100F))
				teimpred.pump_load_adj = CDbl(RSWIN_DESC.rst.PumpLoadAdj)
				Dim text2 As String
				If Not RSWIN_DESC.bBETA Then
					Dim str As String
					Try
						Dim text As String = "GearboxRatio"
						text2 = "28.45"
						Dim regProfileString As Integer = RSWIN.GetRegProfileString(RSWIN_DESC.SECT_RSWIN, text, text2, str, False)
						If regProfileString = 0 Then
							RSWIN_DESC.SETUP_GearboxRatio = 28.45F
						Else
							RSWIN_DESC.SETUP_GearboxRatio = CSng(Convert.ToDouble(Strings.Left(str, regProfileString)))
						End If
					Catch ex As Exception
						RSWIN_DESC.SETUP_GearboxRatio = 28.45F
					End Try
					If(If((-If((Not MImpred.bVBeltRatio > False), 1S, 0S)), 1S, 0S) Or Not RSWIN_DESC.SETUP_CalcVBeltRatio) <> 0S Then
						Try
							text2 = "VBeltRatio"
							Dim text As String = "3.2961"
							Dim regProfileString As Integer = RSWIN.GetRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text, str, False)
							If regProfileString = 0 Then
								RSWIN_DESC.SETUP_VBeltRatio = 3.2961F
							Else
								RSWIN_DESC.SETUP_VBeltRatio = CSng(Convert.ToDouble(Strings.Left(str, regProfileString)))
							End If
						Catch ex2 As Exception
							RSWIN_DESC.SETUP_VBeltRatio = 3.2961F
						End Try
						teimpred.ratio_vb = CDbl(RSWIN_DESC.SETUP_VBeltRatio)
					Else
						teimpred.ratio_vb = MImpred.m_new_ratio_vb
					End If
					teimpred.ratio_gb = CDbl(RSWIN_DESC.SETUP_GearboxRatio)
				Else
					teimpred.ratio_gb = MImpred.mc_GEARBOXRATIO
					teimpred.ratio_vb = MImpred.mc_VBELTRATIO
				End If
				teimpred.sp_grav_oil = CDbl(RSWIN_DESC.rst.OilSPGR)
				teimpred.sp_grav_water = CDbl(RSWIN_DESC.rst.WaterSPGR)
				If RSWIN_DESC.rst.gbCalcFluidSPGR Then
					Util.CheckFluidSPGR()
					RSWIN_DESC.rst.FluidSPGR = RSWIN_DESC.rst.gfMaxFluidSPGR
				End If
				teimpred.liquid_gravity = CDbl(RSWIN_DESC.rst.FluidSPGR)
				teimpred.strokes_per_min = CDbl(RSWIN_DESC.rst.SPM)
				teimpred.torq_cr = 0.0
				If RSWIN_DESC.rst.PU.UnitType = 5S Or RSWIN_DESC.rst.PU.UnitType = 1S Or RSWIN_DESC.rst.PU.UnitType = 9S Or RSWIN_DESC.rst.PU.UnitType = 8S Or RSWIN_DESC.rst.PU.UnitType = 2S Then
					teimpred.torq_cw = MImpred.EstimateMaximumCBMoment()
				Else
					teimpred.torq_cw = 0.0
				End If
				teimpred.tubing_pressure = CDbl(RSWIN_DESC.rst.TubingPressure)
				teimpred.watercut = CDbl((RSWIN_DESC.rst.WaterCut / 100F))
				teimpred.damp_fluid = CDbl(RSWIN_DESC.rst.FluidDamping)
				teimpred.damp_fluid = 0.95
				teimpred.gas_exponent = 1.27
				teimpred.i_downhole_dyno = 0
				teimpred.max_iterations = 40
				text2 = "NumCycles"
				Dim num4 As Integer = 4
				RSWIN_DESC.SETUP_NumCycles = Conversions.ToInteger(RSWIN.GetRegProfileStringByInt(RSWIN_DESC.SECT_RSWIN, text2, num4))
				teimpred.num_cycles = RSWIN_DESC.SETUP_NumCycles
				teimpred.num_rod_elements = CInt((num * 10S))
				teimpred.omega_fill = 0.0
				teimpred.SV_clear_vol = 2.0
				teimpred.TV_clear_vol = 1.0
				teimpred.TV_pos_init = 0.8315
				teimpred.p_drag_f_max_up = CDbl(RSWIN_DESC.rst.PumpFriction)
				teimpred.p_drag_f_max_dn = CDbl(RSWIN_DESC.rst.PumpFriction)
				teimpred.p_drag_up_0 = CInt((-If((-If(((0S = (RSWIN_DESC.rst.DragSettings And 3S)) > False), 1S, 0S)), 1S, 0S)))
				teimpred.p_drag_up_1 = CInt((-If((-If(((1S = (RSWIN_DESC.rst.DragSettings And 3S)) > False), 1S, 0S)), 1S, 0S)))
				teimpred.p_drag_up_2 = CInt((-If((-If(((2S = (RSWIN_DESC.rst.DragSettings And 3S)) > False), 1S, 0S)), 1S, 0S)))
				teimpred.p_drag_dn_0 = CInt((-If((-If(((0S = (RSWIN_DESC.rst.DragSettings And 12S)) > False), 1S, 0S)), 1S, 0S)))
				teimpred.p_drag_dn_1 = CInt((-If((-If(((4S = (RSWIN_DESC.rst.DragSettings And 12S)) > False), 1S, 0S)), 1S, 0S)))
				teimpred.p_drag_dn_2 = CInt((-If((-If(((8S = (RSWIN_DESC.rst.DragSettings And 12S)) > False), 1S, 0S)), 1S, 0S)))
				teimpred.pr_drag_0 = CInt((-If((-If(((0S <> (RSWIN_DESC.rst.DragSettings And 48S)) > False), 1S, 0S)), 1S, 0S)))
				teimpred.pr_drag_1 = CInt((-If((-If(((16S <> (RSWIN_DESC.rst.DragSettings And 48S)) > False), 1S, 0S)), 1S, 0S)))
				teimpred.pr_drag_2 = CInt((-If((-If(((32S <> (RSWIN_DESC.rst.DragSettings And 48S)) > False), 1S, 0S)), 1S, 0S)))
				teimpred.pr_drag_f_max = 0.0
				teimpred.poisson = 0.29
				teimpred.ref_psia = 14.7
				teimpred.rpm_full_load = 1200.0
				teimpred.timestep_multiplier = 1.0
				If RSWIN_DESC.rst.PU.UnitType = 6S Or RSWIN_DESC.rst.PU.UnitType = 7S Then
					teimpred.wk_sq_beam = 0.0
				Else
					teimpred.wk_sq_beam = CDbl(RSWIN_DESC.rst.Iart)
				End If
				teimpred.wk_sq_cr = 0.0
				teimpred.wk_sq_cw = 0.0
				teimpred.wk_sq_gb = 0.0
				teimpred.wk_sq_hss = 0.0
				teimpred.wk_sq_lss = 0.0
				teimpred.wk_sq_mot = 0.0
				teimpred.wk_sq_vb = 0.0
				teimpred.Iart = RSWIN_DESC.rst.Iart
				If RSWIN_DESC.rst.PU.UnitType = 5S Or RSWIN_DESC.rst.PU.UnitType = 1S Or RSWIN_DESC.rst.PU.UnitType = 9S Or RSWIN_DESC.rst.PU.UnitType = 8S Or RSWIN_DESC.rst.PU.UnitType = 2S Then
					MImpred.EstimateRotatingInertia()
				Else
					RSWIN_DESC.rst.Irot = 0F
				End If
				teimpred.Irot = RSWIN_DESC.rst.Irot
				If RSWIN_DESC.rst.DownstrokeFriction <= 0F Then
					RSWIN_DESC.rst.DownstrokeFriction = 0.1F
				End If
				If RSWIN_DESC.rst.UpstrokeFriction <= 0F Then
					RSWIN_DESC.rst.UpstrokeFriction = 0.1F
				End If
				teimpred = Nothing
				MImpred.ReadMotor()
				MImpred.ReadPumpingUnit()
				MImpred.ReadRodTapers()
				If flag Then
					RSWIN_DESC.rst.Irot = RSWIN_DESC.rst.Irot
				End If
				If flag Then
					MImpred.ReadSurvey()
				Else
					MImpred.ReadSurvey_Oct2007()
				End If
				MImpred.ReadTubingTapers()
				Dim impred As TEImpred = MImpred.m_Impred
				impred.dimless_damp_flu = CDbl(RSWIN_DESC.rst.FluidDamping)
				impred.tbg_flu_dens = 64.3481
				impred.char_vel_fluid = Math.Sqrt(4633.0632000000005 / impred.tbg_flu_dens / impred.comp_tot)
				impred.damp_fluid = 3.14159265358979 * impred.char_vel_fluid * impred.dimless_damp_flu / 2.0 / MImpred.m_Impred.get_r_t_taper_depth(impred.num_rod_tapers)
			Catch ex3 As Exception
				bTryAgain = True
			End Try
		End Sub

		Private Sub LoadImpred_Old()
			Dim num As Integer
			Dim num5 As Integer
			Dim obj As Object
			Try
				ProjectData.ClearProjectError()
				num = 2
				If MImpred.m_Impred Is Nothing Then
					MImpred.m_Impred = New TEImpred()
				End If
				Dim num2 As Double = 0.0
				Dim num3 As Double = 0.0
				Dim num4 As Short
				MImpred.CalcNtsteps(num4, num2, num3, MImpred.mfSpeemax)
				If RSWIN_DESC.rst.CalcFriction <> 0S Then
					MImpred.CalcDamping()
				End If
				Dim impred As TEImpred = MImpred.m_Impred
				impred.Initialize()
				impred.anch_depth = Conversions.ToDouble(Interaction.IIf(RSWIN_DESC.rst.TubingAnchored <> 0S, RSWIN_DESC.rst.TubingAnchorDepth, 0))
				impred.angl_cwt_phase = CDbl(RSWIN_DESC.rst.PU.CrankOffset)
				impred.API_len_A = CDbl(RSWIN_DESC.rst.PU.A)
				impred.casing_pressure = CDbl(RSWIN_DESC.rst.CasingPressure)
				impred.comp_tot = CDbl(RSWIN_DESC.rst.CompressibilityIndex) * 1E-06
				impred.cw_or_ccw = CInt(RSWIN_DESC.rst.PU.CrankRotation)
				impred.eff_gb = MImpred.mc_GEARBOXEFFICIENCY
				impred.eff_pu = MImpred.mc_PUMPJACKEFFICIENCY
				impred.fluid_solution = Conversions.ToInteger(Interaction.IIf(RSWIN_DESC.rst.IncludeFluidInertia <> 0S, 0, -1))
				impred.force_su = CDbl(RSWIN_DESC.rst.PU.Unbalance)
				impred.four_bar_class = Conversions.ToInteger(Interaction.IIf(RSWIN_DESC.rst.PU.UnitType = 5S Or RSWIN_DESC.rst.PU.UnitType = 6S, 3, 1))
				impred.hp_mot = Conversions.ToDouble(Motor.GetMotorInfo(0))
				impred.liquid_level = Conversions.ToDouble(Interaction.IIf(RSWIN_DESC.rst.FluidLevelEntered, RSWIN_DESC.rst.FluidLevel, CDbl(RSWIN_DESC.rst.PumpDepth) - (CDbl((RSWIN_DESC.rst.PumpIntakePressure - RSWIN_DESC.rst.CasingPressure)) - 14.7) / (CDbl(RSWIN_DESC.rst.OilSPGR) * 0.433)))
				impred.num_tbg_tapers = 1
				impred.pump_diam = CDbl(RSWIN_DESC.rst.PlungerSize)
				impred.pump_effic = CDbl((RSWIN_DESC.rst.PumpEfficiency / 100F))
				impred.pump_fillup = Conversions.ToDouble(Interaction.IIf(RSWIN_DESC.rst.PumpCondition = 1S, 1, RSWIN_DESC.rst.PumpFillage / 100F))
				impred.pump_load_adj = CDbl(RSWIN_DESC.rst.PumpLoadAdj)
				impred.ratio_gb = MImpred.mc_GEARBOXRATIO
				impred.ratio_vb = MImpred.mc_VBELTRATIO
				impred.sp_grav_oil = CDbl(RSWIN_DESC.rst.OilSPGR)
				impred.sp_grav_water = CDbl(RSWIN_DESC.rst.WaterSPGR)
				impred.strokes_per_min = CDbl(RSWIN_DESC.rst.SPM)
				impred.torq_cr = 0.0
				impred.torq_cw = MImpred.EstimateMaximumCBMoment()
				impred.tubing_pressure = CDbl(RSWIN_DESC.rst.TubingPressure)
				impred.watercut = CDbl((RSWIN_DESC.rst.WaterCut / 100F))
				impred.damp_fluid = CDbl(RSWIN_DESC.rst.FluidDamping)
				impred.gas_exponent = 1.27
				impred.i_downhole_dyno = 0
				impred.max_iterations = 20
				impred.num_cycles = 4
				impred.num_rod_elements = CInt((num4 * 10S))
				impred.omega_fill = 0.0
				impred.SV_clear_vol = 2.0
				impred.TV_clear_vol = 1.0
				impred.TV_pos_init = 0.8315
				impred.p_drag_up_0 = CInt((-If((-If(((0S = (RSWIN_DESC.rst.DragSettings And 3S)) > False), 1S, 0S)), 1S, 0S)))
				impred.p_drag_up_1 = CInt((-If((-If(((1S = (RSWIN_DESC.rst.DragSettings And 3S)) > False), 1S, 0S)), 1S, 0S)))
				impred.p_drag_up_2 = CInt((-If((-If(((2S = (RSWIN_DESC.rst.DragSettings And 3S)) > False), 1S, 0S)), 1S, 0S)))
				impred.p_drag_f_max_up = CDbl(RSWIN_DESC.rst.PumpDragUpstrokeMax)
				impred.p_drag_dn_0 = CInt((-If((-If(((0S = (RSWIN_DESC.rst.DragSettings And 12S)) > False), 1S, 0S)), 1S, 0S)))
				impred.p_drag_dn_1 = CInt((-If((-If(((4S = (RSWIN_DESC.rst.DragSettings And 12S)) > False), 1S, 0S)), 1S, 0S)))
				impred.p_drag_dn_2 = CInt((-If((-If(((8S = (RSWIN_DESC.rst.DragSettings And 12S)) > False), 1S, 0S)), 1S, 0S)))
				impred.p_drag_f_max_dn = CDbl(RSWIN_DESC.rst.PumpDragDownstrokeMax)
				impred.pr_drag_0 = CInt((-If((-If(((0S <> (RSWIN_DESC.rst.DragSettings And 48S)) > False), 1S, 0S)), 1S, 0S)))
				impred.pr_drag_1 = CInt((-If((-If(((16S <> (RSWIN_DESC.rst.DragSettings And 48S)) > False), 1S, 0S)), 1S, 0S)))
				impred.pr_drag_2 = CInt((-If((-If(((32S <> (RSWIN_DESC.rst.DragSettings And 48S)) > False), 1S, 0S)), 1S, 0S)))
				impred.pr_drag_f_max = 0.0
				impred.poisson = 0.29
				impred.ref_psia = 14.7
				impred.rpm_full_load = 1200.0
				impred.timestep_multiplier = 1.0
				impred.wk_sq_beam = CDbl(RSWIN_DESC.rst.Iart)
				impred.wk_sq_cr = 0.0
				impred.wk_sq_cw = 0.0
				impred.wk_sq_gb = 0.0
				impred.wk_sq_hss = 0.0
				impred.wk_sq_lss = 0.0
				impred.wk_sq_mot = 0.0
				impred.wk_sq_vb = 0.0
				MImpred.ReadMotor()
				MImpred.ReadPumpingUnit()
				MImpred.ReadRodTapers()
				MImpred.ReadSurvey()
				MImpred.ReadTubingTapers()
				IL_5BB:
				GoTo IL_602
				IL_5BD:
				num5 = -1
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_5D3:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num5 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_5BD
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_602:
			If num5 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		Public Sub ReadMotor()
			Dim flag As Boolean = False
			Dim text As String = ""
			Dim flag2 As Boolean = True
			Try
				Dim teimpred As TEImpred = MImpred.m_Impred
				If Conversions.ToBoolean(Operators.AndObject(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(Motor.GetMotorInfo(4), 1, False), Operators.CompareObjectEqual(Motor.GetMotorInfo(4), 7, False)), Operators.CompareObjectGreaterEqual(Motor.GetMotorInfo(4), 8, False)), If((-If((RSWIN_DESC.rst.MotorSPV > 0F > False), 1S, 0S)), 1S, 0S) Or RSWIN_DESC.rst.CalcMotorSPV)) Then
					teimpred.mot_pts_flag = 20
					Dim text2 As String = Conversions.ToString(Motor.GetMotorInfo(3))
					If(If((-If(((text2 = Nothing) > False), 1S, 0S)), 1S, 0S) And RSWIN_DESC.rst.CalcMotorSize) <> 0S Then
						text2 = "150 hp"
					End If
					text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Motor.GetMotorInfo(1), " "), text2))
				ElseIf Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(Motor.GetMotorInfo(4), 3, False), If((-If((RSWIN_DESC.rst.MotorSPV > 0F > False), 1S, 0S)), 1S, 0S) Or RSWIN_DESC.rst.CalcMotorSPV)) Then
					teimpred.mot_pts_flag = 20
					text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Motor.GetMotorInfo(1), " "), Motor.GetMotorInfo(3)), " "), Motor.GetMotorInfo(2)))
				ElseIf Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(Motor.GetMotorInfo(4), 5, False), If((-If((RSWIN_DESC.rst.MotorSPV > 0F > False), 1S, 0S)), 1S, 0S) Or RSWIN_DESC.rst.CalcMotorSPV)) Then
					teimpred.mot_pts_flag = 20
					Dim text3 As String = Conversions.ToString(Motor.GetMotorInfo(2))
					If Operators.CompareString(text3, "25 hp", False) = 0 Then
						text3 = RSWIN_DESC.Reliance_Table(4, 2)
					ElseIf Operators.CompareString(text3, "34 hp", False) = 0 Then
						text3 = RSWIN_DESC.Reliance_Table(4, 3)
					ElseIf Operators.CompareString(text3, "50 hp", False) = 0 Then
						text3 = RSWIN_DESC.Reliance_Table(4, 4)
					ElseIf Operators.CompareString(text3, "60 hp", False) = 0 Then
						text3 = RSWIN_DESC.Reliance_Table(4, 5)
					End If
					text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Reliance SVP ", Motor.GetMotorInfo(3)), " "), text3))
				ElseIf Conversions.ToBoolean(Operators.AndObject(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(Motor.GetMotorInfo(4), 2, False), Operators.CompareObjectEqual(Motor.GetMotorInfo(4), 4, False)), Operators.CompareObjectEqual(Motor.GetMotorInfo(4), 6, False)), If((-If((RSWIN_DESC.rst.MotorSPV > 0F > False), 1S, 0S)), 1S, 0S) Or RSWIN_DESC.rst.CalcMotorSPV)) Then
					teimpred.mot_pts_flag = 20
					Dim iSizeIndex As Integer
					Dim text2 As String = MImpred.GetRelianceMotorSizeName(Conversions.ToString(Motor.GetMotorInfo(3)), iSizeIndex)
					Dim text3 As String = Conversions.ToString(Motor.GetMotorInfo(2))
					text3 = MImpred.GetRelianceMotorSettingName(text3, iSizeIndex)
					text = "Reliance SVP " + text2 + " " + text3
				Else
					teimpred.mot_pts_flag = 1
				End If
				If RSWIN_DESC.bRodStarD And RSWIN_DESC.rst.PumpCondition <> 1S Then
					teimpred.mot_pts_flag = 1
				End If
				Dim num6 As Integer
				If flag2 Then
					If Strings.InStr(text, ".0 hp", CompareMethod.Binary) > 0 Then
						text = text.Replace(".0 hp", " hp")
					End If
					If Strings.InStr(text, "Marathon NEMA B", CompareMethod.Binary) > 0 Then
						text = text.Replace("Marathon NEMA B", "NEMA D")
					ElseIf Strings.InStr(text, "Marathon", CompareMethod.Binary) > 0 Then
						text = text.Replace("Marathon", "NEMA D")
					End If
					Dim motorSetting_Deviated As DataSet = RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.GetMotorSetting_Deviated(text)
					Dim motorCurvePoints_Deviated As DataSet = RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.GetMotorCurvePoints_Deviated(text)
					Dim count As Integer = motorSetting_Deviated.Tables(0).Rows.Count
					Dim count2 As Integer = motorCurvePoints_Deviated.Tables(0).Rows.Count
					Dim dataView As DataView = New DataView(motorSetting_Deviated.Tables(0))
					Dim dataView2 As DataView = New DataView(motorCurvePoints_Deviated.Tables(0))
					Try
						For Each obj As Object In dataView
							Dim dataRowView As DataRowView = CType(obj, DataRowView)
							Dim row As DataRow = dataRowView.Row
							Dim num4 As Single = Conversions.ToSingle(row("FullLoadRPM"))
							Dim num5 As Single = Conversions.ToSingle(row("HalfLoadRPM"))
							num6 = Conversions.ToInteger(row("NumPairs"))
							teimpred.rpm_full_load = CDbl(num4)
							teimpred.torq_full_load = 0.0
							teimpred.rpm_no_load = 1200.0
						Next
					Finally
						Dim enumerator As IEnumerator
						If TypeOf enumerator Is IDisposable Then
							TryCast(enumerator, IDisposable).Dispose()
						End If
					End Try
					dataView2.Sort = "MotorCurvePointID"
					Dim num7 As Integer = 0
					Dim num8 As Integer = 0
					Try
						For Each obj2 As Object In dataView2
							Dim dataRowView As DataRowView = CType(obj2, DataRowView)
							Dim row As DataRow = dataRowView.Row
							Dim num9 As Integer = Conversions.ToInteger(row("MotorCurvePointID"))
							Dim num10 As Single = Conversions.ToSingle(row("RPM"))
							Dim num11 As Single = Conversions.ToSingle(row("Torque"))
							num8 += 1
							If Not flag Or (flag And num8 Mod 2 <> 0) Then
								num7 += 1
								teimpred.set_m_c_rpm_mot(num7, CDbl(num10))
								teimpred.set_m_c_torq_mot(num7, CDbl(num11))
							End If
						Next
					Finally
						Dim enumerator2 As IEnumerator
						If TypeOf enumerator2 Is IDisposable Then
							TryCast(enumerator2, IDisposable).Dispose()
						End If
					End Try
					teimpred.mot_pts = num7
				ElseIf Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(Motor.GetMotorInfo(4), 1, False), Operators.CompareObjectEqual(Motor.GetMotorInfo(4), 7, False)), Operators.CompareObjectGreaterEqual(Motor.GetMotorInfo(4), 8, False))) Then
					Dim flag3 As Boolean = False
					Dim text4 As String = Conversions.ToString(Motor.GetMotorInfo(3))
					text4 = text4.Replace(" ", "")
					Dim fileName As String
					FILEUTIL.LocateFile("motor.csv", fileName, 2S, False, False, False, False)
					Dim num12 As Short = CShort(FileSystem.FreeFile())
					FileSystem.FileOpen(CInt(num12), fileName, OpenMode.Input, OpenAccess.[Default], OpenShare.[Default], -1)
					While Not FileSystem.EOF(CInt(num12))
						Dim text5 As String
						FileSystem.Input(CInt(num12), text5)
						Dim text6 As String
						FileSystem.Input(CInt(num12), text6)
						Dim num4 As Single
						FileSystem.Input(CInt(num12), num4)
						FileSystem.Input(CInt(num12), text6)
						Dim num5 As Single
						FileSystem.Input(CInt(num12), num5)
						FileSystem.Input(CInt(num12), text6)
						FileSystem.Input(CInt(num12), num6)
						FileSystem.Input(CInt(num12), text6)
						Dim num10 As Single
						Dim num11 As Single
						If Operators.CompareString(text4, text5, False) = 0 Then
							teimpred.rpm_full_load = CDbl(num4)
							Dim num13 As Single
							teimpred.torq_full_load = CDbl(num13)
							teimpred.rpm_no_load = 1200.0
							flag = True
							Dim num7 As Integer = 0
							Dim num14 As Short = 1S
							Dim num15 As Short = CShort(num6)
							For num3 As Short = num14 To num15
								FileSystem.Input(CInt(num12), num10)
								FileSystem.Input(CInt(num12), num11)
								If flag Then
									num7 += 1
									teimpred.set_m_c_rpm_mot(num7, CDbl(num10))
									teimpred.set_m_c_torq_mot(num7, CDbl(num11))
								End If
							Next
							teimpred.mot_pts = num7
							flag3 = True
							Exit While
						End If
						Dim num16 As Short = 1S
						Dim num17 As Short = CShort(num6)

							For num3 As Short = num16 To num17
								FileSystem.Input(CInt(num12), num10)
								FileSystem.Input(CInt(num12), num11)
							Next

					End While
					FileSystem.FileClose(New Integer() { CInt(num12) })
					Application.DoEvents()
					If Not flag3 Then
						teimpred.mot_pts_flag = 1
					End If
				ElseIf Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(Motor.GetMotorInfo(4), 3, False), Operators.CompareObjectEqual(Motor.GetMotorInfo(4), 2, False)), Operators.CompareObjectEqual(Motor.GetMotorInfo(4), 4, False)), Operators.CompareObjectEqual(Motor.GetMotorInfo(4), 6, False)), Operators.CompareObjectEqual(Motor.GetMotorInfo(4), 5, False))) Then
					Dim text7 As String = Conversions.ToString(Motor.GetMotorInfo(0))
					Dim text8 As String = Conversions.ToString(Motor.GetMotorInfo(2))
					Dim text9 As String = Conversions.ToString(Motor.GetMotorInfo(3))
					Dim [string] As String = text9.Substring(0, 3)
					Dim str As String
					If Strings.InStr(Conversions.ToString(Motor.GetMotorInfo(2)), "Medium/Low", CompareMethod.Binary) > 0 Then
						str = "MLT"
					ElseIf Strings.InStr(Conversions.ToString(Motor.GetMotorInfo(2)), "Low", CompareMethod.Binary) > 0 Then
						str = "LT"
					ElseIf Strings.InStr(Conversions.ToString(Motor.GetMotorInfo(2)), "High", CompareMethod.Binary) > 0 Then
						str = "HT"
					End If
					Try
						Dim flag3 As Boolean = False
						[string] = text9.Substring(0, 3) + str
						Dim fileName As String
						FILEUTIL.LocateFile("motorUHS.csv", fileName, 2S, False, False, False, False)
						Dim num12 As Short = CShort(FileSystem.FreeFile())
						FileSystem.FileOpen(CInt(num12), fileName, OpenMode.Input, OpenAccess.[Default], OpenShare.[Default], -1)
						While Not FileSystem.EOF(CInt(num12))
							Dim text5 As String
							FileSystem.Input(CInt(num12), text5)
							Dim text6 As String
							FileSystem.Input(CInt(num12), text6)
							Dim num4 As Single
							FileSystem.Input(CInt(num12), num4)
							FileSystem.Input(CInt(num12), text6)
							Dim num5 As Single
							FileSystem.Input(CInt(num12), num5)
							FileSystem.Input(CInt(num12), text6)
							FileSystem.Input(CInt(num12), num6)
							FileSystem.Input(CInt(num12), text6)
							Dim num10 As Single
							Dim num11 As Single
							If Strings.InStr(text5, [string], CompareMethod.Binary) > 0 Then
								teimpred.rpm_full_load = CDbl(num4)
								Dim num13 As Single
								teimpred.torq_full_load = CDbl(num13)
								teimpred.rpm_no_load = 1200.0
								flag = True
								Dim num7 As Integer = 0
								Dim num18 As Short = 1S
								Dim num19 As Short = CShort(num6)
								For num3 As Short = num18 To num19
									FileSystem.Input(CInt(num12), num10)
									FileSystem.Input(CInt(num12), num11)
									If flag Then
										num7 += 1
										teimpred.set_m_c_rpm_mot(num7, CDbl(num10))
										teimpred.set_m_c_torq_mot(num7, CDbl(num11))
									End If
								Next
								teimpred.mot_pts = num7
								flag3 = True
								Exit While
							End If
							Dim num20 As Short = 1S
							Dim num21 As Short = CShort(num6)

								For num3 As Short = num20 To num21
									FileSystem.Input(CInt(num12), num10)
									FileSystem.Input(CInt(num12), num11)
								Next

						End While
						FileSystem.FileClose(New Integer() { CInt(num12) })
						Application.DoEvents()
						If Not flag3 Then
							teimpred.mot_pts_flag = 1
						End If
					Catch ex As Exception
					End Try
				End If
				Exit Select
				Select Case teimpred.mot_pts_flag
					Case 1
						teimpred.mot_pts = 0
						Dim num As Short = 1S
						Dim num2 As Short = CShort(teimpred.mot_pts)
						For num3 As Short = num To num2
							teimpred.set_m_c_rpm_mot(CInt(num3), 0.0)
							teimpred.set_m_c_torq_mot(CInt(num3), 0.0)
						Next
					Case 2
						teimpred.rpm_no_load = 0.0
						teimpred.rpm_full_load = 0.0
						teimpred.torq_no_load = 0.0
						teimpred.torq_full_load = 0.0
					Case 3
						teimpred.rpm_no_load = 0.0
						teimpred.rpm_full_load = 0.0
						teimpred.rpm_breakdown = 0.0
						teimpred.torq_no_load = 0.0
						teimpred.torq_full_load = 0.0
						teimpred.torq_breakdown = 0.0
					Case 20
				End Select
				teimpred = Nothing
				Dim num22 As Integer = 2
				If 1 = num22 Then
					Dim text10 As String = "c:\TempRSWINFiles\Mot_Torq_Eff.csv"
					If FILEUTIL.FileExists(text10) Then
						Dim num23 As Short
						FileSystem.FileClose(New Integer() { CInt(num23) })
						Application.DoEvents()
						FileSystem.Kill("c:\TempRSWINFiles\Mot_Torq_Eff.csv")
						Application.DoEvents()
					End If
					Dim num28 As Short
					Dim num29 As Short
					Dim num30 As Short
					Dim num23 As Short = CShort(FileSystem.FreeFile())
					FileSystem.FileOpen(CInt(num23), "c:\TempRSWINFiles\Mot_Torq_Eff.csv", OpenMode.Output, OpenAccess.[Default], OpenShare.[Default], -1)
					FileSystem.PrintLine(CInt(num23), New Object() { "" })
					FileSystem.PrintLine(CInt(num23), New Object() { "Mot_Torq_Eff.csv, PrintLine" })
					FileSystem.PrintLine(CInt(num23), New Object() { Conversions.ToString(RSWIN_DESC.rst.mfRatedHP) + ",=rst.mfRatedHp" })
					Dim num24 As Integer = 0
					Dim num25 As Integer = Information.UBound(RSWIN_DESC.rst.mfEfficiency, 1)
					FileSystem.PrintLine(CInt(num23), New Object() { " , in-lbf?, ft-lbf?, %" })
					FileSystem.PrintLine(CInt(num23), New Object() { "K, rst.mfTorq, rst.mfTorq/12, rst.mfeffic" })
					Dim num26 As Integer = num24
					Dim num27 As Integer = num25
					For i As Integer = num26 To num27
						If 1 = num22 Then
							FileSystem.PrintLine(CInt(num23), New Object() { String.Concat(New String() { Conversions.ToString(i), ",", Conversions.ToString(RSWIN_DESC.rst.mfTorque(i)), ",", Conversions.ToString(RSWIN_DESC.rst.mfTorque(i) / 12F), ",", Conversions.ToString(RSWIN_DESC.rst.mfEfficiency(i)) }) })
						End If
					Next
					FileSystem.PrintLine(CInt(num23), New Object() { " , in-lbf?, ft-lbf?, %" })
					FileSystem.PrintLine(CInt(num23), New Object() { "K, rst.mfTorq, rst.mfTorq/12, rst.mfeffic" })
					FileSystem.PrintLine(CInt(num23), New Object() { " End of debug PrintLine for Mot_Torq_Eff.csv" })
					FileSystem.PrintLine(CInt(num23), New Object() { "  " })
					FileSystem.FileClose(New Integer() { CInt(num23) })
					Application.DoEvents()
					text10 = "c:\TempRSWINFiles\Mot_Rpm_Torq.csv"
					If FILEUTIL.FileExists(text10) Then
						FileSystem.Kill("c:\TempRSWINFiles\Mot_Rpm_Torq.csv")
						Application.DoEvents()
					End If
					num28 = CShort(FileSystem.FreeFile())
					FileSystem.FileOpen(CInt(num28), "c:\TempRSWINFiles\Mot_Rpm_Torq.csv", OpenMode.Output, OpenAccess.[Default], OpenShare.[Default], -1)
					FileSystem.PrintLine(CInt(num28), New Object() { "" })
					FileSystem.PrintLine(CInt(num28), New Object() { "c:\TempRSWINFiles\Mot_Rpm_Torq.csv, PrintLine" })
					FileSystem.PrintLine(CInt(num28), New Object() { Conversions.ToString(MImpred.m_Impred.rpm_full_load) + ", = m_Impred.rpm_full_load" })
					FileSystem.PrintLine(CInt(num28), New Object() { Conversions.ToString(MImpred.m_Impred.torq_full_load) + ", = m_Impred.torq_full_load, ft-lbf" })
					FileSystem.PrintLine(CInt(num28), New Object() { Conversions.ToString(MImpred.m_Impred.rpm_no_load) + ", = m_Impred.rpm_no_load, ft-lbf" })
					FileSystem.PrintLine(CInt(num28), New Object() { " , rpm, ft-lbf" })
					FileSystem.PrintLine(CInt(num28), New Object() { "I, m_c_rpm_mot, m_c_torq_mot" })
					num29 = 1S
					num30 = CShort(num6)
					For num3 As Short = num29 To num30
						FileSystem.PrintLine(CInt(num28), New Object() { String.Concat(New String() { Conversions.ToString(CInt(num3)), ",", Conversions.ToString(MImpred.m_Impred.get_m_c_rpm_mot(CInt(num3))), ",", Conversions.ToString(MImpred.m_Impred.get_m_c_torq_mot(CInt(num3))) }) })
					Next
					FileSystem.PrintLine(CInt(num28), New Object() { " , rpm, ft-lbf" })
					FileSystem.PrintLine(CInt(num28), New Object() { "I, m_c_rpm_mot, m_c_torq_mot" })
					FileSystem.PrintLine(CInt(num28), New Object() { " End of debug PrintLine for Mot_Rpm_Torq.csv" })
					FileSystem.PrintLine(CInt(num28), New Object() { "  " })
					FileSystem.FileClose(New Integer() { CInt(num28) })
					Application.DoEvents()
				End If
			Catch ex2 As Exception
				MessageBox.Show("Error in ReadMotor: " + ex2.Message)
			End Try
		End Sub

		Public Sub ReadPumpingUnit()
			Try
				kinemat.Kinconst(RSWIN_DESC.rst.PU)
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				Dim pu As RSWIN_DESC.PUDataRec = rst.PU
				kinemat.Unitstroke(pu)
				rst.PU = pu
				pu = RSWIN_DESC.rst.PU
				Dim num As Double
				If pu.UnitType = 9S Then
					num = 0.0
					Dim num2 As Double = CDbl(RSWIN_DESC.BeltLowProfile180)
				Else
					Dim prp As Single = 0F
					Dim upstroke As Boolean = True
					Dim num3 As Single = CSng(num)
					kinemat.ThetaFromPrp_Old(prp, upstroke, num3, False)
					num = CDbl(num3)
					pu = RSWIN_DESC.rst.PU
					Dim kinematicStroke As Single = pu.KinematicStroke
					Dim upstroke2 As Boolean = False
					Dim num2 As Double
					num3 = CSng(num2)
					kinemat.ThetaFromPrp_Old(kinematicStroke, upstroke2, num3, False)
					num2 = CDbl(num3)
				End If
				MImpred.m_PI = 3.141592653589793
				Dim num4 As Double
				If Math.Abs(6.283185307179586 - CDbl(RSWIN_DESC.rst.TotalTheta)) < 1E-06 Then
					num4 = 6.283185307179586
				Else
					num4 = Convert.ToDouble(RSWIN_DESC.rst.TotalTheta)
				End If
				Dim num5 As Double = num4 / Convert.ToDouble(RSWIN_DESC.rst.Ntsteps)
				Dim impred As TEImpred = MImpred.m_Impred
				Dim num6 As Short
				Dim num7 As Short
				impred.num_pump_unit_data_points = CInt((RSWIN_DESC.rst.Ntsteps + 1S))
				num6 = 1S
				num7 = CShort(impred.num_pump_unit_data_points)
				For num8 As Short = num6 To num7
					' The following expression was wrapped in a checked-expression
					Dim num9 As Double = num + CDbl((num8 - 1S)) * num5
					Dim num10 As Double
					num10 = num9
					While num10 < 0.0
						num10 += num4
					End While
					While num10 >= num4
						num10 -= num4
					End While
					Dim theta As Double = num10
					Dim num11 As Double = 0.0
					Dim num12 As Double = 0.0
					Dim num13 As Double
					Dim num14 As Double
					kinemat.Kinematics(theta, num11, num13, num14, num12, -1, 0F)
					If(CInt(num8) = impred.num_pump_unit_data_points And num13 < 1E-10) Or (num8 = 1S Or num13 < 1E-05) Then
						num13 = 0.0
					End If
					If(num8 = 1S Or CInt(num8) = impred.num_pump_unit_data_points) And num14 < 1E-05 Then
						num14 = 0.0
					End If
					impred.set_p_u_crank_angle(CInt(num8), num9)
					pu = RSWIN_DESC.rst.PU
					If pu.UnitType = 7S Or RSWIN_DESC.rst.PU.UnitType = 10S Then
						impred.set_p_u_p_r_position(CInt(num8), num13 * 12.0)
					Else
						impred.set_p_u_p_r_position(CInt(num8), num13)
					End If
					impred.set_p_u_torque_factor(CInt(num8), num14)
				Next
				impred.torq_gb_rating = CDbl(RSWIN_DESC.rst.PU.GearboxRating)
			Catch ex As Exception
				MessageBox.Show(ex.Message)
			End Try
		End Sub

		Private Sub ReadRodTapers()
			Dim num As Integer
			Dim num10 As Integer
			Dim obj As Object
			Try
				ProjectData.ClearProjectError()
				num = 2
				MImpred.m_bSBFound = False
				MImpred.m_bHasFG = False
				MImpred.m_bHasRibbonRod = False
				MImpred.m_bLastTaperSB = False
				Dim impred As TEImpred = MImpred.m_Impred
				impred.num_rod_tapers = CInt(RSWIN_DESC.rst.NumRods)
				Dim num2 As Single = 0F
				RSWIN_DESC.bSBDiameterChanged = False
				MImpred.bDiameterChanged = New Boolean(impred.num_rod_tapers + 1 - 1) {}
				Dim num3 As Integer = 1
				Dim num_rod_tapers As Integer = impred.num_rod_tapers
				For i As Integer = num3 To num_rod_tapers
					MImpred.bDiameterChanged(i) = False
					impred.set_r_t_grade(i, CInt(RSWIN_DESC.rst.Sections(i).Grade))

						num2 += RSWIN_DESC.rst.Sections(i).length
						impred.set_r_t_taper_depth(i, CDbl(num2))
						impred.set_r_t_rod_od(i, CDbl(RSWIN_DESC.rst.Sections(i).Diameter))
						impred.set_r_t_rod_id(i, 0.0)
						If RSWIN_DESC.rst.Sections(i).Elasticity = 0F Then
							RODUTIL.LookupElasticity(RSWIN_DESC.rst.Sections(i))
						End If
						If RSWIN_DESC.rst.Sections(i).RodWeight = 0F Then
							RODUTIL.LookupRodWeight(RSWIN_DESC.rst.Sections(i))
						End If
						If RSWIN_DESC.rst.Sections(i).TensileStrength = 0F Then
							RODUTIL.LookupTensileStrength(RSWIN_DESC.rst.Sections(i))
						End If
						If RSWIN_DESC.rst.Sections(i).Grade = 20481S Then
							RSWIN_DESC.rst.Sections(i).RodDensity = 100F
						ElseIf RSWIN_DESC.rst.Sections(i).Grade = 16393S Then
							RSWIN_DESC.rst.Sections(i).RodDensity = 125F
						ElseIf RODUTIL.IsFG(RSWIN_DESC.rst.Sections(i).Grade) Then
							RSWIN_DESC.rst.Sections(i).RodDensity = 130F
						Else
							RSWIN_DESC.rst.Sections(i).RodDensity = 491F
						End If
						If Not CUSTOMRG.IsOtherSteel(CInt(RSWIN_DESC.rst.Sections(i).Grade)) Then
							RSWIN_DESC.rst.Sections(i).RodType = RODUTIL.RodGrade(RSWIN_DESC.rst.Sections(i).Grade)
						End If
						impred.set_r_t_rod_density(i, CDbl(RSWIN_DESC.rst.Sections(i).RodDensity))
						impred.set_r_t_rod_modulus(i, CDbl(RSWIN_DESC.rst.Sections(i).Elasticity))
						If Versioned.IsNumeric(RSWIN_DESC.rst.DownstrokeFriction) Then
							impred.set_r_t_dimless_damp_dn(i, CDbl(RSWIN_DESC.rst.DownstrokeFriction))
						Else
							impred.set_r_t_dimless_damp_dn(i, 0.1)
						End If
						If Versioned.IsNumeric(RSWIN_DESC.rst.UpstrokeFriction) Then
							impred.set_r_t_dimless_damp_up(i, CDbl(RSWIN_DESC.rst.UpstrokeFriction))
						Else
							impred.set_r_t_dimless_damp_up(i, 0.1)
						End If
						If RSWIN_DESC.rst.Sections(i).friction_coef = 0F Then
							RSWIN_DESC.rst.Sections(i).friction_coef = RODUTIL.GetFricCoeff(CInt(RSWIN_DESC.rst.Sections(i).Guide), True)
						End If
						If RSWIN_DESC.SETUP_ALLOWSLIDEFRIC <> 0S Then
							If RSWIN_DESC.rst.RodStringType = 3S Then
								If RSWIN_DESC.rst.RSFricCoef = 0F Then
									RSWIN_DESC.rst.RSFricCoef = RODUTIL.GetFricCoeff(RSWIN_DESC.SETUP_GuideToUse, True)
									If RSWIN_DESC.rst.RSFricCoef = 0F Then
										RSWIN_DESC.rst.RSFricCoef = 0.2F
									End If
									If RSWIN_DESC.rst.Sections(i).friction_coef = 0F Then
										RSWIN_DESC.rst.Sections(i).friction_coef = RODUTIL.GetFricCoeff(RSWIN_DESC.SETUP_GuideToUse, True)
									End If
								Else
									impred.set_r_t_friction_coef(i, CDbl(RSWIN_DESC.rst.RSFricCoef))
									If impred.get_r_t_friction_coef(i) = 0.0 Then
										impred.set_r_t_friction_coef(i, 0.2)
									End If
								End If
							ElseIf RSWIN_DESC.rst.Sections(i).NumGuides = 0S Then
								impred.set_r_t_friction_coef(i, 0.2)
							Else
								impred.set_r_t_friction_coef(i, CDbl(RSWIN_DESC.rst.Sections(i).friction_coef))
							End If
						ElseIf Versioned.IsNumeric(RSWIN_DESC.rst.SlideFricCoeff) Then
							impred.set_r_t_friction_coef(i, CDbl(RSWIN_DESC.rst.SlideFricCoeff))
						Else
							impred.set_r_t_friction_coef(i, 0.2)
						End If
						If(RODUTIL.IsSinkerBar(i) Or If((-If((CUSTOMRG.IsOtherSinkerBar(CInt(RSWIN_DESC.rst.Sections(i).Grade)) > False), 1, 0)), 1, 0)) <> 0 Then
							MImpred.m_bSBFound = True
							If i = CInt(RSWIN_DESC.rst.NumRods) Then
								MImpred.m_bLastTaperSB = True
							End If
						ElseIf RSWIN_DESC.rst.Sections(i).Grade >= 16384S And RSWIN_DESC.rst.Sections(i).Grade < 20480S Then
							MImpred.m_bHasFG = True
						ElseIf RSWIN_DESC.rst.Sections(i).Grade >= 20480S And RSWIN_DESC.rst.Sections(i).Grade < 24576S Then
							MImpred.m_bHasRibbonRod = True
						End If
						impred.set_r_t_rod_area(i, CDbl(RSWIN_DESC.rst.Sections(i).Area))

				Next
				If CDbl(RSWIN_DESC.rst.PumpDepth) <> impred.get_r_t_taper_depth(impred.num_rod_tapers) Then
					Dim num4 As Single = CSng(Math.Abs(CDbl(RSWIN_DESC.rst.PumpDepth) - impred.get_r_t_taper_depth(impred.num_rod_tapers)))
					If MImpred.m_bSBFound And MImpred.m_bLastTaperSB And RSWIN_DESC.rst.NumRods > 1S Then
						If CDbl(RSWIN_DESC.rst.PumpDepth) < impred.get_r_t_taper_depth(impred.num_rod_tapers) Then
							' The following expression was wrapped in a checked-expression
							' The following expression was wrapped in a checked-expression
							impred.set_r_t_taper_depth(impred.num_rod_tapers - 1, impred.get_r_t_taper_depth(impred.num_rod_tapers - 1) - CDbl(num4))
						Else
							' The following expression was wrapped in a checked-expression
							' The following expression was wrapped in a checked-expression
							impred.set_r_t_taper_depth(impred.num_rod_tapers - 1, impred.get_r_t_taper_depth(impred.num_rod_tapers - 1) + CDbl(num4))
						End If
						impred.set_r_t_taper_depth(impred.num_rod_tapers, CDbl(RSWIN_DESC.rst.PumpDepth))
					ElseIf Not(MImpred.m_bSBFound And MImpred.m_bLastTaperSB) Then
						If CDbl(RSWIN_DESC.rst.PumpDepth) < impred.get_r_t_taper_depth(impred.num_rod_tapers) Then
							impred.set_r_t_taper_depth(impred.num_rod_tapers, impred.get_r_t_taper_depth(impred.num_rod_tapers) - CDbl(num4))
						Else
							impred.set_r_t_taper_depth(impred.num_rod_tapers, impred.get_r_t_taper_depth(impred.num_rod_tapers) + CDbl(num4))
						End If
					End If
				End If
				RSWIN_DESC.bQuickFixUsed = False
				Dim num5 As Integer = 1
				If 1 = num5 Then
					RSWIN_DESC.bQuickFix = False
				End If
				If Not RSWIN_DESC.bQuickFix Then
					RSWIN_DESC.bQuickFix = RSWIN_DESC.bQuickFix
				End If
				If RSWIN_DESC.bQuickFix AndAlso (MImpred.m_bSBFound And MImpred.m_bLastTaperSB And Not(MImpred.m_bHasFG Or MImpred.m_bHasRibbonRod)) Then
					RSWIN_DESC.bQuickFixUsed = True
					Dim num6 As Integer
					Dim num7 As Single
					Dim num8 As Single
					num6 = CInt((RSWIN_DESC.rst.NumRods + 1S))
					impred.num_rod_tapers = num6
					num7 = 30F
					num8 = CSng(impred.get_r_t_taper_depth(num6 - 1))
					Dim num9 As Single = CSng((CDbl(num8) - impred.get_r_t_taper_depth(num6 - 2)))
					If num9 > 50F Then
						' The following expression was wrapped in a checked-expression
						' The following expression was wrapped in a checked-expression
						impred.set_r_t_taper_depth(num6 - 1, impred.get_r_t_taper_depth(num6 - 1) - CDbl(num7))
						impred.set_r_t_taper_depth(num6, CDbl(num8))
					Else
						impred.set_r_t_taper_depth(num6, CDbl((num8 + num7)))
					End If
					impred.set_r_t_rod_od(num6, 0.75)
					impred.set_r_t_rod_id(num6, 0.0)
					impred.set_r_t_dimless_damp_up(num6, 0.1)
					impred.set_r_t_dimless_damp_dn(num6, 0.1)
					impred.set_r_t_friction_coef(num6, 0.2)
					impred.set_r_t_rod_density(num6, 491.0)
					impred.set_r_t_rod_modulus(num6, 30500000.0)
				End If
				IL_88A:
				GoTo IL_8D1
				IL_88C:
				num10 = -1
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_8A2:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num10 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_88C
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_8D1:
			If num10 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		Private Sub ReadSurvey()
			' The following expression was wrapped in a checked-statement
			Try
				Dim flag As Boolean = False
				Dim num As Double = 0.02
				Dim num2 As Double = 0.02
				Dim num3 As Double = 0.02
				Dim dataView As DataView = New DataView(RSWIN_DESC.mdsDeviationProfile.Tables(0))
				Dim num4 As Single = 0F
				Dim num5 As Single = 0F
				Dim num6 As Integer = 0
				Dim flag2 As Boolean = True
				Dim flag3 As Boolean = False
				Dim num7 As Single = 0F
				Dim num8 As Single = 0F
				Dim flag4 As Boolean = False
				Dim flag5 As Boolean = False
				Dim flag6 As Boolean = False
				Dim num9 As Integer = 1
				Dim flag7 As Boolean = False
				Dim flag8 As Boolean = True
				Dim num10 As Integer = 0
				Dim sDefaultName As String = "SteelSuckerRodLength"
				Dim value As Object = DBNull.Value
				Dim flag9 As Boolean = False
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(ini.GetDefault(sDefaultName, value, flag9))
				RSWIN_DESC.SETUP_SteelSuckerRodLength = Conversions.ToSingle(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)), 25, RuntimeHelpers.GetObjectValue(objectValue)))
				Dim num11 As Single = RSWIN_DESC.rst.PumpDepth / CSng(RSWIN_DESC.SETUP_RodElementLimit)
				While flag8
					If num10 = 0 Then
						flag8 = False
					End If
					Dim num12 As Integer = CInt(Math.Round(CDbl(RSWIN_DESC.SETUP_SteelSuckerRodLength)))
					dataView.Sort = "Depth"
					Dim i As Integer = 0
					MImpred.m_PI = 4.0 * Math.Atan(1.0)
					Dim num13 As Single = 100000F
					Dim num14 As Single = 100000F
					Dim num15 As Single = 100000F
					Dim teimpred As TEImpred = MImpred.m_Impred
					Dim num17 As Integer
					Dim num18 As Integer
					Dim flag10 As Boolean
					Dim array As Single()
					Dim array2 As Single()
					Dim array3 As Single()
					Dim array4 As Single()
					Dim array5 As Single()
					Dim array6 As MImpred.survey_point_type()
					If RSWIN_DESC.mdsDeviationProfile.Tables(0).Rows.Count < 2 Then
						teimpred.num_survey_points = 2
						Dim num16 As Integer = 1
						Dim num_survey_points As Integer = teimpred.num_survey_points
						i = num16
						While i <= num_survey_points

								teimpred.set_s_p_m_d(i, CDbl(RSWIN_DESC.rst.PumpDepth) * Conversion.Int(CDbl(i) / 2.0))
								teimpred.set_s_p_azi(i, 0.0)
								teimpred.set_s_p_inc(i, 0.0)
								If i > 1 Then
									' The following expression was wrapped in a checked-expression
									num13 = CSng((teimpred.get_s_p_m_d(i) - teimpred.get_s_p_m_d(i - 1)))
								End If

							i += 1
						End While
						num14 = num13
						num15 = num13 * 2F
						MImpred.bUseMD = True
					Else
						i = 1
						num17 = RSWIN_DESC.mdsDeviationProfile.Tables(0).Rows.Count
						If num17 > 1500 Then
							num18 = num17 - 1500
						Else
							num18 = 0
						End If
						If Not RSWIN_DESC.rst.gbAutomatic And Not RSWIN_DESC.rst.gbBatch Then
							If num17 > 1500 And Not MImpred.bSurveyLimitWarningMsgShown Then
								MImpred.bSurveyLimitWarningMsgShown = True
								If RSWIN_DESC.bImplementingRodGuides Then
									flag7 = True
									MImpred.bSurveyWarningMsgAnswer = True
								Else
									Dim msg As String = MImpred.sSurveyLimitWarningMsg
									Dim bDefaultYes As Boolean = True
									flag9 = False
									If Not Util.YesNo(msg, bDefaultYes, flag9) Then
										MImpred.bSurveyWarningMsgAnswer = False
										MImpred.bSurveyLimitWarningMsgShown = False
										RSWIN_DESC.bAbortRun = True
										Exit While
									End If
									flag7 = True
									MImpred.bSurveyWarningMsgAnswer = True
								End If
							ElseIf num17 > 1500 And MImpred.bSurveyLimitWarningMsgShown And MImpred.bSurveyWarningMsgAnswer Then
								flag7 = True
							End If
						ElseIf RSWIN_DESC.rst.gbBatch And num17 > 1500 Then
							flag7 = True
						End If
						flag10 = False
						MImpred.bUseMD = False
						array = New Single(num17 + 1 - 1) {}
						array2 = New Single(num17 + 1 - 1) {}
						array3 = New Single(num17 + 1 - 1) {}
						array4 = New Single(num17 + 1 - 1) {}
						array5 = New Single(num17 + 1 - 1) {}
						array6 = New MImpred.survey_point_type(num17 + 1 - 1) {}
					End If
					Dim j As Integer
					Dim num25 As Integer
					If flag2 Then
						j = 0
						flag3 = False
						flag6 = False
						Try
							For Each obj As Object In dataView
								Dim dataRowView As DataRowView = CType(obj, DataRowView)
								Dim row As DataRow = dataRowView.Row
								j += 1
								Dim num19 As Single
								Dim num20 As Single
								Dim num21 As Single
								Dim num22 As Single
								If j = 1 Then
									num19 = CSng(Convert.ToDouble(RuntimeHelpers.GetObjectValue(row(1))))
									Dim value2 As String = MImpred.InclinationCheck(Conversions.ToString(row(2)))
									num20 = CSng(Convert.ToDouble(value2))
									Dim dataRow As DataRow = row
									Dim dataRow2 As DataRow = dataRow
									Dim columnIndex As Integer = 3
									Dim value3 As String = Conversions.ToString(dataRow2(columnIndex))
									Dim text As String = MImpred.AzimuthCheck(value3)
									dataRow(columnIndex) = value3
									Dim value4 As String = text
									num21 = CSng(Convert.ToDouble(value4))
								ElseIf j = 2 Then
									num22 = CSng(Convert.ToDouble(RuntimeHelpers.GetObjectValue(row(1))))
									Dim value5 As String = MImpred.InclinationCheck(Conversions.ToString(row(2)))
									Dim num23 As Single = CSng(Convert.ToDouble(value5))
									Dim dataRow As DataRow = row
									Dim dataRow3 As DataRow = dataRow
									Dim columnIndex As Integer = 3
									Dim value3 As String = Conversions.ToString(dataRow3(columnIndex))
									Dim text2 As String = MImpred.AzimuthCheck(value3)
									dataRow(columnIndex) = value3
									Dim value6 As String = text2
									Dim num24 As Single = CSng(Convert.ToDouble(value6))
								End If
								If j = 1 And num19 <> 0F Then
									flag3 = True
									If num19 > 1000F Then
										' The following expression was wrapped in a unchecked-expression
										num25 = CInt(Math.Round(CDbl((num19 / 200F - 2F))))
										num7 = num20
										num8 = num21
										flag6 = True
										Exit For
									End If
									Exit For
								Else
									' The following expression was wrapped in a unchecked-expression
									If Not flag3 And j = 2 And num22 - num19 >= 1000F Then
										' The following expression was wrapped in a unchecked-expression
										num25 = CInt(Math.Round(CDbl((num22 / 200F - 2F))))
										num7 = num20
										num8 = num21
										flag6 = True
										Exit For
									End If
									If j = 3 Then
										Exit For
									End If
								End If
							Next
						Finally
							Dim enumerator As IEnumerator
							If TypeOf enumerator Is IDisposable Then
								TryCast(enumerator, IDisposable).Dispose()
							End If
						End Try
						If flag3 And Not flag6 Then
							num17 += 1
							array = New Single(num17 + 1 - 1) {}
							array2 = New Single(num17 + 1 - 1) {}
							array3 = New Single(num17 + 1 - 1) {}
							array6 = New MImpred.survey_point_type(num17 + 1 - 1) {}
						ElseIf flag3 AndAlso flag6 Then
							num17 = num17 + num25 + 1
							array = New Single(num17 + 1 - 1) {}
							array2 = New Single(num17 + 1 - 1) {}
							array3 = New Single(num17 + 1 - 1) {}
							array6 = New MImpred.survey_point_type(num17 + 1 - 1) {}
						ElseIf flag6 Then
							num17 += num25
							array = New Single(num17 + 1 - 1) {}
							array2 = New Single(num17 + 1 - 1) {}
							array3 = New Single(num17 + 1 - 1) {}
							array6 = New MImpred.survey_point_type(num17 + 1 - 1) {}
						End If
					End If
					j = 0
					Try
						For Each obj2 As Object In dataView
							Dim dataRowView As DataRowView = CType(obj2, DataRowView)
							Dim row As DataRow = dataRowView.Row
							j += 1
							Dim num19 As Single = CSng(Convert.ToDouble(RuntimeHelpers.GetObjectValue(row(1))))
							Dim value2 As String = MImpred.InclinationCheck(Conversions.ToString(row(2)))
							Dim num20 As Single = CSng(Convert.ToDouble(value2))
							Dim dataRow As DataRow = row
							Dim dataRow4 As DataRow = dataRow
							Dim columnIndex As Integer = 3
							Dim value3 As String = Conversions.ToString(dataRow4(columnIndex))
							Dim text3 As String = MImpred.AzimuthCheck(value3)
							dataRow(columnIndex) = value3
							Dim value4 As String = text3
							Dim num21 As Single = CSng(Convert.ToDouble(value4))
							If j = 1 Then
								If flag3 Then
									array(j) = 0F
									array2(j) = 0F
									array3(j) = 0F
									num7 = 0F
									num8 = 0F
									j += 1
									If Not flag6 Then
										array(j) = num19
										array2(j) = num20
										array3(j) = num21
									End If
								End If
								If flag6 Then
									If Not flag3 Then
										array(j) = num19
										array2(j) = num20
										array3(j) = num21
										j += 1
									End If
									Dim num26 As Integer = 1
									Dim num27 As Integer = num25
									For k As Integer = num26 To num27
										array(j) = CSng((k * 200))
										array2(j) = num7
										array3(j) = num8
										If k <> num25 Then
											j += 1
										End If
									Next
								End If
								flag3 = False
								flag6 = False
							Else
								array(j) = num19
								array2(j) = num20
								array3(j) = num21
							End If
						Next
					Finally
						Dim enumerator2 As IEnumerator
						If TypeOf enumerator2 Is IDisposable Then
							TryCast(enumerator2, IDisposable).Dispose()
						End If
					End Try
					array5 = New Single(num17 + 1 - 1) {}
					array4 = New Single(num17 + 1 - 1) {}
					MImpred.CalcDogleg(array, array2, array3, array5, array4, num17)
					i = 1
					If array(1) <> 0F Then
						num9 = 1
						teimpred.set_s_p_m_d(i, 0.0)
						teimpred.set_s_p_inc(i, 0.0)
						teimpred.set_s_p_azi(i, 0.0)
						i += 1
					End If
					flag4 = (teimpred.num_survey_points <= 300)
					Try
						Dim num28 As Integer = num9
						Dim num29 As Integer = num17
						j = num28
						While j <= num29
							num4 = array(j)
							Dim num30 As Double = CDbl(array2(j))
							Dim num31 As Double = CDbl(array3(j))
							Dim num32 As Single = array4(j)
							Dim num33 As Single
							Dim num34 As Single
							Dim num37 As Single
							Dim flag11 As Boolean
							If j = 1 Then
								num5 = num4
								num33 = num32
								num34 = array(j + 1)
								Dim num35 As Double = CDbl(array2(j + 1))
								Dim num36 As Double = CDbl(array3(j + 1))
								num37 = array4(j + 1)
							Else
								If Not(flag5 And Not flag11) Then
									num5 = array(j - 1)
								End If
								Dim num38 As Double = CDbl(array2(j - 1))
								Dim num39 As Double = CDbl(array3(j - 1))
								num33 = array4(j - 1)
								If j < num17 Then
									num34 = array(j + 1)
									Dim num35 As Double = CDbl(array2(j + 1))
									Dim num36 As Double = CDbl(array3(j + 1))
									num37 = array4(j + 1)
								Else
									num34 = num4
									num37 = num32
								End If
							End If
							Dim cart_coord_type As MImpred.cart_coord_type
							Dim cart_coord_type2 As MImpred.cart_coord_type
							If j = 1 Then
								Dim num38 As Double = CDbl(array2(j))
								Dim num39 As Double = CDbl(array3(j))

									array6(j).tan.X = Math.Sin(num38) * Math.Sin(num39)
									array6(j).tan.Y = Math.Sin(num38) * Math.Cos(num39)
									array6(j).tan.z = Math.Cos(num38)

								num30 = CDbl(array2(j + 1))
								num31 = CDbl(array3(j + 1))
								array6(j + 1).tan.X = Math.Sin(num30) * Math.Sin(num31)
								array6(j + 1).tan.Y = Math.Sin(num30) * Math.Cos(num31)
								array6(j + 1).tan.z = Math.Cos(num30)
							ElseIf j > 1 And j < num17 Then
								Dim num35 As Double = CDbl(array2(j + 1))
								Dim num36 As Double = CDbl(array3(j + 1))
								array6(j + 1).tan.X = Math.Sin(num35) * Math.Sin(num36)
								array6(j + 1).tan.Y = Math.Sin(num35) * Math.Cos(num36)
								array6(j + 1).tan.z = Math.Cos(num35)
								If array6(j - 1).dog > num Then
									MImpred.cross_prod(cart_coord_type, array6(j - 1).tan, array6(j).tan)
								Else
									array6(j - 1).nor.X = -9999.0
									array6(j - 1).nor.Y = -9999.0
									array6(j - 1).nor.z = -9999.0
								End If
								If array6(j).dog > num Then
									MImpred.cross_prod(cart_coord_type2, array6(j).tan, array6(j + 1).tan)
								Else
									array6(j).nor.X = -9999.0
									array6(j).nor.Y = -9999.0
									array6(j).nor.z = -9999.0
								End If
							ElseIf j = num17 Then
								j = j
							End If
							If j = 1 Or j = num17 Then
								flag11 = True
							ElseIf flag4 Then
								flag11 = True
							ElseIf j = 2 And num4 > 0F And num4 - num5 < RSWIN_DESC.SETUP_SteelSuckerRodLength Then
								flag11 = False
								num18 -= 1
							ElseIf(j = 2 Or j = 3) And num4 - num5 < num11 Then
								flag11 = False
								num18 -= 1
							ElseIf j > 1 And Math.Abs(cart_coord_type2.X - cart_coord_type.X) <= num2 * cart_coord_type2.X And Math.Abs(cart_coord_type2.Y - cart_coord_type.Y) <= num2 * cart_coord_type2.Y And Math.Abs(cart_coord_type2.z - cart_coord_type.z) <= num2 * cart_coord_type2.z And CDbl(Math.Abs(num32 - num33)) <= num3 * CDbl(num32) And CDbl(Math.Abs(num32 - num37)) <= num3 * CDbl(num32) Then
								flag11 = False
								num18 -= 1
							ElseIf flag8 And j Mod 2 <> 0 And i < 1500 And num18 > 0 Then
								flag11 = False
								num18 -= 1
							Else
								flag11 = True
							End If
							If Not flag11 And num5 < RSWIN_DESC.rst.PumpDepth And num34 > RSWIN_DESC.rst.PumpDepth Then
								flag11 = True
							End If
							If num31 > 360.0 Then
								flag11 = False
								num18 -= 1
							End If
							If num30 > 180.0 Then
								flag11 = False
								num18 -= 1
							End If
							If flag11 Then
								If Not flag10 And (num31 <> 0.0 Or num30 <> 0.0) And i > 1 Then
									flag10 = True
								End If
								If Not flag10 And num30 = 0.0 And i > 1 Then
									num30 = 0.0
								ElseIf num30 = 0.0 And i > 0 Then
									num30 = 0.0
								End If
								Try
									If i > Information.UBound(teimpred.s_p, 1) Then
										Dim teimpred2 As TEImpred = teimpred
										Dim array7 As TEImpred.survey_point_type() = teimpred2.s_p
										array7 = CType(Utils.CopyArray(CType(array7, Array), New TEImpred.survey_point_type(i + 1 - 1) {}), TEImpred.survey_point_type())
										teimpred2.s_p = array7
									End If
								Catch ex As Exception
								End Try
								teimpred.set_s_p_m_d(i, CDbl(num4))

									teimpred.set_s_p_azi(i, num31 / 180.0 * MImpred.m_PI)
									teimpred.set_s_p_inc(i, num30 / 180.0 * MImpred.m_PI)
									If i > 1 Then
										' The following expression was wrapped in a checked-expression
										num13 = CSng((teimpred.get_s_p_m_d(i) - teimpred.get_s_p_m_d(i - 1)))
										If(num13 < num14 And num13 <> 0F) AndAlso flag10 Then
											num14 = num13
										End If
										If i > 2 Then
											' The following expression was wrapped in a checked-expression
											Dim num40 As Single = CSng((teimpred.get_s_p_m_d(i) - teimpred.get_s_p_m_d(i - 2)))
											If(num40 < num15 And num40 <> 0F) AndAlso flag10 Then
												num15 = num40
											End If
										End If
									End If

								i += 1
							Else
								num6 += 1
							End If
							num5 = num4
							If num4 > RSWIN_DESC.rst.PumpDepth Then
								j = num17
							End If
							j += 1
						End While
					Catch ex2 As Exception
						If j > 1500 Or i > 1500 Then
							flag = True
						End If
					End Try
					teimpred.num_survey_points = i - 1
					If Not RSWIN_DESC.rst.gbAutomatic And Not RSWIN_DESC.rst.gbBatch Then
						If flag7 Then
							If((i - 1 > 1500 Or teimpred.num_survey_points > 1500) OrElse flag) Or teimpred.get_s_p_m_d(teimpred.num_survey_points) < CDbl(RSWIN_DESC.rst.PumpDepth) Then
								If num10 <> 0 Then
									flag8 = False
									If Not MImpred.bSurveyLimitErrorMsgShown Then
										MessageBox.Show(MImpred.sSurveyLimitErrorMsg)
										MImpred.bSurveyLimitErrorMsgShown = True
									End If
									RSWIN_DESC.bAbortRun = True
									Exit While
								End If
								num10 += 1
								flag8 = True
							Else
								flag8 = False
							End If
						Else
							flag8 = False
						End If
					ElseIf RSWIN_DESC.rst.gbBatch AndAlso flag7 Then
						If(teimpred.num_survey_points > 1500 OrElse flag) Or teimpred.get_s_p_m_d(teimpred.num_survey_points) < CDbl(RSWIN_DESC.rst.PumpDepth) Then
							If num10 = 0 Then
								num10 += 1
								flag8 = True
							Else
								flag8 = False
							End If
						Else
							flag8 = False
						End If
					Else
						flag8 = False
					End If
					Dim minTaperLength As Single = MImpred.GetMinTaperLength()
					If minTaperLength < num14 Then
						num14 = minTaperLength
					End If
					If minTaperLength < num15 Then
						num15 = minTaperLength
					End If
					MImpred.m_Impred.Max_Rod_Elements = CInt(Math.Round(CDbl((RSWIN_DESC.rst.PumpDepth / num14 + 0F))))
					If RSWIN_DESC.rst.PumpDepth / num15 > CSng(MImpred.m_Impred.num_rod_elements) Then
						If RSWIN_DESC.rst.PumpDepth / num15 < CSng(MImpred.m_Impred.Max_Rod_Elements) Then
							MImpred.m_Impred.num_rod_elements = CInt(Math.Round(CDbl((RSWIN_DESC.rst.PumpDepth / num15))))
						Else
							MImpred.m_Impred.num_rod_elements = MImpred.m_Impred.Max_Rod_Elements
						End If
					End If
					If MImpred.m_Impred.num_survey_points > MImpred.m_Impred.num_rod_elements Then
						MImpred.m_Impred.num_rod_elements = MImpred.m_Impred.num_survey_points
					End If
					If teimpred.get_s_p_m_d(2) - teimpred.get_s_p_m_d(1) < CDbl((RSWIN_DESC.rst.PumpDepth / CSng(MImpred.m_Impred.num_rod_elements))) Then
						Dim num41 As Integer = 2
						Dim num42 As Integer = teimpred.num_survey_points - 1
						i = num41
						While i <= num42
							teimpred.set_s_p_m_d(i, teimpred.get_s_p_m_d(i + 1))
							teimpred.set_s_p_azi(i, teimpred.get_s_p_azi(i + 1))
							teimpred.set_s_p_inc(i, teimpred.get_s_p_inc(i + 1))
							i += 1
						End While
						teimpred.num_survey_points = i - 1
					End If
					teimpred = Nothing
				End While
			Catch ex3 As Exception
			End Try
		End Sub

		Private Sub ReadSurvey_Oct2007()
			' The following expression was wrapped in a checked-statement
			Try
				Dim num As Double = 1E-06
				Dim num2 As Double = num / 1000.0
				Dim dataView As DataView = New DataView(RSWIN_DESC.mdsDeviationProfile.Tables(0))
				Dim num3 As Integer = 0
				Dim sDefaultName As String = "SteelSuckerRodLength"
				Dim value As Object = DBNull.Value
				Dim flag As Boolean = False
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(ini.GetDefault(sDefaultName, value, flag))
				RSWIN_DESC.SETUP_SteelSuckerRodLength = Conversions.ToSingle(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)), 25, RuntimeHelpers.GetObjectValue(objectValue)))
				Dim num4 As Integer = CInt(Math.Round(CDbl(RSWIN_DESC.SETUP_SteelSuckerRodLength)))
				dataView.Sort = "Depth"
				Dim i As Integer = 0
				MImpred.m_PI = 4.0 * Math.Atan(1.0)
				Dim teimpred As TEImpred = MImpred.m_Impred
				If RSWIN_DESC.mdsDeviationProfile.Tables(0).Rows.Count < 2 Then
					teimpred.num_survey_points = 2
					Dim num5 As Integer = 1
					Dim num_survey_points As Integer = teimpred.num_survey_points
					i = num5
					While i <= num_survey_points
						' The following expression was wrapped in a unchecked-expression
						teimpred.set_s_p_m_d(i, CDbl(RSWIN_DESC.rst.PumpDepth) * Conversion.Int(CDbl(i) / 2.0))
						teimpred.set_s_p_azi(i, 0.0)
						teimpred.set_s_p_inc(i, 0.0)
						i += 1
					End While
					MImpred.bUseMD = True
				Else
					i = 1
					Dim num6 As Integer = RSWIN_DESC.mdsDeviationProfile.Tables(0).Rows.Count
					Dim flag2 As Boolean = False
					MImpred.bUseMD = False
					Dim array As Single() = New Single(num6 + 1 - 1) {}
					Dim array2 As Single() = New Single(num6 + 1 - 1) {}
					Dim array3 As Single() = New Single(num6 + 1 - 1) {}
					Dim array4 As MImpred.survey_point_type() = New MImpred.survey_point_type(num6 + 1 - 1) {}
					Dim j As Integer = 0
					Try
						For Each obj As Object In dataView
							Dim dataRowView As DataRowView = CType(obj, DataRowView)
							Dim row As DataRow = dataRowView.Row
							j += 1
							array(j) = CSng(Convert.ToDouble(RuntimeHelpers.GetObjectValue(row(1))))
							Dim value2 As String = MImpred.InclinationCheck(Conversions.ToString(row(2)))
							array2(j) = CSng(Convert.ToDouble(value2))
							Dim dataRow As DataRow = row
							Dim dataRow2 As DataRow = dataRow
							Dim columnIndex As Integer = 3
							Dim value3 As String = Conversions.ToString(dataRow2(columnIndex))
							Dim text As String = MImpred.AzimuthCheck(value3)
							dataRow(columnIndex) = value3
							Dim value4 As String = text
							array3(j) = CSng(Convert.ToDouble(value4))
						Next
					Finally
						Dim enumerator As IEnumerator
						If TypeOf enumerator Is IDisposable Then
							TryCast(enumerator, IDisposable).Dispose()
						End If
					End Try
					If array(1) <> 0F Then
						num6 += 1
						array = CType(Utils.CopyArray(CType(array, Array), New Single(num6 + 1 - 1) {}), Single())
						array2 = CType(Utils.CopyArray(CType(array2, Array), New Single(num6 + 1 - 1) {}), Single())
						array3 = CType(Utils.CopyArray(CType(array3, Array), New Single(num6 + 1 - 1) {}), Single())
						array4 = CType(Utils.CopyArray(CType(array4, Array), New MImpred.survey_point_type(num6 + 1 - 1) {}), MImpred.survey_point_type())
						i = num6
						While i >= 2
							array(i) = array(i - 1)
							array2(i) = array2(i - 1)
							array3(i) = array3(i - 1)
							i += -1
						End While
						array(1) = 0F
						array2(1) = 0F
						array3(1) = 0F
					End If
					Dim num7 As Integer = 1
					Dim num8 As Integer = num6
					Dim num9 As Integer
					j = num7
					While j <= num8
						If array(j) >= RSWIN_DESC.rst.PumpDepth Then
							num9 = j
							j = num6
						End If
						j += 1
					End While
					Dim num10 As Integer = 1
					Dim num11 As Integer = num9
					j = num10
					While j <= num11
						teimpred.set_s_p_m_d(j, CDbl(array(j)))

							teimpred.set_s_p_inc(j, CDbl((array2(j) / 180F)) * MImpred.m_PI)
							teimpred.set_s_p_azi(j, CDbl((array3(j) / 180F)) * MImpred.m_PI)
							array4(j).m_d = MImpred.m_Impred.get_s_p_m_d(j)
							array4(j).inc = MImpred.m_Impred.get_s_p_inc(j)
							array4(j).azi = MImpred.m_Impred.get_s_p_azi(j)
							Dim array5 As MImpred.survey_point_type() = array4
							Dim num12 As Integer = j
							Dim num13 As Double = teimpred.get_s_p(j).inc
							Dim num14 As Double = teimpred.get_s_p(j).azi
							MImpred.calc_tan(array5(num12).tan, num13, num14)

						j += 1
					End While
					Dim array6 As Single() = New Single(num6 + 1 - 1) {}
					Dim array7 As Single() = New Single(num6 + 1 - 1) {}
					MImpred.CalcDogleg(array, array2, array3, array6, array7, num6)
					Dim num15 As Integer = 1
					Dim num16 As Integer = num9
					j = num15
					While j <= num16
						Dim num17 As Single = array(j)
						Dim num18 As Double = CDbl(array2(j))
						Dim num19 As Double = CDbl(array3(j))
						Dim num20 As Single = array7(j)
						If j = 1 Then
							Dim num21 As Single = array(j + 1)
							Dim num22 As Double = CDbl(array2(j + 1))
							Dim num23 As Double = CDbl(array3(j + 1))
							Dim num24 As Single = array7(j + 1)
						Else
							Dim num25 As Single = array(j - 1)
							Dim num26 As Double = CDbl(array2(j - 1))
							Dim num27 As Double = CDbl(array3(j - 1))
							Dim num28 As Single = array7(j - 1)
							If j < num6 Then
								Dim num21 As Single = array(j + 1)
								Dim num22 As Double = CDbl(array2(j + 1))
								Dim num23 As Double = CDbl(array3(j + 1))
								Dim num24 As Single = array7(j + 1)
							End If
						End If
						If j < num9 Then
							array4(j).dog = -9999.0
							MImpred.calc_dog(array4(j).dog, array4(j).tan, array4(j + 1).tan, num)
							array4(j).rad = -9999.0
							If array4(j).dog > num Then
								' The following expression was wrapped in a unchecked-expression
								' The following expression was wrapped in a checked-expression
								array4(j).rad = array4(j + 1).m_d - array4(j).m_d / array4(j).dog
							End If
							array4(j).nor.X = -9999.0
							array4(j).nor.Y = -9999.0
							array4(j).nor.z = -9999.0
							If array4(j).dog > num Then
								MImpred.calc_nor(array4(j).nor, array4(j).tan, array4(j + 1).tan)
							Else
								' The following expression was wrapped in a unchecked-expression
								' The following expression was wrapped in a checked-expression
								Dim num14 As Double = teimpred.get_s_p(j + 1).inc + num2
								Dim num13 As Double = teimpred.get_s_p(j + 1).azi
								Dim cart_coord_type As MImpred.cart_coord_type
								MImpred.calc_tan(cart_coord_type, num14, num13)
								MImpred.calc_nor(array4(j).nor, array4(j).tan, cart_coord_type)
								If array4(j).nor.X < Math.Abs(num2) And array4(j).nor.Y < Math.Abs(num2) And array4(j).nor.z < Math.Abs(num2) Then
									j = j * 1 + 0
								End If
							End If
						ElseIf j = num9 Then
							array4(j).dog = -9999.0
							array4(j).rad = -9999.0
							array4(j).nor.X = -9999.0
							array4(j).nor.Y = -9999.0
							array4(j).nor.z = -9999.0
						End If
						Dim flag3 As Boolean = True
						If flag3 Then
							If Not flag2 And num18 <> 0.0 And i = 1 Then
								flag2 = True
							End If
							If Not flag2 And (num19 <> 0.0 Or num18 <> 0.0) And i > 1 Then
								flag2 = True
							End If
							i += 1
						Else
							num3 += 1
							teimpred.set_s_p_m_d(j, CDbl(num17))

								teimpred.set_s_p_azi(j, num19 / 180.0 * MImpred.m_PI)
								teimpred.set_s_p_inc(j, num18 / 180.0 * MImpred.m_PI)

						End If
						If teimpred.get_s_p_m_d(j) >= CDbl(RSWIN_DESC.rst.PumpDepth) Then
							j = num9
						End If
						j += 1
					End While
					teimpred.num_survey_points = i - 1
				End If
				teimpred = Nothing
			Catch ex As Exception
			End Try
		End Sub

		Private Sub ReadSurvey_SAVE()
			' The following expression was wrapped in a checked-statement
			Try
				Dim dataView As DataView = New DataView(RSWIN_DESC.mdsDeviationProfile.Tables(0))
				Dim num As Single = 0F
				Dim num2 As Integer = 0
				Dim flag As Boolean = False
				Dim sDefaultName As String = "SteelSuckerRodLength"
				Dim value As Object = DBNull.Value
				Dim flag2 As Boolean = False
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(ini.GetDefault(sDefaultName, value, flag2))
				RSWIN_DESC.SETUP_SteelSuckerRodLength = Conversions.ToSingle(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)), 25, RuntimeHelpers.GetObjectValue(objectValue)))
				Dim num3 As Integer = CInt(Math.Round(CDbl(RSWIN_DESC.SETUP_SteelSuckerRodLength)))
				dataView.Sort = "Depth"
				Dim i As Integer = 0
				MImpred.m_PI = 4.0 * Math.Atan(1.0)
				Dim num4 As Single = 100000F
				Dim num5 As Single = 100000F
				Dim num6 As Single = 100000F
				Dim teimpred As TEImpred = MImpred.m_Impred
				If RSWIN_DESC.mdsDeviationProfile.Tables(0).Rows.Count < 2 Then
					teimpred.num_survey_points = 2
					Dim num7 As Integer = 1
					Dim num_survey_points As Integer = teimpred.num_survey_points
					i = num7
					While i <= num_survey_points

							teimpred.set_s_p_m_d(i, CDbl(RSWIN_DESC.rst.PumpDepth) * Conversion.Int(CDbl(i) / 2.0))
							teimpred.set_s_p_azi(i, 0.0)
							teimpred.set_s_p_inc(i, 0.0)
							If i > 1 Then
								' The following expression was wrapped in a checked-expression
								num4 = CSng((teimpred.get_s_p_m_d(i) - teimpred.get_s_p_m_d(i - 1)))
							End If

						i += 1
					End While
					num5 = num4
					num6 = num4 * 2F
				Else
					i = 1
					Dim flag3 As Boolean = False
					Dim flag4 As Boolean = False
					Try
						For Each obj As Object In dataView
							Dim dataRowView As DataRowView = CType(obj, DataRowView)
							Dim row As DataRow = dataRowView.Row
							Dim num8 As Single = CSng(Convert.ToDouble(RuntimeHelpers.GetObjectValue(row(1))))
							If i = 1 Then
								num = num8
							End If
							If i = 1 And Convert.ToDouble(RuntimeHelpers.GetObjectValue(row(1))) <> 0.0 Then
								teimpred.set_s_p_m_d(i, 0.0)
								teimpred.set_s_p_inc(i, 0.0)
								teimpred.set_s_p_azi(i, 0.0)
								i += 1
							End If
							If num8 - num >= CSng(num3) Or i <= 2 Then
								Dim value2 As Double = Convert.ToDouble(RuntimeHelpers.GetObjectValue(row(1)))
								Dim dataRow As DataRow = row
								Dim dataRow2 As DataRow = dataRow
								Dim columnIndex As Integer = 3
								Dim value3 As String = Conversions.ToString(dataRow2(columnIndex))
								Dim text As String = MImpred.AzimuthCheck(value3)
								dataRow(columnIndex) = value3
								Dim value4 As String = text
								Dim value5 As String = MImpred.InclinationCheck(Conversions.ToString(row(2)))
								Dim num9 As Double = Convert.ToDouble(value4)
								Dim num10 As Double = Convert.ToDouble(value5)
								If Not flag3 And (num9 <> 0.0 Or num10 <> 0.0) And i > 1 Then
									flag3 = True
								End If
								If Not flag3 And num10 = 0.0 And i > 1 Then
									num10 = 0.01
								ElseIf num10 = 0.0 And i > 0 Then
									num10 = 0.0001
								End If
								teimpred.set_s_p_m_d(i, value2)

									teimpred.set_s_p_azi(i, num9 / 180.0 * MImpred.m_PI)
									teimpred.set_s_p_inc(i, num10 / 180.0 * MImpred.m_PI)

								If i > 1 Then
									If flag Then
										flag4 = (i > 2 And (teimpred.get_s_p_azi(i) = teimpred.get_s_p_azi(i - 1) And teimpred.get_s_p_inc(i) = teimpred.get_s_p_inc(i - 1)) And teimpred.get_s_p_m_d(i) < CDbl(RSWIN_DESC.rst.PumpDepth))
									End If

										' The following expression was wrapped in a checked-expression
										num4 = CSng((teimpred.get_s_p_m_d(i) - teimpred.get_s_p_m_d(i - 1)))
										If(num4 < num5 And num4 <> 0F) AndAlso (flag3 And Not flag4) Then
											num5 = num4
										End If
										If i > 2 Then
											' The following expression was wrapped in a checked-expression
											Dim num11 As Single = CSng((teimpred.get_s_p_m_d(i) - teimpred.get_s_p_m_d(i - 2)))
											If((num11 < num6 And num11 <> 0F) AndAlso flag3) And Not flag4 Then
												num6 = num11
											End If
										End If

									If flag4 Then
										i -= 1
										num8 = CSng(teimpred.get_s_p_m_d(i))
									End If
								End If
								i += 1
							Else
								num2 += 1
							End If
							num = num8
						Next
					Finally
						Dim enumerator As IEnumerator
						If TypeOf enumerator Is IDisposable Then
							TryCast(enumerator, IDisposable).Dispose()
						End If
					End Try
					teimpred.num_survey_points = i - 1
					Dim minTaperLength As Single = MImpred.GetMinTaperLength()
					If minTaperLength < num5 Then
						num5 = minTaperLength
					End If
					If minTaperLength < num6 Then
						num6 = minTaperLength
					End If
					MImpred.m_Impred.Max_Rod_Elements = CInt(Math.Round(CDbl((RSWIN_DESC.rst.PumpDepth / num5 + 0F))))
					If RSWIN_DESC.rst.PumpDepth / num6 > CSng(MImpred.m_Impred.num_rod_elements) Then
						If RSWIN_DESC.rst.PumpDepth / num6 < CSng(MImpred.m_Impred.Max_Rod_Elements) Then
							MImpred.m_Impred.num_rod_elements = CInt(Math.Round(CDbl((RSWIN_DESC.rst.PumpDepth / num6))))
						Else
							MImpred.m_Impred.num_rod_elements = MImpred.m_Impred.Max_Rod_Elements
						End If
					End If
					If MImpred.m_Impred.num_survey_points > MImpred.m_Impred.num_rod_elements Then
						MImpred.m_Impred.num_rod_elements = MImpred.m_Impred.num_survey_points
					End If
				End If
				teimpred = Nothing
			Catch ex As Exception
			End Try
		End Sub

		Private Function GetMinTaperLength() As Single
			Dim num As Single = 1000000F
			Try
				Dim num2 As Integer = 1
				Dim numRods As Integer = CInt(RSWIN_DESC.rst.NumRods)
				For i As Integer = num2 To numRods
					If RSWIN_DESC.rst.Sections(i).length < num Then
						num = RSWIN_DESC.rst.Sections(i).length
					End If
				Next
			Catch ex As Exception
				num = 1000000F
			End Try
			Return num
		End Function

		Private Sub ReadTubingTapers()
			Dim num As Integer
			Dim num2 As Integer
			Dim obj As Object
			Try
				ProjectData.ClearProjectError()
				num = 2
				Dim impred As TEImpred = MImpred.m_Impred
				impred.num_tbg_tapers = 1
				impred.set_t_t_taper_depth(1, CDbl(RSWIN_DESC.rst.PumpDepth))
				impred.set_t_t_tbg_id(1, CDbl(RSWIN_DESC.rst.TubingID))
				impred.set_t_t_tbg_od(1, CDbl(RSWIN_DESC.rst.TubingOD))
				impred.set_t_t_tbg_modulus(1, 30500000.0)
				IL_5E:
				GoTo IL_A1
				IL_60:
				num2 = -1
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_74:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num2 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_60
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_A1:
			If num2 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		Private Sub UnloadImpred()
			Try
				Dim num As Integer = 1
				Dim teimpred As TEImpred
				Dim array As Single() = New Single(CInt((RSWIN_DESC.rst.NumRods + 1S)) - 1) {}
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				Dim inputfile As String = rst.Inputfile
				Dim text As String = Nothing
				Dim text2 As String
				Dim text3 As String
				Dim text4 As String
				FILEIO.SplitPath(inputfile, text2, text3, text4, text)
				rst.Inputfile = inputfile
				teimpred = MImpred.m_Impred
				RSWIN_DESC.rst.Ntsteps = CShort(teimpred.num_timesteps)
				Dim array2 As Single() = New Single(CInt((RSWIN_DESC.rst.Ntsteps - 1S + 1S)) - 1) {}
				RSWIN_DESC.rst.SurfPos = array2
				array2 = New Single(CInt((RSWIN_DESC.rst.Ntsteps - 1S + 1S)) - 1) {}
				RSWIN_DESC.rst.SurfLoad = array2
				array2 = New Single(CInt((RSWIN_DESC.rst.Ntsteps - 1S + 1S)) - 1) {}
				RSWIN_DESC.rst.PumpPos = array2
				array2 = New Single(CInt((RSWIN_DESC.rst.Ntsteps - 1S + 1S)) - 1) {}
				RSWIN_DESC.rst.PumpLoad = array2
				array2 = New Single(CInt((RSWIN_DESC.rst.Ntsteps - 1S + 1S)) - 1) {}
				RSWIN_DESC.rst.PermLoad = array2
				array2 = New Single(CInt((RSWIN_DESC.rst.Ntsteps - 1S + 1S)) - 1) {}
				RSWIN_DESC.rst.prvel = array2
				array2 = New Single(CInt((RSWIN_DESC.rst.Ntsteps - 1S + 1S)) - 1) {}
				RSWIN_DESC.rst.Thetac = array2
				array2 = New Single(CInt((RSWIN_DESC.rst.Ntsteps - 1S + 1S)) - 1) {}
				RSWIN_DESC.rst.Tf = array2
				Dim tnet As Single(,) = New Single(2, CInt((RSWIN_DESC.rst.Ntsteps - 1S + 1S)) - 1) {}
				RSWIN_DESC.rst.Tnet = tnet
				RSWIN_DESC.rst.Pprload = CSng(teimpred.get_t_s(1).p_r_force)
				RSWIN_DESC.rst.Mprload = CSng(teimpred.get_t_s(1).p_r_force)
				Dim flag As Boolean = True
				Try
					Dim num2 As Short
					If Not RSWIN_DESC.bBETA And RSWIN_DESC.bWriteCSVFIles Then
						text = "c:\TempRSWINFiles\Impred-Torques.csv"
						If FILEUTIL.FileExists(text) Then
							FileSystem.Kill("c:\TempRSWINFiles\Impred-Torques.csv")
						End If
						num2 = CShort(FileSystem.FreeFile())
						FileSystem.FileOpen(CInt(num2), "c:\TempRSWINFiles\Impred-Torques.csv", OpenMode.Output, OpenAccess.[Default], OpenShare.[Default], -1)
						FileSystem.PrintLine(CInt(num2), New Object() { "Index , Existing , BalancedT" })
					End If
					Dim num3 As Integer = 1
					Dim ntsteps As Integer = CInt(RSWIN_DESC.rst.Ntsteps)
					For i As Integer = num3 To ntsteps
						Dim timestep_data_type As TEImpred.timestep_data_type = teimpred.get_t_s(i)
						RSWIN_DESC.rst.SurfPos(i - 1) = CSng(timestep_data_type.p_r_position)
					Next
					Dim surfPos As Single() = RSWIN_DESC.rst.SurfPos
					Dim num4 As Single = 0F
					Dim num5 As Single = 0F
					Dim num6 As Single = 0F
					Dim num7 As Single
					Util.Maxmin(surfPos, num4, num5, num7, num6)
					RSWIN_DESC.rst.NtstepsUpstroke = CShort(Math.Round(CDbl(num7)))
					Dim num8 As Integer = 1
					Dim ntsteps2 As Integer = CInt(RSWIN_DESC.rst.Ntsteps)
					For i As Integer = num8 To ntsteps2
						Dim timestep_data_type2 As TEImpred.timestep_data_type = teimpred.get_t_s(i)
						RSWIN_DESC.rst.SurfPos(i - 1) = CSng(timestep_data_type2.p_r_position)
						If i < CInt(RSWIN_DESC.rst.NtstepsUpstroke) Then
							' The following expression was wrapped in a unchecked-expression
							RSWIN_DESC.rst.SurfLoad(i - 1) = CSng((timestep_data_type2.p_r_force + CDbl(RSWIN_DESC.rst.StuffingBoxFriction) - CDbl(RSWIN_DESC.rst.TubingPressure) * Math.Pow(CDbl(RSWIN_DESC.rst.PR_Diameter), 2.0) * 3.141592653589793 / 4.0))
						Else
							' The following expression was wrapped in a unchecked-expression
							RSWIN_DESC.rst.SurfLoad(i - 1) = CSng((timestep_data_type2.p_r_force - CDbl(RSWIN_DESC.rst.StuffingBoxFriction) - CDbl(RSWIN_DESC.rst.TubingPressure) * Math.Pow(CDbl(RSWIN_DESC.rst.PR_Diameter), 2.0) * 3.141592653589793 / 4.0))
						End If
						RSWIN_DESC.rst.PermLoad(i - 1) = CSng(timestep_data_type2.p_r_force_permissible)
						If RSWIN_DESC.rst.SurfLoad(i - 1) > RSWIN_DESC.rst.Pprload Then
							RSWIN_DESC.rst.Pprload = RSWIN_DESC.rst.SurfLoad(i - 1)
						End If
						If RSWIN_DESC.rst.SurfLoad(i - 1) < RSWIN_DESC.rst.Mprload Then
							RSWIN_DESC.rst.Mprload = RSWIN_DESC.rst.SurfLoad(i - 1)
						End If
						RSWIN_DESC.rst.PumpPos(i - 1) = CSng((timestep_data_type2.pump_displacement * 12.0))
						RSWIN_DESC.rst.PumpLoad(i - 1) = CSng(timestep_data_type2.pump_force)
						Dim crank_angle As Double = timestep_data_type2.crank_angle
						Dim num9 As Double = 0.0
						Dim num10 As Double = 0.0
						Dim num11 As Double = 0.0
						Dim num12 As Double
						kinemat.Kinematics(crank_angle, num9, num10, num11, num12, -1, 0F)
						RSWIN_DESC.rst.prvel(i - 1) = CSng(num12)
						RSWIN_DESC.rst.Tf(i - 1) = CSng(timestep_data_type2.torq_fact)
						RSWIN_DESC.rst.Thetac(i - 1) = CSng(timestep_data_type2.crank_angle)
						If RSWIN_DESC.rst.PU.UnitType <> 7S And RSWIN_DESC.rst.PU.UnitType <> 10S Then
							While RSWIN_DESC.rst.Thetac(i - 1) < 0F
								' The following expression was wrapped in a unchecked-expression
								' The following expression was wrapped in a checked-expression
								RSWIN_DESC.rst.Thetac(i - 1) = CSng((CDbl(RSWIN_DESC.rst.Thetac(i - 1)) + 2.0 * MImpred.m_PI))
							End While
							While CDbl(RSWIN_DESC.rst.Thetac(i - 1)) >= 2.0 * MImpred.m_PI
								' The following expression was wrapped in a unchecked-expression
								' The following expression was wrapped in a checked-expression
								RSWIN_DESC.rst.Thetac(i - 1) = CSng((CDbl(RSWIN_DESC.rst.Thetac(i - 1)) - 2.0 * MImpred.m_PI))
							End While
						End If
						RSWIN_DESC.rst.Tnet(2, i - 1) = CSng((timestep_data_type2.torq_crank * 12.0))
						RSWIN_DESC.rst.Tnet(1, i - 1) = CSng((timestep_data_type2.torq_crank_bal * 12.0))
						If Not RSWIN_DESC.bBETA And RSWIN_DESC.bWriteCSVFIles Then
							FileSystem.PrintLine(CInt(num2), New Object() { String.Concat(New String() { Conversions.ToString(i - 1), "  ,  ", Conversions.ToString(RSWIN_DESC.rst.Tnet(2, i - 1)), "  ,  ", Conversions.ToString(RSWIN_DESC.rst.Tnet(1, i - 1)) }) })
						End If
					Next
					If If((-If((RSWIN_DESC.bRodStarD > False), 1S, 0S)), 1S, 0S) And RSWIN_DESC.SETUP_UseImpred And (If((-If((RSWIN_DESC.rst.MotorSPV > 0F > False), 1S, 0S)), 1S, 0S) Or RSWIN_DESC.rst.CalcMotorSPV) And If((-If((flag > False), 1S, 0S)), 1S, 0S) <> 0S AndAlso RSWIN_DESC.rst.SurfLoad(0) <> RSWIN_DESC.rst.SurfLoad(CInt((RSWIN_DESC.rst.Ntsteps - 1S))) Then
						RSWIN_DESC.rst.SurfLoad(0) = RSWIN_DESC.rst.SurfLoad(CInt((RSWIN_DESC.rst.Ntsteps - 1S)))
					End If
					If Not RSWIN_DESC.bBETA And RSWIN_DESC.bWriteCSVFIles Then
						FileSystem.FileClose(New Integer() { CInt(num2) })
						Application.DoEvents()
					End If
				Catch ex As Exception
				End Try
				num = 0
				If num = 1 Then
					Debug.WriteLine(" ")
					If RSWIN_DESC.rst.gbIncludeBuoyancy Then
						Debug.WriteLine("User wants   buoyed stresses")
					Else
						Debug.WriteLine("User wants UNbuoyed stresses")
					End If
					Debug.WriteLine("n,maxStrTop,minStrTop,minStrBot")
				End If
				Dim num13 As Integer = 1
				Dim numRods As Integer = CInt(RSWIN_DESC.rst.NumRods)
				For i As Integer = num13 To numRods

						Dim num14 As Single
						num14 += RSWIN_DESC.rst.Sections(i).length
						array(i) = num14
						RSWIN_DESC.rst.maxStressTop(i) = CSng(teimpred.get_r_t(i).max_taper_stress_top)
						RSWIN_DESC.rst.minStressTop(i) = CSng(teimpred.get_r_t(i).min_taper_stress_top)
						If Not RSWIN_DESC.rst.gbIncludeBuoyancy Then
							If(If((-If((RSWIN_DESC.SETUP_UseBucklingTendencyStresses > False), 1S, 0S)), 1S, 0S) And Not RSWIN_DESC.rst.IncludeFluidInertia) <> 0S Then
								RSWIN_DESC.rst.maxStressTop(i) = CSng(teimpred.get_r_t(i).max_buckle_stress_top)
								RSWIN_DESC.rst.minStressTop(i) = CSng(teimpred.get_r_t(i).min_buckle_stress_top)
								RSWIN_DESC.rst.maxStressBot(i) = CSng(teimpred.get_r_t(i).max_buckle_stress_bot)
								RSWIN_DESC.rst.minStressBot(i) = CSng(teimpred.get_r_t(i).min_buckle_stress_bot)
							ElseIf i = 1 Then
								RSWIN_DESC.rst.maxStressBot(i) = CSng(teimpred.get_r_t(i).max_taper_stress_bot)
								RSWIN_DESC.rst.minStressBot(i) = CSng(teimpred.get_r_t(i).min_taper_stress_bot)
								RSWIN_DESC.rst.maxStressTop(i) = CSng(teimpred.get_r_t(i).max_taper_stress_top_buoyed)
								RSWIN_DESC.rst.minStressTop(i) = CSng(teimpred.get_r_t(i).min_taper_stress_top_buoyed)
							Else
								RSWIN_DESC.rst.maxStressBot(i) = CSng(teimpred.get_r_t(i).max_taper_stress_bot)
								RSWIN_DESC.rst.minStressBot(i) = CSng(teimpred.get_r_t(i).min_taper_stress_bot)
								RSWIN_DESC.rst.maxStressTop(i) = CSng(teimpred.get_r_t(i).max_taper_stress_top)
								RSWIN_DESC.rst.minStressTop(i) = CSng(teimpred.get_r_t(i).min_taper_stress_top)
							End If
						Else
							RSWIN_DESC.rst.maxStressBot(i) = CSng(teimpred.get_r_t(i).max_taper_stress_bot_buoyed)
							RSWIN_DESC.rst.minStressBot(i) = CSng(teimpred.get_r_t(i).min_taper_stress_bot_buoyed)
							RSWIN_DESC.rst.maxStressTop(i) = CSng(teimpred.get_r_t(i).max_taper_stress_top_buoyed)
							RSWIN_DESC.rst.minStressTop(i) = CSng(teimpred.get_r_t(i).min_taper_stress_top_buoyed)
						End If
						If RSWIN_DESC.SETUP_UseJohnsFix AndAlso (RSWIN_DESC.bSBDiameterChanged Or RSWIN_DESC.bSteelAboveFGDiameterChanged) AndAlso MImpred.bDiameterChanged(i) Then
							Dim diameter As Single
							Dim flag2 As Boolean
							If RSWIN_DESC.bSteelAboveFGDiameterChanged And i < CInt(RSWIN_DESC.rst.NumRods) Then
								' The following expression was wrapped in a checked-expression
								If Not MImpred.bIsFGlass(i) And MImpred.bIsFGlass(i + 1) Then
									diameter = RSWIN_DESC.rst.Sections(i).Diameter
									flag2 = True
								Else
									flag2 = False
								End If
							Else
								flag2 = False
							End If
							If flag2 Then
								Dim num15 As Single = CSng((CDbl(RSWIN_DESC.rst.maxStressBot(i)) * teimpred.get_r_t_rod_area(i)))
								RSWIN_DESC.rst.maxStressBot(i) = num15 / RSWIN_DESC.rst.Sections(i).Area
								num15 = CSng((CDbl(RSWIN_DESC.rst.minStressBot(i)) * teimpred.get_r_t_rod_area(i)))
								RSWIN_DESC.rst.minStressBot(i) = num15 / RSWIN_DESC.rst.Sections(i).Area
								num15 = CSng((CDbl(RSWIN_DESC.rst.maxStressTop(i)) * teimpred.get_r_t_rod_area(i)))
								RSWIN_DESC.rst.maxStressTop(i) = num15 / RSWIN_DESC.rst.Sections(i).Area
								num15 = CSng((CDbl(RSWIN_DESC.rst.minStressTop(i)) * teimpred.get_r_t_rod_area(i)))
								RSWIN_DESC.rst.minStressTop(i) = num15 / RSWIN_DESC.rst.Sections(i).Area
							ElseIf i > 1 And RSWIN_DESC.rst.Sections(i - 1).Diameter >= RSWIN_DESC.rst.Sections(i).Diameter And Not(MImpred.bDiameterChanged(i - 1) And RSWIN_DESC.rst.Sections(i).Diameter = RSWIN_DESC.rst.Sections(i - 1).Diameter) Then
								Debug.WriteLine(" ")
							ElseIf i > 1 Then
								Dim num16 As Integer
								Dim previousNonSBDiameter As Boolean = MImpred.GetPreviousNonSBDiameter(i, diameter, (RODUTIL.IsSinkerBar(i) Or If((-If((CUSTOMRG.IsOtherSinkerBar(CInt(RSWIN_DESC.rst.Sections(i).Grade)) > False), 1, 0)), 1, 0)) <> 0, num16)
								If previousNonSBDiameter Then
									Dim num15 As Single = CSng((CDbl(RSWIN_DESC.rst.maxStressBot(i)) * teimpred.get_r_t_rod_area(i)))
									RSWIN_DESC.rst.maxStressBot(i) = num15 / RSWIN_DESC.rst.Sections(i).Area
									num15 = CSng((CDbl(RSWIN_DESC.rst.minStressBot(i)) * teimpred.get_r_t_rod_area(i)))
									RSWIN_DESC.rst.minStressBot(i) = num15 / RSWIN_DESC.rst.Sections(i).Area
									num15 = CSng((CDbl(RSWIN_DESC.rst.maxStressTop(i)) * teimpred.get_r_t_rod_area(i)))
									RSWIN_DESC.rst.maxStressTop(i) = num15 / RSWIN_DESC.rst.Sections(i).Area
									num15 = CSng((CDbl(RSWIN_DESC.rst.minStressTop(i)) * teimpred.get_r_t_rod_area(i)))
									RSWIN_DESC.rst.minStressTop(i) = num15 / RSWIN_DESC.rst.Sections(i).Area
								End If
							End If
						End If
						If num = 1 Then
							Debug.WriteLine(String.Concat(New String() { i.ToString(), ",", Conversions.ToString(RSWIN_DESC.rst.maxStressTop(i)), ",", Conversions.ToString(RSWIN_DESC.rst.minStressTop(i)), ",", Conversions.ToString(RSWIN_DESC.rst.minStressBot(i)) }))
						End If

				Next
				If RSWIN_DESC.rst.gbIncludeBuoyancy Or Not RSWIN_DESC.SETUP_UseBucklingTendencyStresses Then
					Dim rst2 As cRODSTAR = RSWIN_DESC.rst
					If RSWIN_DESC.rst.PumpDepthTVD = 0F Then
						RSWIN_DESC.rst.PumpDepthTVD = RSWIN_DESC.rst.PumpDepth
					End If
					If rst2.gbIncludeBuoyancy Then
						rst2.minStressBot(CInt(rst2.NumRods)) = CSng((-CSng((CDbl(rst2.FluidSPGR) * 0.433 * CDbl(rst2.PumpDepthTVD) * 1.075 + CDbl(rst2.TubingPressure)))))
					Else
						rst2.minStressBot(CInt(rst2.NumRods)) = 0F
					End If
					rst2.minStressBot(CInt(rst2.NumRods)) = rst2.minStressBot(CInt(rst2.NumRods)) - rst2.PumpFriction / rst2.Sections(CInt(rst2.NumRods)).Area
					rst2.maxStressTop(1) = (rst2.Pprload - rst2.StuffingBoxFriction) / rst2.Sections(1).Area
					rst2.minStressTop(1) = (rst2.Mprload + rst2.StuffingBoxFriction) / rst2.Sections(1).Area
				End If
				Dim num17 As Integer = 1
				Dim numRods2 As Integer = CInt(RSWIN_DESC.rst.NumRods)
				For i As Integer = num17 To numRods2
					Dim num18 As Single = MImpred.EffRodArea(RSWIN_DESC.rst.Sections(i), CShort(RODUTIL.IsSinkerBar(i)))

						If RSWIN_DESC.rst.Sections(i).Area <> num18 Then
							Dim num19 As Single = RSWIN_DESC.rst.maxStressTop(i) * RSWIN_DESC.rst.Sections(i).Area
							RSWIN_DESC.rst.maxStressTop(i) = num19 / num18
							num19 = RSWIN_DESC.rst.minStressTop(i) * RSWIN_DESC.rst.Sections(i).Area
							RSWIN_DESC.rst.minStressTop(i) = num19 / num18
						End If
						If(i > 1 And RSWIN_DESC.rst.Sections(i).Diameter > RSWIN_DESC.rst.Sections(i - 1).Diameter) AndAlso RSWIN_DESC.rst.minStressTop(i) < RSWIN_DESC.rst.minStressBot(i - 1) Then
							' The following expression was wrapped in a checked-expression
							' The following expression was wrapped in a checked-expression
							Dim num15 As Single = RSWIN_DESC.rst.minStressBot(i - 1) * RSWIN_DESC.rst.Sections(i - 1).Area
							RSWIN_DESC.rst.minStressTop(i) = num15 / num18
						End If

				Next
				If Not RSWIN_DESC.rst.gbIncludeBuoyancy Then
					Try
						RSWIN_DESC.rst.minStressBot(CInt(RSWIN_DESC.rst.NumRods)) = -(RSWIN_DESC.rst.PumpFriction / RSWIN_DESC.rst.Sections(CInt(RSWIN_DESC.rst.NumRods)).Area)
					Catch ex2 As Exception
					End Try
				End If
				If num = 1 Then
					Debug.WriteLine("n,maxStrTop,minStrTop,minStrBot")
					Debug.WriteLine(" ")
				End If
				RSWIN_DESC.rst.pPRHP = teimpred.PRHP
				RSWIN_DESC.rst.Prhp = teimpred.PRHP
				If teimpred.mot_pts_flag = 20 Then
					Try
						If RSWIN_DESC.rst.CalcMotorSPV <> 0S Then
							RSWIN_DESC.rst.MotorSPV = CSng(teimpred.spm_variation)
						End If
						If Not MImpred.bVBeltRatio Then
							teimpred.slippedRPM = 1200.0 - CDbl(teimpred.PRHP) / teimpred.hp_mot * (1200.0 - teimpred.rpm_full_load)
							MImpred.m_new_ratio_vb = teimpred.slippedRPM / teimpred.strokes_per_min / teimpred.ratio_gb
						End If
					Catch ex3 As Exception
					End Try
				End If
				RSWIN_DESC.rst.FluidLevelTVD = CSng(Math.Abs(teimpred.p_s.liquid_level_TVD))
				If RSWIN_DESC.rst.FluidLevelTVD = 0F Then
					RSWIN_DESC.rst.FluidLevelTVD = RSWIN_DESC.rst.FluidLevel
				End If
				If RSWIN_DESC.rst.PumpDepthTVD = 0F Then
					RSWIN_DESC.rst.PumpDepthTVD = RSWIN_DESC.rst.PumpDepth
				End If
				Dim num20 As Double = CDbl((RSWIN_DESC.rst.PumpDepthTVD - RSWIN_DESC.rst.FluidLevelTVD)) * (0.433 * CDbl(RSWIN_DESC.rst.OilSPGR)) + CDbl(RSWIN_DESC.rst.CasingPressure)
				Dim num21 As Double = CDbl(RSWIN_DESC.rst.PumpDepthTVD) * (0.433 * CDbl(RSWIN_DESC.rst.FluidSPGR)) + CDbl(RSWIN_DESC.rst.TubingPressure)
				RSWIN_DESC.rst.FluidLoad = CSng(((num21 - num20) * 3.141592653589793 / 4.0 * Math.Pow(CDbl(RSWIN_DESC.rst.PlungerSize), 2.0)))
				If(If((-If(((RSWIN_DESC.bRodStarD And RSWIN_DESC.bUseFluidInertiaPumpLoadAdj) > False), 1S, 0S)), 1S, 0S) And RSWIN_DESC.rst.IncludeFluidInertia And RSWIN_DESC.SETUP_UseImpred) <> 0S Then
					Dim num22 As Single = RSWIN_DESC.rst.PumpEfficiency / 100F
					RSWIN_DESC.rst.FluidLoad = RSWIN_DESC.rst.FluidLoad * num22
				End If
				If teimpred.save_pump_position_po > 0.0 Then
					RSWIN_DESC.rst.BPDsurface = CSng((teimpred.p_s.pump_volumetric_rate * CDbl(RSWIN_DESC.rst.Runtime) / 24.0))
				Else
					RSWIN_DESC.rst.BPDsurface = CSng((teimpred.p_s.pump_volumetric_rate * CDbl(RSWIN_DESC.rst.Runtime) / 24.0 * CDbl(RSWIN_DESC.rst.Pfill)))
				End If
				If RSWIN_DESC.rst.PumpCondition = 2S Or RSWIN_DESC.rst.PumpCondition = 3S Then
					RSWIN_DESC.rst.BPDsurface = RSWIN_DESC.rst.BPDsurface * RSWIN_DESC.rst.PumpEfficiency / 100F
				End If
				teimpred = Nothing
				MImpred.CalcWrodsInFluid()
			Catch ex4 As Exception
			End Try
		End Sub

		Public Function AzimuthCheck(ByRef sAZIMUTH As String) As String
			sAZIMUTH = Strings.StrConv(sAZIMUTH, VbStrConv.UpperCase, 0)
			Dim [string] As String = " "
			Dim flag As Boolean = False
			Dim flag2 As Boolean = False
			Dim flag3 As Boolean = False
			Dim flag4 As Boolean = False
			Dim flag5 As Boolean = False
			Dim text2 As String
			Dim num As Short = CShort(Strings.Len(sAZIMUTH))
			Dim string2 As String = Strings.Mid(sAZIMUTH, 1, CInt(num))
			Dim num2 As Short = CShort(Strings.InStr(string2, [string], CompareMethod.Binary))
			If num2 = 1S Then
				num2 = 0S
			End If
			Dim flag6 As Boolean = num2 > 0S
			Dim num3 As Short = CShort(Strings.InStr(sAZIMUTH, "N", CompareMethod.Binary))
			Dim num4 As Short = CShort(Strings.InStr(sAZIMUTH, "E", CompareMethod.Binary))
			Dim num5 As Short = CShort(Strings.InStr(sAZIMUTH, "S", CompareMethod.Binary))
			Dim num6 As Short = CShort(Strings.InStr(sAZIMUTH, "W", CompareMethod.Binary))
			Dim num7 As Short
			Dim num8 As Short
			If num3 = 0S And num5 = 0S And num4 = 0S And num6 = 0S Then
				flag5 = True
				num7 = 0S
				num8 = num
			ElseIf num3 > 0S And num4 > 0S Then
				flag = True
				num7 = num3
				num8 = num4
			ElseIf num3 > 0S And num6 > 0S Then
				flag2 = True
				num7 = num3
				num8 = num6
			ElseIf num5 > 0S And num4 > 0S Then
				flag3 = True
				num7 = num5
				num8 = num4
			ElseIf num5 > 0S And num6 > 0S Then
				flag4 = True
				num7 = num5
				num8 = num6
			End If
			If Not flag6 AndAlso flag5 Then
				Dim num9 As Double = Conversion.Val(sAZIMUTH)
				Dim text As String = "####.####"
				text2 = Util.Format(num9, text)
			ElseIf flag6 AndAlso flag5 Then
				Dim num10 As Short = CShort(Math.Round(Conversion.Val(Strings.Mid(sAZIMUTH, CInt((num7 + 1S)), CInt((num2 - 1S))))))
				Dim num11 As Short
				If num10 < 0S Then
					num11 = -1S
				Else
					num11 = 1S
				End If
				Dim num12 As Short = CShort(Math.Round(Conversion.Val(Strings.Mid(sAZIMUTH, CInt((num2 + 1S)), CInt(num8)))))
				Dim num13 As Single = CSng((CDbl((num11 * Math.Abs(num10))) + CDbl(num12) / 60.0))
				Dim text As String = "####.####"
				text2 = Util.Format(num13, text)
			ElseIf Not flag5 Then
				If flag6 Then
					Dim num10 As Short = CShort(Math.Round(Conversion.Val(Strings.Mid(sAZIMUTH, CInt((num7 + 1S)), CInt((num2 - 1S))))))
					Dim num12 As Short = CShort(Math.Round(Conversion.Val(Strings.Mid(sAZIMUTH, CInt((num2 + 1S)), CInt((num8 - 1S))))))

						Dim num14 As Single
						If flag Then
							num14 = CSng((CDbl(num10) + CDbl(num12) / 60.0))
						ElseIf flag2 Then
							num14 = CSng((-1.0 * (CDbl(num10) + CDbl(num12) / 60.0)))
						ElseIf flag3 Then
							num14 = CSng((180.0 - (CDbl(num10) + CDbl(num12) / 60.0)))
						ElseIf flag4 Then
							num14 = CSng((180.0 + (CDbl(num10) + CDbl(num12) / 60.0)))
						End If
						Dim text As String = "####.####"
						text2 = Util.Format(num14, text)

				Else
					Dim inputStr As String = Strings.Mid(sAZIMUTH, CInt((num7 + 1S)), CInt((num8 - 1S)))
					Dim num14 As Single = CSng(Conversion.Val(inputStr))

						If flag2 Then
							num14 = -num14
						ElseIf flag3 Then
							num14 = 180F - num14
						ElseIf flag4 Then
							num14 = 180F + num14
						End If
						Dim text As String = "####.####"
						text2 = Util.Format(num14, text)

				End If
			End If
			If Operators.CompareString(text2, ".", False) = 0 Or Operators.CompareString(text2, ",", False) = 0 Or Operators.CompareString(text2, "", False) = 0 Then
				text2 = "0"
			Else
				Dim num13 As Single = CSng(Convert.ToDouble(text2))
				If num13 < 0F Then
					num13 = 360F + num13
					Dim text As String = "####.####"
					text2 = Util.Format(num13, text)
				End If
			End If
			Return text2
		End Function

		Public Function AzimuthCheck_Old(sAZIMUTH As String) As String
			sAZIMUTH = Strings.StrConv(sAZIMUTH, VbStrConv.UpperCase, 0)
			Dim [string] As String = " "
			Dim flag As Boolean = False
			Dim flag2 As Boolean = False
			Dim flag3 As Boolean = False
			Dim flag4 As Boolean = False
			Dim flag5 As Boolean = False
			Dim text2 As String
			Dim length As Short = CShort(Strings.Len(sAZIMUTH))
			Dim string2 As String = Strings.Mid(sAZIMUTH, 1, CInt(length))
			Dim num As Short = CShort(Strings.InStr(string2, [string], CompareMethod.Binary))
			If num = 1S Then
				num = 0S
			End If
			Dim flag6 As Boolean = num > 0S
			Dim num2 As Short = CShort(Strings.InStr(sAZIMUTH, "N", CompareMethod.Binary))
			Dim num3 As Short = CShort(Strings.InStr(sAZIMUTH, "E", CompareMethod.Binary))
			Dim num4 As Short = CShort(Strings.InStr(sAZIMUTH, "S", CompareMethod.Binary))
			Dim num5 As Short = CShort(Strings.InStr(sAZIMUTH, "W", CompareMethod.Binary))
			If num2 = 0S And num4 = 0S And num3 = 0S And num5 = 0S Then
				flag5 = True
			ElseIf num2 > 0S And num3 > 0S Then
				flag = True
			ElseIf num2 > 0S And num5 > 0S Then
				flag2 = True
			ElseIf num4 > 0S And num3 > 0S Then
				flag3 = True
			ElseIf num4 > 0S And num5 > 0S Then
				flag4 = True
			End If
			If Not flag6 AndAlso flag5 Then
				Dim num6 As Double = Conversion.Val(sAZIMUTH)
				Dim text As String = "####.####"
				text2 = Util.Format(num6, text)
			ElseIf flag5 Then

					If Not flag6 Then
						Dim flag7 As Boolean = True
						If flag7 = flag Then
							text2 = sAZIMUTH
						ElseIf flag7 = flag2 Then
							Dim num6 As Double = Conversion.Val(sAZIMUTH) * -1.0
							Dim text As String = "####.####"
							text2 = Util.Format(num6, text)
						ElseIf flag7 = flag3 Then
							Dim num6 As Double = 180.0 - Conversion.Val(sAZIMUTH)
							Dim text As String = "####.####"
							text2 = Util.Format(num6, text)
						ElseIf flag7 = flag4 Then
							Dim num6 As Double = 180.0 + Conversion.Val(sAZIMUTH)
							Dim text As String = "####.####"
							text2 = Util.Format(num6, text)
						Else
							text2 = sAZIMUTH
						End If
					Else
						Dim num7 As Short
						Dim num8 As Short
						num7 = CShort(Math.Round(Conversion.Val(Strings.Mid(sAZIMUTH, 1, CInt((num - 1S))))))
						num8 = CShort(Math.Round(Conversion.Val(Strings.Mid(sAZIMUTH, CInt((num + 1S)), CInt(length)))))
						Dim num9 As Single = CSng((CDbl(num7) + CDbl(num8) / 60.0))
						Dim flag8 As Boolean = True
						If flag8 = flag Then
							Dim text As String = "####.####"
							text2 = Util.Format(num9, text)
						ElseIf flag8 = flag2 Then
							Dim num10 As Single = num9 * -1F
							Dim text As String = "####.####"
							text2 = Util.Format(num10, text)
						ElseIf flag8 = flag3 Then
							Dim num10 As Single = 180F - num9
							Dim text As String = "####.####"
							text2 = Util.Format(num10, text)
						ElseIf flag8 = flag4 Then
							Dim num10 As Single = 180F + num9
							Dim text As String = "####.####"
							text2 = Util.Format(num10, text)
						Else
							Dim text As String = "####.####"
							text2 = Util.Format(num9, text)
						End If
					End If

			ElseIf flag Then
				If Not flag6 Then
					Dim inputStr As String = Strings.Mid(sAZIMUTH, CInt((num2 + 1S)), CInt((num3 - 1S)))
					Dim num11 As Single = CSng(Conversion.Val(inputStr))
					Dim text As String = "####.####"
					text2 = Util.Format(num11, text)
				Else
					Dim num7 As Short = CShort(Math.Round(Conversion.Val(Strings.Mid(sAZIMUTH, CInt((num2 + 1S)), CInt((num - 1S))))))
					Dim num8 As Short = CShort(Math.Round(Conversion.Val(Strings.Mid(sAZIMUTH, CInt((num + 1S)), CInt((num3 - 1S))))))
					Dim num11 As Single = CSng((CDbl(num7) + CDbl(num8) / 60.0))
					Dim text As String = "####.####"
					text2 = Util.Format(num11, text)
				End If
			ElseIf flag2 Then
				If Not flag6 Then
					Dim inputStr As String = Strings.Mid(sAZIMUTH, CInt((num2 + 1S)), CInt((num5 - 1S)))
					Dim num11 As Single = CSng(Conversion.Val(inputStr))
					num11 = -num11
					Dim text As String = "####.####"
					text2 = Util.Format(num11, text)
				Else
					Dim num7 As Short = CShort(Math.Round(Conversion.Val(Strings.Mid(sAZIMUTH, CInt((num2 + 1S)), CInt((num - 1S))))))
					Dim num8 As Short = CShort(Math.Round(Conversion.Val(Strings.Mid(sAZIMUTH, CInt((num + 1S)), CInt((num5 - 1S))))))
					Dim num11 As Single = CSng((-1.0 * (CDbl(num7) + CDbl(num8) / 60.0)))
					Dim text As String = "####.####"
					text2 = Util.Format(num11, text)
				End If
			ElseIf flag3 Then
				If Not flag6 Then
					Dim inputStr As String = Strings.Mid(sAZIMUTH, CInt((num4 + 1S)), CInt((num3 - 1S)))
					Dim num11 As Single = CSng(Conversion.Val(inputStr))
					num11 = 180F - num11
					Dim text As String = "####.####"
					text2 = Util.Format(num11, text)
				Else
					Dim num7 As Short = CShort(Math.Round(Conversion.Val(Strings.Mid(sAZIMUTH, CInt((num4 + 1S)), CInt((num - 1S))))))
					Dim num8 As Short = CShort(Math.Round(Conversion.Val(Strings.Mid(sAZIMUTH, CInt((num + 1S)), CInt((num3 - 1S))))))
					Dim num11 As Single = CSng((180.0 - (CDbl(num7) + CDbl(num8) / 60.0)))
					Dim text As String = "####.####"
					text2 = Util.Format(num11, text)
				End If
			ElseIf flag4 Then
				If Not flag6 Then
					Dim inputStr As String = Strings.Mid(sAZIMUTH, CInt((num4 + 1S)), CInt((num5 - 1S)))
					Dim num11 As Single = CSng(Conversion.Val(inputStr))
					num11 = 180F + num11
					Dim text As String = "####.####"
					text2 = Util.Format(num11, text)
				Else
					Dim num7 As Short = CShort(Math.Round(Conversion.Val(Strings.Mid(sAZIMUTH, CInt((num4 + 1S)), CInt((num - 1S))))))
					Dim num8 As Short = CShort(Math.Round(Conversion.Val(Strings.Mid(sAZIMUTH, CInt((num + 1S)), CInt((num5 - 1S))))))
					Dim num11 As Single = CSng((180.0 + (CDbl(num7) + CDbl(num8) / 60.0)))
					Dim text As String = "####.####"
					text2 = Util.Format(num11, text)
				End If
			End If
			If Operators.CompareString(text2, ".", False) = 0 Or Operators.CompareString(text2, ",", False) = 0 Then
				text2 = "0"
			Else
				Dim num9 As Single = CSng(Convert.ToDouble(text2))
				If num9 < 0F Then
					num9 = 360F + num9
					Dim text As String = "####.####"
					text2 = Util.Format(num9, text)
				End If
			End If
			Return text2
		End Function

		Public Function InclinationCheck(sInclination As String) As String
			Dim [string] As String = " "
			Dim length As Short = CShort(Strings.Len(sInclination))
			Dim text As String = Strings.Mid(sInclination, 1, CInt(length))
			Dim num As Short = CShort(Strings.InStr(1, text, [string], CompareMethod.Binary))
			If num = 1S Then
				num = 0S
			End If
			Dim text2 As String
			If num = 0S Then
				text2 = sInclination
			Else
				Dim num2 As Short = CShort(Math.Round(Conversion.Val(Strings.Mid(text, 1, CInt((num - 1S))))))
				Dim num3 As Short = CShort(Math.Round(Conversion.Val(Strings.Mid(text, CInt((num + 1S)), CInt(length)))))
				Dim num4 As Single = CSng((CDbl(num2) + CDbl(num3) / 60.0))
				Dim num5 As Single = num4
				Dim text3 As String = "####.####"
				text2 = Util.Format(num5, text3)
			End If
			If Operators.CompareString(text2, ".", False) = 0 Or Operators.CompareString(text2, ",", False) = 0 Or Operators.CompareString(text2, "", False) = 0 Then
				text2 = "0"
			End If
			Return text2
		End Function

		Public Sub InitSummaryReportXML(ByRef iNumOfLines As Integer, Optional ByRef bMinFootnote As Boolean = False, Optional ByRef sMinFootnote As String = "", Optional ByRef bMaxFootnote As Boolean = False, Optional ByRef sMaxFootnote As String = "", Optional ByRef sGuideMsg As String = "")
			Dim text As String = ""
			Dim bGuidesEntered As Boolean = False
			Dim flag As Boolean = False
			sGuideMsg = ""
			Dim flag2 As Boolean = True
			RSWIN_DESC.bAllZeroNumGuides = RSWIN.AllZeroNumGuides()
			Dim text2 As String = "MaxSideLoadLimit"
			Dim num As Single = 30F
			RSWIN_DESC.SETUP_MaxSideLoadLimit = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text2, num))
			Try
				text2 = "MeasurementSystem"
				Dim num2 As Integer = 1
				RSWIN_DESC.SETUP_MeasurementSystem = Conversions.ToInteger(RSWIN.GetRegProfileStringByInt(RSWIN_DESC.SECT_GENERAL, text2, num2))
				If Not(RSWIN_DESC.SETUP_MeasurementSystem = 1 Or RSWIN_DESC.SETUP_MeasurementSystem = 2 Or RSWIN_DESC.SETUP_MeasurementSystem = 3) Then
					RSWIN_DESC.SETUP_MeasurementSystem = 1
					text2 = "MeasurementSystem"
					Dim obj As Object = RSWIN_DESC.SETUP_MeasurementSystem
					Dim text3 As String = Util.Format(obj)
					RSWIN_DESC.SETUP_MeasurementSystem = Conversions.ToInteger(obj)
					Dim text4 As String = text3
					Dim num3 As Integer = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_GENERAL, text2, text4, RSWIN_DESC.sINIFile)
				End If
			Catch ex As Exception
				RSWIN_DESC.SETUP_MeasurementSystem = 1
				Dim text4 As String = "MeasurementSystem"
				Dim obj As Object = RSWIN_DESC.SETUP_MeasurementSystem
				Dim text5 As String = Util.Format(obj)
				RSWIN_DESC.SETUP_MeasurementSystem = Conversions.ToInteger(obj)
				text2 = text5
				Dim num3 As Integer = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_GENERAL, text4, text2, RSWIN_DESC.sINIFile)
			End Try
			Try
				RSWIN_DESC.MaxRecNumGuides = New Integer(40) {}
				RSWIN_DESC.MaxRecNumGuides_2 = New Integer(80) {}
				Dim num4 As Short = 1S
				Do
					RSWIN_DESC.MaxRecNumGuides(CInt(num4)) = 0
					RSWIN_DESC.MaxRecNumGuides_2(CInt(num4)) = 0
					num4 += 1S
				Loop While num4 <= 40S
				num4 = 41S
				Do
					RSWIN_DESC.MaxRecNumGuides_2(CInt(num4)) = 0
					num4 += 1S
				Loop While num4 <= 80S
				Dim text4 As String = "BareRodLoad"
				num = 50F
				RSWIN_DESC.SETUP_BAREROD_LOAD = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text4, num))
				text4 = "MoldedLoad"
				num = 40F
				RSWIN_DESC.SETUP_MOLDEDGUIDE_LOAD = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text4, num))
				text4 = "WheelLoad"
				num = 25F
				RSWIN_DESC.SETUP_WHEELGUIDE_LOAD = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text4, num))
				text4 = "OtherLoad"
				num = 32.5F
				RSWIN_DESC.SETUP_OTHERGUIDE_LOAD = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text4, num))
				text4 = "MaxSideLoadLimit"
				num = 30F
				RSWIN_DESC.SETUP_MaxSideLoadLimit = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text4, num))
				Dim sDefaultName As String = "SteelSuckerRodLength"
				Dim value As Object = DBNull.Value
				Dim flag3 As Boolean = False
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(ini.GetDefault(sDefaultName, value, flag3))
				RSWIN_DESC.SETUP_SteelSuckerRodLength = Conversions.ToSingle(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)), 25, RuntimeHelpers.GetObjectValue(objectValue)))
				text4 = "MaxNumGuidesPerRod"
				Dim num2 As Integer = 12
				RSWIN_DESC.SETUP_MaxNumGuidesPerRod = Conversions.ToInteger(RSWIN.GetRegProfileStringByInt(RSWIN_DESC.SECT_RSWIN, text4, num2))
				MImpred.TEMP_SETUP_BAREROD_LOAD = RSWIN_DESC.SETUP_BAREROD_LOAD
				If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
					CtrlUI.ConvertValue(MImpred.TEMP_SETUP_BAREROD_LOAD, "l", False)
				End If
				MImpred.TEMP_SETUP_MOLDEDGUIDE_LOAD = RSWIN_DESC.SETUP_MOLDEDGUIDE_LOAD
				If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
					CtrlUI.ConvertValue(MImpred.TEMP_SETUP_MOLDEDGUIDE_LOAD, "l", False)
				End If
				MImpred.TEMP_SETUP_WHEELGUIDE_LOAD = RSWIN_DESC.SETUP_WHEELGUIDE_LOAD
				If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
					CtrlUI.ConvertValue(MImpred.TEMP_SETUP_WHEELGUIDE_LOAD, "l", False)
				End If
				MImpred.TEMP_SETUP_OTHERGUIDE_LOAD = RSWIN_DESC.SETUP_OTHERGUIDE_LOAD
				If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
					CtrlUI.ConvertValue(MImpred.TEMP_SETUP_OTHERGUIDE_LOAD, "l", False)
				End If
				MImpred.TEMP_SETUP_NorrisStandardGuide_Load = RSWIN_DESC.SETUP_NorrisStandardGuide_Load
				If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
					CtrlUI.ConvertValue(MImpred.TEMP_SETUP_NorrisStandardGuide_Load, "l", False)
				End If
				MImpred.TEMP_SETUP_NorrisSidewinderGuide_Load = RSWIN_DESC.SETUP_NorrisSidewinderGuide_Load
				If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
					CtrlUI.ConvertValue(MImpred.TEMP_SETUP_NorrisSidewinderGuide_Load, "l", False)
				End If
				MImpred.TEMP_SETUP_RGIJakeCouplingGuide_Load = RSWIN_DESC.SETUP_RGIJakeCouplingGuide_Load
				If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
					CtrlUI.ConvertValue(MImpred.TEMP_SETUP_RGIJakeCouplingGuide_Load, "l", False)
				End If
				MImpred.TEMP_SETUP_RGISVTGuide_LOAD = RSWIN_DESC.SETUP_RGISVTGuide_LOAD
				If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
					CtrlUI.ConvertValue(MImpred.TEMP_SETUP_RGISVTGuide_LOAD, "l", False)
				End If
				MImpred.TEMP_SETUP_RGITomahawkGuide_LOAD = RSWIN_DESC.SETUP_RGITomahawkGuide_LOAD
				If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
					CtrlUI.ConvertValue(MImpred.TEMP_SETUP_RGITomahawkGuide_LOAD, "l", False)
				End If
				MImpred.TEMP_SETUP_RGITornadoGuide_LOAD = RSWIN_DESC.SETUP_RGITornadoGuide_LOAD
				If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
					CtrlUI.ConvertValue(MImpred.TEMP_SETUP_RGITornadoGuide_LOAD, "l", False)
				End If
				MImpred.TEMP_SETUP_RGITwisterGuide_LOAD = RSWIN_DESC.SETUP_RGITwisterGuide_LOAD
				If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
					CtrlUI.ConvertValue(MImpred.TEMP_SETUP_RGITwisterGuide_LOAD, "l", False)
				End If
				MImpred.TEMP_SETUP_RGIWVTGuide_LOAD = RSWIN_DESC.SETUP_RGIWVTGuide_LOAD
				If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
					CtrlUI.ConvertValue(MImpred.TEMP_SETUP_RGIWVTGuide_LOAD, "l", False)
				End If
				RSWIN_DESC.sSummaryDataSetXML = ""
				Dim str As String = ""
				Dim num5 As Short = 0S
				RSWIN_DESC.sSummaryDataSetXML += "<Data><Entries>"
				Dim num8 As Integer
				Dim num9 As Single
				Dim num10 As Short
				Dim numRods As Short
				Dim num6 As Short = CShort(MImpred.m_Impred.num_rod_elements)
				Dim num7 As Integer = CInt(Math.Round(Conversion.Int(CDbl((RSWIN_DESC.rst.PumpDepth / RSWIN_DESC.SETUP_SteelSuckerRodLength)) + 0.5)))
				num8 = 0
				num9 = 0F
				MImpred.iMinGuide = 0
				num10 = 1S
				numRods = RSWIN_DESC.rst.NumRods
				num4 = num10
				While num4 <= numRods
					num9 += RSWIN_DESC.rst.Sections(CInt(num4)).length
					If RODUTIL.IsFG(RSWIN_DESC.rst.Sections(CInt(num4)).Grade) Or CUSTOMRG.IsOtherFG(CInt(RSWIN_DESC.rst.Sections(CInt(num4)).Grade)) Then
						' The following expression was wrapped in a unchecked-expression
						num8 = CInt(Math.Round(CDbl(num8) + Conversion.Int(CDbl(RSWIN_DESC.rst.Sections(CInt(num4)).length) / 37.5 + 0.5)))
					Else
						' The following expression was wrapped in a unchecked-expression
						num8 = CInt(Math.Round(CDbl(num8) + Conversion.Int(CDbl((RSWIN_DESC.rst.Sections(CInt(num4)).length / RSWIN_DESC.SETUP_SteelSuckerRodLength)) + 0.5)))
					End If
					If RSWIN_DESC.rst.Sections(CInt(num4)).Guide >= 6S Then
						MImpred.iMinGuide = 3
					ElseIf RSWIN_DESC.rst.Sections(CInt(num4)).Guide >= 4S Then
						MImpred.iMinGuide = 4
					End If
					num4 += 1S
				End While
				If MImpred.iMinGuide = 0 Then
					MImpred.iMinGuide = 3
				End If
				Dim num11 As Short
				Dim num12 As Short
				RSWIN_DESC.rod_sideloads = New Single(num8 + 1 - 1) {}
				RSWIN_DESC.rod_num_guides = New Integer(0) {}
				RSWIN_DESC.rod_num_guides = New Integer(num8 + 1 - 1) {}
				RSWIN_DESC.rod_num_depths = New Single(0) {}
				RSWIN_DESC.rod_num_depths = New Single(num8 + 1 - 1) {}
				RSWIN_DESC.rod_suckerrodlength = New Single(0) {}
				RSWIN_DESC.rod_suckerrodlength = New Single(num8 + 1 - 1) {}
				MImpred.GetRodSideLoads(RSWIN_DESC.rod_sideloads, RSWIN_DESC.rod_suckerrodlength, True)
				bMinFootnote = False
				sMinFootnote = ""
				bMaxFootnote = False
				sMaxFootnote = ""
				sGuideMsg = ""
				iNumOfLines = 0
				RSWIN_DESC.rod_num_guides(0) = 0
				RSWIN_DESC.rod_num_depths(0) = 0F
				RSWIN_DESC.iSumMOLDED = 0
				RSWIN_DESC.iSumWHEELED = 0
				RSWIN_DESC.iSumOther = 0
				RSWIN_DESC.iSumNorrisStandard = 0
				RSWIN_DESC.iSumNorrisSidewinder = 0
				RSWIN_DESC.iSumRGIJakeCoupling = 0
				RSWIN_DESC.iSumRGISVT = 0
				RSWIN_DESC.iSumRGITomahawk = 0
				RSWIN_DESC.iSumRGITornado = 0
				RSWIN_DESC.iSumRGITwister = 0
				RSWIN_DESC.iSumRGIWVT = 0
				num9 = 0F
				num11 = 1S
				num12 = CShort(num8)
				num4 = num11
				While num4 <= num12
					Try
						Dim num13 As Integer = 0
						If RSWIN_DESC.rod_suckerrodlength(CInt(num4)) <> 0F Then
							num9 += RSWIN_DESC.rod_suckerrodlength(CInt(num4))
						Else
							num9 += RSWIN_DESC.SETUP_SteelSuckerRodLength
						End If
						MImpred.GetSectionIndex(num9, num13)
						Dim num14 As Single = RSWIN_DESC.rod_sideloads(CInt(num4))
						Try
							MImpred.GetGuideAndNum(num13, CDbl(num9), CDbl(num14), str, num5, bMinFootnote, sMinFootnote, bMaxFootnote, sMaxFootnote, sGuideMsg, bGuidesEntered)
						Catch ex2 As Exception
						End Try
						RSWIN_DESC.rod_num_depths(CInt(num4)) = num9
						Dim num15 As Single = num9
						If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
							CtrlUI.ConvertValue(num15, "f", False)
						End If
						RSWIN_DESC.rod_num_guides(CInt(num4)) = CInt(num5)
						If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
							CtrlUI.ConvertValue(num14, "l", False)
						End If
						If CDbl(num14) < 0.0001 Then
							num14 = 0F
						End If
						If((RSWIN_DESC.SETUP_RECOMMEND_GUIDES Or (Not RSWIN_DESC.SETUP_RECOMMEND_GUIDES And RSWIN_DESC.bAllZeroNumGuides)) And num5 <> 0S And num14 <> 0F) Or (Not RSWIN_DESC.SETUP_RECOMMEND_GUIDES And Not RSWIN_DESC.bAllZeroNumGuides And (RSWIN_DESC.rst.Sections(num13).NumGuides <> 0S Or num5 <> 0S)) Then
							Dim text6 As String
							iNumOfLines += 1
							RSWIN_DESC.sSummaryDataSetXML += "<Row>"
							RSWIN_DESC.sSummaryDataSetXML = RSWIN_DESC.sSummaryDataSetXML + "<Taper>" + num13.ToString().Trim() + "</Taper>"
							RSWIN_DESC.sSummaryDataSetXML += "<Depth>"
							If num15 = 0F Then
								RSWIN_DESC.sSummaryDataSetXML += "0"
							Else
								Dim sSummaryDataSetXML As String = RSWIN_DESC.sSummaryDataSetXML
								text4 = "#####"
								RSWIN_DESC.sSummaryDataSetXML = sSummaryDataSetXML + Util.Format(num15, text4)
							End If
							RSWIN_DESC.sSummaryDataSetXML += "</Depth>"
							RSWIN_DESC.sSummaryDataSetXML += "<MaxSideLoad>"
							If num14 = 0F Then
								RSWIN_DESC.sSummaryDataSetXML += "0"
							Else
								Dim sSummaryDataSetXML2 As String = RSWIN_DESC.sSummaryDataSetXML
								text4 = "######.##"
								RSWIN_DESC.sSummaryDataSetXML = sSummaryDataSetXML2 + Util.Format(num14, text4)
							End If
							RSWIN_DESC.sSummaryDataSetXML += "</MaxSideLoad>"
							Dim teRodSizeList As teRodSizeList
							Try
								teRodSizeList = RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.RodGradeDB().Item(CType(RSWIN_DESC.rst.Sections(num13).Grade, StdInfoConstants.RodGradeConstants)).RodSizeList
							Catch ex3 As Exception
								teRodSizeList = Nothing
							End Try
							If teRodSizeList IsNot Nothing Then
								Try
									For Each obj2 As Object In teRodSizeList
										Dim dictionaryEntry As DictionaryEntry
										Dim teRodSize As teRodSize = CType(If((obj2 IsNot Nothing), CType(obj2, DictionaryEntry), dictionaryEntry).Value, teRodSize)
										Try
											If teRodSize.Diameter = RSWIN_DESC.rst.Sections(num13).Diameter Then
												If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
													text6 = teRodSize.MetricDisplayName
												Else
													text6 = teRodSize.DisplayName
												End If
												flag = True
											End If
										Catch ex4 As Exception
										End Try
									Next
								Finally
									Dim enumerator As IEnumerator
									If TypeOf enumerator Is IDisposable Then
										TryCast(enumerator, IDisposable).Dispose()
									End If
								End Try
							End If
							If Not flag Then
								If RODUTIL.IsCorodH(RSWIN_DESC.rst.Sections(num13).Grade) Then
									text6 = "N/A"
								ElseIf RODUTIL.IsCorod(RSWIN_DESC.rst.Sections(num13).Grade) Then
									If RSWIN_DESC.rst.Sections(num13).Diameter > 1F Then
										num = RSWIN_DESC.rst.Sections(num13).Diameter * 16F
										text4 = "0.0"
										text6 = Util.Format(num, text4) + "/16"
									Else
										num = RSWIN_DESC.rst.Sections(num13).Diameter * 16F
										text4 = "0"
										text6 = Util.Format(num, text4) + "/16"
									End If
								ElseIf RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
									num = RSWIN_DESC.rst.Sections(num13).Diameter * RSWIN_DESC.IN__MM
									text4 = "0.0"
									text6 = Util.Format(num, text4)
								Else
									Dim sections As RSWIN_DESC.RodSection() = RSWIN_DESC.rst.Sections
									Dim num16 As Integer = num13
									text4 = "0.0###"
									text6 = Util.Format(sections(num16).Diameter, text4)
								End If
							End If
							text6 = text6.Replace("  ", " ")
							RSWIN_DESC.sSummaryDataSetXML = RSWIN_DESC.sSummaryDataSetXML + "<RodDiam>" + text6
							RSWIN_DESC.sSummaryDataSetXML += "</RodDiam>"
							RSWIN_DESC.sSummaryDataSetXML = RSWIN_DESC.sSummaryDataSetXML + "<GuideType>" + str
							RSWIN_DESC.sSummaryDataSetXML += "</GuideType>"
							Dim text7 As String
							If bMaxFootnote And (num5 > 6S Or CInt(num5) > RSWIN_DESC.SETUP_MaxNumGuidesPerRod) Then
								text7 = " *"
							ElseIf bMinFootnote And num5 > 0S And CInt(num5) < RSWIN_DESC.SETUP_MinNumGuidesPerRod Then
								text7 = "**"
							Else
								text7 = "  "
							End If
							If Not RSWIN_DESC.SETUP_RECOMMEND_GUIDES And Not RSWIN_DESC.bAllZeroNumGuides Then
								If Not bMaxFootnote AndAlso ((CInt(RSWIN_DESC.rst.Sections(num13).NumGuides) > RSWIN_DESC.SETUP_MaxNumGuidesPerRod Or RSWIN_DESC.rst.Sections(num13).NumGuides > 6S) And RSWIN_DESC.SETUP_MaxNumGuidesPerRod <> 0) Then
									If RSWIN_DESC.rst.Sections(num13).Guide >= 4S Then
										If(RSWIN_DESC.rst.Sections(num13).NumGuides > 6S Or CInt(RSWIN_DESC.rst.Sections(num13).NumGuides) > RSWIN_DESC.SETUP_MaxNumGuidesPerRod) And RSWIN_DESC.SETUP_MaxNumGuidesPerRod <> 6 Then
											bMaxFootnote = True
											sMaxFootnote = "* - The manufacturer recommends a maximum of 6 rod guides per rod (maximum number in Setup is " + Conversions.ToString(RSWIN_DESC.SETUP_MaxNumGuidesPerRod) + ")."
											text = " *"
										Else
											bMaxFootnote = True
											sMaxFootnote = "* - The manufacturer recommends a maximum of 6 rod guides per rod."
											text = " *"
										End If
									Else
										bMaxFootnote = True
										sMaxFootnote = "* - The maximum number of rod guides per rod in Setup is ." + Conversions.ToString(RSWIN_DESC.SETUP_MaxNumGuidesPerRod) + "."
										text = " *"
									End If
								End If
								If Not bMinFootnote AndAlso ((CInt(RSWIN_DESC.rst.Sections(num13).NumGuides) < RSWIN_DESC.SETUP_MinNumGuidesPerRod Or CInt(RSWIN_DESC.rst.Sections(num13).NumGuides) < MImpred.iMinGuide) And RSWIN_DESC.SETUP_MinNumGuidesPerRod <> 0) Then
									If RSWIN_DESC.rst.Sections(num13).Guide >= 4S Then
										bMinFootnote = True
										sMinFootnote = Conversions.ToString(Operators.ConcatenateObject("** - The manufacturer recommends a minimum of " + Conversions.ToString(MImpred.iMinGuide) + " rod guides per rod.", Interaction.IIf(RSWIN_DESC.SETUP_MinNumGuidesPerRod <> 3, " The minimum number of rod guides in Setup is " + Conversions.ToString(RSWIN_DESC.SETUP_MinNumGuidesPerRod) + ".", "")))
										text = "**"
									ElseIf CInt(RSWIN_DESC.rst.Sections(num13).NumGuides) < RSWIN_DESC.SETUP_MinNumGuidesPerRod Then
										bMinFootnote = True
										sMinFootnote = "** - The minimum number of rod guides per rod in Setup is ." + Conversions.ToString(RSWIN_DESC.SETUP_MinNumGuidesPerRod) + "."
										text = "**"
									End If
								End If
							End If
							If Not RSWIN_DESC.SETUP_RECOMMEND_GUIDES And Not RSWIN_DESC.bAllZeroNumGuides Then
								RSWIN_DESC.sSummaryDataSetXML = RSWIN_DESC.sSummaryDataSetXML + "<NumOfGuidesUserEntered>" + Conversions.ToString(CInt(RSWIN_DESC.rst.Sections(num13).NumGuides))
								RSWIN_DESC.sSummaryDataSetXML += "</NumOfGuidesUserEntered>"
								If Operators.CompareString(text.Trim(), "", False) = 0 Then
									RSWIN_DESC.sSummaryDataSetXML += "<FootnoteMarkerUserEntered></FootnoteMarkerUserEntered>"
								Else
									RSWIN_DESC.sSummaryDataSetXML = RSWIN_DESC.sSummaryDataSetXML + "<FootnoteMarkerUserEntered>" + text
									RSWIN_DESC.sSummaryDataSetXML += "</FootnoteMarkerUserEntered>"
								End If
							End If
							RSWIN_DESC.sSummaryDataSetXML = RSWIN_DESC.sSummaryDataSetXML + "<NumOfGuides>" + num5.ToString()
							RSWIN_DESC.sSummaryDataSetXML += "</NumOfGuides>"
							If Operators.CompareString(text7.Trim(), "", False) = 0 Then
								RSWIN_DESC.sSummaryDataSetXML += "<FootnoteMarker></FootnoteMarker>"
							Else
								RSWIN_DESC.sSummaryDataSetXML = RSWIN_DESC.sSummaryDataSetXML + "<FootnoteMarker>" + text7
								RSWIN_DESC.sSummaryDataSetXML += "</FootnoteMarker>"
							End If
							RSWIN_DESC.sSummaryDataSetXML += "</Row>"
							If num13 = 0 Then
								MImpred.GetSectionIndex(num9, num13)
							End If
							If CInt(num5) > RSWIN_DESC.MaxRecNumGuides(num13) Then
								RSWIN_DESC.MaxRecNumGuides(num13) = CInt(num5)
							End If
							Try
								MImpred.GuideFrequencyArrayIndex(num13, num9, CInt(num5))
							Catch ex5 As Exception
							End Try
							Dim num17 As Integer
							MImpred.GetSectionIndex2(num9, num17)
							If CInt(num5) > RSWIN_DESC.MaxRecNumGuides_2(num17) Then
								RSWIN_DESC.MaxRecNumGuides_2(num17) = CInt(num5)
							End If
						Else
							If Not flag2 Then
								Dim text6 As String
								iNumOfLines += 1
								RSWIN_DESC.sSummaryDataSetXML += "<Row>"
								RSWIN_DESC.sSummaryDataSetXML = RSWIN_DESC.sSummaryDataSetXML + "<Taper>" + num13.ToString().Trim() + "</Taper>"
								RSWIN_DESC.sSummaryDataSetXML += "<Depth>"
								If num9 = 0F Then
									RSWIN_DESC.sSummaryDataSetXML += "0"
								Else
									Dim sSummaryDataSetXML3 As String = RSWIN_DESC.sSummaryDataSetXML
									text4 = "#####"
									RSWIN_DESC.sSummaryDataSetXML = sSummaryDataSetXML3 + Util.Format(num15, text4)
								End If
								RSWIN_DESC.sSummaryDataSetXML += "</Depth>"
								RSWIN_DESC.sSummaryDataSetXML += "<MaxSideLoad>"
								If num14 = 0F Then
									RSWIN_DESC.sSummaryDataSetXML += "0"
								Else
									Dim sSummaryDataSetXML4 As String = RSWIN_DESC.sSummaryDataSetXML
									text4 = "######.##"
									RSWIN_DESC.sSummaryDataSetXML = sSummaryDataSetXML4 + Util.Format(num14, text4)
								End If
								RSWIN_DESC.sSummaryDataSetXML += "</MaxSideLoad>"
								RSWIN_DESC.sSummaryDataSetXML = RSWIN_DESC.sSummaryDataSetXML + "<GuideType>" + str
								RSWIN_DESC.sSummaryDataSetXML += "</GuideType>"
								Dim teRodSizeList As teRodSizeList
								Try
									teRodSizeList = RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.RodGradeDB().Item(CType(RSWIN_DESC.rst.Sections(num13).Grade, StdInfoConstants.RodGradeConstants)).RodSizeList
								Catch ex6 As Exception
									teRodSizeList = Nothing
								End Try
								If teRodSizeList IsNot Nothing Then
									Try
										For Each obj3 As Object In teRodSizeList
											Dim dictionaryEntry As DictionaryEntry
											Dim teRodSize As teRodSize = CType(If((obj3 IsNot Nothing), CType(obj3, DictionaryEntry), dictionaryEntry).Value, teRodSize)
											Try
												If teRodSize.Diameter = RSWIN_DESC.rst.Sections(num13).Diameter Then
													If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
														text6 = teRodSize.MetricDisplayName
													Else
														text6 = teRodSize.DisplayName
													End If
													flag = True
												End If
											Catch ex7 As Exception
											End Try
										Next
									Finally
										Dim enumerator2 As IEnumerator
										If TypeOf enumerator2 Is IDisposable Then
											TryCast(enumerator2, IDisposable).Dispose()
										End If
									End Try
								End If
								If Not flag Then
									If RODUTIL.IsCorodH(RSWIN_DESC.rst.Sections(num13).Grade) Then
										text6 = "N/A"
									ElseIf RODUTIL.IsCorod(RSWIN_DESC.rst.Sections(num13).Grade) Then
										If RSWIN_DESC.rst.Sections(num13).Diameter > 1F Then
											num = RSWIN_DESC.rst.Sections(num13).Diameter * 16F
											text4 = "0.0"
											text6 = Util.Format(num, text4) + "/16"
										Else
											num = RSWIN_DESC.rst.Sections(num13).Diameter * 16F
											text4 = "0"
											text6 = Util.Format(num, text4) + "/16"
										End If
									ElseIf RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
										num = RSWIN_DESC.rst.Sections(num13).Diameter * RSWIN_DESC.IN__MM
										text4 = "0.0"
										text6 = Util.Format(num, text4)
									Else
										Dim sections2 As RSWIN_DESC.RodSection() = RSWIN_DESC.rst.Sections
										Dim num18 As Integer = num13
										text4 = "0.0###"
										text6 = Util.Format(sections2(num18).Diameter, text4)
									End If
								End If
								text6 = text6.Replace("  ", " ")
								RSWIN_DESC.sSummaryDataSetXML = RSWIN_DESC.sSummaryDataSetXML + "<RodDiam>" + text6
								RSWIN_DESC.sSummaryDataSetXML += "</RodDiam>"
								RSWIN_DESC.sSummaryDataSetXML = RSWIN_DESC.sSummaryDataSetXML + "<NumOfGuidesUserEntered>" + Conversions.ToString(CInt(RSWIN_DESC.rst.Sections(num13).NumGuides))
								RSWIN_DESC.sSummaryDataSetXML += "</NumOfGuidesUserEntered>"
								Dim text7 As String
								If bMaxFootnote And num5 > 6S Then
									text7 = " *"
								ElseIf bMinFootnote And num5 > 0S And CInt(num5) < RSWIN_DESC.SETUP_MinNumGuidesPerRod Then
									text7 = "**"
								Else
									text7 = "  "
								End If
								RSWIN_DESC.sSummaryDataSetXML = RSWIN_DESC.sSummaryDataSetXML + "<NumOfGuides>" + num5.ToString()
								RSWIN_DESC.sSummaryDataSetXML += "</NumOfGuides>"
								If Operators.CompareString(text7.Trim(), "", False) = 0 Then
									RSWIN_DESC.sSummaryDataSetXML += "<FootnoteMarker></FootnoteMarker>"
								Else
									RSWIN_DESC.sSummaryDataSetXML = RSWIN_DESC.sSummaryDataSetXML + "<FootnoteMarker>" + text7
									RSWIN_DESC.sSummaryDataSetXML += "</FootnoteMarker>"
								End If
								RSWIN_DESC.sSummaryDataSetXML += "</Row>"
								Try
									If num13 = 0 Then
										MImpred.GetSectionIndex(num9, num13)
									End If
									Try
										MImpred.GuideFrequencyArrayIndex(num13, num9, CInt(num5))
										GoTo IL_150E
									Catch ex8 As Exception
										GoTo IL_150E
									End Try
								Catch ex9 As Exception
									GoTo IL_150E
								End Try
							End If
							If(RSWIN_DESC.SETUP_RECOMMEND_GUIDES Or (Not RSWIN_DESC.SETUP_RECOMMEND_GUIDES And RSWIN_DESC.bAllZeroNumGuides)) And num5 = 0S Then
								Try
									If num13 = 0 Then
										MImpred.GetSectionIndex(num9, num13)
									End If
									Try
										MImpred.GuideFrequencyArrayIndex(num13, num9, CInt(num5))
									Catch ex10 As Exception
									End Try
								Catch ex11 As Exception
								End Try
							End If
						End If
						IL_150E:
					Catch ex12 As Exception
					End Try
					num4 += 1S
				End While
				RSWIN_DESC.sSummaryDataSetXML += "</Entries></Data>"
				If CDbl(iNumOfLines) / 35.0 > Conversion.Int(CDbl(iNumOfLines) / 35.0) Then
					' The following expression was wrapped in a unchecked-expression
					RSWIN_DESC.rst.Number_Of_Guide_report_Pages = CInt(Math.Round(Conversion.Int(CDbl(iNumOfLines) / 35.0) + 1.0))
				Else
					RSWIN_DESC.rst.Number_Of_Guide_report_Pages = CInt(Math.Round(Conversion.Int(CDbl(iNumOfLines) / 35.0)))
				End If
			Catch ex13 As Exception
			End Try
		End Sub

		Public Sub GetReportXMLnPages(ByRef iNumOfLines As Integer, Optional ByRef bMinFootnote As Boolean = False, Optional ByRef sMinFootnote As String = "", Optional ByRef bMaxFootnote As Boolean = False, Optional ByRef sMaxFootnote As String = "", Optional ByRef sGuideMsg As String = "", Optional ByRef sTapersOverMax As String = "")
			Dim bGuidesEntered As Boolean = False
			Dim array As Boolean() = New Boolean(40) {}
			sTapersOverMax = ""
			Try
				RSWIN_DESC.bAllZeroNumGuides = RSWIN.AllZeroNumGuides()
				sGuideMsg = ""
				Dim text As String = "BareRodLoad"
				Dim num As Single = 50F
				RSWIN_DESC.SETUP_BAREROD_LOAD = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text, num))
				text = "MoldedLoad"
				num = 40F
				RSWIN_DESC.SETUP_MOLDEDGUIDE_LOAD = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text, num))
				text = "WheelLoad"
				num = 25F
				RSWIN_DESC.SETUP_WHEELGUIDE_LOAD = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text, num))
				text = "OtherLoad"
				num = 32.5F
				RSWIN_DESC.SETUP_OTHERGUIDE_LOAD = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text, num))
				text = "MaxSideLoadLimit"
				num = 30F
				RSWIN_DESC.SETUP_MaxSideLoadLimit = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text, num))
				Dim sDefaultName As String = "SteelSuckerRodLength"
				Dim value As Object = DBNull.Value
				Dim flag As Boolean = False
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(ini.GetDefault(sDefaultName, value, flag))
				RSWIN_DESC.SETUP_SteelSuckerRodLength = Conversions.ToSingle(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)), 25, RuntimeHelpers.GetObjectValue(objectValue)))
				text = "MaxNumGuidesPerRod"
				Dim num2 As Integer = 12
				RSWIN_DESC.SETUP_MaxNumGuidesPerRod = Conversions.ToInteger(RSWIN.GetRegProfileStringByInt(RSWIN_DESC.SECT_RSWIN, text, num2))
				MImpred.TEMP_SETUP_BAREROD_LOAD = RSWIN_DESC.SETUP_BAREROD_LOAD
				If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
					CtrlUI.ConvertValue(MImpred.TEMP_SETUP_BAREROD_LOAD, "l", False)
				End If
				MImpred.TEMP_SETUP_MOLDEDGUIDE_LOAD = RSWIN_DESC.SETUP_MOLDEDGUIDE_LOAD
				If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
					CtrlUI.ConvertValue(MImpred.TEMP_SETUP_MOLDEDGUIDE_LOAD, "l", False)
				End If
				MImpred.TEMP_SETUP_WHEELGUIDE_LOAD = RSWIN_DESC.SETUP_WHEELGUIDE_LOAD
				If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
					CtrlUI.ConvertValue(MImpred.TEMP_SETUP_WHEELGUIDE_LOAD, "l", False)
				End If
				MImpred.TEMP_SETUP_OTHERGUIDE_LOAD = RSWIN_DESC.SETUP_OTHERGUIDE_LOAD
				If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
					CtrlUI.ConvertValue(MImpred.TEMP_SETUP_OTHERGUIDE_LOAD, "l", False)
				End If
				MImpred.TEMP_SETUP_NorrisStandardGuide_Load = RSWIN_DESC.SETUP_NorrisStandardGuide_Load
				If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
					CtrlUI.ConvertValue(MImpred.TEMP_SETUP_NorrisStandardGuide_Load, "l", False)
				End If
				MImpred.TEMP_SETUP_NorrisSidewinderGuide_Load = RSWIN_DESC.SETUP_NorrisSidewinderGuide_Load
				If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
					CtrlUI.ConvertValue(MImpred.TEMP_SETUP_NorrisSidewinderGuide_Load, "l", False)
				End If
				MImpred.TEMP_SETUP_RGIJakeCouplingGuide_Load = RSWIN_DESC.SETUP_RGIJakeCouplingGuide_Load
				If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
					CtrlUI.ConvertValue(MImpred.TEMP_SETUP_RGIJakeCouplingGuide_Load, "l", False)
				End If
				MImpred.TEMP_SETUP_RGISVTGuide_LOAD = RSWIN_DESC.SETUP_RGISVTGuide_LOAD
				If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
					CtrlUI.ConvertValue(MImpred.TEMP_SETUP_RGISVTGuide_LOAD, "l", False)
				End If
				MImpred.TEMP_SETUP_RGITomahawkGuide_LOAD = RSWIN_DESC.SETUP_RGITomahawkGuide_LOAD
				If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
					CtrlUI.ConvertValue(MImpred.TEMP_SETUP_RGITomahawkGuide_LOAD, "l", False)
				End If
				MImpred.TEMP_SETUP_RGITornadoGuide_LOAD = RSWIN_DESC.SETUP_RGITornadoGuide_LOAD
				If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
					CtrlUI.ConvertValue(MImpred.TEMP_SETUP_RGITornadoGuide_LOAD, "l", False)
				End If
				MImpred.TEMP_SETUP_RGITwisterGuide_LOAD = RSWIN_DESC.SETUP_RGITwisterGuide_LOAD
				If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
					CtrlUI.ConvertValue(MImpred.TEMP_SETUP_RGITwisterGuide_LOAD, "l", False)
				End If
				MImpred.TEMP_SETUP_RGIWVTGuide_LOAD = RSWIN_DESC.SETUP_RGIWVTGuide_LOAD
				If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
					CtrlUI.ConvertValue(MImpred.TEMP_SETUP_RGIWVTGuide_LOAD, "l", False)
				End If
				Dim text2 As String = ""
				Dim num3 As Short = 0S
				Dim num6 As Single
				Dim num7 As Short
				Dim numRods As Short
				Dim num4 As Short = CShort(MImpred.m_Impred.num_rod_elements)
				Dim num5 As Integer = CInt(Math.Round(Conversion.Int(CDbl((RSWIN_DESC.rst.PumpDepth / RSWIN_DESC.SETUP_SteelSuckerRodLength)) + 0.5)))
				RSWIN_DESC.rod_numrods = 0
				num6 = 0F
				num7 = 1S
				numRods = RSWIN_DESC.rst.NumRods
				For num8 As Short = num7 To numRods
					num6 += RSWIN_DESC.rst.Sections(CInt(num8)).length
					If RODUTIL.IsFG(RSWIN_DESC.rst.Sections(CInt(num8)).Grade) Or CUSTOMRG.IsOtherFG(CInt(RSWIN_DESC.rst.Sections(CInt(num8)).Grade)) Then
						' The following expression was wrapped in a unchecked-expression
						RSWIN_DESC.rod_numrods = CInt(Math.Round(CDbl(RSWIN_DESC.rod_numrods) + Conversion.Int(CDbl(RSWIN_DESC.rst.Sections(CInt(num8)).length) / 37.5 + 0.5)))
					Else
						' The following expression was wrapped in a unchecked-expression
						RSWIN_DESC.rod_numrods = CInt(Math.Round(CDbl(RSWIN_DESC.rod_numrods) + Conversion.Int(CDbl((RSWIN_DESC.rst.Sections(CInt(num8)).length / RSWIN_DESC.SETUP_SteelSuckerRodLength)) + 0.5)))
					End If
				Next
				Dim num9 As Short
				Dim num10 As Short
				RSWIN_DESC.rod_sideloads = New Single(RSWIN_DESC.rod_numrods + 1 - 1) {}
				RSWIN_DESC.rod_suckerrodlength = New Single(RSWIN_DESC.rod_numrods + 1 - 1) {}
				MImpred.GetRodSideLoads(RSWIN_DESC.rod_sideloads, RSWIN_DESC.rod_suckerrodlength, False)
				bMinFootnote = False
				sMinFootnote = ""
				bMaxFootnote = False
				sMaxFootnote = ""
				sGuideMsg = ""
				iNumOfLines = 0
				RSWIN_DESC.iSumMOLDED = 0
				RSWIN_DESC.iSumWHEELED = 0
				RSWIN_DESC.iSumOther = 0
				RSWIN_DESC.iSumNorrisStandard = 0
				RSWIN_DESC.iSumNorrisSidewinder = 0
				RSWIN_DESC.iSumRGIJakeCoupling = 0
				RSWIN_DESC.iSumRGISVT = 0
				RSWIN_DESC.iSumRGITomahawk = 0
				RSWIN_DESC.iSumRGITornado = 0
				RSWIN_DESC.iSumRGITwister = 0
				RSWIN_DESC.iSumRGIWVT = 0
				num6 = 0F
				num9 = 0S
				num10 = CShort((RSWIN_DESC.rod_numrods - 2))
				For num8 As Short = num9 To num10
					If RSWIN_DESC.rod_suckerrodlength(CInt(num8)) <> 0F Then
						num6 += RSWIN_DESC.rod_suckerrodlength(CInt(num8))
					Else
						num6 += RSWIN_DESC.SETUP_SteelSuckerRodLength
					End If
					Dim num11 As Integer
					MImpred.GetSectionIndex(num6, num11)
					Dim num12 As Single = RSWIN_DESC.rod_sideloads(CInt(num8))
					num3 = 0S
					MImpred.GetGuideAndNum(num11, CDbl(num6), CDbl(num12), text2, num3, bMinFootnote, sMinFootnote, bMaxFootnote, sMaxFootnote, sGuideMsg, bGuidesEntered)
					If CInt(num3) > RSWIN_DESC.SETUP_MaxNumGuidesPerRod Then
						array(num11) = True
					End If
					If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
						CtrlUI.ConvertValue(num12, "l", False)
					End If
					If((RSWIN_DESC.SETUP_RECOMMEND_GUIDES Or (Not RSWIN_DESC.SETUP_RECOMMEND_GUIDES And RSWIN_DESC.bAllZeroNumGuides)) And num3 > 0S And num12 > 0F) Or (Not RSWIN_DESC.SETUP_RECOMMEND_GUIDES And Not RSWIN_DESC.bAllZeroNumGuides And (RSWIN_DESC.rst.Sections(num11).NumGuides > 0S Or num3 > 0S)) Then
						iNumOfLines += 1
					End If
				Next
				Dim num13 As Integer
				Dim num14 As Short
				Dim numRods2 As Short
				If CDbl(iNumOfLines) / 35.0 > Conversion.Int(CDbl(iNumOfLines) / 35.0) Then
					' The following expression was wrapped in a unchecked-expression
					RSWIN_DESC.rst.Number_Of_Guide_report_Pages = CInt(Math.Round(Conversion.Int(CDbl(iNumOfLines) / 35.0) + 1.0))
				Else
					RSWIN_DESC.rst.Number_Of_Guide_report_Pages = CInt(Math.Round(Conversion.Int(CDbl(iNumOfLines) / 35.0)))
				End If
				If RSWIN_DESC.rst.Number_Of_Guide_report_Pages = 0 Then
					RSWIN_DESC.rst.Number_Of_Guide_report_Pages = 1
				End If
				num13 = 0
				num14 = 1S
				numRods2 = RSWIN_DESC.rst.NumRods
				For num8 As Short = num14 To numRods2
					' The following expression was wrapped in a checked-statement
					If array(CInt(num8)) Then
						num13 += 1
					End If
				Next
				Dim num15 As Integer = 0
				sTapersOverMax = ""
				Dim num16 As Short = 1S
				Dim numRods3 As Short = RSWIN_DESC.rst.NumRods
				For num8 As Short = num16 To numRods3
					' The following expression was wrapped in a checked-statement
					If array(CInt(num8)) Then
						num15 += 1
						If Operators.CompareString(sTapersOverMax, "", False) = 0 Then
							sTapersOverMax = num8.ToString()
						ElseIf num15 = num13 Then
							If num13 = 2 Then
								sTapersOverMax = sTapersOverMax + " and " + num8.ToString()
							Else
								sTapersOverMax = sTapersOverMax + ", and " + num8.ToString()
							End If
						Else
							sTapersOverMax = sTapersOverMax + ", " + num8.ToString()
						End If
					End If
				Next
			Catch ex As Exception
			End Try
		End Sub

		Private Sub GetGuideAndNum(Indx As Integer, fDepth As Double, fMaxSideLoad As Double, ByRef sGuide As String, ByRef iNumOfGuides As Short, ByRef bMinFootnote As Boolean, ByRef sMinFootnote As String, ByRef bMaxFootnote As Boolean, ByRef sMaxFootnote As String, ByRef sGuideMsg As String, bGuidesEntered As Boolean)
			Dim num As Double = 0.0
			iNumOfGuides = 0S
			Try
				If Indx <> 0 Then
					If RODUTIL.IsFG(RSWIN_DESC.rst.Sections(Indx).Grade) Or CUSTOMRG.IsOtherFG(CInt(RSWIN_DESC.rst.Sections(Indx).Grade)) Then
					End If
				End If
			Catch ex As Exception
			End Try
			Dim num2 As Short = 1S
			Dim numRods As Short = RSWIN_DESC.rst.NumRods
			Dim num4 As Short
			For num3 As Short = num2 To numRods
				num += CDbl(RSWIN_DESC.rst.Sections(CInt(num3)).length)
				If fDepth < num Then
					num4 = num3
					Exit For
				End If
				If fDepth = num Then
					num4 = num3
					Exit For
				End If
				If fDepth > CDbl(RSWIN_DESC.rst.PumpDepth) Then
					num4 = RSWIN_DESC.rst.NumRods
					Exit For
				End If
			Next
			Dim guideType As Short = MImpred.GetGuideType(RSWIN_DESC.rst.Sections(CInt(num4)).Guide, CInt(num4))
			Dim num5 As Short = guideType
			If num5 = RSWIN_DESC.MOLDED Then
				sGuide = "Molded"
				If fMaxSideLoad >= CDbl(RSWIN_DESC.SETUP_MaxSideLoadLimit) Then
					Dim num6 As Single = CSng((fMaxSideLoad / CDbl(RSWIN_DESC.SETUP_MOLDEDGUIDE_LOAD)))
					iNumOfGuides = CShort(Math.Round(Conversion.Int(fMaxSideLoad / CDbl(RSWIN_DESC.SETUP_MOLDEDGUIDE_LOAD) + 0.5)))
					If num6 > CSng(iNumOfGuides) Then
						iNumOfGuides += 1S
					End If
					If CInt(iNumOfGuides) > RSWIN_DESC.SETUP_MaxNumGuidesPerRod And RSWIN_DESC.SETUP_MaxNumGuidesPerRod <> 0 Then
						bMaxFootnote = True
						sMaxFootnote = "* - The maximum number of rod guides per rod in Setup is ." + Conversions.ToString(RSWIN_DESC.SETUP_MaxNumGuidesPerRod) + "."
					End If
					If CInt(iNumOfGuides) < RSWIN_DESC.SETUP_MinNumGuidesPerRod And RSWIN_DESC.SETUP_MinNumGuidesPerRod <> 0 Then
						bMinFootnote = True
						sMinFootnote = "** - The minimum number of rod guides per rod in Setup is ." + Conversions.ToString(RSWIN_DESC.SETUP_MinNumGuidesPerRod) + "."
					End If
				Else
					iNumOfGuides = 0S
				End If
			ElseIf num5 = 2S Then
				sGuide = "Wheeled"
				If fMaxSideLoad >= CDbl(RSWIN_DESC.SETUP_MaxSideLoadLimit) Then
					Dim num6 As Single = CSng((fMaxSideLoad / CDbl(RSWIN_DESC.SETUP_WHEELGUIDE_LOAD)))
					iNumOfGuides = CShort(Math.Round(Conversion.Int(fMaxSideLoad / CDbl(RSWIN_DESC.SETUP_WHEELGUIDE_LOAD) + 0.5)))
					If num6 > CSng(iNumOfGuides) Then
						iNumOfGuides += 1S
					End If
					If CInt(iNumOfGuides) > RSWIN_DESC.SETUP_MaxNumGuidesPerRod And RSWIN_DESC.SETUP_MaxNumGuidesPerRod <> 0 Then
						bMaxFootnote = True
						sMaxFootnote = "* - The maximum number of rod guides per rod in Setup is ." + Conversions.ToString(RSWIN_DESC.SETUP_MaxNumGuidesPerRod) + "."
					End If
					If CInt(iNumOfGuides) < RSWIN_DESC.SETUP_MinNumGuidesPerRod And RSWIN_DESC.SETUP_MinNumGuidesPerRod <> 0 Then
						bMinFootnote = True
						sMinFootnote = "** - The minimum number of rod guides per rod in Setup is ." + Conversions.ToString(RSWIN_DESC.SETUP_MinNumGuidesPerRod) + "."
					End If
				Else
					iNumOfGuides = 0S
				End If
			ElseIf num5 = 3S Then
				Dim text As String = New String(" "c, 8192)
				Dim text2 As String = "OtherGuide"
				Dim text3 As String = "Other"
				Dim length As Short = CShort(RSWIN.GetRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text3, text, True))
				sGuide = text.Substring(0, CInt(length))
				If fMaxSideLoad >= CDbl(RSWIN_DESC.SETUP_MaxSideLoadLimit) Then
					Dim num6 As Single = CSng((fMaxSideLoad / CDbl(RSWIN_DESC.SETUP_OTHERGUIDE_LOAD)))
					iNumOfGuides = CShort(Math.Round(Conversion.Int(fMaxSideLoad / CDbl(RSWIN_DESC.SETUP_OTHERGUIDE_LOAD) + 0.5)))
					If num6 > CSng(iNumOfGuides) Then
						iNumOfGuides += 1S
					End If
					If CInt(iNumOfGuides) > RSWIN_DESC.SETUP_MaxNumGuidesPerRod And RSWIN_DESC.SETUP_MaxNumGuidesPerRod <> 0 Then
						bMaxFootnote = True
						sMaxFootnote = "* - The maximum number of rod guides per rod in Setup is ." + Conversions.ToString(RSWIN_DESC.SETUP_MaxNumGuidesPerRod) + "."
					End If
					If CInt(iNumOfGuides) < RSWIN_DESC.SETUP_MinNumGuidesPerRod And RSWIN_DESC.SETUP_MinNumGuidesPerRod <> 0 Then
						bMinFootnote = True
						sMinFootnote = "** - The minimum number of rod guides per rod in Setup is ." + Conversions.ToString(RSWIN_DESC.SETUP_MinNumGuidesPerRod) + "."
					End If
				Else
					iNumOfGuides = 0S
				End If
			ElseIf num5 = 4S OrElse num5 = RSWIN_DESC.NorrisSidewinderGuide OrElse num5 = 6S OrElse num5 = 7S OrElse num5 = 8S OrElse num5 = 9S OrElse num5 = 10S OrElse num5 = 11S Then
				Dim num7 As Single
				If num7 = 0F Then
					Try
						MImpred.GetSidewinderNameAndLoad(guideType, num7)
					Catch ex2 As Exception
					End Try
				End If
				sGuide = MImpred.GetSidewinderNameAndLoad(guideType, num7)
				If fMaxSideLoad >= CDbl(RSWIN_DESC.SETUP_MaxSideLoadLimit) Then
					Dim num6 As Single = CSng((fMaxSideLoad / CDbl(num7)))
					iNumOfGuides = CShort(Math.Round(Conversion.Int(fMaxSideLoad / CDbl(num7) + 0.5)))
					If num6 > CSng(iNumOfGuides) Then
						iNumOfGuides += 1S
					End If
					If guideType >= 4S And (CInt(iNumOfGuides) > RSWIN_DESC.SETUP_MaxNumGuidesPerRod Or iNumOfGuides > 6S) Then
						bMaxFootnote = True
						sMaxFootnote = Conversions.ToString(Operators.ConcatenateObject("* - The manufacturer recommends a maximum of 6 rod guides per rod.", Interaction.IIf(Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(RSWIN_DESC.SETUP_MaxNumGuidesPerRod, Interaction.IIf(RSWIN_DESC.SETUP_SteelSuckerRodLength > 25F, 12, 10), False))), " The maximum number of rod guides in Setup is " + Conversions.ToString(RSWIN_DESC.SETUP_MaxNumGuidesPerRod) + ".", "")))
					ElseIf CInt(iNumOfGuides) > RSWIN_DESC.SETUP_MaxNumGuidesPerRod Then
						bMaxFootnote = True
						sMaxFootnote = "* - The maximum number of rod guides per rod in Setup is ." + Conversions.ToString(RSWIN_DESC.SETUP_MaxNumGuidesPerRod) + "."
					End If
					If(CInt(iNumOfGuides) < RSWIN_DESC.SETUP_MinNumGuidesPerRod Or CInt(iNumOfGuides) < MImpred.iMinGuide) And RSWIN_DESC.SETUP_MinNumGuidesPerRod <> 0 Then
						bMinFootnote = True
						sMinFootnote = Conversions.ToString(Operators.ConcatenateObject("** - The manufacturer recommends a minimum of " + Conversions.ToString(MImpred.iMinGuide) + " rod guides per rod.", Interaction.IIf(RSWIN_DESC.SETUP_MinNumGuidesPerRod <> 3, " The minimum number of rod guides in Setup is " + Conversions.ToString(RSWIN_DESC.SETUP_MinNumGuidesPerRod) + ".", "")))
					End If
				End If
			End If
			sGuideMsg = " "
			If iNumOfGuides > 0S And Not RSWIN_DESC.bHasGuides Then
				RSWIN_DESC.bHasGuides = True
			End If
			If RSWIN_DESC.bHasGuides Then
				Dim num8 As Short = guideType
				If num8 = RSWIN_DESC.MOLDED Then
					RSWIN_DESC.iSumMOLDED += 1
				ElseIf num8 = 2S Then
					RSWIN_DESC.iSumWHEELED += 1
				ElseIf num8 = 3S Then
					RSWIN_DESC.iSumOther += 1
				ElseIf num8 = 4S Then
					RSWIN_DESC.iSumNorrisStandard += 1
				ElseIf num8 = RSWIN_DESC.NorrisSidewinderGuide Then
					RSWIN_DESC.iSumNorrisSidewinder += 1
				ElseIf num8 = 6S Then
					RSWIN_DESC.iSumRGIJakeCoupling += 1
				ElseIf num8 = 7S Then
					RSWIN_DESC.iSumRGISVT += 1
				ElseIf num8 = 8S Then
					RSWIN_DESC.iSumRGITomahawk += 1
				ElseIf num8 = 9S Then
					RSWIN_DESC.iSumRGITornado += 1
				ElseIf num8 = 10S Then
					RSWIN_DESC.iSumRGITwister += 1
				ElseIf num8 = 11S Then
					RSWIN_DESC.iSumRGIWVT += 1
				End If
				Return
			End If
		End Sub

		Public Sub DebugDataset(ByRef myDataset As DataSet)
		End Sub

		Private Sub OutputImpredInput()
			Dim text As String = "c:\Theta\RSWIN-Impred-Input.txt"
			If FILEUTIL.FileExists(text) Then
				FileSystem.Kill("c:\Theta\RSWIN-Impred-Input.txt")
			End If
			Dim num As Integer = FileSystem.FreeFile()
			FileSystem.FileOpen(num, "c:\Theta\RSWIN-Impred-Input.txt", OpenMode.Output, OpenAccess.[Default], OpenShare.[Default], -1)
			Dim impred As TEImpred = MImpred.m_Impred
			FileSystem.PrintLine(num, New Object() { " .anch_depth = " + Conversions.ToString(impred.anch_depth) })
			FileSystem.PrintLine(num, New Object() { " .angl_cwt_phase = " + Conversions.ToString(impred.angl_cwt_phase) })
			FileSystem.PrintLine(num, New Object() { " .API_len_A = " + Conversions.ToString(impred.API_len_A) })
			FileSystem.PrintLine(num, New Object() { " .casing_pressure = " + Conversions.ToString(impred.casing_pressure) })
			FileSystem.PrintLine(num, New Object() { " .comp_tot = " + Conversions.ToString(impred.comp_tot) })
			FileSystem.PrintLine(num, New Object() { " .cw_or_ccw = " + Conversions.ToString(impred.cw_or_ccw) })
			FileSystem.PrintLine(num, New Object() { " .eff_gb = " + Conversions.ToString(impred.eff_gb) })
			FileSystem.PrintLine(num, New Object() { " .eff_pu = " + Conversions.ToString(impred.eff_pu) })
			FileSystem.PrintLine(num, New Object() { " .fluid_solution = " + Conversions.ToString(impred.fluid_solution) })
			FileSystem.PrintLine(num, New Object() { " .force_su = " + Conversions.ToString(impred.force_su) })
			FileSystem.PrintLine(num, New Object() { " .four_bar_class = " + Conversions.ToString(impred.four_bar_class) })
			FileSystem.PrintLine(num, New Object() { " .hp_mot = " + Conversions.ToString(impred.hp_mot) })
			FileSystem.PrintLine(num, New Object() { " .liquid_level = " + Conversions.ToString(impred.liquid_level) })
			FileSystem.PrintLine(num, New Object() { " .num_tbg_tapers = " + Conversions.ToString(impred.num_tbg_tapers) })
			FileSystem.PrintLine(num, New Object() { " .pump_diam = " + Conversions.ToString(impred.pump_diam) })
			FileSystem.PrintLine(num, New Object() { " .pump_effic = " + Conversions.ToString(impred.pump_effic) })
			FileSystem.PrintLine(num, New Object() { " .pump_fillup = " + Conversions.ToString(impred.pump_fillup) })
			FileSystem.PrintLine(num, New Object() { " .pump_load_adj = " + Conversions.ToString(impred.pump_load_adj) })
			FileSystem.PrintLine(num, New Object() { " .ratio_gb = " + Conversions.ToString(impred.ratio_gb) })
			FileSystem.PrintLine(num, New Object() { " .ratio_vb = " + Conversions.ToString(impred.ratio_vb) })
			FileSystem.PrintLine(num, New Object() { " .sp_grav_oil = " + Conversions.ToString(impred.sp_grav_oil) })
			FileSystem.PrintLine(num, New Object() { " .sp_grav_water = " + Conversions.ToString(impred.sp_grav_water) })
			FileSystem.PrintLine(num, New Object() { " .strokes_per_min = " + Conversions.ToString(impred.strokes_per_min) })
			FileSystem.PrintLine(num, New Object() { " .torq_cr = " + Conversions.ToString(impred.torq_cr) })
			FileSystem.PrintLine(num, New Object() { " .torq_cw = " + Conversions.ToString(impred.torq_cw) })
			FileSystem.PrintLine(num, New Object() { " .tubing_pressure = " + Conversions.ToString(impred.tubing_pressure) })
			FileSystem.PrintLine(num, New Object() { " .WaterCut = " + Conversions.ToString(impred.watercut) })
			FileSystem.PrintLine(num, New Object() { " .gas_exponent = " + Conversions.ToString(impred.gas_exponent) })
			FileSystem.PrintLine(num, New Object() { " .i_downhole_dyno = " + Conversions.ToString(impred.i_downhole_dyno) })
			FileSystem.PrintLine(num, New Object() { " .max_iterations = " + Conversions.ToString(impred.max_iterations) })
			FileSystem.PrintLine(num, New Object() { " .num_cycles = " + Conversions.ToString(impred.num_cycles) })
			FileSystem.PrintLine(num, New Object() { " .num_rod_elements = " + Conversions.ToString(impred.num_rod_elements) })
			FileSystem.PrintLine(num, New Object() { " .omega_fill = " + Conversions.ToString(impred.omega_fill) })
			FileSystem.PrintLine(num, New Object() { " .SV_clear_vol = " + Conversions.ToString(impred.SV_clear_vol) })
			FileSystem.PrintLine(num, New Object() { " .TV_clear_vol = " + Conversions.ToString(impred.TV_clear_vol) })
			FileSystem.PrintLine(num, New Object() { " .TV_pos_init = " + Conversions.ToString(impred.TV_pos_init) })
			FileSystem.PrintLine(num, New Object() { " .p_drag_up_0 = " + Conversions.ToString(impred.p_drag_up_0) })
			FileSystem.PrintLine(num, New Object() { " .p_drag_up_1 = " + Conversions.ToString(impred.p_drag_up_1) })
			FileSystem.PrintLine(num, New Object() { " .p_drag_up_2 = " + Conversions.ToString(impred.p_drag_up_2) })
			FileSystem.PrintLine(num, New Object() { " .p_drag_f_max_up = " + Conversions.ToString(impred.p_drag_f_max_up) })
			FileSystem.PrintLine(num, New Object() { " .p_drag_dn_0 = " + Conversions.ToString(impred.p_drag_dn_0) })
			FileSystem.PrintLine(num, New Object() { " .p_drag_dn_1 = " + Conversions.ToString(impred.p_drag_dn_1) })
			FileSystem.PrintLine(num, New Object() { " .p_drag_dn_2 = " + Conversions.ToString(impred.p_drag_dn_2) })
			FileSystem.PrintLine(num, New Object() { " .p_drag_f_max_dn = " + Conversions.ToString(impred.p_drag_f_max_dn) })
			FileSystem.PrintLine(num, New Object() { " .pr_drag_0 = " + Conversions.ToString(impred.pr_drag_0) })
			FileSystem.PrintLine(num, New Object() { " .pr_drag_1 = " + Conversions.ToString(impred.pr_drag_1) })
			FileSystem.PrintLine(num, New Object() { " .pr_drag_2 = " + Conversions.ToString(impred.pr_drag_2) })
			FileSystem.PrintLine(num, New Object() { " .pr_drag_f_max = " + Conversions.ToString(impred.pr_drag_f_max) })
			FileSystem.PrintLine(num, New Object() { " .poisson = " + Conversions.ToString(impred.poisson) })
			FileSystem.PrintLine(num, New Object() { " .ref_psia = " + Conversions.ToString(impred.ref_psia) })
			FileSystem.PrintLine(num, New Object() { " .rpm_full_load = " + Conversions.ToString(impred.rpm_full_load) })
			FileSystem.PrintLine(num, New Object() { " .timestep_multiplier = " + Conversions.ToString(impred.timestep_multiplier) })
			FileSystem.PrintLine(num, New Object() { " .wk_sq_beam = " + Conversions.ToString(impred.wk_sq_beam) })
			FileSystem.PrintLine(num, New Object() { " .wk_sq_cr = " + Conversions.ToString(impred.wk_sq_cr) })
			FileSystem.PrintLine(num, New Object() { " .wk_sq_cw = " + Conversions.ToString(impred.wk_sq_cw) })
			FileSystem.PrintLine(num, New Object() { " .wk_sq_gb = " + Conversions.ToString(impred.wk_sq_gb) })
			FileSystem.PrintLine(num, New Object() { " .wk_sq_hss = " + Conversions.ToString(impred.wk_sq_hss) })
			FileSystem.PrintLine(num, New Object() { " .wk_sq_lss = " + Conversions.ToString(impred.wk_sq_lss) })
			FileSystem.PrintLine(num, New Object() { " .wk_sq_mot = " + Conversions.ToString(impred.wk_sq_mot) })
			FileSystem.PrintLine(num, New Object() { " .wk_sq_vb = " + Conversions.ToString(impred.wk_sq_vb) })
			FileSystem.PrintLine(num, New Object() { " .mot_pts_flag = " + Conversions.ToString(impred.mot_pts_flag) })
			FileSystem.PrintLine(num, New Object() { " .mot_pts = " + Conversions.ToString(impred.mot_pts) })
			Select Case impred.mot_pts_flag
				Case 2
					FileSystem.PrintLine(num, New Object() { " .rpm_no_load = " + Conversions.ToString(impred.rpm_no_load) })
					FileSystem.PrintLine(num, New Object() { " .rpm_full_load = " + Conversions.ToString(impred.rpm_full_load) })
					FileSystem.PrintLine(num, New Object() { " .torq_no_load = " + Conversions.ToString(impred.torq_no_load) })
					FileSystem.PrintLine(num, New Object() { " .torq_full_load = " + Conversions.ToString(impred.torq_full_load) })
				Case 3
					FileSystem.PrintLine(num, New Object() { " .rpm_no_load = " + Conversions.ToString(impred.rpm_no_load) })
					FileSystem.PrintLine(num, New Object() { " .rpm_full_load = " + Conversions.ToString(impred.rpm_full_load) })
					FileSystem.PrintLine(num, New Object() { " .rpm_breakdown = " + Conversions.ToString(impred.rpm_breakdown) })
					FileSystem.PrintLine(num, New Object() { " .torq_no_load = " + Conversions.ToString(impred.torq_no_load) })
					FileSystem.PrintLine(num, New Object() { " .torq_full_load = " + Conversions.ToString(impred.torq_full_load) })
					FileSystem.PrintLine(num, New Object() { " .torq_breakdown = " + Conversions.ToString(impred.torq_breakdown) })
				Case 20
					Dim num2 As Integer = 0
					Dim num3 As Integer = impred.mot_pts - 1
					For i As Integer = num2 To num3
						FileSystem.PrintLine(num, New Object() { " .m_c_rpm_mot (" + Conversions.ToString(i) + ") = " + Conversions.ToString(impred.get_m_c_rpm_mot(i)) })
						FileSystem.PrintLine(num, New Object() { " .m_c_torq_mot (" + Conversions.ToString(i) + ") = " + Conversions.ToString(impred.get_m_c_torq_mot(i)) })
					Next
			End Select
			FileSystem.PrintLine(num, New Object() { " .num_pump_unit_data_points = " + Conversions.ToString(impred.num_pump_unit_data_points) })
			Dim num4 As Integer = 1
			Dim num_pump_unit_data_points As Integer = impred.num_pump_unit_data_points
			For i As Integer = num4 To num_pump_unit_data_points
				FileSystem.PrintLine(num, New Object() { " .p_u_crank_angle (" + Conversions.ToString(i) + ") = " + Conversions.ToString(impred.get_p_u_crank_angle(i)) })
				FileSystem.PrintLine(num, New Object() { " .p_u_p_r_position (" + Conversions.ToString(i) + ") = " + Conversions.ToString(impred.get_p_u_p_r_position(i)) })
				FileSystem.PrintLine(num, New Object() { " .p_u_torque_factor (" + Conversions.ToString(i) + ") = " + Conversions.ToString(impred.get_p_u_torque_factor(i)) })
			Next
			FileSystem.PrintLine(num, New Object() { " .num_rod_tapers = " + Conversions.ToString(impred.num_rod_tapers) })
			Dim num5 As Integer = 1
			Dim num_rod_tapers As Integer = impred.num_rod_tapers
			For i As Integer = num5 To num_rod_tapers
				FileSystem.PrintLine(num, New Object() { " .r_t_taper_depth (" + Conversions.ToString(i) + ") = " + Conversions.ToString(impred.get_r_t_taper_depth(i)) })
				FileSystem.PrintLine(num, New Object() { " .r_t_rod_od (" + Conversions.ToString(i) + ") = " + Conversions.ToString(impred.get_r_t_rod_od(i)) })
				FileSystem.PrintLine(num, New Object() { " .r_t_rod_id (" + Conversions.ToString(i) + ") = " + Conversions.ToString(impred.get_r_t_rod_id(i)) })
				FileSystem.PrintLine(num, New Object() { " .r_t_rod_density (" + Conversions.ToString(i) + ") = " + Conversions.ToString(impred.get_r_t_rod_density(i)) })
				FileSystem.PrintLine(num, New Object() { " .r_t_rod_modulus (" + Conversions.ToString(i) + ") = " + Conversions.ToString(impred.get_r_t_rod_modulus(i)) })
				FileSystem.PrintLine(num, New Object() { " .r_t_dimless_damp_dn (" + Conversions.ToString(i) + ") = " + Conversions.ToString(impred.get_r_t_dimless_damp_dn(i)) })
				FileSystem.PrintLine(num, New Object() { " .r_t_dimless_damp_up (" + Conversions.ToString(i) + ") = " + Conversions.ToString(impred.get_r_t_dimless_damp_up(i)) })
				FileSystem.PrintLine(num, New Object() { " .r_t_friction_coef (" + Conversions.ToString(i) + ") = " + Conversions.ToString(impred.get_r_t_friction_coef(i)) })
			Next
			FileSystem.PrintLine(num, New Object() { " .t_t_taper_depth(1) = " + Conversions.ToString(impred.get_t_t_taper_depth(1)) })
			FileSystem.PrintLine(num, New Object() { " .t_t_tbg_id(1) = " + Conversions.ToString(impred.get_t_t_tbg_id(1)) })
			FileSystem.PrintLine(num, New Object() { " .t_t_tbg_od(1) = " + Conversions.ToString(impred.get_t_t_tbg_od(1)) })
			FileSystem.PrintLine(num, New Object() { " .t_t_tbg_modulus(1) = " + Conversions.ToString(impred.get_t_t_tbg_modulus(1)) })
			FileSystem.PrintLine(num, New Object() { " .dimless_damp_flu = " + Conversions.ToString(impred.dimless_damp_flu) })
			FileSystem.PrintLine(num, New Object() { " .tbg_flu_dens = " + Conversions.ToString(impred.tbg_flu_dens) })
			FileSystem.PrintLine(num, New Object() { " .char_vel_fluid = " + Conversions.ToString(impred.char_vel_fluid) })
			FileSystem.PrintLine(num, New Object() { " .damp_fluid = " + Conversions.ToString(impred.damp_fluid) })
			FileSystem.PrintLine(num, New Object() { " " })
			FileSystem.PrintLine(num, New Object() { " " })
			FileSystem.PrintLine(num, New Object() { " " })
			FileSystem.PrintLine(num, New Object() { " Pump Depth = " + Conversions.ToString(RSWIN_DESC.rst.PumpDepth) })
			Try
				FileSystem.PrintLine(num, New Object() { " - " })
				FileSystem.PrintLine(num, New Object() { "Taper , Grade, Length, Diameter " })
				Dim num6 As Integer = 1
				Dim numRods As Integer = CInt(RSWIN_DESC.rst.NumRods)
				For i As Integer = num6 To numRods
					Dim sections As RSWIN_DESC.RodSection() = RSWIN_DESC.rst.Sections
					Dim num7 As Integer = i
					FileSystem.PrintLine(num, New Object() { String.Concat(New String() { Conversions.ToString(i), " , ", RODUTIL.RodGrade(sections(num7).Grade), " , ", Conversions.ToString(sections(num7).length), " , ", Conversions.ToString(sections(num7).Diameter), " , " }) })
				Next
				FileSystem.PrintLine(num, New Object() { " - " })
			Catch ex As Exception
			End Try
			FileSystem.FileClose(New Integer() { num })
			Application.DoEvents()
		End Sub

		Public Sub GetRodSideLoads(ByRef rod_sideloads As Single(), ByRef rod_suckerrodlength As Single(), bInitializing As Boolean)
			' The following expression was wrapped in a checked-statement
			If RSWIN_DESC.rod_numrods = 0 Then
				' The following expression was wrapped in a unchecked-expression
				Dim num As Integer = CInt(Math.Round(Conversion.Int(CDbl((RSWIN_DESC.rst.PumpDepth / RSWIN_DESC.SETUP_SteelSuckerRodLength)) + 0.5)))
				RSWIN_DESC.rod_numrods = 0
				Dim num2 As Integer = 1
				Dim numRods As Integer = CInt(RSWIN_DESC.rst.NumRods)
				For i As Integer = num2 To numRods
					If RODUTIL.IsFG(RSWIN_DESC.rst.Sections(i).Grade) Or CUSTOMRG.IsOtherFG(CInt(RSWIN_DESC.rst.Sections(i).Grade)) Then
						' The following expression was wrapped in a unchecked-expression
						RSWIN_DESC.rod_numrods = CInt(Math.Round(CDbl(RSWIN_DESC.rod_numrods) + Conversion.Int(CDbl(RSWIN_DESC.rst.Sections(i).length) / 37.5 + 0.5)))
					Else
						' The following expression was wrapped in a unchecked-expression
						RSWIN_DESC.rod_numrods = CInt(Math.Round(CDbl(RSWIN_DESC.rod_numrods) + Conversion.Int(CDbl((RSWIN_DESC.rst.Sections(i).length / RSWIN_DESC.SETUP_SteelSuckerRodLength)) + 0.5)))
					End If
				Next
			End If
			If Not bInitializing And (RSWIN_DESC.SETUP_RECOMMEND_GUIDES Or (Not RSWIN_DESC.SETUP_RECOMMEND_GUIDES And RSWIN_DESC.bAllZeroNumGuides)) Then
				RSWIN_DESC.Guide_XYZ_indexes = New Integer(RSWIN_DESC.rod_numrods + 1 - 1) {}
			End If
			Try
				RSWIN_DESC.taper_lens = New Single(CInt((RSWIN_DESC.rst.NumRods + 1S)) - 1) {}
				RSWIN_DESC.taper_lens(0) = 0F
				Dim num3 As Integer = 1
				Dim numRods2 As Integer = CInt(RSWIN_DESC.rst.NumRods)
				For i As Integer = num3 To numRods2
					' The following expression was wrapped in a unchecked-expression
					' The following expression was wrapped in a checked-expression
					RSWIN_DESC.taper_lens(i) = RSWIN_DESC.taper_lens(i - 1) + RSWIN_DESC.rst.Sections(i).length
				Next
				Try
					If RSWIN_DESC.rod_numrods > Information.UBound(rod_sideloads, 1) Then
						rod_sideloads = New Single(RSWIN_DESC.rod_numrods + 1 - 1) {}
						rod_suckerrodlength = New Single(RSWIN_DESC.rod_numrods + 1 - 1) {}
					End If
				Catch ex As Exception
				End Try
				Dim num4 As Integer = Information.LBound(rod_sideloads, 1)
				Dim num5 As Integer = Information.UBound(rod_sideloads, 1)
				Try
					Dim num6 As Integer = num4
					Dim num7 As Integer = num5
					For i As Integer = num6 To num7
						rod_sideloads(i) = 0F
						rod_suckerrodlength(i) = RSWIN_DESC.SETUP_SteelSuckerRodLength
					Next
				Catch ex2 As Exception
				End Try
				Dim impredObj As TEImpred
				Try
					impredObj = MImpred.ImpredObj
				Catch ex3 As Exception
				End Try
				Dim num8 As Single
				If impredObj.p_s.rod_element_length <> 0.0 Then
					num8 = CSng(impredObj.p_s.rod_element_length)
					RSWIN_DESC.num_rod_elements = impredObj.num_rod_elements
				End If
				If num8 = 0F Then
					' The following expression was wrapped in a unchecked-expression
					num8 = CSng(Conversion.Int(impredObj.get_r_e(2).m_d - impredObj.get_r_e(1).m_d + 0.5))
					If num8 = 0F And impredObj.p_s.rod_element_length = 0.0 Then
						num8 = CSng((CDbl(RSWIN_DESC.taper_lens(CInt(RSWIN_DESC.rst.NumRods))) / Convert.ToDouble(impredObj.p_s.num_rod_elements)))
					End If
				End If
				Dim lastDepth As Single = Util.GetLastDepth(RSWIN_DESC.mdsDeviationProfile, False, 1)
				Dim num9 As Single
				If RODUTIL.IsFG(CShort(impredObj.get_r_e(1).Grade)) Or CUSTOMRG.IsOtherFG(impredObj.get_r_e(1).Grade) Then
					num9 = 37.5F
				Else
					num9 = RSWIN_DESC.SETUP_SteelSuckerRodLength
				End If
				rod_suckerrodlength(0) = num9
				rod_suckerrodlength(1) = num9
				Dim num10 As Single = 0F
				Dim num_rod_elements As Integer = impredObj.num_rod_elements
				Dim num11 As Integer = 0
				Dim num12 As Integer = -1
				Dim num13 As Integer = 0
				Dim num14 As Integer = 1
				Dim num15 As Single = 0F
				If Not bInitializing And (RSWIN_DESC.SETUP_RECOMMEND_GUIDES Or (Not RSWIN_DESC.SETUP_RECOMMEND_GUIDES And RSWIN_DESC.bAllZeroNumGuides)) Then
					Try
						Dim num16 As Integer = 0
						Dim rod_numrods As Integer = RSWIN_DESC.rod_numrods
						For i As Integer = num16 To rod_numrods
							RSWIN_DESC.Guide_XYZ_indexes(i) = -1
						Next
					Catch ex4 As Exception
					End Try
				End If

					While num10 <= lastDepth
						Try
							num10 += 1F
							If num10 <= lastDepth Then
								' The following expression was wrapped in a checked-statement
								num11 += 1
								If CSng(num11) > num8 Then
									Try
										num11 = 1
										num13 += 1
										num15 = CSng(impredObj.get_r_e(num13).max_sf_total)
										If RODUTIL.IsFG(CShort(impredObj.get_r_e(num13).Grade)) Or CUSTOMRG.IsOtherFG(impredObj.get_r_e(num13).Grade) Then
											num9 = 37.5F
										Else
											num9 = RSWIN_DESC.SETUP_SteelSuckerRodLength
										End If
									Catch ex5 As Exception
									End Try
								End If
								num12 += 1
								If CSng(num12) > num9 Then
									num12 = 1
									num14 += 1
								End If
								If num15 > 0F AndAlso num14 <= num5 Then
									Try
										rod_sideloads(num14) += num15 * (1F / num8)
									Catch ex6 As Exception
									End Try
									If num9 <> 0F Then
										rod_suckerrodlength(num14) = num9
									Else
										rod_suckerrodlength(num14) = RSWIN_DESC.SETUP_SteelSuckerRodLength
									End If
									If Not bInitializing And (RSWIN_DESC.SETUP_RECOMMEND_GUIDES Or (Not RSWIN_DESC.SETUP_RECOMMEND_GUIDES And RSWIN_DESC.bAllZeroNumGuides)) Then
										Try
											RSWIN_DESC.Guide_XYZ_indexes(num14) = num13
										Catch ex7 As Exception
										End Try
									End If
								End If
							End If
						Catch ex8 As Exception
						End Try
					End While

				Try
					Dim num17 As Integer = num4
					Dim num18 As Integer = num5
					For i As Integer = num17 To num18
						Debug.WriteLine(rod_sideloads(i))
					Next
				Catch ex9 As Exception
				End Try
			Catch ex10 As Exception
				MessageBox.Show("Error in GetRodSideLoads: " + ex10.Message)
			End Try
		End Sub

		Public Sub PumpBoundCond()
			Dim num As Integer
			Dim num3 As Integer
			Dim obj As Object
			Try
				ProjectData.ClearProjectError()
				num = 2
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				If rst.FluidLevelEntered Then
					rst.PumpIntakePressure = CSng((CDbl(((rst.PumpDepth - rst.FluidLevel) * rst.OilSPGR)) * 0.433 + CDbl(rst.CasingPressure) + 14.7))
				Else
					rst.FluidLevel = CSng((CDbl(rst.PumpDepth) - (CDbl((rst.PumpIntakePressure - rst.CasingPressure)) - 14.7) / (CDbl(rst.OilSPGR) * 0.433)))
				End If
				MImpred.Peff = rst.PumpEfficiency / 100F
				MImpred.Pumpfill = rst.PumpFillage / 100F
				rst.FluidDens = CSng((CDbl(rst.FluidSPGR) * 62.4))
				rst.FeetOverPump = rst.PumpDepth - rst.FluidLevel
				rst.Apump = CSng((3.141592653589793 * CDbl(rst.PlungerSize) * CDbl(rst.PlungerSize) / 4.0))
				If(If((-If(((RSWIN_DESC.bRodStarD And RSWIN_DESC.bUseFluidInertiaPumpLoadAdj) > False), 1S, 0S)), 1S, 0S) And RSWIN_DESC.rst.IncludeFluidInertia And RSWIN_DESC.SETUP_UseImpred) <> 0S Then
					rst.FluidLoad = CSng(((0.433 * CDbl((rst.FluidSPGR * rst.PumpDepth - rst.OilSPGR * rst.FeetOverPump)) + CDbl(rst.TubingPressure) - CDbl(rst.CasingPressure)) * CDbl(rst.Apump) * CDbl(MImpred.Peff)))
				Else
					rst.FluidLoad = CSng(((0.433 * CDbl((rst.FluidSPGR * rst.PumpDepth - rst.OilSPGR * rst.FeetOverPump)) + CDbl(rst.TubingPressure) - CDbl(rst.CasingPressure)) * CDbl(rst.Apump)))
				End If
				RSWIN_DESC.rst.TubingAnchored = RSWIN_DESC.rst.TubingAnchored
				RSWIN_DESC.rst.FluidLevel = RSWIN_DESC.rst.FluidLevel
				RSWIN_DESC.rst.FeetOverPump = RSWIN_DESC.rst.FeetOverPump
				Dim num2 As Single
				If Not rst.TubingAnchored <> 0S Then
					num2 = rst.PumpDepth
					rst.TubStretch = RUNCALC.TubingStretch(num2)
				Else
					num2 = rst.PumpDepth - rst.TubingAnchorDepth
					If num2 > 50F Then
						rst.TubStretch = RUNCALC.TubingStretch(num2)
					Else
						rst.TubStretch = 0F
					End If
				End If
				MImpred.IndPumpOp = 0S
				If rst.PumpCondition = 1S Then
					rst.Pfill = MImpred.Peff
					If num2 > 100F And CDbl(rst.TubStretch) > 0.25 Then
						MImpred.dflnu = rst.TubStretch
						MImpred.IndPumpOp = 2S
					Else
						MImpred.dflnu = 0F
						MImpred.IndPumpOp = 0S
					End If
				Else
					rst.Pfill = MImpred.Pumpfill
					If num2 > 100F And rst.TubStretch >= 1F Then
						MImpred.dflnu = rst.TubStretch
						MImpred.IndPumpOp = 3S
					Else
						MImpred.dflnu = 0F
						MImpred.IndPumpOp = 1S
					End If
				End If
				IL_2ED:
				GoTo IL_330
				IL_2EF:
				num3 = -1
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_303:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num3 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_2EF
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_330:
			If num3 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		Private Sub CalcNtsteps(ByRef Nelem As Short, ByRef Dt As Double, ByRef dx As Double, ByRef Speemax As Double)
			Dim num As Integer
			Dim num9 As Integer
			Dim obj As Object
			Try
				ProjectData.ClearProjectError()
				num = 2
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				RSWIN_DESC.rst.RodstringL = 0F
				Dim num2 As Short = 1S
				Dim numRods As Short = RSWIN_DESC.rst.NumRods
				For num3 As Short = num2 To numRods
					RSWIN_DESC.rst.RodstringL = RSWIN_DESC.rst.RodstringL + RSWIN_DESC.rst.Sections(CInt(num3)).length
				Next
				Dim num4 As Single = 0F
				Dim num5 As Short = 1S
				Dim numRods2 As Short = rst.NumRods
				For num3 As Short = num5 To numRods2
					If rst.Sections(CInt(num3)).Elasticity = 0F Then
						RODUTIL.LookupElasticity(rst.Sections(CInt(num3)))
					End If
					If rst.Sections(CInt(num3)).RodDensity = 0F Then
						If rst.Sections(CInt(num3)).Grade = 20481S Then
							rst.Sections(CInt(num3)).RodDensity = 100F
						ElseIf rst.Sections(CInt(num3)).Grade = 16393S Then
							rst.Sections(CInt(num3)).RodDensity = 125F
						ElseIf RODUTIL.IsFG(rst.Sections(CInt(num3)).Grade) Then
							rst.Sections(CInt(num3)).RodDensity = 130F
						Else
							rst.Sections(CInt(num3)).RodDensity = 491F
						End If
					End If
					Dim num6 As Single = rst.Sections(CInt(num3)).Elasticity / rst.Sections(CInt(num3)).RodDensity
					If num6 > num4 Then
						num4 = num6
					End If
				Next
				Speemax = Math.Sqrt(CDbl((4633.056F * num4)))
				Dim num7 As Double = CDbl((60F / rst.SPM))
				Dim num8 As Short
				If rst.PumpCondition <> 1S And rst.PumpIntakePressure < 600F Then
					num8 = 300S
				ElseIf rst.PU.UnitType = 7S Or rst.PU.UnitType = 10S Then
					num8 = 250S
				ElseIf rst.IncludeFluidInertia <> 0S Then
					If rst.PumpDepth < 1500F Then
						num8 = 250S
					Else
						num8 = 200S
					End If
				ElseIf Not rst.gbSteelRodString Then
					num8 = 200S
				Else
					num8 = 160S
				End If
				Do
					Nelem = 0S
					Do
						Nelem += 1S
						dx = CDbl((rst.RodstringL / CSng(Nelem)))
						Dt = dx / Speemax
						rst.Ntsteps = CShort(Math.Round(num7 / Dt)) + 1S
						Dt = num7 / CDbl(rst.Ntsteps)
					Loop While rst.Ntsteps < num8
					If Nelem >= 2S And rst.Ntsteps > 325S Then
						num8 -= 15S
					End If
				Loop While Not(Nelem = 1S Or rst.Ntsteps <= 325S)
				Speemax = dx / Dt
				IL_2F0:
				GoTo IL_337
				IL_2F2:
				num9 = -1
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_308:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num9 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_2F2
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_337:
			If num9 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		Public Function FluidInertiaPossible() As Boolean
			Dim result As Boolean = True
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			If rst.PumpCondition = 3S Then
				result = False
			ElseIf rst.CalcPlungerSize <> 0S Then
				If rst.PumpDepth >= 4250F Then
					result = False
				ElseIf(Not rst.SPMEntered And If((-If((rst.TargetBFPD < 500F > False), 1S, 0S)), 1S, 0S)) <> 0S Then
					result = False
				End If
			Else
				Dim pumpDepth As Single = rst.PumpDepth
				If pumpDepth > 5000F Then
					result = False
				ElseIf pumpDepth >= 4250F Then
					If CDbl(rst.PlungerSize) < 2.75 Then
						result = False
					End If
				ElseIf rst.PlungerSize < 2F Then
					result = False
				End If
			End If
			Return result
		End Function

		Public Property IndPumpOp As Short
			Get
				Return MImpred.m_IndPumpOp
			End Get
			Set(value As Short)
				MImpred.m_IndPumpOp = value
			End Set
		End Property

		Public Property Pumpfill As Single
			Get
				Return MImpred.m_Pumpfill
			End Get
			Set(value As Single)
				MImpred.m_Pumpfill = value
			End Set
		End Property

		Public Property dflnu As Single
			Get
				Return MImpred.m_dflnu
			End Get
			Set(value As Single)
				MImpred.m_dflnu = value
			End Set
		End Property

		Public Property Peff As Single
			Get
				Return MImpred.m_Peff
			End Get
			Set(value As Single)
				MImpred.m_Peff = value
			End Set
		End Property

		Private Sub calc_tan(ByRef tan As MImpred.cart_coord_type, ByRef inc As Double, ByRef azi As Double)
			tan.X = Math.Sin(inc) * Math.Sin(azi)
			tan.Y = Math.Sin(inc) * Math.Cos(azi)
			tan.z = Math.Cos(inc)
		End Sub

		Private Sub calc_dog(ByRef dog As Double, ByRef tan1 As MImpred.cart_coord_type, ByRef tan2 As MImpred.cart_coord_type, tolerance As Double)
			Dim num As Double = MImpred.dot_prod(tan1, tan2)
			If num > 1.0 + tolerance Or num < -tolerance Then
				num += 0.0
			ElseIf num > 1.0 And num <= 1.0 + tolerance Then
				num = 1.0
			ElseIf num < 0.0 And num >= -tolerance Then
				num = 0.0
			End If
			dog = kinemat.ArcCosine(CSng(num))
		End Sub

		Private Sub CalcDogleg(fMDArray As Single(), fInclinationArray As Single(), fAZIMUTHArray As Single(), ByRef fDoglegs As Single(), ByRef fRads As Single(), iCount As Integer)
			Try
				Dim num As Double = 2.0 * Math.Atan(1.0)
				Dim num2 As Integer = iCount
				Dim num3 As Short = CShort(iCount)
				Dim array As Double() = New Double(num2 + 1 - 1) {}
				Dim array2 As Double() = New Double(num2 + 1 - 1) {}
				Dim array3 As Double() = New Double(num2 + 1 - 1) {}
				Dim array4 As Double() = New Double(num2 + 1 - 1) {}
				Dim array5 As Double() = New Double(num2 + 1 - 1) {}
				Dim array6 As Double() = New Double(num2 + 1 - 1) {}
				Dim array7 As Double() = New Double(num2 + 1 - 1) {}
				Dim array8 As Double() = New Double(num2 + 1 - 1) {}
				Dim array9 As Double() = New Double(num2 + 1 - 1) {}
				Dim array10 As Double() = New Double(num2 + 1 - 1) {}
				Dim array11 As Single() = New Single(num2 + 1 - 1) {}
				Dim array12 As MImpred.survey_point_type() = New MImpred.survey_point_type(num2 + 1 - 1) {}
				Dim num4 As Single = 1E-06F
				Dim num5 As Double = 0.0
				num2 = 0
				For i As Integer = 1 To iCount
					Dim num6 As Double = CDbl(fMDArray(i))
					If RSWIN_DESC.SETUP_MeasurementSystem <> 1 Then
						Dim num7 As Single = CSng(num6)
						CtrlUI.ConvertValue(num7, "f", True)
						num6 = CDbl(num7)
					End If

						Dim num8 As Double = CDbl((fInclinationArray(i) / 180F)) * 3.141592653589793
						Dim num9 As Double = CDbl(fAZIMUTHArray(i))
						If num9 < 0.0 Then
							num9 = 360.0 + num9
						End If
						Dim num10 As Double = num9 / 180.0 * 3.141592653589793
						Dim num11 As Double = num6 - num5
						array11(num2) = CSng(num11)
						num5 = num6
						array12(num2).m_d = num6
						array12(num2).inc = num8
						array12(num2).azi = num10
						array7(num2) = num6
						array8(num2) = num11 * Math.Sin(num8) * Math.Sin(num10)
						array9(num2) = num11 * Math.Sin(num8) * Math.Cos(num10)
						array10(num2) = num11 * Math.Cos(num8)
						array(num2) = Math.Sin(num8) * Math.Sin(num10)
						array2(num2) = Math.Sin(num8) * Math.Cos(num10)
						array3(num2) = Math.Cos(num8)
						array12(num2).tan.X = array(num2)
						array12(num2).tan.Y = array2(num2)
						array12(num2).tan.z = array3(num2)

					num2 += 1
				Next
				If num2 > 1 Then
					array = CType(Utils.CopyArray(CType(array, Array), New Double(num2 - 1 + 1 - 1) {}), Double())
					array2 = CType(Utils.CopyArray(CType(array2, Array), New Double(num2 - 1 + 1 - 1) {}), Double())
					array3 = CType(Utils.CopyArray(CType(array3, Array), New Double(num2 - 1 + 1 - 1) {}), Double())
					array12 = CType(Utils.CopyArray(CType(array12, Array), New MImpred.survey_point_type(num2 - 1 + 1 - 1) {}), MImpred.survey_point_type())
					array4 = CType(Utils.CopyArray(CType(array4, Array), New Double(num2 - 1 + 1 - 1) {}), Double())
					array5 = CType(Utils.CopyArray(CType(array5, Array), New Double(num2 - 1 + 1 - 1) {}), Double())
					array6 = CType(Utils.CopyArray(CType(array6, Array), New Double(num2 - 1 + 1 - 1) {}), Double())
					Dim i As Integer = 1
					array5(0) = 0.0
					Dim flag As Boolean = True
					While flag

							' The following expression was wrapped in a checked-expression
							array(i) += array(i - 1)
							array2(i) += array2(i - 1)
							array3(i) += array3(i - 1)
							array8(i) += array8(i - 1)
							array9(i) += array9(i - 1)
							array10(i) += array10(i - 1)
							Try
								array5(i) = Math.Round(array10(i), 2)
							Catch ex As Exception
							End Try

						i += 1
						If i >= num2 Then
							flag = False
						End If
					End While
				End If
				If num2 > 2 Then
					Dim num12 As Double = 0.0
					Dim num13 As Double = 0.0
					Dim num14 As Double = 1.0
					Dim i As Integer = 1
					Dim flag As Boolean = True
					While flag
						Dim num15 As Double
						Dim num16 As Double
						Dim num17 As Double

							' The following expression was wrapped in a checked-expression
							num15 = array(i) - array(i - 1)
							num16 = array2(i) - array2(i - 1)
							num17 = array3(i) - array3(i - 1)
							Dim num18 As Double = num12 * num15 + num13 * num16 + num14 * num17
							Dim num19 As Double
							If num18 <> 0.0 Then
								num19 = kinemat.ArcCosine(CSng(num18))
							Else
								num19 = 0.0
							End If
							If num19 < 0.0 Then
								num19 += 2.0 * num
							End If
							If array11(i) <> 0F Then
								fDoglegs(i) = CSng(Math.Round(num19 / num * 90.0 / CDbl(array11(i)) * 100.0, 2))
							Else
								fDoglegs(i) = 0F
							End If

						i += 1
						If i >= num2 Then
							flag = False
						End If
						num12 = num15
						num13 = num16
						num14 = num17
					End While
					num3 = CShort(Information.UBound(array12, 1))
					Dim num20 As Short = 0S
					Dim num21 As Short = CShort((Information.UBound(array12, 1) - 1))

						For num22 As Short = num20 To num21
							' The following expression was wrapped in a checked-expression
							Dim num23 As Double = MImpred.dot_prod(array12(CInt(num22)).tan, array12(CInt((num22 + 1S))).tan)
							If num23 > 1.0 AndAlso num23 <= CDbl((1F + num4)) Then
								num23 = 1.0
							End If
							If num23 < 0.0 AndAlso num23 >= CDbl((-CDbl(num4))) Then
								num23 = 0.0
							End If
							array12(CInt(num22)).dog = kinemat.ArcCosine(CSng(num23))
							If array12(CInt(num22)).dog > CDbl(num4) Then
								' The following expression was wrapped in a checked-expression
								array12(CInt(num22)).rad = (array12(CInt((num22 + 1S))).m_d - array12(CInt(num22)).m_d) / array12(CInt(num22)).dog
								fRads(CInt((num22 + 1S))) = CSng(array12(CInt(num22)).rad)
							Else
								array12(CInt(num22)).rad = -9999.0
							End If
						Next

					num3 = CShort(Information.UBound(array12, 1))
				End If
			Catch ex2 As Exception
			End Try
		End Sub

		Private Sub calc_nor(ByRef n As MImpred.cart_coord_type, ByRef t1 As MImpred.cart_coord_type, ByRef t2 As MImpred.cart_coord_type)
			Dim cart_coord_type As MImpred.cart_coord_type
			MImpred.cross_prod(cart_coord_type, t2, t1)
			Dim cart_coord_type2 As MImpred.cart_coord_type
			MImpred.cross_prod(cart_coord_type2, cart_coord_type, t1)
			Dim num As Double = Math.Sqrt(cart_coord_type2.X * cart_coord_type2.X + cart_coord_type2.Y * cart_coord_type2.Y + cart_coord_type2.z * cart_coord_type2.z)
			If num > 0.0 Then
				n.X = cart_coord_type2.X / num
				n.Y = cart_coord_type2.Y / num
				n.z = cart_coord_type2.z / num
				Return
			End If
			n.X = 0.0
			n.Y = 0.0
			n.z = 0.0
		End Sub

		Private Sub cross_prod(ByRef result As MImpred.cart_coord_type, ByRef V1 As MImpred.cart_coord_type, ByRef v2 As MImpred.cart_coord_type)
			Try
				result.X = V1.Y * v2.z - V1.z * v2.Y
				result.Y = V1.z * v2.X - V1.X * v2.z
				result.z = V1.X * v2.Y - V1.Y * v2.X
			Catch ex As Exception
			End Try
		End Sub

		Private Function dot_prod(ByRef V1 As MImpred.cart_coord_type, ByRef v2 As MImpred.cart_coord_type) As Double
			Return V1.X * v2.X + V1.Y * v2.Y + V1.z * v2.z
		End Function

		Private Sub calc_pos(ByRef pos2 As MImpred.cart_coord_type, ByRef pos1 As MImpred.cart_coord_type, ByRef tan1 As MImpred.cart_coord_type, ByRef nor1 As MImpred.cart_coord_type, dog1 As Double, rad1 As Double)
			Dim num As Double = rad1 * Math.Sin(dog1)
			Dim num2 As Double = rad1 * (1.0 - Math.Cos(dog1))
			pos2.X = pos1.X + num * tan1.X + num2 * nor1.X
			pos2.Y = pos1.Y + num * tan1.Y + num2 * nor1.Y
			pos2.z = pos1.z + num * tan1.z + num2 * nor1.z
		End Sub

		Private Sub calc_str(ByRef pos2 As MImpred.cart_coord_type, ByRef pos1 As MImpred.cart_coord_type, ByRef tan1 As MImpred.cart_coord_type, ByRef m_d2 As Double, ByRef m_d1 As Double)
			Dim num As Double = m_d2 - m_d1
			pos2.X = pos1.X + num * tan1.X
			pos2.Y = pos1.Y + num * tan1.Y
			pos2.z = pos1.z + num * tan1.z
		End Sub

		Public Sub CopyDatasets(objFrom As DataSet, ByRef objTo As DataSet, bConvert As Boolean, bEnglish As Boolean)
			Try
				Dim dataView As DataView = New DataView(objFrom.Tables(0))
				dataView.Sort = "Depth"
				Dim num As Integer = 0
				Try
					For Each obj As Object In dataView
						Dim dataRowView As DataRowView = CType(obj, DataRowView)
						Dim row As DataRow = dataRowView.Row
						Dim dataRow As DataRow = objTo.Tables(0).NewRow()
						Dim num2 As Single
						num += 1
						dataRow("EntryNumber") = num
						num2 = Conversions.ToSingle(row("Depth"))
						If bConvert And Not bEnglish Then
							CtrlUI.ConvertValue(num2, "f", bEnglish)
						ElseIf bConvert AndAlso bEnglish Then
							num2 = CSng(Conversion.Int(CDbl(num2) + 0.5))
							num2 = num2 * 1F / RSWIN_DESC.FT__M
						End If
						dataRow("Depth") = RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(num2), DBNull.Value, num2))
						dataRow("Inclination") = RuntimeHelpers.GetObjectValue(row("Inclination"))
						dataRow("Azimuth") = RuntimeHelpers.GetObjectValue(row("Azimuth"))
						dataRow("Dogleg") = RuntimeHelpers.GetObjectValue(row("Dogleg"))
						If Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(row("TVDepth"))) Then
							Dim num3 As Single = Convert.ToSingle(RuntimeHelpers.GetObjectValue(row("TVDepth")))
							If bConvert And Not bEnglish Then
								CtrlUI.ConvertValue(num3, "f", bEnglish)
							ElseIf bConvert AndAlso bEnglish Then
								num3 = CSng(Math.Round(CDbl((num3 * 1F / RSWIN_DESC.FT__M)), 2))
							End If
							dataRow("TVDepth") = RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(num3), DBNull.Value, num3))
						Else
							dataRow("TVDepth") = RuntimeHelpers.GetObjectValue(row("TVDepth"))
						End If
						If Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(row("NorthSouth"))) Then
							Dim num4 As Single = Convert.ToSingle(RuntimeHelpers.GetObjectValue(row("NorthSouth")))
							If bConvert And Not bEnglish Then
								CtrlUI.ConvertValue(num4, "f", bEnglish)
							ElseIf bConvert AndAlso bEnglish Then
								num4 = CSng(Math.Round(CDbl((num4 * 1F / RSWIN_DESC.FT__M)), 2))
							End If
							dataRow("NorthSouth") = RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(num4), DBNull.Value, num4))
						Else
							dataRow("NorthSouth") = RuntimeHelpers.GetObjectValue(row("NorthSouth"))
						End If
						If Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(row("EastWest"))) Then
							Dim num5 As Single = Convert.ToSingle(RuntimeHelpers.GetObjectValue(row("EastWest")))
							If bConvert And Not bEnglish Then
								CtrlUI.ConvertValue(num5, "f", bEnglish)
							ElseIf bConvert AndAlso bEnglish Then
								num5 = CSng(Math.Round(CDbl((num5 * 1F / RSWIN_DESC.FT__M)), 2))
							End If
							dataRow("EastWest") = RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(num5), DBNull.Value, num5))
						Else
							dataRow("EastWest") = RuntimeHelpers.GetObjectValue(row("EastWest"))
						End If
						objTo.Tables(0).Rows.Add(dataRow)
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
			Catch ex As Exception
			End Try
		End Sub

		Public Sub CopyDatasets2(objFrom As DataSet, ByRef objTo As DataSet, bConvert As Boolean, bEnglish As Boolean)
			Try
				Dim dataView As DataView = New DataView(objFrom.Tables(0))
				dataView.Sort = "Depth"
				Dim num As Integer = 0
				Try
					For Each obj As Object In dataView
						Dim dataRowView As DataRowView = CType(obj, DataRowView)
						Dim row As DataRow = dataRowView.Row
						If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(row("Depth"))) Then
							Dim dataRow As DataRow = objTo.Tables(0).NewRow()
							Dim num2 As Single
							num += 1
							dataRow("EntryNumber") = num
							num2 = Conversions.ToSingle(row("Depth"))
							If bConvert And Not bEnglish Then
								CtrlUI.ConvertValue(num2, "f", bEnglish)
							ElseIf bConvert AndAlso bEnglish Then
								num2 = CSng(Conversion.Int(CDbl(num2) + 0.5))
								num2 = num2 * 1F / RSWIN_DESC.FT__M
							End If
							dataRow("Depth") = RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(num2), DBNull.Value, num2))
							dataRow("Inclination") = RuntimeHelpers.GetObjectValue(row("Inclination"))
							dataRow("Azimuth") = RuntimeHelpers.GetObjectValue(row("Azimuth"))
							dataRow("Dogleg") = RuntimeHelpers.GetObjectValue(row("Dogleg"))
							If Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(row("TVDepth"))) Then
								Dim num3 As Single = Convert.ToSingle(RuntimeHelpers.GetObjectValue(row("TVDepth")))
								If bConvert And Not bEnglish Then
									CtrlUI.ConvertValue(num3, "f", bEnglish)
								ElseIf bConvert AndAlso bEnglish Then
									num3 = CSng(Math.Round(CDbl((num3 * 1F / RSWIN_DESC.FT__M)), 2))
								End If
								dataRow("TVDepth") = RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(num3), DBNull.Value, num3))
							Else
								dataRow("TVDepth") = RuntimeHelpers.GetObjectValue(row("TVDepth"))
							End If
							If Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(row("NorthSouth"))) Then
								Dim num4 As Single = Convert.ToSingle(RuntimeHelpers.GetObjectValue(row("NorthSouth")))
								If bConvert And Not bEnglish Then
									CtrlUI.ConvertValue(num4, "f", bEnglish)
								ElseIf bConvert AndAlso bEnglish Then
									num4 = CSng(Math.Round(CDbl((num4 * 1F / RSWIN_DESC.FT__M)), 2))
								End If
								dataRow("NorthSouth") = RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(num4), DBNull.Value, num4))
							Else
								dataRow("NorthSouth") = RuntimeHelpers.GetObjectValue(row("NorthSouth"))
							End If
							If Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(row("EastWest"))) Then
								Dim num5 As Single = Convert.ToSingle(RuntimeHelpers.GetObjectValue(row("EastWest")))
								If bConvert And Not bEnglish Then
									CtrlUI.ConvertValue(num5, "f", bEnglish)
								ElseIf bConvert AndAlso bEnglish Then
									num5 = CSng(Math.Round(CDbl((num5 * 1F / RSWIN_DESC.FT__M)), 2))
								End If
								dataRow("EastWest") = RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(num5), DBNull.Value, num5))
							Else
								dataRow("EastWest") = RuntimeHelpers.GetObjectValue(row("EastWest"))
							End If
							objTo.Tables(0).Rows.Add(dataRow)
						End If
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
			Catch ex As Exception
			End Try
		End Sub

		Public Function GetPreviousNonSBDiameter(iSB As Integer, ByRef fDiameter As Single, bSinkerbar As Boolean, ByRef iPrevIndex As Integer) As Boolean
			Dim flag As Boolean = True
			Dim result As Boolean = False
			fDiameter = RSWIN_DESC.rst.Sections(iSB).Diameter
			Dim num As Integer = iSB
			While flag
				If num <> 1 Then
					' The following expression was wrapped in a checked-statement
					num -= 1
					If bSinkerbar Then
						If Not(RODUTIL.IsSinkerBar(num) Or If((-If((CUSTOMRG.IsOtherSinkerBar(CInt(RSWIN_DESC.rst.Sections(num).Grade)) > False), 1, 0)), 1, 0)) <> 0 Then
							fDiameter = RSWIN_DESC.rst.Sections(num).Diameter
							iPrevIndex = num
							flag = False
							result = True
						End If
					ElseIf RSWIN_DESC.rst.Sections(num).Diameter < fDiameter Then
						fDiameter = RSWIN_DESC.rst.Sections(num).Diameter
						iPrevIndex = num
						flag = False
						result = True
					End If
				Else
					flag = False
				End If
			End While
			Return result
		End Function

		Public Function CheckSurveyForDeviation() As Boolean
			' The following expression was wrapped in a checked-statement
			Dim result As Boolean
			Try
				Dim dataView As DataView = New DataView(RSWIN_DESC.mdsDeviationProfile.Tables(0))
				dataView.Sort = "Depth"
				If RSWIN_DESC.mdsDeviationProfile.Tables(0).Rows.Count < 2 Then
					MImpred.bHasDeviation = False
				Else
					MImpred.bHasDeviation = False
					Dim num As Integer = 0
					Try
						For Each obj As Object In dataView
							Dim dataRowView As DataRowView = CType(obj, DataRowView)
							Dim row As DataRow = dataRowView.Row
							Dim value As String = MImpred.InclinationCheck(Conversions.ToString(row(2)))
							Dim num2 As Single = Convert.ToSingle(value)
							Dim dataRow As DataRow = row
							Dim dataRow2 As DataRow = dataRow
							Dim columnIndex As Integer = 3
							Dim value2 As String = Conversions.ToString(dataRow2(columnIndex))
							Dim text As String = MImpred.AzimuthCheck(value2)
							dataRow(columnIndex) = value2
							Dim value3 As String = text
							Dim num3 As Single = Convert.ToSingle(value3)
							If(num3 <> 0F Or num2 <> 0F) And num > 1 Then
								MImpred.bHasDeviation = True
								Exit For
							End If
							num += 1
						Next
					Finally
						Dim enumerator As IEnumerator
						If TypeOf enumerator Is IDisposable Then
							TryCast(enumerator, IDisposable).Dispose()
						End If
					End Try
				End If
				result = MImpred.bHasDeviation
			Catch ex As Exception
				result = True
			End Try
			Return result
		End Function

		Public Function EffRodArea(ByRef sect As RSWIN_DESC.RodSection, bIsSinkerBar As Short) As Single
			Dim result As Single
			If Not RODUTIL.IsSteel(CInt(sect.Grade)) <> 0 Then
				result = sect.Area
			ElseIf RODUTIL.IsNoNeck(sect.Grade) Then
				result = sect.Area
			Else
				Dim num As Single = 0F
				Dim diameter As Single = sect.Diameter
				If diameter > 1.624F Then
					num = 1F
				ElseIf diameter > 1.49F Then
					num = 1F
				ElseIf diameter > 1.374F Then
					num = 1F
				ElseIf diameter > 1.24F AndAlso bIsSinkerBar <> 0S Then
					num = 0.875F
				End If
				If num = 0F Then
					result = sect.Area
				Else
					result = CSng((3.141592653589793 * Math.Pow(CDbl(num), 2.0) / 4.0))
				End If
			End If
			Return result
		End Function

		Public Sub AssignGenericVerticalSurvey()
			' The following expression was wrapped in a checked-statement
			Try
				Dim impred As TEImpred = MImpred.m_Impred
				Dim num As Integer = CInt(Math.Round(CDbl((RSWIN_DESC.rst.PumpDepth / 200F + 2F))))
				Dim s_p As TEImpred.survey_point_type() = New TEImpred.survey_point_type(num + 1 - 1) {}
				impred.s_p = s_p
				impred.num_survey_points = num
				Dim num2 As Integer = 0
				Dim num3 As Integer = num
				For i As Integer = num2 To num3
					impred.set_s_p_m_d(i, CDbl((i * 200)))
					impred.set_s_p_azi(i, 0.0)
					impred.set_s_p_inc(i, 0.0)
				Next
				Dim num4 As Single = 200F
				Dim minTaperLength As Single = MImpred.GetMinTaperLength()
				If minTaperLength < num4 Then
					num4 = minTaperLength
				End If
				If RSWIN_DESC.rst.PumpDepth / num4 > CSng(MImpred.m_Impred.num_rod_elements) Then
					MImpred.m_Impred.num_rod_elements = CInt(Math.Round(CDbl((RSWIN_DESC.rst.PumpDepth / num4))))
					MImpred.m_Impred.Max_Rod_Elements = CInt(Math.Round(CDbl((RSWIN_DESC.rst.PumpDepth / num4))))
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Function GetTVD(fMD As Single) As Single
			' The following expression was wrapped in a checked-statement
			Dim result As Single
			Try
				Dim num As Single = 0F
				Dim impred As TEImpred = MImpred.m_Impred
				Dim num2 As Integer = 1
				Dim num_rod_elements As Integer = impred.p_s.num_rod_elements
				Dim num3 As Integer = num2
				While num3 <= num_rod_elements AndAlso MImpred.m_Impred.get_r_e(num3).m_d <= CDbl(fMD)
					num = CSng(MImpred.m_Impred.get_r_e(num3).pos.z)
					num3 += 1
				End While
				result = num
			Catch ex As Exception
				result = fMD
			End Try
			Return result
		End Function

		Public Sub ApplyJohnsFix()
			Dim flag As Boolean = False
			Dim flag2 As Boolean = False
			Try
				RSWIN_DESC.bSteelAboveFGDiameterChanged = False
				Dim impred As TEImpred = MImpred.m_Impred
				Dim num As Integer = 1
				Dim numRods As Integer = CInt(RSWIN_DESC.rst.NumRods)
				For i As Integer = num To numRods
					MImpred.bDiameterChanged(i) = False
					If i > 1 Then
						If RODUTIL.IsFG(RSWIN_DESC.rst.Sections(i).Grade) Or CUSTOMRG.IsOtherFG(CInt(RSWIN_DESC.rst.Sections(i).Grade)) Then
							MImpred.bIsFGlass(i) = True
						Else
							MImpred.bIsFGlass(i) = False
						End If
					Else
						MImpred.bIsFGlass(i) = False
					End If
				Next
				Dim num2 As Integer = 1
				Dim numRods2 As Integer = CInt(RSWIN_DESC.rst.NumRods)
				For i As Integer = num2 To numRods2

						Dim num3 As Single
						num3 += RSWIN_DESC.rst.Sections(i).length

					If i > 1 Then
						flag = False
						flag2 = False
						If i > 1 Then
							If RSWIN_DESC.rst.Sections(i).Diameter > RSWIN_DESC.rst.Sections(i - 1).Diameter Or (MImpred.bDiameterChanged(i - 1) And RSWIN_DESC.rst.Sections(i).Diameter = RSWIN_DESC.rst.Sections(i - 1).Diameter) Then
								flag = True
							End If
							If MImpred.bDiameterChanged(i - 1) And RSWIN_DESC.rst.Sections(i).Diameter = RSWIN_DESC.rst.Sections(i - 1).Diameter Then
								flag2 = True
							End If
						End If
					End If
					If(MImpred.bIsFGlass(i) AndAlso flag) And RSWIN_DESC.SETUP_UseJohnsFix Then
						If i > 1 Then
							If Not MImpred.bIsFGlass(i - 1) And i = 2 Then
								Dim diameter As Single = RSWIN_DESC.rst.Sections(i).Diameter
								impred.set_r_t_rod_od(i, CDbl(diameter))
								impred.set_r_t_rod_area(i, impred.get_r_t_rod_od(i) * impred.get_r_t_rod_od(i) * Math.Atan(1.0))
								Dim num4 As Single
								If RSWIN_DESC.rst.Sections(i).Grade = 20481S Then
									num4 = 100F
								ElseIf RSWIN_DESC.rst.Sections(i).Grade = 16393S Then
									num4 = 125F
								ElseIf RODUTIL.IsFG(RSWIN_DESC.rst.Sections(i).Grade) Then
									num4 = 130F
								Else
									num4 = 491F
								End If
								impred.set_r_t_rod_density(i, CDbl(num4))
								impred.set_r_t_rod_od(i - 1, impred.get_r_t_rod_od(i))
								impred.set_r_t_rod_area(i - 1, impred.get_r_t_rod_area(i))
								If RSWIN_DESC.rst.Sections(i - 1).Grade = 20481S Then
									num4 = 100F
								ElseIf RSWIN_DESC.rst.Sections(i - 1).Grade = 16393S Then
									num4 = 125F
								ElseIf RODUTIL.IsFG(RSWIN_DESC.rst.Sections(i - 1).Grade) Then
									num4 = 130F
								Else
									num4 = 491F
								End If
								impred.set_r_t_rod_density(i - 1, CDbl(num4))
								MImpred.bDiameterChanged(i - 1) = True
								RSWIN_DESC.bSteelAboveFGDiameterChanged = True
							End If
						End If
					ElseIf(RODUTIL.IsSinkerBar(i) Or If((-If((CUSTOMRG.IsOtherSinkerBar(CInt(RSWIN_DESC.rst.Sections(i).Grade)) > False), 1, 0)), 1, 0) Or If((-If((flag > False), 1, 0)), 1, 0)) And If((-If((RSWIN_DESC.SETUP_UseJohnsFix > False), 1, 0)), 1, 0) <> 0 Then
						If Not(i > 1 And RSWIN_DESC.rst.Sections(i - 1).Diameter >= RSWIN_DESC.rst.Sections(i).Diameter And Not flag2) Then

								If i > 1 Then
									Dim diameter As Single
									Dim num5 As Integer
									Dim previousNonSBDiameter As Boolean = MImpred.GetPreviousNonSBDiameter(i, diameter, (RODUTIL.IsSinkerBar(i) Or If((-If((CUSTOMRG.IsOtherSinkerBar(CInt(RSWIN_DESC.rst.Sections(i).Grade)) > False), 1, 0)), 1, 0)) <> 0, num5)
									If previousNonSBDiameter Then
										RSWIN_DESC.bSBDiameterChanged = True
										MImpred.bDiameterChanged(i) = True
										impred.set_r_t_rod_od(i, CDbl(diameter))
										impred.set_r_t_rod_area(i, impred.get_r_t_rod_od(i) * impred.get_r_t_rod_od(i) * Math.Atan(1.0))
										If MImpred.bUseJohnsNewRodDensityCalc Then
											' The following expression was wrapped in a checked-expression
											Dim diameter2 As Single = RSWIN_DESC.rst.Sections(i - 1).Diameter
											Dim diameter3 As Single = RSWIN_DESC.rst.Sections(i).Diameter
											Dim num6 As Single
											Dim num7 As Single
											If MImpred.bUseMD Then
												' The following expression was wrapped in a checked-expression
												num6 = CSng((0.433 * CDbl(RSWIN_DESC.rst.FluidSPGR) * impred.get_r_t_taper_depth(i - 1) + CDbl(RSWIN_DESC.rst.TubingPressure)))
												num7 = CSng((0.433 * CDbl(RSWIN_DESC.rst.FluidSPGR) * impred.get_r_t_taper_depth(i) + CDbl(RSWIN_DESC.rst.TubingPressure)))
											Else
												' The following expression was wrapped in a checked-expression
												num6 = CSng((0.433 * CDbl(RSWIN_DESC.rst.FluidSPGR) * CDbl(MImpred.GetTVD(CSng(impred.get_r_t_taper_depth(i - 1)))) + CDbl(RSWIN_DESC.rst.TubingPressure)))
												num7 = CSng((0.433 * CDbl(RSWIN_DESC.rst.FluidSPGR) * CDbl(MImpred.GetTVD(CSng(impred.get_r_t_taper_depth(i)))) + CDbl(RSWIN_DESC.rst.TubingPressure)))
											End If
											Dim num8 As Single = CSng((CDbl(num6) * (Math.Pow(CDbl(diameter3), 2.0) - Math.Pow(CDbl(diameter2), 2.0))))
											Dim num9 As Single
											If i = CInt(RSWIN_DESC.rst.NumRods) Or MImpred.AllRemainingSame(i) Then
												num9 = CSng((CDbl(num7) * (Math.Pow(CDbl(diameter2), 2.0) - Math.Pow(CDbl(diameter3), 2.0))))
											Else
												' The following expression was wrapped in a checked-expression
												Dim diameter4 As Single = RSWIN_DESC.rst.Sections(i + 1).Diameter
												num9 = CSng((CDbl(num7) * (2.0 * Math.Pow(CDbl(diameter4), 2.0) - Math.Pow(CDbl(diameter3), 2.0) - Math.Pow(CDbl(diameter2), 2.0))))
											End If
											Dim num10 As Single = CSng((Math.Pow(CDbl((diameter2 / 12F)), 2.0) * CDbl(MImpred.GetTotalLength(i))))
											Dim num4 As Single
											If RSWIN_DESC.rst.Sections(i).Grade = 20481S Then
												num4 = 100F
											ElseIf RSWIN_DESC.rst.Sections(i).Grade = 16393S Then
												num4 = 125F
											ElseIf RODUTIL.IsFG(RSWIN_DESC.rst.Sections(i).Grade) Then
												num4 = 130F
											Else
												num4 = 491F
											End If
											If diameter3 <= 1F Then
												impred.set_r_t_rod_density(i, Math.Pow(CDbl((diameter3 / diameter2)), 2.0) * CDbl(num4) * 0.95)
											Else
												impred.set_r_t_rod_density(i, Math.Pow(CDbl((diameter3 / diameter2)), 2.0) * CDbl(num4) + CDbl(((num8 + num9) / num10)))
											End If
											Dim num11 As Single = CSng(impred.get_r_t_rod_density(i))
											If num11 < 490F Then
												impred.set_r_t_rod_density(i, Math.Pow(CDbl((diameter3 / diameter2)), 2.0) * CDbl(num4) * 0.95)
											End If
										Else
											impred.set_r_t_rod_density(i, CDbl((576F * RSWIN_DESC.rst.Sections(i).RodWeight)) / (3.141592653589793 * Math.Pow(impred.get_r_t_rod_od(i), 2.0)))
										End If
									End If
								End If

						End If
					End If
				Next
				If RSWIN_DESC.bRodStarD And RSWIN_DESC.bSBDiameterChanged Then
					Dim num12 As Integer = 1
					Dim numRods3 As Integer = CInt(RSWIN_DESC.rst.NumRods)
					For i As Integer = num12 To numRods3
						MImpred.bSaveDiameterChanged(i) = MImpred.bDiameterChanged(i)
					Next
					Dim num13 As Integer = 1
					Dim numRods4 As Integer = CInt(RSWIN_DESC.rst.NumRods)
					For i As Integer = num13 To numRods4
						If MImpred.bDiameterChanged(i) AndAlso i < CInt(RSWIN_DESC.rst.NumRods) Then
							Dim num14 As Integer = i + 1
							Dim num15 As Integer = num14
							Dim numRods5 As Integer = CInt(RSWIN_DESC.rst.NumRods)
							Dim num16 As Integer = num15
							While num16 <= numRods5 AndAlso (RSWIN_DESC.rst.Sections(i).Grade = RSWIN_DESC.rst.Sections(num16).Grade And RSWIN_DESC.rst.Sections(i).Diameter = RSWIN_DESC.rst.Sections(num16).Diameter)
								impred.set_r_t_rod_density(num16, impred.get_r_t_rod_density(i))
								impred.set_r_t_rod_od(num16, impred.get_r_t_rod_od(i))
								impred.set_r_t_rod_area(num16, impred.get_r_t_rod_area(i))
								MImpred.bSaveDiameterChanged(num16) = True
								num16 += 1
							End While
						End If
					Next
					Dim num17 As Integer = 1
					Dim numRods6 As Integer = CInt(RSWIN_DESC.rst.NumRods)
					For i As Integer = num17 To numRods6
						If MImpred.bDiameterChanged(i) <> MImpred.bSaveDiameterChanged(i) Then
							MImpred.bDiameterChanged(i) = MImpred.bSaveDiameterChanged(i)
						End If
					Next
				End If
			Catch ex As Exception
			End Try
		End Sub

		Public Function GetSidewinderNameAndLoad(iGuide As Short, ByRef SIDEWINDERGUIDE_LOAD As Single) As String
			If iGuide = 4S Then
				SIDEWINDERGUIDE_LOAD = RSWIN_DESC.SETUP_NorrisStandardGuide_Load
				Return "NRS Stndrd"
			End If
			If iGuide = RSWIN_DESC.NorrisSidewinderGuide Then
				SIDEWINDERGUIDE_LOAD = RSWIN_DESC.SETUP_NorrisSidewinderGuide_Load
				Return "Sidewinder"
			End If
			If iGuide = 6S Then
				SIDEWINDERGUIDE_LOAD = RSWIN_DESC.SETUP_RGIJakeCouplingGuide_Load
				Return "Jake Coupl"
			End If
			If iGuide = 7S Then
				SIDEWINDERGUIDE_LOAD = RSWIN_DESC.SETUP_RGISVTGuide_LOAD
				Return "RGI SVT"
			End If
			If iGuide = 8S Then
				SIDEWINDERGUIDE_LOAD = RSWIN_DESC.SETUP_RGITomahawkGuide_LOAD
				Return "Tomahawk"
			End If
			If iGuide = 9S Then
				SIDEWINDERGUIDE_LOAD = RSWIN_DESC.SETUP_RGITornadoGuide_LOAD
				Return "Tornado"
			End If
			If iGuide = 10S Then
				SIDEWINDERGUIDE_LOAD = RSWIN_DESC.SETUP_RGITwisterGuide_LOAD
				Return "Twister"
			End If
			If iGuide = 11S Then
				SIDEWINDERGUIDE_LOAD = RSWIN_DESC.SETUP_RGIWVTGuide_LOAD
				Return "RGI WVT"
			End If
			Dim obj As Object
			Return Conversions.ToString(obj)
		End Function

		Public Function GetRelianceMotorSizeName(sSargentSizeName As String, ByRef iSizeIndex As Integer) As String
			' The following expression was wrapped in a checked-statement
			Try
				Dim text As String = ""
				Dim num As Integer = Strings.InStr(sSargentSizeName, ",", CompareMethod.Binary)
				Dim num2 As Integer = Strings.InStr(sSargentSizeName, " T", CompareMethod.Binary)
				Dim i As Integer = Convert.ToInt32(sSargentSizeName.Substring(num, num2 - num))
				Dim num3 As Integer = 1
				While i > Convert.ToInt32(RSWIN_DESC.Reliance_Table(num3, 1))
					num3 += 1
					If num3 > 7 Then
						IL_6F:
						If Operators.CompareString(text, "", False) = 0 Then
							iSizeIndex = 7
							text = RSWIN_DESC.Reliance_Table(7, 1) + " T Frame"
						End If
						Return text
					End If
				End While
				iSizeIndex = num3
				text = RSWIN_DESC.Reliance_Table(num3, 1) + " T Frame"
				GoTo IL_6F
			Catch ex As Exception
			End Try
			Dim result As String
			Return result
		End Function

		Public Function GetRelianceMotorSettingName(sSargentSettingName As String, iSizeIndex As Integer) As String
			' The following expression was wrapped in a checked-statement
			Dim result As String
			Try
				Dim text As String = ""
				Dim num As Integer = Strings.InStr(sSargentSettingName, "(", CompareMethod.Binary)
				Dim num2 As Integer = Strings.InStr(sSargentSettingName, " hp", CompareMethod.Binary)
				Dim num3 As Single = Convert.ToSingle(sSargentSettingName.Substring(num, num2 - num))
				Dim num4 As Integer = 2
				While True
					num = Strings.InStr(RSWIN_DESC.Reliance_Table(iSizeIndex, num4), "(", CompareMethod.Binary)
					num2 = Strings.InStr(RSWIN_DESC.Reliance_Table(iSizeIndex, num4), " hp", CompareMethod.Binary)
					Dim num5 As Single = Convert.ToSingle(RSWIN_DESC.Reliance_Table(iSizeIndex, num4).Substring(num, num2 - num))
					If num3 <= num5 Then
						Exit For
					End If
					num4 += 1
					If num4 > 5 Then
						GoTo IL_A4
					End If
				End While
				text = RSWIN_DESC.Reliance_Table(iSizeIndex, num4)
				IL_A4:
				If Operators.CompareString(text, "", False) = 0 Then
					text = RSWIN_DESC.Reliance_Table(iSizeIndex, 5)
				End If
				result = text
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Sub GetSectionIndex(fDepth As Single, ByRef indx As Integer)
			Try
				If fDepth <= RSWIN_DESC.taper_lens(1) Or RSWIN_DESC.rst.NumRods = 1S Then
					indx = 1
				ElseIf fDepth <= RSWIN_DESC.taper_lens(2) Or RSWIN_DESC.rst.NumRods = 2S Then
					indx = 2
				ElseIf fDepth <= RSWIN_DESC.taper_lens(3) Or RSWIN_DESC.rst.NumRods = 3S Then
					indx = 3
				ElseIf fDepth <= RSWIN_DESC.taper_lens(4) Or RSWIN_DESC.rst.NumRods = 4S Then
					indx = 4
				ElseIf fDepth <= RSWIN_DESC.taper_lens(5) Or RSWIN_DESC.rst.NumRods = 5S Then
					indx = 5
				ElseIf fDepth <= RSWIN_DESC.taper_lens(6) Or RSWIN_DESC.rst.NumRods = 6S Then
					indx = 6
				ElseIf fDepth <= RSWIN_DESC.taper_lens(7) Or RSWIN_DESC.rst.NumRods = 7S Then
					indx = 7
				ElseIf fDepth <= RSWIN_DESC.taper_lens(8) Or RSWIN_DESC.rst.NumRods = 8S Then
					indx = 8
				ElseIf fDepth <= RSWIN_DESC.taper_lens(9) Or RSWIN_DESC.rst.NumRods = 9S Then
					indx = 9
				ElseIf fDepth <= RSWIN_DESC.taper_lens(10) Or RSWIN_DESC.rst.NumRods = 10S Then
					indx = 10
				ElseIf fDepth <= RSWIN_DESC.taper_lens(11) Or RSWIN_DESC.rst.NumRods = 11S Then
					indx = 11
				ElseIf fDepth <= RSWIN_DESC.taper_lens(12) Or RSWIN_DESC.rst.NumRods = 12S Then
					indx = 12
				ElseIf fDepth <= RSWIN_DESC.taper_lens(13) Or RSWIN_DESC.rst.NumRods = 13S Then
					indx = 13
				ElseIf fDepth <= RSWIN_DESC.taper_lens(14) Or RSWIN_DESC.rst.NumRods = 14S Then
					indx = 14
				ElseIf fDepth <= RSWIN_DESC.taper_lens(15) Or RSWIN_DESC.rst.NumRods = 15S Then
					indx = 15
				ElseIf fDepth <= RSWIN_DESC.taper_lens(16) Or RSWIN_DESC.rst.NumRods = 16S Then
					indx = 16
				ElseIf fDepth <= RSWIN_DESC.taper_lens(17) Or RSWIN_DESC.rst.NumRods = 17S Then
					indx = 17
				ElseIf fDepth <= RSWIN_DESC.taper_lens(18) Or RSWIN_DESC.rst.NumRods = 18S Then
					indx = 18
				ElseIf fDepth <= RSWIN_DESC.taper_lens(19) Or RSWIN_DESC.rst.NumRods = 19S Then
					indx = 19
				ElseIf fDepth <= RSWIN_DESC.taper_lens(20) Or RSWIN_DESC.rst.NumRods = 20S Then
					indx = 20
				Else
					indx = 20
				End If
			Catch ex As Exception
			End Try
		End Sub

		Public Sub GetSectionIndex2(fDepth As Single, ByRef indx As Integer)
			' The following expression was wrapped in a checked-statement
			Try
				indx = 0
				If fDepth <= RSWIN_DESC.taper_lens(1) / 2F Then
					indx = 1
				Else
					Dim num As Integer = 1
					Dim num2 As Integer = CInt((RSWIN_DESC.rst.NumRods - 1S))
					For i As Integer = num To num2
						' The following expression was wrapped in a unchecked-expression
						' The following expression was wrapped in a checked-expression
						If fDepth <= RSWIN_DESC.taper_lens(i) + RSWIN_DESC.rst.Sections(i + 1).length / 2F Then
							indx = i * 2 + 1
							Exit For
						End If
					Next
				End If
				Dim num3 As Integer = 1
				Dim numRods As Integer = CInt(RSWIN_DESC.rst.NumRods)
				For i As Integer = num3 To numRods
					If fDepth <= RSWIN_DESC.taper_lens(i) Or CInt(RSWIN_DESC.rst.NumRods) = i Then
						indx = i * 2
						Exit For
					End If
				Next
			Catch ex As Exception
			End Try
		End Sub

		Public Function GetRodGuideName(RodGuide As Short) As String
			Dim result As String
			Try
				Dim text As String = New String(" "c, 8192)
				If RodGuide = 0S Then
					result = "Bare Rod (no rod guides)"
				ElseIf RodGuide = RSWIN_DESC.MOLDED Then
					result = "Molded"
				ElseIf RodGuide = 2S Then
					result = "Wheeled"
				ElseIf RodGuide = 3S Then
					Dim text2 As String = "OtherGuide"
					Dim text3 As String = "Other"
					Dim length As Short = CShort(RSWIN.GetRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text3, text, True))
					RSWIN_DESC.sOtherGuided = text.Substring(0, CInt(length))
					result = RSWIN_DESC.sOtherGuided
				ElseIf RodGuide = 4S Then
					result = "Norris Standard"
				ElseIf RodGuide = RSWIN_DESC.NorrisSidewinderGuide Then
					result = "Norris Sidewinder"
				ElseIf RodGuide = 6S Then
					result = "RGI Jake Coupling"
				ElseIf RodGuide = 7S Then
					result = "RGI SVT"
				ElseIf RodGuide = 8S Then
					result = "RGI Tomahawk"
				ElseIf RodGuide = 9S Then
					result = "RGI Tornado"
				ElseIf RodGuide = 10S Then
					result = "RGI Twister"
				ElseIf RodGuide = 11S Then
					result = "RGI WVT"
				End If
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Sub GuideFrequencyArrayIndex(Indx As Integer, fDepth As Single, iNumGuides As Integer)
			Dim flag As Boolean = True
			Try
				Dim num As Integer = 1
				Dim numberOfSubSections As Integer = RSWIN_DESC.GuideFrequencyArray(Indx).NumberOfSubSections
				For i As Integer = num To numberOfSubSections
					If fDepth < RSWIN_DESC.GuideFrequencyArray(Indx).SubSections(i).Depth Then
						If Not flag Then
							Dim num2 As Integer = 1
							Dim numberOfSuckerRodsInSection As Integer = RSWIN_DESC.GuideFrequencyArray(Indx).SubSections(i).NumberOfSuckerRodsInSection
							For j As Integer = num2 To numberOfSuckerRodsInSection
								If fDepth <= RSWIN_DESC.GuideFrequencyArray(Indx).SubSections(i).SuckerRodDepths(j) Then
									RSWIN_DESC.GuideFrequencyArray(Indx).SubSections(i).SuckerRodNumGuides(j) = CSng(iNumGuides)
								End If
							Next
						Else
							RSWIN_DESC.GuideFrequencyArray(Indx).SubSections(i).SuckerRodNumGuides(0) = 0F
							Dim num3 As Integer = 1
							Dim numberOfSuckerRodsInSection2 As Integer = RSWIN_DESC.GuideFrequencyArray(Indx).SubSections(i).NumberOfSuckerRodsInSection
							For j As Integer = num3 To numberOfSuckerRodsInSection2
								If fDepth <= RSWIN_DESC.GuideFrequencyArray(Indx).SubSections(i).SuckerRodDepths(j) And fDepth > RSWIN_DESC.GuideFrequencyArray(Indx).SubSections(i).SuckerRodDepths(j - 1) Then
									RSWIN_DESC.GuideFrequencyArray(Indx).SubSections(i).SuckerRodNumGuides(j) = CSng(iNumGuides)
									Exit For
								End If
							Next
						End If
					End If
				Next
			Catch ex As Exception
			End Try
		End Sub

		Public Function GetTotalTaperDepth(iIndx As Integer) As Single
			Dim result As Single
			Try
				Dim impred As TEImpred = MImpred.m_Impred
				Dim num As Single = CSng(impred.get_r_t_taper_depth(iIndx))
				If iIndx < CInt(RSWIN_DESC.rst.NumRods) Then
					' The following expression was wrapped in a checked-expression
					Dim num2 As Integer = iIndx + 1
					Dim num3 As Integer = num2
					Dim numRods As Integer = CInt(RSWIN_DESC.rst.NumRods)
					Dim num4 As Integer = num3
					While num4 <= numRods AndAlso (RSWIN_DESC.rst.Sections(num4).Grade = RSWIN_DESC.rst.Sections(iIndx).Grade And RSWIN_DESC.rst.Sections(num4).Diameter = RSWIN_DESC.rst.Sections(iIndx).Diameter)
						num += RSWIN_DESC.rst.Sections(num4).length
						num4 += 1
					End While
				End If
				result = num
			Catch ex As Exception
				Dim num As Single
				result = num
			End Try
			Return result
		End Function

		Public Function GetTotalLength(iIndx As Integer) As Single
			Dim result As Single
			Try
				Dim num As Single = RSWIN_DESC.rst.Sections(iIndx).length
				If iIndx < CInt(RSWIN_DESC.rst.NumRods) Then
					' The following expression was wrapped in a checked-expression
					Dim num2 As Integer = iIndx + 1
					Dim num3 As Integer = num2
					Dim numRods As Integer = CInt(RSWIN_DESC.rst.NumRods)
					Dim num4 As Integer = num3
					While num4 <= numRods AndAlso (RSWIN_DESC.rst.Sections(num4).Grade = RSWIN_DESC.rst.Sections(iIndx).Grade And RSWIN_DESC.rst.Sections(num4).Diameter = RSWIN_DESC.rst.Sections(iIndx).Diameter)
						num += RSWIN_DESC.rst.Sections(num4).length
						num4 += 1
					End While
				End If
				result = num
			Catch ex As Exception
				Dim num As Single
				result = num
			End Try
			Return result
		End Function

		Public Function AllRemainingSame(iIndx As Integer) As Boolean
			' The following expression was wrapped in a checked-statement
			Dim result As Boolean
			Try
				Dim flag As Boolean = True
				If iIndx < CInt(RSWIN_DESC.rst.NumRods) Then
					Dim num As Integer = iIndx + 1
					Dim num2 As Integer = num
					Dim numRods As Integer = CInt(RSWIN_DESC.rst.NumRods)
					For i As Integer = num2 To numRods
						If Not(RSWIN_DESC.rst.Sections(i).Grade = RSWIN_DESC.rst.Sections(iIndx).Grade And RSWIN_DESC.rst.Sections(i).Diameter = RSWIN_DESC.rst.Sections(iIndx).Diameter) Then
							flag = False
							Exit For
						End If
					Next
				End If
				result = flag
			Catch ex As Exception
				Dim flag As Boolean
				result = flag
			End Try
			Return result
		End Function

		Public Function GetGuideType(ByRef iGuide As Short, iIndx As Integer) As Short
			' The following expression was wrapped in a checked-statement
			Dim result As Short
			Try
				Dim num As Short
				If iGuide <> 0S Then
					num = iGuide
				Else
					num = 0S
					Dim num2 As Integer = 1
					Dim numRods As Integer = CInt(RSWIN_DESC.rst.NumRods)
					For i As Integer = num2 To numRods
						If RSWIN_DESC.rst.Sections(i).Guide <> 0S Then
							num = RSWIN_DESC.rst.Sections(i).Guide
							Exit For
						End If
					Next
					If num = 0S Then
						If RSWIN_DESC.SETUP_GuideToUse <> 0 Then
							num = CShort(RSWIN_DESC.SETUP_GuideToUse)
						Else
							num = RSWIN_DESC.MOLDED
						End If
					End If
				End If
				result = num
			Catch ex As Exception
				result = iGuide
			End Try
			Return result
		End Function

		Private Sub ReadSurvey_old()
			' The following expression was wrapped in a checked-statement
			Try
				Dim flag As Boolean = False
				Dim num As Double = 0.02
				Dim num2 As Double = 0.02
				Dim num3 As Double = 0.02
				Dim num4 As Integer = 300
				Dim dataView As DataView = New DataView(RSWIN_DESC.mdsDeviationProfile.Tables(0))
				Dim num5 As Single = 0F
				Dim num6 As Integer = 0
				Dim flag2 As Boolean = True
				Dim flag3 As Boolean = False
				Dim num7 As Single = 0F
				Dim num8 As Single = 0F
				Dim flag4 As Boolean = False
				Dim flag5 As Boolean = False
				Dim num9 As Integer = 1
				Dim flag6 As Boolean = False
				Dim sDefaultName As String = "SteelSuckerRodLength"
				Dim value As Object = DBNull.Value
				Dim flag7 As Boolean = False
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(ini.GetDefault(sDefaultName, value, flag7))
				RSWIN_DESC.SETUP_SteelSuckerRodLength = Conversions.ToSingle(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)), 25, RuntimeHelpers.GetObjectValue(objectValue)))
				Dim num10 As Integer = CInt(Math.Round(CDbl(RSWIN_DESC.SETUP_SteelSuckerRodLength)))
				dataView.Sort = "Depth"
				Dim i As Integer = 0
				MImpred.m_PI = 4.0 * Math.Atan(1.0)
				Dim num11 As Single = 100000F
				Dim num12 As Single = 100000F
				Dim num13 As Single = 100000F
				Dim teimpred As TEImpred = MImpred.m_Impred
				If RSWIN_DESC.mdsDeviationProfile.Tables(0).Rows.Count < 2 Then
					teimpred.num_survey_points = 2
					Dim num14 As Integer = 1
					Dim num_survey_points As Integer = teimpred.num_survey_points
					i = num14
					While i <= num_survey_points

							teimpred.set_s_p_m_d(i, CDbl(RSWIN_DESC.rst.PumpDepth) * Conversion.Int(CDbl(i) / 2.0))
							teimpred.set_s_p_azi(i, 0.0)
							teimpred.set_s_p_inc(i, 0.0)
							If i > 1 Then
								' The following expression was wrapped in a checked-expression
								num11 = CSng((teimpred.get_s_p_m_d(i) - teimpred.get_s_p_m_d(i - 1)))
							End If

						i += 1
					End While
					num12 = num11
					num13 = num11 * 2F
					MImpred.bUseMD = True
				Else
					i = 1
					Dim num15 As Integer = RSWIN_DESC.mdsDeviationProfile.Tables(0).Rows.Count
					If Not RSWIN_DESC.rst.gbAutomatic And Not RSWIN_DESC.rst.gbBatch Then
						If num15 > num4 And Not MImpred.bSurveyLimitWarningMsgShown Then
							MImpred.bSurveyLimitWarningMsgShown = True
							Dim msg As String = MImpred.sSurveyLimitWarningMsg
							Dim bDefaultYes As Boolean = True
							flag7 = False
							If Not Util.YesNo(msg, bDefaultYes, flag7) Then
								MImpred.bSurveyWarningMsgAnswer = False
								MImpred.bSurveyLimitWarningMsgShown = False
								RSWIN_DESC.bAbortRun = True
								Return
							End If
							flag6 = True
							MImpred.bSurveyWarningMsgAnswer = True
						ElseIf num15 > num4 And MImpred.bSurveyLimitWarningMsgShown And MImpred.bSurveyWarningMsgAnswer Then
							flag6 = True
						End If
					ElseIf RSWIN_DESC.rst.gbBatch And num15 > num4 Then
						flag6 = True
					End If
					Dim flag8 As Boolean = False
					MImpred.bUseMD = False
					Dim array As Single() = New Single(num15 + 1 - 1) {}
					Dim array2 As Single() = New Single(num15 + 1 - 1) {}
					Dim array3 As Single() = New Single(num15 + 1 - 1) {}
					Dim array4 As MImpred.survey_point_type() = New MImpred.survey_point_type(num15 + 1 - 1) {}
					Dim j As Integer
					Dim num22 As Integer
					If flag2 Then
						j = 0
						flag3 = False
						flag5 = False
						Try
							For Each obj As Object In dataView
								Dim dataRowView As DataRowView = CType(obj, DataRowView)
								Dim row As DataRow = dataRowView.Row
								j += 1
								Dim num16 As Single
								Dim num17 As Single
								Dim num18 As Single
								Dim num19 As Single
								If j = 1 Then
									num16 = CSng(Convert.ToDouble(RuntimeHelpers.GetObjectValue(row(1))))
									Dim value2 As String = MImpred.InclinationCheck(Conversions.ToString(row(2)))
									num17 = CSng(Convert.ToDouble(value2))
									Dim dataRow As DataRow = row
									Dim dataRow2 As DataRow = dataRow
									Dim columnIndex As Integer = 3
									Dim value3 As String = Conversions.ToString(dataRow2(columnIndex))
									Dim text As String = MImpred.AzimuthCheck(value3)
									dataRow(columnIndex) = value3
									Dim value4 As String = text
									num18 = CSng(Convert.ToDouble(value4))
								ElseIf j = 2 Then
									num19 = CSng(Convert.ToDouble(RuntimeHelpers.GetObjectValue(row(1))))
									Dim value5 As String = MImpred.InclinationCheck(Conversions.ToString(row(2)))
									Dim num20 As Single = CSng(Convert.ToDouble(value5))
									Dim dataRow As DataRow = row
									Dim dataRow3 As DataRow = dataRow
									Dim columnIndex As Integer = 3
									Dim value3 As String = Conversions.ToString(dataRow3(columnIndex))
									Dim text2 As String = MImpred.AzimuthCheck(value3)
									dataRow(columnIndex) = value3
									Dim value6 As String = text2
									Dim num21 As Single = CSng(Convert.ToDouble(value6))
								End If
								If j = 1 And num16 <> 0F Then
									flag3 = True
									If num16 > 1000F Then
										' The following expression was wrapped in a unchecked-expression
										num22 = CInt(Math.Round(CDbl((num16 / 200F - 2F))))
										num7 = num17
										num8 = num18
										flag5 = True
										Exit For
									End If
									Exit For
								Else
									' The following expression was wrapped in a unchecked-expression
									If Not flag3 And j = 2 And num19 - num16 >= 1000F Then
										' The following expression was wrapped in a unchecked-expression
										num22 = CInt(Math.Round(CDbl((num19 / 200F - 2F))))
										num7 = num17
										num8 = num18
										flag5 = True
										Exit For
									End If
									If j = 3 Then
										Exit For
									End If
								End If
							Next
						Finally
							Dim enumerator As IEnumerator
							If TypeOf enumerator Is IDisposable Then
								TryCast(enumerator, IDisposable).Dispose()
							End If
						End Try
						If flag3 And Not flag5 Then
							num15 += 1
							array = New Single(num15 + 1 - 1) {}
							array2 = New Single(num15 + 1 - 1) {}
							array3 = New Single(num15 + 1 - 1) {}
							array4 = New MImpred.survey_point_type(num15 + 1 - 1) {}
						ElseIf flag3 AndAlso flag5 Then
							num15 = num15 + num22 + 1
							array = New Single(num15 + 1 - 1) {}
							array2 = New Single(num15 + 1 - 1) {}
							array3 = New Single(num15 + 1 - 1) {}
							array4 = New MImpred.survey_point_type(num15 + 1 - 1) {}
						ElseIf flag5 Then
							num15 += num22
							array = New Single(num15 + 1 - 1) {}
							array2 = New Single(num15 + 1 - 1) {}
							array3 = New Single(num15 + 1 - 1) {}
							array4 = New MImpred.survey_point_type(num15 + 1 - 1) {}
						End If
					End If
					j = 0
					Try
						For Each obj2 As Object In dataView
							Dim dataRowView As DataRowView = CType(obj2, DataRowView)
							Dim row As DataRow = dataRowView.Row
							j += 1
							Dim num16 As Single = CSng(Convert.ToDouble(RuntimeHelpers.GetObjectValue(row(1))))
							Dim value2 As String = MImpred.InclinationCheck(Conversions.ToString(row(2)))
							Dim num17 As Single = CSng(Convert.ToDouble(value2))
							Dim dataRow As DataRow = row
							Dim dataRow4 As DataRow = dataRow
							Dim columnIndex As Integer = 3
							Dim value3 As String = Conversions.ToString(dataRow4(columnIndex))
							Dim text3 As String = MImpred.AzimuthCheck(value3)
							dataRow(columnIndex) = value3
							Dim value4 As String = text3
							Dim num18 As Single = CSng(Convert.ToDouble(value4))
							If j = 1 Then
								If flag3 Then
									array(j) = 0F
									array2(j) = 0F
									array3(j) = 0F
									num7 = 0F
									num8 = 0F
									j += 1
									If Not flag5 Then
										array(j) = num16
										array2(j) = num17
										array3(j) = num18
									End If
								End If
								If flag5 Then
									If Not flag3 Then
										array(j) = num16
										array2(j) = num17
										array3(j) = num18
										j += 1
									End If
									Dim num23 As Integer = 1
									Dim num24 As Integer = num22
									For k As Integer = num23 To num24
										array(j) = CSng((k * 200))
										array2(j) = num7
										array3(j) = num8
										If k <> num22 Then
											j += 1
										End If
									Next
								End If
								flag3 = False
								flag5 = False
							Else
								array(j) = num16
								array2(j) = num17
								array3(j) = num18
							End If
						Next
					Finally
						Dim enumerator2 As IEnumerator
						If TypeOf enumerator2 Is IDisposable Then
							TryCast(enumerator2, IDisposable).Dispose()
						End If
					End Try
					Dim array5 As Single() = New Single(num15 + 1 - 1) {}
					Dim array6 As Single() = New Single(num15 + 1 - 1) {}
					MImpred.CalcDogleg(array, array2, array3, array5, array6, num15)
					i = 1
					If array(1) <> 0F Then
						num9 = 1
						teimpred.set_s_p_m_d(i, 0.0)
						teimpred.set_s_p_inc(i, 0.0)
						teimpred.set_s_p_azi(i, 0.0)
						i += 1
					End If
					Try
						Dim num25 As Integer = num9
						Dim num26 As Integer = num15
						j = num25
						While j <= num26
							Dim num27 As Single = array(j)
							Dim num28 As Double = CDbl(array2(j))
							Dim num29 As Double = CDbl(array3(j))
							Dim num30 As Single = array6(j)
							Dim num31 As Single
							Dim num32 As Single
							Dim num35 As Single
							Dim flag9 As Boolean
							If j = 1 Then
								num5 = num27
								num31 = num30
								num32 = array(j + 1)
								Dim num33 As Double = CDbl(array2(j + 1))
								Dim num34 As Double = CDbl(array3(j + 1))
								num35 = array6(j + 1)
							Else
								If Not(flag4 And Not flag9) Then
									num5 = array(j - 1)
								End If
								Dim num36 As Double = CDbl(array2(j - 1))
								Dim num37 As Double = CDbl(array3(j - 1))
								num31 = array6(j - 1)
								If j < num15 Then
									num32 = array(j + 1)
									Dim num33 As Double = CDbl(array2(j + 1))
									Dim num34 As Double = CDbl(array3(j + 1))
									num35 = array6(j + 1)
								Else
									num32 = num27
									num35 = num30
								End If
							End If
							Dim cart_coord_type As MImpred.cart_coord_type
							Dim cart_coord_type2 As MImpred.cart_coord_type
							If j = 1 Then
								Dim num36 As Double = CDbl(array2(j))
								Dim num37 As Double = CDbl(array3(j))

									array4(j).tan.X = Math.Sin(num36) * Math.Sin(num37)
									array4(j).tan.Y = Math.Sin(num36) * Math.Cos(num37)
									array4(j).tan.z = Math.Cos(num36)

								num28 = CDbl(array2(j + 1))
								num29 = CDbl(array3(j + 1))
								array4(j + 1).tan.X = Math.Sin(num28) * Math.Sin(num29)
								array4(j + 1).tan.Y = Math.Sin(num28) * Math.Cos(num29)
								array4(j + 1).tan.z = Math.Cos(num28)
							ElseIf j > 1 And j < num15 Then
								Dim num33 As Double = CDbl(array2(j + 1))
								Dim num34 As Double = CDbl(array3(j + 1))
								array4(j + 1).tan.X = Math.Sin(num33) * Math.Sin(num34)
								array4(j + 1).tan.Y = Math.Sin(num33) * Math.Cos(num34)
								array4(j + 1).tan.z = Math.Cos(num33)
								If array4(j - 1).dog > num Then
									MImpred.cross_prod(cart_coord_type, array4(j - 1).tan, array4(j).tan)
								Else
									array4(j - 1).nor.X = -9999.0
									array4(j - 1).nor.Y = -9999.0
									array4(j - 1).nor.z = -9999.0
								End If
								If array4(j).dog > num Then
									MImpred.cross_prod(cart_coord_type2, array4(j).tan, array4(j + 1).tan)
								Else
									array4(j).nor.X = -9999.0
									array4(j).nor.Y = -9999.0
									array4(j).nor.z = -9999.0
								End If
							ElseIf j = num15 Then
								j = j
							End If
							flag9 = ((j = 1 Or j = num15) OrElse Not j > 1 And Math.Abs(cart_coord_type2.X - cart_coord_type.X) <= num2 * cart_coord_type2.X And Math.Abs(cart_coord_type2.Y - cart_coord_type.Y) <= num2 * cart_coord_type2.Y And Math.Abs(cart_coord_type2.z - cart_coord_type.z) <= num2 * cart_coord_type2.z And CDbl(Math.Abs(num30 - num31)) <= num3 * CDbl(num30) And CDbl(Math.Abs(num30 - num35)) <= num3 * CDbl(num30))
							If Not flag9 And num5 < RSWIN_DESC.rst.PumpDepth And num32 > RSWIN_DESC.rst.PumpDepth Then
								flag9 = True
							End If
							If num29 > 360.0 Then
								flag9 = False
							End If
							If num28 > 180.0 Then
								flag9 = False
							End If
							If flag9 Then
								If Not flag8 And (num29 <> 0.0 Or num28 <> 0.0) And i > 1 Then
									flag8 = True
								End If
								If Not flag8 And num28 = 0.0 And i > 1 Then
									num28 = 0.0
								ElseIf num28 = 0.0 And i > 0 Then
									num28 = 0.0
								End If
								teimpred.set_s_p_m_d(i, CDbl(num27))

									teimpred.set_s_p_azi(i, num29 / 180.0 * MImpred.m_PI)
									teimpred.set_s_p_inc(i, num28 / 180.0 * MImpred.m_PI)
									If i > 1 Then
										' The following expression was wrapped in a checked-expression
										num11 = CSng((teimpred.get_s_p_m_d(i) - teimpred.get_s_p_m_d(i - 1)))
										If(num11 < num12 And num11 <> 0F) AndAlso flag8 Then
											num12 = num11
										End If
										If i > 2 Then
											' The following expression was wrapped in a checked-expression
											Dim num38 As Single = CSng((teimpred.get_s_p_m_d(i) - teimpred.get_s_p_m_d(i - 2)))
											If(num38 < num13 And num38 <> 0F) AndAlso flag8 Then
												num13 = num38
											End If
										End If
									End If

								i += 1
							Else
								num6 += 1
							End If
							num5 = num27
							If num27 > RSWIN_DESC.rst.PumpDepth Then
								j = num15
							End If
							j += 1
						End While
					Catch ex As Exception
						If j > num4 Or i > num4 Then
							flag = True
						End If
					End Try
					teimpred.num_survey_points = i - 1
					If(Not RSWIN_DESC.rst.gbAutomatic And Not RSWIN_DESC.rst.gbBatch) AndAlso flag6 AndAlso (((i - 1 > num4 Or teimpred.num_survey_points > num4) OrElse flag) Or teimpred.get_s_p_m_d(teimpred.num_survey_points) < CDbl(RSWIN_DESC.rst.PumpDepth)) Then
						If Not MImpred.bSurveyLimitErrorMsgShown Then
							MessageBox.Show(MImpred.sSurveyLimitErrorMsg)
							MImpred.bSurveyLimitErrorMsgShown = True
						End If
						RSWIN_DESC.bAbortRun = True
						Return
					End If
					Dim minTaperLength As Single = MImpred.GetMinTaperLength()
					If minTaperLength < num12 Then
						num12 = minTaperLength
					End If
					If minTaperLength < num13 Then
						num13 = minTaperLength
					End If
					MImpred.m_Impred.Max_Rod_Elements = CInt(Math.Round(CDbl((RSWIN_DESC.rst.PumpDepth / num12 + 0F))))
					If RSWIN_DESC.rst.PumpDepth / num13 > CSng(MImpred.m_Impred.num_rod_elements) Then
						If RSWIN_DESC.rst.PumpDepth / num13 < CSng(MImpred.m_Impred.Max_Rod_Elements) Then
							MImpred.m_Impred.num_rod_elements = CInt(Math.Round(CDbl((RSWIN_DESC.rst.PumpDepth / num13))))
						Else
							MImpred.m_Impred.num_rod_elements = MImpred.m_Impred.Max_Rod_Elements
						End If
					End If
					If MImpred.m_Impred.num_survey_points > MImpred.m_Impred.num_rod_elements Then
						MImpred.m_Impred.num_rod_elements = MImpred.m_Impred.num_survey_points
					End If
					If teimpred.get_s_p_m_d(2) - teimpred.get_s_p_m_d(1) < CDbl((RSWIN_DESC.rst.PumpDepth / CSng(MImpred.m_Impred.num_rod_elements))) Then
						Dim num39 As Integer = 2
						Dim num40 As Integer = teimpred.num_survey_points - 1
						i = num39
						While i <= num40
							teimpred.set_s_p_m_d(i, teimpred.get_s_p_m_d(i + 1))
							teimpred.set_s_p_azi(i, teimpred.get_s_p_azi(i + 1))
							teimpred.set_s_p_inc(i, teimpred.get_s_p_inc(i + 1))
							i += 1
						End While
						teimpred.num_survey_points = i - 1
					End If
				End If
				teimpred = Nothing
			Catch ex2 As Exception
			End Try
		End Sub

		Public Sub CheckLastTaperLength()
			Dim num As Single = RSWIN_DESC.rst.Sections(1).length
			Dim num2 As Integer = 2
			Dim numRods As Integer = CInt(RSWIN_DESC.rst.NumRods)
			For i As Integer = num2 To numRods
				num += RSWIN_DESC.rst.Sections(i).length
			Next
			If num > RSWIN_DESC.rst.PumpDepth + 50F Then
				Dim num3 As Single = num - RSWIN_DESC.rst.PumpDepth
				If RSWIN_DESC.rst.Sections(CInt(RSWIN_DESC.rst.NumRods)).length - num3 >= 50F Then
					RSWIN_DESC.rst.Sections(CInt(RSWIN_DESC.rst.NumRods)).length = RSWIN_DESC.rst.Sections(CInt(RSWIN_DESC.rst.NumRods)).length - num3
				ElseIf RSWIN_DESC.rst.NumRods > 1S Then
					' The following expression was wrapped in a checked-expression
					RSWIN_DESC.rst.Sections(CInt((RSWIN_DESC.rst.NumRods - 1S))).length = RSWIN_DESC.rst.Sections(CInt(RSWIN_DESC.rst.NumRods)).length - num3
				End If
				Return
			End If
		End Sub

		Private Const csKEY_ENTRYNUMBER As String = "EntryNumber"

		Private Const csKEY_AZIMUTH As String = "Azimuth"

		Private Const csKEY_DEPTH As String = "Depth"

		Private Const csKEY_DOGLEG As String = "Dogleg"

		Private Const csKEY_INCLINATION As String = "Inclination"

		Private Const csKEY_TVDEPTH As String = "TVDepth"

		Private Const csKEY_NORTHSOUTH As String = "NorthSouth"

		Private Const csKEY_EASTWEST As String = "EastWest"

		Private TEMP_SETUP_NorrisStandardGuide_Load As Single = 30F

		Private TEMP_SETUP_NorrisSidewinderGuide_Load As Single = 50F

		Private TEMP_SETUP_RGIJakeCouplingGuide_Load As Single = 50F

		Private TEMP_SETUP_RGISVTGuide_LOAD As Single = 30F

		Private TEMP_SETUP_RGITomahawkGuide_LOAD As Single = 70F

		Private TEMP_SETUP_RGITornadoGuide_LOAD As Single = 100F

		Private TEMP_SETUP_RGITwisterGuide_LOAD As Single = 60F

		Private TEMP_SETUP_RGIWVTGuide_LOAD As Single = 50F

		Private bHasDeviation As Boolean = False

		Public bSurveyLimitWarningMsgShown As Boolean = False

		Public bSurveyLimitErrorMsgShown As Boolean = False

		Public bSurveyWarningMsgAnswer As Boolean = False

		Private Const rpm_to_rps As Double = 0.10471975511965977

		Private m_bUseJohnsNewRodDensityCalc As Boolean = True

		Private bIsFGlass As Boolean() = New Boolean(40) {}

		Private bDiameterChanged As Boolean() = New Boolean(40) {}

		Private bSaveDiameterChanged As Boolean() = New Boolean(40) {}

		Private iMinGuide As Integer

		Private mc_GEARBOXEFFICIENCY As Double = 0.88

		Private mc_VBELTEFFICIENCY As Double = 0.94

		Private mc_PUMPJACKEFFICIENCY As Double = Math.Pow(MImpred.mc_GEARBOXEFFICIENCY * MImpred.mc_VBELTEFFICIENCY, 0.2)

		Private Const iMaxPoints As Integer = 1500

		Private sSurveyLimitWarningMsg As String = "The maximum number of deviation survey profile points allowed (" + Conversions.ToString(1500) + ") has been exceeded. Would you like RODSTAR-D to attempt to remove extraneous points and continue to run?"

		Private sSurveyLimitErrorMsg As String = "RODSTAR was unable to automatically reduce the number of deviation survey points to (" + Conversions.ToString(1500) + ") or less. Please remove some points manually"

		Private mc_GEARBOXRATIO As Double = 28.45

		Private mc_VBELTRATIO As Double = 3.2961

		Private m_bSBFound As Boolean

		Private m_bHasFG As Boolean

		Private m_bHasRibbonRod As Boolean

		Private m_bLastTaperSB As Boolean

		Private m_new_ratio_vb As Double

		Private m_bVBeltRatio As Boolean

		Private m_Impred As TEImpred

		Private m_PI As Double

		Private mfSpeemax As Double

		Private mfTubingAnchorDepth As Double

		Private TEMP_SETUP_BAREROD_LOAD As Single

		Private TEMP_SETUP_MOLDEDGUIDE_LOAD As Single

		Private TEMP_SETUP_WHEELGUIDE_LOAD As Single

		Private TEMP_SETUP_OTHERGUIDE_LOAD As Single

		Private TEMP_SETUP_SIDEWINDERGUIDE_LOAD As Single

		Private Const iLineNumPerPage As Integer = 35

		Private bUseMD As Boolean

		Private m_JPred As cJPred

		Private m_IndPumpOp As Short

		Private m_Pumpfill As Single

		Private m_dflnu As Single

		Private m_Peff As Single

		Private Structure cart_coord_type
			Public X As Double

			Public Y As Double

			Public z As Double
		End Structure

		Private Structure parameter_structure_type
			Public p_s As Double
		End Structure

		Private Structure survey_point_type
			Public m_d As Double

			Public inc As Double

			Public azi As Double

			Public dog As Double

			Public rad As Double

			Public pos As MImpred.cart_coord_type

			Public tan As MImpred.cart_coord_type

			Public nor As MImpred.cart_coord_type
		End Structure
	End Module
End Namespace
