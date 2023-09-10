using System;
class Program
{
    static void Main()
    {   string surname = Console.ReadLine();
        string name = Console.ReadLine();
        string second_name = Console.ReadLine();
        Console.WriteLine($"Фамилия: {surname}");
        Console.WriteLine($"Имя: {name}");
        Console.WriteLine($"Отчество: {second_name}");
    }
}