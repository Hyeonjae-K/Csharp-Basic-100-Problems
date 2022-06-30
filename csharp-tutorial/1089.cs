using System;

class Program
{
    static void Main()
    {
        var data = Console.ReadLine().Split();
        int a = int.Parse(data[0]);
        int d = int.Parse(data[1]);
        int n = int.Parse(data[2]);
        Console.WriteLine(a + d * (n - 1));
    }
}