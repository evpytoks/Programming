using System;
class Program
{
    static void Main() 
    {
        Console.WriteLine("Введите целое трёхзначное число:");
        string num_str = Console.ReadLine();
        int num;
        bool f = int.TryParse(num_str, out num);
        if (f && ((num_str.Length == 3 && num_str[0] != '-') || (num_str.Length == 4 && num_str[0] == '-'))) //Проверка на корректность ввода
        {
            if (num_str.Length == 3 && num_str[0] != '-')
            {
                Console.WriteLine(num_str[0]);
                Console.WriteLine(num_str[1]);
                Console.WriteLine(num_str[2]);
            }
            else 
            {
                Console.WriteLine(num_str[1]);
                Console.WriteLine(num_str[2]);
                Console.WriteLine(num_str[3]);
            }
        }
        else
        {
            Console.WriteLine("Ошибка");
        }
    }
}
