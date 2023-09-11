using System;
class Program
{
    static void Main()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear(); // изменён цвет фона
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("Ура, я цветная");   
        }
}
