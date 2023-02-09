namespace Fauna;

public class Plane : Vehicle, IFlying
{
    public Plane(string manufacturer, string model, FuelType fueltype, TransType transType) : base(manufacturer, model, fueltype, transType)
    {
    }

    public void Fly()
    {
        Console.WriteLine($"{Manufacturer} is flying");
    }
}