using System;
class Program
{
    static void Main()
    {
        string str_num1 = Console.ReadLine();
        string str_num2 = Console.ReadLine();
        double num1 = double.Parse(str_num1);
        double num2 = double.Parse(str_num2);
        double int_part1 = Math.Truncate(num1);
        double int_part2 = Math.Truncate(num2);
        Console.WriteLine($"Сумма целых частей {num1} и {num2} равна {int_part1 + int_part2}");
        Console.WriteLine($"Сумма дробных частей {num1} и {num2} равна {num1 + num2 - int_part1 - int_part2}");
    }
}