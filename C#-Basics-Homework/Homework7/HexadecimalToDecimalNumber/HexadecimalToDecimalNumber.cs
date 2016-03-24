using System;

class HexadecimalToDecimalNumber
{
    static void Main()
    {
        Console.WriteLine("Enter hexadecimal number:");
        string hexNum = Console.ReadLine();
        long decNum = 0;
        long length = hexNum.Length - 1;
        for (int i = 0; i < hexNum.Length; i++)
        {
            char a = hexNum[i];
            string b = a.ToString();
            switch (b)
            {
                case "A":
                    b = "10";
                    break;
                case "B":
                    b = "11";
                    break;
                case "C":
                    b = "12";
                    break;
                case "D":
                    b = "13";
                    break;
                case "E":
                    b = "14";
                    break;
                case "F":
                    b = "15";
                    break;
            }
            decNum = decNum + Convert.ToInt64(b) * (long)Math.Pow(16, length);
            length--;
        }
        Console.WriteLine("Decimal: {0}", decNum);
    }
}
