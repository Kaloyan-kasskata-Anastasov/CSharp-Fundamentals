/*
Gold|Silver|Bronze|Medallion|Cup
[ Gold, Silver, Bronze, Medallion, Cup ]
Loot Wood Gold Coins
[ Coins, Wood, Gold, Silver, Bronze, Medallion, Cup ]
Loot Silver Pistol
[ Pistol, Coins, Wood, Gold, Silver, Bronze, Medallion, Cup ]
Drop 3
[ Pistol, Coins, Wood, Silver, Bronze, Medallion, Cup, Gold ]
Steal 3
[ Pistol, Coins, Wood, Silver, Bronze ]
Yohoho!

Gold|Silver|Bronze|Medallion|Cup
Loot Wood Gold Coins
Loot Silver Pistol
Drop 3
Steal 3
Yohoho!
*/

class Program
{
    static void Main()
    {
        List<string> chest = Console.ReadLine()
            .Split("|")
            .ToList();

        string input;
        while ((input = Console.ReadLine()) != "Yohoho!")
        {
            List<string> arguments = input.Split().ToList();

            switch (arguments[0])
            {
                case "Loot":
                    // in c# get all elements of an List of strings except the first element using List GetRange?
                    List<string> range = arguments.GetRange(1, arguments.Count - 1);
                    chest = Add(chest, range);
                    break;
                case "Drop":
                    int index = int.Parse(arguments[1]);
                    chest = Drop(chest, index);
                    break;
                case "Steal":
                    int count = int.Parse(arguments[1]);
                    chest = Steal(chest, count);
                    break;
            }
        }

        if (chest.Count == 0)
        {
            Console.WriteLine("Failed treasure hunt.");
        }
        else
        {
            Console.WriteLine($"Average treasure gain: {CalculateAverageTreasurePerPirate(chest):F2} pirate credits.");
        }
    }

    static List<string> Add(List<string> chest, List<string> range)
    {
        for (int i = 0; i < range.Count; i++)
        {
            if (!chest.Contains(range[i]))
            {
                chest.Insert(0, range[i]);
            }
        }

        return chest;
    }

    static List<string> Drop(List<string> chest, int index)
    {
        if (IsValidIndex(index, chest.Count - 1))
        {
            string item = chest[index];
            chest.RemoveAt(index);
            chest.Insert(chest.Count, item);
        }

        return chest;
    }

    static List<string> Steal(List<string> chest, int count)
    {
        List<string> stolenItems = new List<string>();

        for (int i = 1; i <= count; i++)
        {
            if (chest.Count != 0)
            {
                int lastIndex = chest.Count - 1;
                stolenItems.Insert(0, chest[lastIndex]);
                chest.RemoveAt(lastIndex);
            }
            else
            {
                break;
            }
        }

        Console.WriteLine(string.Join(", ", stolenItems));

        return chest;
    }

    static bool IsValidIndex(int index, int lastIndex)
    {
        return index >= 0 && index <= lastIndex;
    }

    static double CalculateAverageTreasurePerPirate(List<string> chest)
    {
        int average = 0;
        foreach (string item in chest)
        {
            average += item.Length;
        }

        return (double)average / chest.Count;

        // return chest.Select(x => x.Length).Average();
    }
}
