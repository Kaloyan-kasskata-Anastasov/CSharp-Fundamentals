using System;

/*
5
10

 */
internal class Program
{
    static void Main(string[] args)
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());
        int sum = 0;

        for (int i = start; i < end; i++)
        {
            Console.Write($"{i} ");
            sum += i;
        }

        Console.WriteLine(end);
        sum += end;

        Console.WriteLine($"Sum: {sum}");
    }
}
