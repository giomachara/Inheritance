namespace Fauna;

public class Plane : Vehicle, IFlying
{
    public Plane(string manufacturer, string model, FuelType fueltype, TransType transType) : base(manufacturer, model, fueltype, transType)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Plane was created!");
        Console.ResetColor();
    }

    public void Fly()
    {
        Console.WriteLine($"{Manufacturer} is flying");
    }
}