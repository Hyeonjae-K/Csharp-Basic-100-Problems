using System;

class Program
{
    static void Main()
    {
        var data = Console.ReadLine().Split();
        Console.WriteLine(long.Parse(data[0]) + long.Parse(data[1]));
    }
}