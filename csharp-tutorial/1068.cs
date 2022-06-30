using System;

class Program
{
    static void Main()
    {
        int score = int.Parse(Console.ReadLine()) / 10;
        switch (score)
        {
            case 10:
            case 9:
                Console.WriteLine("A");
                break;
            case 8:
            case 7:
                Console.WriteLine("B");
                break;
            case 6:
            case 5:
            case 4:
                Console.WriteLine("C");
                break;
            default:
                Console.WriteLine("D");
                break;
        }
    }
}