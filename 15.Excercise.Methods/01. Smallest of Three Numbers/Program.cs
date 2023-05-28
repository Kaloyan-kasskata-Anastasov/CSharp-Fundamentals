internal class Program
{
/*
2
5
3
*/

    static void Main(string[] args)
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int thirdNumber = int.Parse(Console.ReadLine());

        int minNumber = GetMinNumber(firstNumber, secondNumber);
        minNumber = GetMinNumber(minNumber, thirdNumber);

        Console.WriteLine(minNumber);
    }

    private static int GetMinNumber(int a, int b)
    {
        if (a < b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }
}
