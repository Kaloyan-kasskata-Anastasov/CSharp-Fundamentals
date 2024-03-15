/*
Hawai::Cyprys-Greece
Add Stop:7:Rome
Remove Stop:11:16
Switch:Hawai:Bulgaria
Travel

Albania:Bulgaria:Cyprus:Deuchland
Add Stop:3:Nigeria
Remove Stop:4:8
Switch:Albania: Azərbaycan
Travel

*/

using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder stops = new StringBuilder(Console.ReadLine());

        string input;
        while ((input = Console.ReadLine()) != "Travel")
        {
            string[] arguments = input.Split(":");

            switch (arguments[0])
            {
                case "Add Stop":
                    int index = int.Parse(arguments[1]);
                    string stop = arguments[2];
                    if (IsValidIndex(index, stops.Length - 1))
                    {
                        stops.Insert(index, stop);
                    }

                    break;
                case "Remove Stop":
                    int startIndex = int.Parse(arguments[1]);
                    int endIndex = int.Parse(arguments[2]);
                    if (IsValidIndex(startIndex, stops.Length - 1) && IsValidIndex(endIndex, stops.Length - 1))
                    {
                        stops.Remove(startIndex, endIndex - startIndex + 1);
                    }

                    break;
                case "Switch":
                    string oldString = arguments[1];
                    string newString = arguments[2];
                    stops.Replace(oldString, newString);
                    break;
            }

            Console.WriteLine(stops.ToString());
        }

        Console.WriteLine($"Ready for world tour! Planned stops: {stops}");
    }

    private static bool IsValidIndex(int index, int lastIndex)
    {
        return 0 <= index && index <= lastIndex;
    }
}
