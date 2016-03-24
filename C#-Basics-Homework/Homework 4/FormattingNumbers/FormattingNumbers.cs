using System;

class FormattingNumbers
{
    static void Main()
    {
        int a;
        double b;
        double c;
        Console.Write("Enter an integer a = ");
        a = int.Parse(Console.ReadLine());
        if (a >= 0 && a <= 500)
        {
            Console.Write("Enter floating-point b = ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Enter floating-point c = ");
            c = double.Parse(Console.ReadLine());

            string aToString = Convert.ToString(a, 2);
            Console.WriteLine("|{0,-10:X}|{1}|{2,10:0.00}|{3,-10:0.000}|", a, aToString.PadLeft(10, '0'), b, c);
        }
        else
        {
            Console.WriteLine("Invalid number!");
        }
    }
}
