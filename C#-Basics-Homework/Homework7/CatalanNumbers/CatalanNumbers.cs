using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter n:");
        BigInteger n = BigInteger.Parse(Console.ReadLine());

        if ((n > 1) && (n < 100))
        {
            BigInteger factA = 1;
            BigInteger factB = 1;
            for (int i = 1; i <= (n * 2); i++)
            {
                factA = factA * i;
            }

            /* int nPlusOne = n+1;
            for (int i=1; i<=nPlusOne; i++)
            {
                factB = factB * i;
            }
           */

            for (int i = 1; i <= n; i++)
            {
                factB = factB * i;
            }

            BigInteger result = factA / (factB * (n + 1) * factB);
            Console.WriteLine("The {0}-th Catalan number is: {1}", n, result);

        }
        else
        {
            Console.WriteLine("Incorrect data ! -> Range: 100 > n > 1");
        }

    }
}
