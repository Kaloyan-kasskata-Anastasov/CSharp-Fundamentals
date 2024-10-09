internal class Program
{
    static void Main()
    {
        string input = Console.ReadLine();

        Console.WriteLine(GetMiddleChars(input));
    }

    static string GetMiddleChars(string text)
    {
        int middleIndex = text.Length / 2;

        string result = $"{text[middleIndex]}";

        if (text.Length % 2 == 0)
        {
            result = $"{text[middleIndex - 1]}" + result;
        }

        return result;
    }
}
