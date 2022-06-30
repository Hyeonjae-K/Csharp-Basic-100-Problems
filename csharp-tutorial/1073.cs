using System;

class Program
{
    static void Main()
    {
        var data = Console.ReadLine().Split();
        int i = 0;
        while (data[i] != "0")
        {
            Console.WriteLine(data[i++]);
        }
    }
}