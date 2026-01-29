Imports System
Imports System.Diagnostics
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	Public Class TEImpred
		Public Property displacement_1_n As Double
			Get
				Return Me.m_displacement_1_n
			End Get
			Set(value As Double)
				Me.m_displacement_1_n = value
			End Set
		End Property

		Public Property Max_Rod_Elements As Integer
			Get
				Return Me.m_Max_Rod_Elements
			End Get
			Set(value As Integer)
				Me.m_Max_Rod_Elements = value
			End Set
		End Property

		Public Property angl_cwt_phase As Double
			Get
				Return Me.m_angl_cwt_phase
			End Get
			Set(value As Double)
				Me.m_angl_cwt_phase = value
				Me.m_p_s.angl_cwt_phase = Me.m_angl_cwt_phase
			End Set
		End Property

		Public Property API_len_A As Double
			Get
				Return Me.m_API_len_A
			End Get
			Set(value As Double)
				Me.m_API_len_A = value
				Me.m_p_s.API_len_A = Me.m_API_len_A
			End Set
		End Property

		Public Property p_s As TEImpred.parameter_structure_type
			Get
				Return Me.m_p_s
			End Get
			Set(value As TEImpred.parameter_structure_type)
				Me.m_p_s = value
			End Set
		End Property

		Public Property f_e As TEImpred.fluid_element_data_type()
			Get
				Return Me.m_f_e
			End Get
			Set(value As TEImpred.fluid_element_data_type())
				Me.m_f_e = value
			End Set
		End Property

		Public Property f_e(Index As Integer) As TEImpred.fluid_element_data_type
			Get
				Return Me.m_f_e(Index)
			End Get
			Set(value As TEImpred.fluid_element_data_type)
				Me.m_f_e(Index) = value
			End Set
		End Property

		Public Property l_u As TEImpred.lookup_table_data_type()
			Get
				Return Me.m_l_u
			End Get
			Set(value As TEImpred.lookup_table_data_type())
				Me.m_l_u = value
			End Set
		End Property

		Public Property l_u(Index As Integer) As TEImpred.lookup_table_data_type
			Get
				Return Me.m_l_u(Index)
			End Get
			Set(value As TEImpred.lookup_table_data_type)
				Me.m_l_u(Index) = value
			End Set
		End Property

		Public Property m_c As TEImpred.motor_characteristic_data_type()
			Get
				Return Me.m_m_c
			End Get
			Set(value As TEImpred.motor_characteristic_data_type())
				Me.m_m_c = value
			End Set
		End Property

		Public Property m_c(Index As Integer) As TEImpred.motor_characteristic_data_type
			Get
				Return Me.m_m_c(Index)
			End Get
			Set(value As TEImpred.motor_characteristic_data_type)
				Me.m_m_c(Index) = value
			End Set
		End Property

		Public Property m_c_rpm_mot(Index As Integer) As Double
			Get
				Return Me.m_m_c(Index).rpm_mot
			End Get
			Set(value As Double)
				Me.m_m_c(Index).rpm_mot = value
			End Set
		End Property

		Public Property m_c_torq_mot(Index As Integer) As Double
			Get
				Return Me.m_m_c(Index).torq_mot
			End Get
			Set(value As Double)
				Me.m_m_c(Index).torq_mot = value
			End Set
		End Property

		Public Property m_c_vel_mot(Index As Integer) As Double
			Get
				Return Me.m_m_c(Index).vel_mot
			End Get
			Set(value As Double)
				Me.m_m_c(Index).vel_mot = value
			End Set
		End Property

		Public Property p_u As TEImpred.pump_unit_data_point_type()
			Get
				Return Me.m_p_u
			End Get
			Set(value As TEImpred.pump_unit_data_point_type())
				Me.m_p_u = value
			End Set
		End Property

		Public Property p_u(Index As Integer) As TEImpred.pump_unit_data_point_type
			Get
				Return Me.m_p_u(Index)
			End Get
			Set(value As TEImpred.pump_unit_data_point_type)
				Me.m_p_u(Index) = value
			End Set
		End Property

		Public Property p_u_crank_angle(Index As Integer) As Double
			Get
				Return Me.m_p_u(Index).crank_angle
			End Get
			Set(value As Double)
				Me.m_p_u(Index).crank_angle = value
			End Set
		End Property

		Public Property p_u_p_r_position(Index As Integer) As Double
			Get
				Return Me.m_p_u(Index).p_r_position
			End Get
			Set(value As Double)
				Me.m_p_u(Index).p_r_position = value
			End Set
		End Property

		Public Property torq_gb_rating As Double
			Get
				Return Me.m_torq_gb_rating
			End Get
			Set(value As Double)
				Me.m_torq_gb_rating = value
			End Set
		End Property

		Public Property p_u_torque_factor(Index As Integer) As Double
			Get
				Return Me.m_p_u(Index).torque_factor
			End Get
			Set(value As Double)
				Me.m_p_u(Index).torque_factor = value
			End Set
		End Property

		Public Property d_l As TEImpred.dog_leg_data_type()
			Get
				Return Me.m_d_l
			End Get
			Set(value As TEImpred.dog_leg_data_type())
				Me.m_d_l = value
			End Set
		End Property

		Public Property d_l(Index As Integer) As TEImpred.dog_leg_data_type
			Get
				Return Me.m_d_l(Index)
			End Get
			Set(value As TEImpred.dog_leg_data_type)
				Me.m_d_l(Index) = value
			End Set
		End Property

		Public Property r_e As TEImpred.rod_element_data_type()
			Get
				Return Me.m_r_e
			End Get
			Set(value As TEImpred.rod_element_data_type())
				Me.m_r_e = value
			End Set
		End Property

		Public Property r_e(Index As Integer) As TEImpred.rod_element_data_type
			Get
				Return Me.m_r_e(Index)
			End Get
			Set(value As TEImpred.rod_element_data_type)
				Me.m_r_e(Index) = value
			End Set
		End Property

		Public Property r_t As TEImpred.rod_taper_data_type()
			Get
				Return Me.m_r_t
			End Get
			Set(value As TEImpred.rod_taper_data_type())
				Me.m_r_t = value
			End Set
		End Property

		Public Property r_t(Index As Integer) As TEImpred.rod_taper_data_type
			Get
				Return Me.m_r_t(Index)
			End Get
			Set(value As TEImpred.rod_taper_data_type)
				Me.m_r_t(Index) = value
			End Set
		End Property

		Public Property r_t_taper_depth(Index As Integer) As Double
			Get
				Return Me.m_r_t(Index).taper_depth
			End Get
			Set(value As Double)
				Me.m_r_t(Index).taper_depth = value
			End Set
		End Property

		Public Property r_t_grade(Index As Integer) As Integer
			Get
				Return Me.m_r_t(Index).Grade
			End Get
			Set(value As Integer)
				Me.m_r_t(Index).Grade = value
			End Set
		End Property

		Public Property r_t_rod_area(Index As Integer) As Double
			Get
				Return Me.m_r_t(Index).rod_area
			End Get
			Set(value As Double)
				Me.m_r_t(Index).rod_area = value
			End Set
		End Property

		Public Property r_t_rod_density(Index As Integer) As Double
			Get
				Return Me.m_r_t(Index).rod_density
			End Get
			Set(value As Double)
				Me.m_r_t(Index).rod_density = value
			End Set
		End Property

		Public Property r_t_rod_modulus(Index As Integer) As Double
			Get
				Return Me.m_r_t(Index).rod_modulus
			End Get
			Set(value As Double)
				Me.m_r_t(Index).rod_modulus = value
			End Set
		End Property

		Public Property r_t_friction_coef(Index As Integer) As Double
			Get
				Return Me.m_r_t(Index).friction_coef
			End Get
			Set(value As Double)
				Me.m_r_t(Index).friction_coef = value
			End Set
		End Property

		Public Property r_t_dimless_damp_dn(Index As Integer) As Double
			Get
				Return Me.m_r_t(Index).dimless_damp_dn
			End Get
			Set(value As Double)
				Me.m_r_t(Index).dimless_damp_dn = value
			End Set
		End Property

		Public Property r_t_dimless_damp_up(Index As Integer) As Double
			Get
				Return Me.m_r_t(Index).dimless_damp_up
			End Get
			Set(value As Double)
				Me.m_r_t(Index).dimless_damp_up = value
			End Set
		End Property

		Public Property r_t_max_taper_force(Index As Integer) As Double
			Get
				Return Me.m_r_t(Index).max_taper_force_top
			End Get
			Set(value As Double)
				Me.m_r_t(Index).max_taper_force_top = value
			End Set
		End Property

		Public Property r_t_max_taper_stress(Index As Integer) As Double
			Get
				Return Me.m_r_t(Index).max_taper_stress_top
			End Get
			Set(value As Double)
				Me.m_r_t(Index).max_taper_stress_top = value
			End Set
		End Property

		Public Property r_t_min_taper_force(Index As Integer) As Double
			Get
				Return Me.m_r_t(Index).min_taper_force_top
			End Get
			Set(value As Double)
				Me.m_r_t(Index).min_taper_force_top = value
			End Set
		End Property

		Public Property r_t_min_taper_stress(Index As Integer) As Double
			Get
				Return Me.m_r_t(Index).min_taper_stress_top
			End Get
			Set(value As Double)
				Me.m_r_t(Index).min_taper_stress_top = value
			End Set
		End Property

		Public Property r_t_rod_od(Index As Integer) As Double
			Get
				Return Me.m_r_t(Index).rod_od
			End Get
			Set(value As Double)
				Me.m_r_t(Index).rod_od = value
			End Set
		End Property

		Public Property r_t_rod_id(Index As Integer) As Double
			Get
				Return Me.m_r_t(Index).rod_id
			End Get
			Set(value As Double)
				Me.m_r_t(Index).rod_id = value
			End Set
		End Property

		Public Property r_t_rod_spring_con(Index As Integer) As Double
			Get
				Return Me.m_r_t(Index).rod_spring_con
			End Get
			Set(value As Double)
				Me.m_r_t(Index).rod_spring_con = value
			End Set
		End Property

		Public Property r_t_taper_len(Index As Integer) As Double
			Get
				Return Me.m_r_t(Index).taper_len
			End Get
			Set(value As Double)
				Me.m_r_t(Index).taper_len = value
			End Set
		End Property

		Public Property s_p As TEImpred.survey_point_type()
			Get
				Return Me.m_s_p
			End Get
			Set(value As TEImpred.survey_point_type())
				Me.m_s_p = value
			End Set
		End Property

		Public Property s_p(Index As Integer) As TEImpred.survey_point_type
			Get
				Return Me.m_s_p(Index)
			End Get
			Set(value As TEImpred.survey_point_type)
				Me.m_s_p(Index) = value
			End Set
		End Property

		Public Property s_p_m_d(Index As Integer) As Double
			Get
				Return Me.m_s_p(Index).m_d
			End Get
			Set(value As Double)
				Me.m_s_p(Index).m_d = value
			End Set
		End Property

		Public Property s_p_inc(Index As Integer) As Double
			Get
				Return Me.m_s_p(Index).inc
			End Get
			Set(value As Double)
				Me.m_s_p(Index).inc = value
			End Set
		End Property

		Public Property s_p_azi(Index As Integer) As Double
			Get
				Return Me.m_s_p(Index).azi
			End Get
			Set(value As Double)
				Me.m_s_p(Index).azi = value
			End Set
		End Property

		Public Property s_p_dog(Index As Integer) As Double
			Get
				Return Me.m_s_p(Index).dog
			End Get
			Set(value As Double)
				Me.m_s_p(Index).dog = value
			End Set
		End Property

		Public ReadOnly Property s_p_rad(Index As Integer) As Double
			Get
				Return Me.m_s_p(Index).rad
			End Get
		End Property

		Public Property t_s As TEImpred.timestep_data_type()
			Get
				Return Me.m_t_s
			End Get
			Set(value As TEImpred.timestep_data_type())
				Me.m_t_s = value
			End Set
		End Property

		Public Property t_s(Index As Integer) As TEImpred.timestep_data_type
			Get
				Return Me.m_t_s(Index)
			End Get
			Set(value As TEImpred.timestep_data_type)
				Me.m_t_s(Index) = value
			End Set
		End Property

		Public Property t_t As TEImpred.tbg_taper_data_type()
			Get
				Return Me.m_t_t
			End Get
			Set(value As TEImpred.tbg_taper_data_type())
				Me.m_t_t = value
			End Set
		End Property

		Public Property t_t(Index As Integer) As TEImpred.tbg_taper_data_type
			Get
				Return Me.m_t_t(Index)
			End Get
			Set(value As TEImpred.tbg_taper_data_type)
				Me.m_t_t(Index) = value
			End Set
		End Property

		Public Property t_t_taper_depth(Index As Integer) As Double
			Get
				Return Me.m_t_t(Index).taper_depth
			End Get
			Set(value As Double)
				Me.m_t_t(Index).taper_depth = value
			End Set
		End Property

		Public Property t_t_tbg_id(Index As Integer) As Double
			Get
				Return Me.m_t_t(Index).tbg_id
			End Get
			Set(value As Double)
				Me.m_t_t(Index).tbg_id = value
			End Set
		End Property

		Public Property t_t_tbg_od(Index As Integer) As Double
			Get
				Return Me.m_t_t(Index).tbg_od
			End Get
			Set(value As Double)
				Me.m_t_t(Index).tbg_od = value
			End Set
		End Property

		Public Property t_t_tbg_modulus(Index As Integer) As Double
			Get
				Return Me.m_t_t(Index).tbg_modulus
			End Get
			Set(value As Double)
				Me.m_t_t(Index).tbg_modulus = value
			End Set
		End Property

		Public Property anch_depth As Double
			Get
				Return Me.m_p_s.anch_depth
			End Get
			Set(value As Double)
				If value >= 0.0 Then
					Me.m_p_s.anch_depth = value
				End If
			End Set
		End Property

		Public Property PRHP As Single
			Get
				Return Me.m_PRHP
			End Get
			Set(value As Single)
				Me.m_PRHP = value
			End Set
		End Property

		Public Property PHP As Single
			Get
				Return Me.m_PHP
			End Get
			Set(value As Single)
				Me.m_PHP = value
			End Set
		End Property

		Public Property EHP As Single
			Get
				Return Me.m_EHP
			End Get
			Set(value As Single)
				Me.m_EHP = value
			End Set
		End Property

		Public Property casing_pressure As Double
			Get
				Return Me.m_p_s.casing_pressure
			End Get
			Set(value As Double)
				Me.m_p_s.casing_pressure = value
			End Set
		End Property

		Public Property comp_tot As Double
			Get
				Return Me.m_p_s.comp_tot
			End Get
			Set(value As Double)
				Me.m_p_s.comp_tot = value
			End Set
		End Property

		Public Property dimless_damp_flu As Double
			Get
				Return Me.m_p_s.dimless_damp_flu
			End Get
			Set(value As Double)
				Me.m_p_s.dimless_damp_flu = value
			End Set
		End Property

		Public Property char_vel_fluid As Double
			Get
				Return Me.m_p_s.char_vel_fluid
			End Get
			Set(value As Double)
				Me.m_p_s.char_vel_fluid = value
			End Set
		End Property

		Public Property tbg_flu_dens As Double
			Get
				Return Me.m_p_s.tbg_flu_dens
			End Get
			Set(value As Double)
				Me.m_p_s.tbg_flu_dens = value
			End Set
		End Property

		Public Property compress_tol As Double
			Get
				Return Me.m_p_s.compress_tol
			End Get
			Set(value As Double)
				Me.m_p_s.compress_tol = value
			End Set
		End Property

		Public Property cw_or_ccw As Integer
			Get
				Return Me.m_p_s.cw_or_ccw
			End Get
			Set(value As Integer)
				If Not(value <> 1 And value <> -1) Then
					Me.m_p_s.cw_or_ccw = value
				End If
			End Set
		End Property

		Public Property damp_fluid As Double
			Get
				Return Me.m_p_s.damp_fluid
			End Get
			Set(value As Double)
				Me.m_p_s.damp_fluid = value
			End Set
		End Property

		Public Property bGetVBeltRatio As Boolean
			Get
				Return Me.m_bGetVBeltRatio
			End Get
			Set(value As Boolean)
				Me.m_bGetVBeltRatio = value
			End Set
		End Property

		Public Property eff_gb As Double
			Get
				Return Me.m_p_s.eff_gb
			End Get
			Set(value As Double)
				If Not(0.0 > value Or value > 1.0) Then
					Me.m_p_s.eff_gb = value
				End If
			End Set
		End Property

		Public Property eff_pu As Double
			Get
				Return Me.m_p_s.eff_pu
			End Get
			Set(value As Double)
				If Not(0.0 > value Or value > 1.0) Then
					Me.m_p_s.eff_pu = value
				End If
			End Set
		End Property

		Public Property eff_vb As Double
			Get
				Return Me.m_p_s.eff_vb
			End Get
			Set(value As Double)
				If Not(0.0 > value Or value > 1.0) Then
					Me.m_p_s.eff_vb = value
				End If
			End Set
		End Property

		Public Property fluid_solution As Integer
			Get
				Return Me.m_p_s.fluid_solution
			End Get
			Set(value As Integer)
				Select Case value
					Case -1
						Me.m_p_s.fluid_solution = value
					Case 0
						Me.m_p_s.fluid_solution = value
					Case 1
						Me.m_p_s.fluid_solution = value
				End Select
			End Set
		End Property

		Public Property force_su As Double
			Get
				Return Me.m_p_s.force_su
			End Get
			Set(value As Double)
				Me.m_p_s.force_su = value
			End Set
		End Property

		Public Property four_bar_class As Integer
			Get
				Return Me.m_p_s.four_bar_class
			End Get
			Set(value As Integer)
				Select Case value
					Case 1
						Me.m_p_s.four_bar_class = value
						Return
					Case 3
						Me.m_p_s.four_bar_class = value
						Return
				End Select
				Me.m_p_s.four_bar_class = value
			End Set
		End Property

		Public Property gas_exponent As Double
			Get
				Return Me.m_p_s.gas_exponent
			End Get
			Set(value As Double)
				Me.m_p_s.gas_exponent = value
			End Set
		End Property

		Public Property hp_mot As Double
			Get
				Return Me.m_p_s.hp_mot
			End Get
			Set(value As Double)
				Me.m_p_s.hp_mot = value
			End Set
		End Property

		Public Property i_downhole_dyno As Integer
			Get
				Return Me.m_p_s.i_downhole_dyno
			End Get
			Set(value As Integer)
				If value >= 0 Then
					Me.m_p_s.i_downhole_dyno = value
				End If
			End Set
		End Property

		Public Property liquid_level As Double
			Get
				Return Me.m_p_s.liquid_level
			End Get
			Set(value As Double)
				Me.m_p_s.liquid_level = value
			End Set
		End Property

		Public Property max_iterations As Integer
			Get
				Return Me.m_p_s.max_iterations
			End Get
			Set(value As Integer)
				Me.m_p_s.max_iterations = value
			End Set
		End Property

		Public Property mot_pts As Integer
			Get
				Return Me.m_p_s.mot_pts
			End Get
			Set(value As Integer)
				If value >= 1 And value <= Me.m_p_s.mot_pts_max Then
					Me.m_p_s.mot_pts = value
				Else
					Me.m_p_s.mot_pts = 0
				End If
			End Set
		End Property

		Public Property mot_pts_flag As Integer
			Get
				Return Me.m_p_s.mot_pts_flag
			End Get
			Set(value As Integer)
				Select Case value
					Case 1
						Me.m_p_s.mot_pts_flag = value
					Case 2
						Me.m_p_s.mot_pts_flag = value
					Case 3
						Me.m_p_s.mot_pts_flag = value
					Case 20
						Me.m_p_s.mot_pts_flag = value
				End Select
			End Set
		End Property

		Public ReadOnly Property mot_pts_max As Integer
			Get
				Return Me.m_p_s.mot_pts
			End Get
		End Property

		Public Property num_cycles As Integer
			Get
				Return Me.m_p_s.num_cycles
			End Get
			Set(value As Integer)
				Me.m_p_s.num_cycles = value
			End Set
		End Property

		Public Property num_pump_unit_data_points As Integer
			Get
				Return Me.m_p_s.num_pump_unit_data_points
			End Get
			Set(value As Integer)
				If Not(value < 3 Or value > Me.m_p_s.max_pump_unit_data_points) Then
					Me.m_p_s.num_pump_unit_data_points = value
				End If
			End Set
		End Property

		Public Property num_rod_elements As Integer
			Get
				Return Me.m_p_s.num_rod_elements
			End Get
			Set(value As Integer)
				If Not(value < 1 Or value > Me.m_p_s.Max_Rod_Elements) Then
					Me.m_p_s.num_rod_elements = value
				End If
			End Set
		End Property

		Public Property num_rod_tapers As Integer
			Get
				Return Me.m_p_s.num_rod_tapers
			End Get
			Set(value As Integer)
				If Not(value < 1 Or value > Me.m_p_s.max_rod_tapers) Then
					Me.m_p_s.num_rod_tapers = value
				End If
			End Set
		End Property

		Public Property num_survey_points As Integer
			Get
				Return Me.m_p_s.num_survey_points
			End Get
			Set(value As Integer)
				If Not(value < 2 Or value > Me.m_p_s.max_survey_points) Then
					Me.m_p_s.num_survey_points = value
				End If
			End Set
		End Property

		Public Property num_tbg_tapers As Integer
			Get
				Return Me.m_p_s.num_tbg_tapers
			End Get
			Set(value As Integer)
				If Not(value < 1 Or value > Me.m_p_s.max_tbg_tapers) Then
					Me.m_p_s.num_tbg_tapers = value
				End If
			End Set
		End Property

		Public Property num_timesteps As Integer
			Get
				Return Me.m_p_s.num_timesteps
			End Get
			Set(value As Integer)
				Me.m_p_s.num_timesteps = value
			End Set
		End Property

		Public Property omega_fill As Double
			Get
				Return Me.m_p_s.omega_fill
			End Get
			Set(value As Double)
				Me.m_p_s.omega_fill = value
			End Set
		End Property

		Public Property p_drag_dn_0 As Integer
			Get
				Return Me.m_p_s.p_drag_dn_0
			End Get
			Set(value As Integer)
				Me.m_p_s.p_drag_dn_0 = value
			End Set
		End Property

		Public Property p_drag_dn_1 As Integer
			Get
				Return Me.m_p_s.p_drag_dn_1
			End Get
			Set(value As Integer)
				Me.m_p_s.p_drag_dn_1 = value
			End Set
		End Property

		Public Property p_drag_dn_2 As Integer
			Get
				Return Me.m_p_s.p_drag_dn_2
			End Get
			Set(value As Integer)
				Me.m_p_s.p_drag_dn_2 = value
			End Set
		End Property

		Public Property p_drag_f_max_dn As Double
			Get
				Return Me.m_p_drag_f_max_dn
			End Get
			Set(value As Double)
				Me.m_p_s.p_drag_f_max_dn = value
				Me.m_p_drag_f_max_dn = value
			End Set
		End Property

		Public Property p_drag_f_max_up As Double
			Get
				Return Me.m_p_drag_f_max_up
			End Get
			Set(value As Double)
				Me.m_p_s.p_drag_f_max_up = value
				Me.m_p_drag_f_max_up = value
			End Set
		End Property

		Public Property p_drag_up_0 As Integer
			Get
				Return Me.m_p_s.p_drag_up_0
			End Get
			Set(value As Integer)
				Me.m_p_s.p_drag_up_0 = value
			End Set
		End Property

		Public Property p_drag_up_1 As Integer
			Get
				Return Me.m_p_s.p_drag_up_1
			End Get
			Set(value As Integer)
				Me.m_p_s.p_drag_up_1 = value
			End Set
		End Property

		Public Property p_drag_up_2 As Integer
			Get
				Return Me.m_p_s.p_drag_up_2
			End Get
			Set(value As Integer)
				Me.m_p_s.p_drag_up_2 = value
			End Set
		End Property

		Public Property poisson As Double
			Get
				Return Me.m_p_s.poisson
			End Get
			Set(value As Double)
				If Not(value < 0.0 Or value > 1.0) Then
					Me.m_p_s.poisson = value
				End If
			End Set
		End Property

		Public Property pr_drag_0 As Integer
			Get
				Return Me.m_p_s.pr_drag_0
			End Get
			Set(value As Integer)
				Me.m_p_s.pr_drag_0 = value
			End Set
		End Property

		Public Property pr_drag_1 As Integer
			Get
				Return Me.m_p_s.pr_drag_1
			End Get
			Set(value As Integer)
				Me.m_p_s.pr_drag_1 = value
			End Set
		End Property

		Public Property pr_drag_2 As Integer
			Get
				Return Me.m_p_s.pr_drag_2
			End Get
			Set(value As Integer)
				Me.m_p_s.pr_drag_2 = value
			End Set
		End Property

		Public Property pr_drag_f_max As Double
			Get
				Return Me.m_p_s.pr_drag_f_max
			End Get
			Set(value As Double)
				Me.m_p_s.pr_drag_f_max = value
			End Set
		End Property

		Public Property pump_diam As Double
			Get
				Return Me.m_p_s.pump_diam
			End Get
			Set(value As Double)
				Me.m_p_s.pump_diam = value
				Me.m_p_s.pump_area = value * value * Math.Atan(1.0)
			End Set
		End Property

		Public Property pump_effic As Double
			Get
				Return Me.m_p_s.pump_effic
			End Get
			Set(value As Double)
				If Not(0.0 > value Or value > 1.0) Then
					Me.m_p_s.pump_effic = value
				End If
			End Set
		End Property

		Public Property pump_fillup As Double
			Get
				Return Me.m_p_s.pump_fillup
			End Get
			Set(value As Double)
				Me.m_p_s.pump_fillup = value
			End Set
		End Property

		Public Property pump_load_adj As Double
			Get
				Return Me.m_p_s.pump_load_adj
			End Get
			Set(value As Double)
				Me.m_p_s.pump_load_adj = value
			End Set
		End Property

		Public Property ratio_gb As Double
			Get
				Return Me.m_p_s.ratio_gb
			End Get
			Set(value As Double)
				Me.m_p_s.ratio_gb = value
			End Set
		End Property

		Public Property new_ratio_vb As Double
			Get
				Return Me.m_new_ratio_vb
			End Get
			Set(value As Double)
				Me.m_new_ratio_vb = value
			End Set
		End Property

		Public Property ratio_vb As Double
			Get
				Return Me.m_p_s.ratio_vb
			End Get
			Set(value As Double)
				Me.m_p_s.ratio_vb = value
			End Set
		End Property

		Public Property ref_psia As Double
			Get
				Return Me.m_p_s.ref_psia
			End Get
			Set(value As Double)
				Me.m_p_s.ref_psia = value
			End Set
		End Property

		Public Property rpm_breakdown As Double
			Get
				Return Me.m_p_s.ref_psia
			End Get
			Set(value As Double)
				Me.m_p_s.ref_psia = value
			End Set
		End Property

		Public Property slippedRPM As Double
			Get
				Return Me.m_slippedRPM
			End Get
			Set(value As Double)
				Me.m_slippedRPM = value
			End Set
		End Property

		Public Property rpm_full_load As Double
			Get
				Return Me.m_p_s.rpm_full_load
			End Get
			Set(value As Double)
				Me.m_p_s.rpm_full_load = value
			End Set
		End Property

		Public Property rpm_no_load As Double
			Get
				Return Me.m_p_s.rpm_no_load
			End Get
			Set(value As Double)
				Me.m_p_s.rpm_no_load = value
			End Set
		End Property

		Public Property slip_op_pt As Double
			Get
				Return Me.m_p_s.slip_op_pt
			End Get
			Set(value As Double)
				Me.m_p_s.slip_op_pt = value
			End Set
		End Property

		Public Property spm_variation As Double
			Get
				Return Me.m_p_s.spm_variation
			End Get
			Set(value As Double)
				Me.m_p_s.spm_variation = value
			End Set
		End Property

		Public Property sp_grav_oil As Double
			Get
				Return Me.m_p_s.sp_grav_oil
			End Get
			Set(value As Double)
				Me.m_p_s.sp_grav_oil = value
			End Set
		End Property

		Public Property sp_grav_water As Double
			Get
				Return Me.m_p_s.sp_grav_water
			End Get
			Set(value As Double)
				Me.m_p_s.sp_grav_water = value
			End Set
		End Property

		Public Property liquid_gravity As Double
			Get
				Return Me.m_p_s.liquid_gravity
			End Get
			Set(value As Double)
				Me.m_p_s.liquid_gravity = value
			End Set
		End Property

		Public Property strokes_per_min As Double
			Get
				Return Me.m_p_s.strokes_per_min
			End Get
			Set(value As Double)
				Me.m_p_s.strokes_per_min = value
			End Set
		End Property

		Public Property SV_clear_vol As Double
			Get
				Return Me.m_p_s.SV_clear_vol
			End Get
			Set(value As Double)
				If value > 0.1 Then
					Me.m_p_s.SV_clear_vol = value
				End If
			End Set
		End Property

		Public Property timestep_multiplier As Double
			Get
				Return Me.m_p_s.timestep_multiplier
			End Get
			Set(value As Double)
				If value > 0.0 Then
					Me.m_p_s.timestep_multiplier = value
				End If
			End Set
		End Property

		Public Property torq_breakdown As Double
			Get
				Return Me.m_p_s.torq_breakdown
			End Get
			Set(value As Double)
				Me.m_p_s.torq_breakdown = value
			End Set
		End Property

		Public Property torq_cr As Double
			Get
				Return Me.m_p_s.torq_cr
			End Get
			Set(value As Double)
				Me.m_p_s.torq_cr = value
			End Set
		End Property

		Public Property torq_cw As Double
			Get
				Return Me.m_p_s.torq_cw
			End Get
			Set(value As Double)
				Me.m_p_s.torq_cw = value
			End Set
		End Property

		Public Property torq_full_load As Double
			Get
				Return Me.m_p_s.torq_full_load
			End Get
			Set(value As Double)
				Me.m_p_s.torq_full_load = value
			End Set
		End Property

		Public Property torq_no_load As Double
			Get
				Return Me.m_p_s.torq_no_load
			End Get
			Set(value As Double)
				If Math.Abs(value) <= 0.1 Then
					Me.m_p_s.torq_no_load = value
				End If
			End Set
		End Property

		Public Property tubing_pressure As Double
			Get
				Return Me.m_p_s.tubing_pressure
			End Get
			Set(value As Double)
				Me.m_p_s.tubing_pressure = value
			End Set
		End Property

		Public Property TV_clear_vol As Double
			Get
				Return Me.m_p_s.TV_clear_vol
			End Get
			Set(value As Double)
				If value > 0.1 Then
					Me.m_p_s.TV_clear_vol = value
				End If
			End Set
		End Property

		Public Property TV_pos_init As Double
			Get
				Return Me.m_p_s.TV_pos_init
			End Get
			Set(value As Double)
				Me.m_p_s.TV_pos_init = value
			End Set
		End Property

		Public Property watercut As Double
			Get
				Return Me.m_p_s.watercut
			End Get
			Set(value As Double)
				Me.m_p_s.watercut = value
			End Set
		End Property

		Public Property wk_sq_beam As Double
			Get
				Return Me.m_p_s.wk_sq_beam
			End Get
			Set(value As Double)
				Me.m_p_s.wk_sq_beam = value
			End Set
		End Property

		Public Property wk_sq_cr As Double
			Get
				Return Me.m_p_s.wk_sq_cr
			End Get
			Set(value As Double)
				Me.m_p_s.wk_sq_cr = value
			End Set
		End Property

		Public Property wk_sq_cw As Double
			Get
				Return Me.m_p_s.wk_sq_cw
			End Get
			Set(value As Double)
				Me.m_p_s.wk_sq_cw = value
			End Set
		End Property

		Public Property wk_sq_gb As Double
			Get
				Return Me.m_p_s.wk_sq_gb
			End Get
			Set(value As Double)
				Me.m_p_s.wk_sq_gb = value
			End Set
		End Property

		Public Property wk_sq_hss As Double
			Get
				Return Me.m_p_s.wk_sq_hss
			End Get
			Set(value As Double)
				Me.m_p_s.wk_sq_hss = value
			End Set
		End Property

		Public Property wk_sq_lss As Double
			Get
				Return Me.m_p_s.wk_sq_lss
			End Get
			Set(value As Double)
				Me.m_p_s.wk_sq_lss = value
			End Set
		End Property

		Public Property wk_sq_mot As Double
			Get
				Return Me.m_p_s.wk_sq_mot
			End Get
			Set(value As Double)
				Me.m_p_s.wk_sq_mot = value
			End Set
		End Property

		Public Property wk_sq_vb As Double
			Get
				Return Me.m_p_s.wk_sq_vb
			End Get
			Set(value As Double)
				Me.m_p_s.wk_sq_vb = value
			End Set
		End Property

		Public Property RunStatus As Integer
			Get
				Return Me.m_RunStatus
			End Get
			Set(value As Integer)
				Me.m_RunStatus = value
			End Set
		End Property

		Public Property Iart As Single
			Get
				Return Me.m_Iart
			End Get
			Set(value As Single)
				Me.m_Iart = value
			End Set
		End Property

		Public Property Irot As Single
			Get
				Return Me.m_Irot
			End Get
			Set(value As Single)
				Me.m_Irot = value
			End Set
		End Property

		Public Sub calc_sur(ByRef p_s As TEImpred.parameter_structure_type, ByRef r_t As TEImpred.rod_taper_data_type(), ByRef s_p As TEImpred.survey_point_type(), ByRef r_e As TEImpred.rod_element_data_type(), bReRun As Boolean, Optional bStopForError As Boolean = True)
			Dim num As Integer = 0
			Dim num2 As Integer = 0
			Dim num3 As Double = CDbl(RSWIN_DESC.rst.PumpDepth)
			RSWIN_DESC.rst.PumpDepth = CSng(r_t(p_s.num_rod_tapers).taper_depth)
			Try
				p_s.iostat = 0
				Dim num7 As Double
				Dim num17 As Single
				If Not bReRun Then
					Dim num4 As Integer = 1
					Dim num_survey_points As Integer = p_s.num_survey_points
					Dim i As Integer
					i = num4
					While i <= num_survey_points

							s_p(i).tan.x = Math.Sin(s_p(i).inc) * Math.Sin(s_p(i).azi)
							s_p(i).tan.y = Math.Sin(s_p(i).inc) * Math.Cos(s_p(i).azi)
							s_p(i).tan.z = Math.Cos(s_p(i).inc)

						i += 1
					End While
					Dim num5 As Integer = 1
					Dim num6 As Integer = p_s.num_survey_points - 1
					i = num5
					While i <= num6
						num7 = Me.dot_prod(s_p(i).tan, s_p(i + 1).tan)
						If num7 > 1.0 Then
							' The following expression was wrapped in a unchecked-expression
							If num7 > 1.0 + p_s.epsilon Then
								p_s.iostat = -9941
								RSWIN_DESC.rst.PumpDepth = CSng(num3)
								Return
							End If
							num7 = 1.0
							num2 += 1
						End If
						If num7 < 0.0 Then
							' The following expression was wrapped in a unchecked-expression
							If num7 < -p_s.epsilon Then
								p_s.iostat = -9942
								RSWIN_DESC.rst.PumpDepth = CSng(num3)
								Return
							End If
							num7 = 0.0
							num += 1
						End If
						s_p(i).dog = Me.ArcCosine(num7)
						If s_p(i).dog > p_s.epsilon Then
							' The following expression was wrapped in a unchecked-expression
							' The following expression was wrapped in a checked-expression
							s_p(i).rad = s_p(i + 1).m_d - s_p(i).m_d / s_p(i).dog
						Else
							s_p(i).rad = -9999.0
						End If
						i += 1
					End While
					i = p_s.num_survey_points
					s_p(i).dog = -9999.0
					s_p(i).rad = -9999.0
					Dim num8 As Integer = 0
					Dim num9 As Integer = 1
					Dim num10 As Integer = p_s.num_survey_points - 1
					Dim num11 As Integer
					i = num9
					While i <= num10
						s_p(i).nor.x = -9999.0
						s_p(i).nor.y = -9999.0
						s_p(i).nor.z = -9999.0
						If s_p(i).dog > p_s.epsilon Then
							Me.calc_nor(s_p(i).nor, s_p(i).tan, s_p(i + 1).tan)
							num8 = 1
						ElseIf s_p(i - 1).dog > p_s.epsilon And num8 = 1 Then
							Me.calc_nor(s_p(i).nor, s_p(i).tan, s_p(i - 1).tan)
						ElseIf num8 = 1 Then
							s_p(i).nor.x = s_p(i - 1).nor.x
							s_p(i).nor.y = s_p(i - 1).nor.y
							s_p(i).nor.z = s_p(i - 1).nor.z
						End If
						If s_p(i).m_d <= CDbl(RSWIN_DESC.rst.PumpDepth) Then
							num11 = i
						End If
						i += 1
					End While
					If s_p(num11).m_d < CDbl(RSWIN_DESC.rst.PumpDepth) And s_p(num11 + 1).m_d <> 0.0 Then
						num11 += 1
					End If
					i = p_s.num_survey_points
					s_p(i).nor.x = -9999.0
					s_p(i).nor.y = -9999.0
					s_p(i).nor.z = -9999.0
					i = 1
					s_p(i).pos.x = 0.0
					s_p(i).pos.y = 0.0
					s_p(i).pos.z = 0.0
					Dim num12 As Integer = 2
					Dim num_survey_points2 As Integer = p_s.num_survey_points
					i = num12
					While i <= num_survey_points2
						If s_p(i - 1).dog > p_s.epsilon Then
							Me.calc_pos(s_p(i).pos, s_p(i - 1).pos, s_p(i - 1).tan, s_p(i - 1).nor, s_p(i - 1).dog, s_p(i - 1).rad)
						Else
							Me.calc_str(s_p(i).pos, s_p(i - 1).pos, s_p(i - 1).tan, s_p(i).m_d, s_p(i - 1).m_d)
						End If
						i += 1
					End While
					If s_p(num11 - 1).m_d = CDbl(RSWIN_DESC.rst.PumpDepth) Then
						p_s.pump_pos = s_p(num11 - 1).pos
					ElseIf s_p(num11 - 1).m_d < CDbl(RSWIN_DESC.rst.PumpDepth) And s_p(num11).m_d > CDbl(RSWIN_DESC.rst.PumpDepth) Then
						If s_p(num11 - 1).dog > p_s.epsilon Then
							' The following expression was wrapped in a unchecked-expression
							' The following expression was wrapped in a checked-expression
							Dim num13 As Double = CDbl(RSWIN_DESC.rst.PumpDepth) - s_p(num11 - 1).m_d / s_p(num11 - 1).rad
							Me.calc_pos(p_s.pump_pos, s_p(num11 - 1).pos, s_p(num11 - 1).tan, s_p(num11 - 1).nor, num13, s_p(num11 - 1).rad)
						Else
							Dim array As TEImpred.survey_point_type() = s_p
							Dim num14 As Integer = num11 - 1
							Dim array2 As TEImpred.survey_point_type() = s_p
							Dim num15 As Integer = num11 - 1
							Dim rst As cRODSTAR = RSWIN_DESC.rst
							Dim num16 As Double = CDbl(rst.PumpDepth)
							Me.calc_str(p_s.pump_pos, array(num14).pos, array2(num15).tan, num16, s_p(num11 - 1).m_d)
							rst.PumpDepth = CSng(num16)
						End If
					Else
						If s_p(num11).m_d <> CDbl(RSWIN_DESC.rst.PumpDepth) Then
							Debug.WriteLine(" ")
							Debug.WriteLine("stopped in calc_sur at p_s.pump_pos.  How did I get here?")
							p_s.iostat = -8525
							RSWIN_DESC.rst.PumpDepth = CSng(num3)
							Return
						End If
						p_s.pump_pos = s_p(num11).pos
					End If
					If r_t(p_s.num_rod_tapers).taper_depth > s_p(p_s.num_survey_points).m_d And Math.Abs(r_t(p_s.num_rod_tapers).taper_depth - s_p(p_s.num_survey_points).m_d) > 50.0 Then
						p_s.iostat = -9943
					End If
				End If
				num17 = 100000F
				If p_s.num_survey_points > 2 Then
					Dim num18 As Integer = 3
					Dim num_survey_points3 As Integer = p_s.num_survey_points
					For i As Integer = num18 To num_survey_points3
						' The following expression was wrapped in a unchecked-expression
						' The following expression was wrapped in a checked-expression
						Dim num19 As Single = CSng((s_p(i).m_d - s_p(i - 2).m_d))
						If num19 < num17 Then
							num17 = num19
						End If
					Next
				End If
				Dim num20 As Integer = 1
				Dim num_rod_tapers As Integer = p_s.num_rod_tapers
				For i As Integer = num20 To num_rod_tapers
					If i = 1 Then
						r_t(1).taper_len = r_t(1).taper_depth
					Else
						' The following expression was wrapped in a unchecked-expression
						' The following expression was wrapped in a checked-expression
						r_t(i).taper_len = r_t(i).taper_depth - r_t(i - 1).taper_depth
					End If
				Next
				Dim num21 As Integer = 1
				Dim num_rod_tapers2 As Integer = p_s.num_rod_tapers
				For i As Integer = num21 To num_rod_tapers2
					If r_t(i).taper_len < CDbl(num17) Then
						num17 = CSng(r_t(i).taper_len)
						Dim num22 As Integer = CInt(Math.Round(r_t(p_s.num_rod_tapers).taper_depth / CDbl(num17)))
						If num22 > p_s.num_rod_elements Then
							p_s.num_rod_elements = num22
						End If
					End If
				Next
				If p_s.num_rod_elements > p_s.Max_Rod_Elements Then
					p_s.num_rod_elements = p_s.Max_Rod_Elements
				End If
				p_s.rod_element_length = r_t(p_s.num_rod_tapers).taper_depth / Convert.ToDouble(p_s.num_rod_elements)
				Dim num23 As Integer = 1
				Dim num24 As Integer = 0
				p_s.sum_len_div_vel = 0.0
				p_s.max_char_vel = -1.0
				Dim num25 As Integer = 1
				Dim num_rod_tapers3 As Integer = p_s.num_rod_tapers
				For i As Integer = num25 To num_rod_tapers3
					Me.temp = r_t(i).rod_modulus / r_t(i).rod_density

						r_t(i).char_vel = Math.Sqrt(Me.temp * 144.0 * 32.17405)
						p_s.sum_len_div_vel += r_t(i).taper_len / r_t(i).char_vel
						If True And r_t(i).rod_density > 150.0 And r_t(i).rod_density < 160.0 Then
							r_t(i).rod_density = r_t(i).rod_density
							r_t(i).char_vel = r_t(i).char_vel
						End If
						If Me.temp > p_s.max_char_vel Then
							p_s.max_char_vel = Me.temp
						End If

				Next
				p_s.max_char_vel = Math.Sqrt(p_s.max_char_vel * 144.0 * 32.17405)
				Dim num26 As Double = 0.1
				Dim num27 As Integer = 0
				Dim flag As Boolean = True
				Dim flag2 As Boolean = False
				Dim flag3 As Boolean = False
				Dim num28 As Double = 0.0
				p_s.iostat = 0
				p_s.timestep_length = p_s.sum_len_div_vel / CDbl(p_s.num_rod_elements)
				While flag
					Dim num29 As Double = 0.0
					Dim num30 As Integer = 1
					Dim num_rod_tapers4 As Integer = p_s.num_rod_tapers
					For i As Integer = num30 To num_rod_tapers4

							r_t(i).rod_elem_len = r_t(i).char_vel * p_s.timestep_length
							r_t(i).num_rod_elem = r_t(i).taper_len / r_t(i).rod_elem_len
							r_t(i).num_rod_elem = CDbl(Convert.ToInt32(r_t(i).num_rod_elem + num28))
							If i = p_s.num_rod_tapers And r_t(i).num_rod_elem = 0.0 Then
								r_t(i).num_rod_elem = CDbl(Convert.ToInt32(r_t(i).taper_len / r_t(i).rod_elem_len))
							End If

						If r_t(i).num_rod_elem < 1.0 Then
							p_s.iostat = -9972
							Dim num31 As Integer = 1
							Dim numRods As Integer = CInt(RSWIN_DESC.rst.NumRods)
							For j As Integer = num31 To numRods
								Debug.WriteLine(String.Concat(New String() { Conversions.ToString(j), " ", Conversions.ToString(CInt(RSWIN_DESC.rst.Sections(j).Grade)), " ", Conversions.ToString(RSWIN_DESC.rst.Sections(j).length) }))
							Next
							If bStopForError Or p_s.iostat <> 0 Then
								RSWIN_DESC.rst.PumpDepth = CSng(num3)
								Return
							End If
						End If
						r_t(i).rod_elem_len = r_t(i).taper_len / r_t(i).num_rod_elem

							num29 += r_t(i).num_rod_elem

					Next
					num29 = num29
					p_s.num_rod_elements = p_s.num_rod_elements
					If num29 < CDbl((p_s.num_rod_elements - p_s.num_rod_tapers)) Then
						p_s.iostat = -9948
						If bStopForError Or p_s.iostat <> 0 Then
							RSWIN_DESC.rst.PumpDepth = CSng(num3)
							Return
						End If
					ElseIf num29 < CDbl(p_s.num_rod_elements) And num29 >= CDbl((p_s.num_rod_elements - p_s.num_rod_tapers)) Then

							If num28 < -1.0 Then
								p_s.iostat = -8894
							ElseIf Not flag3 And Not flag2 Then
								flag3 = True
								flag2 = False
								num26 = num26
								num28 += num26
							ElseIf Not flag3 AndAlso flag2 Then
								flag3 = True
								flag2 = False
								num26 *= 0.1
								num28 += num26
							ElseIf flag3 And Not flag2 Then
								num28 += num26
							ElseIf flag3 AndAlso flag2 Then
								p_s.iostat = -8887
							End If

					ElseIf num29 = CDbl(p_s.num_rod_elements) Then
						flag = False
						p_s.iostat = 0
					ElseIf num29 > CDbl(p_s.num_rod_elements) And num29 <= CDbl((p_s.num_rod_elements + p_s.num_rod_tapers)) Then

							If num28 < -1.0 Then
								p_s.iostat = -8888
							ElseIf Not flag3 And Not flag2 Then
								flag3 = False
								flag2 = True
								num26 = num26
								num28 -= num26
								If num28 < -1.0 Then
									p_s.iostat = -8890
								End If
							ElseIf Not flag3 AndAlso flag2 Then
								num28 -= num26
								If num28 < -1.0 Then
									p_s.iostat = -8891
								End If
							ElseIf flag3 And Not flag2 Then
								flag3 = False
								flag2 = True
								num26 *= 0.1
								num28 -= num26
								If num28 < -1.0 Then
									p_s.iostat = -8892
								End If
							ElseIf flag3 AndAlso flag2 Then
								p_s.iostat = -8893
							End If

					ElseIf num29 > CDbl((p_s.num_rod_elements + p_s.num_rod_tapers * 2)) Then
						p_s.iostat = -9949
						If bStopForError Or p_s.iostat <> 0 Then
							RSWIN_DESC.rst.PumpDepth = CSng(num3)
							Return
						End If
					End If
					num27 += 1
					If num27 > 1500 Then
						p_s.iostat = -9950
						If bStopForError Or p_s.iostat <> 0 Then
							RSWIN_DESC.rst.PumpDepth = CSng(num3)
							Return
						End If
					End If
					If num28 = num28 - num26 And num28 = num28 + num26 Then
						If CDbl(p_s.num_rod_elements) < num29 Then
							flag = False
							p_s.iostat = 0
							p_s.num_rod_elements = CInt(Math.Round(num29))
						Else
							Dim num32 As Integer = 1
							Dim num33 As Integer = 2
							Dim num_rod_tapers5 As Integer = p_s.num_rod_tapers
							For k As Integer = num33 To num_rod_tapers5
								If r_t(k).taper_len > r_t(k - 1).taper_len Then
									num32 = k
								End If
							Next

								r_t(num32).num_rod_elem = r_t(num32).num_rod_elem + 1.0
								r_t(num32).rod_elem_len = r_t(num32).taper_len / r_t(num32).num_rod_elem
								r_t(num32).char_vel = r_t(num32).rod_elem_len / p_s.timestep_length - 1.0

						End If
					End If
				End While
				p_s.period = 60.0 / p_s.strokes_per_min
				Dim num34 As Integer = 1
				Dim num_rod_elements As Integer = p_s.num_rod_elements
				For i As Integer = num34 To num_rod_elements

						If i = 1 Then
							r_e(i).length = r_t(1).rod_elem_len
							r_e(i).m_d = r_t(1).rod_elem_len
							r_e(i).Grade = r_t(1).Grade
						ElseIf CDbl(i) < r_t(1).num_rod_elem And p_s.num_rod_tapers >= 1 Then
							r_e(i).length = r_t(1).rod_elem_len
							r_e(i).m_d = r_e(i - 1).m_d + r_t(1).rod_elem_len
							r_e(i).Grade = r_t(1).Grade
						ElseIf CDbl(i) = r_t(1).num_rod_elem Then
							r_e(i).length = r_t(1).rod_elem_len
							r_e(i).m_d = r_t(1).taper_depth
							r_e(i).Grade = r_t(1).Grade
						ElseIf CDbl(i) < r_t(2).num_rod_elem + r_t(1).num_rod_elem And p_s.num_rod_tapers >= 2 Then
							r_e(i).length = r_t(2).rod_elem_len
							r_e(i).m_d = r_e(i - 1).m_d + r_t(2).rod_elem_len
							r_e(i).Grade = r_t(2).Grade
						ElseIf CDbl(i) = r_t(2).num_rod_elem + r_t(1).num_rod_elem Then
							r_e(i).length = r_t(2).rod_elem_len
							r_e(i).m_d = r_t(2).taper_depth
							r_e(i).Grade = r_t(2).Grade
						ElseIf CDbl(i) < r_t(3).num_rod_elem + r_t(2).num_rod_elem + r_t(1).num_rod_elem And p_s.num_rod_tapers >= 3 Then
							r_e(i).length = r_t(3).rod_elem_len
							r_e(i).m_d = r_e(i - 1).m_d + r_t(3).rod_elem_len
							r_e(i).Grade = r_t(3).Grade
						ElseIf CDbl(i) = r_t(3).num_rod_elem + r_t(2).num_rod_elem + r_t(1).num_rod_elem Then
							r_e(i).length = r_t(3).rod_elem_len
							r_e(i).m_d = r_t(3).taper_depth
							r_e(i).Grade = r_t(3).Grade
						ElseIf CDbl(i) < r_t(4).num_rod_elem + r_t(3).num_rod_elem + r_t(2).num_rod_elem + r_t(1).num_rod_elem And p_s.num_rod_tapers >= 4 Then
							r_e(i).length = r_t(4).rod_elem_len
							r_e(i).m_d = r_e(i - 1).m_d + r_t(4).rod_elem_len
							r_e(i).Grade = r_t(4).Grade
						ElseIf CDbl(i) = r_t(4).num_rod_elem + r_t(3).num_rod_elem + r_t(2).num_rod_elem + r_t(1).num_rod_elem Then
							r_e(i).length = r_t(4).rod_elem_len
							r_e(i).m_d = r_t(4).taper_depth
							r_e(i).Grade = r_t(4).Grade
						ElseIf CDbl(i) < r_t(5).num_rod_elem + r_t(4).num_rod_elem + r_t(3).num_rod_elem + r_t(2).num_rod_elem + r_t(1).num_rod_elem And p_s.num_rod_tapers >= 5 Then
							r_e(i).length = r_t(5).rod_elem_len
							r_e(i).m_d = r_e(i - 1).m_d + r_t(5).rod_elem_len
							r_e(i).Grade = r_t(5).Grade
						ElseIf CDbl(i) = r_t(5).num_rod_elem + r_t(4).num_rod_elem + r_t(3).num_rod_elem + r_t(2).num_rod_elem + r_t(1).num_rod_elem Then
							r_e(i).length = r_t(5).rod_elem_len
							r_e(i).m_d = r_t(5).taper_depth
							r_e(i).Grade = r_t(5).Grade
						ElseIf CDbl(i) < r_t(6).num_rod_elem + r_t(5).num_rod_elem + r_t(4).num_rod_elem + r_t(3).num_rod_elem + r_t(2).num_rod_elem + r_t(1).num_rod_elem And p_s.num_rod_tapers >= 6 Then
							r_e(i).length = r_t(6).rod_elem_len
							r_e(i).m_d = r_e(i - 1).m_d + r_t(6).rod_elem_len
							r_e(i).Grade = r_t(6).Grade
						ElseIf CDbl(i) = r_t(6).num_rod_elem + r_t(5).num_rod_elem + r_t(4).num_rod_elem + r_t(3).num_rod_elem + r_t(2).num_rod_elem + r_t(1).num_rod_elem Then
							r_e(i).length = r_t(6).rod_elem_len
							r_e(i).m_d = r_t(6).taper_depth
							r_e(i).Grade = r_t(6).Grade
						ElseIf CDbl(i) < r_t(7).num_rod_elem + r_t(6).num_rod_elem + r_t(5).num_rod_elem + r_t(4).num_rod_elem + r_t(3).num_rod_elem + r_t(2).num_rod_elem + r_t(1).num_rod_elem And p_s.num_rod_tapers >= 7 Then
							r_e(i).length = r_t(7).rod_elem_len
							r_e(i).m_d = r_e(i - 1).m_d + r_t(7).rod_elem_len
							r_e(i).Grade = r_t(7).Grade
						ElseIf CDbl(i) = r_t(7).num_rod_elem + r_t(6).num_rod_elem + r_t(5).num_rod_elem + r_t(4).num_rod_elem + r_t(3).num_rod_elem + r_t(2).num_rod_elem + r_t(1).num_rod_elem Then
							r_e(i).length = r_t(7).rod_elem_len
							r_e(i).m_d = r_t(7).taper_depth
							r_e(i).Grade = r_t(7).Grade
						ElseIf CDbl(i) < r_t(8).num_rod_elem + r_t(7).num_rod_elem + r_t(6).num_rod_elem + r_t(5).num_rod_elem + r_t(4).num_rod_elem + r_t(3).num_rod_elem + r_t(2).num_rod_elem + r_t(1).num_rod_elem And p_s.num_rod_tapers >= 8 Then
							r_e(i).length = r_t(8).rod_elem_len
							r_e(i).m_d = r_e(i - 1).m_d + r_t(8).rod_elem_len
							r_e(i).Grade = r_t(8).Grade
						ElseIf CDbl(i) = r_t(8).num_rod_elem + r_t(7).num_rod_elem + r_t(6).num_rod_elem + r_t(5).num_rod_elem + r_t(4).num_rod_elem + r_t(3).num_rod_elem + r_t(2).num_rod_elem + r_t(1).num_rod_elem Then
							r_e(i).length = r_t(8).rod_elem_len
							r_e(i).m_d = r_t(8).taper_depth
							r_e(i).Grade = r_t(8).Grade
						ElseIf CDbl(i) < r_t(9).num_rod_elem + r_t(8).num_rod_elem + r_t(7).num_rod_elem + r_t(6).num_rod_elem + r_t(5).num_rod_elem + r_t(4).num_rod_elem + r_t(3).num_rod_elem + r_t(2).num_rod_elem + r_t(1).num_rod_elem And p_s.num_rod_tapers >= 9 Then
							r_e(i).length = r_t(9).rod_elem_len
							r_e(i).m_d = r_e(i - 1).m_d + r_t(9).rod_elem_len
							r_e(i).Grade = r_t(9).Grade
						ElseIf CDbl(i) = r_t(9).num_rod_elem + r_t(8).num_rod_elem + r_t(7).num_rod_elem + r_t(6).num_rod_elem + r_t(5).num_rod_elem + r_t(4).num_rod_elem + r_t(3).num_rod_elem + r_t(2).num_rod_elem + r_t(1).num_rod_elem Then
							r_e(i).length = r_t(9).rod_elem_len
							r_e(i).m_d = r_t(9).taper_depth
							r_e(i).Grade = r_t(9).Grade
						ElseIf CDbl(i) < r_t(10).num_rod_elem + r_t(9).num_rod_elem + r_t(8).num_rod_elem + r_t(7).num_rod_elem + r_t(6).num_rod_elem + r_t(5).num_rod_elem + r_t(4).num_rod_elem + r_t(3).num_rod_elem + r_t(2).num_rod_elem + r_t(1).num_rod_elem And p_s.num_rod_tapers >= 10 Then
							r_e(i).length = r_t(10).rod_elem_len
							r_e(i).m_d = r_e(i - 1).m_d + r_t(10).rod_elem_len
							r_e(i).Grade = r_t(10).Grade
						ElseIf CDbl(i) = r_t(10).num_rod_elem + r_t(9).num_rod_elem + r_t(8).num_rod_elem + r_t(7).num_rod_elem + r_t(6).num_rod_elem + r_t(5).num_rod_elem + r_t(4).num_rod_elem + r_t(3).num_rod_elem + r_t(2).num_rod_elem + r_t(1).num_rod_elem Then
							r_e(i).length = r_t(10).rod_elem_len
							r_e(i).m_d = r_t(10).taper_depth
							r_e(i).Grade = r_t(10).Grade
						ElseIf CDbl(i) < r_t(11).num_rod_elem + r_t(10).num_rod_elem + r_t(9).num_rod_elem + r_t(8).num_rod_elem + r_t(7).num_rod_elem + r_t(6).num_rod_elem + r_t(5).num_rod_elem + r_t(4).num_rod_elem + r_t(3).num_rod_elem + r_t(2).num_rod_elem + r_t(1).num_rod_elem And p_s.num_rod_tapers >= 11 Then
							r_e(i).length = r_t(11).rod_elem_len
							r_e(i).m_d = r_e(i - 1).m_d + r_t(11).rod_elem_len
							r_e(i).Grade = r_t(11).Grade
						ElseIf CDbl(i) = r_t(11).num_rod_elem + r_t(10).num_rod_elem + r_t(9).num_rod_elem + r_t(8).num_rod_elem + r_t(7).num_rod_elem + r_t(6).num_rod_elem + r_t(5).num_rod_elem + r_t(4).num_rod_elem + r_t(3).num_rod_elem + r_t(2).num_rod_elem + r_t(1).num_rod_elem Then
							r_e(i).length = r_t(11).rod_elem_len
							r_e(i).m_d = r_t(11).taper_depth
							r_e(i).Grade = r_t(11).Grade
						ElseIf CDbl(i) < r_t(12).num_rod_elem + r_t(11).num_rod_elem + r_t(10).num_rod_elem + r_t(9).num_rod_elem + r_t(8).num_rod_elem + r_t(7).num_rod_elem + r_t(6).num_rod_elem + r_t(5).num_rod_elem + r_t(4).num_rod_elem + r_t(3).num_rod_elem + r_t(2).num_rod_elem + r_t(1).num_rod_elem And p_s.num_rod_tapers >= 12 Then
							r_e(i).length = r_t(12).rod_elem_len
							r_e(i).m_d = r_e(i - 1).m_d + r_t(12).rod_elem_len
							r_e(i).Grade = r_t(12).Grade
						ElseIf CDbl(i) = r_t(12).num_rod_elem + r_t(11).num_rod_elem + r_t(10).num_rod_elem + r_t(9).num_rod_elem + r_t(8).num_rod_elem + r_t(7).num_rod_elem + r_t(6).num_rod_elem + r_t(5).num_rod_elem + r_t(4).num_rod_elem + r_t(3).num_rod_elem + r_t(2).num_rod_elem + r_t(1).num_rod_elem Then
							r_e(i).length = r_t(12).rod_elem_len
							r_e(i).m_d = r_t(12).taper_depth
							r_e(i).Grade = r_t(12).Grade
						ElseIf CDbl(i) < r_t(13).num_rod_elem + r_t(12).num_rod_elem + r_t(11).num_rod_elem + r_t(10).num_rod_elem + r_t(9).num_rod_elem + r_t(8).num_rod_elem + r_t(7).num_rod_elem + r_t(6).num_rod_elem + r_t(5).num_rod_elem + r_t(4).num_rod_elem + r_t(3).num_rod_elem + r_t(2).num_rod_elem + r_t(1).num_rod_elem And p_s.num_rod_tapers >= 13 Then
							r_e(i).length = r_t(13).rod_elem_len
							r_e(i).m_d = r_e(i - 1).m_d + r_t(13).rod_elem_len
							r_e(i).Grade = r_t(13).Grade
						ElseIf CDbl(i) = r_t(13).num_rod_elem + r_t(12).num_rod_elem + r_t(11).num_rod_elem + r_t(10).num_rod_elem + r_t(9).num_rod_elem + r_t(8).num_rod_elem + r_t(7).num_rod_elem + r_t(6).num_rod_elem + r_t(5).num_rod_elem + r_t(4).num_rod_elem + r_t(3).num_rod_elem + r_t(2).num_rod_elem + r_t(1).num_rod_elem Then
							r_e(i).length = r_t(13).rod_elem_len
							r_e(i).m_d = r_t(13).taper_depth
							r_e(i).Grade = r_t(13).Grade
						ElseIf CDbl(i) < r_t(14).num_rod_elem + r_t(13).num_rod_elem + r_t(12).num_rod_elem + r_t(11).num_rod_elem + r_t(10).num_rod_elem + r_t(9).num_rod_elem + r_t(8).num_rod_elem + r_t(7).num_rod_elem + r_t(6).num_rod_elem + r_t(5).num_rod_elem + r_t(4).num_rod_elem + r_t(3).num_rod_elem + r_t(2).num_rod_elem + r_t(1).num_rod_elem And p_s.num_rod_tapers >= 14 Then
							r_e(i).length = r_t(14).rod_elem_len
							r_e(i).m_d = r_e(i - 1).m_d + r_t(14).rod_elem_len
							r_e(i).Grade = r_t(14).Grade
						ElseIf CDbl(i) = r_t(14).num_rod_elem + r_t(13).num_rod_elem + r_t(12).num_rod_elem + r_t(11).num_rod_elem + r_t(10).num_rod_elem + r_t(9).num_rod_elem + r_t(8).num_rod_elem + r_t(7).num_rod_elem + r_t(6).num_rod_elem + r_t(5).num_rod_elem + r_t(4).num_rod_elem + r_t(3).num_rod_elem + r_t(2).num_rod_elem + r_t(1).num_rod_elem Then
							r_e(i).length = r_t(14).rod_elem_len
							r_e(i).m_d = r_t(14).taper_depth
							r_e(i).Grade = r_t(14).Grade
						ElseIf CDbl(i) < r_t(15).num_rod_elem + r_t(14).num_rod_elem + r_t(13).num_rod_elem + r_t(12).num_rod_elem + r_t(11).num_rod_elem + r_t(10).num_rod_elem + r_t(9).num_rod_elem + r_t(8).num_rod_elem + r_t(7).num_rod_elem + r_t(6).num_rod_elem + r_t(5).num_rod_elem + r_t(4).num_rod_elem + r_t(3).num_rod_elem + r_t(2).num_rod_elem + r_t(1).num_rod_elem And p_s.num_rod_tapers >= 15 Then
							r_e(i).length = r_t(15).rod_elem_len
							r_e(i).m_d = r_e(i - 1).m_d + r_t(15).rod_elem_len
							r_e(i).Grade = r_t(15).Grade
						ElseIf CDbl(i) = r_t(15).num_rod_elem + r_t(14).num_rod_elem + r_t(13).num_rod_elem + r_t(12).num_rod_elem + r_t(11).num_rod_elem + r_t(10).num_rod_elem + r_t(9).num_rod_elem + r_t(8).num_rod_elem + r_t(7).num_rod_elem + r_t(6).num_rod_elem + r_t(5).num_rod_elem + r_t(4).num_rod_elem + r_t(3).num_rod_elem + r_t(2).num_rod_elem + r_t(1).num_rod_elem Then
							r_e(i).length = r_t(15).rod_elem_len
							r_e(i).m_d = r_t(15).taper_depth
							r_e(i).Grade = r_t(15).Grade
						ElseIf CDbl(i) < r_t(16).num_rod_elem + r_t(15).num_rod_elem + r_t(14).num_rod_elem + r_t(13).num_rod_elem + r_t(12).num_rod_elem + r_t(11).num_rod_elem + r_t(10).num_rod_elem + r_t(9).num_rod_elem + r_t(8).num_rod_elem + r_t(7).num_rod_elem + r_t(6).num_rod_elem + r_t(5).num_rod_elem + r_t(4).num_rod_elem + r_t(3).num_rod_elem + r_t(2).num_rod_elem + r_t(1).num_rod_elem And p_s.num_rod_tapers >= 16 Then
							r_e(i).length = r_t(16).rod_elem_len
							r_e(i).m_d = r_e(i - 1).m_d + r_t(16).rod_elem_len
							r_e(i).Grade = r_t(16).Grade
						ElseIf CDbl(i) = r_t(16).num_rod_elem + r_t(15).num_rod_elem + r_t(14).num_rod_elem + r_t(13).num_rod_elem + r_t(12).num_rod_elem + r_t(11).num_rod_elem + r_t(10).num_rod_elem + r_t(9).num_rod_elem + r_t(8).num_rod_elem + r_t(7).num_rod_elem + r_t(6).num_rod_elem + r_t(5).num_rod_elem + r_t(4).num_rod_elem + r_t(3).num_rod_elem + r_t(2).num_rod_elem + r_t(1).num_rod_elem Then
							r_e(i).length = r_t(16).rod_elem_len
							r_e(i).m_d = r_t(16).taper_depth
							r_e(i).Grade = r_t(16).Grade
						ElseIf CDbl(i) < r_t(17).num_rod_elem + r_t(16).num_rod_elem + r_t(15).num_rod_elem + r_t(14).num_rod_elem + r_t(13).num_rod_elem + r_t(12).num_rod_elem + r_t(11).num_rod_elem + r_t(10).num_rod_elem + r_t(9).num_rod_elem + r_t(8).num_rod_elem + r_t(7).num_rod_elem + r_t(6).num_rod_elem + r_t(5).num_rod_elem + r_t(4).num_rod_elem + r_t(3).num_rod_elem + r_t(2).num_rod_elem + r_t(1).num_rod_elem And p_s.num_rod_tapers >= 17 Then
							r_e(i).length = r_t(17).rod_elem_len
							r_e(i).m_d = r_e(i - 1).m_d + r_t(17).rod_elem_len
							r_e(i).Grade = r_t(17).Grade
						ElseIf CDbl(i) = r_t(17).num_rod_elem + r_t(16).num_rod_elem + r_t(15).num_rod_elem + r_t(14).num_rod_elem + r_t(13).num_rod_elem + r_t(12).num_rod_elem + r_t(11).num_rod_elem + r_t(10).num_rod_elem + r_t(9).num_rod_elem + r_t(8).num_rod_elem + r_t(7).num_rod_elem + r_t(6).num_rod_elem + r_t(5).num_rod_elem + r_t(4).num_rod_elem + r_t(3).num_rod_elem + r_t(2).num_rod_elem + r_t(1).num_rod_elem Then
							r_e(i).length = r_t(17).rod_elem_len
							r_e(i).m_d = r_t(17).taper_depth
							r_e(i).Grade = r_t(17).Grade
						ElseIf CDbl(i) < r_t(18).num_rod_elem + r_t(17).num_rod_elem + r_t(16).num_rod_elem + r_t(15).num_rod_elem + r_t(14).num_rod_elem + r_t(13).num_rod_elem + r_t(12).num_rod_elem + r_t(11).num_rod_elem + r_t(10).num_rod_elem + r_t(9).num_rod_elem + r_t(8).num_rod_elem + r_t(7).num_rod_elem + r_t(6).num_rod_elem + r_t(5).num_rod_elem + r_t(4).num_rod_elem + r_t(3).num_rod_elem + r_t(2).num_rod_elem + r_t(1).num_rod_elem And p_s.num_rod_tapers >= 18 Then
							r_e(i).length = r_t(18).rod_elem_len
							r_e(i).m_d = r_e(i - 1).m_d + r_t(18).rod_elem_len
							r_e(i).Grade = r_t(18).Grade
						ElseIf CDbl(i) = r_t(18).num_rod_elem + r_t(17).num_rod_elem + r_t(16).num_rod_elem + r_t(15).num_rod_elem + r_t(14).num_rod_elem + r_t(13).num_rod_elem + r_t(12).num_rod_elem + r_t(11).num_rod_elem + r_t(10).num_rod_elem + r_t(9).num_rod_elem + r_t(8).num_rod_elem + r_t(7).num_rod_elem + r_t(6).num_rod_elem + r_t(5).num_rod_elem + r_t(4).num_rod_elem + r_t(3).num_rod_elem + r_t(2).num_rod_elem + r_t(1).num_rod_elem Then
							r_e(i).length = r_t(18).rod_elem_len
							r_e(i).m_d = r_t(18).taper_depth
							r_e(i).Grade = r_t(18).Grade
						ElseIf CDbl(i) < r_t(19).num_rod_elem + r_t(18).num_rod_elem + r_t(17).num_rod_elem + r_t(16).num_rod_elem + r_t(15).num_rod_elem + r_t(14).num_rod_elem + r_t(13).num_rod_elem + r_t(12).num_rod_elem + r_t(11).num_rod_elem + r_t(10).num_rod_elem + r_t(9).num_rod_elem + r_t(8).num_rod_elem + r_t(7).num_rod_elem + r_t(6).num_rod_elem + r_t(5).num_rod_elem + r_t(4).num_rod_elem + r_t(3).num_rod_elem + r_t(2).num_rod_elem + r_t(1).num_rod_elem And p_s.num_rod_tapers >= 19 Then
							r_e(i).length = r_t(19).rod_elem_len
							r_e(i).m_d = r_e(i - 1).m_d + r_t(19).rod_elem_len
							r_e(i).Grade = r_t(19).Grade
						ElseIf CDbl(i) = r_t(19).num_rod_elem + r_t(18).num_rod_elem + r_t(17).num_rod_elem + r_t(16).num_rod_elem + r_t(15).num_rod_elem + r_t(14).num_rod_elem + r_t(13).num_rod_elem + r_t(12).num_rod_elem + r_t(11).num_rod_elem + r_t(10).num_rod_elem + r_t(9).num_rod_elem + r_t(8).num_rod_elem + r_t(7).num_rod_elem + r_t(6).num_rod_elem + r_t(5).num_rod_elem + r_t(4).num_rod_elem + r_t(3).num_rod_elem + r_t(2).num_rod_elem + r_t(1).num_rod_elem Then
							r_e(i).length = r_t(19).rod_elem_len
							r_e(i).m_d = r_t(19).taper_depth
							r_e(i).Grade = r_t(19).Grade
						ElseIf CDbl(i) < r_t(20).num_rod_elem + r_t(19).num_rod_elem + r_t(18).num_rod_elem + r_t(17).num_rod_elem + r_t(16).num_rod_elem + r_t(15).num_rod_elem + r_t(14).num_rod_elem + r_t(13).num_rod_elem + r_t(12).num_rod_elem + r_t(11).num_rod_elem + r_t(10).num_rod_elem + r_t(9).num_rod_elem + r_t(8).num_rod_elem + r_t(7).num_rod_elem + r_t(6).num_rod_elem + r_t(5).num_rod_elem + r_t(4).num_rod_elem + r_t(3).num_rod_elem + r_t(2).num_rod_elem + r_t(1).num_rod_elem And p_s.num_rod_tapers >= 20 Then
							r_e(i).length = r_t(20).rod_elem_len
							r_e(i).m_d = r_e(i - 1).m_d + r_t(20).rod_elem_len
							r_e(i).Grade = r_t(20).Grade
						ElseIf CDbl(i) = r_t(20).num_rod_elem + r_t(19).num_rod_elem + r_t(18).num_rod_elem + r_t(17).num_rod_elem + r_t(16).num_rod_elem + r_t(15).num_rod_elem + r_t(14).num_rod_elem + r_t(13).num_rod_elem + r_t(12).num_rod_elem + r_t(11).num_rod_elem + r_t(10).num_rod_elem + r_t(9).num_rod_elem + r_t(8).num_rod_elem + r_t(7).num_rod_elem + r_t(6).num_rod_elem + r_t(5).num_rod_elem + r_t(4).num_rod_elem + r_t(3).num_rod_elem + r_t(2).num_rod_elem + r_t(1).num_rod_elem Then
							r_e(i).length = r_t(20).rod_elem_len
							r_e(i).m_d = r_t(20).taper_depth
							r_e(i).Grade = r_t(20).Grade
						Else
							p_s.iostat = -9960
							If bStopForError Or p_s.iostat <> 0 Then
								RSWIN_DESC.rst.PumpDepth = CSng(num3)
								Return
							End If
						End If

				Next
				If RSWIN_DESC.rst.NumRods > 10S AndAlso r_e(p_s.num_rod_elements).m_d < r_t(CInt(RSWIN_DESC.rst.NumRods)).taper_depth Then
					r_e(p_s.num_rod_elements).m_d = r_t(CInt(RSWIN_DESC.rst.NumRods)).taper_depth
				End If
				Dim num35 As Integer = 1
				Dim num_rod_elements2 As Integer = p_s.num_rod_elements
				For i As Integer = num35 To num_rod_elements2
					r_e(i).m_d_multi_matl = r_e(i).m_d
				Next
				Dim num36 As Integer = 1
				Dim num_rod_elements3 As Integer = p_s.num_rod_elements
				For i As Integer = num36 To num_rod_elements3
					Dim d As Double = r_e(i).m_d
					r_e(i).m_d = Convert.ToDouble(i) * p_s.rod_element_length
					r_e(i).m_d = r_e(i).m_d_multi_matl
					Dim num37 As Integer = 1
					While r_e(i).m_d > s_p(num37 + 1).m_d
						num37 += 1
					End While
					While r_e(i).m_d > s_p(num23 + 1).m_d
						If r_e(i).m_d > s_p(num23 + 1).m_d Then
							num23 += 1
							If r_e(i).m_d > s_p(num23 + 1).m_d Then
								num24 += 1
							End If
						End If
					End While

						If s_p(num23).dog > p_s.epsilon Then
							Dim num13 As Double = (r_e(i).m_d - s_p(num23).m_d) / s_p(num23).rad
							r_e(i).tan.x = Math.Cos(num13) * s_p(num23).tan.x + Math.Sin(num13) * s_p(num23).nor.x
							r_e(i).tan.y = Math.Cos(num13) * s_p(num23).tan.y + Math.Sin(num13) * s_p(num23).nor.y
							r_e(i).tan.z = Math.Cos(num13) * s_p(num23).tan.z + Math.Sin(num13) * s_p(num23).nor.z
						Else
							r_e(i).tan.x = s_p(num23).tan.x
							r_e(i).tan.y = s_p(num23).tan.y
							r_e(i).tan.z = s_p(num23).tan.z
						End If

				Next
				If r_e(p_s.num_rod_elements).m_d > r_t(p_s.num_rod_tapers).taper_depth Then
					r_e(p_s.num_rod_elements).m_d = r_t(p_s.num_rod_tapers).taper_depth
				End If
				num7 = Me.dot_prod(s_p(1).tan, r_e(1).tan)
				If num7 > 1.0 Then
					If num7 <= 1.0 + p_s.epsilon Then
						num7 = 1.0
					Else
						num7 = 1.0
						p_s.iostat = -9944
						If bStopForError Then
							RSWIN_DESC.rst.PumpDepth = CSng(num3)
							Return
						End If
					End If
				End If
				If num7 < 0.0 Then
					If num7 >= -p_s.epsilon Then
						num7 = 0.0
					Else
						num7 = 0.0
						If bStopForError Then
							p_s.iostat = -9945
							RSWIN_DESC.rst.PumpDepth = CSng(num3)
							Return
						End If
					End If
				End If
				r_e(1).dog = Me.ArcCosine(num7)
				If r_e(1).dog > p_s.epsilon Then
					r_e(1).rad = (r_e(1).m_d - s_p(1).m_d) / r_e(1).dog
				Else
					r_e(1).rad = -9999.0
				End If
				Dim num38 As Integer = 2
				Dim num_rod_elements4 As Integer = p_s.num_rod_elements
				Dim flag4 As Boolean
				Dim num48 As Double
				Dim i As Integer
				i = num38
				While i <= num_rod_elements4
					num7 = Me.dot_prod(r_e(i - 1).tan, r_e(i).tan)

						If num7 > 1.0 Then
							If num7 <= 1.0 + p_s.epsilon Then
								num7 = 1.0
							Else
								num7 = 1.0
								If bStopForError Then
									p_s.iostat = -9944
									RSWIN_DESC.rst.PumpDepth = CSng(num3)
									Return
								End If
							End If
						End If
						If num7 < 0.0 Then
							If num7 >= -p_s.epsilon Then
								num7 = 0.0
							Else
								num7 = 0.0
								If bStopForError Then
									p_s.iostat = -9945
									RSWIN_DESC.rst.PumpDepth = CSng(num3)
									Return
								End If
							End If
						End If
						r_e(i).dog = Me.ArcCosine(num7)
						If r_e(i).dog > p_s.epsilon Then
							' The following expression was wrapped in a checked-expression
							r_e(i).rad = (r_e(i).m_d - r_e(i - 1).m_d) / r_e(i).dog
						Else
							r_e(i).rad = -9999.0
						End If

					i += 1
				End While
				If r_e(1).dog > p_s.epsilon Then
					Me.calc_nor(r_e(1).nor, r_e(1).tan, s_p(1).tan)
				Else
					r_e(1).nor.x = -9999.0
					r_e(1).nor.y = -9999.0
					r_e(1).nor.z = -9999.0
				End If
				Dim num8 As Integer = 0
				Dim num39 As Integer = 1
				Dim num40 As Integer = p_s.num_rod_elements - 1
				i = num39
				While i <= num40
					r_e(i).nor.x = -9999.0
					r_e(i).nor.y = -9999.0
					r_e(i).nor.z = -9999.0
					If r_e(i).dog > p_s.epsilon / CDbl(num17) * p_s.rod_element_length Then
						Me.calc_nor(r_e(i).nor, r_e(i + 1).tan, r_e(i).tan)
						num8 = 1
					ElseIf r_e(i - 1).dog > p_s.epsilon / CDbl(num17) * p_s.rod_element_length And num8 = 1 Then
						Me.calc_nor(r_e(i).nor, r_e(i - 1).tan, r_e(i).tan)
					ElseIf num8 = 1 Then
						r_e(i).nor.x = r_e(i - 1).nor.x
						r_e(i).nor.y = r_e(i - 1).nor.y
						r_e(i).nor.z = r_e(i - 1).nor.z
					End If
					i += 1
				End While
				Dim num41 As Integer = 1
				Dim num_rod_elements5 As Integer = p_s.num_rod_elements
				i = num41
				While i <= num_rod_elements5

						If r_e(i).nor.x <> -9999.0 Then
							r_e(i).nor.x = -r_e(i).nor.x
							r_e(i).nor.y = -r_e(i).nor.y
							r_e(i).nor.z = -r_e(i).nor.z
						End If

					i += 1
				End While
				If r_e(1).dog > p_s.epsilon Then
					Me.calc_pos_lower(r_e(1).pos, s_p(1).pos, r_e(1).tan, r_e(1).nor, r_e(1).dog, r_e(1).rad)
				Else
					Me.calc_str_lower(r_e(1).pos, s_p(1).pos, r_e(1).tan, r_e(1).m_d, s_p(1).m_d)
				End If
				Dim num42 As Integer = 2
				Dim num_rod_elements6 As Integer = p_s.num_rod_elements
				i = num42
				While i <= num_rod_elements6
					If r_e(i).dog > p_s.epsilon Then
						Me.calc_pos_lower(r_e(i).pos, r_e(i - 1).pos, r_e(i).tan, r_e(i).nor, r_e(i).dog, r_e(i).rad)
					Else
						Me.calc_str_lower(r_e(i).pos, r_e(i - 1).pos, r_e(i).tan, r_e(i).m_d, r_e(i - 1).m_d)
					End If
					i += 1
				End While
				i = 1
				While Conversion.Int(r_e(i).m_d) < Conversion.Int(p_s.liquid_level) And i < p_s.num_rod_elements
					i += 1
				End While
				i -= 1
				p_s.liquid_level_TVD = r_e(i).pos.z + (r_e(i + 1).pos.z - r_e(i).pos.z) * (p_s.liquid_level - r_e(i).m_d) / (r_e(i + 1).m_d - r_e(i).m_d)
				Dim num43 As Integer = 1
				Dim num_rod_elements7 As Integer = p_s.num_rod_elements
				Dim cart_coord_type As TEImpred.cart_coord_type
				i = num43
				While i <= num_rod_elements7

						If r_e(i).dog > p_s.epsilon Then
							Dim num44 As Double = Math.Sin(0.5 * r_e(i).dog)
							Dim num45 As Double = Math.Cos(0.5 * r_e(i).dog)
							cart_coord_type.x = r_e(i).tan.x * num45 - r_e(i).nor.x * num44
							cart_coord_type.y = r_e(i).tan.y * num45 - r_e(i).nor.y * num44
							cart_coord_type.z = r_e(i).tan.z * num45 - r_e(i).nor.z * num44
							r_e(i).nor.x = r_e(i).nor.x * num45 + r_e(i).tan.x * num44
							r_e(i).nor.y = r_e(i).nor.y * num45 + r_e(i).tan.y * num44
							r_e(i).nor.z = r_e(i).nor.z * num45 + r_e(i).tan.z * num44
							r_e(i).tan.x = cart_coord_type.x
							r_e(i).tan.y = cart_coord_type.y
							r_e(i).tan.z = cart_coord_type.z
						End If

					i += 1
				End While
				Dim num46 As Integer = 1
				Dim num_rod_elements8 As Integer = p_s.num_rod_elements
				i = num46
				While i <= num_rod_elements8
					' The following expression was wrapped in a unchecked-expression
					If Math.Abs(r_e(i).tan.x) < p_s.epsilon And Math.Abs(r_e(i).tan.y) < p_s.epsilon And Math.Abs(1.0 - r_e(i).tan.z) < p_s.epsilon Then
						r_e(i).tan.x = 0.0
						r_e(i).tan.y = 0.0
						r_e(i).tan.z = 1.0
					End If
					i += 1
				End While
				cart_coord_type.x = 0.0
				cart_coord_type.y = 0.0
				cart_coord_type.z = 1.0
				Dim num47 As Integer = 1
				Dim num_rod_elements9 As Integer = p_s.num_rod_elements
				i = num47
				While i <= num_rod_elements9
					If r_e(i).tan.z < 1.0 Then
						Me.calc_nor(r_e(i).sfg, r_e(i).tan, cart_coord_type)
					Else
						r_e(i).sfg.x = -99990.0
						r_e(i).sfg.y = -99990.0
						r_e(i).sfg.z = -99990.0
					End If
					i += 1
				End While
				flag4 = False
				num48 = 0.03
				If Math.Abs(1.0 - r_e(p_s.num_rod_elements).pos.x / p_s.pump_pos.x) > num48 Then
					flag4 = True
				End If
				Dim flag5 As Boolean = False
				Dim num49 As Double = 0.01
				If Math.Abs(1.0 - r_e(p_s.num_rod_elements).pos.y / p_s.pump_pos.y) > num49 Then
					flag5 = True
				End If
				Dim flag6 As Boolean = False
				Dim num50 As Double = 0.0005
				Dim num51 As Double = 2.0
				If Math.Abs(1.0 - r_e(p_s.num_rod_elements).pos.z / p_s.pump_pos.z) > num50 Or Math.Abs(r_e(p_s.num_rod_elements).pos.z - p_s.pump_pos.z) > num51 Then
					flag6 = True
				End If
				If flag4 OrElse flag5 OrElse flag6 Then
					If bStopForError Then
						p_s.iostat = -9947
						RSWIN_DESC.rst.PumpDepth = CSng(num3)
						Return
					End If
				End If
				Dim num52 As Double = r_e(p_s.num_rod_elements).pos.x - p_s.pump_pos.x
				num52 = r_e(p_s.num_rod_elements).pos.y - p_s.pump_pos.y
				num52 = r_e(p_s.num_rod_elements).pos.z - p_s.pump_pos.z
				RSWIN_DESC.rst.PumpDepth = CSng(num3)
			Catch ex As Exception
				p_s.iostat = -8523
				RSWIN_DESC.rst.PumpDepth = CSng(num3)
				Interaction.MsgBox("Error: in calc_sur " + ex.Message, MsgBoxStyle.OKOnly, Nothing)
			End Try
		End Sub

		Public Sub calc_sur_Oct2007(ByRef d_l As TEImpred.dog_leg_data_type(), ByRef p_s As TEImpred.parameter_structure_type, ByRef r_t As TEImpred.rod_taper_data_type(), ByRef s_p As TEImpred.survey_point_type(), ByRef r_e As TEImpred.rod_element_data_type(), bReRun As Boolean, Optional bStopForError As Boolean = True)
			Dim num As Double = CDbl(RSWIN_DESC.rst.PumpDepth)
			RSWIN_DESC.rst.PumpDepth = CSng(r_t(p_s.num_rod_tapers).taper_depth)
			Try
				p_s.iostat = 0
				Dim i As Integer
				Dim num5 As Integer
				Dim num10 As Double
				If Not bReRun Then
					Dim num2 As Integer = 1
					Dim num_survey_points As Integer = p_s.num_survey_points
					i = num2
					While i <= num_survey_points

							s_p(i).tan.x = Math.Sin(s_p(i).inc) * Math.Sin(s_p(i).azi)
							s_p(i).tan.y = Math.Sin(s_p(i).inc) * Math.Cos(s_p(i).azi)
							s_p(i).tan.z = Math.Cos(s_p(i).inc)

						i += 1
					End While
					Dim num3 As Integer = 1
					Dim num4 As Integer = p_s.num_survey_points - 1
					i = num3
					While i <= num4
						Me.calc_dog(s_p(i).dog, s_p(i).tan, s_p(i + 1).tan, p_s.epsilon, p_s.iostat, bStopForError)
						If s_p(i).dog > p_s.epsilon Then
							' The following expression was wrapped in a unchecked-expression
							' The following expression was wrapped in a checked-expression
							s_p(i).rad = s_p(i + 1).m_d - s_p(i).m_d / s_p(i).dog
						Else
							s_p(i).rad = -9999.0
						End If
						i += 1
					End While
					i = p_s.num_survey_points
					s_p(i).dog = -9999.0
					s_p(i).rad = -9999.0
					num5 = 0
					Dim num6 As Integer = 1
					Dim num7 As Integer = p_s.num_survey_points - 1
					Dim num8 As Integer
					i = num6
					While i <= num7
						s_p(i).nor.x = -9999.0
						s_p(i).nor.y = -9999.0
						s_p(i).nor.z = -9999.0
						If s_p(i).dog > p_s.epsilon Then
							Me.calc_nor(s_p(i).nor, s_p(i).tan, s_p(i + 1).tan)
							num5 = 1
						ElseIf s_p(i - 1).dog > p_s.epsilon And num5 = 1 Then
							Me.calc_nor(s_p(i).nor, s_p(i).tan, s_p(i - 1).tan)
						ElseIf num5 = 1 Then
							s_p(i).nor.x = s_p(i - 1).nor.x
							s_p(i).nor.y = s_p(i - 1).nor.y
							s_p(i).nor.z = s_p(i - 1).nor.z
						End If
						If s_p(i).m_d <= CDbl(RSWIN_DESC.rst.PumpDepth) Then
							num8 = i
						End If
						i += 1
					End While
					If s_p(num8).m_d < CDbl(RSWIN_DESC.rst.PumpDepth) Then
						num8 += 1
					End If
					i = p_s.num_survey_points
					s_p(i).nor.x = -9999.0
					s_p(i).nor.y = -9999.0
					s_p(i).nor.z = -9999.0
					i = 1
					s_p(i).pos.x = 0.0
					s_p(i).pos.y = 0.0
					s_p(i).pos.z = 0.0
					Dim num9 As Integer = 2
					Dim num_survey_points2 As Integer = p_s.num_survey_points
					i = num9
					While i <= num_survey_points2
						If s_p(i - 1).dog > p_s.epsilon Then
							Me.calc_pos(s_p(i).pos, s_p(i - 1).pos, s_p(i - 1).tan, s_p(i - 1).nor, s_p(i - 1).dog, s_p(i - 1).rad)
						Else
							Me.calc_str(s_p(i).pos, s_p(i - 1).pos, s_p(i - 1).tan, s_p(i).m_d, s_p(i - 1).m_d)
						End If
						i += 1
					End While
					If s_p(num8 - 1).m_d = CDbl(RSWIN_DESC.rst.PumpDepth) Then
						p_s.pump_pos = s_p(num8 - 1).pos
					ElseIf s_p(num8 - 1).m_d < CDbl(RSWIN_DESC.rst.PumpDepth) And s_p(num8).m_d > CDbl(RSWIN_DESC.rst.PumpDepth) Then
						If s_p(num8 - 1).dog > p_s.epsilon Then
							' The following expression was wrapped in a unchecked-expression
							' The following expression was wrapped in a checked-expression
							num10 = CDbl(RSWIN_DESC.rst.PumpDepth) - s_p(num8 - 1).m_d / s_p(num8 - 1).rad
							Me.calc_pos(p_s.pump_pos, s_p(num8 - 1).pos, s_p(num8 - 1).tan, s_p(num8 - 1).nor, num10, s_p(num8 - 1).rad)
						Else
							Dim array As TEImpred.survey_point_type() = s_p
							Dim num11 As Integer = num8 - 1
							Dim array2 As TEImpred.survey_point_type() = s_p
							Dim num12 As Integer = num8 - 1
							Dim rst As cRODSTAR = RSWIN_DESC.rst
							Dim num13 As Double = CDbl(rst.PumpDepth)
							Me.calc_str(p_s.pump_pos, array(num11).pos, array2(num12).tan, num13, s_p(num8 - 1).m_d)
							rst.PumpDepth = CSng(num13)
						End If
					Else
						If s_p(num8).m_d <> CDbl(RSWIN_DESC.rst.PumpDepth) Then
							Debug.WriteLine(" ")
							Debug.WriteLine("stopped in calc_sur_Oct2007 at p_s.pump_pos.  How did I get here?")
							p_s.iostat = -8524
							RSWIN_DESC.rst.PumpDepth = CSng(num)
							Return
						End If
						p_s.pump_pos = s_p(num8).pos
					End If
					If r_t(p_s.num_rod_tapers).taper_depth > s_p(p_s.num_survey_points).m_d And Math.Abs(r_t(p_s.num_rod_tapers).taper_depth - s_p(p_s.num_survey_points).m_d) > 50.0 Then
						p_s.iostat = -9943
						RSWIN_DESC.rst.PumpDepth = CSng(num)
					End If
					p_s.num_dog_leg_pts = CInt(Math.Round(Math.Round(CDbl(RSWIN_DESC.rst.PumpDepth))))
					p_s.iIndexAtPump = num8
				End If
				If Not bReRun Then
					Dim num14 As Single = 100000F
					If p_s.num_survey_points > 2 Then
						Dim num15 As Integer = 5
						Dim num_survey_points3 As Integer = p_s.num_survey_points
						i = num15
						While i <= num_survey_points3
							' The following expression was wrapped in a unchecked-expression
							' The following expression was wrapped in a checked-expression
							Dim num16 As Single = CSng((s_p(i).m_d - s_p(i - 4).m_d))
							If num16 < num14 Then
								num14 = num16
							End If
							i += 1
						End While
					End If
					Dim num17 As Integer = 1
					Dim num_rod_tapers As Integer = p_s.num_rod_tapers
					i = num17
					While i <= num_rod_tapers
						If i = 1 Then
							r_t(1).taper_len = r_t(1).taper_depth
						Else
							' The following expression was wrapped in a unchecked-expression
							' The following expression was wrapped in a checked-expression
							r_t(i).taper_len = r_t(i).taper_depth - r_t(i - 1).taper_depth
						End If
						i += 1
					End While
					If RSWIN_DESC.SETUP_RunForSpeed = -1S Then
						p_s.iostat = p_s.iostat
					End If
					Dim num18 As Integer
					Dim num_rod_tapers2 As Integer

						If Not RSWIN_DESC.SETUP_RunForSpeed <> 0S Then
							If num14 > RSWIN_DESC.SETUP_SteelSuckerRodLength * 2F Then
								num14 = RSWIN_DESC.SETUP_SteelSuckerRodLength * 2F
							ElseIf num14 > RSWIN_DESC.SETUP_SteelSuckerRodLength Then
								num14 = RSWIN_DESC.SETUP_SteelSuckerRodLength
							End If
						End If
						num18 = 1
						num_rod_tapers2 = p_s.num_rod_tapers

					i = num18
					While i <= num_rod_tapers2
						If r_t(i).taper_len < CDbl(num14) Then
							num14 = CSng(r_t(i).taper_len)
						End If
						i += 1
					End While
					If CDbl(p_s.num_rod_elements) < Math.Round(CDbl((RSWIN_DESC.rst.PumpDepth / num14))) Then
						p_s.num_rod_elements = CInt(Math.Round(Math.Round(CDbl((RSWIN_DESC.rst.PumpDepth / num14)))))
					End If
				End If
				If p_s.num_rod_elements > p_s.Max_Rod_Elements Then
					p_s.num_rod_elements = p_s.Max_Rod_Elements
				End If
				p_s.rod_element_length = r_t(p_s.num_rod_tapers).taper_depth / Convert.ToDouble(p_s.num_rod_elements)
				Dim num19 As Integer = 1
				Dim num20 As Integer = 0
				num20 = num20
				p_s.num_rod_elements = p_s.num_rod_elements
				If Not bReRun Then
					p_s.sum_len_div_vel = 0.0
					p_s.max_char_vel = -1.0
					Dim num21 As Integer = 1
					Dim num_rod_tapers3 As Integer = p_s.num_rod_tapers
					i = num21
					While i <= num_rod_tapers3
						Me.temp = r_t(i).rod_modulus / r_t(i).rod_density

							r_t(i).char_vel = Math.Sqrt(Me.temp * 144.0 * 32.17405)
							p_s.sum_len_div_vel += r_t(i).taper_len / r_t(i).char_vel
							If True And r_t(i).rod_density > 150.0 And r_t(i).rod_density < 160.0 Then
								r_t(i).rod_density = r_t(i).rod_density
								r_t(i).char_vel = r_t(i).char_vel
							End If
							If Me.temp > p_s.max_char_vel Then
								p_s.max_char_vel = Me.temp
							End If

						i += 1
					End While
					p_s.max_char_vel = Math.Sqrt(p_s.max_char_vel * 144.0 * 32.17405)
				End If
				Dim num22 As Double = 0.1
				Dim num23 As Integer = 0
				Dim flag As Boolean = True
				Dim flag2 As Boolean = False
				Dim flag3 As Boolean = False
				Dim num24 As Double = 0.0
				p_s.iostat = 0
				p_s.timestep_length = p_s.sum_len_div_vel / CDbl(p_s.num_rod_elements)
				While flag
					Dim num25 As Double
					Dim num26 As Integer
					Dim num_rod_tapers4 As Integer

						If True And num25 = 47.0 Then
							num25 += 0.0
						End If
						num25 = 0.0
						num26 = 1
						num_rod_tapers4 = p_s.num_rod_tapers

					i = num26
					While i <= num_rod_tapers4

							r_t(i).rod_elem_len = r_t(i).char_vel * p_s.timestep_length
							r_t(i).num_rod_elem = CDbl(Convert.ToInt32(r_t(i).taper_len / r_t(i).rod_elem_len + num24))
							If r_t(i).num_rod_elem < 1.0 Then
								p_s.iostat = -9972
								MessageBox.Show("Error in calc_sur_Oct2007. Contact technical support.  p_s.iostat = " + Conversions.ToString(p_s.iostat) + ".")
								If bStopForError Or p_s.iostat <> 0 Then
									RSWIN_DESC.rst.PumpDepth = CSng(num)
									Return
								End If
							End If
							r_t(i).rod_elem_len = r_t(i).taper_len / r_t(i).num_rod_elem
							num25 += r_t(i).num_rod_elem

						i += 1
					End While
					num25 = num25
					p_s.num_rod_elements = p_s.num_rod_elements
					If num25 < CDbl((p_s.num_rod_elements - p_s.num_rod_tapers)) Then
						p_s.iostat = -9948
						If bStopForError Or p_s.iostat <> 0 Then
							RSWIN_DESC.rst.PumpDepth = CSng(num)
							Return
						End If
					ElseIf num25 < CDbl(p_s.num_rod_elements) And num25 >= CDbl((p_s.num_rod_elements - p_s.num_rod_tapers)) Then

							If num24 < -1.0 Then
								p_s.iostat = -8894
							ElseIf Not flag3 And Not flag2 Then
								flag3 = True
								flag2 = False
								num22 = num22
								num24 += num22
							ElseIf Not flag3 AndAlso flag2 Then
								flag3 = True
								flag2 = False
								num22 *= 0.1
								num24 += num22
							ElseIf flag3 And Not flag2 Then
								num24 += num22
							ElseIf flag3 AndAlso flag2 Then
								p_s.iostat = -8887
							End If

					ElseIf num25 = CDbl(p_s.num_rod_elements) Then
						flag = False
						p_s.iostat = 0
					ElseIf num25 > CDbl(p_s.num_rod_elements) And num25 <= CDbl((p_s.num_rod_elements + p_s.num_rod_tapers)) Then

							If num24 < -1.0 Then
								p_s.iostat = -8888
							ElseIf Not flag3 And Not flag2 Then
								flag3 = False
								flag2 = True
								num22 = num22
								num24 -= num22
								If num24 < -1.0 Then
									p_s.iostat = -8890
								End If
							ElseIf Not flag3 AndAlso flag2 Then
								num24 -= num22
								If num24 < -1.0 Then
									p_s.iostat = -8891
								End If
							ElseIf flag3 And Not flag2 Then
								flag3 = False
								flag2 = True
								num22 *= 0.1
								num24 -= num22
								If num24 < -1.0 Then
									p_s.iostat = -8892
								End If
							ElseIf flag3 AndAlso flag2 Then
								p_s.iostat = -8893
							End If

					ElseIf num25 > CDbl((p_s.num_rod_elements + p_s.num_rod_tapers * 2)) Then
						p_s.iostat = -9949
						If bStopForError Or p_s.iostat <> 0 Then
							RSWIN_DESC.rst.PumpDepth = CSng(num)
							Return
						End If
					End If
					num23 += 1
					If num23 > 1500 Then
						p_s.iostat = -9950
						If Not RSWIN_DESC.bImplementingRodGuides Then
							MessageBox.Show("Error occurred. Please contact technical support.  p_s.iostat = " + Conversions.ToString(p_s.iostat) + ".")
						End If
						If bStopForError Or p_s.iostat <> 0 Then
							RSWIN_DESC.rst.PumpDepth = CSng(num)
							Return
						End If
						Debug.WriteLine("")
					End If
					If num24 = num24 - num22 And num24 = num24 + num22 Then
						If CDbl(p_s.num_rod_elements) < num25 Then
							flag = False
							p_s.iostat = 0
							p_s.num_rod_elements = CInt(Math.Round(num25))
						Else
							Dim num27 As Integer = 1
							Dim num28 As Integer = 2
							Dim num_rod_tapers5 As Integer = p_s.num_rod_tapers
							For j As Integer = num28 To num_rod_tapers5
								If r_t(j).taper_len > r_t(j - 1).taper_len Then
									num27 = j
								End If
							Next

								r_t(num27).num_rod_elem = r_t(num27).num_rod_elem + 1.0
								r_t(num27).rod_elem_len = r_t(num27).taper_len / r_t(num27).num_rod_elem
								r_t(num27).char_vel = r_t(num27).rod_elem_len / p_s.timestep_length - 1.0

						End If
					End If
				End While
				p_s.period = 60.0 / p_s.strokes_per_min
				Dim num29 As Integer = 1
				Dim num_rod_elements As Integer = p_s.num_rod_elements
				i = num29
				While i <= num_rod_elements

						If i = 1 Then
							r_e(i).length = r_t(1).rod_elem_len
							r_e(i).m_d = r_t(1).rod_elem_len
						ElseIf CDbl(i) < r_t(1).num_rod_elem And p_s.num_rod_tapers >= 1 Then
							r_e(i).length = r_t(1).rod_elem_len
							r_e(i).m_d = r_e(i - 1).m_d + r_t(1).rod_elem_len
						ElseIf CDbl(i) = r_t(1).num_rod_elem Then
							r_e(i).length = r_t(1).rod_elem_len
							r_e(i).m_d = r_t(1).taper_depth
						ElseIf CDbl(i) < r_t(2).num_rod_elem + r_t(1).num_rod_elem And p_s.num_rod_tapers >= 2 Then
							r_e(i).length = r_t(2).rod_elem_len
							r_e(i).m_d = r_e(i - 1).m_d + r_t(2).rod_elem_len
						ElseIf CDbl(i) = r_t(2).num_rod_elem + r_t(1).num_rod_elem Then
							r_e(i).length = r_t(2).rod_elem_len
							r_e(i).m_d = r_t(2).taper_depth
						ElseIf CDbl(i) < r_t(3).num_rod_elem + r_t(2).num_rod_elem + r_t(1).num_rod_elem And p_s.num_rod_tapers >= 3 Then
							r_e(i).length = r_t(3).rod_elem_len
							r_e(i).m_d = r_e(i - 1).m_d + r_t(3).rod_elem_len
						ElseIf CDbl(i) = r_t(3).num_rod_elem + r_t(2).num_rod_elem + r_t(1).num_rod_elem Then
							r_e(i).length = r_t(3).rod_elem_len
							r_e(i).m_d = r_t(3).taper_depth
						ElseIf CDbl(i) < r_t(4).num_rod_elem + r_t(3).num_rod_elem + r_t(2).num_rod_elem + r_t(1).num_rod_elem And p_s.num_rod_tapers >= 4 Then
							r_e(i).length = r_t(4).rod_elem_len
							r_e(i).m_d = r_e(i - 1).m_d + r_t(4).rod_elem_len
						ElseIf CDbl(i) = r_t(4).num_rod_elem + r_t(3).num_rod_elem + r_t(2).num_rod_elem + r_t(1).num_rod_elem Then
							r_e(i).length = r_t(4).rod_elem_len
							r_e(i).m_d = r_t(4).taper_depth
						ElseIf CDbl(i) < r_t(5).num_rod_elem + r_t(4).num_rod_elem + r_t(3).num_rod_elem + r_t(2).num_rod_elem + r_t(1).num_rod_elem And p_s.num_rod_tapers >= 5 Then
							r_e(i).length = r_t(5).rod_elem_len
							r_e(i).m_d = r_e(i - 1).m_d + r_t(5).rod_elem_len
						ElseIf CDbl(i) = r_t(5).num_rod_elem + r_t(4).num_rod_elem + r_t(3).num_rod_elem + r_t(2).num_rod_elem + r_t(1).num_rod_elem Then
							r_e(i).length = r_t(5).rod_elem_len
							r_e(i).m_d = r_t(5).taper_depth
						ElseIf CDbl(i) < r_t(6).num_rod_elem + r_t(5).num_rod_elem + r_t(4).num_rod_elem + r_t(3).num_rod_elem + r_t(2).num_rod_elem + r_t(1).num_rod_elem And p_s.num_rod_tapers >= 6 Then
							r_e(i).length = r_t(6).rod_elem_len
							r_e(i).m_d = r_e(i - 1).m_d + r_t(6).rod_elem_len
						ElseIf CDbl(i) = r_t(6).num_rod_elem + r_t(5).num_rod_elem + r_t(4).num_rod_elem + r_t(3).num_rod_elem + r_t(2).num_rod_elem + r_t(1).num_rod_elem Then
							r_e(i).length = r_t(6).rod_elem_len
							r_e(i).m_d = r_t(6).taper_depth
						ElseIf CDbl(i) < r_t(7).num_rod_elem + r_t(6).num_rod_elem + r_t(5).num_rod_elem + r_t(4).num_rod_elem + r_t(3).num_rod_elem + r_t(2).num_rod_elem + r_t(1).num_rod_elem And p_s.num_rod_tapers >= 7 Then
							r_e(i).length = r_t(7).rod_elem_len
							r_e(i).m_d = r_e(i - 1).m_d + r_t(7).rod_elem_len
						ElseIf CDbl(i) = r_t(7).num_rod_elem + r_t(6).num_rod_elem + r_t(5).num_rod_elem + r_t(4).num_rod_elem + r_t(3).num_rod_elem + r_t(2).num_rod_elem + r_t(1).num_rod_elem Then
							r_e(i).length = r_t(7).rod_elem_len
							r_e(i).m_d = r_t(7).taper_depth
						ElseIf CDbl(i) < r_t(8).num_rod_elem + r_t(7).num_rod_elem + r_t(6).num_rod_elem + r_t(5).num_rod_elem + r_t(4).num_rod_elem + r_t(3).num_rod_elem + r_t(2).num_rod_elem + r_t(1).num_rod_elem And p_s.num_rod_tapers >= 8 Then
							r_e(i).length = r_t(8).rod_elem_len
							r_e(i).m_d = r_e(i - 1).m_d + r_t(8).rod_elem_len
						ElseIf CDbl(i) = r_t(8).num_rod_elem + r_t(7).num_rod_elem + r_t(6).num_rod_elem + r_t(5).num_rod_elem + r_t(4).num_rod_elem + r_t(3).num_rod_elem + r_t(2).num_rod_elem + r_t(1).num_rod_elem Then
							r_e(i).length = r_t(8).rod_elem_len
							r_e(i).m_d = r_t(8).taper_depth
						ElseIf CDbl(i) < r_t(9).num_rod_elem + r_t(8).num_rod_elem + r_t(7).num_rod_elem + r_t(6).num_rod_elem + r_t(5).num_rod_elem + r_t(4).num_rod_elem + r_t(3).num_rod_elem + r_t(2).num_rod_elem + r_t(1).num_rod_elem And p_s.num_rod_tapers >= 9 Then
							r_e(i).length = r_t(9).rod_elem_len
							r_e(i).m_d = r_e(i - 1).m_d + r_t(9).rod_elem_len
						ElseIf CDbl(i) = r_t(9).num_rod_elem + r_t(8).num_rod_elem + r_t(7).num_rod_elem + r_t(6).num_rod_elem + r_t(5).num_rod_elem + r_t(4).num_rod_elem + r_t(3).num_rod_elem + r_t(2).num_rod_elem + r_t(1).num_rod_elem Then
							r_e(i).length = r_t(9).rod_elem_len
							r_e(i).m_d = r_t(9).taper_depth
						ElseIf CDbl(i) < r_t(10).num_rod_elem + r_t(9).num_rod_elem + r_t(8).num_rod_elem + r_t(7).num_rod_elem + r_t(6).num_rod_elem + r_t(5).num_rod_elem + r_t(4).num_rod_elem + r_t(3).num_rod_elem + r_t(2).num_rod_elem + r_t(1).num_rod_elem And p_s.num_rod_tapers >= 10 Then
							r_e(i).length = r_t(10).rod_elem_len
							r_e(i).m_d = r_e(i - 1).m_d + r_t(10).rod_elem_len
						ElseIf CDbl(i) = r_t(10).num_rod_elem + r_t(9).num_rod_elem + r_t(8).num_rod_elem + r_t(7).num_rod_elem + r_t(6).num_rod_elem + r_t(5).num_rod_elem + r_t(4).num_rod_elem + r_t(3).num_rod_elem + r_t(2).num_rod_elem + r_t(1).num_rod_elem Then
							r_e(i).length = r_t(10).rod_elem_len
							r_e(i).m_d = r_t(10).taper_depth
						ElseIf CDbl(i) < r_t(11).num_rod_elem + r_t(10).num_rod_elem + r_t(9).num_rod_elem + r_t(8).num_rod_elem + r_t(7).num_rod_elem + r_t(6).num_rod_elem + r_t(5).num_rod_elem + r_t(4).num_rod_elem + r_t(3).num_rod_elem + r_t(2).num_rod_elem + r_t(1).num_rod_elem And p_s.num_rod_tapers >= 11 Then
							r_e(i).length = r_t(11).rod_elem_len
							r_e(i).m_d = r_e(i - 1).m_d + r_t(11).rod_elem_len
							r_e(i).Grade = r_t(11).Grade
						ElseIf CDbl(i) = r_t(11).num_rod_elem + r_t(10).num_rod_elem + r_t(9).num_rod_elem + r_t(8).num_rod_elem + r_t(7).num_rod_elem + r_t(6).num_rod_elem + r_t(5).num_rod_elem + r_t(4).num_rod_elem + r_t(3).num_rod_elem + r_t(2).num_rod_elem + r_t(1).num_rod_elem Then
							r_e(i).length = r_t(11).rod_elem_len
							r_e(i).m_d = r_t(11).taper_depth
							r_e(i).Grade = r_t(11).Grade
						ElseIf CDbl(i) < r_t(12).num_rod_elem + r_t(11).num_rod_elem + r_t(10).num_rod_elem + r_t(9).num_rod_elem + r_t(8).num_rod_elem + r_t(7).num_rod_elem + r_t(6).num_rod_elem + r_t(5).num_rod_elem + r_t(4).num_rod_elem + r_t(3).num_rod_elem + r_t(2).num_rod_elem + r_t(1).num_rod_elem And p_s.num_rod_tapers >= 12 Then
							r_e(i).length = r_t(12).rod_elem_len
							r_e(i).m_d = r_e(i - 1).m_d + r_t(12).rod_elem_len
							r_e(i).Grade = r_t(12).Grade
						ElseIf CDbl(i) = r_t(12).num_rod_elem + r_t(11).num_rod_elem + r_t(10).num_rod_elem + r_t(9).num_rod_elem + r_t(8).num_rod_elem + r_t(7).num_rod_elem + r_t(6).num_rod_elem + r_t(5).num_rod_elem + r_t(4).num_rod_elem + r_t(3).num_rod_elem + r_t(2).num_rod_elem + r_t(1).num_rod_elem Then
							r_e(i).length = r_t(12).rod_elem_len
							r_e(i).m_d = r_t(12).taper_depth
							r_e(i).Grade = r_t(12).Grade
						ElseIf CDbl(i) < r_t(13).num_rod_elem + r_t(12).num_rod_elem + r_t(11).num_rod_elem + r_t(10).num_rod_elem + r_t(9).num_rod_elem + r_t(8).num_rod_elem + r_t(7).num_rod_elem + r_t(6).num_rod_elem + r_t(5).num_rod_elem + r_t(4).num_rod_elem + r_t(3).num_rod_elem + r_t(2).num_rod_elem + r_t(1).num_rod_elem And p_s.num_rod_tapers >= 13 Then
							r_e(i).length = r_t(13).rod_elem_len
							r_e(i).m_d = r_e(i - 1).m_d + r_t(13).rod_elem_len
							r_e(i).Grade = r_t(13).Grade
						ElseIf CDbl(i) = r_t(13).num_rod_elem + r_t(12).num_rod_elem + r_t(11).num_rod_elem + r_t(10).num_rod_elem + r_t(9).num_rod_elem + r_t(8).num_rod_elem + r_t(7).num_rod_elem + r_t(6).num_rod_elem + r_t(5).num_rod_elem + r_t(4).num_rod_elem + r_t(3).num_rod_elem + r_t(2).num_rod_elem + r_t(1).num_rod_elem Then
							r_e(i).length = r_t(13).rod_elem_len
							r_e(i).m_d = r_t(13).taper_depth
							r_e(i).Grade = r_t(13).Grade
						ElseIf CDbl(i) < r_t(14).num_rod_elem + r_t(13).num_rod_elem + r_t(12).num_rod_elem + r_t(11).num_rod_elem + r_t(10).num_rod_elem + r_t(9).num_rod_elem + r_t(8).num_rod_elem + r_t(7).num_rod_elem + r_t(6).num_rod_elem + r_t(5).num_rod_elem + r_t(4).num_rod_elem + r_t(3).num_rod_elem + r_t(2).num_rod_elem + r_t(1).num_rod_elem And p_s.num_rod_tapers >= 14 Then
							r_e(i).length = r_t(14).rod_elem_len
							r_e(i).m_d = r_e(i - 1).m_d + r_t(14).rod_elem_len
							r_e(i).Grade = r_t(14).Grade
						ElseIf CDbl(i) = r_t(14).num_rod_elem + r_t(13).num_rod_elem + r_t(12).num_rod_elem + r_t(11).num_rod_elem + r_t(10).num_rod_elem + r_t(9).num_rod_elem + r_t(8).num_rod_elem + r_t(7).num_rod_elem + r_t(6).num_rod_elem + r_t(5).num_rod_elem + r_t(4).num_rod_elem + r_t(3).num_rod_elem + r_t(2).num_rod_elem + r_t(1).num_rod_elem Then
							r_e(i).length = r_t(14).rod_elem_len
							r_e(i).m_d = r_t(14).taper_depth
							r_e(i).Grade = r_t(14).Grade
						ElseIf CDbl(i) < r_t(15).num_rod_elem + r_t(14).num_rod_elem + r_t(13).num_rod_elem + r_t(12).num_rod_elem + r_t(11).num_rod_elem + r_t(10).num_rod_elem + r_t(9).num_rod_elem + r_t(8).num_rod_elem + r_t(7).num_rod_elem + r_t(6).num_rod_elem + r_t(5).num_rod_elem + r_t(4).num_rod_elem + r_t(3).num_rod_elem + r_t(2).num_rod_elem + r_t(1).num_rod_elem And p_s.num_rod_tapers >= 15 Then
							r_e(i).length = r_t(15).rod_elem_len
							r_e(i).m_d = r_e(i - 1).m_d + r_t(15).rod_elem_len
							r_e(i).Grade = r_t(15).Grade
						ElseIf CDbl(i) = r_t(15).num_rod_elem + r_t(14).num_rod_elem + r_t(13).num_rod_elem + r_t(12).num_rod_elem + r_t(11).num_rod_elem + r_t(10).num_rod_elem + r_t(9).num_rod_elem + r_t(8).num_rod_elem + r_t(7).num_rod_elem + r_t(6).num_rod_elem + r_t(5).num_rod_elem + r_t(4).num_rod_elem + r_t(3).num_rod_elem + r_t(2).num_rod_elem + r_t(1).num_rod_elem Then
							r_e(i).length = r_t(15).rod_elem_len
							r_e(i).m_d = r_t(15).taper_depth
							r_e(i).Grade = r_t(15).Grade
						ElseIf CDbl(i) < r_t(16).num_rod_elem + r_t(15).num_rod_elem + r_t(14).num_rod_elem + r_t(13).num_rod_elem + r_t(12).num_rod_elem + r_t(11).num_rod_elem + r_t(10).num_rod_elem + r_t(9).num_rod_elem + r_t(8).num_rod_elem + r_t(7).num_rod_elem + r_t(6).num_rod_elem + r_t(5).num_rod_elem + r_t(4).num_rod_elem + r_t(3).num_rod_elem + r_t(2).num_rod_elem + r_t(1).num_rod_elem And p_s.num_rod_tapers >= 16 Then
							r_e(i).length = r_t(16).rod_elem_len
							r_e(i).m_d = r_e(i - 1).m_d + r_t(16).rod_elem_len
							r_e(i).Grade = r_t(16).Grade
						ElseIf CDbl(i) = r_t(16).num_rod_elem + r_t(15).num_rod_elem + r_t(14).num_rod_elem + r_t(13).num_rod_elem + r_t(12).num_rod_elem + r_t(11).num_rod_elem + r_t(10).num_rod_elem + r_t(9).num_rod_elem + r_t(8).num_rod_elem + r_t(7).num_rod_elem + r_t(6).num_rod_elem + r_t(5).num_rod_elem + r_t(4).num_rod_elem + r_t(3).num_rod_elem + r_t(2).num_rod_elem + r_t(1).num_rod_elem Then
							r_e(i).length = r_t(16).rod_elem_len
							r_e(i).m_d = r_t(16).taper_depth
							r_e(i).Grade = r_t(16).Grade
						ElseIf CDbl(i) < r_t(17).num_rod_elem + r_t(16).num_rod_elem + r_t(15).num_rod_elem + r_t(14).num_rod_elem + r_t(13).num_rod_elem + r_t(12).num_rod_elem + r_t(11).num_rod_elem + r_t(10).num_rod_elem + r_t(9).num_rod_elem + r_t(8).num_rod_elem + r_t(7).num_rod_elem + r_t(6).num_rod_elem + r_t(5).num_rod_elem + r_t(4).num_rod_elem + r_t(3).num_rod_elem + r_t(2).num_rod_elem + r_t(1).num_rod_elem And p_s.num_rod_tapers >= 17 Then
							r_e(i).length = r_t(17).rod_elem_len
							r_e(i).m_d = r_e(i - 1).m_d + r_t(17).rod_elem_len
							r_e(i).Grade = r_t(17).Grade
						ElseIf CDbl(i) = r_t(17).num_rod_elem + r_t(16).num_rod_elem + r_t(15).num_rod_elem + r_t(14).num_rod_elem + r_t(13).num_rod_elem + r_t(12).num_rod_elem + r_t(11).num_rod_elem + r_t(10).num_rod_elem + r_t(9).num_rod_elem + r_t(8).num_rod_elem + r_t(7).num_rod_elem + r_t(6).num_rod_elem + r_t(5).num_rod_elem + r_t(4).num_rod_elem + r_t(3).num_rod_elem + r_t(2).num_rod_elem + r_t(1).num_rod_elem Then
							r_e(i).length = r_t(17).rod_elem_len
							r_e(i).m_d = r_t(17).taper_depth
							r_e(i).Grade = r_t(17).Grade
						ElseIf CDbl(i) < r_t(18).num_rod_elem + r_t(17).num_rod_elem + r_t(16).num_rod_elem + r_t(15).num_rod_elem + r_t(14).num_rod_elem + r_t(13).num_rod_elem + r_t(12).num_rod_elem + r_t(11).num_rod_elem + r_t(10).num_rod_elem + r_t(9).num_rod_elem + r_t(8).num_rod_elem + r_t(7).num_rod_elem + r_t(6).num_rod_elem + r_t(5).num_rod_elem + r_t(4).num_rod_elem + r_t(3).num_rod_elem + r_t(2).num_rod_elem + r_t(1).num_rod_elem And p_s.num_rod_tapers >= 18 Then
							r_e(i).length = r_t(18).rod_elem_len
							r_e(i).m_d = r_e(i - 1).m_d + r_t(18).rod_elem_len
							r_e(i).Grade = r_t(18).Grade
						ElseIf CDbl(i) = r_t(18).num_rod_elem + r_t(17).num_rod_elem + r_t(16).num_rod_elem + r_t(15).num_rod_elem + r_t(14).num_rod_elem + r_t(13).num_rod_elem + r_t(12).num_rod_elem + r_t(11).num_rod_elem + r_t(10).num_rod_elem + r_t(9).num_rod_elem + r_t(8).num_rod_elem + r_t(7).num_rod_elem + r_t(6).num_rod_elem + r_t(5).num_rod_elem + r_t(4).num_rod_elem + r_t(3).num_rod_elem + r_t(2).num_rod_elem + r_t(1).num_rod_elem Then
							r_e(i).length = r_t(18).rod_elem_len
							r_e(i).m_d = r_t(18).taper_depth
							r_e(i).Grade = r_t(18).Grade
						ElseIf CDbl(i) < r_t(19).num_rod_elem + r_t(18).num_rod_elem + r_t(17).num_rod_elem + r_t(16).num_rod_elem + r_t(15).num_rod_elem + r_t(14).num_rod_elem + r_t(13).num_rod_elem + r_t(12).num_rod_elem + r_t(11).num_rod_elem + r_t(10).num_rod_elem + r_t(9).num_rod_elem + r_t(8).num_rod_elem + r_t(7).num_rod_elem + r_t(6).num_rod_elem + r_t(5).num_rod_elem + r_t(4).num_rod_elem + r_t(3).num_rod_elem + r_t(2).num_rod_elem + r_t(1).num_rod_elem And p_s.num_rod_tapers >= 19 Then
							r_e(i).length = r_t(19).rod_elem_len
							r_e(i).m_d = r_e(i - 1).m_d + r_t(19).rod_elem_len
							r_e(i).Grade = r_t(19).Grade
						ElseIf CDbl(i) = r_t(19).num_rod_elem + r_t(18).num_rod_elem + r_t(17).num_rod_elem + r_t(16).num_rod_elem + r_t(15).num_rod_elem + r_t(14).num_rod_elem + r_t(13).num_rod_elem + r_t(12).num_rod_elem + r_t(11).num_rod_elem + r_t(10).num_rod_elem + r_t(9).num_rod_elem + r_t(8).num_rod_elem + r_t(7).num_rod_elem + r_t(6).num_rod_elem + r_t(5).num_rod_elem + r_t(4).num_rod_elem + r_t(3).num_rod_elem + r_t(2).num_rod_elem + r_t(1).num_rod_elem Then
							r_e(i).length = r_t(19).rod_elem_len
							r_e(i).m_d = r_t(19).taper_depth
							r_e(i).Grade = r_t(19).Grade
						ElseIf CDbl(i) < r_t(20).num_rod_elem + r_t(19).num_rod_elem + r_t(18).num_rod_elem + r_t(17).num_rod_elem + r_t(16).num_rod_elem + r_t(15).num_rod_elem + r_t(14).num_rod_elem + r_t(13).num_rod_elem + r_t(12).num_rod_elem + r_t(11).num_rod_elem + r_t(10).num_rod_elem + r_t(9).num_rod_elem + r_t(8).num_rod_elem + r_t(7).num_rod_elem + r_t(6).num_rod_elem + r_t(5).num_rod_elem + r_t(4).num_rod_elem + r_t(3).num_rod_elem + r_t(2).num_rod_elem + r_t(1).num_rod_elem And p_s.num_rod_tapers >= 20 Then
							r_e(i).length = r_t(20).rod_elem_len
							r_e(i).m_d = r_e(i - 1).m_d + r_t(20).rod_elem_len
							r_e(i).Grade = r_t(20).Grade
						ElseIf CDbl(i) = r_t(20).num_rod_elem + r_t(19).num_rod_elem + r_t(18).num_rod_elem + r_t(17).num_rod_elem + r_t(16).num_rod_elem + r_t(15).num_rod_elem + r_t(14).num_rod_elem + r_t(13).num_rod_elem + r_t(12).num_rod_elem + r_t(11).num_rod_elem + r_t(10).num_rod_elem + r_t(9).num_rod_elem + r_t(8).num_rod_elem + r_t(7).num_rod_elem + r_t(6).num_rod_elem + r_t(5).num_rod_elem + r_t(4).num_rod_elem + r_t(3).num_rod_elem + r_t(2).num_rod_elem + r_t(1).num_rod_elem Then
							r_e(i).length = r_t(20).rod_elem_len
							r_e(i).m_d = r_t(20).taper_depth
							r_e(i).Grade = r_t(20).Grade
						Else
							p_s.iostat = -9960
							If bStopForError Or p_s.iostat <> 0 Then
								RSWIN_DESC.rst.PumpDepth = CSng(num)
								Return
							End If
						End If

					i += 1
				End While
				Dim num30 As Integer = 1
				Dim num_rod_elements2 As Integer = p_s.num_rod_elements
				i = num30
				While i <= num_rod_elements2
					r_e(i).m_d_multi_matl = r_e(i).m_d
					i += 1
				End While
				Dim num31 As Integer = 1
				Dim num_rod_elements3 As Integer = p_s.num_rod_elements
				i = num31
				While i <= num_rod_elements3
					r_e(i).m_d = r_e(i).m_d_multi_matl
					Dim num32 As Integer = 0
					While r_e(i).m_d > s_p(num19 + 1).m_d
						If r_e(i).m_d > s_p(num19 + 1).m_d Then
							num19 += 1
							num20 += 1
							num32 += 1
						End If
					End While
					If i = p_s.num_rod_elements Then
						i = p_s.num_rod_elements
					End If
					If i = 26 Then
						i = 26
					End If

						If s_p(num19).dog > p_s.epsilon Then
							If i = 1 Then
								If s_p(2).m_d < r_e(1).m_d - 0.5 Then
									i = 1
									Debug.WriteLine(Conversions.ToString(p_s.rod_element_length) + " , " + Conversions.ToString(p_s.num_rod_elements))
									p_s.iostat = -8569
									RSWIN_DESC.rst.PumpDepth = CSng(num)
									Return
								End If
								If s_p(1).rad = -9999.0 Or s_p(2).m_d < r_e(1).m_d Then
									Try
										If r_e(1).dog > p_s.epsilon Then
											r_e(1).rad = (r_e(1).m_d - r_e(0).m_d) / r_e(1).dog
										Else
											r_e(1).rad = (r_e(1).m_d - r_e(0).m_d) / p_s.epsilon
										End If
										s_p(1).rad = r_e(1).rad
										num10 = (r_e(1).m_d - s_p(1).m_d) / s_p(1).rad
										GoTo IL_3F84
									Catch ex As Exception
										GoTo IL_3F84
									End Try
								End If
								num10 = (r_e(1).m_d - s_p(1).m_d) / s_p(1).rad
							ElseIf num32 > 0 Then
								Dim num33 As Integer = num19
								Dim num34 As Integer = num33 - num32
								Dim num35 As Double = s_p(num34).inc + (s_p(num34 + 1).inc - s_p(num34).inc) * (r_e(i - 1).m_d - s_p(num34).m_d) / (s_p(num34 + 1).m_d - s_p(num34).m_d)
								Dim inc As Double = s_p(num33).inc + (s_p(num33 + 1).inc - s_p(num33).inc) * (r_e(i).m_d - s_p(num33).m_d) / (s_p(num33 + 1).m_d - s_p(num33).m_d)
								Dim num36 As Double = s_p(num34).azi + (s_p(num34 + 1).azi - s_p(num34).azi) * (r_e(i - 1).m_d - s_p(num34).m_d) / (s_p(num34 + 1).m_d - s_p(num34).m_d)
								Dim azi As Double = s_p(num33).azi + (s_p(num33 + 1).azi - s_p(num33).azi) * (r_e(i).m_d - s_p(num33).m_d) / (s_p(num33 + 1).m_d - s_p(num33).m_d)
								r_e(i - 1).tan.x = Math.Sin(r_e(i - 1).inc) * Math.Sin(r_e(i - 1).azi)
								r_e(i - 1).tan.y = Math.Sin(r_e(i - 1).inc) * Math.Cos(r_e(i - 1).azi)
								r_e(i - 1).tan.z = Math.Cos(r_e(i - 1).inc)
								r_e(i).inc = inc
								r_e(i).azi = azi
								r_e(i).tan.x = Math.Sin(r_e(i).inc) * Math.Sin(r_e(i).azi)
								r_e(i).tan.y = Math.Sin(r_e(i).inc) * Math.Cos(r_e(i).azi)
								r_e(i).tan.z = Math.Cos(r_e(i).inc)
								r_e(i).dog = -9999.0
								Me.calc_dog(r_e(i).dog, r_e(i - 1).tan, r_e(i).tan, p_s.epsilon, p_s.iostat, bStopForError)
								r_e(i).rad = -9999.0
								If r_e(i).dog > p_s.epsilon Then
									' The following expression was wrapped in a checked-expression
									r_e(i).rad = (r_e(i).m_d - r_e(i - 1).m_d) / r_e(i).dog
								End If
							Else
								num10 = (r_e(i).m_d - s_p(num19).m_d) / s_p(num19).rad
							End If
							IL_3F84:
							If num32 <= 0 Then
								r_e(i).tan.x = Math.Cos(num10) * s_p(num19).tan.x + Math.Sin(num10) * s_p(num19).nor.x
								r_e(i).tan.y = Math.Cos(num10) * s_p(num19).tan.y + Math.Sin(num10) * s_p(num19).nor.y
								r_e(i).tan.z = Math.Cos(num10) * s_p(num19).tan.z + Math.Sin(num10) * s_p(num19).nor.z
							End If
							If i = 1 Then
								If s_p(2).m_d < r_e(1).m_d - 0.5 Then
									i = 1
									p_s.iostat = -8568
									RSWIN_DESC.rst.PumpDepth = CSng(num)
									Return
								End If
								r_e(1).inc = s_p(1).inc + (s_p(2).inc - s_p(1).inc) * (r_e(1).m_d - s_p(1).m_d) / (s_p(2).m_d - s_p(1).m_d)
								r_e(1).azi = s_p(1).azi + (s_p(2).azi - s_p(1).azi) * (r_e(1).m_d - s_p(1).m_d) / (s_p(2).m_d - s_p(1).m_d)
							ElseIf num32 <= 0 Then
								' The following expression was wrapped in a checked-expression
								' The following expression was wrapped in a checked-expression
								' The following expression was wrapped in a checked-expression
								' The following expression was wrapped in a checked-expression
								r_e(i).inc = r_e(i - 1).inc + (s_p(num19 + 1).inc - s_p(num19).inc) * (r_e(i).m_d - r_e(i - 1).m_d) / (s_p(num19 + 1).m_d - s_p(num19).m_d)
								r_e(i).azi = r_e(i - 1).azi + (s_p(num19 + 1).azi - s_p(num19).azi) * (r_e(i).m_d - r_e(i - 1).m_d) / (s_p(num19 + 1).m_d - s_p(num19).m_d)
							End If
						Else
							r_e(i).tan.x = s_p(num19).tan.x
							r_e(i).tan.y = s_p(num19).tan.y
							r_e(i).tan.z = s_p(num19).tan.z
						End If

					i += 1
				End While
				If r_e(p_s.num_rod_elements).m_d > r_t(p_s.num_rod_tapers).taper_depth Then
					r_e(p_s.num_rod_elements).m_d = r_t(p_s.num_rod_tapers).taper_depth
				End If
				Me.calc_dog(r_e(i).dog, s_p(1).tan, r_e(1).tan, p_s.epsilon, p_s.iostat, bStopForError)
				r_e(1).rad = -9999.0
				If r_e(1).dog > p_s.epsilon Then
					' The following expression was wrapped in a unchecked-expression
					r_e(1).rad = r_e(1).m_d - s_p(1).m_d / r_e(1).dog
				End If
				Dim num37 As Integer = 2
				Dim num_rod_elements4 As Integer = p_s.num_rod_elements
				i = num37
				While i <= num_rod_elements4
					If i = p_s.num_rod_elements Then
						i = i * 1 + 1 - 1
					End If
					Me.calc_dog(r_e(i).dog, r_e(i - 1).tan, r_e(i).tan, p_s.epsilon, p_s.iostat, bStopForError)
					r_e(i).rad = -9999.0
					If r_e(i).dog > p_s.epsilon Then
						' The following expression was wrapped in a unchecked-expression
						' The following expression was wrapped in a checked-expression
						r_e(i).rad = r_e(i).m_d - r_e(i - 1).m_d / r_e(i).dog
					End If
					i += 1
				End While
				If r_e(1).dog > p_s.epsilon Then
					Me.calc_nor(r_e(1).nor, r_e(1).tan, s_p(1).tan)
				Else
					r_e(1).nor.x = -9999.0
					r_e(1).nor.y = -9999.0
					r_e(1).nor.z = -9999.0
				End If
				num5 = 0
				Dim num38 As Integer = 1
				Dim num39 As Integer = p_s.num_rod_elements - 1
				i = num38
				While i <= num39
					If i = 1 Then
						i = p_s.num_rod_elements * 0 + i
					End If
					r_e(i).nor.x = -9999.0
					r_e(i).nor.y = -9999.0
					r_e(i).nor.z = -9999.0
					If r_e(i).dog > p_s.epsilon Then
						Me.calc_nor(r_e(i).nor, r_e(i + 1).tan, r_e(i).tan)
						num5 = 1
					ElseIf r_e(i - 1).dog > p_s.epsilon And num5 = 1 Then
						Me.calc_nor(r_e(i).nor, r_e(i - 1).tan, r_e(i).tan)
					ElseIf num5 = 1 Then
						r_e(i).nor.x = r_e(i - 1).nor.x
						r_e(i).nor.y = r_e(i - 1).nor.y
						r_e(i).nor.z = r_e(i - 1).nor.z
					End If
					i += 1
				End While
				r_e(p_s.num_rod_elements).nor.x = r_e(p_s.num_rod_elements - 1).nor.x
				r_e(p_s.num_rod_elements).nor.y = r_e(p_s.num_rod_elements - 1).nor.y
				r_e(p_s.num_rod_elements).nor.z = r_e(p_s.num_rod_elements - 1).nor.z
				Dim num40 As Integer = 1
				Dim num_rod_elements5 As Integer = p_s.num_rod_elements
				i = num40
				While i <= num_rod_elements5
					If i = p_s.num_rod_elements Then
						i = p_s.num_rod_elements
					End If

						If r_e(i).nor.x <> -9999.0 Then
							r_e(i).nor.x = -r_e(i).nor.x
							r_e(i).nor.y = -r_e(i).nor.y
							r_e(i).nor.z = -r_e(i).nor.z
						End If

					i += 1
				End While
				If r_e(1).dog > p_s.epsilon Then
					Me.calc_pos_lower(r_e(1).pos, s_p(1).pos, r_e(1).tan, r_e(1).nor, r_e(1).dog, r_e(1).rad)
				Else
					Me.calc_str_lower(r_e(1).pos, s_p(1).pos, r_e(1).tan, r_e(1).m_d, s_p(1).m_d)
				End If
				Dim num41 As Integer = 2
				Dim num_rod_elements6 As Integer = p_s.num_rod_elements
				i = num41
				While i <= num_rod_elements6
					If r_e(i).dog > p_s.epsilon Then
						Me.calc_pos_lower(r_e(i).pos, r_e(i - 1).pos, r_e(i).tan, r_e(i).nor, r_e(i).dog, r_e(i).rad)
					Else
						Me.calc_str_lower(r_e(i).pos, r_e(i - 1).pos, r_e(i).tan, r_e(i).m_d, r_e(i - 1).m_d)
					End If
					i += 1
				End While
				i = 1
				While Conversion.Int(r_e(i).m_d) < Conversion.Int(p_s.liquid_level) And i < p_s.num_rod_elements
					i += 1
				End While
				i -= 1
				p_s.liquid_level_TVD = r_e(i).pos.z + (r_e(i + 1).pos.z - r_e(i).pos.z) * (p_s.liquid_level - r_e(i).m_d) / (r_e(i + 1).m_d - r_e(i).m_d)
				Dim num42 As Integer = 1
				Dim num_rod_elements7 As Integer = p_s.num_rod_elements
				Dim cart_coord_type As TEImpred.cart_coord_type
				i = num42
				While i <= num_rod_elements7

						If r_e(i).dog > p_s.epsilon Then
							Dim num43 As Double = Math.Sin(0.5 * r_e(i).dog)
							Dim num44 As Double = Math.Cos(0.5 * r_e(i).dog)
							cart_coord_type.x = r_e(i).tan.x * num44 - r_e(i).nor.x * num43
							cart_coord_type.y = r_e(i).tan.y * num44 - r_e(i).nor.y * num43
							cart_coord_type.z = r_e(i).tan.z * num44 - r_e(i).nor.z * num43
							r_e(i).nor.x = r_e(i).nor.x * num44 + r_e(i).tan.x * num43
							r_e(i).nor.y = r_e(i).nor.y * num44 + r_e(i).tan.y * num43
							r_e(i).nor.z = r_e(i).nor.z * num44 + r_e(i).tan.z * num43
							r_e(i).tan.x = cart_coord_type.x
							r_e(i).tan.y = cart_coord_type.y
							r_e(i).tan.z = cart_coord_type.z
						End If

					i += 1
				End While
				Dim num45 As Integer = 1
				Dim num_rod_elements8 As Integer = p_s.num_rod_elements
				i = num45
				While i <= num_rod_elements8
					If i = p_s.num_rod_elements Then
						i = p_s.num_rod_elements
					End If
					If Math.Abs(r_e(i).tan.x) < p_s.epsilon And Math.Abs(r_e(i).tan.y) < p_s.epsilon And Math.Abs(1.0 - r_e(i).tan.z) < p_s.epsilon Then
						r_e(i).tan.x = 0.0
						r_e(i).tan.y = 0.0
						r_e(i).tan.z = 1.0
					End If
					i += 1
				End While
				cart_coord_type.x = 0.0
				cart_coord_type.y = 0.0
				cart_coord_type.z = 1.0
				Dim num46 As Integer = 1
				Dim num_rod_elements9 As Integer = p_s.num_rod_elements
				i = num46
				While i <= num_rod_elements9
					If i = p_s.num_rod_elements Then
						i = p_s.num_rod_elements
					End If
					If r_e(i).tan.z < 1.0 Then
						Me.calc_nor(r_e(i).sfg, r_e(i).tan, cart_coord_type)
					Else
						r_e(i).sfg.x = -99990.0
						r_e(i).sfg.y = -99990.0
						r_e(i).sfg.z = -99990.0
					End If
					i += 1
				End While
				Dim flag4 As Boolean = False
				Me.pump_pos_error(p_s, r_e)
				If p_s.pump_pos_err > p_s.pump_pos_err_max Then
					flag4 = True
				Else
					i = i * 1 + 0
				End If
				If flag4 Then
					If bStopForError Then
						p_s.iostat = -9947
						RSWIN_DESC.rst.PumpDepth = CSng(num)
						Return
					End If
				End If
				p_s.dog_leg_err = True
				If Not p_s.dog_leg_err Then
					If bStopForError Then
						p_s.iostat = -9948
						p_s.iostat = -9947
						RSWIN_DESC.rst.PumpDepth = CSng(num)
						Return
					End If
				End If
				RSWIN_DESC.rst.PumpDepth = CSng(num)
			Catch ex2 As Exception
				p_s.iostat = -8522
				RSWIN_DESC.rst.PumpDepth = CSng(num)
				Interaction.MsgBox("Error: in calc_sur_Oct2007 " + ex2.Message, MsgBoxStyle.OKOnly, Nothing)
			End Try
		End Sub

		Public Sub calc_sur_2(ByRef p_s As TEImpred.parameter_structure_type, ByRef d_l As TEImpred.dog_leg_data_type(), ByRef r_t As TEImpred.rod_taper_data_type(), ByRef s_p As TEImpred.survey_point_type(), ByRef r_e As TEImpred.rod_element_data_type())
			p_s.bOpenCsv = False
			p_s.pump_pos_err = 0.0
			p_s.pump_pos_err_max = 5.0
			p_s.surv_pt_err = False
			p_s.surv_pt_err_max = 50.0
			If RSWIN_DESC.rst.PumpDepth / 200F > CSng(p_s.Min_Rod_Elements) Then
				p_s.Min_Rod_Elements = CInt(Math.Round(CDbl((RSWIN_DESC.rst.PumpDepth / 200F))))
			End If
			p_s.num_rod_elements = p_s.Min_Rod_Elements
			Dim bReRun As Boolean = False
			Me.calc_sur_Oct2007(d_l, p_s, r_t, s_p, r_e, bReRun, True)
			Me.temp = CDbl(p_s.num_rod_elements)
			If p_s.pump_pos_err > p_s.pump_pos_err_max Then
				p_s.num_rod_elements += 1
				bReRun = True
			End If
			If Me.temp <> CDbl(p_s.num_rod_elements) Then
				If Me.temp > CDbl(p_s.num_rod_elements) Then
					p_s.iostat = -9973
				End If
				Me.calc_sur_Oct2007(d_l, p_s, r_t, s_p, r_e, bReRun, True)
			End If
			Dim num As Single = CSng(p_s.num_rod_elements)
			Dim num2 As Integer = 0
			Dim num3 As Integer = 0
			While (p_s.iostat = -9945 Or p_s.iostat = -9944 Or p_s.iostat = -9947) And num2 < 2000 And num3 < 200
				bReRun = True
				p_s.iostat = 0
				p_s.num_rod_elements += 1
				If p_s.num_rod_elements > p_s.Max_Rod_Elements Then
					p_s.iostat = -8527
					Exit While
				End If
				Me.calc_sur_Oct2007(d_l, p_s, r_t, s_p, r_e, bReRun, True)
				If p_s.iostat = -9945 Or p_s.iostat = -9944 Then
					num = CSng(p_s.num_rod_elements)
					num2 += 1
				ElseIf p_s.iostat = -9947 Then
					num = CSng(p_s.num_rod_elements)
					num3 += 1
				End If
			End While
			If p_s.num_rod_elements > RSWIN_DESC.SETUP_RodElementLimit And Not RSWIN_DESC.SETUP_UseDefaultRodElementLimit Then
				p_s.num_rod_elements = RSWIN_DESC.SETUP_RodElementLimit
				RSWIN_DESC.num_rod_elements = p_s.num_rod_elements
				p_s.iostat = 0
				Me.calc_sur_Oct2007(d_l, p_s, r_t, s_p, r_e, bReRun, True)
				Debug.WriteLine(p_s.iostat)
			ElseIf p_s.iostat = -9947 Then
				p_s.iostat = 0
				If num2 = 0 And num3 = p_s.Max_Rod_Elements Then
					num = CSng(p_s.Max_Rod_Elements)
					p_s.num_rod_elements = CInt(Math.Round(CDbl(num)))
					Me.calc_sur_Oct2007(d_l, p_s, r_t, s_p, r_e, bReRun, True)
					If p_s.iostat = -9947 Then
						p_s.iostat = 0
					End If
				ElseIf num2 > 0 Then
					p_s.iostat = -8549
					Return
				End If
			End If
			If p_s.bOpenCsv Then
				FileSystem.PrintLine(Conversions.ToInteger(p_s.frn_debug_ppe), New Object() { "Pump_pos_err=, #RodEl, #SP" })
				FileSystem.FileClose(New Integer() { Conversions.ToInteger(p_s.frn_debug_ppe) })
			End If
			If p_s.iostat <> 0 Then
				Me.m_RunStatus = p_s.iostat
				Return
			End If
		End Sub

		Public Function dot_prod(ByRef v1 As TEImpred.cart_coord_type, ByRef v2 As TEImpred.cart_coord_type) As Double
			Return v1.x * v2.x + v1.y * v2.y + v1.z * v2.z
		End Function

		Public Sub calc_nor(ByRef n As TEImpred.cart_coord_type, ByRef t1 As TEImpred.cart_coord_type, ByRef t2 As TEImpred.cart_coord_type)
			Dim cart_coord_type As TEImpred.cart_coord_type
			Me.cross_prod(cart_coord_type, t2, t1)
			Dim cart_coord_type2 As TEImpred.cart_coord_type
			Me.cross_prod(cart_coord_type2, t1, cart_coord_type)
			Dim num As Double = Math.Sqrt(cart_coord_type2.x * cart_coord_type2.x + cart_coord_type2.y * cart_coord_type2.y + cart_coord_type2.z * cart_coord_type2.z)
			If num > 0.0 Then
				n.x = cart_coord_type2.x / num
				n.y = cart_coord_type2.y / num
				n.z = cart_coord_type2.z / num
				Return
			End If
			n.x = 0.0
			n.y = 0.0
			n.z = 0.0
		End Sub

		Public Sub cross_prod(ByRef result As TEImpred.cart_coord_type, ByRef v1 As TEImpred.cart_coord_type, ByRef v2 As TEImpred.cart_coord_type)
			result.x = v1.y * v2.z - v1.z * v2.y
			result.y = v1.z * v2.x - v1.x * v2.z
			result.z = v1.x * v2.y - v1.y * v2.x
		End Sub

		Public Sub calc_pos(ByRef pos2 As TEImpred.cart_coord_type, ByRef pos1 As TEImpred.cart_coord_type, ByRef tan1 As TEImpred.cart_coord_type, ByRef nor1 As TEImpred.cart_coord_type, dog1 As Double, rad1 As Double)
			Dim num As Double = rad1 * Math.Sin(dog1)
			Dim num2 As Double = rad1 * (1.0 - Math.Cos(dog1))
			pos2.x = pos1.x + num * tan1.x + num2 * nor1.x
			pos2.y = pos1.y + num * tan1.y + num2 * nor1.y
			pos2.z = pos1.z + num * tan1.z + num2 * nor1.z
		End Sub

		Public Sub calc_str(ByRef pos2 As TEImpred.cart_coord_type, ByRef pos1 As TEImpred.cart_coord_type, ByRef tan1 As TEImpred.cart_coord_type, ByRef m_d2 As Double, ByRef m_d1 As Double)
			Dim num As Double = m_d2 - m_d1
			pos2.x = pos1.x + num * tan1.x
			pos2.y = pos1.y + num * tan1.y
			pos2.z = pos1.z + num * tan1.z
			pos2.x = pos1.x + num * tan1.x
			pos2.y = pos1.y + num * tan1.y
			pos2.z = pos1.z + num * tan1.z
		End Sub

		Public Sub calc_pos_lower(ByRef pos2 As TEImpred.cart_coord_type, ByRef pos1 As TEImpred.cart_coord_type, ByRef tan2 As TEImpred.cart_coord_type, ByRef nor2 As TEImpred.cart_coord_type, ByRef dog2 As Double, ByRef rad2 As Double)
			Dim num As Double = rad2 * Math.Sin(dog2)
			Dim num2 As Double = -rad2 * (1.0 - Math.Cos(dog2))
			pos2.x = pos1.x + num * tan2.x + num2 * nor2.x
			pos2.y = pos1.y + num * tan2.y + num2 * nor2.y
			pos2.z = pos1.z + num * tan2.z + num2 * nor2.z
		End Sub

		Public Sub calc_str_lower(ByRef pos2 As TEImpred.cart_coord_type, ByRef pos1 As TEImpred.cart_coord_type, ByRef tan2 As TEImpred.cart_coord_type, ByRef m_d2 As Double, ByRef m_d1 As Double)
			Dim num As Double = m_d2 - m_d1
			pos2.x = pos1.x + num * tan2.x
			pos2.y = pos1.y + num * tan2.y
			pos2.z = pos1.z + num * tan2.z
		End Sub

		Public Sub calc_kinemat(ByRef p_s As TEImpred.parameter_structure_type, ByRef p_u As TEImpred.pump_unit_data_point_type())
		End Sub

		Public Sub calc_motor(ByRef p_s As TEImpred.parameter_structure_type, ByRef m_c As TEImpred.motor_characteristic_data_type())
			Dim num As Integer
			Dim num5 As Integer
			Dim obj As Object
			Try
				ProjectData.ClearProjectError()
				num = 2
				Dim array As Double() = New Double(3) {}
				Dim array2 As Double() = New Double(3) {}
				p_s.vel_full_load = p_s.rpm_full_load * 0.10471975511965977
				If p_s.mot_pts_flag = 2 Then
					p_s.vel_no_load = p_s.rpm_no_load * 0.10471975511965977
				ElseIf p_s.mot_pts_flag = 3 Then
					p_s.vel_breakdown = p_s.rpm_breakdown * 0.10471975511965977
					p_s.vel_no_load = p_s.rpm_no_load * 0.10471975511965977
				ElseIf p_s.mot_pts_flag = 20 Then
					Dim num2 As Integer = 1
					Dim mot_pts As Integer = p_s.mot_pts
					Me.n = num2
					While Me.n <= mot_pts
						m_c(Me.n).vel_mot = m_c(Me.n).rpm_mot * 0.10471975511965977
						m_c(Me.n).hp_mot = m_c(Me.n).torq_mot * m_c(Me.n).vel_mot * 60.0 / 33000.0
						Me.n += 1
					End While
				End If
				p_s.mot_a = 0.0
				p_s.mot_b = 0.0
				p_s.mot_c = 0.0
				p_s.gen_A = 0.0
				p_s.gen_B = 0.0
				p_s.gen_C = 0.0
				p_s.slip_motor = (p_s.rpm_no_load - p_s.rpm_full_load) / p_s.rpm_full_load
				If p_s.mot_pts_flag = 1 Then
					p_s.mot_a = 0.0
					p_s.mot_b = 0.0
					p_s.mot_c = p_s.vel_no_load
					p_s.gen_A = 0.0
					p_s.gen_B = 0.0
					p_s.gen_C = p_s.mot_c
				End If
				If p_s.mot_pts_flag = 2 Then
					p_s.mot_a = 0.0
					p_s.mot_b = (p_s.torq_no_load - p_s.torq_full_load) / (p_s.vel_no_load - p_s.vel_full_load)
					p_s.mot_c = p_s.torq_no_load - p_s.mot_b * p_s.vel_no_load
					p_s.gen_A = 0.0
					p_s.gen_B = p_s.mot_b
					p_s.gen_C = p_s.mot_c
				End If
				If p_s.mot_pts_flag = 3 Then
					array2(1) = p_s.torq_no_load
					array2(2) = p_s.torq_full_load
					array2(3) = p_s.torq_breakdown
					array(1) = p_s.vel_no_load
					array(2) = p_s.vel_full_load
					array(3) = p_s.vel_breakdown
					Dim mot_a As Double
					Dim mot_b As Double
					Dim mot_c As Double
					Me.parabola(array, array2, mot_a, mot_b, mot_c)
					p_s.mot_a = mot_a
					p_s.mot_b = mot_b
					p_s.mot_c = mot_c
					p_s.gen_A = -p_s.mot_a
					p_s.gen_B = p_s.mot_b
					p_s.gen_C = p_s.mot_c
				End If
				If p_s.mot_pts_flag = 2 Then
					p_s.mot_pts_flag = 6
					Dim num3 As Double = p_s.vel_no_load + (p_s.vel_full_load - p_s.vel_no_load)
					Dim num4 As Double = p_s.vel_full_load - (p_s.vel_full_load - p_s.vel_no_load)
					Me.n = 1
					Do
						' The following expression was wrapped in a checked-expression
						m_c(Me.n).vel_mot = num3 + Convert.ToDouble(Me.n - 1) * (num4 - num3) / 5.0
						m_c(Me.n).torq_mot = p_s.mot_b * m_c(Me.n).vel_mot + p_s.mot_c
						Me.n += 1
					Loop While Me.n <= 6
					GoTo IL_5C5
				End If
				If p_s.mot_pts_flag = 3 Then
					p_s.mot_pts_flag = 11
					Dim num3 As Double = p_s.vel_no_load + (p_s.vel_full_load - p_s.vel_no_load)
					Dim num4 As Double = p_s.vel_breakdown
					Me.n = 1
					Do
						' The following expression was wrapped in a checked-expression
						m_c(Me.n).vel_mot = num3 + Convert.ToDouble(Me.n - 1) * (num4 - num3) / 10.0
						If m_c(Me.n).vel_mot < 0.0 Then
							m_c(Me.n).torq_mot = p_s.gen_A * Math.Pow(m_c(Me.n).vel_mot, 2.0) + p_s.gen_B * m_c(Me.n).vel_mot + p_s.gen_C
						Else
							m_c(Me.n).torq_mot = p_s.mot_a * Math.Pow(m_c(Me.n).vel_mot, 2.0) + p_s.mot_b * m_c(Me.n).vel_mot + p_s.mot_c
						End If
						Me.n += 1
					Loop While Me.n <= 11
					GoTo IL_5C5
				End If
				If p_s.mot_pts_flag <> 20 And p_s.mot_pts_flag <> 1 Then
					GoTo IL_5C5
				End If
				GoTo IL_5C5
				IL_562:
				Interaction.MsgBox("Error: in calc_motor " + Information.Err().Description, MsgBoxStyle.OKOnly, Nothing)
				GoTo IL_5C5
				IL_580:
				num5 = -1
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_596:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num5 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_580
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_5C5:
			If num5 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		Public Sub Calc_Pre_Torq(ByRef m_c As TEImpred.motor_characteristic_data_type(), ByRef p_s As TEImpred.parameter_structure_type, ByRef t_s As TEImpred.timestep_data_type(), ByRef i_cycle As Integer, ByRef i_step As Integer, ByRef flag_vari_spm As Integer, ByRef flag_vel_sign As Integer, ByRef vel_mot_0 As Double, ByRef num_spm_iter As Integer)
			' The following expression was wrapped in a checked-statement
			If i_step = 1 And t_s(p_s.num_timesteps).torq_mot < 0.0 Then
				p_s.eff_gb_func = 1.0 / p_s.eff_gb
				p_s.eff_vb_func = 1.0 / p_s.eff_vb
			ElseIf i_step > 1 And t_s(i_step - 1).torq_mot < 0.0 Then
				p_s.eff_gb_func = 1.0 / p_s.eff_gb
				p_s.eff_vb_func = 1.0 / p_s.eff_vb
			Else
				p_s.eff_gb_func = p_s.eff_gb
				p_s.eff_vb_func = p_s.eff_vb
			End If
			If i_step = 1 And t_s(p_s.num_timesteps).torq_p_r < 0.0 Then
				p_s.eff_pu_func = 1.0 / p_s.eff_pu
				Dim obj As Object = -1
			ElseIf i_step > 1 And t_s(i_step - 1).torq_p_r < 0.0 Then
				p_s.eff_pu_func = 1.0 / p_s.eff_pu
				Dim obj As Object = -1
			Else
				p_s.eff_pu_func = p_s.eff_pu
				Dim obj As Object = 1
			End If
			If False And i_cycle = 5 Then
				If i_step = 1 Then
				End If
				Dim a As Double
				If i_step = 1 Then
					a = t_s(p_s.num_timesteps).crank_angle + p_s.angl_cwt_phase
				ElseIf i_step > 1 Then
					' The following expression was wrapped in a checked-expression
					a = t_s(i_step - 1).crank_angle + p_s.angl_cwt_phase
				End If
				Dim num As Double = -p_s.torq_cwt * Math.Sin(a)
				If CDbl((i_step - 1)) / 100.0 * 100.0 + 1.0 = CDbl(i_step) Then
				End If
				If i_step = 1 OrElse i_step >= 2 Then
				End If
			End If
			If i_step = 1 And i_cycle = 1 Then
				t_s(p_s.num_timesteps).vel_beam = 0.0
				If p_s.timestep_avg = 0.0 Or p_s.API_len_A = 0.0 Then
					t_s(i_step).vel_beam = 0.0
				Else
					t_s(i_step).vel_beam = (t_s(i_step).p_r_position - 0.0) / p_s.timestep_avg / p_s.API_len_A / 12.0
				End If
			ElseIf i_step = 1 Then
				If p_s.timestep_length = 0.0 Or p_s.API_len_A = 0.0 Then
					t_s(i_step).vel_beam = 0.0
				Else
					t_s(i_step).vel_beam = (t_s(i_step).p_r_position - t_s(p_s.num_timesteps).p_r_position) / p_s.timestep_length / p_s.API_len_A / 12.0
				End If
			ElseIf i_step = 2 Then
				If p_s.timestep_length = 0.0 Or p_s.API_len_A = 0.0 Then
					t_s(i_step).vel_beam = 0.0
				Else
					' The following expression was wrapped in a checked-expression
					t_s(i_step).vel_beam = (t_s(i_step).p_r_position - t_s(i_step - 1).p_r_position) / p_s.timestep_length / p_s.API_len_A / 12.0
				End If
			ElseIf i_step = 3 Then
				If p_s.timestep_length = 0.0 Or p_s.API_len_A = 0.0 Then
					t_s(i_step).vel_beam = 0.0
				Else
					' The following expression was wrapped in a checked-expression
					t_s(i_step).vel_beam = (t_s(i_step).p_r_position - t_s(i_step - 1).p_r_position) / p_s.timestep_length / p_s.API_len_A / 12.0
				End If
			ElseIf p_s.timestep_length = 0.0 Or p_s.API_len_A = 0.0 Then
				t_s(i_step).vel_beam = 0.0
			Else
				' The following expression was wrapped in a checked-expression
				t_s(i_step).vel_beam = (t_s(i_step).p_r_position - t_s(i_step - 1).p_r_position) / p_s.timestep_length / p_s.API_len_A / 12.0
			End If
			If i_step = 1 And i_cycle = 1 Then
				t_s(i_step).acc_beam = (t_s(i_step).vel_beam - t_s(p_s.num_timesteps).vel_beam) / p_s.timestep_avg
			ElseIf i_step = 1 Then
				t_s(i_step).acc_beam = (t_s(i_step).vel_beam - t_s(p_s.num_timesteps).vel_beam) / p_s.timestep_length
			Else
				' The following expression was wrapped in a checked-expression
				t_s(i_step).acc_beam = (t_s(i_step).vel_beam - t_s(i_step - 1).vel_beam) / p_s.timestep_length
			End If
			Dim flag As Boolean = False And i_step = 3 And i_cycle = 5
			If i_step = 1 And i_cycle = 1 Then
				' The following expression was wrapped in a checked-expression
				t_s(p_s.num_timesteps).vel_cr = (t_s(p_s.num_timesteps).crank_angle - t_s(p_s.num_timesteps - 1).crank_angle) / p_s.timestep_avg
				t_s(i_step).vel_cr = (t_s(i_step).crank_angle - t_s(p_s.num_timesteps).crank_angle + 6.283185307179586) / p_s.timestep_avg
				t_s(p_s.num_timesteps).vel_cr = 0.0
				t_s(i_step).vel_cr = p_s.delta_theta_nu / p_s.timestep_avg
			Else
				t_s(i_step).vel_cr = p_s.delta_theta_nu / p_s.timestep_length
			End If
			If i_step = 1 And i_cycle = 1 Then
				t_s(i_step).acc_cr = 0.0
			ElseIf i_step = 1 Then
				t_s(i_step).acc_cr = (t_s(i_step).vel_cr - t_s(p_s.num_timesteps).vel_cr) / p_s.timestep_length
			Else
				' The following expression was wrapped in a checked-expression
				t_s(i_step).acc_cr = (t_s(i_step).vel_cr - t_s(i_step - 1).vel_cr) / p_s.timestep_length
			End If
			Dim num2 As Integer = 1
			Me.calc_torque(m_c, p_s, t_s, i_cycle, i_step, num2, flag_vari_spm, flag_vel_sign, vel_mot_0, num_spm_iter)
		End Sub

		Public Sub calc_torque(ByRef m_c As TEImpred.motor_characteristic_data_type(), ByRef p_s As TEImpred.parameter_structure_type, ByRef t_s As TEImpred.timestep_data_type(), ByRef i_cycle As Integer, ByRef i_step As Integer, ByRef how_many As Integer, ByRef flag_vari_spm As Integer, ByRef flag_vel_sign As Integer, ByRef vel_mot_0 As Double, ByRef num_spm_iter As Integer)
			Dim num As Integer
			Dim num20 As Integer
			Dim obj As Object
			Try
				ProjectData.ClearProjectError()
				num = 2
				t_s(i_step).torq_p_r_stat = t_s(i_step).torq_fact / 12.0 * t_s(i_step).p_r_force - t_s(i_step).torq_fact / 12.0 * p_s.force_su
				t_s(i_step).torq_p_r = t_s(i_step).torq_p_r_stat + t_s(i_step).torq_fact / 12.0 * p_s.inert_beam * t_s(i_step).acc_beam / 32.17405 / p_s.API_len_A
				Dim num2 As Integer = -3
				Dim num3 As Integer = 5884
				Dim flag As Boolean = i_step = num3 And i_cycle = num2
				Dim a As Double = t_s(i_step).crank_angle + p_s.angl_cwt_phase
				t_s(i_step).torq_cwt = -p_s.torq_cwt * Math.Sin(a)
				t_s(i_step).torq_mot = t_s(i_step).torq_p_r / p_s.eff_vb_func / p_s.eff_gb_func / p_s.eff_pu_func + t_s(i_step).torq_cwt / p_s.eff_vb_func / p_s.eff_gb_func + CDbl(Me.m_Irot) * t_s(i_step).acc_cr / 32.17405 / p_s.eff_vb_func / p_s.eff_gb_func
				Dim flag2 As Boolean = i_step = num3 And i_cycle = num2
				Dim flag3 As Boolean = False And i_step = 220 And i_cycle = 1
				Dim flag4 As Boolean = False And i_step = 220 And i_cycle = 1
				Dim flag5 As Boolean = False And i_step = 220 And i_cycle = 1
				Dim flag6 As Boolean = False And i_step = 220 And i_cycle = 1
				Dim num4 As Integer = 0
				Dim num5 As Integer = 2
				Dim mot_pts As Integer = p_s.mot_pts
				For i As Integer = num5 To mot_pts
					If m_c(i - 1).torq_mot <= t_s(i_step).torq_mot / p_s.ratio_tot And m_c(i).torq_mot >= t_s(i_step).torq_mot / p_s.ratio_tot And num4 = 0 Then
						' The following expression was wrapped in a unchecked-expression
						' The following expression was wrapped in a checked-expression
						' The following expression was wrapped in a checked-expression
						' The following expression was wrapped in a checked-expression
						' The following expression was wrapped in a checked-expression
						t_s(i_step).vel_mot = m_c(i - 1).vel_mot + (m_c(i).vel_mot - m_c(i - 1).vel_mot) * (t_s(i_step).torq_mot / p_s.ratio_tot - m_c(i - 1).torq_mot) / (m_c(i).torq_mot - m_c(i - 1).torq_mot)
						num4 = 1
					End If
				Next
				If num4 = 0 Then
					If t_s(i_step).torq_mot / p_s.ratio_tot > m_c(p_s.mot_pts).torq_mot Then
						' The following expression was wrapped in a checked-expression
						If m_c(p_s.mot_pts).torq_mot - m_c(p_s.mot_pts - 1).torq_mot = 0.0 Then
							' The following expression was wrapped in a checked-expression
							t_s(i_step).vel_mot = m_c(p_s.mot_pts - 1).vel_mot
						Else
							' The following expression was wrapped in a checked-expression
							' The following expression was wrapped in a checked-expression
							Dim num6 As Double = (m_c(p_s.mot_pts).vel_mot - m_c(p_s.mot_pts - 1).vel_mot) / (m_c(p_s.mot_pts).torq_mot - m_c(p_s.mot_pts - 1).torq_mot)
							t_s(i_step).vel_mot = m_c(p_s.mot_pts - 1).vel_mot + num6 * (t_s(i_step).torq_mot / p_s.ratio_tot - m_c(p_s.mot_pts - 1).torq_mot)
						End If
					Else
						If t_s(i_step).torq_mot / p_s.ratio_tot >= m_c(1).torq_mot Then
							GoTo IL_B0D
						End If
						If m_c(1).torq_mot - m_c(2).torq_mot = 0.0 Then
							t_s(i_step).vel_mot = m_c(2).vel_mot
						Else
							Dim num6 As Double = (m_c(1).vel_mot - m_c(2).vel_mot) / (m_c(1).torq_mot - m_c(2).torq_mot)
							t_s(i_step).vel_mot = m_c(2).vel_mot + num6 * (t_s(i_step).torq_mot / p_s.ratio_tot - m_c(2).torq_mot)
						End If
					End If
				End If
				If False And i_step <= 2 Then
					Dim num7 As Double = t_s(i_step).torq_mot / p_s.ratio_tot
					Dim num8 As Double = t_s(i_step).vel_mot / 0.10471975511966
					Dim num9 As Double = p_s.vel_mot * p_s.ratio_tot
					Dim num10 As Double = t_s(i_step).torq_mot / p_s.ratio_tot
					Dim num11 As Double = t_s(i_step).torq_p_r / p_s.eff_vb_func / p_s.eff_gb_func / p_s.eff_pu_func / p_s.ratio_tot
					Dim num12 As Double = t_s(i_step).torq_cwt / p_s.eff_vb_func / p_s.eff_gb_func / p_s.ratio_tot
					Dim num13 As Double = CDbl(Me.m_Irot) * t_s(i_step).acc_cr / 32.17405 / p_s.eff_vb_func / p_s.eff_gb_func / p_s.ratio_tot
					Dim vel_cr As Double = t_s(i_step).vel_cr
					Dim vel_cr2 As Double = t_s(i_step - 1).vel_cr
					Dim num14 As Double = t_s(i_step).vel_cr / 0.10471975511966 * p_s.ratio_tot
					Dim num15 As Double = vel_cr2 - num14
					Dim timestep_avg As Double = p_s.timestep_avg
					Dim acc_cr As Double = t_s(i_step).acc_cr
				End If
				If flag_vari_spm = 1 Then
					p_s.torq_eff_p_r = t_s(i_step).torq_p_r / p_s.eff_vb_func / p_s.eff_gb_func / p_s.eff_pu_func
					p_s.torq_eff_cwt = t_s(i_step).torq_cwt / p_s.eff_vb_func / p_s.eff_gb_func
					p_s.torq_eff_inert = p_s.inert_cr * t_s(i_step).acc_cr / 32.17405 / p_s.eff_vb_func / p_s.eff_gb_func + p_s.inert_cw * t_s(i_step).acc_cr / 32.17405 / p_s.eff_vb_func / p_s.eff_gb_func + p_s.inert_lss_cr * t_s(i_step).acc_cr / 32.17405 / p_s.eff_vb_func + p_s.inert_gb * t_s(i_step).acc_cr / 32.17405 / p_s.eff_vb_func + p_s.inert_mot_cr * t_s(i_step).acc_cr / 32.17405 + p_s.inert_hss_cr * t_s(i_step).acc_cr / 32.17405 + p_s.inert_vb_cr * t_s(i_step).acc_cr / 32.17405
					p_s.torq_eff_mot = p_s.torq_eff_p_r + p_s.torq_eff_cwt + p_s.torq_eff_inert
					p_s.torq_p_r_pr = t_s(i_step).torq_fact / 12.0 * t_s(i_step).p_r_force
					p_s.torq_p_r_su = -t_s(i_step).torq_fact / 12.0 * p_s.force_su
					p_s.torq_p_r_stat = t_s(i_step).torq_p_r_stat
					If Math.Abs(p_s.torq_p_r_stat - p_s.torq_p_r_pr - p_s.torq_p_r_su) > 0.0001 Then
						GoTo IL_B0D
					End If
					p_s.torq_p_r_dyn = t_s(i_step).torq_fact / 12.0 * p_s.inert_beam * t_s(i_step).acc_beam / 32.17405 / p_s.API_len_A
					p_s.torq_p_r_tot = t_s(i_step).torq_p_r
					If Math.Abs(p_s.torq_p_r_tot - p_s.torq_p_r_stat - p_s.torq_p_r_dyn) > 0.0001 Then
						GoTo IL_B0D
					End If
					If Math.Abs(p_s.vel_mot - t_s(i_step).vel_mot) <= 0.00013 Then
						Dim torq_eff_p_r As Double = p_s.torq_eff_p_r
						Dim torq_eff_cwt As Double = p_s.torq_eff_cwt
						Dim torq_eff_inert As Double = p_s.torq_eff_inert
						Dim torq_eff_mot As Double = p_s.torq_eff_mot
						Dim torq_p_r_pr As Double
						Dim torq_p_r_su As Double
						Dim num16 As Double = torq_p_r_pr + torq_p_r_su
						Dim torq_p_r_dyn As Double
						Dim num18 As Double
						Dim num17 As Double = torq_p_r_dyn + num18
						torq_p_r_pr = p_s.torq_p_r_pr
						torq_p_r_su = p_s.torq_p_r_su
						num18 = p_s.torq_p_r_pr + p_s.torq_p_r_su
						torq_p_r_dyn = p_s.torq_p_r_dyn
						Dim num19 As Double = p_s.torq_p_r_dyn + p_s.torq_p_r_stat
					End If
				End If
				Dim flag7 As Boolean = i_step <= 22 And i_cycle >= 2 And flag_vari_spm = 0
				If i_step >= 22 And i_cycle = 2 And flag_vari_spm = 0 Then
					If t_s(i_step).vel_mot >= p_s.vel_mot And t_s(i_step - 1).vel_mot <= p_s.vel_mot Then
						flag_vari_spm = 1
						flag_vel_sign = 1
						vel_mot_0 = p_s.vel_mot
					ElseIf t_s(i_step).vel_mot <= p_s.vel_mot And t_s(i_step - 1).vel_mot >= p_s.vel_mot Then
						flag_vari_spm = 1
						flag_vel_sign = -1
						vel_mot_0 = p_s.vel_mot
					End If
				End If
				GoTo IL_B0D
				IL_AAA:
				Interaction.MsgBox("Error: in calc_torque " + Information.Err().Description, MsgBoxStyle.OKOnly, Nothing)
				GoTo IL_B0D
				IL_AC8:
				num20 = -1
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_ADE:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num20 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_AC8
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_B0D:
			If num20 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		Public Sub calc_pu(ByRef l_u As TEImpred.lookup_table_data_type(), ByRef p_s As TEImpred.parameter_structure_type, ByRef p_u As TEImpred.pump_unit_data_point_type(), ByRef t_s As TEImpred.timestep_data_type())
			Dim num As Integer
			Dim num23 As Integer
			Dim obj As Object
			Try
				IL_00:
				ProjectData.ClearProjectError()
				num = 2
				IL_08:
				Dim num2 As Integer = 2
				p_s.iostat = 0
				IL_12:
				num2 = 3
				Dim array As Double() = New Double(p_s.num_pump_unit_data_points + 1 - 1) {}
				IL_24:
				num2 = 6
				Dim array2 As Double() = New Double(p_s.num_pump_unit_data_points + 1 - 1) {}
				IL_36:
				num2 = 9
				Dim array3 As Double() = New Double(p_s.num_pump_unit_data_points + 1 - 1) {}
				IL_49:
				num2 = 12
				Dim array4 As Double() = New Double(p_s.num_pump_unit_data_points + 1 - 1) {}
				IL_5C:
				num2 = 15
				Dim num3 As Integer = 1
				Dim num_pump_unit_data_points As Integer = p_s.num_pump_unit_data_points
				Dim i As Integer
				i = num3
				While i <= num_pump_unit_data_points
					IL_6D:
					num2 = 16
					array(i) = p_u(i).crank_angle
					IL_84:
					num2 = 17
					array2(i) = p_u(i).p_r_position
					IL_9B:
					num2 = 18
					i += 1
				End While
				IL_AB:
				num2 = 19
				i = p_s.num_pump_unit_data_points
				IL_B7:
				num2 = 20
				Dim num4 As Double = 0.0
				IL_C6:
				num2 = 21
				Dim num5 As Double = 0.0
				IL_D5:
				num2 = 22
				Dim num6 As Integer
				Me.spline(array, array2, i, num4, num5, array3, array4, num6)
				IL_EF:
				num2 = 23
				If num6 = 0 Then
					GoTo IL_10D
				End If
				IL_F7:
				num2 = 24
				p_s.iostat = -13000 - num6
				IL_108:
				GoTo IL_B5B
				IL_10D:
				num2 = 27
				Dim num7 As Double = 8.0 * Math.Atan(1.0) / CDbl(p_s.num_timesteps)
				IL_132:
				num2 = 28
				p_s.delta_theta = num7
				IL_13D:
				num2 = 29
				num6 = 0
				IL_143:
				num2 = 30
				Dim num8 As Integer = 1
				Dim num9 As Integer = p_s.num_timesteps - 1
				i = num8
				While i <= num9
					IL_156:
					num2 = 31
					t_s(i).delta_theta = num7
					IL_16A:
					num2 = 32
					t_s(i).crank_angle = p_u(1).crank_angle + CDbl(i) * num7
					IL_190:
					num2 = 33
					i += 1
				End While
				IL_1A0:
				num2 = 34
				t_s(p_s.num_timesteps).crank_angle = p_u(p_s.num_pump_unit_data_points).crank_angle
				IL_1C9:
				num2 = 35
				Dim num10 As Integer = 1
				Dim num_timesteps As Integer = p_s.num_timesteps
				i = num10
				While i <= num_timesteps
					IL_1DA:
					num2 = 36
					t_s(i).p_r_position = Me.splint(array, array2, array3, t_s(i).crank_angle, p_s.num_pump_unit_data_points, num6)
					IL_20F:
					num2 = 37
					If num6 <> 0 Then
						IL_217:
						num2 = 38
						p_s.iostat = -9975
						IL_226:
						GoTo IL_B5B
					End If
					IL_22B:
					num2 = 41
					i += 1
				End While
				IL_23B:
				num2 = 42
				p_s.max_p_r_position = 0.0
				IL_24E:
				num2 = 43
				p_s.min_p_r_position = 10000000.0
				IL_261:
				num2 = 44
				Dim num11 As Integer = 1
				Dim num_timesteps2 As Integer = p_s.num_timesteps
				i = num11
				While i <= num_timesteps2
					IL_272:
					num2 = 45
					If p_s.max_p_r_position < t_s(i).p_r_position Then
						IL_28D:
						num2 = 46
						p_s.max_p_r_position = t_s(i).p_r_position
					End If
					IL_2A6:
					num2 = 48
					If p_s.min_p_r_position > t_s(i).p_r_position Then
						IL_2C1:
						num2 = 49
						p_s.min_p_r_position = t_s(i).p_r_position
					End If
					IL_2DA:
					num2 = 51
					i += 1
				End While
				IL_2EA:
				num2 = 52
				p_s.surface_stroke = p_s.max_p_r_position - p_s.min_p_r_position
				IL_301:
				num2 = 53
				Dim num12 As Integer = 1
				Dim num_pump_unit_data_points2 As Integer = p_s.num_pump_unit_data_points
				i = num12
				While i <= num_pump_unit_data_points2
					IL_312:
					num2 = 54
					array(i) = p_u(i).crank_angle
					IL_329:
					num2 = 55
					array2(i) = p_u(i).torque_factor
					IL_340:
					num2 = 56
					i += 1
				End While
				IL_350:
				num2 = 57
				i = p_s.num_pump_unit_data_points
				IL_35C:
				num2 = 58
				num4 = 0.0
				IL_36B:
				num2 = 59
				num5 = 0.0
				IL_37A:
				num2 = 60
				Me.spline(array, array2, i, num4, num5, array3, array4, num6)
				IL_394:
				num2 = 61
				If num6 = 0 Then
					GoTo IL_3B2
				End If
				IL_39C:
				num2 = 62
				p_s.iostat = -18000 - num6
				IL_3AD:
				GoTo IL_B5B
				IL_3B2:
				num2 = 65
				Dim num13 As Integer = 1
				Dim num_timesteps3 As Integer = p_s.num_timesteps
				i = num13
				While i <= num_timesteps3
					IL_3C3:
					num2 = 66
					t_s(i).torq_fact = Me.splint(array, array2, array3, t_s(i).crank_angle, p_s.num_pump_unit_data_points, num6)
					IL_3F8:
					num2 = 67
					If num6 <> 0 Then
						IL_400:
						num2 = 68
						p_s.iostat = -8763
						IL_40F:
						GoTo IL_B5B
					End If
					IL_414:
					num2 = 71
					i += 1
				End While
				IL_424:
				num2 = 72
				If Not(RSWIN_DESC.rst.PU.UnitType = 7S Or RSWIN_DESC.rst.PU.UnitType = 10S) Then
					GoTo IL_5DB
				End If
				IL_45B:
				num2 = 73
				Dim num14 As Double = CDbl((RSWIN_DESC.rst.TotalTheta / CSng(p_s.num_timesteps)))
				IL_473:
				num2 = 74
				p_s.max_p_r_position = 0.0
				IL_486:
				num2 = 75
				p_s.min_p_r_position = 10000000.0
				IL_499:
				num2 = 76
				Dim num15 As Integer = 1
				Dim num_timesteps4 As Integer = p_s.num_timesteps
				i = num15
				While i <= num_timesteps4
					IL_4AD:
					num2 = 77

						Dim num16 As Double = CDbl(i) * num14
						IL_4B8:
						num2 = 78
						Dim theta As Double = num16
						Dim rst As cRODSTAR = RSWIN_DESC.rst
						Dim num17 As Double = CDbl(rst.SPM)
						Dim num18 As Double
						Dim torq_fact As Double
						Dim num19 As Double
						kinemat.Kinematics(theta, num17, num18, torq_fact, num19, -1, 0F)
						rst.SPM = CSng(num17)
						IL_4EC:
						num2 = 79
						t_s(i).p_r_position = num18 * 12.0
						IL_50B:
						num2 = 80
						t_s(i).crank_angle = num16
						IL_520:
						num2 = 81
						t_s(i).delta_theta = num14
						IL_534:
						num2 = 82
						t_s(i).torq_fact = torq_fact
						IL_549:
						num2 = 83
						If p_s.max_p_r_position < t_s(i).p_r_position Then
							IL_564:
							num2 = 84
							p_s.max_p_r_position = t_s(i).p_r_position
						End If
						IL_57D:
						num2 = 86
						If p_s.min_p_r_position > t_s(i).p_r_position Then
							IL_598:
							num2 = 87
							p_s.min_p_r_position = t_s(i).p_r_position
						End If
						IL_5B1:
						num2 = 89

					i += 1
				End While
				IL_5C4:
				num2 = 90
				p_s.surface_stroke = p_s.max_p_r_position - p_s.min_p_r_position
				IL_5DB:
				num2 = 92
				p_s.n_down = -1
				IL_5E6:
				num2 = 93
				If Information.UBound(l_u, 1) >= p_s.num_timesteps Then
					GoTo IL_61E
				End If
				IL_5FA:
				num2 = 94
				l_u = CType(Utils.CopyArray(CType(l_u, Array), New TEImpred.lookup_table_data_type(p_s.num_timesteps + 1 - 1) {}), TEImpred.lookup_table_data_type())
				IL_61E:
				num2 = 98
				Dim num20 As Integer = 1
				Dim num_timesteps5 As Integer = p_s.num_timesteps
				i = num20
				While i <= num_timesteps5
					IL_632:
					num2 = 99
					l_u(i).crank_angle = t_s(i).crank_angle
					IL_653:
					num2 = 100
					l_u(i).p_r_position = t_s(i).p_r_position
					IL_674:
					num2 = 101
					l_u(i).torq_fact = t_s(i).torq_fact
					IL_695:
					num2 = 102
					If l_u(i).p_r_position <= l_u(i - 1).p_r_position And i > 1 Then
						IL_6C4:
						num2 = 103
						p_s.n_down = i
					End If
					IL_6D0:
					num2 = 105
					i += 1
				End While
				IL_6E3:
				num2 = 106
				If Not(p_s.n_down < 1 Or p_s.n_down > p_s.num_timesteps) Then
					GoTo IL_717
				End If
				IL_701:
				num2 = 107
				p_s.iostat = -8749
				IL_710:
				GoTo IL_B5B
				IL_717:
				num2 = 110
				IL_71B:
				num2 = 112
				p_s.pr_velo_max_up = -10000000000.0
				IL_72E:
				num2 = 113
				p_s.pr_velo_max_dn = 10000000000.0
				IL_741:
				num2 = 114
				Dim num21 As Double = t_s(1).p_r_position - t_s(p_s.num_timesteps).p_r_position / p_s.timestep_length
				IL_770:
				num2 = 115
				If num21 <= p_s.pr_velo_max_up Then
					GoTo IL_78A
				End If
				IL_77E:
				num2 = 116
				p_s.pr_velo_max_up = num21
				IL_78A:
				num2 = 118
				If num21 >= p_s.pr_velo_max_dn Then
					GoTo IL_7A4
				End If
				IL_798:
				num2 = 119
				p_s.pr_velo_max_dn = num21
				IL_7A4:
				num2 = 121
				Dim num22 As Integer = 2
				Dim num_timesteps6 As Integer = p_s.num_timesteps
				i = num22
				While i <= num_timesteps6
					IL_7B5:
					num2 = 122
					num21 = t_s(i).p_r_position - t_s(i - 1).p_r_position / p_s.timestep_length
					IL_7E3:
					num2 = 123
					If num21 > p_s.pr_velo_max_up Then
						IL_7F1:
						num2 = 124
						p_s.pr_velo_max_up = num21
					End If
					IL_7FD:
					num2 = 126
					If num21 < p_s.pr_velo_max_dn Then
						IL_80B:
						num2 = 127
						p_s.pr_velo_max_dn = num21
					End If
					IL_817:
					num2 = 129
					i += 1
				End While
				IL_82A:
				num2 = 130
				p_s.pr_velo_max_up /= 12.0
				IL_847:
				num2 = 131
				p_s.pr_velo_max_dn /= 12.0
				IL_864:
				num2 = 132
				p_s.p_velo_max_up = p_s.pr_velo_max_up
				IL_877:
				num2 = 133
				p_s.p_velo_max_dn = p_s.pr_velo_max_dn
				IL_88A:
				GoTo IL_B5B
				IL_715:
				GoTo IL_71B
				IL_88F:
				num2 = 135
				Interaction.MsgBox("Error: in calc_pu " + Information.Err().Description, MsgBoxStyle.OKOnly, Nothing)
				IL_8B2:
				num2 = 136
				ProjectData.ClearProjectError()
				If num23 <> 0 Then
					GoTo IL_8D7
				End If
				Throw ProjectData.CreateProjectError(-2146828268)
				IL_8CD:
				IL_8D2:
				GoTo IL_B5B
				IL_8D7:
				Dim num24 As Integer = num23 + 1
				num23 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num24)
				IL_B13:
				GoTo IL_B50
				IL_B15:
				num23 = num2
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_B2C:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num23 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_B15
			End Try
			IL_B50:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_B5B:
			If num23 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		Public Sub spline(ByRef x As Double(), ByRef y As Double(), ByRef n As Integer, ByRef yp1 As Double, ByRef ypn As Double, ByRef y2 As Double(), ByRef U As Double(), ByRef status As Integer)
			status = 0
			If yp1 > 1E+20 Then
				y2(1) = 0.0
				U(1) = 0.0
			Else
				y2(1) = -0.5
				U(1) = 3.0 / (x(2) - x(1)) * ((y(2) - y(1)) / (x(2) - x(1)) - yp1)
			End If
			Dim num As Integer = 2
			Dim num2 As Integer = n
			For i As Integer = num To num2
				' The following expression was wrapped in a unchecked-expression
				' The following expression was wrapped in a checked-expression
				If x(i) - x(i - 1) < 1E-20 Then
					status = i
					Return
				End If
			Next
			Dim num3 As Integer = 2
			Dim num4 As Integer = n - 1
			For i As Integer = num3 To num4

					' The following expression was wrapped in a checked-expression
					' The following expression was wrapped in a checked-expression
					' The following expression was wrapped in a checked-expression
					Dim num5 As Double = (x(i) - x(i - 1)) / (x(i + 1) - x(i - 1))
					Dim num6 As Double = num5 * y2(i - 1) + 2.0
					y2(i) = (num5 - 1.0) / num6
					U(i) = (6.0 * ((y(i + 1) - y(i)) / (x(i + 1) - x(i)) - (y(i) - y(i - 1)) / (x(i) - x(i - 1))) / (x(i + 1) - x(i - 1)) - num5 * U(i - 1)) / num6

			Next
			Dim num7 As Double
			Dim num8 As Double
			If ypn > 1E+20 Then
				num7 = 0.0
				num8 = 0.0
			Else
				num7 = 0.5
				num8 = 3.0 / (x(n) - x(n - 1)) * (ypn - (y(n) - y(n - 1)) / (x(n) - x(n - 1)))
			End If
			y2(n) = (num8 - num7 * U(n - 1)) / (num7 * y2(n - 1) + 1.0)
			For j As Integer = n - 1 To 1 Step -1
				' The following expression was wrapped in a unchecked-expression
				' The following expression was wrapped in a checked-expression
				y2(j) = y2(j) * y2(j + 1) + U(j)
			Next
		End Sub

		Public Function splint(ByRef xa As Double(), ByRef ya As Double(), ByRef y2a As Double(), x As Double, n As Integer, status As Integer) As Double
			Dim num As Integer = 1
			Dim num2 As Integer = n
			While num2 - num > 1
				Dim num3 As Integer = CInt(Math.Round(CDbl((num2 + num)) / 2.0))
				If xa(num3) > x Then
					num2 = num3
				Else
					num = num3
				End If
			End While
			Dim num4 As Double = xa(num2) - xa(num)
			If Math.Abs(num4) < 1E-20 Then
				Return -9999.0
			End If
			Dim num5 As Double = (xa(num2) - x) / num4
			Dim num6 As Double = (x - xa(num)) / num4
			Return num5 * ya(num) + num6 * ya(num2) + ((Math.Pow(num5, 3.0) - num5) * y2a(num) + (Math.Pow(num6, 3.0) - num6) * y2a(num2)) * Math.Pow(num4, 2.0) / 6.0
		End Function

		Public Sub calc_rod(ByRef p_s As TEImpred.parameter_structure_type, ByRef r_t As TEImpred.rod_taper_data_type(), ByRef r_e As TEImpred.rod_element_data_type(), ByRef t_t As TEImpred.tbg_taper_data_type(), ByRef s_p As TEImpred.survey_point_type())
			Dim num As Integer = 1
			Dim num_rod_elements As Integer = p_s.num_rod_elements
			Dim num2 As Integer
			For i As Integer = num To num_rod_elements
				r_e(i).force_buoy = 0.0
				r_e(i).force_buoy_cum = 0.0
			Next
			num2 = 1
			If False And num2 = 1 Then
				p_s.iostat = p_s.iostat
			Else
				p_s.p_r_diam = 1.5
				p_s.p_r_area = 0.7853981633974483 * Math.Pow(p_s.p_r_diam, 2.0)
				p_s.p_r_density = 491.0
				p_s.p_r_len = CDbl((2F * RSWIN_DESC.rst.PU.KinematicStroke)) / 12.0
				p_s.p_r_mass = p_s.p_r_area / 144.0 * p_s.p_r_density * p_s.p_r_len
				p_s.p_r_weight_unbuoyed = p_s.p_r_mass * Math.Cos(r_e(1).inc) * 32.17405 / 32.17405
				p_s.p_r_MD = p_s.p_r_len / 2.0
				p_s.p_r_pos_z = p_s.p_r_MD * Math.Cos(r_e(1).inc)
				p_s.p_r_psia_tbg = p_s.tubing_pressure + 14.7 + p_s.p_r_pos_z * p_s.liquid_gravity * 0.43333333333333335
				r_e(0).hydrostat_psia_tbg = p_s.p_r_psia_tbg
				r_e(1).rod_area = 0.7853981633974483 * Math.Pow(r_t(1).rod_od, 2.0)
				p_s.p_r_weight_buoyed = p_s.p_r_mass + p_s.p_r_psia_tbg * (r_e(1).rod_area - p_s.p_r_area)
				p_s.p_r_rstWrf = 52.0
			End If
			Dim num3 As Double = 491.0
			p_s.pump_density = num3
			Dim num4 As Double = 0.25
			Dim num5 As Double = 1.2732395447351628 * Math.Sqrt(p_s.pump_area)
			Dim x As Double = 2.0 * num4 + num5
			Dim num6 As Double = 0.7853981633974483 * (Math.Pow(x, 2.0) - Math.Pow(num5, 2.0))
			Dim num7 As Double
			If False And num2 = 1 Then
				num7 = 17.0
				p_s.pump_barrel_len = 17.0
			Else
				num7 = CDbl((2F * RSWIN_DESC.rst.PU.KinematicStroke)) / 12.0
				p_s.pump_barrel_len = num7
			End If
			Dim num8 As Double = num6 / 144.0 * num7
			Dim num9 As Double = num8 * num3
			Dim num10 As Double = num9 * 32.17405 / 32.17405 * Math.Cos(r_e(p_s.num_rod_elements).inc)
			Dim num11 As Integer = 1
			If 1 = num11 Then
				num9 = 0.0
				num10 = 0.0
			End If
			Dim num12 As Double = 3.0
			Dim x2 As Double = 1.2732395447351628 * Math.Sqrt(p_s.pump_area)
			Dim num13 As Double = 0.7853981633974483 * Math.Pow(x2, 2.0)
			Dim num14 As Double = num13 / 144.0 * num12
			Dim num15 As Double = num14 * num3
			Dim num16 As Double = num15 * 32.17405 / 32.17405 * Math.Cos(r_e(p_s.num_rod_elements).inc)
			Dim num17 As Double = CDbl(RSWIN_DESC.rst.PU.KinematicStroke) / 12.0
			p_s.pump_pull_rod_diam = 0.75
			p_s.pump_pull_rod_area = 0.7853981633974483 * Math.Pow(p_s.pump_pull_rod_diam, 2.0)
			Dim num18 As Double = p_s.pump_pull_rod_area / 144.0 * num17
			Dim num19 As Double = num18 * num3
			Dim num20 As Double = num19 * 32.17405 / 32.17405 * Math.Cos(r_e(p_s.num_rod_elements).inc)
			Dim num21 As Double = num10 + num16 + num20
			Dim num22 As Double = 0.0
			num21 *= 1.0 + num22
			p_s.pump_mass = num9 + num15 + num19
			p_s.pump_weight_unbuoyed = num21
			Dim j As Integer = p_s.num_rod_elements
			p_s.pump_pos_z = r_e(j).pos.z + p_s.pump_barrel_len / 2.0 * Math.Cos(r_e(j).inc)
			p_s.hydrostat_psia_pump = p_s.pump_pos_z * p_s.liquid_gravity * 0.43333333333333335 + p_s.tubing_pressure + 14.7
			p_s.pump_weight_buoyed = p_s.pump_weight_unbuoyed - r_e(j).rod_area * p_s.hydrostat_psia_pump + r_e(j).rod_area * p_s.hydrostat_psia_pump
			Dim num23 As Integer = 2
			Try
				Dim num24 As Integer = 1
				Dim num_rod_tapers As Integer = p_s.num_rod_tapers
				j = num24
				While j <= num_rod_tapers
					' The following expression was wrapped in a unchecked-expression
					r_t(j).rod_area = 0.7853981633974483 * (Math.Pow(r_t(j).rod_od, 2.0) - Math.Pow(r_t(j).rod_id, 2.0))
					j += 1
				End While
				If False And num2 = 1 Then
					p_s.iostat = p_s.iostat
				Else
					If num23 = 1 Then
						Debug.WriteLine("")
						Debug.WriteLine("n, r_e(n).pos.z, r_e(n).hydrostat_psia_tbg @ LINE 7748")
					End If
					Dim num25 As Integer = 1
					Dim num_rod_elements2 As Integer = p_s.num_rod_elements
					j = num25
					While j <= num_rod_elements2
						' The following expression was wrapped in a unchecked-expression
						r_e(j).hydrostat_psia_tbg = r_e(j).pos.z * 0.43333333333333335 * p_s.liquid_gravity + p_s.tubing_pressure + 14.7
						If num23 = 1 Then
							Debug.WriteLine(String.Concat(New String() { Conversions.ToString(j), ",", Conversions.ToString(r_e(j).pos.z), ",", Conversions.ToString(r_e(j).hydrostat_psia_tbg) }))
						End If
						j += 1
					End While
					If num23 = 1 Then
						Debug.WriteLine("n, r_e(n).pos.z, r_e(n).hydrostat_psia_tbg @ LINE 7748")
						Debug.WriteLine("")
					End If
				End If
				r_t(0).rod_area = r_t(1).rod_area
				p_s.iostat = 0
				p_s.min_pump_load = (r_e(p_s.num_rod_elements).pos.z * 0.43333333333333335 * p_s.liquid_gravity + p_s.tubing_pressure + 14.7) * -r_t(p_s.num_rod_tapers).rod_area
				Dim num26 As Integer = 0
				If num26 = 1 Then
					p_s.min_pump_load = 0.0
				End If
				p_s.rod_bot_load_min = p_s.min_pump_load + p_s.pump_weight_buoyed
				p_s.min_pump_load += p_s.pump_weight_buoyed
				p_s.pump_fluid_load = (r_e(p_s.num_rod_elements).pos.z * 0.43333333333333335 * p_s.liquid_gravity + p_s.tubing_pressure + 14.7) * (p_s.pump_area - r_t(p_s.num_rod_tapers).rod_area) - ((r_e(p_s.num_rod_elements).pos.z - p_s.liquid_level_TVD) * 0.43333333333333335 * p_s.liq_grav_csg + p_s.casing_pressure + 14.7) * p_s.pump_area
				If num26 = 1 Then
					p_s.pump_fluid_load = (r_e(p_s.num_rod_elements).pos.z * 0.43333333333333335 * p_s.liquid_gravity + p_s.tubing_pressure + 14.7) * (p_s.pump_area - 0.0) - ((r_e(p_s.num_rod_elements).pos.z - p_s.liquid_level_TVD) * 0.43333333333333335 * p_s.liq_grav_csg + p_s.casing_pressure + 14.7) * p_s.pump_area
				End If
				p_s.rod_bot_load_max = p_s.pump_fluid_load + p_s.pump_weight_buoyed
				p_s.pump_fluid_load += p_s.pump_weight_buoyed
				If False And num2 = 1 Then
					If p_s.pump_fluid_load < p_s.min_pump_load Then
						p_s.iostat = p_s.iostat
					End If
				Else
					Dim num27 As Integer = 1
					If p_s.pump_fluid_load < p_s.min_pump_load And num27 = 1 Then
						If Not(p_s.pump_fluid_load < 0.0 And p_s.min_pump_load < 0.0) Then
							p_s.iostat = -9934
							Return
						End If
						p_s.iostat = p_s.iostat
					End If
				End If
				Dim num28 As Double = 60.0 / p_s.strokes_per_min
				p_s.num_timesteps = CInt(Math.Round(Conversion.Int(num28 / p_s.timestep_length) + 1.0))
				p_s.timestep_length = num28 / Convert.ToDouble(p_s.num_timesteps)
				If p_s.num_timesteps > p_s.max_timesteps Then
					p_s.iostat = -9931
				ElseIf r_t(1).taper_depth < r_t(1).rod_elem_len Then
					p_s.iostat = -9932
				Else
					Dim k As Integer = 1
					Dim num29 As Integer = 1
					Dim num_rod_elements3 As Integer = p_s.num_rod_elements
					Dim wrodsInFluid As Single
					j = num29
					While j <= num_rod_elements3
						If r_e(j).m_d > r_t(k).taper_depth Then
							k += 1
						End If
						r_e(j).rod_area = r_t(k).rod_area
						j += 1
					End While
					If False And num2 = 1 Then
						p_s.iostat = p_s.iostat
					Else
						Dim num30 As Integer = 2
						Dim num31 As Integer = 2
						num31 = num31
						Dim num32 As Integer = 1
						Dim num_rod_tapers2 As Integer = p_s.num_rod_tapers
						k = num32
						While k <= num_rod_tapers2

								If num30 = 1 Then
									r_t(k).dimless_damp_up = r_t(k).dimless_damp_up * 0.0 + 0.01
									r_t(k).dimless_damp_dn = r_t(k).dimless_damp_dn * 0.0 + 0.3
								End If
								If num31 = 1 Then
									r_t(k).friction_coef = r_t(k).friction_coef * 0.0 + 0.01
								End If

							k += 1
						End While
					End If
					k = 1
					Dim num33 As Integer = 1
					Dim num_rod_elements4 As Integer = p_s.num_rod_elements
					j = num33
					While j <= num_rod_elements4

							If r_e(j).m_d < r_t(k).taper_depth And j <> p_s.num_rod_elements Then
								Dim num34 As Single
								If r_t(k).rod_density <> CDbl(RSWIN_DESC.rst.Sections(k).RodDensity) And RSWIN_DESC.SETUP_UseJohnsFix Then
									num34 = CSng((0.7853981633974483 * Math.Pow(r_t(k).rod_od / 12.0, 2.0) * r_t(k).rod_density))
								Else
									num34 = RSWIN_DESC.rst.Sections(k).RodWeight
								End If
								r_e(j).mass = r_e(j).length * CDbl(num34) * 32.17405 / 32.17405
								r_e(j).unbuoy_weight = r_e(j).mass * 32.17405 / 32.17405
								r_e(j).unbuoy_weight = r_e(j).unbuoy_weight * Math.Cos(r_e(j).inc)
								If False And num2 = 1 Then
									' The following expression was wrapped in a checked-expression
									r_e(j).buoy_weight = r_e(j).unbuoy_weight + p_s.liquid_gravity * 0.43333333333333335 * r_e(j).pos.z * (r_e(j + 1).rod_area - r_e(j).rod_area)
								Else
									' The following expression was wrapped in a checked-expression
									r_e(j).buoy_weight = r_e(j).unbuoy_weight + (p_s.liquid_gravity * 0.43333333333333335 * r_e(j).pos.z + p_s.tubing_pressure + 14.7) * (r_e(j + 1).rod_area - r_e(j).rod_area)
								End If
								r_e(j).damp_coef_dn = 3.141592653589793 * r_t(k).dimless_damp_dn * Math.Sqrt(4633.0632000000005 * r_t(k).rod_modulus / r_t(k).rod_density) / (2.0 * r_t(p_s.num_rod_tapers).taper_depth)
								r_e(j).damp_coef_up = 3.141592653589793 * r_t(k).dimless_damp_up * Math.Sqrt(4633.0632000000005 * r_t(k).rod_modulus / r_t(k).rod_density) / (2.0 * r_t(p_s.num_rod_tapers).taper_depth)
								r_e(j).friction_coef = r_t(k).friction_coef
							ElseIf j = p_s.num_rod_elements Then
								Dim num34 As Single
								If r_t(k).rod_density <> CDbl(RSWIN_DESC.rst.Sections(k).RodDensity) And RSWIN_DESC.SETUP_UseJohnsFix Then
									num34 = CSng((0.7853981633974483 * Math.Pow(r_t(k).rod_od / 12.0, 2.0) * r_t(k).rod_density))
								Else
									num34 = RSWIN_DESC.rst.Sections(k).RodWeight
								End If
								r_e(j).mass = r_e(j).length * CDbl(num34) * 32.17405 / 32.17405
								r_e(j).unbuoy_weight = r_e(j).mass * 32.17405 / 32.17405
								r_e(j).unbuoy_weight = r_e(j).unbuoy_weight * Math.Cos(r_e(j).inc)
								If False And num2 = 1 Then
									r_e(j).buoy_weight = r_e(j).unbuoy_weight + p_s.liquid_gravity * 0.43333333333333335 * r_e(j).pos.z * (0.0 - r_e(j).rod_area)
								Else
									r_e(j).buoy_weight = r_e(j).unbuoy_weight + (p_s.liquid_gravity * 0.43333333333333335 * r_e(j).pos.z + p_s.tubing_pressure + 14.7) * (0.0 - r_e(j).rod_area)
								End If
								r_e(j).damp_coef_dn = 3.141592653589793 * (r_t(k).dimless_damp_dn * Math.Sqrt(4633.0632000000005 * r_t(k).rod_modulus / r_t(k).rod_density) / (2.0 * r_t(p_s.num_rod_tapers).taper_depth))
								r_e(j).damp_coef_up = 3.141592653589793 * (r_t(k).dimless_damp_up * Math.Sqrt(4633.0632000000005 * r_t(k).rod_modulus / r_t(k).rod_density) / (2.0 * r_t(p_s.num_rod_tapers).taper_depth))
								r_e(j).friction_coef = r_t(k).friction_coef
							Else
								Dim num35 As Double = 1.0 - (r_e(j).m_d - r_t(k).taper_depth) / r_e(j).length
								Dim num34 As Single
								If r_t(k + 1).rod_density <> CDbl(RSWIN_DESC.rst.Sections(k + 1).RodDensity) And RSWIN_DESC.SETUP_UseJohnsFix Then
									' The following expression was wrapped in a checked-expression
									' The following expression was wrapped in a checked-expression
									num34 = CSng((0.7853981633974483 * Math.Pow(r_t(k + 1).rod_od / 12.0, 2.0) * r_t(k + 1).rod_density))
								Else
									' The following expression was wrapped in a checked-expression
									num34 = RSWIN_DESC.rst.Sections(k + 1).RodWeight
								End If
								r_e(j).mass = r_e(j).length * num35 * CDbl(RSWIN_DESC.rst.Sections(k).RodWeight) + r_e(j).length * (1.0 - num35) * CDbl(num34)
								If False And num2 = 1 Then
									p_s.iostat = p_s.iostat
								Else
									r_e(j).mass = r_e(j).mass * 32.17405 / 32.17405
								End If
								r_e(j).unbuoy_weight = r_e(j).mass * 32.17405 / 32.17405
								r_e(j).unbuoy_weight = r_e(j).unbuoy_weight * Math.Cos(r_e(j).inc)
								If k < p_s.num_rod_tapers Then
									If False And num2 = 1 Then
										' The following expression was wrapped in a checked-expression
										r_e(j).buoy_weight = r_e(j).unbuoy_weight + p_s.liquid_gravity * 0.43333333333333335 * r_e(j).pos.z * (r_e(j + 1).rod_area - r_e(j).rod_area)
									Else
										' The following expression was wrapped in a checked-expression
										r_e(j).buoy_weight = r_e(j).unbuoy_weight + (p_s.liquid_gravity * 0.43333333333333335 * r_e(j).pos.z + 14.7 + p_s.tubing_pressure) * (r_e(j + 1).rod_area - r_e(j).rod_area)
									End If
								Else
									r_e(j).buoy_weight = r_e(j).unbuoy_weight + p_s.liquid_gravity * 0.43333333333333335 * r_e(j).pos.z * (0.0 - r_e(j).rod_area)
									If False And num2 = 1 Then
										p_s.iostat = p_s.iostat
									Else
										r_e(j).buoy_weight = r_e(j).unbuoy_weight + (p_s.liquid_gravity * 0.43333333333333335 * r_e(j).pos.z + 14.7 + p_s.tubing_pressure) * (0.0 - r_e(j).rod_area)
									End If
								End If
								r_e(j).rod_area = r_t(k).rod_area * num35 + r_t(k + 1).rod_area * (1.0 - num35)
								Debug.WriteLine(Conversions.ToString(j) + " , " + Conversions.ToString(r_e(j).rod_area))
								r_e(j).damp_coef_dn = 3.141592653589793 * (num35 * r_t(k).dimless_damp_dn * Math.Sqrt(4633.0632000000005 * r_t(k).rod_modulus / r_t(k).rod_density) + (1.0 - num35) * r_t(k + 1).dimless_damp_dn * Math.Sqrt(4633.0632000000005 * r_t(k + 1).rod_modulus / r_t(k + 1).rod_density)) / (2.0 * r_t(p_s.num_rod_tapers).taper_depth)
								r_e(j).damp_coef_up = 3.141592653589793 * (num35 * r_t(k).dimless_damp_up * Math.Sqrt(4633.0632000000005 * r_t(k).rod_modulus / r_t(k).rod_density) + (1.0 - num35) * r_t(k + 1).dimless_damp_up * Math.Sqrt(4633.0632000000005 * r_t(k + 1).rod_modulus / r_t(k + 1).rod_density)) / (2.0 * r_t(p_s.num_rod_tapers).taper_depth)
								r_e(j).friction_coef = num35 * r_t(k).friction_coef + (1.0 - num35) * r_t(k + 1).friction_coef
								k += 1
							End If

						j += 1
					End While
					k = 1
					Dim num36 As Integer = 1
					Dim num37 As Integer = p_s.num_rod_elements - 1
					j = num36
					While j <= num37
						If r_e(j).m_d < r_t(k).taper_depth Then
							' The following expression was wrapped in a unchecked-expression
							r_e(j).ea = r_t(k).rod_area * r_t(k).rod_modulus
						ElseIf r_e(j).m_d = r_t(k).taper_depth Then
							' The following expression was wrapped in a unchecked-expression
							r_e(j).ea = r_t(k).rod_area * r_t(k).rod_modulus
							k += 1
						Else
							p_s.iostat = -9971
							If p_s.iostat <> 0 Then
								Return
							End If
						End If
						j += 1
					End While
					r_e(p_s.num_rod_elements).ea = -9999.0
					wrodsInFluid = RSWIN_DESC.rst.WrodsInFluid
					p_s.WrodsInFluid = CDbl(RSWIN_DESC.rst.WrodsInFluid)
					RSWIN_DESC.rst.WrodsInFluid = 0F
					RSWIN_DESC.rst.WrodsInFluid = CSng(p_s.p_r_weight_buoyed)
					Dim num38 As Integer
					If False And num2 = 1 Then
						p_s.iostat = p_s.iostat
					Else
						num38 = 2
					End If
					Dim num39 As Integer = 1
					Dim num_rod_elements5 As Integer = p_s.num_rod_elements
					j = num39
					While j <= num_rod_elements5

							r_e(j).gravity_force = r_e(j).mass * r_e(j).tan.z
							r_e(j).gravity_force = r_e(j).mass * Math.Cos(r_e(j).inc)
							If False And num2 = 1 Then
								p_s.iostat = p_s.iostat
							Else
								r_e(j).gravity_force = r_e(j).mass * Math.Cos(r_e(j).inc) * 32.17405 / 32.17405
							End If
							r_e(j).friction_force = 0.0
							If False And num2 = 1 Then
								RSWIN_DESC.rst.WrodsInFluid = CSng((CDbl(RSWIN_DESC.rst.WrodsInFluid) + (r_e(j).buoy_weight - r_e(j).mass) + r_e(j).gravity_force))
							ElseIf num38 = 1 Then
								RSWIN_DESC.rst.WrodsInFluid = CSng((CDbl(RSWIN_DESC.rst.WrodsInFluid) + (r_e(j).buoy_weight - r_e(j).mass) + r_e(j).gravity_force))
							Else
								r_e(j).WrodsInFluid = r_e(j).buoy_weight
								RSWIN_DESC.rst.WrodsInFluid = CSng((CDbl(RSWIN_DESC.rst.WrodsInFluid) + r_e(j).WrodsInFluid))
							End If

						j += 1
					End While
					RSWIN_DESC.rst.WrodsInFluid = CSng((CDbl(RSWIN_DESC.rst.WrodsInFluid) + p_s.pump_weight_buoyed))
					Dim num40 As Integer = 0
					If num40 = 1 Then
						Dim text As String = "c:\TempRSWINFiles\Impred_Wrf.csv"
						Dim num41 As Integer
						If FILEUTIL.FileExists(text) Then
							FileSystem.FileClose(New Integer() { num41 })
							FileSystem.Kill("c:\TempRSWINFiles\Impred_Wrf.csv")
						End If
						num41 = FileSystem.FreeFile()
						FileSystem.FileOpen(num41, "c:\TempRSWINFiles\Impred_Wrf.csv", OpenMode.Output, OpenAccess.[Default], OpenShare.[Default], -1)
						FileSystem.PrintLine(num41, New Object() { String.Concat(New String() { "Impred_Wrf.z=,,", Conversions.ToString(p_s.WrodsInFluid), ",RP11L-Wrf=,,", Conversions.ToString(RSWIN_DESC.rst.WrodsInFluid), ",minFp=,", Conversions.ToString(p_s.min_pump_load), ",maxFp=,", Conversions.ToString(p_s.pump_fluid_load) }) })
						FileSystem.PrintLine(num41, New Object() { "check_buoyed_weight_in_calc_rod" })
						FileSystem.PrintLine(num41, New Object() { "n,Fgrav,Wrf.z,Wr.z,mass,rstWf,cos(inc),Ar,MD,pos.z,incDeg,Phyd" })
						FileSystem.PrintLine(num41, New Object() { String.Concat(New String() { "pr,", Conversions.ToString(p_s.p_r_mass), ",", Conversions.ToString(p_s.p_r_weight_buoyed), ",", Conversions.ToString(p_s.p_r_weight_unbuoyed), ",", Conversions.ToString(p_s.p_r_mass), ",", Conversions.ToString(p_s.p_r_weight_buoyed), ",", Conversions.ToString(Math.Cos(r_e(1).inc)), ",", Conversions.ToString(p_s.p_r_area), ",", Conversions.ToString(p_s.p_r_MD), ",", Conversions.ToString(p_s.p_r_pos_z), ",", Conversions.ToString(r_e(1).inc * 57.29577951308238), ",", Conversions.ToString(p_s.p_r_psia_tbg) }) })
						Dim num42 As Integer = 1
						Dim num_rod_elements6 As Integer = p_s.num_rod_elements
						j = num42
						While j <= num_rod_elements6
							' The following expression was wrapped in a unchecked-expression
							FileSystem.PrintLine(num41, New Object() { String.Concat(New String() { Conversions.ToString(j), ",", Conversions.ToString(r_e(j).gravity_force), ",", Conversions.ToString(r_e(j).buoy_weight), ",", Conversions.ToString(r_e(j).unbuoy_weight), ",", Conversions.ToString(r_e(j).mass), ",", Conversions.ToString(r_e(j).WrodsInFluid), ",", Conversions.ToString(Math.Cos(r_e(j).inc)), ",", Conversions.ToString(r_e(j).rod_area), ",", Conversions.ToString(r_e(j).m_d), ",", Conversions.ToString(r_e(j).pos.z), ",", Conversions.ToString(r_e(j).inc * 57.29577951308238), ",", Conversions.ToString(r_e(j).hydrostat_psia_tbg) }) })
							j += 1
						End While
						j = p_s.num_rod_elements
						FileSystem.PrintLine(num41, New Object() { String.Concat(New String() { "pump,", Conversions.ToString(p_s.pump_weight_unbuoyed), ",", Conversions.ToString(p_s.pump_weight_buoyed), ",", Conversions.ToString(p_s.pump_weight_unbuoyed), ",", Conversions.ToString(p_s.pump_mass), ",", Conversions.ToString(p_s.pump_weight_buoyed), ",", Conversions.ToString(Math.Cos(r_e(j).inc)), ",", Conversions.ToString(p_s.pump_area), ",", Conversions.ToString(r_e(j).m_d), ",", Conversions.ToString(p_s.pump_pos_z), ",", Conversions.ToString(r_e(j).inc * 57.29577951308238), ",", Conversions.ToString(p_s.hydrostat_psia_pump) }) })
						FileSystem.PrintLine(num41, New Object() { "n,Fgrav,Wrf.z,Wr.z,mass,rstWf,cos(inc),Ar,MD,pos.z,incDeg,Phyd" })
						FileSystem.PrintLine(num41, New Object() { "check_buoyed_weight_in_calc_rod" })
						FileSystem.FileClose(New Integer() { num41 })
					End If
					If p_s.num_survey_points <= 2 Then
						RSWIN_DESC.rst.WrodsInFluid = wrodsInFluid
					End If
					Dim num43 As Integer = 1
					Dim num_rod_elements7 As Integer = p_s.num_rod_elements
					j = num43
					While j <= num_rod_elements7
						If r_e(j).tan.z < 1.0 Then
							Dim num44 As Double = r_e(j).mass * Math.Sqrt(1.0 - r_e(j).tan.z * r_e(j).tan.z)
							r_e(j).sfg.x = num44 * r_e(j).sfg.x
							r_e(j).sfg.y = num44 * r_e(j).sfg.y
							r_e(j).sfg.z = num44 * r_e(j).sfg.z
						Else
							r_e(j).sfg.x = 0.0
							r_e(j).sfg.y = 0.0
							r_e(j).sfg.z = 0.0
						End If
						j = j + 1
					End While
					t_t(p_s.num_tbg_tapers).hydrostat_psia_csg = (r_e(p_s.num_rod_elements).pos.z - p_s.liquid_level_TVD) * 0.43333333333333335 * p_s.liq_grav_csg + p_s.casing_pressure + 14.7
					p_s.anch_depth = p_s.anch_depth
					p_s.unanch_len = t_t(p_s.num_tbg_tapers).taper_depth - p_s.anch_depth
					Dim num45 As Integer = 1
					Dim num_tbg_tapers As Integer = p_s.num_tbg_tapers
					j = num45
					While j <= num_tbg_tapers
						If j = 1 Then
							t_t(1).taper_len = t_t(1).taper_depth
						Else
							' The following expression was wrapped in a unchecked-expression
							' The following expression was wrapped in a checked-expression
							t_t(j).taper_len = t_t(j).taper_depth - t_t(j - 1).taper_depth
						End If
						j += 1
					End While
					j = p_s.num_tbg_tapers
					While j >= 1

							t_t(j).tbg_area_id = 0.7853981633974483 * Math.Pow(t_t(j).tbg_id, 2.0)
							t_t(j).tbg_area_od = 0.7853981633974483 * Math.Pow(t_t(j).tbg_od, 2.0)
							t_t(j).tbg_area = t_t(j).tbg_area_od - t_t(j).tbg_area_id
							If p_s.unanch_len > t_t(j).taper_len Then
								p_s.unanch_len -= t_t(j).taper_len
								t_t(j).tbg_spring_con = t_t(j).tbg_modulus * t_t(j).tbg_area / t_t(j).taper_len
							ElseIf p_s.unanch_len > 0.01 Then
								t_t(j).tbg_spring_con = t_t(j).tbg_modulus * t_t(j).tbg_area / p_s.unanch_len
								p_s.unanch_len = 0.0
							Else
								t_t(j).tbg_spring_con = 1E+20
							End If

						j += -1
					End While
					p_s.tbg_spring_con = 0.0
					Dim num46 As Integer = 1
					Dim num_tbg_tapers2 As Integer = p_s.num_tbg_tapers
					j = num46
					While j <= num_tbg_tapers2

							p_s.tbg_spring_con += 1.0 / t_t(j).tbg_spring_con

						j += 1
					End While
					p_s.tbg_spring_con = 1.0 / p_s.tbg_spring_con
					j = p_s.num_tbg_tapers
					k = p_s.num_rod_elements
					p_s.tbg_force_max = t_t(j).tbg_area_id * r_e(k).hydrostat_psia_tbg - t_t(j).tbg_area_od * t_t(j).hydrostat_psia_csg
					p_s.tbg_force_min = (t_t(j).tbg_area_id - t_t(j).tbg_area_od) * t_t(j).hydrostat_psia_csg
					p_s.tbg_force_max = t_t(j).tbg_area_id * r_e(k).hydrostat_psia_tbg - t_t(j).tbg_area_od * t_t(j).hydrostat_psia_csg
					p_s.tbg_force_min = (t_t(j).tbg_area_id - p_s.pump_area) * r_e(k).hydrostat_psia_tbg - (t_t(j).tbg_area_od - p_s.pump_area) * t_t(j).hydrostat_psia_csg
					p_s.tbg_force_min = (t_t(j).tbg_area_id - p_s.pump_area) * r_e(k).hydrostat_psia_tbg - (t_t(j).tbg_area_od - t_t(j).tbg_area_id) * t_t(j).hydrostat_psia_csg
					p_s.tbg_stretch_max = (p_s.tbg_force_max - p_s.tbg_force_min) / p_s.tbg_spring_con
					Dim num47 As Integer = 1
					Dim num_rod_tapers3 As Integer = p_s.num_rod_tapers
					j = num47
					While j <= num_rod_tapers3
						If j = 1 Then
							r_t(1).taper_len = r_t(1).taper_depth
						Else
							' The following expression was wrapped in a unchecked-expression
							' The following expression was wrapped in a checked-expression
							r_t(j).taper_len = r_t(j).taper_depth - r_t(j - 1).taper_depth
						End If
						j += 1
					End While
					j = p_s.num_rod_tapers
					While j >= 1
						' The following expression was wrapped in a unchecked-expression
						r_t(j).rod_spring_con = r_t(j).rod_modulus * r_t(j).rod_area / r_t(j).taper_len
						j += -1
					End While
					p_s.rod_spring_con = 0.0
					Dim num48 As Integer = 1
					Dim num_rod_tapers4 As Integer = p_s.num_rod_tapers
					j = num48
					While j <= num_rod_tapers4

							p_s.rod_spring_con += 1.0 / r_t(j).rod_spring_con

						j += 1
					End While
					p_s.rod_spring_con = 1.0 / p_s.rod_spring_con
					p_s.rod_stretch_min = -p_s.min_pump_load / p_s.rod_spring_con
					p_s.rod_stretch_max = p_s.pump_fluid_load / p_s.rod_spring_con
					p_s.rod_stretch_range = p_s.rod_stretch_max - p_s.rod_stretch_min
					p_s.pump_spring_con = 2.0 * r_t(p_s.num_rod_tapers).rod_modulus * r_t(p_s.num_rod_tapers).rod_area / r_t(p_s.num_rod_tapers).rod_elem_len
					Dim num71 As Integer
					If False And num2 = 1 Then
						p_s.iostat = p_s.iostat
					Else
						Dim num49 As Integer = 1
						If num49 = 1 Then
							j = 0
							r_e(j).force_buoy = (r_e(j + 1).rod_area - p_s.p_r_area) * r_e(j).hydrostat_psia_tbg
							Dim num50 As Integer = 1
							Dim num51 As Integer = p_s.num_rod_elements - 1
							j = num50
							While j <= num51
								' The following expression was wrapped in a unchecked-expression
								' The following expression was wrapped in a checked-expression
								r_e(j).force_buoy = (r_e(j + 1).rod_area - r_e(j).rod_area) * r_e(j).hydrostat_psia_tbg
								j += 1
							End While
							j = p_s.num_rod_elements
							r_e(j).force_buoy = (0.0 - r_e(j).rod_area) * r_e(j).hydrostat_psia_tbg
							j = p_s.num_rod_elements
							p_s.force_buoy_rod_bot = r_e(j).force_buoy
							r_e(j).force_buoy_cum = r_e(j).force_buoy
							j = p_s.num_rod_elements - 1
							While j >= 1
								' The following expression was wrapped in a unchecked-expression
								' The following expression was wrapped in a checked-expression
								r_e(j).force_buoy_cum = r_e(j + 1).force_buoy_cum + r_e(j).force_buoy
								j += -1
							End While
							j = 0
							r_e(j).force_buoy_cum = r_e(j + 1).force_buoy_cum + r_e(j).force_buoy
						Else
							Dim num52 As Integer = 1
							Dim num_rod_elements8 As Integer = p_s.num_rod_elements
							j = num52
							While j <= num_rod_elements8
								r_e(j).force_buoy = 0.0
								r_e(j).force_buoy_cum = 0.0
								j += 1
							End While
						End If
						If num49 = 1 Then
							j = 0
							k = 0
							r_t(k).force_buoy_cum = r_e(j).force_buoy_cum
							Dim num53 As Integer = 1
							Dim num54 As Integer = 1
							Dim num_rod_tapers5 As Integer = p_s.num_rod_tapers
							k = num54
							While k <= num_rod_tapers5
								Dim num55 As Integer = num53
								Dim num_rod_elements9 As Integer = p_s.num_rod_elements
								j = num55
								While j <= num_rod_elements9
									If r_t(k).taper_depth <= r_e(j).m_d Then
										r_t(k).force_buoy = r_e(j).force_buoy
										r_t(k).force_buoy_cum = r_e(j).force_buoy_cum
										r_t(k).hydrostat_psia_tbg = r_e(j).hydrostat_psia_tbg
										r_t(k).inc = r_e(j).inc
										r_t(k).taper_tvd = r_e(j).pos.z
										num53 = j
										j = p_s.num_rod_elements
									End If
									j += 1
								End While
								k += 1
							End While
						Else
							Dim num56 As Integer = 1
							Dim num_rod_tapers6 As Integer = p_s.num_rod_tapers
							k = num56
							While k <= num_rod_tapers6
								r_t(k).force_buoy = 0.0
								r_t(k).force_buoy_cum = 0.0
								k += 1
							End While
						End If
					End If
					Dim num57 As Integer = 1
					Dim num_rod_elements10 As Integer = p_s.num_rod_elements
					j = num57
					While j <= num_rod_elements10
						r_e(j).force_buoy_PAlocal = r_e(j).force_buoy
						r_e(j).force_buoy_PAlocal_cum = r_e(j).force_buoy_cum
						j += 1
					End While
					j = p_s.num_rod_elements
					p_s.force_buoy_rod_bot_PAlocal = r_e(j).force_buoy
					Dim num58 As Integer = 0
					If num58 = 1 Then
						k = 1
						Dim num59 As Integer = 1
						Dim num_rod_elements11 As Integer = p_s.num_rod_elements
						j = num59
						While j <= num_rod_elements11
							r_e(j).force_buoy_PAdistrib = r_e(j).force_buoy_PAlocal / r_t(k).num_rod_elem
							If r_e(j).m_d < r_t(k).taper_depth Then
								k += 1
							End If
							j += 1
						End While
						j = p_s.num_rod_elements
						p_s.force_buoy_rod_bot_PAdistrib = r_e(j).force_buoy_PAdistrib
						r_e(j).force_buoy_PAdistrib_cum = r_e(j).force_buoy_PAdistrib
						j = p_s.num_rod_elements - 1
						While j >= 1
							' The following expression was wrapped in a unchecked-expression
							' The following expression was wrapped in a checked-expression
							r_e(j).force_buoy_cum = r_e(j + 1).force_buoy_PAdistrib_cum + r_e(j).force_buoy_PAdistrib
							j += -1
						End While
					ElseIf num58 = 2 Then
						k = 1
						Dim num60 As Integer = 1
						Dim num_rod_elements12 As Integer = p_s.num_rod_elements
						j = num60
						While j <= num_rod_elements12
							If r_e(j).m_d < r_t(k).taper_depth Then
								r_e(j).rod_density = r_t(k).rod_density
								k += 1
							End If
							j += 1
						End While
						Dim num61 As Integer = 1
						Dim num_rod_elements13 As Integer = p_s.num_rod_elements
						j = num61
						While j <= num_rod_elements13
							' The following expression was wrapped in a unchecked-expression
							r_e(j).force_buoy_Archimedes = r_e(j).rod_area * r_e(j).length * (r_e(j).rod_density - p_s.liquid_gravity * 62.4)
							j += 1
						End While
						j = p_s.num_rod_elements
						p_s.force_buoy_rod_bot_Archimedes = r_e(j).force_buoy_Archimedes
						r_e(j).force_buoy_Archimedes_cum = r_e(j).force_buoy_Archimedes
						j = p_s.num_rod_elements - 1
						While j >= 1
							' The following expression was wrapped in a unchecked-expression
							' The following expression was wrapped in a checked-expression
							r_e(j).force_buoy_Archimedes_cum = r_e(j + 1).force_buoy_Archimedes_cum + r_e(j).force_buoy_Archimedes
							j += -1
						End While
						Dim text As String = "c:\TempRSWINFiles\Fb_DisplacVol_Archimedes.csv"
						Dim num62 As Integer
						If FILEUTIL.FileExists(text) Then
							FileSystem.FileClose(New Integer() { num62 })
							FileSystem.Kill("c:\TempRSWINFiles\Fb_DisplacVol_Archimedes.csv")
						End If
						num62 = FileSystem.FreeFile()
						FileSystem.FileOpen(num62, "c:\TempRSWINFiles\Fb_DisplacVol_Archimedes.csv", OpenMode.Output, OpenAccess.[Default], OpenShare.[Default], -1)
						FileSystem.PrintLine(num62, New Object() { "n,i,mdEl,mdTap,Ar,Lr,DenR,DenW,SgLiq,FbArch" })
						k = 1
						Dim num63 As Integer = 1
						Dim num_rod_elements14 As Integer = p_s.num_rod_elements
						j = num63
						While j <= num_rod_elements14
							FileSystem.PrintLine(num62, New Object() { "n,i,mdEl,mdTap,Ar,Lr,DenR,DenW,SgLiq,FbArch" })
							FileSystem.PrintLine(num62, New Object() { String.Concat(New String() { Conversions.ToString(p_s.pump_weight_unbuoyed), ",", Conversions.ToString(p_s.pump_weight_buoyed), ",", Conversions.ToString(p_s.pump_weight_unbuoyed), ",", Conversions.ToString(p_s.pump_mass), ",", Conversions.ToString(p_s.pump_weight_buoyed), ",", Conversions.ToString(Math.Cos(r_e(j).inc)), ",", Conversions.ToString(p_s.pump_area), ",", Conversions.ToString(r_e(j).m_d), ",", Conversions.ToString(p_s.pump_pos_z), ",", Conversions.ToString(r_e(j).inc * 57.29577951308238), ",", Conversions.ToString(p_s.hydrostat_psia_pump) }) })
							If r_e(j).m_d < r_t(k).taper_depth Then
								k += 1
							End If
							j += 1
						End While
						FileSystem.FileClose(New Integer() { num62 })
					End If
					Dim num64 As Integer = 0
					If num64 = 1 Then
						Dim num65 As Integer = 1
						Dim num_rod_tapers7 As Integer = p_s.num_rod_tapers
						j = num65
						While j <= num_rod_tapers7

								Dim num66 As Double = 0.006944444444444444 * r_t(j).rod_area * r_t(j).rod_density
								Dim num67 As Double = CDbl(RSWIN_DESC.rst.Sections(j).RodWeight)
								Dim num68 As Single = 0.0001F
								If Math.Abs(num66 - num67) > CDbl(num68) Then
									p_s.iostat = p_s.iostat
								End If

							j += 1
						End While
					End If
					k = 1
					Dim num69 As Integer = 1
					Dim num_rod_elements15 As Integer = p_s.num_rod_elements
					j = num69
					While j <= num_rod_elements15
						r_t(k).pos.z = r_e(j).pos.z
						If r_e(j).m_d >= r_t(k).taper_depth Then
							k += 1
						End If
						j += 1
					End While
					Dim num70 As Integer = 1
					Dim num_rod_tapers8 As Integer = p_s.num_rod_tapers
					j = num70
					While j <= num_rod_tapers8

							Dim num34 As Single
							If r_t(j).rod_density <> CDbl(RSWIN_DESC.rst.Sections(j).RodDensity) And RSWIN_DESC.SETUP_UseJohnsFix Then
								num34 = CSng((0.7853981633974483 * Math.Pow(r_t(j).rod_od / 12.0, 2.0) * r_t(j).rod_density))
							Else
								num34 = RSWIN_DESC.rst.Sections(j).RodWeight
							End If
							r_t(j).mass = r_t(j).taper_len * CDbl(num34) * 32.17405 / 32.17405
							r_t(j).unbuoy_weight = r_t(j).mass * 32.17405 / 32.17405
							If j = 1 Then
								Dim d As Double = (r_e(1).inc + r_t(j).inc) / 2.0
								r_t(j).unbuoy_weight = r_t(j).unbuoy_weight * Math.Cos(d)
							Else
								' The following expression was wrapped in a checked-expression
								Dim d As Double = (r_t(j - 1).inc + r_t(j).inc) / 2.0
								r_t(j).unbuoy_weight = r_t(j).unbuoy_weight * Math.Cos(d)
							End If
							If j < p_s.num_rod_tapers Then
								' The following expression was wrapped in a checked-expression
								r_t(j).buoy_weight = r_t(j).unbuoy_weight + (p_s.liquid_gravity * 0.43333333333333335 * r_t(j).pos.z + p_s.tubing_pressure + 14.7) * (r_t(j + 1).rod_area - r_t(j).rod_area)
							Else
								r_t(j).buoy_weight = r_t(j).unbuoy_weight + (p_s.liquid_gravity * 0.43333333333333335 * r_t(j).pos.z + p_s.tubing_pressure + 14.7) * (0.0 - r_t(j).rod_area)
							End If

						j += 1
					End While
					num71 = 0
					If num71 = 1 Then
						Dim text As String = "c:\TempRSWINFiles\in2ft2.csv"
						Dim num72 As Integer
						If FILEUTIL.FileExists(text) Then
							FileSystem.FileClose(New Integer() { num72 })
							FileSystem.Kill("c:\TempRSWINFiles\in2ft2.csv")
						End If
						num72 = FileSystem.FreeFile()
						FileSystem.FileOpen(num72, "c:\TempRSWINFiles\in2ft2.csv", OpenMode.Output, OpenAccess.[Default], OpenShare.[Default], -1)
						FileSystem.PrintLine(num72, New Object() { String.Concat(New String() { "in2/ft2=,", Conversions.ToString(144.0), ",gc=,", Conversions.ToString(32.17405), ",g=,", Conversions.ToString(32.17405), ",LiqGrav=,", Conversions.ToString(p_s.liquid_gravity), ",psi/ft=,", Conversions.ToString(0.43333333333333335), ",Ptbg=,", Conversions.ToString(p_s.tubing_pressure), ",Patm=,", Conversions.ToString(14.7) }) })
						FileSystem.PrintLine(num72, New Object() { "verify_buoyed_&_unbuoyed_taper_weights" })
						FileSystem.PrintLine(num72, New Object() { "n,tapLen,Ar,den,re.lb/ft,rst.lb/ft,dif_lb/ft,mass,inc,cos(inc),pos.z,~Wr.z,Phyd,Fb,~Wrf.z,cumFb" })
						j = 0
						FileSystem.PrintLine(num72, New Object() { String.Concat(New String() { "pr,", Conversions.ToString(p_s.p_r_MD), ",", Conversions.ToString(p_s.p_r_area), ",", Conversions.ToString(p_s.p_r_density), ",", Conversions.ToString(p_s.p_r_density / 144.0 * 32.17405 / 32.17405), ",", Conversions.ToString(p_s.p_r_density / 144.0 * 32.17405 / 32.17405), ",0,", Conversions.ToString(p_s.p_r_mass), ",", Conversions.ToString(r_e(1).inc), ",", Conversions.ToString(Math.Cos(r_e(1).inc)), ",", Conversions.ToString(p_s.p_r_pos_z), ",", Conversions.ToString(p_s.p_r_weight_unbuoyed), ",", Conversions.ToString(p_s.p_r_psia_tbg), ",", Conversions.ToString(p_s.p_r_psia_tbg * (r_e(1).rod_area - p_s.p_r_area)), ",", Conversions.ToString(p_s.p_r_weight_buoyed), ",", Conversions.ToString(r_t(j).force_buoy_cum) }) })
						j = 1
						Dim num73 As Double = (r_e(1).inc + r_e(1).inc) / 2.0
						FileSystem.PrintLine(num72, New Object() { String.Concat(New String() { Conversions.ToString(j), ",", Conversions.ToString(r_t(j).taper_len), ",", Conversions.ToString(r_t(j).rod_area), ",", Conversions.ToString(r_t(j).rod_density), ",", Conversions.ToString(r_t(j).rod_area * r_t(j).rod_density / 144.0), ",", Conversions.ToString(RSWIN_DESC.rst.Sections(j).RodWeight), ",", Conversions.ToString(r_t(j).rod_area * r_t(j).rod_density / 144.0 - CDbl(RSWIN_DESC.rst.Sections(j).RodWeight)), ",", Conversions.ToString(r_t(j).mass), ",", Conversions.ToString(num73), ",", Conversions.ToString(Math.Cos(num73)), ",", Conversions.ToString(r_t(j).pos.z), ",", Conversions.ToString(r_t(j).unbuoy_weight), ",", Conversions.ToString(p_s.liquid_gravity * 0.43333333333333335 * r_t(j).pos.z + p_s.tubing_pressure + 14.7), ",", Conversions.ToString(r_t(j).hydrostat_psia_tbg * (r_t(j + 1).rod_area - r_t(j).rod_area)), ",", Conversions.ToString(r_t(j).buoy_weight), ",", Conversions.ToString(r_t(j).force_buoy_cum) }) })
						Dim num74 As Integer = 2
						Dim num75 As Integer = p_s.num_rod_tapers - 1
						j = num74
						While j <= num75

								' The following expression was wrapped in a checked-expression
								num73 = (r_t(j - 1).inc + r_t(j).inc) / 2.0
								FileSystem.PrintLine(num72, New Object() { String.Concat(New String() { Conversions.ToString(j), ",", Conversions.ToString(r_t(j).taper_len), ",", Conversions.ToString(r_t(j).rod_area), ",", Conversions.ToString(r_t(j).rod_density), ",", Conversions.ToString(r_t(j).rod_area * r_t(j).rod_density / 144.0), ",", Conversions.ToString(RSWIN_DESC.rst.Sections(j).RodWeight), ",", Conversions.ToString(r_t(j).rod_area * r_t(j).rod_density / 144.0 - CDbl(RSWIN_DESC.rst.Sections(j).RodWeight)), ",", Conversions.ToString(r_t(j).mass), ",", Conversions.ToString(num73), ",", Conversions.ToString(Math.Cos(num73)), ",", Conversions.ToString(r_t(j).pos.z), ",", Conversions.ToString(r_t(j).unbuoy_weight), ",", Conversions.ToString(p_s.liquid_gravity * 0.43333333333333335 * r_t(j).pos.z + p_s.tubing_pressure + 14.7), ",", Conversions.ToString(r_t(j).hydrostat_psia_tbg * (r_t(j + 1).rod_area - r_t(j).rod_area)), ",", Conversions.ToString(r_t(j).buoy_weight), ",", Conversions.ToString(r_t(j).force_buoy_cum) }) })

							j += 1
						End While
						j = p_s.num_rod_tapers
						num73 = (r_t(j - 1).inc + r_t(j).inc) / 2.0
						FileSystem.PrintLine(num72, New Object() { String.Concat(New String() { Conversions.ToString(j), ",", Conversions.ToString(r_t(j).taper_len), ",", Conversions.ToString(r_t(j).rod_area), ",", Conversions.ToString(r_t(j).rod_density), ",", Conversions.ToString(r_t(j).rod_area * r_t(j).rod_density / 144.0), ",", Conversions.ToString(RSWIN_DESC.rst.Sections(j).RodWeight), ",", Conversions.ToString(r_t(j).rod_area * r_t(j).rod_density / 144.0 - CDbl(RSWIN_DESC.rst.Sections(j).RodWeight)), ",", Conversions.ToString(r_t(j).mass), ",", Conversions.ToString(num73), ",", Conversions.ToString(Math.Cos(num73)), ",", Conversions.ToString(r_t(j).pos.z), ",", Conversions.ToString(r_t(j).unbuoy_weight), ",", Conversions.ToString(p_s.liquid_gravity * 0.43333333333333335 * r_t(j).pos.z + p_s.tubing_pressure + 14.7), ",", Conversions.ToString(r_t(j).hydrostat_psia_tbg * (0.0 - r_t(j).rod_area)), ",", Conversions.ToString(r_t(j).buoy_weight), ",", Conversions.ToString(r_t(j).force_buoy_cum) }) })
						k = p_s.num_rod_tapers
						j = p_s.num_rod_elements
						FileSystem.PrintLine(num72, New Object() { String.Concat(New String() { "pump,", Conversions.ToString(p_s.pump_barrel_len), ",", Conversions.ToString(p_s.pump_area), ",", Conversions.ToString(p_s.pump_density), ",", Conversions.ToString(p_s.pump_density / 144.0 * 32.17405 / 32.17405), ",n.a.,", Conversions.ToString(r_t(k).rod_area * r_t(k).rod_density / 144.0 - CDbl(RSWIN_DESC.rst.Sections(k).RodWeight)), ",", Conversions.ToString(p_s.pump_mass), ",", Conversions.ToString(r_e(j).inc), ",", Conversions.ToString(Math.Cos(r_e(j).inc)), ",", Conversions.ToString(r_e(j).pos.z + p_s.pump_barrel_len / 2.0), ",", Conversions.ToString(p_s.pump_weight_unbuoyed), ",", Conversions.ToString(p_s.hydrostat_psia_pump), ",", Conversions.ToString(p_s.hydrostat_psia_pump * p_s.pump_area), ",", Conversions.ToString(p_s.pump_weight_buoyed) }) })
						FileSystem.PrintLine(num72, New Object() { "n,tapLen,Ar,den,re.lb/ft,rst.lb/ft,dif_lb/ft,mass,inc,cos(inc),pos.z,~Wr.z,Phyd,Fb,~Wrf.z,cumFb" })
						FileSystem.PrintLine(num72, New Object() { "verify_buoyed_&_unbuoyed_taper_weights" })
						FileSystem.FileClose(New Integer() { num72 })
					End If
				End If
			Catch ex As Exception
				Interaction.MsgBox("Error: in calc_rod " + Information.Err().Description, MsgBoxStyle.OKOnly, Nothing)
			End Try
		End Sub

		Public Sub thomas(ByRef a As Double(), ByRef b As Double(), ByRef c As Double(), ByRef d As Double(), ByRef x As Double(), ByRef w As Double(), ByRef g As Double(), n As Integer)
			w(1) = b(1)
			g(1) = d(1) / w(1)
			For i As Integer = 2 To n

					' The following expression was wrapped in a checked-expression
					' The following expression was wrapped in a checked-expression
					w(i) = b(i) - a(i) * c(i - 1) / w(i - 1)
					g(i) = (d(i) - a(i) * g(i - 1)) / w(i)

			Next
			x(n) = g(n)
			For i As Integer = n - 1 To 1 Step -1
				' The following expression was wrapped in a unchecked-expression
				' The following expression was wrapped in a checked-expression
				x(i) = g(i) - c(i) * x(i + 1) / w(i)
			Next
		End Sub

		Public Sub calc_sim(ByRef f_e As TEImpred.fluid_element_data_type(), ByRef l_u As TEImpred.lookup_table_data_type(), ByRef m_c As TEImpred.motor_characteristic_data_type(), ByRef p_s As TEImpred.parameter_structure_type, ByRef r_e As TEImpred.rod_element_data_type(), ByRef t_s As TEImpred.timestep_data_type(), ByRef r_t As TEImpred.rod_taper_data_type(), ByRef t_t As TEImpred.tbg_taper_data_type())
			' The following expression was wrapped in a checked-statement
			Dim num3 As Integer
			Dim num139 As Integer
			Dim obj62 As Object
			Try
				Dim num As Integer = 0
				Dim num2 As Integer
				If num = 1 Then
					Dim text As String = "c:\TempRSWINFiles\did_con_to_vari_happen.csv"
					If FILEUTIL.FileExists(text) Then
						FileSystem.FileClose(New Integer() { num2 })
						FileSystem.Kill("c:\TempRSWINFiles\did_con_to_vari_happen.csv")
					End If
					num2 = FileSystem.FreeFile()
					FileSystem.FileOpen(num2, "c:\TempRSWINFiles\did_con_to_vari_happen.csv", OpenMode.Output, OpenAccess.[Default], OpenShare.[Default], -1)
					FileSystem.PrintLine(num2, New Object() { "i_cy,i_st,|p_s.vel_mot-t_s.vel_mot|,tol_var_spm,p_s.vel_mot,t_s.vel_mot,t_s.vel_cr,ratio_tot" })
				End If
				Dim flag As Boolean = True
				flag = flag
				Dim pumpDepthTVD As Single = 0F
				Dim flag2 As Boolean = False
				Dim flag3 As Boolean = True
				Dim flag4 As Boolean = True
				ProjectData.ClearProjectError()
				num3 = 2
				p_s.iostat = 0
				Dim num4 As Integer = 1 + 2 * p_s.num_rod_elements
				Dim array As Double() = New Double(num4 + 1 - 1) {}
				Dim array2 As Double() = New Double(num4 + 1 - 1) {}
				Dim array3 As Double() = New Double(num4 + 1 - 1) {}
				Dim array4 As Double() = New Double(num4 + 1 - 1) {}
				Dim array5 As Double() = New Double(num4 + 1 - 1) {}
				Dim array6 As Double() = New Double(num4 + 1 - 1) {}
				Dim array7 As Double() = New Double(num4 + 1 - 1) {}
				Dim array8 As Double() = New Double(3) {}
				Dim array9 As Double() = New Double(3) {}
				Dim num5 As Long = 31000L
				Dim num6 As Integer = 0
				p_s.max_p_r_force = -9999990.0
				p_s.min_p_r_force = 99999990.0
				p_s.max_pump_force = -9999990.0
				p_s.min_pump_force = 99999990.0
				p_s.max_d_h_force = -9999990.0
				p_s.min_d_h_force = 99999990.0
				Dim obj As Object
				Dim obj2 As Object
				If ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj, 3, num4 - 2, 2, obj2, obj) Then
					Do
						r_e(Conversions.ToInteger(Conversion.Int(Operators.DivideObject(obj, 2)))).max_force = -9999990.0
						r_e(Conversions.ToInteger(Conversion.Int(Operators.DivideObject(obj, 2)))).min_force = 99999990.0
						r_e(Conversions.ToInteger(Conversion.Int(Operators.DivideObject(obj, 2)))).max_force_unbuoyed = -9999990.0
						r_e(Conversions.ToInteger(Conversion.Int(Operators.DivideObject(obj, 2)))).min_force_unbuoyed = 99999990.0
					Loop While ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj, obj2, obj)
				End If
				Dim num7 As Integer = 1
				p_s.pump_psia_as = r_e(p_s.num_rod_elements).hydrostat_psia_tbg
				p_s.pump_psia_bs = t_t(p_s.num_tbg_tapers).hydrostat_psia_csg
				Dim num8 As Integer = 0
				p_s.SV_pos_init = 0.0
				Dim num9 As Integer
				Dim num10 As Double
				Dim num11 As Double

					p_s.p_vol_init = p_s.TV_clear_vol + p_s.SV_clear_vol + (p_s.TV_pos_init - p_s.SV_pos_init) * p_s.pump_area
					num9 = 0
					num10 = 0.0
					p_s.SV_leak_coeff_init = 0.0
					p_s.SV_leak_percent = 0.0
					Dim obj3 As Object
					If ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj, 1, p_s.max_timesteps, 1, obj3, obj) Then
						Do
							t_s(Conversions.ToInteger(obj)).SV_leak_coeff_max = p_s.SV_leak_coeff_init
							t_s(Conversions.ToInteger(obj)).SV_leak_coeff = t_s(Conversions.ToInteger(obj)).SV_leak_coeff_max * p_s.SV_leak_percent / 100.0
						Loop While ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj, obj3, obj)
					End If
					Dim x As Double = 10.0
					Dim obj4 As Object = 1.0 * CDbl(p_s.num_timesteps)
					num11 = Math.Pow(x, CDbl((-CShort(Math.Round(Me.Log10(obj4) + 3.0)))))
					p_s.vari_spm = 0

				If p_s.mot_pts_flag = 6 Or p_s.mot_pts_flag = 11 Or p_s.mot_pts_flag = 20 Then
					p_s.vari_spm = 1
					If p_s.num_cycles <= 2 Then
						p_s.num_cycles += 1
						p_s.num_cycles += 2
						p_s.num_cycles += 3
					End If
				End If
				If p_s.fluid_solution = 1 Then
					p_s.num_cycles += 1
				ElseIf p_s.fluid_solution = 0 Then
					p_s.num_cycles += 1
				End If
				p_s.timestep_avg = p_s.timestep_length
				Dim num12 As Double
				Dim pump_psia_as As Double
				Dim pump_psia_as2 As Double
				Dim num13 As Double
				Dim num14 As Double
				Dim tbg_force_max As Double
				Dim num15 As Double
				Dim num18 As Integer
				Dim num19 As Integer
				Dim num20 As Integer
				Dim num22 As Integer
				Dim num23 As Double
				Dim pump_spring_con As Double
				Dim num24 As Double
				Dim num25 As Double
				Dim num26 As Integer
				Dim num27 As Integer
				Dim flag5 As Boolean

					Dim obj5 As Object
					If ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj, 1, p_s.max_timesteps, 1, obj5, obj) Then
						Do
							t_s(Conversions.ToInteger(obj)).timestep_var = Convert.ToDouble(RuntimeHelpers.GetObjectValue(obj)) * p_s.timestep_length
						Loop While ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj, obj5, obj)
					End If
					num12 = 0.0
					Dim obj6 As Object
					If ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj, 1, p_s.max_timesteps, 1, obj6, obj) Then
						Do
							t_s(Conversions.ToInteger(obj)).displacement_N_n = 0.0
						Loop While ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj, obj6, obj)
					End If
					Dim obj7 As Object
					If ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj, 1, p_s.max_timesteps, 1, obj7, obj) Then
						Do
							t_s(Conversions.ToInteger(obj)).rod_bottom_velo = 0.0
						Loop While ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj, obj7, obj)
					End If
					pump_psia_as = p_s.pump_psia_as
					Dim obj8 As Object
					If ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj, 1, p_s.max_timesteps, 1, obj8, obj) Then
						Do
							t_s(Conversions.ToInteger(obj)).pump_psia_p = p_s.pump_psia_as
						Loop While ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj, obj8, obj)
					End If
					pump_psia_as2 = p_s.pump_psia_as
					Dim obj9 As Object
					If ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj, 1, p_s.max_timesteps, 1, obj9, obj) Then
						Do
							t_s(Conversions.ToInteger(obj)).pump_psia_a = p_s.pump_psia_as
						Loop While ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj, obj9, obj)
					End If
					num13 = -p_s.pump_psia_as * r_t(p_s.num_rod_tapers).rod_area
					num13 = -p_s.pump_psia_as * r_t(p_s.num_rod_tapers).rod_area + p_s.pump_psia_as * p_s.pump_area - p_s.pump_psia_as * p_s.pump_area
					num13 += p_s.pump_weight_buoyed
					num13 -= p_s.pump_weight_buoyed
					Dim obj10 As Object
					If ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj, 1, p_s.max_timesteps, 1, obj10, obj) Then
						Do
							t_s(Conversions.ToInteger(obj)).pump_force = -p_s.pump_psia_as * r_t(p_s.num_rod_tapers).rod_area
							t_s(Conversions.ToInteger(obj)).pump_force = -p_s.pump_psia_as * r_t(p_s.num_rod_tapers).rod_area + p_s.pump_psia_as * p_s.pump_area - p_s.pump_psia_as * p_s.pump_area
						Loop While ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj, obj10, obj)
					End If
					num14 = -p_s.pump_psia_as * r_t(p_s.num_rod_tapers).rod_area / p_s.pump_spring_con
					num14 = -num14
					Dim obj11 As Object
					If ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj, 1, p_s.max_timesteps, 1, obj11, obj) Then
						Do
							t_s(Conversions.ToInteger(obj)).pump_displacement = -p_s.pump_psia_as * r_t(p_s.num_rod_tapers).rod_area / p_s.pump_spring_con
							t_s(Conversions.ToInteger(obj)).pump_displacement = -t_s(Conversions.ToInteger(obj)).pump_displacement
						Loop While ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj, obj11, obj)
					End If
					Dim obj12 As Object
					If ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj, 1, p_s.max_timesteps, 1, obj12, obj) Then
						Do
							t_s(Conversions.ToInteger(obj)).pump_velocity = 0.0
						Loop While ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj, obj12, obj)
					End If
					tbg_force_max = p_s.tbg_force_max
					Dim obj13 As Object
					If ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj, 1, p_s.max_timesteps, 1, obj13, obj) Then
						Do
							t_s(Conversions.ToInteger(obj)).tbg_force = p_s.tbg_force_max
						Loop While ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj, obj13, obj)
					End If
					num15 = tbg_force_max / p_s.tbg_spring_con
					num15 = -num15
					Dim obj14 As Object
					If ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj, 1, p_s.max_timesteps, 1, obj14, obj) Then
						Do
							t_s(Conversions.ToInteger(obj)).tbg_position = tbg_force_max / p_s.tbg_spring_con
							t_s(Conversions.ToInteger(obj)).tbg_position = -t_s(Conversions.ToInteger(obj)).tbg_position
						Loop While ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj, obj14, obj)
					End If
					Dim obj15 As Object
					If ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj, 1, p_s.max_timesteps, 1, obj15, obj) Then
						Do
							t_s(Conversions.ToInteger(obj)).tbg_velo = 0.0
						Loop While ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj, obj15, obj)
					End If
					Dim obj16 As Object
					If ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj, 1, p_s.max_timesteps, 1, obj16, obj) Then
						Do
							t_s(Conversions.ToInteger(obj)).SV_drag_force = 0.0
						Loop While ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj, obj16, obj)
					End If
					Dim obj17 As Object
					If ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj, 1, p_s.max_timesteps, 1, obj17, obj) Then
						Do
							t_s(Conversions.ToInteger(obj)).TV_drag_force = 0.0
						Loop While ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj, obj17, obj)
					End If
					Dim obj18 As Object
					If ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj, 1, p_s.max_timesteps, 1, obj18, obj) Then
						Do
							t_s(Conversions.ToInteger(obj)).bp_drag_force = 0.0
						Loop While ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj, obj18, obj)
					End If
					Dim obj19 As Object
					If ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj, 1, p_s.max_timesteps, 1, obj19, obj) Then
						Do
							t_s(Conversions.ToInteger(obj)).p_drag_force = 0.0
						Loop While ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj, obj19, obj)
					End If
					Application.DoEvents()
					Dim num16 As Double = p_s.delta_theta / p_s.timestep_length * p_s.ratio_gb * p_s.ratio_vb
					Dim obj20 As Object
					If ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj, 1, p_s.max_timesteps, 1, obj20, obj) Then
						Do
							t_s(Conversions.ToInteger(obj)).vel_mot = 0.0
						Loop While ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj, obj20, obj)
					End If
					Dim num17 As Double = t_s(1).crank_angle - 2.0 * p_s.delta_theta
					num18 = 0
					num19 = 0
					num20 = 0
					Dim num21 As Integer = 0
					num22 = 0
					Dim obj21 As Object
					If ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj, 1, p_s.num_rod_elements, 1, obj21, obj) Then
						Do
							If(r_e(Conversions.ToInteger(obj)).tan.z < 1.0 Or r_e(Conversions.ToInteger(obj)).dog > 0.0) AndAlso r_e(Conversions.ToInteger(obj)).friction_coef > 0.0 Then
								num22 = 1
							End If
						Loop While ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj, obj21, obj)
					End If
					obj = p_s.num_rod_elements
					r_e(Conversions.ToInteger(obj)).old_velocity = 0.0
					r_e(Conversions.ToInteger(obj)).old_force = 0.0
					r_e(Conversions.ToInteger(obj)).max_sf_total = 0.0
					Dim obj22 As Object
					If ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj, p_s.num_rod_elements - 1, 1, -1, obj22, obj) Then
						Do
							r_e(Conversions.ToInteger(obj)).old_velocity = 0.0
							r_e(Conversions.ToInteger(obj)).old_force = r_e(Conversions.ToInteger(Operators.AddObject(obj, 1))).old_force + r_e(Conversions.ToInteger(Operators.AddObject(obj, 1))).gravity_force
							r_e(Conversions.ToInteger(obj)).max_sf_total = 0.0
						Loop While ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj, obj22, obj)
					End If
					Dim obj23 As Object
					If ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj, 2, num4 - 1, 2, obj23, obj) Then
						Do
							array(Conversions.ToInteger(obj)) = -1.0
							array3(Conversions.ToInteger(obj)) = 1.0
						Loop While ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj, obj23, obj)
					End If
					Application.DoEvents()
					Dim obj24 As Object
					If ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj, 3, num4 - 2, 2, obj24, obj) Then
						Do
							array(Conversions.ToInteger(obj)) = -1.0
							array2(Conversions.ToInteger(obj)) = r_e(Conversions.ToInteger(Conversion.Int(Operators.DivideObject(obj, 2)))).length / (p_s.timestep_length * r_e(Conversions.ToInteger(Conversion.Int(Operators.DivideObject(obj, 2)))).ea)
							array3(Conversions.ToInteger(obj)) = 1.0
						Loop While ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj, obj24, obj)
					End If
					num23 = 2.0 * r_t(1).rod_modulus * r_t(1).rod_area / r_t(1).rod_elem_len
					pump_spring_con = p_s.pump_spring_con
					Me.displacement_1_n = -(r_e(1).old_force + r_e(1).gravity_force) / num23
					num20 = 1
					num24 = 0.0
					num25 = 0.0
					p_s.tbg_force = p_s.tbg_spring_con * p_s.tbg_stretch_max
					p_s.num_tstep_con = p_s.num_timesteps
					num26 = 0
					num27 = 0
					p_s.k_rod_tbg = pump_spring_con / (1.0 + pump_spring_con / p_s.tbg_spring_con)
					p_s.ratio_vb_converged = 0
					flag5 = True
					num19 = 0

				Dim cart_coord_type2 As TEImpred.cart_coord_type
				While flag5
					Application.DoEvents()
					Application.DoEvents()
					Application.DoEvents()
					num19 += 1
					p_s.total_iterations = 0
					p_s.max_ts_iter_pump_bc = 0
					If p_s.vari_spm = 0 Then
						t_s(num19).num_timesteps = p_s.num_timesteps
					Else
						If p_s.vari_spm <> 1 Then
							GoTo IL_DBFB
						End If
						t_s(num19).num_timesteps = -1
					End If
					Dim pump_displacement As Double = t_s(p_s.num_timesteps).pump_displacement
					Dim num28 As Integer = 1
					Dim num29 As Integer = 1
					Dim num30 As Integer = 0
					num18 = 0
					Dim num31 As Integer = 0
					While num29 = 1
						If RSWIN_DESC.bAbortRun Then
							p_s.iostat = -1
							Me.m_RunStatus = p_s.iostat
							GoTo IL_DBFB
						End If
						num31 += 1
						num18 += 1
						Dim num21 As Integer = 0

							If num27 = 0 And p_s.vari_spm = 1 Then
								If num26 = 1 Then
									If num30 = 0 Then
										If num18 = 1 Then
											' The following expression was wrapped in a checked-expression
											p_s.delta_theta_nu = t_s(p_s.num_timesteps).crank_angle - t_s(p_s.num_timesteps - 1).crank_angle
											p_s.crank_angle_nu = p_s.delta_theta_nu + t_s(p_s.num_timesteps).crank_angle
										ElseIf num18 = 2 Then
											p_s.delta_theta_nu = t_s(1).crank_angle - t_s(p_s.num_timesteps).crank_angle
											p_s.crank_angle_nu = p_s.delta_theta_nu + t_s(1).crank_angle
										Else
											' The following expression was wrapped in a checked-expression
											' The following expression was wrapped in a checked-expression
											p_s.delta_theta_nu = t_s(num18 - 1).crank_angle - t_s(num18 - 2).crank_angle
											p_s.crank_angle_nu = p_s.delta_theta_nu + t_s(num18 - 1).crank_angle
										End If
										p_s.vel_mot = p_s.delta_theta_nu / p_s.timestep_length * p_s.ratio_gb * p_s.ratio_vb
									ElseIf num30 = 1 Then
										If num18 = 1 Then
											' The following expression was wrapped in a checked-expression
											p_s.delta_theta_nu = t_s(p_s.num_timesteps).crank_angle - t_s(p_s.num_timesteps - 1).crank_angle
											p_s.crank_angle_nu = p_s.delta_theta_nu + t_s(p_s.num_timesteps).crank_angle
										ElseIf num18 = 2 Then
											p_s.delta_theta_nu = t_s(1).crank_angle - t_s(p_s.num_timesteps).crank_angle
											p_s.crank_angle_nu = p_s.delta_theta_nu + t_s(1).crank_angle
										Else
											' The following expression was wrapped in a checked-expression
											' The following expression was wrapped in a checked-expression
											p_s.delta_theta_nu = t_s(num18 - 1).crank_angle - t_s(num18 - 2).crank_angle
											p_s.crank_angle_nu = p_s.delta_theta_nu + t_s(num18 - 1).crank_angle
										End If
										p_s.vel_mot = p_s.delta_theta_nu / p_s.timestep_length * p_s.ratio_gb * p_s.ratio_vb
									ElseIf num30 = 2 Then
										If num18 = 1 Then
											' The following expression was wrapped in a checked-expression
											p_s.delta_theta_nu = t_s(p_s.num_timesteps).crank_angle - t_s(p_s.num_timesteps - 1).crank_angle
											p_s.crank_angle_nu = p_s.delta_theta_nu + t_s(p_s.num_timesteps).crank_angle
										ElseIf num18 = 2 Then
											p_s.delta_theta_nu = t_s(1).crank_angle - t_s(p_s.num_timesteps).crank_angle
											p_s.crank_angle_nu = p_s.delta_theta_nu + t_s(1).crank_angle
										Else
											' The following expression was wrapped in a checked-expression
											' The following expression was wrapped in a checked-expression
											p_s.delta_theta_nu = t_s(num18 - 1).crank_angle - t_s(num18 - 2).crank_angle
											p_s.crank_angle_nu = p_s.delta_theta_nu + t_s(num18 - 1).crank_angle
										End If
										p_s.vel_mot = p_s.delta_theta_nu / p_s.timestep_length * p_s.ratio_gb * p_s.ratio_vb
									ElseIf num30 >= 3 Then
										num27 = 1
									End If
								Else
									If num26 <> 0 Then
										GoTo IL_DBFB
									End If
									If num18 = 1 Then
										If p_s.num_tstep_con > p_s.lookup_max Then
										End If
										p_s.delta_theta_nu = p_s.delta_theta
										p_s.crank_angle_nu = p_s.delta_theta_nu + l_u(p_s.num_tstep_con).crank_angle - 3.141592653589793 - 3.141592653589793
										p_s.vel_mot = p_s.delta_theta_nu / p_s.timestep_length * p_s.ratio_gb * p_s.ratio_vb
									Else
										p_s.delta_theta_nu = p_s.delta_theta
										p_s.crank_angle_nu = t_s(num18 - 1).crank_angle + p_s.delta_theta_nu
										p_s.vel_mot = p_s.delta_theta_nu / p_s.timestep_length * p_s.ratio_gb * p_s.ratio_vb
									End If
								End If
							End If
							Dim num32 As Double
							Dim num33 As Double
							Dim num34 As Double
							Dim vel_mot As Double
							If num27 = 1 And p_s.vari_spm = 1 Then
								' The following expression was wrapped in a checked-statement
								Dim obj25 As Object
								If num18 = 1 Then
									array9(1) = t_s(p_s.num_timesteps - 2).vel_mot
									array9(2) = t_s(p_s.num_timesteps - 1).vel_mot
									array9(3) = t_s(p_s.num_timesteps).vel_mot
									array8(1) = t_s(p_s.num_timesteps - 2).timestep_var
									array8(2) = t_s(p_s.num_timesteps - 1).timestep_var
									array8(3) = t_s(p_s.num_timesteps).timestep_var
								ElseIf num18 = 2 Then
									array9(1) = t_s(p_s.num_timesteps - 1).vel_mot
									array9(2) = t_s(p_s.num_timesteps).vel_mot
									array9(3) = t_s(num18 - 1).vel_mot
									array8(1) = t_s(p_s.num_timesteps - 1).timestep_var
									array8(2) = t_s(p_s.num_timesteps).timestep_var
									array8(3) = t_s(num18 - 1).timestep_var
								ElseIf num18 = 3 Then
									array9(1) = t_s(p_s.num_timesteps).vel_mot
									array9(2) = t_s(num18 - 2).vel_mot
									array9(3) = t_s(num18 - 1).vel_mot
									array8(1) = t_s(p_s.num_timesteps).timestep_var
									array8(2) = t_s(num18 - 2).timestep_var
									array8(3) = t_s(num18 - 1).timestep_var
								ElseIf ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj, 1, 3, 1, obj25, obj) Then
									Do
										array8(Conversions.ToInteger(obj)) = t_s(Conversions.ToInteger(Operators.SubtractObject(num18, obj))).timestep_var
										array9(Conversions.ToInteger(obj)) = t_s(Conversions.ToInteger(Operators.SubtractObject(num18, obj))).vel_mot
									Loop While ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj, obj25, obj)
								End If
								Me.parabola(array8, array9, num32, num33, num34)
								p_s.vel_mot = num32 * Math.Pow(array8(1) + p_s.timestep_length, 2.0) + num33 * (array8(1) + p_s.timestep_length) + num34
								p_s.delta_theta_nu = p_s.vel_mot * p_s.timestep_length / p_s.ratio_gb / p_s.ratio_vb
								If num18 = 1 Then
									If num19 = 1 Then
										p_s.crank_angle_nu = p_s.delta_theta_nu + t_s(p_s.num_timesteps).crank_angle
									ElseIf num19 >= 2 Then
										p_s.crank_angle_nu = p_s.delta_theta_nu + t_s(p_s.num_timesteps).crank_angle - 3.141592653589793 - 3.141592653589793
									End If
								ElseIf num18 >= 2 Then
									' The following expression was wrapped in a checked-expression
									p_s.crank_angle_nu = p_s.delta_theta_nu + t_s(num18 - 1).crank_angle
								End If
								vel_mot = p_s.vel_mot
							End If
							If p_s.vari_spm = 1 Then
								Dim num35 As Integer
								Dim num36 As Integer
								If p_s.crank_angle_nu - l_u(1).crank_angle + p_s.delta_theta * 0.99 / p_s.delta_theta > 32000.0 Then
									num35 = p_s.num_tstep_con + 2
								Else
									' The following expression was wrapped in a unchecked-expression
									num35 = CInt(Math.Round(p_s.crank_angle_nu - l_u(1).crank_angle + p_s.delta_theta * 0.99 / p_s.delta_theta))
								End If
								num35 -= 1
								num36 = 1
								If num35 < 1 Then
									num35 = 1
								ElseIf num35 > p_s.num_tstep_con Then
									num35 = p_s.num_tstep_con - 1
								End If
								t_s(num18).p_r_position = -9.0
								t_s(num18).torq_fact = -9.0
								While num36 = 1
									' The following expression was wrapped in a checked-expression
									If p_s.crank_angle_nu <= l_u(1).crank_angle Then
										t_s(num18).p_r_position = l_u(p_s.num_tstep_con).p_r_position + (p_s.crank_angle_nu + 3.141592653589793 + 3.141592653589793 - l_u(p_s.num_tstep_con).crank_angle) / (l_u(1).crank_angle + 3.141592653589793 + 3.141592653589793 - l_u(p_s.num_tstep_con).crank_angle) * (l_u(1).p_r_position - l_u(p_s.num_tstep_con).p_r_position)
										t_s(num18).torq_fact = l_u(p_s.num_tstep_con).torq_fact + (p_s.crank_angle_nu + 3.141592653589793 + 3.141592653589793 - l_u(p_s.num_tstep_con).crank_angle) / (l_u(1).crank_angle + 3.141592653589793 + 3.141592653589793 - l_u(p_s.num_tstep_con).crank_angle) * (l_u(1).torq_fact - l_u(p_s.num_tstep_con).torq_fact)
										t_s(num18).crank_angle = p_s.crank_angle_nu
										num36 = 0
									ElseIf p_s.crank_angle_nu >= l_u(p_s.num_tstep_con).crank_angle Then
										t_s(num18).p_r_position = l_u(p_s.num_tstep_con).p_r_position + (p_s.crank_angle_nu - l_u(p_s.num_tstep_con).crank_angle) / (l_u(1).crank_angle + 3.141592653589793 + 3.141592653589793 - l_u(p_s.num_tstep_con).crank_angle) * (l_u(1).p_r_position - l_u(p_s.num_tstep_con).p_r_position)
										t_s(num18).torq_fact = l_u(p_s.num_tstep_con).torq_fact + (p_s.crank_angle_nu - l_u(p_s.num_tstep_con).crank_angle) / (l_u(1).crank_angle + 3.141592653589793 + 3.141592653589793 - l_u(p_s.num_tstep_con).crank_angle) * (l_u(1).torq_fact - l_u(p_s.num_tstep_con).torq_fact)
										t_s(num18).crank_angle = p_s.crank_angle_nu
										num36 = 0
									ElseIf p_s.crank_angle_nu >= l_u(num35).crank_angle And p_s.crank_angle_nu <= l_u(num35 + 1).crank_angle Then
										' The following expression was wrapped in a checked-expression
										' The following expression was wrapped in a checked-expression
										t_s(num18).p_r_position = l_u(num35).p_r_position + (p_s.crank_angle_nu - l_u(num35).crank_angle) * (l_u(num35 + 1).p_r_position - l_u(num35).p_r_position) / (l_u(num35 + 1).crank_angle - l_u(num35).crank_angle)
										t_s(num18).torq_fact = l_u(num35).torq_fact + (p_s.crank_angle_nu - l_u(num35).crank_angle) * (l_u(num35 + 1).torq_fact - l_u(num35).torq_fact) / (l_u(num35 + 1).crank_angle - l_u(num35).crank_angle)
										t_s(num18).crank_angle = p_s.crank_angle_nu
										num36 = 0
									Else
										' The following expression was wrapped in a checked-statement
										num35 += 1
									End If
								End While
							End If
							Dim num37 As Integer = 1
							Dim num38 As Integer = 1
							Dim num39 As Integer = 0
							Dim num52 As Double
							While num38 = 1
								Dim obj26 As Object
								If ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj, 2, num4 - 1, 2, obj26, obj) Then
									Do
										array4(Conversions.ToInteger(obj)) = r_e(Conversions.ToInteger(Conversion.Int(Operators.DivideObject(obj, 2)))).old_velocity * r_e(Conversions.ToInteger(Conversion.Int(Operators.DivideObject(obj, 2)))).mass / (32.17405 * p_s.timestep_length) - r_e(Conversions.ToInteger(Conversion.Int(Operators.DivideObject(obj, 2)))).gravity_force - r_e(Conversions.ToInteger(Conversion.Int(Operators.DivideObject(obj, 2)))).friction_force
										If RSWIN_DESC.SETUP_UseJeffsFix Then
											array4(Conversions.ToInteger(obj)) = array4(Conversions.ToInteger(obj)) - r_e(Conversions.ToInteger(Conversion.Int(Operators.DivideObject(obj, 2)))).force_buoy
										End If
										Dim num40 As Double
										If r_e(Conversions.ToInteger(Conversion.Int(Operators.DivideObject(obj, 2)))).old_velocity <= 0.0 Then
											num40 = r_e(Conversions.ToInteger(Conversion.Int(Operators.DivideObject(obj, 2)))).damp_coef_dn
										Else
											num40 = r_e(Conversions.ToInteger(Conversion.Int(Operators.DivideObject(obj, 2)))).damp_coef_up
										End If
										array2(Conversions.ToInteger(obj)) = r_e(Conversions.ToInteger(Conversion.Int(Operators.DivideObject(obj, 2)))).mass / 32.17405 * (num40 + 1.0 / p_s.timestep_length)
									Loop While ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj, obj26, obj)
								End If
								If RSWIN_DESC.SETUP_UseJeffsFix Then
									' The following expression was wrapped in a checked-expression
									obj = num4 - 1
									array4(Conversions.ToInteger(obj)) = array4(Conversions.ToInteger(obj)) + r_e(Conversions.ToInteger(Conversion.Int(Operators.DivideObject(obj, 2)))).force_buoy
								End If
								Dim num41 As Double
								If num18 = 1 And num19 = 1 Then
									num41 = 0.0
								ElseIf num18 = 1 Then
									num41 = t_s(p_s.num_timesteps).p_r_position
								Else
									' The following expression was wrapped in a checked-expression
									num41 = t_s(num18 - 1).p_r_position
								End If
								Dim num42 As Double = -(t_s(num18).p_r_position - num41) / p_s.timestep_length / 12.0
								Dim num43 As Double = Math.Abs(num42 / p_s.pr_velo_max_up)
								t_s(num18).pr_drag_force = p_s.pr_drag_f_max * (CDbl(p_s.pr_drag_0) + CDbl(p_s.pr_drag_1) * num43 + CDbl(p_s.pr_drag_2) * Math.Pow(num43, 2.0)) / (CDbl((p_s.pr_drag_0 + p_s.pr_drag_1 + p_s.pr_drag_2)) + 1E-10)
								If t_s(num18).p_r_position > num41 Then
									num43 = Math.Abs(num42 / p_s.pr_velo_max_dn)
									t_s(num18).pr_drag_force = -p_s.pr_drag_f_max * (CDbl(p_s.pr_drag_0) + CDbl(p_s.pr_drag_1) * num43 + CDbl(p_s.pr_drag_2) * Math.Pow(num43, 2.0)) / (CDbl((p_s.pr_drag_0 + p_s.pr_drag_1 + p_s.pr_drag_2)) + 1E-10)
								End If
								array4(2) = array4(2) + t_s(num18).pr_drag_force
								array4(2) = array4(2) - p_s.p_r_weight_unbuoyed
								array4(num4 - 1) = array4(num4 - 1) - p_s.pump_weight_buoyed
								Dim num44 As Double
								Dim num45 As Double
								If num18 = 1 And num19 = 1 Then
									num44 = 0.0
									num45 = -num44
								ElseIf num18 = 1 Then
									num44 = -t_s(p_s.num_timesteps).pump_velocity
									num45 = -num44
								Else
									' The following expression was wrapped in a checked-expression
									num44 = -t_s(num18 - 1).pump_velocity
									num45 = -num44
								End If
								p_s.drag_0_exp = 0.5
								Dim num46 As Double
								If num45 > 0.0 Then
									num46 = Math.Abs(num44 / p_s.p_velo_max_up)
									t_s(num18).p_drag_force = -p_s.p_drag_f_max_up * (CDbl(p_s.p_drag_up_0) + CDbl(p_s.p_drag_up_1) * num46 + CDbl(p_s.p_drag_up_2) * Math.Pow(num46, 2.0)) / (CDbl((p_s.p_drag_up_0 + p_s.p_drag_up_1 + p_s.p_drag_up_2)) + 1E-10)
									t_s(num18).p_drag_force = -p_s.p_drag_f_max_up * (CDbl(p_s.p_drag_up_0) * Math.Pow(num46, p_s.drag_0_exp) + CDbl(p_s.p_drag_up_1) * num46 + CDbl(p_s.p_drag_up_2) * Math.Pow(num46, 2.0)) / (CDbl((p_s.p_drag_up_0 + p_s.p_drag_up_1 + p_s.p_drag_up_2)) + 1E-10)
								ElseIf num45 <= 0.0 Then
									num46 = Math.Abs(num44 / p_s.p_velo_max_dn)
									t_s(num18).p_drag_force = p_s.p_drag_f_max_dn * (CDbl(p_s.p_drag_dn_0) + CDbl(p_s.p_drag_dn_1) * num46 + CDbl(p_s.p_drag_dn_2) * Math.Pow(num46, 2.0)) / (CDbl((p_s.p_drag_dn_0 + p_s.p_drag_dn_1 + p_s.p_drag_dn_2)) + 1E-10)
									t_s(num18).p_drag_force = p_s.p_drag_f_max_dn * (CDbl(p_s.p_drag_dn_0) * Math.Pow(num46, p_s.drag_0_exp) + CDbl(p_s.p_drag_dn_1) * num46 + CDbl(p_s.p_drag_dn_2) * Math.Pow(num46, 2.0)) / (CDbl((p_s.p_drag_dn_0 + p_s.p_drag_dn_1 + p_s.p_drag_dn_2)) + 1E-10)
								End If
								t_s(num18).vel_ratio = num46
								If num18 = 1 And num37 = 0 Then
									num19 = num19
								End If
								If p_s.fluid_solution = 0 And p_s.ratio_vb_converged = 1 Then
									Dim flag6 As Boolean = False And num19 = 1 And num18 = 1
									p_s.pump_area_mod = p_s.pump_area * p_s.pump_effic
									If RSWIN_DESC.rst.IncludeFluidInertia <> 0S Then
										Dim flag7 As Boolean = Me.fluid_inertia(num19, num18, f_e, p_s, r_e, r_t, t_s, t_t, num21)
									End If
									If p_s.iostat <> 0 Then
										GoTo IL_DBFB
									End If
									If num21 = 0 Then
										If Not(num18 = 1 And num19 = 1) Then
											If num18 <> 1 AndAlso num18 <= 1 Then
												If p_s.iostat = 0 Then
													p_s.iostat = -8558
												End If
												GoTo IL_DBFB
											End If
										End If
									End If
									Dim flag8 As Boolean = num19 = 1 And num18 = 1
									If num19 = 1 And num18 = 1 Then
									End If
								Else
									If p_s.fluid_solution = 1 And p_s.ratio_vb_converged = 1 Then
										p_s.iostat = -8579
										GoTo IL_DBFB
									End If
									If p_s.fluid_solution = 0 And p_s.ratio_vb_converged = 0 Then
										t_s(num18).pump_psia_a = p_s.pump_psia_as
									Else
										If p_s.fluid_solution = 1 And p_s.ratio_vb_converged = 0 Then
											p_s.iostat = -8572
											GoTo IL_DBFB
										End If
										If p_s.fluid_solution <> -1 Then
											p_s.iostat = -8592
											GoTo IL_DBFB
										End If
										t_s(num18).pump_psia_a = p_s.pump_psia_as
									End If
								End If
								t_s(num18).SVopen_pump_force = t_s(num18).pump_psia_a * (p_s.pump_area - r_t(p_s.num_rod_tapers).rod_area) - p_s.pump_psia_bs * p_s.pump_area - t_s(num18).p_drag_force
								t_s(num18).TVopen_pump_force = t_s(num18).pump_psia_a * -r_t(p_s.num_rod_tapers).rod_area - t_s(num18).p_drag_force
								p_s.csg_psig_adj = 0.0
								Dim obj27 As Object
								If ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj, 3, num4 - 2, 2, obj27, obj) Then
									Do
										array4(Conversions.ToInteger(obj)) = r_e(Conversions.ToInteger(Conversion.Int(Operators.DivideObject(obj, 2)))).old_force * r_e(Conversions.ToInteger(Conversion.Int(Operators.DivideObject(obj, 2)))).length / (p_s.timestep_length * r_e(Conversions.ToInteger(Conversion.Int(Operators.DivideObject(obj, 2)))).ea)
									Loop While ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj, obj27, obj)
								End If
								array2(1) = 1.0
								array3(1) = num23 * p_s.timestep_length
								array4(1) = num23 * (t_s(num18).p_r_position / 12.0 - Me.displacement_1_n)
								Dim num47 As Integer = 0
								While num47 <> 1
									' The following expression was wrapped in a checked-statement
									num21 += 1
									p_s.total_iterations += 1
									If num21 > p_s.max_ts_iter_pump_bc Then
										p_s.max_ts_iter_pump_bc = num21
									End If
									If num21 > p_s.max_iterations Then
										p_s.iostat = -9923
										GoTo IL_DBFB
									End If
									Select Case num20
										Case 1
											array2(num4) = 1.0
											array(num4) = -pump_spring_con * p_s.timestep_length * p_s.tbg_spring_con / (p_s.tbg_spring_con + pump_spring_con)
											If num19 = 1 And num18 = 1 Then
												array4(num4) = num13
											ElseIf num18 = 1 Then
												array4(num4) = t_s(p_s.num_timesteps).pump_force + pump_spring_con / (p_s.tbg_spring_con + pump_spring_con) * (t_s(num18).pump_psia_a - t_s(p_s.num_timesteps).pump_psia_a) * (t_t(p_s.num_tbg_tapers).tbg_area_id - r_t(p_s.num_rod_tapers).rod_area)
											Else
												' The following expression was wrapped in a checked-expression
												' The following expression was wrapped in a checked-expression
												array4(num4) = t_s(num18 - 1).pump_force + pump_spring_con / (p_s.tbg_spring_con + pump_spring_con) * (t_s(num18).pump_psia_a - t_s(num18 - 1).pump_psia_a) * (t_t(p_s.num_tbg_tapers).tbg_area_id - r_t(p_s.num_rod_tapers).rod_area)
											End If
											Me.thomas(array, array2, array3, array4, array5, array6, array7, num4)
											If num19 = 1 And num18 = 1 Then
												t_s(num18).tbg_force = tbg_force_max + (t_s(num18).pump_psia_a - pump_psia_as2) * (t_t(p_s.num_tbg_tapers).tbg_area_id - r_t(p_s.num_rod_tapers).rod_area) - (array5(num4) - num13)
											ElseIf num18 = 1 Then
												t_s(num18).tbg_force = t_s(p_s.num_timesteps).tbg_force + (t_s(num18).pump_psia_a - t_s(p_s.num_timesteps).pump_psia_a) * (t_t(p_s.num_tbg_tapers).tbg_area_id - r_t(p_s.num_rod_tapers).rod_area) - (array5(num4) - t_s(p_s.num_timesteps).pump_force)
											Else
												' The following expression was wrapped in a checked-expression
												' The following expression was wrapped in a checked-expression
												' The following expression was wrapped in a checked-expression
												t_s(num18).tbg_force = t_s(num18 - 1).tbg_force + (t_s(num18).pump_psia_a - t_s(num18 - 1).pump_psia_a) * (t_t(p_s.num_tbg_tapers).tbg_area_id - r_t(p_s.num_rod_tapers).rod_area) - (array5(num4) - t_s(num18 - 1).pump_force)
											End If
											t_s(num18).pump_psia_p = (t_s(num18).tbg_force - t_s(num18).p_drag_force + p_s.pump_psia_bs * t_t(p_s.num_tbg_tapers).tbg_area_od - t_s(num18).pump_psia_a * (t_t(p_s.num_tbg_tapers).tbg_area_id - p_s.pump_area)) / p_s.pump_area
											If num19 = 1 And num18 = 1 Then
												' The following expression was wrapped in a checked-expression
												t_s(num18).pump_velocity = array5(num4 - 1) - (array5(num4) - num13) / p_s.timestep_length / pump_spring_con
											ElseIf num18 = 1 Then
												' The following expression was wrapped in a checked-expression
												t_s(num18).pump_velocity = array5(num4 - 1) - (array5(num4) - t_s(p_s.num_timesteps).pump_force) / p_s.timestep_length / pump_spring_con
											Else
												' The following expression was wrapped in a checked-expression
												' The following expression was wrapped in a checked-expression
												t_s(num18).pump_velocity = array5(num4 - 1) - (array5(num4) - t_s(num18 - 1).pump_force) / p_s.timestep_length / pump_spring_con
											End If
											If num19 = 1 And num18 = 1 Then
												t_s(num18).pump_displacement = num14 + t_s(num18).pump_velocity * p_s.timestep_length
											ElseIf num18 = 1 Then
												t_s(num18).pump_displacement = t_s(p_s.num_timesteps).pump_displacement + t_s(num18).pump_velocity * p_s.timestep_length
											Else
												' The following expression was wrapped in a checked-expression
												t_s(num18).pump_displacement = t_s(num18 - 1).pump_displacement + t_s(num18).pump_velocity * p_s.timestep_length
											End If
											Dim num48 As Double
											If num18 = 1 And num19 = 1 Then
												num48 = num12
											ElseIf num18 = 1 Then
												num48 = t_s(p_s.num_timesteps).displacement_N_n
												Dim pump_displacement2 As Double = t_s(p_s.num_timesteps).pump_displacement
											Else
												num48 = t_s(num18 - 1).displacement_N_n
												Dim pump_displacement2 As Double = t_s(num18 - 1).pump_displacement
											End If
											Dim num49 As Double = array5(num4 - 1) * p_s.timestep_length + num48
											Dim num50 As Double = -array5(num4) / pump_spring_con + num49
											If Math.Abs(t_s(num18).pump_displacement - num50) > 1E-10 Then
											End If
											t_s(num18).tbg_position = t_s(num18).tbg_force / p_s.tbg_spring_con
											t_s(num18).tbg_position = -t_s(num18).tbg_position
											If num19 = 1 And num18 = 1 Then
												t_s(num18).tbg_velo = (t_s(num18).tbg_position - num15) / p_s.timestep_length
											ElseIf num18 = 1 Then
												t_s(num18).tbg_velo = (t_s(num18).tbg_position - t_s(p_s.num_timesteps).tbg_position) / p_s.timestep_length
											Else
												' The following expression was wrapped in a checked-expression
												t_s(num18).tbg_velo = (t_s(num18).tbg_position - t_s(num18 - 1).tbg_position) / p_s.timestep_length
											End If
											If t_s(num18).pump_psia_p <= p_s.pump_psia_bs Then
												Dim num51 As Integer = CInt(Math.Round(t_s(num18).pump_psia_p))
												num20 = 2
												t_s(num18).pump_psia_p = p_s.pump_psia_bs
											ElseIf t_s(num18).pump_psia_p > t_s(num18).pump_psia_a Then
												Dim num51 As Integer = CInt(Math.Round(t_s(num18).pump_psia_p))
												num20 = 3
												t_s(num18).pump_psia_p = t_s(num18).pump_psia_a
											Else
												num47 = 1
												t_s(num18).p_drag_force = t_s(num18).p_drag_force
												Dim num51 As Integer = CInt(Math.Round(t_s(num18).pump_psia_p))
											End If
											If True And CLng(num18) <= num5 Then
												If Not(num19 = 1 And num18 = 1) Then
													If num18 <> 1 Then
													End If
												End If
											End If
										Case 2
											array(num4) = 0.0
											array2(num4) = 1.0
											array4(num4) = t_s(num18).SVopen_pump_force
											Me.thomas(array, array2, array3, array4, array5, array6, array7, num4)
											t_s(num18).pump_displacement = num52 + p_s.timestep_length * array5(num4 - 1) - array5(num4) / pump_spring_con
											t_s(num18).pump_velocity = (t_s(num18).pump_displacement - pump_displacement) / p_s.timestep_length
											If num19 = 1 And num18 = 1 Then
												t_s(num18).tbg_force = t_s(p_s.num_timesteps).tbg_force + (t_s(num18).pump_psia_a - t_s(p_s.num_timesteps).pump_psia_a) * (t_t(p_s.num_tbg_tapers).tbg_area_id - r_t(p_s.num_rod_tapers).rod_area) - (array5(num4) - t_s(p_s.num_timesteps).pump_force) - (t_s(num18).SV_drag_force - t_s(p_s.num_timesteps).SV_drag_force)
											ElseIf num18 = 1 Then
												t_s(num18).tbg_force = t_s(p_s.num_timesteps).tbg_force + (t_s(num18).pump_psia_a - t_s(p_s.num_timesteps).pump_psia_a) * (t_t(p_s.num_tbg_tapers).tbg_area_id - r_t(p_s.num_rod_tapers).rod_area) - (array5(num4) - t_s(p_s.num_timesteps).pump_force) - (t_s(num18).SV_drag_force - t_s(p_s.num_timesteps).SV_drag_force)
											Else
												' The following expression was wrapped in a checked-expression
												' The following expression was wrapped in a checked-expression
												' The following expression was wrapped in a checked-expression
												' The following expression was wrapped in a checked-expression
												t_s(num18).tbg_force = t_s(num18 - 1).tbg_force + (t_s(num18).pump_psia_a - t_s(num18 - 1).pump_psia_a) * (t_t(p_s.num_tbg_tapers).tbg_area_id - r_t(p_s.num_rod_tapers).rod_area) - (array5(num4) - t_s(num18 - 1).pump_force) - (t_s(num18).SV_drag_force - t_s(num18 - 1).SV_drag_force)
											End If
											t_s(num18).pump_psia_p = p_s.pump_psia_bs
											t_s(num18).tbg_position = t_s(num18).tbg_force / p_s.tbg_spring_con
											t_s(num18).tbg_position = -t_s(num18).tbg_position
											If num19 = 1 And num18 = 1 Then
												t_s(num18).tbg_velo = 0.0
											ElseIf num18 = 1 Then
												t_s(num18).tbg_velo = (t_s(num18).tbg_position - t_s(p_s.num_timesteps).tbg_position) / p_s.timestep_length
											Else
												' The following expression was wrapped in a checked-expression
												t_s(num18).tbg_velo = (t_s(num18).tbg_position - t_s(num18 - 1).tbg_position) / p_s.timestep_length
											End If
											If num18 = 1 Then
											End If
											If t_s(num18).pump_displacement - t_s(num18).tbg_position < t_s(num18 - 1).pump_displacement - t_s(num18 - 1).tbg_position Then
												If num25 < pump_displacement Then
													num25 = pump_displacement
												End If
												If p_s.pump_fillup >= 1.0 Then
													p_s.pump_fillup = 1.0
													num20 = 1
												Else
													num8 = 1
													If num18 = 1 And num19 = 1 Then
														Dim num53 As Double = t_s(num18).tbg_force - p_s.tbg_force_min
													Else
														Dim num53 As Double
														If num18 = 1 Then
															num53 = t_s(num18).tbg_force - t_s(p_s.num_timesteps).tbg_force
															GoTo IL_DBFB
														End If
														num53 = t_s(num18).tbg_force - t_s(num18 - 1).tbg_force
													End If
													num20 = 6
												End If
											Else
												num47 = 1
											End If
											If True And CLng(num18) <= num5 Then
												If Not(num19 = 1 And num18 = 1) Then
													If num18 <> 1 Then
													End If
												End If
											End If
										Case 3
											array(num4) = 0.0
											array2(num4) = 1.0
											array4(num4) = t_s(num18).TVopen_pump_force
											Me.thomas(array, array2, array3, array4, array5, array6, array7, num4)
											t_s(num18).pump_displacement = num52 + p_s.timestep_length * array5(num4 - 1) - array5(num4) / pump_spring_con
											t_s(num18).pump_velocity = (t_s(num18).pump_displacement - pump_displacement) / p_s.timestep_length
											If num19 = 1 And num18 = 1 Then
												t_s(num18).tbg_force = tbg_force_max + (t_s(num18).pump_psia_a - pump_psia_as) * (t_t(p_s.num_tbg_tapers).tbg_area_id - r_t(p_s.num_rod_tapers).rod_area) - (array5(num4) - num13) - (t_s(num18).TV_drag_force - 0.0)
											ElseIf num18 = 1 Then
												t_s(num18).tbg_force = t_s(p_s.num_timesteps).tbg_force + (t_s(num18).pump_psia_a - t_s(p_s.num_timesteps).pump_psia_a) * (t_t(p_s.num_tbg_tapers).tbg_area_id - r_t(p_s.num_rod_tapers).rod_area) - (array5(num4) - t_s(p_s.num_timesteps).pump_force) - (t_s(num18).TV_drag_force - t_s(p_s.num_timesteps).TV_drag_force)
											Else
												' The following expression was wrapped in a checked-expression
												' The following expression was wrapped in a checked-expression
												' The following expression was wrapped in a checked-expression
												' The following expression was wrapped in a checked-expression
												t_s(num18).tbg_force = t_s(num18 - 1).tbg_force + (t_s(num18).pump_psia_a - t_s(num18 - 1).pump_psia_a) * (t_t(p_s.num_tbg_tapers).tbg_area_id - r_t(p_s.num_rod_tapers).rod_area) - (array5(num4) - t_s(num18 - 1).pump_force) - (t_s(num18).TV_drag_force - t_s(num18 - 1).TV_drag_force)
											End If
											t_s(num18).pump_psia_p = t_s(num18).pump_psia_a
											t_s(num18).tbg_position = t_s(num18).tbg_force / p_s.tbg_spring_con
											t_s(num18).tbg_position = -t_s(num18).tbg_position
											Dim num54 As Double
											If num19 = 1 And num18 = 1 Then
												t_s(num18).tbg_velo = (t_s(num18).tbg_position - num15) / p_s.timestep_length
												num54 = num15
											ElseIf num18 = 1 Then
												t_s(num18).tbg_velo = (t_s(num18).tbg_position - t_s(p_s.num_timesteps).tbg_position) / p_s.timestep_length
												num54 = t_s(p_s.num_timesteps).tbg_position
											Else
												' The following expression was wrapped in a checked-expression
												t_s(num18).tbg_velo = (t_s(num18).tbg_position - t_s(num18 - 1).tbg_position) / p_s.timestep_length
												num54 = t_s(num18 - 1).tbg_position
											End If
											If t_s(num18).pump_displacement - t_s(num18).tbg_position > pump_displacement - num54 Then
												If num24 > pump_displacement Then
													num24 = pump_displacement
												End If
												If p_s.pump_fillup >= 1.0 Then
													p_s.pump_fillup = 1.0
													num20 = 1
												Else
													num20 = 6
													num20 = 1
												End If
											Else
												num47 = 1
											End If
											If True And CLng(num18) <= num5 Then
												If Not(num19 = 1 And num18 = 1) Then
													If num18 <> 1 Then
													End If
												End If
											End If
										Case 6
											Dim num55 As Integer = 1
											Dim num56 As Integer = 2224
											Dim num57 As Integer = 2224
											Dim num58 As Integer = 1
											array(num4) = -p_s.k_rod_tbg * p_s.timestep_length
											array2(num4) = 1.0
											Dim pump_psia_a As Double
											Dim num59 As Double
											Dim num60 As Double
											Dim num63 As Integer
											If num19 = 1 And num18 = 1 Then
												p_s.iostat = -8529
											ElseIf num18 = 1 Then
												If num8 = 1 Then
													pump_psia_a = t_s(num18).pump_psia_a
													num59 = t_s(p_s.num_timesteps).pump_psia_p * (1.0 + 0.0 * num11)
													If num59 < p_s.pump_psia_bs Then
														num59 = p_s.pump_psia_bs
														p_s.iostat = -8553
														GoTo IL_DBFB
													End If
													num60 = -t_s(num18).p_drag_force + pump_psia_a * (p_s.pump_area - r_t(p_s.num_rod_tapers).rod_area) - num59 * p_s.pump_area
													Dim num61 As Double = num60 - t_s(p_s.num_timesteps).pump_force
													Dim num62 As Double = (num25 - num24 - p_s.tbg_stretch_max) * 12.0
													p_s.po_vol_init = (1.0 - p_s.pump_fillup) * num62 * p_s.pump_area + p_s.TV_clear_vol
													t_s(p_s.num_timesteps).gas_vol = p_s.po_vol_init / 12.0 / 144.0
												ElseIf num8 = 0 Then
													pump_psia_a = t_s(num18).pump_psia_a
													num59 = t_s(num18 - 1).pump_psia_p + 0.99 * (t_s(num18 - 1).pump_psia_p - t_s(p_s.num_timesteps).pump_psia_p)
													num63 = 0
													If num59 <= p_s.pump_psia_bs Then
														num59 = p_s.pump_psia_bs
														num63 = 1
													End If
													num60 = -t_s(num18).p_drag_force + pump_psia_a * (p_s.pump_area - r_t(p_s.num_rod_tapers).rod_area) - num59 * p_s.pump_area
													Dim num61 As Double = num60 - t_s(num18 - 1).pump_force
													t_s(num18 - 1).gas_vol = t_s(p_s.num_timesteps).gas_vol * Math.Pow(t_s(p_s.num_timesteps).pump_psia_p / t_s(num18 - 1).pump_psia_p, 1.0 / p_s.gas_exponent)
												End If
											Else
												If num8 = 1 Then
													pump_psia_a = t_s(num18).pump_psia_a
													num59 = t_s(num18 - 1).pump_psia_p * (1.0 + 0.0 * num11)
													If num59 < p_s.pump_psia_bs Then
														num59 = p_s.pump_psia_bs
														If p_s.iostat = 0 Then
															p_s.iostat = -8553
														End If
														GoTo IL_DBFB
													End If
													num60 = -t_s(num18).p_drag_force + pump_psia_a * (p_s.pump_area - r_t(p_s.num_rod_tapers).rod_area) - num59 * p_s.pump_area
													Dim num61 As Double = num60 - t_s(num18 - 1).pump_force
													Dim num62 As Double = (num25 - num24 - p_s.tbg_stretch_max) * 12.0
													p_s.po_vol_init = (1.0 - p_s.pump_fillup) * num62 * p_s.pump_area + p_s.TV_clear_vol
													t_s(num18 - 1).gas_vol = p_s.po_vol_init / 12.0 / 144.0
												Else
													If num8 <> 0 Then
														If p_s.iostat = 0 Then
															p_s.iostat = -8551
														End If
														GoTo IL_DBFB
													End If
													If num18 = 1 Or num18 = 2 Then
														If p_s.iostat = 0 Then
															p_s.iostat = -8552
														End If
														GoTo IL_DBFB
													End If
													pump_psia_a = t_s(num18).pump_psia_a
													num59 = t_s(num18 - 1).pump_psia_p + 0.99 * (t_s(num18 - 1).pump_psia_p - t_s(num18 - 2).pump_psia_p)
													num63 = 0
													If num59 <= p_s.pump_psia_bs Then
														num59 = p_s.pump_psia_bs
														num63 = 1
													End If
													num60 = -t_s(num18).p_drag_force + pump_psia_a * (p_s.pump_area - r_t(p_s.num_rod_tapers).rod_area) - num59 * p_s.pump_area
													Dim num61 As Double = num60 - t_s(num18 - 1).pump_force
													t_s(num18 - 1).gas_vol = t_s(num18 - 2).gas_vol * Math.Pow(t_s(num18 - 2).pump_psia_p / t_s(num18 - 1).pump_psia_p, 1.0 / p_s.gas_exponent)
												End If
												Dim flag9 As Boolean = False And num55 = 1 And num18 >= num56 And num18 <= num57 And num19 >= num58
											End If
											Dim num64 As Integer = 0
											While num64 = 0
												' The following expression was wrapped in a checked-expression
												' The following expression was wrapped in a checked-expression
												t_s(num18).d_pump_off = p_s.k_rod_tbg * 144.0 / p_s.pump_area * t_s(num18 - 1).gas_vol * (1.0 - Math.Pow(t_s(num18 - 1).pump_psia_p / num59, 1.0 / p_s.gas_exponent))
												t_s(num18).d_fluid_inertia = -p_s.k_rod_tbg / p_s.tbg_spring_con * (pump_psia_a - t_s(num18 - 1).pump_psia_a) * (r_t(p_s.num_rod_tapers).rod_area - t_t(p_s.num_tbg_tapers).tbg_area_id)
												t_s(num18).SV_leak_coeff = t_s(num18).SV_leak_coeff_max * p_s.SV_leak_percent / 100.0
												If num59 - p_s.pump_psia_bs < 0.0 Then
												End If
												t_s(num18).d_leaky_SV = p_s.k_rod_tbg * 144.0 / p_s.pump_area * p_s.timestep_length * t_s(num18).SV_leak_coeff * Math.Sqrt(num59 - p_s.pump_psia_bs)
												array4(num4) = t_s(num18 - 1).pump_force + t_s(num18).d_pump_off + t_s(num18).d_fluid_inertia + t_s(num18).d_leaky_SV
												Me.thomas(array, array2, array3, array4, array5, array6, array7, num4)
												Dim flag10 As Boolean = False And num55 = 1 And num18 >= num56 And num18 <= num57 And num19 >= num58
												If Math.Abs(num60 - array5(num4)) < 1E-11 Then
													num64 = 1
													If p_s.vari_spm = 0 Then
														num8 = 0
													End If
													If num55 = 1 And num18 >= num56 And num18 <= num57 And num19 >= num58 Then
													End If
												ElseIf num7 = 1 Then
													Dim num65 As Double = num60
													Dim num66 As Double = array5(num4)
													Dim num67 As Double = num59
													Dim num68 As Double = num60 - array5(num4)
													If num8 = 1 Then
														If num19 = 1 And num18 = 1 Then
															p_s.iostat = -8528
															GoTo IL_DBFB
														End If
														If num18 = 1 Then
															num59 = t_s(p_s.num_timesteps).pump_psia_p * (1.0 + 1.0 * num11)
														Else
															' The following expression was wrapped in a checked-expression
															num59 = t_s(num18 - 1).pump_psia_p * (1.0 + 1.0 * num11)
														End If
														num60 = -t_s(num18).p_drag_force + pump_psia_a * (p_s.pump_area - r_t(p_s.num_rod_tapers).rod_area) - num59 * p_s.pump_area
														If num19 = 1 And num18 = 1 Then
															p_s.iostat = -8528
															GoTo IL_DBFB
														End If
														If num18 = 1 Then
															Dim num61 As Double = num60 - t_s(p_s.num_timesteps).pump_force
														Else
															' The following expression was wrapped in a checked-expression
															Dim num61 As Double = num60 - t_s(num18 - 1).pump_force
														End If
													Else
														If num8 <> 0 Then
															If p_s.iostat = 0 Then
																p_s.iostat = -8548
															End If
															GoTo IL_DBFB
														End If
														If num18 = 1 Then
															If p_s.iostat = 0 Then
																p_s.iostat = -8530
															End If
															GoTo IL_DBFB
														End If
														If num18 = 2 Then
															If p_s.iostat = 0 Then
																p_s.iostat = -8567
															End If
															GoTo IL_DBFB
														End If
														num59 = t_s(num18 - 1).pump_psia_p + 1.01 * (t_s(num18 - 1).pump_psia_p - t_s(num18 - 2).pump_psia_p)
														If num59 <= p_s.pump_psia_bs Then
															num59 = p_s.pump_psia_bs + 1E-08
															num63 += 2
														End If
														num60 = -t_s(num18).p_drag_force + pump_psia_a * (p_s.pump_area - r_t(p_s.num_rod_tapers).rod_area) - num59 * p_s.pump_area
														Dim num61 As Double = num60 - t_s(num18 - 1).pump_force
													End If
												ElseIf num7 = 2 Then
													Dim num69 As Double = num60
													Dim num70 As Double = array5(num4)
													Dim num71 As Double = num59
													Dim num72 As Double = num60 - num70
													If num8 = 1 Then
														Dim num67 As Double
														Dim num68 As Double
														Dim num73 As Double = (num72 - num68) / (num71 - num67)
														num59 = num71 - num72 / num73
														If num59 < p_s.pump_psia_bs Then
															num59 = (num67 + num71) / 2.0
															If num59 <= p_s.pump_psia_bs Then
																If p_s.iostat = 0 Then
																	p_s.iostat = -8545
																End If
																GoTo IL_DBFB
															End If
														End If
														num60 = -t_s(num18).p_drag_force + pump_psia_a * (p_s.pump_area - r_t(p_s.num_rod_tapers).rod_area) - num59 * p_s.pump_area
														Dim num61 As Double = num60 - t_s(num18 - 1).pump_force
													ElseIf num8 = 0 Then
														Dim num67 As Double
														Dim num68 As Double
														Dim num73 As Double = (num72 - num68) / (num71 - num67)
														num59 = num71 - num72 / num73
														If num59 <= p_s.pump_psia_bs Then
															num59 = p_s.pump_psia_bs + 2E-08
															num63 += 4
														End If
														num60 = -t_s(num18).p_drag_force + pump_psia_a * (p_s.pump_area - r_t(p_s.num_rod_tapers).rod_area) - num59 * p_s.pump_area
														Dim num61 As Double = num60 - t_s(num18 - 1).pump_force
													End If
												Else
													If num7 < 3 Then
														If p_s.iostat = 0 Then
															p_s.iostat = -8543
														End If
														GoTo IL_DBFB
													End If
													Dim num67 As Double
													Dim num74 As Double = num67
													Dim num65 As Double
													Dim num75 As Double = num65
													Dim num66 As Double
													Dim num76 As Double = num66
													Dim num71 As Double
													num67 = num71
													Dim num69 As Double
													num65 = num69
													Dim num70 As Double
													num66 = num70
													num71 = num59
													num69 = num60
													num70 = array5(num4)
													array8(1) = num75 - num76
													array8(2) = num65 - num66
													array8(3) = num69 - num70
													array9(1) = num74
													array9(2) = num67
													array9(3) = num71
													Dim num77 As Double = 1E-15
													Dim num78 As Double = 1E-15
													Dim num79 As Integer = 0
													If Math.Abs((array8(1) - array8(2)) * 2.0 / (array8(1) + array8(2))) <= num77 Or Math.Abs((array9(1) - array9(2)) * 2.0 / (array9(1) + array9(2))) <= num78 Then
														num79 = 12
													ElseIf Math.Abs((array8(1) - array8(3)) * 2.0 / (array8(1) + array8(3))) <= num77 Or Math.Abs((array9(1) - array9(3)) * 2.0 / (array9(1) + array9(3))) <= num78 Then
														num79 = 13
													ElseIf Math.Abs((array8(2) - array8(3)) * 2.0 / (array8(2) + array8(3))) <= num77 Or Math.Abs((array9(2) - array9(3)) * 2.0 / (array9(2) + array9(3))) <= num78 Then
														num79 = 23
													End If
													If num79 = 0 Then
														Me.parabola(array8, array9, num32, num33, num34)
														Dim num80 As Double = 0.0
														num59 = num32 * Math.Pow(num80, 2.0) + num33 * num80 + num34
														If num59 <= p_s.pump_psia_bs Then
															num64 = 2
															num59 = p_s.pump_psia_bs
															num63 += 8
														End If
														num60 = -t_s(num18).p_drag_force + pump_psia_a * (p_s.pump_area - r_t(p_s.num_rod_tapers).rod_area) - num59 * p_s.pump_area
														Dim num61 As Double = num60 - t_s(num18 - 1).pump_force
													Else
														If Not(num79 = 12 Or num79 = 13 Or num79 = 23) Then
															If p_s.iostat = 0 Then
																p_s.iostat = -8544
															End If
															GoTo IL_DBFB
														End If
														num64 = 1
														num59 = num71
														If num59 <= p_s.pump_psia_bs Then
														End If
														num60 = -t_s(num18).p_drag_force + pump_psia_a * (p_s.pump_area - r_t(p_s.num_rod_tapers).rod_area) - num59 * p_s.pump_area
														Dim num61 As Double = num60 - t_s(num18 - 1).pump_force
													End If
													If num55 = 1 And num18 >= num56 And num18 <= num57 And num19 >= num58 Then
													End If
												End If
												If num7 >= 10 Then
													If p_s.iostat = 0 Then
														p_s.iostat = -8542
													End If
													GoTo IL_DBFB
												End If
												Dim flag11 As Boolean = num55 = 1 And num18 >= num56 And num18 <= num57 And num19 >= num58
												If num64 = 1 Then
													num7 = 1
												ElseIf num64 = 2 Then
													num7 = 1
												Else
													num7 += 1
												End If
											End While
											If num64 = 1 Then
												t_s(num18).pump_psia_p = (-array5(num4) + pump_psia_a * (p_s.pump_area - r_t(p_s.num_rod_tapers).rod_area) - t_s(num18).p_drag_force) / p_s.pump_area
												t_s(num18).pump_force = array5(num4)
											Else
												If num64 <> 2 Then
													If p_s.iostat = 0 Then
														p_s.iostat = -8541
													End If
													GoTo IL_DBFB
												End If
												t_s(num18).pump_psia_p = p_s.pump_psia_bs
												t_s(num18).pump_force = -t_s(num18).p_drag_force + pump_psia_a * (p_s.pump_area - r_t(p_s.num_rod_tapers).rod_area) - num59 * p_s.pump_area
											End If
											t_s(num18).tbg_force = t_s(num18).p_drag_force + t_s(num18).pump_psia_p * p_s.pump_area - p_s.pump_psia_bs * t_t(p_s.num_tbg_tapers).tbg_area_od + t_s(num18).pump_psia_a * (t_t(p_s.num_tbg_tapers).tbg_area_id - p_s.pump_area)
											Dim num53 As Double = t_s(num18).tbg_force - t_s(num18 - 1).tbg_force
											If t_s(num18).pump_psia_p <= p_s.pump_psia_bs Then
												t_s(num18).pump_psia_p = p_s.pump_psia_bs
												num63 += 16
												num20 = 2
											ElseIf t_s(num18).pump_psia_p >= t_s(num18).pump_psia_a Then
												t_s(num18).pump_psia_p = t_s(num18).pump_psia_a
												num20 = 3
												num9 = 1
											Else
												num47 = 1
											End If
											If num19 = 1 And num18 = 1 Then
												If p_s.iostat = 0 Then
													p_s.iostat = -8540
												End If
												GoTo IL_DBFB
											End If
											If num18 = 1 Then
												' The following expression was wrapped in a checked-expression
												t_s(num18).pump_displacement = -array5(num4) / pump_spring_con + array5(num4 - 1) * p_s.timestep_length + num52
												t_s(num18).pump_velocity = 1.0 / p_s.timestep_length * (t_s(num18).pump_displacement - t_s(p_s.num_timesteps).pump_displacement)
											Else
												' The following expression was wrapped in a checked-expression
												t_s(num18).pump_displacement = -array5(num4) / pump_spring_con + array5(num4 - 1) * p_s.timestep_length + num52
												t_s(num18).pump_velocity = 1.0 / p_s.timestep_length * (t_s(num18).pump_displacement - t_s(num18 - 1).pump_displacement)
											End If
											If num19 = 1 And num18 = 1 Then
												p_s.iostat = -8550
												GoTo IL_DBFB
											End If
											If num18 = 1 Then
												t_s(num18).tbg_force = t_s(p_s.num_timesteps).tbg_force + (t_s(num18).pump_psia_a - t_s(p_s.num_timesteps).pump_psia_a) * (t_t(p_s.num_tbg_tapers).tbg_area_id - r_t(p_s.num_rod_tapers).rod_area) - (array5(num4) - t_s(p_s.num_timesteps).pump_force)
											Else
												' The following expression was wrapped in a checked-expression
												' The following expression was wrapped in a checked-expression
												' The following expression was wrapped in a checked-expression
												t_s(num18).tbg_force = t_s(num18 - 1).tbg_force + (t_s(num18).pump_psia_a - t_s(num18 - 1).pump_psia_a) * (t_t(p_s.num_tbg_tapers).tbg_area_id - r_t(p_s.num_rod_tapers).rod_area) - (array5(num4) - t_s(num18 - 1).pump_force)
											End If
											t_s(num18).tbg_position = -t_s(num18).tbg_force / p_s.tbg_spring_con
											If num19 = 1 And num18 = 1 Then
												If p_s.iostat = 0 Then
													p_s.iostat = -8538
												End If
												GoTo IL_DBFB
											End If
											If num18 = 1 Then
												t_s(num18).tbg_velo = (t_s(num18).tbg_position - t_s(p_s.num_timesteps).tbg_position) / p_s.timestep_length
											Else
												' The following expression was wrapped in a checked-expression
												t_s(num18).tbg_velo = (t_s(num18).tbg_position - t_s(num18 - 1).tbg_position) / p_s.timestep_length
											End If
											Dim flag12 As Boolean = t_s(num18).pump_psia_p = p_s.pump_psia_bs And num20 = 2
											If False And num18 = 1 Then
												If p_s.iostat = 0 Then
													p_s.iostat = -8536
												End If
												GoTo IL_DBFB
											End If
											Dim flag13 As Boolean = t_s(num18).pump_psia_p = t_s(num18).pump_psia_a And num20 = 3 And num9 = 1
											If num47 = 1 Then
												If num18 = 1 And num19 = 1 Then
													If p_s.iostat = 0 Then
														p_s.iostat = -8535
													End If
													GoTo IL_DBFB
												End If
												If num18 = 1 Then
													num53 = t_s(num18).tbg_force - t_s(p_s.num_timesteps).tbg_force
												Else
													' The following expression was wrapped in a checked-expression
													num53 = t_s(num18).tbg_force - t_s(num18 - 1).tbg_force
												End If
											End If
											If num19 = 1 And num18 = 1 Then
												If p_s.iostat = 0 Then
													p_s.iostat = -8531
												End If
												GoTo IL_DBFB
											End If
											If num18 = 1 Then
												t_s(num18).tbg_position = t_s(num18).tbg_force / p_s.tbg_spring_con
												t_s(num18).tbg_position = -t_s(num18).tbg_position
												t_s(num18).tbg_velo = (t_s(num18).tbg_position - t_s(p_s.num_timesteps).tbg_position) / p_s.timestep_length
											Else
												t_s(num18).tbg_position = t_s(num18).tbg_force / p_s.tbg_spring_con
												t_s(num18).tbg_position = -t_s(num18).tbg_position
												t_s(num18).tbg_velo = (t_s(num18).tbg_position - t_s(num18 - 1).tbg_position) / p_s.timestep_length
											End If
											If True And CLng(num18) <= num5 Then
												If Not(num19 = 1 And num18 = 1) Then
													If num18 <> 1 Then
													End If
												End If
											End If
									End Select
								End While
								Dim num81 As Integer = 2
								Dim num82 As Integer = 1
								Dim num83 As Integer = 3920
								Dim num84 As Integer = 3928
								Dim vel_mot2 As Double
								Dim num86 As Double
								If p_s.vari_spm = 1 Then
									t_s(num18).p_r_force = array5(1) + CDbl(RSWIN_DESC.fPumpPRWeignt)
									t_s(num18).p_r_force = array5(1)
									Dim num85 As Integer
									Me.Calc_Pre_Torq(m_c, p_s, t_s, num19, num18, num26, num85, vel_mot2, num39)
									num86 = 1.3E-11
									If Math.Abs(p_s.vel_mot - t_s(num18).vel_mot) > num86 Then
										num37 = 1
										If num = 1 Then
											FileSystem.PrintLine(num2, New Object() { String.Concat(New String() { Conversions.ToString(num19), ",", Conversions.ToString(num18), ",", Conversions.ToString(Math.Abs(p_s.vel_mot - t_s(num18).vel_mot)), ",", Conversions.ToString(num86), ",", Conversions.ToString(p_s.vel_mot), ",", Conversions.ToString(t_s(num18).vel_mot), ",", Conversions.ToString(t_s(num18).vel_cr), ",", Conversions.ToString(t_s(num18).vel_mot / t_s(num18).vel_cr) }) })
										End If
										If num18 = 5 Then
											num18 = num18
										End If
									Else
										If num6 = 0 Then
											num6 = 1
										End If
										If num = 1 Then
											FileSystem.PrintLine(num2, New Object() { String.Concat(New String() { Conversions.ToString(num19), ",", Conversions.ToString(num18), ",", Conversions.ToString(Math.Abs(p_s.vel_mot - t_s(num18).vel_mot)), ",", Conversions.ToString(num86), ",", Conversions.ToString(p_s.vel_mot), ",", Conversions.ToString(t_s(num18).vel_mot), ",", Conversions.ToString(t_s(num18).vel_cr), ",", Conversions.ToString(t_s(num18).vel_mot / t_s(num18).vel_cr) }) })
											FileSystem.PrintLine(num2, New Object() { String.Concat(New String() { Conversions.ToString(num19), ",", Conversions.ToString(num18), ", flag_con_to_vari_spm_transition = ", Conversions.ToString(num6) }) })
										End If
										num30 += 1
										num37 = 0
										vel_mot2 = p_s.vel_mot
										Dim num87 As Double = t_s(num18).crank_angle
										If num20 = 6 Then
											num8 = 0
										End If
									End If
								End If
								If num26 = 0 Then
									num37 = 0
								End If
								If num37 = 0 And p_s.vari_spm = 1 Then
									If p_s.crank_angle_nu >= l_u(p_s.num_tstep_con).crank_angle Then
										num28 = 0
										t_s(num19).num_timesteps = num18
										p_s.num_timesteps = num18
									End If
								ElseIf num37 = 1 And p_s.vari_spm = 1 Then
									If num30 > p_s.max_timesteps Then
										If p_s.iostat = 0 Then
											p_s.iostat = -8533
										End If
										GoTo IL_DBFB
									End If
									Dim num87 As Double
									Dim num88 As Double
									num39 += 1
									If num18 = 1 Then
										' The following expression was wrapped in a unchecked-expression
										num87 = t_s(p_s.num_timesteps).crank_angle - 3.141592653589793 - 3.141592653589793
									Else
										num87 = t_s(num18 - 1).crank_angle
									End If
									num88 = 5E-07
									If num39 = 1 Then
										Dim num89 As Double = 0.0
										Dim num90 As Double = 0.0
										Dim crank_angle_nu As Double = p_s.crank_angle_nu
										Dim num91 As Double = p_s.vel_mot - t_s(num18).vel_mot
										If num30 <= 2 Then
											p_s.vel_mot = vel_mot2
										Else
											p_s.vel_mot = vel_mot
										End If
										Dim num85 As Integer = 1
										p_s.vel_mot *= 1.0 + num88 * CDbl(num85) * CDbl(num39)
										p_s.delta_theta_nu = p_s.vel_mot * p_s.timestep_length / p_s.ratio_gb / p_s.ratio_vb
										p_s.crank_angle_nu = p_s.delta_theta_nu + num87
									ElseIf num39 = 2 Then
										Dim crank_angle_nu As Double
										Dim num89 As Double = crank_angle_nu
										Dim num91 As Double
										Dim num90 As Double = num91
										crank_angle_nu = p_s.crank_angle_nu
										num91 = p_s.vel_mot - t_s(num18).vel_mot
										Dim num92 As Double = (num91 - num90) / (crank_angle_nu - num89)
										Dim num93 As Double = num90 - num92 * num89
										p_s.crank_angle_nu = -num93 / num92
										p_s.delta_theta_nu = p_s.crank_angle_nu - num87
										p_s.vel_mot = p_s.delta_theta_nu / p_s.timestep_length * p_s.ratio_gb * p_s.ratio_vb
									ElseIf num39 >= 3 Then
										Dim num89 As Double
										Dim num94 As Double = num89
										Dim num90 As Double
										Dim num95 As Double = num90
										Dim crank_angle_nu As Double
										num89 = crank_angle_nu
										Dim num91 As Double
										num90 = num91
										crank_angle_nu = p_s.crank_angle_nu
										num91 = p_s.vel_mot - t_s(num18).vel_mot
										array9(1) = num94
										array9(2) = num89
										array9(3) = crank_angle_nu
										array8(1) = num95
										array8(2) = num90
										array8(3) = num91
										Dim num79 As Integer = 0
										If array9(1) = array9(2) And array8(1) = array8(2) Then
											num79 = 12
										ElseIf array9(1) = array9(3) And array8(1) = array8(3) Then
											num79 = 13
										ElseIf array9(2) = array9(3) And array8(2) = array8(3) Then
											num79 = 23
										End If
										If num79 = 0 Then
											Me.parabola(array8, array9, num32, num33, num34)
											Dim flag14 As Boolean = num81 = 1 And num18 >= num83 And num18 <= num84 And num19 >= num82
											p_s.crank_angle_nu = num32 * 0.0 + num33 * 0.0 + num34
											p_s.delta_theta_nu = p_s.crank_angle_nu - num87
											p_s.vel_mot = p_s.delta_theta_nu / p_s.timestep_length * p_s.ratio_gb * p_s.ratio_vb
										Else
											If Not(num79 = 12 Or num79 = 13 Or num79 = 23) Then
												p_s.iostat = -8565
												GoTo IL_DBFB
											End If
											num37 = 0
											vel_mot2 = p_s.vel_mot
											num87 = t_s(num18).crank_angle
											If num20 = 6 Then
												num8 = 0
											End If
											If p_s.crank_angle_nu >= l_u(p_s.num_tstep_con).crank_angle Then
												num28 = 0
												t_s(num19).num_timesteps = num18
												p_s.num_timesteps = num18
											End If
											If num = 1 Then
												FileSystem.PrintLine(num2, New Object() { String.Concat(New String() { Conversions.ToString(num19), ",", Conversions.ToString(num18), ",", Conversions.ToString(Math.Abs(p_s.vel_mot - t_s(num18).vel_mot)), ",", Conversions.ToString(num86), ",", Conversions.ToString(p_s.vel_mot), ",", Conversions.ToString(t_s(num18).vel_mot), ",", Conversions.ToString(t_s(num18).vel_cr), ",", Conversions.ToString(t_s(num18).vel_mot / t_s(num18).vel_cr) }) })
												FileSystem.PrintLine(num2, New Object() { String.Concat(New String() { Conversions.ToString(num19), ",", Conversions.ToString(num18), ", flag_dup_pair = ", Conversions.ToString(num79) }) })
											End If
										End If
									End If
									Dim num35 As Integer
									Dim num36 As Integer
									If p_s.crank_angle_nu - l_u(1).crank_angle + p_s.delta_theta * 0.99 / p_s.delta_theta > 32000.0 Then
										num35 = p_s.num_tstep_con + 2
									Else
										' The following expression was wrapped in a unchecked-expression
										num35 = CInt(Math.Round(p_s.crank_angle_nu - l_u(1).crank_angle + p_s.delta_theta * 0.99 / p_s.delta_theta))
									End If
									num35 -= 1
									num36 = 1
									If num35 < 1 Then
										num35 = 1
									ElseIf num35 > p_s.num_tstep_con Then
										num35 = p_s.num_tstep_con - 1
									End If
									While num36 = 1
										' The following expression was wrapped in a checked-expression
										If p_s.crank_angle_nu <= l_u(1).crank_angle Then
											t_s(num18).p_r_position = l_u(p_s.num_tstep_con).p_r_position + (p_s.crank_angle_nu + 3.141592653589793 + 3.141592653589793 - l_u(p_s.num_tstep_con).crank_angle) / (l_u(1).crank_angle + 3.141592653589793 + 3.141592653589793 - l_u(p_s.num_tstep_con).crank_angle) * (l_u(1).p_r_position - l_u(p_s.num_tstep_con).p_r_position)
											t_s(num18).torq_fact = l_u(p_s.num_tstep_con).torq_fact + (p_s.crank_angle_nu + 3.141592653589793 + 3.141592653589793 - l_u(p_s.num_tstep_con).crank_angle) / (l_u(1).crank_angle + 3.141592653589793 + 3.141592653589793 - l_u(p_s.num_tstep_con).crank_angle) * (l_u(1).torq_fact - l_u(p_s.num_tstep_con).torq_fact)
											t_s(num18).crank_angle = p_s.crank_angle_nu
											num36 = 0
										ElseIf p_s.crank_angle_nu >= l_u(p_s.num_tstep_con).crank_angle Then
											t_s(num18).p_r_position = l_u(p_s.num_tstep_con).p_r_position + (p_s.crank_angle_nu - l_u(p_s.num_tstep_con).crank_angle) / (l_u(1).crank_angle + 3.141592653589793 + 3.141592653589793 - l_u(p_s.num_tstep_con).crank_angle) * (l_u(1).p_r_position - l_u(p_s.num_tstep_con).p_r_position)
											t_s(num18).torq_fact = l_u(p_s.num_tstep_con).torq_fact + (p_s.crank_angle_nu - l_u(p_s.num_tstep_con).crank_angle) / (l_u(1).crank_angle + 3.141592653589793 + 3.141592653589793 - l_u(p_s.num_tstep_con).crank_angle) * (l_u(1).torq_fact - l_u(p_s.num_tstep_con).torq_fact)
											t_s(num18).crank_angle = p_s.crank_angle_nu
											num36 = 0
										ElseIf p_s.crank_angle_nu >= l_u(num35).crank_angle And p_s.crank_angle_nu <= l_u(num35 + 1).crank_angle Then
											' The following expression was wrapped in a checked-expression
											' The following expression was wrapped in a checked-expression
											t_s(num18).p_r_position = l_u(num35).p_r_position + (p_s.crank_angle_nu - l_u(num35).crank_angle) * (l_u(num35 + 1).p_r_position - l_u(num35).p_r_position) / (l_u(num35 + 1).crank_angle - l_u(num35).crank_angle)
											t_s(num18).torq_fact = l_u(num35).torq_fact + (p_s.crank_angle_nu - l_u(num35).crank_angle) * (l_u(num35 + 1).torq_fact - l_u(num35).torq_fact) / (l_u(num35 + 1).crank_angle - l_u(num35).crank_angle)
											t_s(num18).crank_angle = p_s.crank_angle_nu
											num36 = 0
										Else
											' The following expression was wrapped in a checked-statement
											num35 += 1
										End If
									End While
								End If
								If p_s.vari_spm = 0 Then
									num37 = 0
								End If
								If num37 = 0 Then
									num38 = 0
								End If
							End While
							t_s(num18).p_r_force = array5(1) + CDbl(RSWIN_DESC.fPumpPRWeignt)
							t_s(num18).p_r_force = array5(1)
							If num18 = 1 Then
							End If
							Me.displacement_1_n += p_s.timestep_length * array5(2)
							If num19 = 1 And num18 = 1 Then
								t_s(p_s.num_timesteps).displacement_N_n = 0.0
							ElseIf num18 = 1 Then
								t_s(p_s.num_timesteps).displacement_N_n = num52
							Else
								' The following expression was wrapped in a checked-expression
								t_s(num18 - 1).displacement_N_n = num52
							End If
							num52 += p_s.timestep_length * array5(num4 - 1)
							t_s(num18).rod_bottom_velo = array5(num4 - 1)
							t_s(num18).pump_force = array5(num4)
							If num20 <> 1 AndAlso num20 <> 2 Then
								If num20 = 3 Then
									If num9 = 1 Then
										num10 = num25 - t_s(num18).pump_displacement
										num10 -= p_s.tbg_stretch_max
										num9 = 0
									End If
								Else
									If num20 = 5 Then
										p_s.iostat = -8564
										GoTo IL_DBFB
									End If
									If num20 <> 6 Then
										p_s.iostat = -8563
										GoTo IL_DBFB
									End If
								End If
							End If
							pump_displacement = t_s(num18).pump_displacement

						Dim obj28 As Object
						If ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj, 2, num4 - 1, 2, obj28, obj) Then
							Do
								r_e(Conversions.ToInteger(Conversion.Int(Operators.DivideObject(obj, 2)))).old_velocity = array5(Conversions.ToInteger(obj))
							Loop While ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj, obj28, obj)
						End If
						Dim obj29 As Object
						If ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj, 3, num4 - 2, 2, obj29, obj) Then
							Do
								r_e(Conversions.ToInteger(Conversion.Int(Operators.DivideObject(obj, 2)))).old_force = array5(Conversions.ToInteger(obj))
							Loop While ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj, obj29, obj)
						End If

							If num19 = 1 And num18 = 1 Then
								Dim num96 As Double = t_s(num18).pump_force - t_s(p_s.num_timesteps).pump_force
								Dim num53 As Double = t_s(num18).tbg_force - t_s(p_s.num_timesteps).tbg_force
							ElseIf num18 = 1 Then
								Dim num96 As Double = t_s(num18).pump_force - t_s(p_s.num_timesteps).pump_force
								Dim num53 As Double = t_s(num18).tbg_force - t_s(p_s.num_timesteps).tbg_force
							Else
								' The following expression was wrapped in a checked-expression
								Dim num96 As Double = t_s(num18).pump_force - t_s(num18 - 1).pump_force
								Dim num53 As Double = t_s(num18).tbg_force - t_s(num18 - 1).tbg_force
							End If
							If num20 <> 1 AndAlso num20 <> 2 AndAlso num20 <> 3 Then
								If num20 = 5 Then
									p_s.iostat = -8562
									GoTo IL_DBFB
								End If
								If num20 <> 6 Then
									p_s.iostat = -8561
									GoTo IL_DBFB
								End If
							End If
							If Not(num19 = 1 And num18 = 1) Then
								If num18 = 1 Then
									Dim num97 As Double = (t_s(num18).pump_psia_a - t_s(p_s.num_timesteps).pump_psia_a) * (t_t(p_s.num_tbg_tapers).tbg_area_id - r_t(p_s.num_rod_tapers).rod_area)
								Else
									' The following expression was wrapped in a checked-expression
									Dim num97 As Double = (t_s(num18).pump_psia_a - t_s(num18 - 1).pump_psia_a) * (t_t(p_s.num_tbg_tapers).tbg_area_id - r_t(p_s.num_rod_tapers).rod_area)
								End If
							End If
							t_s(num18).fluid_inertia_force = t_s(num18).pump_psia_a * (t_t(p_s.num_tbg_tapers).tbg_area_id - r_t(p_s.num_rod_tapers).rod_area)
							Dim downhole_position As Double
							Dim num98 As Double = downhole_position + array5(num4 - 1) * p_s.timestep_length
							If num18 >= 2226 Then
							End If
							If num19 >= 1 Then
								If Not(num18 = 1 And num19 = 1) Then
									If num18 = 1 Then
										Dim vel_mot3 As Double = t_s(p_s.num_timesteps).vel_mot
									Else
										' The following expression was wrapped in a checked-expression
										Dim vel_mot3 As Double = t_s(num18 - 1).vel_mot
									End If
								End If
								If Not(num18 = 1 And num19 = 1) Then
									If num18 = 1 Then
										Dim num99 As Double = t_s(num18).pump_displacement - t_s(num18).tbg_position - t_s(p_s.num_timesteps).pump_displacement + t_s(p_s.num_timesteps).tbg_position
									Else
										' The following expression was wrapped in a checked-expression
										' The following expression was wrapped in a checked-expression
										Dim num99 As Double = t_s(num18).pump_displacement - t_s(num18).tbg_position - t_s(num18 - 1).pump_displacement + t_s(num18 - 1).tbg_position
									End If
								End If
							End If
							If num22 <> 0 Then
								obj = 1
								Dim cart_coord_type As TEImpred.cart_coord_type
								If r_e(Conversions.ToInteger(obj)).tan.z < 1.0 Or r_e(Conversions.ToInteger(obj)).dog > 0.0 Then
									Dim num100 As Double = Math.Sin(0.5 * r_e(Conversions.ToInteger(obj)).dog) * (r_e(Conversions.ToInteger(obj)).old_force + t_s(num18).p_r_force)
									cart_coord_type.x = num100 * r_e(Conversions.ToInteger(obj)).nor.x
									cart_coord_type.y = num100 * r_e(Conversions.ToInteger(obj)).nor.y
									cart_coord_type.z = num100 * r_e(Conversions.ToInteger(obj)).nor.z
									cart_coord_type2.x = cart_coord_type.x + r_e(Conversions.ToInteger(obj)).sfg.x
									cart_coord_type2.y = cart_coord_type.y + r_e(Conversions.ToInteger(obj)).sfg.y
									cart_coord_type2.z = cart_coord_type.z + r_e(Conversions.ToInteger(obj)).sfg.z
									Dim num101 As Double = Math.Sqrt(cart_coord_type2.x * cart_coord_type2.x + cart_coord_type2.y * cart_coord_type2.y + cart_coord_type2.z * cart_coord_type2.z)
									Conversions.ToBoolean(Operators.AndObject(Not RSWIN_DESC.bBETA And RSWIN_DESC.bWriteCSVFIles And num18 >= 2 And num19 = Me.m_p_s.num_cycles, Operators.CompareObjectGreater(obj, Me.m_p_s.num_rod_elements - 10, False)))
									If num101 > r_e(Conversions.ToInteger(obj)).max_sf_total Then
										r_e(Conversions.ToInteger(obj)).max_sf_total = num101
									End If
									Dim num102 As Double
									If r_e(Conversions.ToInteger(obj)).old_velocity <> 0.0 Then
										r_e(Conversions.ToInteger(obj)).friction_force = r_e(Conversions.ToInteger(obj)).old_velocity / Math.Abs(r_e(Conversions.ToInteger(obj)).old_velocity) * num101 * r_e(Conversions.ToInteger(obj)).friction_coef
										num102 = r_e(Conversions.ToInteger(obj)).old_velocity * r_e(Conversions.ToInteger(obj)).mass / (32.17405 * p_s.timestep_length)
									Else
										num102 = t_s(num18).p_r_force - r_e(Conversions.ToInteger(obj)).gravity_force - r_e(Conversions.ToInteger(obj)).old_force
										If num102 <> 0.0 Then
											r_e(Conversions.ToInteger(obj)).friction_force = num101 * r_e(Conversions.ToInteger(obj)).friction_coef * num102 / Math.Abs(num102)
										Else
											r_e(Conversions.ToInteger(obj)).friction_force = 0.0
										End If
									End If
									If Math.Abs(r_e(Conversions.ToInteger(obj)).friction_force) > Math.Abs(num102) Then
										r_e(Conversions.ToInteger(obj)).friction_force = num102
									End If
								End If
								Dim obj30 As Object
								If ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj, 2, p_s.num_rod_elements - 1, 1, obj30, obj) Then
									While Not RSWIN_DESC.bAbortRun
										If r_e(Conversions.ToInteger(obj)).tan.z < 1.0 Or r_e(Conversions.ToInteger(obj)).dog > 0.0 Then
											Dim num100 As Double = Math.Sin(0.5 * r_e(Conversions.ToInteger(obj)).dog) * (r_e(Conversions.ToInteger(obj)).old_force + r_e(Conversions.ToInteger(Operators.SubtractObject(obj, 1))).old_force)
											cart_coord_type.x = num100 * r_e(Conversions.ToInteger(obj)).nor.x
											cart_coord_type.y = num100 * r_e(Conversions.ToInteger(obj)).nor.y
											cart_coord_type.z = num100 * r_e(Conversions.ToInteger(obj)).nor.z
											cart_coord_type2.x = cart_coord_type.x + r_e(Conversions.ToInteger(obj)).sfg.x
											cart_coord_type2.y = cart_coord_type.y + r_e(Conversions.ToInteger(obj)).sfg.y
											cart_coord_type2.z = cart_coord_type.z + r_e(Conversions.ToInteger(obj)).sfg.z
											Dim num101 As Double = Math.Sqrt(cart_coord_type2.x * cart_coord_type2.x + cart_coord_type2.y * cart_coord_type2.y + cart_coord_type2.z * cart_coord_type2.z)
											Conversions.ToBoolean(Operators.AndObject(Not RSWIN_DESC.bBETA And RSWIN_DESC.bWriteCSVFIles And num18 >= 2 And num19 = Me.m_p_s.num_cycles, Operators.CompareObjectGreater(obj, Me.m_p_s.num_rod_elements - 10, False)))
											If num101 > r_e(Conversions.ToInteger(obj)).max_sf_total Then
												r_e(Conversions.ToInteger(obj)).max_sf_total = num101
											End If
											Dim num102 As Double
											If r_e(Conversions.ToInteger(obj)).old_velocity <> 0.0 Then
												r_e(Conversions.ToInteger(obj)).friction_force = r_e(Conversions.ToInteger(obj)).old_velocity / Math.Abs(r_e(Conversions.ToInteger(obj)).old_velocity) * num101 * r_e(Conversions.ToInteger(obj)).friction_coef
												num102 = r_e(Conversions.ToInteger(obj)).old_velocity * r_e(Conversions.ToInteger(obj)).mass / (32.17405 * p_s.timestep_length)
											Else
												num102 = r_e(Conversions.ToInteger(Operators.SubtractObject(obj, 1))).old_force - r_e(Conversions.ToInteger(obj)).gravity_force - r_e(Conversions.ToInteger(obj)).old_force
												If num102 <> 0.0 Then
													r_e(Conversions.ToInteger(obj)).friction_force = num101 * r_e(Conversions.ToInteger(obj)).friction_coef * num102 / Math.Abs(num102)
												Else
													r_e(Conversions.ToInteger(obj)).friction_force = 0.0
												End If
											End If
											If Math.Abs(r_e(Conversions.ToInteger(obj)).friction_force) > Math.Abs(num102) Then
												r_e(Conversions.ToInteger(obj)).friction_force = num102
											End If
										End If
										If Not ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj, obj30, obj) Then
											GoTo IL_6C32
										End If
									End While
									p_s.iostat = -1
									Me.m_RunStatus = p_s.iostat
									GoTo IL_DBFB
								End If
								IL_6C32:
								obj = p_s.num_rod_elements
								If r_e(Conversions.ToInteger(obj)).tan.z < 1.0 Or r_e(Conversions.ToInteger(obj)).dog > 0.0 Then
									Dim num100 As Double = Math.Sin(0.5 * r_e(Conversions.ToInteger(obj)).dog) * (t_s(num18).pump_force + r_e(Conversions.ToInteger(Operators.SubtractObject(obj, 1))).old_force)
									cart_coord_type.x = num100 * r_e(Conversions.ToInteger(obj)).nor.x
									cart_coord_type.y = num100 * r_e(Conversions.ToInteger(obj)).nor.y
									cart_coord_type.z = num100 * r_e(Conversions.ToInteger(obj)).nor.z
									cart_coord_type2.x = cart_coord_type.x + r_e(Conversions.ToInteger(obj)).sfg.x
									cart_coord_type2.y = cart_coord_type.y + r_e(Conversions.ToInteger(obj)).sfg.y
									cart_coord_type2.z = cart_coord_type.z + r_e(Conversions.ToInteger(obj)).sfg.z
									Dim num101 As Double = Math.Sqrt(cart_coord_type2.x * cart_coord_type2.x + cart_coord_type2.y * cart_coord_type2.y + cart_coord_type2.z * cart_coord_type2.z)
									Conversions.ToBoolean(Operators.AndObject(Not RSWIN_DESC.bBETA And RSWIN_DESC.bWriteCSVFIles And num18 >= 2 And num19 = Me.m_p_s.num_cycles, Operators.CompareObjectGreater(obj, Me.m_p_s.num_rod_elements - 10, False)))
									If num101 > r_e(Conversions.ToInteger(obj)).max_sf_total Then
										r_e(Conversions.ToInteger(obj)).max_sf_total = num101
									End If
									Dim num102 As Double
									If r_e(Conversions.ToInteger(obj)).old_velocity <> 0.0 Then
										r_e(Conversions.ToInteger(obj)).friction_force = r_e(Conversions.ToInteger(obj)).old_velocity / Math.Abs(r_e(Conversions.ToInteger(obj)).old_velocity) * num101 * r_e(Conversions.ToInteger(obj)).friction_coef
										num102 = r_e(Conversions.ToInteger(obj)).old_velocity * r_e(Conversions.ToInteger(obj)).mass / (32.17405 * p_s.timestep_length)
									Else
										num102 = r_e(Conversions.ToInteger(Operators.SubtractObject(obj, 1))).old_force - r_e(Conversions.ToInteger(obj)).gravity_force - t_s(num18).pump_force
										If num102 <> 0.0 Then
											r_e(Conversions.ToInteger(obj)).friction_force = num101 * r_e(Conversions.ToInteger(obj)).friction_coef * num102 / Math.Abs(num102)
										Else
											r_e(Conversions.ToInteger(obj)).friction_force = 0.0
										End If
									End If
									If Math.Abs(r_e(Conversions.ToInteger(obj)).friction_force) > Math.Abs(num102) Then
										r_e(Conversions.ToInteger(obj)).friction_force = num102
									End If
								End If
							End If
							If p_s.i_downhole_dyno <> 0 Then
								If num18 = 1 Then
									If num19 = 1 Then
										t_s(num18).downhole_position = 0.0 + p_s.timestep_length * r_e(p_s.i_downhole_dyno).old_velocity
									Else
										t_s(num18).downhole_position = t_s(p_s.num_timesteps).downhole_position + p_s.timestep_length * r_e(p_s.i_downhole_dyno).old_velocity
									End If
								Else
									' The following expression was wrapped in a checked-expression
									t_s(num18).downhole_position = t_s(num18 - 1).downhole_position + p_s.timestep_length * r_e(p_s.i_downhole_dyno).old_velocity
								End If
								downhole_position = t_s(num18).downhole_position
								If p_s.i_downhole_dyno = 1 Then
									t_s(num18).downhole_force = r_e(1).old_force
								ElseIf p_s.i_downhole_dyno = p_s.num_rod_elements Then
									t_s(num18).downhole_force = t_s(num18).pump_force
								Else
									t_s(num18).downhole_force = r_e(p_s.i_downhole_dyno).old_force
								End If
							Else
								t_s(num18).downhole_position = t_s(num18).p_r_position / 12.0
								t_s(num18).downhole_force = t_s(num18).p_r_force
							End If
							If num19 = p_s.num_cycles Then
								If t_s(num18).p_r_force > p_s.max_p_r_force Then
									p_s.max_p_r_force = t_s(num18).p_r_force
								ElseIf t_s(num18).p_r_force < p_s.min_p_r_force Then
									p_s.min_p_r_force = t_s(num18).p_r_force
								End If
								If t_s(num18).pump_force > p_s.max_pump_force Then
									p_s.max_pump_force = t_s(num18).pump_force
								ElseIf t_s(num18).pump_force < p_s.min_pump_force Then
									p_s.min_pump_force = t_s(num18).pump_force
								End If
								If p_s.i_downhole_dyno = p_s.num_rod_elements Then
									If t_s(num18).downhole_force > p_s.max_d_h_force Then
										p_s.max_d_h_force = p_s.max_pump_force
									ElseIf t_s(num18).downhole_force < p_s.min_d_h_force Then
										p_s.min_d_h_force = p_s.min_pump_force
									End If
								ElseIf t_s(num18).downhole_force > p_s.max_d_h_force Then
									p_s.max_d_h_force = t_s(num18).downhole_force
								ElseIf t_s(num18).downhole_force < p_s.min_d_h_force Then
									p_s.min_d_h_force = t_s(num18).downhole_force
								End If
								If p_s.vari_spm = 1 Then
									t_s(num18).p_r_force_permissible = (Me.m_torq_gb_rating + t_s(num18).torq_cwt - 0.5 * CDbl(Me.m_Irot) * t_s(num18).acc_beam * p_s.inert_beam / 32.17405) * p_s.eff_pu_func / t_s(num18).torq_fact * 12.0 + p_s.force_su - p_s.inert_beam * t_s(num18).acc_cr / p_s.API_len_A / 32.17405
								Else
									t_s(num18).p_r_force_permissible = Me.m_torq_gb_rating + p_s.force_su
								End If
								Dim obj31 As Object
								If ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj, 3, num4 - 2, 2, obj31, obj) Then
									Do
										Dim num103 As Integer = 1
										Dim num104 As Integer = 1
										Dim num_fluid_elem As Integer = p_s.num_fluid_elem
										Dim num105 As Integer = num104
										While num105 <= num_fluid_elem AndAlso f_e(num105).m_d <= r_e(Conversions.ToInteger(Conversion.Int(Operators.DivideObject(obj, 2)))).m_d
											num103 += 1
											num105 += 1
										End While
										Application.DoEvents()
										If array5(Conversions.ToInteger(obj)) > r_e(Conversions.ToInteger(Conversion.Int(Operators.DivideObject(obj, 2)))).max_force Then
											If RSWIN_DESC.rst.IncludeFluidInertia <> 0S Then
												r_e(Conversions.ToInteger(Conversion.Int(Operators.DivideObject(obj, 2)))).max_force = array5(Conversions.ToInteger(obj)) + (r_e(Conversions.ToInteger(Operators.SubtractObject(Conversion.Int(Operators.DivideObject(obj, 2)), 1))).rod_area - r_e(Conversions.ToInteger(Conversion.Int(Operators.DivideObject(obj, 2)))).rod_area) * f_e(num103).psia_flu
											Else
												r_e(Conversions.ToInteger(Conversion.Int(Operators.DivideObject(obj, 2)))).max_force = array5(Conversions.ToInteger(obj))
											End If
										End If
										If array5(Conversions.ToInteger(obj)) < r_e(Conversions.ToInteger(Conversion.Int(Operators.DivideObject(obj, 2)))).min_force Then
											If RSWIN_DESC.rst.IncludeFluidInertia <> 0S Then
												r_e(Conversions.ToInteger(Conversion.Int(Operators.DivideObject(obj, 2)))).min_force = array5(Conversions.ToInteger(obj)) + (r_e(Conversions.ToInteger(Operators.SubtractObject(Conversion.Int(Operators.DivideObject(obj, 2)), 1))).rod_area - r_e(Conversions.ToInteger(Conversion.Int(Operators.DivideObject(obj, 2)))).rod_area) * f_e(num103).psia_flu
											Else
												r_e(Conversions.ToInteger(Conversion.Int(Operators.DivideObject(obj, 2)))).min_force = array5(Conversions.ToInteger(obj))
											End If
										End If
									Loop While ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj, obj31, obj)
								End If
								obj = num4
								If array5(Conversions.ToInteger(obj)) > r_e(Conversions.ToInteger(Conversion.Int(Operators.DivideObject(obj, 2)))).max_force Then
									r_e(Conversions.ToInteger(Conversion.Int(Operators.DivideObject(obj, 2)))).max_force = array5(Conversions.ToInteger(obj))
								End If
								If array5(Conversions.ToInteger(obj)) < r_e(Conversions.ToInteger(Conversion.Int(Operators.DivideObject(obj, 2)))).min_force Then
									r_e(Conversions.ToInteger(Conversion.Int(Operators.DivideObject(obj, 2)))).min_force = array5(Conversions.ToInteger(obj))
								End If
							End If
							If p_s.vari_spm = 0 And num18 = p_s.num_timesteps Then
								num28 = 0
							End If
							If num28 = 0 Then
								num29 = 0
							End If
							If RSWIN_DESC.bDoDeviatedInfiniteLoopCheck AndAlso num31 >= p_s.num_timesteps Then
								num29 = 0
							End If

					End While
					Debug.WriteLine(" ")
					Application.DoEvents()

						If p_s.ratio_vb_converged = 0 And p_s.mot_pts_flag = 20 Then
							p_s.period = CDbl(p_s.num_timesteps) * p_s.timestep_length
							p_s.hp_mot_pr_i_cyc = 0.0
							Dim obj32 As Object
							If ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj, 1, p_s.num_timesteps - 1, 1, obj32, obj) Then
								Do
									p_s.hp_mot_pr_i_cyc += (t_s(Conversions.ToInteger(obj)).p_r_force + t_s(Conversions.ToInteger(Operators.AddObject(obj, 1))).p_r_force) / 2.0 * (t_s(Conversions.ToInteger(Operators.AddObject(obj, 1))).p_r_position - t_s(Conversions.ToInteger(obj)).p_r_position)
								Loop While ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj, obj32, obj)
							End If
							p_s.hp_mot_pr_i_cyc += (t_s(p_s.num_timesteps).p_r_force + t_s(1).p_r_force) / 2.0 * (t_s(1).p_r_position - t_s(p_s.num_timesteps).p_r_position)
							p_s.hp_mot_pr_i_cyc = p_s.hp_mot_pr_i_cyc * 60.0 / 12.0 / 33000.0 / p_s.period
							Dim num106 As Double = 0.0
							Debug.WriteLine(String.Concat(New String() { Conversions.ToString(p_s.hp_mot_pr_i_cyc), " , ", Conversions.ToString(m_c(1).hp_mot), " , ", Conversions.ToString(m_c(p_s.mot_pts).hp_mot) }))
							Dim obj33 As Object
							If ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj, 1, p_s.mot_pts - 1, 1, obj33, obj) Then
								Do
									Debug.WriteLine(m_c(Conversions.ToInteger(obj)).hp_mot)
									If p_s.hp_mot_pr_i_cyc <= m_c(1).hp_mot Then
										p_s.ratio_tot = m_c(1).vel_mot * 60.0 / 2.0 / 3.141592653589793 / p_s.strokes_per_min
										num106 = p_s.ratio_tot / p_s.ratio_gb
									ElseIf p_s.hp_mot_pr_i_cyc >= m_c(p_s.mot_pts).hp_mot Then
										p_s.ratio_tot = m_c(p_s.mot_pts).vel_mot * 60.0 / 2.0 / 3.141592653589793 / p_s.strokes_per_min
										num106 = p_s.ratio_tot / p_s.ratio_gb
									ElseIf p_s.hp_mot_pr_i_cyc >= m_c(Conversions.ToInteger(obj)).hp_mot And p_s.hp_mot_pr_i_cyc < m_c(Conversions.ToInteger(Operators.AddObject(obj, 1))).hp_mot Then
										Dim num107 As Double = (p_s.hp_mot_pr_i_cyc - m_c(Conversions.ToInteger(Operators.AddObject(obj, 1))).hp_mot) / (m_c(Conversions.ToInteger(obj)).hp_mot - m_c(Conversions.ToInteger(Operators.AddObject(obj, -1))).hp_mot)
										Dim num108 As Double = num107 * (m_c(Conversions.ToInteger(obj)).vel_mot - m_c(Conversions.ToInteger(Operators.AddObject(obj, 1))).vel_mot) + m_c(Conversions.ToInteger(Operators.AddObject(obj, 1))).vel_mot
										p_s.ratio_tot = num108 * 60.0 / 2.0 / 3.141592653589793 / p_s.strokes_per_min
										num106 = p_s.ratio_tot / p_s.ratio_gb
										obj = p_s.mot_pts - 1
									End If
									If num106 <> 0.0 Then
										Debug.WriteLine("Diff: " + Conversions.ToString(Math.Abs(num106 - p_s.ratio_vb)))
									End If
									If Math.Abs(num106 - p_s.ratio_vb) <= 0.005 Then
										p_s.ratio_vb_converged = 1
									End If
								Loop While ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj, obj33, obj)
							End If
							p_s.ratio_vb = p_s.ratio_tot / p_s.ratio_gb
						End If

					If p_s.fluid_solution = 0 Or p_s.fluid_solution = -1 Then
						If p_s.vari_spm = 1 And num19 = p_s.num_cycles - 1 And p_s.ratio_vb_converged = 0 Then
							p_s.num_cycles += 1
						Else
							If p_s.vari_spm = 1 And num19 = p_s.num_cycles And p_s.ratio_vb_converged = 0 Then
								p_s.iostat = -8527
								GoTo IL_DBFB
							End If
							If p_s.vari_spm <> 0 AndAlso p_s.ratio_vb_converged <> 1 AndAlso num19 >= p_s.num_cycles - 1 Then
								p_s.iostat = -8526
								GoTo IL_DBFB
							End If
						End If
					ElseIf p_s.fluid_solution = -1 Then
						If p_s.vari_spm = 1 And num19 = p_s.num_cycles And p_s.ratio_vb_converged = 0 Then
							p_s.num_cycles += 1
						ElseIf p_s.vari_spm = 1 And num19 = p_s.num_cycles And p_s.ratio_vb_converged = 0 Then
							p_s.iostat = -8570
							GoTo IL_DBFB
						End If
					End If
					Dim num109 As Integer = 0

						If num109 = 1 And num19 <= p_s.num_cycles Then
							Debug.WriteLine("")
							Debug.WriteLine("dynamic pump-card plotting")
							Debug.WriteLine("i_cyc,i_step,Ppump,Fpump")
							Dim obj34 As Object
							If ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj, 1, p_s.num_timesteps, 1, obj34, obj) Then
								Do
									Debug.WriteLine(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Conversions.ToString(num19) + ",", obj), ","), t_s(Conversions.ToInteger(obj)).pump_displacement * 12.0), ","), t_s(Conversions.ToInteger(obj)).pump_force))
								Loop While ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj, obj34, obj)
							End If
							Debug.WriteLine("i_cyc,i_step,Ppump,Fpump")
							Debug.WriteLine("dynamic pump-card plotting")
							Debug.WriteLine("")
						End If
						If num19 = p_s.num_cycles Then
							If t_s(p_s.num_cycles).num_timesteps = -1 And p_s.vari_spm = 1 Then
								t_s(p_s.num_cycles).num_timesteps = p_s.num_timesteps
							End If
							r_e(p_s.num_rod_elements).min_force = p_s.min_pump_force
							Dim num110 As Integer = 0
							If num110 = 1 Then
								Debug.WriteLine(" ")
								Debug.WriteLine("n, MD, BuckTendBuoy, FminBuoy, mat'l, poisson, PHydTbg, Ar")
							End If
							If flag3 Then
								Debug.WriteLine(" ")
								Debug.WriteLine(" ")
								Debug.WriteLine(" BEFORE  =================  ")
								Dim obj35 As Object
								If ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj, 1, p_s.num_rod_elements - 2, 1, obj35, obj) Then
									Do
										Debug.WriteLine(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(obj, " , "), r_e(Conversions.ToInteger(obj)).m_d), " , "), r_e(Conversions.ToInteger(obj)).min_force), " , "), r_e(Conversions.ToInteger(obj)).max_force))
									Loop While ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj, obj35, obj)
								End If
								If r_e(1).max_force < r_e(2).max_force And p_s.num_rod_elements >= 3 Then
									If r_e(3).max_force <> 0.0 Then
										r_e(1).max_force = r_e(2).max_force * (r_e(2).max_force / r_e(3).max_force)
										r_e(1).min_force = r_e(2).min_force * (r_e(2).min_force / r_e(3).min_force)
									Else
										r_e(1).max_force = r_e(2).max_force + (r_e(2).max_force - r_e(3).max_force)
										r_e(1).min_force = r_e(2).min_force + (r_e(2).min_force - r_e(3).min_force)
									End If
								End If
								Dim obj36 As Object
								If ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj, 1, p_s.num_rod_elements - 3, 1, obj36, obj) Then
									Do
										Dim flag15 As Boolean = False
										If Conversions.ToBoolean(Operators.AndObject(flag4, Operators.CompareObjectLess(obj, p_s.num_rod_elements - 4, False))) Then
											' The following expression was wrapped in a checked-expression
											Dim flag16 As Boolean = ((RODUTIL.IsSteel(r_e(Conversions.ToInteger(obj)).Grade) Or If((-If((CUSTOMRG.IsOtherSteel(r_e(Conversions.ToInteger(obj)).Grade) > False), 1, 0)), 1, 0)) And (RODUTIL.IsSteel(r_e(Conversions.ToInteger(Operators.AddObject(obj, 1))).Grade) Or If((-If((CUSTOMRG.IsOtherSteel(r_e(Conversions.ToInteger(Operators.AddObject(obj, 1))).Grade) > False), 1, 0)), 1, 0)) And (RODUTIL.IsSteel(r_e(Conversions.ToInteger(Operators.AddObject(obj, 2))).Grade) Or If((-If((CUSTOMRG.IsOtherSteel(r_e(Conversions.ToInteger(Operators.AddObject(obj, 2))).Grade) > False), 1, 0)), 1, 0)) And (RODUTIL.IsSteel(r_e(Conversions.ToInteger(Operators.AddObject(obj, 3))).Grade) Or If((-If((CUSTOMRG.IsOtherSteel(r_e(Conversions.ToInteger(Operators.AddObject(obj, 3))).Grade) > False), 1, 0)), 1, 0)) And (RODUTIL.IsSteel(r_e(Conversions.ToInteger(Operators.AddObject(obj, 4))).Grade) Or If((-If((CUSTOMRG.IsOtherSteel(r_e(Conversions.ToInteger(Operators.AddObject(obj, 4))).Grade) > False), 1, 0)), 1, 0))) <> 0 OrElse (RODUTIL.IsFG(CShort(r_e(Conversions.ToInteger(obj)).Grade)) Or CUSTOMRG.IsOtherFG(r_e(Conversions.ToInteger(obj)).Grade)) And (RODUTIL.IsFG(CShort(r_e(Conversions.ToInteger(Operators.AddObject(obj, 1))).Grade)) Or CUSTOMRG.IsOtherFG(r_e(Conversions.ToInteger(Operators.AddObject(obj, 1))).Grade)) And (RODUTIL.IsFG(CShort(r_e(Conversions.ToInteger(Operators.AddObject(obj, 2))).Grade)) Or CUSTOMRG.IsOtherFG(r_e(Conversions.ToInteger(Operators.AddObject(obj, 2))).Grade)) And (RODUTIL.IsFG(CShort(r_e(Conversions.ToInteger(Operators.AddObject(obj, 3))).Grade)) Or CUSTOMRG.IsOtherFG(r_e(Conversions.ToInteger(Operators.AddObject(obj, 3))).Grade)) And (RODUTIL.IsFG(CShort(r_e(Conversions.ToInteger(Operators.AddObject(obj, 4))).Grade)) Or CUSTOMRG.IsOtherFG(r_e(Conversions.ToInteger(Operators.AddObject(obj, 4))).Grade))
											If flag16 Then
												If(r_e(Conversions.ToInteger(obj)).max_force < r_e(Conversions.ToInteger(Operators.AddObject(obj, 1))).max_force And r_e(Conversions.ToInteger(Operators.AddObject(obj, 2))).max_force > r_e(Conversions.ToInteger(Operators.AddObject(obj, 3))).max_force) Or (r_e(Conversions.ToInteger(obj)).max_force > r_e(Conversions.ToInteger(Operators.AddObject(obj, 1))).max_force And r_e(Conversions.ToInteger(Operators.AddObject(obj, 2))).max_force < r_e(Conversions.ToInteger(Operators.AddObject(obj, 3))).max_force) Then
													If r_e(Conversions.ToInteger(obj)).max_force > r_e(Conversions.ToInteger(Operators.AddObject(obj, 3))).max_force Then
														Dim num111 As Single = CSng(((r_e(Conversions.ToInteger(obj)).max_force - r_e(Conversions.ToInteger(Operators.AddObject(obj, 3))).max_force) / 3.0))
														Dim num112 As Single = CSng((r_e(Conversions.ToInteger(obj)).max_force - CDbl(num111)))
														Dim num113 As Single = num112 - num111
														r_e(Conversions.ToInteger(Operators.AddObject(obj, 1))).max_force = CDbl(num112)
														r_e(Conversions.ToInteger(Operators.AddObject(obj, 2))).max_force = CDbl(num113)
													Else
														Dim num111 As Single = CSng(((r_e(Conversions.ToInteger(Operators.AddObject(obj, 3))).max_force - r_e(Conversions.ToInteger(obj)).max_force) / 3.0))
														Dim num112 As Single = CSng((r_e(Conversions.ToInteger(Operators.AddObject(obj, 3))).max_force - CDbl(num111)))
														Dim num113 As Single = num112 - num111
														r_e(Conversions.ToInteger(Operators.AddObject(obj, 2))).max_force = CDbl(num112)
														r_e(Conversions.ToInteger(Operators.AddObject(obj, 1))).max_force = CDbl(num113)
													End If
													flag15 = True
												End If
												If(r_e(Conversions.ToInteger(obj)).min_force < r_e(Conversions.ToInteger(Operators.AddObject(obj, 1))).min_force And r_e(Conversions.ToInteger(Operators.AddObject(obj, 2))).min_force > r_e(Conversions.ToInteger(Operators.AddObject(obj, 3))).min_force) Or (r_e(Conversions.ToInteger(obj)).min_force > r_e(Conversions.ToInteger(Operators.AddObject(obj, 1))).min_force And r_e(Conversions.ToInteger(Operators.AddObject(obj, 2))).min_force < r_e(Conversions.ToInteger(Operators.AddObject(obj, 3))).min_force) Then
													If r_e(Conversions.ToInteger(obj)).min_force > r_e(Conversions.ToInteger(Operators.AddObject(obj, 3))).min_force Then
														Dim num114 As Single = CSng(((r_e(Conversions.ToInteger(obj)).min_force - r_e(Conversions.ToInteger(Operators.AddObject(obj, 3))).min_force) / 3.0))
														Dim num115 As Single = CSng((r_e(Conversions.ToInteger(obj)).min_force - CDbl(num114)))
														Dim num116 As Single = num115 - num114
														r_e(Conversions.ToInteger(Operators.AddObject(obj, 1))).min_force = CDbl(num115)
														r_e(Conversions.ToInteger(Operators.AddObject(obj, 2))).min_force = CDbl(num116)
													Else
														Dim num114 As Single = CSng(((r_e(Conversions.ToInteger(Operators.AddObject(obj, 3))).min_force - r_e(Conversions.ToInteger(obj)).min_force) / 3.0))
														Dim num115 As Single = CSng((r_e(Conversions.ToInteger(Operators.AddObject(obj, 3))).min_force - CDbl(num114)))
														Dim num116 As Single = num115 - num114
														r_e(Conversions.ToInteger(Operators.AddObject(obj, 2))).min_force = CDbl(num115)
														r_e(Conversions.ToInteger(Operators.AddObject(obj, 1))).min_force = CDbl(num116)
													End If
													flag15 = True
												End If
												If flag15 Then
													obj = Operators.AddObject(obj, 2)
												End If
											End If
										ElseIf Not flag15 Then
											' The following expression was wrapped in a checked-expression
											Dim flag16 As Boolean = ((RODUTIL.IsSteel(r_e(Conversions.ToInteger(obj)).Grade) Or If((-If((CUSTOMRG.IsOtherSteel(r_e(Conversions.ToInteger(obj)).Grade) > False), 1, 0)), 1, 0)) And (RODUTIL.IsSteel(r_e(Conversions.ToInteger(Operators.AddObject(obj, 1))).Grade) Or If((-If((CUSTOMRG.IsOtherSteel(r_e(Conversions.ToInteger(Operators.AddObject(obj, 1))).Grade) > False), 1, 0)), 1, 0)) And (RODUTIL.IsSteel(r_e(Conversions.ToInteger(Operators.AddObject(obj, 2))).Grade) Or If((-If((CUSTOMRG.IsOtherSteel(r_e(Conversions.ToInteger(Operators.AddObject(obj, 2))).Grade) > False), 1, 0)), 1, 0)) And (RODUTIL.IsSteel(r_e(Conversions.ToInteger(Operators.AddObject(obj, 3))).Grade) Or If((-If((CUSTOMRG.IsOtherSteel(r_e(Conversions.ToInteger(Operators.AddObject(obj, 3))).Grade) > False), 1, 0)), 1, 0))) <> 0 OrElse (RODUTIL.IsFG(CShort(r_e(Conversions.ToInteger(obj)).Grade)) Or CUSTOMRG.IsOtherFG(r_e(Conversions.ToInteger(obj)).Grade)) And (RODUTIL.IsFG(CShort(r_e(Conversions.ToInteger(Operators.AddObject(obj, 1))).Grade)) Or CUSTOMRG.IsOtherFG(r_e(Conversions.ToInteger(Operators.AddObject(obj, 1))).Grade)) And (RODUTIL.IsFG(CShort(r_e(Conversions.ToInteger(Operators.AddObject(obj, 2))).Grade)) Or CUSTOMRG.IsOtherFG(r_e(Conversions.ToInteger(Operators.AddObject(obj, 2))).Grade)) And (RODUTIL.IsFG(CShort(r_e(Conversions.ToInteger(Operators.AddObject(obj, 3))).Grade)) Or CUSTOMRG.IsOtherFG(r_e(Conversions.ToInteger(Operators.AddObject(obj, 3))).Grade))
											If flag16 Then
												flag15 = False
												If(r_e(Conversions.ToInteger(obj)).max_force < r_e(Conversions.ToInteger(Operators.AddObject(obj, 1))).max_force And r_e(Conversions.ToInteger(Operators.AddObject(obj, 2))).max_force < r_e(Conversions.ToInteger(Operators.AddObject(obj, 1))).max_force) Or (r_e(Conversions.ToInteger(obj)).max_force > r_e(Conversions.ToInteger(Operators.AddObject(obj, 1))).max_force And r_e(Conversions.ToInteger(Operators.AddObject(obj, 2))).max_force > r_e(Conversions.ToInteger(Operators.AddObject(obj, 1))).max_force) Then
													Dim num112 As Single
													If r_e(Conversions.ToInteger(obj)).max_force > r_e(Conversions.ToInteger(Operators.AddObject(obj, 2))).max_force Then
														Dim num111 As Single = CSng(((r_e(Conversions.ToInteger(obj)).max_force - r_e(Conversions.ToInteger(Operators.AddObject(obj, 2))).max_force) / 2.0))
														num112 = CSng((r_e(Conversions.ToInteger(obj)).max_force - CDbl(num111)))
													Else
														Dim num111 As Single = CSng(((r_e(Conversions.ToInteger(Operators.AddObject(obj, 2))).max_force - r_e(Conversions.ToInteger(obj)).max_force) / 2.0))
														num112 = CSng((r_e(Conversions.ToInteger(Operators.AddObject(obj, 2))).max_force - CDbl(num111)))
													End If
													If CDbl(num112) < r_e(Conversions.ToInteger(Operators.AddObject(obj, 1))).max_force Then
														r_e(Conversions.ToInteger(Operators.AddObject(obj, 1))).max_force = CDbl(num112)
														flag15 = True
													End If
												End If
												If(r_e(Conversions.ToInteger(obj)).min_force < r_e(Conversions.ToInteger(Operators.AddObject(obj, 1))).min_force And r_e(Conversions.ToInteger(Operators.AddObject(obj, 2))).min_force < r_e(Conversions.ToInteger(Operators.AddObject(obj, 1))).min_force) Or (r_e(Conversions.ToInteger(obj)).min_force > r_e(Conversions.ToInteger(Operators.AddObject(obj, 1))).min_force And r_e(Conversions.ToInteger(Operators.AddObject(obj, 2))).min_force > r_e(Conversions.ToInteger(Operators.AddObject(obj, 1))).min_force) Then
													Dim num115 As Single
													If r_e(Conversions.ToInteger(obj)).min_force > r_e(Conversions.ToInteger(Operators.AddObject(obj, 2))).min_force Then
														Dim num114 As Single = CSng(((r_e(Conversions.ToInteger(obj)).min_force - r_e(Conversions.ToInteger(Operators.AddObject(obj, 2))).min_force) / 2.0))
														num115 = CSng((r_e(Conversions.ToInteger(obj)).min_force - CDbl(num114)))
													Else
														Dim num114 As Single = CSng(((r_e(Conversions.ToInteger(Operators.AddObject(obj, 2))).min_force - r_e(Conversions.ToInteger(obj)).min_force) / 2.0))
														num115 = CSng((r_e(Conversions.ToInteger(Operators.AddObject(obj, 2))).min_force - CDbl(num114)))
													End If
													If CDbl(num115) < r_e(Conversions.ToInteger(Operators.AddObject(obj, 1))).min_force Then
														r_e(Conversions.ToInteger(Operators.AddObject(obj, 1))).min_force = CDbl(num115)
														flag15 = True
													End If
												End If
												If flag15 Then
													obj = Operators.AddObject(obj, 1)
												End If
											End If
										End If
									Loop While ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj, obj36, obj)
								End If
								Debug.WriteLine(" ")
								Debug.WriteLine(" ")
								Debug.WriteLine(" AFTER  =================  ")
								Dim obj37 As Object
								If ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj, 1, p_s.num_rod_elements - 2, 1, obj37, obj) Then
									Do
										Debug.WriteLine(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(obj, " , "), r_e(Conversions.ToInteger(obj)).m_d), " , "), r_e(Conversions.ToInteger(obj)).min_force), " , "), r_e(Conversions.ToInteger(obj)).max_force))
									Loop While ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj, obj37, obj)
								End If
							End If
							Dim obj38 As Object
							If ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj, 1, p_s.num_rod_elements, 1, obj38, obj) Then
								Do
									' The following expression was wrapped in a checked-expression
									If RODUTIL.IsFG(CShort(r_e(Conversions.ToInteger(obj)).Grade)) Or CUSTOMRG.IsOtherFG(r_e(Conversions.ToInteger(obj)).Grade) Then
										r_e(Conversions.ToInteger(obj)).buckle_tendency = r_e(Conversions.ToInteger(obj)).min_force + r_e(Conversions.ToInteger(obj)).hydrostat_psia_tbg * 2.0 * 0.27 * r_e(Conversions.ToInteger(obj)).rod_area
										r_e(Conversions.ToInteger(obj)).buckle_tendency_max = r_e(Conversions.ToInteger(obj)).max_force + r_e(Conversions.ToInteger(obj)).hydrostat_psia_tbg * 2.0 * 0.27 * r_e(Conversions.ToInteger(obj)).rod_area
									Else
										r_e(Conversions.ToInteger(obj)).buckle_tendency = r_e(Conversions.ToInteger(obj)).min_force + r_e(Conversions.ToInteger(obj)).hydrostat_psia_tbg * 2.0 * p_s.poisson * r_e(Conversions.ToInteger(obj)).rod_area
										r_e(Conversions.ToInteger(obj)).buckle_tendency_max = r_e(Conversions.ToInteger(obj)).max_force + r_e(Conversions.ToInteger(obj)).hydrostat_psia_tbg * 2.0 * p_s.poisson * r_e(Conversions.ToInteger(obj)).rod_area
									End If
									r_e(Conversions.ToInteger(obj)).buckle_tendency_stress = r_e(Conversions.ToInteger(obj)).buckle_tendency / r_e(Conversions.ToInteger(obj)).rod_area
									r_e(Conversions.ToInteger(obj)).buckle_tendency_stress_max = r_e(Conversions.ToInteger(obj)).buckle_tendency_max / r_e(Conversions.ToInteger(obj)).rod_area
									If r_e(Conversions.ToInteger(obj)).m_d <= CDbl(RSWIN_DESC.rst.PumpDepth) Then
										pumpDepthTVD = CSng(r_e(Conversions.ToInteger(obj)).pos.z)
									End If
								Loop While ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj, obj38, obj)
							End If
							RSWIN_DESC.rst.PumpDepthTVD = pumpDepthTVD
							If num110 = 1 Then
								Debug.WriteLine("n, MD, BuckTendBuoy, FminBuoy, mat'l, poisson, PHydTbg, Ar")
								Debug.WriteLine(" ")
							End If
							Dim num117 As Integer = 0
							If num117 = 1 Then
								Debug.WriteLine(" ")
								Debug.WriteLine(" fg_poisson=,," + Conversions.ToString(0.27) + ",steel_poisson,,=" + Conversions.ToString(p_s.poisson))
								Debug.WriteLine("n, MD, BuckTendUB, FmaxUB, FminUB, FBuoyCum,BuckTendBuoy, FmaxBuoy, FminBuoy, PHydTbg, Ar")
							End If
							Dim obj39 As Object
							If ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj, 1, p_s.num_rod_elements - 1, 1, obj39, obj) Then
								Do
									' The following expression was wrapped in a checked-expression
									If RODUTIL.IsFG(CShort(r_e(Conversions.ToInteger(obj)).Grade)) Or CUSTOMRG.IsOtherFG(r_e(Conversions.ToInteger(obj)).Grade) Then
										r_e(Conversions.ToInteger(obj)).buckle_tendency_buoyed = r_e(Conversions.ToInteger(obj)).buckle_tendency + r_e(Conversions.ToInteger(obj)).force_buoy_cum - p_s.force_buoy_rod_bot
									Else
										r_e(Conversions.ToInteger(obj)).buckle_tendency_buoyed = r_e(Conversions.ToInteger(obj)).buckle_tendency + r_e(Conversions.ToInteger(obj)).force_buoy_cum - p_s.force_buoy_rod_bot
									End If
								Loop While ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj, obj39, obj)
							End If
							If RODUTIL.IsFG(CShort(r_e(Conversions.ToInteger(obj)).Grade)) Or CUSTOMRG.IsOtherFG(r_e(Conversions.ToInteger(obj)).Grade) Then
								r_e(Conversions.ToInteger(obj)).buckle_tendency_buoyed = r_e(Conversions.ToInteger(obj)).buckle_tendency + r_e(Conversions.ToInteger(obj)).force_buoy_cum - p_s.force_buoy_rod_bot
							Else
								r_e(Conversions.ToInteger(obj)).buckle_tendency_buoyed = r_e(Conversions.ToInteger(obj)).buckle_tendency + r_e(Conversions.ToInteger(obj)).force_buoy_cum - p_s.force_buoy_rod_bot
							End If
							Dim obj40 As Object
							If num117 = 1 AndAlso ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj, 1, p_s.num_rod_elements, 1, obj40, obj) Then
								Do
									Debug.WriteLine(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(obj, ","), r_e(Conversions.ToInteger(obj)).m_d), ","), r_e(Conversions.ToInteger(obj)).buckle_tendency), ","), r_e(Conversions.ToInteger(obj)).max_force), ","), r_e(Conversions.ToInteger(obj)).min_force), ","), r_e(Conversions.ToInteger(obj)).force_buoy_cum), ","), r_e(Conversions.ToInteger(obj)).buckle_tendency_buoyed), ","), r_e(Conversions.ToInteger(obj)).max_force_buoyed), ","), r_e(Conversions.ToInteger(obj)).min_force_buoyed), ","), r_e(Conversions.ToInteger(obj)).hydrostat_psia_tbg), ","), r_e(Conversions.ToInteger(obj)).rod_area))
								Loop While ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj, obj40, obj)
							End If
							If num117 = 1 Then
								Debug.WriteLine("n, MD, BuckTendUB, FmaxUB, FminUB, FBuoyCum,BuckTendBuoy, FmaxBuoy, FminBuoy, PHydTbg, Ar")
								Debug.WriteLine(" ")
							End If
						End If
						p_s.pr_velo_max_up = -10000000.0
						p_s.pr_velo_max_dn = 10000000.0
						p_s.p_velo_max_up = -10000000.0
						p_s.p_velo_max_dn = 10000000.0
						Dim obj41 As Object
						If ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj, 1, p_s.num_timesteps, 1, obj41, obj) Then
							Do
								Dim num41 As Double
								If Operators.ConditionalCompareObjectEqual(obj, 1, False) Then
									num41 = t_s(p_s.num_timesteps).p_r_position
								Else
									num41 = t_s(Conversions.ToInteger(Operators.SubtractObject(obj, 1))).p_r_position
								End If
								Dim num118 As Double = -(t_s(Conversions.ToInteger(obj)).p_r_position - num41) / p_s.timestep_length / 12.0
								If num118 > p_s.pr_velo_max_up Then
									p_s.pr_velo_max_up = num118
								ElseIf num118 < p_s.pr_velo_max_dn Then
									p_s.pr_velo_max_dn = num118
								End If
								If t_s(Conversions.ToInteger(obj)).pump_velocity < p_s.p_velo_max_dn Then
									p_s.p_velo_max_dn = t_s(Conversions.ToInteger(obj)).pump_velocity
								End If
								If t_s(Conversions.ToInteger(obj)).pump_velocity > p_s.p_velo_max_up Then
									p_s.p_velo_max_up = t_s(Conversions.ToInteger(obj)).pump_velocity
								End If
							Loop While ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj, obj41, obj)
						End If
						num24 = 1000000.0
						num25 = -1000000.0
						Dim obj42 As Object
						If ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj, 1, p_s.num_timesteps, 1, obj42, obj) Then
							Do
								If t_s(Conversions.ToInteger(obj)).pump_displacement < num24 Then
									num24 = t_s(Conversions.ToInteger(obj)).pump_displacement
								End If
								If t_s(Conversions.ToInteger(obj)).pump_displacement > num25 Then
									num25 = t_s(Conversions.ToInteger(obj)).pump_displacement
								End If
							Loop While ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj, obj42, obj)
						End If
						If p_s.vari_spm = 0 And num19 >= 2 Then
							p_s.ratio_vb_converged = 1
						End If

					If p_s.fluid_solution = 0 Or p_s.fluid_solution = 1 Then
						If num19 <= p_s.num_cycles - 1 And p_s.vari_spm = 1 And p_s.ratio_vb_converged = 1 Then
							p_s.num_cycles += 1
						End If
					ElseIf p_s.fluid_solution = -1 AndAlso (num19 < p_s.num_cycles And p_s.vari_spm = 1 And p_s.ratio_vb_converged = 1) Then
						t_s(num19).num_timesteps = p_s.num_timesteps
						num19 = p_s.num_cycles - 1
					End If
					If num19 >= p_s.num_cycles Then
						flag5 = False
					End If
				End While
				p_s.max_p_r_force_buoyed = p_s.max_p_r_force
				Dim flag17 As Boolean

					p_s.max_p_r_force_unbuoyed = p_s.max_p_r_force_buoyed - r_e(0).force_buoy_cum
					p_s.min_p_r_force_buoyed = p_s.min_p_r_force
					p_s.min_p_r_force_unbuoyed = p_s.min_p_r_force_buoyed - r_e(0).force_buoy_cum
					Dim num119 As Integer = 0
					If num119 = 1 Then
						Dim text As String = "c:\TempRSWINFiles\r_e_Funbuoy.csv"
						Dim num120 As Integer
						If FILEUTIL.FileExists(text) Then
							FileSystem.FileClose(New Integer() { num120 })
							FileSystem.Kill("c:\TempRSWINFiles\r_e_Funbuoy.csv")
						End If
						num120 = FileSystem.FreeFile()
						FileSystem.FileOpen(num120, "c:\TempRSWINFiles\r_e_Funbuoy.csv", OpenMode.Output, OpenAccess.[Default], OpenShare.[Default], -1)
						FileSystem.PrintLine(num120, New Object() { "check max & min force with & without buoyancy" })
						FileSystem.PrintLine(num120, New Object() { "n,MaxF,MaxFb,Fbcum,MaxFub,MinF,MinFb,Fbcum,MinFub,Ar,Phyd,Fbuoy" })
						obj = 0
						FileSystem.PrintLine(num120, New Object() { String.Concat(New String() { "PolRod,", Conversions.ToString(p_s.max_p_r_force), ",", Conversions.ToString(p_s.max_p_r_force_buoyed), ",", Conversions.ToString(r_e(0).force_buoy_cum), ",", Conversions.ToString(p_s.max_p_r_force_unbuoyed), ",", Conversions.ToString(p_s.min_p_r_force), ",", Conversions.ToString(p_s.min_p_r_force_buoyed), ",", Conversions.ToString(r_e(0).force_buoy_cum), ",", Conversions.ToString(p_s.min_p_r_force_unbuoyed), ",", Conversions.ToString(p_s.p_r_area), ",", Conversions.ToString(p_s.p_r_psia_tbg), ",", Conversions.ToString(p_s.p_r_psia_tbg * (r_e(1).rod_area - p_s.p_r_area)) }) })
						Dim obj43 As Object
						If ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj, 1, p_s.num_rod_elements, 1, obj43, obj) Then
							Do
								r_e(Conversions.ToInteger(obj)).max_force_buoyed = r_e(Conversions.ToInteger(obj)).max_force
								r_e(Conversions.ToInteger(obj)).min_force_buoyed = r_e(Conversions.ToInteger(obj)).min_force
								r_e(Conversions.ToInteger(obj)).max_force_unbuoyed = r_e(Conversions.ToInteger(obj)).max_force_buoyed - r_e(Conversions.ToInteger(obj)).force_buoy_cum
								r_e(Conversions.ToInteger(obj)).min_force_unbuoyed = r_e(Conversions.ToInteger(obj)).min_force_buoyed - r_e(Conversions.ToInteger(obj)).force_buoy_cum
								FileSystem.PrintLine(num120, New Object() { Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(obj, ","), r_e(Conversions.ToInteger(obj)).max_force), ","), r_e(Conversions.ToInteger(obj)).max_force_buoyed), ","), r_e(Conversions.ToInteger(obj)).force_buoy_cum), ","), r_e(Conversions.ToInteger(obj)).max_force_unbuoyed), ","), r_e(Conversions.ToInteger(obj)).min_force), ","), r_e(Conversions.ToInteger(obj)).min_force_buoyed), ","), r_e(Conversions.ToInteger(obj)).force_buoy_cum), ","), r_e(Conversions.ToInteger(obj)).min_force_unbuoyed), ","), r_e(Conversions.ToInteger(obj)).rod_area), ","), r_e(Conversions.ToInteger(obj)).hydrostat_psia_tbg), ","), r_e(Conversions.ToInteger(obj)).force_buoy) })
							Loop While ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj, obj43, obj)
						End If
						FileSystem.PrintLine(num120, New Object() { "n,MaxF,MaxFb,Fbcum,MaxFub,MinF,MinFb,Fbcum,MinFub,Ar,Phyd,Fbuoy" })
						FileSystem.PrintLine(num120, New Object() { "" })
						FileSystem.FileClose(New Integer() { num120 })
					Else
						obj = 0
						Dim obj44 As Object
						If ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj, 1, p_s.num_rod_elements, 1, obj44, obj) Then
							Do
								r_e(Conversions.ToInteger(obj)).max_force_buoyed = r_e(Conversions.ToInteger(obj)).max_force
								r_e(Conversions.ToInteger(obj)).min_force_buoyed = r_e(Conversions.ToInteger(obj)).min_force
								r_e(Conversions.ToInteger(obj)).max_force_unbuoyed = r_e(Conversions.ToInteger(obj)).max_force_buoyed - r_e(Conversions.ToInteger(obj)).force_buoy_cum
								r_e(Conversions.ToInteger(obj)).min_force_unbuoyed = r_e(Conversions.ToInteger(obj)).min_force_buoyed - r_e(Conversions.ToInteger(obj)).force_buoy_cum
							Loop While ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj, obj44, obj)
						End If
						Debug.WriteLine(" ")
					End If
					If Not RSWIN_DESC.rst.gbIncludeBuoyancy AndAlso flag3 Then
						If r_e(1).max_force_unbuoyed < r_e(2).max_force_unbuoyed And p_s.num_rod_elements >= 3 Then
							If r_e(3).max_force_unbuoyed <> 0.0 Then
								r_e(1).max_force_unbuoyed = r_e(2).max_force_unbuoyed * (r_e(2).max_force_unbuoyed / r_e(3).max_force_unbuoyed)
								r_e(1).min_force_unbuoyed = r_e(2).min_force_unbuoyed * (r_e(2).min_force_unbuoyed / r_e(3).min_force_unbuoyed)
							Else
								r_e(1).max_force_unbuoyed = r_e(2).max_force_unbuoyed + (r_e(2).max_force_unbuoyed - r_e(3).max_force_unbuoyed)
								r_e(1).min_force_unbuoyed = r_e(2).min_force_unbuoyed + (r_e(2).min_force_unbuoyed - r_e(3).min_force_unbuoyed)
							End If
						End If
						Dim obj45 As Object
						If ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj, 1, p_s.num_rod_elements - 3, 1, obj45, obj) Then
							Do
								Dim flag15 As Boolean = False
								If Conversions.ToBoolean(Operators.AndObject(flag4, Operators.CompareObjectLess(obj, p_s.num_rod_elements - 4, False))) Then
									' The following expression was wrapped in a checked-expression
									Dim flag16 As Boolean = ((RODUTIL.IsSteel(r_e(Conversions.ToInteger(obj)).Grade) Or If((-If((CUSTOMRG.IsOtherSteel(r_e(Conversions.ToInteger(obj)).Grade) > False), 1, 0)), 1, 0)) And (RODUTIL.IsSteel(r_e(Conversions.ToInteger(Operators.AddObject(obj, 1))).Grade) Or If((-If((CUSTOMRG.IsOtherSteel(r_e(Conversions.ToInteger(Operators.AddObject(obj, 1))).Grade) > False), 1, 0)), 1, 0)) And (RODUTIL.IsSteel(r_e(Conversions.ToInteger(Operators.AddObject(obj, 2))).Grade) Or If((-If((CUSTOMRG.IsOtherSteel(r_e(Conversions.ToInteger(Operators.AddObject(obj, 2))).Grade) > False), 1, 0)), 1, 0)) And (RODUTIL.IsSteel(r_e(Conversions.ToInteger(Operators.AddObject(obj, 3))).Grade) Or If((-If((CUSTOMRG.IsOtherSteel(r_e(Conversions.ToInteger(Operators.AddObject(obj, 3))).Grade) > False), 1, 0)), 1, 0)) And (RODUTIL.IsSteel(r_e(Conversions.ToInteger(Operators.AddObject(obj, 4))).Grade) Or If((-If((CUSTOMRG.IsOtherSteel(r_e(Conversions.ToInteger(Operators.AddObject(obj, 4))).Grade) > False), 1, 0)), 1, 0))) <> 0 OrElse (RODUTIL.IsFG(CShort(r_e(Conversions.ToInteger(obj)).Grade)) Or CUSTOMRG.IsOtherFG(r_e(Conversions.ToInteger(obj)).Grade)) And (RODUTIL.IsFG(CShort(r_e(Conversions.ToInteger(Operators.AddObject(obj, 1))).Grade)) Or CUSTOMRG.IsOtherFG(r_e(Conversions.ToInteger(Operators.AddObject(obj, 1))).Grade)) And (RODUTIL.IsFG(CShort(r_e(Conversions.ToInteger(Operators.AddObject(obj, 2))).Grade)) Or CUSTOMRG.IsOtherFG(r_e(Conversions.ToInteger(Operators.AddObject(obj, 2))).Grade)) And (RODUTIL.IsFG(CShort(r_e(Conversions.ToInteger(Operators.AddObject(obj, 3))).Grade)) Or CUSTOMRG.IsOtherFG(r_e(Conversions.ToInteger(Operators.AddObject(obj, 3))).Grade)) And (RODUTIL.IsFG(CShort(r_e(Conversions.ToInteger(Operators.AddObject(obj, 4))).Grade)) Or CUSTOMRG.IsOtherFG(r_e(Conversions.ToInteger(Operators.AddObject(obj, 4))).Grade))
									If flag16 Then
										If(r_e(Conversions.ToInteger(obj)).max_force_unbuoyed < r_e(Conversions.ToInteger(Operators.AddObject(obj, 1))).max_force_unbuoyed And r_e(Conversions.ToInteger(Operators.AddObject(obj, 2))).max_force_unbuoyed > r_e(Conversions.ToInteger(Operators.AddObject(obj, 3))).max_force_unbuoyed) Or (r_e(Conversions.ToInteger(obj)).max_force_unbuoyed > r_e(Conversions.ToInteger(Operators.AddObject(obj, 1))).max_force_unbuoyed And r_e(Conversions.ToInteger(Operators.AddObject(obj, 2))).max_force_unbuoyed < r_e(Conversions.ToInteger(Operators.AddObject(obj, 3))).max_force_unbuoyed) Then
											If r_e(Conversions.ToInteger(obj)).max_force_unbuoyed > r_e(Conversions.ToInteger(Operators.AddObject(obj, 3))).max_force_unbuoyed Then
												Dim num111 As Single = CSng(((r_e(Conversions.ToInteger(obj)).max_force_unbuoyed - r_e(Conversions.ToInteger(Operators.AddObject(obj, 3))).max_force_unbuoyed) / 3.0))
												Dim num112 As Single = CSng((r_e(Conversions.ToInteger(obj)).max_force_unbuoyed - CDbl(num111)))
												Dim num113 As Single = num112 - num111
												r_e(Conversions.ToInteger(Operators.AddObject(obj, 1))).max_force_unbuoyed = CDbl(num112)
												r_e(Conversions.ToInteger(Operators.AddObject(obj, 2))).max_force_unbuoyed = CDbl(num113)
											Else
												Dim num111 As Single = CSng(((r_e(Conversions.ToInteger(Operators.AddObject(obj, 3))).max_force_unbuoyed - r_e(Conversions.ToInteger(obj)).max_force_unbuoyed) / 3.0))
												Dim num112 As Single = CSng((r_e(Conversions.ToInteger(Operators.AddObject(obj, 3))).max_force_unbuoyed - CDbl(num111)))
												Dim num113 As Single = num112 - num111
												r_e(Conversions.ToInteger(Operators.AddObject(obj, 2))).max_force_unbuoyed = CDbl(num112)
												r_e(Conversions.ToInteger(Operators.AddObject(obj, 1))).max_force_unbuoyed = CDbl(num113)
											End If
											flag15 = True
										End If
										If(r_e(Conversions.ToInteger(obj)).min_force_unbuoyed < r_e(Conversions.ToInteger(Operators.AddObject(obj, 1))).min_force_unbuoyed And r_e(Conversions.ToInteger(Operators.AddObject(obj, 2))).min_force_unbuoyed > r_e(Conversions.ToInteger(Operators.AddObject(obj, 3))).min_force_unbuoyed) Or (r_e(Conversions.ToInteger(obj)).min_force_unbuoyed > r_e(Conversions.ToInteger(Operators.AddObject(obj, 1))).min_force_unbuoyed And r_e(Conversions.ToInteger(Operators.AddObject(obj, 2))).min_force_unbuoyed < r_e(Conversions.ToInteger(Operators.AddObject(obj, 3))).min_force_unbuoyed) Then
											If r_e(Conversions.ToInteger(obj)).min_force_unbuoyed > r_e(Conversions.ToInteger(Operators.AddObject(obj, 3))).min_force_unbuoyed Then
												Dim num114 As Single = CSng(((r_e(Conversions.ToInteger(obj)).min_force_unbuoyed - r_e(Conversions.ToInteger(Operators.AddObject(obj, 3))).min_force_unbuoyed) / 3.0))
												Dim num115 As Single = CSng((r_e(Conversions.ToInteger(obj)).min_force_unbuoyed - CDbl(num114)))
												Dim num116 As Single = num115 - num114
												r_e(Conversions.ToInteger(Operators.AddObject(obj, 1))).min_force_unbuoyed = CDbl(num115)
												r_e(Conversions.ToInteger(Operators.AddObject(obj, 2))).min_force_unbuoyed = CDbl(num116)
											Else
												Dim num114 As Single = CSng(((r_e(Conversions.ToInteger(Operators.AddObject(obj, 3))).min_force_unbuoyed - r_e(Conversions.ToInteger(obj)).min_force_unbuoyed) / 3.0))
												Dim num115 As Single = CSng((r_e(Conversions.ToInteger(Operators.AddObject(obj, 3))).min_force_unbuoyed - CDbl(num114)))
												Dim num116 As Single = num115 - num114
												r_e(Conversions.ToInteger(Operators.AddObject(obj, 2))).min_force_unbuoyed = CDbl(num115)
												r_e(Conversions.ToInteger(Operators.AddObject(obj, 1))).min_force_unbuoyed = CDbl(num116)
											End If
											flag15 = True
										End If
										If flag15 Then
											obj = Operators.AddObject(obj, 2)
										End If
									End If
								ElseIf Not flag15 Then
									' The following expression was wrapped in a checked-expression
									Dim flag16 As Boolean = ((RODUTIL.IsSteel(r_e(Conversions.ToInteger(obj)).Grade) Or If((-If((CUSTOMRG.IsOtherSteel(r_e(Conversions.ToInteger(obj)).Grade) > False), 1, 0)), 1, 0)) And (RODUTIL.IsSteel(r_e(Conversions.ToInteger(Operators.AddObject(obj, 1))).Grade) Or If((-If((CUSTOMRG.IsOtherSteel(r_e(Conversions.ToInteger(Operators.AddObject(obj, 1))).Grade) > False), 1, 0)), 1, 0)) And (RODUTIL.IsSteel(r_e(Conversions.ToInteger(Operators.AddObject(obj, 2))).Grade) Or If((-If((CUSTOMRG.IsOtherSteel(r_e(Conversions.ToInteger(Operators.AddObject(obj, 2))).Grade) > False), 1, 0)), 1, 0)) And (RODUTIL.IsSteel(r_e(Conversions.ToInteger(Operators.AddObject(obj, 3))).Grade) Or If((-If((CUSTOMRG.IsOtherSteel(r_e(Conversions.ToInteger(Operators.AddObject(obj, 3))).Grade) > False), 1, 0)), 1, 0))) <> 0 OrElse (RODUTIL.IsFG(CShort(r_e(Conversions.ToInteger(obj)).Grade)) Or CUSTOMRG.IsOtherFG(r_e(Conversions.ToInteger(obj)).Grade)) And (RODUTIL.IsFG(CShort(r_e(Conversions.ToInteger(Operators.AddObject(obj, 1))).Grade)) Or CUSTOMRG.IsOtherFG(r_e(Conversions.ToInteger(Operators.AddObject(obj, 1))).Grade)) And (RODUTIL.IsFG(CShort(r_e(Conversions.ToInteger(Operators.AddObject(obj, 2))).Grade)) Or CUSTOMRG.IsOtherFG(r_e(Conversions.ToInteger(Operators.AddObject(obj, 2))).Grade)) And (RODUTIL.IsFG(CShort(r_e(Conversions.ToInteger(Operators.AddObject(obj, 3))).Grade)) Or CUSTOMRG.IsOtherFG(r_e(Conversions.ToInteger(Operators.AddObject(obj, 3))).Grade))
									If flag16 Then
										flag15 = False
										If(r_e(Conversions.ToInteger(obj)).max_force_unbuoyed < r_e(Conversions.ToInteger(Operators.AddObject(obj, 1))).max_force_unbuoyed And r_e(Conversions.ToInteger(Operators.AddObject(obj, 2))).max_force_unbuoyed < r_e(Conversions.ToInteger(Operators.AddObject(obj, 1))).max_force_unbuoyed) Or (r_e(Conversions.ToInteger(obj)).max_force_unbuoyed > r_e(Conversions.ToInteger(Operators.AddObject(obj, 1))).max_force_unbuoyed And r_e(Conversions.ToInteger(Operators.AddObject(obj, 2))).max_force_unbuoyed > r_e(Conversions.ToInteger(Operators.AddObject(obj, 1))).max_force_unbuoyed) Then
											Dim num112 As Single
											If r_e(Conversions.ToInteger(obj)).max_force_unbuoyed > r_e(Conversions.ToInteger(Operators.AddObject(obj, 2))).max_force_unbuoyed Then
												Dim num111 As Single = CSng(((r_e(Conversions.ToInteger(obj)).max_force_unbuoyed - r_e(Conversions.ToInteger(Operators.AddObject(obj, 2))).max_force_unbuoyed) / 2.0))
												num112 = CSng((r_e(Conversions.ToInteger(obj)).max_force_unbuoyed - CDbl(num111)))
											Else
												Dim num111 As Single = CSng(((r_e(Conversions.ToInteger(Operators.AddObject(obj, 2))).max_force_unbuoyed - r_e(Conversions.ToInteger(obj)).max_force_unbuoyed) / 2.0))
												num112 = CSng((r_e(Conversions.ToInteger(Operators.AddObject(obj, 2))).max_force_unbuoyed - CDbl(num111)))
											End If
											If CDbl(num112) < r_e(Conversions.ToInteger(Operators.AddObject(obj, 1))).max_force_unbuoyed Then
												r_e(Conversions.ToInteger(Operators.AddObject(obj, 1))).max_force_unbuoyed = CDbl(num112)
												flag15 = True
											End If
										End If
										If(r_e(Conversions.ToInteger(obj)).min_force_unbuoyed < r_e(Conversions.ToInteger(Operators.AddObject(obj, 1))).min_force_unbuoyed And r_e(Conversions.ToInteger(Operators.AddObject(obj, 2))).min_force_unbuoyed < r_e(Conversions.ToInteger(Operators.AddObject(obj, 1))).min_force_unbuoyed) Or (r_e(Conversions.ToInteger(obj)).min_force_unbuoyed > r_e(Conversions.ToInteger(Operators.AddObject(obj, 1))).min_force_unbuoyed And r_e(Conversions.ToInteger(Operators.AddObject(obj, 2))).min_force_unbuoyed > r_e(Conversions.ToInteger(Operators.AddObject(obj, 1))).min_force_unbuoyed) Then
											Dim num115 As Single
											If r_e(Conversions.ToInteger(obj)).min_force_unbuoyed > r_e(Conversions.ToInteger(Operators.AddObject(obj, 2))).min_force_unbuoyed Then
												Dim num114 As Single = CSng(((r_e(Conversions.ToInteger(obj)).min_force_unbuoyed - r_e(Conversions.ToInteger(Operators.AddObject(obj, 2))).min_force_unbuoyed) / 2.0))
												num115 = CSng((r_e(Conversions.ToInteger(obj)).min_force_unbuoyed - CDbl(num114)))
											Else
												Dim num114 As Single = CSng(((r_e(Conversions.ToInteger(Operators.AddObject(obj, 2))).min_force_unbuoyed - r_e(Conversions.ToInteger(obj)).min_force_unbuoyed) / 2.0))
												num115 = CSng((r_e(Conversions.ToInteger(Operators.AddObject(obj, 2))).min_force_unbuoyed - CDbl(num114)))
											End If
											If CDbl(num115) < r_e(Conversions.ToInteger(Operators.AddObject(obj, 1))).min_force_unbuoyed Then
												r_e(Conversions.ToInteger(Operators.AddObject(obj, 1))).min_force_unbuoyed = CDbl(num115)
												flag15 = True
											End If
										End If
										If flag15 Then
											obj = Operators.AddObject(obj, 1)
										End If
									End If
								End If
							Loop While ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj, obj45, obj)
						End If
					End If
					If num = 1 Then
						FileSystem.FileClose(New Integer() { num2 })
					End If
					Dim num121 As Integer = 0
					If num121 = 1 Then
						Dim text As String = "c:\TempRSWINFiles\dyn_before.csv"
						Dim num122 As Integer
						If FILEUTIL.FileExists(text) Then
							FileSystem.FileClose(New Integer() { num122 })
							FileSystem.Kill("c:\TempRSWINFiles\dyn_before.csv")
						End If
						num122 = FileSystem.FreeFile()
						FileSystem.FileOpen(num122, "c:\TempRSWINFiles\dyn_before.csv", OpenMode.Output, OpenAccess.[Default], OpenShare.[Default], -1)
						FileSystem.PrintLine(num122, New Object() { "dyn card plotting BEFORE buoyancy correction" })
						FileSystem.PrintLine(num122, New Object() { "i_cyc,i_step,PRP,PRL,Ppump,Fpump,dhol,Pi,Fi" })
						Dim obj46 As Object
						If ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj, 1, p_s.num_timesteps, 1, obj46, obj) Then
							Do
								' The following expression was wrapped in a checked-expression
								FileSystem.PrintLine(num122, New Object() { Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Conversions.ToString(num19 - 1) + ",", obj), ","), t_s(Conversions.ToInteger(obj)).p_r_position), ","), t_s(Conversions.ToInteger(obj)).p_r_force), ","), t_s(Conversions.ToInteger(obj)).pump_displacement * 12.0), ","), t_s(Conversions.ToInteger(obj)).pump_force), ","), p_s.i_downhole_dyno), ","), t_s(Conversions.ToInteger(obj)).downhole_position * 12.0), ","), t_s(Conversions.ToInteger(obj)).downhole_force) })
							Loop While ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj, obj46, obj)
						End If
						FileSystem.PrintLine(num122, New Object() { "i_cyc,i_step,PRP,PRL,Ppump,Fpump,dhol,Pi,Fi" })
						FileSystem.PrintLine(num122, New Object() { "dyn card plotting BEFORE buoyancy correction" })
						FileSystem.FileClose(New Integer() { num122 })
					End If
					p_s.pump_stroke_length = num25 - num24 - p_s.tbg_stretch_max - num10
					p_s.pump_volumetric_rate = p_s.pump_stroke_length * p_s.pump_area * p_s.strokes_per_min * 1440.0 / 144.0 / 5.615
					Me.save_pump_position_po = num10
					flag17 = False
					obj = 1

				While Operators.ConditionalCompareObjectLessEqual(obj, p_s.num_rod_tapers, False)
					Dim num123 As Integer = 1
					Dim num_rod_elements As Integer = p_s.num_rod_elements
					For i As Integer = num123 To num_rod_elements
						If r_t(Conversions.ToInteger(obj)).taper_depth <= r_e(i).m_d Then
							If i = p_s.num_rod_elements Then
								i = i
							End If

								' The following expression was wrapped in a checked-expression
								' The following expression was wrapped in a checked-expression
								r_t(Conversions.ToInteger(obj)).max_taper_force_bot_buoyed = (r_e(i - 1).max_force - r_e(i).max_force) * (r_t(Conversions.ToInteger(obj)).taper_depth - r_e(i).m_d) / (r_e(i - 1).m_d - r_e(i).m_d) + r_e(i).max_force
								r_t(Conversions.ToInteger(obj)).max_taper_force_bot_unbuoyed = (r_e(i - 1).max_force_unbuoyed - r_e(i).max_force_unbuoyed) * (r_t(Conversions.ToInteger(obj)).taper_depth - r_e(i).m_d) / (r_e(i - 1).m_d - r_e(i).m_d) + r_e(i).max_force_unbuoyed
								r_t(Conversions.ToInteger(obj)).min_taper_force_bot_buoyed = (r_e(i - 1).min_force - r_e(i).min_force) * (r_t(Conversions.ToInteger(obj)).taper_depth - r_e(i).m_d) / (r_e(i - 1).m_d - r_e(i).m_d) + r_e(i).min_force
								r_t(Conversions.ToInteger(obj)).min_taper_force_bot_unbuoyed = (r_e(i - 1).min_force_unbuoyed - r_e(i).min_force_unbuoyed) * (r_t(Conversions.ToInteger(obj)).taper_depth - r_e(i).m_d) / (r_e(i - 1).m_d - r_e(i).m_d) + r_e(i).min_force_unbuoyed
								If r_t(Conversions.ToInteger(obj)).rod_area <> 0.0 Then
									r_t(Conversions.ToInteger(obj)).max_taper_stress_bot_unbuoyed = r_t(Conversions.ToInteger(obj)).max_taper_force_bot_unbuoyed / r_t(Conversions.ToInteger(obj)).rod_area
									r_t(Conversions.ToInteger(obj)).max_taper_stress_bot = r_t(Conversions.ToInteger(obj)).max_taper_stress_bot_unbuoyed
									r_t(Conversions.ToInteger(obj)).min_taper_stress_bot_unbuoyed = r_t(Conversions.ToInteger(obj)).min_taper_force_bot_unbuoyed / r_t(Conversions.ToInteger(obj)).rod_area
									r_t(Conversions.ToInteger(obj)).min_taper_stress_bot = r_t(Conversions.ToInteger(obj)).min_taper_stress_bot_unbuoyed
									r_t(Conversions.ToInteger(obj)).max_taper_stress_bot_buoyed = r_t(Conversions.ToInteger(obj)).max_taper_force_bot_buoyed / r_t(Conversions.ToInteger(obj)).rod_area
									r_t(Conversions.ToInteger(obj)).min_taper_stress_bot_buoyed = r_t(Conversions.ToInteger(obj)).min_taper_force_bot_buoyed / r_t(Conversions.ToInteger(obj)).rod_area
								Else
									r_t(Conversions.ToInteger(obj)).max_taper_stress_bot_unbuoyed = 0.0
									r_t(Conversions.ToInteger(obj)).max_taper_stress_bot = r_t(Conversions.ToInteger(obj)).max_taper_stress_bot_unbuoyed
									r_t(Conversions.ToInteger(obj)).min_taper_stress_bot_unbuoyed = 0.0
									r_t(Conversions.ToInteger(obj)).min_taper_stress_bot = r_t(Conversions.ToInteger(obj)).min_taper_stress_bot_unbuoyed
									r_t(Conversions.ToInteger(obj)).max_taper_stress_bot_buoyed = 0.0
									r_t(Conversions.ToInteger(obj)).min_taper_stress_bot_buoyed = 0.0
								End If
								r_t(Conversions.ToInteger(obj)).max_buckle_stress_bot = r_e(i).buckle_tendency_stress_max
								r_t(Conversions.ToInteger(obj)).min_buckle_stress_bot = r_e(i).buckle_tendency_stress

							If Operators.ConditionalCompareObjectLess(obj, p_s.num_rod_tapers, False) Then
								r_t(Conversions.ToInteger(Operators.AddObject(obj, 1))).max_buckle_stress_top = r_e(i + 1).buckle_tendency_stress_max
								r_t(Conversions.ToInteger(Operators.AddObject(obj, 1))).min_buckle_stress_top = r_e(i + 1).buckle_tendency_stress
							End If
							obj = Operators.AddObject(obj, 1)
						End If
					Next
					If Operators.ConditionalCompareObjectEqual(obj, p_s.num_rod_tapers, False) Then
						If flag17 Then
							Exit While
						End If
						flag17 = True
					End If
				End While
				r_t(1).max_buckle_stress_top = r_e(1).buckle_tendency_stress_max
				r_t(1).min_buckle_stress_top = r_e(1).buckle_tendency_stress
				r_t(p_s.num_rod_tapers).max_buckle_stress_bot = r_e(p_s.num_rod_elements).buckle_tendency_stress_max
				r_t(p_s.num_rod_tapers).min_buckle_stress_bot = r_e(p_s.num_rod_elements).buckle_tendency_stress
				Dim obj47 As Object
				If ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj, 1, p_s.num_rod_tapers, 1, obj47, obj) Then
					Do
						Debug.WriteLine(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(obj, " , "), r_t(Conversions.ToInteger(obj)).max_buckle_stress_top), " , "), r_t(Conversions.ToInteger(obj)).min_buckle_stress_top), " , "), r_t(Conversions.ToInteger(obj)).max_buckle_stress_bot), " , "), r_t(Conversions.ToInteger(obj)).min_buckle_stress_bot))
					Loop While ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj, obj47, obj)
				End If
				r_t(1).max_taper_force_top_buoyed = p_s.max_p_r_force
				r_t(1).min_taper_force_top_buoyed = p_s.min_p_r_force
				r_t(1).max_taper_stress_top_buoyed = p_s.max_p_r_force / r_t(1).rod_area
				r_t(1).min_taper_stress_top_buoyed = p_s.min_p_r_force / r_t(1).rod_area

					r_t(1).max_taper_force_top_unbuoyed = p_s.max_p_r_force - r_t(1).force_buoy_cum
					r_t(1).min_taper_force_top_unbuoyed = p_s.min_p_r_force - r_t(1).force_buoy_cum
					r_t(1).max_taper_stress_top_unbuoyed = r_t(1).max_taper_force_top_unbuoyed / r_t(1).rod_area
					r_t(1).max_taper_stress_top = r_t(1).max_taper_stress_top_unbuoyed
					r_t(1).min_taper_stress_top_unbuoyed = r_t(1).min_taper_force_top_unbuoyed / r_t(1).rod_area
					r_t(1).min_taper_stress_top = r_t(1).min_taper_stress_top_unbuoyed
					Dim obj48 As Object
					If ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj, 2, p_s.num_rod_tapers, 1, obj48, obj) Then
						Do
							r_t(Conversions.ToInteger(obj)).max_taper_force_top_buoyed = r_t(Conversions.ToInteger(Operators.SubtractObject(obj, 1))).max_taper_force_bot_buoyed - r_t(Conversions.ToInteger(Operators.SubtractObject(obj, 1))).force_buoy
							r_t(Conversions.ToInteger(obj)).min_taper_force_top_buoyed = r_t(Conversions.ToInteger(Operators.SubtractObject(obj, 1))).min_taper_force_bot_buoyed - r_t(Conversions.ToInteger(Operators.SubtractObject(obj, 1))).force_buoy
							r_t(Conversions.ToInteger(obj)).max_taper_stress_top_buoyed = r_t(Conversions.ToInteger(obj)).max_taper_force_top_buoyed / r_t(Conversions.ToInteger(obj)).rod_area
							r_t(Conversions.ToInteger(obj)).min_taper_stress_top_buoyed = r_t(Conversions.ToInteger(obj)).min_taper_force_top_buoyed / r_t(Conversions.ToInteger(obj)).rod_area
							r_t(Conversions.ToInteger(obj)).max_taper_force_top_unbuoyed = r_t(Conversions.ToInteger(Operators.SubtractObject(obj, 1))).max_taper_force_bot_unbuoyed
							r_t(Conversions.ToInteger(obj)).min_taper_force_top_unbuoyed = r_t(Conversions.ToInteger(Operators.SubtractObject(obj, 1))).min_taper_force_bot_unbuoyed
							r_t(Conversions.ToInteger(obj)).max_taper_stress_top_unbuoyed = r_t(Conversions.ToInteger(obj)).max_taper_force_top_unbuoyed / r_t(Conversions.ToInteger(obj)).rod_area
							r_t(Conversions.ToInteger(obj)).max_taper_stress_top = r_t(Conversions.ToInteger(obj)).max_taper_stress_top_unbuoyed
							r_t(Conversions.ToInteger(obj)).min_taper_stress_top_unbuoyed = r_t(Conversions.ToInteger(obj)).min_taper_force_top_unbuoyed / r_t(Conversions.ToInteger(obj)).rod_area
							r_t(Conversions.ToInteger(obj)).min_taper_stress_top = r_t(Conversions.ToInteger(obj)).min_taper_stress_top_unbuoyed
						Loop While ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj, obj48, obj)
					End If
					Dim num124 As Integer = 0
					If num124 = 1 Then
						Dim text As String = "c:\TempRSWINFiles\max_min_stress.csv"
						Dim num125 As Integer
						If FILEUTIL.FileExists(text) Then
							FileSystem.FileClose(New Integer() { num125 })
							FileSystem.Kill("c:\TempRSWINFiles\max_min_stress.csv")
						End If
						num125 = FileSystem.FreeFile()
						FileSystem.FileOpen(num125, "c:\TempRSWINFiles\max_min_stress.csv", OpenMode.Output, OpenAccess.[Default], OpenShare.[Default], -1)
						FileSystem.PrintLine(num125, New Object() { "ntap ,SxTopB,SnTopB,FxTopB,FnTopB ,SxTopU,SnTopU,FxTopU,FnTopU ,SxBotB,SnBotB,FxBotB,FnBotB,SxBotU,SnBotU,FxBotU,FnBotU,Atap,FBcum,TapLen,tvd,Phyd" })
						Dim obj49 As Object
						If ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj, 1, p_s.num_rod_tapers, 1, obj49, obj) Then
							Do
								FileSystem.PrintLine(num125, New Object() { Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(obj, ","), r_t(Conversions.ToInteger(obj)).max_taper_stress_top_buoyed), ","), r_t(Conversions.ToInteger(obj)).min_taper_stress_top_buoyed), ","), r_t(Conversions.ToInteger(obj)).max_taper_force_top_buoyed), ","), r_t(Conversions.ToInteger(obj)).min_taper_force_top_buoyed), ""), ","), r_t(Conversions.ToInteger(obj)).max_taper_stress_top_unbuoyed), ","), r_t(Conversions.ToInteger(obj)).min_taper_stress_top_unbuoyed), ","), r_t(Conversions.ToInteger(obj)).max_taper_force_top_unbuoyed), ","), r_t(Conversions.ToInteger(obj)).min_taper_force_top_unbuoyed), ""), ","), r_t(Conversions.ToInteger(obj)).max_taper_stress_bot_buoyed), ","), r_t(Conversions.ToInteger(obj)).min_taper_stress_bot_buoyed), ","), r_t(Conversions.ToInteger(obj)).max_taper_force_bot_buoyed), ","), r_t(Conversions.ToInteger(obj)).min_taper_force_bot_buoyed), ""), ","), r_t(Conversions.ToInteger(obj)).max_taper_stress_bot_unbuoyed), ","), r_t(Conversions.ToInteger(obj)).min_taper_stress_bot_unbuoyed), ","), r_t(Conversions.ToInteger(obj)).max_taper_force_bot_unbuoyed), ","), r_t(Conversions.ToInteger(obj)).min_taper_force_bot_unbuoyed), ""), ","), r_t(Conversions.ToInteger(obj)).rod_area), ","), r_t(Conversions.ToInteger(obj)).force_buoy_cum), ","), r_t(Conversions.ToInteger(obj)).taper_len), ","), r_t(Conversions.ToInteger(obj)).taper_tvd), ","), r_t(Conversions.ToInteger(obj)).hydrostat_psia_tbg) })
							Loop While ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj, obj49, obj)
						End If
						FileSystem.PrintLine(num125, New Object() { "ntap ,SxTopB,SnTopB,FxTopB,FnTopB ,SxTopU,SnTopU,FxTopU,FnTopU ,SxBotB,SnBotB,FxBotB,FnBotB,SxBotU,SnBotU,FxBotU,FnBotU,Atap,FBcum,TapLen,tvd,Phyd" })
						Debug.WriteLine(" ")
						FileSystem.FileClose(New Integer() { num125 })
					End If
					p_s.period = CDbl(p_s.num_timesteps) * p_s.timestep_length
					Me.m_PRHP = 0F
					Me.m_PHP = 0F
					Me.m_EHP = 0F
					Dim obj50 As Object
					If ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj, 1, p_s.num_timesteps - 1, 1, obj50, obj) Then
						Do
							Me.m_PRHP = CSng((CDbl(Me.m_PRHP) + (t_s(Conversions.ToInteger(obj)).p_r_force + t_s(Conversions.ToInteger(Operators.AddObject(obj, 1))).p_r_force) / 2.0 * (t_s(Conversions.ToInteger(Operators.AddObject(obj, 1))).p_r_position - t_s(Conversions.ToInteger(obj)).p_r_position)))
							Me.m_PHP = CSng((CDbl(Me.m_PHP) + (t_s(Conversions.ToInteger(obj)).pump_force + t_s(Conversions.ToInteger(Operators.AddObject(obj, 1))).pump_force) / 2.0 * (t_s(Conversions.ToInteger(Operators.AddObject(obj, 1))).pump_displacement - t_s(Conversions.ToInteger(obj)).pump_displacement)))
							Me.m_EHP = CSng((CDbl(Me.m_EHP) + (t_s(Conversions.ToInteger(obj)).downhole_force + t_s(Conversions.ToInteger(Operators.AddObject(obj, 1))).downhole_force) / 2.0 * (t_s(Conversions.ToInteger(Operators.AddObject(obj, 1))).downhole_position - t_s(Conversions.ToInteger(obj)).downhole_position)))
						Loop While ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj, obj50, obj)
					End If
					Me.m_PRHP = CSng((CDbl(Me.m_PRHP) + (t_s(p_s.num_timesteps).p_r_force + t_s(1).p_r_force) / 2.0 * (t_s(1).p_r_position - t_s(p_s.num_timesteps).p_r_position)))
					Me.m_PHP = CSng((CDbl(Me.m_PHP) + (t_s(Me.num_timesteps).pump_force + t_s(1).pump_force) / 2.0 * (t_s(1).pump_displacement - t_s(p_s.num_timesteps).pump_displacement)))
					Me.m_EHP = CSng((CDbl(Me.m_EHP) + (t_s(p_s.num_timesteps).downhole_force + t_s(1).downhole_force) / 2.0 * (t_s(1).downhole_position - t_s(p_s.num_timesteps).downhole_position)))
					Me.m_PRHP = CSng((CDbl((Me.m_PRHP * 60F / 12F / 33000F)) / p_s.period))
					Me.m_PHP = CSng((CDbl((Me.m_PHP * 60F / 33000F)) / p_s.period))
					Me.m_EHP = CSng((CDbl((Me.m_EHP * 60F / 33000F)) / p_s.period))
					Dim num126 As Integer = 0
					If num126 = 1 Then
						Dim text As String = "c:\TempRSWINFiles\Pump_Force_Debug.csv"
						Dim obj51 As Object
						If FILEUTIL.FileExists(text) Then
							FileSystem.FileClose(New Integer() { Conversions.ToInteger(obj51) })
							FileSystem.Kill("c:\TempRSWINFiles\Pump_Force_Debug.csv")
						End If
						obj51 = FileSystem.FreeFile()
						FileSystem.FileOpen(Conversions.ToInteger(obj51), "c:\TempRSWINFiles\Pump_Force_Debug.csv", OpenMode.Output, OpenAccess.[Default], OpenShare.[Default], -1)
						FileSystem.PrintLine(Conversions.ToInteger(obj51), New Object() { " ts#, pump force, Fp - BuoyedRodWt, Buoyed Rod Weight, Fp -BuoyRodWt +BuoyPumpWt, BuoyPumpWt" })
						Dim obj52 As Object
						If ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj, 1, p_s.num_timesteps, 1, obj52, obj) Then
							Do
								FileSystem.PrintLine(Conversions.ToInteger(obj51), New Object() { String.Concat(New String() { obj.ToString(), " , ", Conversions.ToString(t_s(Conversions.ToInteger(obj)).pump_force), " , ", Conversions.ToString(t_s(Conversions.ToInteger(obj)).pump_force - r_e(p_s.num_rod_elements).buoy_weight), " , ", Conversions.ToString(r_e(p_s.num_rod_elements).buoy_weight), " , ", Conversions.ToString(t_s(Conversions.ToInteger(obj)).pump_force - r_e(p_s.num_rod_elements).buoy_weight + p_s.pump_weight_buoyed), " , ", Conversions.ToString(p_s.pump_weight_buoyed) }) })
							Loop While ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj, obj52, obj)
						End If
						FileSystem.PrintLine(Conversions.ToInteger(obj51), New Object() { " ts#, pump force, Fp - BuoyedRodWt, Buoyed Rod Weight, Fp -BuoyRodWt +BuoyPumpWt, BuoyPumpWt" })
						FileSystem.FileClose(New Integer() { Conversions.ToInteger(obj51) })
					End If
					Dim num127 As Integer = 0
					Dim num128 As Integer = 0
					If flag And Not RSWIN_DESC.rst.gbIncludeBuoyancy Then
						If flag2 Then
							Dim flag18 As Boolean = False
							Dim obj53 As Object
							If ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj, 1, p_s.num_timesteps, 1, obj53, obj) Then
								Do
									If t_s(Conversions.ToInteger(obj)).pump_force < -2.0 * p_s.p_drag_f_max_dn Then
										flag18 = True
										obj = p_s.num_timesteps
									End If
								Loop While ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj, obj53, obj)
							End If
							Dim obj54 As Object
							If(p_s.i_downhole_dyno <> 0 And p_s.i_downhole_dyno <> p_s.num_rod_elements) AndAlso ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj, 2, p_s.num_rod_elements, 1, obj54, obj) Then
								Do
									If r_e(Conversions.ToInteger(obj)).m_d > r_e(p_s.i_downhole_dyno).m_d Then
										p_s.force_buoy_cum_at_downhole_dyno = r_e(Conversions.ToInteger(Operators.SubtractObject(obj, 1))).force_buoy_cum
										obj = p_s.num_rod_elements
									End If
								Loop While ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj, obj54, obj)
							End If
							Dim obj55 As Object
							If ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj, 1, p_s.num_timesteps, 1, obj55, obj) Then
								Do
									If flag18 Then
										t_s(Conversions.ToInteger(obj)).pump_force_orig = t_s(Conversions.ToInteger(obj)).pump_force
										t_s(Conversions.ToInteger(obj)).pump_force = t_s(Conversions.ToInteger(obj)).pump_force - p_s.rod_bot_load_min + p_s.rod_bot_load_max
										t_s(Conversions.ToInteger(obj)).pump_force_corrected = t_s(Conversions.ToInteger(obj)).pump_force + r_e(p_s.num_rod_elements).gravity_force - p_s.pump_fluid_load
										t_s(Conversions.ToInteger(obj)).pump_force_check = -t_s(Conversions.ToInteger(obj)).p_drag_force - p_s.pump_weight_buoyed + t_s(Conversions.ToInteger(obj)).pump_psia_a * p_s.pump_area - t_s(Conversions.ToInteger(obj)).pump_psia_p * p_s.pump_area
										t_s(Conversions.ToInteger(obj)).p_drag_force = t_s(Conversions.ToInteger(obj)).p_drag_force
										t_s(Conversions.ToInteger(obj)).bp_drag_force = t_s(Conversions.ToInteger(obj)).bp_drag_force
										t_s(Conversions.ToInteger(obj)).SV_drag_force = t_s(Conversions.ToInteger(obj)).SV_drag_force
										t_s(Conversions.ToInteger(obj)).TV_drag_force = t_s(Conversions.ToInteger(obj)).TV_drag_force
									End If
									If num127 = 1 AndAlso flag18 Then
										t_s(Conversions.ToInteger(obj)).p_r_force_orig = t_s(Conversions.ToInteger(obj)).p_r_force
										t_s(Conversions.ToInteger(obj)).p_r_force = t_s(Conversions.ToInteger(obj)).p_r_force - p_s.rod_bot_load_min + p_s.rod_bot_load_max
									End If
									If(p_s.i_downhole_dyno <> 0 And p_s.i_downhole_dyno <> p_s.num_rod_elements) AndAlso (num128 = 1 AndAlso flag18) Then
										t_s(Conversions.ToInteger(obj)).downhole_force_orig = t_s(Conversions.ToInteger(obj)).downhole_force
										t_s(Conversions.ToInteger(obj)).downhole_force = t_s(Conversions.ToInteger(obj)).downhole_force - p_s.rod_bot_load_min + p_s.rod_bot_load_max
									End If
								Loop While ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj, obj55, obj)
							End If
							Dim num129 As Integer = 0
							If num129 = 1 And num19 - 1 = p_s.num_cycles Then
								Debug.WriteLine("")
								Debug.WriteLine(String.Concat(New String() { "MaxFp=,,", Conversions.ToString(p_s.pump_fluid_load), ",minFp=,,", Conversions.ToString(p_s.min_pump_load), ",bot_rod_buoy_wt=,,", Conversions.ToString(r_e(p_s.num_rod_elements).buoy_weight) }))
								Debug.WriteLine("Unbuoyed_last_i_cycle_dynamometer-card_plotting")
								Debug.WriteLine("i_cyc,i_step,PRP,PRL,Ppump,Fpump,dhol,Pi,Fi")
								Dim obj56 As Object
								If ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj, 1, p_s.num_timesteps, 1, obj56, obj) Then
									Do
										' The following expression was wrapped in a checked-expression
										Debug.WriteLine(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Conversions.ToString(num19 - 1) + ",", obj), ","), t_s(Conversions.ToInteger(obj)).p_r_position), ","), t_s(Conversions.ToInteger(obj)).p_r_force), ","), t_s(Conversions.ToInteger(obj)).pump_displacement * 12.0), ","), t_s(Conversions.ToInteger(obj)).pump_force), ","), p_s.i_downhole_dyno), ","), t_s(Conversions.ToInteger(obj)).downhole_position * 12.0), ","), t_s(Conversions.ToInteger(obj)).downhole_force))
									Loop While ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj, obj56, obj)
								End If
								Debug.WriteLine("i_cyc,i_step,PRP,PRL,Ppump,Fpump,dhol,Pi,Fi")
								Debug.WriteLine("Unbuoyed_last_i_cycle_dynamometer-card_plotting")
								Debug.WriteLine("")
							End If
						Else
							Dim flag19 As Boolean = False
							Dim num130 As Single = 1000000F
							Dim num131 As Single = -100000F
							Dim obj57 As Object
							If ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj, 1, p_s.num_timesteps, 1, obj57, obj) Then
								Do
									If t_s(Conversions.ToInteger(obj)).pump_force < 0.0 Then
										flag19 = True
									End If
									If CDbl(num130) > t_s(Conversions.ToInteger(obj)).pump_force Then
										num130 = CSng(t_s(Conversions.ToInteger(obj)).pump_force)
									End If
									If CDbl(num131) < t_s(Conversions.ToInteger(obj)).pump_force Then
										num131 = CSng(t_s(Conversions.ToInteger(obj)).pump_force)
									End If
								Loop While ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj, obj57, obj)
							End If
							Dim obj58 As Object
							If ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj, 1, p_s.num_timesteps, 1, obj58, obj) Then
								Do
									If flag19 Then
										t_s(Conversions.ToInteger(obj)).pump_force = t_s(Conversions.ToInteger(obj)).pump_force - CDbl(num130) - p_s.p_drag_f_max_up
									End If
								Loop While ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj, obj58, obj)
							End If
						End If
					End If
					Dim num132 As Integer = 0
					If num132 = 1 Then
						Debug.WriteLine(" ")
						Debug.WriteLine(" " + Conversions.ToString(r_e(p_s.num_rod_elements).buoy_weight) + ",=r_e(p_s.num_rod_elements).buoy_weight")
						Debug.WriteLine(" " + Conversions.ToString(r_e(p_s.num_rod_elements).gravity_force) + ",=r_e(p_s.num_rod_elements).gravity_force")
						Debug.WriteLine(" " + Conversions.ToString(p_s.pump_fluid_load) + ",=p_s.pump_fluid_load")
						Debug.WriteLine(" " + Conversions.ToString(p_s.pump_weight_buoyed) + ",=p_s.pump_weight_buoyed")
						Debug.WriteLine(" " + Conversions.ToString(p_s.pump_area) + ",=p_s.pump_area")
						Debug.WriteLine("n Fp_orig Fp_mod Fp_cor Fp_ck Pp_a Pp_p Fp_dra Up Fr_buo   Vel_Ratio ")
						Dim obj59 As Object
						If ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj, 1, p_s.num_timesteps, 1, obj59, obj) Then
							Do
								Debug.WriteLine(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(obj, " "), t_s(Conversions.ToInteger(obj)).pump_force_orig), " "), t_s(Conversions.ToInteger(obj)).pump_force), " "), t_s(Conversions.ToInteger(obj)).pump_force_corrected), " "), t_s(Conversions.ToInteger(obj)).pump_force_check), " "), t_s(Conversions.ToInteger(obj)).pump_psia_a), " "), t_s(Conversions.ToInteger(obj)).pump_psia_p), " "), t_s(Conversions.ToInteger(obj)).p_drag_force), " "), 12.0 * t_s(Conversions.ToInteger(obj)).pump_displacement), " "), r_e(p_s.num_rod_elements).buoy_weight), " "), t_s(Conversions.ToInteger(obj)).vel_ratio))
							Loop While ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj, obj59, obj)
						End If
					End If
					If p_s.vari_spm = 1 Then
						Dim num133 As Double = -1.0
						Dim num134 As Double = 99999999999999.0
						Dim num135 As Double = 0.0
						Debug.WriteLine(Conversions.ToString(p_s.num_timesteps) + " , " + Conversions.ToString(t_s(p_s.num_cycles).num_timesteps))
						Dim obj60 As Object
						If ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj, 1, p_s.num_timesteps, 1, obj60, obj) Then
							Do
								num135 += t_s(Conversions.ToInteger(obj)).vel_mot
								If t_s(Conversions.ToInteger(obj)).vel_mot > num133 Then
									num133 = t_s(Conversions.ToInteger(obj)).vel_mot
								End If
								If t_s(Conversions.ToInteger(obj)).vel_mot < num134 Then
									num134 = t_s(Conversions.ToInteger(obj)).vel_mot
								End If
							Loop While ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj, obj60, obj)
						End If
						Dim num136 As Double = num135 / CDbl(p_s.num_timesteps) / 0.10471975511965977
						Dim num137 As Double = num136 / p_s.ratio_tot
						p_s.slip_op_pt = (p_s.rpm_no_load - num136) / p_s.rpm_no_load
						num133 /= 0.10471975511965977
						num134 /= 0.10471975511965977
						p_s.spm_variation = (num133 - num134) / p_s.rpm_no_load
					End If
					Dim text2 As String = "counterbalanced"
					Dim flag20 As Boolean = True
					If flag20 And Operators.CompareString(text2, "counterbalanced", False) = 0 Then
						Me.calc_cwt(p_s, t_s)
						Me.calc_cwt_min_ener(p_s, t_s)
					End If

				Dim num138 As Integer
				If True And Not RSWIN_DESC.bBETA And RSWIN_DESC.bWriteCSVFIles And num19 = Me.m_p_s.num_cycles + 1 Then
					Dim obj61 As Object
					If ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj, 1, p_s.num_rod_elements * 1 + 0, 1, obj61, obj) Then
						Do
							FileSystem.PrintLine(num138, New Object() { String.Concat(New String() { num18.ToString(), " , ", num19.ToString(), " , ", obj.ToString(), " , ", Conversions.ToString(r_e(Conversions.ToInteger(obj)).max_sf_total), " , ", Conversions.ToString(cart_coord_type2.x), " , ", Conversions.ToString(cart_coord_type2.y), " , ", Conversions.ToString(cart_coord_type2.z), " , ", Conversions.ToString(r_e(Conversions.ToInteger(obj)).dog), " , ", Conversions.ToString(r_e(Conversions.ToInteger(obj)).nor.x), " , ", Conversions.ToString(r_e(Conversions.ToInteger(obj)).nor.y), " , ", Conversions.ToString(r_e(Conversions.ToInteger(obj)).nor.z), " , ", Conversions.ToString(r_e(Conversions.ToInteger(obj)).pos.x), " , ", Conversions.ToString(r_e(Conversions.ToInteger(obj)).pos.y), " , ", Conversions.ToString(r_e(Conversions.ToInteger(obj)).pos.z), " , ", Conversions.ToString(r_e(Conversions.ToInteger(obj)).m_d) }) })
						Loop While ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj, obj61, obj)
					End If
					FileSystem.PrintLine(num138, New Object() { "i_step,i_cycle,n,r_e(n).max_sf_total,side_force_total.x,side_force_total.y,side_force_total.z,r_e(n).dog,r_e(n).nor.x,r_e(n).nor.y,r_e(n).nor.z,r_e(n).pos.x,r_e(n).pos.y,r_e(n).pos.z,r_e(n).m_d" })
				End If
				If Not RSWIN_DESC.bBETA And RSWIN_DESC.bWriteCSVFIles Then
					FileSystem.FileClose(New Integer() { num138 })
				End If
				GoTo IL_DBFB
				IL_DBA0:
				p_s.iostat = -9991
				GoTo IL_DBFB
				IL_DBAE:
				num139 = -1
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_DBC8:
			Catch obj63 When endfilter(TypeOf obj62 Is Exception And num3 <> 0 And num139 = 0)
				Dim ex As Exception = CType(obj63, Exception)
				GoTo IL_DBAE
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_DBFB:
			If num139 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		Public Sub calc_cwt(ByRef p_s As TEImpred.parameter_structure_type, ByRef t_s As TEImpred.timestep_data_type())
			Dim flag As Boolean = False
			Try
				Dim num As Integer = 0
				Dim num2 As Integer
				If 1 = num Then
					Dim text As String = "c:\TempRSWINFiles\cwt_bal_out.csv"
					If FILEUTIL.FileExists(text) Then
						FileSystem.FileClose(New Integer() { num2 })
						FileSystem.Kill("c:\TempRSWINFiles\cwt_bal_out.csv")
					End If
					num2 = FileSystem.FreeFile()
					FileSystem.FileOpen(num2, "c:\TempRSWINFiles\cwt_bal_out.csv", OpenMode.Output, OpenAccess.[Default], OpenShare.[Default], -1)
					FileSystem.PrintLine(num2, New Object() { "counterbalance torques" })
				End If
				Dim num3 As Integer = -1
				Dim num4 As Integer = -2
				Dim num5 As Integer = -3
				Dim flag2 As Boolean = True
				Select Case RSWIN_DESC.rst.PU.UnitType
					Case 1S, 2S, 5S, 9S
						Dim num6 As Double = 0.0
						Dim torq_cwt As Double = p_s.torq_cwt
						While Not flag
							' The following expression was wrapped in a checked-statement
							If p_s.vari_spm = 0 Then
								Dim num7 As Long = 1L
								t_s(CInt(num7)).vel_beam = t_s(CInt(num7)).p_r_position - t_s(p_s.num_timesteps).p_r_position / p_s.timestep_length / p_s.API_len_A / 12.0
								t_s(CInt(num7)).acc_beam = t_s(CInt(num7)).vel_beam - t_s(p_s.num_timesteps).vel_beam / p_s.timestep_avg
								t_s(CInt(num7)).vel_cr = t_s(CInt(num7)).delta_theta / p_s.timestep_length
								Dim num8 As Long = 2L
								Dim num9 As Long = CLng(p_s.num_timesteps)
								num7 = num8
								While num7 <= num9
									' The following expression was wrapped in a unchecked-expression
									' The following expression was wrapped in a checked-expression
									' The following expression was wrapped in a checked-expression
									t_s(CInt(num7)).vel_beam = t_s(CInt(num7)).p_r_position - t_s(CInt((num7 - 1L))).p_r_position / p_s.timestep_length / p_s.API_len_A / 12.0
									t_s(CInt(num7)).acc_beam = t_s(CInt(num7)).vel_beam - t_s(CInt((num7 - 1L))).vel_beam / p_s.timestep_length
									t_s(CInt(num7)).vel_cr = t_s(CInt(num7)).delta_theta / p_s.timestep_length
									num7 += 1L
								End While
							ElseIf p_s.vari_spm = 1 Then
							End If
							Dim num10 As Double = -1000000000.0
							Dim num11 As Double = -1000000000.0
							Dim num12 As Double = 1000000000.0
							Dim num13 As Long = 1L
							Dim num14 As Long = CLng(p_s.num_timesteps)
							For num7 As Long = num13 To num14
								Dim num15 As Double

									If num7 = 1L Then
										num15 = (t_s(1).p_r_position - t_s(p_s.num_timesteps).p_r_position) / p_s.timestep_length
									Else
										' The following expression was wrapped in a checked-expression
										' The following expression was wrapped in a checked-expression
										num15 = (t_s(CInt(num7)).p_r_position - t_s(CInt((num7 - 1L))).p_r_position) / p_s.timestep_length
									End If

								If p_s.vari_spm = 0 Then
									' The following expression was wrapped in a unchecked-expression
									' The following expression was wrapped in a checked-expression
									' The following expression was wrapped in a checked-expression
									' The following expression was wrapped in a checked-expression
									t_s(CInt(num7)).torq_p_r_stat = t_s(CInt(num7)).torq_fact / 12.0 * t_s(CInt(num7)).p_r_force - t_s(CInt(num7)).torq_fact / 12.0 * p_s.force_su
									t_s(CInt(num7)).torq_p_r = t_s(CInt(num7)).torq_p_r_stat + t_s(CInt(num7)).torq_fact / 12.0 * p_s.inert_beam * t_s(CInt(num7)).acc_beam / 32.17405 / p_s.API_len_A
									Dim a As Double = t_s(CInt(num7)).crank_angle + p_s.angl_cwt_phase
									t_s(CInt(num7)).torq_cwt = -p_s.torq_cwt * Math.Sin(a)
									If flag2 Then
										t_s(CInt(num7)).torq_cwt_exist = t_s(CInt(num7)).torq_cwt
									End If
								ElseIf p_s.vari_spm = 1 Then
								End If
								If num7 = 1L And t_s(p_s.num_timesteps).torq_p_r < 0.0 Then
									p_s.eff_pu_func = 1.0 / p_s.eff_pu
								ElseIf num7 > 1L And t_s(CInt((num7 - 1L))).torq_p_r < 0.0 Then
									p_s.eff_pu_func = 1.0 / p_s.eff_pu
								Else
									p_s.eff_pu_func = p_s.eff_pu
								End If
								t_s(CInt(num7)).torq_crank = t_s(CInt(num7)).torq_p_r / p_s.eff_pu_func + t_s(CInt(num7)).torq_cwt + CDbl(Me.m_Irot) * t_s(CInt(num7)).acc_cr / 32.17405
								If flag2 Then
									' The following expression was wrapped in a unchecked-expression
									' The following expression was wrapped in a checked-expression
									' The following expression was wrapped in a checked-expression
									' The following expression was wrapped in a checked-expression
									t_s(CInt(num7)).torq_crank_exist = t_s(CInt(num7)).torq_p_r / p_s.eff_pu_func + t_s(CInt(num7)).torq_cwt_exist + CDbl(Me.m_Irot) * t_s(CInt(num7)).acc_cr / 32.17405
								End If
								If num10 < t_s(CInt(num7)).torq_crank And num15 > 0.0 Then
									num4 = CInt(num7)
									num10 = t_s(CInt(num7)).torq_crank
								End If
								If num11 < t_s(CInt(num7)).torq_crank And num15 <= 0.0 Then
									num3 = CInt(num7)
									num11 = t_s(CInt(num7)).torq_crank
								End If
								If num12 > t_s(CInt(num7)).torq_crank Then
									num5 = CInt(num7)
									num12 = t_s(CInt(num7)).torq_crank
								End If
							Next
							p_s.torq_cwt_del = ((t_s(num4).torq_p_r - t_s(num3).torq_p_r) / p_s.eff_pu_func - p_s.torq_cwt * (Math.Sin(t_s(num4).crank_angle + p_s.angl_cwt_phase) - Math.Sin(t_s(num3).crank_angle + p_s.angl_cwt_phase)) + CDbl(Me.m_Irot) / 32.17405 * (t_s(num4).acc_cr - t_s(num3).acc_cr)) / (Math.Sin(t_s(num4).crank_angle + p_s.angl_cwt_phase) - Math.Sin(t_s(num3).crank_angle + p_s.angl_cwt_phase))
							If 1 = num Then
								FileSystem.PrintLine(num2, New Object() { "i_step, crank_angle, torq_crank_exist, torq_crank_improv, torq_crank_bal" })
								FileSystem.PrintLine(num2, New Object() { "       ,rad, ft-lbf, ft-lbf" })
							End If
							Dim num16 As Long = 1L
							Dim num17 As Long = CLng(p_s.num_timesteps)
							For num7 As Long = num16 To num17
								' The following expression was wrapped in a unchecked-expression
								' The following expression was wrapped in a checked-expression
								Dim a As Double = t_s(CInt(num7)).crank_angle + p_s.angl_cwt_phase
								t_s(CInt(num7)).torq_crank_bal = t_s(CInt(num7)).torq_crank - p_s.torq_cwt_del * Math.Sin(a)
								If 1 = num Then
									FileSystem.PrintLine(num2, New Object() { String.Concat(New String() { Conversions.ToString(num7), ",", Conversions.ToString(t_s(CInt(num7)).crank_angle), ",", Conversions.ToString(t_s(CInt(num7)).torq_crank_exist), ",", Conversions.ToString(t_s(CInt(num7)).torq_crank), ",", Conversions.ToString(t_s(CInt(num7)).torq_crank_bal) }) })
								End If
							Next
							If 1 = num Then
								FileSystem.PrintLine(num2, New Object() { Conversions.ToString(p_s.torq_cwt_del) + ", = incremental cwt torque" })
								FileSystem.PrintLine(num2, New Object() { Conversions.ToString(num6 + p_s.torq_cwt_del) + ", = cum incr cwt torque" })
								FileSystem.PrintLine(num2, New Object() { "up/dn, i_step, crank_angle, torq_crank_exist,torq_crank_improv, torq_crank_bal" })
								FileSystem.PrintLine(num2, New Object() { String.Concat(New String() { "up_stk,", Conversions.ToString(num4), ",", Conversions.ToString(t_s(num4).crank_angle), ",", Conversions.ToString(t_s(num4).torq_crank_exist * 12.0), ",", Conversions.ToString(t_s(num4).torq_crank * 12.0), ",", Conversions.ToString(t_s(num4).torq_crank_bal * 12.0) }) })
								FileSystem.PrintLine(num2, New Object() { String.Concat(New String() { "dn_stk,", Conversions.ToString(num3), ",", Conversions.ToString(t_s(num3).crank_angle), ",", Conversions.ToString(t_s(num3).torq_crank_exist * 12.0), ",", Conversions.ToString(t_s(num3).torq_crank * 12.0), ",", Conversions.ToString(t_s(num3).torq_crank_bal * 12.0) }) })
								FileSystem.PrintLine(num2, New Object() { String.Concat(New String() { "min_stk,", Conversions.ToString(num5), ",", Conversions.ToString(t_s(num5).crank_angle), ",", Conversions.ToString(t_s(num5).torq_crank_exist * 12.0), ",", Conversions.ToString(t_s(num5).torq_crank * 12.0), ",", Conversions.ToString(t_s(num5).torq_crank_bal * 12.0) }) })
								FileSystem.PrintLine(num2, New Object() { ",i_step, .crank_angle, .torq_crank_exist,.torq_crank_improv, .torq_crank_bal" })
								FileSystem.PrintLine(num2, New Object() { "     , ,rad, in-lbf, in-lbf, in-lbf" })
							End If
							If p_s.torq_cwt_del / p_s.torq_cwt > 0.0001 Then
								num6 += p_s.torq_cwt_del
								p_s.torq_cwt = torq_cwt + num6
							Else
								flag = True
							End If
							p_s.prhp_exist = (t_s(1).p_r_force + t_s(p_s.num_timesteps).p_r_force) / 2.0 * (t_s(1).p_r_position - t_s(p_s.num_timesteps).p_r_position)
							p_s.cwhp_exist = (t_s(1).torq_crank + t_s(p_s.num_timesteps).torq_crank) / 2.0 * (t_s(1).vel_cr + t_s(p_s.num_timesteps).vel_cr) / 2.0
							p_s.cwhp_PT_bal = (t_s(1).torq_crank_bal + t_s(p_s.num_timesteps).torq_crank_bal) / 2.0 * (t_s(1).vel_cr + t_s(p_s.num_timesteps).vel_cr) / 2.0
							Dim num18 As Long = 2L
							Dim num19 As Long = CLng(p_s.num_timesteps)
							For num7 As Long = num18 To num19
								' The following expression was wrapped in a checked-expression
								' The following expression was wrapped in a checked-expression
								' The following expression was wrapped in a checked-expression
								' The following expression was wrapped in a checked-expression
								p_s.prhp_exist += (t_s(CInt(num7)).p_r_force + t_s(CInt((num7 - 1L))).p_r_force) / 2.0 * (t_s(CInt(num7)).p_r_position - t_s(CInt((num7 - 1L))).p_r_position)
								p_s.cwhp_exist += (t_s(CInt(num7)).torq_crank + t_s(CInt((num7 - 1L))).torq_crank) / 2.0 * (t_s(CInt(num7)).vel_cr + t_s(CInt((num7 - 1L))).vel_cr) / 2.0
								p_s.cwhp_PT_bal += (t_s(CInt(num7)).torq_crank_bal + t_s(CInt((num7 - 1L))).torq_crank_bal) / 2.0 * (t_s(CInt(num7)).vel_cr + t_s(CInt((num7 - 1L))).vel_cr) / 2.0
							Next
							p_s.prhp_exist = p_s.prhp_exist * 60.0 / 12.0 / 33000.0 / p_s.period
							p_s.cwhp_exist = p_s.cwhp_exist * 60.0 / 33000.0 / CDbl(p_s.num_timesteps)
							p_s.cwhp_PT_bal = p_s.cwhp_PT_bal * 60.0 / 33000.0 / CDbl(p_s.num_timesteps)
							If 1 = num Then
								FileSystem.PrintLine(num2, New Object() { Conversions.ToString(p_s.torq_cwt_del) + ", = cwt change for next prhp" })
								FileSystem.PrintLine(num2, New Object() { Conversions.ToString(p_s.prhp_exist) + ", = pol-rod hp during torq balance" })
								FileSystem.PrintLine(num2, New Object() { Conversions.ToString(p_s.cwhp_exist) + ", = counterweight hp before peak-torq bal" })
								FileSystem.PrintLine(num2, New Object() { Conversions.ToString(p_s.cwhp_PT_bal) + ", = counterweight hp after peak-torq bal" })
							End If
							flag2 = False
						End While
						p_s.torq_cwt_del = num6
						p_s.torq_cwt = torq_cwt
				End Select
				If 1 = num Then
					FileSystem.PrintLine(num2, New Object() { " End of debug PrintLine from calc_cwt" })
					FileSystem.PrintLine(num2, New Object() { "  " })
					FileSystem.FileClose(New Integer() { num2 })
				End If
			Catch ex As Exception
			End Try
		End Sub

		Public Sub calc_cwt_min_ener(ByRef p_s As TEImpred.parameter_structure_type, ByRef t_s As TEImpred.timestep_data_type())
			Dim flag As Boolean = False
			Try
				Dim num As Integer = 0
				Dim num2 As Integer
				If 1 = num Then
					Dim text As String = "c:\TempRSWINFiles\cwt_bal_min_ener_out.csv"
					If FILEUTIL.FileExists(text) Then
						FileSystem.FileClose(New Integer() { num2 })
						FileSystem.Kill("c:\TempRSWINFiles\cwt_bal_min_ener_out.csv")
					End If
					num2 = FileSystem.FreeFile()
					FileSystem.FileOpen(num2, "c:\TempRSWINFiles\cwt_bal_min_ener_out.csv", OpenMode.Output, OpenAccess.[Default], OpenShare.[Default], -1)
					FileSystem.PrintLine(num2, New Object() { "counterbalance torques" })
					FileSystem.PrintLine(num2, New Object() { "i_step, crank_angle, torq_mot, torq_mot_bal" })
				End If
				Dim num3 As Integer = -1
				Dim num4 As Integer = -2
				Dim flag2 As Boolean = True
				Select Case RSWIN_DESC.rst.PU.UnitType
					Case 1S, 2S, 5S, 9S
						Dim num5 As Double = 0.0
						p_s.torq_cwt_ener = p_s.torq_cr + p_s.torq_cw
						Dim num16 As Double
						While Not flag
							If p_s.vari_spm = 0 OrElse p_s.vari_spm = 1 Then
							End If
							Dim num6 As Double = -1000000000.0
							Dim num7 As Double = -1000000000.0
							Dim num8 As Double = 1000000000.0
							Dim num9 As Long = 1L
							Dim num10 As Long = CLng(p_s.num_timesteps)
							For num11 As Long = num9 To num10
								Dim num12 As Double

									If num11 = 1L Then
										num12 = (t_s(1).p_r_position - t_s(p_s.num_timesteps).p_r_position) / p_s.timestep_length
									Else
										' The following expression was wrapped in a checked-expression
										' The following expression was wrapped in a checked-expression
										num12 = (t_s(CInt(num11)).p_r_position - t_s(CInt((num11 - 1L))).p_r_position) / p_s.timestep_length
									End If
									If p_s.vari_spm = 0 OrElse p_s.vari_spm = 1 Then
									End If

								If num11 = 1L And t_s(p_s.num_timesteps).torq_p_r < 0.0 Then
									p_s.eff_pu_func = 1.0 / p_s.eff_pu
								ElseIf num11 > 1L And t_s(CInt((num11 - 1L))).torq_p_r < 0.0 Then
									p_s.eff_pu_func = 1.0 / p_s.eff_pu
								Else
									p_s.eff_pu_func = p_s.eff_pu
								End If
								If num11 = 1L And t_s(p_s.num_timesteps).torq_mot < 0.0 Then
									p_s.eff_gb_func = 1.0 / p_s.eff_gb
									p_s.eff_vb_func = 1.0 / p_s.eff_vb
								ElseIf num11 > 1L And t_s(CInt((num11 - 1L))).torq_mot < 0.0 Then
									p_s.eff_gb_func = 1.0 / p_s.eff_gb
									p_s.eff_vb_func = 1.0 / p_s.eff_vb
								Else
									p_s.eff_gb_func = p_s.eff_gb
									p_s.eff_vb_func = p_s.eff_vb
								End If
								t_s(CInt(num11)).torq_mot = t_s(CInt(num11)).torq_p_r / p_s.eff_pu_func + t_s(CInt(num11)).torq_cwt + CDbl(Me.m_Irot) * t_s(CInt(num11)).acc_cr / 32.17405
								t_s(CInt(num11)).torq_mot = t_s(CInt(num11)).torq_mot / p_s.ratio_vb / p_s.ratio_gb
								If p_s.vari_spm = 0 Then
									' The following expression was wrapped in a unchecked-expression
									t_s(CInt(num11)).vel_mot = p_s.delta_theta / p_s.timestep_length * p_s.ratio_vb * p_s.ratio_gb
								ElseIf p_s.vari_spm = 1 Then
								End If
								p_s.mot_volt = 460
								p_s.num_phases = 3
								p_s.id_motor = "NEMA-D"
								p_s.hp_mot = p_s.hp_mot
								p_s.torq_full_load = p_s.torq_full_load
								p_s.vel_full_load = p_s.vel_full_load
								p_s.amp_full_load = p_s.amp_full_load
								p_s.amp_full_load = 172.0
								If p_s.num_phases <> 1 AndAlso p_s.num_phases <> 2 Then
									If p_s.num_phases <> 3 Then
										p_s.iostat = -8560
										Return
									End If
									If Operators.CompareString(p_s.id_motor, "NEMA-D", False) = 0 Then
										p_s.mot_a = 0.53977238190458
										p_s.mot_b = 0.023247167337514
										p_s.mot_c = 0.39841952575377
									ElseIf Operators.CompareString(p_s.id_motor, "UHS", False) = 0 Then
									End If
								End If
								If flag2 Then
									' The following expression was wrapped in a unchecked-expression
									' The following expression was wrapped in a checked-expression
									' The following expression was wrapped in a checked-expression
									' The following expression was wrapped in a checked-expression
									t_s(CInt(num11)).torq_mot_exist = t_s(CInt(num11)).torq_p_r / p_s.eff_pu_func + t_s(CInt(num11)).torq_cwt_exist + CDbl(Me.m_Irot) * t_s(CInt(num11)).acc_cr / 32.17405
									t_s(CInt(num11)).torq_mot_exist = t_s(CInt(num11)).torq_mot_exist / p_s.ratio_vb / p_s.ratio_gb
								End If
								If Operators.CompareString(p_s.id_motor, "NEMA-D", False) = 0 Then
									t_s(CInt(num11)).torq_mot_norm = t_s(CInt(num11)).torq_mot / p_s.torq_full_load
									t_s(CInt(num11)).amp_mot_norm = p_s.mot_a * Math.Pow(t_s(CInt(num11)).torq_mot_norm, 2.0) + p_s.mot_b * t_s(CInt(num11)).torq_mot_norm + p_s.mot_c
									t_s(CInt(num11)).amp_mot = t_s(CInt(num11)).amp_mot_norm * p_s.amp_full_load
									If flag2 Then
										t_s(CInt(num11)).torq_mot_norm = t_s(CInt(num11)).torq_mot_exist / p_s.torq_full_load
										t_s(CInt(num11)).amp_mot_norm = p_s.mot_a * Math.Pow(t_s(CInt(num11)).torq_mot_norm, 2.0) + p_s.mot_b * t_s(CInt(num11)).torq_mot_norm + p_s.mot_c
										t_s(CInt(num11)).amp_mot_exist = t_s(CInt(num11)).amp_mot_norm * p_s.amp_full_load
									End If
								ElseIf Operators.CompareString(p_s.id_motor, "UHS", False) = 0 AndAlso flag2 Then
									t_s(CInt(num11)).amp_mot_exist = 1.0
								End If
								If num6 < t_s(CInt(num11)).amp_mot And num12 > 0.0 Then
									num4 = CInt(num11)
									num6 = t_s(CInt(num11)).amp_mot
									p_s.eff_gb_func_up = p_s.eff_gb_func
									p_s.eff_vb_func_up = p_s.eff_vb_func
									p_s.eff_pu_func_up = p_s.eff_pu_func
									p_s.pf_and_mot_func_up = CDbl(p_s.mot_volt) * t_s(num4).amp_mot / t_s(num4).torq_mot / t_s(num4).vel_mot
								End If
								If num7 < t_s(CInt(num11)).amp_mot And num12 <= 0.0 Then
									num3 = CInt(num11)
									num7 = t_s(CInt(num11)).amp_mot
									p_s.eff_gb_func_dn = p_s.eff_gb_func
									p_s.eff_vb_func_dn = p_s.eff_vb_func
									p_s.eff_pu_func_dn = p_s.eff_pu_func
									p_s.pf_and_mot_func_dn = CDbl(p_s.mot_volt) * t_s(num3).amp_mot / t_s(num3).torq_mot / t_s(num3).vel_mot
								End If
								If num8 > t_s(CInt(num11)).amp_mot Then
									Dim num13 As Integer = CInt(num11)
									num8 = t_s(CInt(num11)).amp_mot
								End If
							Next
							p_s.torq_cwt_ener_del = ((t_s(num4).torq_p_r / p_s.eff_pu_func_up / p_s.eff_vb_func_up / p_s.eff_gb_func_up * p_s.pf_and_mot_func_up / CDbl(p_s.mot_volt) - t_s(num3).torq_p_r / p_s.eff_pu_func_dn / p_s.eff_vb_func_dn / p_s.eff_gb_func_dn) * p_s.pf_and_mot_func_dn / CDbl(p_s.mot_volt) - p_s.torq_cwt_ener * (Math.Sin(t_s(num4).crank_angle + p_s.angl_cwt_phase) - Math.Sin(t_s(num3).crank_angle + p_s.angl_cwt_phase)) + CDbl(Me.m_Irot) / 32.17405 * (t_s(num4).acc_cr - t_s(num3).acc_cr)) / (Math.Sin(t_s(num4).crank_angle + p_s.angl_cwt_phase) - Math.Sin(t_s(num3).crank_angle + p_s.angl_cwt_phase))
							If 1 = num Then
								FileSystem.PrintLine(num2, New Object() { "i_step, crank_angle, torq_mot_exist,torq_mot_improv, torq_mot_bal" })
								FileSystem.PrintLine(num2, New Object() { "       ,rad, ft-lbf, ft-lbf" })
							End If
							Dim num14 As Long = 1L
							Dim num15 As Long = CLng(p_s.num_timesteps)
							For num11 As Long = num14 To num15
								' The following expression was wrapped in a unchecked-expression
								' The following expression was wrapped in a checked-expression
								Dim a As Double = t_s(CInt(num11)).crank_angle + p_s.angl_cwt_phase
								t_s(CInt(num11)).torq_mot_ener_bal = t_s(CInt(num11)).torq_mot - p_s.torq_cwt_ener_del * Math.Sin(a) / p_s.ratio_vb / p_s.ratio_gb
								t_s(CInt(num11)).torq_mot_norm = t_s(CInt(num11)).torq_mot_ener_bal / p_s.torq_full_load
								t_s(CInt(num11)).amp_mot_norm = p_s.mot_a * Math.Pow(t_s(CInt(num11)).torq_mot_norm, 2.0) + p_s.mot_b * t_s(CInt(num11)).torq_mot_norm + p_s.mot_c
								t_s(CInt(num11)).amp_mot_ener_bal = t_s(CInt(num11)).amp_mot_norm * p_s.amp_full_load
								If 1 = num Then
									FileSystem.PrintLine(num2, New Object() { String.Concat(New String() { Conversions.ToString(num11), ",", Conversions.ToString(t_s(CInt(num11)).crank_angle), ",", Conversions.ToString(t_s(CInt(num11)).amp_mot_exist), ",", Conversions.ToString(t_s(CInt(num11)).torq_mot), ",", Conversions.ToString(t_s(CInt(num11)).amp_mot_ener_bal) }) })
								End If
							Next
							If 1 = num Then
								FileSystem.PrintLine(num2, New Object() { "i_step, .crank_angle, .amp_mot_exist, .torq_mot, .amp_mot_bal" })
								FileSystem.PrintLine(num2, New Object() { "       ,rad, amp, ft-lbf, amp" })
								FileSystem.PrintLine(num2, New Object() { " " })
								FileSystem.PrintLine(num2, New Object() { Conversions.ToString(p_s.torq_cwt_ener_del) + ", = incremental cwt torque" })
								FileSystem.PrintLine(num2, New Object() { Conversions.ToString(num5 + p_s.torq_cwt_ener_del) + ", = cum incr cwt torque" })
								FileSystem.PrintLine(num2, New Object() { "up/dn, i_step, .crank_angle, .torq_mot_exist, .torq_mot, .torq_mot_bal" })
								FileSystem.PrintLine(num2, New Object() { String.Concat(New String() { "up_stk,", Conversions.ToString(num4), ",", Conversions.ToString(t_s(num4).crank_angle), ",", Conversions.ToString(t_s(num4).torq_mot_exist), ",", Conversions.ToString(t_s(num4).torq_mot), ",", Conversions.ToString(t_s(num4).torq_mot_ener_bal) }) })
								FileSystem.PrintLine(num2, New Object() { String.Concat(New String() { "dn_stk,", Conversions.ToString(num3), ",", Conversions.ToString(t_s(num3).crank_angle), ",", Conversions.ToString(t_s(num3).torq_mot_exist), ",", Conversions.ToString(t_s(num3).torq_mot), ",", Conversions.ToString(t_s(num3).torq_mot_ener_bal) }) })
							End If
							If p_s.torq_cwt_ener_del / p_s.torq_cwt_ener > 0.0001 Then
								num5 += p_s.torq_cwt_ener_del
								p_s.torq_cwt_ener = num16 + num5
							Else
								flag = True
							End If
							p_s.mshp_en_bal = 0.0
							p_s.mshp_exist = 0.0
							Dim num17 As Long = 1L
							Dim num18 As Long = CLng(p_s.num_timesteps)
							For num11 As Long = num17 To num18
								' The following expression was wrapped in a checked-expression
								' The following expression was wrapped in a checked-expression
								p_s.mshp_en_bal += t_s(CInt(num11)).torq_mot_ener_bal * t_s(CInt(num11)).vel_mot
								p_s.mshp_exist += t_s(CInt(num11)).torq_mot * t_s(CInt(num11)).vel_mot
							Next
							p_s.mshp_en_bal = p_s.mshp_en_bal * 60.0 / 33000.0 / CDbl(p_s.num_timesteps)
							p_s.mshp_exist = p_s.mshp_exist * 60.0 / 33000.0 / CDbl(p_s.num_timesteps)
							If 1 = num Then
								FileSystem.PrintLine(num2, New Object() { Conversions.ToString(p_s.torq_cwt_ener_del) + ", = cwt change for next mshp" })
								FileSystem.PrintLine(num2, New Object() { Conversions.ToString(p_s.mshp_en_bal) + ", = mot-shaft hp after energy balance" })
								FileSystem.PrintLine(num2, New Object() { Conversions.ToString(p_s.mshp_exist) + ", = mot-shaft hp before energy balance" })
							End If
							flag2 = False
						End While
						p_s.torq_cwt_ener_del = num5
						p_s.torq_cwt_ener = num16
				End Select
				If 1 = num Then
					FileSystem.PrintLine(num2, New Object() { " End of debug PrintLine for cwt_bal_min_ener_out.csv" })
					FileSystem.PrintLine(num2, New Object() { "  " })
					FileSystem.FileClose(New Integer() { num2 })
				End If
				Dim num19 As Integer = 0
				If 1 = num19 Then
					Dim text As String = "c:\TempRSWINFiles\Mot_Torq_Eff_calc_cwt_min_ener.csv"
					Dim num20 As Integer
					If FILEUTIL.FileExists(text) Then
						FileSystem.FileClose(New Integer() { num20 })
						FileSystem.Kill("c:\TempRSWINFiles\Mot_Torq_Eff_calc_cwt_min_ener.csv")
					End If
					num20 = FileSystem.FreeFile()
					FileSystem.FileOpen(num20, "c:\TempRSWINFiles\Mot_Torq_Eff_calc_cwt_min_ener.csv", OpenMode.Output, OpenAccess.[Default], OpenShare.[Default], -1)
					FileSystem.PrintLine(num20, New Object() { "" })
					FileSystem.PrintLine(num20, New Object() { "Mot_Torq_Eff_calc_cwt_min_ener.csv, PrintLine" })
					FileSystem.PrintLine(num20, New Object() { Conversions.ToString(RSWIN_DESC.rst.mfRatedHP) + ",=rst.mfRatedHp" })
					Dim num21 As Integer = 0
					Dim num22 As Integer = Information.UBound(RSWIN_DESC.rst.mfEfficiency, 1)
					FileSystem.PrintLine(num20, New Object() { "K, rst.mfTorq, rst.mfeffic" })
					Dim num23 As Integer = num21
					Dim num24 As Integer = num22
					For i As Integer = num23 To num24
						If 1 = num Then
							FileSystem.PrintLine(num20, New Object() { String.Concat(New String() { Conversions.ToString(i), ",", Conversions.ToString(RSWIN_DESC.rst.mfTorque(i)), ",", Conversions.ToString(RSWIN_DESC.rst.mfEfficiency(i)) }) })
						End If
					Next
					FileSystem.PrintLine(num20, New Object() { "K, mfTorque(K), mfEffic(K)" })
					FileSystem.PrintLine(num20, New Object() { " End of debug PrintLine for Mot_Torq_Eff_calc_cwt_min_ener.csv" })
					FileSystem.PrintLine(num20, New Object() { "  " })
					FileSystem.FileClose(New Integer() { num20 })
				End If
			Catch ex As Exception
			End Try
		End Sub

		Public Sub calc_var_spm(ByRef p_s As TEImpred.parameter_structure_type)
			Dim flag As Boolean = False
			If flag Then
				p_s.ratio_tot = p_s.ratio_gb * p_s.ratio_vb
			ElseIf Not flag Then
				Dim num As Double = 1145.0
				p_s.ratio_tot = num / p_s.strokes_per_min
			End If
			p_s.ratio_vb = p_s.ratio_tot / p_s.ratio_gb
			p_s.torq_cr /= 12.0
			p_s.torq_cw /= 12.0
			p_s.torq_cwt = p_s.torq_cr + p_s.torq_cw
			p_s.inert_beam = p_s.wk_sq_beam * 32.17405 / 32.17405
			p_s.inert_cr = p_s.wk_sq_cr * 32.17405 / 32.17405
			p_s.inert_cw = p_s.wk_sq_cw * 32.17405 / 32.17405
			p_s.inert_cwt = p_s.wk_sq_cr + p_s.wk_sq_cw
			p_s.inert_gb = p_s.wk_sq_gb * 32.17405 / 32.17405
			p_s.inert_hss_cr = p_s.wk_sq_hss * 32.17405 / 32.17405 * Math.Pow(p_s.ratio_tot, 2.0)
			p_s.inert_lss_cr = p_s.wk_sq_lss * 32.17405 / 32.17405 * Math.Pow(p_s.ratio_gb, 2.0)
			p_s.inert_mot_cr = p_s.wk_sq_mot * 32.17405 / 32.17405 * Math.Pow(p_s.ratio_tot, 2.0)
			p_s.wk_sq_vb = 0.0
			p_s.inert_vb_cr = p_s.wk_sq_vb * 32.17405 / 32.17405 * p_s.ratio_tot
			p_s.iostat = 0
		End Sub

		Public Function fluid_inertia(ByRef i_cycle As Integer, ByRef i_step As Integer, ByRef f_e As TEImpred.fluid_element_data_type(), ByRef p_s As TEImpred.parameter_structure_type, ByRef r_e As TEImpred.rod_element_data_type(), ByRef r_t As TEImpred.rod_taper_data_type(), ByRef t_s As TEImpred.timestep_data_type(), ByRef t_t As TEImpred.tbg_taper_data_type(), ByRef count_try As Integer) As Boolean
			' The following expression was wrapped in a checked-statement
			Dim result As Boolean
			Try
				p_s.iostat = 0
				Dim damp_fluid As Double = p_s.damp_fluid
				Dim timestep_length As Double = p_s.timestep_length
				Dim flu_elem_length As Double = p_s.flu_elem_length
				Dim ref_psia As Double = p_s.ref_psia
				Dim flag As Boolean = False And i_step = 1 And i_cycle = 1
				If p_s.fluid_solution = 0 Then
					If i_step = 1 And i_cycle = 1 Then
						f_e(p_s.num_fluid_elem + 1).vel_flu = 0.0
					ElseIf i_step = 1 And i_cycle >= 2 Then
						If t_s(t_s(i_cycle - 1).num_timesteps).pump_velocity > 0.0 Then
							' The following expression was wrapped in a unchecked-expression
							' The following expression was wrapped in a checked-expression
							f_e(p_s.num_fluid_elem + 1).vel_flu = -(p_s.pump_area_mod - r_e(p_s.num_rod_elements).rod_area) * t_s(t_s(i_cycle - 1).num_timesteps).pump_velocity / (t_t(p_s.num_tbg_tapers).tbg_area_id - r_e(p_s.num_rod_elements).rod_area)
						Else
							' The following expression was wrapped in a unchecked-expression
							' The following expression was wrapped in a checked-expression
							f_e(p_s.num_fluid_elem + 1).vel_flu = r_e(p_s.num_rod_elements).rod_area * t_s(t_s(i_cycle - 1).num_timesteps).pump_velocity / (t_t(p_s.num_tbg_tapers).tbg_area_id - r_e(p_s.num_rod_elements).rod_area)
						End If
					ElseIf t_s(i_step - 1).pump_velocity > 0.0 Then
						' The following expression was wrapped in a unchecked-expression
						' The following expression was wrapped in a checked-expression
						f_e(p_s.num_fluid_elem + 1).vel_flu = -(p_s.pump_area_mod - r_e(p_s.num_rod_elements).rod_area) * t_s(i_step - 1).pump_velocity / (t_t(p_s.num_tbg_tapers).tbg_area_id - r_e(p_s.num_rod_elements).rod_area)
					Else
						' The following expression was wrapped in a unchecked-expression
						' The following expression was wrapped in a checked-expression
						f_e(p_s.num_fluid_elem + 1).vel_flu = r_e(p_s.num_rod_elements).rod_area * t_s(i_step - 1).pump_velocity / (t_t(p_s.num_tbg_tapers).tbg_area_id - r_e(p_s.num_rod_elements).rod_area)
					End If
					Dim i As Integer = p_s.num_fluid_elem + 1
					If(False And i_cycle = 1) AndAlso i_step <> 1 Then
						Dim flag2 As Boolean = i_step >= 2 And i_step <= 2108
					End If
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					While num <> 1
						i = p_s.num_fluid_elem
						While i >= 2

								If num2 = 0 Then
									f_e(i).tbg_flu_dens = p_s.liquid_gravity * 62.4 * (1.0 + p_s.comp_tot * (f_e(i).psia_flu_prev - ref_psia))
								End If
								Dim num3 As Double = (f_e(i - 1).vel_flu_prev - f_e(i + 1).vel_flu_prev) / (4.0 * -flu_elem_length)
								Dim num4 As Double = 4633.0632000000005 / f_e(i).tbg_flu_dens * (f_e(i - 1).psia_flu_prev - f_e(i + 1).psia_flu_prev) / (2.0 * -flu_elem_length)
								Dim num5 As Double = damp_fluid / 2.0
								f_e(i).vel_flu = (f_e(i).vel_flu_prev * (1.0 / timestep_length - num3 - num5) - num4 - -32.17405 * Math.Sin(-f_e(i).hole_slope)) / (1.0 / timestep_length + num3 + num5)
								Dim num6 As Double = 144.0 / p_s.comp_tot * 32.17405 / f_e(i).tbg_flu_dens
								If num6 < 0.0 Then
									Return False
								End If
								num6 = Math.Sqrt(num6)
								If False And i_cycle = 1 Then
									If i_step = 1 Then
										Dim num7 As Double = num6 * t_s(i_step).timestep_var
									ElseIf i_step >= 2 And i_step <= 2108 Then
										' The following expression was wrapped in a checked-expression
										Dim num7 As Double = num6 * (t_s(i_step).timestep_var - t_s(i_step - 1).timestep_var)
									End If
									Dim flag3 As Boolean = i_step >= 1 And i_step <= 2108
								End If
								If num6 > flu_elem_length / timestep_length Then
									p_s.iostat = -8532
								End If
								If num6 < flu_elem_length / timestep_length * 0.2 Then
								End If

							i += -1
						End While
						i = 1
						f_e(i).hole_slope = -1.5707963267948966
						Dim num8 As Integer
						Dim num_fluid_elem As Integer

							If num2 = 0 Then
								f_e(i).tbg_flu_dens = p_s.liquid_gravity * 62.4 * (1.0 + p_s.comp_tot * (f_e(i).psia_flu_prev - ref_psia))
							End If
							Dim num3 As Double = (f_e(i).vel_flu_prev - f_e(i + 1).vel_flu_prev) / (2.0 * -flu_elem_length)
							Dim num4 As Double = 4633.0632000000005 / f_e(i).tbg_flu_dens * (f_e(i).psia_flu_prev - f_e(i + 1).psia_flu_prev) / -flu_elem_length
							Dim num5 As Double = damp_fluid / 2.0
							f_e(i).vel_flu = (f_e(i).vel_flu_prev * (1.0 / timestep_length - num3 - num5) - num4 - -32.17405 * Math.Sin(-f_e(i).hole_slope)) / (1.0 / timestep_length + num3 + num5)
							Dim num6 As Double = 144.0 / p_s.comp_tot * 32.17405 / f_e(i).tbg_flu_dens
							If num6 < 0.0 Then
								num6 = 5000.0
							Else
								num6 = Math.Sqrt(num6)
							End If
							If False And i_cycle = 1 Then
								If i_step = 1 Then
									Dim num7 As Double = num6 * t_s(i_step).timestep_var
								ElseIf i_step >= 2 And i_step <= 2108 Then
									' The following expression was wrapped in a checked-expression
									Dim num7 As Double = num6 * (t_s(i_step).timestep_var - t_s(i_step - 1).timestep_var)
								End If
							End If
							If num6 > flu_elem_length / timestep_length Then
								p_s.iostat = -8583
								Return False
							End If
							If Not(False And i_cycle = 1) OrElse (i_step >= 1 And i_step <= 2108) Then
							End If
							f_e(1).psia_flu = p_s.tubing_pressure + 14.7
							num8 = 2
							num_fluid_elem = p_s.num_fluid_elem

						i = num8
						While i <= num_fluid_elem

								Dim num9 As Double = (f_e(i).vel_flu + f_e(i).vel_flu_prev) / 2.0
								Dim num10 As Double = (f_e(i - 1).psia_flu_prev - f_e(i + 1).psia_flu_prev) / (2.0 * -flu_elem_length)
								Dim num11 As Double = 1.0 / p_s.comp_tot + f_e(i).psia_flu_prev / 2.0 - ref_psia
								Dim num12 As Double = (f_e(i - 1).vel_flu - f_e(i + 1).vel_flu) / (2.0 * -flu_elem_length)
								f_e(i).psia_flu = (f_e(i).psia_flu_prev / timestep_length - num9 * num10 - num11 * num12) / (1.0 / timestep_length + num12 / 2.0)
								If f_e(i).psia_flu < p_s.psia_min_allow Then
									f_e(i).psia_flu = p_s.psia_min_allow
								End If
								If False And i_cycle = 1 Then
									Dim flag4 As Boolean = i_step >= 1 And i_step <= 2108
								End If

							i += 1
						End While
						i = p_s.num_fluid_elem + 1
						Dim num13 As Double
						Dim num14 As Double
						Dim num15 As Double
						Dim num16 As Double
						Dim num17 As Integer

							Dim num9 As Double = (f_e(i).vel_flu + f_e(i).vel_flu_prev) / 2.0
							Dim num10 As Double = (f_e(i - 1).psia_flu_prev - f_e(i).psia_flu_prev) / -flu_elem_length
							Dim num11 As Double = 1.0 / p_s.comp_tot + f_e(i).psia_flu_prev / 2.0 - ref_psia
							Dim num12 As Double = (f_e(i - 1).vel_flu - f_e(i).vel_flu) / -flu_elem_length
							f_e(i).psia_flu = (f_e(i).psia_flu_prev / timestep_length - num9 * num10 - num11 * num12) / (1.0 / timestep_length + num12 / 2.0)
							If f_e(i).psia_flu < p_s.psia_min_allow Then
								f_e(i).psia_flu = p_s.psia_min_allow
							End If
							t_s(i_step).pump_psia_a = f_e(i).psia_flu
							If False And i_cycle = 1 Then
								Dim flag5 As Boolean = i_step >= 1 And i_step <= 2108
							End If
							num13 = -100000.0
							num14 = 0.5
							num15 = -100000.0
							num16 = 0.05
							num17 = 1

						Dim num18 As Integer = p_s.num_fluid_elem + 1
						i = num17
						While i <= num18

								Dim num19 As Double = Math.Abs(f_e(i).psia_flu - f_e(i).psia_flu_prev)
								If num19 > num13 Then
									num13 = num19
								End If
								num19 = Math.Abs(f_e(i).vel_flu - f_e(i).vel_flu_prev)
								If num19 > num15 Then
									num15 = num19
								End If

							i += 1
						End While
						If num2 = 0 Then
							Dim psia_flu As Double = f_e(p_s.num_fluid_elem + 1).psia_flu
							Dim vel_flu As Double = f_e(1).vel_flu
						End If
						If num13 <= num14 And num15 <= num16 Then
							num = 1
						Else
							num2 += 1
							If count_try = 0 Then
								Dim num20 As Integer = 1
								Dim num21 As Integer = p_s.num_fluid_elem + 1
								i = num20
								While i <= num21
									Dim num22 As Double = 1.0
									Dim num23 As Integer = 2
									If num23 = 1 Then
										num22 = 0.5
									End If

										f_e(i).vel_flu_prev = num22 * f_e(i).vel_flu + (1.0 - num22) * f_e(i).vel_flu_prev
										num22 = 1.0
										Dim num24 As Integer = 2
										If num24 = 1 Then
											num22 = 0.5
										End If
										f_e(i).psia_flu_prev = num22 * f_e(i).psia_flu + (1.0 - num22) * f_e(i).psia_flu_prev

									i += 1
								End While
							End If
							Dim num25 As Integer
							If num = 0 Then
								num25 = 1
							End If
							If num25 = 1 Then
								num = 1
								num2 = -1
							End If
						End If
						Dim flag6 As Boolean = num2 > 50 And num2 < 55
					End While
					result = True
				ElseIf p_s.fluid_solution = 1 Then
					p_s.iostat = -8580
					result = False
				Else
					p_s.iostat = -8600
					result = False
				End If
			Catch ex As Exception
				result = False
			End Try
			Return result
		End Function

		Public Sub read_fluid_inertia(ByRef p_s As TEImpred.parameter_structure_type, Optional bRead As Boolean = False, Optional bWrite As Boolean = False)
			Dim num As Integer
			If bRead Then
				num = FileSystem.FreeFile()
				FileSystem.FileOpen(num, "c:\TempRSWINFiles\flu_iner.dat", OpenMode.Input, OpenAccess.[Default], OpenShare.[Default], -1)
			End If
			If bRead Then
				FileSystem.Input(num, p_s.fluid_solution)
			End If
			If bRead Then
				FileSystem.Input(num, p_s.comp_tot)
			End If
			If bRead Then
				FileSystem.Input(num, p_s.ref_psia)
			End If
			If bRead Then
				FileSystem.Input(num, p_s.pump_load_adj)
			End If
			If bRead Then
				FileSystem.Input(num, p_s.damp_fluid)
			End If
			If bRead Then
				FileSystem.FileClose(New Integer() { num })
			End If
			If bWrite Then
				Dim text As String = "c:\TempRSWINFiles\RSWIN-flu_iner.dat"
				Dim num2 As Integer
				If FILEUTIL.FileExists(text) Then
					FileSystem.FileClose(New Integer() { num2 })
					FileSystem.Kill("c:\TempRSWINFiles\RSWIN-flu_iner.dat")
				End If
				num2 = FileSystem.FreeFile()
				FileSystem.FileOpen(num2, "c:\TempRSWINFiles\RSWIN-flu_iner.dat", OpenMode.Output, OpenAccess.[Default], OpenShare.[Default], -1)
				FileSystem.PrintLine(num2, New Object() { p_s.fluid_solution })
				FileSystem.PrintLine(num2, New Object() { p_s.comp_tot })
				FileSystem.PrintLine(num2, New Object() { p_s.ref_psia })
				FileSystem.PrintLine(num2, New Object() { p_s.pump_load_adj })
				p_s.damp_fluid = 0.04
				FileSystem.PrintLine(num2, New Object() { p_s.damp_fluid })
				FileSystem.FileClose(New Integer() { num2 })
				Return
			End If
		End Sub

		Public Sub calc_fluid_inertia(ByRef f_e As TEImpred.fluid_element_data_type(), ByRef p_s As TEImpred.parameter_structure_type, ByRef r_e As TEImpred.rod_element_data_type())
			p_s.iostat = 0
			If p_s.fluid_solution = 0 Then
				Dim num As Double = p_s.liquid_gravity * 62.4
				Dim comp_tot As Double = p_s.comp_tot
				Dim num2 As Double = 144.0 / comp_tot * 32.17405 / num
				If num2 < 0.0 Then
					Return
				End If
				num2 = Math.Sqrt(num2)
				Dim num3 As Double = p_s.timestep_length * num2
				Dim num4 As Double = CDbl(p_s.num_rod_elements) * p_s.rod_element_length
				p_s.num_fluid_elem = CInt(Math.Round(Me.get_r_t(p_s.num_rod_tapers).taper_depth / num3))
				p_s.num_fluid_elem -= 1
				p_s.flu_elem_length = num4 / CDbl(p_s.num_fluid_elem)
				If p_s.num_fluid_elem > p_s.max_fluid_elem Then
					p_s.iostat = -8534
					Return
				End If
				f_e(1).m_d = 0.0
				f_e(1).psia_flu = 14.7 + p_s.tubing_pressure
				f_e(1).psia_flu_prev = 14.7 + p_s.tubing_pressure
				f_e(1).vel_flu = 0.0
				f_e(1).vel_flu_prev = 0.0
				f_e(1).tbg_flu_dens = p_s.liquid_gravity * 62.4 * (1.0 + p_s.comp_tot * (f_e(1).psia_flu_prev - p_s.ref_psia))
				Dim num5 As Integer = 2
				Dim num_fluid_elem As Integer = p_s.num_fluid_elem
				Dim i As Integer
				Dim num7 As Integer
				i = num5
				While i <= num_fluid_elem

						' The following expression was wrapped in a checked-expression
						f_e(i).m_d = Convert.ToDouble(i - 1) * p_s.flu_elem_length
						Dim num6 As Integer = 0
						num7 = 1
						While num6 <> 1
							' The following expression was wrapped in a checked-statement
							num7 += 1
							If num7 = p_s.num_rod_elements - 1 Then
								num6 = 1
							End If
							If f_e(i).m_d < r_e(num7).m_d Then
								' The following expression was wrapped in a checked-expression
								' The following expression was wrapped in a checked-expression
								' The following expression was wrapped in a checked-expression
								' The following expression was wrapped in a checked-expression
								f_e(i).psia_flu = r_e(num7 - 1).hydrostat_psia_tbg + (r_e(num7).hydrostat_psia_tbg - r_e(num7 - 1).hydrostat_psia_tbg) / (r_e(num7).m_d - r_e(num7 - 1).m_d) * (f_e(i).m_d - r_e(num7 - 1).m_d)
								f_e(i).psia_flu_prev = f_e(i).psia_flu
								num6 = 1
							ElseIf num7 = p_s.num_rod_elements - 1 Then
								' The following expression was wrapped in a checked-expression
								' The following expression was wrapped in a checked-expression
								f_e(i).psia_flu = r_e(num7).hydrostat_psia_tbg + (r_e(num7 + 1).hydrostat_psia_tbg - r_e(num7).hydrostat_psia_tbg) / (r_e(num7 + 1).m_d - r_e(num7).m_d) * (f_e(i).m_d - r_e(num7).m_d)
								f_e(i).psia_flu_prev = f_e(i).psia_flu
								num6 = 1
							End If
						End While
						f_e(i).vel_flu = 0.0
						f_e(i).vel_flu_prev = 0.0
						f_e(i).tbg_flu_dens = p_s.liquid_gravity * 62.4 * (1.0 + p_s.comp_tot * (f_e(i).psia_flu_prev - p_s.ref_psia))

					i += 1
				End While
				i = p_s.num_fluid_elem + 1
				num7 = p_s.num_rod_elements
				f_e(i).m_d = r_e(num7).m_d
				f_e(i).psia_flu = r_e(num7).hydrostat_psia_tbg
				f_e(i).psia_flu_prev = r_e(num7).hydrostat_psia_tbg
				f_e(i).vel_flu = 0.0
				f_e(i).vel_flu_prev = 0.0
				f_e(i).tbg_flu_dens = p_s.liquid_gravity * 62.4 * (1.0 + p_s.comp_tot * (f_e(i).psia_flu_prev - p_s.ref_psia))
			Else
				If p_s.fluid_solution = 1 Then
					p_s.iostat = -8581
					Return
				End If
				If p_s.fluid_solution <> -1 Then
					p_s.iostat = -8591
					Return
				End If
			End If
			Dim num8 As Integer = 0
			Dim num9 As Integer = 1
			Dim num10 As Integer = p_s.num_fluid_elem + 1
			For i As Integer = num9 To num10
				If f_e(i).m_d < r_e(1).m_d Then

						Dim num11 As Double = r_e(1).dog / (r_e(2).m_d - r_e(1).m_d) * (f_e(i).m_d - r_e(1).m_d)
						f_e(i).hole_slope = num11 - 1.5707963267948966

					num8 += 1
				End If
			Next
			Dim num12 As Integer = num8 + 1
			Dim num13 As Integer = p_s.num_fluid_elem - 1 + 2
			For i As Integer = num12 To num13
				Dim num14 As Double = 0.0
				Dim num6 As Integer = 0
				Dim num7 As Integer = 1
				While num6 <> 1

						num14 += r_e(num7).dog
						If f_e(i).m_d < r_e(num7).m_d Then
							' The following expression was wrapped in a checked-expression
							' The following expression was wrapped in a checked-expression
							Dim num11 As Double = r_e(num7).dog / (r_e(num7).m_d - r_e(num7 - 1).m_d) * (f_e(i).m_d - r_e(num7 - 1).m_d)
							f_e(i).hole_slope = num14 + num11 - 1.5707963267948966
							num6 = 1
						ElseIf num7 = p_s.num_rod_elements - 1 Then
							' The following expression was wrapped in a checked-expression
							Dim num11 As Double = r_e(num7).dog / (r_e(num7 + 1).m_d - r_e(num7).m_d) * (f_e(i).m_d - r_e(num7).m_d)
							f_e(i).hole_slope = num14 + num11 - 1.5707963267948966
							num6 = 1
						End If

					num7 += 1
				End While
			Next
			p_s.psia_max = -99999990.0
			p_s.psia_min = 99999990.0
			p_s.psia_min_allow = 14.7
		End Sub

		Public Sub TEImpred2(ByRef p_s As TEImpred.parameter_structure_type, ByRef f_e As TEImpred.fluid_element_data_type(), ByRef l_u As TEImpred.lookup_table_data_type(), ByRef m_c As TEImpred.motor_characteristic_data_type(), ByRef p_u As TEImpred.pump_unit_data_point_type(), ByRef r_e As TEImpred.rod_element_data_type(), ByRef r_t As TEImpred.rod_taper_data_type(), ByRef s_p As TEImpred.survey_point_type(), ByRef t_s As TEImpred.timestep_data_type(), ByRef t_t As TEImpred.tbg_taper_data_type(), ByRef d_l As TEImpred.dog_leg_data_type())
			' The following expression was wrapped in a checked-statement
			Dim num As Integer
			Dim num6 As Integer
			Dim obj As Object
			Try
				Dim flag As Boolean = True
				ProjectData.ClearProjectError()
				num = 2
				Dim bWrite As Boolean = False
				Dim bRead As Boolean = False
				Me.pre_read_rod(p_s)
				Me.read_rod(p_s, r_t, t_t, bRead, bWrite)
				Me.post_read_rod(p_s, r_t)
				Me.pre_read_drag(p_s)
				Me.read_drag(p_s, bRead, bWrite)
				Me.post_read_drag(p_s)
				Me.pre_read_pump_off(p_s)
				Me.read_pump_off(p_s, bRead, bWrite)
				Me.post_read_pump_off(p_s)
				Me.pre_read_sur(p_s)
				Me.read_sur(p_s, s_p, bRead, bWrite)
				Me.post_read_sur(p_s, s_p)
				Me.pre_calc_sur(p_s)
				If flag Then
					p_s.iostat = p_s.iostat
				End If
				If flag Then
					Dim num_rod_elements As Integer = p_s.num_rod_elements
					Dim bReRun As Boolean = False
					Me.calc_sur(p_s, r_t, s_p, r_e, bReRun, True)
					Me.temp = CDbl(p_s.num_rod_elements)
					Dim flag2 As Boolean = False
					If r_t(1).taper_depth < r_t(1).rod_elem_len Then
						flag2 = True
					End If
					Dim num2 As Integer = 2
					Dim num_rod_tapers As Integer = p_s.num_rod_tapers
					Me.n = num2
					While Me.n <= num_rod_tapers
						' The following expression was wrapped in a unchecked-expression
						' The following expression was wrapped in a checked-expression
						If r_t(Me.n).taper_depth - r_t(Me.n - 1).taper_depth < r_t(Me.n).rod_elem_len Then
							flag2 = True
						End If
						Me.n += 1
					End While
					If flag2 Then
						p_s.num_rod_elements += 1
						bReRun = True
					End If
					If Me.temp <> CDbl(p_s.num_rod_elements) Then
						If Me.temp > CDbl(p_s.num_rod_elements) Then
							p_s.iostat = -9973
						End If
						Me.calc_sur(p_s, r_t, s_p, r_e, bReRun, True)
					End If
					Dim num3 As Single = CSng(p_s.num_rod_elements)
					Dim num4 As Integer = 0
					Dim num5 As Integer
					While (p_s.iostat = -9945 Or p_s.iostat = -9944 Or p_s.iostat = -9947) And num5 < 2000 And num4 < 100
						bReRun = True
						p_s.iostat = 0
						p_s.num_rod_elements += 1
						If p_s.num_rod_elements > p_s.Max_Rod_Elements Then
							p_s.iostat = -8526
							Exit While
						End If
						Me.calc_sur(p_s, r_t, s_p, r_e, bReRun, True)
						If p_s.iostat = -9945 Or p_s.iostat = -9944 Then
							num3 = CSng(p_s.num_rod_elements)
							num5 += 1
						ElseIf p_s.iostat = -9947 Then
							num3 = CSng(p_s.num_rod_elements)
							num4 += 1
						End If
					End While
					If p_s.num_rod_elements > RSWIN_DESC.SETUP_RodElementLimit And Not RSWIN_DESC.SETUP_UseDefaultRodElementLimit Then
						p_s.num_rod_elements = RSWIN_DESC.SETUP_RodElementLimit
						RSWIN_DESC.num_rod_elements = p_s.num_rod_elements
						p_s.iostat = 0
						Me.calc_sur(p_s, r_t, s_p, r_e, bReRun, True)
						If p_s.iostat = -9947 Then
							p_s.iostat = 0
						End If
						Debug.WriteLine(p_s.iostat)
					ElseIf p_s.iostat = -9947 Then
						p_s.iostat = 0
						If num5 = 0 And num4 = p_s.Max_Rod_Elements Then
							num3 = CSng(p_s.Max_Rod_Elements)
							p_s.num_rod_elements = CInt(Math.Round(CDbl(num3)))
							Me.calc_sur(p_s, r_t, s_p, r_e, bReRun, True)
							If p_s.iostat = -9947 Then
								p_s.iostat = 0
							End If
						End If
					End If
					p_s.num_rod_elements = p_s.num_rod_elements
					If(p_s.num_rod_elements > 200 Or p_s.iostat = -9950) And RSWIN_DESC.SETUP_UseDefaultRodElementLimit Then
						p_s.num_rod_elements = num_rod_elements
						RSWIN_DESC.num_rod_elements = p_s.num_rod_elements
						Me.calc_sur_2(p_s, d_l, r_t, s_p, r_e)
					ElseIf(p_s.num_rod_elements > RSWIN_DESC.SETUP_RodElementLimit Or p_s.iostat = -9950) And Not RSWIN_DESC.SETUP_UseDefaultRodElementLimit Then
						p_s.num_rod_elements = RSWIN_DESC.SETUP_RodElementLimit
						RSWIN_DESC.num_rod_elements = p_s.num_rod_elements
						Me.calc_sur_2(p_s, d_l, r_t, s_p, r_e)
					Else
						RSWIN_DESC.SETUP_RunForSpeed = 0S
					End If
				Else
					Me.calc_sur_2(p_s, d_l, r_t, s_p, r_e)
				End If
				If p_s.iostat <> 0 Then
					Me.m_RunStatus = p_s.iostat
					GoTo IL_6C9
				End If
				Dim flag3 As Boolean = False
				Me.post_calc_sur(p_s, s_p, r_e, flag3)
				Me.pre_calc_rod(p_s)
				Me.calc_rod(p_s, r_t, r_e, t_t, s_p)
				If p_s.iostat <> 0 Then
					Me.m_RunStatus = p_s.iostat
					GoTo IL_6C9
				End If
				Me.post_calc_rod(p_s, r_e)
				Me.pre_read_pu(p_s)
				Me.read_pu(p_s, p_u, bRead, bWrite)
				Me.post_read_pu(p_s, p_u)
				Me.pre_calc_pu(p_s)
				Me.calc_pu(l_u, p_s, p_u, t_s)
				If p_s.iostat <> 0 Then
					Me.m_RunStatus = p_s.iostat
					GoTo IL_6C9
				End If
				Me.post_calc_pu(p_s, t_s)
				Me.pre_read_kinemat(p_s)
				Me.read_kinemat(p_s, p_u, bRead, bWrite)
				Me.post_read_kinemat(p_s)
				Me.pre_calc_kinemat(p_s)
				Me.calc_kinemat(p_s, p_u)
				If p_s.iostat <> 0 Then
					Me.m_RunStatus = p_s.iostat
					GoTo IL_6C9
				End If
				Me.post_calc_kinemat(p_s)
				Me.pre_read_var_spm(p_s)
				Me.read_var_spm(p_s, bRead, bWrite)
				Me.post_read_var_spm(p_s)
				Me.pre_calc_var_spm(p_s)
				Me.calc_var_spm(p_s)
				If p_s.iostat <> 0 Then
					Me.m_RunStatus = p_s.iostat
					GoTo IL_6C9
				End If
				Me.post_calc_var_spm(p_s)
				Me.pre_read_motor(p_s)
				Me.read_motor(p_s, m_c, bRead, bWrite)
				Me.post_read_motor(p_s)
				Me.pre_calc_motor(p_s)
				Me.calc_motor(p_s, m_c)
				If p_s.iostat <> 0 Then
					Me.m_RunStatus = p_s.iostat
					GoTo IL_6C9
				End If
				Me.post_calc_motor(p_s)
				Me.pre_read_fluid_inertia(p_s)
				Me.read_fluid_inertia(p_s, bRead, bWrite)
				Me.post_read_fluid_inertia(p_s)
				Me.pre_calc_fluid_inertia(p_s)
				Me.calc_fluid_inertia(f_e, p_s, r_e)
				If p_s.iostat <> 0 Then
					Me.m_RunStatus = p_s.iostat
					GoTo IL_6C9
				End If
				Me.post_calc_fluid_inertia(p_s)
				Me.pre_calc_sim(p_s)
				If p_s.iostat <> 0 Then
					Me.m_RunStatus = p_s.iostat
					GoTo IL_6C9
				End If
				RSWIN_DESC.SETUP_WeightAdjFactor = 2.5F
				If RSWIN_DESC.bAddPumpPRWeight Then
					RSWIN_DESC.fPumpPRWeignt = 0F
				Else
					RSWIN_DESC.fPumpPRWeignt = 0F
				End If
				Debug.WriteLine(p_s.num_rod_elements)
				Me.calc_sim(f_e, l_u, m_c, p_s, r_e, t_s, r_t, t_t)
				If p_s.iostat <> 0 Then
					Me.m_RunStatus = p_s.iostat
					GoTo IL_6C9
				End If
				Me.post_calc_sim(p_s, t_s, s_p, r_e, r_t, m_c)
				GoTo IL_6C9
				IL_666:
				Interaction.MsgBox("Error: in TeImpred2 " + Information.Err().Description, MsgBoxStyle.OKOnly, Nothing)
				GoTo IL_6C9
				IL_684:
				num6 = -1
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_69A:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num6 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_684
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_6C9:
			If num6 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		Public Sub TEImpred2_Partial(ByRef p_s As TEImpred.parameter_structure_type, ByRef f_e As TEImpred.fluid_element_data_type(), ByRef l_u As TEImpred.lookup_table_data_type(), ByRef m_c As TEImpred.motor_characteristic_data_type(), ByRef p_u As TEImpred.pump_unit_data_point_type(), ByRef r_e As TEImpred.rod_element_data_type(), ByRef r_t As TEImpred.rod_taper_data_type(), ByRef s_p As TEImpred.survey_point_type(), ByRef t_s As TEImpred.timestep_data_type(), ByRef t_t As TEImpred.tbg_taper_data_type(), ByRef d_l As TEImpred.dog_leg_data_type())
			' The following expression was wrapped in a checked-statement
			Dim num As Integer
			Dim num6 As Integer
			Dim obj As Object
			Try
				Dim flag As Boolean = True
				ProjectData.ClearProjectError()
				num = 2
				Dim bWrite As Boolean = False
				Dim bRead As Boolean = False
				Me.pre_read_rod(p_s)
				Me.read_rod(p_s, r_t, t_t, bRead, bWrite)
				Me.post_read_rod(p_s, r_t)
				Me.pre_read_drag(p_s)
				Me.read_drag(p_s, bRead, bWrite)
				Me.post_read_drag(p_s)
				Me.pre_read_pump_off(p_s)
				Me.read_pump_off(p_s, bRead, bWrite)
				Me.post_read_pump_off(p_s)
				Me.pre_read_sur(p_s)
				Me.read_sur(p_s, s_p, bRead, bWrite)
				Me.post_read_sur(p_s, s_p)
				Me.pre_calc_sur(p_s)
				If flag Then
					p_s.iostat = p_s.iostat
				End If
				If flag Then
					Dim num_rod_elements As Integer = p_s.num_rod_elements
					Dim bReRun As Boolean = False
					Me.calc_sur(p_s, r_t, s_p, r_e, bReRun, True)
					Me.temp = CDbl(p_s.num_rod_elements)
					Dim flag2 As Boolean = False
					If r_t(1).taper_depth < r_t(1).rod_elem_len Then
						flag2 = True
					End If
					Dim num2 As Integer = 2
					Dim num_rod_tapers As Integer = p_s.num_rod_tapers
					Me.n = num2
					While Me.n <= num_rod_tapers
						' The following expression was wrapped in a unchecked-expression
						' The following expression was wrapped in a checked-expression
						If r_t(Me.n).taper_depth - r_t(Me.n - 1).taper_depth < r_t(Me.n).rod_elem_len Then
							flag2 = True
						End If
						Me.n += 1
					End While
					If flag2 Then
						p_s.num_rod_elements += 1
						bReRun = True
					End If
					If Me.temp <> CDbl(p_s.num_rod_elements) Then
						If Me.temp > CDbl(p_s.num_rod_elements) Then
							p_s.iostat = -9973
						End If
						Me.calc_sur(p_s, r_t, s_p, r_e, bReRun, True)
					End If
					Dim num3 As Single = CSng(p_s.num_rod_elements)
					Dim num4 As Integer = 0
					Dim num5 As Integer
					While (p_s.iostat = -9945 Or p_s.iostat = -9944 Or p_s.iostat = -9947) And num5 < 2000 And num4 < 100
						bReRun = True
						p_s.iostat = 0
						p_s.num_rod_elements += 1
						If p_s.num_rod_elements > p_s.Max_Rod_Elements Then
							p_s.iostat = -8526
							Exit While
						End If
						Me.calc_sur(p_s, r_t, s_p, r_e, bReRun, True)
						If p_s.iostat = -9945 Or p_s.iostat = -9944 Then
							num3 = CSng(p_s.num_rod_elements)
							num5 += 1
						ElseIf p_s.iostat = -9947 Then
							num3 = CSng(p_s.num_rod_elements)
							num4 += 1
						End If
					End While
					If p_s.num_rod_elements > RSWIN_DESC.SETUP_RodElementLimit And Not RSWIN_DESC.SETUP_UseDefaultRodElementLimit Then
						p_s.num_rod_elements = RSWIN_DESC.SETUP_RodElementLimit
						RSWIN_DESC.num_rod_elements = p_s.num_rod_elements
						p_s.iostat = 0
						Me.calc_sur(p_s, r_t, s_p, r_e, bReRun, True)
						If p_s.iostat = -9947 Then
							p_s.iostat = 0
						End If
						Debug.WriteLine(p_s.iostat)
					ElseIf p_s.iostat = -9947 Then
						p_s.iostat = 0
						If num5 = 0 And num4 = p_s.Max_Rod_Elements Then
							num3 = CSng(p_s.Max_Rod_Elements)
							p_s.num_rod_elements = CInt(Math.Round(CDbl(num3)))
							Me.calc_sur(p_s, r_t, s_p, r_e, bReRun, True)
							If p_s.iostat = -9947 Then
								p_s.iostat = 0
							End If
						End If
					End If
					p_s.num_rod_elements = p_s.num_rod_elements
					If(p_s.num_rod_elements > 200 Or p_s.iostat = -9950) And RSWIN_DESC.SETUP_UseDefaultRodElementLimit Then
						p_s.num_rod_elements = num_rod_elements
						RSWIN_DESC.num_rod_elements = num_rod_elements
						Me.calc_sur_2(p_s, d_l, r_t, s_p, r_e)
					ElseIf(p_s.num_rod_elements > RSWIN_DESC.SETUP_RodElementLimit Or p_s.iostat = -9950) And Not RSWIN_DESC.SETUP_UseDefaultRodElementLimit Then
						p_s.num_rod_elements = RSWIN_DESC.SETUP_RodElementLimit
						RSWIN_DESC.num_rod_elements = p_s.num_rod_elements
						Me.calc_sur_2(p_s, d_l, r_t, s_p, r_e)
					Else
						RSWIN_DESC.SETUP_RunForSpeed = 0S
					End If
				Else
					Me.calc_sur_2(p_s, d_l, r_t, s_p, r_e)
				End If
				If p_s.iostat <> 0 Then
					Me.m_RunStatus = p_s.iostat
					GoTo IL_472
				End If
				GoTo IL_472
				IL_40F:
				Interaction.MsgBox("Error: in TeImpred2_Partial " + Information.Err().Description, MsgBoxStyle.OKOnly, Nothing)
				GoTo IL_472
				IL_42D:
				num6 = -1
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_443:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num6 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_42D
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_472:
			If num6 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		Public Sub TEImpred2_Remainder(ByRef p_s As TEImpred.parameter_structure_type, ByRef f_e As TEImpred.fluid_element_data_type(), ByRef l_u As TEImpred.lookup_table_data_type(), ByRef m_c As TEImpred.motor_characteristic_data_type(), ByRef p_u As TEImpred.pump_unit_data_point_type(), ByRef r_e As TEImpred.rod_element_data_type(), ByRef r_t As TEImpred.rod_taper_data_type(), ByRef s_p As TEImpred.survey_point_type(), ByRef t_s As TEImpred.timestep_data_type(), ByRef t_t As TEImpred.tbg_taper_data_type(), ByRef d_l As TEImpred.dog_leg_data_type())
			Dim bWrite As Boolean = False
			Dim bRead As Boolean = False
			Dim flag As Boolean
			Me.post_calc_sur(p_s, s_p, r_e, flag)
			If flag Then
				Try
					Dim bReRun As Boolean
					Me.calc_sur(p_s, r_t, s_p, r_e, bReRun, True)
					If p_s.iostat = -9947 Then
						p_s.iostat = 0
					End If
				Catch ex As Exception
				End Try
			End If
			Me.pre_calc_rod(p_s)
			Me.calc_rod(p_s, r_t, r_e, t_t, s_p)
			If p_s.iostat <> 0 Then
				Me.m_RunStatus = p_s.iostat
				Return
			End If
			Me.post_calc_rod(p_s, r_e)
			Me.pre_read_pu(p_s)
			Me.read_pu(p_s, p_u, bRead, bWrite)
			Me.post_read_pu(p_s, p_u)
			Me.pre_calc_pu(p_s)
			Me.calc_pu(l_u, p_s, p_u, t_s)
			If p_s.iostat <> 0 Then
				Me.m_RunStatus = p_s.iostat
				Return
			End If
			Me.post_calc_pu(p_s, t_s)
			Me.pre_read_kinemat(p_s)
			Me.read_kinemat(p_s, p_u, bRead, bWrite)
			Me.post_read_kinemat(p_s)
			Me.pre_calc_kinemat(p_s)
			Me.calc_kinemat(p_s, p_u)
			If p_s.iostat <> 0 Then
				Me.m_RunStatus = p_s.iostat
				Return
			End If
			Me.post_calc_kinemat(p_s)
			Me.pre_read_var_spm(p_s)
			Me.read_var_spm(p_s, bRead, bWrite)
			Me.post_read_var_spm(p_s)
			Me.pre_calc_var_spm(p_s)
			Me.calc_var_spm(p_s)
			If p_s.iostat <> 0 Then
				Me.m_RunStatus = p_s.iostat
				Return
			End If
			Me.post_calc_var_spm(p_s)
			Me.pre_read_motor(p_s)
			Me.read_motor(p_s, m_c, bRead, bWrite)
			Me.post_read_motor(p_s)
			Me.pre_calc_motor(p_s)
			Me.calc_motor(p_s, m_c)
			If p_s.iostat <> 0 Then
				Me.m_RunStatus = p_s.iostat
				Return
			End If
			Me.post_calc_motor(p_s)
			Me.pre_read_fluid_inertia(p_s)
			Me.read_fluid_inertia(p_s, bRead, bWrite)
			Me.post_read_fluid_inertia(p_s)
			Me.pre_calc_fluid_inertia(p_s)
			Me.calc_fluid_inertia(f_e, p_s, r_e)
			If p_s.iostat <> 0 Then
				Me.m_RunStatus = p_s.iostat
				Return
			End If
			Me.post_calc_fluid_inertia(p_s)
			Me.pre_calc_sim(p_s)
			If p_s.iostat <> 0 Then
				Me.m_RunStatus = p_s.iostat
				Return
			End If
			RSWIN_DESC.SETUP_WeightAdjFactor = 2.5F
			If RSWIN_DESC.bAddPumpPRWeight Then
				RSWIN_DESC.fPumpPRWeignt = 0F
			Else
				RSWIN_DESC.fPumpPRWeignt = 0F
			End If
			Application.DoEvents()
			Me.calc_sim(f_e, l_u, m_c, p_s, r_e, t_s, r_t, t_t)
			Application.DoEvents()
			If p_s.iostat <> 0 Then
				Me.m_RunStatus = p_s.iostat
				Return
			End If
			Me.post_calc_sim(p_s, t_s, s_p, r_e, r_t, m_c)
		End Sub

		Private Sub calc_dog(ByRef dog As Double, ByRef tan1 As TEImpred.cart_coord_type, ByRef tan2 As TEImpred.cart_coord_type, tolerance As Double, iostat As Integer, bStopForError As Boolean)
			Dim num As Double = Me.dot_prod(tan1, tan2)
			If num <= 1.0 + tolerance Then
				If num >= -tolerance Then
					If num > 1.0 And num <= 1.0 + tolerance Then
						num = 1.0
					ElseIf num < 0.0 And num >= -tolerance Then
						num = 0.0
					End If
				End If
			End If
			dog = Me.ArcCosine(num)
			If bStopForError And Me.p_s.iostat <> 0 Then
				Return
			End If
		End Sub

		Public Sub calc_dog_leg_s_p(ByRef s_p As TEImpred.survey_point_type(), ByRef p_s As TEImpred.parameter_structure_type, ByRef d_l As TEImpred.dog_leg_data_type())
			Dim num As Integer = 1
			Dim num2 As Integer = 1
			Dim num_dog_leg_pts As Integer = p_s.num_dog_leg_pts
			For i As Integer = num2 To num_dog_leg_pts
				Dim num3 As Double = Convert.ToDouble(i)
				If num3 > s_p(num + 1).m_d Then
					If num > p_s.num_survey_points Then
						num = num
						p_s.iostat = -8559
					End If
					num += 1
				End If
				d_l(i).dog_leg_s_p = s_p(num).dog / (s_p(num + 1).m_d - s_p(num).m_d) * 100.0 * 180.0 / 3.141592653589793
			Next
			p_s.dog_leg_nupro_s_p = 0.0
			Dim num4 As Integer = 1
			Dim num_dog_leg_pts2 As Integer = p_s.num_dog_leg_pts
			For i As Integer = num4 To num_dog_leg_pts2

					p_s.dog_leg_nupro_s_p += Math.Pow(d_l(i).dog_leg_s_p, 2.0)

			Next
			p_s.dog_leg_nupro_s_p = Math.Sqrt(p_s.dog_leg_nupro_s_p)
			Dim num5 As Integer = 1
			Dim num_dog_leg_pts3 As Integer = p_s.num_dog_leg_pts
			For i As Integer = num5 To num_dog_leg_pts3
				d_l(i).dog_leg_s_p_norm = d_l(i).dog_leg_s_p / p_s.dog_leg_nupro_s_p
			Next
		End Sub

		Public Sub calc_dog_leg_r_e(ByRef r_e As TEImpred.rod_element_data_type(), ByRef p_s As TEImpred.parameter_structure_type, ByRef d_l As TEImpred.dog_leg_data_type())
			Dim num As Integer = 1
			Dim num2 As Integer = 1
			Dim num_dog_leg_pts As Integer = p_s.num_dog_leg_pts
			For i As Integer = num2 To num_dog_leg_pts
				Dim num3 As Double = Convert.ToDouble(i)
				If num3 > r_e(num).m_d Then
					num += 1
				End If
				d_l(i).dog_leg_r_e = r_e(num).dog / (r_e(num).m_d - r_e(num - 1).m_d) * 100.0 * 180.0 / 3.141592653589793
			Next
			p_s.dog_leg_nupro_r_e = 0.0
			Dim num4 As Integer = 1
			Dim num_dog_leg_pts2 As Integer = p_s.num_dog_leg_pts
			For i As Integer = num4 To num_dog_leg_pts2

					p_s.dog_leg_nupro_r_e += Math.Pow(d_l(i).dog_leg_r_e, 2.0)

			Next
			p_s.dog_leg_nupro_r_e = Math.Sqrt(p_s.dog_leg_nupro_r_e)
			Dim num5 As Integer = 1
			Dim num_dog_leg_pts3 As Integer = p_s.num_dog_leg_pts
			For i As Integer = num5 To num_dog_leg_pts3
				d_l(i).dog_leg_r_e_norm = d_l(i).dog_leg_r_e / p_s.dog_leg_nupro_r_e
			Next
		End Sub

		Public Sub calc_dog_leg_err(ByRef r_e As TEImpred.rod_element_data_type(), ByRef s_p As TEImpred.survey_point_type(), ByRef p_s As TEImpred.parameter_structure_type, ByRef d_l As TEImpred.dog_leg_data_type())
			p_s.dog_leg_nupro = 0.0
			Dim num As Integer = 1
			Dim num_dog_leg_pts As Integer = p_s.num_dog_leg_pts
			For i As Integer = num To num_dog_leg_pts

					p_s.dog_leg_nupro += d_l(i).dog_leg_r_e_norm * d_l(i).dog_leg_s_p_norm

			Next
			p_s.nupro_power = 30
			p_s.dog_leg_nupro = Math.Pow(p_s.dog_leg_nupro, CDbl(p_s.nupro_power))
			Dim num2 As Integer = 1
			Dim num_dog_leg_pts2 As Integer = p_s.num_dog_leg_pts
			For i As Integer = num2 To num_dog_leg_pts2

					d_l(i).dog_leg_dif = d_l(i).dog_leg_r_e - d_l(i).dog_leg_s_p
					d_l(i).dog_leg_dif_for_per = d_l(i).dog_leg_dif
					Dim num3 As Double = (d_l(i).dog_leg_r_e + d_l(i).dog_leg_s_p) / 2.0
					d_l(i).dog_leg_per = 100.0 * d_l(i).dog_leg_dif / num3
					d_l(i).dog_leg_per_for_dif = d_l(i).dog_leg_per
					d_l(i).dog_leg_dif_m_d = Convert.ToDouble(i)
					d_l(i).dog_leg_per_m_d = Convert.ToDouble(i)
					d_l(i).dog_leg_dif_big = d_l(i).dog_leg_dif
					d_l(i).dog_leg_per_big = d_l(i).dog_leg_per
					d_l(i).dog_leg_r_e_dif = d_l(i).dog_leg_r_e
					d_l(i).dog_leg_r_e_per = d_l(i).dog_leg_r_e
					d_l(i).dog_leg_s_p_dif = d_l(i).dog_leg_s_p
					d_l(i).dog_leg_s_p_per = d_l(i).dog_leg_s_p

			Next
			Dim num4 As Integer = 1
			Dim num5 As Integer = p_s.num_dog_leg_pts - 2
			For j As Integer = num4 To num5
				Dim num6 As Integer = 1
				Dim num7 As Integer = p_s.num_dog_leg_pts - j
				For i As Integer = num6 To num7
					If d_l(i).dog_leg_dif_big < d_l(i + 1).dog_leg_dif_big Then
						Dim num3 As Double = d_l(i + 1).dog_leg_dif_big
						d_l(i + 1).dog_leg_dif_big = d_l(i).dog_leg_dif_big
						d_l(i).dog_leg_dif_big = num3
						num3 = d_l(i + 1).dog_leg_dif_m_d
						d_l(i + 1).dog_leg_dif_m_d = d_l(i).dog_leg_dif_m_d
						d_l(i).dog_leg_dif_m_d = num3
						num3 = d_l(i + 1).dog_leg_r_e_dif
						d_l(i + 1).dog_leg_r_e_dif = d_l(i).dog_leg_r_e_dif
						d_l(i).dog_leg_r_e_dif = num3
						num3 = d_l(i + 1).dog_leg_s_p_dif
						d_l(i + 1).dog_leg_s_p_dif = d_l(i).dog_leg_s_p_dif
						d_l(i).dog_leg_s_p_dif = num3
						num3 = d_l(i + 1).dog_leg_per_for_dif
						d_l(i + 1).dog_leg_per_for_dif = d_l(i).dog_leg_per_for_dif
						d_l(i).dog_leg_per_for_dif = num3
					End If
					If d_l(i).dog_leg_per_big < d_l(i + 1).dog_leg_per_big Then
						Dim num3 As Double = d_l(i + 1).dog_leg_per_big
						d_l(i + 1).dog_leg_per_big = d_l(i).dog_leg_per_big
						d_l(i).dog_leg_per_big = num3
						num3 = d_l(i + 1).dog_leg_per_m_d
						d_l(i + 1).dog_leg_per_m_d = d_l(i).dog_leg_per_m_d
						d_l(i).dog_leg_per_m_d = num3
						num3 = d_l(i + 1).dog_leg_r_e_per
						d_l(i + 1).dog_leg_r_e_per = d_l(i).dog_leg_r_e_per
						d_l(i).dog_leg_r_e_per = num3
						num3 = d_l(i + 1).dog_leg_s_p_per
						d_l(i + 1).dog_leg_s_p_per = d_l(i).dog_leg_s_p_per
						d_l(i).dog_leg_s_p_per = num3
						num3 = d_l(i + 1).dog_leg_dif_for_per
						d_l(i + 1).dog_leg_dif_for_per = d_l(i).dog_leg_dif_for_per
						d_l(i).dog_leg_dif_for_per = num3
					End If
				Next
			Next
		End Sub

		Public Sub pre_read_sur(ByRef p_s As TEImpred.parameter_structure_type)
		End Sub

		Public Sub post_read_sur(ByRef p_s As TEImpred.parameter_structure_type, ByRef s_p As TEImpred.survey_point_type())
		End Sub

		Public Sub pre_calc_sur(ByRef p_s As TEImpred.parameter_structure_type)
		End Sub

		Public Sub post_calc_sur(ByRef p_s As TEImpred.parameter_structure_type, ByRef s_p As TEImpred.survey_point_type(), ByRef r_e As TEImpred.rod_element_data_type(), Optional ByRef bReRun As Boolean = False)
			bReRun = False
			Dim num As Integer = 1
			Dim num_rod_elements As Integer = p_s.num_rod_elements
			For i As Integer = num To num_rod_elements
				Dim num2 As Double = Me.ArcCosine(r_e(i).tan.z)
				r_e(i).inc = num2
				Dim num3 As Double
				Try
					If num2 = 0.0 Then
						Debug.WriteLine(" ")
					End If
					If num2 >= 0.0 Then
						If num2 = 0.0 Then
							bReRun = True
						End If
						If r_e(i).tan.y / Math.Sin(num2) > 1.0 Then
							num3 = 0.0
						ElseIf r_e(i).tan.y / Math.Sin(num2) < -1.0 Then
							num3 = 3.141592653589793
						Else
							num3 = Me.ArcCosine(r_e(i).tan.y / Math.Sin(num2))
						End If
					Else
						num3 = -99990.0
					End If
				Catch ex As Exception
				End Try
				r_e(i).azi = num3
			Next
			Dim num4 As Integer = 1
			If num4 = 1 Then
				Debug.WriteLine("")
				Debug.WriteLine("post_calc_sur. Rod-elem details  AFTER  adj num of rod elem by taper.)")
				Debug.WriteLine("n, r_e(n).m_d, r_e(n).pos.x, r_e(n).pos.y, r_e(n).pos.z, r_e(n).inc, r_e(n).azi, r_e(n).dog, r_e(n).rad, r_e(n).tan.x, r_e(n).tan.y, r_e(n).tan.z, r_e(n).nor.x, r_e(n).nor.y, r_e(n).nor.z")
				Dim num5 As Integer = 1
				If num5 = 1 Then
					Dim num6 As Integer = 1
					Dim num_rod_elements2 As Integer = p_s.num_rod_elements
					For i As Integer = num6 To num_rod_elements2
						Debug.WriteLine(String.Concat(New String() { Conversions.ToString(i), ", ", Conversions.ToString(r_e(i).m_d), ", ", Conversions.ToString(r_e(i).pos.x), ", ", Conversions.ToString(r_e(i).pos.y), ", ", Conversions.ToString(r_e(i).pos.z), ", ", Conversions.ToString(r_e(i).inc), ", ", Conversions.ToString(r_e(i).azi), ", ", Conversions.ToString(r_e(i).dog), ", ", Conversions.ToString(r_e(i).rad), ", ", Conversions.ToString(r_e(i).tan.x), ", ", Conversions.ToString(r_e(i).tan.y), ", ", Conversions.ToString(r_e(i).tan.z), ", ", Conversions.ToString(r_e(i).nor.x), ", ", Conversions.ToString(r_e(i).nor.y), ", ", Conversions.ToString(r_e(i).nor.z) }))
					Next
				Else
					Dim i As Integer = p_s.num_rod_elements
					Debug.WriteLine(String.Concat(New String() { Conversions.ToString(i), ", ", Conversions.ToString(r_e(i).m_d), ", ", Conversions.ToString(r_e(i).pos.x), ", ", Conversions.ToString(r_e(i).pos.y), ", ", Conversions.ToString(r_e(i).pos.z), ", ", Conversions.ToString(r_e(i).inc), ", ", Conversions.ToString(r_e(i).azi), ", ", Conversions.ToString(r_e(i).dog), ", ", Conversions.ToString(r_e(i).rad), ", ", Conversions.ToString(r_e(i).tan.x), ", ", Conversions.ToString(r_e(i).tan.y), ", ", Conversions.ToString(r_e(i).tan.z), ", ", Conversions.ToString(r_e(i).nor.x), ", ", Conversions.ToString(r_e(i).nor.y), ", ", Conversions.ToString(r_e(i).nor.z) }))
				End If
				Debug.WriteLine("post_calc_sur. Rod-elem details  AFTER  adj num of rod elem by taper.)")
				Debug.WriteLine("")
			End If
			Dim num7 As Integer = 0
			If num7 = 1 Then
				Dim num8 As Integer = 1
				Dim num_survey_points As Integer = p_s.num_survey_points
				For i As Integer = num8 To num_survey_points

						If s_p(i).dog > p_s.epsilon Then
							Dim num2 As Double = s_p(i).pos.x + s_p(i).rad * s_p(i).nor.x
							Dim num3 As Double = s_p(i).pos.y + s_p(i).rad * s_p(i).nor.y
							Dim num9 As Double = s_p(i).pos.z + s_p(i).rad * s_p(i).nor.z
						Else
							Dim num3 As Double = -99990.0
						End If

				Next
			End If
			Dim num10 As Integer = 0
			If num10 = 1 Then
				Dim num11 As Integer = 1
				Dim num_rod_elements3 As Integer = p_s.num_rod_elements
				For i As Integer = num11 To num_rod_elements3

						If r_e(i).dog > p_s.epsilon Then
							Dim num2 As Double = r_e(i).pos.x - r_e(i).rad * Math.Sin(0.5 * r_e(i).dog) * r_e(i).tan.x - r_e(i).rad * (1.0 - Math.Cos(0.5 * r_e(i).dog)) * r_e(i).nor.x
							Dim num3 As Double = r_e(i).pos.y - r_e(i).rad * Math.Sin(0.5 * r_e(i).dog) * r_e(i).tan.y - r_e(i).rad * (1.0 - Math.Cos(0.5 * r_e(i).dog)) * r_e(i).nor.y
							Dim num9 As Double = r_e(i).pos.z - r_e(i).rad * Math.Sin(0.5 * r_e(i).dog) * r_e(i).tan.z - r_e(i).rad * (1.0 - Math.Cos(0.5 * r_e(i).dog)) * r_e(i).nor.z
							num2 += r_e(i).rad * r_e(i).nor.x
							num3 += r_e(i).rad * r_e(i).nor.y
							num9 += r_e(i).rad * r_e(i).nor.z
						Else
							Dim num3 As Double = -99990.0
						End If

				Next
				Return
			End If
		End Sub

		Public Sub pre_read_pu(ByRef p_s As TEImpred.parameter_structure_type)
		End Sub

		Public Sub post_read_pu(ByRef p_s As TEImpred.parameter_structure_type, ByRef p_u As TEImpred.pump_unit_data_point_type())
		End Sub

		Public Sub pre_calc_pu(ByRef p_s As TEImpred.parameter_structure_type)
		End Sub

		Public Sub post_calc_pu(ByRef p_s As TEImpred.parameter_structure_type, ByRef t_s As TEImpred.timestep_data_type())
		End Sub

		Public Sub pre_read_rod(ByRef p_s As TEImpred.parameter_structure_type)
		End Sub

		Public Sub post_read_rod(ByRef p_s As TEImpred.parameter_structure_type, ByRef r_t As TEImpred.rod_taper_data_type())
		End Sub

		Public Sub pre_calc_rod(ByRef p_s As TEImpred.parameter_structure_type)
		End Sub

		Public Sub post_calc_rod(ByRef p_s As TEImpred.parameter_structure_type, ByRef r_e As TEImpred.rod_element_data_type())
		End Sub

		Public Sub pre_calc_sim(ByRef p_s As TEImpred.parameter_structure_type)
		End Sub

		Public Sub post_calc_sim(ByRef p_s As TEImpred.parameter_structure_type, ByRef t_s As TEImpred.timestep_data_type(), ByRef s_p As TEImpred.survey_point_type(), ByRef r_e As TEImpred.rod_element_data_type(), ByRef r_t As TEImpred.rod_taper_data_type(), ByRef m_c As TEImpred.motor_characteristic_data_type())
			If p_s.fluid_solution = 0 Then
				Return
			End If
		End Sub

		Public Sub pre_read_drag(ByRef p_s As TEImpred.parameter_structure_type)
		End Sub

		Public Sub post_read_drag(ByRef p_s As TEImpred.parameter_structure_type)
		End Sub

		Public Sub pre_read_pump_off(ByRef p_s As TEImpred.parameter_structure_type)
		End Sub

		Public Sub post_read_pump_off(ByRef p_s As TEImpred.parameter_structure_type)
		End Sub

		Public Sub pre_read_motor(ByRef p_s As TEImpred.parameter_structure_type)
		End Sub

		Public Sub post_read_motor(ByRef p_s As TEImpred.parameter_structure_type)
		End Sub

		Public Sub pre_calc_motor(ByRef p_s As TEImpred.parameter_structure_type)
		End Sub

		Public Sub post_calc_motor(ByRef p_s As TEImpred.parameter_structure_type)
		End Sub

		Public Sub pre_read_var_spm(ByRef p_s As TEImpred.parameter_structure_type)
		End Sub

		Public Sub post_read_var_spm(ByRef p_s As TEImpred.parameter_structure_type)
		End Sub

		Public Sub pre_calc_var_spm(ByRef p_s As TEImpred.parameter_structure_type)
		End Sub

		Public Sub post_calc_var_spm(ByRef p_s As TEImpred.parameter_structure_type)
		End Sub

		Public Sub pre_read_kinemat(ByRef p_s As TEImpred.parameter_structure_type)
		End Sub

		Public Sub post_read_kinemat(ByRef p_s As TEImpred.parameter_structure_type)
		End Sub

		Public Sub pre_calc_kinemat(ByRef p_s As TEImpred.parameter_structure_type)
		End Sub

		Public Sub post_calc_kinemat(ByRef p_s As TEImpred.parameter_structure_type)
		End Sub

		Public Sub pre_read_fluid_inertia(ByRef p_s As TEImpred.parameter_structure_type)
		End Sub

		Public Sub post_read_fluid_inertia(ByRef p_s As TEImpred.parameter_structure_type)
		End Sub

		Public Sub pre_calc_fluid_inertia(ByRef p_s As TEImpred.parameter_structure_type)
		End Sub

		Public Sub post_calc_fluid_inertia(ByRef p_s As TEImpred.parameter_structure_type)
		End Sub

		Public Sub pump_pos_error(ByRef p_s As TEImpred.parameter_structure_type, ByRef r_e As TEImpred.rod_element_data_type())
			If p_s.bOpenCsv Then
				p_s.bOpenCsv = False
				Dim text As String = "c:\TempRSWINFiles\pump_pos_errors.csv"
				If FILEUTIL.FileExists(text) Then
					FileSystem.FileClose(New Integer() { Conversions.ToInteger(p_s.frn_debug_ppe) })
					FileSystem.Kill("c:\TempRSWINFiles\pump_pos_errors.csv")
				End If
				p_s.frn_debug_ppe = FileSystem.FreeFile()
				FileSystem.FileOpen(Conversions.ToInteger(p_s.frn_debug_ppe), "c:\TempRSWINFiles\pump_pos_errors.csv", OpenMode.Output, OpenAccess.[Default], OpenShare.[Default], -1)
				FileSystem.PrintLine(Conversions.ToInteger(p_s.frn_debug_ppe), New Object() { "Pump_pos_err=, #RodEl, #SP" })
			End If
			Dim x As Double = r_e(p_s.num_rod_elements).pos.x - p_s.pump_pos.x
			Dim x2 As Double = r_e(p_s.num_rod_elements).pos.y - p_s.pump_pos.y
			Dim x3 As Double = r_e(p_s.num_rod_elements).pos.z - p_s.pump_pos.z
			p_s.pump_pos_err = Math.Sqrt(Math.Pow(x, 2.0) + Math.Pow(x2, 2.0) + Math.Pow(x3, 2.0))
			If p_s.bOpenCsv Then
				FileSystem.PrintLine(Conversions.ToInteger(p_s.frn_debug_ppe), New Object() { String.Concat(New String() { Conversions.ToString(p_s.pump_pos_err), ",", Conversions.ToString(p_s.num_rod_elements), ",", Conversions.ToString(p_s.iIndexAtPump) }) })
				Return
			End If
		End Sub

		Public Sub showdata(ByRef p_s As TEImpred.parameter_structure_type, ByRef f_e As TEImpred.fluid_element_data_type(), ByRef l_u As TEImpred.lookup_table_data_type(), ByRef m_c As TEImpred.motor_characteristic_data_type(), ByRef p_u As TEImpred.pump_unit_data_point_type(), ByRef r_e As TEImpred.rod_element_data_type(), ByRef r_t As TEImpred.rod_taper_data_type(), ByRef s_p As TEImpred.survey_point_type(), ByRef t_s As TEImpred.timestep_data_type(), ByRef t_t As TEImpred.tbg_taper_data_type())
		End Sub

		Public Sub parabola(ByRef x_input As Double(), ByRef y_output As Double(), ByRef a_parabola As Double, ByRef b_parabola As Double, ByRef c_parabola As Double)
			a_parabola = (y_output(3) - y_output(2)) / (x_input(3) - x_input(2)) - (y_output(3) - y_output(1)) / (x_input(3) - x_input(1))
			a_parabola /= x_input(2) - x_input(1)
			b_parabola = -a_parabola * (x_input(3) + x_input(2)) + (y_output(3) - y_output(2)) / (x_input(3) - x_input(2))
			c_parabola = y_output(3) - a_parabola * Math.Pow(x_input(3), 2.0) - b_parabola * x_input(3)
		End Sub

		Public Sub read_drag(ByRef p_s As TEImpred.parameter_structure_type, Optional bRead As Boolean = False, Optional bWrite As Boolean = False)
			Dim num As Integer
			If Not RSWIN_DESC.bBETA And RSWIN_DESC.bWriteCSVFIles Then
				Dim text As String = "c:\TempRSWINFiles\RSWIN-drag.dat"
				If FILEUTIL.FileExists(text) Then
					FileSystem.FileClose(New Integer() { num })
					FileSystem.Kill("c:\TempRSWINFiles\RSWIN-drag.dat")
				End If
				num = FileSystem.FreeFile()
				FileSystem.FileOpen(num, "c:\TempRSWINFiles\RSWIN-drag.dat", OpenMode.Output, OpenAccess.[Default], OpenShare.[Default], -1)
			End If
			Dim num2 As Integer
			If bRead Then
				num2 = FileSystem.FreeFile()
				FileSystem.FileOpen(num2, "c:\TempRSWINFiles\drag.dat", OpenMode.Input, OpenAccess.[Default], OpenShare.[Default], -1)
			End If
			If bRead Then
				FileSystem.Input(num2, p_s.pr_drag_0)
			End If
			If Not RSWIN_DESC.bBETA And RSWIN_DESC.bWriteCSVFIles Then
				FileSystem.PrintLine(num, New Object() { p_s.pr_drag_0 })
			End If
			If bRead Then
				FileSystem.Input(num2, p_s.pr_drag_1)
			End If
			If Not RSWIN_DESC.bBETA And RSWIN_DESC.bWriteCSVFIles Then
				FileSystem.PrintLine(num, New Object() { p_s.pr_drag_1 })
			End If
			If bRead Then
				FileSystem.Input(num2, p_s.pr_drag_2)
			End If
			If Not RSWIN_DESC.bBETA And RSWIN_DESC.bWriteCSVFIles Then
				FileSystem.PrintLine(num, New Object() { p_s.pr_drag_2 })
			End If
			If bRead Then
				FileSystem.Input(num2, p_s.p_drag_up_0)
			End If
			If Not RSWIN_DESC.bBETA And RSWIN_DESC.bWriteCSVFIles Then
				FileSystem.PrintLine(num, New Object() { p_s.p_drag_up_0 })
			End If
			If bRead Then
				FileSystem.Input(num2, p_s.p_drag_up_1)
			End If
			If Not RSWIN_DESC.bBETA And RSWIN_DESC.bWriteCSVFIles Then
				FileSystem.PrintLine(num, New Object() { p_s.p_drag_up_1 })
			End If
			If bRead Then
				FileSystem.Input(num2, p_s.p_drag_up_2)
			End If
			If Not RSWIN_DESC.bBETA And RSWIN_DESC.bWriteCSVFIles Then
				FileSystem.PrintLine(num, New Object() { p_s.p_drag_up_2 })
			End If
			If bRead Then
				FileSystem.Input(num2, p_s.p_drag_dn_0)
			End If
			If Not RSWIN_DESC.bBETA And RSWIN_DESC.bWriteCSVFIles Then
				FileSystem.PrintLine(num, New Object() { p_s.p_drag_dn_0 })
			End If
			If bRead Then
				FileSystem.Input(num2, p_s.p_drag_dn_1)
			End If
			If Not RSWIN_DESC.bBETA And RSWIN_DESC.bWriteCSVFIles Then
				FileSystem.PrintLine(num, New Object() { p_s.p_drag_dn_1 })
			End If
			If bRead Then
				FileSystem.Input(num2, p_s.p_drag_dn_2)
			End If
			If Not RSWIN_DESC.bBETA And RSWIN_DESC.bWriteCSVFIles Then
				FileSystem.PrintLine(num, New Object() { p_s.p_drag_dn_2 })
			End If
			If Not RSWIN_DESC.bBETA And RSWIN_DESC.bWriteCSVFIles Then
				FileSystem.FileClose(New Integer() { num })
			End If
			If bRead Then
				FileSystem.FileClose(New Integer() { num2 })
			End If
			Dim num3 As Integer = 0
			If p_s.pr_drag_f_max > 0.0 Then
				If p_s.pr_drag_0 > 0 Or p_s.pr_drag_1 > 0 Or p_s.pr_drag_2 > 0 Then
					num3 = 1
				End If
				If p_s.pr_drag_0 > 0 Then
				End If
				If p_s.pr_drag_1 > 0 Then
				End If
				If p_s.pr_drag_2 > 0 Then
				End If
			End If
			If p_s.p_drag_f_max_up > 0.0 Then
				If p_s.p_drag_up_0 > 0 Or p_s.p_drag_up_1 > 0 Or p_s.p_drag_up_2 > 0 Then
					num3 = 1
				End If
				If p_s.p_drag_up_0 > 0 Then
				End If
				If p_s.p_drag_up_1 > 0 Then
				End If
				If p_s.p_drag_up_2 > 0 Then
				End If
			End If
			If p_s.p_drag_f_max_dn > 0.0 Then
				If p_s.p_drag_dn_0 > 0 Or p_s.p_drag_dn_1 > 0 Or p_s.p_drag_dn_2 > 0 Then
					num3 = 1
				End If
				If p_s.p_drag_dn_0 > 0 Then
				End If
				If p_s.p_drag_dn_1 > 0 Then
				End If
				If p_s.p_drag_dn_2 > 0 Then
				End If
			End If
			If num3 = 1 Then
				Return
			End If
		End Sub

		Public Sub read_kinemat(ByRef p_s As TEImpred.parameter_structure_type, ByRef p_u As TEImpred.pump_unit_data_point_type(), Optional bRead As Boolean = False, Optional bWrite As Boolean = False)
			Dim num As Integer
			If bRead Then
				num = FileSystem.FreeFile()
				FileSystem.FileOpen(num, "c:\TempRSWINFiles\four_bar.dat", OpenMode.Input, OpenAccess.[Default], OpenShare.[Default], -1)
			End If
			If bRead Then
				FileSystem.Input(num, p_s.id_beam_unit)
			End If
			If bRead Then
				FileSystem.Input(num, p_s.four_bar_class)
			End If
			If bRead Then
				FileSystem.Input(num, p_s.cw_or_ccw)
			End If
			If p_s.cw_or_ccw <> 1 And p_s.cw_or_ccw <> -1 Then
				p_s.iostat = -8785
				Return
			End If
			If bRead Then
				FileSystem.Input(num, p_s.angl_cwt_phase)
			End If
			If p_s.angl_cwt_phase < 0.0 And p_s.four_bar_class = 3 Then
				p_s.iostat = -8780
				Return
			End If
			If p_s.angl_cwt_phase > 30.0 And p_s.four_bar_class = 3 Then
				p_s.iostat = -8779
				Return
			End If
			If p_s.angl_cwt_phase < -25.0 And p_s.four_bar_class = 1 Then
				p_s.iostat = -8778
				Return
			End If
			If p_s.angl_cwt_phase > 0.0 And p_s.four_bar_class = 1 Then
				If Not(Strings.InStr(RSWIN_DESC.rst.PU.Manuf, "Low Profile", CompareMethod.Binary) > 0 Or RSWIN_DESC.rst.PU.UnitType = 9S Or RSWIN_DESC.rst.PU.UnitType = 3S) Then
					p_s.iostat = -8777
					Return
				End If
				p_s.angl_cwt_phase = 0.0
			End If
			p_s.angl_cwt_phase = p_s.angl_cwt_phase
			If bRead Then
				FileSystem.Input(num, p_s.API_len_A)
			End If
			If p_s.API_len_A < 50.0 And p_s.four_bar_class = 3 Then
				p_s.iostat = -8784
				Return
			End If
			If p_s.API_len_A > 450.0 And p_s.four_bar_class = 3 Then
				p_s.iostat = -8783
				Return
			End If
			p_s.API_len_A /= 12.0
			If bRead Then
				FileSystem.FileClose(New Integer() { num })
			End If
			If bWrite And Not RSWIN_DESC.bBETA Then
				Dim text As String = "c:\TempRSWINFiles\RSWIN-four_bar.dat"
				Dim num2 As Integer
				If FILEUTIL.FileExists(text) Then
					FileSystem.FileClose(New Integer() { num2 })
					FileSystem.Kill("c:\TempRSWINFiles\RSWIN-four_bar.dat")
				End If
				num2 = FileSystem.FreeFile()
				FileSystem.FileOpen(num2, "c:\TempRSWINFiles\RSWIN-four_bar.dat", OpenMode.Output, OpenAccess.[Default], OpenShare.[Default], -1)
				FileSystem.PrintLine(num2, New Object() { p_s.id_beam_unit })
				FileSystem.PrintLine(num2, New Object() { p_s.four_bar_class })
				FileSystem.PrintLine(num2, New Object() { p_s.cw_or_ccw })
				FileSystem.PrintLine(num2, New Object() { p_s.angl_cwt_phase })
				FileSystem.PrintLine(num2, New Object() { p_s.API_len_A })
				FileSystem.FileClose(New Integer() { num2 })
			End If
		End Sub

		Public Sub read_motor(ByRef p_s As TEImpred.parameter_structure_type, ByRef m_c As TEImpred.motor_characteristic_data_type(), Optional bRead As Boolean = False, Optional bWrite As Boolean = False)
			Dim num As Integer
			Dim num6 As Integer
			Dim obj3 As Object
			Try
				ProjectData.ClearProjectError()
				num = 2
				bWrite = RSWIN_DESC.bWriteCSVFIles
				If RSWIN_DESC.bBETA Then
					bWrite = False
					bRead = False
				End If
				Dim num2 As Integer
				If bWrite Then
					Dim text As String = "c:\TempRSWINFiles\RSWIN-mot_char.dat"
					If FILEUTIL.FileExists(text) Then
						FileSystem.FileClose(New Integer() { num2 })
						FileSystem.Kill("c:\TempRSWINFiles\RSWIN-mot_char.dat")
					End If
					num2 = FileSystem.FreeFile()
					FileSystem.FileOpen(num2, "c:\TempRSWINFiles\RSWIN-mot_char.dat", OpenMode.Output, OpenAccess.[Default], OpenShare.[Default], -1)
				End If
				Dim num3 As Integer
				If bRead Then
					num3 = FileSystem.FreeFile()
					FileSystem.FileOpen(num3, "c:\TempRSWINFiles\mot_char.dat", OpenMode.Input, OpenAccess.[Default], OpenShare.[Default], -1)
				End If
				If bRead Then
					FileSystem.Input(num3, p_s.id_motor)
				End If
				If bWrite Then
					FileSystem.PrintLine(num2, New Object() { p_s.id_motor })
				End If
				If bRead Then
					FileSystem.Input(num3, p_s.hp_mot)
				End If
				If bWrite Then
					FileSystem.PrintLine(num2, New Object() { p_s.hp_mot })
				End If
				If bRead Then
					FileSystem.Input(num3, p_s.rpm_full_load)
				End If
				If bWrite Then
					FileSystem.PrintLine(num2, New Object() { p_s.rpm_full_load })
				End If
				If bRead Then
					FileSystem.Input(num3, p_s.mot_pts_flag)
				End If
				If bWrite Then
					FileSystem.PrintLine(num2, New Object() { p_s.mot_pts_flag })
				End If
				If p_s.mot_pts_flag <> 1 And p_s.mot_pts_flag <> 2 And p_s.mot_pts_flag <> 3 And p_s.mot_pts_flag <> 20 Then
					p_s.iostat = -8824
					GoTo IL_A20
				End If
				If bRead Then
					FileSystem.Input(num3, p_s.mot_pts)
				End If
				If bWrite Then
					FileSystem.PrintLine(num2, New Object() { p_s.mot_pts })
				End If
				If p_s.mot_pts > p_s.mot_pts_max Then
					p_s.iostat = -8833
					GoTo IL_A20
				End If
				If p_s.mot_pts_flag = 2 And p_s.mot_pts <> 2 Then
					p_s.iostat = -8809
					GoTo IL_A20
				End If
				If p_s.mot_pts_flag = 3 And p_s.mot_pts <> 3 Then
					p_s.iostat = -8823
					GoTo IL_A20
				End If
				If p_s.mot_pts_flag = 1 Then
					p_s.torq_full_load = p_s.hp_mot * 63025.357 / 12.0 / p_s.rpm_full_load
					If p_s.torq_full_load = 0.0 Then
						p_s.iostat = -8791
						GoTo IL_A20
					End If
				ElseIf p_s.mot_pts_flag = 2 Then
					If bRead Then
						FileSystem.Input(num3, p_s.rpm_no_load)
						FileSystem.Input(num3, p_s.torq_no_load)
					End If
					If bWrite Then
						FileSystem.PrintLine(num2, New Object() { Conversions.ToString(p_s.rpm_no_load) + "," + Conversions.ToString(p_s.torq_no_load) })
					End If
					If bRead Then
						FileSystem.Input(num3, p_s.rpm_full_load)
						FileSystem.Input(num3, p_s.torq_full_load)
					End If
					If bWrite Then
						FileSystem.PrintLine(num2, New Object() { Conversions.ToString(p_s.rpm_full_load) + "," + Conversions.ToString(p_s.torq_full_load) })
					End If
					If Math.Abs(p_s.torq_no_load) > 0.01 Then
						p_s.iostat = -8790
						GoTo IL_A20
					End If
					If p_s.torq_full_load < p_s.torq_no_load Then
						p_s.iostat = -8775
						GoTo IL_A20
					End If
					If p_s.rpm_full_load > p_s.rpm_no_load Then
						p_s.iostat = -8806
						GoTo IL_A20
					End If
				ElseIf p_s.mot_pts_flag = 3 Then
					If bRead Then
						FileSystem.Input(num3, p_s.rpm_no_load)
						FileSystem.Input(num3, p_s.torq_no_load)
					End If
					If bRead Then
						FileSystem.Input(num3, p_s.rpm_full_load)
						FileSystem.Input(num3, p_s.torq_full_load)
					End If
					If bRead Then
						Dim fileNumber As Integer = num3
						Dim text As String = Conversions.ToString(p_s.rpm_breakdown) + "," + Conversions.ToString(p_s.torq_breakdown)
						FileSystem.Input(fileNumber, text)
					End If
					If bWrite Then
						FileSystem.PrintLine(num2, New Object() { Conversions.ToString(p_s.rpm_no_load) + "," + Conversions.ToString(p_s.torq_no_load) })
						FileSystem.PrintLine(num2, New Object() { Conversions.ToString(p_s.rpm_full_load) + "," + Conversions.ToString(p_s.torq_full_load) })
						FileSystem.PrintLine(num2, New Object() { Conversions.ToString(p_s.rpm_breakdown) + "," + Conversions.ToString(p_s.torq_breakdown) })
					End If
					If Math.Abs(p_s.torq_no_load) > 0.01 Then
						p_s.iostat = -8790
						GoTo IL_A20
					End If
					If p_s.torq_breakdown < p_s.torq_full_load Or p_s.torq_full_load < p_s.torq_no_load Then
						p_s.iostat = -8776
						GoTo IL_A20
					End If
					If p_s.rpm_breakdown > p_s.rpm_full_load Or p_s.rpm_full_load > p_s.rpm_no_load Then
						p_s.iostat = -8805
						GoTo IL_A20
					End If
					If p_s.torq_breakdown / p_s.torq_full_load < 1.5 Then
						p_s.iostat = -8774
						GoTo IL_A20
					End If
					If p_s.torq_breakdown / p_s.torq_full_load > 3.5 Then
						p_s.iostat = -8773
						GoTo IL_A20
					End If
				ElseIf p_s.mot_pts_flag = 20 Then
					If p_s.mot_pts < 11 Then
						p_s.iostat = -8765
						GoTo IL_A20
					End If
					Dim num4 As Integer = 0
					Dim obj As Object
					Dim obj2 As Object
					If ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj, 1, p_s.mot_pts, 1, obj2, obj) Then
						While True
							If bRead Then
								FileSystem.Input(num3, m_c(Conversions.ToInteger(obj)).rpm_mot)
								FileSystem.Input(num3, m_c(Conversions.ToInteger(obj)).torq_mot)
							End If
							If bWrite Then
								FileSystem.PrintLine(num2, New Object() { Conversions.ToString(m_c(Conversions.ToInteger(obj)).rpm_mot) + "," + Conversions.ToString(m_c(Conversions.ToInteger(obj)).torq_mot) })
							End If
							If m_c(Conversions.ToInteger(obj)).rpm_mot = -9999.0 Then
								Exit For
							End If
							If Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectGreater(obj, 1, False), m_c(Conversions.ToInteger(obj)).torq_mot < m_c(Conversions.ToInteger(Operators.SubtractObject(obj, 1))).torq_mot)) Then
								GoTo Block_46
							End If
							If Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectGreater(obj, 1, False), m_c(Conversions.ToInteger(obj)).rpm_mot > m_c(Conversions.ToInteger(Operators.SubtractObject(obj, 1))).rpm_mot)) Then
								GoTo Block_47
							End If
							If m_c(Conversions.ToInteger(obj)).rpm_mot < p_s.rpm_full_load And num4 = 0 Then
								num4 = 1
								p_s.torq_full_load = p_s.rpm_full_load - m_c(Conversions.ToInteger(Operators.SubtractObject(obj, 1))).rpm_mot
								p_s.torq_full_load /= m_c(Conversions.ToInteger(obj)).rpm_mot - m_c(Conversions.ToInteger(Operators.SubtractObject(obj, 1))).rpm_mot
								p_s.torq_full_load *= m_c(Conversions.ToInteger(obj)).torq_mot - m_c(Conversions.ToInteger(Operators.SubtractObject(obj, 1))).torq_mot
								p_s.torq_full_load += m_c(Conversions.ToInteger(Operators.SubtractObject(obj, 1))).torq_mot
							End If
							If Math.Abs(m_c(Conversions.ToInteger(obj)).torq_mot) < 0.1 Then
								p_s.torq_no_load = m_c(Conversions.ToInteger(obj)).torq_mot
								p_s.rpm_no_load = m_c(Conversions.ToInteger(obj)).rpm_mot
							End If
							If Not ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj, obj2, obj) Then
								GoTo IL_8F2
							End If
						End While
						p_s.iostat = -8768
						GoTo IL_A20
						Block_46:
						p_s.iostat = Conversions.ToInteger(Operators.AddObject(Operators.SubtractObject(-17000, obj), 1))
						GoTo IL_A20
						Block_47:
						p_s.iostat = Conversions.ToInteger(Operators.SubtractObject(-16000, obj))
						GoTo IL_A20
					End If
					IL_8F2:
					p_s.torq_breakdown = m_c(p_s.mot_pts).torq_mot
					p_s.rpm_breakdown = m_c(p_s.mot_pts).rpm_mot
				End If
				Dim num5 As Double = p_s.torq_full_load * p_s.rpm_full_load / 63025.357 * 12.0
				If num5 = 0.0 Then
					p_s.iostat = -8791
					GoTo IL_A20
				End If
				If Math.Abs((num5 - p_s.hp_mot) / num5) > 0.93 Then
					p_s.iostat = -8791
					GoTo IL_A20
				End If
				If bRead Then
					FileSystem.FileClose(New Integer() { num3 })
				End If
				If bWrite Then
					FileSystem.FileClose(New Integer() { num2 })
				End If
				GoTo IL_A20
				IL_9BD:
				Interaction.MsgBox("Error: in read_motor " + Information.Err().Description, MsgBoxStyle.OKOnly, Nothing)
				GoTo IL_A20
				IL_9DB:
				num6 = -1
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_9F1:
			Catch obj4 When endfilter(TypeOf obj3 Is Exception And num <> 0 And num6 = 0)
				Dim ex As Exception = CType(obj4, Exception)
				GoTo IL_9DB
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_A20:
			If num6 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		Public Sub read_pu(ByRef p_s As TEImpred.parameter_structure_type, ByRef p_u As TEImpred.pump_unit_data_point_type(), Optional bRead As Boolean = False, Optional bWrite As Boolean = False)
			p_s.iostat = 0
			bWrite = RSWIN_DESC.bWriteCSVFIles
			If RSWIN_DESC.bBETA Then
				bWrite = False
				bRead = False
			End If
			Dim num As Integer
			If bWrite Then
				Dim text As String = "c:\TempRSWINFiles\RSWIN-pumpunit.dat"
				If FILEUTIL.FileExists(text) Then
					FileSystem.FileClose(New Integer() { num })
					FileSystem.Kill("c:\TempRSWINFiles\RSWIN-pumpunit.dat")
				End If
				num = FileSystem.FreeFile()
				FileSystem.FileOpen(num, "c:\TempRSWINFiles\RSWIN-pumpunit.dat", OpenMode.Output, OpenAccess.[Default], OpenShare.[Default], -1)
			End If
			Dim num2 As Integer
			If bRead Then
				num2 = FileSystem.FreeFile()
				FileSystem.FileOpen(num2, "c:\TempRSWINFiles\pumpunit.dat", OpenMode.Input, OpenAccess.[Default], OpenShare.[Default], -1)
			End If
			If bRead Then
				FileSystem.Input(num2, p_s.num_pump_unit_data_points)
			End If
			If bWrite Then
				FileSystem.PrintLine(num, New Object() { p_s.num_pump_unit_data_points })
			End If
			Dim num3 As Integer = 1
			Dim num_pump_unit_data_points As Integer = p_s.num_pump_unit_data_points
			Dim i As Integer
			i = num3
			While i <= num_pump_unit_data_points
				If bRead Then
					FileSystem.Input(num2, p_u(i).crank_angle)
					FileSystem.Input(num2, p_u(i).p_r_position)
					FileSystem.Input(num2, p_u(i).torque_factor)
				End If
				If bWrite Then
					FileSystem.PrintLine(num, New Object() { String.Concat(New String() { Conversions.ToString(p_u(i).crank_angle), ",", Conversions.ToString(p_u(i).p_r_position), ",", Conversions.ToString(p_u(i).torque_factor) }) })
				End If
				i += 1
			End While
			If bWrite Then
				FileSystem.FileClose(New Integer() { num })
			End If
			If bRead Then
				FileSystem.FileClose(New Integer() { num2 })
			End If
			i = 1
			If p_u(i).p_r_position <> 0.0 Then
				p_s.iostat = -9985
				Return
			End If
			If p_u(i).torque_factor <> 0.0 Then
				p_s.iostat = -9986
				Return
			End If
			i = p_s.num_pump_unit_data_points
			If p_u(i).p_r_position <> 0.0 Then
				p_s.iostat = -9987
				Return
			End If
			If p_u(i).torque_factor <> 0.0 Then
				p_s.iostat = -9988
				Return
			End If
			If Math.Abs(p_u(i).crank_angle - p_u(1).crank_angle - 8.0 * Math.Atan(1.0)) < p_s.epsilon Then
				Return
			End If
			If Math.Abs(p_u(i).crank_angle - p_u(1).crank_angle) < p_s.epsilon Then
				Return
			End If
			p_s.iostat = -9989
		End Sub

		Public Sub read_pump_off(ByRef p_s As TEImpred.parameter_structure_type, Optional bRead As Boolean = False, Optional bWrite As Boolean = False)
			bWrite = RSWIN_DESC.bWriteCSVFIles
			If RSWIN_DESC.bBETA Then
				bWrite = False
				bRead = False
			End If
			Dim num As Integer
			If bWrite Then
				Dim text As String = "c:\TempRSWINFiles\RSWIN-pump_off.dat"
				If FILEUTIL.FileExists(text) Then
					FileSystem.FileClose(New Integer() { num })
					FileSystem.Kill("c:\TempRSWINFiles\RSWIN-pump_off.dat")
				End If
				num = FileSystem.FreeFile()
				FileSystem.FileOpen(num, "c:\TempRSWINFiles\RSWIN-pump_off.dat", OpenMode.Output, OpenAccess.[Default], OpenShare.[Default], -1)
			End If
			Dim num2 As Integer
			If bRead Then
				num2 = FileSystem.FreeFile()
				FileSystem.FileOpen(num2, "c:\TempRSWINFiles\pump_off.dat", OpenMode.Input, OpenAccess.[Default], OpenShare.[Default], -1)
			End If
			If bRead Then
				FileSystem.Input(num2, p_s.SV_clear_vol)
			End If
			If bWrite Then
				FileSystem.PrintLine(num, New Object() { p_s.SV_clear_vol })
			End If
			If p_s.SV_clear_vol < 0.1 Then
				p_s.iostat = -8846
				Return
			End If
			If bRead Then
				FileSystem.Input(num2, p_s.TV_clear_vol)
			End If
			If bWrite Then
				FileSystem.PrintLine(num, New Object() { p_s.TV_clear_vol })
			End If
			If p_s.TV_clear_vol < 0.1 Then
				p_s.iostat = -8841
				Return
			End If
			If bRead Then
				FileSystem.Input(num2, p_s.TV_pos_init)
			End If
			If bWrite Then
				FileSystem.PrintLine(num, New Object() { p_s.TV_pos_init })
			End If
			If bWrite Then
				FileSystem.FileClose(New Integer() { num })
			End If
			If bRead Then
				FileSystem.FileClose(New Integer() { num2 })
				Return
			End If
		End Sub

		Public Sub read_rod(ByRef p_s As TEImpred.parameter_structure_type, ByRef r_t As TEImpred.rod_taper_data_type(), ByRef t_t As TEImpred.tbg_taper_data_type(), Optional bRead As Boolean = False, Optional bWrite As Boolean = False)
			' The following expression was wrapped in a checked-statement
			Try
				bWrite = RSWIN_DESC.bWriteCSVFIles
				If RSWIN_DESC.bBETA Then
					bWrite = False
					bRead = False
				End If
				Dim num As Integer
				If bWrite Then
					Dim text As String = "c:\TempRSWINFiles\RSWIN-impred2.dat"
					If FILEUTIL.FileExists(text) Then
						FileSystem.FileClose(New Integer() { num })
						FileSystem.Kill("c:\TempRSWINFiles\RSWIN-impred2.dat")
					End If
					num = FileSystem.FreeFile()
					FileSystem.FileOpen(num, "c:\TempRSWINFiles\RSWIN-impred2.dat", OpenMode.Output, OpenAccess.[Default], OpenShare.[Default], -1)
				End If
				Dim num2 As Integer
				If bRead Then
					num2 = FileSystem.FreeFile()
					FileSystem.FileOpen(num2, "c:\TempRSWINFiles\impred2.dat", OpenMode.Input, OpenAccess.Read, OpenShare.[Default], -1)
				End If
				If bRead Then
					FileSystem.Input(num2, p_s.num_rod_tapers)
				End If
				If bWrite Then
					FileSystem.PrintLine(num, New Object() { p_s.num_rod_tapers })
				End If
				Dim num3 As Integer = 1
				Dim num_rod_tapers As Integer = p_s.num_rod_tapers
				For i As Integer = num3 To num_rod_tapers
					If bRead Then
						FileSystem.Input(num2, r_t(i).taper_depth)
						FileSystem.Input(num2, r_t(i).rod_od)
						FileSystem.Input(num2, r_t(i).rod_id)
						FileSystem.Input(num2, r_t(i).rod_density)
						FileSystem.Input(num2, r_t(i).rod_modulus)
						FileSystem.Input(num2, r_t(i).dimless_damp_dn)
						FileSystem.Input(num2, r_t(i).dimless_damp_up)
						FileSystem.Input(num2, r_t(i).friction_coef)
					End If
					If bWrite Then
						FileSystem.PrintLine(num, New Object() { String.Concat(New String() { Conversions.ToString(r_t(i).taper_depth), ",", Conversions.ToString(r_t(i).rod_od), ",", Conversions.ToString(r_t(i).rod_id), ",", Conversions.ToString(r_t(i).rod_density), ",", Conversions.ToString(r_t(i).rod_modulus), ",", Conversions.ToString(r_t(i).dimless_damp_dn), ",", Conversions.ToString(r_t(i).dimless_damp_up), ",", Conversions.ToString(r_t(i).friction_coef) }) })
					End If
				Next
				If bRead Then
					FileSystem.Input(num2, p_s.num_rod_elements)
				End If
				If bWrite Then
					FileSystem.PrintLine(num, New Object() { p_s.num_rod_elements })
				End If
				If bRead Then
					FileSystem.Input(num2, p_s.timestep_multiplier)
				End If
				If bWrite Then
					FileSystem.PrintLine(num, New Object() { p_s.timestep_multiplier })
				End If
				If bRead Then
					FileSystem.Input(num2, p_s.i_downhole_dyno)
				End If
				If bWrite Then
					FileSystem.PrintLine(num, New Object() { p_s.i_downhole_dyno })
				End If
				p_s.i_downhole_dyno = p_s.i_downhole_dyno
				If p_s.i_downhole_dyno > p_s.num_rod_elements Or p_s.i_downhole_dyno < 0 Then
					p_s.i_downhole_dyno = p_s.i_downhole_dyno
					p_s.iostat = -8520
				End If
				If bRead Then
					FileSystem.Input(num2, p_s.liquid_level)
				End If
				If bWrite Then
					FileSystem.PrintLine(num, New Object() { p_s.liquid_level })
				End If
				If bRead Then
					FileSystem.Input(num2, p_s.sp_grav_oil)
				End If
				If bWrite Then
					FileSystem.PrintLine(num, New Object() { p_s.sp_grav_oil })
				End If
				If bRead Then
					FileSystem.Input(num2, p_s.sp_grav_water)
				End If
				If bWrite Then
					FileSystem.PrintLine(num, New Object() { p_s.sp_grav_water })
				End If
				If bRead Then
					FileSystem.Input(num2, p_s.watercut)
				End If
				If bWrite Then
					FileSystem.PrintLine(num, New Object() { p_s.watercut })
				End If
				p_s.liq_grav_csg = p_s.sp_grav_oil
				If bRead Then
					FileSystem.Input(num2, p_s.pump_diam)
				End If
				If bWrite Then
					FileSystem.PrintLine(num, New Object() { p_s.pump_diam })
				End If
				If bRead Then
					FileSystem.Input(num2, p_s.pump_effic)
				End If
				If bWrite Then
					FileSystem.PrintLine(num, New Object() { p_s.pump_effic })
				End If
				If bRead Then
					FileSystem.Input(num2, p_s.strokes_per_min)
				End If
				If bWrite Then
					FileSystem.PrintLine(num, New Object() { p_s.strokes_per_min })
				End If
				If bRead Then
					FileSystem.Input(num2, p_s.tubing_pressure)
				End If
				If bWrite Then
					FileSystem.PrintLine(num, New Object() { p_s.tubing_pressure })
				End If
				If bRead Then
					FileSystem.Input(num2, p_s.casing_pressure)
				End If
				If bWrite Then
					FileSystem.PrintLine(num, New Object() { p_s.casing_pressure })
				End If
				If bRead Then
					FileSystem.Input(num2, p_s.max_iterations)
				End If
				If bWrite Then
					FileSystem.PrintLine(num, New Object() { p_s.max_iterations })
				End If
				If bRead Then
					FileSystem.Input(num2, p_s.num_cycles)
				End If
				If bWrite Then
					FileSystem.PrintLine(num, New Object() { p_s.num_cycles })
				End If
				If bRead Then
					FileSystem.Input(num2, p_s.pump_fillup)
				End If
				If bWrite Then
					FileSystem.PrintLine(num, New Object() { p_s.pump_fillup })
				End If
				If bRead Then
					FileSystem.Input(num2, p_s.gas_exponent)
				End If
				If bWrite Then
					FileSystem.PrintLine(num, New Object() { p_s.gas_exponent })
				End If
				p_s.compress_tol = 0.01
				p_s.omega_fill = 0.7
				If bRead Then
					FileSystem.Input(num2, p_s.compress_tol)
				End If
				If bWrite Then
					FileSystem.PrintLine(num, New Object() { p_s.compress_tol })
				End If
				If bRead Then
					FileSystem.Input(num2, p_s.omega_fill)
				End If
				If bWrite Then
					FileSystem.PrintLine(num, New Object() { p_s.omega_fill })
				End If
				If bRead Then
					FileSystem.Input(num2, p_s.num_tbg_tapers)
				End If
				If bWrite Then
					FileSystem.PrintLine(num, New Object() { p_s.num_tbg_tapers })
				End If
				Dim num4 As Integer = 1
				Dim num_tbg_tapers As Integer = p_s.num_tbg_tapers
				For i As Integer = num4 To num_tbg_tapers
					If bRead Then
						FileSystem.Input(num2, t_t(i).taper_depth)
						FileSystem.Input(num2, t_t(i).tbg_id)
						FileSystem.Input(num2, t_t(i).tbg_od)
						FileSystem.Input(num2, t_t(i).tbg_modulus)
					End If
					If bWrite Then
						FileSystem.PrintLine(num, New Object() { String.Concat(New String() { Conversions.ToString(t_t(i).taper_depth), ",", Conversions.ToString(t_t(i).tbg_id), ",", Conversions.ToString(t_t(i).tbg_od), ",", Conversions.ToString(t_t(i).tbg_modulus) }) })
					End If
				Next
				If bRead Then
					FileSystem.Input(num2, p_s.anch_depth)
				End If
				If bWrite Then
					FileSystem.PrintLine(num, New Object() { p_s.anch_depth })
				End If
				If bRead Then
					FileSystem.Input(num2, p_s.poisson)
				End If
				If bWrite Then
					FileSystem.PrintLine(num, New Object() { p_s.poisson })
				End If
				If bRead Then
					FileSystem.Input(num2, p_s.pr_drag_f_max)
				End If
				If bWrite Then
					FileSystem.PrintLine(num, New Object() { p_s.pr_drag_f_max })
				End If
				If bRead Then
					FileSystem.Input(num2, p_s.p_drag_f_max_up)
				End If
				If bWrite Then
					FileSystem.PrintLine(num, New Object() { p_s.p_drag_f_max_up })
				End If
				If bRead Then
					FileSystem.Input(num2, p_s.p_drag_f_max_dn)
				End If
				If bWrite Then
					FileSystem.PrintLine(num, New Object() { p_s.p_drag_f_max_dn })
				End If
				If bWrite Then
					FileSystem.FileClose(New Integer() { num })
				End If
				If bRead Then
					FileSystem.FileClose(New Integer() { num2 })
				End If
				Dim num5 As Double = 0.0001
				Dim num6 As Integer = 1
				Dim num_rod_tapers2 As Integer = p_s.num_rod_tapers
				For i As Integer = num6 To num_rod_tapers2
					If r_t(i).rod_od > num5 Then
						num5 = r_t(i).rod_od
					End If
				Next
				If num5 > 1.25 Then
					p_s.iostat = -8743
				Else
					Dim num7 As Double = 100.0
					Dim num8 As Integer = 1
					Dim num_tbg_tapers2 As Integer = p_s.num_tbg_tapers
					For i As Integer = num8 To num_tbg_tapers2
						If t_t(i).tbg_id < num7 Then
							num7 = t_t(i).tbg_id
						End If
					Next
					Dim num9 As Double = 0.0
					Dim num10 As Integer = 1
					Dim num_rod_tapers3 As Integer = p_s.num_rod_tapers
					For i As Integer = num10 To num_rod_tapers3
						num9 = r_t(i).rod_id
					Next
					Dim num11 As Double = 1.0
					If num9 = 0.0 Then
						num11 = 2.0
					End If
					If num7 < num11 * num5 Then
						p_s.iostat = -8868
					Else
						Dim num12 As Integer = 1
						Dim num_tbg_tapers3 As Integer = p_s.num_tbg_tapers
						For i As Integer = num12 To num_tbg_tapers3
							If t_t(i).tbg_id >= t_t(i).tbg_od Then
								p_s.iostat = -8867
								Return
							End If
						Next
						If p_s.anch_depth > r_t(p_s.num_rod_tapers).taper_depth Then
							p_s.iostat = -8872
						ElseIf p_s.anch_depth < 0.0 Then
							p_s.iostat = -8871
						ElseIf p_s.poisson > 1.0 Or p_s.poisson < 0.0 Then
							p_s.iostat = -8870
						ElseIf t_t(p_s.num_tbg_tapers).taper_depth < p_s.anch_depth Then
							p_s.iostat = -8867
						Else
							Dim i As Integer = p_s.num_rod_tapers
							If p_s.liquid_level < r_t(i).taper_depth And p_s.pump_fillup < 1.0 Then
								p_s.iostat = -8744
							End If
						End If
					End If
				End If
			Catch ex As Exception
				MessageBox.Show(ex.Message)
			End Try
		End Sub

		Public Sub read_sur(ByRef p_s As TEImpred.parameter_structure_type, ByRef s_p As TEImpred.survey_point_type(), Optional bRead As Boolean = False, Optional bWrite As Boolean = False)
			p_s.iostat = 0
			bWrite = RSWIN_DESC.bWriteCSVFIles
			If RSWIN_DESC.bBETA Then
				bWrite = False
				bRead = False
			End If
			Dim num As Integer
			If bWrite Then
				Dim text As String = "c:\TempRSWINFiles\RSWIN-survey.dat"
				If FILEUTIL.FileExists(text) Then
					FileSystem.FileClose(New Integer() { num })
					FileSystem.Kill("c:\TempRSWINFiles\RSWIN-survey.dat")
				End If
				num = FileSystem.FreeFile()
				FileSystem.FileOpen(num, "c:\TempRSWINFiles\RSWIN-survey.dat", OpenMode.Output, OpenAccess.[Default], OpenShare.[Default], -1)
			End If
			Dim num2 As Integer
			If bRead Then
				num2 = FileSystem.FreeFile()
				FileSystem.FileOpen(num2, "c:\TempRSWINFiles\survey.dat", OpenMode.Input, OpenAccess.[Default], OpenShare.[Default], -1)
			End If
			If bRead Then
				FileSystem.Input(num2, p_s.num_survey_points)
			End If
			If bWrite Then
				FileSystem.PrintLine(num, New Object() { p_s.num_survey_points })
			End If
			If p_s.num_survey_points > p_s.max_survey_points Then
				p_s.iostat = -9993
				Return
			End If
			If p_s.num_survey_points < 2 Then
				p_s.iostat = -9994
				Return
			End If
			Dim num3 As Integer = 1
			Dim num_survey_points As Integer = p_s.num_survey_points
			For i As Integer = num3 To num_survey_points
				If bRead Then
					FileSystem.Input(num2, s_p(i).m_d)
					FileSystem.Input(num2, s_p(i).inc)
					FileSystem.Input(num2, s_p(i).azi)
				End If
				If bWrite Then
					FileSystem.PrintLine(num, New Object() { String.Concat(New String() { Conversions.ToString(s_p(i).m_d), ",", Conversions.ToString(s_p(i).inc), ",", Conversions.ToString(s_p(i).azi) }) })
				End If
			Next
			If bWrite Then
				FileSystem.FileClose(New Integer() { num })
			End If
			If bRead Then
				FileSystem.FileClose(New Integer() { num2 })
				Return
			End If
		End Sub

		Public Sub read_var_spm(ByRef p_s As TEImpred.parameter_structure_type, Optional bRead As Boolean = False, Optional bWrite As Boolean = False)
			p_s.iostat = 0
			bWrite = RSWIN_DESC.bWriteCSVFIles
			If RSWIN_DESC.bBETA Then
				bWrite = False
				bRead = False
			End If
			Dim num As Integer
			If bWrite Then
				Dim text As String = "c:\TempRSWINFiles\RSWIN-var_spm.dat"
				If FILEUTIL.FileExists(text) Then
					FileSystem.FileClose(New Integer() { num })
					FileSystem.Kill("c:\TempRSWINFiles\RSWIN-var_spm.dat")
				End If
				num = FileSystem.FreeFile()
				FileSystem.FileOpen(num, "c:\TempRSWINFiles\RSWIN-var_spm.dat", OpenMode.Output, OpenAccess.[Default], OpenShare.[Default], -1)
			End If
			Dim num2 As Integer
			If bRead Then
				num2 = FileSystem.FreeFile()
				FileSystem.FileOpen(num2, "c:\TempRSWINFiles\var_spm.dat", OpenMode.Input, OpenAccess.[Default], OpenShare.[Default], -1)
			End If
			If bRead Then
				FileSystem.Input(num2, p_s.eff_gb)
			End If
			If bWrite Then
				FileSystem.PrintLine(num, New Object() { p_s.eff_gb })
			End If
			If p_s.eff_gb < 0.0 Or p_s.eff_gb > 1.0 Then
				p_s.iostat = -8831
				Return
			End If
			If bRead Then
				FileSystem.Input(num2, p_s.eff_pu)
			End If
			If bWrite Then
				FileSystem.PrintLine(num, New Object() { p_s.eff_pu })
			End If
			If p_s.eff_pu < 0.0 Or p_s.eff_pu > 1.0 Then
				p_s.iostat = -8829
				Return
			End If
			If bRead Then
				FileSystem.Input(num2, p_s.eff_vb)
			End If
			If bWrite Then
				FileSystem.PrintLine(num, New Object() { p_s.eff_vb })
			End If
			If p_s.eff_vb < 0.0 Or p_s.eff_vb > 1.0 Then
				p_s.iostat = -8827
				Return
			End If
			If bRead Then
				FileSystem.Input(num2, p_s.force_su)
			End If
			If bWrite Then
				FileSystem.PrintLine(num, New Object() { p_s.force_su })
			End If
			If p_s.four_bar_class = 1 Then
				If p_s.force_su < -2000.0 Then
					p_s.iostat = -8772
					Return
				End If
				If p_s.force_su > 1000.0 Then
					p_s.iostat = -8771
					Return
				End If
			End If
			If p_s.four_bar_class = 3 Then
				If p_s.force_su < -10000.0 Then
				End If
				If p_s.force_su > -1000.0 Then
				End If
			End If
			If bRead Then
				FileSystem.Input(num2, p_s.ratio_gb)
			End If
			If bWrite Then
				FileSystem.PrintLine(num, New Object() { p_s.ratio_gb })
			End If
			If bRead Then
				FileSystem.Input(num2, p_s.ratio_vb)
			End If
			If bWrite Then
				FileSystem.PrintLine(num, New Object() { p_s.ratio_vb })
			End If
			If bRead Then
				FileSystem.Input(num2, p_s.torq_cw)
			End If
			If bWrite Then
				FileSystem.PrintLine(num, New Object() { p_s.torq_cw })
			End If
			If bRead Then
				FileSystem.Input(num2, p_s.torq_cr)
			End If
			If bWrite Then
				FileSystem.PrintLine(num, New Object() { p_s.torq_cr })
			End If
			If bRead Then
				FileSystem.Input(num2, p_s.wk_sq_beam)
			End If
			If bWrite Then
				FileSystem.PrintLine(num, New Object() { p_s.wk_sq_beam })
			End If
			If bRead Then
				FileSystem.Input(num2, p_s.wk_sq_cw)
			End If
			If bWrite Then
				FileSystem.PrintLine(num, New Object() { p_s.wk_sq_cw })
			End If
			If bRead Then
				FileSystem.Input(num2, p_s.wk_sq_cr)
			End If
			If bWrite Then
				FileSystem.PrintLine(num, New Object() { p_s.wk_sq_cr })
			End If
			If bRead Then
				FileSystem.Input(num2, p_s.wk_sq_gb)
			End If
			If bWrite Then
				FileSystem.PrintLine(num, New Object() { p_s.wk_sq_gb })
			End If
			If bRead Then
				FileSystem.Input(num2, p_s.wk_sq_hss)
			End If
			If bWrite Then
				FileSystem.PrintLine(num, New Object() { p_s.wk_sq_hss })
			End If
			If bRead Then
				FileSystem.Input(num2, p_s.wk_sq_lss)
			End If
			If bWrite Then
				FileSystem.PrintLine(num, New Object() { p_s.wk_sq_lss })
			End If
			If bRead Then
				FileSystem.Input(num2, p_s.wk_sq_mot)
			End If
			If bWrite Then
				FileSystem.PrintLine(num, New Object() { p_s.wk_sq_mot })
			End If
			If bWrite Then
				FileSystem.FileClose(New Integer() { num })
			End If
			If bRead Then
				FileSystem.FileClose(New Integer() { num2 })
				Return
			End If
		End Sub

		Public Function Run_Partial() As Boolean
			Me.m_p_s.angl_cwt_phase = Me.m_angl_cwt_phase
			Me.m_p_s.API_len_A = Me.m_API_len_A
			Me.m_f_e = New TEImpred.fluid_element_data_type(Me.m_p_s.max_fluid_elem + 1 - 1) {}
			Me.m_l_u = New TEImpred.lookup_table_data_type(Me.m_p_s.lookup_max + 1 - 1) {}
			Me.m_RunStatus = 0
			Me.TEImpred2_Partial(Me.m_p_s, Me.m_f_e, Me.m_l_u, Me.m_m_c, Me.m_p_u, Me.m_r_e, Me.m_r_t, Me.m_s_p, Me.m_t_s, Me.m_t_t, Me.m_d_l)
			Application.DoEvents()
			Application.DoEvents()
			Application.DoEvents()
			Application.DoEvents()
			Application.DoEvents()
			Application.DoEvents()
			Return Me.m_p_s.iostat = 0
		End Function

		Public Function Run_Remainder() As Boolean
			Me.m_RunStatus = 0
			Me.TEImpred2_Remainder(Me.m_p_s, Me.m_f_e, Me.m_l_u, Me.m_m_c, Me.m_p_u, Me.m_r_e, Me.m_r_t, Me.m_s_p, Me.m_t_s, Me.m_t_t, Me.m_d_l)
			Application.DoEvents()
			Application.DoEvents()
			Application.DoEvents()
			Application.DoEvents()
			Application.DoEvents()
			Application.DoEvents()
			Return Me.m_p_s.iostat = 0
		End Function

		Public Function Run() As Boolean
			Me.m_p_s.angl_cwt_phase = Me.m_angl_cwt_phase
			Me.m_p_s.API_len_A = Me.m_API_len_A
			Me.m_f_e = New TEImpred.fluid_element_data_type(Me.m_p_s.max_fluid_elem + 1 - 1) {}
			Me.m_l_u = New TEImpred.lookup_table_data_type(Me.m_p_s.lookup_max + 1 - 1) {}
			Me.m_RunStatus = 0
			Me.TEImpred2(Me.m_p_s, Me.m_f_e, Me.m_l_u, Me.m_m_c, Me.m_p_u, Me.m_r_e, Me.m_r_t, Me.m_s_p, Me.m_t_s, Me.m_t_t, Me.m_d_l)
			Application.DoEvents()
			Application.DoEvents()
			Application.DoEvents()
			Application.DoEvents()
			Application.DoEvents()
			Application.DoEvents()
			Return Me.m_p_s.iostat = 0
		End Function

		Public Function ArcCosine(x As Double) As Double
			Dim num As Integer
			Dim num2 As Double
			Dim num3 As Integer
			Dim obj As Object
			Try
				ProjectData.ClearProjectError()
				num = 2
				If x >= 1.0 Then
					num2 = 0.0
				ElseIf x <= -1.0 Then
					num2 = 3.141592653589793
				Else
					num2 = 1.5707963267948966 - Math.Atan(x / Math.Sqrt(1.0 - x * x))
				End If
				IL_60:
				GoTo IL_A3
				IL_62:
				num3 = -1
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_76:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num3 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_62
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_A3:
			Dim result As Double = num2
			If num3 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		Private Function ArcSine(x As Double) As Double
			Dim num As Integer
			Dim num2 As Double
			Dim num3 As Integer
			Dim obj As Object
			Try
				ProjectData.ClearProjectError()
				num = 2
				If Math.Abs(x) >= 1.0 Then
					num2 = 1.5707963267948966 * CDbl(Math.Sign(x))
				Else
					num2 = Math.Atan(x / Math.Sqrt(1.0 - x * x))
				End If
				IL_48:
				GoTo IL_8B
				IL_4A:
				num3 = -1
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num)
				IL_5E:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num <> 0 And num3 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_4A
			End Try
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_8B:
			Dim result As Double = num2
			If num3 <> 0 Then
				ProjectData.ClearProjectError()
			End If
			Return result
		End Function

		Public Function Log10(ByRef x As Object) As Double
			Return Math.Log(Conversions.ToDouble(x)) / Math.Log(10.0)
		End Function

		Private Sub ClassInitialize()
			Me.m_p_s.epsilon = 1E-06
			Me.m_p_s.max_survey_points = 1500
			Me.m_s_p = New TEImpred.survey_point_type(Me.m_p_s.max_survey_points + 1 - 1) {}
			Me.m_p_s.max_pump_unit_data_points = 1000
			Me.m_p_u = New TEImpred.pump_unit_data_point_type(Me.m_p_s.max_pump_unit_data_points + 1 - 1) {}
			Me.m_p_s.max_timesteps = 32000
			Me.m_t_s = New TEImpred.timestep_data_type(Me.m_p_s.max_timesteps + 1 - 1) {}
			Me.m_p_s.max_rod_tapers = 20
			Me.m_r_t = New TEImpred.rod_taper_data_type(Me.m_p_s.max_rod_tapers + 1 - 1) {}
			Me.m_p_s.Max_Rod_Elements = 4000
			Me.m_r_e = New TEImpred.rod_element_data_type(Me.m_p_s.Max_Rod_Elements + 1 - 1) {}
			Me.m_p_s.max_tbg_tapers = 20
			Me.m_t_t = New TEImpred.tbg_taper_data_type(Me.m_p_s.max_tbg_tapers + 1 - 1) {}
			Me.m_p_s.mot_pts_max = 1000
			Me.m_m_c = New TEImpred.motor_characteristic_data_type(Me.m_p_s.mot_pts_max + 1 - 1) {}
			Me.m_p_s.lookup_max = 20000
			Me.m_l_u = New TEImpred.lookup_table_data_type(Me.m_p_s.lookup_max + 1 - 1) {}
			Me.m_p_s.max_fluid_elem = 4000
			Me.m_f_e = New TEImpred.fluid_element_data_type(Me.m_p_s.max_fluid_elem + 1 - 1) {}
			Me.m_p_s.max_dogleg_elem = 20000.0
			Me.m_d_l = New TEImpred.dog_leg_data_type(CInt(Math.Round(Me.m_p_s.max_dogleg_elem)) + 1 - 1) {}
			Me.m_p_s.Min_Rod_Elements = 20
			Me.m_d_l = New TEImpred.dog_leg_data_type(Me.m_p_s.Min_Rod_Elements + 1 - 1) {}
		End Sub

		Public Sub New()
			Me.ClassInitialize()
		End Sub

		Public Sub Initialize()
			Me.m_p_s.epsilon = 1E-06
			Me.m_p_s.max_survey_points = 1500
			Me.m_s_p = New TEImpred.survey_point_type(Me.m_p_s.max_survey_points + 1 - 1) {}
			Me.m_p_s.max_pump_unit_data_points = 1000
			Me.m_p_u = New TEImpred.pump_unit_data_point_type(Me.m_p_s.max_pump_unit_data_points + 1 - 1) {}
			Me.m_p_s.max_timesteps = 32000
			Me.m_t_s = New TEImpred.timestep_data_type(Me.m_p_s.max_timesteps + 1 - 1) {}
			Me.m_p_s.max_rod_tapers = 20
			Me.m_r_t = New TEImpred.rod_taper_data_type(Me.m_p_s.max_rod_tapers + 1 - 1) {}
			Dim r_t As TEImpred.rod_taper_data_type() = New TEImpred.rod_taper_data_type(Me.m_p_s.max_rod_tapers + 1 - 1) {}
			Me.r_t = r_t
			Me.m_p_s.Max_Rod_Elements = 4000
			Me.m_r_e = New TEImpred.rod_element_data_type(Me.m_p_s.Max_Rod_Elements + 1 - 1) {}
			Dim r_e As TEImpred.rod_element_data_type() = New TEImpred.rod_element_data_type(Me.m_p_s.Max_Rod_Elements + 1 - 1) {}
			Me.r_e = r_e
			Me.m_p_s.max_tbg_tapers = 20
			Me.m_t_t = New TEImpred.tbg_taper_data_type(Me.m_p_s.max_tbg_tapers + 1 - 1) {}
			Me.m_p_s.mot_pts_max = 1000
			Me.m_m_c = New TEImpred.motor_characteristic_data_type(Me.m_p_s.mot_pts_max + 1 - 1) {}
			Me.m_p_s.lookup_max = 20000
			Me.m_l_u = New TEImpred.lookup_table_data_type(Me.m_p_s.lookup_max + 1 - 1) {}
			Me.m_p_s.max_fluid_elem = 4000
			Me.m_f_e = New TEImpred.fluid_element_data_type(Me.m_p_s.max_fluid_elem + 1 - 1) {}
			Me.m_p_s.max_dogleg_elem = 20000.0
			Me.m_d_l = New TEImpred.dog_leg_data_type(CInt(Math.Round(Me.m_p_s.max_dogleg_elem)) + 1 - 1) {}
		End Sub

		Private Const fg_poisson As Double = 0.27

		Private Const psi_ft As Double = 0.43333333333333335

		Private Const g_c As Double = 32.17405

		Private Const in2_ft2 As Double = 144.0

		Private Const sec_min As Double = 60.0

		Private Const rpm_to_rps As Double = 0.10471975511966

		Private Const rpm_to_vel As Double = 0.10471975511965977

		Private Const rad_to_deg As Double = 57.29577951308238

		Private Const p_atm As Double = 14.7

		Private Const water_den As Double = 62.4

		Private Const in_ft As Double = 12.0

		Private Const min_day As Double = 1440.0

		Private Const ft3_STB As Double = 5.615

		Private Const g_const As Double = 32.17405

		Private Const g_accel As Double = 32.17405

		Private Const water_dens As Double = 62.4

		Private Const grav_acc As Double = 32.17405

		Private Const ft_lbf_to_hp As Double = 33000.0

		Private Const in_lbf_to_hp As Double = 63025.357

		Public save_pump_position_po As Double

		Private m_displacement_1_n As Double

		Private n As Integer

		Private temp As Double

		Private fraction_i As Double

		Private m_angl_cwt_phase As Double

		Private m_API_len_A As Double

		Private m_p_s As TEImpred.parameter_structure_type

		Private m_d_l As TEImpred.dog_leg_data_type()

		Private m_f_e As TEImpred.fluid_element_data_type()

		Private m_l_u As TEImpred.lookup_table_data_type()

		Private m_m_c As TEImpred.motor_characteristic_data_type()

		Private m_p_u As TEImpred.pump_unit_data_point_type()

		Private m_r_e As TEImpred.rod_element_data_type()

		Private m_r_t As TEImpred.rod_taper_data_type()

		Private m_s_p As TEImpred.survey_point_type()

		Private m_t_s As TEImpred.timestep_data_type()

		Private m_t_t As TEImpred.tbg_taper_data_type()

		Private m_RunStatus As Integer

		Private m_Iart As Single

		Private m_Irot As Single

		Private m_Max_Rod_Elements As Integer

		Private m_torq_gb_rating As Double

		Private m_PRHP As Single

		Private m_PHP As Single

		Private m_EHP As Single

		Private m_bGetVBeltRatio As Boolean

		Private m_p_drag_f_max_dn As Double

		Private m_p_drag_f_max_up As Double

		Private m_new_ratio_vb As Double

		Private m_slippedRPM As Double

		Public Structure cart_coord_type
			Public x As Double

			Public y As Double

			Public z As Double
		End Structure

		Public Structure parameter_structure_type
			Public epsilon As Double

			Public liquid_level As Double

			Public strokes_per_min As Double

			Public pump_area As Double

			Public force_buoy_rod_bot As Double

			Public force_buoy_rod_bot_PAlocal As Double

			Public force_buoy_rod_bot_PAdistrib As Double

			Public force_buoy_rod_bot_Archimedes As Double

			Public hydrostat_psia_pump As Double

			Public pump_barrel_len As Double

			Public pump_pos_z As Double

			Public pump_density As Double

			Public pump_pull_rod_diam As Double

			Public pump_pull_rod_area As Double

			Public pump_mass As Double

			Public p_r_area As Double

			Public p_r_len As Double

			Public p_r_density As Double

			Public p_r_mass As Double

			Public p_r_weight_unbuoyed As Double

			Public p_r_MD As Double

			Public p_r_pos_z As Double

			Public p_r_psia_tbg As Double

			Public p_r_weight_buoyed As Double

			Public p_r_rstWrf As Double

			Public pump_effic As Double

			Public liquid_gravity As Double

			Public tubing_pressure As Double

			Public casing_pressure As Double

			Public gas_exponent As Double

			Public compress_tol As Double

			Public pump_fillup As Double

			Public omega_fill As Double

			Public rod_element_length As Double

			Public timestep_length As Double

			Public timestep_multiplier As Double

			Public liquid_level_TVD As Double

			Public pump_fluid_load As Double

			Public min_pump_load As Double

			Public pump_weight_buoyed As Double

			Public pump_weight_unbuoyed As Double

			Public rod_bot_load_min As Double

			Public rod_bot_load_max As Double

			Public max_char_vel As Double

			Public pump_stroke_length As Double

			Public pump_volumetric_rate As Double

			Public iostat As Integer

			Public i_downhole_dyno As Integer

			Public max_iterations As Integer

			Public num_cycles As Integer

			Public total_iterations As Integer

			Public max_ts_iter_pump_bc As Integer

			Public max_survey_points As Integer

			Public num_survey_points As Integer

			Public max_pump_unit_data_points As Integer

			Public num_pump_unit_data_points As Integer

			Public max_timesteps As Integer

			Public num_timesteps As Integer

			Public max_rod_tapers As Integer

			Public num_rod_tapers As Integer

			Public Max_Rod_Elements As Integer

			Public Min_Rod_Elements As Integer

			Public num_rod_elements As Integer

			Public max_tbg_tapers As Integer

			Public num_tbg_tapers As Integer

			Public anch_depth As Double

			Public k_rod_tbg As Double

			Public liq_grav_csg As Double

			Public max_d_h_force As Double

			Public max_p_r_force As Double

			Public max_p_r_force_buoyed As Double

			Public max_p_r_force_unbuoyed As Double

			Public max_p_r_position As Double

			Public max_pump_force As Double

			Public min_d_h_force As Double

			Public min_p_r_force As Double

			Public min_p_r_force_buoyed As Double

			Public min_p_r_force_unbuoyed As Double

			Public min_p_r_position As Double

			Public min_pump_force As Double

			Public p_r_diam As Double

			Public poisson As Double

			Public pump_diam As Double

			Public pump_spring_con As Double

			Public rod_spring_con As Double

			Public rod_stretch_max As Double

			Public rod_stretch_min As Double

			Public rod_stretch_range As Double

			Public surface_stroke As Double

			Public sp_grav_oil As Double

			Public sp_grav_water As Double

			Public tbg_force As Double

			Public tbg_force_max As Double

			Public tbg_force_min As Double

			Public tbg_spring_con As Double

			Public tbg_stretch_max As Double

			Public unanch_len As Double

			Public watercut As Double

			Public pr_drag_0 As Integer

			Public pr_drag_1 As Integer

			Public pr_drag_2 As Integer

			Public drag_0_exp As Double

			Public p_drag_up_0 As Integer

			Public p_drag_up_1 As Integer

			Public p_drag_up_2 As Integer

			Public p_drag_dn_0 As Integer

			Public p_drag_dn_1 As Integer

			Public p_drag_dn_2 As Integer

			Public p_drag_f_max_dn As Double

			Public p_drag_f_max_up As Double

			Public pr_drag_f_max As Double

			Public p_velo_max_up As Double

			Public p_velo_max_dn As Double

			Public pr_velo_max_dn As Double

			Public pr_velo_max_up As Double

			Public p_vol_init As Double

			Public po_vol_init As Double

			Public pump_psia_as As Double

			Public pump_psia_bs As Double

			Public SV_clear_vol As Double

			Public SV_pos_init As Double

			Public TV_clear_vol As Double

			Public TV_pos_init As Double

			Public amp_full_load As Double

			Public crank_angle_nu As Double

			Public delta_theta As Double

			Public delta_theta_nu As Double

			Public eff_gb As Double

			Public eff_gb_func As Double

			Public eff_gb_func_dn As Double

			Public eff_gb_func_up As Double

			Public pf_and_mot_func_dn As Double

			Public pf_and_mot_func_up As Double

			Public eff_pu As Double

			Public eff_pu_func As Double

			Public eff_pu_func_dn As Double

			Public eff_pu_func_up As Double

			Public eff_vb As Double

			Public eff_vb_func As Double

			Public eff_vb_func_dn As Double

			Public eff_vb_func_up As Double

			Public force_su As Double

			Public gen_A As Double

			Public gen_B As Double

			Public gen_C As Double

			Public inert_beam As Double

			Public inert_cr As Double

			Public inert_cw As Double

			Public inert_cwt As Double

			Public inert_gb As Double

			Public inert_hss_cr As Double

			Public inert_lss_cr As Double

			Public inert_mot_cr As Double

			Public inert_vb_cr As Double

			Public hp_mot As Double

			Public hp_mot_pr_i_cyc As Double

			Public mot_a As Double

			Public mot_b As Double

			Public mot_c As Double

			Public period As Double

			Public ratio_gb As Double

			Public ratio_tot As Double

			Public ratio_vb As Double

			Public ratio_vb_converged As Integer

			Public rpm_breakdown As Double

			Public rpm_full_load As Double

			Public rpm_no_load As Double

			Public slip_op_pt As Double

			Public spm_variation As Double

			Public slip_motor As Double

			Public slip_pu As Double

			Public spm_avg As Double

			Public spm_max As Double

			Public spm_min As Double

			Public timestep_avg As Double

			Public timestep_con As Double

			Public timestep_prev As Double

			Public torq_breakdown As Double

			Public torq_cr As Double

			Public torq_cw As Double

			Public torq_cwt As Double

			Public torq_eff_cwt As Double

			Public torq_eff_p_r As Double

			Public torq_eff_inert As Double

			Public torq_eff_mot As Double

			Public torq_full_load As Double

			Public torq_no_load As Double

			Public torq_p_r_dyn As Double

			Public torq_p_r_pr As Double

			Public torq_p_r_stat As Double

			Public torq_p_r_su As Double

			Public torq_p_r_tot As Double

			Public vel_breakdown As Double

			Public vel_cr_avg As Double

			Public vel_cr_con As Double

			Public vel_cr_min As Double

			Public vel_cr_max As Double

			Public vel_cr_next As Double

			Public vel_full_load As Double

			Public vel_mot As Double

			Public vel_no_load As Double

			Public wk_sq_beam As Double

			Public wk_sq_cr As Double

			Public wk_sq_cw As Double

			Public wk_sq_cwt As Double

			Public wk_sq_gb As Double

			Public wk_sq_hss As Double

			Public wk_sq_lss As Double

			Public wk_sq_mot As Double

			Public wk_sq_vb As Double

			Public lookup_max As Integer

			Public mot_pts As Integer

			Public mot_pts_max As Integer

			Public mot_pts_flag As Integer

			Public num_tstep_con As Integer

			Public n_down As Integer

			Public vari_spm As Integer

			Public angl_cwt_phase As Double

			Public API_len_A As Double

			Public four_bar_class As Integer

			Public cw_or_ccw As Integer

			Public id_motor As String

			Public id_beam_unit As String

			Public fluid_solution As Integer

			Public max_fluid_elem As Integer

			Public num_fluid_elem As Integer

			Public csg_psig_adj As Double

			Public comp_tot As Double

			Public damp_fluid As Double

			Public flu_elem_length As Double

			Public psia_max As Double

			Public psia_min As Double

			Public psia_min_allow As Double

			Public pump_load_adj As Double

			Public pump_area_mod As Double

			Public ref_psia As Double

			Public dimless_damp_flu As Double

			Public tbg_flu_dens As Double

			Public char_vel_fluid As Double

			Public SV_leak_coeff_init As Double

			Public SV_leak_percent As Double

			Public PU_UnitType As Integer

			Public torq_cwt_del As Double

			Public bOpenCsv As Boolean

			Public frn_debug_ppe As Object

			Public iIndexAtPump As Integer

			Public max_dogleg_elem As Double

			Public pump_pos As TEImpred.cart_coord_type

			Public pump_pos_err As Double

			Public pump_pos_err_max As Double

			Public surv_pt_err As Boolean

			Public surv_pt_err_max As Double

			Public num_dog_leg_pts As Integer

			Public num_dog_leg_pts_big As Integer

			Public dog_leg_nupro As Double

			Public dog_leg_nupro_r_e As Double

			Public dog_leg_nupro_s_p As Double

			Public dog_leg_err As Boolean

			Public nupro_power As Integer

			Public cwhp_PT_bal As Double

			Public cwhp_exist As Double

			Public mot_volt As Integer

			Public mshp_en_bal As Double

			Public mshp_exist As Double

			Public num_phases As Integer

			Public prhp_en_bal As Double

			Public prhp_exist As Double

			Public sum_len_div_vel As Double

			Public torq_cwt_ener As Double

			Public torq_cwt_ener_del As Double

			Public torq_cwt_ener_bal As Double

			Public force_buoy_cum_at_downhole_dyno As Double

			Public WrodsInFluid As Double
		End Structure

		Public Structure pump_unit_data_point_type
			Public crank_angle As Double

			Public p_r_position As Double

			Public torque_factor As Double
		End Structure

		Public Structure rod_taper_data_type
			Public taper_depth As Double

			Public taper_tvd As Double

			Public rod_area As Double

			Public rod_density As Double

			Public rod_modulus As Double

			Public friction_coef As Double

			Public dimless_damp_dn As Double

			Public dimless_damp_up As Double

			Public max_taper_force_top As Double

			Public max_taper_stress_top As Double

			Public min_taper_force_top As Double

			Public min_taper_stress_top As Double

			Public max_taper_force_bot As Double

			Public max_taper_stress_bot As Double

			Public min_taper_force_bot As Double

			Public min_taper_stress_bot As Double

			Public max_buckle_stress_top As Double

			Public min_buckle_stress_top As Double

			Public max_buckle_stress_bot As Double

			Public min_buckle_stress_bot As Double

			Public max_taper_stress_top_buoyed As Double

			Public min_taper_stress_top_buoyed As Double

			Public max_taper_force_top_buoyed As Double

			Public min_taper_force_top_buoyed As Double

			Public max_taper_force_bot_buoyed As Double

			Public max_taper_stress_bot_buoyed As Double

			Public min_taper_force_bot_buoyed As Double

			Public min_taper_stress_bot_buoyed As Double

			Public max_taper_stress_top_unbuoyed As Double

			Public min_taper_stress_top_unbuoyed As Double

			Public max_taper_force_top_unbuoyed As Double

			Public min_taper_force_top_unbuoyed As Double

			Public max_taper_force_bot_unbuoyed As Double

			Public max_taper_stress_bot_unbuoyed As Double

			Public min_taper_force_bot_unbuoyed As Double

			Public min_taper_stress_bot_unbuoyed As Double

			Public rod_od As Double

			Public rod_id As Double

			Public rod_spring_con As Double

			Public taper_len As Double

			Public char_vel As Double

			Public rod_elem_len As Double

			Public num_rod_elem As Double

			Public Grade As Integer

			Public force_buoy As Double

			Public force_buoy_cum As Double

			Public hydrostat_psia_tbg As Double

			Public inc As Double

			Public mass As Double

			Public pos As TEImpred.cart_coord_type

			Public buoy_weight As Double

			Public unbuoy_weight As Double
		End Structure

		Public Structure survey_point_type
			Public m_d As Double

			Public inc As Double

			Public azi As Double

			Public dog As Double

			Public rad As Double

			Public pos As TEImpred.cart_coord_type

			Public tan As TEImpred.cart_coord_type

			Public nor As TEImpred.cart_coord_type
		End Structure

		Public Structure tbg_taper_data_type
			Public taper_depth As Double

			Public tbg_id As Double

			Public tbg_od As Double

			Public tbg_area As Double

			Public tbg_area_id As Double

			Public tbg_area_od As Double

			Public tbg_modulus As Double

			Public tbg_spring_con As Double

			Public taper_len As Double

			Public hydrostat_psia_csg As Double
		End Structure

		Public Structure motor_characteristic_data_type
			Public amp_mot As Double

			Public rpm_mot As Double

			Public torq_mot As Double

			Public vel_mot As Double

			Public hp_mot As Double
		End Structure

		Public Structure timestep_data_type
			Public crank_angle As Double

			Public p_r_position As Double

			Public p_r_force As Double

			Public p_r_force_orig As Double

			Public pump_force As Double

			Public pump_force_check As Double

			Public pump_force_corrected As Double

			Public pump_force_orig As Double

			Public pump_displacement As Double

			Public pump_velocity As Double

			Public downhole_position As Double

			Public downhole_force As Double

			Public downhole_force_orig As Double

			Public tbg_velo As Double

			Public tbg_position As Double

			Public tbg_force As Double

			Public pr_drag_force As Double

			Public p_drag_force As Double

			Public bp_drag_force As Double

			Public SV_drag_force As Double

			Public TV_drag_force As Double

			Public vel_ratio As Double

			Public d_pump_off As Double

			Public displacement_N_n As Double

			Public gas_vol As Double

			Public pump_psia_a As Double

			Public pump_psia_p As Double

			Public pump_psia_b As Double

			Public rod_bottom_velo As Double

			Public d_fluid_inertia As Double

			Public fluid_inertia_force As Double

			Public SVopen_pump_force As Double

			Public TVclos_pump_force As Double

			Public TVopen_pump_force As Double

			Public num_timesteps As Integer

			Public acc_beam As Double

			Public acc_cr As Double

			Public amp_mot As Double

			Public amp_mot_ener_bal As Double

			Public amp_mot_exist As Double

			Public amp_mot_norm As Double

			Public delta_theta As Double

			Public timestep_var As Double

			Public torq_crank_exist As Double

			Public torq_crank_bal As Double

			Public torq_cwt As Double

			Public torq_cwt_exist As Double

			Public torq_fact As Double

			Public torq_mot As Double

			Public torq_mot_ener_bal As Double

			Public torq_mot_exist As Double

			Public torq_mot_norm As Double

			Public torq_p_r As Double

			Public torq_p_r_stat As Double

			Public vel_beam As Double

			Public vel_cr As Double

			Public vel_mot As Double

			Public vel_mot_mshp As Double

			Public d_leaky_SV As Double

			Public SV_leak_coeff As Double

			Public SV_leak_coeff_max As Double

			Public p_r_force_permissible As Double

			Public torq_crank As Double
		End Structure

		Public Structure fluid_element_data_type
			Public hole_slope As Double

			Public m_d As Double

			Public psia_flu As Double

			Public psia_flu_prev As Double

			Public tbg_flu_dens As Double

			Public vel_flu As Double

			Public vel_flu_prev As Double
		End Structure

		Public Structure lookup_table_data_type
			Public crank_angle As Double

			Public p_r_position As Double

			Public torq_fact As Double
		End Structure

		Public Structure rod_element_data_type
			Public m_d As Double

			Public m_d_multi_matl As Double

			Public dog As Double

			Public rad As Double

			Public ea As Double

			Public friction_coef As Double

			Public mass As Double

			Public buoy_weight As Double

			Public unbuoy_weight As Double

			Public old_force As Double

			Public old_velocity As Double

			Public friction_force As Double

			Public gravity_force As Double

			Public pos As TEImpred.cart_coord_type

			Public tan As TEImpred.cart_coord_type

			Public nor As TEImpred.cart_coord_type

			Public sfg As TEImpred.cart_coord_type

			Public max_sf_total As Double

			Public inc As Double

			Public azi As Double

			Public max_force As Double

			Public min_force As Double

			Public max_force_unbuoyed As Double

			Public min_force_unbuoyed As Double

			Public max_force_buoyed As Double

			Public min_force_buoyed As Double

			Public damp_coef_dn As Double

			Public damp_coef_up As Double

			Public hydrostat_psia_tbg As Double

			Public hydrostat_psia_csg As Double

			Public dynamic_psia_tbg As Double

			Public dynamic_psia_csg As Double

			Public buckle_tendency As Double

			Public buckle_tendency_stress As Double

			Public buckle_tendency_max As Double

			Public buckle_tendency_stress_max As Double

			Public buckle_tendency_buoyed As Double

			Public force_buoy_cum As Double

			Public force_buoy_PAlocal_cum As Double

			Public force_buoy_PAdistrib_cum As Double

			Public force_buoy_Archimedes_cum As Double

			Public WrodsInFluid As Double

			Public rod_area As Double

			Public length As Double

			Public force_buoy As Double

			Public force_buoy_PAlocal As Double

			Public force_buoy_PAdistrib As Double

			Public force_buoy_Archimedes As Double

			Public rod_density As Double

			Public Grade As Integer
		End Structure

		Public Structure dog_leg_data_type
			Public dog_leg_per_for_dif As Double

			Public dog_leg_dif_for_per As Double

			Public dog_leg_dif As Double

			Public dog_leg_dif_big As Double

			Public dog_leg_dif_m_d As Double

			Public dog_leg_per As Double

			Public dog_leg_per_big As Double

			Public dog_leg_per_m_d As Double

			Public dog_leg_r_e As Double

			Public dog_leg_r_e_dif As Double

			Public dog_leg_r_e_norm As Double

			Public dog_leg_r_e_per As Double

			Public dog_leg_s_p As Double

			Public dog_leg_s_p_dif As Double

			Public dog_leg_s_p_norm As Double

			Public dog_leg_s_p_per As Double
		End Structure
	End Class
End Namespace
