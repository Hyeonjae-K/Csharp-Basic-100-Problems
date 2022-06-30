using System;

class Program
{
    static void Main()
    {
        var data = Console.ReadLine().Split();
        foreach (var item in data)
        {
            Console.WriteLine(item);
            if (item == "q") break;
        }
    }
}