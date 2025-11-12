using System;

class Program
{
    // Recursive function to multiply two integers
    static int Multiply(int a, int b)
    {
        // Base case: if one number is zero
        if (b == 0)
            return 0;

        // If b is negative, handle sign
        if (b < 0)
            return -Multiply(a, -b);

        // Recursive case: a + (a * (b - 1))
        return a + Multiply(a, b - 1);
    }

    static void Main()
    {
        Console.Write("Enter first number (a): ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number (b): ");
        int b = Convert.ToInt32(Console.ReadLine());

        int result = Multiply(a, b);

        Console.WriteLine($"Multiplication of {a} and {b} = {result}");
    }
}
