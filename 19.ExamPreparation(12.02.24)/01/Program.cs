/*
5
40
100
*/

class Program
{
    static void Main()
    {
        int days = int.Parse(Console.ReadLine());
        int daily = int.Parse(Console.ReadLine());
        double expected = double.Parse(Console.ReadLine());

        double total = 0;

        for (int i = 1; i <= days; i++)
        {
            total += (double)daily;

            if (i % 3 == 0)
            {
                total += daily * 0.5;
            }

            if (i % 5 == 0)
            {
                total *= 0.7;
            }
        }

        if (expected <= total)
        {
            Console.WriteLine($"Ahoy! {total:f2} plunder gained.");
        }
        else
        {
            Console.WriteLine($"Collected only {total / expected * 100:f2}% of the plunder.");
        }
    }
}
