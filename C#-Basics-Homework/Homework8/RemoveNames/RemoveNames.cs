using System;

class RemoveNames
{
    static void Main()
    {
        Console.WriteLine("Input:");
        string firstStr = Console.ReadLine();
        string secondStr = Console.ReadLine();
        string[] stringArray2 = secondStr.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        string[] stringArray1 = firstStr.Split(stringArray2, StringSplitOptions.RemoveEmptyEntries);

        Console.WriteLine("Output:");
        foreach (var item in stringArray1)
        {
            string[] stringArrayEmpty = item.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var item2 in stringArrayEmpty)
                Console.Write(item2 + " ");
        }
        Console.WriteLine();
    }
}
