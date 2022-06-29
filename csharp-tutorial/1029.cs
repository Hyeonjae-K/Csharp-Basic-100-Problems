using System;

class Program
{
    static void Main()
    {
        double d = double.Parse(Console.ReadLine());
        Console.WriteLine(String.Format("{0:F11}", d));
    }
}