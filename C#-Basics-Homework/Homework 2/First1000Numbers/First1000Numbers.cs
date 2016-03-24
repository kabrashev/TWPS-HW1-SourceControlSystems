using System;


class First1000Numbers
{
    static void Main(string[] args)
    {
        Console.WriteLine("The first 1000 members of the sequence:");
        int n = 1000;
        for (int i = 2; i <= n + 1; i++)
        {

            if (i % 2 == 0)
            {
                Console.Write(i + ", ");
            }
            else
            {
                Console.Write(-i + ", ");
            }
        }

    }
}