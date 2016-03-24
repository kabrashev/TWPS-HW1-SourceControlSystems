using System;

class PointInsideCircleOutsideRectangle
{
    static void Main()
    {
        Console.WriteLine("Enter x: ");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter y: ");
        double y = double.Parse(Console.ReadLine());
        double z = Math.Sqrt(Math.Pow(x - 1, 2) + Math.Pow(y - 1, 2));

        if ((y > 1) && (z <= 1.5))
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}
