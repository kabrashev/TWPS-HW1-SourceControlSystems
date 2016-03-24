using System;

class TheBiggestOf3Numbers
{
    static void Main()
    {
        Console.WriteLine("Enter number a:");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter number b:");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter number c:");
        double c = double.Parse(Console.ReadLine());

        if (a >= b && a >= c)
        {
            Console.WriteLine("The biggest number is: {0}", a);
        }

        if (a < b && a >= c)
        {
            Console.WriteLine("The biggest number is: {0}", b);
        }

        if (a >= b && a < c)
        {
            Console.WriteLine("The biggest number is: {0}", c);
        }

        if (a < b && a < c && b <= c)
        {
            Console.WriteLine("The biggest number is: {0}", c);
        }

        if (a < b && a < c && b > c)
        {
            Console.WriteLine("The biggest number is: {0}", b);
        }

    }
}
