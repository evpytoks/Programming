using System;
class Program 
{
    static void Main() 
    {
        int num1 = 1;
        double num2 = 0.5;
        char symble = '1';
        Console.WriteLine($"{num1}");
        Console.WriteLine($"{num2}");
        Console.WriteLine($"{symble}");
        Console.WriteLine(num1.GetType());
        Console.WriteLine(num2.GetType());
        Console.WriteLine(symble.GetType());
    }
}