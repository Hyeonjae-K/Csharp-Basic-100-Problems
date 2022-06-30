using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int i=1; ; i++)
        {
            sum += i;
            if (sum >= n)
            {
                Console.WriteLine(i);
                break;
            }
        }
    }
}