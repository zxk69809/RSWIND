Imports System
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	Friend NotInheritable Module Dialogs
		Private Property dlgVerifyMotorHP As dlgVerifyMotorHP
			Get
				Return Dialogs._dlgVerifyMotorHP
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As dlgVerifyMotorHP)
				Dialogs._dlgVerifyMotorHP = value
			End Set
		End Property

		Private Property dlgPUManuf As dlgPUManuf
			Get
				Return Dialogs._dlgPUManuf
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As dlgPUManuf)
				Dialogs._dlgPUManuf = value
			End Set
		End Property = New dlgPUManuf()

		Public Sub dlgGetPUManuf(ByRef sManuf As String)
			Try
				If Not Dialogs.dlgPUManuf.Enabled Then
					Dialogs.dlgPUManuf.Enabled = True
				End If
			Catch ex As Exception
			End Try
			Dialogs.dlgPUManuf.ShowDialog()
			sManuf = Strings.Trim(Dialogs.dlgPUManuf.txtPUManuf.Text)
			If Strings.Len(sManuf) = 0 Then
				sManuf = "(Unknown)"
				Return
			End If
		End Sub

		Public Function dlgVerifyMotorSize(iMessage As Integer, bAllowContinue As Integer, fRecMotorHP As Single, ByRef bUseRecommended As Boolean) As Integer
			RSWIN_DESC.bChangeMotorSize = False
			bUseRecommended = False
			Dim result As Integer
			If RSWIN_DESC.rst.gbAutomatic Or RSWIN_DESC.rst.gbBatch Then
				RSWIN_DESC.bChangeMotorSize = False
			Else
				If Dialogs.dlgVerifyMotorHP Is Nothing Then
					Dialogs.dlgVerifyMotorHP = New dlgVerifyMotorHP()
				End If
				Dialogs.dlgVerifyMotorHP.RecMotorHP = Convert.ToString(fRecMotorHP)
				Dialogs.dlgVerifyMotorHP.MessageNumber = Convert.ToString(iMessage)
				If Not bAllowContinue <> 0 Then
					Dialogs.dlgVerifyMotorHP.cmdContinue.Visible = False
				End If
				Util.UnbusyCursor()
				Try
					If Not Dialogs.dlgVerifyMotorHP.Enabled Then
						Dialogs.dlgVerifyMotorHP.Enabled = True
					End If
				Catch ex As Exception
				End Try
				Dialogs.dlgVerifyMotorHP.ShowDialog()
				Util.BusyCursor()
				RSWIN_DESC.bChangeMotorSize = False
				If Dialogs.dlgVerifyMotorHP IsNot Nothing Then
					If Dialogs.dlgVerifyMotorHP.bChange Then
						RSWIN_DESC.bChangeMotorSize = True
					End If
					bUseRecommended = Dialogs.dlgVerifyMotorHP.bUseRecommended
				End If
				Dim dlgVerifyMotorHP As Form = Dialogs.dlgVerifyMotorHP
				Dim flag As Boolean = RSWIN.IsFormLoaded(dlgVerifyMotorHP)
				Dialogs.dlgVerifyMotorHP = CType(dlgVerifyMotorHP, dlgVerifyMotorHP)
				If flag Then
					If Not RSWIN_DESC.bChangeMotorSize Then
						result = If((-If((Dialogs.dlgVerifyMotorHP.Enabled > False), 1, 0)), 1, 0)
						bUseRecommended = Dialogs.dlgVerifyMotorHP.bUseRecommended
						RSWIN_DESC.bChangeMotorSize = False
					End If
				Else
					RSWIN_DESC.bChangeMotorSize = True
				End If
				If RSWIN_DESC.bChangeMotorSize Then
					result = 0
				End If
			End If
			Return result
		End Function

		Public Function dlgVerifyPumpingSpeed(iMessage As Short, bAllowContinue As Short, Optional ByRef bUseMaxSPM As Boolean = False, Optional fSPMThreshold As Single = 0F) As Boolean
			Dim dlgVerifySPM As dlgVerifySPM = New dlgVerifySPM()
			Dim result As Boolean = False
			Interaction.Beep()
			RSWIN_DESC.bChangeSPM = False
			dlgVerifySPM.MessageNumber = Convert.ToString(iMessage)
			dlgVerifySPM.bContinueVisible = (bAllowContinue <> 0S)
			If fSPMThreshold <> 0F Then
				dlgVerifySPM.SPMThreshold = fSPMThreshold
			End If
			Util.UnbusyCursor()
			Try
				If Not dlgVerifySPM.Enabled Then
					dlgVerifySPM.Enabled = True
				End If
			Catch ex As Exception
			End Try
			dlgVerifySPM.ShowDialog()
			Util.BusyCursor()
			result = dlgVerifySPM.bContinue
			bUseMaxSPM = dlgVerifySPM.bUseMaxSPM
			RSWIN_DESC.bChangeSPM = dlgVerifySPM.bChangeSPM
			Try
				dlgVerifySPM.Close()
				dlgVerifySPM = Nothing
			Catch ex2 As Exception
			End Try
			Return result
		End Function

		<AccessedThroughProperty("dlgVerifyMotorHP")>
		Private _dlgVerifyMotorHP As dlgVerifyMotorHP

		<AccessedThroughProperty("dlgPUManuf")>
		Private _dlgPUManuf As dlgPUManuf
	End Module
End Namespace
