using System;

class Program
{
    static void Main()
    {
        var data = Console.ReadLine().Split();
        bool a = bool.Parse(data[0]);
        bool b = bool.Parse(data[1]);
        if (a != b) Console.WriteLine(1);
        else Console.WriteLine(0)
    }
}