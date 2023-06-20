class Company
{
    public Company(string name)
    {
        Name = name;
        EmployeeIds = new List<string>();
    }

    public string Name { get; set; }

    public List<string> EmployeeIds { get; set; }

    public override string ToString()
    {
        string result = $"{Name}\n";

        for (int i = 0; i < EmployeeIds.Count; i++)
        {
            result += $"-- {EmployeeIds[i]}\n";
        }

        return result.Trim();
    }

    public void AddEmployee(string employeeId)
    {
        if (!EmployeeIds.Contains(employeeId))
        {
            EmployeeIds.Add(employeeId);
        }
    }
}

internal class Program
{
    static void Main()
    {
        Dictionary<string, Company> companies = new Dictionary<string, Company>();

        string command;
        while ((command = Console.ReadLine()) != "End")
        {
            string[] arguments = command.Split(" -> ");

            string companyName = arguments[0];
            string employeeId = arguments[1];

            if (!companies.ContainsKey(companyName))
            {
                Company company = new Company(companyName);
                companies.Add(companyName, company);
            }

            companies[companyName].AddEmployee(employeeId);
        }

        foreach (KeyValuePair<string, Company> pair in companies)
        {
            Console.WriteLine(pair.Value);
        }
    }
}
