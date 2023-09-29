using System;
class Program
{
    static void Main()
    {
        int cnt = 0;
        // Перебираем отрезок.
        for (int i = 2000; i <= 3000; ++i)
        {
            string str_num = i.ToString();
            bool f = true;
            // Проверка на то, что цифры попарно различны.
            for (int ind1  = 0; ind1 < 4; ++ind1)
            {
                for (int ind2 = ind1 + 1; ind2 < 4; ++ind2)
                {
                    if (str_num[ind1] == str_num[ind2])
                    {
                        f = false;
                    }
                }
            }
            if (f)
            {
                Console.WriteLine(str_num);
                ++cnt;
            }
        }
        Console.WriteLine(cnt);
    }
}