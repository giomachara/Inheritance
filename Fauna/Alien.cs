﻿namespace Fauna;

public abstract class Alien : Creature
    {
    public Alien()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Alien was created!");
        Console.ResetColor();
    }

    //public string Planet
}