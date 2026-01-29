Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Data.OleDb
Imports System.Diagnostics
Imports System.Drawing
Imports System.Globalization
Imports System.IO
Imports System.Linq
Imports System.Reflection
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports DataDynamics.ActiveReports.DataSources
Imports DataDynamics.ActiveReports.Document
Imports DataDynamics.ActiveReports.Viewer
Imports Infragistics.Win.Misc.CommonControls
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.Compatibility.VB6
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.Win32
Imports ThetaLMNet

Namespace RSWINV3
	Public Partial Class RODSTAR
		Inherits Form

		Public Shared Property DefInstance As RODSTAR
			Get
				If RODSTAR.m_vb6FormDefInstance Is Nothing OrElse RODSTAR.m_vb6FormDefInstance.IsDisposed Then
					RODSTAR.m_InitializingDefInstance = True
					RODSTAR.m_vb6FormDefInstance = New RODSTAR()
					RODSTAR.m_InitializingDefInstance = False
				End If
				Return RODSTAR.m_vb6FormDefInstance
			End Get
			Set(value As RODSTAR)
				RODSTAR.m_vb6FormDefInstance = value
			End Set
		End Property

		Private Overridable Property dlgSelectDir As dlgSelectDir
			Get
				Return Me._dlgSelectDir
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As dlgSelectDir)
				Me._dlgSelectDir = value
			End Set
		End Property

		Private Overridable Property frmSystemOfUnits As SystemOfUnits
			Get
				Return Me._frmSystemOfUnits
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As SystemOfUnits)
				Me._frmSystemOfUnits = value
			End Set
		End Property

		Public Property bClosing As Boolean
			Get
				Return Me.m_bClosing
			End Get
			Set(value As Boolean)
				Me.m_bClosing = value
				RSWIN_DESC.bParentFormClosing = value
			End Set
		End Property

		Private Overridable Property frmHowToStart As frmHowToStart
			Get
				Return Me._frmHowToStart
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As frmHowToStart)
				Me._frmHowToStart = value
			End Set
		End Property

		Private Overridable Property FAboutSplash As FAboutSplash
			Get
				Return Me._FAboutSplash
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As FAboutSplash)
				Me._FAboutSplash = value
			End Set
		End Property

		Private Overridable Property frmDemoMode As frmDemoMode
			Get
				Return Me._frmDemoMode
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As frmDemoMode)
				Me._frmDemoMode = value
			End Set
		End Property

		Private Overridable Property frmLoadGuruFilenames As frmLoadGuruFNames
			Get
				Return Me._frmLoadGuruFilenames
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As frmLoadGuruFNames)
				Me._frmLoadGuruFilenames = value
			End Set
		End Property

		Private Overridable Property frmDisplayAllDatabaseTemplates As db_guru_admin_form
			Get
				Return Me._frmDisplayAllDatabaseTemplates
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As db_guru_admin_form)
				Me._frmDisplayAllDatabaseTemplates = value
			End Set
		End Property

		Private Overridable Property Clock As Clock
			Get
				Return Me._Clock
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Clock)
				Me._Clock = value
			End Set
		End Property

		Public Overridable Property mnuWindowInput As MenuItemArray
			Get
				Return Me._mnuWindowInput
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItemArray)
				Me._mnuWindowInput = value
			End Set
		End Property

		Public Overridable Property mnuFileNew As MenuItem
			Get
				Return Me._mnuFileNew
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim value2 As EventHandler = AddressOf Me.mnuFileNew_Click
				Dim value3 As EventHandler = AddressOf Me.mnuFileNew_Popup
				If Me._mnuFileNew IsNot Nothing Then
					RemoveHandler Me._mnuFileNew.Click, value2
					RemoveHandler Me._mnuFileNew.Popup, value3
				End If
				Me._mnuFileNew = value
				If Me._mnuFileNew IsNot Nothing Then
					AddHandler Me._mnuFileNew.Click, value2
					AddHandler Me._mnuFileNew.Popup, value3
				End If
			End Set
		End Property

		Public Overridable Property mnuFileOpen_ As MenuItem
			Get
				Return Me._mnuFileOpen_
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim value2 As EventHandler = AddressOf Me.mnuFileOpen__Click
				Dim value3 As EventHandler = AddressOf Me.mnuFileOpen__Popup
				If Me._mnuFileOpen_ IsNot Nothing Then
					RemoveHandler Me._mnuFileOpen_.Click, value2
					RemoveHandler Me._mnuFileOpen_.Popup, value3
				End If
				Me._mnuFileOpen_ = value
				If Me._mnuFileOpen_ IsNot Nothing Then
					AddHandler Me._mnuFileOpen_.Click, value2
					AddHandler Me._mnuFileOpen_.Popup, value3
				End If
			End Set
		End Property

		Public Overridable Property mnuFileSave As MenuItem
			Get
				Return Me._mnuFileSave
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim value2 As EventHandler = AddressOf Me.mnuFileSave_Click
				Dim value3 As EventHandler = AddressOf Me.mnuFileSave_Popup
				If Me._mnuFileSave IsNot Nothing Then
					RemoveHandler Me._mnuFileSave.Click, value2
					RemoveHandler Me._mnuFileSave.Popup, value3
				End If
				Me._mnuFileSave = value
				If Me._mnuFileSave IsNot Nothing Then
					AddHandler Me._mnuFileSave.Click, value2
					AddHandler Me._mnuFileSave.Popup, value3
				End If
			End Set
		End Property

		Public Overridable Property mnuFileSaveAs_ As MenuItem
			Get
				Return Me._mnuFileSaveAs_
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim value2 As EventHandler = AddressOf Me.mnuFileSaveAs__Popup
				If Me._mnuFileSaveAs_ IsNot Nothing Then
					RemoveHandler Me._mnuFileSaveAs_.Popup, value2
				End If
				Me._mnuFileSaveAs_ = value
				If Me._mnuFileSaveAs_ IsNot Nothing Then
					AddHandler Me._mnuFileSaveAs_.Popup, value2
				End If
			End Set
		End Property

		Public Overridable Property mnuFileSaveAsRSDX As MenuItem
			Get
				Return Me._mnuFileSaveAsRSDX
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim value2 As EventHandler = AddressOf Me.mnuFileSaveAsRSDX_Click
				Dim value3 As EventHandler = AddressOf Me.mnuFileSaveAsRSDX__Popup
				If Me._mnuFileSaveAsRSDX IsNot Nothing Then
					RemoveHandler Me._mnuFileSaveAsRSDX.Click, value2
					RemoveHandler Me._mnuFileSaveAsRSDX.Popup, value3
				End If
				Me._mnuFileSaveAsRSDX = value
				If Me._mnuFileSaveAsRSDX IsNot Nothing Then
					AddHandler Me._mnuFileSaveAsRSDX.Click, value2
					AddHandler Me._mnuFileSaveAsRSDX.Popup, value3
				End If
			End Set
		End Property

		Public Overridable Property mnuFileSaveAsRSVX As MenuItem
			Get
				Return Me._mnuFileSaveAsRSVX
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim value2 As EventHandler = AddressOf Me.mnuFileSaveAsRSVX_Click
				Dim value3 As EventHandler = AddressOf Me.mnuFileSaveAsRSVX__Popup
				If Me._mnuFileSaveAsRSVX IsNot Nothing Then
					RemoveHandler Me._mnuFileSaveAsRSVX.Click, value2
					RemoveHandler Me._mnuFileSaveAsRSVX.Popup, value3
				End If
				Me._mnuFileSaveAsRSVX = value
				If Me._mnuFileSaveAsRSVX IsNot Nothing Then
					AddHandler Me._mnuFileSaveAsRSVX.Click, value2
					AddHandler Me._mnuFileSaveAsRSVX.Popup, value3
				End If
			End Set
		End Property

		Public Overridable Property mnuFileSaveAsXRVX As MenuItem
			Get
				Return Me._mnuFileSaveAsXRVX
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim value2 As EventHandler = AddressOf Me.mnuFileSaveAsXRVX_Click
				Dim value3 As EventHandler = AddressOf Me.mnuFileSaveAsXRVX__Popup
				If Me._mnuFileSaveAsXRVX IsNot Nothing Then
					RemoveHandler Me._mnuFileSaveAsXRVX.Click, value2
					RemoveHandler Me._mnuFileSaveAsXRVX.Popup, value3
				End If
				Me._mnuFileSaveAsXRVX = value
				If Me._mnuFileSaveAsXRVX IsNot Nothing Then
					AddHandler Me._mnuFileSaveAsXRVX.Click, value2
					AddHandler Me._mnuFileSaveAsXRVX.Popup, value3
				End If
			End Set
		End Property

		Public Overridable Property mnuFileSaveAsSeparator1 As MenuItem
			Get
				Return Me._mnuFileSaveAsSeparator1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Me._mnuFileSaveAsSeparator1 = value
			End Set
		End Property

		Public Overridable Property mnuFileSaveAsPDF_ As MenuItem
			Get
				Return Me._mnuFileSaveAsPDF_
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim value2 As EventHandler = AddressOf Me.mnuFileSaveAsPDF__Click
				Dim value3 As EventHandler = AddressOf Me.mnuFileSaveAsPDF__Popup
				If Me._mnuFileSaveAsPDF_ IsNot Nothing Then
					RemoveHandler Me._mnuFileSaveAsPDF_.Click, value2
					RemoveHandler Me._mnuFileSaveAsPDF_.Popup, value3
				End If
				Me._mnuFileSaveAsPDF_ = value
				If Me._mnuFileSaveAsPDF_ IsNot Nothing Then
					AddHandler Me._mnuFileSaveAsPDF_.Click, value2
					AddHandler Me._mnuFileSaveAsPDF_.Popup, value3
				End If
			End Set
		End Property

		Public Overridable Property mnuFileSeparator0 As MenuItem
			Get
				Return Me._mnuFileSeparator0
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Me._mnuFileSeparator0 = value
			End Set
		End Property

		Public Overridable Property mnuFileRecentFiles As MenuItem
			Get
				Return Me._mnuFileRecentFiles
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Me._mnuFileRecentFiles = value
			End Set
		End Property

		Public Overridable Property mnuFileSeparator1 As MenuItem
			Get
				Return Me._mnuFileSeparator1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Me._mnuFileSeparator1 = value
			End Set
		End Property

		Public Overridable Property mnuFileImport As MenuItem
			Get
				Return Me._mnuFileImport
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim value2 As EventHandler = AddressOf Me.mnuFileImport_Click
				Dim value3 As EventHandler = AddressOf Me.mnuFileImport_Popup
				If Me._mnuFileImport IsNot Nothing Then
					RemoveHandler Me._mnuFileImport.Click, value2
					RemoveHandler Me._mnuFileImport.Popup, value3
				End If
				Me._mnuFileImport = value
				If Me._mnuFileImport IsNot Nothing Then
					AddHandler Me._mnuFileImport.Click, value2
					AddHandler Me._mnuFileImport.Popup, value3
				End If
			End Set
		End Property

		Public Overridable Property mnuFileSeparator2 As MenuItem
			Get
				Return Me._mnuFileSeparator2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Me._mnuFileSeparator2 = value
			End Set
		End Property

		Public Overridable Property mnuFilePrint_ As MenuItem
			Get
				Return Me._mnuFilePrint_
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim value2 As EventHandler = AddressOf Me.mnuFilePrint__Click
				Dim value3 As EventHandler = AddressOf Me.mnuFilePrint__Popup
				If Me._mnuFilePrint_ IsNot Nothing Then
					RemoveHandler Me._mnuFilePrint_.Click, value2
					RemoveHandler Me._mnuFilePrint_.Popup, value3
				End If
				Me._mnuFilePrint_ = value
				If Me._mnuFilePrint_ IsNot Nothing Then
					AddHandler Me._mnuFilePrint_.Click, value2
					AddHandler Me._mnuFilePrint_.Popup, value3
				End If
			End Set
		End Property

		Public Overridable Property mnuFilePrintSetup_ As MenuItem
			Get
				Return Me._mnuFilePrintSetup_
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim value2 As EventHandler = AddressOf Me.mnuFilePrintSetup__Click
				Dim value3 As EventHandler = AddressOf Me.mnuFilePrintSetup__Popup
				If Me._mnuFilePrintSetup_ IsNot Nothing Then
					RemoveHandler Me._mnuFilePrintSetup_.Click, value2
					RemoveHandler Me._mnuFilePrintSetup_.Popup, value3
				End If
				Me._mnuFilePrintSetup_ = value
				If Me._mnuFilePrintSetup_ IsNot Nothing Then
					AddHandler Me._mnuFilePrintSetup_.Click, value2
					AddHandler Me._mnuFilePrintSetup_.Popup, value3
				End If
			End Set
		End Property

		Public Overridable Property mnuFileSeparator3 As MenuItem
			Get
				Return Me._mnuFileSeparator3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Me._mnuFileSeparator3 = value
			End Set
		End Property

		Public Overridable Property mnuFileExit As MenuItem
			Get
				Return Me._mnuFileExit
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim value2 As EventHandler = AddressOf Me.mnuFileExit_Click
				Dim value3 As EventHandler = AddressOf Me.mnuFileExit_Popup
				If Me._mnuFileExit IsNot Nothing Then
					RemoveHandler Me._mnuFileExit.Click, value2
					RemoveHandler Me._mnuFileExit.Popup, value3
				End If
				Me._mnuFileExit = value
				If Me._mnuFileExit IsNot Nothing Then
					AddHandler Me._mnuFileExit.Click, value2
					AddHandler Me._mnuFileExit.Popup, value3
				End If
			End Set
		End Property

		Public Overridable Property mnuFile As MenuItem
			Get
				Return Me._mnuFile
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim value2 As EventHandler = AddressOf Me.mnuFile_Click
				Dim value3 As EventHandler = AddressOf Me.mnuFile_Popup
				If Me._mnuFile IsNot Nothing Then
					RemoveHandler Me._mnuFile.Click, value2
					RemoveHandler Me._mnuFile.Popup, value3
				End If
				Me._mnuFile = value
				If Me._mnuFile IsNot Nothing Then
					AddHandler Me._mnuFile.Click, value2
					AddHandler Me._mnuFile.Popup, value3
				End If
			End Set
		End Property

		Public Overridable Property mnuEditUndo As MenuItem
			Get
				Return Me._mnuEditUndo
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim value2 As EventHandler = AddressOf Me.mnuEditUndo_Click
				Dim value3 As EventHandler = AddressOf Me.mnuEditUndo_Popup
				If Me._mnuEditUndo IsNot Nothing Then
					RemoveHandler Me._mnuEditUndo.Click, value2
					RemoveHandler Me._mnuEditUndo.Popup, value3
				End If
				Me._mnuEditUndo = value
				If Me._mnuEditUndo IsNot Nothing Then
					AddHandler Me._mnuEditUndo.Click, value2
					AddHandler Me._mnuEditUndo.Popup, value3
				End If
			End Set
		End Property

		Public Overridable Property mnuEditSeparator As MenuItem
			Get
				Return Me._mnuEditSeparator
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Me._mnuEditSeparator = value
			End Set
		End Property

		Public Overridable Property mnuEditCut As MenuItem
			Get
				Return Me._mnuEditCut
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim value2 As EventHandler = AddressOf Me.mnuEditCut_Click
				Dim value3 As EventHandler = AddressOf Me.mnuEditCut_Popup
				If Me._mnuEditCut IsNot Nothing Then
					RemoveHandler Me._mnuEditCut.Click, value2
					RemoveHandler Me._mnuEditCut.Popup, value3
				End If
				Me._mnuEditCut = value
				If Me._mnuEditCut IsNot Nothing Then
					AddHandler Me._mnuEditCut.Click, value2
					AddHandler Me._mnuEditCut.Popup, value3
				End If
			End Set
		End Property

		Public Overridable Property mnuEditCopy As MenuItem
			Get
				Return Me._mnuEditCopy
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim value2 As EventHandler = AddressOf Me.mnuEditCopy_Click
				Dim value3 As EventHandler = AddressOf Me.mnuEditCopy_Popup
				If Me._mnuEditCopy IsNot Nothing Then
					RemoveHandler Me._mnuEditCopy.Click, value2
					RemoveHandler Me._mnuEditCopy.Popup, value3
				End If
				Me._mnuEditCopy = value
				If Me._mnuEditCopy IsNot Nothing Then
					AddHandler Me._mnuEditCopy.Click, value2
					AddHandler Me._mnuEditCopy.Popup, value3
				End If
			End Set
		End Property

		Public Overridable Property mnuEditPaste As MenuItem
			Get
				Return Me._mnuEditPaste
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim value2 As EventHandler = AddressOf Me.mnuEditPaste_Click
				Dim value3 As EventHandler = AddressOf Me.mnuEditPaste_Popup
				If Me._mnuEditPaste IsNot Nothing Then
					RemoveHandler Me._mnuEditPaste.Click, value2
					RemoveHandler Me._mnuEditPaste.Popup, value3
				End If
				Me._mnuEditPaste = value
				If Me._mnuEditPaste IsNot Nothing Then
					AddHandler Me._mnuEditPaste.Click, value2
					AddHandler Me._mnuEditPaste.Popup, value3
				End If
			End Set
		End Property

		Public Overridable Property mnuEditDelete As MenuItem
			Get
				Return Me._mnuEditDelete
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim value2 As EventHandler = AddressOf Me.mnuEditDelete_Click
				Dim value3 As EventHandler = AddressOf Me.mnuEditDelete_Popup
				If Me._mnuEditDelete IsNot Nothing Then
					RemoveHandler Me._mnuEditDelete.Click, value2
					RemoveHandler Me._mnuEditDelete.Popup, value3
				End If
				Me._mnuEditDelete = value
				If Me._mnuEditDelete IsNot Nothing Then
					AddHandler Me._mnuEditDelete.Click, value2
					AddHandler Me._mnuEditDelete.Popup, value3
				End If
			End Set
		End Property

		Public Overridable Property mnuEdit As MenuItem
			Get
				Return Me._mnuEdit
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim value2 As EventHandler = AddressOf Me.mnuEdit_Click
				Dim value3 As EventHandler = AddressOf Me.mnuEdit_Popup
				If Me._mnuEdit IsNot Nothing Then
					RemoveHandler Me._mnuEdit.Click, value2
					RemoveHandler Me._mnuEdit.Popup, value3
				End If
				Me._mnuEdit = value
				If Me._mnuEdit IsNot Nothing Then
					AddHandler Me._mnuEdit.Click, value2
					AddHandler Me._mnuEdit.Popup, value3
				End If
			End Set
		End Property

		Public Overridable Property mnuRun As MenuItem
			Get
				Return Me._mnuRun
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim value2 As EventHandler = AddressOf Me.mnuRun_Click
				Dim value3 As EventHandler = AddressOf Me.mnuRun_Popup
				If Me._mnuRun IsNot Nothing Then
					RemoveHandler Me._mnuRun.Click, value2
					RemoveHandler Me._mnuRun.Popup, value3
				End If
				Me._mnuRun = value
				If Me._mnuRun IsNot Nothing Then
					AddHandler Me._mnuRun.Click, value2
					AddHandler Me._mnuRun.Popup, value3
				End If
			End Set
		End Property

		Public Overridable Property mnuToolsExportDYN As MenuItem
			Get
				Return Me._mnuToolsExportDYN
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim value2 As EventHandler = AddressOf Me.mnuToolsExportDYN_Click
				If Me._mnuToolsExportDYN IsNot Nothing Then
					RemoveHandler Me._mnuToolsExportDYN.Click, value2
				End If
				Me._mnuToolsExportDYN = value
				If Me._mnuToolsExportDYN IsNot Nothing Then
					AddHandler Me._mnuToolsExportDYN.Click, value2
				End If
			End Set
		End Property

		Public Overridable Property mnuToolsExportMCM As MenuItem
			Get
				Return Me._mnuToolsExportMCM
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim value2 As EventHandler = AddressOf Me.mnuToolsExportMCM_Click
				If Me._mnuToolsExportMCM IsNot Nothing Then
					RemoveHandler Me._mnuToolsExportMCM.Click, value2
				End If
				Me._mnuToolsExportMCM = value
				If Me._mnuToolsExportMCM IsNot Nothing Then
					AddHandler Me._mnuToolsExportMCM.Click, value2
				End If
			End Set
		End Property

		Public Overridable Property mnuToolsSeparator0 As MenuItem
			Get
				Return Me._mnuToolsSeparator0
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Me._mnuToolsSeparator0 = value
			End Set
		End Property

		Public Overridable Property mnuToolsSetup_ As MenuItem
			Get
				Return Me._mnuToolsSetup_
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim value2 As EventHandler = AddressOf Me.ToolsSetup_Click
				If Me._mnuToolsSetup_ IsNot Nothing Then
					RemoveHandler Me._mnuToolsSetup_.Click, value2
				End If
				Me._mnuToolsSetup_ = value
				If Me._mnuToolsSetup_ IsNot Nothing Then
					AddHandler Me._mnuToolsSetup_.Click, value2
				End If
			End Set
		End Property

		Public Overridable Property mnuToolsSeparator1 As MenuItem
			Get
				Return Me._mnuToolsSeparator1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Me._mnuToolsSeparator1 = value
			End Set
		End Property

		Public Overridable Property mnuToolsUploadRSVXFile As MenuItem
			Get
				Return Me._mnuToolsUploadRSVXFile
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim value2 As EventHandler = AddressOf Me.mnuToolsUploadRSVXFile_Click
				If Me._mnuToolsUploadRSVXFile IsNot Nothing Then
					RemoveHandler Me._mnuToolsUploadRSVXFile.Click, value2
				End If
				Me._mnuToolsUploadRSVXFile = value
				If Me._mnuToolsUploadRSVXFile IsNot Nothing Then
					AddHandler Me._mnuToolsUploadRSVXFile.Click, value2
				End If
			End Set
		End Property

		Public Overridable Property mnuToolsUploadRSVXFiles As MenuItem
			Get
				Return Me._mnuToolsUploadRSVXFiles
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim value2 As EventHandler = AddressOf Me.mnuToolsUploadRSVXFiles_Click
				If Me._mnuToolsUploadRSVXFiles IsNot Nothing Then
					RemoveHandler Me._mnuToolsUploadRSVXFiles.Click, value2
				End If
				Me._mnuToolsUploadRSVXFiles = value
				If Me._mnuToolsUploadRSVXFiles IsNot Nothing Then
					AddHandler Me._mnuToolsUploadRSVXFiles.Click, value2
				End If
			End Set
		End Property

		Public Overridable Property mnuToolsBatchExportFromOneFolder As MenuItem
			Get
				Return Me._mnuToolsBatchExportFromOneFolder
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim value2 As EventHandler = AddressOf Me.mnuToolsBatchExportFromOneFolder_Click
				If Me._mnuToolsBatchExportFromOneFolder IsNot Nothing Then
					RemoveHandler Me._mnuToolsBatchExportFromOneFolder.Click, value2
				End If
				Me._mnuToolsBatchExportFromOneFolder = value
				If Me._mnuToolsBatchExportFromOneFolder IsNot Nothing Then
					AddHandler Me._mnuToolsBatchExportFromOneFolder.Click, value2
				End If
			End Set
		End Property

		Public Overridable Property mnuToolsDownloadToRSVX As MenuItem
			Get
				Return Me._mnuToolsDownloadToRSVX
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim value2 As EventHandler = AddressOf Me.mnuToolsDownloadToRSVX_Click
				If Me._mnuToolsDownloadToRSVX IsNot Nothing Then
					RemoveHandler Me._mnuToolsDownloadToRSVX.Click, value2
				End If
				Me._mnuToolsDownloadToRSVX = value
				If Me._mnuToolsDownloadToRSVX IsNot Nothing Then
					AddHandler Me._mnuToolsDownloadToRSVX.Click, value2
				End If
			End Set
		End Property

		Public Overridable Property mnuToolsSeparator1b As MenuItem
			Get
				Return Me._mnuToolsSeparator1b
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Me._mnuToolsSeparator1b = value
			End Set
		End Property

		Public Overridable Property mnuToolsDeleteTemplate As MenuItem
			Get
				Return Me._mnuToolsDeleteTemplate
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim value2 As EventHandler = AddressOf Me.mnuToolsDeleteTemplate_Click
				If Me._mnuToolsDeleteTemplate IsNot Nothing Then
					RemoveHandler Me._mnuToolsDeleteTemplate.Click, value2
				End If
				Me._mnuToolsDeleteTemplate = value
				If Me._mnuToolsDeleteTemplate IsNot Nothing Then
					AddHandler Me._mnuToolsDeleteTemplate.Click, value2
				End If
			End Set
		End Property

		Public Overridable Property mnuToolsSeparator2 As MenuItem
			Get
				Return Me._mnuToolsSeparator2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Me._mnuToolsSeparator2 = value
			End Set
		End Property

		Public Overridable Property mnuToolsBatchExportALL As MenuItem
			Get
				Return Me._mnuToolsBatchExportALL
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim value2 As EventHandler = AddressOf Me.mnuToolsBatchExportALL_Click
				If Me._mnuToolsBatchExportALL IsNot Nothing Then
					RemoveHandler Me._mnuToolsBatchExportALL.Click, value2
				End If
				Me._mnuToolsBatchExportALL = value
				If Me._mnuToolsBatchExportALL IsNot Nothing Then
					AddHandler Me._mnuToolsBatchExportALL.Click, value2
				End If
			End Set
		End Property

		Public Overridable Property mnuToolsSeparator3 As MenuItem
			Get
				Return Me._mnuToolsSeparator3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Me._mnuToolsSeparator3 = value
			End Set
		End Property

		Public Overridable Property mnuToolsEncryptTemplateDatabase As MenuItem
			Get
				Return Me._mnuToolsEncryptTemplateDatabase
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim value2 As EventHandler = AddressOf Me.mnuToolsEncryptTemplateDatabase_click
				If Me._mnuToolsEncryptTemplateDatabase IsNot Nothing Then
					RemoveHandler Me._mnuToolsEncryptTemplateDatabase.Click, value2
				End If
				Me._mnuToolsEncryptTemplateDatabase = value
				If Me._mnuToolsEncryptTemplateDatabase IsNot Nothing Then
					AddHandler Me._mnuToolsEncryptTemplateDatabase.Click, value2
				End If
			End Set
		End Property

		Public Overridable Property mnuTools As MenuItem
			Get
				Return Me._mnuTools
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Me._mnuTools = value
			End Set
		End Property

		Public Overridable Property _mnuWindowInput_1 As MenuItem
			Get
				Return Me.__mnuWindowInput_1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim value2 As EventHandler = AddressOf Me._mnuWindowInput_1_Click
				If Me.__mnuWindowInput_1 IsNot Nothing Then
					RemoveHandler Me.__mnuWindowInput_1.Click, value2
				End If
				Me.__mnuWindowInput_1 = value
				If Me.__mnuWindowInput_1 IsNot Nothing Then
					AddHandler Me.__mnuWindowInput_1.Click, value2
				End If
			End Set
		End Property

		Public Overridable Property _mnuWindowInput_2 As MenuItem
			Get
				Return Me.__mnuWindowInput_2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim value2 As EventHandler = AddressOf Me._mnuWindowInput_2_Click
				If Me.__mnuWindowInput_2 IsNot Nothing Then
					RemoveHandler Me.__mnuWindowInput_2.Click, value2
				End If
				Me.__mnuWindowInput_2 = value
				If Me.__mnuWindowInput_2 IsNot Nothing Then
					AddHandler Me.__mnuWindowInput_2.Click, value2
				End If
			End Set
		End Property

		Public Overridable Property _mnuWindowInput_3 As MenuItem
			Get
				Return Me.__mnuWindowInput_3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim value2 As EventHandler = AddressOf Me._mnuWindowInput_3_Click
				If Me.__mnuWindowInput_3 IsNot Nothing Then
					RemoveHandler Me.__mnuWindowInput_3.Click, value2
				End If
				Me.__mnuWindowInput_3 = value
				If Me.__mnuWindowInput_3 IsNot Nothing Then
					AddHandler Me.__mnuWindowInput_3.Click, value2
				End If
			End Set
		End Property

		Public Overridable Property _mnuWindowInput_4 As MenuItem
			Get
				Return Me.__mnuWindowInput_4
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim value2 As EventHandler = AddressOf Me._mnuWindowInput_4_Click
				If Me.__mnuWindowInput_4 IsNot Nothing Then
					RemoveHandler Me.__mnuWindowInput_4.Click, value2
				End If
				Me.__mnuWindowInput_4 = value
				If Me.__mnuWindowInput_4 IsNot Nothing Then
					AddHandler Me.__mnuWindowInput_4.Click, value2
				End If
			End Set
		End Property

		Public Overridable Property _mnuWindowInput_5 As MenuItem
			Get
				Return Me.__mnuWindowInput_5
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim value2 As EventHandler = AddressOf Me._mnuWindowInput_5_Click
				If Me.__mnuWindowInput_5 IsNot Nothing Then
					RemoveHandler Me.__mnuWindowInput_5.Click, value2
				End If
				Me.__mnuWindowInput_5 = value
				If Me.__mnuWindowInput_5 IsNot Nothing Then
					AddHandler Me.__mnuWindowInput_5.Click, value2
				End If
			End Set
		End Property

		Public Overridable Property _mnuWindowInput_6 As MenuItem
			Get
				Return Me.__mnuWindowInput_6
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim value2 As EventHandler = AddressOf Me._mnuWindowInput_6_Click
				If Me.__mnuWindowInput_6 IsNot Nothing Then
					RemoveHandler Me.__mnuWindowInput_6.Click, value2
				End If
				Me.__mnuWindowInput_6 = value
				If Me.__mnuWindowInput_6 IsNot Nothing Then
					AddHandler Me.__mnuWindowInput_6.Click, value2
				End If
			End Set
		End Property

		Public Overridable Property _mnuWindowInput_7 As MenuItem
			Get
				Return Me.__mnuWindowInput_7
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim value2 As EventHandler = AddressOf Me._mnuWindowInput_7_Click
				If Me.__mnuWindowInput_7 IsNot Nothing Then
					RemoveHandler Me.__mnuWindowInput_7.Click, value2
				End If
				Me.__mnuWindowInput_7 = value
				If Me.__mnuWindowInput_7 IsNot Nothing Then
					AddHandler Me.__mnuWindowInput_7.Click, value2
				End If
			End Set
		End Property

		Public Overridable Property mnuWindowSeparator1 As MenuItem
			Get
				Return Me._mnuWindowSeparator1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Me._mnuWindowSeparator1 = value
			End Set
		End Property

		Public Overridable Property mnuWindowPreviousScreen As MenuItem
			Get
				Return Me._mnuWindowPreviousScreen
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim value2 As EventHandler = AddressOf Me.mnuWindowPreviousScreen_Click
				If Me._mnuWindowPreviousScreen IsNot Nothing Then
					RemoveHandler Me._mnuWindowPreviousScreen.Click, value2
				End If
				Me._mnuWindowPreviousScreen = value
				If Me._mnuWindowPreviousScreen IsNot Nothing Then
					AddHandler Me._mnuWindowPreviousScreen.Click, value2
				End If
			End Set
		End Property

		Public Overridable Property mnuWindowNextScreen As MenuItem
			Get
				Return Me._mnuWindowNextScreen
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim value2 As EventHandler = AddressOf Me.mnuWindowNextScreen_Click
				If Me._mnuWindowNextScreen IsNot Nothing Then
					RemoveHandler Me._mnuWindowNextScreen.Click, value2
				End If
				Me._mnuWindowNextScreen = value
				If Me._mnuWindowNextScreen IsNot Nothing Then
					AddHandler Me._mnuWindowNextScreen.Click, value2
				End If
			End Set
		End Property

		Public Overridable Property mnuWindowViewReport As MenuItem
			Get
				Return Me._mnuWindowViewReport
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim value2 As EventHandler = AddressOf Me.mnuWindowViewReport_Popup
				Dim value3 As EventHandler = AddressOf Me.mnuWindowViewReport_Click
				If Me._mnuWindowViewReport IsNot Nothing Then
					RemoveHandler Me._mnuWindowViewReport.Popup, value2
					RemoveHandler Me._mnuWindowViewReport.Click, value3
				End If
				Me._mnuWindowViewReport = value
				If Me._mnuWindowViewReport IsNot Nothing Then
					AddHandler Me._mnuWindowViewReport.Popup, value2
					AddHandler Me._mnuWindowViewReport.Click, value3
				End If
			End Set
		End Property

		Public Overridable Property mnuWindowVisInput As MenuItem
			Get
				Return Me._mnuWindowVisInput
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim value2 As EventHandler = AddressOf Me.mnuWindowVisInput_Click
				Dim value3 As EventHandler = AddressOf Me.mnuWindowVisInput_Popup
				If Me._mnuWindowVisInput IsNot Nothing Then
					RemoveHandler Me._mnuWindowVisInput.Click, value2
					RemoveHandler Me._mnuWindowVisInput.Popup, value3
				End If
				Me._mnuWindowVisInput = value
				If Me._mnuWindowVisInput IsNot Nothing Then
					AddHandler Me._mnuWindowVisInput.Click, value2
					AddHandler Me._mnuWindowVisInput.Popup, value3
				End If
			End Set
		End Property

		Public Overridable Property mnuWindow As MenuItem
			Get
				Return Me._mnuWindow
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Me._mnuWindow = value
			End Set
		End Property

		Public Overridable Property mnuHelpContents As MenuItem
			Get
				Return Me._mnuHelpContents
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim value2 As EventHandler = AddressOf Me.mnuHelpContents_Click
				Dim value3 As EventHandler = AddressOf Me.mnuHelpContents_Popup
				If Me._mnuHelpContents IsNot Nothing Then
					RemoveHandler Me._mnuHelpContents.Click, value2
					RemoveHandler Me._mnuHelpContents.Popup, value3
				End If
				Me._mnuHelpContents = value
				If Me._mnuHelpContents IsNot Nothing Then
					AddHandler Me._mnuHelpContents.Click, value2
					AddHandler Me._mnuHelpContents.Popup, value3
				End If
			End Set
		End Property

		Public Overridable Property mnuHelpSearch_ As MenuItem
			Get
				Return Me._mnuHelpSearch_
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim value2 As EventHandler = AddressOf Me.mnuHelpSearch__Click
				Dim value3 As EventHandler = AddressOf Me.mnuHelpSearch_Popup
				If Me._mnuHelpSearch_ IsNot Nothing Then
					RemoveHandler Me._mnuHelpSearch_.Click, value2
					RemoveHandler Me._mnuHelpSearch_.Popup, value3
				End If
				Me._mnuHelpSearch_ = value
				If Me._mnuHelpSearch_ IsNot Nothing Then
					AddHandler Me._mnuHelpSearch_.Click, value2
					AddHandler Me._mnuHelpSearch_.Popup, value3
				End If
			End Set
		End Property

		Public Overridable Property mnuHelpIndex As MenuItem
			Get
				Return Me._mnuHelpIndex
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim value2 As EventHandler = AddressOf Me.mnuHelpIndex_Click
				Dim value3 As EventHandler = AddressOf Me.mnuHelpIndex_Popup
				If Me._mnuHelpIndex IsNot Nothing Then
					RemoveHandler Me._mnuHelpIndex.Click, value2
					RemoveHandler Me._mnuHelpIndex.Popup, value3
				End If
				Me._mnuHelpIndex = value
				If Me._mnuHelpIndex IsNot Nothing Then
					AddHandler Me._mnuHelpIndex.Click, value2
					AddHandler Me._mnuHelpIndex.Popup, value3
				End If
			End Set
		End Property

		Public Overridable Property mnuHelpSeparator As MenuItem
			Get
				Return Me._mnuHelpSeparator
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Me._mnuHelpSeparator = value
			End Set
		End Property

		Public Overridable Property mnuHelpAbout_ As MenuItem
			Get
				Return Me._mnuHelpAbout_
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Dim value2 As EventHandler = AddressOf Me.mnuHelpAbout_Click
				If Me._mnuHelpAbout_ IsNot Nothing Then
					RemoveHandler Me._mnuHelpAbout_.Click, value2
				End If
				Me._mnuHelpAbout_ = value
				If Me._mnuHelpAbout_ IsNot Nothing Then
					AddHandler Me._mnuHelpAbout_.Click, value2
				End If
			End Set
		End Property

		Public Overridable Property mnuHelp As MenuItem
			Get
				Return Me._mnuHelp
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				Me._mnuHelp = value
			End Set
		End Property

		Public Overridable Property tmrClock As System.Windows.Forms.Timer
			Get
				Return Me._tmrClock
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As System.Windows.Forms.Timer)
				Dim value2 As EventHandler = AddressOf Me.tmrClock_Tick
				If Me._tmrClock IsNot Nothing Then
					RemoveHandler Me._tmrClock.Tick, value2
				End If
				Me._tmrClock = value
				If Me._tmrClock IsNot Nothing Then
					AddHandler Me._tmrClock.Tick, value2
				End If
			End Set
		End Property

		Friend Overridable Property pnlBatchLog As Panel
			Get
				Return Me._pnlBatchLog
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._pnlBatchLog = value
			End Set
		End Property

		Friend Overridable Property Viewer1 As Viewer
			Get
				Return Me._Viewer1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Viewer)
				Me._Viewer1 = value
			End Set
		End Property

		Friend Overridable Property btnClose As Button
			Get
				Return Me._btnClose
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnClose_Click
				If Me._btnClose IsNot Nothing Then
					RemoveHandler Me._btnClose.Click, value2
				End If
				Me._btnClose = value
				If Me._btnClose IsNot Nothing Then
					AddHandler Me._btnClose.Click, value2
				End If
			End Set
		End Property

		Public Sub New()
			AddHandler MyBase.Closing, AddressOf Me.QueryUnload
			AddHandler MyBase.Closing, AddressOf Me.QueryUnload
			AddHandler MyBase.Activated, AddressOf Me.RODSTAR_Activated
			AddHandler MyBase.Closed, AddressOf Me.RODSTAR_Closed
			AddHandler MyBase.Closed, AddressOf Me.RODSTAR_Closed
			AddHandler MyBase.Click, AddressOf Me.RODSTAR_Click
			AddHandler MyBase.MouseDoubleClick, AddressOf Me.Rodstar_MouseDoubleClick
			AddHandler MyBase.MouseDown, AddressOf Me.Rodstar_MouseDown
			AddHandler MyBase.MouseEnter, AddressOf Me.Rodstar_MouseEnter
			AddHandler MyBase.MouseMove, AddressOf Me.Rodstar_MouseMove
			AddHandler MyBase.MouseUp, AddressOf Me.Rodstar_MouseUp
			AddHandler MyBase.MouseWheel, AddressOf Me.Rodstar_MouseWheel
			AddHandler MyBase.Move, AddressOf Me.Rodstar_Move
			AddHandler MyBase.Scroll, AddressOf Me.Rodstar_Scroll
			AddHandler MyBase.KeyPress, AddressOf Me.Rodstar_KeyPress
			AddHandler MyBase.KeyUp, AddressOf Me.Rodstar_KeyUp
			AddHandler MyBase.DragDrop, AddressOf Me.Rodstar_DragDrop
			AddHandler MyBase.DragEnter, AddressOf Me.Rodstar_DragEnter
			AddHandler MyBase.FormClosed, AddressOf Me.Rodstar_FormClosed
			AddHandler MyBase.FormClosing, AddressOf Me.Rodstar_FormClosing
			AddHandler MyBase.LostFocus, AddressOf Me.Rodstar_LostFocus
			AddHandler MyBase.GotFocus, AddressOf Me.Rodstar_GotFocus
			AddHandler MyBase.TextChanged, AddressOf Me.RODSTAR_TextChanged
			AddHandler MyBase.MdiChildActivate, AddressOf Me.MDIChildActivated
			AddHandler MyBase.Resize, AddressOf Me.Rodstar_Resize
			AddHandler MyBase.Load, AddressOf Me.Rodstar_Load
			Me.sbox = New Object(255) {}
			Me.key = New Object(255) {}
			Me.dlgSelectDir = New dlgSelectDir()
			Me.sAlreadyFileList = New String(8) {}
			Me.bCancel = False
			Me.frmSystemOfUnits = New SystemOfUnits()
			Me.NoofTrial = 0S
			Me.bSentinelReplied = True
			Me.m_bClosing = False
			Me.bAllowResize = True
			Me.frmHowToStart = New frmHowToStart()
			Me.FAboutSplash = New FAboutSplash()
			Me.frmDemoMode = New frmDemoMode()
			Me.frmLoadGuruFilenames = New frmLoadGuruFNames()
			Me.sDetent = Util.AssignValueToConstant("RODSTAR", "sDetent", "Detent")
			Me.sNonDetent = Util.AssignValueToConstant("RODSTAR", "sNonDetent", "Non-detent")
			Me.sSpeedVar = ""
			Me.sSpeedVariationNotIncluded = Util.AssignValueToConstant("RODSTAR", "sSpeedVariationNotIncluded", " Motor speed variation: not included.")
			Me.sSpeedVariationIncluded = Util.AssignValueToConstant("RODSTAR", "sSpeedVariationIncluded", " Motor speed variation: included.")
			Me.sDYWExit = Util.AssignValueToConstant("RODSTAR", "sDYWExit", "Do you want to save your data before exiting ")
			Me.sDYWPrevCustomRG = Util.AssignValueToConstant("RODSTAR", "sDYWPrevCustomRG", "Do you want to bring over custom rod information from previous version?")
			Me.sDYWPrevCustomPU = Util.AssignValueToConstant("RODSTAR", "sDYWPrevCustomPU", "Do you want to bring over custom pumping unit information from previous version?")
			Me.sDYWRerun = Util.AssignValueToConstant("RODSTAR", "sDYWRerun", "The diagnosis in this file was made by an earlier version. Do you want to re-run this case for a more up-to-date diagnosis?")
			Me.sInitQuestion = Util.AssignValueToConstant("RODSTAR", "sInitQuestion", "Initialization Question")
			Me.sDYWChangePlungerSize = Util.AssignValueToConstant("RODSTAR", "sDYWChangePlungerSize", "Do you want to change the plunger size?")
			Me.sDYWSaveToDisk = Util.AssignValueToConstant("RODSTAR", "sDYWSaveToDisk", "Do you want to save this data on disk?")
			Me.sMNEPlungerSize = Util.AssignValueToConstant("RODSTAR", "sMNEPlungerSize", "The plunger size must not exceed")
			Me.sMNEPlungerSize1 = Util.AssignValueToConstant("RODSTAR", "sMNEPlungerSize1", "The plunger size must not exceed 1 inches for an insert pump to fit in 2 inch tubing.")
			Me.sMNEPlungerSize2 = Util.AssignValueToConstant("RODSTAR", "sMNEPlungerSize2", "The plunger size must not exceed 1 inches for a tubing pump to fit in 2 inch tubing.")
			Me.sToUsePlungerSize = Util.AssignValueToConstant("RODSTAR", "sToUsePlungerSize", "To use a plunger size of ")
			Me.sDYWAutoBatchSetup = Util.AssignValueToConstant("RODSTAR", "sDYWAutoBatchSetup", "Automatic batch mode has not been set up.  Do you want to go into Setup now?")
			Me.sDYWBatchPrint = Util.AssignValueToConstant("RODSTAR", "sDYWBatchPrint", "Do you want to have the batch run log printed?")
			Me.sBatchPrintNote = Util.AssignValueToConstant("RODSTAR", "sBatchPrintNote", "(Note that if you do not have the log printed, it will be very difficult to tell which cases have been run.)")
			Me.sCalcForFileInProgress = Util.AssignValueToConstant("RODSTAR", "sCalcForFileInProgress", "Calculations for File1 in progress.")
			Me.sNeedMoreSurveyPoints = "Please enter deviation survey data at least one point below the pump depth or adjust the pump depth."
			Me.sSelectExportFolder = Util.AssignValueToConstant("RODSTAR", "sSelectExportFolder", "Select folder for exporting files.")
			Me.sCalcInProgress = Util.AssignValueToConstant("RODSTAR", "sCalcInProgress", "Calculations in progress.")
			Me.sBringOverCustomRodInfo = Util.AssignValueToConstant("RODSTAR", "sBringOverCustomRodInfo", "Do you want to bring over custom rod information from previous version?")
			Me.sBringOverCustomPumpingUnit = Util.AssignValueToConstant("RODSTAR", "sBringOverCustomPumpingUnit", "Do you want to bring over custom pumping unit information from previous version?")
			Me.sExportCBMoment = Util.AssignValueToConstant("RODSTAR", "sExportCBMoment", "Export counterbalance moment")
			Me.sExportRequiredUnbalance = Util.AssignValueToConstant("RODSTAR", "sExportRequiredUnbalance", "Export required structural unbalance")
			Me.frmDisplayAllDatabaseTemplates = New db_guru_admin_form()
			Me.rswin_D_icon = "rswin_D_icon.ico"
			Me.rswin_V_icon = "rswin_V_icon.ico"
			Me.xrod_v_icon = "xrod-v_icon.ico"
			Me.windowCount = 0
			Me.sARSOVERWRITE = "Are you sure you want to overwrite the data in memory?"
			Me.m_bRST = False
			Me.bDisplayBatchFileOutput = False
			Me.myKeyValueHT = New Hashtable()
			Me.m_bEnd = False
			If RODSTAR.m_vb6FormDefInstance Is Nothing Then
				If RODSTAR.m_InitializingDefInstance Then
					RODSTAR.m_vb6FormDefInstance = Me
				Else
					Try
						If Assembly.GetExecutingAssembly().EntryPoint.DeclaringType Is Me.[GetType]() Then
							RODSTAR.m_vb6FormDefInstance = Me
						End If
					Catch ex As Exception
					End Try
				End If
			End If
			Try
				Me.InitializeComponent()
				Me.IsMdiContainer = True
				Me.mnuWindowInput = New MenuItemArray(Me.components)
				Me._mnuWindowInput_1 = New MenuItem()
				Me._mnuWindowInput_2 = New MenuItem()
				Me._mnuWindowInput_3 = New MenuItem()
				Me._mnuWindowInput_4 = New MenuItem()
				Me._mnuWindowInput_5 = New MenuItem()
				Me._mnuWindowInput_6 = New MenuItem()
				Me._mnuWindowInput_7 = New MenuItem()
				Me.MainMenu1 = New MainMenu()
				Me.mnuFile = New MenuItem()
				Me.mnuFileNew = New MenuItem()
				Me.mnuFileOpen_ = New MenuItem()
				Me.mnuFileSave = New MenuItem()
				Me.mnuFileSaveAs_ = New MenuItem()
				Me.mnuFileSaveAsRSVX = New MenuItem()
				Me.mnuFileSaveAsXRVX = New MenuItem()
				Me.mnuFileSaveAsRSDX = New MenuItem()
				Me.mnuFileSaveAsSeparator1 = New MenuItem()
				Me.mnuFileSaveAsPDF_ = New MenuItem()
				Me.mnuFileSeparator0 = New MenuItem()
				Me.mnuFileRecentFiles = New MenuItem()
				Me.mnuFileSeparator1 = New MenuItem()
				Me.mnuFileImport = New MenuItem()
				Me.mnuFileSeparator2 = New MenuItem()
				Me.mnuFilePrint_ = New MenuItem()
				Me.mnuFilePrintSetup_ = New MenuItem()
				Me.mnuFileSeparator3 = New MenuItem()
				Me.mnuFileExit = New MenuItem()
				Me.mnuEdit = New MenuItem()
				Me.mnuEditUndo = New MenuItem()
				Me.mnuEditSeparator = New MenuItem()
				Me.mnuEditCut = New MenuItem()
				Me.mnuEditCopy = New MenuItem()
				Me.mnuEditPaste = New MenuItem()
				Me.mnuEditDelete = New MenuItem()
				Me.mnuRun = New MenuItem()
				Me.mnuTools = New MenuItem()
				Me.mnuToolsExportDYN = New MenuItem()
				Me.mnuToolsExportMCM = New MenuItem()
				Me.mnuToolsSeparator0 = New MenuItem()
				Me.mnuToolsSetup_ = New MenuItem()
				Me.mnuToolsSeparator1 = New MenuItem()
				Me.mnuToolsUploadRSVXFile = New MenuItem()
				Me.mnuToolsUploadRSVXFiles = New MenuItem()
				Me.mnuToolsBatchExportFromOneFolder = New MenuItem()
				Me.mnuToolsDownloadToRSVX = New MenuItem()
				Me.mnuToolsSeparator1b = New MenuItem()
				Me.mnuToolsDeleteTemplate = New MenuItem()
				Me.mnuToolsSeparator2 = New MenuItem()
				Me.mnuToolsBatchExportALL = New MenuItem()
				Me.mnuToolsSeparator3 = New MenuItem()
				Me.mnuToolsEncryptTemplateDatabase = New MenuItem()
				Me.mnuWindow = New MenuItem()
				Me.mnuWindowSeparator1 = New MenuItem()
				Me.mnuWindowPreviousScreen = New MenuItem()
				Me.mnuWindowNextScreen = New MenuItem()
				Me.mnuWindowViewReport = New MenuItem()
				Me.mnuWindowVisInput = New MenuItem()
				Me.mnuHelp = New MenuItem()
				Me.mnuHelpContents = New MenuItem()
				Me.mnuHelpSearch_ = New MenuItem()
				Me.mnuHelpIndex = New MenuItem()
				Me.mnuHelpSeparator = New MenuItem()
				Me.mnuHelpAbout_ = New MenuItem()
				CType(Me.mnuWindowInput, ISupportInitialize).BeginInit()
				Me.mnuWindowInput.SetIndex(Me._mnuWindowInput_1, 1S)
				Me._mnuWindowInput_1.Index = 0
				Me._mnuWindowInput_1.MergeType = MenuMerge.Remove
				Me._mnuWindowInput_1.Text = "&1. Well Information"
				Me.mnuWindowInput.SetIndex(Me._mnuWindowInput_2, 2S)
				Me._mnuWindowInput_2.Index = 1
				Me._mnuWindowInput_2.MergeType = MenuMerge.Remove
				Me._mnuWindowInput_2.Text = "&2. Production Information"
				Me.mnuWindowInput.SetIndex(Me._mnuWindowInput_3, 3S)
				Me._mnuWindowInput_3.Index = 2
				Me._mnuWindowInput_3.MergeType = MenuMerge.Remove
				Me._mnuWindowInput_3.Text = "&3. Pump/Tubing Information"
				Me.mnuWindowInput.SetIndex(Me._mnuWindowInput_4, 4S)
				Me._mnuWindowInput_4.Index = 3
				Me._mnuWindowInput_4.MergeType = MenuMerge.Remove
				Me._mnuWindowInput_4.Text = "&4. Rod String Information"
				If RSWIN_DESC.bRodStarD Then
					Me.mnuWindowInput.SetIndex(Me._mnuWindowInput_5, 5S)
					Me._mnuWindowInput_5.Index = 4
					Me._mnuWindowInput_5.MergeType = MenuMerge.Remove
					Me._mnuWindowInput_5.Text = "&5. Deviation Profile Information"
					Me.mnuWindowInput.SetIndex(Me._mnuWindowInput_6, 6S)
					Me._mnuWindowInput_6.Index = 5
					Me._mnuWindowInput_6.MergeType = MenuMerge.Remove
					Me._mnuWindowInput_6.Text = "&6. Pumping Unit Information"
					Me.mnuWindowInput.SetIndex(Me._mnuWindowInput_7, 7S)
					Me._mnuWindowInput_7.Index = 6
					Me._mnuWindowInput_7.MergeType = MenuMerge.Remove
					Me._mnuWindowInput_7.Text = "&7. Motor Information"
				Else
					Me.mnuWindowInput.SetIndex(Me._mnuWindowInput_5, 5S)
					Me._mnuWindowInput_5.Index = 4
					Me._mnuWindowInput_5.MergeType = MenuMerge.Remove
					Me._mnuWindowInput_5.Text = ""
					Me.mnuWindowInput.SetIndex(Me._mnuWindowInput_6, 6S)
					Me._mnuWindowInput_6.Index = 4
					Me._mnuWindowInput_6.MergeType = MenuMerge.Remove
					Me._mnuWindowInput_6.Text = "&5. Pumping Unit Information"
					Me.mnuWindowInput.SetIndex(Me._mnuWindowInput_7, 7S)
					Me._mnuWindowInput_7.Index = 5
					Me._mnuWindowInput_7.MergeType = MenuMerge.Remove
					Me._mnuWindowInput_7.Text = "&6. Motor Information"
				End If
				Me.MainMenu1.MenuItems.AddRange(New MenuItem() { Me.mnuFile, Me.mnuEdit, Me.mnuRun, Me.mnuTools, Me.mnuWindow, Me.mnuHelp })
				Me.mnuFile.Index = 0
				Me.mnuFile.MenuItems.AddRange(New MenuItem() { Me.mnuFileNew, Me.mnuFileOpen_, Me.mnuFileSave, Me.mnuFileSaveAs_, Me.mnuFileSeparator0, Me.mnuFileRecentFiles, Me.mnuFileSeparator1, Me.mnuFileImport, Me.mnuFileSeparator2, Me.mnuFilePrint_, Me.mnuFilePrintSetup_, Me.mnuFileSeparator3, Me.mnuFileExit })
				Me.mnuFile.MergeType = MenuMerge.Remove
				Me.mnuFile.Text = "&File"
				Me.mnuFileNew.Index = 0
				Me.mnuFileNew.MergeType = MenuMerge.Remove
				Me.mnuFileNew.Text = "&New"
				Me.mnuFileOpen_.Index = 1
				Me.mnuFileOpen_.MergeType = MenuMerge.Remove
				Me.mnuFileOpen_.Shortcut = Shortcut.CtrlO
				Me.mnuFileOpen_.Text = "&Open.."
				Me.mnuFileSave.Index = 2
				Me.mnuFileSave.MergeType = MenuMerge.Remove
				Me.mnuFileSave.Shortcut = Shortcut.CtrlS
				Me.mnuFileSave.Text = "&Save"
				Me.mnuFileSaveAs_.Index = 3
				Me.mnuFileSaveAs_.MergeType = MenuMerge.Remove
				Me.mnuFileSaveAs_.Text = "Save &As.."
				If Not RSWIN_DESC.bRegistryMoveChecked Then
					Me.CheckForHKeyLocalAndMove()
				End If
				RSWIN.CheckToMoveRegistryKeysToTheta()
				Try
					Dim bExpert As Boolean = RSWIN_DESC.bExpert
					Dim guruDataBaseFileName As String = "bGuru"
					Dim flag As Boolean = False
					RSWIN_DESC.SETUP_bGuru = (bExpert And RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_PREFERENCES, guruDataBaseFileName, flag))
					If RSWIN_DESC.SETUP_bGuru Then
						Dim sTemplateDBFileName As String = RSWIN_DESC.sTemplateDBFileName
						guruDataBaseFileName = RSWIN_DESC.GuruDataBaseFileName
						FILEUTIL.LocateFile(sTemplateDBFileName, guruDataBaseFileName, 2S, True, False, False, False)
						RSWIN_DESC.GuruDataBaseFileName = guruDataBaseFileName
					End If
				Catch ex2 As Exception
				End Try
				Try
					If RSWIN_DESC.bExpert Then
						If Not RSWIN_DESC.bXRODAdmin Then
							RSWIN_DESC.SETUP_bGuruUseTemplateDatabase = True
						Else
							Dim guruDataBaseFileName As String = "bXRODUseTemplateDatabase"
							Dim flag As Boolean = True
							RSWIN_DESC.SETUP_bGuruUseTemplateDatabase = RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_PREFERENCES, guruDataBaseFileName, flag)
						End If
					End If
				Catch ex3 As Exception
				End Try
				If RSWIN_DESC.bRodStarD Then
					Me.mnuFileSaveAsRSDX.Index = 0
					Me.mnuFileSaveAsRSDX.MergeType = MenuMerge.Remove
					Me.mnuFileSaveAsRSDX.Shortcut = Shortcut.CtrlD
					Me.mnuFileSaveAsRSDX.Text = "Save As RODSTAR RS&DX File...."
					Me.mnuFileSaveAsRSVX.Index = 1
					Me.mnuFileSaveAsRSVX.MergeType = MenuMerge.Remove
					Me.mnuFileSaveAsRSVX.Shortcut = Shortcut.CtrlV
					Me.mnuFileSaveAsRSVX.Text = "Save As RODSTAR RS&VX File...."
					Me.mnuFileSaveAsSeparator1.Index = 2
					Me.mnuFileSaveAsSeparator1.MergeType = MenuMerge.Remove
					Me.mnuFileSaveAsSeparator1.Text = "-"
					Me.mnuFileSaveAsPDF_.Index = 3
					Me.mnuFileSaveAsPDF_.MergeType = MenuMerge.Remove
					Me.mnuFileSaveAsPDF_.Shortcut = Shortcut.CtrlP
					Me.mnuFileSaveAsPDF_.Text = "Save Results As Adobe &PDF File...."
					Me.mnuFileSaveAsPDF_.Enabled = False
				ElseIf Not RSWIN_DESC.bExpert Or (RSWIN_DESC.bExpert And Not RSWIN_DESC.SETUP_bGuru) Then
					Me.mnuFileSaveAsRSVX.Index = 0
					Me.mnuFileSaveAsRSVX.MergeType = MenuMerge.Remove
					Me.mnuFileSaveAsRSVX.Shortcut = Shortcut.CtrlV
					Me.mnuFileSaveAsRSVX.Text = "Save As RODSTAR RS&VX File...."
					Me.mnuFileSaveAsSeparator1.Index = 1
					Me.mnuFileSaveAsSeparator1.MergeType = MenuMerge.Remove
					Me.mnuFileSaveAsSeparator1.Text = "-"
					Me.mnuFileSaveAsPDF_.Index = 2
					Me.mnuFileSaveAsPDF_.MergeType = MenuMerge.Remove
					Me.mnuFileSaveAsPDF_.Shortcut = Shortcut.CtrlP
					Me.mnuFileSaveAsPDF_.Text = "Save Results As Adobe &PDF File...."
					Me.mnuFileSaveAsPDF_.Enabled = False
				ElseIf RSWIN_DESC.SETUP_bGuru Then
					Me.mnuFileSaveAsXRVX.Index = 0
					Me.mnuFileSaveAsXRVX.MergeType = MenuMerge.Remove
					Me.mnuFileSaveAsXRVX.Shortcut = Shortcut.CtrlG
					Me.mnuFileSaveAsXRVX.Text = "Save As XROD-V &XRVX File...."
					Me.mnuFileSaveAsSeparator1.Index = 1
					Me.mnuFileSaveAsSeparator1.MergeType = MenuMerge.Remove
					Me.mnuFileSaveAsSeparator1.Text = "-"
					Me.mnuFileSaveAsPDF_.Index = 2
					Me.mnuFileSaveAsPDF_.MergeType = MenuMerge.Remove
					Me.mnuFileSaveAsPDF_.Shortcut = Shortcut.CtrlP
					Me.mnuFileSaveAsPDF_.Text = "Save Results As Adobe &PDF File...."
					Me.mnuFileSaveAsPDF_.Enabled = False
				End If
				Me.SetMnuFileSaveAs()
				Me.mnuFileSeparator0.Index = 4
				Me.mnuFileSeparator0.MergeType = MenuMerge.Remove
				Me.mnuFileSeparator0.Text = "-"
				Me.mnuFileRecentFiles.Index = 5
				Me.mnuFileRecentFiles.Text = "Recent &Files"
				Me.mnuFileSeparator1.Index = 6
				Me.mnuFileSeparator1.MergeType = MenuMerge.Remove
				Me.mnuFileSeparator1.Text = "-"
				Me.mnuFileImport.Index = 7
				Me.mnuFileImport.MergeType = MenuMerge.Remove
				Me.mnuFileImport.Text = "&Import.."
				Me.mnuFileSeparator2.Index = 8
				Me.mnuFileSeparator2.MergeType = MenuMerge.Remove
				Me.mnuFileSeparator2.Text = "-"
				Me.mnuFilePrint_.Index = 9
				Me.mnuFilePrint_.MergeType = MenuMerge.Remove
				Me.mnuFilePrint_.Shortcut = Shortcut.CtrlP
				Me.mnuFilePrint_.Text = "&Print.."
				Me.mnuFilePrintSetup_.Index = 10
				Me.mnuFilePrintSetup_.MergeType = MenuMerge.Remove
				Me.mnuFilePrintSetup_.Text = "P&rint Setup.."
				Me.mnuFileSeparator3.Index = 11
				Me.mnuFileSeparator3.MergeType = MenuMerge.Remove
				Me.mnuFileSeparator3.Text = "-"
				Me.mnuFileExit.Index = 12
				Me.mnuFileExit.MergeType = MenuMerge.Remove
				Me.mnuFileExit.Text = "E&xit"
				Me.mnuEdit.Index = 1
				Me.mnuEdit.MenuItems.AddRange(New MenuItem() { Me.mnuEditUndo, Me.mnuEditSeparator, Me.mnuEditCut, Me.mnuEditCopy, Me.mnuEditPaste, Me.mnuEditDelete })
				Me.mnuEdit.MergeType = MenuMerge.Remove
				Me.mnuEdit.Text = "&Edit"
				Me.mnuEdit.Enabled = True
				Me.mnuEditUndo.Index = 0
				Me.mnuEditUndo.MergeType = MenuMerge.Remove
				Me.mnuEditUndo.Shortcut = Shortcut.CtrlZ
				Me.mnuEditUndo.Text = "&Undo"
				Me.mnuEditSeparator.Index = 1
				Me.mnuEditSeparator.MergeType = MenuMerge.Remove
				Me.mnuEditSeparator.Text = "-"
				Me.mnuEditCut.Index = 2
				Me.mnuEditCut.MergeType = MenuMerge.Remove
				Me.mnuEditCut.Shortcut = Shortcut.CtrlX
				Me.mnuEditCut.Text = "Cu&t"
				Me.mnuEditCopy.Index = 3
				Me.mnuEditCopy.MergeType = MenuMerge.Remove
				Me.mnuEditCopy.Shortcut = Shortcut.CtrlC
				Me.mnuEditCopy.Text = "&Copy"
				Me.mnuEditPaste.Index = 4
				Me.mnuEditPaste.MergeType = MenuMerge.Remove
				Me.mnuEditPaste.Shortcut = Shortcut.CtrlV
				Me.mnuEditPaste.Text = "&Paste"
				Me.mnuEditDelete.Index = 5
				Me.mnuEditDelete.MergeType = MenuMerge.Remove
				Me.mnuEditDelete.Shortcut = Shortcut.Del
				Me.mnuEditDelete.Text = "&Delete"
				Me.mnuRun.Index = 2
				Me.mnuRun.MergeType = MenuMerge.Remove
				Me.mnuRun.Text = "&Run!"
				Me.mnuRun.Enabled = False
				If Not RSWIN_DESC.bXRODAdmin Then
					Me.mnuTools.Index = 3
					Me.mnuTools.MenuItems.AddRange(New MenuItem() { Me.mnuToolsExportDYN, Me.mnuToolsExportMCM, Me.mnuToolsSeparator0, Me.mnuToolsSetup_ })
					Me.mnuTools.MergeType = MenuMerge.Remove
					Me.mnuTools.Text = "&Tools"
				Else
					Me.mnuTools.Index = 3
					Me.mnuTools.MenuItems.AddRange(New MenuItem() { Me.mnuToolsExportDYN, Me.mnuToolsExportMCM, Me.mnuToolsSeparator0, Me.mnuToolsSetup_, Me.mnuToolsSeparator1, Me.mnuToolsDownloadToRSVX, Me.mnuToolsSeparator1b, Me.mnuToolsDeleteTemplate, Me.mnuToolsSeparator2, Me.mnuToolsUploadRSVXFile, Me.mnuToolsUploadRSVXFiles, Me.mnuToolsBatchExportFromOneFolder, Me.mnuToolsBatchExportALL, Me.mnuToolsSeparator3, Me.mnuToolsEncryptTemplateDatabase })
					Me.mnuTools.MergeType = MenuMerge.Remove
					Me.mnuTools.Text = "&Tools"
				End If
				Me.mnuToolsExportDYN.Index = 0
				Me.mnuToolsExportDYN.MergeType = MenuMerge.Remove
				Me.mnuToolsExportDYN.Text = "Export &Dynamometer file.."
				Me.mnuToolsExportDYN.Enabled = False
				Me.mnuToolsExportMCM.Index = 1
				Me.mnuToolsExportMCM.MergeType = MenuMerge.Remove
				Me.mnuToolsExportMCM.Text = "Export &Balanced MCM.."
				Me.mnuToolsExportMCM.Enabled = False
				Me.mnuToolsSeparator0.Index = 2
				Me.mnuToolsSeparator0.MergeType = MenuMerge.Remove
				Me.mnuToolsSeparator0.Text = "-"
				Me.mnuToolsSetup_.Index = 3
				Me.mnuToolsSetup_.MergeType = MenuMerge.Remove
				If RSWIN_DESC.bExpert Then
					Me.mnuToolsSetup_.Text = "&XROD-V Setup.."
				Else
					Me.mnuToolsSetup_.Text = "&Rodstar Setup.."
				End If
				If RSWIN_DESC.bXRODAdmin Then
					Me.mnuToolsSeparator1.Index = 4
					Me.mnuToolsSeparator1.MergeType = MenuMerge.Remove
					Me.mnuToolsSeparator1.Text = "-"
					Me.mnuToolsDownloadToRSVX.Index = 5
					Me.mnuToolsDownloadToRSVX.MergeType = MenuMerge.Remove
					Me.mnuToolsDownloadToRSVX.Text = "Download record from Template Database to RSVX file..."
					Me.mnuToolsDownloadToRSVX.Enabled = True
					Me.mnuToolsSeparator1b.Index = 6
					Me.mnuToolsSeparator1b.MergeType = MenuMerge.Remove
					Me.mnuToolsSeparator1b.Text = "-"
					Me.mnuToolsDeleteTemplate.Index = 7
					Me.mnuToolsDeleteTemplate.MergeType = MenuMerge.Remove
					Me.mnuToolsDeleteTemplate.Text = "Delete record from Template Database..."
					Me.mnuToolsDeleteTemplate.Enabled = True
					Me.mnuToolsSeparator2.Index = 8
					Me.mnuToolsSeparator2.MergeType = MenuMerge.Remove
					Me.mnuToolsSeparator2.Text = "-"
					Me.mnuToolsSeparator2.Enabled = True
					Me.mnuToolsUploadRSVXFile.Index = 9
					Me.mnuToolsUploadRSVXFile.MergeType = MenuMerge.Remove
					Me.mnuToolsUploadRSVXFile.Text = "Upload current RSVX file to Template Database..."
					Me.mnuToolsUploadRSVXFile.Enabled = False
					Me.mnuToolsUploadRSVXFiles.Index = 10
					Me.mnuToolsUploadRSVXFiles.MergeType = MenuMerge.Remove
					Me.mnuToolsUploadRSVXFiles.Text = "Upload multiple RSVX files to Template Database..."
					Me.mnuToolsUploadRSVXFiles.Enabled = True
					Me.mnuToolsBatchExportFromOneFolder.Index = 11
					Me.mnuToolsBatchExportFromOneFolder.MergeType = MenuMerge.Remove
					Me.mnuToolsBatchExportFromOneFolder.Text = "Upload RSVX files from one Folder..."
					Me.mnuToolsBatchExportFromOneFolder.Enabled = True
					Me.mnuToolsBatchExportALL.Index = 12
					Me.mnuToolsBatchExportALL.MergeType = MenuMerge.Remove
					Me.mnuToolsBatchExportALL.Text = "Upload ALL RSVX files to Template Database..."
					Me.mnuToolsBatchExportALL.Enabled = True
					Me.mnuToolsSeparator3.Index = 13
					Me.mnuToolsSeparator3.MergeType = MenuMerge.Remove
					Me.mnuToolsSeparator3.Text = "-"
					Me.mnuToolsSeparator3.Enabled = True
					Me.mnuToolsEncryptTemplateDatabase.Index = 14
					Me.mnuToolsEncryptTemplateDatabase.MergeType = MenuMerge.Remove
					Me.mnuToolsEncryptTemplateDatabase.Text = "Create Encrypted Template Database..."
					Me.mnuToolsEncryptTemplateDatabase.Enabled = True
				End If
				Me.mnuWindow.Index = 4
				If RSWIN_DESC.bRodStarD Then
					Me.mnuWindow.MenuItems.AddRange(New MenuItem() { Me._mnuWindowInput_1, Me._mnuWindowInput_2, Me._mnuWindowInput_3, Me._mnuWindowInput_4, Me._mnuWindowInput_5, Me._mnuWindowInput_6, Me._mnuWindowInput_7, Me.mnuWindowSeparator1, Me.mnuWindowPreviousScreen, Me.mnuWindowNextScreen, Me.mnuWindowViewReport, Me.mnuWindowVisInput })
				Else
					Me.mnuWindow.MenuItems.AddRange(New MenuItem() { Me._mnuWindowInput_1, Me._mnuWindowInput_2, Me._mnuWindowInput_3, Me._mnuWindowInput_4, Me._mnuWindowInput_6, Me._mnuWindowInput_7, Me.mnuWindowSeparator1, Me.mnuWindowPreviousScreen, Me.mnuWindowNextScreen, Me.mnuWindowViewReport, Me.mnuWindowVisInput })
				End If
				Me.mnuWindow.MergeType = MenuMerge.Remove
				Me.mnuWindow.Text = "&Window"
				Me.mnuWindow.Enabled = False
				If RSWIN_DESC.bRodStarD Then
					Me.iWindowsStartIndex = 7
				Else
					Me.iWindowsStartIndex = 6
				End If
				Me.mnuWindowSeparator1.Index = Me.iWindowsStartIndex
				Me.mnuWindowSeparator1.MergeType = MenuMerge.Remove
				Me.mnuWindowSeparator1.Text = "-"
				Me.mnuWindowPreviousScreen.Index = Me.iWindowsStartIndex + 1
				Me.mnuWindowPreviousScreen.MergeType = MenuMerge.Remove
				Me.mnuWindowPreviousScreen.Shortcut = Shortcut.CtrlV
				Me.mnuWindowPreviousScreen.Text = "Pre&vious Screen"
				Me.mnuWindowNextScreen.Index = Me.iWindowsStartIndex + 2
				Me.mnuWindowNextScreen.MergeType = MenuMerge.Remove
				Me.mnuWindowNextScreen.Shortcut = Shortcut.CtrlN
				Me.mnuWindowNextScreen.Text = "&Next Screen"
				Me.mnuWindowViewReport.Index = Me.iWindowsStartIndex + 3
				Me.mnuWindowViewReport.MergeType = MenuMerge.Remove
				Me.mnuWindowViewReport.Text = "View &Report"
				Me.mnuWindowVisInput.Index = Me.iWindowsStartIndex + 4
				Me.mnuWindowVisInput.MergeType = MenuMerge.Remove
				Me.mnuWindowVisInput.Text = "Visual &Input"
				Me.mnuHelp.Index = 5
				Me.mnuHelp.MenuItems.AddRange(New MenuItem() { Me.mnuHelpContents, Me.mnuHelpIndex, Me.mnuHelpSearch_, Me.mnuHelpSeparator, Me.mnuHelpAbout_ })
				Me.mnuHelp.MergeType = MenuMerge.Remove
				Me.mnuHelp.Text = "&Help"
				Me.mnuHelpContents.Index = 0
				Me.mnuHelpContents.MergeType = MenuMerge.Remove
				Me.mnuHelpContents.Text = "&Contents.."
				Me.mnuHelpIndex.Index = 1
				Me.mnuHelpIndex.MergeType = MenuMerge.Remove
				Me.mnuHelpIndex.Text = "&Index.."
				Me.mnuHelpSearch_.Index = 2
				Me.mnuHelpSearch_.MergeType = MenuMerge.Remove
				Me.mnuHelpSearch_.Text = "&Search.."
				Me.mnuHelpSeparator.Index = 3
				Me.mnuHelpSeparator.MergeType = MenuMerge.Remove
				Me.mnuHelpSeparator.Text = "-"
				Me.mnuHelpAbout_.Index = 4
				Me.mnuHelpAbout_.MergeType = MenuMerge.Remove
				If RSWIN_DESC.bExpert Then
					Me.mnuHelpAbout_.Text = "&About XROD-V.."
				Else
					Me.mnuHelpAbout_.Text = "&About Rodstar.."
				End If
				CType(Me.mnuWindowInput, ISupportInitialize).EndInit()
				Me.Menu = Me.MainMenu1
			Catch ex4 As Exception
				Dim sMsg As String = "Error in Init : " + ex4.Message
				Dim sMsgType As String = ""
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
			End Try
		End Sub

		Public Property NowTime As DateTime
			Get
				Return Me.m_NowTime
			End Get
			Set(value As DateTime)
				Me.m_NowTime = value
			End Set
		End Property

		Public Property bEnd As Boolean
			Get
				Return Me.m_bEnd
			End Get
			Set(value As Boolean)
				Me.m_bEnd = value
			End Set
		End Property

		Public Sub AddRSInput(bShow As Boolean, Optional bTurnOffReport As Boolean = False)
			Try
				If bTurnOffReport Then
					Me.ToolbarButtonSetState2(2, False)
				End If
			Catch ex As Exception
			End Try
			Try
				Dim flag As Boolean
				If Not Me.MdiFormExists("RSInput", True, False, bShow, flag) Then
					Me.windowCount += 1
					Dim rsinput As RSInput = New RSInput()
					rsinput.MdiParent = Me
					If bShow Then
						RSWIN_DESC.sLastMDIFormName = "RSInput"
						rsinput.Show()
					Else
						rsinput.Hide()
					End If
				End If
			Catch ex2 As Exception
				Dim sMsg As String = "Error in Add RSInput Form: " + ex2.Message
				Dim sMsgType As String = ""
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
			End Try
		End Sub

		Private Sub AddPUData(bShow As Boolean)
			' The following expression was wrapped in a checked-statement
			Try
				Dim flag As Boolean
				If Not Me.MdiFormExists("PUData", True, False, bShow, flag) Then
					Me.windowCount += 1
					Dim pudata As PUData = New PUData()
					pudata.MdiParent = Me
					If bShow Then
						Me.frmHowToStart.Hide()
						RSWIN_DESC.sLastMDIFormName = "PUData"
						pudata.Show()
					Else
						pudata.Hide()
					End If
				End If
			Catch ex As Exception
				Dim sMsg As String = "Error in Add PUData Form: " + ex.Message
				Dim sMsgType As String = ""
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
			End Try
		End Sub

		Private Sub AddWellInfo(bShow As Boolean)
			' The following expression was wrapped in a checked-statement
			Try
				If Me.frmHowToStart.Visible Then
					Me.frmHowToStart.Hide()
					Application.DoEvents()
				End If
				Dim flag As Boolean
				If Not Me.MdiFormExists("WellInfo", True, False, bShow, flag) Then
					Me.windowCount += 1
					Dim wellInfo As WellInfo = New WellInfo()
					wellInfo.MdiParent = Me
					If bShow Then
						Me.frmHowToStart.Hide()
						Application.DoEvents()
						RSWIN_DESC.sLastMDIFormName = "WellInfo"
						wellInfo.CenterForm()
						wellInfo.Show()
						If RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru Then
							Me.ToolbarButtonSetState(15, True)
						ElseIf Me.ValidateAllData() Then
							Me.ToolbarButtonSetState(15, True)
						Else
							Me.ToolbarButtonSetState(15, False)
						End If
						Me.ToolbarButtonSetState(8, True)
					Else
						wellInfo.Hide()
					End If
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub AddDeviationProfile(bShow As Boolean)
			If Not RSWIN_DESC.bRodStarD Then
				Return
			End If
			Try
				If Me.frmHowToStart.Visible Then
					Me.frmHowToStart.Hide()
					Application.DoEvents()
				End If
				Dim flag As Boolean
				If Not Me.MdiFormExists("DeviationProfile", True, False, bShow, flag) Then
					Me.windowCount += 1
					Dim deviationProfile As DeviationProfile = New DeviationProfile()
					deviationProfile.MdiParent = Me
					If bShow Then
						Me.frmHowToStart.Hide()
						Application.DoEvents()
						RSWIN_DESC.sLastMDIFormName = "DeviationProfile"
						deviationProfile.Height = Me.Height - 90
						deviationProfile.Width = CInt(Math.Round(CDbl(Me.Width) * 0.8))
						If deviationProfile.Width > 800 Then
							deviationProfile.Width = 800
						End If
						deviationProfile.Show()
						Me.ToolbarButtonSetState(15, True)
						Me.ToolbarButtonSetState(12, True)
					Else
						deviationProfile.Hide()
					End If
				End If
			Catch ex As Exception
				Dim sMsg As String = "Error in Add DeviationProfile Form: " + ex.Message
				Dim sMsgType As String = ""
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
			End Try
		End Sub

		Private Sub CheckForms()
			For Each form As Form In Me.MdiChildren
				Dim name As String = form.Name
				Dim visible As Boolean = form.Visible
				form.Close()
				Dim text As String = name
				If Operators.CompareString(text, "Production Information", False) = 0 Then
					Me.AddProdInfo(visible)
				ElseIf Operators.CompareString(text, "Pump and Tubing Information", False) = 0 Then
					Me.AddPTInfo(visible)
				ElseIf Operators.CompareString(text, "Rod String Information", False) = 0 Then
					Me.AddRSInput(visible, False)
				ElseIf Operators.CompareString(text, "Pumping Unit Information", False) = 0 Then
					Me.AddPUData(visible)
				ElseIf Operators.CompareString(text, "Motor Information", False) = 0 Then
					Me.AddMotorData(visible)
				ElseIf Operators.CompareString(text, "VisInput", False) = 0 Then
					If visible Then
						Me.AddVisInput(True, True)
					Else
						Me.AddVisInput(False, False)
					End If
				End If
			Next
		End Sub

		Public Function MdiFormExists(FormName As String, ActivateForm As Boolean, RemoveForm As Boolean, bShow As Boolean, ByRef bError As Boolean) As Boolean
			Dim result As Boolean
			Try
				Dim flag As Boolean = False
				bError = False
				For Each form As Form In Me.MdiChildren
					If Operators.CompareString(FormName, form.Name, False) = 0 Then
						flag = True
						If ActivateForm Then
							Try
								form.Activate()
							Catch ex As Exception
								bError = True
							End Try
							If flag AndAlso bShow Then
								Try
									Me.frmHowToStart.Hide()
									Application.DoEvents()
									If Operators.CompareString(FormName, "Results", False) = 0 Then
										Me.InitResultsForm()
										Exit Try
									End If
									form.Show()
									Exit Try
								Catch ex2 As Exception
									bError = True
									GoTo IL_BD
								End Try
							End If
							If Not bShow Then
								form.Hide()
							End If
						ElseIf RemoveForm Then
							If Operators.CompareString(FormName, "Results", False) <> 0 Then
								form.Dispose()
							Else
								form.Hide()
							End If
						End If
					End If
					IL_BD:
				Next
				If bError Then
					flag = False
				End If
				result = flag
			Catch ex3 As Exception
				bError = True
				result = False
			End Try
			Return result
		End Function

		Public Sub InitResultsForm()
			Try
				Dim results As Results = New Results()
				Dim formName As String = "Results"
				Dim form As Form = results
				Dim flag As Boolean = Me.ReturnMdiForm(formName, form)
				results = CType(form, Results)
				Dim flag2 As Boolean = flag
				If flag2 Then
					results.ReInitializeVars()
					results.ResultsLoad(False)
					Application.DoEvents()
					Application.DoEvents()
					Application.DoEvents()
					Application.DoEvents()
					Application.DoEvents()
					Application.DoEvents()
					Application.DoEvents()
					Application.DoEvents()
					Application.DoEvents()
					Application.DoEvents()
					results.Show()
				End If
			Catch ex As Exception
			End Try
		End Sub

		Public Function ReturnMdiForm(FormName As String, ByRef retfrm As Form) As Boolean
			Dim flag As Boolean = False
			For Each form As Form In Me.MdiChildren
				If Operators.CompareString(FormName, form.Name, False) = 0 Then
					flag = True
					retfrm = form
				End If
			Next
			If Not flag Then
				retfrm = Nothing
			End If
			Return flag
		End Function

		Private Sub AddMotorData(bShow As Boolean)
			' The following expression was wrapped in a checked-statement
			Try
				Dim flag As Boolean
				If Not Me.MdiFormExists("MotorData", True, False, bShow, flag) Then
					Me.windowCount += 1
					Dim motorData As MotorData = New MotorData()
					motorData.MdiParent = Me
					If bShow Then
						Me.frmHowToStart.Hide()
						Application.DoEvents()
						RSWIN_DESC.sLastMDIFormName = "MotorData"
						motorData.Show()
					Else
						motorData.Hide()
					End If
				End If
			Catch ex As Exception
				Dim sMsg As String = "Error in Add MotorData Form: " + ex.Message
				Dim sMsgType As String = ""
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
			End Try
		End Sub

		Public Sub AddDlgSelectInput(bShow As Boolean, bSendToBack As Boolean)
			' The following expression was wrapped in a checked-statement
			Try
				Dim flag As Boolean
				If Not Me.MdiFormExists("dlgSelectInput", True, False, bShow, flag) Then
					Me.windowCount += 1
					Dim dlgSelectInput As dlgSelectInput = New dlgSelectInput()
					dlgSelectInput.MdiParent = Me
					dlgSelectInput.StartPosition = FormStartPosition.Manual
					dlgSelectInput.Left = Me.Width - dlgSelectInput.Width - 5
					dlgSelectInput.Top = 0
					Application.DoEvents()
					If bShow Then
						Me.frmHowToStart.Hide()
						Application.DoEvents()
						dlgSelectInput.Show()
						Application.DoEvents()
						If bSendToBack Then
							dlgSelectInput.SendToBack()
						End If
					Else
						dlgSelectInput.Hide()
					End If
				End If
			Catch ex As Exception
				Dim sMsg As String = "Error in Add dlgSelectInput Form: " + ex.Message
				Dim sMsgType As String = ""
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
			End Try
		End Sub

		Private Sub AddResults(bShow As Boolean)
			' The following expression was wrapped in a checked-statement
			Try
				If bShow Then
					Try
						Me.StopRunAni()
					Catch ex As Exception
					End Try
				End If
				Me.SetCBMTooltipText()
				Dim flag As Boolean
				If Not Me.MdiFormExists("Results", True, False, bShow, flag) Then
					Me.windowCount += 1
					Dim results As Results = New Results()
					results.MdiParent = Me
					If bShow Then
						Me.frmHowToStart.Hide()
						Application.DoEvents()
						RSWIN_DESC.sLastMDIFormName = "Results"
						results.CenterForm()
						results.Width = Me.Width - 30
						results.Height = Me.Height - 125
						results.Top = 0
						results.Left = 0
						results.Show()
					Else
						results.Hide()
					End If
				End If
				Try
					Me.RemoveChildForm("WellInfo", False)
				Catch ex2 As Exception
				End Try
			Catch ex3 As Exception
			End Try
		End Sub

		Private Sub AddProdInfo(bShow As Boolean)
			' The following expression was wrapped in a checked-statement
			Try
				Dim flag As Boolean
				If Not Me.MdiFormExists("ProdInfo", True, False, bShow, flag) Then
					Me.windowCount += 1
					Dim prodInfo As ProdInfo = New ProdInfo()
					prodInfo.MdiParent = Me
					If bShow Then
						Me.frmHowToStart.Hide()
						Application.DoEvents()
						RSWIN_DESC.sLastMDIFormName = "ProdInfo"
						prodInfo.Show()
					Else
						prodInfo.Hide()
					End If
				End If
			Catch ex As Exception
				Dim sMsg As String = "Error in Add ProdInfo Form: " + ex.Message
				Dim sMsgType As String = ""
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
			End Try
		End Sub

		Private Sub AddPTInfo(bShow As Boolean)
			' The following expression was wrapped in a checked-statement
			Try
				Dim flag As Boolean
				If Not Me.MdiFormExists("PTInfo", True, False, bShow, flag) Then
					Me.windowCount += 1
					Dim ptinfo As PTInfo = New PTInfo()
					ptinfo.MdiParent = Me
					If bShow Then
						Me.frmHowToStart.Hide()
						Application.DoEvents()
						RSWIN_DESC.sLastMDIFormName = "PTInfo"
						ptinfo.Show()
					Else
						ptinfo.Hide()
					End If
				End If
			Catch ex As Exception
				Dim sMsg As String = "Error in Add PTInfo Form: " + ex.Message
				Dim sMsgType As String = ""
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
			End Try
		End Sub

		Private Sub AddBatchLog(bShow As Boolean)
			' The following expression was wrapped in a checked-statement
			Try
				Dim flag As Boolean
				If Not Me.MdiFormExists("BatchLog", True, False, bShow, flag) Then
					Me.windowCount += 1
					Dim batchLog As BatchLog = New BatchLog()
					batchLog.MdiParent = Me
					If bShow Then
						Me.frmHowToStart.Hide()
						Application.DoEvents()
						RSWIN_DESC.sLastMDIFormName = "BatchLog"
						batchLog.Initialize()
						batchLog.Show()
						batchLog.FilesSelected = RSWIN_DESC.mcBatchFiles.ToString()
					Else
						batchLog.Hide()
					End If
				End If
			Catch ex As Exception
				Dim sMsg As String = "Error in Add BatchLog Form: " + ex.Message
				Dim sMsgType As String = ""
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
			End Try
		End Sub

		Private Sub FileAdd_Clicked(sender As Object, e As EventArgs)
			Me.AddWellInfo(True)
		End Sub

		Public Sub ShowResultsForm()
			Me.RemoveForms()
			Me.AddResults(True)
		End Sub

		Private Sub FileExit_Clicked(sender As Object, e As EventArgs)
			Me.Close()
			ProjectData.EndApp()
		End Sub

		Private Sub MDIChildActivated(sender As Object, e As EventArgs)
			If Me.ActiveMdiChild Is Nothing Then
				Me.panStatus.Text = ""
				Return
			End If
			Me.panStatus.Text = Me.ActiveMdiChild.Text
		End Sub

		Private Sub WindowCascade_Clicked(sender As Object, e As EventArgs)
			Me.LayoutMdi(MdiLayout.Cascade)
			Me.ResetClock()
		End Sub

		Private Sub WindowTileH_Clicked(sender As Object, e As EventArgs)
			Me.LayoutMdi(MdiLayout.TileHorizontal)
			Me.ResetClock()
		End Sub

		Private Sub WindowTileV_Clicked(sender As Object, e As EventArgs)
			Me.LayoutMdi(MdiLayout.TileVertical)
			Me.ResetClock()
		End Sub

		Friend Overridable Property tbrRun As ToolBarButton
			Get
				Return Me._tbrRun
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolBarButton)
				Me._tbrRun = value
			End Set
		End Property

		Friend Overridable Property tbrReport As ToolBarButton
			Get
				Return Me._tbrReport
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolBarButton)
				Me._tbrReport = value
			End Set
		End Property

		Friend Overridable Property tbrPrint As ToolBarButton
			Get
				Return Me._tbrPrint
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolBarButton)
				Me._tbrPrint = value
			End Set
		End Property

		Friend Overridable Property tbrCBM As ToolBarButton
			Get
				Return Me._tbrCBM
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolBarButton)
				Me._tbrCBM = value
			End Set
		End Property

		Friend Overridable Property tbrNew As ToolBarButton
			Get
				Return Me._tbrNew
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolBarButton)
				Me._tbrNew = value
			End Set
		End Property

		Friend Overridable Property tbrOpen As ToolBarButton
			Get
				Return Me._tbrOpen
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolBarButton)
				Me._tbrOpen = value
			End Set
		End Property

		Friend Overridable Property tbrSave As ToolBarButton
			Get
				Return Me._tbrSave
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolBarButton)
				Me._tbrSave = value
			End Set
		End Property

		Friend Overridable Property tbrOptions As ToolBarButton
			Get
				Return Me._tbrOptions
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolBarButton)
				Me._tbrOptions = value
			End Set
		End Property

		Friend Overridable Property tbrWellInfo As ToolBarButton
			Get
				Return Me._tbrWellInfo
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolBarButton)
				Me._tbrWellInfo = value
			End Set
		End Property

		Friend Overridable Property tbrProdInfo As ToolBarButton
			Get
				Return Me._tbrProdInfo
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolBarButton)
				Me._tbrProdInfo = value
			End Set
		End Property

		Friend Overridable Property tbrPumpTubingInfo As ToolBarButton
			Get
				Return Me._tbrPumpTubingInfo
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolBarButton)
				Me._tbrPumpTubingInfo = value
			End Set
		End Property

		Friend Overridable Property tbrRSInput As ToolBarButton
			Get
				Return Me._tbrRSInput
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolBarButton)
				Me._tbrRSInput = value
			End Set
		End Property

		Friend Overridable Property tbrPUData As ToolBarButton
			Get
				Return Me._tbrPUData
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolBarButton)
				Me._tbrPUData = value
			End Set
		End Property

		Friend Overridable Property tbrMotorData As ToolBarButton
			Get
				Return Me._tbrMotorData
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolBarButton)
				Me._tbrMotorData = value
			End Set
		End Property

		Friend Overridable Property tbrNext As ToolBarButton
			Get
				Return Me._tbrNext
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolBarButton)
				Me._tbrNext = value
			End Set
		End Property

		Friend Overridable Property btnVisualInput As Button
			Get
				Return Me._btnVisualInput
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnVisualInput_Click
				If Me._btnVisualInput IsNot Nothing Then
					RemoveHandler Me._btnVisualInput.Click, value2
				End If
				Me._btnVisualInput = value
				If Me._btnVisualInput IsNot Nothing Then
					AddHandler Me._btnVisualInput.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property tbrHelp As ToolBarButton
			Get
				Return Me._tbrHelp
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolBarButton)
				Me._tbrHelp = value
			End Set
		End Property

		Friend Overridable Property pnlToolbar As Panel
			Get
				Return Me._pnlToolbar
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._pnlToolbar = value
			End Set
		End Property

		Friend Overridable Property OpenFileDialog1 As OpenFileDialog
			Get
				Return Me._OpenFileDialog1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As OpenFileDialog)
				Me._OpenFileDialog1 = value
			End Set
		End Property

		Friend Overridable Property SaveFileDialog1 As SaveFileDialog
			Get
				Return Me._SaveFileDialog1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As SaveFileDialog)
				Me._SaveFileDialog1 = value
			End Set
		End Property

		Friend Overridable Property MainMenu1 As MainMenu
			Get
				Return Me._MainMenu1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MainMenu)
				Me._MainMenu1 = value
			End Set
		End Property

		Friend Overridable Property ContextMenu1 As ContextMenu
			Get
				Return Me._ContextMenu1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ContextMenu)
				Me._ContextMenu1 = value
			End Set
		End Property

		Friend Overridable Property tbrToolbar As ToolBar
			Get
				Return Me._tbrToolbar
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolBar)
				Dim value2 As ToolBarButtonClickEventHandler = AddressOf Me.tbrToolBar_ButtonClick
				If Me._tbrToolbar IsNot Nothing Then
					RemoveHandler Me._tbrToolbar.ButtonClick, value2
				End If
				Me._tbrToolbar = value
				If Me._tbrToolbar IsNot Nothing Then
					AddHandler Me._tbrToolbar.ButtonClick, value2
				End If
			End Set
		End Property

		Friend Overridable Property PrintDialog1 As PrintDialog
			Get
				Return Me._PrintDialog1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PrintDialog)
				Me._PrintDialog1 = value
			End Set
		End Property

		Friend Overridable Property tbrSep3 As ToolBarButton
			Get
				Return Me._tbrSep3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolBarButton)
				Me._tbrSep3 = value
			End Set
		End Property

		Friend Overridable Property tbrSep4 As ToolBarButton
			Get
				Return Me._tbrSep4
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolBarButton)
				Me._tbrSep4 = value
			End Set
		End Property

		Friend Overridable Property tbrEmail As ToolBarButton
			Get
				Return Me._tbrEmail
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolBarButton)
				Me._tbrEmail = value
			End Set
		End Property

		Friend Overridable Property tbrDeviated As ToolBarButton
			Get
				Return Me._tbrDeviated
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolBarButton)
				Me._tbrDeviated = value
			End Set
		End Property

		Friend Overridable Property ToolTip1 As ToolTip
			Get
				Return Me._ToolTip1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolTip)
				Me._ToolTip1 = value
			End Set
		End Property

		Friend Overridable Property btnAlpha As Button
			Get
				Return Me._btnAlpha
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnAlpha_Click
				If Me._btnAlpha IsNot Nothing Then
					RemoveHandler Me._btnAlpha.Click, value2
				End If
				Me._btnAlpha = value
				If Me._btnAlpha IsNot Nothing Then
					AddHandler Me._btnAlpha.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property ImageList2 As ImageList
			Get
				Return Me._ImageList2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ImageList)
				Me._ImageList2 = value
			End Set
		End Property

		Friend Overridable Property tbrGuru As ToolBar
			Get
				Return Me._tbrGuru
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolBar)
				Dim value2 As ToolBarButtonClickEventHandler = AddressOf Me.tbrGuru_ButtonClick
				If Me._tbrGuru IsNot Nothing Then
					RemoveHandler Me._tbrGuru.ButtonClick, value2
				End If
				Me._tbrGuru = value
				If Me._tbrGuru IsNot Nothing Then
					AddHandler Me._tbrGuru.ButtonClick, value2
				End If
			End Set
		End Property

		Friend Overridable Property ToolBarButton1 As ToolBarButton
			Get
				Return Me._ToolBarButton1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolBarButton)
				Me._ToolBarButton1 = value
			End Set
		End Property

		Friend Overridable Property lblGURU As Label
			Get
				Return Me._lblGURU
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblGURU = value
			End Set
		End Property

		Friend Overridable Property ImageList_Guru As ImageList
			Get
				Return Me._ImageList_Guru
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ImageList)
				Me._ImageList_Guru = value
			End Set
		End Property

		Friend Overridable Property ImageList_Guru_large As ImageList
			Get
				Return Me._ImageList_Guru_large
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ImageList)
				Me._ImageList_Guru_large = value
			End Set
		End Property

		Friend Overridable Property btnGuru As Button
			Get
				Return Me._btnGuru
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnGuru_Click
				If Me._btnGuru IsNot Nothing Then
					RemoveHandler Me._btnGuru.Click, value2
				End If
				Me._btnGuru = value
				If Me._btnGuru IsNot Nothing Then
					AddHandler Me._btnGuru.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property btnVertical As Button
			Get
				Return Me._btnVertical
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnVertical_Click
				If Me._btnVertical IsNot Nothing Then
					RemoveHandler Me._btnVertical.Click, value2
				End If
				Me._btnVertical = value
				If Me._btnVertical IsNot Nothing Then
					AddHandler Me._btnVertical.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property AniRun As AnimationControl
			Get
				Return Me._AniRun
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As AnimationControl)
				Me._AniRun = value
			End Set
		End Property

		Friend Overridable Property tbrRunSpeed As ToolBarButton
			Get
				Return Me._tbrRunSpeed
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolBarButton)
				Me._tbrRunSpeed = value
			End Set
		End Property

		Friend Overridable Property tbrAbort As ToolBar
			Get
				Return Me._tbrAbort
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolBar)
				Dim value2 As ToolBarButtonClickEventHandler = AddressOf Me.tbrAbort_ButtonClick
				If Me._tbrAbort IsNot Nothing Then
					RemoveHandler Me._tbrAbort.ButtonClick, value2
				End If
				Me._tbrAbort = value
				If Me._tbrAbort IsNot Nothing Then
					AddHandler Me._tbrAbort.ButtonClick, value2
				End If
			End Set
		End Property

		Friend Overridable Property ToolBarButton2 As ToolBarButton
			Get
				Return Me._ToolBarButton2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolBarButton)
				Me._ToolBarButton2 = value
			End Set
		End Property

		Friend Overridable Property pnlAIavi As Panel
			Get
				Return Me._pnlAIavi
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._pnlAIavi = value
			End Set
		End Property

		Friend Overridable Property AIavi As AnimationControl
			Get
				Return Me._AIavi
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As AnimationControl)
				Me._AIavi = value
			End Set
		End Property

		Friend Overridable Property lblMode As Label
			Get
				Return Me._lblMode
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblMode = value
			End Set
		End Property

		Friend Overridable Property btnMeasUnit As Button
			Get
				Return Me._btnMeasUnit
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.btnMeasUnit_Click
				If Me._btnMeasUnit IsNot Nothing Then
					RemoveHandler Me._btnMeasUnit.Click, value2
				End If
				Me._btnMeasUnit = value
				If Me._btnMeasUnit IsNot Nothing Then
					AddHandler Me._btnMeasUnit.Click, value2
				End If
			End Set
		End Property

		Friend Overridable Property tbrExpertAdmin As ToolBar
			Get
				Return Me._tbrExpertAdmin
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolBar)
				Dim value2 As ToolBarButtonClickEventHandler = AddressOf Me.tbrExpertAdmin_ButtonClick
				If Me._tbrExpertAdmin IsNot Nothing Then
					RemoveHandler Me._tbrExpertAdmin.ButtonClick, value2
				End If
				Me._tbrExpertAdmin = value
				If Me._tbrExpertAdmin IsNot Nothing Then
					AddHandler Me._tbrExpertAdmin.ButtonClick, value2
				End If
			End Set
		End Property

		Friend Overridable Property btnToolsUploadRSVXFile As ToolBarButton
			Get
				Return Me._btnToolsUploadRSVXFile
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolBarButton)
				Me._btnToolsUploadRSVXFile = value
			End Set
		End Property

		Friend Overridable Property btnToolsUploadRSVXFiles As ToolBarButton
			Get
				Return Me._btnToolsUploadRSVXFiles
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolBarButton)
				Me._btnToolsUploadRSVXFiles = value
			End Set
		End Property

		Friend Overridable Property btnToolsBatchExportFromOneFolder As ToolBarButton
			Get
				Return Me._btnToolsBatchExportFromOneFolder
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolBarButton)
				Me._btnToolsBatchExportFromOneFolder = value
			End Set
		End Property

		Friend Overridable Property btnToolsDownloadToRSVX As ToolBarButton
			Get
				Return Me._btnToolsDownloadToRSVX
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolBarButton)
				Me._btnToolsDownloadToRSVX = value
			End Set
		End Property

		Friend Overridable Property btnToolsDeleteTemplate As ToolBarButton
			Get
				Return Me._btnToolsDeleteTemplate
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolBarButton)
				Me._btnToolsDeleteTemplate = value
			End Set
		End Property

		Friend Overridable Property btnToolsBatchExportALL As ToolBarButton
			Get
				Return Me._btnToolsBatchExportALL
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolBarButton)
				Me._btnToolsBatchExportALL = value
			End Set
		End Property

		Friend Overridable Property btnToolsEncryptTemplateDatabase As ToolBarButton
			Get
				Return Me._btnToolsEncryptTemplateDatabase
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolBarButton)
				Me._btnToolsEncryptTemplateDatabase = value
			End Set
		End Property

		Friend Overridable Property ImageList_admin As ImageList
			Get
				Return Me._ImageList_admin
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ImageList)
				Me._ImageList_admin = value
			End Set
		End Property

		Friend Overridable Property btnViewAllTemplates As ToolBarButton
			Get
				Return Me._btnViewAllTemplates
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolBarButton)
				Me._btnViewAllTemplates = value
			End Set
		End Property

		Friend Overridable Property btnViewAddedTemplates As ToolBarButton
			Get
				Return Me._btnViewAddedTemplates
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolBarButton)
				Me._btnViewAddedTemplates = value
			End Set
		End Property

		Friend Overridable Property btnRunAllTemplates As ToolBarButton
			Get
				Return Me._btnRunAllTemplates
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolBarButton)
				Me._btnRunAllTemplates = value
			End Set
		End Property

		<STAThread()>
		Public Shared Sub Main(sArgs As String())
			RSWIN_DESC.msArgRSTFilePath = ""
			If sArgs.Length > 0 Then
				Dim text As String = Strings.LCase(sArgs(0))
				text = text.ToLower()
				If Operators.CompareString(text, "/a", False) = 0 Then
					RSWIN_DESC.mbStartAutoBatch = True
				Else
					Dim num As Integer = Strings.InStr(text, "/xdg=", CompareMethod.Binary)
					If num > 0 Then
						RSWIN_DESC.msArgRSTFilePath = Strings.Mid(text, num + 5)
					Else
						num = Strings.InStr(text, "/rdg=", CompareMethod.Binary)
						If num > 0 Then
							RSWIN_DESC.msArgRSTFilePath = Strings.Mid(text, num + 5)
						Else
							num = Strings.InStr(text, "/rst=", CompareMethod.Binary)
							If num > 0 Then
								RSWIN_DESC.msArgRSTFilePath = Strings.Mid(text, num + 5)
							Else
								num = Strings.InStr(text, "/xrvx=", CompareMethod.Binary)
								If num > 0 Then
									RSWIN_DESC.msArgRSTFilePath = Strings.Mid(text, num + 6)
								Else
									num = Strings.InStr(text, "/rsvx=", CompareMethod.Binary)
									If num > 0 Then
										RSWIN_DESC.msArgRSTFilePath = Strings.Mid(text, num + 6)
									Else
										num = Strings.InStr(text, "/rsdx=", CompareMethod.Binary)
										If num > 0 Then
											RSWIN_DESC.msArgRSTFilePath = Strings.Mid(text, num + 6)
										Else
											num = Strings.InStr(text, "/xddx=", CompareMethod.Binary)
											If num > 0 Then
												RSWIN_DESC.msArgRSTFilePath = Strings.Mid(text, num + 6)
											ElseIf Strings.InStr(text, ".xdg", CompareMethod.Binary) > 0 Or Strings.InStr(text, ".xddx", CompareMethod.Binary) > 0 Or Strings.InStr(text, ".rdg", CompareMethod.Binary) > 0 Or Strings.InStr(text, ".rst", CompareMethod.Binary) > 0 Or Strings.InStr(text, ".rsvx", CompareMethod.Binary) > 0 Or Strings.InStr(text, ".rsdx", CompareMethod.Binary) > 0 Or Strings.InStr(text, ".xrvx", CompareMethod.Binary) > 0 Then
												RSWIN_DESC.msArgRSTFilePath = text
											End If
										End If
									End If
								End If
							End If
						End If
					End If
				End If
			End If
			Try
				If Not RSWIN_DESC.bMainClosed Then
					Application.Run(New RODSTAR())
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub DisplayActiveFormActiveControl()
			Dim activeMdiChild As Form = Me.ActiveMdiChild
			Dim name As String = activeMdiChild.Name
			Dim sMsg As String = "This is the active form, " + name
			Dim sMsgType As String = ""
			Dim bClosing As Boolean = False
			Dim dialogResult As DialogResult = DialogResult.OK
			Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
			Dim activeControl As Control = Me.ActiveMdiChild.ActiveControl
			If activeControl Is Nothing Then
				Dim sMsg2 As String = "No Active Control"
				Dim sMsgType2 As String = ""
				Dim bClosing2 As Boolean = False
				dialogResult = DialogResult.OK
				Util.SendMessage(sMsg2, sMsgType2, bClosing2, dialogResult)
			Else
				Dim sMsg3 As String = "This is the active control" + activeControl.Name
				Dim sMsgType3 As String = ""
				Dim bClosing3 As Boolean = False
				dialogResult = DialogResult.OK
				Util.SendMessage(sMsg3, sMsgType3, bClosing3, dialogResult)
			End If
		End Sub

		Public Sub NewFile(iFirstDataWindow As Integer, Optional bInProgress As Boolean = False)
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			Dim i As Integer
			If Not bInProgress Then
				i = 1
				Do
					rst.LineSettings(i).LSet = 0S
					rst.LineSettings(i).Value = 0F
					i += 1
				Loop While i <= 4
				rst.CBDataType = 0S
				rst.SPM = 0F
				rst.RodStringType = 0S
				rst.Ntsteps = 0S
				rst.gbRoddiagFile = False
			End If
			i = 1
			Do
				RSWIN_DESC.NewData(i) = -1S
				Me.ToolbarButtonSetState(Conversions.ToInteger(Me.TBFromScreen(i)), False)
				i += 1
			Loop While i <= 7
			If iFirstDataWindow > 7 Then
				iFirstDataWindow = 1
				Me.ToolbarButtonSetState(2, True)
				Me.ToolbarButtonSetState(1, True)
				Me.ToolbarButtonSetState(0, True)
			Else
				Me.ToolbarButtonSetState(Conversions.ToInteger(Me.TBFromScreen(iFirstDataWindow)), True)
				Me.ToolbarButtonSetState(0, False)
				Me.ToolbarButtonSetState(2, True)
				Me.ToolbarButtonSetState(1, True)
				Me.ToolbarButtonSetState(0, True)
				Me.ToolbarButtonSetState(16, True)
			End If
			Me.UnloadAllForms(0, True)
			rst.Inputfile = "(Untitled)"
			Me.SetCaption(rst.Inputfile)
			rst.gbInputDataChanged = True
			rst.gbOutputLoaded = False
			rst.SetClassDefaults(True)
			If Not rst.gbAutomatic And Not rst.gbBatch Then
				Me.RemoveAllChildForms(False)
			End If
			Me.frmHowToStart.Hide()
			Application.DoEvents()
			Me.AddVisInput(False, False)
			Me.btnVisualInput.Enabled = False
			Me.btnAlpha.Enabled = False
			If Not bInProgress Then
				Me.AddWellInfo(True)
			ElseIf RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru Then
				If Conversions.ToBoolean(Operators.NotObject(ini.GetDataValue("WellInfo", 11, False, False))) Then
					Me.LoadDataInProgress(8, True)
					Me.ToolbarButtonSetState(8, True)
					Me.ToolbarButtonSetState(16, False)
				ElseIf Conversions.ToBoolean(Operators.OrObject(Operators.NotObject(ini.GetDataValue("ProdInfo", 11, False, False)), RSWIN_DESC.rst.TargetBFPD = 0F)) Then
					Me.LoadDataInProgress(8, False)
					Me.LoadDataInProgress(9, True)
					Me.ToolbarButtonSetState(8, True)
					Me.ToolbarButtonSetState(9, True)
					Me.ToolbarButtonSetState(15, True)
					Me.ToolbarButtonSetState(16, False)
				End If
			Else
				Dim num As Integer = 1
				Dim num2 As Integer = iFirstDataWindow - 1
				i = num
				While i <= num2
					If i = iFirstDataWindow - 1 Then
						RSWIN_DESC.NewData(i) = 0S
						Me.LoadDataInProgress(Conversions.ToInteger(Me.TBFromScreen(i)), True)
					Else
						RSWIN_DESC.NewData(i) = 0S
						Me.LoadDataInProgress(Conversions.ToInteger(Me.TBFromScreen(i)), False)
					End If
					Me.ToolbarButtonSetState(Conversions.ToInteger(Me.TBFromScreen(i)), True)
					i += 1
				End While
				Me.ToolbarButtonSetState(16, False)
				Me.ToolbarButtonSetState(15, False)
			End If
			Me.ToolbarButtonSetState(16, True)
			Me.ToolbarButtonSetState(15, True)
			If Not bInProgress Then
				Me.ToolbarButtonSetState(-2, False)
				Me.ToolbarButtonSetState(16, False)
			End If
			RSWIN_DESC.rst.gbInputDataChanged = True
		End Sub

		Public Sub UnloadAllForms(UnloadMode As Object, Done As Object)
			Try
				For Each form As Form In Me.MdiChildren
					Try
						If form IsNot Nothing AndAlso Not(Me.bDisplayBatchFileOutput And Operators.CompareString(form.Name, "BatchLog", False) = 0) Then
							form.Hide()
						End If
					Catch ex As Exception
					End Try
				Next
			Catch ex2 As Exception
			End Try
		End Sub

		Public Sub RemoveAllChildForms(Optional bRemoveVisInput As Boolean = True)
			For Each form As Form In Me.MdiChildren
				If form IsNot Nothing AndAlso Not(Me.bDisplayBatchFileOutput And Operators.CompareString(form.Name, "BatchLog", False) = 0) Then
					If bRemoveVisInput And Operators.CompareString(form.Name, "VisInput", False) = 0 Then
						Try
							form.Hide()
							form.Dispose()
							GoTo IL_B3
						Catch ex As Exception
							GoTo IL_B3
						End Try
					End If
					If Operators.CompareString(form.Name, "VisInput", False) <> 0 Then
						Try
							form.Hide()
							If Operators.CompareString(form.Name, "Results", False) <> 0 Then
								form.Dispose()
							End If
						Catch ex2 As Exception
						End Try
					End If
				End If
				IL_B3:
			Next
		End Sub

		Public Sub RemoveChildForm(sChildFormName As String, Optional bForceDispose As Boolean = False)
			Try
				For Each form As Form In Me.MdiChildren
					If Operators.CompareString(form.Name, sChildFormName, False) = 0 Then
						Try
							form.Hide()
						Catch ex As Exception
						End Try
						Try
							If Operators.CompareString(sChildFormName, "Results", False) <> 0 OrElse bForceDispose Then
								form.Dispose()
							End If
							If Operators.CompareString(sChildFormName, "Results", False) = 0 And Not RSWIN_DESC.rst.gbOutputLoaded Then
								Me.ToolbarButtonSetState2(2, False)
							End If
						Catch ex2 As Exception
						End Try
					End If
				Next
			Catch ex3 As Exception
			End Try
		End Sub

		Public Function ChildFormExists(sChildFormName As String) As Boolean
			Dim result As Boolean = False
			For Each form As Form In Me.MdiChildren
				If Operators.CompareString(form.Name, sChildFormName, False) = 0 Then
					result = True
					Exit For
				End If
			Next
			Return result
		End Function

		Public Sub RemoveChildForms()
			For Each form As Form In Me.MdiChildren
				If Operators.CompareString(form.Name, "frmHowToStart", False) <> 0 And Operators.CompareString(form.Name, "FAboutSplash", False) <> 0 And Operators.CompareString(form.Name, "Clock", False) <> 0 And Not(Me.bDisplayBatchFileOutput And Operators.CompareString(form.Name, "BatchLog", False) = 0) Then
					Try
						form.Hide()
					Catch ex As Exception
					End Try
					Try
						If Operators.CompareString(form.Name, "Results", False) <> 0 Then
							form.Dispose()
						End If
					Catch ex2 As Exception
					End Try
				End If
			Next
		End Sub

		Public Sub UnloadForm(ByRef frm As Form, iUnloadMode As Short, ByRef bDone As Boolean)
			For Each form As Form In Me.MdiChildren
				If frm.Name = form.Name Then
					form.Hide()
				End If
			Next
		End Sub

		Public Sub QueryUnload(sender As Object, e As CancelEventArgs)
			Me.bClosing = True
			Me.SaveRecentFiles(RSWIN_DESC.RECENTFILES, RSWIN_DESC.sINIFile)
			Try
				If Me.mTLM32 IsNot Nothing AndAlso Operators.CompareString(Me.mTLM32.LicenseType, "", False) <> 0 Then
					Me.mTLM32.ReleaseLicense()
				End If
				Try
					Me.RemoveAllChildForms(True)
				Catch ex As Exception
				End Try
				RSWIN_DESC.bRunStarRunning = False
				Try
					NewLateBinding.LateSet(RSWIN_DESC.objExcel, Nothing, "oWB", New Object() { Nothing }, Nothing, Nothing)
				Catch ex2 As Exception
				End Try
				Try
					NewLateBinding.LateSet(RSWIN_DESC.objExcel, Nothing, "oSheet", New Object() { Nothing }, Nothing, Nothing)
				Catch ex3 As Exception
				End Try
				Try
					NewLateBinding.LateSet(RSWIN_DESC.objExcel, Nothing, "oRng", New Object() { Nothing }, Nothing, Nothing)
				Catch ex4 As Exception
				End Try
				Try
					RSWIN_DESC.objExcel = Nothing
				Catch ex5 As Exception
				End Try
				Try
					Me.RemoveChildForm("BatchLog", False)
				Catch ex6 As Exception
				End Try
			Catch ex7 As Exception
			End Try
		End Sub

		Public Sub ToolsSetup_Click(eventSender As Object, eventArgs As EventArgs)
			Dim rswinSetup As RswinSetup = New RswinSetup()
			Me.frmHowToStart.Hide()
			Application.DoEvents()
			Dim flag As Boolean = False
			Dim activeMdiChild As Form
			Try
				Me.ResetClock()
				activeMdiChild = Me.ActiveMdiChild
				If activeMdiChild.Visible Then
					flag = True
					activeMdiChild.Hide()
				End If
				Me.RemoveForms()
			Catch ex As Exception
			End Try
			Me.RemoveChildForm("Results", False)
			Me.DisableMe()
			Dim rswinSetup2 As RswinSetup = rswinSetup
			Me.ResizeRswinsetup(rswinSetup)
			rswinSetup2.ShowDialog()
			If Operators.CompareString(Me.SAVE_SETUP_Language, RSWIN_DESC.SETUP_Language, False) <> 0 And RSWIN_DESC.bIntVersion Then
				Me.RemoveAllChildForms(True)
				If RSWIN_DESC.bChangeCultures Then
					Dim setup_Language As String = RSWIN_DESC.SETUP_Language
					If Operators.CompareString(setup_Language, RSWIN_DESC.sEnglish, False) = 0 Then
						RSWIN_DESC.myCulture = New CultureInfo(RSWIN_DESC.sEnglish)
						Me.btnVisualInput.Width = 90
					ElseIf Operators.CompareString(setup_Language, RSWIN_DESC.sSpanish, False) = 0 Then
						RSWIN_DESC.myCulture = New CultureInfo(RSWIN_DESC.sSpanish)
						Me.btnVisualInput.Width = 200
					ElseIf Operators.CompareString(setup_Language, RSWIN_DESC.sChinese, False) = 0 Then
						RSWIN_DESC.myCulture = New CultureInfo(RSWIN_DESC.sChinese)
					Else
						RSWIN_DESC.myCulture = New CultureInfo(RSWIN_DESC.sEnglish)
					End If
					Thread.CurrentThread.CurrentUICulture = RSWIN_DESC.myCulture
				End If
				If RSWIN_DESC.bReadResXFile Then
					Dim name As String = Me.Name
					Dim sMenu As String = "MainMenu1"
					Dim mainMenu As MainMenu = Me.MainMenu1
					Me.AssignToMainMenu(name, sMenu, mainMenu)
					Me.MainMenu1 = mainMenu
					Util.AssignValuesToControls(Me)
					Me.ReassignVariables()
				End If
				Me.btnAlpha.Left = Me.btnVisualInput.Left + Me.btnVisualInput.Width + 5
			End If
			Me.EnableMe()
			If flag Then
				Try
					Dim name2 As String = activeMdiChild.Name
					Me.RemoveForms()
					Dim text As String = name2
					If Operators.CompareString(text, "WellInfo", False) = 0 Then
						Me.AddWellInfo(True)
						Return
					End If
					If Operators.CompareString(text, "ProdInfo", False) = 0 Then
						Me.AddProdInfo(True)
						Return
					End If
					If Operators.CompareString(text, "PTInfo", False) = 0 Then
						Me.AddPTInfo(True)
						Return
					End If
					If Operators.CompareString(text, "RSInput", False) = 0 Then
						Me.AddRSInput(True, False)
						Return
					End If
					If Operators.CompareString(text, "DeviationProfile", False) = 0 Then
						If RSWIN_DESC.bRodStarD Then
							Me.AddDeviationProfile(True)
						End If
					ElseIf Operators.CompareString(text, "PUData", False) = 0 Then
						Me.AddPUData(True)
					ElseIf Operators.CompareString(text, "MotorData", False) = 0 Then
						Me.AddMotorData(True)
					ElseIf Operators.CompareString(text, "Results", False) = 0 Then
						Me.RemoveForms()
						Me.AddResults(True)
					End If
					Return
				Catch ex2 As Exception
					Return
				End Try
			End If
			Me.RemoveForms()
		End Sub

		Private Sub tbrToolBar3_ButtonClick(sender As Object, e As ToolBarButtonClickEventArgs)
			Try
				Dim activeMdiChild As Form = Me.ActiveMdiChild
				Dim activeControl As Control = activeMdiChild.ActiveControl
				Dim text As String
				If Operators.CompareString(activeMdiChild.Name, "WellInfo", False) = 0 Then
					Dim wellInfo As WellInfo = New WellInfo()
					Dim formName As String = "WellInfo"
					Dim form As Form = wellInfo
					Me.ReturnMdiForm(formName, form)
					wellInfo = CType(form, WellInfo)
					text = wellInfo.HelpProvider1.GetHelpKeyword(activeControl)
				ElseIf Operators.CompareString(activeMdiChild.Name, "PTInfo", False) = 0 Then
					Dim ptinfo As PTInfo = New PTInfo()
					Dim formName2 As String = "PTInfo"
					Dim form As Form = ptinfo
					Me.ReturnMdiForm(formName2, form)
					ptinfo = CType(form, PTInfo)
					text = ptinfo.HelpProvider1.GetHelpKeyword(activeControl)
				ElseIf Operators.CompareString(activeMdiChild.Name, "ProdInfo", False) = 0 Then
					Dim prodInfo As ProdInfo = New ProdInfo()
					Dim formName3 As String = "ProdInfo"
					Dim form As Form = prodInfo
					Me.ReturnMdiForm(formName3, form)
					prodInfo = CType(form, ProdInfo)
					text = prodInfo.HelpProvider1.GetHelpKeyword(activeControl)
				ElseIf Operators.CompareString(activeMdiChild.Name, "PUData", False) = 0 Then
					Dim pudata As PUData = New PUData()
					Dim formName4 As String = "PUData"
					Dim form As Form = pudata
					Me.ReturnMdiForm(formName4, form)
					pudata = CType(form, PUData)
					text = pudata.HelpProvider1.GetHelpKeyword(activeControl)
				ElseIf Operators.CompareString(activeMdiChild.Name, "RSInput", False) = 0 Then
					Dim rsinput As RSInput = New RSInput()
					Dim formName5 As String = "RSInput"
					Dim form As Form = rsinput
					Me.ReturnMdiForm(formName5, form)
					rsinput = CType(form, RSInput)
					text = rsinput.HelpProvider1.GetHelpKeyword(activeControl)
				ElseIf Operators.CompareString(activeMdiChild.Name, "DeviationProfile", False) = 0 Then
					Dim deviationProfile As DeviationProfile = New DeviationProfile()
					Dim formName6 As String = "DeviationProfile"
					Dim form As Form = deviationProfile
					Me.ReturnMdiForm(formName6, form)
					deviationProfile = CType(form, DeviationProfile)
					text = deviationProfile.HelpProvider1.GetHelpKeyword(activeControl)
				ElseIf Operators.CompareString(activeMdiChild.Name, "MotorData", False) = 0 Then
					Dim motorData As MotorData = New MotorData()
					Dim formName7 As String = "MotorData"
					Dim form As Form = motorData
					Me.ReturnMdiForm(formName7, form)
					motorData = CType(form, MotorData)
					text = motorData.HelpProvider1.GetHelpKeyword(activeControl)
				Else
					text = ""
				End If
				If Strings.Len(text) <> 0 Then
					Help.ShowHelp(Me, Me.HelpProvider1.HelpNamespace, HelpNavigator.KeywordIndex, text)
				Else
					Help.ShowHelp(Me, Me.HelpProvider1.HelpNamespace, HelpNavigator.Index, "")
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub NewFileClick(bClicked As Boolean)
			Dim num As Integer = 1
			While Not RSWIN_DESC.NewData(num) = 0S
				num += 1
				If num > 7 Then
					Try
						IL_2B:
						Me.RemoveChildForms()
						Me.CreateForms()
						Application.DoEvents()
						RSWIN_DESC.rst.SetClassDefaults(Not bClicked)
						If Not RSWIN_DESC.rst.gbAutomatic And Not RSWIN_DESC.rst.gbBatch Then
							Me.RemoveAllChildForms(False)
						End If
						Application.DoEvents()
						MImpred.InitSurveyDataset(RSWIN_DESC.mdsDeviationProfile_Edit, Nothing)
						MImpred.InitSurveyDataset(RSWIN_DESC.mdsDeviationProfile, Nothing)
						Application.DoEvents()
						RSWIN_DESC.mdsDeviationProfile_Edit = Nothing
						RSWIN_DESC.mdsDeviationProfile = Nothing
						LOADRST.DeleteTempDeviationFile()
						Application.DoEvents()
						If RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru Then
							MRodstarXML.SetAIFilePreferencesFromSetup(True)
						End If
					Catch ex As Exception
					End Try
					ini.SaveDataValue(RSWIN_DESC.sNull, "")
					RSWIN.ReCreateRegKey(RSWIN_DESC.SECT_DATAENTRY)
					ini.SaveDataValue("InProgress", True)
					Me.NewFile(1, False)
					Me.ToolbarButtonSetState(-2, False)
					Return
				End If
			End While
			Dim msg As String = Me.sARSOVERWRITE
			Dim bDefaultYes As Boolean = True
			Dim flag As Boolean = False
			If Not Util.YesNo(msg, bDefaultYes, flag) Then
				Return
			End If
			GoTo IL_2B
		End Sub

		Private Sub tbrToolBar_ButtonClick(sender As Object, e As ToolBarButtonClickEventArgs)
			Dim rswinSetup As RswinSetup = New RswinSetup()
			Try
				Select Case Me.tbrToolbar.Buttons.IndexOf(e.Button)
					Case 0
						Me.NewFileClick(True)
					Case 1
						Dim flag As Boolean
						If RSWIN_DESC.rst.gbInputDataChanged Then
							Dim msg As String = Me.sARSOVERWRITE
							Dim bDefaultYes As Boolean = True
							flag = False
							If Not Util.YesNo(msg, bDefaultYes, flag) Then
								Exit Select
							End If
						End If
						If Me.frmHowToStart.Visible Then
							Me.frmHowToStart.Hide()
							Application.DoEvents()
						End If
						Dim iFile As Short = -3S
						Dim openFileDialog As OpenFileDialog = Me.OpenFileDialog1
						Dim text As String = ""
						flag = False
						Me.OpenFile(iFile, openFileDialog, text, flag)
						Me.OpenFileDialog1 = openFileDialog
					Case 2
						Me.SAVEAFILE(False, False, False, False, False, False, RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru)
					Case 5
						Me.frmHowToStart.Hide()
						Application.DoEvents()
						Dim flag2 As Boolean = False
						Dim text2 As String
						Try
							Dim activeMdiChild As Form = Me.ActiveMdiChild
							text2 = activeMdiChild.Name
							If Operators.CompareString(text2, "Results", False) = 0 Then
								text2 = ""
							End If
							Me.RemoveChildForm("Results", False)
							If activeMdiChild.Visible Then
								flag2 = True
								activeMdiChild.Hide()
								activeMdiChild.Close()
								Me.RemoveChildForm(activeMdiChild.Name, False)
							End If
							Me.RemoveForms()
						Catch ex As Exception
						End Try
						Me.DisableMe()
						Dim rswinSetup2 As RswinSetup = rswinSetup
						Me.ResizeRswinsetup(rswinSetup)
						rswinSetup2.ShowDialog()
						If Operators.CompareString(Me.SAVE_SETUP_Language, RSWIN_DESC.SETUP_Language, False) <> 0 And RSWIN_DESC.bIntVersion Then
							Me.RemoveAllChildForms(True)
							If RSWIN_DESC.bChangeCultures Then
								Dim setup_Language As String = RSWIN_DESC.SETUP_Language
								If Operators.CompareString(setup_Language, RSWIN_DESC.sEnglish, False) = 0 Then
									RSWIN_DESC.myCulture = New CultureInfo(RSWIN_DESC.sEnglish)
									Me.btnVisualInput.Width = 90
								ElseIf Operators.CompareString(setup_Language, RSWIN_DESC.sSpanish, False) = 0 Then
									RSWIN_DESC.myCulture = New CultureInfo(RSWIN_DESC.sSpanish)
									Me.btnVisualInput.Width = 200
								ElseIf Operators.CompareString(setup_Language, RSWIN_DESC.sChinese, False) = 0 Then
									RSWIN_DESC.myCulture = New CultureInfo(RSWIN_DESC.sChinese)
								Else
									RSWIN_DESC.myCulture = New CultureInfo(RSWIN_DESC.sEnglish)
								End If
								Thread.CurrentThread.CurrentUICulture = RSWIN_DESC.myCulture
							End If
							If RSWIN_DESC.bReadResXFile Then
								Dim name As String = Me.Name
								Dim sMenu As String = "MainMenu1"
								Dim mainMenu As MainMenu = Me.MainMenu1
								Me.AssignToMainMenu(name, sMenu, mainMenu)
								Me.MainMenu1 = mainMenu
								Util.AssignValuesToControls(Me)
								Me.ReassignVariables()
							End If
							Me.btnAlpha.Left = Me.btnVisualInput.Left + Me.btnVisualInput.Width + 5
						End If
						Me.EnableMe()
						If flag2 Then
							Try
								Dim text3 As String = text2
								If Operators.CompareString(text3, "WellInfo", False) = 0 Then
									Me.AddWellInfo(True)
									Exit Try
								End If
								If Operators.CompareString(text3, "ProdInfo", False) = 0 Then
									Me.AddProdInfo(True)
									Exit Try
								End If
								If Operators.CompareString(text3, "PTInfo", False) = 0 Then
									Me.AddPTInfo(True)
									Exit Try
								End If
								If Operators.CompareString(text3, "RSInput", False) = 0 Then
									Me.AddRSInput(True, False)
									Exit Try
								End If
								If Operators.CompareString(text3, "DeviationProfile", False) = 0 Then
									If RSWIN_DESC.bRodStarD Then
										Me.AddDeviationProfile(True)
									End If
								ElseIf Operators.CompareString(text3, "PUData", False) = 0 Then
									Me.AddPUData(True)
								ElseIf Operators.CompareString(text3, "MotorData", False) = 0 Then
									Me.AddMotorData(True)
								ElseIf Operators.CompareString(text3, "Results", False) = 0 Then
									Me.RemoveForms()
									Me.AddResults(True)
								End If
								Exit Try
							Catch ex2 As Exception
								Exit Try
							End Try
						End If
						Me.RemoveForms()
					Case 8
						Dim flag4 As Boolean
						Dim flag3 As Boolean = Me.MdiFormExists("Results", False, True, False, flag4)
						Me.AddWellInfo(True)
					Case 9
						Dim flag4 As Boolean
						Dim flag3 As Boolean = Me.MdiFormExists("Results", False, True, False, flag4)
						Me.AddProdInfo(True)
					Case 10
						Dim flag4 As Boolean
						Dim flag3 As Boolean = Me.MdiFormExists("Results", False, True, False, flag4)
						Me.AddPTInfo(True)
					Case 11
						Dim flag4 As Boolean
						Dim flag3 As Boolean = Me.MdiFormExists("Results", False, True, False, flag4)
						Me.AddRSInput(True, False)
					Case 12
						If RSWIN_DESC.bRodStarD Then
							Dim flag4 As Boolean
							Dim flag3 As Boolean = Me.MdiFormExists("Results", False, True, False, flag4)
							If RSWIN_DESC.bRodStarD Then
								Me.AddDeviationProfile(True)
							End If
						End If
					Case 13
						Dim flag4 As Boolean
						Dim flag3 As Boolean = Me.MdiFormExists("Results", False, True, False, flag4)
						Me.AddPUData(True)
					Case 14
						Dim flag4 As Boolean
						Dim flag3 As Boolean = Me.MdiFormExists("Results", False, True, False, flag4)
						Me.AddMotorData(True)
					Case 15
						Me.DisplayPrevious()
					Case 16
						Me.DisplayNext()
				End Select
			Catch ex3 As Exception
			End Try
		End Sub

		Private Sub LoadDataInProgress(iForm As Integer, bShow As Boolean)
			Try
				Select Case iForm
					Case 8
						ini.ReadWellInfo()
						Dim flag2 As Boolean
						Dim flag As Boolean = Me.MdiFormExists("Results", False, True, False, flag2)
						Me.AddWellInfo(bShow)
					Case 9
						ini.ReadProdInfo()
						Dim flag2 As Boolean
						Dim flag As Boolean = Me.MdiFormExists("Results", False, True, False, flag2)
						Me.AddProdInfo(bShow)
					Case 10
						ini.ReadPTInfo()
						Dim flag2 As Boolean
						Dim flag As Boolean = Me.MdiFormExists("Results", False, True, False, flag2)
						Me.AddPTInfo(bShow)
					Case 11
						ini.ReadRSInput()
						Dim flag2 As Boolean
						Dim flag As Boolean = Me.MdiFormExists("Results", False, True, False, flag2)
						Me.AddRSInput(bShow, False)
					Case 12
						If RSWIN_DESC.bRodStarD Then
							ini.ReadDeviationProfile(True)
							Dim flag2 As Boolean
							Dim flag As Boolean = Me.MdiFormExists("Results", False, True, False, flag2)
							If RSWIN_DESC.bRodStarD Then
								Me.AddDeviationProfile(bShow)
							End If
						End If
					Case 13
						Dim rst As cRODSTAR = RSWIN_DESC.rst
						Dim pu As RSWIN_DESC.PUDataRec = rst.PU
						ini.ReadPUData1(pu)
						rst.PU = pu
						Dim flag2 As Boolean
						Dim flag As Boolean = Me.MdiFormExists("Results", False, True, False, flag2)
						Me.AddPUData(bShow)
					Case 14
						ini.ReadMotorInfoData()
						Dim flag2 As Boolean
						Dim flag As Boolean = Me.MdiFormExists("Results", False, True, False, flag2)
						Me.AddMotorData(bShow)
				End Select
			Catch ex As Exception
			End Try
		End Sub

		Private Function ValidateDeviationProfile(ByRef sProblemControlName As String, Optional bQuiet As Boolean = False, Optional bOverride As Boolean = False) As Boolean
			Return True
		End Function

		Private Function ValidateRSInput(ByRef sProblemControlName As String, Optional bQuiet As Boolean = False, Optional bOverride As Boolean = False) As Boolean
			Dim num As Single = 0F
			Dim flag As Boolean = True
			Dim rsinput As RSInput = New RSInput()
			Dim result As Boolean
			Try
				Me.ResetClock()
				Dim str As String = "enter"
				RSWIN_DESC.sNull = ""
				Dim text As String = RSWIN_DESC.sNull
				sProblemControlName = ""
				Dim formName As String = "RSInput"
				Dim form As Form = rsinput
				Me.ReturnMdiForm(formName, form)
				rsinput = CType(form, RSInput)
				Dim flag2 As Boolean = rsinput.ValidateRSInput(rsinput.bFormLoaded, True, True)
				If Not Me.m_bClosing And rsinput IsNot Nothing Then
					If Not rsinput.bValidated Or Not flag2 Then
						Dim rst As cRODSTAR = RSWIN_DESC.rst
						If rst.ServiceFactor = 0F Then
							If Not bQuiet Then
								rsinput.DisplayRSInputError("Please enter a value for service factor", Me.bCancel)
							End If
							If Not Me.bCancel Then
								sProblemControlName = "txtServiceFactor"
								flag = False
							End If
						Else
							Dim rst2 As cRODSTAR = RSWIN_DESC.rst
							Dim obj As Object = rst2.ServiceFactor
							Dim lowerBound As Single = 0.5F
							Dim inclusive As Integer = -1
							Dim errnum As Integer = 61
							Dim useMetric As Integer = -1
							Dim canadianIsMetric As Integer = -1
							Dim text2 As String = ""
							Dim obj2 As Object = Util.CheckLower(obj, lowerBound, inclusive, errnum, useMetric, canadianIsMetric, bQuiet, text2)
							rst2.ServiceFactor = Conversions.ToSingle(obj)
							If Conversions.ToBoolean(Operators.NotObject(obj2)) Then
								sProblemControlName = "txtServiceFactor"
								flag = False
							Else
								rst2 = RSWIN_DESC.rst
								obj = rst2.ServiceFactor
								Dim upperBound As Single = 1F
								Dim inclusive2 As Integer = -1
								Dim errnum2 As Integer = 61
								Dim useMetric2 As Integer = -1
								Dim canadianIsMetric2 As Integer = -1
								text2 = ""
								Dim obj3 As Object = Util.CheckUpper(obj, upperBound, inclusive2, errnum2, useMetric2, canadianIsMetric2, bQuiet, text2)
								rst2.ServiceFactor = Conversions.ToSingle(obj)
								If Conversions.ToBoolean(Operators.NotObject(obj3)) Then
									sProblemControlName = "txtServiceFactor"
									flag = False
								ElseIf RSWIN_DESC.rst.RodStringType = 2S Then
									Dim num2 As Short = 1S
									Dim numRods As Short = rst.NumRods
									For num3 As Short = num2 To numRods
										Dim str2 As String = " for section #" + num3.ToString()
										If Information.IsDBNull(rst.Sections(CInt(num3)).Grade) Or rst.Sections(CInt(num3)).Grade <= 0S Then
											str = "select"
											text = "rod grade or manufacturer" + str2
											flag = False
											Exit For
										End If
										If Information.IsDBNull(rst.Sections(CInt(num3)).Diameter) Or rst.Sections(CInt(num3)).Diameter <= 0F Then
											str = "select"
											text = "sucker rod diameter" + str2
											flag = False
											Exit For
										End If
										If Information.IsDBNull(rst.Sections(CInt(num3)).length) Or rst.Sections(CInt(num3)).length <= 0F Then
											text = "sucker rod length" + str2
											flag = False
											Exit For
										End If
										num += rst.Sections(CInt(num3)).length
									Next
									If Not flag And Operators.CompareString(text, "", False) <> 0 And Not bQuiet Then
										rsinput.DisplayRSInputError("Please " + str + " value for " + text, Me.bCancel)
									End If
									If(Not bQuiet AndAlso flag) And num < RSWIN_DESC.rst.PumpDepth - 50F Then
										flag = False
										If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
											rsinput.DisplayRSInputError(rsinput.sTotalDepth_ft + rsinput.sPleaseCheckInput, Me.bCancel)
										Else
											rsinput.DisplayRSInputError(rsinput.sTotalDepth_m + rsinput.sPleaseCheckInput, Me.bCancel)
										End If
										sProblemControlName = "ulgTapers"
										If Not Me.bCancel Then
											flag = False
										End If
									ElseIf(Not bQuiet AndAlso flag) And num > RSWIN_DESC.rst.PumpDepth + 2F Then
										flag = False
										Dim sMsg As String = " " + rsinput.sTotalDepth
										rsinput.DisplayRSInputError(sMsg, Me.bCancel)
										sProblemControlName = "ulgTapers"
										If Not Me.bCancel Then
											flag = False
										End If
									End If
								End If
							End If
						End If
						If RSWIN_DESC.rst.RodStringType = 2S Then
							Dim num4 As Short = 1S
							Dim numRods2 As Short = rst.NumRods
							Dim num3 As Short = num4
							While num3 <= numRods2
								If rst.Sections(CInt(num3)).Grade = 16393S Then
									rst.Sections(CInt(num3)).RodDensity = 125F
								ElseIf RODUTIL.IsFG(rst.Sections(CInt(num3)).Grade) Then
									rst.Sections(CInt(num3)).RodDensity = 130F
								ElseIf rst.Sections(CInt(num3)).Grade = 20481S Then
									rst.Sections(CInt(num3)).RodDensity = 100F
								Else
									rst.Sections(CInt(num3)).RodDensity = 491F
								End If
								Dim flag3 As Boolean = True
								If flag3 = (rst.Sections(CInt(num3)).Grade = 16385S) Then
									GoTo IL_545
								End If
								If flag3 = (rst.Sections(CInt(num3)).Grade = 16389S) Then
									GoTo IL_545
								End If
								If flag3 = (rst.Sections(CInt(num3)).Grade = 16390S) Then
									GoTo IL_545
								End If
								If flag3 = RODUTIL.IsCorod(rst.Sections(CInt(num3)).Grade) Then
									rst.Sections(CInt(num3)).SuckerRodLength = 1F
								Else
									rst.Sections(CInt(num3)).SuckerRodLength = 25F
								End If
								IL_5AD:
								RODUTIL.LookupElasticity(rst.Sections(CInt(num3)))
								RODUTIL.LookupRodWeight(rst.Sections(CInt(num3)))
								RODUTIL.LookupTensileStrength(rst.Sections(CInt(num3)))
								If flag Then
									Dim quiet As Object = bQuiet
									Dim grade As Object = rst.Sections(CInt(num3)).Grade
									Dim diameter As Object = rst.Sections(CInt(num3)).Diameter
									Dim flag4 As Boolean
									Dim obj As Object = flag4
									Dim flag5 As Boolean
									Dim obj4 As Object = flag5
									Dim obj5 As Object = ""
									Dim flag6 As Boolean
									Dim obj6 As Object = flag6
									Dim flag7 As Boolean = RODUTIL.CheckRodsInTubing(quiet, grade, diameter, obj, obj4, obj5, obj6, num3)
									flag6 = Conversions.ToBoolean(obj6)
									flag5 = Conversions.ToBoolean(obj4)
									flag4 = Conversions.ToBoolean(obj)
									flag = flag7
									If Not flag Then
										If flag5 Then
										End If
										sProblemControlName = "ulgTapers"
									End If
								End If
								If RSWIN_DESC.bRodStarD Then
									Dim sections As RSWIN_DESC.RodSection() = rst.Sections
									Dim num5 As Integer = CInt(num3)
									If Versioned.IsNumeric(sections(num5).friction_coef) Then
										Dim num6 As Single
										If Util.IsPolyLined(RSWIN_DESC.rst.TubingID) And RSWIN_DESC.bReduceFricCoeff Then
											num6 = 0.1F
											rsinput.sRecommendedFricCoefYesNo_LessThan = rsinput.sRecommendedFricCoefYesNo_LessThan.Replace("0.2", num6.ToString())
										Else
											num6 = 0.2F
										End If
										If sections(num5).friction_coef < num6 And Not rsinput.bRecommendedFricCoefYesNoShown Then
											Dim sRecommendedFricCoefYesNo_LessThan As String = rsinput.sRecommendedFricCoefYesNo_LessThan
											Dim bDefaultYes As Boolean = False
											Dim flag8 As Boolean = False
											Dim flag9 As Boolean = Util.YesNo(sRecommendedFricCoefYesNo_LessThan, bDefaultYes, flag8)
											rsinput.bRecommendedFricCoefYesNoShown = True
											If flag9 Then
												rsinput.ChangeSectionFricCoef(num6)
												sections(num5).friction_coef = num6
												flag = False
											End If
										End If
									End If
								End If
								num3 += 1S
								Continue While
								IL_545:
								rst.Sections(CInt(num3)).SuckerRodLength = 37.5F
								GoTo IL_5AD
							End While
							If Not flag Then
								Return flag
							End If
							num = 0F
							Dim num7 As Short = 1S
							Dim numRods3 As Short = rst.NumRods
							num3 = num7
							While num3 <= numRods3
								num += rst.Sections(CInt(num3)).length
								num3 += 1S
							End While
							If RODUTIL.IsFG(rst.Sections(CInt(rst.NumRods)).Grade) Then
								If Not bQuiet Then
									rsinput.DisplayRSInputError(Conversions.ToString(101), Me.bCancel)
								End If
								flag = False
							End If
							Dim num8 As Short = 2S
							Dim numRods4 As Short = rst.NumRods
							num3 = num8
							While num3 <= numRods4
								If(RODUTIL.IsSinkerBar(CInt(num3)) And RODUTIL.IsSteel(CInt(rst.Sections(CInt(num3)).Grade))) <> 0 Then
									Select Case rst.Sections(CInt(num3)).Grade
										Case 8193S, 8194S, 8195S, 8196S, 8197S, 8198S, 8199S, 8200S, 8301S, 8302S, 8303S, 8304S, 8305S, 8306S, 8307S, 8308S, 8309S, 8310S
											GoTo IL_A3C
									End Select
									If Not bQuiet Then
										rsinput.DisplayRSInputError(Conversions.ToString(62), Me.bCancel)
									End If
									flag = False
									Exit While
								End If
								IL_A3C:
								num3 += 1S
							End While
						ElseIf rst.RodStringType = 3S Then
							If rst.giRodDesignStyle = 1S Then
								If rst.RSFGIncludeSteel <> 0S Then
									If rst.RSGrade <= 0S Then
										sProblemControlName = "cboRSGrade"
										flag = False
									ElseIf rst.RSMaxSize <= 0F Then
										sProblemControlName = "cboRSMaxSize"
										flag = False
									ElseIf rst.RSMinSize <= 0F Then
										sProblemControlName = "cboRSMinSize"
										flag = False
									End If
								End If
								If rst.RSIncludeSB <> 0S Then
									If rst.RSSBGrade <= 0S Then
										sProblemControlName = "cboRSSBGrade"
										flag = False
									ElseIf rst.RSSBLength <= 0F And (Not RSWIN_DESC.bExpert Or (RSWIN_DESC.bExpert And Not RSWIN_DESC.bDesignSinkerbar)) Then
										sProblemControlName = "txtRSSBLength"
										flag = False
									End If
								End If
							ElseIf rst.giRodDesignStyle = 0S Then
								If rst.RSGrade <= 0S Then
									sProblemControlName = "cboRSGrade"
									flag = False
								ElseIf rst.RSMaxSize <= 0F Then
									sProblemControlName = "cboRSMaxSize"
									flag = False
								ElseIf rst.RSMinSize <= 0F Then
									sProblemControlName = "cboRSMinSize"
									flag = False
								End If
								If rst.RSIncludeSB <> 0S Then
									If rst.RSSBGrade <= 0S Then
										sProblemControlName = "cboRSSBGrade"
										flag = False
									ElseIf rst.RSSBLength <= 0F And (Not RSWIN_DESC.bExpert Or (RSWIN_DESC.bExpert And Not RSWIN_DESC.bDesignSinkerbar)) Then
										sProblemControlName = "txtRSSBLength"
										flag = False
									End If
								End If
							End If
						End If
						If Not flag And Operators.CompareString(sProblemControlName, "", False) = 0 Then
							sProblemControlName = "ulgTapers"
						End If
						If(RSWIN_DESC.NewData(4) And If((-If((flag > False), 1S, 0S)), 1S, 0S)) <> 0S Then
							RSWIN_DESC.NewData(4) = 0S
							ini.SaveDataValue("RSInput", True)
						End If
						If Not Me.bCancel And Not bQuiet And Not flag Then
							rsinput.bValidated = False
						Else
							rsinput.bValidated = True
						End If
						result = flag
					Else
						flag = True
						Dim rst3 As cRODSTAR = RSWIN_DESC.rst
						If RSWIN_DESC.rst.RodStringType = 2S Then
							Dim flag10 As Boolean = False
							num = 0F
							Dim num9 As Short = 1S
							Dim numRods5 As Short = rst3.NumRods
							For num3 As Short = num9 To numRods5
								num += rst3.Sections(CInt(num3)).length
								If flag Then
									Dim quiet2 As Object = rsinput.bCheckRodsInTubingMsgShown
									Dim grade2 As Object = RSWIN_DESC.rst.Sections(CInt(num3)).Grade
									Dim diameter2 As Object = RSWIN_DESC.rst.Sections(CInt(num3)).Diameter
									Dim flag4 As Boolean
									Dim obj6 As Object = flag4
									Dim flag5 As Boolean
									Dim obj5 As Object = flag5
									Dim obj4 As Object = Nothing
									Dim flag6 As Boolean
									Dim obj As Object = flag6
									Dim flag11 As Boolean = RODUTIL.CheckRodsInTubing(quiet2, grade2, diameter2, obj6, obj5, obj4, obj, num3)
									flag6 = Conversions.ToBoolean(obj)
									flag5 = Conversions.ToBoolean(obj5)
									flag4 = Conversions.ToBoolean(obj6)
									flag = flag11
									If Not flag Then
										If flag5 Then
											flag10 = flag5
											flag = True
										Else
											rsinput.Set_Row_Diameter_Cell(CInt(num3))
										End If
										sProblemControlName = "ulgTapers"
									End If
								End If
								If Information.IsDBNull(rst3.Sections(CInt(num3)).length) Or rst3.Sections(CInt(num3)).length <= 0F Then
									Dim str2 As String = " for section #" + num3.ToString()
									text = "sucker rod length" + str2
									flag = False
									Exit For
								End If
							Next
							If flag10 Then
								flag = True
							End If
							If RODUTIL.IsFG(rst3.Sections(CInt(rst3.NumRods)).Grade) Then
								If Not bQuiet Then
									rsinput.DisplayRSInputError(Conversions.ToString(101), Me.bCancel)
								End If
								flag = False
							End If
							If Not flag And Operators.CompareString(text, "", False) <> 0 And Not bQuiet Then
								flag = False
								sProblemControlName = "ulgTapers"
								rsinput.DisplayRSInputError("Please " + str + " value for " + text, Me.bCancel)
							ElseIf(Not bQuiet And num < RSWIN_DESC.rst.PumpDepth - 50F) AndAlso flag Then
								flag = False
								If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
									rsinput.DisplayRSInputError(rsinput.sTotalDepth_ft + rsinput.sPleaseCheckInput, Me.bCancel)
								Else
									rsinput.DisplayRSInputError(rsinput.sTotalDepth_m + rsinput.sPleaseCheckInput, Me.bCancel)
								End If
								sProblemControlName = "ulgTapers"
								If Not Me.bCancel Then
									flag = False
								End If
							ElseIf(Not bQuiet And num > RSWIN_DESC.rst.PumpDepth + 2F) AndAlso flag Then
								flag = False
								Dim sMsg As String = " " + rsinput.sTotalDepth
								rsinput.DisplayRSInputError(sMsg, Me.bCancel)
								sProblemControlName = "ulgTapers"
								If Not Me.bCancel Then
									flag = False
								End If
							End If
						ElseIf flag AndAlso (rst3.RSGrade > 0S And rst3.RSMaxSize > 0F) Then
							Dim quiet3 As Object = rsinput.bCheckRodsInTubingMsgShown
							Dim grade3 As Object = rst3.RSGrade
							Dim diameter3 As Object = rst3.RSMaxSize
							Dim flag4 As Boolean
							Dim obj6 As Object = flag4
							Dim flag5 As Boolean
							Dim obj5 As Object = flag5
							Dim obj4 As Object = Nothing
							Dim flag6 As Boolean
							Dim obj As Object = flag6
							Dim flag12 As Boolean = RODUTIL.CheckRodsInTubing(quiet3, grade3, diameter3, obj6, obj5, obj4, obj, 0)
							flag6 = Conversions.ToBoolean(obj)
							flag5 = Conversions.ToBoolean(obj5)
							flag4 = Conversions.ToBoolean(obj6)
							flag = flag12
							If flag5 AndAlso flag6 Then
								rsinput.bCheckRodsInTubingMsgShown = True
							End If
							If Not flag And Not flag5 Then
								sProblemControlName = "cboRSMaxSize"
							ElseIf flag5 Then
								flag = True
							End If
							If(If((-If((Not flag6 > False), 1S, 0S)), 1S, 0S) And rst3.RSIncludeSB And If((-If((rst3.SinkerBar.Grade > 0S > False), 1S, 0S)), 1S, 0S) And If((-If((rst3.SinkerBar.Diameter > 0F > False), 1S, 0S)), 1S, 0S)) <> 0S Then
								Dim quiet4 As Object = True
								Dim grade4 As Object = rst3.SinkerBar.Grade
								Dim diameter4 As Object = rst3.SinkerBar.Diameter
								obj6 = flag4
								obj5 = flag5
								obj4 = Nothing
								obj = flag6
								Dim flag13 As Boolean = RODUTIL.CheckRodsInTubing(quiet4, grade4, diameter4, obj6, obj5, obj4, obj, 0)
								flag6 = Conversions.ToBoolean(obj)
								flag5 = Conversions.ToBoolean(obj5)
								flag4 = Conversions.ToBoolean(obj6)
								flag = flag13
								rsinput.bCheckRodsInTubingMsgShown = flag6
								If Not flag And Not flag5 Then
									sProblemControlName = "cboRSSBDiameter"
								ElseIf flag5 Then
									flag = True
								End If
							End If
						End If
						If flag Then
							result = True
						Else
							result = False
						End If
					End If
				Else
					result = True
				End If
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Function ValidateWellInfo(ByRef sProblemControlName As String, Optional bQuiet As Boolean = False, Optional bOverride As Boolean = False) As Boolean
			Dim text As String = New String(" "c, 40)
			Dim flag As Boolean = True
			Dim wellInfo As WellInfo = New WellInfo()
			Dim num As Integer = 50
			Me.ResetClock()
			If RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru Then
				num = 75
			End If
			Dim formName As String = "WellInfo"
			Dim form As Form = wellInfo
			Me.ReturnMdiForm(formName, form)
			wellInfo = CType(form, WellInfo)
			If Not(Not Me.m_bClosing And wellInfo IsNot Nothing) Then
				Return True
			End If
			If Not wellInfo.bValidated Then
				If Not bQuiet Then
					wellInfo.bQuietLeaveMsg = False
				End If
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				If Operators.CompareString(rst.WellName, "", False) = 0 Or Operators.CompareString(rst.WellName, text, False) = 0 Then
					If Not bQuiet Then
						wellInfo.DisplayWellInfoError("Please enter a value for Well Name", Me.bCancel)
					End If
					If Not Me.bCancel Then
						sProblemControlName = "txtWellName"
						flag = False
					End If
				ElseIf rst.PumpDepth = 0F Then
					If Not bQuiet Then
						wellInfo.DisplayWellInfoError("Please enter a value for Pump Depth", Me.bCancel)
					End If
					If Not Me.bCancel Then
						sProblemControlName = "txtPumpDepth"
						flag = False
					End If
				Else
					Dim cRODSTAR As cRODSTAR = rst
					Dim obj As Object = cRODSTAR.PumpDepth
					Dim sMsg As String
					Dim checkLowerMsg As Object = Util.GetCheckLowerMsg(obj, 100F, -1, 41, -1, 0, sMsg)
					cRODSTAR.PumpDepth = Conversions.ToSingle(obj)
					If Conversions.ToBoolean(checkLowerMsg) Then
						sProblemControlName = "txtPumpDepth"
						flag = False
					Else
						cRODSTAR = rst
						obj = cRODSTAR.PumpDepth
						Dim checkUpperMsg As Object = Util.GetCheckUpperMsg(obj, 20000F, -1, 41, -1, 0, sMsg)
						cRODSTAR.PumpDepth = Conversions.ToSingle(obj)
						If Conversions.ToBoolean(checkUpperMsg) Then
							sProblemControlName = "txtPumpDepth"
							flag = False
						ElseIf rst.Runtime = 0F Then
							If Not bQuiet Then
								wellInfo.DisplayWellInfoError("Please enter a value for Run Time", Me.bCancel)
							End If
							If Not Me.bCancel Then
								sProblemControlName = "txtRuntime"
								flag = False
							End If
						ElseIf rst.OilAPI = 0F Then
							If Not bQuiet Then
								wellInfo.DisplayWellInfoError("Please enter a value for Oil gravity (API °) ", Me.bCancel)
							End If
							If Not Me.bCancel Then
								sProblemControlName = "txtOilAPI"
								flag = False
							End If
						Else
							cRODSTAR = rst
							obj = cRODSTAR.StuffingBoxFriction
							Dim checkUpperMsg2 As Object = Util.GetCheckUpperMsg(obj, 2000F, -1, 75, -1, 0, sMsg)
							cRODSTAR.StuffingBoxFriction = Conversions.ToSingle(obj)
							If Conversions.ToBoolean(checkUpperMsg2) Then
								sProblemControlName = "txtStuffingBoxFriction"
								flag = False
							Else
								cRODSTAR = rst
								obj = cRODSTAR.OilAPI
								Dim checkLowerMsg2 As Object = Util.GetCheckLowerMsg(obj, 5F, -1, 35, -1, 0, sMsg)
								cRODSTAR.OilAPI = Conversions.ToSingle(obj)
								If Conversions.ToBoolean(checkLowerMsg2) Then
									If Not bQuiet Then
										wellInfo.DisplayWellInfoError(sMsg, Me.bCancel)
									End If
									If Not Me.bCancel Then
										sProblemControlName = "txtOilAPI"
										flag = False
									End If
								Else
									cRODSTAR = rst
									obj = cRODSTAR.OilAPI
									Dim checkUpperMsg3 As Object = Util.GetCheckUpperMsg(obj, 70F, -1, 35, -1, 0, sMsg)
									cRODSTAR.OilAPI = Conversions.ToSingle(obj)
									If Conversions.ToBoolean(checkUpperMsg3) Then
										If Not bQuiet Then
											wellInfo.DisplayWellInfoError(sMsg, Me.bCancel)
										End If
										If Not Me.bCancel Then
											sProblemControlName = "txtOilAPI"
											flag = False
										End If
									ElseIf rst.WaterSPGR = 0F Then
										If Not bQuiet Then
											wellInfo.DisplayWellInfoError("Please enter a value for Water SPGR", Me.bCancel)
										End If
										If Not Me.bCancel Then
											sProblemControlName = "txtWaterSPGR"
											flag = False
										End If
									ElseIf rst.WaterSPGR < 1F Or CDbl(rst.WaterSPGR) > 1.5 Then
										If Not Me.bCancel Then
											sProblemControlName = "txtWaterSPGR"
											flag = False
										End If
									ElseIf rst.FluidSPGR = 0F And Not rst.gbCalcFluidSPGR Then
										If Not bQuiet Then
											wellInfo.DisplayWellInfoError("Please enter a value for Fliud SPGR", Me.bCancel)
										End If
										If Not Me.bCancel Then
											sProblemControlName = "txtFluidSPGR"
											flag = False
										End If
									Else
										Dim obj2 As Object = rst.PumpCondition = 1S Or rst.PumpCondition = If((-If((RSWIN_DESC.rst.gbCalcPumpCondition > False), 1S, 0S)), 1S, 0S)
										cRODSTAR = RSWIN_DESC.rst
										obj = cRODSTAR.PumpEfficiency
										Dim lowerBound As Single = CSng(num)
										Dim inclusive As Integer = -1
										Dim errnum As Integer = 43
										Dim useMetric As Integer = 0
										Dim canadianIsMetric As Integer = 0
										Dim bQuiet2 As Boolean = True
										Dim text2 As String = ""
										Dim obj3 As Object = Util.CheckLower(obj, lowerBound, inclusive, errnum, useMetric, canadianIsMetric, bQuiet2, text2)
										cRODSTAR.PumpEfficiency = Conversions.ToSingle(obj)
										Dim obj4 As Object = Operators.NotObject(obj3)
										Dim cRODSTAR2 As cRODSTAR = RSWIN_DESC.rst
										Dim obj5 As Object = cRODSTAR2.PumpEfficiency
										Dim upperBound As Single = 100F
										Dim inclusive2 As Integer = -1
										Dim errnum2 As Integer = 43
										Dim useMetric2 As Integer = 0
										Dim canadianIsMetric2 As Integer = 0
										Dim bQuiet3 As Boolean = True
										Dim text3 As String = ""
										Dim obj6 As Object = Util.CheckUpper(obj5, upperBound, inclusive2, errnum2, useMetric2, canadianIsMetric2, bQuiet3, text3)
										cRODSTAR2.PumpEfficiency = Conversions.ToSingle(obj5)
										If Conversions.ToBoolean(Operators.AndObject(obj2, Operators.OrObject(obj4, Operators.NotObject(obj6)))) Then
											If Not bQuiet Then
												wellInfo.DisplayWellInfoError("The Pump Efficiency must be between " + num.ToString().Trim() + "% and 100%", Me.bCancel)
											End If
											If Not Me.bCancel Then
												sProblemControlName = "txtPumpEfficiency"
												flag = False
												wellInfo.bQuietLeaveMsg = True
											End If
										Else
											Dim obj7 As Object = rst.PumpCondition = 2S Or rst.PumpCondition = 3S
											cRODSTAR2 = RSWIN_DESC.rst
											obj5 = cRODSTAR2.PumpFillage
											Dim lowerBound2 As Single = 10F
											Dim inclusive3 As Integer = -1
											Dim errnum3 As Integer = 44
											Dim useMetric3 As Integer = 0
											Dim canadianIsMetric3 As Integer = 0
											Dim bQuiet4 As Boolean = True
											text3 = ""
											Dim obj8 As Object = Util.CheckLower(obj5, lowerBound2, inclusive3, errnum3, useMetric3, canadianIsMetric3, bQuiet4, text3)
											cRODSTAR2.PumpFillage = Conversions.ToSingle(obj5)
											Dim obj9 As Object = Operators.NotObject(obj8)
											cRODSTAR = RSWIN_DESC.rst
											obj = cRODSTAR.PumpFillage
											Dim upperBound2 As Single = 95F
											Dim inclusive4 As Integer = -1
											Dim errnum4 As Integer = 44
											Dim useMetric4 As Integer = 0
											Dim canadianIsMetric4 As Integer = 0
											Dim bQuiet5 As Boolean = True
											text2 = ""
											Dim obj10 As Object = Util.CheckUpper(obj, upperBound2, inclusive4, errnum4, useMetric4, canadianIsMetric4, bQuiet5, text2)
											cRODSTAR.PumpFillage = Conversions.ToSingle(obj)
											If Conversions.ToBoolean(Operators.AndObject(obj7, Operators.OrObject(obj9, Operators.NotObject(obj10)))) Then
												If Not bQuiet Then
													wellInfo.DisplayWellInfoError("The Pump Fillage must between 10% and 95%", Me.bCancel)
												End If
												If Not Me.bCancel Then
													sProblemControlName = "txtPumpEfficiency"
													flag = False
													wellInfo.bQuietLeaveMsg = True
												End If
											ElseIf rst.PR_Diameter < 1F Or rst.PR_Diameter > 2F Then
												If rst.PR_Diameter < 1F Then
													wellInfo.DisplayWellInfoError(Conversions.ToString(Operators.ConcatenateObject("The polished rod diameter cannot be less than 1" + RSWIN_DESC.sDblQuote, Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem = 1, " ", "  (25.4 mm)"))), Me.bCancel)
												ElseIf rst.PR_Diameter > 2F Then
													wellInfo.DisplayWellInfoError(Conversions.ToString(Operators.ConcatenateObject("The polished rod diameter cannot be greater than 2" + RSWIN_DESC.sDblQuote, Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem = 1, " ", "  (50.8 mm)"))), Me.bCancel)
												End If
												sProblemControlName = "txtPRDiameter"
												flag = False
											Else
												cRODSTAR2 = rst
												obj5 = cRODSTAR2.CasingPressure
												Dim checkLowerMsg3 As Object = Util.GetCheckLowerMsg(obj5, -50F, -1, 91, -1, 0, sMsg)
												cRODSTAR2.CasingPressure = Conversions.ToSingle(obj5)
												If Conversions.ToBoolean(checkLowerMsg3) Then
													If Not Me.bCancel Then
														sProblemControlName = "txtCasingPressure"
														flag = False
													End If
												Else
													cRODSTAR2 = rst
													obj5 = cRODSTAR2.CasingPressure
													Dim checkUpperMsg4 As Object = Util.GetCheckUpperMsg(obj5, 1000F, -1, 89, -1, 0, sMsg)
													cRODSTAR2.CasingPressure = Conversions.ToSingle(obj5)
													If Conversions.ToBoolean(checkUpperMsg4) Then
														If Not Me.bCancel Then
															sProblemControlName = "txtCasingPressure"
															flag = False
														End If
													Else
														cRODSTAR2 = rst
														obj5 = cRODSTAR2.TubingPressure
														Dim checkLowerMsg4 As Object = Util.GetCheckLowerMsg(obj5, 0F, -1, 153, -1, 0, sMsg)
														cRODSTAR2.TubingPressure = Conversions.ToSingle(obj5)
														If Conversions.ToBoolean(checkLowerMsg4) Then
															If Not Me.bCancel Then
																sProblemControlName = "txtTubingPressure"
																flag = False
															End If
														Else
															cRODSTAR2 = rst
															obj5 = cRODSTAR2.TubingPressure
															Dim checkUpperMsg5 As Object = Util.GetCheckUpperMsg(obj5, 1000F, -1, 151, -1, 0, sMsg)
															cRODSTAR2.TubingPressure = Conversions.ToSingle(obj5)
															If Conversions.ToBoolean(checkUpperMsg5) Then
																If Not Me.bCancel Then
																	sProblemControlName = "txtTubingPressure"
																	flag = False
																End If
															ElseIf rst.gbCalcFluidSPGR Then
																rst.gfMaxFluidSPGR = LoadXDG.MaxFluidSPGR(rst.WaterCut, rst.WaterSPGR, rst.OilSPGR)
																rst.FluidSPGR = rst.gfMaxFluidSPGR
															End If
														End If
													End If
												End If
											End If
										End If
									End If
								End If
							End If
						End If
					End If
				End If
				If(RSWIN_DESC.NewData(1) And If((-If((flag > False), 1S, 0S)), 1S, 0S)) <> 0S Then
					RSWIN_DESC.NewData(1) = 0S
					ini.SaveDataValue("WellInfo", True)
				End If
				If Not Me.bCancel And Not bQuiet And Not flag Then
					wellInfo.bValidated = False
				Else
					wellInfo.bValidated = True
				End If
				Return flag
			End If
			Return True
		End Function

		Public Function ValidatePUData(ByRef sProblemControlName As String, Optional bQuiet As Boolean = False, Optional bOverride As Boolean = False) As Boolean
			Dim pudata As PUData = New PUData()
			Try
				Me.ResetClock()
				If RSWIN_DESC.rst.PU.UnitType = 8S Or (RSWIN_DESC.rst.PU.UnitType = 11S And Not RSWIN_DESC.rst.bUseCrankBalancedCalcs) Then
					RSWIN_DESC.bBeamBalanced = True
				Else
					RSWIN_DESC.bBeamBalanced = False
				End If
			Catch ex As Exception
			End Try
			Dim formName As String = "PUData"
			Dim form As Form = pudata
			Me.ReturnMdiForm(formName, form)
			pudata = CType(form, PUData)
			If Not(Not Me.m_bClosing And pudata IsNot Nothing) Then
				Return True
			End If
			If Not pudata.bValidated Then
				Dim flag As Boolean = True
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				If Not rst.IDEntered <> 0S Then
					If Not bQuiet Then
						pudata.DisplayPUDataError("Please enter a value for pumping unit manufacturer.", Me.bCancel)
					End If
					If Not Me.bCancel Then
						sProblemControlName = "cboManufMenu"
						flag = False
					End If
				ElseIf Strings.Trim(rst.UnitID).Length = 0 Then
					If Not bQuiet Then
						pudata.DisplayPUDataError("Please enter a value for pumping unit.", Me.bCancel)
					End If
					If Not Me.bCancel Then
						sProblemControlName = "lvwUnitList"
						flag = False
					End If
				ElseIf Not(RSWIN_DESC.rst.PU.UnitType = 8S Or RSWIN_DESC.bBeamBalanced) And (Not rst.UnknownM And RSWIN_DESC.rst.get_M(2) = 0F And rst.CBDataType <> 2S) Then
					Dim str As String
					If rst.PU.UnitType = 7S Or rst.PU.UnitType = 10S Then
						str = "existing maximum counterbalance weight"
					ElseIf rst.PU.UnitType = 6S Then
						str = "existing air tank pressure at bottom of stroke"
					Else
						str = "existing maximum counterbalance moment"
					End If
					If Not bQuiet Then
						pudata.DisplayPUDataError("Please enter a value for " + str + ".", Me.bCancel)
					End If
					If Not Me.bCancel Then
						sProblemControlName = "txtCounterbalance"
						flag = False
					End If
				ElseIf rst.PU.CrankHole = 0S Then
					If RSWIN_DESC.rst.PU.UnitType = 7S Or RSWIN_DESC.rst.PU.UnitType = 10S Then
						Dim pu As RSWIN_DESC.PUDataRec
						pu.Initialize()
						pu = RSWIN_DESC.rst.PU
						pu.CrankHole = 1S
						pu.R = pu.CrankRadii(0)
						RSWIN_DESC.rst.PU = pu
					ElseIf Not bQuiet Then
						pudata.DisplayPUDataError("Please enter a value for crank hole.", Me.bCancel)
						If Not Me.bCancel Then
							sProblemControlName = "cboCrankHole"
							flag = False
						End If
					End If
				ElseIf rst.PU.CrankRotation <> 1S And rst.PU.CrankRotation <> -1S Then
					If Not bQuiet Then
						pudata.DisplayPUDataError("Please enter a value for direction of crank rotation.", Me.bCancel)
					End If
					If Not Me.bCancel Then
						sProblemControlName = "cboCrankRotation"
						flag = False
					End If
				End If
				If(RSWIN_DESC.NewData(6) And If((-If((flag > False), 1S, 0S)), 1S, 0S)) <> 0S Then
					RSWIN_DESC.NewData(6) = 0S
					ini.SaveDataValue("PUData", True)
				End If
				If Not Me.bCancel And Not bQuiet And Not flag Then
					pudata.bValidated = False
				Else
					pudata.bValidated = True
				End If
				Return flag
			End If
			Return True
		End Function

		Private Function ValidatePTInfo(ByRef sProblemControlName As String, Optional bQuiet As Boolean = False, Optional bOverride As Boolean = False) As Boolean
			Dim ptinfo As PTInfo = New PTInfo()
			Dim flag As Boolean = True
			Me.ResetClock()
			Dim formName As String = "PTInfo"
			Dim form As Form = ptinfo
			Me.ReturnMdiForm(formName, form)
			ptinfo = CType(form, PTInfo)
			If Not(Not Me.m_bClosing And ptinfo IsNot Nothing) Then
				Return True
			End If
			If Not ptinfo.bValidated Then
				RSWIN_DESC.sNull = ""
				Dim sNull As String = RSWIN_DESC.sNull
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				If ptinfo.chkIncludeFluidInertia.Enabled Then
					rst.IncludeFluidInertia = If((-If((ptinfo.chkIncludeFluidInertia.Checked > False), 1S, 0S)), 1S, 0S)
					If ptinfo.txtCompressibilityIndex.Enabled And Versioned.IsNumeric(ptinfo.txtCompressibilityIndex.Text) Then
						rst.CompressibilityIndex = Conversions.ToSingle(ptinfo.txtCompressibilityIndex.Text)
					End If
				End If
				If rst.TubingOD = 0F Then
					If Not bQuiet Then
						ptinfo.DisplayPTInfoError("Please select value for tubing O.D.", Me.bCancel)
					End If
					If Not Me.bCancel Then
						sProblemControlName = "cboTubingOD"
						flag = False
					End If
				ElseIf rst.TubingID = 0F Then
					If Not bQuiet Then
						ptinfo.DisplayPTInfoError("Please select value for tubing I.D.", Me.bCancel)
					End If
					If Not Me.bCancel Then
						sProblemControlName = "cboTubingID"
						flag = False
					End If
				ElseIf rst.PlungerSize = 0F Then
					If Not bQuiet Then
						ptinfo.DisplayPTInfoError("Please select value for plunger size.", Me.bCancel)
					End If
					If Not Me.bCancel Then
						sProblemControlName = "cboPlungerSize"
						flag = False
					End If
				ElseIf(If((-If(((rst.TubingAnchorDepth = 0F) > False), 1S, 0S)), 1S, 0S) And rst.TubingAnchored) <> 0S Then
					If Not bQuiet Then
						ptinfo.DisplayPTInfoError("Please select value for tubing anchor depth.", Me.bCancel)
					End If
					If Not Me.bCancel Then
						sProblemControlName = "txtTubingAnchorDepth"
						flag = False
					End If
				ElseIf(rst.IncludeFluidInertia And If((-If(((rst.CompressibilityIndex < 1F Or rst.CompressibilityIndex > 7F) > False), 1S, 0S)), 1S, 0S)) <> 0S Then
					If Not bQuiet Then
						ptinfo.DisplayPTInfoError("Please select correct value for Fluid Compressibility Index.", Me.bCancel)
					End If
					If Not Me.bCancel Then
						sProblemControlName = "txtCompressibilityIndex"
						flag = False
					End If
				End If
				If Not((rst.TubingOD = 2.375F And rst.TubingID = 1.71F) Or (rst.TubingOD = 2.875F And rst.TubingID = 2.16F) Or (rst.TubingOD = 3.5F And rst.TubingID = 2.67F)) Then
					Dim num As Single
					Dim num2 As Single
					If CDbl(rst.TubingOD) > 5.5 Then
						num = CSng((CDbl(rst.TubingOD) - 0.5))
						num2 = rst.TubingOD - 1F
					Else
						Dim num3 As Single = CSng((-0.4366663 + 1.580083 * CDbl(rst.TubingOD) - 0.4333377 * Math.Pow(CDbl(rst.TubingOD), 2.0) + 0.1045154 * Math.Pow(CDbl(rst.TubingOD), 3.0) - 0.00845177 * Math.Pow(CDbl(rst.TubingOD), 4.0)))
						num = CSng((Conversion.Int((CDbl(num3) + 0.15) * 100.0) / 100.0))
						num2 = CSng((Conversion.Int((CDbl(num3) - 0.15) * 100.0) / 100.0))
					End If
					If Not((rst.TubingOD = 2.375F And rst.TubingID = 1.71F) Or (rst.TubingOD = 2.875F And rst.TubingID = 2.16F) Or (rst.TubingOD = 3.5F And rst.TubingID = 2.67F)) AndAlso (rst.TubingID < num2 Or rst.TubingID > num) Then
						Dim sMsg As String
						If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
							Util.LoadMessage(33, sMsg)
						Else
							Util.LoadMessage(34, sMsg)
						End If
						Util.ApplyNumber(num2, sMsg)
						Util.ApplyNumber(num, sMsg)
						Util.ApplyNumber(num2 * RSWIN_DESC.IN__MM, sMsg)
						Util.ApplyNumber(num * RSWIN_DESC.IN__MM, sMsg)
						If Not bQuiet Then
							ptinfo.DisplayPTInfoError(sMsg, Me.bCancel)
							sProblemControlName = "txtTubingID"
							flag = False
						End If
					End If
				End If
				If RSWIN_DESC.bCheckPlunger Then
					RSWIN_DESC.bCheckPlunger = False
					If Not Me.CheckPlungerInTubing(False) <> 0S Then
						Dim result As Boolean
						Return result
					End If
				End If
				If(RSWIN_DESC.NewData(3) And If((-If((flag > False), 1S, 0S)), 1S, 0S)) <> 0S Then
					RSWIN_DESC.NewData(3) = 0S
					ini.SaveDataValue("PTInfo", True)
				End If
				If Not Me.bCancel And Not bQuiet And Not flag Then
					ptinfo.bValidated = False
				Else
					ptinfo.bValidated = True
				End If
				Return flag
			End If
			If(RSWIN_DESC.NewData(3) And If((-If((flag > False), 1S, 0S)), 1S, 0S)) <> 0S Then
				RSWIN_DESC.NewData(3) = 0S
				ini.SaveDataValue("PTInfo", True)
			End If
			Return True
		End Function

		Public Function CheckPlungerInTubing(Optional bQuiet As Boolean = False) As Short
			Dim text As String = ""
			If RSWIN_DESC.rst.CalcPlungerSize <> 0S Then
				Return -1S
			End If
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			Dim text2 As String
			Dim num As Single
			Dim flag As Boolean
			Select Case rst.PumpType
				Case 1S
					text2 = "an insert"
					Dim tubingOD As Single = rst.TubingOD
					If tubingOD = 1.9F Then
						num = 1.25F
					ElseIf tubingOD = 1.9F Then
						num = 1.25F
					ElseIf tubingOD = 2.375F Then
						If rst.TubingID = 1.71F Then
							flag = True
							num = 1.25F
						Else
							num = 1.5F
						End If
					ElseIf tubingOD = 2.875F Then
						If rst.TubingID = 2.16F Then
							flag = True
							num = 1.75F
						Else
							num = 2F
						End If
					ElseIf tubingOD = 3.5F Then
						If rst.TubingID = 2.67F Then
							flag = True
							num = 2F
						Else
							num = 2.75F
						End If
					ElseIf tubingOD = 4F Then
						num = 3F
					ElseIf tubingOD = 4.5F Then
						num = 3.25F
					ElseIf tubingOD = 5.5F Then
						num = 3.75F
					Else
						num = CSng((CDbl(rst.TubingID) - 0.25))
					End If
				Case 2S
					text2 = "a tubing"
					Dim tubingOD2 As Single = rst.TubingOD
					If tubingOD2 = 1.9F Then
						num = 1.25F
					ElseIf tubingOD2 = 1.9F Then
						num = 1.25F
					ElseIf tubingOD2 = 2.375F Then
						If rst.TubingID = 1.71F Then
							flag = True
							num = 1.5F
						Else
							num = 1.75F
						End If
					ElseIf tubingOD2 = 2.875F Then
						If rst.TubingID = 2.16F Then
							flag = True
							num = 2F
						Else
							num = 2.25F
						End If
					ElseIf tubingOD2 = 3.5F Then
						If rst.TubingID = 2.67F Then
							flag = True
							num = 2.5F
						Else
							num = 2.75F
						End If
					ElseIf tubingOD2 = 4F Then
						num = 3.25F
					ElseIf tubingOD2 = 4.5F Then
						num = 3.75F
					ElseIf tubingOD2 = 5.5F Then
						num = 4.75F
					Else
						num = CSng((CDbl(rst.TubingID) - 0.25))
					End If
				Case 3S
					num = 1E+38F
			End Select
			Dim result As Short
			If Operators.CompareString(RSWIN_DESC.SETUP_Language, RSWIN_DESC.sEnglish, False) = 0 Then
				Dim text6 As String
				If rst.PlungerSize > num Then
					If RSWIN_DESC.SETUP_MeasurementSystem <> 3 Then
						If flag Then
							Dim array As String() = New String(7) {}
							array(0) = Me.sMNEPlungerSize
							array(1) = " "
							Dim array2 As String() = array
							Dim num2 As Integer = 2
							Dim text3 As String = "0.0###"
							array2(num2) = Util.Format(num, text3)
							array(3) = " inches for "
							array(4) = text2
							array(5) = " pump to fit in "
							Dim array3 As String() = array
							Dim num3 As Integer = 6
							Dim cRODSTAR As cRODSTAR = rst
							Dim tubingOD3 As Single = cRODSTAR.TubingOD
							Dim text4 As String = "0.0###"
							Dim text5 As String = Util.Format(tubingOD3, text4)
							cRODSTAR.TubingOD = tubingOD3
							array3(num3) = text5
							array(7) = """ polylined tubing."
							text6 = String.Concat(array)
						Else
							Dim array As String() = New String(7) {}
							array(0) = Me.sMNEPlungerSize
							array(1) = " "
							Dim array4 As String() = array
							Dim num4 As Integer = 2
							Dim text4 As String = "0.0###"
							array4(num4) = Util.Format(num, text4)
							array(3) = " inches for "
							array(4) = text2
							array(5) = " pump to fit in "
							Dim array5 As String() = array
							Dim num5 As Integer = 6
							Dim cRODSTAR As cRODSTAR = rst
							Dim tubingOD3 As Single = cRODSTAR.TubingOD
							Dim text3 As String = "0.0###"
							Dim text7 As String = Util.Format(tubingOD3, text3)
							cRODSTAR.TubingOD = tubingOD3
							array5(num5) = text7
							array(7) = """ tubing."
							text6 = String.Concat(array)
						End If
					ElseIf flag Then
						Dim array As String() = New String(7) {}
						array(0) = Me.sMNEPlungerSize
						array(1) = " "
						Dim array6 As String() = array
						Dim num6 As Integer = 2
						Dim num7 As Single = CtrlUI.ConvertUnits(num, 5)
						Dim text4 As String = "0.0###"
						array6(num6) = Util.Format(num7, text4)
						array(3) = " mm for "
						array(4) = text2
						array(5) = " pump to fit in "
						Dim array7 As String() = array
						Dim num8 As Integer = 6
						Dim tubingOD3 As Single = CtrlUI.ConvertUnits(rst.TubingOD, 5)
						Dim text3 As String = "0.0###"
						array7(num8) = Util.Format(tubingOD3, text3)
						array(7) = " mm polylined tubing."
						text6 = String.Concat(array)
					Else
						Dim array As String() = New String(7) {}
						array(0) = Me.sMNEPlungerSize
						array(1) = " "
						Dim array8 As String() = array
						Dim num9 As Integer = 2
						Dim tubingOD3 As Single = CtrlUI.ConvertUnits(num, 5)
						Dim text4 As String = "0.0###"
						array8(num9) = Util.Format(tubingOD3, text4)
						array(3) = " mm for "
						array(4) = text2
						array(5) = " pump to fit in "
						Dim array9 As String() = array
						Dim num10 As Integer = 6
						Dim num7 As Single = CtrlUI.ConvertUnits(rst.TubingOD, 5)
						Dim text3 As String = "0.0###"
						array9(num10) = Util.Format(num7, text3)
						array(7) = " mm tubing."
						text6 = String.Concat(array)
					End If
				Else
					text6 = RSWIN_DESC.sNull
				End If
				If Strings.Len(text6) = 0 Then
					result = -1S
				ElseIf Not bQuiet Then
					Dim msg As String = text6 + "  " + Me.sDYWChangePlungerSize
					Dim bDefaultYes As Boolean = False
					Dim flag2 As Boolean = False
					result = If((-If((Not Util.YesNo(msg, bDefaultYes, flag2) > False), 1S, 0S)), 1S, 0S)
				Else
					result = 0S
				End If
			Else
				If rst.PumpType = 1S Then
					text = Me.sMNEPlungerSize1
				ElseIf rst.PumpType = 2S Then
					text = Me.sMNEPlungerSize2
				End If
				Dim text6 As String
				If rst.PlungerSize > num Then
					If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
						If Strings.InStr(Me.sMNEPlungerSize1, "1 inches", CompareMethod.Binary) > 0 Then
							Dim text8 As String = text
							Dim oldValue As String = "1 inches"
							Dim text3 As String = "0.0###"
							text = text8.Replace(oldValue, Util.Format(num, text3) + " inches")
							If Strings.InStr(Me.sMNEPlungerSize1, "to fit in 2", CompareMethod.Binary) > 0 Then
								Dim text9 As String = text
								Dim oldValue2 As String = "to fit in 2"
								Dim str As String = "to fit in "
								Dim num7 As Single = CtrlUI.ConvertUnits(rst.TubingOD, 5)
								text3 = "0.0###"
								text = text9.Replace(oldValue2, str + Util.Format(num7, text3))
							End If
						End If
						text6 = text
					Else
						If Strings.InStr(Me.sMNEPlungerSize1, "1 inches", CompareMethod.Binary) > 0 Then
							Dim text10 As String = text
							Dim oldValue3 As String = "1 inches"
							Dim num7 As Single = CtrlUI.ConvertUnits(num, 5)
							Dim text3 As String = "0.0###"
							text = text10.Replace(oldValue3, Util.Format(num7, text3) + " mm")
							If Strings.InStr(Me.sMNEPlungerSize1, "to fit in 2", CompareMethod.Binary) > 0 Then
								Dim text11 As String = text
								Dim oldValue4 As String = "to fit in 2"
								Dim str2 As String = "to fit in "
								num7 = CtrlUI.ConvertUnits(rst.TubingOD, 5)
								text3 = "0.0###"
								text = text11.Replace(oldValue4, str2 + Util.Format(num7, text3))
							End If
						End If
						text6 = text
					End If
				Else
					text6 = RSWIN_DESC.sNull
				End If
				If Strings.Len(text6) = 0 Then
					result = -1S
				ElseIf Not bQuiet Then
					Dim msg2 As String = text6 + "  " + Me.sDYWChangePlungerSize
					Dim bDefaultYes2 As Boolean = False
					Dim flag2 As Boolean = False
					result = If((-If((Not Util.YesNo(msg2, bDefaultYes2, flag2) > False), 1S, 0S)), 1S, 0S)
				Else
					result = 0S
				End If
			End If
			Return result
		End Function

		Public Function CheckPlungerInTubing_Old() As Short
			Dim text As String = ""
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			Dim text2 As String
			Dim num As Single
			Dim flag As Boolean
			Select Case rst.PumpType
				Case 1S
					text2 = "an insert"
					Dim tubingOD As Single = rst.TubingOD
					If tubingOD = 1.9F Then
						num = 1.25F
					ElseIf tubingOD = 1.9F Then
						num = 1.25F
					ElseIf tubingOD = 2.375F Then
						If rst.TubingID = 1.71F Then
							flag = True
							num = 1.25F
						Else
							num = 1.5F
						End If
					ElseIf tubingOD = 2.875F Then
						If rst.TubingID = 2.16F Then
							flag = True
							num = 1.75F
						Else
							num = 2F
						End If
					ElseIf tubingOD = 3.5F Then
						If rst.TubingID = 2.67F Then
							flag = True
							num = 2F
						Else
							num = 2.75F
						End If
					ElseIf tubingOD = 4F Then
						num = 3F
					ElseIf tubingOD = 4.5F Then
						num = 3.25F
					ElseIf tubingOD = 5.5F Then
						num = 3.75F
					Else
						num = CSng((CDbl(rst.TubingID) - 0.25))
					End If
				Case 2S
					text2 = "a tubing"
					Dim tubingOD2 As Single = rst.TubingOD
					If tubingOD2 = 1.9F Then
						num = 1.25F
					ElseIf tubingOD2 = 1.9F Then
						num = 1.25F
					ElseIf tubingOD2 = 2.375F Then
						If rst.TubingID = 1.71F Then
							flag = True
							num = 1.5F
						Else
							num = 1.75F
						End If
					ElseIf tubingOD2 = 2.875F Then
						If rst.TubingID = 2.16F Then
							flag = True
							num = 2F
						Else
							num = 2.25F
						End If
					ElseIf tubingOD2 = 3.5F Then
						If rst.TubingID = 2.67F Then
							flag = True
							num = 2.5F
						Else
							num = 2.75F
						End If
					ElseIf tubingOD2 = 4F Then
						num = 3.25F
					ElseIf tubingOD2 = 4.5F Then
						num = 3.75F
					ElseIf tubingOD2 = 5.5F Then
						num = 4.75F
					Else
						num = CSng((CDbl(rst.TubingID) - 0.25))
					End If
				Case 3S
					num = 1E+38F
			End Select
			Dim result As Short
			If Operators.CompareString(RSWIN_DESC.SETUP_Language, RSWIN_DESC.sEnglish, False) = 0 Then
				Dim text6 As String
				If rst.PlungerSize > num Then
					If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
						If flag Then
							Dim array As String() = New String(7) {}
							array(0) = Me.sMNEPlungerSize
							array(1) = " "
							Dim array2 As String() = array
							Dim num2 As Integer = 2
							Dim text3 As String = "0.0###"
							array2(num2) = Util.Format(num, text3)
							array(3) = " inches for "
							array(4) = text2
							array(5) = " pump to fit in "
							Dim array3 As String() = array
							Dim num3 As Integer = 6
							Dim cRODSTAR As cRODSTAR = rst
							Dim tubingOD3 As Single = cRODSTAR.TubingOD
							Dim text4 As String = "0.0###"
							Dim text5 As String = Util.Format(tubingOD3, text4)
							cRODSTAR.TubingOD = tubingOD3
							array3(num3) = text5
							array(7) = """ polylined tubing."
							text6 = String.Concat(array)
						Else
							Dim array As String() = New String(7) {}
							array(0) = Me.sMNEPlungerSize
							array(1) = " "
							Dim array4 As String() = array
							Dim num4 As Integer = 2
							Dim text4 As String = "0.0###"
							array4(num4) = Util.Format(num, text4)
							array(3) = " inches for "
							array(4) = text2
							array(5) = " pump to fit in "
							Dim array5 As String() = array
							Dim num5 As Integer = 6
							Dim cRODSTAR As cRODSTAR = rst
							Dim tubingOD3 As Single = cRODSTAR.TubingOD
							Dim text3 As String = "0.0###"
							Dim text7 As String = Util.Format(tubingOD3, text3)
							cRODSTAR.TubingOD = tubingOD3
							array5(num5) = text7
							array(7) = """ tubing."
							text6 = String.Concat(array)
						End If
					ElseIf flag Then
						Dim array As String() = New String(7) {}
						array(0) = Me.sMNEPlungerSize
						array(1) = " "
						Dim array6 As String() = array
						Dim num6 As Integer = 2
						Dim num7 As Single = CtrlUI.ConvertUnits(num, 5)
						Dim text4 As String = "0.0###"
						array6(num6) = Util.Format(num7, text4)
						array(3) = " mm for "
						array(4) = text2
						array(5) = " pump to fit in "
						Dim array7 As String() = array
						Dim num8 As Integer = 6
						Dim tubingOD3 As Single = CtrlUI.ConvertUnits(rst.TubingOD, 5)
						Dim text3 As String = "0.0###"
						array7(num8) = Util.Format(tubingOD3, text3)
						array(7) = " mm polylined tubing."
						text6 = String.Concat(array)
					Else
						Dim array As String() = New String(7) {}
						array(0) = Me.sMNEPlungerSize
						array(1) = " "
						Dim array8 As String() = array
						Dim num9 As Integer = 2
						Dim tubingOD3 As Single = CtrlUI.ConvertUnits(num, 5)
						Dim text4 As String = "0.0###"
						array8(num9) = Util.Format(tubingOD3, text4)
						array(3) = " mm for "
						array(4) = text2
						array(5) = " pump to fit in "
						Dim array9 As String() = array
						Dim num10 As Integer = 6
						Dim num7 As Single = CtrlUI.ConvertUnits(rst.TubingOD, 5)
						Dim text3 As String = "0.0###"
						array9(num10) = Util.Format(num7, text3)
						array(7) = " mm tubing."
						text6 = String.Concat(array)
					End If
				Else
					text6 = RSWIN_DESC.sNull
				End If
				If Strings.Len(text6) = 0 Then
					result = -1S
				Else
					Dim msg As String = text6 + "  " + Me.sDYWChangePlungerSize
					Dim bDefaultYes As Boolean = False
					Dim flag2 As Boolean = False
					result = If((-If((Not Util.YesNo(msg, bDefaultYes, flag2) > False), 1S, 0S)), 1S, 0S)
				End If
			Else
				If rst.PumpType = 1S Then
					text = Me.sMNEPlungerSize1
				ElseIf rst.PumpType = 2S Then
					text = Me.sMNEPlungerSize2
				End If
				Dim text6 As String
				If rst.PlungerSize > num Then
					If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
						If Strings.InStr(Me.sMNEPlungerSize1, "1 inches", CompareMethod.Binary) > 0 Then
							Dim text8 As String = text
							Dim oldValue As String = "1 inches"
							Dim text3 As String = "0.0###"
							text = text8.Replace(oldValue, Util.Format(num, text3) + " inches")
							If Strings.InStr(Me.sMNEPlungerSize1, "to fit in 2", CompareMethod.Binary) > 0 Then
								Dim text9 As String = text
								Dim oldValue2 As String = "to fit in 2"
								Dim str As String = "to fit in "
								Dim num7 As Single = CtrlUI.ConvertUnits(rst.TubingOD, 5)
								text3 = "0.0###"
								text = text9.Replace(oldValue2, str + Util.Format(num7, text3))
							End If
						End If
						text6 = text
					Else
						If Strings.InStr(Me.sMNEPlungerSize1, "1 inches", CompareMethod.Binary) > 0 Then
							Dim text10 As String = text
							Dim oldValue3 As String = "1 inches"
							Dim num7 As Single = CtrlUI.ConvertUnits(num, 5)
							Dim text3 As String = "0.0###"
							text = text10.Replace(oldValue3, Util.Format(num7, text3) + " mm")
							If Strings.InStr(Me.sMNEPlungerSize1, "to fit in 2", CompareMethod.Binary) > 0 Then
								Dim text11 As String = text
								Dim oldValue4 As String = "to fit in 2"
								Dim str2 As String = "to fit in "
								num7 = CtrlUI.ConvertUnits(rst.TubingOD, 5)
								text3 = "0.0###"
								text = text11.Replace(oldValue4, str2 + Util.Format(num7, text3))
							End If
						End If
						text6 = text
					End If
				Else
					text6 = RSWIN_DESC.sNull
				End If
				If Strings.Len(text6) = 0 Then
					result = -1S
				Else
					Dim msg2 As String = text6 + "  " + Me.sDYWChangePlungerSize
					Dim bDefaultYes2 As Boolean = False
					Dim flag2 As Boolean = False
					result = If((-If((Not Util.YesNo(msg2, bDefaultYes2, flag2) > False), 1S, 0S)), 1S, 0S)
				End If
			End If
			Return result
		End Function

		Public Function ValidateProdInfo(ByRef sProblemControlName As String, Optional bQuiet As Boolean = False, Optional ByRef sFormName As String = "ProdInfo", Optional bOverride As Boolean = False) As Boolean
			Dim flag As Boolean = True
			Dim prodInfo As ProdInfo = New ProdInfo()
			Me.ResetClock()
			If Not(Not Me.m_bClosing And prodInfo IsNot Nothing) Then
				Return True
			End If
			If prodInfo.bValidated Then
				If(RSWIN_DESC.NewData(2) And If((-If((flag > False), 1S, 0S)), 1S, 0S)) <> 0S Then
					RSWIN_DESC.NewData(2) = 0S
					ini.SaveDataValue("ProdInfo", True)
				End If
				Return True
			End If
			Dim formName As String = "ProdInfo"
			Dim form As Form = prodInfo
			Me.ReturnMdiForm(formName, form)
			prodInfo = CType(form, ProdInfo)
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			If(If((-If(((RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru) > False), 1S, 0S)), 1S, 0S) And Not rst.SPMEntered And If((-If((Not rst.gbCalcTargetBFPD > False), 1S, 0S)), 1S, 0S) And If((-If((rst.TargetBFPD < 10F > False), 1S, 0S)), 1S, 0S)) <> 0S Then
				sProblemControlName = "txtSPMBFPD"
				Return False
			End If
			Dim obj As Object = rst.giFluidLevelSource = 1S
			Dim cRODSTAR As cRODSTAR = rst
			Dim obj2 As Object = cRODSTAR.FluidLevel
			Dim msgtxt As String
			Dim obj3 As Object = Util.CheckLower(obj2, 0F, -1, 105, 0, 0, True, msgtxt)
			cRODSTAR.FluidLevel = Conversions.ToSingle(obj2)
			If Conversions.ToBoolean(Operators.AndObject(obj, Operators.NotObject(obj3))) Then
				sProblemControlName = "txtFLPIP"
				Return False
			End If
			Dim obj4 As Object = rst.giFluidLevelSource = 1S
			cRODSTAR = rst
			obj2 = cRODSTAR.FluidLevel
			Dim obj5 As Object = Util.CheckUpper(obj2, RSWIN_DESC.rst.PumpDepth, -1, 103, 0, 0, True, msgtxt)
			cRODSTAR.FluidLevel = Conversions.ToSingle(obj2)
			If Conversions.ToBoolean(Operators.AndObject(obj4, Operators.NotObject(obj5))) Then
				sProblemControlName = "txtFLPIP"
				Return False
			End If
			If rst.gbUseIPR Then
				If rst.FetkovichN = 0F And rst.giIPRMethod = 0S Then
					If Not bQuiet Then
						prodInfo.DisplayProdInfoError("Please enter a value for 'n' (Fetkovich corr.). If you do not have IPR information, please click on the 'IPR Data' command button to continue without using IPR Data.", Me.bCancel)
					End If
					sProblemControlName = "txtFetkovichN"
					Return False
				End If
				If rst.giIPRMethod = -1S Then
					If Not bQuiet Then
						prodInfo.DisplayProdInfoError("Please select IPR calculation method. If you do not have IPR information, please click on the 'IPR Data' command button to continue without using IPR Data.", Me.bCancel)
					End If
					sProblemControlName = "txtFetkovichN"
					Return False
				End If
				If rst.MidPerfDepth = 0F Then
					If Not bQuiet Then
						prodInfo.DisplayProdInfoError("Please enter a value for Mid-perf. depth. If you do not have this information, please click on 'IPR Data' command button to continue without using IPR Data.", Me.bCancel)
					End If
					sProblemControlName = "txtMidPerfDepth"
					Return False
				End If
				If rst.StaticBHPressure = 0F Then
					If Not bQuiet Then
						prodInfo.DisplayProdInfoError("Please enter a value for Static b'hole pressure. If you do not have this information, please click on 'IPR Data' command button to continue without using IPR Data.", Me.bCancel)
					End If
					sProblemControlName = "txtStaticBHPressure"
					Return False
				End If
				If rst.BubblePoint = 0F And Not rst.gbProducingBelowBPP Then
					If Not bQuiet Then
						prodInfo.DisplayProdInfoError("Please enter a value for Bubble point pressure. If you do not have this information, please click on 'IPR Data' command button to continue without using IPR Data.", Me.bCancel)
					End If
					sProblemControlName = "txtBubblePoint"
					Return False
				End If
				If rst.gnTestPoints = 0S Then
					If Not bQuiet Then
						prodInfo.DisplayProdInfoError("Please enter at least one pressure test point. If you do not have this information, please click on 'IPR Data' command button to continue without using IPR Data.", Me.bCancel)
					End If
					sProblemControlName = "ulgTestPoints"
					Return False
				End If
				Dim obj6 As Object = rst.giIPRMethod = 0S
				cRODSTAR = RSWIN_DESC.rst
				obj2 = cRODSTAR.FetkovichN
				Dim lowerBound As Single = 0.5F
				Dim inclusive As Integer = -1
				Dim errnum As Integer = 22
				Dim useMetric As Integer = 0
				Dim canadianIsMetric As Integer = 0
				Dim bQuiet2 As Boolean = True
				Dim text As String = ""
				Dim obj7 As Object = Util.CheckLower(obj2, lowerBound, inclusive, errnum, useMetric, canadianIsMetric, bQuiet2, text)
				cRODSTAR.FetkovichN = Conversions.ToSingle(obj2)
				If Conversions.ToBoolean(Operators.AndObject(obj6, Operators.NotObject(obj7))) Then
					If Not RSWIN_DESC.rst.gbCalcFetkovichN Then
						If Not bQuiet Then
							prodInfo.DisplayProdInfoError("Value for 'n' (Fetkovich corr.) must be between 0.5 and 1.0", Me.bCancel)
						End If
						sProblemControlName = "txtFetkovichN"
					Else
						If Not bQuiet Then
							prodInfo.DisplayProdInfoError("Calculated 'n' (Fetkovich corr.) is less than 0.5. Please check mid-perf. depth, static b'hole pressure, bubble point pressure, and production test point data.", Me.bCancel)
						End If
						sProblemControlName = "txtMidPerfDepth"
					End If
					Return False
				End If
				Dim obj8 As Object = rst.giIPRMethod = 0S
				cRODSTAR = RSWIN_DESC.rst
				obj2 = cRODSTAR.FetkovichN
				Dim upperBound As Single = 1F
				Dim inclusive2 As Integer = -1
				Dim errnum2 As Integer = 22
				Dim useMetric2 As Integer = 0
				Dim canadianIsMetric2 As Integer = 0
				Dim bQuiet3 As Boolean = True
				text = ""
				Dim obj9 As Object = Util.CheckUpper(obj2, upperBound, inclusive2, errnum2, useMetric2, canadianIsMetric2, bQuiet3, text)
				cRODSTAR.FetkovichN = Conversions.ToSingle(obj2)
				If Conversions.ToBoolean(Operators.AndObject(obj8, Operators.NotObject(obj9))) Then
					If Not RSWIN_DESC.rst.gbCalcFetkovichN Then
						If Not bQuiet Then
							prodInfo.DisplayProdInfoError("Value for 'n' (Fetkovich corr.) must be between 0.5 and 1.0", Me.bCancel)
						End If
						sProblemControlName = "txtFetkovichN"
					Else
						If Not bQuiet Then
							prodInfo.DisplayProdInfoError("Calculated 'n' (Fetkovich corr.) is greater than 1.0. Please check mid-perf. depth, static b'hole pressure, bubble point pressure, and production test point data.", Me.bCancel)
						End If
						sProblemControlName = "txtMidPerfDepth"
					End If
					Return False
				End If
				Dim num As Integer = 1
				Dim gnTestPoints As Integer = CInt(rst.gnTestPoints)
				For i As Integer = num To gnTestPoints
					Dim obj10 As Object
					If rst.TestPoints(i).bPIEntered <> 0S Then
						obj10 = IPR.iprPwfFromPip(rst.TestPoints(i).Pintake)
					Else
						obj10 = IPR.iprPipFromPwf(rst.TestPoints(i).Pwf)
					End If
					Dim flag2 As Boolean = False
					If Not Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(obj10)) Then
						flag2 = True
					ElseIf Operators.ConditionalCompareObjectLessEqual(obj10, 0, False) Then
						flag2 = True
					End If
					If flag2 Then
						Util.LoadMessage(108, msgtxt)
						Util.ApplyNumber(CSng(i), msgtxt)
						If Not bQuiet Then
							Util.Errmsg(msgtxt)
						End If
						sProblemControlName = "ulgTestPoints"
						Return False
					End If
				Next
				If Not rst.gbCalcPumpCondition Then
					If rst.FluidLevelEntered Then
						rst.PumpIntakePressure = CSng((0.433 * CDbl(rst.OilSPGR) * CDbl((rst.PumpDepth - rst.FluidLevel)) + CDbl(rst.CasingPressure) + 14.7))
					End If
					If IPR.iprPwfFromPip(rst.PumpIntakePressure) >= rst.StaticBHPressure Then
						If Not bQuiet Then
							Util.cErrmsg(Conversions.ToInteger(Interaction.IIf(rst.FluidLevelEntered, 104S, 124S)))
						End If
						sProblemControlName = "txtFLPIP"
						Return False
					End If
					If rst.SPMEntered <> 0S AndAlso Not bQuiet Then
						Util.Errmsg(Util.FormatMessage("If you enter the pumping speed, {0} uses the IPR data only if you have {1} calculate the pump condition and pump fillage. To do this, select 'Calculate pump condition' on the Well Information window.", New Object() { VERSION1.ProgramTitle(), VERSION1.ProgramTitle() }))
					End If
				End If
				If(Not rst.SPMEntered And If((-If((Not rst.gbCalcTargetBFPD > False), 1S, 0S)), 1S, 0S)) <> 0S Then
					Dim num2 As Single = IPR.iprPwfFromPip(rst.CasingPressure)
					If rst.TargetBFPD > IPR.iprProductionFromPwf(num2) + rst.WaterPI * (rst.StaticBHPressure - num2) Then
						If Not bQuiet Then
							Util.cErrmsg(146)
						End If
						sProblemControlName = "txtSPMBFPD"
						Return False
					End If
				End If
			End If
			If rst.giFluidLevelSource <> 0S Then
				If rst.giFluidLevelSource = 1S Then
					If rst.FluidLevel < 0F Then
						If Not bQuiet Then
							prodInfo.DisplayProdInfoError("Please enter a value for Fluid Level", Me.bCancel)
						End If
						If Not Me.bCancel Then
							sProblemControlName = "txtFLPIP"
							Return False
						End If
					ElseIf(If((-If(((rst.TargetBFPD = 0F) > False), 1S, 0S)), 1S, 0S) And Not rst.SPMEntered And If((-If((Not rst.gbCalcTargetBFPD > False), 1S, 0S)), 1S, 0S)) <> 0S Then
						If Not bQuiet Then
							prodInfo.DisplayProdInfoError("Please enter a value for Target Production", Me.bCancel)
						End If
						If Not Me.bCancel Then
							sProblemControlName = "txtSPMBFPD"
							Return False
						End If
					ElseIf(Not rst.SPMEntered And If((-If((Not rst.gbCalcTargetBFPD > False), 1S, 0S)), 1S, 0S) And If((-If((RSWIN_DESC.rst.Runtime < 24F > False), 1S, 0S)), 1S, 0S) And RSWIN_DESC.SETUP_DisplayTargetBFPDWarning) <> 0S Then
						If Not bQuiet And Not prodInfo.bAlreadyAskedTargetBFPDQuestion And RSWIN_DESC.bExpert Then
							prodInfo.bAlreadyAskedTargetBFPDQuestion = True
							Me.Message("To change the runtime or target production click on 'No'.")
							Dim dialogResult As DialogResult = MessageBox.Show(" Do you want to achieve this target production with a runtime of " + Conversions.ToString(RSWIN_DESC.rst.Runtime) + " hours? ", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
							If dialogResult = DialogResult.No And Not Me.bCancel Then
								sFormName = "WellInfo"
								sProblemControlName = "txtRuntime"
								Return False
							End If
							Me.Message(" ")
						End If
					ElseIf(If((-If(((rst.SPM = 0F) > False), 1S, 0S)), 1S, 0S) And rst.SPMEntered And If((-If((Not rst.gbCalcTargetBFPD > False), 1S, 0S)), 1S, 0S)) <> 0S Then
						If Not bQuiet Then
							prodInfo.DisplayProdInfoError("Please enter a value for Pumping speed (spm)", Me.bCancel)
						End If
						If Not Me.bCancel Then
							sProblemControlName = "txtSPMBFPD"
							Return False
						End If
					End If
				ElseIf rst.giFluidLevelSource = 2S And rst.PumpIntakePressure = 0F Then
					If Not bQuiet Then
						prodInfo.DisplayProdInfoError("Please enter a value for Pump Intake Pressure", Me.bCancel)
					End If
					If Not Me.bCancel Then
						sProblemControlName = "txtFLPIP"
						Return False
					End If
				End If
			ElseIf(If((-If(((rst.TargetBFPD = 0F) > False), 1S, 0S)), 1S, 0S) And Not rst.SPMEntered And If((-If((Not rst.gbCalcTargetBFPD > False), 1S, 0S)), 1S, 0S)) <> 0S Then
				If Not bQuiet Then
					prodInfo.DisplayProdInfoError("Please enter a value for Target Production", Me.bCancel)
				End If
				If Not Me.bCancel Then
					sProblemControlName = "txtSPMBFPD"
					Return False
				End If
			ElseIf(If((-If(((rst.SPM = 0F) > False), 1S, 0S)), 1S, 0S) And rst.SPMEntered And If((-If((Not rst.gbCalcTargetBFPD > False), 1S, 0S)), 1S, 0S)) <> 0S Then
				If Not bQuiet Then
					prodInfo.DisplayProdInfoError("Please enter a value for Pumping speed (spm)", Me.bCancel)
				End If
				If Not Me.bCancel Then
					sProblemControlName = "txtSPMBFPD"
					Return False
				End If
			End If
			If(RSWIN_DESC.NewData(2) And If((-If((flag > False), 1S, 0S)), 1S, 0S)) <> 0S Then
				RSWIN_DESC.NewData(2) = 0S
				ini.SaveDataValue("ProdInfo", True)
			End If
			If Not Me.bCancel And Not bQuiet And Not flag Then
				prodInfo.bValidated = False
			Else
				prodInfo.bValidated = True
			End If
			Return flag
		End Function

		Public Sub DisplayForm(FrmName As String, sProblemControlName As String)
			Dim flag As Boolean = False
			If Operators.CompareString(FrmName, "WellInfo", False) = 0 Then
				Me.AddWellInfo(True)
			ElseIf Operators.CompareString(FrmName, "ProdInfo", False) = 0 Then
				Me.AddProdInfo(True)
			ElseIf Operators.CompareString(FrmName, "PTInfo", False) = 0 Then
				Me.AddPTInfo(True)
			ElseIf Operators.CompareString(FrmName, "RSInput", False) = 0 Then
				Me.AddRSInput(True, False)
			ElseIf Operators.CompareString(FrmName, "DeviationProfile", False) = 0 Then
				If RSWIN_DESC.bRodStarD Then
					Me.AddDeviationProfile(True)
				End If
			ElseIf Operators.CompareString(FrmName, "PUData", False) = 0 Then
				Me.AddPUData(True)
			ElseIf Operators.CompareString(FrmName, "MotorData", False) = 0 Then
				Me.AddMotorData(True)
			End If
			For Each form As Form In Me.MdiChildren
				If Operators.CompareString(FrmName, form.Name, False) = 0 Then
					form.Activate()
					Try
						For Each obj As Object In form.Controls
							Dim control As Control = CType(obj, Control)
							Dim index As Integer = form.Controls.IndexOf(control)
							If Operators.CompareString(control.Name, sProblemControlName, False) = 0 Then
								form.Controls(index).Focus()
								flag = True
								Exit For
							End If
							Try
								For Each obj2 As Object In control.Controls
									Dim control2 As Control = CType(obj2, Control)
									If Operators.CompareString(control2.Name, sProblemControlName, False) = 0 Then
										index = form.Controls.IndexOf(control)
										Dim index2 As Integer = control.Controls.IndexOf(control2)
										form.Controls(index).Focus()
										form.Controls(index).Controls(index2).Focus()
										flag = True
										Exit For
									End If
									Try
										For Each obj3 As Object In control2.Controls
											Dim control3 As Control = CType(obj3, Control)
											If Operators.CompareString(control3.Name, sProblemControlName, False) = 0 Then
												Try
													index = form.Controls.IndexOf(control)
													Dim index2 As Integer = control.Controls.IndexOf(control2)
													Dim index3 As Integer = control2.Controls.IndexOf(control3)
													form.Controls(index).Focus()
													form.Controls(index).Controls(index2).Focus()
													form.Controls(index).Controls(index2).Controls(index3).Focus()
													flag = True
													Exit Try
												Catch ex As Exception
												End Try
											End If
											Try
												For Each obj4 As Object In control3.Controls
													Dim control4 As Control = CType(obj4, Control)
													If Operators.CompareString(control4.Name, sProblemControlName, False) = 0 Then
														Try
															index = form.Controls.IndexOf(control)
															Dim index2 As Integer = control.Controls.IndexOf(control2)
															Dim index3 As Integer = control2.Controls.IndexOf(control3)
															Dim index4 As Integer = control3.Controls.IndexOf(control4)
															form.Controls(index).Focus()
															form.Controls(index).Controls(index2).Focus()
															form.Controls(index).Controls(index2).Controls(index3).Focus()
															form.Controls(index).Controls(index2).Controls(index3).Controls(index4).Focus()
															flag = True
															Exit Try
														Catch ex2 As Exception
														End Try
													End If
													If flag Then
														Exit For
													End If
												Next
											Finally
												Dim enumerator4 As IEnumerator
												If TypeOf enumerator4 Is IDisposable Then
													TryCast(enumerator4, IDisposable).Dispose()
												End If
											End Try
											If flag Then
												Exit For
											End If
										Next
									Finally
										Dim enumerator3 As IEnumerator
										If TypeOf enumerator3 Is IDisposable Then
											TryCast(enumerator3, IDisposable).Dispose()
										End If
									End Try
									If flag Then
										Exit For
									End If
								Next
							Finally
								Dim enumerator2 As IEnumerator
								If TypeOf enumerator2 Is IDisposable Then
									TryCast(enumerator2, IDisposable).Dispose()
								End If
							End Try
							If flag Then
								Exit For
							End If
						Next
					Finally
						Dim enumerator As IEnumerator
						If TypeOf enumerator Is IDisposable Then
							TryCast(enumerator, IDisposable).Dispose()
						End If
					End Try
					form.Show()
					Exit For
				End If
			Next
		End Sub

		Private Function ValidateMotorData(ByRef sProblemControlName As String, Optional bQuiet As Boolean = False, Optional bOverride As Boolean = False) As Boolean
			Me.ResetClock()
			Dim flag As Boolean = True
			RSWIN_DESC.sNull = ""
			Dim sNull As String = RSWIN_DESC.sNull
			Dim wellInfo As WellInfo = New WellInfo()
			Dim formName As String = "WellInfo"
			Dim form As Form = wellInfo
			Dim flag2 As Boolean = Me.ReturnMdiForm(formName, form)
			wellInfo = CType(form, WellInfo)
			Dim flag3 As Boolean = flag2
			If Not Me.m_bClosing Then
				If(flag3 And wellInfo IsNot Nothing) AndAlso Not wellInfo.bValidated Then
					Dim rst As cRODSTAR = RSWIN_DESC.rst
					If rst.ElectricityCost = 0F Then
						If Not bQuiet Then
							wellInfo.DisplayWellInfoError("Please enter a value for electricity cost", Me.bCancel)
						End If
						If Not Me.bCancel Then
							sProblemControlName = "txtElectricityCost"
							flag = False
						End If
					End If
				End If
				If(RSWIN_DESC.NewData(7) And If((-If((flag > False), 1S, 0S)), 1S, 0S)) <> 0S Then
					RSWIN_DESC.NewData(7) = 0S
					ini.SaveDataValue("MotorData", True)
				End If
				Return flag
			End If
			Return True
		End Function

		Private Sub DisplayNext()
			Dim flag As Boolean = False
			Dim flag2 As Boolean = False
			Dim text As String = ""
			Dim text2 As String
			Try
				text2 = Me.ActiveMdiChild.Name
			Catch ex As Exception
				text2 = ""
			End Try
			Util.BusyCursor()
			Try
				Util.BusyCursor()
				Application.DoEvents()
			Catch ex2 As Exception
			End Try
			Dim text3 As String = text2
			If Operators.CompareString(text3, "WellInfo", False) = 0 Then
				Dim sProblemControlName As String
				If Me.ValidateWellInfo(sProblemControlName, False, False) Then
					Me.UnloadAllFormsExceptVisInput()
					Application.DoEvents()
					Me.AddProdInfo(True)
					Me.ToolbarButtonSetState(8, True)
					Me.ToolbarButtonSetState(9, True)
				Else
					Me.DisplayForm("WellInfo", sProblemControlName)
				End If
			ElseIf Operators.CompareString(text3, "ProdInfo", False) = 0 Then
				If RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru Then
					flag = (Operators.CompareString(RSWIN_DESC.rst.Inputfile, "(Untitled)", False) = 0)
					Me.ToolbarButtonSetState(2, True)
					Me.ToolbarButtonSetState2(0, True)
				End If
				text = "ProdInfo"
				Dim sProblemControlName As String
				If Me.ValidateProdInfo(sProblemControlName, False, text, False) Then
					Me.UnloadAllFormsExceptVisInput()
					Application.DoEvents()
					If RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru Then
						Me.ToolbarButtonSetState(9, True)
						Me.AddWellInfo(True)
						Me.ToolbarButtonSetState(8, True)
					Else
						Me.AddPTInfo(True)
						Me.ToolbarButtonSetState(9, True)
						Me.ToolbarButtonSetState(10, True)
					End If
				ElseIf Operators.CompareString(text, "WellInfo", False) = 0 Then
					Me.DisplayForm("WellInfo", sProblemControlName)
					Me.ToolbarButtonSetState(8, True)
				Else
					Me.DisplayForm("ProdInfo", sProblemControlName)
				End If
			ElseIf Operators.CompareString(text3, "PTInfo", False) = 0 Then
				Dim sProblemControlName As String
				If Me.ValidatePTInfo(sProblemControlName, False, False) Then
					Me.UnloadAllFormsExceptVisInput()
					Application.DoEvents()
					If RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru Then
						Me.AddMotorData(True)
						Me.ToolbarButtonSetState(10, True)
						Me.ToolbarButtonSetState(14, True)
					Else
						Me.AddRSInput(True, False)
						Me.ToolbarButtonSetState(10, True)
						Me.ToolbarButtonSetState(11, True)
					End If
				Else
					Me.DisplayForm("PTInfo", sProblemControlName)
				End If
			ElseIf Operators.CompareString(text3, "RSInput", False) = 0 Then
				Dim sProblemControlName As String
				If Me.ValidateRSInput(sProblemControlName, False, False) Then
					If RSWIN_DESC.bRodStarD Then
						Me.UnloadAllFormsExceptVisInput()
						Application.DoEvents()
						Me.AddDeviationProfile(True)
						Me.ToolbarButtonSetState(11, True)
						Me.ToolbarButtonSetState(12, True)
					Else
						Me.UnloadAllFormsExceptVisInput()
						Application.DoEvents()
						Me.AddPUData(True)
						Me.ToolbarButtonSetState(12, False)
						Me.ToolbarButtonSetState(13, True)
					End If
				Else
					Me.DisplayForm("RSInput", sProblemControlName)
				End If
			ElseIf Operators.CompareString(text3, "DeviationProfile", False) = 0 Then
				If RSWIN_DESC.bRodStarD Then
					Dim sProblemControlName As String
					If Me.ValidateDeviationProfile(sProblemControlName, False, False) Then
						Me.UnloadAllFormsExceptVisInput()
						Application.DoEvents()
						Me.AddPUData(True)
						Me.ToolbarButtonSetState(12, True)
						Me.ToolbarButtonSetState(13, True)
					Else
						Me.DisplayForm("DeviationProfile", sProblemControlName)
					End If
				End If
			ElseIf Operators.CompareString(text3, "PUData", False) = 0 Then
				Dim sProblemControlName As String
				If Me.ValidatePUData(sProblemControlName, False, False) Then
					Me.UnloadAllFormsExceptVisInput()
					Application.DoEvents()
					Me.AddMotorData(True)
					Me.ToolbarButtonSetState(13, True)
					Me.ToolbarButtonSetState(14, True)
					Me.ToolbarButtonSetState(1, True)
					Me.ToolbarButtonSetState(2, True)
					Me.ToolbarButtonSetState2(4, True)
					Me.ToolbarButtonSetState2(5, True)
					Me.ToolbarButtonSetState2(0, True)
					Me.ToolbarButtonSetState(16, True)
					Me.btnVisualInput.Visible = True
					Me.btnVisualInput.Enabled = True
					Me.btnAlpha.Visible = True
					Me.btnAlpha.Enabled = True
				Else
					Me.DisplayForm("PUData", sProblemControlName)
				End If
			ElseIf Operators.CompareString(text3, "MotorData", False) = 0 Then
				flag = (Operators.CompareString(RSWIN_DESC.rst.Inputfile, "(Untitled)", False) = 0)
				Dim sProblemControlName As String
				If Me.ValidateMotorData(sProblemControlName, False, False) Then
					Me.UnloadAllFormsExceptVisInput()
					Application.DoEvents()
					Me.ToolbarButtonSetState(14, True)
					Me.ToolbarButtonSetState(16, True)
					If RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru Then
						flag2 = True
					End If
					Me.AddWellInfo(True)
				Else
					Me.DisplayForm("MotorData", sProblemControlName)
				End If
				Me.ToolbarButtonSetState2(3, True)
			End If
			Dim flag3 As Boolean = True
			Dim num As Integer = 1
			Do
				If(RSWIN_DESC.NewData(num) And If((-If(((num <> 5) > False), 1S, 0S)), 1S, 0S)) <> 0S Then
					flag3 = False
				End If
				num += 1
			Loop While num <= 7
			If flag3 OrElse flag Then
				Me.ToolbarButtonSetState(2, True)
				Me.ToolbarButtonSetState2(0, True)
				If flag Then
					ini.SaveDataValue("InProgress", False)
					Me.SAVEAFILE(True, True, False, False, False, False, RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru)
				End If
				If RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru Then
					Me.ToolbarButtonSetState(2, True)
					Me.ToolbarButtonSetState2(0, True)
				End If
			Else
				Me.ToolbarButtonSetState(0, False)
			End If
			Me.ToolbarButtonSetState(0, True)
			Me.ToolbarButtonSetState(1, True)
			If flag2 Then
				Me.ToolbarButtonSetState2(0, True)
			End If
			Util.UnbusyCursor()
		End Sub

		Private Sub DisplayPrevious()
			Dim text As String
			Try
				text = Me.ActiveMdiChild.Name
			Catch ex As Exception
				text = ""
			End Try
			Try
				Util.BusyCursor()
				Me.UnloadAllForms(0, 0)
				Application.DoEvents()
			Catch ex2 As Exception
			End Try
			Dim text2 As String = text
			If Operators.CompareString(text2, "WellInfo", False) = 0 Then
				If RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru Then
					Me.AddProdInfo(True)
				Else
					Me.AddMotorData(True)
				End If
			ElseIf Operators.CompareString(text2, "ProdInfo", False) = 0 Then
				Me.AddWellInfo(True)
				Me.ToolbarButtonSetState(16, True)
			ElseIf Operators.CompareString(text2, "PTInfo", False) = 0 Then
				Me.AddProdInfo(True)
				Me.ToolbarButtonSetState(16, True)
			ElseIf Operators.CompareString(text2, "RSInput", False) = 0 Then
				Me.AddPTInfo(True)
				Me.ToolbarButtonSetState(13, True)
				Me.ToolbarButtonSetState(16, True)
			ElseIf Operators.CompareString(text2, "DeviationProfile", False) = 0 Then
				Me.AddRSInput(True, False)
				Me.ToolbarButtonSetState(16, True)
			ElseIf Operators.CompareString(text2, "PUData", False) = 0 Then
				If RSWIN_DESC.bRodStarD Then
					Me.AddDeviationProfile(True)
				Else
					Me.AddRSInput(True, False)
				End If
				Me.ToolbarButtonSetState(16, True)
			ElseIf Operators.CompareString(text2, "MotorData", False) = 0 Then
				Me.AddPUData(True)
				Me.ToolbarButtonSetState(16, True)
			End If
			Util.UnbusyCursor()
		End Sub

		Private Sub Rodstar_Resize(sender As Object, e As EventArgs)
			Dim text As String = ""
			Me.panStatus.Width = Me.Width - 75
			Try
				Dim formName As String = "Results"
				Dim results As Results
				Dim form As Form = results
				Dim flag As Boolean = Me.ReturnMdiForm(formName, form)
				results = CType(form, Results)
				Dim flag2 As Boolean = flag
				If flag2 Then
					results.Width = Me.Width - 30
					results.Height = Me.Height - 120
					results.Refresh()
				End If
			Catch ex As Exception
			End Try
			Try
				Dim formName2 As String = "BatchLog"
				Dim batchLog As BatchLog
				Dim form As Form = batchLog
				Dim flag3 As Boolean = Me.ReturnMdiForm(formName2, form)
				batchLog = CType(form, BatchLog)
				Dim flag2 As Boolean = flag3
				If flag2 Then
					batchLog.Height = Me.Height - 120
					batchLog.Refresh()
				End If
				If RSWIN_DESC.bExpert Then
					If RSWIN_DESC.bXRODAdmin Then
						Me.tbrExpertAdmin.Left = Me.btnAlpha.Left + Me.btnAlpha.Width + 10
					End If
					Me.tbrGuru.Visible = True
					If RSWIN_DESC.SETUP_bGuru Then
						Me.lblGURU.Left = Me.panStatus.Width - 108
						Me.lblGURU.Height = Me.panStatus.Height
						Me.lblGURU.Top = Me.panStatus.Top
						Me.btnGuru.Left = Me.lblGURU.Left
						Me.btnGuru.Top = Me.lblGURU.Top - Me.btnGuru.Height
						Me.lblGURU.Visible = True
						FILEUTIL.LocateFile(RSWIN_DESC.sXRODV_Gif_Corner_Filename, text, 0S, False, False, False, False)
						If Operators.CompareString(text, "", False) <> 0 Then
							Me.btnGuru.Text = ""
							Dim image As Bitmap = New Bitmap(text)
							Me.btnGuru.Image = image
						Else
							Me.btnGuru.Text = "AI Mode"
						End If
						Me.btnGuru.Visible = True
						Me.btnMeasUnit.Top = Me.panStatus.Top
						Me.btnMeasUnit.Left = Me.btnGuru.Left - Me.btnMeasUnit.Width
						Me.btnMeasUnit.BringToFront()
						Me.btnMeasUnit.Visible = True
					Else
						Me.lblGURU.Visible = False
						Me.btnGuru.Visible = False
						Me.btnGuru.Image = Nothing
						Me.btnMeasUnit.Left = Me.panStatus.Left + Me.panStatus.Width - 40
						Me.btnMeasUnit.Top = Me.panStatus.Top
						Me.btnMeasUnit.BringToFront()
						Me.btnMeasUnit.Visible = True
					End If
				Else
					Me.tbrGuru.Visible = False
					Me.lblGURU.Visible = False
					Me.btnGuru.Visible = False
					Me.btnMeasUnit.Left = Me.panStatus.Left + Me.panStatus.Width - 40
					Me.btnMeasUnit.Top = Me.panStatus.Top
					Me.btnMeasUnit.BringToFront()
					Me.btnMeasUnit.Visible = True
				End If
			Catch ex2 As Exception
			End Try
		End Sub

		Public Sub SetBatchLogTopMost(bTop As Boolean)
			Try
				Dim flag2 As Boolean
				Dim flag As Boolean = Me.MdiFormExists("BatchLog", False, False, False, flag2)
				If flag Then
					Dim formName As String = "BatchLog"
					Dim batchLog As BatchLog
					Dim form As Form = batchLog
					Me.ReturnMdiForm(formName, form)
					batchLog = CType(form, BatchLog)
					batchLog.SetTopMost(bTop)
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub Rodstar_Load(sender As Object, e As EventArgs)
			Try
				If RSWIN_DESC.bRunningChineseVersion And RSWIN_DESC.clsGlobal Is Nothing Then
					RSWIN_DESC.clsGlobal = New cGlobal()
					cGlobal.Lang = New ResourceManager("RSWINV3.RSWStrings_zh-Hans", GetType(RODSTAR).Assembly)
				End If
			Catch ex As Exception
			End Try
			RSWIN_DESC.bParentFormClosing = False
			Try
				Dim text As String = "MeasurementSystem"
				Dim num As Integer = 1
				RSWIN_DESC.SETUP_MeasurementSystem = Conversions.ToInteger(RSWIN.GetRegProfileStringByInt(RSWIN_DESC.SECT_GENERAL, text, num))
				If Not(RSWIN_DESC.SETUP_MeasurementSystem = 1 Or RSWIN_DESC.SETUP_MeasurementSystem = 2 Or RSWIN_DESC.SETUP_MeasurementSystem = 3) Then
					RSWIN_DESC.SETUP_MeasurementSystem = 1
					text = "MeasurementSystem"
					Dim obj As Object = RSWIN_DESC.SETUP_MeasurementSystem
					Dim text2 As String = Util.Format(obj)
					RSWIN_DESC.SETUP_MeasurementSystem = Conversions.ToInteger(obj)
					Dim text3 As String = text2
					Dim num2 As Long = CLng(RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_GENERAL, text, text3, RSWIN_DESC.sINIFile))
				End If
			Catch ex2 As Exception
				RSWIN_DESC.SETUP_MeasurementSystem = 1
				Dim text3 As String = "MeasurementSystem"
				Dim obj As Object = RSWIN_DESC.SETUP_MeasurementSystem
				Dim text4 As String = Util.Format(obj)
				RSWIN_DESC.SETUP_MeasurementSystem = Conversions.ToInteger(obj)
				Dim text As String = text4
				Dim num2 As Long = CLng(RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_GENERAL, text3, text, RSWIN_DESC.sINIFile))
			End Try
			Try
				Application.DoEvents()
				Application.DoEvents()
				RSWIN.GetMeasurementUnit()
				Me.ResetClock()
				If Operators.CompareString(RSWIN_DESC.sRodstarVorD, "RODSTARD", False) <> 0 Then
					Me.lblMode.Visible = False
				Else
					If RSWIN_DESC.bRodStarD Then
						Me.lblMode.ForeColor = Color.Green
						Me.lblMode.Text = "Deviated mode"
					Else
						Me.lblMode.ForeColor = Color.Blue
						Me.lblMode.Text = "Vertical mode"
					End If
					Me.lblMode.Visible = True
				End If
				RSWIN_DESC.bGuruFileDataLoaded = False
				If Screen.PrimaryScreen.Bounds.Height < 700 Then
					Me.Top = 0
				End If
				Application.DoEvents()
				Application.DoEvents()
				Application.DoEvents()
				RSWIN_DESC.bRunStarRunning = True
				Me.Load_Rodstar()
				Application.DoEvents()
				If RSWIN_DESC.bRodStarD Then
					Me.tbrRun.ToolTipText = "Run"
					Me.tbrRunSpeed.ToolTipText = "Run"
					Me.tbrToolBar2.Buttons(1).Visible = False
					Me.tbrToolBar2.Buttons(1).Enabled = False
				End If
				Application.DoEvents()
				Application.DoEvents()
				Application.DoEvents()
				If RSWIN_DESC.bExpert Then
					Me.PrepareAIAni()
					If RSWIN_DESC.bXRODAdmin Then
						Me.tbrExpertAdmin.Visible = True
					End If
				End If
				Me.ResetClock()
				Application.DoEvents()
				Application.DoEvents()
				Application.DoEvents()
				Me.btnAlpha.Left = Me.btnVisualInput.Left + Me.btnVisualInput.Width + 5
				Dim text3 As String = "ExitIfIdle"
				Dim flag As Boolean = False
				RSWIN_DESC.SETUP_ExitIfIdle = If((-If((RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_GENERAL, text3, flag) > False), 1S, 0S)), 1S, 0S)
				If RSWIN_DESC.SETUP_ExitIfIdle <> 0S Then
					Me.tmrClock.Enabled = True
				Else
					Me.tmrClock.Enabled = False
				End If
				If RSWIN_DESC.bDoAutoSentinelChecks Then
					If Not RSWIN_DESC.gbDemoMode Then
						AddHandler Me.mTLM32.SentinelUnplugged, Sub()
							Me.SentinelUnplugged(True)
						End Sub
						Me.mTLM32.tmrCheckSentinel.Interval = 240000
						Me.mTLM32.tmrCheckSentinelRepliedBln.Interval = 60000
						Me.mTLM32.StartSentinelCheck()
					Else
						Me.mTLM32.StopSentinelCheck()
						Me.mTLM32.tmrCheckSentinel.Enabled = False
					End If
				End If
				If RSWIN_DESC.bExpert Then
					If RSWIN_DESC.SETUP_bGuru Then
						RSWIN_DESC.rst.RSTDir = Conversions.ToString(RSWIN.GetInitialDir(".XRVX", ""))
					Else
						RSWIN_DESC.rst.RSTDir = Conversions.ToString(RSWIN.GetInitialDir(".RSVX", ""))
					End If
				End If
			Catch ex3 As Exception
			End Try
		End Sub

		Private Sub Load_Rodstar()
			' The following expression was wrapped in a checked-statement
			Try
				Dim fileName As String = ""
				Dim text As String = ""
				Dim flag As Boolean = True
				Me.tbrToolbar.Buttons(0).Enabled = False
				Me.tbrToolbar.Buttons(1).Enabled = False
				RSWIN_DESC.gbTrialLicenseExpired = False
				RSWIN_DESC.gsTrialType = ""
				If Screen.PrimaryScreen.Bounds.Width >= 1280 Then
					RSWIN_DESC.bUseLandscape = True
					Me.StartPosition = FormStartPosition.Manual
					Me.Width = CInt(Math.Round(CDbl(Screen.PrimaryScreen.Bounds.Width) * 0.9125))
					Me.Height = CInt(Math.Round(CDbl(Screen.PrimaryScreen.Bounds.Height) * 0.9))
					Me.Left = CInt(Math.Round(CDbl(Screen.PrimaryScreen.Bounds.Left) + CDbl((Screen.PrimaryScreen.Bounds.Width - Me.Width)) / 2.0))
					Me.Top = CInt(Math.Round(CDbl(Screen.PrimaryScreen.Bounds.Top) + CDbl((Screen.PrimaryScreen.Bounds.Height - Me.Height)) / 2.0))
				ElseIf Screen.PrimaryScreen.Bounds.Width >= 1000 Then
					RSWIN_DESC.bUseLandscape = False
					Me.StartPosition = FormStartPosition.Manual
					Me.Width = CInt(Math.Round(CDbl(Screen.PrimaryScreen.Bounds.Width) * 0.95))
					If Screen.PrimaryScreen.Bounds.Height < 700 Then
						' The following expression was wrapped in a unchecked-expression
						Me.Height = CInt(Math.Round(CDbl(Screen.PrimaryScreen.Bounds.Height) * 0.95))
					Else
						' The following expression was wrapped in a unchecked-expression
						Me.Height = CInt(Math.Round(CDbl(Screen.PrimaryScreen.Bounds.Height) * 0.9))
					End If
					Me.Left = CInt(Math.Round(CDbl(Screen.PrimaryScreen.Bounds.Left) + CDbl((Screen.PrimaryScreen.Bounds.Width - Me.Width)) / 2.0))
					If Screen.PrimaryScreen.Bounds.Height > 700 Then
						' The following expression was wrapped in a unchecked-expression
						' The following expression was wrapped in a checked-expression
						Me.Top = CInt(Math.Round(CDbl(Screen.PrimaryScreen.Bounds.Top) + CDbl((Screen.PrimaryScreen.Bounds.Height - Me.Height)) / 2.0))
					End If
				Else
					RSWIN_DESC.bUseLandscape = False
					Me.StartPosition = FormStartPosition.Manual
					Me.Width = CInt(Math.Round(CDbl(Screen.PrimaryScreen.Bounds.Width) * 0.975))
					Me.Height = CInt(Math.Round(CDbl(Screen.PrimaryScreen.Bounds.Height) * 0.95))
					Me.Left = CInt(Math.Round(CDbl(Screen.PrimaryScreen.Bounds.Left) + CDbl((Screen.PrimaryScreen.Bounds.Width - Me.Width)) / 2.0))
					If Screen.PrimaryScreen.Bounds.Height > 700 Then
						' The following expression was wrapped in a unchecked-expression
						' The following expression was wrapped in a checked-expression
						Me.Top = CInt(Math.Round(CDbl(Screen.PrimaryScreen.Bounds.Top) + CDbl((Screen.PrimaryScreen.Bounds.Height - Me.Height)) / 2.0))
					End If
				End If
				Me.panStatus.Width = Me.Width - 75
				RSWIN_DESC.gbDemoMode = False
				RSWIN_DESC.gsDemoFile = ""
				Me.bClosing = False
				RSWIN_DESC.bMainClosed = False
				Dim text2 As String = "Type"
				Dim text3 As String = ""
				Dim text4 As String
				Dim regProfileString As Integer = RSWIN.GetRegProfileString(RSWIN_DESC.SECT_SENTINEL, text2, text3, text4, False)
				Dim text5 As String
				If regProfileString > 0 Then
					text5 = text4.Substring(0, regProfileString)
				End If
				Try
					Try
						Dim fileName2 As String
						FILEUTIL.LocateFile(Me.rswin_D_icon, fileName2, 2S, False, False, False, False)
						Dim fileName3 As String
						FILEUTIL.LocateFile(Me.rswin_V_icon, fileName3, 2S, False, False, False, False)
						RSWIN_DESC.RodstarD_Icon = New Icon(fileName2)
						RSWIN_DESC.RodstarV_Icon = New Icon(fileName3)
						If RSWIN_DESC.bExpert Then
							Dim fileName4 As String
							FILEUTIL.LocateFile(Me.xrod_v_icon, fileName4, 2S, False, False, False, False)
							RSWIN_DESC.XRODV_Icon = New Icon(fileName4)
						End If
						RSWIN_DESC.myCurrentRegion = RegionInfo.CurrentRegion
						RSWIN_DESC.myCurrentCulture = CultureInfo.CurrentCulture
						RSWIN_DESC.NumFormatInfo = RSWIN_DESC.myCurrentCulture.NumberFormat
						If RSWIN_DESC.bRodStarD Then
							Me.Icon = RSWIN_DESC.RodstarD_Icon
							Me.btnVertical.Visible = True
							Me.ToolTip1.SetToolTip(Me.btnVertical, "Change to Vertical Mode")
						ElseIf RSWIN_DESC.bExpert Then
							Me.Icon = RSWIN_DESC.XRODV_Icon
							Me.btnVertical.Visible = False
						Else
							Me.Icon = RSWIN_DESC.RodstarV_Icon
							Me.btnVertical.Visible = False
						End If
					Catch ex As Exception
					End Try
					If RSWIN_DESC.bIntVersion Then
						text3 = "Language"
						regProfileString = RSWIN.GetRegProfileString(RSWIN_DESC.SECT_GENERAL, text3, RSWIN_DESC.sEnglish, text4, False)
						RSWIN_DESC.SETUP_Language = text4.Substring(0, regProfileString)
						If RSWIN_DESC.bChangeCultures Then
							Dim setup_Language As String = RSWIN_DESC.SETUP_Language
							If Operators.CompareString(setup_Language, RSWIN_DESC.sEnglish, False) = 0 Then
								RSWIN_DESC.myCulture = New CultureInfo(RSWIN_DESC.sEnglish)
								Me.btnVisualInput.Width = 90
							ElseIf Operators.CompareString(setup_Language, RSWIN_DESC.sSpanish, False) = 0 Then
								RSWIN_DESC.myCulture = New CultureInfo(RSWIN_DESC.sSpanish)
								Me.btnVisualInput.Width = 200
							ElseIf Operators.CompareString(setup_Language, RSWIN_DESC.sChinese, False) = 0 Then
								RSWIN_DESC.myCulture = New CultureInfo(RSWIN_DESC.sChinese)
							Else
								RSWIN_DESC.myCulture = New CultureInfo(RSWIN_DESC.sEnglish)
							End If
							Thread.CurrentThread.CurrentUICulture = RSWIN_DESC.myCulture
						End If
						If RSWIN_DESC.bReadResXFile Then
							If Not RSWIN_DESC.bResxReader Then
								Util.OpenResourceReader()
								Util.ReadResourceResxReader()
								Util.CloseResourceReader()
							End If
							Dim name As String = Me.Name
							Dim sMenu As String = "MainMenu1"
							Dim mainMenu As MainMenu = Me.MainMenu1
							Me.AssignToMainMenu(name, sMenu, mainMenu)
							Me.MainMenu1 = mainMenu
							Util.AssignValuesToControls(Me)
						End If
					End If
				Catch ex2 As Exception
				End Try
				Try
					If RSWIN_DESC.bIntVersion AndAlso RSWIN_DESC.bChangeCultures Then
						RSWIN_DESC.myCulture = New CultureInfo(RSWIN_DESC.sEnglish)
						Thread.CurrentThread.CurrentUICulture = RSWIN_DESC.myCulture
					End If
					If RSWIN_DESC.bRodStarD Then
						RSWIN_DESC.sProgramName = RSWIN_DESC.sProgramNameD
						RSWIN_DESC.sProgramLongName = RSWIN_DESC.sProgramLongNameD
					Else
						RSWIN_DESC.sProgramName = RSWIN_DESC.sProgramNameV
						RSWIN_DESC.sProgramLongName = RSWIN_DESC.sProgramLongNameV
						Me.ToolbarButtonSetState(12, False)
					End If
					Util.BusyCursor()
					RSWIN.App = New CThetaApp()
					RSWIN_DESC.rst = New cRODSTAR()
					Me.Message(" ")
					Me.Enabled = False
					Me.FAboutSplash.bLaunch = True
					Me.FAboutSplash.Show()
					Dim text6 As String
					Try
						text3 = "Version"
						text2 = "Short"
						text6 = ""
						regProfileString = RSWIN.GetRegProfileString(text3, text2, text6, text4, False)
						RSWIN_DESC.sProgramName = text4.Substring(0, regProfileString)
						text6 = "Version"
						text3 = "Long"
						text2 = ""
						regProfileString = RSWIN.GetRegProfileString(text6, text3, text2, text4, False)
						RSWIN_DESC.sProgramLongName = text4.Substring(0, regProfileString)
						RSWIN_DESC.sProgramName = RSWIN_DESC.sProgramName.Replace(RSWIN_DESC.SECT_RSWIN, "RODSTAR")
						RSWIN_DESC.sProgramLongName = RSWIN_DESC.sProgramLongName.Replace(RSWIN_DESC.SECT_RSWIN, "RODSTAR")
					Catch ex3 As Exception
					End Try
					Me.Text = RSWIN_DESC.sProgramName
					Me.InitThetaFile()
					Me.InitHelpFile()
					Me.InitVarsAndControls()
					Me.mnuFileSave.Enabled = False
					Me.mnuFileSaveAs_.Enabled = False
					RSWIN.CheckRegKeys()
					text6 = "Status"
					RSWIN.CheckForKey(text6)
					text6 = "Status"
					text3 = "Sentinel Failure"
					text2 = Conversions.ToString(False)
					RSWIN.WriteRegProfileString(text6, text3, text2, "")
					text6 = "Status"
					text3 = "Checking Sentinel"
					text2 = Conversions.ToString(True)
					RSWIN.WriteRegProfileString(text6, text3, text2, "")
					RSWIN_DESC.bUseTLM32 = False
					Me.mTLM32 = New TLM32()
					Me.mTLM32.StartUpPath = Application.StartupPath
					If RSWIN_DESC.bRodStarD Then
						Me.mTLM32.Product = "15"
					ElseIf RSWIN_DESC.bExpert Then
						Me.mTLM32.Product = "12"
					Else
						Me.mTLM32.Product = "10"
					End If
					RSWIN_DESC.rst.gbAutomaticEnabled = True
					Dim giSentinelNumber As Integer
					If Operators.CompareString(text5, "SUPERPRO", False) = 0 Then
						RSWIN_DESC.bUseTLM32 = False
						RSWIN.InitRODSTAR(giSentinelNumber, RSWIN_DESC.bUseTLM32)
					End If
					If giSentinelNumber = 0 Then
						Try
							Me.mTLM32.GetLicense()
						Catch ex4 As Exception
						End Try
						If Me.mTLM32.ErrNum = 0S Then
							CHECKSN.CheckSN(Conversions.ToInteger(Me.mTLM32.SerialNum))
							RSWIN_DESC.bUseTLM32 = True
						End If
						Dim flag2 As Boolean
						If Operators.CompareString(Me.mTLM32.LicenseType, "inuse", False) = 0 Then
							flag2 = True
						ElseIf Operators.CompareString(Me.mTLM32.LicenseType, "trialexp", False) = 0 Then
							RSWIN_DESC.gbTrialLicenseExpired = True
						End If
						If(Operators.CompareString(Me.mTLM32.LicenseType, "", False) = 0 OrElse flag2) Or RSWIN_DESC.gbTrialLicenseExpired Then
							Me.mTLM32 = Nothing
							Me.mTLM32 = New TLM32()
							RSWIN_DESC.bUseTLM32 = False
							RSWIN.InitRODSTAR(giSentinelNumber, RSWIN_DESC.bUseTLM32)
							If giSentinelNumber = 0 Then
								text6 = "Status"
								text3 = "Sentinel Failure"
								text2 = Conversions.ToString(True)
								RSWIN.WriteRegProfileString(text6, text3, text2, "")
								If flag2 Then
									Util.FatalError("Network License is in use and no local Sentinel was found.")
								End If
							Else
								text6 = "Type"
								text3 = "SUPERPRO"
								RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_SENTINEL, text6, text3, "")
							End If
						Else
							mCbalance_dec.giSentinelNumber = Conversions.ToInteger(Me.mTLM32.SerialNum)
							RSWIN_DESC.gsTrialType = Me.mTLM32.TrialType
							RSWIN.InitRODSTAR(mCbalance_dec.giSentinelNumber, RSWIN_DESC.bUseTLM32)
							giSentinelNumber = mCbalance_dec.giSentinelNumber
							If Operators.CompareString(Me.mTLM32.LicenseType, "sa", False) = 0 Then
								text6 = "Type"
								text3 = "USB-SA"
								RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_SENTINEL, text6, text3, "")
							ElseIf Operators.CompareString(Me.mTLM32.LicenseType, "net", False) = 0 Then
								text6 = "Type"
								text3 = "USB-NET"
								RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_SENTINEL, text6, text3, "")
							End If
						End If
					Else
						CHECKSN.CheckSN(giSentinelNumber)
					End If
					Me.Refresh()
					Application.DoEvents()
					text6 = "Status"
					text3 = "Sentinel Failure"
					Dim regValue As Boolean = RSWIN.GetRegValue(text6, text3)
					If RSWIN_DESC.bCheck4Sentinel AndAlso regValue Then
						Me.ShowFrmDemoMode()
						If RSWIN_DESC.gbDemoMode Then
							RSWIN_DESC.bUseTLM32 = False
							RSWIN.InitRODSTAR(mCbalance_dec.giSentinelNumber, RSWIN_DESC.bUseTLM32)
						Else
							ProjectData.EndApp()
						End If
					End If
					Application.DoEvents()
					text6 = "Status"
					text3 = "Checking Sentinel"
					text2 = Conversions.ToString(False)
					RSWIN.WriteRegProfileString(text6, text3, text2, "")
					text6 = "Status"
					text3 = "Sentinel Failure"
					text2 = Conversions.ToString(False)
					RSWIN.WriteRegProfileString(text6, text3, text2, "")
					text6 = "Status"
					text3 = "Running"
					text2 = Conversions.ToString(False)
					RSWIN.WriteRegProfileString(text6, text3, text2, "")
					Me.FAboutSplash.bLaunch = False
					Me.FAboutSplash.SerialNumber = giSentinelNumber
					If RSWIN_DESC.gbDemoMode Then
						Me.FAboutSplash.lblDemoMode.Visible = True
						If RSWIN_DESC.bRodStarD Then
							Me.FAboutSplash.Text = RSWIN_DESC.sProgramNameD + " - (Demo Version)"
						Else
							Me.FAboutSplash.Text = RSWIN_DESC.sProgramNameV + " - (Demo Version)"
						End If
					ElseIf RSWIN_DESC.bRodStarD Then
						Me.FAboutSplash.Text = RSWIN_DESC.sProgramNameD + " - Found Serial # " + giSentinelNumber.ToString()
					Else
						Me.FAboutSplash.Text = RSWIN_DESC.sProgramNameV + " - Found Serial # " + giSentinelNumber.ToString()
					End If
					Application.DoEvents()
					Me.FAboutSplash.Refresh()
					Me.ShowSplashPage(giSentinelNumber)
					Me.Refresh()
					Application.DoEvents()
					RSWIN_DESC.frmMain = Me
					text6 = "Status"
					text3 = "Running"
					text2 = Conversions.ToString(True)
					RSWIN.WriteRegProfileString(text6, text3, text2, "")
					Dim flag3 As Boolean = Me.CheckDataEntryInProgress()
					Try
						If flag3 And Not(RSWIN_DESC.rst.gbAutomatic And RSWIN_DESC.rst.gbBatch) Then
							Me.ToolbarButtonSetState2(2, False)
							If Not(If(-If(((Information.IsDBNull(RSWIN_DESC.rst.UnitID) Or Operators.CompareString(RSWIN_DESC.rst.UnitID, "          ", False) = 0) > False), 1S, 0S), 1S, 0S) Or RSWIN_DESC.NewData(6)) <> 0S Then
								Me.SetCBMTooltipText()
							End If
						End If
					Catch ex5 As Exception
					End Try
					If flag3 And Not RSWIN_DESC.bNewCaseAsked Then
						Dim text7 As String
						LOADRST.LoadTempDeviationProfile(text7, True)
					End If
					If RSWIN_DESC.bIntVersion Then
						If RSWIN_DESC.bChangeCultures Then
							Dim setup_Language2 As String = RSWIN_DESC.SETUP_Language
							If Operators.CompareString(setup_Language2, RSWIN_DESC.sEnglish, False) = 0 Then
								RSWIN_DESC.myCulture = New CultureInfo(RSWIN_DESC.sEnglish)
							ElseIf Operators.CompareString(setup_Language2, RSWIN_DESC.sSpanish, False) = 0 Then
								RSWIN_DESC.myCulture = New CultureInfo(RSWIN_DESC.sSpanish)
							ElseIf Operators.CompareString(setup_Language2, RSWIN_DESC.sChinese, False) = 0 Then
								RSWIN_DESC.myCulture = New CultureInfo(RSWIN_DESC.sChinese)
							Else
								RSWIN_DESC.myCulture = New CultureInfo(RSWIN_DESC.sEnglish)
							End If
							Thread.CurrentThread.CurrentUICulture = RSWIN_DESC.myCulture
						End If
						If RSWIN_DESC.bReadResXFile Then
							Util.AssignValuesToControls(Me)
						End If
					End If
					Try
						Me.Enabled = True
					Catch ex6 As Exception
					End Try
					Me.InitToolbars()
					If RSWIN_DESC.bIntVersion AndAlso RSWIN_DESC.bWriteResXFile Then
						Util.OpenResourceWriter(Me.Name)
						Util.WriteControlStrings(Me, Me.ToolTip1)
						Util.WriteMainMenuToRexResource(Me.MainMenu1, "MainMenu1")
						Util.WriteContextMenuToRexResource(Me.ContextMenu1)
						Util.WriteContextMenuToRexResource(Me.ctxMenu4ToolBar)
						Util.CloseResourceWriter()
						Util.OpenResourceWriter("Error-Rodstar-MSG")
						Dim num As Integer = 0
						Do
							Dim text8 As String
							Util.LoadMessage(num, text8)
							If Operators.CompareString(text8.Trim(), "", False) <> 0 And Operators.CompareString(text8.Trim(), "Invalid error number.", False) <> 0 Then
								RSWIN_DESC.RwX.AddResource(num.ToString(), text8)
							End If
							num += 1
						Loop While num <= 500
						Util.CloseResourceWriter()
					End If
					Util.UnbusyCursor()
					FILEUTIL.LocateFile(Conversions.ToString(RSWIN_DESC.sRunAVIFileName), fileName, 0S, False, False, False, False)
					Me.AniRun.FileName = fileName
					If RSWIN_DESC.gbDemoMode Then
						RSWIN_DESC.gbDemoShowWellInfo = False
						Dim iFile As Short = -1S
						Dim openFileDialog As OpenFileDialog = Nothing
						text6 = Application.StartupPath + "\" + RSWIN_DESC.gsDemoFile
						Dim flag4 As Boolean = False
						Me.OpenFile(iFile, openFileDialog, text6, flag4)
					Else
						If(RSWIN_DESC.bExpert And RSWIN_DESC.msArgRSTFilePath <> Nothing) AndAlso (LikeOperator.LikeString(Strings.LCase(RSWIN_DESC.msArgRSTFilePath), "*.xrvx", CompareMethod.Binary) And Not RSWIN_DESC.SETUP_bGuru) Then
							RSWIN_DESC.SETUP_bGuru = True
						End If
						If RSWIN_DESC.rst.gbAutomaticEnabled And RSWIN_DESC.mbStartAutoBatch Then
							RSWIN_DESC.mbStartAutoBatchHide = True
							Me.StartAutomaticBatchMode(True)
						ElseIf RSWIN_DESC.msArgRSTFilePath IsNot Nothing AndAlso Operators.CompareString(RSWIN_DESC.msArgRSTFilePath, "", False) <> 0 Then
							Dim iFile2 As Short = -1S
							Dim openFileDialog As OpenFileDialog = Nothing
							Dim flag4 As Boolean = False
							Me.OpenFile(iFile2, openFileDialog, RSWIN_DESC.msArgRSTFilePath, flag4)
							flag = False
						End If
						If RSWIN_DESC.bExpert Then
							Me.PopulateExpertFileFolderNames()
							If Not RSWIN_DESC.SETUP_bGuru Then
								Me.lblGURU.Visible = False
								Me.btnGuru.Visible = False
								Me.tbrGuru.Buttons(0).Pushed = False
								Me.tbrToolbar.Buttons(11).Visible = True
								Me.tbrToolbar.Buttons(13).Visible = True
								Me.tbrToolbar.Buttons(10).Visible = True
								Me.tbrToolbar.Buttons(14).Visible = True
								Me._mnuWindowInput_3.Enabled = True
								Me._mnuWindowInput_4.Enabled = True
								Me._mnuWindowInput_6.Enabled = True
								Me._mnuWindowInput_7.Enabled = True
								Try
									If RSWIN_DESC.bXRODAdmin Then
										GURU_DB.LoadALLGuruFiledata(True)
										RSWIN_DESC.bGuruFileDataLoaded = True
										RSWIN_DESC.bProcessFinished = True
										Me.Message("Total templates: " + Conversions.ToString(RSWIN_DESC.iGuruFileCount) + " , Number Added: " + Conversions.ToString(RSWIN_DESC.iAddedTemplates))
									Else
										Me.StartTemplateLoadProcess()
									End If
									Application.DoEvents()
									GoTo IL_1314
								Catch ex7 As Exception
									GoTo IL_1314
								End Try
							End If
							Me.lblGURU.Left = Me.panStatus.Width - 108
							Me.lblGURU.Height = Me.panStatus.Height
							Me.lblGURU.Top = Me.panStatus.Top
							Me.tbrGuru.Buttons(0).Pushed = True
							Me.btnGuru.Left = Me.lblGURU.Left
							Me.btnGuru.Top = Me.lblGURU.Top - Me.btnGuru.Height
							Me.lblGURU.Visible = True
							FILEUTIL.LocateFile(RSWIN_DESC.sXRODV_Gif_Corner_Filename, text, 0S, False, False, False, False)
							If Operators.CompareString(text, "", False) <> 0 Then
								Me.btnGuru.Text = ""
								Dim image As Bitmap = New Bitmap(text)
								Me.btnGuru.Image = image
							Else
								Me.btnGuru.Text = "AI Mode"
							End If
							Me.btnGuru.Visible = True
							Me.tbrToolbar.Buttons(11).Visible = False
							Me.tbrToolbar.Buttons(13).Visible = False
							Me.tbrToolbar.Buttons(10).Visible = False
							Me.tbrToolbar.Buttons(14).Visible = False
							Me._mnuWindowInput_3.Enabled = False
							Me._mnuWindowInput_4.Enabled = False
							Me._mnuWindowInput_6.Enabled = False
							Me._mnuWindowInput_7.Enabled = False
							Try
								If RSWIN_DESC.bXRODAdmin Then
									GURU_DB.LoadALLGuruFiledata(True)
									RSWIN_DESC.bGuruFileDataLoaded = True
									Me.Message("Total templates: " + Conversions.ToString(RSWIN_DESC.iGuruFileCount) + " , Number Added: " + Conversions.ToString(RSWIN_DESC.iAddedTemplates))
								Else
									Me.StartTemplateLoadProcess()
								End If
								Application.DoEvents()
							Catch ex8 As Exception
							End Try
						End If
					End If
					IL_1314:
					If Not flag3 AndAlso flag Then
						Me.ShowHowToForm()
					End If
					Me.tbrToolbar.Buttons(0).Enabled = True
					Me.tbrToolbar.Buttons(1).Enabled = True
					RSWIN_DESC.sCurrentFormName = ""
				Catch ex9 As Exception
					Util.UnbusyCursor()
				End Try
			Catch ex10 As Exception
			End Try
		End Sub

		Private Sub ShowHowToForm()
			Me.frmHowToStart.Hide()
			Me.frmHowToStart.MdiParent = Me
			Me.frmHowToStart.StartPosition = FormStartPosition.Manual
			Me.frmHowToStart.Left = CInt(Math.Round(CDbl((Me.Width - Me.frmHowToStart.Width)) / 2.0))
			Me.frmHowToStart.Top = CInt(Math.Round(CDbl((Me.Height - Me.frmHowToStart.Height)) / 2.0 - CDbl(Me.pnlToolbar.Height)))
			Application.DoEvents()
			Me.frmHowToStart.Show()
			If RSWIN_DESC.bExpert And RSWIN_DESC.bXRODAdmin Then
				Me.Message("Total templates: " + Conversions.ToString(RSWIN_DESC.iGuruFileCount) + " , Number Added: " + Conversions.ToString(RSWIN_DESC.iAddedTemplates))
			End If
			Me.Refresh()
			Application.DoEvents()
		End Sub

		Private Sub ShowFrmDemoMode()
			Me.frmDemoMode.StartPosition = FormStartPosition.CenterScreen
			Me.frmDemoMode.ShowDialog()
		End Sub

		Private Sub ShowSplashPage(wThetaSerial As Integer)
			Me.FAboutSplash.MinDisplay = 3000
			Me.FAboutSplash.sProgramName = RSWIN_DESC.sProgramName
			Me.FAboutSplash.StartPosition = FormStartPosition.CenterScreen
			If Not RSWIN_DESC.bUseTLM32 Then
				If wThetaSerial > 0 Then
					Me.FAboutSplash.SerialNumber = wThetaSerial
				End If
			ElseIf RSWIN_DESC.bUseTLM32 AndAlso Conversions.ToDouble(Me.mTLM32.SerialNum) > 0.0 Then
				Me.FAboutSplash.SerialNumber = Conversions.ToInteger(Me.mTLM32.SerialNum)
			End If
			Dim faboutSplash As FAboutSplash = Me.FAboutSplash
			Dim text As String = ""
			Dim text2 As String = ""
			faboutSplash.SplashOn(text, text2)
		End Sub

		Private Sub InitHelpFile()
			If Operators.CompareString(RSWIN_DESC.HelpNameSpace, "", False) <> 0 Or RSWIN_DESC.HelpNameSpace <> Nothing Then
				Me.HelpProvider1.HelpNamespace = RSWIN_DESC.HelpNameSpace
			Else
				Dim text As String
				FILEUTIL.LocateFile(RSWIN_DESC.sHelpFile, text, 0S, False, False, False, False)
				If Strings.Len(text) > 0 Then
					RSWIN_DESC.HelpNameSpace = text
					Me.HelpProvider1.HelpNamespace = RSWIN_DESC.HelpNameSpace
				End If
			End If
		End Sub

		Private Sub InitThetaFile()
			Dim text As String = ""
			Dim text2 As String = "DBCleaned"
			Dim text3 As String = ""
			Dim obj As Object = RSWIN.GetRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text3, text, False)
			Dim text4 As String = text.Substring(0, Conversions.ToInteger(obj))
			If Conversions.ToBoolean(Operators.OrObject(Operators.CompareString(text4, "", False) = 0 Or Operators.CompareString(text4, "True", False) <> 0, Operators.CompareObjectEqual(obj, 0, False))) Then
				COSTDB.DBCleanup()
				text3 = "DBCleaned"
				text2 = "True"
				Dim num As Integer = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text3, text2, RSWIN_DESC.sINIFile)
			End If
			text3 = "Initialized"
			text2 = ""
			obj = RSWIN.GetRegProfileString(RSWIN_DESC.SECT_RSWIN, text3, text2, text, False)
			Dim text5 As String = text.Substring(0, Conversions.ToInteger(obj))
			Dim flag As Boolean = False
			If Conversions.ToBoolean(Operators.OrObject(Operators.CompareString(text5, "", False) = 0 Or Operators.CompareString(text5, "True", False) <> 0, Operators.CompareObjectEqual(obj, 0, False))) Then
				flag = True
				If RSWIN_DESC.bExpert Then
					ini.SavePreferenceDataValue("PUManuf_Preference_1", "Lufkin Conventional - New               ")
					ini.SavePreferenceDataValue("PUManuf_Preference_2", "Lufkin Mark II               ")
					ini.SavePreferenceDataValue("Use_PUManuf_Preference_1", True)
					ini.SavePreferenceDataValue("Use_PUManuf_Preference_2", True)
				End If
				text3 = "Initialized"
				text2 = "True"
				Dim num As Integer = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text3, text2, RSWIN_DESC.sINIFile)
			End If
			If flag Then
				RSWIN_DESC.SETUP_PrintData = -1S
				RSWIN_DESC.SETUP_PrintCostAnalysis = -1S
				RSWIN_DESC.SETUP_PrintDiagnosis = -1
				RSWIN_DESC.SETUP_PrintIPR = -1S
				RSWIN_DESC.SETUP_PrintDynoPred = -1S
				RSWIN_DESC.SETUP_PrintDynoActual = -1S
				RSWIN_DESC.SETUP_PrintSinglePageDynoTorque = RSWIN_DESC.SETUP_PrintDynoPred
				RSWIN_DESC.SETUP_PrintTorque = RSWIN_DESC.SETUP_PrintDynoPred
				RSWIN_DESC.SETUP_PrintDevChart = -1S
				RSWIN_DESC.SETUP_PrintGuide = -1S
				RSWIN_DESC.SETUP_ReportDevSurvey = -1S
				RSWIN_DESC.SETUP_SummaryPage = 0S
				RSWIN_DESC.SETUP_ScoringPage = -1S
				RSWIN_DESC.SETUP_CoverPage = 0S
				text3 = "CoverPage"
				text2 = Convert.ToString(RSWIN_DESC.SETUP_CoverPage)
				Dim num As Integer = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text3, text2, RSWIN_DESC.sINIFile)
				text3 = "OrderPage"
				text2 = Convert.ToString(RSWIN_DESC.SETUP_OrderPage)
				num = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text3, text2, RSWIN_DESC.sINIFile)
				text3 = "PrintData"
				text2 = Convert.ToString(RSWIN_DESC.SETUP_PrintData)
				num = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text3, text2, RSWIN_DESC.sINIFile)
				text3 = "PrintDiagnosis"
				text2 = Convert.ToString(RSWIN_DESC.SETUP_PrintDiagnosis)
				num = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text3, text2, RSWIN_DESC.sINIFile)
				text3 = "PrintDynoPred"
				text2 = Convert.ToString(RSWIN_DESC.SETUP_PrintDynoPred)
				num = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text3, text2, RSWIN_DESC.sINIFile)
				text3 = "PrintDynoActual"
				text2 = Convert.ToString(RSWIN_DESC.SETUP_PrintDynoActual)
				num = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text3, text2, RSWIN_DESC.sINIFile)
				text3 = "PrintIPR"
				text2 = Convert.ToString(RSWIN_DESC.SETUP_PrintIPR)
				num = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text3, text2, RSWIN_DESC.sINIFile)
				text3 = "PrintSinglePageDynoTorque"
				text2 = Convert.ToString(RSWIN_DESC.SETUP_PrintDynoPred)
				num = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text3, text2, RSWIN_DESC.sINIFile)
				text3 = "PrintTorque"
				text2 = Convert.ToString(RSWIN_DESC.SETUP_PrintDynoPred)
				num = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text3, text2, RSWIN_DESC.sINIFile)
				text3 = "PrintCostAnalysis"
				text2 = Convert.ToString(RSWIN_DESC.SETUP_PrintCostAnalysis)
				num = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text3, text2, RSWIN_DESC.sINIFile)
				text3 = "PrintDevChart"
				text2 = Convert.ToString(RSWIN_DESC.SETUP_PrintDevChart)
				num = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text3, text2, RSWIN_DESC.sINIFile)
				text3 = "PrintGuide"
				text2 = Convert.ToString(RSWIN_DESC.SETUP_PrintGuide)
				num = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text3, text2, RSWIN_DESC.sINIFile)
				text3 = "ReportDevSurvey"
				text2 = Convert.ToString(RSWIN_DESC.SETUP_ReportDevSurvey)
				num = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text3, text2, RSWIN_DESC.sINIFile)
				text3 = "SummaryPage"
				text2 = Convert.ToString(RSWIN_DESC.SETUP_SummaryPage)
				num = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text3, text2, RSWIN_DESC.sINIFile)
				If RSWIN_DESC.bExpert Then
					text3 = "ScoringPage"
					text2 = Convert.ToString(RSWIN_DESC.SETUP_ScoringPage)
					num = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text3, text2, RSWIN_DESC.sINIFile)
				End If
				RSWIN_DESC.DEBUG_AllowDebugging = False
				RSWIN_DESC.DEBUG_DebugMessages = 0S
				RSWIN_DESC.DEBUG_DisableAutomatic = 0S
				RSWIN_DESC.DEBUG_DisableOnError = 0S
				RSWIN_DESC.DEBUG_FixSinusoidalDyno = 0S
				RSWIN_DESC.DEBUG_NoFIReplaceGoodMatch = 0S
				RSWIN_DESC.DEBUG_RDGFilesFirst = 0S
				RSWIN_DESC.DEBUG_SaveCards = 0S
				RSWIN_DESC.DEBUG_ShowPredictInfo = 0S
				RSWIN_DESC.DEBUG_TreatAsSolidLine = 0S
				ini.SaveDataValue("IncludeBuoyancy", False)
				text3 = "IncludeBuoyancy"
				text2 = "1"
				num = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_DEFAULTS, text3, text2, RSWIN_DESC.sINIFile)
				RSWIN_DESC.DEBUG_PlotAllDownholeCards = False
			End If
			text3 = "InitializedCustomMDB"
			text2 = ""
			obj = RSWIN.GetRegProfileString(RSWIN_DESC.SECT_RSWIN, text3, text2, text, False)
			Dim text6 As String = text.Substring(0, Conversions.ToInteger(obj))
			If Conversions.ToBoolean(Operators.OrObject(Operators.CompareString(text6, "", False) = 0 Or Operators.CompareString(text6, "True", False) <> 0, Operators.CompareObjectEqual(obj, 0, False))) Then
				Dim flag2 As Boolean = FILEUTIL.InitializeCustomMDB()
				Custom.InitializeCustomPumpingUnitLists()
				If flag2 Then
					text3 = "InitializedCustomMDB"
					text2 = "True"
					Dim num As Integer = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text3, text2, RSWIN_DESC.sINIFile)
				End If
			End If
			text3 = "NewInstall"
			text2 = ""
			obj = RSWIN.GetRegProfileString(RSWIN_DESC.SECT_RSWIN, text3, text2, text, False)
			Dim text7 As String = text.Substring(0, Conversions.ToInteger(obj))
			If Conversions.ToBoolean(Operators.OrObject(Operators.CompareString(text7, "", False) = 0 Or Operators.CompareString(text7, "True", False) = 0, Operators.CompareObjectEqual(obj, 0, False))) Then
				text3 = "IncludeBuoyancy"
				text2 = "1"
				Dim num As Integer = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_DEFAULTS, text3, text2, RSWIN_DESC.sINIFile)
				text3 = "NewInstall"
				text2 = "False"
				num = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text3, text2, RSWIN_DESC.sINIFile)
			End If
			text3 = "InitializedFrictionCoefficients"
			text2 = ""
			obj = RSWIN.GetRegProfileString(RSWIN_DESC.SECT_RSWIN, text3, text2, text, False)
			Dim text8 As String = text.Substring(0, Conversions.ToInteger(obj))
			If Conversions.ToBoolean(Operators.OrObject(Operators.CompareString(text8, "", False) = 0 Or Operators.CompareString(text8, "True", False) <> 0, Operators.CompareObjectEqual(obj, 0, False))) Then
				Me.ResetFrictions()
				text3 = "InitializedFrictionCoefficients"
				text2 = "True"
				Dim num As Integer = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text3, text2, RSWIN_DESC.sINIFile)
				Return
			End If
		End Sub

		Private Sub InitVarsAndControls()
			Dim text As String = Conversions.ToString(0)
			MJPred.InitJPred()
			RSWIN.CheckRegKeys()
			RSWIN_DESC.sLastMDIFormName = ""
			Me.bFormLoaded = False
			RSWIN_DESC.StatusControl = Me.panStatus
			Application.DoEvents()
			Me.Refresh()
			Application.DoEvents()
			Me.bFormLoaded = True
			If Operators.ConditionalCompareObjectEqual(RSWIN_DESC.SaveWidth, 0, False) Then
				RSWIN_DESC.SaveWidth = Me.Width
				RSWIN_DESC.SaveHeight = Me.Height
			End If
			If RSWIN_DESC.bExpert Then
				If RSWIN_DESC.SETUP_bGuru Then
					RSWIN_DESC.RECENTFILES = "AI Recent Files"
				Else
					RSWIN_DESC.RECENTFILES = "XRODV Recent Files"
				End If
			End If
			Me.LoadRecentFiles(RSWIN_DESC.sINIFile, RSWIN_DESC.RECENTFILES)
			Me.tbrOpen.DropDownMenu = Me.ctxMenu4ToolBar
			Me.bDisplayBatchFileOutput = False
			If RSWIN_DESC.bRodStarD Then
				Me.tbrRunSpeed.Enabled = Me.tbrRun.Enabled
				Me.tbrRunSpeed.Visible = Me.tbrRun.Visible
			Else
				Me.tbrRunSpeed.Enabled = False
				Me.tbrRunSpeed.Visible = False
			End If
			RSWIN_DESC.rst.gbAutomaticEnabled = True
		End Sub

		Private Sub InitToolbars()
			Me.tbrToolbar.Enabled = False
			Me.tbrToolBar2.Enabled = False
			Me.tbrToolBar3.Enabled = False
			Application.DoEvents()
			Me.tbrToolbar.Enabled = True
			Me.tbrToolBar2.Enabled = True
			Me.tbrToolBar3.Enabled = True
			If Not RSWIN_DESC.rst.gbAutomaticEnabled Then
				Me.tbrToolBar2.Buttons(8).Enabled = False
				Return
			End If
			Me.tbrToolBar2.Buttons(8).Enabled = True
			Me.tbrToolBar2.Buttons(3).Enabled = True
		End Sub

		Public Sub mnuFile_Popup(eventSender As Object, eventArgs As EventArgs)
			Me.mnuFile_Click(RuntimeHelpers.GetObjectValue(eventSender), eventArgs)
		End Sub

		Public Sub mnuFile_Click(eventSender As Object, eventArgs As EventArgs)
			Me.ResetClock()
			Dim num As Short = 1S
			While (RSWIN_DESC.NewData(CInt(num)) And If((-If(((num <> 5S) > False), 1S, 0S)), 1S, 0S)) = 0S
				num += 1S
				If num > 7S Then
					IL_30:
					Me.mnuFileRecentFiles.MenuItems.Clear()
					Dim mnuFileRecentFiles As MenuItem = Me.mnuFileRecentFiles
					Me.LoadRecentFileMenu(mnuFileRecentFiles)
					Me.ResetClock()
					Return
				End If
			End While
			GoTo IL_30
		End Sub

		Private Sub LoadRecentFileMenu(ByRef mnuItem As MenuItem)
			Me.ResetClock()
			mnuItem.MenuItems.Clear()
			Dim obj As Object
			Dim obj2 As Object
			If Me.RecentFileCount() = 0S Then
				Dim menuItem As MenuItem = New MenuItem()
				menuItem.Text = "(none)"
				menuItem.Enabled = False
				mnuItem.MenuItems.Add(menuItem)
			ElseIf ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj, 0, CInt((Me.RecentFileCount() - 1S)), 1, obj2, obj) Then
				Do
					mnuItem.MenuItems.Add(New MenuItem(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("&", Operators.AddObject(obj, 1)), ". "), Me.RecentFileName(Conversions.ToShort(obj)))), AddressOf Me.RecentFile_Clicked, Shortcut.CtrlN))
				Loop While ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj, obj2, obj)
			End If
		End Sub

		Private Sub RecentFile_Clicked(sender As Object, e As EventArgs)
			Dim menuItem As MenuItem = CType(sender, MenuItem)
			Try
				Me.ResetClock()
				If RSWIN_DESC.bExpert Then
					If RSWIN_DESC.SETUP_bGuru Then
						RSWIN_DESC.RECENTFILES = "AI Recent Files"
					Else
						RSWIN_DESC.RECENTFILES = "XRODV Recent Files"
					End If
				End If
				Dim num As Integer = 0
				Dim num2 As Integer = Me.mnuFileRecentFiles.MenuItems.Count - 1
				For i As Integer = num To num2
					If menuItem Is Me.mnuFileRecentFiles.MenuItems(i) Then
						Dim fileNum As Integer = Me.GetFileNum(menuItem.Text)
						If RSWIN_DESC.rst.gbInputDataChanged Then
							Dim msg As String = Me.sARSOVERWRITE
							Dim bDefaultYes As Boolean = True
							Dim flag As Boolean = False
							If Not Util.YesNo(msg, bDefaultYes, flag) Then
								Exit For
							End If
						End If
						Try
							Dim iFile As Short = CShort(fileNum)
							Dim openFileDialog As OpenFileDialog = Nothing
							Dim text As String = ""
							Dim flag As Boolean = False
							Me.OpenFile(iFile, openFileDialog, text, flag)
							Me.SelectRecentFile(fileNum)
							Me.SaveRecentFiles(RSWIN_DESC.RECENTFILES, RSWIN_DESC.sINIFile)
							Me.LoadRecentFiles(RSWIN_DESC.THETA_INI, RSWIN_DESC.RECENTFILES)
							Exit Try
						Catch ex As Exception
							Exit Try
						End Try
					End If
				Next
			Catch ex2 As Exception
			End Try
		End Sub

		Public Sub mnuFileExit_Popup(eventSender As Object, eventArgs As EventArgs)
			Me.mnuFileExit_Click(RuntimeHelpers.GetObjectValue(eventSender), eventArgs)
			Me.ResetClock()
		End Sub

		Public Sub mnuFileImport_Popup(eventSender As Object, eventArgs As EventArgs)
			Me.mnuFileImport_Click(RuntimeHelpers.GetObjectValue(eventSender), eventArgs)
			Me.ResetClock()
		End Sub

		Public Sub mnuFileImport_Click(eventSender As Object, eventArgs As EventArgs)
			Me.ResetClock()
			Me.ImportFile()
		End Sub

		Private Sub ImportFile()
			Dim text As String = "RSW Data"
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			Dim rstdir As String = rst.RSTDir
			Dim text2 As String
			FILEIO.SelectInputFile(text2, rstdir, "Theta import files (*.IMP)|*.IMP", 1, "", "Import File")
			rst.RSTDir = rstdir
			If Strings.Len(text2) > 0 Then
				Dim sINIFile As String = text2
				Dim sSection As String = text
				Dim num2 As Short
				Dim num As Integer = CInt(num2)
				Dim array As String()
				ini.GetPrivateProfileKeyListFromFile(sINIFile, sSection, array, num)
				num2 = CShort(num)
				If num2 = 0S Then
					Dim text3 As String
					Util.LoadMessage(99, text3)
					Dim num3 As Short = CShort(Strings.InStr(text3, "{}", CompareMethod.Binary))
					text3 = text3.Substring(0, CInt((num3 - 1S))) + text2 + Strings.Mid(text3, CInt((num3 + 2S)))
					Util.Errmsg(text3)
				Else
					ini.SaveDataValue(RSWIN_DESC.sNull, DBNull.Value)
					Dim text4 As String = Strings.Space(2560)
					Dim num4 As Short = 0S
					Dim num5 As Short = num2 - 1S

						For num6 As Short = num4 To num5
							Dim text5 As String = text4
							Dim array2 As String() = array
							Dim num7 As Integer = CInt(num6)
							rstdir = ""
							Dim length As Short = CShort(LibWrap.GetPrivateProfileString(text, array2(num7), rstdir, text5, Strings.Len(text5), text2))
							ini.SaveDataValue(array(CInt(num6)), text5.Substring(0, CInt(length)))
						Next
						ini.SaveDataValue("InProgress", True)
						Me.OpenINI(True)
						Me.AddWellInfo(True)
						Me.ToolbarButtonSetState(-2, True)
						Me.ToolbarButtonSetState(16, True)

				End If
				Return
			End If
		End Sub

		Private Function TBFromScreen(iScreenNumber As Integer) As String
			Dim objectValue As Object
			If RSWIN_DESC.bRodStarD Then
				objectValue = RuntimeHelpers.GetObjectValue(Interaction.Choose(CDbl(iScreenNumber), New Object() { 8, 9, 10, 11, 12, 13, 14 }))
			Else
				objectValue = RuntimeHelpers.GetObjectValue(Interaction.Choose(CDbl(iScreenNumber), New Object() { 8, 9, 10, 11, 13, 14, 14 }))
			End If
			Dim result As String
			If Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
				result = Nothing
			Else
				result = Convert.ToString(RuntimeHelpers.GetObjectValue(objectValue))
			End If
			Return result
		End Function

		Private Sub OpenINI(Optional bInProgress As Boolean = False)
			If RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru Then
				If Conversions.ToBoolean(Operators.NotObject(ini.GetDataValue("WellInfo", 11, False, False))) Then
					Me.NewFile(1, bInProgress)
					Return
				End If
				If Conversions.ToBoolean(Operators.NotObject(ini.GetDataValue("ProdInfo", 11, False, False))) Then
					Me.NewFile(2, bInProgress)
					Return
				End If
			ElseIf Conversions.ToBoolean(Operators.NotObject(ini.GetDataValue("WellInfo", 11, False, False))) Then
				Me.NewFile(1, bInProgress)
			ElseIf Conversions.ToBoolean(Operators.NotObject(ini.GetDataValue("ProdInfo", 11, False, False))) Then
				Me.NewFile(2, bInProgress)
			ElseIf Conversions.ToBoolean(Operators.NotObject(ini.GetDataValue("PTInfo", 11, False, False))) Then
				Me.NewFile(3, bInProgress)
			ElseIf Conversions.ToBoolean(Operators.NotObject(ini.GetDataValue("RSInput", 11, False, False))) Then
				Me.NewFile(4, bInProgress)
			ElseIf Conversions.ToBoolean(Operators.NotObject(ini.GetDataValue("PUData", 11, False, False))) Then
				Me.NewFile(6, bInProgress)
			ElseIf Conversions.ToBoolean(Operators.NotObject(ini.GetDataValue("MotorData", 11, False, False))) Then
				Me.NewFile(7, bInProgress)
			Else
				Me.NewFile(8, False)
			End If
		End Sub

		Public Sub mnuFileNew_Popup(eventSender As Object, eventArgs As EventArgs)
			Me.mnuFileNew_Click(RuntimeHelpers.GetObjectValue(eventSender), eventArgs)
		End Sub

		Public Sub mnuFileNew_Click(eventSender As Object, eventArgs As EventArgs)
			Application.DoEvents()
			Dim num As Short = 1S
			Do
				RSWIN_DESC.NewData(CInt(num)) = -1S
				num += 1S
			Loop While num <= 7S
			ini.SaveDataValue("", "")
			ini.SaveDataValue("InProgress", True)
			Me.NewFileClick(True)
		End Sub

		Public Sub mnuFileOpen__Popup(eventSender As Object, eventArgs As EventArgs)
			Me.mnuFileOpen__Click(RuntimeHelpers.GetObjectValue(eventSender), eventArgs)
		End Sub

		Public Sub mnuFileOpen__Click(eventSender As Object, eventArgs As EventArgs)
			Try
				Dim flag As Boolean
				If RSWIN_DESC.rst.gbInputDataChanged Then
					Dim msg As String = Me.sARSOVERWRITE
					Dim bDefaultYes As Boolean = True
					flag = False
					If Not Util.YesNo(msg, bDefaultYes, flag) Then
						Return
					End If
				End If
				If Me.frmHowToStart.Visible Then
					Me.frmHowToStart.Hide()
					Application.DoEvents()
				End If
				Dim iFile As Short = -3S
				Dim openFileDialog As OpenFileDialog = Nothing
				Dim text As String = ""
				flag = False
				Me.OpenFile(iFile, openFileDialog, text, flag)
			Catch ex As Exception
			End Try
		End Sub

		Public Sub mnuFileSave_Popup(eventSender As Object, eventArgs As EventArgs)
			Me.mnuFileSave_Click(RuntimeHelpers.GetObjectValue(eventSender), eventArgs)
		End Sub

		Public Sub mnuFileSave_Click(eventSender As Object, eventArgs As EventArgs)
			Dim bRSVX As Boolean = False
			Dim bXRVX As Boolean = False
			Me.ResetClock()
			If RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru Then
				bXRVX = True
			ElseIf Not RSWIN_DESC.bRodStarD Then
				bRSVX = True
			End If
			Me.SAVEAFILE(False, False, False, False, bRSVX, False, bXRVX)
		End Sub

		Public Sub SAVEAFILE(bAskFirst As Boolean, bRequestName As Boolean, bPDF As Boolean, bRST As Boolean, bRSVX As Boolean, bRSDX As Boolean, bXRVX As Boolean)
			Dim flag As Boolean = False
			Dim flag2 As Boolean = False
			Dim text As String = ""
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
			If RSWIN_DESC.gbDemoMode Then
				MessageBox.Show("Saving the file is not allowed in DEMO MODE.", "DEMO MODE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
				Return
			End If
			If Strings.InStr(RSWIN_DESC.rst.Inputfile.ToLower(), ".xddx", CompareMethod.Binary) > 0 Then
				RSWIN_DESC.rst.Inputfile = RSWIN_DESC.rst.Inputfile.ToLower().Replace(".xddx", "")
			End If
			Dim text2 As String = RSWIN_DESC.sFILETYPE
			Dim sExt As String = RSWIN_DESC.sDOTFILETYPE
			Dim sOTHERFILETYPE As String = RSWIN_DESC.sOTHERFILETYPE
			Dim sDescList As String = RSWIN_DESC.sSelectOutputFileType
			Try
				Dim extension As Boolean
				If bPDF Then
					text2 = "pdf"
					sDescList = RSWIN_DESC.sPDFFileType
					extension = Me.GetExtension(RSWIN_DESC.rst.Inputfile, text2, sOTHERFILETYPE)
				ElseIf bRST Then
					text2 = "rst"
					sDescList = RSWIN_DESC.sRSTFileType
					extension = Me.GetExtension(RSWIN_DESC.rst.Inputfile, text2, sOTHERFILETYPE)
				ElseIf bRSVX Then
					text2 = "rsvx"
					sDescList = RSWIN_DESC.sRSVXFileType
					extension = Me.GetExtension(RSWIN_DESC.rst.Inputfile, text2, sOTHERFILETYPE)
				ElseIf bXRVX Then
					text2 = "xrvx"
					sDescList = RSWIN_DESC.sXRVXFileType
					extension = Me.GetExtension(RSWIN_DESC.rst.Inputfile, text2, sOTHERFILETYPE)
				ElseIf bRSDX Then
					text2 = "rsdx"
					sDescList = RSWIN_DESC.sRSDXFileType
					extension = Me.GetExtension(RSWIN_DESC.rst.Inputfile, text2, sOTHERFILETYPE)
				ElseIf RSWIN_DESC.bRodStarD Then
					sDescList = RSWIN_DESC.sSelectOutputFileType
					If RSWIN_DESC.mdsDeviationProfile Is Nothing Then
						text2 = RSWIN_DESC.sRSVX
						sDescList = RSWIN_DESC.sSelectOutputFileType_wo_RSDX
						extension = Me.GetExtension(RSWIN_DESC.rst.Inputfile, text2, sOTHERFILETYPE)
						sExt = "." + RSWIN_DESC.sRSVX
					ElseIf RSWIN_DESC.mdsDeviationProfile.Tables(0).Rows.Count = 0 Then
						text2 = RSWIN_DESC.sRSVX
						sExt = "." + RSWIN_DESC.sRSVX
						sDescList = RSWIN_DESC.sSelectOutputFileType
						extension = Me.GetExtension(RSWIN_DESC.rst.Inputfile, text2, sOTHERFILETYPE)
					Else
						text2 = RSWIN_DESC.sRSDX
						sExt = "." + RSWIN_DESC.sRSDX
						extension = Me.GetExtension(RSWIN_DESC.rst.Inputfile, text2, sOTHERFILETYPE)
					End If
				Else
					text2 = RSWIN_DESC.sRSVX
					sExt = "." + RSWIN_DESC.sRSVX
					extension = Me.GetExtension(RSWIN_DESC.rst.Inputfile, text2, sOTHERFILETYPE)
				End If
				If(RSWIN_DESC.rst.Inputfile.Length <> 0 And Operators.CompareString(RSWIN_DESC.rst.Inputfile, "(Untitled)", False) <> 0) AndAlso extension Then
					text = Util.FileName(RSWIN_DESC.rst.Inputfile.Replace("." + sOTHERFILETYPE, "." + text2))
				End If
			Catch ex2 As Exception
			End Try
			If bAskFirst Then
				Dim msg As String = Me.sDYWSaveToDisk
				Dim bDefaultYes As Boolean = True
				Dim flag3 As Boolean = False
				If Not Util.YesNo(msg, bDefaultYes, flag3) Then
					Return
				End If
			End If
			Dim text3 As String
			If RSWIN_DESC.rst.Inputfile.Length = 0 Or Operators.CompareString(RSWIN_DESC.rst.Inputfile, "(Untitled)", False) = 0 Then
				If Not bPDF Then
					FILEIO.MakeFileName(text3, sExt)
				Else
					FILEIO.MakeFileName(text3, ".pdf")
				End If
				bRequestName = True
			ElseIf Operators.CompareString(text, "", False) <> 0 Then
				text3 = text
			Else
				text = RSWIN_DESC.rst.Inputfile
				text3 = text
			End If
			If bRequestName Then
				RSWIN_DESC.rst.RSTDir = Conversions.ToString(RSWIN.GetInitialDir(sExt, ""))
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				Dim rstdir As String = rst.RSTDir
				Dim flag4 As Boolean = FILEIO.SelectOutputFile(text3, rstdir, sDescList, text3, text2, "Save File As")
				rst.RSTDir = rstdir
				If Not flag4 Then
					text3 = ""
				End If
			End If
			If(If((-If((Strings.InStr(text3, ".PDF", CompareMethod.Binary) > 0 > False), 1, 0)), 1, 0) Or Strings.InStr(text3, ".pdf", CompareMethod.Binary)) <> 0 Then
				Dim results As Results = New Results()
				Util.BusyCursor()
				Dim msgtxt As String = "Saving results to " + text3
				Me.Message(msgtxt)
				Dim formName As String = "Results"
				Dim form As Form = results
				Dim flag5 As Boolean = Me.ReturnMdiForm(formName, form)
				results = CType(form, Results)
				If Not flag5 Then
					Me.AddResults(False)
					Dim formName2 As String = "Results"
					form = results
					Me.ReturnMdiForm(formName2, form)
					results = CType(form, Results)
				End If
				RSWIN_DESC.bPDFFileSaved = False
				results.StorePDFFile(text3)
				While Not RSWIN_DESC.bPDFFileSaved
					Application.DoEvents()
				End While
				Util.UnbusyCursor()
				msgtxt = "Results saved to " + text3
				Me.Message(msgtxt)
				Return
			End If
			If Strings.Len(text3) > 0 Then
				Me.Message("Storing..")
				Util.BusyCursor()
				Dim flag7 As Boolean
				If Strings.InStr(text3.ToLower(), ".rsvx", CompareMethod.Binary) > 0 Or Strings.InStr(text3.ToLower(), ".rsdx", CompareMethod.Binary) > 0 Or (Strings.InStr(text3.ToLower(), ".xrvx", CompareMethod.Binary) > 0 And RSWIN_DESC.SETUP_bGuru) Then
					If FILEUTIL.FileExists(text3) Then
						FileSystem.Kill(text3)
					End If
					Dim flag6 As Boolean = MRodstarXML.StoreXML(text3, RSWIN_DESC.rst.gbOutputLoaded, flag, flag2)
					If Not flag6 And (RSWIN_DESC.rst.gbOutputLoaded And Not flag2) Then
						If FILEUTIL.FileExists(text3) Then
							FileSystem.Kill(text3)
						End If
						flag6 = MRodstarXML.StoreXML(text3, False, flag, flag2)
					End If
					flag7 = flag6
				ElseIf Strings.InStr(text3.ToLower(), ".rst", CompareMethod.Binary) <> 0 Then
					SAVEFILE.StoreFile(text3, RSWIN_DESC.rst.gbOutputLoaded, flag7)
				End If
				Util.UnbusyCursor()
				Me.Message(RSWIN_DESC.sNull)
				If flag7 Then
					If Not bPDF Then
						RSWIN_DESC.rst.Inputfile = text3
						Me.AddRecentFile(RSWIN_DESC.rst.Inputfile)
						Me.SetCaption(RSWIN_DESC.rst.Inputfile)
						Me.Message(text3 + " stored to disk.")
						RSWIN_DESC.rst.gbInputDataChanged = False
						ini.SaveDataValue("InProgress", DBNull.Value)
						RSWIN.ReCreateRegKey(RSWIN_DESC.SECT_DATAENTRY)
						Dim num As Integer = 1
						Do
							RSWIN_DESC.NewData(num) = 0S
							num += 1
						Loop While num <= 7
					Else
						Me.SetCaption(text)
					End If
					If Not RSWIN_DESC.rst.gbAutomatic Then
						Me.tbrToolBar2.Buttons(3).Enabled = True
					End If
				End If
			End If
			If RSWIN_DESC.bXRODAdmin And RSWIN_DESC.bExpert And Not RSWIN_DESC.SETUP_bGuru And Strings.InStr(text3.ToLower(), ".rsvx", CompareMethod.Binary) > 0 Then
				Me.mnuToolsUploadRSVXFile.PerformClick()
			End If
		End Sub

		Public Sub mnuFileSaveAsPDF__Popup(eventSender As Object, eventArgs As EventArgs)
			Me.mnuFileSaveAsPDF__Click(RuntimeHelpers.GetObjectValue(eventSender), eventArgs)
		End Sub

		Public Sub mnuFileSaveAsPDF__Click(eventSender As Object, eventArgs As EventArgs)
			Me.ResetClock()
			Me.SAVEAFILE(False, True, True, False, False, False, False)
		End Sub

		Public Sub SelectRecentFile(iFile As Integer)
			Dim text As String = Me.asRecentFiles(iFile)
			For i As Integer = iFile To 1 Step -1
				Me.asRecentFiles(i) = Me.asRecentFiles(i - 1)
			Next
			Me.asRecentFiles(0) = text
		End Sub

		Private Sub TreeView1_AfterExpand(sender As Object, e As TreeViewEventArgs)
			Dim node As TreeNode = e.Node
			Me.SetNodeSettings(node)
		End Sub

		Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs)
			Dim node As TreeNode = e.Node
			Me.SetNodeSettings(node)
		End Sub

		Private Sub SetNodeSettings(ByRef nodeExpanding As TreeNode)
			Dim rswinSetup As RswinSetup = New RswinSetup()
			Dim text As String = nodeExpanding.Text
			Dim text2 As String = text
			If Operators.CompareString(text2, "Options", False) = 0 Then
				Me.RemoveForms()
				Me.DisableMe()
				Me.RemoveChildForm("Results", False)
				Dim rswinSetup2 As RswinSetup = rswinSetup
				Me.ResizeRswinsetup(rswinSetup)
				rswinSetup2.ShowDialog()
				If Operators.CompareString(Me.SAVE_SETUP_Language, RSWIN_DESC.SETUP_Language, False) <> 0 And RSWIN_DESC.bIntVersion Then
					Me.RemoveAllChildForms(True)
					If RSWIN_DESC.bChangeCultures Then
						Dim setup_Language As String = RSWIN_DESC.SETUP_Language
						If Operators.CompareString(setup_Language, RSWIN_DESC.sEnglish, False) = 0 Then
							RSWIN_DESC.myCulture = New CultureInfo(RSWIN_DESC.sEnglish)
							Me.btnVisualInput.Width = 90
						ElseIf Operators.CompareString(setup_Language, RSWIN_DESC.sSpanish, False) = 0 Then
							RSWIN_DESC.myCulture = New CultureInfo(RSWIN_DESC.sSpanish)
							Me.btnVisualInput.Width = 200
						ElseIf Operators.CompareString(setup_Language, RSWIN_DESC.sChinese, False) = 0 Then
							RSWIN_DESC.myCulture = New CultureInfo(RSWIN_DESC.sChinese)
						Else
							RSWIN_DESC.myCulture = New CultureInfo(RSWIN_DESC.sEnglish)
						End If
						Thread.CurrentThread.CurrentUICulture = RSWIN_DESC.myCulture
					End If
					If RSWIN_DESC.bReadResXFile Then
						Dim name As String = Me.Name
						Dim sMenu As String = "MainMenu1"
						Dim mainMenu As MainMenu = Me.MainMenu1
						Me.AssignToMainMenu(name, sMenu, mainMenu)
						Me.MainMenu1 = mainMenu
						Util.AssignValuesToControls(Me)
						Me.ReassignVariables()
					End If
					Me.btnAlpha.Left = Me.btnVisualInput.Left + Me.btnVisualInput.Width + 5
				End If
				Me.EnableMe()
			ElseIf Operators.CompareString(text2, "Well Information", False) = 0 Then
				Me.AddWellInfo(True)
			ElseIf Operators.CompareString(text2, "Production Information", False) = 0 Then
				Me.AddProdInfo(True)
			ElseIf Operators.CompareString(text2, "Pump And Tubing Information", False) = 0 Then
				Me.AddPTInfo(True)
			ElseIf Operators.CompareString(text2, "Rod String Information", False) = 0 Then
				Me.AddRSInput(True, False)
			ElseIf Operators.CompareString(text2, "Pumping Unit Information", False) = 0 Then
				Me.AddPUData(True)
			ElseIf Operators.CompareString(text2, "Motor Information", False) = 0 Then
				Me.AddMotorData(True)
			End If
		End Sub

		Private Sub btnVisualInput_Click(sender As Object, e As EventArgs)
			Me.ResetClock()
			If Me.m_VisualInput Then
				Me.m_VisualInput = False
				Me.AddVisInput(False, False)
			Else
				Me.m_VisualInput = True
				Me.AddVisInput(True, False)
			End If
		End Sub

		Public Property CurrentChildForm As String
			Get
				Return Me.m_CurrentChildForm
			End Get
			Set(value As String)
				Me.m_CurrentChildForm = value
			End Set
		End Property

		Public Property CurrentChildFormField As String
			Get
				Return Me.m_CurrentChildFormField
			End Get
			Set(value As String)
				Me.m_CurrentChildFormField = value
			End Set
		End Property

		Private Sub _mnuWindowInput_1_Click(sender As Object, e As EventArgs)
			Me.AddWellInfo(True)
		End Sub

		Private Sub _mnuWindowInput_2_Click(sender As Object, e As EventArgs)
			Me.AddProdInfo(True)
		End Sub

		Private Sub _mnuWindowInput_3_Click(sender As Object, e As EventArgs)
			Me.AddPTInfo(True)
		End Sub

		Private Sub _mnuWindowInput_4_Click(sender As Object, e As EventArgs)
			Me.AddRSInput(True, False)
		End Sub

		Private Sub _mnuWindowInput_5_Click(sender As Object, e As EventArgs)
			Me.AddDeviationProfile(True)
		End Sub

		Private Sub _mnuWindowInput_6_Click(sender As Object, e As EventArgs)
			Me.AddPUData(True)
		End Sub

		Private Sub _mnuWindowInput_7_Click(sender As Object, e As EventArgs)
			Me.AddMotorData(True)
		End Sub

		Private Sub mnuFileExit_Click(sender As Object, e As EventArgs)
			Try
				Me.ResetClock()
				Me.bClosing = True
				If Me.SaveBeforeExit() <> 0 Then
					Me.ExitProgram()
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub ExitProgram()
			Me.Close()
			ProjectData.EndApp()
		End Sub

		Public Sub mnuEdit_Popup(eventSender As Object, eventArgs As EventArgs)
			Me.mnuEdit_Click(RuntimeHelpers.GetObjectValue(eventSender), eventArgs)
		End Sub

		Public Sub mnuEdit_Click(eventSender As Object, eventArgs As EventArgs)
			Dim dataObject As DataObject = New DataObject()
			dataObject = CType(Clipboard.GetDataObject(), DataObject)
			Me.ResetClock()
			Try
				If Me.ActiveMdiChild.ActiveControl IsNot Nothing Then
					Dim activeControl As Control = Me.ActiveMdiChild.ActiveControl
					Dim num As Short = 0S
					Dim num2 As Short = 0S
					Dim num3 As Short = 0S
					Dim num4 As Short = 0S
					If activeControl IsNot Nothing AndAlso TypeOf activeControl Is TextBox Then
						Dim textBox As TextBox = New TextBox()
						textBox = CType(activeControl, TextBox)
						num = If((-If((Not textBox.SelectedText.Equals("") > False), 1S, 0S)), 1S, 0S)
						num2 = If((-If((Not textBox.SelectedText.Equals("") > False), 1S, 0S)), 1S, 0S)
						If dataObject.GetDataPresent(DataFormats.Rtf) Or dataObject.GetDataPresent(DataFormats.Text) Then
							num3 = -1S
						Else
							num3 = 0S
						End If
						num4 = -1S
					End If
					Me.mnuEditUndo.Enabled = (num4 <> 0S)
					Me.mnuEditCut.Enabled = (num2 <> 0S)
					Me.mnuEditCopy.Enabled = (num <> 0S)
					Me.mnuEditPaste.Enabled = (num3 <> 0S)
					Me.mnuEditDelete.Enabled = (num3 <> 0S)
				End If
			Catch ex As Exception
			End Try
		End Sub

		Public Sub mnuEditCopy_Popup(eventSender As Object, eventArgs As EventArgs)
			Me.mnuEditCopy_Click(RuntimeHelpers.GetObjectValue(eventSender), eventArgs)
		End Sub

		Public Sub mnuEditCopy_Click(eventSender As Object, eventArgs As EventArgs)
			Me.ResetClock()
			Dim activeControl As Control = Me.ActiveMdiChild.ActiveControl
			If TypeOf activeControl Is TextBox Then
				Dim textBox As TextBox = CType(activeControl, TextBox)
				Clipboard.SetDataObject(textBox.SelectedText, True)
			ElseIf TypeOf activeControl Is PictureBox Then
				Dim pictureBox As PictureBox = CType(activeControl, PictureBox)
				Clipboard.SetDataObject(pictureBox.Image, True)
			End If
		End Sub

		Public Sub mnuEditCut_Popup(eventSender As Object, eventArgs As EventArgs)
			Me.mnuEditCut_Click(RuntimeHelpers.GetObjectValue(eventSender), eventArgs)
		End Sub

		Public Sub mnuEditCut_Click(eventSender As Object, eventArgs As EventArgs)
			Me.ResetClock()
			Dim activeControl As Control = Me.ActiveMdiChild.ActiveControl
			If TypeOf activeControl Is TextBox Then
				Dim textBox As TextBox = CType(activeControl, TextBox)
				Clipboard.SetDataObject(textBox.SelectedText, True)
				textBox.SelectedText = ""
			End If
		End Sub

		Public Sub mnuEditDelete_Popup(eventSender As Object, eventArgs As EventArgs)
			Me.mnuEditDelete_Click(RuntimeHelpers.GetObjectValue(eventSender), eventArgs)
		End Sub

		Public Sub mnuEditDelete_Click(eventSender As Object, eventArgs As EventArgs)
			Me.ResetClock()
			Dim activeControl As Control = Me.ActiveMdiChild.ActiveControl
			If TypeOf activeControl Is TextBox Then
				Dim textBox As TextBox = CType(activeControl, TextBox)
				Clipboard.SetDataObject(textBox.SelectedText, True)
				textBox.SelectedText = ""
			End If
		End Sub

		Public Sub mnuEditPaste_Popup(eventSender As Object, eventArgs As EventArgs)
			Me.mnuEditPaste_Click(RuntimeHelpers.GetObjectValue(eventSender), eventArgs)
		End Sub

		Public Sub mnuEditPaste_Click(eventSender As Object, eventArgs As EventArgs)
			Me.ResetClock()
			Dim activeControl As Control = Me.ActiveMdiChild.ActiveControl
			Dim dataObject As DataObject = CType(Clipboard.GetDataObject(), DataObject)
			If TypeOf activeControl Is TextBox And Operators.CompareString(RSWIN_DESC.sCurrentFormName, "DeviationProfile", False) <> 0 Then
				Dim textBox As TextBox = CType(activeControl, TextBox)
				textBox.Text = Conversions.ToString(dataObject.GetData(DataFormats.Text))
				Return
			End If
			If Operators.CompareString(RSWIN_DESC.sCurrentFormName, "DeviationProfile", False) = 0 Then
				Dim text As String = Conversions.ToString(dataObject.GetData(DataFormats.Text))
				Dim formName As String = "DeviationProfile"
				Dim deviationProfile As DeviationProfile
				Dim form As Form = deviationProfile
				Dim flag As Boolean = Me.ReturnMdiForm(formName, form)
				deviationProfile = CType(form, DeviationProfile)
				Dim flag2 As Boolean = flag
				If flag2 AndAlso (Strings.InStr(text, vbTab, CompareMethod.Binary) > 0 Or Strings.InStr(text, vbVerticalTab, CompareMethod.Binary) > 0 Or Strings.InStr(text, vbCr, CompareMethod.Binary) > 0) Then
					deviationProfile.ImportToGridPasteString(text)
				End If
				Return
			End If
		End Sub

		Public Sub mnuEditUndo_Popup(eventSender As Object, eventArgs As EventArgs)
			Me.mnuEditUndo_Click(RuntimeHelpers.GetObjectValue(eventSender), eventArgs)
		End Sub

		Public Sub mnuEditUndo_Click(eventSender As Object, eventArgs As EventArgs)
			Me.ResetClock()
			Dim activeControl As Control = Me.ActiveMdiChild.ActiveControl
			If TypeOf activeControl Is TextBox Then
				Dim textBox As TextBox = CType(activeControl, TextBox)
				textBox.Undo()
			End If
		End Sub

		Public Sub mnuRun_Popup(eventSender As Object, eventArgs As EventArgs)
			Me.mnuRun_Click(RuntimeHelpers.GetObjectValue(eventSender), eventArgs)
		End Sub

		Public Sub mnuRun_Click(eventSender As Object, eventArgs As EventArgs)
			RSWIN_DESC.SETUP_RunForSpeed = 0S
			Me.ResetClock()
			Me.mnuRunPrediction_Click(True)
		End Sub

		Private Sub OpenFile(iFile As Short, Optional ByRef OpenDialog As OpenFileDialog = Nothing, Optional ByRef rfn As String = "", Optional ByRef bDisplayed As Boolean = False)
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
			RSWIN_DESC.mdsDeviationProfile_Edit = Nothing
			RSWIN_DESC.mdsDeviationProfile = Nothing
			RSWIN_DESC.bReadingFile = True
			If RSWIN_DESC.bIntVersion AndAlso RSWIN_DESC.bChangeCultures Then
				RSWIN_DESC.myCulture = New CultureInfo(RSWIN_DESC.sEnglish)
				Thread.CurrentThread.CurrentUICulture = RSWIN_DESC.myCulture
			End If
			Select Case iFile
				Case -2S
					Dim flag As Boolean
					If Strings.Len(rfn) > 0 Then
						Dim rst As cRODSTAR = RSWIN_DESC.rst
						Dim gbInputDataChanged As Boolean = rst.gbInputDataChanged
						Dim cursor As Cursor
						Me.LoadOneFile(cursor, rfn, flag, gbInputDataChanged, False)
						rst.gbInputDataChanged = gbInputDataChanged
						Me.AddRecentFile(rfn)
						Me.SetCaption(RSWIN_DESC.rst.Inputfile)
					End If
					If flag And RSWIN_DESC.rst.gbOutputLoaded Then
						bDisplayed = True
						Me.mnuWindowViewReport_Click(Me.mnuWindowViewReport, New EventArgs())
					Else
						bDisplayed = False
					End If
				Case -1S
					If Strings.Len(rfn) > 0 Then
						Dim rst As cRODSTAR = RSWIN_DESC.rst
						Dim gbInputDataChanged As Boolean = rst.gbInputDataChanged
						Dim cursor As Cursor
						Dim flag As Boolean
						Me.LoadOneFile(cursor, rfn, flag, gbInputDataChanged, False)
						rst.gbInputDataChanged = gbInputDataChanged
						If RSWIN_DESC.gbDemoMode AndAlso Strings.InStr(RSWIN_DESC.rst.UserName, "Demo", CompareMethod.Binary) < 1 Then
							Dim sMsg As String = "Error in OpenFile: This is not a Demo File."
							Dim sMsgType As String = ""
							Dim bClosing As Boolean = False
							Dim dialogResult As DialogResult = DialogResult.OK
							Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
							ProjectData.EndApp()
						End If
					End If
				Case 0S, 1S, 2S, 3S, 4S, 5S, 6S, 7S, 8S, 9S, 10S, 11S, 12S, 13S, 14S, 15S, 16S, 17S, 18S, 19S
					rfn = Me.RecentFileName(iFile)
					If Strings.Len(rfn) > 0 Then
						Dim rst As cRODSTAR = RSWIN_DESC.rst
						Dim gbInputDataChanged As Boolean = rst.gbInputDataChanged
						Dim cursor As Cursor
						Dim flag As Boolean
						Me.LoadOneFile(cursor, rfn, flag, gbInputDataChanged, False)
						rst.gbInputDataChanged = gbInputDataChanged
						If flag Then
							If RSWIN_DESC.SETUP_bGuru Then
								If Strings.InStr(rfn, ".rdg", CompareMethod.Binary) > 0 Then
									RSWIN_DESC.rst.Inputfile = rfn.Replace(".rdg", ".xrvx")
								ElseIf Strings.InStr(rfn, ".RDG", CompareMethod.Binary) > 0 Then
									RSWIN_DESC.rst.Inputfile = rfn.Replace(".RDG", ".xrvx")
								ElseIf Strings.InStr(rfn, ".xdg", CompareMethod.Binary) > 0 Then
									RSWIN_DESC.rst.Inputfile = rfn.Replace(".xdg", ".xrvx")
								ElseIf Strings.InStr(rfn, ".XDG", CompareMethod.Binary) > 0 Then
									RSWIN_DESC.rst.Inputfile = rfn.Replace(".XDG", ".xrvx")
								End If
							ElseIf Strings.InStr(rfn, ".rdg", CompareMethod.Binary) > 0 Then
								RSWIN_DESC.rst.Inputfile = rfn.Replace(".rdg", ".rsvx")
							ElseIf Strings.InStr(rfn, ".RDG", CompareMethod.Binary) > 0 Then
								RSWIN_DESC.rst.Inputfile = rfn.Replace(".RDG", ".rsvx")
							ElseIf Strings.InStr(rfn, ".xdg", CompareMethod.Binary) > 0 Then
								RSWIN_DESC.rst.Inputfile = rfn.Replace(".xdg", ".rsvx")
							ElseIf Strings.InStr(rfn, ".XDG", CompareMethod.Binary) > 0 Then
								RSWIN_DESC.rst.Inputfile = rfn.Replace(".XDG", ".rsvx")
							ElseIf Not RSWIN_DESC.bRodStarD And Strings.InStr(RSWIN_DESC.rst.Inputfile, "." + RSWIN_DESC.sOTHERFILETYPE, CompareMethod.Binary) > 0 Then
								RSWIN_DESC.rst.Inputfile = RSWIN_DESC.rst.Inputfile.Replace("." + RSWIN_DESC.sOTHERFILETYPE, "." + RSWIN_DESC.sFILETYPE)
							ElseIf Not RSWIN_DESC.bRodStarD And Strings.InStr(RSWIN_DESC.rst.Inputfile, "." + RSWIN_DESC.sOTHERFILETYPE.ToUpper(), CompareMethod.Binary) > 0 Then
								RSWIN_DESC.rst.Inputfile = RSWIN_DESC.rst.Inputfile.Replace("." + RSWIN_DESC.sOTHERFILETYPE.ToUpper(), "." + RSWIN_DESC.sFILETYPE)
							Else
								RSWIN_DESC.rst.Inputfile = rfn
							End If
							Me.SetCaption(RSWIN_DESC.rst.Inputfile)
							Try
								Dim text As String = ""
								Dim rstdir As String = ""
								Dim text2 As String
								Dim text3 As String
								FILEIO.SplitPath(rfn, text2, text3, text, rstdir)
								rst = RSWIN_DESC.rst
								rstdir = rst.RSTDir
								text = ""
								Dim rstdir2 As String = ""
								FILEIO.MakePath(rstdir, text2, text3, text, rstdir2)
								rst.RSTDir = rstdir
								rstdir2 = "DefaultFolderRST"
								rst = RSWIN_DESC.rst
								rstdir = rst.RSTDir
								RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_FOLDER_DEFAULTS, rstdir2, rstdir, RSWIN_DESC.sINIFile)
								rst.RSTDir = rstdir
							Catch ex2 As Exception
							End Try
							If Not RSWIN_DESC.rst.gbAutomatic And Not RSWIN_DESC.rst.gbBatch Then
								Me.RemoveChildForm("Results", False)
								If RSWIN_DESC.bRodStarD Then
									If Strings.InStr(rfn.ToLower(), ".rsvx", CompareMethod.Binary) > 0 Then
										Dim msg As String = "Switch to Vertical Mode?"
										Dim bDefaultYes As Boolean = False
										gbInputDataChanged = False
										If Util.YesNo(msg, bDefaultYes, gbInputDataChanged) Then
											Me.btnVertical.PerformClick()
										End If
									End If
								ElseIf Operators.CompareString(RSWIN_DESC.sRodstarVorD, "RODSTARD", False) = 0 AndAlso Strings.InStr(rfn.ToLower(), ".rsdx", CompareMethod.Binary) > 0 Then
									Dim msg2 As String = "Switch to Deviated Mode?"
									Dim bDefaultYes2 As Boolean = False
									gbInputDataChanged = False
									If Util.YesNo(msg2, bDefaultYes2, gbInputDataChanged) Then
										Me.btnVertical.PerformClick()
									End If
								End If
							End If
						End If
					End If
				Case Else
					Dim sDescList As String = Conversions.ToString(RSWIN_DESC.sAllTypes)
					Dim rst As cRODSTAR = RSWIN_DESC.rst
					Dim rstdir2 As String = rst.RSTDir
					Dim array As String()
					Dim num As Short
					Dim sDefaultBatchFolder As String
					FILEIO.SelectInputFiles(array, num, rstdir2, sDescList, 1, "", "Open Data File", sDefaultBatchFolder)
					rst.RSTDir = rstdir2
					If iFile = -3S Then
						If RSWIN_DESC.bExpert Then
							If num >= 1S Then
								rfn = array(0)
								If Not RSWIN_DESC.SETUP_bGuru Then
									If Strings.InStr(rfn.ToLower(), ".xrvx", CompareMethod.Binary) > 0 Then
										Dim msg3 As String = "Switch to AI mode?"
										Dim bDefaultYes3 As Boolean = False
										Dim gbInputDataChanged As Boolean = False
										If Util.YesNo(msg3, bDefaultYes3, gbInputDataChanged) Then
											Me.btnGuruChanged()
										End If
									End If
								ElseIf Strings.InStr(rfn.ToLower(), ".rsvx", CompareMethod.Binary) > 0 Or Strings.InStr(rfn.ToLower(), ".rsdx", CompareMethod.Binary) > 0 Then
									Dim msg4 As String = "Switch to non-AI mode?"
									Dim bDefaultYes4 As Boolean = False
									Dim gbInputDataChanged As Boolean = False
									If Util.YesNo(msg4, bDefaultYes4, gbInputDataChanged) Then
										Me.btnGuruChanged()
										If num > 1S Then
											Dim msg5 As String = "Multiple files were selected. Execute Batch?"
											Dim bDefaultYes5 As Boolean = False
											gbInputDataChanged = False
											If Not Util.YesNo(msg5, bDefaultYes5, gbInputDataChanged) Then
												num = 1S
											End If
										End If
									End If
								End If
							End If
						ElseIf RSWIN_DESC.bRodStarD Then
							If num >= 1S Then
								rfn = array(0)
								If Strings.InStr(rfn.ToLower(), ".rsvx", CompareMethod.Binary) > 0 And Not RSWIN_DESC.rst.gbBatch And Not RSWIN_DESC.rst.gbAutomatic Then
									Dim msg6 As String = "Switch to Vertical Mode?"
									Dim bDefaultYes6 As Boolean = False
									Dim gbInputDataChanged As Boolean = False
									If Util.YesNo(msg6, bDefaultYes6, gbInputDataChanged) Then
										Me.btnVertical.PerformClick()
									End If
								End If
							End If
						ElseIf Operators.CompareString(RSWIN_DESC.sRodstarVorD, "RODSTARD", False) = 0 AndAlso num >= 1S Then
							rfn = array(0)
							If Strings.InStr(rfn.ToLower(), ".rsdx", CompareMethod.Binary) > 0 And Not RSWIN_DESC.rst.gbBatch And Not RSWIN_DESC.rst.gbAutomatic Then
								Dim msg7 As String = "Switch to Deviated Mode?"
								Dim bDefaultYes7 As Boolean = False
								Dim gbInputDataChanged As Boolean = False
								If Util.YesNo(msg7, bDefaultYes7, gbInputDataChanged) Then
									Me.btnVertical.PerformClick()
								End If
							End If
						End If
					End If
					If num = 1S Then
						rfn = array(0)
						rst = RSWIN_DESC.rst
						Dim gbInputDataChanged As Boolean = rst.gbInputDataChanged
						Dim cursor As Cursor
						Dim flag As Boolean
						Me.LoadOneFile(cursor, rfn, flag, gbInputDataChanged, False)
						rst.gbInputDataChanged = gbInputDataChanged
						If flag Then
							If Strings.InStr(rfn, ".rdg", CompareMethod.Binary) > 0 Then
								RSWIN_DESC.rst.Inputfile = rfn.Replace(".rdg", ".rsvx")
							ElseIf Strings.InStr(rfn, ".RDG", CompareMethod.Binary) > 0 Then
								RSWIN_DESC.rst.Inputfile = rfn.Replace(".RDG", ".rsvx")
							ElseIf Strings.InStr(rfn, ".xdg", CompareMethod.Binary) > 0 Then
								RSWIN_DESC.rst.Inputfile = rfn.Replace(".xdg", ".rsvx")
							ElseIf Strings.InStr(rfn, ".XDG", CompareMethod.Binary) > 0 Then
								RSWIN_DESC.rst.Inputfile = rfn.Replace(".XDG", ".rsvx")
							ElseIf Not RSWIN_DESC.bRodStarD And Strings.InStr(RSWIN_DESC.rst.Inputfile, "." + RSWIN_DESC.sOTHERFILETYPE, CompareMethod.Binary) > 0 Then
								RSWIN_DESC.rst.Inputfile = RSWIN_DESC.rst.Inputfile.Replace("." + RSWIN_DESC.sOTHERFILETYPE, "." + RSWIN_DESC.sFILETYPE)
							ElseIf Not RSWIN_DESC.bRodStarD And Strings.InStr(RSWIN_DESC.rst.Inputfile, "." + RSWIN_DESC.sOTHERFILETYPE.ToUpper(), CompareMethod.Binary) > 0 Then
								RSWIN_DESC.rst.Inputfile = RSWIN_DESC.rst.Inputfile.Replace("." + RSWIN_DESC.sOTHERFILETYPE.ToUpper(), "." + RSWIN_DESC.sFILETYPE)
							Else
								RSWIN_DESC.rst.Inputfile = rfn.Trim()
							End If
							Me.SetCaption(RSWIN_DESC.rst.Inputfile)
							Try
								Dim rstdir As String
								Try
									rstdir2 = ""
									rstdir = ""
									Dim text2 As String
									Dim text3 As String
									FILEIO.SplitPath(rfn, text2, text3, rstdir2, rstdir)
									rst = RSWIN_DESC.rst
									rstdir2 = rst.RSTDir
									rstdir = ""
									Dim text As String = ""
									FILEIO.MakePath(rstdir2, text2, text3, rstdir, text)
									rst.RSTDir = rstdir2
									rstdir2 = "DefaultFolderRST"
									rst = RSWIN_DESC.rst
									rstdir = rst.RSTDir
									RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_FOLDER_DEFAULTS, rstdir2, rstdir, RSWIN_DESC.sINIFile)
									rst.RSTDir = rstdir
								Catch ex3 As Exception
								End Try
								rstdir2 = "DefaultFolderRST"
								rst = RSWIN_DESC.rst
								rstdir = rst.RSTDir
								RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_FOLDER_DEFAULTS, rstdir2, rstdir, RSWIN_DESC.sINIFile)
								rst.RSTDir = rstdir
							Catch ex4 As Exception
							End Try
							If Not RSWIN_DESC.rst.gbAutomatic And Not RSWIN_DESC.rst.gbBatch Then
								Me.RemoveChildForm("Results", False)
							End If
						End If
						RSWIN_DESC.rst.gbBatch = False
						Dim inputfile As String = RSWIN_DESC.rst.Inputfile
						If flag Then
							Me.AddRecentFile(rfn)
						End If
					ElseIf num > 1S Then
						Try
							Application.DoEvents()
							Me.frmHowToStart.Hide()
							Application.DoEvents()
						Catch ex5 As Exception
						End Try
						RSWIN_DESC.sDefaultBatchFolder = sDefaultBatchFolder
						Batch.BatchRunFiles(array, CInt(num), Me.m_bRST)
						Me.BatchProcess(sDefaultBatchFolder)
					End If
			End Select
			If Not RSWIN_DESC.bRodStarD AndAlso RSWIN_DESC.bExpert Then
				If RSWIN_DESC.SETUP_bGuru Then
					Me._mnuWindowInput_3.Enabled = False
					Me._mnuWindowInput_4.Enabled = False
					Me._mnuWindowInput_6.Enabled = False
					Me._mnuWindowInput_7.Enabled = False
				Else
					Me._mnuWindowInput_3.Enabled = True
					Me._mnuWindowInput_4.Enabled = True
					Me._mnuWindowInput_6.Enabled = True
					Me._mnuWindowInput_7.Enabled = True
				End If
			End If
			If RSWIN_DESC.bIntVersion AndAlso RSWIN_DESC.bChangeCultures Then
				Dim setup_Language As String = RSWIN_DESC.SETUP_Language
				If Operators.CompareString(setup_Language, RSWIN_DESC.sEnglish, False) = 0 Then
					RSWIN_DESC.myCulture = New CultureInfo(RSWIN_DESC.sEnglish)
				ElseIf Operators.CompareString(setup_Language, RSWIN_DESC.sSpanish, False) = 0 Then
					RSWIN_DESC.myCulture = New CultureInfo(RSWIN_DESC.sSpanish)
				ElseIf Operators.CompareString(setup_Language, RSWIN_DESC.sChinese, False) = 0 Then
					RSWIN_DESC.myCulture = New CultureInfo(RSWIN_DESC.sChinese)
				Else
					RSWIN_DESC.myCulture = New CultureInfo(RSWIN_DESC.sEnglish)
				End If
				Thread.CurrentThread.CurrentUICulture = RSWIN_DESC.myCulture
			End If
			RSWIN_DESC.bReadingFile = False
		End Sub

		Public Sub LoadOneFile(ByRef iCursorPrev As Cursor, ByRef rfn As String, ByRef bFileLoaded As Boolean, ByRef gbInputDataChanged As Boolean, Optional bQuiet As Boolean = False)
			Dim flag As Boolean = True
			Try
				iCursorPrev = Me.Cursor
				Me.Cursor = Cursors.WaitCursor
				Me.RemoveChildForms()
				RSWIN_DESC.rst.SetClassDefaults(False)
				If Not RSWIN_DESC.rst.gbAutomatic And Not RSWIN_DESC.rst.gbBatch Then
					Me.RemoveAllChildForms(False)
				End If
			Catch ex As Exception
			End Try
			MImpred.InitSurveyDataset(RSWIN_DESC.mdsDeviationProfile_Edit, Nothing)
			Me.ToolbarButtonSetState(0, False)
			Me.ToolbarButtonSetState(1, False)
			Me.ToolbarButtonSetState(2, False)
			Me.ToolbarButtonSetState(8, False)
			Me.ToolbarButtonSetState(9, False)
			Me.ToolbarButtonSetState(10, False)
			Me.ToolbarButtonSetState(11, False)
			Me.ToolbarButtonSetState(12, False)
			Me.ToolbarButtonSetState(13, False)
			Me.ToolbarButtonSetState(14, False)
			Me.ToolbarButtonSetState(15, False)
			Me.ToolbarButtonSetState(16, False)
			Me.ToolbarButtonSetState2(4, False)
			Me.ToolbarButtonSetState2(5, False)
			Me.ToolbarButtonSetState2(0, False)
			Me.ToolbarButtonSetState2(5, False)
			RSWIN.ReadFile(rfn, bFileLoaded, bQuiet)
			Me.Cursor = iCursorPrev
			If Not bFileLoaded Then
				Me.SetCaption(RSWIN_DESC.sNull)
			Else
				Dim num As Integer = 1
				Do
					RSWIN_DESC.NewData(num) = 0S
					num += 1
				Loop While num <= 7
				ini.SaveDataValue(RSWIN_DESC.sNull, "")
				ini.SaveDataValue("InProgress", DBNull.Value)
				RSWIN.ReCreateRegKey(RSWIN_DESC.SECT_DATAENTRY)
				Me.ToolbarButtonSetState(0, True)
				Me.ToolbarButtonSetState(1, True)
				Me.ToolbarButtonSetState(2, True)
				Me.ToolbarButtonSetState(8, True)
				Me.ToolbarButtonSetState(9, True)
				Me.ToolbarButtonSetState(10, True)
				Me.ToolbarButtonSetState(11, True)
				If RSWIN_DESC.bRodStarD Then
					Me.ToolbarButtonSetState(12, True)
				Else
					Me.ToolbarButtonSetState(12, False)
				End If
				Me.ToolbarButtonSetState(13, True)
				Me.ToolbarButtonSetState(14, True)
				Me.ToolbarButtonSetState(15, True)
				Me.ToolbarButtonSetState(16, True)
				Me.ToolbarButtonSetState2(4, True)
				Me.ToolbarButtonSetState2(5, True)
				Me.ToolbarButtonSetState2(0, True)
				Me.ToolbarButtonSetState2(5, True)
				Me.btnVisualInput.Enabled = True
				Me.btnAlpha.Enabled = True
				If Operators.CompareString(RSWIN_DESC.rst.Inputfile, rfn, False) <> 0 Then
					RSWIN_DESC.rst.Inputfile = rfn
					If Strings.InStr(RSWIN_DESC.rst.Inputfile.ToLower(), ".xddx", CompareMethod.Binary) > 0 Then
						RSWIN_DESC.rst.gbOutputLoaded = False
						Me.ToolbarButtonSetState2(2, False)
					End If
				End If
				Dim text As String = "Successfully loaded file " + RSWIN_DESC.rst.Inputfile
				If RSWIN_DESC.rst.gbOutputLoaded Then
					text += " (output results are available)"
					Me.frmHowToStart.Hide()
				End If
				text += "."
				If Not bQuiet Then
					Me.Message(text)
					Me.SetCaption(RSWIN_DESC.rst.Inputfile)
				End If
				If RSWIN_DESC.rst.gbOutputLoaded Then
					Me.ToolbarButtonSetState2(2, True)
					Me.ToolbarButtonSetState2(3, True)
					Me.LoadForm(1S, -1S)
				Else
					Me.ToolbarButtonSetState2(2, False)
					If Not RSWIN_DESC.gbDemoMode And RSWIN_DESC.SETUP_bGuru And RSWIN_DESC.bExpert Then
						Dim flag2 As Boolean
						If RSWIN_DESC.rst.TargetBFPD = 0F Then
							flag = Not Me.MdiFormExists("ProdInfo", False, False, False, flag2)
						ElseIf Me.MdiFormExists("ProdInfo", False, False, False, flag2) Then
							flag = False
						End If
					End If
					If flag Then
						If Not RSWIN_DESC.gbDemoMode Then
							Me.LoadForm(1S, -1S)
						ElseIf RSWIN_DESC.gbDemoShowWellInfo Then
							Me.LoadForm(1S, -1S)
						End If
					End If
				End If
				gbInputDataChanged = False
				Dim flag3 As Boolean = False
				Dim flag4 As Boolean = False
				If RSWIN_DESC.mdsDeviationProfile Is Nothing Then
					flag3 = True
				ElseIf RSWIN_DESC.mdsDeviationProfile.Tables(0).Rows.Count = 0 Then
					flag3 = True
				End If
				If flag3 And Not RSWIN_DESC.rst.gbBatch Then
					Dim text2 As String
					Dim wellnameFromLastTempDeviationProfile As Boolean = Util.GetWellnameFromLastTempDeviationProfile(text2)
					If wellnameFromLastTempDeviationProfile AndAlso (Operators.CompareString(RSWIN_DESC.rst.WellName.Trim(), text2.Trim(), False) = 0 And RSWIN_DESC.bRodStarD) Then
						Dim msg As String = "Use the deviation survey from a previous run of well " + text2 + "?"
						Dim bDefaultYes As Boolean = True
						Dim flag5 As Boolean = False
						If Util.YesNo(msg, bDefaultYes, flag5) Then
							LOADRST.LoadTempDeviationProfile(text2, False)
							RSWIN_DESC.bNoLoad = True
						Else
							RSWIN_DESC.bNoLoad = True
						End If
					End If
				End If
				If Not flag3 And Not flag4 Then
					LOADRST.DeleteTempDeviationFile()
					If RSWIN_DESC.mdsDeviationProfile IsNot Nothing AndAlso RSWIN_DESC.mdsDeviationProfile.Tables(0).Rows.Count > 0 Then
						Dim flag6 As Boolean = SAVEFILE.StoreTempDeviationProfile(RSWIN_DESC.mdsDeviationProfile, False)
					End If
				End If
			End If
			If Not(RSWIN_DESC.rst.gbAutomatic And RSWIN_DESC.rst.gbBatch) Then
				Me.SetCBMTooltipText()
				Return
			End If
		End Sub

		Public Sub LoadOneFile2(ByRef iCursorPrev As Object, ByRef rfn As Object, ByRef bFileLoaded As Object, ByRef gbInputDataChanged As Object)
			iCursorPrev = Me.Cursor
			Me.Cursor = Cursors.WaitCursor
			Try
				Me.RemoveChildForms()
				Me.CreateForms()
				RSWIN_DESC.rst.SetClassDefaults(False)
				If Not RSWIN_DESC.rst.gbAutomatic And Not RSWIN_DESC.rst.gbBatch Then
					Me.RemoveAllChildForms(False)
				End If
			Catch ex As Exception
			End Try
			Dim inputfile As String = Conversions.ToString(rfn)
			Dim flag As Boolean = Conversions.ToBoolean(bFileLoaded)
			RSWIN.ReadFile(inputfile, flag, False)
			bFileLoaded = flag
			If Strings.InStr(Conversions.ToString(rfn), ".rdg", CompareMethod.Binary) > 0 Then
				RSWIN_DESC.rst.Inputfile = Conversions.ToString(NewLateBinding.LateGet(rfn, Nothing, "Replace", New Object() { ".rdg", ".rsvx" }, Nothing, Nothing, Nothing))
			ElseIf Strings.InStr(Conversions.ToString(rfn), ".RDG", CompareMethod.Binary) > 0 Then
				RSWIN_DESC.rst.Inputfile = Conversions.ToString(NewLateBinding.LateGet(rfn, Nothing, "Replace", New Object() { ".RDG", ".rsvx" }, Nothing, Nothing, Nothing))
			ElseIf Strings.InStr(Conversions.ToString(rfn), ".xdg", CompareMethod.Binary) > 0 Then
				RSWIN_DESC.rst.Inputfile = Conversions.ToString(NewLateBinding.LateGet(rfn, Nothing, "Replace", New Object() { ".xdg", ".rsvx" }, Nothing, Nothing, Nothing))
			ElseIf Strings.InStr(Conversions.ToString(rfn), ".XDG", CompareMethod.Binary) > 0 Then
				RSWIN_DESC.rst.Inputfile = Conversions.ToString(NewLateBinding.LateGet(rfn, Nothing, "Replace", New Object() { ".XDG", ".rsvx" }, Nothing, Nothing, Nothing))
			ElseIf Not RSWIN_DESC.bRodStarD And Strings.InStr(RSWIN_DESC.rst.Inputfile, "." + RSWIN_DESC.sOTHERFILETYPE, CompareMethod.Binary) > 0 Then
				RSWIN_DESC.rst.Inputfile = RSWIN_DESC.rst.Inputfile.Replace("." + RSWIN_DESC.sOTHERFILETYPE, "." + RSWIN_DESC.sFILETYPE)
			ElseIf Not RSWIN_DESC.bRodStarD And Strings.InStr(RSWIN_DESC.rst.Inputfile, "." + RSWIN_DESC.sOTHERFILETYPE.ToUpper(), CompareMethod.Binary) > 0 Then
				RSWIN_DESC.rst.Inputfile = RSWIN_DESC.rst.Inputfile.Replace("." + RSWIN_DESC.sOTHERFILETYPE.ToUpper(), "." + RSWIN_DESC.sFILETYPE)
			End If
			Me.Cursor = CType(iCursorPrev, Cursor)
			If Conversions.ToBoolean(Operators.NotObject(bFileLoaded)) Then
				Me.SetCaption(RSWIN_DESC.sNull)
			Else
				Dim num As Integer = 1
				Do
					RSWIN_DESC.NewData(num) = 0S
					num += 1
				Loop While num <= 7
				ini.SaveDataValue(RSWIN_DESC.sNull, "")
				ini.SaveDataValue("InProgress", DBNull.Value)
				RSWIN.ReCreateRegKey(RSWIN_DESC.SECT_DATAENTRY)
				Me.ToolbarButtonSetState(0, True)
				Me.ToolbarButtonSetState(1, True)
				Me.ToolbarButtonSetState(2, True)
				Me.ToolbarButtonSetState(8, True)
				Me.ToolbarButtonSetState(9, True)
				Me.ToolbarButtonSetState(10, True)
				Me.ToolbarButtonSetState(11, True)
				If RSWIN_DESC.bRodStarD Then
					Me.ToolbarButtonSetState(12, True)
				Else
					Me.ToolbarButtonSetState(12, False)
				End If
				Me.ToolbarButtonSetState(13, True)
				Me.ToolbarButtonSetState(14, True)
				Me.ToolbarButtonSetState(15, True)
				Me.ToolbarButtonSetState(16, True)
				Me.ToolbarButtonSetState2(4, True)
				Me.ToolbarButtonSetState2(5, True)
				Me.ToolbarButtonSetState2(0, True)
				Me.btnVisualInput.Enabled = True
				Me.btnAlpha.Enabled = True
				Me.SetCaption(RSWIN_DESC.rst.Inputfile)
				If RSWIN_DESC.rst.gbOutputLoaded Then
					Me.ToolbarButtonSetState2(2, True)
					Me.ToolbarButtonSetState2(3, True)
				Else
					Me.ToolbarButtonSetState2(2, False)
					Me.LoadForm(1S, -1S)
				End If
				gbInputDataChanged = False
			End If
		End Sub

		Public Sub LoadForm(nForm As Short, nItem As Short)
			Util.BusyCursor()
			Dim form As Form = Nothing
			Select Case nForm
				Case 1S
					Me.AddWellInfo(True)
				Case 2S
					Me.AddProdInfo(True)
				Case 3S
					Me.AddPTInfo(True)
				Case 4S
					Me.AddRSInput(True, False)
				Case 5S
					If RSWIN_DESC.bRodStarD Then
						Me.AddDeviationProfile(True)
					End If
				Case 6S
					Me.AddPUData(True)
				Case 7S
					Me.AddMotorData(True)
			End Select
			If form IsNot Nothing Then
				form.Show()
				If form.WindowState = FormWindowState.Minimized Then
					form.WindowState = FormWindowState.Normal
				End If
			End If
			Util.UnbusyCursor()
		End Sub

		Public Sub mnuWindowViewReport_Popup(eventSender As Object, eventArgs As EventArgs)
			Me.mnuWindowViewReport_Click(RuntimeHelpers.GetObjectValue(eventSender), eventArgs)
		End Sub

		Public Sub mnuWindowViewReport_Click(eventSender As Object, eventArgs As EventArgs)
			Me.ResetClock()
			Dim num As Short = -1S
			If RSWIN_DESC.rst.gbOutputOld Then
				Dim msg As String = Me.sDYWRerun
				Dim bDefaultYes As Boolean = True
				Dim flag As Boolean = False
				num = If((-If((Not Util.YesNo(msg, bDefaultYes, flag) > False), 1S, 0S)), 1S, 0S)
			End If
			If num <> 0S Then
				Util.BusyCursor()
				Me.UnloadAllForms(0, 0)
				Try
					Me.ActiveMdiChild.Hide()
				Catch ex As Exception
				End Try
				RSWIN_DESC.bBackFromSetLines = False
				Me.AddResults(True)
				Return
			End If
			RSWIN_DESC.SETUP_RunForSpeed = 0S
			Me.mnuRunPrediction_Click(True)
		End Sub

		Public Sub mnuWindowVisInput_Popup(eventSender As Object, eventArgs As EventArgs)
			Me.mnuWindowVisInput_Click(RuntimeHelpers.GetObjectValue(eventSender), eventArgs)
		End Sub

		Public Sub mnuWindowVisInput_Click(eventSender As Object, eventArgs As EventArgs)
			Me.ResetClock()
			If Me.m_VisualInput Then
				Me.m_VisualInput = False
				Me.AddVisInput(False, False)
			Else
				Me.m_VisualInput = True
				Me.AddVisInput(True, False)
			End If
		End Sub

		Public Sub ToolbarButtonSetState(Index As Integer, bEnabled As Boolean)
			' The following expression was wrapped in a checked-statement
			Try
				If Versioned.IsNumeric(Index) Then
					If RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru And RSWIN_DESC.ScrnNum = 6 And RSWIN_DESC.ScrnNum = 4 And RSWIN_DESC.ScrnNum = 10 Then
						Me.tbrToolbar.Buttons(Index).Enabled = False
					Else
						If Index = -1 Or Index = -2 Then
							Dim num As Integer = 0
							Dim num2 As Integer = Me.tbrToolbar.Buttons.Count - 1
							For i As Integer = num To num2
								Me.tbrToolbar.Buttons(i).Enabled = bEnabled
								If Index = -2 And (i = 5 Or i = 0 Or i = 1) Then
									Me.tbrToolbar.Buttons(i).Enabled = True
								End If
							Next
							Dim num3 As Integer = 0
							Dim num4 As Integer = Me.tbrToolBar2.Buttons.Count - 1
							For i As Integer = num3 To num4
								Me.tbrToolBar2.Buttons(i).Enabled = bEnabled
								If i = 8 Then
									Me.tbrToolBar2.Buttons(8).Enabled = True
								End If
								If i = 3 Then
									Me.tbrToolBar2.Buttons(3).Enabled = True
								End If
							Next
							Dim num5 As Integer = 0
							Dim num6 As Integer = Me.tbrToolBar3.Buttons.Count - 1
							For i As Integer = num5 To num6
								Me.tbrToolBar3.Buttons(i).Enabled = bEnabled
								If i = 0 Then
									Me.tbrToolBar3.Buttons(0).Enabled = True
								End If
							Next
						Else
							Me.tbrToolbar.Buttons(Index).Enabled = bEnabled
						End If
						If Not RSWIN_DESC.bRodStarD Then
							Me.tbrToolbar.Buttons(12).Enabled = False
							Me.tbrToolbar.Buttons(12).Visible = False
						End If
						Select Case Index
							Case 0
								Me.mnuFileSave.Enabled = bEnabled
								Me.mnuFileSaveAs_.Enabled = bEnabled
								Me.mnuRun.Enabled = bEnabled
								Me.mnuWindow.Enabled = bEnabled
								Application.DoEvents()
							Case 2
								Me.mnuFileSave.Enabled = bEnabled
								Me.mnuFileSaveAs_.Enabled = bEnabled
								Me.tbrToolbar.Buttons(2).Enabled = bEnabled
								If RSWIN_DESC.bXRODAdmin Then
									Me.mnuToolsUploadRSVXFile.Enabled = bEnabled
									Me.tbrExpertAdmin.Buttons(0).Enabled = bEnabled
								End If
							Case 5
								Me.mnuToolsExportMCM.Enabled = bEnabled
							Case 8
								Me.mnuWindowInput(1S).Enabled = bEnabled
							Case 9
								Me.mnuWindowInput(2S).Enabled = bEnabled
								Me.tbrPrevious.Enabled = True
							Case 10
								Me.mnuWindowInput(3S).Enabled = bEnabled
							Case 11
								Me.mnuWindowInput(4S).Enabled = bEnabled
							Case 12
								If RSWIN_DESC.bRodStarD Then
									Me.mnuWindowInput(5S).Enabled = bEnabled
								Else
									Me.mnuWindowInput(5S).Enabled = False
									Me.mnuWindowInput(5S).Visible = False
								End If
							Case 13
								Me.mnuWindowInput(6S).Enabled = bEnabled
							Case 14
								Me.mnuWindowInput(7S).Enabled = bEnabled
								If bEnabled Then
									Me.mnuFileSave.Enabled = bEnabled
									Me.mnuFileSaveAs_.Enabled = bEnabled
								End If
							Case 15
								Me.mnuWindowPreviousScreen.Enabled = bEnabled
							Case 16
								Me.mnuWindowNextScreen.Enabled = bEnabled
								If RSWIN_DESC.bRunIconEnabled Then
									Me.tbrToolBar2.Buttons(0).Enabled = bEnabled
									If RSWIN_DESC.bRodStarD Then
										Me.tbrToolBar2.Buttons(1).Visible = False
										Me.tbrToolBar2.Buttons(1).Enabled = False
									End If
								End If
						End Select
					End If
				End If
			Catch ex As Exception
				MessageBox.Show("Error in ToolbarButtonSetState: " + ex.Message)
			End Try
		End Sub

		Public Sub ToolbarButtonSetState2(Index As Integer, bEnabled As Boolean)
			Me.tbrToolBar2.Buttons(Index).Enabled = bEnabled
			Select Case Index
				Case 0
					Me.mnuRun.Enabled = bEnabled
					If bEnabled Then
						RSWIN_DESC.bRunIconEnabled = True
					End If
					If RSWIN_DESC.bRodStarD Then
						Me.tbrToolBar2.Buttons(1).Visible = False
						Me.tbrToolBar2.Buttons(1).Enabled = False
						Return
					End If
					Return
				Case 1, 5, 6, 7
				Case 2
					Me.mnuFileSaveAsPDF_.Enabled = bEnabled
					Me.mnuToolsExportDYN.Enabled = bEnabled
					Me.mnuWindowViewReport.Enabled = bEnabled
					If Not RSWIN_DESC.rst.gbAutomatic And Not RSWIN_DESC.rst.gbBatch And Not bEnabled Then
						RSWIN_DESC.rst.gbOutputLoaded = False
					End If
					Me.mnuToolsExportMCM.Enabled = bEnabled
					Me.tbrCBM.Enabled = bEnabled
					If RSWIN_DESC.bRodStarD And Not bEnabled Then
						Try
							RSWIN_DESC.rst.bImplementedDesign = False
						Catch ex As Exception
						End Try
						Return
					End If
				Case 3
					Me.tbrToolBar2.Buttons(3).Enabled = True
					Return
				Case 4
					Me.mnuFilePrint_.Enabled = bEnabled
					Return
				Case 8
					If Not RSWIN_DESC.rst.gbAutomaticEnabled Then
						Me.tbrToolBar2.Buttons(8).Enabled = False
					End If
				Case Else
					Return
			End Select
		End Sub

		Public Sub AddRecentFile(sFileName As String)
			Dim flag As Boolean = False
			Try
				If Not(RSWIN_DESC.bExpert And Operators.CompareString(RSWIN_DESC.RECENTFILES, "AI Recent Files", False) = 0 And Strings.InStr(sFileName.ToLower(), ".xrvx", CompareMethod.Binary) <= 0) Then
					Dim num As Short = 0S
					Dim num2 As Short = Me.nRecentFiles - 1S
					For num3 As Short = num To num2
						If Strings.StrComp(sFileName, Me.asRecentFiles(CInt(num3)), CompareMethod.Text) = 0 Then
							Me.SelectRecentFile(num3)
							flag = True
							Exit For
						End If
					Next
					If Not flag Then
						' The following expression was wrapped in a checked-statement
						If Me.nRecentFiles < 20S Then
							Me.asRecentFiles = CType(Utils.CopyArray(CType(Me.asRecentFiles, Array), New String(CInt((Me.nRecentFiles + 1S)) - 1) {}), String())
							Me.nRecentFiles += 1S
						End If
						For num3 As Short = Me.nRecentFiles - 1S To 1S Step -1S
							' The following expression was wrapped in a checked-expression
							Me.asRecentFiles(CInt(num3)) = Me.asRecentFiles(CInt((num3 - 1S)))
						Next
						Me.asRecentFiles(0) = sFileName
						Me.SaveRecentFiles(RSWIN_DESC.RECENTFILES, RSWIN_DESC.sINIFile)
						Me.LoadRecentFiles(RSWIN_DESC.THETA_INI, RSWIN_DESC.RECENTFILES)
					End If
				End If
			Catch ex As Exception
				Dim sMsg As String = "Error in Add Recent File: " + ex.Message
				Dim sMsgType As String = ""
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
			End Try
		End Sub

		Private Sub CheckRecentFiles()
			Dim num As Short = -1S
			Dim num2 As Short = 0S
			Dim num3 As Short = Me.nRecentFiles - 1S
			For num4 As Short = num2 To num3
				' The following expression was wrapped in a checked-statement
				If FILEUTIL.FileExists(Me.asRecentFiles(CInt(num4))) Then
					num += 1S
					If num4 <> num Then
						Me.asRecentFiles(CInt(num)) = Me.asRecentFiles(CInt(num4))
					End If
				End If
			Next
			Me.nRecentFiles = num + 1S
		End Sub

		Public Sub LoadRecentFiles(sINIFile As String, sINISection As String)
			Try
				Dim text As String = Strings.Space(1024)
				Me.asRecentFiles = New String(19) {}
				Me.ctxMenu4ToolBar.MenuItems.Clear()
				Me.nRecentFiles = 0S
				If Not RSWIN_DESC.bExpert Then
					Dim num As Short = 0S
					Do
						Dim text2 As String = Convert.ToString(num)
						Dim text3 As String = ""
						Dim num2 As Short = CShort(RSWIN.GetRegProfileString(sINISection, text2, text3, text, False))
						Me.asRecentFiles(CInt(num)) = text.Substring(0, CInt(num2))
						If num2 > 0S Then
							Me.ctxMenu4ToolBar.MenuItems.Add(New MenuItem(Me.asRecentFiles(CInt(num)), AddressOf Me.ctxMenu4ToolBar_Clicked))
							Me.nRecentFiles = num + 1S
						End If
						num += 1S
					Loop While num <= 19S
				Else
					Dim num As Short = 0S
					Do
						Dim text3 As String = Convert.ToString(num)
						Dim text2 As String = ""
						Dim num2 As Short = CShort(RSWIN.GetRegProfileString(sINISection, text3, text2, text, False))
						Me.asRecentFiles(CInt(num)) = text.Substring(0, CInt(num2))
						If num2 > 0S Then
							If RSWIN_DESC.SETUP_bGuru Then
								If Strings.InStr(Me.asRecentFiles(CInt(num)).ToLower(), "xrvx", CompareMethod.Binary) > 0 Then
									Me.ctxMenu4ToolBar.MenuItems.Add(New MenuItem(Me.asRecentFiles(CInt(num)), AddressOf Me.ctxMenu4ToolBar_Clicked))
									Me.nRecentFiles += 1S
								End If
							Else
								Me.ctxMenu4ToolBar.MenuItems.Add(New MenuItem(Me.asRecentFiles(CInt(num)), AddressOf Me.ctxMenu4ToolBar_Clicked))
								Me.nRecentFiles += 1S
							End If
						End If
						num += 1S
					Loop While num <= 19S
				End If
			Catch ex As Exception
				Dim sMsg As String = "Error in LoadRecentFiles: " + ex.Message
				Dim sMsgType As String = ""
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
			End Try
		End Sub

		Public Function RecentFileCount() As Short
			Return Me.nRecentFiles
		End Function

		Public Function RecentFileName(iFile As Short) As String
			Dim result As String
			If iFile >= 0S AndAlso iFile <= Me.nRecentFiles - 1S Then
				result = Me.asRecentFiles(CInt(iFile))
			Else
				result = Nothing
			End If
			Return result
		End Function

		Public Sub SaveRecentFiles(sINISection As String, sINIFile As String)
			RSWIN.ReCreateRegKey(sINISection)
			Dim num As Short = 0S
			Dim num2 As Short = Me.nRecentFiles - 1S
			For num3 As Short = num To num2
				Dim text As String = Convert.ToString(num3)
				Dim num4 As Integer = RSWIN.WriteRegProfileString(sINISection, text, Me.asRecentFiles(CInt(num3)), sINIFile)
			Next
		End Sub

		Public Sub SelectRecentFile(iFile As Short)
			Dim text As String = Me.asRecentFiles(CInt(iFile))
			For num As Short = iFile To 1S Step -1S
				' The following expression was wrapped in a checked-expression
				Me.asRecentFiles(CInt(num)) = Me.asRecentFiles(CInt((num - 1S)))
			Next
			Me.asRecentFiles(0) = text
		End Sub

		Public Sub mnuFilePrint__Popup(eventSender As Object, eventArgs As EventArgs)
			Me.mnuFilePrint__Click(RuntimeHelpers.GetObjectValue(eventSender), eventArgs)
		End Sub

		Public Sub mnuFilePrint__Click(eventSender As Object, eventArgs As EventArgs)
			Me.MakePrintout(-1S)
		End Sub

		Public Sub mnuFilePrintSetup__Popup(eventSender As Object, eventArgs As EventArgs)
			Me.mnuFilePrintSetup__Click(RuntimeHelpers.GetObjectValue(eventSender), eventArgs)
		End Sub

		Public Sub mnuFilePrintSetup__Click(eventSender As Object, eventArgs As EventArgs)
			Me.ResetClock()
			RSWIN_DESC.pd.PrinterSettings = RSWIN_DESC.ps
			Dim dialogResult As DialogResult = RSWIN_DESC.pd.ShowDialog()
		End Sub

		Private Sub DisplayChildForm(ScrnNum As Integer)
			Select Case ScrnNum
				Case 1
					Me.AddWellInfo(True)
				Case 2
					Me.AddProdInfo(True)
				Case 3
					Me.AddPTInfo(True)
				Case 4
					Me.AddRSInput(True, False)
				Case 5
					If RSWIN_DESC.bRodStarD Then
						Me.AddDeviationProfile(True)
					End If
				Case 6
					Me.AddPUData(True)
				Case 7
					Me.AddMotorData(True)
			End Select
		End Sub

		Public Sub mnuRunPrediction_Click(Optional bShowResults As Boolean = True)
			Dim num As Integer = 0
			Dim num2 As Integer = 0
			Dim num3 As Integer = 0
			Dim num4 As Integer = 0
			Dim num5 As Integer = 0
			Dim num6 As Integer = 0
			Dim num7 As Single = 0F
			Dim flag As Boolean = True
			Dim flag2 As Boolean = False
			Dim flag3 As Boolean = False
			Dim flag4 As Boolean = RSWIN_DESC.bExpert And RSWIN_DESC.bRunGuru And RSWIN_DESC.bXRODAdmin And RSWIN_DESC.SETUP_bAdminDebug
			Dim flag5 As Boolean = False
			Dim flag6 As Boolean = False
			Try
				Me.ResetClock()
				RSWIN_DESC.bPredictiveRunning = False
				MImpred.bSurveyLimitWarningMsgShown = False
				MImpred.bSurveyLimitErrorMsgShown = False
				MImpred.bSurveyWarningMsgAnswer = False
				RSWIN_DESC.bImplementingRodGuides = False
				RSWIN_DESC.i2Score = 1
				If RSWIN_DESC.bExpert Then
					If RSWIN_DESC.SETUP_bGuru Then
						flag = Me.ValidateTargetProduction()
					ElseIf Not RSWIN_DESC.rst.UnknownM Then
						RSWIN_DESC.i2Score = 2
					End If
				End If
				If flag Then
					RSWIN_DESC.bRunStarRunning = True
					RSWIN_DESC.iErrorOccurred = 0
					If RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru Then
						RSWIN_DESC.sAIFilename = RSWIN_DESC.rst.Inputfile
					End If
					Me.StartRunAni()
					Dim flag7 As Boolean
					If Not RSWIN_DESC.rst.gbBatch And Not RSWIN_DESC.rst.gbAutomatic Then
						flag7 = Me.ValidateActiveMDIChild("")
						If Not flag7 Then
							Me.StopRunAni()
							RSWIN_DESC.bPredictiveRunning = False
							Return
						End If
					End If
					RSWIN_DESC.bRunGuru = False
					RSWIN_DESC.bOneGuruFile = True
					RSWIN_DESC.bSuppressWarningMessages = False
					RSWIN_DESC.bImprovingScore = False
					RSWIN_DESC.bUsingClosestUnit = False
					RSWIN_DESC.bUsingGeneralList = False
					If RSWIN_DESC.gbDemoMode Then
						MessageBox.Show("Demo Mode: The report will show results for the Demo Case only and not reflect any changes you might have input.", "DEMO MODE REPORT for " + RSWIN_DESC.gsDemoFile, MessageBoxButtons.OK)
						RSWIN_DESC.gbDemoShowWellInfo = False
						Dim iFile As Short = -1S
						Dim openFileDialog As OpenFileDialog = Nothing
						Dim setup_GURUTEMPDIR As String = Application.StartupPath + "\" + RSWIN_DESC.gsDemoFile
						Dim flag8 As Boolean = False
						Me.OpenFile(iFile, openFileDialog, setup_GURUTEMPDIR, flag8)
					ElseIf RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru Then
						Try
							Dim activeMdiChild As Form = Me.ActiveMdiChild
							If activeMdiChild IsNot Nothing AndAlso activeMdiChild.Visible Then
								Me.RemoveChildForm(activeMdiChild.Name, False)
							End If
						Catch ex As Exception
						End Try
						Try
							Application.DoEvents()
							Me.StartAIAni()
						Catch ex2 As Exception
						End Try
						Me.Message(Me.sCalcInProgress + RSWIN_DESC.sPleaseWait)
						If RSWIN_DESC.SETUP_bGuruUseTemplateDatabase AndAlso Not RSWIN_DESC.bGuruFileDataLoaded Then
							If RSWIN_DESC.bProcessFinished Or Not RSWIN_DESC.SETUP_bGuru Then
								GURU_DB.ReLoadALLGuruFiledata()
								RSWIN_DESC.bGuruFileDataLoaded = True
								RSWIN_DESC.bProcessFinished = True
							ElseIf Not Me.WaitForProcessToFinishLoading() Then
								GURU_DB.ReLoadALLGuruFiledata()
								RSWIN_DESC.bGuruFileDataLoaded = True
								RSWIN_DESC.bProcessFinished = True
							End If
						End If
						Dim flag9 As Boolean = Me.AreAllManufacturerPreferencesSame(flag6)
						If flag6 Then
							MessageBox.Show("Please select at least one pumping unit manufacturer from the AI Mode Preferences in Setup.")
							flag7 = False
							Me.StopRunAni()
							Return
						End If
						If flag9 And Not(RSWIN_DESC.SETUP_bUseFGlassWithSteelOnBottom And RSWIN_DESC.SETUP_bUseSteelRodsOnly) Then
							RSWIN_DESC.bOneGuruFile = True
							If RSWIN_DESC.SETUP_bGuruUseTemplateDatabase Then
								If Not RSWIN_DESC.bGuruFileDataLoaded Then
									GURU_DB.ReLoadALLGuruFiledata()
									RSWIN_DESC.bGuruFileDataLoaded = True
								End If
								flag7 = Me.ReadOneGuruTemplateFromDatabase(flag5)
								If flag5 Then
									flag7 = False
									Me.StopRunAni()
									RSWIN_DESC.bPredictiveRunning = False
									Return
								End If
								RSWIN_DESC.rst.Inputfile = "AI_RUN_1_(" + RSWIN_DESC.rst_save.WellName.Trim() + ").rsvx"
								RSWIN_DESC.bSuppressWarningMessages_Override = True
								DESIGN.Design()
								Dim fTemplateTotalAIScore As Single = RSWIN_DESC.fTemplateTotalAIScore
								Dim bCheckToAdd As Boolean = False
								Dim flag8 As Boolean = False
								Dim sTemplateTotalAIScore As String = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, fTemplateTotalAIScore, bCheckToAdd, flag2, flag8, False, False)
								RSWIN_DESC.fTemplateTotalAIScore = fTemplateTotalAIScore
								RSWIN_DESC.sTemplateTotalAIScore = sTemplateTotalAIScore
								RSWIN_DESC.bSuppressWarningMessages_Override = False
							Else
								flag7 = Me.ReadGuruFile()
							End If
							If Not flag7 Then
								Me.StopRunAni()
								Return
							End If
							Me.btnGuru.SendToBack()
						Else
							Try
								RSWIN_DESC.mrgBatchFileList = New String(0) {}
								RSWIN_DESC.sAI_DBKeys = New String(0) {}
								RSWIN_DESC.sAI_DBPrefixes = New String(0) {}
								RSWIN_DESC.bRunGuru = True
								RSWIN_DESC.bOneGuruFile = False
								Application.DoEvents()
								Me.frmHowToStart.Hide()
								Application.DoEvents()
								RSWIN_DESC.SETUP_GURUTEMPDIR = "c:\Theta\TEMP\"
								Dim directoryInfo As DirectoryInfo = New DirectoryInfo(RSWIN_DESC.SETUP_GURUTEMPDIR)
								Try
									directoryInfo.Delete(True)
								Catch ex3 As Exception
								End Try
								Try
									directoryInfo.Create()
								Catch ex4 As Exception
								End Try
								RSWIN_DESC.rst_save = New cRODSTAR()
								RSWIN_DESC.rst_save.SetClassDefaults(False)
								Me.SaveRSObject()
								Me.sAlreadyFileList = New String(0) {}
								Dim num8 As Integer
								If RSWIN_DESC.SETUP_bGuruUseTemplateDatabase Then
									If Not RSWIN_DESC.bGuruFileDataLoaded Then
										GURU_DB.ReLoadALLGuruFiledata()
										RSWIN_DESC.bGuruFileDataLoaded = True
									End If
									Try
										Dim activeMdiChild2 As Form = Me.ActiveMdiChild
										If activeMdiChild2 IsNot Nothing AndAlso activeMdiChild2.Visible Then
											Me.RemoveChildForm(activeMdiChild2.Name, False)
										End If
									Catch ex5 As Exception
									End Try
									flag7 = Me.GuruBatchRunFilesFromDatabase(num8)
									If Not flag7 Then
										num8 = 0
										MessageBox.Show("The target production cannot be achieved with any of the pumping units you selected in your preferences. Please reduce the target production and rerun.")
									End If
								Else
									Me.GuruBatchRunFiles(num8)
								End If
								RSWIN_DESC.mcBatchFiles = num8
								If num8 <= 0 Then
									Me.StopRunAni()
									Return
								End If
								Dim setup_GURUTEMPDIR As String = RSWIN_DESC.SETUP_GURUTEMPDIR
								Me.BatchProcess(setup_GURUTEMPDIR)
								RSWIN_DESC.SETUP_GURUTEMPDIR = setup_GURUTEMPDIR
								If Not flag7 Then
									Me.StopRunAni()
									Return
								End If
								Return
							Catch ex6 As Exception
								Return
							End Try
						End If
					End If
					Try
						Me.AddVisInput(False, False)
						If Not RSWIN_DESC.rst.gbBatch And Not RSWIN_DESC.rst.gbAutomatic Then
							flag7 = Me.ValidateActiveMDIChild("")
							If Not flag7 Then
								Me.StopRunAni()
								Return
							End If
						End If
						If Me.ActiveMdiChild IsNot Nothing Then
							Me.ActiveMdiChild.Hide()
						End If
						Me.RemoveForms()
					Catch ex7 As Exception
						Dim sMsg As String = "Error in Run: Removing active MDI child" + ex7.Message
						Dim sMsgType As String = ""
						Dim bClosing As Boolean = False
						Dim dialogResult As DialogResult = DialogResult.OK
						Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
					End Try
					Application.DoEvents()
					Try
						RSWIN_DESC.sNull = ""
						Me.Message(RSWIN_DESC.sNull)
						If Not Me.$STATIC$mnuRunPrediction_Click$20112$bRunning <> 0 Then
							Me.$STATIC$mnuRunPrediction_Click$20112$bRunning = -1
							RSWIN_DESC.bPredictiveRunning = (Me.$STATIC$mnuRunPrediction_Click$20112$bRunning <> 0)
							Me.ToolbarButtonSetState(-1, False)
							Util.BusyCursor()
							Application.DoEvents()
							Me.CheckFileName()
							RSWIN_DESC.bChangeMotorSize = False
							RSWIN_DESC.bChangeSPM = False
							Util.BusyCursor()
							Application.DoEvents()
							Dim pu As RSWIN_DESC.PUDataRec
							Dim flag10 As Boolean
							Try
								If RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru And RSWIN_DESC.bOneGuruFile Then
									RSWIN_DESC.bSuppressWarningMessages = True
								End If
								Dim flag8 As Boolean
								If(RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru) AndAlso (Not RSWIN_DESC.SETUP_bUseAvgRodTBGFricCoeff And RSWIN_DESC.SETUP_TimesAvgRodTBGFricCoeff >= 2F) Then
									pu.Initialize()
									pu = RSWIN_DESC.rst.PU
									Dim unitID As String = RSWIN_DESC.rst.UnitID
									Dim text As String = Me.CheckFrictionAndPumpingUnit(pu, RSWIN_DESC.rst.UnitID, flag4)
									If Operators.CompareString(text, "", False) <> 0 And Operators.CompareString(text, unitID, False) <> 0 Then
										RSWIN_DESC.rst.UnitID = text
										Me.ReRunWithNewUnitID(text, True, False, False)
										If flag4 Then
											' The following expression was wrapped in a checked-expression
											Batch.BatchMessage(String.Concat(New String() { ">New GB Load: ", RSWIN_DESC.rst.GearboxLoading(RSWIN_DESC.i2Score).ToString(), " , unit ", RSWIN_DESC.rst.UnitID, " , ", Conversions.ToString(RSWIN_DESC.rst.PU.GearboxRating), "-", Conversions.ToString(RSWIN_DESC.rst.PU.StructRating), "-", Conversions.ToString(RSWIN_DESC.rst.PU.MaxStroke), " , crankhole: ", RSWIN_DESC.rst.PU.CrankHole.ToString(), " , stroke: ", RSWIN_DESC.rst.PU.Strokes(CInt((RSWIN_DESC.rst.CrankHole - 1S))).ToString() }))
										End If
										Dim bCheckToAdd2 As Boolean = False
										flag8 = False
										Dim text2 As String = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num7, bCheckToAdd2, flag2, flag8, False, False)
									End If
								End If
								Dim num9 As Integer = If((-If((flag10 > False), 1, 0)), 1, 0)
								flag8 = False
								Me.MakeRun(num9, flag8)
								flag10 = (num9 <> 0)
							Catch ex8 As Exception
								Dim sMsg2 As String = "Error calling MakeRun: " + ex8.Message
								Dim sMsgType2 As String = ""
								Dim bClosing2 As Boolean = False
								Dim dialogResult As DialogResult = DialogResult.OK
								Util.SendMessage(sMsg2, sMsgType2, bClosing2, dialogResult)
							End Try
							If Not RSWIN_DESC.bExpert Then
								Me.StopRunAni()
							ElseIf Not RSWIN_DESC.SETUP_bGuru Or Not flag10 Then
								Me.StopRunAni()
							End If
							If flag10 Then
								' The following expression was wrapped in a checked-statement
								If RSWIN_DESC.bXRODUseCustomizedLists And RSWIN_DESC.bXRODUseClosestUnit And RSWIN_DESC.bUsingClosestUnit Then
									Debug.WriteLine(" ")
								ElseIf RSWIN_DESC.bExpert And RSWIN_DESC.bCheckSmallestUnit And Strings.InStr(RSWIN_DESC.rst.UnitID, "CUSTOM", CompareMethod.Binary) <= 0 Then
									Dim rst As cRODSTAR = New cRODSTAR()
									rst = RSWIN_DESC.rst
									PUDATA1.FindSmallestUnitID()
									If Operators.CompareString(RSWIN_DESC.SmallestUnitID.Trim(), "", False) <> 0 Then
										Dim unitID2 As String = RSWIN_DESC.rst.UnitID
										RSWIN_DESC.rst.UnitID = RSWIN_DESC.SmallestUnitID
										pu.Initialize()
										pu = RSWIN_DESC.rst.PU
										Dim crankHole As Short = RSWIN_DESC.rst.PU.CrankHole
										Dim crankRotation As Short = RSWIN_DESC.rst.PU.CrankRotation
										Dim unbalance As Single = RSWIN_DESC.rst.PU.Unbalance
										PUDATA1.ReadPUData(RSWIN_DESC.rst.UnitID, pu, False, True)
										pu.CrankHole = crankHole
										pu.CrankRotation = crankRotation
										If Not(pu.UnitType = 7S Or pu.UnitType = 10S) Then
											pu.R = pu.CrankRadii(CInt((pu.CrankHole - 1S)))
										Else
											pu.R = pu.CrankRadii(0)
										End If
										kinemat.Kinconst(pu)
										kinemat.Unitstroke(pu)
										RSWIN_DESC.rst.PU = pu
										flag7 = PREDICT.Predict(True, "")
										If flag7 Then
											flag7 = DESIGN.SurfCalc(False)
											If(RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru) AndAlso flag7 Then
												If CDbl(RSWIN_DESC.rst.GearboxLoading(RSWIN_DESC.i2Score)) < 0.7 Then
													RSWIN_DESC.bSmallestUnitGearbox = True
												Else
													RSWIN_DESC.bSmallestUnitGearbox = False
												End If
												If CDbl(RSWIN_DESC.rst.StructL) < 0.7 Then
													RSWIN_DESC.bSmallestUnitStructL = True
												Else
													RSWIN_DESC.bSmallestUnitStructL = False
												End If
											End If
										End If
										RSWIN_DESC.rst.UnitID = unitID2
										pu.Initialize()
										PUDATA1.ReadPUData(RSWIN_DESC.rst.UnitID, pu, False, True)
										pu.CrankHole = crankHole
										pu.CrankRotation = crankRotation
										pu.Unbalance = unbalance
										If Not(pu.UnitType = 7S Or pu.UnitType = 10S) Then
											pu.R = pu.CrankRadii(CInt((pu.CrankHole - 1S)))
										Else
											pu.R = pu.CrankRadii(0)
										End If
										kinemat.Kinconst(pu)
										kinemat.Unitstroke(pu)
										RSWIN_DESC.rst.PU = pu
										flag7 = PREDICT.Predict(True, "")
										If flag7 Then
											flag7 = DESIGN.SurfCalc(False)
										End If
										RSWIN_DESC.rst = rst
									End If
								End If
								Dim text2 As String = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num7, False, flag2, flag3, False, False)
								If RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru And RSWIN_DESC.bOneGuruFile Then
									Dim sSaveFile As String = RSWIN_DESC.sAIFilename.ToLower().Replace(".xrvx", ".rsvx")
									RSWIN_DESC.bAIScoreImproved = False
									Dim text2 As String = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num7, False, flag2, flag3, False, False)
									Dim num10 As Single = num7
									If CDbl(num10) < 0.98 Then
										Dim num11 As Integer = 0
										While CDbl(num7) < 0.98 And num11 < 2
											RSWIN_DESC.bSuppressWarningMessages = True
											Me.TryToImproveScore(num, num2, num3, num4, num5, num6, num10)
											text2 = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num7, False, flag2, flag3, False, False)
											If RSWIN_DESC.rst.SPM < 9F And CDbl(RSWIN_DESC.rst.GearboxLoading(RSWIN_DESC.i2Score)) <= 0.9 Then
												Dim fOrigTotalScore As Single = num10
												Dim flag8 As Boolean = False
												Dim setup_GURUTEMPDIR As String = ""
												Dim text3 As String = ""
												Me.ExtraSmallerGearboxAndSLCheck(num, num2, num3, num4, num5, num6, fOrigTotalScore, flag8, setup_GURUTEMPDIR, text3)
												text2 = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num7, False, flag2, flag3, False, False)
											Else
												Me.ExtraSmallerGearboxCheck(num, num2, num3, num4, num5, num6, num7, CDbl(RSWIN_DESC.rst.GearboxLoading(RSWIN_DESC.i2Score)) < 0.85)
												text2 = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num7, False, flag2, flag3, False, False)
											End If
											If RODUTIL.CheckForOverloadedRods() Or (CDbl(RSWIN_DESC.rst.StructL) > 0.95 And RSWIN_DESC.rst.SPM < 9F And CDbl(RSWIN_DESC.rst.SystemEff) > 0.42) Then
												Dim flag11 As Boolean = Me.TrySmallerPlungerSize(num, num2, num3, num4, num5, num6, num7)
												text2 = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num7, False, flag2, flag3, False, False)
												If(If((-If((flag11 > False), 1S, 0S)), 1S, 0S) And Not RSWIN_DESC.rst.PU.RequiredRotation And If((-If((num7 < 1F > False), 1S, 0S)), 1S, 0S)) <> 0S Then
													Me.TryDifferentRotationDirection(num, num2, num3, num4, num5, num6, num7)
													text2 = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num7, False, flag2, flag3, False, False)
												End If
											End If
											text2 = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num7, False, flag2, flag3, False, False)
											If(RSWIN_DESC.SETUP_bUseFGlassWithSteelOnBottom AndAlso flag3) Or (num7 > RSWIN_DESC.fTemplateTotalAIScore And RSWIN_DESC.fTemplateTotalAIScore <> 0F And RSWIN_DESC.SETUP_TimesAvgRodTBGFricCoeff = 1F) Then
												RSWIN_DESC.bAIScoreImproved = Me.TryToImproveRodLoadingScoreOnly(num2, num10, False, num7)
												text2 = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num7, False, flag2, flag3, False, False)
											End If
											If CDbl(num7) >= 0.98 And num4 < 100 Then
												Dim flag11 As Boolean = Me.TryLargerPlungerSize(num, num2, num3, num4, num5, num6, num7)
												text2 = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num7, False, flag2, flag3, False, False)
												If(If((-If((flag11 > False), 1S, 0S)), 1S, 0S) And Not RSWIN_DESC.rst.PU.RequiredRotation And If((-If((num7 < 1F > False), 1S, 0S)), 1S, 0S)) <> 0S Then
													Me.TryDifferentRotationDirection(num, num2, num3, num4, num5, num6, num7)
													text2 = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num7, False, flag2, flag3, False, False)
												End If
											End If
											If(num7 > num10 And CDbl(num7) > 0.93) Or (num7 > RSWIN_DESC.fTemplateTotalAIScore And RSWIN_DESC.fTemplateTotalAIScore <> 0F And RSWIN_DESC.SETUP_TimesAvgRodTBGFricCoeff = 1F) Then
												RSWIN_DESC.bAIScoreImproved = True
											End If
											If RSWIN_DESC.bAIScoreImproved AndAlso CDbl((RSWIN_DESC.rst.BPDsurface / RSWIN_DESC.rst.TargetBFPD)) < 0.965 Then
												RSWIN_DESC.bAIScoreImproved = False
											End If
											num11 += 1
										End While
										RSWIN_DESC.bSuppressWarningMessages = False
										Me.SaveAIFile(sSaveFile)
										Me.StopRunAni()
									ElseIf(CDbl(num10) >= 0.98 And num2 < 100) Or (RSWIN_DESC.SETUP_bUseFGlassWithSteelOnBottom AndAlso flag3) Or (num7 > RSWIN_DESC.fTemplateTotalAIScore And RSWIN_DESC.fTemplateTotalAIScore <> 0F And RSWIN_DESC.SETUP_TimesAvgRodTBGFricCoeff = 1F) Then
										RSWIN_DESC.bSuppressWarningMessages = True
										RSWIN_DESC.bAIScoreImproved = Me.TryToImproveRodLoadingScoreOnly(num2, num10, False, num7)
										Dim num9 As Integer = If((-If((flag10 > False), 1, 0)), 1, 0)
										Dim flag8 As Boolean = False
										Me.MakeRun(num9, flag8)
										flag10 = (num9 <> 0)
										If RSWIN_DESC.bAIScoreImproved AndAlso CDbl((RSWIN_DESC.rst.BPDsurface / RSWIN_DESC.rst.TargetBFPD)) < 0.965 Then
											RSWIN_DESC.bAIScoreImproved = False
										End If
										text2 = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num7, False, flag2, flag3, False, False)
										Me.TryToImproveSysEffOnly(num, num2, num3, num4, num5, num6, num10)
										text2 = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num7, False, flag2, flag3, False, False)
										If RSWIN_DESC.rst.SPM < 9F And CDbl(RSWIN_DESC.rst.GearboxLoading(RSWIN_DESC.i2Score)) <= 0.9 Then
											Dim fOrigTotalScore2 As Single = num10
											flag8 = False
											Dim text3 As String = ""
											Dim setup_GURUTEMPDIR As String = ""
											Me.ExtraSmallerGearboxAndSLCheck(num, num2, num3, num4, num5, num6, fOrigTotalScore2, flag8, text3, setup_GURUTEMPDIR)
											text2 = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num7, False, flag2, flag3, False, False)
										Else
											Me.ExtraSmallerGearboxCheck(num, num2, num3, num4, num5, num6, num10, CDbl(RSWIN_DESC.rst.GearboxLoading(RSWIN_DESC.i2Score)) < 0.85)
											text2 = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num7, False, flag2, flag3, False, False)
										End If
										RSWIN_DESC.bSuppressWarningMessages = False
										Me.SaveAIFile(sSaveFile)
										Me.StopRunAni()
									Else
										RSWIN_DESC.bSuppressWarningMessages = True
										Me.TryToImproveSysEffOnly(num, num2, num3, num4, num5, num6, num10)
										If RSWIN_DESC.rst.SPM < 9F And CDbl(RSWIN_DESC.rst.GearboxLoading(RSWIN_DESC.i2Score)) <= 0.9 Then
											Dim fOrigTotalScore3 As Single = num10
											Dim flag8 As Boolean = False
											Dim text3 As String = ""
											Dim setup_GURUTEMPDIR As String = ""
											Me.ExtraSmallerGearboxAndSLCheck(num, num2, num3, num4, num5, num6, fOrigTotalScore3, flag8, text3, setup_GURUTEMPDIR)
											text2 = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num7, False, flag2, flag3, False, False)
										Else
											Me.ExtraSmallerGearboxCheck(num, num2, num3, num4, num5, num6, num10, CDbl(RSWIN_DESC.rst.GearboxLoading(RSWIN_DESC.i2Score)) < 0.85)
											text2 = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num7, False, flag2, flag3, False, False)
										End If
										RSWIN_DESC.bSuppressWarningMessages = False
										Me.SaveAIFile(sSaveFile)
										Me.StopRunAni()
									End If
								Else
									Me.StopRunAni()
								End If
								If bShowResults Then
									Me.RemoveForms()
									RSWIN_DESC.bBackFromSetLines = False
									Application.DoEvents()
									Me.Message("Loading Output Results")
									Me.AddResults(True)
								End If
							ElseIf RSWIN_DESC.bChangeMotorSize And Not RSWIN_DESC.bAbortRun Then
								Me.StopRunAni()
								Me.AddMotorData(True)
							End If
							Util.UnbusyCursor()
							Application.DoEvents()
							Me.ToolbarButtonSetState(-1, True)
							If Not flag10 And Not RSWIN_DESC.rst.gbAutomatic Then
								Me.ToolbarButtonSetState2(2, False)
							ElseIf Not RSWIN_DESC.rst.gbAutomatic AndAlso bShowResults Then
								Me.ToolbarButtonSetState2(2, True)
							End If
							Me.$STATIC$mnuRunPrediction_Click$20112$bRunning = 0
							RSWIN_DESC.bPredictiveRunning = (Me.$STATIC$mnuRunPrediction_Click$20112$bRunning <> 0)
						End If
					Catch ex9 As Exception
						Dim sMsg3 As String = "Error in Run : " + ex9.Message
						Dim sMsgType3 As String = ""
						Dim bClosing3 As Boolean = False
						Dim dialogResult As DialogResult = DialogResult.OK
						Util.SendMessage(sMsg3, sMsgType3, bClosing3, dialogResult)
						Me.StopRunAni()
					End Try
				End If
				RSWIN_DESC.bPredictiveRunning = False
			Catch ex10 As Exception
				Dim sMsg4 As String = "Error in Run : " + ex10.Message
				Dim sMsgType4 As String = ""
				Dim bClosing4 As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg4, sMsgType4, bClosing4, dialogResult)
				Me.StopRunAni()
			End Try
		End Sub

		Private Sub StartRunAni()
			Try
				If Not RSWIN_DESC.rst.gbAutomatic Then
					Me.AniRun.FileName = Application.StartupPath + "\Hourglass.AVI"
					If(If((-If((Not RSWIN_DESC.bRodStarD > False), 1S, 0S)), 1S, 0S) Or Not RSWIN_DESC.SETUP_RunForSpeed) <> 0S Then
						Me.AniRun.Left = Me.tbrToolBar2.Left
					Else
						' The following expression was wrapped in a checked-expression
						Me.AniRun.Left = Me.tbrToolBar2.Left + Me.tbrToolBar2.ButtonSize.Width
					End If
					Me.AniRun.Visible = True
					Me.AniRun.BringToFront()
					Me.AniRun.Play()
					If RSWIN_DESC.bRodStarD Then
						Me.tbrAbort.Visible = True
						RSWIN_DESC.bAbortRun = False
					End If
					Util.BusyCursor()
					If(RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru) AndAlso Me.btnGuru.Visible Then
						Me.lblGURU.BackColor = Color.LightGreen
						Me.Message(Me.sCalcInProgress + RSWIN_DESC.sPleaseWait)
					End If
					Application.DoEvents()
					Application.DoEvents()
				End If
			Catch ex As Exception
			End Try
		End Sub

		Public Sub StopRunAni()
			Try
				Me.AniRun.Visible = False
				Me.AniRun.SendToBack()
				Me.AniRun.[Stop]()
				RSWIN_DESC.bPredictiveRunning = False
				If RSWIN_DESC.bRodStarD Then
					Me.tbrAbort.Visible = False
				End If
				If(RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru) AndAlso Me.btnGuru.Visible Then
					Me.lblGURU.BackColor = Color.LightGray
					Me.StopAIAni()
				End If
				Util.UnbusyCursor()
				Application.DoEvents()
				Application.DoEvents()
			Catch ex As Exception
			End Try
		End Sub

		Public Sub OutputInput(bNewFile As Boolean)
		End Sub

		Public Sub CheckInput()
		End Sub

		Friend Overridable Property tbrToolBar2 As ToolBar
			Get
				Return Me._tbrToolBar2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolBar)
				Dim value2 As ToolBarButtonClickEventHandler = AddressOf Me.tbrToolBar2_ButtonClick
				If Me._tbrToolBar2 IsNot Nothing Then
					RemoveHandler Me._tbrToolBar2.ButtonClick, value2
				End If
				Me._tbrToolBar2 = value
				If Me._tbrToolBar2 IsNot Nothing Then
					AddHandler Me._tbrToolBar2.ButtonClick, value2
				End If
			End Set
		End Property

		Private Sub tbrToolBar2_ButtonClick(sender As Object, e As ToolBarButtonClickEventArgs)
			Try
				Select Case Me.tbrToolBar2.Buttons.IndexOf(e.Button)
					Case 0
						RSWIN_DESC.SETUP_RunForSpeed = 0S
						Me.mnuRunPrediction_Click(True)
					Case 1
						If RSWIN_DESC.bRodStarD Then
							RSWIN_DESC.SETUP_RunForSpeed = -1S
							Me.mnuRunPrediction_Click(True)
						End If
					Case 2
						Me.mnuWindowViewReport_Click(Me.mnuWindowViewReport, New EventArgs())
					Case 3
						Dim frmSendEmail As frmSendEmail = New frmSendEmail()
						Me.ResetClock()
						frmSendEmail.ShowDialog()
					Case 4
						Me.MakePrintout(0S)
					Case 5
						Me.mnuToolsExportMCM.PerformClick()
					Case 8
						If RSWIN_DESC.rst.gbAutomaticEnabled Then
							Me.StartAutomaticBatchMode(True)
						End If
				End Select
			Catch ex As Exception
			End Try
		End Sub

		Friend Overridable Property tbrToolBar3 As ToolBar
			Get
				Return Me._tbrToolBar3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolBar)
				Dim value2 As ToolBarButtonClickEventHandler = AddressOf Me.tbrToolBar3_ButtonClick
				If Me._tbrToolBar3 IsNot Nothing Then
					RemoveHandler Me._tbrToolBar3.ButtonClick, value2
				End If
				Me._tbrToolBar3 = value
				If Me._tbrToolBar3 IsNot Nothing Then
					AddHandler Me._tbrToolBar3.ButtonClick, value2
				End If
			End Set
		End Property

		Private Sub PopulateToolbarContextMenu(nFiles As Integer)
			Me.ctxMenu4ToolBar.MenuItems.Clear()
			Dim num As Integer = 0
			Dim num2 As Integer = nFiles - 1
			For i As Integer = num To num2
				Me.ctxMenu4ToolBar.MenuItems.Add(New MenuItem(Me.asRecentFiles(i), AddressOf Me.ctxMenu4ToolBar_Clicked))
			Next
		End Sub

		Private Sub ctxMenu4ToolBar_Clicked(sender As Object, e As EventArgs)
			Dim menuItem As MenuItem = CType(sender, MenuItem)
			Dim flag As Boolean = False
			Me.ResetClock()
			Dim num As Short = 0S
			Dim num2 As Short = CShort((Me.ctxMenu4ToolBar.MenuItems.Count - 1))
			Dim num4 As Short
			For num3 As Short = num To num2
				If menuItem Is Me.ctxMenu4ToolBar.MenuItems(CInt(num3)) Then
					num4 = num3
					flag = True
					Exit For
				End If
			Next
			If flag Then
				Dim flag2 As Boolean
				If RSWIN_DESC.rst.gbInputDataChanged Then
					Dim msg As String = Me.sARSOVERWRITE
					Dim bDefaultYes As Boolean = True
					flag2 = False
					If Not Util.YesNo(msg, bDefaultYes, flag2) Then
						Return
					End If
				End If
				Dim iFile As Short = num4
				Dim openFileDialog As OpenFileDialog = Nothing
				Dim text As String = ""
				flag2 = False
				Me.OpenFile(iFile, openFileDialog, text, flag2)
				If RSWIN_DESC.bExpert Then
					If RSWIN_DESC.SETUP_bGuru Then
						RSWIN_DESC.RECENTFILES = "AI Recent Files"
					Else
						RSWIN_DESC.RECENTFILES = "XRODV Recent Files"
					End If
				End If
				Me.SelectRecentFile(num4)
				Me.SaveRecentFiles(RSWIN_DESC.RECENTFILES, RSWIN_DESC.sINIFile)
				Me.LoadRecentFiles(RSWIN_DESC.THETA_INI, RSWIN_DESC.RECENTFILES)
			End If
		End Sub

		Public Sub mnuHelpAbout_Click(sender As Object, e As EventArgs)
			Me.FAboutSplash.MinDisplay = 0
			Me.FAboutSplash.sProgramName = RSWIN_DESC.sProgramLongName
			Me.ResetClock()
			Dim num As Integer
			If num > 0 And Not RSWIN_DESC.bUseTLM32 Then
				Me.FAboutSplash.SerialNumber = num
			ElseIf RSWIN_DESC.bUseTLM32 Then
				Me.FAboutSplash.SerialNumber = Conversions.ToInteger(Me.mTLM32.SerialNum)
			End If
			Dim faboutSplash As FAboutSplash = Me.FAboutSplash
			Dim text As String = ""
			Dim text2 As String = ""
			faboutSplash.SplashOn(text, text2)
			Application.DoEvents()
		End Sub

		Public Sub MakePrintout(bAskFirst As Short)
			Dim dlgPrint As dlgPrint = New dlgPrint()
			Dim flag As Boolean = False
			Dim num As Integer = 35
			Dim form As Form
			Try
				Dim formName As String = "BatchLog"
				Dim batchLog As BatchLog
				form = batchLog
				Dim flag2 As Boolean = Me.ReturnMdiForm(formName, form)
				batchLog = CType(form, BatchLog)
				flag = flag2
				If flag AndAlso Not batchLog.Visible Then
					flag = False
				End If
			Catch ex As Exception
				flag = False
			End Try
			If RSWIN_DESC.rst.gbBatch OrElse flag Then
				Me.Message("Printing the batch run log." + RSWIN_DESC.sPleaseWait)
				Dim formName2 As String = "BatchLog"
				Dim batchLog2 As BatchLog
				form = batchLog2
				Me.ReturnMdiForm(formName2, form)
				batchLog2 = CType(form, BatchLog)
				Dim array As String()
				batchLog2.GetBatchList(array)
				Me.InitializeBatchLogXML(array)
				Dim obj As Object
				Try
					obj = New rptBatchLog()
				Catch ex2 As Exception
				End Try
				NewLateBinding.LateSet(obj, Nothing, "bPrint", New Object() { True }, Nothing, Nothing)
				NewLateBinding.LateSet(obj, Nothing, "NumFiles", New Object() { RSWIN_DESC.mcBatchFiles }, Nothing, Nothing)
				Try
					Dim xmldataSource As XMLDataSource = New XMLDataSource()
					xmldataSource.LoadXML(RSWIN_DESC.sBatchLogXML)
					NewLateBinding.LateSet(obj, Nothing, "ds", New Object() { xmldataSource }, Nothing, Nothing)
					NewLateBinding.LateSet(obj, Nothing, "DataSource", New Object() { xmldataSource }, Nothing, Nothing)
				Catch ex3 As Exception
				End Try
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, Nothing, "ds", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "ValidateOnParse", New Object() { True }, Nothing, Nothing, False, True)
				CType(NewLateBinding.LateGet(obj, Nothing, "ds", New Object(-1) {}, Nothing, Nothing, Nothing), XMLDataSource).RecordsetPattern = "//Data/Entries/Row"
				NewLateBinding.LateSet(obj, Nothing, "TotalPageNumber", New Object() { CInt(Math.Round(CDbl(array.Count()) / CDbl(num) + 0.5)) }, Nothing, Nothing)
				NewLateBinding.LateSet(obj, Nothing, "ThisPageNumber", New Object() { 1 }, Nothing, Nothing)
				NewLateBinding.LateSet(obj, Nothing, "NumberOfLines", New Object() { array.Count() }, Nothing, Nothing)
				Try
					NewLateBinding.LateCall(obj, Nothing, "Run", New Object() { False }, Nothing, Nothing, Nothing, True)
					If Conversions.ToBoolean(NewLateBinding.LateGet(obj, Nothing, "bPrint", New Object(-1) {}, Nothing, Nothing, Nothing)) Then
						NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "Document", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Printer", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "PrinterSettings", New Object() { RSWIN_DESC.pd.PrinterSettings }, Nothing, Nothing, False, True)
						NewLateBinding.LateCall(NewLateBinding.LateGet(obj, Nothing, "Document", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Print", New Object() { False, False }, Nothing, Nothing, Nothing, True)
						obj = Nothing
					Else
						Me.Viewer1.Document = CType(NewLateBinding.LateGet(obj, Nothing, "Document", New Object(-1) {}, Nothing, Nothing, Nothing), Document)
						Me.pnlBatchLog.Left = 0
						Me.pnlBatchLog.Visible = True
					End If
				Catch ex4 As Exception
				End Try
				Application.DoEvents()
				Application.DoEvents()
				Me.Message("")
				Return
			End If
			Dim formName3 As String = "Results"
			Dim results As Results
			form = results
			Dim flag3 As Boolean = Me.ReturnMdiForm(formName3, form)
			results = CType(form, Results)
			Dim flag4 As Boolean = flag3
			If flag4 Then
				Util.BusyCursor()
				If results.Viewer1.Document IsNot Nothing Then
					results.Viewer1.Document.Print()
				End If
				Util.UnbusyCursor()
			ElseIf Not RSWIN_DESC.rst.gbBatch Then
				Util.UnbusyCursor()
				MessageBox.Show("Report Results window must be visible in order to print.", "Need Results to Print", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			End If
		End Sub

		Public Sub StartAutomaticBatchMode(bShowMessages As Boolean)
			Dim rswinSetup As RswinSetup = New RswinSetup()
			RSWIN_DESC.rst.gbAutomatic = True
			Try
				Me.RemoveChildForm("BatchLog", False)
			Catch ex As Exception
			End Try
			Try
				Dim num As Integer = -1
				If Information.IsDBNull(RSWIN_DESC.SETUP_BeginTime) Or Strings.Len(RSWIN_DESC.SETUP_RSWINDIR) = 0 Then
					num = 0
				End If
				If Not num <> 0 Then
					Dim msg As String = Me.sDYWAutoBatchSetup
					Dim bDefaultYes As Boolean = True
					Dim flag As Boolean = False
					If Util.YesNo(msg, bDefaultYes, flag) Then
						Cursor.Current = Cursors.WaitCursor
						rswinSetup.Show()
						rswinSetup.DefaultNode = "Batch Mode"
					End If
				Else
					Dim flag2 As Boolean
					If RSWIN_DESC.SETUP_ExitIfIdle <> 0S Then
						Dim msg2 As String = "Turning on the automatic batch mode will disable the 'exit if idle' timer until the automatic batch is completed. Continue?"
						Dim bDefaultYes2 As Boolean = True
						Dim flag As Boolean = False
						flag2 = Util.YesNo(msg2, bDefaultYes2, flag)
					Else
						flag2 = True
					End If
					If flag2 Then
						RSWIN_DESC.SETUP_ExitIfIdle = 0S
						Me.tmrClock.Enabled = False
						Dim text As String
						Dim text2 As String
						Dim text3 As String
						Dim regProfileString As Integer
						If bShowMessages Then
							Me.BringUpBatchOptForm()
							If RSWIN_DESC.CancelBatch Then
								Return
							End If
							Dim sMsg As String = String.Concat(New String() { "The program will scan for and process files at ", RSWIN_DESC.SETUP_BeginTime.ToLongDateString(), " ", RSWIN_DESC.SETUP_BeginTime.ToLongTimeString(), ".  To cancel automatic batch mode, double-click the icon at the bottom of the screen." })
							Dim sMsgType As String = "Batch Message"
							Dim bClosing As Boolean = False
							Dim dialogResult As DialogResult = DialogResult.OK
							Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
						Else
							text = Strings.Space(255)
							text2 = "AutoBatchPrintLog"
							text3 = "-1"
							regProfileString = RSWIN.GetRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text3, text, False)
							text = text.Substring(0, regProfileString)
							If Versioned.IsNumeric(text) Then
								RSWIN_DESC.rst.gbPrintBatchLog = (Conversions.ToInteger(text) <> 0)
							Else
								Dim text4 As String = Strings.UCase(text)
								If Operators.CompareString(text4, "FALSE", False) <> 0 Then
									If Operators.CompareString(text4, "NO", False) <> 0 Then
										If Operators.CompareString(text4, "OFF", False) <> 0 Then
											RSWIN_DESC.rst.gbPrintBatchLog = True
											GoTo IL_1E3
										End If
									End If
								End If
								RSWIN_DESC.rst.gbPrintBatchLog = False
							End If
						End If
						IL_1E3:
						If Me.Clock Is Nothing Then
							Me.Clock = New Clock()
						End If
						Application.DoEvents()
						Me.Hide()
						Application.DoEvents()
						Me.Clock.WindowState = FormWindowState.Minimized
						Me.Clock.Show()
						Application.DoEvents()
						Me.Text = " " + Me.Text
						text = Strings.Space(255)
						text3 = "BatchInterval"
						text2 = "30000"
						regProfileString = RSWIN.GetRegProfileString(RSWIN_DESC.SECT_RSWIN, text3, text2, text, False)
						text = text.Substring(0, regProfileString)
						Dim num2 As Long
						If Versioned.IsNumeric(text) Then
							num2 = Conversions.ToLong(text)
						Else
							num2 = 30000L
						End If
						Me.Clock.dwInterval = CInt(num2)
						Me.Clock.EnableBatchTimer()
					End If
				End If
			Catch ex2 As Exception
			End Try
		End Sub

		Public Function BatchCancelRequested(bFoundFrm As Boolean, sTag As String) As Boolean
			Dim result As Boolean = False
			Dim flag As Boolean = True
			If flag <> RSWIN_DESC.rst.gbAutomatic Then
				If flag <> Not bFoundFrm Then
					If flag <> (Strings.Len(sTag) = 0) Then
						result = True
					End If
				End If
			End If
			Return result
		End Function

		Public Sub BatchProcess(Optional ByRef sDefaultFolder As String = "")
			Dim flag As Boolean = False
			Dim dlgBatchOpts As dlgBatchOpts = New dlgBatchOpts()
			Dim text As String = ""
			Dim flag2 As Boolean = False
			Dim flag3 As Boolean = False
			Dim flag4 As Boolean = False
			Dim flag5 As Boolean = False
			Dim flag6 As Boolean = RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru And RSWIN_DESC.bXRODAdmin And RSWIN_DESC.SETUP_bAdminDebug
			Dim setup_bAdminDebug As Boolean = RSWIN_DESC.SETUP_bAdminDebug
			Dim flag7 As Boolean = False
			Dim text2 As String = ""
			Dim flag8 As Boolean = False
			Dim num As Integer = 0
			RSWIN_DESC.bRunStarRunning = True
			Dim flag9 As Boolean = False
			Me.bDisplayBatchFileOutput = False
			Dim num2 As Integer = 0
			Dim flag10 As Boolean = False
			Dim results As Results = New Results()
			Dim wellInfo As WellInfo = New WellInfo()
			Dim num3 As Single = 0F
			Dim num4 As Integer = 0
			Dim num5 As Integer = 0
			Dim num6 As Integer = 0
			Dim num7 As Integer = 0
			Dim num8 As Integer = 0
			Dim num9 As Integer = 0
			Dim flag11 As Boolean = False
			RSWIN_DESC.bSuppressWarningMessages = False
			Dim flag12 As Boolean
			Dim flag13 As Boolean
			Dim flag15 As Boolean
			Dim text5 As String
			If RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru Then
				flag4 = True
				flag12 = False
				flag13 = False
				flag = False
				Dim text3 As String = "BatchSaveWorksheet"
				Dim flag14 As Boolean = True
				RSWIN_DESC.SETUP_BatchSaveWorksheet = If((-If((RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_RSWIN, text3, flag14) > False), 1, 0)), 1, 0)
				text3 = "BatchViewWorksheet"
				flag14 = True
				RSWIN_DESC.SETUP_BatchViewWorksheet = If((-If((RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_RSWIN, text3, flag14) > False), 1, 0)), 1, 0)
				flag15 = (RSWIN_DESC.SETUP_BatchSaveWorksheet <> 0)
				If flag15 Then
					text3 = "WK1Directory"
					Dim text4 As String = ""
					Dim regProfileString As Integer = RSWIN.GetRegProfileString(RSWIN_DESC.SECT_RSWIN, text3, text4, text5, False)
					RSWIN_DESC.SETUP_WK1Dir = Strings.Trim(text5.Substring(0, regProfileString))
					text = RSWIN_DESC.SETUP_WK1Dir + "AI_Batch.xls"
					If RSWIN_DESC.rst_save.WellName IsNot Nothing AndAlso Operators.CompareString(RSWIN_DESC.rst_save.WellName.Trim(), "", False) <> 0 Then
						text = RSWIN_DESC.SETUP_WK1Dir + "AI_Batch_" + RSWIN_DESC.rst_save.WellName.Trim() + ".xls"
					End If
					If Operators.CompareString(text, "", False) <> 0 Then
						RSWIN_DESC.EXCELBATCHFILENAME = Util.FileName(text)
					End If
				End If
			End If
			RSWIN_DESC.miBatchCurFile = 0
			Dim text6 As String
			Dim flag16 As Boolean = Batch.BatchGetNextFileName(text6)
			If RSWIN_DESC.bRodStarD Then
				RSWIN_DESC.SETUP_RunForSpeed = 0S
			End If
			flag9 = False
			Dim text3 As String
			Dim text4 As String
			Dim text7 As String
			Dim batchLog As BatchLog
			While flag16 And Not flag9
				If num2 = 0 Then
					If Conversions.ToBoolean(Operators.NotObject(Batch.BatchCheckDiskSpace(0))) Then
						Me.StopRunAni()
						Return
					End If
					Dim form As Form
					If RSWIN_DESC.rst.gbAutomatic Then
						flag12 = (RSWIN_DESC.SETUP_BatchPrintouts <> 0)
						flag15 = (RSWIN_DESC.SETUP_BatchSaveWorksheet <> 0)
						flag13 = (RSWIN_DESC.SETUP_BatchSkipProcessedFiles <> 0)
						If Not RSWIN_DESC.SETUP_BatchSaveWorksheet <> 0 Then
							text7 = ""
						Else
							If RSWIN_DESC.SETUP_WK1Dir.Length > 0 Then
								text7 = RSWIN_DESC.SETUP_WK1Dir
							Else
								text7 = RSWIN_DESC.rst.RSTDir
							End If
							If Operators.CompareString(text7.Substring(text7.Length - 1, 1), "\", False) <> 0 Then
								text7 += "\"
							End If
							Dim str As String = text7
							Dim str2 As String = "rst_"
							Dim now As DateTime = DateAndTime.Now
							text4 = "MMddyyyy_hhmm"
							text7 = str + str2 + Util.Format(now, text4) + ".xls"
							text7 = text7.Trim()
						End If
						Try
							Me.Clock.StopAutomaticBatch()
							RSWIN_DESC.rst.gbAutomatic = True
							RSWIN_DESC.rst.gbBatch = True
						Catch ex As Exception
						End Try
						Try
							Dim formName As String = "BatchLog"
							form = batchLog
							Dim flag17 As Boolean = Me.ReturnMdiForm(formName, form)
							batchLog = CType(form, BatchLog)
							flag10 = flag17
							If flag10 Then
								Me.RemoveChildForm("BatchLog", False)
							End If
							Me.AddBatchLog(True)
							Dim formName2 As String = "BatchLog"
							form = batchLog
							Dim flag18 As Boolean = Me.ReturnMdiForm(formName2, form)
							batchLog = CType(form, BatchLog)
							flag10 = flag18
							Batch.doc_batchlog = batchLog
							GoTo IL_4FE
						Catch ex2 As Exception
							GoTo IL_4FE
						End Try
						GoTo IL_364
					End If
					GoTo IL_364
					IL_4FE:
					If flag15 Then
						If Operators.CompareString(sDefaultFolder, "", False) = 0 Then
							sDefaultFolder = "c:\"
						End If
						If Not RSWIN_DESC.rst.gbAutomatic Then
							text7 = sDefaultFolder + RSWIN_DESC.EXCELBATCHFILENAME
						End If
						If Not flag Then
							If RSWIN_DESC.SETUP_ExcelInstalled Then
								flag = Conversions.ToBoolean(NewLateBinding.LateGet(RSWIN_DESC.objExcel, Nothing, "XLWorkSheetCreate", New Object(-1) {}, Nothing, Nothing, Nothing))
							Else
								Dim objExcel As Object = RSWIN_DESC.objExcel
								Dim type As Type = Nothing
								Dim text8 As String = "XLWorkSheetCreate"
								Dim array As Object() = New Object() { text7 }
								Dim array2 As Object() = array
								Dim array3 As String() = Nothing
								Dim array4 As Type() = Nothing
								Dim array5 As Boolean() = New Boolean() { True }
								Dim obj As Object = NewLateBinding.LateGet(objExcel, type, text8, array2, array3, array4, array5)
								If array5(0) Then
									text7 = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array(0)), GetType(String)))
								End If
								flag = Conversions.ToBoolean(obj)
							End If
						End If
						Application.DoEvents()
						Application.DoEvents()
						Application.DoEvents()
						Application.DoEvents()
						Application.DoEvents()
						Application.DoEvents()
						If Not flag2 Then
							Batch.BatchAddWorksheetData(True, flag7)
						End If
					End If
					Util.BusyCursor()
					RSWIN_DESC.rst.gbBatch = True
					Me.ToolbarButtonSetState(-1, False)
					Me.tbrToolBar2.Enabled = True
					Me.ToolbarButtonSetState2(4, True)
					Application.DoEvents()
					GoTo IL_622
					IL_364:
					Me.frmHowToStart.Hide()
					If Not RSWIN_DESC.bRunGuru Then
						dlgBatchOpts.bRST = Me.m_bRST
						dlgBatchOpts.ShowDialog()
						If RSWIN_DESC.rst.gbAutomatic Then
							dlgBatchOpts.Hide()
						Else
							Me.StartRunAni()
						End If
						If RSWIN_DESC.CancelBatch Then
							dlgBatchOpts.Hide()
							Me.StopRunAni()
							Return
						End If
						flag12 = dlgBatchOpts.chkPrintResults.Checked
						flag15 = dlgBatchOpts.chkSaveWorksheet.Checked
						If Not RSWIN_DESC.rst.gbAutomatic AndAlso flag15 Then
							text4 = "WK1Directory"
							text3 = ""
							Dim regProfileString As Integer = RSWIN.GetRegProfileString(RSWIN_DESC.SECT_RSWIN, text4, text3, text5, False)
							RSWIN_DESC.SETUP_WK1Dir = Strings.Trim(text5.Substring(0, regProfileString))
							FILEIO.SelectOutputFile(text, RSWIN_DESC.SETUP_WK1Dir, RSWIN_DESC.sXLSFileType, RSWIN_DESC.EXCELBATCHFILENAME, ".xls", "Save File As")
							If Operators.CompareString(text, "", False) <> 0 Then
								RSWIN_DESC.EXCELBATCHFILENAME = Util.FileName(text)
							End If
						End If
						flag13 = dlgBatchOpts.chkSkipProcessedFiles.Checked
						dlgBatchOpts.Hide()
					Else
						Me.StartRunAni()
					End If
					Dim formName3 As String = "BatchLog"
					form = batchLog
					Dim flag19 As Boolean = Me.ReturnMdiForm(formName3, form)
					batchLog = CType(form, BatchLog)
					flag10 = flag19
					If flag10 Then
						Me.RemoveChildForm("BatchLog", False)
					End If
					Me.RemoveChildForms()
					Me.AddBatchLog(True)
					Dim formName4 As String = "BatchLog"
					form = batchLog
					Dim flag20 As Boolean = Me.ReturnMdiForm(formName4, form)
					batchLog = CType(form, BatchLog)
					flag10 = flag20
					Batch.doc_batchlog = batchLog
					If RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru Then
						Me.StopAIAni()
						Me.btnGuru.SendToBack()
						Application.DoEvents()
						Application.DoEvents()
						GoTo IL_4FE
					End If
					GoTo IL_4FE
				End If
				IL_622:
				num2 += 1
				Dim flag21 As Boolean

					Dim fTemplateTotalAIScore As Single
					If num2 = 1 And RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru Then
						Batch.BatchMessage(" ")
						If Strings.InStr(RSWIN_DESC.sAIFilename.ToLower(), "untitled", CompareMethod.Binary) <= 0 Then
							Batch.BatchMessage("XROD-V AI Batch Run (" + Util.FileName(RSWIN_DESC.sAIFilename) + "):    ")
						Else
							Batch.BatchMessage("XROD-V AI Batch Run:    ")
						End If
						Batch.BatchMessage("  Company name: " + RSWIN_DESC.rst_save.ACompanyName + ",  Well name: " + RSWIN_DESC.rst_save.WellName)
						If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
							Batch.BatchMessage(String.Concat(New String() { "  Pump depth: ", Conversions.ToString(RSWIN_DESC.rst_save.PumpDepth), " (", RSWIN_DESC.ft.ToLower(), "),  Target production: ", Conversions.ToString(RSWIN_DESC.rst_save.TargetBFPD), " (", RSWIN_DESC.bpd.ToLower(), ")" }))
							Dim str3 As String = "  Run time: "
							Dim str4 As String = Conversions.ToString(RSWIN_DESC.rst_save.Runtime)
							Dim str5 As String = " (hrs),  Pump Efficiency: "
							Dim num10 As Single = RSWIN_DESC.rst_save.PumpEfficiency / 100F
							text4 = "###%"
							Batch.BatchMessage(str3 + str4 + str5 + Util.Format(num10, text4))
						Else
							Dim array6 As String() = New String(8) {}
							array6(0) = "  Pump depth: "
							Dim array7 As String() = array6
							Dim num11 As Integer = 1
							fTemplateTotalAIScore = RSWIN_DESC.rst_save.PumpDepth * RSWIN_DESC.FT__M
							text3 = "#.##"
							array7(num11) = Util.Format(fTemplateTotalAIScore, text3)
							array6(2) = " ("
							array6(3) = RSWIN_DESC.m.ToLower()
							array6(4) = "),  Target production: "
							Dim array8 As String() = array6
							Dim num12 As Integer = 5
							Dim num10 As Single = RSWIN_DESC.rst_save.TargetBFPD * RSWIN_DESC.BPD__M3D
							text4 = "#.#"
							array8(num12) = Util.Format(num10, text4)
							array6(6) = " ("
							array6(7) = RSWIN_DESC.m3D.ToLower()
							array6(8) = ")"
							Batch.BatchMessage(String.Concat(array6))
							Batch.BatchMessage("  Run time: " + Conversions.ToString(RSWIN_DESC.rst_save.Runtime) + " (hrs) ")
						End If
						If RSWIN_DESC.SETUP_bUseSteelRodsOnly And RSWIN_DESC.SETUP_bUseFGlassWithSteelOnBottom Then
							Batch.BatchMessage("  Designing for both steel rods and fiberglass with steel on bottom.")
							Batch.BatchMessage("  Steel rod service factor: " + Conversions.ToString(RSWIN_DESC.AIFilePreferences.ServiceFactorPreference) + ".")
							Batch.BatchMessage("  Preferred rod type stronger than API grade D: " + RODUTIL.RodGrade(RSWIN_DESC.HSGradeRod) + " ")
							Batch.BatchMessage("  Preferred fiberglass rod: " + RODUTIL.RodGrade(RSWIN_DESC.FGGradeRod) + " ")
							Batch.BatchMessage("  Sinker Bars: " + RODUTIL.RodGrade(RSWIN_DESC.SBGradeRod) + " ")
						ElseIf RSWIN_DESC.SETUP_bUseSteelRodsOnly Then
							Batch.BatchMessage("  Designing for steel rods only (steel rod service factor: " + Conversions.ToString(RSWIN_DESC.AIFilePreferences.ServiceFactorPreference) + ").")
							Batch.BatchMessage("  Preferred rod type stronger than API grade D: " + RODUTIL.RodGrade(RSWIN_DESC.HSGradeRod) + " ")
							Batch.BatchMessage("  Sinker Bars: " + RODUTIL.RodGrade(RSWIN_DESC.SBGradeRod) + " ")
						ElseIf RSWIN_DESC.SETUP_bUseFGlassWithSteelOnBottom Then
							Batch.BatchMessage("  Designing for fiberglass with steel on bottom (steel rod service factor: " + Conversions.ToString(RSWIN_DESC.AIFilePreferences.ServiceFactorPreference) + ").")
							Batch.BatchMessage("  Preferred rod type stronger than API grade D: " + RODUTIL.RodGrade(RSWIN_DESC.HSGradeRod) + " ")
							Batch.BatchMessage("  Preferred fiberglass rod: " + RODUTIL.RodGrade(RSWIN_DESC.FGGradeRod) + " ")
							Batch.BatchMessage("  Sinker Bars: " + RODUTIL.RodGrade(RSWIN_DESC.SBGradeRod) + " ")
						End If
						If RSWIN_DESC.bXRODUseCustomizedLists Then
							Batch.BatchMessage("  'Use customized pumping unit lists' selected.")
							If RSWIN_DESC.bXRODUseGeneralList Then
								Batch.BatchMessage("  'Use general list if needed' selected.")
							ElseIf RSWIN_DESC.bXRODUseClosestUnit Then
								Batch.BatchMessage("  'Use unit closest to recommended size' selected")
							Else
								Batch.BatchMessage("  Neither 'Use general list if needed' or 'Use unit closest to recommended size' selected.")
							End If
						End If
						If RSWIN_DESC.SETUP_bUseAvgRodTBGFricCoeff Then
							Batch.BatchMessage("  Using average calculated rod-tubing friction coefficients.")
						Else
							Dim str6 As String = "  Using "
							fTemplateTotalAIScore = RSWIN_DESC.SETUP_TimesAvgRodTBGFricCoeff
							Batch.BatchMessage(str6 + fTemplateTotalAIScore.ToString().Trim() + " times average calculated rod-tubing friction coefficients.")
						End If
						Me.sSpeedVar = ""
						If RSWIN_DESC.SETUP_IncludeMotorSPV Then
							Me.sSpeedVar = Me.sSpeedVariationIncluded
						Else
							Me.sSpeedVar = Me.sSpeedVariationNotIncluded
						End If
						Batch.BatchMessage("  Electricity Cost: " + Conversions.ToString(RSWIN_DESC.AIFilePreferences.ElectricityCostPreference))
						Batch.BatchMessage(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("  Power meter type: ", Interaction.IIf(RSWIN_DESC.SETUP_PowerMeterType = 1S, Me.sDetent, Me.sNonDetent)), ", "), Me.sSpeedVar)))
						If Not RSWIN_DESC.SETUP_UseXRODVTubingSizes Then
							Batch.BatchMessage(String.Concat(New String() { "  Casing Size: ", Conversions.ToString(RSWIN_DESC.MaxCasingSize), RSWIN_DESC.sDblQuote, ",  Tubing Size OD: ", Conversions.ToString(RSWIN_DESC.MaxTubingSizeOD), RSWIN_DESC.sDblQuote, " " }))
						End If
						Batch.BatchMessage("  Polished Rod Diameter: " + Conversions.ToString(RSWIN_DESC.rst.PR_Diameter))
						Batch.BatchMessage(" ")
						If RSWIN_DESC.SETUP_bUseFGlassWithSteelOnBottom And RSWIN_DESC.SETUP_bUseSteelRodsOnly Then
							Batch.BatchMessage("  Steel rods only designs:")
						End If
					End If
					RSWIN_DESC.Inputfile = text6
					RSWIN_DESC.rst.Inputfile = RSWIN_DESC.Inputfile
					If RSWIN_DESC.SETUP_bUseFGlassWithSteelOnBottom And RSWIN_DESC.SETUP_bUseSteelRodsOnly And CDbl(num2) = CDbl(RSWIN_DESC.mcBatchFiles) / 2.0 + 1.0 Then
						Batch.BatchMessage("  Fiberglass with steel on bottom designs:")
						flag7 = True
					End If
					Batch.BatchMessage(RSWIN_DESC.Inputfile + ":")
					If num2 > 1 Then
						' The following expression was wrapped in a checked-expression
						batchLog.UpdatePercent = CSng((CDbl((num2 - 1)) / CDbl(RSWIN_DESC.mcBatchFiles) * 100.0))
						batchLog.UpdateProgress()
					End If
					If Not RSWIN_DESC.rst.gbAutomatic Then
						Me.SetCaption(RSWIN_DESC.Inputfile)
					Else
						Me.SetCaption(RSWIN_DESC.Inputfile)
						Me.Clock.BatchShowInputFile(RSWIN_DESC.Inputfile)
					End If
					RSWIN_DESC.rst.SetClassDefaults(False)
					RSWIN.ReadFile(text6, flag21, False)
					RSWIN_DESC.bSuppressWarningMessages_Override = True
					If RSWIN_DESC.bXRODAdmin Then
						RSWIN_DESC.SETUP_bAdminDebug = False
					End If
					DESIGN.Design()
					fTemplateTotalAIScore = RSWIN_DESC.fTemplateTotalAIScore
					Dim bCheckToAdd As Boolean = False
					Dim flag14 As Boolean = False
					Dim sTemplateTotalAIScore As String = RSWIN.TotalExpertScore(num4, num5, num6, num7, num8, num9, fTemplateTotalAIScore, bCheckToAdd, flag11, flag14, False, False)
					RSWIN_DESC.fTemplateTotalAIScore = fTemplateTotalAIScore
					RSWIN_DESC.sTemplateTotalAIScore = sTemplateTotalAIScore
					RSWIN_DESC.bSuppressWarningMessages_Override = False
					If RSWIN_DESC.bXRODAdmin Then
						RSWIN_DESC.SETUP_bAdminDebug = setup_bAdminDebug
					End If

				If RSWIN_DESC.bRunGuru Then
					Me.MergeGURUInputs(num2 - 1, flag8)
					Try
						If Not flag8 Then
							Retail.UpdateFile()
						End If
					Catch ex3 As Exception
					End Try
				End If
				Dim sTag As String
				If Not flag21 Then
					Batch.BatchMessage("Unable to read file.")
				Else
					If RSWIN_DESC.bRunGuru Then
						Batch.BatchMessage(RSWIN_DESC.rst.PU.Manuf)
					End If
					If Not RSWIN_DESC.rst.gbBatch Then
						batchLog.UpdatePercent = CSng((CDbl((4 * (num2 - 1) + 1)) / CDbl((4 * RSWIN_DESC.mcBatchFiles))))
						batchLog.UpdateProgress()
					End If
					Application.DoEvents()
					If flag10 Then
						sTag = Conversions.ToString(batchLog.Tag)
					Else
						sTag = ""
					End If
					If Me.BatchCancelRequested(flag10, sTag) Then
						flag9 = True
						Exit While
					End If
					If(RSWIN_DESC.rst.gbOutputLoaded And Not RSWIN_DESC.rst.gbOutputOld And Not RSWIN_DESC.rst.gbAutomatic) AndAlso flag13 Then
						Batch.BatchMessage("** File already processed **")
					ElseIf flag8 Then
						Debug.WriteLine(" ")
					Else
						If RSWIN_DESC.rst.gbAutomatic AndAlso ((RSWIN_DESC.rst.gbOutputLoaded And Not RSWIN_DESC.rst.gbOutputOld) AndAlso flag13) Then
							Batch.BatchMessage("** File already processed **")
						End If
						If RSWIN_DESC.rst.gbAutomatic Then
							Dim text9 As String = text6
							If Strings.InStr(text9, ".RST", CompareMethod.Binary) <> 0 Then
								If Strings.InStr(text9, ".RST", CompareMethod.Binary) > 0 Then
									text9 = text9.Substring(0, Strings.Len(text9) - 3) + "CBL"
								End If
								If FILEUTIL.FileExists(text9) Then
									Dim flag22 As Boolean
									LOADCBL.LoadCBalanceFile(text9, flag22)
									If flag22 Then
										RSWIN_DESC.rst.CBDataFile = text9
										RSWIN_DESC.rst.UnknownM = False
									End If
								End If
							End If
						End If
						Application.DoEvents()
						Application.DoEvents()
						Application.DoEvents()
						If flag6 Then
							Batch.BatchMessage(">Matched on " + RSWIN_DESC.sAI_DBKeys(num2 - 1))
						End If
						RSWIN_DESC.iCurrentBatchFile = num2
						If RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru Then
							RSWIN_DESC.bSuppressWarningMessages = True
							If Not RSWIN_DESC.SETUP_bUseAvgRodTBGFricCoeff And RSWIN_DESC.SETUP_TimesAvgRodTBGFricCoeff >= 2F Then
								Dim pu As RSWIN_DESC.PUDataRec
								pu.Initialize()
								pu = RSWIN_DESC.rst.PU
								Dim unitID As String = RSWIN_DESC.rst.UnitID
								Dim text10 As String = Me.CheckFrictionAndPumpingUnit(pu, RSWIN_DESC.rst.UnitID, flag6)
								If Operators.CompareString(text10, "", False) <> 0 And Operators.CompareString(text10, unitID, False) <> 0 Then
									RSWIN_DESC.rst.UnitID = text10
									Me.ReRunWithNewUnitID(text10, True, False, False)
									If flag6 Then
										Batch.BatchMessage(String.Concat(New String() { ">New GB Load: ", RSWIN_DESC.rst.GearboxLoading(RSWIN_DESC.i2Score).ToString(), " , unit ", RSWIN_DESC.rst.UnitID, " , ", Conversions.ToString(RSWIN_DESC.rst.PU.GearboxRating), "-", Conversions.ToString(RSWIN_DESC.rst.PU.StructRating), "-", Conversions.ToString(RSWIN_DESC.rst.PU.MaxStroke), " , crankhole: ", RSWIN_DESC.rst.PU.CrankHole.ToString(), " , stroke: ", RSWIN_DESC.rst.PU.Strokes(CInt((RSWIN_DESC.rst.CrankHole - 1S))).ToString() }))
									End If
									Dim bCheckToAdd2 As Boolean = False
									Dim flag14 As Boolean = False
									Dim text11 As String = RSWIN.TotalExpertScore(num4, num5, num6, num7, num8, num9, num3, bCheckToAdd2, flag11, flag14, False, False)
								End If
							End If
						Else
							RSWIN_DESC.bSuppressWarningMessages = False
						End If
						Dim flag23 As Boolean
						Dim num13 As Integer = If(-If((flag23 > False), 1, 0), 1, 0)
						Me.MakeRun(num13, flag2)
						flag23 = (num13 <> 0)
						If flag2 Then
							RSWIN_DESC.rst.gbOutputLoaded = False
						End If
						Application.DoEvents()
						Application.DoEvents()
						Application.DoEvents()
						Application.DoEvents()
						Application.DoEvents()
						Application.DoEvents()
						Application.DoEvents()
						If RSWIN_DESC.bRodStarD And Not RSWIN_DESC.rst.gbAutomatic And RSWIN_DESC.bAbortRun Then
							Exit While
						End If
					End If
					batchLog.FilesComplete = num2.ToString()
					batchLog.UpdatePercent = CSng((CDbl((4 * (num2 - 1) + 2)) / CDbl((4 * RSWIN_DESC.mcBatchFiles)) * 100.0))
					batchLog.UpdateProgress()
					If RSWIN_DESC.rst.gbOutputLoaded Then
						num += 1
						Me.Message("Storing " + RSWIN_DESC.Inputfile + " to disk.")
						If RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru Then
							Dim rodStringType As Short = RSWIN_DESC.rst.RodStringType
							Dim flag24 As Boolean = RSWIN_DESC.rst.CalcFriction <> 0S
							RSWIN_DESC.rst.RodStringType = 2S
							RSWIN_DESC.rst.CalcFriction = 0S
							RSWIN_DESC.rst.SPMEntered = -1S
							RSWIN_DESC.rst.Iart = RSWIN_DESC.rst.PU.ArtInertia
							Retail.UpdateFile()
							RSWIN_DESC.rst.RodStringType = rodStringType
							RSWIN_DESC.rst.CalcFriction = If(-If((flag24 > False), 1S, 0S), 1S, 0S)
						Else
							Retail.UpdateFile()
							If RSWIN_DESC.SETUP_CreatePDFs <> 0 Then
								If Strings.InStr(RSWIN_DESC.rst.Inputfile.ToLower(), ".rsvx", CompareMethod.Binary) > 0 Then
									text2 = RSWIN_DESC.rst.Inputfile.Replace(".rsvx", ".pdf")
								ElseIf Strings.InStr(RSWIN_DESC.rst.Inputfile.ToLower(), ".rsdx", CompareMethod.Binary) > 0 Then
									text2 = RSWIN_DESC.rst.Inputfile.Replace(".rsdx", ".pdf")
								End If
								Me.MakePDF(text2)
								If Not RSWIN_DESC.rst.gbAutomatic Then
									Me.ResetClock()
								End If
							End If
						End If
						If flag15 Then
							If RSWIN_DESC.rst.gbAutomatic And Not flag Then
								If Not flag Then
									If RSWIN_DESC.SETUP_ExcelInstalled Then
										flag = Conversions.ToBoolean(NewLateBinding.LateGet(RSWIN_DESC.objExcel, Nothing, "XLWorkSheetCreate", New Object(-1) {}, Nothing, Nothing, Nothing))
									Else
										Dim objExcel2 As Object = RSWIN_DESC.objExcel
										Dim type2 As Type = Nothing
										Dim text12 As String = "XLWorkSheetCreate"
										Dim array9 As Object() = New Object() { text7 }
										Dim array10 As Object() = array9
										Dim array11 As String() = Nothing
										Dim array12 As Type() = Nothing
										Dim array5 As Boolean() = New Boolean() { True }
										Dim obj2 As Object = NewLateBinding.LateGet(objExcel2, type2, text12, array10, array11, array12, array5)
										If array5(0) Then
											text7 = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(0)), GetType(String)))
										End If
										flag = Conversions.ToBoolean(obj2)
									End If
								End If
								If text7.Length = 0 Then
									flag15 = False
								Else
									Application.DoEvents()
									Application.DoEvents()
									Application.DoEvents()
									Application.DoEvents()
									Application.DoEvents()
									Application.DoEvents()
									If Not flag2 Then
										Batch.BatchAddWorksheetData(True, flag7)
									End If
								End If
								flag = True
							End If
							Application.DoEvents()
							Application.DoEvents()
							Application.DoEvents()
							Application.DoEvents()
							Application.DoEvents()
							Application.DoEvents()
							If Not flag2 Then
								Batch.BatchAddWorksheetData(False, flag7)
							End If
						End If
						batchLog.UpdatePercent = CSng((CDbl((4 * (num2 - 1) + 3)) / CDbl((4 * RSWIN_DESC.mcBatchFiles))))
						batchLog.UpdateProgress()
						Application.DoEvents()
						If flag10 Then
							sTag = Conversions.ToString(batchLog.Tag)
						Else
							sTag = ""
						End If
						If Me.BatchCancelRequested(flag10, sTag) Then
							flag9 = True
							Exit While
						End If
						If flag12 Then
							Dim formName5 As String = "Results"
							Dim form As Form = results
							Dim flag25 As Boolean = Me.ReturnMdiForm(formName5, form)
							results = CType(form, Results)
							Dim flag26 As Boolean = flag25
							If flag26 Then
								results.LoadGraphs()
								results.PrintResults()
							Else
								RSWIN_DESC.bBackFromSetLines = False
								Me.AddResults(False)
								Dim formName6 As String = "Results"
								form = results
								Dim flag27 As Boolean = Me.ReturnMdiForm(formName6, form)
								results = CType(form, Results)
								flag26 = flag27
								If flag26 Then
									results.LoadGraphs()
									results.PrintResults()
								End If
							End If
							batchLog.UpdatePercent = CSng((CDbl((4 * (num2 - 1) + 4)) / CDbl((4 * RSWIN_DESC.mcBatchFiles))))
							batchLog.UpdateProgress()
						End If
					ElseIf Not RSWIN_DESC.SETUP_bGuru AndAlso flag2 Then
						Retail.UpdateFile()
					End If
				End If
				If RSWIN_DESC.SETUP_bGuru And RSWIN_DESC.bRunGuru Then
					If RSWIN_DESC.iErrorOccurred = 159 Then
						Batch.BatchMessage("The required pumping unit size is larger than the largest unit available from this manufacturer.")
					ElseIf RSWIN_DESC.bXRODUseCustomizedLists Then
						If RSWIN_DESC.bUsingMatchedUnit Then
							Batch.BatchMessage("Selected pumping unit from custom pumping unit list matches XROD recommended size " + RSWIN_DESC.sRecommendedUnit + ".")
						ElseIf RSWIN_DESC.bUsingGeneralList Then
							Batch.BatchMessage("Selected pumping unit is from general list because XROD recommended size " + RSWIN_DESC.sRecommendedUnit + " does not exist in customized list.")
						ElseIf RSWIN_DESC.bUsingClosestUnit Then
							Batch.BatchMessage("Selected unit from custom pumping unit list does not match XROD recommended size " + RSWIN_DESC.sRecommendedUnit + ".")
						ElseIf flag8 Then
							RSWIN_DESC.sRecommendedUnit = String.Concat(New String() { "(", Conversions.ToString(RSWIN_DESC.rst.PU.GearboxRating), "-", Conversions.ToString(RSWIN_DESC.rst.PU.StructRating), "-", Conversions.ToString(RSWIN_DESC.rst.PU.MaxStroke), ")" })
							Batch.BatchMessage("Required unit " + RSWIN_DESC.sRecommendedUnit + " not found in customized pumping unit list")
						End If
					End If
				End If
				Batch.BatchMessage(" ")
				Application.DoEvents()
				If flag10 Then
					sTag = Conversions.ToString(batchLog.Tag)
				Else
					sTag = ""
				End If
				If Me.BatchCancelRequested(flag10, sTag) Then
					flag9 = True
					Exit While
				End If
				flag16 = Batch.BatchGetNextFileName(text6)
			End While
			If num2 = 0 Or num = 0 Then
				batchLog.FilesComplete = num2.ToString()
				batchLog.UpdatePercent = 100F
				batchLog.UpdateProgress()
			Else
				Dim sTag As String
				If flag10 Then
					sTag = Conversions.ToString(batchLog.Tag)
				Else
					sTag = ""
				End If
				If Not Me.BatchCancelRequested(flag10, sTag) Then
					batchLog.UpdatePercent = 100F
					batchLog.FilesComplete = num2.ToString()
					batchLog.UpdateProgress()
					batchLog.cmdCancelText = "&Close"
					Application.DoEvents()
					Application.DoEvents()
					Application.DoEvents()
				Else
					RSWIN_DESC.bAbortRun = True
				End If
				If RSWIN_DESC.SETUP_bGuru And RSWIN_DESC.bExpert Then
					If Not RSWIN_DESC.bAbortRun Then
						batchLog.btnSort.Visible = True
						batchLog.btnAcceptAllGuruRun.Visible = True
						batchLog.btnAcceptGuruRun.Visible = True
						batchLog.btnAcceptGuruRun.Enabled = False
						Me.mnuFileSaveAsPDF_.Enabled = False
					End If
					RSWIN_DESC.bRunGuru = False
				Else
					batchLog.btnSort.Visible = False
					batchLog.btnAcceptAllGuruRun.Visible = False
					batchLog.btnAcceptGuruRun.Visible = False
				End If
				If RSWIN_DESC.bRodStarD And Not RSWIN_DESC.rst.gbAutomatic And RSWIN_DESC.bAbortRun Then
					Me.StopRunAni()
					If RSWIN_DESC.bExpert Then
						Batch.BatchMessage(" ")
						Batch.BatchMessage("The XROD-V AI batch run aborted!")
					Else
						Batch.BatchMessage(" ")
						Batch.BatchMessage("Batch run aborted!")
					End If
				ElseIf(flag15 AndAlso flag) And Not flag9 Then
					batchLog.SetTopMost(False)
					If flag9 Then
						flag15 = False
					End If
					Try
						Dim objExcel3 As Object = RSWIN_DESC.objExcel
						Dim type3 As Type = Nothing
						Dim text13 As String = "XLWorkSheetClose"
						Dim array9 As Object() = New Object() { flag15, text7 }
						Dim array13 As Object() = array9
						Dim array14 As String() = Nothing
						Dim array15 As Type() = Nothing
						Dim array5 As Boolean() = New Boolean() { True, True }
						NewLateBinding.LateCall(objExcel3, type3, text13, array13, array14, array15, array5, True)
						If array5(0) Then
							flag15 = CBool(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(0)), GetType(Boolean)))
						End If
						If array5(1) Then
							text7 = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9(1)), GetType(String)))
						End If
					Catch ex4 As Exception
					End Try
					batchLog.SetTopMost(True)
				End If
			End If
			RSWIN_DESC.rst.gbOutputLoaded = False
			RSWIN_DESC.Inputfile = ""
			If Not RSWIN_DESC.rst.gbAutomatic Then
				Me.SetCaption(RSWIN_DESC.Inputfile)
			Else
				Me.SetCaption(RSWIN_DESC.Inputfile)
				Me.Clock.BatchShowInputFile(RSWIN_DESC.Inputfile)
			End If
			Me.Message(RSWIN_DESC.sNull)
			Me.ToolbarButtonSetState(0, True)
			Me.ToolbarButtonSetState(1, True)
			Me.ToolbarButtonSetState(5, True)
			Me.ToolbarButtonSetState(4, True)
			Me.ToolbarButtonSetState(0, True)
			Util.UnbusyCursor()
			Dim num14 As Integer = 0
			Dim array16 As String() = New String(0) {}
			If(RSWIN_DESC.SETUP_bGuru And RSWIN_DESC.bExpert) AndAlso (Not RSWIN_DESC.bBatchGuruPUManufFound(1) Or Not RSWIN_DESC.bBatchGuruPUManufFound(2) Or Not RSWIN_DESC.bBatchGuruPUManufFound(3) Or Not RSWIN_DESC.bBatchGuruPUManufFound(4) Or Not RSWIN_DESC.bBatchGuruPUManufFound(5) Or Not RSWIN_DESC.bBatchGuruPUManufFound(6) Or Not RSWIN_DESC.bBatchGuruPUManufFound(7) Or Not RSWIN_DESC.bBatchGuruPUManufFound(8)) Then
				Dim i As Integer = 1
				Do
					If(Not RSWIN_DESC.bBatchGuruPUManufFound(i) And RSWIN_DESC.get_bUsePUManuf(i)) AndAlso Me.IsAlreadyInList(i, True) Then
						num14 += 1
						array16 = CType(Utils.CopyArray(CType(array16, Array), New String(num14 + 1 - 1) {}), String())
						array16(num14) = "  Pumping Unit Manufacturer Preference #" + i.ToString().Trim() + ": " + RSWIN_DESC.get_PUManuf(i)
					End If
					i += 1
				Loop While i <= 8
				If num14 > 0 Then
					Batch.BatchMessage(" ")
					Batch.BatchMessage("The target production cannot be achieved for the following: ")
					Batch.BatchMessage(" ")
					Dim num15 As Integer = 1
					Dim num16 As Integer = num14
					i = num15
					While i <= num16
						Batch.BatchMessage(array16(i))
						i += 1
					End While
				End If
			End If
			batchLog.cmdCancelText = "&Close"
			text4 = "LastBatchRunComplete"
			text3 = Convert.ToString(DateAndTime.Now)
			Dim num17 As Integer = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text4, text3, RSWIN_DESC.sINIFile)
			batchLog.SetTopMost(False)
			If Strings.Len(RuntimeHelpers.GetObjectValue(batchLog.Tag)) = 0 Then
				Me.ToolbarButtonSetState(4, True)
				If RSWIN_DESC.bRodStarD And Not RSWIN_DESC.rst.gbAutomatic And RSWIN_DESC.bAbortRun Then
					Me.StopRunAni()
					Batch.BatchMessage(" ")
				ElseIf RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru Then
					If Not RSWIN_DESC.rst.gbAutomatic Then
						Me.StopRunAni()
					End If
					If Strings.InStr(RSWIN_DESC.sAIFilename.ToLower(), "untitled", CompareMethod.Binary) <= 0 Then
						Batch.BatchMessage("The XROD-V AI batch run is complete (" + Util.FileName(RSWIN_DESC.sAIFilename) + ").")
						Me.Message("The XROD-V AI batch run is complete (" + Util.FileName(RSWIN_DESC.sAIFilename) + ").")
					Else
						Batch.BatchMessage("The XROD-V AI batch run is complete.")
						Me.Message("The XROD-V AI batch run is complete")
					End If
					RSWIN_DESC.rst.Inputfile = RSWIN_DESC.sAIFilename
					Me.SetCaption(RSWIN_DESC.rst.Inputfile)
				Else
					If Not RSWIN_DESC.rst.gbAutomatic Then
						Me.StopRunAni()
					End If
					Batch.BatchMessage("The batch run is complete.")
					Me.Message("The batch run is complete.")
				End If
				RSWIN_DESC.rst.gbBatch = False
				flag5 = False
				RSWIN_DESC.bHaltBatchLoop = False
				While Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.OrObject(Strings.Len(RuntimeHelpers.GetObjectValue(batchLog.Tag)) = 0, Operators.NotObject(Operators.CompareObjectEqual(batchLog.Tag, "Close", False))), RSWIN_DESC.bRunStarRunning), Not flag5), Not RSWIN_DESC.bHaltBatchLoop))
					Application.DoEvents()
					If Operators.ConditionalCompareObjectEqual(batchLog.Tag, "DisplayReport", False) Then
						Try
							batchLog.Tag = ""
							If batchLog.bDisplayBatchOutput And batchLog.sBatchFileName.Length > 0 Then
								Me.bDisplayBatchFileOutput = True
								Me.m_sBatchFileName = batchLog.sBatchFileName
								batchLog.SetTopMost(False)
								Me.RemoveChildForm("Results", True)
								Me.DisplayBatchFileOutput(flag3)
								Me.bDisplayBatchFileOutput = False
								If flag3 Then
									Dim formName7 As String = "Results"
									Dim form As Form = results
									Dim flag28 As Boolean = Me.ReturnMdiForm(formName7, form)
									results = CType(form, Results)
									Dim flag26 As Boolean = flag28
									If flag26 Then
										While Strings.Len(RuntimeHelpers.GetObjectValue(results.Tag)) = 0 And Not flag5
											Application.DoEvents()
											Try
												If(RSWIN_DESC.bExpert And Not RSWIN_DESC.SETUP_bGuru) AndAlso flag4 Then
													flag5 = True
												End If
											Catch ex5 As Exception
											End Try
										End While
									End If
								Else
									Dim formName8 As String = "WellInfo"
									Dim form As Form = wellInfo
									Dim flag29 As Boolean = Me.ReturnMdiForm(formName8, form)
									wellInfo = CType(form, WellInfo)
									Dim flag26 As Boolean = flag29
									If flag26 Then
										Me.RemoveChildForm("WellInfo", False)
									End If
								End If
								If Not flag5 Then
									Try
										If batchLog IsNot Nothing Then
											batchLog.Show()
										End If
									Catch ex6 As Exception
									End Try
								End If
							End If
						Catch ex7 As Exception
						End Try
					End If
				End While
				If(RSWIN_DESC.bHaltBatchLoop OrElse flag5) AndAlso (RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru) Then
					If Me.btnGuru.Visible Then
						Me.btnGuru.BringToFront()
					End If
					Me.lblGURU.BackColor = Color.LightGray
					If Me.btnGuru.Visible Then
						Me.StopAIAni()
						Me.btnGuru.BringToFront()
					End If
					If RSWIN_DESC.rst_save IsNot Nothing Then
						Me.ReloadAIRunInputs()
					End If
					Me.ToolbarButtonSetState2(2, False)
				End If
				Me.RemoveChildForm("BatchLog", False)
				If Not flag5 Then
					Me.RemoveChildForm("Results", False)
				End If
			Else
				If Not RSWIN_DESC.rst.gbAutomatic Then
					Me.StopRunAni()
				End If
				batchLog.prgPercentComplete.Value = 0
				batchLog.UpdateProgress()
				Batch.BatchMessage(" ")
				Batch.BatchMessage("___________________________________ ")
				If RSWIN_DESC.bExpert Then
					Batch.BatchMessage("XROD-V AI batch run was canceled.")
					Me.Message("XROD-V AI batch run was canceled.")
				Else
					Batch.BatchMessage("The batch run was canceled.")
					Me.Message("The batch run was canceled.")
					Me.RemoveChildForm("BatchLog", False)
				End If
				RSWIN_DESC.rst.gbBatch = False
			End If
			If RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru Then
				batchLog.btnAcceptGuruRun.Visible = True
				batchLog.btnAcceptGuruRun.Enabled = False
				Me.StopRunAni()
			End If
			Try
				Me.Clock.StopAutomaticBatch()
				Me.Clock = Nothing
				Me.RemoveChildForm("Clock", False)
			Catch ex8 As Exception
			End Try
			RSWIN.CheckLoadedForms()
			Me.StopRunAni()
		End Sub

		Public Sub mnuToolsExportDYN_Click(sender As Object, e As EventArgs)
			Me.StoreDynaFile()
		End Sub

		Public Sub StoreDynaFile()
			If RSWIN_DESC.gbDemoMode Then
				MessageBox.Show("Exporting the file is not allowed in DEMO MODE.", "DEMO MODE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
				Return
			End If
			Try
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				If rst.gbOutputLoaded Then
					Dim text3 As String
					If Strings.Len(Strings.Trim(RSWIN_DESC.rst.Inputfile)) = 0 Or Operators.CompareString(RSWIN_DESC.rst.Inputfile, "(Untitled)", False) = 0 Then
						Dim text As String
						FILEIO.MakeFileName(text, ".DYN")
						Dim cRODSTAR As cRODSTAR = rst
						Dim text2 As String = cRODSTAR.DYNDir
						FILEIO.SelectOutputFile(text3, text2, "Theta dyna. files (*.DYN)|*.DYN", text, ".DYN", "Save Dynamometer Card As")
						cRODSTAR.DYNDir = text2
					Else
						Dim cRODSTAR As cRODSTAR = RSWIN_DESC.rst
						Dim text2 As String = cRODSTAR.Inputfile
						Dim sNull As String = RSWIN_DESC.sNull
						Dim text4 As String = RSWIN_DESC.sNull
						Dim text5 As String
						Dim text6 As String
						FILEIO.SplitPath(text2, sNull, text4, text5, text6)
						RSWIN_DESC.sNull = text4
						RSWIN_DESC.sNull = sNull
						cRODSTAR.Inputfile = text2
						RSWIN_DESC.sNull = ""
						cRODSTAR = RSWIN_DESC.rst
						text4 = cRODSTAR.Inputfile
						Dim fileDirectory As String = FILEIO.GetFileDirectory(text4)
						cRODSTAR.Inputfile = text4
						Dim text As String = fileDirectory
						text3 = text + text5 + ".DYN"
						FILEIO.SelectOutputFile(text3, text, "Theta dyna. files (*.DYN)|*.DYN", text5, ".DYN", "Save Dynamometer Card As")
					End If
					If Strings.Len(text3) > 0 Then
						Dim num As Short = FILEIO.OpenTheFile(text3, 545S, 0S)
						kinemat.Kinconst(rst.PU)
						Dim cRODSTAR As cRODSTAR = rst
						Dim pu As RSWIN_DESC.PUDataRec = cRODSTAR.PU
						kinemat.Unitstroke(pu)
						cRODSTAR.PU = pu
						FileSystem.PrintLine(CInt(num), New Object() { rst.Ntsteps })
						Dim num2 As Short = 0S
						Dim num3 As Short = rst.Ntsteps - 1S
						For num4 As Short = num2 To num3
							FileSystem.WriteLine(CInt(num), New Object() { rst.SurfPos(CInt(num4)), rst.SurfLoad(CInt(num4)) })
						Next
						If rst.MeasuredCBEffect = 0F Then
							FileSystem.WriteLine(CInt(num), New Object() { 0F })
						Else
							If rst.MeasuredCBEupstroke <> 0S Then
								FileSystem.WriteLine(CInt(num), New Object() { 1 })
							Else
								FileSystem.WriteLine(CInt(num), New Object() { -1 })
							End If
							FileSystem.WriteLine(CInt(num), New Object() { rst.MeasuredCBEffect })
							FileSystem.WriteLine(CInt(num), New Object() { rst.MeasuredCBEpos })
						End If
						If rst.MeasuredSPM <> 0F Then
							FileSystem.WriteLine(CInt(num), New Object() { rst.MeasuredSPM })
						Else
							FileSystem.WriteLine(CInt(num), New Object() { rst.SPM })
						End If
						FileSystem.WriteLine(CInt(num), New Object() { rst.MeasuredStroke })
						FileSystem.WriteLine(CInt(num), New Object() { 0 })
						FileSystem.WriteLine(CInt(num), New Object() { 0 })
						If Strings.Len(rst.DynoDate) = 0 Then
							FileSystem.WriteLine(CInt(num), New Object() { 0 })
						Else
							FileSystem.WriteLine(CInt(num), New Object() { 1 })
							FileSystem.PrintLine(CInt(num), New Object() { rst.DynoDate })
						End If
						FileSystem.FileClose(New Integer() { CInt(num) })
					End If
				End If
			Catch ex As Exception
			End Try
		End Sub

		Public Sub mnuToolsExportMCM_Click(sender As Object, e As EventArgs)
			Me.ExportMCM()
			Me.ResetClock()
		End Sub

		Public Sub ExportMCM()
			Dim dlgSelectCBM As dlgSelectCBM = New dlgSelectCBM()
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			Dim num As Single
			If Not(RSWIN_DESC.rst.PU.UnitType = 8S Or RSWIN_DESC.bBeamBalanced) Then
				If rst.get_M(1) = rst.get_M(0) Or CDbl(rst.GearboxLoading(0)) >= 0.99 Or RSWIN_DESC.bBalancedEVarsOverwritten Then
					num = rst.get_M(1)
				Else
					Me.ResetClock()
					dlgSelectCBM.ShowDialog()
					If Conversion.Val(RuntimeHelpers.GetObjectValue(dlgSelectCBM.Tag)) = 1.0 Then
						num = rst.get_M(1)
					ElseIf Conversion.Val(RuntimeHelpers.GetObjectValue(dlgSelectCBM.Tag)) = 0.0 Then
						num = rst.get_M(0)
					End If
				End If
				If num = 0F Then
					num = rst.get_M(2)
					dlgSelectCBM.Tag = 2
				End If
			Else
				If rst.get_RequiredUnbalance(1) = rst.get_RequiredUnbalance(0) Or CDbl(rst.GearboxLoading(0)) >= 0.99 Or RSWIN_DESC.bBalancedEVarsOverwritten Then
					num = rst.get_RequiredUnbalance(1)
				Else
					Me.ResetClock()
					dlgSelectCBM.ShowDialog()
					If Conversion.Val(RuntimeHelpers.GetObjectValue(dlgSelectCBM.Tag)) = 1.0 Then
						num = rst.get_RequiredUnbalance(1)
					ElseIf Conversion.Val(RuntimeHelpers.GetObjectValue(dlgSelectCBM.Tag)) = 0.0 Then
						num = rst.get_RequiredUnbalance(0)
					End If
				End If
				If num = 0F Then
					num = rst.Unbalance
					dlgSelectCBM.Tag = 2
				End If
			End If
			Util.CopyMCMToClipboard(num)
			If RSWIN_DESC.rst.PU.UnitType = 8S Or RSWIN_DESC.bBeamBalanced Then
				Dim sMsg As String = "The structural unbalance required to balance the pumping unit has been exported to XBAL. The next time you create a new file or read an existing file in XBAL, you can import the value using the Paste CB button on XBAL's toolbar."
				Dim sMsgType As String = ""
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
			Else
				Dim sMsg2 As String = "The balanced maximum CB moment has been exported to XBAL.  The next time you create a new file or read an existing file in XBAL, you can import the CB moment using the Paste CB button on XBAL's toolbar."
				Dim sMsgType2 As String = ""
				Dim bClosing2 As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg2, sMsgType2, bClosing2, dialogResult)
			End If
		End Sub

		Public Function CheckDataEntryInProgress() As Boolean
			Dim flag As Boolean = False
			Dim objectValue As Object = RuntimeHelpers.GetObjectValue(ini.GetDataValue("InProgress", 11, False, DBNull.Value))
			If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
				Dim text As String
				If Conversions.ToBoolean(objectValue) Then
					text = "The previous session ended while data was still being entered. Do you want to continue entering data?"
				Else
					text = "The previous session ended before the data in memory was saved to disk. Do you want to continue using the data?"
				End If
				Dim msg As String = text
				Dim bDefaultYes As Boolean = True
				Dim flag2 As Boolean = False
				If Util.YesNo(msg, bDefaultYes, flag2) Then
					flag = True
					Me.OpenINI(flag)
					Me.ToolbarButtonSetState(-2, True)
					Me.ToolbarButtonSetState(16, True)
				Else
					RSWIN.ReCreateRegKey(RSWIN_DESC.SECT_DATAENTRY)
				End If
			End If
			Return flag
		End Function

		Public Sub SetCaption(sFileName As String)
			Dim text As String
			If Strings.Len(sFileName) = 0 Then
				text = ""
			ElseIf Operators.CompareString(sFileName, "Untitled", False) = 0 Then
				text = sFileName
			Else
				text = Util.FileName(sFileName)
			End If
			If Strings.Len(text) > 0 Then
				text = " - " + text
			End If
			If Strings.InStr(text.ToLower(), ".xddx", CompareMethod.Binary) > 0 Then
				text = text.ToLower().Replace(".xddx", Conversions.ToString(Interaction.IIf(RSWIN_DESC.bRodStarD, ".rsdx", ".rsvx")))
			ElseIf Strings.InStr(text.ToLower(), ".xdg", CompareMethod.Binary) > 0 Then
				text = text.ToLower().Replace(".xdg", Conversions.ToString(Interaction.IIf(RSWIN_DESC.bRodStarD, ".rsdx", ".rsvx")))
			ElseIf Strings.InStr(text.ToLower(), ".rdg", CompareMethod.Binary) > 0 Then
				text = text.ToLower().Replace(".rdg", Conversions.ToString(Interaction.IIf(RSWIN_DESC.bRodStarD, ".rsdx", ".rsvx")))
			ElseIf Strings.InStr(text.ToLower(), ".rst", CompareMethod.Binary) > 0 Then
				text = text.ToLower().Replace(".rst", Conversions.ToString(Interaction.IIf(RSWIN_DESC.bRodStarD, ".rsdx", ".rsvx")))
			ElseIf Strings.InStr(text.ToLower(), ".rsvx", CompareMethod.Binary) > 0 And RSWIN_DESC.bRodStarD Then
				text = text.ToLower().Replace(".rsvx", ".rsdx")
			ElseIf Strings.InStr(text.ToLower(), ".rsdx", CompareMethod.Binary) > 0 And Not RSWIN_DESC.bRodStarD Then
				text = text.ToLower().Replace(".rsdx", ".rsvx")
			End If
			Me.Text = RSWIN_DESC.sProgramName + text
			If Me.WindowState = FormWindowState.Minimized Then
				Me.Hide()
				Me.Show()
			End If
		End Sub

		Public Sub CreateForms()
			Try
				RSWIN_DESC.bBackFromSetLines = False
				If Not RSWIN_DESC.rst.gbAutomatic And Not RSWIN_DESC.rst.gbBatch Then
					Me.RemoveAllChildForms(False)
				End If
				Me.AddResults(False)
				Me.AddWellInfo(False)
				Me.AddProdInfo(False)
				Me.AddPTInfo(False)
				Me.AddRSInput(False, False)
				Me.AddPUData(False)
				Me.AddMotorData(False)
				Me.m_VisualInput = False
				Me.AddVisInput(False, False)
			Catch ex As Exception
			End Try
		End Sub

		Private Sub RemoveForms()
			Try
				Dim flag2 As Boolean
				Dim flag As Boolean = Me.MdiFormExists("WellInfo", False, True, False, flag2)
				flag = Me.MdiFormExists("ProdInfo", False, True, False, flag2)
				flag = Me.MdiFormExists("PTInfo", False, True, False, flag2)
				flag = Me.MdiFormExists("RSInput", False, True, False, flag2)
				flag = Me.MdiFormExists("DeviationProfile", False, True, False, flag2)
				flag = Me.MdiFormExists("PUData", False, True, False, flag2)
				flag = Me.MdiFormExists("MotorData", False, True, False, flag2)
				flag = Me.MdiFormExists("Results", False, True, False, flag2)
			Catch ex As Exception
			End Try
		End Sub

		Public Sub CheckAndCreateForm(sFrmName As String)
			Dim flag2 As Boolean
			Dim flag As Boolean = Me.MdiFormExists(sFrmName, False, True, False, flag2)
			If Operators.CompareString(sFrmName, "WellInfo", False) = 0 Then
				Me.AddWellInfo(False)
			ElseIf Operators.CompareString(sFrmName, "ProdInfo", False) = 0 Then
				Me.AddProdInfo(False)
			ElseIf Operators.CompareString(sFrmName, "PTInfo", False) = 0 Then
				Me.AddPTInfo(False)
			ElseIf Operators.CompareString(sFrmName, "RSInput", False) = 0 Then
				Me.AddRSInput(False, False)
			Else
				If Operators.CompareString(sFrmName, "DeviationProfile", False) = 0 Then
					Try
						If RSWIN_DESC.bRodStarD Then
							Me.AddDeviationProfile(False)
						End If
						Return
					Catch ex As Exception
						Return
					End Try
				End If
				If Operators.CompareString(sFrmName, "PUData", False) = 0 Then
					Me.AddPUData(False)
				ElseIf Operators.CompareString(sFrmName, "MotorData", False) = 0 Then
					Me.AddMotorData(False)
				End If
			End If
		End Sub

		Public Sub CheckAndCreateForms()
			Dim flag2 As Boolean
			Dim flag As Boolean = Me.MdiFormExists("WellInfo", False, True, False, flag2)
			Me.AddWellInfo(False)
			flag = Me.MdiFormExists("ProdInfo", False, True, False, flag2)
			Me.AddProdInfo(False)
			flag = Me.MdiFormExists("PTInfo", False, True, False, flag2)
			Me.AddPTInfo(False)
			flag = Me.MdiFormExists("RSInput", False, True, False, flag2)
			Me.AddRSInput(False, False)
			flag = Me.MdiFormExists("DeviationProfile", False, True, False, flag2)
			If RSWIN_DESC.bRodStarD Then
				Me.AddDeviationProfile(False)
			End If
			flag = Me.MdiFormExists("PUData", False, True, False, flag2)
			Me.AddPUData(False)
			flag = Me.MdiFormExists("MotorData", False, True, False, flag2)
			Me.AddMotorData(False)
		End Sub

		Public Sub DisplayChildFormAndControl(FrmName As String, sControlName As String, Optional sTabName As String = "")
			If Operators.CompareString(FrmName, "DeviationProfile", False) = 0 Then
				Dim deviationProfile As DeviationProfile = New DeviationProfile()
				Me.CheckAndCreateForm(FrmName)
				Dim form As Form = deviationProfile
				Me.ReturnMdiForm(FrmName, form)
				deviationProfile = CType(form, DeviationProfile)
				deviationProfile.Activate()
				deviationProfile.bVisible_tabInput = False
				deviationProfile.Show()
				deviationProfile.DisplayInputTab(sControlName, sTabName)
				deviationProfile.bVisible_tabInput = True
			Else
				Me.CheckAndCreateForm(FrmName)
				Dim form2 As Form
				Dim flag As Boolean = Me.ReturnMdiForm(FrmName, form2)
				If flag Then
					form2.Activate()
					form2.Show()
					Try
						For Each obj As Object In form2.Controls
							Dim control As Control = CType(obj, Control)
							Dim index As Integer = form2.Controls.IndexOf(control)
							Dim flag2 As Boolean
							If Operators.CompareString(control.Name.ToLower(), sControlName.ToLower(), False) = 0 Then
								form2.Controls(index).Focus()
								flag2 = True
								Exit For
							End If
							Try
								For Each obj2 As Object In control.Controls
									Dim control2 As Control = CType(obj2, Control)
									Dim index2 As Integer = control.Controls.IndexOf(control2)
									If Operators.CompareString(control2.Name.ToLower(), sControlName.ToLower(), False) = 0 Then
										form2.Controls(index).Controls(index2).Focus()
										flag2 = True
										Exit For
									End If
									Try
										For Each obj3 As Object In control2.Controls
											Dim control3 As Control = CType(obj3, Control)
											Dim index3 As Integer = control2.Controls.IndexOf(control3)
											If Operators.CompareString(control3.Name.ToLower(), sControlName.ToLower(), False) = 0 Then
												form2.Controls(index).Controls(index2).Controls(index3).Focus()
												flag2 = True
												Exit For
											End If
											Try
												For Each obj4 As Object In control3.Controls
													Dim control4 As Control = CType(obj4, Control)
													Dim index4 As Integer = control3.Controls.IndexOf(control4)
													If Operators.CompareString(control4.Name.ToLower(), sControlName.ToLower(), False) = 0 Then
														form2.Controls(index).Controls(index2).Controls(index3).Controls(index4).Focus()
														flag2 = True
														Exit For
													End If
													Try
														For Each obj5 As Object In control4.Controls
															Dim control5 As Control = CType(obj5, Control)
															Dim index5 As Integer = control4.Controls.IndexOf(control5)
															If Operators.CompareString(control5.Name.ToLower(), sControlName.ToLower(), False) = 0 Then
																form2.Controls(index).Controls(index2).Controls(index3).Controls(index4).Controls(index5).Focus()
																flag2 = True
																Exit For
															End If
														Next
													Finally
														Dim enumerator5 As IEnumerator
														If TypeOf enumerator5 Is IDisposable Then
															TryCast(enumerator5, IDisposable).Dispose()
														End If
													End Try
													If flag2 Then
														Exit For
													End If
												Next
											Finally
												Dim enumerator4 As IEnumerator
												If TypeOf enumerator4 Is IDisposable Then
													TryCast(enumerator4, IDisposable).Dispose()
												End If
											End Try
											If flag2 Then
												Exit For
											End If
										Next
									Finally
										Dim enumerator3 As IEnumerator
										If TypeOf enumerator3 Is IDisposable Then
											TryCast(enumerator3, IDisposable).Dispose()
										End If
									End Try
									If flag2 Then
										Exit For
									End If
								Next
							Finally
								Dim enumerator2 As IEnumerator
								If TypeOf enumerator2 Is IDisposable Then
									TryCast(enumerator2, IDisposable).Dispose()
								End If
							End Try
							If flag2 Then
								Exit For
							End If
						Next
					Finally
						Dim enumerator As IEnumerator
						If TypeOf enumerator Is IDisposable Then
							TryCast(enumerator, IDisposable).Dispose()
						End If
					End Try
					Dim name As String = form2.Name
					RSWIN_DESC.sLastMDIFormName = name
				End If
			End If
		End Sub

		Public Sub mnuHelpContents_Popup(eventSender As Object, eventArgs As EventArgs)
			Me.mnuHelpContents_Click(RuntimeHelpers.GetObjectValue(eventSender), eventArgs)
		End Sub

		Public Sub mnuHelpContents_Click(eventSender As Object, eventArgs As EventArgs)
			Help.ShowHelp(Me, Me.HelpProvider1.HelpNamespace, HelpNavigator.TableOfContents, "topOverviewrst.htm")
			Me.ResetClock()
		End Sub

		Public Sub mnuHelpIndex_Popup(eventSender As Object, eventArgs As EventArgs)
			Me.mnuHelpIndex_Click(RuntimeHelpers.GetObjectValue(eventSender), eventArgs)
		End Sub

		Public Sub mnuHelpIndex_Click(eventSender As Object, eventArgs As EventArgs)
			Help.ShowHelp(Me, Me.HelpProvider1.HelpNamespace, HelpNavigator.Index)
			Me.ResetClock()
		End Sub

		Public Sub mnuHelpSearch_Popup(eventSender As Object, eventArgs As EventArgs)
			Me.mnuHelpSearch__Click(RuntimeHelpers.GetObjectValue(eventSender), eventArgs)
		End Sub

		Public Sub mnuHelpSearch__Click(eventSender As Object, eventArgs As EventArgs)
			Help.ShowHelp(Me, Me.HelpProvider1.HelpNamespace, HelpNavigator.Find, "")
			Me.ResetClock()
		End Sub

		Public Property BatchFileName As String
			Get
				Return Me.m_sBatchFileName
			End Get
			Set(value As String)
				Me.m_sBatchFileName = value
			End Set
		End Property

		Public Sub DisplayBatchFileOutput(ByRef bDisplayed As Boolean)
			bDisplayed = False
			Try
				Me.RemoveChildForm("Results", False)
			Catch ex As Exception
			End Try
			Try
				RSWIN_DESC.rst.gbBatch = False
				Dim iFile As Short = -2S
				Dim openFileDialog As OpenFileDialog = Nothing
				Dim batchFileName As String = Me.BatchFileName
				Me.OpenFile(iFile, openFileDialog, batchFileName, bDisplayed)
				Me.BatchFileName = batchFileName
			Catch ex2 As Exception
			End Try
		End Sub

		Public Sub MakeRun(ByRef bRunSucceeded As Integer, Optional ByRef bLengthError As Boolean = False)
			Dim num As Integer = 0
			Dim num2 As Integer = 0
			Dim num3 As Integer = 0
			Dim num4 As Integer = 0
			Dim num5 As Integer = 0
			Dim num6 As Integer = 0
			Dim text As String = ""
			Dim flag As Boolean = False
			Dim flag2 As Boolean = False
			Dim flag3 As Boolean = RSWIN_DESC.bExpert And RSWIN_DESC.bRunGuru And RSWIN_DESC.bXRODAdmin And RSWIN_DESC.SETUP_bAdminDebug
			bLengthError = False
			Application.DoEvents()
			Application.DoEvents()
			Application.DoEvents()
			Application.DoEvents()
			Application.DoEvents()
			Application.DoEvents()
			Application.DoEvents()
			Application.DoEvents()
			Try
				Verify.bMotorVerified = False
				If Conversions.ToBoolean(Operators.AndObject(If((-If((RSWIN_DESC.bRodStarD > False), 1S, 0S)), 1S, 0S) And RSWIN_DESC.rst.CalcMotorSize And (If((-If((RSWIN_DESC.rst.MotorSPV > 0F > False), 1S, 0S)), 1S, 0S) Or RSWIN_DESC.rst.CalcMotorSPV), Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(Motor.GetMotorInfo(4), 1, False), Operators.CompareObjectEqual(Motor.GetMotorInfo(4), 7, False)), Operators.CompareObjectGreaterEqual(Motor.GetMotorInfo(4), 8, False)))) Then
					Try
						Dim text2 As String = "150 hp"
						Motor.SelectMotorSizeByName(text2)
						Motor.SelectMotorSettingByName(text2)
					Catch ex As Exception
					End Try
				End If
				If RSWIN_DESC.rst.PU.UnitType = 8S Or RSWIN_DESC.bBeamBalanced Then
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
				RSWIN_DESC.i2Score = 1
				If RSWIN_DESC.bExpert And Not RSWIN_DESC.SETUP_bGuru And Not RSWIN_DESC.rst.UnknownM Then
					RSWIN_DESC.i2Score = 2
				End If
				RSWIN_DESC.bAbortRun = False
				RSWIN_DESC.iErrorOccurred = 0
				RSWIN_DESC.bChangeSPM = False
				If RSWIN_DESC.bIntVersion AndAlso RSWIN_DESC.bChangeCultures Then
					RSWIN_DESC.myCulture = New CultureInfo(RSWIN_DESC.sEnglish)
					Thread.CurrentThread.CurrentUICulture = RSWIN_DESC.myCulture
				End If
				Dim cRODSTAR As cRODSTAR = RSWIN_DESC.rst
				Dim flag4 As Boolean = True
				If Not RSWIN_DESC.bRodStarD Then
					RSWIN_DESC.SETUP_UseImpred = 0S
				Else
					RSWIN_DESC.SETUP_UseImpred = -1S
				End If
				If cRODSTAR.gbBatch Then
					Me.Message(Util.FormatMessage(Me.sCalcForFileInProgress.Replace("File1", RSWIN_DESC.Inputfile) + RSWIN_DESC.sPleaseWait, New Object(-1) {}))
				Else
					Me.Message(Me.sCalcInProgress + RSWIN_DESC.sPleaseWait)
				End If
				Application.DoEvents()
				If RSWIN_DESC.bExpert And (RSWIN_DESC.SETUP_bGuru Or RSWIN_DESC.bRunGuru) Then
					If RSWIN_DESC.rst.FluidLevel > RSWIN_DESC.rst.PumpDepth Then
						RSWIN_DESC.rst.FluidLevel = RSWIN_DESC.rst.PumpDepth
					End If
					If RSWIN_DESC.rst.TubingAnchorDepth > RSWIN_DESC.rst.PumpDepth Then
						RSWIN_DESC.rst.TubingAnchorDepth = RSWIN_DESC.rst.PumpDepth
					End If
				End If
				Dim num7 As Single = 0F
				Dim num8 As Single = 0F
				RSWIN_DESC.rst.bHasFGlass = False
				RSWIN_DESC.rst.bHasRR = False
				Dim num9 As Integer = 1
				Dim numRods As Integer = CInt(cRODSTAR.NumRods)
				For i As Integer = num9 To numRods
					If RODUTIL.IsRibbonRod(cRODSTAR.Sections(i).Grade) Then
						num8 += cRODSTAR.Sections(i).length
						RSWIN_DESC.rst.bHasRR = True
					ElseIf RODUTIL.IsFG(cRODSTAR.Sections(i).Grade) Then
						num7 += cRODSTAR.Sections(i).length
						RSWIN_DESC.rst.bHasFGlass = True
					End If
				Next
				If RSWIN_DESC.rst.RodStringType = 3S Then
					If RSWIN_DESC.rst.giRodDesignStyle = 0S Then
						RSWIN_DESC.rst.bHasFGlass = False
					Else
						RSWIN_DESC.rst.bHasFGlass = True
					End If
				ElseIf RSWIN_DESC.rst.RodStringType = 2S Then
					flag4 = Conversions.ToBoolean(Me.CheckRodLength(bLengthError))
				End If
				If RSWIN_DESC.bRodStarD Then
					RSWIN_DESC.SETUP_UseImpred = -1S
				Else
					RSWIN_DESC.SETUP_UseImpred = 0S
				End If
				If(If((-If((RSWIN_DESC.bBETA > False), 1S, 0S)), 1S, 0S) And RSWIN_DESC.SETUP_UseImpred And If((-If(((RSWIN_DESC.rst.PumpCondition <> 1S) > False), 1S, 0S)), 1S, 0S)) <> 0S AndAlso Conversions.ToBoolean(Operators.AndObject(Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(Motor.GetMotorInfo(4), 1, False), Operators.CompareObjectEqual(Motor.GetMotorInfo(4), 7, False)), Operators.CompareObjectGreaterEqual(Motor.GetMotorInfo(4), 8, False)), Operators.CompareObjectEqual(Motor.GetMotorInfo(4), 3, False)), If((-If((RSWIN_DESC.rst.MotorSPV > 0F > False), 1S, 0S)), 1S, 0S) Or RSWIN_DESC.rst.CalcMotorSPV)) Then
					Dim msg As String = "This version doesn't support speed variation unless pump condition is full. Continue with constant speed?"
					Dim bDefaultYes As Boolean = True
					Dim flag5 As Boolean = False
					If Not Util.YesNo(msg, bDefaultYes, flag5) Then
						flag4 = False
					End If
				End If
				If Not(RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru) AndAlso flag4 Then
					flag4 = DESIGN.CheckSanity()
					If flag4 Then
						flag4 = Verify.VerifyInputDataConsistency()
					End If
				End If
				If(flag4 And RSWIN_DESC.bRodStarD) AndAlso RSWIN_DESC.mdsDeviationProfile.Tables(0).Rows.Count >= 2 Then
					Dim last_MD_from_Survey As Single = Me.Get_Last_MD_from_Survey()
					If last_MD_from_Survey <= RSWIN_DESC.rst.PumpDepth Then
						If Not RSWIN_DESC.rst.gbBatch Then
							MessageBox.Show(Me.sNeedMoreSurveyPoints)
						Else
							Batch.BatchMessage(Me.sNeedMoreSurveyPoints)
						End If
						flag4 = False
					End If
				End If
				If flag4 Then
					RSWIN_DESC.bRunningPred = True
					If RSWIN_DESC.bExpert Then
						If RSWIN_DESC.SETUP_bGuru Then
							RSWIN_DESC.bSuppressWarningMessages = True
							RSWIN_DESC.bDesignSinkerbar = True
						Else
							Try
								RSWIN_DESC.bDesignSinkerbar = RSWIN_DESC.rst.gbDesignSinkerbar
								If RSWIN_DESC.bDesignSinkerbar AndAlso RSWIN_DESC.rst.SinkerBar.length > 200F Then
									Dim sinkerBar As RSWIN_DESC.RodSection
									sinkerBar.Initialize()
									sinkerBar = RSWIN_DESC.rst.SinkerBar
									sinkerBar.length = 200F
									RSWIN_DESC.rst.SinkerBar = sinkerBar
								End If
							Catch ex2 As Exception
							End Try
						End If
					Else
						RSWIN_DESC.bDesignSinkerbar = False
					End If
					bRunSucceeded = If((-If((DESIGN.Design() > False), 1, 0)), 1, 0)
					If(If((-If((Not cRODSTAR.gbBatch > False), 1, 0)), 1, 0) And Not bRunSucceeded And If((-If((RSWIN_DESC.bChangeSPM > False), 1, 0)), 1, 0)) <> 0 Then
						Try
							Me.DisplayForm("ProdInfo", "txtSPMBFPD")
							GoTo IL_1522
						Catch ex3 As Exception
							GoTo IL_1522
						End Try
					End If
					If bRunSucceeded <> 0 Then
						cRODSTAR.gbOutputLoaded = True
						cRODSTAR.gbOutputOld = False
						If cRODSTAR.gbBatch Then
							If RSWIN_DESC.SETUP_bGuru And RSWIN_DESC.bRunGuru Then
								Dim num10 As Single
								Dim num11 As Single
								If RSWIN_DESC.bExpert And RSWIN_DESC.bCheckSmallestUnit And Strings.InStr(RSWIN_DESC.rst.UnitID, "CUSTOM", CompareMethod.Binary) <= 0 Then
									Dim rst As cRODSTAR = New cRODSTAR()
									rst = RSWIN_DESC.rst
									PUDATA1.FindSmallestUnitID()
									If Operators.CompareString(RSWIN_DESC.SmallestUnitID.Trim(), "", False) <> 0 Then
										Dim unitID As String = RSWIN_DESC.rst.UnitID
										RSWIN_DESC.rst.UnitID = RSWIN_DESC.SmallestUnitID
										Dim pu As RSWIN_DESC.PUDataRec
										pu.Initialize()
										pu = RSWIN_DESC.rst.PU
										Dim crankHole As Short = RSWIN_DESC.rst.PU.CrankHole
										Dim crankRotation As Short = RSWIN_DESC.rst.PU.CrankRotation
										Dim unbalance As Single = RSWIN_DESC.rst.PU.Unbalance
										PUDATA1.ReadPUData(RSWIN_DESC.rst.UnitID, pu, False, True)
										pu.CrankHole = crankHole
										pu.CrankRotation = crankRotation
										If Not(pu.UnitType = 7S Or pu.UnitType = 10S) Then
											pu.R = pu.CrankRadii(CInt((pu.CrankHole - 1S)))
										Else
											pu.R = pu.CrankRadii(0)
										End If
										kinemat.Kinconst(pu)
										kinemat.Unitstroke(pu)
										RSWIN_DESC.rst.PU = pu
										Dim flag6 As Boolean = PREDICT.Predict(True, "")
										If flag6 Then
											flag6 = DESIGN.SurfCalc(True)
											If RSWIN_DESC.bExpert AndAlso flag6 Then
												If CDbl(RSWIN_DESC.rst.GearboxLoading(RSWIN_DESC.i2Score)) < 0.7 Then
													RSWIN_DESC.bSmallestUnitGearbox = True
												Else
													RSWIN_DESC.bSmallestUnitGearbox = False
												End If
												If CDbl(RSWIN_DESC.rst.StructL) < 0.7 Then
													RSWIN_DESC.bSmallestUnitStructL = True
												Else
													RSWIN_DESC.bSmallestUnitStructL = False
												End If
											End If
										End If
										RSWIN_DESC.rst.UnitID = unitID
										pu.Initialize()
										PUDATA1.ReadPUData(RSWIN_DESC.rst.UnitID, pu, False, True)
										pu.CrankHole = crankHole
										pu.CrankRotation = crankRotation
										pu.Unbalance = unbalance
										If Not(pu.UnitType = 7S Or pu.UnitType = 10S) Then
											pu.R = pu.CrankRadii(CInt((pu.CrankHole - 1S)))
										Else
											pu.R = pu.CrankRadii(0)
										End If
										kinemat.Kinconst(pu)
										kinemat.Unitstroke(pu)
										RSWIN_DESC.rst.PU = pu
										flag6 = PREDICT.Predict(True, "")
										If flag6 Then
											flag6 = DESIGN.SurfCalc(True)
										End If
										RSWIN_DESC.rst = rst
									End If
								End If
								RSWIN_DESC.bAIScoreImproved = False
								Dim text3 As String = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num10, False, flag, flag2, False, False)
								num11 = num10
								If CDbl(num11) < 0.98 Then
									Dim num12 As Integer = 0
									While CDbl(num10) < 0.98 And num12 < 2
										RSWIN_DESC.bSuppressWarningMessages = True
										Me.TryToImproveScore(num, num2, num3, num4, num5, num6, num11)
										Dim text3 As String = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num10, False, flag, flag2, False, False)
										If RSWIN_DESC.rst.SPM < 9F And CDbl(RSWIN_DESC.rst.GearboxLoading(RSWIN_DESC.i2Score)) <= 0.9 Then
											Dim fOrigTotalScore As Single = num11
											Dim flag5 As Boolean = False
											Dim text4 As String = ""
											Dim text5 As String = ""
											Me.ExtraSmallerGearboxAndSLCheck(num, num2, num3, num4, num5, num6, fOrigTotalScore, flag5, text4, text5)
											text3 = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num10, False, flag, flag2, False, False)
										Else
											Me.ExtraSmallerGearboxCheck(num, num2, num3, num4, num5, num6, num10, CDbl(RSWIN_DESC.rst.GearboxLoading(RSWIN_DESC.i2Score)) < 0.85)
											text3 = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num10, False, flag, flag2, False, False)
										End If
										If RODUTIL.CheckForOverloadedRods() Or (CDbl(RSWIN_DESC.rst.StructL) > 0.95 And RSWIN_DESC.rst.SPM < 9F And CDbl(RSWIN_DESC.rst.SystemEff) > 0.42) Then
											Dim flag7 As Boolean = Me.TrySmallerPlungerSize(num, num2, num3, num4, num5, num6, num10)
											text3 = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num10, False, flag, flag2, False, False)
											If(If((-If((flag7 > False), 1S, 0S)), 1S, 0S) And Not RSWIN_DESC.rst.PU.RequiredRotation And If((-If((num10 < 1F > False), 1S, 0S)), 1S, 0S)) <> 0S Then
												Me.TryDifferentRotationDirection(num, num2, num3, num4, num5, num6, num10)
												text3 = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num10, False, flag, flag2, False, False)
											End If
										End If
										text3 = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num10, False, flag, flag2, False, False)
										If(RSWIN_DESC.SETUP_bUseFGlassWithSteelOnBottom AndAlso flag2) Or (num10 > RSWIN_DESC.fTemplateTotalAIScore And RSWIN_DESC.fTemplateTotalAIScore <> 0F And RSWIN_DESC.SETUP_TimesAvgRodTBGFricCoeff = 1F) Then
											RSWIN_DESC.bAIScoreImproved = Me.TryToImproveRodLoadingScoreOnly(num2, num11, False, num10)
											text3 = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num10, False, flag, flag2, False, False)
										End If
										If CDbl(num10) >= 0.98 And num4 < 100 Then
											Dim flag7 As Boolean = Me.TryLargerPlungerSize(num, num2, num3, num4, num5, num6, num10)
											text3 = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num10, False, flag, flag2, False, False)
											If(If((-If((flag7 > False), 1S, 0S)), 1S, 0S) And Not RSWIN_DESC.rst.PU.RequiredRotation And If((-If((num10 < 1F > False), 1S, 0S)), 1S, 0S)) <> 0S Then
												Me.TryDifferentRotationDirection(num, num2, num3, num4, num5, num6, num10)
												text3 = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num10, False, flag, flag2, False, False)
											End If
										End If
										RSWIN_DESC.bSuppressWarningMessages = False
										If(num10 > num11 And CDbl(num10) > 0.93) Or (num10 > RSWIN_DESC.fTemplateTotalAIScore And RSWIN_DESC.fTemplateTotalAIScore <> 0F And RSWIN_DESC.SETUP_TimesAvgRodTBGFricCoeff = 1F) Then
											RSWIN_DESC.bAIScoreImproved = True
										End If
										If RSWIN_DESC.bAIScoreImproved AndAlso CDbl((RSWIN_DESC.rst.BPDsurface / RSWIN_DESC.rst.TargetBFPD)) < 0.965 Then
											RSWIN_DESC.bAIScoreImproved = False
										End If
										num12 += 1
									End While
									Debug.WriteLine(" ")
								ElseIf(CDbl(num11) >= 0.98 And num2 < 100) Or (RSWIN_DESC.SETUP_bUseFGlassWithSteelOnBottom AndAlso flag2) Then
									If flag3 Then
										Batch.BatchMessage(String.Concat(New String() { "> Original total score: ", Conversions.ToString(num11), ", but checking if rods can be improved (rod load score = ", Conversions.ToString(num2), ") " }))
									End If
									RSWIN_DESC.bSuppressWarningMessages = True
									RSWIN_DESC.bAIScoreImproved = Me.TryToImproveRodLoadingScoreOnly(num2, num11, False, num10)
									If RSWIN_DESC.bAIScoreImproved AndAlso CDbl((RSWIN_DESC.rst.BPDsurface / RSWIN_DESC.rst.TargetBFPD)) < 0.965 Then
										RSWIN_DESC.bAIScoreImproved = False
									End If
									Dim text3 As String = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num10, False, flag, flag2, False, False)
									Me.TryToImproveSysEffOnly(num, num2, num3, num4, num5, num6, num11)
									text3 = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num10, False, flag, flag2, False, False)
									If RSWIN_DESC.rst.SPM < 9F And CDbl(RSWIN_DESC.rst.GearboxLoading(RSWIN_DESC.i2Score)) <= 0.9 Then
										Dim fOrigTotalScore2 As Single = num11
										Dim flag5 As Boolean = False
										Dim text5 As String = ""
										Dim text4 As String = ""
										Me.ExtraSmallerGearboxAndSLCheck(num, num2, num3, num4, num5, num6, fOrigTotalScore2, flag5, text5, text4)
										text3 = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num10, False, flag, flag2, False, False)
									Else
										Me.ExtraSmallerGearboxCheck(num, num2, num3, num4, num5, num6, num11, CDbl(RSWIN_DESC.rst.GearboxLoading(RSWIN_DESC.i2Score)) < 0.85)
										text3 = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num10, False, flag, flag2, False, False)
									End If
									If CDbl(num11) >= 0.98 And num4 < 100 Then
										Dim flag7 As Boolean = Me.TryLargerPlungerSize(num, num2, num3, num4, num5, num6, num10)
										text3 = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num10, False, flag, flag2, False, False)
										If(If((-If((flag7 > False), 1S, 0S)), 1S, 0S) And Not RSWIN_DESC.rst.PU.RequiredRotation And If((-If((num10 < 1F > False), 1S, 0S)), 1S, 0S)) <> 0S Then
											Me.TryDifferentRotationDirection(num, num2, num3, num4, num5, num6, num10)
											text3 = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num10, False, flag, flag2, False, False)
										End If
									End If
									RSWIN_DESC.bSuppressWarningMessages = False
									Me.StopRunAni()
								Else
									If flag3 Then
										Batch.BatchMessage("> Original total score:  " + Conversions.ToString(num11))
									End If
									RSWIN_DESC.bSuppressWarningMessages = True
									Me.TryToImproveSysEffOnly(num, num2, num3, num4, num5, num6, num11)
									Dim text3 As String = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num10, False, flag, flag2, False, False)
									If RSWIN_DESC.rst.SPM < 9F And CDbl(RSWIN_DESC.rst.GearboxLoading(RSWIN_DESC.i2Score)) <= 0.9 Then
										Dim fOrigTotalScore3 As Single = num11
										Dim flag5 As Boolean = False
										Dim text5 As String = ""
										Dim text4 As String = ""
										Me.ExtraSmallerGearboxAndSLCheck(num, num2, num3, num4, num5, num6, fOrigTotalScore3, flag5, text5, text4)
										text3 = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num10, False, flag, flag2, False, False)
									Else
										Me.ExtraSmallerGearboxCheck(num, num2, num3, num4, num5, num6, num11, CDbl(RSWIN_DESC.rst.GearboxLoading(RSWIN_DESC.i2Score)) < 0.85)
										text3 = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num10, False, flag, flag2, False, False)
									End If
									If CDbl(num10) >= 0.98 And num4 < 100 Then
										Dim flag7 As Boolean = Me.TryLargerPlungerSize(num, num2, num3, num4, num5, num6, num10)
										text3 = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num10, False, flag, flag2, False, False)
										If(If((-If((flag7 > False), 1S, 0S)), 1S, 0S) And Not RSWIN_DESC.rst.PU.RequiredRotation And If((-If((num10 < 1F > False), 1S, 0S)), 1S, 0S)) <> 0S Then
											Me.TryDifferentRotationDirection(num, num2, num3, num4, num5, num6, num10)
											text3 = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num10, False, flag, flag2, False, False)
										End If
									End If
									RSWIN_DESC.bSuppressWarningMessages = False
								End If
								If CDbl(RSWIN_DESC.rst.GearboxLoading(RSWIN_DESC.i2Score)) > 1.1 Then
									Batch.BatchMessage("Required unit size does not exist for this pumping unit manufacturer.")
								End If
								Dim targetBFPD As Single
								If RSWIN_DESC.rst_save IsNot Nothing Then
									targetBFPD = RSWIN_DESC.rst_save.TargetBFPD
								Else
									targetBFPD = RSWIN_DESC.rst.TargetBFPD
								End If
								If CDbl((RSWIN_DESC.rst.BPDsurface / targetBFPD)) < 0.965 Then
									Util.LoadMessage(77, text)
									If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
										Dim text6 As String = text
										Dim oldValue As String = "."
										Dim array As String() = New String(4) {}
										array(0) = "  ("
										Dim array2 As String() = array
										Dim num13 As Integer = 1
										Dim text5 As String = "#.#"
										array2(num13) = Util.Format(targetBFPD, text5)
										array(2) = "  "
										array(3) = RSWIN_DESC.bpd.ToLower()
										array(4) = ")."
										text = text6.Replace(oldValue, String.Concat(array))
									Else
										Dim text7 As String = text
										Dim oldValue2 As String = "."
										Dim array As String() = New String(4) {}
										array(0) = "  ("
										Dim array3 As String() = array
										Dim num14 As Integer = 1
										Dim bpdsurface As Single = targetBFPD * RSWIN_DESC.BPD__M3D
										Dim text5 As String = "#.#"
										array3(num14) = Util.Format(bpdsurface, text5)
										array(2) = "  "
										array(3) = RSWIN_DESC.m3D.ToLower()
										array(4) = ")."
										text = text7.Replace(oldValue2, String.Concat(array))
									End If
									Batch.BatchMessage(text)
								End If
								If Operators.CompareString(text, "", False) = 0 Then
									Dim bAIScoreImproved As Boolean = RSWIN_DESC.bAIScoreImproved
									Dim flag5 As Boolean = False
									Dim text8 As String = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num10, bAIScoreImproved, flag, flag5, True, True)
									Batch.BatchMessage("** Run complete **    " + text8)
								ElseIf RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
									Dim bAIScoreImproved2 As Boolean = RSWIN_DESC.bAIScoreImproved
									Dim flag5 As Boolean = False
									Dim text8 As String = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num10, bAIScoreImproved2, flag, flag5, True, True)
									Dim array As String() = New String(6) {}
									array(0) = "** Run complete **    "
									array(1) = text8
									array(2) = "  ("
									Dim array4 As String() = array
									Dim num15 As Integer = 3
									Dim rst2 As cRODSTAR = RSWIN_DESC.rst
									Dim bpdsurface As Single = rst2.BPDsurface
									Dim text5 As String = "#.#"
									Dim text9 As String = Util.Format(bpdsurface, text5)
									rst2.BPDsurface = bpdsurface
									array4(num15) = text9
									array(4) = "  "
									array(5) = RSWIN_DESC.bpd.ToLower()
									array(6) = ") "
									Batch.BatchMessage(String.Concat(array))
								Else
									Dim bAIScoreImproved3 As Boolean = RSWIN_DESC.bAIScoreImproved
									Dim flag5 As Boolean = False
									Dim text8 As String = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num10, bAIScoreImproved3, flag, flag5, True, True)
									Dim array As String() = New String(6) {}
									array(0) = "** Run complete **    "
									array(1) = text8
									array(2) = "  ("
									Dim array5 As String() = array
									Dim num16 As Integer = 3
									Dim bpdsurface As Single = RSWIN_DESC.rst.BPDsurface * RSWIN_DESC.BPD__M3D
									Dim text5 As String = "#.#"
									array5(num16) = Util.Format(bpdsurface, text5)
									array(4) = "  "
									array(5) = RSWIN_DESC.m3D.ToLower()
									array(6) = ") "
									Batch.BatchMessage(String.Concat(array))
								End If
							Else
								If RSWIN_DESC.bRodStarD And RSWIN_DESC.rst.gbBatch Then
									Dim flag9 As Boolean
									Dim flag8 As Boolean = Me.VerifySideLoads(flag9)
									If flag8 AndAlso flag9 Then
										Try
											Me.RunImplementationFromBatch()
										Catch ex4 As Exception
										End Try
										Try
											Me.CleanupImplementationVars()
										Catch ex5 As Exception
										End Try
									End If
								End If
								If RSWIN_DESC.SETUP_ScoringPage <> 0S Then
									Dim bAIScoreImproved4 As Boolean = RSWIN_DESC.bAIScoreImproved
									Dim flag5 As Boolean = False
									Dim num10 As Single
									Dim text8 As String = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num10, bAIScoreImproved4, flag, flag5, True, True)
									Batch.BatchMessage("** Run complete **    " + text8)
								Else
									Batch.BatchMessage("** Run complete **")
								End If
							End If
						End If
						Try
							RSWIN.CheckLoadedForms()
						Catch ex6 As Exception
						End Try
						Me.Message(RSWIN_DESC.sNull)
					Else
						Me.Message("")
						If RSWIN_DESC.bRodStarD And RSWIN_DESC.bAbortRun And Not RSWIN_DESC.rst.gbAutomatic Then
							Me.Message("Run aborted!")
						End If
					End If
					IL_1522:
					RSWIN_DESC.bRunningPred = False
				End If
				cRODSTAR = Nothing
				If RSWIN_DESC.bIntVersion AndAlso RSWIN_DESC.bChangeCultures Then
					Dim setup_Language As String = RSWIN_DESC.SETUP_Language
					If Operators.CompareString(setup_Language, RSWIN_DESC.sEnglish, False) = 0 Then
						RSWIN_DESC.myCulture = New CultureInfo(RSWIN_DESC.sEnglish)
					ElseIf Operators.CompareString(setup_Language, RSWIN_DESC.sSpanish, False) = 0 Then
						RSWIN_DESC.myCulture = New CultureInfo(RSWIN_DESC.sSpanish)
					ElseIf Operators.CompareString(setup_Language, RSWIN_DESC.sChinese, False) = 0 Then
						RSWIN_DESC.myCulture = New CultureInfo(RSWIN_DESC.sChinese)
					Else
						RSWIN_DESC.myCulture = New CultureInfo(RSWIN_DESC.sEnglish)
					End If
					Thread.CurrentThread.CurrentUICulture = RSWIN_DESC.myCulture
				End If
			Catch ex7 As Exception
				MessageBox.Show("Error in MakeRun  " + ex7.Message)
			End Try
		End Sub

		Public Function SaveBeforeExit() As Integer
			Dim result As Integer
			If Strings.Len(RSWIN_DESC.rst.Inputfile) <> 0 Then
				Dim num As Integer = 0
				Dim num2 As Integer = 1
				While (RSWIN_DESC.NewData(num2) And If((-If(((num2 <> 5) > False), 1S, 0S)), 1S, 0S)) = 0S
					' The following expression was wrapped in a checked-statement
					num2 += 1
					If num2 > 7 Then
						IL_42:
						If num <> 0 Then
							Return -1
						End If
						If Not RSWIN_DESC.rst.gbInputDataChanged Then
							Return -1
						End If
						Select Case MessageBox.Show(Me.sDYWExit + VERSION1.ProgramTitle() + "?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
							Case DialogResult.Cancel
								Return 0
							Case DialogResult.Abort, DialogResult.Retry, DialogResult.Ignore
								Return result
							Case DialogResult.Yes
								Me.SAVEAFILE(False, True, False, False, False, False, RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru)
								Return -1
							Case DialogResult.No
								Return -1
							Case Else
								Return result
						End Select
					End If
				End While
				num = -1
				GoTo IL_42
			End If
			result = -1
			Return result
		End Function

		Public Function CheckMdiForm(FormName As String) As Boolean
			Dim result As Boolean = False
			For Each form As Form In Me.MdiChildren
				If Operators.CompareString(FormName, form.Name, False) = 0 Then
					result = True
				End If
			Next
			Return result
		End Function

		Public Sub LoadAllFormsNow()
			Dim array As Form() = New Form(40) {}
			array(0) = New MotorData()
			array(1) = New dlgWK1Setup()
			array(2) = New WellInfo()
			array(3) = New VisInput()
			array(4) = New dlgVerifySPM()
			array(5) = New dlgVerifyMotorHP()
			array(5) = New Version()
			array(6) = New SetupEquip()
			array(7) = New dlgSelectDir()
			array(8) = New dlgSelectCBM()
			array(9) = New RswinSetup()
			array(10) = New RSInput()
			array(11) = New Results()
			array(12) = New dlgPUManuf()
			array(13) = New dlgPUList()
			array(14) = New PUData()
			array(15) = New PTInfo()
			array(16) = New dlgPrintSetup()
			array(17) = New dlgPrint()
			array(18) = New ProdInfo()
			array(19) = New MotorData()
			array(20) = New IPRPlot()
			array(21) = New frmHowToStart()
			array(22) = New frmWizard()
			array(23) = New frmSendEmail()
			array(24) = New frmImportDialog()
			array(25) = New frmDevSettings()
			array(26) = New dlgDuplicateCustomRodGrade()
			array(27) = New dlgSelectInput()
			array(28) = New dlgDeviationEntries()
			array(29) = New dlgCustomRG()
			array(30) = New dlgCustomPU()
			array(31) = New DeviationProfile()
			array(32) = New Clock()
			array(33) = New dlgCBData()
			array(34) = New dlgBatchOpts()
			array(35) = New BatchLog()
			Dim num As Integer = 0
			Do
				Try
					array(num).Show()
					Dim num2 As Integer = 1
					Do
						Application.DoEvents()
						num2 += 1
					Loop While num2 <= 15
					array(num).Close()
				Catch ex As Exception
				End Try
				num += 1
			Loop While num <= 35
		End Sub

		Public Sub CloseAllFormsNow()
			Dim array As Form() = New Form(40) {}
			array(0) = New MotorData()
			array(1) = New dlgWK1Setup()
			array(2) = New WellInfo()
			array(3) = New VisInput()
			array(4) = New dlgVerifySPM()
			array(5) = New dlgVerifyMotorHP()
			array(5) = New Version()
			array(6) = New SetupEquip()
			array(7) = New dlgSelectDir()
			array(8) = New dlgSelectCBM()
			array(9) = New RswinSetup()
			array(10) = New RSInput()
			array(11) = New Results()
			array(12) = New dlgPUManuf()
			array(13) = New dlgPUList()
			array(14) = New PUData()
			array(15) = New PTInfo()
			array(16) = New dlgPrintSetup()
			array(17) = New dlgPrint()
			array(18) = New ProdInfo()
			array(19) = New MotorData()
			array(20) = New IPRPlot()
			array(21) = New frmHowToStart()
			array(22) = New frmWizard()
			array(23) = New frmSendEmail()
			array(24) = New frmImportDialog()
			array(25) = New frmDevSettings()
			array(26) = New dlgDuplicateCustomRodGrade()
			array(27) = New dlgSelectInput()
			array(28) = New dlgDeviationEntries()
			array(29) = New dlgCustomRG()
			array(30) = New dlgCustomPU()
			array(31) = New DeviationProfile()
			array(32) = New Clock()
			array(33) = New dlgCBData()
			array(34) = New dlgBatchOpts()
			array(35) = New BatchLog()
			Dim num As Integer = 0
			Do
				Try
					array(num).Close()
					Dim num2 As Integer = 1
					Do
						Application.DoEvents()
						num2 += 1
					Loop While num2 <= 10
				Catch ex As Exception
				End Try
				num += 1
			Loop While num <= 35
		End Sub

		Private Overridable Property panStatus As StatusBar
			Get
				Return Me._panStatus
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As StatusBar)
				Dim value2 As StatusBarPanelClickEventHandler = AddressOf Me.panStatus_PanelClick
				Dim value3 As EventHandler = AddressOf Me.panStatus_TextChanged
				If Me._panStatus IsNot Nothing Then
					RemoveHandler Me._panStatus.PanelClick, value2
					RemoveHandler Me._panStatus.TextChanged, value3
				End If
				Me._panStatus = value
				If Me._panStatus IsNot Nothing Then
					AddHandler Me._panStatus.PanelClick, value2
					AddHandler Me._panStatus.TextChanged, value3
				End If
			End Set
		End Property

		Friend Overridable Property ctxMenu4ToolBar As ContextMenu
			Get
				Return Me._ctxMenu4ToolBar
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ContextMenu)
				Me._ctxMenu4ToolBar = value
			End Set
		End Property

		Friend Overridable Property tbrBatch As ToolBarButton
			Get
				Return Me._tbrBatch
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolBarButton)
				Me._tbrBatch = value
			End Set
		End Property

		Friend Overridable Property tbrPrevious As ToolBarButton
			Get
				Return Me._tbrPrevious
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolBarButton)
				Me._tbrPrevious = value
			End Set
		End Property

		Friend Overridable Property tbrSep2 As ToolBarButton
			Get
				Return Me._tbrSep2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolBarButton)
				Me._tbrSep2 = value
			End Set
		End Property

		Friend Overridable Property tbrSep1 As ToolBarButton
			Get
				Return Me._tbrSep1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolBarButton)
				Me._tbrSep1 = value
			End Set
		End Property

		Friend Overridable Property tbrSep6 As ToolBarButton
			Get
				Return Me._tbrSep6
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolBarButton)
				Me._tbrSep6 = value
			End Set
		End Property

		Friend Overridable Property tbrSep5 As ToolBarButton
			Get
				Return Me._tbrSep5
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolBarButton)
				Me._tbrSep5 = value
			End Set
		End Property

		Friend Overridable Property HelpProvider1 As HelpProvider
			Get
				Return Me._HelpProvider1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As HelpProvider)
				Me._HelpProvider1 = value
			End Set
		End Property

		Private Sub RODSTAR_Activated(sender As Object, e As EventArgs)
			RSWIN_DESC.bRunStarRunning = True
			If RSWIN_DESC.mbStartAutoBatch And RSWIN_DESC.mbStartAutoBatchHide Then
				RSWIN_DESC.mbStartAutoBatchHide = False
				Me.Hide()
			ElseIf RSWIN_DESC.bRodStarD Then
				Me.Icon = RSWIN_DESC.RodstarD_Icon
			ElseIf RSWIN_DESC.bExpert Then
				Me.Icon = RSWIN_DESC.XRODV_Icon
			Else
				Me.Icon = RSWIN_DESC.RodstarV_Icon
			End If
			If Operators.CompareString(RSWIN_DESC.sRodstarVorD, "RODSTARD", False) = 0 Then
				Me.lblMode.Visible = True
				Me.btnVertical.Visible = True
				Return
			End If
			Me.lblMode.Visible = False
			Me.btnVertical.Visible = False
		End Sub

		Private Sub CheckFileName()
			Dim text As String = ""
			Dim text2 As String = ""
			Try
				Dim flag As Boolean = False
				If RSWIN_DESC.bRodStarD Then
					If RSWIN_DESC.mdsDeviationProfile Is Nothing Then
						flag = True
					ElseIf RSWIN_DESC.mdsDeviationProfile.Tables(0).Rows.Count = 0 Then
						flag = True
					ElseIf RSWIN_DESC.mdsDeviationProfile.Tables(0).Rows.Count < 3 Then
						flag = True
					End If
				End If
				If flag Or Not RSWIN_DESC.bRodStarD Then
					text2 = ".rsvx"
				ElseIf Not flag And RSWIN_DESC.bRodStarD Then
					text2 = ".rsdx"
				End If
				If Strings.InStr(RSWIN_DESC.rst.Inputfile, ".rsvx", CompareMethod.Binary) > 0 Then
					text = ".rsvx"
				ElseIf Strings.InStr(RSWIN_DESC.rst.Inputfile, ".RSVX", CompareMethod.Binary) > 0 Then
					text = ".RSVX"
				ElseIf Strings.InStr(RSWIN_DESC.rst.Inputfile, ".rsdx", CompareMethod.Binary) > 0 Then
					text = ".rsdx"
				ElseIf Strings.InStr(RSWIN_DESC.rst.Inputfile, ".RSDX", CompareMethod.Binary) > 0 Then
					text = ".RSDX"
				ElseIf Strings.InStr(RSWIN_DESC.rst.Inputfile, ".RST", CompareMethod.Binary) > 0 Then
					text = ".RST"
				ElseIf Strings.InStr(RSWIN_DESC.rst.Inputfile, ".rst", CompareMethod.Binary) > 0 Then
					text = ".rst"
				ElseIf Strings.InStr(RSWIN_DESC.rst.Inputfile, ".xdg", CompareMethod.Binary) > 0 Then
					text = ".xdg"
				ElseIf Strings.InStr(RSWIN_DESC.rst.Inputfile, ".XDG", CompareMethod.Binary) > 0 Then
					text = ".XDG"
				ElseIf Strings.InStr(RSWIN_DESC.rst.Inputfile, ".rdg", CompareMethod.Binary) > 0 Then
					text = ".rdg"
				ElseIf Strings.InStr(RSWIN_DESC.rst.Inputfile, ".RDG", CompareMethod.Binary) > 0 Then
					text = ".RDG"
				End If
				If Operators.CompareString(text, "", False) <> 0 And Operators.CompareString(text2, "", False) <> 0 And Operators.CompareString(text.ToLower(), text2.ToLower(), False) <> 0 Then
					RSWIN_DESC.rst.Inputfile = RSWIN_DESC.rst.Inputfile.Replace(text, text2)
					Me.Text = Me.Text.Replace(text, text2)
				End If
			Catch ex As Exception
				MessageBox.Show("Error in CheckFileName: " + ex.Message)
			End Try
		End Sub

		Private Sub DisableMe()
			Try
				Me.Enabled = False
				Me.tbrToolbar.Visible = False
				Me.tbrToolBar2.Visible = False
				Me.tbrToolBar3.Visible = False
				Me.tbrGuru.Visible = False
				Me.btnVertical.Visible = False
				Me.btnVisualInput.Visible = False
				Me.btnAlpha.Visible = False
			Catch ex As Exception
			End Try
		End Sub

		Private Sub EnableMe()
			Try
				Me.Enabled = True
				Me.tbrToolbar.Visible = True
				Me.tbrToolBar2.Visible = True
				Me.tbrToolBar3.Visible = True
				If RSWIN_DESC.bExpert Then
					Me.tbrGuru.Visible = True
				End If
				If RSWIN_DESC.bRodStarD Then
					Me.btnVertical.Visible = True
				End If
				Me.btnVisualInput.Visible = True
				Me.btnAlpha.Visible = True
				RSWIN_DESC.bHaltBatchLoop = True
			Catch ex As Exception
			End Try
		End Sub

		Public Sub UnloadAllFormsExceptVisInput()
			Try
				Application.DoEvents()
				For Each form As Form In Me.MdiChildren
					Try
						If form IsNot Nothing AndAlso Operators.CompareString(form.Name, "VisInput", False) <> 0 Then
							Try
								form.Hide()
							Catch ex As Exception
							End Try
							Try
								If Operators.CompareString(form.Name, "Results", False) <> 0 Then
									form.Dispose()
								End If
							Catch ex2 As Exception
							End Try
						End If
					Catch ex3 As Exception
					End Try
				Next
			Catch ex4 As Exception
			End Try
			Application.DoEvents()
			Application.DoEvents()
			Application.DoEvents()
		End Sub

		Public Sub AssignToMainMenu(sfrmName As String, sMenu As String, ByRef objControl As MainMenu)
			Dim str As String = sfrmName.Trim() + "-" + RSWIN_DESC.SETUP_Language.Trim() + "-"
			Try
				Dim num As Integer = 0
				Dim num2 As Integer = objControl.MenuItems.Count - 1
				For i As Integer = num To num2
					Dim text As String = str + sMenu.Trim() + "-" + i.ToString().Trim()
					text = text.ToLower()
					If RSWIN_DESC.bRunningChineseVersion Then
						text = text.Replace("-zh-hans-", "-")
						Dim [string] As String = cGlobal.Lang.GetString(text)
						If [string] IsNot Nothing Then
							If Operators.CompareString([string].Trim(), "", False) <> 0 Then
								objControl.MenuItems(i).Text = [string]
							End If
						End If
					ElseIf RSWIN_DESC.myALLKeyValueHT.ContainsKey(text) Then
						objControl.MenuItems(i).Text = Conversions.ToString(RSWIN_DESC.myALLKeyValueHT(text))
					End If
				Next
				Try
					For Each obj As Object In objControl.MenuItems
						Dim menuItem As MenuItem = CType(obj, MenuItem)
						Dim text2 As String = ""
						Dim flag As Boolean = True
						If flag = (menuItem Is Me.mnuFile) Then
							text2 = "mnuFile"
						ElseIf flag = (menuItem Is Me.mnuEdit) Then
							text2 = "mnuEdit"
						ElseIf flag = (menuItem Is Me.mnuRun) Then
							text2 = "mnuRun"
						ElseIf flag = (menuItem Is Me.mnuHelp) Then
							text2 = "mnuHelp"
						ElseIf flag = (menuItem Is Me.mnuTools) Then
							text2 = "mnuTools"
						End If
						Dim text As String = str + text2
						text = text.ToLower()
						If RSWIN_DESC.bRunningChineseVersion Then
							text = text.Replace("-zh-hans-", "-")
							Dim [string] As String = cGlobal.Lang.GetString(text)
							If [string] IsNot Nothing Then
								If Operators.CompareString([string].Trim(), "", False) <> 0 Then
									menuItem.Text = [string]
								End If
							End If
						ElseIf RSWIN_DESC.myALLKeyValueHT.ContainsKey(text) Then
							menuItem.Text = Conversions.ToString(RSWIN_DESC.myALLKeyValueHT(text))
						End If
						Try
							For Each obj2 As Object In menuItem.MenuItems
								Dim menuItem2 As MenuItem = CType(obj2, MenuItem)
								text2 = ""
								Dim flag2 As Boolean = True
								If flag2 = (menuItem2 Is Me.mnuFileNew) Then
									text2 = "mnuFileNew"
								ElseIf flag2 = (menuItem2 Is Me.mnuFileOpen_) Then
									text2 = "mnuFileOpen"
								ElseIf flag2 = (menuItem2 Is Me.mnuFileSave) Then
									text2 = "mnuFileSave"
								ElseIf flag2 = (menuItem2 Is Me.mnuFileSaveAs_) Then
									text2 = "mnuFileSaveAs"
								ElseIf flag2 = (menuItem2 Is Me.mnuFileRecentFiles) Then
									text2 = "mnuFileRecentFiles"
								ElseIf flag2 = (menuItem2 Is Me.mnuFileImport) Then
									text2 = "mnuFileImport"
								ElseIf flag2 = (menuItem2 Is Me.mnuFilePrint_) Then
									text2 = "mnuFilePrint"
								ElseIf flag2 = (menuItem2 Is Me.mnuFilePrintSetup_) Then
									text2 = "mnuFilePrintSetup"
								ElseIf flag2 = (menuItem2 Is Me.mnuFileExit) Then
									text2 = "mnuFileExit"
								ElseIf flag2 = (menuItem2 Is Me.mnuEditUndo) Then
									text2 = "mnuEditUndo"
								ElseIf flag2 = (menuItem2 Is Me.mnuEditCut) Then
									text2 = "mnuEditCut"
								ElseIf flag2 = (menuItem2 Is Me.mnuEditCopy) Then
									text2 = "mnuEditCopy"
								ElseIf flag2 = (menuItem2 Is Me.mnuEditPaste) Then
									text2 = "mnuEditPaste"
								ElseIf flag2 = (menuItem2 Is Me.mnuEditDelete) Then
									text2 = "mnuEditDelete"
								ElseIf flag2 = (menuItem2 Is Me.mnuHelpContents) Then
									text2 = "mnuHelpContents"
								ElseIf flag2 = (menuItem2 Is Me.mnuHelpSearch_) Then
									text2 = "mnuHelpSearch"
								ElseIf flag2 = (menuItem2 Is Me.mnuHelpIndex) Then
									text2 = "mnuHelpIndex"
								ElseIf flag2 = (menuItem2 Is Me.mnuHelpAbout_) Then
									text2 = "mnuHelpAbout"
								ElseIf flag2 = (menuItem2 Is Me.mnuToolsExportDYN) Then
									text2 = "mnuToolsExportDYN"
								ElseIf flag2 = (menuItem2 Is Me.mnuToolsExportMCM) Then
									text2 = "mnuToolsExportMCM"
								ElseIf flag2 = (menuItem2 Is Me.mnuToolsSetup_) Then
									text2 = "mnuToolsSetup_"
								ElseIf flag2 = (menuItem2 Is Me.mnuToolsUploadRSVXFile) Then
									text2 = "mnuToolsUploadRSVXFile"
								ElseIf flag2 = (menuItem2 Is Me.mnuToolsUploadRSVXFiles) Then
									text2 = "mnuToolsUploadRSVXFiles"
								ElseIf flag2 = (menuItem2 Is Me.mnuToolsBatchExportFromOneFolder) Then
									text2 = "mnuToolsBatchExportFromOneFolder"
								ElseIf flag2 = (menuItem2 Is Me.mnuToolsDownloadToRSVX) Then
									text2 = "mnuToolsDownloadToRSVX"
								ElseIf flag2 = (menuItem2 Is Me.mnuToolsDeleteTemplate) Then
									text2 = "mnuToolsDeleteTemplate"
								ElseIf flag2 = (menuItem2 Is Me.mnuToolsSeparator2) Then
									text2 = "mnuToolsSeparator2"
								ElseIf flag2 = (menuItem2 Is Me.mnuToolsBatchExportALL) Then
									text2 = "mnuToolsBatchExportALL"
								ElseIf flag2 = (menuItem2 Is Me.mnuToolsEncryptTemplateDatabase) Then
									text2 = "mnuToolsEncryptTemplateDatabase"
								End If
								If Operators.CompareString(text2, "", False) <> 0 Then
									text = str + text2
									text = text.ToLower()
									If RSWIN_DESC.bRunningChineseVersion Then
										text = text.Replace("-zh-hans-", "-")
										Dim [string] As String = cGlobal.Lang.GetString(text)
										If [string] IsNot Nothing Then
											If Operators.CompareString([string].Trim(), "", False) <> 0 Then
												menuItem2.Text = [string]
											End If
										End If
									ElseIf RSWIN_DESC.myALLKeyValueHT.ContainsKey(text) Then
										menuItem2.Text = Conversions.ToString(RSWIN_DESC.myALLKeyValueHT(text))
									End If
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
			Catch ex As Exception
			End Try
		End Sub

		Private Sub RODSTAR_Closed(sender As Object, e As EventArgs)
			Me.bClosing = False
			RSWIN_DESC.bMainClosed = True
		End Sub

		Private Sub mnuWindowNextScreen_Click(sender As Object, e As EventArgs)
			Me.DisplayNext()
			Me.ResetClock()
		End Sub

		Private Sub mnuWindowPreviousScreen_Click(sender As Object, e As EventArgs)
			Me.DisplayPrevious()
			Me.ResetClock()
		End Sub

		Public Function ParentToolbarHeight() As Integer
			' The following expression was wrapped in a checked-expression
			Return Me.pnlToolbar.Height + 25
		End Function

		Private Sub mnuFileSaveAs__Popup(sender As Object, e As EventArgs)
			If RSWIN_DESC.bRodStarD Then
				Me.mnuFileSaveAsRSDX.Enabled = True
				Me.mnuFileSaveAsRSVX.Enabled = False
				Me.mnuFileSaveAsXRVX.Enabled = False
				Return
			End If
			If RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru Then
				Me.mnuFileSaveAsRSDX.Enabled = False
				Me.mnuFileSaveAsRSVX.Enabled = True
				Me.mnuFileSaveAsXRVX.Enabled = True
				Return
			End If
			Me.mnuFileSaveAsRSVX.Enabled = True
			Me.mnuFileSaveAsRSDX.Enabled = False
			Me.mnuFileSaveAsXRVX.Enabled = False
		End Sub

		Public Sub mnuFileSaveAsRSDX__Popup(eventSender As Object, eventArgs As EventArgs)
			Me.mnuFileSaveAsRSDX_Click(RuntimeHelpers.GetObjectValue(eventSender), eventArgs)
		End Sub

		Private Sub mnuFileSaveAsRSDX_Click(sender As Object, e As EventArgs)
			Me.SAVEAFILE(False, True, False, False, False, True, False)
			Me.ResetClock()
		End Sub

		Public Sub mnuFileSaveAsRSVX__Popup(eventSender As Object, eventArgs As EventArgs)
			Me.mnuFileSaveAsRSVX_Click(RuntimeHelpers.GetObjectValue(eventSender), eventArgs)
		End Sub

		Private Sub mnuFileSaveAsRSVX_Click(sender As Object, e As EventArgs)
			Me.SAVEAFILE(False, True, False, False, True, False, False)
			Me.ResetClock()
		End Sub

		Public Sub mnuFileSaveAsXRVX__Popup(eventSender As Object, eventArgs As EventArgs)
			Me.mnuFileSaveAsXRVX_Click(RuntimeHelpers.GetObjectValue(eventSender), eventArgs)
		End Sub

		Private Sub mnuFileSaveAsXRVX_Click(sender As Object, e As EventArgs)
			Me.SAVEAFILE(False, True, False, False, False, False, True)
			Me.ResetClock()
		End Sub

		Private Function GetExtension(sInputFile As String, sOrgExt As String, ByRef sExt As String) As Boolean
			Dim flag As Boolean = True
			If Strings.InStr(sInputFile, ".rsvx", CompareMethod.Binary) > 0 Then
				sExt = "rsvx"
			ElseIf Strings.InStr(sInputFile, ".RSVX", CompareMethod.Binary) > 0 Then
				sExt = "RSVX"
			ElseIf Strings.InStr(sInputFile, ".xrvx", CompareMethod.Binary) > 0 Then
				sExt = "xrvx"
			ElseIf Strings.InStr(sInputFile, ".XRVX", CompareMethod.Binary) > 0 Then
				sExt = "XRVX"
			ElseIf Strings.InStr(sInputFile, ".rsdx", CompareMethod.Binary) > 0 Then
				sExt = "rsdx"
			ElseIf Strings.InStr(sInputFile, ".RSDX", CompareMethod.Binary) > 0 Then
				sExt = "RSDX"
			ElseIf Strings.InStr(sInputFile, ".rst", CompareMethod.Binary) > 0 Then
				sExt = "rst"
			ElseIf Strings.InStr(sInputFile, ".RST", CompareMethod.Binary) > 0 Then
				sExt = "RST"
			Else
				flag = False
			End If
			If flag And Operators.CompareString(sOrgExt.ToLower().Trim(), sExt.ToLower().Trim(), False) = 0 Then
				flag = False
			End If
			Return flag
		End Function

		Private Sub RODSTAR_Click(sender As Object, e As EventArgs)
			Me.ResetClock()
		End Sub

		Public Sub BringUpBatchOptForm()
			Dim dlgBatchOpts As dlgBatchOpts = New dlgBatchOpts()
			Me.frmHowToStart.Hide()
			dlgBatchOpts.bRST = Me.m_bRST
			dlgBatchOpts.ShowDialog()
			dlgBatchOpts.Hide()
		End Sub

		Public Function GetToolbar2State(iTB As Integer) As Boolean
			Dim enabled As Boolean
			Try
				enabled = Me.tbrToolBar2.Buttons(iTB).Enabled
			Catch ex As Exception
			End Try
			Return enabled
		End Function

		Public Sub UnloadDlgSelectInput()
			Dim frmName As String = ""
			Dim dlgSelectInput As dlgSelectInput = New dlgSelectInput()
			Try
				Dim formName As String = "dlgSelectInput"
				Dim form As Form = dlgSelectInput
				Dim flag As Boolean = Me.ReturnMdiForm(formName, form)
				dlgSelectInput = CType(form, dlgSelectInput)
				Dim flag2 As Boolean = flag
				If flag2 AndAlso Not dlgSelectInput.bCancel Then
					Dim controlName As String = dlgSelectInput.ControlName
					Dim tabName As String = dlgSelectInput.TabName
					Select Case RSWIN_DESC.ScrnNum
						Case 1
							frmName = "WellInfo"
						Case 2
							frmName = "ProdInfo"
						Case 3
							frmName = "PTInfo"
						Case 4
							frmName = "RSInput"
						Case 5
							frmName = "DeviationProfile"
						Case 6
							frmName = "PUData"
						Case 7
							frmName = "MotorData"
					End Select
					Me.DisplayForm(frmName, controlName)
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub btnAlpha_Click(sender As Object, e As EventArgs)
			Me.ResetClock()
			Me.AddDlgSelectInput(True, False)
		End Sub

		Private Sub AddVisInput(bShow As Boolean, bSendToBack As Boolean)
			' The following expression was wrapped in a checked-statement
			Try
				Dim flag As Boolean
				If Not Me.MdiFormExists("VisInput", True, False, bShow, flag) Then
					Me.windowCount += 1
					Dim visInput As VisInput = New VisInput()
					visInput.MdiParent = Me
					visInput.Dock = DockStyle.Right
					Application.DoEvents()
					If bShow Then
						Me.frmHowToStart.Hide()
						visInput.Show()
						Application.DoEvents()
						If bSendToBack Then
							visInput.SendToBack()
						End If
					Else
						visInput.Hide()
					End If
				End If
			Catch ex As Exception
				Dim sMsg As String = "Error in Add VisInput Form: " + ex.Message
				Dim sMsgType As String = ""
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
			End Try
		End Sub

		Public Function ValidateActiveMDIChild(Optional sFormName As String = "") As Boolean
			Dim flag As Boolean = True
			Dim result As Boolean
			Try
				Me.ResetClock()
				Dim activeMdiChild As Form = Me.ActiveMdiChild
				If activeMdiChild IsNot Nothing AndAlso activeMdiChild.Visible Then
					Dim text As String
					If Operators.CompareString(sFormName, "", False) = 0 Then
						text = activeMdiChild.Name
					Else
						text = sFormName
					End If
					Dim text2 As String = text
					If Operators.CompareString(text2, "WellInfo", False) = 0 Then
						Dim wellInfo As WellInfo = New WellInfo()
						Dim formName As String = "WellInfo"
						Dim form As Form = wellInfo
						Dim flag2 As Boolean = Me.ReturnMdiForm(formName, form)
						wellInfo = CType(form, WellInfo)
						Dim flag3 As Boolean = flag2
						If flag3 And wellInfo.Visible Then
							flag = wellInfo.ValidateWellInfoData(False)
							Dim sProblemControlName As String
							If flag Then
								wellInfo.bValidated = False
								flag = Me.ValidateWellInfo(sProblemControlName, False, False)
							End If
							If Not flag Then
								Me.DisplayForm("WellInfo", sProblemControlName)
							End If
						End If
					ElseIf Operators.CompareString(text2, "ProdInfo", False) = 0 Then
						Dim prodInfo As ProdInfo = New ProdInfo()
						Dim formName2 As String = "ProdInfo"
						Dim form As Form = prodInfo
						Dim flag4 As Boolean = Me.ReturnMdiForm(formName2, form)
						prodInfo = CType(form, ProdInfo)
						Dim flag3 As Boolean = flag4
						If flag3 And prodInfo.Visible Then
							Dim flag5 As Boolean
							flag = prodInfo.ValidateProdInfo(flag5, False)
							Dim sProblemControlName As String
							If flag Then
								Dim bQuiet As Boolean = False
								Dim text3 As String = "ProdInfo"
								flag = Me.ValidateProdInfo(sProblemControlName, bQuiet, text3, False)
							End If
							If Not flag Then
								Me.DisplayForm("ProdInfo", sProblemControlName)
							End If
						End If
					ElseIf Operators.CompareString(text2, "PTInfo", False) = 0 Then
						Dim ptinfo As PTInfo = New PTInfo()
						Dim formName3 As String = "PTInfo"
						Dim form As Form = ptinfo
						Dim flag6 As Boolean = Me.ReturnMdiForm(formName3, form)
						ptinfo = CType(form, PTInfo)
						Dim flag3 As Boolean = flag6
						If flag3 And ptinfo.Visible Then
							flag = ptinfo.ValidatePTInfo(False)
							Dim sProblemControlName As String
							If flag Then
								flag = Me.ValidatePTInfo(sProblemControlName, False, False)
							End If
							If Not flag Then
								Me.DisplayForm("PTInfo", sProblemControlName)
							End If
						End If
					ElseIf Operators.CompareString(text2, "RSInput", False) = 0 Then
						Dim rsinput As RSInput = New RSInput()
						Dim formName4 As String = "RSInput"
						Dim form As Form = rsinput
						Dim flag7 As Boolean = Me.ReturnMdiForm(formName4, form)
						rsinput = CType(form, RSInput)
						Dim flag3 As Boolean = flag7
						If flag3 And rsinput.Visible Then
							flag = rsinput.ValidateRSInput(True, False, False)
							Dim sProblemControlName As String
							If flag Then
								flag = Me.ValidateRSInput(sProblemControlName, False, False)
							End If
							If Not flag Then
								Me.DisplayForm("RSInput", sProblemControlName)
							End If
						End If
					ElseIf Operators.CompareString(text2, "PUData", False) = 0 Then
						Dim pudata As PUData = New PUData()
						Dim formName5 As String = "PUData"
						Dim form As Form = pudata
						Dim flag8 As Boolean = Me.ReturnMdiForm(formName5, form)
						pudata = CType(form, PUData)
						Dim flag3 As Boolean = flag8
						If flag3 And pudata.Visible Then
							flag = pudata.ValidatePUData(False)
							Dim sProblemControlName As String
							If flag Then
								pudata.bValidated = False
								flag = Me.ValidatePUData(sProblemControlName, False, False)
							End If
							If Not flag Then
								Me.DisplayForm("PUData", sProblemControlName)
							End If
						End If
					ElseIf Operators.CompareString(text2, "MotorData", False) = 0 Then
						Dim motorData As MotorData = New MotorData()
						Dim formName6 As String = "MotorData"
						Dim form As Form = motorData
						Dim flag9 As Boolean = Me.ReturnMdiForm(formName6, form)
						motorData = CType(form, MotorData)
						Dim flag3 As Boolean = flag9
						If flag3 And motorData.Visible Then
							flag = motorData.ValidateMotorData(False)
							Dim sProblemControlName As String
							If flag Then
								motorData.bValidated = False
								flag = Me.ValidateMotorData(sProblemControlName, False, False)
							End If
							If Not flag Then
								Me.DisplayForm("MotorData", sProblemControlName)
							End If
						End If
					End If
				End If
				result = flag
			Catch ex As Exception
			End Try
			Return result
		End Function

		Private Sub DisplayActiveForm(ByRef frm As Form, sProblemControlName As String)
			Dim flag As Boolean = False
			frm.Activate()
			Try
				For Each obj As Object In frm.Controls
					Dim control As Control = CType(obj, Control)
					Dim index As Integer = frm.Controls.IndexOf(control)
					If Operators.CompareString(control.Name, sProblemControlName, False) = 0 Then
						frm.Controls(index).Focus()
						flag = True
						Exit For
					End If
					Try
						For Each obj2 As Object In control.Controls
							Dim control2 As Control = CType(obj2, Control)
							If Operators.CompareString(control2.Name, sProblemControlName, False) = 0 Then
								index = frm.Controls.IndexOf(control)
								Dim index2 As Integer = control.Controls.IndexOf(control2)
								frm.Controls(index).Focus()
								frm.Controls(index).Controls(index2).Focus()
								flag = True
								Exit For
							End If
							Try
								For Each obj3 As Object In control2.Controls
									Dim control3 As Control = CType(obj3, Control)
									If Operators.CompareString(control3.Name, sProblemControlName, False) = 0 Then
										Try
											index = frm.Controls.IndexOf(control)
											Dim index2 As Integer = control.Controls.IndexOf(control2)
											Dim index3 As Integer = control2.Controls.IndexOf(control3)
											frm.Controls(index).Focus()
											frm.Controls(index).Controls(index2).Focus()
											frm.Controls(index).Controls(index2).Controls(index3).Focus()
											flag = True
											Exit Try
										Catch ex As Exception
										End Try
									End If
									If flag Then
										Exit For
									End If
								Next
							Finally
								Dim enumerator3 As IEnumerator
								If TypeOf enumerator3 Is IDisposable Then
									TryCast(enumerator3, IDisposable).Dispose()
								End If
							End Try
							If flag Then
								Exit For
							End If
						Next
					Finally
						Dim enumerator2 As IEnumerator
						If TypeOf enumerator2 Is IDisposable Then
							TryCast(enumerator2, IDisposable).Dispose()
						End If
					End Try
					If flag Then
						Exit For
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		Private Sub tbrGuru_ButtonClick(sender As Object, e As ToolBarButtonClickEventArgs)
			' The following expression was wrapped in a checked-statement
			Try
				Dim text As String = ""
				If RSWIN_DESC.SETUP_bGuru Then
					RSWIN_DESC.SETUP_bGuru = False
					RSWIN_DESC.RECENTFILES = "XRODV Recent Files"
					Me.lblGURU.Visible = False
					Me.btnGuru.Visible = False
					Me.tbrGuru.Buttons(0).Pushed = False
					Me.tbrToolbar.Buttons(11).Visible = True
					Me.tbrToolbar.Buttons(13).Visible = True
					Me.tbrToolbar.Buttons(10).Visible = True
					Me.tbrToolbar.Buttons(14).Visible = True
					Me._mnuWindowInput_3.Enabled = True
					Me._mnuWindowInput_4.Enabled = True
					Me._mnuWindowInput_6.Enabled = True
					Me._mnuWindowInput_7.Enabled = True
					Me.LoadRecentFiles(RSWIN_DESC.sINIFile, RSWIN_DESC.RECENTFILES)
				Else
					RSWIN_DESC.SETUP_bGuru = True
					RSWIN_DESC.RECENTFILES = "AI Recent Files"
					Me.lblGURU.Left = Me.panStatus.Width - 108
					Me.lblGURU.Height = Me.panStatus.Height
					Me.lblGURU.Top = Me.panStatus.Top
					Me.tbrGuru.Buttons(0).Pushed = True
					Me.btnGuru.Left = Me.lblGURU.Left
					Me.btnGuru.Top = Me.lblGURU.Top - Me.btnGuru.Height
					Me.lblGURU.Visible = True
					Me.tbrToolbar.Buttons(11).Visible = False
					Me.tbrToolbar.Buttons(13).Visible = False
					Me.tbrToolbar.Buttons(10).Visible = False
					Me.tbrToolbar.Buttons(14).Visible = False
					Me.ToolbarButtonSetState2(2, False)
					Me._mnuWindowInput_3.Enabled = False
					Me._mnuWindowInput_4.Enabled = False
					Me._mnuWindowInput_6.Enabled = False
					Me._mnuWindowInput_7.Enabled = False
					Me.LoadRecentFiles(RSWIN_DESC.sINIFile, RSWIN_DESC.RECENTFILES)
					Dim sTemplateDBFileName As String = RSWIN_DESC.sTemplateDBFileName
					Dim guruDataBaseFileName As String = RSWIN_DESC.GuruDataBaseFileName
					FILEUTIL.LocateFile(sTemplateDBFileName, guruDataBaseFileName, 2S, True, False, False, False)
					RSWIN_DESC.GuruDataBaseFileName = guruDataBaseFileName
					FILEUTIL.LocateFile(RSWIN_DESC.sXRODV_Gif_Corner_Filename, text, 0S, True, False, False, False)
					If Operators.CompareString(text, "", False) <> 0 Then
						Me.btnGuru.Text = ""
						Dim image As Bitmap = New Bitmap(text)
						Me.btnGuru.Image = image
					Else
						Me.btnGuru.Text = "AI Mode"
					End If
					Me.btnGuru.Visible = True
					Me.btnGuru.BringToFront()
				End If
				Me.SetMnuFileSaveAs()
				ini.SavePreferenceDataValue("bGuru", Convert.ToString(RSWIN_DESC.SETUP_bGuru))
				Me.ForGuruModeReDisplayActiveChildForm()
				If Me.btnGuru.Visible Then
					Me.btnMeasUnit.Top = Me.panStatus.Top
					Me.btnMeasUnit.Left = Me.btnGuru.Left - Me.btnMeasUnit.Width
					Me.btnMeasUnit.BringToFront()
				Else
					Me.btnMeasUnit.Left = Me.panStatus.Left + Me.panStatus.Width - 40
					Me.btnMeasUnit.Top = Me.panStatus.Top
					Me.btnMeasUnit.BringToFront()
				End If
			Catch ex As Exception
			End Try
		End Sub

		Public Sub ForGuruModeReDisplayActiveChildForm()
			Dim flag As Boolean = False
			Dim name As String
			Try
				Dim activeMdiChild As Form = Me.ActiveMdiChild
				name = activeMdiChild.Name
				If activeMdiChild.Visible Then
					flag = True
					activeMdiChild.Hide()
				End If
				Me.RemoveForms()
			Catch ex As Exception
			End Try
			If flag Then
				Try
					Dim text As String = name
					If Operators.CompareString(text, "WellInfo", False) = 0 Then
						Me.AddWellInfo(True)
					ElseIf Operators.CompareString(text, "ProdInfo", False) = 0 Then
						Me.AddProdInfo(True)
					ElseIf Operators.CompareString(text, "PTInfo", False) = 0 Then
						If Not RSWIN_DESC.SETUP_bGuru Then
							Me.AddPTInfo(True)
						End If
					ElseIf Operators.CompareString(text, "PUData", False) = 0 Then
						If Not RSWIN_DESC.SETUP_bGuru Then
							Me.AddPUData(True)
						End If
					ElseIf Operators.CompareString(text, "MotorData", False) = 0 AndAlso Not RSWIN_DESC.SETUP_bGuru Then
						Me.AddMotorData(True)
					End If
				Catch ex2 As Exception
				End Try
				Return
			End If
		End Sub

		Private Sub btnGuru_Click(sender As Object, e As EventArgs)
			Me.ResetClock()
			If Me.btnGuru Is Me.ActiveControl Then
				Me.btnGuruChanged()
				ini.SavePreferenceDataValue("bGuru", Convert.ToString(RSWIN_DESC.SETUP_bGuru))
				Me.ForGuruModeReDisplayActiveChildForm()
				If Not RSWIN_DESC.SETUP_bGuru Then
					Me.ToolbarButtonSetState2(2, False)
				End If
				If Me.btnGuru.Visible Then
					Me.btnMeasUnit.Top = Me.panStatus.Top
					Me.btnMeasUnit.Left = Me.btnGuru.Left - Me.btnMeasUnit.Width
					Me.btnMeasUnit.BringToFront()
				Else
					Me.btnMeasUnit.Left = Me.panStatus.Left + Me.panStatus.Width - 40
					Me.btnMeasUnit.Top = Me.panStatus.Top
					Me.btnMeasUnit.BringToFront()
				End If
			End If
			If RSWIN_DESC.bExpert Then
				If RSWIN_DESC.SETUP_bGuru Then
					RSWIN_DESC.rst.RSTDir = Conversions.ToString(RSWIN.GetInitialDir(".XRVX", ""))
				Else
					RSWIN_DESC.rst.RSTDir = Conversions.ToString(RSWIN.GetInitialDir(".RSVX", ""))
				End If
				Return
			End If
		End Sub

		Private Sub btnGuruChanged()
			' The following expression was wrapped in a checked-statement
			Try
				Dim text As String = ""
				If RSWIN_DESC.SETUP_bGuru Then
					RSWIN_DESC.SETUP_bGuru = False
					ini.SavePreferenceDataValue("bGuru", Convert.ToString(RSWIN_DESC.SETUP_bGuru))
					Me.lblGURU.Visible = False
					Me.btnGuru.Visible = False
					Me.tbrGuru.Buttons(0).Pushed = False
					Me.tbrToolbar.Buttons(11).Visible = True
					Me.tbrToolbar.Buttons(13).Visible = True
					Me.tbrToolbar.Buttons(10).Visible = True
					Me.tbrToolbar.Buttons(14).Visible = True
					Me._mnuWindowInput_3.Enabled = True
					Me._mnuWindowInput_4.Enabled = True
					Me._mnuWindowInput_6.Enabled = True
					Me._mnuWindowInput_7.Enabled = True
				Else
					RSWIN_DESC.SETUP_bGuru = True
					ini.SavePreferenceDataValue("bGuru", Convert.ToString(RSWIN_DESC.SETUP_bGuru))
					Me.lblGURU.Left = Me.panStatus.Width - 108
					Me.lblGURU.Height = Me.panStatus.Height
					Me.lblGURU.Top = Me.panStatus.Top
					Me.tbrGuru.Buttons(0).Pushed = True
					Me.btnGuru.Left = Me.lblGURU.Left
					Me.btnGuru.Top = Me.lblGURU.Top - Me.btnGuru.Height
					Me.lblGURU.Visible = True
					Me.tbrToolbar.Buttons(11).Visible = False
					Me.tbrToolbar.Buttons(13).Visible = False
					Me.tbrToolbar.Buttons(10).Visible = False
					Me.tbrToolbar.Buttons(14).Visible = False
					Me.ToolbarButtonSetState2(2, False)
					Me._mnuWindowInput_3.Enabled = False
					Me._mnuWindowInput_4.Enabled = False
					Me._mnuWindowInput_6.Enabled = False
					Me._mnuWindowInput_7.Enabled = False
					FILEUTIL.LocateFile(RSWIN_DESC.sXRODV_Gif_Corner_Filename, text, 0S, False, False, False, False)
					If Operators.CompareString(text, "", False) <> 0 Then
						Me.btnGuru.Text = ""
						Dim image As Bitmap = New Bitmap(text)
						Me.btnGuru.Image = image
					Else
						Me.btnGuru.Text = "AI Mode"
					End If
					Me.btnGuru.Visible = True
					Dim sTemplateDBFileName As String = RSWIN_DESC.sTemplateDBFileName
					Dim guruDataBaseFileName As String = RSWIN_DESC.GuruDataBaseFileName
					FILEUTIL.LocateFile(sTemplateDBFileName, guruDataBaseFileName, 2S, True, False, False, False)
					RSWIN_DESC.GuruDataBaseFileName = guruDataBaseFileName
				End If
				If RSWIN_DESC.SETUP_bGuru Then
					Me.btnMeasUnit.Left = Me.btnGuru.Left - Me.btnMeasUnit.Width
				Else
					Me.btnMeasUnit.Left = Me.panStatus.Left + Me.panStatus.Width - 40
				End If
				Try
					Me.LoadRecentFiles(RSWIN_DESC.sINIFile, RSWIN_DESC.RECENTFILES)
				Catch ex As Exception
				End Try
			Catch ex2 As Exception
			End Try
		End Sub

		Public Function ReadSaveGuruFile(rfn As String, indx As Integer) As Boolean
			Dim result As Boolean
			Try
				Dim flag As Boolean = False
				If RSWIN_DESC.bRunGuru Then
					RSWIN_DESC.rst_save = New cRODSTAR()
					RSWIN_DESC.rst_save.SetClassDefaults(False)
					Me.SaveRSObject()
					If Strings.Len(rfn) > 0 Then
						Dim rst As cRODSTAR = RSWIN_DESC.rst
						Dim gbInputDataChanged As Boolean = rst.gbInputDataChanged
						Dim cursor As Cursor
						Dim flag2 As Boolean
						Me.LoadOneFile(cursor, rfn, flag2, gbInputDataChanged, False)
						rst.gbInputDataChanged = gbInputDataChanged
						If flag2 Then
							Me.MergeGURUInputs(indx, flag)
							rfn = RSWIN_DESC.SETUP_GURUTEMPDIR + Util.FileName(rfn)
							RSWIN_DESC.mrgBatchFileList(indx) = rfn
							If FILEUTIL.FileExists(rfn) Then
								FileSystem.Kill(rfn)
							End If
							Dim flag4 As Boolean
							Dim flag5 As Boolean
							Dim flag3 As Boolean = MRodstarXML.StoreXML(rfn, False, flag4, flag5)
						Else
							RSWIN_DESC.rst = RSWIN_DESC.rst_save
						End If
						result = True
					Else
						If RSWIN_DESC.bOneGuruFile Then
							MessageBox.Show("The target production cannot be achieved with this pumping unit type!")
						End If
						result = False
					End If
				End If
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Function GetGuruFileName(PumpDepth As Single, TargetBFPD As Single, PUManuf As String, iManuf As Integer, ByRef prefix As String, Optional bUsePUUnitType As Boolean = False, Optional ByRef sFileName As String = "", Optional bCheckForTargetProduction As Boolean = True) As String
			' The following expression was wrapped in a checked-statement
			Dim result As String
			Try
				Dim str As String = ""
				Dim text As String = ""
				Dim text2 As String = ""
				Dim text3 As String = ""
				Dim flag As Boolean = True
				prefix = ""
				If PumpDepth >= 1000F Then
					If PumpDepth <= 19000F Then
						Dim num As Integer = Convert.ToInt32(PumpDepth)
					End If
				End If
				If TargetBFPD >= 50F Then
					If TargetBFPD <= 5000F Then
						Dim num2 As Integer = Convert.ToInt32(TargetBFPD)
					End If
				End If
				Dim num3 As Short
				If bUsePUUnitType Then
					num3 = RSWIN_DESC.rst.PU.UnitType
				Else
					num3 = Me.GetManufUnitType(PUManuf)
				End If
				If(num3 = 1S Or num3 = 3S Or num3 = 8S Or num3 = 9S Or num3 = 4S) And RSWIN_DESC.SETUP_bUseSteelRodsOnly Then
					str = RSWIN_DESC.sExpertFileFolders(0) + "\"
					prefix = RSWIN_DESC.sExpertFilePrefixes(0)
					text2 = ""
				ElseIf(num3 = 1S Or num3 = 3S Or num3 = 8S Or num3 = 9S Or num3 = 4S) And RSWIN_DESC.SETUP_bUseFGlassWithSteelOnBottom Then
					str = RSWIN_DESC.sExpertFileFolders(1) + "\"
					prefix = RSWIN_DESC.sExpertFilePrefixes(1)
					text2 = ""
				ElseIf num3 = 5S And RSWIN_DESC.SETUP_bUseSteelRodsOnly Then
					str = RSWIN_DESC.sExpertFileFolders(2) + "\"
					prefix = RSWIN_DESC.sExpertFilePrefixes(2)
					text2 = RSWIN_DESC.sExpertFileFolders(0) + "\"
					text3 = RSWIN_DESC.sExpertFilePrefixes(0)
				ElseIf num3 = 5S And RSWIN_DESC.SETUP_bUseFGlassWithSteelOnBottom Then
					str = RSWIN_DESC.sExpertFileFolders(3) + "\"
					prefix = RSWIN_DESC.sExpertFilePrefixes(3)
					text2 = RSWIN_DESC.sExpertFileFolders(1) + "\"
					text3 = RSWIN_DESC.sExpertFilePrefixes(1)
				ElseIf(num3 = 2S Or Strings.InStr(PUManuf, "Reverse Mark", CompareMethod.Binary) > 0) And RSWIN_DESC.SETUP_bUseSteelRodsOnly Then
					str = RSWIN_DESC.sExpertFileFolders(4) + "\"
					prefix = RSWIN_DESC.sExpertFilePrefixes(4)
					text2 = RSWIN_DESC.sExpertFileFolders(0) + "\"
					text3 = RSWIN_DESC.sExpertFilePrefixes(0)
				ElseIf(num3 = 2S Or Strings.InStr(PUManuf, "Reverse Mark", CompareMethod.Binary) > 0) And RSWIN_DESC.SETUP_bUseFGlassWithSteelOnBottom Then
					str = RSWIN_DESC.sExpertFileFolders(5) + "\"
					prefix = RSWIN_DESC.sExpertFilePrefixes(5)
					text2 = RSWIN_DESC.sExpertFileFolders(1) + "\"
					text3 = RSWIN_DESC.sExpertFilePrefixes(1)
				ElseIf num3 = 10S And RSWIN_DESC.SETUP_bUseSteelRodsOnly Then
					str = RSWIN_DESC.sExpertFileFolders(0) + "\"
					prefix = RSWIN_DESC.sExpertFilePrefixes(0)
					text2 = RSWIN_DESC.sExpertFileFolders(0) + "\"
					text3 = RSWIN_DESC.sExpertFilePrefixes(0)
				ElseIf num3 = 10S And RSWIN_DESC.SETUP_bUseFGlassWithSteelOnBottom Then
					str = RSWIN_DESC.sExpertFileFolders(1) + "\"
					prefix = RSWIN_DESC.sExpertFilePrefixes(1)
					text2 = RSWIN_DESC.sExpertFileFolders(1) + "\"
					text3 = RSWIN_DESC.sExpertFilePrefixes(1)
				ElseIf num3 = 7S And RSWIN_DESC.SETUP_bUseSteelRodsOnly Then
					str = RSWIN_DESC.sExpertFileFolders(6) + "\"
					prefix = RSWIN_DESC.sExpertFilePrefixes(6)
					text2 = RSWIN_DESC.sExpertFileFolders(0) + "\"
					text3 = RSWIN_DESC.sExpertFilePrefixes(0)
				ElseIf num3 = 7S And RSWIN_DESC.SETUP_bUseFGlassWithSteelOnBottom Then
					str = RSWIN_DESC.sExpertFileFolders(7) + "\"
					prefix = RSWIN_DESC.sExpertFilePrefixes(7)
					text2 = RSWIN_DESC.sExpertFileFolders(1) + "\"
					text3 = RSWIN_DESC.sExpertFilePrefixes(1)
				ElseIf num3 = 6S And RSWIN_DESC.SETUP_bUseSteelRodsOnly Then
					str = RSWIN_DESC.sExpertFileFolders(8) + "\"
					prefix = RSWIN_DESC.sExpertFilePrefixes(8)
					text2 = RSWIN_DESC.sExpertFileFolders(0) + "\"
					text3 = RSWIN_DESC.sExpertFilePrefixes(0)
				ElseIf num3 = 6S And RSWIN_DESC.SETUP_bUseFGlassWithSteelOnBottom Then
					str = RSWIN_DESC.sExpertFileFolders(9) + "\"
					prefix = RSWIN_DESC.sExpertFilePrefixes(9)
					text2 = RSWIN_DESC.sExpertFileFolders(1) + "\"
					text3 = RSWIN_DESC.sExpertFilePrefixes(1)
				End If
				Dim text4 As String = String.Concat(New String() { prefix, PumpDepth.ToString().Trim(), "-", TargetBFPD.ToString().Trim(), ".rsvx" })
				sFileName = text4
				Dim text5 As String = str + text4
				If FILEUTIL.FileExists(text5) Then
					text = str + text4
				ElseIf PumpDepth <= 20000F And TargetBFPD <= 6000F Then
					Dim num4 As Integer = 1000
					While True
						Dim num5 As Integer = 50
						Do
							text4 = String.Concat(New String() { prefix, num4.ToString().Trim(), "-", num5.ToString().Trim(), ".rsvx" })
							text5 = str + text4
							If FILEUTIL.FileExists(text5) Then
								' The following expression was wrapped in a unchecked-expression
								If CSng(num4) >= PumpDepth And (CSng(num5) >= TargetBFPD Or (CSng(num5) < TargetBFPD And TargetBFPD - CSng(num5) < 5F)) Then
									GoTo Block_22
								End If
								text = ""
							End If
							num5 += 25
						Loop While num5 <= 5000
						IL_594:
						If Operators.CompareString(text, "", False) <> 0 Then
							Exit For
						End If
						num4 += 500
						If num4 > 20000 Then
							Exit For
						End If
						Continue For
						Block_22:
						text = str + text4
						GoTo IL_594
					End While
				End If
				If Not flag Then
					text2 = ""
				End If
				If Operators.CompareString(text, "", False) = 0 Then
					If Operators.CompareString(text2, "", False) = 0 AndAlso bCheckForTargetProduction Then
						If RSWIN_DESC.bOneGuruFile Then
							MessageBox.Show("The target production cannot be achieved with " + PUManuf + "!")
						End If
					Else
						If RSWIN_DESC.bOneGuruFile AndAlso bCheckForTargetProduction Then
							MessageBox.Show("The target production cannot be achieved with " + PUManuf + "! Will look for conventional substitute!")
						End If
						text4 = String.Concat(New String() { text3, PumpDepth.ToString().Trim(), "-", TargetBFPD.ToString().Trim(), ".rsvx" })
						prefix = text3
						text5 = text2 + text4
						If FILEUTIL.FileExists(text5) Then
							text = text2 + text4
						Else
							Dim num4 As Integer = 1000
							While True
								Dim num5 As Integer = 50
								Do
									text4 = String.Concat(New String() { text3, num4.ToString().Trim(), "-", num5.ToString().Trim(), ".rsvx" })
									text5 = text2 + text4
									If FILEUTIL.FileExists(text5) Then
										If CSng(num4) >= PumpDepth And CSng(num5) >= TargetBFPD Then
											GoTo Block_31
										End If
										text = ""
									End If
									num5 += 25
								Loop While num5 <= 5000
								IL_744:
								If Operators.CompareString(text, "", False) <> 0 Then
									Exit For
								End If
								num4 += 500
								If num4 > 19000 Then
									Exit For
								End If
								Continue For
								Block_31:
								text = text2 + text4
								GoTo IL_744
							End While
						End If
					End If
				End If
				If Operators.CompareString(text, "", False) = 0 Then
					RSWIN_DESC.bBatchGuruPUManufFound(iManuf) = False
				Else
					RSWIN_DESC.bBatchGuruPUManufFound(iManuf) = True
				End If
				result = text
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Function GetGuruDBFileName(PumpDepth As Single, fTargetBFPD As Single, PUManuf As String, iManuf As Integer, ByRef prefix As String) As String
			' The following expression was wrapped in a checked-statement
			Dim result As String
			Try
				Dim text As String = ""
				Dim text2 As String = ""
				Dim text3 As String = ""
				Dim text4 As String = ""
				Dim text5 As String = ""
				Dim flag As Boolean = False
				Dim flag2 As Boolean = False
				Dim array As RSWIN_DESC.GuruFileDataStructure() = New RSWIN_DESC.GuruFileDataStructure(0) {}
				Dim num As Single = fTargetBFPD
				prefix = ""
				If PumpDepth >= 1000F Then
					If PumpDepth <= 19000F Then
						Dim num2 As Integer = Convert.ToInt32(PumpDepth)
					End If
				End If
				If num >= 50F Then
					If num <= 5000F Then
						Dim num3 As Integer = Convert.ToInt32(num)
					End If
				End If
				Dim manufUnitType As Short = Me.GetManufUnitType(PUManuf)
				If(manufUnitType = 1S Or manufUnitType = 3S Or manufUnitType = 8S Or manufUnitType = 9S Or manufUnitType = 4S) And RSWIN_DESC.SETUP_bUseSteelRodsOnly Then
					prefix = RSWIN_DESC.sExpertFilePrefixes(0)
				ElseIf(manufUnitType = 1S Or manufUnitType = 3S Or manufUnitType = 8S Or manufUnitType = 9S Or manufUnitType = 4S) And RSWIN_DESC.SETUP_bUseFGlassWithSteelOnBottom Then
					prefix = RSWIN_DESC.sExpertFilePrefixes(1)
				ElseIf manufUnitType = 5S And RSWIN_DESC.SETUP_bUseSteelRodsOnly Then
					prefix = RSWIN_DESC.sExpertFilePrefixes(2)
					text3 = RSWIN_DESC.sExpertFileFolders(0) + "\"
					text2 = RSWIN_DESC.sExpertFilePrefixes(0)
				ElseIf manufUnitType = 5S And RSWIN_DESC.SETUP_bUseFGlassWithSteelOnBottom Then
					prefix = RSWIN_DESC.sExpertFilePrefixes(3)
					text3 = RSWIN_DESC.sExpertFileFolders(1) + "\"
					text2 = RSWIN_DESC.sExpertFilePrefixes(1)
				ElseIf manufUnitType = 2S And RSWIN_DESC.SETUP_bUseSteelRodsOnly Then
					prefix = RSWIN_DESC.sExpertFilePrefixes(4)
					text3 = RSWIN_DESC.sExpertFileFolders(0) + "\"
					text2 = RSWIN_DESC.sExpertFilePrefixes(0)
				ElseIf manufUnitType = 2S And RSWIN_DESC.SETUP_bUseFGlassWithSteelOnBottom Then
					prefix = RSWIN_DESC.sExpertFilePrefixes(5)
					text3 = RSWIN_DESC.sExpertFileFolders(1) + "\"
					text2 = RSWIN_DESC.sExpertFilePrefixes(1)
				ElseIf manufUnitType = 10S And RSWIN_DESC.SETUP_bUseSteelRodsOnly Then
					prefix = RSWIN_DESC.sExpertFilePrefixes(0)
					text3 = RSWIN_DESC.sExpertFileFolders(0) + "\"
					text2 = RSWIN_DESC.sExpertFilePrefixes(0)
				ElseIf manufUnitType = 10S And RSWIN_DESC.SETUP_bUseFGlassWithSteelOnBottom Then
					prefix = RSWIN_DESC.sExpertFilePrefixes(1)
					text3 = RSWIN_DESC.sExpertFileFolders(1) + "\"
					text2 = RSWIN_DESC.sExpertFilePrefixes(1)
				ElseIf manufUnitType = 7S And RSWIN_DESC.SETUP_bUseSteelRodsOnly Then
					prefix = RSWIN_DESC.sExpertFilePrefixes(6)
					text3 = RSWIN_DESC.sExpertFileFolders(0) + "\"
					text2 = RSWIN_DESC.sExpertFilePrefixes(0)
				ElseIf manufUnitType = 7S And RSWIN_DESC.SETUP_bUseFGlassWithSteelOnBottom Then
					prefix = RSWIN_DESC.sExpertFilePrefixes(7)
					text3 = RSWIN_DESC.sExpertFileFolders(1) + "\"
					text2 = RSWIN_DESC.sExpertFilePrefixes(1)
				ElseIf manufUnitType = 6S And RSWIN_DESC.SETUP_bUseSteelRodsOnly Then
					prefix = RSWIN_DESC.sExpertFilePrefixes(8)
					text3 = RSWIN_DESC.sExpertFileFolders(0) + "\"
					text2 = RSWIN_DESC.sExpertFilePrefixes(0)
				ElseIf manufUnitType = 6S And RSWIN_DESC.SETUP_bUseFGlassWithSteelOnBottom Then
					prefix = RSWIN_DESC.sExpertFilePrefixes(9)
					text3 = RSWIN_DESC.sExpertFileFolders(1) + "\"
					text2 = RSWIN_DESC.sExpertFilePrefixes(1)
				End If
				If RSWIN_DESC.rst_save.Runtime = 24F Then
					text5 = prefix + PumpDepth.ToString().Trim() + "-" + num.ToString().Trim()
				Else
					Dim text6 As String = RSWIN.gettargetbfpd(num, RSWIN_DESC.rst_save.Runtime).Trim()
					num = Convert.ToSingle(text6)
					text5 = prefix + PumpDepth.ToString().Trim() + "-" + text6
				End If
				array = New RSWIN_DESC.GuruFileDataStructure(0) {}
				Dim num4 As Single
				Dim num5 As Single
				Me.LoadPrefixGuruFiles(prefix, array, num4, num5)
				text4 = prefix + RSWIN.getpumpdepth(PumpDepth).Trim() + "-" + RSWIN.gettargetbfpd(fTargetBFPD, RSWIN_DESC.rst_save.Runtime).Trim()
				If GURU_DB.DBFileNameKeyExistsFromArrayUsingPrefix(text5, text4, array, PUManuf) Then
					text = text5
					flag = True
				ElseIf Information.UBound(array, 1) > 10 Then
					If PumpDepth <= 20000F And num <= 6000F Then
						Dim num6 As Integer = 25
						Dim num7 As Integer = Conversions.ToInteger(Me.SetStartPoint(num))
						Dim num8 As Integer = 1000
						Do
							Dim num9 As Integer = num7
							Dim num10 As Integer = num6
							Dim num11 As Integer = num9
							While (num10 >> 31 Xor num11) <= (num10 >> 31 Xor 6000)
								text5 = prefix + num8.ToString().Trim() + "-" + num11.ToString().Trim()
								Dim text7 As String = ""

									If GURU_DB.DBFileNameKeyExistsFromArrayUsingPrefix(text5, text7, array, PUManuf) Then
										If CSng(num8) = PumpDepth And CSng(num11) = num Then
											text = text5
											flag = True
											Exit While
										End If
										If CDbl((Math.Abs(CSng(num8) - PumpDepth) / CSng(num8))) < 0.025 And CDbl((Math.Abs(CSng(num11) - num) / CSng(num11))) < 0.025 Then
											text = text5
											flag = True
											Exit While
										End If
										If CSng(num8) >= PumpDepth And (CSng(num11) >= num Or (CSng(num11) < num And num - CSng(num11) < 5F)) Then
											text = text5
											flag = True
											Exit While
										End If
										text = ""
									End If

								num11 += num10
							End While
							If Operators.CompareString(text, "", False) <> 0 Then
								Exit Do
							End If
							num8 += 500
						Loop While num8 <= 20000
					Else
						flag = False
						text = ""
					End If
				End If
				If Not flag2 Then
					text3 = ""
				End If
				If Operators.CompareString(text, "", False) = 0 Then
					If Operators.CompareString(text3, "", False) = 0 Then
						If RSWIN_DESC.bOneGuruFile Then
							MessageBox.Show("The target production cannot be achieved with " + PUManuf.Trim() + "!")
						End If
					Else
						If RSWIN_DESC.bOneGuruFile Then
							MessageBox.Show("The target production cannot be achieved with " + PUManuf + "! Will look for conventional substitute!")
						End If
						array = New RSWIN_DESC.GuruFileDataStructure(0) {}
						Me.LoadPrefixGuruFiles(text2, array, num4, num5)
						prefix = text2
						text5 = text2 + PumpDepth.ToString().Trim() + "-" + num.ToString().Trim()
						text4 = prefix + RSWIN.getpumpdepth(PumpDepth).Trim() + "-" + RSWIN.gettargetbfpd(num, RSWIN_DESC.rst_save.Runtime).Trim()
						If GURU_DB.DBFileNameKeyExistsFromArrayUsingPrefix(text5, text4, array, PUManuf) Then
							text = text5
							flag = True
						Else
							Dim num8 As Integer = 1000
							While True
								Dim num11 As Integer = 50
								Do
									text5 = text2 + num8.ToString().Trim() + "-" + num11.ToString().Trim()
									Dim text7 As String = ""
									If GURU_DB.DBFileNameKeyExistsFromArrayUsingPrefix(text5, text7, array, PUManuf) Then
										If CSng(num8) >= PumpDepth And CSng(num11) >= num Then
											GoTo Block_35
										End If
										text = ""
									End If
									num11 += 25
								Loop While num11 <= 5000
								IL_6FA:
								If Operators.CompareString(text, "", False) <> 0 Then
									Exit For
								End If
								num8 += 500
								If num8 > 19000 Then
									Exit For
								End If
								Continue For
								Block_35:
								text = text5
								flag = True
								GoTo IL_6FA
							End While
						End If
					End If
				End If
				If Operators.CompareString(text, "", False) = 0 Then
					RSWIN_DESC.bBatchGuruPUManufFound(iManuf) = False
				Else
					RSWIN_DESC.bBatchGuruPUManufFound(iManuf) = True
				End If
				If flag Then
					result = text
				Else
					result = ""
				End If
			Catch ex As Exception
			End Try
			Return result
		End Function

		Private Sub MergeGURUInputs(iRun As Integer, ByRef bStopRun As Boolean)
			Try
				Dim flag As Boolean = False
				Dim sDefaultName As String = "SteelSuckerRodLength"
				Dim value As Object = DBNull.Value
				Dim flag2 As Boolean = False
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(ini.GetDefault(sDefaultName, value, flag2))
				RSWIN_DESC.SETUP_SteelSuckerRodLength = Conversions.ToSingle(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)), 25, RuntimeHelpers.GetObjectValue(objectValue)))
				RSWIN_DESC.bUsingGeneralList = False
				RSWIN_DESC.bUsingClosestUnit = False
				RSWIN_DESC.bUsingMatchedUnit = False
				RSWIN_DESC.sRecommendedUnit = ""
				bStopRun = False
				Dim cRODSTAR As cRODSTAR = RSWIN_DESC.rst_save
				RSWIN_DESC.rst.CalcMotorSPV = cRODSTAR.CalcMotorSPV
				RSWIN_DESC.rst.CasingPressure = cRODSTAR.CasingPressure
				RSWIN_DESC.rst.ACompanyName = cRODSTAR.ACompanyName
				Try
					Dim singleDefault As Single = ini.GetSingleDefault("ElectricityCost", VariantType.[Single])
					If singleDefault > 0F Then
						RSWIN_DESC.rst.ElectricityCost = singleDefault
					End If
				Catch ex As Exception
				End Try
				Try
					If(RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru) AndAlso (Not RSWIN_DESC.SETUP_UseXRODVTubingSizes And RSWIN_DESC.MaxTubingSizeOD <> 0F) Then
						If Not RSWIN_DESC.SETUP_FixTubingSize And cRODSTAR.TubingOD > RSWIN_DESC.MaxTubingSizeOD Then
							cRODSTAR.TubingOD = RSWIN_DESC.MaxTubingSizeOD
							cRODSTAR.TubingID = RODUTIL.GetMaxTubingSizeID(cRODSTAR.TubingOD)
						ElseIf RSWIN_DESC.SETUP_FixTubingSize And cRODSTAR.TubingOD <> RSWIN_DESC.MaxTubingSizeOD Then
							cRODSTAR.TubingOD = RSWIN_DESC.MaxTubingSizeOD
							cRODSTAR.TubingID = RODUTIL.GetMaxTubingSizeID(cRODSTAR.TubingOD)
						End If
						Dim maxCasingSize As Single = RSWIN_DESC.MaxCasingSize
						Dim maxTubingSizeOD As Single = RSWIN_DESC.MaxTubingSizeOD
						Dim num As Single
						Dim num2 As Single
						Dim num3 As Single
						RODUTIL.GetSizeFromCasingSize(maxCasingSize, maxTubingSizeOD, num, num2, num3, False)
						RSWIN_DESC.MaxTubingSizeOD = maxTubingSizeOD
						If cRODSTAR.RSMaxSize > num Then
							cRODSTAR.RSMaxSize = num
						End If
						If cRODSTAR.RSMinSize > num Then
							cRODSTAR.RSMinSize = num
						End If
						If cRODSTAR.PlungerSize > num2 And num2 <> 0F Then
							cRODSTAR.PlungerSize = num2
						End If
						If cRODSTAR.SinkerBar.Diameter > num3 Then
							Dim sinkerBar As RSWIN_DESC.RodSection
							sinkerBar.Initialize()
							sinkerBar = cRODSTAR.SinkerBar
							sinkerBar.Diameter = num3
							cRODSTAR.SinkerBar = sinkerBar
						End If
					End If
				Catch ex2 As Exception
				End Try
				Try
					If cRODSTAR.CoverPageComment IsNot Nothing AndAlso Operators.CompareString(cRODSTAR.CoverPageComment.Trim(), "", False) <> 0 Then
						RSWIN_DESC.rst.CoverPageComment = cRODSTAR.CoverPageComment
					End If
				Catch ex3 As Exception
				End Try
				Dim text As String = "IncludeMotorSPV"
				flag2 = False
				RSWIN_DESC.SETUP_IncludeMotorSPV = RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_PREFERENCES, text, flag2)
				RSWIN_DESC.rst.CalcMotorSPV = If((-If((RSWIN_DESC.SETUP_IncludeMotorSPV > False), 1S, 0S)), 1S, 0S)
				If RSWIN_DESC.SETUP_IncludeMotorSPV Then
					RSWIN_DESC.rst.CalcMotorSPV = -1S
					RSWIN_DESC.rst.IrotEntered = 0S
					RSWIN_DESC.rst.MotorSPV = 0F
				Else
					RSWIN_DESC.rst.CalcMotorSPV = 0S
					RSWIN_DESC.rst.IrotEntered = -1S
					RSWIN_DESC.rst.MotorSPV = 0F
				End If
				RSWIN_DESC.rst.FileComment = cRODSTAR.FileComment
				RSWIN_DESC.rst.FluidSPGR = cRODSTAR.FluidSPGR
				RSWIN_DESC.rst.OilAPI = cRODSTAR.OilAPI
				RSWIN_DESC.rst.OilSPGR = cRODSTAR.OilSPGR
				Dim objectValue2 As Object = RuntimeHelpers.GetObjectValue(ini.GetPreferenceDataValue("PowerMeterType", 3, DBNull.Value))
				If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue2)) Then
					RSWIN_DESC.SETUP_PowerMeterType = Conversions.ToShort(objectValue2)
					RSWIN_DESC.rst.PowerMeterType = RSWIN_DESC.SETUP_PowerMeterType
				End If
				RSWIN_DESC.rst.PumpDepth = cRODSTAR.PumpDepth
				RSWIN_DESC.rst.gbCalcFluidSPGR = cRODSTAR.gbCalcFluidSPGR
				RSWIN_DESC.rst.FluidLevel = RSWIN_DESC.rst.PumpDepth
				RSWIN_DESC.rst.TubingAnchorDepth = RSWIN_DESC.rst.PumpDepth
				Try
					If RSWIN_DESC.rst.PumpEfficiency <= 0F Then
						RSWIN_DESC.rst.PumpEfficiency = cRODSTAR.PumpEfficiency
					End If
				Catch ex4 As Exception
				End Try
				RSWIN_DESC.rst.PumpLoadAdj = cRODSTAR.PumpLoadAdj
				RSWIN_DESC.rst.Runtime = cRODSTAR.Runtime
				If CDbl(RSWIN_DESC.SETUP_ServiceFactorPreference) >= 0.75 Then
					RSWIN_DESC.rst.ServiceFactor = RSWIN_DESC.SETUP_ServiceFactorPreference
				End If
				If RSWIN_DESC.SETUP_ElectricityCostPreference > 0F Then
					RSWIN_DESC.rst.ElectricityCost = RSWIN_DESC.SETUP_ElectricityCostPreference
				End If
				RSWIN_DESC.rst.SPMEntered = 0S
				RSWIN_DESC.rst.StuffingBoxFriction = cRODSTAR.StuffingBoxFriction
				RSWIN_DESC.rst.TargetBFPD = cRODSTAR.TargetBFPD
				RSWIN_DESC.rst.TubingPressure = cRODSTAR.TubingPressure
				RSWIN_DESC.rst.UserDate = cRODSTAR.UserDate
				RSWIN_DESC.rst.UserName = cRODSTAR.UserName
				RSWIN_DESC.rst.WaterCut = cRODSTAR.WaterCut
				RSWIN_DESC.rst.WaterSPGR = cRODSTAR.WaterSPGR
				If RSWIN_DESC.rst.WaterSPGR < 1F Then
					RSWIN_DESC.rst.WaterSPGR = 1F
				ElseIf CDbl(RSWIN_DESC.rst.WaterSPGR) > 1.5 Then
					RSWIN_DESC.rst.WaterSPGR = 1.5F
				End If
				RSWIN_DESC.rst.WellName = cRODSTAR.WellName
				RSWIN_DESC.rst.gbCalcFluidSPGR = cRODSTAR.gbCalcFluidSPGR
				RSWIN_DESC.rst.gfMaxFluidSPGR = cRODSTAR.gfMaxFluidSPGR
				RSWIN_DESC.rst.FluidSPGR = cRODSTAR.FluidSPGR
				RSWIN_DESC.rst.gbUseIPR = cRODSTAR.gbUseIPR
				RSWIN_DESC.rst.gbCalcTargetBFPD = cRODSTAR.gbCalcTargetBFPD
				If RSWIN_DESC.rst.gbUseIPR Then
					RSWIN_DESC.rst.BubblePoint = cRODSTAR.BubblePoint
					RSWIN_DESC.rst.gbCalcFetkovichN = cRODSTAR.gbCalcFetkovichN
					RSWIN_DESC.rst.gbProducingBelowBPP = cRODSTAR.gbProducingBelowBPP
					RSWIN_DESC.rst.giIPRMethod = cRODSTAR.giIPRMethod
					RSWIN_DESC.rst.MidPerfDepth = cRODSTAR.MidPerfDepth
					RSWIN_DESC.rst.StaticBHPressure = cRODSTAR.StaticBHPressure
					RSWIN_DESC.rst.gnTestPoints = cRODSTAR.gnTestPoints
					Dim testPoints As RSWIN_DESC.IPRTESTPOINT() = New RSWIN_DESC.IPRTESTPOINT(CInt((RSWIN_DESC.rst.gnTestPoints + 1S)) - 1) {}
					RSWIN_DESC.rst.TestPoints = testPoints
					Dim num4 As Integer = 1
					Dim gnTestPoints As Integer = CInt(RSWIN_DESC.rst.gnTestPoints)
					For i As Integer = num4 To gnTestPoints
						RSWIN_DESC.rst.TestPoints(i).Production = cRODSTAR.TestPoints(i).Production
						RSWIN_DESC.rst.TestPoints(i).bPIEntered = cRODSTAR.TestPoints(i).bPIEntered
						If cRODSTAR.TestPoints(i).bPIEntered <> 0S Then
							RSWIN_DESC.rst.TestPoints(i).Pintake = cRODSTAR.TestPoints(i).Pintake
						Else
							RSWIN_DESC.rst.TestPoints(i).Pwf = cRODSTAR.TestPoints(i).Pwf
						End If
					Next
				End If
				If cRODSTAR.gbUseIPR And cRODSTAR.gbCalcTargetBFPD Then
					Dim num5 As Single
					Dim flag3 As Boolean = IPR.CheckIPR_AI(num5, cRODSTAR.gbCalcTargetBFPD)
					If flag3 And num5 <> -1F Then
						RSWIN_DESC.rst.TargetBFPD = num5
						RSWIN_DESC.rst.gbCalcTargetBFPD = False
					End If
				End If
				RSWIN_DESC.rst.Runtime = cRODSTAR.Runtime
				RSWIN_DESC.rst.RDNtsteps = 0S
				Dim array As Single() = New Single(0) {}
				RSWIN_DESC.rst.RDSurfLoad = array
				array = New Single(0) {}
				RSWIN_DESC.rst.RDSurfPos = array
				RSWIN_DESC.rst.gbRoddiagFile = False
				RSWIN_DESC.rst.miMotorKind = cRODSTAR.miMotorKind
				RSWIN_DESC.rst.CalcMotorSize = -1S
				Application.DoEvents()
				Dim crankHole As Integer = CInt(RSWIN_DESC.rst.PU.CrankHole)
				Dim crankRotation As Integer = CInt(RSWIN_DESC.rst.PU.CrankRotation)
				Dim unitID As String = RSWIN_DESC.rst.UnitID
				Dim pu As RSWIN_DESC.PUDataRec = RSWIN_DESC.rst.PU
				Application.DoEvents()
				PUDATA1.SetGuruPumpingUnit(RSWIN_DESC.sBatchGuruPUManufPreferences(iRun))
				Application.DoEvents()
				If RSWIN_DESC.bExpert And RSWIN_DESC.bRunGuru And RSWIN_DESC.bXRODAdmin And RSWIN_DESC.SETUP_bAdminDebug Then
					flag = True
					Batch.BatchMessage(String.Concat(New String() { "> Matched unit ", RSWIN_DESC.rst.UnitID, " (", Conversions.ToString(RSWIN_DESC.rst.PU.GearboxRating), "-", Conversions.ToString(RSWIN_DESC.rst.PU.StructRating), "-", Conversions.ToString(RSWIN_DESC.rst.PU.MaxStroke) }))
				End If
				Application.DoEvents()
				If RSWIN_DESC.bXRODUseCustomizedLists Then
					Dim flag4 As Boolean = PUDATA1.IsInCustomizedPUList(RSWIN_DESC.rst.UnitID)
					If flag4 Then
						RSWIN_DESC.sRecommendedUnit = String.Concat(New String() { "(", Conversions.ToString(RSWIN_DESC.rst.PU.GearboxRating), "-", Conversions.ToString(RSWIN_DESC.rst.PU.StructRating), "-", Conversions.ToString(RSWIN_DESC.rst.PU.MaxStroke), ")" })
						If flag Then
							Batch.BatchMessage("> Matched unit is in customized pumping unit list ... using unit")
						End If
						RSWIN_DESC.bUsingMatchedUnit = True
					Else
						If Not RSWIN_DESC.bXRODUseClosestUnit And Not RSWIN_DESC.bXRODUseGeneralList And Not flag4 Then
							bStopRun = True
							Return
						End If
						If flag Then
							Batch.BatchMessage("> Matched unit not in customized pumping unit list ... searching for closest match.")
						End If
						If PUDATA1.MatchClosestToCustomizedList() Then
							If flag Then
								Batch.BatchMessage(String.Concat(New String() { "> Using closest unit found ", RSWIN_DESC.rst.UnitID, " (", Conversions.ToString(RSWIN_DESC.rst.PU.GearboxRating), "-", Conversions.ToString(RSWIN_DESC.rst.PU.StructRating), "-", Conversions.ToString(RSWIN_DESC.rst.PU.MaxStroke), ")" }))
							End If
						Else
							RSWIN_DESC.rst.PU = pu
							RSWIN_DESC.rst.UnitID = unitID
							Application.DoEvents()
							PUDATA1.SetGuruPumpingUnit(RSWIN_DESC.sBatchGuruPUManufPreferences(iRun))
							Application.DoEvents()
							If flag Then
								Batch.BatchMessage(String.Concat(New String() { "> Reverting to ", RSWIN_DESC.rst.UnitID, " (", Conversions.ToString(RSWIN_DESC.rst.PU.GearboxRating), "-", Conversions.ToString(RSWIN_DESC.rst.PU.StructRating), "-", Conversions.ToString(RSWIN_DESC.rst.PU.MaxStroke), ")" }))
							End If
							Batch.BatchMessage("The selected pumping unit is from the general list because recommended unit size " + RSWIN_DESC.sRecommendedUnit + " does not exist in the customized list.")
						End If
					End If
				End If
				Application.DoEvents()
				Select Case RSWIN_DESC.rst.RodStringType
					Case 1S, 2S, 4S
						RSWIN_DESC.rst.RodStringType = 3S
						If RSWIN_DESC.SETUP_bUseSteelRodsOnly Then
							RSWIN_DESC.rst.giRodDesignStyle = 0S
						ElseIf RSWIN_DESC.SETUP_bUseFGlassWithSteelOnBottom Then
							RSWIN_DESC.rst.giRodDesignStyle = 1S
						End If
				End Select
				Me.SetGuruRodPreferences(False)
				RSWIN_DESC.rst.CalcFriction = -1S
				If RSWIN_DESC.SETUP_IncludeMotorSPV Then
					If RSWIN_DESC.rst.PU.UnitType = 5S Or RSWIN_DESC.rst.PU.UnitType = 1S Or RSWIN_DESC.rst.PU.UnitType = 9S Then
						MImpred.EstimateRotatingInertia()
					Else
						RSWIN_DESC.rst.CalcMotorSPV = 0S
						RSWIN_DESC.rst.IrotEntered = -1S
						RSWIN_DESC.rst.MotorSPV = 0F
					End If
				End If
				If RSWIN_DESC.rst.PU.UnitType = 8S Or RSWIN_DESC.bBeamBalanced Then
					RSWIN_DESC.rst.bUnknownUnbalance = True
				End If
				cRODSTAR = Nothing
			Catch ex5 As Exception
			End Try
		End Sub

		Public Sub SaveRSObject()
			' The following expression was wrapped in a checked-statement
			Try
				Dim cRODSTAR As cRODSTAR = RSWIN_DESC.rst_save
				Try
					cRODSTAR.Inputfile = RSWIN_DESC.rst.Inputfile
				Catch ex As Exception
				End Try
				cRODSTAR.CalcFriction = RSWIN_DESC.rst.CalcFriction
				cRODSTAR.CalcMotorSize = RSWIN_DESC.rst.CalcMotorSize
				cRODSTAR.CalcMotorSPV = RSWIN_DESC.rst.CalcMotorSPV
				cRODSTAR.CalcPlungerSize = RSWIN_DESC.rst.CalcPlungerSize
				cRODSTAR.CasingPressure = RSWIN_DESC.rst.CasingPressure
				cRODSTAR.CBDataFile = RSWIN_DESC.rst.CBDataFile
				cRODSTAR.ACompanyName = RSWIN_DESC.rst.ACompanyName
				cRODSTAR.CompressibilityIndex = RSWIN_DESC.rst.CompressibilityIndex
				cRODSTAR.DownstrokeFriction = RSWIN_DESC.rst.DownstrokeFriction
				cRODSTAR.DownstrokeFriction = RSWIN_DESC.rst.DownstrokeFriction
				cRODSTAR.ElectricityCost = RSWIN_DESC.rst.ElectricityCost
				cRODSTAR.FileComment = RSWIN_DESC.rst.FileComment
				Try
					cRODSTAR.CoverPageComment = RSWIN_DESC.rst.CoverPageComment
				Catch ex2 As Exception
				End Try
				cRODSTAR.FluidDamping = RSWIN_DESC.rst.FluidDamping
				cRODSTAR.FluidLevel = RSWIN_DESC.rst.FluidLevel
				cRODSTAR.giFluidLevelSource = RSWIN_DESC.rst.giFluidLevelSource
				cRODSTAR.FluidLevelEntered = RSWIN_DESC.rst.FluidLevelEntered
				cRODSTAR.giFluidLevelSource = RSWIN_DESC.rst.giFluidLevelSource
				cRODSTAR.FluidSPGR = RSWIN_DESC.rst.FluidSPGR
				cRODSTAR.gbCalcPumpCondition = RSWIN_DESC.rst.gbCalcPumpCondition
				cRODSTAR.gbCalcPumpIntakePressure = RSWIN_DESC.rst.gbCalcPumpIntakePressure
				cRODSTAR.gbCalcTargetBFPD = RSWIN_DESC.rst.gbCalcTargetBFPD
				cRODSTAR.gbIncludeBuoyancy = RSWIN_DESC.rst.gbIncludeBuoyancy
				cRODSTAR.Iart = RSWIN_DESC.rst.Iart
				cRODSTAR.IncludeFluidInertia = RSWIN_DESC.rst.IncludeFluidInertia
				cRODSTAR.Irot = RSWIN_DESC.rst.Irot
				cRODSTAR.IrotEntered = RSWIN_DESC.rst.IrotEntered
				cRODSTAR.MotorSPV = RSWIN_DESC.rst.MotorSPV
				cRODSTAR.OilAPI = RSWIN_DESC.rst.OilAPI
				cRODSTAR.OilSPGR = RSWIN_DESC.rst.OilSPGR
				cRODSTAR.PlungerSize = RSWIN_DESC.rst.PlungerSize
				cRODSTAR.PowerMeterType = RSWIN_DESC.rst.PowerMeterType
				cRODSTAR.PumpCondition = RSWIN_DESC.rst.PumpCondition
				cRODSTAR.PumpDragDownstrokeMax = RSWIN_DESC.rst.PumpDragDownstrokeMax
				cRODSTAR.PumpDragUpstrokeMax = RSWIN_DESC.rst.PumpDragUpstrokeMax
				cRODSTAR.PumpDepth = RSWIN_DESC.rst.PumpDepth
				cRODSTAR.gbCalcFluidSPGR = RSWIN_DESC.rst.gbCalcFluidSPGR
				cRODSTAR.IntermediateDepth = RSWIN_DESC.rst.IntermediateDepth
				cRODSTAR.PumpEfficiency = RSWIN_DESC.rst.PumpEfficiency
				cRODSTAR.PumpFillage = RSWIN_DESC.rst.PumpFillage
				cRODSTAR.PumpFriction = RSWIN_DESC.rst.PumpFriction
				cRODSTAR.PumpIntakePressure = RSWIN_DESC.rst.PumpIntakePressure
				cRODSTAR.UPumpIntakePressure = RSWIN_DESC.rst.PumpIntakePressure
				cRODSTAR.PumpLoadAdj = RSWIN_DESC.rst.PumpLoadAdj
				cRODSTAR.PumpType = RSWIN_DESC.rst.PumpType
				cRODSTAR.RSExtraCost = RSWIN_DESC.rst.RSExtraCost
				cRODSTAR.RSExtraCostLabel = RSWIN_DESC.rst.RSExtraCostLabel
				cRODSTAR.Runtime = RSWIN_DESC.rst.Runtime
				cRODSTAR.ServiceFactor = RSWIN_DESC.rst.ServiceFactor
				cRODSTAR.SPM = RSWIN_DESC.rst.SPM
				cRODSTAR.SPMEntered = 0S
				cRODSTAR.StuffingBoxFriction = RSWIN_DESC.rst.StuffingBoxFriction
				cRODSTAR.TargetBFPD = RSWIN_DESC.rst.TargetBFPD
				cRODSTAR.TubingAnchorDepth = RSWIN_DESC.rst.TubingAnchorDepth
				cRODSTAR.TubingAnchored = RSWIN_DESC.rst.TubingAnchored
				cRODSTAR.TubingID = RSWIN_DESC.rst.TubingID
				cRODSTAR.TubingOD = RSWIN_DESC.rst.TubingOD
				cRODSTAR.TubingPressure = RSWIN_DESC.rst.TubingPressure
				cRODSTAR.UpstrokeFriction = RSWIN_DESC.rst.UpstrokeFriction
				cRODSTAR.SlideFricCoeff = RSWIN_DESC.rst.SlideFricCoeff
				cRODSTAR.UserDate = RSWIN_DESC.rst.UserDate
				cRODSTAR.UserName = RSWIN_DESC.rst.UserName
				cRODSTAR.WaterCut = RSWIN_DESC.rst.WaterCut
				cRODSTAR.WaterSPGR = RSWIN_DESC.rst.WaterSPGR
				cRODSTAR.WellName = RSWIN_DESC.rst.WellName
				cRODSTAR.bDeviated = RSWIN_DESC.rst.bDeviated
				cRODSTAR.gbCalcFluidSPGR = RSWIN_DESC.rst.gbCalcFluidSPGR
				cRODSTAR.gfMaxFluidSPGR = RSWIN_DESC.rst.gfMaxFluidSPGR
				cRODSTAR.FluidSPGR = RSWIN_DESC.rst.FluidSPGR
				cRODSTAR.gbUseIPR = RSWIN_DESC.rst.gbUseIPR
				cRODSTAR.giFluidLevelSource = RSWIN_DESC.rst.giFluidLevelSource
				cRODSTAR.BubblePoint = RSWIN_DESC.rst.BubblePoint
				cRODSTAR.gbCalcFetkovichN = RSWIN_DESC.rst.gbCalcFetkovichN
				cRODSTAR.gbProducingBelowBPP = RSWIN_DESC.rst.gbProducingBelowBPP
				cRODSTAR.giIPRMethod = RSWIN_DESC.rst.giIPRMethod
				cRODSTAR.MidPerfDepth = RSWIN_DESC.rst.MidPerfDepth
				cRODSTAR.StaticBHPressure = RSWIN_DESC.rst.StaticBHPressure
				cRODSTAR.gnTestPoints = RSWIN_DESC.rst.gnTestPoints
				Dim testPoints As RSWIN_DESC.IPRTESTPOINT() = New RSWIN_DESC.IPRTESTPOINT(CInt((cRODSTAR.gnTestPoints + 1S)) - 1) {}
				cRODSTAR.TestPoints = testPoints
				Dim num As Integer = 1
				Dim gnTestPoints As Integer = CInt(cRODSTAR.gnTestPoints)
				For i As Integer = num To gnTestPoints
					cRODSTAR.TestPoints(i).Production = RSWIN_DESC.rst.TestPoints(i).Production
					cRODSTAR.TestPoints(i).bPIEntered = RSWIN_DESC.rst.TestPoints(i).bPIEntered
					If cRODSTAR.TestPoints(i).bPIEntered <> 0S Then
						cRODSTAR.TestPoints(i).Pintake = RSWIN_DESC.rst.TestPoints(i).Pintake
					Else
						cRODSTAR.TestPoints(i).Pwf = RSWIN_DESC.rst.TestPoints(i).Pwf
					End If
				Next
				cRODSTAR.MotorSPV = RSWIN_DESC.rst.MotorSPV
				cRODSTAR.miMotorKind = RSWIN_DESC.rst.miMotorKind
				cRODSTAR.CalcMotorSize = RSWIN_DESC.rst.CalcMotorSize
				cRODSTAR = Nothing
			Catch ex3 As Exception
			End Try
		End Sub

		Public Function GetManufUnitType(sManuf As String) As Short
			Dim result As Short
			Try
				Dim fileName As String
				FILEUTIL.LocateFile("UNITINFO32.PUD", fileName, 2S, False, False, False, False)
				Dim num6 As Short
				Dim num7 As Short
				Dim num As Short = CShort(FileSystem.FreeFile())
				FileSystem.FileOpen(CInt(num), fileName, OpenMode.Binary, OpenAccess.Read, OpenShare.[Shared], -1)
				Dim unitTypeInfo As RSWIN_DESC.UnitTypeInfo
				Dim num2 As Short = CShort((FileSystem.LOF(CInt(num)) / CLng(Strings.Len(unitTypeInfo))))
				Me.tmpUnitTypeInfoList = New RSWIN_DESC.UnitTypeInfo(CInt((num2 + 1S)) - 1) {}
				Me.nUnitTypes = 0
				Dim num3 As Short = 1S
				Dim num4 As Short = num2
				For num5 As Short = num3 To num4
					Dim fileNumber As Integer = CInt(num)
					Dim valueType As ValueType = unitTypeInfo
					FileSystem.FileGet(fileNumber, valueType, -1L)
					Dim valueType2 As ValueType = valueType
					Dim unitTypeInfo2 As RSWIN_DESC.UnitTypeInfo
					unitTypeInfo = If((valueType2 IsNot Nothing), CType(valueType2, RSWIN_DESC.UnitTypeInfo), unitTypeInfo2)
					Dim expression As String = Strings.Trim(unitTypeInfo.Abbrev)
					If Strings.Len(expression) > 0 Then
						Me.nUnitTypes += 1
						Me.tmpUnitTypeInfoList(Me.nUnitTypes) = unitTypeInfo
					End If
				Next
				FileSystem.FileClose(New Integer() { CInt(num) })
				Me.tmpUnitTypeInfoList = CType(Utils.CopyArray(CType(Me.tmpUnitTypeInfoList, Array), New RSWIN_DESC.UnitTypeInfo(Me.nUnitTypes + 1 - 1) {}), RSWIN_DESC.UnitTypeInfo())
				num6 = 1S
				num7 = CShort(Me.nUnitTypes)
				Dim unitType As Integer
				For num5 As Short = num6 To num7
					If Operators.CompareString(sManuf.Trim(), Me.tmpUnitTypeInfoList(CInt(num5)).Manuf.Trim(), False) = 0 Then
						unitType = CInt(Me.tmpUnitTypeInfoList(CInt(num5)).UnitType)
						Exit For
					End If
				Next
				result = CShort(unitType)
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Sub GuruBatchRunFiles(ByRef iFileCount As Integer)
			Dim num As Integer = -1
			Dim text As String = ""
			Dim num2 As Integer = 0
			Try
				RSWIN_DESC.mrgBatchFileList = New String(0) {}
				RSWIN_DESC.sBatchGuruPUManufPreferences = New String(0) {}
				RSWIN_DESC.sAI_DBKeys = New String(0) {}
				RSWIN_DESC.sAI_DBPrefixes = New String(0) {}
				Dim text2 As String = ""
				Dim num3 As Integer = -1
				Me.sAlreadyFileList = New String(0) {}
				If(RSWIN_DESC.SETUP_bUseFGlassWithSteelOnBottom And Not RSWIN_DESC.SETUP_bUseSteelRodsOnly) Or (Not RSWIN_DESC.SETUP_bUseFGlassWithSteelOnBottom And RSWIN_DESC.SETUP_bUseSteelRodsOnly) Then
					Dim num4 As Integer = 1
					Do
						If RSWIN_DESC.get_bUsePUManuf(num4) And Not Me.IsAlreadyInList(num4, False) Then
							text2 = ""
							Dim pumpDepth As Single = RSWIN_DESC.rst.PumpDepth
							Dim targetBFPD As Single = RSWIN_DESC.rst.TargetBFPD
							Dim pumanuf As String = RSWIN_DESC.get_PUManuf(num4)
							Dim iManuf As Integer = num4
							Dim bUsePUUnitType As Boolean = False
							Dim text3 As String = ""
							Dim guruFileName As String = Me.GetGuruFileName(pumpDepth, targetBFPD, pumanuf, iManuf, text2, bUsePUUnitType, text3, True)
							If Operators.CompareString(guruFileName, "", False) <> 0 Then
								num3 += 1
								Me.sAlreadyFileList = CType(Utils.CopyArray(CType(Me.sAlreadyFileList, Array), New String(num3 + 1 - 1) {}), String())
								Me.sAlreadyFileList(num3) = RSWIN_DESC.get_PUManuf(num4)
								If Me.GetManufUnitType(RSWIN_DESC.get_PUManuf(num4)) = 1S Or Me.GetManufUnitType(RSWIN_DESC.get_PUManuf(num4)) = 8S Or Me.GetManufUnitType(RSWIN_DESC.get_PUManuf(num4)) = 9S Then
									num2 += 1
								End If
								num += 1
								RSWIN_DESC.mrgBatchFileList = CType(Utils.CopyArray(CType(RSWIN_DESC.mrgBatchFileList, Array), New String(num + 1 - 1) {}), String())
								RSWIN_DESC.sBatchGuruPUManufPreferences = CType(Utils.CopyArray(CType(RSWIN_DESC.sBatchGuruPUManufPreferences, Array), New String(num + 1 - 1) {}), String())
								RSWIN_DESC.sAI_DBKeys = CType(Utils.CopyArray(CType(RSWIN_DESC.sAI_DBKeys, Array), New String(num + 1 - 1) {}), String())
								RSWIN_DESC.sAI_DBPrefixes = CType(Utils.CopyArray(CType(RSWIN_DESC.sAI_DBPrefixes, Array), New String(num + 1 - 1) {}), String())
								Dim fileInfo As FileInfo = New FileInfo(guruFileName)
								text = String.Concat(New String() { RSWIN_DESC.SETUP_GURUTEMPDIR, "AI_RUN_", num4.ToString().Trim(), "_(", RSWIN_DESC.rst_save.WellName.Trim(), ").rsvx" })
								If FILEUTIL.FileExists(text) Then
									FileSystem.Kill(text)
								End If
								fileInfo.CopyTo(text)
								RSWIN_DESC.mrgBatchFileList(num) = text
								RSWIN_DESC.sBatchGuruPUManufPreferences(num) = RSWIN_DESC.get_PUManuf(num4)
								RSWIN_DESC.sAI_DBKeys(num) = guruFileName
								RSWIN_DESC.sAI_DBPrefixes(num) = text2
							End If
						End If
						num4 += 1
					Loop While num4 <= 8
				ElseIf RSWIN_DESC.SETUP_bUseFGlassWithSteelOnBottom And RSWIN_DESC.SETUP_bUseSteelRodsOnly Then
					Dim num5 As Integer = 1
					Do
						If num5 = 1 Then
							RSWIN_DESC.SETUP_bUseFGlassWithSteelOnBottom = False
							RSWIN_DESC.SETUP_bUseSteelRodsOnly = True
						Else
							RSWIN_DESC.SETUP_bUseFGlassWithSteelOnBottom = True
							RSWIN_DESC.SETUP_bUseSteelRodsOnly = False
						End If
						Dim num4 As Integer = 1
						Do
							If RSWIN_DESC.get_bUsePUManuf(num4) Then
								text2 = ""
								Dim pumpDepth2 As Single = RSWIN_DESC.rst.PumpDepth
								Dim targetBFPD2 As Single = RSWIN_DESC.rst.TargetBFPD
								Dim pumanuf2 As String = RSWIN_DESC.get_PUManuf(num4)
								Dim iManuf2 As Integer = num4
								Dim bUsePUUnitType2 As Boolean = False
								Dim text3 As String = ""
								Dim guruFileName As String = Me.GetGuruFileName(pumpDepth2, targetBFPD2, pumanuf2, iManuf2, text2, bUsePUUnitType2, text3, True)
								If Operators.CompareString(guruFileName, "", False) <> 0 Then
									num3 += 1
									Me.sAlreadyFileList = CType(Utils.CopyArray(CType(Me.sAlreadyFileList, Array), New String(num3 + 1 - 1) {}), String())
									Me.sAlreadyFileList(num3) = RSWIN_DESC.get_PUManuf(num4)
									If Me.GetManufUnitType(RSWIN_DESC.get_PUManuf(num4)) = 1S Or Me.GetManufUnitType(RSWIN_DESC.get_PUManuf(num4)) = 8S Or Me.GetManufUnitType(RSWIN_DESC.get_PUManuf(num4)) = 9S Then
										num2 += 1
									End If
									num += 1
									RSWIN_DESC.mrgBatchFileList = CType(Utils.CopyArray(CType(RSWIN_DESC.mrgBatchFileList, Array), New String(num + 1 - 1) {}), String())
									RSWIN_DESC.sBatchGuruPUManufPreferences = CType(Utils.CopyArray(CType(RSWIN_DESC.sBatchGuruPUManufPreferences, Array), New String(num + 1 - 1) {}), String())
									RSWIN_DESC.sAI_DBKeys = CType(Utils.CopyArray(CType(RSWIN_DESC.sAI_DBKeys, Array), New String(num + 1 - 1) {}), String())
									RSWIN_DESC.sAI_DBPrefixes = CType(Utils.CopyArray(CType(RSWIN_DESC.sAI_DBPrefixes, Array), New String(num + 1 - 1) {}), String())
									Dim fileInfo2 As FileInfo = New FileInfo(guruFileName)
									text = String.Concat(New String() { RSWIN_DESC.SETUP_GURUTEMPDIR, "AI_RUN_", (num + 1).ToString().Trim(), "_(", RSWIN_DESC.rst_save.WellName.Trim(), ").rsvx" })
									If FILEUTIL.FileExists(text) Then
										FileSystem.Kill(text)
									End If
									fileInfo2.CopyTo(text)
									RSWIN_DESC.mrgBatchFileList(num) = text
									RSWIN_DESC.sBatchGuruPUManufPreferences(num) = RSWIN_DESC.get_PUManuf(num4)
									RSWIN_DESC.sAI_DBKeys(num) = guruFileName
									RSWIN_DESC.sAI_DBPrefixes(num) = text2
								End If
							End If
							num4 += 1
						Loop While num4 <= 8
						num5 += 1
					Loop While num5 <= 2
					RSWIN_DESC.SETUP_bUseFGlassWithSteelOnBottom = True
					RSWIN_DESC.SETUP_bUseSteelRodsOnly = True
				End If
				RSWIN_DESC.miBatchCurFile = 0
				iFileCount = num + 1
			Catch ex As Exception
			End Try
		End Sub

		Public Function GuruBatchRunFilesFromDatabase(ByRef iFileCount As Integer) As Boolean
			Dim num As Integer = -1
			Dim text As String = ""
			Dim num2 As Integer = 0
			Dim flag As Boolean = False
			Dim result As Boolean
			Try
				RSWIN_DESC.mrgBatchFileList = New String(0) {}
				RSWIN_DESC.sBatchGuruPUManufPreferences = New String(0) {}
				RSWIN_DESC.sAI_DBKeys = New String(0) {}
				RSWIN_DESC.sAI_DBPrefixes = New String(0) {}
				Dim num3 As Integer = -1
				Dim text2 As String = ""
				Me.sAlreadyFileList = New String(num3 + 1 - 1) {}
				Dim now As DateTime = DateAndTime.Now
				If(RSWIN_DESC.SETUP_bUseFGlassWithSteelOnBottom And Not RSWIN_DESC.SETUP_bUseSteelRodsOnly) Or (Not RSWIN_DESC.SETUP_bUseFGlassWithSteelOnBottom And RSWIN_DESC.SETUP_bUseSteelRodsOnly) Then
					Dim num4 As Integer = 1
					Do
						If RSWIN_DESC.get_bUsePUManuf(num4) And Not Me.IsAlreadyInList(num4, False) Then
							text2 = ""
							Dim guruDBFileName As String = Me.GetGuruDBFileName(RSWIN_DESC.rst_save.PumpDepth, RSWIN_DESC.rst_save.TargetBFPD, RSWIN_DESC.get_PUManuf(num4), num4, text2)
							If Operators.CompareString(guruDBFileName, "", False) <> 0 Then
								flag = True
								num3 += 1
								Me.sAlreadyFileList = CType(Utils.CopyArray(CType(Me.sAlreadyFileList, Array), New String(num3 + 1 - 1) {}), String())
								Me.sAlreadyFileList(num3) = RSWIN_DESC.get_PUManuf(num4)
								If Me.GetManufUnitType(RSWIN_DESC.get_PUManuf(num4)) = 1S Or Me.GetManufUnitType(RSWIN_DESC.get_PUManuf(num4)) = 8S Or Me.GetManufUnitType(RSWIN_DESC.get_PUManuf(num4)) = 9S Then
									num2 += 1
								End If
								num += 1
								RSWIN_DESC.mrgBatchFileList = CType(Utils.CopyArray(CType(RSWIN_DESC.mrgBatchFileList, Array), New String(num + 1 - 1) {}), String())
								RSWIN_DESC.sBatchGuruPUManufPreferences = CType(Utils.CopyArray(CType(RSWIN_DESC.sBatchGuruPUManufPreferences, Array), New String(num + 1 - 1) {}), String())
								RSWIN_DESC.sAI_DBKeys = CType(Utils.CopyArray(CType(RSWIN_DESC.sAI_DBKeys, Array), New String(num + 1 - 1) {}), String())
								RSWIN_DESC.sAI_DBPrefixes = CType(Utils.CopyArray(CType(RSWIN_DESC.sAI_DBPrefixes, Array), New String(num + 1 - 1) {}), String())
								Dim sGuruFilenameKey As String = guruDBFileName
								text = String.Concat(New String() { RSWIN_DESC.SETUP_GURUTEMPDIR, "AI_RUN_", num4.ToString().Trim(), "_(", RSWIN_DESC.rst_save.WellName.Trim(), ").rsvx" })
								If FILEUTIL.FileExists(text) Then
									FileSystem.Kill(text)
								End If
								Dim filenameNumber As Integer = Me.GetFilenameNumber(sGuruFilenameKey, RSWIN_DESC.get_PUManuf(num4), False)
								If filenameNumber <> -1 Then
									GURU_DB.CopyGuruFiledata2RSTObj(filenameNumber, False)
									RSWIN_DESC.sBatchGuruPUManufPreferences(num) = RSWIN_DESC.get_PUManuf(num4)
									RSWIN_DESC.mrgBatchFileList(num) = text
									Me.SAVEGURUBATCHFILE(text)
									RSWIN_DESC.sAI_DBKeys(num) = guruDBFileName
									RSWIN_DESC.sAI_DBPrefixes(num) = text2
								Else
									num -= 1
								End If
							End If
						End If
						num4 += 1
					Loop While num4 <= 8
				ElseIf RSWIN_DESC.SETUP_bUseFGlassWithSteelOnBottom And RSWIN_DESC.SETUP_bUseSteelRodsOnly Then
					Dim num5 As Integer = 1
					Do
						If num5 = 1 Then
							RSWIN_DESC.SETUP_bUseFGlassWithSteelOnBottom = False
							RSWIN_DESC.SETUP_bUseSteelRodsOnly = True
						Else
							RSWIN_DESC.SETUP_bUseFGlassWithSteelOnBottom = True
							RSWIN_DESC.SETUP_bUseSteelRodsOnly = False
						End If
						Dim num4 As Integer = 1
						Do
							If RSWIN_DESC.get_bUsePUManuf(num4) Then
								text2 = ""
								Dim guruDBFileName As String = Me.GetGuruDBFileName(RSWIN_DESC.rst_save.PumpDepth, RSWIN_DESC.rst_save.TargetBFPD, RSWIN_DESC.get_PUManuf(num4), num4, text2)
								If Operators.CompareString(guruDBFileName, "", False) <> 0 Then
									flag = True
									num3 += 1
									Me.sAlreadyFileList = CType(Utils.CopyArray(CType(Me.sAlreadyFileList, Array), New String(num3 + 1 - 1) {}), String())
									Me.sAlreadyFileList(num3) = RSWIN_DESC.get_PUManuf(num4)
									If Me.GetManufUnitType(RSWIN_DESC.get_PUManuf(num4)) = 1S Or Me.GetManufUnitType(RSWIN_DESC.get_PUManuf(num4)) = 8S Or Me.GetManufUnitType(RSWIN_DESC.get_PUManuf(num4)) = 9S Then
										num2 += 1
									End If
									num += 1
									RSWIN_DESC.mrgBatchFileList = CType(Utils.CopyArray(CType(RSWIN_DESC.mrgBatchFileList, Array), New String(num + 1 - 1) {}), String())
									RSWIN_DESC.sBatchGuruPUManufPreferences = CType(Utils.CopyArray(CType(RSWIN_DESC.sBatchGuruPUManufPreferences, Array), New String(num + 1 - 1) {}), String())
									RSWIN_DESC.sAI_DBKeys = CType(Utils.CopyArray(CType(RSWIN_DESC.sAI_DBKeys, Array), New String(num + 1 - 1) {}), String())
									RSWIN_DESC.sAI_DBPrefixes = CType(Utils.CopyArray(CType(RSWIN_DESC.sAI_DBPrefixes, Array), New String(num + 1 - 1) {}), String())
									Dim sGuruFilenameKey As String = guruDBFileName
									text = String.Concat(New String() { RSWIN_DESC.SETUP_GURUTEMPDIR, "AI_RUN_", (num + 1).ToString().Trim(), "_(", RSWIN_DESC.rst_save.WellName.Trim(), ").rsvx" })
									If FILEUTIL.FileExists(text) Then
										FileSystem.Kill(text)
									End If
									Dim filenameNumber As Integer = Me.GetFilenameNumber(sGuruFilenameKey, RSWIN_DESC.get_PUManuf(num4), False)
									If filenameNumber <> -1 Then
										GURU_DB.CopyGuruFiledata2RSTObj(filenameNumber, False)
										RSWIN_DESC.sBatchGuruPUManufPreferences(num) = RSWIN_DESC.get_PUManuf(num4)
										RSWIN_DESC.mrgBatchFileList(num) = text
										Me.SAVEGURUBATCHFILE(text)
										RSWIN_DESC.sAI_DBKeys(num) = guruDBFileName
										RSWIN_DESC.sAI_DBPrefixes(num) = text2
									Else
										num -= 1
									End If
								End If
							End If
							num4 += 1
						Loop While num4 <= 8
						num5 += 1
					Loop While num5 <= 2
					RSWIN_DESC.SETUP_bUseFGlassWithSteelOnBottom = True
					RSWIN_DESC.SETUP_bUseSteelRodsOnly = True
				End If
				Dim seconds As Integer = DateAndTime.Now.Subtract(now).Seconds
				RSWIN_DESC.miBatchCurFile = 0
				iFileCount = num + 1
				result = flag
			Catch ex As Exception
				result = flag
			End Try
			Return result
		End Function

		Public Function ReadGuruFile() As Boolean
			Dim result As Boolean
			Try
				Dim expression As String = ""
				Dim text As String = ""
				Dim flag As Boolean = False
				If RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru Then
					RSWIN_DESC.rst_save = New cRODSTAR()
					RSWIN_DESC.rst_save.SetClassDefaults(False)
					Me.SaveRSObject()
					Dim pumpDepth As Single = RSWIN_DESC.rst_save.PumpDepth
					Dim targetBFPD As Single = RSWIN_DESC.rst_save.TargetBFPD
					Dim pumanuf As String = RSWIN_DESC.get_PUManuf(1)
					Dim iManuf As Integer = 1
					Dim bUsePUUnitType As Boolean = False
					Dim text2 As String = ""
					expression = Me.GetGuruFileName(pumpDepth, targetBFPD, pumanuf, iManuf, text, bUsePUUnitType, text2, True)
					RSWIN_DESC.sBatchGuruPUManufPreferences = New String(1) {}
					RSWIN_DESC.sBatchGuruPUManufPreferences(0) = RSWIN_DESC.get_PUManuf(1)
					If Strings.Len(expression) > 0 Then
						Dim rst As cRODSTAR = RSWIN_DESC.rst
						Dim gbInputDataChanged As Boolean = rst.gbInputDataChanged
						Dim cursor As Cursor
						Dim flag2 As Boolean
						Me.LoadOneFile(cursor, expression, flag2, gbInputDataChanged, False)
						rst.gbInputDataChanged = gbInputDataChanged
						If flag2 Then
							Me.MergeGURUInputs(0, flag)
						Else
							RSWIN_DESC.rst = RSWIN_DESC.rst_save
						End If
						result = True
					Else
						If RSWIN_DESC.bOneGuruFile Then
							MessageBox.Show("The target production cannot be achieved with " + RSWIN_DESC.get_PUManuf(1) + "!")
						End If
						result = False
					End If
				End If
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Function ReadOneGuruTemplateFromDatabase(ByRef bStopRun As Boolean) As Boolean
			' The following expression was wrapped in a checked-statement
			Try
				Dim text As String = ""
				bStopRun = False
				If RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru Then
					RSWIN_DESC.rst_save = New cRODSTAR()
					RSWIN_DESC.rst_save.SetClassDefaults(False)
					Me.SaveRSObject()
					Dim iManuf As Integer = 1
					Dim text2 As String = RSWIN_DESC.get_PUManuf(1)
					Dim num As Integer = 1
					While Not RSWIN_DESC.get_bUsePUManuf(num)
						num += 1
						If num > 8 Then
							IL_74:
							Dim guruDBFileName As String = Me.GetGuruDBFileName(RSWIN_DESC.rst_save.PumpDepth, RSWIN_DESC.rst_save.TargetBFPD, text2, iManuf, text)
							RSWIN_DESC.sBatchGuruPUManufPreferences = New String(1) {}
							RSWIN_DESC.sBatchGuruPUManufPreferences(0) = text2
							If Strings.Len(guruDBFileName) <= 0 Then
								Return False
							End If
							Dim filenameNumber As Integer = Me.GetFilenameNumber(guruDBFileName, text2, False)
							If filenameNumber = -1 Then
								RSWIN_DESC.rst = RSWIN_DESC.rst_save
								Return False
							End If
							GURU_DB.CopyGuruFiledata2RSTObj(filenameNumber, False)
							Me.MergeGURUInputs(0, bStopRun)
							RSWIN_DESC.sAI_DBKeys = New String(0) {}
							RSWIN_DESC.sAI_DBPrefixes = New String(0) {}
							RSWIN_DESC.sAI_DBKeys(0) = guruDBFileName
							RSWIN_DESC.sAI_DBPrefixes(0) = text
							If bStopRun Then
								RSWIN_DESC.sRecommendedUnit = String.Concat(New String() { "(", Conversions.ToString(RSWIN_DESC.rst.PU.GearboxRating), "-", Conversions.ToString(RSWIN_DESC.rst.PU.StructRating), "-", Conversions.ToString(RSWIN_DESC.rst.PU.MaxStroke), ")" })
								MessageBox.Show("Required unit " + RSWIN_DESC.sRecommendedUnit + " not found in customized pumping unit list")
								Return False
							End If
							Return True
						End If
					End While
					iManuf = num
					text2 = RSWIN_DESC.get_PUManuf(num)
					GoTo IL_74
				End If
			Catch ex As Exception
			End Try
			Dim result As Boolean
			Return result
		End Function

		Private Sub SetGuruRodPreferences(Optional bOverride As Boolean = False)
			Dim rodType As String = New String(" "c, 20)
			Try
				Dim cRODSTAR As cRODSTAR = RSWIN_DESC.rst
				If cRODSTAR.RSGrade = 4098S Or cRODSTAR.RSGrade = 4099S Then
					Dim rsgrade As Short = 4099S
					Dim rsgrade2 As Short = 4098S
					Dim flag As Boolean = False
					If RODUTIL.IsCorod(RSWIN_DESC.HSGradeRod) Then
						Dim hsgradeRod As Short = RSWIN_DESC.HSGradeRod
						If hsgradeRod = 12547S OrElse hsgradeRod = 12549S OrElse hsgradeRod = 12550S OrElse hsgradeRod = 12548S Then
							rsgrade = 12546S
							rsgrade2 = 12545S
							flag = True
						ElseIf hsgradeRod = 12802S OrElse hsgradeRod = 12803S OrElse hsgradeRod = 12805S OrElse hsgradeRod = 12806S OrElse hsgradeRod = 13057S OrElse hsgradeRod = 12808S OrElse hsgradeRod = 12807S Then
							rsgrade = 12801S
							rsgrade2 = 12804S
							flag = True
						End If
					ElseIf RODUTIL.IsProRod(CInt(RSWIN_DESC.HSGradeRod)) <> 0 Then
						rsgrade = 24580S
						rsgrade2 = 24579S
						flag = True
					End If
					If flag Then
						If cRODSTAR.RSGrade = 4098S Then
							cRODSTAR.RSGrade = rsgrade2
							cRODSTAR.RSMaxSize = RODUTIL.SetGuruRodDiameter(CInt(cRODSTAR.RSGrade), cRODSTAR.RSMaxSize)
							cRODSTAR.RSMinSize = RODUTIL.SetGuruRodDiameter(CInt(cRODSTAR.RSGrade), cRODSTAR.RSMinSize)
						ElseIf cRODSTAR.RSGrade = 4099S Then
							cRODSTAR.RSGrade = rsgrade
							cRODSTAR.RSMaxSize = RODUTIL.SetGuruRodDiameter(CInt(cRODSTAR.RSGrade), cRODSTAR.RSMaxSize)
							cRODSTAR.RSMinSize = RODUTIL.SetGuruRodDiameter(CInt(cRODSTAR.RSGrade), cRODSTAR.RSMinSize)
						End If
					End If
				End If
				If cRODSTAR.RSFGGrade <> 0S And RSWIN_DESC.FGGradeRod <> 0S And cRODSTAR.RSFGGrade <> RSWIN_DESC.FGGradeRod Then
					cRODSTAR.RSFGGrade = RSWIN_DESC.FGGradeRod
				End If
				If cRODSTAR.RSFGIncludeSteel <> 0S AndAlso (cRODSTAR.SinkerBar.Grade <> 0S And RSWIN_DESC.SBGradeRod <> 0S And cRODSTAR.SinkerBar.Grade <> RSWIN_DESC.SBGradeRod) Then
					Dim sinkerBar As RSWIN_DESC.RodSection
					sinkerBar.Initialize()
					sinkerBar.Grade = RSWIN_DESC.SBGradeRod
					sinkerBar.RodType = rodType
					sinkerBar.RodType = RODUTIL.RodGrade(sinkerBar.Grade)
					sinkerBar.Diameter = RODUTIL.SetGuruRodDiameter(CInt(cRODSTAR.SinkerBar.Grade), cRODSTAR.SinkerBar.Diameter)
					sinkerBar.length = cRODSTAR.SinkerBar.length
					cRODSTAR.SinkerBar = sinkerBar
					Try
						If sinkerBar.SuckerRodLength = 0F Then
							Dim flag2 As Boolean = True
							If flag2 <> (sinkerBar.Grade = 16385S) Then
								If flag2 <> (sinkerBar.Grade = 16389S) Then
									If flag2 <> (sinkerBar.Grade = 16390S) Then
										If flag2 = (RODUTIL.IsSteel(CInt(sinkerBar.Grade)) <> 0) Then
											Dim sDefaultName As String = "SteelSuckerRodLength"
											Dim vNotPresentDefault As Object = 25
											Dim flag3 As Boolean = False
											sinkerBar.SuckerRodLength = Conversions.ToSingle(ini.GetDefault(sDefaultName, vNotPresentDefault, flag3))
											GoTo IL_373
										End If
										If flag2 = RODUTIL.IsCorod(sinkerBar.Grade) OrElse flag2 = (RODUTIL.IsProRod(CInt(sinkerBar.Grade)) <> 0) Then
											sinkerBar.SuckerRodLength = 1F
											GoTo IL_373
										End If
										sinkerBar.SuckerRodLength = 25F
										GoTo IL_373
									End If
								End If
							End If
							sinkerBar.SuckerRodLength = 37.5F
						End If
						IL_373:
					Catch ex As Exception
					End Try
				End If
				If cRODSTAR.RSGrade <> 0S And RSWIN_DESC.HSGradeRod <> 0S Then
					If Not RODUTIL.IsAPI(CInt(cRODSTAR.RSGrade), RODUTIL.RodGrade(cRODSTAR.RSGrade)) And cRODSTAR.RSGrade <> RSWIN_DESC.HSGradeRod Then
						cRODSTAR.RSGrade = RSWIN_DESC.HSGradeRod
						cRODSTAR.RSMaxSize = RODUTIL.SetGuruRodDiameter(CInt(cRODSTAR.RSGrade), cRODSTAR.RSMaxSize)
						cRODSTAR.RSMinSize = RODUTIL.SetGuruRodDiameter(CInt(cRODSTAR.RSGrade), cRODSTAR.RSMinSize)
					ElseIf bOverride Then
						cRODSTAR.RSGrade = RSWIN_DESC.HSGradeRod
						cRODSTAR.RSMaxSize = RODUTIL.SetGuruRodDiameter(CInt(cRODSTAR.RSGrade), cRODSTAR.RSMaxSize)
						cRODSTAR.RSMinSize = RODUTIL.SetGuruRodDiameter(CInt(cRODSTAR.RSGrade), cRODSTAR.RSMinSize)
					End If
				End If
				Dim num As Integer = 1
				Dim numRods As Integer = CInt(cRODSTAR.NumRods)
				For i As Integer = num To numRods
					Dim sections As RSWIN_DESC.RodSection() = cRODSTAR.Sections
					Dim num2 As Integer = i
					If sections(num2).Grade <> 0S And RSWIN_DESC.HSGradeRod <> 0S And Not RODUTIL.IsFG(sections(num2).Grade) And Not RODUTIL.IsAPI(CInt(sections(num2).Grade), RODUTIL.RodGrade(sections(num2).Grade)) And sections(num2).Grade <> RSWIN_DESC.HSGradeRod Then
						sections(num2).Grade = RSWIN_DESC.HSGradeRod
						sections(num2).Diameter = RODUTIL.SetGuruRodDiameter(CInt(sections(num2).Grade), sections(num2).Diameter)
					ElseIf bOverride Then
						sections(num2).Grade = RSWIN_DESC.HSGradeRod
						sections(num2).Diameter = RODUTIL.SetGuruRodDiameter(CInt(sections(num2).Grade), sections(num2).Diameter)
					ElseIf If((-If(((sections(num2).Grade <> 0S And RSWIN_DESC.SBGradeRod <> 0S) > False), 1, 0)), 1, 0) And RODUTIL.IsSinkerBar1(CInt(sections(num2).Grade), sections(num2).RodType) And If((-If(((sections(num2).Grade <> RSWIN_DESC.SBGradeRod) > False), 1, 0)), 1, 0) <> 0 Then
						sections(num2).Grade = RSWIN_DESC.SBGradeRod
						sections(num2).RodType = rodType
						sections(num2).RodType = RODUTIL.RodGrade(sections(num2).Grade)
						sections(num2).Diameter = RODUTIL.SetGuruRodDiameter(CInt(sections(num2).Grade), sections(num2).Diameter)
					End If
					Try
						If sections(num2).SuckerRodLength = 0F Then
							Dim flag4 As Boolean = True
							If flag4 <> (sections(num2).Grade = 16385S) Then
								If flag4 <> (sections(num2).Grade = 16389S) Then
									If flag4 <> (sections(num2).Grade = 16390S) Then
										If flag4 = (RODUTIL.IsSteel(CInt(sections(num2).Grade)) <> 0) Then
											Dim array As RSWIN_DESC.RodSection() = sections
											Dim num3 As Integer = num2
											Dim sDefaultName2 As String = "SteelSuckerRodLength"
											Dim vNotPresentDefault2 As Object = 25
											Dim flag3 As Boolean = False
											array(num3).SuckerRodLength = Conversions.ToSingle(ini.GetDefault(sDefaultName2, vNotPresentDefault2, flag3))
											GoTo IL_777
										End If
										If flag4 = RODUTIL.IsCorod(sections(num2).Grade) OrElse flag4 = (RODUTIL.IsProRod(CInt(sections(num2).Grade)) <> 0) Then
											sections(num2).SuckerRodLength = 1F
											GoTo IL_777
										End If
										sections(num2).SuckerRodLength = 25F
										GoTo IL_777
									End If
								End If
							End If
							sections(num2).SuckerRodLength = 37.5F
						End If
						IL_777:
					Catch ex2 As Exception
					End Try
				Next
				cRODSTAR = Nothing
			Catch ex3 As Exception
			End Try
		End Sub

		Public Sub ResetProgramVarDefaults()
			Try
				If Not RSWIN_DESC.bRodStarD Then
					Me.Icon = RSWIN_DESC.RodstarV_Icon
					If RSWIN_DESC.bExpert Then
						RSWIN_DESC.SECT_PROGWIN32 = "XROD-V"
					ElseIf Operators.CompareString(RSWIN_DESC.sRodstarVorD, "RODSTARD", False) = 0 Then
						RSWIN_DESC.SECT_PROGWIN32 = "RODSTAR-D"
					Else
						RSWIN_DESC.SECT_PROGWIN32 = "RODSTAR-V"
					End If
					RSWIN_DESC.sForWindows = ""
					RSWIN_DESC.sFILETYPE = "rsvx"
					RSWIN_DESC.sDOTFILETYPE = ".rsvx"
					RSWIN_DESC.sOTHERFILETYPE = "rsdx"
					RSWIN_DESC.sAllTypes = "RODSTAR vertical file type (*.rsvx)|*.rsvx|RODSTAR old file type (*.rst)|*.rst|RODSTAR deviated file type (*.rsdx)|*.rsdx|ALL RODSTAR files (*.rst,*.rsvx,*.rsdx)|*.rst;*.rsvx;*.rsdx|XDIAG files (*.xdg,*.xddx)|*.xdg;*.xddx|RODDIAG files (*.rdg)|*.rdg|All Files|*.*"
					RSWIN_DESC.sRODSTARFiles = "RODSTAR vertical file type (*.rsvx)|*.rsvx|RODSTAR old file type (*.rst)|*.rst|XDIAG files (*.XDG,*.XDDX)|*.XDG;*.XDDX|Adobe Acrobat Document (*.PDF)|*.PDF"
					RSWIN_DESC.sImportRSTXFiles = "RODSTAR vertical file type (*.rsvx)|*.rsvx|RODSTAR deviated file type (*.rsdx)|*.rsdx"
					RSWIN_DESC.sSelectOutputFileType = "RODSTAR vertical file type (*.rsvx)|*.rsvx|RODSTAR old file type (*.rst)|*.rst"
					RSWIN_DESC.sSelectOutputFileTypePDF = "Adobe Acrobat Document (*.PDF)|*.PDF"
					RSWIN_DESC.bBETA = False
					RSWIN_DESC.bWriteCSVFIles = False
					RSWIN_DESC.bChangeMotorSize = False
					RSWIN_DESC.bChangeSPM = False
					RSWIN_DESC.bIntVersion = False
					RSWIN_DESC.bChangeCultures = False
					RSWIN_DESC.bWriteResXFile = False
					RSWIN_DESC.bReadResXFile = False
					RSWIN_DESC.bQuickFix = False
					RSWIN_DESC.bQuickFixUsed = False
					RSWIN_DESC.bQuickFixLoop = False
					RSWIN_DESC.sProgramName = "RODSTAR-V "
					RSWIN_DESC.sProgramLongName = "RODSTAR-V "
					RSWIN_DESC.sProgramNameD = "RODSTAR-D "
					RSWIN_DESC.sProgramLongNameD = "RODSTAR-D "
					RSWIN_DESC.sProgramNameV = RSWIN_DESC.sProgramName
					RSWIN_DESC.sProgramLongNameV = RSWIN_DESC.sProgramLongName
					RSWIN_DESC.bExpert = False
					RSWIN_DESC.bCheckSmallestUnit = False
				ElseIf RSWIN_DESC.bRodStarD Then
					Me.Icon = RSWIN_DESC.RodstarD_Icon
					RSWIN_DESC.SECT_PROGWIN32 = "RODSTAR-D"
					RSWIN_DESC.sForWindows = ""
					RSWIN_DESC.sFILETYPE = "rsdx"
					RSWIN_DESC.sDOTFILETYPE = ".rsdx"
					RSWIN_DESC.sOTHERFILETYPE = "rsvx"
					RSWIN_DESC.sRODSTARFiles = "RODSTAR deviated file type (*.rsdx)|*.rsdx|RODSTAR old file type (*.rst)|*.rst|XDIAG files (*.XDG,*.XDDX)|*.XDG;*.XDDX|Adobe Acrobat Document (*.PDF)|*.PDF"
					RSWIN_DESC.sAllTypes = "RODSTAR deviated file type (*.rsdx)|*.rsdx|RODSTAR vertical file type (*.rsvx)|*.rsvx|RODSTAR old file type (*.rst)|*.rst|ALL RODSTAR files (*.rsdx,*.rsvx,*.rst)|*.rsdx;*.rsvx;*.rst|XDIAG files (*.xdg,*.xddx)|*.xdg;*.xddx|RODDIAG files (*.rdg)|*.rdg|All Files|*.*"
					RSWIN_DESC.sImportRSTXFiles = "Files with deviation (*.rsdx,*.deviationprofile)|*.rsdx;*.deviationprofile|RODSTAR deviated file type (*.rsdx)|*.rsdx|RODSTAR files (*.deviationprofile)|*.deviationprofile"
					RSWIN_DESC.sSelectOutputFileType = "RODSTAR deviated file type (*.rsdx)|*.rsdx|RODSTAR vertical file type (*.rsvx)|*.rsvx|RODSTAR old file type (*.rst)|*.rst"
					RSWIN_DESC.sSelectOutputFileTypePDF = "Adobe Acrobat Document (*.PDF)|*.PDF"
					RSWIN_DESC.bBETA = True
					RSWIN_DESC.bWriteCSVFIles = False
					RSWIN_DESC.bChangeMotorSize = False
					RSWIN_DESC.bChangeSPM = False
					RSWIN_DESC.bIntVersion = False
					RSWIN_DESC.bChangeCultures = False
					RSWIN_DESC.bWriteResXFile = False
					RSWIN_DESC.bReadResXFile = False
					RSWIN_DESC.sProgramName = "RODSTAR-D "
					RSWIN_DESC.sProgramLongName = "RODSTAR-D "
					RSWIN_DESC.sProgramNameD = RSWIN_DESC.sProgramName
					RSWIN_DESC.sProgramLongNameD = RSWIN_DESC.sProgramLongName
					RSWIN_DESC.sProgramNameV = "RODSTAR-V "
					RSWIN_DESC.sProgramLongNameV = "RODSTAR-V "
					RSWIN_DESC.bQuickFixUsed = False
					RSWIN_DESC.bQuickFixLoop = RSWIN_DESC.bQuickFix
					RSWIN_DESC.bExpert = False
					RSWIN_DESC.bCheckSmallestUnit = False
				End If
				Dim num As Integer = Conversions.ToInteger(RSWIN_DESC.VersionMajor)
				Dim num2 As Integer = Conversions.ToInteger(RSWIN_DESC.VersionMinor)
				Dim num3 As Integer = Conversions.ToInteger(RSWIN_DESC.VersionBuild)
				Dim num4 As Integer = Conversions.ToInteger(RSWIN_DESC.VersionRevision)
				If RSWIN_DESC.bRodStarD Then
					Dim text As String = RSWIN_DESC.sProgramNameD.Replace(" for Windows", " ")
					RSWIN_DESC.sProgramName = String.Concat(New String() { text, num.ToString(), ".", num2.ToString(), RSWIN_DESC.sForWindows })
					Dim text2 As String = RSWIN_DESC.sProgramLongNameD.Replace(" for Windows", " ")
					RSWIN_DESC.sProgramLongName = String.Concat(New String() { text2, num.ToString(), ".", num2.ToString(), ".", num3.ToString(), RSWIN_DESC.sForWindows })
				Else
					Dim text As String = RSWIN_DESC.sProgramNameV.Replace(" for Windows", " ")
					RSWIN_DESC.sProgramName = String.Concat(New String() { text, num.ToString(), ".", num2.ToString(), RSWIN_DESC.sForWindows })
					Dim text2 As String = RSWIN_DESC.sProgramLongNameV.Replace(" for Windows", " ")
					RSWIN_DESC.sProgramLongName = String.Concat(New String() { text2, num.ToString(), ".", num2.ToString(), ".", num3.ToString(), RSWIN_DESC.sForWindows })
				End If
				Me.Text = RSWIN_DESC.sProgramName
			Catch ex As Exception
			End Try
		End Sub

		Private Sub btnVertical_Click(sender As Object, e As EventArgs)
			Dim text As String = ""
			Dim obj As Object = RSWIN_DESC.SETUP_MeasurementSystem
			Try
				Me.ResetClock()
				If Me.ActiveMdiChild IsNot Nothing Then
					Dim activeMdiChild As Form = Me.ActiveMdiChild
					text = activeMdiChild.Name
					If RSWIN_DESC.bRodStarD Then
						If Operators.CompareString(text, "WellInfo", False) = 0 Or Operators.CompareString(text, "PTInfo", False) = 0 Or Operators.CompareString(text, "RSInput", False) = 0 Or Operators.CompareString(text, "MotorData", False) = 0 Or Operators.CompareString(text, "Results", False) = 0 Or Operators.CompareString(text, "DeviationProfile", False) = 0 Then
							Me.RemoveChildForm(text.Trim(), False)
							Me.RemoveAllChildForms(False)
						Else
							text = ""
						End If
					ElseIf Operators.CompareString(text, "WellInfo", False) = 0 Or Operators.CompareString(text, "PTInfo", False) = 0 Or Operators.CompareString(text, "RSInput", False) = 0 Or Operators.CompareString(text, "MotorData", False) = 0 Or Operators.CompareString(text, "Results", False) = 0 Then
						Me.RemoveChildForm(text.Trim(), False)
						Me.RemoveAllChildForms(False)
					Else
						text = ""
					End If
				End If
				If RSWIN_DESC.bRodStarD Then
					RSWIN_DESC.SavedUpstrokeFriction = RSWIN_DESC.rst.UpstrokeFriction
					RSWIN_DESC.SavedDownstrokeFriction = RSWIN_DESC.rst.DownstrokeFriction
					RSWIN_DESC.rst.UpstrokeFriction = 1F
					RSWIN_DESC.rst.DownstrokeFriction = 1F
					RSWIN_DESC.bRodStarD = False
					RSWIN_DESC.rst.CalcFriction = -1S
					Me.btnVertical.ImageIndex = 2
					Me.ToolTip1.SetToolTip(Me.btnVertical, "Change to Deviated Mode")
					Me.tbrToolbar.Buttons(12).Visible = False
					Me.tbrToolbar.Buttons(12).Enabled = False
					Me.tbrRunSpeed.Enabled = False
					Me.tbrRunSpeed.Visible = False
					If Operators.CompareString(text, "", False) <> 0 AndAlso Operators.CompareString(text, "DeviationProfile", False) = 0 Then
						Me.RemoveChildForm("DeviationProfile", False)
						text = ""
					End If
					Me.tbrRun.ToolTipText = "Run"
					Me.lblMode.ForeColor = Color.Blue
					Me.lblMode.Text = "Vertical mode"
				Else
					RSWIN_DESC.rst.UpstrokeFriction = RSWIN_DESC.SavedUpstrokeFriction
					RSWIN_DESC.rst.DownstrokeFriction = RSWIN_DESC.SavedDownstrokeFriction
					If CDbl(RSWIN_DESC.rst.UpstrokeFriction) > 0.5 Then
						RSWIN_DESC.rst.UpstrokeFriction = 0.1F
						RSWIN_DESC.SavedUpstrokeFriction = 0.1F
					End If
					If CDbl(RSWIN_DESC.rst.DownstrokeFriction) > 0.5 Then
						RSWIN_DESC.rst.DownstrokeFriction = 0.1F
						RSWIN_DESC.SavedDownstrokeFriction = 0.1F
					End If
					RSWIN_DESC.bRodStarD = True
					Me.btnVertical.ImageIndex = 1
					Me.ToolTip1.SetToolTip(Me.btnVertical, "Change to Vertical Mode")
					Me.tbrToolbar.Buttons(12).Visible = True
					Me.tbrToolbar.Buttons(12).Enabled = True
					Me.tbrRun.ToolTipText = "Run"
					Me.tbrRunSpeed.ToolTipText = "Run"
					Me.lblMode.ForeColor = Color.Green
					Me.lblMode.Text = "Deviated mode"
				End If
				Me.ResetProgramVarDefaults()
				Me.ToolbarButtonSetState2(2, False)
				If Operators.CompareString(text, "", False) <> 0 Then
					Dim text2 As String = text
					If Operators.CompareString(text2, "PTInfo", False) = 0 Then
						Me.AddPTInfo(True)
					ElseIf Operators.CompareString(text2, "RSInput", False) = 0 Then
						Me.AddRSInput(True, False)
					ElseIf Operators.CompareString(text2, "MotorData", False) = 0 Then
						Me.AddMotorData(True)
					ElseIf Operators.CompareString(text2, "WellInfo", False) = 0 Then
						Me.AddWellInfo(True)
					End If
				End If
				If RSWIN_DESC.bRodStarD Then
					Me.mnuFileSaveAsRSDX.Enabled = True
					Me.mnuFileSaveAsRSVX.Enabled = False
					Me.mnuFileSaveAsXRVX.Enabled = False
				ElseIf RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru Then
					Me.mnuFileSaveAsRSDX.Enabled = False
					Me.mnuFileSaveAsRSVX.Enabled = True
					Me.mnuFileSaveAsXRVX.Enabled = True
				Else
					Me.mnuFileSaveAsRSVX.Enabled = True
					Me.mnuFileSaveAsRSDX.Enabled = False
					Me.mnuFileSaveAsXRVX.Enabled = False
				End If
				RSWIN_DESC.SETUP_MeasurementSystem = Conversions.ToInteger(obj)
				Dim text3 As String = "MeasurementSystem"
				Dim obj2 As Object = RSWIN_DESC.SETUP_MeasurementSystem
				Dim text4 As String = Util.Format(obj2)
				RSWIN_DESC.SETUP_MeasurementSystem = Conversions.ToInteger(obj2)
				Dim text5 As String = text4
				Dim num As Integer = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_GENERAL, text3, text5, RSWIN_DESC.sINIFile)
				RSWIN.GetMeasurementUnit()
				If Not RSWIN_DESC.bExpert Then
					If RSWIN_DESC.bRodStarD Then
						RSWIN_DESC.rst.RSTDir = Conversions.ToString(RSWIN.GetInitialDir(".RSDX", ""))
					Else
						RSWIN_DESC.rst.RSTDir = Conversions.ToString(RSWIN.GetInitialDir(".RSVX", ""))
					End If
				End If
			Catch ex As Exception
				RSWIN_DESC.SETUP_MeasurementSystem = Conversions.ToInteger(obj)
				Dim text5 As String = "MeasurementSystem"
				Dim obj2 As Object = RSWIN_DESC.SETUP_MeasurementSystem
				Dim text6 As String = Util.Format(obj2)
				RSWIN_DESC.SETUP_MeasurementSystem = Conversions.ToInteger(obj2)
				Dim text3 As String = text6
				Dim num As Integer = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_GENERAL, text5, text3, RSWIN_DESC.sINIFile)
				RSWIN.GetMeasurementUnit()
			End Try
		End Sub

		Private Sub DebugMergeGURUInputs(iRun As Integer)
			Try
			Catch ex As Exception
			End Try
		End Sub

		Private Sub SetMnuFileSaveAs()
			Try
				Me.mnuFileSaveAs_.MenuItems.Clear()
				Try
					If RSWIN_DESC.bRodStarD Then
						Me.mnuFileSaveAsRSDX.Index = 0
						Me.mnuFileSaveAsRSDX.MergeType = MenuMerge.Remove
						Me.mnuFileSaveAsRSDX.Shortcut = Shortcut.CtrlD
						Me.mnuFileSaveAsRSDX.Text = "Save As RODSTAR RS&DX File...."
						Me.mnuFileSaveAsRSVX.Index = 1
						Me.mnuFileSaveAsRSVX.MergeType = MenuMerge.Remove
						Me.mnuFileSaveAsRSVX.Shortcut = Shortcut.CtrlV
						Me.mnuFileSaveAsRSVX.Text = "Save As RODSTAR RS&VX File...."
						Me.mnuFileSaveAsSeparator1.Index = 2
						Me.mnuFileSaveAsSeparator1.MergeType = MenuMerge.Remove
						Me.mnuFileSaveAsSeparator1.Text = "-"
						Me.mnuFileSaveAsPDF_.Index = 3
						Me.mnuFileSaveAsPDF_.MergeType = MenuMerge.Remove
						Me.mnuFileSaveAsPDF_.Shortcut = Shortcut.CtrlP
						Me.mnuFileSaveAsPDF_.Text = "Save Results As Adobe &PDF File...."
						Me.mnuFileSaveAsPDF_.Enabled = False
					ElseIf Not RSWIN_DESC.bExpert Or (RSWIN_DESC.bExpert And Not RSWIN_DESC.SETUP_bGuru) Then
						Me.mnuFileSaveAsRSVX.Index = 0
						Me.mnuFileSaveAsRSVX.MergeType = MenuMerge.Remove
						Me.mnuFileSaveAsRSVX.Shortcut = Shortcut.CtrlV
						Me.mnuFileSaveAsRSVX.Text = "Save As RODSTAR RS&VX File...."
						Me.mnuFileSaveAsSeparator1.Index = 1
						Me.mnuFileSaveAsSeparator1.MergeType = MenuMerge.Remove
						Me.mnuFileSaveAsSeparator1.Text = "-"
						Me.mnuFileSaveAsPDF_.Index = 2
						Me.mnuFileSaveAsPDF_.MergeType = MenuMerge.Remove
						Me.mnuFileSaveAsPDF_.Shortcut = Shortcut.CtrlP
						Me.mnuFileSaveAsPDF_.Text = "Save Results As Adobe &PDF File...."
						Me.mnuFileSaveAsPDF_.Enabled = False
					ElseIf RSWIN_DESC.SETUP_bGuru Then
						Me.mnuFileSaveAsXRVX.Index = 0
						Me.mnuFileSaveAsXRVX.MergeType = MenuMerge.Remove
						Me.mnuFileSaveAsXRVX.Shortcut = Shortcut.CtrlG
						Me.mnuFileSaveAsXRVX.Text = "Save As XROD-V &XRVX File...."
						Me.mnuFileSaveAsSeparator1.Index = 1
						Me.mnuFileSaveAsSeparator1.MergeType = MenuMerge.Remove
						Me.mnuFileSaveAsSeparator1.Text = "-"
						Me.mnuFileSaveAsPDF_.Index = 2
						Me.mnuFileSaveAsPDF_.MergeType = MenuMerge.Remove
						Me.mnuFileSaveAsPDF_.Shortcut = Shortcut.CtrlP
						Me.mnuFileSaveAsPDF_.Text = "Save Results As Adobe &PDF File...."
						Me.mnuFileSaveAsPDF_.Enabled = False
					End If
				Catch ex As Exception
				End Try
				If RSWIN_DESC.bRodStarD Then
					Me.mnuFileSaveAs_.MenuItems.AddRange(New MenuItem() { Me.mnuFileSaveAsRSDX, Me.mnuFileSaveAsRSVX, Me.mnuFileSaveAsSeparator1, Me.mnuFileSaveAsPDF_ })
				ElseIf Not RSWIN_DESC.bExpert Or (RSWIN_DESC.bExpert And Not RSWIN_DESC.SETUP_bGuru) Then
					Me.mnuFileSaveAs_.MenuItems.AddRange(New MenuItem() { Me.mnuFileSaveAsRSVX, Me.mnuFileSaveAsSeparator1, Me.mnuFileSaveAsPDF_ })
				ElseIf RSWIN_DESC.SETUP_bGuru Then
					Me.mnuFileSaveAs_.MenuItems.AddRange(New MenuItem() { Me.mnuFileSaveAsXRVX, Me.mnuFileSaveAsSeparator1, Me.mnuFileSaveAsPDF_ })
				End If
			Catch ex2 As Exception
			End Try
		End Sub

		Public Sub ExportRSVXtoGuruDB(bMultipleFiles As Boolean, bAskQuestion As Boolean, Optional bAll As Boolean = False, Optional iLast As Integer = 0)
			Dim flag As Boolean = False
			Dim text As String = ""
			Dim text2 As String = ""
			If RSWIN_DESC.rst Is Nothing Then
				flag = True
			ElseIf Operators.CompareString(RSWIN_DESC.rst.Inputfile.Trim(), "", False) = 0 Then
				flag = True
			End If
			Dim text4 As String
			If flag Then
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				Dim text3 As String = rst.RSTDir
				FILEIO.SelectInputFile(text4, text3, "RODSTAR vertical file type (*.rsvx)|*.RSVX", 1, "", "")
				rst.RSTDir = text3
			End If
			If flag And Strings.Len(text4) > 0 Then
				Cursor.Current = Cursors.WaitCursor
				If LikeOperator.LikeString(Strings.LCase(text4), "*.rsvx", CompareMethod.Binary) Then
					Dim flag2 As Boolean = MRodstarXML.ValidateXML(text4)
					If flag2 Then
						MessageBox.Show("File is not valid!", "Open File Error", MessageBoxButtons.OK)
					Else
						RSWIN_DESC.rst = New cRODSTAR()
						RSWIN_DESC.rst.SetClassDefaults(False)
						Dim flag3 As Boolean = MRodstarXML.LoadRodstarXML(text4)
						If flag3 Then
							Dim guruFileDataStructure As RSWIN_DESC.GuruFileDataStructure
							guruFileDataStructure.FileName = Util.FileName(text4)
							guruFileDataStructure.FileName = guruFileDataStructure.FileName.Replace(".rsvx", "")
							guruFileDataStructure.FileName = guruFileDataStructure.FileName.Replace(".RSVX", "")
							GURU_DB.CopyRST2Filedata(guruFileDataStructure, RSWIN_DESC.OriginalConst)
							If Not bMultipleFiles AndAlso bAskQuestion Then
								Dim msg As String = "Upload " + Util.FileName(text4) + " to Template Database! Are you sure?"
								Dim bDefaultYes As Boolean = True
								Dim flag4 As Boolean = False
								If Util.YesNo(msg, bDefaultYes, flag4) Then
									Dim sTemplateDBFileName As String = RSWIN_DESC.sTemplateDBFileName
									Dim text3 As String = RSWIN_DESC.GuruDataBaseFileName
									FILEUTIL.LocateFile(sTemplateDBFileName, text3, 2S, True, False, False, False)
									RSWIN_DESC.GuruDataBaseFileName = text3
									Dim filenameNumber As Integer = Me.GetFilenameNumber(guruFileDataStructure.FileName.Trim(), "", False)
									If filenameNumber = -1 OrElse bAll Then
										GURU_DB.DBAddFiledata(guruFileDataStructure, False, False)
									Else
										RSWIN_DESC.AllGuruFiles(filenameNumber) = guruFileDataStructure
										GURU_DB.UpdateRow(filenameNumber, guruFileDataStructure.FileName.Trim(), False)
									End If
								End If
							Else
								Dim sTemplateDBFileName2 As String = RSWIN_DESC.sTemplateDBFileName
								Dim text3 As String = RSWIN_DESC.GuruDataBaseFileName
								FILEUTIL.LocateFile(sTemplateDBFileName2, text3, 2S, True, False, False, False)
								RSWIN_DESC.GuruDataBaseFileName = text3
								Dim filenameNumber As Integer = Me.GetFilenameNumber(guruFileDataStructure.FileName.Trim(), "", False)
								If filenameNumber = -1 OrElse bAll Then
									GURU_DB.DBAddFiledata(guruFileDataStructure, False, False)
								Else
									RSWIN_DESC.AllGuruFiles(filenameNumber) = guruFileDataStructure
									GURU_DB.UpdateRow(filenameNumber, guruFileDataStructure.FileName.Trim(), False)
								End If
							End If
						End If
					End If
				End If
			ElseIf RSWIN_DESC.rst IsNot Nothing Then
				Dim guruFileDataStructure As RSWIN_DESC.GuruFileDataStructure
				guruFileDataStructure.FileName = Util.FileName(RSWIN_DESC.rst.Inputfile.Trim())
				guruFileDataStructure.FileName = guruFileDataStructure.FileName.Replace(".rsvx", "")
				guruFileDataStructure.FileName = guruFileDataStructure.FileName.Replace(".RSVX", "")
				GURU_DB.CopyRST2Filedata(guruFileDataStructure, RSWIN_DESC.OriginalConst)
				If Not Me.PrefixInFilename(guruFileDataStructure.FileName) Then
					Dim guruFileName As String = Me.GetGuruFileName(RSWIN_DESC.rst.PumpDepth, RSWIN_DESC.rst.TargetBFPD, RSWIN_DESC.get_PUManuf(1), 1, text, True, text2, False)
					If Me.PrefixInFilename(text2) Then
						If Strings.InStr(text2, ".rsvx", CompareMethod.Binary) > 0 Then
							text2 = text2.Replace(".rsvx", "")
						ElseIf Strings.InStr(text2, ".RSVX", CompareMethod.Binary) > 0 Then
							text2 = text2.Replace(".RSVX", "")
						End If
						guruFileDataStructure.FileName = text2
					End If
				End If
				If Not bMultipleFiles AndAlso bAskQuestion Then
					Dim text5 As String
					If Operators.CompareString(text2, "", False) = 0 Then
						text5 = "Upload " + Util.FileName(RSWIN_DESC.rst.Inputfile.Trim()) + " to Template Database! Are you sure?"
					Else
						text5 = String.Concat(New String() { "Upload ", Util.FileName(RSWIN_DESC.rst.Inputfile.Trim()), " (to be uploaded as ", text2, ") to Template Database! Are you sure?" })
					End If
					Dim msg2 As String = text5
					Dim bDefaultYes2 As Boolean = True
					Dim flag4 As Boolean = False
					If Util.YesNo(msg2, bDefaultYes2, flag4) Then
						Dim sTemplateDBFileName3 As String = RSWIN_DESC.sTemplateDBFileName
						Dim text3 As String = RSWIN_DESC.GuruDataBaseFileName
						FILEUTIL.LocateFile(sTemplateDBFileName3, text3, 2S, True, False, False, False)
						RSWIN_DESC.GuruDataBaseFileName = text3
						Dim filenameNumber As Integer = Me.GetFilenameNumber(guruFileDataStructure.FileName.Trim(), "", False)
						If filenameNumber = -1 OrElse bAll Then
							Application.DoEvents()
							GURU_DB.DBAddFiledata(guruFileDataStructure, False, False)
							Application.DoEvents()
						Else
							Application.DoEvents()
							RSWIN_DESC.AllGuruFiles(filenameNumber) = guruFileDataStructure
							GURU_DB.UpdateRow(filenameNumber, guruFileDataStructure.FileName.Trim(), False)
							Application.DoEvents()
						End If
					End If
				Else
					Dim sTemplateDBFileName4 As String = RSWIN_DESC.sTemplateDBFileName
					Dim text3 As String = RSWIN_DESC.GuruDataBaseFileName
					FILEUTIL.LocateFile(sTemplateDBFileName4, text3, 2S, True, False, False, False)
					RSWIN_DESC.GuruDataBaseFileName = text3
					Dim filenameNumber As Integer = Me.GetFilenameNumber(guruFileDataStructure.FileName.Trim(), "", False)
					If filenameNumber = -1 OrElse bAll Then
						Application.DoEvents()
						GURU_DB.DBAddFiledata(guruFileDataStructure, False, False)
						Application.DoEvents()
					Else
						Application.DoEvents()
						RSWIN_DESC.AllGuruFiles(filenameNumber) = guruFileDataStructure
						GURU_DB.UpdateRow(filenameNumber, guruFileDataStructure.FileName.Trim(), False)
						Application.DoEvents()
					End If
				End If
			End If
			Me.Message("Total templates: " + Conversions.ToString(RSWIN_DESC.iGuruFileCount) + " , Number Added: " + Conversions.ToString(RSWIN_DESC.iAddedTemplates))
			Cursor.Current = Cursors.[Default]
		End Sub

		Public Sub mnuToolsUploadRSVXFile_Click(sender As Object, e As EventArgs)
			Try
				If RSWIN_DESC.iGuruFileCount = 0 Then
					GURU_DB.LoadALLGuruFiledata(False)
					RSWIN_DESC.bGuruFileDataLoaded = True
				End If
				Me.Message("Total templates: " + Conversions.ToString(RSWIN_DESC.iGuruFileCount) + " , Number Added: " + Conversions.ToString(RSWIN_DESC.iAddedTemplates))
				Me.ExportRSVXtoGuruDB(False, True, False, 0)
				GURU_DB.ReLoadALLGuruFiledata()
			Catch ex As Exception
			End Try
		End Sub

		Public Sub mnuToolsUploadRSVXFiles_Click(sender As Object, e As EventArgs)
			' The following expression was wrapped in a checked-statement
			Try
				Dim text As String = ""
				If RSWIN_DESC.iGuruFileCount = 0 Then
					GURU_DB.LoadALLGuruFiledata(False)
				End If
				Dim num2 As Integer
				Dim num As Short = CShort(num2)
				Dim rst As cRODSTAR = RSWIN_DESC.rst
				Dim rstdir As String = rst.RSTDir
				Dim array As String()
				FILEIO.SelectInputFiles(array, num, rstdir, "RODSTAR vertical file type (*.rsvx)|*.RSVX", 1, "", "Select RSVX Template File(s)", text)
				rst.RSTDir = rstdir
				num2 = CInt(num)
				Dim num3 As Integer = Information.LBound(array, 1)
				Dim num4 As Integer = Information.UBound(array, 1)
				For i As Integer = num3 To num4
					Me.SetCaption("")
					If Strings.InStr(array(i).ToLower(), "rsvx", CompareMethod.Binary) > 0 Then
						Dim flag As Boolean = False
						Dim array2 As String() = array
						Dim num5 As Integer = i
						rst = RSWIN_DESC.rst
						Dim gbInputDataChanged As Boolean = rst.gbInputDataChanged
						Dim cursor As Cursor
						Me.LoadOneFile(cursor, array2(num5), flag, gbInputDataChanged, True)
						rst.gbInputDataChanged = gbInputDataChanged
						If flag Then
							Me.Message("Uploading " + Util.FileName(array(i)))
							Me.ExportRSVXtoGuruDB(False, False, False, 0)
							Me.Message("File " + Util.FileName(array(i)) + " uploaded successfully!")
						Else
							Me.Message("")
						End If
					End If
				Next
				Me.Message("Finished uploading!")
				Try
					GURU_DB.ReLoadALLGuruFiledata()
					RSWIN_DESC.bGuruFileDataLoaded = True
				Catch ex As Exception
				End Try
			Catch ex2 As Exception
				Me.Message("Finished uploading!")
			End Try
		End Sub

		Public Sub mnuToolsDownloadToRSVX_Click(sender As Object, e As EventArgs)
			' The following expression was wrapped in a checked-statement
			Try
				GURU_DB.ReLoadALLGuruFiledata()
				RSWIN_DESC.bGuruFileDataLoaded = True
				Me.frmLoadGuruFilenames = New frmLoadGuruFNames()
				Me.frmLoadGuruFilenames.StartPosition = FormStartPosition.CenterScreen
				Me.frmLoadGuruFilenames.sFormCaption = "Select Template to Import"
				Me.Enabled = False
				Me.frmLoadGuruFilenames.ShowDialog()
				Me.Enabled = True
				If Operators.CompareString(RSWIN_DESC.sGuruFilenameKey, "", False) <> 0 Then
					Dim filenameNumber As Integer = Me.GetFilenameNumber(RSWIN_DESC.sGuruFilenameKey, "", True)
					If filenameNumber <> -1 Then
						GURU_DB.CopyGuruFiledata2RSTObj(filenameNumber, False)
						Dim num As Integer = 1
						Do
							RSWIN_DESC.NewData(num) = 0S
							num += 1
						Loop While num <= 7
						ini.SaveDataValue(RSWIN_DESC.sNull, "")
						ini.SaveDataValue("InProgress", DBNull.Value)
						RSWIN.ReCreateRegKey(RSWIN_DESC.SECT_DATAENTRY)
						Me.ToolbarButtonSetState(0, True)
						Me.ToolbarButtonSetState(1, True)
						Me.ToolbarButtonSetState(2, True)
						Me.ToolbarButtonSetState(8, True)
						Me.ToolbarButtonSetState(9, True)
						Me.ToolbarButtonSetState(10, True)
						Me.ToolbarButtonSetState(11, True)
						Me.ToolbarButtonSetState(12, False)
						Me.ToolbarButtonSetState(13, True)
						Me.ToolbarButtonSetState(14, True)
						Me.ToolbarButtonSetState(15, True)
						Me.ToolbarButtonSetState(16, True)
						Me.ToolbarButtonSetState2(4, True)
						Me.ToolbarButtonSetState2(5, True)
						Me.ToolbarButtonSetState2(0, True)
						Me.btnVisualInput.Enabled = True
						Me.btnAlpha.Enabled = True
						Dim msgtxt As String = "Successfully loaded file " + RSWIN_DESC.rst.Inputfile + " from template database."
						Me.Message(msgtxt)
						Me.SetCaption(RSWIN_DESC.rst.Inputfile)
						Me.ToolbarButtonSetState2(2, False)
						Me.LoadForm(1S, -1S)
					End If
				End If
			Catch ex As Exception
			End Try
		End Sub

		Public Sub mnuToolsDeleteTemplate_Click(sender As Object, e As EventArgs)
			Try
				GURU_DB.ReLoadALLGuruFiledata()
				Me.Enabled = False
				Me.frmLoadGuruFilenames = New frmLoadGuruFNames()
				Me.frmLoadGuruFilenames.StartPosition = FormStartPosition.CenterScreen
				Me.frmLoadGuruFilenames.sFormCaption = "Select Template to Delete"
				Me.frmLoadGuruFilenames.ShowDialog()
				Me.Enabled = True
				If Operators.CompareString(RSWIN_DESC.sGuruFilenameKey, "", False) <> 0 Then
					Dim msg As String = "Delete template " + RSWIN_DESC.sGuruFilenameKey
					Dim bDefaultYes As Boolean = True
					Dim flag As Boolean = False
					If Util.YesNo(msg, bDefaultYes, flag) Then
						GURU_DB.DBDeletePattern(RSWIN_DESC.sGuruFilenameKey)
					End If
				End If
			Catch ex As Exception
			End Try
		End Sub

		Public Function GetFilenameNumber(sGuruFilenameKey As String, PUManuf As String, Optional bAdmin As Boolean = False) As Integer
			Dim flag As Boolean = False
			Dim result As Integer
			Try
				If Not bAdmin And RSWIN_DESC.bXRODAdmin Then
					bAdmin = True
				End If
				Dim num As Integer = 1
				Dim iGuruFileCount As Integer = RSWIN_DESC.iGuruFileCount
				Dim i As Integer
				i = num
				While i <= iGuruFileCount
					If Operators.CompareString(RSWIN_DESC.AllGuruFiles(i).FileName.Trim().ToLower(), sGuruFilenameKey.Trim().ToLower(), False) = 0 Then
						If Not RSWIN_DESC.bUseLatestXRODCode Then
							sGuruFilenameKey = RSWIN_DESC.AllGuruFiles(i).FileName
							flag = True
							Exit While
						End If
						If RSWIN_DESC.AllGuruFiles(i).Original = 1S Then
							sGuruFilenameKey = RSWIN_DESC.AllGuruFiles(i).FileName
							flag = True
							Exit While
						End If
						If bAdmin And RSWIN_DESC.AllGuruFiles(i).Original = 0S Then
							sGuruFilenameKey = RSWIN_DESC.AllGuruFiles(i).FileName
							flag = True
							Exit While
						End If
						If Operators.CompareString(PUManuf.Trim(), "", False) <> 0 Then
							Dim id As String = RSWIN_DESC.AllGuruFiles(i).Unit.Trim() + RSWIN_DESC.AllGuruFiles(i).ID.Trim()
							Dim pudataRec As RSWIN_DESC.PUDataRec
							PUDATA1.ReadPUData(id, pudataRec, True, False)
							Dim manuf As String = pudataRec.Manuf
							Dim manufUnitType As Short = Me.GetManufUnitType(PUManuf)
							Dim manufUnitType2 As Short = Me.GetManufUnitType(manuf)
							If Operators.CompareString(manuf.Trim(), PUManuf.Trim(), False) = 0 Or (manufUnitType = 1S And manufUnitType2 = 1S) Then
								sGuruFilenameKey = RSWIN_DESC.AllGuruFiles(i).FileName
								flag = True
								Exit While
							End If
						End If
					End If
					i += 1
				End While
				If flag Then
					result = i
				Else
					result = -1
				End If
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Sub mnuToolsEncryptTemplateDatabase_click(sender As Object, e As EventArgs)
			Dim msg As String = "Creating Encrypted Template Database! Are you sure?"
			Dim bDefaultYes As Boolean = True
			Dim flag As Boolean = False
			If Util.YesNo(msg, bDefaultYes, flag) Then
				Me.Message("Creating Encrypted Template Database!")
				GURU_DB.ReLoadALLGuruFiledata()
				RSWIN_DESC.bGuruFileDataLoaded = True
				Dim text As String = ""
				Dim text2 As String = ""
				Dim fileName As String = ""
				Dim text3 As String
				FILEUTIL.LocateFile(RSWIN_DESC.sTemplateDBFileName, text3, 2S, True, False, False, False)
				Dim text4 As String = text3.Replace(RSWIN_DESC.sTemplateDBFileName, RSWIN_DESC.sTemplateDBFileName_En)
				If Operators.CompareString(text4, "", False) <> 0 AndAlso FILEUTIL.FileExists(text4) Then
					Try
						text = text4.Replace(".mdb", "-sav.mdb")
						If FILEUTIL.FileExists(text) Then
							Try
								FileSystem.Kill(text)
							Catch ex As Exception
							End Try
						End If
						If FILEUTIL.FileExists(text4) Then
							Dim fileInfo As FileInfo = New FileInfo(text4)
							fileInfo.CopyTo(text)
							FileSystem.Kill(text4)
						End If
					Catch ex2 As Exception
					End Try
				End If
				FILEUTIL.LocateFile(RSWIN_DESC.BlankGuruDataBaseFileNameEn, fileName, 2S, True, False, False, False)
				Dim fileInfo2 As FileInfo = New FileInfo(fileName)
				FILEUTIL.LocateFile(RSWIN_DESC.sTemplateDBFileName_En, text2, 2S, True, False, False, False)
				If Operators.CompareString(text2, "", False) = 0 Then
					text2 = Application.StartupPath + "\" + RSWIN_DESC.sTemplateDBFileName_En
				End If
				If FILEUTIL.FileExists(text2) Then
					Try
						FileSystem.Kill(text2)
					Catch ex3 As Exception
					End Try
				End If
				fileInfo2.CopyTo(text2)
				Dim connectionString As String = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + text2 + ";Mode=Share Deny None;Extended Properties="""";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password=", RSWIN_DESC.GuruDatabasePassword), ";Jet OLEDB:Engine Type=5;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password="""";Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False"))
				Dim text5 As String = "filedata"
				Dim selectCommandText As String = "Select * from " + text5
				Dim selectConnection As OleDbConnection = New OleDbConnection(connectionString)
				Dim oleDbDataAdapter As OleDbDataAdapter = New OleDbDataAdapter(selectCommandText, selectConnection)
				If Operators.CompareString(text2, RSWIN_DESC.sTemplateDBFileName_En, False) = 0 Then
					FILEUTIL.LocateFile(RSWIN_DESC.sTemplateDBFileName_En, text2, 2S, True, False, False, False)
				End If
				oleDbDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey
				Dim dataSet As DataSet = New DataSet("filedata")
				oleDbDataAdapter.Fill(dataSet, text5)
				Dim count As Integer = dataSet.Tables(0).Rows.Count
				Dim oleDbCommandBuilder As OleDbCommandBuilder = New OleDbCommandBuilder(oleDbDataAdapter)
				Me.Message(" Encrypting Template Database! Please wait!")
				Try
					Dim num As Integer = 1
					Dim iGuruFileCount As Integer = RSWIN_DESC.iGuruFileCount
					For i As Integer = num To iGuruFileCount
						Try
							Dim dataRow As DataRow = dataSet.Tables(0).NewRow()
							Dim num2 As Integer = i
							dataRow("FileName") = RuntimeHelpers.GetObjectValue(Me.EnDeCrypt(RSWIN_DESC.AllGuruFiles(num2).FileName))
							dataRow("WellName") = RSWIN_DESC.AllGuruFiles(num2).WellName
							dataRow("gbCalcPumpCondition") = RSWIN_DESC.AllGuruFiles(num2).gbCalcPumpCondition
							dataRow("PumpCondition") = RSWIN_DESC.AllGuruFiles(num2).PumpCondition
							dataRow("IrotEntered") = RSWIN_DESC.AllGuruFiles(num2).IrotEntered
							dataRow("CalcPlungerSize") = RSWIN_DESC.AllGuruFiles(num2).CalcPlungerSize
							dataRow("gbCalcPumpIntakePressure") = RSWIN_DESC.AllGuruFiles(num2).gbCalcPumpIntakePressure
							dataRow("CasingPressure") = RSWIN_DESC.AllGuruFiles(num2).CasingPressure
							dataRow("CompressibilityIndex") = RSWIN_DESC.AllGuruFiles(num2).CompressibilityIndex
							dataRow("ElectricityCost") = RSWIN_DESC.AllGuruFiles(num2).ElectricityCost
							dataRow("FluidDamping") = RSWIN_DESC.AllGuruFiles(num2).FluidDamping
							dataRow("FluidLevel") = Me.Convert_Encrypt(RSWIN_DESC.AllGuruFiles(num2).FluidLevel)
							dataRow("gbIncludeBuoyancy") = RSWIN_DESC.AllGuruFiles(num2).gbIncludeBuoyancy
							dataRow("IncludeFluidInertia") = RSWIN_DESC.AllGuruFiles(num2).IncludeFluidInertia
							dataRow("Iart") = RSWIN_DESC.AllGuruFiles(num2).Iart
							dataRow("Irot") = RSWIN_DESC.AllGuruFiles(num2).Irot
							dataRow("UnknownM") = RSWIN_DESC.AllGuruFiles(num2).UnknownM
							dataRow("M_Existing") = RSWIN_DESC.AllGuruFiles(num2).M_Existing
							dataRow("CBEffect") = RSWIN_DESC.AllGuruFiles(num2).CBEffect
							dataRow("CBAngle") = RSWIN_DESC.AllGuruFiles(num2).CBAngle
							dataRow("CBDataType") = RSWIN_DESC.AllGuruFiles(num2).CBDataType
							dataRow("CalcMotorSize") = RSWIN_DESC.AllGuruFiles(num2).CalcMotorSize
							dataRow("IncludeMotorSPV") = RSWIN_DESC.AllGuruFiles(num2).IncludeMotorSPV
							dataRow("MotorSPV") = RSWIN_DESC.AllGuruFiles(num2).MotorSPV
							dataRow("OilAPI") = RSWIN_DESC.AllGuruFiles(num2).OilAPI
							dataRow("PlungerSize") = RSWIN_DESC.AllGuruFiles(num2).PlungerSize
							dataRow("PowerMeterType") = RSWIN_DESC.AllGuruFiles(num2).PowerMeterType
							dataRow("PumpDepth") = Me.Convert_Encrypt(RSWIN_DESC.AllGuruFiles(num2).PumpDepth)
							dataRow("PumpEfficiency") = RSWIN_DESC.AllGuruFiles(num2).PumpEfficiency
							dataRow("PumpFillage") = RSWIN_DESC.AllGuruFiles(num2).PumpFillage
							dataRow("PumpFriction") = RSWIN_DESC.AllGuruFiles(num2).PumpFriction
							dataRow("PumpIntakePressure") = RSWIN_DESC.AllGuruFiles(num2).PumpIntakePressure
							dataRow("PumpLoadAdj") = RSWIN_DESC.AllGuruFiles(num2).PumpLoadAdj
							dataRow("PumpType") = RSWIN_DESC.AllGuruFiles(num2).PumpType
							dataRow("SPM") = RSWIN_DESC.AllGuruFiles(num2).SPM
							dataRow("CalcFriction") = RSWIN_DESC.AllGuruFiles(num2).CalcFriction
							dataRow("DownstrokeFriction") = RSWIN_DESC.AllGuruFiles(num2).DownstrokeFriction
							dataRow("UpstrokeFriction") = RSWIN_DESC.AllGuruFiles(num2).UpstrokeFriction
							dataRow("XTimes") = RSWIN_DESC.AllGuruFiles(num2).XTimes
							dataRow("Runtime") = RSWIN_DESC.AllGuruFiles(num2).Runtime
							dataRow("StuffingBoxFriction") = RSWIN_DESC.AllGuruFiles(num2).StuffingBoxFriction
							dataRow("TargetBFPD") = Me.Convert_Encrypt(RSWIN_DESC.AllGuruFiles(num2).TargetBFPD)
							dataRow("TubingAnchorDepth") = Me.Convert_Encrypt(RSWIN_DESC.AllGuruFiles(num2).TubingAnchorDepth)
							dataRow("TubingAnchored") = RSWIN_DESC.AllGuruFiles(num2).TubingAnchored
							dataRow("TubingID") = RSWIN_DESC.AllGuruFiles(num2).TubingID
							dataRow("TubingOD") = RSWIN_DESC.AllGuruFiles(num2).TubingOD
							dataRow("TubingPressure") = RSWIN_DESC.AllGuruFiles(num2).TubingPressure
							dataRow("WaterCut") = RSWIN_DESC.AllGuruFiles(num2).WaterCut
							dataRow("WaterSPGR") = RSWIN_DESC.AllGuruFiles(num2).WaterSPGR
							dataRow("RodStringType") = RSWIN_DESC.AllGuruFiles(num2).RodStringType
							dataRow("giRodDesignStyle") = RSWIN_DESC.AllGuruFiles(num2).giRodDesignStyle
							dataRow("RSFGIncludeSteel") = RSWIN_DESC.AllGuruFiles(num2).RSFGIncludeSteel
							dataRow("RSGrade") = RSWIN_DESC.AllGuruFiles(num2).RSGrade
							dataRow("RSMaxSize") = RSWIN_DESC.AllGuruFiles(num2).RSMaxSize
							dataRow("RSMinSize") = RSWIN_DESC.AllGuruFiles(num2).RSMinSize
							dataRow("RSFricCoef") = RSWIN_DESC.AllGuruFiles(num2).RSFricCoef
							dataRow("RSIncludeSB") = RSWIN_DESC.AllGuruFiles(num2).RSIncludeSB
							dataRow("SinkerBar_Grade") = RSWIN_DESC.AllGuruFiles(num2).SinkerBar_Grade
							dataRow("SinkerBar_length") = RSWIN_DESC.AllGuruFiles(num2).SinkerBar_length
							dataRow("SinkerBar_Diameter") = RSWIN_DESC.AllGuruFiles(num2).SinkerBar_Diameter
							dataRow("RSFGGrade") = RSWIN_DESC.AllGuruFiles(num2).RSFGGrade
							dataRow("RSExtraCost") = RSWIN_DESC.AllGuruFiles(num2).RSExtraCost
							If Operators.CompareString(RSWIN_DESC.AllGuruFiles(num2).RSExtraCostLabel, "", False) = 0 Then
								RSWIN_DESC.AllGuruFiles(num2).RSExtraCostLabel = " "
							End If
							dataRow("RSExtraCostLabel") = RSWIN_DESC.AllGuruFiles(num2).RSExtraCostLabel
							dataRow("ServiceFactor") = RSWIN_DESC.AllGuruFiles(num2).ServiceFactor
							dataRow("PU_CrankRotation") = RSWIN_DESC.AllGuruFiles(num2).PU_CrankRotation
							dataRow("PU_CrankHole") = RSWIN_DESC.AllGuruFiles(num2).PU_CrankHole
							dataRow("Unbalance") = RSWIN_DESC.AllGuruFiles(num2).Unbalance
							dataRow("Unit") = RuntimeHelpers.GetObjectValue(Me.EnDeCrypt(RSWIN_DESC.AllGuruFiles(num2).Unit))
							dataRow("ID") = RuntimeHelpers.GetObjectValue(Me.EnDeCrypt(RSWIN_DESC.AllGuruFiles(num2).ID))
							dataRow("DateAdded") = RSWIN_DESC.AllGuruFiles(num2).DateAdded
							dataRow("Original") = RSWIN_DESC.AllGuruFiles(num2).Original
							dataSet.Tables(0).Rows.Add(dataRow)
							Try
								Dim num3 As Integer = oleDbDataAdapter.Update(dataSet, text5)
								count = dataSet.Tables(0).Rows.Count
							Catch ex4 As OleDbException
								MessageBox.Show(ex4.Message)
								Me.Message(" ")
							End Try
						Catch ex5 As Exception
							MessageBox.Show(ex5.Message)
							Me.Message(" ")
						End Try
					Next
					count = dataSet.Tables(0).Rows.Count
					Me.Message(" Encrypted Template Database Created Successfully!")
				Catch ex6 As Exception
					Me.Message(" ")
				End Try
			End If
		End Sub

		Public Sub mnuToolsBatchExportALL_Click(sender As Object, e As EventArgs)
			' The following expression was wrapped in a checked-statement
			Try
				Dim num As Integer = 0
				Dim flag As Boolean = False
				Dim text As String = ""
				Dim msg As String = "Upload ALL RSVX files to Template Database! Are you sure?"
				Dim bDefaultYes As Boolean = True
				Dim gbInputDataChanged As Boolean = False
				If Util.YesNo(msg, bDefaultYes, gbInputDataChanged) Then
					Try
						Dim text2 As String
						FILEUTIL.LocateFile(RSWIN_DESC.sTemplateDBFileName, text2, 2S, True, False, False, False)
						If Operators.CompareString(text2, "", False) <> 0 AndAlso FILEUTIL.FileExists(text2) Then
							Try
								text = text2.Replace(".mdb", "-sav.mdb")
								If FILEUTIL.FileExists(text) Then
									Try
										FileSystem.Kill(text)
									Catch ex As Exception
									End Try
								End If
								Dim fileInfo As FileInfo = New FileInfo(text2)
								fileInfo.CopyTo(text)
								FileSystem.Kill(text2)
							Catch ex2 As Exception
							End Try
						End If
					Catch ex3 As Exception
					End Try
					Dim i As Integer = 0
					Dim array As String()
					Do
						Dim files As String() = Directory.GetFiles(RSWIN_DESC.sExpertFileFolders(i), "*.*")
						Dim num2 As Integer = num
						num = num + files.Length - 1
						array = CType(Utils.CopyArray(CType(array, Array), New String(num + 1 - 1) {}), String())
						Dim num3 As Integer = 0
						Dim num4 As Integer = 0
						Dim num5 As Integer = files.Length - 1
						For j As Integer = num4 To num5
							array(num2 + num3) = files(j)
							num3 += 1
						Next
						i += 1
					Loop While i <= 11
					If num > 0 Then
						Dim fileInfo2 As FileInfo = New FileInfo(RSWIN_DESC.BlankGuruDataBaseFileName)
						Try
							Try
								Dim guruDataBaseFileName As String = RSWIN_DESC.GuruDataBaseFileName
								Dim flag2 As Boolean = FILEUTIL.FileExists(guruDataBaseFileName)
								RSWIN_DESC.GuruDataBaseFileName = guruDataBaseFileName
								If flag2 Then
									FileSystem.Kill(RSWIN_DESC.GuruDataBaseFileName)
								End If
							Catch ex4 As Exception
							End Try
							fileInfo2.CopyTo(RSWIN_DESC.GuruDataBaseFileName)
						Catch ex5 As Exception
						End Try
					End If
					Dim iLast As Integer = Information.UBound(array, 1) + 1
					Dim num6 As Integer = Information.LBound(array, 1)
					Dim num7 As Integer = Information.UBound(array, 1)
					i = num6
					While i <= num7
						Me.SetCaption("")
						If Strings.InStr(array(i).ToLower(), "rsvx", CompareMethod.Binary) > 0 Then
							Dim flag3 As Boolean = False
							Dim array2 As String() = array
							Dim num8 As Integer = i
							Dim rst As cRODSTAR = RSWIN_DESC.rst
							gbInputDataChanged = rst.gbInputDataChanged
							Dim cursor As Cursor
							Me.LoadOneFile(cursor, array2(num8), flag3, gbInputDataChanged, True)
							rst.gbInputDataChanged = gbInputDataChanged
							If flag3 Then
								Debug.WriteLine("Exporting " + Util.FileName(array(i)))
								Me.Message("Exporting " + Util.FileName(array(i)))
								Me.ExportRSVXtoGuruDB(True, False, True, iLast)
								flag = True
							Else
								Me.Message("")
							End If
						End If
						i += 1
					End While
					Me.Message("")
					If flag Then
						Me.Message("File successfully uploaded to template database!")
					End If
				End If
			Catch ex6 As Exception
			End Try
		End Sub

		Public Function SAVEGURUBATCHFILE(rfn As String) As Boolean
			Dim flag As Boolean = False
			Dim flag2 As Boolean = False
			Dim result As Boolean
			If Strings.Len(rfn) > 0 Then
				Util.BusyCursor()
				result = MRodstarXML.StoreXML(rfn, RSWIN_DESC.rst.gbOutputLoaded, flag, flag2)
			Else
				result = False
			End If
			Return result
		End Function

		Public Sub Message(msgtxt As String)
			Try
				Me.panStatus.Text = msgtxt
			Catch ex As Exception
			End Try
		End Sub

		Private Sub PopulateExpertFileFolderNames()
			Try
				RSWIN_DESC.sExpertFileFolders(0) = Application.StartupPath + "\PU-Size-Tables\Conv-Steel"
				RSWIN_DESC.sExpertFileFolders(1) = Application.StartupPath + "\PU-Size-Tables\FG - CONV UNIT"
				RSWIN_DESC.sExpertFileFolders(2) = Application.StartupPath + "\PU-Size-Tables\MarkII-Steel"
				RSWIN_DESC.sExpertFileFolders(3) = Application.StartupPath + "\PU-Size-Tables\FG-MarkII Unit"
				RSWIN_DESC.sExpertFileFolders(4) = Application.StartupPath + "\PU-Size-Tables\Rmark-Steel"
				RSWIN_DESC.sExpertFileFolders(5) = Application.StartupPath + "\PU-Size-Tables\RM-Steel-FG"
				RSWIN_DESC.sExpertFileFolders(6) = Application.StartupPath + "\PU-Size-Tables\Rotaflex-Steel"
				RSWIN_DESC.sExpertFileFolders(7) = Application.StartupPath + "\PU-Size-Tables\Rotaflex-FG-Steel"
				RSWIN_DESC.sExpertFileFolders(8) = Application.StartupPath + "\PU-Size-Tables\Steel-AB Unit"
				RSWIN_DESC.sExpertFileFolders(9) = Application.StartupPath + "\PU-Size-Tables\AB-FG-Steel"
				RSWIN_DESC.sExpertFileFolders(10) = Application.StartupPath + "\PU-Size-Tables\DNP-Steel"
				RSWIN_DESC.sExpertFileFolders(11) = Application.StartupPath + "\PU-Size-Tables\DNP-FG-Steel"
				RSWIN_DESC.sExpertFilePrefixes(0) = "Conv-Steel-"
				RSWIN_DESC.sExpertFilePrefixes(1) = "FG - CONV UNIT-"
				RSWIN_DESC.sExpertFilePrefixes(2) = "MarkII-Steel-"
				RSWIN_DESC.sExpertFilePrefixes(3) = "FG-MARKII UNIT-"
				RSWIN_DESC.sExpertFilePrefixes(4) = "Rmark-Steel-"
				RSWIN_DESC.sExpertFilePrefixes(5) = "RM-Steel-FG-"
				RSWIN_DESC.sExpertFilePrefixes(6) = "Rotaflex-Steel-"
				RSWIN_DESC.sExpertFilePrefixes(7) = "Rotaflex-FG-Steel-"
				RSWIN_DESC.sExpertFilePrefixes(8) = "Steel-AB UNIT-"
				RSWIN_DESC.sExpertFilePrefixes(9) = "AB-FG-Steel "
				RSWIN_DESC.sExpertFilePrefixes(10) = "DNP-Steel-"
				RSWIN_DESC.sExpertFilePrefixes(11) = "DNP-FG-Steel-"
			Catch ex As Exception
			End Try
		End Sub

		Private Sub panStatus_TextChanged(sender As Object, e As EventArgs)
		End Sub

		Public Function AreAllManufacturerPreferencesSame(ByRef bNoUnitPreferences As Boolean) As Boolean
			' The following expression was wrapped in a checked-statement
			Dim result As Boolean
			Try
				Dim flag As Boolean = True
				bNoUnitPreferences = True
				Dim num As Integer = 1
				Do
					If RSWIN_DESC.get_bUsePUManuf(num) Then
						Dim num2 As Integer = 1
						Do
							If RSWIN_DESC.get_bUsePUManuf(num2) Then
								bNoUnitPreferences = False
								If Operators.CompareString(RSWIN_DESC.get_PUManuf(num).Trim(), RSWIN_DESC.get_PUManuf(num2).Trim(), False) <> 0 Then
									flag = False
								End If
							End If
							num2 += 1
						Loop While num2 <= 8
					End If
					num += 1
				Loop While num <= 8
				result = flag
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Function IsAlreadyInList(indx As Integer, bDefault As Boolean) As Boolean
			Dim result As Boolean = bDefault
			If indx > 1 Then
				Dim num As Integer = 0
				Dim num2 As Integer = Information.UBound(Me.sAlreadyFileList, 1)
				For i As Integer = num To num2
					If Operators.CompareString(RSWIN_DESC.get_PUManuf(indx).Trim(), Me.sAlreadyFileList(i).Trim(), False) = 0 Then
						result = Not bDefault
					End If
				Next
			End If
			Return result
		End Function

		Public Sub mnuToolsBatchExportFromOneFolder_Click(sender As Object, e As EventArgs)
			' The following expression was wrapped in a checked-statement
			Try
				Dim num As Integer = 0
				Dim flag As Boolean = False
				Me.dlgSelectDir.Caption = Me.sSelectExportFolder
				Me.dlgSelectDir.Path = Application.StartupPath + "\PU-Size-Tables\"
				Me.ResetClock()
				Me.dlgSelectDir.ShowDialog()
				Dim path As String = Me.dlgSelectDir.Path
				If Operators.CompareString(path, "", False) <> 0 Then
					Dim files As String() = Directory.GetFiles(path, "*.*")
					Dim num2 As Integer = num
					num = num + files.Length - 1
					Dim array As String() = CType(Utils.CopyArray(CType(array, Array), New String(num + 1 - 1) {}), String())
					Dim num3 As Integer = 0
					Dim num4 As Integer = 0
					Dim num5 As Integer = files.Length - 1
					For i As Integer = num4 To num5
						array(num2 + num3) = files(i)
						num3 += 1
					Next
					If num > 0 Then
						Dim fileInfo As FileInfo = New FileInfo(RSWIN_DESC.BlankGuruDataBaseFileName)
						Dim guruDataBaseFileName As String = RSWIN_DESC.GuruDataBaseFileName
						Dim flag2 As Boolean = FILEUTIL.FileExists(guruDataBaseFileName)
						RSWIN_DESC.GuruDataBaseFileName = guruDataBaseFileName
						If flag2 Then
							Try
								Dim text As String = RSWIN_DESC.GuruDataBaseFileName.Replace(".mdb", ".sav")
								FILEUTIL.CopyFile(RSWIN_DESC.GuruDataBaseFileName, text, text, "")
							Catch ex As Exception
							End Try
						End If
					End If
					Dim num6 As Integer = Information.LBound(array, 1)
					Dim num7 As Integer = Information.UBound(array, 1)
					For j As Integer = num6 To num7
						Me.SetCaption("")
						If Strings.InStr(array(j).ToLower(), "rsvx", CompareMethod.Binary) > 0 Then
							Dim flag3 As Boolean = False
							Dim array2 As String() = array
							Dim num8 As Integer = j
							Dim rst As cRODSTAR = RSWIN_DESC.rst
							Dim gbInputDataChanged As Boolean = rst.gbInputDataChanged
							Dim cursor As Cursor
							Me.LoadOneFile(cursor, array2(num8), flag3, gbInputDataChanged, True)
							rst.gbInputDataChanged = gbInputDataChanged
							If flag3 Then
								Me.Message("Exporting " + Util.FileName(array(j)))
								Me.ExportRSVXtoGuruDB(True, False, False, 0)
								flag = True
							Else
								Me.Message("")
							End If
						End If
					Next
					Me.Message("")
					If flag Then
						Me.Message("File successfully uploaded to template database from folder!")
					End If
				End If
			Catch ex2 As Exception
			End Try
		End Sub

		Private Sub tbrAbort_ButtonClick(sender As Object, e As ToolBarButtonClickEventArgs)
			If RSWIN_DESC.bRodStarD Then
				RSWIN_DESC.bAbortRun = True
				Me.ToolbarButtonSetState2(2, False)
				Application.DoEvents()
				Return
			End If
		End Sub

		Public Sub RC4Initialize(strPwd As Object)
			Dim num As Integer = Strings.Len(RuntimeHelpers.GetObjectValue(strPwd))
			Dim num2 As Long = 0L
			Do
				' The following expression was wrapped in a unchecked-expression
				Me.key(CInt(num2)) = Strings.Asc(Strings.Mid(Conversions.ToString(strPwd), CInt((num2 Mod CLng(num) + 1L)), 1))
				Me.sbox(CInt(num2)) = num2
				num2 += 1L
			Loop While num2 <= 255L
			Dim num3 As Long = 0L
			num2 = 0L
			Do
				num3 = Conversions.ToLong(Operators.ModObject(Operators.AddObject(Operators.AddObject(num3, Me.sbox(CInt(num2))), Me.key(CInt(num2))), 256))
				Dim text As String = Conversions.ToString(Me.sbox(CInt(num2)))
				Me.sbox(CInt(num2)) = RuntimeHelpers.GetObjectValue(Me.sbox(CInt(num3)))
				Me.sbox(CInt(num3)) = text
				num2 += 1L
			Loop While num2 <= 255L
		End Sub

		Public Function EnDeCrypt(plaintxt As String) As Object
			Dim strPwd As String = "2349358399323"
			Dim num As Long = 0L
			Dim num2 As Long = 0L
			Me.RC4Initialize(strPwd)
			Dim num3 As Long = 1L
			Dim num4 As Long = CLng(Strings.Len(plaintxt))
			Dim text2 As String
			For num5 As Long = num3 To num4
				num = (num + 1L) Mod 256L
				num2 = Conversions.ToLong(Operators.ModObject(Operators.AddObject(num2, Me.sbox(CInt(num))), 256))
				Dim text As String = Conversions.ToString(Me.sbox(CInt(num)))
				Me.sbox(CInt(num)) = RuntimeHelpers.GetObjectValue(Me.sbox(CInt(num2)))
				Me.sbox(CInt(num2)) = text
				Dim num6 As Long = Conversions.ToLong(Me.sbox(Conversions.ToInteger(Operators.ModObject(Operators.AddObject(Me.sbox(CInt(num)), Me.sbox(CInt(num2))), 256))))
				Dim num7 As Long = CLng(Strings.Asc(Strings.Mid(plaintxt, CInt(num5), 1))) Xor num6
				text2 += Conversions.ToString(Strings.Chr(CInt(num7)))
			Next
			Return text2
		End Function

		Public Function Convert_Encrypt(myVal As Object) As String
			Dim result As String
			Try
				Dim plaintxt As String = Convert.ToString(RuntimeHelpers.GetObjectValue(myVal))
				Dim text As String = Conversions.ToString(Me.EnDeCrypt(plaintxt))
				result = text
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Sub LoadPrefixGuruFiles(prefix As String, ByRef PrefixGuruFiles As RSWIN_DESC.GuruFileDataStructure(), ByRef fMinDiffPumpDepth As Single, ByRef fMinTargetBFPD As Single)
			Dim num As Integer = 0
			Dim array As Single() = New Single(0) {}
			Dim array2 As Single() = New Single(0) {}
			Try
				Dim num2 As Integer = Information.LBound(RSWIN_DESC.AllGuruFiles, 1)
				Dim num3 As Integer = Information.UBound(RSWIN_DESC.AllGuruFiles, 1)
				Dim num4 As Integer = num2
				Dim num5 As Integer = num3
				For i As Integer = num4 To num5
					If RSWIN_DESC.AllGuruFiles(i).FileName IsNot Nothing AndAlso Strings.InStr(RSWIN_DESC.AllGuruFiles(i).FileName.ToLower(), prefix.ToLower(), CompareMethod.Binary) > 0 Then
						num += 1
						PrefixGuruFiles = CType(Utils.CopyArray(CType(PrefixGuruFiles, Array), New RSWIN_DESC.GuruFileDataStructure(num + 1 - 1) {}), RSWIN_DESC.GuruFileDataStructure())
						PrefixGuruFiles(num) = RSWIN_DESC.AllGuruFiles(i)
						array = CType(Utils.CopyArray(CType(array, Array), New Single(num + 1 - 1) {}), Single())
						array(num) = RSWIN_DESC.AllGuruFiles(i).PumpDepth
						array2 = CType(Utils.CopyArray(CType(array2, Array), New Single(num + 1 - 1) {}), Single())
						array2(num) = RSWIN_DESC.AllGuruFiles(i).TargetBFPD
					End If
				Next
				Array.Sort(Of Single)(array)
				fMinDiffPumpDepth = 100000F
				num2 = Information.LBound(array, 1)
				num3 = Information.UBound(array, 1)
				Dim num6 As Integer = num2
				Dim num7 As Integer = num3 - 1
				For i As Integer = num6 To num7

						' The following expression was wrapped in a checked-expression
						' The following expression was wrapped in a checked-expression
						If array(i + 1) - array(i) < fMinDiffPumpDepth And array(i + 1) - array(i) <> 0F Then
							' The following expression was wrapped in a checked-expression
							fMinDiffPumpDepth = array(i + 1) - array(i)
						End If

				Next
				Array.Sort(Of Single)(array2)
				fMinTargetBFPD = 100000F
				num2 = Information.LBound(array2, 1)
				num3 = Information.UBound(array2, 1)
				Dim num8 As Integer = num2
				Dim num9 As Integer = num3 - 1
				For i As Integer = num8 To num9

						' The following expression was wrapped in a checked-expression
						' The following expression was wrapped in a checked-expression
						If array2(i + 1) - array2(i) < fMinTargetBFPD And array2(i + 1) - array2(i) <> 0F Then
							' The following expression was wrapped in a checked-expression
							fMinTargetBFPD = array2(i + 1) - array2(i)
						End If

				Next
			Catch ex As Exception
			End Try
		End Sub

		Public Sub TemplateLoadProcess()
			Try
				RSWIN_DESC.bProcessFinished = False
				GURU_DB.LoadALLGuruFiledata(True)
				RSWIN_DESC.bProcessFinished = True
				Me.Message("XROD-V")
			Catch ex As Exception
				RSWIN_DESC.bGuruFileDataLoaded = False
				RSWIN_DESC.bProcessFinished = True
			End Try
		End Sub

		Private Sub StartTemplateLoadProcess()
			Try
				Dim threadStart As ThreadStart = AddressOf Me.TemplateLoadProcess
				RSWIN_DESC.bGuruFileDataLoaded = False
				Dim start As ThreadStart = threadStart
				RSWIN_DESC.bProcessFinished = False
				Dim thread As Thread = New Thread(start)
				thread.Start()
			Catch ex As Exception
				RSWIN_DESC.bGuruFileDataLoaded = False
				RSWIN_DESC.bProcessFinished = True
			End Try
		End Sub

		Public Sub ReloadAIRunInputs()
			' The following expression was wrapped in a checked-statement
			Try
				If(RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru) AndAlso RSWIN_DESC.rst_save IsNot Nothing Then
					RSWIN_DESC.rst.SetClassDefaults(False)
					RSWIN_DESC.rst = RSWIN_DESC.rst_save
					Dim num As Integer = 1
					Do
						RSWIN_DESC.NewData(num) = 0S
						num += 1
					Loop While num <= 7
					ini.SaveDataValue(RSWIN_DESC.sNull, "")
					ini.SaveDataValue("InProgress", DBNull.Value)
					RSWIN.ReCreateRegKey(RSWIN_DESC.SECT_DATAENTRY)
					Me.ToolbarButtonSetState(0, True)
					Me.ToolbarButtonSetState(1, True)
					Me.ToolbarButtonSetState(2, True)
					Me.ToolbarButtonSetState(8, True)
					Me.ToolbarButtonSetState(9, True)
					Me.ToolbarButtonSetState(10, False)
					Me.tbrToolbar.Buttons(10).Visible = False
					Me.ToolbarButtonSetState(11, False)
					Me.tbrToolbar.Buttons(11).Visible = False
					Me.ToolbarButtonSetState(13, False)
					Me.tbrToolbar.Buttons(13).Visible = False
					Me.ToolbarButtonSetState(14, True)
					Me.ToolbarButtonSetState(15, True)
					Me.ToolbarButtonSetState(16, True)
					Me.ToolbarButtonSetState2(4, True)
					Me.ToolbarButtonSetState2(5, True)
					Me.ToolbarButtonSetState2(0, True)
					Dim text As String = "Successfully loaded file " + RSWIN_DESC.rst.Inputfile
					text += "."
					Me.Message(text)
					Me.SetCaption(RSWIN_DESC.rst.Inputfile)
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub PrepareAIAni()
			Try
				Dim text As String
				FILEUTIL.LocateFile(RSWIN_DESC.sXRODV_AI_mode_running, text, 0S, False, False, False, False)
				If Operators.CompareString(text, "", False) <> 0 Then
					Me.pnlAIavi.Visible = False
					Me.AIavi.Visible = False
					Me.AIavi.FileName = text
					Me.AIavi.Play()
					Application.DoEvents()
					Application.DoEvents()
					Me.AIavi.[Stop]()
					Application.DoEvents()
				End If
			Catch ex As Exception
			End Try
		End Sub

		Public Sub StartAIAni()
			' The following expression was wrapped in a checked-statement
			Try
				Dim text As String = ""
				Application.DoEvents()
				Try
					Dim activeMdiChild As Form = Me.ActiveMdiChild
					If activeMdiChild IsNot Nothing AndAlso activeMdiChild.Visible Then
						Me.RemoveChildForm(activeMdiChild.Name, False)
					End If
				Catch ex As Exception
				End Try
				Application.DoEvents()
				Me.pnlAIavi.Visible = False
				Application.DoEvents()
				FILEUTIL.LocateFile(RSWIN_DESC.sXRODV_AI_mode_running, text, 0S, False, False, False, False)
				If Operators.CompareString(Me.AIavi.FileName, text, False) = 0 Then
					' The following expression was wrapped in a unchecked-expression
					Me.pnlAIavi.Left = CInt(Math.Round(CDbl(Me.Width) / 2.0 - 137.0))
					Me.pnlAIavi.Top = CInt(Math.Round(CDbl(Me.Height) / 2.0 - 137.0))
					Me.pnlAIavi.Height = Me.AIavi.Height + 20
					Me.pnlAIavi.Width = Me.AIavi.Width + 20
					Me.AIavi.Left = 10
					Me.AIavi.Top = 10
					Me.AIavi.FileName = text
					Application.DoEvents()
					Application.DoEvents()
					Me.AIavi.Play()
					Application.DoEvents()
					Application.DoEvents()
					Me.AIavi.Visible = True
					Me.pnlAIavi.Visible = True
					Me.btnGuru.SendToBack()
				End If
				Application.DoEvents()
				Application.DoEvents()
				Application.DoEvents()
				Application.DoEvents()
			Catch ex2 As Exception
			End Try
		End Sub

		Public Sub StopAIAni()
			Try
				Application.DoEvents()
				Application.DoEvents()
				Me.AIavi.Visible = False
				Me.AIavi.[Stop]()
				Me.pnlAIavi.Visible = False
				Me.pnlAIavi.Left = -1333
				Application.DoEvents()
				Application.DoEvents()
				Application.DoEvents()
			Catch ex As Exception
			End Try
		End Sub

		Public Function WaitForProcessToFinishLoading() As Boolean
			Dim result As Boolean
			Try
				Dim num As Integer = 0
				Dim flag As Boolean = False
				Dim now As DateTime = DateAndTime.Now
				While Not RSWIN_DESC.bGuruFileDataLoaded And num < 30 And Not RSWIN_DESC.bProcessFinished
					Application.DoEvents()
					Application.DoEvents()
					Application.DoEvents()
					Application.DoEvents()
					Application.DoEvents()
					Application.DoEvents()
					num = DateAndTime.Now.Subtract(now).Seconds
				End While
				If RSWIN_DESC.bGuruFileDataLoaded Then
					flag = True
				ElseIf num >= 30 Then
					flag = False
				End If
				result = flag
			Catch ex As Exception
				result = False
			End Try
			Return result
		End Function

		Private Sub TryToImproveScore(ByRef iGBScore As Integer, ByRef iRLScore As Integer, ByRef iSLScore As Integer, ByRef iSEffScore As Integer, ByRef iBotMinStressScore As Integer, ByRef iMPRLScore As Integer, fOrigTotalScore As Single)
			Try
				Dim num As Integer = 0
				Dim num2 As Integer = 0
				Dim num3 As Integer = 0
				Dim num4 As Integer = 0
				Dim num5 As Integer = 0
				Dim num6 As Integer = 0
				Dim text As String = ""
				Dim text2 As String = ""
				Dim rptExpertSummary As rptExpertSummary = New rptExpertSummary()
				Dim flag As Boolean = False
				Dim flag2 As Boolean = False
				Dim flag3 As Boolean = False
				Dim flag4 As Boolean = False
				Dim flag5 As Boolean = False
				RSWIN_DESC.bImprovingScore = True
				If RSWIN_DESC.bExpert And RSWIN_DESC.bRunGuru And RSWIN_DESC.bXRODAdmin And RSWIN_DESC.SETUP_bAdminDebug And Not RSWIN_DESC.bOneGuruFile Then
					flag = True
				End If
				If flag Then
					Batch.BatchMessage("> Original Total Score (Less < 0.98) " + Conversions.ToString(fOrigTotalScore))
					Batch.BatchMessage(String.Concat(New String() { "> Checking Sys. Eff ", Conversions.ToString(RSWIN_DESC.rst.SystemEff), " , TargetBFPD ", Conversions.ToString(RSWIN_DESC.rst.TargetBFPD), " , plunger size ", Conversions.ToString(RSWIN_DESC.rst.PlungerSize) }))
				End If
				Dim num12 As Single
				Dim str As String
				If CDbl(RSWIN_DESC.rst.SystemEff) < 0.45 And RSWIN_DESC.rst.TargetBFPD >= 100F Then
					Dim systemEff As Single = RSWIN_DESC.rst.SystemEff
					Dim num7 As Single = RSWIN_DESC.rst.PlungerSize
					Dim flag6 As Boolean = False
					Dim num8 As Single = Me.GetPlungersize(RSWIN_DESC.rst.PlungerSize, False)
					If Not RSWIN_DESC.SETUP_UseXRODVTubingSizes And RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru Then
						Dim maxCasingSize As Single = RSWIN_DESC.MaxCasingSize
						Dim maxTubingSizeOD As Single = RSWIN_DESC.MaxTubingSizeOD
						Dim num9 As Single
						Dim num10 As Single
						Dim num11 As Single
						RODUTIL.GetSizeFromCasingSize(maxCasingSize, maxTubingSizeOD, num9, num10, num11, False)
						RSWIN_DESC.MaxTubingSizeOD = maxTubingSizeOD
						If num8 > num10 Then
							num8 = num10
						End If
					End If
					Dim plungerSize As Single
					If num8 = -1F Or num8 = 0F Then
						flag6 = True
					ElseIf num8 <> -1F Then
						plungerSize = RSWIN_DESC.rst.PlungerSize
						RSWIN_DESC.rst.PlungerSize = num8
						If flag Then
							Batch.BatchMessage("> Try larger Plunger Size  " + num8.ToString())
						End If
						Dim flag7 As Boolean = DESIGN.Design()
						Dim bCheckToAdd As Boolean = False
						Dim flag8 As Boolean = False
						str = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num12, bCheckToAdd, flag2, flag8, False, False)
						If flag Then
							Batch.BatchMessage("> new sys eff score: " + num4.ToString() + " , new sys eff: " + Conversions.ToString(RSWIN_DESC.rst.SystemEff))
						End If
						flag6 = (RSWIN_DESC.bFGUnderTravel OrElse (Not(num12 > fOrigTotalScore And (num4 > iSEffScore Or RSWIN_DESC.rst.SystemEff > systemEff)) AndAlso (num4 <= iSEffScore Or (num4 > iSEffScore And num12 <= fOrigTotalScore))))
					End If
					If flag6 Then
						If flag Then
							Batch.BatchMessage("> Score not improved! Revert to original plungersize.")
						End If
						If num7 = 0F And plungerSize <> 0F Then
							num7 = plungerSize
						End If
						RSWIN_DESC.rst.PlungerSize = num7
						Dim flag7 As Boolean = DESIGN.Design()
						Dim bCheckToAdd2 As Boolean = False
						Dim flag8 As Boolean = False
						str = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num12, bCheckToAdd2, flag2, flag8, False, False)
					End If
				ElseIf flag Then
					Batch.BatchMessage("> Sys. Eff OK ")
				End If
				Dim hsgradeRod As Short = RSWIN_DESC.HSGradeRod
				Dim flag9 As Boolean = Me.CheckAIRodLoading(flag)
				Dim unitID As String = RSWIN_DESC.rst.UnitID
				Dim pu As RSWIN_DESC.PUDataRec
				pu.Initialize()
				pu = RSWIN_DESC.rst.PU
				Dim num13 As Single = RSWIN_DESC.rst.GearboxLoading(RSWIN_DESC.i2Score)
				Dim structL As Single = RSWIN_DESC.rst.StructL
				Dim flag10 As Boolean = False
				If flag Then
					Dim array As String() = New String(9) {}
					array(0) = "> Checking GB ( "
					array(1) = RSWIN_DESC.rst.GearboxLoading(RSWIN_DESC.i2Score).ToString()
					array(2) = " , unit "
					array(3) = RSWIN_DESC.rst.UnitID
					array(4) = " , "
					array(5) = Conversions.ToString(RSWIN_DESC.rst.PU.GearboxRating)
					array(6) = "-"
					Dim array2 As String() = array
					Dim num14 As Integer = 7
					Dim pu2 As RSWIN_DESC.PUDataRec = RSWIN_DESC.rst.PU
					array2(num14) = Conversions.ToString(pu2.StructRating)
					array(8) = "-"
					array(9) = Conversions.ToString(RSWIN_DESC.rst.PU.MaxStroke)
					Batch.BatchMessage(String.Concat(array))
				End If
				Dim num15 As Single
				Dim pu4 As RSWIN_DESC.PUDataRec
				Dim flag13 As Boolean
				If CDbl(num13) < 0.7 Or CDbl(num13) > 0.95 Then
					Dim flag11 As Boolean = True
					text = ""
					While flag11
						Dim bCheckToAdd3 As Boolean = False
						Dim flag8 As Boolean = False
						str = RSWIN.TotalExpertScore(iGBScore, iRLScore, iSLScore, iSEffScore, iBotMinStressScore, iMPRLScore, num15, bCheckToAdd3, flag2, flag8, False, False)
						flag10 = True
						Dim text3 As String = text2
						text2 = text
						Dim gearboxRating As Single = RSWIN_DESC.rst.PU.GearboxRating
						Dim pu2 As RSWIN_DESC.PUDataRec = RSWIN_DESC.rst.PU
						Dim structRating As Single = pu2.StructRating
						Dim maxStroke As Single = RSWIN_DESC.rst.PU.MaxStroke
						flag8 = False
						Dim flag12 As Boolean = False
						flag13 = False
						Dim flag14 As Boolean = PUDATA1.AdjustGearboxForScore(gearboxRating, structRating, maxStroke, text, flag3, flag4, flag8, flag12, flag13, False, RSWIN_DESC.SETUP_TimesAvgRodTBGFricCoeff > 1F)
						If Operators.CompareString(text3, text, False) = 0 Then
							Debug.WriteLine("Here")
						End If
						If flag14 And Operators.CompareString(text, "", False) <> 0 And Operators.CompareString(text2, text, False) <> 0 And Operators.CompareString(text3, text, False) <> 0 Then
							Dim maxStroke2 As Single = RSWIN_DESC.rst.PU.MaxStroke
							unitID = RSWIN_DESC.rst.UnitID
							pu.Initialize()
							pu = RSWIN_DESC.rst.PU
							Dim crankHole As Short = RSWIN_DESC.rst.PU.CrankHole
							Dim crankRotation As Short = RSWIN_DESC.rst.PU.CrankRotation
							RSWIN_DESC.rst.UnitID = text
							Me.ReRunWithNewUnitID(text, True, False, True)
							If flag Then
								Dim array As String() = New String(13) {}
								array(0) = ">New GB Load: "
								array(1) = RSWIN_DESC.rst.GearboxLoading(RSWIN_DESC.i2Score).ToString()
								array(2) = " , unit "
								array(3) = RSWIN_DESC.rst.UnitID
								array(4) = " , "
								array(5) = Conversions.ToString(RSWIN_DESC.rst.PU.GearboxRating)
								array(6) = "-"
								Dim array3 As String() = array
								Dim num16 As Integer = 7
								Dim pu3 As RSWIN_DESC.PUDataRec = RSWIN_DESC.rst.PU
								array3(num16) = Conversions.ToString(pu3.StructRating)
								array(8) = "-"
								array(9) = Conversions.ToString(RSWIN_DESC.rst.PU.MaxStroke)
								array(10) = " , crankhole: "
								Dim array4 As String() = array
								Dim num17 As Integer = 11
								pu2 = RSWIN_DESC.rst.PU
								array4(num17) = pu2.CrankHole.ToString()
								array(12) = " , stroke: "
								array(13) = RSWIN_DESC.rst.PU.Strokes(CInt((RSWIN_DESC.rst.CrankHole - 1S))).ToString()
								Batch.BatchMessage(String.Concat(array))
							End If
							Dim bCheckToAdd4 As Boolean = False
							flag13 = False
							str = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num12, bCheckToAdd4, flag2, flag13, False, False)
							If flag Then
								' The following expression was wrapped in a unchecked-expression
								Batch.BatchMessage(">New GB Score: " + Conversions.ToString(num) + " , New Total Score: " + Conversions.ToString(num12 * 100F))
							End If
							If num > iGBScore And num2 < iRLScore And num12 < num15 Then
								Dim flag15 As Boolean = Me.TryToImproveRodLoadingScoreOnly(num2, num12, True, num12)
								Dim bCheckToAdd5 As Boolean = False
								flag13 = False
								str = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num12, bCheckToAdd5, flag2, flag13, False, False)
							End If
							Dim flag16 As Boolean = ((num > iGBScore Or (CDbl(RSWIN_DESC.rst.GearboxLoading(RSWIN_DESC.i2Score)) >= 0.7 And CDbl(RSWIN_DESC.rst.GearboxLoading(RSWIN_DESC.i2Score)) <= 0.95) Or (CDbl(RSWIN_DESC.rst.GearboxLoading(RSWIN_DESC.i2Score)) < 0.7 And RSWIN_DESC.rst.GearboxLoading(RSWIN_DESC.i2Score) > num13)) And num12 >= num15) OrElse (num = iGBScore And (RSWIN_DESC.rst.GearboxLoading(RSWIN_DESC.i2Score) > 1F And num13 > 1F) And RSWIN_DESC.rst.GearboxLoading(RSWIN_DESC.i2Score) < num13 And num12 >= num15)
							If flag16 Then
								structL = RSWIN_DESC.rst.StructL
								num13 = RSWIN_DESC.rst.GearboxLoading(RSWIN_DESC.i2Score)
								If(CDbl(num13) < 0.7 Or CDbl(num13) > 0.95) And Operators.CompareString(text2, text, False) <> 0 Then
									If flag Then
										Batch.BatchMessage("> Trying yet another unit")
									End If
									flag11 = True
								Else
									If flag Then
										Batch.BatchMessage("> Keeping new unit")
									End If
									flag11 = False
								End If
							Else
								flag11 = False
								If flag Then
									Batch.BatchMessage("> Reverting to original unit")
								End If
								RSWIN_DESC.rst.UnitID = unitID
								pu4 = pu
								pu4.CrankHole = crankHole
								pu4.CrankRotation = crankRotation
								If pu4.CrankHole > 0S Then
									RSWIN_DESC.rst.CrankHole = pu4.CrankHole
								End If
								If Not(pu4.UnitType = 7S Or pu4.UnitType = 10S) And pu4.CrankHole > 0S Then
									pu4.R = pu4.CrankRadii(CInt((pu4.CrankHole - 1S)))
								Else
									pu4.R = pu4.CrankRadii(0)
								End If
								kinemat.Kinconst(pu4)
								kinemat.Unitstroke(pu4)
								RSWIN_DESC.rst.PU = pu4
								Dim flag7 As Boolean = DESIGN.Design()
								Dim bCheckToAdd6 As Boolean = False
								flag13 = False
								str = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num12, bCheckToAdd6, flag2, flag13, False, False)
								num13 = RSWIN_DESC.rst.GearboxLoading(RSWIN_DESC.i2Score)
								structL = RSWIN_DESC.rst.StructL
							End If
						Else
							flag11 = False
							If flag Then
								Batch.BatchMessage(">Better replacement unit not found!")
							End If
							Dim bCheckToAdd7 As Boolean = False
							flag13 = False
							str = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num12, bCheckToAdd7, flag2, flag13, False, False)
							If(CDbl(RSWIN_DESC.rst.GearboxLoading(RSWIN_DESC.i2Score)) > 0.95 And num < 100) AndAlso RSWIN_DESC.SETUP_bUseAvgRodTBGFricCoeff Then
								Batch.BatchMessage("Unit with larger gearbox rating not found.")
							End If
						End If
					End While
					If flag10 And (Not flag3 And Not flag4 And pu4.CrankHoles > pu4.CrankHole) Then
						Dim flag17 As Boolean = False
						pu4 = RSWIN_DESC.rst.PU
						Dim crankHole As Short = pu4.CrankHole
						Dim num18 As Integer = CInt(crankHole)
						While Not flag17
							pu4.CrankHole += 1S
							If flag Then
								Batch.BatchMessage("> Trying crankhole " + Conversions.ToString(CInt(pu4.CrankHole)) + " to improve GB Score of " + Conversions.ToString(num))
							End If
							If pu4.CrankHole > 0S Then
								RSWIN_DESC.rst.CrankHole = pu4.CrankHole
							End If
							If Not(pu4.UnitType = 7S Or pu4.UnitType = 10S) And pu4.CrankHole > 0S Then
								pu4.R = pu4.CrankRadii(CInt((pu4.CrankHole - 1S)))
							Else
								pu4.R = pu4.CrankRadii(0)
							End If
							kinemat.Kinconst(pu4)
							kinemat.Unitstroke(pu4)
							RSWIN_DESC.rst.PU = pu4
							Dim flag7 As Boolean = DESIGN.Design()
							Dim num19 As Integer = num
							Dim bCheckToAdd8 As Boolean = False
							flag13 = False
							str = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num12, bCheckToAdd8, flag2, flag13, False, False)
							If num > num19 Then
								If flag Then
									Batch.BatchMessage(String.Concat(New String() { "> Keeping crankhole ", Conversions.ToString(CInt(pu4.CrankHole)), " (new GB Score  ", Conversions.ToString(num), ")" }))
								End If
								crankHole = pu4.CrankHole
							Else
								If flag Then
									Batch.BatchMessage(String.Concat(New String() { "> Reverting to  crankhole ", Conversions.ToString(CInt(pu4.CrankHole)), " (new GB Score was ", Conversions.ToString(num), ")" }))
								End If
								flag17 = True
								pu4.CrankHole -= 1S
								crankHole = pu4.CrankHole
								If pu4.CrankHole > 0S Then
									RSWIN_DESC.rst.CrankHole = pu4.CrankHole
								End If
								If Not(pu4.UnitType = 7S Or pu4.UnitType = 10S) And pu4.CrankHole > 0S Then
									pu4.R = pu4.CrankRadii(CInt((pu4.CrankHole - 1S)))
								Else
									pu4.R = pu4.CrankRadii(0)
								End If
								kinemat.Kinconst(pu4)
								kinemat.Unitstroke(pu4)
								RSWIN_DESC.rst.PU = pu4
								flag7 = DESIGN.Design()
								Dim bCheckToAdd9 As Boolean = False
								flag13 = False
								str = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num12, bCheckToAdd9, flag2, flag13, False, False)
							End If
							If Not flag17 AndAlso pu4.CrankHole + 1S > pu4.CrankHoles Then
								flag17 = True
							End If
						End While
						If num18 <> CInt(crankHole) Then
						End If
					End If
				ElseIf flag Then
					Batch.BatchMessage("> GB score =" + Conversions.ToString(iGBScore) + " , Gearboxload=" + Conversions.ToString(num13))
				End If
				If flag Then
					Dim array As String() = New String(7) {}
					array(0) = "> Checking Struct. Load: "
					array(1) = structL.ToString()
					array(2) = " , unit "
					array(3) = Conversions.ToString(RSWIN_DESC.rst.PU.GearboxRating)
					array(4) = "-"
					Dim array5 As String() = array
					Dim num20 As Integer = 5
					Dim pu3 As RSWIN_DESC.PUDataRec = RSWIN_DESC.rst.PU
					array5(num20) = Conversions.ToString(pu3.StructRating)
					array(6) = "-"
					array(7) = Conversions.ToString(RSWIN_DESC.rst.PU.MaxStroke)
					Batch.BatchMessage(String.Concat(array))
				End If
				If CDbl(structL) < 0.7 Or CDbl(structL) > 0.95 Then
					Dim flag11 As Boolean = True
					text2 = RSWIN_DESC.rst.UnitID
					text = ""
					Dim num21 As Integer = 0
					While flag11
						Dim bCheckToAdd10 As Boolean = False
						flag13 = False
						str = RSWIN.TotalExpertScore(iGBScore, iRLScore, iSLScore, iSEffScore, iBotMinStressScore, iMPRLScore, num15, bCheckToAdd10, flag2, flag13, False, False)
						Dim text3 As String = text2
						text2 = text
						Dim text4 As String = text
						Dim iStructure As Integer = CInt(Math.Round(CDbl(RSWIN_DESC.rst.Pprload) * 1.05 / 100.0))
						Dim gearboxRating2 As Single = RSWIN_DESC.rst.PU.GearboxRating
						Dim pu3 As RSWIN_DESC.PUDataRec = RSWIN_DESC.rst.PU
						Dim flag14 As Boolean = PUDATA1.AdjustStructureForScore(gearboxRating2, pu3.StructRating, RSWIN_DESC.rst.PU.MaxStroke, text, flag, flag5, False, False, False, iStructure)
						If Not flag14 Or Operators.CompareString(text, "", False) = 0 Then
							Dim gearboxRating3 As Single = RSWIN_DESC.rst.PU.GearboxRating
							pu3 = RSWIN_DESC.rst.PU
							flag14 = PUDATA1.AdjustStructureForScore(gearboxRating3, pu3.StructRating, RSWIN_DESC.rst.PU.MaxStroke, text, flag, flag5, False, False, CDbl(structL) > 0.95, 0)
						End If
						If flag14 And Operators.CompareString(text, "", False) <> 0 And Operators.CompareString(text2, text, False) <> 0 And Operators.CompareString(text3, text, False) <> 0 Then
							Dim maxStroke2 As Single = RSWIN_DESC.rst.PU.MaxStroke
							unitID = RSWIN_DESC.rst.UnitID
							pu.Initialize()
							pu = RSWIN_DESC.rst.PU
							RSWIN_DESC.rst.UnitID = text
							Dim crankHole As Short = RSWIN_DESC.rst.PU.CrankHole
							Dim crankRotation As Short = RSWIN_DESC.rst.PU.CrankRotation
							Me.ReRunWithNewUnitID(text, Not flag5, False, True)
							Dim bCheckToAdd11 As Boolean = False
							flag13 = False
							str = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num12, bCheckToAdd11, flag2, flag13, False, False)
							If flag Then
								Dim array As String() = New String(11) {}
								array(0) = ">New Struct. Load: "
								Dim array6 As String() = array
								Dim num22 As Integer = 1
								Dim maxTubingSizeOD As Single = RSWIN_DESC.rst.StructL
								array6(num22) = maxTubingSizeOD.ToString()
								array(2) = " , unit "
								array(3) = Conversions.ToString(RSWIN_DESC.rst.PU.GearboxRating)
								array(4) = "-"
								Dim array7 As String() = array
								Dim num23 As Integer = 5
								Dim pu2 As RSWIN_DESC.PUDataRec = RSWIN_DESC.rst.PU
								array7(num23) = Conversions.ToString(pu2.StructRating)
								array(6) = "-"
								array(7) = Conversions.ToString(RSWIN_DESC.rst.PU.MaxStroke)
								array(8) = " , crankhole: "
								Dim array8 As String() = array
								Dim num24 As Integer = 9
								pu3 = RSWIN_DESC.rst.PU
								array8(num24) = pu3.CrankHole.ToString()
								array(10) = " , stroke: "
								array(11) = RSWIN_DESC.rst.PU.Strokes(CInt((RSWIN_DESC.rst.CrankHole - 1S))).ToString()
								Batch.BatchMessage(String.Concat(array))
								Batch.BatchMessage(">New Struct. Score: " + Conversions.ToString(num3) + " , New Total Score: " + Conversions.ToString(num12 * 100F))
							End If
							If num3 > iSLScore And num2 < iRLScore And num12 < num15 Then
								Dim flag15 As Boolean = Me.TryToImproveRodLoadingScoreOnly(num2, num12, True, num12)
								Dim bCheckToAdd12 As Boolean = False
								flag13 = False
								str = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num12, bCheckToAdd12, flag2, flag13, False, False)
							End If
							Dim flag16 As Boolean = ((num3 > iSLScore Or (CDbl(RSWIN_DESC.rst.StructL) >= 0.7 And CDbl(RSWIN_DESC.rst.StructL) <= 0.95) Or (CDbl(RSWIN_DESC.rst.StructL) < 0.7 And RSWIN_DESC.rst.StructL > structL)) And num12 >= num15) OrElse (num3 = iSLScore And (RSWIN_DESC.rst.StructL > 1F And structL > 1F) And RSWIN_DESC.rst.StructL < structL And num12 >= fOrigTotalScore)
							If flag16 Then
								num13 = RSWIN_DESC.rst.GearboxLoading(RSWIN_DESC.i2Score)
								structL = RSWIN_DESC.rst.StructL
								If(CDbl(num13) < 0.7 Or CDbl(num13) > 0.95) And Operators.CompareString(text2, text, False) <> 0 Then
									If flag Then
										Batch.BatchMessage("> Trying yet another unit")
									End If
									flag11 = True
								Else
									If flag Then
										Batch.BatchMessage("> Keeping new unit (" + text + ")")
									End If
									flag11 = False
								End If
							Else
								flag11 = False
								If flag Then
									Batch.BatchMessage("> Reverting to previous unit (" + unitID + ")")
								End If
								RSWIN_DESC.rst.UnitID = unitID
								pu4 = pu
								pu4.CrankHole = crankHole
								pu4.CrankRotation = crankRotation
								If pu4.CrankHole > 0S Then
									RSWIN_DESC.rst.CrankHole = pu4.CrankHole
								End If
								If Not(pu4.UnitType = 7S Or pu4.UnitType = 10S) And pu4.CrankHole > 0S Then
									pu4.R = pu4.CrankRadii(CInt((pu4.CrankHole - 1S)))
								Else
									pu4.R = pu4.CrankRadii(0)
								End If
								kinemat.Kinconst(pu4)
								kinemat.Unitstroke(pu4)
								RSWIN_DESC.rst.PU = pu4
								Dim flag7 As Boolean = DESIGN.Design()
								Dim bCheckToAdd13 As Boolean = False
								flag13 = False
								str = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num12, bCheckToAdd13, flag2, flag13, False, False)
								num13 = RSWIN_DESC.rst.GearboxLoading(RSWIN_DESC.i2Score)
								structL = RSWIN_DESC.rst.StructL
							End If
						Else
							flag11 = False
							If flag Then
								Batch.BatchMessage(">Better unit not found!")
							End If
							Dim bCheckToAdd14 As Boolean = False
							flag13 = False
							str = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num12, bCheckToAdd14, flag2, flag13, False, False)
						End If
						If Operators.CompareString(text3, "", False) <> 0 And Operators.CompareString(text2, "", False) <> 0 And Operators.CompareString(text3, text, False) = 0 And Operators.CompareString(text4, text2, False) = 0 Then
							num21 += 1
							If num21 = 5 Then
								flag11 = False
							End If
						Else
							num21 = 0
						End If
					End While
				End If
				Dim bCheckToAdd15 As Boolean = False
				flag13 = False
				str = RSWIN.TotalExpertScore(iGBScore, iRLScore, iSLScore, iSEffScore, iBotMinStressScore, iMPRLScore, num15, bCheckToAdd15, flag2, flag13, False, False)
				If(Not RSWIN_DESC.rst.PU.RequiredRotation And If((-If((CDbl(num15) < 0.99 > False), 1S, 0S)), 1S, 0S)) <> 0S Then
					If flag Then
						Batch.BatchMessage("> rotating in other direction: " + str)
					End If
					Dim crankRotation As Short = RSWIN_DESC.rst.PU.CrankRotation
					pu4.Initialize()
					pu4 = RSWIN_DESC.rst.PU
					If pu4.CrankRotation = 1S Then
						pu4.CrankRotation = -1S
					Else
						pu4.CrankRotation = 1S
					End If
					kinemat.Kinconst(pu4)
					kinemat.Unitstroke(pu4)
					RSWIN_DESC.rst.PU = pu4
					Dim flag7 As Boolean = DESIGN.Design()
					Dim bCheckToAdd16 As Boolean = False
					Dim flag13 As Boolean = False
					Dim str2 As String = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num12, bCheckToAdd16, flag2, flag13, False, False)
					If flag Then
						Batch.BatchMessage("> new score rotation other direction: " + str2)
					End If
					If num12 <= num15 Then
						If flag Then
							Batch.BatchMessage("> Reverting rotation back")
						End If
						pu4 = RSWIN_DESC.rst.PU
						pu4.CrankRotation = crankRotation
						kinemat.Kinconst(pu4)
						kinemat.Unitstroke(pu4)
						RSWIN_DESC.rst.PU = pu4
						flag7 = DESIGN.Design()
					End If
				End If
				Dim flag18 As Boolean
				str = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num12, False, flag2, flag18, False, False)
				If(num12 > fOrigTotalScore And CDbl(num12) > 0.93) Or (num12 > RSWIN_DESC.fTemplateTotalAIScore And RSWIN_DESC.fTemplateTotalAIScore <> 0F And RSWIN_DESC.SETUP_TimesAvgRodTBGFricCoeff = 1F) Then
					RSWIN_DESC.bAIScoreImproved = True
				Else
					RSWIN_DESC.bAIScoreImproved = False
					If flag9 Then
						num2 = rptExpertSummary.SetMaxRodLoadingScore(flag18)
						If num2 <= iRLScore Then
							RSWIN_DESC.HSGradeRod = hsgradeRod
							Me.SetGuruRodPreferences(False)
							Dim flag14 As Boolean = DESIGN.Design()
						End If
					End If
				End If
				RSWIN_DESC.bImprovingScore = False
			Catch ex As Exception
			End Try
		End Sub

		Private Function TryToImproveRodLoadingScoreOnly(ByRef iRLScore As Integer, fOrigTotalScore As Single, Optional bRevertAll As Boolean = False, Optional ByRef fNewTotalScore As Single = 0F) As Boolean
			' The following expression was wrapped in a checked-statement
			Dim result As Boolean
			Try
				Dim num As Integer = 0
				Dim num2 As Integer = 0
				Dim num3 As Integer = 0
				Dim num4 As Integer = 0
				Dim num5 As Integer = 0
				Dim num6 As Integer = 0
				fNewTotalScore = 0F
				Dim rptExpertSummary As rptExpertSummary = New rptExpertSummary()
				Dim flag As Boolean = False
				Dim flag2 As Boolean = False
				Dim array As RSWIN_DESC.RodSection() = New RSWIN_DESC.RodSection(CInt((RSWIN_DESC.rst.NumRods + 1S)) - 1) {}
				Dim numRods As Integer
				If bRevertAll Then
					Try
						numRods = CInt(RSWIN_DESC.rst.NumRods)
						Dim num7 As Integer = 1
						Dim numRods2 As Integer = CInt(RSWIN_DESC.rst.NumRods)
						For i As Integer = num7 To numRods2
							array(i) = RSWIN_DESC.rst.Sections(i)
						Next
					Catch ex As Exception
						bRevertAll = False
					End Try
				End If
				RSWIN_DESC.bImprovingScore = True
				If RSWIN_DESC.bExpert And RSWIN_DESC.bRunGuru And RSWIN_DESC.bXRODAdmin And RSWIN_DESC.SETUP_bAdminDebug And Not RSWIN_DESC.bOneGuruFile Then
					flag = True
				End If
				If flag Then
					If CDbl(fOrigTotalScore) < 0.98 Then
						Batch.BatchMessage("> Original Total Score (Less < 0.98) = " + Conversions.ToString(fOrigTotalScore))
					Else
						Batch.BatchMessage("> Original Total Score = " + Conversions.ToString(fOrigTotalScore))
					End If
					Batch.BatchMessage(String.Concat(New String() { "> Checking Sys. Eff ", Conversions.ToString(RSWIN_DESC.rst.SystemEff), " , TargetBFPD ", Conversions.ToString(RSWIN_DESC.rst.TargetBFPD), " , plunger size ", Conversions.ToString(RSWIN_DESC.rst.PlungerSize) }))
				End If
				Dim hsgradeRod As Short = RSWIN_DESC.HSGradeRod
				Dim flag3 As Boolean = Me.CheckAIRodLoading(flag)
				Dim bCheckToAdd As Boolean = False
				Dim flag4 As Boolean = False
				Dim text As String = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, fNewTotalScore, bCheckToAdd, flag2, flag4, False, False)
				If(fNewTotalScore >= fOrigTotalScore And CDbl(fNewTotalScore) > 0.93) Or (fNewTotalScore > RSWIN_DESC.fTemplateTotalAIScore And RSWIN_DESC.fTemplateTotalAIScore <> 0F And RSWIN_DESC.SETUP_TimesAvgRodTBGFricCoeff = 1F) Then
					RSWIN_DESC.bAIScoreImproved = True
				Else
					RSWIN_DESC.bAIScoreImproved = False
					If bRevertAll Then
						RSWIN_DESC.rst.NumRods = CShort(numRods)
						Dim num8 As Integer = 1
						Dim numRods3 As Integer = CInt(RSWIN_DESC.rst.NumRods)
						For i As Integer = num8 To numRods3
							RSWIN_DESC.rst.Sections(i) = array(i)
						Next
						If flag3 Then
							Dim flag5 As Boolean
							num2 = rptExpertSummary.SetMaxRodLoadingScore(flag5)
							If num2 <= iRLScore Then
								RSWIN_DESC.HSGradeRod = hsgradeRod
								Me.SetGuruRodPreferences(False)
								Dim flag6 As Boolean = DESIGN.Design()
							End If
						End If
					ElseIf flag3 Then
						Dim flag5 As Boolean
						num2 = rptExpertSummary.SetMaxRodLoadingScore(flag5)
						If num2 <= iRLScore Then
							RSWIN_DESC.HSGradeRod = hsgradeRod
							Me.SetGuruRodPreferences(False)
							Dim flag6 As Boolean = DESIGN.Design()
						End If
					End If
				End If
				RSWIN_DESC.bImprovingScore = False
				result = RSWIN_DESC.bAIScoreImproved
			Catch ex2 As Exception
				result = False
			End Try
			Return result
		End Function

		Private Function GetPlungersize(fPlungersize As Single, bFindPrevious As Boolean) As Single
			Dim array As String() = New String(0) {}
			Dim result As Single = -1F
			Dim num As Short
			Util.LoadMenu("PLUNGER-SIZE-LIST", num, array)
			Dim array2 As Single() = New Single(CInt((num + 1S)) - 1) {}
			Dim num2 As Integer = 0
			Dim num3 As Short = 1S
			Dim num4 As Short = num
			For num5 As Short = num3 To num4
				' The following expression was wrapped in a checked-statement
				If Versioned.IsNumeric(array(CInt(num5))) Then
					num2 += 1
					array2(num2) = CSng(Conversion.Val(array(num2)))
					If array2(num2) = 0F Then
						num2 -= 1
						Exit For
					End If
				End If
			Next
			num = CShort(num2)
			Array.Sort(Of Single)(array2)
			Dim num6 As Short = 1S
			Dim num7 As Short = num
			For num5 As Short = num6 To num7
				Debug.WriteLine(array2(CInt(num5)))
			Next
			Dim num8 As Short = 1S
			Dim num9 As Short = num
			For num5 As Short = num8 To num9
				If bFindPrevious Then
					If array2(CInt(num5)) < fPlungersize Then
						result = array2(CInt(num5))
					End If
				ElseIf array2(CInt(num5)) > fPlungersize Then
					result = array2(CInt(num5))
					Exit For
				End If
			Next
			Return result
		End Function

		Private Function CheckAIRodLoading(bWriteDebugLines As Boolean) As Boolean
			' The following expression was wrapped in a checked-statement
			Dim result As Boolean
			Try
				Dim flag As Boolean = False
				Dim flag2 As Boolean = False
				Dim flag3 As Boolean = False
				Dim array As Integer() = New Integer(CInt((RSWIN_DESC.rst.NumRods + 1S)) - 1) {}
				Dim num As Integer = 0
				Dim num2 As Integer = 0
				Dim num3 As Integer = 0
				Dim num4 As Integer = 0
				Dim num5 As Integer = 0
				Dim num6 As Integer = 0
				Dim num7 As Integer = 0
				Dim num8 As Integer = 0
				Dim num9 As Integer = 0
				Dim num10 As Integer = 0
				Dim num11 As Integer = 0
				Dim num12 As Integer = 0
				Dim flag4 As Boolean = False
				Dim num13 As Short
				Dim num14 As Short
				If RODUTIL.IsCorod(RSWIN_DESC.HSGradeRod) Then
					Dim hsgradeRod As Short = RSWIN_DESC.HSGradeRod
					If hsgradeRod = 12547S OrElse hsgradeRod = 12549S OrElse hsgradeRod = 12550S OrElse hsgradeRod = 12548S Then
						num13 = 12546S
						num14 = 12545S
					ElseIf hsgradeRod = 12802S OrElse hsgradeRod = 12803S OrElse hsgradeRod = 12805S OrElse hsgradeRod = 12806S OrElse hsgradeRod = 13057S OrElse hsgradeRod = 12808S OrElse hsgradeRod = 12807S Then
						num13 = 12801S
						num14 = 12804S
					End If
				ElseIf RODUTIL.IsProRod(CInt(RSWIN_DESC.HSGradeRod)) <> 0 Then
					num13 = 24580S
					num14 = 24579S
				Else
					num13 = 4099S
					num14 = 4098S
				End If
				Dim num15 As Single = 0F
				Dim num16 As Integer = 1
				Dim numRods As Integer = CInt(RSWIN_DESC.rst.NumRods)
				For i As Integer = num16 To numRods
					If RSWIN_DESC.SBGradeRod = 8305S Or RSWIN_DESC.SBGradeRod = 8307S Or RSWIN_DESC.SBGradeRod = 8309S Or RSWIN_DESC.SBGradeRod = 8195S Or RSWIN_DESC.SBGradeRod = 8196S Or RSWIN_DESC.SBGradeRod = 8193S Or RSWIN_DESC.SBGradeRod = 8194S Then
						flag2 = True
						If RSWIN_DESC.rst.StressL(i) > num15 Then
							num15 = RSWIN_DESC.rst.StressL(i)
						End If
					End If
				Next
				Dim num17 As Single = num15
				If flag2 And num17 > 0F Then
					If bWriteDebugLines Then
						If CDbl(num17) < 0.95 And num17 > 0F Then
							Batch.BatchMessage("> Checking Sinkerbar Stress: " + Conversions.ToString(num17))
						Else
							Batch.BatchMessage("> Checking Sinkerbar Stress: high : " + Conversions.ToString(num17))
						End If
					End If
					If CDbl(num17) > 0.95 AndAlso (RSWIN_DESC.SBGradeRod = 8305S Or RSWIN_DESC.SBGradeRod = 8307S Or RSWIN_DESC.SBGradeRod = 8309S Or RSWIN_DESC.SBGradeRod = 8195S Or RSWIN_DESC.SBGradeRod = 8196S Or RSWIN_DESC.SBGradeRod = 8193S Or RSWIN_DESC.SBGradeRod = 8194S) Then
						If bWriteDebugLines Then
							Batch.BatchMessage("> Changing to no neck")
						End If
						Dim sbgradeRod As Short = RSWIN_DESC.SBGradeRod
						If sbgradeRod = 8195S Then
							RSWIN_DESC.SBGradeRod = 8199S
						ElseIf sbgradeRod = 8196S Then
							RSWIN_DESC.SBGradeRod = 8200S
						ElseIf sbgradeRod = 8193S Then
							RSWIN_DESC.SBGradeRod = 8197S
						ElseIf sbgradeRod = 8194S Then
							RSWIN_DESC.SBGradeRod = 8198S
						ElseIf sbgradeRod = 8305S Then
							RSWIN_DESC.SBGradeRod = 8306S
						ElseIf sbgradeRod = 8307S Then
							RSWIN_DESC.SBGradeRod = 8308S
						ElseIf sbgradeRod = 8309S Then
							RSWIN_DESC.SBGradeRod = 8310S
						End If
						Me.SetGuruRodPreferences(True)
						Dim flag5 As Boolean = DESIGN.Design()
						num15 = 0F
						Dim num18 As Integer = 1
						Dim numRods2 As Integer = CInt(RSWIN_DESC.rst.NumRods)
						For i As Integer = num18 To numRods2
							If(RSWIN_DESC.SBGradeRod = 8199S Or RSWIN_DESC.SBGradeRod = 8200S Or RSWIN_DESC.SBGradeRod = 8197S Or RSWIN_DESC.SBGradeRod = 8198S) AndAlso RSWIN_DESC.rst.StressL(i) > num15 Then
								num15 = RSWIN_DESC.rst.StressL(i)
							End If
						Next
						num17 = num15
						If bWriteDebugLines Then
							Batch.BatchMessage("> New Sinkerbar (NN) Stress " + Conversions.ToString(num17))
						End If
					End If
				End If
				Dim hsgradeRod2 As Short
				Dim rsmaxSize As Single
				Dim rsminSize As Single
				Try
					hsgradeRod2 = RSWIN_DESC.HSGradeRod
					rsmaxSize = RSWIN_DESC.rst.RSMaxSize
					rsminSize = RSWIN_DESC.rst.RSMinSize
				Catch ex As Exception
				End Try
				Dim bCheckToAdd As Boolean = False
				Dim flag6 As Boolean = False
				Dim num19 As Single
				Dim text As String = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num19, bCheckToAdd, flag4, flag6, False, False)
				num15 = 0F
				Dim num20 As Integer = 0
				Dim num21 As Integer = 1
				Dim numRods3 As Integer = CInt(RSWIN_DESC.rst.NumRods)
				For i As Integer = num21 To numRods3
					If(RSWIN_DESC.rst.Sections(i).TensileStrength > 115000F And RSWIN_DESC.rst.Sections(i).TensileStrength <= 145000F) AndAlso RSWIN_DESC.rst.StressL(i) > num15 Then
						flag = True
						num15 = RSWIN_DESC.rst.StressL(i)
						num20 += 1
						array(num20) = i
					End If
				Next
				Dim num22 As Single = num15
				If bWriteDebugLines Then
					If num22 = 0F Then
						Batch.BatchMessage("> Checking Rod Loading: No HS in template ")
					Else
						Batch.BatchMessage("> Checking Rod Loading: Stress using HS Rod preference = " + Conversions.ToString(num22))
					End If
				End If
				If flag Then
					If CDbl(num22) >= 0.75 Then
						If bWriteDebugLines AndAlso CDbl(num22) <= 1.0 Then
							Batch.BatchMessage("> Keeping HS Rod")
						End If
						If num22 > 1F Then
							RODUTIL.TryLargerHSDiameter(num20, array, bWriteDebugLines)
							Dim num23 As Single = Me.GetPlungersize(RSWIN_DESC.rst.PlungerSize, True)
							If Not RSWIN_DESC.SETUP_UseXRODVTubingSizes And RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru And num23 <> -1F And num23 <> 0F Then
								Dim num24 As Single
								num23 = num24
								Dim maxCasingSize As Single = RSWIN_DESC.MaxCasingSize
								Dim maxTubingSizeOD As Single = RSWIN_DESC.MaxTubingSizeOD
								Dim num25 As Single
								Dim num26 As Single
								RODUTIL.GetSizeFromCasingSize(maxCasingSize, maxTubingSizeOD, num25, num24, num26, False)
								RSWIN_DESC.MaxTubingSizeOD = maxTubingSizeOD
								If num23 > num24 Then
									num23 = num24
								End If
							End If
							If num23 <> -1F And num23 <> 0F Then
								Dim bCheckToAdd2 As Boolean = False
								flag6 = False
								text = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num19, bCheckToAdd2, flag4, flag6, False, False)
								Dim plungerSize As Single = RSWIN_DESC.rst.PlungerSize
								RSWIN_DESC.rst.PlungerSize = num23
								If bWriteDebugLines Then
									Batch.BatchMessage("> HS overloaded, trying smaller Plunger Size  " + num23.ToString())
								End If
								Dim flag5 As Boolean = DESIGN.Design()
								Dim bCheckToAdd3 As Boolean = False
								flag6 = False
								Dim num27 As Single
								text = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num27, bCheckToAdd3, flag4, flag6, False, False)
								Dim flag7 As Boolean
								If RSWIN_DESC.bFGUnderTravel Then
									flag7 = True
								ElseIf num27 > num19 Then
									If bWriteDebugLines Then
										Batch.BatchMessage("> Keeping smaller plunger size")
									End If
									flag7 = False
								Else
									flag7 = True
								End If
								If flag7 Then
									If bWriteDebugLines Then
										Batch.BatchMessage("> Revert to larger plunger size")
									End If
									RSWIN_DESC.rst.PlungerSize = plungerSize
									flag5 = DESIGN.Design()
									Dim bCheckToAdd4 As Boolean = False
									flag6 = False
									text = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num19, bCheckToAdd4, flag4, flag6, False, False)
								End If
							End If
						End If
					ElseIf flag And CDbl(num22) < 0.75 Then
						flag3 = True
						RSWIN_DESC.HSGradeRod = num13
						Dim num28 As Single = CSng(RSWIN_DESC.rst.RSGrade)
						RSWIN_DESC.rst.RSGrade = num13
						Me.SetGuruRodPreferences(True)
						Dim flag5 As Boolean = DESIGN.Design()
						num15 = 0F
						Dim num29 As Integer = 1
						Dim numRods4 As Integer = CInt(RSWIN_DESC.rst.NumRods)
						For i As Integer = num29 To numRods4
							If RSWIN_DESC.rst.Sections(i).Grade = num13 And RSWIN_DESC.rst.StressL(i) > num15 Then
								num15 = RSWIN_DESC.rst.StressL(i)
							End If
						Next
						Dim num30 As Single = num15
						If bWriteDebugLines Then
							Batch.BatchMessage("> Run with " + RODUTIL.RodGrade(num13) + ": rod stress = " + Conversions.ToString(num30))
						End If
						Dim bCheckToAdd5 As Boolean = False
						flag6 = False
						Dim num27 As Single
						Dim text2 As String = RSWIN.TotalExpertScore(num7, num8, num9, num10, num11, num12, num27, bCheckToAdd5, flag4, flag6, False, False)
						If CDbl(num30) >= 0.75 And CDbl(num30) <= 0.95 And num19 <= num27 Then
							If bWriteDebugLines Then
								Batch.BatchMessage("> Keeping " + RODUTIL.RodGrade(num13) + "")
							End If
						ElseIf CDbl(num30) > 0.95 Or num19 > num27 Then
							flag3 = False
							RSWIN_DESC.HSGradeRod = hsgradeRod2
							RSWIN_DESC.rst.RSMaxSize = rsmaxSize
							RSWIN_DESC.rst.RSMinSize = rsminSize
							RSWIN_DESC.rst.RSGrade = CShort(Math.Round(CDbl(num28)))
							Me.SetGuruRodPreferences(True)
							flag5 = DESIGN.Design()
							If bWriteDebugLines Then
								Batch.BatchMessage("> Reverting to HS rod")
							End If
						ElseIf CDbl(num30) < 0.75 Then
							flag3 = True
							RSWIN_DESC.HSGradeRod = num14
							Me.SetGuruRodPreferences(True)
							flag5 = DESIGN.Design()
							num15 = 0F
							Dim num31 As Integer = 1
							Dim numRods5 As Integer = CInt(RSWIN_DESC.rst.NumRods)
							For i As Integer = num31 To numRods5
								If RSWIN_DESC.rst.Sections(i).Grade = num14 And RSWIN_DESC.rst.StressL(i) > num15 Then
									num15 = RSWIN_DESC.rst.StressL(i)
								End If
							Next
							Dim num32 As Single = num15
							If bWriteDebugLines Then
								Batch.BatchMessage("> Run with " + RODUTIL.RodGrade(num14) + ": rod stress = " + Conversions.ToString(num32))
							End If
							If CDbl(num32) > 0.95 Then
								flag3 = True
								RSWIN_DESC.HSGradeRod = num13
								RSWIN_DESC.rst.RSGrade = num13
								Me.SetGuruRodPreferences(True)
								flag5 = DESIGN.Design()
								If bWriteDebugLines Then
									Batch.BatchMessage("> Reverting to " + RODUTIL.RodGrade(num13) + "")
								End If
							ElseIf bWriteDebugLines Then
								Batch.BatchMessage("> Keeping " + RODUTIL.RodGrade(num14) + "")
							End If
						End If
					End If
				Else
					num15 = 0F
					Dim num33 As Integer = 1
					Dim flag8 As Boolean = False
					Dim flag9 As Boolean = False
					Dim flag10 As Boolean = False
					Dim num34 As Integer = 1
					Dim numRods6 As Integer = CInt(RSWIN_DESC.rst.NumRods)
					Dim grade As Short
					For i As Integer = num34 To numRods6
						' The following expression was wrapped in a unchecked-expression
						If If((-If((RSWIN_DESC.rst.StressL(i) > num15 > False), 1, 0)), 1, 0) And (RODUTIL.IsSteel(CInt(RSWIN_DESC.rst.Sections(i).Grade)) Or If((-If((CUSTOMRG.IsOtherSteel(CInt(RSWIN_DESC.rst.Sections(i).Grade)) > False), 1, 0)), 1, 0)) <> 0 Then
							If RSWIN_DESC.rst.Sections(i).Grade = num13 Then
								flag9 = True
							ElseIf RSWIN_DESC.rst.Sections(i).Grade = num14 Then
								flag10 = True
							End If
							num15 = RSWIN_DESC.rst.StressL(i)
							num33 = i
							flag8 = True
							grade = RSWIN_DESC.rst.Sections(i).Grade
						End If
					Next
					Dim num30 As Single = num15
					grade = RSWIN_DESC.rst.Sections(num33).Grade
					Dim num28 As Single = CSng(RSWIN_DESC.rst.RSGrade)
					If grade = num14 Or grade = 4098S Or (flag10 And Not flag9) Then
						If CDbl(num15) <= 0.95 Then
							If bWriteDebugLines Then
								Batch.BatchMessage("> Template has " + RODUTIL.RodGrade(grade) + ":  rod stress = " + Conversions.ToString(num15))
							End If
						Else
							If bWriteDebugLines Then
								Batch.BatchMessage(String.Concat(New String() { "> Template has ", RODUTIL.RodGrade(grade), ": rod stress = ", Conversions.ToString(num15), " , trying ", RODUTIL.RodGrade(num13) }))
							End If
							RSWIN_DESC.rst.RSGrade = num13
							rsmaxSize = RSWIN_DESC.rst.RSMaxSize
							rsminSize = RSWIN_DESC.rst.RSMinSize
							RSWIN_DESC.rst.RSMaxSize = RODUTIL.SetGuruRodDiameter(CInt(RSWIN_DESC.rst.RSGrade), RSWIN_DESC.rst.RSMaxSize)
							RSWIN_DESC.rst.RSMinSize = RODUTIL.SetGuruRodDiameter(CInt(RSWIN_DESC.rst.RSGrade), RSWIN_DESC.rst.RSMinSize)
							Dim flag5 As Boolean = DESIGN.Design()
							num15 = 0F
							Dim num35 As Integer = 1
							Dim numRods7 As Integer = CInt(RSWIN_DESC.rst.NumRods)
							For i As Integer = num35 To numRods7
								If RSWIN_DESC.rst.Sections(i).Grade = num13 AndAlso RSWIN_DESC.rst.StressL(i) > num15 Then
									num15 = RSWIN_DESC.rst.StressL(i)
								End If
							Next
							num30 = num15
							If bWriteDebugLines Then
								Batch.BatchMessage("> Run with " + RODUTIL.RodGrade(num13) + ": rod stress = " + Conversions.ToString(num30))
							End If
							If CDbl(num30) > 0.95 Then
								If bWriteDebugLines Then
									Batch.BatchMessage("> Trying High Strength")
								End If
								If RSWIN_DESC.HSGradeRod = num13 Then
									Dim objectValue As Object = RuntimeHelpers.GetObjectValue(ini.GetPreferenceDataValue("HSGradeRod", 3, 4101))
									If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)) Then
										RSWIN_DESC.HSGradeRod = Conversions.ToShort(objectValue)
										RSWIN_DESC.HSRodType = RODUTIL.RodGrade(RSWIN_DESC.HSGradeRod)
									End If
								End If
								Dim num36 As Integer = 1
								Dim numRods8 As Integer = CInt(RSWIN_DESC.rst.NumRods)
								For i As Integer = num36 To numRods8
									If RSWIN_DESC.rst.Sections(i).Grade = num13 Or RSWIN_DESC.rst.Sections(i).Grade = 4099S Then
										RSWIN_DESC.rst.Sections(i).Grade = RSWIN_DESC.HSGradeRod
									End If
								Next
								RSWIN_DESC.rst.RSGrade = RSWIN_DESC.HSGradeRod
								rsmaxSize = RSWIN_DESC.rst.RSMaxSize
								rsminSize = RSWIN_DESC.rst.RSMinSize
								RSWIN_DESC.rst.RSMaxSize = RODUTIL.SetGuruRodDiameter(CInt(RSWIN_DESC.rst.RSGrade), RSWIN_DESC.rst.RSMaxSize)
								RSWIN_DESC.rst.RSMinSize = RODUTIL.SetGuruRodDiameter(CInt(RSWIN_DESC.rst.RSGrade), RSWIN_DESC.rst.RSMinSize)
								flag5 = DESIGN.Design()
								num15 = 0F
								Dim num37 As Integer = 1
								Dim numRods9 As Integer = CInt(RSWIN_DESC.rst.NumRods)
								For i As Integer = num37 To numRods9
									If RSWIN_DESC.rst.Sections(i).Grade = RSWIN_DESC.HSGradeRod AndAlso RSWIN_DESC.rst.StressL(i) > num15 Then
										num15 = RSWIN_DESC.rst.StressL(i)
									End If
								Next
								If bWriteDebugLines Then
									Batch.BatchMessage("> Run with " + RODUTIL.RodGrade(RSWIN_DESC.HSGradeRod) + ": rod stress = " + Conversions.ToString(num15))
									Batch.BatchMessage("> Keeping " + RODUTIL.RodGrade(RSWIN_DESC.HSGradeRod) + " ")
								End If
							End If
						End If
					ElseIf Not flag8 Then
						If bWriteDebugLines Then
							Batch.BatchMessage("> Template has " + RODUTIL.RodGrade(grade))
						End If
					ElseIf CDbl(num30) > 0.95 Then
						If bWriteDebugLines Then
							Batch.BatchMessage(String.Concat(New String() { "> Template has ", RODUTIL.RodGrade(grade), ": rod stress = ", Conversions.ToString(num30), " , trying High Strength" }))
						End If
						If RSWIN_DESC.HSGradeRod = num13 Then
							Dim objectValue2 As Object = RuntimeHelpers.GetObjectValue(ini.GetPreferenceDataValue("HSGradeRod", 3, 4101))
							If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue2)) Then
								RSWIN_DESC.HSGradeRod = Conversions.ToShort(objectValue2)
								RSWIN_DESC.HSRodType = RODUTIL.RodGrade(RSWIN_DESC.HSGradeRod)
							End If
						End If
						Dim num38 As Integer = 1
						Dim numRods10 As Integer = CInt(RSWIN_DESC.rst.NumRods)
						For i As Integer = num38 To numRods10
							If RSWIN_DESC.rst.Sections(i).Grade = num13 Or RSWIN_DESC.rst.Sections(i).Grade = 4099S Then
								RSWIN_DESC.rst.Sections(i).Grade = RSWIN_DESC.HSGradeRod
							End If
						Next
						RSWIN_DESC.rst.RSGrade = RSWIN_DESC.HSGradeRod
						rsmaxSize = RSWIN_DESC.rst.RSMaxSize
						rsminSize = RSWIN_DESC.rst.RSMinSize
						RSWIN_DESC.rst.RSMaxSize = RODUTIL.SetGuruRodDiameter(CInt(RSWIN_DESC.rst.RSGrade), RSWIN_DESC.rst.RSMaxSize)
						RSWIN_DESC.rst.RSMinSize = RODUTIL.SetGuruRodDiameter(CInt(RSWIN_DESC.rst.RSGrade), RSWIN_DESC.rst.RSMinSize)
						Dim flag5 As Boolean = DESIGN.Design()
						num15 = 0F
						Dim num39 As Integer = 1
						Dim numRods11 As Integer = CInt(RSWIN_DESC.rst.NumRods)
						For i As Integer = num39 To numRods11
							If RSWIN_DESC.rst.Sections(i).Grade = RSWIN_DESC.HSGradeRod AndAlso RSWIN_DESC.rst.StressL(i) > num15 Then
								num15 = RSWIN_DESC.rst.StressL(i)
							End If
						Next
						If bWriteDebugLines Then
							Batch.BatchMessage("> Run with " + RODUTIL.RodGrade(RSWIN_DESC.HSGradeRod) + ": rod stress = " + Conversions.ToString(num15))
							Batch.BatchMessage("> Keeping " + RODUTIL.RodGrade(RSWIN_DESC.HSGradeRod) + " ")
						End If
					ElseIf CDbl(num30) >= 0.75 And CDbl(num30) <= 0.95 Then
						If bWriteDebugLines Then
							Batch.BatchMessage("> Template has " + RODUTIL.RodGrade(grade) + ": rod stress = " + Conversions.ToString(num30))
						End If
					ElseIf CDbl(num30) < 0.75 Then
						If bWriteDebugLines Then
							Batch.BatchMessage(String.Concat(New String() { "> Template has ", RODUTIL.RodGrade(grade), ": Less: rod stress = ", Conversions.ToString(num30), "> Trying ", RODUTIL.RodGrade(num14), "" }))
						End If
						Dim num40 As Integer = 1
						Dim numRods12 As Integer = CInt(RSWIN_DESC.rst.NumRods)
						For i As Integer = num40 To numRods12
							If RSWIN_DESC.rst.Sections(i).Grade = grade Or RSWIN_DESC.rst.Sections(i).Grade = 4099S Then
								RSWIN_DESC.rst.Sections(i).Grade = num14
							End If
						Next
						RSWIN_DESC.rst.RSGrade = num14
						rsmaxSize = RSWIN_DESC.rst.RSMaxSize
						rsminSize = RSWIN_DESC.rst.RSMinSize
						RSWIN_DESC.rst.RSMaxSize = RODUTIL.SetGuruRodDiameter(CInt(RSWIN_DESC.rst.RSGrade), RSWIN_DESC.rst.RSMaxSize)
						RSWIN_DESC.rst.RSMinSize = RODUTIL.SetGuruRodDiameter(CInt(RSWIN_DESC.rst.RSGrade), RSWIN_DESC.rst.RSMinSize)
						Dim flag5 As Boolean = DESIGN.Design()
						num15 = 0F
						Dim num41 As Integer = 1
						Dim numRods13 As Integer = CInt(RSWIN_DESC.rst.NumRods)
						For i As Integer = num41 To numRods13
							If RSWIN_DESC.rst.Sections(i).Grade = num14 AndAlso RSWIN_DESC.rst.StressL(i) > num15 Then
								num15 = RSWIN_DESC.rst.StressL(i)
							End If
						Next
						Dim num32 As Single = num15
						If bWriteDebugLines Then
							Batch.BatchMessage("> Run with " + RODUTIL.RodGrade(num14) + ": rod stress = " + Conversions.ToString(num32))
						End If
						If CDbl(num32) > 0.95 Then
							Dim num42 As Integer = 1
							Dim numRods14 As Integer = CInt(RSWIN_DESC.rst.NumRods)
							For i As Integer = num42 To numRods14
								If RSWIN_DESC.rst.Sections(i).Grade = num14 Then
									RSWIN_DESC.rst.Sections(i).Grade = grade
								End If
							Next
							If bWriteDebugLines Then
								Batch.BatchMessage("> Reverting to (" + RODUTIL.RodGrade(grade))
							End If
							RSWIN_DESC.rst.RSGrade = CShort(Math.Round(CDbl(num28)))
							RSWIN_DESC.rst.RSMaxSize = rsmaxSize
							RSWIN_DESC.rst.RSMinSize = rsminSize
							flag5 = DESIGN.Design()
						ElseIf bWriteDebugLines Then
							Batch.BatchMessage("> Keeping " + RODUTIL.RodGrade(num14) + " ")
						End If
					End If
				End If
				result = flag3
			Catch ex2 As Exception
				result = False
			End Try
			Return result
		End Function

		Private Function SetStartPoint(TargetBFPD As Object) As Object
			' The following expression was wrapped in a checked-statement
			Dim result As Object
			Try
				Dim num As Integer = Conversions.ToInteger(Operators.SubtractObject(TargetBFPD, 400))
				If num < 0 Then
					num = 0
				Else
					num -= num Mod 100
					If num < 0 Then
						num = 0
					End If
				End If
				result = num
			Catch ex As Exception
				result = 0
			End Try
			Return result
		End Function

		Private Sub CheckForHKeyLocalAndMove()
			' The following expression was wrapped in a checked-statement
			Try
				Dim flag As Boolean = True
				Dim flag2 As Boolean = True
				Dim flag3 As Boolean = False
				Dim registryKey As RegistryKey
				Try
					registryKey = Registry.LocalMachine.OpenSubKey(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Software\", RSWIN_DESC.sOldThetaName), "\"), RSWIN_DESC.SECT_PROGWIN32)))
				Catch ex As Exception
					registryKey = Nothing
				End Try
				Dim registryKey2 As RegistryKey
				Try
					registryKey2 = Registry.CurrentUser.OpenSubKey(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Software\", RSWIN_DESC.sOldThetaName), "\"), RSWIN_DESC.SECT_PROGWIN32)))
				Catch ex2 As Exception
					registryKey2 = Nothing
				End Try
				If registryKey IsNot Nothing And registryKey2 Is Nothing Then
					Try
						Registry.CurrentUser.CreateSubKey(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Software\", RSWIN_DESC.sOldThetaName), "\"), RSWIN_DESC.SECT_PROGWIN32)))
					Catch ex3 As Exception
						flag = False
					End Try
					If flag Then
						Try
							registryKey2 = Registry.CurrentUser.OpenSubKey(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Software\", RSWIN_DESC.sOldThetaName), "\"), RSWIN_DESC.SECT_PROGWIN32)))
						Catch ex4 As Exception
							flag2 = False
						End Try
						If flag2 Then
							If registryKey.SubKeyCount > 0 Then
								Dim subKeyNames As String() = registryKey.GetSubKeyNames()
								If subKeyNames.Length > 0 Then
									Dim num As Integer = Information.LBound(subKeyNames, 1)
									Dim num2 As Integer = Information.UBound(subKeyNames, 1)
									For i As Integer = num To num2
										Dim registryKey3 As RegistryKey = Registry.LocalMachine.OpenSubKey(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Software\", RSWIN_DESC.sOldThetaName), "\"), RSWIN_DESC.SECT_PROGWIN32), "\"), subKeyNames(i))))
										Try
											Registry.CurrentUser.CreateSubKey(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Software\", RSWIN_DESC.sOldThetaName), "\"), RSWIN_DESC.SECT_PROGWIN32), "\"), subKeyNames(i))))
										Catch ex5 As Exception
											flag2 = False
										End Try
										Dim registryKey4 As RegistryKey = Registry.CurrentUser.OpenSubKey(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Software\", RSWIN_DESC.sOldThetaName), "\"), RSWIN_DESC.SECT_PROGWIN32), "\"), subKeyNames(i))), True)
										Dim valueNames As String() = registryKey3.GetValueNames()
										Dim num3 As Integer = Information.LBound(valueNames, 1)
										Dim num4 As Integer = Information.UBound(valueNames, 1)
										For j As Integer = num3 To num4
											Try
												registryKey4.SetValue(valueNames(j), RuntimeHelpers.GetObjectValue(registryKey3.GetValue(valueNames(j))))
											Catch ex6 As Exception
												flag3 = True
											End Try
										Next
									Next
								End If
							End If
						End If
					ElseIf registryKey Is Nothing And registryKey2 Is Nothing Then
						Try
							Registry.CurrentUser.CreateSubKey(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Software\", RSWIN_DESC.sOldThetaName), "\"), RSWIN_DESC.SECT_PROGWIN32)))
						Catch ex7 As Exception
							flag = False
						End Try
					End If
				End If
				RSWIN_DESC.bRegistryMoveChecked = True
				If(flag AndAlso flag2) And Not flag3 Then
					RSWIN_DESC.bUseCurrentUser = True
				Else
					RSWIN_DESC.bUseCurrentUser = False
				End If
			Catch ex8 As Exception
			End Try
		End Sub

		Public Function ValidateTargetProduction() As Boolean
			Dim flag As Boolean = True
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			Me.ResetClock()
			If rst.gbUseIPR Then
				If Not rst.gbCalcTargetBFPD And rst.TargetBFPD = 0F Then
					flag = False
				End If
			ElseIf rst.TargetBFPD = 0F Then
				flag = False
			End If
			If Not flag Then
				Me.RemoveAllChildForms(False)
				Dim sMsg As String = "Please enter a value for Target Production"
				Dim sMsgType As String = "Data Entry Error"
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
				Me.DisplayForm("ProdInfo", "txtSPMBFPD")
			End If
			Return flag
		End Function

		Public Sub SaveAIFile(sSaveFile As Object)
			Dim flag As Boolean = False
			Dim flag2 As Boolean = False
			Try
				Dim rodStringType As Short = RSWIN_DESC.rst.RodStringType
				Dim flag3 As Boolean = RSWIN_DESC.rst.CalcFriction <> 0S
				RSWIN_DESC.rst.RodStringType = 2S
				RSWIN_DESC.rst.CalcFriction = 0S
				RSWIN_DESC.rst.SPMEntered = -1S
				RSWIN_DESC.rst.Iart = RSWIN_DESC.rst.PU.ArtInertia
				Dim flag4 As Boolean = MRodstarXML.StoreXML(Conversions.ToString(sSaveFile), True, flag, flag2)
			Catch ex As Exception
			End Try
		End Sub

		Public Function SetCBMTooltipText() As Object
			Try
				If RSWIN_DESC.rst.PU.UnitType = 8S Or RSWIN_DESC.bBeamBalanced Then
					Me.tbrCBM.ToolTipText = Me.sExportRequiredUnbalance
					Me.mnuToolsExportMCM.Text = "Export &Required Unbalance.."
				Else
					Me.tbrCBM.ToolTipText = Me.sExportCBMoment
					Me.mnuToolsExportMCM.Text = "Export &Balanced MCM.."
				End If
			Catch ex As Exception
			End Try
			Dim result As Object
			Return result
		End Function

		Public Sub ReRunWithNewUnitID(sNewUnitId As String, bSetCrankHole As Boolean, Optional bTryNextCrankhole As Boolean = False, Optional bTryMatchMaxStroke As Boolean = False)
			' The following expression was wrapped in a checked-statement
			Try
				Dim num As Integer = 0
				Dim flag As Boolean = False
				Dim maxStroke As Single = RSWIN_DESC.rst.PU.MaxStroke
				Dim pu As RSWIN_DESC.PUDataRec
				pu.Initialize()
				pu = RSWIN_DESC.rst.PU
				Dim crankHole As Short = RSWIN_DESC.rst.PU.CrankHole
				Dim crankRotation As Short = RSWIN_DESC.rst.PU.CrankRotation
				PUDATA1.ReadPUData(sNewUnitId, pu, False, True)
				If bTryMatchMaxStroke And Me.TryToMatchMaxStroke(pu, maxStroke, num) Then
					pu.CrankHole = CShort(num)
					pu.CrankRotation = crankRotation
					bSetCrankHole = False
					flag = True
				End If
				If Not flag Then
					If bTryNextCrankhole And crankHole + 1S <= pu.CrankHoles Then
						pu.CrankHole = crankHole + 1S
						pu.CrankRotation = crankRotation
						bSetCrankHole = False
					Else
						pu.CrankHole = crankHole
						pu.CrankRotation = crankRotation
					End If
				End If
				If bSetCrankHole AndAlso (pu.Strokes IsNot Nothing And crankHole > 0S) AndAlso pu.Strokes(CInt((pu.CrankHole - 1S))) <> maxStroke Then
					Dim num2 As Short = -1S
					Dim num3 As Integer = 0
					Dim num4 As Integer = CInt((pu.CrankHoles - 1S))
					For i As Integer = num3 To num4
						' The following expression was wrapped in a unchecked-expression
						If pu.Strokes(i) = maxStroke Or Math.Abs(pu.Strokes(i) - maxStroke) < 4F Then
							num2 = CShort(i)
							Exit For
						End If
						If pu.Strokes(i) > maxStroke Then
							num2 = CShort(i)
						End If
					Next
					If num2 <> -1S Then
						pu.CrankHole = num2 + 1S
					End If
				End If
				If pu.CrankHole > 0S Then
					RSWIN_DESC.rst.CrankHole = pu.CrankHole
				End If
				If Not(pu.UnitType = 7S Or pu.UnitType = 10S) And pu.CrankHole > 0S Then
					pu.R = pu.CrankRadii(CInt((pu.CrankHole - 1S)))
				Else
					pu.R = pu.CrankRadii(0)
				End If
				kinemat.Kinconst(pu)
				kinemat.Unitstroke(pu)
				RSWIN_DESC.rst.PU = pu
				Dim flag2 As Boolean = DESIGN.Design()
			Catch ex As Exception
			End Try
		End Sub

		Private Function GetFileNum(sFile As String) As Integer
			' The following expression was wrapped in a checked-statement
			Dim result As Integer
			Try
				Dim startIndex As Integer = Strings.InStr(sFile, "&", CompareMethod.Binary)
				sFile = sFile.Substring(startIndex)
				Dim num As Integer = Strings.InStr(sFile, ".", CompareMethod.Binary)
				Dim value As String = sFile.Substring(0, num - 1)
				Dim num2 As Integer = Convert.ToInt32(value)
				If num2 > 0 Then
					num2 -= 1
				End If
				result = num2
			Catch ex As Exception
			End Try
			Return result
		End Function

		Private Function CheckRodLength(ByRef bLengthError As Boolean) As Object
			Dim result As Object
			Try
				Dim text As String = "Total of rod taper lengths cannot be greater than current pump depth. "
				Dim text2 As String = "Please check input."
				Dim text3 As String = "Rod string length must be within 50 feet of pump depth. "
				Dim text4 As String = "Rod string length must be within 15.24 meters of pump depth. "
				bLengthError = False
				Dim num As Single = 0F
				Dim num2 As Integer = 1
				Dim numRods As Integer = CInt(RSWIN_DESC.rst.NumRods)
				For i As Integer = num2 To numRods
					num += RSWIN_DESC.rst.Sections(i).length
				Next
				If num < RSWIN_DESC.rst.PumpDepth - 50F Then
					If RSWIN_DESC.rst.gbBatch Then
						If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
							Batch.BatchMessage(text3)
						Else
							Batch.BatchMessage(text4)
						End If
						Batch.BatchMessage(text2)
					ElseIf Not RSWIN_DESC.bExpert And Not RSWIN_DESC.SETUP_bGuru Then
						If RSWIN_DESC.SETUP_MeasurementSystem = 1 Then
							MessageBox.Show(text3 + text2)
						Else
							MessageBox.Show(text4 + text2)
						End If
					End If
					bLengthError = True
				ElseIf num > RSWIN_DESC.rst.PumpDepth + 2F Then
					If RSWIN_DESC.rst.gbBatch Then
						Batch.BatchMessage(text)
						Batch.BatchMessage(text2)
					ElseIf Not RSWIN_DESC.bExpert And Not RSWIN_DESC.SETUP_bGuru Then
						MessageBox.Show(text + text2)
					End If
					bLengthError = True
				End If
				result = Not bLengthError
			Catch ex As Exception
			End Try
			Return result
		End Function

		Private Sub ExtraSmallerGearboxCheck(ByRef iGBScore As Integer, ByRef iRLScore As Integer, ByRef iSLScore As Integer, ByRef iSEffScore As Integer, ByRef iBotMinStressScore As Integer, ByRef iMPRLScore As Integer, fOrigTotalScore As Single, bTrySmallerGBAndStrokeLength As Boolean)
			' The following expression was wrapped in a checked-statement
			Try
				Dim num As Integer = 0
				Dim num2 As Integer = 0
				Dim num3 As Integer = 0
				Dim num4 As Integer = 0
				Dim num5 As Integer = 0
				Dim num6 As Integer = 0
				Dim text As String = ""
				Dim rptExpertSummary As rptExpertSummary = New rptExpertSummary()
				Dim flag As Boolean = False
				Dim flag2 As Boolean = False
				Dim flag3 As Boolean = False
				Dim flag4 As Boolean = False
				Dim flag5 As Boolean = False
				Dim flag6 As Boolean = False
				Dim bTryNextCrankhole As Boolean = False
				RSWIN_DESC.bImprovingScore = True
				If RSWIN_DESC.bExpert And RSWIN_DESC.bRunGuru And RSWIN_DESC.bXRODAdmin And RSWIN_DESC.SETUP_bAdminDebug And Not RSWIN_DESC.bOneGuruFile Then
					flag = True
				End If
				Dim unitID As String = RSWIN_DESC.rst.UnitID
				Dim pu As RSWIN_DESC.PUDataRec
				pu.Initialize()
				pu = RSWIN_DESC.rst.PU
				Dim num7 As Single = RSWIN_DESC.rst.GearboxLoading(RSWIN_DESC.i2Score)
				If flag Then
					Dim array As String() = New String(9) {}
					array(0) = "> Checking GB ( "
					array(1) = RSWIN_DESC.rst.GearboxLoading(RSWIN_DESC.i2Score).ToString()
					array(2) = " , unit "
					array(3) = RSWIN_DESC.rst.UnitID
					array(4) = " , "
					array(5) = Conversions.ToString(RSWIN_DESC.rst.PU.GearboxRating)
					array(6) = "-"
					Dim array2 As String() = array
					Dim num8 As Integer = 7
					Dim pu2 As RSWIN_DESC.PUDataRec = RSWIN_DESC.rst.PU
					array2(num8) = Conversions.ToString(pu2.StructRating)
					array(8) = "-"
					array(9) = Conversions.ToString(RSWIN_DESC.rst.PU.MaxStroke)
					Batch.BatchMessage(String.Concat(array))
				End If
				If(iGBScore < 95 And CDbl(num7) < 0.7 And RSWIN_DESC.rst.SPM < 10F) OrElse bTrySmallerGBAndStrokeLength Then
					text = ""
					Dim unitID2 As String = RSWIN_DESC.rst.UnitID
					flag3 = True
					Dim gearboxRating As Single = RSWIN_DESC.rst.PU.GearboxRating
					Dim pu2 As RSWIN_DESC.PUDataRec = RSWIN_DESC.rst.PU
					Dim structRating As Single = pu2.StructRating
					Dim maxStroke As Single = RSWIN_DESC.rst.PU.MaxStroke
					Dim flag7 As Boolean = True
					Dim flag8 As Boolean = PUDATA1.AdjustGearboxForScore(gearboxRating, structRating, maxStroke, text, flag3, flag4, flag7, flag5, flag6, True, False)
					If flag8 And Operators.CompareString(text, "", False) <> 0 Then
						Dim maxStroke2 As Single = RSWIN_DESC.rst.PU.MaxStroke
						unitID = RSWIN_DESC.rst.UnitID
						pu.Initialize()
						pu = RSWIN_DESC.rst.PU
						Dim crankHole As Short = RSWIN_DESC.rst.PU.CrankHole
						Dim crankRotation As Short = RSWIN_DESC.rst.PU.CrankRotation
						RSWIN_DESC.rst.UnitID = text
						If flag6 Then
							If flag Then
								Batch.BatchMessage("> Trying smaller GB and smaller max stroke length to improve total score")
							End If
							bTryNextCrankhole = False
						Else
							Dim num9 As Short = RSWIN_DESC.rst.PU.CrankHole + 1S
							pu2 = RSWIN_DESC.rst.PU
							If num9 <= pu2.CrankHoles Then
								If flag Then
									Batch.BatchMessage("> Trying crankhole 2 to try to improve total score")
								End If
								bTryNextCrankhole = True
							End If
						End If
						Me.ReRunWithNewUnitID(text, True, bTryNextCrankhole, False)
						If flag Then
							Dim array As String() = New String(13) {}
							array(0) = ">New GB Load: "
							array(1) = RSWIN_DESC.rst.GearboxLoading(RSWIN_DESC.i2Score).ToString()
							array(2) = " , unit "
							array(3) = RSWIN_DESC.rst.UnitID
							array(4) = " , "
							array(5) = Conversions.ToString(RSWIN_DESC.rst.PU.GearboxRating)
							array(6) = "-"
							array(7) = Conversions.ToString(RSWIN_DESC.rst.PU.StructRating)
							array(8) = "-"
							array(9) = Conversions.ToString(RSWIN_DESC.rst.PU.MaxStroke)
							array(10) = " , crankhole: "
							Dim array3 As String() = array
							Dim num10 As Integer = 11
							pu2 = RSWIN_DESC.rst.PU
							array3(num10) = pu2.CrankHole.ToString()
							array(12) = " , stroke: "
							array(13) = RSWIN_DESC.rst.PU.Strokes(CInt((RSWIN_DESC.rst.CrankHole - 1S))).ToString()
							Batch.BatchMessage(String.Concat(array))
						End If
						Dim bCheckToAdd As Boolean = False
						flag7 = False
						Dim num11 As Single
						Dim text2 As String = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num11, bCheckToAdd, flag2, flag7, False, False)
						If flag Then
							' The following expression was wrapped in a unchecked-expression
							Batch.BatchMessage(">New GB Score: " + Conversions.ToString(num) + " , New Total Score: " + Conversions.ToString(num11 * 100F))
						End If
						If num11 >= fOrigTotalScore And (CDbl(RSWIN_DESC.rst.GearboxLoading(RSWIN_DESC.i2Score)) >= 0.7 And CDbl(RSWIN_DESC.rst.GearboxLoading(RSWIN_DESC.i2Score)) <= 0.95) Then
							If flag Then
								Batch.BatchMessage("> Keeping new unit")
							End If
						Else
							If flag Then
								Batch.BatchMessage("> Reverting to original unit")
							End If
							RSWIN_DESC.rst.UnitID = unitID
							Dim pu3 As RSWIN_DESC.PUDataRec = pu
							pu3.CrankHole = crankHole
							pu3.CrankRotation = crankRotation
							RSWIN_DESC.rst.CrankHole = crankHole
							If pu3.CrankHole > 0S Then
								RSWIN_DESC.rst.CrankHole = pu3.CrankHole
							End If
							If Not(pu3.UnitType = 7S Or pu3.UnitType = 10S) And pu3.CrankHole > 0S Then
								pu3.R = pu3.CrankRadii(CInt((pu3.CrankHole - 1S)))
							Else
								pu3.R = pu3.CrankRadii(0)
							End If
							kinemat.Kinconst(pu3)
							kinemat.Unitstroke(pu3)
							RSWIN_DESC.rst.PU = pu3
							Dim flag9 As Boolean = DESIGN.Design()
							Dim bCheckToAdd2 As Boolean = False
							flag7 = False
							text2 = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num11, bCheckToAdd2, flag2, flag7, False, False)
						End If
					Else
						If flag Then
							Batch.BatchMessage(">Better replacement unit not found!")
						End If
						Dim bCheckToAdd3 As Boolean = False
						flag7 = False
						Dim num11 As Single
						Dim text2 As String = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num11, bCheckToAdd3, flag2, flag7, False, False)
						If(CDbl(RSWIN_DESC.rst.GearboxLoading(RSWIN_DESC.i2Score)) > 0.95 And num < 100) AndAlso RSWIN_DESC.SETUP_bUseAvgRodTBGFricCoeff Then
							Batch.BatchMessage("Unit with smaller gearbox rating not found.")
						End If
					End If
				End If
				RSWIN_DESC.bImprovingScore = False
			Catch ex As Exception
			End Try
		End Sub

		Private Sub ExtraSmallerGearboxAndSLCheck(ByRef iGBScore As Integer, ByRef iRLScore As Integer, ByRef iSLScore As Integer, ByRef iSEffScore As Integer, ByRef iBotMinStressScore As Integer, ByRef iMPRLScore As Integer, fOrigTotalScore As Single, Optional ByRef bUnitChanged As Boolean = False, Optional ByRef sOld_Unit_Id As String = "", Optional ByRef sNew_Unit_Id As String = "")
			' The following expression was wrapped in a checked-statement
			Try
				Dim num As Integer = 0
				Dim num2 As Integer = 0
				Dim num3 As Integer = 0
				Dim num4 As Integer = 0
				Dim num5 As Integer = 0
				Dim num6 As Integer = 0
				Dim text As String = ""
				Dim rptExpertSummary As rptExpertSummary = New rptExpertSummary()
				Dim flag As Boolean = False
				Dim flag2 As Boolean = False
				Dim flag3 As Boolean = False
				Dim flag4 As Boolean = False
				Dim flag5 As Boolean = False
				Dim flag6 As Boolean = False
				Dim flag7 As Boolean = False
				Dim flag8 As Boolean = True
				bUnitChanged = False
				RSWIN_DESC.bImprovingScore = True
				If RSWIN_DESC.bExpert And RSWIN_DESC.bRunGuru And RSWIN_DESC.bXRODAdmin And RSWIN_DESC.SETUP_bAdminDebug And Not RSWIN_DESC.bOneGuruFile Then
					flag = True
				End If
				Dim unitID As String = RSWIN_DESC.rst.UnitID
				Dim pu As RSWIN_DESC.PUDataRec
				pu.Initialize()
				pu = RSWIN_DESC.rst.PU
				Dim num7 As Single = RSWIN_DESC.rst.GearboxLoading(RSWIN_DESC.i2Score)
				If flag Then
					Dim array As String() = New String(9) {}
					array(0) = "> Checking GB ( "
					array(1) = RSWIN_DESC.rst.GearboxLoading(RSWIN_DESC.i2Score).ToString()
					array(2) = " , unit "
					array(3) = RSWIN_DESC.rst.UnitID
					array(4) = " , "
					array(5) = Conversions.ToString(RSWIN_DESC.rst.PU.GearboxRating)
					array(6) = "-"
					Dim array2 As String() = array
					Dim num8 As Integer = 7
					Dim pu2 As RSWIN_DESC.PUDataRec = RSWIN_DESC.rst.PU
					array2(num8) = Conversions.ToString(pu2.StructRating)
					array(8) = "-"
					array(9) = Conversions.ToString(RSWIN_DESC.rst.PU.MaxStroke)
					Batch.BatchMessage(String.Concat(array))
				End If
				While (RSWIN_DESC.rst.SPM < 9F And CDbl(RSWIN_DESC.rst.GearboxLoading(RSWIN_DESC.i2Score)) <= 0.9) AndAlso flag8
					text = ""
					Dim unitID2 As String = RSWIN_DESC.rst.UnitID
					Dim array As String() = New String(7) {}
					array(0) = RSWIN_DESC.rst.UnitID
					array(1) = "  ("
					array(2) = Conversions.ToString(RSWIN_DESC.rst.PU.GearboxRating)
					array(3) = "-"
					Dim array3 As String() = array
					Dim num9 As Integer = 4
					Dim pu2 As RSWIN_DESC.PUDataRec = RSWIN_DESC.rst.PU
					array3(num9) = Conversions.ToString(pu2.StructRating)
					array(5) = "-"
					array(6) = Conversions.ToString(RSWIN_DESC.rst.PU.MaxStroke)
					array(7) = ")"
					sOld_Unit_Id = String.Concat(array)
					flag3 = True
					Dim gearboxRating As Single = RSWIN_DESC.rst.PU.GearboxRating
					pu2 = RSWIN_DESC.rst.PU
					Dim structRating As Single = pu2.StructRating
					Dim maxStroke As Single = RSWIN_DESC.rst.PU.MaxStroke
					Dim flag9 As Boolean = True
					Dim flag10 As Boolean = PUDATA1.AdjustGearboxForScore(gearboxRating, structRating, maxStroke, text, flag3, flag4, flag9, flag5, flag6, True, False)
					If flag10 And Operators.CompareString(text, "", False) <> 0 And Operators.CompareString(text, unitID2, False) <> 0 Then
						Dim maxStroke2 As Single = RSWIN_DESC.rst.PU.MaxStroke
						unitID = RSWIN_DESC.rst.UnitID
						pu.Initialize()
						pu = RSWIN_DESC.rst.PU
						Dim crankHole As Short = RSWIN_DESC.rst.PU.CrankHole
						Dim crankRotation As Short = RSWIN_DESC.rst.PU.CrankRotation
						RSWIN_DESC.rst.UnitID = text
						Me.ReRunWithNewUnitID(text, True, False, False)
						Dim bCheckToAdd As Boolean = False
						flag9 = False
						Dim num10 As Single
						Dim text2 As String = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num10, bCheckToAdd, flag2, flag9, False, False)
						array = New String(7) {}
						array(0) = RSWIN_DESC.rst.UnitID
						array(1) = "  ("
						array(2) = Conversions.ToString(RSWIN_DESC.rst.PU.GearboxRating)
						array(3) = "-"
						Dim array4 As String() = array
						Dim num11 As Integer = 4
						pu2 = RSWIN_DESC.rst.PU
						array4(num11) = Conversions.ToString(pu2.StructRating)
						array(5) = "-"
						array(6) = Conversions.ToString(RSWIN_DESC.rst.PU.MaxStroke)
						array(7) = ")"
						Debug.WriteLine(String.Concat(array))
						If flag6 Then
							If flag Then
								Batch.BatchMessage("> Trying smaller GB and smaller max stroke length to improve total score")
							End If
							flag7 = False
						Else
							Dim num12 As Short = RSWIN_DESC.rst.PU.CrankHole + 1S
							pu2 = RSWIN_DESC.rst.PU
							If num12 <= pu2.CrankHoles Then
								If flag Then
									Batch.BatchMessage("> Trying crankhole 2 to try to improve total score")
								End If
								flag7 = True
							End If
						End If
						If CDbl(RSWIN_DESC.rst.GearboxLoading(RSWIN_DESC.i2Score)) > 0.95 AndAlso flag7 Then
							Me.ReRunWithNewUnitID(text, True, flag7, False)
							If flag Then
								array = New String(13) {}
								array(0) = ">New GB Load: "
								array(1) = RSWIN_DESC.rst.GearboxLoading(RSWIN_DESC.i2Score).ToString()
								array(2) = " , unit "
								array(3) = RSWIN_DESC.rst.UnitID
								array(4) = " , "
								array(5) = Conversions.ToString(RSWIN_DESC.rst.PU.GearboxRating)
								array(6) = "-"
								Dim array5 As String() = array
								Dim num13 As Integer = 7
								Dim pu3 As RSWIN_DESC.PUDataRec = RSWIN_DESC.rst.PU
								array5(num13) = Conversions.ToString(pu3.StructRating)
								array(8) = "-"
								array(9) = Conversions.ToString(RSWIN_DESC.rst.PU.MaxStroke)
								array(10) = " , crankhole: "
								Dim array6 As String() = array
								Dim num14 As Integer = 11
								pu2 = RSWIN_DESC.rst.PU
								array6(num14) = pu2.CrankHole.ToString()
								array(12) = " , stroke: "
								array(13) = RSWIN_DESC.rst.PU.Strokes(CInt((RSWIN_DESC.rst.CrankHole - 1S))).ToString()
								Batch.BatchMessage(String.Concat(array))
							End If
							Dim bCheckToAdd2 As Boolean = False
							flag9 = False
							text2 = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num10, bCheckToAdd2, flag2, flag9, False, False)
							If flag Then
								' The following expression was wrapped in a unchecked-expression
								Batch.BatchMessage(">New GB Score: " + Conversions.ToString(num) + " , New Total Score: " + Conversions.ToString(num10 * 100F))
							End If
							If num10 >= fOrigTotalScore And (CDbl(RSWIN_DESC.rst.GearboxLoading(RSWIN_DESC.i2Score)) >= 0.7 And CDbl(RSWIN_DESC.rst.GearboxLoading(RSWIN_DESC.i2Score)) <= 0.95) Then
								If flag Then
									Batch.BatchMessage("> Keeping new unit")
								End If
								bUnitChanged = True
								array = New String(7) {}
								array(0) = RSWIN_DESC.rst.UnitID
								array(1) = "  ("
								array(2) = Conversions.ToString(RSWIN_DESC.rst.PU.GearboxRating)
								array(3) = "-"
								Dim array7 As String() = array
								Dim num15 As Integer = 4
								Dim pu3 As RSWIN_DESC.PUDataRec = RSWIN_DESC.rst.PU
								array7(num15) = Conversions.ToString(pu3.StructRating)
								array(5) = "-"
								array(6) = Conversions.ToString(RSWIN_DESC.rst.PU.MaxStroke)
								array(7) = ")"
								sNew_Unit_Id = String.Concat(array)
							Else
								If flag Then
									Batch.BatchMessage("> Reverting to original unit")
								End If
								flag8 = False
								bUnitChanged = False
								RSWIN_DESC.rst.UnitID = unitID
								Dim pu4 As RSWIN_DESC.PUDataRec = pu
								pu4.CrankHole = crankHole
								pu4.CrankRotation = crankRotation
								If pu4.CrankHole > 0S Then
									RSWIN_DESC.rst.CrankHole = pu4.CrankHole
								End If
								If Not(pu4.UnitType = 7S Or pu4.UnitType = 10S) And pu4.CrankHole > 0S Then
									pu4.R = pu4.CrankRadii(CInt((pu4.CrankHole - 1S)))
								Else
									pu4.R = pu4.CrankRadii(0)
								End If
								kinemat.Kinconst(pu4)
								kinemat.Unitstroke(pu4)
								RSWIN_DESC.rst.PU = pu4
								Dim flag11 As Boolean = DESIGN.Design()
								Dim bCheckToAdd3 As Boolean = False
								flag9 = False
								text2 = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num10, bCheckToAdd3, flag2, flag9, False, False)
							End If
						ElseIf(num > iGBScore Or (CDbl(RSWIN_DESC.rst.GearboxLoading(RSWIN_DESC.i2Score)) >= 0.7 And CDbl(RSWIN_DESC.rst.GearboxLoading(RSWIN_DESC.i2Score)) <= 0.95) Or (CDbl(RSWIN_DESC.rst.GearboxLoading(RSWIN_DESC.i2Score)) < 0.7 And RSWIN_DESC.rst.GearboxLoading(RSWIN_DESC.i2Score) > num7)) And num10 >= fOrigTotalScore Then
							Dim structL As Single = RSWIN_DESC.rst.StructL
							num7 = RSWIN_DESC.rst.GearboxLoading(RSWIN_DESC.i2Score)
							If(CDbl(num7) < 0.7 Or CDbl(num7) > 0.95) And Operators.CompareString(unitID2, text, False) <> 0 Then
								If flag Then
									Batch.BatchMessage("> Trying yet another unit")
								End If
								flag8 = True
							Else
								If flag Then
									Batch.BatchMessage("> Keeping new unit")
								End If
								flag8 = False
								bUnitChanged = True
								array = New String(7) {}
								array(0) = RSWIN_DESC.rst.UnitID
								array(1) = "  ("
								array(2) = Conversions.ToString(RSWIN_DESC.rst.PU.GearboxRating)
								array(3) = "-"
								Dim array8 As String() = array
								Dim num16 As Integer = 4
								Dim pu3 As RSWIN_DESC.PUDataRec = RSWIN_DESC.rst.PU
								array8(num16) = Conversions.ToString(pu3.StructRating)
								array(5) = "-"
								array(6) = Conversions.ToString(RSWIN_DESC.rst.PU.MaxStroke)
								array(7) = ")"
								sNew_Unit_Id = String.Concat(array)
							End If
						Else
							flag8 = False
							If flag Then
								Batch.BatchMessage("> Reverting to original unit")
							End If
							bUnitChanged = False
							RSWIN_DESC.rst.UnitID = unitID
							Dim pu4 As RSWIN_DESC.PUDataRec = pu
							pu4.CrankHole = crankHole
							pu4.CrankRotation = crankRotation
							If pu4.CrankHole > 0S Then
								RSWIN_DESC.rst.CrankHole = pu4.CrankHole
							End If
							If Not(pu4.UnitType = 7S Or pu4.UnitType = 10S) And pu4.CrankHole > 0S Then
								pu4.R = pu4.CrankRadii(CInt((pu4.CrankHole - 1S)))
							Else
								pu4.R = pu4.CrankRadii(0)
							End If
							kinemat.Kinconst(pu4)
							kinemat.Unitstroke(pu4)
							RSWIN_DESC.rst.PU = pu4
							Dim flag11 As Boolean = DESIGN.Design()
							Dim bCheckToAdd4 As Boolean = False
							flag9 = False
							text2 = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num10, bCheckToAdd4, flag2, flag9, False, False)
						End If
						If bUnitChanged Then
							Dim gearboxRating2 As Single = RSWIN_DESC.rst.PU.GearboxRating
							Dim pu3 As RSWIN_DESC.PUDataRec = RSWIN_DESC.rst.PU
							Dim structRating2 As Single = pu3.StructRating
							Dim maxStroke3 As Single = RSWIN_DESC.rst.PU.MaxStroke
							Dim bWriteDebugLines As Boolean = RSWIN_DESC.bExpert And RSWIN_DESC.bRunGuru And RSWIN_DESC.bXRODAdmin And RSWIN_DESC.SETUP_bAdminDebug And Not RSWIN_DESC.bOneGuruFile
							flag9 = True
							flag10 = PUDATA1.AdjustStructureForScore(gearboxRating2, structRating2, maxStroke3, text, bWriteDebugLines, flag9, True, False, False, 0)
							If flag10 And Operators.CompareString(text, "", False) <> 0 Then
								maxStroke2 = RSWIN_DESC.rst.PU.MaxStroke
								unitID = RSWIN_DESC.rst.UnitID
								pu.Initialize()
								pu = RSWIN_DESC.rst.PU
								crankHole = RSWIN_DESC.rst.PU.CrankHole
								crankRotation = RSWIN_DESC.rst.PU.CrankRotation
								RSWIN_DESC.rst.UnitID = text
								Me.ReRunWithNewUnitID(text, True, False, False)
								If flag Then
									array = New String(13) {}
									array(0) = ">New GB Load: "
									array(1) = RSWIN_DESC.rst.GearboxLoading(RSWIN_DESC.i2Score).ToString()
									array(2) = " , unit "
									array(3) = RSWIN_DESC.rst.UnitID
									array(4) = " , "
									array(5) = Conversions.ToString(RSWIN_DESC.rst.PU.GearboxRating)
									array(6) = "-"
									Dim array9 As String() = array
									Dim num17 As Integer = 7
									pu2 = RSWIN_DESC.rst.PU
									array9(num17) = Conversions.ToString(pu2.StructRating)
									array(8) = "-"
									array(9) = Conversions.ToString(RSWIN_DESC.rst.PU.MaxStroke)
									array(10) = " , crankhole: "
									Dim array10 As String() = array
									Dim num18 As Integer = 11
									pu3 = RSWIN_DESC.rst.PU
									array10(num18) = pu3.CrankHole.ToString()
									array(12) = " , stroke: "
									array(13) = RSWIN_DESC.rst.PU.Strokes(CInt((RSWIN_DESC.rst.CrankHole - 1S))).ToString()
									Batch.BatchMessage(String.Concat(array))
								End If
								Dim bCheckToAdd5 As Boolean = False
								flag9 = False
								text2 = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num10, bCheckToAdd5, flag2, flag9, False, False)
								If flag Then
									' The following expression was wrapped in a unchecked-expression
									Batch.BatchMessage(">New GB Score: " + Conversions.ToString(num) + " , New Total Score: " + Conversions.ToString(num10 * 100F))
								End If
								If(num > iGBScore Or (CDbl(RSWIN_DESC.rst.GearboxLoading(RSWIN_DESC.i2Score)) >= 0.7 And CDbl(RSWIN_DESC.rst.GearboxLoading(RSWIN_DESC.i2Score)) <= 0.95) Or (CDbl(RSWIN_DESC.rst.GearboxLoading(RSWIN_DESC.i2Score)) < 0.7 And RSWIN_DESC.rst.GearboxLoading(RSWIN_DESC.i2Score) > num7)) And num10 >= fOrigTotalScore Then
									Dim structL As Single = RSWIN_DESC.rst.StructL
									bUnitChanged = False
									num7 = RSWIN_DESC.rst.GearboxLoading(RSWIN_DESC.i2Score)
									If(CDbl(num7) < 0.7 Or CDbl(num7) > 0.95) And Operators.CompareString(unitID2, text, False) <> 0 Then
										If flag Then
											Batch.BatchMessage("> Trying yet another unit")
										End If
										flag8 = True
									Else
										If flag Then
											Batch.BatchMessage("> Keeping new unit")
										End If
										flag8 = False
									End If
								Else
									flag8 = False
									If flag Then
										Batch.BatchMessage("> Reverting to original unit")
									End If
									bUnitChanged = False
									RSWIN_DESC.rst.UnitID = unitID
									Dim pu4 As RSWIN_DESC.PUDataRec = pu
									pu4.CrankHole = crankHole
									pu4.CrankRotation = crankRotation
									If pu4.CrankHole > 0S Then
										RSWIN_DESC.rst.CrankHole = pu4.CrankHole
									End If
									If Not(pu4.UnitType = 7S Or pu4.UnitType = 10S) And pu4.CrankHole > 0S Then
										pu4.R = pu4.CrankRadii(CInt((pu4.CrankHole - 1S)))
									Else
										pu4.R = pu4.CrankRadii(0)
									End If
									kinemat.Kinconst(pu4)
									kinemat.Unitstroke(pu4)
									RSWIN_DESC.rst.PU = pu4
									Dim flag11 As Boolean = DESIGN.Design()
									Dim bCheckToAdd6 As Boolean = False
									flag9 = False
									text2 = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num10, bCheckToAdd6, flag2, flag9, False, False)
								End If
							End If
						End If
					Else
						flag8 = False
						If flag Then
							Batch.BatchMessage(">Better replacement unit not found!")
						End If
						Dim bCheckToAdd7 As Boolean = False
						flag9 = False
						Dim num10 As Single
						Dim text2 As String = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num10, bCheckToAdd7, flag2, flag9, False, False)
						If(CDbl(RSWIN_DESC.rst.GearboxLoading(RSWIN_DESC.i2Score)) > 0.95 And num < 100) AndAlso RSWIN_DESC.SETUP_bUseAvgRodTBGFricCoeff Then
							Batch.BatchMessage("Unit with smaller gearbox rating not found.")
						End If
					End If
				End While
				RSWIN_DESC.bImprovingScore = False
			Catch ex As Exception
			End Try
		End Sub

		Private Sub TryToImproveSysEffOnly(ByRef iGBScore As Integer, ByRef iRLScore As Integer, ByRef iSLScore As Integer, ByRef iSEffScore As Integer, ByRef iBotMinStressScore As Integer, ByRef iMPRLScore As Integer, fOrigTotalScore As Single)
			Try
				Dim num As Integer = 0
				Dim num2 As Integer = 0
				Dim num3 As Integer = 0
				Dim num4 As Integer = 0
				Dim num5 As Integer = 0
				Dim num6 As Integer = 0
				Dim rptExpertSummary As rptExpertSummary = New rptExpertSummary()
				Dim flag As Boolean = False
				Dim flag2 As Boolean = False
				RSWIN_DESC.bImprovingScore = True
				If RSWIN_DESC.bExpert And RSWIN_DESC.bRunGuru And RSWIN_DESC.bXRODAdmin And RSWIN_DESC.SETUP_bAdminDebug And Not RSWIN_DESC.bOneGuruFile Then
					flag = True
				End If
				If flag Then
					Batch.BatchMessage("> Original Total Score (Less < 0.98) " + Conversions.ToString(fOrigTotalScore))
					Batch.BatchMessage(String.Concat(New String() { "> Checking Sys. Eff ", Conversions.ToString(RSWIN_DESC.rst.SystemEff), " , TargetBFPD ", Conversions.ToString(RSWIN_DESC.rst.TargetBFPD), " , plunger size ", Conversions.ToString(RSWIN_DESC.rst.PlungerSize) }))
				End If
				If CDbl(RSWIN_DESC.rst.SystemEff) < 0.45 And RSWIN_DESC.rst.TargetBFPD >= 100F Then
					Dim systemEff As Single = RSWIN_DESC.rst.SystemEff
					Dim plungerSize As Single = RSWIN_DESC.rst.PlungerSize
					Dim flag3 As Boolean = False
					Dim plungersize As Single = Me.GetPlungersize(RSWIN_DESC.rst.PlungerSize, False)
					Dim num7 As Single
					If plungersize = -1F Or plungersize = 0F Then
						flag3 = True
					ElseIf plungersize <> -1F And plungersize <> 0F Then
						Dim plungerSize2 As Single = RSWIN_DESC.rst.PlungerSize
						RSWIN_DESC.rst.PlungerSize = plungersize
						If flag Then
							Batch.BatchMessage("> Try larger Plunger Size  " + plungersize.ToString())
						End If
						Dim flag4 As Boolean = DESIGN.Design()
						Dim bCheckToAdd As Boolean = False
						Dim flag5 As Boolean = False
						Dim text As String = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num7, bCheckToAdd, flag2, flag5, False, False)
						If flag Then
							Batch.BatchMessage("> new sys eff score: " + num4.ToString() + " , new sys eff: " + Conversions.ToString(RSWIN_DESC.rst.SystemEff))
						End If
						flag3 = (RSWIN_DESC.bFGUnderTravel OrElse (Not(num7 > fOrigTotalScore And (num4 > iSEffScore Or RSWIN_DESC.rst.SystemEff > systemEff)) AndAlso (num4 <= iSEffScore Or (num4 > iSEffScore And num7 <= fOrigTotalScore))))
					End If
					If flag3 Then
						If flag Then
							Batch.BatchMessage("> Score not improved! Revert to original plungersize.")
						End If
						RSWIN_DESC.rst.PlungerSize = plungerSize
						Dim flag4 As Boolean = DESIGN.Design()
						Dim bCheckToAdd2 As Boolean = False
						Dim flag5 As Boolean = False
						Dim text As String = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num7, bCheckToAdd2, flag2, flag5, False, False)
					End If
				ElseIf flag Then
					Batch.BatchMessage("> Sys. Eff OK ")
				End If
				RSWIN_DESC.bImprovingScore = False
			Catch ex As Exception
			End Try
		End Sub

		Private Function TrySmallerPlungerSize(ByRef iGBScore As Integer, ByRef iRLScore As Integer, ByRef iSLScore As Integer, ByRef iSEffScore As Integer, ByRef iBotMinStressScore As Integer, ByRef iMPRLScore As Integer, fOrigTotalScore As Single) As Boolean
			' The following expression was wrapped in a checked-statement
			Dim result As Boolean
			Try
				Dim num As Integer = 0
				Dim num2 As Integer = 0
				Dim num3 As Integer = 0
				Dim num4 As Integer = 0
				Dim num5 As Integer = 0
				Dim num6 As Integer = 0
				Dim rptExpertSummary As rptExpertSummary = New rptExpertSummary()
				Dim flag As Boolean = False
				Dim flag2 As Boolean = False
				Dim flag3 As Boolean = False
				Dim text As String = ""
				RSWIN_DESC.bImprovingScore = True
				If RSWIN_DESC.bExpert And RSWIN_DESC.bRunGuru And RSWIN_DESC.bXRODAdmin And RSWIN_DESC.SETUP_bAdminDebug And Not RSWIN_DESC.bOneGuruFile Then
					flag = True
				End If
				If flag Then
					Batch.BatchMessage("> Original Total Score (with overloaded rod) " + Conversions.ToString(fOrigTotalScore))
					Batch.BatchMessage(String.Concat(New String() { "> Checking smaller plungersize ", Conversions.ToString(RSWIN_DESC.rst.SystemEff), " , TargetBFPD ", Conversions.ToString(RSWIN_DESC.rst.TargetBFPD), " , plunger size ", Conversions.ToString(RSWIN_DESC.rst.PlungerSize) }))
				End If
				If Not RSWIN_DESC.SETUP_UseXRODVTubingSizes And RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru Then
					Dim maxCasingSize As Single = RSWIN_DESC.MaxCasingSize
					Dim maxTubingSizeOD As Single = RSWIN_DESC.MaxTubingSizeOD
					Dim num7 As Single
					Dim num8 As Single
					Dim num9 As Single
					RODUTIL.GetSizeFromCasingSize(maxCasingSize, maxTubingSizeOD, num7, num8, num9, False)
					RSWIN_DESC.MaxTubingSizeOD = maxTubingSizeOD
					If RSWIN_DESC.rst.PlungerSize > num8 Then
						RSWIN_DESC.rst.PlungerSize = num8
					End If
				End If
				Dim plungersize As Single = Me.GetPlungersize(RSWIN_DESC.rst.PlungerSize, True)
				Dim num10 As Single
				Dim num11 As Single
				If plungersize <> -1F And plungersize <> 0F Then
					Dim bCheckToAdd As Boolean = False
					Dim flag4 As Boolean = False
					Dim text2 As String = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num10, bCheckToAdd, flag3, flag4, False, False)
					Dim plungerSize As Single = RSWIN_DESC.rst.PlungerSize
					RSWIN_DESC.rst.PlungerSize = plungersize
					If flag Then
						Batch.BatchMessage("> HS overloaded, trying smaller Plunger Size  " + plungersize.ToString())
					End If
					Dim flag5 As Boolean = DESIGN.Design()
					Dim bCheckToAdd2 As Boolean = False
					flag4 = False
					text2 = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num11, bCheckToAdd2, flag3, flag4, False, False)
					If RSWIN_DESC.bFGUnderTravel Then
						flag2 = True
					ElseIf num11 > num10 Then
						If flag Then
							Batch.BatchMessage("> Keeping smaller plunger size")
						End If
						flag2 = False
					Else
						flag2 = True
					End If
					If flag2 Then
						If flag Then
							Batch.BatchMessage("> Revert to larger plunger size")
						End If
						flag2 = True
						RSWIN_DESC.rst.PlungerSize = plungerSize
						flag5 = DESIGN.Design()
						Dim bCheckToAdd3 As Boolean = False
						flag4 = False
						text2 = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num10, bCheckToAdd3, flag3, flag4, False, False)
					End If
				End If
				If Not flag2 Then
					Dim tubingOD As Single = RSWIN_DESC.rst.TubingOD
					Dim tubingID As Single = RSWIN_DESC.rst.TubingID
					Dim num12 As Single
					Dim tubingID2 As Single
					Dim smallerTubingDiameter As Boolean = RODUTIL.GetSmallerTubingDiameter(num12, tubingID2)
					If smallerTubingDiameter And num12 <> -1F And num12 <> tubingOD Then
						Dim flag6 As Boolean = False
						RSWIN_DESC.rst.TubingOD = num12
						RSWIN_DESC.rst.TubingID = tubingID2
						Dim num13 As Integer = 1
						Dim numRods As Integer = CInt(RSWIN_DESC.rst.NumRods)
						For i As Integer = num13 To numRods
							Dim quiet As Object = True
							Dim grade As Object = RSWIN_DESC.rst.Sections(i).Grade
							Dim diameter As Object = RSWIN_DESC.rst.Sections(i).Diameter
							Dim flag7 As Boolean
							Dim obj As Object = flag7
							Dim flag8 As Boolean
							Dim obj2 As Object = flag8
							Dim obj3 As Object = text
							Dim flag9 As Boolean
							Dim obj4 As Object = flag9
							Dim flag10 As Boolean = RODUTIL.CheckRodsInTubing(quiet, grade, diameter, obj, obj2, obj3, obj4, i)
							flag9 = Conversions.ToBoolean(obj4)
							text = Conversions.ToString(obj3)
							flag8 = Conversions.ToBoolean(obj2)
							flag7 = Conversions.ToBoolean(obj)
							Dim flag11 As Boolean = flag10
							If Not flag11 Or Operators.CompareString(text, "", False) <> 0 Then
								flag6 = True
								RSWIN_DESC.rst.TubingOD = tubingOD
								RSWIN_DESC.rst.TubingID = tubingID
								Exit For
							End If
						Next
						If Not flag6 Then
							Dim flag5 As Boolean = DESIGN.Design()
							Dim bCheckToAdd4 As Boolean = False
							Dim flag4 As Boolean = False
							Dim text2 As String = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num11, bCheckToAdd4, flag3, flag4, False, False)
							If num11 < num10 Then
								RSWIN_DESC.rst.TubingOD = tubingOD
								RSWIN_DESC.rst.TubingID = tubingID
								flag5 = DESIGN.Design()
								Dim bCheckToAdd5 As Boolean = False
								flag4 = False
								text2 = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num11, bCheckToAdd5, flag3, flag4, False, False)
							End If
						End If
					End If
				End If
				RSWIN_DESC.bImprovingScore = False
				result = Not flag2
			Catch ex As Exception
				result = False
			End Try
			Return result
		End Function

		Private Function TryLargerPlungerSize(ByRef iGBScore As Integer, ByRef iRLScore As Integer, ByRef iSLScore As Integer, ByRef iSEffScore As Integer, ByRef iBotMinStressScore As Integer, ByRef iMPRLScore As Integer, fOrigTotalScore As Single) As Boolean
			Dim result As Boolean
			Try
				Dim num As Integer = 0
				Dim num2 As Integer = 0
				Dim num3 As Integer = 0
				Dim num4 As Integer = 0
				Dim num5 As Integer = 0
				Dim num6 As Integer = 0
				Dim rptExpertSummary As rptExpertSummary = New rptExpertSummary()
				Dim flag As Boolean = False
				Dim flag2 As Boolean = False
				RSWIN_DESC.bImprovingScore = True
				If RSWIN_DESC.bExpert And RSWIN_DESC.bRunGuru And RSWIN_DESC.bXRODAdmin And RSWIN_DESC.SETUP_bAdminDebug And Not RSWIN_DESC.bOneGuruFile Then
					flag = True
				End If
				If flag Then
					Batch.BatchMessage("> Original Total Score (with overloaded rod) " + Conversions.ToString(fOrigTotalScore))
					Batch.BatchMessage(String.Concat(New String() { "> Checking larger plungersize ", Conversions.ToString(RSWIN_DESC.rst.SystemEff), " , TargetBFPD ", Conversions.ToString(RSWIN_DESC.rst.TargetBFPD), " , plunger size ", Conversions.ToString(RSWIN_DESC.rst.PlungerSize) }))
				End If
				Dim plungerSize As Single = RSWIN_DESC.rst.PlungerSize
				Dim num8 As Single
				If Not RSWIN_DESC.SETUP_UseXRODVTubingSizes And RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru Then
					Dim maxCasingSize As Single = RSWIN_DESC.MaxCasingSize
					Dim maxTubingSizeOD As Single = RSWIN_DESC.MaxTubingSizeOD
					Dim num7 As Single
					Dim num9 As Single
					RODUTIL.GetSizeFromCasingSize(maxCasingSize, maxTubingSizeOD, num7, num8, num9, False)
					RSWIN_DESC.MaxTubingSizeOD = maxTubingSizeOD
					If RSWIN_DESC.rst.PlungerSize > num8 Then
						RSWIN_DESC.rst.PlungerSize = num8
					End If
				End If
				Dim num10 As Single = Me.GetPlungersize(RSWIN_DESC.rst.PlungerSize, False)
				If(Not RSWIN_DESC.SETUP_UseXRODVTubingSizes And RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru) AndAlso num10 > num8 Then
					num10 = -1F
				End If
				Dim flag5 As Boolean
				If num10 <> -1F And num10 <> 0F Then
					plungerSize = RSWIN_DESC.rst.PlungerSize
					RSWIN_DESC.rst.PlungerSize = num10
					Dim tubingOD As Single = RSWIN_DESC.rst.TubingOD
					Dim tubingID As Single = RSWIN_DESC.rst.TubingID
					If Not(Not RSWIN_DESC.SETUP_UseXRODVTubingSizes And RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru) AndAlso Me.CheckPlungerInTubing(True) = 0S Then
						Dim tubingOD2 As Single
						Dim tubingID2 As Single
						Dim largerTubingDiameter As Boolean = RODUTIL.GetLargerTubingDiameter(tubingOD2, tubingID2)
						If largerTubingDiameter Then
							RSWIN_DESC.rst.TubingOD = tubingOD2
							RSWIN_DESC.rst.TubingID = tubingID2
						End If
					End If
					RSWIN_DESC.rst.PlungerSize = num10
					If flag Then
						Batch.BatchMessage("> HS overloaded, trying larger Plunger Size  " + num10.ToString())
					End If
					Dim bCheckToAdd As Boolean = False
					Dim flag3 As Boolean = False
					Dim num11 As Single
					Dim text As String = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num11, bCheckToAdd, flag2, flag3, False, False)
					Dim flag4 As Boolean = DESIGN.Design()
					Dim bCheckToAdd2 As Boolean = False
					flag3 = False
					Dim num12 As Single
					text = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num12, bCheckToAdd2, flag2, flag3, False, False)
					If RSWIN_DESC.bFGUnderTravel Then
						flag5 = True
					ElseIf num12 > num11 Then
						If flag Then
							Batch.BatchMessage("> Keeping larger plunger size")
						End If
						flag5 = False
					Else
						flag5 = True
					End If
					If flag5 Then
						If flag Then
							Batch.BatchMessage("> Revert to larger plunger size")
						End If
						flag5 = True
						RSWIN_DESC.rst.PlungerSize = plungerSize
						RSWIN_DESC.rst.TubingOD = tubingOD
						RSWIN_DESC.rst.TubingID = tubingID
						flag4 = DESIGN.Design()
						Dim bCheckToAdd3 As Boolean = False
						flag3 = False
						text = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num11, bCheckToAdd3, flag2, flag3, False, False)
					End If
				Else
					If flag Then
						Batch.BatchMessage("> Revert to larger plunger size")
					End If
					flag5 = True
					RSWIN_DESC.rst.PlungerSize = plungerSize
					Dim tubingOD As Single
					RSWIN_DESC.rst.TubingOD = tubingOD
					Dim tubingID As Single
					RSWIN_DESC.rst.TubingID = tubingID
					Dim flag4 As Boolean = DESIGN.Design()
					Dim bCheckToAdd4 As Boolean = False
					Dim flag3 As Boolean = False
					Dim num11 As Single
					Dim text As String = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num11, bCheckToAdd4, flag2, flag3, False, False)
				End If
				RSWIN_DESC.bImprovingScore = False
				result = Not flag5
			Catch ex As Exception
				result = False
			End Try
			Return result
		End Function

		Private Sub TryDifferentRotationDirection(ByRef iGBScore As Integer, ByRef iRLScore As Integer, ByRef iSLScore As Integer, ByRef iSEffScore As Integer, ByRef iBotMinStressScore As Integer, ByRef iMPRLScore As Integer, fOrigTotalScore As Single)
			Try
				Dim num As Integer = 0
				Dim num2 As Integer = 0
				Dim num3 As Integer = 0
				Dim num4 As Integer = 0
				Dim num5 As Integer = 0
				Dim num6 As Integer = 0
				Dim rptExpertSummary As rptExpertSummary = New rptExpertSummary()
				Dim flag As Boolean = False
				Dim flag2 As Boolean = False
				Dim rodStringType As Short = RSWIN_DESC.rst.RodStringType
				RSWIN_DESC.bImprovingScore = True
				If RSWIN_DESC.bExpert And RSWIN_DESC.bRunGuru And RSWIN_DESC.bXRODAdmin And RSWIN_DESC.SETUP_bAdminDebug And Not RSWIN_DESC.bOneGuruFile Then
					flag = True
				End If
				rodStringType = RSWIN_DESC.rst.RodStringType
				If RSWIN_DESC.rst.RodStringType <> 2S Then
					RSWIN_DESC.rst.RodStringType = 2S
				End If
				Dim str As String
				If flag Then
					Batch.BatchMessage("> rotating in other direction: " + str)
				End If
				Dim crankRotation As Short = RSWIN_DESC.rst.PU.CrankRotation
				Dim pu As RSWIN_DESC.PUDataRec
				pu.Initialize()
				pu = RSWIN_DESC.rst.PU
				If pu.CrankRotation = 1S Then
					pu.CrankRotation = -1S
				Else
					pu.CrankRotation = 1S
				End If
				kinemat.Kinconst(pu)
				kinemat.Unitstroke(pu)
				RSWIN_DESC.rst.PU = pu
				Dim flag3 As Boolean = DESIGN.Design()
				Dim bCheckToAdd As Boolean = False
				Dim flag4 As Boolean = False
				Dim num7 As Single
				str = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num7, bCheckToAdd, flag2, flag4, False, False)
				If flag Then
					Batch.BatchMessage("> new score rotation other direction: " + Conversions.ToString(num7))
				End If
				If num7 < fOrigTotalScore Then
					If flag Then
						Batch.BatchMessage("> Reverting rotation back")
					End If
					pu = RSWIN_DESC.rst.PU
					pu.CrankRotation = crankRotation
					kinemat.Kinconst(pu)
					kinemat.Unitstroke(pu)
					RSWIN_DESC.rst.PU = pu
					flag3 = DESIGN.Design()
				End If
				RSWIN_DESC.rst.RodStringType = rodStringType
				RSWIN_DESC.bImprovingScore = False
			Catch ex As Exception
			End Try
		End Sub

		Private Sub btnMeasUnit_Click(sender As Object, e As EventArgs)
			Dim text As String = ""
			Me.frmSystemOfUnits.Height = 70
			Me.frmSystemOfUnits.Width = 768
			Me.frmSystemOfUnits.Top = Me.Top + Me.panStatus.Top
			Me.frmSystemOfUnits.Left = Me.Left + Me.btnMeasUnit.Left - Me.frmSystemOfUnits.Width - 20
			Me.ResetClock()
			Try
				text = Me.ActiveMdiChild.Name
			Catch ex As Exception
				text = ""
			End Try
			Me.RemoveAllChildForms(False)
			Me.ResetClock()
			Me.frmSystemOfUnits.ShowDialog()
			If Operators.CompareString(text, "", False) <> 0 Then
				Me.DisplayForm(text, "")
				Return
			End If
		End Sub

		Private Sub tbrExpertAdmin_ButtonClick(sender As Object, e As ToolBarButtonClickEventArgs)
			Try
				Select Case Me.tbrExpertAdmin.Buttons.IndexOf(e.Button)
					Case 0
						Me.mnuToolsUploadRSVXFile.PerformClick()
					Case 1
						Me.mnuToolsUploadRSVXFiles.PerformClick()
					Case 2
						Me.mnuToolsBatchExportFromOneFolder.PerformClick()
					Case 3
						Me.mnuToolsBatchExportALL.PerformClick()
					Case 4
						Me.mnuToolsDownloadToRSVX.PerformClick()
					Case 5
						Me.mnuToolsDeleteTemplate.PerformClick()
					Case 6
						Me.mnuToolsEncryptTemplateDatabase.PerformClick()
					Case 7
						Util.BusyCursor()
						Me.frmDisplayAllDatabaseTemplates.ShowAddedOnly = False
						Me.frmDisplayAllDatabaseTemplates.ShowDialog()
						Util.UnbusyCursor()
					Case 8
						Util.BusyCursor()
						Me.frmDisplayAllDatabaseTemplates.ShowAddedOnly = True
						Me.frmDisplayAllDatabaseTemplates.ShowDialog()
						Util.UnbusyCursor()
					Case 9
						Util.BusyCursor()
						Me.RunAllTemplates()
						Util.UnbusyCursor()
				End Select
			Catch ex As Exception
			End Try
		End Sub

		Public Function PrefixInFilename(sFileName As String) As Boolean
			Dim flag As Boolean = False
			Dim result As Boolean
			Try
				Dim num As Integer = 0
				While Strings.InStr(sFileName, RSWIN_DESC.sExpertFilePrefixes(num), CompareMethod.Binary) <= 0
					num += 1
					If num > 11 Then
						IL_22:
						Return flag
					End If
				End While
				flag = True
				GoTo IL_22
			Catch ex As Exception
				result = flag
			End Try
			Return result
		End Function

		Public Function CheckFrictionAndPumpingUnit(ByRef TEMPPU As RSWIN_DESC.PUDataRec, sUnitID As String, bWriteDebug As Boolean) As String
			' The following expression was wrapped in a checked-statement
			Dim result As String
			Try
				Dim flag As Boolean = False
				Dim flag2 As Boolean = False
				Dim num As Integer = -1
				Dim num2 As Integer = -1
				Dim num3 As Integer = 0
				Dim num4 As Integer = 0
				Dim flag3 As Boolean = True
				If flag3 = (RSWIN_DESC.SETUP_TimesAvgRodTBGFricCoeff >= 2F And RSWIN_DESC.SETUP_TimesAvgRodTBGFricCoeff < 4F) Then
					num = 1
					num2 = 0
				ElseIf flag3 = (RSWIN_DESC.SETUP_TimesAvgRodTBGFricCoeff >= 4F And RSWIN_DESC.SETUP_TimesAvgRodTBGFricCoeff < 6F) Then
					num = 2
					num2 = 1
				ElseIf flag3 = (RSWIN_DESC.SETUP_TimesAvgRodTBGFricCoeff >= 6F And RSWIN_DESC.SETUP_TimesAvgRodTBGFricCoeff <= 10F) Then
					num = 3
					num2 = 2
				ElseIf flag3 = RSWIN_DESC.SETUP_TimesAvgRodTBGFricCoeff > 10F Then
					num = 4
					num2 = 2
				End If
				TEMPPU.Initialize()
				TEMPPU = RSWIN_DESC.rst.PU
				Dim gearboxRating As Single = TEMPPU.GearboxRating
				Dim structRating As Single = TEMPPU.StructRating
				Dim maxStroke As Single = TEMPPU.MaxStroke
				Dim text As String = RSWIN_DESC.rst.UnitID
				Dim text2 As String = text
				Debug.WriteLine(String.Concat(New String() { Conversions.ToString(gearboxRating), " , ", Conversions.ToString(structRating), " , ", Conversions.ToString(maxStroke), " , ", sUnitID }))
				Dim flag4 As Boolean = num <> -1
				If bWriteDebug Then
					Batch.BatchMessage(">In subroutine to improve initial pumping unit")
					Batch.BatchMessage(">Times Average Friction: " + Conversions.ToString(RSWIN_DESC.SETUP_TimesAvgRodTBGFricCoeff) + " , trying to skip to gearbox: " + Conversions.ToString(num))
					Batch.BatchMessage(String.Concat(New String() { ">original unit: ", RSWIN_DESC.rst.UnitID, " , ", Conversions.ToString(gearboxRating), "-", Conversions.ToString(structRating), "-", Conversions.ToString(maxStroke) }))
				End If
				Dim flag9 As Boolean
				While flag4
					Dim fGearboxRating As Single = gearboxRating
					Dim fStructRating As Single = structRating
					Dim fMaxStroke As Single = maxStroke
					Dim flag5 As Boolean = False
					Dim flag6 As Boolean = False
					Dim flag7 As Boolean = False
					Dim flag8 As Boolean = False
					flag9 = PUDATA1.AdjustGearboxForScore(fGearboxRating, fStructRating, fMaxStroke, text, flag5, flag, flag6, flag7, flag8, False, True)
					If flag9 And Operators.CompareString(text, "", False) <> 0 And Operators.CompareString(text2, text, False) <> 0 Then
						num3 += 1
						TEMPPU.Initialize()
						TEMPPU = RSWIN_DESC.rst.PU
						PUDATA1.ReadPUData(text, TEMPPU, False, True)
						flag4 = True
						gearboxRating = TEMPPU.GearboxRating
						structRating = TEMPPU.StructRating
						Debug.WriteLine(String.Concat(New String() { Conversions.ToString(gearboxRating), " , ", Conversions.ToString(structRating), " , ", Conversions.ToString(TEMPPU.MaxStroke), " , ", text }))
						If num3 = num Then
							flag4 = False
						End If
						text2 = text
					Else
						text = text2
						flag4 = False
					End If
				End While
				If bWriteDebug Then
					Batch.BatchMessage(String.Concat(New String() { ">new unit: ", text, " , ", Conversions.ToString(gearboxRating), "-", Conversions.ToString(structRating), "-", Conversions.ToString(maxStroke) }))
				End If
				If bWriteDebug Then
					Batch.BatchMessage(String.Concat(New String() { ">new unit: ", text, " , ", Conversions.ToString(gearboxRating), "-", Conversions.ToString(structRating), "-", Conversions.ToString(maxStroke) }))
					Batch.BatchMessage(">searching structure num: " + Conversions.ToString(num2))
				End If
				Dim iStructure As Integer
				flag9 = PUDATA1.AdjustStructureForScore(TEMPPU.GearboxRating, TEMPPU.StructRating, TEMPPU.MaxStroke, text, bWriteDebug, flag2, False, False, False, iStructure)
				If Not flag9 Or Operators.CompareString(text, "", False) = 0 Then
					text2 = ""
					flag4 = (num2 <> -1)
					While flag4
						flag9 = PUDATA1.AdjustStructureForScore(TEMPPU.GearboxRating, TEMPPU.StructRating, TEMPPU.MaxStroke, text, bWriteDebug, flag2, False, True, False, 0)
						If flag9 And Operators.CompareString(text, "", False) <> 0 And Operators.CompareString(text2, text, False) <> 0 Then
							num4 += 1
							TEMPPU.Initialize()
							TEMPPU = RSWIN_DESC.rst.PU
							PUDATA1.ReadPUData(text, TEMPPU, False, True)
							flag4 = True
							gearboxRating = TEMPPU.GearboxRating
							structRating = TEMPPU.StructRating
							Dim structL As Single = RSWIN_DESC.rst.StructL
							Debug.WriteLine(String.Concat(New String() { Conversions.ToString(gearboxRating), " , ", Conversions.ToString(structRating), " , ", Conversions.ToString(TEMPPU.MaxStroke), " , ", text }))
							If num4 = num2 Then
								flag4 = False
							End If
							text2 = text
						Else
							text = text2
							flag4 = False
						End If
					End While
				End If
				If bWriteDebug Then
					Batch.BatchMessage(String.Concat(New String() { ">new unit: ", text, " , ", Conversions.ToString(gearboxRating), "-", Conversions.ToString(structRating), "-", Conversions.ToString(maxStroke) }))
					Batch.BatchMessage(">Leaving subroutine to improve initial pumping unit")
				End If
				result = text
			Catch ex As Exception
				result = sUnitID
			End Try
			Return result
		End Function

		Public Function TryToMatchMaxStroke(TEMPPU As RSWIN_DESC.PUDataRec, fMaxStroke As Single, ByRef iNewCrankHole As Integer) As Boolean
			' The following expression was wrapped in a checked-statement
			Dim result As Boolean
			Try
				iNewCrankHole = -1
				Dim num As Integer = 1
				Dim crankHoles As Integer = CInt(TEMPPU.CrankHoles)
				For i As Integer = num To crankHoles
					If RSWIN_DESC.rst.PU.Strokes(i - 1) >= fMaxStroke Then
						iNewCrankHole = i
					End If
				Next
				result = (iNewCrankHole <> -1)
			Catch ex As Exception
				result = True
			End Try
			Return result
		End Function

		Private Sub RunAllTemplates()
			Dim guruFileDataStructure As RSWIN_DESC.GuruFileDataStructure = Nothing
			Dim num As Integer = 0
			Dim num2 As Integer = 0
			Dim num3 As Integer = 0
			Dim num4 As Integer = 0
			Dim num5 As Integer = 0
			Dim num6 As Integer = 0
			Dim num7 As Single = 0F
			Dim setup_bAdminDebug As Boolean = RSWIN_DESC.SETUP_bAdminDebug
			Dim flag As Boolean = True
			Dim flag2 As Boolean = False
			Dim str As String = ""
			Dim str2 As String = ""
			If RSWIN_DESC.SETUP_bGuru Then
				MessageBox.Show("Please switch to non-AI mode before Running/Checking All Templates!")
			Else
				Me.Message("Running All Templates!")
				Dim msg As String = "Run/Check all templates. Are you sure?"
				Dim bDefaultYes As Boolean = False
				Dim flag3 As Boolean = False
				If Util.YesNo(msg, bDefaultYes, flag3) Then
					RSWIN_DESC.bRunAllTemplates = True
					RSWIN_DESC.bCheck4Sentinel = False
					If FILEUTIL.FileExists(RSWIN_DESC.sAIRunAllLog) Then
						FileSystem.Kill(RSWIN_DESC.sAIRunAllLog)
					End If
					RSWIN_DESC.SETUP_bAdminDebug = False
					RSWIN_DESC.frn_AI_Run_All_log = CShort(FileSystem.FreeFile())
					FileSystem.FileOpen(CInt(RSWIN_DESC.frn_AI_Run_All_log), RSWIN_DESC.sAIRunAllLog, OpenMode.Append, OpenAccess.[Default], OpenShare.[Default], -1)
					FileSystem.PrintLine(CInt(RSWIN_DESC.frn_AI_Run_All_log), New Object() { "Run Datetime: " + DateAndTime.Now.ToString() })
					FileSystem.PrintLine(CInt(RSWIN_DESC.frn_AI_Run_All_log), New Object() { " Time , Template , Original Score , New Score , Production/Target " })
					GURU_DB.ReLoadALLGuruFiledata()
					RSWIN_DESC.bGuruFileDataLoaded = True
					Dim num8 As Integer = 1
					Dim iGuruFileCount As Integer = RSWIN_DESC.iGuruFileCount
					Dim num9 As Integer = num8
					Dim num10 As Integer = iGuruFileCount
					For i As Integer = num9 To num10
						RSWIN_DESC.rst = New cRODSTAR()
						guruFileDataStructure = Nothing
						guruFileDataStructure.Initialize()
						guruFileDataStructure = RSWIN_DESC.AllGuruFiles(i)
						GURU_DB.CopyGuruFiledata2RSTObj(i, True)
						RSWIN_DESC.bSuppressWarningMessages = True
						Me.panStatus.Text = "   Running template " + guruFileDataStructure.FileName
						DESIGN.Design()
						Dim fTemplateTotalAIScore As Single = RSWIN_DESC.fTemplateTotalAIScore
						Dim bCheckToAdd As Boolean = False
						flag3 = False
						Dim flag4 As Boolean
						Dim sTemplateTotalAIScore As String = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, fTemplateTotalAIScore, bCheckToAdd, flag4, flag3, False, False)
						RSWIN_DESC.fTemplateTotalAIScore = fTemplateTotalAIScore
						RSWIN_DESC.sTemplateTotalAIScore = sTemplateTotalAIScore
						Me.panStatus.Text = "   Running template " + guruFileDataStructure.FileName + " , Original Score: " + Conversions.ToString(RSWIN_DESC.fTemplateTotalAIScore)

							If flag Then
								Me.TryToImproveScore(num, num2, num3, num4, num5, num6, RSWIN_DESC.fTemplateTotalAIScore)
								Dim flag5 As Boolean
								Dim num11 As Integer = If((-If((flag5 > False), 1, 0)), 1, 0)
								flag3 = False
								Me.MakeRun(num11, flag3)
								flag5 = (num11 <> 0)
								Dim flag6 As Boolean
								Dim text As String = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num7, False, flag4, flag6, False, False)
								Me.ExtraSmallerGearboxAndSLCheck(num, num2, num3, num4, num5, num6, RSWIN_DESC.fTemplateTotalAIScore, flag2, str, str2)
								text = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num7, False, flag4, flag6, False, False)
								If flag2 Then
									FileSystem.PrintLine(CInt(RSWIN_DESC.frn_AI_Run_All_log), New Object() { " Pumping Unit Changed: From: " + str + "  , To: " + str2 })
								End If
								If RODUTIL.CheckForOverloadedRods() Or (CDbl(RSWIN_DESC.rst.StructL) > 0.95 And RSWIN_DESC.rst.SPM < 9F And CDbl(RSWIN_DESC.rst.SystemEff) > 0.42) Then
									Dim flag7 As Boolean = Me.TrySmallerPlungerSize(num, num2, num3, num4, num5, num6, num7)
									text = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num7, False, flag4, flag6, False, False)
									If(If((-If((flag7 > False), 1S, 0S)), 1S, 0S) And Not RSWIN_DESC.rst.PU.RequiredRotation And If((-If((num7 < 1F > False), 1S, 0S)), 1S, 0S)) <> 0S Then
										Me.TryDifferentRotationDirection(num, num2, num3, num4, num5, num6, num7)
										text = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num7, False, flag4, flag6, False, False)
									End If
								End If
								text = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num7, False, flag4, flag6, False, False)
								If RSWIN_DESC.SETUP_bUseFGlassWithSteelOnBottom AndAlso flag6 Then
									RSWIN_DESC.bAIScoreImproved = Me.TryToImproveRodLoadingScoreOnly(num2, RSWIN_DESC.fTemplateTotalAIScore, False, num7)
									text = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num7, False, flag4, flag6, False, False)
								End If
								If CDbl(num7) >= 0.98 And num4 < 100 Then
									Dim flag7 As Boolean = Me.TryLargerPlungerSize(num, num2, num3, num4, num5, num6, num7)
									text = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num7, False, flag4, flag6, False, False)
									If(If((-If((flag7 > False), 1S, 0S)), 1S, 0S) And Not RSWIN_DESC.rst.PU.RequiredRotation And If((-If((num7 < 1F > False), 1S, 0S)), 1S, 0S)) <> 0S Then
										Me.TryDifferentRotationDirection(num, num2, num3, num4, num5, num6, num7)
										text = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num7, False, flag4, flag6, False, False)
									End If
								End If
								If(num7 > RSWIN_DESC.fTemplateTotalAIScore And CDbl(num7) > 0.93) Or (num7 > RSWIN_DESC.fTemplateTotalAIScore And RSWIN_DESC.fTemplateTotalAIScore <> 0F And RSWIN_DESC.SETUP_TimesAvgRodTBGFricCoeff = 1F) Then
									RSWIN_DESC.bAIScoreImproved = True
								End If
								Me.panStatus.Text = String.Concat(New String() { "   Running template ", guruFileDataStructure.FileName, " , Original Score: ", RSWIN_DESC.sTemplateTotalAIScore, " , New Score: ", Conversions.ToString(num7), " , Percent Production: ", Conversions.ToString(RSWIN_DESC.rst.BPDsurface / RSWIN_DESC.rst.TargetBFPD) })
								If RSWIN_DESC.bAIScoreImproved AndAlso CDbl((RSWIN_DESC.rst.BPDsurface / RSWIN_DESC.rst.TargetBFPD)) < 0.965 Then
									RSWIN_DESC.bAIScoreImproved = False
								End If
								If RSWIN_DESC.bAIScoreImproved Then
									guruFileDataStructure.Initialize()
									GURU_DB.CopyRST2Filedata(guruFileDataStructure, RSWIN_DESC.AllGuruFiles(i).Original)
									guruFileDataStructure.FileName = RSWIN_DESC.AllGuruFiles(i).FileName
									guruFileDataStructure.DateAdded = DateAndTime.Now.[Date]
									guruFileDataStructure.Original = RSWIN_DESC.AllGuruFiles(i).Original
									RSWIN_DESC.AllGuruFiles(i) = guruFileDataStructure
									GURU_DB.UpdateRow(i, guruFileDataStructure.FileName.Trim(), True)
									FileSystem.PrintLine(CInt(RSWIN_DESC.frn_AI_Run_All_log), New Object() { String.Concat(New String() { DateAndTime.Now.ToString(), " Template ", guruFileDataStructure.FileName, " Updated! , Original Score ", Conversions.ToString(RSWIN_DESC.fTemplateTotalAIScore), " , New Score ", Conversions.ToString(num7) }) })
								End If
							End If

					Next
					FileSystem.FileClose(New Integer() { CInt(RSWIN_DESC.frn_AI_Run_All_log) })
					Me.Message("Finished running all templates!")
					RSWIN_DESC.bRunAllTemplates = False
					RSWIN_DESC.bSuppressWarningMessages = False
				Else
					Me.Message(" ")
					RSWIN_DESC.bRunAllTemplates = False
				End If
				RSWIN_DESC.SETUP_bAdminDebug = setup_bAdminDebug
			End If
			RSWIN_DESC.bSuppressWarningMessages = False
			RSWIN_DESC.bCheck4Sentinel = True
		End Sub

		Private Sub RunAllTemplates_Save()
			Dim guruFileDataStructure As RSWIN_DESC.GuruFileDataStructure = Nothing
			Dim num As Integer = 0
			Dim num2 As Integer = 0
			Dim num3 As Integer = 0
			Dim num4 As Integer = 0
			Dim num5 As Integer = 0
			Dim num6 As Integer = 0
			Dim num7 As Single = 0F
			Dim setup_bAdminDebug As Boolean = RSWIN_DESC.SETUP_bAdminDebug
			Dim flag As Boolean = True
			If RSWIN_DESC.SETUP_bGuru Then
				MessageBox.Show("Please switch to non-AI mode before Running/Checking All Templates!")
				Return
			End If
			Me.Message("Running All Templates!")
			Dim msg As String = "Run/Check all templates. Are you sure?"
			Dim bDefaultYes As Boolean = False
			Dim flag2 As Boolean = False
			If Util.YesNo(msg, bDefaultYes, flag2) Then
				RSWIN_DESC.bRunAllTemplates = True
				If FILEUTIL.FileExists(RSWIN_DESC.sAIRunAllLog) Then
					FileSystem.Kill(RSWIN_DESC.sAIRunAllLog)
				End If
				RSWIN_DESC.SETUP_bAdminDebug = False
				RSWIN_DESC.frn_AI_Run_All_log = CShort(FileSystem.FreeFile())
				FileSystem.FileOpen(CInt(RSWIN_DESC.frn_AI_Run_All_log), RSWIN_DESC.sAIRunAllLog, OpenMode.Append, OpenAccess.[Default], OpenShare.[Default], -1)
				FileSystem.PrintLine(CInt(RSWIN_DESC.frn_AI_Run_All_log), New Object() { "Run Datetime: " + DateAndTime.Now.ToString() })
				FileSystem.PrintLine(CInt(RSWIN_DESC.frn_AI_Run_All_log), New Object() { " Time , Template , Original Score , New Score , Production/Target " })
				GURU_DB.ReLoadALLGuruFiledata()
				RSWIN_DESC.bGuruFileDataLoaded = True
				Dim num8 As Integer = 1
				Dim iGuruFileCount As Integer = RSWIN_DESC.iGuruFileCount
				Dim num9 As Integer = num8
				Dim num10 As Integer = iGuruFileCount
				For i As Integer = num9 To num10
					RSWIN_DESC.rst = New cRODSTAR()
					guruFileDataStructure = Nothing
					guruFileDataStructure.Initialize()
					guruFileDataStructure = RSWIN_DESC.AllGuruFiles(i)
					GURU_DB.CopyGuruFiledata2RSTObj(i, True)
					RSWIN_DESC.bSuppressWarningMessages = True
					Me.panStatus.Text = "   Running template " + guruFileDataStructure.FileName
					DESIGN.Design()
					Dim fTemplateTotalAIScore As Single = RSWIN_DESC.fTemplateTotalAIScore
					Dim bCheckToAdd As Boolean = False
					flag2 = False
					Dim flag3 As Boolean
					Dim sTemplateTotalAIScore As String = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, fTemplateTotalAIScore, bCheckToAdd, flag3, flag2, False, False)
					RSWIN_DESC.fTemplateTotalAIScore = fTemplateTotalAIScore
					RSWIN_DESC.sTemplateTotalAIScore = sTemplateTotalAIScore
					Me.panStatus.Text = "   Running template " + guruFileDataStructure.FileName + " , Original Score: " + Conversions.ToString(RSWIN_DESC.fTemplateTotalAIScore)

						If flag Then
							Me.TryToImproveScore(num, num2, num3, num4, num5, num6, RSWIN_DESC.fTemplateTotalAIScore)
							Dim flag4 As Boolean
							Dim num11 As Integer = If((-If((flag4 > False), 1, 0)), 1, 0)
							flag2 = False
							Me.MakeRun(num11, flag2)
							flag4 = (num11 <> 0)
							Dim flag5 As Boolean
							Dim text As String = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num7, False, flag3, flag5, False, False)
							If RSWIN_DESC.rst.SPM < 9F And CDbl(RSWIN_DESC.rst.GearboxLoading(RSWIN_DESC.i2Score)) <= 0.9 Then
								Dim fTemplateTotalAIScore2 As Single = RSWIN_DESC.fTemplateTotalAIScore
								flag2 = False
								Dim text2 As String = ""
								Dim text3 As String = ""
								Me.ExtraSmallerGearboxAndSLCheck(num, num2, num3, num4, num5, num6, fTemplateTotalAIScore2, flag2, text2, text3)
								text = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num7, False, flag3, flag5, False, False)
							Else
								Me.ExtraSmallerGearboxCheck(num, num2, num3, num4, num5, num6, num7, CDbl(RSWIN_DESC.rst.GearboxLoading(RSWIN_DESC.i2Score)) < 0.85)
								text = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num7, False, flag3, flag5, False, False)
							End If
							If RODUTIL.CheckForOverloadedRods() Or (CDbl(RSWIN_DESC.rst.StructL) > 0.95 And RSWIN_DESC.rst.SPM < 9F And CDbl(RSWIN_DESC.rst.SystemEff) > 0.42) Then
								Dim flag6 As Boolean = Me.TrySmallerPlungerSize(num, num2, num3, num4, num5, num6, num7)
								text = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num7, False, flag3, flag5, False, False)
								If(If((-If((flag6 > False), 1S, 0S)), 1S, 0S) And Not RSWIN_DESC.rst.PU.RequiredRotation And If((-If((num7 < 1F > False), 1S, 0S)), 1S, 0S)) <> 0S Then
									Me.TryDifferentRotationDirection(num, num2, num3, num4, num5, num6, num7)
									text = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num7, False, flag3, flag5, False, False)
								End If
							End If
							text = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num7, False, flag3, flag5, False, False)
							If RSWIN_DESC.SETUP_bUseFGlassWithSteelOnBottom AndAlso flag5 Then
								RSWIN_DESC.bAIScoreImproved = Me.TryToImproveRodLoadingScoreOnly(num2, RSWIN_DESC.fTemplateTotalAIScore, False, num7)
								text = RSWIN.TotalExpertScore(num, num2, num3, num4, num5, num6, num7, False, flag3, flag5, False, False)
							End If
							If(num7 > RSWIN_DESC.fTemplateTotalAIScore And CDbl(num7) > 0.93) Or (num7 > RSWIN_DESC.fTemplateTotalAIScore And RSWIN_DESC.fTemplateTotalAIScore <> 0F And RSWIN_DESC.SETUP_TimesAvgRodTBGFricCoeff = 1F) Then
								RSWIN_DESC.bAIScoreImproved = True
							End If
							Me.panStatus.Text = String.Concat(New String() { "   Running template ", guruFileDataStructure.FileName, " , Original Score: ", RSWIN_DESC.sTemplateTotalAIScore, " , New Score: ", Conversions.ToString(num7), " , Percent Production: ", Conversions.ToString(RSWIN_DESC.rst.BPDsurface / RSWIN_DESC.rst.TargetBFPD) })
							If RSWIN_DESC.bAIScoreImproved AndAlso CDbl((RSWIN_DESC.rst.BPDsurface / RSWIN_DESC.rst.TargetBFPD)) < 0.965 Then
								RSWIN_DESC.bAIScoreImproved = False
							End If
							If RSWIN_DESC.bAIScoreImproved Then
								guruFileDataStructure.Initialize()
								GURU_DB.CopyRST2Filedata(guruFileDataStructure, RSWIN_DESC.AllGuruFiles(i).Original)
								guruFileDataStructure.FileName = RSWIN_DESC.AllGuruFiles(i).FileName
								guruFileDataStructure.DateAdded = DateAndTime.Now.[Date]
								guruFileDataStructure.Original = RSWIN_DESC.AllGuruFiles(i).Original
								RSWIN_DESC.AllGuruFiles(i) = guruFileDataStructure
								GURU_DB.UpdateRow(i, guruFileDataStructure.FileName.Trim(), True)
								FileSystem.PrintLine(CInt(RSWIN_DESC.frn_AI_Run_All_log), New Object() { String.Concat(New String() { DateAndTime.Now.ToString(), " Template ", guruFileDataStructure.FileName, " Updated! , Original Score ", Conversions.ToString(RSWIN_DESC.fTemplateTotalAIScore), " , New Score ", Conversions.ToString(num7) }) })
							End If
						End If

				Next
				FileSystem.FileClose(New Integer() { CInt(RSWIN_DESC.frn_AI_Run_All_log) })
				Me.Message("Finished running all templates!")
				RSWIN_DESC.bRunAllTemplates = False
				RSWIN_DESC.bSuppressWarningMessages = False
			Else
				Me.Message(" ")
				RSWIN_DESC.bRunAllTemplates = False
			End If
			RSWIN_DESC.SETUP_bAdminDebug = setup_bAdminDebug
		End Sub

		Public Sub CheckWellInfo()
			Dim rst As cRODSTAR = RSWIN_DESC.rst
			If rst.gbCalcFluidSPGR Then
				Util.CheckFluidSPGR()
				If rst.FluidSPGR = 0F Then
					rst.FluidSPGR = rst.gfMaxFluidSPGR
				End If
			End If
		End Sub

		Public Sub ResizeRswinsetup(ByRef frmRswinSetup As RswinSetup)
			Try
				Me.ResetClock()
			Catch ex As Exception
			End Try
			Me.SAVE_SETUP_Language = RSWIN_DESC.SETUP_Language
		End Sub

		Public Sub Message_Status(msgtxt As String)
			Try
				Me.panStatus.Text = msgtxt
			Catch ex As Exception
			End Try
		End Sub

		Private Sub tmrClock_Tick(eventSender As Object, eventArgs As EventArgs)
			If(RSWIN_DESC.SETUP_ExitIfIdle And If((-If((Not RSWIN_DESC.gbDemoMode > False), 1S, 0S)), 1S, 0S) And If((-If((Not RSWIN_DESC.rst.gbAutomatic > False), 1S, 0S)), 1S, 0S)) <> 0S Then
				' The following expression was wrapped in a checked-statement
				If DateAndTime.Hour(DateAndTime.Now) = DateAndTime.Hour(Me.NowTime) + DateAndTime.Hour(RSWIN_DESC.SETUP_IntervalTime) Then
					If DateAndTime.Minute(DateAndTime.Now) = DateAndTime.Minute(Me.NowTime) + DateAndTime.Minute(RSWIN_DESC.SETUP_IntervalTime) And DateAndTime.Second(DateAndTime.Now) >= DateAndTime.Second(Me.NowTime) + DateAndTime.Second(RSWIN_DESC.SETUP_IntervalTime) Then
						Me.bEnd = True
					ElseIf DateAndTime.Minute(DateAndTime.Now) > DateAndTime.Minute(Me.NowTime) + DateAndTime.Minute(RSWIN_DESC.SETUP_IntervalTime) Then
						Me.bEnd = True
					End If
				ElseIf DateAndTime.Hour(DateAndTime.Now) > DateAndTime.Hour(Me.NowTime) + DateAndTime.Hour(RSWIN_DESC.SETUP_IntervalTime) Then
					Me.bEnd = True
				End If
				If Me.bEnd Then
					Me.tmrClock.Enabled = False
					If(RSWIN_DESC.SETUP_SaveOpenFileOnExit And If((-If(((Me.mnuFileSave.Enabled Or Me.mnuFileSaveAs_.Enabled Or Me.tbrToolbar.Buttons(2).Enabled) > False), 1S, 0S)), 1S, 0S)) <> 0S AndAlso RSWIN_DESC.rst.Inputfile IsNot Nothing AndAlso Not(Operators.CompareString(RSWIN_DESC.rst.Inputfile, "", False) = 0 Or Operators.CompareString(RSWIN_DESC.rst.Inputfile, "(Untitled)", False) = 0) Then
						Me.SAVEAFILE(False, False, False, False, False, False, RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru)
					End If
					If Me.mTLM32 IsNot Nothing AndAlso Operators.CompareString(Me.mTLM32.LicenseType, "", False) <> 0 Then
						Me.mTLM32.ReleaseLicense()
					End If
					ProjectData.EndApp()
					Return
				End If
			Else
				If Not RSWIN_DESC.SETUP_ExitIfIdle = 0S Then
					Return
				End If
				Me.tmrClock.Enabled = False
			End If
		End Sub

		Public Sub ResetClock()
			Try
				If(RSWIN_DESC.bExpert And RSWIN_DESC.SETUP_bGuru) Or (RSWIN_DESC.bExpert And RSWIN_DESC.bXRODAdmin) Then
					Me.tmrClock.Enabled = False
				ElseIf RSWIN_DESC.SETUP_ExitIfIdle <> 0S Then
					Me.bEnd = False
					Me.tmrClock.Enabled = False
					Me.NowTime = DateAndTime.Now
					Me.tmrClock.Enabled = True
				ElseIf RSWIN_DESC.rst IsNot Nothing Then
					If RSWIN_DESC.rst.gbAutomatic Or RSWIN_DESC.rst.gbBatch Then
						Me.tmrClock.Enabled = False
					End If
				Else
					Me.tmrClock.Enabled = False
				End If
			Catch ex As Exception
			End Try
		End Sub

		Public Sub TurnOnClock()
			Try
				Me.bEnd = False
				Me.tmrClock.Enabled = False
				Me.NowTime = DateAndTime.Now
				Me.tmrClock.Enabled = True
			Catch ex As Exception
			End Try
		End Sub

		Public Sub TurnOffClock()
			Try
				Me.tmrClock.Enabled = False
			Catch ex As Exception
			End Try
		End Sub

		Private Sub Rodstar_MouseDoubleClick(sender As Object, e As MouseEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub Rodstar_MouseDown(sender As Object, e As MouseEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub Rodstar_MouseEnter(sender As Object, e As EventArgs)
			Me.ResetClock()
		End Sub

		Private Sub Rodstar_MouseMove(sender As Object, e As MouseEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub Rodstar_MouseUp(sender As Object, e As MouseEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub Rodstar_MouseWheel(sender As Object, e As MouseEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub Rodstar_Move(sender As Object, e As EventArgs)
			Me.ResetClock()
		End Sub

		Private Sub Rodstar_Scroll(sender As Object, e As ScrollEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub Rodstar_KeyPress(sender As Object, e As KeyPressEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub Rodstar_KeyUp(sender As Object, e As KeyEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub Rodstar_DragDrop(sender As Object, e As DragEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub Rodstar_DragEnter(sender As Object, e As DragEventArgs)
			Me.ResetClock()
		End Sub

		Private Sub Rodstar_FormClosed(sender As Object, e As FormClosedEventArgs)
			Me.DisableTimeClock()
		End Sub

		Private Sub Rodstar_FormClosing(sender As Object, e As FormClosingEventArgs)
			Me.bClosing = True
			Me.DisableTimeClock()
		End Sub

		Private Sub Rodstar_LostFocus(sender As Object, e As EventArgs)
			Me.DisableTimeClock()
		End Sub

		Private Sub Rodstar_GotFocus(sender As Object, e As EventArgs)
			Me.ResetClock()
		End Sub

		Public Sub Control__LostFocus(ByRef cntrl As Control)
			CtrlUI.Control_LostFocus(cntrl)
			Me.ResetClock()
		End Sub

		Public Sub TextBox__LostFocus(ByRef txt As TextBox, Optional ByRef lbl As Label = Nothing, Optional bRequiredColor As Boolean = True)
			CtrlUI.TextBox_LostFocus(txt, lbl, bRequiredColor)
			Me.ResetClock()
		End Sub

		Public Sub TextBox__KeyDown(ByRef txt As TextBox, ByRef lbl As Label, KeyCode As Integer, Shift As Integer)
			CtrlUI.TextBox_KeyDown(txt, lbl, KeyCode, Shift)
			Me.ResetClock()
		End Sub

		Public Sub DisableTimeClock()
			Try
				Me.tmrClock.Enabled = False
			Catch ex As Exception
			End Try
		End Sub

		Public Sub SentinelUnplugged(Optional bExit As Boolean = True)
			NewLateBinding.LateCall(Nothing, GetType(MessageBox), "Show", New Object() { RuntimeHelpers.GetObjectValue(Interaction.IIf(bExit, "Please connect sentinel to continue otherwise application will close.", "Please connect sentinel to continue.")), "Sentinel does not appear to be connected!" }, Nothing, Nothing, Nothing, True)
			Application.DoEvents()
			Me.mTLM32.ReCheckLicense_Thread()
			If Not Me.mTLM32.SentinelFound Then
				If bExit Then
					ProjectData.EndApp()
				End If
				Return
			End If
		End Sub

		Private Sub panStatus_PanelClick(sender As Object, e As StatusBarPanelClickEventArgs)
		End Sub

		Private Sub RODSTAR_TextChanged(sender As Object, e As EventArgs)
		End Sub

		Private Sub MakePDF(ByRef rfn As String)
			Try
				Dim results As Results = New Results()
				Util.BusyCursor()
				Dim msgtxt As String = "Saving results to " + rfn
				Me.Message(msgtxt)
				Dim formName As String = "Results"
				Dim form As Form = results
				Dim flag As Boolean = Me.ReturnMdiForm(formName, form)
				results = CType(form, Results)
				If Not flag Then
					Me.AddResults(False)
					Dim formName2 As String = "Results"
					form = results
					Me.ReturnMdiForm(formName2, form)
					results = CType(form, Results)
				End If
				RSWIN_DESC.bPDFFileSaved = False
				results.StorePDFFile(rfn)
				While Not RSWIN_DESC.bPDFFileSaved
					Application.DoEvents()
				End While
				Util.UnbusyCursor()
				msgtxt = "Results saved to " + rfn
				Me.Message(msgtxt)
			Catch ex As Exception
			End Try
		End Sub

		Public Function IsInCustomRodGradeDB(CustomRodGradeItem As RSWIN_DESC.CustomRodGrade) As Object
			' The following expression was wrapped in a checked-statement
			Dim result As Object
			Try
				Dim flag As Boolean = False
				Dim num As Integer = 1
				Dim num2 As Integer = Information.UBound(RSWIN_DESC.CustomRodGradeList, 1)
				For i As Integer = num To num2
					If Operators.CompareString(RSWIN_DESC.CustomRodGradeList(i).RodType, CustomRodGradeItem.RodType, False) = 0 Then
						flag = True
						Exit For
					End If
				Next
				result = flag
			Catch ex As Exception
			End Try
			Return result
		End Function

		Public Sub ReassignVariables()
			Try
				Me.sDetent = Util.AssignValueToConstant("RODSTAR", "sDetent", "Detent")
				Me.sNonDetent = Util.AssignValueToConstant("RODSTAR", "sNonDetent", "Non-detent")
				Me.sSpeedVar = ""
				Me.sSpeedVariationNotIncluded = Util.AssignValueToConstant("RODSTAR", "sSpeedVariationNotIncluded", " Motor speed variation: not included.")
				Me.sSpeedVariationIncluded = Util.AssignValueToConstant("RODSTAR", "sSpeedVariationIncluded", " Motor speed variation: included.")
				Me.sDYWExit = Util.AssignValueToConstant("RODSTAR", "sDYWExit", "Do you want to save your data before exiting ")
				Me.sDYWPrevCustomRG = Util.AssignValueToConstant("RODSTAR", "sDYWPrevCustomRG", "Do you want to bring over custom rod information from previous version?")
				Me.sDYWPrevCustomPU = Util.AssignValueToConstant("RODSTAR", "sDYWPrevCustomPU", "Do you want to bring over custom pumping unit information from previous version?")
				Me.sDYWRerun = Util.AssignValueToConstant("RODSTAR", "sDYWRerun", "The diagnosis in this file was made by an earlier version. Do you want to re-run this case for a more up-to-date diagnosis?")
				Me.sInitQuestion = Util.AssignValueToConstant("RODSTAR", "sInitQuestion", "Initialization Question")
				Me.sDYWChangePlungerSize = Util.AssignValueToConstant("RODSTAR", "sDYWChangePlungerSize", "Do you want to change the plunger size?")
				Me.sDYWSaveToDisk = Util.AssignValueToConstant("RODSTAR", "sDYWSaveToDisk", "Do you want to save this data on disk?")
				Me.sMNEPlungerSize = Util.AssignValueToConstant("RODSTAR", "sMNEPlungerSize", "The plunger size must not exceed")
				Me.sMNEPlungerSize1 = Util.AssignValueToConstant("RODSTAR", "sMNEPlungerSize1", "The plunger size must not exceed 1 inches for an insert pump to fit in 2 inch tubing.")
				Me.sMNEPlungerSize2 = Util.AssignValueToConstant("RODSTAR", "sMNEPlungerSize2", "The plunger size must not exceed 1 inches for a tubing pump to fit in 2 inch tubing.")
				Me.sToUsePlungerSize = Util.AssignValueToConstant("RODSTAR", "sToUsePlungerSize", "To use a plunger size of ")
				Me.sDYWAutoBatchSetup = Util.AssignValueToConstant("RODSTAR", "sDYWAutoBatchSetup", "Automatic batch mode has not been set up.  Do you want to go into Setup now?")
				Me.sDYWBatchPrint = Util.AssignValueToConstant("RODSTAR", "sDYWBatchPrint", "Do you want to have the batch run log printed?")
				Me.sBatchPrintNote = Util.AssignValueToConstant("RODSTAR", "sBatchPrintNote", "(Note that if you do not have the log printed, it will be very difficult to tell which cases have been run.)")
				Me.sCalcForFileInProgress = Util.AssignValueToConstant("RODSTAR", "sCalcForFileInProgress", "Calculations for File1 in progress.")
				Me.sSelectExportFolder = Util.AssignValueToConstant("RODSTAR", "sSelectExportFolder", "Select folder for exporting files.")
				Me.sCalcInProgress = Util.AssignValueToConstant("RODSTAR", "sCalcInProgress", "Calculations in progress.")
				Me.sBringOverCustomRodInfo = Util.AssignValueToConstant("RODSTAR", "sBringOverCustomRodInfo", "Do you want to bring over custom rod information from previous version?")
				Me.sBringOverCustomPumpingUnit = Util.AssignValueToConstant("RODSTAR", "sBringOverCustomPumpingUnit", "Do you want to bring over custom pumping unit information from previous version?")
				Me.sExportCBMoment = Util.AssignValueToConstant("RODSTAR", "sExportCBMoment", "Export counterbalance moment")
				Me.sExportRequiredUnbalance = Util.AssignValueToConstant("RODSTAR", "sExportRequiredUnbalance", "Export required structural unbalance")
			Catch ex As Exception
			End Try
		End Sub

		Public Sub InitializeBatchLogXML(sList As String())
			Try
				RSWIN_DESC.sBatchLogXML = ""
				RSWIN_DESC.sBatchLogXML += "<Data><Entries>"
				Dim num As Integer = Information.LBound(sList, 1)
				Dim num2 As Integer = Information.UBound(sList, 1)
				Dim num3 As Short
				Dim num4 As Short
				num3 = CShort(num)
				num4 = CShort(num2)
				For num5 As Short = num3 To num4
					Try
						If Not Information.IsDBNull(sList(CInt(num5))) Then
							RSWIN_DESC.sBatchLogXML += "<Row>"
							RSWIN_DESC.sBatchLogXML = RSWIN_DESC.sBatchLogXML + "<BatchEntry>" + sList(CInt(num5)) + "</BatchEntry>"
							RSWIN_DESC.sBatchLogXML += "</Row>"
						End If
					Catch ex As Exception
					End Try
				Next
				RSWIN_DESC.sBatchLogXML += "</Entries></Data>"
			Catch ex2 As Exception
			End Try
		End Sub

		Private Sub btnClose_Click(sender As Object, e As EventArgs)
			Me.pnlBatchLog.Visible = False
		End Sub

		Private Function ValidateActiveChildFormBeforeRun() As Boolean
			Dim text As String = ""
			Dim flag As Boolean = True
			Dim text2 As String
			Try
				text2 = Me.ActiveMdiChild.Name
			Catch ex As Exception
				text2 = ""
			End Try
			Util.BusyCursor()
			Try
				Util.BusyCursor()
				Application.DoEvents()
			Catch ex2 As Exception
			End Try
			Dim result As Boolean
			Try
				Dim text3 As String = text2
				Dim sProblemControlName As String
				If Operators.CompareString(text3, "WellInfo", False) = 0 Then
					If Not Me.ValidateWellInfo(sProblemControlName, True, False) Then
						flag = False
						Me.DisplayForm("WellInfo", sProblemControlName)
					End If
				ElseIf Operators.CompareString(text3, "ProdInfo", False) = 0 Then
					text = "ProdInfo"
					If Not Me.ValidateProdInfo(sProblemControlName, True, text, False) Then
						flag = False
						Me.DisplayForm("ProdInfo", sProblemControlName)
					End If
				ElseIf Operators.CompareString(text3, "PTInfo", False) = 0 Then
					If Not Me.ValidatePTInfo(sProblemControlName, True, False) Then
						flag = False
						Me.DisplayForm("PTInfo", sProblemControlName)
					End If
				ElseIf Operators.CompareString(text3, "RSInput", False) = 0 Then
					If Not Me.ValidateRSInput(sProblemControlName, True, False) Then
						flag = False
						Me.DisplayForm("RSInput", sProblemControlName)
					End If
				ElseIf Operators.CompareString(text3, "DeviationProfile", False) = 0 Then
					If RSWIN_DESC.bRodStarD Then
						If Not Me.ValidateDeviationProfile(sProblemControlName, True, False) Then
							flag = False
							Me.DisplayForm("DeviationProfile", sProblemControlName)
						End If
					End If
				ElseIf Operators.CompareString(text3, "PUData", False) = 0 Then
					If Not Me.ValidatePUData(sProblemControlName, True, False) Then
						flag = False
						Me.DisplayForm("PUData", sProblemControlName)
					End If
				ElseIf Operators.CompareString(text3, "MotorData", False) = 0 AndAlso Not Me.ValidateMotorData(sProblemControlName, True, False) Then
					flag = False
					Me.DisplayForm("MotorData", sProblemControlName)
				End If
				result = flag
			Catch ex3 As Exception
				result = True
			End Try
			Return result
		End Function

		Private Sub ResetFrictions()
			Try
				RSWIN_DESC.SETUP_BAREROD_FRICCOEFF = 0.2F
				Dim text As String = "BareRodFricCoeff"
				Dim text2 As String = Conversions.ToString(RSWIN_DESC.SETUP_BAREROD_FRICCOEFF)
				RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text, text2, RSWIN_DESC.sINIFile)
				RSWIN_DESC.SETUP_BAREROD_FRICCOEFF = Conversions.ToSingle(text2)
				RSWIN_DESC.SETUP_MOLDEDGUIDE_FRICCOEFF = RSWIN_DESC.fDefaultFricCoeff
				text2 = "MoldedFricCoeff"
				text = Conversions.ToString(RSWIN_DESC.SETUP_MOLDEDGUIDE_FRICCOEFF)
				RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text, RSWIN_DESC.sINIFile)
				RSWIN_DESC.SETUP_MOLDEDGUIDE_FRICCOEFF = Conversions.ToSingle(text)
				RSWIN_DESC.SETUP_WHEELGUIDE_FRICCOEFF = RSWIN_DESC.fDefaultFricCoeff
				text2 = "WheelFricCoeff"
				text = Conversions.ToString(RSWIN_DESC.SETUP_WHEELGUIDE_FRICCOEFF)
				RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text, RSWIN_DESC.sINIFile)
				RSWIN_DESC.SETUP_WHEELGUIDE_FRICCOEFF = Conversions.ToSingle(text)
				RSWIN_DESC.SETUP_OTHERGUIDE_FRICCOEFF = RSWIN_DESC.fDefaultFricCoeff
				text2 = "OtherFricCoeff"
				text = Conversions.ToString(RSWIN_DESC.SETUP_OTHERGUIDE_FRICCOEFF)
				RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text, RSWIN_DESC.sINIFile)
				RSWIN_DESC.SETUP_OTHERGUIDE_FRICCOEFF = Conversions.ToSingle(text)
				RSWIN_DESC.SETUP_NorrisStandardGuide_FRICCOEFF = RSWIN_DESC.fNorrisDefaultFricCoeff
				text2 = "NorrisStandardGuideFricCoeff"
				text = Conversions.ToString(RSWIN_DESC.SETUP_NorrisStandardGuide_FRICCOEFF)
				RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text, RSWIN_DESC.sINIFile)
				RSWIN_DESC.SETUP_NorrisStandardGuide_FRICCOEFF = Conversions.ToSingle(text)
				RSWIN_DESC.SETUP_NorrisSidewinderGuide_FRICCOEFF = RSWIN_DESC.fNorrisDefaultFricCoeff
				text2 = "NorrisSidewinderGuideFricCoeff"
				text = Conversions.ToString(RSWIN_DESC.SETUP_NorrisSidewinderGuide_FRICCOEFF)
				RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text, RSWIN_DESC.sINIFile)
				RSWIN_DESC.SETUP_NorrisSidewinderGuide_FRICCOEFF = Conversions.ToSingle(text)
				RSWIN_DESC.SETUP_RGIJakeCouplingGuide_FRICCOEFF = RSWIN_DESC.fNorrisDefaultFricCoeff
				text2 = "RGIJakeCouplingGuideFricCoeff"
				text = Conversions.ToString(RSWIN_DESC.SETUP_RGIJakeCouplingGuide_FRICCOEFF)
				RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text, RSWIN_DESC.sINIFile)
				RSWIN_DESC.SETUP_RGIJakeCouplingGuide_FRICCOEFF = Conversions.ToSingle(text)
				RSWIN_DESC.SETUP_RGISVTGuide_FRICCOEFF = RSWIN_DESC.fNorrisDefaultFricCoeff
				text2 = "RGISVTGuideFricCoeff"
				text = Conversions.ToString(RSWIN_DESC.SETUP_RGISVTGuide_FRICCOEFF)
				RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text, RSWIN_DESC.sINIFile)
				RSWIN_DESC.SETUP_RGISVTGuide_FRICCOEFF = Conversions.ToSingle(text)
				RSWIN_DESC.SETUP_RGITomahawkGuide_FRICCOEFF = RSWIN_DESC.fNorrisDefaultFricCoeff
				text2 = "RGITomahawkGuideFricCoeff"
				text = Conversions.ToString(RSWIN_DESC.SETUP_RGITomahawkGuide_FRICCOEFF)
				RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text, RSWIN_DESC.sINIFile)
				RSWIN_DESC.SETUP_RGITomahawkGuide_FRICCOEFF = Conversions.ToSingle(text)
				RSWIN_DESC.SETUP_RGITornadoGuide_FRICCOEFF = RSWIN_DESC.fNorrisDefaultFricCoeff
				text2 = "RGITornadoGuideFricCoeff"
				text = Conversions.ToString(RSWIN_DESC.SETUP_RGITornadoGuide_FRICCOEFF)
				RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text, RSWIN_DESC.sINIFile)
				RSWIN_DESC.SETUP_RGITornadoGuide_FRICCOEFF = Conversions.ToSingle(text)
				RSWIN_DESC.SETUP_RGITwisterGuide_FRICCOEFF = RSWIN_DESC.fNorrisDefaultFricCoeff
				text2 = "RGITwisterGuideFricCoeff"
				text = Conversions.ToString(RSWIN_DESC.SETUP_RGITwisterGuide_FRICCOEFF)
				RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text, RSWIN_DESC.sINIFile)
				RSWIN_DESC.SETUP_RGITwisterGuide_FRICCOEFF = Conversions.ToSingle(text)
				RSWIN_DESC.SETUP_RGIWVTGuide_FRICCOEFF = RSWIN_DESC.fNorrisDefaultFricCoeff
				text2 = "RGIWVTGuideFricCoeff"
				text = Conversions.ToString(RSWIN_DESC.SETUP_RGIWVTGuide_FRICCOEFF)
				RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text2, text, RSWIN_DESC.sINIFile)
				RSWIN_DESC.SETUP_RGIWVTGuide_FRICCOEFF = Conversions.ToSingle(text)
			Catch ex As Exception
			End Try
		End Sub

		Public Sub RunImplementationFromBatch()
			Dim flag As Boolean = False
			Try
				Dim num As Integer
				Dim text3 As String
				Try
					Dim text As String = "MeasurementSystem"
					num = 1
					RSWIN_DESC.SETUP_MeasurementSystem = Conversions.ToInteger(RSWIN.GetRegProfileStringByInt(RSWIN_DESC.SECT_GENERAL, text, num))
					If Not(RSWIN_DESC.SETUP_MeasurementSystem = 1 Or RSWIN_DESC.SETUP_MeasurementSystem = 2 Or RSWIN_DESC.SETUP_MeasurementSystem = 3) Then
						RSWIN_DESC.SETUP_MeasurementSystem = 1
						text = "MeasurementSystem"
						Dim obj As Object = RSWIN_DESC.SETUP_MeasurementSystem
						Dim text2 As String = Util.Format(obj)
						RSWIN_DESC.SETUP_MeasurementSystem = Conversions.ToInteger(obj)
						text3 = text2
						Dim num2 As Integer = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_GENERAL, text, text3, RSWIN_DESC.sINIFile)
					End If
				Catch ex As Exception
					RSWIN_DESC.SETUP_MeasurementSystem = 1
					text3 = "MeasurementSystem"
					Dim obj As Object = RSWIN_DESC.SETUP_MeasurementSystem
					Dim text4 As String = Util.Format(obj)
					RSWIN_DESC.SETUP_MeasurementSystem = Conversions.ToInteger(obj)
					Dim text As String = text4
					Dim num2 As Integer = RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_GENERAL, text3, text, RSWIN_DESC.sINIFile)
				End Try
				Dim flag2 As Boolean
				If RSWIN_DESC.SETUP_MeasurementSystem = 2 Then
					text3 = "DisplaySBinFeet"
					flag2 = True
					RSWIN_DESC.SETUP_DisplaySBinFeet = If((-If((RSWIN.GetRegProfileStringByBoolean(RSWIN_DESC.SECT_GENERAL, text3, flag2) > False), 1S, 0S)), 1S, 0S)
				End If
				text3 = "BareRodFricCoeff"
				Dim num3 As Single = 0.2F
				RSWIN_DESC.SETUP_BAREROD_FRICCOEFF = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text3, num3))
				text3 = "MoldedFricCoeff"
				RSWIN_DESC.SETUP_MOLDEDGUIDE_FRICCOEFF = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text3, RSWIN_DESC.fDefaultFricCoeff))
				text3 = "WheelFricCoeff"
				RSWIN_DESC.SETUP_WHEELGUIDE_FRICCOEFF = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text3, RSWIN_DESC.fDefaultFricCoeff))
				text3 = "OtherFricCoeff"
				RSWIN_DESC.SETUP_OTHERGUIDE_FRICCOEFF = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text3, RSWIN_DESC.fDefaultFricCoeff))
				text3 = "NorrisStandardGuideFricCoeff"
				RSWIN_DESC.SETUP_NorrisStandardGuide_FRICCOEFF = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text3, RSWIN_DESC.fNorrisDefaultFricCoeff))
				text3 = "NorrisSidewinderGuideFricCoeff"
				RSWIN_DESC.SETUP_NorrisSidewinderGuide_FRICCOEFF = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text3, RSWIN_DESC.fNorrisDefaultFricCoeff))
				text3 = "RGIJakeCouplingGuideFricCoeff"
				RSWIN_DESC.SETUP_RGIJakeCouplingGuide_FRICCOEFF = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text3, RSWIN_DESC.fNorrisDefaultFricCoeff))
				text3 = "RGISVTGuideFricCoeff"
				RSWIN_DESC.SETUP_RGISVTGuide_FRICCOEFF = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text3, RSWIN_DESC.fNorrisDefaultFricCoeff))
				text3 = "RGITomahawkGuideFricCoeff"
				RSWIN_DESC.SETUP_RGITomahawkGuide_FRICCOEFF = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text3, RSWIN_DESC.fNorrisDefaultFricCoeff))
				text3 = "RGITornadoGuideFricCoeff"
				RSWIN_DESC.SETUP_RGITornadoGuide_FRICCOEFF = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text3, RSWIN_DESC.fNorrisDefaultFricCoeff))
				text3 = "RGITwisterGuideFricCoeff"
				RSWIN_DESC.SETUP_RGITwisterGuide_FRICCOEFF = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text3, RSWIN_DESC.fNorrisDefaultFricCoeff))
				text3 = "RGIWVTGuideFricCoeff"
				RSWIN_DESC.SETUP_RGIWVTGuide_FRICCOEFF = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text3, RSWIN_DESC.fNorrisDefaultFricCoeff))
				text3 = "BareRodLoad"
				num3 = 50F
				RSWIN_DESC.SETUP_BAREROD_LOAD = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text3, num3))
				text3 = "MoldedLoad"
				num3 = 40F
				RSWIN_DESC.SETUP_MOLDEDGUIDE_LOAD = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text3, num3))
				text3 = "WheelLoad"
				num3 = 25F
				RSWIN_DESC.SETUP_WHEELGUIDE_LOAD = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text3, num3))
				text3 = "OtherLoad"
				num3 = 32.5F
				RSWIN_DESC.SETUP_OTHERGUIDE_LOAD = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text3, num3))
				text3 = "MaxSideLoadLimit"
				num3 = 30F
				RSWIN_DESC.SETUP_MaxSideLoadLimit = Conversions.ToSingle(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text3, num3))
				text3 = "RodGuideOverlap"
				num3 = 150F
				RSWIN_DESC.Setup_RodGuideOverlap = Conversions.ToInteger(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text3, num3))
				text3 = "NumRodsPerBundle"
				num3 = 20F
				RSWIN_DESC.Setup_NumRodsPerBundle = Conversions.ToInteger(RSWIN.GetRegProfileStringBySingle(RSWIN_DESC.SECT_RSWIN, text3, num3))
				Dim sDefaultName As String = "SteelSuckerRodLength"
				Dim value As Object = DBNull.Value
				flag2 = False
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(ini.GetDefault(sDefaultName, value, flag2))
				RSWIN_DESC.SETUP_SteelSuckerRodLength = Conversions.ToSingle(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(objectValue)), 25, RuntimeHelpers.GetObjectValue(objectValue)))
				text3 = "MinNumGuidesPerRod"
				num = 3
				RSWIN_DESC.SETUP_MinNumGuidesPerRod = Conversions.ToInteger(RSWIN.GetRegProfileStringByInt(RSWIN_DESC.SECT_RSWIN, text3, num))
				text3 = "MaxNumGuidesPerRod"
				num = 6
				RSWIN_DESC.SETUP_MaxNumGuidesPerRod = Conversions.ToInteger(RSWIN.GetRegProfileStringByInt(RSWIN_DESC.SECT_RSWIN, text3, num))
				RSWIN_DESC.bImplementingRodGuides = True
				RSWIN_DESC.SaveRodStringType = RSWIN_DESC.rst.RodStringType
				RSWIN_DESC.rst.RodStringType = 2S
				cImplementGuideChanges.iOrigNumRods = CInt(RSWIN_DESC.rst.NumRods)
				Try
					RSWIN_DESC.saved_rod_designs = New RSWIN_DESC.previous_rod_design_type(2) {}
					RSWIN_DESC.saved_num_rods = New Integer(2) {}
					RSWIN_DESC.saved_rst = New cRODSTAR(2) {}
					RSWIN_DESC.saved_Impred = New TEImpred(2) {}
				Catch ex2 As Exception
				End Try
				Try
					Dim num4 As Integer = 1
					Dim numRods As Integer = CInt(RSWIN_DESC.rst.NumRods)
					For i As Integer = num4 To numRods
						RSWIN_DESC.SaveSections(i) = RSWIN_DESC.rst.Sections(i)
					Next
				Catch ex3 As Exception
				End Try
				Application.DoEvents()
				Application.DoEvents()
				Application.DoEvents()
				RSWIN_DESC.saved_rod_designs(0).Initialize()
				Dim num5 As Integer = 1
				Dim numRods2 As Integer = CInt(RSWIN_DESC.rst.NumRods)
				For j As Integer = num5 To numRods2
					RSWIN_DESC.saved_rod_designs(0).Sections(j).Initialize()
				Next
				Try
					RSWIN_DESC.saved_rst(0) = New cRODSTAR()
					RSWIN_DESC.saved_rst(0) = RSWIN_DESC.rst
				Catch ex4 As Exception
				End Try
				Try
					RSWIN_DESC.saved_Impred(0) = New TEImpred()
					Dim teimpred As TEImpred = New TEImpred()
					teimpred = MImpred.ImpredObj
					RSWIN_DESC.saved_Impred(0) = New TEImpred()
					RSWIN_DESC.saved_Impred(0) = teimpred
				Catch ex5 As Exception
				End Try
				Try
					RSWIN_DESC.saved_num_rods(0) = CInt(RSWIN_DESC.rst.NumRods)
					Dim num6 As Integer = 1
					Dim numRods3 As Integer = CInt(RSWIN_DESC.rst.NumRods)
					For i As Integer = num6 To numRods3
						RSWIN_DESC.saved_rod_designs(0).Sections(i) = RSWIN_DESC.rst.Sections(i)
					Next
				Catch ex6 As Exception
				End Try
				RSWIN_DESC.bRestartImplementation = False
				cImplementGuideChanges.iOrigNumRods = CInt(RSWIN_DESC.rst.NumRods)
				cImplementGuideChanges.iOrigNumRods = cImplementGuideChanges.iOrigNumRods
				cImplementGuideChanges.sMaximum = ""
				cImplementGuideChanges.sMinimum = ""
				Try
					cImplementGuideChanges.ExecuteImplementation()
					If RSWIN_DESC.bRestartImplementation Then
						cImplementGuideChanges.UndoGuideImplementation()
						cImplementGuideChanges.ExecuteImplementation()
					End If
				Catch ex7 As Exception
				End Try
				Try
					Dim flag3 As Boolean = cImplementGuideChanges.CheckImplementationChanges(flag)
					If flag3 Then
						If Not flag Then
							RSWIN_DESC.SETUP_RECOMMEND_GUIDES = False
							Try
								text3 = "RecommendGuides"
								Dim text As String = Conversions.ToString(RSWIN_DESC.SETUP_RECOMMEND_GUIDES)
								RSWIN.WriteRegProfileString(RSWIN_DESC.SECT_RSWIN, text3, text, RSWIN_DESC.sINIFile)
								RSWIN_DESC.SETUP_RECOMMEND_GUIDES = Conversions.ToBoolean(text)
							Catch ex8 As Exception
							End Try
						End If
						Try
							Dim num7 As Integer = 1
							Dim numRods4 As Integer = CInt(RSWIN_DESC.rst.NumRods)
							For i As Integer = num7 To numRods4
								If RSWIN_DESC.rst.Sections(i).friction_coef = 0F Then
									RSWIN_DESC.rst.Sections(i).friction_coef = RODUTIL.GetFricCoeff(CInt(RSWIN_DESC.rst.Sections(i).Guide), True)
								End If
							Next
						Catch ex9 As Exception
						End Try
						Try
							RSWIN_DESC.rst.RodStringType = 2S
							RSWIN_DESC.bSuppressWarningMessages_Override = True
							DESIGN.Design()
							RSWIN_DESC.bSuppressWarningMessages_Override = False
						Catch ex10 As Exception
						End Try
					End If
				Catch ex11 As Exception
				End Try
			Catch ex12 As Exception
			End Try
		End Sub

		Public Sub CleanupImplementationVars()
			' The following expression was wrapped in a checked-statement
			Try
				Dim num As Integer = 1
				Do
					Application.DoEvents()
					Application.DoEvents()
					Application.DoEvents()
					Try
						RSWIN_DESC.saved_rst(num) = Nothing
					Catch ex As Exception
					End Try
					Try
						RSWIN_DESC.saved_Impred(num) = Nothing
					Catch ex2 As Exception
					End Try
					Try
						RSWIN_DESC.saved_rod_designs(num) = Nothing
					Catch ex3 As Exception
					End Try
					Try
						RSWIN_DESC.saved_num_rods(num) = 0
					Catch ex4 As Exception
					End Try
					num += 1
				Loop While num <= 2
			Catch ex5 As Exception
			End Try
		End Sub

		Public Function VerifySideLoads(ByRef bHasDeviation As Boolean) As Boolean
			Dim impredObj As TEImpred = MImpred.ImpredObj
			Dim result As Boolean = True
			bHasDeviation = True
			Try
				bHasDeviation = MImpred.CheckSurveyForDeviation()
			Catch ex As Exception
			End Try
			Try
				Dim array As Single() = New Single(impredObj.num_rod_elements + 1 - 1) {}
				array(0) = 0F
				If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
				End If
				Dim num As Single = 0F
				If impredObj.num_rod_elements > 0 Then
					Dim num2 As Long = 0L
					Dim num3 As Long = CLng((impredObj.num_rod_elements - 1))
					For num4 As Long = num2 To num3
						Dim num5 As Single = CSng(impredObj.get_r_e(CInt((num4 + 1L))).m_d)
						If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
							CtrlUI.ConvertValue(num5, "f", False)
						End If
						Dim num6 As Single = num5 - num
						array(CInt(num4)) = num6
						num = num5
					Next
					Dim num7 As Long = 0L
					Dim num8 As Long = CLng((impredObj.num_rod_elements - 1))
					For num4 As Long = num7 To num8
						' The following expression was wrapped in a unchecked-expression
						' The following expression was wrapped in a checked-expression
						Dim num5 As Single = CSng(-CSng(impredObj.get_r_e(CInt((num4 + 1L))).m_d))
						If bHasDeviation Then
							Dim max_sf_total As Double = impredObj.get_r_e(CInt((num4 + 1L))).max_sf_total
							If max_sf_total < 0.0 Then
								result = False
							End If
						End If
					Next
				Else
					result = False
				End If
			Catch ex2 As Exception
				result = False
			End Try
			Return result
		End Function

		Public Function ValidateAllData() As Boolean
			Dim flag As Boolean = True
			Dim num As Integer = 50
			Dim result As Boolean
			Try
				Dim cRODSTAR As cRODSTAR = RSWIN_DESC.rst
				Dim text As String
				If Operators.CompareString(cRODSTAR.WellName, "", False) = 0 Then
					flag = False
				ElseIf cRODSTAR.PumpDepth = 0F Then
					flag = False
				Else
					Dim cRODSTAR2 As cRODSTAR = cRODSTAR
					Dim obj As Object = cRODSTAR2.PumpDepth
					Dim checkLowerMsg As Object = Util.GetCheckLowerMsg(obj, 100F, -1, 41, -1, 0, text)
					cRODSTAR2.PumpDepth = Conversions.ToSingle(obj)
					If Conversions.ToBoolean(checkLowerMsg) Then
						flag = False
					Else
						cRODSTAR2 = cRODSTAR
						obj = cRODSTAR2.PumpDepth
						Dim checkUpperMsg As Object = Util.GetCheckUpperMsg(obj, 20000F, -1, 41, -1, 0, text)
						cRODSTAR2.PumpDepth = Conversions.ToSingle(obj)
						If Conversions.ToBoolean(checkUpperMsg) Then
							flag = False
						ElseIf cRODSTAR.Runtime = 0F Then
							flag = False
						ElseIf cRODSTAR.OilAPI = 0F Then
							flag = False
						Else
							cRODSTAR2 = cRODSTAR
							obj = cRODSTAR2.StuffingBoxFriction
							Dim checkUpperMsg2 As Object = Util.GetCheckUpperMsg(obj, 2000F, -1, 75, -1, 0, text)
							cRODSTAR2.StuffingBoxFriction = Conversions.ToSingle(obj)
							If Conversions.ToBoolean(checkUpperMsg2) Then
								flag = False
							Else
								cRODSTAR2 = cRODSTAR
								obj = cRODSTAR2.OilAPI
								Dim checkLowerMsg2 As Object = Util.GetCheckLowerMsg(obj, 5F, -1, 35, -1, 0, text)
								cRODSTAR2.OilAPI = Conversions.ToSingle(obj)
								If Conversions.ToBoolean(checkLowerMsg2) Then
									flag = False
								Else
									cRODSTAR2 = cRODSTAR
									obj = cRODSTAR2.OilAPI
									Dim checkUpperMsg3 As Object = Util.GetCheckUpperMsg(obj, 70F, -1, 35, -1, 0, text)
									cRODSTAR2.OilAPI = Conversions.ToSingle(obj)
									If Conversions.ToBoolean(checkUpperMsg3) Then
										flag = False
									ElseIf cRODSTAR.WaterSPGR = 0F Then
										flag = False
									ElseIf cRODSTAR.WaterSPGR < 1F Or CDbl(cRODSTAR.WaterSPGR) > 1.5 Then
										flag = False
									ElseIf cRODSTAR.FluidSPGR = 0F And Not cRODSTAR.gbCalcFluidSPGR Then
										flag = False
									Else
										Dim obj2 As Object = cRODSTAR.PumpCondition = 1S Or cRODSTAR.PumpCondition = If((-If((RSWIN_DESC.rst.gbCalcPumpCondition > False), 1S, 0S)), 1S, 0S)
										cRODSTAR2 = RSWIN_DESC.rst
										obj = cRODSTAR2.PumpEfficiency
										Dim lowerBound As Single = CSng(num)
										Dim inclusive As Integer = -1
										Dim errnum As Integer = 43
										Dim useMetric As Integer = 0
										Dim canadianIsMetric As Integer = 0
										Dim bQuiet As Boolean = True
										Dim text2 As String = ""
										Dim obj3 As Object = Util.CheckLower(obj, lowerBound, inclusive, errnum, useMetric, canadianIsMetric, bQuiet, text2)
										cRODSTAR2.PumpEfficiency = Conversions.ToSingle(obj)
										Dim obj4 As Object = Operators.NotObject(obj3)
										Dim cRODSTAR3 As cRODSTAR = RSWIN_DESC.rst
										Dim obj5 As Object = cRODSTAR3.PumpEfficiency
										Dim upperBound As Single = 100F
										Dim inclusive2 As Integer = -1
										Dim errnum2 As Integer = 43
										Dim useMetric2 As Integer = 0
										Dim canadianIsMetric2 As Integer = 0
										Dim bQuiet2 As Boolean = True
										Dim text3 As String = ""
										Dim obj6 As Object = Util.CheckUpper(obj5, upperBound, inclusive2, errnum2, useMetric2, canadianIsMetric2, bQuiet2, text3)
										cRODSTAR3.PumpEfficiency = Conversions.ToSingle(obj5)
										If Conversions.ToBoolean(Operators.AndObject(obj2, Operators.OrObject(obj4, Operators.NotObject(obj6)))) Then
											flag = False
										End If
									End If
								End If
							End If
						End If
					End If
				End If
				If flag Then
					Dim obj7 As Object = cRODSTAR.PumpCondition = 2S Or cRODSTAR.PumpCondition = 3S
					Dim cRODSTAR3 As cRODSTAR = RSWIN_DESC.rst
					Dim obj5 As Object = cRODSTAR3.PumpFillage
					Dim lowerBound2 As Single = 10F
					Dim inclusive3 As Integer = -1
					Dim errnum3 As Integer = 44
					Dim useMetric3 As Integer = 0
					Dim canadianIsMetric3 As Integer = 0
					Dim bQuiet3 As Boolean = True
					Dim text3 As String = ""
					Dim obj8 As Object = Util.CheckLower(obj5, lowerBound2, inclusive3, errnum3, useMetric3, canadianIsMetric3, bQuiet3, text3)
					cRODSTAR3.PumpFillage = Conversions.ToSingle(obj5)
					Dim obj9 As Object = Operators.NotObject(obj8)
					Dim cRODSTAR2 As cRODSTAR = RSWIN_DESC.rst
					Dim obj As Object = cRODSTAR2.PumpFillage
					Dim upperBound2 As Single = 95F
					Dim inclusive4 As Integer = -1
					Dim errnum4 As Integer = 44
					Dim useMetric4 As Integer = 0
					Dim canadianIsMetric4 As Integer = 0
					Dim bQuiet4 As Boolean = True
					Dim text2 As String = ""
					Dim obj10 As Object = Util.CheckUpper(obj, upperBound2, inclusive4, errnum4, useMetric4, canadianIsMetric4, bQuiet4, text2)
					cRODSTAR2.PumpFillage = Conversions.ToSingle(obj)
					If Conversions.ToBoolean(Operators.AndObject(obj7, Operators.OrObject(obj9, Operators.NotObject(obj10)))) Then
						flag = False
					ElseIf cRODSTAR.PR_Diameter < 1F Or cRODSTAR.PR_Diameter > 2F Then
						flag = False
					Else
						cRODSTAR3 = cRODSTAR
						obj5 = cRODSTAR3.CasingPressure
						Dim checkLowerMsg3 As Object = Util.GetCheckLowerMsg(obj5, -50F, -1, 91, -1, 0, text)
						cRODSTAR3.CasingPressure = Conversions.ToSingle(obj5)
						If Conversions.ToBoolean(checkLowerMsg3) Then
							flag = False
						Else
							cRODSTAR3 = cRODSTAR
							obj5 = cRODSTAR3.CasingPressure
							Dim checkUpperMsg4 As Object = Util.GetCheckUpperMsg(obj5, 1000F, -1, 89, -1, 0, text)
							cRODSTAR3.CasingPressure = Conversions.ToSingle(obj5)
							If Conversions.ToBoolean(checkUpperMsg4) Then
								flag = False
							Else
								cRODSTAR3 = cRODSTAR
								obj5 = cRODSTAR3.TubingPressure
								Dim checkLowerMsg4 As Object = Util.GetCheckLowerMsg(obj5, 0F, -1, 153, -1, 0, text)
								cRODSTAR3.TubingPressure = Conversions.ToSingle(obj5)
								If Conversions.ToBoolean(checkLowerMsg4) Then
									flag = False
								Else
									cRODSTAR3 = cRODSTAR
									obj5 = cRODSTAR3.TubingPressure
									Dim checkUpperMsg5 As Object = Util.GetCheckUpperMsg(obj5, 1000F, -1, 151, -1, 0, text)
									cRODSTAR3.TubingPressure = Conversions.ToSingle(obj5)
									If Conversions.ToBoolean(checkUpperMsg5) Then
										flag = False
									End If
								End If
							End If
						End If
					End If
				End If
				If flag Then
					Dim obj11 As Object = cRODSTAR.giFluidLevelSource = 1S
					Dim cRODSTAR3 As cRODSTAR = cRODSTAR
					Dim obj5 As Object = cRODSTAR3.FluidLevel
					Dim obj12 As Object = Util.CheckLower(obj5, 0F, -1, 105, 0, 0, True, text)
					cRODSTAR3.FluidLevel = Conversions.ToSingle(obj5)
					If Conversions.ToBoolean(Operators.AndObject(obj11, Operators.NotObject(obj12))) Then
						flag = False
					Else
						Dim obj13 As Object = cRODSTAR.giFluidLevelSource = 1S
						cRODSTAR3 = cRODSTAR
						obj5 = cRODSTAR3.FluidLevel
						Dim obj14 As Object = Util.CheckUpper(obj5, RSWIN_DESC.rst.PumpDepth, -1, 103, 0, 0, True, text)
						cRODSTAR3.FluidLevel = Conversions.ToSingle(obj5)
						If Conversions.ToBoolean(Operators.AndObject(obj13, Operators.NotObject(obj14))) Then
							flag = False
						ElseIf cRODSTAR.gbUseIPR Then
							If cRODSTAR.FetkovichN = 0F And cRODSTAR.giIPRMethod = 0S Then
								flag = False
							ElseIf cRODSTAR.giIPRMethod = -1S Then
								flag = False
							ElseIf cRODSTAR.MidPerfDepth = 0F Then
								flag = False
							ElseIf cRODSTAR.StaticBHPressure = 0F Then
								flag = False
							ElseIf cRODSTAR.BubblePoint = 0F And Not cRODSTAR.gbProducingBelowBPP Then
								flag = False
							ElseIf cRODSTAR.gnTestPoints = 0S Then
								flag = False
							Else
								Dim obj15 As Object = cRODSTAR.giIPRMethod = 0S
								cRODSTAR3 = RSWIN_DESC.rst
								obj5 = cRODSTAR3.FetkovichN
								Dim lowerBound3 As Single = 0.5F
								Dim inclusive5 As Integer = -1
								Dim errnum5 As Integer = 22
								Dim useMetric5 As Integer = 0
								Dim canadianIsMetric5 As Integer = 0
								Dim bQuiet5 As Boolean = True
								Dim text3 As String = ""
								Dim obj16 As Object = Util.CheckLower(obj5, lowerBound3, inclusive5, errnum5, useMetric5, canadianIsMetric5, bQuiet5, text3)
								cRODSTAR3.FetkovichN = Conversions.ToSingle(obj5)
								If Conversions.ToBoolean(Operators.AndObject(obj15, Operators.NotObject(obj16))) Then
									flag = False
								Else
									Dim obj17 As Object = cRODSTAR.giIPRMethod = 0S
									cRODSTAR3 = RSWIN_DESC.rst
									obj5 = cRODSTAR3.FetkovichN
									Dim upperBound3 As Single = 1F
									Dim inclusive6 As Integer = -1
									Dim errnum6 As Integer = 22
									Dim useMetric6 As Integer = 0
									Dim canadianIsMetric6 As Integer = 0
									Dim bQuiet6 As Boolean = True
									text3 = ""
									Dim obj18 As Object = Util.CheckUpper(obj5, upperBound3, inclusive6, errnum6, useMetric6, canadianIsMetric6, bQuiet6, text3)
									cRODSTAR3.FetkovichN = Conversions.ToSingle(obj5)
									If Conversions.ToBoolean(Operators.AndObject(obj17, Operators.NotObject(obj18))) Then
										flag = False
									End If
								End If
							End If
						End If
					End If
					If cRODSTAR.giFluidLevelSource <> 0S Then
						If cRODSTAR.giFluidLevelSource = 1S Then
							If cRODSTAR.FluidLevel < 0F Then
								flag = False
							ElseIf(If((-If(((cRODSTAR.TargetBFPD = 0F) > False), 1S, 0S)), 1S, 0S) And Not cRODSTAR.SPMEntered And If((-If((Not cRODSTAR.gbCalcTargetBFPD > False), 1S, 0S)), 1S, 0S)) <> 0S Then
								flag = False
							ElseIf(Not cRODSTAR.SPMEntered And If((-If((Not cRODSTAR.gbCalcTargetBFPD > False), 1S, 0S)), 1S, 0S) And If((-If((RSWIN_DESC.rst.Runtime < 24F > False), 1S, 0S)), 1S, 0S)) <> 0S Then
								flag = False
							ElseIf(If((-If(((cRODSTAR.SPM = 0F) > False), 1S, 0S)), 1S, 0S) And cRODSTAR.SPMEntered And If((-If((Not cRODSTAR.gbCalcTargetBFPD > False), 1S, 0S)), 1S, 0S)) <> 0S Then
								flag = False
							End If
						ElseIf cRODSTAR.giFluidLevelSource = 2S And cRODSTAR.PumpIntakePressure = 0F Then
							flag = False
						End If
					ElseIf(If((-If(((cRODSTAR.TargetBFPD = 0F) > False), 1S, 0S)), 1S, 0S) And Not cRODSTAR.SPMEntered And If((-If((Not cRODSTAR.gbCalcTargetBFPD > False), 1S, 0S)), 1S, 0S)) <> 0S Then
						flag = False
					ElseIf(If((-If(((cRODSTAR.SPM = 0F) > False), 1S, 0S)), 1S, 0S) And cRODSTAR.SPMEntered And If((-If((Not cRODSTAR.gbCalcTargetBFPD > False), 1S, 0S)), 1S, 0S)) <> 0S Then
						flag = False
					End If
				End If
				If flag Then
					If cRODSTAR.TubingOD = 0F Then
						flag = False
					ElseIf cRODSTAR.TubingID = 0F Then
						flag = False
					ElseIf cRODSTAR.PlungerSize = 0F Then
						flag = False
					ElseIf(If((-If(((cRODSTAR.TubingAnchorDepth = 0F) > False), 1S, 0S)), 1S, 0S) And cRODSTAR.TubingAnchored) <> 0S Then
						flag = False
					ElseIf(cRODSTAR.IncludeFluidInertia And If((-If(((cRODSTAR.CompressibilityIndex < 1F Or cRODSTAR.CompressibilityIndex > 7F) > False), 1S, 0S)), 1S, 0S)) <> 0S Then
						flag = False
					End If
				End If
				If flag Then
					If cRODSTAR.ServiceFactor = 0F Then
						flag = False
					Else
						Dim cRODSTAR3 As cRODSTAR = RSWIN_DESC.rst
						Dim obj5 As Object = cRODSTAR3.ServiceFactor
						Dim lowerBound4 As Single = 0.5F
						Dim inclusive7 As Integer = -1
						Dim errnum7 As Integer = 61
						Dim useMetric7 As Integer = -1
						Dim canadianIsMetric7 As Integer = -1
						Dim bQuiet7 As Boolean = True
						Dim text3 As String = ""
						Dim obj19 As Object = Util.CheckLower(obj5, lowerBound4, inclusive7, errnum7, useMetric7, canadianIsMetric7, bQuiet7, text3)
						cRODSTAR3.ServiceFactor = Conversions.ToSingle(obj5)
						If Conversions.ToBoolean(Operators.NotObject(obj19)) Then
							flag = False
						Else
							cRODSTAR3 = RSWIN_DESC.rst
							obj5 = cRODSTAR3.ServiceFactor
							Dim upperBound4 As Single = 1F
							Dim inclusive8 As Integer = -1
							Dim errnum8 As Integer = 61
							Dim useMetric8 As Integer = -1
							Dim canadianIsMetric8 As Integer = -1
							Dim bQuiet8 As Boolean = True
							text3 = ""
							Dim obj20 As Object = Util.CheckUpper(obj5, upperBound4, inclusive8, errnum8, useMetric8, canadianIsMetric8, bQuiet8, text3)
							cRODSTAR3.ServiceFactor = Conversions.ToSingle(obj5)
							If Conversions.ToBoolean(Operators.NotObject(obj20)) Then
								flag = False
							End If
						End If
					End If
					If RSWIN_DESC.rst.RodStringType = 2S Then
						If cRODSTAR.NumRods = 0S Then
							flag = False
						End If
						If flag Then
							Dim num2 As Integer = 1
							Dim numRods As Integer = CInt(cRODSTAR.NumRods)
							For i As Integer = num2 To numRods
								If Information.IsDBNull(cRODSTAR.Sections(i).Grade) Or cRODSTAR.Sections(i).Grade <= 0S Then
									flag = False
									Exit For
								End If
								If Information.IsDBNull(cRODSTAR.Sections(i).Diameter) Or cRODSTAR.Sections(i).Diameter <= 0F Then
									flag = False
									Exit For
								End If
								If Information.IsDBNull(cRODSTAR.Sections(i).length) Or cRODSTAR.Sections(i).length <= 0F Then
									flag = False
									Exit For
								End If
							Next
						End If
					ElseIf cRODSTAR.RodStringType = 3S Then
						If cRODSTAR.giRodDesignStyle = 1S Then
							If cRODSTAR.RSFGIncludeSteel <> 0S Then
								If cRODSTAR.RSGrade <= 0S Then
									flag = False
								ElseIf cRODSTAR.RSMaxSize <= 0F Then
									flag = False
								ElseIf cRODSTAR.RSMinSize <= 0F Then
									flag = False
								End If
							End If
							If cRODSTAR.RSIncludeSB <> 0S Then
								If cRODSTAR.RSSBGrade = 0S And cRODSTAR.SinkerBar.Grade = 0S Then
									flag = False
								ElseIf cRODSTAR.RSSBLength > 0F And cRODSTAR.SinkerBar.length = 0F And (Not RSWIN_DESC.bExpert Or (RSWIN_DESC.bExpert And Not RSWIN_DESC.bDesignSinkerbar)) Then
									flag = False
								End If
							End If
						ElseIf cRODSTAR.giRodDesignStyle = 0S Then
							If cRODSTAR.RSGrade <= 0S Then
								flag = False
							ElseIf cRODSTAR.RSMaxSize <= 0F Then
								flag = False
							ElseIf cRODSTAR.RSMinSize <= 0F Then
								flag = False
							End If
							If cRODSTAR.RSIncludeSB <> 0S Then
								If cRODSTAR.RSSBGrade = 0S And cRODSTAR.SinkerBar.Grade = 0S Then
									flag = False
								ElseIf cRODSTAR.RSSBLength = 0F And cRODSTAR.SinkerBar.length = 0F And (Not RSWIN_DESC.bExpert Or (RSWIN_DESC.bExpert And Not RSWIN_DESC.bDesignSinkerbar)) Then
									flag = False
								End If
							End If
						End If
					End If
				End If
				If flag Then
					If Not cRODSTAR.IDEntered <> 0S Then
						flag = False
					ElseIf cRODSTAR.UnitID Is Nothing Then
						flag = False
					ElseIf Operators.CompareString(cRODSTAR.UnitID.Trim(), "", False) = 0 Then
						flag = False
					End If
				End If
				If flag Then
					Try
						If RSWIN_DESC.rst.PU.UnitType <> 8S And RSWIN_DESC.rst.PU.UnitType <> 10S And Not cRODSTAR.UnknownM And RSWIN_DESC.rst.get_M(2) = 0F And cRODSTAR.CBDataType <> 2S Then
							flag = False
						ElseIf cRODSTAR.PU.CrankHole = 0S And RSWIN_DESC.rst.PU.UnitType <> 10S Then
							flag = False
						ElseIf cRODSTAR.PU.CrankRotation <> 1S And cRODSTAR.PU.CrankRotation <> -1S And RSWIN_DESC.rst.PU.UnitType <> 10S Then
							flag = False
						End If
					Catch ex As Exception
						flag = False
					End Try
					If cRODSTAR.ElectricityCost = 0F Then
						flag = False
					End If
				End If
				cRODSTAR = Nothing
				result = flag
			Catch ex2 As Exception
				result = False
			End Try
			Return result
		End Function

		Public Function Get_Last_MD_from_Survey() As Single
			Dim result As Single
			Try
				Dim dataView As DataView = New DataView(RSWIN_DESC.mdsDeviationProfile.Tables(0))
				Dim num As Single = 0F
				Dim count As Integer = RSWIN_DESC.mdsDeviationProfile.Tables(0).Rows.Count
				If count > 2 Then
					Try
						For Each obj As Object In dataView
							Dim dataRowView As DataRowView = CType(obj, DataRowView)
							Dim row As DataRow = dataRowView.Row
							Dim num2 As Single = CSng(Convert.ToDouble(RuntimeHelpers.GetObjectValue(row(1))))
							If num2 > num Then
								num = num2
							End If
						Next
					Finally
						Dim enumerator As IEnumerator
						If TypeOf enumerator Is IDisposable Then
							TryCast(enumerator, IDisposable).Dispose()
						End If
					End Try
				End If
				result = num
			Catch ex As Exception
				result = 0F
			End Try
			Return result
		End Function

		Private Shared m_vb6FormDefInstance As RODSTAR

		Private Shared m_InitializingDefInstance As Boolean

		Private sbox As Object()

		Private key As Object()

		<AccessedThroughProperty("dlgSelectDir")>
		Private _dlgSelectDir As dlgSelectDir

		Private sAlreadyFileList As String()

		Private MyParentFrm As RODSTAR

		Private bCancel As Boolean

		<AccessedThroughProperty("frmSystemOfUnits")>
		Private _frmSystemOfUnits As SystemOfUnits

		Private NoofTrial As Short

		Private bSentinelReplied As Boolean

		Private m_bClosing As Boolean

		Private tmpUnitTypeInfoList As RSWIN_DESC.UnitTypeInfo()

		Private nUnitTypes As Integer

		Public bAllowResize As Boolean

		Public mTLM32 As TLM32

		<AccessedThroughProperty("frmHowToStart")>
		Private _frmHowToStart As frmHowToStart

		<AccessedThroughProperty("FAboutSplash")>
		Private _FAboutSplash As FAboutSplash

		<AccessedThroughProperty("frmDemoMode")>
		Private _frmDemoMode As frmDemoMode

		<AccessedThroughProperty("frmLoadGuruFilenames")>
		Private _frmLoadGuruFilenames As frmLoadGuruFNames

		Private iWindowsStartIndex As Integer

		Private sDetent As String

		Private sNonDetent As String

		Private sSpeedVar As String

		Private sSpeedVariationNotIncluded As String

		Private sSpeedVariationIncluded As String

		Private sDYWExit As String

		Private sDYWPrevCustomRG As String

		Private sDYWPrevCustomPU As String

		Private sDYWRerun As String

		Private sInitQuestion As String

		Private sDYWChangePlungerSize As String

		Private sDYWSaveToDisk As String

		Private sMNEPlungerSize As String

		Private sMNEPlungerSize1 As String

		Private sMNEPlungerSize2 As String

		Private sToUsePlungerSize As String

		Private sDYWAutoBatchSetup As String

		Private sDYWBatchPrint As String

		Private sBatchPrintNote As String

		Private sCalcForFileInProgress As String

		Private sNeedMoreSurveyPoints As String

		Private sSelectExportFolder As String

		Public sCalcInProgress As String

		Private sBringOverCustomRodInfo As Object

		Private sBringOverCustomPumpingUnit As Object

		Private sExportCBMoment As String

		Private sExportRequiredUnbalance As String

		Private SAVE_SETUP_Language As String

		<AccessedThroughProperty("frmDisplayAllDatabaseTemplates")>
		Private _frmDisplayAllDatabaseTemplates As db_guru_admin_form

		Private rswin_D_icon As String

		Private rswin_V_icon As String

		Private xrod_v_icon As String

		<AccessedThroughProperty("Clock")>
		Private _Clock As Clock

		Private m_VisualInput As Boolean

		Private windowCount As Integer

		<AccessedThroughProperty("mnuWindowInput")>
		Private _mnuWindowInput As MenuItemArray

		<AccessedThroughProperty("mnuFileNew")>
		Private _mnuFileNew As MenuItem

		<AccessedThroughProperty("mnuFileOpen_")>
		Private _mnuFileOpen_ As MenuItem

		<AccessedThroughProperty("mnuFileSave")>
		Private _mnuFileSave As MenuItem

		<AccessedThroughProperty("mnuFileSaveAs_")>
		Private _mnuFileSaveAs_ As MenuItem

		<AccessedThroughProperty("mnuFileSaveAsRSDX")>
		Private _mnuFileSaveAsRSDX As MenuItem

		<AccessedThroughProperty("mnuFileSaveAsRSVX")>
		Private _mnuFileSaveAsRSVX As MenuItem

		<AccessedThroughProperty("mnuFileSaveAsXRVX")>
		Private _mnuFileSaveAsXRVX As MenuItem

		<AccessedThroughProperty("mnuFileSaveAsSeparator1")>
		Private _mnuFileSaveAsSeparator1 As MenuItem

		<AccessedThroughProperty("mnuFileSaveAsPDF_")>
		Private _mnuFileSaveAsPDF_ As MenuItem

		<AccessedThroughProperty("mnuFileSeparator0")>
		Private _mnuFileSeparator0 As MenuItem

		<AccessedThroughProperty("mnuFileRecentFiles")>
		Private _mnuFileRecentFiles As MenuItem

		<AccessedThroughProperty("mnuFileSeparator1")>
		Private _mnuFileSeparator1 As MenuItem

		<AccessedThroughProperty("mnuFileImport")>
		Private _mnuFileImport As MenuItem

		<AccessedThroughProperty("mnuFileSeparator2")>
		Private _mnuFileSeparator2 As MenuItem

		<AccessedThroughProperty("mnuFilePrint_")>
		Private _mnuFilePrint_ As MenuItem

		<AccessedThroughProperty("mnuFilePrintSetup_")>
		Private _mnuFilePrintSetup_ As MenuItem

		<AccessedThroughProperty("mnuFileSeparator3")>
		Private _mnuFileSeparator3 As MenuItem

		<AccessedThroughProperty("mnuFileExit")>
		Private _mnuFileExit As MenuItem

		<AccessedThroughProperty("mnuFile")>
		Private _mnuFile As MenuItem

		<AccessedThroughProperty("mnuEditUndo")>
		Private _mnuEditUndo As MenuItem

		<AccessedThroughProperty("mnuEditSeparator")>
		Private _mnuEditSeparator As MenuItem

		<AccessedThroughProperty("mnuEditCut")>
		Private _mnuEditCut As MenuItem

		<AccessedThroughProperty("mnuEditCopy")>
		Private _mnuEditCopy As MenuItem

		<AccessedThroughProperty("mnuEditPaste")>
		Private _mnuEditPaste As MenuItem

		<AccessedThroughProperty("mnuEditDelete")>
		Private _mnuEditDelete As MenuItem

		<AccessedThroughProperty("mnuEdit")>
		Private _mnuEdit As MenuItem

		<AccessedThroughProperty("mnuRun")>
		Private _mnuRun As MenuItem

		<AccessedThroughProperty("mnuToolsExportDYN")>
		Private _mnuToolsExportDYN As MenuItem

		<AccessedThroughProperty("mnuToolsExportMCM")>
		Private _mnuToolsExportMCM As MenuItem

		<AccessedThroughProperty("mnuToolsSeparator0")>
		Private _mnuToolsSeparator0 As MenuItem

		<AccessedThroughProperty("mnuToolsSetup_")>
		Private _mnuToolsSetup_ As MenuItem

		<AccessedThroughProperty("mnuToolsSeparator1")>
		Private _mnuToolsSeparator1 As MenuItem

		<AccessedThroughProperty("mnuToolsUploadRSVXFile")>
		Private _mnuToolsUploadRSVXFile As MenuItem

		<AccessedThroughProperty("mnuToolsUploadRSVXFiles")>
		Private _mnuToolsUploadRSVXFiles As MenuItem

		<AccessedThroughProperty("mnuToolsBatchExportFromOneFolder")>
		Private _mnuToolsBatchExportFromOneFolder As MenuItem

		<AccessedThroughProperty("mnuToolsDownloadToRSVX")>
		Private _mnuToolsDownloadToRSVX As MenuItem

		<AccessedThroughProperty("mnuToolsSeparator1b")>
		Private _mnuToolsSeparator1b As MenuItem

		<AccessedThroughProperty("mnuToolsDeleteTemplate")>
		Private _mnuToolsDeleteTemplate As MenuItem

		<AccessedThroughProperty("mnuToolsSeparator2")>
		Private _mnuToolsSeparator2 As MenuItem

		<AccessedThroughProperty("mnuToolsBatchExportALL")>
		Private _mnuToolsBatchExportALL As MenuItem

		<AccessedThroughProperty("mnuToolsSeparator3")>
		Private _mnuToolsSeparator3 As MenuItem

		<AccessedThroughProperty("mnuToolsEncryptTemplateDatabase")>
		Private _mnuToolsEncryptTemplateDatabase As MenuItem

		<AccessedThroughProperty("mnuTools")>
		Private _mnuTools As MenuItem

		<AccessedThroughProperty("_mnuWindowInput_1")>
		Private __mnuWindowInput_1 As MenuItem

		<AccessedThroughProperty("_mnuWindowInput_2")>
		Private __mnuWindowInput_2 As MenuItem

		<AccessedThroughProperty("_mnuWindowInput_3")>
		Private __mnuWindowInput_3 As MenuItem

		<AccessedThroughProperty("_mnuWindowInput_4")>
		Private __mnuWindowInput_4 As MenuItem

		<AccessedThroughProperty("_mnuWindowInput_5")>
		Private __mnuWindowInput_5 As MenuItem

		<AccessedThroughProperty("_mnuWindowInput_6")>
		Private __mnuWindowInput_6 As MenuItem

		<AccessedThroughProperty("_mnuWindowInput_7")>
		Private __mnuWindowInput_7 As MenuItem

		<AccessedThroughProperty("mnuWindowSeparator1")>
		Private _mnuWindowSeparator1 As MenuItem

		<AccessedThroughProperty("mnuWindowPreviousScreen")>
		Private _mnuWindowPreviousScreen As MenuItem

		<AccessedThroughProperty("mnuWindowNextScreen")>
		Private _mnuWindowNextScreen As MenuItem

		<AccessedThroughProperty("mnuWindowViewReport")>
		Private _mnuWindowViewReport As MenuItem

		<AccessedThroughProperty("mnuWindowVisInput")>
		Private _mnuWindowVisInput As MenuItem

		<AccessedThroughProperty("mnuWindow")>
		Private _mnuWindow As MenuItem

		<AccessedThroughProperty("mnuHelpContents")>
		Private _mnuHelpContents As MenuItem

		<AccessedThroughProperty("mnuHelpSearch_")>
		Private _mnuHelpSearch_ As MenuItem

		<AccessedThroughProperty("mnuHelpIndex")>
		Private _mnuHelpIndex As MenuItem

		<AccessedThroughProperty("mnuHelpSeparator")>
		Private _mnuHelpSeparator As MenuItem

		<AccessedThroughProperty("mnuHelpAbout_")>
		Private _mnuHelpAbout_ As MenuItem

		<AccessedThroughProperty("mnuHelp")>
		Private _mnuHelp As MenuItem

		Private bFormLoaded As Boolean

		Private Const POPUP_NONE As Integer = -1

		Private Const POPUP_WELLINFO As Integer = 0

		Private Const POPUP_PRODINFO As Integer = 1

		Private Const POPUP_PTINFO As Integer = 2

		Private Const POPUP_RSINPUT As Integer = 3

		Private Const POPUP_PUDATA As Integer = 4

		Private Const POPUP_MOTORDATA As Integer = 5

		Private Const POPUP_TUBING As Integer = 6

		Private sARSOVERWRITE As String

		Private Const iGuruTargetBfpdTolerance As Integer = 5

		Private m_bRST As Boolean

		Private CurrentContextMenu As String

		Private bDisplayBatchFileOutput As Boolean

		Private Const gWarningInfo As String = " Warning: This computer program is protected by copyright law and international treaties. Unauthorized reproduction of this program, or any portion of it, may result in severe civil and criminal penalties, and will be prosecuted to the maximum extent possible under law."

		<AccessedThroughProperty("tmrClock")>
		Private _tmrClock As System.Windows.Forms.Timer

		<AccessedThroughProperty("pnlBatchLog")>
		Private _pnlBatchLog As Panel

		<AccessedThroughProperty("Viewer1")>
		Private _Viewer1 As Viewer

		<AccessedThroughProperty("btnClose")>
		Private _btnClose As Button

		Private myKeyValueHT As Hashtable

		Private m_NowTime As DateTime

		Private m_bEnd As Boolean

		<AccessedThroughProperty("tbrRun")>
		Private _tbrRun As ToolBarButton

		<AccessedThroughProperty("tbrReport")>
		Private _tbrReport As ToolBarButton

		<AccessedThroughProperty("tbrPrint")>
		Private _tbrPrint As ToolBarButton

		<AccessedThroughProperty("tbrCBM")>
		Private _tbrCBM As ToolBarButton

		<AccessedThroughProperty("tbrNew")>
		Private _tbrNew As ToolBarButton

		<AccessedThroughProperty("tbrOpen")>
		Private _tbrOpen As ToolBarButton

		<AccessedThroughProperty("tbrSave")>
		Private _tbrSave As ToolBarButton

		<AccessedThroughProperty("tbrOptions")>
		Private _tbrOptions As ToolBarButton

		<AccessedThroughProperty("tbrWellInfo")>
		Private _tbrWellInfo As ToolBarButton

		<AccessedThroughProperty("tbrProdInfo")>
		Private _tbrProdInfo As ToolBarButton

		<AccessedThroughProperty("tbrPumpTubingInfo")>
		Private _tbrPumpTubingInfo As ToolBarButton

		<AccessedThroughProperty("tbrRSInput")>
		Private _tbrRSInput As ToolBarButton

		<AccessedThroughProperty("tbrPUData")>
		Private _tbrPUData As ToolBarButton

		<AccessedThroughProperty("tbrMotorData")>
		Private _tbrMotorData As ToolBarButton

		<AccessedThroughProperty("tbrNext")>
		Private _tbrNext As ToolBarButton

		<AccessedThroughProperty("btnVisualInput")>
		Private _btnVisualInput As Button

		<AccessedThroughProperty("tbrHelp")>
		Private _tbrHelp As ToolBarButton

		<AccessedThroughProperty("pnlToolbar")>
		Private _pnlToolbar As Panel

		<AccessedThroughProperty("OpenFileDialog1")>
		Private _OpenFileDialog1 As OpenFileDialog

		<AccessedThroughProperty("SaveFileDialog1")>
		Private _SaveFileDialog1 As SaveFileDialog

		<AccessedThroughProperty("MainMenu1")>
		Private _MainMenu1 As MainMenu

		<AccessedThroughProperty("ContextMenu1")>
		Private _ContextMenu1 As ContextMenu

		<AccessedThroughProperty("tbrToolbar")>
		Private _tbrToolbar As ToolBar

		<AccessedThroughProperty("PrintDialog1")>
		Private _PrintDialog1 As PrintDialog

		<AccessedThroughProperty("tbrSep3")>
		Private _tbrSep3 As ToolBarButton

		<AccessedThroughProperty("tbrSep4")>
		Private _tbrSep4 As ToolBarButton

		<AccessedThroughProperty("tbrEmail")>
		Private _tbrEmail As ToolBarButton

		<AccessedThroughProperty("tbrDeviated")>
		Private _tbrDeviated As ToolBarButton

		<AccessedThroughProperty("ToolTip1")>
		Private _ToolTip1 As ToolTip

		<AccessedThroughProperty("btnAlpha")>
		Private _btnAlpha As Button

		<AccessedThroughProperty("ImageList2")>
		Private _ImageList2 As ImageList

		<AccessedThroughProperty("tbrGuru")>
		Private _tbrGuru As ToolBar

		<AccessedThroughProperty("ToolBarButton1")>
		Private _ToolBarButton1 As ToolBarButton

		<AccessedThroughProperty("lblGURU")>
		Private _lblGURU As Label

		<AccessedThroughProperty("ImageList_Guru")>
		Private _ImageList_Guru As ImageList

		<AccessedThroughProperty("ImageList_Guru_large")>
		Private _ImageList_Guru_large As ImageList

		<AccessedThroughProperty("btnGuru")>
		Private _btnGuru As Button

		<AccessedThroughProperty("btnVertical")>
		Private _btnVertical As Button

		<AccessedThroughProperty("AniRun")>
		Private _AniRun As AnimationControl

		<AccessedThroughProperty("tbrRunSpeed")>
		Private _tbrRunSpeed As ToolBarButton

		<AccessedThroughProperty("tbrAbort")>
		Private _tbrAbort As ToolBar

		<AccessedThroughProperty("ToolBarButton2")>
		Private _ToolBarButton2 As ToolBarButton

		<AccessedThroughProperty("pnlAIavi")>
		Private _pnlAIavi As Panel

		<AccessedThroughProperty("AIavi")>
		Private _AIavi As AnimationControl

		<AccessedThroughProperty("lblMode")>
		Private _lblMode As Label

		<AccessedThroughProperty("btnMeasUnit")>
		Private _btnMeasUnit As Button

		<AccessedThroughProperty("tbrExpertAdmin")>
		Private _tbrExpertAdmin As ToolBar

		<AccessedThroughProperty("btnToolsUploadRSVXFile")>
		Private _btnToolsUploadRSVXFile As ToolBarButton

		<AccessedThroughProperty("btnToolsUploadRSVXFiles")>
		Private _btnToolsUploadRSVXFiles As ToolBarButton

		<AccessedThroughProperty("btnToolsBatchExportFromOneFolder")>
		Private _btnToolsBatchExportFromOneFolder As ToolBarButton

		<AccessedThroughProperty("btnToolsDownloadToRSVX")>
		Private _btnToolsDownloadToRSVX As ToolBarButton

		<AccessedThroughProperty("btnToolsDeleteTemplate")>
		Private _btnToolsDeleteTemplate As ToolBarButton

		<AccessedThroughProperty("btnToolsBatchExportALL")>
		Private _btnToolsBatchExportALL As ToolBarButton

		<AccessedThroughProperty("btnToolsEncryptTemplateDatabase")>
		Private _btnToolsEncryptTemplateDatabase As ToolBarButton

		<AccessedThroughProperty("ImageList_admin")>
		Private _ImageList_admin As ImageList

		<AccessedThroughProperty("btnViewAllTemplates")>
		Private _btnViewAllTemplates As ToolBarButton

		<AccessedThroughProperty("btnViewAddedTemplates")>
		Private _btnViewAddedTemplates As ToolBarButton

		<AccessedThroughProperty("btnRunAllTemplates")>
		Private _btnRunAllTemplates As ToolBarButton

		Private m_CurrentChildForm As String

		Private m_CurrentChildFormField As String

		Public Const MAXRECENTFILES As Short = 20S

		Private nRecentFiles As Short

		Private asRecentFiles As String()

		<AccessedThroughProperty("tbrToolBar2")>
		Private _tbrToolBar2 As ToolBar

		<AccessedThroughProperty("tbrToolBar3")>
		Private _tbrToolBar3 As ToolBar

		Private m_sBatchFileName As String

		<AccessedThroughProperty("panStatus")>
		Private _panStatus As StatusBar

		<AccessedThroughProperty("ctxMenu4ToolBar")>
		Private _ctxMenu4ToolBar As ContextMenu

		<AccessedThroughProperty("tbrBatch")>
		Private _tbrBatch As ToolBarButton

		<AccessedThroughProperty("tbrPrevious")>
		Private _tbrPrevious As ToolBarButton

		<AccessedThroughProperty("tbrSep2")>
		Private _tbrSep2 As ToolBarButton

		<AccessedThroughProperty("tbrSep1")>
		Private _tbrSep1 As ToolBarButton

		<AccessedThroughProperty("tbrSep6")>
		Private _tbrSep6 As ToolBarButton

		<AccessedThroughProperty("tbrSep5")>
		Private _tbrSep5 As ToolBarButton

		<AccessedThroughProperty("HelpProvider1")>
		Private _HelpProvider1 As HelpProvider

		Private $STATIC$mnuRunPrediction_Click$20112$bRunning As Integer
	End Class
End Namespace
