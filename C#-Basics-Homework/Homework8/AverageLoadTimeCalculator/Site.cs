using System.Collections.Generic;
using System;

public class Site
{
    public List<DateTime> date = new List<DateTime>();
    public string url = "";
    private double totalLoadTime = 0;
    private int count = 0;

    public Site(string url)
    {
        this.url = url;
    }

    public double AverageLoadTime
    {
        get
        {
            return this.totalLoadTime / count;
        }
    }

    public void PrintInfo()
    {
        Console.WriteLine("{0} -> {1}", this.url, this.AverageLoadTime);
    }


    public void GetDateTime(string dateAsString)
    {
        this.date.Add(DateTime.Parse(dateAsString));
    }

    public void SumLoadTime(double loadTime)
    {
        this.totalLoadTime += loadTime;
        this.count++;
    }
}