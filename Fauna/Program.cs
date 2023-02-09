using System.Numerics;

namespace Fauna;

class Program
{
    static void Main(string[] args)
    {
        Plane plane1 = new Plane("Messerschmidt", "BF109", FuelType.Aviafuel, TransType.Manual);
        plane1.FuelInfo();


        Car car1 = new Car("Mercedes", "W124", FuelType.Petrol, TransType.Automatic);
        car1.PrintVehicleInfo();
        car1.Drive();

        IFlying flyingPlane = new Plane("Messerschmidt", "BF109", FuelType.Aviafuel, TransType.Manual);

        flyingPlane.Fly();

        Bird bird1 = new Bird() { Name = "Guguli" };
        bird1.Fly();        

        IFlying shashvi = new Shashvi()
        {
            Name = "shashvi 0"
        };
        Bird shashvi1 = new Shashvi() { Name = "shashvi 1" };
        Shashvi shashvi2 = new Shashvi() { Name = "shashvi 2" };

        shashvi.Fly();
        shashvi1.Fly();
        shashvi2.Fly();

    }
}
