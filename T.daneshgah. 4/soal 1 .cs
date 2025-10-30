using System;

class Program
{
    static void Main()
    {
        int position = -1; // to store the position of number 2 if found
        Console.WriteLine("Enter 5 numbers:");

        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"Number {i}: ");
            int number = int.Parse(Console.ReadLine());

            if (number == 2)
            {
                position = i;
                break; // stop reading if 2 is found
            }
        }

        Console.WriteLine();

        if (position != -1)
            Console.WriteLine($"Number 2 was found at position {position}.");
        else
            Console.WriteLine("Number 2 was not found among the entered numbers.");
    }
}

