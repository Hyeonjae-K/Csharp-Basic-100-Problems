using System;

class Program
{
    static void Main()
    {
        Console.ReadLine();
        var data = Console.ReadLine().Split();
        int min = 23;
        foreach (var item in data)
            min = min > int.Parse(item) ? int.Parse(item) : min;
        Console.WriteLine(min);
    }
}