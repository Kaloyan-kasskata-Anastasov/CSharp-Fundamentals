using Console = System.Console;

internal class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(" ");

        int result = Sum(input[0], input[1]);
        Console.WriteLine(result);
    }

    private static int Sum(string first, string second)
    {
        int sum = 0;
        int length = Math.Max(first.Length, second.Length);

        for (int i = 0; i < length; i++)
        {
            if (i < first.Length && i < second.Length)
            {
                sum += first[i] * second[i];
            }
            else if (i < first.Length)
            {
                sum += first[i];
            }
            else if (i < second.Length)
            {
                sum += second[i];
            }
        }

        return sum;
    }
}
