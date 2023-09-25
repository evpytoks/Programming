using System;
class Program 
{
    static void Main()
    {
        int num_of_int = 0;
        int num_of_double = 0;
        int num_of_not_num = 0;
        string input;
        // Основной цикл ввода.
        do
        {
            input = Console.ReadLine();
            int num;
            double num2;
            // Проверка на тип введенных данных.
            bool f;
            f = double.TryParse(input, out num2);
            if (f)
            {
                ++num_of_double;
                f = int.TryParse(input, out num);
                if (f)
                {
                    ++num_of_int;
                }
            } else
            {
                // Проверка на содержание цифр в строке.
                int ind = 0;
                bool f2 = true;
                while (ind < input.Length)
                {
                    if (char.IsDigit(input[ind]))
                    {
                        f2 = false;
                        break;
                    }
                    ++ind;
                }
                if (f2)
                {
                    ++num_of_not_num;
                }
            }
        }
        while (input != "0");
        Console.WriteLine($"{num_of_int} - количество введённых целых чисел, удовлетворяющих типу int");
        Console.WriteLine($"{num_of_double} -  количество введённых вещественных чисел, удовлетворяющих типу double");
        Console.WriteLine($"{num_of_not_num} -  количество введённых нечисловых значений");
    }
}