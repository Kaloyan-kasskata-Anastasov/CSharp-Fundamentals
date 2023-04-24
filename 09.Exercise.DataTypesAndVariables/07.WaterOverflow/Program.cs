using System;

/*
5
20
100
100
100
20
*/

internal class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int totalLiters = 0;

        for (int i = 0; i < n; i++)
        {
            int quantity = int.Parse(Console.ReadLine());

            if (totalLiters + quantity > byte.MaxValue)
            {
                Console.WriteLine("Insufficient capacity!");
            }
            else
            {
                totalLiters += quantity;
            }
        }

        Console.WriteLine(totalLiters);
    }
}
