using System;

namespace Std
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = Console.ReadLine().Split(".");
            int y = int.Parse(data[0]);
            int m = int.Parse(data[1]);
            int d = int.Parse(data[2]);
            Console.WriteLine("{0}.{1}.{2}", y.ToString("D4"), m.ToString("D2"), d.ToString("D2"));
        }
    }
}