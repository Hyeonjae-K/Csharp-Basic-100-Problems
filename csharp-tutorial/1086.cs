using System;

class Program
{
    static void Main()
    {
        var data = Console.ReadLine().Split();
        double w = double.Parse(data[0]);
        double h = double.Parse(data[1]);
        double b = double.Parse(data[2]);
        Console.WriteLine("{0} MB", (w * h * b / (8 * 1024 * 1024)).ToString("F2"));
    }
}