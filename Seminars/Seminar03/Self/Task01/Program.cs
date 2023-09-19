using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число углов (от 1 до 10) :");
        string n_str = Console.ReadLine();
        Console.WriteLine("Введите длину стороны (положительную) :");
        string l_str = Console.ReadLine();
        double n;
        double l;
        bool f1 = double.TryParse(n_str, out n);
        bool f2 = double.TryParse(l_str, out l);
        if (f1 && f2)
        {
            double s = (n * l * l) / (4.0 * Math.Tan(Math.PI / n));
            Console.WriteLine(s);
        }
        else 
        {
            Console.WriteLine("Ошибка");
        }
    }
}
