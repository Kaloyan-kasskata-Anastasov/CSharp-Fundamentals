using System.Text;
using System.Text.RegularExpressions;

/*
2
STCDoghudd4=63333$D$0A53333
EHfsytsnhf?8555&I&2C9555SR

3
tt(''DGsvywgerx>6444444444%H%1B9444
GQhrr|A977777(H(TTTT
EHfsytsnhf?8555&I&2C9555SR
*/

class Message
{
    public Message()
    {
    }

    public Message(string planetName, uint population, string attackType, uint soldierCount)
    {
        PlanetName = planetName;
        Population = population;
        AttackType = attackType;
        SoldierCount = soldierCount;
    }

    public string PlanetName { get; set; }

    public uint Population { get; set; }

    public string AttackType { get; set; }

    public uint SoldierCount { get; set; }
}

internal class Program
{
    static void Main()
    {
        List<Message> messages = new List<Message>();

        int messagesCount = int.Parse(Console.ReadLine());

        string starPattern = @"[SsTtAaRr]";
        string msgPattern = @"\@(?<planet>[A-Za-z]+)[^\@\-\!\:\>]*\:(?<population>\d+)[^\@\-\!\:\>]*\!(?<type>A|D)\![^\@\-\!\:\>]*\-\>[^\@\-\!\:\>]*?(?<soldiers>\d+)[^\@\-\!\:\>]*";

        for (int i = 0; i < messagesCount; i++)
        {
            string encryptMsg = Console.ReadLine();

            int decryptionKey = Regex.Matches(encryptMsg, starPattern).Count;

            StringBuilder sb = new StringBuilder();
            for (int j = 0; j < encryptMsg.Length; j++)
            {
                sb.Append((char)(encryptMsg[j] - decryptionKey));
            }

            string encryptedMsg = sb.ToString();

            var match = Regex.Match(encryptedMsg, msgPattern);
            if (Regex.IsMatch(encryptedMsg, msgPattern) == false)
            {
                continue;
            }

            string planetName = match.Groups["planet"].Value;
            uint population = uint.Parse(match.Groups["population"].Value);
            string attackType = match.Groups["type"].Value;
            uint soldierCount = uint.Parse(match.Groups["soldiers"].Value);

            Message message = new Message(planetName, population, attackType, soldierCount);

            messages.Add(message);
        }

        var planets = messages.Where(m => m.AttackType == "A")
            .OrderBy(m => m.PlanetName)
            .ToList();
        
        Console.WriteLine($"Attacked planets: {planets.Count}");
        planets.ForEach(m => Console.WriteLine($"-> {m.PlanetName}"));

        planets = messages.Where(m => m.AttackType == "D")
            .OrderBy(m => m.PlanetName)
            .ToList();
        
        Console.WriteLine($"Destroyed planets: {planets.Count}");
        planets.ForEach(m => Console.WriteLine($"-> {m.PlanetName}"));
    }
}
