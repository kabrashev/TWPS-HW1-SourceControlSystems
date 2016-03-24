using System;
using System.Collections.Generic;

class SortingNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter n:");
        int n = int.Parse(Console.ReadLine());

        List<int> numbers = new List<int>();
        Console.WriteLine("Enter {0} numbers:", n);
        for (int i = 0; i < n; i++)
        {
            int a = int.Parse(Console.ReadLine());
            numbers.Add(a);
        }

        numbers.Sort();
        Console.WriteLine("Output:");
        for (int i = 0; i<n; i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }
}
