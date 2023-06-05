using System.Diagnostics.CodeAnalysis;

internal class Program
{
    static void Main()
    {
        List<int> playerOneDeck = Console.ReadLine().Split().Select(int.Parse).ToList();
        List<int> playerTwoDeck = Console.ReadLine().Split().Select(int.Parse).ToList();

        while (playerOneDeck.Count > 0 && playerTwoDeck.Count > 0)
        {
            int playerOneCard = playerOneDeck[0];
            int playerTwoCard = playerTwoDeck[0];

            if (playerOneCard > playerTwoCard)
            {
                playerOneDeck.RemoveAt(0);
                playerTwoDeck.RemoveAt(0);
                playerOneDeck.Add(playerTwoCard);
                playerOneDeck.Add(playerOneCard);
            }
            else if (playerTwoCard > playerOneCard)
            {
                playerOneDeck.RemoveAt(0);
                playerTwoDeck.RemoveAt(0);
                playerTwoDeck.Add(playerOneCard);
                playerTwoDeck.Add(playerTwoCard);
            }
            else
            {
                playerOneDeck.RemoveAt(0);
                playerTwoDeck.RemoveAt(0);
            }
        }

        if (playerOneDeck.Count > 0)
        {
            Console.WriteLine($"First player wins! Sum: {Sum(playerOneDeck)}");
        }
        else if (playerTwoDeck.Count > 0)
        {
            Console.WriteLine($"Second player wins! Sum: {Sum(playerTwoDeck)}");
        }
        else
        {
            Console.WriteLine("No player wins! Sum: 0");
        }
    }

    private static int Sum(List<int> list)
    {
        int sum = 0;
        foreach (int item in list)
        {
            sum += item;
        }

        return sum;
    }
}
