using System;
class Program
{
    static void Main()
    {
        string str_x = Console.ReadLine();
        string str_y = Console.ReadLine();
        string str_z = Console.ReadLine();
        int x = int.Parse(str_x);
        int y = int.Parse(str_y);
        int z = int.Parse(str_z);
        int small = x <= y ? (x <= z ? x : z) : (y <= z ? y : z);
        int big = x >= y ? (x >= z ? x : z) : (y >= z ? y : z);
        int medium = x + y + z - small - big;
        Console.WriteLine($"{small}");
        Console.WriteLine($"{medium}");
        Console.WriteLine($"{big}");
    }
}