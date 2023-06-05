/*
1 2 2 4 2 2 2 9
4 2
*/

internal class Program
{
    static void Main()
    {
        List<int> list = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();

        List<int> bomb = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();

        list = Explode(list, bomb);

        Console.WriteLine(Sum(list));
    }

    private static int Sum(List<int> list)
    {
        int sum = 0;
        foreach (int item in list)
        {
            sum += item;
        }

        return sum;
    }

    private static List<int> Explode(List<int> list, List<int> bomb)
    {
        int number = bomb[0];
        int power = bomb[1];

        while (list.Contains(number))
        {
            int index = list.IndexOf(number);

            int leftIndex = Math.Max(0, index - power);
            int rightIndex = Math.Min(list.Count - 1, index + power);

            int range = rightIndex - leftIndex + 1;
            list.RemoveRange(leftIndex, range);
        }

        return list;
    }
}
