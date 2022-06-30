using System;

class Program
{
    static void Main()
    {
        var data = Console.ReadLine().Split();
        Console.WriteLine(int.Parse(data[0]) | int.Parse(data[1]));
    }
}