Imports System
Imports System.Diagnostics
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	Friend Class CThetaApp
		Public ReadOnly Property Comments As String
			Get
				Dim num As Integer
				Dim num2 As Integer
				Dim obj As Object
				Try
					Dim text As String = "CThetaApplication.get_Comments"
					Me.TrTraceIn(text)
					ProjectData.ClearProjectError()
					num = 2
					text = "CThetaApplication.get_Comments"
					Me.TrTraceOut(text)
					IL_25:
					GoTo IL_68
					IL_27:
					num2 = -1
					switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
					IL_3B:
				Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num2 = 0)
					Dim ex As Exception = CType(obj2, Exception)
					GoTo IL_27
				End Try
				Throw ProjectData.CreateProjectError(-2146828237)
				IL_68:
				Dim text2 As String
				Dim result As String = text2
				If num2 <> 0 Then
					ProjectData.ClearProjectError()
				End If
				Return result
			End Get
		End Property

		Public ReadOnly Property CompanyName As String
			Get
				Dim num As Integer
				Dim companyName As String
				Dim num2 As Integer
				Dim obj As Object
				Try
					Dim text As String = "CThetaApplication.get_CompanyName"
					Me.TrTraceIn(text)
					ProjectData.ClearProjectError()
					num = 2
					companyName = Application.CompanyName
					text = "CThetaApplication.get_CompanyName"
					Me.TrTraceOut(text)
					IL_2B:
					GoTo IL_6E
					IL_2D:
					num2 = -1
					switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
					IL_41:
				Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num2 = 0)
					Dim ex As Exception = CType(obj2, Exception)
					GoTo IL_2D
				End Try
				Throw ProjectData.CreateProjectError(-2146828237)
				IL_6E:
				Dim result As String = companyName
				If num2 <> 0 Then
					ProjectData.ClearProjectError()
				End If
				Return result
			End Get
		End Property

		Public ReadOnly Property EXEName As String
			Get
				Dim num As Integer
				Dim text2 As String
				Dim num2 As Integer
				Dim obj As Object
				Try
					Dim text As String = "CThetaApplication.get_EXEName"
					Me.TrTraceIn(text)
					ProjectData.ClearProjectError()
					num = 2
					text2 = Application.ProductName
					If Not RSWIN_DESC.bRodStarD Then
						text2 = text2.Replace("-D", "-V")
					End If
					text = "CThetaApplication.get_EXEName"
					Me.TrTraceOut(text)
					IL_43:
					GoTo IL_86
					IL_45:
					num2 = -1
					switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
					IL_59:
				Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num2 = 0)
					Dim ex As Exception = CType(obj2, Exception)
					GoTo IL_45
				End Try
				Throw ProjectData.CreateProjectError(-2146828237)
				IL_86:
				Dim result As String = text2
				If num2 <> 0 Then
					ProjectData.ClearProjectError()
				End If
				Return result
			End Get
		End Property

		Public ReadOnly Property FileDescription As String
			Get
				Dim num As Integer
				Dim num2 As Integer
				Dim obj As Object
				Try
					Dim text As String = "CThetaApplication.get_FileDescription"
					Me.TrTraceIn(text)
					ProjectData.ClearProjectError()
					num = 2
					text = "CThetaApplication.get_FileDescription"
					Me.TrTraceOut(text)
					IL_25:
					GoTo IL_68
					IL_27:
					num2 = -1
					switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
					IL_3B:
				Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num2 = 0)
					Dim ex As Exception = CType(obj2, Exception)
					GoTo IL_27
				End Try
				Throw ProjectData.CreateProjectError(-2146828237)
				IL_68:
				Dim text2 As String
				Dim result As String = text2
				If num2 <> 0 Then
					ProjectData.ClearProjectError()
				End If
				Return result
			End Get
		End Property

		Public Property HelpFile As String
			Get
				Dim num As Integer
				Dim text2 As String
				Dim num2 As Integer
				Dim obj As Object
				Try
					Dim text As String = "CThetaApplication.get_HelpFile"
					Me.TrTraceIn(text)
					ProjectData.ClearProjectError()
					num = 2
					text2 = text2
					text = "CThetaApplication.get_HelpFile"
					Me.TrTraceOut(text)
					IL_27:
					GoTo IL_6A
					IL_29:
					num2 = -1
					switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
					IL_3D:
				Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num2 = 0)
					Dim ex As Exception = CType(obj2, Exception)
					GoTo IL_29
				End Try
				Throw ProjectData.CreateProjectError(-2146828237)
				IL_6A:
				Dim result As String = text2
				If num2 <> 0 Then
					ProjectData.ClearProjectError()
				End If
				Return result
			End Get
			Set(value As String)
				Dim num As Integer
				Dim num2 As Integer
				Dim obj As Object
				Try
					Dim text As String = "CThetaApplication.let_HelpFile"
					Me.TrTraceIn(text)
					ProjectData.ClearProjectError()
					num = 2
					text = "CThetaApplication.let_HelpFile"
					Me.TrTraceOut(text)
					IL_25:
					GoTo IL_68
					IL_27:
					num2 = -1
					switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
					IL_3B:
				Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num2 = 0)
					Dim ex As Exception = CType(obj2, Exception)
					GoTo IL_27
				End Try
				Throw ProjectData.CreateProjectError(-2146828237)
				IL_68:
				If num2 <> 0 Then
					ProjectData.ClearProjectError()
				End If
			End Set
		End Property

		Public ReadOnly Property hInstance As Integer
			Get
				Dim num As Integer
				Dim num2 As Integer
				Dim obj As Object
				Try
					Dim text As String = "CThetaApplication.get_hInstance"
					Me.TrTraceIn(text)
					ProjectData.ClearProjectError()
					num = 2
					text = "CThetaApplication.get_hInstance"
					Me.TrTraceOut(text)
					IL_25:
					GoTo IL_68
					IL_27:
					num2 = -1
					switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
					IL_3B:
				Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num2 = 0)
					Dim ex As Exception = CType(obj2, Exception)
					GoTo IL_27
				End Try
				Throw ProjectData.CreateProjectError(-2146828237)
				IL_68:
				Dim num3 As Integer
				Dim result As Integer = num3
				If num2 <> 0 Then
					ProjectData.ClearProjectError()
				End If
				Return result
			End Get
		End Property

		Public ReadOnly Property LegalCopyright As String
			Get
				Dim num As Integer
				Dim num2 As Integer
				Dim obj As Object
				Try
					Dim text As String = "CThetaApplication.get_LegalCopyright"
					Me.TrTraceIn(text)
					ProjectData.ClearProjectError()
					num = 2
					text = "CThetaApplication.get_LegalCopyright"
					Me.TrTraceOut(text)
					IL_25:
					GoTo IL_68
					IL_27:
					num2 = -1
					switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
					IL_3B:
				Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num2 = 0)
					Dim ex As Exception = CType(obj2, Exception)
					GoTo IL_27
				End Try
				Throw ProjectData.CreateProjectError(-2146828237)
				IL_68:
				Dim text2 As String
				Dim result As String = text2
				If num2 <> 0 Then
					ProjectData.ClearProjectError()
				End If
				Return result
			End Get
		End Property

		Public ReadOnly Property LegalTrademarks As String
			Get
				Dim num As Integer
				Dim num2 As Integer
				Dim obj As Object
				Try
					Dim text As String = "CThetaApplication.get_LegalTrademarks"
					Me.TrTraceIn(text)
					ProjectData.ClearProjectError()
					num = 2
					text = "CThetaApplication.get_LegalTrademarks"
					Me.TrTraceOut(text)
					IL_25:
					GoTo IL_68
					IL_27:
					num2 = -1
					switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
					IL_3B:
				Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num2 = 0)
					Dim ex As Exception = CType(obj2, Exception)
					GoTo IL_27
				End Try
				Throw ProjectData.CreateProjectError(-2146828237)
				IL_68:
				Dim text2 As String
				Dim result As String = text2
				If num2 <> 0 Then
					ProjectData.ClearProjectError()
				End If
				Return result
			End Get
		End Property

		Public ReadOnly Property LogMode As Integer
			Get
				Dim num As Integer
				Dim num2 As Integer
				Dim num3 As Integer
				Dim obj As Object
				Try
					Dim text As String = "CThetaApplication.get_LogMode"
					Me.TrTraceIn(text)
					ProjectData.ClearProjectError()
					num = 2
					num2 = num2
					text = "CThetaApplication.get_LogMode"
					Me.TrTraceOut(text)
					IL_27:
					GoTo IL_6A
					IL_29:
					num3 = -1
					switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
					IL_3D:
				Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num3 = 0)
					Dim ex As Exception = CType(obj2, Exception)
					GoTo IL_29
				End Try
				Throw ProjectData.CreateProjectError(-2146828237)
				IL_6A:
				Dim result As Integer = num2
				If num3 <> 0 Then
					ProjectData.ClearProjectError()
				End If
				Return result
			End Get
		End Property

		Public ReadOnly Property LogPath As String
			Get
				Dim num As Integer
				Dim text2 As String
				Dim num2 As Integer
				Dim obj As Object
				Try
					Dim text As String = "CThetaApplication.get_LogPath"
					Me.TrTraceIn(text)
					ProjectData.ClearProjectError()
					num = 2
					text2 = text2
					text = "CThetaApplication.get_LogPath"
					Me.TrTraceOut(text)
					IL_27:
					GoTo IL_6A
					IL_29:
					num2 = -1
					switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
					IL_3D:
				Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num2 = 0)
					Dim ex As Exception = CType(obj2, Exception)
					GoTo IL_29
				End Try
				Throw ProjectData.CreateProjectError(-2146828237)
				IL_6A:
				Dim result As String = text2
				If num2 <> 0 Then
					ProjectData.ClearProjectError()
				End If
				Return result
			End Get
		End Property

		Public ReadOnly Property NonModalAllowed As Boolean
			Get
				Dim num As Integer
				Dim flag As Boolean
				Dim num2 As Integer
				Dim obj As Object
				Try
					Dim text As String = "CThetaApplication.get_NonModalAllowed"
					Me.TrTraceIn(text)
					ProjectData.ClearProjectError()
					num = 2
					flag = flag
					text = "CThetaApplication.get_NonModalAllowed"
					Me.TrTraceOut(text)
					IL_27:
					GoTo IL_6A
					IL_29:
					num2 = -1
					switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
					IL_3D:
				Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num2 = 0)
					Dim ex As Exception = CType(obj2, Exception)
					GoTo IL_29
				End Try
				Throw ProjectData.CreateProjectError(-2146828237)
				IL_6A:
				Dim result As Boolean = flag
				If num2 <> 0 Then
					ProjectData.ClearProjectError()
				End If
				Return result
			End Get
		End Property

		Public Property OleRequestPendingMsgText As String
			Get
				Dim num As Integer
				Dim text2 As String
				Dim num2 As Integer
				Dim obj As Object
				Try
					Dim text As String = "CThetaApplication.get_OleRequestPendingMsgText"
					Me.TrTraceIn(text)
					ProjectData.ClearProjectError()
					num = 2
					text2 = text2
					text = "CThetaApplication.get_OleRequestPendingMsgText"
					Me.TrTraceOut(text)
					IL_27:
					GoTo IL_6A
					IL_29:
					num2 = -1
					switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
					IL_3D:
				Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num2 = 0)
					Dim ex As Exception = CType(obj2, Exception)
					GoTo IL_29
				End Try
				Throw ProjectData.CreateProjectError(-2146828237)
				IL_6A:
				Dim result As String = text2
				If num2 <> 0 Then
					ProjectData.ClearProjectError()
				End If
				Return result
			End Get
			Set(value As String)
				Dim num As Integer
				Dim num2 As Integer
				Dim obj As Object
				Try
					Dim text As String = "CThetaApplication.let_OleRequestPendingMsgText"
					Me.TrTraceIn(text)
					ProjectData.ClearProjectError()
					num = 2
					text = "CThetaApplication.let_OleRequestPendingMsgText"
					Me.TrTraceOut(text)
					IL_25:
					GoTo IL_68
					IL_27:
					num2 = -1
					switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
					IL_3B:
				Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num2 = 0)
					Dim ex As Exception = CType(obj2, Exception)
					GoTo IL_27
				End Try
				Throw ProjectData.CreateProjectError(-2146828237)
				IL_68:
				If num2 <> 0 Then
					ProjectData.ClearProjectError()
				End If
			End Set
		End Property

		Public Property OleRequestPendingMsgTitle As String
			Get
				Dim num As Integer
				Dim text2 As String
				Dim num2 As Integer
				Dim obj As Object
				Try
					Dim text As String = "CThetaApplication.get_OleRequestPendingMsgTitle"
					Me.TrTraceIn(text)
					ProjectData.ClearProjectError()
					num = 2
					text2 = text2
					text = "CThetaApplication.get_OleRequestPendingMsgTitle"
					Me.TrTraceOut(text)
					IL_27:
					GoTo IL_6A
					IL_29:
					num2 = -1
					switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
					IL_3D:
				Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num2 = 0)
					Dim ex As Exception = CType(obj2, Exception)
					GoTo IL_29
				End Try
				Throw ProjectData.CreateProjectError(-2146828237)
				IL_6A:
				Dim result As String = text2
				If num2 <> 0 Then
					ProjectData.ClearProjectError()
				End If
				Return result
			End Get
			Set(value As String)
				Dim num As Integer
				Dim num2 As Integer
				Dim obj As Object
				Try
					Dim text As String = "CThetaApplication.let_OleRequestPendingMsgTitle"
					Me.TrTraceIn(text)
					ProjectData.ClearProjectError()
					num = 2
					text = "CThetaApplication.let_OleRequestPendingMsgTitle"
					Me.TrTraceOut(text)
					IL_25:
					GoTo IL_68
					IL_27:
					num2 = -1
					switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
					IL_3B:
				Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num2 = 0)
					Dim ex As Exception = CType(obj2, Exception)
					GoTo IL_27
				End Try
				Throw ProjectData.CreateProjectError(-2146828237)
				IL_68:
				If num2 <> 0 Then
					ProjectData.ClearProjectError()
				End If
			End Set
		End Property

		Public Property OleRequestPendingTimeout As Integer
			Get
				Dim num As Integer
				Dim num2 As Integer
				Dim num3 As Integer
				Dim obj As Object
				Try
					Dim text As String = "CThetaApplication.get_OleRequestPendingTimeout"
					Me.TrTraceIn(text)
					ProjectData.ClearProjectError()
					num = 2
					num2 = num2
					text = "CThetaApplication.get_OleRequestPendingTimeout"
					Me.TrTraceOut(text)
					IL_27:
					GoTo IL_6A
					IL_29:
					num3 = -1
					switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
					IL_3D:
				Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num3 = 0)
					Dim ex As Exception = CType(obj2, Exception)
					GoTo IL_29
				End Try
				Throw ProjectData.CreateProjectError(-2146828237)
				IL_6A:
				Dim result As Integer = num2
				If num3 <> 0 Then
					ProjectData.ClearProjectError()
				End If
				Return result
			End Get
			Set(value As Integer)
				Dim num As Integer
				Dim num2 As Integer
				Dim obj As Object
				Try
					Dim text As String = "CThetaApplication.let_OleRequestPendingTimeout"
					Me.TrTraceIn(text)
					ProjectData.ClearProjectError()
					num = 2
					text = "CThetaApplication.let_OleRequestPendingTimeout"
					Me.TrTraceOut(text)
					IL_25:
					GoTo IL_68
					IL_27:
					num2 = -1
					switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
					IL_3B:
				Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num2 = 0)
					Dim ex As Exception = CType(obj2, Exception)
					GoTo IL_27
				End Try
				Throw ProjectData.CreateProjectError(-2146828237)
				IL_68:
				If num2 <> 0 Then
					ProjectData.ClearProjectError()
				End If
			End Set
		End Property

		Public Property OleServerBusyMsgText As String
			Get
				Dim num As Integer
				Dim text2 As String
				Dim num2 As Integer
				Dim obj As Object
				Try
					Dim text As String = "CThetaApplication.get_OleServerBusyMsgText"
					Me.TrTraceIn(text)
					ProjectData.ClearProjectError()
					num = 2
					text2 = text2
					text = "CThetaApplication.get_OleServerBusyMsgText"
					Me.TrTraceOut(text)
					IL_27:
					GoTo IL_6A
					IL_29:
					num2 = -1
					switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
					IL_3D:
				Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num2 = 0)
					Dim ex As Exception = CType(obj2, Exception)
					GoTo IL_29
				End Try
				Throw ProjectData.CreateProjectError(-2146828237)
				IL_6A:
				Dim result As String = text2
				If num2 <> 0 Then
					ProjectData.ClearProjectError()
				End If
				Return result
			End Get
			Set(value As String)
				Dim num As Integer
				Dim num2 As Integer
				Dim obj As Object
				Try
					Dim text As String = "CThetaApplication.let_OleServerBusyMsgText"
					Me.TrTraceIn(text)
					ProjectData.ClearProjectError()
					num = 2
					text = "CThetaApplication.let_OleServerBusyMsgText"
					Me.TrTraceOut(text)
					IL_25:
					GoTo IL_68
					IL_27:
					num2 = -1
					switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
					IL_3B:
				Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num2 = 0)
					Dim ex As Exception = CType(obj2, Exception)
					GoTo IL_27
				End Try
				Throw ProjectData.CreateProjectError(-2146828237)
				IL_68:
				If num2 <> 0 Then
					ProjectData.ClearProjectError()
				End If
			End Set
		End Property

		Public Property OleServerBusyMsgTitle As String
			Get
				Dim num As Integer
				Dim text2 As String
				Dim num2 As Integer
				Dim obj As Object
				Try
					Dim text As String = "CThetaApplication.get_OleServerBusyMsgTitle"
					Me.TrTraceIn(text)
					ProjectData.ClearProjectError()
					num = 2
					text2 = text2
					text = "CThetaApplication.get_OleServerBusyMsgTitle"
					Me.TrTraceOut(text)
					IL_27:
					GoTo IL_6A
					IL_29:
					num2 = -1
					switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
					IL_3D:
				Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num2 = 0)
					Dim ex As Exception = CType(obj2, Exception)
					GoTo IL_29
				End Try
				Throw ProjectData.CreateProjectError(-2146828237)
				IL_6A:
				Dim result As String = text2
				If num2 <> 0 Then
					ProjectData.ClearProjectError()
				End If
				Return result
			End Get
			Set(value As String)
				Dim num As Integer
				Dim num2 As Integer
				Dim obj As Object
				Try
					Dim text As String = "CThetaApplication.let_OleServerBusyMsgTitle"
					Me.TrTraceIn(text)
					ProjectData.ClearProjectError()
					num = 2
					text = "CThetaApplication.let_OleServerBusyMsgTitle"
					Me.TrTraceOut(text)
					IL_25:
					GoTo IL_68
					IL_27:
					num2 = -1
					switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
					IL_3B:
				Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num2 = 0)
					Dim ex As Exception = CType(obj2, Exception)
					GoTo IL_27
				End Try
				Throw ProjectData.CreateProjectError(-2146828237)
				IL_68:
				If num2 <> 0 Then
					ProjectData.ClearProjectError()
				End If
			End Set
		End Property

		Public Property OleServerBusyRaiseError As Boolean
			Get
				Dim num As Integer
				Dim flag As Boolean
				Dim num2 As Integer
				Dim obj As Object
				Try
					Dim text As String = "CThetaApplication.get_OleServerBusyRaiseError"
					Me.TrTraceIn(text)
					ProjectData.ClearProjectError()
					num = 2
					flag = flag
					text = "CThetaApplication.get_OleServerBusyRaiseError"
					Me.TrTraceOut(text)
					IL_27:
					GoTo IL_6A
					IL_29:
					num2 = -1
					switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
					IL_3D:
				Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num2 = 0)
					Dim ex As Exception = CType(obj2, Exception)
					GoTo IL_29
				End Try
				Throw ProjectData.CreateProjectError(-2146828237)
				IL_6A:
				Dim result As Boolean = flag
				If num2 <> 0 Then
					ProjectData.ClearProjectError()
				End If
				Return result
			End Get
			Set(value As Boolean)
				Dim num As Integer
				Dim num2 As Integer
				Dim obj As Object
				Try
					Dim text As String = "CThetaApplication.let_OleServerBusyRaiseError"
					Me.TrTraceIn(text)
					ProjectData.ClearProjectError()
					num = 2
					text = "CThetaApplication.let_OleServerBusyRaiseError"
					Me.TrTraceOut(text)
					IL_25:
					GoTo IL_68
					IL_27:
					num2 = -1
					switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
					IL_3B:
				Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num2 = 0)
					Dim ex As Exception = CType(obj2, Exception)
					GoTo IL_27
				End Try
				Throw ProjectData.CreateProjectError(-2146828237)
				IL_68:
				If num2 <> 0 Then
					ProjectData.ClearProjectError()
				End If
			End Set
		End Property

		Public Property OleServerBusyTimeout As Integer
			Get
				Dim num As Integer
				Dim num2 As Integer
				Dim num3 As Integer
				Dim obj As Object
				Try
					Dim text As String = "CThetaApplication.get_OleServerBusyTimeout"
					Me.TrTraceIn(text)
					ProjectData.ClearProjectError()
					num = 2
					num2 = num2
					text = "CThetaApplication.get_OleServerBusyTimeout"
					Me.TrTraceOut(text)
					IL_27:
					GoTo IL_6A
					IL_29:
					num3 = -1
					switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
					IL_3D:
				Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num3 = 0)
					Dim ex As Exception = CType(obj2, Exception)
					GoTo IL_29
				End Try
				Throw ProjectData.CreateProjectError(-2146828237)
				IL_6A:
				Dim result As Integer = num2
				If num3 <> 0 Then
					ProjectData.ClearProjectError()
				End If
				Return result
			End Get
			Set(value As Integer)
				Dim num As Integer
				Dim num2 As Integer
				Dim obj As Object
				Try
					Dim text As String = "CThetaApplication.let_OleServerBusyTimeout"
					Me.TrTraceIn(text)
					ProjectData.ClearProjectError()
					num = 2
					text = "CThetaApplication.let_OleServerBusyTimeout"
					Me.TrTraceOut(text)
					IL_25:
					GoTo IL_68
					IL_27:
					num2 = -1
					switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
					IL_3B:
				Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num2 = 0)
					Dim ex As Exception = CType(obj2, Exception)
					GoTo IL_27
				End Try
				Throw ProjectData.CreateProjectError(-2146828237)
				IL_68:
				If num2 <> 0 Then
					ProjectData.ClearProjectError()
				End If
			End Set
		End Property

		Public ReadOnly Property Path As String
			Get
				Dim num As Integer
				Dim startupPath As String
				Dim num2 As Integer
				Dim obj As Object
				Try
					Dim text As String = "CThetaApplication.get_Path"
					Me.TrTraceIn(text)
					ProjectData.ClearProjectError()
					num = 2
					startupPath = Application.StartupPath
					text = "CThetaApplication.get_Path"
					Me.TrTraceOut(text)
					IL_2B:
					GoTo IL_6E
					IL_2D:
					num2 = -1
					switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
					IL_41:
				Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num2 = 0)
					Dim ex As Exception = CType(obj2, Exception)
					GoTo IL_2D
				End Try
				Throw ProjectData.CreateProjectError(-2146828237)
				IL_6E:
				Dim result As String = startupPath
				If num2 <> 0 Then
					ProjectData.ClearProjectError()
				End If
				Return result
			End Get
		End Property

		Public ReadOnly Property PrevInstance As Boolean
			Get
				Dim num As Integer
				Dim num2 As Integer
				Dim obj As Object
				Try
					Dim text As String = "CThetaApplication.get_PrevInstance"
					Me.TrTraceIn(text)
					ProjectData.ClearProjectError()
					num = 2
					text = "CThetaApplication.get_PrevInstance"
					Me.TrTraceOut(text)
					IL_25:
					GoTo IL_68
					IL_27:
					num2 = -1
					switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
					IL_3B:
				Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num2 = 0)
					Dim ex As Exception = CType(obj2, Exception)
					GoTo IL_27
				End Try
				Throw ProjectData.CreateProjectError(-2146828237)
				IL_68:
				Dim flag As Boolean
				Dim result As Boolean = flag
				If num2 <> 0 Then
					ProjectData.ClearProjectError()
				End If
				Return result
			End Get
		End Property

		Public ReadOnly Property ProductName As String
			Get
				Dim num As Integer
				Dim text2 As String
				Dim num2 As Integer
				Dim obj As Object
				Try
					Dim text As String = "CThetaApplication.get_ProductName"
					Me.TrTraceIn(text)
					ProjectData.ClearProjectError()
					num = 2
					text2 = Application.ProductName
					If Not RSWIN_DESC.bRodStarD Then
						text2 = text2.Replace("-D", "-V")
					End If
					text = "CThetaApplication.get_ProductName"
					Me.TrTraceOut(text)
					IL_43:
					GoTo IL_86
					IL_45:
					num2 = -1
					switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
					IL_59:
				Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num2 = 0)
					Dim ex As Exception = CType(obj2, Exception)
					GoTo IL_45
				End Try
				Throw ProjectData.CreateProjectError(-2146828237)
				IL_86:
				Dim result As String = text2
				If num2 <> 0 Then
					ProjectData.ClearProjectError()
				End If
				Return result
			End Get
		End Property

		Public ReadOnly Property RetainedProject As Boolean
			Get
				Dim num As Integer
				Dim flag As Boolean
				Dim num2 As Integer
				Dim obj As Object
				Try
					Dim text As String = "CThetaApplication.get_RetainedProject"
					Me.TrTraceIn(text)
					ProjectData.ClearProjectError()
					num = 2
					flag = flag
					text = "CThetaApplication.get_RetainedProject"
					Me.TrTraceOut(text)
					IL_27:
					GoTo IL_6A
					IL_29:
					num2 = -1
					switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
					IL_3D:
				Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num2 = 0)
					Dim ex As Exception = CType(obj2, Exception)
					GoTo IL_29
				End Try
				Throw ProjectData.CreateProjectError(-2146828237)
				IL_6A:
				Dim result As Boolean = flag
				If num2 <> 0 Then
					ProjectData.ClearProjectError()
				End If
				Return result
			End Get
		End Property

		Public ReadOnly Property Revision As Short
			Get
				Dim num As Integer
				Dim num2 As Integer
				Dim obj As Object
				Try
					Dim text As String = "CThetaApplication.get_Revision"
					Me.TrTraceIn(text)
					ProjectData.ClearProjectError()
					num = 2
					text = "CThetaApplication.get_Revision"
					Me.TrTraceOut(text)
					IL_25:
					GoTo IL_68
					IL_27:
					num2 = -1
					switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
					IL_3B:
				Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num2 = 0)
					Dim ex As Exception = CType(obj2, Exception)
					GoTo IL_27
				End Try
				Throw ProjectData.CreateProjectError(-2146828237)
				IL_68:
				Dim num3 As Short
				Dim result As Short = num3
				If num2 <> 0 Then
					ProjectData.ClearProjectError()
				End If
				Return result
			End Get
		End Property

		Public ReadOnly Property StartMode As Short
			Get
				Dim num As Integer
				Dim num2 As Short
				Dim num3 As Integer
				Dim obj As Object
				Try
					Dim text As String = "CThetaApplication.get_StartMode"
					Me.TrTraceIn(text)
					ProjectData.ClearProjectError()
					num = 2
					num2 = num2
					text = "CThetaApplication.get_StartMode"
					Me.TrTraceOut(text)
					IL_27:
					GoTo IL_6A
					IL_29:
					num3 = -1
					switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
					IL_3D:
				Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num3 = 0)
					Dim ex As Exception = CType(obj2, Exception)
					GoTo IL_29
				End Try
				Throw ProjectData.CreateProjectError(-2146828237)
				IL_6A:
				Dim result As Short = num2
				If num3 <> 0 Then
					ProjectData.ClearProjectError()
				End If
				Return result
			End Get
		End Property

		Public Property TaskVisible As Boolean
			Get
				Dim num As Integer
				Dim flag As Boolean
				Dim num2 As Integer
				Dim obj As Object
				Try
					Dim text As String = "CThetaApplication.get_TaskVisible"
					Me.TrTraceIn(text)
					ProjectData.ClearProjectError()
					num = 2
					flag = flag
					text = "CThetaApplication.get_TaskVisible"
					Me.TrTraceOut(text)
					IL_27:
					GoTo IL_6A
					IL_29:
					num2 = -1
					switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
					IL_3D:
				Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num2 = 0)
					Dim ex As Exception = CType(obj2, Exception)
					GoTo IL_29
				End Try
				Throw ProjectData.CreateProjectError(-2146828237)
				IL_6A:
				Dim result As Boolean = flag
				If num2 <> 0 Then
					ProjectData.ClearProjectError()
				End If
				Return result
			End Get
			Set(value As Boolean)
				Dim num As Integer
				Dim num2 As Integer
				Dim obj As Object
				Try
					Dim text As String = "CThetaApplication.let_TaskVisible"
					Me.TrTraceIn(text)
					ProjectData.ClearProjectError()
					num = 2
					text = "CThetaApplication.let_TaskVisible"
					Me.TrTraceOut(text)
					IL_25:
					GoTo IL_68
					IL_27:
					num2 = -1
					switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
					IL_3B:
				Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num2 = 0)
					Dim ex As Exception = CType(obj2, Exception)
					GoTo IL_27
				End Try
				Throw ProjectData.CreateProjectError(-2146828237)
				IL_68:
				If num2 <> 0 Then
					ProjectData.ClearProjectError()
				End If
			End Set
		End Property

		Public ReadOnly Property ThreadID As Integer
			Get
				Dim num As Integer
				Dim num2 As Integer
				Dim obj As Object
				Try
					Dim text As String = "CThetaApplication.get_ThreadID"
					Me.TrTraceIn(text)
					ProjectData.ClearProjectError()
					num = 2
					text = "CThetaApplication.get_ThreadID"
					Me.TrTraceOut(text)
					IL_25:
					GoTo IL_68
					IL_27:
					num2 = -1
					switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
					IL_3B:
				Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num2 = 0)
					Dim ex As Exception = CType(obj2, Exception)
					GoTo IL_27
				End Try
				Throw ProjectData.CreateProjectError(-2146828237)
				IL_68:
				Dim num3 As Integer
				Dim result As Integer = num3
				If num2 <> 0 Then
					ProjectData.ClearProjectError()
				End If
				Return result
			End Get
		End Property

		Public Property Title As String
			Get
				Dim num As Integer
				Dim num2 As Integer
				Dim obj As Object
				Try
					Dim text As String = "CThetaApplication.get_Title"
					Me.TrTraceIn(text)
					ProjectData.ClearProjectError()
					num = 2
					text = "CThetaApplication.get_Title"
					Me.TrTraceOut(text)
					IL_25:
					GoTo IL_68
					IL_27:
					num2 = -1
					switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
					IL_3B:
				Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num2 = 0)
					Dim ex As Exception = CType(obj2, Exception)
					GoTo IL_27
				End Try
				Throw ProjectData.CreateProjectError(-2146828237)
				IL_68:
				Dim text2 As String
				Dim result As String = text2
				If num2 <> 0 Then
					ProjectData.ClearProjectError()
				End If
				Return result
			End Get
			Set(value As String)
				Dim num As Integer
				Dim num2 As Integer
				Dim obj As Object
				Try
					Dim text As String = "CThetaApplication.let_Title"
					Me.TrTraceIn(text)
					ProjectData.ClearProjectError()
					num = 2
					text = "CThetaApplication.let_Title"
					Me.TrTraceOut(text)
					IL_25:
					GoTo IL_68
					IL_27:
					num2 = -1
					switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
					IL_3B:
				Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num2 = 0)
					Dim ex As Exception = CType(obj2, Exception)
					GoTo IL_27
				End Try
				Throw ProjectData.CreateProjectError(-2146828237)
				IL_68:
				If num2 <> 0 Then
					ProjectData.ClearProjectError()
				End If
			End Set
		End Property

		Public ReadOnly Property UnattendedApp As Boolean
			Get
				Dim num As Integer
				Dim flag As Boolean
				Dim num2 As Integer
				Dim obj As Object
				Try
					Dim text As String = "CThetaApplication.get_UnattendedApp"
					Me.TrTraceIn(text)
					ProjectData.ClearProjectError()
					num = 2
					flag = flag
					text = "CThetaApplication.get_UnattendedApp"
					Me.TrTraceOut(text)
					IL_27:
					GoTo IL_6A
					IL_29:
					num2 = -1
					switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
					IL_3D:
				Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num2 = 0)
					Dim ex As Exception = CType(obj2, Exception)
					GoTo IL_29
				End Try
				Throw ProjectData.CreateProjectError(-2146828237)
				IL_6A:
				Dim result As Boolean = flag
				If num2 <> 0 Then
					ProjectData.ClearProjectError()
				End If
				Return result
			End Get
		End Property

		Public Function InDesign() As Boolean
			Dim num As Integer
			Dim flag As Boolean
			Dim num2 As Integer
			Dim obj As Object
			Try
				Dim text As String = "CThetaApplication.InDesign"
				Me.TrTraceIn(text)
				ProjectData.ClearProjectError()
				num = 2
				If Information.IsNothing(RuntimeHelpers.GetObjectValue(Me.$STATIC$InDesign$2002$Counter)) Then
					Me.$STATIC$InDesign$2002$Counter = 1
					Debug.Assert(Me.InDesign() Or True, "")
					Me.$STATIC$InDesign$2002$Counter = Operators.SubtractObject(Me.$STATIC$InDesign$2002$Counter, 1)
				ElseIf Operators.ConditionalCompareObjectEqual(Me.$STATIC$InDesign$2002$Counter, 1, False) Then
					Me.$STATIC$InDesign$2002$Counter = 0
				End If
				flag = Conversions.ToBoolean(Me.$STATIC$InDesign$2002$Counter)
				text = "CThetaApplication.InDesign"
				Me.TrTraceOut(text)
				IL_9A:
				GoTo IL_DD
				IL_9C:
				num2 = -1
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_B0:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num2 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_9C
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_DD:
			Dim result As Boolean = flag
			If num2 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		Public Sub LogEvent(ByRef LogBuffer As String, Optional ByRef EventType As Object = Nothing)
			Dim num As Integer
			Dim num2 As Integer
			Dim obj As Object
			Try
				Dim text As String = "CThetaApplication.LogEvent"
				Me.TrTraceIn(text)
				ProjectData.ClearProjectError()
				num = 2
				text = "CThetaApplication.LogEvent"
				Me.TrTraceOut(text)
				IL_25:
				GoTo IL_68
				IL_27:
				num2 = -1
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_3B:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num2 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_27
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_68:
			If num2 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		Public Sub StartLogging(ByRef LogTarget As String, ByRef LogModes As Integer)
			Dim num As Integer
			Dim num2 As Integer
			Dim obj As Object
			Try
				Dim text As String = "CThetaApplication.StartLogging"
				Me.TrTraceIn(text)
				ProjectData.ClearProjectError()
				num = 2
				text = "CThetaApplication.StartLogging"
				Me.TrTraceOut(text)
				IL_25:
				GoTo IL_68
				IL_27:
				num2 = -1
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_3B:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num2 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_27
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_68:
			If num2 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		Public Sub TrTraceIn(ByRef sTrace As String)
			' The following expression was wrapped in a checked-statement
			Dim num As Integer
			Dim num2 As Integer
			Dim obj As Object
			Try
				ProjectData.ClearProjectError()
				num = 2
				If Me.miCallStackPtr >= Me.mcCallStackSize Then
					Me.mcCallStackSize += 64
					Me.mrgCallStack = CType(Utils.CopyArray(CType(Me.mrgCallStack, Array), New String(Me.mcCallStackSize - 1 + 1 - 1) {}), String())
				End If
				Me.mrgCallStack(Me.miCallStackPtr) = sTrace
				Me.miCallStackPtr += 1
				IL_6D:
				GoTo IL_B0
				IL_6F:
				num2 = -1
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_83:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num2 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_6F
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_B0:
			If num2 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		Public Function TrTraceItem(Index As Integer) As String
			Dim num As Integer
			Dim text As String
			Dim num2 As Integer
			Dim obj As Object
			Try
				ProjectData.ClearProjectError()
				num = 2
				If Index >= 0 AndAlso Index <= Me.miCallStackPtr - 1 Then
					text = Me.mrgCallStack(Index)
				Else
					text = Nothing
				End If
				IL_27:
				GoTo IL_6A
				IL_29:
				num2 = -1
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_3D:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num2 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_29
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_6A:
			Dim result As String = text
			If num2 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		Public Sub TrTraceOut(ByRef sTrace As String)
			' The following expression was wrapped in a checked-statement
			Dim num As Integer
			Dim num2 As Integer
			Dim obj As Object
			Try
				ProjectData.ClearProjectError()
				num = 2
				For i As Integer = Me.miCallStackPtr - 1 To 0 Step -1
					If Operators.CompareString(Me.mrgCallStack(i), sTrace, False) = 0 Then
						Me.miCallStackPtr = i
						Exit For
					End If
				Next
				IL_38:
				GoTo IL_7B
				IL_3A:
				num2 = -1
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_4E:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num2 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_3A
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_7B:
			If num2 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		Public Function TrTraceSize() As Integer
			Dim num As Integer
			Dim num2 As Integer
			Dim num3 As Integer
			Dim obj As Object
			Try
				Dim text As String = "CThetaApplication.TrTraceSize"
				Me.TrTraceIn(text)
				ProjectData.ClearProjectError()
				num = 2
				num2 = Me.miCallStackPtr
				text = "CThetaApplication.TrTraceSize"
				Me.TrTraceOut(text)
				IL_2C:
				GoTo IL_6F
				IL_2E:
				num3 = -1
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_42:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num3 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_2E
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_6F:
			Dim result As Integer = num2
			If num3 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		Private Sub ClassInitialize()
			Dim num As Integer
			Dim num2 As Integer
			Dim obj As Object
			Try
				Dim text As String = "CThetaApplication.ClassInitialize"
				Me.TrTraceIn(text)
				ProjectData.ClearProjectError()
				num = 2
				Me.mcCallStackSize = 64
				Me.mrgCallStack = New String(Me.mcCallStackSize - 1 + 1 - 1) {}
				Me.miCallStackPtr = 0
				text = "CThetaApplication.ClassInitialize"
				Me.TrTraceOut(text)
				IL_49:
				GoTo IL_8C
				IL_4B:
				num2 = -1
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_5F:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num2 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_4B
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_8C:
			If num2 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		Public Sub New()
			Me.ClassInitialize()
		End Sub

		Private Sub ClassTerminate()
			Dim num As Integer
			Dim num2 As Integer
			Dim obj As Object
			Try
				Dim text As String = "CThetaApplication.ClassTerminate"
				Me.TrTraceIn(text)
				ProjectData.ClearProjectError()
				num = 2
				text = "CThetaApplication.ClassTerminate"
				Me.TrTraceOut(text)
				IL_25:
				GoTo IL_68
				IL_27:
				num2 = -1
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_3B:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num2 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_27
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_68:
			If num2 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		Protected Overrides Sub Finalize()
			Me.ClassTerminate()
			MyBase.Finalize()
		End Sub

		Private Const MODULESIG As String = "CThetaApplication."

		Private Const CALLSTACKREALLOCSIZE As Integer = 64

		Private mcCallStackSize As Integer

		Private miCallStackPtr As Integer

		Private mrgCallStack As String()

		Private $STATIC$InDesign$2002$Counter As Object
	End Class
End Namespace
