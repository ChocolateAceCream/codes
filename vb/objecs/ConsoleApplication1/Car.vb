Namespace carperformance

    Public Class Car
        Public color As String

        Public HorsePower As Integer


        Private intSpeed As Integer


        Private intNumberOfDoors As Integer

        Public Sub New()
            color = "white"
            intSpeed = 0
            intNumberOfDoors = 5
        End Sub

        Public ReadOnly Property Speed() As Integer
            Get
                Return intSpeed
            End Get
        End Property

        Public Sub Accelerate(accelerateBy As Integer)
            intSpeed += accelerateBy
        End Sub

        Public Property NumberOfDoors() As Integer
            Get
                Return intNumberOfDoors
            End Get
            Set(value As Integer)
                If value >= 2 And value <= 5 Then
                    intNumberOfDoors = value

                End If
            End Set
        End Property

        Public Function IsMoving() As Boolean

            If Speed = 0 Then
                Return False
            Else
                Return True
            End If
        End Function

        Public Overridable Function CalculateAccelerationRate() As Double
            Return 4.2
        End Function


    End Class
End Namespace
