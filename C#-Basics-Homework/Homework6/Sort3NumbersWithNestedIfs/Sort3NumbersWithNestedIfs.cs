using System;

class Sort3NumbersWithNestedIfs
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
            if (b >= c)
            {
                string desc = a.ToString() + " " + b.ToString() + " " + c.ToString();
                Console.WriteLine("The result is: {0}", desc);
            }
            if (c > b)
            {
                string desc = a.ToString() + " " + c.ToString() + " " + b.ToString();
                Console.WriteLine("The result is: {0}", desc);
            }
        }

        if (a <= b && a <= c)
        {
            if (b > c)
            {
                string desc = b.ToString() + " " + c.ToString() + " " + a.ToString();
                Console.WriteLine("The result is: {0}", desc);
            }
            if (c > b)
            {
                string desc = c.ToString() + " " + b.ToString() + " " + a.ToString();
                Console.WriteLine("The result is: {0}", desc);
            }
        }

        if (a > b && a < c)
        {
            string desc = c.ToString() + " " + a.ToString() + " " + b.ToString();
            Console.WriteLine("The result is: {0}", desc);
        }

    }
}
