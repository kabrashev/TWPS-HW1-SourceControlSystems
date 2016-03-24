using System;

class CheckABitAtGivenPosition
{
    static void Main()
    {
        Console.WriteLine("Enter integer number n:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the index p:");
        int p = int.Parse(Console.ReadLine());
        int b = n >> p;
        int bit = b & 1;
        bool isOne = (bit == 1);
        Console.WriteLine("The bit #{0} is 1? - {0}", isOne);
    }
}
