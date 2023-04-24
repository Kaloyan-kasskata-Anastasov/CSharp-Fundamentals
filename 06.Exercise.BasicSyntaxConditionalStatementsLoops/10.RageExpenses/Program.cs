using System;
using System.Collections.Generic;

/*
7
2
3
4
5

23
12.50
21.50
40
200
 */

internal class Program
{
    static void Main(string[] args)
    {
        int gamesCount = int.Parse(Console.ReadLine());
        double headsetPrice = double.Parse(Console.ReadLine());
        double mousePrice = double.Parse(Console.ReadLine());
        double keyboardPrice = double.Parse(Console.ReadLine());
        double displayPrice = double.Parse(Console.ReadLine());
        double expenses = 0;

        // Every second lost game, trashes his headset.
        int headsetsTrashed = 0;
        //Every third lost game, trashes his mouse.
        int miceTrashed = 0;
        //both his mouse and headset in the same lost game, trashes his keyboard.
        int keyboardsTrashed = 0;
        //Every second time, when he trashes his keyboard, he also trashes his display
        int displaysTrashed = 0;

        for (int i = 1; i <= gamesCount; i++)
        {
            if (i % 2 == 0)
            {
                headsetsTrashed++;
            }
            
            if (i % 3 == 0)
            {
                miceTrashed++;
            }
            
            if (i % 2 == 0 && i % 3 == 0)
            {
                keyboardsTrashed++;
                if (keyboardsTrashed % 2 == 0)
                {
                    displaysTrashed++;
                }
            }
        }

        expenses = headsetsTrashed * headsetPrice +
                   miceTrashed * mousePrice +
                   keyboardsTrashed * keyboardPrice+
                   displaysTrashed * displayPrice;

        Console.WriteLine($"Rage expenses: {expenses:F2} lv.");
    }
}
