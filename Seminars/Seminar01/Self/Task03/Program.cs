﻿using System;
class Program 
{
    static void Main() 
    {
        Console.WriteLine("Как тебя зовут?");
        string name = Console.ReadLine();
        Console.WriteLine($"Привет, {name}!");
    }
}
