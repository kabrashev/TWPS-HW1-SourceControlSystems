using System;

class MultiplicationSign
{
    static void Main()
    {
        Console.WriteLine("Enter number a:");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter number b:");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter number c:");
        double c = double.Parse(Console.ReadLine());
        int num = 0;

        if (a == 0 || b == 0 || c == 0)
        {
            Console.WriteLine("The result is: 0");
        }
        else
        {
            if (a < 0)
            {
                num++;
            }
            if (b < 0)
            {
                num++;
            }
            if (c < 0)
            {
                num++;
            }
            if ((num == 3) || (num == 1))
            {
                Console.WriteLine("The result is: -");
            }
            if ((num == 0) || (num == 2))
            {
                Console.WriteLine("The result is: +");
            }
        }

    }
}