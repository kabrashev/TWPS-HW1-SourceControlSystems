using System;

class NumbersNotDivisibleBy3And7
{
    static void Main()
    {
        Console.WriteLine("Enter positive integer number n:");
        int number = int.Parse(Console.ReadLine());
        if (number > 0)
        {
            for (int i = 1; i <= number; i++)
            {
                bool isDev = (i % 3 == 0) || (i % 7 == 0);
                if (!isDev)
                    Console.Write("{0} ", i);
            }
        }
        else
        {
            Console.WriteLine("The number is not positive!");
        }
    }
}
