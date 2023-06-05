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

using System;

internal class Program
{
    static void Main()
    {
        List<int> list = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();

        string commands;
        while ((commands = Console.ReadLine()) != "End")
        {
            string[] arguments = commands.Split();
            switch (arguments[0])
            {
                case "Add":
                    list.Add(int.Parse(arguments[1]));
                    break;
                case "Insert":
                    int item = int.Parse(arguments[1]);
                    int insertIndex = int.Parse(arguments[2]);
                    if (IsNotValidIndex(insertIndex, list.Count))
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    list.Insert(insertIndex, item);
                    break;
                case "Remove":
                    int removeIndex = int.Parse(arguments[1]);
                    if (IsNotValidIndex(removeIndex, list.Count))
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    list.RemoveAt(removeIndex);

                    break;
                case "Shift":
                    string direction = arguments[1];
                    int count = int.Parse(arguments[2]);
                    Shift(list, direction, count);
                    break;
            }
        }

        Console.WriteLine(string.Join(" ", list));
    }

    private static bool IsNotValidIndex(int index, int count)
    {
        return index < 0 || index >= count;
    }

    private static void Shift(List<int> list, string direction, int count)
    {
        count %= list.Count;

        if (direction == "left")
        {
            List<int> shiftedPart = list.GetRange(0, count);
            list.RemoveRange(0, count);
            list.InsertRange(list.Count, shiftedPart);
        }
        else if (direction == "right")
        {
            List<int> shiftedPart = list.GetRange(list.Count - count, count);
            list.RemoveRange(list.Count - count, count);
            list.InsertRange(0, shiftedPart);
        }
    }
}
