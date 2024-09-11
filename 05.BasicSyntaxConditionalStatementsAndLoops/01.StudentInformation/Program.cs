/*
John
15
5.40

Steve
16
2.50

Marry
12
6.00

*/

internal class Program
{
    static void Main()
    {
        string studentName = Console.ReadLine();
        int studentAge = int.Parse(Console.ReadLine());
        double studentGrade = double.Parse(Console.ReadLine());

        Console.WriteLine($"Name: {studentName}, Age: {studentAge}, Grade: {studentGrade:F2}");
    }
}
