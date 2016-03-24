using System;

class MinMaxSumAndAverageOfNNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter n:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number1: ");
        int firstNumber = int.Parse(Console.ReadLine());
        int max = firstNumber;
        int min = firstNumber;
        int sum = firstNumber;
        for (int i = 2; i <= n; i++)
        {
            Console.WriteLine("Enter number{0}: ", i);
            int nextNumber = int.Parse(Console.ReadLine());
            if (nextNumber > max)
            {
                max = nextNumber;
            }
            if (nextNumber < min)
            {
                min = nextNumber;
            }
            sum = sum + nextNumber;
        }

        double avg = (double)sum / n;

        Console.WriteLine("max = {0}", max);
        Console.WriteLine("min = {0}", min);
        Console.WriteLine("sum = {0}", sum);
        Console.WriteLine("avg = {0:F2}", avg);

    }
}
