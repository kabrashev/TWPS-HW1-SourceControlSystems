using System;

class BonusScore
{
    static void Main()
    {
        Console.WriteLine("Enter score:");
        int a = int.Parse(Console.ReadLine());

        if ((1 <= a) && (a <= 9))
        {
            if ((1 <= a) && (a <= 3))
            {
                Console.WriteLine("The result is: {0}", a * 10);
            }
            if ((4 <= a) && (a <= 6))
            {
                Console.WriteLine("The result is: {0}", a * 100);
            }
            if ((7 <= a) && (a <= 9))
            {
                Console.WriteLine("The result is: {0}", a * 1000);
            }
        }
        else
        {
            Console.WriteLine("invalid score");
        }

    }
}

