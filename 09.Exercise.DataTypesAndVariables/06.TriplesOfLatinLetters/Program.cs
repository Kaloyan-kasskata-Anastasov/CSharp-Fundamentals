using System;

internal class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int startChar = 97;
        int endChar = startChar + n;

        for (int i = startChar; i < endChar; i++)
        {
            for (int j = startChar; j < endChar; j++)
            {
                for (int k = startChar; k < endChar; k++)
                {
                    Console.WriteLine($"{(char)i}{(char)j}{(char)k}");
                }
            }
        }
    }
}
