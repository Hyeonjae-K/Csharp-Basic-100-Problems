using System;

class Program
{
    static void Main()
    {
        var data = Console.ReadLine().Split();
        int a = int.Parse(data[0]);
        int r = int.Parse(data[1]);
        int n = int.Parse(data[2]);
        Console.WriteLine(a * Math.Pow(r, n - 1));
    }
}