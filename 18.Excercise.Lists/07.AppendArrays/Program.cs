/*
1 2 3 |4 5 6 | 7 8
*/

internal class Program
{
    static void Main()
    {
        string[] stringsArrays = Console.ReadLine()
            .Split('|', StringSplitOptions.RemoveEmptyEntries);
        
        List<string> symbols = ExtractSymbols(stringsArrays);

        Console.WriteLine(string.Join(" ", symbols));
    }

    private static List<string> ExtractSymbols(string[] stringsArrays)
    {
        List<string> result = new List<string>();

        for (int i = stringsArrays.Length - 1; i >= 0; i--)
        {
            string[] array = stringsArrays[i]
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            result.AddRange(array);
        }

        return result;
    }
}
