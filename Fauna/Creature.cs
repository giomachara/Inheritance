namespace Fauna;

public class Creature
{
    public Creature()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Creature was created!");
        Console.ResetColor();
    }

    public string Name { get; set; }

    public void Breath()
    {
        Console.WriteLine("Creature is breathing");
    }
    
}
