Imports System
Imports System.Collections
Imports System.IO
Imports System.Windows.Forms
Imports System.Xml
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	Friend NotInheritable Module CLIPXML
		Public Function CBW_CopyMCMToCLIPXML(sngM As Single) As Boolean
			Dim xmlTextReader As XmlTextReader = Nothing
			Dim name As String = "THETA_CBALANCE"
			Dim text As String = "clipboardM"
			Dim text2 As String = "required_structural_unbalance"
			Dim destFileName As String = ""
			Dim flag As Boolean = False
			Dim result As Boolean = False
			Dim innerText As String = sngM.ToString()
			Dim clipxmlpath As String
			Try
				Dim directoryInfo As DirectoryInfo = New DirectoryInfo(Environment.SystemDirectory)
				Dim fullName As String = directoryInfo.Parent.FullName
				clipxmlpath = CLIPXML.GetCLIPXMLPath(destFileName)
				xmlTextReader = New XmlTextReader(clipxmlpath)
			Catch ex As Exception
				Return result
			End Try
			xmlTextReader.WhitespaceHandling = WhitespaceHandling.None
			Dim xmlDocument As XmlDocument = New XmlDocument()
			xmlDocument.Load(xmlTextReader)
			xmlTextReader.Close()
			xmlTextReader = Nothing
			Dim elementsByTagName As XmlNodeList = xmlDocument.GetElementsByTagName(name)
			flag = False
			Try
				For Each obj As Object In elementsByTagName
					Dim xmlNode As XmlNode = CType(obj, XmlNode)
					Try
						For Each obj2 As Object In xmlNode.ChildNodes
							Dim xmlNode2 As XmlNode = CType(obj2, XmlNode)
							If RSWIN_DESC.rst.PU.UnitType = 8S Or RSWIN_DESC.bBeamBalanced Then
								If Operators.CompareString(xmlNode2.Name, text2, False) = 0 Then
									xmlNode2.InnerText = innerText
									flag = True
								ElseIf Operators.CompareString(xmlNode2.Name, text, False) = 0 Then
									xmlNode2.InnerText = "0"
								End If
							ElseIf Operators.CompareString(xmlNode2.Name, text, False) = 0 Then
								xmlNode2.InnerText = innerText
								flag = True
							ElseIf Operators.CompareString(xmlNode2.Name, text2, False) = 0 Then
								xmlNode2.InnerText = "0"
							End If
						Next
					Finally
						Dim enumerator2 As IEnumerator
						If TypeOf enumerator2 Is IDisposable Then
							TryCast(enumerator2, IDisposable).Dispose()
						End If
					End Try
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			If flag Then
				xmlDocument.Save(clipxmlpath)
				result = True
				xmlDocument = Nothing
			Else
				xmlDocument = Nothing
				Try
					Try
						File.Copy(clipxmlpath, destFileName)
					Catch ex2 As Exception
					End Try
				Catch ex3 As Exception
				End Try
			End If
			Return result
		End Function

		Public Sub CheckForCBDataInCLIPXML(ByRef ClipboardM As Util.IMPORTEDMOMENT, ByRef bCBDataInCLIPXML As Boolean)
			Dim xmlTextReader As XmlTextReader = Nothing
			Dim text As String = "m_sngE"
			Dim name As String = "THETA_CBALANCE"
			Dim text2 As String = "clipboardM"
			bCBDataInCLIPXML = False
			Try
				Dim directoryInfo As DirectoryInfo = New DirectoryInfo(Environment.SystemDirectory)
				Dim fullName As String = directoryInfo.Parent.FullName
				Dim text3 As String = ""
				Dim clipxmlpath As String = CLIPXML.GetCLIPXMLPath(text3)
				xmlTextReader = New XmlTextReader(clipxmlpath)
			Catch ex As Exception
				Return
			End Try
			xmlTextReader.WhitespaceHandling = WhitespaceHandling.None
			Dim xmlDocument As XmlDocument = New XmlDocument()
			xmlDocument.Load(xmlTextReader)
			xmlTextReader.Close()
			xmlTextReader = Nothing
			Dim elementsByTagName As XmlNodeList = xmlDocument.GetElementsByTagName(name)
			Dim text4 As String
			Try
				For Each obj As Object In elementsByTagName
					Dim xmlNode As XmlNode = CType(obj, XmlNode)
					Try
						For Each obj2 As Object In xmlNode.ChildNodes
							Dim xmlNode2 As XmlNode = CType(obj2, XmlNode)
							If(Operators.CompareString(xmlNode2.Name, text2, False) = 0 And Not(RSWIN_DESC.rst.PU.UnitType = 8S Or RSWIN_DESC.bBeamBalanced)) Or (Operators.CompareString(xmlNode2.Name, text, False) = 0 And (RSWIN_DESC.rst.PU.UnitType = 8S Or RSWIN_DESC.bBeamBalanced)) Then
								text4 = Strings.Trim(xmlNode2.InnerText)
								bCBDataInCLIPXML = True
							End If
						Next
					Finally
						Dim enumerator2 As IEnumerator
						If TypeOf enumerator2 Is IDisposable Then
							TryCast(enumerator2, IDisposable).Dispose()
						End If
					End Try
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			If bCBDataInCLIPXML Then
				If Operators.CompareString(text4.Trim(), "", False) <> 0 And Operators.CompareString(text4.Trim(), "0", False) <> 0 Then
					ClipboardM.CBMoment = Convert.ToSingle(text4)
					Return
				End If
				bCBDataInCLIPXML = False
				Return
			End If
		End Sub

		Public Function XDW_CopyMCMToCLIPXML(sngM As Single, iSource As Integer) As Boolean
			Dim xmlTextReader As XmlTextReader = Nothing
			Dim destFileName As String = ""
			Dim name As String = "THETA_CBALANCE_IMPORT"
			Dim text As String = "CBMoment"
			Dim text2 As String = "required_structural_unbalance"
			Dim text3 As String = "Source"
			Dim flag As Boolean = False
			Dim flag2 As Boolean = False
			Dim result As Boolean = False
			If Not(sngM = 0F Or iSource = 0) Then
				Dim innerText As String = sngM.ToString()
				Dim innerText2 As String = iSource.ToString()
				Dim clipxmlpath As String
				Try
					Dim directoryInfo As DirectoryInfo = New DirectoryInfo(Environment.SystemDirectory)
					Dim fullName As String = directoryInfo.Parent.FullName
					clipxmlpath = CLIPXML.GetCLIPXMLPath(destFileName)
					xmlTextReader = New XmlTextReader(clipxmlpath)
				Catch ex As Exception
					Return result
				End Try
				xmlTextReader.WhitespaceHandling = WhitespaceHandling.None
				Dim xmlDocument As XmlDocument = New XmlDocument()
				xmlDocument.Load(xmlTextReader)
				xmlTextReader.Close()
				xmlTextReader = Nothing
				Dim elementsByTagName As XmlNodeList = xmlDocument.GetElementsByTagName(name)
				Try
					For Each obj As Object In elementsByTagName
						Dim xmlNode As XmlNode = CType(obj, XmlNode)
						Try
							For Each obj2 As Object In xmlNode.ChildNodes
								Dim xmlNode2 As XmlNode = CType(obj2, XmlNode)
								If RSWIN_DESC.rst.PU.UnitType = 8S Or RSWIN_DESC.bBeamBalanced Then
									If Operators.CompareString(xmlNode2.Name, text2, False) = 0 Then
										xmlNode2.InnerText = innerText
										flag = True
									ElseIf Operators.CompareString(xmlNode2.Name, text, False) = 0 Then
										xmlNode2.InnerText = "0"
									End If
								ElseIf Operators.CompareString(xmlNode2.Name, text, False) = 0 Then
									xmlNode2.InnerText = innerText
									flag = True
								ElseIf Operators.CompareString(xmlNode2.Name, text2, False) = 0 Then
									xmlNode2.InnerText = "0"
								End If
								If Operators.CompareString(xmlNode2.Name, text3, False) = 0 Then
									xmlNode2.InnerText = innerText2
									flag2 = True
								End If
							Next
						Finally
							Dim enumerator2 As IEnumerator
							If TypeOf enumerator2 Is IDisposable Then
								TryCast(enumerator2, IDisposable).Dispose()
							End If
						End Try
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				If flag AndAlso flag2 Then
					xmlDocument.Save(clipxmlpath)
					result = True
				End If
				Try
					Try
						File.Copy(clipxmlpath, destFileName)
					Catch ex2 As Exception
					End Try
				Catch ex3 As Exception
				End Try
				xmlDocument = Nothing
			End If
			Return result
		End Function

		Public Function ImportCBMoment(ByRef M As Util.IMPORTEDMOMENT, bQuiet As Boolean) As Boolean
			Dim obj As Object = False
			Dim flag As Boolean = Conversions.ToBoolean(obj)
			Dim importedmoment As Util.IMPORTEDMOMENT
			CLIPXML.CheckForCBDataInCLIPXML(importedmoment, flag)
			obj = flag
			Dim flag2 As Boolean
			If Conversions.ToBoolean(Operators.NotObject(obj)) Then
				flag2 = False
			ElseIf bQuiet Then
				flag2 = True
			Else
				Dim text As String
				Select Case importedmoment.wSource
					Case 1
						text = "XBAL"
					Case 2
						text = "RODDIAG"
					Case 3
						text = "XDIAG"
					Case 4
						text = "RODSTAR"
				End Select
				If Not(RSWIN_DESC.rst.PU.UnitType = 8S Or RSWIN_DESC.bBeamBalanced) Then
					Dim text2 As String = text + " has exported a balanced maximum CB moment of "
					If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
						Dim str As String = text2
						Dim num As Single = importedmoment.CBMoment * RSWIN_DESC.MINLB__NM
						Dim text3 As String = "0.0"
						text2 = str + Util.Format(num, text3) + " N-m"
					Else
						Dim str2 As String = text2
						Dim num As Single = importedmoment.CBMoment / 1000F
						Dim text3 As String = "0.0"
						text2 = str2 + Util.Format(num, text3) + " M in-lbs"
					End If
					text2 = text2 + ".  Do you want to replace the balanced maximum CB moment in this file with the moment exported by " + text + "?"
					flag2 = (Interaction.MsgBox(text2, MsgBoxStyle.YesNo Or MsgBoxStyle.Question, Nothing) = MsgBoxResult.Yes)
				Else
					Dim text2 As String = text + " has exported a structural unbalance of "
					If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
						Dim str3 As String = text2
						Dim num As Single = importedmoment.CBMoment * RSWIN_DESC.LB__N
						Dim text3 As String = "0.0"
						text2 = str3 + Util.Format(num, text3) + " N"
					Else
						Dim str4 As String = text2
						Dim text3 As String = "0.0"
						text2 = str4 + Util.Format(importedmoment.CBMoment, text3) + " lbs"
					End If
					text2 = text2 + ".  Do you want to replace the structural unbalance in this file with the one exported by " + text + "?"
					flag2 = (Interaction.MsgBox(text2, MsgBoxStyle.YesNo Or MsgBoxStyle.Question, Nothing) = MsgBoxResult.Yes)
				End If
			End If
			If flag2 Then
				M = importedmoment
			End If
			Return flag2
		End Function

		Public Function GetCLIPXMLPath(Optional ByRef sOtherPath As String = "") As String
			Dim result As String = ""
			Dim text As String = Interaction.Environ("USERPROFILE") + "\Application Data\ThetaData"
			Dim text2 As String = text.Trim() + "\thetaclp.xml"
			Dim text3 As String = Strings.Left(Application.ExecutablePath, 3) + "THETA"
			Dim text4 As String = text3 + "\thetaclp.xml"
			Dim sourceFileName As String = Strings.Left(Application.ExecutablePath, Application.ExecutablePath.LastIndexOf("\")) + "\thetaclp_master.xml"
			Dim fileInfo As FileInfo = New FileInfo(text2)
			Dim fileInfo2 As FileInfo = New FileInfo(text4)
			If fileInfo.Exists Then
				result = text2
				sOtherPath = text4
			ElseIf fileInfo2.Exists Then
				result = text4
				sOtherPath = text2
			End If
			If Not fileInfo.Exists And Not fileInfo2.Exists Then
				If Not Directory.Exists(text) Then
					Try
						Directory.CreateDirectory(text)
					Catch ex As Exception
					End Try
				End If
				Try
					File.Copy(sourceFileName, text2)
				Catch ex2 As Exception
				End Try
				If Not Directory.Exists(text3) Then
					Try
						Directory.CreateDirectory(text3)
					Catch ex3 As Exception
					End Try
				End If
				Try
					File.Copy(sourceFileName, text4)
					Return result
				Catch ex4 As Exception
					Return result
				End Try
			End If
			If Not fileInfo.Exists Then
				If Not Directory.Exists(text) Then
					Directory.CreateDirectory(text)
				End If
				Try
					File.Copy(sourceFileName, text2)
					Return result
				Catch ex5 As Exception
					Return result
				End Try
			End If
			If Not fileInfo2.Exists Then
				If Not Directory.Exists(text3) Then
					Directory.CreateDirectory(text3)
				End If
				Try
					File.Copy(sourceFileName, text4)
				Catch ex6 As Exception
				End Try
			End If
			Return result
		End Function

		Public Sub MoveXMLFile()
			Try
				Dim text As String = Interaction.Environ("USERPROFILE") + "\Application Data\ThetaData"
				Dim text2 As String = text.Trim() + "\thetaclp.xml"
				Dim sourceFileName As String = Application.StartupPath + "\thetaclp_master.xml"
				Dim fileInfo As FileInfo = New FileInfo(text2)
				Try
					If fileInfo.Exists Then
						fileInfo.Delete()
					End If
				Catch ex As Exception
				End Try
				Try
					File.Copy(sourceFileName, text2)
				Catch ex2 As Exception
				End Try
			Catch ex3 As Exception
			End Try
		End Sub

		Private Const cnCBALANCE As Integer = 1

		Private Const cnRODDIAG As Integer = 2

		Private Const cnXDIAG As Integer = 3

		Private Const cnRODSTAR As Integer = 4

		Private Const CLIPXML_FILE As String = "\thetaclp.xml"

		Private Const CLIPXML_MASTER_FILE As String = "\thetaclp_master.xml"
	End Module
End Namespace
