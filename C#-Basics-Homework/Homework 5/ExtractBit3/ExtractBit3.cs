using System;

class ExtractBit3
{
    static void Main()
    {
        Console.WriteLine("Enter integer number n:");
        int n = int.Parse(Console.ReadLine());
        int b = n >> 3;
        int bit = b & 1;
        Console.WriteLine("The bit #3 is: {0}", bit);
    }
}
