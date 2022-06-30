using System;

class Program
{
    static void Main()
    {
        bool[,] board = new bool[19, 19];
        
        for (int i = 0; i < 19; i++)
        {
            var row = Console.ReadLine().Split();
            for (int j = 0; j < row.Length; j++)
                board[i, j] = row[j] == "1" ? true : false;
        }

        int n = int.Parse(Console.ReadLine());
        for (int i=0; i < n; i++)
        {
            var loc = Console.ReadLine().Split();
            int x = int.Parse(loc[0]) - 1;
            int y = int.Parse(loc[1]) - 1;
            for (int j=0; j < 19; j++)
            {
                board[j, x] = !board[j, x];
                board[y, j] = !board[y, j];
            }
        }

        for (int i = 0; i < 19; i++)
        {
            for (int j = 0; j < 19; j++)
                Console.Write(board[i, j] ? "1 " : "0 ");
            Console.WriteLine();
        }
    }
}