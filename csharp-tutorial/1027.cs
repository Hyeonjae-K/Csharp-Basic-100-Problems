using System;

class Program
{
    static void Main()
    {
        var data = Console.ReadLine().Split(".");
        int y = int.Parse(data[0]);
        int m = int.Parse(data[1]);
        int d = int.Parse(data[2]);

        Console.WriteLine("{0}-{1}-{2}", d.ToString("D2"), m.ToString("D2"), y.ToString("D4"));
    }
}