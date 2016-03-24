using System;

class PrimeChecker
{
    static void Main()
    {
        Console.WriteLine("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        if ((n == 0) || (n == 1))
        {
            Console.WriteLine("Is prime? -> False");
        }
        else
        {
            Console.WriteLine("Is prime? -> {0}", isPrime(n));
        }
    }
    public static bool isPrime(int n)
    {
        bool isPrime = true;
        int sqrtN = (int)(Math.Sqrt(n));

        for (int i = 2; i <= sqrtN; i++)
        {
            if (n % i == 0)
            {
                isPrime = false;
                return isPrime;
            }
            else
            {
                isPrime = true;
            }
        }
        return isPrime;
    }
}
