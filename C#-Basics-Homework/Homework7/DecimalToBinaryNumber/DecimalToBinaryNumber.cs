using System;

class DecimalToBinaryNumber
{
    static void Main()
    {
        Console.WriteLine("Enter decimal number:");
        long decNum = long.Parse(Console.ReadLine());
        string binNum = "";

        if (decNum > 1)
        {
            while (decNum > 1)
            {
                if (decNum % 2 == 0)
                {
                    binNum = "0" + binNum;
                }
                if (decNum % 2 != 0)
                {
                    binNum = "1" + binNum;
                }

                decNum = decNum / 2;
            }
            binNum = "1" + binNum;
            Console.WriteLine("Binary: {0}", binNum);
        }
        if (decNum == 0)
        {
            binNum = "0";
            Console.WriteLine("Binary: {0}", binNum);
        }
        else
        {
            Console.WriteLine("Incorrect data!");
        }
    }
}
