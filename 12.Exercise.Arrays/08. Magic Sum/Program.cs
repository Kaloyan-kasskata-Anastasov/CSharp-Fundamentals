using System;
using System.Linq;

/*
1 7 6 2 19 23
8
*/
internal class Program
{
    static void Main()
    {
        int[] numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();
        int sum = int.Parse(Console.ReadLine());

        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[i] + numbers[j] == sum)
                {
                    Console.WriteLine($"{numbers[i]} {numbers[j]}");
                }
            }
        }
    }
}
