using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.Write("Enter coefficient a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter coefficient b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter coefficient c = ");
        double c = double.Parse(Console.ReadLine());

        double d = Math.Sqrt(b * b - 4 * a * c);
        if (d > 0 && a != 0)
        {
            Console.WriteLine("x1={0}; x2={1}", (-b - d) / (2 * a), (-b + d) / (2 * a));
        }
        if (d == 0 && a != 0)
        {
            Console.WriteLine("x1=x2={0}", -b / (2 * a));
        }
        else
        {
            Console.WriteLine("no real roots");
        }

    }
}