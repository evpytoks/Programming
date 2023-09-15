using System;
class Program
{
    static void Main() 
    {
        string r_str = Console.ReadLine();
        double r;
        bool f1 = double.TryParse(r_str, out r);
        if (f1) 
        {
            Console.WriteLine("Введите координаты точки, которую хотите проверить. Для завершения введите stop.");
            string x_str, y_str;
            x_str = Console.ReadLine();
            if (x_str != "stop")
            {
                y_str = Console.ReadLine();
                while (y_str != "stop") 
                {
                    double x, y;
                    bool f2 = double.TryParse(x_str, out x);
                    bool f3 = double.TryParse(y_str, out y);
                    Console.WriteLine($"{x}");
                    if (f3 && f2) 
                    {
                        double dist = Math.Sqrt(x * x + y * y);
                        if (dist <= r) 
                        {
                            Console.WriteLine("Точка внутри круга!");
                        }
                         else 
                        {
                            Console.WriteLine("Точка вне круга!");
                        }
                    }
                    else 
                    {
                        Console.WriteLine("ошибка");
                    }
                    x_str = Console.ReadLine();
                    if (x_str == "stop")
                    {
                        break;
                    }
                    y_str = Console.ReadLine();
                }
            }
            
        } 
        else 
        {
            Console.WriteLine("Ошибка");
        }

    }
}