using System;

/*
51 47 32 61 21
2
*/

internal class Program
{
    static void Main()
    {
        string[] array = Console.ReadLine().Split();
        int rotations = int.Parse(Console.ReadLine());

        for (int i = 0; i < rotations; i++)
        {
            string firstElement = array[0];

            for (int j = 0; j < array.Length - 1; j++)
            {
                array[j] = array[j + 1];
            }

            array[array.Length - 1] = firstElement;
        }

        Console.WriteLine(string.Join(" ", array));
    }
}
