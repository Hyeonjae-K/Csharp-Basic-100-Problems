﻿using System;

class Program
{
    static void Main()
    {
        int month = int.Parse(Console.ReadLine());
        switch (month)
        {
            case 12:
            case 1:
            case 2:
                Console.WriteLine("winter");
                break;
            case 3:
            case 4:
            case 5:
                Console.WriteLine("spring");
                break;
            case 6:
            case 7:
            case 8:
                Console.WriteLine("summer");
                break;
            case 9:
            case 10:
            case 11:
                Console.WriteLine("fall");
                break;
            default:
                break;
        }
    }
}