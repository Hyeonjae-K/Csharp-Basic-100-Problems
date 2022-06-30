using System;

class Program
{
    static void Main()
    {
        char c = char.Parse(Console.ReadLine());
        for (int i='a'; i <= c; i++)
            Console.Write($"{(char)i} ");
    }
}