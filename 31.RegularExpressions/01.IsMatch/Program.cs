using System.Text.RegularExpressions;

internal class Program
{
    static void Main(string[] args)
    {
        string text = "Today is 2015-05-11";
        string pattern = @"\d{4}-\d{2}-\d{2}";
        
        Regex regex = new Regex(pattern);
        bool containsValidDate = regex.IsMatch(text);
        Console.WriteLine(containsValidDate); // True
    }
}
