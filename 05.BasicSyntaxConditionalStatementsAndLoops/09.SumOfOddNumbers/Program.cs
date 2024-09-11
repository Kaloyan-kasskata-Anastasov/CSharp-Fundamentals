/*
5

3

*/

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int oddNumber = 1;

        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(oddNumber);
            sum += oddNumber;
            oddNumber += 2;
        }

        Console.WriteLine("Sum: " + sum);
    }
}
