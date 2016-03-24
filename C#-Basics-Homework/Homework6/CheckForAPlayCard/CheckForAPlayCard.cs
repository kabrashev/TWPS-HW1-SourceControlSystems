using System;

class CheckForAPlayCard
{
    static void Main()
    {
        Console.WriteLine("Enter character:");
        string a = Console.ReadLine();

        if ((a == "2") || (a == "3") || (a == "4") || (a == "5") || (a == "6") || (a == "7") || (a == "8") || (a == "9") || (a == "10") || (a == "J") || (a == "Q") || (a == "K") || (a == "A"))
        {
            Console.WriteLine("Valid card sign? - yes");
        }
        else
        {
            Console.WriteLine("Valid card sign? - no");
        }
    }
}
