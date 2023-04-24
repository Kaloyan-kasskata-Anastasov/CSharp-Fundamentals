using System;

internal class Program
{
    static void Main(string[] args)
    {
        int yield = int.Parse(Console.ReadLine());
        int days = 0;
        int spice = 0;

        while (yield >= 100)
        {
            days++;
            spice += yield;
            spice -= 26;
            yield -= 10;
        }

        spice -= 26;

        if (spice < 0)
        {
            spice = 0;
        }

        Console.WriteLine(days);
        Console.WriteLine(spice);
    }
}
