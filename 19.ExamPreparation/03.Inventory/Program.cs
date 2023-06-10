/*
Iron, Wood, Sword
Collect - Gold
Drop - Wood
Craft!
*/
using System.ComponentModel.Design;

internal class Program
{
    static void Main()
    {
        List<string> items = Console.ReadLine()
            .Split(", ", StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        string command;
        while ((command = Console.ReadLine()) != "Craft!")
        {
            string[] arguments = command.Split(" - ", StringSplitOptions.RemoveEmptyEntries);
            switch (arguments[0])
            {
                case "Collect":
                    items = CollectItem(items, arguments[1]);
                    break;
                case "Drop":
                    items = DropItem(items, arguments[1]);
                    break;
                case "Combine Items":
                    string[] combineItems = arguments[1].Split(":");
                    items = CombineItems(items, combineItems[0], combineItems[1]);
                    break;
                case "Renew":
                    items = RenewItem(items, arguments[1]);
                    break;
            }
        }

        Console.WriteLine(string.Join(", ", items));
    }

    private static List<string> RenewItem(List<string> items, string item)
    {
        int index = items.IndexOf(item);
        if (index >= 0)
        {
            string renewedItem = items[index];
            items.RemoveAt(index);
            CollectItem(items, renewedItem);
        }

        return items;
    }

    private static List<string> CombineItems(List<string> items, string oldItem, string newItem)
    {
        int oldItemIndex = items.IndexOf(oldItem);
        if (oldItemIndex >= 0)
        {
            if (oldItemIndex >= items.Count)
            {
                CollectItem(items, newItem);
            }
            else
            {
                items.Insert(oldItemIndex + 1, newItem);
            }
        }

        return items;
    }

    private static List<string> DropItem(List<string> items, string item)
    {
        if (items.Contains(item))
        {
            items.Remove(item);
        }

        return items;
    }

    static List<string> CollectItem(List<string> items, string item)
    {
        if (!items.Contains(item))
        {
            items.Add(item);
        }

        return items;
    }
}