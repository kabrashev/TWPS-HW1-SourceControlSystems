using System;
using System.Collections.Generic;

class PrimesInGivenRange
{
    static void Main()
    {
        Console.WriteLine("Enter first number: ");
        int startNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter end number: ");
        int endNumber = int.Parse(Console.ReadLine());
        int counter = 0;
        FindPrimesInRange(startNumber, endNumber, counter);

    }

    static void FindPrimesInRange(int startNum, int endNum, int counter)
    {
        if (startNum > endNum)
        {
            Console.WriteLine("Empty list");
        }

        if (startNum == 0 || startNum == 1)
        {
            startNum = 2;
        }
        
        List<int> numbers = new List<int>();

        for (int i = startNum; i <= endNum; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                if (i % j == 0)
                {
                    counter++;
                }
                if (counter > 2)
                {
                    break;
                }
            }
            if (counter <= 2)
            {
                numbers.Add(i);
            }

            counter = 0;
        }
        foreach (var item in numbers)
        {
            Console.Write(item + " ");
        }
    }
}

