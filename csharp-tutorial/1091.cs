using System;

class Program
{
    static void Main()
    {
        var data = Console.ReadLine().Split();
        int a = int.Parse(data[0]);
        int m = int.Parse(data[1]);
        int d = int.Parse(data[2]);
        int n = int.Parse(data[3]);
        for (int i = 1; i < n; i++)
            a = a * m + d;
        Console.WriteLine(a);
    }
}