using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int i=2; i<=n; i+=2)
            sum += i;
        Console.WriteLine(sum);
    }
}