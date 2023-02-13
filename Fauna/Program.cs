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

        Dog dog1 = new Dog("bibi");
        dog1.Bark();

        Animal animal = new Animal("Zebra");

        Console.WriteLine();

        Dog dog = new Dog("Bobi");
        dog.Bark();

        Console.WriteLine();

        SuperDog superDog = new SuperDog();

        Console.WriteLine();

        Cat cat = new Cat("Cat");

        Shark shark = new Shark("Shark");

    }
}
