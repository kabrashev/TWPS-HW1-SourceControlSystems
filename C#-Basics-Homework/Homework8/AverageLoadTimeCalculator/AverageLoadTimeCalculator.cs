using System.Collections.Generic;

class AverageLoadTimeCalculator
{
    static void Main()
    {
        string[] inputStrings =
            {
                "2014-Mar-02 11:33 http://softuni.bg 8.37725",
                "2014-Mar-02 11:34 http://www.google.com 1.335",
                "2014-Mar-03 21:03 http://softuni.bg 7.25",
                "2014-Mar-03 22:00 http://www.google.com 2.44",
                "2014-Mar-03 22:01 http://www.google.com 2.45",
                "2014-Mar-03 22:01 http://www.google.com 2.77"
            };

        var sites = new List<Site>();

        foreach (var str in inputStrings)
        {
            string[] inputData = str.Split(' ');

            if (!sites.Exists(s => s.url == inputData[2]))
            {
                sites.Add(new Site(inputData[2]));
            }

            var site = sites.Find(s => s.url == inputData[2]);
            site.GetDateTime(inputData[0] + " " + inputData[1]);
            site.SumLoadTime(double.Parse(inputData[3]));
        }

        foreach (var item in sites)
        {
            item.PrintInfo();
        }
    }
}
