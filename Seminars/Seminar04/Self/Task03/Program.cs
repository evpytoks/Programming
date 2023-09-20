using System;
class Program
{
    static void Main()
    {
        string num_str, num1_str, num2_str;
        int num;
        bool f;
        do
        {
            Console.WriteLine("Введте код операции (число от 1 до 4) :");
            num_str = Console.ReadLine();
            f = int.TryParse(num_str, out num);
        }
        while (!f);
        double num1, num2;
        do
        {
            Console.WriteLine("Введите вещетсвенное число А:");
            num1_str = Console.ReadLine();
            f = double.TryParse(num1_str, out num1);
        }
        while (!f);
        do
        {
            Console.WriteLine("Введите вещетсвенное число B:");
            num2_str = Console.ReadLine();
            f = double.TryParse(num2_str, out num2);
        }
        while (!f);
        switch(num)
        {
            case 1:
                Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                break;
            case 2:
                Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                break;
            case 3:
                Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                break;
            case 4:
                Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                break;
            default:
                Console.WriteLine("Операции не существует.");
                break;
        }
    } 
}