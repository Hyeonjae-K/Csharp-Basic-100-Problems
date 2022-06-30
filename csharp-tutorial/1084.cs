using System;

class Program
{
    static void Main()
    {
        var data = Console.ReadLine().Split();
        int r = int.Parse(data[0]);
        int g = int.Parse(data[1]);
        int b = int.Parse(data[2]);

        for (int i = 0; i < r; i++)
        {
            for (int j = 0; j < g; j++)
            {
                for (int k = 0; k < b; k++)
                    Console.WriteLine($"{i} {j} {k}");
            }
        }

        Console.WriteLine(r * g * b);
    }
}