using System;

class Program
{
    static void Main()
    {
        var data = Console.ReadLine().Split();
        foreach (var item in data) Console.WriteLine(int.Parse(item) % 2 == 0 ? "even" : "odd");
    }
}