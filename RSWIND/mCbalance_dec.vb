Imports System
Imports CBFile
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	Public NotInheritable Module mCbalance_dec
		Public Const TB_IMPORTMCM As Integer = 6

		Public msCBLDir As String

		Public msIMPDir As String

		Public Const MNU_FILE As Integer = 0

		Public Const MNU_BALANCE As Integer = 2

		Public Const MNU_PRINT As Integer = 9

		Public Const CWT_NONE As Integer = 0

		Public Const CWT_FLD As Integer = 1

		Public Const CWT_FLG As Integer = 2

		Public Const CWT_BLD As Integer = 3

		Public Const CWT_BLG As Integer = 4

		Public Const MAX_CWTS As Integer = 4

		Public Const MAX_AUXWTS As Integer = 3

		Public Const cAMERICAN As Integer = 1

		Public Const cDARCO As Integer = 2

		Public Const cOTHER As Integer = 0

		Public bIgnoreEvent As Boolean

		Public gbInputDataChanged As Integer

		Public cbf As CBFile = New CBFile()

		Public UndoText As String

		Public bGridUpdatedLast As Boolean

		Public SETUP_OutputFormat As String

		Public UnitInBalance As Integer

		Public NumXb As Integer

		Public giSentinelNumber As Integer

		Public Const cOUTPUT_FORMAT_CBL As String = ".cbl"

		Public Const cOUTPUT_FORMAT_CBLX As String = ".cblx"

		Public Const cOUTPUT_FORMAT_XBLX As String = ".xblx"

		Public Const cOUTPUT_FORMAT_NONE As String = ""

		Public CtlIndex As Integer() = New Integer(4) {}

		Public CwtIndex As Integer() = New Integer(4) {}

		Public gnMfrs As Integer

		Public gnCranks As Integer

		Public gnLeadCwts As Integer

		Public gnLagCwts As Integer

		Public gnFLDAuxwts As Integer

		Public gnFLGAuxwts As Integer

		Public gnBLDAuxwts As Integer

		Public gnBLGAuxwts As Integer

		Public LeadCwtList As String()

		Public LagCwtList As String()

		Public FLDAuxwts As String()

		Public FLGAuxwts As String()

		Public BLDAuxwts As String()

		Public BLGAuxwts As String()
	End Module
End Namespace
