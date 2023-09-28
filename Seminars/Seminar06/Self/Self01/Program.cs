using System;
class Program
{
    static void Main()
    {
        int p = -1, q = -1;
        Console.WriteLine("p q f");
        // Изменение p.
        do
        {
        ++p;
        // Изменение q.
        do 
        {
            ++q;
            int f = (((p & q) + 1) % 2) & (((p | ((q + 1) % 2)) + 1) % 2);
            Console.WriteLine($"{p} {q} {f}");
        } while (q != 1);
        q = -1;
        } while (p != 1);
        
    }
}