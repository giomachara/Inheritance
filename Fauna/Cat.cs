﻿namespace Fauna;

public class Cat : Animal
{
    public Cat()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Cat was created!");
        Console.ResetColor();
    }
}