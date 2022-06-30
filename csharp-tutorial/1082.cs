using System;

class Program
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine(), 16);
        for(int i=1; i<16; i++)
        {
            Console.WriteLine($"{n.ToString("X")}*{i.ToString("X")}={(n*i).ToString("X")}");
        }
    }
}