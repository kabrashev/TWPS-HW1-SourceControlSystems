using System;


class AgeAfter10Years
{
    static void Main(string[] args)
    {
        Console.Write("Enter your birthday in format(DD.MM.YYYY): ");
        DateTime userBirthday = DateTime.Parse(Console.ReadLine());
        long resulut = DateTime.Today.Subtract(userBirthday).Ticks;
        Console.WriteLine("Now: {0}", new DateTime(resulut).Year - 1);
        Console.WriteLine("After 10 years: {0}", new DateTime(resulut).AddYears(10).Year - 1);
    }
}
