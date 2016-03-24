using System;

class DivideBy7And5
{
    static void Main()
    {
        Console.WriteLine("Enter integer number:");
        int a = int.Parse(Console.ReadLine());
        bool isDevided = (a % 5 == 0) && (a % 7 == 0);
        Console.WriteLine("Divided by 7 and 5? - {0}", isDevided);
    }
}