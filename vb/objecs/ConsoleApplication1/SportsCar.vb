Imports MyCodeWidgets.carperformance

Public Class SportsCar
    Inherits Car


    Public Sub New()
        color = "GREEN"

    End Sub


    Public Weight As Integer

    Public Function GetPowerToWeightRatio() As Double
        Return CType(HorsePower, Double) / CType(Weight, Double)
    End Function

    Public Overrides Function CalculateAccelerationRate() As Double
        Return 4.2 * GetPowerToWeightRatio()
    End Function

End Class
