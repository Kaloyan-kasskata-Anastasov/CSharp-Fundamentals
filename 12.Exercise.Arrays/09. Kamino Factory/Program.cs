using System;

/*
5
1!0!1!1!0
0!1!1!0!0
Clone them!

4
1!1!0!1
1!0!0!1
1!1!0!0
Clone them!
*/

internal class Program
{
    static void Main()
    {
        int sequenceLength = int.Parse(Console.ReadLine());
        // Fixed by MiroslavaTsaneva january 2024 :)
        int bestSequenceIndex = 1;
        int bestStartIndex = int.MaxValue;
        int bestSum = 0;
        int bestCount = 0;
        string[] bestSequence = Array.Empty<string>();

        int index = 0;
        string sequence;

        while (true)
        {
            sequence = Console.ReadLine();
            if (sequence == "Clone them!")
            {
                break;
            }
            
            index += 1;
            int count = 0;
            int sum = 0;
            string[] sequenceArr = sequence.Split("!", StringSplitOptions.RemoveEmptyEntries);
            if (bestSequence.Length == 0)
            {
                bestSequence = sequenceArr;
            }

            for (int i = sequenceLength - 1; i >= 0; i--)
            {
                if (sequenceArr[i] == "1")
                {
                    sum++;
                    count++;
                    if (bestCount < count || bestStartIndex > i || bestSum < sum)
                    {
                        bestSequence = sequenceArr;
                        bestStartIndex = i;
                        bestSequenceIndex = index;
                        bestCount = count;
                        bestSum = sum;
                    }
                }
                else
                {
                    count = 0;
                }
            }
        }

        Console.WriteLine($"Best DNA sample {bestSequenceIndex} with sum: {bestSum}.");
        Console.WriteLine($"RESULT {string.Join(" ", bestSequence)} KASSKATA");
    }
}
