using System;

class Program
{
    static void Main()
    {
        var data = Console.ReadLine().Split();
        foreach (var item in data)
        {
            if (item == "0") break;
            Console.WriteLine(item);
        }
    }
}