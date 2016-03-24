using System;

class OddAndEvenProduct
{
    static void Main()
    {
        Console.WriteLine("Enter integer numbers with space between them:");
        string[] numbers = Console.ReadLine().Split();
        int sumOdd = 1;
        int sumEven = 1;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (i % 2 == 0)
            {
                sumOdd = sumOdd * Convert.ToInt32(numbers[i]);
            }
            else
            {
                sumEven = sumEven * Convert.ToInt32(numbers[i]);
            }
        }
        Console.WriteLine("\nResult:");
        if (sumOdd == sumEven)
        {
            Console.WriteLine("yes");
            Console.WriteLine("product = {0}", sumOdd);
        }
        else
        {
            Console.WriteLine("no");
            Console.WriteLine("odd_product = {0}\neven_product = {1}", sumOdd, sumEven);
        }

    }
}
