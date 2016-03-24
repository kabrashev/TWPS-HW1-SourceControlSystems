using System;

class NumberComparer
{
    static void Main()
    {
        double a;
        double b;
        Console.Write("a = ");
        bool isaDouble = double.TryParse(Console.ReadLine(), out a);
        Console.Write("b = ");
        bool isbDouble = double.TryParse(Console.ReadLine(), out b);
        

        bool greaterNum = a > b;

        if (isaDouble)
        {
            Console.WriteLine("a is greater than b: {0}", greaterNum);
            Console.WriteLine("Max number is: {0}", Math.Max(a, b));
        }

        else
        {
            Console.WriteLine("Please enter valid number!");
        }
    }
}
