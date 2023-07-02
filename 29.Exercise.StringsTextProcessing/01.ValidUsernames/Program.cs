internal class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] usernames = input.Split(", ");

        foreach (string username in usernames)
        {
            if (username.Length < 3 || username.Length > 16)
            {
                continue;
            }

            bool isValidName = username.All(character => char.IsLetterOrDigit(character) || character == '-' || character == '_');

            if (isValidName)
            {
                Console.WriteLine(username);
            }
        }
    }
}
