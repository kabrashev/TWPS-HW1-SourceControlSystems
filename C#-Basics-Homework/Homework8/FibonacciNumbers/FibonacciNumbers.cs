using System;

class FibonacciNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        if (n < 0)
        {
            Console.WriteLine("Incorrect data!");
            return;
        }
        if (n == 0)
        {
            Console.WriteLine("The 0-th fibonacci number is: 0");
            return;
        }

        Console.WriteLine("The {0}-th fibonacci number is: {1}", n, Fib(n));
    }

    public static int Fib(int n)
    {
        int fibA = 0;
        int fibB = 1;
        int fibC = 0;

        for (int i = 1; i <= n; i++)
        {
            fibC = fibA + fibB;
            fibA = fibB;
            fibB = fibC;

        }
        return fibC;
    }
}