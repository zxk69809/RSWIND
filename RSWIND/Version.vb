Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace RSWINV3
	Friend Partial Class Version
		Inherits Form

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.Version_Load
			If Version.m_vb6FormDefInstance Is Nothing Then
				If Version.m_InitializingDefInstance Then
					Version.m_vb6FormDefInstance = Me
				Else
					Try
						If Assembly.GetExecutingAssembly().EntryPoint.DeclaringType Is Me.[GetType]() Then
							Version.m_vb6FormDefInstance = Me
						End If
					Catch ex As Exception
					End Try
				End If
			End If
			Me.InitializeComponent()
		End Sub

		Public Overridable Property VerStamp As PictureBox
			Get
				Return Me._VerStamp
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._VerStamp = value
			End Set
		End Property

		Public Shared Property DefInstance As Version
			Get
				If Version.m_vb6FormDefInstance Is Nothing OrElse Version.m_vb6FormDefInstance.IsDisposed Then
					Version.m_InitializingDefInstance = True
					Version.m_vb6FormDefInstance = New Version()
					Version.m_InitializingDefInstance = False
				End If
				Return Version.m_vb6FormDefInstance
			End Get
			Set(value As Version)
				Version.m_vb6FormDefInstance = value
			End Set
		End Property

		Private Sub Version_Load(sender As Object, e As EventArgs)
			If RSWIN_DESC.bWriteResXFile Then
				Util.OpenResourceWriter(Me.Name)
				Util.WriteControlStrings(Me, Me.ToolTip1)
				Util.CloseResourceWriter()
			End If
		End Sub

		<AccessedThroughProperty("VerStamp")>
		Private _VerStamp As PictureBox

		Private Shared m_vb6FormDefInstance As Version

		Private Shared m_InitializingDefInstance As Boolean
	End Class
End Namespace
