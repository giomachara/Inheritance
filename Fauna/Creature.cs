namespace Fauna;

public abstract class Creature
{
    public Creature()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Creature was created!");
        Console.ResetColor();
        Breath();
    }

    public string Name { get; set; }

    //public void Breath()
    //{
    //    Console.WriteLine("Creature is breathing");
    //}

    public void Move()
    {
        Console.WriteLine("Creature is moving");
    }

    protected abstract void Breath();
    
}
