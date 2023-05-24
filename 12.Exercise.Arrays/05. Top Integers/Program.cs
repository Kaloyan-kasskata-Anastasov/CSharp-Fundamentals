using System;

/*
1 4 3 2
*/
internal class Program
{
    static void Main()
    {
        // INPUT
        string[] inputArr = Console.ReadLine().Split();
        int[] numbers = new int[inputArr.Length];

        for (int i = 0; i < inputArr.Length; i++)
        {
            numbers[i] = int.Parse(inputArr[i]);
        }

        // SOLUTION
        for (int i = 0; i < numbers.Length; i++)
        {
            bool isTop = true;
            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[i] <= numbers[j])
                {
                    isTop = false;
                    break;
                }
            }

            if (isTop)
            {
                // OUTPUT
                Console.Write($"{numbers[i]} ");
            }
        }
    }
}
