using System;

class Calculate
{
    static void Main()
    {
        Console.WriteLine("Enter n:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter x:");
        int x = int.Parse(Console.ReadLine());

        double result = 0;
        int fact = 1;
        int pow = x;
        for (int i = 2; i <= n; i++)
        {
            fact = fact * i;
            pow = pow * x;
            result = result + (double)fact / pow;
        }
        result = 1 + 1 / (double)x + result;
        Console.WriteLine("S = {0:F5}", result);

    }
}
