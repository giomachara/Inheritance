namespace Fauna;

public class Fish : Creature
{
    public Fish()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Fish was created!");
        Console.ResetColor();
    }
}