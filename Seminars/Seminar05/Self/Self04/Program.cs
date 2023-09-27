using System;
class Program
{
    static void Main()
    {
        decimal summ = 0;
        int n = 1;
        // Считаем сумму.
        while (n < 1000000)
        {
            summ += 1 / ((decimal)(n * (n + 1) * (n + 2)));
            ++n;
        }
        Console.WriteLine(summ);
    }
}