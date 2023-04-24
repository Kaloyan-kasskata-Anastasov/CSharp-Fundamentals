using System;
/*
5
A
b
C
d
E
*/
internal class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            char c = char.Parse(Console.ReadLine());
            sum += c;
        }

        Console.WriteLine($"The sum equals: {sum}");
    }
}
