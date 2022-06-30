using System;

class Program
{
    static void Main()
    {
        var data = Console.ReadLine().Split();
        int a = int.Parse(data[0]);
        int b = int.Parse(data[1]);
        int c = int.Parse(data[2]);
        int day = 1;
        day *= ((b % a == 0) | (c % a == 0) ? 1 : a) * 
            ((a % b == 0) | (c % b == 0) ? 1 : b) * 
            ((b % c == 0) | (a % c == 0) ? 1 : c);
        Console.WriteLine(day);
    }
}