using System;
class Program
{
    static void Main()
    {
        int number = 0;
        while (number <= 50)
        {
            if (number == 20)
            {
                ++number;
                continue;
            }
            if (number % 2 == 0 && number % 3 == 0)
            {
                Console.WriteLine($"Число {number} кратно 2 и 3");
            } 
            else
            {
                Console.WriteLine($"Число {number} не соответсвует условию");
            }
            ++number;
        }
    }
}