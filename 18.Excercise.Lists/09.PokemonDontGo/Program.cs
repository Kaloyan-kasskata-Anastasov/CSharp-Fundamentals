/*
4 5 3
1
1
0

5 10 6 3 5
2
4
1
1
3
0
0
*/

using System.Diagnostics.CodeAnalysis;

internal class Program
{
    static void Main()
    {
        List<int> distances = Console.ReadLine().Split().Select(int.Parse).ToList();
        int RemovedValuesSum = 0;
        while (distances.Count > 0)
        {
            int indexToRemove = int.Parse(Console.ReadLine());
            int removedNumber;
            if (indexToRemove < 0)
            {
                removedNumber = distances[0];
                distances[0] = distances[distances.Count - 1];
            }
            else if (indexToRemove > distances.Count - 1)
            {
                removedNumber = distances[distances.Count - 1];
                distances[distances.Count - 1] = distances[0];
            }
            else
            {
                removedNumber = distances[indexToRemove];
                distances.RemoveAt(indexToRemove);
            }

            RemovedValuesSum += removedNumber;

            for (int i = 0; i < distances.Count; i++)
            {
                if (distances[i] <= removedNumber)
                {
                    distances[i] += removedNumber;
                }
                else
                {
                    distances[i] -= removedNumber;
                }
            }
        }

        Console.WriteLine(RemovedValuesSum);
    }
}
