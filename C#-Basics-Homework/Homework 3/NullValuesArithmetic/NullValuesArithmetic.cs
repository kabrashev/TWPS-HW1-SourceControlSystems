using System;

class NullValuesArithmetic
{
    static void Main(string[] args)
    {
        int? a = null;
        double? b = null;
        Console.WriteLine("Integer a ={0}\nDouble b = {1}", a, b);
        Console.WriteLine("Integer a + 5 = {0}", a + 5);
        Console.WriteLine("Double b + 5 = {0}", b + 5);
        Console.WriteLine("Integer a + null = {0}", a + null);
        Console.WriteLine("Double b + null = {0}", b + null);
    }
}
