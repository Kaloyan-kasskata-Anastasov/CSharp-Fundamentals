internal class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] strings = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        decimal totalSum = 0;

        foreach (string str in strings)
        {
            char letterBefore = str[0];
            char letterAfter = str[str.Length - 1];
            ulong number = ulong.Parse(str.Substring(1, str.Length - 2));

            ulong position;
            decimal result = 0;
            if (char.IsUpper(letterBefore))
            {
                position = (ulong)(letterBefore - 'A' + 1);
                result = number / (decimal)position;
            }
            else if (char.IsLower(letterBefore))
            {
                position = (ulong)(letterBefore - 'a' + 1);
                result = number * position;
            }

            if (char.IsUpper(letterAfter))
            {
                position = (ulong)(letterAfter - 'A' + 1);
                result -= position;
            }
            else if (char.IsLower(letterAfter))
            {
                position = (ulong)(letterAfter - 'a' + 1);
                result += position;
            }

            totalSum += result;
        }

        Console.WriteLine($"{totalSum:F2}");
    }
}
