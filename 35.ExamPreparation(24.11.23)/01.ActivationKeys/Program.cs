/*
abcdefghijklmnopqrstuvwxyz
Slice>>>2>>>6
Flip>>>Upper>>>3>>>14
Flip>>>Lower>>>5>>>7
Contains>>>def
Contains>>>deF
Generate
*/

class Program
{
    static string activationKey;

    static void Main()
    {
        activationKey = Console.ReadLine();

        string command;
        while ((command = Console.ReadLine()) != "Generate")
        {
            string[] arguments = command.Split(">>>");

            switch (arguments[0])
            {
                case "Contains":
                    Contains(arguments[1]);
                    break;
                case "Flip":
                    if (arguments[1] == "Upper")
                    {
                        FlipUpper(int.Parse(arguments[2]), int.Parse(arguments[3]));
                    }
                    else
                    {
                        FlipLower(int.Parse(arguments[2]), int.Parse(arguments[3]));
                    }

                    break;
                case "Slice":
                    Slice(int.Parse(arguments[1]), int.Parse(arguments[2]));
                    break;
            }
        }

        Console.WriteLine($"Your activation key is: {activationKey}");
    }

    static void Contains(string substring)
    {
        if (activationKey.Contains(substring))
        {
            Console.WriteLine($"{activationKey} contains {substring}");
        }
        else
        {
            Console.WriteLine("Substring not found!");
        }
    }

    static void FlipUpper(int startIndex, int endIndex)
    {
        string prefix = activationKey.Substring(0, startIndex);
        string middle = activationKey.Substring(startIndex, endIndex - startIndex).ToUpper();
        string suffix = activationKey.Substring(endIndex);

        activationKey = $"{prefix}{middle}{suffix}";
        Console.WriteLine(activationKey);
    }

    static void FlipLower(int startIndex, int endIndex)
    {
        string prefix = activationKey.Substring(0, startIndex);
        string middle = activationKey.Substring(startIndex, endIndex - startIndex).ToLower();
        string suffix = activationKey.Substring(endIndex);

        activationKey = $"{prefix}{middle}{suffix}";
        Console.WriteLine(activationKey);
    }

    static void Slice(int startIndex, int endIndex)
    {
        string firstPart = activationKey.Substring(0, startIndex);
        string secondPart = activationKey.Substring(endIndex);

        activationKey = $"{firstPart}{secondPart}";
        Console.WriteLine(activationKey);
    }
}
