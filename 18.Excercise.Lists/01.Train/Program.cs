/*
32 54 21 12 4 0 23
75
Add 10
Add 0
30
10
75
end
*/

internal class Program
{
    static void Main()
    {
        int[] passengers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();
        int maxCapacity = int.Parse(Console.ReadLine());

        List<int> wagons = new List<int>(passengers);

        string commands;
        while ((commands = Console.ReadLine()) != "end")
        {
            string[] arguments = commands.Split();
            if (arguments[0] == "Add")
            {
                wagons.Add(int.Parse(arguments[1]));
            }
            else
            {
                int newPassengers = int.Parse(arguments[0]);
                for (int i = 0; i < wagons.Count; i++)
                {
                    if (wagons[i] + newPassengers <= maxCapacity)
                    {
                        wagons[i] += newPassengers;
                        break;
                    }
                }
            }
        }

        Console.WriteLine(string.Join(" ", wagons));
    }
}
