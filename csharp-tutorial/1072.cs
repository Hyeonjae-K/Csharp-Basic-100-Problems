using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var data = Console.ReadLine().Split();

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(data[i]);
        }
    }
}