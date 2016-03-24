using System;

class GravitationOnTheMoon
{
    static void Main()
    {
        Console.WriteLine("Enter weight on the Earth:");
        double weightEarth = double.Parse(Console.ReadLine());
        if (weightEarth >= 0)
        {
            double weightMoon = weightEarth * 0.17;
            Console.WriteLine("The weight of a man on the moon is: {0}", weightMoon);
        }
        else
        {
            Console.WriteLine("Weight can not be negative!");
        }

    }
}
