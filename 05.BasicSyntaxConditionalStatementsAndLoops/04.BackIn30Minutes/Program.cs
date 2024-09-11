/*
1
46

0
01

23
59

11
08

11
32

*/

class Program
{
    static void Main()
    {
        int hours = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());

        minutes += 30;

        if (minutes >= 60)
        {
            minutes -= 60;
            hours += 1;
        }

        if (hours >= 24)
        {
            hours -= 24;
        }

        Console.WriteLine($"{hours}:{minutes:D2}");
    }
}
