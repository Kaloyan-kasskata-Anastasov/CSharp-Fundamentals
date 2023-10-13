/*
1 1 2 2 3 3 4 4 5 5
1 0
-1 0
1 0
1 0
1 0
end

a 2 4 a 2 4
0 3
0 2
0 1
0 1
end

Next example == FormatException???

a 2 4 a 2 4
4 0 
0 2 
0 1 
0 1 
end

*/

class Program
{
    static void Main()
    {
        List<string> sequence = Console.ReadLine()
            .Split(' ')
            .ToList();

        string input;
        int movesCount = 0;
        bool won = false;

        while ((input = Console.ReadLine()) != "end")
        {
            int[] indexes = input
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int firstIndex = indexes[0];
            int secondIndex = indexes[1];

            movesCount++;
            if (firstIndex == secondIndex ||
                (firstIndex < 0 || firstIndex >= sequence.Count) ||
                (secondIndex < 0 || secondIndex >= sequence.Count))
            {
                int middleIndex = sequence.Count / 2;
                string newSymbol = $"-{movesCount}a";
                List<string> newElements = new List<string> { newSymbol, newSymbol };
                sequence.InsertRange(middleIndex, newElements);
                Console.WriteLine("Invalid input! Adding additional elements to the board");
            }
            else
            {
                // hit two matching elements
                if (sequence[firstIndex] == sequence[secondIndex])
                {
                    var value = sequence[firstIndex];
                    Console.WriteLine($"Congrats! You have found matching elements - {value}!");

                    if (firstIndex < secondIndex)
                    {
                        sequence.RemoveAt(firstIndex);
                        sequence.RemoveAt(secondIndex - 1);
                    }
                    else
                    {
                        sequence.RemoveAt(secondIndex);
                        sequence.RemoveAt(firstIndex - 1);
                    }
                }
                // hit two different elements
                else if (sequence[firstIndex] != sequence[secondIndex])
                {
                    Console.WriteLine("Try again!");
                }

                // all matching elements before he receives "end"
                if (sequence.Count == 0)
                {
                    won = true;
                    Console.WriteLine($"You have won in {movesCount} turns!");
                    break;
                }
            }
        }

        // "end" before he hits all matching elements
        if (!won)
        {
            Console.WriteLine("Sorry you lose :(");
            Console.WriteLine($"{string.Join(" ", sequence)}");
        }
    }
}
