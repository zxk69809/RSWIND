Imports System
Imports System.Runtime.InteropServices
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	Friend NotInheritable Module SuperproLib
		Public Class SuperproClass
			Public Declare Ansi Function RNBOsproFormatPacket Lib "sx32w_dotnet.dll" (packet As Byte(), ByRef ApiPackSize As Integer) As Short

			Public Declare Ansi Function RNBOsproInitialize Lib "sx32w_dotnet.dll" (packet As Byte()) As Short

			Public Declare Ansi Function RNBOsproGetFullStatus Lib "sx32w_dotnet.dll" (packet As Byte()) As Short

			Public Declare Ansi Function RNBOsproGetVersion Lib "sx32w_dotnet.dll" (packet As Byte(), ByRef majv As Byte, ByRef minv As Byte, ByRef rev As Byte, ByRef ostype As Byte) As Short

			Public Declare Ansi Function RNBOsproFindFirstUnit Lib "sx32w_dotnet.dll" (packet As Byte(), developerID As Integer) As Short

			Public Declare Ansi Function RNBOsproFindNextUnit Lib "sx32w_dotnet.dll" (packet As Byte()) As Short

			Public Declare Ansi Function RNBOsproRead Lib "sx32w_dotnet.dll" (packet As Byte(), address As Integer, ByRef data As Integer) As Short

			Public Declare Ansi Function RNBOsproExtendedRead Lib "sx32w_dotnet.dll" (packet As Byte(), address As Integer, ByRef data As Integer, ByRef accessCode As Byte) As Short

			Public Declare Ansi Function RNBOsproWrite Lib "sx32w_dotnet.dll" (packet As Byte(), wPass As Integer, address As Short, data As Integer, accessCode As Byte) As Short

			Public Declare Ansi Function RNBOsproOverwrite Lib "sx32w_dotnet.dll" (packet As Byte(), wPass As Integer, oPass1 As Integer, oPass2 As Integer, address As Short, datum As Integer, accessCode As Byte) As Short

			Public Declare Ansi Function RNBOsproDecrement Lib "sx32w_dotnet.dll" (packet As Byte(), wPass As Integer, address As Integer) As Short

			Public Declare Ansi Function RNBOsproActivate Lib "sx32w_dotnet.dll" (packet As Byte(), wPass As Integer, aPass1 As Integer, aPass2 As Integer, address As Short) As Short

			Public Declare Ansi Function RNBOsproQuery Lib "sx32w_dotnet.dll" (packet As Byte(), address As Short, queryString As Byte(), response As Byte(), ByRef response32 As Long, length As Short) As Short

			Public Declare Ansi Function RNBOsproGetHardLimit Lib "sx32w_dotnet.dll" (packet As Byte(), ByRef hardlimit As Integer) As Short

			Public Declare Ansi Function RNBOsproGetContactServer Lib "sx32w_dotnet.dll" (packet As Byte(), serverName As Byte(), bufferSize As Integer) As Short

			Public Declare Ansi Function RNBOsproSetContactServer Lib "sx32w_dotnet.dll" (packet As Byte(), <MarshalAs(UnmanagedType.VBByRefStr)> ByRef serverName As String) As Short

			Public Declare Ansi Function RNBOsproGetSubLicense Lib "sx32w_dotnet.dll" (packet As Byte(), cellAddress As Short) As Short

			Public Declare Ansi Function RNBOsproSetProtocol Lib "sx32w_dotnet.dll" (packet As Byte(), protocolFlag As Short) As Short

			Public Declare Ansi Function RNBOsproSetHeartBeat Lib "sx32w_dotnet.dll" (packet As Byte(), heartbeat As Integer) As Short

			Public Declare Ansi Function RNBOsproReleaseLicense Lib "sx32w_dotnet.dll" (packet As Byte(), cellAddress As Short, ByRef numOfLic As Integer) As Short

			Public Declare Ansi Function RNBOsproEnumServer Lib "sx32w_dotnet.dll" (enumflag As Integer, developerid As Integer, serverBuffer As Byte(), ByRef numOfServers As Short) As Short

			Public Declare Ansi Function RNBOsproGetKeyInfo Lib "sx32w_dotnet.dll" (packet As Byte(), developerId As Integer, keyIndex As Short, keyBuffer As Byte()) As Short

			Public Const SP_SUCCESS As Integer = 0

			Public Const SP_INVALID_FUNCTION_CODE As Integer = 1

			Public Const SP_INVALID_PACKET As Integer = 2

			Public Const SP_UNIT_NOT_FOUND As Integer = 3

			Public Const SP_ACCESS_DENIED As Integer = 4

			Public Const SP_INVALID_MEMORY_ADDRESS As Integer = 5

			Public Const SP_INVALID_ACCESS_CODE As Integer = 6

			Public Const SP_PORT_IS_BUSY As Integer = 7

			Public Const SP_WRITE_NOT_READY As Integer = 8

			Public Const SP_NO_PORT_FOUND As Integer = 9

			Public Const SP_ALREADY_ZERO As Integer = 10

			Public Const SP_DRIVER_OPEN_ERROR As Integer = 11

			Public Const SP_DRIVER_NOT_INSTALLED As Integer = 12

			Public Const SP_IO_COMMUNICATIONS_ERROR As Integer = 13

			Public Const SP_PACKET_TOO_SMALL As Integer = 15

			Public Const SP_INVALID_PARAMETER As Integer = 16

			Public Const SP_MEM_ACCESS_ERROR As Integer = 17

			Public Const SP_VERSION_NOT_SUPPORTED As Integer = 18

			Public Const SP_OS_NOT_SUPPORTED As Integer = 19

			Public Const SP_QUERY_TOO_LONG As Integer = 20

			Public Const SP_INVALID_COMMAND As Integer = 21

			Public Const SP_MEM_ALIGNMENT_ERROR As Integer = 29

			Public Const SP_DRIVER_IS_BUSY As Integer = 30

			Public Const SP_PORT_ALLOCATION_FAILURE As Integer = 31

			Public Const SP_PORT_RELEASE_FAILURE As Integer = 32

			Public Const SP_ACQUIRE_PORT_TIMEOUT As Integer = 39

			Public Const SP_SIGNAL_NOT_SUPPORTED As Integer = 42

			Public Const SP_UNKNOWN_MACHINE As Integer = 44

			Public Const SP_SYS_API_ERROR As Integer = 45

			Public Const SP_UNIT_IS_BUSY As Integer = 46

			Public Const SP_INVALID_PORT_TYPE As Integer = 47

			Public Const SP_INVALID_MACH_TYPE As Integer = 48

			Public Const SP_INVALID_IRQ_MASK As Integer = 49

			Public Const SP_INVALID_CONT_METHOD As Integer = 50

			Public Const SP_INVALID_PORT_FLAGS As Integer = 51

			Public Const SP_INVALID_LOG_PORT_CFG As Integer = 52

			Public Const SP_INVALID_OS_TYPE As Integer = 53

			Public Const SP_INVALID_LOG_PORT_NUM As Integer = 54

			Public Const SP_INVALID_ROUTER_FLGS As Integer = 56

			Public Const SP_INIT_NOT_CALLED As Integer = 57

			Public Const SP_DRVR_TYPE_NOT_SUPPORTED As Integer = 58

			Public Const SP_FAIL_ON_DRIVER_COMM As Integer = 59

			Public Const SP_SERVER_PROBABLY_NOT_UP As Integer = 60

			Public Const SP_UNKNOWN_HOST As Integer = 61

			Public Const SP_SENDTO_FAILED As Integer = 62

			Public Const SP_SOCKET_CREATION_FAILED As Integer = 63

			Public Const SP_NORESOURCES As Integer = 64

			Public Const SP_BROADCAST_NOT_SUPPORTED As Integer = 65

			Public Const SP_BAD_SERVER_MESSAGE As Integer = 66

			Public Const SP_NO_SERVER_RUNNING As Integer = 67

			Public Const SP_NO_NETWORK As Integer = 68

			Public Const SP_NO_SERVER_RESPONSE As Integer = 69

			Public Const SP_NO_LICENSE_AVAILABLE As Integer = 70

			Public Const SP_INVALID_LICENSE As Integer = 71

			Public Const SP_INVALID_OPERATION As Integer = 72

			Public Const SP_BUFFER_TOO_SMALL As Integer = 73

			Public Const SP_INTERNAL_ERROR As Integer = 74

			Public Const SP_PACKET_ALREADY_INITIALIZED As Integer = 75

			Public Const SP_PROTOCOL_NOT_INSTALLED As Integer = 76

			Public Const RB_WINNT_SYS_DRVR As Integer = 5

			Public Const RB_WIN95_SYS_DRVR As Integer = 7

			Public Const RB_NW_LOCAL_DRVR As Integer = 8

			Public Const MAX_NUM_DEV As Integer = 10

			Public Const MAX_NAME_LEN As Integer = 64

			Public Const MAX_ADDR_LEN As Integer = 32

			Public Const MAX_HEARTBEAT As Integer = 2592000

			Public Const MIN_HEARTBEAT As Integer = 60

			Public Const INFINITE_HEARTBEAT As Integer = -1

			Public Const SPRO_MAX_QUERY_SIZE As Integer = 56

			Public Const RNBO_STANDALONE As String = "RNBO_STANDALONE"

			Public Const RNBO_SPN_DRIVER As String = "RNBO_SPN_DRIVER"

			Public Const RNBO_SPN_LOCAL As String = "RNBO_SPN_LOCAL"

			Public Const RNBO_SPN_BROADCAST As String = "RNBO_SPN_BROADCAST"

			Public Const RNBO_SPN_ALL_MODES As String = "RNBO_ALL_SPN_MODES"

			Public Const RNBO_SPN_SERVER_MODES As String = "RNBO_SPN_SERVER_MODES"

			Public Const SPRO_APIPACKET_SIZE As Integer = 4112

			Public Shared packet As Byte() = New Byte(4112) {}

			Public Class ServerInfo
				Public Sub New()
					Me.serverAddress = New Byte(32) {}
				End Sub

				Public Sub GetServerInfo(buffer As Byte(), offset As Integer)
					Array.Clear(Me.serverAddress, 0, 32)
					Dim num As Integer = 0
					Dim num2 As Integer = offset
					Do
						Me.serverAddress(num) = buffer(num2)
						num2 += 1
						num += 1
					Loop While num2 <= 32 + offset
					Me.numOfAvail = BitConverter.ToInt16(buffer, 32 + offset)
				End Sub

				Public serverAddress As Byte()

				Public numOfAvail As Short
			End Class

			Public Structure KeyInfo
				Public developerId As Short

				Public hardLimit As Short

				Public inUse As Short

				Public numTimeOut As Short

				Public highestUse As Short
			End Structure

			Public Class MonitorInfo
				Public Sub New()
					Me.serverName = New Byte(64) {}
					Me.serverIPAddress = New Byte(32) {}
					Me.serverIPXAddress = New Byte(32) {}
					Me.version = New Byte(64) {}
					Me.sproKeyMonitorInfo = Nothing
				End Sub

				Public Sub GetMonitorInfo(buffer As Byte())
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Do
						Me.serverName(num2) = buffer(num)
						num2 += 1
						num += 1
					Loop While num <> 64
					Dim num3 As Integer = num
					num2 = 0
					Do
						Me.serverIPAddress(num2) = buffer(num)
						num2 += 1
						num += 1
					Loop While num <> 32 + num3
					num3 = num
					num2 = 0
					Do
						Me.serverIPXAddress(num2) = buffer(num)
						num2 += 1
						num += 1
					Loop While num <> 32 + num3
					num3 = num
					num2 = 0
					Do
						Me.version(num2) = buffer(num)
						num2 += 1
						num += 1
					Loop While num <> 64 + num3
					Me.protocol = BitConverter.ToInt16(buffer, num)
					Me.sproKeyMonitorInfo.developerId = BitConverter.ToInt16(buffer, num + 2)
					Me.sproKeyMonitorInfo.hardLimit = BitConverter.ToInt16(buffer, num + 4)
					Me.sproKeyMonitorInfo.inUse = BitConverter.ToInt16(buffer, num + 6)
					Me.sproKeyMonitorInfo.numTimeOut = BitConverter.ToInt16(buffer, num + 8)
					Me.sproKeyMonitorInfo.highestUse = BitConverter.ToInt16(buffer, num + 10)
				End Sub

				Public serverName As Byte()

				Public serverIPAddress As Byte()

				Public serverIPXAddress As Byte()

				Public version As Byte()

				Public protocol As Short

				Public sproKeyMonitorInfo As SuperproLib.SuperproClass.KeyInfo
			End Class

			Public Enum PROTOCOL_FLAG
				NSPRO_TCP_PROTOCOL = 1
				NSPRO_IPX_PROTOCOL
				NSPRO_NETBEUI_PROTOCOL = 4
				NSPRO_SAP_PROTOCOL = 8
			End Enum

			Public Enum ENUM_SERVER_FLAG
				NSPRO_RET_ON_FIRST = 1
				NSPRO_GET_ALL_SERVERS
				NSPRO_RET_ON_FIRST_AVAILABLE = 4
			End Enum
		End Class
	End Module
End Namespace
