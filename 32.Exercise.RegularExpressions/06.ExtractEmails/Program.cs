using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        string pattern = @"[^\.\-_]\b(?![\._\-])[A-Za-z0-9]+[\.\-_]*[A-Za-z0-9]+@[^\.\-](?:[A-Za-z\.\-]+\.)+[A-Za-z]+";

        MatchCollection collection = Regex.Matches(input, pattern);

        for (int i = 0; i < collection.Count; i++)
        {
            Console.WriteLine(collection[i].Value.Trim(',', ' ', '\n'));
        }
    }
}
