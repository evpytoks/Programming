using System;
class Program
{
    static void Main()
    {
        string month_name = Console.ReadLine();
        Console.WriteLine(month_name);
        switch(month_name)
        {
            case "January":
            case "Январь": 
                Console.WriteLine("1"); 
                break;
            case "February":
            case "Февраль": 
                Console.WriteLine("2"); 
                break;
            case "March":
            case "Март":
                Console.WriteLine("3");
                break;
            case "April":
            case "Апрель":
                Console.WriteLine("4");
                break;
            case "May":
            case "Май":
                Console.WriteLine("5");
                break;
            case "June":
            case "Июнь":
                Console.WriteLine("6");
                break;
            case "July":
            case "Июль":
                Console.WriteLine("7");
                break;
            case "August":
            case "Август":
                Console.WriteLine("8");
                break;
            case "September":
            case "Сентябрь":
                Console.WriteLine("9");
                break;
            case "October":
            case "Октябрь":
                Console.WriteLine("10");
                break;
            case "November":
            case "Ноябрь":
                Console.WriteLine("11");
                break;
            case "December":
            case "Декабрь":
                Console.WriteLine("12");
                break;
            default:
                Console.WriteLine("В году такой месяц отсутствует.");
                break;
        }
    }
}