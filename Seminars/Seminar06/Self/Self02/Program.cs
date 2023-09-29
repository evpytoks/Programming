using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("A B C F");
        // Перебираем А.
        for (int a = 0; a < 2; ++a)
        {
            // Перебираем B.
            for (int b = 0; b < 2; ++b)
            {
                // Перебираем С.
                for (int c = 0; c < 2; ++c)
                {
                    // Выводим строку таблицы.
                    Console.WriteLine($"{a} {b} {c} {((a | (b & c) + 1) % 2) | a}");
                }
            }
        }
    }
}