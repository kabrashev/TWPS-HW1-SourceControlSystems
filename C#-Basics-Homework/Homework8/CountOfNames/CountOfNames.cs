using System;
using System.Collections.Generic;

class CountOfNames
{
    static void Main()
    {
        Console.WriteLine("Input names:");
        string line = Console.ReadLine();
        string[] list = line.Split(' ');

        List<string> nonDuplicate = new List<string> { };

        foreach (string letter in list)
        {
            if (!nonDuplicate.Contains(letter))
            {
                nonDuplicate.Add(letter);
            }
        }
        nonDuplicate.Sort();

        Dictionary<string, int> dict = new Dictionary<string, int> { };

        foreach (string letter in nonDuplicate)
        {
            dict[letter] = 0;
        }
        foreach (string letter in list)
        {
            dict[letter]++;
        }
        Console.WriteLine("Output:");
        foreach (string letter in dict.Keys)
        {
            Console.WriteLine("{0} -> {1}", letter, dict[letter]);
        }

    }
}
