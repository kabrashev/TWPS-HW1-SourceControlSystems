﻿using System;

class MatrixOfNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter n:");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {

            for (int j = i; j <= i + n - 1; j++)
            {
                Console.Write("{0} ", j);
            }
            Console.WriteLine();
        }
    }
}
