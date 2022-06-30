using System;

class Program
{
    static void Main()
    {
        var data = Console.ReadLine().Split();
        foreach (var item in data)
            if (int.Parse(item) % 2 == 0) Console.WriteLine(item);
    }
}