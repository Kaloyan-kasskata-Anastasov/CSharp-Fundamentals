using System;

/*
10
20
3
3
*/

internal class Program
{
    static void Main(string[] args)
    {
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());
        int third = int.Parse(Console.ReadLine());
        int forth = int.Parse(Console.ReadLine());

        int add = first + second;
        int devide = add / third;
        int multiply = devide * forth;

        Console.WriteLine(multiply);
    }
}
