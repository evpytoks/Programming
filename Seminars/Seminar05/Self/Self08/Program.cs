using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите натуральное число:");
        string num = Console.ReadLine();
        Console.WriteLine("Введите количество разрядов, которые хотите вывести:");
        string str_k = Console.ReadLine();
        int k;
        bool f = int.TryParse(str_k, out k);
        // Проверка на корректность k.
        if (f && k <= num.Length)
        {
            // Проходимся по k старшим разрядам.
            for (int i = 0; i < k; ++i) {
                Console.Write(num[i]);
            }
        }
        else
        {
            Console.WriteLine("Ошибка.");
        }
        
    }
}