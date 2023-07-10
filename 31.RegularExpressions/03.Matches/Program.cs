using System.Text.RegularExpressions;

internal class Program
{
    static void Main()
    {
        string text = "Nakov: 123, Branson: 456";
        string pattern = @"([A-Z][a-z]+): (\d+)";
        Regex regex = new Regex(pattern);
        MatchCollection matches = regex.Matches(text);
        Console.WriteLine("Found {0} matches", matches.Count);
        foreach (Match match in matches)
        {
            Console.WriteLine("Name: {0}", match.Groups[1]);
        }

        // Found 2 matches
        // Name: Nakov
        // Name: Branson
    }
}
