using System;

class Program
{
    static void Main(string[] args)
    {
        VehicleFactory factory = VehicleFactory.Instance;

        Vehicle car = factory.CreateVehicle("Car", "Toyota", "Camry", 2023, "Black");
        Vehicle motorcycle = factory.CreateVehicle("Motorcycle", "Honda", "CBR", 1000, "Red");

        Console.WriteLine(car.Move());
        Console.WriteLine(car.GetDetails());

        Console.WriteLine(motorcycle.Move());
        Console.WriteLine(motorcycle.GetDetails());
    }
}
