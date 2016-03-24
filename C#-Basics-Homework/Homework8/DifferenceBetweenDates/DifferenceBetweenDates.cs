using System;
using System.Collections.Generic;

class DifferenceBetweenDates
{
    static void Main()
    {
        Console.WriteLine("Enter first date:");
        DateTime firstDate = DateTime.Parse(Console.ReadLine());
        firstDate.ToString("dd.mm.yyyy");

        Console.WriteLine("Enter second date:");
        DateTime secondDate = DateTime.Parse(Console.ReadLine());
        secondDate.ToString("dd.mm.yyyy");

        TimeSpan d = secondDate - firstDate;
        double days = d.TotalDays;

        Console.WriteLine("The difference between dates is {0} days", days);
    }
}
