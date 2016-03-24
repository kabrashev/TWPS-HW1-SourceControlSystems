using System;

class CalculateNFactDevKFact
{
    static void Main()
    {
        Console.WriteLine("Enter n:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter k:");
        int k = int.Parse(Console.ReadLine());

        if ((k < n) && (k > 1) && (n < 100))
        {
            int nDevK = 1;

            while (k < n)
            {
                k++;
                nDevK = nDevK * k;

            }

            Console.WriteLine("n!/k! = {0}", nDevK);
        }
        else
        {
            Console.WriteLine("Incorrect data ! -> Range: 100 > n > k > 0");
        }

    }
}
