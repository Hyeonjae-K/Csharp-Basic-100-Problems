using System;

namespace Std
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = Console.ReadLine().Split("-");
            int front = int.Parse(data[0]);
            int rear = int.Parse(data[1]);

            Console.WriteLine("{0}{1}", front.ToString("D6"), rear.ToString("D7"));
        }
    }
}