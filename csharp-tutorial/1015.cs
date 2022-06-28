using System;

namespace Std
{
    class Program
    {
        static void Main(string[] args)
        {
            float x = float.Parse(Console.ReadLine());
            Console.WriteLine(String.Format("{0:0.##}", x));
        }
    }
}