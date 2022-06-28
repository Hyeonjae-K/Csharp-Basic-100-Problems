using System;

namespace Std
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = Console.ReadLine().Split(":");
            int h = int.Parse(data[0]);
            int m = int.Parse(data[1]);

            Console.WriteLine($"{h}:{m}");
        }
    }
}