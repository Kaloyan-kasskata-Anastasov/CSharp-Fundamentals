/*
In the Sofia Zoo there are 311 animals in total! ::Smiley:: This includes 3 **Tigers**, 1 ::Elephant:, 12 **Monk3ys**, a **Gorilla::, 5 ::fox:es: and 21 different types of :Snak::Es::. ::Mooning:: **Shy**

5, 4, 3, 2, 1, go! The 1-th consecutive banana-eating contest has begun! ::Joy:: **Banana** ::Wink:: **Vali** ::valid_emoji::

It is a long established fact that 1 a reader will be distracted by 9 the readable content of a page when looking at its layout. The point of using ::LoremIpsum:: is that it has a more-or-less normal 3 distribution of 8 letters, as opposed to using 'Content here, content 99 here', making it look like readable **English**.
*/

using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string coolThresholdPattern = @"\d";
        string emojiPattern = @"(\*{2}|:{2})(?<Emoji>[A-Z][a-z]{2,})\1";
        ulong coolThreshold = 1;
        List<string> coolEmojis = new List<string>();

        string input = Console.ReadLine();

        foreach (Match match in Regex.Matches(input, coolThresholdPattern))
        {
            coolThreshold *= ulong.Parse(match.Value);
        }

        MatchCollection matches = Regex.Matches(input, emojiPattern);

        foreach (Match match in matches)
        {
            string emojiStr = match.Groups["Emoji"].Value;
            ulong totalEmojiSum = 0;
            foreach (char character in emojiStr)
            {
                totalEmojiSum += character;
            }

            if (totalEmojiSum >= coolThreshold)
            {
                coolEmojis.Add(match.Value);
            }
        }

        Console.WriteLine($"Cool threshold: {coolThreshold}");
        Console.WriteLine($"{matches.Count} emojis found in the text. The cool ones are:");
        coolEmojis.ForEach(emoji => Console.WriteLine(emoji));
    }
}
