using System;

class RandomNumbersInGivenRange
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter min: ");
        int min = int.Parse(Console.ReadLine());
        Console.Write("Enter max: ");
        int max = int.Parse(Console.ReadLine());   

        if (min < max)
        {
            Random randNum = new Random();
            for (int i = 1; i <= n; i++)
            {
                Console.Write("{0} ", randNum.Next(min, max + 1));
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Incorrect data!");
        }
    }
}
