using System;

class Program
{
    static void Main()
    {
        int[,] board = new int[20, 20];
        int n = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < n; i++)
        {
            var loc = Console.ReadLine().Split();
            int x = int.Parse(loc[0]);
            int y = int.Parse(loc[1]);
            board[x, y] = 1;
        }

        for (int i = 1; i < 20; i++)
        {
            for (int j = 1; j < 20; j++)
                Console.Write($"{board[i, j]} ");
            Console.WriteLine();
        }
    }
}