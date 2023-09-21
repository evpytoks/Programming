using System;
class Program
{
    static void Main()
    {
        string str;
        double a, b, c;
        bool f;
        do
        {
            Console.WriteLine("Введите вещественное число а:");
            str = Console.ReadLine();
            f = double.TryParse(str, out a);
        }
        while (!f);
        double num1, num2;
        do
        {
            Console.WriteLine("Введите вещественное число b:");
            str = Console.ReadLine();
            f = double.TryParse(str, out b);
        }
        while (!f);
        do
        {
            Console.WriteLine("Введите вещественное число c:");
            str = Console.ReadLine();
            f = double.TryParse(str, out c);
        }
        while (!f);
        Console.WriteLine($"{a}*x^2 + {b}*x + {c} = 0");
        double d = b * b - 4 * a * c;
        if (a == 0)
        {
            Console.WriteLine($"x = {-c / b}");
        }
        else if (Math.Abs(d) <= 0.000000000001)
        {
            Console.WriteLine($"x = {-b / (2 * a)}");
        }
        else if (d > 0) 
        {
            Console.WriteLine($"x1 = {(-b + Math.Sqrt(d)) / (2 * a)}");
            Console.WriteLine($"x2 = {(-b - Math.Sqrt(d)) / (2 * a)}");
        }
        else
        {
            d = -d;
            double t = Math.Abs(Math.Sqrt(d) / (2 * a));
            if (b == 0) 
            {
                Console.WriteLine($"{t}i");
                Console.WriteLine($"-{t}i");
            }
            else 
            {
            Console.WriteLine($"x1 = {-b / (2 * a)} + {t}i");
            Console.WriteLine($"x2 = {-b / (2 * a)} - {t}i");
            }
        }
    } 
}