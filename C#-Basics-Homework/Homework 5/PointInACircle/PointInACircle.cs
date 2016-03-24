using System;

class PointInACircle
{
    static void Main()
    {
        Console.WriteLine("Enter x:");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter y:");
        double y = double.Parse(Console.ReadLine());

        double z = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
        bool isInside = (z >= -2) && (z <= 2);

        Console.WriteLine("Inside: {0}", isInside);
    }
}
