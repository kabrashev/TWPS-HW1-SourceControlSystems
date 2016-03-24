using System;


class PrintNames
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your first name:");
        String firstName = Console.ReadLine();
        Console.WriteLine("Enter your family:");
        String family = Console.ReadLine();
        Console.WriteLine("My first name is: " + firstName);
        Console.WriteLine("My last name is: " + family);
    }
}
