using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var data = Console.ReadLine().Split();
        int[] arr = new int[23];
        foreach (var item in data)
            arr[int.Parse(item) - 1]++;
        foreach (var item in arr)
            Console.Write($"{item} ");
    }
}