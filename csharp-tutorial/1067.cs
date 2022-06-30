using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(n > 0 ? "plus" : "minus");
        Console.WriteLine(n % 2 == 0 ? "even" : "odd");
    }
}