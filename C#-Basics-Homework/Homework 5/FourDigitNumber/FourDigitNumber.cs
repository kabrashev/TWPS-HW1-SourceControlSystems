using System;

class FourDigitNumber
{
    static void Main()
    {
        Console.WriteLine("Enter four-digit number number:");
        int number = int.Parse(Console.ReadLine());
        int a = ((number / 1000) % 10);
        int b = ((number / 100) % 10);
        int c = ((number / 10) % 10);
        int d = (number % 10);

        if ((number <= 9999) && (number >= 1000))
        {
            int sum = a + b + c + d;

            Console.WriteLine("Sum of the digits {0}+{1}+{2}+{3} = {4}", a, b, c, d, sum);
            Console.WriteLine("Reversed: {0}{1}{2}{3}", d, c, b, a);
            Console.WriteLine("Last digit in front: {0}{1}{2}{3}", d, a, b, c);
            Console.WriteLine("Second and third digits exchanged: {0}{1}{2}{3}", a, c, b, d);
        }

        else
        {
            Console.WriteLine("Number is not four-digit!");
        }

    }
}

