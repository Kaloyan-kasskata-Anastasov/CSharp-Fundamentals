using System.Text.RegularExpressions;

internal class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+";

        Regex regex = new Regex(pattern);
        MatchCollection validNames = regex.Matches(input);

        foreach (Match name in validNames)
        {
            Console.Write($"{name.Value} ");
        }
    }
}
