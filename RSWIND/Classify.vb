Imports System
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	Friend NotInheritable Module Classify
		Public Function Classification(ByRef pd As RSWIN_DESC.PUMPDIAGNOSIS, bUpstroke As Integer) As String
			Dim diagnosis As Long = pd.Diagnosis
			Dim text As String
			If(diagnosis And 1L) <> 0L Then
				text = "full"
			Else
				Dim num As Long = diagnosis And 6L
				If num <= 4L AndAlso num >= 2L Then
					Select Case CInt((num - 2L))
						Case 0
							text = "fl.pound"
							GoTo IL_54
						Case 2
							text = "gas intf."
							GoTo IL_54
					End Select
				End If
				text = "incomplete"
			End If
			IL_54:
			If(diagnosis And 65536L) <> 0L Then
				text += ", phase adjustment needed"
			End If
			If(diagnosis And 4096L) <> 0L Then
				text += ", bent pump barrel"
			End If
			If(diagnosis And 8192L) <> 0L Then
				text += ", malf.tub.anchor"
			End If
			If(diagnosis And 2048L) <> 0L Then
				text += ", rod/tubing fr."
			End If
			If(diagnosis And 1024L) <> 0L Then
				text += ", shallow fr."
			End If
			If(diagnosis And 16384L) <> 0L Then
				text += ", worn pump barrel"
			End If
			If bUpstroke <> 0 Then
				Dim num2 As Long = diagnosis And -1073741824L
				If num2 = -1073741824L Then
					text += ", slight tv leak"
				ElseIf num2 = -2147483648L Then
					text += ", tv leak"
				ElseIf num2 = 1073741824L Then
					text += ", severe tv leak"
				End If
				If(diagnosis And 536870912L) <> 0L Then
					text += ", hitting up"
				End If
				If(diagnosis And 268435456L) <> 0L Then
					text += ", gas exp."
				End If
			Else
				Dim num3 As Long = diagnosis And -1073741824L
				If num3 = -1073741824L Then
					text += ", slight sv leak"
				ElseIf num3 = -2147483648L Then
					text += ", sv leak"
				ElseIf num3 = 1073741824L Then
					text += ", severe sv leak"
				End If
				If(diagnosis And 536870912L) <> 0L Then
					text += ", hitting down"
				End If
				If(diagnosis And 268435456L) <> 0L Then
					text += ", sbar wave refl."
				End If
			End If
			Return text
		End Function

		Public Function ClsAdjustPhase(pd As RSWIN_DESC.PUMPDIAGNOSIS) As Long
			Return If((-If((((pd.Diagnosis And 65536L) <> 0L) > False), 1L, 0L)), 1L, 0L)
		End Function

		Public Function ClsBentPumpBarrel(pd As RSWIN_DESC.PUMPDIAGNOSIS) As Long
			Return If((-If((((pd.Diagnosis And 4096L) <> 0L) > False), 1L, 0L)), 1L, 0L)
		End Function

		Public Function ClsFluidPound(pd As RSWIN_DESC.PUMPDIAGNOSIS) As Integer
			Return If((-If((((pd.Diagnosis And 7L) = 2L) > False), 1, 0)), 1, 0)
		End Function

		Public Function ClsFullPump(pd As RSWIN_DESC.PUMPDIAGNOSIS) As Integer
			Return If((-If((((pd.Diagnosis And 1L) <> 0L) > False), 1, 0)), 1, 0)
		End Function

		Public Function ClsGasExpansion(pd As RSWIN_DESC.PUMPDIAGNOSIS) As Integer
			Return If((-If((((pd.Diagnosis And 268435456L) = 268435456L) > False), 1, 0)), 1, 0)
		End Function

		Public Function ClsGasInterference(pd As RSWIN_DESC.PUMPDIAGNOSIS) As Integer
			Return If((-If((((pd.Diagnosis And 7L) = 4L) > False), 1, 0)), 1, 0)
		End Function

		Public Function ClsHittingDown(pd As RSWIN_DESC.PUMPDIAGNOSIS) As Integer
			Return If((-If((((pd.Diagnosis And 536870912L) <> 0L) > False), 1, 0)), 1, 0)
		End Function

		Public Function ClsHittingUp(pd As RSWIN_DESC.PUMPDIAGNOSIS) As Integer
			Return If((-If((((pd.Diagnosis And 536870912L) <> 0L) > False), 1, 0)), 1, 0)
		End Function

		Public Function ClsIncompleteFillage(pd As RSWIN_DESC.PUMPDIAGNOSIS) As Integer
			Return If((-If((((pd.Diagnosis And 7L) = 0L) > False), 1, 0)), 1, 0)
		End Function

		Public Function ClsMalfunctioningTubingAnchor(pd As RSWIN_DESC.PUMPDIAGNOSIS) As Long
			Return If((-If((((pd.Diagnosis And 8192L) <> 0L) > False), 1L, 0L)), 1L, 0L)
		End Function

		Public Function ClsMechanical(pd As RSWIN_DESC.PUMPDIAGNOSIS) As Long
			Return pd.Diagnosis And -4096L
		End Function

		Public Function ClsRodTubingFriction(pd As RSWIN_DESC.PUMPDIAGNOSIS) As Object
			Return(pd.Diagnosis And 2048L) <> 0L
		End Function

		Public Function ClsSBWaveReflection(pd As RSWIN_DESC.PUMPDIAGNOSIS) As Long
			Return If((-If((((pd.Diagnosis And 268435456L) <> 0L) > False), 1L, 0L)), 1L, 0L)
		End Function

		Public Function ClsShallowFriction(pd As RSWIN_DESC.PUMPDIAGNOSIS) As Long
			Return If((-If((((pd.Diagnosis And 1024L) <> 0L) > False), 1L, 0L)), 1L, 0L)
		End Function

		Public Function ClsSVLeak(pd As RSWIN_DESC.PUMPDIAGNOSIS) As Long
			Return pd.Diagnosis And -1073741824L
		End Function

		Public Function ClsTVLeak(pd As RSWIN_DESC.PUMPDIAGNOSIS) As Long
			Return pd.Diagnosis And -1073741824L
		End Function

		Public Function ClsWornPump(ByRef pdUp As RSWIN_DESC.PUMPDIAGNOSIS, ByRef pdDown As RSWIN_DESC.PUMPDIAGNOSIS) As Object
			Dim num As Long = Classify.ClsTVLeak(pdUp)
			Dim num2 As Long = Classify.ClsSVLeak(pdDown)
			Dim result As Object
			If num = -1073741824L And num2 = -1073741824L Then
				result = 1
			ElseIf num = -2147483648L And num2 = -2147483648L Then
				result = 2
			ElseIf num = -2147483648L And num2 = 1073741824L Then
				result = 2
			ElseIf num = 1073741824L And num2 = -2147483648L Then
				result = 2
			ElseIf num = 1073741824L And num2 = 1073741824L Then
				result = 3
			Else
				result = 0
			End If
			Return result
		End Function

		Public Function ClsWornPumpBarrel(pd As RSWIN_DESC.PUMPDIAGNOSIS) As Long
			Return If((-If((((pd.Diagnosis And 16384L) <> 0L) > False), 1L, 0L)), 1L, 0L)
		End Function
	End Module
End Namespace
