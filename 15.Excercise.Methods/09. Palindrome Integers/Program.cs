using System;

internal class Program
{
    static void Main()
    {
        string numStr;

        while ((numStr = Console.ReadLine()) != "END")
        {
            Console.WriteLine(IsPalindrome(numStr));
        }
    }

    public static bool IsPalindrome(string input)
    {
        string first = input.Substring(0, input.Length / 2);
        char[] arr = input.ToCharArray();

        Array.Reverse(arr);

        string temp = new string(arr);
        string second = temp.Substring(0, temp.Length / 2);

        return first.Equals(second);
    }
}
