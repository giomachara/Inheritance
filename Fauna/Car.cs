namespace Fauna;

public class Car : Vehicle
{
    public Car(string manufacturer, string model, FuelType fueltype, TransType transType) : base(manufacturer, model, fueltype, transType)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Car was created!");
        Console.ResetColor();
    }
}


