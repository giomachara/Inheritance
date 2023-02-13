namespace Fauna;

public class Bird : Creature,IFlying

{
    public Bird()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Bird was created!");
        Console.ResetColor();
    }
    public void Fly()
    {
        Console.WriteLine($"{Name} is flying");
    }

    protected override void Breath()
    {
        Console.WriteLine("Bird is breathing with air");
    }
}