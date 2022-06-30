using System;

class Program
{
    static void Main()
    {
        var data = Console.ReadLine().Split();
        int a = int.Parse(data[0]);
        int b = int.Parse(data[1]);
        a = a < b ? a : b;
        b = int.Parse(data[2]);
        Console.WriteLine(a < b ? a : b);
    }
}