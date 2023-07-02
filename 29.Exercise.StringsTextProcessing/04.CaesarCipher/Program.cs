using System.Text;

internal class Program
{
    static void Main()
    {
        string text = Console.ReadLine();

        StringBuilder sb = new StringBuilder();

        char[] encryptedChars = new char[text.Length];

        for (int i = 0; i < text.Length; i++)
        {
            char originalChar = text[i];
            
            sb.Append((char)(originalChar + 3));
        }

        Console.WriteLine(sb);
    }
}
