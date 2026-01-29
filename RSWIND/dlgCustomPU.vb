Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Globalization
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.Compatibility.VB6
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	Friend Partial Class dlgCustomPU
		Inherits Form

		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.dlgCustomPU_Load
			Me.sAlreadyPU = "There is already a pumping unit with this manufacturer, API designation, and unit name. Do you want to change the information for this pumping unit?"
			Me.sCalculatedStrokeLength = Util.AssignValueToConstant("dlgCustomPU", "sCalculatedStrokeLength", "Calculated stroke length")
			Me.bOK = False
			If dlgCustomPU.m_vb6FormDefInstance Is Nothing Then
				If dlgCustomPU.m_InitializingDefInstance Then
					dlgCustomPU.m_vb6FormDefInstance = Me
				Else
					Try
						If Assembly.GetExecutingAssembly().EntryPoint.DeclaringType Is Me.[GetType]() Then
							dlgCustomPU.m_vb6FormDefInstance = Me
						End If
					Catch ex As Exception
					End Try
				End If
			End If
			Me.InitializeComponent()
		End Sub

		Public Overridable Property cmdOK As Button
			Get
				Return Me._cmdOK
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.cmdOK_Click
				If Me._cmdOK IsNot Nothing Then
					RemoveHandler Me._cmdOK.Click, value2
				End If
				Me._cmdOK = value
				If Me._cmdOK IsNot Nothing Then
					AddHandler Me._cmdOK.Click, value2
				End If
			End Set
		End Property

		Public Overridable Property cmdCancel As Button
			Get
				Return Me._cmdCancel
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.cmdCancel_Click
				If Me._cmdCancel IsNot Nothing Then
					RemoveHandler Me._cmdCancel.Click, value2
				End If
				Me._cmdCancel = value
				If Me._cmdCancel IsNot Nothing Then
					AddHandler Me._cmdCancel.Click, value2
				End If
			End Set
		End Property

		Public Overridable Property cmdHelp As Button
			Get
				Return Me._cmdHelp
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.cmdHelp_Click
				If Me._cmdHelp IsNot Nothing Then
					RemoveHandler Me._cmdHelp.Click, value2
				End If
				Me._cmdHelp = value
				If Me._cmdHelp IsNot Nothing Then
					AddHandler Me._cmdHelp.Click, value2
				End If
			End Set
		End Property

		Public Overridable Property txtM As TextBox
			Get
				Return Me._txtM
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtM_Enter
				Dim value3 As EventHandler = AddressOf Me.txtM_Leave
				Dim value4 As KeyPressEventHandler = AddressOf Me.txtM_KeyPress
				Dim value5 As KeyEventHandler = AddressOf Me.txtM_KeyDown
				Dim value6 As EventHandler = AddressOf Me.txtM_TextChanged
				If Me._txtM IsNot Nothing Then
					RemoveHandler Me._txtM.Enter, value2
					RemoveHandler Me._txtM.Leave, value3
					RemoveHandler Me._txtM.KeyPress, value4
					RemoveHandler Me._txtM.KeyDown, value5
					RemoveHandler Me._txtM.TextChanged, value6
				End If
				Me._txtM = value
				If Me._txtM IsNot Nothing Then
					AddHandler Me._txtM.Enter, value2
					AddHandler Me._txtM.Leave, value3
					AddHandler Me._txtM.KeyPress, value4
					AddHandler Me._txtM.KeyDown, value5
					AddHandler Me._txtM.TextChanged, value6
				End If
			End Set
		End Property

		Public Overridable Property txtS As TextBox
			Get
				Return Me._txtS
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtS_Enter
				Dim value3 As EventHandler = AddressOf Me.txtS_Leave
				Dim value4 As KeyPressEventHandler = AddressOf Me.txtS_KeyPress
				Dim value5 As KeyEventHandler = AddressOf Me.txtS_KeyDown
				Dim value6 As EventHandler = AddressOf Me.txtS_TextChanged
				If Me._txtS IsNot Nothing Then
					RemoveHandler Me._txtS.Enter, value2
					RemoveHandler Me._txtS.Leave, value3
					RemoveHandler Me._txtS.KeyPress, value4
					RemoveHandler Me._txtS.KeyDown, value5
					RemoveHandler Me._txtS.TextChanged, value6
				End If
				Me._txtS = value
				If Me._txtS IsNot Nothing Then
					AddHandler Me._txtS.Enter, value2
					AddHandler Me._txtS.Leave, value3
					AddHandler Me._txtS.KeyPress, value4
					AddHandler Me._txtS.KeyDown, value5
					AddHandler Me._txtS.TextChanged, value6
				End If
			End Set
		End Property

		Public Overridable Property txtV0 As TextBox
			Get
				Return Me._txtV0
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtV0_Enter
				Dim value3 As EventHandler = AddressOf Me.txtV0_Leave
				Dim value4 As KeyPressEventHandler = AddressOf Me.txtV0_KeyPress
				Dim value5 As KeyEventHandler = AddressOf Me.txtV0_KeyDown
				Dim value6 As EventHandler = AddressOf Me.txtV0_TextChanged
				If Me._txtV0 IsNot Nothing Then
					RemoveHandler Me._txtV0.Enter, value2
					RemoveHandler Me._txtV0.Leave, value3
					RemoveHandler Me._txtV0.KeyPress, value4
					RemoveHandler Me._txtV0.KeyDown, value5
					RemoveHandler Me._txtV0.TextChanged, value6
				End If
				Me._txtV0 = value
				If Me._txtV0 IsNot Nothing Then
					AddHandler Me._txtV0.Enter, value2
					AddHandler Me._txtV0.Leave, value3
					AddHandler Me._txtV0.KeyPress, value4
					AddHandler Me._txtV0.KeyDown, value5
					AddHandler Me._txtV0.TextChanged, value6
				End If
			End Set
		End Property

		Public Overridable Property _Label_25 As Label
			Get
				Return Me.__Label_25
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_25 = value
			End Set
		End Property

		Public Overridable Property _Label_26 As Label
			Get
				Return Me.__Label_26
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_26 = value
			End Set
		End Property

		Public Overridable Property _Label_27 As Label
			Get
				Return Me.__Label_27
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_27 = value
			End Set
		End Property

		Public Overridable Property _panDimensions_4 As Panel
			Get
				Return Me.__panDimensions_4
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me.__panDimensions_4 = value
			End Set
		End Property

		Public Overridable Property txtUnbalance As TextBox
			Get
				Return Me._txtUnbalance
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtUnbalance_Leave
				Dim value3 As KeyPressEventHandler = AddressOf Me.txtUnbalance_KeyPress
				Dim value4 As KeyEventHandler = AddressOf Me.txtUnbalance_KeyDown
				Dim value5 As EventHandler = AddressOf Me.txtUnbalance_Enter
				Dim value6 As EventHandler = AddressOf Me.txtUnbalance_TextChanged
				If Me._txtUnbalance IsNot Nothing Then
					RemoveHandler Me._txtUnbalance.Leave, value2
					RemoveHandler Me._txtUnbalance.KeyPress, value3
					RemoveHandler Me._txtUnbalance.KeyDown, value4
					RemoveHandler Me._txtUnbalance.Enter, value5
					RemoveHandler Me._txtUnbalance.TextChanged, value6
				End If
				Me._txtUnbalance = value
				If Me._txtUnbalance IsNot Nothing Then
					AddHandler Me._txtUnbalance.Leave, value2
					AddHandler Me._txtUnbalance.KeyPress, value3
					AddHandler Me._txtUnbalance.KeyDown, value4
					AddHandler Me._txtUnbalance.Enter, value5
					AddHandler Me._txtUnbalance.TextChanged, value6
				End If
			End Set
		End Property

		Public Overridable Property txtCrankOffset As TextBox
			Get
				Return Me._txtCrankOffset
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtCrankOffset_Leave
				Dim value3 As KeyPressEventHandler = AddressOf Me.txtCrankOffset_KeyPress
				Dim value4 As KeyEventHandler = AddressOf Me.txtCrankOffset_KeyDown
				Dim value5 As EventHandler = AddressOf Me.txtCrankOffset_Enter
				Dim value6 As EventHandler = AddressOf Me.txtCrankOffset_TextChanged
				If Me._txtCrankOffset IsNot Nothing Then
					RemoveHandler Me._txtCrankOffset.Leave, value2
					RemoveHandler Me._txtCrankOffset.KeyPress, value3
					RemoveHandler Me._txtCrankOffset.KeyDown, value4
					RemoveHandler Me._txtCrankOffset.Enter, value5
					RemoveHandler Me._txtCrankOffset.TextChanged, value6
				End If
				Me._txtCrankOffset = value
				If Me._txtCrankOffset IsNot Nothing Then
					AddHandler Me._txtCrankOffset.Leave, value2
					AddHandler Me._txtCrankOffset.KeyPress, value3
					AddHandler Me._txtCrankOffset.KeyDown, value4
					AddHandler Me._txtCrankOffset.Enter, value5
					AddHandler Me._txtCrankOffset.TextChanged, value6
				End If
			End Set
		End Property

		Public Overridable Property _Label_23 As Label
			Get
				Return Me.__Label_23
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_23 = value
			End Set
		End Property

		Public Overridable Property _Label_24 As Label
			Get
				Return Me.__Label_24
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_24 = value
			End Set
		End Property

		Public Overridable Property _panDimensions_3 As Panel
			Get
				Return Me.__panDimensions_3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me.__panDimensions_3 = value
			End Set
		End Property

		Public Overridable Property txtPitmanLength As TextBox
			Get
				Return Me._txtPitmanLength
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtPitmanLength_Enter
				Dim value3 As EventHandler = AddressOf Me.txtPitmanLength_Leave
				Dim value4 As KeyPressEventHandler = AddressOf Me.txtPitmanLength_KeyPress
				Dim value5 As KeyEventHandler = AddressOf Me.txtPitmanLength_KeyDown
				Dim value6 As EventHandler = AddressOf Me.txtPitmanLength_TextChanged
				If Me._txtPitmanLength IsNot Nothing Then
					RemoveHandler Me._txtPitmanLength.Enter, value2
					RemoveHandler Me._txtPitmanLength.Leave, value3
					RemoveHandler Me._txtPitmanLength.KeyPress, value4
					RemoveHandler Me._txtPitmanLength.KeyDown, value5
					RemoveHandler Me._txtPitmanLength.TextChanged, value6
				End If
				Me._txtPitmanLength = value
				If Me._txtPitmanLength IsNot Nothing Then
					AddHandler Me._txtPitmanLength.Enter, value2
					AddHandler Me._txtPitmanLength.Leave, value3
					AddHandler Me._txtPitmanLength.KeyPress, value4
					AddHandler Me._txtPitmanLength.KeyDown, value5
					AddHandler Me._txtPitmanLength.TextChanged, value6
				End If
			End Set
		End Property

		Public Overridable Property txtDrumDiamRatio As TextBox
			Get
				Return Me._txtDrumDiamRatio
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtDrumDiamRatio_Enter
				Dim value3 As EventHandler = AddressOf Me.txtDrumDiamRatio_Leave
				Dim value4 As KeyPressEventHandler = AddressOf Me.txtDrumDiamRatio_KeyPress
				Dim value5 As KeyEventHandler = AddressOf Me.txtDrumDiamRatio_KeyDown
				Dim value6 As EventHandler = AddressOf Me.txtDrumDiamRatio_TextChanged
				If Me._txtDrumDiamRatio IsNot Nothing Then
					RemoveHandler Me._txtDrumDiamRatio.Enter, value2
					RemoveHandler Me._txtDrumDiamRatio.Leave, value3
					RemoveHandler Me._txtDrumDiamRatio.KeyPress, value4
					RemoveHandler Me._txtDrumDiamRatio.KeyDown, value5
					RemoveHandler Me._txtDrumDiamRatio.TextChanged, value6
				End If
				Me._txtDrumDiamRatio = value
				If Me._txtDrumDiamRatio IsNot Nothing Then
					AddHandler Me._txtDrumDiamRatio.Enter, value2
					AddHandler Me._txtDrumDiamRatio.Leave, value3
					AddHandler Me._txtDrumDiamRatio.KeyPress, value4
					AddHandler Me._txtDrumDiamRatio.KeyDown, value5
					AddHandler Me._txtDrumDiamRatio.TextChanged, value6
				End If
			End Set
		End Property

		Public Overridable Property txtSprocketDistance As TextBox
			Get
				Return Me._txtSprocketDistance
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtSprocketDistance_Enter
				Dim value3 As EventHandler = AddressOf Me.txtSprocketDistance_Leave
				Dim value4 As KeyPressEventHandler = AddressOf Me.txtSprocketDistance_KeyPress
				Dim value5 As KeyEventHandler = AddressOf Me.txtSprocketDistance_KeyDown
				Dim value6 As EventHandler = AddressOf Me.txtSprocketDistance_TextChanged
				If Me._txtSprocketDistance IsNot Nothing Then
					RemoveHandler Me._txtSprocketDistance.Enter, value2
					RemoveHandler Me._txtSprocketDistance.Leave, value3
					RemoveHandler Me._txtSprocketDistance.KeyPress, value4
					RemoveHandler Me._txtSprocketDistance.KeyDown, value5
					RemoveHandler Me._txtSprocketDistance.TextChanged, value6
				End If
				Me._txtSprocketDistance = value
				If Me._txtSprocketDistance IsNot Nothing Then
					AddHandler Me._txtSprocketDistance.Enter, value2
					AddHandler Me._txtSprocketDistance.Leave, value3
					AddHandler Me._txtSprocketDistance.KeyPress, value4
					AddHandler Me._txtSprocketDistance.KeyDown, value5
					AddHandler Me._txtSprocketDistance.TextChanged, value6
				End If
			End Set
		End Property

		Public Overridable Property txtSprocketDiameter As TextBox
			Get
				Return Me._txtSprocketDiameter
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtSprocketDiameter_Enter
				Dim value3 As EventHandler = AddressOf Me.txtSprocketDiameter_Leave
				Dim value4 As KeyPressEventHandler = AddressOf Me.txtSprocketDiameter_KeyPress
				Dim value5 As KeyEventHandler = AddressOf Me.txtSprocketDiameter_KeyDown
				Dim value6 As EventHandler = AddressOf Me.txtSprocketDiameter_TextChanged
				If Me._txtSprocketDiameter IsNot Nothing Then
					RemoveHandler Me._txtSprocketDiameter.Enter, value2
					RemoveHandler Me._txtSprocketDiameter.Leave, value3
					RemoveHandler Me._txtSprocketDiameter.KeyPress, value4
					RemoveHandler Me._txtSprocketDiameter.KeyDown, value5
					RemoveHandler Me._txtSprocketDiameter.TextChanged, value6
				End If
				Me._txtSprocketDiameter = value
				If Me._txtSprocketDiameter IsNot Nothing Then
					AddHandler Me._txtSprocketDiameter.Enter, value2
					AddHandler Me._txtSprocketDiameter.Leave, value3
					AddHandler Me._txtSprocketDiameter.KeyPress, value4
					AddHandler Me._txtSprocketDiameter.KeyDown, value5
					AddHandler Me._txtSprocketDiameter.TextChanged, value6
				End If
			End Set
		End Property

		Public Overridable Property _panCalcStroke_0 As Label
			Get
				Return Me.__panCalcStroke_0
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__panCalcStroke_0 = value
			End Set
		End Property

		Public Overridable Property _Label_30 As Label
			Get
				Return Me.__Label_30
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_30 = value
			End Set
		End Property

		Public Overridable Property _Label_17 As Label
			Get
				Return Me.__Label_17
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_17 = value
			End Set
		End Property

		Public Overridable Property _Label_16 As Label
			Get
				Return Me.__Label_16
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_16 = value
			End Set
		End Property

		Public Overridable Property _Label_15 As Label
			Get
				Return Me.__Label_15
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_15 = value
			End Set
		End Property

		Public Overridable Property _Label_14 As Label
			Get
				Return Me.__Label_14
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_14 = value
			End Set
		End Property

		Public Overridable Property cboCrankHoles As ComboBox
			Get
				Return Me._cboCrankHoles
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim value2 As EventHandler = AddressOf Me.cboCrankHoles_Leave
				Dim value3 As EventHandler = AddressOf Me.cboCrankHoles_Enter
				Dim value4 As EventHandler = AddressOf Me.cboCrankHoles_DropDown
				Dim value5 As EventHandler = AddressOf Me.cboCrankHoles_SelectedIndexChanged
				If Me._cboCrankHoles IsNot Nothing Then
					RemoveHandler Me._cboCrankHoles.Leave, value2
					RemoveHandler Me._cboCrankHoles.Enter, value3
					RemoveHandler Me._cboCrankHoles.DropDown, value4
					RemoveHandler Me._cboCrankHoles.SelectedIndexChanged, value5
				End If
				Me._cboCrankHoles = value
				If Me._cboCrankHoles IsNot Nothing Then
					AddHandler Me._cboCrankHoles.Leave, value2
					AddHandler Me._cboCrankHoles.Enter, value3
					AddHandler Me._cboCrankHoles.DropDown, value4
					AddHandler Me._cboCrankHoles.SelectedIndexChanged, value5
				End If
			End Set
		End Property

		Public Overridable Property _txtR_5 As TextBox
			Get
				Return Me.__txtR_5
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me._txtR_5_Leave
				Dim value3 As EventHandler = AddressOf Me._txtR_5_Enter
				Dim value4 As EventHandler = AddressOf Me.txtR_5_Leave
				Dim value5 As EventHandler = AddressOf Me._txtR_5_TextChanged
				If Me.__txtR_5 IsNot Nothing Then
					RemoveHandler Me.__txtR_5.Leave, value2
					RemoveHandler Me.__txtR_5.Enter, value3
					RemoveHandler Me.__txtR_5.Leave, value4
					RemoveHandler Me.__txtR_5.TextChanged, value5
				End If
				Me.__txtR_5 = value
				If Me.__txtR_5 IsNot Nothing Then
					AddHandler Me.__txtR_5.Leave, value2
					AddHandler Me.__txtR_5.Enter, value3
					AddHandler Me.__txtR_5.Leave, value4
					AddHandler Me.__txtR_5.TextChanged, value5
				End If
			End Set
		End Property

		Public Overridable Property _txtR_4 As TextBox
			Get
				Return Me.__txtR_4
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me._txtR_4_Leave
				Dim value3 As EventHandler = AddressOf Me._txtR_4_Enter
				Dim value4 As EventHandler = AddressOf Me.txtR_4_Leave
				Dim value5 As EventHandler = AddressOf Me._txtR_4_TextChanged
				If Me.__txtR_4 IsNot Nothing Then
					RemoveHandler Me.__txtR_4.Leave, value2
					RemoveHandler Me.__txtR_4.Enter, value3
					RemoveHandler Me.__txtR_4.Leave, value4
					RemoveHandler Me.__txtR_4.TextChanged, value5
				End If
				Me.__txtR_4 = value
				If Me.__txtR_4 IsNot Nothing Then
					AddHandler Me.__txtR_4.Leave, value2
					AddHandler Me.__txtR_4.Enter, value3
					AddHandler Me.__txtR_4.Leave, value4
					AddHandler Me.__txtR_4.TextChanged, value5
				End If
			End Set
		End Property

		Public Overridable Property _txtR_3 As TextBox
			Get
				Return Me.__txtR_3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me._txtR_3_Leave
				Dim value3 As EventHandler = AddressOf Me._txtR_3_Enter
				Dim value4 As EventHandler = AddressOf Me.txtR_3_Leave
				Dim value5 As EventHandler = AddressOf Me._txtR_3_TextChanged
				If Me.__txtR_3 IsNot Nothing Then
					RemoveHandler Me.__txtR_3.Leave, value2
					RemoveHandler Me.__txtR_3.Enter, value3
					RemoveHandler Me.__txtR_3.Leave, value4
					RemoveHandler Me.__txtR_3.TextChanged, value5
				End If
				Me.__txtR_3 = value
				If Me.__txtR_3 IsNot Nothing Then
					AddHandler Me.__txtR_3.Leave, value2
					AddHandler Me.__txtR_3.Enter, value3
					AddHandler Me.__txtR_3.Leave, value4
					AddHandler Me.__txtR_3.TextChanged, value5
				End If
			End Set
		End Property

		Public Overridable Property _txtR_2 As TextBox
			Get
				Return Me.__txtR_2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me._txtR_2_Leave
				Dim value3 As EventHandler = AddressOf Me._txtR_2_Enter
				Dim value4 As EventHandler = AddressOf Me.txtR_2_Leave
				Dim value5 As EventHandler = AddressOf Me._txtR_2_TextChanged
				If Me.__txtR_2 IsNot Nothing Then
					RemoveHandler Me.__txtR_2.Leave, value2
					RemoveHandler Me.__txtR_2.Enter, value3
					RemoveHandler Me.__txtR_2.Leave, value4
					RemoveHandler Me.__txtR_2.TextChanged, value5
				End If
				Me.__txtR_2 = value
				If Me.__txtR_2 IsNot Nothing Then
					AddHandler Me.__txtR_2.Leave, value2
					AddHandler Me.__txtR_2.Enter, value3
					AddHandler Me.__txtR_2.Leave, value4
					AddHandler Me.__txtR_2.TextChanged, value5
				End If
			End Set
		End Property

		Public Overridable Property _txtR_1 As TextBox
			Get
				Return Me.__txtR_1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me._txtR_1_Leave
				Dim value3 As EventHandler = AddressOf Me._txtR_1_Enter
				Dim value4 As EventHandler = AddressOf Me.txtR_1_Leave
				Dim value5 As EventHandler = AddressOf Me._txtR_1_TextChanged
				If Me.__txtR_1 IsNot Nothing Then
					RemoveHandler Me.__txtR_1.Leave, value2
					RemoveHandler Me.__txtR_1.Enter, value3
					RemoveHandler Me.__txtR_1.Leave, value4
					RemoveHandler Me.__txtR_1.TextChanged, value5
				End If
				Me.__txtR_1 = value
				If Me.__txtR_1 IsNot Nothing Then
					AddHandler Me.__txtR_1.Leave, value2
					AddHandler Me.__txtR_1.Enter, value3
					AddHandler Me.__txtR_1.Leave, value4
					AddHandler Me.__txtR_1.TextChanged, value5
				End If
			End Set
		End Property

		Public Overridable Property _panCalcStroke_5 As Label
			Get
				Return Me.__panCalcStroke_5
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__panCalcStroke_5 = value
			End Set
		End Property

		Public Overridable Property _panCalcStroke_4 As Label
			Get
				Return Me.__panCalcStroke_4
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__panCalcStroke_4 = value
			End Set
		End Property

		Public Overridable Property _panCalcStroke_3 As Label
			Get
				Return Me.__panCalcStroke_3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__panCalcStroke_3 = value
			End Set
		End Property

		Public Overridable Property _panCalcStroke_2 As Label
			Get
				Return Me.__panCalcStroke_2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__panCalcStroke_2 = value
			End Set
		End Property

		Public Overridable Property _panCalcStroke_1 As Label
			Get
				Return Me.__panCalcStroke_1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__panCalcStroke_1 = value
			End Set
		End Property

		Public Overridable Property _Label_8 As Label
			Get
				Return Me.__Label_8
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_8 = value
			End Set
		End Property

		Public Overridable Property _Label_13 As Label
			Get
				Return Me.__Label_13
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_13 = value
			End Set
		End Property

		Public Overridable Property _Label_12 As Label
			Get
				Return Me.__Label_12
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_12 = value
			End Set
		End Property

		Public Overridable Property _Label_11 As Label
			Get
				Return Me.__Label_11
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_11 = value
			End Set
		End Property

		Public Overridable Property _Label_10 As Label
			Get
				Return Me.__Label_10
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_10 = value
			End Set
		End Property

		Public Overridable Property _Label_9 As Label
			Get
				Return Me.__Label_9
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_9 = value
			End Set
		End Property

		Public Overridable Property _Label_29 As Label
			Get
				Return Me.__Label_29
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_29 = value
			End Set
		End Property

		Public Overridable Property _panDimensions_0 As Panel
			Get
				Return Me.__panDimensions_0
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me.__panDimensions_0 = value
			End Set
		End Property

		Public Overridable Property txtP As TextBox
			Get
				Return Me._txtP
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtP_Enter
				Dim value3 As EventHandler = AddressOf Me.txtP_Leave
				Dim value4 As KeyPressEventHandler = AddressOf Me.txtP_KeyPress
				Dim value5 As KeyEventHandler = AddressOf Me.txtP_KeyDown
				Dim value6 As EventHandler = AddressOf Me.txtP_TextChanged
				If Me._txtP IsNot Nothing Then
					RemoveHandler Me._txtP.Enter, value2
					RemoveHandler Me._txtP.Leave, value3
					RemoveHandler Me._txtP.KeyPress, value4
					RemoveHandler Me._txtP.KeyDown, value5
					RemoveHandler Me._txtP.TextChanged, value6
				End If
				Me._txtP = value
				If Me._txtP IsNot Nothing Then
					AddHandler Me._txtP.Enter, value2
					AddHandler Me._txtP.Leave, value3
					AddHandler Me._txtP.KeyPress, value4
					AddHandler Me._txtP.KeyDown, value5
					AddHandler Me._txtP.TextChanged, value6
				End If
			End Set
		End Property

		Public Overridable Property txtK As TextBox
			Get
				Return Me._txtK
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtK_Enter
				Dim value3 As EventHandler = AddressOf Me.txtK_Leave
				Dim value4 As KeyPressEventHandler = AddressOf Me.txtK_KeyPress
				Dim value5 As KeyEventHandler = AddressOf Me.txtK_KeyDown
				Dim value6 As EventHandler = AddressOf Me.txtK_TextChanged
				If Me._txtK IsNot Nothing Then
					RemoveHandler Me._txtK.Enter, value2
					RemoveHandler Me._txtK.Leave, value3
					RemoveHandler Me._txtK.KeyPress, value4
					RemoveHandler Me._txtK.KeyDown, value5
					RemoveHandler Me._txtK.TextChanged, value6
				End If
				Me._txtK = value
				If Me._txtK IsNot Nothing Then
					AddHandler Me._txtK.Enter, value2
					AddHandler Me._txtK.Leave, value3
					AddHandler Me._txtK.KeyPress, value4
					AddHandler Me._txtK.KeyDown, value5
					AddHandler Me._txtK.TextChanged, value6
				End If
			End Set
		End Property

		Public Overridable Property txtI As TextBox
			Get
				Return Me._txtI
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtI_Enter
				Dim value3 As EventHandler = AddressOf Me.txtI_Leave
				Dim value4 As KeyPressEventHandler = AddressOf Me.txtI_KeyPress
				Dim value5 As KeyEventHandler = AddressOf Me.txtI_KeyDown
				Dim value6 As EventHandler = AddressOf Me.txtI_TextChanged
				If Me._txtI IsNot Nothing Then
					RemoveHandler Me._txtI.Enter, value2
					RemoveHandler Me._txtI.Leave, value3
					RemoveHandler Me._txtI.KeyPress, value4
					RemoveHandler Me._txtI.KeyDown, value5
					RemoveHandler Me._txtI.TextChanged, value6
				End If
				Me._txtI = value
				If Me._txtI IsNot Nothing Then
					AddHandler Me._txtI.Enter, value2
					AddHandler Me._txtI.Leave, value3
					AddHandler Me._txtI.KeyPress, value4
					AddHandler Me._txtI.KeyDown, value5
					AddHandler Me._txtI.TextChanged, value6
				End If
			End Set
		End Property

		Public Overridable Property txtC As TextBox
			Get
				Return Me._txtC
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtC_Enter
				Dim value3 As EventHandler = AddressOf Me.txtC_Leave
				Dim value4 As KeyPressEventHandler = AddressOf Me.txtC_KeyPress
				Dim value5 As KeyEventHandler = AddressOf Me.txtC_KeyDown
				Dim value6 As EventHandler = AddressOf Me.txtC_TextChanged
				If Me._txtC IsNot Nothing Then
					RemoveHandler Me._txtC.Enter, value2
					RemoveHandler Me._txtC.Leave, value3
					RemoveHandler Me._txtC.KeyPress, value4
					RemoveHandler Me._txtC.KeyDown, value5
					RemoveHandler Me._txtC.TextChanged, value6
				End If
				Me._txtC = value
				If Me._txtC IsNot Nothing Then
					AddHandler Me._txtC.Enter, value2
					AddHandler Me._txtC.Leave, value3
					AddHandler Me._txtC.KeyPress, value4
					AddHandler Me._txtC.KeyDown, value5
					AddHandler Me._txtC.TextChanged, value6
				End If
			End Set
		End Property

		Public Overridable Property txtA As TextBox
			Get
				Return Me._txtA
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtA_Enter
				Dim value3 As EventHandler = AddressOf Me.txtA_Leave
				Dim value4 As KeyPressEventHandler = AddressOf Me.txtA_KeyPress
				Dim value5 As KeyEventHandler = AddressOf Me.txtA_KeyDown
				Dim value6 As EventHandler = AddressOf Me.txtA_TextChanged
				If Me._txtA IsNot Nothing Then
					RemoveHandler Me._txtA.Enter, value2
					RemoveHandler Me._txtA.Leave, value3
					RemoveHandler Me._txtA.KeyPress, value4
					RemoveHandler Me._txtA.KeyDown, value5
					RemoveHandler Me._txtA.TextChanged, value6
				End If
				Me._txtA = value
				If Me._txtA IsNot Nothing Then
					AddHandler Me._txtA.Enter, value2
					AddHandler Me._txtA.Leave, value3
					AddHandler Me._txtA.KeyPress, value4
					AddHandler Me._txtA.KeyDown, value5
					AddHandler Me._txtA.TextChanged, value6
				End If
			End Set
		End Property

		Public Overridable Property _Label_18 As Label
			Get
				Return Me.__Label_18
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_18 = value
			End Set
		End Property

		Public Overridable Property _Label_19 As Label
			Get
				Return Me.__Label_19
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_19 = value
			End Set
		End Property

		Public Overridable Property _Label_20 As Label
			Get
				Return Me.__Label_20
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_20 = value
			End Set
		End Property

		Public Overridable Property _Label_21 As Label
			Get
				Return Me.__Label_21
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_21 = value
			End Set
		End Property

		Public Overridable Property _Label_22 As Label
			Get
				Return Me.__Label_22
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_22 = value
			End Set
		End Property

		Public Overridable Property _panDimensions_2 As Panel
			Get
				Return Me.__panDimensions_2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me.__panDimensions_2 = value
			End Set
		End Property

		Public Overridable Property txtGearboxRating As TextBox
			Get
				Return Me._txtGearboxRating
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtGearboxRating_Enter
				Dim value3 As EventHandler = AddressOf Me.txtGearboxRating_Leave
				Dim value4 As KeyPressEventHandler = AddressOf Me.txtGearboxRating_KeyPress
				Dim value5 As KeyEventHandler = AddressOf Me.txtGearboxRating_KeyDown
				Dim value6 As EventHandler = AddressOf Me.txtGearboxRating_TextChanged
				If Me._txtGearboxRating IsNot Nothing Then
					RemoveHandler Me._txtGearboxRating.Enter, value2
					RemoveHandler Me._txtGearboxRating.Leave, value3
					RemoveHandler Me._txtGearboxRating.KeyPress, value4
					RemoveHandler Me._txtGearboxRating.KeyDown, value5
					RemoveHandler Me._txtGearboxRating.TextChanged, value6
				End If
				Me._txtGearboxRating = value
				If Me._txtGearboxRating IsNot Nothing Then
					AddHandler Me._txtGearboxRating.Enter, value2
					AddHandler Me._txtGearboxRating.Leave, value3
					AddHandler Me._txtGearboxRating.KeyPress, value4
					AddHandler Me._txtGearboxRating.KeyDown, value5
					AddHandler Me._txtGearboxRating.TextChanged, value6
				End If
			End Set
		End Property

		Public Overridable Property txtStructRating As TextBox
			Get
				Return Me._txtStructRating
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtStructRating_Enter
				Dim value3 As EventHandler = AddressOf Me.txtStructRating_Leave
				Dim value4 As KeyPressEventHandler = AddressOf Me.txtStructRating_KeyPress
				Dim value5 As KeyEventHandler = AddressOf Me.txtStructRating_KeyDown
				Dim value6 As EventHandler = AddressOf Me.txtStructRating_TextChanged
				If Me._txtStructRating IsNot Nothing Then
					RemoveHandler Me._txtStructRating.Enter, value2
					RemoveHandler Me._txtStructRating.Leave, value3
					RemoveHandler Me._txtStructRating.KeyPress, value4
					RemoveHandler Me._txtStructRating.KeyDown, value5
					RemoveHandler Me._txtStructRating.TextChanged, value6
				End If
				Me._txtStructRating = value
				If Me._txtStructRating IsNot Nothing Then
					AddHandler Me._txtStructRating.Enter, value2
					AddHandler Me._txtStructRating.Leave, value3
					AddHandler Me._txtStructRating.KeyPress, value4
					AddHandler Me._txtStructRating.KeyDown, value5
					AddHandler Me._txtStructRating.TextChanged, value6
				End If
			End Set
		End Property

		Public Overridable Property txtMaxStroke As TextBox
			Get
				Return Me._txtMaxStroke
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtMaxStroke_Enter
				Dim value3 As EventHandler = AddressOf Me.txtMaxStroke_Leave
				Dim value4 As KeyPressEventHandler = AddressOf Me.txtMaxStroke_KeyPress
				Dim value5 As KeyEventHandler = AddressOf Me.txtMaxStroke_KeyDown
				Dim value6 As EventHandler = AddressOf Me.txtMaxStroke_TextChanged
				If Me._txtMaxStroke IsNot Nothing Then
					RemoveHandler Me._txtMaxStroke.Enter, value2
					RemoveHandler Me._txtMaxStroke.Leave, value3
					RemoveHandler Me._txtMaxStroke.KeyPress, value4
					RemoveHandler Me._txtMaxStroke.KeyDown, value5
					RemoveHandler Me._txtMaxStroke.TextChanged, value6
				End If
				Me._txtMaxStroke = value
				If Me._txtMaxStroke IsNot Nothing Then
					AddHandler Me._txtMaxStroke.Enter, value2
					AddHandler Me._txtMaxStroke.Leave, value3
					AddHandler Me._txtMaxStroke.KeyPress, value4
					AddHandler Me._txtMaxStroke.KeyDown, value5
					AddHandler Me._txtMaxStroke.TextChanged, value6
				End If
			End Set
		End Property

		Public Overridable Property cboUnitType As ComboBox
			Get
				Return Me._cboUnitType
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim value2 As EventHandler = AddressOf Me.cboUnitType_Leave
				Dim value3 As EventHandler = AddressOf Me.cboUnitType_Enter
				Dim value4 As EventHandler = AddressOf Me.cboUnitType_DropDown
				Dim value5 As EventHandler = AddressOf Me.cboUnitType_SelectedIndexChanged
				If Me._cboUnitType IsNot Nothing Then
					RemoveHandler Me._cboUnitType.Leave, value2
					RemoveHandler Me._cboUnitType.Enter, value3
					RemoveHandler Me._cboUnitType.DropDown, value4
					RemoveHandler Me._cboUnitType.SelectedIndexChanged, value5
				End If
				Me._cboUnitType = value
				If Me._cboUnitType IsNot Nothing Then
					AddHandler Me._cboUnitType.Leave, value2
					AddHandler Me._cboUnitType.Enter, value3
					AddHandler Me._cboUnitType.DropDown, value4
					AddHandler Me._cboUnitType.SelectedIndexChanged, value5
				End If
			End Set
		End Property

		Public Overridable Property txtManufacturer As TextBox
			Get
				Return Me._txtManufacturer
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtManufacturer_Leave
				Dim value3 As EventHandler = AddressOf Me.txtManufacturer_Enter
				Dim value4 As KeyPressEventHandler = AddressOf Me.txtManufacturer_KeyPress
				Dim value5 As KeyEventHandler = AddressOf Me.txtManufacturer_KeyDown
				Dim value6 As EventHandler = AddressOf Me.txtManufacturer_TextChanged
				If Me._txtManufacturer IsNot Nothing Then
					RemoveHandler Me._txtManufacturer.Leave, value2
					RemoveHandler Me._txtManufacturer.Enter, value3
					RemoveHandler Me._txtManufacturer.KeyPress, value4
					RemoveHandler Me._txtManufacturer.KeyDown, value5
					RemoveHandler Me._txtManufacturer.TextChanged, value6
				End If
				Me._txtManufacturer = value
				If Me._txtManufacturer IsNot Nothing Then
					AddHandler Me._txtManufacturer.Leave, value2
					AddHandler Me._txtManufacturer.Enter, value3
					AddHandler Me._txtManufacturer.KeyPress, value4
					AddHandler Me._txtManufacturer.KeyDown, value5
					AddHandler Me._txtManufacturer.TextChanged, value6
				End If
			End Set
		End Property

		Public Overridable Property txtOtherInfo As TextBox
			Get
				Return Me._txtOtherInfo
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtOtherInfo_Enter
				Dim value3 As EventHandler = AddressOf Me.txtOtherInfo_Leave
				Dim value4 As KeyPressEventHandler = AddressOf Me.txtOtherInfo_KeyPress
				Dim value5 As KeyEventHandler = AddressOf Me.txtOtherInfo_KeyDown
				Dim value6 As EventHandler = AddressOf Me.txtOtherInfo_TextChanged
				If Me._txtOtherInfo IsNot Nothing Then
					RemoveHandler Me._txtOtherInfo.Enter, value2
					RemoveHandler Me._txtOtherInfo.Leave, value3
					RemoveHandler Me._txtOtherInfo.KeyPress, value4
					RemoveHandler Me._txtOtherInfo.KeyDown, value5
					RemoveHandler Me._txtOtherInfo.TextChanged, value6
				End If
				Me._txtOtherInfo = value
				If Me._txtOtherInfo IsNot Nothing Then
					AddHandler Me._txtOtherInfo.Enter, value2
					AddHandler Me._txtOtherInfo.Leave, value3
					AddHandler Me._txtOtherInfo.KeyPress, value4
					AddHandler Me._txtOtherInfo.KeyDown, value5
					AddHandler Me._txtOtherInfo.TextChanged, value6
				End If
			End Set
		End Property

		Public Overridable Property txtUnitName As TextBox
			Get
				Return Me._txtUnitName
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtUnitName_Leave
				Dim value3 As EventHandler = AddressOf Me.txtUnitName_Enter
				Dim value4 As KeyPressEventHandler = AddressOf Me.txtUnitName_KeyPress
				Dim value5 As KeyEventHandler = AddressOf Me.txtUnitName_KeyDown
				Dim value6 As EventHandler = AddressOf Me.txtUnitName_TextChanged
				If Me._txtUnitName IsNot Nothing Then
					RemoveHandler Me._txtUnitName.Leave, value2
					RemoveHandler Me._txtUnitName.Enter, value3
					RemoveHandler Me._txtUnitName.KeyPress, value4
					RemoveHandler Me._txtUnitName.KeyDown, value5
					RemoveHandler Me._txtUnitName.TextChanged, value6
				End If
				Me._txtUnitName = value
				If Me._txtUnitName IsNot Nothing Then
					AddHandler Me._txtUnitName.Leave, value2
					AddHandler Me._txtUnitName.Enter, value3
					AddHandler Me._txtUnitName.KeyPress, value4
					AddHandler Me._txtUnitName.KeyDown, value5
					AddHandler Me._txtUnitName.TextChanged, value6
				End If
			End Set
		End Property

		Public Overridable Property txtArtInertia As TextBox
			Get
				Return Me._txtArtInertia
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtArtInertia_EnabledChanged
				Dim value3 As EventHandler = AddressOf Me.txtArtInertia_Enter
				Dim value4 As EventHandler = AddressOf Me.txtArtInertia_Leave
				Dim value5 As KeyPressEventHandler = AddressOf Me.txtArtInertia_KeyPress
				Dim value6 As KeyEventHandler = AddressOf Me.txtArtInertia_KeyDown
				If Me._txtArtInertia IsNot Nothing Then
					RemoveHandler Me._txtArtInertia.EnabledChanged, value2
					RemoveHandler Me._txtArtInertia.Enter, value3
					RemoveHandler Me._txtArtInertia.Leave, value4
					RemoveHandler Me._txtArtInertia.KeyPress, value5
					RemoveHandler Me._txtArtInertia.KeyDown, value6
				End If
				Me._txtArtInertia = value
				If Me._txtArtInertia IsNot Nothing Then
					AddHandler Me._txtArtInertia.EnabledChanged, value2
					AddHandler Me._txtArtInertia.Enter, value3
					AddHandler Me._txtArtInertia.Leave, value4
					AddHandler Me._txtArtInertia.KeyPress, value5
					AddHandler Me._txtArtInertia.KeyDown, value6
				End If
			End Set
		End Property

		Public Overridable Property lblAPIDesignation As Label
			Get
				Return Me._lblAPIDesignation
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblAPIDesignation = value
			End Set
		End Property

		Public Overridable Property _Label_6 As Label
			Get
				Return Me.__Label_6
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_6 = value
			End Set
		End Property

		Public Overridable Property _Label_5 As Label
			Get
				Return Me.__Label_5
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_5 = value
			End Set
		End Property

		Public Overridable Property _Label_3 As Label
			Get
				Return Me.__Label_3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_3 = value
			End Set
		End Property

		Public Overridable Property _Label_0 As Label
			Get
				Return Me.__Label_0
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_0 = value
			End Set
		End Property

		Public Overridable Property _Label_2 As Label
			Get
				Return Me.__Label_2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_2 = value
			End Set
		End Property

		Public Overridable Property _Label_1 As Label
			Get
				Return Me.__Label_1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_1 = value
			End Set
		End Property

		Public Overridable Property _SSFrame_0 As GroupBox
			Get
				Return Me.__SSFrame_0
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me.__SSFrame_0 = value
			End Set
		End Property

		Public Overridable Property cmdLoad As Button
			Get
				Return Me._cmdLoad
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.cmdLoad_Click
				If Me._cmdLoad IsNot Nothing Then
					RemoveHandler Me._cmdLoad.Click, value2
				End If
				Me._cmdLoad = value
				If Me._cmdLoad IsNot Nothing Then
					AddHandler Me._cmdLoad.Click, value2
				End If
			End Set
		End Property

		Public Overridable Property Label As LabelArray
			Get
				Return Me._Label
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As LabelArray)
				Dim obj As EventHandler = AddressOf Me.Label_DoubleClick
				Dim obj2 As EventHandler = AddressOf Me.Label_Click
				If Me._Label IsNot Nothing Then
					RemoveHandler Me._Label.DoubleClick, obj
					RemoveHandler Me._Label.Click, obj2
				End If
				Me._Label = value
				If Me._Label IsNot Nothing Then
					AddHandler Me._Label.DoubleClick, obj
					AddHandler Me._Label.Click, obj2
				End If
			End Set
		End Property

		Public Overridable Property Line As LabelArray
			Get
				Return Me._Line
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As LabelArray)
				Me._Line = value
			End Set
		End Property

		Public Overridable Property SSFrame As GroupBoxArray
			Get
				Return Me._SSFrame
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBoxArray)
				Me._SSFrame = value
			End Set
		End Property

		Public Overridable Property panCalcStroke As LabelArray
			Get
				Return Me._panCalcStroke
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As LabelArray)
				Me._panCalcStroke = value
			End Set
		End Property

		Public Overridable Property panDimensions As PanelArray
			Get
				Return Me._panDimensions
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PanelArray)
				Me._panDimensions = value
			End Set
		End Property

		Public Overridable Property txtR As TextBoxArray
			Get
				Return Me._txtR
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBoxArray)
				Me._txtR = value
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

		Public Overridable Property txtA_ABAL As TextBox
			Get
				Return Me._txtA_ABAL
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtA_ABAL_Enter
				Dim value3 As EventHandler = AddressOf Me.txtA_ABAL_Leave
				Dim value4 As KeyPressEventHandler = AddressOf Me.txtA_ABAL_KeyPress
				Dim value5 As KeyEventHandler = AddressOf Me.txtA_ABAL_KeyDown
				Dim value6 As EventHandler = AddressOf Me.txtA_ABAL_TextChanged
				If Me._txtA_ABAL IsNot Nothing Then
					RemoveHandler Me._txtA_ABAL.Enter, value2
					RemoveHandler Me._txtA_ABAL.Leave, value3
					RemoveHandler Me._txtA_ABAL.KeyPress, value4
					RemoveHandler Me._txtA_ABAL.KeyDown, value5
					RemoveHandler Me._txtA_ABAL.TextChanged, value6
				End If
				Me._txtA_ABAL = value
				If Me._txtA_ABAL IsNot Nothing Then
					AddHandler Me._txtA_ABAL.Enter, value2
					AddHandler Me._txtA_ABAL.Leave, value3
					AddHandler Me._txtA_ABAL.KeyPress, value4
					AddHandler Me._txtA_ABAL.KeyDown, value5
					AddHandler Me._txtA_ABAL.TextChanged, value6
				End If
			End Set
		End Property

		Public Overridable Property _panDimensions_2_ABAL As Panel
			Get
				Return Me.__panDimensions_2_ABAL
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me.__panDimensions_2_ABAL = value
			End Set
		End Property

		Public Overridable Property txtP_ABAL As TextBox
			Get
				Return Me._txtP_ABAL
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtP_ABAL_Enter
				Dim value3 As EventHandler = AddressOf Me.txtP_ABAL_Leave
				Dim value4 As KeyPressEventHandler = AddressOf Me.txtP_ABAL_KeyPress
				Dim value5 As KeyEventHandler = AddressOf Me.txtP_ABAL_KeyDown
				Dim value6 As EventHandler = AddressOf Me.txtP_ABAL_TextChanged
				If Me._txtP_ABAL IsNot Nothing Then
					RemoveHandler Me._txtP_ABAL.Enter, value2
					RemoveHandler Me._txtP_ABAL.Leave, value3
					RemoveHandler Me._txtP_ABAL.KeyPress, value4
					RemoveHandler Me._txtP_ABAL.KeyDown, value5
					RemoveHandler Me._txtP_ABAL.TextChanged, value6
				End If
				Me._txtP_ABAL = value
				If Me._txtP_ABAL IsNot Nothing Then
					AddHandler Me._txtP_ABAL.Enter, value2
					AddHandler Me._txtP_ABAL.Leave, value3
					AddHandler Me._txtP_ABAL.KeyPress, value4
					AddHandler Me._txtP_ABAL.KeyDown, value5
					AddHandler Me._txtP_ABAL.TextChanged, value6
				End If
			End Set
		End Property

		Public Overridable Property txtK_ABAL As TextBox
			Get
				Return Me._txtK_ABAL
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtK_ABAL_Enter
				Dim value3 As EventHandler = AddressOf Me.txtK_ABAL_Leave
				Dim value4 As KeyPressEventHandler = AddressOf Me.txtK_ABAL_KeyPress
				Dim value5 As KeyEventHandler = AddressOf Me.txtK_ABAL_KeyDown
				Dim value6 As EventHandler = AddressOf Me.txtK_ABAL_TextChanged
				If Me._txtK_ABAL IsNot Nothing Then
					RemoveHandler Me._txtK_ABAL.Enter, value2
					RemoveHandler Me._txtK_ABAL.Leave, value3
					RemoveHandler Me._txtK_ABAL.KeyPress, value4
					RemoveHandler Me._txtK_ABAL.KeyDown, value5
					RemoveHandler Me._txtK_ABAL.TextChanged, value6
				End If
				Me._txtK_ABAL = value
				If Me._txtK_ABAL IsNot Nothing Then
					AddHandler Me._txtK_ABAL.Enter, value2
					AddHandler Me._txtK_ABAL.Leave, value3
					AddHandler Me._txtK_ABAL.KeyPress, value4
					AddHandler Me._txtK_ABAL.KeyDown, value5
					AddHandler Me._txtK_ABAL.TextChanged, value6
				End If
			End Set
		End Property

		Public Overridable Property txtI_ABAL As TextBox
			Get
				Return Me._txtI_ABAL
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtI_ABAL_Enter
				Dim value3 As EventHandler = AddressOf Me.txtI_ABAL_Leave
				Dim value4 As KeyPressEventHandler = AddressOf Me.txtI_ABAL_KeyPress
				Dim value5 As KeyEventHandler = AddressOf Me.txtI_ABAL_KeyDown
				Dim value6 As EventHandler = AddressOf Me.txtI_ABAL_TextChanged
				If Me._txtI_ABAL IsNot Nothing Then
					RemoveHandler Me._txtI_ABAL.Enter, value2
					RemoveHandler Me._txtI_ABAL.Leave, value3
					RemoveHandler Me._txtI_ABAL.KeyPress, value4
					RemoveHandler Me._txtI_ABAL.KeyDown, value5
					RemoveHandler Me._txtI_ABAL.TextChanged, value6
				End If
				Me._txtI_ABAL = value
				If Me._txtI_ABAL IsNot Nothing Then
					AddHandler Me._txtI_ABAL.Enter, value2
					AddHandler Me._txtI_ABAL.Leave, value3
					AddHandler Me._txtI_ABAL.KeyPress, value4
					AddHandler Me._txtI_ABAL.KeyDown, value5
					AddHandler Me._txtI_ABAL.TextChanged, value6
				End If
			End Set
		End Property

		Public Overridable Property txtC_ABAL As TextBox
			Get
				Return Me._txtC_ABAL
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtC_ABAL_Enter
				Dim value3 As EventHandler = AddressOf Me.txtC_ABAL_Leave
				Dim value4 As KeyPressEventHandler = AddressOf Me.txtC_ABAL_KeyPress
				Dim value5 As KeyEventHandler = AddressOf Me.txtC_ABAL_KeyDown
				Dim value6 As EventHandler = AddressOf Me.txtC_ABAL_TextChanged
				If Me._txtC_ABAL IsNot Nothing Then
					RemoveHandler Me._txtC_ABAL.Enter, value2
					RemoveHandler Me._txtC_ABAL.Leave, value3
					RemoveHandler Me._txtC_ABAL.KeyPress, value4
					RemoveHandler Me._txtC_ABAL.KeyDown, value5
					RemoveHandler Me._txtC_ABAL.TextChanged, value6
				End If
				Me._txtC_ABAL = value
				If Me._txtC_ABAL IsNot Nothing Then
					AddHandler Me._txtC_ABAL.Enter, value2
					AddHandler Me._txtC_ABAL.Leave, value3
					AddHandler Me._txtC_ABAL.KeyPress, value4
					AddHandler Me._txtC_ABAL.KeyDown, value5
					AddHandler Me._txtC_ABAL.TextChanged, value6
				End If
			End Set
		End Property

		Public Overridable Property Label_A_ABAL As Label
			Get
				Return Me._Label_A_ABAL
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label_A_ABAL = value
			End Set
		End Property

		Public Overridable Property Label_C_ABAL As Label
			Get
				Return Me._Label_C_ABAL
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label_C_ABAL = value
			End Set
		End Property

		Public Overridable Property Label_I_ABAL As Label
			Get
				Return Me._Label_I_ABAL
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label_I_ABAL = value
			End Set
		End Property

		Public Overridable Property Label_K_ABAL As Label
			Get
				Return Me._Label_K_ABAL
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label_K_ABAL = value
			End Set
		End Property

		Public Overridable Property Label_P_ABAL As Label
			Get
				Return Me._Label_P_ABAL
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label_P_ABAL = value
			End Set
		End Property

		Public Overridable Property _panDimensions_2_MII As Panel
			Get
				Return Me.__panDimensions_2_MII
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me.__panDimensions_2_MII = value
			End Set
		End Property

		Public Overridable Property txtP_MII As TextBox
			Get
				Return Me._txtP_MII
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtP_MII_Enter
				Dim value3 As EventHandler = AddressOf Me.txtP_MII_Leave
				Dim value4 As KeyPressEventHandler = AddressOf Me.txtP_MII_KeyPress
				Dim value5 As KeyEventHandler = AddressOf Me.txtP_MII_KeyDown
				Dim value6 As EventHandler = AddressOf Me.txtP_MII_TextChanged
				If Me._txtP_MII IsNot Nothing Then
					RemoveHandler Me._txtP_MII.Enter, value2
					RemoveHandler Me._txtP_MII.Leave, value3
					RemoveHandler Me._txtP_MII.KeyPress, value4
					RemoveHandler Me._txtP_MII.KeyDown, value5
					RemoveHandler Me._txtP_MII.TextChanged, value6
				End If
				Me._txtP_MII = value
				If Me._txtP_MII IsNot Nothing Then
					AddHandler Me._txtP_MII.Enter, value2
					AddHandler Me._txtP_MII.Leave, value3
					AddHandler Me._txtP_MII.KeyPress, value4
					AddHandler Me._txtP_MII.KeyDown, value5
					AddHandler Me._txtP_MII.TextChanged, value6
				End If
			End Set
		End Property

		Public Overridable Property txtK_MII As TextBox
			Get
				Return Me._txtK_MII
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtK_MII_Enter
				Dim value3 As EventHandler = AddressOf Me.txtK_MII_Leave
				Dim value4 As KeyPressEventHandler = AddressOf Me.txtK_MII_KeyPress
				Dim value5 As KeyEventHandler = AddressOf Me.txtK_MII_KeyDown
				Dim value6 As EventHandler = AddressOf Me.txtK_MII_TextChanged
				If Me._txtK_MII IsNot Nothing Then
					RemoveHandler Me._txtK_MII.Enter, value2
					RemoveHandler Me._txtK_MII.Leave, value3
					RemoveHandler Me._txtK_MII.KeyPress, value4
					RemoveHandler Me._txtK_MII.KeyDown, value5
					RemoveHandler Me._txtK_MII.TextChanged, value6
				End If
				Me._txtK_MII = value
				If Me._txtK_MII IsNot Nothing Then
					AddHandler Me._txtK_MII.Enter, value2
					AddHandler Me._txtK_MII.Leave, value3
					AddHandler Me._txtK_MII.KeyPress, value4
					AddHandler Me._txtK_MII.KeyDown, value5
					AddHandler Me._txtK_MII.TextChanged, value6
				End If
			End Set
		End Property

		Public Overridable Property txtI_MII As TextBox
			Get
				Return Me._txtI_MII
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtI_MII_Enter
				Dim value3 As EventHandler = AddressOf Me.txtI_MII_Leave
				Dim value4 As KeyPressEventHandler = AddressOf Me.txtI_MII_KeyPress
				Dim value5 As KeyEventHandler = AddressOf Me.txtI_MII_KeyDown
				Dim value6 As EventHandler = AddressOf Me.txtI_MII_TextChanged
				If Me._txtI_MII IsNot Nothing Then
					RemoveHandler Me._txtI_MII.Enter, value2
					RemoveHandler Me._txtI_MII.Leave, value3
					RemoveHandler Me._txtI_MII.KeyPress, value4
					RemoveHandler Me._txtI_MII.KeyDown, value5
					RemoveHandler Me._txtI_MII.TextChanged, value6
				End If
				Me._txtI_MII = value
				If Me._txtI_MII IsNot Nothing Then
					AddHandler Me._txtI_MII.Enter, value2
					AddHandler Me._txtI_MII.Leave, value3
					AddHandler Me._txtI_MII.KeyPress, value4
					AddHandler Me._txtI_MII.KeyDown, value5
					AddHandler Me._txtI_MII.TextChanged, value6
				End If
			End Set
		End Property

		Public Overridable Property txtC_MII As TextBox
			Get
				Return Me._txtC_MII
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtC_MII_Enter
				Dim value3 As EventHandler = AddressOf Me.txtC_MII_Leave
				Dim value4 As KeyPressEventHandler = AddressOf Me.txtC_MII_KeyPress
				Dim value5 As KeyEventHandler = AddressOf Me.txtC_MII_KeyDown
				Dim value6 As EventHandler = AddressOf Me.txtC_MII_TextChanged
				If Me._txtC_MII IsNot Nothing Then
					RemoveHandler Me._txtC_MII.Enter, value2
					RemoveHandler Me._txtC_MII.Leave, value3
					RemoveHandler Me._txtC_MII.KeyPress, value4
					RemoveHandler Me._txtC_MII.KeyDown, value5
					RemoveHandler Me._txtC_MII.TextChanged, value6
				End If
				Me._txtC_MII = value
				If Me._txtC_MII IsNot Nothing Then
					AddHandler Me._txtC_MII.Enter, value2
					AddHandler Me._txtC_MII.Leave, value3
					AddHandler Me._txtC_MII.KeyPress, value4
					AddHandler Me._txtC_MII.KeyDown, value5
					AddHandler Me._txtC_MII.TextChanged, value6
				End If
			End Set
		End Property

		Public Overridable Property txtA_MII As TextBox
			Get
				Return Me._txtA_MII
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtA_MII_Enter
				Dim value3 As EventHandler = AddressOf Me.txtA_MII_Leave
				Dim value4 As KeyPressEventHandler = AddressOf Me.txtA_MII_KeyPress
				Dim value5 As KeyEventHandler = AddressOf Me.txtA_MII_KeyDown
				Dim value6 As EventHandler = AddressOf Me.txtA_MII_TextChanged
				If Me._txtA_MII IsNot Nothing Then
					RemoveHandler Me._txtA_MII.Enter, value2
					RemoveHandler Me._txtA_MII.Leave, value3
					RemoveHandler Me._txtA_MII.KeyPress, value4
					RemoveHandler Me._txtA_MII.KeyDown, value5
					RemoveHandler Me._txtA_MII.TextChanged, value6
				End If
				Me._txtA_MII = value
				If Me._txtA_MII IsNot Nothing Then
					AddHandler Me._txtA_MII.Enter, value2
					AddHandler Me._txtA_MII.Leave, value3
					AddHandler Me._txtA_MII.KeyPress, value4
					AddHandler Me._txtA_MII.KeyDown, value5
					AddHandler Me._txtA_MII.TextChanged, value6
				End If
			End Set
		End Property

		Public Overridable Property Label_A_MII As Label
			Get
				Return Me._Label_A_MII
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label_A_MII = value
			End Set
		End Property

		Public Overridable Property Label_C_MII As Label
			Get
				Return Me._Label_C_MII
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label_C_MII = value
			End Set
		End Property

		Public Overridable Property Label_I_MII As Label
			Get
				Return Me._Label_I_MII
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label_I_MII = value
			End Set
		End Property

		Public Overridable Property Label_K_MII As Label
			Get
				Return Me._Label_K_MII
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label_K_MII = value
			End Set
		End Property

		Public Overridable Property Label_P_MII As Label
			Get
				Return Me._Label_P_MII
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label_P_MII = value
			End Set
		End Property

		Public Overridable Property _txtR_2_disabled As Label
			Get
				Return Me.__txtR_2_disabled
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__txtR_2_disabled = value
			End Set
		End Property

		Public Overridable Property _txtR_1_disabled As Label
			Get
				Return Me.__txtR_1_disabled
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__txtR_1_disabled = value
			End Set
		End Property

		Public Overridable Property _txtR_4_disabled As Label
			Get
				Return Me.__txtR_4_disabled
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__txtR_4_disabled = value
			End Set
		End Property

		Public Overridable Property _txtR_3_disabled As Label
			Get
				Return Me.__txtR_3_disabled
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__txtR_3_disabled = value
			End Set
		End Property

		Public Overridable Property _txtR_5_disabled As Label
			Get
				Return Me.__txtR_5_disabled
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__txtR_5_disabled = value
			End Set
		End Property

		Public Overridable Property lblArtInertia_Disabled As Label
			Get
				Return Me._lblArtInertia_Disabled
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblArtInertia_Disabled = value
			End Set
		End Property

		Friend Overridable Property lblCrankCBMoment As Label
			Get
				Return Me._lblCrankCBMoment
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblCrankCBMoment = value
			End Set
		End Property

		Friend Overridable Property txtCrankCBMoment As TextBox
			Get
				Return Me._txtCrankCBMoment
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtCrankCBMoment_Enter
				Dim value3 As EventHandler = AddressOf Me.txtCrankCBMoment_Leave
				Dim value4 As EventHandler = AddressOf Me.txtCrankCBMoment_TextChanged
				If Me._txtCrankCBMoment IsNot Nothing Then
					RemoveHandler Me._txtCrankCBMoment.Enter, value2
					RemoveHandler Me._txtCrankCBMoment.Leave, value3
					RemoveHandler Me._txtCrankCBMoment.TextChanged, value4
				End If
				Me._txtCrankCBMoment = value
				If Me._txtCrankCBMoment IsNot Nothing Then
					AddHandler Me._txtCrankCBMoment.Enter, value2
					AddHandler Me._txtCrankCBMoment.Leave, value3
					AddHandler Me._txtCrankCBMoment.TextChanged, value4
				End If
			End Set
		End Property

		Public Overridable Property cboRequiredRotation As ComboBox
			Get
				Return Me._cboRequiredRotation
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim value2 As EventHandler = AddressOf Me.cboRequiredRotation_SelectedIndexChanged
				If Me._cboRequiredRotation IsNot Nothing Then
					RemoveHandler Me._cboRequiredRotation.SelectedIndexChanged, value2
				End If
				Me._cboRequiredRotation = value
				If Me._cboRequiredRotation IsNot Nothing Then
					AddHandler Me._cboRequiredRotation.SelectedIndexChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property _panLowProfileBelt1 As Panel
			Get
				Return Me.__panLowProfileBelt1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me.__panLowProfileBelt1 = value
			End Set
		End Property

		Public Overridable Property txtD_lp As TextBox
			Get
				Return Me._txtD_lp
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtD_lp_Enter
				Dim value3 As EventHandler = AddressOf Me.txtD_lp_Leave
				Dim value4 As KeyPressEventHandler = AddressOf Me.txtD_lp_KeyPress
				Dim value5 As EventHandler = AddressOf Me.txtD_lp_TextChanged
				If Me._txtD_lp IsNot Nothing Then
					RemoveHandler Me._txtD_lp.Enter, value2
					RemoveHandler Me._txtD_lp.Leave, value3
					RemoveHandler Me._txtD_lp.KeyPress, value4
					RemoveHandler Me._txtD_lp.TextChanged, value5
				End If
				Me._txtD_lp = value
				If Me._txtD_lp IsNot Nothing Then
					AddHandler Me._txtD_lp.Enter, value2
					AddHandler Me._txtD_lp.Leave, value3
					AddHandler Me._txtD_lp.KeyPress, value4
					AddHandler Me._txtD_lp.TextChanged, value5
				End If
			End Set
		End Property

		Public Overridable Property txtB_lp As TextBox
			Get
				Return Me._txtB_lp
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._txtB_lp = value
			End Set
		End Property

		Public Overridable Property lblB As Label
			Get
				Return Me._lblB
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblB = value
			End Set
		End Property

		Public Overridable Property lblD As Label
			Get
				Return Me._lblD
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblD = value
			End Set
		End Property

		Public Overridable Property lblI As Label
			Get
				Return Me._lblI
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblI = value
			End Set
		End Property

		Public Overridable Property txtI_lp As TextBox
			Get
				Return Me._txtI_lp
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtI_lp_Leave
				Dim value3 As EventHandler = AddressOf Me.txtI_lp_Enter
				Dim value4 As EventHandler = AddressOf Me.txtI_lp_TextChanged
				If Me._txtI_lp IsNot Nothing Then
					RemoveHandler Me._txtI_lp.Leave, value2
					RemoveHandler Me._txtI_lp.Enter, value3
					RemoveHandler Me._txtI_lp.TextChanged, value4
				End If
				Me._txtI_lp = value
				If Me._txtI_lp IsNot Nothing Then
					AddHandler Me._txtI_lp.Leave, value2
					AddHandler Me._txtI_lp.Enter, value3
					AddHandler Me._txtI_lp.TextChanged, value4
				End If
			End Set
		End Property

		Public Overridable Property lblK As Label
			Get
				Return Me._lblK
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblK = value
			End Set
		End Property

		Public Overridable Property txtK_LP As TextBox
			Get
				Return Me._txtK_LP
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtK_LP_Leave
				Dim value3 As EventHandler = AddressOf Me.txtK_LP_Enter
				Dim value4 As EventHandler = AddressOf Me.txtK_lp_TextChanged
				If Me._txtK_LP IsNot Nothing Then
					RemoveHandler Me._txtK_LP.Leave, value2
					RemoveHandler Me._txtK_LP.Enter, value3
					RemoveHandler Me._txtK_LP.TextChanged, value4
				End If
				Me._txtK_LP = value
				If Me._txtK_LP IsNot Nothing Then
					AddHandler Me._txtK_LP.Leave, value2
					AddHandler Me._txtK_LP.Enter, value3
					AddHandler Me._txtK_LP.TextChanged, value4
				End If
			End Set
		End Property

		Public Overridable Property _panLowProfileBelt2 As Panel
			Get
				Return Me.__panLowProfileBelt2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me.__panLowProfileBelt2 = value
			End Set
		End Property

		Public Overridable Property txtTheta As TextBox
			Get
				Return Me._txtTheta
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.txtTheta_Leave
				Dim value3 As EventHandler = AddressOf Me.txtTheta_Enter
				If Me._txtTheta IsNot Nothing Then
					RemoveHandler Me._txtTheta.Leave, value2
					RemoveHandler Me._txtTheta.Enter, value3
				End If
				Me._txtTheta = value
				If Me._txtTheta IsNot Nothing Then
					AddHandler Me._txtTheta.Leave, value2
					AddHandler Me._txtTheta.Enter, value3
				End If
			End Set
		End Property

		Public Overridable Property lblTheta As Label
			Get
				Return Me._lblTheta
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblTheta = value
			End Set
		End Property

		Public Overridable Property _panDimensions_longstroke As Panel
			Get
				Return Me.__panDimensions_longstroke
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me.__panDimensions_longstroke = value
			End Set
		End Property

		Public Overridable Property _Label_GearboxRating As Label
			Get
				Return Me.__Label_GearboxRating
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Dim value2 As EventHandler = AddressOf Me._Label_GearboxRating_TextChanged
				If Me.__Label_GearboxRating IsNot Nothing Then
					RemoveHandler Me.__Label_GearboxRating.TextChanged, value2
				End If
				Me.__Label_GearboxRating = value
				If Me.__Label_GearboxRating IsNot Nothing Then
					AddHandler Me.__Label_GearboxRating.TextChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property lblArtInertia As Label
			Get
				Return Me._lblArtInertia
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Dim value2 As EventHandler = AddressOf Me.lblArtInertia_TextChanged
				If Me._lblArtInertia IsNot Nothing Then
					RemoveHandler Me._lblArtInertia.TextChanged, value2
				End If
				Me._lblArtInertia = value
				If Me._lblArtInertia IsNot Nothing Then
					AddHandler Me._lblArtInertia.TextChanged, value2
				End If
			End Set
		End Property

		Public Overridable Property _SSFrame_UnitDimensions As GroupBox
			Get
				Return Me.__SSFrame_UnitDimensions
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me.__SSFrame_UnitDimensions = value
			End Set
		End Property

		Public Overridable Property _Label_API_designation As Label
			Get
				Return Me.__Label_API_designation
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me.__Label_API_designation = value
			End Set
		End Property

		Public Overridable Property lblRequiredRotation As Label
			Get
				Return Me._lblRequiredRotation
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._lblRequiredRotation = value
			End Set
		End Property

		Public Shared Property DefInstance As dlgCustomPU
			Get
				If dlgCustomPU.m_vb6FormDefInstance Is Nothing OrElse dlgCustomPU.m_vb6FormDefInstance.IsDisposed Then
					dlgCustomPU.m_InitializingDefInstance = True
					dlgCustomPU.m_vb6FormDefInstance = New dlgCustomPU()
					dlgCustomPU.m_InitializingDefInstance = False
				End If
				Return dlgCustomPU.m_vb6FormDefInstance
			End Get
			Set(value As dlgCustomPU)
				dlgCustomPU.m_vb6FormDefInstance = value
			End Set
		End Property

		Public Property lvwCustomPU As ListView
			Get
				Return Me.m_lvwCustomPU
			End Get
			Set(value As ListView)
				Me.m_lvwCustomPU = value
			End Set
		End Property

		Private Function CheckCustomPU() As Boolean
			Dim lvwCustomPU As ListView = Me.m_lvwCustomPU
			Dim result As Boolean = False
			Dim num As Short = CShort((Me.cboUnitType.SelectedIndex + 1))
			Dim text As String = "enter"
			Dim text2 As String = RSWIN_DESC.sNull
			If Strings.Len(Strings.Trim(Me.txtManufacturer.Text)) = 0 Then
				text2 = "pumping unit manufacturer"
				Me.txtUnitName.Focus()
			ElseIf num <= 0S Then
				text = "select"
				text2 = "pumping unit type"
				Me.cboUnitType.Focus()
			ElseIf Strings.Len(Strings.Trim(Me.txtGearboxRating.Text)) = 0 And num <> 10S Then
				text2 = "gearbox rating"
				Me.txtGearboxRating.Focus()
			ElseIf Strings.Len(Strings.Trim(Me.txtStructRating.Text)) = 0 Then
				text2 = "structural rating"
				Me.txtStructRating.Focus()
			ElseIf Strings.Len(Strings.Trim(Me.txtMaxStroke.Text)) = 0 Then
				text2 = "maximum stroke length"
				Me.txtMaxStroke.Focus()
			ElseIf num = 6S And Strings.Len(Strings.Trim(Me.txtA_ABAL.Text)) = 0 Then
				text2 = "A dimension"
				Me.txtA_ABAL.Focus()
			ElseIf num = 6S And Strings.Len(Strings.Trim(Me.txtC_ABAL.Text)) = 0 Then
				text2 = "C dimension"
				Me.txtC_ABAL.Focus()
			ElseIf num = 6S And Strings.Len(Strings.Trim(Me.txtI_ABAL.Text)) = 0 Then
				text2 = "I dimension"
				Me.txtI_ABAL.Focus()
			ElseIf num = 6S And Strings.Len(Strings.Trim(Me.txtK_ABAL.Text)) = 0 Then
				text2 = "K dimension"
				Me.txtK_ABAL.Focus()
			ElseIf num = 6S And Strings.Len(Strings.Trim(Me.txtP_ABAL.Text)) = 0 Then
				text2 = "P dimension"
				Me.txtP_ABAL.Focus()
			ElseIf num = 5S And Strings.Len(Strings.Trim(Me.txtA_MII.Text)) = 0 Then
				text2 = "A dimension"
				Me.txtA_MII.Focus()
			ElseIf num = 5S And Strings.Len(Strings.Trim(Me.txtC_MII.Text)) = 0 Then
				text2 = "C dimension"
				Me.txtC_MII.Focus()
			ElseIf num = 5S And Strings.Len(Strings.Trim(Me.txtI_MII.Text)) = 0 Then
				text2 = "I dimension"
				Me.txtI_MII.Focus()
			ElseIf num = 5S And Strings.Len(Strings.Trim(Me.txtK_MII.Text)) = 0 Then
				text2 = "K dimension"
				Me.txtK_MII.Focus()
			ElseIf num = 5S And Strings.Len(Strings.Trim(Me.txtP_MII.Text)) = 0 Then
				text2 = "P dimension"
				Me.txtP_MII.Focus()
			ElseIf num <> 7S And num <> 10S And num <> 5S And num <> 6S And num <> 9S And Strings.Len(Strings.Trim(Me.txtA.Text)) = 0 Then
				text2 = "A dimension"
				Me.txtA.Focus()
			ElseIf num <> 7S And num <> 10S And num <> 5S And num <> 6S And num <> 9S And Strings.Len(Strings.Trim(Me.txtC.Text)) = 0 Then
				text2 = "C dimension"
				Me.txtC.Focus()
			ElseIf num <> 7S And num <> 10S And num <> 5S And num <> 6S And num <> 9S And Strings.Len(Strings.Trim(Me.txtI.Text)) = 0 Then
				text2 = "I dimension"
				Me.txtI.Focus()
			ElseIf num <> 7S And num <> 10S And num <> 5S And num <> 6S And num <> 9S And Strings.Len(Strings.Trim(Me.txtK.Text)) = 0 Then
				text2 = "K dimension"
				Me.txtK.Focus()
			ElseIf num <> 7S And num <> 10S And num <> 5S And num <> 6S And num <> 9S And Strings.Len(Strings.Trim(Me.txtP.Text)) = 0 Then
				text2 = "P dimension"
				Me.txtP.Focus()
			ElseIf num <> 6S And num <> 7S And num <> 10S And num <> 9S And Strings.Len(Strings.Trim(Me.txtUnbalance.Text)) = 0 Then
				text2 = "structural unbalance"
				Me.txtUnbalance.Focus()
			ElseIf num <> 6S And num <> 7S And num <> 10S And num <> 9S And Strings.Len(Strings.Trim(Me.txtCrankOffset.Text)) = 0 Then
				text2 = "crank offset angle"
				Me.txtCrankOffset.Focus()
			ElseIf num = 6S And Strings.Len(Strings.Trim(Me.txtM.Text)) = 0 Then
				text2 = "M dimension"
				Me.txtM.Focus()
			ElseIf num = 6S And Strings.Len(Strings.Trim(Me.txtS.Text)) = 0 Then
				text2 = "S dimension"
				Me.txtS.Focus()
			ElseIf num = 6S And Strings.Len(Strings.Trim(Me.txtV0.Text)) = 0 Then
				text2 = "V0 dimension"
				Me.txtV0.Focus()
			ElseIf num = 7S And Strings.Len(Strings.Trim(Me.txtSprocketDiameter.Text)) = 0 Then
				text2 = "sprocket diameter"
				Me.txtSprocketDiameter.Focus()
			ElseIf num = 7S And Strings.Len(Strings.Trim(Me.txtSprocketDistance.Text)) = 0 Then
				text2 = "centerline distance between the sprockets"
				Me.txtSprocketDistance.Focus()
			ElseIf num = 7S And Strings.Len(Strings.Trim(Me.txtDrumDiamRatio.Text)) = 0 Then
				text2 = "top drum diameter ratio"
				Me.txtDrumDiamRatio.Focus()
			ElseIf num = 9S And Strings.Len(Strings.Trim(Me.txtD_lp.Text)) = 0 Then
				text2 = "D dimension"
				Me.txtD_lp.Focus()
			ElseIf num = 9S And Strings.Len(Strings.Trim(Me.txtI_lp.Text)) = 0 Then
				text2 = "I dimension"
				Me.txtI_lp.Focus()
			ElseIf num = 9S And Strings.Len(Strings.Trim(Me.txtK_LP.Text)) = 0 Then
				text2 = "K dimension"
				Me.txtK_LP.Focus()
			ElseIf num = 9S And Strings.Len(Strings.Trim(Me.txtTheta.Text)) = 0 Then
				text2 = "Theta"
				Me.txtTheta.Focus()
			ElseIf num = 8S And Strings.Len(Strings.Trim(Me.txtCrankCBMoment.Text)) = 0 Then
				text2 = "Crank CB Moment"
				Me.txtCrankCBMoment.Focus()
			End If
			If Strings.Len(text2) > 0 Then
				Dim sMsg As String = String.Concat(New String() { "Please ", text, " the ", text2, "." })
				Dim sMsgType As String = "Data Entry Error"
				Dim bClosing As Boolean = False
				Dim dialogResult As DialogResult = DialogResult.OK
				Util.SendMessage(sMsg, sMsgType, bClosing, dialogResult)
			Else
				If num <> 7S And num <> 10S Then
					Dim num2 As Short = 1S
					Dim num3 As Short = CShort((Me.cboCrankHoles.SelectedIndex + 1))
					For num4 As Short = num2 To num3
						Select Case num4
							Case 1S
								If Strings.Len(Strings.Trim(Me._txtR_1.Text)) = 0 Then
									Util.Errmsg("Please enter the R dimension for crank hole #" + Conversions.ToString(CInt(num4)) + ".")
									Me._txtR_1.Focus()
								End If
							Case 2S
								If Strings.Len(Strings.Trim(Me._txtR_2.Text)) = 0 Then
									Util.Errmsg("Please enter the R dimension for crank hole #" + Conversions.ToString(CInt(num4)) + ".")
									Me._txtR_2.Focus()
								End If
							Case 3S
								If Strings.Len(Strings.Trim(Me._txtR_3.Text)) = 0 Then
									Util.Errmsg("Please enter the R dimension for crank hole #" + Conversions.ToString(CInt(num4)) + ".")
									Me._txtR_3.Focus()
								End If
							Case 4S
								If Strings.Len(Strings.Trim(Me._txtR_4.Text)) = 0 Then
									Util.Errmsg("Please enter the R dimension for crank hole #" + Conversions.ToString(CInt(num4)) + ".")
									Me._txtR_4.Focus()
								End If
							Case 5S
								If Strings.Len(Strings.Trim(Me._txtR_5.Text)) = 0 Then
									Util.Errmsg("Please enter the R dimension for crank hole #" + Conversions.ToString(CInt(num4)) + ".")
									Me._txtR_5.Focus()
								End If
						End Select
					Next
				End If
				If Not Me.CheckDimensions() Then
					Util.Errmsg("One or more of your pumping unit dimensions is in error.  Please check your input.")
					Me._txtR_1.Focus()
				Else
					Dim num5 As Short
					If Strings.Len(RuntimeHelpers.GetObjectValue(Me.Tag)) = 0 Then
						num5 = -1S
					Else
						num5 = Conversions.ToShort(Me.Tag)
					End If
					Dim [string] As String = String.Concat(New String() { Strings.Trim(Me.txtManufacturer.Text), vbTab, Me.lblAPIDesignation.Text, vbTab, Strings.Trim(Me.txtUnitName.Text) })
					Dim num6 As Short = 0S
					Dim num7 As Short = CShort((lvwCustomPU.Items.Count - 1))
					For num4 As Short = num6 To num7
						If num4 <> num5 Then
							Dim string2 As String = String.Concat(New String() { lvwCustomPU.Items(CInt(num4)).Text, vbTab, lvwCustomPU.Items(CInt(num4)).SubItems(1).Text, vbTab, lvwCustomPU.Items(CInt(num4)).SubItems(2).Text })
							If Strings.StrComp(string2, [string], CompareMethod.Text) = 0 Then
								Dim msg As String = Me.sAlreadyPU
								Dim bDefaultYes As Boolean = True
								Dim flag As Boolean = False
								If Util.YesNo(msg, bDefaultYes, flag) Then
									Return result
								End If
							End If
						End If
					Next
					result = True
				End If
			End If
			Return result
		End Function

		Private Function CheckDimensions() As Boolean
			Dim result As Boolean = True
			If Me.cboUnitType.SelectedIndex + 1 <> 7 And Me.cboUnitType.SelectedIndex + 1 <> 10 And Me.cboUnitType.SelectedIndex + 1 <> 9 Then
				Dim num As Single = Convert.ToSingle(Me.txtC.Text)
				Dim num2 As Single = Convert.ToSingle(Me.txtI.Text)
				Dim num3 As Single = Convert.ToSingle(Me.txtK.Text)
				Dim num4 As Single = Convert.ToSingle(Me.txtP.Text)
				Dim num5 As Short = 1S
				Dim num6 As Short = CShort((Me.cboCrankHoles.SelectedIndex + 1))
				For num7 As Short = num5 To num6
					Dim num8 As Single
					Select Case num7
						Case 1S
							num8 = Convert.ToSingle(Me._txtR_1.Text)
						Case 2S
							num8 = Convert.ToSingle(Me._txtR_2.Text)
						Case 3S
							num8 = Convert.ToSingle(Me._txtR_3.Text)
						Case 4S
							num8 = Convert.ToSingle(Me._txtR_4.Text)
						Case 5S
							num8 = Convert.ToSingle(Me._txtR_5.Text)
					End Select
					If num8 > 0F Then
						If num4 + num8 + num <= num3 Then
							result = False
						End If
						If num4 + num8 + num3 <= num Then
							result = False
						End If
						If num4 + num8 > num + num3 Then
							result = False
						End If
						If num4 - num8 + num <= num3 Then
							result = False
						End If
						If num4 - num8 + num3 <= num Then
							result = False
						End If
						If num4 - num8 > num + num3 Then
							result = False
						End If
					End If
				Next
				If num3 <= num2 Then
					result = False
				End If
			End If
			Return result
		End Function

		Private Function MakeAPIDimErrorMessage(APIName As String, min As Single, max As Single, EUnits As String, Munits As String, EtoM As Single) As String
			Return Util.FormatMessage(RuntimeHelpers.GetObjectValue(Interaction.IIf(RSWIN_DESC.SETUP_MeasurementSystem = 3, "The {0} dimension must be between {1} and {2} {3}.~({4!0.0} and {5!0.0} {6}).", "The {0} dimension must be between {1} and {2} {3}.")), New Object() { APIName, min, max, EUnits, min * EtoM, max * EtoM, Munits })
		End Function

		Private Sub ShowAPIDesignation()
			Dim flag As Boolean = False
			Dim flag2 As Boolean = False
			Dim obj As Object
			Dim obj2 As Object
			Dim obj3 As Object
			If flag2 <> Me.cboUnitType.SelectedIndex >= 0 Then
				If flag2 <> CtrlUI.CheckValid(Me.txtStructRating, False, False, obj) Then
					If flag2 <> CtrlUI.CheckValid(Me.txtMaxStroke, False, False, obj2) Then
						If flag2 = CtrlUI.CheckValid(Me.txtGearboxRating, False, False, obj3) Then
							If Me.cboUnitType.SelectedIndex + 1 = 10 Then
								flag = True
							End If
						Else
							flag = True
						End If
					End If
				End If
			End If
			If Not flag Then
				Me.lblAPIDesignation.Text = Nothing
				Return
			End If
			Dim text As String
			Select Case Me.cboUnitType.SelectedIndex + 1
				Case 4, 9
					text = "LP"
				Case 5
					text = "M"
				Case 6
					text = "A"
				Case 7
					text = "R"
				Case 8
					text = "B"
				Case 10
					text = "H"
				Case Else
					text = "C"
			End Select
			If Operators.CompareString(text, "H", False) = 0 Then
				Me.lblAPIDesignation.Text = Util.FormatMessage("{0}-{1!0}-{2!0}", New Object() { text, RuntimeHelpers.GetObjectValue(obj), RuntimeHelpers.GetObjectValue(obj2) })
			Else
				Me.lblAPIDesignation.Text = Util.FormatMessage("{0}-{1!0}-{2!0}-{3!0}", New Object() { text, RuntimeHelpers.GetObjectValue(obj3), RuntimeHelpers.GetObjectValue(obj), RuntimeHelpers.GetObjectValue(obj2) })
			End If
		End Sub

		Private Sub ShowUnitStroke(iCrankHole As Short)
			Try
				Me.CheckRequiredRotationCombo()
				Dim flag As Boolean = True
				Dim num As Short
				Dim obj As Object
				Dim obj2 As Object
				Dim obj3 As Object
				Dim obj4 As Object
				Dim obj5 As Object
				Dim obj6 As Object
				Dim obj7 As Object
				If Me.cboUnitType.SelectedIndex < 0 Then
					flag = False
				Else
					' The following expression was wrapped in a checked-expression
					num = CShort((Me.cboUnitType.SelectedIndex + 1))
					If iCrankHole < 0S Then
						If num = 7S Or num = 10S Then
							Me.ShowUnitStroke(0S)
							Return
						End If
						Try
							Dim num2 As Short = 1S
							Dim crankHoles As Short = Me.puRec.CrankHoles
							For num3 As Short = num2 To crankHoles
								Me.ShowUnitStroke(num3)
							Next
						Catch ex As Exception
						End Try
						Return
					Else
						Select Case num
							Case 7S, 10S
								If num = 7S Then
									If Not CtrlUI.CheckValid(Me.txtSprocketDiameter, False, True, obj) Then
										flag = False
									End If
									If Not CtrlUI.CheckValid(Me.txtSprocketDistance, False, True, obj2) Then
										flag = False
									End If
									GoTo IL_27A
								End If
								GoTo IL_27A
						End Select
						Select Case iCrankHole
							Case 1S
								If Not CtrlUI.CheckValid(Me._txtR_1, False, True, obj3) Then
									flag = False
								End If
							Case 2S
								If Not CtrlUI.CheckValid(Me._txtR_2, False, True, obj3) Then
									flag = False
								End If
							Case 3S
								If Not CtrlUI.CheckValid(Me._txtR_3, False, True, obj3) Then
									flag = False
								End If
							Case 4S
								If Not CtrlUI.CheckValid(Me._txtR_4, False, True, obj3) Then
									flag = False
								End If
							Case 5S
								If Not CtrlUI.CheckValid(Me._txtR_5, False, True, obj3) Then
									flag = False
								End If
						End Select
						If num <> 9S Then
							If num = 6S Then
								If Not CtrlUI.CheckValid(Me.txtA_ABAL, False, True, obj4) Then
									flag = False
								End If
								If Not CtrlUI.CheckValid(Me.txtC_ABAL, False, True, obj5) Then
									flag = False
								End If
								If Not CtrlUI.CheckValid(Me.txtK_ABAL, False, True, obj6) Then
									flag = False
								End If
								If Not CtrlUI.CheckValid(Me.txtP_ABAL, False, True, obj7) Then
									flag = False
								End If
							ElseIf num = 5S Then
								If Not CtrlUI.CheckValid(Me.txtA_MII, False, True, obj4) Then
									flag = False
								End If
								If Not CtrlUI.CheckValid(Me.txtC_MII, False, True, obj5) Then
									flag = False
								End If
								If Not CtrlUI.CheckValid(Me.txtK_MII, False, True, obj6) Then
									flag = False
								End If
								If Not CtrlUI.CheckValid(Me.txtP_MII, False, True, obj7) Then
									flag = False
								End If
							Else
								If Not CtrlUI.CheckValid(Me.txtA, False, True, obj4) Then
									flag = False
								End If
								If Not CtrlUI.CheckValid(Me.txtC, False, True, obj5) Then
									flag = False
								End If
								If Not CtrlUI.CheckValid(Me.txtK, False, True, obj6) Then
									flag = False
								End If
								If Not CtrlUI.CheckValid(Me.txtP, False, True, obj7) Then
									flag = False
								End If
							End If
							If flag Then
								If Operators.ConditionalCompareObjectEqual(obj5, 0, False) Then
									flag = False
								End If
								If Operators.ConditionalCompareObjectEqual(obj6, 0, False) Then
									flag = False
								End If
							End If
						End If
					End If
				End If
				IL_27A:
				If Not flag Then
					If iCrankHole > 0S Then
						Select Case iCrankHole
							Case 0S
								Me._panCalcStroke_0.Text = ""
							Case 1S
								Me._panCalcStroke_1.Text = ""
							Case 2S
								Me._panCalcStroke_2.Text = ""
							Case 3S
								Me._panCalcStroke_3.Text = ""
							Case 4S
								Me._panCalcStroke_4.Text = ""
							Case 5S
								Me._panCalcStroke_5.Text = ""
						End Select
					End If
				Else
					Dim num4 As Single
					If num = 7S Then
						num4 = Conversions.ToSingle(Operators.AddObject(obj2, obj))
					ElseIf num = 10S Then
						Dim txtMaxStroke As TextBox = Me.txtMaxStroke
						Dim bValidIfEmpty As Boolean = False
						Dim bShowMessage As Boolean = False
						Dim num5 As Single
						Dim obj8 As Object = num5
						Dim flag2 As Boolean = CtrlUI.CheckValid(txtMaxStroke, bValidIfEmpty, bShowMessage, obj8)
						num5 = Conversions.ToSingle(obj8)
						If flag2 Then
							num4 = num5
						End If
					ElseIf num = 9S Then
						If Operators.ConditionalCompareObjectGreater(obj3, 0, False) Then
							num4 = Conversions.ToSingle(Operators.MultiplyObject(obj3, 2))
						End If
					Else
						Dim num6 As Single = CSng(kinemat.ArcCosine(Conversions.ToSingle(Operators.DivideObject(Operators.SubtractObject(Operators.AddObject(Operators.MultiplyObject(obj5, obj5), Operators.MultiplyObject(obj6, obj6)), Operators.ExponentObject(Operators.AddObject(obj7, obj3), 2)), Operators.MultiplyObject(Operators.MultiplyObject(2, obj5), obj6)))))
						Dim num7 As Single = CSng(kinemat.ArcCosine(Conversions.ToSingle(Operators.DivideObject(Operators.SubtractObject(Operators.AddObject(Operators.MultiplyObject(obj5, obj5), Operators.MultiplyObject(obj6, obj6)), Operators.ExponentObject(Operators.SubtractObject(obj7, obj3), 2)), Operators.MultiplyObject(Operators.MultiplyObject(2, obj5), obj6)))))
						num4 = Conversions.ToSingle(Operators.MultiplyObject(obj4, num6 - num7))
					End If
					Select Case iCrankHole
						Case 0S
							Me._panCalcStroke_0.Tag = Convert.ToString(Conversion.Int(CDbl(num4) + 0.5))
							If num4 <> 0F Then
								If RSWIN_DESC.SETUP_MeasurementSystem <> 3 Then
									Dim panCalcStroke_ As Label = Me._panCalcStroke_0
									Dim text As String = "0.0"
									panCalcStroke_.Text = Util.Format(num4, text)
								Else
									Dim panCalcStroke_2 As Label = Me._panCalcStroke_0
									Dim num8 As Single = num4 * RSWIN_DESC.IN__CM
									Dim text As String = "0"
									panCalcStroke_2.Text = Util.Format(num8, text)
								End If
							Else
								Me._panCalcStroke_0.Text = ""
							End If
						Case 1S
							Me._panCalcStroke_1.Tag = Convert.ToString(Conversion.Int(CDbl(num4) + 0.5))
							If num4 <> 0F Then
								If RSWIN_DESC.SETUP_MeasurementSystem <> 3 Then
									Dim panCalcStroke_3 As Label = Me._panCalcStroke_1
									Dim text As String = "0.0"
									panCalcStroke_3.Text = Util.Format(num4, text)
								Else
									Dim panCalcStroke_4 As Label = Me._panCalcStroke_1
									Dim num8 As Single = num4 * RSWIN_DESC.IN__CM
									Dim text As String = "0"
									panCalcStroke_4.Text = Util.Format(num8, text)
								End If
							Else
								Me._panCalcStroke_1.Text = ""
							End If
						Case 2S
							Me._panCalcStroke_2.Tag = Convert.ToString(Conversion.Int(CDbl(num4) + 0.5))
							If num4 <> 0F Then
								If RSWIN_DESC.SETUP_MeasurementSystem <> 3 Then
									Dim panCalcStroke_5 As Label = Me._panCalcStroke_2
									Dim text As String = "0.0"
									panCalcStroke_5.Text = Util.Format(num4, text)
								Else
									Dim panCalcStroke_6 As Label = Me._panCalcStroke_2
									Dim num8 As Single = num4 * RSWIN_DESC.IN__CM
									Dim text As String = "0"
									panCalcStroke_6.Text = Util.Format(num8, text)
								End If
							Else
								Me._panCalcStroke_2.Text = ""
							End If
						Case 3S
							Me._panCalcStroke_3.Tag = Convert.ToString(Conversion.Int(CDbl(num4) + 0.5))
							If num4 <> 0F Then
								If RSWIN_DESC.SETUP_MeasurementSystem <> 3 Then
									Dim panCalcStroke_7 As Label = Me._panCalcStroke_3
									Dim text As String = "0.0"
									panCalcStroke_7.Text = Util.Format(num4, text)
								Else
									Dim panCalcStroke_8 As Label = Me._panCalcStroke_3
									Dim num8 As Single = num4 * RSWIN_DESC.IN__CM
									Dim text As String = "0"
									panCalcStroke_8.Text = Util.Format(num8, text)
								End If
							Else
								Me._panCalcStroke_3.Text = ""
							End If
						Case 4S
							Me._panCalcStroke_4.Tag = Convert.ToString(Conversion.Int(CDbl(num4) + 0.5))
							If num4 <> 0F Then
								If RSWIN_DESC.SETUP_MeasurementSystem <> 3 Then
									Dim panCalcStroke_9 As Label = Me._panCalcStroke_4
									Dim text As String = "0.0"
									panCalcStroke_9.Text = Util.Format(num4, text)
								Else
									Dim panCalcStroke_10 As Label = Me._panCalcStroke_4
									Dim num8 As Single = num4 * RSWIN_DESC.IN__CM
									Dim text As String = "0"
									panCalcStroke_10.Text = Util.Format(num8, text)
								End If
							Else
								Me._panCalcStroke_4.Text = ""
							End If
						Case 5S
							Me._panCalcStroke_5.Tag = Convert.ToString(Conversion.Int(CDbl(num4) + 0.5))
							If num4 <> 0F Then
								If RSWIN_DESC.SETUP_MeasurementSystem <> 3 Then
									Dim panCalcStroke_11 As Label = Me._panCalcStroke_5
									Dim text As String = "0.0"
									panCalcStroke_11.Text = Util.Format(num4, text)
								Else
									Dim panCalcStroke_12 As Label = Me._panCalcStroke_5
									Dim num8 As Single = num4 * RSWIN_DESC.IN__CM
									Dim text As String = "0"
									panCalcStroke_12.Text = Util.Format(num8, text)
								End If
							Else
								Me._panCalcStroke_5.Text = ""
							End If
					End Select
				End If
			Catch ex2 As Exception
			End Try
		End Sub

		Private Sub cboCrankHoles_SelectedIndexChanged(eventSender As Object, eventArgs As EventArgs)
			If Not Me.cboCrankHoles.Focus() Then
				Me.cboCrankHoles.BackColor = RSWIN_DESC.rgbEditComplete
			ElseIf Me.cboCrankHoles.SelectedIndex = -1 Then
				Me.cboCrankHoles.BackColor = RSWIN_DESC.rgbEditRequired
			Else
				Me.cboCrankHoles.BackColor = RSWIN_DESC.rgbEditFocus
			End If
			Me.SetRadiusTextBoxes()
		End Sub

		Private Sub SetRadiusTextBoxes()
			' The following expression was wrapped in a checked-statement
			Try
				Me.ResetClock()
				If Me.cboCrankHoles.SelectedIndex <> -1 Then
					Dim num As Integer = 1
					Do
						Select Case num
							Case 1
								Me._txtR_1.Enabled = (num - 1 <= Me.cboCrankHoles.SelectedIndex)
								Dim textBox As TextBox = Me._txtR_1
								Me.SetBackgroundColor(textBox, 1)
								Me._txtR_1 = textBox
							Case 2
								Me._txtR_2.Enabled = (num - 1 <= Me.cboCrankHoles.SelectedIndex)
								Dim textBox As TextBox = Me._txtR_2
								Me.SetBackgroundColor(textBox, 2)
								Me._txtR_2 = textBox
							Case 3
								Me._txtR_3.Enabled = (num - 1 <= Me.cboCrankHoles.SelectedIndex)
								Dim textBox As TextBox = Me._txtR_3
								Me.SetBackgroundColor(textBox, 3)
								Me._txtR_3 = textBox
							Case 4
								Me._txtR_4.Enabled = (num - 1 <= Me.cboCrankHoles.SelectedIndex)
								Dim textBox As TextBox = Me._txtR_4
								Me.SetBackgroundColor(textBox, 4)
								Me._txtR_4 = textBox
							Case 5
								Me._txtR_5.Enabled = (num - 1 <= Me.cboCrankHoles.SelectedIndex)
								Dim textBox As TextBox = Me._txtR_5
								Me.SetBackgroundColor(textBox, 5)
								Me._txtR_5 = textBox
						End Select
						num += 1
					Loop While num <= 5
					Me.puRec.CrankHoles = CShort((Me.cboCrankHoles.SelectedIndex + 1))
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub SetBackgroundColor(ByRef txt As TextBox, index As Integer)
			If txt.Enabled Then
				If Operators.CompareString(txt.Text, "", False) = 0 Then
					txt.BackColor = RSWIN_DESC.rgbEditRequired
				Else
					txt.BackColor = RSWIN_DESC.rgbEditComplete
				End If
				Select Case index
					Case 1
						Me._txtR_1_disabled.SendToBack()
					Case 2
						Me._txtR_2_disabled.SendToBack()
					Case 3
						Me._txtR_3_disabled.SendToBack()
					Case 4
						Me._txtR_4_disabled.SendToBack()
					Case 5
						Me._txtR_5_disabled.SendToBack()
				End Select
			ElseIf Not txt.Enabled Then
				Select Case index
					Case 1
						Me._txtR_1_disabled.BringToFront()
					Case 2
						Me._txtR_2_disabled.BringToFront()
					Case 3
						Me._txtR_3_disabled.BringToFront()
					Case 4
						Me._txtR_4_disabled.BringToFront()
					Case 5
						Me._txtR_5_disabled.BringToFront()
				End Select
			End If
		End Sub

		Private Sub cboCrankHoles_DropDown(eventSender As Object, eventArgs As EventArgs)
		End Sub

		Public Sub ComboBox_Click(cbo As ComboBox)
			If Me.ActiveControl IsNot cbo Then
				CtrlUI.ComboBox_LostFocus(cbo)
			End If
			Me.ResetClock()
		End Sub

		Private Sub cboUnitType_SelectedIndexChanged(eventSender As Object, eventArgs As EventArgs)
			Dim num As Short
			Dim num2 As Short
			Dim num3 As Short
			Dim num4 As Short
			Dim num5 As Short
			If Me.cboUnitType.SelectedIndex >= 0 Then
				Try
					If Me.cboUnitType.SelectedIndex + 1 = 1 Or Me.cboUnitType.SelectedIndex + 1 = 2 Then
						Me.HelpProvider1.SetHelpKeyword(Me.txtA, "A Dimension (Conventional and Enhanced Units)")
						Me.HelpProvider1.SetHelpKeyword(Me.txtC, "C Dimension (Conventional and Enhanced Units)")
						Me.HelpProvider1.SetHelpKeyword(Me.txtI, "I Dimension (Conventional and Enhanced Units)")
						Me.HelpProvider1.SetHelpKeyword(Me.txtK, "K Dimension (Conventional and Enhanced Units)")
						Me.HelpProvider1.SetHelpKeyword(Me.txtP, "P Dimension (Conventional and Enhanced Units)")
						Me.HelpProvider1.SetHelpKeyword(Me._txtR_1, "R Dimension (Conventional and Enhanced Units)")
						Me.HelpProvider1.SetHelpKeyword(Me._txtR_2, "R Dimension (Conventional and Enhanced Units)")
						Me.HelpProvider1.SetHelpKeyword(Me._txtR_3, "R Dimension (Conventional and Enhanced Units)")
						Me.HelpProvider1.SetHelpKeyword(Me._txtR_4, "R Dimension (Conventional and Enhanced Units)")
						Me.HelpProvider1.SetHelpKeyword(Me._txtR_5, "R Dimension (Conventional and Enhanced Units)")
					ElseIf Me.cboUnitType.SelectedIndex + 1 = 8 Then
						Me.HelpProvider1.SetHelpKeyword(Me.txtA, "A Dimension (Beam Balanced Units)")
						Me.HelpProvider1.SetHelpKeyword(Me.txtC, "C Dimension (Beam Balanced Units)")
						Me.HelpProvider1.SetHelpKeyword(Me.txtI, "I Dimension (Beam Balanced Units)")
						Me.HelpProvider1.SetHelpKeyword(Me.txtK, "K Dimension (Beam Balanced Units)")
						Me.HelpProvider1.SetHelpKeyword(Me.txtP, "P Dimension (Beam Balanced Units)")
						Me.HelpProvider1.SetHelpKeyword(Me._txtR_1, "R Dimension (Beam Balanced Units)")
						Me.HelpProvider1.SetHelpKeyword(Me._txtR_2, "R Dimension (Beam Balanced Units)")
						Me.HelpProvider1.SetHelpKeyword(Me._txtR_3, "R Dimension (Beam Balanced Units)")
						Me.HelpProvider1.SetHelpKeyword(Me._txtR_4, "R Dimension (Beam Balanced Units)")
						Me.HelpProvider1.SetHelpKeyword(Me._txtR_5, "R Dimension (Beam Balanced Units)")
					ElseIf Me.cboUnitType.SelectedIndex + 1 = 6 Then
						Me.HelpProvider1.SetHelpKeyword(Me._txtR_1, "R Dimension (Air-Balanced Units)")
						Me.HelpProvider1.SetHelpKeyword(Me._txtR_2, "R Dimension (Air-Balanced Units)")
						Me.HelpProvider1.SetHelpKeyword(Me._txtR_3, "R Dimension (Air-Balanced Units)")
						Me.HelpProvider1.SetHelpKeyword(Me._txtR_4, "R Dimension (Air-Balanced Units)")
						Me.HelpProvider1.SetHelpKeyword(Me._txtR_5, "R Dimension (Air-Balanced Units)")
					ElseIf Me.cboUnitType.SelectedIndex + 1 = 5 Then
						Me.HelpProvider1.SetHelpKeyword(Me._txtR_1, "R Dimension (Mark II Units)")
						Me.HelpProvider1.SetHelpKeyword(Me._txtR_2, "R Dimension (Mark II Units)")
						Me.HelpProvider1.SetHelpKeyword(Me._txtR_3, "R Dimension (Mark II Units)")
						Me.HelpProvider1.SetHelpKeyword(Me._txtR_4, "R Dimension (Mark II Units)")
						Me.HelpProvider1.SetHelpKeyword(Me._txtR_5, "R Dimension (Mark II Units)")
					ElseIf Me.cboUnitType.SelectedIndex + 1 = 9 Then
						Me.HelpProvider1.SetHelpKeyword(Me._txtR_1, "R Dimension (Belted Low Profile Units)")
						Me.HelpProvider1.SetHelpKeyword(Me._txtR_2, "R Dimension (Belted Low Profile Units)")
						Me.HelpProvider1.SetHelpKeyword(Me._txtR_3, "R Dimension (Belted Low Profile Units)")
						Me.HelpProvider1.SetHelpKeyword(Me._txtR_4, "R Dimension (Belted Low Profile Units)")
						Me.HelpProvider1.SetHelpKeyword(Me._txtR_5, "R Dimension (Belted Low Profile Units)")
						Me.HelpProvider1.SetHelpKeyword(Me.txtI_lp, "I Dimension (Belted Low Profile Units)")
						Me.HelpProvider1.SetHelpKeyword(Me.txtK_LP, "K Dimension (Belted Low Profile Units)")
					Else
						Me.HelpProvider1.SetHelpKeyword(Me.txtA, "A Dimension (Conventional and Enhanced Units)")
						Me.HelpProvider1.SetHelpKeyword(Me.txtC, "C Dimension (Conventional and Enhanced Units)")
						Me.HelpProvider1.SetHelpKeyword(Me.txtI, "I Dimension (Conventional and Enhanced Units)")
						Me.HelpProvider1.SetHelpKeyword(Me.txtK, "K Dimension (Conventional and Enhanced Units)")
						Me.HelpProvider1.SetHelpKeyword(Me.txtP, "P Dimension (Conventional and Enhanced Units)")
						Me.HelpProvider1.SetHelpKeyword(Me._txtR_1, "R Dimension (Conventional and Enhanced Units)")
						Me.HelpProvider1.SetHelpKeyword(Me._txtR_2, "R Dimension (Conventional and Enhanced Units)")
						Me.HelpProvider1.SetHelpKeyword(Me._txtR_3, "R Dimension (Conventional and Enhanced Units)")
						Me.HelpProvider1.SetHelpKeyword(Me._txtR_4, "R Dimension (Conventional and Enhanced Units)")
						Me.HelpProvider1.SetHelpKeyword(Me._txtR_5, "R Dimension (Conventional and Enhanced Units)")
					End If
				Catch ex As Exception
				End Try
			End If
			If Me.ActiveControl Is Me.cboUnitType Then
				Me.CheckRequiredRotationCombo()
				num = CShort((Me.cboUnitType.SelectedIndex + 1))
				Me.PULinkItem.UnitType = num
				Select Case num
					Case 1S
						Me.PULinkItem.RequiredRotation = 0S
						Me.cboRequiredRotation.SelectedIndex = 2
					Case 2S
						Me.PULinkItem.RequiredRotation = 1S
						Me.cboRequiredRotation.SelectedIndex = 0
					Case 3S
						Me.PULinkItem.RequiredRotation = -1S
						Me.cboRequiredRotation.SelectedIndex = 1
					Case 4S
						Me.PULinkItem.RequiredRotation = -1S
						Me.cboRequiredRotation.SelectedIndex = 1
					Case 5S
						Me.PULinkItem.RequiredRotation = -1S
						Me.cboRequiredRotation.SelectedIndex = 1
					Case 6S
						Me.PULinkItem.RequiredRotation = 0S
						Me.cboRequiredRotation.SelectedIndex = 2
					Case 7S, 9S, 10S
						Me.PULinkItem.RequiredRotation = 0S
						Me.cboRequiredRotation.SelectedIndex = 2
					Case 8S
						Me.PULinkItem.RequiredRotation = 0S
						Me.cboRequiredRotation.SelectedIndex = 2
				End Select
			End If
			Me.ComboBox_Click(Me.cboUnitType)
			num = CShort((Me.cboUnitType.SelectedIndex + 1))
			Select Case num
				Case 6S
					num2 = 0S
					num3 = 2S
					num4 = 4S
					GoTo IL_659
				Case 7S
					num2 = 1S
					num3 = -1S
					num4 = -1S
					GoTo IL_659
				Case 9S
					num2 = 0S
					num3 = 5S
					num4 = -1S
					GoTo IL_659
				Case 10S
					num2 = -1S
					num3 = -1S
					num4 = -1S
					GoTo IL_659
			End Select
			num2 = 0S
			num3 = 2S
			num4 = 3S
			IL_659:
			If num = 10S Then
				Me._Label_GearboxRating.Visible = False
				Me.txtGearboxRating.Visible = False
				Me.lblArtInertia.Visible = False
				Me.txtArtInertia.Visible = False
				Me.lblArtInertia_Disabled.Visible = False
				Me._SSFrame_UnitDimensions.Visible = False
				Me.lblRequiredRotation.Visible = False
				Me.cboRequiredRotation.Visible = False
				Me._Label_API_designation.Text = "Unit Designation"
			Else
				Me._Label_GearboxRating.Visible = True
				Me.txtGearboxRating.Visible = True
				Me.lblArtInertia.Visible = True
				Me.txtArtInertia.Visible = True
				Me.lblArtInertia_Disabled.Visible = True
				Me._SSFrame_UnitDimensions.Visible = True
				Me.lblRequiredRotation.Visible = True
				Me.cboRequiredRotation.Visible = True
				Me._Label_API_designation.Text = "API Designation"
			End If
			Me._panDimensions_0.Visible = False
			Me._panDimensions_longstroke.Visible = False
			Me._panDimensions_2.Visible = False
			Me._panDimensions_2_ABAL.Visible = False
			Me._panDimensions_2_MII.Visible = False
			Me._panDimensions_4.Visible = False
			Me._panLowProfileBelt1.Visible = False
			Me._panLowProfileBelt2.Visible = False
			Me.lblCrankCBMoment.Visible = False
			Me.txtCrankCBMoment.Visible = False
			num5 = 0S
			Do
				Dim visible As Boolean = num5 = num2 Or num5 = num3 Or num5 = num4
				Select Case num5
					Case 0S
						Me._panDimensions_0.Visible = visible
					Case 1S
						Me._panDimensions_longstroke.Visible = visible
					Case 2S
						Select Case num
							Case 5S
								Me._panDimensions_2_MII.Visible = visible
							Case 6S
								Me._panDimensions_2_ABAL.Visible = visible
							Case Else
								Me._panDimensions_2.Visible = visible
						End Select
					Case 3S
						Me._panDimensions_3.Visible = visible
						If num = 8S Then
							Me.lblCrankCBMoment.Visible = visible
							Me.txtCrankCBMoment.Visible = visible
						End If
					Case 4S
						Me._panDimensions_4.Visible = visible
					Case 5S
						Me._panLowProfileBelt1.Visible = visible
						Me._panLowProfileBelt2.Visible = visible
				End Select
				num5 += 1S
			Loop While num5 <= 5S
			Me.txtArtInertia.Enabled = (num <> 7S And num <> 10S)
			Me.ShowAPIDesignation()
			Me.ShowUnitStroke(-1S)
		End Sub

		Private Sub cboUnitType_DropDown(eventSender As Object, eventArgs As EventArgs)
		End Sub

		Private Sub cmdCancel_Click(eventSender As Object, eventArgs As EventArgs)
			Me.bOK = False
			Try
				FileSystem.FileClose(New Integer() { CInt(Me.frn) })
			Catch ex As Exception
			End Try
			Me.Hide()
		End Sub

		Private Sub cmdHelp_Click(eventSender As Object, eventArgs As EventArgs)
			Help.ShowHelp(Me, Me.HelpProvider1.HelpNamespace, HelpNavigator.Index, "")
		End Sub

		Private Sub cmdLoad_Click(eventSender As Object, eventArgs As EventArgs)
			Me.PerformLoad()
		End Sub

		Private Sub cmdOK_Click(eventSender As Object, eventArgs As EventArgs)
			Dim flag As Boolean = False
			Dim num As Integer = -1
			If Strings.InStr(RSWIN_DESC.rst.UnitID.Trim(), "CUSTOM", CompareMethod.Binary) > 0 Then
				flag = True
				Dim text As String = RSWIN_DESC.rst.UnitID.Replace("CUSTOM", "")
				If Versioned.IsNumeric(text) Then
					num = Convert.ToInt32(text)
				End If
			End If
			Me.bOK = True
			If Me.CheckCustomPU() Then
				If Me.iMethod = 1 Then
					' The following expression was wrapped in a checked-expression
					' The following expression was wrapped in a unchecked-expression
					Me.nUnits = CShort((FileSystem.LOF(CInt(Me.frn)) / CLng(Strings.Len(Me.puRec))))
					Dim i As Short = 2S
					Dim num2 As Short = Me.nUnits
					Me.I = i
					While Me.I <= num2
						Dim fileNumber As Integer = CInt(Me.frn)
						Dim valueType As ValueType = Me.puRec
						FileSystem.FileGet(fileNumber, valueType, CLng(Me.I))
						Dim valueType2 As ValueType = valueType
						Dim pudataRec As RSWIN_DESC.PUDataRec
						Me.puRec = If((valueType2 IsNot Nothing), CType(valueType2, RSWIN_DESC.PUDataRec), pudataRec)
						If Strings.Len(Strings.Trim(Me.puRec.Manuf)) = 0 Then
							Exit While
						End If
						Me.I += 1S
					End While
					Try
						Me.GetUnitDimensions(Me.puRec)
						FileSystem.FilePut(CInt(Me.frn), Me.puRec, CLng(Me.I))
						Me.Close()
						CUSTOMPU.GetCustomUnitNames(Me.lst)
					Catch ex As Exception
					End Try
					FileSystem.FileClose(New Integer() { CInt(Me.frn) })
					Me.m_lvwCustomPU = Me.lst
				ElseIf Me.iMethod = 2 Then
					Try
						Me.GetUnitDimensions(Me.puRec)
						FileSystem.FilePut(CInt(Me.frn), Me.puRec, CLng(Me.nIndex))
						Me.Close()
						If Me.lvw Is Nothing AndAlso Me.m_lvwCustomPU IsNot Nothing Then
							Me.lvw = Me.m_lvwCustomPU
						End If
						CUSTOMPU.GetCustomUnitNames(Me.lvw)
						If flag And CInt(Me.nIndex) = num Then
							RSWIN_DESC.rst.PU = Me.puRec
						End If
					Catch ex2 As Exception
					End Try
					FileSystem.FileClose(New Integer() { CInt(Me.frn) })
					Me.m_lvwCustomPU = Me.lvw
				End If
				Me.Hide()
			End If
		End Sub

		Private Sub dlgCustomPU_Load(eventSender As Object, eventArgs As EventArgs)
			SUPERPRO.NewCheckSentinel(True)
			Me.HelpProvider1.HelpNamespace = RSWIN_DESC.HelpNameSpace
			Me.ResetClock()
			RSWIN.GetMeasurementUnit()
			If RSWIN_DESC.bIntVersion Then
				If RSWIN_DESC.bChangeCultures Then
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
				If RSWIN_DESC.bReadResXFile Then
					Util.AssignValuesToControls(Me)
				End If
			End If
			Try
				Me.Icon = RSWIN_DESC.frmMain.Icon
			Catch ex As Exception
			End Try
			Dim control As Control = Me._Label_29
			CtrlUI.TextBox_SetLabel(control, "c", RSWIN_DESC.SETUP_MeasurementSystem <> 3)
			Me._Label_29 = CType(control, Label)
			control = Me._Label_30
			CtrlUI.TextBox_SetLabel(control, "c", RSWIN_DESC.SETUP_MeasurementSystem <> 3)
			Me._Label_30 = CType(control, Label)
			Me.cboCrankHoles.Items.Clear()
			Me.cboCrankHoles.Items.Add("1")
			Me.cboCrankHoles.Items.Add("2")
			Me.cboCrankHoles.Items.Add("3")
			Me.cboCrankHoles.Items.Add("4")
			Me.cboCrankHoles.Items.Add("5")
			Me.txtManufacturer_TextChanged(Me.txtManufacturer, New EventArgs())
			Me.txtGearboxRating_TextChanged(Me.txtGearboxRating, New EventArgs())
			Me.txtStructRating_TextChanged(Me.txtStructRating, New EventArgs())
			Me.txtMaxStroke_TextChanged(Me.txtMaxStroke, New EventArgs())
			Me.txtSprocketDiameter_TextChanged(Me.txtSprocketDiameter, New EventArgs())
			Me.txtSprocketDistance_TextChanged(Me.txtSprocketDistance, New EventArgs())
			Me.txtDrumDiamRatio_TextChanged(Me.txtDrumDiamRatio, New EventArgs())
			Me._txtR_1_TextChanged(Me._txtR_1, New EventArgs())
			Me._txtR_2_TextChanged(Me._txtR_2, New EventArgs())
			Me._txtR_3_TextChanged(Me._txtR_3, New EventArgs())
			Me._txtR_4_TextChanged(Me._txtR_4, New EventArgs())
			Me._txtR_5_TextChanged(Me._txtR_5, New EventArgs())
			Dim textBox As TextBox = Me._txtR_1
			Me.SetBackgroundColor(textBox, 1)
			Me._txtR_1 = textBox
			textBox = Me._txtR_2
			Me.SetBackgroundColor(textBox, 2)
			Me._txtR_2 = textBox
			textBox = Me._txtR_3
			Me.SetBackgroundColor(textBox, 3)
			Me._txtR_3 = textBox
			textBox = Me._txtR_4
			Me.SetBackgroundColor(textBox, 4)
			Me._txtR_4 = textBox
			textBox = Me._txtR_5
			Me.SetBackgroundColor(textBox, 5)
			Me._txtR_5 = textBox
			Me.txtA_TextChanged(Me.txtA, New EventArgs())
			Me.txtC_TextChanged(Me.txtC, New EventArgs())
			Me.txtI_TextChanged(Me.txtI, New EventArgs())
			Me.txtK_TextChanged(Me.txtK, New EventArgs())
			Me.txtP_TextChanged(Me.txtP, New EventArgs())
			Me.txtA_ABAL_TextChanged(Me.txtA_ABAL, New EventArgs())
			Me.txtC_ABAL_TextChanged(Me.txtC_ABAL, New EventArgs())
			Me.txtI_ABAL_TextChanged(Me.txtI_ABAL, New EventArgs())
			Me.txtK_ABAL_TextChanged(Me.txtK_ABAL, New EventArgs())
			Me.txtP_ABAL_TextChanged(Me.txtP_ABAL, New EventArgs())
			Me.txtA_MII_TextChanged(Me.txtA_MII, New EventArgs())
			Me.txtC_MII_TextChanged(Me.txtC_MII, New EventArgs())
			Me.txtI_MII_TextChanged(Me.txtI_MII, New EventArgs())
			Me.txtK_MII_TextChanged(Me.txtK_MII, New EventArgs())
			Me.txtP_MII_TextChanged(Me.txtP_MII, New EventArgs())
			Me.txtM_TextChanged(Me.txtM, New EventArgs())
			Me.txtS_TextChanged(Me.txtS, New EventArgs())
			Me.txtV0_TextChanged(Me.txtV0, New EventArgs())
			Me.txtUnbalance_TextChanged(Me.txtUnbalance, New EventArgs())
			Me.txtCrankOffset_TextChanged(Me.txtCrankOffset, New EventArgs())
			Me.txtTheta_TextChanged(Me.txtTheta, New EventArgs())
			Me.txtD_lp_TextChanged(Me.txtD_lp, New EventArgs())
			Me.txtI_lp_TextChanged(Me.txtI_lp, New EventArgs())
			Me.txtK_lp_TextChanged(Me.txtK_LP, New EventArgs())
			Me.txtCrankCBMoment_TextChanged(Me.txtCrankCBMoment, New EventArgs())
			Me.SetRadiusTextBoxes()
			If RSWIN_DESC.bIntVersion Then
				If RSWIN_DESC.bWriteResXFile Then
					Util.OpenResourceWriter(Me.Name)
					Util.WriteControlStrings(Me, Me.ToolTip1)
					Util.CloseResourceWriter()
				End If
				Return
			End If
		End Sub

		Private Sub Label_Click(eventSender As Object, eventArgs As EventArgs)
			Dim index As Short = Me.Label.GetIndex(CType(eventSender, Label))
		End Sub

		Private Sub Label_DoubleClick(eventSender As Object, eventArgs As EventArgs)
			Dim index As Short = Me.Label.GetIndex(CType(eventSender, Label))
		End Sub

		Private Sub txtA_TextChanged(eventSender As Object, eventArgs As EventArgs)
			Dim txtA As TextBox = Me.txtA
			Dim label_ As Label = Me._Label_18
			Me.TextBox_Change(txtA, label_)
			Me._Label_18 = label_
			Me.txtA = txtA
			Me.ShowUnitStroke(-1S)
		End Sub

		Private Sub txtA_KeyDown(eventSender As Object, eventArgs As KeyEventArgs)
			' The following expression was wrapped in a checked-statement
			Dim num As Short = CShort(eventArgs.KeyCode)
			Dim num2 As Short = CShort((eventArgs.KeyData / Keys.Shift))
		End Sub

		Private Sub txtA_KeyPress(eventSender As Object, eventArgs As KeyPressEventArgs)
			' The following expression was wrapped in a checked-expression
			Dim num As Short = CShort(Strings.Asc(eventArgs.KeyChar))
			If num = 0S Then
				eventArgs.Handled = True
			End If
		End Sub

		Private Sub txtA_Leave(eventSender As Object, eventArgs As EventArgs)
			Dim txtA As Control = Me.txtA
			CtrlUI.Control_LostFocus(txtA)
			Me.txtA = CType(txtA, TextBox)
			Dim msgtxt As String = Me.MakeAPIDimErrorMessage("A", 15F, 500F, RSWIN_DESC.ins, RSWIN_DESC.cm, RSWIN_DESC.IN__CM)
			Dim flag As Boolean = False
			Dim obj As Object
			If flag <> CtrlUI.CheckValid(Me.txtA, True, False, obj) Then
				Dim obj2 As Object = flag
				Dim lowerBound As Single = 15F
				Dim inclusive As Integer = -1
				Dim errnum As Integer = 0
				Dim useMetric As Integer = 0
				Dim canadianIsMetric As Integer = 0
				Dim bQuiet As Boolean = False
				Dim text As String = ""
				If Operators.ConditionalCompareObjectEqual(obj2, Util.CheckLower(obj, lowerBound, inclusive, errnum, useMetric, canadianIsMetric, bQuiet, text), False) Then
					Util.Errmsg(msgtxt)
					Me.txtA.Focus()
				Else
					Dim obj3 As Object = flag
					Dim upperBound As Single = 500F
					Dim inclusive2 As Integer = -1
					Dim errnum2 As Integer = 0
					Dim useMetric2 As Integer = 0
					Dim canadianIsMetric2 As Integer = 0
					Dim bQuiet2 As Boolean = False
					text = ""
					If Operators.ConditionalCompareObjectEqual(obj3, Util.CheckUpper(obj, upperBound, inclusive2, errnum2, useMetric2, canadianIsMetric2, bQuiet2, text), False) Then
						Util.Errmsg(msgtxt)
						Me.txtA.Focus()
					ElseIf Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
						Me.PULinkItem.A = Conversions.ToSingle(obj)
					End If
				End If
			End If
		End Sub

		Private Sub txtA_ABAL_TextChanged(eventSender As Object, eventArgs As EventArgs)
			Dim txtA_ABAL As TextBox = Me.txtA_ABAL
			Dim label_A_ABAL As Label = Me.Label_A_ABAL
			Me.TextBox_Change(txtA_ABAL, label_A_ABAL)
			Me.Label_A_ABAL = label_A_ABAL
			Me.txtA_ABAL = txtA_ABAL
			Me.ShowUnitStroke(-1S)
		End Sub

		Private Sub txtA_ABAL_KeyDown(eventSender As Object, eventArgs As KeyEventArgs)
			' The following expression was wrapped in a checked-statement
			Dim num As Short = CShort(eventArgs.KeyCode)
			Dim num2 As Short = CShort((eventArgs.KeyData / Keys.Shift))
		End Sub

		Private Sub txtA_ABAL_KeyPress(eventSender As Object, eventArgs As KeyPressEventArgs)
			' The following expression was wrapped in a checked-expression
			Dim num As Short = CShort(Strings.Asc(eventArgs.KeyChar))
			If num = 0S Then
				eventArgs.Handled = True
			End If
		End Sub

		Private Sub txtA_ABAL_Leave(eventSender As Object, eventArgs As EventArgs)
			Dim txtA_ABAL As Control = Me.txtA_ABAL
			CtrlUI.Control_LostFocus(txtA_ABAL)
			Me.txtA_ABAL = CType(txtA_ABAL, TextBox)
			Dim msgtxt As String = Me.MakeAPIDimErrorMessage("A", 15F, 500F, RSWIN_DESC.ins, RSWIN_DESC.cm, RSWIN_DESC.IN__CM)
			Dim flag As Boolean = False
			Dim obj As Object
			If flag <> CtrlUI.CheckValid(Me.txtA_ABAL, True, False, obj) Then
				Dim obj2 As Object = flag
				Dim lowerBound As Single = 15F
				Dim inclusive As Integer = -1
				Dim errnum As Integer = 0
				Dim useMetric As Integer = 0
				Dim canadianIsMetric As Integer = 0
				Dim bQuiet As Boolean = False
				Dim text As String = ""
				If Operators.ConditionalCompareObjectEqual(obj2, Util.CheckLower(obj, lowerBound, inclusive, errnum, useMetric, canadianIsMetric, bQuiet, text), False) Then
					Util.Errmsg(msgtxt)
					Me.txtA_ABAL.Focus()
				Else
					Dim obj3 As Object = flag
					Dim upperBound As Single = 500F
					Dim inclusive2 As Integer = -1
					Dim errnum2 As Integer = 0
					Dim useMetric2 As Integer = 0
					Dim canadianIsMetric2 As Integer = 0
					Dim bQuiet2 As Boolean = False
					text = ""
					If Operators.ConditionalCompareObjectEqual(obj3, Util.CheckUpper(obj, upperBound, inclusive2, errnum2, useMetric2, canadianIsMetric2, bQuiet2, text), False) Then
						Util.Errmsg(msgtxt)
						Me.txtA_ABAL.Focus()
					ElseIf Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
						Me.PULinkItem.A = Conversions.ToSingle(obj)
					End If
				End If
			End If
		End Sub

		Private Sub txtA_MII_TextChanged(eventSender As Object, eventArgs As EventArgs)
			Dim txtA_MII As TextBox = Me.txtA_MII
			Dim label_A_MII As Label = Me.Label_A_MII
			Me.TextBox_Change(txtA_MII, label_A_MII)
			Me.Label_A_MII = label_A_MII
			Me.txtA_MII = txtA_MII
			Me.ShowUnitStroke(-1S)
		End Sub

		Private Sub txtA_MII_KeyDown(eventSender As Object, eventArgs As KeyEventArgs)
			' The following expression was wrapped in a checked-statement
			Dim num As Short = CShort(eventArgs.KeyCode)
			Dim num2 As Short = CShort((eventArgs.KeyData / Keys.Shift))
		End Sub

		Private Sub txtA_MII_KeyPress(eventSender As Object, eventArgs As KeyPressEventArgs)
			' The following expression was wrapped in a checked-expression
			Dim num As Short = CShort(Strings.Asc(eventArgs.KeyChar))
			If num = 0S Then
				eventArgs.Handled = True
			End If
		End Sub

		Private Sub txtA_MII_Leave(eventSender As Object, eventArgs As EventArgs)
			Dim txtA_MII As Control = Me.txtA_MII
			CtrlUI.Control_LostFocus(txtA_MII)
			Me.txtA_MII = CType(txtA_MII, TextBox)
			Dim msgtxt As String = Me.MakeAPIDimErrorMessage("A", 15F, 500F, RSWIN_DESC.ins, RSWIN_DESC.cm, RSWIN_DESC.IN__CM)
			Dim flag As Boolean = False
			Dim obj As Object
			If flag <> CtrlUI.CheckValid(Me.txtA_MII, True, False, obj) Then
				Dim obj2 As Object = flag
				Dim lowerBound As Single = 15F
				Dim inclusive As Integer = -1
				Dim errnum As Integer = 0
				Dim useMetric As Integer = 0
				Dim canadianIsMetric As Integer = 0
				Dim bQuiet As Boolean = False
				Dim text As String = ""
				If Operators.ConditionalCompareObjectEqual(obj2, Util.CheckLower(obj, lowerBound, inclusive, errnum, useMetric, canadianIsMetric, bQuiet, text), False) Then
					Util.Errmsg(msgtxt)
					Me.txtA_MII.Focus()
				Else
					Dim obj3 As Object = flag
					Dim upperBound As Single = 500F
					Dim inclusive2 As Integer = -1
					Dim errnum2 As Integer = 0
					Dim useMetric2 As Integer = 0
					Dim canadianIsMetric2 As Integer = 0
					Dim bQuiet2 As Boolean = False
					text = ""
					If Operators.ConditionalCompareObjectEqual(obj3, Util.CheckUpper(obj, upperBound, inclusive2, errnum2, useMetric2, canadianIsMetric2, bQuiet2, text), False) Then
						Util.Errmsg(msgtxt)
						Me.txtA_MII.Focus()
					ElseIf Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
						Me.PULinkItem.A = Conversions.ToSingle(obj)
					End If
				End If
			End If
		End Sub

		Private Sub txtArtInertia_KeyDown(eventSender As Object, eventArgs As KeyEventArgs)
			' The following expression was wrapped in a checked-statement
			Dim num As Short = CShort(eventArgs.KeyCode)
			Dim num2 As Short = CShort((eventArgs.KeyData / Keys.Shift))
		End Sub

		Private Sub txtArtInertia_KeyPress(eventSender As Object, eventArgs As KeyPressEventArgs)
			' The following expression was wrapped in a checked-expression
			Dim num As Short = CShort(Strings.Asc(eventArgs.KeyChar))
			If num = 0S Then
				eventArgs.Handled = True
			End If
		End Sub

		Private Sub txtArtInertia_Leave(eventSender As Object, eventArgs As EventArgs)
			Dim txtArtInertia As Control = Me.txtArtInertia
			CtrlUI.Control_LostFocus(txtArtInertia)
			Me.txtArtInertia = CType(txtArtInertia, TextBox)
			Dim flag As Boolean = False
			Dim obj As Object
			If flag <> CtrlUI.CheckValid(Me.txtArtInertia, True, False, obj) Then
				If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
					Me.PULinkItem.ArtInertia = Conversions.ToSingle(obj)
				End If
			End If
		End Sub

		Private Sub txtC_TextChanged(eventSender As Object, eventArgs As EventArgs)
			Dim txtC As TextBox = Me.txtC
			Dim label_ As Label = Me._Label_19
			Me.TextBox_Change(txtC, label_)
			Me._Label_19 = label_
			Me.txtC = txtC
			Me.ShowUnitStroke(-1S)
		End Sub

		Private Sub txtC_KeyDown(eventSender As Object, eventArgs As KeyEventArgs)
			' The following expression was wrapped in a checked-statement
			Dim num As Short = CShort(eventArgs.KeyCode)
			Dim num2 As Short = CShort((eventArgs.KeyData / Keys.Shift))
		End Sub

		Private Sub txtC_KeyPress(eventSender As Object, eventArgs As KeyPressEventArgs)
			' The following expression was wrapped in a checked-expression
			Dim num As Short = CShort(Strings.Asc(eventArgs.KeyChar))
			If num = 0S Then
				eventArgs.Handled = True
			End If
		End Sub

		Private Sub txtC_Leave(eventSender As Object, eventArgs As EventArgs)
			Dim txtC As Control = Me.txtC
			CtrlUI.Control_LostFocus(txtC)
			Me.txtC = CType(txtC, TextBox)
			Dim msgtxt As String = Me.MakeAPIDimErrorMessage("C", 15F, 400F, RSWIN_DESC.ins, RSWIN_DESC.cm, RSWIN_DESC.IN__CM)
			Dim flag As Boolean = False
			Dim obj As Object
			If flag <> CtrlUI.CheckValid(Me.txtC, True, False, obj) Then
				Dim obj2 As Object = flag
				Dim lowerBound As Single = 15F
				Dim inclusive As Integer = -1
				Dim errnum As Integer = 0
				Dim useMetric As Integer = 0
				Dim canadianIsMetric As Integer = 0
				Dim bQuiet As Boolean = False
				Dim text As String = ""
				If Operators.ConditionalCompareObjectEqual(obj2, Util.CheckLower(obj, lowerBound, inclusive, errnum, useMetric, canadianIsMetric, bQuiet, text), False) Then
					Util.Errmsg(msgtxt)
					Me.txtC.Focus()
				Else
					Dim obj3 As Object = flag
					Dim upperBound As Single = 400F
					Dim inclusive2 As Integer = -1
					Dim errnum2 As Integer = 0
					Dim useMetric2 As Integer = 0
					Dim canadianIsMetric2 As Integer = 0
					Dim bQuiet2 As Boolean = False
					text = ""
					If Operators.ConditionalCompareObjectEqual(obj3, Util.CheckUpper(obj, upperBound, inclusive2, errnum2, useMetric2, canadianIsMetric2, bQuiet2, text), False) Then
						Util.Errmsg(msgtxt)
						Me.txtC.Focus()
					ElseIf Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
						Me.PULinkItem.C = Conversions.ToSingle(obj)
					End If
				End If
			End If
		End Sub

		Private Sub txtC_ABAL_TextChanged(eventSender As Object, eventArgs As EventArgs)
			Dim txtC_ABAL As TextBox = Me.txtC_ABAL
			Dim label_C_ABAL As Label = Me.Label_C_ABAL
			Me.TextBox_Change(txtC_ABAL, label_C_ABAL)
			Me.Label_C_ABAL = label_C_ABAL
			Me.txtC_ABAL = txtC_ABAL
			Me.ShowUnitStroke(-1S)
		End Sub

		Private Sub txtC_ABAL_KeyDown(eventSender As Object, eventArgs As KeyEventArgs)
			' The following expression was wrapped in a checked-statement
			Dim num As Short = CShort(eventArgs.KeyCode)
			Dim num2 As Short = CShort((eventArgs.KeyData / Keys.Shift))
		End Sub

		Private Sub txtC_ABAL_KeyPress(eventSender As Object, eventArgs As KeyPressEventArgs)
			' The following expression was wrapped in a checked-expression
			Dim num As Short = CShort(Strings.Asc(eventArgs.KeyChar))
			If num = 0S Then
				eventArgs.Handled = True
			End If
		End Sub

		Private Sub txtC_ABAL_Leave(eventSender As Object, eventArgs As EventArgs)
			Dim txtC_ABAL As Control = Me.txtC_ABAL
			CtrlUI.Control_LostFocus(txtC_ABAL)
			Me.txtC_ABAL = CType(txtC_ABAL, TextBox)
			Dim msgtxt As String = Me.MakeAPIDimErrorMessage("C", 15F, 400F, RSWIN_DESC.ins, RSWIN_DESC.cm, RSWIN_DESC.IN__CM)
			Dim flag As Boolean = False
			Dim obj As Object
			If flag <> CtrlUI.CheckValid(Me.txtC_ABAL, True, False, obj) Then
				Dim obj2 As Object = flag
				Dim lowerBound As Single = 15F
				Dim inclusive As Integer = -1
				Dim errnum As Integer = 0
				Dim useMetric As Integer = 0
				Dim canadianIsMetric As Integer = 0
				Dim bQuiet As Boolean = False
				Dim text As String = ""
				If Operators.ConditionalCompareObjectEqual(obj2, Util.CheckLower(obj, lowerBound, inclusive, errnum, useMetric, canadianIsMetric, bQuiet, text), False) Then
					Util.Errmsg(msgtxt)
					Me.txtC_ABAL.Focus()
				Else
					Dim obj3 As Object = flag
					Dim upperBound As Single = 400F
					Dim inclusive2 As Integer = -1
					Dim errnum2 As Integer = 0
					Dim useMetric2 As Integer = 0
					Dim canadianIsMetric2 As Integer = 0
					Dim bQuiet2 As Boolean = False
					text = ""
					If Operators.ConditionalCompareObjectEqual(obj3, Util.CheckUpper(obj, upperBound, inclusive2, errnum2, useMetric2, canadianIsMetric2, bQuiet2, text), False) Then
						Util.Errmsg(msgtxt)
						Me.txtC_ABAL.Focus()
					ElseIf Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
						Me.PULinkItem.C = Conversions.ToSingle(obj)
					End If
				End If
			End If
		End Sub

		Private Sub txtC_MII_TextChanged(eventSender As Object, eventArgs As EventArgs)
			Dim txtC_MII As TextBox = Me.txtC_MII
			Dim label_C_MII As Label = Me.Label_C_MII
			Me.TextBox_Change(txtC_MII, label_C_MII)
			Me.Label_C_MII = label_C_MII
			Me.txtC_MII = txtC_MII
			Me.ShowUnitStroke(-1S)
		End Sub

		Private Sub txtC_MII_KeyDown(eventSender As Object, eventArgs As KeyEventArgs)
			' The following expression was wrapped in a checked-statement
			Dim num As Short = CShort(eventArgs.KeyCode)
			Dim num2 As Short = CShort((eventArgs.KeyData / Keys.Shift))
		End Sub

		Private Sub txtC_MII_KeyPress(eventSender As Object, eventArgs As KeyPressEventArgs)
			' The following expression was wrapped in a checked-expression
			Dim num As Short = CShort(Strings.Asc(eventArgs.KeyChar))
			If num = 0S Then
				eventArgs.Handled = True
			End If
		End Sub

		Private Sub txtC_MII_Leave(eventSender As Object, eventArgs As EventArgs)
			Dim txtC_MII As Control = Me.txtC_MII
			CtrlUI.Control_LostFocus(txtC_MII)
			Me.txtC_MII = CType(txtC_MII, TextBox)
			Dim msgtxt As String = Me.MakeAPIDimErrorMessage("C", 15F, 400F, RSWIN_DESC.ins, RSWIN_DESC.cm, RSWIN_DESC.IN__CM)
			Dim flag As Boolean = False
			Dim obj As Object
			If flag <> CtrlUI.CheckValid(Me.txtC_MII, True, False, obj) Then
				Dim obj2 As Object = flag
				Dim lowerBound As Single = 15F
				Dim inclusive As Integer = -1
				Dim errnum As Integer = 0
				Dim useMetric As Integer = 0
				Dim canadianIsMetric As Integer = 0
				Dim bQuiet As Boolean = False
				Dim text As String = ""
				If Operators.ConditionalCompareObjectEqual(obj2, Util.CheckLower(obj, lowerBound, inclusive, errnum, useMetric, canadianIsMetric, bQuiet, text), False) Then
					Util.Errmsg(msgtxt)
					Me.txtC_MII.Focus()
				Else
					Dim obj3 As Object = flag
					Dim upperBound As Single = 400F
					Dim inclusive2 As Integer = -1
					Dim errnum2 As Integer = 0
					Dim useMetric2 As Integer = 0
					Dim canadianIsMetric2 As Integer = 0
					Dim bQuiet2 As Boolean = False
					text = ""
					If Operators.ConditionalCompareObjectEqual(obj3, Util.CheckUpper(obj, upperBound, inclusive2, errnum2, useMetric2, canadianIsMetric2, bQuiet2, text), False) Then
						Util.Errmsg(msgtxt)
						Me.txtC_MII.Focus()
					ElseIf Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
						Me.PULinkItem.C = Conversions.ToSingle(obj)
					End If
				End If
			End If
		End Sub

		Private Sub txtCrankOffset_TextChanged(eventSender As Object, eventArgs As EventArgs)
			Dim txtCrankOffset As TextBox = Me.txtCrankOffset
			Dim label_ As Label = Me._Label_24
			Me.TextBox_Change(txtCrankOffset, label_)
			Me._Label_24 = label_
			Me.txtCrankOffset = txtCrankOffset
		End Sub

		Private Sub txtCrankOffset_Enter(eventSender As Object, eventArgs As EventArgs)
		End Sub

		Private Sub txtCrankOffset_KeyDown(eventSender As Object, eventArgs As KeyEventArgs)
			' The following expression was wrapped in a checked-statement
			Dim num As Short = CShort(eventArgs.KeyCode)
			Dim num2 As Short = CShort((eventArgs.KeyData / Keys.Shift))
		End Sub

		Private Sub txtCrankOffset_KeyPress(eventSender As Object, eventArgs As KeyPressEventArgs)
			' The following expression was wrapped in a checked-expression
			Dim num As Short = CShort(Strings.Asc(eventArgs.KeyChar))
			If num = 0S Then
				eventArgs.Handled = True
			End If
		End Sub

		Private Sub txtCrankOffset_Leave(eventSender As Object, eventArgs As EventArgs)
			Dim txtCrankOffset As Control = Me.txtCrankOffset
			CtrlUI.Control_LostFocus(txtCrankOffset)
			Me.txtCrankOffset = CType(txtCrankOffset, TextBox)
			Dim flag As Boolean = False
			Dim obj As Object
			If flag <> CtrlUI.CheckValid(Me.txtCrankOffset, True, False, obj) Then
				Dim obj2 As Object = flag
				Dim lowerBound As Single = -90F
				Dim inclusive As Integer = -1
				Dim errnum As Integer = 17
				Dim useMetric As Integer = 0
				Dim canadianIsMetric As Integer = 0
				Dim bQuiet As Boolean = False
				Dim text As String = ""
				If Operators.ConditionalCompareObjectEqual(obj2, Util.CheckLower(obj, lowerBound, inclusive, errnum, useMetric, canadianIsMetric, bQuiet, text), False) Then
					Me.txtCrankOffset.Focus()
				Else
					Dim obj3 As Object = flag
					Dim upperBound As Single = 90F
					Dim inclusive2 As Integer = -1
					Dim errnum2 As Integer = 17
					Dim useMetric2 As Integer = 0
					Dim canadianIsMetric2 As Integer = 0
					Dim bQuiet2 As Boolean = False
					text = ""
					If Operators.ConditionalCompareObjectEqual(obj3, Util.CheckUpper(obj, upperBound, inclusive2, errnum2, useMetric2, canadianIsMetric2, bQuiet2, text), False) Then
						Me.txtCrankOffset.Focus()
					ElseIf Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
						obj = Operators.DivideObject(Operators.MultiplyObject(obj, 3.141592653589793), 180)
						If Conversions.ToBoolean(Operators.AndObject(Me.cboUnitType.SelectedIndex + 1 = 2, Operators.CompareObjectGreaterEqual(obj, 0, False))) Then
							Util.cErrmsg(100)
						End If
						If Conversions.ToBoolean(Operators.AndObject(Me.cboUnitType.SelectedIndex + 1 = 5, Operators.CompareObjectLessEqual(obj, 0, False))) Then
							Util.cErrmsg(111)
						End If
					End If
				End If
			End If
		End Sub

		Private Sub txtDrumDiamRatio_TextChanged(eventSender As Object, eventArgs As EventArgs)
			Dim txtDrumDiamRatio As TextBox = Me.txtDrumDiamRatio
			Dim label_ As Label = Me._Label_16
			Me.TextBox_Change(txtDrumDiamRatio, label_)
			Me._Label_16 = label_
			Me.txtDrumDiamRatio = txtDrumDiamRatio
		End Sub

		Private Sub txtDrumDiamRatio_KeyDown(eventSender As Object, eventArgs As KeyEventArgs)
			' The following expression was wrapped in a checked-statement
			Dim num As Short = CShort(eventArgs.KeyCode)
			Dim num2 As Short = CShort((eventArgs.KeyData / Keys.Shift))
		End Sub

		Private Sub txtDrumDiamRatio_KeyPress(eventSender As Object, eventArgs As KeyPressEventArgs)
			' The following expression was wrapped in a checked-expression
			Dim num As Short = CShort(Strings.Asc(eventArgs.KeyChar))
			If num = 0S Then
				eventArgs.Handled = True
			End If
		End Sub

		Private Sub txtDrumDiamRatio_Leave(eventSender As Object, eventArgs As EventArgs)
			Dim txtDrumDiamRatio As Control = Me.txtDrumDiamRatio
			CtrlUI.Control_LostFocus(txtDrumDiamRatio)
			Me.txtDrumDiamRatio = CType(txtDrumDiamRatio, TextBox)
			Dim flag As Boolean = False
			Dim obj As Object
			If flag <> CtrlUI.CheckValid(Me.txtDrumDiamRatio, True, False, obj) Then
				Dim obj2 As Object = flag
				Dim lowerBound As Single = 0.5F
				Dim inclusive As Integer = -1
				Dim errnum As Integer = 18
				Dim useMetric As Integer = 0
				Dim canadianIsMetric As Integer = 0
				Dim bQuiet As Boolean = False
				Dim text As String = ""
				If Operators.ConditionalCompareObjectEqual(obj2, Util.CheckLower(obj, lowerBound, inclusive, errnum, useMetric, canadianIsMetric, bQuiet, text), False) Then
					Me.txtDrumDiamRatio.Focus()
				Else
					Dim obj3 As Object = flag
					Dim upperBound As Single = 3F
					Dim inclusive2 As Integer = -1
					Dim errnum2 As Integer = 18
					Dim useMetric2 As Integer = 0
					Dim canadianIsMetric2 As Integer = 0
					Dim bQuiet2 As Boolean = False
					text = ""
					If Operators.ConditionalCompareObjectEqual(obj3, Util.CheckUpper(obj, upperBound, inclusive2, errnum2, useMetric2, canadianIsMetric2, bQuiet2, text), False) Then
						Me.txtDrumDiamRatio.Focus()
					ElseIf Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
						Me.PULinkItem.DrumDiamRatio = Conversions.ToSingle(obj)
					End If
				End If
			End If
		End Sub

		Private Sub TextBox_Change(ByRef txt As TextBox, ByRef lbl As Label)
			If Me.ActiveControl IsNot txt Then
				CtrlUI.TextBox_LostFocus(txt, lbl, True)
			End If
			Me.ResetClock()
		End Sub

		Private Sub txtGearboxRating_TextChanged(eventSender As Object, eventArgs As EventArgs)
			Dim txtGearboxRating As TextBox = Me.txtGearboxRating
			Dim label_GearboxRating As Label = Me._Label_GearboxRating
			Me.TextBox_Change(txtGearboxRating, label_GearboxRating)
			Me._Label_GearboxRating = label_GearboxRating
			Me.txtGearboxRating = txtGearboxRating
			Me.ShowAPIDesignation()
		End Sub

		Private Sub txtGearboxRating_KeyDown(eventSender As Object, eventArgs As KeyEventArgs)
			' The following expression was wrapped in a checked-statement
			Dim num As Short = CShort(eventArgs.KeyCode)
			Dim num2 As Short = CShort((eventArgs.KeyData / Keys.Shift))
		End Sub

		Private Sub txtGearboxRating_KeyPress(eventSender As Object, eventArgs As KeyPressEventArgs)
			' The following expression was wrapped in a checked-expression
			Dim num As Short = CShort(Strings.Asc(eventArgs.KeyChar))
			If num = 0S Then
				eventArgs.Handled = True
			End If
		End Sub

		Private Sub txtGearboxRating_Leave(eventSender As Object, eventArgs As EventArgs)
			Dim txtGearboxRating As Control = Me.txtGearboxRating
			CtrlUI.Control_LostFocus(txtGearboxRating)
			Me.txtGearboxRating = CType(txtGearboxRating, TextBox)
			Dim flag As Boolean = False
			Dim obj As Object
			If flag <> CtrlUI.CheckValid(Me.txtGearboxRating, True, False, obj) Then
				Dim obj2 As Object = flag
				Dim lowerBound As Single = 15F
				Dim inclusive As Integer = -1
				Dim errnum As Integer = 24
				Dim useMetric As Integer = -1
				Dim canadianIsMetric As Integer = 0
				Dim bQuiet As Boolean = False
				Dim text As String = ""
				If Operators.ConditionalCompareObjectEqual(obj2, Util.CheckLower(obj, lowerBound, inclusive, errnum, useMetric, canadianIsMetric, bQuiet, text), False) Then
					Me.txtGearboxRating.Focus()
				Else
					Dim obj3 As Object = flag
					Dim upperBound As Single = 5000F
					Dim inclusive2 As Integer = -1
					Dim errnum2 As Integer = 24
					Dim useMetric2 As Integer = -1
					Dim canadianIsMetric2 As Integer = 0
					Dim bQuiet2 As Boolean = False
					text = ""
					If Operators.ConditionalCompareObjectEqual(obj3, Util.CheckUpper(obj, upperBound, inclusive2, errnum2, useMetric2, canadianIsMetric2, bQuiet2, text), False) Then
						Me.txtGearboxRating.Focus()
					ElseIf Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
						Me.PULinkItem.GearboxRating = Conversions.ToSingle(obj)
					End If
				End If
			End If
		End Sub

		Private Sub txtI_TextChanged(eventSender As Object, eventArgs As EventArgs)
			Dim txtI As TextBox = Me.txtI
			Dim label_ As Label = Me._Label_20
			Me.TextBox_Change(txtI, label_)
			Me._Label_20 = label_
			Me.txtI = txtI
		End Sub

		Private Sub txtI_KeyDown(eventSender As Object, eventArgs As KeyEventArgs)
			' The following expression was wrapped in a checked-statement
			Dim num As Short = CShort(eventArgs.KeyCode)
			Dim num2 As Short = CShort((eventArgs.KeyData / Keys.Shift))
		End Sub

		Private Sub txtI_KeyPress(eventSender As Object, eventArgs As KeyPressEventArgs)
			' The following expression was wrapped in a checked-expression
			Dim num As Short = CShort(Strings.Asc(eventArgs.KeyChar))
			If num = 0S Then
				eventArgs.Handled = True
			End If
		End Sub

		Private Sub txtI_Leave(eventSender As Object, eventArgs As EventArgs)
			Dim txtI As Control = Me.txtI
			CtrlUI.Control_LostFocus(txtI)
			Me.txtI = CType(txtI, TextBox)
			Dim msgtxt As String = Me.MakeAPIDimErrorMessage("I", 15F, 400F, RSWIN_DESC.ins, RSWIN_DESC.cm, RSWIN_DESC.IN__CM)
			Dim flag As Boolean = False
			Dim obj As Object
			If flag <> CtrlUI.CheckValid(Me.txtI, True, False, obj) Then
				Dim obj2 As Object = flag
				Dim lowerBound As Single = 15F
				Dim inclusive As Integer = -1
				Dim errnum As Integer = 0
				Dim useMetric As Integer = 0
				Dim canadianIsMetric As Integer = 0
				Dim bQuiet As Boolean = False
				Dim text As String = ""
				If Operators.ConditionalCompareObjectEqual(obj2, Util.CheckLower(obj, lowerBound, inclusive, errnum, useMetric, canadianIsMetric, bQuiet, text), False) Then
					Util.Errmsg(msgtxt)
					Me.txtI.Focus()
				Else
					Dim obj3 As Object = flag
					Dim upperBound As Single = 400F
					Dim inclusive2 As Integer = -1
					Dim errnum2 As Integer = 0
					Dim useMetric2 As Integer = 0
					Dim canadianIsMetric2 As Integer = 0
					Dim bQuiet2 As Boolean = False
					text = ""
					If Operators.ConditionalCompareObjectEqual(obj3, Util.CheckUpper(obj, upperBound, inclusive2, errnum2, useMetric2, canadianIsMetric2, bQuiet2, text), False) Then
						Util.Errmsg(msgtxt)
						Me.txtI.Focus()
					ElseIf Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
						Me.PULinkItem.I = Conversions.ToSingle(obj)
					End If
				End If
			End If
		End Sub

		Private Sub txtK_TextChanged(eventSender As Object, eventArgs As EventArgs)
			Dim txtK As TextBox = Me.txtK
			Dim label_ As Label = Me._Label_21
			Me.TextBox_Change(txtK, label_)
			Me._Label_21 = label_
			Me.txtK = txtK
			Me.ShowUnitStroke(-1S)
		End Sub

		Private Sub txtK_KeyDown(eventSender As Object, eventArgs As KeyEventArgs)
			' The following expression was wrapped in a checked-statement
			Dim num As Short = CShort(eventArgs.KeyCode)
			Dim num2 As Short = CShort((eventArgs.KeyData / Keys.Shift))
		End Sub

		Private Sub txtK_KeyPress(eventSender As Object, eventArgs As KeyPressEventArgs)
			' The following expression was wrapped in a checked-expression
			Dim num As Short = CShort(Strings.Asc(eventArgs.KeyChar))
			If num = 0S Then
				eventArgs.Handled = True
			End If
		End Sub

		Private Sub txtK_Leave(eventSender As Object, eventArgs As EventArgs)
			Dim txtK As Control = Me.txtK
			CtrlUI.Control_LostFocus(txtK)
			Me.txtK = CType(txtK, TextBox)
			Dim msgtxt As String = Me.MakeAPIDimErrorMessage("K", 25F, 400F, RSWIN_DESC.ins, RSWIN_DESC.cm, RSWIN_DESC.IN__CM)
			Dim flag As Boolean = False
			Dim obj As Object
			If flag <> CtrlUI.CheckValid(Me.txtK, True, False, obj) Then
				Dim obj2 As Object = flag
				Dim lowerBound As Single = 25F
				Dim inclusive As Integer = -1
				Dim errnum As Integer = 0
				Dim useMetric As Integer = 0
				Dim canadianIsMetric As Integer = 0
				Dim bQuiet As Boolean = False
				Dim text As String = ""
				If Operators.ConditionalCompareObjectEqual(obj2, Util.CheckLower(obj, lowerBound, inclusive, errnum, useMetric, canadianIsMetric, bQuiet, text), False) Then
					Util.Errmsg(msgtxt)
					Me.txtK.Focus()
				Else
					Dim obj3 As Object = flag
					Dim upperBound As Single = 400F
					Dim inclusive2 As Integer = -1
					Dim errnum2 As Integer = 0
					Dim useMetric2 As Integer = 0
					Dim canadianIsMetric2 As Integer = 0
					Dim bQuiet2 As Boolean = False
					text = ""
					If Operators.ConditionalCompareObjectEqual(obj3, Util.CheckUpper(obj, upperBound, inclusive2, errnum2, useMetric2, canadianIsMetric2, bQuiet2, text), False) Then
						Util.Errmsg(msgtxt)
						Me.txtK.Focus()
					ElseIf Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
						Me.PULinkItem.K = Conversions.ToSingle(obj)
					End If
				End If
			End If
		End Sub

		Private Sub txtI_ABAL_TextChanged(eventSender As Object, eventArgs As EventArgs)
			Dim txtI_ABAL As TextBox = Me.txtI_ABAL
			Dim label_I_ABAL As Label = Me.Label_I_ABAL
			Me.TextBox_Change(txtI_ABAL, label_I_ABAL)
			Me.Label_I_ABAL = label_I_ABAL
			Me.txtI_ABAL = txtI_ABAL
		End Sub

		Private Sub txtI_ABAL_KeyDown(eventSender As Object, eventArgs As KeyEventArgs)
			' The following expression was wrapped in a checked-statement
			Dim num As Short = CShort(eventArgs.KeyCode)
			Dim num2 As Short = CShort((eventArgs.KeyData / Keys.Shift))
		End Sub

		Private Sub txtI_ABAL_KeyPress(eventSender As Object, eventArgs As KeyPressEventArgs)
			' The following expression was wrapped in a checked-expression
			Dim num As Short = CShort(Strings.Asc(eventArgs.KeyChar))
			If num = 0S Then
				eventArgs.Handled = True
			End If
		End Sub

		Private Sub txtI_ABAL_Leave(eventSender As Object, eventArgs As EventArgs)
			Dim txtI_ABAL As Control = Me.txtI_ABAL
			CtrlUI.Control_LostFocus(txtI_ABAL)
			Me.txtI_ABAL = CType(txtI_ABAL, TextBox)
			Dim msgtxt As String = Me.MakeAPIDimErrorMessage("I", 15F, 400F, RSWIN_DESC.ins, RSWIN_DESC.cm, RSWIN_DESC.IN__CM)
			Dim flag As Boolean = False
			Dim obj As Object
			If flag <> CtrlUI.CheckValid(Me.txtI_ABAL, True, False, obj) Then
				Dim obj2 As Object = flag
				Dim lowerBound As Single = 15F
				Dim inclusive As Integer = -1
				Dim errnum As Integer = 0
				Dim useMetric As Integer = 0
				Dim canadianIsMetric As Integer = 0
				Dim bQuiet As Boolean = False
				Dim text As String = ""
				If Operators.ConditionalCompareObjectEqual(obj2, Util.CheckLower(obj, lowerBound, inclusive, errnum, useMetric, canadianIsMetric, bQuiet, text), False) Then
					Util.Errmsg(msgtxt)
					Me.txtI_ABAL.Focus()
				Else
					Dim obj3 As Object = flag
					Dim upperBound As Single = 400F
					Dim inclusive2 As Integer = -1
					Dim errnum2 As Integer = 0
					Dim useMetric2 As Integer = 0
					Dim canadianIsMetric2 As Integer = 0
					Dim bQuiet2 As Boolean = False
					text = ""
					If Operators.ConditionalCompareObjectEqual(obj3, Util.CheckUpper(obj, upperBound, inclusive2, errnum2, useMetric2, canadianIsMetric2, bQuiet2, text), False) Then
						Util.Errmsg(msgtxt)
						Me.txtI_ABAL.Focus()
					ElseIf Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
						Me.PULinkItem.I = Conversions.ToSingle(obj)
					End If
				End If
			End If
		End Sub

		Private Sub txtK_ABAL_TextChanged(eventSender As Object, eventArgs As EventArgs)
			Dim txtK_ABAL As TextBox = Me.txtK_ABAL
			Dim label_K_ABAL As Label = Me.Label_K_ABAL
			Me.TextBox_Change(txtK_ABAL, label_K_ABAL)
			Me.Label_K_ABAL = label_K_ABAL
			Me.txtK_ABAL = txtK_ABAL
			Me.ShowUnitStroke(-1S)
		End Sub

		Private Sub txtK_ABAL_KeyDown(eventSender As Object, eventArgs As KeyEventArgs)
			' The following expression was wrapped in a checked-statement
			Dim num As Short = CShort(eventArgs.KeyCode)
			Dim num2 As Short = CShort((eventArgs.KeyData / Keys.Shift))
		End Sub

		Private Sub txtK_ABAL_KeyPress(eventSender As Object, eventArgs As KeyPressEventArgs)
			' The following expression was wrapped in a checked-expression
			Dim num As Short = CShort(Strings.Asc(eventArgs.KeyChar))
			If num = 0S Then
				eventArgs.Handled = True
			End If
		End Sub

		Private Sub txtK_ABAL_Leave(eventSender As Object, eventArgs As EventArgs)
			Dim txtK_ABAL As Control = Me.txtK_ABAL
			CtrlUI.Control_LostFocus(txtK_ABAL)
			Me.txtK_ABAL = CType(txtK_ABAL, TextBox)
			Dim msgtxt As String = Me.MakeAPIDimErrorMessage("K", 25F, 400F, RSWIN_DESC.ins, RSWIN_DESC.cm, RSWIN_DESC.IN__CM)
			Dim flag As Boolean = False
			Dim obj As Object
			If flag <> CtrlUI.CheckValid(Me.txtK_ABAL, True, False, obj) Then
				Dim obj2 As Object = flag
				Dim lowerBound As Single = 25F
				Dim inclusive As Integer = -1
				Dim errnum As Integer = 0
				Dim useMetric As Integer = 0
				Dim canadianIsMetric As Integer = 0
				Dim bQuiet As Boolean = False
				Dim text As String = ""
				If Operators.ConditionalCompareObjectEqual(obj2, Util.CheckLower(obj, lowerBound, inclusive, errnum, useMetric, canadianIsMetric, bQuiet, text), False) Then
					Util.Errmsg(msgtxt)
					Me.txtK_ABAL.Focus()
				Else
					Dim obj3 As Object = flag
					Dim upperBound As Single = 400F
					Dim inclusive2 As Integer = -1
					Dim errnum2 As Integer = 0
					Dim useMetric2 As Integer = 0
					Dim canadianIsMetric2 As Integer = 0
					Dim bQuiet2 As Boolean = False
					text = ""
					If Operators.ConditionalCompareObjectEqual(obj3, Util.CheckUpper(obj, upperBound, inclusive2, errnum2, useMetric2, canadianIsMetric2, bQuiet2, text), False) Then
						Util.Errmsg(msgtxt)
						Me.txtK_ABAL.Focus()
					ElseIf Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
						Me.PULinkItem.K = Conversions.ToSingle(obj)
					End If
				End If
			End If
		End Sub

		Private Sub txtI_MII_TextChanged(eventSender As Object, eventArgs As EventArgs)
			Dim txtI_MII As TextBox = Me.txtI_MII
			Dim label_I_MII As Label = Me.Label_I_MII
			Me.TextBox_Change(txtI_MII, label_I_MII)
			Me.Label_I_MII = label_I_MII
			Me.txtI_MII = txtI_MII
		End Sub

		Private Sub txtI_MII_KeyDown(eventSender As Object, eventArgs As KeyEventArgs)
			' The following expression was wrapped in a checked-statement
			Dim num As Short = CShort(eventArgs.KeyCode)
			Dim num2 As Short = CShort((eventArgs.KeyData / Keys.Shift))
		End Sub

		Private Sub txtI_MII_KeyPress(eventSender As Object, eventArgs As KeyPressEventArgs)
			' The following expression was wrapped in a checked-expression
			Dim num As Short = CShort(Strings.Asc(eventArgs.KeyChar))
			If num = 0S Then
				eventArgs.Handled = True
			End If
		End Sub

		Private Sub txtI_MII_Leave(eventSender As Object, eventArgs As EventArgs)
			Dim txtI_MII As Control = Me.txtI_MII
			CtrlUI.Control_LostFocus(txtI_MII)
			Me.txtI_MII = CType(txtI_MII, TextBox)
			Dim msgtxt As String = Me.MakeAPIDimErrorMessage("I", 15F, 400F, RSWIN_DESC.ins, RSWIN_DESC.cm, RSWIN_DESC.IN__CM)
			Dim flag As Boolean = False
			Dim obj As Object
			If flag <> CtrlUI.CheckValid(Me.txtI_MII, True, False, obj) Then
				Dim obj2 As Object = flag
				Dim lowerBound As Single = 15F
				Dim inclusive As Integer = -1
				Dim errnum As Integer = 0
				Dim useMetric As Integer = 0
				Dim canadianIsMetric As Integer = 0
				Dim bQuiet As Boolean = False
				Dim text As String = ""
				If Operators.ConditionalCompareObjectEqual(obj2, Util.CheckLower(obj, lowerBound, inclusive, errnum, useMetric, canadianIsMetric, bQuiet, text), False) Then
					Util.Errmsg(msgtxt)
					Me.txtI_MII.Focus()
				Else
					Dim obj3 As Object = flag
					Dim upperBound As Single = 400F
					Dim inclusive2 As Integer = -1
					Dim errnum2 As Integer = 0
					Dim useMetric2 As Integer = 0
					Dim canadianIsMetric2 As Integer = 0
					Dim bQuiet2 As Boolean = False
					text = ""
					If Operators.ConditionalCompareObjectEqual(obj3, Util.CheckUpper(obj, upperBound, inclusive2, errnum2, useMetric2, canadianIsMetric2, bQuiet2, text), False) Then
						Util.Errmsg(msgtxt)
						Me.txtI_MII.Focus()
					ElseIf Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
						Me.PULinkItem.I = Conversions.ToSingle(obj)
					End If
				End If
			End If
		End Sub

		Private Sub txtK_MII_TextChanged(eventSender As Object, eventArgs As EventArgs)
			Dim txtK_MII As TextBox = Me.txtK_MII
			Dim label_K_MII As Label = Me.Label_K_MII
			Me.TextBox_Change(txtK_MII, label_K_MII)
			Me.Label_K_MII = label_K_MII
			Me.txtK_MII = txtK_MII
			Me.ShowUnitStroke(-1S)
		End Sub

		Private Sub txtK_MII_KeyDown(eventSender As Object, eventArgs As KeyEventArgs)
			' The following expression was wrapped in a checked-statement
			Dim num As Short = CShort(eventArgs.KeyCode)
			Dim num2 As Short = CShort((eventArgs.KeyData / Keys.Shift))
		End Sub

		Private Sub txtK_MII_KeyPress(eventSender As Object, eventArgs As KeyPressEventArgs)
			' The following expression was wrapped in a checked-expression
			Dim num As Short = CShort(Strings.Asc(eventArgs.KeyChar))
			If num = 0S Then
				eventArgs.Handled = True
			End If
		End Sub

		Private Sub txtK_MII_Leave(eventSender As Object, eventArgs As EventArgs)
			Dim txtK_MII As Control = Me.txtK_MII
			CtrlUI.Control_LostFocus(txtK_MII)
			Me.txtK_MII = CType(txtK_MII, TextBox)
			Dim msgtxt As String = Me.MakeAPIDimErrorMessage("K", 25F, 400F, RSWIN_DESC.ins, RSWIN_DESC.cm, RSWIN_DESC.IN__CM)
			Dim flag As Boolean = False
			Dim obj As Object
			If flag <> CtrlUI.CheckValid(Me.txtK_MII, True, False, obj) Then
				Dim obj2 As Object = flag
				Dim lowerBound As Single = 25F
				Dim inclusive As Integer = -1
				Dim errnum As Integer = 0
				Dim useMetric As Integer = 0
				Dim canadianIsMetric As Integer = 0
				Dim bQuiet As Boolean = False
				Dim text As String = ""
				If Operators.ConditionalCompareObjectEqual(obj2, Util.CheckLower(obj, lowerBound, inclusive, errnum, useMetric, canadianIsMetric, bQuiet, text), False) Then
					Util.Errmsg(msgtxt)
					Me.txtK_MII.Focus()
				Else
					Dim obj3 As Object = flag
					Dim upperBound As Single = 400F
					Dim inclusive2 As Integer = -1
					Dim errnum2 As Integer = 0
					Dim useMetric2 As Integer = 0
					Dim canadianIsMetric2 As Integer = 0
					Dim bQuiet2 As Boolean = False
					text = ""
					If Operators.ConditionalCompareObjectEqual(obj3, Util.CheckUpper(obj, upperBound, inclusive2, errnum2, useMetric2, canadianIsMetric2, bQuiet2, text), False) Then
						Util.Errmsg(msgtxt)
						Me.txtK_MII.Focus()
					ElseIf Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
						Me.PULinkItem.K = Conversions.ToSingle(obj)
					End If
				End If
			End If
		End Sub

		Private Sub txtM_TextChanged(eventSender As Object, eventArgs As EventArgs)
			Dim txtM As TextBox = Me.txtM
			Dim label_ As Label = Me._Label_25
			Me.TextBox_Change(txtM, label_)
			Me._Label_25 = label_
			Me.txtM = txtM
		End Sub

		Private Sub txtM_KeyDown(eventSender As Object, eventArgs As KeyEventArgs)
			' The following expression was wrapped in a checked-statement
			Dim num As Short = CShort(eventArgs.KeyCode)
			Dim num2 As Short = CShort((eventArgs.KeyData / Keys.Shift))
		End Sub

		Private Sub txtM_KeyPress(eventSender As Object, eventArgs As KeyPressEventArgs)
			' The following expression was wrapped in a checked-expression
			Dim num As Short = CShort(Strings.Asc(eventArgs.KeyChar))
			If num = 0S Then
				eventArgs.Handled = True
			End If
		End Sub

		Private Sub txtM_Leave(eventSender As Object, eventArgs As EventArgs)
			Dim txtM As Control = Me.txtM
			CtrlUI.Control_LostFocus(txtM)
			Me.txtM = CType(txtM, TextBox)
			Dim msgtxt As String = Me.MakeAPIDimErrorMessage("M", 10F, 200F, "in²", "cm²", CSng(Math.Pow(CDbl(RSWIN_DESC.IN__CM), 2.0)))
			Dim flag As Boolean = False
			Dim obj As Object
			If flag <> CtrlUI.CheckValid(Me.txtM, True, False, obj) Then
				Dim obj2 As Object = flag
				Dim lowerBound As Single = 10F
				Dim inclusive As Integer = -1
				Dim errnum As Integer = 0
				Dim useMetric As Integer = 0
				Dim canadianIsMetric As Integer = 0
				Dim bQuiet As Boolean = False
				Dim text As String = ""
				If Operators.ConditionalCompareObjectEqual(obj2, Util.CheckLower(obj, lowerBound, inclusive, errnum, useMetric, canadianIsMetric, bQuiet, text), False) Then
					Util.Errmsg(msgtxt)
					Me.txtM.Focus()
				Else
					Dim obj3 As Object = flag
					Dim upperBound As Single = 200F
					Dim inclusive2 As Integer = -1
					Dim errnum2 As Integer = 0
					Dim useMetric2 As Integer = 0
					Dim canadianIsMetric2 As Integer = 0
					Dim bQuiet2 As Boolean = False
					text = ""
					If Operators.ConditionalCompareObjectEqual(obj3, Util.CheckUpper(obj, upperBound, inclusive2, errnum2, useMetric2, canadianIsMetric2, bQuiet2, text), False) Then
						Util.Errmsg(msgtxt)
						Me.txtM.Focus()
					ElseIf Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
						Me.PULinkItem.M = Conversions.ToSingle(obj)
					End If
				End If
			End If
		End Sub

		Private Sub txtManufacturer_TextChanged(eventSender As Object, eventArgs As EventArgs)
			Dim txtManufacturer As TextBox = Me.txtManufacturer
			Dim label_ As Label = Me._Label_0
			Me.TextBox_Change(txtManufacturer, label_)
			Me._Label_0 = label_
			Me.txtManufacturer = txtManufacturer
		End Sub

		Private Sub txtManufacturer_KeyDown(eventSender As Object, eventArgs As KeyEventArgs)
			' The following expression was wrapped in a checked-statement
			Dim num As Short = CShort(eventArgs.KeyCode)
			Dim num2 As Short = CShort((eventArgs.KeyData / Keys.Shift))
		End Sub

		Private Sub txtManufacturer_KeyPress(eventSender As Object, eventArgs As KeyPressEventArgs)
			' The following expression was wrapped in a checked-expression
			Dim num As Short = CShort(Strings.Asc(eventArgs.KeyChar))
			If num = 0S Then
				eventArgs.Handled = True
			End If
		End Sub

		Private Sub txtMaxStroke_TextChanged(eventSender As Object, eventArgs As EventArgs)
			Dim txtMaxStroke As TextBox = Me.txtMaxStroke
			Dim label_ As Label = Me._Label_6
			Me.TextBox_Change(txtMaxStroke, label_)
			Me._Label_6 = label_
			Me.txtMaxStroke = txtMaxStroke
			Me.ShowAPIDesignation()
		End Sub

		Private Sub txtMaxStroke_KeyDown(eventSender As Object, eventArgs As KeyEventArgs)
			' The following expression was wrapped in a checked-statement
			Dim num As Short = CShort(eventArgs.KeyCode)
			Dim num2 As Short = CShort((eventArgs.KeyData / Keys.Shift))
		End Sub

		Private Sub txtMaxStroke_KeyPress(eventSender As Object, eventArgs As KeyPressEventArgs)
			' The following expression was wrapped in a checked-expression
			Dim num As Short = CShort(Strings.Asc(eventArgs.KeyChar))
			If num = 0S Then
				eventArgs.Handled = True
			End If
		End Sub

		Private Sub txtMaxStroke_Leave(eventSender As Object, eventArgs As EventArgs)
			Dim txtMaxStroke As Control = Me.txtMaxStroke
			CtrlUI.Control_LostFocus(txtMaxStroke)
			Me.txtMaxStroke = CType(txtMaxStroke, TextBox)
			Dim flag As Boolean = False
			Dim obj As Object
			If flag <> CtrlUI.CheckValid(Me.txtMaxStroke, True, False, obj) Then
				Dim obj2 As Object = flag
				Dim lowerBound As Single = 12F
				Dim inclusive As Integer = -1
				Dim errnum As Integer = 28
				Dim useMetric As Integer = -1
				Dim canadianIsMetric As Integer = -1
				Dim bQuiet As Boolean = False
				Dim text As String = ""
				If Operators.ConditionalCompareObjectEqual(obj2, Util.CheckLower(obj, lowerBound, inclusive, errnum, useMetric, canadianIsMetric, bQuiet, text), False) Then
					Me.txtMaxStroke.Focus()
				Else
					Dim obj3 As Object = flag
					Dim upperBound As Single = 500F
					Dim inclusive2 As Integer = -1
					Dim errnum2 As Integer = 28
					Dim useMetric2 As Integer = -1
					Dim canadianIsMetric2 As Integer = -1
					Dim bQuiet2 As Boolean = False
					text = ""
					If Operators.ConditionalCompareObjectEqual(obj3, Util.CheckUpper(obj, upperBound, inclusive2, errnum2, useMetric2, canadianIsMetric2, bQuiet2, text), False) Then
						Me.txtMaxStroke.Focus()
					ElseIf Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
						Me.PULinkItem.MaxStroke = Conversions.ToSingle(obj)
					End If
				End If
			End If
		End Sub

		Private Sub txtOtherInfo_TextChanged(eventSender As Object, eventArgs As EventArgs)
			Dim txtOtherInfo As TextBox = Me.txtOtherInfo
			Dim label_ As Label = Me._Label_2
			Me.TextBox_Change(txtOtherInfo, label_)
			Me._Label_2 = label_
			Me.txtOtherInfo = txtOtherInfo
		End Sub

		Private Sub txtOtherInfo_KeyDown(eventSender As Object, eventArgs As KeyEventArgs)
			' The following expression was wrapped in a checked-statement
			Dim num As Short = CShort(eventArgs.KeyCode)
			Dim num2 As Short = CShort((eventArgs.KeyData / Keys.Shift))
		End Sub

		Private Sub txtOtherInfo_KeyPress(eventSender As Object, eventArgs As KeyPressEventArgs)
			' The following expression was wrapped in a checked-expression
			Dim num As Short = CShort(Strings.Asc(eventArgs.KeyChar))
			If num = 0S Then
				eventArgs.Handled = True
			End If
		End Sub

		Private Sub txtOtherInfo_Leave(eventSender As Object, eventArgs As EventArgs)
			Dim txtOtherInfo As Control = Me.txtOtherInfo
			CtrlUI.Control_LostFocus(txtOtherInfo)
			Me.txtOtherInfo = CType(txtOtherInfo, TextBox)
		End Sub

		Private Sub txtP_TextChanged(eventSender As Object, eventArgs As EventArgs)
			Dim txtP As TextBox = Me.txtP
			Dim label_ As Label = Me._Label_22
			Me.TextBox_Change(txtP, label_)
			Me._Label_22 = label_
			Me.txtP = txtP
			Me.ShowUnitStroke(-1S)
		End Sub

		Private Sub txtP_KeyDown(eventSender As Object, eventArgs As KeyEventArgs)
			' The following expression was wrapped in a checked-statement
			Dim num As Short = CShort(eventArgs.KeyCode)
			Dim num2 As Short = CShort((eventArgs.KeyData / Keys.Shift))
		End Sub

		Private Sub txtP_KeyPress(eventSender As Object, eventArgs As KeyPressEventArgs)
			' The following expression was wrapped in a checked-expression
			Dim num As Short = CShort(Strings.Asc(eventArgs.KeyChar))
			If num = 0S Then
				eventArgs.Handled = True
			End If
		End Sub

		Private Sub txtP_Leave(eventSender As Object, eventArgs As EventArgs)
			Dim txtP As Control = Me.txtP
			CtrlUI.Control_LostFocus(txtP)
			Me.txtP = CType(txtP, TextBox)
			Dim msgtxt As String = Me.MakeAPIDimErrorMessage("P", 15F, 400F, RSWIN_DESC.ins, RSWIN_DESC.cm, RSWIN_DESC.IN__CM)
			Dim flag As Boolean = False
			Dim obj As Object
			If flag <> CtrlUI.CheckValid(Me.txtP, True, False, obj) Then
				Dim obj2 As Object = flag
				Dim lowerBound As Single = 15F
				Dim inclusive As Integer = -1
				Dim errnum As Integer = 0
				Dim useMetric As Integer = 0
				Dim canadianIsMetric As Integer = 0
				Dim bQuiet As Boolean = False
				Dim text As String = ""
				If Operators.ConditionalCompareObjectEqual(obj2, Util.CheckLower(obj, lowerBound, inclusive, errnum, useMetric, canadianIsMetric, bQuiet, text), False) Then
					Util.Errmsg(msgtxt)
					Me.txtP.Focus()
				Else
					Dim obj3 As Object = flag
					Dim upperBound As Single = 400F
					Dim inclusive2 As Integer = -1
					Dim errnum2 As Integer = 0
					Dim useMetric2 As Integer = 0
					Dim canadianIsMetric2 As Integer = 0
					Dim bQuiet2 As Boolean = False
					text = ""
					If Operators.ConditionalCompareObjectEqual(obj3, Util.CheckUpper(obj, upperBound, inclusive2, errnum2, useMetric2, canadianIsMetric2, bQuiet2, text), False) Then
						Util.Errmsg(msgtxt)
						Me.txtP.Focus()
					ElseIf Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
						Me.PULinkItem.P = Conversions.ToSingle(obj)
					End If
				End If
			End If
		End Sub

		Private Sub txtP_ABAL_TextChanged(eventSender As Object, eventArgs As EventArgs)
			Dim txtP_ABAL As TextBox = Me.txtP_ABAL
			Dim label_P_ABAL As Label = Me.Label_P_ABAL
			Me.TextBox_Change(txtP_ABAL, label_P_ABAL)
			Me.Label_P_ABAL = label_P_ABAL
			Me.txtP_ABAL = txtP_ABAL
			Me.ShowUnitStroke(-1S)
		End Sub

		Private Sub txtP_ABAL_KeyDown(eventSender As Object, eventArgs As KeyEventArgs)
			' The following expression was wrapped in a checked-statement
			Dim num As Short = CShort(eventArgs.KeyCode)
			Dim num2 As Short = CShort((eventArgs.KeyData / Keys.Shift))
		End Sub

		Private Sub txtP_ABAL_KeyPress(eventSender As Object, eventArgs As KeyPressEventArgs)
			' The following expression was wrapped in a checked-expression
			Dim num As Short = CShort(Strings.Asc(eventArgs.KeyChar))
			If num = 0S Then
				eventArgs.Handled = True
			End If
		End Sub

		Private Sub txtP_ABAL_Leave(eventSender As Object, eventArgs As EventArgs)
			Dim txtP_ABAL As Control = Me.txtP_ABAL
			CtrlUI.Control_LostFocus(txtP_ABAL)
			Me.txtP_ABAL = CType(txtP_ABAL, TextBox)
			Dim msgtxt As String = Me.MakeAPIDimErrorMessage("P", 15F, 400F, RSWIN_DESC.ins, RSWIN_DESC.cm, RSWIN_DESC.IN__CM)
			Dim flag As Boolean = False
			Dim obj As Object
			If flag <> CtrlUI.CheckValid(Me.txtP_ABAL, True, False, obj) Then
				Dim obj2 As Object = flag
				Dim lowerBound As Single = 15F
				Dim inclusive As Integer = -1
				Dim errnum As Integer = 0
				Dim useMetric As Integer = 0
				Dim canadianIsMetric As Integer = 0
				Dim bQuiet As Boolean = False
				Dim text As String = ""
				If Operators.ConditionalCompareObjectEqual(obj2, Util.CheckLower(obj, lowerBound, inclusive, errnum, useMetric, canadianIsMetric, bQuiet, text), False) Then
					Util.Errmsg(msgtxt)
					Me.txtP_ABAL.Focus()
				Else
					Dim obj3 As Object = flag
					Dim upperBound As Single = 400F
					Dim inclusive2 As Integer = -1
					Dim errnum2 As Integer = 0
					Dim useMetric2 As Integer = 0
					Dim canadianIsMetric2 As Integer = 0
					Dim bQuiet2 As Boolean = False
					text = ""
					If Operators.ConditionalCompareObjectEqual(obj3, Util.CheckUpper(obj, upperBound, inclusive2, errnum2, useMetric2, canadianIsMetric2, bQuiet2, text), False) Then
						Util.Errmsg(msgtxt)
						Me.txtP_ABAL.Focus()
					ElseIf Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
						Me.PULinkItem.P = Conversions.ToSingle(obj)
					End If
				End If
			End If
		End Sub

		Private Sub txtP_MII_TextChanged(eventSender As Object, eventArgs As EventArgs)
			Dim txtP_MII As TextBox = Me.txtP_MII
			Dim label_P_MII As Label = Me.Label_P_MII
			Me.TextBox_Change(txtP_MII, label_P_MII)
			Me.Label_P_MII = label_P_MII
			Me.txtP_MII = txtP_MII
			Me.ShowUnitStroke(-1S)
		End Sub

		Private Sub txtP_MII_KeyDown(eventSender As Object, eventArgs As KeyEventArgs)
			' The following expression was wrapped in a checked-statement
			Dim num As Short = CShort(eventArgs.KeyCode)
			Dim num2 As Short = CShort((eventArgs.KeyData / Keys.Shift))
		End Sub

		Private Sub txtP_MII_KeyPress(eventSender As Object, eventArgs As KeyPressEventArgs)
			' The following expression was wrapped in a checked-expression
			Dim num As Short = CShort(Strings.Asc(eventArgs.KeyChar))
			If num = 0S Then
				eventArgs.Handled = True
			End If
		End Sub

		Private Sub txtP_MII_Leave(eventSender As Object, eventArgs As EventArgs)
			Dim txtP_MII As Control = Me.txtP_MII
			CtrlUI.Control_LostFocus(txtP_MII)
			Me.txtP_MII = CType(txtP_MII, TextBox)
			Dim msgtxt As String = Me.MakeAPIDimErrorMessage("P", 15F, 400F, RSWIN_DESC.ins, RSWIN_DESC.cm, RSWIN_DESC.IN__CM)
			Dim flag As Boolean = False
			Dim obj As Object
			If flag <> CtrlUI.CheckValid(Me.txtP_MII, True, False, obj) Then
				Dim obj2 As Object = flag
				Dim lowerBound As Single = 15F
				Dim inclusive As Integer = -1
				Dim errnum As Integer = 0
				Dim useMetric As Integer = 0
				Dim canadianIsMetric As Integer = 0
				Dim bQuiet As Boolean = False
				Dim text As String = ""
				If Operators.ConditionalCompareObjectEqual(obj2, Util.CheckLower(obj, lowerBound, inclusive, errnum, useMetric, canadianIsMetric, bQuiet, text), False) Then
					Util.Errmsg(msgtxt)
					Me.txtP_MII.Focus()
				Else
					Dim obj3 As Object = flag
					Dim upperBound As Single = 400F
					Dim inclusive2 As Integer = -1
					Dim errnum2 As Integer = 0
					Dim useMetric2 As Integer = 0
					Dim canadianIsMetric2 As Integer = 0
					Dim bQuiet2 As Boolean = False
					text = ""
					If Operators.ConditionalCompareObjectEqual(obj3, Util.CheckUpper(obj, upperBound, inclusive2, errnum2, useMetric2, canadianIsMetric2, bQuiet2, text), False) Then
						Util.Errmsg(msgtxt)
						Me.txtP_MII.Focus()
					ElseIf Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
						Me.PULinkItem.P = Conversions.ToSingle(obj)
					End If
				End If
			End If
		End Sub

		Private Sub txtPitmanLength_TextChanged(eventSender As Object, eventArgs As EventArgs)
			Dim txtPitmanLength As TextBox = Me.txtPitmanLength
			Dim label_ As Label = Me._Label_17
			Me.TextBox_Change(txtPitmanLength, label_)
			Me._Label_17 = label_
			Me.txtPitmanLength = txtPitmanLength
		End Sub

		Private Sub txtPitmanLength_KeyDown(eventSender As Object, eventArgs As KeyEventArgs)
			' The following expression was wrapped in a checked-statement
			Dim num As Short = CShort(eventArgs.KeyCode)
			Dim num2 As Short = CShort((eventArgs.KeyData / Keys.Shift))
		End Sub

		Private Sub txtPitmanLength_KeyPress(eventSender As Object, eventArgs As KeyPressEventArgs)
			' The following expression was wrapped in a checked-expression
			Dim num As Short = CShort(Strings.Asc(eventArgs.KeyChar))
			If num = 0S Then
				eventArgs.Handled = True
			End If
		End Sub

		Private Sub txtPitmanLength_Leave(eventSender As Object, eventArgs As EventArgs)
			Dim txtPitmanLength As Control = Me.txtPitmanLength
			CtrlUI.Control_LostFocus(txtPitmanLength)
			Me.txtPitmanLength = CType(txtPitmanLength, TextBox)
			Dim obj As Object
			If Versioned.IsNumeric(Me.txtPitmanLength) AndAlso CtrlUI.CheckValid(Me.txtPitmanLength, False, False, obj) Then
				Me.PULinkItem.P = Conversions.ToSingle(obj)
			End If
		End Sub

		Private Sub txtR_1_Leave(eventSender As Object, eventArgs As EventArgs)
			Dim msgtxt As String = Me.MakeAPIDimErrorMessage("R", 5F, 100F, RSWIN_DESC.ins, RSWIN_DESC.cm, RSWIN_DESC.IN__CM)
			Dim flag As Boolean = False
			Dim obj As Object
			If flag <> CtrlUI.CheckValid(Me._txtR_1, True, False, obj) Then
				Dim obj2 As Object = flag
				Dim lowerBound As Single = 5F
				Dim inclusive As Integer = -1
				Dim errnum As Integer = 0
				Dim useMetric As Integer = 0
				Dim canadianIsMetric As Integer = 0
				Dim bQuiet As Boolean = False
				Dim text As String = ""
				If Operators.ConditionalCompareObjectEqual(obj2, Util.CheckLower(obj, lowerBound, inclusive, errnum, useMetric, canadianIsMetric, bQuiet, text), False) Then
					Util.Errmsg(msgtxt)
					Me._txtR_1.Focus()
				Else
					Dim obj3 As Object = flag
					Dim upperBound As Single = 100F
					Dim inclusive2 As Integer = -1
					Dim errnum2 As Integer = 0
					Dim useMetric2 As Integer = 0
					Dim canadianIsMetric2 As Integer = 0
					Dim bQuiet2 As Boolean = False
					text = ""
					If Operators.ConditionalCompareObjectEqual(obj3, Util.CheckUpper(obj, upperBound, inclusive2, errnum2, useMetric2, canadianIsMetric2, bQuiet2, text), False) Then
						Util.Errmsg(msgtxt)
						Me._txtR_1.Focus()
					Else
						Dim txtR_ As TextBox = Me._txtR_1
						Dim label_ As Label = Me._Label_9
						CtrlUI.TextBox_LostFocus(txtR_, label_, True)
						Me._Label_9 = label_
						Me._txtR_1 = txtR_
						If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
							Me.PULinkItem.CrankRadii(0) = Conversions.ToSingle(obj)
						End If
					End If
				End If
			End If
		End Sub

		Private Sub txtR_2_Leave(eventSender As Object, eventArgs As EventArgs)
			Dim msgtxt As String = Me.MakeAPIDimErrorMessage("R", 5F, 100F, RSWIN_DESC.ins, RSWIN_DESC.cm, RSWIN_DESC.IN__CM)
			Dim flag As Boolean = False
			Dim obj As Object
			If flag <> CtrlUI.CheckValid(Me._txtR_2, True, False, obj) Then
				Dim obj2 As Object = flag
				Dim lowerBound As Single = 5F
				Dim inclusive As Integer = -1
				Dim errnum As Integer = 0
				Dim useMetric As Integer = 0
				Dim canadianIsMetric As Integer = 0
				Dim bQuiet As Boolean = False
				Dim text As String = ""
				If Operators.ConditionalCompareObjectEqual(obj2, Util.CheckLower(obj, lowerBound, inclusive, errnum, useMetric, canadianIsMetric, bQuiet, text), False) Then
					Util.Errmsg(msgtxt)
					Me._txtR_2.Focus()
				Else
					Dim obj3 As Object = flag
					Dim upperBound As Single = 100F
					Dim inclusive2 As Integer = -1
					Dim errnum2 As Integer = 0
					Dim useMetric2 As Integer = 0
					Dim canadianIsMetric2 As Integer = 0
					Dim bQuiet2 As Boolean = False
					text = ""
					If Operators.ConditionalCompareObjectEqual(obj3, Util.CheckUpper(obj, upperBound, inclusive2, errnum2, useMetric2, canadianIsMetric2, bQuiet2, text), False) Then
						Util.Errmsg(msgtxt)
						Me._txtR_2.Focus()
					Else
						Dim txtR_ As TextBox = Me._txtR_2
						Dim label_ As Label = Me._Label_10
						CtrlUI.TextBox_LostFocus(txtR_, label_, True)
						Me._Label_10 = label_
						Me._txtR_2 = txtR_
						If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
							Me.PULinkItem.CrankRadii(1) = Conversions.ToSingle(obj)
						End If
					End If
				End If
			End If
		End Sub

		Private Sub txtR_3_Leave(eventSender As Object, eventArgs As EventArgs)
			Dim msgtxt As String = Me.MakeAPIDimErrorMessage("R", 5F, 100F, RSWIN_DESC.ins, RSWIN_DESC.cm, RSWIN_DESC.IN__CM)
			Dim flag As Boolean = False
			Dim obj As Object
			If flag <> CtrlUI.CheckValid(Me._txtR_3, True, False, obj) Then
				Dim obj2 As Object = flag
				Dim lowerBound As Single = 5F
				Dim inclusive As Integer = -1
				Dim errnum As Integer = 0
				Dim useMetric As Integer = 0
				Dim canadianIsMetric As Integer = 0
				Dim bQuiet As Boolean = False
				Dim text As String = ""
				If Operators.ConditionalCompareObjectEqual(obj2, Util.CheckLower(obj, lowerBound, inclusive, errnum, useMetric, canadianIsMetric, bQuiet, text), False) Then
					Util.Errmsg(msgtxt)
					Me._txtR_3.Focus()
				Else
					Dim obj3 As Object = flag
					Dim upperBound As Single = 100F
					Dim inclusive2 As Integer = -1
					Dim errnum2 As Integer = 0
					Dim useMetric2 As Integer = 0
					Dim canadianIsMetric2 As Integer = 0
					Dim bQuiet2 As Boolean = False
					text = ""
					If Operators.ConditionalCompareObjectEqual(obj3, Util.CheckUpper(obj, upperBound, inclusive2, errnum2, useMetric2, canadianIsMetric2, bQuiet2, text), False) Then
						Util.Errmsg(msgtxt)
						Me._txtR_3.Focus()
					Else
						Dim txtR_ As TextBox = Me._txtR_3
						Dim label_ As Label = Me._Label_11
						CtrlUI.TextBox_LostFocus(txtR_, label_, True)
						Me._Label_11 = label_
						Me._txtR_3 = txtR_
						If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
							Me.PULinkItem.CrankRadii(2) = Conversions.ToSingle(obj)
						End If
					End If
				End If
			End If
		End Sub

		Private Sub txtR_4_Leave(eventSender As Object, eventArgs As EventArgs)
			Dim msgtxt As String = Me.MakeAPIDimErrorMessage("R", 5F, 100F, RSWIN_DESC.ins, RSWIN_DESC.cm, RSWIN_DESC.IN__CM)
			Dim flag As Boolean = False
			Dim obj As Object
			If flag <> CtrlUI.CheckValid(Me._txtR_4, True, False, obj) Then
				Dim obj2 As Object = flag
				Dim lowerBound As Single = 5F
				Dim inclusive As Integer = -1
				Dim errnum As Integer = 0
				Dim useMetric As Integer = 0
				Dim canadianIsMetric As Integer = 0
				Dim bQuiet As Boolean = False
				Dim text As String = ""
				If Operators.ConditionalCompareObjectEqual(obj2, Util.CheckLower(obj, lowerBound, inclusive, errnum, useMetric, canadianIsMetric, bQuiet, text), False) Then
					Util.Errmsg(msgtxt)
					Me._txtR_4.Focus()
				Else
					Dim obj3 As Object = flag
					Dim upperBound As Single = 100F
					Dim inclusive2 As Integer = -1
					Dim errnum2 As Integer = 0
					Dim useMetric2 As Integer = 0
					Dim canadianIsMetric2 As Integer = 0
					Dim bQuiet2 As Boolean = False
					text = ""
					If Operators.ConditionalCompareObjectEqual(obj3, Util.CheckUpper(obj, upperBound, inclusive2, errnum2, useMetric2, canadianIsMetric2, bQuiet2, text), False) Then
						Util.Errmsg(msgtxt)
						Me._txtR_4.Focus()
					Else
						Dim txtR_ As TextBox = Me._txtR_4
						Dim label_ As Label = Me._Label_12
						CtrlUI.TextBox_LostFocus(txtR_, label_, True)
						Me._Label_12 = label_
						Me._txtR_4 = txtR_
						If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
							Me.PULinkItem.CrankRadii(3) = Conversions.ToSingle(obj)
						End If
					End If
				End If
			End If
		End Sub

		Private Sub txtR_5_Leave(eventSender As Object, eventArgs As EventArgs)
			Dim msgtxt As String = Me.MakeAPIDimErrorMessage("R", 5F, 100F, RSWIN_DESC.ins, RSWIN_DESC.cm, RSWIN_DESC.IN__CM)
			Dim flag As Boolean = False
			Dim obj As Object
			If flag <> CtrlUI.CheckValid(Me._txtR_5, True, False, obj) Then
				Dim obj2 As Object = flag
				Dim lowerBound As Single = 5F
				Dim inclusive As Integer = -1
				Dim errnum As Integer = 0
				Dim useMetric As Integer = 0
				Dim canadianIsMetric As Integer = 0
				Dim bQuiet As Boolean = False
				Dim text As String = ""
				If Operators.ConditionalCompareObjectEqual(obj2, Util.CheckLower(obj, lowerBound, inclusive, errnum, useMetric, canadianIsMetric, bQuiet, text), False) Then
					Util.Errmsg(msgtxt)
					Me._txtR_5.Focus()
				Else
					Dim obj3 As Object = flag
					Dim upperBound As Single = 100F
					Dim inclusive2 As Integer = -1
					Dim errnum2 As Integer = 0
					Dim useMetric2 As Integer = 0
					Dim canadianIsMetric2 As Integer = 0
					Dim bQuiet2 As Boolean = False
					text = ""
					If Operators.ConditionalCompareObjectEqual(obj3, Util.CheckUpper(obj, upperBound, inclusive2, errnum2, useMetric2, canadianIsMetric2, bQuiet2, text), False) Then
						Util.Errmsg(msgtxt)
						Me._txtR_5.Focus()
					Else
						Dim txtR_ As TextBox = Me._txtR_5
						Dim label_ As Label = Me._Label_13
						CtrlUI.TextBox_LostFocus(txtR_, label_, True)
						Me._Label_13 = label_
						Me._txtR_5 = txtR_
						If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
							Me.PULinkItem.CrankRadii(4) = Conversions.ToSingle(obj)
						End If
					End If
				End If
			End If
		End Sub

		Private Sub txtS_TextChanged(eventSender As Object, eventArgs As EventArgs)
			Dim txtS As TextBox = Me.txtS
			Dim label_ As Label = Me._Label_26
			Me.TextBox_Change(txtS, label_)
			Me._Label_26 = label_
			Me.txtS = txtS
		End Sub

		Private Sub txtS_KeyDown(eventSender As Object, eventArgs As KeyEventArgs)
			' The following expression was wrapped in a checked-statement
			Dim num As Short = CShort(eventArgs.KeyCode)
			Dim num2 As Short = CShort((eventArgs.KeyData / Keys.Shift))
		End Sub

		Private Sub txtS_KeyPress(eventSender As Object, eventArgs As KeyPressEventArgs)
			' The following expression was wrapped in a checked-expression
			Dim num As Short = CShort(Strings.Asc(eventArgs.KeyChar))
			If num = 0S Then
				eventArgs.Handled = True
			End If
		End Sub

		Private Sub txtS_Leave(eventSender As Object, eventArgs As EventArgs)
			Dim txtS As Control = Me.txtS
			CtrlUI.Control_LostFocus(txtS)
			Me.txtS = CType(txtS, TextBox)
			Dim msgtxt As String = Me.MakeAPIDimErrorMessage("S", 25F, 300F, "psig", RSWIN_DESC.kPa, RSWIN_DESC.PSI__KPA)
			Dim flag As Boolean = False
			Dim obj As Object
			If flag <> CtrlUI.CheckValid(Me.txtS, True, False, obj) Then
				Dim obj2 As Object = flag
				Dim lowerBound As Single = 25F
				Dim inclusive As Integer = -1
				Dim errnum As Integer = 0
				Dim useMetric As Integer = 0
				Dim canadianIsMetric As Integer = 0
				Dim bQuiet As Boolean = False
				Dim text As String = ""
				If Operators.ConditionalCompareObjectEqual(obj2, Util.CheckLower(obj, lowerBound, inclusive, errnum, useMetric, canadianIsMetric, bQuiet, text), False) Then
					Util.Errmsg(msgtxt)
					Me.txtS.Focus()
				Else
					Dim obj3 As Object = flag
					Dim upperBound As Single = 300F
					Dim inclusive2 As Integer = -1
					Dim errnum2 As Integer = 0
					Dim useMetric2 As Integer = 0
					Dim canadianIsMetric2 As Integer = 0
					Dim bQuiet2 As Boolean = False
					text = ""
					If Operators.ConditionalCompareObjectEqual(obj3, Util.CheckUpper(obj, upperBound, inclusive2, errnum2, useMetric2, canadianIsMetric2, bQuiet2, text), False) Then
						Util.Errmsg(msgtxt)
						Me.txtS.Focus()
					ElseIf Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
						Me.PULinkItem.S = Conversions.ToSingle(obj)
					End If
				End If
			End If
		End Sub

		Private Sub txtSprocketDiameter_TextChanged(eventSender As Object, eventArgs As EventArgs)
			Dim txtSprocketDiameter As TextBox = Me.txtSprocketDiameter
			Dim label_ As Label = Me._Label_14
			Me.TextBox_Change(txtSprocketDiameter, label_)
			Me._Label_14 = label_
			Me.txtSprocketDiameter = txtSprocketDiameter
			Me.ShowUnitStroke(0S)
		End Sub

		Private Sub txtSprocketDiameter_KeyDown(eventSender As Object, eventArgs As KeyEventArgs)
			' The following expression was wrapped in a checked-statement
			Dim num As Short = CShort(eventArgs.KeyCode)
			Dim num2 As Short = CShort((eventArgs.KeyData / Keys.Shift))
		End Sub

		Private Sub txtSprocketDiameter_KeyPress(eventSender As Object, eventArgs As KeyPressEventArgs)
			' The following expression was wrapped in a checked-expression
			Dim num As Short = CShort(Strings.Asc(eventArgs.KeyChar))
			If num = 0S Then
				eventArgs.Handled = True
			End If
		End Sub

		Private Sub txtSprocketDiameter_Leave(eventSender As Object, eventArgs As EventArgs)
			Dim txtSprocketDiameter As Control = Me.txtSprocketDiameter
			CtrlUI.Control_LostFocus(txtSprocketDiameter)
			Me.txtSprocketDiameter = CType(txtSprocketDiameter, TextBox)
			Dim msgtxt As String = "The sprocket radius must be between 1 and 200 inches."
			Dim flag As Boolean = False
			Dim obj As Object
			If flag <> CtrlUI.CheckValid(Me.txtSprocketDiameter, True, False, obj) Then
				Dim obj2 As Object = flag
				Dim lowerBound As Single = 1F
				Dim inclusive As Integer = -1
				Dim errnum As Integer = 0
				Dim useMetric As Integer = 0
				Dim canadianIsMetric As Integer = 0
				Dim bQuiet As Boolean = False
				Dim text As String = ""
				If Operators.ConditionalCompareObjectEqual(obj2, Util.CheckLower(obj, lowerBound, inclusive, errnum, useMetric, canadianIsMetric, bQuiet, text), False) Then
					Util.Errmsg(msgtxt)
					Me.txtSprocketDiameter.Focus()
				Else
					Dim obj3 As Object = flag
					Dim upperBound As Single = 200F
					Dim inclusive2 As Integer = -1
					Dim errnum2 As Integer = 0
					Dim useMetric2 As Integer = 0
					Dim canadianIsMetric2 As Integer = 0
					Dim bQuiet2 As Boolean = False
					text = ""
					If Operators.ConditionalCompareObjectEqual(obj3, Util.CheckUpper(obj, upperBound, inclusive2, errnum2, useMetric2, canadianIsMetric2, bQuiet2, text), False) Then
						Util.Errmsg(msgtxt)
						Me.txtSprocketDiameter.Focus()
					ElseIf Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
						Me.PULinkItem.SprocketRadius = Conversions.ToSingle(obj)
					End If
				End If
			End If
		End Sub

		Private Sub txtSprocketDistance_TextChanged(eventSender As Object, eventArgs As EventArgs)
			Dim txtSprocketDistance As TextBox = Me.txtSprocketDistance
			Dim label_ As Label = Me._Label_15
			Me.TextBox_Change(txtSprocketDistance, label_)
			Me._Label_15 = label_
			Me.txtSprocketDistance = txtSprocketDistance
			Me.ShowUnitStroke(0S)
		End Sub

		Private Sub txtSprocketDistance_KeyDown(eventSender As Object, eventArgs As KeyEventArgs)
			' The following expression was wrapped in a checked-statement
			Dim num As Short = CShort(eventArgs.KeyCode)
			Dim num2 As Short = CShort((eventArgs.KeyData / Keys.Shift))
		End Sub

		Private Sub txtSprocketDistance_KeyPress(eventSender As Object, eventArgs As KeyPressEventArgs)
			' The following expression was wrapped in a checked-expression
			Dim num As Short = CShort(Strings.Asc(eventArgs.KeyChar))
			If num = 0S Then
				eventArgs.Handled = True
			End If
		End Sub

		Private Sub txtSprocketDistance_Leave(eventSender As Object, eventArgs As EventArgs)
			Dim txtSprocketDistance As Control = Me.txtSprocketDistance
			CtrlUI.Control_LostFocus(txtSprocketDistance)
			Me.txtSprocketDistance = CType(txtSprocketDistance, TextBox)
			Dim flag As Boolean = False
			Dim obj As Object
			If flag <> CtrlUI.CheckValid(Me.txtSprocketDistance, True, False, obj) Then
				Dim obj2 As Object = flag
				Dim lowerBound As Single = 25F
				Dim inclusive As Integer = -1
				Dim errnum As Integer = 65
				Dim useMetric As Integer = -1
				Dim canadianIsMetric As Integer = -1
				Dim bQuiet As Boolean = False
				Dim text As String = ""
				If Operators.ConditionalCompareObjectEqual(obj2, Util.CheckLower(obj, lowerBound, inclusive, errnum, useMetric, canadianIsMetric, bQuiet, text), False) Then
					Me.txtSprocketDistance.Focus()
				Else
					Dim obj3 As Object = flag
					Dim upperBound As Single = 450F
					Dim inclusive2 As Integer = -1
					Dim errnum2 As Integer = 65
					Dim useMetric2 As Integer = -1
					Dim canadianIsMetric2 As Integer = -1
					Dim bQuiet2 As Boolean = False
					text = ""
					If Operators.ConditionalCompareObjectEqual(obj3, Util.CheckUpper(obj, upperBound, inclusive2, errnum2, useMetric2, canadianIsMetric2, bQuiet2, text), False) Then
						Me.txtSprocketDistance.Focus()
					ElseIf Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
						Me.PULinkItem.SprocketDistance = Conversions.ToSingle(obj)
					End If
				End If
			End If
		End Sub

		Private Sub txtStructRating_TextChanged(eventSender As Object, eventArgs As EventArgs)
			Dim txtStructRating As TextBox = Me.txtStructRating
			Dim label_ As Label = Me._Label_5
			Me.TextBox_Change(txtStructRating, label_)
			Me._Label_5 = label_
			Me.txtStructRating = txtStructRating
			Me.ShowAPIDesignation()
		End Sub

		Private Sub txtStructRating_KeyDown(eventSender As Object, eventArgs As KeyEventArgs)
			' The following expression was wrapped in a checked-statement
			Dim num As Short = CShort(eventArgs.KeyCode)
			Dim num2 As Short = CShort((eventArgs.KeyData / Keys.Shift))
		End Sub

		Private Sub txtStructRating_KeyPress(eventSender As Object, eventArgs As KeyPressEventArgs)
			' The following expression was wrapped in a checked-expression
			Dim num As Short = CShort(Strings.Asc(eventArgs.KeyChar))
			If num = 0S Then
				eventArgs.Handled = True
			End If
		End Sub

		Private Sub txtStructRating_Leave(eventSender As Object, eventArgs As EventArgs)
			Dim txtStructRating As Control = Me.txtStructRating
			CtrlUI.Control_LostFocus(txtStructRating)
			Me.txtStructRating = CType(txtStructRating, TextBox)
			If Not(Me.cboUnitType.SelectedIndex + 1 = 7 Or Me.cboUnitType.SelectedIndex + 1 = 10) Then
				Dim flag As Boolean = False
				Dim obj As Object
				If flag <> CtrlUI.CheckValid(Me.txtStructRating, True, False, obj) Then
					Dim obj2 As Object = flag
					Dim lowerBound As Single = 25F
					Dim inclusive As Integer = -1
					Dim errnum As Integer = 73
					Dim useMetric As Integer = -1
					Dim canadianIsMetric As Integer = -1
					Dim bQuiet As Boolean = False
					Dim text As String = ""
					If Operators.ConditionalCompareObjectEqual(obj2, Util.CheckLower(obj, lowerBound, inclusive, errnum, useMetric, canadianIsMetric, bQuiet, text), False) Then
						Me.txtStructRating.Focus()
					Else
						Dim obj3 As Object = flag
						Dim upperBound As Single = 700F
						Dim inclusive2 As Integer = -1
						Dim errnum2 As Integer = 73
						Dim useMetric2 As Integer = -1
						Dim canadianIsMetric2 As Integer = -1
						Dim bQuiet2 As Boolean = False
						text = ""
						If Operators.ConditionalCompareObjectEqual(obj3, Util.CheckUpper(obj, upperBound, inclusive2, errnum2, useMetric2, canadianIsMetric2, bQuiet2, text), False) Then
							Me.txtStructRating.Focus()
						ElseIf Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
							Me.PULinkItem.StructRating = Conversions.ToSingle(obj)
						End If
					End If
				End If
			ElseIf Me.cboUnitType.SelectedIndex + 1 = 7 Then
				Dim flag2 As Boolean = False
				Dim obj As Object
				If flag2 <> CtrlUI.CheckValid(Me.txtStructRating, True, False, obj) Then
					Dim obj4 As Object = flag2
					Dim lowerBound2 As Single = 10F
					Dim inclusive3 As Integer = -1
					Dim errnum3 As Integer = 277
					Dim useMetric3 As Integer = -1
					Dim canadianIsMetric3 As Integer = -1
					Dim bQuiet3 As Boolean = False
					Dim text As String = ""
					If Operators.ConditionalCompareObjectEqual(obj4, Util.CheckLower(obj, lowerBound2, inclusive3, errnum3, useMetric3, canadianIsMetric3, bQuiet3, text), False) Then
						Me.txtStructRating.Focus()
					Else
						Dim obj5 As Object = flag2
						Dim upperBound2 As Single = 900F
						Dim inclusive4 As Integer = -1
						Dim errnum4 As Integer = 277
						Dim useMetric4 As Integer = -1
						Dim canadianIsMetric4 As Integer = -1
						Dim bQuiet4 As Boolean = False
						text = ""
						If Operators.ConditionalCompareObjectEqual(obj5, Util.CheckUpper(obj, upperBound2, inclusive4, errnum4, useMetric4, canadianIsMetric4, bQuiet4, text), False) Then
							Me.txtStructRating.Focus()
						ElseIf Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
							Me.PULinkItem.StructRating = Conversions.ToSingle(obj)
						End If
					End If
				End If
			ElseIf Me.cboUnitType.SelectedIndex + 1 = 10 Then
				Dim flag3 As Boolean = False
				Dim obj As Object
				If flag3 <> CtrlUI.CheckValid(Me.txtStructRating, True, False, obj) Then
					Dim obj6 As Object = flag3
					Dim lowerBound3 As Single = 10F
					Dim inclusive5 As Integer = -1
					Dim errnum5 As Integer = 277
					Dim useMetric5 As Integer = -1
					Dim canadianIsMetric5 As Integer = -1
					Dim bQuiet5 As Boolean = False
					Dim text As String = ""
					If Operators.ConditionalCompareObjectEqual(obj6, Util.CheckLower(obj, lowerBound3, inclusive5, errnum5, useMetric5, canadianIsMetric5, bQuiet5, text), False) Then
						Me.txtStructRating.Focus()
					Else
						Dim obj7 As Object = flag3
						Dim upperBound3 As Single = 2000F
						Dim inclusive6 As Integer = -1
						Dim errnum6 As Integer = 277
						Dim useMetric6 As Integer = -1
						Dim canadianIsMetric6 As Integer = -1
						Dim bQuiet6 As Boolean = False
						text = ""
						If Operators.ConditionalCompareObjectEqual(obj7, Util.CheckUpper(obj, upperBound3, inclusive6, errnum6, useMetric6, canadianIsMetric6, bQuiet6, text), False) Then
							Me.txtStructRating.Focus()
						ElseIf Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
							Me.PULinkItem.StructRating = Conversions.ToSingle(obj)
						End If
					End If
				End If
			End If
		End Sub

		Private Sub txtUnbalance_TextChanged(eventSender As Object, eventArgs As EventArgs)
			Dim txtUnbalance As TextBox = Me.txtUnbalance
			Dim label_ As Label = Me._Label_23
			Me.TextBox_Change(txtUnbalance, label_)
			Me._Label_23 = label_
			Me.txtUnbalance = txtUnbalance
		End Sub

		Private Sub txtUnbalance_Enter(eventSender As Object, eventArgs As EventArgs)
		End Sub

		Private Sub txtUnbalance_KeyDown(eventSender As Object, eventArgs As KeyEventArgs)
			' The following expression was wrapped in a checked-statement
			Dim num As Short = CShort(eventArgs.KeyCode)
			Dim num2 As Short = CShort((eventArgs.KeyData / Keys.Shift))
		End Sub

		Private Sub txtUnbalance_KeyPress(eventSender As Object, eventArgs As KeyPressEventArgs)
			' The following expression was wrapped in a checked-expression
			Dim num As Short = CShort(Strings.Asc(eventArgs.KeyChar))
			If num = 0S Then
				eventArgs.Handled = True
			End If
		End Sub

		Private Sub txtUnbalance_Leave(eventSender As Object, eventArgs As EventArgs)
			Dim txtUnbalance As Control = Me.txtUnbalance
			CtrlUI.Control_LostFocus(txtUnbalance)
			Me.txtUnbalance = CType(txtUnbalance, TextBox)
			Dim flag As Boolean = False
			Dim obj As Object
			If flag <> CtrlUI.CheckValid(Me.txtUnbalance, True, False, obj) Then
				Dim obj2 As Object = flag
				Dim lowerBound As Single = -12000F
				Dim inclusive As Integer = -1
				Dim errnum As Integer = 84
				Dim useMetric As Integer = -1
				Dim canadianIsMetric As Integer = -1
				Dim bQuiet As Boolean = False
				Dim text As String = ""
				If Operators.ConditionalCompareObjectEqual(obj2, Util.CheckLower(obj, lowerBound, inclusive, errnum, useMetric, canadianIsMetric, bQuiet, text), False) Then
					Me.txtUnbalance.Focus()
				Else
					Dim obj3 As Object = flag
					Dim upperBound As Single = 12000F
					Dim inclusive2 As Integer = -1
					Dim errnum2 As Integer = 84
					Dim useMetric2 As Integer = -1
					Dim canadianIsMetric2 As Integer = -1
					Dim bQuiet2 As Boolean = False
					text = ""
					If Operators.ConditionalCompareObjectEqual(obj3, Util.CheckUpper(obj, upperBound, inclusive2, errnum2, useMetric2, canadianIsMetric2, bQuiet2, text), False) Then
						Me.txtUnbalance.Focus()
					ElseIf Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectGreaterEqual(obj, 0, False), Me.cboUnitType.SelectedIndex + 1 = 5)) Then
						Util.cErrmsg(27)
						Me.txtUnbalance.Focus()
					ElseIf Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
						Me.PULinkItem.Unbalance = Conversions.ToSingle(obj)
					End If
				End If
			End If
		End Sub

		Private Sub txtUnitName_TextChanged(eventSender As Object, eventArgs As EventArgs)
		End Sub

		Private Sub txtUnitName_KeyDown(eventSender As Object, eventArgs As KeyEventArgs)
			' The following expression was wrapped in a checked-statement
			Dim num As Short = CShort(eventArgs.KeyCode)
			Dim num2 As Short = CShort((eventArgs.KeyData / Keys.Shift))
		End Sub

		Private Sub txtUnitName_KeyPress(eventSender As Object, eventArgs As KeyPressEventArgs)
			' The following expression was wrapped in a checked-expression
			Dim num As Short = CShort(Strings.Asc(eventArgs.KeyChar))
			If num = 0S Then
				eventArgs.Handled = True
			End If
		End Sub

		Private Sub txtV0_TextChanged(eventSender As Object, eventArgs As EventArgs)
			Dim txtV As TextBox = Me.txtV0
			Dim label_ As Label = Me._Label_27
			Me.TextBox_Change(txtV, label_)
			Me._Label_27 = label_
			Me.txtV0 = txtV
		End Sub

		Private Sub txtV0_KeyDown(eventSender As Object, eventArgs As KeyEventArgs)
			' The following expression was wrapped in a checked-statement
			Dim num As Short = CShort(eventArgs.KeyCode)
			Dim num2 As Short = CShort((eventArgs.KeyData / Keys.Shift))
		End Sub

		Private Sub txtV0_KeyPress(eventSender As Object, eventArgs As KeyPressEventArgs)
			' The following expression was wrapped in a checked-expression
			Dim num As Short = CShort(Strings.Asc(eventArgs.KeyChar))
			If num = 0S Then
				eventArgs.Handled = True
			End If
		End Sub

		Private Sub txtV0_Leave(eventSender As Object, eventArgs As EventArgs)
			Dim txtV As Control = Me.txtV0
			CtrlUI.Control_LostFocus(txtV)
			Me.txtV0 = CType(txtV, TextBox)
			Dim msgtxt As String = Me.MakeAPIDimErrorMessage("V0", 15F, 500F, "in³", "cm³", CSng(Math.Pow(CDbl(RSWIN_DESC.IN__CM), 3.0)))
			Dim flag As Boolean = False
			Dim obj As Object
			If flag <> CtrlUI.CheckValid(Me.txtV0, True, False, obj) Then
				Dim obj2 As Object = flag
				Dim lowerBound As Single = 15F
				Dim inclusive As Integer = -1
				Dim errnum As Integer = 0
				Dim useMetric As Integer = 0
				Dim canadianIsMetric As Integer = 0
				Dim bQuiet As Boolean = False
				Dim text As String = ""
				If Operators.ConditionalCompareObjectEqual(obj2, Util.CheckLower(obj, lowerBound, inclusive, errnum, useMetric, canadianIsMetric, bQuiet, text), False) Then
					Util.Errmsg(msgtxt)
					Me.txtV0.Focus()
				Else
					Dim obj3 As Object = flag
					Dim upperBound As Single = 500F
					Dim inclusive2 As Integer = -1
					Dim errnum2 As Integer = 0
					Dim useMetric2 As Integer = 0
					Dim canadianIsMetric2 As Integer = 0
					Dim bQuiet2 As Boolean = False
					text = ""
					If Operators.ConditionalCompareObjectEqual(obj3, Util.CheckUpper(obj, upperBound, inclusive2, errnum2, useMetric2, canadianIsMetric2, bQuiet2, text), False) Then
						Util.Errmsg(msgtxt)
						Me.txtV0.Focus()
					ElseIf Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
						Me.PULinkItem.V0 = Conversions.ToSingle(obj)
					End If
				End If
			End If
		End Sub

		Public Sub GetUnitDimensions(ByRef P As RSWIN_DESC.PUDataRec)
			Try
				P.Initialize()
				P.Manuf = Me.txtManufacturer.Text
				P.UnitName = Me.txtUnitName.Text
				P.OtherInfo = Me.txtOtherInfo.Text
				P.UnitType = CShort((Me.cboUnitType.SelectedIndex + 1))
				Select Case P.UnitType
					Case 1S
						P.RequiredRotation = CShort(Me.GetRequiredRotation())
						P.APIDesignation = "C"
					Case 2S
						P.RequiredRotation = CShort(Me.GetRequiredRotation())
						P.APIDesignation = "C"
					Case 3S
						P.RequiredRotation = CShort(Me.GetRequiredRotation())
						P.APIDesignation = "C"
					Case 4S, 9S
						P.RequiredRotation = CShort(Me.GetRequiredRotation())
						P.APIDesignation = "LP"
					Case 5S
						P.RequiredRotation = CShort(Me.GetRequiredRotation())
						P.APIDesignation = "M"
					Case 6S
						P.RequiredRotation = CShort(Me.GetRequiredRotation())
						P.APIDesignation = "A"
					Case 7S
						P.RequiredRotation = CShort(Me.GetRequiredRotation())
						P.APIDesignation = "R"
					Case 8S
						P.RequiredRotation = CShort(Me.GetRequiredRotation())
						P.APIDesignation = "B"
					Case 10S
						P.RequiredRotation = 0S
						P.APIDesignation = "H"
				End Select
				If P.UnitType <> 10S Then
					P.GearboxRating = Me.PULinkItem.GearboxRating
				End If
				P.StructRating = Me.PULinkItem.StructRating
				P.MaxStroke = Me.PULinkItem.MaxStroke
				If P.UnitType = 10S Then
					Dim lblAPIDesignation As Label = Me.lblAPIDesignation
					Dim array As String() = New String(4) {}
					array(0) = Strings.Trim(P.APIDesignation)
					array(1) = "-"
					Dim array2 As String() = array
					Dim num As Integer = 2
					Dim text As String = "0"
					array2(num) = Util.Format(P.StructRating, text)
					array(3) = "-"
					Dim array3 As String() = array
					Dim num2 As Integer = 4
					Dim text2 As String = "0"
					array3(num2) = Util.Format(P.MaxStroke, text2)
					lblAPIDesignation.Text = String.Concat(array)
					P.APIDesignation = Me.lblAPIDesignation.Text
				Else
					Dim lblAPIDesignation2 As Label = Me.lblAPIDesignation
					Dim array As String() = New String(6) {}
					array(0) = Strings.Trim(P.APIDesignation)
					array(1) = "-"
					Dim array4 As String() = array
					Dim num3 As Integer = 2
					Dim text3 As String = "0"
					array4(num3) = Util.Format(P.GearboxRating, text3)
					array(3) = "-"
					Dim array5 As String() = array
					Dim num4 As Integer = 4
					Dim text2 As String = "0"
					array5(num4) = Util.Format(P.StructRating, text2)
					array(5) = "-"
					Dim array6 As String() = array
					Dim num5 As Integer = 6
					Dim text As String = "0"
					array6(num5) = Util.Format(P.MaxStroke, text)
					lblAPIDesignation2.Text = String.Concat(array)
					P.APIDesignation = Me.lblAPIDesignation.Text
				End If
				If P.UnitType <> 7S And P.UnitType <> 10S Then
					If Me.cboCrankHoles.SelectedIndex <> -1 Then
						P.CrankHoles = CShort((Me.cboCrankHoles.SelectedIndex + 1))
					End If
					Dim obj As Object
					Dim obj2 As Object
					If ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj, 1, 5, 1, obj2, obj) Then
						Do
							If Operators.ConditionalCompareObjectLessEqual(obj, P.CrankHoles, False) Then
								P.CrankRadii(Conversions.ToInteger(Operators.SubtractObject(obj, 1))) = Me.PULinkItem.CrankRadii(Conversions.ToInteger(Operators.SubtractObject(obj, 1)))
								Dim obj3 As Object = obj
								If Operators.ConditionalCompareObjectEqual(obj3, 1, False) Then
									P.Strokes(Conversions.ToInteger(Operators.SubtractObject(obj, 1))) = Convert.ToSingle(RuntimeHelpers.GetObjectValue(Me._panCalcStroke_1.Tag))
								ElseIf Operators.ConditionalCompareObjectEqual(obj3, 2, False) Then
									P.Strokes(Conversions.ToInteger(Operators.SubtractObject(obj, 1))) = Convert.ToSingle(RuntimeHelpers.GetObjectValue(Me._panCalcStroke_2.Tag))
								ElseIf Operators.ConditionalCompareObjectEqual(obj3, 3, False) Then
									P.Strokes(Conversions.ToInteger(Operators.SubtractObject(obj, 1))) = Convert.ToSingle(RuntimeHelpers.GetObjectValue(Me._panCalcStroke_3.Tag))
								ElseIf Operators.ConditionalCompareObjectEqual(obj3, 4, False) Then
									P.Strokes(Conversions.ToInteger(Operators.SubtractObject(obj, 1))) = Convert.ToSingle(RuntimeHelpers.GetObjectValue(Me._panCalcStroke_4.Tag))
								ElseIf Operators.ConditionalCompareObjectEqual(obj3, 5, False) Then
									P.Strokes(Conversions.ToInteger(Operators.SubtractObject(obj, 1))) = Convert.ToSingle(RuntimeHelpers.GetObjectValue(Me._panCalcStroke_5.Tag))
								End If
							Else
								P.CrankRadii(Conversions.ToInteger(Operators.SubtractObject(obj, 1))) = 0F
								P.Strokes(Conversions.ToInteger(Operators.SubtractObject(obj, 1))) = 0F
							End If
						Loop While ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj, obj2, obj)
					End If
					P.A = Me.PULinkItem.A
					P.C = Me.PULinkItem.C
					P.I = Me.PULinkItem.I
					P.K = Me.PULinkItem.K
					P.P = Me.PULinkItem.P
					If Strings.Len(Strings.Trim(Me.txtArtInertia.Text)) = 0 Then
						P.ArtInertia = 0F
					Else
						P.ArtInertia = Me.PULinkItem.ArtInertia
					End If
				End If
				If P.UnitType = 6S Then
					P.M = Me.PULinkItem.M
					P.S = Me.PULinkItem.S
					P.V0 = Me.PULinkItem.V0
				End If
				If P.UnitType = 10S Then
					Try
						P.MaxStroke = Me.PULinkItem.MaxStroke
					Catch ex As Exception
					End Try
					Try
						P.SprocketRadius = Me.GetHydraulicRadius(Me.PULinkItem.MaxStroke, Me.PULinkItem.SprocketDistance) / 2F
						P.SprocketDistance = Me.PULinkItem.SprocketDistance
					Catch ex2 As Exception
						P.SprocketRadius = 20F
						P.SprocketDistance = P.MaxStroke - P.SprocketRadius
					End Try
					P.DrumDiamRatio = 1F
					P.P = 0F
					P.CrankHoles = 1S
					P.Strokes(0) = P.MaxStroke
					P.Strokes(1) = P.MaxStroke
				End If
				If P.UnitType = 7S Then
					P.CrankHoles = 1S
					P.Strokes(0) = Convert.ToSingle(RuntimeHelpers.GetObjectValue(Me._panCalcStroke_0.Tag))
					P.Strokes(1) = Convert.ToSingle(RuntimeHelpers.GetObjectValue(Me._panCalcStroke_0.Tag))
					P.SprocketRadius = Me.PULinkItem.SprocketRadius / 2F
					P.SprocketDistance = Me.PULinkItem.SprocketDistance
					P.DrumDiamRatio = Me.PULinkItem.DrumDiamRatio
					If Me.PULinkItem.P = 0F Then
						P.P = 0F
					Else
						P.P = Me.PULinkItem.P
					End If
				End If
				If P.UnitType <> 6S And P.UnitType <> 7S And P.UnitType <> 10S And P.UnitType <> 9S Then
					P.Unbalance = Me.PULinkItem.Unbalance
					P.CrankOffset = CSng((Conversions.ToDouble(Me.txtCrankOffset.Text) / 180.0 * 3.141592653589793))
				End If
				If P.UnitType = 8S Then
					P.M = Me.PULinkItem.M
				End If
				If P.UnitType = 9S Then
					P.CrankOffset = CSng((Conversions.ToDouble(Me.txtTheta.Text) / 180.0 * 3.141592653589793))
					P.Unbalance = 0F
				End If
			Catch ex3 As Exception
				Util.Errmsg("Error occurred in sub GetUnitDimensions." + ex3.Message)
			End Try
		End Sub

		Private Sub SetUnitDimensions(P As RSWIN_DESC.PUDataRec)
			Try
				Me.txtManufacturer.Text = P.Manuf.Trim()
				Me.txtUnitName.Text = P.UnitName.Trim()
				Me.txtOtherInfo.Text = P.OtherInfo.Trim()
				Me.cboUnitType.SelectedIndex = CInt((P.UnitType - 1S))
				Me.PULinkItem.GearboxRating = Conversions.ToSingle(Convert.ToString(P.GearboxRating))
				Dim textBox As TextBox = Me.txtGearboxRating
				Me.TextBox_SetValue(textBox, P.GearboxRating)
				Me.txtGearboxRating = textBox
				Me.PULinkItem.StructRating = Conversions.ToSingle(Convert.ToString(P.StructRating))
				textBox = Me.txtStructRating
				Me.TextBox_SetValue(textBox, P.StructRating)
				Me.txtStructRating = textBox
				Me.PULinkItem.MaxStroke = Conversions.ToSingle(Convert.ToString(P.MaxStroke))
				textBox = Me.txtMaxStroke
				Me.TextBox_SetValue(textBox, P.MaxStroke)
				Me.txtMaxStroke = textBox
				Me.CheckRequiredRotationCombo()
				Me.PULinkItem.RequiredRotation = P.RequiredRotation
				Select Case P.RequiredRotation
					Case -1S
						Me.cboRequiredRotation.SelectedIndex = 1
					Case 0S
						Me.cboRequiredRotation.SelectedIndex = 2
					Case 1S
						Me.cboRequiredRotation.SelectedIndex = 0
				End Select
				If P.UnitType <> 7S And P.UnitType <> 10S Then
					Dim obj As Object
					Dim obj2 As Object
					If ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj, 1, 5, 1, obj2, obj) Then
						Do
							Me.PULinkItem.CrankRadii(Conversions.ToInteger(Operators.SubtractObject(obj, 1))) = Conversions.ToSingle(Convert.ToString(P.CrankRadii(Conversions.ToInteger(Operators.SubtractObject(obj, 1)))))
							Dim obj3 As Object = obj
							If Operators.ConditionalCompareObjectEqual(obj3, 1, False) Then
								textBox = Me._txtR_1
								Me.TextBox_SetValue(textBox, P.CrankRadii(Conversions.ToInteger(Operators.SubtractObject(obj, 1))))
								Me._txtR_1 = textBox
							ElseIf Operators.ConditionalCompareObjectEqual(obj3, 2, False) Then
								textBox = Me._txtR_2
								Me.TextBox_SetValue(textBox, P.CrankRadii(Conversions.ToInteger(Operators.SubtractObject(obj, 1))))
								Me._txtR_2 = textBox
							ElseIf Operators.ConditionalCompareObjectEqual(obj3, 3, False) Then
								textBox = Me._txtR_3
								Me.TextBox_SetValue(textBox, P.CrankRadii(Conversions.ToInteger(Operators.SubtractObject(obj, 1))))
								Me._txtR_3 = textBox
							ElseIf Operators.ConditionalCompareObjectEqual(obj3, 4, False) Then
								textBox = Me._txtR_4
								Me.TextBox_SetValue(textBox, P.CrankRadii(Conversions.ToInteger(Operators.SubtractObject(obj, 1))))
								Me._txtR_4 = textBox
							ElseIf Operators.ConditionalCompareObjectEqual(obj3, 5, False) Then
								textBox = Me._txtR_5
								Me.TextBox_SetValue(textBox, P.CrankRadii(Conversions.ToInteger(Operators.SubtractObject(obj, 1))))
								Me._txtR_5 = textBox
							End If
						Loop While ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj, obj2, obj)
					End If
					Me.PULinkItem.A = Conversions.ToSingle(Convert.ToString(P.A))
					textBox = Me.txtA
					Me.TextBox_SetValue(textBox, P.A)
					Me.txtA = textBox
					Me.PULinkItem.C = Conversions.ToSingle(Convert.ToString(P.C))
					textBox = Me.txtC
					Me.TextBox_SetValue(textBox, P.C)
					Me.txtC = textBox
					Me.PULinkItem.I = Conversions.ToSingle(Convert.ToString(P.I))
					textBox = Me.txtI
					Me.TextBox_SetValue(textBox, P.I)
					Me.txtI = textBox
					Me.PULinkItem.K = Conversions.ToSingle(Convert.ToString(P.K))
					textBox = Me.txtK
					Me.TextBox_SetValue(textBox, P.K)
					Me.txtK = textBox
					Me.PULinkItem.P = Conversions.ToSingle(Convert.ToString(P.P))
					textBox = Me.txtP
					Me.TextBox_SetValue(textBox, P.P)
					Me.txtP = textBox
					textBox = Me.txtA_ABAL
					Me.TextBox_SetValue(textBox, P.A)
					Me.txtA_ABAL = textBox
					textBox = Me.txtC_ABAL
					Me.TextBox_SetValue(textBox, P.C)
					Me.txtC_ABAL = textBox
					textBox = Me.txtI_ABAL
					Me.TextBox_SetValue(textBox, P.I)
					Me.txtI_ABAL = textBox
					textBox = Me.txtK_ABAL
					Me.TextBox_SetValue(textBox, P.K)
					Me.txtK_ABAL = textBox
					textBox = Me.txtP_ABAL
					Me.TextBox_SetValue(textBox, P.P)
					Me.txtP_ABAL = textBox
					textBox = Me.txtA_MII
					Me.TextBox_SetValue(textBox, P.A)
					Me.txtA_MII = textBox
					textBox = Me.txtC_MII
					Me.TextBox_SetValue(textBox, P.C)
					Me.txtC_MII = textBox
					textBox = Me.txtI_MII
					Me.TextBox_SetValue(textBox, P.I)
					Me.txtI_MII = textBox
					textBox = Me.txtK_MII
					Me.TextBox_SetValue(textBox, P.K)
					Me.txtK_MII = textBox
					textBox = Me.txtP_MII
					Me.TextBox_SetValue(textBox, P.P)
					Me.txtP_MII = textBox
					If P.CrankHoles = 0S Then
						P.CrankHoles = 1S
					End If
					Me.cboCrankHoles.SelectedIndex = CInt((P.CrankHoles - 1S))
					If P.ArtInertia <> 0F Then
						Me.PULinkItem.ArtInertia = Conversions.ToSingle(Convert.ToString(P.ArtInertia))
						textBox = Me.txtArtInertia
						Me.TextBox_SetValue(textBox, P.ArtInertia)
						Me.txtArtInertia = textBox
					End If
				End If
				If P.UnitType = 6S Then
					Me.PULinkItem.M = Conversions.ToSingle(Convert.ToString(P.M))
					textBox = Me.txtM
					Me.TextBox_SetValue(textBox, P.M)
					Me.txtM = textBox
					Me.PULinkItem.S = Conversions.ToSingle(Convert.ToString(P.S))
					textBox = Me.txtS
					Me.TextBox_SetValue(textBox, P.S)
					Me.txtS = textBox
					Me.PULinkItem.V0 = Conversions.ToSingle(Convert.ToString(P.V0))
					textBox = Me.txtV0
					Me.TextBox_SetValue(textBox, P.V0)
					Me.txtV0 = textBox
				End If
				If P.UnitType = 8S Then
					Me.PULinkItem.Unbalance = Conversions.ToSingle(Convert.ToString(P.Unbalance))
					Dim textBox As TextBox = Me.txtUnbalance
					Me.TextBox_SetValue(textBox, P.Unbalance)
					Me.txtUnbalance = textBox
					Me.PULinkItem.CrankOffset = Conversions.ToSingle(Convert.ToString(P.CrankOffset))
					Dim txtCrankOffset As TextBox = Me.txtCrankOffset
					Dim num As Double = CDbl(P.CrankOffset) / 3.141592653589793 * 180.0
					Dim text As String = "0.0#"
					txtCrankOffset.Text = Util.Format(num, text)
					Me.PULinkItem.M = Conversions.ToSingle(Convert.ToString(P.M))
					textBox = Me.txtCrankCBMoment
					Me.TextBox_SetValue(textBox, P.M)
					Me.txtCrankCBMoment = textBox
				End If
				If P.UnitType = 9S Then
					Me.PULinkItem.CrankOffset = Conversions.ToSingle(Convert.ToString(P.CrankOffset))
					Dim txtTheta As TextBox = Me.txtTheta
					Dim num As Double = CDbl(P.CrankOffset) / 3.141592653589793 * 180.0
					Dim text As String = "0.0#"
					txtTheta.Text = Util.Format(num, text)
					Me.PULinkItem.A = Conversions.ToSingle(Convert.ToString(P.A))
					Me.PULinkItem.C = Conversions.ToSingle(Convert.ToString(P.C))
					Dim textBox As TextBox = Me.txtD_lp
					Me.TextBox_SetValue(textBox, P.C)
					Me.txtD_lp = textBox
					Me.PULinkItem.I = Conversions.ToSingle(Convert.ToString(P.I))
					textBox = Me.txtI_lp
					Me.TextBox_SetValue(textBox, P.I)
					Me.txtI_lp = textBox
					Me.PULinkItem.K = Conversions.ToSingle(Convert.ToString(P.K))
					textBox = Me.txtK_LP
					Me.TextBox_SetValue(textBox, P.K)
					Me.txtK_LP = textBox
					Me.PULinkItem.Unbalance = 0F
				End If
				If P.UnitType = 7S Then
					Me.PULinkItem.SprocketRadius = Conversions.ToSingle(Convert.ToString(P.SprocketRadius * 2F))
					Dim textBox As TextBox = Me.txtSprocketDiameter
					Dim num2 As Single = P.SprocketRadius * 2F
					Me.TextBox_SetValue(textBox, num2)
					Me.txtSprocketDiameter = textBox
					Me.PULinkItem.SprocketDistance = Conversions.ToSingle(Convert.ToString(P.SprocketDistance))
					textBox = Me.txtSprocketDistance
					Me.TextBox_SetValue(textBox, P.SprocketDistance)
					Me.txtSprocketDistance = textBox
					Me.PULinkItem.DrumDiamRatio = P.DrumDiamRatio
					Me.txtDrumDiamRatio.Text = P.DrumDiamRatio.ToString()
					If P.P > 0F Then
						Me.PULinkItem.P = Conversions.ToSingle(Convert.ToString(P.P))
						textBox = Me.txtPitmanLength
						Me.TextBox_SetValue(textBox, P.P)
						Me.txtPitmanLength = textBox
					End If
				End If
				If P.UnitType = 10S Then
					Me.PULinkItem.SprocketRadius = Conversions.ToSingle(Convert.ToString(P.SprocketRadius * 2F))
					Me.PULinkItem.SprocketDistance = Conversions.ToSingle(Convert.ToString(P.SprocketDistance))
					Me.PULinkItem.DrumDiamRatio = 1F
					Me.PULinkItem.P = 0F
					Me.PULinkItem.CrankHoles = 1S
					Me.PULinkItem.MaxStroke = Me.PULinkItem.MaxStroke
					Me.PULinkItem.Strokes(0) = P.MaxStroke
					Me.PULinkItem.Strokes(1) = P.MaxStroke
				End If
				If P.UnitType <> 6S And P.UnitType <> 7S And P.UnitType <> 10S Then
					Me.PULinkItem.Unbalance = Conversions.ToSingle(Convert.ToString(P.Unbalance))
					Dim textBox As TextBox = Me.txtUnbalance
					Me.TextBox_SetValue(textBox, P.Unbalance)
					Me.txtUnbalance = textBox
					Dim txtCrankOffset2 As TextBox = Me.txtCrankOffset
					Dim num As Double = CDbl((P.CrankOffset * 180F)) / 3.141592653589793
					Dim text As String = "0.0"
					txtCrankOffset2.Text = Util.Format(num, text)
				End If
			Catch ex As Exception
				Util.Errmsg("Error occurred in sub SetUnitDimensions." + ex.Message)
			End Try
		End Sub

		Public Sub TextBox_SetValue(ByRef txt As TextBox, ByRef fValue As Single)
			Dim num As Integer
			If RSWIN_DESC.SETUP_MeasurementSystem = 2 Then
				Dim control As Control = txt
				Dim obj As Object = Me.TextBox_GetCanadianUnitSystem(control)
				txt = CType(control, TextBox)
				num = Conversions.ToInteger(Operators.CompareObjectEqual(obj, 3, False))
			Else
				num = If((-If(((RSWIN_DESC.SETUP_MeasurementSystem = 3) > False), 1, 0)), 1, 0)
			End If
			If num <> 0 Then
				Dim control As Control = txt
				Dim units As String = CtrlUI.TextBox_GetUnitType(control)
				txt = CType(control, TextBox)
				CtrlUI.ConvertValue(fValue, units, False)
			End If
			txt.Text = Me.QFormat(fValue)
		End Sub

		Private Function TextBox_GetCanadianUnitSystem(ByRef txt As Control) As Object
			Dim result As Object
			If TypeOf txt Is TextBox Then
				Dim text As String = Conversions.ToString(txt.Tag)
				If Strings.Len(text) < 3 Then
					result = 1
				ElseIf Operators.CompareString(Strings.Mid(text, 3, 1), RSWIN_DESC.SzENGLISH, False) = 0 Then
					result = 1
				Else
					result = 3
				End If
			End If
			Return result
		End Function

		Public Function QFormat(v As Object) As String
			Dim text As String = Util.Format(v)
			If Strings.Len(text) > 0 Then
				Dim text2 As String = ""
				Dim text3 As String = ""
				Select Case Information.VarType(RuntimeHelpers.GetObjectValue(v))
					Case VariantType.[Single], VariantType.[Double]
						Dim obj As Object = Strings.InStr(text, ".", CompareMethod.Binary)
						If Operators.ConditionalCompareObjectGreater(obj, 0, False) Then
							Dim text4 As String = Strings.Mid(text, Conversions.ToInteger(Operators.AddObject(obj, 1)))
							If Strings.Len(text4) > 1 Then
								Dim text5 As String = text4
								If Operators.CompareString(text5, text2.PadLeft(text4.Length - 1, "0"c) + "1", False) = 0 Then
									text = text.Substring(0, Conversions.ToInteger(Operators.SubtractObject(obj, 1)))
								ElseIf Operators.CompareString(text5, text3.PadLeft(text4.Length, "9"c), False) = 0 Then
									Dim obj2 As Object = Operators.AddObject(Conversion.Int(RuntimeHelpers.GetObjectValue(v)), 1)
									text = Util.Format(obj2)
								End If
							End If
						End If
				End Select
			End If
			Return text
		End Function

		Private Sub SetUnitDimensions_Old(ByRef P As RSWIN_DESC.PUDataRec)
			Me.txtManufacturer.Text = Strings.Trim(P.Manuf)
			Me.txtUnitName.Text = Strings.Trim(P.UnitName)
			Me.txtOtherInfo.Text = Strings.Trim(P.OtherInfo)
			Me.cboUnitType.SelectedIndex = CInt((P.UnitType - 1S))
			Me.txtGearboxRating.Text = Conversions.ToString(P.GearboxRating)
			Me.txtStructRating.Text = Conversions.ToString(P.StructRating)
			Me.txtMaxStroke.Text = Conversions.ToString(P.MaxStroke)
			If P.UnitType <> 7S And P.UnitType <> 10S Then
				Try
					Me._txtR_1.Text = Conversions.ToString(P.CrankRadii(0))
					Me._txtR_2.Text = Conversions.ToString(P.CrankRadii(1))
					Me._txtR_3.Text = Conversions.ToString(P.CrankRadii(2))
					Me._txtR_4.Text = Conversions.ToString(P.CrankRadii(3))
					Me._txtR_5.Text = Conversions.ToString(P.CrankRadii(4))
				Catch ex As Exception
				End Try
				Me.txtA.Text = Conversions.ToString(P.A)
				Me.txtC.Text = Conversions.ToString(P.C)
				Me.txtI.Text = Conversions.ToString(P.I)
				Me.txtK.Text = Conversions.ToString(P.K)
				Me.txtP.Text = Conversions.ToString(P.P)
				Me.txtA_ABAL.Text = Conversions.ToString(P.A)
				Me.txtC_ABAL.Text = Conversions.ToString(P.C)
				Me.txtI_ABAL.Text = Conversions.ToString(P.I)
				Me.txtK_ABAL.Text = Conversions.ToString(P.K)
				Me.txtP_ABAL.Text = Conversions.ToString(P.P)
				Me.txtA_MII.Text = Conversions.ToString(P.A)
				Me.txtC_MII.Text = Conversions.ToString(P.C)
				Me.txtI_MII.Text = Conversions.ToString(P.I)
				Me.txtK_MII.Text = Conversions.ToString(P.K)
				Me.txtP_MII.Text = Conversions.ToString(P.P)
				Me.cboCrankHoles.SelectedIndex = CInt((P.CrankHoles - 1S))
				If P.ArtInertia <> 0F Then
					Me.txtArtInertia.Text = Conversions.ToString(P.ArtInertia)
				End If
			End If
			If P.UnitType = 6S Then
				Me.txtM.Text = Conversions.ToString(P.M)
				Me.txtS.Text = Conversions.ToString(P.S)
				Me.txtV0.Text = Conversions.ToString(P.V0)
			End If
			If P.UnitType = 7S Or P.UnitType = 10S Then
				Me.txtSprocketDiameter.Text = Conversions.ToString(P.SprocketRadius * 2F)
				Me.txtSprocketDistance.Text = Conversions.ToString(P.SprocketDistance)
				Me.txtDrumDiamRatio.Text = Convert.ToString(P.DrumDiamRatio)
				If P.P > 0F Then
					Me.txtPitmanLength.Text = Conversions.ToString(P.P)
				End If
			End If
			If P.UnitType <> 6S And P.UnitType <> 7S And P.UnitType <> 10S Then
				Me.txtUnbalance.Text = Conversions.ToString(P.Unbalance)
				Dim txtCrankOffset As TextBox = Me.txtCrankOffset
				Dim num As Double = CDbl((P.CrankOffset * 180F)) / 3.141592653589793
				Dim text As String = "0.0"
				txtCrankOffset.Text = Util.Format(num, text)
			End If
		End Sub

		Private Sub initform()
			Me.txtManufacturer.Text = ""
			Me.txtUnitName.Text = ""
			Me.txtOtherInfo.Text = ""
			Me.txtUnitName.BackColor = RSWIN_DESC.rgbEditComplete
			Me.txtOtherInfo.BackColor = RSWIN_DESC.rgbEditComplete
			Me.txtPitmanLength.BackColor = RSWIN_DESC.rgbEditComplete
			Me.txtArtInertia.BackColor = RSWIN_DESC.rgbEditComplete
			Me.txtOtherInfo.BackColor = RSWIN_DESC.rgbEditComplete
			Me.txtGearboxRating.Text = ""
			Me.txtStructRating.Text = ""
			Me.txtMaxStroke.Text = ""
			Me._txtR_1.Text = ""
			Me._txtR_2.Text = ""
			Me._txtR_3.Text = ""
			Me._txtR_4.Text = ""
			Me._txtR_5.Text = ""
			Me._txtR_1.Enabled = False
			Me._txtR_2.Enabled = False
			Me._txtR_3.Enabled = False
			Me._txtR_4.Enabled = False
			Me._txtR_5.Enabled = False
			Dim textBox As TextBox = Me._txtR_1
			Me.SetBackgroundColor(textBox, 1)
			Me._txtR_1 = textBox
			textBox = Me._txtR_2
			Me.SetBackgroundColor(textBox, 2)
			Me._txtR_2 = textBox
			textBox = Me._txtR_3
			Me.SetBackgroundColor(textBox, 3)
			Me._txtR_3 = textBox
			textBox = Me._txtR_4
			Me.SetBackgroundColor(textBox, 4)
			Me._txtR_4 = textBox
			textBox = Me._txtR_5
			Me.SetBackgroundColor(textBox, 5)
			Me._txtR_5 = textBox
			Me.txtA.Text = ""
			Me.txtC.Text = ""
			Me.txtI.Text = ""
			Me.txtK.Text = ""
			Me.txtP.Text = ""
			Me.txtA_ABAL.Text = ""
			Me.txtC_ABAL.Text = ""
			Me.txtI_ABAL.Text = ""
			Me.txtK_ABAL.Text = ""
			Me.txtP_ABAL.Text = ""
			Me.txtA_MII.Text = ""
			Me.txtC_MII.Text = ""
			Me.txtI_MII.Text = ""
			Me.txtK_MII.Text = ""
			Me.txtP_MII.Text = ""
			Me.txtCrankCBMoment.Text = ""
			Me.txtK_LP.Text = ""
			Me.txtI_lp.Text = ""
			Me.txtD_lp.Text = ""
			Me.txtB_lp.Text = ""
			Me.txtTheta.Text = ""
			Me.cboCrankHoles.SelectedIndex = -1
			Me.txtArtInertia.Text = ""
			Me.txtM.Text = ""
			Me.txtS.Text = ""
			Me.txtV0.Text = ""
			Me.txtSprocketDiameter.Text = ""
			Me.txtSprocketDistance.Text = ""
			Me.txtDrumDiamRatio.Text = ""
			Me.txtPitmanLength.Text = ""
			Me.txtUnbalance.Text = ""
			Me.txtCrankOffset.Text = ""
			Me.cboUnitType.SelectedIndex = 0
			Me.CheckRequiredRotationCombo()
			Me.cboRequiredRotation.SelectedIndex = 2
		End Sub

		Private Function UnitTitle(puRec As RSWIN_DESC.PUDataRec) As String
			Return String.Concat(New String() { Strings.Trim(puRec.Manuf), vbTab, Strings.Trim(puRec.APIDesignation), vbTab, Strings.Trim(puRec.UnitName), vbTab, Strings.Trim(puRec.OtherInfo) })
		End Function

		Public Sub ModifyCustomPU(ByRef lvw As ListView)
			Me.PULinkItem.Initialize()
			Me.iMethod = 2
			Me.frn = CUSTOMPU.OpenCustomPUDB(False, True)
			If Me.frn < 0S Then
				Return
			End If
			Me.m_lvwCustomPU = lvw
			If lvw.SelectedIndices IsNot Nothing Then
				Try
					Me.nSelectedIndex = lvw.SelectedIndices(0)
				Catch ex As Exception
					MessageBox.Show("Please select a unit to modify")
					FileSystem.FileClose(New Integer() { CInt(Me.frn) })
					Return
				End Try
			End If
			Me.itm = lvw.SelectedItems(0)
			Me.Tag = Me.itm.Index
			Me.nIndex = Conversions.ToShort(Me.itm.SubItems(4).Text)
			Dim fileNumber As Integer = CInt(Me.frn)
			Dim valueType As ValueType = Me.puRec
			FileSystem.FileGet(fileNumber, valueType, CLng(Me.nIndex))
			Dim valueType2 As ValueType = valueType
			Dim pudataRec As RSWIN_DESC.PUDataRec
			Me.puRec = If((valueType2 IsNot Nothing), CType(valueType2, RSWIN_DESC.PUDataRec), pudataRec)
			Util.BusyCursor()
			Me.SetUnitDimensions(Me.puRec)
			Me.PerformLoad()
			Me.cboCrankHoles.SelectedIndex = CInt((Me.puRec.CrankHoles - 1S))
			Me.txtManufacturer.Focus()
			Me.ShowDialog()
		End Sub

		Public Sub NewCustomPU(ByRef lst As ListView)
			Me.PULinkItem.Initialize()
			Me.frn = CUSTOMPU.OpenCustomPUDB(False, True)
			If Me.frn < 0S Then
				Return
			End If
			Me.iMethod = 1
			Me.m_lvwCustomPU = lst
			Util.BusyCursor()
			Me.Tag = ""
			Me.PerformLoad()
			Me.initform()
			Me.CheckRequiredRotationCombo()
			Me.cboRequiredRotation.SelectedIndex = 2
			Me.txtManufacturer.Focus()
			Me.ShowDialog()
		End Sub

		Private Sub txtUnitName_Enter(sender As Object, e As EventArgs)
			Me.txtUnitName.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub txtUnitName_Leave(sender As Object, e As EventArgs)
			Dim txtUnitName As Control = Me.txtUnitName
			CtrlUI.Control_LostFocus(txtUnitName)
			Me.txtUnitName = CType(txtUnitName, TextBox)
		End Sub

		Private Sub txtOtherInfo_Enter(sender As Object, e As EventArgs)
			Me.txtOtherInfo.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub cboUnitType_Enter(sender As Object, e As EventArgs)
			Me.cboUnitType.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub cboUnitType_Leave(sender As Object, e As EventArgs)
			Dim cboUnitType As Control = Me.cboUnitType
			CtrlUI.Control_LostFocus(cboUnitType)
			Me.cboUnitType = CType(cboUnitType, ComboBox)
		End Sub

		Private Sub cboCrankHoles_Enter(sender As Object, e As EventArgs)
			Me.cboCrankHoles.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub cboCrankHoles_Leave(sender As Object, e As EventArgs)
			Dim cboCrankHoles As Control = Me.cboCrankHoles
			CtrlUI.Control_LostFocus(cboCrankHoles)
			Me.cboCrankHoles = CType(cboCrankHoles, ComboBox)
			Me.SetRadiusTextBoxes()
		End Sub

		Private Sub txtSprocketDiameter_Enter(sender As Object, e As EventArgs)
			Me.txtSprocketDiameter.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub PerformLoad()
			If Strings.Len(RuntimeHelpers.GetObjectValue(Me.Tag)) = 0 Then
				Me.cboUnitType.SelectedIndex = 0
			End If
			Me.ShowUnitStroke(-1S)
		End Sub

		Private Sub txtSprocketDistance_Enter(sender As Object, e As EventArgs)
			Me.txtSprocketDistance.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub txtDrumDiamRatio_Enter(sender As Object, e As EventArgs)
			Me.txtDrumDiamRatio.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub txtPitmanLength_Enter(sender As Object, e As EventArgs)
			Me.txtPitmanLength.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub txtA_Enter(sender As Object, e As EventArgs)
			Me.txtA.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub txtC_Enter(sender As Object, e As EventArgs)
			Me.txtC.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub txtI_Enter(sender As Object, e As EventArgs)
			Me.txtI.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub txtK_Enter(sender As Object, e As EventArgs)
			Me.txtK.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub txtP_Enter(sender As Object, e As EventArgs)
			Me.txtP.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub txtS_Enter(sender As Object, e As EventArgs)
			Me.txtS.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub txtV0_Enter(sender As Object, e As EventArgs)
			Me.txtV0.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub txtM_Enter(sender As Object, e As EventArgs)
			Me.txtM.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub txtA_ABAL_Enter(sender As Object, e As EventArgs)
			Me.txtA_ABAL.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub txtC_ABAL_Enter(sender As Object, e As EventArgs)
			Me.txtC_ABAL.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub txtI_ABAL_Enter(sender As Object, e As EventArgs)
			Me.txtI_ABAL.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub txtK_ABAL_Enter(sender As Object, e As EventArgs)
			Me.txtK_ABAL.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub txtP_ABAL_Enter(sender As Object, e As EventArgs)
			Me.txtP_ABAL.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub txtA_MII_Enter(sender As Object, e As EventArgs)
			Me.txtA_MII.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub txtC_MII_Enter(sender As Object, e As EventArgs)
			Me.txtC_MII.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub txtI_MII_Enter(sender As Object, e As EventArgs)
			Me.txtI_MII.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub txtK_MII_Enter(sender As Object, e As EventArgs)
			Me.txtK_MII.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub txtP_MII_Enter(sender As Object, e As EventArgs)
			Me.txtP_MII.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub txtGearboxRating_Enter(sender As Object, e As EventArgs)
			Me.txtGearboxRating.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub txtStructRating_Enter(sender As Object, e As EventArgs)
			Me.txtStructRating.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub txtMaxStroke_Enter(sender As Object, e As EventArgs)
			Me.txtMaxStroke.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub txtArtInertia_Enter(sender As Object, e As EventArgs)
			Me.txtArtInertia.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub txtManufacturer_Enter(sender As Object, e As EventArgs)
			Me.txtManufacturer.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub txtManufacturer_Leave(sender As Object, e As EventArgs)
			Dim txtManufacturer As Control = Me.txtManufacturer
			CtrlUI.Control_LostFocus(txtManufacturer)
			Me.txtManufacturer = CType(txtManufacturer, TextBox)
		End Sub

		Private Sub _txtR_1_TextChanged(sender As Object, e As EventArgs)
			Dim txtR_ As TextBox = Me._txtR_1
			Dim label_ As Label = Me._Label_9
			Me.TextBox_Change(txtR_, label_)
			Me._Label_9 = label_
			Me._txtR_1 = txtR_
			Me.ShowUnitStroke(1S)
		End Sub

		Private Sub _txtR_2_TextChanged(sender As Object, e As EventArgs)
			Dim txtR_ As TextBox = Me._txtR_2
			Dim label_ As Label = Me._Label_10
			Me.TextBox_Change(txtR_, label_)
			Me._Label_10 = label_
			Me._txtR_2 = txtR_
			Me.ShowUnitStroke(2S)
		End Sub

		Private Sub _txtR_3_TextChanged(sender As Object, e As EventArgs)
			Dim txtR_ As TextBox = Me._txtR_3
			Dim label_ As Label = Me._Label_11
			Me.TextBox_Change(txtR_, label_)
			Me._Label_11 = label_
			Me._txtR_3 = txtR_
			Me.ShowUnitStroke(3S)
		End Sub

		Private Sub _txtR_4_TextChanged(sender As Object, e As EventArgs)
			Dim txtR_ As TextBox = Me._txtR_4
			Dim label_ As Label = Me._Label_12
			Me.TextBox_Change(txtR_, label_)
			Me._Label_12 = label_
			Me._txtR_4 = txtR_
			Me.ShowUnitStroke(4S)
		End Sub

		Private Sub _txtR_5_TextChanged(sender As Object, e As EventArgs)
			Dim txtR_ As TextBox = Me._txtR_5
			Dim label_ As Label = Me._Label_13
			Me.TextBox_Change(txtR_, label_)
			Me._Label_13 = label_
			Me._txtR_5 = txtR_
			Me.ShowUnitStroke(5S)
		End Sub

		Private Sub SetTxtRBackColor(ByRef txt As TextBox)
			txt.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub _txtR_1_Enter(sender As Object, e As EventArgs)
			Dim txtR_ As TextBox = Me._txtR_1
			Me.SetTxtRBackColor(txtR_)
			Me._txtR_1 = txtR_
		End Sub

		Private Sub _txtR_2_Enter(sender As Object, e As EventArgs)
			Dim txtR_ As TextBox = Me._txtR_2
			Me.SetTxtRBackColor(txtR_)
			Me._txtR_2 = txtR_
		End Sub

		Private Sub _txtR_3_Enter(sender As Object, e As EventArgs)
			Dim txtR_ As TextBox = Me._txtR_3
			Me.SetTxtRBackColor(txtR_)
			Me._txtR_3 = txtR_
		End Sub

		Private Sub _txtR_4_Enter(sender As Object, e As EventArgs)
			Dim txtR_ As TextBox = Me._txtR_4
			Me.SetTxtRBackColor(txtR_)
			Me._txtR_4 = txtR_
		End Sub

		Private Sub _txtR_5_Enter(sender As Object, e As EventArgs)
			Dim txtR_ As TextBox = Me._txtR_5
			Me.SetTxtRBackColor(txtR_)
			Me._txtR_5 = txtR_
		End Sub

		Private Sub _txtR_1_Leave(sender As Object, e As EventArgs)
			Me.txtR_LostFocus(1)
		End Sub

		Private Sub _txtR_2_Leave(sender As Object, e As EventArgs)
			Me.txtR_LostFocus(2)
		End Sub

		Private Sub _txtR_3_Leave(sender As Object, e As EventArgs)
			Me.txtR_LostFocus(3)
		End Sub

		Private Sub _txtR_4_Leave(sender As Object, e As EventArgs)
			Me.txtR_LostFocus(4)
		End Sub

		Private Sub _txtR_5_Leave(sender As Object, e As EventArgs)
			Me.txtR_LostFocus(5)
		End Sub

		Private Sub txtR_LostFocus(Index As Integer)
		End Sub

		Public Sub MakeAPIDimErrorMessage(APIName As String, Min As Single, Max As Single, EUnits As String, Munits As String, EtoM As Single, ByRef msg As String)
			Dim array As String() = New String(7) {}
			array(0) = "The "
			array(1) = APIName
			array(2) = " dimension must be between "
			Dim array2 As String() = array
			Dim num As Integer = 3
			Dim obj As Object = Min
			Dim text As String = Util.Format(obj)
			Min = Conversions.ToSingle(obj)
			array2(num) = text
			array(4) = " and "
			Dim array3 As String() = array
			Dim num2 As Integer = 5
			Dim obj2 As Object = Max
			Dim text2 As String = Util.Format(obj2)
			Max = Conversions.ToSingle(obj2)
			array3(num2) = text2
			array(6) = " "
			array(7) = EUnits
			msg = String.Concat(array)
			If RSWIN_DESC.SETUP_MeasurementSystem = 3 Then
				array = New String(7) {}
				array(0) = msg
				array(1) = "~("
				Dim array4 As String() = array
				Dim num3 As Integer = 2
				Dim num4 As Single = Min * EtoM
				Dim text3 As String = "0.0"
				array4(num3) = Util.Format(num4, text3)
				array(3) = " and "
				Dim array5 As String() = array
				Dim num5 As Integer = 4
				Dim num6 As Single = Max * EtoM
				Dim text4 As String = "0.0"
				array5(num5) = Util.Format(num6, text4)
				array(5) = " "
				array(6) = Munits
				array(7) = ")"
				msg = String.Concat(array)
			End If
			msg += "."
		End Sub

		Private Sub txtArtInertia_EnabledChanged(sender As Object, e As EventArgs)
			If Me.txtArtInertia.Enabled Then
				Me.lblArtInertia_Disabled.SendToBack()
			Else
				Me.lblArtInertia_Disabled.BringToFront()
			End If
		End Sub

		Private Sub txtCrankCBMoment_TextChanged(sender As Object, e As EventArgs)
			Try
				Dim txtCrankCBMoment As TextBox = Me.txtCrankCBMoment
				Dim lblCrankCBMoment As Label = Me.lblCrankCBMoment
				Me.TextBox_Change(txtCrankCBMoment, lblCrankCBMoment)
				Me.lblCrankCBMoment = lblCrankCBMoment
				Me.txtCrankCBMoment = txtCrankCBMoment
				If Versioned.IsNumeric(Me.txtCrankCBMoment.Text) Then
					Me.PULinkItem.M = Convert.ToSingle(Me.txtCrankCBMoment.Text)
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub txtCrankCBMoment_Leave(sender As Object, e As EventArgs)
			If Me.PULinkItem.UnitType = 8S AndAlso Versioned.IsNumeric(Me.txtCrankCBMoment.Text) AndAlso (Convert.ToSingle(Me.txtCrankCBMoment.Text) < 1F Or Convert.ToSingle(Me.txtCrankCBMoment.Text) > 10F) Then
				MessageBox.Show("With Beam Balanced units crank CB moment should be between 1000 and 10000 lbs")
			End If
			Dim txtCrankCBMoment As Control = Me.txtCrankCBMoment
			CtrlUI.Control_LostFocus(txtCrankCBMoment)
			Me.txtCrankCBMoment = CType(txtCrankCBMoment, TextBox)
		End Sub

		Private Sub txtK_lp_TextChanged(sender As Object, e As EventArgs)
			Try
				Dim txtK_LP As TextBox = Me.txtK_LP
				Dim lblK As Label = Me.lblK
				Me.TextBox_Change(txtK_LP, lblK)
				Me.lblK = lblK
				Me.txtK_LP = txtK_LP
				If Versioned.IsNumeric(Me.txtK_LP.Text) Then
					Me.PULinkItem.K = Convert.ToSingle(Me.txtK_LP.Text)
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub txtI_lp_TextChanged(sender As Object, e As EventArgs)
			Try
				Dim txtI_lp As TextBox = Me.txtI_lp
				Dim lblI As Label = Me.lblI
				Me.TextBox_Change(txtI_lp, lblI)
				Me.lblI = lblI
				Me.txtI_lp = txtI_lp
				If Versioned.IsNumeric(Me.txtI_lp.Text) Then
					Me.PULinkItem.I = Convert.ToSingle(Me.txtI_lp.Text)
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub txtD_lp_KeyPress(eventSender As Object, eventArgs As KeyPressEventArgs)
			' The following expression was wrapped in a checked-expression
			Dim num As Short = CShort(Strings.Asc(eventArgs.KeyChar))
			If num = 0S Then
				eventArgs.Handled = True
			End If
		End Sub

		Private Sub txtD_lp_Leave(eventSender As Object, eventArgs As EventArgs)
			Dim txtD_lp As Control = Me.txtD_lp
			CtrlUI.Control_LostFocus(txtD_lp)
			Me.txtD_lp = CType(txtD_lp, TextBox)
			Dim msgtxt As String = Me.MakeAPIDimErrorMessage("D", 10F, 40F, RSWIN_DESC.ins, RSWIN_DESC.cm, RSWIN_DESC.IN__CM)
			Dim flag As Boolean = False
			Dim obj As Object
			If flag <> CtrlUI.CheckValid(Me.txtD_lp, True, False, obj) Then
				Dim obj2 As Object = flag
				Dim lowerBound As Single = 10F
				Dim inclusive As Integer = -1
				Dim errnum As Integer = 0
				Dim useMetric As Integer = 0
				Dim canadianIsMetric As Integer = 0
				Dim bQuiet As Boolean = False
				Dim text As String = ""
				If Operators.ConditionalCompareObjectEqual(obj2, Util.CheckLower(obj, lowerBound, inclusive, errnum, useMetric, canadianIsMetric, bQuiet, text), False) Then
					Util.Errmsg(msgtxt)
					Me.txtD_lp.Focus()
				Else
					Dim obj3 As Object = flag
					Dim upperBound As Single = 40F
					Dim inclusive2 As Integer = -1
					Dim errnum2 As Integer = 0
					Dim useMetric2 As Integer = 0
					Dim canadianIsMetric2 As Integer = 0
					Dim bQuiet2 As Boolean = False
					text = ""
					If Operators.ConditionalCompareObjectEqual(obj3, Util.CheckUpper(obj, upperBound, inclusive2, errnum2, useMetric2, canadianIsMetric2, bQuiet2, text), False) Then
						Util.Errmsg(msgtxt)
						Me.txtD_lp.Focus()
					ElseIf Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
						Me.PULinkItem.C = Conversions.ToSingle(obj)
					End If
				End If
			End If
		End Sub

		Private Sub txtD_lp_TextChanged(sender As Object, e As EventArgs)
			Try
				Dim txtD_lp As TextBox = Me.txtD_lp
				Dim lblD As Label = Me.lblD
				Me.TextBox_Change(txtD_lp, lblD)
				Me.lblD = lblD
				Me.txtD_lp = txtD_lp
				If Versioned.IsNumeric(Me.txtD_lp.Text) Then
					Me.PULinkItem.C = Convert.ToSingle(Me.txtD_lp.Text)
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub txtTheta_TextChanged(sender As Object, e As EventArgs)
			Try
				Dim txtTheta As TextBox = Me.txtTheta
				Dim lblTheta As Label = Me.lblTheta
				Me.TextBox_Change(txtTheta, lblTheta)
				Me.lblTheta = lblTheta
				Me.txtTheta = txtTheta
				If Versioned.IsNumeric(Me.txtTheta.Text) Then
					Me.PULinkItem.CrankOffset = Convert.ToSingle(Me.txtTheta.Text)
				End If
			Catch ex As Exception
			End Try
		End Sub

		Private Sub txtTheta_Enter(sender As Object, e As EventArgs)
			Me.txtTheta.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub txtD_lp_Enter(sender As Object, e As EventArgs)
			Me.txtD_lp.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub txtI_lp_Enter(sender As Object, e As EventArgs)
			Me.txtI_lp.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub txtK_LP_Enter(sender As Object, e As EventArgs)
			Me.txtK_LP.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub txtCrankCBMoment_Enter(sender As Object, e As EventArgs)
			Me.txtCrankCBMoment.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub txtK_LP_Leave(sender As Object, e As EventArgs)
			Dim txtK_LP As Control = Me.txtK_LP
			CtrlUI.Control_LostFocus(txtK_LP)
			Me.txtK_LP = CType(txtK_LP, TextBox)
		End Sub

		Private Sub txtI_lp_Leave(sender As Object, e As EventArgs)
			Dim txtI_lp As Control = Me.txtI_lp
			CtrlUI.Control_LostFocus(txtI_lp)
			Me.txtI_lp = CType(txtI_lp, TextBox)
		End Sub

		Private Sub txtTheta_Leave(sender As Object, e As EventArgs)
			Dim txtTheta As Control = Me.txtTheta
			CtrlUI.Control_LostFocus(txtTheta)
			Me.txtTheta = CType(txtTheta, TextBox)
		End Sub

		Private Function GetRequiredRotation() As Integer
			Dim result As Short
			If Me.cboRequiredRotation.SelectedIndex = 0 Then
				result = 1S
			ElseIf Me.cboRequiredRotation.SelectedIndex = 1 Then
				result = -1S
			ElseIf Me.cboRequiredRotation.SelectedIndex = 2 Then
				result = 0S
			End If
			Return CInt(result)
		End Function

		Private Sub cboRequiredRotation_SelectedIndexChanged(sender As Object, e As EventArgs)
			If Me.ActiveControl Is Me.cboRequiredRotation Then
				If Me.cboRequiredRotation.SelectedIndex = 0 Then
					Me.PULinkItem.RequiredRotation = 1S
				ElseIf Me.cboRequiredRotation.SelectedIndex = 1 Then
					Me.PULinkItem.RequiredRotation = -1S
				ElseIf Me.cboRequiredRotation.SelectedIndex = 2 Then
					Me.PULinkItem.RequiredRotation = 0S
				End If
				Return
			End If
		End Sub

		Private Sub CheckRequiredRotationCombo()
			If Me.cboRequiredRotation.Items.Count <> 3 Then
				Me.cboRequiredRotation.Items.Clear()
				Me.cboRequiredRotation.Items.Add("Clockwise")
				Me.cboRequiredRotation.Items.Add("Counterclockwise")
				Me.cboRequiredRotation.Items.Add("None")
			End If
		End Sub

		Public Function GetHydraulicRadius(fMaxStroke As Single, ByRef fCLine As Single) As Single
			Dim num As Single = 20F
			Dim result As Single
			Try
				If fMaxStroke = 360F Then
					num = 40F
				ElseIf fMaxStroke = 348F Then
					num = 36F
				ElseIf fMaxStroke = 336F Then
					num = 32F
				ElseIf fMaxStroke = 312F Then
					num = 31F
				ElseIf fMaxStroke = 288F Then
					num = 30F
				ElseIf fMaxStroke = 264F Then
					num = 27F
				ElseIf fMaxStroke = 240F Then
					num = 24F
				ElseIf fMaxStroke = 204F Then
					num = 22F
				ElseIf fMaxStroke = 168F Then
					num = 20F
				ElseIf fMaxStroke > 354F Then
					num = 40F
				ElseIf fMaxStroke < 354F And fMaxStroke >= 342F Then
					num = 36F
				ElseIf fMaxStroke < 342F And fMaxStroke >= 324F Then
					num = 32F
				ElseIf fMaxStroke < 324F And fMaxStroke >= 300F Then
					num = 31F
				ElseIf fMaxStroke < 300F And fMaxStroke >= 276F Then
					num = 30F
				ElseIf fMaxStroke < 276F And fMaxStroke >= 252F Then
					num = 27F
				ElseIf fMaxStroke < 252F And fMaxStroke >= 222F Then
					num = 24F
				ElseIf fMaxStroke < 222F And fMaxStroke >= 186F Then
					num = 22F
				ElseIf fMaxStroke < 186F Then
					num = 20F
				End If
				fCLine = fMaxStroke - num
				result = num
			Catch ex As Exception
				result = 20F
			End Try
			Return result
		End Function

		Private Sub txtB_lp_Enter(sender As Object, e As EventArgs)
			Me.txtB_lp.BackColor = RSWIN_DESC.rgbEditFocus
		End Sub

		Private Sub txtB_lp_TextChanged(eventSender As Object, eventArgs As EventArgs)
			Dim txtB_lp As TextBox = Me.txtB_lp
			Dim lblB As Label = Me.lblB
			Me.TextBox_Change(txtB_lp, lblB)
			Me.lblB = lblB
			Me.txtB_lp = txtB_lp
			Me.ShowUnitStroke(-1S)
		End Sub

		Private Sub txtB_lp_KeyPress(eventSender As Object, eventArgs As KeyPressEventArgs)
			' The following expression was wrapped in a checked-expression
			Dim num As Short = CShort(Strings.Asc(eventArgs.KeyChar))
			If num = 0S Then
				eventArgs.Handled = True
			End If
		End Sub

		Private Sub txtB_lp_Leave(eventSender As Object, eventArgs As EventArgs)
			Dim txtB_lp As Control = Me.txtB_lp
			CtrlUI.Control_LostFocus(txtB_lp)
			Me.txtB_lp = CType(txtB_lp, TextBox)
			Dim msgtxt As String = Me.MakeAPIDimErrorMessage("B", 15F, 500F, RSWIN_DESC.ins, RSWIN_DESC.cm, RSWIN_DESC.IN__CM)
			Dim flag As Boolean = False
			Dim obj As Object
			If flag = CtrlUI.CheckValid(Me.txtB_lp, True, False, obj) Then
				Return
			End If
			Dim obj2 As Object = flag
			Dim lowerBound As Single = 15F
			Dim inclusive As Integer = -1
			Dim errnum As Integer = 0
			Dim useMetric As Integer = 0
			Dim canadianIsMetric As Integer = 0
			Dim bQuiet As Boolean = False
			Dim text As String = ""
			If Operators.ConditionalCompareObjectEqual(obj2, Util.CheckLower(obj, lowerBound, inclusive, errnum, useMetric, canadianIsMetric, bQuiet, text), False) Then
				Util.Errmsg(msgtxt)
				Me.txtB_lp.Focus()
				Return
			End If
			Dim obj3 As Object = flag
			Dim upperBound As Single = 500F
			Dim inclusive2 As Integer = -1
			Dim errnum2 As Integer = 0
			Dim useMetric2 As Integer = 0
			Dim canadianIsMetric2 As Integer = 0
			Dim bQuiet2 As Boolean = False
			text = ""
			If Operators.ConditionalCompareObjectEqual(obj3, Util.CheckUpper(obj, upperBound, inclusive2, errnum2, useMetric2, canadianIsMetric2, bQuiet2, text), False) Then
				Util.Errmsg(msgtxt)
				Me.txtB_lp.Focus()
				Return
			End If
			If Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(obj)) Then
				Me.PULinkItem.A = Conversions.ToSingle(obj)
			End If
		End Sub

		Public Sub ResetClock()
			Try
				If RSWIN_DESC.SETUP_ExitIfIdle <> 0S Then
					If Me.MyParentFrm Is Nothing Then
						Try
							Me.MyParentFrm = RSWIN_DESC.frmMain
						Catch ex As Exception
						End Try
					End If
					Me.MyParentFrm.ResetClock()
				End If
			Catch ex2 As Exception
			End Try
		End Sub

		Private Sub _Label_GearboxRating_TextChanged(sender As Object, e As EventArgs)
			Debug.WriteLine(Me._Label_GearboxRating.Text)
		End Sub

		Private Sub lblArtInertia_TextChanged(sender As Object, e As EventArgs)
			Debug.WriteLine(Me.lblArtInertia.Text)
		End Sub

		<AccessedThroughProperty("cmdOK")>
		Private _cmdOK As Button

		<AccessedThroughProperty("cmdCancel")>
		Private _cmdCancel As Button

		<AccessedThroughProperty("cmdHelp")>
		Private _cmdHelp As Button

		<AccessedThroughProperty("txtM")>
		Private _txtM As TextBox

		<AccessedThroughProperty("txtS")>
		Private _txtS As TextBox

		<AccessedThroughProperty("txtV0")>
		Private _txtV0 As TextBox

		<AccessedThroughProperty("_Label_25")>
		Private __Label_25 As Label

		<AccessedThroughProperty("_Label_26")>
		Private __Label_26 As Label

		<AccessedThroughProperty("_Label_27")>
		Private __Label_27 As Label

		<AccessedThroughProperty("_panDimensions_4")>
		Private __panDimensions_4 As Panel

		<AccessedThroughProperty("txtUnbalance")>
		Private _txtUnbalance As TextBox

		<AccessedThroughProperty("txtCrankOffset")>
		Private _txtCrankOffset As TextBox

		<AccessedThroughProperty("_Label_23")>
		Private __Label_23 As Label

		<AccessedThroughProperty("_Label_24")>
		Private __Label_24 As Label

		<AccessedThroughProperty("_panDimensions_3")>
		Private __panDimensions_3 As Panel

		<AccessedThroughProperty("txtPitmanLength")>
		Private _txtPitmanLength As TextBox

		<AccessedThroughProperty("txtDrumDiamRatio")>
		Private _txtDrumDiamRatio As TextBox

		<AccessedThroughProperty("txtSprocketDistance")>
		Private _txtSprocketDistance As TextBox

		<AccessedThroughProperty("txtSprocketDiameter")>
		Private _txtSprocketDiameter As TextBox

		<AccessedThroughProperty("_panCalcStroke_0")>
		Private __panCalcStroke_0 As Label

		<AccessedThroughProperty("_Label_30")>
		Private __Label_30 As Label

		<AccessedThroughProperty("_Label_17")>
		Private __Label_17 As Label

		<AccessedThroughProperty("_Label_16")>
		Private __Label_16 As Label

		<AccessedThroughProperty("_Label_15")>
		Private __Label_15 As Label

		<AccessedThroughProperty("_Label_14")>
		Private __Label_14 As Label

		<AccessedThroughProperty("cboCrankHoles")>
		Private _cboCrankHoles As ComboBox

		<AccessedThroughProperty("_txtR_5")>
		Private __txtR_5 As TextBox

		<AccessedThroughProperty("_txtR_4")>
		Private __txtR_4 As TextBox

		<AccessedThroughProperty("_txtR_3")>
		Private __txtR_3 As TextBox

		<AccessedThroughProperty("_txtR_2")>
		Private __txtR_2 As TextBox

		<AccessedThroughProperty("_txtR_1")>
		Private __txtR_1 As TextBox

		<AccessedThroughProperty("_panCalcStroke_5")>
		Private __panCalcStroke_5 As Label

		<AccessedThroughProperty("_panCalcStroke_4")>
		Private __panCalcStroke_4 As Label

		<AccessedThroughProperty("_panCalcStroke_3")>
		Private __panCalcStroke_3 As Label

		<AccessedThroughProperty("_panCalcStroke_2")>
		Private __panCalcStroke_2 As Label

		<AccessedThroughProperty("_panCalcStroke_1")>
		Private __panCalcStroke_1 As Label

		<AccessedThroughProperty("_Label_8")>
		Private __Label_8 As Label

		<AccessedThroughProperty("_Label_13")>
		Private __Label_13 As Label

		<AccessedThroughProperty("_Label_12")>
		Private __Label_12 As Label

		<AccessedThroughProperty("_Label_11")>
		Private __Label_11 As Label

		<AccessedThroughProperty("_Label_10")>
		Private __Label_10 As Label

		<AccessedThroughProperty("_Label_9")>
		Private __Label_9 As Label

		<AccessedThroughProperty("_Label_29")>
		Private __Label_29 As Label

		<AccessedThroughProperty("_panDimensions_0")>
		Private __panDimensions_0 As Panel

		<AccessedThroughProperty("txtP")>
		Private _txtP As TextBox

		<AccessedThroughProperty("txtK")>
		Private _txtK As TextBox

		<AccessedThroughProperty("txtI")>
		Private _txtI As TextBox

		<AccessedThroughProperty("txtC")>
		Private _txtC As TextBox

		<AccessedThroughProperty("txtA")>
		Private _txtA As TextBox

		<AccessedThroughProperty("_Label_18")>
		Private __Label_18 As Label

		<AccessedThroughProperty("_Label_19")>
		Private __Label_19 As Label

		<AccessedThroughProperty("_Label_20")>
		Private __Label_20 As Label

		<AccessedThroughProperty("_Label_21")>
		Private __Label_21 As Label

		<AccessedThroughProperty("_Label_22")>
		Private __Label_22 As Label

		<AccessedThroughProperty("_panDimensions_2")>
		Private __panDimensions_2 As Panel

		<AccessedThroughProperty("txtGearboxRating")>
		Private _txtGearboxRating As TextBox

		<AccessedThroughProperty("txtStructRating")>
		Private _txtStructRating As TextBox

		<AccessedThroughProperty("txtMaxStroke")>
		Private _txtMaxStroke As TextBox

		<AccessedThroughProperty("cboUnitType")>
		Private _cboUnitType As ComboBox

		<AccessedThroughProperty("txtManufacturer")>
		Private _txtManufacturer As TextBox

		<AccessedThroughProperty("txtOtherInfo")>
		Private _txtOtherInfo As TextBox

		<AccessedThroughProperty("txtUnitName")>
		Private _txtUnitName As TextBox

		<AccessedThroughProperty("txtArtInertia")>
		Private _txtArtInertia As TextBox

		<AccessedThroughProperty("lblAPIDesignation")>
		Private _lblAPIDesignation As Label

		<AccessedThroughProperty("_Label_6")>
		Private __Label_6 As Label

		<AccessedThroughProperty("_Label_5")>
		Private __Label_5 As Label

		<AccessedThroughProperty("_Label_3")>
		Private __Label_3 As Label

		<AccessedThroughProperty("_Label_0")>
		Private __Label_0 As Label

		<AccessedThroughProperty("_Label_2")>
		Private __Label_2 As Label

		<AccessedThroughProperty("_Label_1")>
		Private __Label_1 As Label

		<AccessedThroughProperty("_SSFrame_0")>
		Private __SSFrame_0 As GroupBox

		<AccessedThroughProperty("cmdLoad")>
		Private _cmdLoad As Button

		<AccessedThroughProperty("Label")>
		Private _Label As LabelArray

		<AccessedThroughProperty("Line")>
		Private _Line As LabelArray

		<AccessedThroughProperty("SSFrame")>
		Private _SSFrame As GroupBoxArray

		<AccessedThroughProperty("panCalcStroke")>
		Private _panCalcStroke As LabelArray

		<AccessedThroughProperty("panDimensions")>
		Private _panDimensions As PanelArray

		<AccessedThroughProperty("txtR")>
		Private _txtR As TextBoxArray

		<AccessedThroughProperty("HelpProvider1")>
		Private _HelpProvider1 As HelpProvider

		<AccessedThroughProperty("txtA_ABAL")>
		Private _txtA_ABAL As TextBox

		<AccessedThroughProperty("_panDimensions_2_ABAL")>
		Private __panDimensions_2_ABAL As Panel

		<AccessedThroughProperty("txtP_ABAL")>
		Private _txtP_ABAL As TextBox

		<AccessedThroughProperty("txtK_ABAL")>
		Private _txtK_ABAL As TextBox

		<AccessedThroughProperty("txtI_ABAL")>
		Private _txtI_ABAL As TextBox

		<AccessedThroughProperty("txtC_ABAL")>
		Private _txtC_ABAL As TextBox

		<AccessedThroughProperty("Label_A_ABAL")>
		Private _Label_A_ABAL As Label

		<AccessedThroughProperty("Label_C_ABAL")>
		Private _Label_C_ABAL As Label

		<AccessedThroughProperty("Label_I_ABAL")>
		Private _Label_I_ABAL As Label

		<AccessedThroughProperty("Label_K_ABAL")>
		Private _Label_K_ABAL As Label

		<AccessedThroughProperty("Label_P_ABAL")>
		Private _Label_P_ABAL As Label

		<AccessedThroughProperty("_panDimensions_2_MII")>
		Private __panDimensions_2_MII As Panel

		<AccessedThroughProperty("txtP_MII")>
		Private _txtP_MII As TextBox

		<AccessedThroughProperty("txtK_MII")>
		Private _txtK_MII As TextBox

		<AccessedThroughProperty("txtI_MII")>
		Private _txtI_MII As TextBox

		<AccessedThroughProperty("txtC_MII")>
		Private _txtC_MII As TextBox

		<AccessedThroughProperty("txtA_MII")>
		Private _txtA_MII As TextBox

		<AccessedThroughProperty("Label_A_MII")>
		Private _Label_A_MII As Label

		<AccessedThroughProperty("Label_C_MII")>
		Private _Label_C_MII As Label

		<AccessedThroughProperty("Label_I_MII")>
		Private _Label_I_MII As Label

		<AccessedThroughProperty("Label_K_MII")>
		Private _Label_K_MII As Label

		<AccessedThroughProperty("Label_P_MII")>
		Private _Label_P_MII As Label

		<AccessedThroughProperty("_txtR_2_disabled")>
		Private __txtR_2_disabled As Label

		<AccessedThroughProperty("_txtR_1_disabled")>
		Private __txtR_1_disabled As Label

		<AccessedThroughProperty("_txtR_4_disabled")>
		Private __txtR_4_disabled As Label

		<AccessedThroughProperty("_txtR_3_disabled")>
		Private __txtR_3_disabled As Label

		<AccessedThroughProperty("_txtR_5_disabled")>
		Private __txtR_5_disabled As Label

		<AccessedThroughProperty("lblArtInertia_Disabled")>
		Private _lblArtInertia_Disabled As Label

		<AccessedThroughProperty("lblCrankCBMoment")>
		Private _lblCrankCBMoment As Label

		<AccessedThroughProperty("txtCrankCBMoment")>
		Private _txtCrankCBMoment As TextBox

		<AccessedThroughProperty("cboRequiredRotation")>
		Private _cboRequiredRotation As ComboBox

		<AccessedThroughProperty("_panLowProfileBelt1")>
		Private __panLowProfileBelt1 As Panel

		<AccessedThroughProperty("txtD_lp")>
		Private _txtD_lp As TextBox

		<AccessedThroughProperty("txtB_lp")>
		Private _txtB_lp As TextBox

		<AccessedThroughProperty("lblB")>
		Private _lblB As Label

		<AccessedThroughProperty("lblD")>
		Private _lblD As Label

		<AccessedThroughProperty("lblI")>
		Private _lblI As Label

		<AccessedThroughProperty("txtI_lp")>
		Private _txtI_lp As TextBox

		<AccessedThroughProperty("lblK")>
		Private _lblK As Label

		<AccessedThroughProperty("txtK_LP")>
		Private _txtK_LP As TextBox

		<AccessedThroughProperty("_panLowProfileBelt2")>
		Private __panLowProfileBelt2 As Panel

		<AccessedThroughProperty("txtTheta")>
		Private _txtTheta As TextBox

		<AccessedThroughProperty("lblTheta")>
		Private _lblTheta As Label

		<AccessedThroughProperty("_panDimensions_longstroke")>
		Private __panDimensions_longstroke As Panel

		<AccessedThroughProperty("_Label_GearboxRating")>
		Private __Label_GearboxRating As Label

		<AccessedThroughProperty("lblArtInertia")>
		Private _lblArtInertia As Label

		<AccessedThroughProperty("_SSFrame_UnitDimensions")>
		Private __SSFrame_UnitDimensions As GroupBox

		<AccessedThroughProperty("_Label_API_designation")>
		Private __Label_API_designation As Label

		<AccessedThroughProperty("lblRequiredRotation")>
		Private _lblRequiredRotation As Label

		Private Shared m_vb6FormDefInstance As dlgCustomPU

		Private Shared m_InitializingDefInstance As Boolean

		Private MyParentFrm As RODSTAR

		Private Const LBLCALCSTROKE_CRANKS As Short = 29S

		Private Const LBLCALCSTROKE_LONGSTROKE As Short = 30S

		Private Const DIM_NONE As Short = -1S

		Private Const DIM_CRANKRADII As Short = 0S

		Private Const DIM_LONGSTROKE As Short = 1S

		Private Const DIM_API As Short = 2S

		Private Const DIM_CONVENTIONAL As Short = 3S

		Private Const DIM_AIRBALANCED As Short = 4S

		Private Const DIM_BELTEDLOWPROFILE As Short = 5S

		Private Const CDX_SETUPCUSTOMPUC As Short = 210S

		Private Const CDX_SETUPCUSTOMPUM As Short = 211S

		Private Const CDX_SETUPCUSTOMPUA As Short = 212S

		Private Const CDX_SETUPCUSTOMPUR As Short = 213S

		Private Const CDX_RC As Short = 320S

		Private Const CDX_RM As Short = 330S

		Private Const CDX_RA As Short = 340S

		Private sAlreadyPU As String

		Private sCalculatedStrokeLength As String

		Private iMethod As Integer

		Private bOK As Boolean

		Private frn As Short

		Private nIndex As Short

		Private puRec As RSWIN_DESC.PUDataRec

		Public PULinkItem As RSWIN_DESC.PUDataRec

		Private itm As ListViewItem

		Private nSelectedIndex As Integer

		Private I As Short

		Private nUnits As Short

		Private lst As ListView

		Private lvw As ListView

		Private m_lvwCustomPU As ListView
	End Class
End Namespace
