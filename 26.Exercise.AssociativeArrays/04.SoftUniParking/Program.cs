/*
5
register John CS1234JS
register George JAVA123S
register Andy AB4142CD
register Jesica VR1223EE
unregister Andy
*/

internal class User
{
    public User(string userName, string licensePlateNumber)
    {
        UserName = userName;
        LicensePlateNumber = licensePlateNumber;
    }

    public string UserName { get; set; }

    public string LicensePlateNumber { get; set; }

    public override string ToString()
    {
        return $"{UserName} => {LicensePlateNumber}";
    }
}

internal class Program
{
    static void Main()
    {
        Dictionary<string, User> users = new Dictionary<string, User>();

        int commandsCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < commandsCount; i++)
        {
            string[] arguments = Console.ReadLine().Split();
            string command = arguments[0];
            string username = arguments[1];

            switch (command)
            {
                case "register":
                    string licensePlateNumber = arguments[2];
                    User user = new User(username, licensePlateNumber);
                    if (!users.ContainsKey(username))
                    {
                        users.Add(username, user);
                        Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
                    }

                    break;
                case "unregister":
                    if (users.ContainsKey(username))
                    {
                        users.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }

                    break;
            }
        }

        foreach (KeyValuePair<string, User> pair in users)
        {
            Console.WriteLine(pair.Value);
        }
    }
}
