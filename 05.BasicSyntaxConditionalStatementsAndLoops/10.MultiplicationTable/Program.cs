/*
5
2

*/

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{number} X {i} = {number * i}");
        }
    }
}
