using System;

class Program
{
    static void Main()
    {
        var data = Console.ReadLine().Split();
        int w = int.Parse(data[0]);
        int h = int.Parse(data[1]);
        bool[,] board = new bool[w, h];
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            data = Console.ReadLine().Split();
            int l = int.Parse(data[0]);
            int d = int.Parse(data[1]);
            int y = int.Parse(data[2]) - 1;
            int x = int.Parse(data[3]) - 1;
            if (d == 1)
                for (int j = 0; j < l; j++)
                    board[y + j, x] = !board[y + j, x];
            else
                for (int j = 0; j < l; j++)
                    board[y, x + j] = !board[y, x + j];
        }

        for (int i = 0; i < h; i++)
        {
            for (int j = 0; j < w; j++)
                Console.Write(board[i, j] ? "1 " : "0 ");
            Console.WriteLine();
        }
    }
}