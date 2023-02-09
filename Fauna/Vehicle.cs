namespace Fauna;

public class Vehicle
{
     public Vehicle(string manufacturer, string model, FuelType fueltype, TransType transType)
    {
        Manufacturer = manufacturer;
        Model = model;
        FuelType = fueltype;
        TransType = transType;
    }

    public string Manufacturer { get; set; }

    public string Model { get; set; }

    public FuelType FuelType { get; set; }

    public TransType TransType { get; set; }


    public void PrintVehicleInfo()
    {
        Console.WriteLine($"{Manufacturer} {Model} {FuelType} {TransType}");
    }

    public void Drive()
    {
        Console.WriteLine($"{Model} is very Fast!");
    }

    public void FuelInfo()
    {
        Console.WriteLine($"{Manufacturer} {Model} engine works on {FuelType}");
    }
    public void Damaged(string reason)
    {
        Console.WriteLine($"Vehicle is damaged. Reason is: {reason}");
    }
}
public enum FuelType
{
    Petrol,
    Diesel,
    Hybrid,
    CNG,
    Aviafuel
}

public enum TransType
{
    Manual,
    Automatic,
    Tiptronic
}

