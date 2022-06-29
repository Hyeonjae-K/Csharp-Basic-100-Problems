using System;

class Program
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine(), 16);
        Console.WriteLine(Convert.ToString(n, 8));
    }
}