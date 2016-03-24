using System;
using System.Collections.Generic;
using System.Linq;


class JoinLists
{
    static void Main()
    {
        List<string> firstListOfNumbers = new List<string>();

        firstListOfNumbers.AddRange(Console.ReadLine().Split(' '));

        List<string> secondListOfNumbers = new List<string>();

        secondListOfNumbers.AddRange(Console.ReadLine().Split(' '));


        List<Int32> firstListInt = firstListOfNumbers.Select(Int32.Parse).ToList();

        List<Int32> secondListInt = secondListOfNumbers.Select(Int32.Parse).ToList();

        List<Int32> unionList = firstListInt.Union(secondListInt).ToList();

        unionList.Sort();
        Console.WriteLine("Result:");
        foreach (var item in unionList)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
