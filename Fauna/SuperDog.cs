namespace Fauna;

public class SuperDog : Dog
{
    public SuperDog()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("SuperDog was created!");
        Console.ResetColor();
    }

    protected override void Breath()
    {
        Console.WriteLine("SuperDog is breathing with air");
    }
}