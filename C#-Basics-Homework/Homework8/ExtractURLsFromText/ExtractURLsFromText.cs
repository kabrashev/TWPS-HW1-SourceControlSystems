using System;
using System.Linq;

class ExtractURLsFromText
{
    static void Main()
    {
        Console.WriteLine("Enter text:");
        string text = Console.ReadLine();
        var links = text.Split("\t\n ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Where(s => s.StartsWith("http://") || s.StartsWith("www."));

        Console.WriteLine("\nExtracted URLs:");
        foreach (string s in links)
        {
            Console.WriteLine(s);
        }
    }
}
