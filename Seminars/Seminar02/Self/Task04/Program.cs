using System;
class Program
{
    static void Main()
    {
        string sym = Console.ReadLine();
        string ans = Char.IsDigit(sym[0]) ? "Это цифра" : (Char.IsLetter(sym[0]) ? "Это буква" : "Это ни буква, ни цифра");
        Console.WriteLine(ans);
    }
}