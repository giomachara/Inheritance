namespace Fauna;

public class Dog : Animal
{
    public Dog()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Dog was created!");
        Console.ResetColor();
    }
}
