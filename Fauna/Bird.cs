namespace Fauna;

public class Bird : Creature,IFlying

{
    public void Fly()
    {
        Console.WriteLine($"{Name} is flying");
    }
}