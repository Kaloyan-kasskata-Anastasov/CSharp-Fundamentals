internal class Program
{
    static void Main()
    {
        string sentence = Console.ReadLine();

        int vowelsCount = GetVowelsCount(sentence);

        Console.WriteLine(vowelsCount);
    }

    private static int GetVowelsCount(string sentence)
    {
        int count = 0;

        sentence = sentence.ToLower();
        foreach (var symbol in sentence)
        {
            if (symbol == 'e' || 
                symbol == 'o' ||
                symbol == 'a' ||
                symbol == 'i' ||
                symbol == 'u')
            {
                count++;
            }
        }
        return count;
    }
}
