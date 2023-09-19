using System;
class Program
{
    static void Main()
    {
        string x_str, y_str;
        double x, y;
        bool f1, f2;
        do
        {   
            Console.WriteLine("Введите вещественные x и y:");
            x_str = Console.ReadLine();
            y_str = Console.ReadLine();
            f1 =double.TryParse(x_str, out x);
            f2 = double.TryParse(y_str, out y);
        }
        while (!(f1 && f2));
        double f;
        if (x < y)
        {
            f = Math.Sin(x) + Math.Cos(y) * Math.Cos(y);
        }
        else if (x == y)
        {
            f = Math.Log(Math.Abs(x));
        }
        else
        {
            f = Math.Sin(x * x) + Math.Cos(y);
        }
        Console.WriteLine(f);
    }
}