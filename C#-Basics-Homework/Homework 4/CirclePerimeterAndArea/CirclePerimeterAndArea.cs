using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.Write("Enter circle's radius: ");
        double radius = double.Parse(Console.ReadLine());
        double perimeter = 2 * Math.PI * radius;
        double area = Math.PI * Math.Pow(radius, 2);

        Console.WriteLine("The Perimeter of the circle is: {0:F2}", perimeter);
        Console.WriteLine("The Area of the circle is: {0:F2}", area);
    }
}
