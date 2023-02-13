namespace Fauna;

public class Animal : Creature
{	
	public Animal(string name)
	{
		this.Name = name;

		Console.ForegroundColor = ConsoleColor.Green;
		Console.WriteLine($"Animalwith name {name} was created!");
		Console.ResetColor();
	}

    protected override void Breath()
    {
		Console.WriteLine("Animal is breathing");
    }
}
