using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите натуральное числo k:");
        string k_str;
        k_str = Console.ReadLine();
        // Перевод числа в нужный тип и проверка на корректность данных.
        int k;
        bool f = int.TryParse(k_str, out k);
        if (f)
        {
            // Считаем сумму.
            double summ = 0;
            for (int i = 1; i < k + 1; ++i) 
            {
                summ += 1 / ((double)i);
            }
            Console.WriteLine(summ);
        }
        else 
        {
            Console.WriteLine("Ошибка");
        }
    }
}
