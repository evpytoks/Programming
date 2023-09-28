using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите натуральное число:");
        string num = Console.ReadLine();
        string answer = "";
        // Переворот числа.
        for (int i = 0; i < num.Length; ++i) 
        {   
            answer = num[i] + answer;
        }
        // Находим первый не ноль.
        int ind = 0;
        while (answer[ind] == '0')
        {
            ++ind;
        }
        // Вывод ответа.
        for (int i = ind; i < answer.Length; ++i)
        {
            Console.Write(answer[i]);
        }
    }
}