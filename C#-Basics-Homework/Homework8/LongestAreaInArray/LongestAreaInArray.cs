using System;

class LongestAreaInArray
{
    static void Main()
    {
        Console.WriteLine("Input n:");
        int n = int.Parse(Console.ReadLine());
        string[] array = new string[n];

        string lastString = "";
        string longestSeqString = "";
        int longestSequence = 1;
        int currentSequence = 0;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Input {0}-th element:", i + 1);
            array[i] = Console.ReadLine();
            if (lastString == array[i])
            {
                currentSequence++;
                if (currentSequence > longestSequence)
                {
                    longestSequence = currentSequence;
                    longestSeqString = array[i];
                }
            }
            else
            {
                currentSequence = 1;
            }
            lastString = array[i];
        }
        Console.WriteLine("Result:");
        Console.WriteLine(longestSequence);

        for (int i = 1; i <= longestSequence; i++)
        {
            Console.WriteLine(longestSeqString);
        }
    }
}
