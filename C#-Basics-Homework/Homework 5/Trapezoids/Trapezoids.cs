using System;

class Trapezoids
{
    static void Main()
    {
        Console.WriteLine("Enter side a:");
        double sideA = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter side b:");
        double sideB = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter height h:");
        double height = double.Parse(Console.ReadLine());
        if (sideA >= 0 && sideB >= 0 && height >= 0)
        {
            double area = (sideA + sideB) * height / 2;
            Console.WriteLine("The area is: {0}", area);
        }
        else
        {
            Console.WriteLine("Sides of trapezoids can not be negative!");
        }
    }
}
