using System;

class Program
{
    static void Main()
    {
        var data = Console.ReadLine().Split();
        long sum = 0;
        foreach(var item in data)
        {
            sum += long.Parse(item);
        }
        Console.WriteLine(sum);
        Console.WriteLine(((float)sum / data.Length).ToString("F1"));
    }
}