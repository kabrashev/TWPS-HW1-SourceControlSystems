using System;

class ModifyABitAtGivenPosition
{
    static void Main()
    {
        Console.WriteLine("Enter integer number n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter position p: ");
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value v: ");
        int v = int.Parse(Console.ReadLine());
        int c = 1 << p;

        if (v == 1)
        {
            int result1 = n | c;
            Console.WriteLine("The result is: {0}", result1);
        }

        else
        {
            int result2 = n & (~c);
            Console.WriteLine("The result is: {0}", result2);
        }
    }
}
