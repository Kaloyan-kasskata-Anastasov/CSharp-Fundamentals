internal class Program
{
    static void Main()
    {
        Dictionary<char, int> charOccurrences = new Dictionary<char, int>();

        string input = Console.ReadLine();

        for (int i = 0; i < input.Length; i++)
        {
            var character = input[i];

            if (character == ' ')
            {
                continue;
            }

            if (!charOccurrences.ContainsKey(character))
            {
                charOccurrences.Add(character, 0);
            }

            charOccurrences[character]++;
        }

        foreach (KeyValuePair<char, int> pair in charOccurrences)
        {
            char character = pair.Key;
            int occurrences = pair.Value;
            Console.WriteLine($"{character} -> {occurrences}");
        }

    }
}
