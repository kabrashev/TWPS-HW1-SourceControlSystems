using System;

class ThirdDigitIs7
{
    static void Main()
    {
        Console.WriteLine("Enter integer number:");
        int a = int.Parse(Console.ReadLine());
        int b = a / 100;
        bool isSeven = ((b % 10) == 7);

        Console.WriteLine("Third digit is 7? - {0}", isSeven);

    }
}
