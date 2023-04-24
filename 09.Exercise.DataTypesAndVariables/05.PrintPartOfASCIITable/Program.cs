using System;

internal class Program
{
    static void Main(string[] args)
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());

        int i = start;
        for (; i < end; i++)
        {
            Console.Write($"{(char)i} ");
        }

        Console.WriteLine((char)i);
    }
}
