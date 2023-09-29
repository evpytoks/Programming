using System;
class Program
{
    static void Main()
    {
        do 
        {   
            // ВВодим N.
            Console.WriteLine("Введите натуральное число N:");
            string n_str;
            n_str = Console.ReadLine();
            int n;
            bool f1 = int.TryParse(n_str, out n);
            // Вводим A.
            Console.WriteLine("Введите вещественное число A:");
            string a_str;
            a_str = Console.ReadLine();
            double a;
            bool f2 = double.TryParse(a_str, out a);
            // Проверяем на корректность ввода.
            if (f1 && f2)
            {
                double summ = 0, product = 1;
                for (int i = 1; i <= n; ++i)
                {
                    product *= (a - (double)i);
                    double mul = 1;
                    // Считаем степень A.
                    for (int j = 0; j < i; ++j)
                    {
                        mul *= a;
                    }
                    summ += (1 / mul);
                }
                Console.WriteLine(summ);
                Console.WriteLine(product);
            }
            else
            {
                Console.WriteLine("Ошибка.");
            }
            Console.WriteLine("Для выхода из программы нажмите esc, иначе любую другую клавишу");
        } while (Console.ReadKey().Key != ConsoleKey.Escape);
    }
}
