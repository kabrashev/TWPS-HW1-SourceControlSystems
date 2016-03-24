using System;


class First10Numbers
{
    static void Main(string[] args)
    {
        int n = 10;
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
        Console.WriteLine();
    }
}
