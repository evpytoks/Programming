using System;
using System.Text.Unicode;
class Proram {
    static void Main()
    {
        string u = Console.ReadLine();
        string r = Console.ReadLine();
        bool f1, f2;
        double u_num, r_num, i, p;
        f1 = double.TryParse(u, out u_num);
        f2 = double.TryParse(r, out r_num);
        if (f1 && f2) 
        {
            i = u_num / r_num;
            p = (u_num * u_num) / r_num;
            Console.WriteLine($"Сила тока: {i}");
            Console.WriteLine($"Потребляемая мощность электрической цепи: {p}");
        } 
        else 
        {
            Console.WriteLine("Ошибка");
        }
    }
}
