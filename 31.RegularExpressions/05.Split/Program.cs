using System.Text.RegularExpressions;

internal class Program
{
    static void Main()
    {
        string text = "1 2 3 4";
        string pattern = @"\s+";
        
        string[] results = Regex.Split(text, pattern);
        Console.WriteLine(string.Join(", ", results));
        // 1, 2, 3, 4
    }
}
