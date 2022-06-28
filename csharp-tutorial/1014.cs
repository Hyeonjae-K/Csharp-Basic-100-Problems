using System;

namespace Std
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = Console.ReadLine().Split();
            char x = char.Parse(data[0]);
            char y = char.Parse(data[1]);

            Console.WriteLine($"{y} {x}");
        }
    }
}