using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Letter E:");
        for (int i = 0; i < 5; i++)
        {
            if (i == 0 || i == 2 || i == 4)
                Console.WriteLine("#####");
            else
                Console.WriteLine("#");
        }

        Console.WriteLine("\nLetter H:");
        for (int i = 0; i < 5; i++)
        {
            if (i == 2)
                Console.WriteLine("#####");
            else
                Console.WriteLine("#   #");
        }

        Console.WriteLine("\nLetter I:");
        for (int i = 0; i < 5; i++)
        {
            if (i == 0 || i == 4)
                Console.WriteLine("#####");
            else
                Console.WriteLine("  #  ");
        }
    }
}
