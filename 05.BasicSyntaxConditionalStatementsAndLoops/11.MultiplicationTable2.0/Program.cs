/*
5
1

2
5

2
14

*/
class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int multiplier = int.Parse(Console.ReadLine());

        if (multiplier <= 10)
        {
            for (int i = multiplier; i <= 10; i++)
            {
                int product = number * i;
                Console.WriteLine($"{number} X {i} = {product}");
            }
        }
        else
        {
            int product = number * multiplier;
            Console.WriteLine($"{number} X {multiplier} = {product}");
        }
    }
}
