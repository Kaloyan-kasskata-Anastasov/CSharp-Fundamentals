/*
4
Allie is going!
George is going!
John is not going!
George is not going!
*/

internal class Program
{
    static void Main()
    {
        int guestsCount = int.Parse(Console.ReadLine());
        List<string> guestList = new List<string>();

        for (int i = 0; i < guestsCount; i++)
        {
            string[] arguments = Console.ReadLine().Split();
            string name = arguments[0];

            if (arguments[2] == "going!")
            {
                AddGuest(guestList, name);
            }
            else if (arguments[2] == "not")
            {
                RemoveGuest(guestList, name);
            }
        }

        Console.WriteLine(string.Join("\n", guestList));
    }

    private static void AddGuest(List<string> guestList, string name)
    {
        if (guestList.FindIndex(x => x == name) == -1)
        {
            guestList.Add(name);
        }
        else
        {
            Console.WriteLine($"{name} is already in the list!");
        }
    }

    private static void RemoveGuest(List<string> guestList, string name)
    {
        if (guestList.FindIndex(x => x == name) == -1)
        {
            Console.WriteLine($"{name} is not in the list!");
        }
        else
        {
            guestList.Remove(name);
        }
    }
}
