using System;

class NumbersFrom1ToN
{
    static void Main()
    {
        Console.WriteLine("Enter positive integer number n:");
        int number = int.Parse(Console.ReadLine());
        if (number > 0)
        {
            for (int i = 1; i <= number; i++)
            {
                Console.Write("{0} ", i);
            }
        }
        else
        {
            Console.WriteLine("The number is not positive!");
        }

    }
}
