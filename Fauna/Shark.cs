namespace Fauna;

public class Shark : Fish
{
    public Shark(string name) : base(name)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Shark was created!");
        Console.ResetColor();
    }
}