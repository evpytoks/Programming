using System;
class Program
{
    static void Main ()
    {
        string s = Console.ReadLine();
        string num1_s = "",num2_s = "";
        char operation;
        int i = 0;
        // Отделяем первое число.
        while (s[i] != ' ')
        {
            num1_s += s[i];
            i += 1;
        }
        i += 1;
        operation = s[i];
        i += 2;
        // Проверяем, что после операции стоит пробел.
        if (s[i - 1] != ' ') 
        {
            Console.WriteLine("Error");
        }
        else
        {   
            // Отделяем второе число.
            while (i < s.Length)
            {
                num2_s += s[i];
                i += 1;
            }
            bool f1, f2;
            double num1, num2;
            f1 = double.TryParse(num1_s, out num1);
            f2 = double.TryParse(num2_s, out num2);
            // Проверяем, что введенные числа корректны.
            if (f1 && f2)
            {
                // Проверяем операцию и выводим ответ.
                switch(operation)
                {
                    case '+':
                        Console.WriteLine(num1 + num2);
                        break;
                    case '-':
                        Console.WriteLine(num1 - num2);
                        break;
                    case '*':
                        Console.WriteLine(num1 * num2);
                        break;
                    case '/':
                        Console.WriteLine(num1 / num2);
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }
            }
            else 
            {
                Console.WriteLine("Error");
            }
        }
    }
}