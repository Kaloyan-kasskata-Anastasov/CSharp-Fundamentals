/*
23 -2 321 87 42 90 -123
swap 1 3
swap 3 6
swap 1 0
multiply 1 2
multiply 2 1
decrease
end
*/

internal class Program
{
    static void Main()
    {
        List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

        string command;
        while ((command = Console.ReadLine()) != "end")
        {
            string[] arguments = command.Split();
            switch (arguments[0])
            {
                case "swap":
                    list = Swap(list, int.Parse(arguments[1]), int.Parse(arguments[2]));
                    break;
                case "multiply":
                    list = Miltiply(list, int.Parse(arguments[1]), int.Parse(arguments[2]));
                    break;
                case "decrease":
                    list = Decrease(list);
                    break;
            }
        }

        Console.WriteLine(string.Join(", ", list));
    }

    private static List<int> Swap(List<int> list, int index1, int index2)
    {
        if (IndexInBounds(list.Count, index1) && IndexInBounds(list.Count, index2))
        {
            int temp = list[index1];
            list[index1] = list[index2];
            list[index2] = temp;
        }

        return list;
    }

    private static List<int> Miltiply(List<int> list, int index1, int index2)
    {
        if (IndexInBounds(list.Count, index1) && IndexInBounds(list.Count, index2))
        {
            list[index1] *= list[index2];
        }

        return list;
    }

    private static List<int> Decrease(List<int> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            list[i]--;
        }

        return list;
    }

    private static bool IndexInBounds(int count, int index1)
    {
        return index1 >= 0 && index1 < count;
    }
}