using System;

class DecimalToHexadecimalNumber
{
    static void Main()
    {
        Console.WriteLine("Enter decimal number:");
        long integerNumber = long.Parse(Console.ReadLine());
        string finalHexadecimal = "";
        string hexaDigit = "";

        do
        {
            long hexadecimal = integerNumber % 16;
            integerNumber = integerNumber / 16;

            if (hexadecimal == 10)
            {
                hexaDigit = "A";
            }
            if (hexadecimal == 11)
            {
                hexaDigit = "B";
            }
            if (hexadecimal == 12)
            {
                hexaDigit = "C";
            }
            if (hexadecimal == 13)
            {
                hexaDigit = "D";
            }
            if (hexadecimal == 14)
            {
                hexaDigit = "E";
            }
            if (hexadecimal == 15)
            {
                hexaDigit = "F";
            }
            if ((hexadecimal < 10) && (hexadecimal > 0))
            {
                hexaDigit = hexadecimal.ToString();
            }
            if (hexadecimal == 0)
            {
                hexaDigit = hexadecimal.ToString();
            }

            finalHexadecimal = hexaDigit + finalHexadecimal;

        } while (integerNumber != 0);
            Console.WriteLine("Hexadecimal: {0}", finalHexadecimal);
    }
}
