using System;
using System.Text.RegularExpressions;
using System.Text.Unicode;
class Proram {
    static void Main()
    {
        string a = Console.ReadLine();
        string b = Console.ReadLine();
        bool f1, f2;
        double a_num, b_num, c;
        f1 = double.TryParse(a, out a_num);
        f2 = double.TryParse(b, out b_num);
        if (f1 && f2)  // проверка на то, что a и b числа.
        {
            c = Math.Sqrt(a_num * a_num + b_num * b_num);
            Console.WriteLine($"Гипотинуза: {c}");
        } 
        else 
        {
            Console.WriteLine("Ошибка");
        }
    }
}
