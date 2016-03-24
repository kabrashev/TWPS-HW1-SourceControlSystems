using System;
using System.Numerics;

class Calculate2
{
    static void Main()
    {
        Console.WriteLine("Enter n:");
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        Console.WriteLine("Enter k:");
        BigInteger k = BigInteger.Parse(Console.ReadLine());

        if ((k < n) && (k > 1) && (n < 100))
        {
            BigInteger nDevK = 1;
            BigInteger nKFact = 1;
            BigInteger b = n - k;

            while (k < n)
            {
                k++;
                nDevK = nDevK * k;
            }

            for (int i = 1; i <= b; i++)
            {
                nKFact = nKFact * i;
            }
            Console.WriteLine("Calculate: {0}", nDevK / nKFact);
        }
        else
        {
            Console.WriteLine("Incorrect data ! -> Range: 100 > n > k > 0");
        }

    }
}
