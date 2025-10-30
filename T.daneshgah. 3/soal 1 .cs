using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number (1 to 7): ");
        int number = int.Parse(Console.ReadLine());

        switch (number)
        {
            case 1:
                Console.WriteLine("Saturday");
                break;
            case 2:
                Console.WriteLine("Sunday");
                break;
            case 3:
                Console.WriteLine("Monday");
                break;
            case 4:
                Console.WriteLine("Tuesday");
                break;
            case 5:
                Console.WriteLine("Wednesday");
                break;
            case 6:
                Console.WriteLine("Thursday");
                break;
            case 7:
                Console.WriteLine("Friday");
                break;
            default:
                Console.WriteLine("END");
                break;
        }
    }
}

