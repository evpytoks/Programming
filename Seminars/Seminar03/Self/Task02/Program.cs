using System;
class Program
{
    static void Main() 
    {
        string x_str, y_str;
        bool f1, f2;
        double x, y;
        do
        {
            x_str = Console.ReadLine();
            y_str = Console.ReadLine();
            f1 = double.TryParse(x_str, out x);
            f2 = double.TryParse(y_str, out y);
        }
        while (!(f1 && f2));
        double dist = Math.Sqrt(x * x + y * y);
        if (y < 0 || dist < 1 || dist > 2) {
            Console.WriteLine("Точка не принадлежит области.");
        }
        else if (Math.Abs(dist - 1) < (double)0.000000001 || Math.Abs(dist - 2) < (double)0.000000001)
        {
            Console.WriteLine("Точка лежит на границе области.");
        } 
        else
        {
            Console.WriteLine("Точка лежит внутри области.");
        }
    }
}
