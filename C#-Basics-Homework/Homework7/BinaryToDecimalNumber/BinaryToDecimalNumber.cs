using System;

class BinaryToDecimalNumber
{
    static void Main()
    {
        Console.WriteLine("Enter binary number:");
        string binNum = Console.ReadLine();
        int[] number = new int[binNum.Length];
        long decNum = 0;
        long length = binNum.Length - 1;
        for (int i = 0; i < binNum.Length; i++)
        {
            char ch = binNum[i];
            number[i] = Convert.ToInt32(ch.ToString());
            decNum = decNum + number[i] * (long)Math.Pow(2, length);
            length--;
        }
        Console.WriteLine("Decimal: {0}", decNum);
    }
}
