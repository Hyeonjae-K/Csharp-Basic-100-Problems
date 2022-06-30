using System;

class Program
{
    static void Main()
    {
        Console.ReadLine();
        var data = Console.ReadLine().Split();
        for (int i=data.Length-1; i>=0; i--)
        {
            Console.Write($"{data[i]} ");
        }
    }
}