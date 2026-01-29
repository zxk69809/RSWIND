Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.OleDb
Imports System.Diagnostics
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	Friend NotInheritable Module GURU_DB
		Public Sub DBAddFiledata(ByRef file As RSWIN_DESC.GuruFileDataStructure, bQuiet As Boolean, bByProgram As Boolean)
			If Operators.CompareString(RSWIN_DESC.GuruDataBaseFileName, RSWIN_DESC.sTemplateDBFileName, False) = 0 Then
				Dim sTemplateDBFileName As String = RSWIN_DESC.sTemplateDBFileName
				Dim guruDataBaseFileName As String = RSWIN_DESC.GuruDataBaseFileName
				FILEUTIL.LocateFile(sTemplateDBFileName, guruDataBaseFileName, 2S, False, False, False, False)
				RSWIN_DESC.GuruDataBaseFileName = guruDataBaseFileName
			End If
			Dim connectionString As String = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + RSWIN_DESC.GuruDataBaseFileName + ";Mode=Share Deny None;Extended Properties="""";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password=", RSWIN_DESC.GuruDatabasePassword), ";Jet OLEDB:Engine Type=5;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password="""";Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False"))
			Dim text As String = "filedata"
			Dim selectCommandText As String = "Select * from " + text
			Try
				Dim oleDbConnection As OleDbConnection = New OleDbConnection(connectionString)
				Dim oleDbDataAdapter As OleDbDataAdapter = New OleDbDataAdapter(selectCommandText, oleDbConnection)
				oleDbDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey
				Dim dataSet As DataSet = New DataSet("filedata")
				oleDbDataAdapter.Fill(dataSet, text)
				Dim count As Integer = dataSet.Tables(0).Rows.Count
				Dim dataRow As DataRow = dataSet.Tables(0).NewRow()
				Try
					If RSWIN_DESC.bXRODAdmin Then
						dataRow("FileName") = file.FileName
						dataRow("WellName") = file.WellName
						dataRow("gbCalcPumpCondition") = file.gbCalcPumpCondition
						dataRow("PumpCondition") = file.PumpCondition
						dataRow("IrotEntered") = file.IrotEntered
						dataRow("CalcPlungerSize") = file.CalcPlungerSize
						dataRow("gbCalcPumpIntakePressure") = file.gbCalcPumpIntakePressure
						dataRow("CasingPressure") = file.CasingPressure
						dataRow("CompressibilityIndex") = file.CompressibilityIndex
						dataRow("ElectricityCost") = file.ElectricityCost
						dataRow("FluidDamping") = file.FluidDamping
						dataRow("FluidLevel") = file.FluidLevel
						dataRow("gbIncludeBuoyancy") = file.gbIncludeBuoyancy
						dataRow("IncludeFluidInertia") = file.IncludeFluidInertia
						dataRow("Iart") = file.Iart
						dataRow("Irot") = file.Irot
						dataRow("UnknownM") = file.UnknownM
						dataRow("M_Existing") = file.M_Existing
						dataRow("CBEffect") = file.CBEffect
						dataRow("CBAngle") = file.CBAngle
						dataRow("CBDataType") = file.CBDataType
						dataRow("CalcMotorSize") = file.CalcMotorSize
						dataRow("IncludeMotorSPV") = file.IncludeMotorSPV
						dataRow("MotorSPV") = file.MotorSPV
						dataRow("OilAPI") = file.OilAPI
						dataRow("PlungerSize") = file.PlungerSize
						dataRow("PowerMeterType") = file.PowerMeterType
						dataRow("PumpDepth") = file.PumpDepth
						dataRow("PumpEfficiency") = file.PumpEfficiency
						dataRow("PumpFillage") = file.PumpFillage
						dataRow("PumpFriction") = file.PumpFriction
						dataRow("PumpIntakePressure") = file.PumpIntakePressure
						dataRow("PumpLoadAdj") = file.PumpLoadAdj
						dataRow("PumpType") = file.PumpType
						dataRow("SPM") = file.SPM
						dataRow("CalcFriction") = file.CalcFriction
						dataRow("DownstrokeFriction") = file.DownstrokeFriction
						dataRow("UpstrokeFriction") = file.UpstrokeFriction
						dataRow("XTimes") = file.XTimes
						dataRow("Runtime") = file.Runtime
						dataRow("StuffingBoxFriction") = file.StuffingBoxFriction
						dataRow("TargetBFPD") = file.TargetBFPD
						dataRow("TubingAnchorDepth") = file.TubingAnchorDepth
						dataRow("TubingAnchored") = file.TubingAnchored
						dataRow("TubingID") = file.TubingID
						dataRow("TubingOD") = file.TubingOD
						dataRow("TubingPressure") = file.TubingPressure
						dataRow("WaterCut") = file.WaterCut
						dataRow("WaterSPGR") = file.WaterSPGR
						dataRow("RodStringType") = file.RodStringType
						dataRow("giRodDesignStyle") = file.giRodDesignStyle
						dataRow("RSFGIncludeSteel") = file.RSFGIncludeSteel
						dataRow("RSGrade") = file.RSGrade
						dataRow("RSMaxSize") = file.RSMaxSize
						dataRow("RSMinSize") = file.RSMinSize
						dataRow("RSFricCoef") = file.RSFricCoef
						dataRow("RSIncludeSB") = file.RSIncludeSB
						dataRow("SinkerBar_Grade") = file.SinkerBar_Grade
						dataRow("SinkerBar_length") = file.SinkerBar_length
						dataRow("SinkerBar_Diameter") = file.SinkerBar_Diameter
						dataRow("RSFGGrade") = file.RSFGGrade
						dataRow("RSExtraCost") = file.RSExtraCost
						If Operators.CompareString(file.RSExtraCostLabel, "", False) = 0 Then
							file.RSExtraCostLabel = " "
						End If
						dataRow("RSExtraCostLabel") = file.RSExtraCostLabel
						dataRow("ServiceFactor") = file.ServiceFactor
						dataRow("PU_CrankRotation") = file.PU_CrankRotation
						dataRow("PU_CrankHole") = file.PU_CrankHole
						dataRow("Unbalance") = file.Unbalance
						dataRow("Unit") = file.Unit
						dataRow("ID") = file.ID
						dataRow("DateAdded") = DateAndTime.Now.[Date]
						dataRow("Original") = file.Original
					Else
						dataRow("FileName") = RuntimeHelpers.GetObjectValue(GURU_DB.EnDeCrypt(file.FileName))
						dataRow("WellName") = file.WellName
						dataRow("gbCalcPumpCondition") = file.gbCalcPumpCondition
						dataRow("PumpCondition") = file.PumpCondition
						dataRow("IrotEntered") = file.IrotEntered
						dataRow("CalcPlungerSize") = file.CalcPlungerSize
						dataRow("gbCalcPumpIntakePressure") = file.gbCalcPumpIntakePressure
						dataRow("CasingPressure") = file.CasingPressure
						dataRow("CompressibilityIndex") = file.CompressibilityIndex
						dataRow("ElectricityCost") = file.ElectricityCost
						dataRow("FluidDamping") = file.FluidDamping
						dataRow("FluidLevel") = RuntimeHelpers.GetObjectValue(GURU_DB.EnDeCrypt(Conversions.ToString(file.FluidLevel)))
						dataRow("gbIncludeBuoyancy") = file.gbIncludeBuoyancy
						dataRow("IncludeFluidInertia") = file.IncludeFluidInertia
						dataRow("Iart") = file.Iart
						dataRow("Irot") = file.Irot
						dataRow("UnknownM") = file.UnknownM
						dataRow("M_Existing") = file.M_Existing
						dataRow("CBEffect") = file.CBEffect
						dataRow("CBAngle") = file.CBAngle
						dataRow("CBDataType") = file.CBDataType
						dataRow("CalcMotorSize") = file.CalcMotorSize
						dataRow("IncludeMotorSPV") = file.IncludeMotorSPV
						dataRow("MotorSPV") = file.MotorSPV
						dataRow("OilAPI") = file.OilAPI
						dataRow("PlungerSize") = file.PlungerSize
						dataRow("PowerMeterType") = file.PowerMeterType
						dataRow("PumpDepth") = RuntimeHelpers.GetObjectValue(GURU_DB.EnDeCrypt(Conversions.ToString(file.PumpDepth)))
						dataRow("PumpEfficiency") = file.PumpEfficiency
						dataRow("PumpFillage") = file.PumpFillage
						dataRow("PumpFriction") = file.PumpFriction
						dataRow("PumpIntakePressure") = file.PumpIntakePressure
						dataRow("PumpLoadAdj") = file.PumpLoadAdj
						dataRow("PumpType") = file.PumpType
						dataRow("SPM") = file.SPM
						dataRow("CalcFriction") = file.CalcFriction
						dataRow("DownstrokeFriction") = file.DownstrokeFriction
						dataRow("UpstrokeFriction") = file.UpstrokeFriction
						dataRow("XTimes") = file.XTimes
						dataRow("Runtime") = file.Runtime
						dataRow("StuffingBoxFriction") = file.StuffingBoxFriction
						dataRow("TargetBFPD") = RuntimeHelpers.GetObjectValue(GURU_DB.EnDeCrypt(Conversions.ToString(file.TargetBFPD)))
						dataRow("TubingAnchorDepth") = RuntimeHelpers.GetObjectValue(GURU_DB.EnDeCrypt(Conversions.ToString(file.TubingAnchorDepth)))
						dataRow("TubingAnchored") = file.TubingAnchored
						dataRow("TubingID") = file.TubingID
						dataRow("TubingOD") = file.TubingOD
						dataRow("TubingPressure") = file.TubingPressure
						dataRow("WaterCut") = file.WaterCut
						dataRow("WaterSPGR") = file.WaterSPGR
						dataRow("RodStringType") = file.RodStringType
						dataRow("giRodDesignStyle") = file.giRodDesignStyle
						dataRow("RSFGIncludeSteel") = file.RSFGIncludeSteel
						dataRow("RSGrade") = file.RSGrade
						dataRow("RSMaxSize") = file.RSMaxSize
						dataRow("RSMinSize") = file.RSMinSize
						dataRow("RSFricCoef") = file.RSFricCoef
						dataRow("RSIncludeSB") = file.RSIncludeSB
						dataRow("SinkerBar_Grade") = file.SinkerBar_Grade
						dataRow("SinkerBar_length") = file.SinkerBar_length
						dataRow("SinkerBar_Diameter") = file.SinkerBar_Diameter
						dataRow("RSFGGrade") = file.RSFGGrade
						dataRow("RSExtraCost") = file.RSExtraCost
						If Operators.CompareString(file.RSExtraCostLabel, "", False) = 0 Then
							file.RSExtraCostLabel = " "
						End If
						dataRow("RSExtraCostLabel") = file.RSExtraCostLabel
						dataRow("ServiceFactor") = file.ServiceFactor
						dataRow("PU_CrankRotation") = file.PU_CrankRotation
						dataRow("PU_CrankHole") = file.PU_CrankHole
						dataRow("Unbalance") = file.Unbalance
						dataRow("Unit") = RuntimeHelpers.GetObjectValue(GURU_DB.EnDeCrypt(file.Unit))
						dataRow("ID") = RuntimeHelpers.GetObjectValue(GURU_DB.EnDeCrypt(file.ID))
						dataRow("DateAdded") = DateAndTime.Now.[Date]
						dataRow("Original") = file.Original
					End If
				Catch ex As Exception
					If Not bQuiet Then
						MessageBox.Show(ex.Message)
					End If
				End Try
				Try
					Try
						dataSet.Tables(0).Rows.Add(dataRow)
						If RSWIN_DESC.bXRODAdmin Then
							' The following expression was wrapped in a checked-expression
							RSWIN_DESC.frn_AI_Admin_log = CShort(FileSystem.FreeFile())
							FileSystem.FileOpen(CInt(RSWIN_DESC.frn_AI_Admin_log), RSWIN_DESC.sAIAdminLog, OpenMode.Append, OpenAccess.[Default], OpenShare.[Default], -1)
							FileSystem.PrintLine(CInt(RSWIN_DESC.frn_AI_Admin_log), New Object() { Operators.ConcatenateObject(DateAndTime.Now.ToString() + "  : Template (" + file.FileName + ") added, ", Interaction.IIf(bByProgram, "by program.", "by administrator.")) })
							FileSystem.FileClose(New Integer() { CInt(RSWIN_DESC.frn_AI_Admin_log) })
						End If
					Catch ex2 As OleDbException
						If Not bQuiet Then
							MessageBox.Show(ex2.Message)
						End If
					End Try
				Catch ex3 As Exception
					If Not bQuiet Then
						MessageBox.Show(ex3.Message)
					End If
				End Try
				Dim oleDbCommandBuilder As OleDbCommandBuilder = New OleDbCommandBuilder(oleDbDataAdapter)
				Try
					Dim num As Integer = oleDbDataAdapter.Update(dataSet, text)
				Catch ex4 As OleDbException
					If Not bQuiet Then
						MessageBox.Show(ex4.Message)
					End If
				End Try
				count = dataSet.Tables(0).Rows.Count
				If oleDbConnection.State = ConnectionState.Open Then
					oleDbConnection.Close()
					GURU_DB.bDBOpened = 0S
				End If
			Catch ex5 As OleDbException
				If Not bQuiet Then
					MessageBox.Show("Error in DBAddFiledata: " + ex5.Message)
				End If
			End Try
		End Sub

		Public Sub ReLoadALLGuruFiledata()
			GURU_DB.myFile = Nothing
			GURU_DB.myFile = New cGuruFileData()
			GURU_DB.LoadALLGuruFiledata(False)
			RSWIN_DESC.bGuruFileDataLoaded = True
		End Sub

		Public Sub DBClose()
			GURU_DB.myFile.CloseDB()
			GURU_DB.bDBOpened = 0S
		End Sub

		Public Sub DBNextFile(ByRef iFile As Integer)
			Dim guruFileDataStructure As RSWIN_DESC.GuruFileDataStructure
			Dim flag As Boolean = GURU_DB.ReadFiledata(iFile, guruFileDataStructure)
		End Sub

		Public Sub DBOpen()
			If Strings.Len(RSWIN_DESC.GuruDataBaseFileName) = 0 Then
				Try
					Dim sTemplateDBFileName As String = RSWIN_DESC.sTemplateDBFileName
					Dim guruDataBaseFileName As String = RSWIN_DESC.GuruDataBaseFileName
					FILEUTIL.LocateFile(sTemplateDBFileName, guruDataBaseFileName, 2S, False, False, False, False)
					RSWIN_DESC.GuruDataBaseFileName = guruDataBaseFileName
					GURU_DB.myFile = New cGuruFileData()
					GURU_DB.LoadALLGuruFiledata(False)
					RSWIN_DESC.bGuruFileDataLoaded = True
				Catch ex As Exception
					MessageBox.Show(ex.Message)
				End Try
			End If
			GURU_DB.bDBOpened = -1S
		End Sub

		Public Function UpdateRow(iFile As Integer, sFileName As String, bByProgram As Boolean) As Object
			If Operators.CompareString(RSWIN_DESC.GuruDataBaseFileName, RSWIN_DESC.sTemplateDBFileName, False) = 0 Then
				Dim sTemplateDBFileName As String = RSWIN_DESC.sTemplateDBFileName
				Dim guruDataBaseFileName As String = RSWIN_DESC.GuruDataBaseFileName
				FILEUTIL.LocateFile(sTemplateDBFileName, guruDataBaseFileName, 2S, False, False, False, False)
				RSWIN_DESC.GuruDataBaseFileName = guruDataBaseFileName
			End If
			Dim connectionString As String = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + RSWIN_DESC.GuruDataBaseFileName + ";Mode=Share Deny None;Extended Properties="""";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password=", RSWIN_DESC.GuruDatabasePassword), ";Jet OLEDB:Engine Type=5;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password="""";Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False"))
			Dim text As String = "Filedata"
			Dim selectCommandText As String = String.Concat(New String() { "Select * from ", text, " where FileName=", RSWIN_DESC.sSnglQuote, sFileName, RSWIN_DESC.sSnglQuote })
			Try
				Try
					Dim oleDbConnection As OleDbConnection = New OleDbConnection(connectionString)
					Dim oleDbDataAdapter As OleDbDataAdapter = New OleDbDataAdapter(selectCommandText, oleDbConnection)
					oleDbDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey
					Dim dataSet As DataSet = New DataSet("filedata")
					oleDbDataAdapter.Fill(dataSet, text)
					Dim dataRow As DataRow = dataSet.Tables(text).Rows(0)
					If Operators.ConditionalCompareObjectEqual(dataRow("FileName"), RSWIN_DESC.AllGuruFiles(iFile).FileName, False) Then
						If RSWIN_DESC.bXRODAdmin Then
							dataRow("FileName") = RSWIN_DESC.AllGuruFiles(iFile).FileName
							dataRow("WellName") = RSWIN_DESC.AllGuruFiles(iFile).WellName
							dataRow("gbCalcPumpCondition") = RSWIN_DESC.AllGuruFiles(iFile).gbCalcPumpCondition
							dataRow("PumpCondition") = RSWIN_DESC.AllGuruFiles(iFile).PumpCondition
							dataRow("IrotEntered") = RSWIN_DESC.AllGuruFiles(iFile).IrotEntered
							dataRow("CalcPlungerSize") = RSWIN_DESC.AllGuruFiles(iFile).CalcPlungerSize
							dataRow("gbCalcPumpIntakePressure") = RSWIN_DESC.AllGuruFiles(iFile).gbCalcPumpIntakePressure
							dataRow("CasingPressure") = RSWIN_DESC.AllGuruFiles(iFile).CasingPressure
							dataRow("WellName") = RSWIN_DESC.AllGuruFiles(iFile).WellName
							dataRow("CompressibilityIndex") = RSWIN_DESC.AllGuruFiles(iFile).CompressibilityIndex
							dataRow("ElectricityCost") = RSWIN_DESC.AllGuruFiles(iFile).ElectricityCost
							dataRow("FluidDamping") = RSWIN_DESC.AllGuruFiles(iFile).FluidDamping
							dataRow("FluidLevel") = RSWIN_DESC.AllGuruFiles(iFile).FluidLevel
							dataRow("gbIncludeBuoyancy") = RSWIN_DESC.AllGuruFiles(iFile).gbIncludeBuoyancy
							dataRow("IncludeFluidInertia") = RSWIN_DESC.AllGuruFiles(iFile).IncludeFluidInertia
							dataRow("Iart") = RSWIN_DESC.AllGuruFiles(iFile).Iart
							dataRow("Irot") = RSWIN_DESC.AllGuruFiles(iFile).Irot
							dataRow("UnknownM") = RSWIN_DESC.AllGuruFiles(iFile).UnknownM
							dataRow("M_Existing") = RSWIN_DESC.AllGuruFiles(iFile).M_Existing
							dataRow("CBEffect") = RSWIN_DESC.AllGuruFiles(iFile).CBEffect
							dataRow("CBAngle") = RSWIN_DESC.AllGuruFiles(iFile).CBAngle
							dataRow("CBDataType") = RSWIN_DESC.AllGuruFiles(iFile).CBDataType
							dataRow("CalcMotorSize") = RSWIN_DESC.AllGuruFiles(iFile).CalcMotorSize
							dataRow("IncludeMotorSPV") = RSWIN_DESC.AllGuruFiles(iFile).IncludeMotorSPV
							dataRow("MotorSPV") = RSWIN_DESC.AllGuruFiles(iFile).MotorSPV
							dataRow("OilAPI") = RSWIN_DESC.AllGuruFiles(iFile).OilAPI
							dataRow("PlungerSize") = RSWIN_DESC.AllGuruFiles(iFile).PlungerSize
							dataRow("PowerMeterType") = RSWIN_DESC.AllGuruFiles(iFile).PowerMeterType
							dataRow("PumpDepth") = RSWIN_DESC.AllGuruFiles(iFile).PumpDepth
							dataRow("PumpEfficiency") = RSWIN_DESC.AllGuruFiles(iFile).PumpEfficiency
							dataRow("PumpFillage") = RSWIN_DESC.AllGuruFiles(iFile).PumpFillage
							dataRow("PumpFriction") = RSWIN_DESC.AllGuruFiles(iFile).PumpFriction
							dataRow("PumpIntakePressure") = RSWIN_DESC.AllGuruFiles(iFile).PumpIntakePressure
							dataRow("PumpLoadAdj") = RSWIN_DESC.AllGuruFiles(iFile).PumpLoadAdj
							dataRow("PumpType") = RSWIN_DESC.AllGuruFiles(iFile).PumpType
							dataRow("SPM") = RSWIN_DESC.AllGuruFiles(iFile).SPM
							dataRow("CalcFriction") = RSWIN_DESC.AllGuruFiles(iFile).CalcFriction
							dataRow("DownstrokeFriction") = RSWIN_DESC.AllGuruFiles(iFile).DownstrokeFriction
							dataRow("UpstrokeFriction") = RSWIN_DESC.AllGuruFiles(iFile).UpstrokeFriction
							dataRow("XTimes") = RSWIN_DESC.AllGuruFiles(iFile).XTimes
							dataRow("Runtime") = RSWIN_DESC.AllGuruFiles(iFile).Runtime
							dataRow("StuffingBoxFriction") = RSWIN_DESC.AllGuruFiles(iFile).StuffingBoxFriction
							dataRow("TargetBFPD") = RSWIN_DESC.AllGuruFiles(iFile).TargetBFPD
							dataRow("TubingAnchorDepth") = RSWIN_DESC.AllGuruFiles(iFile).TubingAnchorDepth
							dataRow("TubingAnchored") = RSWIN_DESC.AllGuruFiles(iFile).TubingAnchored
							dataRow("TubingID") = RSWIN_DESC.AllGuruFiles(iFile).TubingID
							dataRow("TubingOD") = RSWIN_DESC.AllGuruFiles(iFile).TubingOD
							dataRow("TubingPressure") = RSWIN_DESC.AllGuruFiles(iFile).TubingPressure
							dataRow("WaterCut") = RSWIN_DESC.AllGuruFiles(iFile).WaterCut
							dataRow("WaterSPGR") = RSWIN_DESC.AllGuruFiles(iFile).WaterSPGR
							dataRow("RodStringType") = RSWIN_DESC.AllGuruFiles(iFile).RodStringType
							dataRow("giRodDesignStyle") = RSWIN_DESC.AllGuruFiles(iFile).giRodDesignStyle
							dataRow("RSFGIncludeSteel") = RSWIN_DESC.AllGuruFiles(iFile).RSFGIncludeSteel
							dataRow("RSGrade") = RSWIN_DESC.AllGuruFiles(iFile).RSGrade
							dataRow("RSMaxSize") = RSWIN_DESC.AllGuruFiles(iFile).RSMaxSize
							dataRow("RSMinSize") = RSWIN_DESC.AllGuruFiles(iFile).RSMinSize
							dataRow("RSFricCoef") = RSWIN_DESC.AllGuruFiles(iFile).RSFricCoef
							dataRow("RSIncludeSB") = RSWIN_DESC.AllGuruFiles(iFile).RSIncludeSB
							dataRow("SinkerBar_Grade") = RSWIN_DESC.AllGuruFiles(iFile).SinkerBar_Grade
							dataRow("SinkerBar_length") = RSWIN_DESC.AllGuruFiles(iFile).SinkerBar_length
							dataRow("SinkerBar_Diameter") = RSWIN_DESC.AllGuruFiles(iFile).SinkerBar_Diameter
							dataRow("RSFGGrade") = RSWIN_DESC.AllGuruFiles(iFile).RSFGGrade
							dataRow("RSExtraCost") = RSWIN_DESC.AllGuruFiles(iFile).RSExtraCost
							dataRow("RSExtraCostLabel") = RSWIN_DESC.AllGuruFiles(iFile).RSExtraCostLabel
							If Operators.ConditionalCompareObjectEqual(dataRow("RSExtraCostLabel"), "", False) Then
								dataRow("RSExtraCostLabel") = " "
							End If
							dataRow("ServiceFactor") = RSWIN_DESC.AllGuruFiles(iFile).ServiceFactor
							dataRow("PU_CrankRotation") = RSWIN_DESC.AllGuruFiles(iFile).PU_CrankRotation
							dataRow("PU_CrankHole") = RSWIN_DESC.AllGuruFiles(iFile).PU_CrankHole
							dataRow("Unbalance") = RSWIN_DESC.AllGuruFiles(iFile).Unbalance
							dataRow("Unit") = RSWIN_DESC.AllGuruFiles(iFile).Unit
							dataRow("ID") = RSWIN_DESC.AllGuruFiles(iFile).ID
							dataRow("DateAdded") = DateAndTime.Now.[Date]
							dataRow("Original") = RSWIN_DESC.AllGuruFiles(iFile).Original
						Else
							dataRow("FileName") = RuntimeHelpers.GetObjectValue(GURU_DB.EnDeCrypt(RSWIN_DESC.AllGuruFiles(iFile).FileName))
							dataRow("WellName") = RSWIN_DESC.AllGuruFiles(iFile).WellName
							dataRow("gbCalcPumpCondition") = RSWIN_DESC.AllGuruFiles(iFile).gbCalcPumpCondition
							dataRow("PumpCondition") = RSWIN_DESC.AllGuruFiles(iFile).PumpCondition
							dataRow("IrotEntered") = RSWIN_DESC.AllGuruFiles(iFile).IrotEntered
							dataRow("CalcPlungerSize") = RSWIN_DESC.AllGuruFiles(iFile).CalcPlungerSize
							dataRow("gbCalcPumpIntakePressure") = RSWIN_DESC.AllGuruFiles(iFile).gbCalcPumpIntakePressure
							dataRow("CasingPressure") = RSWIN_DESC.AllGuruFiles(iFile).CasingPressure
							dataRow("CompressibilityIndex") = RSWIN_DESC.AllGuruFiles(iFile).CompressibilityIndex
							dataRow("ElectricityCost") = RSWIN_DESC.AllGuruFiles(iFile).ElectricityCost
							dataRow("FluidDamping") = RSWIN_DESC.AllGuruFiles(iFile).FluidDamping
							dataRow("FluidLevel") = RuntimeHelpers.GetObjectValue(GURU_DB.EnDeCrypt(Conversions.ToString(RSWIN_DESC.AllGuruFiles(iFile).FluidLevel)))
							dataRow("gbIncludeBuoyancy") = RSWIN_DESC.AllGuruFiles(iFile).gbIncludeBuoyancy
							dataRow("IncludeFluidInertia") = RSWIN_DESC.AllGuruFiles(iFile).IncludeFluidInertia
							dataRow("Iart") = RSWIN_DESC.AllGuruFiles(iFile).Iart
							dataRow("Irot") = RSWIN_DESC.AllGuruFiles(iFile).Irot
							dataRow("UnknownM") = RSWIN_DESC.AllGuruFiles(iFile).UnknownM
							dataRow("M_Existing") = RSWIN_DESC.AllGuruFiles(iFile).M_Existing
							dataRow("CBEffect") = RSWIN_DESC.AllGuruFiles(iFile).CBEffect
							dataRow("CBAngle") = RSWIN_DESC.AllGuruFiles(iFile).CBAngle
							dataRow("CBDataType") = RSWIN_DESC.AllGuruFiles(iFile).CBDataType
							dataRow("CalcMotorSize") = RSWIN_DESC.AllGuruFiles(iFile).CalcMotorSize
							dataRow("IncludeMotorSPV") = RSWIN_DESC.AllGuruFiles(iFile).IncludeMotorSPV
							dataRow("MotorSPV") = RSWIN_DESC.AllGuruFiles(iFile).MotorSPV
							dataRow("OilAPI") = RSWIN_DESC.AllGuruFiles(iFile).OilAPI
							dataRow("PlungerSize") = RSWIN_DESC.AllGuruFiles(iFile).PlungerSize
							dataRow("PowerMeterType") = RSWIN_DESC.AllGuruFiles(iFile).PowerMeterType
							dataRow("PumpDepth") = RuntimeHelpers.GetObjectValue(GURU_DB.EnDeCrypt(Conversions.ToString(RSWIN_DESC.AllGuruFiles(iFile).PumpDepth)))
							dataRow("PumpEfficiency") = RSWIN_DESC.AllGuruFiles(iFile).PumpEfficiency
							dataRow("PumpFillage") = RSWIN_DESC.AllGuruFiles(iFile).PumpFillage
							dataRow("PumpFriction") = RSWIN_DESC.AllGuruFiles(iFile).PumpFriction
							dataRow("PumpIntakePressure") = RSWIN_DESC.AllGuruFiles(iFile).PumpIntakePressure
							dataRow("PumpLoadAdj") = RSWIN_DESC.AllGuruFiles(iFile).PumpLoadAdj
							dataRow("PumpType") = RSWIN_DESC.AllGuruFiles(iFile).PumpType
							dataRow("SPM") = RSWIN_DESC.AllGuruFiles(iFile).SPM
							dataRow("CalcFriction") = RSWIN_DESC.AllGuruFiles(iFile).CalcFriction
							dataRow("DownstrokeFriction") = RSWIN_DESC.AllGuruFiles(iFile).DownstrokeFriction
							dataRow("UpstrokeFriction") = RSWIN_DESC.AllGuruFiles(iFile).UpstrokeFriction
							dataRow("XTimes") = RSWIN_DESC.AllGuruFiles(iFile).XTimes
							dataRow("Runtime") = RSWIN_DESC.AllGuruFiles(iFile).Runtime
							dataRow("StuffingBoxFriction") = RSWIN_DESC.AllGuruFiles(iFile).StuffingBoxFriction
							dataRow("TargetBFPD") = RuntimeHelpers.GetObjectValue(GURU_DB.EnDeCrypt(Conversions.ToString(RSWIN_DESC.AllGuruFiles(iFile).TargetBFPD)))
							dataRow("TubingAnchorDepth") = RuntimeHelpers.GetObjectValue(GURU_DB.EnDeCrypt(Conversions.ToString(RSWIN_DESC.AllGuruFiles(iFile).TubingAnchorDepth)))
							dataRow("TubingAnchored") = RSWIN_DESC.AllGuruFiles(iFile).TubingAnchored
							dataRow("TubingID") = RSWIN_DESC.AllGuruFiles(iFile).TubingID
							dataRow("TubingOD") = RSWIN_DESC.AllGuruFiles(iFile).TubingOD
							dataRow("TubingPressure") = RSWIN_DESC.AllGuruFiles(iFile).TubingPressure
							dataRow("WaterCut") = RSWIN_DESC.AllGuruFiles(iFile).WaterCut
							dataRow("WaterSPGR") = RSWIN_DESC.AllGuruFiles(iFile).WaterSPGR
							dataRow("RodStringType") = RSWIN_DESC.AllGuruFiles(iFile).RodStringType
							dataRow("giRodDesignStyle") = RSWIN_DESC.AllGuruFiles(iFile).giRodDesignStyle
							dataRow("RSFGIncludeSteel") = RSWIN_DESC.AllGuruFiles(iFile).RSFGIncludeSteel
							dataRow("RSGrade") = RSWIN_DESC.AllGuruFiles(iFile).RSGrade
							dataRow("RSMaxSize") = RSWIN_DESC.AllGuruFiles(iFile).RSMaxSize
							dataRow("RSMinSize") = RSWIN_DESC.AllGuruFiles(iFile).RSMinSize
							dataRow("RSFricCoef") = RSWIN_DESC.AllGuruFiles(iFile).RSFricCoef
							dataRow("RSIncludeSB") = RSWIN_DESC.AllGuruFiles(iFile).RSIncludeSB
							dataRow("SinkerBar_Grade") = RSWIN_DESC.AllGuruFiles(iFile).SinkerBar_Grade
							dataRow("SinkerBar_length") = RSWIN_DESC.AllGuruFiles(iFile).SinkerBar_length
							dataRow("SinkerBar_Diameter") = RSWIN_DESC.AllGuruFiles(iFile).SinkerBar_Diameter
							dataRow("RSFGGrade") = RSWIN_DESC.AllGuruFiles(iFile).RSFGGrade
							dataRow("RSExtraCost") = RSWIN_DESC.AllGuruFiles(iFile).RSExtraCost
							If Operators.CompareString(RSWIN_DESC.AllGuruFiles(iFile).RSExtraCostLabel, "", False) = 0 Then
								RSWIN_DESC.AllGuruFiles(iFile).RSExtraCostLabel = " "
							End If
							dataRow("RSExtraCostLabel") = RSWIN_DESC.AllGuruFiles(iFile).RSExtraCostLabel
							dataRow("ServiceFactor") = RSWIN_DESC.AllGuruFiles(iFile).ServiceFactor
							dataRow("PU_CrankRotation") = RSWIN_DESC.AllGuruFiles(iFile).PU_CrankRotation
							dataRow("PU_CrankHole") = RSWIN_DESC.AllGuruFiles(iFile).PU_CrankHole
							dataRow("Unbalance") = RSWIN_DESC.AllGuruFiles(iFile).Unbalance
							dataRow("Unit") = RuntimeHelpers.GetObjectValue(GURU_DB.EnDeCrypt(RSWIN_DESC.AllGuruFiles(iFile).Unit))
							dataRow("ID") = RuntimeHelpers.GetObjectValue(GURU_DB.EnDeCrypt(RSWIN_DESC.AllGuruFiles(iFile).ID))
							dataRow("DateAdded") = DateAndTime.Now.[Date]
							dataRow("Original") = RSWIN_DESC.AllGuruFiles(iFile).Original
						End If
						If RSWIN_DESC.bXRODAdmin Then
							' The following expression was wrapped in a checked-expression
							RSWIN_DESC.frn_AI_Admin_log = CShort(FileSystem.FreeFile())
							FileSystem.FileOpen(CInt(RSWIN_DESC.frn_AI_Admin_log), RSWIN_DESC.sAIAdminLog, OpenMode.Append, OpenAccess.[Default], OpenShare.[Default], -1)
							FileSystem.PrintLine(CInt(RSWIN_DESC.frn_AI_Admin_log), New Object() { Operators.ConcatenateObject(DateAndTime.Now.ToString() + "  : Template (" + RSWIN_DESC.AllGuruFiles(iFile).FileName + ") updated, ", Interaction.IIf(bByProgram, " by program.", " by administrator.")) })
							FileSystem.FileClose(New Integer() { CInt(RSWIN_DESC.frn_AI_Admin_log) })
						End If
						Dim oleDbCommandBuilder As OleDbCommandBuilder = New OleDbCommandBuilder(oleDbDataAdapter)
						Dim num As Integer = oleDbDataAdapter.Update(dataSet, text)
					End If
					If oleDbConnection.State = ConnectionState.Open Then
						oleDbConnection.Close()
					End If
				Catch ex As OleDbException
					MessageBox.Show(ex.Message, "OleDb Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				End Try
			Catch ex2 As Exception
			End Try
			Dim result As Object
			Return result
		End Function

		Public Sub LoadFile(iFile As Integer, ByRef file As RSWIN_DESC.GuruFileDataStructure, Optional ByRef bRet As Boolean = True)
			bRet = GURU_DB.ReadFiledata(iFile, file)
		End Sub

		Public Sub UpdateAllGuruFiles(File As RSWIN_DESC.GuruFileDataStructure)
			RSWIN_DESC.AllGuruFiles(Conversions.ToInteger(File.FileName)).FileName = File.FileName
		End Sub

		Public Sub LoadALLGuruFiledata(bQuiet As Boolean)
			Dim stringBuilder As StringBuilder = New StringBuilder()
			Dim asciiencoding As ASCIIEncoding = New ASCIIEncoding()
			RSWIN_DESC.AllGuruFiles = New RSWIN_DESC.GuruFileDataStructure(7500) {}
			Try
				RSWIN_DESC.iAddedTemplates = 0
				RSWIN_DESC.bGuruFileDataLoaded = False
				Dim sTemplateDBFileName As String = RSWIN_DESC.sTemplateDBFileName
				Dim guruDataBaseFileName As String = RSWIN_DESC.GuruDataBaseFileName
				FILEUTIL.LocateFile(sTemplateDBFileName, guruDataBaseFileName, 2S, False, False, False, False)
				RSWIN_DESC.GuruDataBaseFileName = guruDataBaseFileName
				Dim num As Integer = 0
				GURU_DB.myFile = New cGuruFileData()
				Dim filedataTable As DataTable = GURU_DB.myFile.FiledataTable
				Dim filedataDataAdapter As OleDbDataAdapter = GURU_DB.myFile.FiledataDataAdapter
				Dim now As DateTime = DateAndTime.Now
				Try
					For Each obj As Object In filedataTable.Rows
						Dim dataRow As DataRow = CType(obj, DataRow)
						Try
							Application.DoEvents()
							num += 1
							Dim num2 As Integer = num
							RSWIN_DESC.AllGuruFiles(num2).Initialize()
							If Not RSWIN_DESC.bXRODAdmin Then
								RSWIN_DESC.AllGuruFiles(num2).FileName = Conversions.ToString(GURU_DB.EnDeCrypt(Conversions.ToString(dataRow("FileName"))))
								RSWIN_DESC.AllGuruFiles(num2).WellName = Conversions.ToString(dataRow("WellName"))
								RSWIN_DESC.AllGuruFiles(num2).gbCalcPumpCondition = Conversions.ToBoolean(dataRow("gbCalcPumpCondition"))
								RSWIN_DESC.AllGuruFiles(num2).PumpCondition = Conversions.ToShort(dataRow("PumpCondition"))
								RSWIN_DESC.AllGuruFiles(num2).IrotEntered = Conversions.ToBoolean(dataRow("IrotEntered"))
								RSWIN_DESC.AllGuruFiles(num2).CalcPlungerSize = Conversions.ToBoolean(dataRow("CalcPlungerSize"))
								RSWIN_DESC.AllGuruFiles(num2).gbCalcPumpIntakePressure = Conversions.ToBoolean(dataRow("gbCalcPumpIntakePressure"))
								RSWIN_DESC.AllGuruFiles(num2).CasingPressure = Conversions.ToSingle(dataRow("CasingPressure"))
								RSWIN_DESC.AllGuruFiles(num2).CompressibilityIndex = Conversions.ToSingle(dataRow("CompressibilityIndex"))
								RSWIN_DESC.AllGuruFiles(num2).ElectricityCost = Conversions.ToSingle(dataRow("ElectricityCost"))
								RSWIN_DESC.AllGuruFiles(num2).FluidDamping = Conversions.ToSingle(dataRow("FluidDamping"))
								RSWIN_DESC.AllGuruFiles(num2).FluidLevel = Conversions.ToSingle(GURU_DB.EnDeCrypt(Conversions.ToString(dataRow("FluidLevel"))))
								RSWIN_DESC.AllGuruFiles(num2).gbIncludeBuoyancy = Conversions.ToBoolean(dataRow("gbIncludeBuoyancy"))
								RSWIN_DESC.AllGuruFiles(num2).IncludeFluidInertia = Conversions.ToShort(dataRow("IncludeFluidInertia"))
								RSWIN_DESC.AllGuruFiles(num2).Iart = Conversions.ToSingle(dataRow("Iart"))
								RSWIN_DESC.AllGuruFiles(num2).Irot = Conversions.ToSingle(dataRow("Irot"))
								RSWIN_DESC.AllGuruFiles(num2).UnknownM = Conversions.ToBoolean(dataRow("UnknownM"))
								RSWIN_DESC.AllGuruFiles(num2).M_Existing = Conversions.ToSingle(dataRow("M_Existing"))
								RSWIN_DESC.AllGuruFiles(num2).CBEffect = Conversions.ToSingle(dataRow("CBEffect"))
								RSWIN_DESC.AllGuruFiles(num2).CBAngle = Conversions.ToSingle(dataRow("CBAngle"))
								RSWIN_DESC.AllGuruFiles(num2).CBDataType = Conversions.ToShort(dataRow("CBDataType"))
								RSWIN_DESC.AllGuruFiles(num2).CalcMotorSize = Conversions.ToBoolean(dataRow("CalcMotorSize"))
								RSWIN_DESC.AllGuruFiles(num2).IncludeMotorSPV = Conversions.ToBoolean(dataRow("IncludeMotorSPV"))
								RSWIN_DESC.AllGuruFiles(num2).MotorSPV = Conversions.ToSingle(dataRow("MotorSPV"))
								RSWIN_DESC.AllGuruFiles(num2).OilAPI = Conversions.ToSingle(dataRow("OilAPI"))
								RSWIN_DESC.AllGuruFiles(num2).PlungerSize = Conversions.ToSingle(dataRow("PlungerSize"))
								RSWIN_DESC.AllGuruFiles(num2).PowerMeterType = Conversions.ToShort(dataRow("PowerMeterType"))
								RSWIN_DESC.AllGuruFiles(num2).PumpDepth = Conversions.ToSingle(GURU_DB.EnDeCrypt(Conversions.ToString(dataRow("PumpDepth"))))
								RSWIN_DESC.AllGuruFiles(num2).PumpEfficiency = Conversions.ToSingle(dataRow("PumpEfficiency"))
								RSWIN_DESC.AllGuruFiles(num2).PumpFillage = Conversions.ToSingle(dataRow("PumpFillage"))
								RSWIN_DESC.AllGuruFiles(num2).PumpFriction = Conversions.ToSingle(dataRow("PumpFriction"))
								RSWIN_DESC.AllGuruFiles(num2).PumpIntakePressure = Conversions.ToSingle(dataRow("PumpIntakePressure"))
								RSWIN_DESC.AllGuruFiles(num2).PumpLoadAdj = Conversions.ToSingle(dataRow("PumpLoadAdj"))
								RSWIN_DESC.AllGuruFiles(num2).PumpType = Conversions.ToShort(dataRow("PumpType"))
								RSWIN_DESC.AllGuruFiles(num2).SPM = Conversions.ToSingle(dataRow("SPM"))
								RSWIN_DESC.AllGuruFiles(num2).CalcFriction = Conversions.ToBoolean(dataRow("CalcFriction"))
								RSWIN_DESC.AllGuruFiles(num2).DownstrokeFriction = Conversions.ToSingle(dataRow("DownstrokeFriction"))
								RSWIN_DESC.AllGuruFiles(num2).UpstrokeFriction = Conversions.ToSingle(dataRow("UpstrokeFriction"))
								If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow("XTimes"))) Then
									RSWIN_DESC.AllGuruFiles(num2).XTimes = Conversions.ToSingle(dataRow("XTimes"))
								Else
									RSWIN_DESC.AllGuruFiles(num2).XTimes = 1F
								End If
								RSWIN_DESC.AllGuruFiles(num2).Runtime = Conversions.ToSingle(dataRow("Runtime"))
								RSWIN_DESC.AllGuruFiles(num2).StuffingBoxFriction = Conversions.ToSingle(dataRow("StuffingBoxFriction"))
								RSWIN_DESC.AllGuruFiles(num2).TargetBFPD = Conversions.ToSingle(GURU_DB.EnDeCrypt(Conversions.ToString(dataRow("TargetBFPD"))))
								RSWIN_DESC.AllGuruFiles(num2).TubingAnchorDepth = Conversions.ToSingle(GURU_DB.EnDeCrypt(Conversions.ToString(dataRow("TubingAnchorDepth"))))
								RSWIN_DESC.AllGuruFiles(num2).TubingAnchored = Conversions.ToShort(dataRow("TubingAnchored"))
								RSWIN_DESC.AllGuruFiles(num2).TubingID = Conversions.ToSingle(dataRow("TubingID"))
								RSWIN_DESC.AllGuruFiles(num2).TubingOD = Conversions.ToSingle(dataRow("TubingOD"))
								RSWIN_DESC.AllGuruFiles(num2).TubingPressure = Conversions.ToSingle(dataRow("TubingPressure"))
								RSWIN_DESC.AllGuruFiles(num2).WaterCut = Conversions.ToSingle(dataRow("WaterCut"))
								RSWIN_DESC.AllGuruFiles(num2).WaterSPGR = Conversions.ToSingle(dataRow("WaterSPGR"))
								RSWIN_DESC.AllGuruFiles(num2).RodStringType = Conversions.ToShort(dataRow("RodStringType"))
								RSWIN_DESC.AllGuruFiles(num2).giRodDesignStyle = Conversions.ToShort(dataRow("giRodDesignStyle"))
								RSWIN_DESC.AllGuruFiles(num2).RSFGIncludeSteel = Conversions.ToShort(dataRow("RSFGIncludeSteel"))
								RSWIN_DESC.AllGuruFiles(num2).RSGrade = Conversions.ToShort(dataRow("RSGrade"))
								RSWIN_DESC.AllGuruFiles(num2).RSMaxSize = Conversions.ToSingle(dataRow("RSMaxSize"))
								RSWIN_DESC.AllGuruFiles(num2).RSMinSize = Conversions.ToSingle(dataRow("RSMinSize"))
								RSWIN_DESC.AllGuruFiles(num2).RSFricCoef = Conversions.ToSingle(dataRow("RSFricCoef"))
								RSWIN_DESC.AllGuruFiles(num2).RSIncludeSB = Conversions.ToShort(dataRow("RSIncludeSB"))
								RSWIN_DESC.AllGuruFiles(num2).SinkerBar_Grade = Conversions.ToShort(dataRow("SinkerBar_Grade"))
								RSWIN_DESC.AllGuruFiles(num2).SinkerBar_length = Conversions.ToSingle(dataRow("SinkerBar_length"))
								RSWIN_DESC.AllGuruFiles(num2).SinkerBar_Diameter = Conversions.ToSingle(dataRow("SinkerBar_Diameter"))
								RSWIN_DESC.AllGuruFiles(num2).RSFGGrade = Conversions.ToShort(dataRow("RSFGGrade"))
								RSWIN_DESC.AllGuruFiles(num2).RSExtraCost = Conversions.ToSingle(dataRow("RSExtraCost"))
								If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow("RSExtraCostLabel"))) Then
									RSWIN_DESC.AllGuruFiles(num2).RSExtraCostLabel = Conversions.ToString(dataRow("RSExtraCostLabel"))
								Else
									RSWIN_DESC.AllGuruFiles(num2).RSExtraCostLabel = ""
								End If
								RSWIN_DESC.AllGuruFiles(num2).ServiceFactor = Conversions.ToSingle(dataRow("ServiceFactor"))
								RSWIN_DESC.AllGuruFiles(num2).PU_CrankRotation = Conversions.ToShort(dataRow("PU_CrankRotation"))
								RSWIN_DESC.AllGuruFiles(num2).PU_CrankHole = Conversions.ToShort(dataRow("PU_CrankHole"))
								RSWIN_DESC.AllGuruFiles(num2).Unbalance = Conversions.ToSingle(dataRow("Unbalance"))
								RSWIN_DESC.AllGuruFiles(num2).Unit = Conversions.ToString(GURU_DB.EnDeCrypt(Conversions.ToString(dataRow("Unit"))))
								RSWIN_DESC.AllGuruFiles(num2).ID = Conversions.ToString(GURU_DB.EnDeCrypt(Conversions.ToString(dataRow("ID"))))
								RSWIN_DESC.AllGuruFiles(num2).DateAdded = Conversions.ToDate(dataRow("DateAdded"))
								RSWIN_DESC.AllGuruFiles(num2).Original = Conversions.ToShort(dataRow("Original"))
							Else
								Try
									RSWIN_DESC.AllGuruFiles(num2).FileName = Conversions.ToString(dataRow("FileName"))
								Catch ex As Exception
								End Try
								Try
									RSWIN_DESC.AllGuruFiles(num2).WellName = Conversions.ToString(dataRow("WellName"))
								Catch ex2 As Exception
								End Try
								Try
									RSWIN_DESC.AllGuruFiles(num2).gbCalcPumpCondition = Conversions.ToBoolean(dataRow("gbCalcPumpCondition"))
								Catch ex3 As Exception
								End Try
								Try
									RSWIN_DESC.AllGuruFiles(num2).PumpCondition = Conversions.ToShort(dataRow("PumpCondition"))
								Catch ex4 As Exception
								End Try
								Try
									RSWIN_DESC.AllGuruFiles(num2).IrotEntered = Conversions.ToBoolean(dataRow("IrotEntered"))
								Catch ex5 As Exception
								End Try
								Try
									RSWIN_DESC.AllGuruFiles(num2).CalcPlungerSize = Conversions.ToBoolean(dataRow("CalcPlungerSize"))
								Catch ex6 As Exception
								End Try
								Try
									RSWIN_DESC.AllGuruFiles(num2).gbCalcPumpIntakePressure = Conversions.ToBoolean(dataRow("gbCalcPumpIntakePressure"))
								Catch ex7 As Exception
								End Try
								Try
									RSWIN_DESC.AllGuruFiles(num2).CasingPressure = Conversions.ToSingle(dataRow("CasingPressure"))
								Catch ex8 As Exception
								End Try
								Try
									RSWIN_DESC.AllGuruFiles(num2).CompressibilityIndex = Conversions.ToSingle(dataRow("CompressibilityIndex"))
								Catch ex9 As Exception
								End Try
								Try
									RSWIN_DESC.AllGuruFiles(num2).ElectricityCost = Conversions.ToSingle(dataRow("ElectricityCost"))
								Catch ex10 As Exception
								End Try
								Try
									RSWIN_DESC.AllGuruFiles(num2).FluidDamping = Conversions.ToSingle(dataRow("FluidDamping"))
								Catch ex11 As Exception
								End Try
								Try
									RSWIN_DESC.AllGuruFiles(num2).FluidLevel = Conversions.ToSingle(dataRow("FluidLevel"))
								Catch ex12 As Exception
								End Try
								Try
									RSWIN_DESC.AllGuruFiles(num2).gbIncludeBuoyancy = Conversions.ToBoolean(dataRow("gbIncludeBuoyancy"))
								Catch ex13 As Exception
								End Try
								Try
									RSWIN_DESC.AllGuruFiles(num2).IncludeFluidInertia = Conversions.ToShort(dataRow("IncludeFluidInertia"))
								Catch ex14 As Exception
								End Try
								Try
									RSWIN_DESC.AllGuruFiles(num2).Iart = Conversions.ToSingle(dataRow("Iart"))
								Catch ex15 As Exception
								End Try
								Try
									RSWIN_DESC.AllGuruFiles(num2).Irot = Conversions.ToSingle(dataRow("Irot"))
								Catch ex16 As Exception
								End Try
								Try
									RSWIN_DESC.AllGuruFiles(num2).UnknownM = Conversions.ToBoolean(dataRow("UnknownM"))
								Catch ex17 As Exception
								End Try
								Try
									RSWIN_DESC.AllGuruFiles(num2).M_Existing = Conversions.ToSingle(dataRow("M_Existing"))
								Catch ex18 As Exception
								End Try
								Try
									RSWIN_DESC.AllGuruFiles(num2).CBEffect = Conversions.ToSingle(dataRow("CBEffect"))
								Catch ex19 As Exception
								End Try
								Try
									RSWIN_DESC.AllGuruFiles(num2).CBAngle = Conversions.ToSingle(dataRow("CBAngle"))
								Catch ex20 As Exception
								End Try
								Try
									RSWIN_DESC.AllGuruFiles(num2).CBDataType = Conversions.ToShort(dataRow("CBDataType"))
								Catch ex21 As Exception
								End Try
								Try
									RSWIN_DESC.AllGuruFiles(num2).CalcMotorSize = Conversions.ToBoolean(dataRow("CalcMotorSize"))
								Catch ex22 As Exception
								End Try
								Try
									RSWIN_DESC.AllGuruFiles(num2).IncludeMotorSPV = Conversions.ToBoolean(dataRow("IncludeMotorSPV"))
								Catch ex23 As Exception
								End Try
								Try
									RSWIN_DESC.AllGuruFiles(num2).MotorSPV = Conversions.ToSingle(dataRow("MotorSPV"))
								Catch ex24 As Exception
								End Try
								Try
									RSWIN_DESC.AllGuruFiles(num2).OilAPI = Conversions.ToSingle(dataRow("OilAPI"))
								Catch ex25 As Exception
								End Try
								Try
									RSWIN_DESC.AllGuruFiles(num2).PlungerSize = Conversions.ToSingle(dataRow("PlungerSize"))
								Catch ex26 As Exception
								End Try
								Try
									RSWIN_DESC.AllGuruFiles(num2).PowerMeterType = Conversions.ToShort(dataRow("PowerMeterType"))
								Catch ex27 As Exception
								End Try
								Try
									RSWIN_DESC.AllGuruFiles(num2).PumpDepth = Conversions.ToSingle(dataRow("PumpDepth"))
								Catch ex28 As Exception
								End Try
								Try
									RSWIN_DESC.AllGuruFiles(num2).PumpEfficiency = Conversions.ToSingle(dataRow("PumpEfficiency"))
								Catch ex29 As Exception
								End Try
								Try
									RSWIN_DESC.AllGuruFiles(num2).PumpFillage = Conversions.ToSingle(dataRow("PumpFillage"))
								Catch ex30 As Exception
								End Try
								Try
									RSWIN_DESC.AllGuruFiles(num2).PumpFriction = Conversions.ToSingle(dataRow("PumpFriction"))
								Catch ex31 As Exception
								End Try
								Try
									RSWIN_DESC.AllGuruFiles(num2).PumpIntakePressure = Conversions.ToSingle(dataRow("PumpIntakePressure"))
								Catch ex32 As Exception
								End Try
								Try
									RSWIN_DESC.AllGuruFiles(num2).PumpLoadAdj = Conversions.ToSingle(dataRow("PumpLoadAdj"))
								Catch ex33 As Exception
								End Try
								Try
									RSWIN_DESC.AllGuruFiles(num2).PumpType = Conversions.ToShort(dataRow("PumpType"))
								Catch ex34 As Exception
								End Try
								Try
									RSWIN_DESC.AllGuruFiles(num2).SPM = Conversions.ToSingle(dataRow("SPM"))
								Catch ex35 As Exception
								End Try
								Try
									RSWIN_DESC.AllGuruFiles(num2).CalcFriction = Conversions.ToBoolean(dataRow("CalcFriction"))
								Catch ex36 As Exception
								End Try
								Try
									RSWIN_DESC.AllGuruFiles(num2).DownstrokeFriction = Conversions.ToSingle(dataRow("DownstrokeFriction"))
								Catch ex37 As Exception
								End Try
								Try
									RSWIN_DESC.AllGuruFiles(num2).UpstrokeFriction = Conversions.ToSingle(dataRow("UpstrokeFriction"))
								Catch ex38 As Exception
								End Try
								If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow("XTimes"))) Then
									Try
										RSWIN_DESC.AllGuruFiles(num2).XTimes = Conversions.ToSingle(dataRow("XTimes"))
										GoTo IL_12CB
									Catch ex39 As Exception
										GoTo IL_12CB
									End Try
								End If
								RSWIN_DESC.AllGuruFiles(num2).XTimes = 1F
								Try
									IL_12CB:
									RSWIN_DESC.AllGuruFiles(num2).Runtime = Conversions.ToSingle(dataRow("Runtime"))
								Catch ex40 As Exception
								End Try
								Try
									RSWIN_DESC.AllGuruFiles(num2).StuffingBoxFriction = Conversions.ToSingle(dataRow("StuffingBoxFriction"))
								Catch ex41 As Exception
								End Try
								Try
									RSWIN_DESC.AllGuruFiles(num2).TargetBFPD = Conversions.ToSingle(dataRow("TargetBFPD"))
								Catch ex42 As Exception
								End Try
								Try
									RSWIN_DESC.AllGuruFiles(num2).TubingAnchorDepth = Conversions.ToSingle(dataRow("TubingAnchorDepth"))
								Catch ex43 As Exception
								End Try
								Try
									RSWIN_DESC.AllGuruFiles(num2).TubingAnchored = Conversions.ToShort(dataRow("TubingAnchored"))
								Catch ex44 As Exception
								End Try
								Try
									RSWIN_DESC.AllGuruFiles(num2).TubingID = Conversions.ToSingle(dataRow("TubingID"))
								Catch ex45 As Exception
								End Try
								Try
									RSWIN_DESC.AllGuruFiles(num2).TubingOD = Conversions.ToSingle(dataRow("TubingOD"))
								Catch ex46 As Exception
								End Try
								Try
									RSWIN_DESC.AllGuruFiles(num2).TubingPressure = Conversions.ToSingle(dataRow("TubingPressure"))
								Catch ex47 As Exception
								End Try
								Try
									RSWIN_DESC.AllGuruFiles(num2).WaterCut = Conversions.ToSingle(dataRow("WaterCut"))
								Catch ex48 As Exception
								End Try
								Try
									RSWIN_DESC.AllGuruFiles(num2).WaterSPGR = Conversions.ToSingle(dataRow("WaterSPGR"))
								Catch ex49 As Exception
								End Try
								Try
									RSWIN_DESC.AllGuruFiles(num2).RodStringType = Conversions.ToShort(dataRow("RodStringType"))
								Catch ex50 As Exception
								End Try
								Try
									RSWIN_DESC.AllGuruFiles(num2).giRodDesignStyle = Conversions.ToShort(dataRow("giRodDesignStyle"))
								Catch ex51 As Exception
								End Try
								Try
									RSWIN_DESC.AllGuruFiles(num2).RSFGIncludeSteel = Conversions.ToShort(dataRow("RSFGIncludeSteel"))
								Catch ex52 As Exception
								End Try
								Try
									RSWIN_DESC.AllGuruFiles(num2).RSGrade = Conversions.ToShort(dataRow("RSGrade"))
								Catch ex53 As Exception
								End Try
								Try
									RSWIN_DESC.AllGuruFiles(num2).RSMaxSize = Conversions.ToSingle(dataRow("RSMaxSize"))
								Catch ex54 As Exception
								End Try
								Try
									RSWIN_DESC.AllGuruFiles(num2).RSMinSize = Conversions.ToSingle(dataRow("RSMinSize"))
								Catch ex55 As Exception
								End Try
								Try
									RSWIN_DESC.AllGuruFiles(num2).RSFricCoef = Conversions.ToSingle(dataRow("RSFricCoef"))
								Catch ex56 As Exception
								End Try
								Try
									RSWIN_DESC.AllGuruFiles(num2).RSIncludeSB = Conversions.ToShort(dataRow("RSIncludeSB"))
								Catch ex57 As Exception
								End Try
								Try
									RSWIN_DESC.AllGuruFiles(num2).SinkerBar_Grade = Conversions.ToShort(dataRow("SinkerBar_Grade"))
								Catch ex58 As Exception
								End Try
								Try
									RSWIN_DESC.AllGuruFiles(num2).SinkerBar_length = Conversions.ToSingle(dataRow("SinkerBar_length"))
								Catch ex59 As Exception
								End Try
								Try
									RSWIN_DESC.AllGuruFiles(num2).SinkerBar_Diameter = Conversions.ToSingle(dataRow("SinkerBar_Diameter"))
								Catch ex60 As Exception
								End Try
								Try
									RSWIN_DESC.AllGuruFiles(num2).RSFGGrade = Conversions.ToShort(dataRow("RSFGGrade"))
								Catch ex61 As Exception
								End Try
								Try
									RSWIN_DESC.AllGuruFiles(num2).RSExtraCost = Conversions.ToSingle(dataRow("RSExtraCost"))
								Catch ex62 As Exception
								End Try
								Try
									If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow("RSExtraCostLabel"))) Then
										RSWIN_DESC.AllGuruFiles(num2).RSExtraCostLabel = Conversions.ToString(dataRow("RSExtraCostLabel"))
									Else
										RSWIN_DESC.AllGuruFiles(num2).RSExtraCostLabel = ""
									End If
								Catch ex63 As Exception
								End Try
								Try
									RSWIN_DESC.AllGuruFiles(num2).ServiceFactor = Conversions.ToSingle(dataRow("ServiceFactor"))
								Catch ex64 As Exception
								End Try
								Try
									RSWIN_DESC.AllGuruFiles(num2).PU_CrankRotation = Conversions.ToShort(dataRow("PU_CrankRotation"))
								Catch ex65 As Exception
								End Try
								Try
									RSWIN_DESC.AllGuruFiles(num2).PU_CrankHole = Conversions.ToShort(dataRow("PU_CrankHole"))
								Catch ex66 As Exception
								End Try
								Try
									RSWIN_DESC.AllGuruFiles(num2).Unbalance = Conversions.ToSingle(dataRow("Unbalance"))
								Catch ex67 As Exception
								End Try
								Try
									RSWIN_DESC.AllGuruFiles(num2).Unit = Conversions.ToString(dataRow("Unit"))
								Catch ex68 As Exception
								End Try
								Try
									RSWIN_DESC.AllGuruFiles(num2).ID = Conversions.ToString(dataRow("ID"))
								Catch ex69 As Exception
								End Try
								Try
									RSWIN_DESC.AllGuruFiles(num2).DateAdded = Conversions.ToDate(dataRow("DateAdded"))
								Catch ex70 As Exception
								End Try
								Try
									RSWIN_DESC.AllGuruFiles(num2).Original = Conversions.ToShort(dataRow("Original"))
								Catch ex71 As Exception
								End Try
							End If
							If RSWIN_DESC.AllGuruFiles(num2).Original = 0S Then
								RSWIN_DESC.iAddedTemplates += 1
							End If
						Catch ex72 As Exception
						End Try
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				RSWIN_DESC.iGuruFileCount = num
				RSWIN_DESC.bGuruFileDataLoaded = True
				Dim seconds As Integer = DateAndTime.Now.Subtract(now).Seconds
				Try
					GURU_DB.DBClose()
					If RSWIN_DESC.bXRODAdmin Then
						Util.Message("Total templates: " + Conversions.ToString(RSWIN_DESC.iGuruFileCount) + " , Number Added: " + Conversions.ToString(RSWIN_DESC.iAddedTemplates))
					End If
				Catch ex73 As Exception
				End Try
			Catch ex74 As Exception
				If Not bQuiet Then
					MessageBox.Show("Error in load:" + ex74.Message)
				End If
			End Try
		End Sub

		Public Sub SortGuruFiledata()
			' The following expression was wrapped in a checked-statement
			Try
				Dim array As RSWIN_DESC.GuruFileDataStructure() = New RSWIN_DESC.GuruFileDataStructure(7500) {}
				Dim array2 As String() = New String(11) {}
				Dim num As Integer = 0
				Do
					array2(num) = RSWIN_DESC.sExpertFilePrefixes(num)
					num += 1
				Loop While num <= 11
				Dim flag As Boolean = False
				While Not flag
					flag = True
					Dim i As Integer = 11
					Do
						If Operators.CompareString(array2(i), array2(i - 1), False) < 0 Then
							Dim text As String = array2(i)
							array2(i) = array2(i - 1)
							array2(i - 1) = text
							flag = False
						End If
						i += -1
					Loop While i >= 1
				End While
				Dim num2 As Integer = 0
				num = 0
				Do
					Dim obj As Object = 0
					Dim num3 As Integer = 1
					Dim iGuruFileCount As Integer = RSWIN_DESC.iGuruFileCount
					For i As Integer = num3 To iGuruFileCount
						If Strings.InStr(RSWIN_DESC.AllGuruFiles(i).FileName.ToLower(), RSWIN_DESC.sExpertFilePrefixes(num).ToLower(), CompareMethod.Binary) > 0 Then
							obj = Operators.AddObject(obj, 1)
							num2 += 1
							array(num2).Initialize()
							array(num2) = RSWIN_DESC.AllGuruFiles(i)
						End If
					Next
					num += 1
				Loop While num <= 11
				Dim num4 As Integer = 0
				Do
					flag = True
					num4 += 1
					Application.DoEvents()
					For i As Integer = RSWIN_DESC.iGuruFileCount To 2 Step -1
						Application.DoEvents()
						If Operators.CompareString(array(i - 1).FileName, array(i).FileName, False) > 0 Then
							Dim guruFileDataStructure As RSWIN_DESC.GuruFileDataStructure
							guruFileDataStructure.Initialize()
							guruFileDataStructure = array(i)
							array(i) = array(i - 1)
							array(i - 1) = guruFileDataStructure
							flag = False
						End If
					Next
				Loop While Not flag
				Dim num5 As Integer = 1
				Dim num6 As Integer = num2
				For i As Integer = num5 To num6
					RSWIN_DESC.AllGuruFiles(i) = array(i)
				Next
			Catch ex As Exception
			End Try
		End Sub

		Public Function ReadFiledata(iFile As Integer, ByRef File As RSWIN_DESC.GuruFileDataStructure) As Boolean
			If iFile < 0 Then
				Return False
			End If
			File = RSWIN_DESC.AllGuruFiles(iFile)
			Return Not(Operators.CompareString(File.FileName, "", False) = 0 Or Information.IsDBNull(File.FileName))
		End Function

		Public Function StringToByte(aString As String) As Byte()
			' The following expression was wrapped in a checked-statement
			Dim array As Byte() = New Byte(aString.Length + 1 - 1) {}
			Dim num As Integer = 0
			Dim num2 As Integer = aString.Length - 1
			For i As Integer = num To num2
				Try
					Dim [string] As Char = Conversions.ToChar(aString.Substring(i, 1))
					array(i) = CByte(Strings.Asc([string]))
				Catch ex As Exception
					MessageBox.Show(ex.Message)
				End Try
			Next
			Return array
		End Function

		Public Sub CopyRST2Filedata(ByRef file As RSWIN_DESC.GuruFileDataStructure, iOriginal As Short)
			Try
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				file.gbCalcPumpCondition = rst.gbCalcPumpCondition
				file.PumpCondition = rst.PumpCondition
				file.IrotEntered = (rst.IrotEntered <> 0S)
				file.CalcPlungerSize = (rst.CalcPlungerSize <> 0S)
				file.gbCalcPumpIntakePressure = rst.gbCalcPumpIntakePressure
				file.CasingPressure = rst.CasingPressure
				file.WellName = rst.WellName
				file.CompressibilityIndex = rst.CompressibilityIndex
				file.ElectricityCost = rst.ElectricityCost
				file.FluidDamping = rst.FluidDamping
				file.FluidLevel = rst.FluidLevel
				file.gbIncludeBuoyancy = rst.gbIncludeBuoyancy
				file.IncludeFluidInertia = rst.IncludeFluidInertia
				file.Iart = rst.Iart
				file.Irot = rst.Irot
				file.UnknownM = rst.UnknownM
				file.M_Existing = rst.get_M(2)
				file.CBEffect = rst.CBEffect
				file.CBAngle = rst.CBAngle
				file.CBDataType = rst.CBDataType
				file.CalcMotorSize = (rst.CalcMotorSize <> 0S)
				file.IncludeMotorSPV = (rst.CalcMotorSPV <> 0S)
				file.MotorSPV = rst.MotorSPV
				file.OilAPI = rst.OilAPI
				file.PlungerSize = rst.PlungerSize
				file.PowerMeterType = rst.PowerMeterType
				file.PumpDepth = rst.PumpDepth
				file.PumpEfficiency = rst.PumpEfficiency
				file.PumpFillage = rst.PumpFillage
				file.PumpFriction = rst.PumpFriction
				file.PumpIntakePressure = rst.PumpIntakePressure
				file.PumpLoadAdj = rst.PumpLoadAdj
				file.PumpType = rst.PumpType
				file.SPM = rst.SPM
				file.CalcFriction = (rst.CalcFriction <> 0S)
				file.DownstrokeFriction = rst.DownstrokeFriction
				file.UpstrokeFriction = rst.UpstrokeFriction
				file.Runtime = rst.Runtime
				file.StuffingBoxFriction = rst.StuffingBoxFriction
				file.TargetBFPD = rst.TargetBFPD
				file.TubingAnchorDepth = rst.TubingAnchorDepth
				file.TubingAnchored = rst.TubingAnchored
				file.TubingID = rst.TubingID
				file.TubingOD = rst.TubingOD
				file.TubingPressure = rst.TubingPressure
				file.WaterCut = rst.WaterCut
				file.WaterSPGR = rst.WaterSPGR
				file.RodStringType = rst.RodStringType
				file.giRodDesignStyle = rst.giRodDesignStyle
				file.RSFGIncludeSteel = rst.RSFGIncludeSteel
				file.RSGrade = rst.RSGrade
				file.RSMaxSize = rst.RSMaxSize
				file.RSMinSize = rst.RSMinSize
				file.RSFricCoef = rst.RSFricCoef
				file.RSIncludeSB = rst.RSIncludeSB
				file.SinkerBar_Grade = rst.SinkerBar.Grade
				file.SinkerBar_length = rst.SinkerBar.length
				file.SinkerBar_Diameter = rst.SinkerBar.Diameter
				file.RSFGGrade = rst.RSFGGrade
				file.RSExtraCost = rst.RSExtraCost
				file.RSExtraCostLabel = rst.RSExtraCostLabel
				file.SlideFricCoeff = rst.SlideFricCoeff
				file.ServiceFactor = rst.ServiceFactor
				file.PU_CrankRotation = rst.PU.CrankRotation
				file.PU_CrankHole = rst.PU.CrankHole
				file.Unbalance = rst.PU.Unbalance
				Dim text As String
				Dim num As Integer
				PUDATA1.ParseUnitID(rst.UnitID, text, num)
				file.Unit = text.Trim()
				file.ID = num.ToString().Trim()
				file.Original = iOriginal
				If iOriginal <> 0S Then
					file.XTimes = 1F
				Else
					file.XTimes = RSWIN_DESC.SETUP_TimesAvgRodTBGFricCoeff
				End If
			Catch ex As Exception
			End Try
		End Sub

		Public Sub CopyGuruFiledata2RSTObj(iFile As Integer, Optional bNew As Boolean = False)
			Try
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				rst.SetClassDefaults(bNew)
				rst.Inputfile = RSWIN_DESC.AllGuruFiles(iFile).FileName + ".rsvx"
				rst.WellName = RSWIN_DESC.AllGuruFiles(iFile).WellName
				rst.gbCalcPumpCondition = RSWIN_DESC.AllGuruFiles(iFile).gbCalcPumpCondition
				rst.PumpCondition = RSWIN_DESC.AllGuruFiles(iFile).PumpCondition
				rst.IrotEntered = If((-If((RSWIN_DESC.AllGuruFiles(iFile).IrotEntered > False), 1S, 0S)), 1S, 0S)
				rst.CalcPlungerSize = If((-If((RSWIN_DESC.AllGuruFiles(iFile).CalcPlungerSize > False), 1S, 0S)), 1S, 0S)
				rst.gbCalcPumpIntakePressure = RSWIN_DESC.AllGuruFiles(iFile).gbCalcPumpIntakePressure
				rst.CasingPressure = RSWIN_DESC.AllGuruFiles(iFile).CasingPressure
				rst.CompressibilityIndex = RSWIN_DESC.AllGuruFiles(iFile).CompressibilityIndex
				rst.ElectricityCost = RSWIN_DESC.AllGuruFiles(iFile).ElectricityCost
				rst.FluidDamping = RSWIN_DESC.AllGuruFiles(iFile).FluidDamping
				rst.FluidLevel = RSWIN_DESC.AllGuruFiles(iFile).FluidLevel
				rst.gbIncludeBuoyancy = RSWIN_DESC.AllGuruFiles(iFile).gbIncludeBuoyancy
				rst.IncludeFluidInertia = RSWIN_DESC.AllGuruFiles(iFile).IncludeFluidInertia
				rst.Iart = RSWIN_DESC.AllGuruFiles(iFile).Iart
				rst.Irot = RSWIN_DESC.AllGuruFiles(iFile).Irot
				rst.UnknownM = RSWIN_DESC.AllGuruFiles(iFile).UnknownM
				rst.set_M(2, RSWIN_DESC.AllGuruFiles(iFile).M_Existing)
				rst.CBEffect = RSWIN_DESC.AllGuruFiles(iFile).CBEffect
				rst.CBAngle = RSWIN_DESC.AllGuruFiles(iFile).CBAngle
				rst.CBDataType = RSWIN_DESC.AllGuruFiles(iFile).CBDataType
				rst.CalcMotorSize = If((-If((RSWIN_DESC.AllGuruFiles(iFile).CalcMotorSize > False), 1S, 0S)), 1S, 0S)
				rst.CalcMotorSPV = If((-If((RSWIN_DESC.AllGuruFiles(iFile).IncludeMotorSPV > False), 1S, 0S)), 1S, 0S)
				rst.MotorSPV = RSWIN_DESC.AllGuruFiles(iFile).MotorSPV
				rst.OilAPI = RSWIN_DESC.AllGuruFiles(iFile).OilAPI
				rst.PlungerSize = RSWIN_DESC.AllGuruFiles(iFile).PlungerSize
				rst.PowerMeterType = RSWIN_DESC.AllGuruFiles(iFile).PowerMeterType
				rst.PumpDepth = RSWIN_DESC.AllGuruFiles(iFile).PumpDepth
				rst.PumpEfficiency = RSWIN_DESC.AllGuruFiles(iFile).PumpEfficiency
				rst.PumpFillage = RSWIN_DESC.AllGuruFiles(iFile).PumpFillage
				rst.PumpFriction = RSWIN_DESC.AllGuruFiles(iFile).PumpFriction
				rst.PumpIntakePressure = RSWIN_DESC.AllGuruFiles(iFile).PumpIntakePressure
				rst.PumpLoadAdj = RSWIN_DESC.AllGuruFiles(iFile).PumpLoadAdj
				rst.PumpType = RSWIN_DESC.AllGuruFiles(iFile).PumpType
				rst.SPM = RSWIN_DESC.AllGuruFiles(iFile).SPM
				rst.CalcFriction = If((-If((RSWIN_DESC.AllGuruFiles(iFile).CalcFriction > False), 1S, 0S)), 1S, 0S)
				rst.DownstrokeFriction = RSWIN_DESC.AllGuruFiles(iFile).DownstrokeFriction
				rst.UpstrokeFriction = RSWIN_DESC.AllGuruFiles(iFile).UpstrokeFriction
				rst.Runtime = RSWIN_DESC.AllGuruFiles(iFile).Runtime
				rst.StuffingBoxFriction = RSWIN_DESC.AllGuruFiles(iFile).StuffingBoxFriction
				rst.TargetBFPD = RSWIN_DESC.AllGuruFiles(iFile).TargetBFPD
				rst.TubingAnchorDepth = RSWIN_DESC.AllGuruFiles(iFile).TubingAnchorDepth
				rst.TubingAnchored = RSWIN_DESC.AllGuruFiles(iFile).TubingAnchored
				rst.TubingID = RSWIN_DESC.AllGuruFiles(iFile).TubingID
				rst.TubingOD = RSWIN_DESC.AllGuruFiles(iFile).TubingOD
				rst.TubingPressure = RSWIN_DESC.AllGuruFiles(iFile).TubingPressure
				rst.WaterCut = RSWIN_DESC.AllGuruFiles(iFile).WaterCut
				rst.WaterSPGR = RSWIN_DESC.AllGuruFiles(iFile).WaterSPGR
				rst.RodStringType = RSWIN_DESC.AllGuruFiles(iFile).RodStringType
				rst.giRodDesignStyle = RSWIN_DESC.AllGuruFiles(iFile).giRodDesignStyle
				rst.RSFGIncludeSteel = RSWIN_DESC.AllGuruFiles(iFile).RSFGIncludeSteel
				rst.RSGrade = RSWIN_DESC.AllGuruFiles(iFile).RSGrade
				rst.RSMaxSize = RSWIN_DESC.AllGuruFiles(iFile).RSMaxSize
				rst.RSMinSize = RSWIN_DESC.AllGuruFiles(iFile).RSMinSize
				rst.RSFricCoef = RSWIN_DESC.AllGuruFiles(iFile).RSFricCoef
				rst.RSIncludeSB = RSWIN_DESC.AllGuruFiles(iFile).RSIncludeSB
				Dim sinkerBar As RSWIN_DESC.RodSection
				sinkerBar.Initialize()
				sinkerBar.Grade = RSWIN_DESC.AllGuruFiles(iFile).SinkerBar_Grade
				sinkerBar.length = RSWIN_DESC.AllGuruFiles(iFile).SinkerBar_length
				sinkerBar.Diameter = RSWIN_DESC.AllGuruFiles(iFile).SinkerBar_Diameter
				If(RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru) AndAlso (Not RSWIN_DESC.SETUP_UseXRODVTubingSizes And RSWIN_DESC.MaxTubingSizeOD <> 0F) Then
					If Not RSWIN_DESC.SETUP_FixTubingSize And rst.TubingOD > RSWIN_DESC.MaxTubingSizeOD Then
						rst.TubingOD = RSWIN_DESC.MaxTubingSizeOD
						rst.TubingID = RODUTIL.GetMaxTubingSizeID(rst.TubingOD)
					ElseIf RSWIN_DESC.SETUP_FixTubingSize And rst.TubingOD <> RSWIN_DESC.MaxTubingSizeOD Then
						rst.TubingOD = RSWIN_DESC.MaxTubingSizeOD
						rst.TubingID = RODUTIL.GetMaxTubingSizeID(rst.TubingOD)
					End If
					Dim maxCasingSize As Single = RSWIN_DESC.MaxCasingSize
					Dim maxTubingSizeOD As Single = RSWIN_DESC.MaxTubingSizeOD
					Dim num As Single
					Dim num2 As Single
					Dim num3 As Single
					RODUTIL.GetSizeFromCasingSize(maxCasingSize, maxTubingSizeOD, num, num2, num3, False)
					RSWIN_DESC.MaxTubingSizeOD = maxTubingSizeOD
					If rst.RSMaxSize > num Then
						rst.RSMaxSize = num
					End If
					If rst.RSMinSize > num Then
						rst.RSMinSize = num
					End If
					If rst.PlungerSize > num2 Then
						rst.PlungerSize = num2
					End If
					If sinkerBar.Diameter > num3 Then
						sinkerBar.Diameter = num3
					End If
				End If
				rst.SinkerBar = sinkerBar
				rst.RSFGGrade = RSWIN_DESC.AllGuruFiles(iFile).RSFGGrade
				rst.RSExtraCost = RSWIN_DESC.AllGuruFiles(iFile).RSExtraCost
				rst.RSExtraCostLabel = RSWIN_DESC.AllGuruFiles(iFile).RSExtraCostLabel.Trim()
				rst.ServiceFactor = RSWIN_DESC.AllGuruFiles(iFile).ServiceFactor
				Dim pu_CrankRotation As Short = RSWIN_DESC.AllGuruFiles(iFile).PU_CrankRotation
				Dim pu_CrankHole As Short = RSWIN_DESC.AllGuruFiles(iFile).PU_CrankHole
				Dim unbalance As Single = RSWIN_DESC.AllGuruFiles(iFile).Unbalance
				rst.IDEntered = -1S
				Dim text As String = RSWIN_DESC.AllGuruFiles(iFile).Unit + RSWIN_DESC.AllGuruFiles(iFile).ID
				rst.UnitID = text.PadRight(10, " "c)
				Dim pu As RSWIN_DESC.PUDataRec
				PUDATA1.ReadPUData(rst.UnitID, pu, False, True)
				pu.CrankHole = pu_CrankHole
				pu.CrankRotation = pu_CrankRotation
				pu.R = pu.CrankRadii(CInt((pu.CrankHole - 1S)))
				If pu.Unbalance <> unbalance Then
					pu.Unbalance = unbalance
				End If
				kinemat.Kinconst(pu)
				kinemat.Unitstroke(pu)
				RSWIN_DESC.rst.PU = pu
				rst.FluidLevelEntered = True
				rst.CalcFriction = -1S
				rst.gbCalcSlideFricCoeff = True
				rst.CalcMotorSize = -1S
				rst.SPMEntered = 0S
				rst.gbCalcTargetBFPD = False
				rst.gbUseIPR = False
				rst.gbCalcFluidSPGR = True
				rst.CalcMotorSize = -1S
				Dim num4 As Short = 0S
				Dim text2 As String = "150 hp"
				Dim text3 As String = ""
				Motor.SelectMotorKind(CInt(num4))
				Motor.SelectMotorSizeByName(text2)
				Motor.SelectMotorSettingByName(text3)
				rst.miMotorKind = num4
				rst.msMotorSizeName = text2
				rst.msMotorSettingName = text3
				rst.UPumpIntakePressure = rst.PumpIntakePressure
			Catch ex As Exception
			End Try
		End Sub

		Public Sub CopyGuruFile2RSTObj(File As RSWIN_DESC.GuruFileDataStructure)
			Try
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				rst.SetClassDefaults(False)
				rst.Inputfile = File.FileName + ".rsvx"
				rst.WellName = File.WellName
				rst.gbCalcPumpCondition = File.gbCalcPumpCondition
				rst.PumpCondition = File.PumpCondition
				rst.IrotEntered = If((-If((File.IrotEntered > False), 1S, 0S)), 1S, 0S)
				rst.CalcPlungerSize = If((-If((File.CalcPlungerSize > False), 1S, 0S)), 1S, 0S)
				rst.gbCalcPumpIntakePressure = File.gbCalcPumpIntakePressure
				rst.CasingPressure = File.CasingPressure
				rst.CompressibilityIndex = File.CompressibilityIndex
				rst.ElectricityCost = File.ElectricityCost
				rst.FluidDamping = File.FluidDamping
				rst.FluidLevel = File.FluidLevel
				rst.gbIncludeBuoyancy = File.gbIncludeBuoyancy
				rst.IncludeFluidInertia = File.IncludeFluidInertia
				rst.Iart = File.Iart
				rst.Irot = File.Irot
				rst.UnknownM = File.UnknownM
				rst.set_M(2, File.M_Existing)
				rst.CBEffect = File.CBEffect
				rst.CBAngle = File.CBAngle
				rst.CBDataType = File.CBDataType
				rst.CalcMotorSize = If((-If((File.CalcMotorSize > False), 1S, 0S)), 1S, 0S)
				rst.CalcMotorSPV = If((-If((File.IncludeMotorSPV > False), 1S, 0S)), 1S, 0S)
				rst.MotorSPV = File.MotorSPV
				rst.OilAPI = File.OilAPI
				rst.PlungerSize = File.PlungerSize
				rst.PowerMeterType = File.PowerMeterType
				rst.PumpDepth = File.PumpDepth
				rst.PumpEfficiency = File.PumpEfficiency
				rst.PumpFillage = File.PumpFillage
				rst.PumpFriction = File.PumpFriction
				rst.PumpIntakePressure = File.PumpIntakePressure
				rst.PumpLoadAdj = File.PumpLoadAdj
				rst.PumpType = File.PumpType
				rst.SPM = File.SPM
				rst.CalcFriction = If((-If((File.CalcFriction > False), 1S, 0S)), 1S, 0S)
				rst.DownstrokeFriction = File.DownstrokeFriction
				rst.UpstrokeFriction = File.UpstrokeFriction
				rst.Runtime = File.Runtime
				rst.StuffingBoxFriction = File.StuffingBoxFriction
				rst.TargetBFPD = File.TargetBFPD
				rst.TubingAnchorDepth = File.TubingAnchorDepth
				rst.TubingAnchored = File.TubingAnchored
				rst.TubingID = File.TubingID
				rst.TubingOD = File.TubingOD
				rst.TubingPressure = File.TubingPressure
				rst.WaterCut = File.WaterCut
				rst.WaterSPGR = File.WaterSPGR
				rst.RodStringType = File.RodStringType
				rst.giRodDesignStyle = File.giRodDesignStyle
				rst.RSFGIncludeSteel = File.RSFGIncludeSteel
				rst.RSGrade = File.RSGrade
				rst.RSMaxSize = File.RSMaxSize
				rst.RSMinSize = File.RSMinSize
				rst.RSFricCoef = File.RSFricCoef
				rst.RSIncludeSB = File.RSIncludeSB
				Dim sinkerBar As RSWIN_DESC.RodSection
				sinkerBar.Initialize()
				sinkerBar.Grade = File.SinkerBar_Grade
				sinkerBar.length = File.SinkerBar_length
				sinkerBar.Diameter = File.SinkerBar_Diameter
				If(RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru) AndAlso (Not RSWIN_DESC.SETUP_UseXRODVTubingSizes And RSWIN_DESC.MaxTubingSizeOD <> 0F) Then
					If Not RSWIN_DESC.SETUP_FixTubingSize And rst.TubingOD > RSWIN_DESC.MaxTubingSizeOD Then
						rst.TubingOD = RSWIN_DESC.MaxTubingSizeOD
						rst.TubingID = RODUTIL.GetMaxTubingSizeID(rst.TubingOD)
					ElseIf RSWIN_DESC.SETUP_FixTubingSize And rst.TubingOD <> RSWIN_DESC.MaxTubingSizeOD Then
						rst.TubingOD = RSWIN_DESC.MaxTubingSizeOD
						rst.TubingID = RODUTIL.GetMaxTubingSizeID(rst.TubingOD)
					End If
					Dim maxCasingSize As Single = RSWIN_DESC.MaxCasingSize
					Dim maxTubingSizeOD As Single = RSWIN_DESC.MaxTubingSizeOD
					Dim num As Single
					Dim num2 As Single
					Dim num3 As Single
					RODUTIL.GetSizeFromCasingSize(maxCasingSize, maxTubingSizeOD, num, num2, num3, False)
					RSWIN_DESC.MaxTubingSizeOD = maxTubingSizeOD
					If rst.RSMaxSize > num Then
						rst.RSMaxSize = num
					End If
					If rst.RSMinSize > num Then
						rst.RSMinSize = num
					End If
					If rst.PlungerSize > num2 Then
						rst.PlungerSize = num2
					End If
					If sinkerBar.Diameter > num3 Then
						sinkerBar.Diameter = num3
					End If
				End If
				rst.SinkerBar = sinkerBar
				rst.RSFGGrade = File.RSFGGrade
				rst.RSExtraCost = File.RSExtraCost
				rst.RSExtraCostLabel = File.RSExtraCostLabel.Trim()
				rst.ServiceFactor = File.ServiceFactor
				Dim pu_CrankRotation As Short = File.PU_CrankRotation
				Dim pu_CrankHole As Short = File.PU_CrankHole
				Dim unbalance As Single = File.Unbalance
				rst.IDEntered = -1S
				Dim text As String = File.Unit + File.ID
				rst.UnitID = text.PadRight(10, " "c)
				Dim pu As RSWIN_DESC.PUDataRec
				PUDATA1.ReadPUData(rst.UnitID, pu, False, True)
				pu.CrankHole = pu_CrankHole
				pu.CrankRotation = pu_CrankRotation
				pu.R = pu.CrankRadii(CInt((pu.CrankHole - 1S)))
				If pu.Unbalance <> unbalance Then
					pu.Unbalance = unbalance
				End If
				kinemat.Kinconst(pu)
				kinemat.Unitstroke(pu)
				RSWIN_DESC.rst.PU = pu
				rst.FluidLevelEntered = True
				rst.CalcFriction = -1S
				rst.gbCalcSlideFricCoeff = True
				rst.CalcMotorSize = -1S
				rst.SPMEntered = 0S
				rst.gbCalcTargetBFPD = False
				rst.gbUseIPR = False
				rst.gbCalcFluidSPGR = True
				rst.CalcMotorSize = -1S
				Dim num4 As Short = 0S
				Dim text2 As String = "150 hp"
				Dim text3 As String = ""
				Motor.SelectMotorKind(CInt(num4))
				Motor.SelectMotorSizeByName(text2)
				Motor.SelectMotorSettingByName(text3)
				rst.miMotorKind = num4
				rst.msMotorSizeName = text2
				rst.msMotorSettingName = text3
				rst.UPumpIntakePressure = rst.PumpIntakePressure
			Catch ex As Exception
			End Try
		End Sub

		Public Function DBDeletePattern(sGuruFilenameKey As String) As Short
			Dim num As Integer = GURU_DB.DeleteFiledataRows(sGuruFilenameKey)
			RSWIN_DESC.AllGuruFiles = New RSWIN_DESC.GuruFileDataStructure(0) {}
			GURU_DB.ReLoadALLGuruFiledata()
			RSWIN_DESC.bGuruFileDataLoaded = True
			If num > 0 Then
				Return -1S
			End If
			Return 0S
		End Function

		Public Function DeleteFiledataRows(sGuruFilename As String) As Integer
			If Operators.CompareString(RSWIN_DESC.GuruDataBaseFileName, RSWIN_DESC.sTemplateDBFileName, False) = 0 Then
				Dim sTemplateDBFileName As String = RSWIN_DESC.sTemplateDBFileName
				Dim guruDataBaseFileName As String = RSWIN_DESC.GuruDataBaseFileName
				FILEUTIL.LocateFile(sTemplateDBFileName, guruDataBaseFileName, 2S, False, False, False, False)
				RSWIN_DESC.GuruDataBaseFileName = guruDataBaseFileName
			End If
			Dim connectionString As String = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + RSWIN_DESC.GuruDataBaseFileName + ";Mode=Share Deny None;Extended Properties="""";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password=", RSWIN_DESC.GuruDatabasePassword), ";Jet OLEDB:Engine Type=5;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password="""";Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False"))
			Dim text As String = "Filedata"
			Dim cmdText As String = String.Concat(New String() { "Delete from ", text, " where FileName='", sGuruFilename, "'" })
			Dim selectCommandText As String = String.Concat(New String() { "Select * from ", text, " where FileName='", sGuruFilename, "'" })
			Dim oleDbConnection As OleDbConnection = New OleDbConnection(connectionString)
			Dim oleDbDataAdapter As OleDbDataAdapter = New OleDbDataAdapter(selectCommandText, oleDbConnection)
			oleDbDataAdapter.DeleteCommand = New OleDbCommand(cmdText, oleDbConnection)
			oleDbDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey
			Dim dataSet As DataSet = New DataSet("filedata")
			oleDbDataAdapter.Fill(dataSet, text)
			Dim count As Integer = dataSet.Tables(0).Rows.Count
			Try
				If count > 0 Then
					dataSet.Tables(0).Rows(0).Delete()
					oleDbDataAdapter.Update(dataSet, text)
					Dim obj As Object = dataSet.Tables(0).Rows.Count
				End If
			Catch ex As Exception
			End Try
			Return count
		End Function

		Public Function DBFileNameKeyExistsFromArray(DbKeyName As String) As Boolean
			Dim flag As Boolean = False
			Dim result As Boolean
			Try
				Dim num As Integer = Information.LBound(RSWIN_DESC.AllGuruFiles, 1)
				Dim num2 As Integer = Information.UBound(RSWIN_DESC.AllGuruFiles, 1)
				Dim num3 As Integer = num
				Dim num4 As Integer = num2
				For i As Integer = num3 To num4
					If RSWIN_DESC.AllGuruFiles(i).FileName IsNot Nothing AndAlso Operators.CompareString(RSWIN_DESC.AllGuruFiles(i).FileName.ToLower().Trim(), DbKeyName.ToLower().Trim(), False) = 0 Then
						flag = True
						Exit For
					End If
				Next
				result = flag
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Function DBFileNameKeyExistsFromArrayUsingPrefix(ByRef DbKeyName As String, ByRef ExtraDbKeyName As String, PrefixGuruFiles As RSWIN_DESC.GuruFileDataStructure(), PUManuf As String) As Boolean
			Dim flag As Boolean = False
			Dim result As Boolean
			Try
				Dim num As Integer = Information.LBound(PrefixGuruFiles, 1)
				Dim num2 As Integer = Information.UBound(PrefixGuruFiles, 1)
				Dim num3 As Integer = num
				Dim num4 As Integer = num2
				For i As Integer = num3 To num4
					If PrefixGuruFiles(i).FileName IsNot Nothing AndAlso Operators.CompareString(PrefixGuruFiles(i).FileName.ToLower().Trim(), DbKeyName.ToLower().Trim(), False) = 0 Then
						If Not RSWIN_DESC.bUseLatestXRODCode Then
							flag = True
							Exit For
						End If
						If PrefixGuruFiles(i).Original = 1S Then
							flag = True
							Exit For
						End If
						If GURU_DB.CompareRunAIPreferencesWithDatabase(PrefixGuruFiles(i), PUManuf) Then
							flag = True
							Exit For
						End If
					End If
				Next
				If Not flag And Operators.CompareString(ExtraDbKeyName, "", False) <> 0 And RSWIN_DESC.bUseLatestXRODCode Then
					Dim num5 As Integer = num
					Dim num6 As Integer = num2
					For i As Integer = num5 To num6
						If PrefixGuruFiles(i).FileName IsNot Nothing AndAlso Operators.CompareString(PrefixGuruFiles(i).FileName.ToLower().Trim(), ExtraDbKeyName.ToLower().Trim(), False) = 0 AndAlso PrefixGuruFiles(i).Original = 0S AndAlso GURU_DB.CompareRunAIPreferencesWithDatabase(PrefixGuruFiles(i), PUManuf) Then
							flag = True
							DbKeyName = ExtraDbKeyName
							Exit For
						End If
					Next
				End If
				result = flag
			Catch ex As Exception
				MessageBox.Show("Error in DBFileNameKeyExistsFromArrayUsingPrefix" + ex.Message)
			End Try
			Return result
		End Function

		Public Function DBFileNameKeyExistsFromDB(DbKeyName As String) As Boolean
			Dim result As Boolean
			Try
				If Operators.CompareString(RSWIN_DESC.GuruDataBaseFileName, RSWIN_DESC.sTemplateDBFileName, False) = 0 Then
					Dim sTemplateDBFileName As String = RSWIN_DESC.sTemplateDBFileName
					Dim guruDataBaseFileName As String = RSWIN_DESC.GuruDataBaseFileName
					FILEUTIL.LocateFile(sTemplateDBFileName, guruDataBaseFileName, 2S, False, False, False, False)
					RSWIN_DESC.GuruDataBaseFileName = guruDataBaseFileName
				End If
				Dim connectionString As String = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + RSWIN_DESC.GuruDataBaseFileName + ";Mode=Share Deny None;Extended Properties="""";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password=", RSWIN_DESC.GuruDatabasePassword), ";Jet OLEDB:Engine Type=5;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password="""";Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False"))
				Dim text As String = "Filedata"
				Dim selectCommandText As String = String.Concat(New String() { "Select * from ", text, " where FileName='", DbKeyName, "'" })
				Dim selectConnection As OleDbConnection = New OleDbConnection(connectionString)
				Dim oleDbDataAdapter As OleDbDataAdapter = New OleDbDataAdapter(selectCommandText, selectConnection)
				oleDbDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey
				Dim dataSet As DataSet = New DataSet("filedata")
				oleDbDataAdapter.Fill(dataSet, text)
				Dim count As Integer = dataSet.Tables(0).Rows.Count
				Dim flag As Boolean
				Try
					If count > 0 Then
						flag = True
					Else
						flag = False
					End If
				Catch ex As Exception
				End Try
				result = flag
			Catch ex2 As Exception
				result = False
			End Try
			Return result
		End Function

		Private Sub RC4Initialize(strPwd As Object)
			Dim num As Integer = Strings.Len(RuntimeHelpers.GetObjectValue(strPwd))
			Dim num2 As Long = 0L
			Do
				' The following expression was wrapped in a unchecked-expression
				GURU_DB.key(CInt(num2)) = Strings.Asc(Strings.Mid(Conversions.ToString(strPwd), CInt((num2 Mod CLng(num) + 1L)), 1))
				GURU_DB.sbox(CInt(num2)) = num2
				num2 += 1L
			Loop While num2 <= 255L
			Dim num3 As Long = 0L
			num2 = 0L
			Do
				num3 = Conversions.ToLong(Operators.ModObject(Operators.AddObject(Operators.AddObject(num3, GURU_DB.sbox(CInt(num2))), GURU_DB.key(CInt(num2))), 256))
				Dim text As String = Conversions.ToString(GURU_DB.sbox(CInt(num2)))
				GURU_DB.sbox(CInt(num2)) = RuntimeHelpers.GetObjectValue(GURU_DB.sbox(CInt(num3)))
				GURU_DB.sbox(CInt(num3)) = text
				num2 += 1L
			Loop While num2 <= 255L
		End Sub

		Private Function EnDeCrypt(plaintxt As String) As Object
			Dim strPwd As String = "2349358399323"
			Dim num As Long = 0L
			Dim num2 As Long = 0L
			If plaintxt Is Nothing Then
				Return ""
			End If
			If Operators.CompareString(plaintxt, "", False) = 0 Then
				Return ""
			End If
			GURU_DB.RC4Initialize(strPwd)
			Dim num3 As Long = 1L
			Dim num4 As Long = CLng(Strings.Len(plaintxt))
			Dim text2 As String
			For num5 As Long = num3 To num4
				num = (num + 1L) Mod 256L
				num2 = Conversions.ToLong(Operators.ModObject(Operators.AddObject(num2, GURU_DB.sbox(CInt(num))), 256))
				Dim text As String = Conversions.ToString(GURU_DB.sbox(CInt(num)))
				GURU_DB.sbox(CInt(num)) = RuntimeHelpers.GetObjectValue(GURU_DB.sbox(CInt(num2)))
				GURU_DB.sbox(CInt(num2)) = text
				Dim num6 As Long = Conversions.ToLong(GURU_DB.sbox(Conversions.ToInteger(Operators.ModObject(Operators.AddObject(GURU_DB.sbox(CInt(num)), GURU_DB.sbox(CInt(num2))), 256))))
				Dim num7 As Long = CLng(Strings.Asc(Strings.Mid(plaintxt, CInt(num5), 1))) Xor num6
				text2 += Conversions.ToString(Strings.Chr(CInt(num7)))
			Next
			Return text2
		End Function

		Public Sub logfilestructure(file As RSWIN_DESC.GuruFileDataStructure)
			Try
				Debug.WriteLine("FileName  = " + file.FileName)
				Debug.WriteLine("WellName  = " + file.WellName)
				Debug.WriteLine("gbCalcPumpCondition  = " + Conversions.ToString(file.gbCalcPumpCondition))
				Debug.WriteLine("PumpCondition  = " + Conversions.ToString(CInt(file.PumpCondition)))
				Debug.WriteLine("IrotEntered  = " + Conversions.ToString(file.IrotEntered))
				Debug.WriteLine("CalcPlungerSize  = " + Conversions.ToString(file.CalcPlungerSize))
				Debug.WriteLine("gbCalcPumpIntakePressure  = " + Conversions.ToString(file.gbCalcPumpIntakePressure))
				Debug.WriteLine("CasingPressure  = " + Conversions.ToString(file.CasingPressure))
				Debug.WriteLine("CompressibilityIndex  = " + Conversions.ToString(file.CompressibilityIndex))
				Debug.WriteLine("ElectricityCost  = " + Conversions.ToString(file.ElectricityCost))
				Debug.WriteLine("FluidDamping  = " + Conversions.ToString(file.FluidDamping))
				Debug.WriteLine("FluidLevel  = " + Conversions.ToString(file.FluidLevel))
				Debug.WriteLine("gbIncludeBuoyancy  = " + Conversions.ToString(file.gbIncludeBuoyancy))
				Debug.WriteLine("IncludeFluidInertia  = " + Conversions.ToString(CInt(file.IncludeFluidInertia)))
				Debug.WriteLine("Iart  = " + Conversions.ToString(file.Iart))
				Debug.WriteLine("Irot  = " + Conversions.ToString(file.Irot))
				Debug.WriteLine("UnknownM  = " + Conversions.ToString(file.UnknownM))
				Debug.WriteLine("M_Existing  = " + Conversions.ToString(file.M_Existing))
				Debug.WriteLine("CBEffect  = " + Conversions.ToString(file.CBEffect))
				Debug.WriteLine("CBAngle  = " + Conversions.ToString(file.CBAngle))
				Debug.WriteLine("CBDataType  = " + Conversions.ToString(CInt(file.CBDataType)))
				Debug.WriteLine("CalcMotorSize  = " + Conversions.ToString(file.CalcMotorSize))
				Debug.WriteLine("IncludeMotorSPV  = " + Conversions.ToString(file.IncludeMotorSPV))
				Debug.WriteLine("MotorSPV  = " + Conversions.ToString(file.MotorSPV))
				Debug.WriteLine("OilAPI  = " + Conversions.ToString(file.OilAPI))
				Debug.WriteLine("PlungerSize  = " + Conversions.ToString(file.PlungerSize))
				Debug.WriteLine("PowerMeterType  = " + Conversions.ToString(CInt(file.PowerMeterType)))
				Debug.WriteLine("PumpDepth  = " + Conversions.ToString(file.PumpDepth))
				Debug.WriteLine("PumpEfficiency  = " + Conversions.ToString(file.PumpEfficiency))
				Debug.WriteLine("PumpFillage  = " + Conversions.ToString(file.PumpFillage))
				Debug.WriteLine("PumpFriction  = " + Conversions.ToString(file.PumpFriction))
				Debug.WriteLine("PumpIntakePressure  = " + Conversions.ToString(file.PumpIntakePressure))
				Debug.WriteLine("PumpLoadAdj  = " + Conversions.ToString(file.PumpLoadAdj))
				Debug.WriteLine("PumpType  = " + Conversions.ToString(CInt(file.PumpType)))
				Debug.WriteLine("SPM  = " + Conversions.ToString(file.SPM))
				Debug.WriteLine("CalcFriction  = " + Conversions.ToString(file.CalcFriction))
				Debug.WriteLine("DownstrokeFriction  = " + Conversions.ToString(file.DownstrokeFriction))
				Debug.WriteLine("UpstrokeFriction  = " + Conversions.ToString(file.UpstrokeFriction))
				Debug.WriteLine("Runtime  = " + Conversions.ToString(file.Runtime))
				Debug.WriteLine("StuffingBoxFriction  = " + Conversions.ToString(file.StuffingBoxFriction))
				Debug.WriteLine("TargetBFPD  = " + Conversions.ToString(file.TargetBFPD))
				Debug.WriteLine("TubingAnchorDepth  = " + Conversions.ToString(file.TubingAnchorDepth))
				Debug.WriteLine("TubingAnchored  = " + Conversions.ToString(CInt(file.TubingAnchored)))
				Debug.WriteLine("TubingID  = " + Conversions.ToString(file.TubingID))
				Debug.WriteLine("TubingOD  = " + Conversions.ToString(file.TubingOD))
				Debug.WriteLine("TubingPressure  = " + Conversions.ToString(file.TubingPressure))
				Debug.WriteLine("WaterCut  = " + Conversions.ToString(file.WaterCut))
				Debug.WriteLine("WaterSPGR  = " + Conversions.ToString(file.WaterSPGR))
				Debug.WriteLine("RodStringType  = " + Conversions.ToString(CInt(file.RodStringType)))
				Debug.WriteLine("giRodDesignStyle  = " + Conversions.ToString(CInt(file.giRodDesignStyle)))
				Debug.WriteLine("RSFGIncludeSteel  = " + Conversions.ToString(CInt(file.RSFGIncludeSteel)))
				Debug.WriteLine("RSGrade  = " + Conversions.ToString(CInt(file.RSGrade)))
				Debug.WriteLine("RSMaxSize  = " + Conversions.ToString(file.RSMaxSize))
				Debug.WriteLine("RSMinSize  = " + Conversions.ToString(file.RSMinSize))
				Debug.WriteLine("RSFricCoef  = " + Conversions.ToString(file.RSFricCoef))
				Debug.WriteLine("RSIncludeSB  = " + Conversions.ToString(CInt(file.RSIncludeSB)))
				Debug.WriteLine("SinkerBar_Grade  = " + Conversions.ToString(CInt(file.SinkerBar_Grade)))
				Debug.WriteLine("SinkerBar_length  = " + Conversions.ToString(file.SinkerBar_length))
				Debug.WriteLine("SinkerBar_Diameter  = " + Conversions.ToString(file.SinkerBar_Diameter))
				Debug.WriteLine("RSFGGrade  = " + Conversions.ToString(CInt(file.RSFGGrade)))
				Debug.WriteLine("RSExtraCost  = " + Conversions.ToString(file.RSExtraCost))
				Debug.WriteLine("RSExtraCostLabel  = *" + file.RSExtraCostLabel + "*")
				Debug.WriteLine("ServiceFactor  = " + Conversions.ToString(file.ServiceFactor))
				Debug.WriteLine("PU_CrankRotation  = " + Conversions.ToString(CInt(file.PU_CrankRotation)))
				Debug.WriteLine("PU_CrankHole  = " + Conversions.ToString(CInt(file.PU_CrankHole)))
				Debug.WriteLine("Unbalance  = " + Conversions.ToString(file.Unbalance))
				Debug.WriteLine("UnitID  = " + file.Unit + file.ID)
				Debug.WriteLine("Date Added  = " + Conversions.ToString(file.DateAdded))
				Debug.WriteLine("Added  = " + Conversions.ToString(CInt(file.Original)))
				Debug.WriteLine("-------------------------")
			Catch ex As Exception
			End Try
		End Sub

		Public Sub logfiledatarow(myRec As DataRow)
			Try
				Debug.WriteLine(Operators.ConcatenateObject("FileName  = ", myRec("FileName")))
				Debug.WriteLine(Operators.ConcatenateObject("WellName  = ", myRec("WellName")))
				Debug.WriteLine(Operators.ConcatenateObject("gbCalcPumpCondition  = ", myRec("gbCalcPumpCondition")))
				Debug.WriteLine(Operators.ConcatenateObject("PumpCondition  = ", myRec("PumpCondition")))
				Debug.WriteLine(Operators.ConcatenateObject("IrotEntered  = ", myRec("IrotEntered")))
				Debug.WriteLine(Operators.ConcatenateObject("CalcPlungerSize  = ", myRec("CalcPlungerSize")))
				Debug.WriteLine(Operators.ConcatenateObject("gbCalcPumpIntakePressure  = ", myRec("gbCalcPumpIntakePressure")))
				Debug.WriteLine(Operators.ConcatenateObject("CasingPressure  = ", myRec("CasingPressure")))
				Debug.WriteLine(Operators.ConcatenateObject("WellName  = ", myRec("WellName")))
				Debug.WriteLine(Operators.ConcatenateObject("CompressibilityIndex  = ", myRec("CompressibilityIndex")))
				Debug.WriteLine(Operators.ConcatenateObject("ElectricityCost  = ", myRec("ElectricityCost")))
				Debug.WriteLine(Operators.ConcatenateObject("FluidDamping  = ", myRec("FluidDamping")))
				Debug.WriteLine(Operators.ConcatenateObject("FluidLevel  = ", myRec("FluidLevel")))
				Debug.WriteLine(Operators.ConcatenateObject("gbIncludeBuoyancy  = ", myRec("gbIncludeBuoyancy")))
				Debug.WriteLine(Operators.ConcatenateObject("IncludeFluidInertia  = ", myRec("IncludeFluidInertia")))
				Debug.WriteLine(Operators.ConcatenateObject("Iart  = ", myRec("Iart")))
				Debug.WriteLine(Operators.ConcatenateObject("Irot  = ", myRec("Irot")))
				Debug.WriteLine(Operators.ConcatenateObject("UnknownM  = ", myRec("UnknownM")))
				Debug.WriteLine(Operators.ConcatenateObject("M_Existing  = ", myRec("M_Existing")))
				Debug.WriteLine(Operators.ConcatenateObject("CBEffect  = ", myRec("CBEffect")))
				Debug.WriteLine(Operators.ConcatenateObject("CBAngle  = ", myRec("CBAngle")))
				Debug.WriteLine(Operators.ConcatenateObject("CBDataType  = ", myRec("CBDataType")))
				Debug.WriteLine(Operators.ConcatenateObject("CalcMotorSize = ", myRec("CalcMotorSize")))
				Debug.WriteLine(Operators.ConcatenateObject("IncludeMotorSPV = ", myRec("IncludeMotorSPV")))
				Debug.WriteLine(Operators.ConcatenateObject("MotorSPV  = ", myRec("MotorSPV")))
				Debug.WriteLine(Operators.ConcatenateObject("OilAPI  = ", myRec("OilAPI")))
				Debug.WriteLine(Operators.ConcatenateObject("PlungerSize  = ", myRec("PlungerSize")))
				Debug.WriteLine(Operators.ConcatenateObject("PowerMeterType  = ", myRec("PowerMeterType")))
				Debug.WriteLine(Operators.ConcatenateObject("PumpDepth  = ", myRec("PumpDepth")))
				Debug.WriteLine(Operators.ConcatenateObject("PumpEfficiency  = ", myRec("PumpEfficiency")))
				Debug.WriteLine(Operators.ConcatenateObject("PumpFillage  = ", myRec("PumpFillage")))
				Debug.WriteLine(Operators.ConcatenateObject("PumpFriction  = ", myRec("PumpFriction")))
				Debug.WriteLine(Operators.ConcatenateObject("PumpIntakePressure  = ", myRec("PumpIntakePressure")))
				Debug.WriteLine(Operators.ConcatenateObject("PumpLoadAdj  = ", myRec("PumpLoadAdj")))
				Debug.WriteLine(Operators.ConcatenateObject("PumpType  = ", myRec("PumpType")))
				Debug.WriteLine(Operators.ConcatenateObject("SPM  = ", myRec("SPM")))
				Debug.WriteLine(Operators.ConcatenateObject("CalcFriction  = ", myRec("CalcFriction")))
				Debug.WriteLine(Operators.ConcatenateObject("DownstrokeFriction  = ", myRec("DownstrokeFriction")))
				Debug.WriteLine(Operators.ConcatenateObject("UpstrokeFriction  = ", myRec("UpstrokeFriction")))
				Debug.WriteLine(Operators.ConcatenateObject("Runtime  = ", myRec("Runtime")))
				Debug.WriteLine(Operators.ConcatenateObject("StuffingBoxFriction  = ", myRec("StuffingBoxFriction")))
				Debug.WriteLine(Operators.ConcatenateObject("TargetBFPD  = ", myRec("TargetBFPD")))
				Debug.WriteLine(Operators.ConcatenateObject("TubingAnchorDepth  = ", myRec("TubingAnchorDepth")))
				Debug.WriteLine(Operators.ConcatenateObject("TubingAnchored  = ", myRec("TubingAnchored")))
				Debug.WriteLine(Operators.ConcatenateObject("TubingID  = ", myRec("TubingID")))
				Debug.WriteLine(Operators.ConcatenateObject("TubingOD  = ", myRec("TubingOD")))
				Debug.WriteLine(Operators.ConcatenateObject("TubingPressure  = ", myRec("TubingPressure")))
				Debug.WriteLine(Operators.ConcatenateObject("WaterCut  = ", myRec("WaterCut")))
				Debug.WriteLine(Operators.ConcatenateObject("WaterSPGR  = ", myRec("WaterSPGR")))
				Debug.WriteLine(Operators.ConcatenateObject("RodStringType  = ", myRec("RodStringType")))
				Debug.WriteLine(Operators.ConcatenateObject("giRodDesignStyle  = ", myRec("giRodDesignStyle")))
				Debug.WriteLine(Operators.ConcatenateObject("RSFGIncludeSteel  = ", myRec("RSFGIncludeSteel")))
				Debug.WriteLine(Operators.ConcatenateObject("RSGrade  = ", myRec("RSGrade")))
				Debug.WriteLine(Operators.ConcatenateObject("RSMaxSize  = ", myRec("RSMaxSize")))
				Debug.WriteLine(Operators.ConcatenateObject("RSMinSize  = ", myRec("RSMinSize")))
				Debug.WriteLine(Operators.ConcatenateObject("RSFricCoef  = ", myRec("RSFricCoef")))
				Debug.WriteLine(Operators.ConcatenateObject("RSIncludeSB  = ", myRec("RSIncludeSB")))
				Debug.WriteLine(Operators.ConcatenateObject("SinkerBar_Grade  = ", myRec("SinkerBar_Grade")))
				Debug.WriteLine(Operators.ConcatenateObject("SinkerBar_length  = ", myRec("SinkerBar_length")))
				Debug.WriteLine(Operators.ConcatenateObject("SinkerBar_Diameter  = ", myRec("SinkerBar_Diameter")))
				Debug.WriteLine(Operators.ConcatenateObject("RSFGGrade  = ", myRec("RSFGGrade")))
				Debug.WriteLine(Operators.ConcatenateObject("RSExtraCost  = ", myRec("RSExtraCost")))
				Debug.WriteLine(Operators.ConcatenateObject(Operators.ConcatenateObject("RSExtraCostLabel  = *", myRec("RSExtraCostLabel")), "*"))
				Debug.WriteLine(Operators.ConcatenateObject("ServiceFactor  = ", myRec("ServiceFactor")))
				Debug.WriteLine(Operators.ConcatenateObject("PU_CrankRotation  = ", myRec("PU_CrankRotation")))
				Debug.WriteLine(Operators.ConcatenateObject("PU_CrankHole  = ", myRec("PU_CrankHole")))
				Debug.WriteLine(Operators.ConcatenateObject("Unbalance  = ", myRec("Unbalance")))
				Debug.WriteLine(Operators.ConcatenateObject(Operators.ConcatenateObject("UnitID  = ", myRec("Unit")), myRec("ID")))
				Debug.WriteLine(Operators.ConcatenateObject("Date Added  = ", myRec("DateAdded")))
				Debug.WriteLine(Operators.ConcatenateObject("bOriginal  = ", myRec("Original")))
				Debug.WriteLine("-------------------------")
			Catch ex As Exception
			End Try
		End Sub

		Public Function CompareRunAIPreferencesWithDatabase(file As RSWIN_DESC.GuruFileDataStructure, PUManuf As String) As Boolean
			Dim result As Boolean
			Try
				Dim num As Short = 4099S
				Dim num2 As Short = 4098S
				Dim flag As Boolean = True
				Dim flag2 As Boolean = RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru And RSWIN_DESC.bXRODAdmin And RSWIN_DESC.SETUP_bAdminDebug
				If flag2 Then
					Batch.BatchMessage(" > Comparing preference with added template.")
				End If
				If RODUTIL.IsCorod(RSWIN_DESC.HSGradeRod) Then
					Dim hsgradeRod As Short = RSWIN_DESC.HSGradeRod
					If hsgradeRod = 12547S OrElse hsgradeRod = 12549S OrElse hsgradeRod = 12550S OrElse hsgradeRod = 12548S Then
						num = 12546S
						num2 = 12545S
					ElseIf hsgradeRod = 12802S OrElse hsgradeRod = 12803S OrElse hsgradeRod = 12805S OrElse hsgradeRod = 12806S OrElse hsgradeRod = 13057S OrElse hsgradeRod = 12808S OrElse hsgradeRod = 12807S Then
						num = 12801S
						num2 = 12804S
					End If
				ElseIf RODUTIL.IsProRod(CInt(RSWIN_DESC.HSGradeRod)) <> 0 Then
					num = 24580S
					num2 = 24579S
				End If
				If file.giRodDesignStyle = 0S And RSWIN_DESC.SETUP_bUseSteelRodsOnly Then
					If file.RSGrade <> RSWIN_DESC.HSGradeRod And file.RSGrade <> num And file.RSGrade <> num2 Then
						flag = False
						If flag2 Then
							Batch.BatchMessage(" > RSGrade not equal")
						End If
					End If
				ElseIf file.giRodDesignStyle = 0S And Not RSWIN_DESC.SETUP_bUseSteelRodsOnly Then
					flag = False
					If flag2 Then
						Batch.BatchMessage(" > UseSteelRodsOnly not equal")
					End If
				End If
				If file.giRodDesignStyle = 1S And RSWIN_DESC.SETUP_bUseFGlassWithSteelOnBottom Then
					If file.RSFGGrade <> RSWIN_DESC.FGGradeRod Then
						flag = False
						If flag2 Then
							Batch.BatchMessage(" > FGGrade not equal")
						End If
					End If
					If file.RSFGIncludeSteel <> 0S Then
						If file.RSGrade <> RSWIN_DESC.HSGradeRod And file.RSGrade <> num And file.RSGrade <> num2 Then
							flag = False
							If flag2 Then
								Batch.BatchMessage(" > RSGrade not equal")
							End If
						End If
					End If
				ElseIf file.giRodDesignStyle = 1S And Not RSWIN_DESC.SETUP_bUseFGlassWithSteelOnBottom Then
					flag = False
					If flag2 Then
						Batch.BatchMessage(" > UseFGlassWithSteelOnBottom not equal")
					End If
				End If
				If file.RSIncludeSB <> 0S AndAlso RSWIN_DESC.SBGradeRod <> file.SinkerBar_Grade Then
					flag = False
					If flag2 Then
						Batch.BatchMessage(" > SBGradeRod not equal")
					End If
				End If
				If file.ServiceFactor <> RSWIN_DESC.SETUP_ServiceFactorPreference Then
					flag = False
					If flag2 Then
						Batch.BatchMessage(" > ServiceFactor not equal")
					End If
				End If
				If file.ElectricityCost <> RSWIN_DESC.SETUP_ElectricityCostPreference Then
					flag = False
					If flag2 Then
						Batch.BatchMessage(" > Electric Cost not equal")
					End If
				End If
				If file.PowerMeterType <> RSWIN_DESC.SETUP_PowerMeterType Then
					flag = False
					If flag2 Then
						Batch.BatchMessage(" > PowerMeterType not equal")
					End If
				End If
				If RSWIN_DESC.SETUP_IncludeMotorSPV <> file.IncludeMotorSPV AndAlso (file.MotorSPV <= 0F And Not file.CalcMotorSize) Then
					flag = False
					If flag2 Then
						Batch.BatchMessage(" > IncludeMotorSPV not equal")
					End If
				End If
				Try
					Dim text As String = file.Unit.Trim() + file.ID.Trim()
					If Operators.CompareString(text.Trim(), "", False) <> 0 Then
						Dim pudataRec As RSWIN_DESC.PUDataRec
						PUDATA1.ReadPUData(text, pudataRec, True, False)
						Dim manuf As String = pudataRec.Manuf
						If Operators.CompareString(manuf.Trim(), PUManuf.Trim(), False) <> 0 Then
							flag = False
							If flag2 Then
								Batch.BatchMessage(" > PUManuf not equal")
							End If
						End If
					End If
				Catch ex As Exception
				End Try
				If flag2 AndAlso flag Then
					Batch.BatchMessage(" > Comparing preference with added template.")
				End If
				result = flag
			Catch ex2 As Exception
				result = False
			End Try
			Return result
		End Function

		Public Sub OutputTemplatesToFile()
			MessageBox.Show("Writing Templates to file: " + Application.StartupPath + "\AllTemplates.txt")
			Dim text As String = Application.StartupPath + "\AllTemplates.txt"
			If FILEUTIL.FileExists(text) Then
				Try
					FileSystem.Kill(Application.StartupPath + "\AllTemplates.txt")
				Catch ex As Exception
				End Try
			End If
			Dim num As Integer = FileSystem.FreeFile()
			FileSystem.FileOpen(num, Application.StartupPath + "\AllTemplates.txt", OpenMode.Append, OpenAccess.[Default], OpenShare.[Default], -1)
			Try
				Dim num2 As Integer = 1
				Dim iGuruFileCount As Integer = RSWIN_DESC.iGuruFileCount
				For i As Integer = num2 To iGuruFileCount
					Dim num3 As Integer = i
					FileSystem.PrintLine(num, New Object() { "FileName = " + RSWIN_DESC.AllGuruFiles(num3).FileName })
					FileSystem.PrintLine(num, New Object() { "WellName = " + RSWIN_DESC.AllGuruFiles(num3).WellName })
					FileSystem.PrintLine(num, New Object() { "gbCalcPumpCondition = " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(num3).gbCalcPumpCondition) })
					FileSystem.PrintLine(num, New Object() { "PumpCondition = " + Conversions.ToString(CInt(RSWIN_DESC.AllGuruFiles(num3).PumpCondition)) })
					FileSystem.PrintLine(num, New Object() { "IrotEntered = " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(num3).IrotEntered) })
					FileSystem.PrintLine(num, New Object() { "CalcPlungerSize = " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(num3).CalcPlungerSize) })
					FileSystem.PrintLine(num, New Object() { "gbCalcPumpIntakePressure = " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(num3).gbCalcPumpIntakePressure) })
					FileSystem.PrintLine(num, New Object() { "CasingPressure = " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(num3).CasingPressure) })
					FileSystem.PrintLine(num, New Object() { "CompressibilityIndex = " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(num3).CompressibilityIndex) })
					FileSystem.PrintLine(num, New Object() { "ElectricityCost = " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(num3).ElectricityCost) })
					FileSystem.PrintLine(num, New Object() { "FluidDamping = " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(num3).FluidDamping) })
					FileSystem.PrintLine(num, New Object() { "FluidLevel = " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(num3).FluidLevel) })
					FileSystem.PrintLine(num, New Object() { "gbIncludeBuoyancy = " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(num3).gbIncludeBuoyancy) })
					FileSystem.PrintLine(num, New Object() { "IncludeFluidInertia = " + Conversions.ToString(CInt(RSWIN_DESC.AllGuruFiles(num3).IncludeFluidInertia)) })
					FileSystem.PrintLine(num, New Object() { "Iart = " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(num3).Iart) })
					FileSystem.PrintLine(num, New Object() { "Irot = " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(num3).Irot) })
					FileSystem.PrintLine(num, New Object() { "UnknownM = " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(num3).UnknownM) })
					FileSystem.PrintLine(num, New Object() { "M_Existing = " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(num3).M_Existing) })
					FileSystem.PrintLine(num, New Object() { "CBEffect = " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(num3).CBEffect) })
					FileSystem.PrintLine(num, New Object() { "CBAngle = " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(num3).CBAngle) })
					FileSystem.PrintLine(num, New Object() { "CBDataType = " + Conversions.ToString(CInt(RSWIN_DESC.AllGuruFiles(num3).CBDataType)) })
					FileSystem.PrintLine(num, New Object() { "CalcMotorSize = " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(num3).CalcMotorSize) })
					FileSystem.PrintLine(num, New Object() { "IncludeMotorSPV = " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(num3).IncludeMotorSPV) })
					FileSystem.PrintLine(num, New Object() { "MotorSPV = " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(num3).MotorSPV) })
					FileSystem.PrintLine(num, New Object() { "OilAPI = " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(num3).OilAPI) })
					FileSystem.PrintLine(num, New Object() { "PlungerSize = " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(num3).PlungerSize) })
					FileSystem.PrintLine(num, New Object() { "PowerMeterType = " + Conversions.ToString(CInt(RSWIN_DESC.AllGuruFiles(num3).PowerMeterType)) })
					FileSystem.PrintLine(num, New Object() { "PumpDepth = " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(num3).PumpDepth) })
					FileSystem.PrintLine(num, New Object() { "PumpEfficiency = " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(num3).PumpEfficiency) })
					FileSystem.PrintLine(num, New Object() { "PumpFillage = " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(num3).PumpFillage) })
					FileSystem.PrintLine(num, New Object() { "PumpFriction = " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(num3).PumpFriction) })
					FileSystem.PrintLine(num, New Object() { "PumpIntakePressure = " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(num3).PumpIntakePressure) })
					FileSystem.PrintLine(num, New Object() { "PumpLoadAdj = " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(num3).PumpLoadAdj) })
					FileSystem.PrintLine(num, New Object() { "PumpType = " + Conversions.ToString(CInt(RSWIN_DESC.AllGuruFiles(num3).PumpType)) })
					FileSystem.PrintLine(num, New Object() { "SPM = " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(num3).SPM) })
					FileSystem.PrintLine(num, New Object() { "CalcFriction = " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(num3).CalcFriction) })
					FileSystem.PrintLine(num, New Object() { "DownstrokeFriction = " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(num3).DownstrokeFriction) })
					FileSystem.PrintLine(num, New Object() { "UpstrokeFriction = " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(num3).UpstrokeFriction) })
					FileSystem.PrintLine(num, New Object() { "Runtime = " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(num3).Runtime) })
					FileSystem.PrintLine(num, New Object() { "StuffingBoxFriction = " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(num3).StuffingBoxFriction) })
					FileSystem.PrintLine(num, New Object() { "TargetBFPD = " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(num3).TargetBFPD) })
					FileSystem.PrintLine(num, New Object() { "TubingAnchorDepth = " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(num3).TubingAnchorDepth) })
					FileSystem.PrintLine(num, New Object() { "TubingAnchored = " + Conversions.ToString(CInt(RSWIN_DESC.AllGuruFiles(num3).TubingAnchored)) })
					FileSystem.PrintLine(num, New Object() { "TubingID = " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(num3).TubingID) })
					FileSystem.PrintLine(num, New Object() { "TubingOD = " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(num3).TubingOD) })
					FileSystem.PrintLine(num, New Object() { "TubingPressure = " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(num3).TubingPressure) })
					FileSystem.PrintLine(num, New Object() { "WaterCut = " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(num3).WaterCut) })
					FileSystem.PrintLine(num, New Object() { "WaterSPGR = " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(num3).WaterSPGR) })
					FileSystem.PrintLine(num, New Object() { "RodStringType = " + Conversions.ToString(CInt(RSWIN_DESC.AllGuruFiles(num3).RodStringType)) })
					FileSystem.PrintLine(num, New Object() { "giRodDesignStyle = " + Conversions.ToString(CInt(RSWIN_DESC.AllGuruFiles(num3).giRodDesignStyle)) })
					FileSystem.PrintLine(num, New Object() { "RSFGIncludeSteel = " + Conversions.ToString(CInt(RSWIN_DESC.AllGuruFiles(num3).RSFGIncludeSteel)) })
					FileSystem.PrintLine(num, New Object() { "RSGrade = " + Conversions.ToString(CInt(RSWIN_DESC.AllGuruFiles(num3).RSGrade)) })
					FileSystem.PrintLine(num, New Object() { "RSMaxSize = " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(num3).RSMaxSize) })
					FileSystem.PrintLine(num, New Object() { "RSMinSize = " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(num3).RSMinSize) })
					FileSystem.PrintLine(num, New Object() { "RSFricCoef = " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(num3).RSFricCoef) })
					FileSystem.PrintLine(num, New Object() { "RSIncludeSB = " + Conversions.ToString(CInt(RSWIN_DESC.AllGuruFiles(num3).RSIncludeSB)) })
					FileSystem.PrintLine(num, New Object() { "SinkerBar_Grade = " + Conversions.ToString(CInt(RSWIN_DESC.AllGuruFiles(num3).SinkerBar_Grade)) })
					FileSystem.PrintLine(num, New Object() { "SinkerBar_length = " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(num3).SinkerBar_length) })
					FileSystem.PrintLine(num, New Object() { "SinkerBar_Diameter = " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(num3).SinkerBar_Diameter) })
					FileSystem.PrintLine(num, New Object() { "RSFGGrade = " + Conversions.ToString(CInt(RSWIN_DESC.AllGuruFiles(num3).RSFGGrade)) })
					FileSystem.PrintLine(num, New Object() { "RSExtraCost = " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(num3).RSExtraCost) })
					If Operators.CompareString(RSWIN_DESC.AllGuruFiles(num3).RSExtraCostLabel, " Then", False) = 0 Then
						RSWIN_DESC.AllGuruFiles(num3).RSExtraCostLabel = " "
					End If
					FileSystem.PrintLine(num, New Object() { "RSExtraCostLabel = " + RSWIN_DESC.AllGuruFiles(num3).RSExtraCostLabel })
					FileSystem.PrintLine(num, New Object() { "ServiceFactor = " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(num3).ServiceFactor) })
					FileSystem.PrintLine(num, New Object() { "PU_CrankRotation = " + Conversions.ToString(CInt(RSWIN_DESC.AllGuruFiles(num3).PU_CrankRotation)) })
					FileSystem.PrintLine(num, New Object() { "PU_CrankHole = " + Conversions.ToString(CInt(RSWIN_DESC.AllGuruFiles(num3).PU_CrankHole)) })
					FileSystem.PrintLine(num, New Object() { "Unbalance = " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(num3).Unbalance) })
					FileSystem.PrintLine(num, New Object() { "Unit = " + RSWIN_DESC.AllGuruFiles(num3).Unit })
					FileSystem.PrintLine(num, New Object() { "ID = " + RSWIN_DESC.AllGuruFiles(num3).ID })
					FileSystem.PrintLine(num, New Object() { "DateAdded = " + Conversions.ToString(DateAndTime.Now.[Date]) })
					FileSystem.PrintLine(num, New Object() { "Original = " + Conversions.ToString(CInt(RSWIN_DESC.AllGuruFiles(num3).Original)) })
				Next
				FileSystem.FileClose(New Integer() { num })
				MessageBox.Show("Write to file finished!")
			Catch ex2 As Exception
				MessageBox.Show("Exception in Output ALL Templates")
				FileSystem.FileClose(New Integer() { num })
			End Try
		End Sub

		Public Sub CheckAddedTemplatesForNewInstall()
			' The following expression was wrapped in a checked-statement
			Try
				Dim str As String = ""
				Dim text As String = Interaction.Environ("USERPROFILE") + "\Application Data\ThetaData\" + VERSION1.ProgramName() + "\"
				Dim array As RSWIN_DESC.GuruFileDataStructure() = New RSWIN_DESC.GuruFileDataStructure(7500) {}
				Dim fileInfo As FileInfo = New FileInfo(Application.StartupPath + "\" + RSWIN_DESC.sTemplateDBFileName)
				If fileInfo.Exists Then
					RSWIN_DESC.GuruDataBaseFileName = text + RSWIN_DESC.sTemplateDBFileName
					Dim fileInfo2 As FileInfo = New FileInfo(RSWIN_DESC.GuruDataBaseFileName)
					If fileInfo2.Exists Then
						fileInfo2.Delete()
					End If
					File.Copy(Application.StartupPath + "\" + RSWIN_DESC.sTemplateDBFileName, RSWIN_DESC.GuruDataBaseFileName)
				End If
				str = RSWIN_DESC.sTemplateDBFileName.ToLower().Replace(".mdb", "_backup.mdb")
				Dim fileInfo3 As FileInfo = New FileInfo(text + str)
				If fileInfo3.Exists Then
					Dim connectionString As String = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=""" + text + str + """" + ";Mode=Share Deny None;Extended Properties="""";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password=", RSWIN_DESC.GuruDatabasePassword), ";Jet OLEDB:Engine Type=5;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password="""";Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False"))
					Dim text2 As String = "Filedata"
					Dim selectCommandText As String = "Select * from " + text2 + " where Original=0"
					Dim selectConnection As OleDbConnection = New OleDbConnection(connectionString)
					Dim oleDbDataAdapter As OleDbDataAdapter = New OleDbDataAdapter(selectCommandText, selectConnection)
					oleDbDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey
					Dim dataSet As DataSet = New DataSet("filedata")
					oleDbDataAdapter.Fill(dataSet, text2)
					array = New RSWIN_DESC.GuruFileDataStructure(0) {}
					Dim count As Integer = dataSet.Tables(0).Rows.Count
					Try
						If count > 0 Then
							Dim i As Integer
							Try
								For Each obj As Object In dataSet.Tables(0).Rows
									Dim dataRow As DataRow = CType(obj, DataRow)
									Try
										Application.DoEvents()
										i += 1
										array = CType(Utils.CopyArray(CType(array, Array), New RSWIN_DESC.GuruFileDataStructure(i + 1 - 1) {}), RSWIN_DESC.GuruFileDataStructure())
										Dim num As Integer = i
										array(num).Initialize()
										If Not RSWIN_DESC.bXRODAdmin Then
											array(num).FileName = Conversions.ToString(GURU_DB.EnDeCrypt(Conversions.ToString(dataRow("FileName"))))
											array(num).WellName = Conversions.ToString(dataRow("WellName"))
											array(num).gbCalcPumpCondition = Conversions.ToBoolean(dataRow("gbCalcPumpCondition"))
											array(num).PumpCondition = Conversions.ToShort(dataRow("PumpCondition"))
											array(num).IrotEntered = Conversions.ToBoolean(dataRow("IrotEntered"))
											array(num).CalcPlungerSize = Conversions.ToBoolean(dataRow("CalcPlungerSize"))
											array(num).gbCalcPumpIntakePressure = Conversions.ToBoolean(dataRow("gbCalcPumpIntakePressure"))
											array(num).CasingPressure = Conversions.ToSingle(dataRow("CasingPressure"))
											array(num).CompressibilityIndex = Conversions.ToSingle(dataRow("CompressibilityIndex"))
											array(num).ElectricityCost = Conversions.ToSingle(dataRow("ElectricityCost"))
											array(num).FluidDamping = Conversions.ToSingle(dataRow("FluidDamping"))
											array(num).FluidLevel = Conversions.ToSingle(GURU_DB.EnDeCrypt(Conversions.ToString(dataRow("FluidLevel"))))
											array(num).gbIncludeBuoyancy = Conversions.ToBoolean(dataRow("gbIncludeBuoyancy"))
											array(num).IncludeFluidInertia = Conversions.ToShort(dataRow("IncludeFluidInertia"))
											array(num).Iart = Conversions.ToSingle(dataRow("Iart"))
											array(num).Irot = Conversions.ToSingle(dataRow("Irot"))
											array(num).UnknownM = Conversions.ToBoolean(dataRow("UnknownM"))
											array(num).M_Existing = Conversions.ToSingle(dataRow("M_Existing"))
											array(num).CBEffect = Conversions.ToSingle(dataRow("CBEffect"))
											array(num).CBAngle = Conversions.ToSingle(dataRow("CBAngle"))
											array(num).CBDataType = Conversions.ToShort(dataRow("CBDataType"))
											array(num).CalcMotorSize = Conversions.ToBoolean(dataRow("CalcMotorSize"))
											array(num).IncludeMotorSPV = Conversions.ToBoolean(dataRow("IncludeMotorSPV"))
											array(num).MotorSPV = Conversions.ToSingle(dataRow("MotorSPV"))
											array(num).OilAPI = Conversions.ToSingle(dataRow("OilAPI"))
											array(num).PlungerSize = Conversions.ToSingle(dataRow("PlungerSize"))
											array(num).PowerMeterType = Conversions.ToShort(dataRow("PowerMeterType"))
											array(num).PumpDepth = Conversions.ToSingle(GURU_DB.EnDeCrypt(Conversions.ToString(dataRow("PumpDepth"))))
											array(num).PumpEfficiency = Conversions.ToSingle(dataRow("PumpEfficiency"))
											array(num).PumpFillage = Conversions.ToSingle(dataRow("PumpFillage"))
											array(num).PumpFriction = Conversions.ToSingle(dataRow("PumpFriction"))
											array(num).PumpIntakePressure = Conversions.ToSingle(dataRow("PumpIntakePressure"))
											array(num).PumpLoadAdj = Conversions.ToSingle(dataRow("PumpLoadAdj"))
											array(num).PumpType = Conversions.ToShort(dataRow("PumpType"))
											array(num).SPM = Conversions.ToSingle(dataRow("SPM"))
											array(num).CalcFriction = Conversions.ToBoolean(dataRow("CalcFriction"))
											array(num).DownstrokeFriction = Conversions.ToSingle(dataRow("DownstrokeFriction"))
											array(num).UpstrokeFriction = Conversions.ToSingle(dataRow("UpstrokeFriction"))
											If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow("XTimes"))) Then
												array(num).XTimes = Conversions.ToSingle(dataRow("XTimes"))
											Else
												array(num).XTimes = 1F
											End If
											array(num).Runtime = Conversions.ToSingle(dataRow("Runtime"))
											array(num).StuffingBoxFriction = Conversions.ToSingle(dataRow("StuffingBoxFriction"))
											array(num).TargetBFPD = Conversions.ToSingle(GURU_DB.EnDeCrypt(Conversions.ToString(dataRow("TargetBFPD"))))
											array(num).TubingAnchorDepth = Conversions.ToSingle(GURU_DB.EnDeCrypt(Conversions.ToString(dataRow("TubingAnchorDepth"))))
											array(num).TubingAnchored = Conversions.ToShort(dataRow("TubingAnchored"))
											array(num).TubingID = Conversions.ToSingle(dataRow("TubingID"))
											array(num).TubingOD = Conversions.ToSingle(dataRow("TubingOD"))
											array(num).TubingPressure = Conversions.ToSingle(dataRow("TubingPressure"))
											array(num).WaterCut = Conversions.ToSingle(dataRow("WaterCut"))
											array(num).WaterSPGR = Conversions.ToSingle(dataRow("WaterSPGR"))
											array(num).RodStringType = Conversions.ToShort(dataRow("RodStringType"))
											array(num).giRodDesignStyle = Conversions.ToShort(dataRow("giRodDesignStyle"))
											array(num).RSFGIncludeSteel = Conversions.ToShort(dataRow("RSFGIncludeSteel"))
											array(num).RSGrade = Conversions.ToShort(dataRow("RSGrade"))
											array(num).RSMaxSize = Conversions.ToSingle(dataRow("RSMaxSize"))
											array(num).RSMinSize = Conversions.ToSingle(dataRow("RSMinSize"))
											array(num).RSFricCoef = Conversions.ToSingle(dataRow("RSFricCoef"))
											array(num).RSIncludeSB = Conversions.ToShort(dataRow("RSIncludeSB"))
											array(num).SinkerBar_Grade = Conversions.ToShort(dataRow("SinkerBar_Grade"))
											array(num).SinkerBar_length = Conversions.ToSingle(dataRow("SinkerBar_length"))
											array(num).SinkerBar_Diameter = Conversions.ToSingle(dataRow("SinkerBar_Diameter"))
											array(num).RSFGGrade = Conversions.ToShort(dataRow("RSFGGrade"))
											array(num).RSExtraCost = Conversions.ToSingle(dataRow("RSExtraCost"))
											If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow("RSExtraCostLabel"))) Then
												array(num).RSExtraCostLabel = Conversions.ToString(dataRow("RSExtraCostLabel"))
											Else
												array(num).RSExtraCostLabel = ""
											End If
											array(num).ServiceFactor = Conversions.ToSingle(dataRow("ServiceFactor"))
											array(num).PU_CrankRotation = Conversions.ToShort(dataRow("PU_CrankRotation"))
											array(num).PU_CrankHole = Conversions.ToShort(dataRow("PU_CrankHole"))
											array(num).Unbalance = Conversions.ToSingle(dataRow("Unbalance"))
											array(num).Unit = Conversions.ToString(GURU_DB.EnDeCrypt(Conversions.ToString(dataRow("Unit"))))
											array(num).ID = Conversions.ToString(GURU_DB.EnDeCrypt(Conversions.ToString(dataRow("ID"))))
											array(num).DateAdded = Conversions.ToDate(dataRow("DateAdded"))
											array(num).Original = Conversions.ToShort(dataRow("Original"))
										Else
											array(num).FileName = Conversions.ToString(dataRow("FileName"))
											array(num).WellName = Conversions.ToString(dataRow("WellName"))
											array(num).gbCalcPumpCondition = Conversions.ToBoolean(dataRow("gbCalcPumpCondition"))
											array(num).PumpCondition = Conversions.ToShort(dataRow("PumpCondition"))
											array(num).IrotEntered = Conversions.ToBoolean(dataRow("IrotEntered"))
											array(num).CalcPlungerSize = Conversions.ToBoolean(dataRow("CalcPlungerSize"))
											array(num).gbCalcPumpIntakePressure = Conversions.ToBoolean(dataRow("gbCalcPumpIntakePressure"))
											array(num).CasingPressure = Conversions.ToSingle(dataRow("CasingPressure"))
											array(num).CompressibilityIndex = Conversions.ToSingle(dataRow("CompressibilityIndex"))
											array(num).ElectricityCost = Conversions.ToSingle(dataRow("ElectricityCost"))
											array(num).FluidDamping = Conversions.ToSingle(dataRow("FluidDamping"))
											array(num).FluidLevel = Conversions.ToSingle(dataRow("FluidLevel"))
											array(num).gbIncludeBuoyancy = Conversions.ToBoolean(dataRow("gbIncludeBuoyancy"))
											array(num).IncludeFluidInertia = Conversions.ToShort(dataRow("IncludeFluidInertia"))
											array(num).Iart = Conversions.ToSingle(dataRow("Iart"))
											array(num).Irot = Conversions.ToSingle(dataRow("Irot"))
											array(num).UnknownM = Conversions.ToBoolean(dataRow("UnknownM"))
											array(num).M_Existing = Conversions.ToSingle(dataRow("M_Existing"))
											array(num).CBEffect = Conversions.ToSingle(dataRow("CBEffect"))
											array(num).CBAngle = Conversions.ToSingle(dataRow("CBAngle"))
											array(num).CBDataType = Conversions.ToShort(dataRow("CBDataType"))
											array(num).CalcMotorSize = Conversions.ToBoolean(dataRow("CalcMotorSize"))
											array(num).IncludeMotorSPV = Conversions.ToBoolean(dataRow("IncludeMotorSPV"))
											array(num).MotorSPV = Conversions.ToSingle(dataRow("MotorSPV"))
											array(num).OilAPI = Conversions.ToSingle(dataRow("OilAPI"))
											array(num).PlungerSize = Conversions.ToSingle(dataRow("PlungerSize"))
											array(num).PowerMeterType = Conversions.ToShort(dataRow("PowerMeterType"))
											array(num).PumpDepth = Conversions.ToSingle(dataRow("PumpDepth"))
											array(num).PumpEfficiency = Conversions.ToSingle(dataRow("PumpEfficiency"))
											array(num).PumpFillage = Conversions.ToSingle(dataRow("PumpFillage"))
											array(num).PumpFriction = Conversions.ToSingle(dataRow("PumpFriction"))
											array(num).PumpIntakePressure = Conversions.ToSingle(dataRow("PumpIntakePressure"))
											array(num).PumpLoadAdj = Conversions.ToSingle(dataRow("PumpLoadAdj"))
											array(num).PumpType = Conversions.ToShort(dataRow("PumpType"))
											array(num).SPM = Conversions.ToSingle(dataRow("SPM"))
											array(num).CalcFriction = Conversions.ToBoolean(dataRow("CalcFriction"))
											array(num).DownstrokeFriction = Conversions.ToSingle(dataRow("DownstrokeFriction"))
											array(num).UpstrokeFriction = Conversions.ToSingle(dataRow("UpstrokeFriction"))
											If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow("XTimes"))) Then
												array(num).XTimes = Conversions.ToSingle(dataRow("XTimes"))
											Else
												array(num).XTimes = 1F
											End If
											array(num).Runtime = Conversions.ToSingle(dataRow("Runtime"))
											array(num).StuffingBoxFriction = Conversions.ToSingle(dataRow("StuffingBoxFriction"))
											array(num).TargetBFPD = Conversions.ToSingle(dataRow("TargetBFPD"))
											array(num).TubingAnchorDepth = Conversions.ToSingle(dataRow("TubingAnchorDepth"))
											array(num).TubingAnchored = Conversions.ToShort(dataRow("TubingAnchored"))
											array(num).TubingID = Conversions.ToSingle(dataRow("TubingID"))
											array(num).TubingOD = Conversions.ToSingle(dataRow("TubingOD"))
											array(num).TubingPressure = Conversions.ToSingle(dataRow("TubingPressure"))
											array(num).WaterCut = Conversions.ToSingle(dataRow("WaterCut"))
											array(num).WaterSPGR = Conversions.ToSingle(dataRow("WaterSPGR"))
											array(num).RodStringType = Conversions.ToShort(dataRow("RodStringType"))
											array(num).giRodDesignStyle = Conversions.ToShort(dataRow("giRodDesignStyle"))
											array(num).RSFGIncludeSteel = Conversions.ToShort(dataRow("RSFGIncludeSteel"))
											array(num).RSGrade = Conversions.ToShort(dataRow("RSGrade"))
											array(num).RSMaxSize = Conversions.ToSingle(dataRow("RSMaxSize"))
											array(num).RSMinSize = Conversions.ToSingle(dataRow("RSMinSize"))
											array(num).RSFricCoef = Conversions.ToSingle(dataRow("RSFricCoef"))
											array(num).RSIncludeSB = Conversions.ToShort(dataRow("RSIncludeSB"))
											array(num).SinkerBar_Grade = Conversions.ToShort(dataRow("SinkerBar_Grade"))
											array(num).SinkerBar_length = Conversions.ToSingle(dataRow("SinkerBar_length"))
											array(num).SinkerBar_Diameter = Conversions.ToSingle(dataRow("SinkerBar_Diameter"))
											array(num).RSFGGrade = Conversions.ToShort(dataRow("RSFGGrade"))
											array(num).RSExtraCost = Conversions.ToSingle(dataRow("RSExtraCost"))
											If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow("RSExtraCostLabel"))) Then
												array(num).RSExtraCostLabel = Conversions.ToString(dataRow("RSExtraCostLabel"))
											Else
												array(num).RSExtraCostLabel = ""
											End If
											array(num).ServiceFactor = Conversions.ToSingle(dataRow("ServiceFactor"))
											array(num).PU_CrankRotation = Conversions.ToShort(dataRow("PU_CrankRotation"))
											array(num).PU_CrankHole = Conversions.ToShort(dataRow("PU_CrankHole"))
											array(num).Unbalance = Conversions.ToSingle(dataRow("Unbalance"))
											array(num).Unit = Conversions.ToString(dataRow("Unit"))
											array(num).ID = Conversions.ToString(dataRow("ID"))
											array(num).DateAdded = Conversions.ToDate(dataRow("DateAdded"))
											array(num).Original = Conversions.ToShort(dataRow("Original"))
										End If
									Catch ex As Exception
									End Try
								Next
							Finally
								Dim enumerator As IEnumerator
								If TypeOf enumerator Is IDisposable Then
									TryCast(enumerator, IDisposable).Dispose()
								End If
							End Try
							Dim num2 As Integer = i
							If num2 > 0 Then
								Dim num3 As Integer = 1
								Dim num4 As Integer = num2
								i = num3
								While i <= num4
									Dim guruFileDataStructure As RSWIN_DESC.GuruFileDataStructure = array(i)
									guruFileDataStructure.DateAdded = DateAndTime.Now.[Date]
									guruFileDataStructure.Original = 0S
									If guruFileDataStructure.FluidLevel > guruFileDataStructure.PumpDepth Then
										guruFileDataStructure.FluidLevel = guruFileDataStructure.PumpDepth
									End If
									If guruFileDataStructure.TubingAnchorDepth > guruFileDataStructure.PumpDepth Then
										guruFileDataStructure.TubingAnchorDepth = guruFileDataStructure.PumpDepth
									End If
									Try
										GURU_DB.DBAddFiledata(guruFileDataStructure, True, True)
									Catch ex2 As Exception
									End Try
									i += 1
								End While
							End If
						End If
					Catch ex3 As Exception
					End Try
				End If
				Try
					If fileInfo3.Exists Then
						fileInfo3.Delete()
					End If
					File.Copy(text + RSWIN_DESC.sTemplateDBFileName, text + str)
				Catch ex4 As Exception
				End Try
			Catch ex5 As Exception
			End Try
		End Sub

		Public Sub LogTemplate(I As Integer)
			Try
				Debug.WriteLine(" FileName " + RSWIN_DESC.AllGuruFiles(I).FileName)
				Debug.WriteLine(" WellName " + RSWIN_DESC.AllGuruFiles(I).WellName)
				Debug.WriteLine(" gbCalcPumpCondition " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(I).gbCalcPumpCondition))
				Debug.WriteLine(" PumpCondition " + Conversions.ToString(CInt(RSWIN_DESC.AllGuruFiles(I).PumpCondition)))
				Debug.WriteLine(" IrotEntered " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(I).IrotEntered))
				Debug.WriteLine(" CalcPlungerSize " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(I).CalcPlungerSize))
				Debug.WriteLine(" gbCalcPumpIntakePressure " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(I).gbCalcPumpIntakePressure))
				Debug.WriteLine(" CasingPressure " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(I).CasingPressure))
				Debug.WriteLine(" CompressibilityIndex " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(I).CompressibilityIndex))
				Debug.WriteLine(" ElectricityCost " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(I).ElectricityCost))
				Debug.WriteLine(" FluidDamping " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(I).FluidDamping))
				Debug.WriteLine(" FluidLevel " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(I).FluidLevel))
				Debug.WriteLine(" gbIncludeBuoyancy " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(I).gbIncludeBuoyancy))
				Debug.WriteLine(" IncludeFluidInertia " + Conversions.ToString(CInt(RSWIN_DESC.AllGuruFiles(I).IncludeFluidInertia)))
				Debug.WriteLine(" Iart " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(I).Iart))
				Debug.WriteLine(" Irot " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(I).Irot))
				Debug.WriteLine(" UnknownM " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(I).UnknownM))
				Debug.WriteLine(" M_Existing " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(I).M_Existing))
				Debug.WriteLine(" CBEffect " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(I).CBEffect))
				Debug.WriteLine(" CBAngle " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(I).CBAngle))
				Debug.WriteLine(" CBDataType " + Conversions.ToString(CInt(RSWIN_DESC.AllGuruFiles(I).CBDataType)))
				Debug.WriteLine(" CalcMotorSize " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(I).CalcMotorSize))
				Debug.WriteLine(" IncludeMotorSPV " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(I).IncludeMotorSPV))
				Debug.WriteLine(" MotorSPV " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(I).MotorSPV))
				Debug.WriteLine(" OilAPI " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(I).OilAPI))
				Debug.WriteLine(" PlungerSize " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(I).PlungerSize))
				Debug.WriteLine(" PowerMeterType " + Conversions.ToString(CInt(RSWIN_DESC.AllGuruFiles(I).PowerMeterType)))
				Debug.WriteLine(" PumpDepth " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(I).PumpDepth))
				Debug.WriteLine(" PumpEfficiency " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(I).PumpEfficiency))
				Debug.WriteLine(" PumpFillage " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(I).PumpFillage))
				Debug.WriteLine(" PumpFriction " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(I).PumpFriction))
				Debug.WriteLine(" PumpIntakePressure " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(I).PumpIntakePressure))
				Debug.WriteLine(" PumpLoadAdj " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(I).PumpLoadAdj))
				Debug.WriteLine(" PumpType " + Conversions.ToString(CInt(RSWIN_DESC.AllGuruFiles(I).PumpType)))
				Debug.WriteLine(" SPM " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(I).SPM))
				Debug.WriteLine(" CalcFriction " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(I).CalcFriction))
				Debug.WriteLine(" DownstrokeFriction " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(I).DownstrokeFriction))
				Debug.WriteLine(" UpstrokeFriction " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(I).UpstrokeFriction))
				Debug.WriteLine(" XTimes " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(I).XTimes))
				Debug.WriteLine(" Runtime " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(I).Runtime))
				Debug.WriteLine(" StuffingBoxFriction " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(I).StuffingBoxFriction))
				Debug.WriteLine(" TargetBFPD " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(I).TargetBFPD))
				Debug.WriteLine(" TubingAnchorDepth " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(I).TubingAnchorDepth))
				Debug.WriteLine(" TubingAnchored " + Conversions.ToString(CInt(RSWIN_DESC.AllGuruFiles(I).TubingAnchored)))
				Debug.WriteLine(" TubingID " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(I).TubingID))
				Debug.WriteLine(" TubingOD " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(I).TubingOD))
				Debug.WriteLine(" TubingPressure " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(I).TubingPressure))
				Debug.WriteLine(" WaterCut " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(I).WaterCut))
				Debug.WriteLine(" WaterSPGR " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(I).WaterSPGR))
				Debug.WriteLine(" RodStringType " + Conversions.ToString(CInt(RSWIN_DESC.AllGuruFiles(I).RodStringType)))
				Debug.WriteLine(" giRodDesignStyle " + Conversions.ToString(CInt(RSWIN_DESC.AllGuruFiles(I).giRodDesignStyle)))
				Debug.WriteLine(" RSFGIncludeSteel " + Conversions.ToString(CInt(RSWIN_DESC.AllGuruFiles(I).RSFGIncludeSteel)))
				Debug.WriteLine(" RSGrade " + Conversions.ToString(CInt(RSWIN_DESC.AllGuruFiles(I).RSGrade)))
				Debug.WriteLine(" RSMaxSize " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(I).RSMaxSize))
				Debug.WriteLine(" RSMinSize " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(I).RSMinSize))
				Debug.WriteLine(" RSFricCoef " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(I).RSFricCoef))
				Debug.WriteLine(" RSIncludeSB " + Conversions.ToString(CInt(RSWIN_DESC.AllGuruFiles(I).RSIncludeSB)))
				Debug.WriteLine(" SinkerBar_Grade " + Conversions.ToString(CInt(RSWIN_DESC.AllGuruFiles(I).SinkerBar_Grade)))
				Debug.WriteLine(" SinkerBar_length " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(I).SinkerBar_length))
				Debug.WriteLine(" SinkerBar_Diameter " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(I).SinkerBar_Diameter))
				Debug.WriteLine(" RSFGGrade " + Conversions.ToString(CInt(RSWIN_DESC.AllGuruFiles(I).RSFGGrade)))
				Debug.WriteLine(" RSExtraCost " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(I).RSExtraCost))
				Debug.WriteLine(" RSExtraCostLabel " + RSWIN_DESC.AllGuruFiles(I).RSExtraCostLabel)
				Debug.WriteLine(" SlideFricCoeff " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(I).SlideFricCoeff))
				Debug.WriteLine(" ServiceFactor " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(I).ServiceFactor))
				Debug.WriteLine(" PU_CrankRotation " + Conversions.ToString(CInt(RSWIN_DESC.AllGuruFiles(I).PU_CrankRotation)))
				Debug.WriteLine(" PU_CrankHole " + Conversions.ToString(CInt(RSWIN_DESC.AllGuruFiles(I).PU_CrankHole)))
				Debug.WriteLine(" Unbalance " + Conversions.ToString(RSWIN_DESC.AllGuruFiles(I).Unbalance))
				Debug.WriteLine(" Unit " + RSWIN_DESC.AllGuruFiles(I).Unit)
				Debug.WriteLine(" ID " + RSWIN_DESC.AllGuruFiles(I).ID)
			Catch ex As Exception
			End Try
		End Sub

		Private myFile As cGuruFileData

		Private g_strConn As String

		Private bDBOpened As Short

		Private DBPath As String

		Private sbox As Object() = New Object(255) {}

		Private key As Object() = New Object(255) {}
	End Module
End Namespace
