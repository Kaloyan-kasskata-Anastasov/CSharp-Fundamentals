using System;

/*
Acer
login
go
let me in
recA

sunny
rainy
cloudy
sunny
not sunny

*/

internal class Program
{
    static void Main(string[] args)
    {
        string username = Console.ReadLine();

        char[] stringArray = username.ToCharArray();
        Array.Reverse(stringArray);
        string password = new string(stringArray);
        int attempts = 4;

        while (attempts > 0)
        {
            attempts -= 1;
            string typedPass = Console.ReadLine();
            if (password == typedPass)
            {
                Console.WriteLine($"User {username} logged in.");
                break;
            }
            else
            {
                if (attempts == 0)
                {
                    Console.WriteLine($"User {username} blocked!");
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
            }
        }
    }
}
