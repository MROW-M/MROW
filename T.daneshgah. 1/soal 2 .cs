using System;

class Program
{
    static void Main()
    {
        // Get temperature in Celsius
        Console.Write("Please enter the temperature in Celsius: ");
        string input = Console.ReadLine();
        double celsius = Convert.ToDouble(input);

        // Convert Celsius to Fahrenheit
        double fahrenheit = (celsius * 9 / 5) + 32;

        // Display the result
        Console.WriteLine("Equivalent temperature in Fahrenheit: " + fahrenheit);
    }
}
