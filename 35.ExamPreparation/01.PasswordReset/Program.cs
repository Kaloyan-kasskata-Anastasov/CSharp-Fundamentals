using System.Text;
/*
Siiceercaroetavm!:?:ahsott.:i:nstupmomceqr
TakeOdd
Cut 15 3
Substitute :: -
Substitute | ^
Done
*/
internal class Program
{
    static void Main()
    {
        StringBuilder password = new StringBuilder(Console.ReadLine());
        string input;

        string[] arguments;
        while ((input = Console.ReadLine()) != "Done")
        {
            arguments = input.Split();

            switch (arguments[0])
            {
                case "TakeOdd":
                    password = TakeOdd(password);
                    break;
                case "Cut":
                    int startIndex = int.Parse(arguments[1]);
                    int length = int.Parse(arguments[2]);
                    password = Cut(password, startIndex, length);
                    break;
                case "Substitute":
                    string oldSymbols = arguments[1];
                    string newSymbols = arguments[2];
                    password = Substitute(password, oldSymbols, newSymbols);
                    break;
            }
        }

        Console.WriteLine($"Your password is: {password}");
    }

    private static StringBuilder Substitute(StringBuilder password, string oldSymbols, string newSymbols)
    {
        if (password.ToString().Contains(oldSymbols))
        {
            password = password.Replace(oldSymbols, newSymbols);
            Console.WriteLine(password);
        }
        else
        {
            Console.WriteLine("Nothing to replace!");
        }

        return password;
    }

    private static StringBuilder Cut(StringBuilder password, int startIndex, int length)
    {
        password = password.Remove(startIndex, length);
        Console.WriteLine(password);
        return password;
    }

    private static StringBuilder TakeOdd(StringBuilder password)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 1; i < password.Length; i += 2)
        {
            sb.Append(password[i]);
        }

        password = sb;
        Console.WriteLine(password);
        return password;
    }
}
