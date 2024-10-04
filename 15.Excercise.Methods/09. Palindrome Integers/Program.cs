/*9
123
323
421
121
END
*/

using System;

class Program
{
    static void Main()
    {
        string numberAsString;
        while ((numberAsString = Console.ReadLine()) != "END")
        {
            Console.WriteLine(IsPalindrome(numberAsString));
        }
    }

    static bool IsPalindrome(string palindromeString)
    {
        string reversedString = Reverse(palindromeString);
        return palindromeString == reversedString;
    }

    static string Reverse(string stringToReverse)
    {
        char[] arr = stringToReverse.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }
}
