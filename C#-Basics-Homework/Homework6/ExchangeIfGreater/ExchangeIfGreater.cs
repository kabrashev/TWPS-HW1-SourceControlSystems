using System;

class ExchangeIfGreater
{
    static void Main()
    {
        Console.WriteLine("Enter integer a:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter integer b:");
        int b = int.Parse(Console.ReadLine());

        if (a != b)
        {
            if (a < b)
            {
                Console.WriteLine("The result is: {0} {1}", a, b);
            }
            else
            {
                Console.WriteLine("The result is: {0} {1}", b, a);
            }
        }
        else
        {
            Console.WriteLine("a=b !");
        }
    }
}
