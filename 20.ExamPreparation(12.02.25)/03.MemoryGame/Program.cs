/*
10 20 30 40 50

5 2 3 4 -10 30 40 50 20 50 60 60 51

1

-1 -2 -3 -4 -5 -6
*/

class Program
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();

        double average;
        double sum = 0;
        for (int i = 0; i < numbers.Count; i++)
        {
            sum += numbers[i];
        }

        average = sum / numbers.Count;

        List<int> topNumbers = new List<int>();

        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] > average)
            {
                topNumbers.Add(numbers[i]);
            }
        }

        topNumbers.Sort();
        topNumbers.Reverse();

        if (topNumbers.Count == 0)
        {
            Console.WriteLine("No");
        }
        else
        {
            int count = Math.Min(5, topNumbers.Count);
            for (int i = 0; i < count; i++)
            {
                Console.Write($"{topNumbers[i]} ");
            }
        }
    }

    // Bonus
    public void PrintTopFiveNumbers(List<int> numbers)
    {
        double average = numbers.Average();
        List<int> top = numbers.FindAll(number => number > average)
            .OrderByDescending(number => number)
            .Take(5)
            .ToList();

        Console.WriteLine(top.Count == 0 ? "No" : string.Join(" ", top));
    }
}
