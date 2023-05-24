using System;

/*
4
1 5
9 10
31 81
41 20
*/

internal class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        bool isFirstSelected = true;
        string[] firstArr = new string[n];
        string[] secondArr = new string[n];

        for (int i = 0; i < n; i++)
        {
            string numbers = Console.ReadLine();
            string[] numbersAsArray = numbers.Split();
            if (isFirstSelected)
            {
                firstArr[i] = numbersAsArray[0];
                secondArr[i] = numbersAsArray[1];
            }
            else
            {
                firstArr[i] = numbersAsArray[1];
                secondArr[i] = numbersAsArray[0];
            }

            isFirstSelected = !isFirstSelected;
        }

        Console.WriteLine(string.Join(" ", firstArr));
        Console.WriteLine(string.Join(" ", secondArr));
    }
}
