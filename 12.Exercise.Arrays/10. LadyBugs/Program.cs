using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Fill the field (array) with ladybugs
        int fieldLength = int.Parse(Console.ReadLine());
        int[] bugPlaces = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        int[] field = new int[fieldLength];

        for (int i = 0; i < bugPlaces.Length; i++)
        {
            int bugIndex = bugPlaces[i];
            if (bugIndex >= 0 && bugIndex <= field.Length - 1)
            {
                field[bugIndex] = 1;
            }
        }

        // Get the command lines. "end" stops the while loop
        string command;
        while ((command = Console.ReadLine()) != "end")
        {
            // Parse the arguments
            string[] arguments = command.Split();
            int bugIndex = int.Parse(arguments[0]);
            string direction = arguments[1];
            int distance = int.Parse(arguments[2]);

            // Move the bug
            if (bugIndex >= 0 && bugIndex <= field.Length - 1 && field[bugIndex] == 1)
            {
                field[bugIndex] = 0;
                int landIndex;
                switch (direction)
                {
                    case "right":
                    {
                        landIndex = bugIndex + distance;
                        // Check if the land position is within the field's bounds AND if the cell is not empty
                        while (landIndex >= 0 && landIndex <= field.Length - 1 && field[landIndex] == 1)
                        {
                            landIndex += distance;
                        }

                        // Check if the land position is within the field's bounds
                        if (landIndex >= 0 && landIndex <= field.Length - 1)
                        {
                            field[landIndex] = 1;
                        }

                        break;
                    }
                    case "left":
                    {
                        landIndex = bugIndex - distance;
                        while (landIndex >= 0 && landIndex <= field.Length - 1 && field[landIndex] == 1)
                        {
                            landIndex -= distance;
                        }

                        if (landIndex >= 0 && landIndex <= field.Length - 1)
                        {
                            field[landIndex] = 1;
                        }

                        break;
                    }
                }
            }
        }

        // Print the state of the field
        Console.WriteLine(string.Join(" ", field));
    }
}
