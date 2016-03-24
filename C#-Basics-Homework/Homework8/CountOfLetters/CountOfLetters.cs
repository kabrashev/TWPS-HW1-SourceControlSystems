using System;
using System.Collections.Generic;

class CountOfLetters
{
    static void Main()
    {
        Console.WriteLine("Input:");
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
        foreach (string letter in dict.Keys)
        {
            Console.WriteLine("Output:{0} -> {1}", letter, dict[letter]);
        }
    }
}
