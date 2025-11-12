using System;

class Triangle
{
    private double a, b, c;

    // Constructor
    public Triangle(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    // Method to calculate perimeter
    public double Perimeter()
    {
        return a + b + c;
    }

    // Method to calculate area using Heron's formula
    public double Area()
    {
        double s = Perimeter() / 2; // semi-perimeter
        double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        return area;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter side a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter side b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter side c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        Triangle triangle = new Triangle(a, b, c);

        Console.WriteLine($"Perimeter of the triangle: {triangle.Perimeter()}");
        Console.WriteLine($"Area of the triangle: {triangle.Area()}");
    }
}

