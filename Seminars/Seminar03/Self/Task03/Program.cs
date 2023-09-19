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
        if (y >= 0)
        {
            if (dist < 2)
            {
                Console.WriteLine("Точка внутри области.");
            } 
            else if (Math.Abs(dist - 2) < 0.000000000001)
            {
                Console.WriteLine("Точка на границе области.");
            }
            else 
            {
                Console.WriteLine("Точка вне области.");
            }
        }
        else 
        {
            if (dist < 1)
            {
                Console.WriteLine("Точка внутри области.");
            } 
            else if (Math.Abs(dist - 1) < 0.000000000001)
            {
                Console.WriteLine("Точка на границе области.");
            }
            else 
            {
                Console.WriteLine("Точка вне области.");
            }
        }
    }
}