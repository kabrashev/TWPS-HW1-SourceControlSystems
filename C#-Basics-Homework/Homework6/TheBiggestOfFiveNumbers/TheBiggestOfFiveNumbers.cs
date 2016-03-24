using System;

class TheBiggestOfFiveNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter number a:");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter number b:");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter number c:");
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter number d:");
        double d = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter number e:");
        double e = double.Parse(Console.ReadLine());

        if (a >= b && a >= c && a >= d && a >= e)
        {
            Console.WriteLine("The biggest number is: {0}", a);
        }
        if (b > a && b >= c && b >= d && b >= e)
        {
            Console.WriteLine("The biggest number is: {0}", b);
        }
        if (c > a && c > b && c >= d && c >= e)
        {
            Console.WriteLine("The biggest number is: {0}", c);
        }
        if (d > a && d > b && d > c && d >= e)
        {
            Console.WriteLine("The biggest number is: {0}", d);
        }
        if (e > a && e > b && e > c && e > d)
        {
            Console.WriteLine("The biggest number is: {0}", e);
        }

    }
}
