Module Module1

    Sub Main()


        Dim objCar As New SportsCar
        objCar.color = "Red"

        objCar.HorsePower = 240
        objCar.Weight = 1085

        DisplaySportsCarDetails(objCar)

        Console.ReadLine()

        DisplayCarDetails(objCar)

        Console.ReadLine()



        Console.WriteLine("My car is this color:")
        Console.WriteLine(objCar.color)

        Console.ReadLine()

        Console.WriteLine("The car's speed is now:")
        Console.WriteLine(objCar.Speed + 12131)





        If objCar.IsMoving = True Then
            Console.WriteLine("the car is moving.")
        Else
            Console.WriteLine("the car is stopped.")
        End If
        Console.ReadLine()
        objCar.Accelerate(5)

        Console.WriteLine("The car's speed is now:")
        Console.WriteLine(objCar.Speed)
        If objCar.IsMoving = True Then
            Console.WriteLine("the car is moving.")
        Else
            Console.WriteLine("the car is stopped.")
        End If

        Console.ReadLine()

        Console.WriteLine("The number of doors is:")
        Console.WriteLine(objCar.NumberOfDoors)

        Console.ReadLine()

        objCar.NumberOfDoors = 2000
        Console.WriteLine("The number of doors is:")
        objCar.NumberOfDoors = 4
        Console.WriteLine(objCar.NumberOfDoors)

        Console.ReadLine()

    End Sub

    Sub DisplayCarDetails(theCar As carperformance.Car)
        Console.WriteLine("color:" & theCar.color)
        Console.WriteLine("Number of doors:" & theCar.NumberOfDoors)
        Console.WriteLine("current speed" & theCar.Speed)
        Console.WriteLine("Acceleration raate:" & theCar.CalculateAccelerationRate)
    End Sub

    Sub DisplaySportsCarDetails(theCar As SportsCar)
        Console.WriteLine()
        Console.WriteLine("sports car horsepower:" & theCar.HorsePower)
        Console.WriteLine("Sports car weight:" & theCar.Weight)
        Console.WriteLine("power to weight ratio:" & theCar.GetPowerToWeightRatio)

    End Sub
   


End Module

