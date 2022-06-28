using System;

namespace Std
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = Console.ReadLine().Split();
            int a = int.Parse(data[0]);
            int b = int.Parse(data[1]);

            Console.WriteLine($"{a} {b}");
        }
    }
}