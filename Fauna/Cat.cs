namespace Fauna;

public class Cat : Animal
{
    public Cat(string name) : base(name)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Cat was created!");
        Console.ResetColor();
    }
}