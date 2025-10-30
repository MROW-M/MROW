
using System;

namespace CircleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read the radius from user input
            Console.Write("Enter the radius of the circle: ");

            // Read input and convert to double
            double r = Convert.ToDouble(Console.ReadLine());

            // Calculate circumference and area
            double circumference = 2 * Math.PI * r;
            double area = Math.PI * r * r;

            // Display the results
            Console.WriteLine("Circumference = " + circumference);
            Console.WriteLine("Area = " + area);
        }
    }
}
