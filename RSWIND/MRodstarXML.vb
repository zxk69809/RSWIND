Imports System
Imports System.Collections
Imports System.Data
Imports System.Diagnostics
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Windows.Forms
Imports System.Xml
Imports System.Xml.Schema
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.Compatibility.VB6
Imports Microsoft.VisualBasic.CompilerServices
Imports ThetaStdInfo

Namespace RSWINV3
	Friend NotInheritable Module MRodstarXML
		Public Property bCustomPU As Boolean
			Get
				Return MRodstarXML.m_bCustomPU
			End Get
			Set(value As Boolean)
				MRodstarXML.m_bCustomPU = value
			End Set
		End Property

		Public Property bErrorCustomPU As Boolean
			Get
				Return MRodstarXML.m_bErrorCustomPU
			End Get
			Set(value As Boolean)
				MRodstarXML.m_bErrorCustomPU = value
			End Set
		End Property

		Public Function ValidateXML(sFileName As String) As Boolean
			Dim xmlTextReader As XmlTextReader = New XmlTextReader(sFileName)
			Dim xmlValidatingReader As XmlValidatingReader = New XmlValidatingReader(xmlTextReader)
			Dim nametable As XmlNameTable = New NameTable()
			Dim xmlSchemaCollection As XmlSchemaCollection = New XmlSchemaCollection(nametable)
			Try
				xmlValidatingReader = New XmlValidatingReader(xmlTextReader)
				xmlSchemaCollection.Add(Nothing, Application.StartupPath + "\rodstar-schema.xsd")
			Catch ex As XmlException
				MessageBox.Show(ex.Message)
			End Try
			Try
				For Each schema As XmlSchema In xmlSchemaCollection
					xmlValidatingReader.Schemas.Add(schema)
				Next
			Catch ex2 As XmlException
				MessageBox.Show(ex2.Message)
			End Try
			xmlValidatingReader.ValidationType = ValidationType.Schema
			Dim flag As Boolean = False
			Dim flag2 As Boolean
			Try
				flag2 = xmlValidatingReader.Read()
				GoTo IL_FC
			Catch ex3 As XmlException
				flag2 = False
				flag = True
				Dim message As String = ex3.Message
				GoTo IL_FC
			End Try
			Try
				IL_D6:
				flag2 = xmlValidatingReader.Read()
			Catch ex4 As XmlException
				flag2 = False
				flag = True
				Dim message As String = ex4.Message
			End Try
			IL_FC:
			If Not flag2 OrElse Not flag Then
				Try
					xmlTextReader.Close()
					xmlValidatingReader.Close()
				Catch ex5 As Exception
				End Try
				Return flag
			End If
			GoTo IL_D6
		End Function

		Public Function LoadRodstarXML(ByRef sFileName As String) As Boolean
			Dim flag As Boolean = False
			Dim nametable As XmlNameTable = New NameTable()
			Dim xmlSchemaCollection As XmlSchemaCollection = New XmlSchemaCollection(nametable)
			Dim result As Boolean
			Try
				If Not RSWIN_DESC.bRodStarD Then
					RSWIN_DESC.bQuickFix = False
				End If
				Dim text As String = "SaveXDIAGMeasuredCard"
				Dim flag2 As Boolean = True
				RSWIN_DESC.SETUP_SaveXDIAGMeasuredCard = If((-If((RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_GENERAL, text, flag2) > False), 1S, 0S)), 1S, 0S)
				MRodstarXML.SetupLookups()
				Dim xmlDocument As XmlDocument = New XmlDocument()
				Dim xmlDocument2 As XmlDocument = xmlDocument
				Try
					xmlDocument2.Load(sFileName)
				Catch ex As Exception
				End Try
				Dim xmlNamespaceManager As XmlNamespaceManager
				Try
					xmlNamespaceManager = New XmlNamespaceManager(xmlDocument.NameTable)
					xmlNamespaceManager.AddNamespace("r", "urn:schemas-gotheta-com:rodstar")
				Catch ex2 As XmlException
					MessageBox.Show(ex2.Message)
				End Try
				Dim cRODSTAR As cRODSTAR = RSWIN_DESC.rst
				Dim flag3 As Boolean = (Strings.InStr(sFileName, ".xrvx", CompareMethod.Binary) > 0 Or LikeOperator.LikeString(Strings.LCase(sFileName), "*.xrvx", CompareMethod.Binary)) And RSWIN_DESC.SETUP_bGuru
				Dim flag4 As Boolean = MRodstarXML.LoadInputXML(xmlDocument, xmlNamespaceManager, flag3)
				If Not(RSWIN_DESC.rst.RodStringType = 3S And (RSWIN_DESC.rst.giRodDesignStyle = 1S Or RSWIN_DESC.rst.giRodDesignStyle = 0S)) Then
					If flag4 And RSWIN_DESC.bRodStarD Then
						If MRodstarXML.AllNoGuides(flag, True) Then
							MRodstarXML.ChangeGuidesToSetup()
						ElseIf MRodstarXML.GuideExceptionInFile() And Not flag And Not RSWIN_DESC.rst.gbBatch And Not RSWIN_DESC.bDisplayingBatchOutput Then
							Dim dlgGuides As dlgGuides = New dlgGuides()
							Dim dlgGuides2 As dlgGuides = dlgGuides
							If dlgGuides2.Height > RSWIN_DESC.frmMain.Height Then
								dlgGuides2.Height = RSWIN_DESC.frmMain.Height
								dlgGuides2.Top = RSWIN_DESC.frmMain.Top
							End If
							dlgGuides2.ShowDialog()
							If dlgGuides2.bUseSetup Then
								MRodstarXML.ChangeGuidesToSetup()
							ElseIf dlgGuides2.bUseFile AndAlso dlgGuides2.bOverwriteSetup Then
								RSWIN_DESC.SETUP_GuideToUse = dlgGuides2.GuideInFileToUse
								text = "GuideToUse"
								Dim text2 As String = Conversions.ToString(RSWIN_DESC.SETUP_GuideToUse)
								RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text, text2, RSWIN_DESC.sINIFile)
								RSWIN_DESC.SETUP_GuideToUse = Conversions.ToInteger(text2)
							End If
						End If
					End If
				ElseIf RSWIN_DESC.rst.RodStringType = 3S Then
					If RSWIN_DESC.rst.RSRodGuide = 0 And Not RSWIN_DESC.rst.gbBatch And RSWIN_DESC.bRodStarD Then
						MessageBox.Show(RSWIN_DESC.sNoGuidesInFile)
					ElseIf RSWIN_DESC.rst.RSRodGuide <> RSWIN_DESC.SETUP_GuideToUse And Not RSWIN_DESC.rst.gbBatch And RSWIN_DESC.bRodStarD Then
						Dim dlgGuides3 As dlgGuides = New dlgGuides()
						Dim dlgGuides4 As dlgGuides = dlgGuides3
						If dlgGuides4.Height > RSWIN_DESC.frmMain.Height Then
							dlgGuides4.Height = RSWIN_DESC.frmMain.Height
							dlgGuides4.Top = RSWIN_DESC.frmMain.Top
						End If
						dlgGuides4.ShowDialog()
						If dlgGuides4.bUseSetup Then
							RSWIN_DESC.rst.RSRodGuide = RSWIN_DESC.SETUP_GuideToUse
						ElseIf dlgGuides4.bUseFile AndAlso dlgGuides4.bOverwriteSetup Then
							RSWIN_DESC.SETUP_GuideToUse = RSWIN_DESC.rst.RSRodGuide
							Dim text2 As String = "GuideToUse"
							text = Conversions.ToString(RSWIN_DESC.SETUP_GuideToUse)
							RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text, RSWIN_DESC.sINIFile)
							RSWIN_DESC.SETUP_GuideToUse = Conversions.ToInteger(text)
						End If
					End If
				End If
				Dim flag5 As Boolean
				If RSWIN_DESC.bRodStarD And Not RSWIN_DESC.rst.bSaveFlag Then
					flag5 = True
					cRODSTAR.gbOutputLoaded = False
				ElseIf(RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru) AndAlso flag3 Then
					flag5 = True
					cRODSTAR.gbOutputLoaded = False
				ElseIf Not flag4 Then
					flag5 = False
					cRODSTAR.gbOutputLoaded = False
				ElseIf RSWIN_DESC.bRodStarD Then
					flag5 = MRodstarXML.LoadOutputXML(xmlDocument, xmlNamespaceManager)
				ElseIf Not RSWIN_DESC.bRodStarD And (Strings.InStr(sFileName, "rsvx", CompareMethod.Binary) > 0 Or Strings.InStr(sFileName, "RSVX", CompareMethod.Binary) > 0 Or Strings.InStr(sFileName, "xrvx", CompareMethod.Binary) > 0 Or Strings.InStr(sFileName, "XRVX", CompareMethod.Binary) > 0) Then
					If RSWIN_DESC.rst.bSaveFlag Then
						flag5 = True
						cRODSTAR.gbOutputLoaded = False
					Else
						flag5 = MRodstarXML.LoadOutputXML(xmlDocument, xmlNamespaceManager)
					End If
				ElseIf Not RSWIN_DESC.bRodStarD Then
					flag5 = True
					cRODSTAR.gbOutputLoaded = False
				End If
				If cRODSTAR.PU.UnitType = 8S Or (RSWIN_DESC.rst.PU.UnitType = 11S And Not RSWIN_DESC.rst.bUseCrankBalancedCalcs) Then
					RSWIN_DESC.bBeamBalanced = True
				Else
					RSWIN_DESC.bBeamBalanced = False
				End If
				If cRODSTAR.gbOutputLoaded Then
					Try
						Dim rst As cRODSTAR = RSWIN_DESC.rst
						RSWIN_DESC.bBalancedEVarsOverwritten = False
						Dim num As Integer = 1
						If Not(rst.PU.UnitType = 8S Or RSWIN_DESC.bBeamBalanced) And rst.get_M(2) = 0F Then
							rst.UnknownM = True
						End If
						If((Not(rst.PU.UnitType = 8S Or RSWIN_DESC.bBeamBalanced) And Not rst.UnknownM) Or ((RSWIN_DESC.rst.PU.UnitType = 8S Or RSWIN_DESC.bBeamBalanced) And Not rst.bUnknownUnbalance)) And rst.get_ElectricBillperMonth(2) < rst.get_ElectricBillperMonth(1) Then
							num = 2
						End If
						If((If((-If((CDbl(rst.get_ElectricBillperMonth(0)) >= 0.99 * CDbl(rst.get_ElectricBillperMonth(num)) > False), 1S, 0S)), 1S, 0S) And Not RSWIN_DESC.DEBUG_ShowAllBalanced) Or If((-If(((RSWIN_DESC.rst.PU.UnitType = 10S) > False), 1S, 0S)), 1S, 0S)) <> 0S Then
							RSWIN_DESC.bBalancedEVarsOverwritten = True
							RSWIN_DESC.iOverWriteIndex = num
						End If
					Catch ex3 As Exception
						RSWIN_DESC.bBalancedEVarsOverwritten = False
					End Try
				End If
				Dim flag6 As Boolean
				If cRODSTAR.gbBatch Then
					flag6 = flag4
				Else
					flag6 = (flag4 AndAlso flag5)
				End If
				If flag6 Then
					MRodstarXML.CheckInputData(sFileName)
				End If
				result = flag6
				Try
					xmlDocument = Nothing
					xmlNamespaceManager = Nothing
				Catch ex4 As Exception
				End Try
				cRODSTAR = Nothing
			Catch ex5 As XmlException
				MessageBox.Show(ex5.Message)
				result = False
			End Try
			Return result
		End Function

		Public Function LoadRodstarXML_DeviationOnly(ByRef sFileName As String, ByRef iCount As Integer) As Boolean
			Dim nametable As XmlNameTable = New NameTable()
			Dim xmlSchemaCollection As XmlSchemaCollection = New XmlSchemaCollection(nametable)
			Dim result As Boolean
			Try
				Try
					Dim xmlDocument As XmlDocument = New XmlDocument()
					Dim xmlDocument2 As XmlDocument = xmlDocument
					Try
						xmlDocument2.Load(sFileName)
					Catch ex As Exception
					End Try
					Dim xmlNamespaceManager As XmlNamespaceManager
					Try
						xmlNamespaceManager = New XmlNamespaceManager(xmlDocument.NameTable)
						xmlNamespaceManager.AddNamespace("r", "urn:schemas-gotheta-com:rodstar")
					Catch ex2 As XmlException
						MessageBox.Show(ex2.Message)
					End Try
					Dim rst As cRODSTAR = RSWIN_DESC.rst
					result = MRodstarXML.LoadInputXML_DeviationOnly(xmlDocument, xmlNamespaceManager, iCount)
				Catch ex3 As XmlException
					MessageBox.Show(ex3.Message)
					result = False
				End Try
			Catch ex4 As Exception
				result = False
			End Try
			Return result
		End Function

		Public Function StoreXML(sFileName As String, bStoreOutput As Boolean, ByRef bInputStored As Boolean, ByRef bOutputStored As Boolean) As Boolean
			Dim result As Boolean
			Try
				Dim encoding As ASCIIEncoding = New ASCIIEncoding()
				Dim xmlTextWriter As XmlTextWriter = New XmlTextWriter(sFileName, encoding)
				Dim bXROD As Boolean = False
				Dim flag As Boolean = True
				If RSWIN_DESC.bExpert And Strings.InStr(sFileName.ToLower(), ".xrvx", CompareMethod.Binary) > 0 Then
					bXROD = True
				End If
				MRodstarXML.SetupLookups()
				Dim xmlTextWriter2 As XmlTextWriter = xmlTextWriter
				xmlTextWriter2.Namespaces = True
				xmlTextWriter2.WriteStartDocument(False)
				xmlTextWriter2.Formatting = Formatting.Indented
				xmlTextWriter2.WriteStartElement("r:rodstar")
				xmlTextWriter2.WriteAttributeString("xmlns:r", "urn:schemas-gotheta-com:rodstar")
				xmlTextWriter2.WriteAttributeString("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance")
				bInputStored = MRodstarXML.StoreInputXML(xmlTextWriter, bXROD)
				flag = bInputStored
				If bInputStored AndAlso bStoreOutput Then
					bOutputStored = MRodstarXML.StoreOutputXML(xmlTextWriter)
					flag = bOutputStored
				End If
				Try
					xmlTextWriter.WriteEndElement()
				Catch ex As Exception
				End Try
				Try
					xmlTextWriter.WriteEndDocument()
				Catch ex2 As Exception
				End Try
				Try
					xmlTextWriter.Close()
				Catch ex3 As Exception
				End Try
				result = flag
			Catch ex4 As Exception
				result = False
			End Try
			Return result
		End Function

		Private Sub AddAttribute(ByRef rNode As XmlNode, ByRef sTagName As String, ByRef sValue As String)
			Dim num As Integer
			Dim num2 As Integer
			Dim obj As Object
			Try
				ProjectData.ClearProjectError()
				num = 2
				Dim xmlNode As XmlNode = rNode
				Dim namedItem As XmlAttribute = xmlNode.OwnerDocument.CreateAttribute(sTagName)
				xmlNode.Attributes.SetNamedItem(namedItem)
				IL_29:
				GoTo IL_6C
				IL_2B:
				num2 = -1
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_3F:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num2 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_2B
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_6C:
			If num2 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		Private Function AddBooleanElement(ByRef myWriter As XmlTextWriter, ByRef sTagName As String, bValue As Boolean) As Boolean
			Dim result As Boolean = True
			Try
				Dim xmlTextWriter As XmlTextWriter = myWriter
				xmlTextWriter.WriteStartElement(sTagName)
				If Not bValue Then
					xmlTextWriter.WriteString("0")
				Else
					xmlTextWriter.WriteString("-1")
				End If
				xmlTextWriter.WriteEndElement()
			Catch ex As Exception
				result = False
			End Try
			Return result
		End Function

		Private Function AddBooleanElement(ByRef rElt As XmlElement, ByRef sTagName As String, bValue As Boolean) As Boolean
			Dim result As Boolean = True
			Try
				Dim ownerDocument As XmlDocument = rElt.OwnerDocument
				Dim xmlElement As XmlElement = ownerDocument.CreateElement(sTagName)
				If bValue Then
					xmlElement.AppendChild(ownerDocument.CreateTextNode("1"))
				Else
					xmlElement.AppendChild(ownerDocument.CreateTextNode("0"))
				End If
				rElt.AppendChild(xmlElement)
			Catch ex As Exception
				result = False
			End Try
			Return result
		End Function

		Public Function AddDecimalElement(ByRef myWriter As XmlTextWriter, ByRef sTagName As String, fValue As Double) As Boolean
			Dim array As Integer() = New Integer(1) {}
			Dim result As Boolean = True
			Try
				Dim xmlTextWriter As XmlTextWriter = myWriter
				xmlTextWriter.WriteStartElement(sTagName)
				xmlTextWriter.WriteString(Convert.ToString(fValue))
				xmlTextWriter.WriteEndElement()
			Catch ex As Exception
				result = False
			End Try
			Return result
		End Function

		Private Function AddDecimalElement(ByRef rElt As XmlElement, ByRef sTagName As String, fValue As Double) As Boolean
			Dim array As Integer() = New Integer(1) {}
			Dim result As Boolean = True
			Try
				Dim ownerDocument As XmlDocument = rElt.OwnerDocument
				Dim xmlElement As XmlElement = ownerDocument.CreateElement(sTagName)
				xmlElement.AppendChild(ownerDocument.CreateTextNode(Convert.ToString(fValue)))
				rElt.AppendChild(xmlElement)
			Catch ex As Exception
				result = False
			End Try
			Return result
		End Function

		Private Sub AddCrankRadii(ByRef myWriter As XmlTextWriter)
			' The following expression was wrapped in a checked-statement
			Try
				If RSWIN_DESC.rst.PU.CrankHoles = 0S Then
					Dim text As String = "r:pu-crank-radii"
					MRodstarXML.AddNilElement(myWriter, text)
				Else
					Dim xmlTextWriter As XmlTextWriter = myWriter
					xmlTextWriter.WriteStartElement("r:pu-crank-radii")
					Dim num As Integer = 1
					Dim crankHoles As Integer = CInt(RSWIN_DESC.rst.PU.CrankHoles)
					For i As Integer = num To crankHoles
						xmlTextWriter.WriteStartElement("r:crank-radius")
						xmlTextWriter.WriteAttributeString("Order", i.ToString())
						Dim text As String = "r:pu-apidimension-r"
						MRodstarXML.AddDecimalElement(myWriter, text, CDbl(RSWIN_DESC.rst.PU.CrankRadii(i - 1)))
						text = "r:nominal-stroke-length"
						MRodstarXML.AddDecimalElement(myWriter, text, CDbl(RSWIN_DESC.rst.PU.Strokes(i - 1)))
						xmlTextWriter.WriteEndElement()
					Next
					xmlTextWriter.WriteEndElement()
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub AddDeviationSurvey(ByRef myWriter As XmlTextWriter)
			' The following expression was wrapped in a checked-statement
			Try
				Dim flag As Boolean = False
				If RSWIN_DESC.mdsDeviationProfile Is Nothing Then
					Dim value As String = "r:deviation-survey"
					MRodstarXML.AddNilElement(myWriter, value)
				ElseIf RSWIN_DESC.mdsDeviationProfile.Tables(0).Rows.Count = 0 Then
					Dim value As String = "r:deviation-survey"
					MRodstarXML.AddNilElement(myWriter, value)
				Else
					Dim xmlTextWriter As XmlTextWriter = myWriter
					flag = True
					xmlTextWriter.WriteStartElement("r:deviation-survey")
					Dim num As Integer = 0
					Dim dataView As DataView = New DataView(RSWIN_DESC.mdsDeviationProfile.Tables(0))
					dataView.Sort = "Depth"
					Try
						For Each obj As Object In dataView
							Dim dataRowView As DataRowView = CType(obj, DataRowView)
							Dim row As DataRow = dataRowView.Row
							Dim flag2 As Boolean = False
							If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(row("Depth"))) Then
								num += 1
								If Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(row("Depth"))) Then
									If num = 1 Or (num > 1 And Util.ConvertToSingle(Conversions.ToString(row("Depth"))) > 0F) Then
										flag2 = True
										xmlTextWriter.WriteStartElement("r:survey-point")
										xmlTextWriter.WriteAttributeString("Order", num.ToString())
										Dim value As String = "r:measured-depth"
										MRodstarXML.AddDecimalElement(myWriter, value, Conversions.ToDouble(row("Depth")))
										If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(row("Azimuth"))) Then
											If Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(row("Azimuth"))) Then
												value = "r:azimuth"
												Dim dataRow As DataRow = row
												Dim dataRow2 As DataRow = dataRow
												Dim columnName As String = "Azimuth"
												Dim value2 As String = Conversions.ToString(dataRow2(columnName))
												MRodstarXML.AddStringElement(myWriter, value, value2, False)
												dataRow(columnName) = value2
											Else
												Dim value2 As String = "r:azimuth"
												Dim dataRow As DataRow = row
												Dim dataRow3 As DataRow = dataRow
												Dim columnName As String = "Azimuth"
												value = Conversions.ToString(dataRow3(columnName))
												MRodstarXML.AddStringElement(myWriter, value2, value, False)
												dataRow(columnName) = value
											End If
										Else
											Dim value2 As String = "r:azimuth"
											Dim columnName As String = ""
											MRodstarXML.AddStringElement(myWriter, value2, columnName, False)
										End If
										If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(row("Inclination"))) Then
											If Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(row("Inclination"))) Then
												Dim value2 As String = "r:inclination"
												Dim dataRow As DataRow = row
												Dim dataRow4 As DataRow = dataRow
												Dim columnName As String = "Inclination"
												value = Conversions.ToString(dataRow4(columnName))
												MRodstarXML.AddStringElement(myWriter, value2, value, False)
												dataRow(columnName) = value
											Else
												Dim value2 As String = "r:inclination"
												Dim dataRow As DataRow = row
												Dim dataRow5 As DataRow = dataRow
												Dim columnName As String = "Inclination"
												value = Conversions.ToString(dataRow5(columnName))
												MRodstarXML.AddStringElement(myWriter, value2, value, False)
												dataRow(columnName) = value
											End If
										Else
											Dim value2 As String = "r:inclination"
											Dim columnName As String = ""
											MRodstarXML.AddStringElement(myWriter, value2, columnName, False)
										End If
									End If
									If flag2 Then
										xmlTextWriter.WriteEndElement()
									End If
								End If
							ElseIf RSWIN_DESC.mdsDeviationProfile.Tables(0).Rows.Count > 0 And num = 0 Then
								num += 1
								xmlTextWriter.WriteStartElement("r:survey-point")
								xmlTextWriter.WriteAttributeString("Order", num.ToString())
								Dim value2 As String = "r:measured-depth"
								MRodstarXML.AddDecimalElement(myWriter, value2, Conversions.ToDouble("0.0"))
								value2 = "r:azimuth"
								Dim columnName As String = "0.0"
								MRodstarXML.AddStringElement(myWriter, value2, columnName, False)
								value2 = "r:inclination"
								columnName = "0.0"
								MRodstarXML.AddStringElement(myWriter, value2, columnName, False)
								xmlTextWriter.WriteEndElement()
							End If
						Next
					Finally
						Dim enumerator As IEnumerator
						If TypeOf enumerator Is IDisposable Then
							TryCast(enumerator, IDisposable).Dispose()
						End If
					End Try
				End If
				If flag Then
					myWriter.WriteEndElement()
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Function AddDeviationSurvey(ByRef rElt As XmlElement) As Boolean
			Dim result As Boolean = True
			Try
				If RSWIN_DESC.mdsDeviationProfile Is Nothing Then
					Dim value As String = "r:deviation-survey"
					MRodstarXML.AddNilElement(rElt, value)
				ElseIf RSWIN_DESC.mdsDeviationProfile.Tables(0).Rows.Count = 0 Then
					Dim value As String = "r:deviation-survey"
					MRodstarXML.AddNilElement(rElt, value)
				Else
					Dim ownerDocument As XmlDocument = rElt.OwnerDocument
					Dim xmlElement As XmlElement = ownerDocument.CreateElement("r:deviation-survey")
					Dim num As Integer = 0
					Try
						For Each obj As Object In RSWIN_DESC.mdsDeviationProfile.Tables(0).Rows
							Dim dataRow As DataRow = CType(obj, DataRow)
							If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow("Depth"))) Then
								num += 1
								Dim xmlElement2 As XmlElement = ownerDocument.CreateElement("r:survey-point")
								Dim value As String = "r:measured-depth"
								result = MRodstarXML.AddDecimalElement(xmlElement2, value, Conversions.ToDouble(dataRow("Depth")))
								value = "r:azimuth"
								Dim dataRow2 As DataRow = dataRow
								Dim dataRow3 As DataRow = dataRow2
								Dim columnName As String = "Azimuth"
								Dim value2 As String = Conversions.ToString(dataRow3(columnName))
								Dim flag As Boolean = MRodstarXML.AddStringElement(xmlElement2, value, value2, False)
								dataRow2(columnName) = value2
								result = flag
								value2 = "r:inclination"
								dataRow2 = dataRow
								Dim dataRow4 As DataRow = dataRow2
								columnName = "Inclination"
								value = Conversions.ToString(dataRow4(columnName))
								Dim flag2 As Boolean = MRodstarXML.AddStringElement(xmlElement2, value2, value, False)
								dataRow2(columnName) = value
								result = flag2
								xmlElement2.SetAttribute("order", Convert.ToString(num))
								xmlElement.AppendChild(xmlElement2)
							End If
						Next
					Finally
						Dim enumerator As IEnumerator
						If TypeOf enumerator Is IDisposable Then
							TryCast(enumerator, IDisposable).Dispose()
						End If
					End Try
					rElt.AppendChild(xmlElement)
				End If
			Catch ex As Exception
				result = False
			End Try
			Return result
		End Function

		Private Sub AddDragProportionalityElement(ByRef myWriter As XmlTextWriter, ByRef sTagName As String, lValue As Integer)
			Try
				Dim text As String
				Select Case lValue
					Case 0
						text = "constant"
					Case 1
						text = "velocity"
					Case 2
						text = "velocity-squared"
				End Select
				MRodstarXML.AddStringElement(myWriter, sTagName, text, False)
			Catch ex As Exception
			End Try
		End Sub

		Private Sub AddDragProportionalityElement(ByRef rElt As XmlElement, ByRef sTagName As String, lValue As Integer)
			Try
				Dim text As String
				Select Case lValue
					Case 0
						text = "constant"
					Case 1
						text = "velocity"
					Case 2
						text = "velocity-squared"
				End Select
				MRodstarXML.AddStringElement(rElt, sTagName, text, False)
			Catch ex As Exception
			End Try
		End Sub

		Private Sub AddIntegerElement(ByRef myWriter As XmlTextWriter, ByRef sTagName As String, lValue As Integer)
			Try
				Dim xmlTextWriter As XmlTextWriter = myWriter
				xmlTextWriter.WriteStartElement(sTagName)
				xmlTextWriter.WriteString(Convert.ToString(lValue))
				xmlTextWriter.WriteEndElement()
			Catch ex As Exception
			End Try
		End Sub

		Private Sub AddIntegerElement(ByRef rElt As XmlElement, ByRef sTagName As String, lValue As Integer)
			Try
				Dim ownerDocument As XmlDocument = rElt.OwnerDocument
				Dim xmlElement As XmlElement = ownerDocument.CreateElement(sTagName)
				xmlElement.AppendChild(ownerDocument.CreateTextNode(Convert.ToString(lValue)))
				rElt.AppendChild(xmlElement)
			Catch ex As Exception
			End Try
		End Sub

		Private Sub AddIPRProfile(ByRef myWriter As XmlTextWriter)
			Try
				If Not RSWIN_DESC.rst.gbUseIPR Then
					Dim text As String = "r:ipr-profile"
					MRodstarXML.AddNilElement(myWriter, text)
				Else
					Dim xmlTextWriter As XmlTextWriter = myWriter
					xmlTextWriter.WriteStartElement("r:ipr-profile")
					Dim text As String = "r:bubble-point-pressure"
					MRodstarXML.AddDecimalElement(myWriter, text, CDbl(RSWIN_DESC.rst.BubblePoint))
					text = "r:calc-fetkovich-n"
					MRodstarXML.AddBooleanElement(myWriter, text, RSWIN_DESC.rst.gbCalcFetkovichN)
					text = "r:producing-below-bubble-point"
					MRodstarXML.AddDecimalElement(myWriter, text, -(RSWIN_DESC.rst.gbProducingBelowBPP > False))
					text = "r:fetkovich-n"
					MRodstarXML.AddDecimalElement(myWriter, text, CDbl(RSWIN_DESC.rst.FetkovichN))
					text = "r:ipr-correlation"
					Dim text2 As String = Convert.ToString(RuntimeHelpers.GetObjectValue(MRodstarXML.DoLookup(MRodstarXML.mnLookupIPRCorrelation, RSWIN_DESC.rst.giIPRMethod)))
					MRodstarXML.AddStringElement(myWriter, text, text2, False)
					text2 = "r:mid-perf-depth"
					MRodstarXML.AddDecimalElement(myWriter, text2, CDbl(RSWIN_DESC.rst.MidPerfDepth))
					text2 = "r:producing-below-bubble-point"
					MRodstarXML.AddBooleanElement(myWriter, text2, RSWIN_DESC.rst.gbProducingBelowBPP)
					text2 = "r:static-bottom-hole-pressure"
					MRodstarXML.AddDecimalElement(myWriter, text2, CDbl(RSWIN_DESC.rst.StaticBHPressure))
					xmlTextWriter.WriteStartElement("r:ipr-test-points")
					Dim num As Integer = 1
					Dim gnTestPoints As Integer = CInt(RSWIN_DESC.rst.gnTestPoints)
					For i As Integer = num To gnTestPoints
						xmlTextWriter.WriteStartElement("r:ipr-test-point")
						xmlTextWriter.WriteAttributeString("Order", i.ToString())
						text2 = "r:fluid-production"
						MRodstarXML.AddDecimalElement(myWriter, text2, CDbl(RSWIN_DESC.rst.TestPoints(i).Production))
						If RSWIN_DESC.rst.TestPoints(i).bPIEntered <> 0S Then
							text2 = "r:pump-intake-pressure"
							MRodstarXML.AddDecimalElement(myWriter, text2, CDbl(RSWIN_DESC.rst.TestPoints(i).Pintake))
						Else
							text2 = "r:flowing-wellbore-pressure"
							MRodstarXML.AddDecimalElement(myWriter, text2, CDbl(RSWIN_DESC.rst.TestPoints(i).Pwf))
						End If
						xmlTextWriter.WriteEndElement()
					Next
					xmlTextWriter.WriteEndElement()
					myWriter.WriteEndElement()
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub AddIPRProfile(ByRef rElt As XmlElement)
			' The following expression was wrapped in a checked-statement
			Dim num As Integer
			Dim num3 As Integer
			Dim obj As Object
			Try
				ProjectData.ClearProjectError()
				num = 2
				If Not RSWIN_DESC.rst.gbUseIPR Then
					Dim text As String = "r:ipr-profile"
					MRodstarXML.AddNilElement(rElt, text)
				Else
					Dim ownerDocument As XmlDocument = rElt.OwnerDocument
					Dim xmlElement As XmlElement = ownerDocument.CreateElement("r:ipr-profile")
					Dim text As String = "r:bubble-point-pressure"
					MRodstarXML.AddDecimalElement(xmlElement, text, CDbl(RSWIN_DESC.rst.BubblePoint))
					text = "r:calc-fetkovich-n"
					MRodstarXML.AddBooleanElement(xmlElement, text, RSWIN_DESC.rst.gbCalcFetkovichN)
					text = "r:fetkovich-n"
					MRodstarXML.AddDecimalElement(xmlElement, text, CDbl(RSWIN_DESC.rst.FetkovichN))
					text = "r:ipr-correlation"
					Dim text2 As String = Convert.ToString(RuntimeHelpers.GetObjectValue(MRodstarXML.DoLookup(MRodstarXML.mnLookupIPRCorrelation, RSWIN_DESC.rst.giIPRMethod)))
					MRodstarXML.AddStringElement(xmlElement, text, text2, False)
					Dim xmlElement2 As XmlElement = ownerDocument.CreateElement("r:ipr-test-points")
					Dim num2 As Integer = 1
					Dim gnTestPoints As Integer = CInt(RSWIN_DESC.rst.gnTestPoints)
					For i As Integer = num2 To gnTestPoints
						Dim newChild As XmlElement = ownerDocument.CreateElement("r:ipr-test-point")
						text2 = "r:fluid-production"
						MRodstarXML.AddDecimalElement(newChild, text2, CDbl(RSWIN_DESC.rst.TestPoints(i).Production))
						If RSWIN_DESC.rst.TestPoints(i).bPIEntered <> 0S Then
							text2 = "r:pump-intake-pressure"
							MRodstarXML.AddDecimalElement(newChild, text2, CDbl(RSWIN_DESC.rst.TestPoints(i).Pintake))
						Else
							text2 = "r:flowing-wellbore-pressure"
							MRodstarXML.AddDecimalElement(newChild, text2, CDbl(RSWIN_DESC.rst.TestPoints(i).Pwf))
						End If
						xmlElement2.AppendChild(newChild)
					Next
					xmlElement.AppendChild(xmlElement2)
					text2 = "r:mid-perf-depth"
					MRodstarXML.AddDecimalElement(xmlElement, text2, CDbl(RSWIN_DESC.rst.MidPerfDepth))
					text2 = "r:producing-below-bubble-point"
					MRodstarXML.AddBooleanElement(xmlElement, text2, RSWIN_DESC.rst.gbProducingBelowBPP)
					text2 = "r:static-bottom-hole-pressure"
					MRodstarXML.AddDecimalElement(xmlElement, text2, CDbl(RSWIN_DESC.rst.StaticBHPressure))
					rElt.AppendChild(xmlElement)
				End If
				IL_20A:
				GoTo IL_251
				IL_20C:
				num3 = -1
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_222:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num3 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_20C
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_251:
			If num3 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		Private Sub AddMeasuredDyno(ByRef myWriter As XmlTextWriter)
			Try
				Dim flag As Boolean = RSWIN_DESC.rst.RDNtsteps > 2S
				If(If((-If((Not flag > False), 1S, 0S)), 1S, 0S) Or Not RSWIN_DESC.SETUP_SaveXDIAGMeasuredCard) <> 0S Then
					Dim text As String = "r:measured-dynamometer-card"
					MRodstarXML.AddNilElement(myWriter, text)
				Else
					Dim xmlTextWriter As XmlTextWriter = myWriter
					xmlTextWriter.WriteStartElement("r:measured-dynamometer-card")
					Dim num As Integer = 0
					Dim num2 As Integer = CInt((RSWIN_DESC.rst.RDNtsteps - 1S))
					For i As Integer = num To num2
						xmlTextWriter.WriteStartElement("r:measured-dynamometer-card-point")
						xmlTextWriter.WriteAttributeString("Order", i.ToString())
						Dim text As String = "r:surface-load"
						MRodstarXML.AddDecimalElement(myWriter, text, CDbl(RSWIN_DESC.rst.RDSurfLoad(i)))
						text = "r:surface-position"
						MRodstarXML.AddDecimalElement(myWriter, text, CDbl(RSWIN_DESC.rst.RDSurfPos(i)))
						xmlTextWriter.WriteEndElement()
					Next
					xmlTextWriter.WriteEndElement()
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub AddMeasuredDyno(ByRef rElt As XmlElement)
			Dim num As Integer
			Dim num4 As Integer
			Dim obj As Object
			Try
				ProjectData.ClearProjectError()
				num = 2
				If RSWIN_DESC.rst.RDNtsteps > 2S Then
				End If
				If(If((-If((Not RSWIN_DESC.rst.gbRoddiagFile > False), 1S, 0S)), 1S, 0S) Or Not RSWIN_DESC.SETUP_SaveXDIAGMeasuredCard) <> 0S Then
					Dim text As String = "r:measured-dynamometer-card"
					MRodstarXML.AddNilElement(rElt, text)
				Else
					Dim ownerDocument As XmlDocument = rElt.OwnerDocument
					Dim xmlElement As XmlElement = ownerDocument.CreateElement("r:measured-dynamometer-card")
					Dim num2 As Integer = 0
					Dim num3 As Integer = CInt((RSWIN_DESC.rst.RDNtsteps - 1S))
					For i As Integer = num2 To num3
						Dim xmlElement2 As XmlElement = ownerDocument.CreateElement("r:measured-dynamometer-card-point")
						Dim text As String = "r:surface-load"
						MRodstarXML.AddDecimalElement(xmlElement2, text, CDbl(RSWIN_DESC.rst.RDSurfLoad(i)))
						text = "r:surface-position"
						MRodstarXML.AddDecimalElement(xmlElement2, text, CDbl(RSWIN_DESC.rst.RDSurfPos(i)))
						xmlElement2.SetAttribute("order", Convert.ToString(i))
						xmlElement.AppendChild(xmlElement2)
					Next
					rElt.AppendChild(xmlElement)
				End If
				IL_EE:
				GoTo IL_135
				IL_F0:
				num4 = -1
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_106:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num4 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_F0
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_135:
			If num4 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		Private Sub AddNilElement(ByRef myWriter As XmlTextWriter, ByRef sTagName As String)
			Try
				Dim xmlTextWriter As XmlTextWriter = myWriter
				xmlTextWriter.WriteStartElement(sTagName)
				xmlTextWriter.WriteString("xsi:nil")
				xmlTextWriter.WriteEndElement()
			Catch ex As Exception
			End Try
		End Sub

		Private Sub AddNilElement(ByRef rElt As XmlElement, ByRef sTagName As String)
			Try
				Dim ownerDocument As XmlDocument = rElt.OwnerDocument
				Dim xmlElement As XmlElement = ownerDocument.CreateElement(sTagName)
				xmlElement.SetAttribute("xsi:nil", "true")
				rElt.AppendChild(xmlElement)
			Catch ex As Exception
			End Try
		End Sub

		Private Sub AddPumpingUnit(ByRef myWriter As XmlTextWriter)
			Try
				MRodstarXML.bCustomPU = False
				If RSWIN_DESC.rst.PU.UnitType = 8S Or (RSWIN_DESC.rst.PU.UnitType = 11S And Not RSWIN_DESC.rst.bUseCrankBalancedCalcs) Then
					RSWIN_DESC.bBeamBalanced = True
				Else
					RSWIN_DESC.bBeamBalanced = False
				End If
				Dim text As String
				Select Case RSWIN_DESC.rst.PU.UnitType
					Case 1S
						text = "r:pumpingunit-conventional"
					Case 2S
						text = "r:pumpingunit-enhanced"
					Case 3S
						text = "r:pumpingunit-grooves"
					Case 4S
						text = "r:pumpingunit-lowprofile"
					Case 5S
						text = "r:pumpingunit-markii"
					Case 6S
						text = "r:pumpingunit-airbalanced"
					Case 7S
						text = "r:pumpingunit-longstroke"
					Case 8S
						text = "r:pumpingunit-beambalanced"
					Case 9S
						text = "r:pumpingunit-beltlowprofile"
					Case 10S
						text = "r:pumpingunit-hydraulic"
					Case 11S
						text = "r:pumpingunit-combobeamcrank"
				End Select
				Dim xmlTextWriter As XmlTextWriter = myWriter
				If Operators.CompareString(text.Trim(), "", False) = 0 And Operators.CompareString(RSWIN_DESC.rst.UnitID.Trim(), "", False) <> 0 Then
					Dim pu As RSWIN_DESC.PUDataRec
					pu.Initialize()
					pu = RSWIN_DESC.rst.PU
					Dim crankHole As Short
					If pu.CrankHole <> 0S Then
						crankHole = pu.CrankHole
					ElseIf RSWIN_DESC.rst.CrankHole <> 0S Then
						crankHole = RSWIN_DESC.rst.CrankHole
					End If
					Dim num As Short
					If pu.CrankRotation = 1S Or pu.CrankRotation = -1S Then
						num = pu.CrankRotation
					ElseIf RSWIN_DESC.rst.Rotation = 1S Or RSWIN_DESC.rst.Rotation = -1S Then
						num = RSWIN_DESC.rst.Rotation
					End If
					PUDATA1.ReadPUData(RSWIN_DESC.rst.UnitID, pu, False, True)
					If crankHole <> 0S Then
						pu.CrankHole = crankHole
					End If
					If num <> 0S Then
						pu.CrankRotation = num
					End If
					RSWIN_DESC.rst.PU = pu
					Select Case RSWIN_DESC.rst.PU.UnitType
						Case 1S
							text = "r:pumpingunit-conventional"
						Case 2S
							text = "r:pumpingunit-enhanced"
						Case 3S
							text = "r:pumpingunit-grooves"
						Case 4S
							text = "r:pumpingunit-lowprofile"
						Case 5S
							text = "r:pumpingunit-markii"
						Case 6S
							text = "r:pumpingunit-airbalanced"
						Case 7S
							text = "r:pumpingunit-longstroke"
						Case 8S
							text = "r:pumpingunit-beambalanced"
						Case 9S
							text = "r:pumpingunit-beltlowprofile"
						Case 10S
							text = "r:pumpingunit-hydraulic"
						Case 11S
							text = "r:pumpingunit-combobeamcrank"
						Case Else
							text = "r:pumpingunit-conventional"
					End Select
				End If
				xmlTextWriter.WriteStartElement("r:pumpingunit")
				xmlTextWriter.WriteStartElement(text)
				Dim text2 As String = "r:crank-rotation"
				Dim text3 As String = Convert.ToString(RuntimeHelpers.GetObjectValue(MRodstarXML.DoLookup(MRodstarXML.mnLookupCrankRotation, RSWIN_DESC.rst.PU.CrankRotation)))
				MRodstarXML.AddStringElement(myWriter, text2, text3, False)
				text3 = "r:crank-hole-number"
				MRodstarXML.AddIntegerElement(myWriter, text3, CInt(RSWIN_DESC.rst.PU.CrankHole))
				If RSWIN_DESC.rst.IDEntered <> 0S Then
					text3 = "r:pumping-unit-id"
					text2 = Strings.Trim(RSWIN_DESC.rst.UnitID)
					MRodstarXML.AddStringElement(myWriter, text3, text2, True)
					If Strings.InStr(RSWIN_DESC.rst.UnitID, "CUSTOM", CompareMethod.Binary) > 0 Then
						MRodstarXML.bCustomPU = True
					End If
				Else
					text3 = "r:pumping-unit-id"
					MRodstarXML.AddNilElement(myWriter, text3)
				End If
				If MRodstarXML.bCustomPU Then
					text3 = "r:api-designation"
					text2 = RSWIN_DESC.rst.PU.APIDesignation.Trim()
					MRodstarXML.AddStringElement(myWriter, text3, text2, True)
					text3 = "r:pumping-unit-manufacturer"
					text2 = RSWIN_DESC.rst.PU.Manuf.Trim()
					MRodstarXML.AddStringElement(myWriter, text3, text2, True)
					text3 = "r:pumping-unit-name"
					text2 = RSWIN_DESC.rst.PU.UnitName.Trim()
					MRodstarXML.AddStringElement(myWriter, text3, text2, True)
					text3 = "r:pumping-unit-other-info"
					text2 = RSWIN_DESC.rst.PU.OtherInfo.Trim()
					MRodstarXML.AddStringElement(myWriter, text3, text2, True)
					text3 = "r:pumping-unit-struct-rating"
					text2 = Conversions.ToString(RSWIN_DESC.rst.PU.StructRating)
					MRodstarXML.AddStringElement(myWriter, text3, text2, True)
					text3 = "r:pumping-unit-gearbox-rating"
					text2 = Conversions.ToString(RSWIN_DESC.rst.PU.GearboxRating)
					MRodstarXML.AddStringElement(myWriter, text3, text2, True)
					text3 = "r:pumping-unit-max-stroke"
					text2 = Conversions.ToString(RSWIN_DESC.rst.PU.MaxStroke)
					MRodstarXML.AddStringElement(myWriter, text3, text2, True)
					text3 = "r:pumping-unit-art-inertia"
					text2 = Conversions.ToString(RSWIN_DESC.rst.PU.ArtInertia)
					MRodstarXML.AddStringElement(myWriter, text3, text2, True)
				End If
				If RSWIN_DESC.rst.PU.UnitType = 7S Or RSWIN_DESC.rst.PU.UnitType = 10S Then
					If MRodstarXML.bCustomPU Then
						text3 = "r:drum-diameter-ratio"
						MRodstarXML.AddDecimalElement(myWriter, text3, CDbl(RSWIN_DESC.rst.PU.DrumDiamRatio))
						text3 = "r:pitman-arm-length"
						MRodstarXML.AddDecimalElement(myWriter, text3, CDbl(RSWIN_DESC.rst.PU.P))
						text3 = "r:sprocket-diameter"
						MRodstarXML.AddDecimalElement(myWriter, text3, CDbl((RSWIN_DESC.rst.PU.SprocketRadius * 2F)))
						text3 = "r:sprocket-distance"
						MRodstarXML.AddDecimalElement(myWriter, text3, CDbl(RSWIN_DESC.rst.PU.SprocketDistance))
					End If
				Else
					If MRodstarXML.bCustomPU Then
						MRodstarXML.AddCrankRadii(myWriter)
					End If
					If MRodstarXML.bCustomPU Then
						text3 = "r:pu-apidimension-a"
						MRodstarXML.AddDecimalElement(myWriter, text3, CDbl(RSWIN_DESC.rst.PU.A))
						text3 = "r:pu-apidimension-c"
						MRodstarXML.AddDecimalElement(myWriter, text3, CDbl(RSWIN_DESC.rst.PU.C))
						text3 = "r:pu-apidimension-i"
						MRodstarXML.AddDecimalElement(myWriter, text3, CDbl(RSWIN_DESC.rst.PU.I))
						text3 = "r:pu-apidimension-k"
						MRodstarXML.AddDecimalElement(myWriter, text3, CDbl(RSWIN_DESC.rst.PU.K))
						text3 = "r:pu-apidimension-p"
						MRodstarXML.AddDecimalElement(myWriter, text3, CDbl(RSWIN_DESC.rst.PU.P))
					End If
					If RSWIN_DESC.rst.PU.UnitType = 6S Then
						If MRodstarXML.bCustomPU Then
							text3 = "r:pu-apidimension-m"
							MRodstarXML.AddDecimalElement(myWriter, text3, CDbl(RSWIN_DESC.rst.PU.M))
							text3 = "r:pu-apidimension-s"
							MRodstarXML.AddDecimalElement(myWriter, text3, CDbl(RSWIN_DESC.rst.PU.S))
							text3 = "r:pu-apidimension-v0"
							MRodstarXML.AddDecimalElement(myWriter, text3, CDbl(RSWIN_DESC.rst.PU.V0))
						End If
					Else
						text3 = "r:crank-offset-angle"
						MRodstarXML.AddDecimalElement(myWriter, text3, CDbl(RSWIN_DESC.rst.PU.CrankOffset))
						If(RSWIN_DESC.rst.PU.UnitType = 8S Or RSWIN_DESC.bBeamBalanced) And RSWIN_DESC.rst.Unbalance <> RSWIN_DESC.rst.PU.Unbalance Then
							text3 = "r:structural-unbalance"
							MRodstarXML.AddDecimalElement(myWriter, text3, CDbl(RSWIN_DESC.rst.Unbalance))
						Else
							text3 = "r:structural-unbalance"
							MRodstarXML.AddDecimalElement(myWriter, text3, CDbl(RSWIN_DESC.rst.PU.Unbalance))
						End If
					End If
				End If
				xmlTextWriter.WriteEndElement()
				xmlTextWriter.WriteEndElement()
			Catch ex As Exception
			End Try
		End Sub

		Private Function AddRodStringDesign(ByRef myWriter As XmlTextWriter) As Boolean
			Dim result As Boolean = True
			Try
				Dim xmlTextWriter As XmlTextWriter = myWriter
				xmlTextWriter.WriteStartElement("r:rod-string-design")
				If RSWIN_DESC.rst.RodStringType <> 3S Then
					xmlTextWriter.WriteString("xsi:nil")
				Else
					If RSWIN_DESC.rst.giRodDesignStyle = 0S Then
						xmlTextWriter.WriteStartElement("r:rodstringdesign-steel")
						If Conversions.ToBoolean(Support.Imp(RSWIN_DESC.rst.giRodDesignStyle <> 0S, Not RSWIN_DESC.rst.RSFGIncludeSteel)) Then
							result = MRodstarXML.AddRodGradeElement(myWriter, CInt(RSWIN_DESC.rst.RSGrade))
							Dim text As String = "r:steel-size-max"
							result = MRodstarXML.AddDecimalElement(myWriter, text, CDbl(RSWIN_DESC.rst.RSMaxSize))
							If RSWIN_DESC.bRodStarD Then
								Try
									text = "r:sucker-rod-size"
									result = MRodstarXML.AddDecimalElement(myWriter, text, CDbl(RSWIN_DESC.rst.RSSRSize))
								Catch ex As Exception
								End Try
							End If
							text = "r:steel-size-min"
							result = MRodstarXML.AddDecimalElement(myWriter, text, CDbl(RSWIN_DESC.rst.RSMinSize))
							text = "r:steel-fric-coef"
							result = MRodstarXML.AddDecimalElement(myWriter, text, CDbl(RSWIN_DESC.rst.RSFricCoef))
							text = "r:steel-guide"
							result = MRodstarXML.AddDecimalElement(myWriter, text, CDbl(RSWIN_DESC.rst.RSRodGuide))
						Else
							Dim text As String = "r:rodtype-steel"
							MRodstarXML.AddNilElement(myWriter, text)
						End If
						xmlTextWriter.WriteStartElement("r:sinker-bar")
						If Not RSWIN_DESC.rst.RSIncludeSB <> 0S Then
							xmlTextWriter.WriteString("xsi:nil")
						Else
							result = MRodstarXML.AddRodGradeElement(myWriter, CInt(RSWIN_DESC.rst.SinkerBar.Grade))
							Dim text As String = "r:taper-length"
							result = MRodstarXML.AddDecimalElement(myWriter, text, CDbl(RSWIN_DESC.rst.SinkerBar.length))
							text = "r:taper-size"
							result = MRodstarXML.AddDecimalElement(myWriter, text, CDbl(RSWIN_DESC.rst.SinkerBar.Diameter))
							Try
								If RSWIN_DESC.rst.SinkerBar.TensileStrength = 0F Then
									Dim sinkerBar As RSWIN_DESC.RodSection
									sinkerBar.Initialize()
									sinkerBar = RSWIN_DESC.rst.SinkerBar
									sinkerBar.TensileStrength = RODUTIL.LookupTensileStrength(CSng(RSWIN_DESC.rst.SinkerBar.Grade))
									RSWIN_DESC.rst.SinkerBar = sinkerBar
								End If
								text = "r:taper-tensile-strength"
								result = MRodstarXML.AddDecimalElement(myWriter, text, CDbl(RSWIN_DESC.rst.SinkerBar.TensileStrength))
							Catch ex2 As Exception
							End Try
							Try
								text = "r:taper-stress-method"
								result = MRodstarXML.AddDecimalElement(myWriter, text, CDbl(RSWIN_DESC.rst.SinkerBar.StressMethod))
							Catch ex3 As Exception
							End Try
						End If
						xmlTextWriter.WriteEndElement()
					Else
						If RSWIN_DESC.rst.giRodDesignStyle = 1S Then
							xmlTextWriter.WriteStartElement("r:rodstringdesign-fiberglass")
							result = MRodstarXML.AddRodGradeElement(myWriter, CInt(RSWIN_DESC.rst.RSFGGrade))
						Else
							xmlTextWriter.WriteStartElement("r:rodstringdesign-ribbonrod")
							result = MRodstarXML.AddRodGradeElement(myWriter, 20481)
						End If
						If RSWIN_DESC.rst.RodStringType = 3S Then
							If RSWIN_DESC.rst.RSFGIncludeSteel <> 0S Then
								result = MRodstarXML.AddRodGradeElement(myWriter, CInt(RSWIN_DESC.rst.RSGrade))
								Dim text As String = "r:steel-size-max"
								result = MRodstarXML.AddDecimalElement(myWriter, text, CDbl(RSWIN_DESC.rst.RSMaxSize))
								If RSWIN_DESC.bRodStarD Then
									Try
										text = "r:sucker-rod-size"
										result = MRodstarXML.AddDecimalElement(myWriter, text, CDbl(RSWIN_DESC.rst.RSSRSize))
									Catch ex4 As Exception
									End Try
								End If
								text = "r:steel-size-min"
								result = MRodstarXML.AddDecimalElement(myWriter, text, CDbl(RSWIN_DESC.rst.RSMinSize))
								text = "r:steel-fric-coef"
								result = MRodstarXML.AddDecimalElement(myWriter, text, CDbl(RSWIN_DESC.rst.RSFricCoef))
								text = "r:steel-guide"
								result = MRodstarXML.AddDecimalElement(myWriter, text, CDbl(RSWIN_DESC.rst.RSRodGuide))
							End If
						Else
							Dim text As String = "r:rodtype-steel"
							MRodstarXML.AddNilElement(myWriter, text)
						End If
						xmlTextWriter.WriteStartElement("r:sinker-bar")
						If Not RSWIN_DESC.rst.RSIncludeSB <> 0S Then
							xmlTextWriter.WriteString("xsi:nil")
						Else
							result = MRodstarXML.AddRodGradeElement(myWriter, CInt(RSWIN_DESC.rst.SinkerBar.Grade))
							Dim text As String = "r:taper-length"
							result = MRodstarXML.AddDecimalElement(myWriter, text, CDbl(RSWIN_DESC.rst.SinkerBar.length))
							text = "r:taper-size"
							result = MRodstarXML.AddDecimalElement(myWriter, text, CDbl(RSWIN_DESC.rst.SinkerBar.Diameter))
							Try
								If RSWIN_DESC.rst.SinkerBar.TensileStrength = 0F Then
									Dim sinkerBar2 As RSWIN_DESC.RodSection
									sinkerBar2.Initialize()
									sinkerBar2 = RSWIN_DESC.rst.SinkerBar
									sinkerBar2.TensileStrength = RODUTIL.LookupTensileStrength(CSng(RSWIN_DESC.rst.SinkerBar.Grade))
									RSWIN_DESC.rst.SinkerBar = sinkerBar2
								End If
								text = "r:taper-tensile-strength"
								result = MRodstarXML.AddDecimalElement(myWriter, text, CDbl(RSWIN_DESC.rst.SinkerBar.TensileStrength))
							Catch ex5 As Exception
							End Try
							Try
								text = "r:taper-stress-method"
								result = MRodstarXML.AddDecimalElement(myWriter, text, CDbl(RSWIN_DESC.rst.SinkerBar.StressMethod))
							Catch ex6 As Exception
							End Try
						End If
						xmlTextWriter.WriteEndElement()
					End If
					xmlTextWriter.WriteEndElement()
				End If
				xmlTextWriter.WriteEndElement()
				xmlTextWriter = Nothing
			Catch ex7 As Exception
				result = False
			End Try
			Return result
		End Function

		Private Function AddRodStringDesign(ByRef rElt As XmlElement) As Boolean
			Dim result As Boolean = True
			Try
				Dim xmlElement As XmlElement = rElt.OwnerDocument.CreateElement("r:rod-string-design")
				If RSWIN_DESC.rst.RodStringType <> 3S Then
					xmlElement.SetAttribute("xsi:nil", "true")
				Else
					Dim xmlElement2 As XmlElement
					If RSWIN_DESC.rst.giRodDesignStyle = 0S Then
						xmlElement2 = rElt.OwnerDocument.CreateElement("r:rodstringdesign-steel")
						If Conversions.ToBoolean(Support.Imp(RSWIN_DESC.rst.giRodDesignStyle <> 0S, Not RSWIN_DESC.rst.RSFGIncludeSteel)) Then
							result = MRodstarXML.AddRodGradeElement(xmlElement2, CInt(RSWIN_DESC.rst.RSGrade))
							Dim text As String = "r:steel-size-max"
							result = MRodstarXML.AddDecimalElement(xmlElement2, text, CDbl(RSWIN_DESC.rst.RSMaxSize))
							If RSWIN_DESC.bRodStarD Then
								Try
									text = "r:sucker-rod-size"
									result = MRodstarXML.AddDecimalElement(xmlElement2, text, CDbl(RSWIN_DESC.rst.RSSRSize))
								Catch ex As Exception
								End Try
							End If
							text = "r:steel-size-min"
							result = MRodstarXML.AddDecimalElement(xmlElement2, text, CDbl(RSWIN_DESC.rst.RSMinSize))
							text = "r:steel-fric-coef"
							result = MRodstarXML.AddDecimalElement(xmlElement2, text, CDbl(RSWIN_DESC.rst.RSFricCoef))
							text = "r:steel-guide"
							result = MRodstarXML.AddDecimalElement(xmlElement2, text, CDbl(RSWIN_DESC.rst.RSRodGuide))
						Else
							Dim text As String = "r:rodtype-steel"
							MRodstarXML.AddNilElement(xmlElement2, text)
						End If
						Dim xmlElement3 As XmlElement = rElt.OwnerDocument.CreateElement("r:sinker-bar")
						If Not RSWIN_DESC.rst.RSIncludeSB <> 0S Then
							xmlElement3.SetAttribute("xsi:nil", "true")
						Else
							result = MRodstarXML.AddRodGradeElement(xmlElement3, CInt(RSWIN_DESC.rst.SinkerBar.Grade))
							Dim text As String = "r:taper-length"
							result = MRodstarXML.AddDecimalElement(xmlElement3, text, CDbl(RSWIN_DESC.rst.SinkerBar.length))
							text = "r:taper-size"
							result = MRodstarXML.AddDecimalElement(xmlElement3, text, CDbl(RSWIN_DESC.rst.SinkerBar.Diameter))
							Try
								If RSWIN_DESC.rst.SinkerBar.TensileStrength = 0F Then
									Dim sinkerBar As RSWIN_DESC.RodSection
									sinkerBar.Initialize()
									sinkerBar = RSWIN_DESC.rst.SinkerBar
									sinkerBar.TensileStrength = RODUTIL.LookupTensileStrength(CSng(RSWIN_DESC.rst.SinkerBar.Grade))
									RSWIN_DESC.rst.SinkerBar = sinkerBar
								End If
								text = "r:taper-tensile-strength"
								result = MRodstarXML.AddDecimalElement(xmlElement3, text, CDbl(RSWIN_DESC.rst.SinkerBar.TensileStrength))
							Catch ex2 As Exception
							End Try
							Try
								text = "r:taper-stress-method"
								result = MRodstarXML.AddDecimalElement(xmlElement3, text, CDbl(RSWIN_DESC.rst.SinkerBar.StressMethod))
							Catch ex3 As Exception
							End Try
						End If
						xmlElement2.AppendChild(xmlElement3)
					Else
						If RSWIN_DESC.rst.giRodDesignStyle = 1S Then
							xmlElement2 = rElt.OwnerDocument.CreateElement("r:rodstringdesign-fiberglass")
							result = MRodstarXML.AddRodGradeElement(xmlElement2, CInt(RSWIN_DESC.rst.RSFGGrade))
						Else
							xmlElement2 = rElt.OwnerDocument.CreateElement("r:rodstringdesign-ribbonrod")
							result = MRodstarXML.AddRodGradeElement(xmlElement2, CInt(RSWIN_DESC.rst.RSFGGrade))
						End If
						If Conversions.ToBoolean(Support.Imp(RSWIN_DESC.rst.giRodDesignStyle <> 0S, Not RSWIN_DESC.rst.RSFGIncludeSteel)) Then
							result = MRodstarXML.AddRodGradeElement(xmlElement2, CInt(RSWIN_DESC.rst.RSGrade))
							Dim text As String = "r:steel-size-max"
							result = MRodstarXML.AddDecimalElement(xmlElement2, text, CDbl(RSWIN_DESC.rst.RSMaxSize))
							If RSWIN_DESC.bRodStarD Then
								Try
									text = "r:sucker-rod-size"
									result = MRodstarXML.AddDecimalElement(xmlElement2, text, CDbl(RSWIN_DESC.rst.RSSRSize))
								Catch ex4 As Exception
								End Try
							End If
							text = "r:steel-size-min"
							result = MRodstarXML.AddDecimalElement(xmlElement2, text, CDbl(RSWIN_DESC.rst.RSMinSize))
							text = "r:steel-fric-coef"
							result = MRodstarXML.AddDecimalElement(xmlElement2, text, CDbl(RSWIN_DESC.rst.RSFricCoef))
							text = "r:steel-guide"
							result = MRodstarXML.AddDecimalElement(xmlElement2, text, CDbl(RSWIN_DESC.rst.RSRodGuide))
						Else
							Dim text As String = "r:rodtype-steel"
							MRodstarXML.AddNilElement(xmlElement2, text)
						End If
						Dim xmlElement3 As XmlElement = rElt.OwnerDocument.CreateElement("r:sinker-bar")
						If Not RSWIN_DESC.rst.RSIncludeSB <> 0S Then
							xmlElement3.SetAttribute("xsi:nil", "true")
						Else
							result = MRodstarXML.AddRodGradeElement(xmlElement3, CInt(RSWIN_DESC.rst.SinkerBar.Grade))
							Dim text As String = "r:taper-length"
							result = MRodstarXML.AddDecimalElement(xmlElement3, text, CDbl(RSWIN_DESC.rst.SinkerBar.length))
							text = "r:taper-size"
							result = MRodstarXML.AddDecimalElement(xmlElement3, text, CDbl(RSWIN_DESC.rst.SinkerBar.Diameter))
							Try
								If RSWIN_DESC.rst.SinkerBar.TensileStrength = 0F Then
									Dim sinkerBar2 As RSWIN_DESC.RodSection
									sinkerBar2.Initialize()
									sinkerBar2 = RSWIN_DESC.rst.SinkerBar
									sinkerBar2.TensileStrength = RODUTIL.LookupTensileStrength(CSng(RSWIN_DESC.rst.SinkerBar.Grade))
									RSWIN_DESC.rst.SinkerBar = sinkerBar2
								End If
								text = "r:taper-tensile-strength"
								result = MRodstarXML.AddDecimalElement(xmlElement3, text, CDbl(RSWIN_DESC.rst.SinkerBar.TensileStrength))
							Catch ex5 As Exception
							End Try
							Try
								text = "r:taper-stress-method"
								result = MRodstarXML.AddDecimalElement(xmlElement3, text, CDbl(RSWIN_DESC.rst.SinkerBar.StressMethod))
							Catch ex6 As Exception
							End Try
						End If
						xmlElement2.AppendChild(xmlElement3)
					End If
					xmlElement.AppendChild(xmlElement2)
				End If
				rElt.AppendChild(xmlElement)
			Catch ex7 As Exception
				result = False
			End Try
			Return result
		End Function

		Private Function AddRodGradeElement(ByRef myWriter As XmlTextWriter, lValue As Integer) As Boolean
			Dim result As Boolean = True
			Try
				Dim flag As Boolean = True
				Dim text As String
				If flag = (RODUTIL.IsCorod(lValue) <> 0) Then
					text = "r:rodtype-corod"
				ElseIf flag = (RODUTIL.IsProRod(lValue) <> 0) Then
					text = "r:rodtype-prorod"
				ElseIf flag = RODUTIL.IsRibbonRod(CShort(lValue)) Then
					text = "r:rodtype-ribbonrod"
				ElseIf flag = RODUTIL.IsFG(CShort(lValue)) Then
					text = "r:rodtype-fiberglass"
				ElseIf flag = RODUTIL.IsSinkerBarGrade(lValue) Then
					text = "r:rodtype-sinkerbar"
				Else
					text = "r:rodtype-steel"
				End If
				Dim text2 As String = Convert.ToString(RuntimeHelpers.GetObjectValue(MRodstarXML.DoLookup(MRodstarXML.new_mnLookupRodGrade, lValue)))
				If text2 <> Nothing And Operators.CompareString(text2, "", False) <> 0 Then
					Dim text3 As String = Convert.ToString(RuntimeHelpers.GetObjectValue(MRodstarXML.DoLookup(MRodstarXML.new_mnLookupRodGrade, lValue)))
					result = MRodstarXML.AddStringElement(myWriter, text, text3, False)
				ElseIf CUSTOMRG.IsOtherFG(lValue) Then
					Dim num As Single = 0F
					Dim text3 As String = RODUTIL.GetOtherFG(lValue, num)
					result = MRodstarXML.AddStringElement(myWriter, text, text3, False)
				ElseIf CUSTOMRG.IsOtherSinkerBar(lValue) Then
					Dim num As Single = 0F
					Dim text3 As String = RODUTIL.GetOtherSinkerbar(lValue, num)
					result = MRodstarXML.AddStringElement(myWriter, text, text3, False)
				ElseIf CUSTOMRG.IsOtherSteel(lValue) Then
					Dim num As Single = 0F
					Dim text3 As String = RODUTIL.GetOtherSteel(lValue, num)
					result = MRodstarXML.AddStringElement(myWriter, text, text3, False)
				End If
			Catch ex As Exception
				result = False
			End Try
			Return result
		End Function

		Public Function DoCustomSteelRodGradeLookup(iSearch As Integer) As String
			Dim num As Integer = -1
			Dim result As String = ""
			Dim num2 As Integer = 1
			Dim num3 As Integer = Information.UBound(RSWIN_DESC.CustomRodGradeList, 1)
			For i As Integer = num2 To num3
				num += 1
				If 4143 + num = iSearch Or 4096 + num = iSearch Then
					result = RSWIN_DESC.CustomRodGradeList(i).RodType
					Exit For
				End If
			Next
			Return result
		End Function

		Public Function DoCustomFGRodGradeLookup(iSearch As Integer) As String
			Dim num As Integer = -1
			Dim result As String = ""
			Dim num2 As Integer = 1
			Dim num3 As Integer = Information.UBound(RSWIN_DESC.CustomRodGradeList, 1)
			For i As Integer = num2 To num3
				num += 1
				If 16397 + iSearch = num Or 16384 + iSearch = num Then
					result = RSWIN_DESC.CustomRodGradeList(i).RodType
					Exit For
				End If
			Next
			Return result
		End Function

		Public Function DoCustomSinkerBarRodGradeLookup(iSearch As Integer) As String
			Dim num As Integer = -1
			Dim result As String = ""
			Dim num2 As Integer = 1
			Dim num3 As Integer = Information.UBound(RSWIN_DESC.CustomRodGradeList, 1)
			For i As Integer = num2 To num3
				num += 1
				If 8311 + num = iSearch Then
					result = RSWIN_DESC.CustomRodGradeList(i).RodType
					Exit For
				End If
			Next
			Return result
		End Function

		Public Function DoCustomSteelRodGradeLookup(sSearch As String) As Integer
			Dim result As Integer = 0
			Dim num As Integer = 0
			Dim num2 As Integer = 0
			Dim flag As Boolean = False
			Dim num3 As Integer = 1
			Dim num4 As Integer = Information.UBound(RSWIN_DESC.CustomRodGradeList, 1)
			Dim i As Integer = num3
			While i <= num4
				If RSWIN_DESC.CustomRodGradeList(i).RodType IsNot Nothing Then
					If(RSWIN_DESC.CustomRodGradeList(i).Steel And Not RSWIN_DESC.CustomRodGradeList(i).SinkerBar) <> 0S Then
						num += 1
						flag = False
					ElseIf(RSWIN_DESC.CustomRodGradeList(i).Steel And RSWIN_DESC.CustomRodGradeList(i).SinkerBar) <> 0S Then
						num2 += 1
						flag = True
					End If
				End If
				If Operators.CompareString(RSWIN_DESC.CustomRodGradeList(i).RodType.Trim(), sSearch, False) = 0 Then
					If Not flag Then
						result = 4143 + num
						Exit While
					End If
					result = 8311 + num2
					Exit While
				Else
					i += 1
				End If
			End While
			Return result
		End Function

		Public Function DoCustomSinkerBarRodGradeLookup(sSearch As String) As Integer
			Dim num As Integer = -1
			Dim result As Integer = 0
			Dim num2 As Integer = 1
			Dim num3 As Integer = Information.UBound(RSWIN_DESC.CustomRodGradeList, 1)
			For i As Integer = num2 To num3
				num += 1
				If Operators.CompareString(RSWIN_DESC.CustomRodGradeList(i).RodType.Trim(), sSearch, False) = 0 Then
					result = 8311 + num
					Exit For
				End If
			Next
			Return result
		End Function

		Private Function AddRodGradeElement(ByRef rElt As XmlElement, lValue As Integer) As Boolean
			Dim result As Boolean = True
			Try
				Dim flag As Boolean = True
				Dim text As String
				If flag = (RODUTIL.IsCorod(lValue) <> 0) Then
					text = "r:rodtype-corod"
				ElseIf flag = (RODUTIL.IsProRod(lValue) <> 0) Then
					text = "r:rodtype-prorod"
				ElseIf flag = RODUTIL.IsRibbonRod(CShort(lValue)) Then
					text = "r:rodtype-ribbonrod"
				ElseIf flag = RODUTIL.IsFG(CShort(lValue)) Then
					text = "r:rodtype-fiberglass"
				ElseIf flag = RODUTIL.IsSinkerBarGrade(lValue) Then
					text = "r:rodtype-sinkerbar"
				Else
					text = "r:rodtype-steel"
				End If
				Dim text2 As String = Convert.ToString(RuntimeHelpers.GetObjectValue(MRodstarXML.DoLookup(MRodstarXML.new_mnLookupRodGrade, lValue)))
				Dim text3 As String = Convert.ToString(RuntimeHelpers.GetObjectValue(MRodstarXML.DoLookup(MRodstarXML.new_mnLookupRodGrade, lValue)))
				MRodstarXML.AddStringElement(rElt, text, text3, False)
			Catch ex As Exception
				result = False
			End Try
			Return result
		End Function

		Private Function AddCalculatedRodTapers(ByRef myWriter As XmlTextWriter) As Boolean
			Dim result As Boolean = True
			Try
				Dim xmlTextWriter As XmlTextWriter = myWriter
				If RSWIN_DESC.rst.NumRods = 0S Then
					Dim text As String = "r:calculated-rod-tapers"
					MRodstarXML.AddNilElement(myWriter, text)
				Else
					xmlTextWriter.WriteStartElement("r:calculated-rod-tapers")
					Dim num As Integer = 1
					Dim numRods As Integer = CInt(RSWIN_DESC.rst.NumRods)
					For i As Integer = num To numRods
						xmlTextWriter.WriteStartElement("r:calculated-rod-taper")
						xmlTextWriter.WriteAttributeString("Order", i.ToString())
						Dim text As String = "r:max-rod-stress-top"
						result = MRodstarXML.AddDecimalElement(myWriter, text, CDbl(RSWIN_DESC.rst.maxStressTop(i)))
						text = "r:min-rod-stress-bot"
						result = MRodstarXML.AddDecimalElement(myWriter, text, CDbl(RSWIN_DESC.rst.minStressBot(i)))
						text = "r:min-rod-stress-top"
						result = MRodstarXML.AddDecimalElement(myWriter, text, CDbl(RSWIN_DESC.rst.minStressTop(i)))
						text = "r:rod-stress-loading"
						result = MRodstarXML.AddDecimalElement(myWriter, text, CDbl(RSWIN_DESC.rst.StressL(i)))
						xmlTextWriter.WriteEndElement()
					Next
					xmlTextWriter.WriteEndElement()
				End If
			Catch ex As Exception
				result = False
			End Try
			Return result
		End Function

		Private Sub AddRodTapers(ByRef myWriter As XmlTextWriter)
			' The following expression was wrapped in a checked-statement
			Try
				Dim xmlTextWriter As XmlTextWriter = myWriter
				If RSWIN_DESC.rst.NumRods = 0S Then
					Dim text As String = "r:rod-tapers"
					MRodstarXML.AddNilElement(myWriter, text)
				Else
					xmlTextWriter.WriteStartElement("r:rod-tapers")
					Dim num As Integer = 1
					Dim numRods As Integer = CInt(RSWIN_DESC.rst.NumRods)
					For i As Integer = num To numRods
						xmlTextWriter.WriteStartElement("r:rod-taper")
						xmlTextWriter.WriteAttributeString("Order", i.ToString())
						MRodstarXML.AddRodGradeElement(myWriter, CInt(RSWIN_DESC.rst.Sections(i).Grade))
						Dim text As String = "r:taper-length"
						MRodstarXML.AddDecimalElement(myWriter, text, CDbl(RSWIN_DESC.rst.Sections(i).length))
						text = "r:taper-size"
						MRodstarXML.AddDecimalElement(myWriter, text, CDbl(RSWIN_DESC.rst.Sections(i).Diameter))
						Try
							If RSWIN_DESC.rst.Sections(i).TensileStrength = 0F Then
								RODUTIL.LookupTensileStrength(RSWIN_DESC.rst.Sections(i))
							End If
							text = "r:taper-tensile-strength"
							MRodstarXML.AddDecimalElement(myWriter, text, CDbl(RSWIN_DESC.rst.Sections(i).TensileStrength))
						Catch ex As Exception
						End Try
						Try
							If RSWIN_DESC.rst.Sections(i).StressMethod = 0S Then
								RODUTIL.LookupStressMethod(RSWIN_DESC.rst.Sections(i))
							End If
							text = "r:taper-stress-method"
							MRodstarXML.AddDecimalElement(myWriter, text, CDbl(RSWIN_DESC.rst.Sections(i).StressMethod))
						Catch ex2 As Exception
						End Try
						If RSWIN_DESC.rst.Sections(i).Guide >= 0S Then
							text = "r:taper-guide"
							MRodstarXML.AddDecimalElement(myWriter, text, CDbl(RSWIN_DESC.rst.Sections(i).Guide))
						Else
							text = "r:taper-guide"
							MRodstarXML.AddDecimalElement(myWriter, text, 0.0)
						End If
						If Not RSWIN_DESC.SETUP_ALLOWSLIDEFRIC <> 0S Then
							text = "r:taper-friction-coef"
							MRodstarXML.AddDecimalElement(myWriter, text, CDbl(Util.ConvertToDouble(Conversions.ToString(RSWIN_DESC.rst.SlideFricCoeff))))
						ElseIf RSWIN_DESC.rst.Sections(i).friction_coef >= 0F Then
							text = "r:taper-friction-coef"
							MRodstarXML.AddDecimalElement(myWriter, text, CDbl(Util.ConvertToDouble(Conversions.ToString(RSWIN_DESC.rst.Sections(i).friction_coef))))
						Else
							text = "r:taper-friction-coef"
							MRodstarXML.AddDecimalElement(myWriter, text, 0.2)
						End If
						If RSWIN_DESC.bRodStarD Then
							If RSWIN_DESC.rst.Sections(i).NumGuides >= 0S Then
								text = "r:taper-num-guides"
								MRodstarXML.AddDecimalElement(myWriter, text, CDbl(RSWIN_DESC.rst.Sections(i).NumGuides))
							Else
								text = "r:taper-num-guides"
								MRodstarXML.AddDecimalElement(myWriter, text, 0.0)
							End If
						End If
						xmlTextWriter.WriteEndElement()
					Next
					xmlTextWriter.WriteEndElement()
				End If
				xmlTextWriter = Nothing
			Catch ex3 As Exception
			End Try
		End Sub

		Private Sub AddRodTapers(ByRef rElt As XmlElement)
			Dim ownerDocument As XmlDocument = rElt.OwnerDocument
			If RSWIN_DESC.rst.NumRods = 0S Then
				Dim text As String = "r:rod-tapers"
				MRodstarXML.AddNilElement(rElt, text)
			Else
				Dim xmlElement As XmlElement = ownerDocument.CreateElement("r:rod-tapers")
				Dim num As Integer = 1
				Dim numRods As Integer = CInt(RSWIN_DESC.rst.NumRods)
				For i As Integer = num To numRods
					Dim xmlElement2 As XmlElement = ownerDocument.CreateElement("r:rod-taper")
					MRodstarXML.AddRodGradeElement(xmlElement2, CInt(RSWIN_DESC.rst.Sections(i).Grade))
					Dim text As String = "r:taper-length"
					MRodstarXML.AddDecimalElement(xmlElement2, text, CDbl(RSWIN_DESC.rst.Sections(i).length))
					text = "r:taper-size"
					MRodstarXML.AddDecimalElement(xmlElement2, text, CDbl(RSWIN_DESC.rst.Sections(i).Diameter))
					If RSWIN_DESC.rst.Sections(i).Guide >= 0S Then
						text = "r:taper-guide"
						MRodstarXML.AddDecimalElement(xmlElement2, text, CDbl(RSWIN_DESC.rst.Sections(i).Guide))
					Else
						text = "r:taper-guide"
						MRodstarXML.AddDecimalElement(xmlElement2, text, 0.0)
					End If
					If RSWIN_DESC.rst.Sections(i).TensileStrength = 0F Then
						RODUTIL.LookupTensileStrength(RSWIN_DESC.rst.Sections(i))
					End If
					text = "r:taper-tensile-strength"
					MRodstarXML.AddDecimalElement(xmlElement2, text, CDbl(RSWIN_DESC.rst.Sections(i).TensileStrength))
					RODUTIL.LookupStressMethod(RSWIN_DESC.rst.Sections(i))
					text = "r:taper-stress-method"
					MRodstarXML.AddDecimalElement(xmlElement2, text, CDbl(RSWIN_DESC.rst.Sections(i).StressMethod))
					If RSWIN_DESC.rst.Sections(i).friction_coef >= 0F Then
						text = "r:taper-friction-coef"
						MRodstarXML.AddDecimalElement(xmlElement2, text, CDbl(Util.ConvertToDouble(Conversions.ToString(RSWIN_DESC.rst.Sections(i).friction_coef))))
					Else
						text = "r:taper-friction-coef"
						MRodstarXML.AddDecimalElement(xmlElement2, text, 0.0)
					End If
					If RSWIN_DESC.bRodStarD Then
						If RSWIN_DESC.rst.Sections(i).NumGuides >= 0S Then
							text = "r:taper-num-guides"
							MRodstarXML.AddDecimalElement(xmlElement2, text, CDbl(RSWIN_DESC.rst.Sections(i).NumGuides))
						Else
							text = "r:taper-num-guides"
							MRodstarXML.AddDecimalElement(xmlElement2, text, 0.0)
						End If
					End If
					xmlElement2.SetAttribute("order", Convert.ToString(i))
					xmlElement.AppendChild(xmlElement2)
				Next
				rElt.AppendChild(xmlElement)
			End If
		End Sub

		Private Function AddStringElement(ByRef myWriter As XmlTextWriter, ByRef sTagName As String, ByRef sText As String, Optional bForceEmitEmptyString As Object = False) As Boolean
			Dim result As Boolean = True
			Try
				Dim xmlTextWriter As XmlTextWriter = myWriter
				xmlTextWriter.WriteStartElement(sTagName)
				xmlTextWriter.WriteString(sText)
				xmlTextWriter.WriteEndElement()
			Catch ex As Exception
				result = False
			End Try
			Return result
		End Function

		Private Function AddStringElement(ByRef rElt As XmlElement, ByRef sTagName As String, ByRef sText As String, Optional bForceEmitEmptyString As Object = False) As Boolean
			Dim result As Boolean = True
			Try
				If Conversions.ToBoolean(Operators.OrObject(sText.Length > 0, bForceEmitEmptyString)) Then
					Dim ownerDocument As XmlDocument = rElt.OwnerDocument
					Dim xmlElement As XmlElement = ownerDocument.CreateElement(sTagName)
					xmlElement.AppendChild(ownerDocument.CreateTextNode(sText))
					rElt.AppendChild(xmlElement)
				End If
			Catch ex As Exception
				result = False
			End Try
			Return result
		End Function

		Private Sub CheckInputData(Optional sFileName As String = "")
			Dim num As Integer
			Dim num6 As Integer
			Dim obj2 As Object
			Try
				ProjectData.ClearProjectError()
				num = 2
				Dim pu As RSWIN_DESC.PUDataRec
				pu.Initialize()
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				Dim unitID As String = rst.UnitID
				pu = rst.PU
				rst.OilSPGR = CSng((141.5 / (CDbl(rst.OilAPI) + 131.5)))
				RSWIN_DESC.WarnedAboutFluidInertia = -1S
				RSWIN_DESC.WarnedAboutPlungerSize = -1S
				If Not rst.gbCalcPumpCondition AndAlso rst.PumpCondition = 1S Then
					rst.PumpFillage = 0F
				End If
				If rst.RodStringType = 1S Then
					rst.APIRodType = rst.Sections(1).RodType
					rst.APITensileStrength = rst.Sections(1).TensileStrength
				Else
					rst.APIRod = 0S
					rst.APIGrade = 0S
				End If
				Dim sinkerBar As RSWIN_DESC.RodSection
				If rst.RodStringType = 3S Then
					If(If((-If(((rst.giRodDesignStyle <> 0S) > False), 1S, 0S)), 1S, 0S) And Not rst.RSIncludeSB And Not rst.RSFGIncludeSteel) <> 0S Then
						rst.RSIncludeSB = -1S
					End If
				Else
					rst.RSGrade = 0S
					rst.RSMaxSize = 0F
					rst.RSSRSize = 0F
					rst.RSMinSize = 0F
					rst.SinkerBar = sinkerBar
				End If
				If Strings.InStr(sFileName.ToLower(), "xrvx", CompareMethod.Binary) <= 0 Then
					Dim num2 As Short
					Dim obj As Object = num2
					Dim text As String
					PUDATA1.ParseUnitID(unitID, text, obj)
					num2 = Conversions.ToShort(obj)
					Dim text2 As String = text
					If Operators.CompareString(text2, "CAB", False) = 0 Then
						Dim cRODSTAR As cRODSTAR = rst
						Dim str As String = "CAA"
						obj = CInt((num2 + 98S))
						cRODSTAR.UnitID = str + Util.Format(obj).Trim()
					End If
					Dim num3 As Integer = CInt(pu.CrankHole)
					Dim crankRotation As Integer = CInt(pu.CrankRotation)
					If Not MRodstarXML.bCustomPU Then
						PUDATA1.ReadPUData(rst.UnitID, pu, False, True)
					ElseIf MRodstarXML.bErrorCustomPU Then
						PUDATA1.ReadPUData(rst.UnitID, pu, False, True)
					End If
					pu.CrankHole = CShort(num3)
					pu.CrankRotation = CShort(crankRotation)
					If Not(pu.UnitType = 7S Or pu.UnitType = 10S) Then
						If num3 = 0 Then
							num3 = 1
							pu.CrankHole = CShort(num3)
						End If
						pu.R = pu.CrankRadii(CInt((pu.CrankHole - 1S)))
					Else
						pu.R = pu.CrankRadii(0)
					End If
					If pu.UnitType = 7S Or pu.UnitType = 10S Or pu.UnitType = 6S Then
						rst.CalcMotorSPV = 0S
						rst.MotorSPV = 0F
					End If
					kinemat.Kinconst(pu)
					kinemat.Unitstroke(pu)
					rst.PU = pu
					If RSWIN_DESC.rst.AdjustedStrokeLength <= 0F And RSWIN_DESC.rst.PU.MaxStroke <> 0F Then
						RSWIN_DESC.rst.AdjustedStrokeLength = RSWIN_DESC.rst.PU.MaxStroke
					End If
					If Strings.InStr(RSWIN_DESC.rst.UnitID, "CUSTOM", CompareMethod.Binary) > 0 And Not RSWIN_DESC.rst.gbAutomatic And Not RSWIN_DESC.rst.gbBatch Then
						Dim flag As Boolean = PUDATA1.CheckCustomUnitList(pu, sFileName)
					End If

						If rst.RodStringType = 3S AndAlso (If((-If(((rst.giRodDesignStyle <> 0S) > False), 1S, 0S)), 1S, 0S) Or rst.RSIncludeSB) <> 0S Then
							sinkerBar = rst.SinkerBar
							If sinkerBar.SuckerRodLength = 0F Then
								If(If((-If((RODUTIL.IsCorod(sinkerBar.Grade) > False), 1, 0)), 1, 0) Or RODUTIL.IsProRod(CInt(sinkerBar.Grade))) <> 0 Then
									sinkerBar.SuckerRodLength = 1F
								ElseIf RODUTIL.IsSteel(CInt(sinkerBar.Grade)) <> 0 Then
									sinkerBar.SuckerRodLength = RSWIN_DESC.SETUP_SteelSuckerRodLength
								ElseIf sinkerBar.Grade <> 16385S And sinkerBar.Grade <> 16389S And sinkerBar.Grade <> 16390S Then
									sinkerBar.SuckerRodLength = 37.5F
								End If
							End If
							rst.SinkerBar = sinkerBar
							If rst.RSSBDiameter <> rst.SinkerBar.Diameter Then
								rst.RSSBDiameter = rst.SinkerBar.Diameter
							End If
						End If
						RODUTIL.CheckCustomRodGrades()

					If rst.RodStringType = 3S Then
						If(RSWIN_DESC.rst.RSGrade = 0S And MRodstarXML.sRSGrade <> Nothing) AndAlso Operators.CompareString(MRodstarXML.sRSGrade.Trim(), "", False) <> 0 Then
							RSWIN_DESC.rst.RSGrade = CShort(MRodstarXML.DoCustomSteelRodGradeLookup(MRodstarXML.sRSGrade))
						End If
						If rst.RSIncludeSB And If((-If(((sinkerBar.Grade = 0S) > False), 1S, 0S)), 1S, 0S) And If((-If(((MRodstarXML.sRSSBGrade <> Nothing) > False), 1S, 0S)), 1S, 0S) <> 0S AndAlso Operators.CompareString(MRodstarXML.sRSSBGrade.Trim(), "", False) <> 0 Then
							sinkerBar.Grade = CShort(MRodstarXML.DoCustomSteelRodGradeLookup(MRodstarXML.sRSSBGrade))
						End If
					End If
					If rst.RodStringType = 2S Or rst.RodStringType = 4S Then
						Dim num4 As Integer = 1
						Dim numRods As Integer = CInt(rst.NumRods)
						For i As Integer = num4 To numRods
							RODUTIL.LookupRodDiameterForCorrection(rst.Sections(i))
							Dim sections As RSWIN_DESC.RodSection() = rst.Sections
							Dim num5 As Integer = i
							sections(num5).Area = CSng((CDbl((sections(num5).Diameter * sections(num5).Diameter)) * Math.Atan(1.0)))
							RODUTIL.LookupElasticity(rst.Sections(i))
							RODUTIL.LookupRodWeight(rst.Sections(i))
							RODUTIL.LookupStressMethod(rst.Sections(i))
							If Not CUSTOMRG.IsOtherSteel(CInt(rst.Sections(i).Grade)) Then
								RODUTIL.LookupTensileStrength(rst.Sections(i))
							ElseIf rst.Sections(i).TensileStrength = 0F Then
								RODUTIL.LookupTensileStrength(rst.Sections(i))
							End If
							If rst.Sections(i).Grade = 20481S Then
								rst.Sections(i).RodDensity = 100F
							ElseIf rst.Sections(i).Grade = 16393S Then
								rst.Sections(i).RodDensity = 125F
							ElseIf RODUTIL.IsFG(rst.Sections(i).Grade) Then
								rst.Sections(i).RodDensity = 130F
							Else
								rst.Sections(i).RodDensity = 491F
							End If
						Next
					End If
				End If
				IL_6C2:
				GoTo IL_709
				IL_6C4:
				num6 = -1
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_6DA:
			Catch obj3 When endfilter(TypeOf obj2 Is Exception And num <> 0 And num6 = 0)
				Dim ex As Exception = CType(obj3, Exception)
				GoTo IL_6C4
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_709:
			If num6 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		Private Function DoLookup(ByRef mnLookup As Collection, vIndex As Object) As Object
			Dim objectValue As Object
			Try
				If Not Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(vIndex)) Then
					objectValue = RuntimeHelpers.GetObjectValue(mnLookup(RuntimeHelpers.GetObjectValue(vIndex)))
				Else
					Try
						objectValue = RuntimeHelpers.GetObjectValue(mnLookup(Operators.ConcatenateObject("#", vIndex)))
					Catch ex As Exception
					End Try
				End If
			Catch ex2 As Exception
			End Try
			Return objectValue
		End Function

		Private Function LoadInputXML(ByRef xmlDoc As XmlDocument, ByRef nsmgr As XmlNamespaceManager, Optional bXROD As Boolean = False) As Boolean
			Dim text As String = New String(" "c, 40)
			Dim text2 As String = ""
			Dim text3 As String = ""
			Dim result As Boolean
			Try
				If RSWIN_DESC.bRodStarD Then
					Dim text4 As String = "GuideToUse"
					Dim molded As Integer = CInt(RSWIN_DESC.MOLDED)
					Dim regProfileStringByInt As String = RSWIN.GetRegProfileStringByInt(RSWIN_DESC.SECT_RSWIN, text4, molded)
					RSWIN_DESC.MOLDED = CShort(molded)
					RSWIN_DESC.SETUP_GuideToUse = Conversions.ToInteger(regProfileStringByInt)
					If RSWIN_DESC.SETUP_GuideToUse = 0 Then
						RSWIN_DESC.SETUP_GuideToUse = CInt(RSWIN_DESC.MOLDED)
						text4 = "GuideToUse"
						Dim text5 As String = Conversions.ToString(CInt(RSWIN_DESC.MOLDED))
						RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text4, text5, RSWIN_DESC.sINIFile)
						RSWIN_DESC.MOLDED = Conversions.ToShort(text5)
					End If
				End If
				Application.DoEvents()
				Application.DoEvents()
				MRodstarXML.bCustomPU = False
				MRodstarXML.bErrorCustomPU = False
				Dim pu As RSWIN_DESC.PUDataRec
				pu.Initialize()
				RSWIN_DESC.rst.PU.Initialize()
				Dim xmlNode As XmlNode = xmlDoc.SelectSingleNode("//r:input", nsmgr)
				Dim xmlNode2 As XmlNode = xmlNode
				Dim xmlNode3 As XmlNode
				Try
					xmlNode3 = xmlNode2.SelectSingleNode("r:calc-friction", nsmgr)
				Catch ex As Exception
				End Try
				Try
					RSWIN_DESC.rst.bSaveFlag = MRodstarXML.CheckBoolean(xmlNode2.SelectSingleNode("r:rodstard-save-flag", nsmgr).InnerText)
				Catch ex2 As Exception
					RSWIN_DESC.rst.bSaveFlag = False
				End Try
				If RSWIN_DESC.rst.bSaveFlag And Not RSWIN_DESC.bRodStarD Then
					RSWIN_DESC.rst.CalcFriction = -1S
				ElseIf RSWIN_DESC.bRodStarD And Not RSWIN_DESC.rst.bSaveFlag Then
					RSWIN_DESC.rst.CalcFriction = -1S
				Else
					Try
						RSWIN_DESC.rst.CalcFriction = CShort(Math.Round(CDbl(Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:calc-friction", nsmgr).InnerText))))
					Catch ex3 As Exception
					End Try
				End If
				RSWIN_DESC.rst.CalcMotorSize = Conversions.ToShort(Util.ConvertToInt16(xmlNode2.SelectSingleNode("r:calc-motor-size", nsmgr).InnerText))
				RSWIN_DESC.rst.CalcMotorSPV = Conversions.ToShort(Util.ConvertToInt16(xmlNode2.SelectSingleNode("r:calc-motor-spv", nsmgr).InnerText))
				RSWIN_DESC.rst.CalcPlungerSize = Conversions.ToShort(Util.ConvertToInt16(xmlNode2.SelectSingleNode("r:calc-plunger-size", nsmgr).InnerText))
				RSWIN_DESC.rst.CasingPressure = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:casing-pressure", nsmgr).InnerText)
				RSWIN_DESC.rst.CBDataFile = Convert.ToString(xmlNode2.SelectSingleNode("r:cbalance-file", nsmgr).InnerText)
				RSWIN_DESC.rst.ACompanyName = Convert.ToString(xmlNode2.SelectSingleNode("r:company-name", nsmgr).InnerText)
				RSWIN_DESC.rst.CompressibilityIndex = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:compressibility-index", nsmgr).InnerText)
				Try
					RSWIN_DESC.rst.DownstrokeFriction = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:rod-tubing-friction-downstroke", nsmgr).InnerText)
				Catch ex4 As Exception
				End Try
				If RSWIN_DESC.bRodStarD And CDbl(RSWIN_DESC.rst.DownstrokeFriction) > 0.5 Then
					RSWIN_DESC.rst.DownstrokeFriction = 0.1F
				ElseIf RSWIN_DESC.rst.bSaveFlag And Not RSWIN_DESC.bRodStarD Then
					RSWIN_DESC.rst.DownstrokeFriction = 1F
				ElseIf Not RSWIN_DESC.rst.bSaveFlag And RSWIN_DESC.bRodStarD Then
					RSWIN_DESC.rst.DownstrokeFriction = 0.1F
				End If
				RSWIN_DESC.rst.ElectricityCost = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:electricity-cost", nsmgr).InnerText)
				RSWIN_DESC.rst.FileComment = Convert.ToString(xmlNode2.SelectSingleNode("r:comment", nsmgr).InnerText)
				Try
					RSWIN_DESC.rst.CoverPageComment = Convert.ToString(xmlNode2.SelectSingleNode("r:cover-page-comment", nsmgr).InnerText)
				Catch ex5 As Exception
					RSWIN_DESC.rst.CoverPageComment = ""
				End Try
				RSWIN_DESC.rst.FluidDamping = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:fluid-damping", nsmgr).InnerText)
				RSWIN_DESC.rst.FluidLevel = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:fluid-level", nsmgr).InnerText)
				xmlNode3 = xmlNode2.SelectSingleNode("r:calc-friction", nsmgr)
				Dim flag As Boolean
				Try
					flag = MRodstarXML.CheckBoolean(xmlNode2.SelectSingleNode("r:calc-fluid-level", nsmgr).InnerText)
				Catch ex6 As Exception
					flag = False
				End Try
				RSWIN_DESC.rst.giFluidLevelSource = 0S
				RSWIN_DESC.rst.FluidLevelEntered = Not flag
				If RSWIN_DESC.rst.FluidLevelEntered Then
					RSWIN_DESC.rst.giFluidLevelSource = 1S
				End If
				RSWIN_DESC.rst.FluidSPGR = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:fluid-spgr", nsmgr).InnerText)
				RSWIN_DESC.rst.gbCalcPumpCondition = Conversions.ToBoolean(Util.ConvertToInt16(xmlNode2.SelectSingleNode("r:calc-pump-condition", nsmgr).InnerText))
				RSWIN_DESC.rst.gbCalcPumpIntakePressure = MRodstarXML.CheckBoolean(xmlNode2.SelectSingleNode("r:calc-pump-intake-pressure", nsmgr).InnerText)
				RSWIN_DESC.rst.gbCalcTargetBFPD = MRodstarXML.CheckBoolean(xmlNode2.SelectSingleNode("r:calc-target-production", nsmgr).InnerText)
				RSWIN_DESC.rst.gbIncludeBuoyancy = MRodstarXML.CheckBoolean(xmlNode2.SelectSingleNode("r:include-buoyancy", nsmgr).InnerText)
				RSWIN_DESC.rst.Iart = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:inertia-articulating", nsmgr).InnerText)
				RSWIN_DESC.rst.IncludeFluidInertia = Conversions.ToShort(Util.ConvertToInt16(xmlNode2.SelectSingleNode("r:include-fluid-inertia", nsmgr).InnerText))
				RSWIN_DESC.rst.Irot = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:inertia-rotating", nsmgr).InnerText)
				RSWIN_DESC.rst.IrotEntered = Conversions.ToShort(Operators.NotObject(Util.ConvertToInt16(xmlNode2.SelectSingleNode("r:calc-irot", nsmgr).InnerText)))
				RSWIN_DESC.rst.MotorSPV = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:motor-speed-variation", nsmgr).InnerText)
				RSWIN_DESC.rst.OilAPI = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:oil-density", nsmgr).InnerText)

					RSWIN_DESC.rst.OilSPGR = CSng((141.5 / (CDbl(RSWIN_DESC.rst.OilAPI) + 131.5)))
					RSWIN_DESC.rst.PlungerSize = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:plunger-size", nsmgr).InnerText)
					If RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru And RSWIN_DESC.rst.PlungerSize = 0F Then
						RSWIN_DESC.rst.PlungerSize = 1.5F
					End If
					RSWIN_DESC.rst.Apump = CSng((3.141592653589793 * CDbl(RSWIN_DESC.rst.PlungerSize) * CDbl(RSWIN_DESC.rst.PlungerSize) / 4.0))

				RSWIN_DESC.rst.PowerMeterType = CShort(Conversions.ToInteger(MRodstarXML.DoLookup(MRodstarXML.mnLookupPowerMeterType, xmlNode2.SelectSingleNode("r:power-meter-type", nsmgr).InnerText)))
				RSWIN_DESC.rst.PumpCondition = CShort(Conversions.ToInteger(MRodstarXML.DoLookup(MRodstarXML.mnLookupPumpCondition, xmlNode2.SelectSingleNode("r:pump-condition", nsmgr).InnerText)))
				RSWIN_DESC.rst.PumpDragDownstrokeMax = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:max-pump-drag-downstroke", nsmgr).InnerText)
				RSWIN_DESC.rst.PumpDragUpstrokeMax = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:max-pump-drag-upstroke", nsmgr).InnerText)
				RSWIN_DESC.rst.PumpDepth = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:pump-depth", nsmgr).InnerText)
				Try
					RSWIN_DESC.rst.gbCalcFluidSPGR = Conversions.ToBoolean(Util.ConvertToInt16(xmlNode2.SelectSingleNode("r:calc-fluid-spgr", nsmgr).InnerText))
				Catch ex7 As Exception
					RSWIN_DESC.rst.gbCalcFluidSPGR = False
				End Try
				If RSWIN_DESC.bRodStarD Then
					Try
						RSWIN_DESC.rst.gbParaffin = Conversions.ToBoolean(Util.ConvertToInt16(xmlNode2.SelectSingleNode("r:paraffin", nsmgr).InnerText))
					Catch ex8 As Exception
						RSWIN_DESC.rst.gbParaffin = False
					End Try
					Try
						RSWIN_DESC.rst.ParaffinDepth = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:paraffin-depth", nsmgr).InnerText)
					Catch ex9 As Exception
						RSWIN_DESC.rst.ParaffinDepth = 0F
					End Try
				End If
				Try
					RSWIN_DESC.rst.IntermediateDepth = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:intermediate-depth", nsmgr).InnerText)
				Catch ex10 As Exception
					RSWIN_DESC.rst.IntermediateDepth = 0F
				End Try
				RSWIN_DESC.rst.PumpEfficiency = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:pump-efficiency", nsmgr).InnerText)
				RSWIN_DESC.rst.PumpFillage = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:pump-fillage", nsmgr).InnerText)
				If RSWIN_DESC.bRodStarD Then
					If RSWIN_DESC.rst.PumpEfficiency = 0F Then
						RSWIN_DESC.rst.PumpEfficiency = 85F
					End If
					If RSWIN_DESC.rst.PumpFillage = 0F Then
						RSWIN_DESC.rst.PumpFillage = 85F
					End If
				End If
				RSWIN_DESC.rst.PumpFriction = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:pump-friction", nsmgr).InnerText)
				RSWIN_DESC.rst.PumpIntakePressure = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:pump-intake-pressure", nsmgr).InnerText)
				RSWIN_DESC.rst.UPumpIntakePressure = RSWIN_DESC.rst.PumpIntakePressure
				RSWIN_DESC.rst.PumpLoadAdj = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:pump-load-adjustment", nsmgr).InnerText)
				RSWIN_DESC.rst.PumpType = CShort(Conversions.ToInteger(MRodstarXML.DoLookup(MRodstarXML.mnLookupPumpType, xmlNode2.SelectSingleNode("r:pump-type", nsmgr).InnerText)))
				Try
					RSWIN_DESC.rst.VSP = MRodstarXML.CheckBoolean(xmlNode2.SelectSingleNode("r:vsp", nsmgr).InnerText)
				Catch ex11 As Exception
					RSWIN_DESC.rst.VSP = False
				End Try
				If Not bXROD Then
					RSWIN_DESC.rst.RSExtraCost = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:rod-string-extra-cost", nsmgr).InnerText)
					RSWIN_DESC.rst.RSExtraCostLabel = Convert.ToString(xmlNode2.SelectSingleNode("r:rod-string-extra-cost-desc", nsmgr).InnerText)
					RSWIN_DESC.rst.ServiceFactor = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:service-factor", nsmgr).InnerText)
				End If
				RSWIN_DESC.rst.Runtime = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:runtime", nsmgr).InnerText)
				RSWIN_DESC.rst.SPM = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:pumping-speed", nsmgr).InnerText)
				RSWIN_DESC.rst.SPMEntered = Conversions.ToShort(Operators.NotObject(Util.ConvertToInt16(xmlNode2.SelectSingleNode("r:calc-pumping-speed", nsmgr).InnerText)))
				RSWIN_DESC.rst.StuffingBoxFriction = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:stuffing-box-friction", nsmgr).InnerText)
				RSWIN_DESC.rst.TargetBFPD = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:target-production", nsmgr).InnerText)
				RSWIN_DESC.rst.TubingAnchorDepth = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:tubing-anchor-depth", nsmgr).InnerText)
				RSWIN_DESC.rst.TubingAnchored = Conversions.ToShort(Util.ConvertToInt16(xmlNode2.SelectSingleNode("r:tubing-anchored", nsmgr).InnerText))
				RSWIN_DESC.rst.TubingID = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:tubing-id", nsmgr).InnerText)
				RSWIN_DESC.rst.TubingOD = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:tubing-od", nsmgr).InnerText)
				RSWIN_DESC.rst.TubingPressure = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:tubing-pressure", nsmgr).InnerText)
				RSWIN_DESC.rst.UpstrokeFriction = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:rod-tubing-friction-upstroke", nsmgr).InnerText)
				If RSWIN_DESC.bRodStarD And CDbl(RSWIN_DESC.rst.UpstrokeFriction) > 0.5 Then
					RSWIN_DESC.rst.UpstrokeFriction = 0.1F
				ElseIf RSWIN_DESC.rst.bSaveFlag And Not RSWIN_DESC.bRodStarD Then
					RSWIN_DESC.rst.UpstrokeFriction = 1F
				ElseIf Not RSWIN_DESC.rst.bSaveFlag And RSWIN_DESC.bRodStarD Then
					RSWIN_DESC.rst.UpstrokeFriction = 0.1F
				End If
				Try
					RSWIN_DESC.rst.SlideFricCoeff = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:sliding-friction-coeff", nsmgr).InnerText)
					If RSWIN_DESC.rst.SlideFricCoeff = 0F Then
						RSWIN_DESC.rst.SlideFricCoeff = 0.2F
					End If
				Catch ex12 As Exception
					RSWIN_DESC.rst.SlideFricCoeff = 0.2F
				End Try
				RSWIN_DESC.rst.UserDate = Convert.ToString(xmlNode2.SelectSingleNode("r:date", nsmgr).InnerText)
				RSWIN_DESC.rst.UserName = Convert.ToString(xmlNode2.SelectSingleNode("r:user-name", nsmgr).InnerText)
				RSWIN_DESC.rst.WaterCut = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:water-cut", nsmgr).InnerText)
				RSWIN_DESC.rst.WaterSPGR = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:water-spgr", nsmgr).InnerText)
				If RSWIN_DESC.rst.WaterSPGR < 1F Then
					RSWIN_DESC.rst.WaterSPGR = 1F
				ElseIf CDbl(RSWIN_DESC.rst.WaterSPGR) > 1.5 Then
					RSWIN_DESC.rst.WaterSPGR = 1.5F
				End If
				RSWIN_DESC.rst.WellName = Convert.ToString(xmlNode2.SelectSingleNode("r:well-name", nsmgr).InnerText)
				Try
					RSWIN_DESC.rst.gbDesignSinkerbar = MRodstarXML.CheckBoolean(xmlNode2.SelectSingleNode("r:design-sinkerbar", nsmgr).InnerText)
				Catch ex13 As Exception
					RSWIN_DESC.rst.gbDesignSinkerbar = False
				End Try
				RSWIN_DESC.rst.bDeviated = MRodstarXML.CheckBoolean(xmlNode2.SelectSingleNode("r:deviated-case", nsmgr).InnerText)
				If RSWIN_DESC.rst.gbCalcFluidSPGR Then
					RSWIN_DESC.rst.gfMaxFluidSPGR = LoadXDG.MaxFluidSPGR(RSWIN_DESC.rst.WaterCut, RSWIN_DESC.rst.WaterSPGR, RSWIN_DESC.rst.OilSPGR)
					RSWIN_DESC.rst.FluidSPGR = RSWIN_DESC.rst.gfMaxFluidSPGR
				End If
				If Not RSWIN_DESC.rst.bDeviated Then
					RSWIN_DESC.rst.giThisVersion = 29S
				Else
					RSWIN_DESC.rst.giThisVersion = 31S
				End If
				If RSWIN_DESC.bRodStarD Then
					RSWIN_DESC.SavedUpstrokeFriction = RSWIN_DESC.rst.UpstrokeFriction
					RSWIN_DESC.SavedDownstrokeFriction = RSWIN_DESC.rst.DownstrokeFriction
				End If
				MImpred.InitSurveyDataset(RSWIN_DESC.mdsDeviationProfile, Nothing)
				If RSWIN_DESC.bRodStarD Then
					Dim num As Single = -1F
					Dim xmlNodeList As XmlNodeList = xmlNode2.SelectNodes("r:deviation-survey", nsmgr)
					If xmlNodeList.Count > 0 Then
						Dim xmlNodeList2 As XmlNodeList = xmlNode2.SelectNodes("r:deviation-survey/r:survey-point", nsmgr)
						Dim xmlNodeList3 As XmlNodeList = xmlNodeList2
						Dim count As Integer = xmlNodeList3.Count
						Dim enumerator As IEnumerator = xmlNodeList3.GetEnumerator()
						Dim num2 As Integer = 0
						If xmlNodeList3.Count > 0 Then
						End If
						While enumerator.MoveNext()
							Dim obj As Object = enumerator.Current
							xmlNode3 = CType(obj, XmlNode)
							Console.WriteLine(xmlNode3.InnerText)
							Dim dataRow As DataRow = RSWIN_DESC.mdsDeviationProfile.Tables(0).NewRow()
							dataRow("EntryNumber") = num2 + 1
							dataRow("Depth") = Util.ConvertToSingle(xmlNode3("r:measured-depth").InnerText)
							dataRow("Inclination") = Util.CheckDec(xmlNode3("r:inclination").InnerText)
							dataRow("Azimuth") = Util.CheckDec(xmlNode3("r:azimuth").InnerText)
							dataRow("Dogleg") = DBNull.Value
							dataRow("TVDepth") = DBNull.Value
							dataRow("NorthSouth") = DBNull.Value
							dataRow("EastWest") = DBNull.Value
							If Conversions.ToBoolean(Operators.AndObject(num2 + 1 = 1, Operators.NotObject(Operators.CompareObjectEqual(dataRow("Depth"), 0, False)))) Then
								Dim num3 As Single = Conversions.ToSingle(dataRow("Depth"))
								Dim value As String = Conversions.ToString(dataRow("Inclination"))
								Dim value2 As String = Conversions.ToString(dataRow("Azimuth"))
								dataRow("Depth") = 0
								dataRow("Inclination") = "0"
								dataRow("Azimuth") = "0"
								RSWIN_DESC.mdsDeviationProfile.Tables(0).Rows.Add(dataRow)
								num = 0F
								num2 += 1
								dataRow = RSWIN_DESC.mdsDeviationProfile.Tables(0).NewRow()
								dataRow("EntryNumber") = num2 + 1
								dataRow("Depth") = num3
								dataRow("Inclination") = value
								dataRow("Azimuth") = value2
								dataRow("Dogleg") = DBNull.Value
								dataRow("TVDepth") = DBNull.Value
								dataRow("NorthSouth") = DBNull.Value
								dataRow("EastWest") = DBNull.Value
							End If
							If Operators.ConditionalCompareObjectEqual(num, dataRow("Depth"), False) Then
								num2 -= 1
								Debug.WriteLine(Operators.ConcatenateObject("no add: previous depth=" + Conversions.ToString(num) + " , current depth=", dataRow("Depth")))
							Else
								RSWIN_DESC.mdsDeviationProfile.Tables(0).Rows.Add(dataRow)
								num = Conversions.ToSingle(dataRow("Depth"))
							End If
							num2 += 1
						End While
					End If
				End If
				RSWIN_DESC.mdsDeviationProfile_Edit = Nothing
				Application.DoEvents()
				Application.DoEvents()
				RSWIN_DESC.rst.gbUseIPR = False
				Dim flag2 As Boolean
				Try
					flag2 = False
					Dim xmlNode4 As XmlNode = xmlNode2.SelectSingleNode("r:ipr-profile", nsmgr)
					Dim innerText As String = xmlNode4.InnerText
					If Operators.CompareString(innerText, "xsi:nil", False) = 0 Then
						flag2 = True
					End If
				Catch ex14 As Exception
					flag2 = False
				End Try
				Dim num4 As Integer = Conversions.ToInteger(Util.ConvertToInt32(Conversions.ToString(xmlNode2.SelectNodes("r:ipr-profile", nsmgr).Count)))
				RSWIN_DESC.rst.gbUseIPR = (num4 <> 0 And Not flag2)
				If((Not RSWIN_DESC.rst.gbUseIPR And RSWIN_DESC.rst.giFluidLevelSource <> 1S) AndAlso flag) And RSWIN_DESC.rst.PumpIntakePressure > 0F Then
					RSWIN_DESC.rst.giFluidLevelSource = 2S
				End If
				If RSWIN_DESC.rst.gbUseIPR Then
					Dim xmlNode5 As XmlNode = xmlNode2.SelectSingleNode("r:ipr-profile", nsmgr)
					Try
						RSWIN_DESC.rst.BubblePoint = Util.ConvertToSingle(xmlNode5.SelectSingleNode("r:bubble-point-pressure", nsmgr).InnerText)
					Catch ex15 As Exception
					End Try
					Try
						RSWIN_DESC.rst.gbCalcFetkovichN = Conversions.ToBoolean(xmlNode5.SelectSingleNode("r:calc-fetkovich-n", nsmgr).InnerText)
					Catch ex16 As Exception
					End Try
					Try
						RSWIN_DESC.rst.gbProducingBelowBPP = Conversions.ToBoolean(xmlNode5.SelectSingleNode("r:producing-below-bubble-point", nsmgr).InnerText)
					Catch ex17 As Exception
					End Try
					Try
						RSWIN_DESC.rst.giIPRMethod = CShort(Conversions.ToInteger(MRodstarXML.DoLookup(MRodstarXML.mnLookupIPRCorrelation, xmlNode5.SelectSingleNode("r:ipr-correlation", nsmgr).InnerText)))
					Catch ex18 As Exception
					End Try
					Try
						RSWIN_DESC.rst.FetkovichN = Util.ConvertToSingle(xmlNode5.SelectSingleNode("r:fetkovich-n", nsmgr).InnerText)
					Catch ex19 As Exception
					End Try
					Try
						RSWIN_DESC.rst.MidPerfDepth = Util.ConvertToSingle(xmlNode5.SelectSingleNode("r:mid-perf-depth", nsmgr).InnerText)
					Catch ex20 As Exception
					End Try
					Try
						RSWIN_DESC.rst.StaticBHPressure = Util.ConvertToSingle(xmlNode5.SelectSingleNode("r:static-bottom-hole-pressure", nsmgr).InnerText)
					Catch ex21 As Exception
					End Try
					Dim xmlNodeList2 As XmlNodeList = xmlNode5.SelectNodes(".//r:ipr-test-point", nsmgr)
					Dim xmlNodeList4 As XmlNodeList = xmlNodeList2
					RSWIN_DESC.rst.gnTestPoints = CShort(xmlNodeList4.Count)
					Dim testPoints As RSWIN_DESC.IPRTESTPOINT() = New RSWIN_DESC.IPRTESTPOINT(CInt((RSWIN_DESC.rst.gnTestPoints + 1S)) - 1) {}
					RSWIN_DESC.rst.TestPoints = testPoints
					Dim enumerator As IEnumerator = xmlNodeList4.GetEnumerator()
					Dim num2 As Integer = 1
					While enumerator.MoveNext()
						Dim obj2 As Object = enumerator.Current
						xmlNode3 = CType(obj2, XmlNode)
						RSWIN_DESC.rst.TestPoints(num2).Production = Util.ConvertToSingle(xmlNode3("r:fluid-production").InnerText)
						RSWIN_DESC.rst.TestPoints(num2).bPIEntered = If(-If(((xmlNode3("r:flowing-wellbore-pressure") Is Nothing) > False), 1S, 0S), 1S, 0S)
						If RSWIN_DESC.rst.TestPoints(num2).bPIEntered <> 0S Then
							RSWIN_DESC.rst.TestPoints(num2).Pintake = Util.ConvertToSingle(xmlNode3("r:pump-intake-pressure").InnerText)
						Else
							RSWIN_DESC.rst.TestPoints(num2).Pwf = Util.ConvertToSingle(xmlNode3("r:flowing-wellbore-pressure").InnerText)
						End If
						num2 += 1
					End While
					xmlNode5 = Nothing
				End If
				Dim count2 As Integer = xmlNode2.SelectNodes("r:max-existing-counterbalance", nsmgr).Count
				RSWIN_DESC.rst.UnknownM = Conversions.ToBoolean(Interaction.IIf(count2 = 0, True, False))
				Try
					RSWIN_DESC.rst.CBDataType = Conversions.ToShort(xmlNode2.SelectSingleNode("r:cb-datatype", nsmgr).InnerText)
				Catch ex22 As Exception
					RSWIN_DESC.rst.CBDataType = 0S
				End Try
				If RSWIN_DESC.rst.UnknownM Then
					RSWIN_DESC.rst.set_M(2, 0F)
				Else
					Try
						RSWIN_DESC.rst.set_M(2, Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:max-existing-counterbalance", nsmgr).InnerText))
						If RSWIN_DESC.rst.get_M(2) > 0F And RSWIN_DESC.rst.CBDataType = 0S Then
							RSWIN_DESC.rst.CBDataType = 1S
						End If
					Catch ex23 As Exception
						RSWIN_DESC.rst.set_M(2, 0F)
						RSWIN_DESC.rst.UnknownM = True
					End Try
				End If
				RSWIN_DESC.rst.UnknownM = (RSWIN_DESC.rst.get_M(2) = 0F)
				Try
					RSWIN_DESC.rst.CBEffect = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:cb-effect", nsmgr).InnerText)
				Catch ex24 As Exception
					RSWIN_DESC.rst.CBEffect = 0F
				End Try
				Try
					RSWIN_DESC.rst.CBAngle = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:cb-angle", nsmgr).InnerText)
					If RSWIN_DESC.rst.CBEffect > 0F And RSWIN_DESC.rst.CBAngle > 0F And RSWIN_DESC.rst.get_M(2) = 0F Then
						RSWIN_DESC.rst.CBDataType = 2S
					End If
				Catch ex25 As Exception
					RSWIN_DESC.rst.CBAngle = 0F
				End Try
				Application.DoEvents()
				Application.DoEvents()
				count2 = xmlNode2.SelectNodes("r:measured-dynamometer-card", nsmgr).Count
				RSWIN_DESC.rst.gbRoddiagFile = (count2 <> 0)
				Dim array As Single()
				If RSWIN_DESC.rst.gbRoddiagFile Then
					Try
						Dim xmlNodeList2 As XmlNodeList = xmlNode2.SelectNodes(".//r:measured-dynamometer-card-point", nsmgr)
						Dim xmlNodeList5 As XmlNodeList = xmlNodeList2
						RSWIN_DESC.rst.RDNtsteps = CShort(xmlNodeList5.Count)
						array = New Single(CInt((RSWIN_DESC.rst.RDNtsteps - 1S + 1S)) - 1) {}
						RSWIN_DESC.rst.RDSurfLoad = array
						array = New Single(CInt((RSWIN_DESC.rst.RDNtsteps - 1S + 1S)) - 1) {}
						RSWIN_DESC.rst.RDSurfPos = array
						If RSWIN_DESC.rst.RDNtsteps > 0S Then
							Dim enumerator As IEnumerator = xmlNodeList5.GetEnumerator()
							Dim num2 As Integer = 0
							While enumerator.MoveNext()
								Dim obj3 As Object = enumerator.Current
								xmlNode3 = CType(obj3, XmlNode)
								RSWIN_DESC.rst.RDSurfLoad(num2) = Util.ConvertToSingle(xmlNode3("r:surface-load").InnerText)
								RSWIN_DESC.rst.RDSurfPos(num2) = Util.ConvertToSingle(xmlNode3("r:surface-position").InnerText)
								num2 += 1
							End While
						Else
							RSWIN_DESC.rst.gbRoddiagFile = False
						End If
						GoTo IL_19AD
					Catch ex26 As Exception
						RSWIN_DESC.rst.RDNtsteps = 0S
						array = New Single(0) {}
						RSWIN_DESC.rst.RDSurfLoad = array
						array = New Single(0) {}
						RSWIN_DESC.rst.RDSurfPos = array
						RSWIN_DESC.rst.gbRoddiagFile = False
						GoTo IL_19AD
					End Try
				End If
				RSWIN_DESC.rst.RDNtsteps = 0S
				array = New Single(0) {}
				RSWIN_DESC.rst.RDSurfLoad = array
				array = New Single(0) {}
				RSWIN_DESC.rst.RDSurfPos = array
				RSWIN_DESC.rst.gbRoddiagFile = False
				IL_19AD:
				Dim num5 As Integer = Conversions.ToInteger(Util.ConvertToInt32(xmlNode2.SelectSingleNode("r:motor-kind", nsmgr).InnerText))
				text2 = xmlNode2.SelectSingleNode("r:motor-size", nsmgr).InnerText
				text3 = xmlNode2.SelectSingleNode("r:motor-setting", nsmgr).InnerText
				If num5 > 7 Then
					Motor.CorrectMotorSizeSettingName(num5 + 1, text2)
					Motor.CorrectMotorSizeSettingName(num5 + 1, text3)
				End If
				If num5 = 0 AndAlso Operators.CompareString(text3.Trim(), "", False) = 0 Then
					text3 = text2
				End If
				Motor.SelectMotorKind(num5)
				Motor.SelectMotorSizeByName(text2)
				Motor.SelectMotorSettingByName(text3)
				RSWIN_DESC.rst.DragSettings = 0S
				Dim innerText2 As String = xmlNode2.SelectSingleNode("r:polrod-drag-proportionality", nsmgr).InnerText
				Dim num6 As Integer = 0
				If num6 <> Strings.StrComp(innerText2, "constant", CompareMethod.Binary) Then
					If num6 = Strings.StrComp(innerText2, "velocity", CompareMethod.Binary) Then
						RSWIN_DESC.rst.DragSettings = (RSWIN_DESC.rst.DragSettings Or 16S)
					ElseIf num6 = Strings.StrComp(innerText2, "velocity-squared", CompareMethod.Binary) Then
						RSWIN_DESC.rst.DragSettings = (RSWIN_DESC.rst.DragSettings Or 32S)
					End If
				End If
				innerText2 = xmlNode2.SelectSingleNode("r:pump-drag-d-proportionality", nsmgr).InnerText
				Dim num7 As Integer = 0
				If num7 <> Strings.StrComp(innerText2, "constant", CompareMethod.Binary) Then
					If num7 = Strings.StrComp(innerText2, "velocity", CompareMethod.Binary) Then
						RSWIN_DESC.rst.DragSettings = (RSWIN_DESC.rst.DragSettings Or 4S)
					ElseIf num7 = Strings.StrComp(innerText2, "velocity-squared", CompareMethod.Binary) Then
						RSWIN_DESC.rst.DragSettings = (RSWIN_DESC.rst.DragSettings Or 8S)
					End If
				End If
				innerText2 = xmlNode2.SelectSingleNode("r:pump-drag-u-proportionality", nsmgr).InnerText
				Dim num8 As Integer = 0
				If num8 <> Strings.StrComp(innerText2, "constant", CompareMethod.Binary) Then
					If num8 = Strings.StrComp(innerText2, "velocity", CompareMethod.Binary) Then
						RSWIN_DESC.rst.DragSettings = (RSWIN_DESC.rst.DragSettings Or 1S)
					ElseIf num8 = Strings.StrComp(innerText2, "velocity-squared", CompareMethod.Binary) Then
						RSWIN_DESC.rst.DragSettings = (RSWIN_DESC.rst.DragSettings Or 2S)
					End If
				End If
				pu = RSWIN_DESC.rst.PU
				Try
					RSWIN_DESC.rst.PR_Diameter = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:polished-rod-diameter", nsmgr).InnerText)
					If RSWIN_DESC.rst.PR_Diameter = 0F Then
						RSWIN_DESC.rst.PR_Diameter = 1.5F
					End If
				Catch ex27 As Exception
					RSWIN_DESC.rst.PR_Diameter = 1.5F
				End Try
				Try
					If Not bXROD Then
						Dim xmlNode6 As XmlNode = xmlNode2.SelectSingleNode("r:pumpingunit", nsmgr)
						Dim flag3 As Boolean = True
						Dim xmlNode7 As XmlNode
						If flag3 = xmlNode6.SelectNodes("r:pumpingunit-airbalanced", nsmgr).Count > 0 Then
							pu.UnitType = 6S
							xmlNode7 = xmlNode6.SelectSingleNode("r:pumpingunit-airbalanced", nsmgr)
						ElseIf flag3 = xmlNode6.SelectNodes("r:pumpingunit-conventional", nsmgr).Count > 0 Then
							pu.UnitType = 1S
							xmlNode7 = xmlNode6.SelectSingleNode("r:pumpingunit-conventional", nsmgr)
						ElseIf flag3 = xmlNode6.SelectNodes("r:pumpingunit-beambalanced", nsmgr).Count > 0 Then
							pu.UnitType = 8S
							xmlNode7 = xmlNode6.SelectSingleNode("r:pumpingunit-beambalanced", nsmgr)
						ElseIf flag3 = xmlNode6.SelectNodes("r:pumpingunit-combobeamcrank", nsmgr).Count > 0 Then
							pu.UnitType = 11S
							xmlNode7 = xmlNode6.SelectSingleNode("r:pumpingunit-combobeamcrank", nsmgr)
						ElseIf flag3 = xmlNode6.SelectNodes("r:pumpingunit-beltlowprofile", nsmgr).Count > 0 Then
							pu.UnitType = 9S
							xmlNode7 = xmlNode6.SelectSingleNode("r:pumpingunit-beltlowprofile", nsmgr)
						ElseIf flag3 = xmlNode6.SelectNodes("r:pumpingunit-grooves", nsmgr).Count > 0 Then
							pu.UnitType = 3S
							xmlNode7 = xmlNode6.SelectSingleNode("r:pumpingunit-grooves", nsmgr)
						ElseIf flag3 = xmlNode6.SelectNodes("r:pumpingunit-enhanced", nsmgr).Count > 0 Then
							pu.UnitType = 2S
							xmlNode7 = xmlNode6.SelectSingleNode("r:pumpingunit-enhanced", nsmgr)
						ElseIf flag3 = xmlNode6.SelectNodes("r:pumpingunit-longstroke", nsmgr).Count > 0 Then
							pu.UnitType = 7S
							xmlNode7 = xmlNode6.SelectSingleNode("r:pumpingunit-longstroke", nsmgr)
						ElseIf flag3 = xmlNode6.SelectNodes("r:pumpingunit-hydraulic", nsmgr).Count > 0 Then
							pu.UnitType = 10S
							xmlNode7 = xmlNode6.SelectSingleNode("r:pumpingunit-hydraulic", nsmgr)
						ElseIf flag3 = xmlNode6.SelectNodes("r:pumpingunit-lowprofile", nsmgr).Count > 0 Then
							pu.UnitType = 4S
							xmlNode7 = xmlNode6.SelectSingleNode("r:pumpingunit-lowprofile", nsmgr)
						ElseIf flag3 = xmlNode6.SelectNodes("r:pumpingunit-markii", nsmgr).Count > 0 Then
							pu.UnitType = 5S
							xmlNode7 = xmlNode6.SelectSingleNode("r:pumpingunit-markii", nsmgr)
						End If
						If xmlNode7 IsNot Nothing Then
							Dim xmlNode8 As XmlNode = xmlNode7
							xmlNode3 = xmlNode8.SelectSingleNode("r:pumping-unit-id", nsmgr)
							If xmlNode3 IsNot Nothing Then
								RSWIN_DESC.rst.IDEntered = -1S
								RSWIN_DESC.rst.UnitID = Convert.ToString(xmlNode8.SelectSingleNode("r:pumping-unit-id", nsmgr).InnerText)
							Else
								RSWIN_DESC.rst.IDEntered = 0S
								RSWIN_DESC.rst.UnitID = ""
							End If
							If(RSWIN_DESC.rst.IDEntered And If(-If((Strings.InStr(RSWIN_DESC.rst.UnitID, "CUSTOM", CompareMethod.Binary) > 0 > False), 1S, 0S), 1S, 0S)) <> 0S Then
								MRodstarXML.bCustomPU = True
							End If
							xmlNode3 = xmlNode8.SelectSingleNode("r:crank-rotation", nsmgr)
							pu.CrankRotation = CShort(Conversions.ToInteger(MRodstarXML.DoLookup(MRodstarXML.mnLookupCrankRotation, xmlNode8.SelectSingleNode("r:crank-rotation", nsmgr).InnerText)))
							Try
								pu.CrankHole = Conversions.ToShort(Util.ConvertToInt16(xmlNode8.SelectSingleNode("r:crank-hole-number", nsmgr).InnerText))
							Catch ex28 As Exception
							End Try
							If Not(pu.UnitType = 7S Or pu.UnitType = 10S) AndAlso pu.CrankHole = 0S Then
								pu.CrankHole = 1S
							End If
							If RSWIN_DESC.rst.IDEntered <> 0S Then
								RSWIN_DESC.rst.UnitID = Convert.ToString(xmlNode8.SelectSingleNode("r:pumping-unit-id", nsmgr).InnerText)
								If Strings.InStr(RSWIN_DESC.rst.UnitID, "CUSTOM", CompareMethod.Binary) > 0 Then
									MRodstarXML.bCustomPU = True
								End If
							End If
							Try
								RSWIN_DESC.rst.Unbalance = Util.ConvertToSingle(xmlNode8.SelectSingleNode("r:structural-unbalance", nsmgr).InnerText)
							Catch ex29 As Exception
								RSWIN_DESC.rst.Unbalance = 0F
							End Try
							If MRodstarXML.bCustomPU Then
								pu.APIDesignation = Convert.ToString(xmlNode8.SelectSingleNode("r:api-designation", nsmgr).InnerText)
								pu.Manuf = Convert.ToString(xmlNode8.SelectSingleNode("r:pumping-unit-manufacturer", nsmgr).InnerText)
								pu.OtherInfo = Convert.ToString(xmlNode8.SelectSingleNode("r:pumping-unit-other-info", nsmgr).InnerText)
								pu.UnitName = Convert.ToString(xmlNode8.SelectSingleNode("r:pumping-unit-name", nsmgr).InnerText)
								If pu.Manuf.Length < 40 Then
									pu.Manuf = pu.Manuf.PadRight(40)
								End If
								If pu.APIDesignation.Length < 40 Then
									pu.APIDesignation = pu.APIDesignation.PadRight(40)
								End If
								If pu.UnitName.Length < 40 Then
									pu.UnitName = pu.UnitName.PadRight(40)
								End If
								If pu.OtherInfo.Length < 40 Then
									pu.OtherInfo = pu.OtherInfo.PadRight(40)
								End If
								Try
									pu.StructRating = Util.ConvertToSingle(xmlNode8.SelectSingleNode("r:pumping-unit-struct-rating", nsmgr).InnerText)
								Catch ex30 As Exception
									MRodstarXML.bErrorCustomPU = True
								End Try
								Try
									pu.GearboxRating = Util.ConvertToSingle(xmlNode8.SelectSingleNode("r:pumping-unit-gearbox-rating", nsmgr).InnerText)
								Catch ex31 As Exception
									MRodstarXML.bErrorCustomPU = True
								End Try
								Try
									Dim num9 As Single = Util.ConvertToSingle(xmlNode8.SelectSingleNode("r:pumping-unit-max-stroke", nsmgr).InnerText)
									Dim text5 As String = "####.##"
									pu.MaxStroke = Conversions.ToSingle(Util.Format(num9, text5))
								Catch ex32 As Exception
									MRodstarXML.bErrorCustomPU = True
								End Try
								Try
									pu.ArtInertia = Util.ConvertToSingle(xmlNode8.SelectSingleNode("r:pumping-unit-art-inertia", nsmgr).InnerText)
								Catch ex33 As Exception
									MRodstarXML.bErrorCustomPU = True
								End Try
								If pu.UnitType = 7S Or pu.UnitType = 10S Then
									pu.DrumDiamRatio = Util.ConvertToSingle(xmlNode8.SelectSingleNode("r:drum-diameter-ratio", nsmgr).InnerText)
									pu.P = Util.ConvertToSingle(xmlNode8.SelectSingleNode("r:pitman-arm-length", nsmgr).InnerText)
									pu.SprocketDistance = Util.ConvertToSingle(xmlNode8.SelectSingleNode("r:sprocket-distance", nsmgr).InnerText)
									pu.SprocketRadius = Util.ConvertToSingle(xmlNode8.SelectSingleNode("r:sprocket-diameter", nsmgr).InnerText) / 2F
									If pu.CrankRadii Is Nothing Then
										pu.CrankRadii = New Single(4) {}
									End If
									If pu.Strokes Is Nothing Then
										pu.Strokes = New Single(4) {}
									End If
									pu.CrankHoles = 1S
									pu.CrankHole = 1S
									If pu.UnitType = 7S And pu.MaxStroke > 0F Then
										pu.Strokes(0) = pu.MaxStroke
									End If
								Else
									Dim xmlNodeList2 As XmlNodeList = xmlNode8.SelectNodes("r:pu-crank-radii/r:crank-radius", nsmgr)
									Dim xmlNodeList6 As XmlNodeList = xmlNodeList2
									pu.CrankHoles = CShort(xmlNodeList6.Count)
									Dim enumerator As IEnumerator = xmlNodeList6.GetEnumerator()
									If pu.CrankRadii Is Nothing Then
										pu.CrankRadii = New Single(4) {}
									End If
									If pu.Strokes Is Nothing Then
										pu.Strokes = New Single(4) {}
									End If
									Dim num2 As Integer = 1
									While enumerator.MoveNext()
										Dim obj4 As Object = enumerator.Current
										xmlNode3 = CType(obj4, XmlNode)
										pu.CrankRadii(num2 - 1) = Util.ConvertToSingle(xmlNode3("r:pu-apidimension-r").InnerText)
										pu.Strokes(num2 - 1) = Util.ConvertToSingle(xmlNode3("r:nominal-stroke-length").InnerText)
										num2 += 1
									End While
									pu.A = Util.ConvertToSingle(xmlNode8.SelectSingleNode("r:pu-apidimension-a", nsmgr).InnerText)
									pu.C = Util.ConvertToSingle(xmlNode8.SelectSingleNode("r:pu-apidimension-c", nsmgr).InnerText)
									pu.I = Util.ConvertToSingle(xmlNode8.SelectSingleNode("r:pu-apidimension-i", nsmgr).InnerText)
									pu.K = Util.ConvertToSingle(xmlNode8.SelectSingleNode("r:pu-apidimension-k", nsmgr).InnerText)
									pu.P = Util.ConvertToSingle(xmlNode8.SelectSingleNode("r:pu-apidimension-p", nsmgr).InnerText)
									If pu.UnitType <> 6S Then
										pu.CrankOffset = Util.ConvertToSingle(xmlNode8.SelectSingleNode("r:crank-offset-angle", nsmgr).InnerText)
									Else
										pu.M = Util.ConvertToSingle(xmlNode8.SelectSingleNode("r:pu-apidimension-m", nsmgr).InnerText)
										pu.S = Util.ConvertToSingle(xmlNode8.SelectSingleNode("r:pu-apidimension-s", nsmgr).InnerText)
										pu.V0 = Util.ConvertToSingle(xmlNode8.SelectSingleNode("r:pu-apidimension-v0", nsmgr).InnerText)
									End If
									pu.Unbalance = Util.ConvertToSingle(xmlNode8.SelectSingleNode("r:structural-unbalance", nsmgr).InnerText)
								End If
							End If
							xmlNode8 = Nothing
						Else
							RSWIN_DESC.rst.IDEntered = 0S
							RSWIN_DESC.rst.UnitID = ""
						End If
					End If
				Catch ex34 As Exception
				End Try
				Application.DoEvents()
				Application.DoEvents()
				If pu.UnitType = 8S Or RSWIN_DESC.bBeamBalanced Then
					Try
						RSWIN_DESC.rst.bUnknownUnbalance = MRodstarXML.CheckBoolean(xmlNode2.SelectSingleNode("r:beam-balanced", nsmgr).InnerText)
					Catch ex35 As Exception
						RSWIN_DESC.rst.bUnknownUnbalance = False
					End Try
				End If
				Try
					If pu.UnitType = 10S Then
						Try
							RSWIN_DESC.rst.AdjustedStrokeLength = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:adjusted-stroke-length", nsmgr).InnerText)
						Catch ex36 As Exception
							RSWIN_DESC.rst.AdjustedStrokeLength = pu.MaxStroke
						End Try
						Try
							RSWIN_DESC.rst.PercentDownstrokeSPM = 50F
						Catch ex37 As Exception
							RSWIN_DESC.rst.PercentDownstrokeSPM = 50F
						End Try
						Try
							RSWIN_DESC.rst.PercentUpstrokeSPM = 50F
							GoTo IL_2700
						Catch ex38 As Exception
							RSWIN_DESC.rst.PercentUpstrokeSPM = 50F
							GoTo IL_2700
						End Try
					End If
					If pu.UnitType = 11S Then
						Try
							RSWIN_DESC.rst.bUseCrankBalancedCalcs = MRodstarXML.CheckBoolean(xmlNode2.SelectSingleNode("r:use-crank-balanced-calcs", nsmgr).InnerText)
						Catch ex39 As Exception
							RSWIN_DESC.rst.bUseCrankBalancedCalcs = True
						End Try
					End If
				Catch ex40 As Exception
				End Try
				Try
					IL_2700:
					If Not bXROD Then
						Dim xmlNode9 As XmlNode = xmlNode2.SelectSingleNode("r:rod-string-design", nsmgr)
						Dim flag4 As Boolean = True
						Dim xmlElement As XmlElement
						If flag4 = xmlNode9.SelectNodes("r:rodstringdesign-steel", nsmgr).Count > 0 Then
							xmlElement = CType(xmlNode9.SelectSingleNode("r:rodstringdesign-steel", nsmgr), XmlElement)
							RSWIN_DESC.rst.RodStringType = 3S
							RSWIN_DESC.rst.giRodDesignStyle = 0S
						ElseIf flag4 = xmlNode9.SelectNodes("r:rodstringdesign-fiberglass", nsmgr).Count > 0 Then
							RSWIN_DESC.rst.giRodDesignStyle = 1S
							xmlElement = CType(xmlNode9.SelectSingleNode("r:rodstringdesign-fiberglass", nsmgr), XmlElement)
							Dim obj5 As Object = Conversions.ToInteger(MRodstarXML.DoLookup(MRodstarXML.new_mnLookupRodGrade, xmlElement.SelectSingleNode("r:rodtype-fiberglass", nsmgr).InnerText))
							If Operators.ConditionalCompareObjectEqual(obj5, 0, False) Then
								RSWIN_DESC.rst.RSFGGrade = CShort(Conversions.ToInteger(MRodstarXML.DoLookup(MRodstarXML.mnLookupRodGrade, xmlElement.SelectSingleNode("r:rodtype-fiberglass", nsmgr).InnerText)))
							Else
								RSWIN_DESC.rst.RSFGGrade = Conversions.ToShort(obj5)
							End If
							RSWIN_DESC.rst.RodStringType = 3S
							RSWIN_DESC.rst.giRodDesignStyle = 1S
						Else
							xmlElement = Nothing
							If Not RSWIN_DESC.rst.bDeviated Then
								RSWIN_DESC.rst.RodStringType = 2S
							Else
								RSWIN_DESC.rst.RodStringType = 4S
							End If
							RSWIN_DESC.rst.giRodDesignStyle = 0S
						End If
						If xmlElement IsNot Nothing Then
							Dim xmlElement2 As XmlElement = xmlElement
							If xmlElement2.SelectNodes("r:rodtype-steel", nsmgr).Count = 0 And xmlElement2.SelectNodes("r:rodtype-corod", nsmgr).Count = 0 And xmlElement2.SelectNodes("r:rodtype-prorod", nsmgr).Count = 0 Then
								RSWIN_DESC.rst.RSFGIncludeSteel = 0S
							Else
								RSWIN_DESC.rst.RSFGIncludeSteel = -1S
								Dim flag5 As Boolean = True
								If flag5 = (xmlElement2.SelectNodes("r:rodtype-steel", nsmgr).Count <> 0) Then
									Dim obj5 As Object = Conversions.ToInteger(MRodstarXML.DoLookup(MRodstarXML.new_mnLookupRodGrade, xmlElement2.SelectSingleNode("r:rodtype-steel", nsmgr).InnerText))
									If Operators.ConditionalCompareObjectEqual(obj5, 0, False) Then
										Try
											MRodstarXML.sRSGrade = xmlElement2.SelectSingleNode("r:rodtype-steel", nsmgr).InnerText
										Catch ex41 As Exception
											MRodstarXML.sRSGrade = ""
										End Try
										RSWIN_DESC.rst.RSGrade = CShort(Conversions.ToInteger(MRodstarXML.DoLookup(MRodstarXML.mnLookupRodGrade, xmlElement2.SelectSingleNode("r:rodtype-steel", nsmgr).InnerText)))
									Else
										RSWIN_DESC.rst.RSGrade = Conversions.ToShort(obj5)
									End If
									If RSWIN_DESC.rst.RSGrade = 0S Then
										MRodstarXML.sRSGrade = xmlElement2.SelectSingleNode("r:rodtype-steel", nsmgr).InnerText
										RSWIN_DESC.rst.RSGrade = CShort(MRodstarXML.DoCustomSteelRodGradeLookup(xmlElement2.SelectSingleNode("r:rodtype-steel", nsmgr).InnerText))
									End If
								ElseIf flag5 = (xmlElement2.SelectNodes("r:rodtype-corod", nsmgr).Count <> 0) Then
									Dim obj5 As Object = Conversions.ToInteger(MRodstarXML.DoLookup(MRodstarXML.new_mnLookupRodGrade, xmlElement2.SelectSingleNode("r:rodtype-corod", nsmgr).InnerText))
									If Operators.ConditionalCompareObjectEqual(obj5, 0, False) Then
										RSWIN_DESC.rst.RSGrade = CShort(Conversions.ToInteger(MRodstarXML.DoLookup(MRodstarXML.mnLookupRodGrade, xmlElement2.SelectSingleNode("r:rodtype-corod", nsmgr).InnerText)))
									Else
										RSWIN_DESC.rst.RSGrade = Conversions.ToShort(obj5)
									End If
								ElseIf flag5 = (xmlElement2.SelectNodes("r:rodtype-prorod", nsmgr).Count <> 0) Then
									Dim obj5 As Object = Conversions.ToInteger(MRodstarXML.DoLookup(MRodstarXML.new_mnLookupRodGrade, xmlElement2.SelectSingleNode("r:rodtype-prorod", nsmgr).InnerText))
									If Operators.ConditionalCompareObjectEqual(obj5, 0, False) Then
										RSWIN_DESC.rst.RSGrade = CShort(Conversions.ToInteger(MRodstarXML.DoLookup(MRodstarXML.mnLookupRodGrade, xmlElement2.SelectSingleNode("r:rodtype-prorod", nsmgr).InnerText)))
									Else
										RSWIN_DESC.rst.RSGrade = Conversions.ToShort(obj5)
									End If
								Else
									RSWIN_DESC.rst.RSFGIncludeSteel = 0S
								End If
								If RSWIN_DESC.rst.RSFGIncludeSteel <> 0S Then
									RSWIN_DESC.rst.RSMaxSize = Util.ConvertToSingle(xmlElement2.SelectSingleNode("r:steel-size-max", nsmgr).InnerText)
									If RSWIN_DESC.bRodStarD Then
										Try
											RSWIN_DESC.rst.RSSRSize = Util.ConvertToSingle(xmlElement2.SelectSingleNode("r:sucker-rod-size", nsmgr).InnerText)
										Catch ex42 As Exception
											RSWIN_DESC.rst.RSSRSize = RSWIN_DESC.rst.RSMaxSize
										End Try
									End If
									RSWIN_DESC.rst.RSMinSize = Util.ConvertToSingle(xmlElement2.SelectSingleNode("r:steel-size-min", nsmgr).InnerText)
									Try
										RSWIN_DESC.rst.RSFricCoef = Util.ConvertToSingle(xmlElement2.SelectSingleNode("r:steel-fric-coef", nsmgr).InnerText)
									Catch ex43 As Exception
										RSWIN_DESC.rst.RSFricCoef = 0.2F
									End Try
									Try
										RSWIN_DESC.rst.RSRodGuide = CInt(Math.Round(CDbl(Util.ConvertToSingle(xmlElement2.SelectSingleNode("r:steel-guide", nsmgr).InnerText))))
									Catch ex44 As Exception
										RSWIN_DESC.rst.RSRodGuide = RSWIN_DESC.SETUP_GuideToUse
									End Try
								End If
							End If
							If xmlElement2.SelectNodes("r:sinker-bar", nsmgr).Count = 0 Then
								RSWIN_DESC.rst.RSIncludeSB = 0S
							Else
								RSWIN_DESC.rst.RSIncludeSB = -1S
								Try
									Dim xmlNode10 As XmlNode = xmlElement2.SelectSingleNode("r:sinker-bar", nsmgr)
									Dim flag6 As Boolean = True
									Dim sinkerBar As RSWIN_DESC.RodSection
									If flag6 = (xmlNode10.SelectNodes("r:rodtype-steel", nsmgr).Count <> 0) Then
										Dim obj5 As Object = Conversions.ToInteger(MRodstarXML.DoLookup(MRodstarXML.new_mnLookupRodGrade, xmlNode10.SelectSingleNode("r:rodtype-steel", nsmgr).InnerText))
										If Operators.ConditionalCompareObjectEqual(obj5, 0, False) Then
											Try
												MRodstarXML.sRSSBGrade = xmlNode10.SelectSingleNode("r:rodtype-steel", nsmgr).InnerText
											Catch ex45 As Exception
												MRodstarXML.sRSSBGrade = ""
											End Try
											sinkerBar.Grade = CShort(Conversions.ToInteger(MRodstarXML.DoLookup(MRodstarXML.mnLookupRodGrade, xmlNode10.SelectSingleNode("r:rodtype-steel", nsmgr).InnerText)))
										Else
											sinkerBar.Grade = Conversions.ToShort(obj5)
										End If
										Try
											If sinkerBar.Grade = 0S Then
												MRodstarXML.sRSSBGrade = xmlNode10.SelectSingleNode("r:rodtype-steel", nsmgr).InnerText
												sinkerBar.Grade = CShort(MRodstarXML.DoCustomSteelRodGradeLookup(xmlNode10.SelectSingleNode("r:rodtype-steel", nsmgr).InnerText))
											End If
											GoTo IL_2FEE
										Catch ex46 As Exception
											GoTo IL_2FEE
										End Try
									End If
									If flag6 = (xmlNode10.SelectNodes("r:rodtype-corod", nsmgr).Count <> 0) Then
										Dim obj5 As Object = Conversions.ToInteger(MRodstarXML.DoLookup(MRodstarXML.new_mnLookupRodGrade, xmlNode10.SelectSingleNode("r:rodtype-corod", nsmgr).InnerText))
										If Operators.ConditionalCompareObjectEqual(obj5, 0, False) Then
											sinkerBar.Grade = CShort(Conversions.ToInteger(MRodstarXML.DoLookup(MRodstarXML.mnLookupRodGrade, xmlNode10.SelectSingleNode("r:rodtype-corod", nsmgr).InnerText)))
										Else
											sinkerBar.Grade = Conversions.ToShort(obj5)
										End If
									ElseIf flag6 = (xmlNode10.SelectNodes("r:rodtype-prorod", nsmgr).Count <> 0) Then
										sinkerBar.Grade = CShort(Conversions.ToInteger(MRodstarXML.DoLookup(MRodstarXML.mnLookupRodGrade, xmlNode10.SelectSingleNode("r:rodtype-prorod", nsmgr).InnerText)))
										Dim obj5 As Object = Conversions.ToInteger(MRodstarXML.DoLookup(MRodstarXML.new_mnLookupRodGrade, xmlNode10.SelectSingleNode("r:rodtype-prorod", nsmgr).InnerText))
										If Operators.ConditionalCompareObjectEqual(obj5, 0, False) Then
											sinkerBar.Grade = CShort(Conversions.ToInteger(MRodstarXML.DoLookup(MRodstarXML.mnLookupRodGrade, xmlNode10.SelectSingleNode("r:rodtype-prorod", nsmgr).InnerText)))
										Else
											sinkerBar.Grade = Conversions.ToShort(obj5)
										End If
									ElseIf flag6 = (xmlNode10.SelectNodes("r:rodtype-sinkerbar", nsmgr).Count <> 0) Then
										Dim obj5 As Object = Conversions.ToInteger(MRodstarXML.DoLookup(MRodstarXML.new_mnLookupRodGrade, xmlNode10.SelectSingleNode("r:rodtype-sinkerbar", nsmgr).InnerText))
										If Operators.ConditionalCompareObjectEqual(obj5, 0, False) Then
											sinkerBar.Grade = CShort(Conversions.ToInteger(MRodstarXML.DoLookup(MRodstarXML.mnLookupRodGrade, xmlNode10.SelectSingleNode("r:rodtype-sinkerbar", nsmgr).InnerText)))
										Else
											sinkerBar.Grade = Conversions.ToShort(obj5)
										End If
										If sinkerBar.Grade = 0S Then
											sinkerBar.Grade = CShort(MRodstarXML.DoCustomSinkerBarRodGradeLookup(xmlNode10.SelectSingleNode("r:rodtype-sinkerbar", nsmgr).InnerText))
										End If
									Else
										RSWIN_DESC.rst.RSIncludeSB = 0S
									End If
									IL_2FEE:
									If RSWIN_DESC.rst.RSIncludeSB <> 0S Then
										sinkerBar.Diameter = Util.ConvertToSingle(xmlNode10.SelectSingleNode("r:taper-size", nsmgr).InnerText)
										sinkerBar.length = Util.ConvertToSingle(xmlNode10.SelectSingleNode("r:taper-length", nsmgr).InnerText)
										Try
											sinkerBar.TensileStrength = Util.ConvertToSingle(xmlNode10.SelectSingleNode("r:taper-tensile-strength", nsmgr).InnerText)
										Catch ex47 As Exception
										End Try
										Try
											sinkerBar.StressMethod = Conversions.ToShort(xmlNode10.SelectSingleNode("r:taper-stress-method", nsmgr).InnerText)
										Catch ex48 As Exception
										End Try
										RSWIN_DESC.rst.SinkerBar = sinkerBar
									End If
									xmlNode10 = Nothing
								Catch ex49 As Exception
								End Try
							End If
							xmlElement2 = Nothing
						End If
					End If
				Catch ex50 As Exception
					If Not RSWIN_DESC.rst.bDeviated Then
						RSWIN_DESC.rst.RodStringType = 2S
					Else
						RSWIN_DESC.rst.RodStringType = 4S
					End If
				End Try
				If Not bXROD Then
					Dim xmlNodeList2 As XmlNodeList = xmlNode2.SelectNodes("r:rod-tapers/r:rod-taper", nsmgr)
					Dim xmlNodeList7 As XmlNodeList = xmlNodeList2
					RSWIN_DESC.rst.NumRods = CShort(xmlNodeList7.Count)
					Dim num2 As Integer = 1
					Dim enumerator As IEnumerator = xmlNodeList7.GetEnumerator()
					While enumerator.MoveNext()
						Dim rodSection As RSWIN_DESC.RodSection = Nothing
						rodSection.Initialize()
						xmlNode3 = CType(enumerator.Current, XmlNode)
						Dim text6 As String
						Try
							text6 = xmlNode3("r:rodtype-corod").InnerText
						Catch ex51 As Exception
							text6 = ""
						End Try
						Dim text7 As String
						Try
							text7 = xmlNode3("r:rodtype-prorod").InnerText
						Catch ex52 As Exception
							text7 = ""
						End Try
						Dim text8 As String
						Try
							text8 = xmlNode3("r:rodtype-fiberglass").InnerText
						Catch ex53 As Exception
							text8 = ""
						End Try
						Dim text9 As String
						Try
							text9 = xmlNode3("r:rodtype-ribbonrod").InnerText
						Catch ex54 As Exception
							text9 = ""
						End Try
						Dim text10 As String
						Try
							text10 = xmlNode3("r:rodtype-sinkerbar").InnerText
						Catch ex55 As Exception
							text10 = ""
						End Try
						Dim text11 As String
						Try
							text11 = xmlNode3("r:rodtype-steel").InnerText
						Catch ex56 As Exception
							text11 = ""
						End Try
						Dim flag7 As Boolean = True
						If flag7 = (text6.Length <> 0) Then
							Dim obj5 As Object = Conversions.ToInteger(MRodstarXML.DoLookup(MRodstarXML.new_mnLookupRodGrade, xmlNode3("r:rodtype-corod").InnerText))
							If Operators.ConditionalCompareObjectEqual(obj5, 0, False) Then
								rodSection.Grade = CShort(Conversions.ToInteger(MRodstarXML.DoLookup(MRodstarXML.mnLookupRodGrade, xmlNode3("r:rodtype-corod").InnerText)))
							Else
								rodSection.Grade = Conversions.ToShort(obj5)
							End If
							Try
								Dim grade As Short = rodSection.Grade
								Dim flag8 As Boolean = RODUTIL.ConvertRodGrade(rodSection) <> 0
								GoTo IL_36B1
							Catch ex57 As Exception
								Dim grade As Short
								rodSection.Grade = grade
								GoTo IL_36B1
							End Try
							GoTo IL_330C
						End If
						GoTo IL_330C
						IL_36B1:
						rodSection.Diameter = Util.ConvertToSingle(xmlNode3("r:taper-size").InnerText)
						rodSection.length = Util.ConvertToSingle(xmlNode3("r:taper-length").InnerText)
						rodSection.Guide = Conversions.ToShort(Util.ConvertToInt16(xmlNode3("r:taper-guide").InnerText))
						Try
							rodSection.TensileStrength = Util.ConvertToSingle(xmlNode3("r:taper-tensile-strength").InnerText)
						Catch ex58 As Exception
							If rodSection.Grade <> 0S Then
								RODUTIL.LookupTensileStrength(rodSection)
							Else
								rodSection.TensileStrength = 0F
							End If
						End Try
						Try
							rodSection.StressMethod = Conversions.ToShort(Util.ConvertToInt16(xmlNode3("r:taper-stress-method").InnerText))
						Catch ex59 As Exception
							If rodSection.Grade <> 0S Then
								RODUTIL.LookupStressMethod(rodSection)
							Else
								rodSection.StressMethod = 0S
							End If
						End Try
						Try
							If RSWIN_DESC.SETUP_ALLOWSLIDEFRIC <> 0S Then
								rodSection.friction_coef = Util.ConvertToSingle(xmlNode3("r:taper-friction-coef").InnerText)
							Else
								rodSection.friction_coef = RSWIN_DESC.rst.SlideFricCoeff
							End If
						Catch ex60 As Exception
							rodSection.friction_coef = 0.2F
						End Try
						If RSWIN_DESC.bRodStarD Then
							Try
								rodSection.NumGuides = Convert.ToInt16(xmlNode3("r:taper-num-guides").InnerText)
							Catch ex61 As Exception
								rodSection.NumGuides = 0S
							End Try
						End If
						RSWIN_DESC.rst.Sections(num2) = rodSection
						num2 += 1
						Continue While
						IL_330C:
						If flag7 = (text7.Length <> 0) Then
							Dim obj5 As Object = Conversions.ToInteger(MRodstarXML.DoLookup(MRodstarXML.new_mnLookupRodGrade, xmlNode3("r:rodtype-prorod").InnerText))
							If Operators.ConditionalCompareObjectEqual(obj5, 0, False) Then
								rodSection.Grade = CShort(Conversions.ToInteger(MRodstarXML.DoLookup(MRodstarXML.mnLookupRodGrade, xmlNode3("r:rodtype-prorod").InnerText)))
								GoTo IL_36B1
							End If
							rodSection.Grade = Conversions.ToShort(obj5)
							GoTo IL_36B1
						ElseIf flag7 = (text8.Length <> 0) Then
							Dim obj5 As Object = Conversions.ToInteger(MRodstarXML.DoLookup(MRodstarXML.new_mnLookupRodGrade, xmlNode3("r:rodtype-fiberglass").InnerText))
							If Operators.ConditionalCompareObjectEqual(obj5, 0, False) Then
								rodSection.Grade = CShort(Conversions.ToInteger(MRodstarXML.DoLookup(MRodstarXML.mnLookupRodGrade, xmlNode3("r:rodtype-fiberglass").InnerText)))
							Else
								rodSection.Grade = Conversions.ToShort(obj5)
							End If
							If rodSection.Grade = 0S Then
								rodSection.Grade = Conversions.ToShort(MRodstarXML.DoCustomFGRodGradeLookup(Conversions.ToInteger(xmlNode3("r:rodtype-fiberglass").InnerText)))
								GoTo IL_36B1
							End If
							GoTo IL_36B1
						ElseIf flag7 = (text9.Length <> 0) Then
							rodSection.Grade = CShort(Conversions.ToInteger(MRodstarXML.DoLookup(MRodstarXML.mnLookupRodGrade, xmlNode3("r:rodtype-ribbonrod").InnerText)))
							Dim obj5 As Object = Conversions.ToInteger(MRodstarXML.DoLookup(MRodstarXML.new_mnLookupRodGrade, xmlNode3("r:rodtype-ribbonrod").InnerText))
							If Operators.ConditionalCompareObjectEqual(obj5, 0, False) Then
								rodSection.Grade = CShort(Conversions.ToInteger(MRodstarXML.DoLookup(MRodstarXML.mnLookupRodGrade, xmlNode3("r:rodtype-ribbonrod").InnerText)))
								GoTo IL_36B1
							End If
							rodSection.Grade = Conversions.ToShort(obj5)
							GoTo IL_36B1
						ElseIf flag7 = (text10.Length <> 0) Then
							rodSection.Grade = CShort(Conversions.ToInteger(MRodstarXML.DoLookup(MRodstarXML.mnLookupRodGrade, xmlNode3("r:rodtype-sinkerbar").InnerText)))
							Dim obj5 As Object = Conversions.ToInteger(MRodstarXML.DoLookup(MRodstarXML.new_mnLookupRodGrade, xmlNode3("r:rodtype-sinkerbar").InnerText))
							If Operators.ConditionalCompareObjectEqual(obj5, 0, False) Then
								rodSection.Grade = CShort(Conversions.ToInteger(MRodstarXML.DoLookup(MRodstarXML.mnLookupRodGrade, xmlNode3("r:rodtype-sinkerbar").InnerText)))
							Else
								rodSection.Grade = Conversions.ToShort(obj5)
							End If
							If rodSection.Grade = 0S Then
								rodSection.Grade = CShort(MRodstarXML.DoCustomSinkerBarRodGradeLookup(xmlNode3("r:rodtype-sinkerbar").InnerText))
								GoTo IL_36B1
							End If
							GoTo IL_36B1
						Else
							If flag7 <> (text11.Length <> 0) Then
								GoTo IL_36B1
							End If
							Dim obj5 As Object = Conversions.ToInteger(MRodstarXML.DoLookup(MRodstarXML.new_mnLookupRodGrade, xmlNode3("r:rodtype-steel").InnerText))
							If Operators.ConditionalCompareObjectEqual(obj5, 0, False) Then
								rodSection.Grade = CShort(Conversions.ToInteger(MRodstarXML.DoLookup(MRodstarXML.mnLookupRodGrade, xmlNode3("r:rodtype-steel").InnerText)))
							Else
								rodSection.Grade = Conversions.ToShort(obj5)
							End If
							If rodSection.Grade <> 0S Then
								GoTo IL_36B1
							End If
							rodSection.Grade = CShort(MRodstarXML.DoCustomSteelRodGradeLookup(xmlNode3("r:rodtype-steel").InnerText))
							If rodSection.Grade = 0S And text11.Trim().Length <> 0 Then
								rodSection.RodType = text11
								GoTo IL_36B1
							End If
							GoTo IL_36B1
						End If
					End While
					RSWIN_DESC.rst.PU = pu
				End If
				If bXROD AndAlso (RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru) Then
					Dim xmlNode11 As XmlNode = xmlNode2.SelectSingleNode("r:ai-preferences", nsmgr)
					If xmlNode11 IsNot Nothing Then
						Dim xmlNode12 As XmlNode = xmlNode11
						Try
							RSWIN_DESC.AIFilePreferences.Initialize()
						Catch ex62 As Exception
						End Try
						Try
							RSWIN_DESC.AIFilePreferences.FGGradeRod = Conversions.ToShort(Util.ConvertToInt16(xmlNode12.SelectSingleNode("r:fg-rod-grade", nsmgr).InnerText))
							If RSWIN_DESC.AIFilePreferences.FGGradeRod > 0S Then
								RSWIN_DESC.AIFilePreferences.FGRodType = RODUTIL.RodGrade(RSWIN_DESC.AIFilePreferences.FGGradeRod)
							End If
						Catch ex63 As Exception
						End Try
						Try
							RSWIN_DESC.AIFilePreferences.HSGradeRod = Conversions.ToShort(Util.ConvertToInt16(xmlNode12.SelectSingleNode("r:hs-rod-grade", nsmgr).InnerText))
							If RSWIN_DESC.AIFilePreferences.HSGradeRod > 0S Then
								RSWIN_DESC.AIFilePreferences.HSRodType = RODUTIL.RodGrade(RSWIN_DESC.AIFilePreferences.HSGradeRod)
							End If
						Catch ex64 As Exception
						End Try
						Try
							RSWIN_DESC.AIFilePreferences.SBGradeRod = Conversions.ToShort(Util.ConvertToInt16(xmlNode12.SelectSingleNode("r:sb-rod-grade", nsmgr).InnerText))
							If RSWIN_DESC.AIFilePreferences.SBGradeRod > 0S Then
								RSWIN_DESC.AIFilePreferences.SBRodType = RODUTIL.RodGrade(RSWIN_DESC.AIFilePreferences.SBGradeRod)
							End If
						Catch ex65 As Exception
						End Try
						Try
							RSWIN_DESC.AIFilePreferences.bXRODUseCustomizedLists = MRodstarXML.CheckBoolean(xmlNode12.SelectSingleNode("r:use-customized-lists", nsmgr).InnerText)
						Catch ex66 As Exception
							RSWIN_DESC.AIFilePreferences.bXRODUseCustomizedLists = False
						End Try
						Try
							RSWIN_DESC.AIFilePreferences.bXRODUseGeneralList = MRodstarXML.CheckBoolean(xmlNode12.SelectSingleNode("r:use-general-list", nsmgr).InnerText)
						Catch ex67 As Exception
							RSWIN_DESC.AIFilePreferences.bXRODUseGeneralList = False
						End Try
						Try
							RSWIN_DESC.AIFilePreferences.bXRODUseClosestUnit = MRodstarXML.CheckBoolean(xmlNode12.SelectSingleNode("r:use-closest-unit", nsmgr).InnerText)
						Catch ex68 As Exception
							RSWIN_DESC.AIFilePreferences.bXRODUseClosestUnit = False
						End Try
						Try
							If MRodstarXML.CheckBoolean(xmlNode12.SelectSingleNode("r:use-238-tubing-only", nsmgr).InnerText) Then
								RSWIN_DESC.rst.TubingOD = 2.375F
								RSWIN_DESC.rst.TubingID = 1.995F
								RSWIN_DESC.AIFilePreferences.bUseXRODVTubingSizes = False
							End If
						Catch ex69 As Exception
							RSWIN_DESC.AIFilePreferences.bUseXRODVTubingSizes = True
						End Try
						Try
							If MRodstarXML.CheckBoolean(xmlNode12.SelectSingleNode("r:use-278-tubing-only", nsmgr).InnerText) Then
								RSWIN_DESC.rst.TubingOD = 2.875F
								RSWIN_DESC.rst.TubingID = 2.441F
								RSWIN_DESC.AIFilePreferences.bUseXRODVTubingSizes = False
							End If
						Catch ex70 As Exception
							RSWIN_DESC.AIFilePreferences.bUseXRODVTubingSizes = True
						End Try
						Try
							RSWIN_DESC.AIFilePreferences.bUseXRODVTubingSizes = MRodstarXML.CheckBoolean(xmlNode12.SelectSingleNode("r:use-xrodv-tubing-sizes", nsmgr).InnerText)
						Catch ex71 As Exception
							RSWIN_DESC.AIFilePreferences.bUseXRODVTubingSizes = True
						End Try
						Try
							RSWIN_DESC.AIFilePreferences.fTubingSizeOD = Util.ConvertToSingle(xmlNode12.SelectSingleNode("r:tubing-od-size", nsmgr).InnerText)
						Catch ex72 As Exception
							RSWIN_DESC.AIFilePreferences.fTubingSizeOD = 2.875F
						End Try
						Try
							RSWIN_DESC.AIFilePreferences.fCasingSize = Util.ConvertToSingle(xmlNode12.SelectSingleNode("r:casing-size", nsmgr).InnerText)
						Catch ex73 As Exception
							RSWIN_DESC.AIFilePreferences.fCasingSize = 5.5F
						End Try
						Try
							RSWIN_DESC.AIFilePreferences.bFixTubingSize = MRodstarXML.CheckBoolean(xmlNode12.SelectSingleNode("r:fix-tubing-size", nsmgr).InnerText)
						Catch ex74 As Exception
							RSWIN_DESC.AIFilePreferences.bFixTubingSize = False
						End Try
						Try
							RSWIN_DESC.AIFilePreferences.bUseSteelRodsOnly = MRodstarXML.CheckBoolean(xmlNode12.SelectSingleNode("r:use-steel-rods-only", nsmgr).InnerText)
						Catch ex75 As Exception
						End Try
						Try
							RSWIN_DESC.AIFilePreferences.bUseFGlassWithSteelOnBottom = MRodstarXML.CheckBoolean(xmlNode12.SelectSingleNode("r:use-fglass-with-steel-on-bottom", nsmgr).InnerText)
						Catch ex76 As Exception
						End Try
						Try
							RSWIN_DESC.AIFilePreferences.bUseAvgRodTBGFricCoeff = MRodstarXML.CheckBoolean(xmlNode12.SelectSingleNode("r:use-avg-rod-tbg-fric-coeff", nsmgr).InnerText)
						Catch ex77 As Exception
						End Try
						Try
							RSWIN_DESC.AIFilePreferences.TimesAvgRodTBGFricCoeff = Util.ConvertToSingle(xmlNode12.SelectSingleNode("r:times-avg-rod-tbg-fric-coeff", nsmgr).InnerText)
						Catch ex78 As Exception
						End Try
						Try
							RSWIN_DESC.AIFilePreferences.ServiceFactorPreference = Util.ConvertToSingle(xmlNode12.SelectSingleNode("r:service-factor-pref", nsmgr).InnerText)
						Catch ex79 As Exception
						End Try
						Try
							RSWIN_DESC.AIFilePreferences.ElectricityCostPreference = Util.ConvertToSingle(xmlNode12.SelectSingleNode("r:electricity-cost-pref", nsmgr).InnerText)
						Catch ex80 As Exception
							Dim num10 As Single = Conversions.ToSingle(ini.GetDataValue("ElectricityCost", 4, True, 0.06))
							RSWIN_DESC.AIFilePreferences.ElectricityCostPreference = Conversions.ToSingle(ini.GetPreferenceDataValue("ElectricityCostPreference", 4, num10))
						End Try
						Try
							RSWIN_DESC.AIFilePreferences.PowerMeterType = Conversions.ToShort(Util.ConvertToInt16(xmlNode12.SelectSingleNode("r:power-meter-type-pref", nsmgr).InnerText))
						Catch ex81 As Exception
						End Try
						Try
							RSWIN_DESC.AIFilePreferences.IncludeMotorSPV = MRodstarXML.CheckBoolean(xmlNode12.SelectSingleNode("r:include-motor-spv-pref", nsmgr).InnerText)
						Catch ex82 As Exception
						End Try
						Dim num2 As Integer = 1
						Do
							Try
								RSWIN_DESC.AIFilePreferences.bUsePUManuf(num2) = MRodstarXML.CheckBoolean(xmlNode12.SelectSingleNode("r:use-pumanuf-preference-" + num2.ToString().Trim(), nsmgr).InnerText)
							Catch ex83 As Exception
							End Try
							Try
								RSWIN_DESC.AIFilePreferences.PUManuf(num2) = Convert.ToString(xmlNode12.SelectSingleNode("r:pumanuf-preference-" + num2.ToString().Trim(), nsmgr).InnerText)
								If RSWIN_DESC.AIFilePreferences.PUManuf(num2) IsNot Nothing AndAlso (Strings.InStr(RSWIN_DESC.AIFilePreferences.PUManuf(num2), "American Conv. (100", CompareMethod.Binary) > 0 Or Strings.InStr(RSWIN_DESC.AIFilePreferences.PUManuf(num2), "American Conv. (less than 100", CompareMethod.Binary) > 0 Or Strings.InStr(RSWIN_DESC.AIFilePreferences.PUManuf(num2), "American (100", CompareMethod.Binary) > 0 Or Strings.InStr(RSWIN_DESC.AIFilePreferences.PUManuf(num2), "American (less than 100", CompareMethod.Binary) > 0) Then
									RSWIN_DESC.AIFilePreferences.PUManuf(num2) = "American Conventional                   "
								End If
							Catch ex84 As Exception
							End Try
							num2 += 1
						Loop While num2 <= 8
						xmlNode12 = Nothing
						If Not MRodstarXML.CompareAIPreferences() Then
							Dim dlgAIPreference As dlgAIPreference = New dlgAIPreference()
							Dim dlgAIPreference2 As dlgAIPreference = dlgAIPreference
							If dlgAIPreference2.Height > RSWIN_DESC.frmMain.Height Then
								dlgAIPreference2.Height = RSWIN_DESC.frmMain.Height
								dlgAIPreference2.Top = RSWIN_DESC.frmMain.Top
							End If
							dlgAIPreference2.ShowDialog()
							If dlgAIPreference2.bUseSetup Then
								MRodstarXML.SetAIFilePreferencesFromSetup(True)
							ElseIf dlgAIPreference2.bUseFile Then
								MRodstarXML.UseAIFilePreferencesFromFile()
								If dlgAIPreference2.bOverwriteSetup Then
									MRodstarXML.SetAIFilePreferencesFromFile()
								End If
							End If
						End If
					Else
						MRodstarXML.SetAIFilePreferencesFromSetup(True)
					End If
				End If
				xmlNode2 = Nothing
				If RSWIN_DESC.rst.gbUseIPR AndAlso RSWIN_DESC.rst.gnTestPoints > 0S Then
					Dim flag9 As Boolean = MRodstarXML.CheckIPR()
				End If
				result = True
				Application.DoEvents()
				Application.DoEvents()
				If RSWIN_DESC.rst.PU.UnitType = 9S Then
					RSWIN_DESC.rst.Unbalance = 0F
				End If
			Catch ex85 As Exception
			End Try
			Return result
		End Function

		Public Function CheckIPR() As Boolean
			Dim result As Boolean
			Try
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				Dim flag As Boolean
				If Not rst.gbUseIPR Then
					flag = False
				Else
					flag = (rst.MidPerfDepth >= 0F)
					flag = flag And (rst.StaticBHPressure > 0F)
					flag = flag And (rst.gbProducingBelowBPP Or rst.BubblePoint > 0F)
					flag = flag And (rst.gnTestPoints >= 1S)
					Dim num As Short = 1S
					Dim gnTestPoints As Short = rst.gnTestPoints
					For num2 As Short = num To gnTestPoints
						flag = flag And (rst.TestPoints(CInt(num2)).Pintake >= 0F Or rst.TestPoints(CInt(num2)).Pwf >= 0F)
						flag = flag And (rst.TestPoints(CInt(num2)).Production > 0F)
					Next
					If flag Then
						Dim num3 As Short = 1S
						Dim gnTestPoints2 As Short = rst.gnTestPoints
						For num2 As Short = num3 To gnTestPoints2
							If RSWIN_DESC.rst.TestPoints(CInt(num2)).bPIEntered <> 0S Then
								RSWIN_DESC.rst.TestPoints(CInt(num2)).Pwf = IPR.iprPwfFromPip(RSWIN_DESC.rst.TestPoints(CInt(num2)).Pintake)
							Else
								RSWIN_DESC.rst.TestPoints(CInt(num2)).Pintake = IPR.iprPipFromPwf(RSWIN_DESC.rst.TestPoints(CInt(num2)).Pwf)
							End If
							If RSWIN_DESC.rst.TestPoints(CInt(num2)).Pwf >= rst.StaticBHPressure Then
								flag = False
							ElseIf CDbl(RSWIN_DESC.rst.TestPoints(CInt(num2)).Pintake) < CDbl(rst.CasingPressure) + 14.7 Then
								flag = False
							End If
						Next
					End If
					If flag Then
						Dim num4 As Short = 1S
						Dim num5 As Short = rst.gnTestPoints - 1S
						For num2 As Short = num4 To num5
							' The following expression was wrapped in a checked-expression
							Dim num6 As Single = rst.TestPoints(CInt(num2)).Pwf - rst.TestPoints(CInt((num2 + 1S))).Pwf
							If num6 < 0F Then
								If rst.TestPoints(CInt(num2)).Production <= rst.TestPoints(CInt((num2 + 1S))).Production Then
									flag = False
								End If
							ElseIf num6 > 0F Then
								If rst.TestPoints(CInt(num2)).Production >= rst.TestPoints(CInt((num2 + 1S))).Production Then
									flag = False
								End If
							Else
								flag = False
								If rst.TestPoints(CInt(num2)).Production = rst.TestPoints(CInt((num2 + 1S))).Production Then
								End If
							End If
							If Not flag Then
								Exit For
							End If
						Next
					End If
				End If
				result = flag
			Catch ex As Exception
				result = False
			End Try
			Return result
		End Function

		Private Function LoadInputXML_DeviationOnly(ByRef xmlDoc As XmlDocument, ByRef nsmgr As XmlNamespaceManager, ByRef iCount As Integer) As Boolean
			Dim num As Single = -1F
			Dim result As Boolean
			Try
				Dim xmlNode As XmlNode = xmlDoc.SelectSingleNode("//r:input", nsmgr)
				Dim xmlNode2 As XmlNode = xmlNode
				RSWIN_DESC.mdsDeviationProfile = Nothing
				MImpred.InitSurveyDataset(RSWIN_DESC.mdsDeviationProfile, Nothing)
				Dim xmlNodeList As XmlNodeList = xmlNode2.SelectNodes("r:deviation-survey", nsmgr)
				iCount = 0
				If xmlNodeList.Count > 0 Then
					Dim xmlNodeList2 As XmlNodeList = xmlNode2.SelectNodes("r:deviation-survey/r:survey-point", nsmgr)
					Dim xmlNodeList3 As XmlNodeList = xmlNodeList2
					Dim count As Integer = xmlNodeList3.Count
					iCount = count
					Dim enumerator As IEnumerator = xmlNodeList3.GetEnumerator()
					Dim num2 As Integer = 0
					If xmlNodeList3.Count > 0 Then
					End If
					While enumerator.MoveNext()
						Dim obj As Object = enumerator.Current
						Dim xmlNode3 As XmlNode = CType(obj, XmlNode)
						Console.WriteLine(xmlNode3.InnerText)
						Dim dataRow As DataRow = RSWIN_DESC.mdsDeviationProfile.Tables(0).NewRow()
						dataRow("EntryNumber") = num2 + 1
						dataRow("Depth") = Util.ConvertToSingle(xmlNode3("r:measured-depth").InnerText)
						dataRow("Inclination") = Util.CheckDec(xmlNode3("r:inclination").InnerText)
						dataRow("Azimuth") = Util.CheckDec(xmlNode3("r:azimuth").InnerText)
						dataRow("Dogleg") = DBNull.Value
						dataRow("TVDepth") = DBNull.Value
						dataRow("NorthSouth") = DBNull.Value
						dataRow("EastWest") = DBNull.Value
						If Conversions.ToBoolean(Operators.AndObject(num2 + 1 = 1, Operators.NotObject(Operators.CompareObjectEqual(dataRow("Depth"), 0, False)))) Then
							Dim num3 As Single = Conversions.ToSingle(dataRow("Depth"))
							Dim value As String = Conversions.ToString(dataRow("Inclination"))
							Dim value2 As String = Conversions.ToString(dataRow("Azimuth"))
							dataRow("Depth") = 0
							dataRow("Inclination") = "0"
							dataRow("Azimuth") = "0"
							RSWIN_DESC.mdsDeviationProfile.Tables(0).Rows.Add(dataRow)
							num = 0F
							num2 += 1
							dataRow = RSWIN_DESC.mdsDeviationProfile.Tables(0).NewRow()
							dataRow("EntryNumber") = num2 + 1
							dataRow("Depth") = num3
							dataRow("Inclination") = value
							dataRow("Azimuth") = value2
							dataRow("Dogleg") = DBNull.Value
							dataRow("TVDepth") = DBNull.Value
							dataRow("NorthSouth") = DBNull.Value
							dataRow("EastWest") = DBNull.Value
						End If
						If Operators.ConditionalCompareObjectEqual(num, dataRow("Depth"), False) Then
							num2 -= 1
							Debug.WriteLine(Operators.ConcatenateObject("no add: previous depth=" + Conversions.ToString(num) + " , current depth=", dataRow("Depth")))
						Else
							RSWIN_DESC.mdsDeviationProfile.Tables(0).Rows.Add(dataRow)
							num = Conversions.ToSingle(dataRow("Depth"))
						End If
						num2 += 1
					End While
				End If
				result = True
			Catch ex As Exception
			End Try
			Return result
		End Function

		Private Function CheckBoolean(sVal As String) As Boolean
			Return Operators.CompareString(sVal, "-1", False) = 0 Or Operators.CompareString(sVal, "-2", False) = 0 Or Operators.CompareString(sVal, "True", False) = 0
		End Function

		Private Sub SetupLookups()
			' The following expression was wrapped in a checked-statement
			Try
				If MRodstarXML.mnLookupCrankRotation Is Nothing Then
					MRodstarXML.mnLookupCrankRotation = New Collection()
					Dim collection As Collection = MRodstarXML.mnLookupCrankRotation
					Dim obj As Object = New Object() { 1, "clockwise", -1, "counterclockwise" }
					Dim num As Integer = 0
					Dim num2 As Integer = Information.UBound(CType(obj, Array), 1)
					For i As Integer = num To num2 Step 2
						collection.Add(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(obj, New Object() { i }, Nothing)), Conversions.ToString(NewLateBinding.LateIndexGet(obj, New Object() { i + 1 }, Nothing)), Nothing, Nothing)
						collection.Add(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(obj, New Object() { i + 1 }, Nothing)), Conversions.ToString(Operators.ConcatenateObject("#", NewLateBinding.LateIndexGet(obj, New Object() { i }, Nothing))), Nothing, Nothing)
					Next
					MRodstarXML.mnLookupIPRCorrelation = New Collection()
					Dim collection2 As Collection = MRodstarXML.mnLookupIPRCorrelation
					obj = New Object() { 0, "fetkovich", 1, "vogel" }
					Dim num3 As Integer = 0
					Dim num4 As Integer = Information.UBound(CType(obj, Array), 1)
					For i As Integer = num3 To num4 Step 2
						collection2.Add(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(obj, New Object() { i }, Nothing)), Conversions.ToString(NewLateBinding.LateIndexGet(obj, New Object() { i + 1 }, Nothing)), Nothing, Nothing)
						collection2.Add(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(obj, New Object() { i + 1 }, Nothing)), Conversions.ToString(Operators.ConcatenateObject("#", NewLateBinding.LateIndexGet(obj, New Object() { i }, Nothing))), Nothing, Nothing)
					Next
					MRodstarXML.mnLookupPowerMeterType = New Collection()
					Dim collection3 As Collection = MRodstarXML.mnLookupPowerMeterType
					obj = New Object() { 1, "detent", 2, "non-detent" }
					Dim num5 As Integer = 0
					Dim num6 As Integer = Information.UBound(CType(obj, Array), 1)
					For i As Integer = num5 To num6 Step 2
						collection3.Add(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(obj, New Object() { i }, Nothing)), Conversions.ToString(NewLateBinding.LateIndexGet(obj, New Object() { i + 1 }, Nothing)), Nothing, Nothing)
						collection3.Add(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(obj, New Object() { i + 1 }, Nothing)), Conversions.ToString(Operators.ConcatenateObject("#", NewLateBinding.LateIndexGet(obj, New Object() { i }, Nothing))), Nothing, Nothing)
					Next
					MRodstarXML.mnLookupPumpCondition = New Collection()
					Dim collection4 As Collection = MRodstarXML.mnLookupPumpCondition
					obj = New Object() { 1, "full", 2, "pumped-off", 3, "gas-interference" }
					Dim num7 As Integer = 0
					Dim num8 As Integer = Information.UBound(CType(obj, Array), 1)
					For i As Integer = num7 To num8 Step 2
						collection4.Add(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(obj, New Object() { i }, Nothing)), Conversions.ToString(NewLateBinding.LateIndexGet(obj, New Object() { i + 1 }, Nothing)), Nothing, Nothing)
						collection4.Add(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(obj, New Object() { i + 1 }, Nothing)), Conversions.ToString(Operators.ConcatenateObject("#", NewLateBinding.LateIndexGet(obj, New Object() { i }, Nothing))), Nothing, Nothing)
					Next
					MRodstarXML.mnLookupPumpType = New Collection()
					Dim collection5 As Collection = MRodstarXML.mnLookupPumpType
					obj = New Object() { 1, "insert", 2, "tubing", 3, "large-bore" }
					Dim num9 As Integer = 0
					Dim num10 As Integer = Information.UBound(CType(obj, Array), 1)
					For i As Integer = num9 To num10 Step 2
						collection5.Add(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(obj, New Object() { i }, Nothing)), Conversions.ToString(NewLateBinding.LateIndexGet(obj, New Object() { i + 1 }, Nothing)), Nothing, Nothing)
						collection5.Add(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(obj, New Object() { i + 1 }, Nothing)), Conversions.ToString(Operators.ConcatenateObject("#", NewLateBinding.LateIndexGet(obj, New Object() { i }, Nothing))), Nothing, Nothing)
					Next
					MRodstarXML.mnLookupRodGrade = New Collection()
					Dim collection6 As Collection = MRodstarXML.mnLookupRodGrade
					obj = New Object() { 4097, "api-k", 4098, "api-c", 4099, "api-d", 4100, "electra", 4116, "norris-96", 4101, "norris-97", 4102, "ltv-hs", 4103, "upco-50k", 4104, "trico-66", 4105, "axelson-s88", 4106, "highland-xd", 4110, "upco-c-grade", 4111, "upco-cd-grade", 4112, "upco-ad-grade", 4113, "upco-kd-grade", 4114, "upco-k-grade", 4115, "upco-hs-grade", 4130, "upco-hx", 4107, "axelson-s87", 4108, "axelson-s67", 4109, "axelson-s60", 4117, "tenaris-uhs", 4118, "tenaris-mms", 4119, "tenaris-plus", 4138, "tenaris-d", 4139, "tenaris-d-alloy", 4140, "tenaris-kd", 4120, "weatherford-md56", 4121, "weatherford-kd63", 4131, "weatherford-hd", 4122, "global-ad79", 4123, "global-ss99", 4132, "camrod-c", 4133, "camrod-k", 4134, "camrod-dc", 4135, "camrod-da", 4136, "camrod-d-special", 4137, "camrod-special", 4141, "upco-hx-grade" }
					Dim num11 As Integer = 0
					Dim num12 As Integer = Information.UBound(CType(obj, Array), 1)
					For i As Integer = num11 To num12 Step 2
						collection6.Add(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(obj, New Object() { i }, Nothing)), Conversions.ToString(NewLateBinding.LateIndexGet(obj, New Object() { i + 1 }, Nothing)), Nothing, Nothing)
						collection6.Add(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(obj, New Object() { i + 1 }, Nothing)), Conversions.ToString(Operators.ConcatenateObject("#", NewLateBinding.LateIndexGet(obj, New Object() { i }, Nothing))), Nothing, Nothing)
					Next
					obj = New Object() { 8193, "sb-api-c", 8194, "sb-api-k", 8195, "flexbar-c", 8196, "flexbar-k", 8197, "sb-api-c-nn", 8198, "sb-api-k-nn", 8199, "flexbar-c-nn", 8200, "flexbar-k-nn", 8301, "nprsb-carbon", 8302, "nprsb-alloy", 8303, "nprsb-norloy", 8304, "nprsb-piston", 8305, "norris-c-sb", 8306, "norris-c-nn", 8307, "norris-k-sb", 8308, "norris-k-nn", 8309, "norris-d-sb", 8310, "norris-d-nn" }
					Dim num13 As Integer = 0
					Dim num14 As Integer = Information.UBound(CType(obj, Array), 1)
					For i As Integer = num13 To num14 Step 2
						collection6.Add(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(obj, New Object() { i }, Nothing)), Conversions.ToString(NewLateBinding.LateIndexGet(obj, New Object() { i + 1 }, Nothing)), Nothing, Nothing)
						collection6.Add(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(obj, New Object() { i + 1 }, Nothing)), Conversions.ToString(Operators.ConcatenateObject("#", NewLateBinding.LateIndexGet(obj, New Object() { i }, Nothing))), Nothing, Nothing)
					Next
					obj = New Object() { 12545, "corod-se-c", 12546, "corod-se-d", 12547, "corod-se-hs41", 12548, "corod-se-endura", 12550, "corod-se-se", 12549, "corod-se-de", 12801, "corod-round-d", 12802, "corod-round-hs41", 12803, "corod-round-endura", 12806, "corod-round-endura-se", 12805, "corod-round-endura-de", 12804, "corod-round-c", 13057, "corod-h-d", 12808, "corod-round-sw", 12807, "corod-round-dw" }
					Dim num15 As Integer = 0
					Dim num16 As Integer = Information.UBound(CType(obj, Array), 1)
					For i As Integer = num15 To num16 Step 2
						collection6.Add(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(obj, New Object() { i }, Nothing)), Conversions.ToString(NewLateBinding.LateIndexGet(obj, New Object() { i + 1 }, Nothing)), Nothing, Nothing)
						collection6.Add(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(obj, New Object() { i + 1 }, Nothing)), Conversions.ToString(Operators.ConcatenateObject("#", NewLateBinding.LateIndexGet(obj, New Object() { i }, Nothing))), Nothing, Nothing)
					Next
					obj = New Object() { 24577, "prorod-620", 24578, "prorod-790", 24579, "prorod-780", 24580, "prorod-750", 24581, "prorod-960", 24582, "prorod-970" }
					Dim num17 As Integer = 0
					Dim num18 As Integer = Information.UBound(CType(obj, Array), 1)
					For i As Integer = num17 To num18 Step 2
						collection6.Add(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(obj, New Object() { i }, Nothing)), Conversions.ToString(NewLateBinding.LateIndexGet(obj, New Object() { i + 1 }, Nothing)), Nothing, Nothing)
						collection6.Add(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(obj, New Object() { i + 1 }, Nothing)), Conversions.ToString(Operators.ConcatenateObject("#", NewLateBinding.LateIndexGet(obj, New Object() { i }, Nothing))), Nothing, Nothing)
					Next
					obj = New Object() { 16385, "fiberflex", 16386, "petrorod", 16387, "norris-fg", 16388, "durarod", 16391, "fibercom", 16389, "fiberflex-30", 16390, "fiberflex-25", 16393, "fibercom-ccr", 16396, "fiberco" }
					Dim num19 As Integer = 0
					Dim num20 As Integer = Information.UBound(CType(obj, Array), 1)
					For i As Integer = num19 To num20 Step 2
						collection6.Add(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(obj, New Object() { i }, Nothing)), Conversions.ToString(NewLateBinding.LateIndexGet(obj, New Object() { i + 1 }, Nothing)), Nothing, Nothing)
						collection6.Add(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(obj, New Object() { i + 1 }, Nothing)), Conversions.ToString(Operators.ConcatenateObject("#", NewLateBinding.LateIndexGet(obj, New Object() { i }, Nothing))), Nothing, Nothing)
					Next
					obj = New Object() { 20481, "ribbon-rod" }
					Dim num21 As Integer = 0
					Dim num22 As Integer = Information.UBound(CType(obj, Array), 1)
					For i As Integer = num21 To num22 Step 2
						collection6.Add(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(obj, New Object() { i }, Nothing)), Conversions.ToString(NewLateBinding.LateIndexGet(obj, New Object() { i + 1 }, Nothing)), Nothing, Nothing)
						collection6.Add(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(obj, New Object() { i + 1 }, Nothing)), Conversions.ToString(Operators.ConcatenateObject("#", NewLateBinding.LateIndexGet(obj, New Object() { i }, Nothing))), Nothing, Nothing)
					Next
					MRodstarXML.LoadLookupRodGrade()
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub ShowParseError(lErrorCode As Integer, ByRef sReason As String, lFilePos As Integer, lLine As Integer, lLinePos As Integer, ByRef sSrcText As String, ByRef sURL As String)
			Dim num As Integer
			Dim num2 As Integer
			Dim obj As Object
			Try
				ProjectData.ClearProjectError()
				num = 2
				If lErrorCode <> 0 Then
					Interaction.MsgBox(String.Concat(New String() { "Code: ", Conversion.Hex(lErrorCode), vbCrLf & "Reason: ", sReason, vbCrLf & "FilePos: ", Conversions.ToString(lFilePos), vbCrLf & "Line: ", Conversions.ToString(lLine), vbCrLf & "LinePos: ", Conversions.ToString(lLinePos), vbCrLf & "SrcText: """, sSrcText, """" & vbCrLf & "URL: """, sURL, """" }), MsgBoxStyle.OKOnly, Nothing)
				End If
				IL_A2:
				GoTo IL_E5
				IL_A4:
				num2 = -1
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_B8:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num2 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_A4
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_E5:
			If num2 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		Private Function StoreInputXML(ByRef xmlWriter As XmlTextWriter, Optional bXROD As Boolean = False) As Boolean
			Dim result As Boolean
			Try
				Dim cRODSTAR As cRODSTAR = RSWIN_DESC.rst
				Dim text As String
				If cRODSTAR.gbCalcPumpCondition Then
					text = Nothing
				Else
					Select Case cRODSTAR.PumpCondition
						Case 1S
							text = "full"
						Case 2S
							text = "pumped-off"
						Case 3S
							text = "gas-interference"
						Case Else
							text = Nothing
					End Select
				End If
				xmlWriter.WriteStartElement("r:input")
				Dim text2 As String = "r:calc-fluid-level"
				Dim flag As Boolean = MRodstarXML.AddBooleanElement(xmlWriter, text2, Not cRODSTAR.FluidLevelEntered)
				text2 = "r:calc-friction"
				flag = MRodstarXML.AddBooleanElement(xmlWriter, text2, cRODSTAR.CalcFriction <> 0S)
				Try
					text2 = "r:calc-sliding-friction-coeff"
					flag = MRodstarXML.AddBooleanElement(xmlWriter, text2, cRODSTAR.gbCalcSlideFricCoeff)
				Catch ex As Exception
					cRODSTAR.gbCalcSlideFricCoeff = False
				End Try
				text2 = "r:calc-irot"
				flag = MRodstarXML.AddBooleanElement(xmlWriter, text2, Not cRODSTAR.IrotEntered <> 0S)
				text2 = "r:calc-motor-size"
				flag = MRodstarXML.AddBooleanElement(xmlWriter, text2, cRODSTAR.CalcMotorSize <> 0S)
				text2 = "r:calc-motor-spv"
				flag = MRodstarXML.AddBooleanElement(xmlWriter, text2, cRODSTAR.CalcMotorSPV <> 0S)
				text2 = "r:calc-plunger-size"
				flag = MRodstarXML.AddBooleanElement(xmlWriter, text2, cRODSTAR.CalcPlungerSize <> 0S)
				text2 = "r:calc-pump-condition"
				flag = MRodstarXML.AddBooleanElement(xmlWriter, text2, cRODSTAR.gbCalcPumpCondition)
				text2 = "r:calc-pump-intake-pressure"
				flag = MRodstarXML.AddBooleanElement(xmlWriter, text2, cRODSTAR.gbCalcPumpIntakePressure)
				text2 = "r:calc-pumping-speed"
				flag = MRodstarXML.AddBooleanElement(xmlWriter, text2, Not cRODSTAR.SPMEntered <> 0S)
				text2 = "r:calc-target-production"
				flag = MRodstarXML.AddBooleanElement(xmlWriter, text2, cRODSTAR.gbCalcTargetBFPD)
				text2 = "r:casing-pressure"
				flag = MRodstarXML.AddDecimalElement(xmlWriter, text2, CDbl(cRODSTAR.CasingPressure))
				text2 = "r:cbalance-file"
				Dim text3 As String = Strings.Trim(cRODSTAR.CBDataFile)
				flag = MRodstarXML.AddStringElement(xmlWriter, text2, text3, True)
				text3 = "r:comment"
				text2 = Strings.Trim(cRODSTAR.FileComment)
				flag = MRodstarXML.AddStringElement(xmlWriter, text3, text2, True)
				Try
					text3 = "r:cover-page-comment"
					Dim cRODSTAR2 As cRODSTAR = cRODSTAR
					text2 = cRODSTAR2.CoverPageComment
					MRodstarXML.AddStringElement(xmlWriter, text3, text2, True)
					cRODSTAR2.CoverPageComment = text2
				Catch ex2 As Exception
				End Try
				text3 = "r:company-name"
				text2 = Strings.Trim(cRODSTAR.ACompanyName)
				flag = MRodstarXML.AddStringElement(xmlWriter, text3, text2, True)
				text3 = "r:compressibility-index"
				flag = MRodstarXML.AddDecimalElement(xmlWriter, text3, CDbl(cRODSTAR.CompressibilityIndex))
				text3 = "r:date"
				text2 = Strings.Trim(cRODSTAR.UserDate)
				flag = MRodstarXML.AddStringElement(xmlWriter, text3, text2, False)
				MRodstarXML.AddDeviationSurvey(xmlWriter)
				text3 = "r:electricity-cost"
				flag = MRodstarXML.AddDecimalElement(xmlWriter, text3, CDbl(cRODSTAR.ElectricityCost))
				text3 = "r:fluid-damping"
				flag = MRodstarXML.AddDecimalElement(xmlWriter, text3, CDbl(cRODSTAR.FluidDamping))
				text3 = "r:fluid-level"
				flag = MRodstarXML.AddDecimalElement(xmlWriter, text3, CDbl(cRODSTAR.FluidLevel))
				Try
					text3 = "r:calc-fluid-spgr"
					flag = MRodstarXML.AddBooleanElement(xmlWriter, text3, cRODSTAR.gbCalcFluidSPGR)
				Catch ex3 As Exception
					RSWIN_DESC.rst.gbCalcFluidSPGR = False
				End Try
				If RSWIN_DESC.bRodStarD Then
					Try
						text3 = "r:paraffin"
						flag = MRodstarXML.AddBooleanElement(xmlWriter, text3, cRODSTAR.gbParaffin)
					Catch ex4 As Exception
						RSWIN_DESC.rst.gbParaffin = False
					End Try
					Try
						text3 = "r:paraffin-depth"
						flag = MRodstarXML.AddDecimalElement(xmlWriter, text3, CDbl(cRODSTAR.ParaffinDepth))
					Catch ex5 As Exception
					End Try
				End If
				text3 = "r:fluid-spgr"
				flag = MRodstarXML.AddDecimalElement(xmlWriter, text3, CDbl(cRODSTAR.FluidSPGR))
				text3 = "r:include-buoyancy"
				flag = MRodstarXML.AddBooleanElement(xmlWriter, text3, cRODSTAR.gbIncludeBuoyancy)
				text3 = "r:include-fluid-inertia"
				flag = MRodstarXML.AddBooleanElement(xmlWriter, text3, cRODSTAR.IncludeFluidInertia <> 0S)
				text3 = "r:inertia-articulating"
				flag = MRodstarXML.AddDecimalElement(xmlWriter, text3, CDbl(cRODSTAR.Iart))
				text3 = "r:inertia-rotating"
				flag = MRodstarXML.AddDecimalElement(xmlWriter, text3, CDbl(cRODSTAR.Irot))
				MRodstarXML.AddIPRProfile(xmlWriter)
				If cRODSTAR.UnknownM OrElse bXROD Then
					text3 = "r:max-existing-counterbalance"
					MRodstarXML.AddNilElement(xmlWriter, text3)
					text3 = "r:cb-effect"
					MRodstarXML.AddNilElement(xmlWriter, text3)
					text3 = "r:cb-angle"
					MRodstarXML.AddNilElement(xmlWriter, text3)
					text3 = "r:cb-datatype"
					MRodstarXML.AddNilElement(xmlWriter, text3)
				Else
					text3 = "r:max-existing-counterbalance"
					flag = MRodstarXML.AddDecimalElement(xmlWriter, text3, CDbl(cRODSTAR.get_M(2)))
					If RSWIN_DESC.rst.CBEffect >= 0F Then
						text3 = "r:cb-effect"
						flag = MRodstarXML.AddDecimalElement(xmlWriter, text3, CDbl(RSWIN_DESC.rst.CBEffect))
					Else
						text3 = "r:cb-effect"
						MRodstarXML.AddNilElement(xmlWriter, text3)
					End If
					If RSWIN_DESC.rst.CBAngle >= 0F Then
						text3 = "r:cb-angle"
						flag = MRodstarXML.AddDecimalElement(xmlWriter, text3, CDbl(RSWIN_DESC.rst.CBAngle))
					Else
						text3 = "r:cb-angle"
						MRodstarXML.AddNilElement(xmlWriter, text3)
					End If
					If RSWIN_DESC.rst.CBDataType >= 0S Then
						text3 = "r:cb-datatype"
						MRodstarXML.AddIntegerElement(xmlWriter, text3, CInt(RSWIN_DESC.rst.CBDataType))
					Else
						text3 = "r:cb-datatype"
						MRodstarXML.AddIntegerElement(xmlWriter, text3, 0)
					End If
				End If
				text3 = "r:max-pump-drag-downstroke"
				flag = MRodstarXML.AddDecimalElement(xmlWriter, text3, CDbl(cRODSTAR.PumpDragDownstrokeMax))
				text3 = "r:max-pump-drag-upstroke"
				flag = MRodstarXML.AddDecimalElement(xmlWriter, text3, CDbl(cRODSTAR.PumpDragDownstrokeMax))
				MRodstarXML.AddMeasuredDyno(xmlWriter)
				Dim num As Integer = Conversions.ToInteger(Motor.GetMotorInfo(4))
				text3 = "r:motor-kind"
				MRodstarXML.AddIntegerElement(xmlWriter, text3, Conversions.ToInteger(Operators.SubtractObject(Motor.GetMotorInfo(4), 1)))
				If num < 9 Then
					text3 = "r:motor-setting"
					text2 = Conversions.ToString(Motor.GetMotorInfo(2))
					flag = MRodstarXML.AddStringElement(xmlWriter, text3, text2, True)
					text3 = "r:motor-size"
					text2 = Conversions.ToString(Motor.GetMotorInfo(3))
					flag = MRodstarXML.AddStringElement(xmlWriter, text3, text2, True)
				Else
					Dim text4 As String = Conversions.ToString(Motor.GetMotorInfo(3))
					Dim text5 As String = Conversions.ToString(Motor.GetMotorInfo(2))
					If Strings.InStr(text4, "АДЧР", CompareMethod.Binary) > 0 Then
						text4 = text4.Replace("АДЧР", "ADYP")
					Else
						text4 = text4
					End If
					If Strings.InStr(text4, "ВА", CompareMethod.Binary) > 0 Then
						text4 = text4.Replace("ВА", "BA")
					End If
					If Strings.InStr(text4, "М", CompareMethod.Binary) > 0 Then
						text4 = text4.Replace("М", "M")
					End If
					If Strings.InStr(text4, "S", CompareMethod.Binary) > 0 Then
						text4 = text4.Replace("S", "S")
					End If
					If Strings.InStr(text4, "L", CompareMethod.Binary) > 0 Then
						text4 = text4.Replace("L", "L")
					End If
					If Strings.InStr(text4, "IP", CompareMethod.Binary) > 0 Then
						text4 = text4.Replace("IP", "IP")
					End If
					If Strings.InStr(text5, "АДЧР", CompareMethod.Binary) > 0 Then
						text5 = text5.Replace("АДЧР", "ADYP")
					Else
						text5 = text5
					End If
					If Strings.InStr(text5, "ВА", CompareMethod.Binary) > 0 Then
						text5 = text5.Replace("ВА", "BA")
					End If
					If Strings.InStr(text5, "М", CompareMethod.Binary) > 0 Then
						text5 = text5.Replace("М", "M")
					End If
					If Strings.InStr(text5, "S", CompareMethod.Binary) > 0 Then
						text5 = text5.Replace("S", "S")
					End If
					If Strings.InStr(text5, "L", CompareMethod.Binary) > 0 Then
						text5 = text5.Replace("L", "L")
					End If
					If Strings.InStr(text5, "IP", CompareMethod.Binary) > 0 Then
						text5 = text5.Replace("IP", "IP")
					End If
					text3 = "r:motor-setting"
					flag = MRodstarXML.AddStringElement(xmlWriter, text3, text5, True)
					text3 = "r:motor-size"
					flag = MRodstarXML.AddStringElement(xmlWriter, text3, text4, True)
				End If
				text3 = "r:motor-speed-variation"
				flag = MRodstarXML.AddDecimalElement(xmlWriter, text3, CDbl(cRODSTAR.MotorSPV))
				text3 = "r:oil-density"
				flag = MRodstarXML.AddDecimalElement(xmlWriter, text3, CDbl(cRODSTAR.OilAPI))
				text3 = "r:plunger-size"
				flag = MRodstarXML.AddDecimalElement(xmlWriter, text3, CDbl(cRODSTAR.PlungerSize))
				text3 = "r:polrod-drag-proportionality"
				MRodstarXML.AddDragProportionalityElement(xmlWriter, text3, CInt((cRODSTAR.DragSettings / 16S And 3S)))
				text3 = "r:power-meter-type"
				text2 = Convert.ToString(RuntimeHelpers.GetObjectValue(MRodstarXML.DoLookup(MRodstarXML.mnLookupPowerMeterType, cRODSTAR.PowerMeterType)))
				flag = MRodstarXML.AddStringElement(xmlWriter, text3, text2, False)
				If text Is Nothing Then
					Select Case cRODSTAR.PumpCondition
						Case 1S
							text = "full"
						Case 2S
							text = "pumped-off"
						Case 3S
							text = "gas-interference"
						Case Else
							text = Nothing
					End Select
				End If
				text3 = "r:pump-condition"
				flag = MRodstarXML.AddStringElement(xmlWriter, text3, text, False)
				text3 = "r:pump-depth"
				flag = MRodstarXML.AddDecimalElement(xmlWriter, text3, CDbl(cRODSTAR.PumpDepth))
				text3 = "r:pump-drag-d-proportionality"
				MRodstarXML.AddDragProportionalityElement(xmlWriter, text3, CInt((cRODSTAR.DragSettings / 4S And 3S)))
				text3 = "r:pump-drag-u-proportionality"
				MRodstarXML.AddDragProportionalityElement(xmlWriter, text3, CInt((cRODSTAR.DragSettings And 3S)))
				text3 = "r:pump-efficiency"
				flag = MRodstarXML.AddDecimalElement(xmlWriter, text3, CDbl(cRODSTAR.PumpEfficiency))
				text3 = "r:pump-fillage"
				flag = MRodstarXML.AddDecimalElement(xmlWriter, text3, CDbl(cRODSTAR.PumpFillage))
				text3 = "r:pump-friction"
				flag = MRodstarXML.AddDecimalElement(xmlWriter, text3, CDbl(cRODSTAR.PumpFriction))
				text3 = "r:pump-intake-pressure"
				flag = MRodstarXML.AddDecimalElement(xmlWriter, text3, CDbl(cRODSTAR.PumpIntakePressure))
				cRODSTAR.UPumpIntakePressure = cRODSTAR.PumpIntakePressure
				text3 = "r:pump-load-adjustment"
				flag = MRodstarXML.AddDecimalElement(xmlWriter, text3, CDbl(cRODSTAR.PumpLoadAdj))
				text3 = "r:pump-type"
				text2 = Convert.ToString(RuntimeHelpers.GetObjectValue(MRodstarXML.DoLookup(MRodstarXML.mnLookupPumpType, cRODSTAR.PumpType)))
				flag = MRodstarXML.AddStringElement(xmlWriter, text3, text2, False)
				text3 = "r:pumping-speed"
				flag = MRodstarXML.AddDecimalElement(xmlWriter, text3, CDbl(cRODSTAR.SPM))
				text3 = "r:vsp"
				flag = MRodstarXML.AddBooleanElement(xmlWriter, text3, cRODSTAR.VSP)
				If RSWIN_DESC.rst.PU.UnitType = 8S Or (RSWIN_DESC.rst.PU.UnitType = 11S And Not RSWIN_DESC.rst.bUseCrankBalancedCalcs) Then
					RSWIN_DESC.bBeamBalanced = True
				Else
					RSWIN_DESC.bBeamBalanced = False
				End If
				If RSWIN_DESC.bBeamBalanced Then
					text3 = "r:beam-balanced"
					flag = MRodstarXML.AddBooleanElement(xmlWriter, text3, cRODSTAR.bUnknownUnbalance)
				End If
				If Not bXROD Then
					MRodstarXML.AddPumpingUnit(xmlWriter)
					MRodstarXML.AddRodStringDesign(xmlWriter)
					text3 = "r:rod-string-extra-cost"
					flag = MRodstarXML.AddDecimalElement(xmlWriter, text3, CDbl(cRODSTAR.RSExtraCost))
					text3 = "r:rod-string-extra-cost-desc"
					Dim cRODSTAR2 As cRODSTAR = cRODSTAR
					text2 = cRODSTAR2.RSExtraCostLabel
					MRodstarXML.AddStringElement(xmlWriter, text3, text2, True)
					cRODSTAR2.RSExtraCostLabel = text2
					MRodstarXML.AddRodTapers(xmlWriter)
					Try
						text3 = "r:sliding-friction-coeff"
						flag = MRodstarXML.AddDecimalElement(xmlWriter, text3, CDbl(cRODSTAR.SlideFricCoeff))
					Catch ex6 As Exception
					End Try
					text3 = "r:service-factor"
					flag = MRodstarXML.AddDecimalElement(xmlWriter, text3, CDbl(cRODSTAR.ServiceFactor))
				End If
				text3 = "r:rod-tubing-friction-downstroke"
				flag = MRodstarXML.AddDecimalElement(xmlWriter, text3, CDbl(cRODSTAR.DownstrokeFriction))
				text3 = "r:rod-tubing-friction-upstroke"
				flag = MRodstarXML.AddDecimalElement(xmlWriter, text3, CDbl(cRODSTAR.UpstrokeFriction))
				text3 = "r:runtime"
				flag = MRodstarXML.AddDecimalElement(xmlWriter, text3, CDbl(cRODSTAR.Runtime))
				text3 = "r:stuffing-box-friction"
				flag = MRodstarXML.AddDecimalElement(xmlWriter, text3, CDbl(cRODSTAR.StuffingBoxFriction))
				text3 = "r:target-production"
				flag = MRodstarXML.AddDecimalElement(xmlWriter, text3, CDbl(cRODSTAR.TargetBFPD))
				text3 = "r:tubing-anchor-depth"
				flag = MRodstarXML.AddDecimalElement(xmlWriter, text3, CDbl(cRODSTAR.TubingAnchorDepth))
				text3 = "r:tubing-anchored"
				flag = MRodstarXML.AddBooleanElement(xmlWriter, text3, cRODSTAR.TubingAnchored <> 0S)
				text3 = "r:tubing-id"
				flag = MRodstarXML.AddDecimalElement(xmlWriter, text3, CDbl(cRODSTAR.TubingID))
				text3 = "r:tubing-od"
				flag = MRodstarXML.AddDecimalElement(xmlWriter, text3, CDbl(cRODSTAR.TubingOD))
				text3 = "r:tubing-pressure"
				flag = MRodstarXML.AddDecimalElement(xmlWriter, text3, CDbl(cRODSTAR.TubingPressure))
				text3 = "r:user-name"
				text2 = Strings.Trim(cRODSTAR.UserName)
				flag = MRodstarXML.AddStringElement(xmlWriter, text3, text2, True)
				text3 = "r:water-cut"
				flag = MRodstarXML.AddDecimalElement(xmlWriter, text3, CDbl(cRODSTAR.WaterCut))
				text3 = "r:water-spgr"
				flag = MRodstarXML.AddDecimalElement(xmlWriter, text3, CDbl(cRODSTAR.WaterSPGR))
				text3 = "r:well-name"
				text2 = Strings.Trim(cRODSTAR.WellName)
				flag = MRodstarXML.AddStringElement(xmlWriter, text3, text2, True)
				text3 = "r:deviated-case"
				flag = MRodstarXML.AddBooleanElement(xmlWriter, text3, cRODSTAR.bDeviated)
				Try
					text3 = "r:design-sinkerbar"
					flag = MRodstarXML.AddBooleanElement(xmlWriter, text3, cRODSTAR.gbDesignSinkerbar)
				Catch ex7 As Exception
				End Try
				text3 = "r:rodstard-save-flag"
				flag = MRodstarXML.AddBooleanElement(xmlWriter, text3, RSWIN_DESC.bRodStarD)
				If bXROD Then
					MRodstarXML.AddAIPreferences(xmlWriter)
				End If
				If RSWIN_DESC.rst.PU.UnitType = 10S Then
					If cRODSTAR.AdjustedStrokeLength = -1F Then
						cRODSTAR.AdjustedStrokeLength = cRODSTAR.PU.MaxStroke
					End If
					text3 = "r:adjusted-stroke-length"
					flag = MRodstarXML.AddDecimalElement(xmlWriter, text3, CDbl(cRODSTAR.AdjustedStrokeLength))
					text3 = "r:downstroke-pumping-speed-percentage"
					flag = MRodstarXML.AddDecimalElement(xmlWriter, text3, CDbl(cRODSTAR.PercentDownstrokeSPM))
					text3 = "r:upstroke-pumping-speed-percentage"
					flag = MRodstarXML.AddDecimalElement(xmlWriter, text3, CDbl(cRODSTAR.PercentUpstrokeSPM))
				ElseIf RSWIN_DESC.rst.PU.UnitType = 11S Then
					text3 = "r:use-crank-balanced-calcs"
					flag = MRodstarXML.AddBooleanElement(xmlWriter, text3, RSWIN_DESC.rst.bUseCrankBalancedCalcs)
				End If
				text3 = "r:polished-rod-diameter"
				flag = MRodstarXML.AddDecimalElement(xmlWriter, text3, CDbl(cRODSTAR.PR_Diameter))
				xmlWriter.WriteEndElement()
				cRODSTAR = Nothing
				result = flag
			Catch ex8 As Exception
				Dim flag As Boolean = False
				result = flag
			End Try
			Return result
		End Function

		Private Function LoadOutputXML(ByRef xmlDoc As XmlDocument, ByRef nsmgr As XmlNamespaceManager) As Boolean
			Dim flag As Boolean = False
			Dim flag2 As Boolean = False
			Dim result As Boolean
			Try
				Application.DoEvents()
				Application.DoEvents()
				Dim xmlNode As XmlNode = xmlDoc.SelectSingleNode("//r:output", nsmgr)
				If xmlNode IsNot Nothing Then
					Dim xmlNode2 As XmlNode = xmlNode
					If RSWIN_DESC.bRodStarD Then
						Try
							flag2 = MRodstarXML.CheckBoolean(xmlNode2.SelectSingleNode("r:rodstard-new-calcs", nsmgr).InnerText)
						Catch ex As Exception
							flag2 = False
						End Try
					End If
					RSWIN_DESC.rst.BPDsurface = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:bpd-surface", nsmgr).InnerText)
					RSWIN_DESC.rst.FluidLoad = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:fluid-load", nsmgr).InnerText)
					Try
						RSWIN_DESC.rst.FluidLevelTVD = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:fluid-level-tvd", nsmgr).InnerText)
					Catch ex2 As Exception
					End Try
					RSWIN_DESC.rst.FoSkr = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:fzero-skr", nsmgr).InnerText)
					RSWIN_DESC.rst.GrossPumpStroke = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:gross-pump-stroke", nsmgr).InnerText)
					RSWIN_DESC.rst.MaxRodStressL = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:max-rod-stress-loading", nsmgr).InnerText)
					RSWIN_DESC.rst.MinMotorHP = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:min-motor-hp", nsmgr).InnerText)
					RSWIN_DESC.rst.Mprload = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:mprload", nsmgr).InnerText)
					RSWIN_DESC.rst.NoverNoP = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:n-over-nzeroprime", nsmgr).InnerText)
					RSWIN_DESC.rst.Ntsteps = CShort(Math.Round(CDbl(Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:ntsteps", nsmgr).InnerText))))
					RSWIN_DESC.rst.NtstepsUpstroke = CShort(Math.Round(CDbl(Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:ntsteps-upstroke", nsmgr).InnerText))))
					RSWIN_DESC.rst.Pfill = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:pfill", nsmgr).InnerText)
					RSWIN_DESC.rst.PlungerLength = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:plunger-length", nsmgr).InnerText)
					RSWIN_DESC.rst.Pprload = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:pprload", nsmgr).InnerText)
					RSWIN_DESC.rst.Prhp = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:prhp", nsmgr).InnerText)
					Try
						RSWIN_DESC.rst.Plhp = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:plhp", nsmgr).InnerText)
					Catch ex3 As Exception
						RSWIN_DESC.rst.Plhp = 0F
					End Try
					RSWIN_DESC.rst.ProductionLoss = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:production-loss", nsmgr).InnerText)
					RSWIN_DESC.rst.PumpLength = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:pump-length", nsmgr).InnerText)
					RSWIN_DESC.rst.PumpSpacing = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:pump-spacing", nsmgr).InnerText)
					RSWIN_DESC.rst.StructL = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:structure-loading", nsmgr).InnerText)
					RSWIN_DESC.rst.SystemEff = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:system-eff", nsmgr).InnerText)
					RSWIN_DESC.rst.TubStretch = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:tubing-stretch", nsmgr).InnerText)
					RSWIN_DESC.rst.WrodsInFluid = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:wrods-in-fluid", nsmgr).InnerText)
					Dim xmlNode3 As XmlNode = xmlNode2.SelectSingleNode("r:peak-gearbox-torque", nsmgr)
					Dim xmlNode4 As XmlNode = xmlNode3
					Try
						RSWIN_DESC.rst.PeakTorque(2) = Util.ConvertToSingle(xmlNode4.SelectSingleNode("r:existing", nsmgr).InnerText)
						RSWIN_DESC.rst.PeakTorque(0) = Util.ConvertToSingle(xmlNode4.SelectSingleNode("r:min-energy", nsmgr).InnerText)
						RSWIN_DESC.rst.PeakTorque(1) = Util.ConvertToSingle(xmlNode4.SelectSingleNode("r:min-torque", nsmgr).InnerText)
					Catch ex4 As Exception
					End Try
					xmlNode3 = xmlNode2.SelectSingleNode("r:monthly-electric-bill", nsmgr)
					Dim xmlNode5 As XmlNode = xmlNode3
					Try
						RSWIN_DESC.rst.set_ElectricBillperMonth(2, Util.ConvertToSingle(xmlNode5.SelectSingleNode("r:existing", nsmgr).InnerText))
						RSWIN_DESC.rst.set_ElectricBillperMonth(0, Util.ConvertToSingle(xmlNode5.SelectSingleNode("r:min-energy", nsmgr).InnerText))
						RSWIN_DESC.rst.set_ElectricBillperMonth(1, Util.ConvertToSingle(xmlNode5.SelectSingleNode("r:min-torque", nsmgr).InnerText))
					Catch ex5 As Exception
					End Try
					xmlNode3 = xmlNode2.SelectSingleNode("r:motor-kwh", nsmgr)
					Dim xmlNode6 As XmlNode = xmlNode3
					Try
						RSWIN_DESC.rst.MotorKWH(2) = Util.ConvertToSingle(xmlNode6.SelectSingleNode("r:existing", nsmgr).InnerText)
						RSWIN_DESC.rst.MotorKWH(0) = Util.ConvertToSingle(xmlNode6.SelectSingleNode("r:min-energy", nsmgr).InnerText)
						RSWIN_DESC.rst.MotorKWH(1) = Util.ConvertToSingle(xmlNode6.SelectSingleNode("r:min-torque", nsmgr).InnerText)
					Catch ex6 As Exception
					End Try
					If RSWIN_DESC.rst.PU.UnitType = 8S Or (RSWIN_DESC.rst.PU.UnitType = 11S And Not RSWIN_DESC.rst.bUseCrankBalancedCalcs) Then
						xmlNode3 = xmlNode2.SelectSingleNode("r:required-unbalance", nsmgr)
						Dim xmlNode7 As XmlNode = xmlNode3
						Try
							RSWIN_DESC.rst.set_RequiredUnbalance(2, Util.ConvertToSingle(xmlNode7.SelectSingleNode("r:existing", nsmgr).InnerText))
							RSWIN_DESC.rst.set_RequiredUnbalance(0, Util.ConvertToSingle(xmlNode7.SelectSingleNode("r:min-energy", nsmgr).InnerText))
							RSWIN_DESC.rst.set_RequiredUnbalance(1, Util.ConvertToSingle(xmlNode7.SelectSingleNode("r:min-torque", nsmgr).InnerText))
						Catch ex7 As Exception
						End Try
					Else
						xmlNode3 = xmlNode2.SelectSingleNode("r:maximum-counterbalance", nsmgr)
						Dim xmlNode8 As XmlNode = xmlNode3
						Try
							RSWIN_DESC.rst.set_M(2, Util.ConvertToSingle(xmlNode8.SelectSingleNode("r:existing", nsmgr).InnerText))
							RSWIN_DESC.rst.set_M(0, Util.ConvertToSingle(xmlNode8.SelectSingleNode("r:min-energy", nsmgr).InnerText))
							RSWIN_DESC.rst.set_M(1, Util.ConvertToSingle(xmlNode8.SelectSingleNode("r:min-torque", nsmgr).InnerText))
						Catch ex8 As Exception
						End Try
					End If
					xmlNode3 = xmlNode2.SelectSingleNode("r:hp-uhs", nsmgr)
					Dim xmlNode9 As XmlNode = xmlNode3
					Try
						RSWIN_DESC.rst.HpUhs(2) = Util.ConvertToSingle(xmlNode9.SelectSingleNode("r:existing", nsmgr).InnerText)
						RSWIN_DESC.rst.HpUhs(0) = Util.ConvertToSingle(xmlNode9.SelectSingleNode("r:min-energy", nsmgr).InnerText)
						RSWIN_DESC.rst.HpUhs(1) = Util.ConvertToSingle(xmlNode9.SelectSingleNode("r:min-torque", nsmgr).InnerText)
					Catch ex9 As Exception
					End Try
					xmlNode3 = xmlNode2.SelectSingleNode("r:hp-nema-d", nsmgr)
					Dim xmlNode10 As XmlNode = xmlNode3
					Try
						RSWIN_DESC.rst.HpNemaD(2) = Util.ConvertToSingle(xmlNode10.SelectSingleNode("r:existing", nsmgr).InnerText)
						RSWIN_DESC.rst.HpNemaD(0) = Util.ConvertToSingle(xmlNode10.SelectSingleNode("r:min-energy", nsmgr).InnerText)
						RSWIN_DESC.rst.HpNemaD(1) = Util.ConvertToSingle(xmlNode10.SelectSingleNode("r:min-torque", nsmgr).InnerText)
					Catch ex10 As Exception
					End Try
					xmlNode3 = xmlNode2.SelectSingleNode("r:gearbox-loading", nsmgr)
					Dim xmlNode11 As XmlNode = xmlNode3
					Try
						RSWIN_DESC.rst.GearboxLoading(2) = Util.ConvertToSingle(xmlNode11.SelectSingleNode("r:existing", nsmgr).InnerText)
						RSWIN_DESC.rst.GearboxLoading(0) = Util.ConvertToSingle(xmlNode11.SelectSingleNode("r:min-energy", nsmgr).InnerText)
						RSWIN_DESC.rst.GearboxLoading(1) = Util.ConvertToSingle(xmlNode11.SelectSingleNode("r:min-torque", nsmgr).InnerText)
					Catch ex11 As Exception
					End Try
					xmlNode3 = xmlNode2.SelectSingleNode("r:cyclic-load-factor", nsmgr)
					Dim xmlNode12 As XmlNode = xmlNode3
					Try
						RSWIN_DESC.rst.Clf(2) = Util.ConvertToSingle(xmlNode12.SelectSingleNode("r:existing", nsmgr).InnerText)
						RSWIN_DESC.rst.Clf(0) = Util.ConvertToSingle(xmlNode12.SelectSingleNode("r:min-energy", nsmgr).InnerText)
						RSWIN_DESC.rst.Clf(1) = Util.ConvertToSingle(xmlNode12.SelectSingleNode("r:min-torque", nsmgr).InnerText)
					Catch ex12 As Exception
					End Try
					xmlNode3 = xmlNode2.SelectSingleNode("r:cost-per-bbl-oil", nsmgr)
					Dim xmlNode13 As XmlNode = xmlNode3
					Try
						RSWIN_DESC.rst.DollarsPerBblOil(2) = Util.ConvertToSingle(xmlNode13.SelectSingleNode("r:existing", nsmgr).InnerText)
						RSWIN_DESC.rst.DollarsPerBblOil(0) = Util.ConvertToSingle(xmlNode13.SelectSingleNode("r:min-energy", nsmgr).InnerText)
						RSWIN_DESC.rst.DollarsPerBblOil(1) = Util.ConvertToSingle(xmlNode13.SelectSingleNode("r:min-torque", nsmgr).InnerText)
					Catch ex13 As Exception
					End Try
					xmlNode3 = xmlNode2.SelectSingleNode("r:cost-per-bbl-fluid", nsmgr)
					Dim xmlNode14 As XmlNode = xmlNode3
					Try
						RSWIN_DESC.rst.DollarsPerBblFluid(2) = Util.ConvertToSingle(xmlNode14.SelectSingleNode("r:existing", nsmgr).InnerText)
						RSWIN_DESC.rst.DollarsPerBblFluid(0) = Util.ConvertToSingle(xmlNode14.SelectSingleNode("r:min-energy", nsmgr).InnerText)
						RSWIN_DESC.rst.DollarsPerBblFluid(1) = Util.ConvertToSingle(xmlNode14.SelectSingleNode("r:min-torque", nsmgr).InnerText)
					Catch ex14 As Exception
					End Try
					xmlNode3 = xmlNode2.SelectSingleNode("r:cbeffect-at-90-deg", nsmgr)
					Dim xmlNode15 As XmlNode = xmlNode3
					Try
						RSWIN_DESC.rst.CBE90(2) = Util.ConvertToSingle(xmlNode15.SelectSingleNode("r:existing", nsmgr).InnerText)
						RSWIN_DESC.rst.CBE90(0) = Util.ConvertToSingle(xmlNode15.SelectSingleNode("r:min-energy", nsmgr).InnerText)
						RSWIN_DESC.rst.CBE90(1) = Util.ConvertToSingle(xmlNode15.SelectSingleNode("r:min-torque", nsmgr).InnerText)
					Catch ex15 As Exception
					End Try
					Dim xmlNodeList As XmlNodeList = xmlNode2.SelectNodes(".//r:net-torque-point", nsmgr)
					Dim xmlNodeList2 As XmlNodeList = xmlNodeList
					RSWIN_DESC.rst.Ntsteps = CShort(xmlNodeList2.Count)
					Dim tnet As Single(,) = New Single(2, CInt((RSWIN_DESC.rst.Ntsteps - 1S + 1S)) - 1) {}
					RSWIN_DESC.rst.Tnet = tnet
					Dim enumerator As IEnumerator = xmlNodeList2.GetEnumerator()
					Dim num As Integer = 0
					While enumerator.MoveNext()
						Dim obj As Object = enumerator.Current
						xmlNode3 = CType(obj, XmlNode)
						RSWIN_DESC.rst.Tnet(2, num) = Util.ConvertToSingle(xmlNode3("r:existing").InnerText)
						RSWIN_DESC.rst.Tnet(0, num) = Util.ConvertToSingle(xmlNode3("r:min-energy").InnerText)
						RSWIN_DESC.rst.Tnet(1, num) = Util.ConvertToSingle(xmlNode3("r:min-torque").InnerText)
						num += 1
					End While
					xmlNodeList = xmlNode2.SelectNodes("r:calculated-rod-tapers/r:calculated-rod-taper", nsmgr)
					Dim xmlNodeList3 As XmlNodeList = xmlNodeList
					RSWIN_DESC.rst.NumRods = CShort(xmlNodeList3.Count)
					num = 1
					For Each obj2 As Object In xmlNodeList3
						xmlNode3 = CType(obj2, XmlNode)
						RSWIN_DESC.rst.maxStressTop(num) = Util.ConvertToSingle(xmlNode3("r:max-rod-stress-top").InnerText)
						RSWIN_DESC.rst.minStressBot(num) = Util.ConvertToSingle(xmlNode3("r:min-rod-stress-bot").InnerText)
						RSWIN_DESC.rst.minStressTop(num) = Util.ConvertToSingle(xmlNode3("r:min-rod-stress-top").InnerText)
						RSWIN_DESC.rst.StressL(num) = Util.ConvertToSingle(xmlNode3("r:rod-stress-loading").InnerText)
						num += 1
					Next
					Try
						xmlNodeList = xmlNode2.SelectNodes(".//r:predicted-dynamometer-card-point", nsmgr)
						Dim xmlNodeList4 As XmlNodeList = xmlNodeList
						RSWIN_DESC.rst.Ntsteps = CShort(xmlNodeList4.Count)
						Dim array As Single() = New Single(CInt((RSWIN_DESC.rst.Ntsteps - 1S + 1S)) - 1) {}
						RSWIN_DESC.rst.SurfLoad = array
						array = New Single(CInt((RSWIN_DESC.rst.Ntsteps - 1S + 1S)) - 1) {}
						RSWIN_DESC.rst.SurfPos = array
						array = New Single(CInt((RSWIN_DESC.rst.Ntsteps - 1S + 1S)) - 1) {}
						RSWIN_DESC.rst.PumpLoad = array
						array = New Single(CInt((RSWIN_DESC.rst.Ntsteps - 1S + 1S)) - 1) {}
						RSWIN_DESC.rst.PumpPos = array
						array = New Single(CInt((RSWIN_DESC.rst.Ntsteps - 1S + 1S)) - 1) {}
						RSWIN_DESC.rst.PermLoad = array
						array = New Single(CInt((RSWIN_DESC.rst.Ntsteps - 1S + 1S)) - 1) {}
						RSWIN_DESC.rst.Thetac = array
						array = New Single(CInt((RSWIN_DESC.rst.Ntsteps - 1S + 1S)) - 1) {}
						RSWIN_DESC.rst.Tf = array
						enumerator = xmlNodeList4.GetEnumerator()
						num = 0
						While enumerator.MoveNext()
							Dim obj3 As Object = enumerator.Current
							xmlNode3 = CType(obj3, XmlNode)
							RSWIN_DESC.rst.SurfLoad(num) = Util.ConvertToSingle(xmlNode3("r:surface-load").InnerText)
							RSWIN_DESC.rst.SurfPos(num) = Util.ConvertToSingle(xmlNode3("r:surface-position").InnerText)
							RSWIN_DESC.rst.PumpLoad(num) = Util.ConvertToSingle(xmlNode3("r:pump-load").InnerText)
							RSWIN_DESC.rst.PumpPos(num) = Util.ConvertToSingle(xmlNode3("r:pump-position").InnerText)
							RSWIN_DESC.rst.PermLoad(num) = Util.ConvertToSingle(xmlNode3("r:permissible-load").InnerText)
							RSWIN_DESC.rst.Thetac(num) = Util.ConvertToSingle(xmlNode3("r:thetac").InnerText)
							RSWIN_DESC.rst.Tf(num) = Util.ConvertToSingle(xmlNode3("r:torque-factor").InnerText)
							num += 1
						End While
					Catch ex16 As Exception
					End Try
					If RSWIN_DESC.mdsDeviationProfile.Tables(0).Rows.Count > 2 Then
						Try
							Dim impredObj As TEImpred = MImpred.ImpredObj
							xmlNodeList = xmlNode2.SelectNodes(".//r:rod-element-data-point", nsmgr)
							Dim xmlNodeList5 As XmlNodeList = xmlNodeList
							impredObj.num_rod_elements = xmlNodeList5.Count
							enumerator = xmlNodeList5.GetEnumerator()
							num = 0
							While enumerator.MoveNext()
								Dim obj4 As Object = enumerator.Current
								xmlNode3 = CType(obj4, XmlNode)
								Dim value As TEImpred.rod_element_data_type
								value.m_d = CDbl(Util.ConvertToDouble(xmlNode3("r:m-d").InnerText))
								value.dog = CDbl(Util.ConvertToDouble(xmlNode3("r:dog").InnerText))
								value.rad = CDbl(Util.ConvertToDouble(xmlNode3("r:rad").InnerText))
								value.ea = CDbl(Util.ConvertToDouble(xmlNode3("r:ea").InnerText))
								value.friction_coef = CDbl(Util.ConvertToDouble(xmlNode3("r:friction-coef").InnerText))
								value.mass = CDbl(Util.ConvertToDouble(xmlNode3("r:mass").InnerText))
								value.buoy_weight = CDbl(Util.ConvertToDouble(xmlNode3("r:buoy-weight").InnerText))
								value.old_force = CDbl(Util.ConvertToDouble(xmlNode3("r:old-force").InnerText))
								value.old_velocity = CDbl(Util.ConvertToDouble(xmlNode3("r:old-velocity").InnerText))
								value.friction_force = CDbl(Util.ConvertToDouble(xmlNode3("r:friction-force").InnerText))
								value.gravity_force = CDbl(Util.ConvertToDouble(xmlNode3("r:gravity-force").InnerText))
								value.pos.x = CDbl(Util.ConvertToDouble(xmlNode3("r:pos-x").InnerText))
								value.pos.y = CDbl(Util.ConvertToDouble(xmlNode3("r:pos-y").InnerText))
								value.pos.z = CDbl(Util.ConvertToDouble(xmlNode3("r:pos-z").InnerText))
								value.tan.x = CDbl(Util.ConvertToDouble(xmlNode3("r:tan-x").InnerText))
								value.tan.y = CDbl(Util.ConvertToDouble(xmlNode3("r:tan-y").InnerText))
								value.tan.z = CDbl(Util.ConvertToDouble(xmlNode3("r:tan-z").InnerText))
								value.nor.x = CDbl(Util.ConvertToDouble(xmlNode3("r:nor-x").InnerText))
								value.nor.y = CDbl(Util.ConvertToDouble(xmlNode3("r:nor-y").InnerText))
								value.nor.z = CDbl(Util.ConvertToDouble(xmlNode3("r:nor-z").InnerText))
								value.sfg.x = CDbl(Util.ConvertToDouble(xmlNode3("r:sfg-x").InnerText))
								value.sfg.y = CDbl(Util.ConvertToDouble(xmlNode3("r:sfg-y").InnerText))
								value.sfg.z = CDbl(Util.ConvertToDouble(xmlNode3("r:sfg-z").InnerText))
								value.max_sf_total = CDbl(Util.ConvertToDouble(xmlNode3("r:max-sf-total").InnerText))
								value.inc = CDbl(Util.ConvertToDouble(xmlNode3("r:inc").InnerText))
								value.azi = CDbl(Util.ConvertToDouble(xmlNode3("r:azi").InnerText))
								Try
									If RSWIN_DESC.rst.gbIncludeBuoyancy Then
										value.max_force = CDbl(Util.ConvertToDouble(xmlNode3("r:max-force").InnerText))
										value.min_force = CDbl(Util.ConvertToDouble(xmlNode3("r:min-force").InnerText))
									Else
										value.max_force_unbuoyed = CDbl(Util.ConvertToDouble(xmlNode3("r:max-force").InnerText))
										value.min_force_unbuoyed = CDbl(Util.ConvertToDouble(xmlNode3("r:min-force").InnerText))
									End If
								Catch ex17 As Exception
								End Try
								value.damp_coef_dn = CDbl(Util.ConvertToDouble(xmlNode3("r:damp-coef-dn").InnerText))
								value.damp_coef_up = CDbl(Util.ConvertToDouble(xmlNode3("r:damp-coef-up").InnerText))
								value.hydrostat_psia_tbg = CDbl(Util.ConvertToDouble(xmlNode3("r:hydrostat-psia-tbg").InnerText))
								value.hydrostat_psia_csg = CDbl(Util.ConvertToDouble(xmlNode3("r:hydrostat-psia-csg").InnerText))
								value.dynamic_psia_tbg = CDbl(Util.ConvertToDouble(xmlNode3("r:dynamic-psia-tbg").InnerText))
								value.dynamic_psia_csg = CDbl(Util.ConvertToDouble(xmlNode3("r:dynamic-psia-csg").InnerText))
								value.buckle_tendency = CDbl(Util.ConvertToDouble(xmlNode3("r:buckle-tendency").InnerText))
								value.rod_area = CDbl(Util.ConvertToDouble(xmlNode3("r:rod-area").InnerText))
								Try
									value.Grade = CInt(Math.Round(CDbl(Util.ConvertToDouble(xmlNode3("r:rod-grade").InnerText))))
								Catch ex18 As Exception
									RSWIN_DESC.rst.gbOutputLoaded = False
									Return True
								End Try
								Try
									impredObj.set_r_e(num + 1, value)
								Catch ex19 As Exception
								End Try
								num += 1
							End While
							Try
								RSWIN_DESC.num_rod_elements = impredObj.num_rod_elements
							Catch ex20 As Exception
							End Try
						Catch ex21 As Exception
						End Try
					End If
					Try
						flag = MRodstarXML.CheckBoolean(xmlNode2.SelectSingleNode("r:xrod-v-output-saved", nsmgr).InnerText)
					Catch ex22 As Exception
						flag = False
					End Try
					If RSWIN_DESC.bRodStarD Then
						Try
							RSWIN_DESC.rst.bImplementedDesign = (Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:implemented-design", nsmgr).InnerText) <> 0F)
						Catch ex23 As Exception
							RSWIN_DESC.rst.bImplementedDesign = False
						End Try
					End If
					xmlNode2 = Nothing
					Application.DoEvents()
					Application.DoEvents()
					If RSWIN_DESC.bExpert And Not flag Then
						RSWIN_DESC.rst.gbOutputLoaded = False
						result = True
					ElseIf RSWIN_DESC.bRodStarD And Not flag2 Then
						RSWIN_DESC.rst.gbOutputLoaded = False
						result = True
					Else
						RSWIN_DESC.rst.gbOutputLoaded = True
						result = True
					End If
				Else
					RSWIN_DESC.rst.gbOutputLoaded = False
					result = True
				End If
			Catch ex24 As Exception
				RSWIN_DESC.rst.gbOutputLoaded = False
				result = True
			End Try
			Return result
		End Function

		Private Function StoreOutputXML(ByRef myWriter As XmlTextWriter) As Boolean
			Dim result As Boolean
			Try
				result = True
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				myWriter.WriteStartElement("r:output")
				Dim text As String = "r:bpd-surface"
				result = MRodstarXML.AddDecimalElement(myWriter, text, CDbl(rst.BPDsurface))
				text = "r:fluid-load"
				result = MRodstarXML.AddDecimalElement(myWriter, text, CDbl(rst.FluidLoad))
				text = "r:fluid-level-tvd"
				result = MRodstarXML.AddDecimalElement(myWriter, text, CDbl(rst.FluidLevelTVD))
				text = "r:fzero-skr"
				result = MRodstarXML.AddDecimalElement(myWriter, text, CDbl(rst.FoSkr))
				text = "r:gross-pump-stroke"
				result = MRodstarXML.AddDecimalElement(myWriter, text, CDbl(rst.GrossPumpStroke))
				text = "r:max-rod-stress-loading"
				result = MRodstarXML.AddDecimalElement(myWriter, text, CDbl(rst.MaxRodStressL))
				text = "r:min-motor-hp"
				result = MRodstarXML.AddDecimalElement(myWriter, text, CDbl(rst.MinMotorHP))
				text = "r:mprload"
				result = MRodstarXML.AddDecimalElement(myWriter, text, CDbl(rst.Mprload))
				text = "r:n-over-nzeroprime"
				result = MRodstarXML.AddDecimalElement(myWriter, text, CDbl(rst.NoverNoP))
				text = "r:ntsteps"
				result = MRodstarXML.AddDecimalElement(myWriter, text, CDbl(rst.Ntsteps))
				text = "r:ntsteps-upstroke"
				result = MRodstarXML.AddDecimalElement(myWriter, text, CDbl(rst.NtstepsUpstroke))
				text = "r:pfill"
				result = MRodstarXML.AddDecimalElement(myWriter, text, CDbl(rst.Pfill))
				text = "r:plunger-length"
				result = MRodstarXML.AddDecimalElement(myWriter, text, CDbl(rst.PlungerLength))
				text = "r:pprload"
				result = MRodstarXML.AddDecimalElement(myWriter, text, CDbl(rst.Pprload))
				text = "r:prhp"
				result = MRodstarXML.AddDecimalElement(myWriter, text, CDbl(rst.Prhp))
				text = "r:plhp"
				result = MRodstarXML.AddDecimalElement(myWriter, text, CDbl(rst.Plhp))
				text = "r:production-loss"
				result = MRodstarXML.AddDecimalElement(myWriter, text, CDbl(rst.ProductionLoss))
				text = "r:pump-length"
				result = MRodstarXML.AddDecimalElement(myWriter, text, CDbl(rst.PumpLength))
				text = "r:pump-spacing"
				result = MRodstarXML.AddDecimalElement(myWriter, text, CDbl(rst.PumpSpacing))
				text = "r:structure-loading"
				result = MRodstarXML.AddDecimalElement(myWriter, text, CDbl(rst.StructL))
				text = "r:system-eff"
				result = MRodstarXML.AddDecimalElement(myWriter, text, CDbl(rst.SystemEff))
				text = "r:tubing-stretch"
				result = MRodstarXML.AddDecimalElement(myWriter, text, CDbl(rst.TubStretch))
				text = "r:wrods-in-fluid"
				result = MRodstarXML.AddDecimalElement(myWriter, text, CDbl(rst.WrodsInFluid))
				result = MRodstarXML.AddCbeffectAt90Deg(myWriter)
				result = MRodstarXML.AddCyclicLoadFactor(myWriter)
				result = MRodstarXML.AddCostPerBblFluid(myWriter)
				result = MRodstarXML.AddCostPerBblOil(myWriter)
				result = MRodstarXML.AddMonthlyElectricBill(myWriter)
				result = MRodstarXML.AddGearboxLoading(myWriter)
				result = MRodstarXML.AddHpNemaD(myWriter)
				result = MRodstarXML.AddHpUHS(myWriter)
				If RSWIN_DESC.rst.PU.UnitType = 8S Or (RSWIN_DESC.rst.PU.UnitType = 11S And Not RSWIN_DESC.rst.bUseCrankBalancedCalcs) Then
					result = MRodstarXML.AddRequiredStructuralUnbalance(myWriter)
				Else
					result = MRodstarXML.AddMaximumCounterbalance(myWriter)
				End If
				result = MRodstarXML.AddMotorKwh(myWriter)
				result = MRodstarXML.AddPeakTorque(myWriter)
				result = MRodstarXML.AddNetTorque(myWriter)
				result = MRodstarXML.AddCalculatedRodTapers(myWriter)
				result = MRodstarXML.AddPredictedDyno(myWriter)
				result = MRodstarXML.AddRodElementData(myWriter)
				If RSWIN_DESC.bExpert Then
					text = "r:xrod-v-output-saved"
					result = MRodstarXML.AddDecimalElement(myWriter, text, -1.0)
				End If
				If RSWIN_DESC.bRodStarD Then
					text = "r:rodstard-new-calcs"
					result = MRodstarXML.AddDecimalElement(myWriter, text, -1.0)
					text = "r:implemented-design"
					result = MRodstarXML.AddDecimalElement(myWriter, text, -(RSWIN_DESC.rst.bImplementedDesign > False))
				End If
				Try
					myWriter.WriteEndElement()
				Catch ex As Exception
				End Try
			Catch ex2 As Exception
				result = False
			End Try
			Return result
		End Function

		Private Function AddPredictedDyno(ByRef myWriter As XmlTextWriter) As Boolean
			Dim result As Boolean = True
			Try
				Dim xmlTextWriter As XmlTextWriter = myWriter
				xmlTextWriter.WriteStartElement("r:predicted-dynamometer-card")
				Dim num As Integer = 0
				Dim num2 As Integer = CInt((RSWIN_DESC.rst.Ntsteps - 1S))
				For i As Integer = num To num2
					xmlTextWriter.WriteStartElement("r:predicted-dynamometer-card-point")
					xmlTextWriter.WriteAttributeString("Order", i.ToString())
					Dim text As String = "r:surface-load"
					result = MRodstarXML.AddDecimalElement(myWriter, text, CDbl(RSWIN_DESC.rst.SurfLoad(i)))
					text = "r:surface-position"
					result = MRodstarXML.AddDecimalElement(myWriter, text, CDbl(RSWIN_DESC.rst.SurfPos(i)))
					text = "r:pump-load"
					result = MRodstarXML.AddDecimalElement(myWriter, text, CDbl(RSWIN_DESC.rst.PumpLoad(i)))
					text = "r:pump-position"
					result = MRodstarXML.AddDecimalElement(myWriter, text, CDbl(RSWIN_DESC.rst.PumpPos(i)))
					text = "r:permissible-load"
					result = MRodstarXML.AddDecimalElement(myWriter, text, CDbl(RSWIN_DESC.rst.PermLoad(i)))
					text = "r:thetac"
					result = MRodstarXML.AddDecimalElement(myWriter, text, CDbl(RSWIN_DESC.rst.Thetac(i)))
					text = "r:torque-factor"
					result = MRodstarXML.AddDecimalElement(myWriter, text, CDbl(RSWIN_DESC.rst.Tf(i)))
					xmlTextWriter.WriteEndElement()
				Next
				xmlTextWriter.WriteEndElement()
			Catch ex As Exception
				result = False
			End Try
			Return result
		End Function

		Private Function AddPeakTorque(ByRef myWriter As XmlTextWriter) As Boolean
			Dim result As Boolean = True
			Try
				Dim xmlTextWriter As XmlTextWriter = myWriter
				xmlTextWriter.WriteStartElement("r:peak-gearbox-torque")
				Dim text As String = "r:existing"
				result = MRodstarXML.AddDecimalElement(myWriter, text, CDbl(RSWIN_DESC.rst.PeakTorque(2)))
				text = "r:min-energy"
				result = MRodstarXML.AddDecimalElement(myWriter, text, CDbl(RSWIN_DESC.rst.PeakTorque(0)))
				text = "r:min-torque"
				result = MRodstarXML.AddDecimalElement(myWriter, text, CDbl(RSWIN_DESC.rst.PeakTorque(1)))
				myWriter.WriteEndElement()
			Catch ex As Exception
				result = False
			End Try
			Return result
		End Function

		Private Function AddMonthlyElectricBill(ByRef myWriter As XmlTextWriter) As Boolean
			Dim result As Boolean = True
			Try
				Dim xmlTextWriter As XmlTextWriter = myWriter
				xmlTextWriter.WriteStartElement("r:monthly-electric-bill")
				Dim text As String = "r:existing"
				result = MRodstarXML.AddDecimalElement(myWriter, text, CDbl(RSWIN_DESC.rst.get_ElectricBillperMonth(2)))
				text = "r:min-energy"
				result = MRodstarXML.AddDecimalElement(myWriter, text, CDbl(RSWIN_DESC.rst.get_ElectricBillperMonth(0)))
				text = "r:min-torque"
				result = MRodstarXML.AddDecimalElement(myWriter, text, CDbl(RSWIN_DESC.rst.get_ElectricBillperMonth(1)))
				myWriter.WriteEndElement()
			Catch ex As Exception
				result = False
			End Try
			Return result
		End Function

		Private Function AddMotorKwh(ByRef myWriter As XmlTextWriter) As Boolean
			Dim result As Boolean = True
			Try
				Dim xmlTextWriter As XmlTextWriter = myWriter
				xmlTextWriter.WriteStartElement("r:motor-kwh")
				Dim text As String = "r:existing"
				result = MRodstarXML.AddDecimalElement(myWriter, text, CDbl(RSWIN_DESC.rst.MotorKWH(2)))
				text = "r:min-energy"
				result = MRodstarXML.AddDecimalElement(myWriter, text, CDbl(RSWIN_DESC.rst.MotorKWH(0)))
				text = "r:min-torque"
				result = MRodstarXML.AddDecimalElement(myWriter, text, CDbl(RSWIN_DESC.rst.MotorKWH(1)))
				myWriter.WriteEndElement()
			Catch ex As Exception
				result = False
			End Try
			Return result
		End Function

		Private Function AddRequiredStructuralUnbalance(ByRef myWriter As XmlTextWriter) As Boolean
			Dim result As Boolean = True
			Try
				Dim xmlTextWriter As XmlTextWriter = myWriter
				xmlTextWriter.WriteStartElement("r:required-unbalance")
				Dim text As String = "r:existing"
				result = MRodstarXML.AddDecimalElement(myWriter, text, CDbl(RSWIN_DESC.rst.get_RequiredUnbalance(2)))
				text = "r:min-energy"
				result = MRodstarXML.AddDecimalElement(myWriter, text, CDbl(RSWIN_DESC.rst.get_RequiredUnbalance(0)))
				text = "r:min-torque"
				result = MRodstarXML.AddDecimalElement(myWriter, text, CDbl(RSWIN_DESC.rst.get_RequiredUnbalance(1)))
				myWriter.WriteEndElement()
			Catch ex As Exception
				result = False
			End Try
			Return result
		End Function

		Private Function AddMaximumCounterbalance(ByRef myWriter As XmlTextWriter) As Boolean
			Dim result As Boolean = True
			Try
				Dim xmlTextWriter As XmlTextWriter = myWriter
				xmlTextWriter.WriteStartElement("r:maximum-counterbalance")
				Dim text As String = "r:existing"
				result = MRodstarXML.AddDecimalElement(myWriter, text, CDbl(RSWIN_DESC.rst.get_M(2)))
				text = "r:min-energy"
				result = MRodstarXML.AddDecimalElement(myWriter, text, CDbl(RSWIN_DESC.rst.get_M(0)))
				text = "r:min-torque"
				result = MRodstarXML.AddDecimalElement(myWriter, text, CDbl(RSWIN_DESC.rst.get_M(1)))
				myWriter.WriteEndElement()
			Catch ex As Exception
				result = False
			End Try
			Return result
		End Function

		Private Function AddHpUHS(ByRef myWriter As XmlTextWriter) As Boolean
			Dim result As Boolean = True
			Try
				Dim xmlTextWriter As XmlTextWriter = myWriter
				xmlTextWriter.WriteStartElement("r:hp-uhs")
				Dim text As String = "r:existing"
				result = MRodstarXML.AddDecimalElement(myWriter, text, CDbl(RSWIN_DESC.rst.HpUhs(2)))
				text = "r:min-energy"
				result = MRodstarXML.AddDecimalElement(myWriter, text, CDbl(RSWIN_DESC.rst.HpUhs(0)))
				text = "r:min-torque"
				result = MRodstarXML.AddDecimalElement(myWriter, text, CDbl(RSWIN_DESC.rst.HpUhs(1)))
				myWriter.WriteEndElement()
			Catch ex As Exception
				result = False
			End Try
			Return result
		End Function

		Private Function AddHpNemaD(ByRef myWriter As XmlTextWriter) As Boolean
			Dim result As Boolean = True
			Try
				Dim xmlTextWriter As XmlTextWriter = myWriter
				xmlTextWriter.WriteStartElement("r:hp-nema-d")
				Dim text As String = "r:existing"
				result = MRodstarXML.AddDecimalElement(myWriter, text, CDbl(RSWIN_DESC.rst.HpNemaD(2)))
				text = "r:min-energy"
				result = MRodstarXML.AddDecimalElement(myWriter, text, CDbl(RSWIN_DESC.rst.HpNemaD(0)))
				text = "r:min-torque"
				result = MRodstarXML.AddDecimalElement(myWriter, text, CDbl(RSWIN_DESC.rst.HpNemaD(1)))
				myWriter.WriteEndElement()
			Catch ex As Exception
				result = False
			End Try
			Return result
		End Function

		Private Function AddGearboxLoading(ByRef myWriter As XmlTextWriter) As Boolean
			Dim result As Boolean = True
			Try
				Dim xmlTextWriter As XmlTextWriter = myWriter
				xmlTextWriter.WriteStartElement("r:gearbox-loading")
				Dim text As String = "r:existing"
				result = MRodstarXML.AddDecimalElement(myWriter, text, CDbl(RSWIN_DESC.rst.GearboxLoading(2)))
				text = "r:min-energy"
				result = MRodstarXML.AddDecimalElement(myWriter, text, CDbl(RSWIN_DESC.rst.GearboxLoading(0)))
				text = "r:min-torque"
				result = MRodstarXML.AddDecimalElement(myWriter, text, CDbl(RSWIN_DESC.rst.GearboxLoading(1)))
				myWriter.WriteEndElement()
			Catch ex As Exception
				result = False
			End Try
			Return result
		End Function

		Private Function AddCyclicLoadFactor(ByRef myWriter As XmlTextWriter) As Boolean
			Dim result As Boolean = True
			Try
				Dim xmlTextWriter As XmlTextWriter = myWriter
				xmlTextWriter.WriteStartElement("r:cyclic-load-factor")
				Dim text As String = "r:existing"
				result = MRodstarXML.AddDecimalElement(myWriter, text, CDbl(RSWIN_DESC.rst.Clf(2)))
				text = "r:min-energy"
				result = MRodstarXML.AddDecimalElement(myWriter, text, CDbl(RSWIN_DESC.rst.Clf(0)))
				text = "r:min-torque"
				result = MRodstarXML.AddDecimalElement(myWriter, text, CDbl(RSWIN_DESC.rst.Clf(1)))
				myWriter.WriteEndElement()
			Catch ex As Exception
				result = False
			End Try
			Return result
		End Function

		Private Function AddCostPerBblOil(ByRef myWriter As XmlTextWriter) As Boolean
			Dim result As Boolean = True
			Try
				Dim xmlTextWriter As XmlTextWriter = myWriter
				xmlTextWriter.WriteStartElement("r:cost-per-bbl-oil")
				Dim text As String = "r:existing"
				result = MRodstarXML.AddDecimalElement(myWriter, text, CDbl(RSWIN_DESC.rst.DollarsPerBblOil(2)))
				text = "r:min-energy"
				result = MRodstarXML.AddDecimalElement(myWriter, text, CDbl(RSWIN_DESC.rst.DollarsPerBblOil(0)))
				text = "r:min-torque"
				result = MRodstarXML.AddDecimalElement(myWriter, text, CDbl(RSWIN_DESC.rst.DollarsPerBblOil(1)))
				myWriter.WriteEndElement()
			Catch ex As Exception
				result = False
			End Try
			Return result
		End Function

		Private Function AddCostPerBblFluid(ByRef myWriter As XmlTextWriter) As Boolean
			Dim result As Boolean = True
			Try
				Dim xmlTextWriter As XmlTextWriter = myWriter
				xmlTextWriter.WriteStartElement("r:cost-per-bbl-fluid")
				Dim text As String = "r:existing"
				result = MRodstarXML.AddDecimalElement(myWriter, text, CDbl(RSWIN_DESC.rst.DollarsPerBblFluid(2)))
				text = "r:min-energy"
				result = MRodstarXML.AddDecimalElement(myWriter, text, CDbl(RSWIN_DESC.rst.DollarsPerBblFluid(0)))
				text = "r:min-torque"
				result = MRodstarXML.AddDecimalElement(myWriter, text, CDbl(RSWIN_DESC.rst.DollarsPerBblFluid(1)))
				myWriter.WriteEndElement()
			Catch ex As Exception
				result = False
			End Try
			Return result
		End Function

		Private Function AddCbeffectAt90Deg(ByRef myWriter As XmlTextWriter) As Boolean
			Dim result As Boolean = True
			Try
				Dim xmlTextWriter As XmlTextWriter = myWriter
				xmlTextWriter.WriteStartElement("r:cbeffect-at-90-deg")
				Dim text As String = "r:existing"
				MRodstarXML.AddDecimalElement(myWriter, text, CDbl(RSWIN_DESC.rst.CBE90(2)))
				text = "r:min-energy"
				MRodstarXML.AddDecimalElement(myWriter, text, CDbl(RSWIN_DESC.rst.CBE90(0)))
				text = "r:min-torque"
				MRodstarXML.AddDecimalElement(myWriter, text, CDbl(RSWIN_DESC.rst.CBE90(1)))
				myWriter.WriteEndElement()
			Catch ex As Exception
				result = False
			End Try
			Return result
		End Function

		Private Function AddNetTorque(ByRef myWriter As XmlTextWriter) As Boolean
			Dim result As Boolean = True
			Try
				Dim xmlTextWriter As XmlTextWriter = myWriter
				xmlTextWriter.WriteStartElement("r:net-torque")
				Dim num As Integer = 0
				Dim num2 As Integer = CInt((RSWIN_DESC.rst.Ntsteps - 1S))
				For i As Integer = num To num2
					xmlTextWriter.WriteStartElement("r:net-torque-point")
					xmlTextWriter.WriteAttributeString("Order", i.ToString())
					Dim text As String = "r:existing"
					result = MRodstarXML.AddDecimalElement(myWriter, text, CDbl(RSWIN_DESC.rst.Tnet(2, i)))
					text = "r:min-energy"
					result = MRodstarXML.AddDecimalElement(myWriter, text, CDbl(RSWIN_DESC.rst.Tnet(0, i)))
					text = "r:min-torque"
					result = MRodstarXML.AddDecimalElement(myWriter, text, CDbl(RSWIN_DESC.rst.Tnet(1, i)))
					xmlTextWriter.WriteEndElement()
				Next
				xmlTextWriter.WriteEndElement()
			Catch ex As Exception
				result = False
			End Try
			Return result
		End Function

		Private Function AddRodElementData(ByRef myWriter As XmlTextWriter) As Boolean
			Dim result As Boolean = True
			Dim impredObj As TEImpred = MImpred.ImpredObj
			Try
				Dim xmlTextWriter As XmlTextWriter = myWriter
				If RSWIN_DESC.mdsDeviationProfile Is Nothing Then
					Dim text As String = "r:rod-element-data"
					MRodstarXML.AddNilElement(myWriter, text)
				Else
					xmlTextWriter.WriteStartElement("r:rod-element-data")
					Dim num As Integer = 0
					Dim num2 As Integer = impredObj.num_rod_elements - 1
					For i As Integer = num To num2
						xmlTextWriter.WriteStartElement("r:rod-element-data-point")
						xmlTextWriter.WriteAttributeString("Order", i.ToString())
						Dim text As String = "r:m-d"
						Dim rod_element_data_type As TEImpred.rod_element_data_type = impredObj.get_r_e(i + 1)
						result = MRodstarXML.AddDecimalElement(myWriter, text, rod_element_data_type.m_d)
						text = "r:dog"
						rod_element_data_type = impredObj.get_r_e(i + 1)
						result = MRodstarXML.AddDecimalElement(myWriter, text, rod_element_data_type.dog)
						text = "r:rad"
						rod_element_data_type = impredObj.get_r_e(i + 1)
						result = MRodstarXML.AddDecimalElement(myWriter, text, rod_element_data_type.rad)
						text = "r:ea"
						rod_element_data_type = impredObj.get_r_e(i + 1)
						result = MRodstarXML.AddDecimalElement(myWriter, text, rod_element_data_type.ea)
						text = "r:friction-coef"
						rod_element_data_type = impredObj.get_r_e(i + 1)
						result = MRodstarXML.AddDecimalElement(myWriter, text, rod_element_data_type.friction_coef)
						text = "r:mass"
						rod_element_data_type = impredObj.get_r_e(i + 1)
						result = MRodstarXML.AddDecimalElement(myWriter, text, rod_element_data_type.mass)
						text = "r:buoy-weight"
						rod_element_data_type = impredObj.get_r_e(i + 1)
						result = MRodstarXML.AddDecimalElement(myWriter, text, rod_element_data_type.buoy_weight)
						text = "r:old-force"
						rod_element_data_type = impredObj.get_r_e(i + 1)
						result = MRodstarXML.AddDecimalElement(myWriter, text, rod_element_data_type.old_force)
						text = "r:old-velocity"
						rod_element_data_type = impredObj.get_r_e(i + 1)
						result = MRodstarXML.AddDecimalElement(myWriter, text, rod_element_data_type.old_velocity)
						text = "r:friction-force"
						rod_element_data_type = impredObj.get_r_e(i + 1)
						result = MRodstarXML.AddDecimalElement(myWriter, text, rod_element_data_type.friction_force)
						text = "r:gravity-force"
						rod_element_data_type = impredObj.get_r_e(i + 1)
						result = MRodstarXML.AddDecimalElement(myWriter, text, rod_element_data_type.gravity_force)
						text = "r:pos-x"
						rod_element_data_type = impredObj.get_r_e(i + 1)
						result = MRodstarXML.AddDecimalElement(myWriter, text, rod_element_data_type.pos.x)
						text = "r:pos-y"
						rod_element_data_type = impredObj.get_r_e(i + 1)
						result = MRodstarXML.AddDecimalElement(myWriter, text, rod_element_data_type.pos.y)
						text = "r:pos-z"
						rod_element_data_type = impredObj.get_r_e(i + 1)
						result = MRodstarXML.AddDecimalElement(myWriter, text, rod_element_data_type.pos.z)
						text = "r:tan-x"
						rod_element_data_type = impredObj.get_r_e(i + 1)
						result = MRodstarXML.AddDecimalElement(myWriter, text, rod_element_data_type.tan.x)
						text = "r:tan-y"
						rod_element_data_type = impredObj.get_r_e(i + 1)
						result = MRodstarXML.AddDecimalElement(myWriter, text, rod_element_data_type.tan.y)
						text = "r:tan-z"
						rod_element_data_type = impredObj.get_r_e(i + 1)
						result = MRodstarXML.AddDecimalElement(myWriter, text, rod_element_data_type.tan.z)
						text = "r:nor-x"
						rod_element_data_type = impredObj.get_r_e(i + 1)
						result = MRodstarXML.AddDecimalElement(myWriter, text, rod_element_data_type.nor.x)
						text = "r:nor-y"
						rod_element_data_type = impredObj.get_r_e(i + 1)
						result = MRodstarXML.AddDecimalElement(myWriter, text, rod_element_data_type.nor.y)
						text = "r:nor-z"
						rod_element_data_type = impredObj.get_r_e(i + 1)
						result = MRodstarXML.AddDecimalElement(myWriter, text, rod_element_data_type.nor.z)
						text = "r:sfg-x"
						rod_element_data_type = impredObj.get_r_e(i + 1)
						result = MRodstarXML.AddDecimalElement(myWriter, text, rod_element_data_type.sfg.x)
						text = "r:sfg-y"
						rod_element_data_type = impredObj.get_r_e(i + 1)
						result = MRodstarXML.AddDecimalElement(myWriter, text, rod_element_data_type.sfg.y)
						text = "r:sfg-z"
						rod_element_data_type = impredObj.get_r_e(i + 1)
						result = MRodstarXML.AddDecimalElement(myWriter, text, rod_element_data_type.sfg.z)
						text = "r:max-sf-total"
						rod_element_data_type = impredObj.get_r_e(i + 1)
						result = MRodstarXML.AddDecimalElement(myWriter, text, rod_element_data_type.max_sf_total)
						text = "r:inc"
						rod_element_data_type = impredObj.get_r_e(i + 1)
						result = MRodstarXML.AddDecimalElement(myWriter, text, rod_element_data_type.inc)
						text = "r:azi"
						rod_element_data_type = impredObj.get_r_e(i + 1)
						result = MRodstarXML.AddDecimalElement(myWriter, text, rod_element_data_type.azi)
						If RSWIN_DESC.rst.gbIncludeBuoyancy Then
							text = "r:max-force"
							rod_element_data_type = impredObj.get_r_e(i + 1)
							result = MRodstarXML.AddDecimalElement(myWriter, text, rod_element_data_type.max_force)
							text = "r:min-force"
							rod_element_data_type = impredObj.get_r_e(i + 1)
							result = MRodstarXML.AddDecimalElement(myWriter, text, rod_element_data_type.min_force)
						Else
							text = "r:max-force"
							rod_element_data_type = impredObj.get_r_e(i + 1)
							result = MRodstarXML.AddDecimalElement(myWriter, text, rod_element_data_type.max_force_unbuoyed)
							text = "r:min-force"
							rod_element_data_type = impredObj.get_r_e(i + 1)
							result = MRodstarXML.AddDecimalElement(myWriter, text, rod_element_data_type.min_force_unbuoyed)
						End If
						text = "r:damp-coef-dn"
						rod_element_data_type = impredObj.get_r_e(i + 1)
						result = MRodstarXML.AddDecimalElement(myWriter, text, rod_element_data_type.damp_coef_dn)
						text = "r:damp-coef-up"
						rod_element_data_type = impredObj.get_r_e(i + 1)
						result = MRodstarXML.AddDecimalElement(myWriter, text, rod_element_data_type.damp_coef_up)
						text = "r:hydrostat-psia-tbg"
						rod_element_data_type = impredObj.get_r_e(i + 1)
						result = MRodstarXML.AddDecimalElement(myWriter, text, rod_element_data_type.hydrostat_psia_tbg)
						text = "r:hydrostat-psia-csg"
						rod_element_data_type = impredObj.get_r_e(i + 1)
						result = MRodstarXML.AddDecimalElement(myWriter, text, rod_element_data_type.hydrostat_psia_csg)
						text = "r:dynamic-psia-tbg"
						rod_element_data_type = impredObj.get_r_e(i + 1)
						result = MRodstarXML.AddDecimalElement(myWriter, text, rod_element_data_type.dynamic_psia_tbg)
						text = "r:dynamic-psia-csg"
						rod_element_data_type = impredObj.get_r_e(i + 1)
						result = MRodstarXML.AddDecimalElement(myWriter, text, rod_element_data_type.dynamic_psia_csg)
						text = "r:buckle-tendency"
						rod_element_data_type = impredObj.get_r_e(i + 1)
						result = MRodstarXML.AddDecimalElement(myWriter, text, rod_element_data_type.buckle_tendency)
						text = "r:rod-area"
						rod_element_data_type = impredObj.get_r_e(i + 1)
						result = MRodstarXML.AddDecimalElement(myWriter, text, rod_element_data_type.rod_area)
						text = "r:rod-grade"
						rod_element_data_type = impredObj.get_r_e(i + 1)
						result = MRodstarXML.AddDecimalElement(myWriter, text, CDbl(rod_element_data_type.Grade))
						xmlTextWriter.WriteEndElement()
					Next
				End If
				xmlTextWriter.WriteEndElement()
			Catch ex As Exception
				result = False
			End Try
			Return result
		End Function

		Private Sub LoadLookupRodGrade()
			Dim arrayList As ArrayList = New ArrayList()
			Try
				MRodstarXML.new_mnLookupRodGrade = New Collection()
				arrayList.Clear()
				Dim num As Integer = 1
				Do
					Dim obj As Object
					Select Case num
						Case 0, 1
							obj = StdInfoConstants.RodMatlConstants.teRodMatlAPISteel
						Case 2
							obj = StdInfoConstants.RodMatlConstants.teRodMatlSinkerBar
						Case 3
							obj = StdInfoConstants.RodMatlConstants.teRodMatlCorod
						Case 4
							obj = StdInfoConstants.RodMatlConstants.teRodMatlFG
						Case 5
							obj = StdInfoConstants.RodMatlConstants.teRodMatlRR
						Case 6
							obj = StdInfoConstants.RodMatlConstants.teRodMatlProrod
					End Select
					Dim teRodGradeList As teRodGradeList = RSWIN_DESC.ThetaStdInfoGThetaStdInfo_definst.RodGradeDB().RodGradeLists().Item(RuntimeHelpers.GetObjectValue(obj))
					Try
						For Each obj2 As Object In teRodGradeList
							Dim dictionaryEntry As DictionaryEntry
							Dim teRodGrade As teRodGrade = CType(If((obj2 IsNot Nothing), CType(obj2, DictionaryEntry), dictionaryEntry).Value, teRodGrade)
							If Not(LikeOperator.LikeString(teRodGrade.Name, "(Custom *)", CompareMethod.Binary) Or LikeOperator.LikeString(teRodGrade.Name, "(Unknown *)", CompareMethod.Binary)) And Not(Operators.CompareString(teRodGrade.Name, RSWIN_DESC.s_Steel, False) = 0 Or Operators.CompareString(teRodGrade.Name, RSWIN_DESC.s_SinkerBars, False) = 0 Or Operators.CompareString(teRodGrade.Name, RSWIN_DESC.s_Corod, False) = 0 Or Operators.CompareString(teRodGrade.Name, RSWIN_DESC.s_Fiberglass, False) = 0 Or Operators.CompareString(teRodGrade.Name, RSWIN_DESC.s_RibbonRod, False) = 0 Or Operators.CompareString(teRodGrade.Name, RSWIN_DESC.s_Prorod, False) = 0) Then
								Try
									RODUTIL.AddToArrayList(True, arrayList, CInt(teRodGrade.RodGradeID), teRodGrade.Name, Conversions.ToInteger(teRodGrade.DisplayOrder), teRodGrade.AbbrName, teRodGrade.XMLstring)
								Catch ex As Exception
								End Try
							End If
						Next
					Finally
						Dim enumerator As IEnumerator
						If TypeOf enumerator Is IDisposable Then
							TryCast(enumerator, IDisposable).Dispose()
						End If
					End Try
					num += 1
				Loop While num <= 6
				Dim comparer As RODUTIL.rgaComparer = New RODUTIL.rgaComparer()
				arrayList.Sort(comparer)
				Dim enumerator2 As IEnumerator = arrayList.GetEnumerator()
				Try
					While enumerator2.MoveNext()
						Dim obj3 As Object = enumerator2.Current
						Dim cRodGrade As cRodGrade = CType(obj3, cRodGrade)
						MRodstarXML.new_mnLookupRodGrade.Add(cRodGrade.RodGradeID, cRodGrade.XMLstring, Nothing, Nothing)
						MRodstarXML.new_mnLookupRodGrade.Add(cRodGrade.XMLstring, "#" + Conversions.ToString(cRodGrade.RodGradeID), Nothing, Nothing)
					End While
				Catch ex2 As Exception
				End Try
			Catch ex3 As Exception
			End Try
		End Sub

		Private Sub AddAIPreferences(ByRef XmlWriter As XmlTextWriter)
			' The following expression was wrapped in a checked-statement
			Try
				XmlWriter.WriteStartElement("r:ai-preferences")
				Dim text As String = "r:fg-rod-grade"
				MRodstarXML.AddIntegerElement(XmlWriter, text, CInt(RSWIN_DESC.AIFilePreferences.FGGradeRod))
				text = "r:hs-rod-grade"
				MRodstarXML.AddIntegerElement(XmlWriter, text, CInt(RSWIN_DESC.AIFilePreferences.HSGradeRod))
				text = "r:sb-rod-grade"
				MRodstarXML.AddIntegerElement(XmlWriter, text, CInt(RSWIN_DESC.AIFilePreferences.SBGradeRod))
				text = "r:use-customized-lists"
				Dim flag As Boolean = MRodstarXML.AddBooleanElement(XmlWriter, text, RSWIN_DESC.AIFilePreferences.bXRODUseCustomizedLists)
				text = "r:use-general-list"
				flag = MRodstarXML.AddBooleanElement(XmlWriter, text, RSWIN_DESC.AIFilePreferences.bXRODUseGeneralList)
				text = "r:use-closest-unit"
				flag = MRodstarXML.AddBooleanElement(XmlWriter, text, RSWIN_DESC.AIFilePreferences.bXRODUseClosestUnit)
				Try
					text = "r:use-xrodv-tubing-sizes"
					flag = MRodstarXML.AddBooleanElement(XmlWriter, text, RSWIN_DESC.AIFilePreferences.bUseXRODVTubingSizes)
				Catch ex As Exception
					RSWIN_DESC.AIFilePreferences.bUseXRODVTubingSizes = True
				End Try
				Try
					If RSWIN_DESC.AIFilePreferences.fTubingSizeOD <> 0F Then
						text = "r:tubing-od-size"
						flag = MRodstarXML.AddDecimalElement(XmlWriter, text, CDbl(RSWIN_DESC.AIFilePreferences.fTubingSizeOD))
					End If
				Catch ex2 As Exception
				End Try
				Try
					If RSWIN_DESC.AIFilePreferences.fCasingSize <> 0F Then
						text = "r:casing-size"
						flag = MRodstarXML.AddDecimalElement(XmlWriter, text, CDbl(RSWIN_DESC.AIFilePreferences.fCasingSize))
					End If
				Catch ex3 As Exception
				End Try
				Try
					text = "r:fix-tubing-size"
					flag = MRodstarXML.AddBooleanElement(XmlWriter, text, RSWIN_DESC.AIFilePreferences.bFixTubingSize)
				Catch ex4 As Exception
					RSWIN_DESC.AIFilePreferences.bFixTubingSize = False
				End Try
				text = "r:use-steel-rods-only"
				flag = MRodstarXML.AddBooleanElement(XmlWriter, text, RSWIN_DESC.AIFilePreferences.bUseSteelRodsOnly)
				text = "r:use-fglass-with-steel-on-bottom"
				flag = MRodstarXML.AddBooleanElement(XmlWriter, text, RSWIN_DESC.AIFilePreferences.bUseFGlassWithSteelOnBottom)
				text = "r:use-avg-rod-tbg-fric-coeff"
				flag = MRodstarXML.AddBooleanElement(XmlWriter, text, RSWIN_DESC.AIFilePreferences.bUseAvgRodTBGFricCoeff)
				text = "r:times-avg-rod-tbg-fric-coeff"
				flag = MRodstarXML.AddDecimalElement(XmlWriter, text, CDbl(RSWIN_DESC.AIFilePreferences.TimesAvgRodTBGFricCoeff))
				text = "r:service-factor-pref"
				flag = MRodstarXML.AddDecimalElement(XmlWriter, text, CDbl(RSWIN_DESC.AIFilePreferences.ServiceFactorPreference))
				text = "r:electricity-cost-pref"
				flag = MRodstarXML.AddDecimalElement(XmlWriter, text, CDbl(RSWIN_DESC.AIFilePreferences.ElectricityCostPreference))
				text = "r:power-meter-type-pref"
				MRodstarXML.AddIntegerElement(XmlWriter, text, CInt(RSWIN_DESC.AIFilePreferences.PowerMeterType))
				text = "r:include-motor-spv-pref"
				flag = MRodstarXML.AddBooleanElement(XmlWriter, text, RSWIN_DESC.AIFilePreferences.IncludeMotorSPV)
				Dim num As Integer = 1
				Do
					text = "r:use-pumanuf-preference-" + num.ToString().Trim()
					flag = MRodstarXML.AddBooleanElement(XmlWriter, text, RSWIN_DESC.get_bUsePUManuf(num))
					text = "r:pumanuf-preference-" + num.ToString().Trim()
					Dim index As Integer = num
					Dim value As String = RSWIN_DESC.get_PUManuf(index)
					MRodstarXML.AddStringElement(XmlWriter, text, value, False)
					RSWIN_DESC.set_PUManuf(index, value)
					num += 1
				Loop While num <= 8
				XmlWriter.WriteEndElement()
			Catch ex5 As Exception
			End Try
		End Sub

		Public Sub SetAIFilePreferencesFromSetup(bLoad As Boolean)
			' The following expression was wrapped in a checked-statement
			Try
				If bLoad Then
					RSWIN.LoadExpertPreferences()
				End If
				RSWIN_DESC.AIFilePreferences.Initialize()
				RSWIN_DESC.AIFilePreferences.FGGradeRod = RSWIN_DESC.FGGradeRod
				RSWIN_DESC.AIFilePreferences.FGRodType = RODUTIL.RodGrade(RSWIN_DESC.FGGradeRod)
				RSWIN_DESC.AIFilePreferences.HSGradeRod = RSWIN_DESC.HSGradeRod
				RSWIN_DESC.AIFilePreferences.HSRodType = RODUTIL.RodGrade(RSWIN_DESC.HSGradeRod)
				RSWIN_DESC.AIFilePreferences.SBGradeRod = RSWIN_DESC.SBGradeRod
				RSWIN_DESC.AIFilePreferences.SBRodType = RODUTIL.RodGrade(RSWIN_DESC.SBGradeRod)
				RSWIN_DESC.bDesignSinkerbar = True
				RSWIN_DESC.AIFilePreferences.bXRODUseCustomizedLists = RSWIN_DESC.bXRODUseCustomizedLists
				RSWIN_DESC.AIFilePreferences.bXRODUseGeneralList = RSWIN_DESC.bXRODUseGeneralList
				RSWIN_DESC.AIFilePreferences.bXRODUseClosestUnit = RSWIN_DESC.bXRODUseClosestUnit
				RSWIN_DESC.AIFilePreferences.bUseXRODVTubingSizes = RSWIN_DESC.SETUP_UseXRODVTubingSizes
				RSWIN_DESC.AIFilePreferences.fTubingSizeOD = RSWIN_DESC.MaxTubingSizeOD
				RSWIN_DESC.AIFilePreferences.fCasingSize = RSWIN_DESC.MaxCasingSize
				RSWIN_DESC.AIFilePreferences.bFixTubingSize = RSWIN_DESC.SETUP_FixTubingSize
				RSWIN_DESC.AIFilePreferences.bUseSteelRodsOnly = RSWIN_DESC.SETUP_bUseSteelRodsOnly
				RSWIN_DESC.AIFilePreferences.bUseFGlassWithSteelOnBottom = RSWIN_DESC.SETUP_bUseFGlassWithSteelOnBottom
				RSWIN_DESC.AIFilePreferences.bUseAvgRodTBGFricCoeff = RSWIN_DESC.SETUP_bUseAvgRodTBGFricCoeff
				If RSWIN_DESC.SETUP_bUseAvgRodTBGFricCoeff Then
					RSWIN_DESC.AIFilePreferences.TimesAvgRodTBGFricCoeff = 1F
				Else
					RSWIN_DESC.AIFilePreferences.TimesAvgRodTBGFricCoeff = RSWIN_DESC.SETUP_TimesAvgRodTBGFricCoeff
				End If
				RSWIN_DESC.AIFilePreferences.ServiceFactorPreference = RSWIN_DESC.SETUP_ServiceFactorPreference
				RSWIN_DESC.AIFilePreferences.ElectricityCostPreference = RSWIN_DESC.SETUP_ElectricityCostPreference
				RSWIN_DESC.AIFilePreferences.PowerMeterType = RSWIN_DESC.SETUP_PowerMeterType
				RSWIN_DESC.AIFilePreferences.IncludeMotorSPV = RSWIN_DESC.SETUP_IncludeMotorSPV
				Dim num As Integer = 1
				Do
					RSWIN_DESC.AIFilePreferences.bUsePUManuf(num) = RSWIN_DESC.get_bUsePUManuf(num)
					RSWIN_DESC.AIFilePreferences.PUManuf(num) = RSWIN_DESC.get_PUManuf(num)
					num += 1
				Loop While num <= 8
			Catch ex As Exception
			End Try
		End Sub

		Public Sub SetAIFilePreferencesFromFile()
			' The following expression was wrapped in a checked-statement
			Try
				RSWIN.LoadExpertPreferences()
				RSWIN_DESC.FGGradeRod = RSWIN_DESC.AIFilePreferences.FGGradeRod
				ini.SavePreferenceDataValue("FGGradeRod", RSWIN_DESC.FGGradeRod)
				RSWIN_DESC.FGRodType = RODUTIL.RodGrade(RSWIN_DESC.AIFilePreferences.FGGradeRod)
				RSWIN_DESC.HSGradeRod = RSWIN_DESC.AIFilePreferences.HSGradeRod
				ini.SavePreferenceDataValue("HSGradeRod", RSWIN_DESC.HSGradeRod)
				RSWIN_DESC.HSRodType = RODUTIL.RodGrade(RSWIN_DESC.AIFilePreferences.HSGradeRod)
				RSWIN_DESC.SBGradeRod = RSWIN_DESC.AIFilePreferences.SBGradeRod
				ini.SavePreferenceDataValue("SBGradeRod", RSWIN_DESC.SBGradeRod)
				RSWIN_DESC.SBRodType = RODUTIL.RodGrade(RSWIN_DESC.AIFilePreferences.SBGradeRod)
				Try
					RSWIN_DESC.bDesignSinkerbar = RSWIN_DESC.rst.gbDesignSinkerbar
				Catch ex As Exception
				End Try
				RSWIN_DESC.bUseNNSinkerbar = True
				RSWIN_DESC.bXRODUseCustomizedLists = RSWIN_DESC.AIFilePreferences.bXRODUseCustomizedLists
				ini.SavePreferenceDataValue("XRODUseCustomizedLists", Convert.ToString(RSWIN_DESC.bXRODUseCustomizedLists))
				RSWIN_DESC.bXRODUseGeneralList = RSWIN_DESC.AIFilePreferences.bXRODUseGeneralList
				ini.SavePreferenceDataValue("XRODUseGeneralList", Convert.ToString(RSWIN_DESC.bXRODUseGeneralList))
				RSWIN_DESC.bXRODUseClosestUnit = RSWIN_DESC.AIFilePreferences.bXRODUseClosestUnit
				ini.SavePreferenceDataValue("XRODUseClosestUnit", Convert.ToString(RSWIN_DESC.bXRODUseClosestUnit))
				RSWIN_DESC.MaxCasingSize = RSWIN_DESC.AIFilePreferences.fCasingSize
				ini.SavePreferenceDataValue("MaxCasingSize", RSWIN_DESC.MaxCasingSize)
				RSWIN_DESC.MaxTubingSizeOD = RSWIN_DESC.AIFilePreferences.fTubingSizeOD
				ini.SavePreferenceDataValue("MaxTubingSizeOD", RSWIN_DESC.MaxTubingSizeOD)
				RSWIN_DESC.SETUP_UseXRODVTubingSizes = RSWIN_DESC.AIFilePreferences.bUseXRODVTubingSizes
				ini.SavePreferenceDataValue("UseXRODVTubingSizes", Convert.ToString(RSWIN_DESC.SETUP_UseXRODVTubingSizes))
				RSWIN_DESC.SETUP_FixTubingSize = RSWIN_DESC.AIFilePreferences.bFixTubingSize
				ini.SavePreferenceDataValue("FixTubingSize", Convert.ToString(RSWIN_DESC.SETUP_FixTubingSize))
				RSWIN_DESC.SETUP_bUseSteelRodsOnly = RSWIN_DESC.AIFilePreferences.bUseSteelRodsOnly
				ini.SavePreferenceDataValue("bUseSteelRodsOnly", Convert.ToString(RSWIN_DESC.SETUP_bUseSteelRodsOnly))
				RSWIN_DESC.SETUP_bUseFGlassWithSteelOnBottom = RSWIN_DESC.AIFilePreferences.bUseFGlassWithSteelOnBottom
				ini.SavePreferenceDataValue("bUseFGlassWithSteelOnBottom", Convert.ToString(RSWIN_DESC.SETUP_bUseFGlassWithSteelOnBottom))
				RSWIN_DESC.SETUP_bUseAvgRodTBGFricCoeff = RSWIN_DESC.AIFilePreferences.bUseAvgRodTBGFricCoeff
				ini.SavePreferenceDataValue("bUseAvgRodTBGFricCoeff", Convert.ToString(RSWIN_DESC.SETUP_bUseAvgRodTBGFricCoeff))
				If RSWIN_DESC.SETUP_bUseAvgRodTBGFricCoeff Then
					RSWIN_DESC.SETUP_TimesAvgRodTBGFricCoeff = 1F
				Else
					RSWIN_DESC.SETUP_TimesAvgRodTBGFricCoeff = RSWIN_DESC.AIFilePreferences.TimesAvgRodTBGFricCoeff
				End If
				ini.SavePreferenceDataValue("TimesAvgRodTBGFricCoeff", RSWIN_DESC.SETUP_TimesAvgRodTBGFricCoeff)
				RSWIN_DESC.SETUP_ServiceFactorPreference = RSWIN_DESC.AIFilePreferences.ServiceFactorPreference
				ini.SavePreferenceDataValue("ServiceFactorPreference", RSWIN_DESC.SETUP_ServiceFactorPreference)
				RSWIN_DESC.SETUP_ElectricityCostPreference = RSWIN_DESC.AIFilePreferences.ElectricityCostPreference
				ini.SavePreferenceDataValue("ElectricityCostPreference", RSWIN_DESC.SETUP_ElectricityCostPreference)
				RSWIN_DESC.SETUP_PowerMeterType = RSWIN_DESC.AIFilePreferences.PowerMeterType
				ini.SavePreferenceDataValue("PowerMeterType", Convert.ToString(RSWIN_DESC.SETUP_PowerMeterType))
				RSWIN_DESC.SETUP_IncludeMotorSPV = RSWIN_DESC.AIFilePreferences.IncludeMotorSPV
				ini.SavePreferenceDataValue("IncludeMotorSPV", Convert.ToString(RSWIN_DESC.SETUP_IncludeMotorSPV))
				Dim num As Integer = 1
				Do
					RSWIN_DESC.set_bUsePUManuf(num, RSWIN_DESC.AIFilePreferences.bUsePUManuf(num))
					RSWIN_DESC.set_PUManuf(num, RSWIN_DESC.AIFilePreferences.PUManuf(num))
					ini.SavePreferenceDataValue("Use_PUManuf_Preference_" + num.ToString().Trim(), Convert.ToString(RSWIN_DESC.get_bUsePUManuf(num)))
					ini.SavePreferenceDataValue("PUManuf_Preference_" + num.ToString().Trim(), RSWIN_DESC.get_PUManuf(num))
					num += 1
				Loop While num <= 8
			Catch ex2 As Exception
			End Try
		End Sub

		Public Sub UseAIFilePreferencesFromFile()
			' The following expression was wrapped in a checked-statement
			Try
				RSWIN_DESC.FGGradeRod = RSWIN_DESC.AIFilePreferences.FGGradeRod
				RSWIN_DESC.FGRodType = RODUTIL.RodGrade(RSWIN_DESC.AIFilePreferences.FGGradeRod)
				RSWIN_DESC.HSGradeRod = RSWIN_DESC.AIFilePreferences.HSGradeRod
				RSWIN_DESC.HSRodType = RODUTIL.RodGrade(RSWIN_DESC.AIFilePreferences.HSGradeRod)
				RSWIN_DESC.SBGradeRod = RSWIN_DESC.AIFilePreferences.SBGradeRod
				RSWIN_DESC.SBRodType = RODUTIL.RodGrade(RSWIN_DESC.AIFilePreferences.SBGradeRod)
				Try
					RSWIN_DESC.bDesignSinkerbar = RSWIN_DESC.rst.gbDesignSinkerbar
				Catch ex As Exception
				End Try
				RSWIN_DESC.bUseNNSinkerbar = True
				RSWIN_DESC.bXRODUseCustomizedLists = RSWIN_DESC.AIFilePreferences.bXRODUseCustomizedLists
				RSWIN_DESC.bXRODUseGeneralList = RSWIN_DESC.AIFilePreferences.bXRODUseGeneralList
				RSWIN_DESC.bXRODUseClosestUnit = RSWIN_DESC.AIFilePreferences.bXRODUseClosestUnit
				RSWIN_DESC.MaxCasingSize = RSWIN_DESC.AIFilePreferences.fCasingSize
				RSWIN_DESC.MaxTubingSizeOD = RSWIN_DESC.AIFilePreferences.fTubingSizeOD
				RSWIN_DESC.SETUP_UseXRODVTubingSizes = RSWIN_DESC.AIFilePreferences.bUseXRODVTubingSizes
				RSWIN_DESC.SETUP_FixTubingSize = RSWIN_DESC.AIFilePreferences.bFixTubingSize
				RSWIN_DESC.SETUP_bUseSteelRodsOnly = RSWIN_DESC.AIFilePreferences.bUseSteelRodsOnly
				RSWIN_DESC.SETUP_bUseFGlassWithSteelOnBottom = RSWIN_DESC.AIFilePreferences.bUseFGlassWithSteelOnBottom
				RSWIN_DESC.SETUP_bUseAvgRodTBGFricCoeff = RSWIN_DESC.AIFilePreferences.bUseAvgRodTBGFricCoeff
				If RSWIN_DESC.SETUP_bUseAvgRodTBGFricCoeff Then
					RSWIN_DESC.SETUP_TimesAvgRodTBGFricCoeff = 1F
				Else
					RSWIN_DESC.SETUP_TimesAvgRodTBGFricCoeff = RSWIN_DESC.AIFilePreferences.TimesAvgRodTBGFricCoeff
				End If
				RSWIN_DESC.SETUP_ServiceFactorPreference = RSWIN_DESC.AIFilePreferences.ServiceFactorPreference
				RSWIN_DESC.SETUP_ElectricityCostPreference = RSWIN_DESC.AIFilePreferences.ElectricityCostPreference
				RSWIN_DESC.SETUP_PowerMeterType = RSWIN_DESC.AIFilePreferences.PowerMeterType
				RSWIN_DESC.SETUP_IncludeMotorSPV = RSWIN_DESC.AIFilePreferences.IncludeMotorSPV
				Dim num As Integer = 1
				Do
					RSWIN_DESC.set_bUsePUManuf(num, RSWIN_DESC.AIFilePreferences.bUsePUManuf(num))
					RSWIN_DESC.set_PUManuf(num, RSWIN_DESC.AIFilePreferences.PUManuf(num))
					num += 1
				Loop While num <= 8
			Catch ex2 As Exception
			End Try
		End Sub

		Public Function CompareAIPreferences() As Boolean
			' The following expression was wrapped in a checked-statement
			Dim result As Boolean
			Try
				Dim flag As Boolean = True
				RSWIN.LoadExpertPreferences()
				Dim num As Single
				If RSWIN_DESC.AIFilePreferences.bUseAvgRodTBGFricCoeff Then
					num = 1F
				Else
					num = RSWIN_DESC.AIFilePreferences.TimesAvgRodTBGFricCoeff
				End If
				Dim num2 As Single
				If RSWIN_DESC.SETUP_bUseAvgRodTBGFricCoeff Then
					num2 = 1F
				Else
					num2 = RSWIN_DESC.SETUP_TimesAvgRodTBGFricCoeff
				End If
				If RSWIN_DESC.AIFilePreferences.FGGradeRod <> RSWIN_DESC.FGGradeRod Or RSWIN_DESC.AIFilePreferences.HSGradeRod <> RSWIN_DESC.HSGradeRod Or RSWIN_DESC.AIFilePreferences.SBGradeRod <> RSWIN_DESC.SBGradeRod Or RSWIN_DESC.AIFilePreferences.bXRODUseCustomizedLists <> RSWIN_DESC.bXRODUseCustomizedLists Or ((RSWIN_DESC.AIFilePreferences.bXRODUseCustomizedLists Or RSWIN_DESC.bXRODUseCustomizedLists) And RSWIN_DESC.AIFilePreferences.bXRODUseGeneralList <> RSWIN_DESC.bXRODUseGeneralList) Or ((RSWIN_DESC.AIFilePreferences.bXRODUseCustomizedLists Or RSWIN_DESC.bXRODUseCustomizedLists) And RSWIN_DESC.AIFilePreferences.bXRODUseClosestUnit <> RSWIN_DESC.bXRODUseClosestUnit) Or RSWIN_DESC.AIFilePreferences.bUseXRODVTubingSizes <> RSWIN_DESC.SETUP_UseXRODVTubingSizes Or (Not RSWIN_DESC.AIFilePreferences.bUseXRODVTubingSizes And Not RSWIN_DESC.SETUP_UseXRODVTubingSizes And RSWIN_DESC.AIFilePreferences.fCasingSize <> RSWIN_DESC.MaxCasingSize) Or (Not RSWIN_DESC.AIFilePreferences.bUseXRODVTubingSizes And Not RSWIN_DESC.SETUP_UseXRODVTubingSizes And RSWIN_DESC.AIFilePreferences.fTubingSizeOD <> RSWIN_DESC.MaxTubingSizeOD) Or (Not RSWIN_DESC.AIFilePreferences.bUseXRODVTubingSizes And Not RSWIN_DESC.SETUP_UseXRODVTubingSizes And RSWIN_DESC.AIFilePreferences.bFixTubingSize <> RSWIN_DESC.SETUP_FixTubingSize) Or RSWIN_DESC.AIFilePreferences.bUseSteelRodsOnly <> RSWIN_DESC.SETUP_bUseSteelRodsOnly Or RSWIN_DESC.AIFilePreferences.bUseFGlassWithSteelOnBottom <> RSWIN_DESC.SETUP_bUseFGlassWithSteelOnBottom Or RSWIN_DESC.AIFilePreferences.bUseAvgRodTBGFricCoeff <> RSWIN_DESC.SETUP_bUseAvgRodTBGFricCoeff Or num <> num2 Or RSWIN_DESC.AIFilePreferences.ServiceFactorPreference <> RSWIN_DESC.SETUP_ServiceFactorPreference Or RSWIN_DESC.AIFilePreferences.ElectricityCostPreference <> RSWIN_DESC.SETUP_ElectricityCostPreference Or RSWIN_DESC.AIFilePreferences.PowerMeterType <> RSWIN_DESC.SETUP_PowerMeterType Or RSWIN_DESC.AIFilePreferences.IncludeMotorSPV <> RSWIN_DESC.SETUP_IncludeMotorSPV Then
					flag = False
				End If
				Dim num3 As Integer = 1
				While True
					If RSWIN_DESC.AIFilePreferences.bUsePUManuf(num3) Then
						If(RSWIN_DESC.AIFilePreferences.bUsePUManuf(num3) Or RSWIN_DESC.get_bUsePUManuf(num3)) And Operators.CompareString(RSWIN_DESC.AIFilePreferences.PUManuf(num3), RSWIN_DESC.get_PUManuf(num3), False) <> 0 Then
							Exit For
						End If
						If RSWIN_DESC.AIFilePreferences.bUsePUManuf(num3) <> RSWIN_DESC.get_bUsePUManuf(num3) And Operators.CompareString(RSWIN_DESC.AIFilePreferences.PUManuf(num3), RSWIN_DESC.get_PUManuf(num3), False) = 0 Then
							GoTo Block_7
						End If
					End If
					num3 += 1
					If num3 > 8 Then
						GoTo IL_2AB
					End If
				End While
				flag = False
				GoTo IL_2AB
				Block_7:
				flag = False
				IL_2AB:
				result = flag
			Catch ex As Exception
				result = False
			End Try
			Return result
		End Function

		Public Function CheckBoolean(bValue As Boolean) As String
			If bValue Then
				Return "Yes"
			End If
			Return "No"
		End Function

		Private Sub ChangeGuidesToSetup()
			' The following expression was wrapped in a checked-statement
			Try
				Dim text As String = "GuideToUse"
				Dim molded As Integer = CInt(RSWIN_DESC.MOLDED)
				Dim regProfileStringByInt As String = RSWIN.GetRegProfileStringByInt(RSWIN_DESC.SECT_RSWIN, text, molded)
				RSWIN_DESC.MOLDED = CShort(molded)
				RSWIN_DESC.SETUP_GuideToUse = Conversions.ToInteger(regProfileStringByInt)
				If RSWIN_DESC.SETUP_GuideToUse = 0 Then
					RSWIN_DESC.SETUP_GuideToUse = CInt(RSWIN_DESC.MOLDED)
					text = "GuideToUse"
					Dim text2 As String = Conversions.ToString(CInt(RSWIN_DESC.MOLDED))
					RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text, text2, RSWIN_DESC.sINIFile)
					RSWIN_DESC.MOLDED = Conversions.ToShort(text2)
				End If
				Dim num As Integer = 1
				Dim numRods As Integer = CInt(RSWIN_DESC.rst.NumRods)
				For i As Integer = num To numRods
					RSWIN_DESC.rst.Sections(i).Guide = CShort(RSWIN_DESC.SETUP_GuideToUse)
					RSWIN_DESC.rst.Sections(i).friction_coef = RODUTIL.GetFricCoeff(RSWIN_DESC.SETUP_GuideToUse, True)
				Next
			Catch ex As Exception
			End Try
		End Sub

		Private Function GuideExceptionInFile() As Boolean
			' The following expression was wrapped in a checked-statement
			Dim result As Boolean
			Try
				Dim flag As Boolean = False
				Dim flag2 As Boolean = False
				Dim flag3 As Boolean = False
				Dim text As String = "GuideToUse"
				Dim molded As Integer = CInt(RSWIN_DESC.MOLDED)
				Dim regProfileStringByInt As String = RSWIN.GetRegProfileStringByInt(RSWIN_DESC.SECT_RSWIN, text, molded)
				RSWIN_DESC.MOLDED = CShort(molded)
				RSWIN_DESC.SETUP_GuideToUse = Conversions.ToInteger(regProfileStringByInt)
				If RSWIN_DESC.SETUP_GuideToUse = 0 Then
					RSWIN_DESC.SETUP_GuideToUse = CInt(RSWIN_DESC.MOLDED)
					text = "GuideToUse"
					Dim text2 As String = Conversions.ToString(CInt(RSWIN_DESC.MOLDED))
					RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text, text2, RSWIN_DESC.sINIFile)
					RSWIN_DESC.MOLDED = Conversions.ToShort(text2)
				End If
				If RSWIN_DESC.SETUP_GuideToUse <> 0 Then
					flag3 = True
				End If
				Dim num As Integer = 1
				Dim numRods As Integer = CInt(RSWIN_DESC.rst.NumRods)
				For i As Integer = num To numRods
					If Not flag3 Then
						If CInt(RSWIN_DESC.rst.Sections(i).Guide) <> RSWIN_DESC.SETUP_GuideToUse And RSWIN_DESC.rst.Sections(i).Guide <> 0S Then
							flag = True
						ElseIf CInt(RSWIN_DESC.rst.Sections(i).Guide) = RSWIN_DESC.SETUP_GuideToUse And RSWIN_DESC.rst.Sections(i).Guide <> 0S Then
							flag2 = True
						End If
					ElseIf CInt(RSWIN_DESC.rst.Sections(i).Guide) <> RSWIN_DESC.SETUP_GuideToUse Then
						flag = True
					ElseIf CInt(RSWIN_DESC.rst.Sections(i).Guide) = RSWIN_DESC.SETUP_GuideToUse Then
						flag2 = True
					End If
				Next
				result = (flag And Not flag2)
			Catch ex As Exception
			End Try
			Return result
		End Function

		Private Function AllNoGuides(ByRef bAnswered As Boolean, Optional bShowAlternateMessage As Boolean = False) As Boolean
			' The following expression was wrapped in a checked-statement
			Dim result As Boolean
			Try
				Dim flag As Boolean = False
				Dim flag2 As Boolean = False
				Dim flag3 As Boolean = False
				bAnswered = False
				If RSWIN_DESC.bDisplayingBatchOutput Then
					flag3 = False
				Else
					Dim num As Integer = 1
					Dim numRods As Integer = CInt(RSWIN_DESC.rst.NumRods)
					For i As Integer = num To numRods
						If RSWIN_DESC.rst.Sections(i).Guide <> 0S Then
							flag = True
						End If
						If RSWIN_DESC.rst.Sections(i).NumGuides <> 0S Then
							flag2 = True
						End If
					Next
					If Not flag Or (Not flag2 And Not RSWIN_DESC.SETUP_RECOMMEND_GUIDES) Then
						If Not RSWIN_DESC.rst.gbBatch And Not RSWIN_DESC.rst.gbAutomatic Then
							If bShowAlternateMessage Then
								MessageBox.Show(RSWIN_DESC.sNoGuidesInFile)
							Else
								Dim msg As String = "No rod guides in file. Set all rod guides to default in Setup?"
								Dim bDefaultYes As Boolean = True
								Dim flag4 As Boolean = False
								If Util.YesNo(msg, bDefaultYes, flag4) Then
									flag3 = True
								End If
							End If
						End If
						bAnswered = True
					End If
				End If
				result = flag3
			Catch ex As Exception
			End Try
			Return result
		End Function

		Private Function SelectedSetupGuide() As String
			Dim result As String
			Try
				Dim setup_GuideToUse As Integer = RSWIN_DESC.SETUP_GuideToUse
				Dim text As String
				If setup_GuideToUse = 4 Then
					text = "Norris Standard"
				ElseIf setup_GuideToUse = CInt(RSWIN_DESC.NorrisSidewinderGuide) Then
					text = "Norris Sidewinder"
				ElseIf setup_GuideToUse = 6 Then
					text = "RGI Jake Coupling"
				ElseIf setup_GuideToUse = 7 Then
					text = "RGI SVT"
				ElseIf setup_GuideToUse = 8 Then
					text = "RGI Tomahawk"
				ElseIf setup_GuideToUse = 9 Then
					text = "RGI Tornado"
				ElseIf setup_GuideToUse = 10 Then
					text = "RGI Twister"
				ElseIf setup_GuideToUse = 11 Then
					text = "RGI WVT"
				End If
				result = text
			Catch ex As Exception
				result = "Norris Standard"
			End Try
			Return result
		End Function

		Public Function LoadXDIAGXML(ByRef sFileName As String, bDeviated As Boolean) As Boolean
			Dim flag As Boolean = False
			Dim nametable As XmlNameTable = New NameTable()
			Dim xmlSchemaCollection As XmlSchemaCollection = New XmlSchemaCollection(nametable)
			Dim result As Boolean
			Try
				RSWIN_DESC.bQuickFix = False
				MRodstarXML.SetupLookups()
				Dim xmlDocument As XmlDocument = New XmlDocument()
				Dim xmlDocument2 As XmlDocument = xmlDocument
				Try
					xmlDocument2.Load(sFileName)
				Catch ex As Exception
				End Try
				Dim xmlNamespaceManager As XmlNamespaceManager
				Try
					xmlNamespaceManager = New XmlNamespaceManager(xmlDocument.NameTable)
					xmlNamespaceManager.AddNamespace("r", "urn:schemas-gotheta-com:rodstar")
				Catch ex2 As XmlException
					MessageBox.Show(ex2.Message)
				End Try
				Dim cRODSTAR As cRODSTAR = RSWIN_DESC.rst
				Dim flag2 As Boolean = MRodstarXML.LoadInputXML_XDIAG(xmlDocument, xmlNamespaceManager, bDeviated)
				If flag2 And RSWIN_DESC.bRodStarD Then
					If MRodstarXML.AllNoGuides(flag, True) Then
						MRodstarXML.ChangeGuidesToSetup()
					ElseIf MRodstarXML.GuideExceptionInFile() And Not flag And Not RSWIN_DESC.rst.gbBatch And Not RSWIN_DESC.bDisplayingBatchOutput Then
						Dim dlgGuides As dlgGuides = New dlgGuides()
						Dim dlgGuides2 As dlgGuides = dlgGuides
						If dlgGuides2.Height > RSWIN_DESC.frmMain.Height Then
							dlgGuides2.Height = RSWIN_DESC.frmMain.Height
							dlgGuides2.Top = RSWIN_DESC.frmMain.Top
						End If
						dlgGuides2.ShowDialog()
						If dlgGuides2.bUseSetup Then
							MRodstarXML.ChangeGuidesToSetup()
						ElseIf dlgGuides2.bUseFile AndAlso dlgGuides2.bOverwriteSetup Then
							RSWIN_DESC.SETUP_GuideToUse = dlgGuides2.GuideInFileToUse
							Dim text As String = "GuideToUse"
							Dim text2 As String = Conversions.ToString(RSWIN_DESC.SETUP_GuideToUse)
							RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text, text2, RSWIN_DESC.sINIFile)
							RSWIN_DESC.SETUP_GuideToUse = Conversions.ToInteger(text2)
						End If
					End If
				End If
				Dim flag3 As Boolean
				If RSWIN_DESC.bRodStarD AndAlso flag2 Then
					MRodstarXML.LoadOutputXML_XDIAG(xmlDocument, xmlNamespaceManager, flag3)
					Try
						If flag3 And RSWIN_DESC.rst.gbOutputLoaded Then
							Dim num As Single = Conversions.ToSingle(Interaction.IIf((cRODSTAR.ULineSettingsChanged And cRODSTAR.ULinesSetH) <> 0S, cRODSTAR.UFeetFromSurface, cRODSTAR.XDFeetFromSurface))
							If num > 0F Then
								cRODSTAR.FluidLevelEntered = True
								cRODSTAR.giFluidLevelSource = 1S
								cRODSTAR.FluidLevel = num
								cRODSTAR.gbUseIPR = False
								cRODSTAR.gbCalcPumpCondition = False
							Else
								cRODSTAR.gbCalcPumpCondition = False
								Select Case cRODSTAR.giFluidLevelSource
									Case 0S
										cRODSTAR.FluidLevel = cRODSTAR.PumpDepth
										cRODSTAR.FluidLevelEntered = True
									Case 1S
										cRODSTAR.FluidLevelEntered = True
									Case 2S
										cRODSTAR.FluidLevelEntered = False
								End Select
							End If
							If RSWIN_DESC.gSysDiag.bSurfaceMatchPoor <> 0S Then
								cRODSTAR.PumpCondition = 1S
							ElseIf RSWIN_DESC.gSysDiag.bFullPump <> 0S Then
								cRODSTAR.PumpCondition = 1S
							ElseIf RSWIN_DESC.gSysDiag.bFluidPound <> 0S Then
								cRODSTAR.PumpCondition = 2S
							Else
								cRODSTAR.PumpCondition = 3S
							End If
							Dim flag4 As Boolean = RSWIN_DESC.gSysDiag.bFluidInertia <> 0S
							Dim num2 As Single = Conversions.ToSingle(Interaction.IIf(cRODSTAR.CBDataType = 1S And cRODSTAR.UnknownM, 0, cRODSTAR.get_M(2)))
							cRODSTAR.PumpFillage = RSWIN_DESC.gSysDiag.PumpFillage
							Dim num3 As Single = Conversions.ToSingle(Interaction.IIf((cRODSTAR.ULineSettingsChanged And cRODSTAR.ULinesSetH) <> 0S, cRODSTAR.UFeetFromSurface, cRODSTAR.XDFeetFromSurface))
							Dim num4 As Single = Conversions.ToSingle(Interaction.IIf((cRODSTAR.ULineSettingsChanged And cRODSTAR.ULinesSetH) <> 0S, cRODSTAR.UFluidLoad, cRODSTAR.XDFluidLoad))
							cRODSTAR.PumpEfficiency = Conversions.ToSingle(Interaction.IIf(flag4 And Strings.Len(Strings.Trim(cRODSTAR.gclsUpstroke(1).Pattern)) = 0, cRODSTAR.PumpEfficiency, 85))
							Dim num5 As Integer = 0
							num5 = num5 Or CInt((1S * -RSWIN_DESC.gSysDiag.bMeasuredStrokeCorrected))
							num5 = num5 Or CInt((2S * -(RSWIN_DESC.gSysDiag.bSurfPosKinematicCorrected And If((-If(((cRODSTAR.giDynoCorrectKinematic = 0S) > False), 1S, 0S)), 1S, 0S) And If((-If(((RSWIN_DESC.rst.PU.UnitType <> 10S) > False), 1S, 0S)), 1S, 0S) And If((-If(((RSWIN_DESC.rst.PU.UnitType <> 9S) > False), 1S, 0S)), 1S, 0S))))
							num5 = num5 Or CInt((4S * -If((-If(((RSWIN_DESC.gSysDiag.iAdjustPhase <> 0S And RSWIN_DESC.gSysDiag.PhaseAdjustment <> 0F And cRODSTAR.giDynoCorrectPhase = 0S) > False), 1S, 0S)), 1S, 0S)))
							num5 = num5 Or CInt((8S * -If((-If(((cRODSTAR.gfDynoLoadAdjustment <> 0F) > False), 1S, 0S)), 1S, 0S)))
							num5 = num5 Or CInt((16S * -RSWIN_DESC.gSysDiag.bLoadShiftCorrected))
							num5 = num5 Or CInt((32S * -RSWIN_DESC.gSysDiag.bClamponLoadCell))
							num5 = num5 Or CInt((64S * -If((-If(((cRODSTAR.giDynoCorrectPhase = 2S Or cRODSTAR.giDynoCorrectPhase = 3S) > False), 1S, 0S)), 1S, 0S)))
							num5 = num5 Or CInt((128S * -If((-If(((cRODSTAR.giDynoCorrectKinematic = 2S) > False), 1S, 0S)), 1S, 0S)))
							If cRODSTAR.xNtsteps <> 0S And num5 <> 0 Then
								Dim text3 As String = MRodstarXML.sDYWXDIAGCorrected1
								text3 = Conversions.ToString(Operators.ConcatenateObject(text3, Interaction.IIf((num5 And 1) = 0, RSWIN_DESC.sNull, Conversions.ToString(RSWIN_DESC.LF) + MRodstarXML.sDYWXDIAGCorrected2)))
								text3 = Conversions.ToString(Operators.ConcatenateObject(text3, Interaction.IIf((num5 And 2) = 0, RSWIN_DESC.sNull, Conversions.ToString(RSWIN_DESC.LF) + MRodstarXML.sDYWXDIAGCorrected3)))
								text3 = Conversions.ToString(Operators.ConcatenateObject(text3, Interaction.IIf((num5 And 4) = 0, RSWIN_DESC.sNull, Conversions.ToString(RSWIN_DESC.LF) + MRodstarXML.sDYWXDIAGCorrected4)))
								text3 = Conversions.ToString(Operators.ConcatenateObject(text3, Interaction.IIf((num5 And 8) = 0, RSWIN_DESC.sNull, Conversions.ToString(RSWIN_DESC.LF) + MRodstarXML.sDYWXDIAGCorrected5)))
								text3 = Conversions.ToString(Operators.ConcatenateObject(text3, Interaction.IIf((num5 And 16) = 0, RSWIN_DESC.sNull, Conversions.ToString(RSWIN_DESC.LF) + MRodstarXML.sDYWXDIAGCorrected6)))
								text3 = Conversions.ToString(Operators.ConcatenateObject(text3, Interaction.IIf((num5 And 32) = 0, RSWIN_DESC.sNull, Conversions.ToString(RSWIN_DESC.LF) + MRodstarXML.sDYWXDIAGCorrected7)))
								text3 = Conversions.ToString(Operators.ConcatenateObject(text3, Interaction.IIf((num5 And 64) = 0, RSWIN_DESC.sNull, Conversions.ToString(RSWIN_DESC.LF) + MRodstarXML.sDYWXDIAGCorrected8)))
								text3 = Conversions.ToString(Operators.ConcatenateObject(text3, Interaction.IIf((num5 And 128) = 0, RSWIN_DESC.sNull, Conversions.ToString(RSWIN_DESC.LF) + MRodstarXML.sDYWXDIAGCorrected9)))
								text3 = text3 + Conversions.ToString(RSWIN_DESC.LF) + Conversions.ToString(RSWIN_DESC.LF) + MRodstarXML.sDYWXDIAGCorrected10
								Dim msg As String = text3
								Dim bDefaultYes As Boolean = True
								Dim flag5 As Boolean = False
								If Util.YesNo(msg, bDefaultYes, flag5) Then
									Dim array As Single() = New Single(CInt((cRODSTAR.xNtsteps - 1S + 1S)) - 1) {}
									cRODSTAR.RDSurfLoad = array
									array = New Single(CInt((cRODSTAR.xNtsteps - 1S + 1S)) - 1) {}
									cRODSTAR.RDSurfPos = array
									cRODSTAR.dNtsteps = cRODSTAR.xNtsteps
									Dim num6 As Short = 0S
									Dim num7 As Short = cRODSTAR.dNtsteps - 1S

										For num8 As Short = num6 To num7
											cRODSTAR.RDSurfLoad(CInt(num8)) = cRODSTAR.xSurfLoad(CInt(num8))
											cRODSTAR.RDSurfPos(CInt(num8)) = cRODSTAR.xSurfPos(CInt(num8))
										Next
										cRODSTAR.RDNtsteps = cRODSTAR.xNtsteps

								End If
							End If
							RSWIN_DESC.rst.gbOutputLoaded = False
							GoTo IL_8B0
						End If
						cRODSTAR.gbCalcPumpCondition = False
						cRODSTAR.PumpCondition = 1S
						Select Case cRODSTAR.giFluidLevelSource
							Case 0S
								cRODSTAR.FluidLevel = cRODSTAR.PumpDepth
								cRODSTAR.FluidLevelEntered = True
								cRODSTAR.giFluidLevelSource = 1S
							Case 1S
								cRODSTAR.FluidLevelEntered = True
							Case 2S
								cRODSTAR.FluidLevelEntered = False
						End Select
						GoTo IL_8B0
					Catch ex3 As Exception
						GoTo IL_8B0
					End Try
				End If
				If Not flag2 Then
					flag3 = False
					cRODSTAR.gbOutputLoaded = False
				ElseIf Not RSWIN_DESC.bRodStarD And (Strings.InStr(sFileName, "rsvx", CompareMethod.Binary) > 0 Or Strings.InStr(sFileName, "RSVX", CompareMethod.Binary) > 0 Or Strings.InStr(sFileName, "xrvx", CompareMethod.Binary) > 0 Or Strings.InStr(sFileName, "XRVX", CompareMethod.Binary) > 0) Then
					If RSWIN_DESC.rst.bSaveFlag Then
						flag3 = True
						cRODSTAR.gbOutputLoaded = False
					Else
						MRodstarXML.LoadOutputXML_XDIAG(xmlDocument, xmlNamespaceManager, flag3)
					End If
				ElseIf Not RSWIN_DESC.bRodStarD Then
					flag3 = True
					cRODSTAR.gbOutputLoaded = False
				End If
				IL_8B0:
				If flag2 Then
					If RSWIN_DESC.rst.giFluidLevelSource > 0S Then
						RSWIN_DESC.rst.giFluidLevelSource = RSWIN_DESC.rst.giFluidLevelSource - 1S
					End If
					Select Case RSWIN_DESC.rst.PumpCondition
						Case 1S, 2S, 3S
						Case Else
							RSWIN_DESC.rst.PumpCondition = 1S
					End Select
					If RSWIN_DESC.rst.PumpCondition = 1S Then
						If Not RSWIN_DESC.rst.IncludeFluidInertia <> 0S Then
							RSWIN_DESC.rst.PumpEfficiency = 85F
						End If
					ElseIf RSWIN_DESC.rst.PumpFillage >= 0F Then
						If RSWIN_DESC.rst.PumpFillage <= 1F Then
							' The following expression was wrapped in a unchecked-expression
							RSWIN_DESC.rst.PumpFillage = Conversion.Int(RSWIN_DESC.rst.PumpFillage * 100F)
						End If
						If RSWIN_DESC.rst.PumpFillage > 95F Then
							RSWIN_DESC.rst.PumpFillage = 95F
						End If
						If RSWIN_DESC.rst.PumpFillage < 10F Then
							RSWIN_DESC.rst.PumpFillage = 10F
						End If
					Else
						RSWIN_DESC.rst.PumpFillage = 85F
					End If
					If RSWIN_DESC.bRodStarD Then
						RSWIN_DESC.rst.Friction = 0.2F
						RSWIN_DESC.rst.DownstrokeFriction = 0.1F
						RSWIN_DESC.rst.UpstrokeFriction = 0.1F
					Else
						RSWIN_DESC.rst.Friction = 2F
						RSWIN_DESC.rst.DownstrokeFriction = 1F
						RSWIN_DESC.rst.UpstrokeFriction = 1F
					End If
					RSWIN_DESC.rst.SlideFricCoeff = 0.2F
				End If
				If cRODSTAR.gbOutputLoaded Then
					Try
						Dim rst As cRODSTAR = RSWIN_DESC.rst
						RSWIN_DESC.bBalancedEVarsOverwritten = False
						Dim num9 As Integer = 1
						If rst.PU.UnitType <> 8S And rst.get_M(2) = 0F Then
							rst.UnknownM = True
						End If
						If((rst.PU.UnitType <> 8S And Not rst.UnknownM) Or (RSWIN_DESC.rst.PU.UnitType = 8S And Not rst.bUnknownUnbalance)) And rst.get_ElectricBillperMonth(2) < rst.get_ElectricBillperMonth(1) Then
							num9 = 2
						End If
						If(If((-If((CDbl(rst.get_ElectricBillperMonth(0)) >= 0.99 * CDbl(rst.get_ElectricBillperMonth(num9)) > False), 1S, 0S)), 1S, 0S) And Not RSWIN_DESC.DEBUG_ShowAllBalanced) <> 0S Then
							RSWIN_DESC.bBalancedEVarsOverwritten = True
							RSWIN_DESC.iOverWriteIndex = num9
						End If
					Catch ex4 As Exception
						RSWIN_DESC.bBalancedEVarsOverwritten = False
					End Try
				End If
				Dim flag6 As Boolean
				If cRODSTAR.gbBatch Then
					flag6 = flag2
				Else
					flag6 = (flag2 AndAlso flag3)
				End If
				If flag6 Then
					MRodstarXML.CheckInputData(sFileName)
				End If
				result = flag6
				Try
					xmlDocument = Nothing
					xmlNamespaceManager = Nothing
				Catch ex5 As Exception
				End Try
				cRODSTAR = Nothing
			Catch ex6 As XmlException
				MessageBox.Show(ex6.Message)
				result = False
			End Try
			Return result
		End Function

		Private Function LoadInputXML_XDIAG(ByRef xmlDoc As XmlDocument, ByRef nsmgr As XmlNamespaceManager, bDeviated As Boolean) As Boolean
			Dim text As String = New String(" "c, 40)
			Dim sMotorSizeName As String = ""
			Dim sMotorSettingName As String = ""
			Dim flag As Boolean = True
			Dim result As Boolean
			Try
				Dim xmlNode As XmlNode = xmlDoc.SelectSingleNode("//r:input", nsmgr)
				Dim xmlNode2 As XmlNode = xmlNode
				RSWIN_DESC.rst.ACompanyName = New String(" "c, 40)
				RSWIN_DESC.rst.ACompanyName = Convert.ToString(xmlNode2.SelectSingleNode("r:company-name", nsmgr).InnerText)
				RSWIN_DESC.rst.WellName = New String(" "c, 40)
				RSWIN_DESC.rst.WellName = Convert.ToString(xmlNode2.SelectSingleNode("r:well-name", nsmgr).InnerText)
				RSWIN_DESC.rst.UserName = New String(" "c, 40)
				RSWIN_DESC.rst.UserName = Convert.ToString(xmlNode2.SelectSingleNode("r:user-name", nsmgr).InnerText)
				RSWIN_DESC.rst.UserDate = New String(" "c, 40)
				RSWIN_DESC.rst.UserDate = Convert.ToString(xmlNode2.SelectSingleNode("r:date", nsmgr).InnerText)
				RSWIN_DESC.rst.PumpDepth = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:pump-depth", nsmgr).InnerText)
				RSWIN_DESC.rst.FluidLevel = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:fluid-level", nsmgr).InnerText)
				If RSWIN_DESC.rst.FluidLevel > RSWIN_DESC.rst.PumpDepth Then
					RSWIN_DESC.rst.FluidLevel = RSWIN_DESC.rst.PumpDepth
				End If
				RSWIN_DESC.rst.SPM = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:pumping-speed", nsmgr).InnerText)
				If RSWIN_DESC.rst.SPM > 0F Then
					RSWIN_DESC.rst.SPMEntered = -1S
				End If
				RSWIN_DESC.rst.Runtime = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:runtime", nsmgr).InnerText)
				RSWIN_DESC.rst.DynaSource = Conversions.ToShort(Util.ConvertToInt16(xmlNode2.SelectSingleNode("r:dyno-source", nsmgr).InnerText))
				RSWIN_DESC.rst.DynaFile = Convert.ToString(xmlNode2.SelectSingleNode("r:dyno-file", nsmgr).InnerText)
				RSWIN_DESC.rst.DynoDate = ""
				RSWIN_DESC.rst.DynoDate = Convert.ToString(xmlNode2.SelectSingleNode("r:dyno-date", nsmgr).InnerText)
				RSWIN_DESC.rst.LeutertDynamometer = Conversions.ToShort(Util.ConvertToInt16(xmlNode2.SelectSingleNode("r:leutert-dynamometer", nsmgr).InnerText))
				RSWIN_DESC.rst.LeutertModel = Convert.ToString(xmlNode2.SelectSingleNode("r:leutert-model", nsmgr).InnerText)
				RSWIN_DESC.rst.LeutertSpring = Conversions.ToShort(Util.ConvertToInt16(xmlNode2.SelectSingleNode("r:leutert-spring", nsmgr).InnerText))
				RSWIN_DESC.rst.LeutertScale = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:leutert-scale", nsmgr).InnerText)
				RSWIN_DESC.rst.MeasuredStroke = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:measured-stroke", nsmgr).InnerText)
				RSWIN_DESC.rst.PumpType = CShort(Conversions.ToInteger(MRodstarXML.DoLookup(MRodstarXML.mnLookupPumpType, xmlNode2.SelectSingleNode("r:pump-type", nsmgr).InnerText)))
				Try
					RSWIN_DESC.rst.VSP = MRodstarXML.CheckBoolean(xmlNode2.SelectSingleNode("r:vsp", nsmgr).InnerText)
				Catch ex As Exception
					RSWIN_DESC.rst.VSP = False
				End Try
				RSWIN_DESC.rst.PlungerSize = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:plunger-size", nsmgr).InnerText)
				If RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru And RSWIN_DESC.rst.PlungerSize = 0F Then
					RSWIN_DESC.rst.PlungerSize = 1.5F
				End If
				RSWIN_DESC.rst.WaterCut = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:water-cut", nsmgr).InnerText)
				RSWIN_DESC.rst.WaterSPGR = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:water-spgr", nsmgr).InnerText)
				If RSWIN_DESC.rst.WaterSPGR < 1F Then
					RSWIN_DESC.rst.WaterSPGR = 1F
				ElseIf CDbl(RSWIN_DESC.rst.WaterSPGR) > 1.5 Then
					RSWIN_DESC.rst.WaterSPGR = 1.5F
				End If
				RSWIN_DESC.rst.OilAPI = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:oil-density", nsmgr).InnerText)
				RSWIN_DESC.rst.OilSPGR = CSng((141.5 / CDbl(RSWIN_DESC.rst.OilAPI) + 131.5))
				RSWIN_DESC.rst.FluidSPGR = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:fluid-spgr", nsmgr).InnerText)
				RSWIN_DESC.rst.Friction = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:friction", nsmgr).InnerText)
				RSWIN_DESC.rst.TubingOD = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:tubing-od", nsmgr).InnerText)
				RSWIN_DESC.rst.TubingID = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:tubing-id", nsmgr).InnerText)
				RSWIN_DESC.rst.TubingAnchored = Conversions.ToShort(Util.ConvertToInt16(xmlNode2.SelectSingleNode("r:tubing-anchored", nsmgr).InnerText))
				RSWIN_DESC.rst.TubingAnchorDepth = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:tubing-anchor-depth", nsmgr).InnerText)
				RSWIN_DESC.rst.TubingPressure = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:tubing-pressure", nsmgr).InnerText)
				RSWIN_DESC.rst.CasingPressure = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:casing-pressure", nsmgr).InnerText)
				Dim xmlNodeList As XmlNodeList = xmlNode2.SelectNodes("r:rod-tapers/r:rod-taper", nsmgr)
				Dim xmlNodeList2 As XmlNodeList = xmlNodeList
				RSWIN_DESC.rst.NumRods = CShort(xmlNodeList2.Count)
				Dim i As Integer = 1
				Dim enumerator As IEnumerator = xmlNodeList2.GetEnumerator()
				Dim xmlNode3 As XmlNode
				While enumerator.MoveNext()
					Dim rodSection As RSWIN_DESC.RodSection = Nothing
					rodSection.Initialize()
					xmlNode3 = CType(enumerator.Current, XmlNode)
					Dim text2 As String
					Try
						text2 = xmlNode3("r:rodtype-corod").InnerText
					Catch ex2 As Exception
						text2 = ""
					End Try
					Dim text3 As String
					Try
						text3 = xmlNode3("r:rodtype-prorod").InnerText
					Catch ex3 As Exception
						text3 = ""
					End Try
					Dim text4 As String
					Try
						text4 = xmlNode3("r:rodtype-fiberglass").InnerText
					Catch ex4 As Exception
						text4 = ""
					End Try
					Dim text5 As String
					Try
						text5 = xmlNode3("r:rodtype-ribbonrod").InnerText
					Catch ex5 As Exception
						text5 = ""
					End Try
					Dim text6 As String
					Try
						text6 = xmlNode3("r:rodtype-sinkerbar").InnerText
					Catch ex6 As Exception
						text6 = ""
					End Try
					Dim text7 As String
					Try
						text7 = xmlNode3("r:rodtype-steel").InnerText
					Catch ex7 As Exception
						text7 = ""
					End Try
					Dim flag2 As Boolean = True
					If flag2 = (text2.Length <> 0) Then
						Dim obj As Object = Conversions.ToInteger(MRodstarXML.DoLookup(MRodstarXML.new_mnLookupRodGrade, xmlNode3("r:rodtype-corod").InnerText))
						If Operators.ConditionalCompareObjectEqual(obj, 0, False) Then
							rodSection.Grade = CShort(Conversions.ToInteger(MRodstarXML.DoLookup(MRodstarXML.mnLookupRodGrade, xmlNode3("r:rodtype-corod").InnerText)))
						Else
							rodSection.Grade = Conversions.ToShort(obj)
						End If
						Try
							Dim grade As Short = rodSection.Grade
							Dim flag3 As Boolean = RODUTIL.ConvertRodGrade(rodSection) <> 0
							GoTo IL_B64
						Catch ex8 As Exception
							Dim grade As Short
							rodSection.Grade = grade
							GoTo IL_B64
						End Try
						GoTo IL_7BF
					End If
					GoTo IL_7BF
					IL_B64:
					rodSection.Diameter = Util.ConvertToSingle(xmlNode3("r:taper-size").InnerText)
					rodSection.length = Util.ConvertToSingle(xmlNode3("r:taper-length").InnerText)
					If RSWIN_DESC.bRodStarD Then
						Try
							rodSection.Guide = Conversions.ToShort(Util.ConvertToInt16(xmlNode3("r:taper-guide").InnerText))
						Catch ex9 As Exception
						End Try
					End If
					Try
						rodSection.TensileStrength = Util.ConvertToSingle(xmlNode3("r:taper-tensile-strength").InnerText)
					Catch ex10 As Exception
						If rodSection.Grade <> 0S Then
							RODUTIL.LookupTensileStrength(rodSection)
						Else
							rodSection.TensileStrength = 0F
						End If
					End Try
					Try
						rodSection.StressMethod = Conversions.ToShort(Util.ConvertToInt16(xmlNode3("r:taper-stress-method").InnerText))
					Catch ex11 As Exception
						If rodSection.Grade <> 0S Then
							RODUTIL.LookupStressMethod(rodSection)
						Else
							rodSection.StressMethod = 0S
						End If
					End Try
					Try
						If RSWIN_DESC.SETUP_ALLOWSLIDEFRIC <> 0S Then
							rodSection.friction_coef = Util.ConvertToSingle(xmlNode3("r:taper-friction-coef").InnerText)
						Else
							rodSection.friction_coef = RSWIN_DESC.rst.SlideFricCoeff
						End If
					Catch ex12 As Exception
						rodSection.friction_coef = 0.2F
					End Try
					RSWIN_DESC.rst.Sections(i) = rodSection
					Dim flag4 As Boolean = True
					If flag4 = (RSWIN_DESC.rst.Sections(i).Grade = 16385S) Then
						GoTo IL_D4F
					End If
					If flag4 = (RSWIN_DESC.rst.Sections(i).Grade = 16389S) Then
						GoTo IL_D4F
					End If
					If flag4 = (RSWIN_DESC.rst.Sections(i).Grade = 16390S) Then
						GoTo IL_D4F
					End If
					If flag4 = (RODUTIL.IsSteel(CInt(RSWIN_DESC.rst.Sections(i).Grade)) <> 0) Then
						RSWIN_DESC.rst.Sections(i).SuckerRodLength = RSWIN_DESC.SETUP_SteelSuckerRodLength
					ElseIf flag4 = ((If(-If((RODUTIL.IsCorod(RSWIN_DESC.rst.Sections(i).Grade) > False), 1, 0), 1, 0) Or RODUTIL.IsProRod(CInt(RSWIN_DESC.rst.Sections(i).Grade))) <> 0) Then
						RSWIN_DESC.rst.Sections(i).SuckerRodLength = 1F
					Else
						RSWIN_DESC.rst.Sections(i).SuckerRodLength = 25F
					End If
					IL_E28:
					i += 1
					Continue While
					IL_D4F:
					RSWIN_DESC.rst.Sections(i).SuckerRodLength = 37.5F
					GoTo IL_E28
					IL_7BF:
					If flag2 = (text3.Length <> 0) Then
						Dim obj As Object = Conversions.ToInteger(MRodstarXML.DoLookup(MRodstarXML.new_mnLookupRodGrade, xmlNode3("r:rodtype-prorod").InnerText))
						If Operators.ConditionalCompareObjectEqual(obj, 0, False) Then
							rodSection.Grade = CShort(Conversions.ToInteger(MRodstarXML.DoLookup(MRodstarXML.mnLookupRodGrade, xmlNode3("r:rodtype-prorod").InnerText)))
							GoTo IL_B64
						End If
						rodSection.Grade = Conversions.ToShort(obj)
						GoTo IL_B64
					ElseIf flag2 = (text4.Length <> 0) Then
						Dim obj As Object = Conversions.ToInteger(MRodstarXML.DoLookup(MRodstarXML.new_mnLookupRodGrade, xmlNode3("r:rodtype-fiberglass").InnerText))
						If Operators.ConditionalCompareObjectEqual(obj, 0, False) Then
							rodSection.Grade = CShort(Conversions.ToInteger(MRodstarXML.DoLookup(MRodstarXML.mnLookupRodGrade, xmlNode3("r:rodtype-fiberglass").InnerText)))
						Else
							rodSection.Grade = Conversions.ToShort(obj)
						End If
						If rodSection.Grade = 0S Then
							rodSection.Grade = Conversions.ToShort(MRodstarXML.DoCustomFGRodGradeLookup(Conversions.ToInteger(xmlNode3("r:rodtype-fiberglass").InnerText)))
							GoTo IL_B64
						End If
						GoTo IL_B64
					ElseIf flag2 = (text5.Length <> 0) Then
						rodSection.Grade = CShort(Conversions.ToInteger(MRodstarXML.DoLookup(MRodstarXML.mnLookupRodGrade, xmlNode3("r:rodtype-ribbonrod").InnerText)))
						Dim obj As Object = Conversions.ToInteger(MRodstarXML.DoLookup(MRodstarXML.new_mnLookupRodGrade, xmlNode3("r:rodtype-ribbonrod").InnerText))
						If Operators.ConditionalCompareObjectEqual(obj, 0, False) Then
							rodSection.Grade = CShort(Conversions.ToInteger(MRodstarXML.DoLookup(MRodstarXML.mnLookupRodGrade, xmlNode3("r:rodtype-ribbonrod").InnerText)))
							GoTo IL_B64
						End If
						rodSection.Grade = Conversions.ToShort(obj)
						GoTo IL_B64
					ElseIf flag2 = (text6.Length <> 0) Then
						rodSection.Grade = CShort(Conversions.ToInteger(MRodstarXML.DoLookup(MRodstarXML.mnLookupRodGrade, xmlNode3("r:rodtype-sinkerbar").InnerText)))
						Dim obj As Object = Conversions.ToInteger(MRodstarXML.DoLookup(MRodstarXML.new_mnLookupRodGrade, xmlNode3("r:rodtype-sinkerbar").InnerText))
						If Operators.ConditionalCompareObjectEqual(obj, 0, False) Then
							rodSection.Grade = CShort(Conversions.ToInteger(MRodstarXML.DoLookup(MRodstarXML.mnLookupRodGrade, xmlNode3("r:rodtype-sinkerbar").InnerText)))
						Else
							rodSection.Grade = Conversions.ToShort(obj)
						End If
						If rodSection.Grade = 0S Then
							rodSection.Grade = CShort(MRodstarXML.DoCustomSinkerBarRodGradeLookup(xmlNode3("r:rodtype-sinkerbar").InnerText))
							GoTo IL_B64
						End If
						GoTo IL_B64
					Else
						If flag2 <> (text7.Length <> 0) Then
							GoTo IL_B64
						End If
						Dim obj As Object = Conversions.ToInteger(MRodstarXML.DoLookup(MRodstarXML.new_mnLookupRodGrade, xmlNode3("r:rodtype-steel").InnerText))
						If Operators.ConditionalCompareObjectEqual(obj, 0, False) Then
							rodSection.Grade = CShort(Conversions.ToInteger(MRodstarXML.DoLookup(MRodstarXML.mnLookupRodGrade, xmlNode3("r:rodtype-steel").InnerText)))
						Else
							rodSection.Grade = Conversions.ToShort(obj)
						End If
						If rodSection.Grade <> 0S Then
							GoTo IL_B64
						End If
						rodSection.Grade = CShort(MRodstarXML.DoCustomSteelRodGradeLookup(xmlNode3("r:rodtype-steel").InnerText))
						If rodSection.Grade = 0S And text7.Trim().Length <> 0 Then
							rodSection.RodType = text7
							GoTo IL_B64
						End If
						GoTo IL_B64
					End If
				End While
				RSWIN_DESC.rst.ServiceFactor = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:service-factor", nsmgr).InnerText)
				Dim pu As RSWIN_DESC.PUDataRec
				pu.Initialize()
				RSWIN_DESC.rst.PU.Initialize()
				Try
					Dim xmlNode4 As XmlNode = xmlNode2.SelectSingleNode("r:pumpingunit", nsmgr)
					Dim flag5 As Boolean = True
					Dim xmlNode5 As XmlNode
					If flag5 = xmlNode4.SelectNodes("r:pumpingunit-airbalanced", nsmgr).Count > 0 Then
						pu.UnitType = 6S
						xmlNode5 = xmlNode4.SelectSingleNode("r:pumpingunit-airbalanced", nsmgr)
					ElseIf flag5 = xmlNode4.SelectNodes("r:pumpingunit-conventional", nsmgr).Count > 0 Then
						pu.UnitType = 1S
						xmlNode5 = xmlNode4.SelectSingleNode("r:pumpingunit-conventional", nsmgr)
					ElseIf flag5 = xmlNode4.SelectNodes("r:pumpingunit-beambalanced", nsmgr).Count > 0 Then
						pu.UnitType = 8S
						xmlNode5 = xmlNode4.SelectSingleNode("r:pumpingunit-beambalanced", nsmgr)
					ElseIf flag5 = xmlNode4.SelectNodes("r:pumpingunit-beltlowprofile", nsmgr).Count > 0 Then
						pu.UnitType = 9S
						xmlNode5 = xmlNode4.SelectSingleNode("r:pumpingunit-beltlowprofile", nsmgr)
					ElseIf flag5 = xmlNode4.SelectNodes("r:pumpingunit-grooves", nsmgr).Count > 0 Then
						pu.UnitType = 3S
						xmlNode5 = xmlNode4.SelectSingleNode("r:pumpingunit-grooves", nsmgr)
					ElseIf flag5 = xmlNode4.SelectNodes("r:pumpingunit-enhanced", nsmgr).Count > 0 Then
						pu.UnitType = 2S
						xmlNode5 = xmlNode4.SelectSingleNode("r:pumpingunit-enhanced", nsmgr)
					ElseIf flag5 = xmlNode4.SelectNodes("r:pumpingunit-longstroke", nsmgr).Count > 0 Then
						pu.UnitType = 7S
						xmlNode5 = xmlNode4.SelectSingleNode("r:pumpingunit-longstroke", nsmgr)
					ElseIf flag5 = xmlNode4.SelectNodes("r:pumpingunit-hydraulic", nsmgr).Count > 0 Then
						pu.UnitType = 10S
						xmlNode5 = xmlNode4.SelectSingleNode("r:pumpingunit-hydraulic", nsmgr)
					ElseIf flag5 = xmlNode4.SelectNodes("r:pumpingunit-lowprofile", nsmgr).Count > 0 Then
						pu.UnitType = 4S
						xmlNode5 = xmlNode4.SelectSingleNode("r:pumpingunit-lowprofile", nsmgr)
					ElseIf flag5 = xmlNode4.SelectNodes("r:pumpingunit-markii", nsmgr).Count > 0 Then
						pu.UnitType = 5S
						xmlNode5 = xmlNode4.SelectSingleNode("r:pumpingunit-markii", nsmgr)
					End If
					Dim xmlNode6 As XmlNode = xmlNode5
					xmlNode3 = xmlNode6.SelectSingleNode("r:pumping-unit-id", nsmgr)
					If xmlNode3 IsNot Nothing Then
						RSWIN_DESC.rst.IDEntered = -1S
						RSWIN_DESC.rst.UnitID = Convert.ToString(xmlNode6.SelectSingleNode("r:pumping-unit-id", nsmgr).InnerText)
					Else
						RSWIN_DESC.rst.IDEntered = 0S
						RSWIN_DESC.rst.UnitID = ""
					End If
					If(RSWIN_DESC.rst.IDEntered And If(-If((Strings.InStr(RSWIN_DESC.rst.UnitID, "CUSTOM", CompareMethod.Binary) > 0 > False), 1S, 0S), 1S, 0S)) <> 0S Then
						MRodstarXML.bCustomPU = True
					End If
					xmlNode3 = xmlNode6.SelectSingleNode("r:crank-rotation", nsmgr)
					pu.CrankRotation = CShort(Conversions.ToInteger(MRodstarXML.DoLookup(MRodstarXML.mnLookupCrankRotation, xmlNode6.SelectSingleNode("r:crank-rotation", nsmgr).InnerText)))
					Try
						pu.CrankHole = Conversions.ToShort(Util.ConvertToInt16(xmlNode6.SelectSingleNode("r:crank-hole-number", nsmgr).InnerText))
					Catch ex13 As Exception
					End Try
					If pu.UnitType <> 7S AndAlso pu.CrankHole = 0S Then
						pu.CrankHole = 1S
					End If
					If RSWIN_DESC.rst.IDEntered <> 0S Then
						RSWIN_DESC.rst.UnitID = Convert.ToString(xmlNode6.SelectSingleNode("r:pumping-unit-id", nsmgr).InnerText)
						If Strings.InStr(RSWIN_DESC.rst.UnitID, "CUSTOM", CompareMethod.Binary) > 0 Then
							MRodstarXML.bCustomPU = True
						End If
					End If
					Try
						RSWIN_DESC.rst.Unbalance = Util.ConvertToSingle(xmlNode6.SelectSingleNode("r:structural-unbalance", nsmgr).InnerText)
					Catch ex14 As Exception
						RSWIN_DESC.rst.Unbalance = 0F
					End Try
					If MRodstarXML.bCustomPU Then
						pu.APIDesignation = Convert.ToString(xmlNode6.SelectSingleNode("r:api-designation", nsmgr).InnerText)
						pu.Manuf = Convert.ToString(xmlNode6.SelectSingleNode("r:pumping-unit-manufacturer", nsmgr).InnerText)
						pu.OtherInfo = Convert.ToString(xmlNode6.SelectSingleNode("r:pumping-unit-other-info", nsmgr).InnerText)
						pu.UnitName = Convert.ToString(xmlNode6.SelectSingleNode("r:pumping-unit-name", nsmgr).InnerText)
						If pu.Manuf.Length < 40 Then
							pu.Manuf = pu.Manuf.PadRight(40)
						End If
						If pu.APIDesignation.Length < 40 Then
							pu.APIDesignation = pu.APIDesignation.PadRight(40)
						End If
						If pu.UnitName.Length < 40 Then
							pu.UnitName = pu.UnitName.PadRight(40)
						End If
						If pu.OtherInfo.Length < 40 Then
							pu.OtherInfo = pu.OtherInfo.PadRight(40)
						End If
						Try
							pu.StructRating = Util.ConvertToSingle(xmlNode6.SelectSingleNode("r:pumping-unit-struct-rating", nsmgr).InnerText)
						Catch ex15 As Exception
							MRodstarXML.bErrorCustomPU = True
						End Try
						Try
							pu.GearboxRating = Util.ConvertToSingle(xmlNode6.SelectSingleNode("r:pumping-unit-gearbox-rating", nsmgr).InnerText)
						Catch ex16 As Exception
							MRodstarXML.bErrorCustomPU = True
						End Try
						Try
							Dim num As Single = Util.ConvertToSingle(xmlNode6.SelectSingleNode("r:pumping-unit-max-stroke", nsmgr).InnerText)
							Dim text8 As String = "####.##"
							pu.MaxStroke = Conversions.ToSingle(Util.Format(num, text8))
						Catch ex17 As Exception
							MRodstarXML.bErrorCustomPU = True
						End Try
						Try
							pu.ArtInertia = Util.ConvertToSingle(xmlNode6.SelectSingleNode("r:pumping-unit-art-inertia", nsmgr).InnerText)
						Catch ex18 As Exception
							MRodstarXML.bErrorCustomPU = True
						End Try
						If pu.UnitType = 7S Or pu.UnitType = 10S Then
							pu.DrumDiamRatio = Util.ConvertToSingle(xmlNode6.SelectSingleNode("r:drum-diameter-ratio", nsmgr).InnerText)
							pu.P = Util.ConvertToSingle(xmlNode6.SelectSingleNode("r:pitman-arm-length", nsmgr).InnerText)
							pu.SprocketDistance = Util.ConvertToSingle(xmlNode6.SelectSingleNode("r:sprocket-distance", nsmgr).InnerText)
							pu.SprocketRadius = Util.ConvertToSingle(xmlNode6.SelectSingleNode("r:sprocket-diameter", nsmgr).InnerText) / 2F
							If pu.CrankRadii Is Nothing Then
								pu.CrankRadii = New Single(4) {}
							End If
							If pu.Strokes Is Nothing Then
								pu.Strokes = New Single(4) {}
							End If
							pu.CrankHoles = 1S
							pu.CrankHole = 1S
							If pu.UnitType = 7S And pu.MaxStroke > 0F Then
								pu.Strokes(0) = pu.MaxStroke
							End If
						Else
							xmlNodeList = xmlNode6.SelectNodes("r:pu-crank-radii/r:crank-radius", nsmgr)
							Dim xmlNodeList3 As XmlNodeList = xmlNodeList
							pu.CrankHoles = CShort(xmlNodeList3.Count)
							enumerator = xmlNodeList3.GetEnumerator()
							If pu.CrankRadii Is Nothing Then
								pu.CrankRadii = New Single(4) {}
							End If
							If pu.Strokes Is Nothing Then
								pu.Strokes = New Single(4) {}
							End If
							i = 1
							While enumerator.MoveNext()
								Dim obj2 As Object = enumerator.Current
								xmlNode3 = CType(obj2, XmlNode)
								pu.CrankRadii(i - 1) = Util.ConvertToSingle(xmlNode3("r:pu-apidimension-r").InnerText)
								pu.Strokes(i - 1) = Util.ConvertToSingle(xmlNode3("r:nominal-stroke-length").InnerText)
								i += 1
							End While
							pu.A = Util.ConvertToSingle(xmlNode6.SelectSingleNode("r:pu-apidimension-a", nsmgr).InnerText)
							pu.C = Util.ConvertToSingle(xmlNode6.SelectSingleNode("r:pu-apidimension-c", nsmgr).InnerText)
							pu.I = Util.ConvertToSingle(xmlNode6.SelectSingleNode("r:pu-apidimension-i", nsmgr).InnerText)
							pu.K = Util.ConvertToSingle(xmlNode6.SelectSingleNode("r:pu-apidimension-k", nsmgr).InnerText)
							pu.P = Util.ConvertToSingle(xmlNode6.SelectSingleNode("r:pu-apidimension-p", nsmgr).InnerText)
							If pu.UnitType <> 6S Then
								pu.CrankOffset = Util.ConvertToSingle(xmlNode6.SelectSingleNode("r:crank-offset-angle", nsmgr).InnerText)
							Else
								pu.M = Util.ConvertToSingle(xmlNode6.SelectSingleNode("r:pu-apidimension-m", nsmgr).InnerText)
								pu.S = Util.ConvertToSingle(xmlNode6.SelectSingleNode("r:pu-apidimension-s", nsmgr).InnerText)
								pu.V0 = Util.ConvertToSingle(xmlNode6.SelectSingleNode("r:pu-apidimension-v0", nsmgr).InnerText)
							End If
							pu.Unbalance = Util.ConvertToSingle(xmlNode6.SelectSingleNode("r:structural-unbalance", nsmgr).InnerText)
						End If
					End If
					xmlNode6 = Nothing
				Catch ex19 As Exception
				End Try
				Application.DoEvents()
				Application.DoEvents()
				RSWIN_DESC.rst.PU = pu
				If pu.UnitType = 8S Then
					Try
						RSWIN_DESC.rst.bUnknownUnbalance = MRodstarXML.CheckBoolean(xmlNode2.SelectSingleNode("r:beam-balanced", nsmgr).InnerText)
					Catch ex20 As Exception
						RSWIN_DESC.rst.bUnknownUnbalance = False
					End Try
				End If
				RSWIN_DESC.rst.ElectricityCost = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:electricity-cost", nsmgr).InnerText)
				RSWIN_DESC.rst.PowerMeterType = CShort(Conversions.ToInteger(MRodstarXML.DoLookup(MRodstarXML.mnLookupPowerMeterType, xmlNode2.SelectSingleNode("r:power-meter-type", nsmgr).InnerText)))
				RSWIN_DESC.rst.CalcMotorSize = Conversions.ToShort(Util.ConvertToInt16(xmlNode2.SelectSingleNode("r:calc-motor-size", nsmgr).InnerText))
				Dim num2 As Integer = Conversions.ToInteger(Util.ConvertToInt32(xmlNode2.SelectSingleNode("r:motor-kind", nsmgr).InnerText))
				sMotorSizeName = xmlNode2.SelectSingleNode("r:motor-size", nsmgr).InnerText
				sMotorSettingName = xmlNode2.SelectSingleNode("r:motor-setting", nsmgr).InnerText
				If num2 > 7 Then
					Motor.CorrectMotorSizeSettingName(num2 + 1, sMotorSizeName)
					Motor.CorrectMotorSizeSettingName(num2 + 1, sMotorSettingName)
				End If
				Motor.SelectMotorKind(num2)
				Motor.SelectMotorSizeByName(sMotorSizeName)
				Motor.SelectMotorSettingByName(sMotorSettingName)
				Dim count As Integer = xmlNode2.SelectNodes("r:max-existing-counterbalance", nsmgr).Count
				RSWIN_DESC.rst.UnknownM = Conversions.ToBoolean(Interaction.IIf(count = 0, True, False))
				Try
					RSWIN_DESC.rst.CBDataType = Conversions.ToShort(xmlNode2.SelectSingleNode("r:cb-datatype", nsmgr).InnerText)
				Catch ex21 As Exception
					RSWIN_DESC.rst.CBDataType = 0S
				End Try
				If RSWIN_DESC.rst.UnknownM Then
					RSWIN_DESC.rst.set_M(2, 0F)
				Else
					Try
						RSWIN_DESC.rst.set_M(2, Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:max-existing-counterbalance", nsmgr).InnerText))
						If RSWIN_DESC.rst.get_M(2) > 0F And RSWIN_DESC.rst.CBDataType = 0S Then
							RSWIN_DESC.rst.CBDataType = 1S
						End If
					Catch ex22 As Exception
						RSWIN_DESC.rst.set_M(2, 0F)
						RSWIN_DESC.rst.UnknownM = True
					End Try
				End If
				RSWIN_DESC.rst.UnknownM = (RSWIN_DESC.rst.get_M(2) = 0F)
				Try
					RSWIN_DESC.rst.CBDataType = Conversions.ToShort(xmlNode2.SelectSingleNode("r:cb-datatype", nsmgr).InnerText)
				Catch ex23 As Exception
					RSWIN_DESC.rst.CBDataType = 0S
				End Try
				Try
					RSWIN_DESC.rst.CBEffect = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:cb-effect", nsmgr).InnerText)
				Catch ex24 As Exception
					RSWIN_DESC.rst.CBEffect = 0F
				End Try
				Try
					RSWIN_DESC.rst.CBAngle = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:cb-angle", nsmgr).InnerText)
					If RSWIN_DESC.rst.CBEffect > 0F And RSWIN_DESC.rst.CBAngle > 0F And RSWIN_DESC.rst.get_M(2) = 0F Then
						RSWIN_DESC.rst.CBDataType = 2S
					End If
				Catch ex25 As Exception
					RSWIN_DESC.rst.CBAngle = 0F
				End Try
				If RSWIN_DESC.rst.UnknownM Then
					RSWIN_DESC.rst.set_M(2, 0F)
				Else
					Try
						RSWIN_DESC.rst.set_M(2, Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:max-existing-counterbalance", nsmgr).InnerText))
						If RSWIN_DESC.rst.get_M(2) > 0F And RSWIN_DESC.rst.CBDataType = 0S Then
							RSWIN_DESC.rst.CBDataType = 1S
						End If
					Catch ex26 As Exception
						RSWIN_DESC.rst.set_M(2, 0F)
						RSWIN_DESC.rst.UnknownM = True
					End Try
				End If
				RSWIN_DESC.rst.CBDataFile = Convert.ToString(xmlNode2.SelectSingleNode("r:cbalance-file", nsmgr).InnerText)
				MImpred.InitSurveyDataset(RSWIN_DESC.mdsDeviationProfile, Nothing)
				If bDeviated And RSWIN_DESC.bRodStarD Then
					Dim xmlNodeList4 As XmlNodeList = xmlNode2.SelectNodes("r:deviation-survey", nsmgr)
					If xmlNodeList4.Count > 0 Then
						xmlNodeList = xmlNode2.SelectNodes("r:deviation-survey/r:survey-point", nsmgr)
						Dim xmlNodeList5 As XmlNodeList = xmlNodeList
						Dim count2 As Integer = xmlNodeList5.Count
						enumerator = xmlNodeList5.GetEnumerator()
						i = 0
						If xmlNodeList5.Count > 0 Then
						End If
						While enumerator.MoveNext()
							Dim obj3 As Object = enumerator.Current
							xmlNode3 = CType(obj3, XmlNode)
							Console.WriteLine(xmlNode3.InnerText)
							Dim dataRow As DataRow = RSWIN_DESC.mdsDeviationProfile.Tables(0).NewRow()
							dataRow("EntryNumber") = i + 1
							dataRow("Depth") = Util.ConvertToSingle(xmlNode3("r:measured-depth").InnerText)
							dataRow("Inclination") = Util.CheckDec(xmlNode3("r:inclination").InnerText)
							dataRow("Azimuth") = Util.CheckDec(xmlNode3("r:azimuth").InnerText)
							dataRow("Dogleg") = DBNull.Value
							dataRow("TVDepth") = DBNull.Value
							dataRow("NorthSouth") = DBNull.Value
							dataRow("EastWest") = DBNull.Value
							RSWIN_DESC.mdsDeviationProfile.Tables(0).Rows.Add(dataRow)
							i += 1
						End While
					End If
				End If
				RSWIN_DESC.mdsDeviationProfile_Edit = Nothing
				count = xmlNode2.SelectNodes("r:measured-dynamometer-card", nsmgr).Count
				Try
					xmlNodeList = xmlNode2.SelectNodes(".//r:measured-dynamometer-card-point", nsmgr)
					Dim xmlNodeList6 As XmlNodeList = xmlNodeList
					RSWIN_DESC.rst.RDNtsteps = CShort(xmlNodeList6.Count)
					Dim array As Single() = New Single(CInt((RSWIN_DESC.rst.RDNtsteps - 1S + 1S)) - 1) {}
					RSWIN_DESC.rst.RDSurfLoad = array
					array = New Single(CInt((RSWIN_DESC.rst.RDNtsteps - 1S + 1S)) - 1) {}
					RSWIN_DESC.rst.RDSurfPos = array
					If RSWIN_DESC.rst.RDNtsteps > 0S Then
						enumerator = xmlNodeList6.GetEnumerator()
						i = 0
						While enumerator.MoveNext()
							Dim obj4 As Object = enumerator.Current
							xmlNode3 = CType(obj4, XmlNode)
							RSWIN_DESC.rst.RDSurfLoad(i) = Util.ConvertToSingle(xmlNode3("r:surface-load").InnerText)
							RSWIN_DESC.rst.RDSurfPos(i) = Util.ConvertToSingle(xmlNode3("r:surface-position").InnerText)
							i += 1
						End While
					Else
						RSWIN_DESC.rst.RDNtsteps = 0S
					End If
				Catch ex27 As Exception
					RSWIN_DESC.rst.RDNtsteps = 0S
					Dim array As Single() = New Single(0) {}
					RSWIN_DESC.rst.RDSurfLoad = array
					array = New Single(0) {}
					RSWIN_DESC.rst.RDSurfPos = array
				End Try
				If flag Then
					Try
						RSWIN_DESC.rst.PumpEfficiency = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:pump-efficiency", nsmgr).InnerText)
					Catch ex28 As Exception
						RSWIN_DESC.rst.PumpEfficiency = 0F
					End Try
					Try
						RSWIN_DESC.rst.MotorSPV = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:motor-speed-variation", nsmgr).InnerText)
					Catch ex29 As Exception
						RSWIN_DESC.rst.MotorSPV = 0F
					End Try
					Try
						RSWIN_DESC.rst.UpstrokeFriction = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:rod-tubing-friction-upstroke", nsmgr).InnerText)
					Catch ex30 As Exception
					End Try
					Try
						RSWIN_DESC.rst.DownstrokeFriction = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:rod-tubing-friction-downstroke", nsmgr).InnerText)
					Catch ex31 As Exception
					End Try
					Try
						RSWIN_DESC.rst.gfDynoLoadAdjustment = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:dyno-load-adjustment", nsmgr).InnerText)
					Catch ex32 As Exception
						RSWIN_DESC.rst.gfDynoLoadAdjustment = 0F
					End Try
					Try
						RSWIN_DESC.rst.giDynoCorrectPhase = Conversions.ToShort(Util.ConvertToInt32(xmlNode2.SelectSingleNode("r:dyno-correct-phase", nsmgr).InnerText))
					Catch ex33 As Exception
						RSWIN_DESC.rst.giDynoCorrectPhase = 0S
					End Try
					Try
						RSWIN_DESC.rst.giDynoCorrectKinematic = Conversions.ToShort(Util.ConvertToInt32(xmlNode2.SelectSingleNode("r:dyno-correct-kinematic", nsmgr).InnerText))
					Catch ex34 As Exception
						RSWIN_DESC.rst.giDynoCorrectPhase = 0S
					End Try
					Try
						RSWIN_DESC.rst.CompressibilityIndex = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:compressibility-index", nsmgr).InnerText)
					Catch ex35 As Exception
						RSWIN_DESC.rst.CompressibilityIndex = 3F
					End Try
				End If
				count = xmlNode2.SelectNodes("r:xdiag-dynamometer-card", nsmgr).Count
				Try
					xmlNodeList = xmlNode2.SelectNodes(".//r:xdiag-dynamometer-card-point", nsmgr)
					Dim xmlNodeList7 As XmlNodeList = xmlNodeList
					RSWIN_DESC.rst.xNtsteps = CShort(xmlNodeList7.Count)
					Dim array As Single() = New Single(CInt((RSWIN_DESC.rst.xNtsteps - 1S + 1S)) - 1) {}
					RSWIN_DESC.rst.xSurfLoad = array
					array = New Single(CInt((RSWIN_DESC.rst.xNtsteps - 1S + 1S)) - 1) {}
					RSWIN_DESC.rst.xSurfPos = array
					If RSWIN_DESC.rst.xNtsteps > 0S Then
						enumerator = xmlNodeList7.GetEnumerator()
						i = 0
						While enumerator.MoveNext()
							Dim obj5 As Object = enumerator.Current
							xmlNode3 = CType(obj5, XmlNode)
							RSWIN_DESC.rst.xSurfLoad(i) = Util.ConvertToSingle(xmlNode3("r:surface-load").InnerText)
							RSWIN_DESC.rst.xSurfPos(i) = Util.ConvertToSingle(xmlNode3("r:surface-position").InnerText)
							i += 1
						End While
					Else
						RSWIN_DESC.rst.xNtsteps = 0S
					End If
				Catch ex36 As Exception
					RSWIN_DESC.rst.xNtsteps = 0S
					Dim array As Single() = New Single(0) {}
					RSWIN_DESC.rst.xSurfLoad = array
					array = New Single(0) {}
					RSWIN_DESC.rst.xSurfPos = array
				End Try
				RSWIN_DESC.rst.giFluidLevelSource = Conversions.ToShort(Util.ConvertToInt16(xmlNode2.SelectSingleNode("r:fluid-level-source", nsmgr).InnerText))
				RSWIN_DESC.rst.UPumpIntakePressure = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:u-pump-intake-pressure", nsmgr).InnerText)
				Dim flag6 As Boolean
				Try
					flag6 = False
					Dim xmlNode7 As XmlNode = xmlNode2.SelectSingleNode("r:ipr-profile", nsmgr)
					Dim innerText As String = xmlNode7.InnerText
					If Operators.CompareString(innerText, "xsi:nil", False) = 0 Then
						flag6 = True
					End If
				Catch ex37 As Exception
					flag6 = False
				End Try
				Dim num3 As Integer = Conversions.ToInteger(Util.ConvertToInt32(Conversions.ToString(xmlNode2.SelectNodes("r:ipr-profile", nsmgr).Count)))
				RSWIN_DESC.rst.gbUseIPR = (num3 <> 0 And Not flag6)
				If Not RSWIN_DESC.rst.gbUseIPR And RSWIN_DESC.rst.giFluidLevelSource <> 1S And RSWIN_DESC.rst.PumpIntakePressure > 0F Then
					RSWIN_DESC.rst.giFluidLevelSource = 2S
				End If
				If RSWIN_DESC.rst.gbUseIPR Then
					Dim xmlNode8 As XmlNode = xmlNode2.SelectSingleNode("r:ipr-profile", nsmgr)
					Try
						RSWIN_DESC.rst.BubblePoint = Util.ConvertToSingle(xmlNode8.SelectSingleNode("r:bubble-point-pressure", nsmgr).InnerText)
					Catch ex38 As Exception
					End Try
					Try
						RSWIN_DESC.rst.gbCalcFetkovichN = Conversions.ToBoolean(xmlNode8.SelectSingleNode("r:calc-fetkovich-n", nsmgr).InnerText)
					Catch ex39 As Exception
						RSWIN_DESC.rst.gbCalcFetkovichN = True
					End Try
					Try
						RSWIN_DESC.rst.gbProducingBelowBPP = Conversions.ToBoolean(xmlNode8.SelectSingleNode("r:producing-below-bubble-point", nsmgr).InnerText)
					Catch ex40 As Exception
						RSWIN_DESC.rst.gbProducingBelowBPP = False
					End Try
					Try
						RSWIN_DESC.rst.giIPRMethod = CShort(Conversions.ToInteger(MRodstarXML.DoLookup(MRodstarXML.mnLookupIPRCorrelation, xmlNode8.SelectSingleNode("r:ipr-correlation", nsmgr).InnerText)))
					Catch ex41 As Exception
					End Try
					Try
						RSWIN_DESC.rst.FetkovichN = Util.ConvertToSingle(xmlNode8.SelectSingleNode("r:fetkovich-n", nsmgr).InnerText)
					Catch ex42 As Exception
						RSWIN_DESC.rst.FetkovichN = -1F
					End Try
					Try
						RSWIN_DESC.rst.MidPerfDepth = Util.ConvertToSingle(xmlNode8.SelectSingleNode("r:mid-perf-depth", nsmgr).InnerText)
					Catch ex43 As Exception
					End Try
					Try
						RSWIN_DESC.rst.StaticBHPressure = Util.ConvertToSingle(xmlNode8.SelectSingleNode("r:static-bottom-hole-pressure", nsmgr).InnerText)
					Catch ex44 As Exception
					End Try
					xmlNodeList = xmlNode8.SelectNodes(".//r:ipr-test-point", nsmgr)
					Dim xmlNodeList8 As XmlNodeList = xmlNodeList
					RSWIN_DESC.rst.gnTestPoints = CShort(xmlNodeList8.Count)
					Dim testPoints As RSWIN_DESC.IPRTESTPOINT() = New RSWIN_DESC.IPRTESTPOINT(CInt((RSWIN_DESC.rst.gnTestPoints + 1S)) - 1) {}
					RSWIN_DESC.rst.TestPoints = testPoints
					enumerator = xmlNodeList8.GetEnumerator()
					i = 1
					While enumerator.MoveNext()
						Dim obj6 As Object = enumerator.Current
						xmlNode3 = CType(obj6, XmlNode)
						RSWIN_DESC.rst.TestPoints(i).Production = Util.ConvertToSingle(xmlNode3("r:fluid-production").InnerText)
						RSWIN_DESC.rst.TestPoints(i).bPIEntered = If(-If(((xmlNode3("r:flowing-wellbore-pressure") Is Nothing) > False), 1S, 0S), 1S, 0S)
						If RSWIN_DESC.rst.TestPoints(i).bPIEntered <> 0S Then
							RSWIN_DESC.rst.TestPoints(i).Pintake = Util.ConvertToSingle(xmlNode3("r:pump-intake-pressure").InnerText)
						Else
							RSWIN_DESC.rst.TestPoints(i).Pwf = Util.ConvertToSingle(xmlNode3("r:flowing-wellbore-pressure").InnerText)
						End If
						i += 1
					End While
					xmlNode8 = Nothing
				End If
				If RSWIN_DESC.rst.gnTestPoints = 0S Or ((RSWIN_DESC.rst.gbUseIPR And RSWIN_DESC.rst.gnTestPoints = 0S) Or RSWIN_DESC.rst.MidPerfDepth = 0F Or RSWIN_DESC.rst.StaticBHPressure = 0F) Then
					Dim testPoints As RSWIN_DESC.IPRTESTPOINT() = New RSWIN_DESC.IPRTESTPOINT(0) {}
					RSWIN_DESC.rst.TestPoints = testPoints
				End If
				Try
					RSWIN_DESC.rst.FileComment = Convert.ToString(xmlNode2.SelectSingleNode("r:comment", nsmgr).InnerText)
				Catch ex45 As Exception
					RSWIN_DESC.rst.FileComment = ""
				End Try
				Try
					RSWIN_DESC.rst.MeasuredTVLoad = Util.ConvertToSingle(xmlNode3("r:measured-TV-load").InnerText)
				Catch ex46 As Exception
					RSWIN_DESC.rst.MeasuredSVLoad = 0F
				End Try
				Try
					RSWIN_DESC.rst.MeasuredSVLoad = Util.ConvertToSingle(xmlNode3("r:measured-SV-load").InnerText)
				Catch ex47 As Exception
					RSWIN_DESC.rst.MeasuredSVLoad = 0F
				End Try
				If RSWIN_DESC.rst.MeasuredSVLoad < 100F Then
					RSWIN_DESC.rst.MeasuredSVLoad = 0F
				End If
				Try
					RSWIN_DESC.rst.gbIncludeBuoyancy = MRodstarXML.CheckBoolean(xmlNode2.SelectSingleNode("r:include-buoyancy", nsmgr).InnerText)
				Catch ex48 As Exception
					RSWIN_DESC.rst.gbIncludeBuoyancy = False
				End Try
				Try
					RSWIN_DESC.rst.gbCalcFriction = (Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:calc-friction", nsmgr).InnerText) <> 0F)
				Catch ex49 As Exception
					RSWIN_DESC.rst.gbCalcFriction = True
				End Try
				Try
					RSWIN_DESC.rst.gbCalcFluidSPGR = Conversions.ToBoolean(Util.ConvertToInt16(xmlNode2.SelectSingleNode("r:calc-fluid-spgr", nsmgr).InnerText))
				Catch ex50 As Exception
					RSWIN_DESC.rst.gbCalcFluidSPGR = False
				End Try
				Dim cRODSTAR As cRODSTAR
				Dim num5 As Integer
				Dim numRods As Integer

					Try
						RSWIN_DESC.rst.gbClampOn = If((-If((MRodstarXML.CheckBoolean(xmlNode2.SelectSingleNode("r:clamp-on", nsmgr).InnerText) > False), 1S, 0S)), 1S, 0S)
					Catch ex51 As Exception
						RSWIN_DESC.rst.gbClampOn = 0S
					End Try
					Try
						RSWIN_DESC.rst.giDynoCorrectKinematic = Conversions.ToShort(Util.ConvertToInt16(xmlNode2.SelectSingleNode("r:dyno-correct-kinematic", nsmgr).InnerText))
					Catch ex52 As Exception
						RSWIN_DESC.rst.giDynoCorrectKinematic = 0S
					End Try
					Try
						RSWIN_DESC.rst.giDynoCorrectPhase = Conversions.ToShort(Util.ConvertToInt16(xmlNode2.SelectSingleNode("r:dyno-correct-phase", nsmgr).InnerText))
					Catch ex53 As Exception
						RSWIN_DESC.rst.giDynoCorrectPhase = 0S
					End Try
					Try
						RSWIN_DESC.rst.gfDynoPhaseAdjustment = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:dyno-phase-adjustment", nsmgr).InnerText)
					Catch ex54 As Exception
						RSWIN_DESC.rst.gfDynoPhaseAdjustment = 0F
					End Try
					Try
						RSWIN_DESC.rst.gfDynoTOSAdjustment = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:dyno-TOS-adjustment", nsmgr).InnerText)
					Catch ex55 As Exception
						RSWIN_DESC.rst.gfDynoTOSAdjustment = 0F
					End Try
					Try
						RSWIN_DESC.rst.giDynoDetectKinematic = Conversions.ToShort(Util.ConvertToInt16(xmlNode2.SelectSingleNode("r:dyno-detect-kinematic", nsmgr).InnerText))
					Catch ex56 As Exception
						RSWIN_DESC.rst.giDynoDetectKinematic = -1S
					End Try
					Try
						RSWIN_DESC.rst.giDynoDetectPhase = Conversions.ToShort(Util.ConvertToInt16(xmlNode2.SelectSingleNode("r:dyno-detect-phase", nsmgr).InnerText))
					Catch ex57 As Exception
						RSWIN_DESC.rst.giDynoDetectPhase = -1S
					End Try
					If Single.IsNaN(RSWIN_DESC.rst.gfDynoLoadAdjustment) Then
						RSWIN_DESC.rst.gfDynoLoadAdjustment = 0F
					End If
					If RSWIN_DESC.rst.PU.UnitType = 8S Then
						Try
							RSWIN_DESC.rst.bUnknownUnbalance = MRodstarXML.CheckBoolean(xmlNode2.SelectSingleNode("r:beam-balanced", nsmgr).InnerText)
						Catch ex58 As Exception
							RSWIN_DESC.rst.bUnknownUnbalance = False
						End Try
					End If
					Dim num4 As Single
					Select Case RSWIN_DESC.rst.PU.UnitType
						Case 6S
							If RSWIN_DESC.rst.CBDataType <> 1S Or RSWIN_DESC.rst.UnknownM Then
								RSWIN_DESC.rst.Counterbalance = 0F
							End If
							num4 = 1F
						Case 7S
							If RSWIN_DESC.rst.CBDataType <> 1S Or RSWIN_DESC.rst.UnknownM Then
								RSWIN_DESC.rst.Counterbalance = 0F
							End If
							num4 = 1000F
						Case 8S
							RSWIN_DESC.rst.Counterbalance = 0F
							num4 = 1F
						Case Else
							If RSWIN_DESC.rst.CBDataType <> 1S Or RSWIN_DESC.rst.UnknownM Then
								RSWIN_DESC.rst.Counterbalance = 0F
							End If
							num4 = 1000F
					End Select
					If RSWIN_DESC.rst.CBDataType = 1S AndAlso Not RSWIN_DESC.rst.UnknownM AndAlso RSWIN_DESC.rst.get_M(2) / num4 <> 0F Then
						RSWIN_DESC.rst.Counterbalance = RSWIN_DESC.rst.get_M(2) / num4
					End If
					If RSWIN_DESC.rst.PU.CrankHole = 0S Then
						Dim pu2 As RSWIN_DESC.PUDataRec
						pu2.Initialize()
						pu2 = RSWIN_DESC.rst.PU
						pu2.CrankRadii(0) = RSWIN_DESC.rst.PU.R
						If pu2.CrankHoles = 0S Then
							pu2.CrankHoles = 1S
						End If
						pu2.CrankHole = 1S
						kinemat.Kinconst(pu2)
						kinemat.Unitstroke(pu2)
						pu2.Strokes(0) = CSng(Conversion.Int(CDbl(pu2.KinematicStroke) + 0.5))
						RSWIN_DESC.rst.PU = pu2
					End If
					RSWIN_DESC.rst.Iart = RSWIN_DESC.rst.PU.ArtInertia
					Try
						RSWIN_DESC.rst.StuffingBoxFriction = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:stuffing-box-friction", nsmgr).InnerText)
					Catch ex59 As Exception
						RSWIN_DESC.rst.StuffingBoxFriction = 100F
					End Try
					Try
						RSWIN_DESC.rst.PR_Diameter = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:polished-rod-diameter", nsmgr).InnerText)
						If RSWIN_DESC.rst.PR_Diameter = 0F Then
							RSWIN_DESC.rst.PR_Diameter = 1.5F
						End If
					Catch ex60 As Exception
						RSWIN_DESC.rst.PR_Diameter = 1.5F
					End Try
					Dim motorInfo As Object = Motor.GetMotorInfo(4)
					If Conversions.ToBoolean(If((Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo, 1, False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo, 7, False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo, 8, False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo, 9, False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo, 10, False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo, 11, False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo, 12, False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo, 13, False))), True, False)) Then
						RSWIN_DESC.rst.MotorSPV = 0F
						RSWIN_DESC.rst.CalcMotorSPV = 0S
					ElseIf Conversions.ToBoolean(If((Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo, 3, False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo, 2, False)) OrElse Conversions.ToBoolean(Operators.CompareObjectEqual(motorInfo, 4, False))), True, False)) Then
						RSWIN_DESC.rst.MotorSPV = 0F
						RSWIN_DESC.rst.CalcMotorSPV = -1S
					End If
					cRODSTAR = RSWIN_DESC.rst
					num5 = 1
					numRods = CInt(cRODSTAR.NumRods)

				i = num5
				While i <= numRods
					Try
						If RSWIN_DESC.rst.Sections(i).Elasticity = 0F Then
							RODUTIL.LookupElasticity(RSWIN_DESC.rst.Sections(i))
						End If
						If RSWIN_DESC.rst.Sections(i).Area = 0F Then
							' The following expression was wrapped in a unchecked-expression
							RSWIN_DESC.rst.Sections(i).Area = CSng((3.141592653589793 * Math.Pow(CDbl(RSWIN_DESC.rst.Sections(i).Diameter), 2.0) / 4.0))
						End If
						If RSWIN_DESC.rst.Sections(i).RodWeight = 0F Then
							RODUTIL.LookupRodWeight(RSWIN_DESC.rst.Sections(i))
						End If
						If RSWIN_DESC.rst.Sections(i).TensileStrength = 0F Then
							RODUTIL.LookupTensileStrength(RSWIN_DESC.rst.Sections(i))
						End If
						If cRODSTAR.Sections(i).RodDensity = 0F Then
							If cRODSTAR.Sections(i).Grade = 20481S Then
								cRODSTAR.Sections(i).RodDensity = 100F
							ElseIf cRODSTAR.Sections(i).Grade = 16393S Then
								cRODSTAR.Sections(i).RodDensity = 125F
							ElseIf RODUTIL.IsFG(cRODSTAR.Sections(i).Grade) Then
								cRODSTAR.Sections(i).RodDensity = 130F
							Else
								cRODSTAR.Sections(i).RodDensity = 491F
							End If
						End If
					Catch ex61 As Exception
					End Try
					i += 1
				End While
				cRODSTAR = Nothing
				xmlNode2 = Nothing
				Try
					LoadXDG.CheckXDGInputData(Conversions.ToString(True))
				Catch ex62 As Exception
					Return False
				End Try
				result = True
			Catch ex63 As Exception
				Dim sMsg As String = "Error in LoadInputFile: " + ex63.Message
				Dim sMsgType As String = "Error"
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
				result = False
			End Try
			Return result
		End Function

		Private Function LoadInputXML_XDIAG_Save(ByRef xmlDoc As XmlDocument, ByRef nsmgr As XmlNamespaceManager, bDeviated As Boolean) As Boolean
			Dim text As String = New String(" "c, 40)
			Dim sMotorSizeName As String = ""
			Dim sMotorSettingName As String = ""
			Dim flag As Boolean = True
			Dim result As Boolean
			Try
				Dim xmlNode As XmlNode = xmlDoc.SelectSingleNode("//r:input", nsmgr)
				Dim xmlNode2 As XmlNode = xmlNode
				RSWIN_DESC.rst.ACompanyName = New String(" "c, 40)
				RSWIN_DESC.rst.ACompanyName = Convert.ToString(xmlNode2.SelectSingleNode("r:company-name", nsmgr).InnerText)
				RSWIN_DESC.rst.WellName = New String(" "c, 40)
				RSWIN_DESC.rst.WellName = Convert.ToString(xmlNode2.SelectSingleNode("r:well-name", nsmgr).InnerText)
				RSWIN_DESC.rst.UserName = New String(" "c, 40)
				RSWIN_DESC.rst.UserName = Convert.ToString(xmlNode2.SelectSingleNode("r:user-name", nsmgr).InnerText)
				RSWIN_DESC.rst.UserDate = New String(" "c, 40)
				RSWIN_DESC.rst.UserDate = Convert.ToString(xmlNode2.SelectSingleNode("r:date", nsmgr).InnerText)
				RSWIN_DESC.rst.PumpDepth = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:pump-depth", nsmgr).InnerText)
				RSWIN_DESC.rst.FluidLevel = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:fluid-level", nsmgr).InnerText)
				If RSWIN_DESC.rst.FluidLevel > RSWIN_DESC.rst.PumpDepth Then
					RSWIN_DESC.rst.FluidLevel = RSWIN_DESC.rst.PumpDepth
				End If
				RSWIN_DESC.rst.SPM = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:pumping-speed", nsmgr).InnerText)
				If RSWIN_DESC.rst.SPM > 0F Then
					RSWIN_DESC.rst.SPMEntered = -1S
				End If
				RSWIN_DESC.rst.Runtime = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:runtime", nsmgr).InnerText)
				RSWIN_DESC.rst.DynaSource = Conversions.ToShort(Util.ConvertToInt16(xmlNode2.SelectSingleNode("r:dyno-source", nsmgr).InnerText))
				RSWIN_DESC.rst.DynaFile = Convert.ToString(xmlNode2.SelectSingleNode("r:dyno-file", nsmgr).InnerText)
				RSWIN_DESC.rst.DynoDate = ""
				RSWIN_DESC.rst.DynoDate = Convert.ToString(xmlNode2.SelectSingleNode("r:dyno-date", nsmgr).InnerText)
				RSWIN_DESC.rst.LeutertDynamometer = Conversions.ToShort(Util.ConvertToInt16(xmlNode2.SelectSingleNode("r:leutert-dynamometer", nsmgr).InnerText))
				RSWIN_DESC.rst.LeutertModel = Convert.ToString(xmlNode2.SelectSingleNode("r:leutert-model", nsmgr).InnerText)
				RSWIN_DESC.rst.LeutertSpring = Conversions.ToShort(Util.ConvertToInt16(xmlNode2.SelectSingleNode("r:leutert-spring", nsmgr).InnerText))
				RSWIN_DESC.rst.LeutertScale = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:leutert-scale", nsmgr).InnerText)
				RSWIN_DESC.rst.MeasuredStroke = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:measured-stroke", nsmgr).InnerText)
				RSWIN_DESC.rst.PumpType = CShort(Conversions.ToInteger(MRodstarXML.DoLookup(MRodstarXML.mnLookupPumpType, xmlNode2.SelectSingleNode("r:pump-type", nsmgr).InnerText)))
				Try
					RSWIN_DESC.rst.VSP = MRodstarXML.CheckBoolean(xmlNode2.SelectSingleNode("r:vsp", nsmgr).InnerText)
				Catch ex As Exception
					RSWIN_DESC.rst.VSP = False
				End Try
				RSWIN_DESC.rst.PlungerSize = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:plunger-size", nsmgr).InnerText)
				RSWIN_DESC.rst.WaterCut = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:water-cut", nsmgr).InnerText)
				RSWIN_DESC.rst.WaterSPGR = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:water-spgr", nsmgr).InnerText)
				If RSWIN_DESC.rst.WaterSPGR < 1F Then
					RSWIN_DESC.rst.WaterSPGR = 1F
				ElseIf CDbl(RSWIN_DESC.rst.WaterSPGR) > 1.5 Then
					RSWIN_DESC.rst.WaterSPGR = 1.5F
				End If
				RSWIN_DESC.rst.OilAPI = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:oil-density", nsmgr).InnerText)
				RSWIN_DESC.rst.OilSPGR = CSng((141.5 / CDbl(RSWIN_DESC.rst.OilAPI) + 131.5))
				RSWIN_DESC.rst.FluidSPGR = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:fluid-spgr", nsmgr).InnerText)
				RSWIN_DESC.rst.Friction = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:friction", nsmgr).InnerText)
				RSWIN_DESC.rst.TubingOD = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:tubing-od", nsmgr).InnerText)
				RSWIN_DESC.rst.TubingID = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:tubing-id", nsmgr).InnerText)
				RSWIN_DESC.rst.TubingAnchored = Conversions.ToShort(Util.ConvertToInt16(xmlNode2.SelectSingleNode("r:tubing-anchored", nsmgr).InnerText))
				RSWIN_DESC.rst.TubingAnchorDepth = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:tubing-anchor-depth", nsmgr).InnerText)
				RSWIN_DESC.rst.TubingPressure = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:tubing-pressure", nsmgr).InnerText)
				RSWIN_DESC.rst.CasingPressure = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:casing-pressure", nsmgr).InnerText)
				Dim xmlNodeList As XmlNodeList = xmlNode2.SelectNodes("r:rod-tapers/r:rod-taper", nsmgr)
				Dim xmlNodeList2 As XmlNodeList = xmlNodeList
				RSWIN_DESC.rst.NumRods = CShort(xmlNodeList2.Count)
				Dim i As Integer = 1
				Dim enumerator As IEnumerator = xmlNodeList2.GetEnumerator()
				Dim xmlNode3 As XmlNode
				While enumerator.MoveNext()
					Dim rodSection As RSWIN_DESC.RodSection = Nothing
					rodSection.Initialize()
					xmlNode3 = CType(enumerator.Current, XmlNode)
					Dim text2 As String
					Try
						text2 = xmlNode3("r:rodtype-corod").InnerText
					Catch ex2 As Exception
						text2 = ""
					End Try
					Dim text3 As String
					Try
						text3 = xmlNode3("r:rodtype-prorod").InnerText
					Catch ex3 As Exception
						text3 = ""
					End Try
					Dim text4 As String
					Try
						text4 = xmlNode3("r:rodtype-fiberglass").InnerText
					Catch ex4 As Exception
						text4 = ""
					End Try
					Dim text5 As String
					Try
						text5 = xmlNode3("r:rodtype-ribbonrod").InnerText
					Catch ex5 As Exception
						text5 = ""
					End Try
					Dim text6 As String
					Try
						text6 = xmlNode3("r:rodtype-sinkerbar").InnerText
					Catch ex6 As Exception
						text6 = ""
					End Try
					Dim text7 As String
					Try
						text7 = xmlNode3("r:rodtype-steel").InnerText
					Catch ex7 As Exception
						text7 = ""
					End Try
					Dim flag2 As Boolean = True
					If flag2 = (text2.Length <> 0) Then
						Dim obj As Object = Conversions.ToInteger(MRodstarXML.DoLookup(MRodstarXML.new_mnLookupRodGrade, xmlNode3("r:rodtype-corod").InnerText))
						If Operators.ConditionalCompareObjectEqual(obj, 0, False) Then
							rodSection.Grade = CShort(Conversions.ToInteger(MRodstarXML.DoLookup(MRodstarXML.mnLookupRodGrade, xmlNode3("r:rodtype-corod").InnerText)))
						Else
							rodSection.Grade = Conversions.ToShort(obj)
						End If
						Try
							Dim grade As Short = rodSection.Grade
							Dim flag3 As Boolean = RODUTIL.ConvertRodGrade(rodSection) <> 0
							GoTo IL_B36
						Catch ex8 As Exception
							Dim grade As Short
							rodSection.Grade = grade
							GoTo IL_B36
						End Try
						GoTo IL_791
					End If
					GoTo IL_791
					IL_B36:
					rodSection.Diameter = Util.ConvertToSingle(xmlNode3("r:taper-size").InnerText)
					rodSection.length = Util.ConvertToSingle(xmlNode3("r:taper-length").InnerText)
					If RSWIN_DESC.bRodStarD Then
						Try
							rodSection.Guide = Conversions.ToShort(Util.ConvertToInt16(xmlNode3("r:taper-guide").InnerText))
						Catch ex9 As Exception
						End Try
					End If
					Try
						rodSection.TensileStrength = Util.ConvertToSingle(xmlNode3("r:taper-tensile-strength").InnerText)
					Catch ex10 As Exception
						If rodSection.Grade <> 0S Then
							RODUTIL.LookupTensileStrength(rodSection)
						Else
							rodSection.TensileStrength = 0F
						End If
					End Try
					Try
						rodSection.StressMethod = Conversions.ToShort(Util.ConvertToInt16(xmlNode3("r:taper-stress-method").InnerText))
					Catch ex11 As Exception
						If rodSection.Grade <> 0S Then
							RODUTIL.LookupStressMethod(rodSection)
						Else
							rodSection.StressMethod = 0S
						End If
					End Try
					Try
						If RSWIN_DESC.SETUP_ALLOWSLIDEFRIC <> 0S Then
							rodSection.friction_coef = Util.ConvertToSingle(xmlNode3("r:taper-friction-coef").InnerText)
						Else
							rodSection.friction_coef = RSWIN_DESC.rst.SlideFricCoeff
						End If
					Catch ex12 As Exception
						rodSection.friction_coef = 0.2F
					End Try
					RSWIN_DESC.rst.Sections(i) = rodSection
					Dim flag4 As Boolean = True
					If flag4 = (RSWIN_DESC.rst.Sections(i).Grade = 16385S) Then
						GoTo IL_D21
					End If
					If flag4 = (RSWIN_DESC.rst.Sections(i).Grade = 16389S) Then
						GoTo IL_D21
					End If
					If flag4 = (RSWIN_DESC.rst.Sections(i).Grade = 16390S) Then
						GoTo IL_D21
					End If
					If flag4 = (RODUTIL.IsSteel(CInt(RSWIN_DESC.rst.Sections(i).Grade)) <> 0) Then
						RSWIN_DESC.rst.Sections(i).SuckerRodLength = RSWIN_DESC.SETUP_SteelSuckerRodLength
					ElseIf flag4 = ((If(-If((RODUTIL.IsCorod(RSWIN_DESC.rst.Sections(i).Grade) > False), 1, 0), 1, 0) Or RODUTIL.IsProRod(CInt(RSWIN_DESC.rst.Sections(i).Grade))) <> 0) Then
						RSWIN_DESC.rst.Sections(i).SuckerRodLength = 1F
					Else
						RSWIN_DESC.rst.Sections(i).SuckerRodLength = 25F
					End If
					IL_DFA:
					i += 1
					Continue While
					IL_D21:
					RSWIN_DESC.rst.Sections(i).SuckerRodLength = 37.5F
					GoTo IL_DFA
					IL_791:
					If flag2 = (text3.Length <> 0) Then
						Dim obj As Object = Conversions.ToInteger(MRodstarXML.DoLookup(MRodstarXML.new_mnLookupRodGrade, xmlNode3("r:rodtype-prorod").InnerText))
						If Operators.ConditionalCompareObjectEqual(obj, 0, False) Then
							rodSection.Grade = CShort(Conversions.ToInteger(MRodstarXML.DoLookup(MRodstarXML.mnLookupRodGrade, xmlNode3("r:rodtype-prorod").InnerText)))
							GoTo IL_B36
						End If
						rodSection.Grade = Conversions.ToShort(obj)
						GoTo IL_B36
					ElseIf flag2 = (text4.Length <> 0) Then
						Dim obj As Object = Conversions.ToInteger(MRodstarXML.DoLookup(MRodstarXML.new_mnLookupRodGrade, xmlNode3("r:rodtype-fiberglass").InnerText))
						If Operators.ConditionalCompareObjectEqual(obj, 0, False) Then
							rodSection.Grade = CShort(Conversions.ToInteger(MRodstarXML.DoLookup(MRodstarXML.mnLookupRodGrade, xmlNode3("r:rodtype-fiberglass").InnerText)))
						Else
							rodSection.Grade = Conversions.ToShort(obj)
						End If
						If rodSection.Grade = 0S Then
							rodSection.Grade = Conversions.ToShort(MRodstarXML.DoCustomFGRodGradeLookup(Conversions.ToInteger(xmlNode3("r:rodtype-fiberglass").InnerText)))
							GoTo IL_B36
						End If
						GoTo IL_B36
					ElseIf flag2 = (text5.Length <> 0) Then
						rodSection.Grade = CShort(Conversions.ToInteger(MRodstarXML.DoLookup(MRodstarXML.mnLookupRodGrade, xmlNode3("r:rodtype-ribbonrod").InnerText)))
						Dim obj As Object = Conversions.ToInteger(MRodstarXML.DoLookup(MRodstarXML.new_mnLookupRodGrade, xmlNode3("r:rodtype-ribbonrod").InnerText))
						If Operators.ConditionalCompareObjectEqual(obj, 0, False) Then
							rodSection.Grade = CShort(Conversions.ToInteger(MRodstarXML.DoLookup(MRodstarXML.mnLookupRodGrade, xmlNode3("r:rodtype-ribbonrod").InnerText)))
							GoTo IL_B36
						End If
						rodSection.Grade = Conversions.ToShort(obj)
						GoTo IL_B36
					ElseIf flag2 = (text6.Length <> 0) Then
						rodSection.Grade = CShort(Conversions.ToInteger(MRodstarXML.DoLookup(MRodstarXML.mnLookupRodGrade, xmlNode3("r:rodtype-sinkerbar").InnerText)))
						Dim obj As Object = Conversions.ToInteger(MRodstarXML.DoLookup(MRodstarXML.new_mnLookupRodGrade, xmlNode3("r:rodtype-sinkerbar").InnerText))
						If Operators.ConditionalCompareObjectEqual(obj, 0, False) Then
							rodSection.Grade = CShort(Conversions.ToInteger(MRodstarXML.DoLookup(MRodstarXML.mnLookupRodGrade, xmlNode3("r:rodtype-sinkerbar").InnerText)))
						Else
							rodSection.Grade = Conversions.ToShort(obj)
						End If
						If rodSection.Grade = 0S Then
							rodSection.Grade = CShort(MRodstarXML.DoCustomSinkerBarRodGradeLookup(xmlNode3("r:rodtype-sinkerbar").InnerText))
							GoTo IL_B36
						End If
						GoTo IL_B36
					Else
						If flag2 <> (text7.Length <> 0) Then
							GoTo IL_B36
						End If
						Dim obj As Object = Conversions.ToInteger(MRodstarXML.DoLookup(MRodstarXML.new_mnLookupRodGrade, xmlNode3("r:rodtype-steel").InnerText))
						If Operators.ConditionalCompareObjectEqual(obj, 0, False) Then
							rodSection.Grade = CShort(Conversions.ToInteger(MRodstarXML.DoLookup(MRodstarXML.mnLookupRodGrade, xmlNode3("r:rodtype-steel").InnerText)))
						Else
							rodSection.Grade = Conversions.ToShort(obj)
						End If
						If rodSection.Grade <> 0S Then
							GoTo IL_B36
						End If
						rodSection.Grade = CShort(MRodstarXML.DoCustomSteelRodGradeLookup(xmlNode3("r:rodtype-steel").InnerText))
						If rodSection.Grade = 0S And text7.Trim().Length <> 0 Then
							rodSection.RodType = text7
							GoTo IL_B36
						End If
						GoTo IL_B36
					End If
				End While
				RSWIN_DESC.rst.ServiceFactor = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:service-factor", nsmgr).InnerText)
				Dim pu As RSWIN_DESC.PUDataRec
				pu.Initialize()
				RSWIN_DESC.rst.PU.Initialize()
				Try
					Dim xmlNode4 As XmlNode = xmlNode2.SelectSingleNode("r:pumpingunit", nsmgr)
					Dim flag5 As Boolean = True
					Dim xmlNode5 As XmlNode
					If flag5 = xmlNode4.SelectNodes("r:pumpingunit-airbalanced", nsmgr).Count > 0 Then
						pu.UnitType = 6S
						xmlNode5 = xmlNode4.SelectSingleNode("r:pumpingunit-airbalanced", nsmgr)
					ElseIf flag5 = xmlNode4.SelectNodes("r:pumpingunit-conventional", nsmgr).Count > 0 Then
						pu.UnitType = 1S
						xmlNode5 = xmlNode4.SelectSingleNode("r:pumpingunit-conventional", nsmgr)
					ElseIf flag5 = xmlNode4.SelectNodes("r:pumpingunit-beambalanced", nsmgr).Count > 0 Then
						pu.UnitType = 8S
						xmlNode5 = xmlNode4.SelectSingleNode("r:pumpingunit-beambalanced", nsmgr)
					ElseIf flag5 = xmlNode4.SelectNodes("r:pumpingunit-beltlowprofile", nsmgr).Count > 0 Then
						pu.UnitType = 9S
						xmlNode5 = xmlNode4.SelectSingleNode("r:pumpingunit-beltlowprofile", nsmgr)
					ElseIf flag5 = xmlNode4.SelectNodes("r:pumpingunit-grooves", nsmgr).Count > 0 Then
						pu.UnitType = 3S
						xmlNode5 = xmlNode4.SelectSingleNode("r:pumpingunit-grooves", nsmgr)
					ElseIf flag5 = xmlNode4.SelectNodes("r:pumpingunit-enhanced", nsmgr).Count > 0 Then
						pu.UnitType = 2S
						xmlNode5 = xmlNode4.SelectSingleNode("r:pumpingunit-enhanced", nsmgr)
					ElseIf flag5 = xmlNode4.SelectNodes("r:pumpingunit-longstroke", nsmgr).Count > 0 Then
						pu.UnitType = 7S
						xmlNode5 = xmlNode4.SelectSingleNode("r:pumpingunit-longstroke", nsmgr)
					ElseIf flag5 = xmlNode4.SelectNodes("r:pumpingunit-hydraulic", nsmgr).Count > 0 Then
						pu.UnitType = 10S
						xmlNode5 = xmlNode4.SelectSingleNode("r:pumpingunit-hydraulic", nsmgr)
					ElseIf flag5 = xmlNode4.SelectNodes("r:pumpingunit-lowprofile", nsmgr).Count > 0 Then
						pu.UnitType = 4S
						xmlNode5 = xmlNode4.SelectSingleNode("r:pumpingunit-lowprofile", nsmgr)
					ElseIf flag5 = xmlNode4.SelectNodes("r:pumpingunit-markii", nsmgr).Count > 0 Then
						pu.UnitType = 5S
						xmlNode5 = xmlNode4.SelectSingleNode("r:pumpingunit-markii", nsmgr)
					End If
					Dim xmlNode6 As XmlNode = xmlNode5
					xmlNode3 = xmlNode6.SelectSingleNode("r:pumping-unit-id", nsmgr)
					If xmlNode3 IsNot Nothing Then
						RSWIN_DESC.rst.IDEntered = -1S
						RSWIN_DESC.rst.UnitID = Convert.ToString(xmlNode6.SelectSingleNode("r:pumping-unit-id", nsmgr).InnerText)
					Else
						RSWIN_DESC.rst.IDEntered = 0S
						RSWIN_DESC.rst.UnitID = ""
					End If
					If(RSWIN_DESC.rst.IDEntered And If(-If((Strings.InStr(RSWIN_DESC.rst.UnitID, "CUSTOM", CompareMethod.Binary) > 0 > False), 1S, 0S), 1S, 0S)) <> 0S Then
						MRodstarXML.bCustomPU = True
					End If
					xmlNode3 = xmlNode6.SelectSingleNode("r:crank-rotation", nsmgr)
					pu.CrankRotation = CShort(Conversions.ToInteger(MRodstarXML.DoLookup(MRodstarXML.mnLookupCrankRotation, xmlNode6.SelectSingleNode("r:crank-rotation", nsmgr).InnerText)))
					Try
						pu.CrankHole = Conversions.ToShort(Util.ConvertToInt16(xmlNode6.SelectSingleNode("r:crank-hole-number", nsmgr).InnerText))
					Catch ex13 As Exception
					End Try
					If pu.UnitType <> 7S AndAlso pu.CrankHole = 0S Then
						pu.CrankHole = 1S
					End If
					If RSWIN_DESC.rst.IDEntered <> 0S Then
						RSWIN_DESC.rst.UnitID = Convert.ToString(xmlNode6.SelectSingleNode("r:pumping-unit-id", nsmgr).InnerText)
						If Strings.InStr(RSWIN_DESC.rst.UnitID, "CUSTOM", CompareMethod.Binary) > 0 Then
							MRodstarXML.bCustomPU = True
						End If
					End If
					Try
						RSWIN_DESC.rst.Unbalance = Util.ConvertToSingle(xmlNode6.SelectSingleNode("r:structural-unbalance", nsmgr).InnerText)
					Catch ex14 As Exception
						RSWIN_DESC.rst.Unbalance = 0F
					End Try
					If MRodstarXML.bCustomPU Then
						pu.APIDesignation = Convert.ToString(xmlNode6.SelectSingleNode("r:api-designation", nsmgr).InnerText)
						pu.Manuf = Convert.ToString(xmlNode6.SelectSingleNode("r:pumping-unit-manufacturer", nsmgr).InnerText)
						pu.OtherInfo = Convert.ToString(xmlNode6.SelectSingleNode("r:pumping-unit-other-info", nsmgr).InnerText)
						pu.UnitName = Convert.ToString(xmlNode6.SelectSingleNode("r:pumping-unit-name", nsmgr).InnerText)
						If pu.Manuf.Length < 40 Then
							pu.Manuf = pu.Manuf.PadRight(40)
						End If
						If pu.APIDesignation.Length < 40 Then
							pu.APIDesignation = pu.APIDesignation.PadRight(40)
						End If
						If pu.UnitName.Length < 40 Then
							pu.UnitName = pu.UnitName.PadRight(40)
						End If
						If pu.OtherInfo.Length < 40 Then
							pu.OtherInfo = pu.OtherInfo.PadRight(40)
						End If
						Try
							pu.StructRating = Util.ConvertToSingle(xmlNode6.SelectSingleNode("r:pumping-unit-struct-rating", nsmgr).InnerText)
						Catch ex15 As Exception
							MRodstarXML.bErrorCustomPU = True
						End Try
						Try
							pu.GearboxRating = Util.ConvertToSingle(xmlNode6.SelectSingleNode("r:pumping-unit-gearbox-rating", nsmgr).InnerText)
						Catch ex16 As Exception
							MRodstarXML.bErrorCustomPU = True
						End Try
						Try
							pu.MaxStroke = Util.ConvertToSingle(xmlNode6.SelectSingleNode("r:pumping-unit-max-stroke", nsmgr).InnerText)
						Catch ex17 As Exception
							MRodstarXML.bErrorCustomPU = True
						End Try
						Try
							pu.ArtInertia = Util.ConvertToSingle(xmlNode6.SelectSingleNode("r:pumping-unit-art-inertia", nsmgr).InnerText)
						Catch ex18 As Exception
							MRodstarXML.bErrorCustomPU = True
						End Try
						If pu.UnitType = 7S Then
							pu.DrumDiamRatio = Util.ConvertToSingle(xmlNode6.SelectSingleNode("r:drum-diameter-ratio", nsmgr).InnerText)
							pu.P = Util.ConvertToSingle(xmlNode6.SelectSingleNode("r:pitman-arm-length", nsmgr).InnerText)
							pu.SprocketDistance = Util.ConvertToSingle(xmlNode6.SelectSingleNode("r:sprocket-distance", nsmgr).InnerText)
							pu.SprocketRadius = Util.ConvertToSingle(xmlNode6.SelectSingleNode("r:sprocket-diameter", nsmgr).InnerText) / 2F
							If pu.CrankRadii Is Nothing Then
								pu.CrankRadii = New Single(4) {}
							End If
							If pu.Strokes Is Nothing Then
								pu.Strokes = New Single(4) {}
							End If
							pu.CrankHoles = 1S
							pu.CrankHole = 1S
						Else
							xmlNodeList = xmlNode6.SelectNodes("r:pu-crank-radii/r:crank-radius", nsmgr)
							Dim xmlNodeList3 As XmlNodeList = xmlNodeList
							pu.CrankHoles = CShort(xmlNodeList3.Count)
							enumerator = xmlNodeList3.GetEnumerator()
							If pu.CrankRadii Is Nothing Then
								pu.CrankRadii = New Single(4) {}
							End If
							If pu.Strokes Is Nothing Then
								pu.Strokes = New Single(4) {}
							End If
							i = 1
							While enumerator.MoveNext()
								Dim obj2 As Object = enumerator.Current
								xmlNode3 = CType(obj2, XmlNode)
								pu.CrankRadii(i - 1) = Util.ConvertToSingle(xmlNode3("r:pu-apidimension-r").InnerText)
								pu.Strokes(i - 1) = Util.ConvertToSingle(xmlNode3("r:nominal-stroke-length").InnerText)
								i += 1
							End While
							pu.A = Util.ConvertToSingle(xmlNode6.SelectSingleNode("r:pu-apidimension-a", nsmgr).InnerText)
							pu.C = Util.ConvertToSingle(xmlNode6.SelectSingleNode("r:pu-apidimension-c", nsmgr).InnerText)
							pu.I = Util.ConvertToSingle(xmlNode6.SelectSingleNode("r:pu-apidimension-i", nsmgr).InnerText)
							pu.K = Util.ConvertToSingle(xmlNode6.SelectSingleNode("r:pu-apidimension-k", nsmgr).InnerText)
							pu.P = Util.ConvertToSingle(xmlNode6.SelectSingleNode("r:pu-apidimension-p", nsmgr).InnerText)
							If pu.UnitType <> 6S Then
								pu.CrankOffset = Util.ConvertToSingle(xmlNode6.SelectSingleNode("r:crank-offset-angle", nsmgr).InnerText)
							Else
								pu.M = Util.ConvertToSingle(xmlNode6.SelectSingleNode("r:pu-apidimension-m", nsmgr).InnerText)
								pu.S = Util.ConvertToSingle(xmlNode6.SelectSingleNode("r:pu-apidimension-s", nsmgr).InnerText)
								pu.V0 = Util.ConvertToSingle(xmlNode6.SelectSingleNode("r:pu-apidimension-v0", nsmgr).InnerText)
							End If
							pu.Unbalance = Util.ConvertToSingle(xmlNode6.SelectSingleNode("r:structural-unbalance", nsmgr).InnerText)
						End If
					End If
					xmlNode6 = Nothing
				Catch ex19 As Exception
				End Try
				Application.DoEvents()
				Application.DoEvents()
				RSWIN_DESC.rst.PU = pu
				If pu.UnitType = 8S Then
					Try
						RSWIN_DESC.rst.bUnknownUnbalance = MRodstarXML.CheckBoolean(xmlNode2.SelectSingleNode("r:beam-balanced", nsmgr).InnerText)
					Catch ex20 As Exception
						RSWIN_DESC.rst.bUnknownUnbalance = False
					End Try
				End If
				RSWIN_DESC.rst.ElectricityCost = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:electricity-cost", nsmgr).InnerText)
				RSWIN_DESC.rst.PowerMeterType = CShort(Conversions.ToInteger(MRodstarXML.DoLookup(MRodstarXML.mnLookupPowerMeterType, xmlNode2.SelectSingleNode("r:power-meter-type", nsmgr).InnerText)))
				RSWIN_DESC.rst.CalcMotorSize = Conversions.ToShort(Util.ConvertToInt16(xmlNode2.SelectSingleNode("r:calc-motor-size", nsmgr).InnerText))
				Dim num As Integer = Conversions.ToInteger(Util.ConvertToInt32(xmlNode2.SelectSingleNode("r:motor-kind", nsmgr).InnerText))
				sMotorSizeName = xmlNode2.SelectSingleNode("r:motor-size", nsmgr).InnerText
				sMotorSettingName = xmlNode2.SelectSingleNode("r:motor-setting", nsmgr).InnerText
				If num > 7 Then
					Motor.CorrectMotorSizeSettingName(num + 1, sMotorSizeName)
					Motor.CorrectMotorSizeSettingName(num + 1, sMotorSettingName)
				End If
				Motor.SelectMotorKind(num)
				Motor.SelectMotorSizeByName(sMotorSizeName)
				Motor.SelectMotorSettingByName(sMotorSettingName)
				Dim count As Integer = xmlNode2.SelectNodes("r:max-existing-counterbalance", nsmgr).Count
				RSWIN_DESC.rst.UnknownM = Conversions.ToBoolean(Interaction.IIf(count = 0, True, False))
				Try
					RSWIN_DESC.rst.CBDataType = Conversions.ToShort(xmlNode2.SelectSingleNode("r:cb-datatype", nsmgr).InnerText)
				Catch ex21 As Exception
					RSWIN_DESC.rst.CBDataType = 0S
				End Try
				If RSWIN_DESC.rst.UnknownM Then
					RSWIN_DESC.rst.set_M(2, 0F)
				Else
					Try
						RSWIN_DESC.rst.set_M(2, Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:max-existing-counterbalance", nsmgr).InnerText))
						If RSWIN_DESC.rst.get_M(2) > 0F And RSWIN_DESC.rst.CBDataType = 0S Then
							RSWIN_DESC.rst.CBDataType = 1S
						End If
					Catch ex22 As Exception
						RSWIN_DESC.rst.set_M(2, 0F)
						RSWIN_DESC.rst.UnknownM = True
					End Try
				End If
				RSWIN_DESC.rst.UnknownM = (RSWIN_DESC.rst.get_M(2) = 0F)
				Try
					RSWIN_DESC.rst.CBDataType = Conversions.ToShort(xmlNode2.SelectSingleNode("r:cb-datatype", nsmgr).InnerText)
				Catch ex23 As Exception
					RSWIN_DESC.rst.CBDataType = 0S
				End Try
				Try
					RSWIN_DESC.rst.CBEffect = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:cb-effect", nsmgr).InnerText)
				Catch ex24 As Exception
					RSWIN_DESC.rst.CBEffect = 0F
				End Try
				Try
					RSWIN_DESC.rst.CBAngle = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:cb-angle", nsmgr).InnerText)
					If RSWIN_DESC.rst.CBEffect > 0F And RSWIN_DESC.rst.CBAngle > 0F And RSWIN_DESC.rst.get_M(2) = 0F Then
						RSWIN_DESC.rst.CBDataType = 2S
					End If
				Catch ex25 As Exception
					RSWIN_DESC.rst.CBAngle = 0F
				End Try
				If RSWIN_DESC.rst.UnknownM Then
					RSWIN_DESC.rst.set_M(2, 0F)
				Else
					Try
						RSWIN_DESC.rst.set_M(2, Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:max-existing-counterbalance", nsmgr).InnerText))
						If RSWIN_DESC.rst.get_M(2) > 0F And RSWIN_DESC.rst.CBDataType = 0S Then
							RSWIN_DESC.rst.CBDataType = 1S
						End If
					Catch ex26 As Exception
						RSWIN_DESC.rst.set_M(2, 0F)
						RSWIN_DESC.rst.UnknownM = True
					End Try
				End If
				RSWIN_DESC.rst.CBDataFile = Convert.ToString(xmlNode2.SelectSingleNode("r:cbalance-file", nsmgr).InnerText)
				MImpred.InitSurveyDataset(RSWIN_DESC.mdsDeviationProfile, Nothing)
				If bDeviated And RSWIN_DESC.bRodStarD Then
					Dim xmlNodeList4 As XmlNodeList = xmlNode2.SelectNodes("r:deviation-survey", nsmgr)
					If xmlNodeList4.Count > 0 Then
						xmlNodeList = xmlNode2.SelectNodes("r:deviation-survey/r:survey-point", nsmgr)
						Dim xmlNodeList5 As XmlNodeList = xmlNodeList
						Dim count2 As Integer = xmlNodeList5.Count
						enumerator = xmlNodeList5.GetEnumerator()
						i = 0
						If xmlNodeList5.Count > 0 Then
						End If
						While enumerator.MoveNext()
							Dim obj3 As Object = enumerator.Current
							xmlNode3 = CType(obj3, XmlNode)
							Console.WriteLine(xmlNode3.InnerText)
							Dim dataRow As DataRow = RSWIN_DESC.mdsDeviationProfile.Tables(0).NewRow()
							dataRow("EntryNumber") = i + 1
							dataRow("Depth") = Util.ConvertToSingle(xmlNode3("r:measured-depth").InnerText)
							dataRow("Inclination") = Util.CheckDec(xmlNode3("r:inclination").InnerText)
							dataRow("Azimuth") = Util.CheckDec(xmlNode3("r:azimuth").InnerText)
							dataRow("Dogleg") = DBNull.Value
							dataRow("TVDepth") = DBNull.Value
							dataRow("NorthSouth") = DBNull.Value
							dataRow("EastWest") = DBNull.Value
							RSWIN_DESC.mdsDeviationProfile.Tables(0).Rows.Add(dataRow)
							i += 1
						End While
					End If
				End If
				RSWIN_DESC.mdsDeviationProfile_Edit = Nothing
				count = xmlNode2.SelectNodes("r:measured-dynamometer-card", nsmgr).Count
				Try
					xmlNodeList = xmlNode2.SelectNodes(".//r:measured-dynamometer-card-point", nsmgr)
					Dim xmlNodeList6 As XmlNodeList = xmlNodeList
					RSWIN_DESC.rst.dNtsteps = CShort(xmlNodeList6.Count)
					Dim array As Single() = New Single(CInt((RSWIN_DESC.rst.dNtsteps - 1S + 1S)) - 1) {}
					RSWIN_DESC.rst.dSurfLoad = array
					array = New Single(CInt((RSWIN_DESC.rst.dNtsteps - 1S + 1S)) - 1) {}
					RSWIN_DESC.rst.dSurfPos = array
					If RSWIN_DESC.rst.dNtsteps > 0S Then
						enumerator = xmlNodeList6.GetEnumerator()
						i = 0
						While enumerator.MoveNext()
							Dim obj4 As Object = enumerator.Current
							xmlNode3 = CType(obj4, XmlNode)
							RSWIN_DESC.rst.dSurfLoad(i) = Util.ConvertToSingle(xmlNode3("r:surface-load").InnerText)
							RSWIN_DESC.rst.dSurfPos(i) = Util.ConvertToSingle(xmlNode3("r:surface-position").InnerText)
							i += 1
						End While
					Else
						RSWIN_DESC.rst.dNtsteps = 0S
					End If
				Catch ex27 As Exception
					RSWIN_DESC.rst.dNtsteps = 0S
					Dim array As Single() = New Single(0) {}
					RSWIN_DESC.rst.dSurfLoad = array
					array = New Single(0) {}
					RSWIN_DESC.rst.dSurfPos = array
				End Try
				If flag Then
					Try
						RSWIN_DESC.rst.PumpEfficiency = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:pump-efficiency", nsmgr).InnerText)
					Catch ex28 As Exception
						RSWIN_DESC.rst.PumpEfficiency = 0F
					End Try
					Try
						RSWIN_DESC.rst.MotorSPV = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:motor-speed-variation", nsmgr).InnerText)
					Catch ex29 As Exception
						RSWIN_DESC.rst.MotorSPV = 0F
					End Try
					Try
						RSWIN_DESC.rst.UpstrokeFriction = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:rod-tubing-friction-upstroke", nsmgr).InnerText)
					Catch ex30 As Exception
					End Try
					Try
						RSWIN_DESC.rst.DownstrokeFriction = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:rod-tubing-friction-downstroke", nsmgr).InnerText)
					Catch ex31 As Exception
					End Try
					Try
						RSWIN_DESC.rst.CompressibilityIndex = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:compressibility-index", nsmgr).InnerText)
					Catch ex32 As Exception
						RSWIN_DESC.rst.CompressibilityIndex = 3F
					End Try
				End If
				count = xmlNode2.SelectNodes("r:xdiag-dynamometer-card", nsmgr).Count
				Try
					xmlNodeList = xmlNode2.SelectNodes(".//r:xdiag-dynamometer-card-point", nsmgr)
					Dim xmlNodeList7 As XmlNodeList = xmlNodeList
					RSWIN_DESC.rst.Ntsteps = CShort(xmlNodeList7.Count)
					Dim array As Single() = New Single(CInt((RSWIN_DESC.rst.Ntsteps - 1S + 1S)) - 1) {}
					RSWIN_DESC.rst.SurfLoad = array
					array = New Single(CInt((RSWIN_DESC.rst.Ntsteps - 1S + 1S)) - 1) {}
					RSWIN_DESC.rst.SurfPos = array
					If RSWIN_DESC.rst.Ntsteps > 0S Then
						enumerator = xmlNodeList7.GetEnumerator()
						i = 0
						While enumerator.MoveNext()
							Dim obj5 As Object = enumerator.Current
							xmlNode3 = CType(obj5, XmlNode)
							RSWIN_DESC.rst.SurfLoad(i) = Util.ConvertToSingle(xmlNode3("r:surface-load").InnerText)
							RSWIN_DESC.rst.SurfPos(i) = Util.ConvertToSingle(xmlNode3("r:surface-position").InnerText)
							i += 1
						End While
					Else
						RSWIN_DESC.rst.Ntsteps = 0S
					End If
				Catch ex33 As Exception
					RSWIN_DESC.rst.Ntsteps = 0S
					Dim array As Single() = New Single(0) {}
					RSWIN_DESC.rst.SurfLoad = array
					array = New Single(0) {}
					RSWIN_DESC.rst.SurfPos = array
				End Try
				RSWIN_DESC.rst.giFluidLevelSource = Conversions.ToShort(Util.ConvertToInt16(xmlNode2.SelectSingleNode("r:fluid-level-source", nsmgr).InnerText))
				RSWIN_DESC.rst.UPumpIntakePressure = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:u-pump-intake-pressure", nsmgr).InnerText)
				Dim flag6 As Boolean
				Try
					flag6 = False
					Dim xmlNode7 As XmlNode = xmlNode2.SelectSingleNode("r:ipr-profile", nsmgr)
					Dim innerText As String = xmlNode7.InnerText
					If Operators.CompareString(innerText, "xsi:nil", False) = 0 Then
						flag6 = True
					End If
				Catch ex34 As Exception
					flag6 = False
				End Try
				Dim num2 As Integer = Conversions.ToInteger(Util.ConvertToInt32(Conversions.ToString(xmlNode2.SelectNodes("r:ipr-profile", nsmgr).Count)))
				RSWIN_DESC.rst.gbUseIPR = (num2 <> 0 And Not flag6)
				If Not RSWIN_DESC.rst.gbUseIPR And RSWIN_DESC.rst.giFluidLevelSource <> 1S And RSWIN_DESC.rst.PumpIntakePressure > 0F Then
					RSWIN_DESC.rst.giFluidLevelSource = 2S
				End If
				If RSWIN_DESC.rst.gbUseIPR Then
					Dim xmlNode8 As XmlNode = xmlNode2.SelectSingleNode("r:ipr-profile", nsmgr)
					Try
						RSWIN_DESC.rst.BubblePoint = Util.ConvertToSingle(xmlNode8.SelectSingleNode("r:bubble-point-pressure", nsmgr).InnerText)
					Catch ex35 As Exception
					End Try
					Try
						RSWIN_DESC.rst.gbCalcFetkovichN = Conversions.ToBoolean(xmlNode8.SelectSingleNode("r:calc-fetkovich-n", nsmgr).InnerText)
					Catch ex36 As Exception
						RSWIN_DESC.rst.gbCalcFetkovichN = True
					End Try
					Try
						RSWIN_DESC.rst.gbProducingBelowBPP = Conversions.ToBoolean(xmlNode8.SelectSingleNode("r:producing-below-bubble-point", nsmgr).InnerText)
					Catch ex37 As Exception
						RSWIN_DESC.rst.gbProducingBelowBPP = False
					End Try
					Try
						RSWIN_DESC.rst.giIPRMethod = CShort(Conversions.ToInteger(MRodstarXML.DoLookup(MRodstarXML.mnLookupIPRCorrelation, xmlNode8.SelectSingleNode("r:ipr-correlation", nsmgr).InnerText)))
					Catch ex38 As Exception
					End Try
					Try
						RSWIN_DESC.rst.FetkovichN = Util.ConvertToSingle(xmlNode8.SelectSingleNode("r:fetkovich-n", nsmgr).InnerText)
					Catch ex39 As Exception
						RSWIN_DESC.rst.FetkovichN = -1F
					End Try
					Try
						RSWIN_DESC.rst.MidPerfDepth = Util.ConvertToSingle(xmlNode8.SelectSingleNode("r:mid-perf-depth", nsmgr).InnerText)
					Catch ex40 As Exception
					End Try
					Try
						RSWIN_DESC.rst.StaticBHPressure = Util.ConvertToSingle(xmlNode8.SelectSingleNode("r:static-bottom-hole-pressure", nsmgr).InnerText)
					Catch ex41 As Exception
					End Try
					xmlNodeList = xmlNode8.SelectNodes(".//r:ipr-test-point", nsmgr)
					Dim xmlNodeList8 As XmlNodeList = xmlNodeList
					RSWIN_DESC.rst.gnTestPoints = CShort(xmlNodeList8.Count)
					Dim testPoints As RSWIN_DESC.IPRTESTPOINT() = New RSWIN_DESC.IPRTESTPOINT(CInt((RSWIN_DESC.rst.gnTestPoints + 1S)) - 1) {}
					RSWIN_DESC.rst.TestPoints = testPoints
					enumerator = xmlNodeList8.GetEnumerator()
					i = 1
					While enumerator.MoveNext()
						Dim obj6 As Object = enumerator.Current
						xmlNode3 = CType(obj6, XmlNode)
						RSWIN_DESC.rst.TestPoints(i).Production = Util.ConvertToSingle(xmlNode3("r:fluid-production").InnerText)
						RSWIN_DESC.rst.TestPoints(i).bPIEntered = If(-If(((xmlNode3("r:flowing-wellbore-pressure") Is Nothing) > False), 1S, 0S), 1S, 0S)
						If RSWIN_DESC.rst.TestPoints(i).bPIEntered <> 0S Then
							RSWIN_DESC.rst.TestPoints(i).Pintake = Util.ConvertToSingle(xmlNode3("r:pump-intake-pressure").InnerText)
						Else
							RSWIN_DESC.rst.TestPoints(i).Pwf = Util.ConvertToSingle(xmlNode3("r:flowing-wellbore-pressure").InnerText)
						End If
						i += 1
					End While
					xmlNode8 = Nothing
				End If
				If RSWIN_DESC.rst.gnTestPoints = 0S Or ((RSWIN_DESC.rst.gbUseIPR And RSWIN_DESC.rst.gnTestPoints = 0S) Or RSWIN_DESC.rst.MidPerfDepth = 0F Or RSWIN_DESC.rst.StaticBHPressure = 0F) Then
					Dim testPoints As RSWIN_DESC.IPRTESTPOINT() = New RSWIN_DESC.IPRTESTPOINT(0) {}
					RSWIN_DESC.rst.TestPoints = testPoints
				End If
				Try
					RSWIN_DESC.rst.FileComment = Convert.ToString(xmlNode2.SelectSingleNode("r:comment", nsmgr).InnerText)
				Catch ex42 As Exception
					RSWIN_DESC.rst.FileComment = ""
				End Try
				Try
					RSWIN_DESC.rst.MeasuredTVLoad = Util.ConvertToSingle(xmlNode3("r:measured-TV-load").InnerText)
				Catch ex43 As Exception
					RSWIN_DESC.rst.MeasuredSVLoad = 0F
				End Try
				Try
					RSWIN_DESC.rst.MeasuredSVLoad = Util.ConvertToSingle(xmlNode3("r:measured-SV-load").InnerText)
				Catch ex44 As Exception
					RSWIN_DESC.rst.MeasuredSVLoad = 0F
				End Try
				If RSWIN_DESC.rst.MeasuredSVLoad < 100F Then
					RSWIN_DESC.rst.MeasuredSVLoad = 0F
				End If
				Try
					RSWIN_DESC.rst.gbIncludeBuoyancy = MRodstarXML.CheckBoolean(xmlNode2.SelectSingleNode("r:include-buoyancy", nsmgr).InnerText)
				Catch ex45 As Exception
					RSWIN_DESC.rst.gbIncludeBuoyancy = False
				End Try
				Try
					RSWIN_DESC.rst.gbCalcFriction = (Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:calc-friction", nsmgr).InnerText) <> 0F)
				Catch ex46 As Exception
					RSWIN_DESC.rst.gbCalcFriction = True
				End Try
				Try
					RSWIN_DESC.rst.gbCalcFluidSPGR = Conversions.ToBoolean(Util.ConvertToInt16(xmlNode2.SelectSingleNode("r:calc-fluid-spgr", nsmgr).InnerText))
				Catch ex47 As Exception
					RSWIN_DESC.rst.gbCalcFluidSPGR = False
				End Try
				Dim cRODSTAR As cRODSTAR
				Dim num4 As Integer
				Dim numRods As Integer

					Try
						RSWIN_DESC.rst.gbClampOn = If((-If((MRodstarXML.CheckBoolean(xmlNode2.SelectSingleNode("r:clamp-on", nsmgr).InnerText) > False), 1S, 0S)), 1S, 0S)
					Catch ex48 As Exception
						RSWIN_DESC.rst.gbClampOn = 0S
					End Try
					Try
						RSWIN_DESC.rst.giDynoCorrectKinematic = Conversions.ToShort(Util.ConvertToInt16(xmlNode2.SelectSingleNode("r:dyno-correct-kinematic", nsmgr).InnerText))
					Catch ex49 As Exception
						RSWIN_DESC.rst.giDynoCorrectKinematic = 0S
					End Try
					Try
						RSWIN_DESC.rst.giDynoCorrectPhase = Conversions.ToShort(Util.ConvertToInt16(xmlNode2.SelectSingleNode("r:dyno-correct-phase", nsmgr).InnerText))
					Catch ex50 As Exception
						RSWIN_DESC.rst.giDynoCorrectPhase = 0S
					End Try
					Try
						RSWIN_DESC.rst.gfDynoPhaseAdjustment = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:dyno-phase-adjustment", nsmgr).InnerText)
					Catch ex51 As Exception
						RSWIN_DESC.rst.gfDynoPhaseAdjustment = 0F
					End Try
					Try
						RSWIN_DESC.rst.gfDynoTOSAdjustment = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:dyno-TOS-adjustment", nsmgr).InnerText)
					Catch ex52 As Exception
						RSWIN_DESC.rst.gfDynoTOSAdjustment = 0F
					End Try
					Try
						RSWIN_DESC.rst.giDynoDetectKinematic = Conversions.ToShort(Util.ConvertToInt16(xmlNode2.SelectSingleNode("r:dyno-detect-kinematic", nsmgr).InnerText))
					Catch ex53 As Exception
						RSWIN_DESC.rst.giDynoDetectKinematic = -1S
					End Try
					Try
						RSWIN_DESC.rst.giDynoDetectPhase = Conversions.ToShort(Util.ConvertToInt16(xmlNode2.SelectSingleNode("r:dyno-detect-phase", nsmgr).InnerText))
					Catch ex54 As Exception
						RSWIN_DESC.rst.giDynoDetectPhase = -1S
					End Try
					If Single.IsNaN(RSWIN_DESC.rst.gfDynoLoadAdjustment) Then
						RSWIN_DESC.rst.gfDynoLoadAdjustment = 0F
					End If
					If RSWIN_DESC.rst.PU.UnitType = 8S Then
						Try
							RSWIN_DESC.rst.bUnknownUnbalance = MRodstarXML.CheckBoolean(xmlNode2.SelectSingleNode("r:beam-balanced", nsmgr).InnerText)
						Catch ex55 As Exception
							RSWIN_DESC.rst.bUnknownUnbalance = False
						End Try
					End If
					Dim num3 As Single
					Select Case RSWIN_DESC.rst.PU.UnitType
						Case 6S
							If RSWIN_DESC.rst.CBDataType <> 1S Or RSWIN_DESC.rst.UnknownM Then
								RSWIN_DESC.rst.Counterbalance = 0F
							End If
							num3 = 1F
						Case 7S
							If RSWIN_DESC.rst.CBDataType <> 1S Or RSWIN_DESC.rst.UnknownM Then
								RSWIN_DESC.rst.Counterbalance = 0F
							End If
							num3 = 1000F
						Case 8S
							RSWIN_DESC.rst.Counterbalance = 0F
							num3 = 1F
						Case Else
							If RSWIN_DESC.rst.CBDataType <> 1S Or RSWIN_DESC.rst.UnknownM Then
								RSWIN_DESC.rst.Counterbalance = 0F
							End If
							num3 = 1000F
					End Select
					If RSWIN_DESC.rst.CBDataType = 1S AndAlso Not RSWIN_DESC.rst.UnknownM AndAlso RSWIN_DESC.rst.get_M(2) / num3 <> 0F Then
						RSWIN_DESC.rst.Counterbalance = RSWIN_DESC.rst.get_M(2) / num3
					End If
					If RSWIN_DESC.rst.PU.CrankHole = 0S Then
						Dim pu2 As RSWIN_DESC.PUDataRec
						pu2.Initialize()
						pu2 = RSWIN_DESC.rst.PU
						pu2.CrankRadii(0) = RSWIN_DESC.rst.PU.R
						If pu2.CrankHoles = 0S Then
							pu2.CrankHoles = 1S
						End If
						pu2.CrankHole = 1S
						kinemat.Kinconst(pu2)
						kinemat.Unitstroke(pu2)
						pu2.Strokes(0) = CSng(Conversion.Int(CDbl(pu2.KinematicStroke) + 0.5))
						RSWIN_DESC.rst.PU = pu2
					End If
					RSWIN_DESC.rst.Iart = RSWIN_DESC.rst.PU.ArtInertia
					Try
						RSWIN_DESC.rst.StuffingBoxFriction = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:stuffing-box-friction", nsmgr).InnerText)
					Catch ex56 As Exception
						RSWIN_DESC.rst.StuffingBoxFriction = 100F
					End Try
					Try
						RSWIN_DESC.rst.PR_Diameter = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:polished-rod-diameter", nsmgr).InnerText)
						If RSWIN_DESC.rst.PR_Diameter = 0F Then
							RSWIN_DESC.rst.PR_Diameter = 1.5F
						End If
					Catch ex57 As Exception
						RSWIN_DESC.rst.PR_Diameter = 1.5F
					End Try
					cRODSTAR = RSWIN_DESC.rst
					num4 = 1
					numRods = CInt(cRODSTAR.NumRods)

				i = num4
				While i <= numRods
					Try
						If RSWIN_DESC.rst.Sections(i).Elasticity = 0F Then
							RODUTIL.LookupElasticity(RSWIN_DESC.rst.Sections(i))
						End If
						If RSWIN_DESC.rst.Sections(i).Area = 0F Then
							' The following expression was wrapped in a unchecked-expression
							RSWIN_DESC.rst.Sections(i).Area = CSng((3.141592653589793 * Math.Pow(CDbl(RSWIN_DESC.rst.Sections(i).Diameter), 2.0) / 4.0))
						End If
						If RSWIN_DESC.rst.Sections(i).RodWeight = 0F Then
							RODUTIL.LookupRodWeight(RSWIN_DESC.rst.Sections(i))
						End If
						If RSWIN_DESC.rst.Sections(i).TensileStrength = 0F Then
							RODUTIL.LookupTensileStrength(RSWIN_DESC.rst.Sections(i))
						End If
						If cRODSTAR.Sections(i).RodDensity = 0F Then
							If cRODSTAR.Sections(i).Grade = 20481S Then
								cRODSTAR.Sections(i).RodDensity = 100F
							ElseIf cRODSTAR.Sections(i).Grade = 16393S Then
								cRODSTAR.Sections(i).RodDensity = 125F
							ElseIf RODUTIL.IsFG(cRODSTAR.Sections(i).Grade) Then
								cRODSTAR.Sections(i).RodDensity = 130F
							Else
								cRODSTAR.Sections(i).RodDensity = 491F
							End If
						End If
					Catch ex58 As Exception
					End Try
					i += 1
				End While
				cRODSTAR = Nothing
				xmlNode2 = Nothing
				Try
					LoadXDG.CheckXDGInputData(Conversions.ToString(True))
				Catch ex59 As Exception
					Return False
				End Try
				result = True
			Catch ex60 As Exception
				Dim sMsg As String = "Error in LoadInputFile: " + ex60.Message
				Dim sMsgType As String = "Error"
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
				result = False
			End Try
			Return result
		End Function

		Private Sub LoadOutputXML_XDIAG(ByRef xmlDoc As XmlDocument, ByRef nsmgr As XmlNamespaceManager, ByRef bOutputLoaded As Boolean)
			bOutputLoaded = False
			Dim flag As Boolean = False
			Try
				Dim xmlNode As XmlNode = xmlDoc.SelectSingleNode("//r:output", nsmgr)
				Dim dateTime As DateTime
				If xmlNode IsNot Nothing Then
					flag = True
					Dim xmlNode2 As XmlNode = xmlNode
					dateTime = Conversions.ToDate(Convert.ToString(xmlNode2.SelectSingleNode("r:xpat-db-filedate", nsmgr).InnerText))
					RSWIN_DESC.rst.ThisVersion = CShort(Math.Round(CDbl(Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:calculation-version", nsmgr).InnerText))))
					RSWIN_DESC.rst.BPDsurface = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:bpd-surface", nsmgr).InnerText)
					RSWIN_DESC.rst.UFeetFromSurface = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:u-feet-from-surface", nsmgr).InnerText)
					RSWIN_DESC.rst.UFeetOverPump = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:u-feet-over-pump", nsmgr).InnerText)
					RSWIN_DESC.rst.UFluidLoad = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:u-fluid-load", nsmgr).InnerText)
					RSWIN_DESC.rst.GrossPumpStroke = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:gross-pump-stroke", nsmgr).InnerText)
					RSWIN_DESC.rst.MaxRodStressL = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:max-rod-stress-loading", nsmgr).InnerText)
					RSWIN_DESC.rst.MinMotorHP = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:min-motor-hp", nsmgr).InnerText)
					RSWIN_DESC.rst.Mprload = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:mprload", nsmgr).InnerText)
					RSWIN_DESC.rst.UNetProduction = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:u-net-production", nsmgr).InnerText)
					RSWIN_DESC.rst.UNetStrokeApparent = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:u-net-stroke-apparent", nsmgr).InnerText)
					RSWIN_DESC.rst.UNetStroke = RSWIN_DESC.rst.UNetStrokeApparent
					RSWIN_DESC.rst.Ntsteps = CShort(Math.Round(CDbl(Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:ntsteps", nsmgr).InnerText))))
					RSWIN_DESC.rst.NtstepsUpstroke = CShort(Math.Round(CDbl(Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:ntsteps-upstroke", nsmgr).InnerText))))
					RSWIN_DESC.rst.Prhp = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:prhp", nsmgr).InnerText)
					Try
						RSWIN_DESC.rst.Plhp = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:plhp", nsmgr).InnerText)
					Catch ex As Exception
						RSWIN_DESC.rst.Plhp = 0F
					End Try
					RSWIN_DESC.rst.Pprload = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:pprload", nsmgr).InnerText)
					RSWIN_DESC.rst.UPintakeFromLines = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:u-pump-intake-pressure-from-lines", nsmgr).InnerText)
					RSWIN_DESC.rst.UPumpFillage = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:u-pump-fillage", nsmgr).InnerText)
					RSWIN_DESC.rst.PumpFriction = 200F
					RSWIN_DESC.rst.StructL = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:structure-loading", nsmgr).InnerText)
					RSWIN_DESC.rst.USystemEff = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:u-system-eff", nsmgr).InnerText)
					RSWIN_DESC.rst.TotalTheta = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:total-theta", nsmgr).InnerText)
					Dim xmlNode3 As XmlNode
					Dim xmlNodeList As XmlNodeList
					Dim xmlNodeList2 As XmlNodeList

						Try
							RSWIN_DESC.rst.ULinesSetH = If((-If((MRodstarXML.CheckBoolean(xmlNode2.SelectSingleNode("r:u-lines-set-h", nsmgr).InnerText) > False), 1S, 0S)), 1S, 0S)
						Catch ex2 As Exception
							RSWIN_DESC.rst.ULinesSetH = 0S
						End Try
						Try
							RSWIN_DESC.rst.ULinesSetV = If((-If((MRodstarXML.CheckBoolean(xmlNode2.SelectSingleNode("r:u-lines-set-v", nsmgr).InnerText) > False), 1S, 0S)), 1S, 0S)
						Catch ex3 As Exception
							RSWIN_DESC.rst.ULinesSetV = 0S
						End Try
						Try
							RSWIN_DESC.rst.ULineSettingsChanged = If((-If((MRodstarXML.CheckBoolean(xmlNode2.SelectSingleNode("r:u-line-setting-changed", nsmgr).InnerText) > False), 1S, 0S)), 1S, 0S)
						Catch ex4 As Exception
							RSWIN_DESC.rst.ULineSettingsChanged = 0S
						End Try
						RSWIN_DESC.rst.XDFeetFromSurface = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:xd-feet-from-surface", nsmgr).InnerText)
						RSWIN_DESC.rst.XDFeetOverPump = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:xd-feet-over-pump", nsmgr).InnerText)
						RSWIN_DESC.rst.XDFluidLoad = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:xd-fluid-load", nsmgr).InnerText)
						Try
							RSWIN_DESC.rst.XDLinesSetH = If((-If((MRodstarXML.CheckBoolean(xmlNode2.SelectSingleNode("r:xd-lines-set-h", nsmgr).InnerText) > False), 1S, 0S)), 1S, 0S)
						Catch ex5 As Exception
							RSWIN_DESC.rst.XDLinesSetH = 0S
						End Try
						Try
							RSWIN_DESC.rst.XDLinesSetV = If((-If((MRodstarXML.CheckBoolean(xmlNode2.SelectSingleNode("r:xd-lines-set-v", nsmgr).InnerText) > False), 1S, 0S)), 1S, 0S)
						Catch ex6 As Exception
							RSWIN_DESC.rst.XDLinesSetV = 0S
						End Try
						RSWIN_DESC.rst.XDNetProduction = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:xd-net-production", nsmgr).InnerText)
						RSWIN_DESC.rst.XDNetStroke = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:xd-net-stroke", nsmgr).InnerText)
						RSWIN_DESC.rst.XDNetStrokeApparent = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:xd-net-stroke-apparent", nsmgr).InnerText)
						RSWIN_DESC.rst.XDPintakeFromLines = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:xd-pump-intake-pressure-from-lines", nsmgr).InnerText)
						RSWIN_DESC.rst.XDPumpFillage = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:xd-pump-fillage", nsmgr).InnerText)
						RSWIN_DESC.rst.XDSystemEff = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:xd-system-eff", nsmgr).InnerText)
						RSWIN_DESC.rst.WrodsInAir = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:wrods-in-air", nsmgr).InnerText)
						RSWIN_DESC.rst.WrodsInFluid = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:wrods-in-fluid", nsmgr).InnerText)
						RSWIN_DESC.rst.g_FluidPoundFluidLoad = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:fluid-pound-fluid-load", nsmgr).InnerText)
						xmlNode3 = xmlNode2.SelectSingleNode("r:cbeffect-at-90-deg", nsmgr)
						Dim xmlNode4 As XmlNode = xmlNode3
						Try
							RSWIN_DESC.rst.CBE90(2) = Util.ConvertToSingle(xmlNode4.SelectSingleNode("r:existing", nsmgr).InnerText)
							RSWIN_DESC.rst.CBE90(0) = Util.ConvertToSingle(xmlNode4.SelectSingleNode("r:min-energy", nsmgr).InnerText)
							RSWIN_DESC.rst.CBE90(1) = Util.ConvertToSingle(xmlNode4.SelectSingleNode("r:min-torque", nsmgr).InnerText)
						Catch ex7 As Exception
						End Try
						xmlNode3 = xmlNode2.SelectSingleNode("r:cyclic-load-factor", nsmgr)
						Dim xmlNode5 As XmlNode = xmlNode3
						Try
							RSWIN_DESC.rst.Clf(2) = Util.ConvertToSingle(xmlNode5.SelectSingleNode("r:existing", nsmgr).InnerText)
							RSWIN_DESC.rst.Clf(0) = Util.ConvertToSingle(xmlNode5.SelectSingleNode("r:min-energy", nsmgr).InnerText)
							RSWIN_DESC.rst.Clf(1) = Util.ConvertToSingle(xmlNode5.SelectSingleNode("r:min-torque", nsmgr).InnerText)
						Catch ex8 As Exception
						End Try
						xmlNode3 = xmlNode2.SelectSingleNode("r:cost-per-bbl-fluid", nsmgr)
						Dim xmlNode6 As XmlNode = xmlNode3
						Try
							RSWIN_DESC.rst.DollarsPerBblFluid(2) = Util.ConvertToSingle(xmlNode6.SelectSingleNode("r:existing", nsmgr).InnerText)
							RSWIN_DESC.rst.DollarsPerBblFluid(0) = Util.ConvertToSingle(xmlNode6.SelectSingleNode("r:min-energy", nsmgr).InnerText)
							RSWIN_DESC.rst.DollarsPerBblFluid(1) = Util.ConvertToSingle(xmlNode6.SelectSingleNode("r:min-torque", nsmgr).InnerText)
						Catch ex9 As Exception
						End Try
						xmlNode3 = xmlNode2.SelectSingleNode("r:cost-per-bbl-oil", nsmgr)
						Dim xmlNode7 As XmlNode = xmlNode3
						Try
							RSWIN_DESC.rst.DollarsPerBblOil(2) = Util.ConvertToSingle(xmlNode7.SelectSingleNode("r:existing", nsmgr).InnerText)
							RSWIN_DESC.rst.DollarsPerBblOil(0) = Util.ConvertToSingle(xmlNode7.SelectSingleNode("r:min-energy", nsmgr).InnerText)
							RSWIN_DESC.rst.DollarsPerBblOil(1) = Util.ConvertToSingle(xmlNode7.SelectSingleNode("r:min-torque", nsmgr).InnerText)
						Catch ex10 As Exception
						End Try
						xmlNode3 = xmlNode2.SelectSingleNode("r:monthly-electric-bill", nsmgr)
						Dim xmlNode8 As XmlNode = xmlNode3
						Try
							RSWIN_DESC.rst.set_ElectricBillperMonth(2, Util.ConvertToSingle(xmlNode8.SelectSingleNode("r:existing", nsmgr).InnerText))
							RSWIN_DESC.rst.set_ElectricBillperMonth(0, Util.ConvertToSingle(xmlNode8.SelectSingleNode("r:min-energy", nsmgr).InnerText))
							RSWIN_DESC.rst.set_ElectricBillperMonth(1, Util.ConvertToSingle(xmlNode8.SelectSingleNode("r:min-torque", nsmgr).InnerText))
						Catch ex11 As Exception
						End Try
						xmlNode3 = xmlNode2.SelectSingleNode("r:gearbox-loading", nsmgr)
						Dim xmlNode9 As XmlNode = xmlNode3
						Try
							RSWIN_DESC.rst.GearboxLoading(2) = Util.ConvertToSingle(xmlNode9.SelectSingleNode("r:existing", nsmgr).InnerText)
							RSWIN_DESC.rst.GearboxLoading(0) = Util.ConvertToSingle(xmlNode9.SelectSingleNode("r:min-energy", nsmgr).InnerText)
							RSWIN_DESC.rst.GearboxLoading(1) = Util.ConvertToSingle(xmlNode9.SelectSingleNode("r:min-torque", nsmgr).InnerText)
						Catch ex12 As Exception
						End Try
						xmlNode3 = xmlNode2.SelectSingleNode("r:hp-nema-d", nsmgr)
						Dim xmlNode10 As XmlNode = xmlNode3
						Try
							RSWIN_DESC.rst.HpNemaD(2) = Util.ConvertToSingle(xmlNode10.SelectSingleNode("r:existing", nsmgr).InnerText)
							RSWIN_DESC.rst.HpNemaD(0) = Util.ConvertToSingle(xmlNode10.SelectSingleNode("r:min-energy", nsmgr).InnerText)
							RSWIN_DESC.rst.HpNemaD(1) = Util.ConvertToSingle(xmlNode10.SelectSingleNode("r:min-torque", nsmgr).InnerText)
						Catch ex13 As Exception
						End Try
						xmlNode3 = xmlNode2.SelectSingleNode("r:hp-uhs", nsmgr)
						Dim xmlNode11 As XmlNode = xmlNode3
						Try
							RSWIN_DESC.rst.HpUhs(2) = Util.ConvertToSingle(xmlNode11.SelectSingleNode("r:existing", nsmgr).InnerText)
							RSWIN_DESC.rst.HpUhs(0) = Util.ConvertToSingle(xmlNode11.SelectSingleNode("r:min-energy", nsmgr).InnerText)
							RSWIN_DESC.rst.HpUhs(1) = Util.ConvertToSingle(xmlNode11.SelectSingleNode("r:min-torque", nsmgr).InnerText)
						Catch ex14 As Exception
						End Try
						If RSWIN_DESC.rst.PU.UnitType = 8S Then
							xmlNode3 = xmlNode2.SelectSingleNode("r:required-unbalance", nsmgr)
							Dim xmlNode12 As XmlNode = xmlNode3
							Try
								RSWIN_DESC.rst.set_RequiredUnbalance(2, Util.ConvertToSingle(xmlNode12.SelectSingleNode("r:existing", nsmgr).InnerText))
								RSWIN_DESC.rst.set_RequiredUnbalance(0, Util.ConvertToSingle(xmlNode12.SelectSingleNode("r:min-energy", nsmgr).InnerText))
								RSWIN_DESC.rst.set_RequiredUnbalance(1, Util.ConvertToSingle(xmlNode12.SelectSingleNode("r:min-torque", nsmgr).InnerText))
							Catch ex15 As Exception
							End Try
						Else
							xmlNode3 = xmlNode2.SelectSingleNode("r:maximum-counterbalance", nsmgr)
							Dim xmlNode13 As XmlNode = xmlNode3
							Try
								RSWIN_DESC.rst.set_M(2, Util.ConvertToSingle(xmlNode13.SelectSingleNode("r:existing", nsmgr).InnerText))
								RSWIN_DESC.rst.set_M(0, Util.ConvertToSingle(xmlNode13.SelectSingleNode("r:min-energy", nsmgr).InnerText))
								RSWIN_DESC.rst.set_M(1, Util.ConvertToSingle(xmlNode13.SelectSingleNode("r:min-torque", nsmgr).InnerText))
							Catch ex16 As Exception
							End Try
						End If
						xmlNode3 = xmlNode2.SelectSingleNode("r:motor-kwh", nsmgr)
						Dim xmlNode14 As XmlNode = xmlNode3
						Try
							RSWIN_DESC.rst.MotorKWH(2) = Util.ConvertToSingle(xmlNode14.SelectSingleNode("r:existing", nsmgr).InnerText)
							RSWIN_DESC.rst.MotorKWH(0) = Util.ConvertToSingle(xmlNode14.SelectSingleNode("r:min-energy", nsmgr).InnerText)
							RSWIN_DESC.rst.MotorKWH(1) = Util.ConvertToSingle(xmlNode14.SelectSingleNode("r:min-torque", nsmgr).InnerText)
						Catch ex17 As Exception
						End Try
						xmlNode3 = xmlNode2.SelectSingleNode("r:peak-gearbox-torque", nsmgr)
						Dim xmlNode15 As XmlNode = xmlNode3
						Try
							RSWIN_DESC.rst.PeakTorque(2) = Util.ConvertToSingle(xmlNode15.SelectSingleNode("r:existing", nsmgr).InnerText)
							RSWIN_DESC.rst.PeakTorque(0) = Util.ConvertToSingle(xmlNode15.SelectSingleNode("r:min-energy", nsmgr).InnerText)
							RSWIN_DESC.rst.PeakTorque(1) = Util.ConvertToSingle(xmlNode15.SelectSingleNode("r:min-torque", nsmgr).InnerText)
						Catch ex18 As Exception
						End Try
						xmlNodeList = xmlNode2.SelectNodes(".//r:net-torque-point", nsmgr)
						xmlNodeList2 = xmlNodeList

					Dim tnet As Single(,) = New Single(2, CInt((RSWIN_DESC.rst.Ntsteps - 1S + 1S)) - 1) {}
					RSWIN_DESC.rst.Tnet = tnet
					Dim enumerator As IEnumerator = xmlNodeList2.GetEnumerator()
					Dim num As Integer = 0
					While enumerator.MoveNext()
						Dim obj As Object = enumerator.Current
						xmlNode3 = CType(obj, XmlNode)
						RSWIN_DESC.rst.Tnet(2, num) = Util.ConvertToSingle(xmlNode3("r:existing").InnerText)
						RSWIN_DESC.rst.Tnet(0, num) = Util.ConvertToSingle(xmlNode3("r:min-energy").InnerText)
						RSWIN_DESC.rst.Tnet(1, num) = Util.ConvertToSingle(xmlNode3("r:min-torque").InnerText)
						num += 1
					End While
					Try
						If xmlNode2.SelectNodes("r:output-dynamometer-card", nsmgr).Count > 0 Then
							xmlNodeList = xmlNode2.SelectNodes(".//r:output-dynamometer-card-point", nsmgr)
							Dim xmlNodeList3 As XmlNodeList = xmlNodeList
							RSWIN_DESC.rst.Ntsteps = CShort(xmlNodeList3.Count)
							Dim array As Single() = New Single(CInt((RSWIN_DESC.rst.Ntsteps - 1S + 1S)) - 1) {}
							RSWIN_DESC.rst.PumpLoad = array
							array = New Single(CInt((RSWIN_DESC.rst.Ntsteps - 1S + 1S)) - 1) {}
							RSWIN_DESC.rst.PumpPos = array
							array = New Single(CInt((RSWIN_DESC.rst.Ntsteps - 1S + 1S)) - 1) {}
							RSWIN_DESC.rst.PermLoad = array
							array = New Single(CInt((RSWIN_DESC.rst.Ntsteps - 1S + 1S)) - 1) {}
							RSWIN_DESC.rst.Thetac = array
							array = New Single(CInt((RSWIN_DESC.rst.Ntsteps - 1S + 1S)) - 1) {}
							RSWIN_DESC.rst.Tf = array
							enumerator = xmlNodeList3.GetEnumerator()
							num = 0
							While enumerator.MoveNext()
								Dim obj2 As Object = enumerator.Current
								xmlNode3 = CType(obj2, XmlNode)
								RSWIN_DESC.rst.PumpLoad(num) = Util.ConvertToSingle(xmlNode3("r:pump-load").InnerText)
								RSWIN_DESC.rst.PumpPos(num) = Util.ConvertToSingle(xmlNode3("r:pump-position").InnerText)
								RSWIN_DESC.rst.PermLoad(num) = Util.ConvertToSingle(xmlNode3("r:permissible-load").InnerText)
								RSWIN_DESC.rst.Thetac(num) = Util.ConvertToSingle(xmlNode3("r:thetac").InnerText)
								RSWIN_DESC.rst.Tf(num) = Util.ConvertToSingle(xmlNode3("r:torque-factor").InnerText)
								num += 1
							End While
						End If
					Catch ex19 As Exception
					End Try
					xmlNodeList = xmlNode2.SelectNodes("r:calculated-rod-tapers/r:calculated-rod-taper", nsmgr)
					Dim xmlNodeList4 As XmlNodeList = xmlNodeList
					num = 1
					For Each obj3 As Object In xmlNodeList4
						xmlNode3 = CType(obj3, XmlNode)
						RSWIN_DESC.rst.maxStressTop(num) = Util.ConvertToSingle(xmlNode3("r:max-rod-stress-top").InnerText)
						RSWIN_DESC.rst.minStressBot(num) = Util.ConvertToSingle(xmlNode3("r:min-rod-stress-bot").InnerText)
						RSWIN_DESC.rst.minStressTop(num) = Util.ConvertToSingle(xmlNode3("r:min-rod-stress-top").InnerText)
						RSWIN_DESC.rst.StressL(num) = Util.ConvertToSingle(xmlNode3("r:rod-stress-loading").InnerText)
						num += 1
					Next
					xmlNodeList = xmlNode2.SelectNodes("r:line-settings/r:line-setting", nsmgr)
					Dim xmlNodeList5 As XmlNodeList = xmlNodeList
					num = 1
					For Each obj4 As Object In xmlNodeList5
						xmlNode3 = CType(obj4, XmlNode)
						Try
							' The following expression was wrapped in a unchecked-expression
							RSWIN_DESC.rst.LineSettings(num).LSet = If(-If((MRodstarXML.CheckBoolean(xmlNode3("r:lset").InnerText) > False), 1S, 0S), 1S, 0S)
						Catch ex20 As Exception
							RSWIN_DESC.rst.LineSettings(num).LSet = 0S
						End Try
						Try
							RSWIN_DESC.rst.LineSettings(num).Value = Util.ConvertToSingle(xmlNode3("r:lset_value").InnerText)
						Catch ex21 As Exception
							RSWIN_DESC.rst.LineSettings(num).Value = 0F
						End Try
						num += 1
					Next
					xmlNodeList = xmlNode2.SelectNodes("r:xd-line-settings/r:line-setting", nsmgr)
					Dim xmlNodeList6 As XmlNodeList = xmlNodeList
					num = 1
					For Each obj5 As Object In xmlNodeList6
						xmlNode3 = CType(obj5, XmlNode)
						Try
							' The following expression was wrapped in a unchecked-expression
							RSWIN_DESC.rst.XDLineSettings(num).LSet = If(-If((MRodstarXML.CheckBoolean(xmlNode3("r:lset").InnerText) > False), 1S, 0S), 1S, 0S)
						Catch ex22 As Exception
							RSWIN_DESC.rst.XDLineSettings(num).LSet = 0S
						End Try
						Try
							RSWIN_DESC.rst.XDLineSettings(num).Value = Util.ConvertToSingle(xmlNode3("r:lset_value").InnerText)
						Catch ex23 As Exception
							RSWIN_DESC.rst.XDLineSettings(num).Value = 0F
						End Try
						num += 1
					Next
					xmlNode3 = xmlNode2.SelectSingleNode("r:system-diagnosis", nsmgr)

						Try
							RSWIN_DESC.gSysDiag.bBentPumpBarrel = If((-If((MRodstarXML.CheckBoolean(xmlNode3("r:bBentPumpBarrel").InnerText) > False), 1S, 0S)), 1S, 0S)
							RSWIN_DESC.gSysDiag.bClamponInelegantHackHackPC = If((-If((MRodstarXML.CheckBoolean(xmlNode3("r:bClamponInelegantHackHackPC").InnerText) > False), 1S, 0S)), 1S, 0S)
							RSWIN_DESC.gSysDiag.bClamponLoadCell = If((-If((MRodstarXML.CheckBoolean(xmlNode3("r:bClamponLoadCell").InnerText) > False), 1S, 0S)), 1S, 0S)
							RSWIN_DESC.gSysDiag.bCrankHoleCorrected = If((-If((MRodstarXML.CheckBoolean(xmlNode3("r:bCrankHoleCorrected").InnerText) > False), 1S, 0S)), 1S, 0S)
							RSWIN_DESC.gSysDiag.bExtremeRodTubingFriction = If((-If((MRodstarXML.CheckBoolean(xmlNode3("r:bExtremeRodTubingFriction").InnerText) > False), 1S, 0S)), 1S, 0S)
							RSWIN_DESC.gSysDiag.bExcessiveRodTubingFriction = If((-If((MRodstarXML.CheckBoolean(xmlNode3("r:bExcessiveRodTubingFriction").InnerText) > False), 1S, 0S)), 1S, 0S)
							RSWIN_DESC.gSysDiag.bFluidInertia = If((-If((MRodstarXML.CheckBoolean(xmlNode3("r:bFluidInertia").InnerText) > False), 1S, 0S)), 1S, 0S)
							RSWIN_DESC.gSysDiag.bFluidLevelCorrected = If((-If((MRodstarXML.CheckBoolean(xmlNode3("r:bFluidLevelCorrected").InnerText) > False), 1S, 0S)), 1S, 0S)
							RSWIN_DESC.gSysDiag.bFluidPound = If((-If((MRodstarXML.CheckBoolean(xmlNode3("r:bFluidPound").InnerText) > False), 1S, 0S)), 1S, 0S)
							RSWIN_DESC.gSysDiag.bFullPump = If((-If((MRodstarXML.CheckBoolean(xmlNode3("r:bFullPump").InnerText) > False), 1S, 0S)), 1S, 0S)
							RSWIN_DESC.gSysDiag.bGasInterference = If((-If((MRodstarXML.CheckBoolean(xmlNode3("r:bGasInterference").InnerText) > False), 1S, 0S)), 1S, 0S)
							RSWIN_DESC.gSysDiag.bGasLock = If((-If((MRodstarXML.CheckBoolean(xmlNode3("r:bGasLock").InnerText) > False), 1S, 0S)), 1S, 0S)
							RSWIN_DESC.gSysDiag.bHittingDown = If((-If((MRodstarXML.CheckBoolean(xmlNode3("r:bHittingDown").InnerText) > False), 1S, 0S)), 1S, 0S)
							RSWIN_DESC.gSysDiag.bHittingUp = If((-If((MRodstarXML.CheckBoolean(xmlNode3("r:bHittingUp").InnerText) > False), 1S, 0S)), 1S, 0S)
							RSWIN_DESC.gSysDiag.bIncompleteFillage = If((-If((MRodstarXML.CheckBoolean(xmlNode3("r:bIncompleteFillage").InnerText) > False), 1S, 0S)), 1S, 0S)
							RSWIN_DESC.gSysDiag.bIncorrectFluidSPGR = If((-If((MRodstarXML.CheckBoolean(xmlNode3("r:bIncorrectFluidSPGR").InnerText) > False), 1S, 0S)), 1S, 0S)
							RSWIN_DESC.gSysDiag.bIncorrectPlungerSize = If((-If((MRodstarXML.CheckBoolean(xmlNode3("r:bIncorrectPlungerSize").InnerText) > False), 1S, 0S)), 1S, 0S)
							RSWIN_DESC.gSysDiag.bIncorrectProductionRate = If((-If((MRodstarXML.CheckBoolean(xmlNode3("r:bIncorrectProductionRate").InnerText) > False), 1S, 0S)), 1S, 0S)
							RSWIN_DESC.gSysDiag.bIncorrectSPM = If((-If((MRodstarXML.CheckBoolean(xmlNode3("r:bIncorrectSPM").InnerText) > False), 1S, 0S)), 1S, 0S)
							RSWIN_DESC.gSysDiag.bLoadShiftCorrected = If((-If((MRodstarXML.CheckBoolean(xmlNode3("r:bLoadShiftCorrected").InnerText) > False), 1S, 0S)), 1S, 0S)
							RSWIN_DESC.gSysDiag.bMalfunctioningTubingAnchor = If((-If((MRodstarXML.CheckBoolean(xmlNode3("r:bMalfunctioningTubingAnchor").InnerText) > False), 1S, 0S)), 1S, 0S)
							RSWIN_DESC.gSysDiag.bMeasuredStrokeCorrected = If((-If((MRodstarXML.CheckBoolean(xmlNode3("r:bMeasuredStrokeCorrected").InnerText) > False), 1S, 0S)), 1S, 0S)
							RSWIN_DESC.gSysDiag.bPlungerTooLarge = If((-If((MRodstarXML.CheckBoolean(xmlNode3("r:bPlungerTooLarge").InnerText) > False), 1S, 0S)), 1S, 0S)
							RSWIN_DESC.gSysDiag.bPlungerTooSmall = If((-If((MRodstarXML.CheckBoolean(xmlNode3("r:bPlungerTooSmall").InnerText) > False), 1S, 0S)), 1S, 0S)
							RSWIN_DESC.gSysDiag.bPumpConditionGood = If((-If((MRodstarXML.CheckBoolean(xmlNode3("r:bPumpConditionGood").InnerText) > False), 1S, 0S)), 1S, 0S)
							RSWIN_DESC.gSysDiag.bPumpFriction = If((-If((MRodstarXML.CheckBoolean(xmlNode3("r:bPumpFriction").InnerText) > False), 1S, 0S)), 1S, 0S)
							RSWIN_DESC.gSysDiag.bRodPart = If((-If((MRodstarXML.CheckBoolean(xmlNode3("r:bRodPart").InnerText) > False), 1S, 0S)), 1S, 0S)
							RSWIN_DESC.gSysDiag.bRodTubingFriction = If((-If((MRodstarXML.CheckBoolean(xmlNode3("r:bRodTubingFriction").InnerText) > False), 1S, 0S)), 1S, 0S)
							RSWIN_DESC.gSysDiag.bSevereDownholeProblem = If((-If((MRodstarXML.CheckBoolean(xmlNode3("r:bSevereDownholeProblem").InnerText) > False), 1S, 0S)), 1S, 0S)
							RSWIN_DESC.gSysDiag.bShallowFriction = If((-If((MRodstarXML.CheckBoolean(xmlNode3("r:bShallowFriction").InnerText) > False), 1S, 0S)), 1S, 0S)
							RSWIN_DESC.gSysDiag.bSinkerBarWaveReflection = If((-If((MRodstarXML.CheckBoolean(xmlNode3("r:bSinkerBarWaveReflection").InnerText) > False), 1S, 0S)), 1S, 0S)
							RSWIN_DESC.gSysDiag.bSPMHigh = If((-If((MRodstarXML.CheckBoolean(xmlNode3("r:bSPMHigh").InnerText) > False), 1S, 0S)), 1S, 0S)
							RSWIN_DESC.gSysDiag.bSPMLow = If((-If((MRodstarXML.CheckBoolean(xmlNode3("r:bSPMLow").InnerText) > False), 1S, 0S)), 1S, 0S)
							RSWIN_DESC.gSysDiag.bStuckPump = If((-If((MRodstarXML.CheckBoolean(xmlNode3("r:bStuckPump").InnerText) > False), 1S, 0S)), 1S, 0S)
							RSWIN_DESC.gSysDiag.bSurfaceMatchPoor = If((-If((MRodstarXML.CheckBoolean(xmlNode3("r:bSurfaceMatchPoor").InnerText) > False), 1S, 0S)), 1S, 0S)
							RSWIN_DESC.gSysDiag.bSurfPosKinematicCorrected = If((-If((MRodstarXML.CheckBoolean(xmlNode3("r:bSurfPosKinematicCorrected").InnerText) > False), 1S, 0S)), 1S, 0S)
							RSWIN_DESC.gSysDiag.bSurfPosKinematicRequired = If((-If((MRodstarXML.CheckBoolean(xmlNode3("r:bSurfPosKinematicRequired").InnerText) > False), 1S, 0S)), 1S, 0S)
							RSWIN_DESC.gSysDiag.bTubingAnchored = If((-If((MRodstarXML.CheckBoolean(xmlNode3("r:bTubingAnchored").InnerText) > False), 1S, 0S)), 1S, 0S)
							RSWIN_DESC.gSysDiag.bTubingAnchorLoose = If((-If((MRodstarXML.CheckBoolean(xmlNode3("r:bTubingAnchorLoose").InnerText) > False), 1S, 0S)), 1S, 0S)
							RSWIN_DESC.gSysDiag.bTubingLeak = If((-If((MRodstarXML.CheckBoolean(xmlNode3("r:bTubingLeak").InnerText) > False), 1S, 0S)), 1S, 0S)
							RSWIN_DESC.gSysDiag.bTubingMovement = If((-If((MRodstarXML.CheckBoolean(xmlNode3("r:bTubingMovement").InnerText) > False), 1S, 0S)), 1S, 0S)
							RSWIN_DESC.gSysDiag.bUnknownPumpCondition = If((-If((MRodstarXML.CheckBoolean(xmlNode3("r:bUnknownPumpCondition").InnerText) > False), 1S, 0S)), 1S, 0S)
							RSWIN_DESC.gSysDiag.bUpperRingValvePump = If((-If((MRodstarXML.CheckBoolean(xmlNode3("r:bUpperRingValvePump").InnerText) > False), 1S, 0S)), 1S, 0S)
							RSWIN_DESC.gSysDiag.iAdjustPhase = Conversions.ToShort(Util.ConvertToInt32(xmlNode3("r:iAdjustPhase").InnerText))
							RSWIN_DESC.gSysDiag.iCalcFrictionStatus = Conversions.ToShort(Util.ConvertToInt32(xmlNode3("r:iCalcFrictionStatus").InnerText))
							RSWIN_DESC.gSysDiag.iDiagRodPart = Conversions.ToShort(Util.ConvertToInt32(xmlNode3("r:iDiagRodPart").InnerText))
							RSWIN_DESC.gSysDiag.iOrigCrankHole = Conversions.ToShort(Util.ConvertToInt32(xmlNode3("r:iOrigCrankHole").InnerText))
							RSWIN_DESC.gSysDiag.iPumpFriction = Conversions.ToShort(Util.ConvertToInt32(xmlNode3("r:iPumpFriction").InnerText))
							RSWIN_DESC.gSysDiag.iSectFluidVelocity = Conversions.ToShort(Util.ConvertToInt32(xmlNode3("r:iSectFluidVelocity").InnerText))
							RSWIN_DESC.gSysDiag.iSVLeak = Conversions.ToInteger(Util.ConvertToInt32(xmlNode3("r:iSVLeak").InnerText))
							RSWIN_DESC.gSysDiag.iTVLeak = Conversions.ToInteger(Util.ConvertToInt32(xmlNode3("r:iTVLeak").InnerText))
							RSWIN_DESC.gSysDiag.iWornPump = Conversions.ToShort(Util.ConvertToInt32(xmlNode3("r:iWornPump").InnerText))
							RSWIN_DESC.gSysDiag.iWornPumpBarrel = Conversions.ToShort(Util.ConvertToInt32(xmlNode3("r:iWornPumpBarrel").InnerText))
							RSWIN_DESC.gSysDiag.FeetFromSurface = Util.ConvertToSingle(xmlNode3("r:FeetFromSurface").InnerText)
							RSWIN_DESC.gSysDiag.FluidSPGR = Util.ConvertToSingle(xmlNode3("r:FluidSPGR").InnerText)
							RSWIN_DESC.gSysDiag.FluidVelocity = Util.ConvertToSingle(xmlNode3("r:FluidVelocity").InnerText)
							RSWIN_DESC.gSysDiag.LoadShift = Util.ConvertToSingle(xmlNode3("r:LoadShift").InnerText)
							RSWIN_DESC.gSysDiag.LoadShiftPct = Util.ConvertToSingle(xmlNode3("r:LoadShiftPct").InnerText)
							RSWIN_DESC.gSysDiag.MeasuredStroke = Util.ConvertToSingle(xmlNode3("r:MeasuredStroke").InnerText)
							RSWIN_DESC.gSysDiag.OrigStrokeLength = Util.ConvertToSingle(xmlNode3("r:OrigStrokeLength").InnerText)
							RSWIN_DESC.gSysDiag.PhaseAdjustment = Util.ConvertToSingle(xmlNode3("r:PhaseAdjustment").InnerText)
							RSWIN_DESC.gSysDiag.PlungerSize = Util.ConvertToSingle(xmlNode3("r:PlungerSize").InnerText)
							RSWIN_DESC.gSysDiag.PumpFillage = Util.ConvertToSingle(xmlNode3("r:PumpFillage").InnerText)
							RSWIN_DESC.gSysDiag.PumpIntakePressure = Util.ConvertToSingle(xmlNode3("r:PumpIntakePressure").InnerText)
							RSWIN_DESC.gSysDiag.TubingMovement = Util.ConvertToSingle(xmlNode3("r:TubingMovement").InnerText)
						Catch ex24 As Exception
							bOutputLoaded = True
							RSWIN_DESC.rst.gbOutputLoaded = False
							Return
						End Try

					Try
						If RSWIN_DESC.mdsDeviationProfile.Tables(0).Rows.Count > 2 Then
							Try
								Dim impredObj As TEImpred = MImpred.ImpredObj
								xmlNodeList = xmlNode2.SelectNodes(".//r:rod-element-data-point", nsmgr)
								Dim xmlNodeList7 As XmlNodeList = xmlNodeList
								impredObj.num_rod_elements = xmlNodeList7.Count
								enumerator = xmlNodeList7.GetEnumerator()
								num = 0
								While enumerator.MoveNext()
									Dim obj6 As Object = enumerator.Current
									xmlNode3 = CType(obj6, XmlNode)
									Dim value As TEImpred.rod_element_data_type
									value.m_d = CDbl(Util.ConvertToDouble(xmlNode3("r:m-d").InnerText))
									value.dog = CDbl(Util.ConvertToDouble(xmlNode3("r:dog").InnerText))
									value.rad = CDbl(Util.ConvertToDouble(xmlNode3("r:rad").InnerText))
									value.ea = CDbl(Util.ConvertToDouble(xmlNode3("r:ea").InnerText))
									value.friction_coef = CDbl(Util.ConvertToDouble(xmlNode3("r:friction-coef").InnerText))
									value.mass = CDbl(Util.ConvertToDouble(xmlNode3("r:mass").InnerText))
									value.buoy_weight = CDbl(Util.ConvertToDouble(xmlNode3("r:buoy-weight").InnerText))
									value.old_force = CDbl(Util.ConvertToDouble(xmlNode3("r:old-force").InnerText))
									value.old_velocity = CDbl(Util.ConvertToDouble(xmlNode3("r:old-velocity").InnerText))
									value.friction_force = CDbl(Util.ConvertToDouble(xmlNode3("r:friction-force").InnerText))
									value.gravity_force = CDbl(Util.ConvertToDouble(xmlNode3("r:gravity-force").InnerText))
									value.pos.x = CDbl(Util.ConvertToDouble(xmlNode3("r:pos-x").InnerText))
									value.pos.y = CDbl(Util.ConvertToDouble(xmlNode3("r:pos-y").InnerText))
									value.pos.z = CDbl(Util.ConvertToDouble(xmlNode3("r:pos-z").InnerText))
									value.tan.x = CDbl(Util.ConvertToDouble(xmlNode3("r:tan-x").InnerText))
									value.tan.y = CDbl(Util.ConvertToDouble(xmlNode3("r:tan-y").InnerText))
									value.tan.z = CDbl(Util.ConvertToDouble(xmlNode3("r:tan-z").InnerText))
									value.nor.x = CDbl(Util.ConvertToDouble(xmlNode3("r:nor-x").InnerText))
									value.nor.y = CDbl(Util.ConvertToDouble(xmlNode3("r:nor-y").InnerText))
									value.nor.z = CDbl(Util.ConvertToDouble(xmlNode3("r:nor-z").InnerText))
									value.sfg.x = CDbl(Util.ConvertToDouble(xmlNode3("r:sfg-x").InnerText))
									value.sfg.y = CDbl(Util.ConvertToDouble(xmlNode3("r:sfg-y").InnerText))
									value.sfg.z = CDbl(Util.ConvertToDouble(xmlNode3("r:sfg-z").InnerText))
									value.max_sf_total = CDbl(Util.ConvertToDouble(xmlNode3("r:max-sf-total").InnerText))
									value.inc = CDbl(Util.ConvertToDouble(xmlNode3("r:inc").InnerText))
									value.azi = CDbl(Util.ConvertToDouble(xmlNode3("r:azi").InnerText))
									Try
										If RSWIN_DESC.rst.gbIncludeBuoyancy Then
											value.max_force = CDbl(Util.ConvertToDouble(xmlNode3("r:max-force").InnerText))
											value.min_force = CDbl(Util.ConvertToDouble(xmlNode3("r:min-force").InnerText))
										Else
											value.max_force_unbuoyed = CDbl(Util.ConvertToDouble(xmlNode3("r:max-force").InnerText))
											value.min_force_unbuoyed = CDbl(Util.ConvertToDouble(xmlNode3("r:min-force").InnerText))
										End If
									Catch ex25 As Exception
									End Try
									value.damp_coef_dn = CDbl(Util.ConvertToDouble(xmlNode3("r:damp-coef-dn").InnerText))
									value.damp_coef_up = CDbl(Util.ConvertToDouble(xmlNode3("r:damp-coef-up").InnerText))
									value.hydrostat_psia_tbg = CDbl(Util.ConvertToDouble(xmlNode3("r:hydrostat-psia-tbg").InnerText))
									value.hydrostat_psia_csg = CDbl(Util.ConvertToDouble(xmlNode3("r:hydrostat-psia-csg").InnerText))
									value.dynamic_psia_tbg = CDbl(Util.ConvertToDouble(xmlNode3("r:dynamic-psia-tbg").InnerText))
									value.dynamic_psia_csg = CDbl(Util.ConvertToDouble(xmlNode3("r:dynamic-psia-csg").InnerText))
									value.buckle_tendency = CDbl(Util.ConvertToDouble(xmlNode3("r:buckle-tendency").InnerText))
									value.rod_area = CDbl(Util.ConvertToDouble(xmlNode3("r:rod-area").InnerText))
									Try
										value.Grade = CInt(Math.Round(CDbl(Util.ConvertToDouble(xmlNode3("r:rod-grade").InnerText))))
									Catch ex26 As Exception
										RSWIN_DESC.rst.gbOutputLoaded = False
									End Try
									Try
										impredObj.set_r_e(num + 1, value)
									Catch ex27 As Exception
									End Try
									num += 1
								End While
							Catch ex28 As Exception
							End Try
						End If
					Catch ex29 As Exception
					End Try
					Try
						RSWIN_DESC.rst.FluidLevelTVD = Util.ConvertToSingle(xmlNode2.SelectSingleNode("r:fluid-level-tvd", nsmgr).InnerText)
					Catch ex30 As Exception
					End Try
					xmlNode2 = Nothing
				End If
				If Not flag Then
					bOutputLoaded = True
					RSWIN_DESC.rst.gbOutputLoaded = False
				ElseIf RSWIN_DESC.rst.ThisVersion <> 27S And RSWIN_DESC.rst.ThisVersion <> 25S Then
					bOutputLoaded = True
					RSWIN_DESC.rst.gbOutputLoaded = False
				Else
					bOutputLoaded = True
					RSWIN_DESC.rst.gbOutputLoaded = True
					RSWIN_DESC.rst.gbOutputOld = False
					Dim dateTime2 As DateTime
					If Operators.CompareString(dateTime.ToShortDateString(), dateTime2.ToShortDateString(), False) <> 0 Or Operators.CompareString(dateTime.ToShortTimeString(), dateTime2.ToShortTimeString(), False) <> 0 Then
						RSWIN_DESC.rst.gbOutputOld = True
						bOutputLoaded = True
						RSWIN_DESC.rst.gbOutputLoaded = False
					End If
					If RSWIN_DESC.rst.gbOutputLoaded Then
						Try
							Dim rst As cRODSTAR = RSWIN_DESC.rst
							RSWIN_DESC.bBalancedEVarsOverwritten = False
							Dim num2 As Integer = 1
							If rst.PU.UnitType <> 8S And rst.get_M(2) = 0F Then
								rst.UnknownM = True
							End If
							If((rst.PU.UnitType <> 8S And Not rst.UnknownM) Or (rst.PU.UnitType = 8S And Not rst.bUnknownUnbalance)) And rst.get_ElectricBillperMonth(2) < rst.get_ElectricBillperMonth(1) Then
								num2 = 2
							End If
							If(If((-If((CDbl(rst.get_ElectricBillperMonth(0)) >= 0.99 * CDbl(rst.get_ElectricBillperMonth(num2)) > False), 1S, 0S)), 1S, 0S) And Not RSWIN_DESC.DEBUG_ShowAllBalanced) <> 0S Then
								RSWIN_DESC.bBalancedEVarsOverwritten = True
								RSWIN_DESC.iOverWriteIndex = num2
							End If
						Catch ex31 As Exception
							RSWIN_DESC.bBalancedEVarsOverwritten = False
						End Try
					End If
					bOutputLoaded = True
					RSWIN_DESC.rst.gbOutputLoaded = True
				End If
			Catch ex32 As Exception
				bOutputLoaded = True
				RSWIN_DESC.rst.gbOutputLoaded = False
			End Try
		End Sub

		Private Const c_ENTRYNUMBER As String = "EntryNumber"

		Private Const c_AZIMUTH As String = "Azimuth"

		Private Const c_CONSTANT As String = "constant"

		Private Const c_DEPTH As String = "Depth"

		Private Const c_INCLINATION As String = "Inclination"

		Private Const c_DOGLEG As String = "Dogleg"

		Private Const c_TVDEPTH As String = "TVDepth"

		Private Const c_NORTHSOUTH As String = "NorthSouth"

		Private Const c_EASTWEST As String = "EastWest"

		Private Const c_NIL As String = "xsi:nil"

		Private Const c_NS_PREFIX As String = "r:"

		Private Const c_VELOCITY As String = "velocity"

		Private Const c_VELOCITYSQUARED As String = "velocity-squared"

		Private sRSGrade As String = ""

		Private sRSSBGrade As String = ""

		Private sDYWXDIAGCorrected1 As String = Util.AssignValueToConstant("DoYouWant", "sDYWXDIAGCorrected1", "XDIAG corrected the following in the measured surface dynamometer card:")

		Private sDYWXDIAGCorrected2 As String = Util.AssignValueToConstant("DoYouWant", "sDYWXDIAGCorrected2", "--  Stroke length (card rescaled)")

		Private sDYWXDIAGCorrected3 As String = Util.AssignValueToConstant("DoYouWant", "sDYWXDIAGCorrected3", "--  Non-kinematic surface positions")

		Private sDYWXDIAGCorrected4 As String = Util.AssignValueToConstant("DoYouWant", "sDYWXDIAGCorrected4", "--  Phase shift in surface positions")

		Private sDYWXDIAGCorrected5 As String = Util.AssignValueToConstant("DoYouWant", "sDYWXDIAGCorrected5", "--  Surface load adjustment (user-specified)")

		Private sDYWXDIAGCorrected6 As String = Util.AssignValueToConstant("DoYouWant", "sDYWXDIAGCorrected6", "--  Load shift (load cell measurement correction)")

		Private sDYWXDIAGCorrected7 As String = Util.AssignValueToConstant("DoYouWant", "sDYWXDIAGCorrected7", "--  Load span")

		Private sDYWXDIAGCorrected8 As String = Util.AssignValueToConstant("DoYouWant", "sDYWXDIAGCorrected8", "--  Phase shift in surface positions (user-specified)")

		Private sDYWXDIAGCorrected9 As String = Util.AssignValueToConstant("DoYouWant", "sDYWXDIAGCorrected9", "--  Kinematic position replacement (user-specified)")

		Private sDYWXDIAGCorrected10 As String = Util.AssignValueToConstant("DoYouWant", "sDYWXDIAGCorrected10", "Do you want to have the corrected card displayed instead of the measured card?")

		Private mnLookupCrankRotation As Collection

		Private mnLookupIPRCorrelation As Collection

		Private mnLookupPowerMeterType As Collection

		Private mnLookupPumpCondition As Collection

		Private mnLookupPumpType As Collection

		Private mnLookupRodGrade As Collection

		Private new_mnLookupRodGrade As Collection

		Private Const RodstarSchema As String = "rodstar-schema.xsd"

		Private Const document As String = "rodstar-schema.xsd"

		Private m_Depths As Single() = New Single(0) {}

		Private m_Inclinations As String() = New String(0) {}

		Private m_Azimuths As String() = New String(0) {}

		Private m_Production As Single() = New Single(0) {}

		Private m_bPIEntered As Boolean() = New Boolean(0) {}

		Private m_Pintake As Single() = New Single(0) {}

		Private m_Pwf As Single() = New Single(0) {}

		Private m_CrankRadii As Single() = New Single(0) {}

		Private m_Strokes As Single() = New Single(0) {}

		Private m_Surfload As Single() = New Single(0) {}

		Private m_SurfPos As Single() = New Single(0) {}

		Private iDevEntry As Integer = 0

		Private iIPRPoints As Integer = 0

		Private iNtSteps As Integer = 0

		Private iCrankHoles As Integer = 0

		Private iNumRods As Integer = 0

		Private TempPU As RSWIN_DESC.PUDataRec

		Private sEnum As String

		Private m_bCustomPU As Boolean = False

		Private m_bErrorCustomPU As Boolean = False
	End Module
End Namespace
