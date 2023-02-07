namespace Fauna;

public class Animal : Creature
{
	public Animal()
	{
		Console.ForegroundColor = ConsoleColor.Green;
		Console.WriteLine("Animal was created!");
		Console.ResetColor();
	}
}
