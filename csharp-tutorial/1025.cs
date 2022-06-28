using System;

namespace Std
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            for (int i = 0; i < line.Length; i++)
            {
                Console.WriteLine($"[{int.Parse(line[i].ToString()) * Math.Pow(10, line.Length - i - 1)}]");
            }
        }
    }
}