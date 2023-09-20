using System;
class Program
{
    static void Main()
    {
        string symbol = Console.ReadLine();
        switch(symbol[0])
        {
            case not 'A' when Char.IsDigit(symbol[0]):
                Console.WriteLine("100");
                break;
            case not '1' when Char.IsLetter(symbol[0]) && Char.IsUpper(symbol[0]):
                Console.WriteLine("200");
                break;
            case not '1' when Char.IsLetter(symbol[0]) && Char.IsLower(symbol[0]):
                Console.WriteLine("300");
                break;
            default:
                Console.WriteLine("400");
                break;
        }
    }
}