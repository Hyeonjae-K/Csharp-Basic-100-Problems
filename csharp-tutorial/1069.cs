using System;

class Program
{
    static void Main()
    {
        char grade = char.Parse(Console.ReadLine());
        switch (grade)
        {
            case 'A':
                Console.WriteLine("best!!!");
                break;
            case 'B':
                Console.WriteLine("good!!");
                break;
            case 'C':
                Console.WriteLine("run!");
                break;
            case 'D':
                Console.WriteLine("slowly~");
                break;
            default:
                Console.WriteLine("What?");
                break;
        }
    }
}