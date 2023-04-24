using System;

/*
100
2
1.0
2.0
3.0

100
42
12.0
4.0
3.0
*/
internal class Program
{
    static void Main(string[] args)
    {
        double moneyAmount = double.Parse(Console.ReadLine());
        int studentsCount = int.Parse(Console.ReadLine());
        double saberPrice = double.Parse(Console.ReadLine());
        double robePrice = double.Parse(Console.ReadLine());
        double beltPrice = double.Parse(Console.ReadLine());

        double percent = (double)studentsCount * 10 / 100;
        double allSabers = studentsCount + Math.Ceiling(percent);
        double sabers = saberPrice * allSabers;

        double robes = robePrice * studentsCount;

        double beltsDiss = studentsCount - Math.Ceiling((double)(studentsCount / 6));
        double belts = beltPrice * beltsDiss;

        double total = sabers + robes + belts;
        //Console.WriteLine($"Total: {total}, Money: {moneyAmount}");
        Console.WriteLine(total <= moneyAmount ?
            $"The money is enough - it would cost {total:F2}lv.":
            $"John will need {(total - moneyAmount):F2}lv more.");
    }
}
