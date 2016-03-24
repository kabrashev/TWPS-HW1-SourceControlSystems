using System;

class PlayWithIntDoubleAndString
{
    static void Main()
    {
        Console.WriteLine("Please choose a type:\n1 --> int\n2 --> double\n3 --> string");
        int number = int.Parse(Console.ReadLine());


        switch (number)
        {
            case 1:
                Console.WriteLine("Please enter a integer:");
                int integerNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("The result is: {0}", integerNumber + 1);
                break;
            case 2:
                Console.WriteLine("Please enter a double:");
                double doubleNumber = double.Parse(Console.ReadLine());
                Console.WriteLine("The result is: {0}", doubleNumber + 1);
                break;
            case 3:
                Console.WriteLine("Please enter a string:");
                string str = Console.ReadLine();
                Console.WriteLine("The result is: {0}*", str);
                break;

            default:
                Console.WriteLine("Please choose from 1 to 3 !");
                break;
        }

    }
}
