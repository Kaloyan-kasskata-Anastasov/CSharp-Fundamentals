using System;
using System.Numerics;

/*
(snowballSnow / snowballTime) ^ snowballQuality
{snowballSnow} : {snowballTime} = {snowballValue} ({snowballQuality})

2
10
2
3
5
5
5
*/

internal class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int bestSnow = 0, bestTime = 0, bestQuality = 0;
        BigInteger bestValue = 0;

        for (int i = 0; i < n; i++)
        {
            int snow = int.Parse(Console.ReadLine());
            int time = int.Parse(Console.ReadLine());
            int quality = int.Parse(Console.ReadLine());

            BigInteger value = BigInteger.Pow(snow / time, quality);

            if (bestValue < value)
            {
                bestValue = value;
                bestSnow = snow;
                bestTime = time;
                bestQuality = quality;
            }
        }

        Console.WriteLine($"{bestSnow} : {bestTime} = {bestValue} ({bestQuality})");
    }
}
