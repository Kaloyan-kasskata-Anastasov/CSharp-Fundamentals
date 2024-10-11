/*
1 2 3 4 5 5 5 6
Delete 5
Insert 10 1
Delete 5
end

20 12 4 319 21 31234 2 41 23 4
Insert 50 2
Insert 50 5
Delete 4
end
*/

using System.Collections.Generic;

internal class Program
{
    static void Main()
    {
        List<int> list = Console.ReadLine()
            .Split()
            .Select(e => int.Parse(e))
            .OrderByDescending(e => e)
            .ToList();

        string input;
        while ((input = Console.ReadLine()) != "end")
        {
            string[] arguments = input.Split();
            int element;

            switch (arguments[0])
            {
                case "Insert":
                {
                    element = int.Parse(arguments[1]);
                    int position = int.Parse(arguments[2]);
                    list.Insert(position, element);
                    break;
                }
                case "Delete":
                    element = int.Parse(arguments[1]);
                    for (int i = list.Count - 1; i >= 0; i--) 
                    {
                        if (list[i] == element)
                        {
                            list.RemoveAt(i);
                        }
                    }

                    break;
            }
        }

        Console.WriteLine(string.Join(" ", list));
    }
}
