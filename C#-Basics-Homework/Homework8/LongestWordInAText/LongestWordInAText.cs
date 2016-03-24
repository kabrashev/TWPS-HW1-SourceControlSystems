using System;

class LongestWordInAText
{
    static void Main()
    {
        Console.WriteLine("Enter text:");
        char[] chars = new char[] { ' ', '.' };
        string[] data = Console.ReadLine().Split(chars);
        Array.Sort(data, (x1, x2) => x1.Length.CompareTo(x2.Length));
        Console.WriteLine("The longest word in the text is: \"{0}\"", data[data.Length - 1]);
    }
}
