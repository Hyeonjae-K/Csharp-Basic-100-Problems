﻿using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int i = 0;
        while (++i <= n)
        {
            if (i % 3 == 0) continue;
            Console.Write($"{i} ");
        }
    }
}