using System;

class PrimeNumberCheck
{
    static void Main()
    {
        Console.WriteLine("Enter integer number: ");
        uint a = uint.Parse(Console.ReadLine());
        uint divider = 2;
        uint maxDivider = (uint)Math.Sqrt(a);
        bool isPrime = true;

        while (isPrime && (divider <= maxDivider))
        {
            if (a % divider == 0)
            {
                isPrime = false;
            }
            divider++;
        }
        Console.WriteLine("Prime? - {0}", isPrime);
    }
}
