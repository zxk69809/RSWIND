Imports System
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace RSWINV3
	Friend Class RegressionObject
		Private Sub GaussSolve(ByRef O As Integer)
			' The following expression was wrapped in a checked-statement
			Dim a As Double = CDbl((O + 1))
			Dim num As Integer = 0
			Dim num2 As Integer = O
			For i As Integer = num To num2
				Dim num3 As Integer = i
				Dim num4 As Double = Math.Abs(Me.M(num3, i))
				Dim num5 As Integer = i + 1
				Dim num6 As Integer = O
				For j As Integer = num5 To num6
					If num4 < Math.Abs(Me.M(j, i)) Then
						num3 = j
						num4 = Math.Abs(Me.M(num3, i))
					End If
				Next
				If i < num3 Then
					Dim num7 As Integer = i
					Dim num8 As Integer = CInt(Math.Round(a))
					For k As Integer = num7 To num8
						num4 = Me.M(i, k)
						Me.M(i, k) = Me.M(num3, k)
						Me.M(num3, k) = num4
					Next
				End If
				Dim num9 As Integer = i + 1
				Dim num10 As Integer = O
				For j As Integer = num9 To num10
					num4 = Me.M(j, i) / Me.M(i, i)
					Me.M(j, i) = 0.0
					Dim num11 As Integer = i + 1
					Dim num12 As Integer = CInt(Math.Round(a))
					For k As Integer = num11 To num12
						' The following expression was wrapped in a unchecked-expression
						Me.M(j, k) = Me.M(j, k) - Me.M(i, k) * num4
					Next
				Next
			Next
			For j As Integer = O To 0 Step -1
				Dim num4 As Double = Me.M(j, CInt(Math.Round(a)))
				Dim num13 As Integer = j + 1
				Dim num14 As Integer = O
				For k As Integer = num13 To num14

						num4 -= Me.M(j, k) * Me.C(k)

				Next
				Me.C(j) = num4 / Me.M(j, j)
			Next
			Me.Finished = True
		End Sub

		Private Sub BuildMatrix(ByRef O As Integer)
			' The following expression was wrapped in a checked-statement
			Dim num As Integer = O + 1
			Dim num2 As Integer = 0
			Dim num3 As Integer = O
			For i As Integer = num2 To num3
				Dim num4 As Integer = 0
				Dim num5 As Integer = O
				For j As Integer = num4 To num5
					Me.M(i, j) = Me.SumX(i + j)
				Next
				Me.M(i, num) = Me.SumYX(i)
			Next
		End Sub

		Private Sub FinalizeMatrix(ByRef O As Integer)
			' The following expression was wrapped in a checked-statement
			Dim num As Integer = O + 1
			Dim num2 As Integer = 0
			Dim num3 As Integer = O
			For i As Integer = num2 To num3
				Me.M(i, num) = Me.SumYX(i)
			Next
		End Sub

		Private Sub Solve()
			Dim num3 As Integer
			Dim num6 As Integer
			Dim obj As Object
			Try
				IL_00:
				Dim num As Integer = 1
				Dim num2 As Integer = Me.GlobalO
				IL_0A:
				num = 2
				If Me.XYCount > num2 Then
					GoTo IL_22
				End If
				IL_16:
				num = 3
				num2 = Me.XYCount - 1
				IL_22:
				num = 5
				If num2 >= 0 Then
					GoTo IL_2E
				End If
				IL_29:
				GoTo IL_14A
				IL_2E:
				num = 8
				Me.BuildMatrix(num2)
				IL_39:
				ProjectData.ClearProjectError()
				num3 = 1
				IL_40:
				num = 10
				Dim num4 As Integer = num2
				Me.GaussSolve(num4)
				IL_4E:
				While True
					IL_89:
					num = 12
					If Not(Information.Err().Number <> 0 And 1 < num2) Then
						Exit For
					End If
					IL_50:
					num = 13
					Information.Err().Clear()
					IL_5E:
					num = 14
					Me.C(0) = 0.0
					IL_73:
					num = 15
					num2 -= 1
					IL_7B:
					num = 16
					num4 = num2
					Me.FinalizeMatrix(num4)
				End While
				IL_A4:
				ProjectData.ClearProjectError()
				num3 = 0
				IL_AB:
				GoTo IL_14A
				IL_B0:
				Dim num5 As Integer = num6 + 1
				num6 = 0
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num5)
				IL_10A:
				GoTo IL_13F
				IL_10C:
				num6 = num
				switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3)
				IL_11D:
			Catch obj2 When endfilter(TypeOf obj Is Exception And num3 <> 0 And num6 = 0)
				Dim ex As Exception = CType(obj2, Exception)
				GoTo IL_10C
			End Try
			IL_13F:
			Throw ProjectData.CreateProjectError(-2146828237)
			IL_14A:
			If num6 <> 0 Then
				ProjectData.ClearProjectError()
			End If
		End Sub

		Private Sub Class_Initialize_Renamed()
			Me.Init()
			Me.GlobalO = 2
		End Sub

		Public Sub New()
			Me.SumX = New Double(50) {}
			Me.SumYX = New Double(25) {}
			Me.M = New Double(25, 26) {}
			Me.C = New Double(25) {}
			Me.Class_Initialize_Renamed()
		End Sub

		Public Sub Init()
			Me.Finished = False
			Dim num As Integer = 0
			Do
				Me.SumX(num) = 0.0
				Me.SumX(num + 25) = 0.0
				Me.SumYX(num) = 0.0
				Me.C(num) = 0.0
				num += 1
			Loop While num <= 25
		End Sub

		Public ReadOnly Property Coeff(Exponent As Integer) As Double
			Get
				If Not Me.Finished Then
					Me.Solve()
				End If
				Dim num As Integer = Math.Abs(Exponent)
				Dim num2 As Integer = Me.GlobalO
				If Me.XYCount <= num2 Then
					' The following expression was wrapped in a checked-expression
					num2 = Me.XYCount - 1
				End If
				Dim result As Double
				If num2 < num Then
					result = 0.0
				Else
					result = Me.C(num)
				End If
				Return result
			End Get
		End Property

		Public Property Degree As Integer
			Get
				Return Me.GlobalO
			End Get
			Set(value As Integer)
				If value < 0 Or 25 < value Then
					Information.Err().Raise(6000, "RegressionObject", Conversions.ToString(value) + " is an invalid property value! Use 0<= Degree <= " + Conversions.ToString(25), Nothing, Nothing)
					Return
				End If
				Me.Init()
				Me.GlobalO = value
			End Set
		End Property

		Public ReadOnly Property XYCount As Integer
			Get
				' The following expression was wrapped in a checked-expression
				Return CInt(Math.Round(Me.SumX(0)))
			End Get
		End Property

		Public Function XYAdd(NewX As Double, NewY As Double) As Object
			Me.Finished = False
			Dim num As Integer = 2 * Me.GlobalO
			Dim num2 As Double = 1.0
			Me.SumX(0) = Me.SumX(0) + 1.0
			Me.SumYX(0) = Me.SumYX(0) + NewY
			Dim num3 As Integer = 1
			Dim globalO As Integer = Me.GlobalO
			For i As Integer = num3 To globalO

					num2 *= NewX
					Me.SumX(i) = Me.SumX(i) + num2
					Me.SumYX(i) = Me.SumYX(i) + NewY * num2

			Next
			Dim num4 As Integer = Me.GlobalO + 1
			Dim num5 As Integer = num
			For i As Integer = num4 To num5

					num2 *= NewX
					Me.SumX(i) = Me.SumX(i) + num2

			Next
			Dim result As Object
			Return result
		End Function

		Public Function RegVal(ByRef X As Double) As Double
			If Not Me.Finished Then
				Me.Solve()
			End If
			Dim num As Double = 0.0
			Dim num2 As Integer = Me.GlobalO
			If Me.XYCount <= num2 Then
				num2 = Me.XYCount - 1
			End If
			Dim num3 As Integer = 0
			Dim num4 As Integer = num2
			For i As Integer = num3 To num4

					num += Me.C(i) * Math.Pow(X, CDbl(i))

			Next
			Return num
		End Function

		Private Const MaxO As Integer = 25

		Private GlobalO As Integer

		Private Finished As Boolean

		Private SumX As Double()

		Private SumYX As Double()

		Private M As Double(,)

		Private C As Double()
	End Class
End Namespace
