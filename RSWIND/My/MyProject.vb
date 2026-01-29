Imports System
Imports System.CodeDom.Compiler
Imports System.Collections
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Diagnostics
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3.My
	<GeneratedCode("MyTemplate", "8.0.0.0")>
	<HideModuleName()>
	Friend NotInheritable Module MyProject
		<HelpKeyword("My.Computer")>
		Friend ReadOnly Property Computer As MyComputer
			<DebuggerHidden()>
			Get
				Return MyProject.m_ComputerObjectProvider.GetInstance
			End Get
		End Property

		<HelpKeyword("My.Application")>
		Friend ReadOnly Property Application As MyApplication
			<DebuggerHidden()>
			Get
				Return MyProject.m_AppObjectProvider.GetInstance
			End Get
		End Property

		<HelpKeyword("My.User")>
		Friend ReadOnly Property User As User
			<DebuggerHidden()>
			Get
				Return MyProject.m_UserObjectProvider.GetInstance
			End Get
		End Property

		<HelpKeyword("My.Forms")>
		Friend ReadOnly Property Forms As MyProject.MyForms
			<DebuggerHidden()>
			Get
				Return MyProject.m_MyFormsObjectProvider.GetInstance
			End Get
		End Property

		<HelpKeyword("My.WebServices")>
		Friend ReadOnly Property WebServices As MyProject.MyWebServices
			<DebuggerHidden()>
			Get
				Return MyProject.m_MyWebServicesObjectProvider.GetInstance
			End Get
		End Property

		Private m_ComputerObjectProvider As MyProject.ThreadSafeObjectProvider(Of MyComputer) = New MyProject.ThreadSafeObjectProvider(Of MyComputer)()

		Private m_AppObjectProvider As MyProject.ThreadSafeObjectProvider(Of MyApplication) = New MyProject.ThreadSafeObjectProvider(Of MyApplication)()

		Private m_UserObjectProvider As MyProject.ThreadSafeObjectProvider(Of User) = New MyProject.ThreadSafeObjectProvider(Of User)()

		Private m_MyFormsObjectProvider As MyProject.ThreadSafeObjectProvider(Of MyProject.MyForms) = New MyProject.ThreadSafeObjectProvider(Of MyProject.MyForms)()

		Private m_MyWebServicesObjectProvider As MyProject.ThreadSafeObjectProvider(Of MyProject.MyWebServices) = New MyProject.ThreadSafeObjectProvider(Of MyProject.MyWebServices)()

		<MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")>
		<EditorBrowsable(EditorBrowsableState.Never)>
		Friend NotInheritable Class MyForms
			Public Property BatchLog As BatchLog
				Get
					Me.m_BatchLog = MyProject.MyForms.Create__Instance__(Of BatchLog)(Me.m_BatchLog)
					Return Me.m_BatchLog
				End Get
				Set(value As BatchLog)
					If value Is Me.m_BatchLog Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of BatchLog)(Me.m_BatchLog)
				End Set
			End Property

			Public Property Clock As Clock
				Get
					Me.m_Clock = MyProject.MyForms.Create__Instance__(Of Clock)(Me.m_Clock)
					Return Me.m_Clock
				End Get
				Set(value As Clock)
					If value Is Me.m_Clock Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of Clock)(Me.m_Clock)
				End Set
			End Property

			Public Property db_guru_admin_form As db_guru_admin_form
				Get
					Me.m_db_guru_admin_form = MyProject.MyForms.Create__Instance__(Of db_guru_admin_form)(Me.m_db_guru_admin_form)
					Return Me.m_db_guru_admin_form
				End Get
				Set(value As db_guru_admin_form)
					If value Is Me.m_db_guru_admin_form Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of db_guru_admin_form)(Me.m_db_guru_admin_form)
				End Set
			End Property

			Public Property DeviationProfile As DeviationProfile
				Get
					Me.m_DeviationProfile = MyProject.MyForms.Create__Instance__(Of DeviationProfile)(Me.m_DeviationProfile)
					Return Me.m_DeviationProfile
				End Get
				Set(value As DeviationProfile)
					If value Is Me.m_DeviationProfile Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of DeviationProfile)(Me.m_DeviationProfile)
				End Set
			End Property

			Public Property dlgAIPreference As dlgAIPreference
				Get
					Me.m_dlgAIPreference = MyProject.MyForms.Create__Instance__(Of dlgAIPreference)(Me.m_dlgAIPreference)
					Return Me.m_dlgAIPreference
				End Get
				Set(value As dlgAIPreference)
					If value Is Me.m_dlgAIPreference Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of dlgAIPreference)(Me.m_dlgAIPreference)
				End Set
			End Property

			Public Property dlgBatchOpts As dlgBatchOpts
				Get
					Me.m_dlgBatchOpts = MyProject.MyForms.Create__Instance__(Of dlgBatchOpts)(Me.m_dlgBatchOpts)
					Return Me.m_dlgBatchOpts
				End Get
				Set(value As dlgBatchOpts)
					If value Is Me.m_dlgBatchOpts Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of dlgBatchOpts)(Me.m_dlgBatchOpts)
				End Set
			End Property

			Public Property dlgCBData As dlgCBData
				Get
					Me.m_dlgCBData = MyProject.MyForms.Create__Instance__(Of dlgCBData)(Me.m_dlgCBData)
					Return Me.m_dlgCBData
				End Get
				Set(value As dlgCBData)
					If value Is Me.m_dlgCBData Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of dlgCBData)(Me.m_dlgCBData)
				End Set
			End Property

			Public Property dlgCoverPageComments As dlgCoverPageComments
				Get
					Me.m_dlgCoverPageComments = MyProject.MyForms.Create__Instance__(Of dlgCoverPageComments)(Me.m_dlgCoverPageComments)
					Return Me.m_dlgCoverPageComments
				End Get
				Set(value As dlgCoverPageComments)
					If value Is Me.m_dlgCoverPageComments Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of dlgCoverPageComments)(Me.m_dlgCoverPageComments)
				End Set
			End Property

			Public Property dlgCustomPU As dlgCustomPU
				Get
					Me.m_dlgCustomPU = MyProject.MyForms.Create__Instance__(Of dlgCustomPU)(Me.m_dlgCustomPU)
					Return Me.m_dlgCustomPU
				End Get
				Set(value As dlgCustomPU)
					If value Is Me.m_dlgCustomPU Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of dlgCustomPU)(Me.m_dlgCustomPU)
				End Set
			End Property

			Public Property dlgCustomRG As dlgCustomRG
				Get
					Me.m_dlgCustomRG = MyProject.MyForms.Create__Instance__(Of dlgCustomRG)(Me.m_dlgCustomRG)
					Return Me.m_dlgCustomRG
				End Get
				Set(value As dlgCustomRG)
					If value Is Me.m_dlgCustomRG Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of dlgCustomRG)(Me.m_dlgCustomRG)
				End Set
			End Property

			Public Property dlgCustomUnitComparison As dlgCustomUnitComparison
				Get
					Me.m_dlgCustomUnitComparison = MyProject.MyForms.Create__Instance__(Of dlgCustomUnitComparison)(Me.m_dlgCustomUnitComparison)
					Return Me.m_dlgCustomUnitComparison
				End Get
				Set(value As dlgCustomUnitComparison)
					If value Is Me.m_dlgCustomUnitComparison Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of dlgCustomUnitComparison)(Me.m_dlgCustomUnitComparison)
				End Set
			End Property

			Public Property dlgDeviationEntries As dlgDeviationEntries
				Get
					Me.m_dlgDeviationEntries = MyProject.MyForms.Create__Instance__(Of dlgDeviationEntries)(Me.m_dlgDeviationEntries)
					Return Me.m_dlgDeviationEntries
				End Get
				Set(value As dlgDeviationEntries)
					If value Is Me.m_dlgDeviationEntries Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of dlgDeviationEntries)(Me.m_dlgDeviationEntries)
				End Set
			End Property

			Public Property dlgDuplicateCustomPumpingUnit As dlgDuplicateCustomPumpingUnit
				Get
					Me.m_dlgDuplicateCustomPumpingUnit = MyProject.MyForms.Create__Instance__(Of dlgDuplicateCustomPumpingUnit)(Me.m_dlgDuplicateCustomPumpingUnit)
					Return Me.m_dlgDuplicateCustomPumpingUnit
				End Get
				Set(value As dlgDuplicateCustomPumpingUnit)
					If value Is Me.m_dlgDuplicateCustomPumpingUnit Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of dlgDuplicateCustomPumpingUnit)(Me.m_dlgDuplicateCustomPumpingUnit)
				End Set
			End Property

			Public Property dlgDuplicateCustomRodGrade As dlgDuplicateCustomRodGrade
				Get
					Me.m_dlgDuplicateCustomRodGrade = MyProject.MyForms.Create__Instance__(Of dlgDuplicateCustomRodGrade)(Me.m_dlgDuplicateCustomRodGrade)
					Return Me.m_dlgDuplicateCustomRodGrade
				End Get
				Set(value As dlgDuplicateCustomRodGrade)
					If value Is Me.m_dlgDuplicateCustomRodGrade Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of dlgDuplicateCustomRodGrade)(Me.m_dlgDuplicateCustomRodGrade)
				End Set
			End Property

			Public Property dlgGuides As dlgGuides
				Get
					Me.m_dlgGuides = MyProject.MyForms.Create__Instance__(Of dlgGuides)(Me.m_dlgGuides)
					Return Me.m_dlgGuides
				End Get
				Set(value As dlgGuides)
					If value Is Me.m_dlgGuides Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of dlgGuides)(Me.m_dlgGuides)
				End Set
			End Property

			Public Property dlgImplementGuideChanges As dlgImplementGuideChanges
				Get
					Me.m_dlgImplementGuideChanges = MyProject.MyForms.Create__Instance__(Of dlgImplementGuideChanges)(Me.m_dlgImplementGuideChanges)
					Return Me.m_dlgImplementGuideChanges
				End Get
				Set(value As dlgImplementGuideChanges)
					If value Is Me.m_dlgImplementGuideChanges Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of dlgImplementGuideChanges)(Me.m_dlgImplementGuideChanges)
				End Set
			End Property

			Public Property dlgPrint As dlgPrint
				Get
					Me.m_dlgPrint = MyProject.MyForms.Create__Instance__(Of dlgPrint)(Me.m_dlgPrint)
					Return Me.m_dlgPrint
				End Get
				Set(value As dlgPrint)
					If value Is Me.m_dlgPrint Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of dlgPrint)(Me.m_dlgPrint)
				End Set
			End Property

			Public Property dlgPrintSetup As dlgPrintSetup
				Get
					Me.m_dlgPrintSetup = MyProject.MyForms.Create__Instance__(Of dlgPrintSetup)(Me.m_dlgPrintSetup)
					Return Me.m_dlgPrintSetup
				End Get
				Set(value As dlgPrintSetup)
					If value Is Me.m_dlgPrintSetup Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of dlgPrintSetup)(Me.m_dlgPrintSetup)
				End Set
			End Property

			Public Property dlgPUList As dlgPUList
				Get
					Me.m_dlgPUList = MyProject.MyForms.Create__Instance__(Of dlgPUList)(Me.m_dlgPUList)
					Return Me.m_dlgPUList
				End Get
				Set(value As dlgPUList)
					If value Is Me.m_dlgPUList Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of dlgPUList)(Me.m_dlgPUList)
				End Set
			End Property

			Public Property dlgPUManuf As dlgPUManuf
				Get
					Me.m_dlgPUManuf = MyProject.MyForms.Create__Instance__(Of dlgPUManuf)(Me.m_dlgPUManuf)
					Return Me.m_dlgPUManuf
				End Get
				Set(value As dlgPUManuf)
					If value Is Me.m_dlgPUManuf Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of dlgPUManuf)(Me.m_dlgPUManuf)
				End Set
			End Property

			Public Property dlgSelectCBM As dlgSelectCBM
				Get
					Me.m_dlgSelectCBM = MyProject.MyForms.Create__Instance__(Of dlgSelectCBM)(Me.m_dlgSelectCBM)
					Return Me.m_dlgSelectCBM
				End Get
				Set(value As dlgSelectCBM)
					If value Is Me.m_dlgSelectCBM Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of dlgSelectCBM)(Me.m_dlgSelectCBM)
				End Set
			End Property

			Public Property dlgSelectDir As dlgSelectDir
				Get
					Me.m_dlgSelectDir = MyProject.MyForms.Create__Instance__(Of dlgSelectDir)(Me.m_dlgSelectDir)
					Return Me.m_dlgSelectDir
				End Get
				Set(value As dlgSelectDir)
					If value Is Me.m_dlgSelectDir Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of dlgSelectDir)(Me.m_dlgSelectDir)
				End Set
			End Property

			Public Property dlgSelectInput As dlgSelectInput
				Get
					Me.m_dlgSelectInput = MyProject.MyForms.Create__Instance__(Of dlgSelectInput)(Me.m_dlgSelectInput)
					Return Me.m_dlgSelectInput
				End Get
				Set(value As dlgSelectInput)
					If value Is Me.m_dlgSelectInput Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of dlgSelectInput)(Me.m_dlgSelectInput)
				End Set
			End Property

			Public Property dlgVerifyMotorHP As dlgVerifyMotorHP
				Get
					Me.m_dlgVerifyMotorHP = MyProject.MyForms.Create__Instance__(Of dlgVerifyMotorHP)(Me.m_dlgVerifyMotorHP)
					Return Me.m_dlgVerifyMotorHP
				End Get
				Set(value As dlgVerifyMotorHP)
					If value Is Me.m_dlgVerifyMotorHP Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of dlgVerifyMotorHP)(Me.m_dlgVerifyMotorHP)
				End Set
			End Property

			Public Property dlgVerifySPM As dlgVerifySPM
				Get
					Me.m_dlgVerifySPM = MyProject.MyForms.Create__Instance__(Of dlgVerifySPM)(Me.m_dlgVerifySPM)
					Return Me.m_dlgVerifySPM
				End Get
				Set(value As dlgVerifySPM)
					If value Is Me.m_dlgVerifySPM Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of dlgVerifySPM)(Me.m_dlgVerifySPM)
				End Set
			End Property

			Public Property dlgWK1Setup As dlgWK1Setup
				Get
					Me.m_dlgWK1Setup = MyProject.MyForms.Create__Instance__(Of dlgWK1Setup)(Me.m_dlgWK1Setup)
					Return Me.m_dlgWK1Setup
				End Get
				Set(value As dlgWK1Setup)
					If value Is Me.m_dlgWK1Setup Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of dlgWK1Setup)(Me.m_dlgWK1Setup)
				End Set
			End Property

			Public Property FAboutSplash As FAboutSplash
				Get
					Me.m_FAboutSplash = MyProject.MyForms.Create__Instance__(Of FAboutSplash)(Me.m_FAboutSplash)
					Return Me.m_FAboutSplash
				End Get
				Set(value As FAboutSplash)
					If value Is Me.m_FAboutSplash Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of FAboutSplash)(Me.m_FAboutSplash)
				End Set
			End Property

			Public Property frmDemoMode As frmDemoMode
				Get
					Me.m_frmDemoMode = MyProject.MyForms.Create__Instance__(Of frmDemoMode)(Me.m_frmDemoMode)
					Return Me.m_frmDemoMode
				End Get
				Set(value As frmDemoMode)
					If value Is Me.m_frmDemoMode Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of frmDemoMode)(Me.m_frmDemoMode)
				End Set
			End Property

			Public Property frmDevSettings As frmDevSettings
				Get
					Me.m_frmDevSettings = MyProject.MyForms.Create__Instance__(Of frmDevSettings)(Me.m_frmDevSettings)
					Return Me.m_frmDevSettings
				End Get
				Set(value As frmDevSettings)
					If value Is Me.m_frmDevSettings Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of frmDevSettings)(Me.m_frmDevSettings)
				End Set
			End Property

			Public Property frmHowToStart As frmHowToStart
				Get
					Me.m_frmHowToStart = MyProject.MyForms.Create__Instance__(Of frmHowToStart)(Me.m_frmHowToStart)
					Return Me.m_frmHowToStart
				End Get
				Set(value As frmHowToStart)
					If value Is Me.m_frmHowToStart Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of frmHowToStart)(Me.m_frmHowToStart)
				End Set
			End Property

			Public Property frmImportDialog As frmImportDialog
				Get
					Me.m_frmImportDialog = MyProject.MyForms.Create__Instance__(Of frmImportDialog)(Me.m_frmImportDialog)
					Return Me.m_frmImportDialog
				End Get
				Set(value As frmImportDialog)
					If value Is Me.m_frmImportDialog Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of frmImportDialog)(Me.m_frmImportDialog)
				End Set
			End Property

			Public Property frmLoadGuruFNames As frmLoadGuruFNames
				Get
					Me.m_frmLoadGuruFNames = MyProject.MyForms.Create__Instance__(Of frmLoadGuruFNames)(Me.m_frmLoadGuruFNames)
					Return Me.m_frmLoadGuruFNames
				End Get
				Set(value As frmLoadGuruFNames)
					If value Is Me.m_frmLoadGuruFNames Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of frmLoadGuruFNames)(Me.m_frmLoadGuruFNames)
				End Set
			End Property

			Public Property frmSendEmail As frmSendEmail
				Get
					Me.m_frmSendEmail = MyProject.MyForms.Create__Instance__(Of frmSendEmail)(Me.m_frmSendEmail)
					Return Me.m_frmSendEmail
				End Get
				Set(value As frmSendEmail)
					If value Is Me.m_frmSendEmail Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of frmSendEmail)(Me.m_frmSendEmail)
				End Set
			End Property

			Public Property frmWizard As frmWizard
				Get
					Me.m_frmWizard = MyProject.MyForms.Create__Instance__(Of frmWizard)(Me.m_frmWizard)
					Return Me.m_frmWizard
				End Get
				Set(value As frmWizard)
					If value Is Me.m_frmWizard Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of frmWizard)(Me.m_frmWizard)
				End Set
			End Property

			Public Property IPRPlot As IPRPlot
				Get
					Me.m_IPRPlot = MyProject.MyForms.Create__Instance__(Of IPRPlot)(Me.m_IPRPlot)
					Return Me.m_IPRPlot
				End Get
				Set(value As IPRPlot)
					If value Is Me.m_IPRPlot Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of IPRPlot)(Me.m_IPRPlot)
				End Set
			End Property

			Public Property MotorData As MotorData
				Get
					Me.m_MotorData = MyProject.MyForms.Create__Instance__(Of MotorData)(Me.m_MotorData)
					Return Me.m_MotorData
				End Get
				Set(value As MotorData)
					If value Is Me.m_MotorData Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of MotorData)(Me.m_MotorData)
				End Set
			End Property

			Public Property ProdInfo As ProdInfo
				Get
					Me.m_ProdInfo = MyProject.MyForms.Create__Instance__(Of ProdInfo)(Me.m_ProdInfo)
					Return Me.m_ProdInfo
				End Get
				Set(value As ProdInfo)
					If value Is Me.m_ProdInfo Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of ProdInfo)(Me.m_ProdInfo)
				End Set
			End Property

			Public Property PTInfo As PTInfo
				Get
					Me.m_PTInfo = MyProject.MyForms.Create__Instance__(Of PTInfo)(Me.m_PTInfo)
					Return Me.m_PTInfo
				End Get
				Set(value As PTInfo)
					If value Is Me.m_PTInfo Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of PTInfo)(Me.m_PTInfo)
				End Set
			End Property

			Public Property PUData As PUData
				Get
					Me.m_PUData = MyProject.MyForms.Create__Instance__(Of PUData)(Me.m_PUData)
					Return Me.m_PUData
				End Get
				Set(value As PUData)
					If value Is Me.m_PUData Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of PUData)(Me.m_PUData)
				End Set
			End Property

			Public Property Results As Results
				Get
					Me.m_Results = MyProject.MyForms.Create__Instance__(Of Results)(Me.m_Results)
					Return Me.m_Results
				End Get
				Set(value As Results)
					If value Is Me.m_Results Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of Results)(Me.m_Results)
				End Set
			End Property

			Public Property RODSTAR As RODSTAR
				Get
					Me.m_RODSTAR = MyProject.MyForms.Create__Instance__(Of RODSTAR)(Me.m_RODSTAR)
					Return Me.m_RODSTAR
				End Get
				Set(value As RODSTAR)
					If value Is Me.m_RODSTAR Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of RODSTAR)(Me.m_RODSTAR)
				End Set
			End Property

			Public Property RSInput As RSInput
				Get
					Me.m_RSInput = MyProject.MyForms.Create__Instance__(Of RSInput)(Me.m_RSInput)
					Return Me.m_RSInput
				End Get
				Set(value As RSInput)
					If value Is Me.m_RSInput Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of RSInput)(Me.m_RSInput)
				End Set
			End Property

			Public Property RswinSetup As RswinSetup
				Get
					Me.m_RswinSetup = MyProject.MyForms.Create__Instance__(Of RswinSetup)(Me.m_RswinSetup)
					Return Me.m_RswinSetup
				End Get
				Set(value As RswinSetup)
					If value Is Me.m_RswinSetup Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of RswinSetup)(Me.m_RswinSetup)
				End Set
			End Property

			Public Property SetupEquip As SetupEquip
				Get
					Me.m_SetupEquip = MyProject.MyForms.Create__Instance__(Of SetupEquip)(Me.m_SetupEquip)
					Return Me.m_SetupEquip
				End Get
				Set(value As SetupEquip)
					If value Is Me.m_SetupEquip Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of SetupEquip)(Me.m_SetupEquip)
				End Set
			End Property

			Public Property SystemOfUnits As SystemOfUnits
				Get
					Me.m_SystemOfUnits = MyProject.MyForms.Create__Instance__(Of SystemOfUnits)(Me.m_SystemOfUnits)
					Return Me.m_SystemOfUnits
				End Get
				Set(value As SystemOfUnits)
					If value Is Me.m_SystemOfUnits Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of SystemOfUnits)(Me.m_SystemOfUnits)
				End Set
			End Property

			Public Property Version As Version
				Get
					Me.m_Version = MyProject.MyForms.Create__Instance__(Of Version)(Me.m_Version)
					Return Me.m_Version
				End Get
				Set(value As Version)
					If value Is Me.m_Version Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of Version)(Me.m_Version)
				End Set
			End Property

			Public Property VisInput As VisInput
				Get
					Me.m_VisInput = MyProject.MyForms.Create__Instance__(Of VisInput)(Me.m_VisInput)
					Return Me.m_VisInput
				End Get
				Set(value As VisInput)
					If value Is Me.m_VisInput Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of VisInput)(Me.m_VisInput)
				End Set
			End Property

			Public Property WellInfo As WellInfo
				Get
					Me.m_WellInfo = MyProject.MyForms.Create__Instance__(Of WellInfo)(Me.m_WellInfo)
					Return Me.m_WellInfo
				End Get
				Set(value As WellInfo)
					If value Is Me.m_WellInfo Then
						Return
					End If
					If value IsNot Nothing Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of WellInfo)(Me.m_WellInfo)
				End Set
			End Property

			<DebuggerHidden()>
			Private Shared Function Create__Instance__(Of T As{Form, New})(Instance As T) As T
				If Instance Is Nothing OrElse Instance.IsDisposed Then
					If MyProject.MyForms.m_FormBeingCreated IsNot Nothing Then
						If MyProject.MyForms.m_FormBeingCreated.ContainsKey(GetType(T)) Then
							Throw New InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", New String(-1) {}))
						End If
					Else
						MyProject.MyForms.m_FormBeingCreated = New Hashtable()
					End If
					MyProject.MyForms.m_FormBeingCreated.Add(GetType(T), Nothing)
					Try
						Return Activator.CreateInstance(Of T)()
					Catch ex As TargetInvocationException When ex.InnerException IsNot Nothing
						Dim resourceString As String = Utils.GetResourceString("WinForms_SeeInnerException", New String() { ex.InnerException.Message })
						Throw New InvalidOperationException(resourceString, ex.InnerException)
					Finally
						MyProject.MyForms.m_FormBeingCreated.Remove(GetType(T))
					End Try
					Return Instance
				End If
				Return Instance
			End Function

			<DebuggerHidden()>
			Private Sub Dispose__Instance__(Of T As Form)(ByRef instance As T)
				instance.Dispose()
				instance = Nothing
			End Sub

			<DebuggerHidden()>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Sub New()
			End Sub

			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function Equals(o As Object) As Boolean
				Return MyBase.Equals(RuntimeHelpers.GetObjectValue(o))
			End Function

			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function GetHashCode() As Integer
				Return MyBase.GetHashCode()
			End Function

			<EditorBrowsable(EditorBrowsableState.Never)>
			Friend Function [GetType]() As Type
				Return GetType(MyProject.MyForms)
			End Function

			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function ToString() As String
				Return MyBase.ToString()
			End Function

			Public m_BatchLog As BatchLog

			Public m_Clock As Clock

			Public m_db_guru_admin_form As db_guru_admin_form

			Public m_DeviationProfile As DeviationProfile

			Public m_dlgAIPreference As dlgAIPreference

			Public m_dlgBatchOpts As dlgBatchOpts

			Public m_dlgCBData As dlgCBData

			Public m_dlgCoverPageComments As dlgCoverPageComments

			Public m_dlgCustomPU As dlgCustomPU

			Public m_dlgCustomRG As dlgCustomRG

			Public m_dlgCustomUnitComparison As dlgCustomUnitComparison

			Public m_dlgDeviationEntries As dlgDeviationEntries

			Public m_dlgDuplicateCustomPumpingUnit As dlgDuplicateCustomPumpingUnit

			Public m_dlgDuplicateCustomRodGrade As dlgDuplicateCustomRodGrade

			Public m_dlgGuides As dlgGuides

			Public m_dlgImplementGuideChanges As dlgImplementGuideChanges

			Public m_dlgPrint As dlgPrint

			Public m_dlgPrintSetup As dlgPrintSetup

			Public m_dlgPUList As dlgPUList

			Public m_dlgPUManuf As dlgPUManuf

			Public m_dlgSelectCBM As dlgSelectCBM

			Public m_dlgSelectDir As dlgSelectDir

			Public m_dlgSelectInput As dlgSelectInput

			Public m_dlgVerifyMotorHP As dlgVerifyMotorHP

			Public m_dlgVerifySPM As dlgVerifySPM

			Public m_dlgWK1Setup As dlgWK1Setup

			Public m_FAboutSplash As FAboutSplash

			Public m_frmDemoMode As frmDemoMode

			Public m_frmDevSettings As frmDevSettings

			Public m_frmHowToStart As frmHowToStart

			Public m_frmImportDialog As frmImportDialog

			Public m_frmLoadGuruFNames As frmLoadGuruFNames

			Public m_frmSendEmail As frmSendEmail

			Public m_frmWizard As frmWizard

			Public m_IPRPlot As IPRPlot

			Public m_MotorData As MotorData

			Public m_ProdInfo As ProdInfo

			Public m_PTInfo As PTInfo

			Public m_PUData As PUData

			Public m_Results As Results

			Public m_RODSTAR As RODSTAR

			Public m_RSInput As RSInput

			Public m_RswinSetup As RswinSetup

			Public m_SetupEquip As SetupEquip

			Public m_SystemOfUnits As SystemOfUnits

			Public m_Version As Version

			Public m_VisInput As VisInput

			Public m_WellInfo As WellInfo

			<ThreadStatic()>
			Private Shared m_FormBeingCreated As Hashtable
		End Class

		<MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")>
		<EditorBrowsable(EditorBrowsableState.Never)>
		Friend NotInheritable Class MyWebServices
			<DebuggerHidden()>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function Equals(o As Object) As Boolean
				Return MyBase.Equals(RuntimeHelpers.GetObjectValue(o))
			End Function

			<EditorBrowsable(EditorBrowsableState.Never)>
			<DebuggerHidden()>
			Public Overrides Function GetHashCode() As Integer
				Return MyBase.GetHashCode()
			End Function

			<DebuggerHidden()>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Friend Function [GetType]() As Type
				Return GetType(MyProject.MyWebServices)
			End Function

			<DebuggerHidden()>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function ToString() As String
				Return MyBase.ToString()
			End Function

			<DebuggerHidden()>
			Private Shared Function Create__Instance__(Of T As New)(instance As T) As T
				If instance Is Nothing Then
					Return Activator.CreateInstance(Of T)()
				End If
				Return instance
			End Function

			<DebuggerHidden()>
			Private Sub Dispose__Instance__(Of T)(ByRef instance As T)
				instance = Nothing
			End Sub

			<DebuggerHidden()>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Sub New()
			End Sub
		End Class

		<ComVisible(False)>
		<EditorBrowsable(EditorBrowsableState.Never)>
		Friend NotInheritable Class ThreadSafeObjectProvider(Of T As New)
			Friend ReadOnly Property GetInstance As T
				<DebuggerHidden()>
				Get
					If MyProject.ThreadSafeObjectProvider(Of T).m_ThreadStaticValue Is Nothing Then
						MyProject.ThreadSafeObjectProvider(Of T).m_ThreadStaticValue = Activator.CreateInstance(Of T)()
					End If
					Return MyProject.ThreadSafeObjectProvider(Of T).m_ThreadStaticValue
				End Get
			End Property

			<EditorBrowsable(EditorBrowsableState.Never)>
			<DebuggerHidden()>
			Public Sub New()
			End Sub

			<CompilerGenerated()>
			<ThreadStatic()>
			Private Shared m_ThreadStaticValue As T
		End Class
	End Module
End Namespace
