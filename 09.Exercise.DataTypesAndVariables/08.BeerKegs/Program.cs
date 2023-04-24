using System;

internal class Program
{
    static void Main(string[] args)
    {
        string kegModel;
        double kegRadius;
        double kegHeight;

        string biggestKegModel = "";
        double biggestKeg = 0;

        int kegsCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < kegsCount; i++)
        {
            kegModel = Console.ReadLine();
            kegRadius = double.Parse(Console.ReadLine());
            kegHeight = double.Parse(Console.ReadLine());

            double volume = Math.PI * (kegRadius * kegRadius) * kegHeight;

            if (biggestKeg < volume)
            {
                biggestKeg = volume;
                biggestKegModel = kegModel;
            }
        }

        Console.WriteLine(biggestKegModel);
    }
}
