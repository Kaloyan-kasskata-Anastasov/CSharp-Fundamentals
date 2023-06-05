/*
20 12 4 319 21 31234 2 41 23 4
Insert 50 2
Insert 50 5
Delete 4
end
*/

internal class Program
{
    static void Main()
    {
        List<int> list = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();

        string commands;
        while ((commands = Console.ReadLine()) != "end")
        {
            string[] arguments = commands.Split();
            int index;

            switch (arguments[0])
            {
                case "Insert":
                    int item = int.Parse(arguments[1]);
                    index = int.Parse(arguments[2]);
                    list.Insert(index, item);
                    break;
                case "Delete":
                    item = int.Parse(arguments[1]);
                    list.Remove(item);
                    break;
            }
        }

        Console.WriteLine(string.Join(" ", list));
    }
}
