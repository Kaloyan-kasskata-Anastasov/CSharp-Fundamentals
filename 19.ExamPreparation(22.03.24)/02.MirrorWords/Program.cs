using System.Text.RegularExpressions;

/*
@mix#tix3dj#poOl##loOp#wl@@bong&song%4very$long@thong#Part##traP##@@leveL@@Level@##car#rac##tu@pack@@ckap@#rr#sAw##wAs#r#@w1r

#po0l##l0op# @bAc##cAB@ @LM@ML@ #xxxXxx##xxxXxx# @aba@@ababa@

#lol#lol# @#God@@doG@# #abC@@Cba# @Xyu@#uyX#

*/
internal class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        string pattern = @"(?<word>(?:\@|\#)[A-Za-z]{3,}(?:\@|\#))(?<mirror>(?:\@|\#)[A-Za-z]{3,}(?:\@|\#))";

        int pairs = 0;

        var matches = Regex.Matches(input, pattern);

        List<string> mirrors = new List<string>();

        foreach (Match match in matches)
        {
            string word = match.Groups["word"].Value;
            string mirror = match.Groups["mirror"].Value;

            char a = word[0];
            if (word[0] == word[word.Length - 1] &&
                word[0] == mirror[0] &&
                word[0] == mirror[mirror.Length - 1])
            {
                pairs++;

                var mirrored = new string(mirror.Reverse().ToArray());
                if (word == mirrored)
                {
                    string matchSymbolsPattern = @"(?:\@|\#)";
                    string cleanWord = Regex.Replace(word, matchSymbolsPattern, "");
                    string cleanMirror = Regex.Replace(mirror, matchSymbolsPattern, "");
                    mirrors.Add($"{cleanWord} <=> {cleanMirror}");
                }
            }
        }

        if (pairs == 0)
        {
            Console.WriteLine("No word pairs found!");
        }
        else
        {
            Console.WriteLine($"{pairs} word pairs found!");
        }

        if (mirrors.Count > 0)
        {
            Console.WriteLine("The mirror words are:");
            Console.WriteLine(string.Join(", ", mirrors));
        }
        else
        {
            Console.WriteLine("No mirror words!");
        }
    }
}
