using System;

class Program
{
    static void Main()
    {
        int[,] board = new int[10, 10];
        for (int i = 0; i < 10; i++)
        {
            var row = Console.ReadLine().Split();
            for (int j = 0; j < 10; j++)
                board[i, j] = int.Parse(row[j]);
        }

        int x = 1;
        int y = 1;
        while ((board[y, x] != 2) && ((board[y, x + 1] != 1) || (board[y + 1, x] != 1)))
        {
            board[y, x] = 9;
            if (board[y, x + 1] == 1) y++;
            else x++;
        }

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
                Console.Write($"{board[i, j]} ");
            Console.WriteLine();
        }
    }
}