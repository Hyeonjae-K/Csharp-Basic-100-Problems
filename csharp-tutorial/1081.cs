using System;

class Program
{
    static void Main()
    {
        var data = Console.ReadLine().Split();
        int n = int.Parse(data[0]);
        int m = int.Parse(data[1]);

        for (int i=1; i<=n; i++)
        {
            for (int j=1; j<=m; j++)
                Console.WriteLine($"{i} {j}");
        }
    }
}