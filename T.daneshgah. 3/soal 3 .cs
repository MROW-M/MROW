using System;

class Program
{
    static void Main()
    {
        double number;
        double product = 1;

        Console.WriteLine("Enter numbers (enter 0 to stop):");

        do
        {
            number = double.Parse(Console.ReadLine());

            if (number != 0)
                product *= number;

        } while (number != 0);

        Console.WriteLine("The product of entered numbers is: " + product);
    }
}
