/*
1.05.2016
15.05.2016

1.5.2016
2.5.2016

15.5.2020
10.5.2020

22.2.2020
1.3.2020

*/

using System.Globalization;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        // Correct date format with uppercase 'MM'
        DateTime startDate = DateTime.ParseExact(Console.ReadLine(),
            "d.M.yyyy", 
            CultureInfo.InvariantCulture);
        DateTime endDate = DateTime.ParseExact(Console.ReadLine(),
            "d.M.yyyy", 
            CultureInfo.InvariantCulture);

        // Initialize holiday count
        int holidaysCount = 0;

        // Use date <= endDate and correct date increment
        for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
        {
            // Check if the day is Saturday or Sunday
            if (date.DayOfWeek == DayOfWeek.Saturday ||
                date.DayOfWeek == DayOfWeek.Sunday)
            {
                 holidaysCount++;
            }
        }

        Console.WriteLine(holidaysCount);
    }
}
