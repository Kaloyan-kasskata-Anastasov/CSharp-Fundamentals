internal class Program
{
    static void Main()
    {
        int studentsCount = int.Parse(Console.ReadLine());
        int lecturesCount = int.Parse(Console.ReadLine());
        int additionalBonus = int.Parse(Console.ReadLine());

        int maxAttendances = 0;
        double maxBonus = 0;

        for (int i = 0; i < studentsCount; i++)
        {
            int attendances = int.Parse(Console.ReadLine());
            double bonus = Math.Ceiling((double)attendances / lecturesCount * (5 + additionalBonus));

            if (bonus > maxBonus)
            {
                maxBonus = bonus;
                maxAttendances = attendances;
            }
        }

        Console.WriteLine($"Max Bonus: {maxBonus}.");
        Console.WriteLine($"The student has attended {maxAttendances} lectures.");
    }
}