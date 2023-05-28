using System;

internal class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        PrintMatrix(n);
    }

    static void PrintMatrix(int n)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{n} ");
            }
            Console.WriteLine();
        }
    }
}
