/*
Data Types, Objects, Lists
Add:Databases
Insert:Arrays:0
Remove:Lists
course start

Arrays, Lists, Methods
Swap:Arrays:Methods
Exercise:Databases
Swap:Lists:Databases
Insert:Arrays:0
course start
*/

internal class Program
{
    static void Main()
    {
        List<string> schedule = Console.ReadLine().Split(", ").ToList();

        string commands;
        while ((commands = Console.ReadLine()) != "course start")
        {
            string[] arguments = commands.Split(":");
            switch (arguments[0])
            {
                case "Add":
                    schedule = AddTitle(schedule, arguments[1]);
                    break;
                case "Insert":
                    schedule = InsertTitle(schedule, arguments[1], int.Parse(arguments[2]));
                    break;
                case "Remove":
                    schedule = RemoveTitle(schedule, arguments[1]);
                    break;
                case "Swap":
                    schedule = SwapTitles(schedule, arguments[1], arguments[2]);
                    break;
                case "Exercise":
                    schedule = InsertExercise(schedule, arguments[1]);
                    break;
            }
        }

        Console.WriteLine(PrintSchedule(schedule));
    }

    private static List<string> AddTitle(List<string> schedule, string title)
    {
        if (!schedule.Contains(title))
        {
            schedule.Add(title);
        }

        return schedule;
    }
    
    private static List<string> RemoveTitle(List<string> schedule, string title)
    {
        schedule.Remove(title);

        string exerciseTitle = $"{title}-Exercise";
        int index = schedule.FindIndex(x => x == exerciseTitle);
        if (index >= 0)
        {
            RemoveTitle(schedule, exerciseTitle);
        }

        return schedule;
    }

    private static List<string> SwapTitles(List<string> schedule, string firstTitle, string secondTitle)
    {
        if (schedule.Contains(firstTitle) && schedule.Contains(secondTitle))
        {
            int firstIndex = schedule.FindIndex(x => x == firstTitle);
            int secondIndex = schedule.FindIndex(x => x == secondTitle);

            string temp = schedule[firstIndex];
            schedule[firstIndex] = schedule[secondIndex];
            schedule[secondIndex] = temp;

            schedule = SwapExercise(schedule, firstTitle, secondIndex);
            schedule = SwapExercise(schedule, secondTitle, firstIndex);
        }

        return schedule;
    }

    private static List<string> SwapExercise(List<string> schedule, string title, int titleIndex)
    {
        string exerciseTitle = $"{title}-Exercise";
        int index = schedule.FindIndex(x => x == exerciseTitle);
        if (index >= 0)
        {
            RemoveTitle(schedule, exerciseTitle);
            InsertTitle(schedule, exerciseTitle, titleIndex + 1);
        }

        return schedule;
    }

    private static List<string> InsertTitle(List<string> schedule, string title, int index)
    {
        if (!schedule.Contains(title))
        {
            schedule.Insert(index, title);
        }

        return schedule;
    }

    private static List<string> InsertExercise(List<string> schedule, string title)
    {
        string exerciseTitle = $"{title}-Exercise";
        if (!schedule.Contains(title))
        {
            AddTitle(schedule, title);
        }

        if (schedule.Contains(title) && !schedule.Contains(exerciseTitle))
        {
            int index = schedule.FindIndex(x => x == title);
            InsertTitle(schedule, exerciseTitle, index + 1);
        }

        return schedule;
    }

    private static string PrintSchedule(List<string> schedule)
    {
        string result = "";
        for (int i = 0; i < schedule.Count; i++)
        {
            Console.WriteLine($"{i + 1}.{schedule[i]}");
        }

        return result;
    }
}
