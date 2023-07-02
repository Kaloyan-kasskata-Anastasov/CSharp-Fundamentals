using System.Text;
using System.Text.RegularExpressions;

/*
George, Peter, Bill, Tom
G4e@55or%6g6!68e!!@
R1@!3a$y4456@
B5@i@#123ll
G@e54o$r6ge#
7P%et^#e5346r
T$o553m&6
end of race
*/

public class Participant
{
    public Participant(string name)
    {
        Name = name;
    }

    public string Name { get; set; }

    public uint Distance { get; set; }
}

internal class Program
{
    static void Main()
    {
        Dictionary<string, Participant> participants = new Dictionary<string, Participant>();
        string digitsPattern = @"\d";
        string lettersPattern = @"[A-Za-z]";

        string[] participantsArr = Console.ReadLine().Split(", ");

        for (int i = 0; i < participantsArr.Length; i++)
        {
            participants.Add(participantsArr[i], new Participant(participantsArr[i]));
        }

        string command;
        while ((command = Console.ReadLine()) != "end of race")
        {
            StringBuilder name = new StringBuilder();
            foreach (Match m in Regex.Matches(command, lettersPattern))
            {
                name.Append(m.Value);
            }

            uint distance = 0;
            foreach (Match m in Regex.Matches(command, digitsPattern))
            {
                distance += uint.Parse(m.Value);
            }

            if (participants.ContainsKey(name.ToString()))
            {
                participants[name.ToString()].Distance += distance;
            }
        }

        List<Participant> orderedParticipants = participants
            .Select(p=>p.Value)
            .OrderByDescending(m => m.Distance)
            .Take(3)
            .ToList();

        Console.WriteLine($"1st place: {orderedParticipants[0].Name}");
        Console.WriteLine($"2nd place: {orderedParticipants[1].Name}");
        Console.WriteLine($"3rd place: {orderedParticipants[2].Name}");
    }
}
