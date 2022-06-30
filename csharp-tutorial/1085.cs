using System;

class Program
{
    static void Main()
    {
        var data = Console.ReadLine().Split();
        double h = double.Parse(data[0]);
        double b = double.Parse(data[1]);
        double c = double.Parse(data[2]);
        double s = double.Parse(data[3]);
        double size_bit = h * b * c * s;
        Console.WriteLine("{0} MB", (size_bit / (8 * 1024 * 1024)).ToString("F1"));
    }
}