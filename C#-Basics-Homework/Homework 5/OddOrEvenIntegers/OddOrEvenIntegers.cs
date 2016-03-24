using System;

class OddOrEvenIntegers
{
    static void Main()
    {
        Console.WriteLine("Enter integer number:");
        int a = int.Parse(Console.ReadLine());
        bool isOdd = (a % 2 != 0);
        Console.WriteLine("The number {0} is odd: {1}", a, isOdd);
    }
}
